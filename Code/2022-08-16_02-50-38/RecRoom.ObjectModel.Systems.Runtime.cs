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
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class FELJJHKIKLN<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class DMLLFMOFEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::FELJJHKIKLN<T> GNOMDOCHNAF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] OLKELAGMDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public DMLLFMOFEEI(global::FELJJHKIKLN<T> GNOMDOCHNAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BCLFGHAJKEL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::FELJJHKIKLN<T> <>4__this;

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
		public BCLFGHAJKEL(int <>1__state)
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
	private const int AGELCMDHGGH = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> LLBKONIGAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int BDGGJLMCAGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T LFAJLOBHMDD
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
	private bool NHGANEKMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FLFNDNGPHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool NHJIADLMPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DBOEJCGBHLO
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
	public int JFMPCJJIJJI
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
	public FELJJHKIKLN(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public FELJJHKIKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void FFCBNOPDCNH(int BAOHKIGDOBF, T IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void OFOMMAGAOIE(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JAKNHMFGHIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void PEHAHILFOCD(NativeArray<T> MPENDCAONOC, int KLKFOFJLECO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::FELJJHKIKLN<>.BCLFGHAJKEL))]
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
	public int OIPMBJNKOEM(T IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool MAHLOMNJIKK(T IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void KEDNPJCIJEA(int LDIKCPKDPKG, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void IPPIMAPIGFK(int LDIKCPKDPKG, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void CJGIOEECMML(int LDIKCPKDPKG, int HMFFBMGNBCG, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int JMCHIIJLNAD(int BAOHKIGDOBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T KCMNDCLKFPB(int BAOHKIGDOBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void GKMGIIJNNLA(int BAOHKIGDOBF, T IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void OCEMLGKKEME(int BAOHKIGDOBF, T IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void GDBNAJFDLGN(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int EDINIOILEPN(int PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int ANNDEJNBIKA(int PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void FMOHPPFNCOO(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void LKAOPOAFJDJ(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T AHIICDHGFCJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T FPCJPPMJDMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void CKNAHLENOOK(int BAOHKIGDOBF, IReadOnlyCollection<T> AIMOGJHOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void KCLMECMMMNA(int BAOHKIGDOBF, int GIJAKNBKDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void OAOMJDAPLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void KMKEHOHIFOJ(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void KDIHKOPGNOP(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void JMENJDMBEAH(int HMFFBMGNBCG, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T GEICBFLDBML()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T KJNAEMHPDCE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[EBHLIKGFBFJ]
public static class GMGDDIMFKHA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x25F1800", Offset = "0x25F0400", VA = "0x1825F1800")]
	static GMGDDIMFKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30B0A40", Offset = "0x30AF640", VA = "0x1830B0A40")]
	public static void HOBKAINGHLD<T>(T HOMNJBLAHAL, ref T DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x25F16A0", Offset = "0x25F02A0", VA = "0x1825F16A0")]
	public static void HOBKAINGHLD(FixedString32 HOMNJBLAHAL, ref string DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x25F1540", Offset = "0x25F0140", VA = "0x1825F1540")]
	public static void HOBKAINGHLD(string HOMNJBLAHAL, ref FixedString32 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25F17B0", Offset = "0x25F03B0", VA = "0x1825F17B0")]
	public static void HOBKAINGHLD(FixedString64 HOMNJBLAHAL, ref string DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25F1710", Offset = "0x25F0310", VA = "0x1825F1710")]
	public static void HOBKAINGHLD(string HOMNJBLAHAL, ref FixedString64 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF6150", Offset = "0x1EF4D50", VA = "0x181EF6150")]
	public static void HOBKAINGHLD(IHDCHPFDJOK HOMNJBLAHAL, ref Vector3 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25F1620", Offset = "0x25F0220", VA = "0x1825F1620")]
	public static void HOBKAINGHLD(Vector3 HOMNJBLAHAL, ref IHDCHPFDJOK DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25F1510", Offset = "0x25F0110", VA = "0x1825F1510")]
	public static void HOBKAINGHLD(DOKAMIJGBGB HOMNJBLAHAL, ref Vector4 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25F1590", Offset = "0x25F0190", VA = "0x1825F1590")]
	public static void HOBKAINGHLD(Vector4 HOMNJBLAHAL, ref DOKAMIJGBGB DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25F1510", Offset = "0x25F0110", VA = "0x1825F1510")]
	public static void HOBKAINGHLD(DOKAMIJGBGB HOMNJBLAHAL, ref Quaternion DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25F1590", Offset = "0x25F0190", VA = "0x1825F1590")]
	public static void HOBKAINGHLD(Quaternion HOMNJBLAHAL, ref DOKAMIJGBGB DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25F15E0", Offset = "0x25F01E0", VA = "0x1825F15E0")]
	public static void HOBKAINGHLD(IHDCHPFDJOK HOMNJBLAHAL, ref float3 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25F1620", Offset = "0x25F0220", VA = "0x1825F1620")]
	public static void HOBKAINGHLD(float3 HOMNJBLAHAL, ref IHDCHPFDJOK DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25F1680", Offset = "0x25F0280", VA = "0x1825F1680")]
	public static void HOBKAINGHLD(DOKAMIJGBGB HOMNJBLAHAL, ref float4 DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25F1590", Offset = "0x25F0190", VA = "0x1825F1590")]
	public static void HOBKAINGHLD(float4 HOMNJBLAHAL, ref DOKAMIJGBGB DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25F1680", Offset = "0x25F0280", VA = "0x1825F1680")]
	public static void HOBKAINGHLD(DOKAMIJGBGB HOMNJBLAHAL, ref quaternion DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25F1780", Offset = "0x25F0380", VA = "0x1825F1780")]
	public static void HOBKAINGHLD(quaternion HOMNJBLAHAL, ref DOKAMIJGBGB DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x25F16D0", Offset = "0x25F02D0", VA = "0x1825F16D0")]
	public static void HOBKAINGHLD(Entity HOMNJBLAHAL, ref KGIIDDFCGIB DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x25F17E0", Offset = "0x25F03E0", VA = "0x1825F17E0")]
	public static void HOBKAINGHLD(KGIIDDFCGIB HOMNJBLAHAL, ref Entity DFCDFHBOIBF, OBMBDPDKGND IMPCIAHGEFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KIBLKIBMNHJ : CDJDJFPMFGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int JAHDCPGLHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILICMPFMPIB IHHHKILKLMA(Entity NNCGIOJNJIH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPBHEDDCOJA(NativeArray<ILICMPFMPIB> PGHOFPMOHFA, NativeArray<GOAEOJFPBIL> IPEPCLOOLAD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPHFDILFPJK(ILICMPFMPIB PEIBOBCLLBF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGBNNIFHMJG(ILICMPFMPIB PEIBOBCLLBF, out Collider DDOMPBPGFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[EFHICEMKHKB]
public class EIJHFNNNCOD : ComponentSystem, GLEEPPGLLOC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LPPHKFGPEPM LDHJEGHECPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AKDHBKEIEHJ GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2278D40", Offset = "0x2277940", VA = "0x182278D40", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public EIJHFNNNCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x25671B0", Offset = "0x2565DB0", VA = "0x1825671B0")]
		public static ObjectModelConfigAsset NOFEBAKFLEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDD4560", Offset = "0xDD3160", VA = "0x180DD4560")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[KHHGHKHGGFN(EOABPLMDMOL.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[KHHGHKHGGFN(EOABPLMDMOL.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int OEGEMGKBDGN = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly PEOJNAGCHAI NLGECAJFNEP;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x256B0E0", Offset = "0x2569CE0", VA = "0x18256B0E0")]
			public static EEDOLIFAKPN KPCFOCDLNGA(int JNJMNLDNIKH)
			{
				return default(EEDOLIFAKPN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x256B270", Offset = "0x2569E70", VA = "0x18256B270")]
			public static int LPJLOOKFMPM(GameObject JPIPKHMPCNE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x256B050", Offset = "0x2569C50", VA = "0x18256B050")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			private static void FBPPJJMLMCP(GDHDBKNKOKH IFPFHNLOHFM, int JNJMNLDNIKH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static IBFJOMHJBJL OMBBCDBECLD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static HENOPHAMODO BEIGDPPEKJK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static IBFJOMHJBJL DEECDDIOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2567780", Offset = "0x2566380", VA = "0x182567780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x25688C0", Offset = "0x25674C0", VA = "0x1825688C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static HENOPHAMODO IEGAFLFABHO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x25685A0", Offset = "0x25671A0", VA = "0x1825685A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2567630", Offset = "0x2566230", VA = "0x182567630")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool FLHKFKBNCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2568800", Offset = "0x2567400", VA = "0x182568800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static AKDHBKEIEHJ GBKMFNDEMBF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x25675C0", Offset = "0x25661C0", VA = "0x1825675C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ODDGBIGFEAO EDKCLGGKJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2567D30", Offset = "0x2566930", VA = "0x182567D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static KMGPAOBKBAH FNHNDIDALAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2568990", Offset = "0x2567590", VA = "0x182568990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ALMILKEKENF FHHJJOHBFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2567E00", Offset = "0x2566A00", VA = "0x182567E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static KJFKLHABFME IKFKPLOGFIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x25684D0", Offset = "0x25670D0", VA = "0x1825684D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool HFAIDDALHOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2567230", Offset = "0x2565E30", VA = "0x182567230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2568020", Offset = "0x2566C20", VA = "0x182568020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool AAIIGLFAPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2568110", Offset = "0x2566D10", VA = "0x182568110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2567560", Offset = "0x2566160", VA = "0x182567560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool OCBOMMPAHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2568170", Offset = "0x2566D70", VA = "0x182568170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2567970", Offset = "0x2566570", VA = "0x182567970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action BKGAEJBPJCB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x25679D0", Offset = "0x25665D0", VA = "0x1825679D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2568700", Offset = "0x2567300", VA = "0x182568700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2567490", Offset = "0x2566090", VA = "0x182567490")]
		public static GDHDBKNKOKH BLAKDJDJKFD(GameObject JPIPKHMPCNE)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2567C40", Offset = "0x2566840", VA = "0x182567C40")]
		public static EEDOLIFAKPN GHJADADNKKE(GameObject JPIPKHMPCNE)
		{
			return default(EEDOLIFAKPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2567ED0", Offset = "0x2566AD0", VA = "0x182567ED0")]
		public static JHMPJMIHIEB IBPFCJGALCD(EEDOLIFAKPN PLIJDIMDLMI)
		{
			return default(JHMPJMIHIEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2567FE0", Offset = "0x2566BE0", VA = "0x182567FE0")]
		public static JHMPJMIHIEB IBPFCJGALCD(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(JHMPJMIHIEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25677E0", Offset = "0x25663E0", VA = "0x1825677E0")]
		public static (ByteString, IDisposable) EKJBCLFLGLG()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2568340", Offset = "0x2566F40", VA = "0x182568340")]
		public static (ByteString, IDisposable) JEBKHPLHFEB(IEnumerable<GDHDBKNKOKH> ODIKFPCELJC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2567AD0", Offset = "0x25666D0", VA = "0x182567AD0")]
		public static bool GDADJCOHDMG(GameObject JPIPKHMPCNE, out EEDOLIFAKPN PLIJDIMDLMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x25681D0", Offset = "0x2566DD0", VA = "0x1825681D0")]
		public static bool JEBJLPBFHDH(GameObject JPIPKHMPCNE, out bool BHOOELOFEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2567370", Offset = "0x2565F70", VA = "0x182567370")]
		private static HENOPHAMODO ALHLAOOMEJP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EJPADBCGJJL
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2279500", Offset = "0x2278100", VA = "0x182279500")]
	public static CICKPBCENCE LGPGOGPHNHB(GameObject JPIPKHMPCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2279320", Offset = "0x2277F20", VA = "0x182279320")]
	public static CICKPBCENCE LGPGOGPHNHB(GameObject JPIPKHMPCNE, EEDOLIFAKPN PLIJDIMDLMI)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, ODJAIBMKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GDHDBKNKOKH GKCHNJEIIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(GDHDBKNKOKH);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x25597F0", Offset = "0x25583F0", VA = "0x1825597F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[KHHGHKHGGFN(EOABPLMDMOL.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, CICKPBCENCE, ODJAIBMKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string GKMCPLKCFMK = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GDHDBKNKOKH NDMJKBJOMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EPPGBGLFGCC DGLKFIPALBO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public GDHDBKNKOKH GKCHNJEIIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A50", Offset = "0x8F4650", VA = "0x1808F5A50", Slot = "11")]
			get
			{
				return default(GDHDBKNKOKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JHMPJMIHIEB HPBAFHAKIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x255A670", Offset = "0x2559270", VA = "0x18255A670", Slot = "4")]
			get
			{
				return default(JHMPJMIHIEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private AKDHBKEIEHJ GBKMFNDEMBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2559CC0", Offset = "0x25588C0", VA = "0x182559CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private KKNBPBMPKBC PMGLCBBMKMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2559D10", Offset = "0x2558910", VA = "0x182559D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EPPGBGLFGCC DADPHIHEBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6350F0", Offset = "0x633CF0", VA = "0x1806350F0", Slot = "5")]
			get
			{
				return default(EPPGBGLFGCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool NIDNKHIEMEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E70", Offset = "0x7D4A70", VA = "0x1807D5E70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7D5EF0", Offset = "0x7D4AF0", VA = "0x1807D5EF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> CNELFMFBFKH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x255A5D0", Offset = "0x25591D0", VA = "0x18255A5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x255A6A0", Offset = "0x25592A0", VA = "0x18255A6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2559BF0", Offset = "0x25587F0", VA = "0x182559BF0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x255A300", Offset = "0x2558F00", VA = "0x18255A300", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2559F60", Offset = "0x2558B60", VA = "0x182559F60", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x255A270", Offset = "0x2558E70", VA = "0x18255A270", Slot = "8")]
		public void OnEmbody(DJFBKNFJCKG DFJHEIJOIKC, GDHDBKNKOKH NDMJKBJOMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x255A2F0", Offset = "0x2558EF0", VA = "0x18255A2F0", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x255A020", Offset = "0x2558C20", VA = "0x18255A020", Slot = "10")]
		public void OnDisembody(bool KJFKCABBCIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2559E50", Offset = "0x2558A50", VA = "0x182559E50")]
		private void MDJLDHJFHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2559D90", Offset = "0x2558990", VA = "0x182559D90")]
		private void LHKCKMMAOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x255A400", Offset = "0x2559000", VA = "0x18255A400")]
		private void PPFCFFHDDCM(bool OPMLDICBKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1290420", Offset = "0x128F020", VA = "0x181290420", Slot = "7")]
		private GameObject GEBACCGILEK()
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
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[KHHGHKHGGFN(EOABPLMDMOL.Registration)]
	public sealed class TransformEntity : MonoBehaviour, ODJAIBMKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private GGPLMDHKFKM prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private GDHDBKNKOKH IFPFHNLOHFM;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public GGPLMDHKFKM CMEPEBDEPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
			get
			{
				return default(GGPLMDHKFKM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x736910", Offset = "0x735510", VA = "0x180736910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public GDHDBKNKOKH GKCHNJEIIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A50", Offset = "0x8F4650", VA = "0x1808F5A50", Slot = "4")]
			get
			{
				return default(GDHDBKNKOKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity CMGIPAKOGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal ALMILKEKENF FHHJJOHBFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal KKNBPBMPKBC JHPPONDDLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5764370", Offset = "0x5762F70", VA = "0x185764370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57640F0", Offset = "0x5762CF0", VA = "0x1857640F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x57643E0", Offset = "0x5762FE0", VA = "0x1857643E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5764100", Offset = "0x5762D00", VA = "0x185764100")]
		internal void CMEOLNMPNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x57643E0", Offset = "0x5762FE0", VA = "0x1857643E0")]
		internal void FNAPKEMHLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57644E0", Offset = "0x57630E0", VA = "0x1857644E0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5764600", Offset = "0x5763200", VA = "0x185764600")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum GKDPMMMHHBP
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
[PCJLLMMMFMG(typeof(HENOPHAMODO), new string[] { })]
public class GPGAOJKBHLL : HENOPHAMODO, IDisposable, IMMOFHNOPFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LPPHKFGPEPM LDHJEGHECPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CAOPEEFBAOK GMMOCAFFECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public AKDHBKEIEHJ GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HFAIDDALHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x25F2560", Offset = "0x25F1160", VA = "0x1825F2560", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x25F29D0", Offset = "0x25F15D0", VA = "0x1825F29D0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FBJFFGFJCFH ICEBJPFOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x60D720", Offset = "0x60C320", VA = "0x18060D720", Slot = "15")]
		get
		{
			return default(FBJFFGFJCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x25F2E50", Offset = "0x25F1A50", VA = "0x1825F2E50")]
	public static GPGAOJKBHLL NEKFKHFNPIG(IEMJHGKEHDA NBFNONBMPHP, GKDPMMMHHBP PELMCJBBFEG = GKDPMMMHHBP.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25F3330", Offset = "0x25F1F30", VA = "0x1825F3330")]
	private static void OPBFLCGDDKM(IEMJHGKEHDA NBFNONBMPHP, GKDPMMMHHBP PELMCJBBFEG = GKDPMMMHHBP.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x25F2FC0", Offset = "0x25F1BC0", VA = "0x1825F2FC0")]
	private static void NJKJDJAOJEO(IEMJHGKEHDA NBFNONBMPHP, GKDPMMMHHBP PELMCJBBFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25F2820", Offset = "0x25F1420", VA = "0x1825F2820")]
	private static string[] FKLHMKNPBJA(GKDPMMMHHBP PELMCJBBFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x25F2AA0", Offset = "0x25F16A0", VA = "0x1825F2AA0")]
	private static bool IGNJKKJFFDN(GKDPMMMHHBP PELMCJBBFEG, out string[] ICHHKAKHDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25F2CB0", Offset = "0x25F18B0", VA = "0x1825F2CB0")]
	private static void LNGGPBFCHMP(IEMJHGKEHDA NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F3250", Offset = "0x25F1E50", VA = "0x1825F3250", Slot = "16")]
	public void OBNALPGBIFA(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x109DB60", Offset = "0x109C760", VA = "0x18109DB60")]
	private void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F25C0", Offset = "0x25F11C0", VA = "0x1825F25C0")]
	private void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x25F2640", Offset = "0x25F1240", VA = "0x1825F2640", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x25F2D70", Offset = "0x25F1970", VA = "0x1825F2D70", Slot = "19")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x25F2C40", Offset = "0x25F1840", VA = "0x1825F2C40", Slot = "9")]
	public void KODDGKBMAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "10")]
	public void KOMOEDDPHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25F2DE0", Offset = "0x25F19E0", VA = "0x1825F2DE0", Slot = "11")]
	public void NBDPJEEAIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x25F3420", Offset = "0x25F2020", VA = "0x1825F3420", Slot = "7")]
	public void OPELNPIHKCP(ByteString CEECNJJKNFO, HGCLGNGAHLP PELMCJBBFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25F2BD0", Offset = "0x25F17D0", VA = "0x1825F2BD0", Slot = "8")]
	public void IHBAIKPFLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x25F27B0", Offset = "0x25F13B0", VA = "0x1825F27B0", Slot = "12")]
	public void FABODALPJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x25F2960", Offset = "0x25F1560", VA = "0x1825F2960", Slot = "13")]
	public void GIEKIMKNNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25F26D0", Offset = "0x25F12D0", VA = "0x1825F26D0", Slot = "20")]
	public ByteString EKJBCLFLGLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0")]
	private static bool NKPFEIOIBHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public GPGAOJKBHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MHAHDECECMA
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2560360", Offset = "0x255EF60", VA = "0x182560360")]
	public static JHMPJMIHIEB LOHNFJICDGO(this HENOPHAMODO BEIGDPPEKJK, EEDOLIFAKPN PLIJDIMDLMI, GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(JHMPJMIHIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2560160", Offset = "0x255ED60", VA = "0x182560160")]
	public static FGPEFBCCMDJ EGCGJPFDOJL(this HENOPHAMODO BEIGDPPEKJK)
	{
		return default(FGPEFBCCMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x25600C0", Offset = "0x255ECC0", VA = "0x1825600C0")]
	public static GDHDBKNKOKH BLAKDJDJKFD(this HENOPHAMODO BEIGDPPEKJK, Entity NNCGIOJNJIH)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x255FFB0", Offset = "0x255EBB0", VA = "0x18255FFB0")]
	public static GDHDBKNKOKH BLAKDJDJKFD(this HENOPHAMODO BEIGDPPEKJK, EEDOLIFAKPN PLIJDIMDLMI)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2560260", Offset = "0x255EE60", VA = "0x182560260")]
	public static EEDOLIFAKPN GHJADADNKKE(this HENOPHAMODO BEIGDPPEKJK, GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(EEDOLIFAKPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class LCNBEHPIBLD<T> : global::MGNIDCGMMJM<T>, global::OIOLNNEPNFJ<EEDOLIFAKPN, T>, global::JABALPDKNAB<EEDOLIFAKPN>, DLFABEMBHFH, IDisposable, APLKBADHFCN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::JABALPDKNAB<Entity> EAIGMDJHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate HKPFEPJKPOB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x44EF9F0", Offset = "0x44EE5F0", VA = "0x1844EF9F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type IPCNLNJCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x44EF100", Offset = "0x44EDD00", VA = "0x1844EF100", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EPHEKOJILAC EDFBONHJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x44EF3A0", Offset = "0x44EDFA0", VA = "0x1844EF3A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JALNHJKBGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x44EF3F0", Offset = "0x44EDFF0", VA = "0x1844EF3F0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AILNNILCAJD FPEIEBOMFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x44F12F0", Offset = "0x44EFEF0", VA = "0x1844F12F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x27D4C90", Offset = "0x27D3890", VA = "0x1827D4C90", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x44EE950", Offset = "0x44ED550", VA = "0x1844EE950", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::FLGLLECPPDA<EEDOLIFAKPN> KLPAHNCIGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x44F2030", Offset = "0x44F0C30", VA = "0x1844F2030", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x44EF1F0", Offset = "0x44EDDF0", VA = "0x1844EF1F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2446210", Offset = "0x2444E10", VA = "0x182446210")]
	public LCNBEHPIBLD(global::JABALPDKNAB<Entity> EAIGMDJHNBA, ALMILKEKENF JFBMPLDKGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x44F1770", Offset = "0x44F0370", VA = "0x1844F1770")]
	private Entity ONNAEPJPGJD(EEDOLIFAKPN PLIJDIMDLMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x44F1690", Offset = "0x44F0290", VA = "0x1844F1690")]
	private EEDOLIFAKPN ONNAEPJPGJD(Entity NNCGIOJNJIH)
	{
		return default(EEDOLIFAKPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x44F0580", Offset = "0x44EF180", VA = "0x1844F0580", Slot = "4")]
	public T LBHEOGGFILM(EEDOLIFAKPN PLIJDIMDLMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x44EF490", Offset = "0x44EE090", VA = "0x1844EF490")]
	public bool KCACFLLCKKN(EEDOLIFAKPN PLIJDIMDLMI, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x44EFB70", Offset = "0x44EE770", VA = "0x1844EFB70")]
	public bool KMKBFGCOFKL(EEDOLIFAKPN PLIJDIMDLMI, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x44F08D0", Offset = "0x44EF4D0", VA = "0x1844F08D0", Slot = "9")]
	public bool MDNKFKLILBA(EEDOLIFAKPN PLIJDIMDLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x44F10A0", Offset = "0x44EFCA0", VA = "0x1844F10A0", Slot = "26")]
	public object NGMIPJDJOIG(EEDOLIFAKPN PLIJDIMDLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x44EED40", Offset = "0x44ED940", VA = "0x1844EED40")]
	public bool DOKICGFGCNA(EEDOLIFAKPN PLIJDIMDLMI, in object GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x44F07D0", Offset = "0x44EF3D0", VA = "0x1844F07D0")]
	public void LBHEOGGFILM(EEDOLIFAKPN PLIJDIMDLMI, in LHILGMABJGJ PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x44EF820", Offset = "0x44EE420", VA = "0x1844EF820")]
	public bool KCACFLLCKKN(EEDOLIFAKPN PLIJDIMDLMI, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x44EFAF0", Offset = "0x44EE6F0", VA = "0x1844EFAF0")]
	public bool KMKBFGCOFKL(EEDOLIFAKPN PLIJDIMDLMI, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x24457D0", Offset = "0x24443D0", VA = "0x1824457D0", Slot = "21")]
	public void OFFBIIPDPNO(JMPGJCCPFPM CEHJPIKDCNA, [Optional] object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x44F1500", Offset = "0x44F0100", VA = "0x1844F1500", Slot = "15")]
	public void OFFBIIPDPNO(EEDOLIFAKPN IHPCMBAPNMC, LOHOEPCACME CEHJPIKDCNA, object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x44EE880", Offset = "0x44ED480", VA = "0x1844EE880", Slot = "14")]
	public bool AGNEFBHNEGG(EEDOLIFAKPN DFCDFHBOIBF, EEDOLIFAKPN HOMNJBLAHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC81C0", Offset = "0x1FC6DC0", VA = "0x181FC81C0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x44F20E0", Offset = "0x44F0CE0", VA = "0x1844F20E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x44F1050", Offset = "0x44EFC50", VA = "0x1844F1050")]
	public string NCMBBCEMIFP(in BNKGCKPKCFJ MFBLKCJOHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x44F00A0", Offset = "0x44EECA0", VA = "0x1844F00A0")]
	private void KPACMANFIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x44EE9C0", Offset = "0x44ED5C0", VA = "0x1844EE9C0")]
	private void DDJNJJKEEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x44F1840", Offset = "0x44F0440", VA = "0x1844F1840")]
	private void PDCGPGBKDBA(Entity NNCGIOJNJIH, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x44F1210", Offset = "0x44EFE10", VA = "0x1844F1210")]
	private void NHCHIALIKCA(Entity NNCGIOJNJIH, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x44F0C70", Offset = "0x44EF870", VA = "0x1844F0C70")]
	[Conditional("DEBUG_BUILD")]
	private static void MPAMKEMLMLM(Entity NNCGIOJNJIH, EEDOLIFAKPN PLIJDIMDLMI, string LOBDPBBMIIM, string MFIBLJJHIPI, [CallerMemberName] string KACFJFDAOHM = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x292FD20", Offset = "0x292E920", VA = "0x18292FD20", Slot = "5")]
	private bool KGGOPLIFMFG(EEDOLIFAKPN IHPCMBAPNMC, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2930110", Offset = "0x292ED10", VA = "0x182930110", Slot = "6")]
	private bool EHGPAKGIJAB(EEDOLIFAKPN IHPCMBAPNMC, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F78840", Offset = "0x2F77440", VA = "0x182F78840", Slot = "23")]
	private string IBBNCEEDAGA(in BNKGCKPKCFJ PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F78810", Offset = "0x2F77410", VA = "0x182F78810", Slot = "10")]
	private bool DMKBCAJPDOK(EEDOLIFAKPN IHPCMBAPNMC, in object GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F78930", Offset = "0x2F77530", VA = "0x182F78930", Slot = "11")]
	private void ANHGNFOGBKN(EEDOLIFAKPN IHPCMBAPNMC, in LHILGMABJGJ PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x44EF1C0", Offset = "0x44EDDC0", VA = "0x1844EF1C0", Slot = "12")]
	private bool ELHOKGFPIMD(EEDOLIFAKPN IHPCMBAPNMC, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x242FEC0", Offset = "0x242EAC0", VA = "0x18242FEC0", Slot = "13")]
	private bool LGOIMGGCOAK(EEDOLIFAKPN IHPCMBAPNMC, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class BEDFJHDAFAF<T> : global::AMCGIPBMOKC<T>, global::OIOLNNEPNFJ<GDHDBKNKOKH, T>, global::JABALPDKNAB<GDHDBKNKOKH>, DLFABEMBHFH, IDisposable, EFJFACGMOLK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::JABALPDKNAB<Entity> EAIGMDJHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate HKPFEPJKPOB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2444000", Offset = "0x2442C00", VA = "0x182444000", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type IPCNLNJCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x24436F0", Offset = "0x24422F0", VA = "0x1824436F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EPHEKOJILAC EDFBONHJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x24438F0", Offset = "0x24424F0", VA = "0x1824438F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JALNHJKBGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2443A20", Offset = "0x2442620", VA = "0x182443A20", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AILNNILCAJD FPEIEBOMFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x24453A0", Offset = "0x2443FA0", VA = "0x1824453A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2443FC0", Offset = "0x2442BC0", VA = "0x182443FC0", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2442EC0", Offset = "0x2441AC0", VA = "0x182442EC0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::FLGLLECPPDA<GDHDBKNKOKH> KLPAHNCIGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2445F70", Offset = "0x2444B70", VA = "0x182445F70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2443790", Offset = "0x2442390", VA = "0x182443790", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2446210", Offset = "0x2444E10", VA = "0x182446210")]
	public BEDFJHDAFAF(global::JABALPDKNAB<Entity> EAIGMDJHNBA, ALMILKEKENF JFBMPLDKGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9CB0", Offset = "0x1BF88B0", VA = "0x181BF9CB0")]
	private Entity ONNAEPJPGJD(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2445800", Offset = "0x2444400", VA = "0x182445800")]
	private GDHDBKNKOKH ONNAEPJPGJD(Entity NNCGIOJNJIH)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24449B0", Offset = "0x24435B0", VA = "0x1824449B0", Slot = "4")]
	public T LBHEOGGFILM(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2443A70", Offset = "0x2442670", VA = "0x182443A70")]
	public bool KCACFLLCKKN(GDHDBKNKOKH IFPFHNLOHFM, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x24443E0", Offset = "0x2442FE0", VA = "0x1824443E0")]
	public bool KMKBFGCOFKL(GDHDBKNKOKH IFPFHNLOHFM, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2445040", Offset = "0x2443C40", VA = "0x182445040", Slot = "9")]
	public bool MDNKFKLILBA(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x24451B0", Offset = "0x2443DB0", VA = "0x1824451B0", Slot = "25")]
	public object NGMIPJDJOIG(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2443480", Offset = "0x2442080", VA = "0x182443480")]
	public bool DOKICGFGCNA(GDHDBKNKOKH IFPFHNLOHFM, in object GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2444EE0", Offset = "0x2443AE0", VA = "0x182444EE0")]
	public void LBHEOGGFILM(GDHDBKNKOKH IFPFHNLOHFM, in LHILGMABJGJ PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2443C20", Offset = "0x2442820", VA = "0x182443C20")]
	public bool KCACFLLCKKN(GDHDBKNKOKH IFPFHNLOHFM, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2444350", Offset = "0x2442F50", VA = "0x182444350")]
	public bool KMKBFGCOFKL(GDHDBKNKOKH IFPFHNLOHFM, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x24457D0", Offset = "0x24443D0", VA = "0x1824457D0", Slot = "21")]
	public void OFFBIIPDPNO(JMPGJCCPFPM CEHJPIKDCNA, [Optional] object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2445440", Offset = "0x2444040", VA = "0x182445440", Slot = "15")]
	public void OFFBIIPDPNO(GDHDBKNKOKH IHPCMBAPNMC, LOHOEPCACME CEHJPIKDCNA, object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2442C90", Offset = "0x2441890", VA = "0x182442C90", Slot = "14")]
	public bool AGNEFBHNEGG(GDHDBKNKOKH DFCDFHBOIBF, GDHDBKNKOKH HOMNJBLAHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2444580", Offset = "0x2443180", VA = "0x182444580")]
	private void KPACMANFIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x24430C0", Offset = "0x2441CC0", VA = "0x1824430C0")]
	private void DDJNJJKEEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2445830", Offset = "0x2444430", VA = "0x182445830")]
	private void PDCGPGBKDBA(Entity NNCGIOJNJIH, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x24452C0", Offset = "0x2443EC0", VA = "0x1824452C0")]
	private void NHCHIALIKCA(Entity NNCGIOJNJIH, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2443660", Offset = "0x2442260", VA = "0x182443660", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2446170", Offset = "0x2444D70", VA = "0x182446170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2442C50", Offset = "0x2441850", VA = "0x182442C50", Slot = "5")]
	private bool ADEPOKKPDLH(GDHDBKNKOKH IHPCMBAPNMC, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2444F60", Offset = "0x2443B60", VA = "0x182444F60", Slot = "6")]
	private bool LFADKBHLDGB(GDHDBKNKOKH IHPCMBAPNMC, in T GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2443750", Offset = "0x2442350", VA = "0x182443750", Slot = "10")]
	private bool EOOIPKLPPHB(GDHDBKNKOKH IHPCMBAPNMC, in object GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2443990", Offset = "0x2442590", VA = "0x182443990", Slot = "11")]
	private void IGDBKIPFIHN(GDHDBKNKOKH IHPCMBAPNMC, in LHILGMABJGJ PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2445360", Offset = "0x2443F60", VA = "0x182445360", Slot = "12")]
	private bool NJFNNOLGIAJ(GDHDBKNKOKH IHPCMBAPNMC, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x24450E0", Offset = "0x2443CE0", VA = "0x1824450E0", Slot = "13")]
	private bool MJMGDDKAHPM(GDHDBKNKOKH IHPCMBAPNMC, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PCJLLMMMFMG(typeof(ODDGBIGFEAO), new string[] { })]
public class IFFNAKKHNHG : GLEEPPGLLOC, ODDGBIGFEAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const string HOIDKDEFJBD = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private FGPEFBCCMDJ CHDNHOJEDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private KJFKLHABFME JLFPFLLINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private PEMMGIBHFPO EAPJLCHNOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ObjectEmbodimentService LIKJOLDFEOD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GDHDBKNKOKH DHDGJGOAJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "7")]
		get
		{
			return default(GDHDBKNKOKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x25F7F70", Offset = "0x25F6B70", VA = "0x1825F7F70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FGPEFBCCMDJ EDDHPMLAOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "9")]
		get
		{
			return default(FGPEFBCCMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x25F7F70", Offset = "0x25F6B70", VA = "0x1825F7F70", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GNBNPAOJOKC GCEANADBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x25F7E00", Offset = "0x25F6A00", VA = "0x1825F7E00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x25F84D0", Offset = "0x25F70D0", VA = "0x1825F84D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x25F7D30", Offset = "0x25F6930", VA = "0x1825F7D30", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25F7EA0", Offset = "0x25F6AA0", VA = "0x1825F7EA0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x25F8570", Offset = "0x25F7170", VA = "0x1825F8570", Slot = "11")]
	public GDHDBKNKOKH LCMCMOHEAEM(GDHDBKNKOKH FOKMNOHOCNA, GDHDBKNKOKH FJKICIEEJIJ)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x25F7F90", Offset = "0x25F6B90", VA = "0x1825F7F90", Slot = "12")]
	public bool EEOIKKOOHMM(GDHDBKNKOKH FOKMNOHOCNA, GDHDBKNKOKH FJKICIEEJIJ, out GDHDBKNKOKH ILFEJKHGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x25F7C10", Offset = "0x25F6810", VA = "0x1825F7C10", Slot = "13")]
	public void AKAMIDAADKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25F8680", Offset = "0x25F7280", VA = "0x1825F8680", Slot = "14")]
	public void MCNBEMKOMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x25F7AF0", Offset = "0x25F66F0", VA = "0x1825F7AF0", Slot = "15")]
	public bool ADGFAPLMOEN(GDHDBKNKOKH PNGBENFNCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25F8260", Offset = "0x25F6E60", VA = "0x1825F8260")]
	private bool GMCCHCMDAGK(GDHDBKNKOKH DKKKAJIAAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25F8090", Offset = "0x25F6C90", VA = "0x1825F8090")]
	private void FOMBBJGEIPD(JHMPJMIHIEB HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IFFNAKKHNHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PCJLLMMMFMG(typeof(PEMMGIBHFPO), new string[] { })]
public class IICBAMJGDMM : GLEEPPGLLOC, PEMMGIBHFPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x25F8CE0", Offset = "0x25F78E0", VA = "0x1825F8CE0", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x25F8DB0", Offset = "0x25F79B0", VA = "0x1825F8DB0", Slot = "5")]
	public void IABNIDPKGIF(GDHDBKNKOKH NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x25F8D50", Offset = "0x25F7950", VA = "0x1825F8D50", Slot = "6")]
	public void DEOPAFLJFEE(GDHDBKNKOKH NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IICBAMJGDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DFIKIBFBKKB : IDisposable, JKNPCDDAHDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> DAFOPKHFJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A40", Offset = "0x8F4640", VA = "0x1808F5A40", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public DFIKIBFBKKB(NativeArray<EntityRemapUtility.EntityRemapInfo> JEIAFELIGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x22753B0", Offset = "0x2273FB0", VA = "0x1822753B0", Slot = "6")]
	public GDHDBKNKOKH FJEEBAOHLFA(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2275400", Offset = "0x2274000", VA = "0x182275400", Slot = "7")]
	public Entity FJEEBAOHLFA(Entity NNCGIOJNJIH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2275320", Offset = "0x2273F20", VA = "0x182275320", Slot = "8")]
	public IEnumerable<GDHDBKNKOKH> FJEEBAOHLFA(IEnumerable<GDHDBKNKOKH> ODIKFPCELJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x22752C0", Offset = "0x2273EC0", VA = "0x1822752C0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[KHHGHKHGGFN(EOABPLMDMOL.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string ANMOFFHILAC = "Remap";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly PEOJNAGCHAI GELOOKHNBMI;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static int MOCBPBAPCHG;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static JKNPCDDAHDN OODOAHDGELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool LFIIJMLGJKI;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> DAFOPKHFJGG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x256C1A0", Offset = "0x256ADA0", VA = "0x18256C1A0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static bool DIKPGGBGHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x256C110", Offset = "0x256AD10", VA = "0x18256C110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x256BD30", Offset = "0x256A930", VA = "0x18256BD30")]
		public static SerializationRemapScope DNEOEPNEIAJ()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x256C320", Offset = "0x256AF20", VA = "0x18256C320")]
		public SerializationRemapScope(JKNPCDDAHDN MDGDJDMFKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x256BD90", Offset = "0x256A990", VA = "0x18256BD90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x256BE90", Offset = "0x256AA90", VA = "0x18256BE90")]
		public static GDHDBKNKOKH FJEEBAOHLFA(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x256BFE0", Offset = "0x256ABE0", VA = "0x18256BFE0")]
		public static Entity FJEEBAOHLFA(Entity NNCGIOJNJIH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[PCJLLMMMFMG(typeof(KJFKLHABFME), new string[] { })]
public class NKDAJIOHNIB : KJFKLHABFME, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityHierarchyParents JJMCKEAOKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityHierarchyChildren PPLIDDKCFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private INFBOELCJHP GBIHOJOKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ObjectEmbodimentService LIKJOLDFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public global::AMCGIPBMOKC<GDHDBKNKOKH> GBDEIDMACBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5F7D70", Offset = "0x5F6970", VA = "0x1805F7D70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x67EFC0", Offset = "0x67DBC0", VA = "0x18067EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xC745E0", Offset = "0xC731E0", VA = "0x180C745E0", Slot = "12")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2562210", Offset = "0x2560E10", VA = "0x182562210", Slot = "13")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2562780", Offset = "0x2561380", VA = "0x182562780", Slot = "14")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2562A80", Offset = "0x2561680", VA = "0x182562A80")]
	private GDHDBKNKOKH MJMODDAMGCD(Entity NNCGIOJNJIH)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2562670", Offset = "0x2561270", VA = "0x182562670", Slot = "17")]
	public GDHDBKNKOKH FCBFJIMMCJO(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25622E0", Offset = "0x2560EE0", VA = "0x1825622E0", Slot = "18")]
	public void CMNDNBNHJJD(ref List<GDHDBKNKOKH> CLKPKBPNOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2562B20", Offset = "0x2561720", VA = "0x182562B20", Slot = "19")]
	public IEnumerable<GDHDBKNKOKH> ODDBCNABBCI(GDHDBKNKOKH IFPFHNLOHFM, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2562AB0", Offset = "0x25616B0", VA = "0x182562AB0", Slot = "20")]
	public GDHDBKNKOKH MLIECFFOLEB(GDHDBKNKOKH IFPFHNLOHFM, int BAOHKIGDOBF)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2562480", Offset = "0x2561080", VA = "0x182562480", Slot = "21")]
	public int DMHAKOOPBKO(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2562A50", Offset = "0x2561650", VA = "0x182562A50", Slot = "6")]
	public int MIBHFDDOHEA(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2562850", Offset = "0x2561450", VA = "0x182562850", Slot = "7")]
	public EGFIHJFLGFK IGOCIMBLAEA(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x25628C0", Offset = "0x25614C0", VA = "0x1825628C0", Slot = "22")]
	public IEnumerable<GDHDBKNKOKH> JILLEFHCFOK(GDHDBKNKOKH IFPFHNLOHFM, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2562960", Offset = "0x2561560", VA = "0x182562960", Slot = "10")]
	public GDHDBKNKOKH LCMCMOHEAEM(GDHDBKNKOKH FOKMNOHOCNA, GDHDBKNKOKH FJKICIEEJIJ)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2562560", Offset = "0x2561160", VA = "0x182562560", Slot = "11")]
	public bool EEOIKKOOHMM(GDHDBKNKOKH FOKMNOHOCNA, GDHDBKNKOKH FJKICIEEJIJ, out GDHDBKNKOKH ILFEJKHGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2562710", Offset = "0x2561310", VA = "0x182562710", Slot = "4")]
	public GDHDBKNKOKH GONPBILDEDE(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2562BC0", Offset = "0x25617C0", VA = "0x182562BC0", Slot = "9")]
	public bool PJPPMNCPPCG(GDHDBKNKOKH IFPFHNLOHFM, GDHDBKNKOKH DDBHKAHGHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2562640", Offset = "0x2561240", VA = "0x182562640", Slot = "23")]
	public bool ENBKDMJDKDK(GDHDBKNKOKH IFPFHNLOHFM, GDHDBKNKOKH PCCELBMBFIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2562530", Offset = "0x2561130", VA = "0x182562530", Slot = "8")]
	public bool EEICHDLNGBO(GDHDBKNKOKH IFPFHNLOHFM, GDHDBKNKOKH FOKMNOHOCNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x25626E0", Offset = "0x25612E0", VA = "0x1825626E0", Slot = "5")]
	public bool FHDAIOOLDNB(GDHDBKNKOKH IFPFHNLOHFM, GDHDBKNKOKH PPHLLODMENC, bool JEOPJCKNNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xF20200", Offset = "0xF1EE00", VA = "0x180F20200", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NKDAJIOHNIB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(EKIJLGHMMLP))]
	[KHHGHKHGGFN(EOABPLMDMOL.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class EKIJLGHMMLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer GDLCFFFAFKF;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int JFMPCJJIJJI
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x25598F0", Offset = "0x25584F0", VA = "0x1825598F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public AKKBFLHNMND[] BLIMHLOLDHM
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x2559940", Offset = "0x2558540", VA = "0x182559940")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
			public EKIJLGHMMLP(ActionBuffer GAONLPJNEFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x2559810", Offset = "0x2558410", VA = "0x182559810")]
			[CompilerGenerated]
			private AKKBFLHNMND BBLFNJKMLNH(EMCCHJHGEOI FHCMCNABNIM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class AKKBFLHNMND : JMPGJCCPFPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly ActionBuffer GDLCFFFAFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private readonly EMCCHJHGEOI FHCMCNABNIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private List<(KIOOBADIGHP, string, object)> BEMPOAOGIKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private ECMKNPGCFDI CPAEFKPNLIE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int JFMPCJJIJJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x2554CF0", Offset = "0x25538F0", VA = "0x182554CF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public List<(KIOOBADIGHP, string, object)> CGFLDJCMCAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x25550A0", Offset = "0x2553CA0", VA = "0x1825550A0")]
			public AKKBFLHNMND(ActionBuffer GAONLPJNEFK, EMCCHJHGEOI FHCMCNABNIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2554D40", Offset = "0x2553940", VA = "0x182554D40")]
			private string EJNGBHEHDFF(KIOOBADIGHP OBEDCGEEEIB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2554DC0", Offset = "0x25539C0", VA = "0x182554DC0")]
			private void MMDAHEHGHKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x22248C0", Offset = "0x22234C0", VA = "0x1822248C0", Slot = "4")]
			public void AOBAHFDOFAJ<TKey, T>(global::OIOLNNEPNFJ<TKey, T> EAIGMDJHNBA, [Optional] object BGDHIGEIIHJ) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private NativeList<byte> FOKDMEPEAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Stack<EMCCHJHGEOI> LDNLBJKEDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DEHAHAGCKBK FDEJPLIJIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly PBLGGEBLEDD FCIOLACIEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly PAKOKDDGBAI OHOCCAOGOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly bool HCNEAIBBKHC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public MDIGALBMIEN JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x2555AA0", Offset = "0x25546A0", VA = "0x182555AA0")]
			get
			{
				return default(MDIGALBMIEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int JFMPCJJIJJI
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2555400", Offset = "0x2554000", VA = "0x182555400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2555E40", Offset = "0x2554A40", VA = "0x182555E40")]
		public ActionBuffer(PBLGGEBLEDD FCIOLACIEPB, PAKOKDDGBAI OHOCCAOGOIA, bool HCNEAIBBKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2555150", Offset = "0x2553D50", VA = "0x182555150")]
		public bool AEAMMDHEBCE(out EMCCHJHGEOI FHCMCNABNIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2555B10", Offset = "0x2554710", VA = "0x182555B10")]
		public void MNHBKLHOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2555730", Offset = "0x2554330", VA = "0x182555730")]
		public EMCCHJHGEOI HIOHLGIEIHO(LDCGGKKMNGD BEMPOAOGIKC, MEALGONGCGH BHMAHHDPLCI, uint BHPDDHGLFPE)
		{
			return default(EMCCHJHGEOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2555AE0", Offset = "0x25546E0", VA = "0x182555AE0")]
		public bool MLECPEAPHHG(uint BHPDDHGLFPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2555B70", Offset = "0x2554770", VA = "0x182555B70")]
		public bool OCJLDONLBLP(uint BHPDDHGLFPE, out EMCCHJHGEOI PNGBENFNCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2555240", Offset = "0x2553E40", VA = "0x182555240")]
		public void CNKFBHNOOAI(EMCCHJHGEOI PNGBENFNCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2555440", Offset = "0x2554040", VA = "0x182555440")]
		[Conditional("DEBUG_BUILD")]
		private void FLOLCIKJBAK(EMCCHJHGEOI PNGBENFNCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2555890", Offset = "0x2554490", VA = "0x182555890")]
		private void JMJFHDIAEPF(EMCCHJHGEOI JFDFPIBKMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2555580", Offset = "0x2554180", VA = "0x182555580")]
		private void HBDICAHOFMO(ECMKNPGCFDI COLLMIDDEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x25551E0", Offset = "0x2553DE0", VA = "0x1825551E0")]
		private void CFIBANLIIAF(EMCCHJHGEOI FHCMCNABNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2555D30", Offset = "0x2554930", VA = "0x182555D30")]
		private ECMKNPGCFDI PLGEPDEEJNP(EMCCHJHGEOI FHCMCNABNIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x25553A0", Offset = "0x2553FA0", VA = "0x1825553A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DEHAHAGCKBK : JMPGJCCPFPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PBLGGEBLEDD FCIOLACIEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PAKOKDDGBAI OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private EEDOLIFAKPN NDMJKBJOMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private ECMKNPGCFDI NGMABCLDIMM;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5F7990", Offset = "0x5F6590", VA = "0x1805F7990")]
	public DEHAHAGCKBK(PBLGGEBLEDD FCIOLACIEPB, PAKOKDDGBAI OHOCCAOGOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A140", Offset = "0x2E28D40", VA = "0x182E2A140", Slot = "4")]
	public void AOBAHFDOFAJ<TKey, T>(global::OIOLNNEPNFJ<TKey, T> GMGMEDIFPHB, [Optional] object BGDHIGEIIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2275130", Offset = "0x2273D30", VA = "0x182275130")]
	public void OFFBIIPDPNO(KIOOBADIGHP OBEDCGEEEIB, ref ECMKNPGCFDI COLLMIDDEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LDOPFOKNOLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct KCFPPAJEIBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly LDOPFOKNOLJ PPHLLODMENC;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x25FDE20", Offset = "0x25FCA20", VA = "0x1825FDE20")]
		public KCFPPAJEIBC(LDOPFOKNOLJ PPHLLODMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x25FDD30", Offset = "0x25FC930", VA = "0x1825FDD30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected LDCGGKKMNGD BEMPOAOGIKC;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LDCGGKKMNGD CGFLDJCMCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x212F570", Offset = "0x212E170", VA = "0x18212F570")]
		get
		{
			return default(LDCGGKKMNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool LKPKGGHNBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2600950", Offset = "0x25FF550", VA = "0x182600950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2600D80", Offset = "0x25FF980", VA = "0x182600D80")]
	public LDOPFOKNOLJ(LDCGGKKMNGD.PFPFEGKDJFL DJPHDBFHGEK = LDCGGKKMNGD.PFPFEGKDJFL.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2600C30", Offset = "0x25FF830", VA = "0x182600C30")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2600990", Offset = "0x25FF590", VA = "0x182600990")]
	public void GNDBCCFLEHM(EEDOLIFAKPN NDMJKBJOMGA, JCLNMMLEPOP IBGKMLNBJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2600D10", Offset = "0x25FF910", VA = "0x182600D10")]
	public void PMHMEELAPCD(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2600C40", Offset = "0x25FF840", VA = "0x182600C40")]
	public void OPGJEKDFOID(EEDOLIFAKPN NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2600B50", Offset = "0x25FF750", VA = "0x182600B50")]
	public void JDIAPMLJCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2600A70", Offset = "0x25FF670", VA = "0x182600A70")]
	public void HECODCAKEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2600940", Offset = "0x25FF540", VA = "0x182600940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2600960", Offset = "0x25FF560", VA = "0x182600960")]
	public KCFPPAJEIBC FABCOCFOMCN()
	{
		return default(KCFPPAJEIBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KIOOBADIGHP : IComparable<KIOOBADIGHP>, IEquatable<KIOOBADIGHP>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KIOOBADIGHP OEGEMGKBDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public EEDOLIFAKPN NDMJKBJOMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public GBEPIPMPHEG MKJDELBEPBK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x25FE350", Offset = "0x25FCF50", VA = "0x1825FE350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x76DD30", Offset = "0x76C930", VA = "0x18076DD30")]
	public KIOOBADIGHP(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x25FE300", Offset = "0x25FCF00", VA = "0x1825FE300")]
	public void AFHBBEOFCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x25FE310", Offset = "0x25FCF10", VA = "0x1825FE310", Slot = "4")]
	public int CompareTo(KIOOBADIGHP LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x25FE520", Offset = "0x25FD120", VA = "0x1825FE520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x25FE400", Offset = "0x25FD000", VA = "0x1825FE400", Slot = "0")]
	public override bool Equals(object HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x25FE3B0", Offset = "0x25FCFB0", VA = "0x1825FE3B0", Slot = "5")]
	public bool Equals(KIOOBADIGHP LPEBOAHCFNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x25FE4A0", Offset = "0x25FD0A0", VA = "0x1825FE4A0")]
	public static bool GPLOOKALJBH(KIOOBADIGHP EAGBNEBPABL, KIOOBADIGHP HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x25FE360", Offset = "0x25FCF60", VA = "0x1825FE360")]
	public static bool EGNPDGHOPNA(KIOOBADIGHP EAGBNEBPABL, KIOOBADIGHP HDKBIEHDLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x25FE4E0", Offset = "0x25FD0E0", VA = "0x1825FE4E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AEGJGNOICJK : LOHOEPCACME
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private PBLGGEBLEDD FCIOLACIEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EEDOLIFAKPN NDMJKBJOMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private HNCMIACNIJA CKEALBHLMFG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x226B460", Offset = "0x226A060", VA = "0x18226B460")]
	public void GJKIAMNHKEN(EEDOLIFAKPN NDMJKBJOMGA, PBLGGEBLEDD FCIOLACIEPB, HNCMIACNIJA CKEALBHLMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x226B3A0", Offset = "0x2269FA0", VA = "0x18226B3A0", Slot = "4")]
	private void BBOKBLJADMI(DLFABEMBHFH EAIGMDJHNBA, in BNKGCKPKCFJ PDMPLJICJLE, object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public AEGJGNOICJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DIHELGHABAC
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2275F30", Offset = "0x2274B30", VA = "0x182275F30")]
	public static void GDOGMDFCHEO(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB, JCLNMMLEPOP IBGKMLNBJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2275DF0", Offset = "0x22749F0", VA = "0x182275DF0")]
	public static void BPCJAFNMJON(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2275EE0", Offset = "0x2274AE0", VA = "0x182275EE0")]
	public static void EDLKHNCPJBP(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2276050", Offset = "0x2274C50", VA = "0x182276050")]
	public static void HNOEPCKHMJP(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2276120", Offset = "0x2274D20", VA = "0x182276120")]
	public static JCLNMMLEPOP OMMOKBNIGBG(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB)
	{
		return default(JCLNMMLEPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1D8D390", Offset = "0x1D8BF90", VA = "0x181D8D390")]
	public static T NJGMAAPEMLN<T>(LDCGGKKMNGD BEMPOAOGIKC, KIOOBADIGHP OBEDCGEEEIB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1D8D360", Offset = "0x1D8BF60", VA = "0x181D8D360")]
	public static T NJGMAAPEMLN<T>(ref ECMKNPGCFDI CEECNJJKNFO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2276170", Offset = "0x2274D70", VA = "0x182276170")]
	public static JCLNMMLEPOP OMMOKBNIGBG(ref ECMKNPGCFDI CEECNJJKNFO)
	{
		return default(JCLNMMLEPOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[PCJLLMMMFMG(typeof(HNCMIACNIJA), new string[] { })]
[CFMIFJPBJOM(typeof(KMGPAOBKBAH))]
public class HNCMIACNIJA : GLEEPPGLLOC, IDisposable, KMGPAOBKBAH
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JIJABBGELMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct HLHEOGCNIGK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly JIJABBGELMO MGADMFHPLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly HNCMIACNIJA ALHPFJAALAP;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x25F4780", Offset = "0x25F3380", VA = "0x1825F4780")]
		public HLHEOGCNIGK(HNCMIACNIJA ALHPFJAALAP, bool ENLIGIMJDIO, uint PGLJOAGFHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x25F4750", Offset = "0x25F3350", VA = "0x1825F4750", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class KJCLDBOFCGI
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct JHIIFMHENCD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly KJCLDBOFCGI FOJKOMAOGDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly bool IJJCMLILADK;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x25FC240", Offset = "0x25FAE40", VA = "0x1825FC240")]
			public JHIIFMHENCD(KJCLDBOFCGI FOJKOMAOGDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x25EF2F0", Offset = "0x25EDEF0", VA = "0x1825EF2F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct ABOIFKGNDCC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly KJCLDBOFCGI FOJKOMAOGDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly bool IJJCMLILADK;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x25EF320", Offset = "0x25EDF20", VA = "0x1825EF320")]
			public ABOIFKGNDCC(KJCLDBOFCGI FOJKOMAOGDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x25EF2F0", Offset = "0x25EDEF0", VA = "0x1825EF2F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly HNCMIACNIJA CKEALBHLMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool EGLGLBBEIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int NCMMOKACOCD;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x25FE690", Offset = "0x25FD290", VA = "0x1825FE690")]
		public KJCLDBOFCGI(HNCMIACNIJA CKEALBHLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x25FE610", Offset = "0x25FD210", VA = "0x1825FE610")]
		public bool MJAFKPNNEFC(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x25FE5C0", Offset = "0x25FD1C0", VA = "0x1825FE5C0")]
		public ABOIFKGNDCC EHECAEPLAHG()
		{
			return default(ABOIFKGNDCC);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x25FE640", Offset = "0x25FD240", VA = "0x1825FE640")]
		public JHIIFMHENCD OCFKKLAKILP()
		{
			return default(JHIIFMHENCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ADFDKIODFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HNCMIACNIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ADFDKIODFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x25EF360", Offset = "0x25EDF60", VA = "0x1825EF360")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FCOMGHNKLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HNCMIACNIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FCOMGHNKLPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x25F0C80", Offset = "0x25EF880", VA = "0x1825F0C80")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LCEMACEJPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public LCEMACEJPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x25FEAD0", Offset = "0x25FD6D0", VA = "0x1825FEAD0")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly UndoAction PIGCPOLCEMF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly RedoAction JFECANEFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private LDOPFOKNOLJ OJPNFKCEOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer AIPGGLNNIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private ActionBuffer COABPBPNOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HEINBCBJOCN NACNPKFGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NPHACLKFACK FNALOPBEMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private TransformOwnershipPhase PDMJCBOMAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private MEALGONGCGH BHMAHHDPLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private JIJABBGELMO KIHJAPGCJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint AKKKAFOOGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private uint NDIBJCKEBKJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private KJCLDBOFCGI PBFLCHEAPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA620", Offset = "0x5E9220", VA = "0x1805EA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool IOKFDHOKPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x25F5370", Offset = "0x25F3F70", VA = "0x1825F5370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NABPKPCPKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x25F54F0", Offset = "0x25F40F0", VA = "0x1825F54F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CBAKKOJPKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x25F55E0", Offset = "0x25F41E0", VA = "0x1825F55E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int CMOCCNCGPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x25F5C40", Offset = "0x25F4840", VA = "0x1825F5C40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HEJDHECOCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x25F4D60", Offset = "0x25F3960", VA = "0x1825F4D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool JCDEIDBAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x25F50F0", Offset = "0x25F3CF0", VA = "0x1825F50F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private bool LMBLIEGLPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x25F59D0", Offset = "0x25F45D0", VA = "0x1825F59D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool KJHGHMDIELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x73FAB0", Offset = "0x73E6B0", VA = "0x18073FAB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x73FB00", Offset = "0x73E700", VA = "0x18073FB00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private ActionBuffer BAOLDFNMOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x25F47F0", Offset = "0x25F33F0", VA = "0x1825F47F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action ACMKOIGFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x25F5540", Offset = "0x25F4140", VA = "0x1825F5540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x25F5450", Offset = "0x25F4050", VA = "0x1825F5450", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EFKJJKGINFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x25F59E0", Offset = "0x25F45E0", VA = "0x1825F59E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x25F51E0", Offset = "0x25F3DE0", VA = "0x1825F51E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x25F60A0", Offset = "0x25F4CA0", VA = "0x1825F60A0")]
	public HNCMIACNIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x25F4A30", Offset = "0x25F3630", VA = "0x1825F4A30", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x25F4F90", Offset = "0x25F3B90", VA = "0x1825F4F90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x25F5A80", Offset = "0x25F4680", VA = "0x1825F5A80", Slot = "14")]
	public IDisposable LIDAIELAAKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x25F5100", Offset = "0x25F3D00", VA = "0x1825F5100", Slot = "9")]
	public IDisposable GDDNKIHLONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x25F53A0", Offset = "0x25F3FA0", VA = "0x1825F53A0", Slot = "6")]
	public UndoAction HIOHLGIEIHO()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x25F4E10", Offset = "0x25F3A10", VA = "0x1825F4E10", Slot = "15")]
	public RedoAction DKFOOKCOENB()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x25F4CD0", Offset = "0x25F38D0", VA = "0x1825F4CD0", Slot = "16")]
	public UndoAction BOGOMBMGOGE()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x25F4EA0", Offset = "0x25F3AA0", VA = "0x1825F4EA0", Slot = "7")]
	public RedoAction DKFOOKCOENB(UndoAction PNGBENFNCCL)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x25F4BE0", Offset = "0x25F37E0", VA = "0x1825F4BE0", Slot = "8")]
	public UndoAction BOGOMBMGOGE(RedoAction PNGBENFNCCL)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x25F4D80", Offset = "0x25F3980", VA = "0x1825F4D80")]
	public bool DAAFFCFJLFF(CBDPAOJBHCO GEPAOJOGPDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x25F5B20", Offset = "0x25F4720", VA = "0x1825F5B20", Slot = "17")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x25F5280", Offset = "0x25F3E80", VA = "0x1825F5280")]
	public void GNDBCCFLEHM(EEDOLIFAKPN NDMJKBJOMGA, JCLNMMLEPOP IBGKMLNBJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x25F5EC0", Offset = "0x25F4AC0", VA = "0x1825F5EC0")]
	public void PMHMEELAPCD(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x25F5D00", Offset = "0x25F4900", VA = "0x1825F5D00")]
	public void OPGJEKDFOID(EEDOLIFAKPN NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x25F4DD0", Offset = "0x25F39D0", VA = "0x1825F4DD0")]
	private void DAHJNIIIIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x25F5330", Offset = "0x25F3F30", VA = "0x1825F5330")]
	private void GOEGMDFCCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x25F5B00", Offset = "0x25F4700", VA = "0x1825F5B00")]
	private void MHHPBEMEOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x25F5610", Offset = "0x25F4210", VA = "0x1825F5610")]
	private EMCCHJHGEOI IOHCHMELPAG()
	{
		return default(EMCCHJHGEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x25F5B70", Offset = "0x25F4770", VA = "0x1825F5B70")]
	private uint MOHFFJOHPOM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x25F5430", Offset = "0x25F4030", VA = "0x1825F5430")]
	private bool HNFBOHJHPCC(out EMCCHJHGEOI FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x25F5DA0", Offset = "0x25F49A0", VA = "0x1825F5DA0")]
	private bool PAALKLFHLLA(out EMCCHJHGEOI FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x25F5090", Offset = "0x25F3C90", VA = "0x1825F5090")]
	private RedoAction FFLKABBFPLG(EMCCHJHGEOI FHCMCNABNIM)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F5180", Offset = "0x25F3D80", VA = "0x1825F5180")]
	private UndoAction GJGAPBCFIHP(EMCCHJHGEOI FHCMCNABNIM)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x25F5710", Offset = "0x25F4310", VA = "0x1825F5710")]
	private EMCCHJHGEOI JMJFHDIAEPF(EMCCHJHGEOI FHCMCNABNIM, ActionBuffer EJJBKKFPFCE, bool ENLIGIMJDIO)
	{
		return default(EMCCHJHGEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F5B90", Offset = "0x25F4790", VA = "0x1825F5B90")]
	private void NEIBJGCJLEK(Action FHCMCNABNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x33DAA90", Offset = "0x33D9690", VA = "0x1833DAA90")]
	private T NEIBJGCJLEK<T>(Func<T> IBLJEJBHCPL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x25F5C90", Offset = "0x25F4890", VA = "0x1825F5C90")]
	private HLHEOGCNIGK NOKDNOJJOEH(bool ENLIGIMJDIO, uint PGLJOAGFHIO)
	{
		return default(HLHEOGCNIGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x25F5DC0", Offset = "0x25F49C0", VA = "0x1825F5DC0")]
	[CompilerGenerated]
	private UndoAction PJOMDNNILKM()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x25F4910", Offset = "0x25F3510", VA = "0x1825F4910")]
	[CompilerGenerated]
	private RedoAction BAANCPOBJNF()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x25F4800", Offset = "0x25F3400", VA = "0x1825F4800")]
	[CompilerGenerated]
	private UndoAction AHPAOLEJOCJ()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LDCGGKKMNGD : IEnumerable<KIOOBADIGHP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum PFPFEGKDJFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct CDNDHODFFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly LDCGGKKMNGD EJNJGLOFIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly MEALGONGCGH BHMAHHDPLCI;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x25F0080", Offset = "0x25EEC80", VA = "0x1825F0080")]
		public CDNDHODFFDE(LDCGGKKMNGD EJNJGLOFIFF, MEALGONGCGH BHMAHHDPLCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x25EF8C0", Offset = "0x25EE4C0", VA = "0x1825EF8C0")]
		public void FNOFEFAFDGC(NativeList<byte> OEMDOONMCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x25F0030", Offset = "0x25EEC30", VA = "0x1825F0030")]
		private void OLAFMIEELOJ(KIOOBADIGHP OBEDCGEEEIB, ref CFCHMAFCPCM AFKNFMMBBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x25EFE40", Offset = "0x25EEA40", VA = "0x1825EFE40")]
		private void LKLHHADMFCG(KIOOBADIGHP OBEDCGEEEIB, ref CFCHMAFCPCM AFKNFMMBBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x25EF7E0", Offset = "0x25EE3E0", VA = "0x1825EF7E0")]
		private NativeArray<byte> FDIJNDLFEPI(NativeList<byte> OEMDOONMCAB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x25EFD70", Offset = "0x25EE970", VA = "0x1825EFD70")]
		private NativeArray<byte> IBPBCEACLHP(NativeList<byte> OEMDOONMCAB, int LIJNMPAFKGC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x25EFB50", Offset = "0x25EE750", VA = "0x1825EFB50")]
		private int GCEEPNLMLCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x25EFED0", Offset = "0x25EEAD0", VA = "0x1825EFED0")]
		private bool NEMFIPCOLPF(KIOOBADIGHP OBEDCGEEEIB, out NativeArray<byte> HCJDLIELHDC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct FFGAJLGCPJJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeList<byte> CEECNJJKNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private LDCGGKKMNGD EJNJGLOFIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly KIOOBADIGHP CHFHFNDILMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int DJHHNCHEKKB;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x25F0F80", Offset = "0x25EFB80", VA = "0x1825F0F80")]
		internal FFGAJLGCPJJ(LDCGGKKMNGD EJNJGLOFIFF, KIOOBADIGHP CHFHFNDILMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x25F0CF0", Offset = "0x25EF8F0", VA = "0x1825F0CF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x25F0D20", Offset = "0x25EF920", VA = "0x1825F0D20")]
		public void EFCJCGNAHEE(NativeArray<byte> PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x25F0F10", Offset = "0x25EFB10", VA = "0x1825F0F10")]
		public void JGGLLPIMIHN(NativeArray<byte> PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x25F0F70", Offset = "0x25EFB70", VA = "0x1825F0F70")]
		public void LKLHHADMFCG(in BNKGCKPKCFJ PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C380", Offset = "0x2E0AF80", VA = "0x182E0C380")]
		public void LKLHHADMFCG<T>(T PDMPLJICJLE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x25F0EA0", Offset = "0x25EFAA0", VA = "0x1825F0EA0")]
		private void FKEALBJOBFB(int PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x25F0D80", Offset = "0x25EF980", VA = "0x1825F0D80")]
		private void FKEALBJOBFB(in BNKGCKPKCFJ PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x25F0E40", Offset = "0x25EFA40", VA = "0x1825F0E40")]
		private unsafe void FKEALBJOBFB(void* PNBCAMLEJGI, int LIJNMPAFKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x25F0D20", Offset = "0x25EF920", VA = "0x1825F0D20")]
		private void FKEALBJOBFB(NativeArray<byte> HOMNJBLAHAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct IMJNAENFHBI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private LDCGGKKMNGD EJNJGLOFIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private NativeArray<byte> CEECNJJKNFO;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x25F9BE0", Offset = "0x25F87E0", VA = "0x1825F9BE0")]
		internal IMJNAENFHBI(LDCGGKKMNGD EJNJGLOFIFF, NativeArray<byte> CEECNJJKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x25F9AA0", Offset = "0x25F86A0", VA = "0x1825F9AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x25F9AB0", Offset = "0x25F86B0", VA = "0x1825F9AB0")]
		public NativeArray<byte> GFEBBJDHFMA(int LIJNMPAFKGC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x25F9B70", Offset = "0x25F8770", VA = "0x1825F9B70")]
		public NativeArray<byte> OOBGILFDFMI()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2238050", Offset = "0x2236C50", VA = "0x182238050")]
		public T DICJDEAEFBM<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x25F9A20", Offset = "0x25F8620", VA = "0x1825F9A20")]
		public void DICJDEAEFBM(in LHILGMABJGJ PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ICNABOLFFAD : IEnumerator<KIOOBADIGHP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly NativeArray<KIOOBADIGHP> MPENDCAONOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int BAOHKIGDOBF;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public KIOOBADIGHP JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x25F7510", Offset = "0x25F6110", VA = "0x1825F7510", Slot = "4")]
			get
			{
				return default(KIOOBADIGHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x25F74B0", Offset = "0x25F60B0", VA = "0x1825F74B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x25F7500", Offset = "0x25F6100", VA = "0x1825F7500")]
		internal ICNABOLFFAD(NativeArray<KIOOBADIGHP> HOMNJBLAHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x25F73E0", Offset = "0x25F5FE0", VA = "0x1825F73E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x25F7460", Offset = "0x25F6060", VA = "0x1825F7460", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct GMFOIBNCDMF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int INMOKOCGEME = 0;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int DMKPHAPGGHI = 1;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const int KMPANHECIGI = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NativeArray<int> CEECNJJKNFO;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public int FCJONFNOICM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x25F13A0", Offset = "0x25EFFA0", VA = "0x1825F13A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x25F13F0", Offset = "0x25EFFF0", VA = "0x1825F13F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public PFPFEGKDJFL JPGIBFNJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x25F1420", Offset = "0x25F0020", VA = "0x1825F1420")]
			get
			{
				return default(PFPFEGKDJFL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x25F1380", Offset = "0x25EFF80", VA = "0x1825F1380")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool LKPKGGHNBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x25F1360", Offset = "0x25EFF60", VA = "0x1825F1360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x25F1430", Offset = "0x25F0030", VA = "0x1825F1430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool JGOHMFENHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x25F1370", Offset = "0x25EFF70", VA = "0x1825F1370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x25F1400", Offset = "0x25F0000", VA = "0x1825F1400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x25F1480", Offset = "0x25F0080", VA = "0x1825F1480")]
		public GMFOIBNCDMF(PFPFEGKDJFL DJPHDBFHGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x25F1450", Offset = "0x25F0050", VA = "0x1825F1450")]
		private int LBHEOGGFILM(int HMFFBMGNBCG, int JHFAPOJNLLL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x25F13B0", Offset = "0x25EFFB0", VA = "0x1825F13B0")]
		private void KCACFLLCKKN(int HMFFBMGNBCG, int PDMPLJICJLE, int JHFAPOJNLLL = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x25F1320", Offset = "0x25EFF20", VA = "0x1825F1320", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int PCNKNMALPIA = -1;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int MFGHKOFLDJO = 0;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly KIOOBADIGHP MKJOHNNKKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeHashMap<KIOOBADIGHP, int> JNMCKGPFIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<KIOOBADIGHP> BEMPOAOGIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<int> DCHEPHMALKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> DHMIBGDOAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NativeList<byte> CEECNJJKNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GMFOIBNCDMF OKFGJOLPNEO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LKPKGGHNBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x25FF6C0", Offset = "0x25FE2C0", VA = "0x1825FF6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool BFPAPOJMAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x25FF4F0", Offset = "0x25FE0F0", VA = "0x1825FF4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int FCJONFNOICM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x25FF9A0", Offset = "0x25FE5A0", VA = "0x1825FF9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int EHBLHIJGEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x25FF5B0", Offset = "0x25FE1B0", VA = "0x1825FF5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x25FFB10", Offset = "0x25FE710", VA = "0x1825FFB10")]
	public static LDCGGKKMNGD NEKFKHFNPIG(PFPFEGKDJFL DJPHDBFHGEK = PFPFEGKDJFL.Last, int FPAGMCOBOII = 16, int GIDHPPDDJBO = 256)
	{
		return default(LDCGGKKMNGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x25FFF50", Offset = "0x25FEB50", VA = "0x1825FFF50")]
	private LDCGGKKMNGD(PFPFEGKDJFL DJPHDBFHGEK, int FPAGMCOBOII, int GIDHPPDDJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x25FF5F0", Offset = "0x25FE1F0", VA = "0x1825FF5F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x25FF740", Offset = "0x25FE340", VA = "0x1825FF740")]
	public FFGAJLGCPJJ FMFLGJKGENA(KIOOBADIGHP CHFHFNDILMF)
	{
		return default(FFGAJLGCPJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x25FF410", Offset = "0x25FE010", VA = "0x1825FF410")]
	public IMJNAENFHBI BCPODDNHGIA(KIOOBADIGHP CHFHFNDILMF)
	{
		return default(IMJNAENFHBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x25FF830", Offset = "0x25FE430", VA = "0x1825FF830")]
	public bool HGNMKOHPFHJ(KIOOBADIGHP CHFHFNDILMF, out IMJNAENFHBI CHDNHOJEDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x25FFDF0", Offset = "0x25FE9F0", VA = "0x1825FFDF0")]
	public bool OHMAGAMBGLA(KIOOBADIGHP CHFHFNDILMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x25FF500", Offset = "0x25FE100", VA = "0x1825FF500")]
	public bool DEDCBMOAKFP(KIOOBADIGHP CHFHFNDILMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x25FF9B0", Offset = "0x25FE5B0", VA = "0x1825FF9B0")]
	public void KHBGDDIDBGF(NativeList<byte> OEMDOONMCAB, MEALGONGCGH BHMAHHDPLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2248540", Offset = "0x2247140", VA = "0x182248540")]
	public T ELNOFIGJJCO<T>(KIOOBADIGHP CHFHFNDILMF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x25FFA80", Offset = "0x25FE680", VA = "0x1825FFA80")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x25FF6D0", Offset = "0x25FE2D0", VA = "0x1825FF6D0")]
	public ICNABOLFFAD FIAIDFFFPCH()
	{
		return default(ICNABOLFFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x25FFC30", Offset = "0x25FE830", VA = "0x1825FFC30")]
	private void NPNAFMPDDKL(KIOOBADIGHP CHFHFNDILMF, int DJHHNCHEKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x25FF350", Offset = "0x25FDF50", VA = "0x1825FF350")]
	private void AFHBBEOFCFD(int FBBKDGKNIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x25FFB70", Offset = "0x25FE770", VA = "0x1825FFB70")]
	private void NJKMFOAGHMD(KIOOBADIGHP CHFHFNDILMF, int DJHHNCHEKKB, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2248690", Offset = "0x2247290", VA = "0x182248690")]
	private static T ELNOFIGJJCO<T>(NativeArray<byte> MPENDCAONOC, int HMFFBMGNBCG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x25FFE90", Offset = "0x25FEA90", VA = "0x1825FFE90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x25FFE40", Offset = "0x25FEA40", VA = "0x1825FFE40", Slot = "4")]
	private IEnumerator<KIOOBADIGHP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HLGOHLFGMFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> MPENDCAONOC;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public HLGOHLFGMFP(NativeArray<byte> MPENDCAONOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x25F46F0", Offset = "0x25F32F0", VA = "0x1825F46F0")]
	public static HLGOHLFGMFP EDHAFEIJFCP(NativeArray<byte> MPENDCAONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	public T DICJDEAEFBM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	public NativeArray<T> GFEBBJDHFMA<T>(int LIJNMPAFKGC, Allocator KIPGDNHHBGE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> OOBGILFDFMI<T>(Allocator KIPGDNHHBGE) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ECMKNPGCFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> MPENDCAONOC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public ECMKNPGCFDI(NativeArray<byte> MPENDCAONOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2276F90", Offset = "0x2275B90", VA = "0x182276F90")]
	public static ECMKNPGCFDI EDHAFEIJFCP(NativeArray<byte> MPENDCAONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x33D53A0", Offset = "0x33D3FA0", VA = "0x1833D53A0")]
	public T DICJDEAEFBM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	public NativeArray<T> GFEBBJDHFMA<T>(int LIJNMPAFKGC, Allocator KIPGDNHHBGE) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CFCHMAFCPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeArray<byte> MPENDCAONOC;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public CFCHMAFCPCM(NativeArray<byte> MPENDCAONOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2273E40", Offset = "0x2272A40", VA = "0x182273E40")]
	public static CFCHMAFCPCM EDHAFEIJFCP(NativeArray<byte> MPENDCAONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2E29B10", Offset = "0x2E28710", VA = "0x182E29B10")]
	public void OEBDOIHBHPP<T>(in T PDMPLJICJLE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2E29A00", Offset = "0x2E28600", VA = "0x182E29A00")]
	public void MOFJJLMMNLN<T>(NativeArray<T> HOMNJBLAHAL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	public void ACHGAHBOKEP<T>(NativeArray<T> PDMPLJICJLE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NIACEJMKLNB
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2561C90", Offset = "0x2560890", VA = "0x182561C90")]
	public static Span<byte> KBMHIKNICEN(this NativeArray<byte> MPENDCAONOC)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2561F50", Offset = "0x2560B50", VA = "0x182561F50")]
	public static ReadOnlySpan<byte> OHPIIJCGLFE(this NativeArray<byte> MPENDCAONOC)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2561E00", Offset = "0x2560A00", VA = "0x182561E00")]
	public static NativeArray<byte> KOKOLKMFNOD(this NativeArray<byte> MPENDCAONOC, int DJHHNCHEKKB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2561C20", Offset = "0x2560820", VA = "0x182561C20")]
	public static NativeArray<byte> FOBMAHNBJBE(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFBE0", Offset = "0x2FBE7E0", VA = "0x182FBFBE0")]
	public static NativeArray<byte> FOBMAHNBJBE<T>(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2561EE0", Offset = "0x2560AE0", VA = "0x182561EE0")]
	public static NativeArray<byte> NEFNKGKLJBL(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x36531C0", Offset = "0x3651DC0", VA = "0x1836531C0")]
	public static NativeArray<byte> NEFNKGKLJBL<T>(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2561E70", Offset = "0x2560A70", VA = "0x182561E70")]
	public static NativeArray<byte> MBCKNFGPNKE(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3651D20", Offset = "0x3650920", VA = "0x183651D20")]
	public static NativeArray<byte> MBCKNFGPNKE<T>(this NativeArray<byte> MPENDCAONOC, int GCKMDOIKFCL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class EJKOLDEPKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private NativeList<byte> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xD5CB80", Offset = "0xD5B780", VA = "0x180D5CB80")]
	public EJKOLDEPKOK(NativeList<byte> EJNJGLOFIFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x22792C0", Offset = "0x2277EC0", VA = "0x1822792C0")]
	public static EJKOLDEPKOK EDHAFEIJFCP(NativeList<byte> MPENDCAONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	public void OEBDOIHBHPP<T>(in T PDMPLJICJLE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	public void MOFJJLMMNLN<T>(NativeArray<T> PDMPLJICJLE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	public void ACHGAHBOKEP<T>(NativeArray<T> PDMPLJICJLE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[PCJLLMMMFMG(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.PropertyChanges)]
	public class PropertyChangeNetworkRouter : BHNKHJBOFIN, GLEEPPGLLOC, JMPGJCCPFPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private LDOPFOKNOLJ PDAHFHABHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MPHEKEAEHAM BFKGLJCKHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private PAKOKDDGBAI OHOCCAOGOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AKLLJKPOLKI JJBKJENHHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private KIOOBADIGHP OBEDCGEEEIB;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public LDOPFOKNOLJ AELBFCJNICH
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x256B610", Offset = "0x256A210", VA = "0x18256B610")]
		public LDOPFOKNOLJ.KCFPPAJEIBC FABCOCFOMCN()
		{
			return default(LDOPFOKNOLJ.KCFPPAJEIBC);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x256B9B0", Offset = "0x256A5B0", VA = "0x18256B9B0", Slot = "4")]
		public void HBGKEGAFJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x256B4F0", Offset = "0x256A0F0", VA = "0x18256B4F0", Slot = "5")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x256BA60", Offset = "0x256A660", VA = "0x18256BA60")]
		public void HIOHLGIEIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x256B630", Offset = "0x256A230", VA = "0x18256B630")]
		private void FMFLGJKGENA(KIOOBADIGHP CHFHFNDILMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x256B880", Offset = "0x256A480", VA = "0x18256B880")]
		private void GDOGMDFCHEO(KIOOBADIGHP CHFHFNDILMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x256B5B0", Offset = "0x256A1B0", VA = "0x18256B5B0")]
		private void EDLKHNCPJBP(KIOOBADIGHP CHFHFNDILMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x256BBB0", Offset = "0x256A7B0", VA = "0x18256BBB0")]
		private void JDIAPMLJCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x256BA40", Offset = "0x256A640", VA = "0x18256BA40")]
		private void HECODCAKEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x256BBD0", Offset = "0x256A7D0", VA = "0x18256BBD0")]
		private void KMPECDLKMOE(KIOOBADIGHP CHFHFNDILMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x22303B0", Offset = "0x222EFB0", VA = "0x1822303B0", Slot = "6")]
		private void PDCIIKIGCAI<TKey, T>(global::OIOLNNEPNFJ<TKey, T> EAIGMDJHNBA, object BGDHIGEIIHJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x256B580", Offset = "0x256A180", VA = "0x18256B580", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PCJLLMMMFMG(typeof(IKJLIJBBHIC), new string[] { })]
public class IKJLIJBBHIC : GLEEPPGLLOC, MJAFAPEAAKM
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AEGJGNOICJK IKKPJHADEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private PBLGGEBLEDD FCIOLACIEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private MACMHPECBIO OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HNCMIACNIJA CKEALBHLMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private PropertyChangeNetworkRouter IOFLDANCGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private GBEPIPMPHEG BBCLONIFPJI;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x25F91A0", Offset = "0x25F7DA0", VA = "0x1825F91A0", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x25F9600", Offset = "0x25F8200", VA = "0x1825F9600", Slot = "5")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x25F9530", Offset = "0x25F8130", VA = "0x1825F9530")]
	public void GNDBCCFLEHM(EEDOLIFAKPN NDMJKBJOMGA, JCLNMMLEPOP IBGKMLNBJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x25F9800", Offset = "0x25F8400", VA = "0x1825F9800")]
	public void PMHMEELAPCD(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK, in BNKGCKPKCFJ NJJLOKBHGMC, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x25F96D0", Offset = "0x25F82D0", VA = "0x1825F96D0")]
	public void OPGJEKDFOID(EEDOLIFAKPN NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x25F9370", Offset = "0x25F7F70", VA = "0x1825F9370")]
	private void EAHFHKCHBGH(EEDOLIFAKPN NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x25F9250", Offset = "0x25F7E50", VA = "0x1825F9250")]
	public void CHFNPDPKBMM(EEDOLIFAKPN NDMJKBJOMGA, GBEPIPMPHEG MKJDELBEPBK, in BNKGCKPKCFJ NJJLOKBHGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x25F9420", Offset = "0x25F8020", VA = "0x1825F9420")]
	private void EGKEMDJDNCJ(EEDOLIFAKPN NDMJKBJOMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x25F98D0", Offset = "0x25F84D0", VA = "0x1825F98D0")]
	public IKJLIJBBHIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class BCAOKNJMPFM : GLEEPPGLLOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private HEINBCBJOCN NACNPKFGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private uint LOBACPAMGAB;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract uint GFKFDMIBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x226BDD0", Offset = "0x226A9D0", VA = "0x18226BDD0", Slot = "7")]
	public virtual void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x226BEC0", Offset = "0x226AAC0", VA = "0x18226BEC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x226BE70", Offset = "0x226AA70", VA = "0x18226BE70")]
	public EEDOLIFAKPN DHMMPBCGGNC()
	{
		return default(EEDOLIFAKPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x226BF50", Offset = "0x226AB50", VA = "0x18226BF50")]
	public void GLHLPLEGPOD(EEDOLIFAKPN LLAJIFDKLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x226BF40", Offset = "0x226AB40", VA = "0x18226BF40", Slot = "8")]
	public virtual void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected BCAOKNJMPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PCJLLMMMFMG(typeof(JFPLKGANNDJ), new string[] { })]
internal sealed class JFPLKGANNDJ : BCAOKNJMPFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private uint NIEIMPEMMMI;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override uint GFKFDMIBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5E5390", Offset = "0x5E3F90", VA = "0x1805E5390", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x25FBAF0", Offset = "0x25FA6F0", VA = "0x1825FBAF0", Slot = "7")]
	public override void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x25FBBF0", Offset = "0x25FA7F0", VA = "0x1825FBBF0")]
	private void OGCFPJOBADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x25FBB90", Offset = "0x25FA790", VA = "0x1825FBB90", Slot = "8")]
	public override void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public JFPLKGANNDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[PCJLLMMMFMG(typeof(NLIGFDOHODI), new string[] { })]
internal sealed class NLIGFDOHODI : BCAOKNJMPFM
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public override uint GFKFDMIBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x611E80", Offset = "0x610A80", VA = "0x180611E80", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public NLIGFDOHODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[PCJLLMMMFMG(typeof(GFPDCLAMEDA), new string[] { })]
public class HPLBBKGGOJE : GFPDCLAMEDA
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x25F7240", Offset = "0x25F5E40", VA = "0x1825F7240", Slot = "5")]
	public void GAECBPCAOLB(object EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x25F7090", Offset = "0x25F5C90", VA = "0x1825F7090", Slot = "6")]
	public void ALLFGEGFHHN(object EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x25F7300", Offset = "0x25F5F00", VA = "0x1825F7300", Slot = "7")]
	public void OJPPLBKDGHP(object EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x25F7150", Offset = "0x25F5D50", VA = "0x1825F7150", Slot = "4")]
	public IDisposable FCGEFCGICOD(object EHGGIAFACBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HPLBBKGGOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[PCJLLMMMFMG(typeof(PEMMOOCPOFD), new string[] { })]
[APAIBGLBFHK(typeof(DJFBKNFJCKG))]
internal sealed class PEMMOOCPOFD : OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery ODLHPPHGLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery KLCANOLIBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityQuery KLHPAIPJPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x256A700", Offset = "0x2569300", VA = "0x18256A700")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EntityQuery NGDPCHAMKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10AE970", Offset = "0x10AD570", VA = "0x1810AE970")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public EntityQuery BCJAJMFNMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C70", Offset = "0x8E4870", VA = "0x1808E5C70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery HPNMMJHJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x256A750", Offset = "0x2569350", VA = "0x18256A750")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int HNCHGLFGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x256A1D0", Offset = "0x2568DD0", VA = "0x18256A1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int JFLOFAHMGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x256A130", Offset = "0x2568D30", VA = "0x18256A130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OOJKMGFNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x256A7D0", Offset = "0x25693D0", VA = "0x18256A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x256A150", Offset = "0x2568D50", VA = "0x18256A150", Slot = "5")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x256A380", Offset = "0x2568F80", VA = "0x18256A380", Slot = "6")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x256A230", Offset = "0x2568E30", VA = "0x18256A230")]
	public EGFIHJFLGFK FKHBHEAMMJP()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x256A550", Offset = "0x2569150", VA = "0x18256A550")]
	public EGFIHJFLGFK ICKIJLGBDKD()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x256A950", Offset = "0x2569550", VA = "0x18256A950")]
	public EGFIHJFLGFK OCKFELNCJCE()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x256A8A0", Offset = "0x25694A0", VA = "0x18256A8A0")]
	public PJMGKLOCDGA MKDPNGGDPBH(GDHDBKNKOKH NDMJKBJOMGA)
	{
		return default(PJMGKLOCDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x256A7F0", Offset = "0x25693F0", VA = "0x18256A7F0")]
	public PJMGKLOCDGA MKDPNGGDPBH(Entity NNCGIOJNJIH)
	{
		return default(PJMGKLOCDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x256A650", Offset = "0x2569250", VA = "0x18256A650")]
	public GGPLMDHKFKM JDBNKLLLKBM(Entity NNCGIOJNJIH)
	{
		return default(GGPLMDHKFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x256A1F0", Offset = "0x2568DF0", VA = "0x18256A1F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x256A2D0", Offset = "0x2568ED0", VA = "0x18256A2D0")]
	private EGFIHJFLGFK GAIGEHLFPGD(EntityQuery CLMPDPEACMB)
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x256A9F0", Offset = "0x25695F0", VA = "0x18256A9F0")]
	public PEMMOOCPOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[PCJLLMMMFMG(typeof(ALMILKEKENF), new string[] { })]
public class LMJOFHJHPED : GLEEPPGLLOC, ALMILKEKENF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectLifecycleService LNMLGEFGGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectEmbodimentService LIKJOLDFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectPrefabCreationService CEGBCPNNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private ObjectNetworkToLocalMapService CCIEDGODKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private PEMMOOCPOFD GBIHOJOKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HEINBCBJOCN NACNPKFGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AKDHBKEIEHJ GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x255B770", Offset = "0x255A370", VA = "0x18255B770", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x255C3B0", Offset = "0x255AFB0", VA = "0x18255C3B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int HNCHGLFGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x255B6F0", Offset = "0x255A2F0", VA = "0x18255B6F0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int JFLOFAHMGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x255B220", Offset = "0x2559E20", VA = "0x18255B220", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int OOJKMGFNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x255C5D0", Offset = "0x255B1D0", VA = "0x18255C5D0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int EMGDEOMHNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x255C330", Offset = "0x255AF30", VA = "0x18255C330", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LICBKFNLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x255CBE0", Offset = "0x255B7E0", VA = "0x18255CBE0", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GDHDBKNKOKH, GGPLMDHKFKM> PIBHLJBILEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x255B130", Offset = "0x2559D30", VA = "0x18255B130", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x255BA40", Offset = "0x255A640", VA = "0x18255BA40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GDHDBKNKOKH> AGKAIIOCPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x255BCA0", Offset = "0x255A8A0", VA = "0x18255BCA0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x255B580", Offset = "0x255A180", VA = "0x18255B580", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x255B390", Offset = "0x2559F90", VA = "0x18255B390", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x255C400", Offset = "0x255B000", VA = "0x18255C400")]
	private void LDJINKMDCIB(Entity NNCGIOJNJIH, GGPLMDHKFKM DFPCAFCOFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x255B250", Offset = "0x2559E50", VA = "0x18255B250")]
	private void AMEHELJEALC(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x255C600", Offset = "0x255B200", VA = "0x18255C600")]
	internal GDHDBKNKOKH MJMODDAMGCD(Entity NNCGIOJNJIH)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x255C7C0", Offset = "0x255B3C0", VA = "0x18255C7C0", Slot = "36")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private void MJKIDDCFCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x255B7C0", Offset = "0x255A3C0", VA = "0x18255B7C0", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x255BD40", Offset = "0x255A940", VA = "0x18255BD40", Slot = "11")]
	public EGFIHJFLGFK FKHBHEAMMJP()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x255BEC0", Offset = "0x255AAC0", VA = "0x18255BEC0", Slot = "41")]
	public EGFIHJFLGFK ICKIJLGBDKD()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x255CAA0", Offset = "0x255B6A0", VA = "0x18255CAA0", Slot = "42")]
	public EGFIHJFLGFK OCKFELNCJCE()
	{
		return default(EGFIHJFLGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x255C630", Offset = "0x255B230", VA = "0x18255C630", Slot = "12")]
	public PJMGKLOCDGA MKDPNGGDPBH(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(PJMGKLOCDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x255C220", Offset = "0x255AE20", VA = "0x18255C220", Slot = "13")]
	public GGPLMDHKFKM JDBNKLLLKBM(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(GGPLMDHKFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x255C5A0", Offset = "0x255B1A0", VA = "0x18255C5A0", Slot = "35")]
	public bool MDNKFKLILBA(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x255B0E0", Offset = "0x2559CE0", VA = "0x18255B0E0", Slot = "31")]
	public void ACBDHJAGILA(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x255B720", Offset = "0x255A320", VA = "0x18255B720", Slot = "32")]
	public void CPAKPCECLGL(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x255C1A0", Offset = "0x255ADA0", VA = "0x18255C1A0", Slot = "33")]
	public void IEPLAPCAJCO(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x255CB50", Offset = "0x255B750", VA = "0x18255CB50", Slot = "37")]
	public void OGAKNNNGOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x255BE40", Offset = "0x255AA40", VA = "0x18255BE40", Slot = "25")]
	public JHMPJMIHIEB GNDBCCFLEHM(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(JHMPJMIHIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x255B620", Offset = "0x255A220", VA = "0x18255B620", Slot = "26")]
	public JHMPJMIHIEB CDKLHBJFFCM(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(JHMPJMIHIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x255C4C0", Offset = "0x255B0C0", VA = "0x18255C4C0", Slot = "27")]
	public JHMPJMIHIEB LOHNFJICDGO(EEDOLIFAKPN PLIJDIMDLMI, GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(JHMPJMIHIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x255BAE0", Offset = "0x255A6E0", VA = "0x18255BAE0", Slot = "28")]
	public FGPEFBCCMDJ EGCGJPFDOJL()
	{
		return default(FGPEFBCCMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x255C9A0", Offset = "0x255B5A0", VA = "0x18255C9A0", Slot = "43")]
	public JCFAIICBHNH NPFGAHHPCIJ(MKMAJNKPPKN HCPDGKICMEB)
	{
		return default(JCFAIICBHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x255C260", Offset = "0x255AE60", VA = "0x18255C260", Slot = "29")]
	public DJJKEEOINPH JENKFHCCNKM()
	{
		return default(DJJKEEOINPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x255C6F0", Offset = "0x255B2F0", VA = "0x18255C6F0", Slot = "30")]
	public MDDKAKCGDGB MKIOGIKCIDJ(AGOBHJFJLNP HCPDGKICMEB)
	{
		return default(MDDKAKCGDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x255C4A0", Offset = "0x255B0A0", VA = "0x18255C4A0", Slot = "15")]
	public void LGPGOGPHNHB(EEDOLIFAKPN PLIJDIMDLMI, CICKPBCENCE ODBAAACEKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x255BB90", Offset = "0x255A790", VA = "0x18255BB90", Slot = "16")]
	public JHMPJMIHIEB FAKHDFKFALL(GDHDBKNKOKH IFPFHNLOHFM, [Optional] object BNKIDKMECMP)
	{
		return default(JHMPJMIHIEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x255C1D0", Offset = "0x255ADD0", VA = "0x18255C1D0", Slot = "17")]
	public bool IJBPKLGCINO(GDHDBKNKOKH IFPFHNLOHFM, out CICKPBCENCE FADBLLIMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x255B300", Offset = "0x2559F00", VA = "0x18255B300", Slot = "45")]
	public Transform BIABPPENGKD(GDHDBKNKOKH IFPFHNLOHFM, [Optional] object BNKIDKMECMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x255B6A0", Offset = "0x255A2A0", VA = "0x18255B6A0", Slot = "19")]
	public bool CEPHPONIACJ(GDHDBKNKOKH IFPFHNLOHFM, out Transform DMEEHMHNHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x255CBA0", Offset = "0x255B7A0", VA = "0x18255CBA0", Slot = "20")]
	public bool PGHOMBCKNOP(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x255CA50", Offset = "0x255B650", VA = "0x18255CA50")]
	public bool OAACJNGPADG(CICKPBCENCE PDMPLJICJLE, [Optional] object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x255CA70", Offset = "0x255B670", VA = "0x18255CA70", Slot = "46")]
	public bool OAACJNGPADG(GDHDBKNKOKH IFPFHNLOHFM, [Optional] object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x255B2E0", Offset = "0x2559EE0", VA = "0x18255B2E0", Slot = "47")]
	public void BCKJFCHEDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x255BFE0", Offset = "0x255ABE0", VA = "0x18255BFE0", Slot = "18")]
	public void IENOGAEPMEK(CICKPBCENCE HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x255C350", Offset = "0x255AF50", VA = "0x18255C350", Slot = "48")]
	public void JKJJKFIJGAL(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x255C980", Offset = "0x255B580", VA = "0x18255C980", Slot = "21")]
	public void NOCELDNAFKF(Entity NNCGIOJNJIH, object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x255BDF0", Offset = "0x255A9F0", VA = "0x18255BDF0", Slot = "22")]
	public bool FPAPHAHKCPI(Entity NNCGIOJNJIH, object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x255C390", Offset = "0x255AF90", VA = "0x18255C390", Slot = "49")]
	public bool KLBLGODKIIG(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x255CB80", Offset = "0x255B780", VA = "0x18255CB80", Slot = "50")]
	public bool PDCIHMALEMC(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x255B1D0", Offset = "0x2559DD0", VA = "0x18255B1D0", Slot = "34")]
	public NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)> AFDKJCKHECB(NativeArray<GDHDBKNKOKH> HIMBCNPDLCF, Allocator KIPGDNHHBGE)
	{
		return default(NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x255BE10", Offset = "0x255AA10", VA = "0x18255BE10", Slot = "24")]
	public EEDOLIFAKPN GHJADADNKKE(GDHDBKNKOKH IFPFHNLOHFM)
	{
		return default(EEDOLIFAKPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x255B350", Offset = "0x2559F50", VA = "0x18255B350", Slot = "23")]
	public GDHDBKNKOKH BLAKDJDJKFD(EEDOLIFAKPN PLIJDIMDLMI)
	{
		return default(GDHDBKNKOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public LMJOFHJHPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[PCJLLMMMFMG(typeof(OFMBKHHKHGK), new string[] { })]
internal sealed class OFMBKHHKHGK : GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private ObjectPrefabCreationService CEGBCPNNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PEMMOOCPOFD GBIHOJOKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IMONMIBPEJJ DFJHEIJOIKC;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2565F00", Offset = "0x2564B00", VA = "0x182565F00", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2565DD0", Offset = "0x25649D0", VA = "0x182565DD0")]
	public NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)> AFDKJCKHECB(NativeArray<GDHDBKNKOKH> HIMBCNPDLCF, Allocator KIPGDNHHBGE)
	{
		return default(NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2565FB0", Offset = "0x2564BB0", VA = "0x182565FB0")]
	private void CBDFCAEBJGM(NativeMultiHashMap<int, (GDHDBKNKOKH src, GDHDBKNKOKH dst)> BGINGBKBDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x25662C0", Offset = "0x2564EC0", VA = "0x1825662C0")]
	private void INEPHCGBDBM(NativeMultiHashMap<int, (GDHDBKNKOKH src, GDHDBKNKOKH dst)> BGINGBKBDDF, int DFPCAFCOFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2566140", Offset = "0x2564D40", VA = "0x182566140")]
	private void FJGAPKODAJB(NativeMultiHashMap<int, (GDHDBKNKOKH src, GDHDBKNKOKH dst)> BGINGBKBDDF, int DFPCAFCOFNA, EFCKPAPAFFN OHOCCAOGOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x25664C0", Offset = "0x25650C0", VA = "0x1825664C0")]
	private NativeMultiHashMap<int, (GDHDBKNKOKH, GDHDBKNKOKH)> JNMPHOMCLFN(Allocator KIPGDNHHBGE, NativeArray<GDHDBKNKOKH> HIMBCNPDLCF, out NativeArray<(GDHDBKNKOKH src, GDHDBKNKOKH dst)> LPHBGNMKMFG)
	{
		return default(NativeMultiHashMap<int, (GDHDBKNKOKH, GDHDBKNKOKH)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OFMBKHHKHGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PCJLLMMMFMG(typeof(AKAOKGPBCEI), new string[] { })]
public class JHGECJNLOOA : GLEEPPGLLOC, AKAOKGPBCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private KIBLKIBMNHJ CBAGFOMEBCK;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x25FBFE0", Offset = "0x25FABE0", VA = "0x1825FBFE0", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x25FC070", Offset = "0x25FAC70", VA = "0x1825FC070", Slot = "5")]
	public void EMHKNDEMCOP(GDHDBKNKOKH IFPFHNLOHFM, Vector3 NAMHFPEGFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x25FC120", Offset = "0x25FAD20", VA = "0x1825FC120", Slot = "6")]
	public bool PKCKLOFILLL(GDHDBKNKOKH IFPFHNLOHFM, out Collider DDOMPBPGFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JHGECJNLOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class LDJEGBKGLPJ : HGFCOFPNCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly string ILNDHPJOMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly LDJEGBKGLPJ GAKIBBPAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly List<LDJEGBKGLPJ> IPOKHFNDFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly List<EFJFACGMOLK> OHOCCAOGOIA;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string DOBBKHKKDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public HGFCOFPNCDO FHLAPECMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IEnumerable<HGFCOFPNCDO> DLKPNKKPMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IEnumerable<EFJFACGMOLK> DKCAICEFIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2600230", Offset = "0x25FEE30", VA = "0x182600230")]
	public LDJEGBKGLPJ(string AMDKCMALAFD, LDJEGBKGLPJ PPHLLODMENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[APAIBGLBFHK(typeof(LGGFDALMHNK))]
[PCJLLMMMFMG(typeof(MNCOJIFMMHE), new string[] { })]
public sealed class HPBDOHKGEEH : MNCOJIFMMHE, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class IEMGANMFKEI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x25F7AA0", Offset = "0x25F66A0", VA = "0x1825F7AA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0D7D0", Offset = "0xA0C3D0", VA = "0x180A0D7D0")]
		[DebuggerHidden]
		public IEMGANMFKEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x25F77A0", Offset = "0x25F63A0", VA = "0x1825F77A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x25F7A50", Offset = "0x25F6650", VA = "0x1825F7A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x25F79B0", Offset = "0x25F65B0", VA = "0x1825F79B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x25F79B0", Offset = "0x25F65B0", VA = "0x1825F79B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly FLGCFDICFAJ PFAKJLCOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<string, LDJEGBKGLPJ> AANLEAJIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LGGFDALMHNK OHOCCAOGOIA;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HGFCOFPNCDO MLFCGDPCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x25F6260", Offset = "0x25F4E60", VA = "0x1825F6260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F6790", Offset = "0x25F5390", VA = "0x1825F6790", Slot = "6")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x25F6900", Offset = "0x25F5500", VA = "0x1825F6900", Slot = "7")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F68B0", Offset = "0x25F54B0", VA = "0x1825F68B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x25F6440", Offset = "0x25F5040", VA = "0x1825F6440")]
	private void BJBLMBAFCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x25F62C0", Offset = "0x25F4EC0", VA = "0x1825F62C0")]
	private void BFDDBDPBGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x25F6DE0", Offset = "0x25F59E0", VA = "0x1825F6DE0")]
	private LDJEGBKGLPJ PHDNEJJFABF(string GLIPDEMIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x25F6260", Offset = "0x25F4E60", VA = "0x1825F6260")]
	private LDJEGBKGLPJ HLOJICGLJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x25F6A10", Offset = "0x25F5610", VA = "0x1825F6A10")]
	private LDJEGBKGLPJ LMJJCAJKIAO(string GLIPDEMIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x25F6C60", Offset = "0x25F5860", VA = "0x1825F6C60")]
	private LDJEGBKGLPJ NJDLNBOBOJA(string BMKGDMDCJNI, string BNKIDKMECMP, [Optional] LDJEGBKGLPJ GAKIBBPAJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x25F6720", Offset = "0x25F5320", VA = "0x1825F6720")]
	[IteratorStateMachine(typeof(IEMGANMFKEI))]
	private IEnumerable<(string, string)> BJEAOFMMBLJ(string GLIPDEMIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x25F69C0", Offset = "0x25F55C0", VA = "0x1825F69C0")]
	private bool LDPEIGGFMLD(EFJFACGMOLK EAIGMDJHNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x25F6F10", Offset = "0x25F5B10", VA = "0x1825F6F10")]
	private FLGCFDICFAJ PMOJNIJHFOM(EFJFACGMOLK EAIGMDJHNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x25F6860", Offset = "0x25F5460", VA = "0x1825F6860")]
	private FLGCFDICFAJ DHHJGBBLBCA(EFJFACGMOLK EAIGMDJHNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x25F67F0", Offset = "0x25F53F0", VA = "0x1825F67F0")]
	private FLGCFDICFAJ DDIGIKNPCIE(EFJFACGMOLK EAIGMDJHNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x33DAD70", Offset = "0x33D9970", VA = "0x1833DAD70")]
	private T PNMFPLGCLIK<T>(EFJFACGMOLK EAIGMDJHNBA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x25F6E40", Offset = "0x25F5A40", VA = "0x1825F6E40")]
	private FieldInfo PLCGPMNEFEK(EFJFACGMOLK EAIGMDJHNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x25F6FD0", Offset = "0x25F5BD0", VA = "0x1825F6FD0")]
	public HPBDOHKGEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x25F6920", Offset = "0x25F5520", VA = "0x1825F6920")]
	[CompilerGenerated]
	private int HGNDBMKHCLF(EFJFACGMOLK GBHOMBFJPAG, EFJFACGMOLK DBJNEGCCKCM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[APAIBGLBFHK(typeof(JJDGAPFNOOH))]
[PCJLLMMMFMG(typeof(MACMHPECBIO), new string[] { })]
[DefaultMember("Item")]
public class LILOKEOBKJO : MACMHPECBIO, IEnumerable<PIGCJKHMOBI>, IEnumerable, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Dictionary<(Type, string), int> EJBJCCLNLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private JJDGAPFNOOH OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private KKINEDHLEJF NJJIMPMKKLN;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x26013B0", Offset = "0x25FFFB0", VA = "0x1826013B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public PIGCJKHMOBI LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x26018A0", Offset = "0x26004A0", VA = "0x1826018A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PIGCJKHMOBI LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x26018A0", Offset = "0x26004A0", VA = "0x1826018A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2601850", Offset = "0x2600450", VA = "0x182601850", Slot = "11")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2601330", Offset = "0x25FFF30", VA = "0x182601330", Slot = "12")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "13")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2601070", Offset = "0x25FFC70", VA = "0x182601070")]
	private void AJKBBHCJONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D2C450", Offset = "0x1D2B050", VA = "0x181D2C450")]
	private string IEOHDANOPAI(string AMDKCMALAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x26014E0", Offset = "0x26000E0", VA = "0x1826014E0", Slot = "7")]
	public PIGCJKHMOBI FBFJFFLNMGM(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x26015C0", Offset = "0x26001C0", VA = "0x1826015C0")]
	private bool FEOBEAODPMJ(Type BOLCPAJJPIN, string AMDKCMALAFD, out PIGCJKHMOBI JMMMLGCJDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x26013D0", Offset = "0x25FFFD0", VA = "0x1826013D0", Slot = "8")]
	public GBEPIPMPHEG EFPHMDMKILN(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return default(GBEPIPMPHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2601830", Offset = "0x2600430", VA = "0x182601830", Slot = "9")]
	public IEnumerator<PIGCJKHMOBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2601830", Offset = "0x2600430", VA = "0x182601830", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x26018C0", Offset = "0x26004C0", VA = "0x1826018C0")]
	public LILOKEOBKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[DefaultMember("Item")]
public interface MEALGONGCGH
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAPDIMOLDEH(GBEPIPMPHEG PHGKKLLIIFD, out int AABEJHHLOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
[PCJLLMMMFMG(typeof(MEALGONGCGH), new string[] { })]
[APAIBGLBFHK(typeof(PAKOKDDGBAI))]
public class NPCAOMNAMLO : GLEEPPGLLOC, MJAFAPEAAKM, MEALGONGCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<GBEPIPMPHEG, int> KIFDPAFIPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PAKOKDDGBAI OHOCCAOGOIA;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x25640B0", Offset = "0x2562CB0", VA = "0x1825640B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2564110", Offset = "0x2562D10", VA = "0x182564110", Slot = "6")]
	public bool NAPDIMOLDEH(GBEPIPMPHEG PHGKKLLIIFD, out int AABEJHHLOHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2563D90", Offset = "0x2562990", VA = "0x182563D90", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x25640A0", Offset = "0x2562CA0", VA = "0x1825640A0", Slot = "5")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2563DF0", Offset = "0x25629F0", VA = "0x182563DF0")]
	private void DGLNPKEHIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2564180", Offset = "0x2562D80", VA = "0x182564180")]
	public NPCAOMNAMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[PCJLLMMMFMG(typeof(PAKOKDDGBAI), new string[] { })]
[APAIBGLBFHK(typeof(MACMHPECBIO))]
[DefaultMember("Item")]
public class BGMCDIKGDPO : PAKOKDDGBAI, IEnumerable<APLKBADHFCN>, IEnumerable, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, JMPGJCCPFPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private MACMHPECBIO PJADBNAKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private APLKBADHFCN[] ENEKGGHPLHH;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x226C910", Offset = "0x226B510", VA = "0x18226C910", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public APLKBADHFCN LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x226CBD0", Offset = "0x226B7D0", VA = "0x18226CBD0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public APLKBADHFCN LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x226CBD0", Offset = "0x226B7D0", VA = "0x18226CBD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "10")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x226C540", Offset = "0x226B140", VA = "0x18226C540", Slot = "11")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "12")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x226C9F0", Offset = "0x226B5F0", VA = "0x18226C9F0", Slot = "6")]
	public APLKBADHFCN FBFJFFLNMGM(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x226C920", Offset = "0x226B520", VA = "0x18226C920", Slot = "7")]
	public GBEPIPMPHEG EFPHMDMKILN(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return default(GBEPIPMPHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x226CB20", Offset = "0x226B720", VA = "0x18226CB20", Slot = "8")]
	public IEnumerator<APLKBADHFCN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x226CC10", Offset = "0x226B810", VA = "0x18226CC10", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F96C60", Offset = "0x1F95860", VA = "0x181F96C60", Slot = "13")]
	public void AOBAHFDOFAJ<TKey, T>(global::OIOLNNEPNFJ<TKey, T> EAIGMDJHNBA, [Optional] object BGDHIGEIIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x226C7D0", Offset = "0x226B3D0", VA = "0x18226C7D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public BGMCDIKGDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x226CBD0", Offset = "0x226B7D0", VA = "0x18226CBD0")]
	[CompilerGenerated]
	private APLKBADHFCN KOBCCDHNDAP(int ACJHPBCLINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
[APAIBGLBFHK(typeof(MACMHPECBIO))]
[PCJLLMMMFMG(typeof(LGGFDALMHNK), new string[] { })]
public class GNLAAFACJLG : LGGFDALMHNK, IEnumerable<EFJFACGMOLK>, IEnumerable, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, JMPGJCCPFPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MACMHPECBIO PJADBNAKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private EFJFACGMOLK[] ENEKGGHPLHH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x25F1F60", Offset = "0x25F0B60", VA = "0x1825F1F60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EFJFACGMOLK LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x25F24D0", Offset = "0x25F10D0", VA = "0x1825F24D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EFJFACGMOLK LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x25F24D0", Offset = "0x25F10D0", VA = "0x1825F24D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x25F1D60", Offset = "0x25F0960", VA = "0x1825F1D60", Slot = "8")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x25F2280", Offset = "0x25F0E80", VA = "0x1825F2280", Slot = "9")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x25F1DE0", Offset = "0x25F09E0", VA = "0x1825F1DE0")]
	private EFJFACGMOLK DNPONPMFLOE(int BAOHKIGDOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x25F2080", Offset = "0x25F0C80", VA = "0x1825F2080", Slot = "4")]
	public EFJFACGMOLK FBFJFFLNMGM(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x25F1FB0", Offset = "0x25F0BB0", VA = "0x1825F1FB0", Slot = "15")]
	public GBEPIPMPHEG EFPHMDMKILN(HLHPGDAKIBK LOBDPBBMIIM)
	{
		return default(GBEPIPMPHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x25F21A0", Offset = "0x25F0DA0", VA = "0x1825F21A0", Slot = "5")]
	public IEnumerator<EFJFACGMOLK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x25F21A0", Offset = "0x25F0DA0", VA = "0x1825F21A0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x30B4860", Offset = "0x30B3460", VA = "0x1830B4860", Slot = "10")]
	public void AOBAHFDOFAJ<TKey, T>(global::OIOLNNEPNFJ<TKey, T> EAIGMDJHNBA, [Optional] object BGDHIGEIIHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x25F1EC0", Offset = "0x25F0AC0", VA = "0x1825F1EC0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public GNLAAFACJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25F24D0", Offset = "0x25F10D0", VA = "0x1825F24D0")]
	[CompilerGenerated]
	private EFJFACGMOLK KOAGGIPFMAI(int ACJHPBCLINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[PCJLLMMMFMG(typeof(JJDGAPFNOOH), new string[] { })]
[APAIBGLBFHK(typeof(DJFBKNFJCKG))]
internal class JJDGAPFNOOH : GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private MACMHPECBIO PJADBNAKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LGGFDALMHNK OIBAEKFCIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PAKOKDDGBAI JAICKDLJJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private global::BGGCDGNEJCN<EFCKPAPAFFN> FIKNJIDCALK;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public KKINEDHLEJF IFIKHAJAKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x25FC870", Offset = "0x25FB470", VA = "0x1825FC870", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x25FC9D0", Offset = "0x25FB5D0", VA = "0x1825FC9D0")]
	private void CABKKFBOJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1CA85F0", Offset = "0x1CA71F0", VA = "0x181CA85F0")]
	public T EDHNFIAIEAO<T>() where T : EFCKPAPAFFN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x25FCAC0", Offset = "0x25FB6C0", VA = "0x1825FCAC0")]
	public PIGCJKHMOBI CCFAHPPDLFP(HLHPGDAKIBK AMDKCMALAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	public global::DFKMLMGEHEE<T> CCFAHPPDLFP<T>(HLHPGDAKIBK AMDKCMALAFD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x25FCB90", Offset = "0x25FB790", VA = "0x1825FCB90")]
	public EFJFACGMOLK DAMEBEPFOKO(HLHPGDAKIBK AMDKCMALAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x23925B0", Offset = "0x23911B0", VA = "0x1823925B0")]
	public global::BEDFJHDAFAF<T> DAMEBEPFOKO<T>(HLHPGDAKIBK AMDKCMALAFD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x25FCC60", Offset = "0x25FB860", VA = "0x1825FCC60")]
	public APLKBADHFCN FMACCKBLENJ(HLHPGDAKIBK AMDKCMALAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	public global::LCNBEHPIBLD<T> FMACCKBLENJ<T>(HLHPGDAKIBK AMDKCMALAFD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JJDGAPFNOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class ONIIHDJHPKO
{
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2744F70", Offset = "0x2743B70", VA = "0x182744F70")]
	public static global::DFKMLMGEHEE<T> CCFAHPPDLFP<T>(this JJDGAPFNOOH AHPIJHDAJIA, global::IEEHKIFNEBA<T> AMDKCMALAFD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::BEDFJHDAFAF<T> DAMEBEPFOKO<T>(this JJDGAPFNOOH AHPIJHDAJIA, global::IEEHKIFNEBA<T> AMDKCMALAFD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	public static global::LCNBEHPIBLD<T> FMACCKBLENJ<T>(this JJDGAPFNOOH AHPIJHDAJIA, global::IEEHKIFNEBA<T> AMDKCMALAFD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[PCJLLMMMFMG(typeof(FNHILOKANIL), new string[] { })]
public sealed class FNHILOKANIL : GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JJFLPLKPEPB : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public JJFLPLKPEPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x22819B0", Offset = "0x22805B0", VA = "0x1822819B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2281630", Offset = "0x2280230", VA = "0x182281630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2281A50", Offset = "0x2280650", VA = "0x182281A50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2281960", Offset = "0x2280560", VA = "0x182281960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x22818D0", Offset = "0x22804D0", VA = "0x1822818D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x22818D0", Offset = "0x22804D0", VA = "0x1822818D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private const string KGLNKFDBCPH = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Dictionary<SerializableGuid, ANEJDFCHNED> PGIHGIKDKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<SerializableGuid> KDDPBNJBHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Dictionary<SerializableGuid, GameObject> CEGBCPNNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private LGGFDALMHNK OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private INGCDOCDLMD EODOOKPKGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private DMFKDOOKGAJ JHMAEGCBJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private global::AMCGIPBMOKC<ANEJDFCHNED> JJGMFBEKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GameObject KBCENADOEHA;

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x227CD60", Offset = "0x227B960", VA = "0x18227CD60", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x227D580", Offset = "0x227C180", VA = "0x18227D580", Slot = "5")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x227CE30", Offset = "0x227BA30", VA = "0x18227CE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x227D6E0", Offset = "0x227C2E0", VA = "0x18227D6E0")]
	private void JMKOEJOCEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x227DA00", Offset = "0x227C600", VA = "0x18227DA00")]
	internal void MOFAIOFDCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x227CF80", Offset = "0x227BB80", VA = "0x18227CF80")]
	private void EHCKHKAEMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x227E120", Offset = "0x227CD20", VA = "0x18227E120")]
	private void NPLEHOKDHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x227E200", Offset = "0x227CE00", VA = "0x18227E200")]
	[IteratorStateMachine(typeof(JJFLPLKPEPB))]
	private IEnumerable<RRCustomPropTag> OHEFFCOJKML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x227D150", Offset = "0x227BD50", VA = "0x18227D150")]
	private void FMOKIGHNOOJ(GDHDBKNKOKH IFPFHNLOHFM, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x227D6F0", Offset = "0x227C2F0", VA = "0x18227D6F0")]
	private void LGPGOGPHNHB(SerializableGuid EDJALHGEENI, GameObject JPIPKHMPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x227DDE0", Offset = "0x227C9E0", VA = "0x18227DDE0")]
	private void NCNKLOEAEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x227D800", Offset = "0x227C400", VA = "0x18227D800")]
	private bool MFGGMJABMPH(ANEJDFCHNED FMDLHKOJBDJ, Transform PPHLLODMENC, out GameObject CPEJHBAMMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x227D9B0", Offset = "0x227C5B0", VA = "0x18227D9B0")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x227E260", Offset = "0x227CE60", VA = "0x18227E260")]
	public FNHILOKANIL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public SerializableGuid CBPNKAJDJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x256BCB0", Offset = "0x256A8B0", VA = "0x18256BCB0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[PCJLLMMMFMG(typeof(PDDCDJBBMKP), new string[] { })]
public class LEEGJCJOIEF : PDDCDJBBMKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool IJNBOFEDMPG;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool HFAIDDALHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x60F7B0", Offset = "0x60E3B0", VA = "0x18060F7B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2600EF0", Offset = "0x25FFAF0", VA = "0x182600EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<bool> JGCKFOBFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2600E50", Offset = "0x25FFA50", VA = "0x182600E50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2600F50", Offset = "0x25FFB50", VA = "0x182600F50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public LEEGJCJOIEF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[PCJLLMMMFMG(typeof(INGCDOCDLMD), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.Serialization, new string[] { "Timing" })]
	public class SerializationService : GLEEPPGLLOC, INGCDOCDLMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private struct FMCBABOHLHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public DHDDHGGFJLE AJFPKGDIBGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public DHDDHGGFJLE CIKJAEIEKOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public DHDDHGGFJLE MNAEFCFCNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public DHDDHGGFJLE GFPDGEMCPDD;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x255A740", Offset = "0x2559340", VA = "0x18255A740")]
			public static FMCBABOHLHI MMDAHEHGHKH()
			{
				return default(FMCBABOHLHI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			[Conditional("DEBUG_WORLDS")]
			public void KHFNNCAMANL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct DHDDHGGFJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public DHDDHGGFJLE(string JONOOKFGNFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public void AGNEFBHNEGG(EntityManager JONOOKFGNFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public void KHFNNCAMANL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private const string MELBMOGNEOM = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly PEOJNAGCHAI BIIHLFCOHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private LPPHKFGPEPM NBFNONBMPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private PDDCDJBBMKP EHFBPANBAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private SerializationRemapScope DOEMKCFPEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private PEMMOOCPOFD GBIHOJOKJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private PJIIJGLAIPK JJFGNAOBGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private bool? DFGFLAPKBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private FMCBABOHLHI CJEDOEJHMED;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool NDBAMNCHAHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x256E320", Offset = "0x256CF20", VA = "0x18256E320", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x256DD30", Offset = "0x256C930", VA = "0x18256DD30", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action NBDPJEEAIDM
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x256CCF0", Offset = "0x256B8F0", VA = "0x18256CCF0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x256E170", Offset = "0x256CD70", VA = "0x18256E170", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<JKNPCDDAHDN> GOCLNMADKBA
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x256E840", Offset = "0x256D440", VA = "0x18256E840", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x256EB50", Offset = "0x256D750", VA = "0x18256EB50", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action CCCMPJGNIIA
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x256E0D0", Offset = "0x256CCD0", VA = "0x18256E0D0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x256EAB0", Offset = "0x256D6B0", VA = "0x18256EAB0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action FFCOKDAHJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x256E7A0", Offset = "0x256D3A0", VA = "0x18256E7A0", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x256C550", Offset = "0x256B150", VA = "0x18256C550", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<JKNPCDDAHDN> IMKCBNAIFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x256DBF0", Offset = "0x256C7F0", VA = "0x18256DBF0", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x256EF30", Offset = "0x256DB30", VA = "0x18256EF30", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x256CBC0", Offset = "0x256B7C0", VA = "0x18256CBC0", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x256D710", Offset = "0x256C310", VA = "0x18256D710", Slot = "11")]
		public void FANPFNKJHAO(bool HBNIBEPBNGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x256D290", Offset = "0x256BE90", VA = "0x18256D290", Slot = "13")]
		public ByteString EKJBCLFLGLG(out IDisposable DOEMKCFPEGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x256D0E0", Offset = "0x256BCE0", VA = "0x18256D0E0", Slot = "12")]
		public ByteString EKJBCLFLGLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x256EEF0", Offset = "0x256DAF0", VA = "0x18256EEF0", Slot = "16")]
		public bool OPELNPIHKCP(ByteString MHGELEHJEMC, HGCLGNGAHLP PELMCJBBFEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x256DE60", Offset = "0x256CA60", VA = "0x18256DE60", Slot = "17")]
		public bool IHBAIKPFLHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x256E210", Offset = "0x256CE10", VA = "0x18256E210", Slot = "14")]
		public void KODDGKBMAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x256C3B0", Offset = "0x256AFB0", VA = "0x18256C3B0", Slot = "27")]
		public void ABNMMNKMMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x256DF30", Offset = "0x256CB30", VA = "0x18256DF30", Slot = "15")]
		public void JGNPADKECGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x256D4F0", Offset = "0x256C0F0", VA = "0x18256D4F0", Slot = "18")]
		public bool FABODALPJAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x256D9A0", Offset = "0x256C5A0", VA = "0x18256D9A0", Slot = "19")]
		public bool GIEKIMKNNOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x256D860", Offset = "0x256C460", VA = "0x18256D860")]
		private void FHBMBACMGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x10A3B40", Offset = "0x10A2740", VA = "0x1810A3B40")]
		private void BOIJBCOHBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x256DD40", Offset = "0x256C940", VA = "0x18256DD40")]
		private void HNEDNPNGFDM(DFIKIBFBKKB OODOAHDGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x256DC90", Offset = "0x256C890", VA = "0x18256DC90")]
		private ByteString GONJEJNBNOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x256E220", Offset = "0x256CE20", VA = "0x18256E220")]
		private ByteString LAHCACONDNO(ByteString HNODBNMBHHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x256CCC0", Offset = "0x256B8C0", VA = "0x18256CCC0")]
		private bool CFGKLCPDPPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x256C850", Offset = "0x256B450", VA = "0x18256C850")]
		private void BKPIBDDBHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x256CD90", Offset = "0x256B990", VA = "0x18256CD90")]
		private void DFMHGIHJLOJ(out ByteString HNODBNMBHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x256EBF0", Offset = "0x256D7F0", VA = "0x18256EBF0")]
		private bool OJBCNPBGDEL(ByteString MHGELEHJEMC, HGCLGNGAHLP PELMCJBBFEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x256E330", Offset = "0x256CF30", VA = "0x18256E330")]
		private bool MKNNPCNENEH(ByteString MHGELEHJEMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x256E8E0", Offset = "0x256D4E0", VA = "0x18256E8E0")]
		private bool NPIDMJMBJPB(PJIIJGLAIPK.JAKOKDLOJFH.GEKMHPDLECM MNDEADLDJDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x256EFD0", Offset = "0x256DBD0", VA = "0x18256EFD0")]
		private void PKGALFJFCCB(JKNPCDDAHDN OODOAHDGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x256C7B0", Offset = "0x256B3B0", VA = "0x18256C7B0")]
		private DFIKIBFBKKB BDIMPDGCFLF(EntityManager CEDJFMGFILP, EntityManager DDDACONLNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x256C5F0", Offset = "0x256B1F0", VA = "0x18256C5F0")]
		private void AHHMCDJGHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x256E5E0", Offset = "0x256D1E0", VA = "0x18256E5E0")]
		private void MNHBKLHOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x256DCF0", Offset = "0x256C8F0", VA = "0x18256DCF0")]
		private void HFHHDKNMBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x256D910", Offset = "0x256C510", VA = "0x18256D910")]
		private PJIIJGLAIPK.JAKOKDLOJFH.GEKMHPDLECM FMNJJJOHCHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PCJLLMMMFMG(typeof(CCEOIGIGHJE), new string[] { })]
public class CCEOIGIGHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Dictionary<AGOBHJFJLNP, string> PHLKNFKLEML;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2272C80", Offset = "0x2271880", VA = "0x182272C80")]
	public GameObject GNCHPGFFOKE(AGOBHJFJLNP DPJMMKJEJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2272D30", Offset = "0x2271930", VA = "0x182272D30")]
	public CCEOIGIGHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[PCJLLMMMFMG(typeof(MNIIOGACFNJ), new string[] { })]
public class HDBJLDHDLDE : GLEEPPGLLOC, MNIIOGACFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private FFFGJFHAGNG OADFPFGCNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private PDDCDJBBMKP LBMAGJKHOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private TransformOwnershipPhase PDMJCBOMAOF;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x25F35B0", Offset = "0x25F21B0", VA = "0x1825F35B0", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x25F3B10", Offset = "0x25F2710", VA = "0x1825F3B10", Slot = "6")]
	public void NCFLFFGEHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x25F37D0", Offset = "0x25F23D0", VA = "0x1825F37D0", Slot = "5")]
	public void HFBPEMAIMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x25F38D0", Offset = "0x25F24D0", VA = "0x1825F38D0", Slot = "7")]
	public void IHFCCLDDADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x25F36D0", Offset = "0x25F22D0", VA = "0x1825F36D0", Slot = "8")]
	public void FEFPPEIOPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x25F39F0", Offset = "0x25F25F0", VA = "0x1825F39F0", Slot = "9")]
	public void KKJLEPMOILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x25F3660", Offset = "0x25F2260", VA = "0x1825F3660", Slot = "10")]
	public void CNBFBAINMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x25F3510", Offset = "0x25F2110", VA = "0x1825F3510", Slot = "11")]
	public void ABMEEPCKAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HDBJLDHDLDE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[PCJLLMMMFMG(typeof(KKNBPBMPKBC), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.TransformSyncing)]
	public class TransformService : KKNBPBMPKBC, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private KJFKLHABFME JLFPFLLINDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TransformOwnershipPhase FBNJFFAOGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private global::DFKMLMGEHEE<Entity> PPHLLODMENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private ObjectEmbodimentService BNFCLMKBNAB;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private EntityManager OOLEAOGIJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x5767FB0", Offset = "0x5766BB0", VA = "0x185767FB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private DMFKDOOKGAJ AAEMACHOPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x57653B0", Offset = "0x5763FB0", VA = "0x1857653B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5764A30", Offset = "0x5763630", VA = "0x185764A30", Slot = "32")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x57669C0", Offset = "0x57655C0", VA = "0x1857669C0", Slot = "33")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x57656E0", Offset = "0x57642E0", VA = "0x1857656E0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5769360", Offset = "0x5767F60", VA = "0x185769360", Slot = "35")]
		public bool NMBGJPHDAMA(Transform DMEEHMHNHEF, out GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5766AC0", Offset = "0x57656C0", VA = "0x185766AC0", Slot = "36")]
		public Transform HJDGHBLHALJ(Entity NNCGIOJNJIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5764E60", Offset = "0x5763A60", VA = "0x185764E60", Slot = "30")]
		public bool CEPHPONIACJ(Entity NNCGIOJNJIH, out Transform DMEEHMHNHEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x57669A0", Offset = "0x57655A0", VA = "0x1857669A0")]
		private void GOAKKKPLHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5765BC0", Offset = "0x57647C0", VA = "0x185765BC0", Slot = "29")]
		public void EHIMEJACPCG(Entity NNCGIOJNJIH, out Matrix4x4 AKNGAPPIBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x57680E0", Offset = "0x5766CE0", VA = "0x1857680E0", Slot = "4")]
		public void LHKCKMMAOID(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x57646B0", Offset = "0x57632B0", VA = "0x1857646B0")]
		private void AJLHCBCIAFD(Entity NNCGIOJNJIH, Vector3 PHMCCHPIHON, Quaternion FNKFECDNDFC, Vector3 CAJDGIOHABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5765F40", Offset = "0x5764B40", VA = "0x185765F40")]
		private void EKPNMCKIDAI(Entity NNCGIOJNJIH, Vector3 PHMCCHPIHON, Quaternion FNKFECDNDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5769C80", Offset = "0x5768880", VA = "0x185769C80", Slot = "27")]
		public void PEDCGMIKPCK(Entity NNCGIOJNJIH, out Matrix4x4 HEPOKIIGKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5769690", Offset = "0x5768290", VA = "0x185769690")]
		public void OPFAKAFKLAF(Entity NNCGIOJNJIH, in Matrix4x4 AKNGAPPIBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x57676C0", Offset = "0x57662C0", VA = "0x1857676C0")]
		private void KFPCKJLFLMO(Entity NNCGIOJNJIH, in Matrix4x4 LDPOAJNPNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x57694F0", Offset = "0x57680F0", VA = "0x1857694F0", Slot = "5")]
		public void NOKPILFMODE(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5766830", Offset = "0x5765430", VA = "0x185766830", Slot = "6")]
		public Vector3 GNHLONLHHIE(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5769D20", Offset = "0x5768920", VA = "0x185769D20", Slot = "7")]
		public void PPAHJFGLGDD(Entity NNCGIOJNJIH, Quaternion PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x57686E0", Offset = "0x57672E0", VA = "0x1857686E0", Slot = "8")]
		public Quaternion MHPOLDGPNPE(Entity NNCGIOJNJIH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5766090", Offset = "0x5764C90", VA = "0x185766090", Slot = "12")]
		public void EMPCOHANECE(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5768EF0", Offset = "0x5767AF0", VA = "0x185768EF0", Slot = "11")]
		public Vector3 NCCPJLEJJFG(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5766BE0", Offset = "0x57657E0", VA = "0x185766BE0")]
		private void HLFMFCPNPID(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5766C80", Offset = "0x5765880", VA = "0x185766C80")]
		private Vector3 ICFMBABLLKB(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x57655D0", Offset = "0x57641D0", VA = "0x1857655D0", Slot = "14")]
		public float DNMKAOABDME(Entity NNCGIOJNJIH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5766490", Offset = "0x5765090", VA = "0x185766490", Slot = "13")]
		public void FMAIGEKJFCH(Entity NNCGIOJNJIH, float PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5768400", Offset = "0x5767000", VA = "0x185768400")]
		private float LLENPKNKKDP(Entity NNCGIOJNJIH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5769C90", Offset = "0x5768890", VA = "0x185769C90")]
		private void POBJLCGJOEO(Entity NNCGIOJNJIH, float MCLGFHLPDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5769B40", Offset = "0x5768740", VA = "0x185769B40", Slot = "16")]
		public Vector3 PBBOMFEAHAF(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5764860", Offset = "0x5763460", VA = "0x185764860", Slot = "15")]
		public void ALHEFCHHJMB(Entity NNCGIOJNJIH, Vector3 FLMONCINEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5766370", Offset = "0x5764F70", VA = "0x185766370")]
		private Vector3 EOKEJCHIDFB(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x57675F0", Offset = "0x57661F0", VA = "0x1857675F0")]
		private void JPCOIFJBNGG(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5766670", Offset = "0x5765270", VA = "0x185766670")]
		[Conditional("DEBUG_BUILD")]
		private void GCMEEBGNCON(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5766D50", Offset = "0x5765950", VA = "0x185766D50", Slot = "9")]
		public void JAALMBCAEDN(Entity NNCGIOJNJIH, out Vector3 AJODAOPNJGC, out Quaternion HMDLEIFEMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x57684E0", Offset = "0x57670E0", VA = "0x1857684E0", Slot = "10")]
		public void LOEPNNIEEDN(Entity NNCGIOJNJIH, out Vector3 AJODAOPNJGC, out Quaternion HMDLEIFEMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x57690A0", Offset = "0x5767CA0", VA = "0x1857690A0", Slot = "17")]
		public void NLDOPLCOEMD(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5768D30", Offset = "0x5767930", VA = "0x185768D30", Slot = "18")]
		public Vector3 NAKJFOBIGBK(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5765080", Offset = "0x5763C80", VA = "0x185765080", Slot = "19")]
		public void CNENPBFENIK(Entity NNCGIOJNJIH, Quaternion PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5765470", Offset = "0x5764070", VA = "0x185765470", Slot = "20")]
		public Quaternion DNCDABKCAJJ(Entity NNCGIOJNJIH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5767B80", Offset = "0x5766780", VA = "0x185767B80", Slot = "22")]
		public void KJOKJHMBEEP(Entity NNCGIOJNJIH, Vector3 PDMPLJICJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5766200", Offset = "0x5764E00", VA = "0x185766200", Slot = "21")]
		public Vector3 ENCFBAFBNFK(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5764B00", Offset = "0x5763700", VA = "0x185764B00", Slot = "23")]
		public void CACNJINJAOP(Entity NNCGIOJNJIH, float OABDPKOCBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5764F00", Offset = "0x5763B00", VA = "0x185764F00", Slot = "24")]
		public float CIJAGOEOKND(Entity NNCGIOJNJIH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x57688A0", Offset = "0x57674A0", VA = "0x1857688A0", Slot = "25")]
		public void MMKGKBBIIII(Entity NNCGIOJNJIH, Vector3 GEGKENCCHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5765D90", Offset = "0x5764990", VA = "0x185765D90", Slot = "26")]
		public Vector3 EIJCECNIEAF(Entity NNCGIOJNJIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5765760", Offset = "0x5764360", VA = "0x185765760", Slot = "31")]
		public void ECAOGICOABI(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5767AC0", Offset = "0x57666C0", VA = "0x185767AC0")]
		private void KINPGBDANIM(Entity NNCGIOJNJIH, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x57678D0", Offset = "0x57664D0", VA = "0x1857678D0")]
		private void KINPGBDANIM(Entity NNCGIOJNJIH, in Entity OCKMNAKIFGM, in Entity HBOBFHIJAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5766F60", Offset = "0x5765B60", VA = "0x185766F60")]
		private OJFIKMMKJIN JAALMBCAEDN(Entity NNCGIOJNJIH)
		{
			return default(OJFIKMMKJIN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5768000", Offset = "0x5766C00", VA = "0x185768000")]
		private bool LEALOMMGODD(Entity NNCGIOJNJIH, out Entity PPHLLODMENC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5766FE0", Offset = "0x5765BE0", VA = "0x185766FE0")]
		private void JBMOAFGCPHD(Entity NNCGIOJNJIH, out Matrix4x4 AKNGAPPIBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5767270", Offset = "0x5765E70", VA = "0x185767270")]
		public void JCPCAJMBOMH(Entity NNCGIOJNJIH, out Matrix4x4 LDPOAJNPNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5769680", Offset = "0x5768280", VA = "0x185769680", Slot = "28")]
		private void OBGGPHIEPMK(Entity NNCGIOJNJIH, in Matrix4x4 HEPOKIIGKNG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[PCJLLMMMFMG(typeof(AKLLJKPOLKI), new string[] { })]
public class AKLLJKPOLKI
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct OJMGECDEMNA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly AKLLJKPOLKI PPHLLODMENC;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2282130", Offset = "0x2280D30", VA = "0x182282130")]
		public OJMGECDEMNA(AKLLJKPOLKI PPHLLODMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x22820F0", Offset = "0x2280CF0", VA = "0x1822820F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int CPOOALHMBEM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AOBAFPFGOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x11241C0", Offset = "0x1122DC0", VA = "0x1811241C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action IFCFAILGLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x226B7D0", Offset = "0x226A3D0", VA = "0x18226B7D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x226B890", Offset = "0x226A490", VA = "0x18226B890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x226B790", Offset = "0x226A390", VA = "0x18226B790")]
	public OJMGECDEMNA FABCOCFOMCN()
	{
		return default(OJMGECDEMNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x106B190", Offset = "0x1069D90", VA = "0x18106B190")]
	public void JDIAPMLJCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x226B870", Offset = "0x226A470", VA = "0x18226B870")]
	public void HECODCAKEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public AKLLJKPOLKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[PCJLLMMMFMG(typeof(DJFBKNFJCKG), new string[] { })]
[APAIBGLBFHK(typeof(HENOPHAMODO))]
public class FDMACPJOAKL : DJFBKNFJCKG, IDisposable, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OFOONJBJILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LPPHKFGPEPM services;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public OFOONJBJILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2282090", Offset = "0x2280C90", VA = "0x182282090")]
		internal void <InitReferences>b__0(GLEEPPGLLOC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CAHBFDJPAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public LPPHKFGPEPM services;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public CAHBFDJPAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2272C20", Offset = "0x2271820", VA = "0x182272C20")]
		internal void <InitExternal>b__0(MJAFAPEAAKM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly ProfilerMarker KKFNOPDNEIM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker JEFOILDMIDP;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker FFDFHOPNHIN;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly ProfilerMarker BODBOLHMAJN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly ProfilerMarker DBPBAFNFKFG;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly ProfilerMarker JFKBJOIPNOA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly ProfilerMarker IGCIFCHCOFO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly ProfilerMarker HLBDCGDKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private IMONMIBPEJJ DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IMONMIBPEJJ ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public DMFKDOOKGAJ AAEMACHOPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2279D00", Offset = "0x2278900", VA = "0x182279D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x227A690", Offset = "0x2279290", VA = "0x18227A690", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AKDHBKEIEHJ GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action PHLJNJOJOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2279D20", Offset = "0x2278920", VA = "0x182279D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x227A5F0", Offset = "0x22791F0", VA = "0x18227A5F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x227A000", Offset = "0x2278C00", VA = "0x18227A000", Slot = "21")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2279B30", Offset = "0x2278730", VA = "0x182279B30", Slot = "22")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x227A240", Offset = "0x2278E40", VA = "0x18227A240", Slot = "23")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2279C10", Offset = "0x2278810", VA = "0x182279C10", Slot = "11")]
	public void CFJDGPDNINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x227A7A0", Offset = "0x22793A0", VA = "0x18227A7A0", Slot = "12")]
	public void MCDGPGJDKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x227A500", Offset = "0x2279100", VA = "0x18227A500", Slot = "14")]
	public void KEODMLPJJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x227AA30", Offset = "0x2279630", VA = "0x18227AA30", Slot = "15")]
	public void NPEOEGLJKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x227A3E0", Offset = "0x2278FE0", VA = "0x18227A3E0", Slot = "13")]
	public void JJOOCMKMELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x227A6B0", Offset = "0x22792B0", VA = "0x18227A6B0", Slot = "16")]
	public void LEPNDECFFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x227A2F0", Offset = "0x2278EF0", VA = "0x18227A2F0", Slot = "17")]
	public void IDHBFCGNKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2279A40", Offset = "0x2278640", VA = "0x182279A40", Slot = "18")]
	public void AIINPNKLKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2279FB0", Offset = "0x2278BB0", VA = "0x182279FB0", Slot = "19")]
	public void EHJIAPPHIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x227A890", Offset = "0x2279490", VA = "0x18227A890", Slot = "24")]
	public void NCHFPGIOPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x227A8D0", Offset = "0x22794D0", VA = "0x18227A8D0")]
	private void NEKFKHFNPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2279DC0", Offset = "0x22789C0", VA = "0x182279DC0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2279FE0", Offset = "0x2278BE0", VA = "0x182279FE0", Slot = "10")]
	public ComponentSystemBase FBGIKPFBIEI(Type HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x227A4D0", Offset = "0x22790D0", VA = "0x18227A4D0")]
	public bool KDGCKAAJMHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FDMACPJOAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public class IFENFMFEFOD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Func<From, To> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Func<To, From> BOPCLAOBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public DynamicBuffer<From> GDLCFFFAFKF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public To LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	public IFENFMFEFOD(Func<From, To> DPMMEIABOCJ, Func<To, From> BOPCLAOBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BAOHKIGDOBF, To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public class EIOPAGCMHJO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly Func<From, To> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly Func<To, From> BOPCLAOBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public List<From> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public To LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D200", Offset = "0x3E1BE00", VA = "0x183E1D200", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D260", Offset = "0x3E1BE60", VA = "0x183E1D260", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D1D0", Offset = "0x3E1BDD0", VA = "0x183E1D1D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x665990", Offset = "0x664590", VA = "0x180665990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA33180", Offset = "0xA31D80", VA = "0x180A33180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2EE30E0", Offset = "0x2EE1CE0", VA = "0x182EE30E0")]
	public EIOPAGCMHJO(Func<From, To> DPMMEIABOCJ, Func<To, From> BOPCLAOBNKL, bool EGMEIMCHLPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CE20", Offset = "0x3E1BA20", VA = "0x183E1CE20", Slot = "11")]
	public void Add(To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AD30", Offset = "0x1E29930", VA = "0x181E2AD30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CE80", Offset = "0x3E1BA80", VA = "0x183E1CE80", Slot = "13")]
	public bool Contains(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CEE0", Offset = "0x3E1BAE0", VA = "0x183E1CEE0", Slot = "14")]
	public void CopyTo(To[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CFF0", Offset = "0x3E1BBF0", VA = "0x183E1CFF0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D060", Offset = "0x3E1BC60", VA = "0x183E1D060", Slot = "6")]
	public int IndexOf(To IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D0C0", Offset = "0x3E1BCC0", VA = "0x183E1D0C0", Slot = "7")]
	public void Insert(int BAOHKIGDOBF, To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D170", Offset = "0x3E1BD70", VA = "0x183E1D170", Slot = "15")]
	public bool Remove(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D140", Offset = "0x3E1BD40", VA = "0x183E1D140", Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A533B0", Offset = "0x2A51FB0", VA = "0x182A533B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public class DJGHFGIDHPJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Func<From, To> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Func<To, From> BOPCLAOBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<From> MPENDCAONOC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public To LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x22B4420", Offset = "0x22B3020", VA = "0x1822B4420", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x22B4470", Offset = "0x22B3070", VA = "0x1822B4470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x22B43E0", Offset = "0x22B2FE0", VA = "0x1822B43E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x22B4380", Offset = "0x22B2F80", VA = "0x1822B4380")]
	public DJGHFGIDHPJ(Func<From, To> DPMMEIABOCJ, Func<To, From> BOPCLAOBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B3F40", Offset = "0x22B2B40", VA = "0x1822B3F40", Slot = "11")]
	public void Add(To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x22B3F90", Offset = "0x22B2B90", VA = "0x1822B3F90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x22B3FE0", Offset = "0x22B2BE0", VA = "0x1822B3FE0", Slot = "13")]
	public bool Contains(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x22B40A0", Offset = "0x22B2CA0", VA = "0x1822B40A0", Slot = "14")]
	public void CopyTo(To[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x22B4160", Offset = "0x22B2D60", VA = "0x1822B4160", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x22B4220", Offset = "0x22B2E20", VA = "0x1822B4220", Slot = "6")]
	public int IndexOf(To IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x22B4290", Offset = "0x22B2E90", VA = "0x1822B4290", Slot = "7")]
	public void Insert(int BAOHKIGDOBF, To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x22B4330", Offset = "0x22B2F30", VA = "0x1822B4330", Slot = "15")]
	public bool Remove(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x22B42E0", Offset = "0x22B2EE0", VA = "0x1822B42E0", Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8B00", Offset = "0x1FC7700", VA = "0x181FC8B00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class KHPIEOLOGEB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Func<From, To> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Func<To, From> BOPCLAOBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeList<From> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public To LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	public KHPIEOLOGEB(Func<From, To> DPMMEIABOCJ, Func<To, From> BOPCLAOBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BAOHKIGDOBF, To IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class EBLKFONAMCG
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public const string BHFDLDNJLME = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public const string BJIEEJGFGGI = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public const string DEJCBPELHLH = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public const string OLPAPDJMGJP = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public const string JGBDHOLGGDF = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public const string MDMAJMFKJJD = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public const string HHOOJJOFFMM = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class PHCHCMLBEEM
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LDGEJLONAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public LPPHKFGPEPM services;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public LDGEJLONAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x255B020", Offset = "0x2559C20", VA = "0x18255B020")]
		internal void <InitServices>b__1(GLEEPPGLLOC svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x255B080", Offset = "0x2559C80", VA = "0x18255B080")]
		internal void <InitServices>b__2(MJAFAPEAAKM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x256AD90", Offset = "0x2569990", VA = "0x18256AD90")]
	public static void NMGBNHKAKJJ(this IMONMIBPEJJ DFJHEIJOIKC, LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x38135D0", Offset = "0x38121D0", VA = "0x1838135D0")]
	public static void OGBDJOIOJHJ<T>(this IMONMIBPEJJ DFJHEIJOIKC, Action<T> FFNJCJHPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3813640", Offset = "0x3812240", VA = "0x183813640")]
	public static void ONGDHILNCBL<T>(this IMONMIBPEJJ DFJHEIJOIKC, Action<T> FFNJCJHPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x3813810", Offset = "0x3812410", VA = "0x183813810")]
	public static void PMPEKEHCLPL<T>(this IMONMIBPEJJ DFJHEIJOIKC, Action<T> FFNJCJHPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x38131D0", Offset = "0x3811DD0", VA = "0x1838131D0")]
	public static void BIPKANIBGMG<T>(this IMONMIBPEJJ DFJHEIJOIKC, Action<T> FFNJCJHPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3813370", Offset = "0x3811F70", VA = "0x183813370")]
	public static void FHGLDHLBIFM<T>(this IMONMIBPEJJ DFJHEIJOIKC, Action<T> FFNJCJHPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3813510", Offset = "0x3812110", VA = "0x183813510")]
	private static void OFLLJHILHBH<T>(object IIIOAELMNKN, Action<T> FFNJCJHPBIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class BALIFCKJBBH
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x226BCC0", Offset = "0x226A8C0", VA = "0x18226BCC0")]
	public static Quaternion GLIOPFJJKEG(this in MOBDBBHLBGC OJJDANFEAMM, in Vector3 PNJNNEDNALB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class LNKJCDHILGO
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private const float JLIJDMIBBLO = 1E-05f;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x255E240", Offset = "0x255CE40", VA = "0x18255E240")]
	public static bool KLECOJAKMIK(this DJJKEEOINPH AIFCFJHEJLG, ShapeConfigData.Flags FAOFMGAPHDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x255E190", Offset = "0x255CD90", VA = "0x18255E190")]
	public static bool KGLKNBJOBLI(this DJJKEEOINPH AIFCFJHEJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x255CC30", Offset = "0x255B830", VA = "0x18255CC30")]
	public static bool FALMPAPJGCD(this DJJKEEOINPH AIFCFJHEJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x255E730", Offset = "0x255D330", VA = "0x18255E730")]
	public static bool PDBIFFOPLHK(Vector3 NOFLJCFDJGC, Vector3 EFOJAOIMOJA, out Vector3 ABNDCJOBBNE, bool LHDNJPODALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x255E480", Offset = "0x255D080", VA = "0x18255E480")]
	public static void ODJFHKMMKJP(this DJJKEEOINPH AIFCFJHEJLG, Vector3 CFDKADJLMGD, Quaternion ADOKJGOCFJD, float MFOJOPJIDAP, bool LMBFLBIECGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x255E2F0", Offset = "0x255CEF0", VA = "0x18255E2F0")]
	public static void MIHKNCCAAHK(this DJJKEEOINPH AIFCFJHEJLG, int AAKHFNJBFPD, Vector3 CFDKADJLMGD, Quaternion ADOKJGOCFJD, float MFOJOPJIDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x255E420", Offset = "0x255D020", VA = "0x18255E420")]
	public static void NDIBLJLHNHP(this DJJKEEOINPH AIFCFJHEJLG, Vector3 JMGJHKJODGN, Quaternion PLLJKIOLLEK, float MFOJOPJIDAP, bool LMBFLBIECGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x255D710", Offset = "0x255C310", VA = "0x18255D710")]
	private static void JNCMCDAHCOM(this DJJKEEOINPH AIFCFJHEJLG, Vector3 AJODAOPNJGC, Quaternion HMDLEIFEMBE, float MFOJOPJIDAP, bool LMBFLBIECGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x255E5B0", Offset = "0x255D1B0", VA = "0x18255E5B0")]
	private static void OJMLJEGKOFC(this DJJKEEOINPH AIFCFJHEJLG, Vector3 PHMCCHPIHON, Quaternion FNKFECDNDFC, float IHENALHLFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x255CC00", Offset = "0x255B800", VA = "0x18255CC00")]
	private static bool AMMEPFCCANL(this DJJKEEOINPH AIFCFJHEJLG, int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x255CCE0", Offset = "0x255B8E0", VA = "0x18255CCE0")]
	private static void HGFJIJIGCMK(this DJJKEEOINPH AIFCFJHEJLG, int BAOHKIGDOBF, Vector3 PHMCCHPIHON, Quaternion FNKFECDNDFC, float IHENALHLFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x255D080", Offset = "0x255BC80", VA = "0x18255D080")]
	public static Vector3 ILNFFHEFGMP(this DJJKEEOINPH AIFCFJHEJLG, int BAOHKIGDOBF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x255CFE0", Offset = "0x255BBE0", VA = "0x18255CFE0")]
	public static Quaternion IHDCOFPGPHO(this DJJKEEOINPH AIFCFJHEJLG, int BAOHKIGDOBF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class NEDIKNDAIJH
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class AGOOBDINALM
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	public static bool ACFFBFFJOOP<T>(ref T GBHOMBFJPAG, ref T DBJNEGCCKCM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class JFHDFKHCDPI
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GCIAOOAEAGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public GCIAOOAEAGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x25FB9F0", Offset = "0x25FA5F0", VA = "0x1825FB9F0")]
	public static string MHLHLLCCPJJ(Transform DMEEHMHNHEF, Transform PNGBENFNCCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class CKMCPPBCHDI : IPALCPMEFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly MethodInfo HDEKKDMACIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Type[] IHGKCAPJCJE;

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x22746A0", Offset = "0x22732A0", VA = "0x1822746A0")]
	public CKMCPPBCHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action LBKLDBCCFBP();

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22744D0", Offset = "0x22730D0", VA = "0x1822744D0")]
	public MethodInfo IODAGHDDBHD(Action FHCMCNABNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2274510", Offset = "0x2273110", VA = "0x182274510", Slot = "4")]
	public void LGPGOGPHNHB(Type HCPDGKICMEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class POJDIDOGBAF : CKMCPPBCHDI
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private enum MKEKGCGAGFJ
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x256AFC0", Offset = "0x2569BC0", VA = "0x18256AFC0", Slot = "5")]
	public override Action LBKLDBCCFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LNDBNBKCLNC<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x256AF40", Offset = "0x2569B40", VA = "0x18256AF40")]
	[Preserve]
	public void GALEIKHLEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x256B040", Offset = "0x2569C40", VA = "0x18256B040")]
	protected POJDIDOGBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class IMPOHFODKKC : CKMCPPBCHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x25F9CA0", Offset = "0x25F88A0", VA = "0x1825F9CA0", Slot = "5")]
	public override Action LBKLDBCCFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LFLLENDFAOB<T>() where T : FAACHECLGAP;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x25F9C20", Offset = "0x25F8820", VA = "0x1825F9C20")]
	[Preserve]
	public void GALEIKHLEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x256B040", Offset = "0x2569C40", VA = "0x18256B040")]
	protected IMPOHFODKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class JKNBILIGGPL : CKMCPPBCHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x25FD040", Offset = "0x25FBC40", VA = "0x1825FD040", Slot = "5")]
	public override Action LBKLDBCCFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EJDNBDKJDDD<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x25FCFC0", Offset = "0x25FBBC0", VA = "0x1825FCFC0")]
	[Preserve]
	public void GALEIKHLEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x256B040", Offset = "0x2569C40", VA = "0x18256B040")]
	protected JKNBILIGGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[PCJLLMMMFMG(typeof(AKDHBKEIEHJ), new string[] { })]
public class KLGFJENLCHL : IMMOFHNOPFP, AKDHBKEIEHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public LPPHKFGPEPM LDHJEGHECPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CAOPEEFBAOK GMMOCAFFECE
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public DJFBKNFJCKG ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HENOPHAMODO IEGAFLFABHO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public ALMILKEKENF FHHJJOHBFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public KJFKLHABFME IKFKPLOGFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public KKNBPBMPKBC JHPPONDDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5F7D70", Offset = "0x5F6970", VA = "0x1805F7D70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x67EFC0", Offset = "0x67DBC0", VA = "0x18067EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public INGCDOCDLMD KGGBPPHNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x637130", Offset = "0x635D30", VA = "0x180637130", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6719F0", Offset = "0x6705F0", VA = "0x1806719F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public FFFGJFHAGNG DOOILBENCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x608720", Offset = "0x607320", VA = "0x180608720", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x671920", Offset = "0x670520", VA = "0x180671920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PDDCDJBBMKP FLHJMFEAOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6220", Offset = "0x5F4E20", VA = "0x1805F6220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x67E370", Offset = "0x67CF70", VA = "0x18067E370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LGGFDALMHNK DKCAICEFIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA630", Offset = "0x5E9230", VA = "0x1805EA630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5F7EE0", Offset = "0x5F6AE0", VA = "0x1805F7EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public MEMHLILDHIH MBNFOBJEGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA620", Offset = "0x5E9220", VA = "0x1805EA620", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x671B80", Offset = "0x670780", VA = "0x180671B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DODMEIANOBL IACOCKJFDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x608660", Offset = "0x607260", VA = "0x180608660", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x5EA640", Offset = "0x5E9240", VA = "0x1805EA640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ODDGBIGFEAO EDKCLGGKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x608670", Offset = "0x607270", VA = "0x180608670", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5F6250", Offset = "0x5F4E50", VA = "0x1805F6250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KMGPAOBKBAH FNHNDIDALAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5F7EA0", Offset = "0x5F6AA0", VA = "0x1805F7EA0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5F6230", Offset = "0x5F4E30", VA = "0x1805F6230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AKAOKGPBCEI PEGIJPLDFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x61E080", Offset = "0x61CC80", VA = "0x18061E080", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x67F7E0", Offset = "0x67E3E0", VA = "0x18067F7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public MNIIOGACFNJ GANIPDLNAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x637140", Offset = "0x635D40", VA = "0x180637140", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BF0", Offset = "0x7C37F0", VA = "0x1807C4BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public FBJFFGFJCFH ICEBJPFOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF390", Offset = "0x6ADF90", VA = "0x1806AF390", Slot = "4")]
		get
		{
			return default(FBJFFGFJCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x25FE7B0", Offset = "0x25FD3B0", VA = "0x1825FE7B0", Slot = "5")]
	public void OBNALPGBIFA(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public KLGFJENLCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DefaultMember("Item")]
public class PANJBNKAPPE : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class LPOGHIIEPAN : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public PANJBNKAPPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x608710", Offset = "0x607310", VA = "0x180608710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x255F1E0", Offset = "0x255DDE0", VA = "0x18255F1E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public LPOGHIIEPAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x255F020", Offset = "0x255DC20", VA = "0x18255F020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x255F190", Offset = "0x255DD90", VA = "0x18255F190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected const ulong EBFPINLHLBP = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected const ulong DIKEGDLMHOM = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected const int NPICKBCCLBJ = 8;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected const int ONOMJLHDMGF = 6;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public const int NHBHKACKNMJ = 64;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected const int JCKJFBHJHIC = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly List<ulong> AMLFHPODKAJ;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x736910", Offset = "0x735510", VA = "0x180736910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int FDFCDLLJJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7368D0", Offset = "0x7354D0", VA = "0x1807368D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x736900", Offset = "0x735500", VA = "0x180736900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2569220", Offset = "0x2567E20", VA = "0x182569220")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2568B30", Offset = "0x2567730", VA = "0x182568B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2569820", Offset = "0x2568420", VA = "0x182569820")]
	public PANJBNKAPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2569890", Offset = "0x2568490", VA = "0x182569890")]
	public PANJBNKAPPE(int BKAKMOPHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2569060", Offset = "0x2567C60", VA = "0x182569060")]
	public bool JOPOJEAKNIN(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x25696B0", Offset = "0x25682B0", VA = "0x1825696B0")]
	public bool OHOOFNCPLAD(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x25692C0", Offset = "0x2567EC0", VA = "0x1825692C0")]
	public bool KMHLIPBIFII(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x25693C0", Offset = "0x2567FC0", VA = "0x1825693C0")]
	public bool MLPCDHELIGA(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2569340", Offset = "0x2567F40", VA = "0x182569340")]
	public void LBDOMPBIAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2568DE0", Offset = "0x25679E0", VA = "0x182568DE0")]
	public void DEBHFOMKECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x2569130", Offset = "0x2567D30", VA = "0x182569130")]
	public void KCACFLLCKKN(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x25693D0", Offset = "0x2567FD0", VA = "0x1825693D0")]
	public void MNHBKLHOOAC(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2569790", Offset = "0x2568390", VA = "0x182569790")]
	public bool PFBDILLHGAG(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2568CD0", Offset = "0x25678D0", VA = "0x182568CD0")]
	public void DBDDEKBIPLE(int HMFFBMGNBCG, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2569510", Offset = "0x2568110", VA = "0x182569510")]
	public void OFHGOLCPLNI(int PIMDCPHDLPC, int MHKIPJIIMLH, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2568FA0", Offset = "0x2567BA0", VA = "0x182568FA0")]
	public int JNIPLPDFDNO(int GCKMDOIKFCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2568F30", Offset = "0x2567B30", VA = "0x182568F30")]
	public int JNIPLPDFDNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x25694C0", Offset = "0x25680C0", VA = "0x1825694C0")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2568EC0", Offset = "0x2567AC0", VA = "0x182568EC0", Slot = "4")]
	[IteratorStateMachine(typeof(LPOGHIIEPAN))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2568EC0", Offset = "0x2567AC0", VA = "0x182568EC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CGMDFFEOJJP<T> : global::AJGHAHLIKAK<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected global::FHKGCLOFIDN<T> OAPKDOPENCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected global::AHEMPMHEAPE<T> HBIOGDCPDOE;

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F120", Offset = "0x1E1DD20", VA = "0x181E1F120")]
	public CGMDFFEOJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF23B0", Offset = "0x2CF0FB0", VA = "0x182CF23B0")]
	public CGMDFFEOJJP(global::FHKGCLOFIDN<T> OAPKDOPENCJ, global::AHEMPMHEAPE<T> HBIOGDCPDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2070", Offset = "0x2CF0C70", VA = "0x182CF2070", Slot = "11")]
	public override T OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1D10", Offset = "0x2CF0910", VA = "0x182CF1D10", Slot = "12")]
	public override void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML, T PDMPLJICJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class PFLDNABJEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2745140", Offset = "0x2743D40", VA = "0x182745140")]
	public static GBEPIPMPHEG LGPGOGPHNHB<T>(this BFGKPDBKBHL OHOCCAOGOIA, global::IEEHKIFNEBA<T> AMDKCMALAFD, global::FHKGCLOFIDN<T> OAPKDOPENCJ, global::AHEMPMHEAPE<T> HBIOGDCPDOE) where T : struct
	{
		return default(GBEPIPMPHEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public sealed class OCEDKGCHEPK<T> : global::CGMDFFEOJJP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2A53CD0", Offset = "0x2A528D0", VA = "0x182A53CD0")]
	public OCEDKGCHEPK(T LAKDIHOJGNM, T COIOJNIHJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class MKAANBHPEAH<T> : global::AJGHAHLIKAK<T> where T : struct, FAACHECLGAP
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x323A940", Offset = "0x3239540", VA = "0x18323A940", Slot = "11")]
	public override T OPELNPIHKCP(POBPEGAACCC DNLABCFBCML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x323A8B0", Offset = "0x32394B0", VA = "0x18323A8B0", Slot = "12")]
	public override void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBE890", VA = "0x181FBFC90")]
	public MKAANBHPEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class HBMPJDADBAL : GCKINOCNPCP
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public abstract Type EGBDHMNPEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML, in LHILGMABJGJ PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML, in BNKGCKPKCFJ PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void OFFBIIPDPNO(POBPEGAACCC DNLABCFBCML, PGPEHOGEHAH CEHJPIKDCNA, [Optional] object BGDHIGEIIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected HBMPJDADBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class AJGHAHLIKAK<T> : HBMPJDADBAL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public override Type EGBDHMNPEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2EE08A0", Offset = "0x2EDF4A0", VA = "0x182EE08A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T OPELNPIHKCP(POBPEGAACCC DNLABCFBCML);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML, T PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2260", Offset = "0x2EE0E60", VA = "0x182EE2260", Slot = "8")]
	public override void OPELNPIHKCP(POBPEGAACCC DNLABCFBCML, in LHILGMABJGJ PNGBENFNCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2EDFE90", Offset = "0x2EDEA90", VA = "0x182EDFE90", Slot = "9")]
	public override void EKJBCLFLGLG(POBPEGAACCC DNLABCFBCML, in BNKGCKPKCFJ CHFHFNDILMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2EE0FC0", Offset = "0x2EDFBC0", VA = "0x182EE0FC0", Slot = "10")]
	public override void OFFBIIPDPNO(POBPEGAACCC DNLABCFBCML, PGPEHOGEHAH CEHJPIKDCNA, object BGDHIGEIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x241E380", Offset = "0x241CF80", VA = "0x18241E380")]
	protected AJGHAHLIKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class BKPMNMEHOMA
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class PCCGAGANNMI
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class KCFCEJBEHBE<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
			public KCFCEJBEHBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x204CCF0", Offset = "0x204B8F0", VA = "0x18204CCF0")]
			internal void <RegisterFixedString>b__0(POBPEGAACCC p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x204CF20", Offset = "0x204BB20", VA = "0x18204CF20")]
			internal T <RegisterFixedString>b__1(POBPEGAACCC p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2282240", Offset = "0x2280E40", VA = "0x182282240")]
		public static void HOMDKFMEGNM(LPGJLACJGKH JLNMBMPNDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2E3BFC0", Offset = "0x2E3ABC0", VA = "0x182E3BFC0")]
		private static void KFNGBCAMBML<T>(LPGJLACJGKH JLNMBMPNDFH, int COIOJNIHJPJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2E3C0E0", Offset = "0x2E3ACE0", VA = "0x182E3C0E0")]
		private static void OPIKIKDBALJ<T>(POBPEGAACCC LMLNCGLGHJD, T MLEMCDNNOBN, int COIOJNIHJPJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D90700", Offset = "0x1D8F300", VA = "0x181D90700")]
		private static T MNCGNCLLBML<T>(POBPEGAACCC LMLNCGLGHJD, int COIOJNIHJPJ) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public PCCGAGANNMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class PKEBPCFNJMF : POJDIDOGBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private LPGJLACJGKH JLNMBMPNDFH;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x2E3C170", Offset = "0x2E3AD70", VA = "0x182E3C170", Slot = "6")]
		public override void LNDBNBKCLNC<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2282400", Offset = "0x2281000", VA = "0x182282400")]
		public static void HNALPGCCPFI(LPGJLACJGKH JLNMBMPNDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2282480", Offset = "0x2281080", VA = "0x182282480")]
		public PKEBPCFNJMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x22715C0", Offset = "0x22701C0", VA = "0x1822715C0")]
	public static void IMNGCLGFFFI(LPGJLACJGKH JLNMBMPNDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E28570", Offset = "0x2E27170", VA = "0x182E28570")]
	public static void BPNMLEMHDLL<T>(LPGJLACJGKH JLNMBMPNDFH, global::FHKGCLOFIDN<T> OAPKDOPENCJ, global::AHEMPMHEAPE<T> HBIOGDCPDOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E28600", Offset = "0x2E27200", VA = "0x182E28600")]
	public static void HPGAPBPKCCE<T>(LPGJLACJGKH DOFPJMPPGBL) where T : struct, FAACHECLGAP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface LPGJLACJGKH : global::GFKPJELBOME<LPGJLACJGKH>
{
	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGPGOGPHNHB(Type HCPDGKICMEB, GCKINOCNPCP DOFPJMPPGBL);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKAHJGPJCBE(Type HCPDGKICMEB, out GCKINOCNPCP DOFPJMPPGBL);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class HEECDAJJALJ
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x25F3C10", Offset = "0x25F2810", VA = "0x1825F3C10")]
	public static void LGPGOGPHNHB(this LPGJLACJGKH ALHPFJAALAP, GCKINOCNPCP DOFPJMPPGBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[PCJLLMMMFMG(typeof(BFGKPDBKBHL), new string[] { })]
public sealed class OMDPDJBJDMG : BFGKPDBKBHL, global::GFKPJELBOME<BFGKPDBKBHL>, BHNKHJBOFIN, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<GBEPIPMPHEG, GCKINOCNPCP> JLNMBMPNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private LPGJLACJGKH AGNNIKIBONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private PAKOKDDGBAI OHOCCAOGOIA;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool GAOJGIDOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x665990", Offset = "0x664590", VA = "0x180665990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA33180", Offset = "0xA31D80", VA = "0x180A33180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2567030", Offset = "0x2565C30", VA = "0x182567030")]
	public OMDPDJBJDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x25670A0", Offset = "0x2565CA0", VA = "0x1825670A0")]
	public OMDPDJBJDMG(Dictionary<GBEPIPMPHEG, GCKINOCNPCP> JLNMBMPNDFH, bool JKLKOGMBIFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2566CF0", Offset = "0x25658F0", VA = "0x182566CF0", Slot = "7")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2566AD0", Offset = "0x25656D0", VA = "0x182566AD0", Slot = "8")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2566FE0", Offset = "0x2565BE0", VA = "0x182566FE0", Slot = "9")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2566B50", Offset = "0x2565750", VA = "0x182566B50", Slot = "4")]
	public GBEPIPMPHEG EFPHMDMKILN(HLHPGDAKIBK AMDKCMALAFD)
	{
		return default(GBEPIPMPHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2566EC0", Offset = "0x2565AC0", VA = "0x182566EC0", Slot = "5")]
	public void LGPGOGPHNHB(GBEPIPMPHEG PHGKKLLIIFD, GCKINOCNPCP DOFPJMPPGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x25669C0", Offset = "0x25655C0", VA = "0x1825669C0")]
	[Conditional("DEBUG_BUILD")]
	private void AJNGAKIGFAG(GBEPIPMPHEG PHGKKLLIIFD, Type HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2566D40", Offset = "0x2565940", VA = "0x182566D40", Slot = "6")]
	public bool KKAHJGPJCBE(GBEPIPMPHEG PHGKKLLIIFD, out GCKINOCNPCP DOFPJMPPGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2566C20", Offset = "0x2565820", VA = "0x182566C20", Slot = "10")]
	public BFGKPDBKBHL FPJCJDLKDFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[PCJLLMMMFMG(typeof(LPGJLACJGKH), new string[] { })]
public sealed class DHPOOGAPFBA : BHNKHJBOFIN, LPGJLACJGKH, global::GFKPJELBOME<LPGJLACJGKH>
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly Dictionary<Type, GCKINOCNPCP> JLNMBMPNDFH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool GAOJGIDOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x712FE0", Offset = "0x711BE0", VA = "0x180712FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B78D0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2275D80", Offset = "0x2274980", VA = "0x182275D80")]
	public DHPOOGAPFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2275CD0", Offset = "0x22748D0", VA = "0x182275CD0")]
	public DHPOOGAPFBA(Dictionary<Type, GCKINOCNPCP> JLNMBMPNDFH, bool JKLKOGMBIFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2275A80", Offset = "0x2274680", VA = "0x182275A80", Slot = "4")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2275BA0", Offset = "0x22747A0", VA = "0x182275BA0", Slot = "5")]
	public void LGPGOGPHNHB(Type HCPDGKICMEB, GCKINOCNPCP DOFPJMPPGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2275AE0", Offset = "0x22746E0", VA = "0x182275AE0", Slot = "6")]
	public bool KKAHJGPJCBE(Type HCPDGKICMEB, out GCKINOCNPCP DOFPJMPPGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x22759B0", Offset = "0x22745B0", VA = "0x1822759B0", Slot = "7")]
	public LPGJLACJGKH FPJCJDLKDFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[PCJLLMMMFMG(typeof(JFAIJHOMHLH), new string[] { })]
internal sealed class OFDKGLKJGDI : JFAIJHOMHLH, BHNKHJBOFIN, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly Dictionary<GBEPIPMPHEG, AECGCIMHLPM> LCDENHJPOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private PAKOKDDGBAI OHOCCAOGOIA;

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2565AE0", Offset = "0x25646E0", VA = "0x182565AE0", Slot = "6")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2565A80", Offset = "0x2564680", VA = "0x182565A80", Slot = "7")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2565B30", Offset = "0x2564730", VA = "0x182565B30", Slot = "4")]
	public void LGPGOGPHNHB(GBEPIPMPHEG MKJDELBEPBK, Type BODPIAKOHEC, AECGCIMHLPM FEKHLOKDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2565CF0", Offset = "0x25648F0", VA = "0x182565CF0", Slot = "5")]
	public bool PDAGBGJIKOG(GBEPIPMPHEG MKJDELBEPBK, out AECGCIMHLPM FEKHLOKDKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2565BA0", Offset = "0x25647A0", VA = "0x182565BA0")]
	[Conditional("DEBUG_BUILD")]
	private void LPBEDKLIKPE(GBEPIPMPHEG MKJDELBEPBK, Type BODPIAKOHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2565D60", Offset = "0x2564960", VA = "0x182565D60")]
	public OFDKGLKJGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[APAIBGLBFHK(typeof(PAKOKDDGBAI))]
[PCJLLMMMFMG(typeof(LBCDPHCKHDG), new string[] { })]
internal sealed class LDOEBKPIKDO : LBCDPHCKHDG, OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly PANJBNKAPPE HNKCJJBFEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly Dictionary<EEDOLIFAKPN, int> CJCLOABFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly Stack<int> OKBCHDKPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private PAKOKDDGBAI OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private int BCPABGALLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x2600380", Offset = "0x25FEF80", VA = "0x182600380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KKONBFDNOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6668B0", Offset = "0x6654B0", VA = "0x1806668B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x734890", Offset = "0x733490", VA = "0x180734890", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x26005C0", Offset = "0x25FF1C0", VA = "0x1826005C0", Slot = "6")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2600300", Offset = "0x25FEF00", VA = "0x182600300", Slot = "7")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2600740", Offset = "0x25FF340", VA = "0x182600740", Slot = "8")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x26007D0", Offset = "0x25FF3D0", VA = "0x1826007D0")]
	private void MBNCNADGBIN(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2600690", Offset = "0x25FF290", VA = "0x182600690", Slot = "4")]
	public bool FKILNGHCJFB(EEDOLIFAKPN PLIJDIMDLMI, GBEPIPMPHEG EAIGMDJHNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x26003D0", Offset = "0x25FEFD0", VA = "0x1826003D0", Slot = "5")]
	public void CMBGNNMKGCI(EEDOLIFAKPN PLIJDIMDLMI, Span<GBEPIPMPHEG> OHOCCAOGOIA, bool EHBLLNEJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x26005C0", Offset = "0x25FF1C0", VA = "0x1826005C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2600870", Offset = "0x25FF470", VA = "0x182600870")]
	public LDOEBKPIKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class EAFAACKPMKB
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2276C00", Offset = "0x2275800", VA = "0x182276C00")]
	public static void CEJPCCBLLNN(this POBPEGAACCC DNLABCFBCML, ReadOnlyMemory<byte> HEBDLGPHGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E320F0", Offset = "0x2E30CF0", VA = "0x182E320F0")]
	public static void NAJKHBEKKJC<T>(this POBPEGAACCC DNLABCFBCML, in T PDMPLJICJLE) where T : struct, FAACHECLGAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x33D5210", Offset = "0x33D3E10", VA = "0x1833D5210")]
	public static T GMJILDEJCCO<T>(this POBPEGAACCC DNLABCFBCML) where T : struct, FAACHECLGAP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2276E60", Offset = "0x2275A60", VA = "0x182276E60")]
	public static void NAJKHBEKKJC(this POBPEGAACCC DNLABCFBCML, DBEFLNOPFLF EPGKKIPDCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2276C80", Offset = "0x2275880", VA = "0x182276C80")]
	public static DBEFLNOPFLF FPKFDMADDDP(this POBPEGAACCC DNLABCFBCML)
	{
		return default(DBEFLNOPFLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2276CB0", Offset = "0x22758B0", VA = "0x182276CB0")]
	public static void MGNBDIAPAKG(this POBPEGAACCC BFKGLJCKHHO, uint MBOOIPEHKPC, bool GFDKAOKKKEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2276AE0", Offset = "0x22756E0", VA = "0x182276AE0")]
	public static uint AEEIKLPIBLP(this POBPEGAACCC CPAEFKPNLIE, bool GFDKAOKKKEG = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class ILINEFHNJAP
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class ILOAOLGOOIC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public ILOAOLGOOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x33D0110", Offset = "0x33CED10", VA = "0x1833D0110")]
		internal void <GetByteEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x33D0180", Offset = "0x33CED80", VA = "0x1833D0180")]
		internal T <GetByteEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class CDCKGNLEJMJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public CDCKGNLEJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x33BE180", Offset = "0x33BCD80", VA = "0x1833BE180")]
		internal void <GetSByteEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x33BE1F0", Offset = "0x33BCDF0", VA = "0x1833BE1F0")]
		internal T <GetSByteEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BHKDMBHBNMD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public BHKDMBHBNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x33BE0B0", Offset = "0x33BCCB0", VA = "0x1833BE0B0")]
		internal void <GetShortEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x33BE120", Offset = "0x33BCD20", VA = "0x1833BE120")]
		internal T <GetShortEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class PPNDCBCMPLB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public PPNDCBCMPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x33D3170", Offset = "0x33D1D70", VA = "0x1833D3170")]
		internal void <GetUShortEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x33D31E0", Offset = "0x33D1DE0", VA = "0x1833D31E0")]
		internal T <GetUShortEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JCBGIIAHCHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public JCBGIIAHCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x33D01E0", Offset = "0x33CEDE0", VA = "0x1833D01E0")]
		internal void <GetIntEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x33D0240", Offset = "0x33CEE40", VA = "0x1833D0240")]
		internal T <GetIntEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class NEJPLMGJHPH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public NEJPLMGJHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x33D02A0", Offset = "0x33CEEA0", VA = "0x1833D02A0")]
		internal void <GetUIntEnumDelegates>b__0(POBPEGAACCC b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x33D0300", Offset = "0x33CEF00", VA = "0x1833D0300")]
		internal T <GetUIntEnumDelegates>b__1(POBPEGAACCC b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C19A10", Offset = "0x3C18610", VA = "0x183C19A10")]
	public static void ENNFCNPMKMB<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3C19C00", Offset = "0x3C18800", VA = "0x183C19C00")]
	private static void OKALBCODJGK<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x3C19C00", Offset = "0x3C18800", VA = "0x183C19C00")]
	private static void FIIHEADOINO<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x3C198C0", Offset = "0x3C184C0", VA = "0x183C198C0")]
	private static void LEBJGEFFFNP<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3C198C0", Offset = "0x3C184C0", VA = "0x183C198C0")]
	private static void ADDDEDJOEBO<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3C19D50", Offset = "0x3C18950", VA = "0x183C19D50")]
	private static void HBOCKPPNCDF<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3C19D50", Offset = "0x3C18950", VA = "0x183C19D50")]
	private static void NOAIBHMFGEO<T>(T LAKDIHOJGNM, T COIOJNIHJPJ, out global::FHKGCLOFIDN<T> FADHKIMIJOI, out global::AHEMPMHEAPE<T> KIJMMHPKBHM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public abstract class OBDOGGLHACP : CHPIMBEBNAB, MJAFAPEAAKM
{
	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2565690", Offset = "0x2564290", VA = "0x182565690", Slot = "4")]
	private void LPPHEBCIAMO(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EDMMLDMPHBB(BFGKPDBKBHL OHOCCAOGOIA);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	protected OBDOGGLHACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[IAGIAPGFEBP(typeof(LocalPoseData))]
public sealed class CMJBIPDBHNM : OBDOGGLHACP
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2274880", Offset = "0x2273480", VA = "0x182274880", Slot = "5")]
	protected override void EDMMLDMPHBB(BFGKPDBKBHL OHOCCAOGOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public CMJBIPDBHNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class LJPJHNFLILL : global::KBCEBPNOHMB<AuthoredParentData, OJJDCGFPFHF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x26019F0", Offset = "0x26005F0", VA = "0x1826019F0", Slot = "14")]
	protected override EntityQueryDesc PEBKBGCOBHH(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x77FEA0", Offset = "0x77EAA0", VA = "0x18077FEA0", Slot = "15")]
	protected override EntityQueryDesc LJAKMLHNHMG(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2601930", Offset = "0x2600530", VA = "0x182601930", Slot = "16")]
	protected override EntityQueryDesc GHKOAPMMAKC(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x26019B0", Offset = "0x26005B0", VA = "0x1826019B0", Slot = "17")]
	protected override EntityQueryDesc PDIBINBOCCH(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2601A30", Offset = "0x2600630", VA = "0x182601A30")]
	public LJPJHNFLILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2601970", Offset = "0x2600570", VA = "0x182601970", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[KHHGHKHGGFN(EOABPLMDMOL.Connectables)]
	public class UpdateConnectableVisuals : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		private struct CALLCONPANN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public CPIAMODPOFP PEIBOBCLLBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public float3 AJODAOPNJGC;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x57629D0", Offset = "0x57615D0", VA = "0x1857629D0")]
			public CALLCONPANN(CPIAMODPOFP PEIBOBCLLBF, float3 AJODAOPNJGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x57629B0", Offset = "0x57615B0", VA = "0x1857629B0")]
			public void EAJCABHENAD(out CPIAMODPOFP PEIBOBCLLBF, out float3 AJODAOPNJGC)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct CDEBHNNIOLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public NativeList<CALLCONPANN> childrenWithoutCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public NativeList<CALLCONPANN> childrenWithCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public BufferFromEntity<AuthoredChildrenData> childBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public ComponentDataFromEntity<JJGPMKHEGMF> stateArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public NativeList<CALLCONPANN> parentWithoutCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public NativeList<CALLCONPANN> parentWithCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public CDEBHNNIOLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <UpdateModifiedVisuals>b__2(JJGPMKHEGMF state, WorldPoseData pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <UpdateModifiedVisuals>b__3(JJGPMKHEGMF state, WorldPoseData pose, HDAKJJDIEGK com)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <UpdateModifiedVisuals>b__4(Entity entity, WorldPoseData pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <UpdateModifiedVisuals>b__5(Entity entity, WorldPoseData pose, HDAKJJDIEGK com)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OOCCCKKMFOF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			private struct FJMICEGBINI
			{
				[Cpp2IlInjected.Token(Token = "0x2000097")]
				[NoAlias]
				public struct BINJGBAKCOL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E8")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JJGPMKHEGMF>.Runtime DOJHDGDAHEO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001E9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MMPFLBAOPBL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<JJGPMKHEGMF> DFJLFMEHLCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BFKEOGEKHGK;

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x57631D0", Offset = "0x5761DD0", VA = "0x1857631D0")]
				public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x5763150", Offset = "0x5761D50", VA = "0x185763150")]
				public BINJGBAKCOL HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(BINJGBAKCOL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public NativeList<CALLCONPANN> OJNPHGCLMON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private FJMICEGBINI DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FJMICEGBINI.BINJGBAKCOL* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x5763830", Offset = "0x5762430", VA = "0x185763830")]
			internal void DMHMIBKCDOO(JJGPMKHEGMF DGLKFIPALBO, WorldPoseData LMNGHKPBEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
			public void ReadFromDisplayClass(ref CDEBHNNIOLD GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x57638D0", Offset = "0x57624D0", VA = "0x1857638D0", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x5763980", Offset = "0x5762580", VA = "0x185763980")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref FJMICEGBINI.BINJGBAKCOL MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x5763A50", Offset = "0x5762650", VA = "0x185763A50")]
			public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD, ref CDEBHNNIOLD GGANILFKEIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct MFIJOOIPDBF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private struct BACLJHPOBML
			{
				[Cpp2IlInjected.Token(Token = "0x200009A")]
				[NoAlias]
				public struct CMKEJAHHOFE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F0")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JJGPMKHEGMF>.Runtime DOJHDGDAHEO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MMPFLBAOPBL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40001F2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<HDAKJJDIEGK>.Runtime DGBLOKHKIMJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<JJGPMKHEGMF> DFJLFMEHLCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BFKEOGEKHGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<HDAKJJDIEGK> KDIFDEDNLLD;

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x5762930", Offset = "0x5761530", VA = "0x185762930")]
				public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x5762890", Offset = "0x5761490", VA = "0x185762890")]
				public CMKEJAHHOFE HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(CMKEJAHHOFE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public NativeList<CALLCONPANN> NEIMEHABJAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private BACLJHPOBML DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BACLJHPOBML.CMKEJAHHOFE* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x5763490", Offset = "0x5762090", VA = "0x185763490")]
			internal void DMHMIBKCDOO(JJGPMKHEGMF DGLKFIPALBO, WorldPoseData LMNGHKPBEMI, HDAKJJDIEGK JMAGACCDOEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x25FCFB0", Offset = "0x25FBBB0", VA = "0x1825FCFB0", Slot = "5")]
			public void ReadFromDisplayClass(ref CDEBHNNIOLD GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x5763540", Offset = "0x5762140", VA = "0x185763540", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x5763610", Offset = "0x5762210", VA = "0x185763610")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref BACLJHPOBML.CMKEJAHHOFE MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x5763740", Offset = "0x5762340", VA = "0x185763740")]
			public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD, ref CDEBHNNIOLD GGANILFKEIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct ELDJOGCJLAL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct PBFEHBIEOIC
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				[NoAlias]
				public struct MOFMBEOKACL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FA")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001FB")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MMPFLBAOPBL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BFKEOGEKHGK;

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x5763C80", Offset = "0x5762880", VA = "0x185763C80")]
				public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x5763C00", Offset = "0x5762800", VA = "0x185763C00")]
				public MOFMBEOKACL HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(MOFMBEOKACL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public BufferFromEntity<AuthoredChildrenData> AEGAOBKAHJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			[ReadOnly]
			public ComponentDataFromEntity<JJGPMKHEGMF> PIHOHIEJMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public NativeList<CALLCONPANN> BGLAIKMHFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private PBFEHBIEOIC DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PBFEHBIEOIC.MOFMBEOKACL* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x5762E00", Offset = "0x5761A00", VA = "0x185762E00")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, WorldPoseData LMNGHKPBEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x5763120", Offset = "0x5761D20", VA = "0x185763120", Slot = "5")]
			public void ReadFromDisplayClass(ref CDEBHNNIOLD GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x5762F30", Offset = "0x5761B30", VA = "0x185762F30", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x5762FD0", Offset = "0x5761BD0", VA = "0x185762FD0")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref PBFEHBIEOIC.MOFMBEOKACL MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x5763090", Offset = "0x5761C90", VA = "0x185763090")]
			public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD, ref CDEBHNNIOLD GGANILFKEIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct PHAGJNCGHMN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct OPEBOHIBBLF
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct GMECONIPPLO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000204")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MMPFLBAOPBL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<HDAKJJDIEGK>.Runtime DGBLOKHKIMJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000201")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BFKEOGEKHGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<HDAKJJDIEGK> KDIFDEDNLLD;

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x5763B80", Offset = "0x5762780", VA = "0x185763B80")]
				public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x5763AE0", Offset = "0x57626E0", VA = "0x185763AE0")]
				public GMECONIPPLO HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(GMECONIPPLO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public BufferFromEntity<AuthoredChildrenData> AEGAOBKAHJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			[ReadOnly]
			public ComponentDataFromEntity<JJGPMKHEGMF> PIHOHIEJMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<CALLCONPANN> FECMCELBJIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private OPEBOHIBBLF DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe OPEBOHIBBLF.GMECONIPPLO* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x5763CE0", Offset = "0x57628E0", VA = "0x185763CE0")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, WorldPoseData LMNGHKPBEMI, HDAKJJDIEGK JMAGACCDOEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x5764070", Offset = "0x5762C70", VA = "0x185764070", Slot = "5")]
			public void ReadFromDisplayClass(ref CDEBHNNIOLD GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x5763E30", Offset = "0x5762A30", VA = "0x185763E30", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x5763F00", Offset = "0x5762B00", VA = "0x185763F00")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref OPEBOHIBBLF.GMECONIPPLO MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x5764030", Offset = "0x5762C30", VA = "0x185764030")]
			public void JOOHKCJALDF(UpdateConnectableVisuals FEPEPIEDFAD, ref CDEBHNNIOLD GGANILFKEIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private EntityQuery LDBKOKEFOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private EntityQuery ODNHIGPMHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private EntityQuery JAHIGKLJMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private EntityQuery IMIMMJEEHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private EntityQuery ECEJNDDCBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private EntityQuery BAHMJMJBABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private global::MPMDJDCFKAB<CPIAMODPOFP, ONCLIPMNFEK> NIGBCAFLBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private OAKLFPLBGGO EHGOLKCBIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private EntityQuery IKMEBCIIHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private EntityQuery FFDHEMBLNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private EntityQuery CPJENMKMKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private EntityQuery NCGIIOLBNBH;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		internal global::MPMDJDCFKAB<CPIAMODPOFP, ONCLIPMNFEK> JNGADIEPGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x608670", Offset = "0x607270", VA = "0x180608670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x576A030", Offset = "0x5768C30", VA = "0x18576A030", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x576B840", Offset = "0x576A440", VA = "0x18576B840", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x576B970", Offset = "0x576A570", VA = "0x18576B970", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x576A290", Offset = "0x5768E90", VA = "0x18576A290")]
		private void DEPNPMKILPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
		private void KLEKJNDEDAM(NativeArray<JJGPMKHEGMF> BFHMBAJGGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x576B170", Offset = "0x5769D70", VA = "0x18576B170")]
		private void NECABEODHCK(NativeArray<Entity> EGLKALOECOP, NativeArray<AuthoredParentData> BBAEGALOCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x576B920", Offset = "0x576A520", VA = "0x18576B920", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x576A1C0", Offset = "0x5768DC0", VA = "0x18576A1C0")]
		[CompilerGenerated]
		private ONCLIPMNFEK DEGAPEIKPBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x576B760", Offset = "0x576A360", VA = "0x18576B760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x576A9D0", Offset = "0x57695D0", VA = "0x18576A9D0")]
		public static EntityQuery DGCDIFCDHJD(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x576AC30", Offset = "0x5769830", VA = "0x18576AC30")]
		public static EntityQuery FPPCNMMBDLO(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x576B530", Offset = "0x576A130", VA = "0x18576B530")]
		public static EntityQuery OMKLHDFNBIN(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x576AE80", Offset = "0x5769A80", VA = "0x18576AE80")]
		public static EntityQuery KFDLLMILEJH(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct CPIAMODPOFP : global::DGMLBDFJNFE<CPIAMODPOFP>, NINKJOKNHPH, IEquatable<CPIAMODPOFP>
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2274AF0", Offset = "0x22736F0", VA = "0x182274AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2274B30", Offset = "0x2273730", VA = "0x182274B30", Slot = "8")]
	public bool Equals(CPIAMODPOFP LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2274B80", Offset = "0x2273780", VA = "0x182274B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct JJGPMKHEGMF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public CPIAMODPOFP PEIBOBCLLBF;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class PDMABEKOMNK : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private ObjectEmbodimentService BNFCLMKBNAB;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x256A080", Offset = "0x2568C80", VA = "0x18256A080", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x256A0E0", Offset = "0x2568CE0", VA = "0x18256A0E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x256A110", Offset = "0x2568D10", VA = "0x18256A110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public PDMABEKOMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class MEOJBAKKCBG : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private EntityQuery BBFLBEIPBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private EntityQuery BLKGIDCLEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private EntityQuery OPFKPJGBEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private EntityQuery BLHGNIFNCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private ObjectEmbodimentService PHFMJAPJNFB;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int EMGDEOMHNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x255F950", Offset = "0x255E550", VA = "0x18255F950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public int LICBKFNLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x255FFA0", Offset = "0x255EBA0", VA = "0x18255FFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x255F4E0", Offset = "0x255E0E0", VA = "0x18255F4E0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x255FAE0", Offset = "0x255E6E0", VA = "0x18255FAE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x255FC90", Offset = "0x255E890", VA = "0x18255FC90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x255FD70", Offset = "0x255E970", VA = "0x18255FD70")]
	protected void PIGJPKHNHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x255F540", Offset = "0x255E140", VA = "0x18255F540")]
	protected void COLOBJJLGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x255F770", Offset = "0x255E370", VA = "0x18255F770")]
	private bool FCPLKPKCLOP(EntityQuery CLMPDPEACMB, out NativeArray<Entity> PGMFELKKDCA, out NativeArray<ILEOEHNOMOP> PGHOFPMOHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x255F8A0", Offset = "0x255E4A0", VA = "0x18255F8A0")]
	public global::CDLKACEOIMD<Entity> IFHGBEJGIKG(Allocator KIPGDNHHBGE)
	{
		return default(global::CDLKACEOIMD<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x255F860", Offset = "0x255E460", VA = "0x18255F860")]
	public global::CDLKACEOIMD<Entity> HCENJNLHHPD(Allocator KIPGDNHHBGE)
	{
		return default(global::CDLKACEOIMD<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x255F960", Offset = "0x255E560", VA = "0x18255F960")]
	public bool JOBNBHMCLON(Allocator KIPGDNHHBGE, out global::CDLKACEOIMD<Entity> LIKJOLDFEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x255FD00", Offset = "0x255E900", VA = "0x18255FD00")]
	public bool PGHOMBCKNOP(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x255FA60", Offset = "0x255E660", VA = "0x18255FA60")]
	public CICKPBCENCE NIOLHAAOOOM(Entity NNCGIOJNJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x255F8E0", Offset = "0x255E4E0", VA = "0x18255F8E0")]
	public bool IJBPKLGCINO(Entity NNCGIOJNJIH, out KJFJPNENILE LIKJOLDFEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x255FCB0", Offset = "0x255E8B0", VA = "0x18255FCB0")]
	public void PDMNPMILBPC(Entity NNCGIOJNJIH, KJFJPNENILE LIKJOLDFEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x255F9F0", Offset = "0x255E5F0", VA = "0x18255F9F0")]
	public bool KBDFNDHKKAN(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public MEOJBAKKCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KJFJPNENILE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public CICKPBCENCE LIKJOLDFEOD;

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public KJFJPNENILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	public KJFJPNENILE(CICKPBCENCE LIKJOLDFEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CHENCINABDG))]
public class NNBKNALNPFP : GHIOHHHNFPK
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public NNBKNALNPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct GOAEOJFPBIL : ISystemStateComponentData, IComponentData, IEquatable<GOAEOJFPBIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public float3 BPDKFIGGMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public float3 PLHBEEKFGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x25F24E0", Offset = "0x25F10E0", VA = "0x1825F24E0", Slot = "4")]
	public bool Equals(GOAEOJFPBIL LPEBOAHCFNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class GICDFMFIOGJ : GHIOHHHNFPK, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct DNJENALDIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public GICDFMFIOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public DNJENALDIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MCMGBMGNKGD : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		private struct EJJAHDHMEDN
		{
			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			public struct KIFCOGLEEGF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400021F")]
				public LambdaParameterValueProvider_Entity.Runtime JLCGLGFFOJF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CPLGNOGFCGG;

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x25F04F0", Offset = "0x25EF0F0", VA = "0x1825F04F0")]
			public void JOOHKCJALDF(GICDFMFIOGJ FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x25F04E0", Offset = "0x25EF0E0", VA = "0x1825F04E0")]
			public KIFCOGLEEGF HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(KIFCOGLEEGF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public GICDFMFIOGJ IKBFMCHEBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EntityCommandBuffer PILKIIJMIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private EJJAHDHMEDN DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EJJAHDHMEDN.KIFCOGLEEGF* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x2281A90", Offset = "0x2280690", VA = "0x182281A90")]
		internal void DMHMIBKCDOO(Entity NDHKDNBHBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x2281CF0", Offset = "0x22808F0", VA = "0x182281CF0", Slot = "5")]
		public void ReadFromDisplayClass(ref DNJENALDIBI GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2281D20", Offset = "0x2280920", VA = "0x182281D20", Slot = "6")]
		public void WriteToDisplayClass(ref DNJENALDIBI GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x2281B80", Offset = "0x2280780", VA = "0x182281B80", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2281BE0", Offset = "0x22807E0", VA = "0x182281BE0")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, ref EJJAHDHMEDN.KIFCOGLEEGF MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2281C50", Offset = "0x2280850", VA = "0x182281C50")]
		public void JOOHKCJALDF(GICDFMFIOGJ FEPEPIEDFAD, ref DNJENALDIBI GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2281C90", Offset = "0x2280890", VA = "0x182281C90")]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private GKADHIHODPN GFINHOFHDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private KIBLKIBMNHJ LFNNPGGNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private EntityQuery DLLCKNMOMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private ProfilerMarker BJDPEPMPJIJ;

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2280DE0", Offset = "0x227F9E0", VA = "0x182280DE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x22809F0", Offset = "0x227F5F0", VA = "0x1822809F0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2280E40", Offset = "0x227FA40", VA = "0x182280E40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public GICDFMFIOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2280BE0", Offset = "0x227F7E0", VA = "0x182280BE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2280A50", Offset = "0x227F650", VA = "0x182280A50")]
	public static EntityQuery KGELOGFGGKJ(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct EHEBPCLKHDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public ILICMPFMPIB PEIBOBCLLBF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0")]
	public static EHEBPCLKHDL EDHAFEIJFCP(in ILICMPFMPIB JGDENBHKDOL)
	{
		return default(EHEBPCLKHDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0")]
	public static ILICMPFMPIB EDHAFEIJFCP(in EHEBPCLKHDL EOHDLKFHDCI)
	{
		return default(ILICMPFMPIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[PCJLLMMMFMG(typeof(KIBLKIBMNHJ), new string[] { })]
public sealed class NKDPJJDOEGH : KIBLKIBMNHJ, CDJDJFPMFGA, BHNKHJBOFIN, GLEEPPGLLOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private const int GHPJPJFFIAA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private RaycastHit[] HDIFDDLBGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private Type[] PCLEJLNJPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private global::LDPOKLHHIGK<ILICMPFMPIB, BoxCollider> FIICEJIOEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Scene FCFPJLBNMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private PhysicsScene HIBOPEOIDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private INGCDOCDLMD EODOOKPKGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private GameObject LILAAJNNHHA;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int JAHDCPGLHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x25635C0", Offset = "0x25621C0", VA = "0x1825635C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x25631D0", Offset = "0x2561DD0", VA = "0x1825631D0", Slot = "10")]
	public void HBGKEGAFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2562E80", Offset = "0x2561A80", VA = "0x182562E80", Slot = "11")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x25630C0", Offset = "0x2561CC0", VA = "0x1825630C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2563450", Offset = "0x2562050", VA = "0x182563450", Slot = "5")]
	public ILICMPFMPIB IHHHKILKLMA(Entity NNCGIOJNJIH)
	{
		return default(ILICMPFMPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2563600", Offset = "0x2562200", VA = "0x182563600", Slot = "6")]
	public void KPBHEDDCOJA(NativeArray<ILICMPFMPIB> PGHOFPMOHFA, NativeArray<GOAEOJFPBIL> IPEPCLOOLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2563800", Offset = "0x2562400", VA = "0x182563800", Slot = "7")]
	public void LPHFDILFPJK(ILICMPFMPIB PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2562F30", Offset = "0x2561B30", VA = "0x182562F30", Slot = "8")]
	public bool CGBNNIFHMJG(ILICMPFMPIB PEIBOBCLLBF, out Collider DDOMPBPGFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2562C70", Offset = "0x2561870", VA = "0x182562C70")]
	public bool ADEFHBFDNLI(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, Allocator KIPGDNHHBGE, out NativeArray<Entity> PGMFELKKDCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2563180", Offset = "0x2561D80", VA = "0x182563180")]
	private void EALLCGPPANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A8E80", VA = "0x1808AA280")]
	private void CIEOCBGJLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2563A10", Offset = "0x2562610", VA = "0x182563A10")]
	private void PMIIIIKDNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x9D35D0", Offset = "0x9D21D0", VA = "0x1809D35D0")]
	private void IIKHDPKHBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2562FD0", Offset = "0x2561BD0", VA = "0x182562FD0")]
	private BoxCollider CNPENENKMMI(Entity NNCGIOJNJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2562BF0", Offset = "0x25617F0", VA = "0x182562BF0")]
	private void AACMJDALEIP(BoxCollider KFIAPADECAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2563580", Offset = "0x2562180", VA = "0x182563580")]
	[Conditional("UNITY_EDITOR")]
	private void IIFMFGCLHHC(GameObject JPIPKHMPCNE, Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2563B70", Offset = "0x2562770", VA = "0x182563B70")]
	private void PONMJFENNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x25638E0", Offset = "0x25624E0", VA = "0x1825638E0")]
	private void NNBEMKPMLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2563440", Offset = "0x2562040", VA = "0x182563440")]
	private void HHNCNDLNFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x25638A0", Offset = "0x25624A0", VA = "0x1825638A0")]
	private void MLIOGEOBNFA(Scene MBEEMBEBNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NKDPJJDOEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2563430", Offset = "0x2562030", VA = "0x182563430", Slot = "9")]
	private bool HGBBCBLCFDB(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, Allocator KIPGDNHHBGE, out NativeArray<Entity> PGMFELKKDCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class GKADHIHODPN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public GKADHIHODPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class HFHCBJHLIKF : GHIOHHHNFPK, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct DKCHNJBHLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public HFHCBJHLIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public DKCHNJBHLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity e, EHEBPCLKHDL ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DHJICKGMCME : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct EJIMNDKNLPH
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			public struct MLHDJECPPKH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public LambdaParameterValueProvider_Entity.Runtime JLCGLGFFOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public LambdaParameterValueProvider_IComponentData<EHEBPCLKHDL>.Runtime ODCCJLOPHGJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CPLGNOGFCGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EHEBPCLKHDL> BLNBHMDFJEM;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x25F0480", Offset = "0x25EF080", VA = "0x1825F0480")]
			public void JOOHKCJALDF(HFHCBJHLIKF FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x25F0400", Offset = "0x25EF000", VA = "0x1825F0400")]
			public MLHDJECPPKH HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(MLHDJECPPKH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public HFHCBJHLIKF IKBFMCHEBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EntityCommandBuffer PILKIIJMIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private EJIMNDKNLPH DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EJIMNDKNLPH.MLHDJECPPKH* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x25F00C0", Offset = "0x25EECC0", VA = "0x1825F00C0")]
		internal void DMHMIBKCDOO(Entity NDHKDNBHBLL, EHEBPCLKHDL OPOHJOHNPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2281CF0", Offset = "0x22808F0", VA = "0x182281CF0", Slot = "5")]
		public void ReadFromDisplayClass(ref DKCHNJBHLKC GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2281D20", Offset = "0x2280920", VA = "0x182281D20", Slot = "6")]
		public void WriteToDisplayClass(ref DKCHNJBHLKC GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x25F01C0", Offset = "0x25EEDC0", VA = "0x1825F01C0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x25F0260", Offset = "0x25EEE60", VA = "0x1825F0260")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, ref EJIMNDKNLPH.MLHDJECPPKH MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x25F0310", Offset = "0x25EEF10", VA = "0x1825F0310")]
		public void JOOHKCJALDF(HFHCBJHLIKF FEPEPIEDFAD, ref DKCHNJBHLKC GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x25F03A0", Offset = "0x25EEFA0", VA = "0x1825F03A0")]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private GKADHIHODPN GFINHOFHDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private KIBLKIBMNHJ LFNNPGGNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private EntityQuery PDFPKCELOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private ProfilerMarker NGEPPKBEMGP;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x25F4280", Offset = "0x25F2E80", VA = "0x1825F4280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x25F3E90", Offset = "0x25F2A90", VA = "0x1825F3E90", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F42E0", Offset = "0x25F2EE0", VA = "0x1825F42E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public HFHCBJHLIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F4080", Offset = "0x25F2C80", VA = "0x1825F4080", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x25F3EF0", Offset = "0x25F2AF0", VA = "0x1825F3EF0")]
	public static EntityQuery MENOEFMFFGA(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[KHHGHKHGGFN(EOABPLMDMOL.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		private struct HHFEKHAMGMH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public KGBHHKGFLKL HILNOPGMOJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public NativeHashMap<Entity, JPLMCCNINHK> PGMFELKKDCA;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x22E50E0", Offset = "0x22E3CE0", VA = "0x1822E50E0")]
			public HHFEKHAMGMH(int EFOLPOOCAHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x22E5070", Offset = "0x22E3C70", VA = "0x1822E5070", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[BurstCompile]
		private struct FECPBLBELDE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CPJEJIHEGGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> IALCNPFFAOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> DCNKCLJJACD;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x22E49E0", Offset = "0x22E35E0", VA = "0x1822E49E0", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct PPFKMPJKEGA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CPJEJIHEGGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> DCNKCLJJACD;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x22EC5B0", Offset = "0x22EB1B0", VA = "0x1822EC5B0", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private KIBLKIBMNHJ LFNNPGGNOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private EntityQuery AJGMIALFCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private EntityQuery GHALHBAMJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private EntityQuery HAFGOPAGBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private EntityQuery DELJBEEHACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private EntityQuery BHDAEBHJOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private JobHandle ACLPBJKJGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private HHFEKHAMGMH PIADEHKMNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private HHFEKHAMGMH GDCBBONGMII;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x22ECAD0", Offset = "0x22EB6D0", VA = "0x1822ECAD0", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x22ED270", Offset = "0x22EBE70", VA = "0x1822ED270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x22ED4B0", Offset = "0x22EC0B0", VA = "0x1822ED4B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x22ED4C0", Offset = "0x22EC0C0", VA = "0x1822ED4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x22ECEB0", Offset = "0x22EBAB0", VA = "0x1822ECEB0")]
		private void KBBLKAPDCLH(EntityQuery CLMPDPEACMB, out (global::CDLKACEOIMD<EHEBPCLKHDL> handles, global::CDLKACEOIMD<GOAEOJFPBIL> bounds) CEECNJJKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x22EC8C0", Offset = "0x22EB4C0", VA = "0x1822EC8C0")]
		private void ANIKPEEEBDP((global::CDLKACEOIMD<EHEBPCLKHDL> handles, global::CDLKACEOIMD<GOAEOJFPBIL> bounds) CEECNJJKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x22ECC60", Offset = "0x22EB860", VA = "0x1822ECC60")]
		private void HOHHPNBBJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x22EC760", Offset = "0x22EB360", VA = "0x1822EC760")]
		private void AMLCNKOFHAJ(EntityQuery CLMPDPEACMB, out (global::CDLKACEOIMD<Entity> entities, global::CDLKACEOIMD<EHEBPCLKHDL> handles) CEECNJJKNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x22ED010", Offset = "0x22EBC10", VA = "0x1822ED010")]
		private void MPPCINKHBEC((global::CDLKACEOIMD<Entity> entities, global::CDLKACEOIMD<EHEBPCLKHDL> handles) CEECNJJKNFO, HHFEKHAMGMH JDINKLLNGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x22ECD60", Offset = "0x22EB960", VA = "0x1822ECD60")]
		private JobHandle IDIMEDPGEGP(HHFEKHAMGMH JDINKLLNGFB, ComponentDataFromEntity<WorldPoseData> CPJEJIHEGGC, ComponentDataFromEntity<WorldUniformScaleData> DCNKCLJJACD, ComponentDataFromEntity<WorldDeformableScaleData> IALCNPFFAOP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x22ECB30", Offset = "0x22EB730", VA = "0x1822ECB30")]
		private JobHandle HNMHCIPEFOF(HHFEKHAMGMH JDINKLLNGFB, ComponentDataFromEntity<WorldPoseData> CPJEJIHEGGC, ComponentDataFromEntity<WorldUniformScaleData> DCNKCLJJACD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[PCJLLMMMFMG(typeof(DODMEIANOBL), new string[] { })]
public sealed class PCGOELAGEOG : DODMEIANOBL, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct EPHEILGHNDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public float DMKJHAOIIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public uint GGFDCMIALOL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private CDJDJFPMFGA OABBJGFAIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private FDPONFLPNMM EBFNHLEAKLH;

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2569EF0", Offset = "0x2568AF0", VA = "0x182569EF0", Slot = "5")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2569B00", Offset = "0x2568700", VA = "0x182569B00")]
	public bool ADEFHBFDNLI(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, out NMIDNMJIEAO LHGHPMDIGHH, out Entity FBGGIOMEJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x2569F60", Offset = "0x2568B60", VA = "0x182569F60")]
	public static bool FAMGFHJHAAE(in Span<NMIDNMJIEAO> HBOABCLCAPJ, float FLANGJLOLNC, out int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x256A050", Offset = "0x2568C50", VA = "0x18256A050")]
	public static float IGOEOOMAAOJ(float DMKJHAOIIMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PCGOELAGEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2569F50", Offset = "0x2568B50", VA = "0x182569F50", Slot = "4")]
	private bool COCEAKLDOEC(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, out NMIDNMJIEAO LHGHPMDIGHH, out Entity FBGGIOMEJKO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct BCBDECJEMMK : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[KHHGHKHGGFN(EOABPLMDMOL.Physics)]
	public class SplineLocalBoundsSystem : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct OLOJIOKELHM : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[ReadOnly]
			public NativeArray<Entity> NJIJHCLAJLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LOLAGPBCALN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			[ReadOnly]
			public ComponentDataFromEntity<GOAEOJFPBIL> HCAFOLCHDAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			[WriteOnly]
			public NativeHashMap<Entity, JPLMCCNINHK>.ParallelWriter KDFADHKOOIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter MPAMMLFMLDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter GAPKJOIMOED;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x5763780", Offset = "0x5762380", VA = "0x185763780", Slot = "4")]
			public void Execute(int BAOHKIGDOBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[BurstCompile]
		private struct JHDKPGCCJOM : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			[ReadOnly]
			public NativeArray<Entity> DLJNCNMGOMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> PAIAIAGIAMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LOLAGPBCALN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<GOAEOJFPBIL> ANOLGDGPMHA;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x5763290", Offset = "0x5761E90", VA = "0x185763290", Slot = "4")]
			public void Execute(int BAOHKIGDOBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private EntityQuery PMDEOLOIBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private EntityQuery CIHNFALENDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private EntityQuery PIKHBDMAENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private EntityQuery BNCHBABOHED;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x22F3510", Offset = "0x22F2110", VA = "0x1822F3510", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x22F36B0", Offset = "0x22F22B0", VA = "0x1822F36B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x22F30C0", Offset = "0x22F1CC0", VA = "0x1822F30C0")]
		private JobHandle KNICPFDMJBP(global::CDLKACEOIMD<Entity> MPENDCAONOC, int LIJNMPAFKGC, JobHandle HKCAPDPGJLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x22F3190", Offset = "0x22F1D90", VA = "0x1822F3190")]
		private JobHandle KNICPFDMJBP(NativeArray<Entity> ILEAEHHMIEE, int LIJNMPAFKGC, [Optional] JobHandle HKCAPDPGJLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x22F2CB0", Offset = "0x22F18B0", VA = "0x1822F2CB0")]
		private global::CDLKACEOIMD<Entity> JFLILJDHBEK(EntityQuery CLMPDPEACMB)
		{
			return default(global::CDLKACEOIMD<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x22F28E0", Offset = "0x22F14E0", VA = "0x1822F28E0")]
		private (global::GLGPGDFCOAH<Entity>, global::GLGPGDFCOAH<Entity>) FLAOMDOGPBA(global::CDLKACEOIMD<Entity> DABEHOPDEEH)
		{
			return default((global::GLGPGDFCOAH<Entity>, global::GLGPGDFCOAH<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x22F3490", Offset = "0x22F2090", VA = "0x1822F3490")]
		private void MIJEABMBLCP(out NativeArray<Entity> PGMFELKKDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x22F3410", Offset = "0x22F2010", VA = "0x1822F3410")]
		private void LFFJICFLPDA(NativeList<Entity> PGMFELKKDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x22F3350", Offset = "0x22F1F50", VA = "0x1822F3350")]
		private void LFFJICFLPDA(NativeArray<Entity> PGMFELKKDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x22F27C0", Offset = "0x22F13C0", VA = "0x1822F27C0")]
		private void EBEKCOBDECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private static void JFLMHOHJDPD(int FIKFJLNPHAE, int CPHMKJGLJPH, int OJPGGGMIHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x22F2D40", Offset = "0x22F1940", VA = "0x1822F2D40")]
		private static GOAEOJFPBIL KDINGKBGJJP(NativeArray<Entity> CJDMHHEHNNK, ComponentDataFromEntity<SplinePointData> LOLAGPBCALN)
		{
			return default(GOAEOJFPBIL);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[PCJLLMMMFMG(typeof(FDPONFLPNMM), new string[] { })]
public sealed class HGMNKJEKJMA : FDPONFLPNMM, GLEEPPGLLOC
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[BurstCompile]
	private struct NJOBOCKDJIK : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		[ReadOnly]
		public NativeArray<Entity> PGMFELKKDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		[ReadOnly]
		public float3 FGMCNFIPKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		[ReadOnly]
		public float3 MFJMIEEAAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> LLJIMMHELPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> CIGJNAAIDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> PAIAIAGIAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> LOLAGPBCALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[WriteOnly]
		public NativeArray<NMIDNMJIEAO> OADGELAEKKP;

		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private static readonly NMIDNMJIEAO FKLGDCJHMLG;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x2602280", Offset = "0x2600E80", VA = "0x182602280", Slot = "4")]
		public void Execute(int BAOHKIGDOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x2602D00", Offset = "0x2601900", VA = "0x182602D00")]
		private static float3 LEEFFGIEGOO(in float4x4 MLEHCELNJNP, in float3 LMLNCGLGHJD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x26025B0", Offset = "0x26011B0", VA = "0x1826025B0")]
		private static float3 JLCEDGOBGGC(in float4x4 MLEHCELNJNP, in float3 OHKJMOLJEFG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2602180", Offset = "0x2600D80", VA = "0x182602180")]
		private static float3 EBJMPDNBPDP(in float4x4 MLEHCELNJNP, in float3 LMLNCGLGHJD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2602780", Offset = "0x2601380", VA = "0x182602780")]
		private static float3 KKIONFBCLGE(in float4x4 MLEHCELNJNP, in float3 OHKJMOLJEFG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x26029B0", Offset = "0x26015B0", VA = "0x1826029B0")]
		private bool KMGMONPJIAN(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, in NativeArray<Entity> GBMNBACBLBI, out float3 LHGHPMDIGHH, out float3 BJEBKPPDLFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2601A80", Offset = "0x2600680", VA = "0x182601A80")]
		public static bool CMILMFFBJAE(in float3 MJOILFOCOMA, in float3 HMMIMAHOBDG, in float3 PLGBHFMBEHH, in float3 OGHIALKKMEP, float AKLNOEBENHM, float OGBEEAJCELC, out float JJBHDPAHMPA, out float3 JCGCCDNHIIL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x25F4680", Offset = "0x25F3280", VA = "0x1825F4680", Slot = "5")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x25F4470", Offset = "0x25F3070", VA = "0x1825F4470")]
	public void ADEFHBFDNLI(in NativeArray<Entity> PGMFELKKDCA, in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, in NativeArray<NMIDNMJIEAO> KHDJDLKHLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HGMNKJEKJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x25F4470", Offset = "0x25F3070", VA = "0x1825F4470", Slot = "4")]
	private void OLKKDNEAHOO(in NativeArray<Entity> PGMFELKKDCA, in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, in NativeArray<NMIDNMJIEAO> KHDJDLKHLPG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct LOHDDBLJJLI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[KHHGHKHGGFN(EOABPLMDMOL.Lifecycle)]
	public class DestroyLocalObjects : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private bool ONBALJNPLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private EntityQuery NNOKJDMPKGF;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x22E2D00", Offset = "0x22E1900", VA = "0x1822E2D00")]
		public bool AHBLMPPJLPM(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x22E2DA0", Offset = "0x22E19A0", VA = "0x1822E2DA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x22E2E20", Offset = "0x22E1A20", VA = "0x1822E2E20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x1105C20", Offset = "0x1104820", VA = "0x181105C20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[KHHGHKHGGFN(EOABPLMDMOL.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private PNAAFBKOFON GPPNHBBAGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private MACMHPECBIO NIJKCBBECFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private LNJHMHFINIC DGLKFIPALBO;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		protected abstract ComputePropertyDifferences CIAMKCACLKM
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x22E2F80", Offset = "0x22E1B80", VA = "0x1822E2F80", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x22E3030", Offset = "0x22E1C30", VA = "0x1822E3030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private void EJCHCEPBGFD(Entity NNCGIOJNJIH, EEDOLIFAKPN PLIJDIMDLMI, PIGCJKHMOBI JMMMLGCJDIC, JIHJLEBKKBA FNGPNCJACAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[KHHGHKHGGFN(EOABPLMDMOL.Callbacks)]
	public abstract class PropertyEventCallbacks : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private PropertyEventCallbacksService ICEBKIIKPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private LNJHMHFINIC DGLKFIPALBO;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x22F1460", Offset = "0x22F0060", VA = "0x1822F1460", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x22F14E0", Offset = "0x22F00E0", VA = "0x1822F14E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public abstract class ODBFEKDJEDP : GHIOHHHNFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private List<(EntityQuery, ComponentType)> GBIHOJOKJHC;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x25656F0", Offset = "0x25642F0", VA = "0x1825656F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x25658C0", Offset = "0x25644C0", VA = "0x1825658C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2565A10", Offset = "0x2564610", VA = "0x182565A10")]
	protected ODBFEKDJEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct MNAOEJKCNGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public int LEADIMEMNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public int DBOCDBJDJNH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x25604A0", Offset = "0x255F0A0", VA = "0x1825604A0")]
	public static Entity EDHAFEIJFCP(MNAOEJKCNGI CEECNJJKNFO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x25604A0", Offset = "0x255F0A0", VA = "0x1825604A0")]
	public static MNAOEJKCNGI EDHAFEIJFCP(Entity NNCGIOJNJIH)
	{
		return default(MNAOEJKCNGI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct NNCBINKCNLL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct JIJEFOBIPAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly ComponentType ABLJKBEKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly NativeList<int> CFGAMGPMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public readonly NativeList<int> HHJHOFJANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public readonly NativeArray<Entity> PGMFELKKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public readonly NativeArray<Entity> ACLAMKHAINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public readonly NativeArray<byte> ANDJPGLENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public readonly NativeArray<byte> PDAHFHABHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly int GJLPBFKEEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public readonly int OMJOHPKCEHH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool GFNDJGKNCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x25FC7A0", Offset = "0x25FB3A0", VA = "0x1825FC7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x25FC810", Offset = "0x25FB410", VA = "0x1825FC810")]
	public JIJEFOBIPAK(ComponentType ABLJKBEKADN, NativeList<int> CFGAMGPMLDE, NativeList<int> HHJHOFJANEB, NativeArray<Entity> PGMFELKKDCA, NativeArray<Entity> ACLAMKHAINJ, NativeArray<byte> ANDJPGLENEM, NativeArray<byte> PDAHFHABHCI, int GJLPBFKEEAM, int OMJOHPKCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x25FC5A0", Offset = "0x25FB1A0", VA = "0x1825FC5A0")]
	private BNKGCKPKCFJ CNAGDGDNJJE(NativeArray<byte> MPENDCAONOC, int BAOHKIGDOBF)
	{
		return default(BNKGCKPKCFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	private T CNAGDGDNJJE<T>(NativeArray<byte> MPENDCAONOC, int BAOHKIGDOBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x25FC550", Offset = "0x25FB150", VA = "0x1825FC550")]
	public BNKGCKPKCFJ CILFPAGHLAJ(int BAOHKIGDOBF)
	{
		return default(BNKGCKPKCFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	public T CILFPAGHLAJ<T>(int BAOHKIGDOBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x25FC500", Offset = "0x25FB100", VA = "0x1825FC500")]
	public BNKGCKPKCFJ ALOLCPFODLE(int BAOHKIGDOBF)
	{
		return default(BNKGCKPKCFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	public T ALOLCPFODLE<T>(int BAOHKIGDOBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x25FC6C0", Offset = "0x25FB2C0", VA = "0x1825FC6C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct LAAJBKKLNIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public readonly EntityQuery CLMPDPEACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public readonly NativeArray<KDMHPBOIKOP> OHOCCAOGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public readonly ComponentType ABLJKBEKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public readonly int GJLPBFKEEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public readonly int OMJOHPKCEHH;

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x25FEAA0", Offset = "0x25FD6A0", VA = "0x1825FEAA0")]
	public LAAJBKKLNIF(ComponentType ABLJKBEKADN, int GJLPBFKEEAM, int OMJOHPKCEHH, EntityQuery CLMPDPEACMB, NativeArray<KDMHPBOIKOP> OHOCCAOGOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x25FEA50", Offset = "0x25FD650", VA = "0x1825FEA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct IMBCKPCPJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public int BAOHKIGDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public int BHDBLDNLBAA;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x76DD30", Offset = "0x76C930", VA = "0x18076DD30")]
	public IMBCKPCPJOH(int BAOHKIGDOBF, int BHDBLDNLBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct KDMHPBOIKOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly int HMFFBMGNBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public readonly int AABEJHHLOHL;

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x76DD30", Offset = "0x76C930", VA = "0x18076DD30")]
	public KDMHPBOIKOP(int HMFFBMGNBCG, int AABEJHHLOHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct JIHJLEBKKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly GBEPIPMPHEG PHGKKLLIIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly int GJLPBFKEEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private unsafe readonly byte* ANDJPGLENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private unsafe readonly byte* PDAHFHABHCI;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x25FC310", Offset = "0x25FAF10", VA = "0x1825FC310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GBEPIPMPHEG EIFANLOKHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500")]
		get
		{
			return default(GBEPIPMPHEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x25FC320", Offset = "0x25FAF20", VA = "0x1825FC320")]
	public BNKGCKPKCFJ HEBNKIIKIDA(Type HCPDGKICMEB)
	{
		return default(BNKGCKPKCFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x25FC400", Offset = "0x25FB000", VA = "0x1825FC400")]
	public BNKGCKPKCFJ NLFPEGEHACK(Type HCPDGKICMEB)
	{
		return default(BNKGCKPKCFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x33DF210", Offset = "0x33DDE10", VA = "0x1833DF210")]
	public T HEBNKIIKIDA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x33DF230", Offset = "0x33DDE30", VA = "0x1833DF230")]
	public T NLFPEGEHACK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x25FC4E0", Offset = "0x25FB0E0", VA = "0x1825FC4E0")]
	public unsafe JIHJLEBKKBA(GBEPIPMPHEG PHGKKLLIIFD, int AABEJHHLOHL, byte* ANDJPGLENEM, byte* PDAHFHABHCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class AEEEINHCILN
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] MHLCEOIDEMP;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[DefaultMember("Item")]
internal class FDPMDKEHFKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly Dictionary<ComponentType, LAAJBKKLNIF> DEDADAACCOO;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LAAJBKKLNIF LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x227B630", Offset = "0x227A230", VA = "0x18227B630")]
		get
		{
			return default(LAAJBKKLNIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x227AEB0", Offset = "0x2279AB0", VA = "0x18227AEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x227B6B0", Offset = "0x227A2B0", VA = "0x18227B6B0")]
	public FDPMDKEHFKM(DJFBKNFJCKG PEFFPCJPBOK, PEOJNAGCHAI NLGECAJFNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x227AF00", Offset = "0x2279B00", VA = "0x18227AF00")]
	public Dictionary<ComponentType, LAAJBKKLNIF>.Enumerator FIAIDFFFPCH()
	{
		return default(Dictionary<ComponentType, LAAJBKKLNIF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x227AD30", Offset = "0x2279930", VA = "0x18227AD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x227AF90", Offset = "0x2279B90", VA = "0x18227AF90")]
	private void FKFBMFMNNHK(IEnumerable<EFCKPAPAFFN> AMHPGLEIFGM, EntityManager DEFMCCAEPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x227AC80", Offset = "0x2279880", VA = "0x18227AC80")]
	private static int DJHGBACFLPN(EFCKPAPAFFN FIKNJIDCALK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x227B380", Offset = "0x2279F80", VA = "0x18227B380")]
	private static NativeArray<KDMHPBOIKOP> INGNNGGGKAM(EFCKPAPAFFN FIKNJIDCALK, Allocator KIPGDNHHBGE = Allocator.Persistent)
	{
		return default(NativeArray<KDMHPBOIKOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal interface LNJHMHFINIC
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	World EFBFALBAFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHKBNJLIEBK(out NativeArray<int> ONJBJACHEEE, Allocator KIPGDNHHBGE);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BLJAHJGEHJO(ComponentType ABLJKBEKADN, out JIJEFOBIPAK CMNPLECEDGJ, out LAAJBKKLNIF CMCJHIBMAKJ);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLJAHJGEHJO(ComponentType ABLJKBEKADN, out JIJEFOBIPAK CMNPLECEDGJ);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JIJEFOBIPAK POJMJADNDPF(ComponentType ABLJKBEKADN);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DGOBJPGENND LOEFGHMDONF();

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PFOEEIDJGNN(JobHandle NHBMKIBCLOB);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal interface DLEACGMLCMC
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	World EFBFALBAFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	FDPMDKEHFKM DNEFHCGOMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	IFPAIJDEBEG DMGCIEDKPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	NativeMultiHashMap<Entity, JIHJLEBKKBA> EHGPFFEJKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	JobHandle OLJBBDIHJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMDAHEHGHKH();

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNHBKLHOOAC();

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBGFKAHAIFK(ComponentType ABLJKBEKADN, in JIJEFOBIPAK PIEBPKOIOBB);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FMNCKHPAPBB(GGPLMDHKFKM DFPCAFCOFNA, out Entity LILAAJNNHHA);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[KHHGHKHGGFN(EOABPLMDMOL.PropertyChanges)]
	[PCJLLMMMFMG(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : GLEEPPGLLOC, MJAFAPEAAKM, DLEACGMLCMC, LNJHMHFINIC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private DJFBKNFJCKG PEFFPCJPBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private ObjectPrefabCreationService CEGBCPNNCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private HEINBCBJOCN NACNPKFGBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private FDPMDKEHFKM DEDADAACCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IFPAIJDEBEG CNKCEFADLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private EGFDPLCDJLP ABPGAGNPEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private List<JIJEFOBIPAK> IIAGKBIAFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private NativeMultiHashMap<Entity, JIHJLEBKKBA> LAIHFICLAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private NativeHashMap<int, int> NEGEBJFIMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private JobHandle HMCFBJJLPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private JobHandle LGBOACDIMKG;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool GFNDJGKNCLM
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x22EF850", Offset = "0x22EE450", VA = "0x1822EF850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private World KNAPKJJDFLF
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x22F0060", Offset = "0x22EEC60", VA = "0x1822F0060", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private FDPMDKEHFKM CAEIMLGDNHK
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private IFPAIJDEBEG OGOEPEDNAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private NativeMultiHashMap<Entity, JIHJLEBKKBA> LPAPHNGPBJF
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xFFB200", Offset = "0xFF9E00", VA = "0x180FFB200", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, JIHJLEBKKBA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private JobHandle DHJDPMCCEFP
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8E5DD0", Offset = "0x8E49D0", VA = "0x1808E5DD0", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x8E5E80", Offset = "0x8E4A80", VA = "0x1808E5E80", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private World HFJHIGKOFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x22EFC90", Offset = "0x22EE890", VA = "0x1822EFC90", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x22EF5A0", Offset = "0x22EE1A0", VA = "0x1822EF5A0", Slot = "13")]
		private void CGFAICLIBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x22EF4F0", Offset = "0x22EE0F0", VA = "0x1822EF4F0", Slot = "12")]
		private void BPFMJLLCAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x22EFCF0", Offset = "0x22EE8F0", VA = "0x1822EFCF0", Slot = "14")]
		private void JHCLEGOGBJI(ComponentType ABLJKBEKADN, in JIJEFOBIPAK PIEBPKOIOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x22EFC70", Offset = "0x22EE870", VA = "0x1822EFC70", Slot = "15")]
		private bool HPPKLBNKBDB(GGPLMDHKFKM DFPCAFCOFNA, out Entity LILAAJNNHHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x22EF700", Offset = "0x22EE300", VA = "0x1822EF700", Slot = "17")]
		private bool DLDEANHOKCI(out NativeArray<int> ONJBJACHEEE, Allocator KIPGDNHHBGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x22EF970", Offset = "0x22EE570", VA = "0x1822EF970", Slot = "18")]
		private bool FGKFDGIOAAP(ComponentType ABLJKBEKADN, out JIJEFOBIPAK CMNPLECEDGJ, out LAAJBKKLNIF CMCJHIBMAKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x22EF860", Offset = "0x22EE460", VA = "0x1822EF860", Slot = "19")]
		private bool FGKFDGIOAAP(ComponentType ABLJKBEKADN, out JIJEFOBIPAK CMNPLECEDGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x22F00C0", Offset = "0x22EECC0", VA = "0x1822F00C0", Slot = "20")]
		private JIJEFOBIPAK OPCBFHGMOJE(ComponentType ABLJKBEKADN)
		{
			return default(JIJEFOBIPAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x22EFE00", Offset = "0x22EEA00", VA = "0x1822EFE00", Slot = "21")]
		private DGOBJPGENND MHGFFLPJPDJ()
		{
			return default(DGOBJPGENND);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x22EFDC0", Offset = "0x22EE9C0", VA = "0x1822EFDC0", Slot = "22")]
		private void MFFCFOMKBPP(JobHandle NHBMKIBCLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x22EF480", Offset = "0x22EE080", VA = "0x1822EF480", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x22EFAD0", Offset = "0x22EE6D0", VA = "0x1822EFAD0", Slot = "5")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x22EF790", Offset = "0x22EE390", VA = "0x1822EF790", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x22EFE40", Offset = "0x22EEA40", VA = "0x1822EFE40")]
		private void MNHBKLHOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x22EF2C0", Offset = "0x22EDEC0", VA = "0x1822EF2C0")]
		private bool BHLCAMMIBHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x22EF5B0", Offset = "0x22EE1B0", VA = "0x1822EF5B0")]
		private int DHOJEDBNPBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x22F0240", Offset = "0x22EEE40", VA = "0x1822F0240")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct DGOBJPGENND
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct HMIKPDHBJPE : IEnumerator<JIHJLEBKKBA>, IEnumerator, IDisposable, IEnumerable<JIHJLEBKKBA>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private readonly NativeMultiHashMap<Entity, JIHJLEBKKBA> MIFOEAMJCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly Entity NNCGIOJNJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private NativeMultiHashMapIterator<Entity> KMKEANIAAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private JIHJLEBKKBA PDAHFHABHCI;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public JIHJLEBKKBA JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xBFAF40", Offset = "0xBF9B40", VA = "0x180BFAF40", Slot = "4")]
			get
			{
				return default(JIHJLEBKKBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x2281510", Offset = "0x2280110", VA = "0x182281510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2281560", Offset = "0x2280160", VA = "0x182281560")]
		internal HMIKPDHBJPE(NativeMultiHashMap<Entity, JIHJLEBKKBA> MIFOEAMJCKN, Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x22812F0", Offset = "0x227FEF0", VA = "0x1822812F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x22812C0", Offset = "0x227FEC0", VA = "0x1822812C0")]
		public HMIKPDHBJPE FIAIDFFFPCH()
		{
			return default(HMIKPDHBJPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x22813B0", Offset = "0x227FFB0", VA = "0x1822813B0", Slot = "9")]
		private IEnumerator<JIHJLEBKKBA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x2281460", Offset = "0x2280060", VA = "0x182281460", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private readonly DLEACGMLCMC DGLKFIPALBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private readonly JobHandle KOFFACBDEBB;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int MCBDAFMBKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x2275640", Offset = "0x2274240", VA = "0x182275640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool IJOOMGLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x2275560", Offset = "0x2274160", VA = "0x182275560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2275980", Offset = "0x2274580", VA = "0x182275980")]
	public DGOBJPGENND(DLEACGMLCMC DGLKFIPALBO, JobHandle KOFFACBDEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x2275840", Offset = "0x2274440", VA = "0x182275840")]
	public bool OFFFJEIIFDB(Allocator KIPGDNHHBGE, out NativeKeyValueArrays<Entity, JIHJLEBKKBA> FADBLLIMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x2275410", Offset = "0x2274010", VA = "0x182275410")]
	public bool HDBECDOBHNC(Allocator KIPGDNHHBGE, out (NativeArray<Entity> entities, int uniqueCount) FADBLLIMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2275730", Offset = "0x2274330", VA = "0x182275730")]
	public HMIKPDHBJPE NCPBCAPDHGL(Entity NNCGIOJNJIH)
	{
		return default(HMIKPDHBJPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[DefaultMember("Item")]
internal class IFPAIJDEBEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly List<LAAJBKKLNIF> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public LAAJBKKLNIF LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x25F8B80", Offset = "0x25F7780", VA = "0x1825F8B80")]
		get
		{
			return default(LAAJBKKLNIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x25F8820", Offset = "0x25F7420", VA = "0x1825F8820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x25F8C10", Offset = "0x25F7810", VA = "0x1825F8C10")]
	public IFPAIJDEBEG(FDPMDKEHFKM DEDADAACCOO, DJFBKNFJCKG PEFFPCJPBOK, PEOJNAGCHAI NLGECAJFNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x25F8860", Offset = "0x25F7460", VA = "0x1825F8860")]
	public List<LAAJBKKLNIF>.Enumerator FIAIDFFFPCH()
	{
		return default(List<LAAJBKKLNIF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x25F86B0", Offset = "0x25F72B0", VA = "0x1825F86B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x25F88E0", Offset = "0x25F74E0", VA = "0x1825F88E0")]
	private void FKFBMFMNNHK(FDPMDKEHFKM DEDADAACCOO, EntityManager DEFMCCAEPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class EGFDPLCDJLP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly ObjectPrefabCreationService CEGBCPNNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly global::BGGCDGNEJCN<EFCKPAPAFFN> NJJIMPMKKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly World KJLAAKPMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private NativeHashMap<int, Entity> ABPGAGNPEME;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x22789C0", Offset = "0x22775C0", VA = "0x1822789C0")]
	public EGFDPLCDJLP(ObjectPrefabCreationService CEGBCPNNCHP, DJFBKNFJCKG PEFFPCJPBOK, PEOJNAGCHAI NLGECAJFNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2277B30", Offset = "0x2276730", VA = "0x182277B30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2277390", Offset = "0x2275F90", VA = "0x182277390")]
	public bool BBPANNNJEGD(GGPLMDHKFKM DFPCAFCOFNA, out Entity LILAAJNNHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x22773F0", Offset = "0x2275FF0", VA = "0x1822773F0")]
	private void BIPGEMGLIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2277CD0", Offset = "0x22768D0", VA = "0x182277CD0")]
	private EntityArchetype KOLPKCHJOIG(EntityArchetype DINNMDLKCJK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2278550", Offset = "0x2277150", VA = "0x182278550")]
	public static void OCDMDEMPMMD(EntityManager CEDJFMGFILP, EntityManager DDDACONLNAE, NativeArray<Entity> NMLKODKFIAJ, NativeArray<EntityArchetype> KMMLBEJMGLL, [Optional] NativeArray<Entity> PFDADOGPDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x22779D0", Offset = "0x22765D0", VA = "0x1822779D0")]
	[Conditional("DEBUG_BUILD")]
	private static void DJFMOENCBFF(NativeArray<EntityArchetype> PKNOPOAPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2278370", Offset = "0x2276F70", VA = "0x182278370")]
	private static string NCMBBCEMIFP(EntityArchetype NHDMIJDMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2277B90", Offset = "0x2276790", VA = "0x182277B90")]
	[CompilerGenerated]
	internal static void IEBOHHLCAPN(ref Span<ComponentType> GKFLKGIPEEF, ComponentType PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x22781D0", Offset = "0x2276DD0", VA = "0x1822781D0")]
	[CompilerGenerated]
	internal static void MCBMGHMJGEE(Span<ComponentType> MPENDCAONOC, ref Span<ComponentType> GKFLKGIPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x22788F0", Offset = "0x22774F0", VA = "0x1822788F0")]
	[CompilerGenerated]
	internal static void PBCFOJFPDKF(Span<ComponentType> MPENDCAONOC, ref Span<ComponentType> GKFLKGIPEEF, ComponentType JGCGCGPPLNH)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[KHHGHKHGGFN(EOABPLMDMOL.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private struct GBMFOGIOGHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public NIHGFLOMPHJ dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public GBMFOGIOGHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct EPMNHBBBLAL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			[ReadOnly]
			public NativeArray<byte> PDAHFHABHCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			[ReadOnly]
			public NativeList<int> CFGAMGPMLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> ACLAMKHAINJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public int GJLPBFKEEAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NIHGFLOMPHJ LAHMDNEBKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public ComponentType ABLJKBEKADN;

			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x25599E0", Offset = "0x25585E0", VA = "0x1825599E0")]
			internal void DMHMIBKCDOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x2559BB0", Offset = "0x25587B0", VA = "0x182559BB0", Slot = "5")]
			public void ReadFromDisplayClass(ref GBMFOGIOGHF GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x2559B80", Offset = "0x2558780", VA = "0x182559B80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x2559B90", Offset = "0x2558790", VA = "0x182559B90")]
			public void JOOHKCJALDF(ApplyPropertyDifferences FEPEPIEDFAD, ref GBMFOGIOGHF GGANILFKEIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private LNJHMHFINIC DGLKFIPALBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private JobHandle HMCFBJJLPJH;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x25562E0", Offset = "0x2554EE0", VA = "0x1825562E0")]
		public void HLHCNOFHMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x2555F60", Offset = "0x2554B60", VA = "0x182555F60", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x25562F0", Offset = "0x2554EF0", VA = "0x1825562F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2555FC0", Offset = "0x2554BC0", VA = "0x182555FC0")]
		private bool CFJPNEKEJCM(JobHandle HKCAPDPGJLE, int DGOFBPBLNGG, out JobHandle ENPHEKBFOAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[KHHGHKHGGFN(EOABPLMDMOL.PropertyChanges)]
	public abstract class ComputePropertyDifferences : GHIOHHHNFPK, GLEEPPGLLOC, MJAFAPEAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[BurstCompile]
		internal struct OKAHMENELBA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[ReadOnly]
			public NativeArray<byte> ILPKKFPKOKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			[ReadOnly]
			public NativeArray<byte> EPBGKBFOMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			[ReadOnly]
			public NativeArray<KDMHPBOIKOP> DKCAICEFIAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			[WriteOnly]
			public NativeList<IMBCKPCPJOH>.ParallelWriter LIKJGOOMKGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public int GLDFHBLNLNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public int AKPKBAAPHGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public ProfilerMarker NPJNOCCMJAM;

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x22E72C0", Offset = "0x22E5EC0", VA = "0x1822E72C0", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x22E7230", Offset = "0x22E5E30", VA = "0x1822E7230")]
			private unsafe int DLJNMNMPMME(byte* JAGDCMJNNBD, byte* GPCFBGLDMBJ)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[BurstCompile]
		internal struct JCMFPLANGLN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			[WriteOnly]
			public NativeList<int> CFGAMGPMLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			[WriteOnly]
			public NativeList<int> COMGNFLGEEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			[ReadOnly]
			public NativeList<IMBCKPCPJOH> IJBFHJAIOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public ProfilerMarker NPJNOCCMJAM;

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x22E56F0", Offset = "0x22E42F0", VA = "0x1822E56F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[BurstCompile]
		internal struct KPNGLPKBAMK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			[WriteOnly]
			public NativeArray<byte> FOKOPCNPPAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[ReadOnly]
			public NIHGFLOMPHJ JEKBFLBIDGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public int GJLPBFKEEAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public ProfilerMarker NPJNOCCMJAM;

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x22E6020", Offset = "0x22E4C20", VA = "0x1822E6020", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[BurstCompile]
		internal struct HFMIILBBGLE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, JIHJLEBKKBA> ODGJEJNAPMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public NativeArray<byte> ANDJPGLENEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public NativeArray<byte> PDAHFHABHCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[ReadOnly]
			public NativeArray<KDMHPBOIKOP> PDLIMODBPAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			[ReadOnly]
			public NativeList<int> HHJHOFJANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[ReadOnly]
			public NativeList<int> CFGAMGPMLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public int IAJDBMIODCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public int OMJOHPKCEHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public ProfilerMarker NPJNOCCMJAM;

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x22E4E20", Offset = "0x22E3A20", VA = "0x1822E4E20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static readonly ProfilerMarker OAEMENDDNPE;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private static readonly ProfilerMarker IGOKGLGALEM;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static readonly ProfilerMarker GONKJCHNDBH;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static readonly ProfilerMarker IPJLHPEFFNO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static readonly ProfilerMarker HEMNBPMFMFB;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static readonly ProfilerMarker OONOKECBKJH;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private static readonly ProfilerMarker GJPACEGMPOA;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private static readonly ProfilerMarker EBCGAKNAKGE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private static readonly ProfilerMarker IOAPEJCDPHH;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static readonly ProfilerMarker PKHHMPOLPNC;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static readonly ProfilerMarker GJKAJFFMGDJ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static readonly ProfilerMarker MMEDCJHIMPC;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static readonly ProfilerMarker FMDFPGMCHGD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static readonly ProfilerMarker EKDNAILJIBL;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly ProfilerMarker ICIJDECIEOO;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly ProfilerMarker HMFCKFBNAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private DLEACGMLCMC DGLKFIPALBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private ApplyPropertyDifferences GGNHHAAAOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private EntityQuery HFNDLPLEEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private EntityQuery LMHEGHLDAHC;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		protected abstract ApplyPropertyDifferences ICKINFJIDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		internal World EFBFALBAFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x2558C10", Offset = "0x2557810", VA = "0x182558C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2558500", Offset = "0x2557100", VA = "0x182558500")]
		internal LAAJBKKLNIF HPJPPEPCDPM(ComponentType ABLJKBEKADN)
		{
			return default(LAAJBKKLNIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2556F30", Offset = "0x2555B30", VA = "0x182556F30", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "15")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x2559300", Offset = "0x2557F00", VA = "0x182559300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2559450", Offset = "0x2558050", VA = "0x182559450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2559400", Offset = "0x2558000", VA = "0x182559400", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2557C70", Offset = "0x2556870", VA = "0x182557C70")]
		private void FOIKCCOFPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2556F90", Offset = "0x2555B90", VA = "0x182556F90")]
		private void BOGEOPLODIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x2557F20", Offset = "0x2556B20", VA = "0x182557F20")]
		internal void HFGHILOKDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x2558860", Offset = "0x2557460", VA = "0x182558860")]
		private void KGPNBAENONJ(NativeArray<Entity> NMLKODKFIAJ, NativeArray<RRObjectPrefabData> NJGIHGGFFKK, ref NativeArray<Entity> GHGMIAMNEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2558FA0", Offset = "0x2557BA0", VA = "0x182558FA0")]
		internal void MOMJIJGPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x25568A0", Offset = "0x25554A0", VA = "0x1825568A0")]
		internal void AJCFBBOHOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2557080", Offset = "0x2555C80", VA = "0x182557080")]
		private void CAFIAFIDJAK(LAAJBKKLNIF CMCJHIBMAKJ, bool NCOIJOBBFOO, ref JobHandle AHLCNBPDJKO, ref JobHandle JNCHJABEPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x25573F0", Offset = "0x2555FF0", VA = "0x1825573F0")]
		internal bool ELDMBMFKHPO(in LAAJBKKLNIF GPCFBGLDMBJ, out JobHandle PEIBOBCLLBF, out JIJEFOBIPAK EBHMPKHAMBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2557420", Offset = "0x2556020", VA = "0x182557420")]
		private bool ELDMBMFKHPO(in LAAJBKKLNIF GPCFBGLDMBJ, bool NCOIJOBBFOO, out JobHandle PEIBOBCLLBF, out JIJEFOBIPAK EBHMPKHAMBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2558A70", Offset = "0x2557670", VA = "0x182558A70")]
		internal (NativeList<int>, NativeList<int>) KNMNAEDNFEO(NativeList<IMBCKPCPJOH> IJBFHJAIOGG, int EFOLPOOCAHO, JobHandle HKCAPDPGJLE, out JobHandle NHBMKIBCLOB, Allocator KIPGDNHHBGE = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2559260", Offset = "0x2557E60", VA = "0x182559260")]
		internal static NativeArray<Entity> OFIHKMNNPHP(EntityQuery CLMPDPEACMB, out JobHandle LOIKPMNPEMC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2557370", Offset = "0x2555F70", VA = "0x182557370")]
		internal static NativeArray<byte> DLEODGOHAMD(int DNJADMBKFKK, out JobHandle CKBGCOCBAIH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2558C60", Offset = "0x2557860", VA = "0x182558C60")]
		internal static NativeArray<byte> LMHNHBBLMKP(EntityQuery CLMPDPEACMB, int DGOFBPBLNGG, out JobHandle CKBGCOCBAIH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2558730", Offset = "0x2557330", VA = "0x182558730")]
		internal static NativeArray<Entity> JFLILJDHBEK(EntityQuery CLMPDPEACMB, out JobHandle LFAJJHCILCG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2558DB0", Offset = "0x25579B0", VA = "0x182558DB0")]
		internal NativeArray<byte> MFNKBNIGNKF(NativeArray<Entity> PGMFELKKDCA, LAAJBKKLNIF CMCJHIBMAKJ, JobHandle HKCAPDPGJLE, out JobHandle NHBMKIBCLOB, Allocator KIPGDNHHBGE = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x25585A0", Offset = "0x25571A0", VA = "0x1825585A0")]
		internal JobHandle IFJLKDBDJBO(in JIJEFOBIPAK CEECNJJKNFO, in LAAJBKKLNIF CMCJHIBMAKJ, NativeMultiHashMap<Entity, JIHJLEBKKBA> ODGJEJNAPMJ, JobHandle HKCAPDPGJLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x22E18C0", Offset = "0x22E04C0", VA = "0x1822E18C0")]
		private JobHandle DKLFCIDNHJD(JobHandle BFDGHKDABLJ, JobHandle AMKLKEKGKEG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x22E18C0", Offset = "0x22E04C0", VA = "0x1822E18C0")]
		private JobHandle DKLFCIDNHJD(JobHandle BFDGHKDABLJ, JobHandle AMKLKEKGKEG, JobHandle BFGJHJMOLMM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class LDBLKMOPEDI : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery NNFCHDPPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private EntityQuery NLMHCHLHHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private EMDEHPHDHBH OABLJACAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x25FED60", Offset = "0x25FD960", VA = "0x1825FED60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x25FEB00", Offset = "0x25FD700", VA = "0x1825FEB00", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x25FEB60", Offset = "0x25FD760", VA = "0x1825FEB60")]
	private static void HEJGGAIEAAP(EntityQuery CLMPDPEACMB, EntityManager DEFMCCAEPJC, EMDEHPHDHBH NGFKPIIJJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x25FF000", Offset = "0x25FDC00", VA = "0x1825FF000")]
	private static void OMFKIMAJDGM(JICCIPMDHGH OMBBCDBECLD, EMDEHPHDHBH NGFKPIIJJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x25FF160", Offset = "0x25FDD60", VA = "0x1825FF160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x25FF300", Offset = "0x25FDF00", VA = "0x1825FF300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x25FF230", Offset = "0x25FDE30", VA = "0x1825FF230", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x25FEDB0", Offset = "0x25FD9B0", VA = "0x1825FEDB0")]
	private void OLOKMACBFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public LDBLKMOPEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct JICCIPMDHGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public CMPJNDPOACO DDOBILIIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private global::GOKMAJOKCDN<BLBOCCNKIPE> LALBFFOJEFG;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BLBOCCNKIPE LDIJIDKHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x25FC280", Offset = "0x25FAE80", VA = "0x1825FC280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x25FC2C0", Offset = "0x25FAEC0", VA = "0x1825FC2C0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class IBEEKCIANPP<UserTag, StateTag> : GHIOHHHNFPK, GLEEPPGLLOC where UserTag : struct, IComponentData where StateTag : struct, ISystemStateComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery DNGMLLLGILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery FJLACNLEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery CGGLGBPPLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private EntityQuery GOENLOKDPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery EFIHDCJMLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private EntityQuery CHHNDGFPLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private EntityQuery EHNLGDHEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected NMGBENFFOBL HJDLMNGCNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x33C1770", Offset = "0x33C0370", VA = "0x1833C1770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected virtual bool KEOHPKEFOII
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	protected virtual bool NCPIHGLAGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x33C1510", Offset = "0x33C0110", VA = "0x1833C1510", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x33C1AE0", Offset = "0x33C06E0", VA = "0x1833C1AE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x33C1E00", Offset = "0x33C0A00", VA = "0x1833C1E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected abstract void DDDIAHNHNOL(in JHNPAHOFJND FAIMOGKJCCG);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	protected abstract void BMGJDKHMAIL(in JHNPAHOFJND FAIMOGKJCCG);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	protected abstract void DDDIAHNHNOL(in CMPJNDPOACO DDOBILIIEDN);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	protected abstract void FOCEMNBCLKD();

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	protected abstract void KBLNBBJPMDF();

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	protected abstract void EELIOIFFIAJ();

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x33C1570", Offset = "0x33C0170", VA = "0x1833C1570")]
	private void LGFFBIAEPOO(Entity NNCGIOJNJIH, in JICCIPMDHGH OMBBCDBECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x33C12B0", Offset = "0x33BFEB0", VA = "0x1833C12B0")]
	private void ADFFABFHHHF(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x33C1680", Offset = "0x33C0280", VA = "0x1833C1680")]
	private void LPFEAGCDHED(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x33C3B00", Offset = "0x33C2700", VA = "0x1833C3B00")]
	protected IBEEKCIANPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x242A860", Offset = "0x2429460", VA = "0x18242A860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class MNBOEMAPPNK : global::NEELGOPIEFA<CGILNCPLECI>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	protected override OGNGNPGEEPO EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C2CE0", Offset = "0x9C18E0", VA = "0x1809C2CE0", Slot = "23")]
		get
		{
			return default(OGNGNPGEEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected override bool NCPIHGLAGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2560500", Offset = "0x255F100", VA = "0x182560500")]
	public MNBOEMAPPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x25604C0", Offset = "0x255F0C0", VA = "0x1825604C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class BMIDABOCLBE : global::NEELGOPIEFA<CGILNCPLECI>
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	protected override OGNGNPGEEPO EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x611E80", Offset = "0x610A80", VA = "0x180611E80", Slot = "23")]
		get
		{
			return default(OGNGNPGEEPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected override bool KEOHPKEFOII
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2272BE0", Offset = "0x22717E0", VA = "0x182272BE0")]
	public BMIDABOCLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2272BA0", Offset = "0x22717A0", VA = "0x182272BA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct NHIOGIEJHAH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class NEELGOPIEFA<Tag> : global::IBEEKCIANPP<Tag, NHIOGIEJHAH> where Tag : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	protected abstract OGNGNPGEEPO EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x3FA73F0", Offset = "0x3FA5FF0", VA = "0x183FA73F0", Slot = "17")]
	protected override void DDDIAHNHNOL(in JHNPAHOFJND FAIMOGKJCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7370", Offset = "0x3FA5F70", VA = "0x183FA7370", Slot = "18")]
	protected override void BMGJDKHMAIL(in JHNPAHOFJND FAIMOGKJCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7470", Offset = "0x3FA6070", VA = "0x183FA7470", Slot = "19")]
	protected override void DDDIAHNHNOL(in CMPJNDPOACO DDOBILIIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7670", Offset = "0x3FA6270", VA = "0x183FA7670", Slot = "20")]
	protected override void FOCEMNBCLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3FA76E0", Offset = "0x3FA62E0", VA = "0x183FA76E0", Slot = "21")]
	protected override void KBLNBBJPMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7580", Offset = "0x3FA6180", VA = "0x183FA7580", Slot = "22")]
	protected override void EELIOIFFIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBE890", VA = "0x181FBFC90")]
	protected NEELGOPIEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C9E0", Offset = "0x1F0B5E0", VA = "0x181F0C9E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class CPFFLBDIICM : global::FBIOHBBMHFD<GKNJLNJEPMI>
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected override OOEHAPFDLKJ EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x6C94D0", Offset = "0x6C80D0", VA = "0x1806C94D0", Slot = "23")]
		get
		{
			return default(OOEHAPFDLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected override bool NCPIHGLAGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2274AB0", Offset = "0x22736B0", VA = "0x182274AB0")]
	public CPFFLBDIICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x2274A70", Offset = "0x2273670", VA = "0x182274A70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct PHGPKADFDAH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class FBIOHBBMHFD<Tag> : global::IBEEKCIANPP<Tag, PHGPKADFDAH> where Tag : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract OOEHAPFDLKJ EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA6F0", Offset = "0x3BF92F0", VA = "0x183BFA6F0", Slot = "19")]
	protected override void DDDIAHNHNOL(in CMPJNDPOACO DDOBILIIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA670", Offset = "0x3BF9270", VA = "0x183BFA670", Slot = "18")]
	protected override void BMGJDKHMAIL(in JHNPAHOFJND FAIMOGKJCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA800", Offset = "0x3BF9400", VA = "0x183BFA800", Slot = "17")]
	protected override void DDDIAHNHNOL(in JHNPAHOFJND FAIMOGKJCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA970", Offset = "0x3BF9570", VA = "0x183BFA970", Slot = "20")]
	protected override void FOCEMNBCLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA9E0", Offset = "0x3BF95E0", VA = "0x183BFA9E0", Slot = "21")]
	protected override void KBLNBBJPMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BFA880", Offset = "0x3BF9480", VA = "0x183BFA880", Slot = "22")]
	protected override void EELIOIFFIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBE890", VA = "0x181FBFC90")]
	protected FBIOHBBMHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C9E0", Offset = "0x1F0B5E0", VA = "0x181F0C9E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class CLKALALNKPI : global::FBIOHBBMHFD<GKNJLNJEPMI>
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected override OOEHAPFDLKJ EGHCAJDNCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9030", Offset = "0x6C7C30", VA = "0x1806C9030", Slot = "23")]
		get
		{
			return default(OOEHAPFDLKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected override bool KEOHPKEFOII
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2274790", Offset = "0x2273390", VA = "0x182274790")]
	public CLKALALNKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2274750", Offset = "0x2273350", VA = "0x182274750", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class NDBDEAGKOGC : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JBBPAPCMDHJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		private struct IDADAKPFCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			public struct NIPHJAMDAFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FE")]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FF")]
				public LambdaParameterValueProvider_IComponentData<JICCIPMDHGH>.Runtime MLJGNAMNLME;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JICCIPMDHGH> AHCADALAELI;

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x255AD70", Offset = "0x2559970", VA = "0x18255AD70")]
			public void JOOHKCJALDF(NDBDEAGKOGC FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x255ACF0", Offset = "0x25598F0", VA = "0x18255ACF0")]
			public NIPHJAMDAFG HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(NIPHJAMDAFG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public NDBDEAGKOGC GKPKKFIOHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private IDADAKPFCDJ DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IDADAKPFCDJ.NIPHJAMDAFG* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x255ADD0", Offset = "0x25599D0", VA = "0x18255ADD0")]
		public void DMHMIBKCDOO(Entity NNCGIOJNJIH, [In] ref JICCIPMDHGH OMBBCDBECLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x255ADF0", Offset = "0x25599F0", VA = "0x18255ADF0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x255AE90", Offset = "0x2559A90", VA = "0x18255AE90")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, ref IDADAKPFCDJ.NIPHJAMDAFG MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x255AF40", Offset = "0x2559B40", VA = "0x18255AF40")]
		public void JOOHKCJALDF(NDBDEAGKOGC FEPEPIEDFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x255AFC0", Offset = "0x2559BC0", VA = "0x18255AFC0")]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private EntityHierarchyChildren PPLIDDKCFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private EntityQuery KMPBIILFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private ProfilerMarker AOIJAOLKNHP;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private NMGBENFFOBL HJDLMNGCNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2561860", Offset = "0x2560460", VA = "0x182561860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x25614A0", Offset = "0x25600A0", VA = "0x1825614A0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2561A80", Offset = "0x2560680", VA = "0x182561A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2561520", Offset = "0x2560120", VA = "0x182561520")]
	private void GFEHIOHFHEP(Entity NNCGIOJNJIH, in JICCIPMDHGH OMBBCDBECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x25616C0", Offset = "0x25602C0", VA = "0x1825616C0")]
	private void LGFFBIAEPOO(Entity NNCGIOJNJIH, in JICCIPMDHGH OMBBCDBECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x2561530", Offset = "0x2560130", VA = "0x182561530")]
	private void IPEHHBFIGLM(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x25617E0", Offset = "0x25603E0", VA = "0x1825617E0")]
	private void LPFEAGCDHED(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public NDBDEAGKOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x2561520", Offset = "0x2560120", VA = "0x182561520")]
	[CompilerGenerated]
	private void ONDCMNFDHKN(Entity NNCGIOJNJIH, in JICCIPMDHGH OMBBCDBECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x25618B0", Offset = "0x25604B0", VA = "0x1825618B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2561340", Offset = "0x255FF40", VA = "0x182561340")]
	public static EntityQuery BHBKNOEAHCM(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public abstract class GFDBGJEPHJK : OLOJNJEFDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	protected readonly GDHDBKNKOKH NDMJKBJOMGA;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected JHMPJMIHIEB HPBAFHAKIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x227FF50", Offset = "0x227EB50", VA = "0x18227FF50")]
		get
		{
			return default(JHMPJMIHIEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	protected Entity CMGIPAKOGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x227E330", Offset = "0x227CF30", VA = "0x18227E330")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	protected ALMILKEKENF FHHJJOHBFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected AKDHBKEIEHJ GBKMFNDEMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x227ED30", Offset = "0x227D930", VA = "0x18227ED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	protected KJFKLHABFME IKFKPLOGFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x227F7C0", Offset = "0x227E3C0", VA = "0x18227F7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	protected KKNBPBMPKBC JHPPONDDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x227ECB0", Offset = "0x227D8B0", VA = "0x18227ECB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private LMMBNFLDKGF KLFJCHNBFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x227FF90", Offset = "0x227EB90", VA = "0x18227FF90", Slot = "12")]
		get
		{
			return default(LMMBNFLDKGF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x227FA00", Offset = "0x227E600", VA = "0x18227FA00", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private GameObject ABGCGOCBIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x227EA80", Offset = "0x227D680", VA = "0x18227EA80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private Matrix4x4 EEPKFCOINFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x227ED80", Offset = "0x227D980", VA = "0x18227ED80", Slot = "14")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private Vector3 CNABGHDHEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x227EFA0", Offset = "0x227DBA0", VA = "0x18227EFA0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x227F6D0", Offset = "0x227E2D0", VA = "0x18227F6D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private Quaternion DFOHNBHBBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x227E990", Offset = "0x227D590", VA = "0x18227E990", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x227EAD0", Offset = "0x227D6D0", VA = "0x18227EAD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private Vector3 LJCPBKKDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x227FE60", Offset = "0x227EA60", VA = "0x18227FE60", Slot = "16")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x227EBC0", Offset = "0x227D7C0", VA = "0x18227EBC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private Matrix4x4 HPPIMJPGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x227FC30", Offset = "0x227E830", VA = "0x18227FC30", Slot = "15")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private Vector3 JIDGJHKOJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x227F1C0", Offset = "0x227DDC0", VA = "0x18227F1C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x227F2B0", Offset = "0x227DEB0", VA = "0x18227F2B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Quaternion GGFFBCEDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x227FD70", Offset = "0x227E970", VA = "0x18227FD70", Slot = "10")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2280280", Offset = "0x227EE80", VA = "0x182280280", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private Vector3 JFHFKPOILPA
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x227F3A0", Offset = "0x227DFA0", VA = "0x18227F3A0", Slot = "18")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Vector3 NDFCHICFBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2280370", Offset = "0x227EF70", VA = "0x182280370", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x227F490", Offset = "0x227E090", VA = "0x18227F490", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private Vector3 CDMDJLHPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x227E7D0", Offset = "0x227D3D0", VA = "0x18227E7D0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x227E590", Offset = "0x227D190", VA = "0x18227E590", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private Vector3 HOFPOIKLNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x227F840", Offset = "0x227E440", VA = "0x18227F840", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x227E350", Offset = "0x227CF50", VA = "0x18227E350", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D90", Offset = "0x6F6990", VA = "0x1806F7D90")]
	protected GFDBGJEPHJK(GDHDBKNKOKH MFHBAEBOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x227F090", Offset = "0x227DC90", VA = "0x18227F090")]
	protected LMMBNFLDKGF GONPBILDEDE()
	{
		return default(LMMBNFLDKGF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x226B760", Offset = "0x226A360", VA = "0x18226B760")]
	public static LMMBNFLDKGF EDHAFEIJFCP(GFDBGJEPHJK JJBHDPAHMPA)
	{
		return default(LMMBNFLDKGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class AJMKKFBILOP : GFDBGJEPHJK, BLBOCCNKIPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private const string HOIDKDEFJBD = "RenderContainerWrapper";

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LMMBNFLDKGF CGNEMPAMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x226B760", Offset = "0x226A360", VA = "0x18226B760", Slot = "26")]
		get
		{
			return default(LMMBNFLDKGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IEGLCOKJOLH BDOBOEJGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x6AF390", Offset = "0x6ADF90", VA = "0x1806AF390", Slot = "27")]
		get
		{
			return default(IEGLCOKJOLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x226B6C0", Offset = "0x226A2C0", VA = "0x18226B6C0")]
	public AJMKKFBILOP(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x226B650", Offset = "0x226A250", VA = "0x18226B650", Slot = "28")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class CCHNDDMNKPL : CJLLBGEOJDH, JCIFAILOKAO, COOIOEIAAOB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct JIEBFPIJJEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public int pointCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public bool preventInvertedCreation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public Vector3 prevTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public SplinePointData currPointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public SplinePointData nextPointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public CCHNDDMNKPL <>4__this;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NativeList<DACMAJGNCFF> FGACMGHHGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private bool BHOINDOBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private bool LHEDENFIODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private float MGOHKMPLGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private int OHLGGILMHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private bool FCFEOHHMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private int NPPAPHOFJGO;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private PMDIHHGIGCD FIMAJFDEMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x22731C0", Offset = "0x2271DC0", VA = "0x1822731C0")]
		get
		{
			return default(PMDIHHGIGCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private bool POLHMEOHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x60F820", Offset = "0x60E420", VA = "0x18060F820", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private bool PPLGMKNPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x60F810", Offset = "0x60E410", VA = "0x18060F810", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private float LEPEENJLOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1A07400", Offset = "0x1A06000", VA = "0x181A07400", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private int ICOHNKNNPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x60F8D0", Offset = "0x60E4D0", VA = "0x18060F8D0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool BDHOOIOEOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x11145E0", Offset = "0x11131E0", VA = "0x1811145E0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private int NGDDJBAKEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x67F620", Offset = "0x67E220", VA = "0x18067F620", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2273DB0", Offset = "0x22729B0", VA = "0x182273DB0")]
	public CCHNDDMNKPL(GDHDBKNKOKH MFHBAEBOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2272F80", Offset = "0x2271B80", VA = "0x182272F80", Slot = "33")]
	public override void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x2273270", Offset = "0x2271E70", VA = "0x182273270", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2273830", Offset = "0x2272430", VA = "0x182273830", Slot = "40")]
	private NativeArray<DACMAJGNCFF> PKPGJLABHDB()
	{
		return default(NativeArray<DACMAJGNCFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x22735C0", Offset = "0x22721C0", VA = "0x1822735C0")]
	private static Vector3 KMJIECDLCBM(int LKGKJOMCLLO, int AAGCLNHDCON, bool KCOBNFOIPCI, in Vector3 GJNLEEEPOKA, in SplinePointData DLHLDBBHNPK, in SplinePointData ENDDILJOJCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x22732D0", Offset = "0x2271ED0", VA = "0x1822732D0")]
	private static Quaternion HDCFOFBCOCF(int LKGKJOMCLLO, int AAGCLNHDCON, bool KCOBNFOIPCI, ref Vector3 GJNLEEEPOKA, in SplinePointData DLHLDBBHNPK, in SplinePointData ENDDILJOJCP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2273C50", Offset = "0x2272850", VA = "0x182273C50")]
	[CompilerGenerated]
	private void POCNNCOJHMO(int LKGKJOMCLLO, ref JIEBFPIJJEP P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class IJGMJADFABF : CJLLBGEOJDH, JGIENIGGMIN, COOIOEIAAOB
{
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private static readonly Dictionary<AGOBHJFJLNP, KODIEEBLFLF> EPONKOOJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private KODIEEBLFLF EBLHLGNAFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool LFOCHCEKPEG;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private EPALBEJCGHN FJMHGBEODAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x25F8F40", Offset = "0x25F7B40", VA = "0x1825F8F40")]
		get
		{
			return default(EPALBEJCGHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private KODIEEBLFLF HLBACDEJNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x73FCD0", Offset = "0x73E8D0", VA = "0x18073FCD0", Slot = "34")]
		get
		{
			return default(KODIEEBLFLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool IFEIBMMFINA
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF130", Offset = "0x7ADD30", VA = "0x1807AF130", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x25F9180", Offset = "0x25F7D80", VA = "0x1825F9180")]
	public IJGMJADFABF(GDHDBKNKOKH MFHBAEBOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x25F8E10", Offset = "0x25F7A10", VA = "0x1825F8E10", Slot = "33")]
	public override void ADGIMOCDCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public abstract class CJLLBGEOJDH : GFDBGJEPHJK, COOIOEIAAOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private float FIOIFMEPJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private Vector3 JOBFGAEILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private BMOEILFIHJP PJGKAHJGLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private DPANBBAKMDL AEJCCCPBFBN;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2274420", Offset = "0x2273020", VA = "0x182274420")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected DJFBKNFJCKG ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x22742A0", Offset = "0x2272EA0", VA = "0x1822742A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	protected DMFKDOOKGAJ AAEMACHOPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x2274320", Offset = "0x2272F20", VA = "0x182274320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	protected ShapeConfigData HFHEDMFGMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2274380", Offset = "0x2272F80", VA = "0x182274380")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected GBPBLNEMGON IGHEJOGDAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x22741D0", Offset = "0x2272DD0", VA = "0x1822741D0")]
		get
		{
			return default(GBPBLNEMGON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private LMMBNFLDKGF IELJBOKABMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x226B760", Offset = "0x226A360", VA = "0x18226B760", Slot = "26")]
		get
		{
			return default(LMMBNFLDKGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private float MNHDFJENCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x134D4F0", Offset = "0x134C0F0", VA = "0x18134D4F0", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Vector3 KJFBAFGBCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x124F4E0", Offset = "0x124E0E0", VA = "0x18124F4E0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private BMOEILFIHJP GPGEAAECECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x60F7E0", Offset = "0x60E3E0", VA = "0x18060F7E0", Slot = "29")]
		get
		{
			return default(BMOEILFIHJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private DPANBBAKMDL GFEOLALBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x6350F0", Offset = "0x633CF0", VA = "0x1806350F0", Slot = "30")]
		get
		{
			return default(DPANBBAKMDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2274480", Offset = "0x2273080", VA = "0x182274480")]
	protected CJLLBGEOJDH(GDHDBKNKOKH MFHBAEBOKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "32")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x2274100", Offset = "0x2272D00", VA = "0x182274100", Slot = "33")]
	public virtual void ADGIMOCDCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class JCJNBFFMOFC : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private EntityQuery IEKPGIPFBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private EntityQuery LANPCHKHBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private EntityQuery MCMKEHOJLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private EMDEHPHDHBH OABLJACAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x25FB5F0", Offset = "0x25FA1F0", VA = "0x1825FB5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x25FB110", Offset = "0x25F9D10", VA = "0x1825FB110", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x25FB6B0", Offset = "0x25FA2B0", VA = "0x1825FB6B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x25FB930", Offset = "0x25FA530", VA = "0x1825FB930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x25FB3C0", Offset = "0x25F9FC0", VA = "0x1825FB3C0")]
	private void JHEADJHFGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x25FB190", Offset = "0x25F9D90", VA = "0x1825FB190")]
	private void IAADIEFEHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x25FB640", Offset = "0x25FA240", VA = "0x1825FB640")]
	private void OCDKKPEIIFM(EntityQuery CLMPDPEACMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x25FAE80", Offset = "0x25F9A80", VA = "0x1825FAE80")]
	private CMPJNDPOACO AMBGIKCEDOA(Entity NNCGIOJNJIH)
	{
		return default(CMPJNDPOACO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public JCJNBFFMOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct MFGPOPMCBBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public CMPJNDPOACO DDOBILIIEDN;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class FJGIEENMGNF : global::HHBMIIICHHN<PrimitiveShapeData, EEJADEKOOKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private EntityQuery BNPNDGEKNHE;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x227C0C0", Offset = "0x227ACC0", VA = "0x18227C0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x227C020", Offset = "0x227AC20", VA = "0x18227C020", Slot = "15")]
	protected override void BCMLCONNPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x227B7E0", Offset = "0x227A3E0", VA = "0x18227B7E0")]
	public FJGIEENMGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x227B7A0", Offset = "0x227A3A0", VA = "0x18227B7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[AlwaysUpdateSystem]
public abstract class HHBMIIICHHN<ShapeComponentData, ShapeRenderHandleStateData> : GHIOHHHNFPK, GLEEPPGLLOC where ShapeComponentData : struct, IComponentData where ShapeRenderHandleStateData : struct, AJINIMLAONN
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private struct IAHAGAEFEAB : HFOHGLLLBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[ReadOnly]
		public ArchetypeChunkComponentType<MFGPOPMCBBN> MABDDDKMCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> KNLFCPCDMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[WriteOnly]
		public NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> CNBCCJPEHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public EMDEHPHDHBH NGFKPIIJJFL;

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x43AB380", Offset = "0x43A9F80", VA = "0x1843AB380", Slot = "4")]
		public void DGHOBJEPAPD(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private struct JNGDCOGLLNG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> PMIIDGONMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> HDAAOLGCHOP;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x43AB570", Offset = "0x43AA170", VA = "0x1843AB570", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private struct CDMGBOKMJHO : HFOHGLLLBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> ONAKNGFOLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[WriteOnly]
		public NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> JJMHKIMPMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public EMDEHPHDHBH NGFKPIIJJFL;

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x4397130", Offset = "0x4395D30", VA = "0x184397130", Slot = "4")]
		public void DGHOBJEPAPD(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private static readonly ProfilerMarker NMIHKBKNIML;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private static readonly ProfilerMarker MBGHODNPFEC;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private static readonly ProfilerMarker MDBGMAHBJJK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private static readonly ProfilerMarker HBJBNMDLNDE;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private static readonly ProfilerMarker JPMEHBEBLGC;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private static readonly ProfilerMarker BNDCKDBGOII;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly ProfilerMarker HIGHCAJBOFM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly ProfilerMarker BKPPMBMEKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private EntityQuery PGHLJBKPHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private EntityQuery MNNOGLOFBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private EntityQuery KEMBHPNNDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private EntityQuery EALGMJGHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private EntityQuery LPPFJBBFIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private EntityQuery EBBBFOLGHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private EntityQuery BKKDNFMIOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private EntityQuery KDNDPEHLLEM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private const int MKGNLMLMHEL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int PLBJALCJDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private HashSet<CMPJNDPOACO> JCGMMGIHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private Queue<CMPJNDPOACO> EKNOEKMAODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	protected CAOPEEFBAOK LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	protected ALMILKEKENF JFBMPLDKGJF;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected EMDEHPHDHBH OABLJACAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x439EB00", Offset = "0x439D700", VA = "0x18439EB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x439BFE0", Offset = "0x439ABE0", VA = "0x18439BFE0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x439F8F0", Offset = "0x439E4F0", VA = "0x18439F8F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x439FDC0", Offset = "0x439E9C0", VA = "0x18439FDC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x439FD80", Offset = "0x439E980", VA = "0x18439FD80", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x439C0E0", Offset = "0x439ACE0", VA = "0x18439C0E0")]
	private void CMNOLMKGLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x439F080", Offset = "0x439DC80", VA = "0x18439F080")]
	private NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> OLEEAIKJJFN(EntityQuery CLMPDPEACMB)
	{
		return default(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x439BE50", Offset = "0x439AA50", VA = "0x18439BE50", Slot = "15")]
	protected virtual void BCMLCONNPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x439DE60", Offset = "0x439CA60", VA = "0x18439DE60")]
	private void KFCOMOODAOG(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> JBALNBKMCML, NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> JOBMJEINPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x439EBA0", Offset = "0x439D7A0", VA = "0x18439EBA0")]
	private void NKNMOOHLKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x439DC40", Offset = "0x439C840", VA = "0x18439DC40")]
	protected (NativeArray<ShapeRenderHandleStateData>, JobHandle) JDFNCJMLJDL(EntityQuery CLMPDPEACMB)
	{
		return default((NativeArray<ShapeRenderHandleStateData>, JobHandle));
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x439CEE0", Offset = "0x439BAE0", VA = "0x18439CEE0")]
	protected void DHIIBEJLJFP((NativeArray<ShapeRenderHandleStateData> shapeHandles, JobHandle job) CEECNJJKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x439DA60", Offset = "0x439C660", VA = "0x18439DA60")]
	private NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> JCHEDLNCFFB(EntityQuery CLMPDPEACMB)
	{
		return default(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x439E800", Offset = "0x439D400", VA = "0x18439E800")]
	private NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> MMCGBOGMKHP(EntityQuery CLMPDPEACMB, out JobHandle NHBMKIBCLOB)
	{
		return default(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x439D2C0", Offset = "0x439BEC0", VA = "0x18439D2C0")]
	private void EKFJKPDLFFN(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> EHNLGDHEENH, JobHandle NHBMKIBCLOB, ProfilerMarker GEPAOJOGPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x439BCA0", Offset = "0x439A8A0", VA = "0x18439BCA0")]
	private NativeHashMap<CMPJNDPOACO, JPLMCCNINHK> AAODLIFADAC(EntityQuery CLMPDPEACMB)
	{
		return default(NativeHashMap<CMPJNDPOACO, JPLMCCNINHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x43A04B0", Offset = "0x439F0B0", VA = "0x1843A04B0")]
	protected HHBMIIICHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x242A860", Offset = "0x2429460", VA = "0x18242A860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface AJINIMLAONN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	CMPJNDPOACO LPALAGJNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JHNPAHOFJND HAEEDDKGBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADGIMOCDCAK();

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMFPNEDOEKL(GDHDBKNKOKH IFPFHNLOHFM);

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNDAKLNFBHA();

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADEIGBNFMOJ(CMPJNDPOACO DDOBILIIEDN, EMDEHPHDHBH NGFKPIIJJFL);

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOJGBONAJLB(EMDEHPHDHBH NGFKPIIJJFL);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct EEJADEKOOKE : AJINIMLAONN, ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private global::GOKMAJOKCDN<IJGMJADFABF> HHHONCLKJEC;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public CMPJNDPOACO LPALAGJNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2277140", Offset = "0x2275D40", VA = "0x182277140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CMPJNDPOACO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2277150", Offset = "0x2275D50", VA = "0x182277150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public JHNPAHOFJND HAEEDDKGBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2277160", Offset = "0x2275D60", VA = "0x182277160", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JHNPAHOFJND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x22771E0", Offset = "0x2275DE0", VA = "0x1822771E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x22771F0", Offset = "0x2275DF0", VA = "0x1822771F0", Slot = "7")]
	public void LMFPNEDOEKL(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x2277170", Offset = "0x2275D70", VA = "0x182277170", Slot = "8")]
	public void HNDAKLNFBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x22770E0", Offset = "0x2275CE0", VA = "0x1822770E0", Slot = "6")]
	public void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x2276FF0", Offset = "0x2275BF0", VA = "0x182276FF0", Slot = "9")]
	public void ADEIGBNFMOJ(CMPJNDPOACO DDOBILIIEDN, EMDEHPHDHBH NGFKPIIJJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x2277270", Offset = "0x2275E70", VA = "0x182277270", Slot = "10")]
	public void LOJGBONAJLB(EMDEHPHDHBH NGFKPIIJJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct JHFAPDHDIGB : AJINIMLAONN, ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private global::GOKMAJOKCDN<CCHNDDMNKPL> CEDGKJOIHMD;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public CMPJNDPOACO LPALAGJNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2277140", Offset = "0x2275D40", VA = "0x182277140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CMPJNDPOACO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2277150", Offset = "0x2275D50", VA = "0x182277150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public JHNPAHOFJND HAEEDDKGBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2277160", Offset = "0x2275D60", VA = "0x182277160", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JHNPAHOFJND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x22771E0", Offset = "0x2275DE0", VA = "0x1822771E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x25FBE80", Offset = "0x25FAA80", VA = "0x1825FBE80", Slot = "7")]
	public void LMFPNEDOEKL(GDHDBKNKOKH IFPFHNLOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x25FBE10", Offset = "0x25FAA10", VA = "0x1825FBE10", Slot = "8")]
	public void HNDAKLNFBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x25FBDB0", Offset = "0x25FA9B0", VA = "0x1825FBDB0", Slot = "6")]
	public void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x25FBCC0", Offset = "0x25FA8C0", VA = "0x1825FBCC0", Slot = "9")]
	public void ADEIGBNFMOJ(CMPJNDPOACO DDOBILIIEDN, EMDEHPHDHBH NGFKPIIJJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x25FBF00", Offset = "0x25FAB00", VA = "0x1825FBF00", Slot = "10")]
	public void LOJGBONAJLB(EMDEHPHDHBH NGFKPIIJJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class MDPKLBLGFPN : global::HHBMIIICHHN<SplineData, JHFAPDHDIGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery AFBMAMLMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private EntityQuery KAFIIIPDJPL;

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x255F370", Offset = "0x255DF70", VA = "0x18255F370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x255F230", Offset = "0x255DE30", VA = "0x18255F230", Slot = "15")]
	protected override void BCMLCONNPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x255F480", Offset = "0x255E080", VA = "0x18255F480")]
	public MDPKLBLGFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x255F330", Offset = "0x255DF30", VA = "0x18255F330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public class EJJANMLJPAF : OICGEACCMCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct LMJCFJICOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public LMJCFJICOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct DNFOJIDBJFH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private struct INEGPMFEBFP
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[NoAlias]
			public struct GDMKCNPKPLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000350")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime AAIMFBOGKIL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> ELBOMHLMKEG;

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x22815E0", Offset = "0x22801E0", VA = "0x1822815E0")]
			public void JOOHKCJALDF(EJJANMLJPAF FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x2281590", Offset = "0x2280190", VA = "0x182281590")]
			public GDMKCNPKPLF HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(GDMKCNPKPLF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public NativeArray<int> MPENDCAONOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private INEGPMFEBFP DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe INEGPMFEBFP.GDMKCNPKPLF* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MEHHPEHJOID;

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2276770", Offset = "0x2275370", VA = "0x182276770")]
		internal void DMHMIBKCDOO(ref AuthoredLocalPoseData BCFFIIGLFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
		public void ReadFromDisplayClass(ref LMJCFJICOGM GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x226BC00", Offset = "0x226A800", VA = "0x18226BC00", Slot = "6")]
		public void WriteToDisplayClass(ref LMJCFJICOGM GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2276870", Offset = "0x2275470", VA = "0x182276870", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x22768F0", Offset = "0x22754F0", VA = "0x1822768F0")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref INEGPMFEBFP.GDMKCNPKPLF MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2276980", Offset = "0x2275580", VA = "0x182276980")]
		public void JOOHKCJALDF(EJJANMLJPAF FEPEPIEDFAD, ref LMJCFJICOGM GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2276A00", Offset = "0x2275600", VA = "0x182276A00")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private EntityQuery KMPBIILFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private ProfilerMarker AOIJAOLKNHP;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x22790C0", Offset = "0x2277CC0", VA = "0x1822790C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public EJJANMLJPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x2278EE0", Offset = "0x2277AE0", VA = "0x182278EE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x2278DB0", Offset = "0x22779B0", VA = "0x182278DB0")]
	public static EntityQuery BHBKNOEAHCM(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public class DLNGJKMFNAC : OICGEACCMCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct KFCKHHFHAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public KFCKHHFHAAK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct ADPLCEBEFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public KFCKHHFHAAK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public ADPLCEBEFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HAFKPGOOHKO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		private struct NJIGGODPIEK
		{
			[Cpp2IlInjected.Token(Token = "0x2000108")]
			[NoAlias]
			public struct FOMLFMBEBOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime FPJGIGJDAHM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> DFCGKDIDJJK;

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x2281F70", Offset = "0x2280B70", VA = "0x182281F70")]
			public void JOOHKCJALDF(DLNGJKMFNAC FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x2281EF0", Offset = "0x2280AF0", VA = "0x182281EF0")]
			public FOMLFMBEBOK HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(FOMLFMBEBOK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public EntityManager DEFMCCAEPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public NativeList<Entity> CFGNFCHHMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private NJIGGODPIEK DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NJIGGODPIEK.FOMLFMBEBOK* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MEHHPEHJOID;

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x2280FC0", Offset = "0x227FBC0", VA = "0x182280FC0")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, SplinePointData LFHAKIFFEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x22812A0", Offset = "0x227FEA0", VA = "0x1822812A0", Slot = "5")]
		public void ReadFromDisplayClass(ref ADPLCEBEFBD GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x22812B0", Offset = "0x227FEB0", VA = "0x1822812B0", Slot = "6")]
		public void WriteToDisplayClass(ref ADPLCEBEFBD GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x2281040", Offset = "0x227FC40", VA = "0x182281040", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x22810E0", Offset = "0x227FCE0", VA = "0x1822810E0")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref NJIGGODPIEK.FOMLFMBEBOK MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x22811B0", Offset = "0x227FDB0", VA = "0x1822811B0")]
		public void JOOHKCJALDF(DLNGJKMFNAC FEPEPIEDFAD, ref ADPLCEBEFBD GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x2281240", Offset = "0x227FE40", VA = "0x182281240")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EntityQuery KMPBIILFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private ProfilerMarker AOIJAOLKNHP;

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x22764D0", Offset = "0x22750D0", VA = "0x1822764D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public DLNGJKMFNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x22762F0", Offset = "0x2274EF0", VA = "0x1822762F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x22761C0", Offset = "0x2274DC0", VA = "0x1822761C0")]
	public static EntityQuery BHBKNOEAHCM(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class LDGDOOHPAAH : OICGEACCMCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery CMABIPLLPNE;

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x26000F0", Offset = "0x25FECF0", VA = "0x1826000F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2600170", Offset = "0x25FED70", VA = "0x182600170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public LDGDOOHPAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public class GIBPKPMFPMA : OICGEACCMCG, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct NBKOHIFKIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public NativeHashMap<EEDOLIFAKPN, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public NBKOHIFKIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BAENDIIBEJB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		private struct OKOCJNKEFED
		{
			[Cpp2IlInjected.Token(Token = "0x200010E")]
			public struct LGCINPMMMKK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime FBNALJCJHNC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FLBGEEAOBLC;

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x22821E0", Offset = "0x2280DE0", VA = "0x1822821E0")]
			public void JOOHKCJALDF(GIBPKPMFPMA FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2282160", Offset = "0x2280D60", VA = "0x182282160")]
			public LGCINPMMMKK HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(LGCINPMMMKK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public NativeHashMap<EEDOLIFAKPN, Entity> MIFOEAMJCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private OKOCJNKEFED DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OKOCJNKEFED.LGCINPMMMKK* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x226B930", Offset = "0x226A530", VA = "0x18226B930")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, ObjectNetworkIdComponentData PHDFPOMAHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
		public void ReadFromDisplayClass(ref NBKOHIFKIOA GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x226BC00", Offset = "0x226A800", VA = "0x18226BC00", Slot = "6")]
		public void WriteToDisplayClass(ref NBKOHIFKIOA GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x226B9B0", Offset = "0x226A5B0", VA = "0x18226B9B0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x226BA50", Offset = "0x226A650", VA = "0x18226BA50")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, ref OKOCJNKEFED.LGCINPMMMKK MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x226BB00", Offset = "0x226A700", VA = "0x18226BB00")]
		public void JOOHKCJALDF(GIBPKPMFPMA FEPEPIEDFAD, ref NBKOHIFKIOA GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x226BB90", Offset = "0x226A790", VA = "0x18226BB90")]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private ObjectNetworkToLocalMapService CCIEDGODKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private EntityQuery KMPBIILFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private ProfilerMarker AOIJAOLKNHP;

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2280680", Offset = "0x227F280", VA = "0x182280680", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2280890", Offset = "0x227F490", VA = "0x182280890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public GIBPKPMFPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x22806E0", Offset = "0x227F2E0", VA = "0x1822806E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x2280550", Offset = "0x227F150", VA = "0x182280550")]
	public static EntityQuery BHBKNOEAHCM(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[KHHGHKHGGFN(EOABPLMDMOL.Embodiment)]
	public class PostLoadInitializeEmbodiment : GHIOHHHNFPK, GLEEPPGLLOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private struct OHLMPJHJPOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public NativeHashMap<Entity, EEDOLIFAKPN> networkIds;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public OHLMPJHJPOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <AppendRoots>b__0(Entity entity, ObjectNetworkIdComponentData component, int entityInQueryIndex)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct KGOIGDGLMPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, EEDOLIFAKPN> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public ComponentDataFromEntity<ParentData> parentsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdByEntity;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
			public KGOIGDGLMPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
			internal void <AppendDescendants>b__0(Entity entity, ObjectNetworkIdComponentData component, int entityInQueryIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct PMEIBOKOLBO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000113")]
			private struct GBEKCLAKDLJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000114")]
				[NoAlias]
				public struct PGBPFNGJJIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000383")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime CEKHGOGOMFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000384")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime FJPLAIPAEKB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> KNIKMPNFBEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex FMIEDFJALPL;

				[Cpp2IlInjected.Token(Token = "0x60007C9")]
				[Cpp2IlInjected.Address(RVA = "0x22E4C80", Offset = "0x22E3880", VA = "0x1822E4C80")]
				public void JOOHKCJALDF(PostLoadInitializeEmbodiment FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007CA")]
				[Cpp2IlInjected.Address(RVA = "0x22E4BC0", Offset = "0x22E37C0", VA = "0x1822E4BC0")]
				public PGBPFNGJJIC HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(PGBPFNGJJIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public NativeHashMap<Entity, EEDOLIFAKPN> LKDMNFLBNMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private GBEKCLAKDLJ DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GBEKCLAKDLJ.PGBPFNGJJIC* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MEHHPEHJOID;

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x22EC2A0", Offset = "0x22EAEA0", VA = "0x1822EC2A0")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, ObjectNetworkIdComponentData GPCFBGLDMBJ, int MNNFJAIOKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
			public void ReadFromDisplayClass(ref OHLMPJHJPOJ GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0x226BC00", Offset = "0x226A800", VA = "0x18226BC00", Slot = "6")]
			public void WriteToDisplayClass(ref OHLMPJHJPOJ GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0x22EC300", Offset = "0x22EAF00", VA = "0x1822EC300", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x22EC3F0", Offset = "0x22EAFF0", VA = "0x1822EC3F0")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref GBEKCLAKDLJ.PGBPFNGJJIC MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x22EC4B0", Offset = "0x22EB0B0", VA = "0x1822EC4B0")]
			public void JOOHKCJALDF(PostLoadInitializeEmbodiment FEPEPIEDFAD, ref OHLMPJHJPOJ GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x22EC550", Offset = "0x22EB150", VA = "0x1822EC550")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LIFKLLKJBPP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			private struct GCBEGGIPPOK
			{
				[Cpp2IlInjected.Token(Token = "0x2000117")]
				[NoAlias]
				public struct LIAMNBHDIEJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400038F")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000390")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime CEKHGOGOMFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000391")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime FJPLAIPAEKB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400038C")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400038D")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> KNIKMPNFBEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400038E")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex FMIEDFJALPL;

				[Cpp2IlInjected.Token(Token = "0x60007D3")]
				[Cpp2IlInjected.Address(RVA = "0x22E4DB0", Offset = "0x22E39B0", VA = "0x1822E4DB0")]
				public void JOOHKCJALDF(PostLoadInitializeEmbodiment FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D4")]
				[Cpp2IlInjected.Address(RVA = "0x22E4CF0", Offset = "0x22E38F0", VA = "0x1822E4CF0")]
				public LIAMNBHDIEJ HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(LIAMNBHDIEJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public NativeHashMap<Entity, EEDOLIFAKPN> LKDMNFLBNMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public ComponentDataFromEntity<ParentData> BEODIINKHJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> KAGOPJMPAIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			private GCBEGGIPPOK DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GCBEGGIPPOK.LIAMNBHDIEJ* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

			[Cpp2IlInjected.Token(Token = "0x400038B")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MEHHPEHJOID;

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x22E6CE0", Offset = "0x22E58E0", VA = "0x1822E6CE0")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, ObjectNetworkIdComponentData GPCFBGLDMBJ, int MNNFJAIOKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x22E6CF0", Offset = "0x22E58F0", VA = "0x1822E6CF0")]
			internal void DOMJCBMALEB(Entity NNCGIOJNJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x22E7060", Offset = "0x22E5C60", VA = "0x1822E7060", Slot = "5")]
			public void ReadFromDisplayClass(ref KGOIGDGLMPL GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x22E7090", Offset = "0x22E5C90", VA = "0x1822E7090", Slot = "6")]
			public void WriteToDisplayClass(ref KGOIGDGLMPL GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x22E6DB0", Offset = "0x22E59B0", VA = "0x1822E6DB0", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x22E6EA0", Offset = "0x22E5AA0", VA = "0x1822E6EA0")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref GCBEGGIPPOK.LIAMNBHDIEJ MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x22E6F60", Offset = "0x22E5B60", VA = "0x1822E6F60")]
			public void JOOHKCJALDF(PostLoadInitializeEmbodiment FEPEPIEDFAD, ref KGOIGDGLMPL GGANILFKEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x22E7000", Offset = "0x22E5C00", VA = "0x1822E7000")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery BBFLBEIPBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private CAOPEEFBAOK LLALMPDIGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private KKNBPBMPKBC HILNOPGMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery LBGFFJGDBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private ProfilerMarker NKONEOKOCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private EntityQuery DDDJHFDDDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private ProfilerMarker DEHNIKGFGAB;

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x22EDEF0", Offset = "0x22ECAF0", VA = "0x1822EDEF0", Slot = "14")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x22EE900", Offset = "0x22ED500", VA = "0x1822EE900", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x22EE980", Offset = "0x22ED580", VA = "0x1822EE980", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x22EE140", Offset = "0x22ECD40", VA = "0x1822EE140")]
		private void LHOBLLPNLIH(NativeArray<EEDOLIFAKPN> LKDMNFLBNMA, NativeArray<CKKHJFCEGAP> PAGGALACMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x22EEE60", Offset = "0x22EDA60", VA = "0x1822EEE60")]
		private void PKACLKOHBKO(NativeHashMap<Entity, EEDOLIFAKPN> LKDMNFLBNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x22EE480", Offset = "0x22ED080", VA = "0x1822EE480")]
		private void ODIBAMEMKEP(NativeHashMap<Entity, EEDOLIFAKPN> LKDMNFLBNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x22EDD70", Offset = "0x22EC970", VA = "0x1822EDD70")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BKBNAGMAGOL(NativeArray<EEDOLIFAKPN> LKDMNFLBNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private static void EADNMKNMDMO(NativeArray<EEDOLIFAKPN> LKDMNFLBNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x22EE620", Offset = "0x22ED220", VA = "0x1822EE620", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x22EDF80", Offset = "0x22ECB80", VA = "0x1822EDF80")]
		public static EntityQuery GKCGNNENILD(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x22EECD0", Offset = "0x22ED8D0", VA = "0x1822EECD0")]
		public static EntityQuery PIPADIOFCDJ(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class DCEBMLLFHFG : GHIOHHHNFPK, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct CBGPMEABBBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NativeHashMap<EEDOLIFAKPN, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public CBGPMEABBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FDHLDHJGKHG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct PDAJDMEALLH
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			[NoAlias]
			public struct OJKNPJOIJBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400039E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400039F")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime FJPLAIPAEKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003A0")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime FBNALJCJHNC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex FMIEDFJALPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FLBGEEAOBLC;

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2282390", Offset = "0x2280F90", VA = "0x182282390")]
			public void JOOHKCJALDF(DCEBMLLFHFG FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x22822D0", Offset = "0x2280ED0", VA = "0x1822822D0")]
			public OJKNPJOIJBI HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(OJKNPJOIJBI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public NativeHashMap<EEDOLIFAKPN, Entity> MIFOEAMJCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private PDAJDMEALLH DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PDAJDMEALLH.OJKNPJOIJBI* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MEHHPEHJOID;

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x2279700", Offset = "0x2278300", VA = "0x182279700")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, int MNNFJAIOKKA, ref ObjectNetworkIdComponentData PHDFPOMAHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
		public void ReadFromDisplayClass(ref CBGPMEABBBN GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x226BC00", Offset = "0x226A800", VA = "0x18226BC00", Slot = "6")]
		public void WriteToDisplayClass(ref CBGPMEABBBN GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x2279790", Offset = "0x2278390", VA = "0x182279790", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2279880", Offset = "0x2278480", VA = "0x182279880")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref PDAJDMEALLH.OJKNPJOIJBI MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x2279940", Offset = "0x2278540", VA = "0x182279940")]
		public void JOOHKCJALDF(DCEBMLLFHFG FEPEPIEDFAD, ref CBGPMEABBBN GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x22799E0", Offset = "0x22785E0", VA = "0x1822799E0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private ObjectNetworkToLocalMapService CCIEDGODKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery KMPBIILFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private ProfilerMarker AOIJAOLKNHP;

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x2274D00", Offset = "0x2273900", VA = "0x182274D00", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x2274F40", Offset = "0x2273B40", VA = "0x182274F40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public DCEBMLLFHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x2274D60", Offset = "0x2273960", VA = "0x182274D60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2274BD0", Offset = "0x22737D0", VA = "0x182274BD0")]
	public static EntityQuery BHBKNOEAHCM(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public class PEOFMAHAIPC : GHIOHHHNFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private EntityQuery BBFLBEIPBEH;

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x256AA00", Offset = "0x2569600", VA = "0x18256AA00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x256AA80", Offset = "0x2569680", VA = "0x18256AA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public PEOFMAHAIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public class NCIIEKFAHHF : GHIOHHHNFPK, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x2560CC0", Offset = "0x255F8C0", VA = "0x182560CC0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x2561030", Offset = "0x255FC30", VA = "0x182561030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x2560D20", Offset = "0x255F920", VA = "0x182560D20")]
	private void EMBCLFDBHND(NativeList<EntityArchetype> PKNOPOAPBEN, NativeHashMap<int, JPLMCCNINHK> GBFDPAHLEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x25607C0", Offset = "0x255F3C0", VA = "0x1825607C0")]
	private void BJOHDANMOEN(NativeHashMap<int, JPLMCCNINHK> GBFDPAHLEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public NCIIEKFAHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2560EF0", Offset = "0x255FAF0", VA = "0x182560EF0")]
	[CompilerGenerated]
	internal static Span<int> HDCIHCKMDJA(EntityArchetype NHDMIJDMMIM)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[KHHGHKHGGFN(EOABPLMDMOL.Serialization)]
	public class PreSerializeRemoveEntities : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery LMHEGHLDAHC;

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x22EF010", Offset = "0x22EDC10", VA = "0x1822EF010", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x22EF230", Offset = "0x22EDE30", VA = "0x1822EF230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(ABOMDPJBFJJ))]
public sealed class CGGCCIPMHLO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public CGGCCIPMHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(ABOMDPJBFJJ))]
[UpdateAfter(typeof(CGGCCIPMHLO))]
public sealed class OCDLKNFDIAD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public OCDLKNFDIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[ExecuteAlways]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JOMBINEMLFI))]
public sealed class GDDODNDLHOM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public GDDODNDLHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[ExecuteAlways]
[EFHICEMKHKB]
[UpdateInGroup(typeof(HEMIJONFJFJ))]
public sealed class NHCLMFPBPNB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public NHCLMFPBPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
[ExecuteAlways]
[EFHICEMKHKB]
[UpdateInGroup(typeof(EFDMBJFEKAM))]
public sealed class CHENCINABDG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public CHENCINABDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(CPHPIILMJPB))]
public sealed class DCFADMDKMEK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public DCFADMDKMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public sealed class GLGEPOOIJFM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public GLGEPOOIJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(IHMCNACMGCH))]
public sealed class CBDBCBDDNDL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public CBDBCBDDNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public sealed class MMLMIPFCGBD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public MMLMIPFCGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public class ELMHHJAJPCB : global::KBCEBPNOHMB<ParentData, DPBOGNPPLME, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x22796C0", Offset = "0x22782C0", VA = "0x1822796C0", Slot = "14")]
	protected override EntityQueryDesc PEBKBGCOBHH(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x77FEA0", Offset = "0x77EAA0", VA = "0x18077FEA0", Slot = "15")]
	protected override EntityQueryDesc LJAKMLHNHMG(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x2279640", Offset = "0x2278240", VA = "0x182279640", Slot = "16")]
	protected override EntityQueryDesc GHKOAPMMAKC(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2279680", Offset = "0x2278280", VA = "0x182279680", Slot = "17")]
	protected override EntityQueryDesc PDIBINBOCCH(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x2276AA0", Offset = "0x22756A0", VA = "0x182276AA0")]
	public ELMHHJAJPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x2276A60", Offset = "0x2275660", VA = "0x182276A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public abstract class KBCEBPNOHMB<ParentData, PreviousParentData, ChildrenData> : CHAPJLBBPNB where ParentData : struct, IComponentData, JCDLAHGBHBA where PreviousParentData : struct, IComponentData, JCDLAHGBHBA where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JCDLAHGBHBA
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[BurstCompile]
	private struct EJADBFIFALN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter IIFNELHNBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter BIIBHMFIFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public NativeHashMap<Entity, int>.ParallelWriter IFCGLOLALCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public ArchetypeChunkComponentType<PreviousParentData> JNFGIGKIEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ParentData> LCJKNJBJHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[ReadOnly]
		public ArchetypeChunkEntityType LABLHBCDJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public uint KBPLIDJIHPJ;

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x241F0A0", Offset = "0x241DCA0", VA = "0x18241F0A0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[BurstCompile]
	private struct IKNFKGDDNEK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[ReadOnly]
		public NativeHashMap<Entity, int> IFCGLOLALCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> DBOBCPLFLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public NativeList<Entity> BLLHAPOPDCL;

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x2422150", Offset = "0x2420D50", VA = "0x182422150", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[BurstCompile]
	private struct JJGCEFBLJII : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> IIFNELHNBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> BIIBHMFIFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		[ReadOnly]
		public NativeHashMap<Entity, int> IFCGLOLALCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public BufferFromEntity<ChildrenData> DBOBCPLFLGC;

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x2423190", Offset = "0x2421D90", VA = "0x182423190")]
		private int BNFCLECFDAC(DynamicBuffer<ChildrenData> PPLIDDKCFMM, Entity NNCGIOJNJIH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x2423700", Offset = "0x2422300", VA = "0x182423700")]
		private void FOENAGLEAEG(Entity PPHLLODMENC, DynamicBuffer<ChildrenData> PPLIDDKCFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x2423980", Offset = "0x2422580", VA = "0x182423980")]
		private void KPDLNHJJGDB(Entity PPHLLODMENC, DynamicBuffer<ChildrenData> PPLIDDKCFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x2423420", Offset = "0x2422020", VA = "0x182423420", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[BurstCompile]
	private struct DAFJEJIKJCP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public NativeArray<Entity> CCGOIDLMIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public NativeList<Entity> DOOOFADIIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public BufferFromEntity<ChildrenData> DBOBCPLFLGC;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x241E710", Offset = "0x241D310", VA = "0x18241E710", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected EntityQuery EDEOPELLCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	protected EntityQuery HIEECOKLHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	protected EntityQuery HJFLEEJBDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	protected EntityQuery LGHGMDAFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected ProfilerMarker EGGPBKILHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	protected ProfilerMarker NMJBDIPMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected ProfilerMarker GKFIBMNGLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	protected ProfilerMarker HEPKGGBACAP;

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x242ABE0", Offset = "0x24297E0", VA = "0x18242ABE0")]
	public KBCEBPNOHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x2429B60", Offset = "0x2428760", VA = "0x182429B60")]
	private int BNFCLECFDAC(DynamicBuffer<ChildrenData> PPLIDDKCFMM, Entity NNCGIOJNJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x242A6F0", Offset = "0x24292F0", VA = "0x18242A6F0")]
	private void NPMFJALOEAB(Entity EMDOHOJEJPL, Entity LENLBAEHICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x77FEA0", Offset = "0x77EAA0", VA = "0x18077FEA0", Slot = "14")]
	protected virtual EntityQueryDesc PEBKBGCOBHH(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x77FEA0", Offset = "0x77EAA0", VA = "0x18077FEA0", Slot = "15")]
	protected virtual EntityQueryDesc LJAKMLHNHMG(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x77FEA0", Offset = "0x77EAA0", VA = "0x18077FEA0", Slot = "16")]
	protected virtual EntityQueryDesc GHKOAPMMAKC(EntityQueryDesc CLMPDPEACMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected abstract EntityQueryDesc PDIBINBOCCH(EntityQueryDesc CLMPDPEACMB);

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x242A880", Offset = "0x2429480", VA = "0x18242A880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x2429F90", Offset = "0x2428B90", VA = "0x182429F90")]
	private void DPLCMLPDEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x242A530", Offset = "0x2429130", VA = "0x18242A530")]
	private void MFIOOGMGCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x242A080", Offset = "0x2428C80", VA = "0x18242A080")]
	private void JIFBFBCBMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x2429C60", Offset = "0x2428860", VA = "0x182429C60")]
	private void CPIEABPFABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x242AB20", Offset = "0x2429720", VA = "0x18242AB20", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle NMHOHPDHKEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x242A860", Offset = "0x2429460", VA = "0x18242A860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[KHHGHKHGGFN(EOABPLMDMOL.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[BurstCompile]
		private struct BNEIABAFNDI : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private const float LBPFHCEHGEH = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> HKPGKBJHLNN;

			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x22DF1E0", Offset = "0x22DDDE0", VA = "0x1822DF1E0", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0x22DF6E0", Offset = "0x22DE2E0", VA = "0x1822DF6E0")]
			private bool NKBIMBECMGH(float3 GBEJOMHKKEA, float3 EHMKAJMLGBB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0x22DF1B0", Offset = "0x22DDDB0", VA = "0x1822DF1B0")]
			private bool DPDKECKLBFA(quaternion GBEJOMHKKEA, quaternion EHMKAJMLGBB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x22DF3D0", Offset = "0x22DDFD0", VA = "0x1822DF3D0")]
			private static bool HJMAILIIGCK(float3 GBHOMBFJPAG, float3 DBJNEGCCKCM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x22DF650", Offset = "0x22DE250", VA = "0x1822DF650")]
			private static bool HJMAILIIGCK(quaternion EAGBNEBPABL, quaternion HDKBIEHDLMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0x22DF1A0", Offset = "0x22DDDA0", VA = "0x1822DF1A0")]
			private static bool AOOPEEIFCEI(float DNGLOFNMKDF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x22DF690", Offset = "0x22DE290", VA = "0x1822DF690")]
			private static float HKLONEIMFFE(quaternion GOBFAKNMLKL, quaternion HCAKBEFGDNC)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[BurstCompile]
		private struct HOEDONAPICD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> PPOLDHNGCAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> FMJIMBFOMPC;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x22E5180", Offset = "0x22E3D80", VA = "0x1822E5180", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private const string KIPBHGNMHOO = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private const string BHHKOFELDKO = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string KOOEIBANPBP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private static readonly ProfilerMarker GGJKBMDFABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private RegisterTransforms AOBEDLMFKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TransformAccessArray CIHMPIAEIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private DJFBKNFJCKG PEFFPCJPBOK;

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x22E1CE0", Offset = "0x22E08E0", VA = "0x1822E1CE0")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x22E1D40", Offset = "0x22E0940", VA = "0x1822E1D40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x22E1DB0", Offset = "0x22E09B0", VA = "0x1822E1DB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x22E1E20", Offset = "0x22E0A20", VA = "0x1822E1E20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[KHHGHKHGGFN(EOABPLMDMOL.TransformSyncing)]
	public class RegisterTransforms : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct IIIFPPFJKFC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000135")]
			private struct MELBGFDIABK
			{
				[Cpp2IlInjected.Token(Token = "0x2000136")]
				public struct POOLBMFKJGG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003DE")]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003DF")]
					public LambdaParameterValueProvider_IComponentData<JGOMOMBKPJI>.Runtime EOCGDOFCHDO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003E0")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime DGINNNNJOII;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003DB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003DC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<JGOMOMBKPJI> GMIJOBMKMAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003DD")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> CDOFPLKPOGJ;

				[Cpp2IlInjected.Token(Token = "0x6000849")]
				[Cpp2IlInjected.Address(RVA = "0x22E71B0", Offset = "0x22E5DB0", VA = "0x1822E71B0")]
				public void JOOHKCJALDF(RegisterTransforms FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600084A")]
				[Cpp2IlInjected.Address(RVA = "0x22E70C0", Offset = "0x22E5CC0", VA = "0x1822E70C0")]
				public POOLBMFKJGG HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(POOLBMFKJGG);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private MELBGFDIABK DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe MELBGFDIABK.POOLBMFKJGG* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCOPAHMMKMK;

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x22E5360", Offset = "0x22E3F60", VA = "0x1822E5360")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, JGOMOMBKPJI KLKFOFJLECO, Transform DMEEHMHNHEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x22E5440", Offset = "0x22E4040", VA = "0x1822E5440", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x22E54D0", Offset = "0x22E40D0", VA = "0x1822E54D0")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, ref MELBGFDIABK.POOLBMFKJGG MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x22E55A0", Offset = "0x22E41A0", VA = "0x1822E55A0")]
			public void JOOHKCJALDF(RegisterTransforms FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x22E55B0", Offset = "0x22E41B0", VA = "0x1822E55B0")]
			public unsafe static void KMMICMCBOHM(ArchetypeChunkIterator* JIGBDJLGFJJ, void* FCDKMBBNEOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct KEMPDLAHDOE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000138")]
			private struct IMDMPKKPFDM
			{
				[Cpp2IlInjected.Token(Token = "0x2000139")]
				[NoAlias]
				public struct NJDJBNJOHEE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003E5")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003E6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JGOMOMBKPJI>.Runtime EOCGDOFCHDO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003E3")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003E4")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<JGOMOMBKPJI> GMIJOBMKMAP;

				[Cpp2IlInjected.Token(Token = "0x600084F")]
				[Cpp2IlInjected.Address(RVA = "0x22E5690", Offset = "0x22E4290", VA = "0x1822E5690")]
				public void JOOHKCJALDF(RegisterTransforms FEPEPIEDFAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000850")]
				[Cpp2IlInjected.Address(RVA = "0x22E5610", Offset = "0x22E4210", VA = "0x1822E5610")]
				public NJDJBNJOHEE HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
				{
					return default(NJDJBNJOHEE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private IMDMPKKPFDM DBLCJBJLCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IMDMPKKPFDM.NJDJBNJOHEE* DMAILDBFFKI;

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x22E5E10", Offset = "0x22E4A10", VA = "0x1822E5E10")]
			internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, JGOMOMBKPJI KLKFOFJLECO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x22E5ED0", Offset = "0x22E4AD0", VA = "0x1822E5ED0", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x22E5F70", Offset = "0x22E4B70", VA = "0x1822E5F70")]
			public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref IMDMPKKPFDM.NJDJBNJOHEE MPODBPIDOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x22E5690", Offset = "0x22E4290", VA = "0x1822E5690")]
			public void JOOHKCJALDF(RegisterTransforms FEPEPIEDFAD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private DFELGPEHGJE GMPKJIPOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private KGBHHKGFLKL LAKAJAHDFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery ENJGNJMHIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private EntityQuery GHKJELBBABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery ACGPINNPDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery NIPMMMPGJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private ProfilerMarker AIPOAFNNKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery AIPNCJCDNAD;

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public KGBHHKGFLKL CJBPNHMPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x8FB690", Offset = "0x8FA290", VA = "0x1808FB690")]
			get
			{
				return default(KGBHHKGFLKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x22F1F30", Offset = "0x22F0B30", VA = "0x1822F1F30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x22F20C0", Offset = "0x22F0CC0", VA = "0x1822F20C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x22F20D0", Offset = "0x22F0CD0", VA = "0x1822F20D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x22F1AC0", Offset = "0x22F06C0", VA = "0x1822F1AC0")]
		private void JKJJFNHAHHJ(NativeArray<Entity> PGMFELKKDCA, KGBHHKGFLKL HPACNLENFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x22F1510", Offset = "0x22F0110", VA = "0x1822F1510")]
		[BurstCompile]
		internal static void ABKIIJBLKHP(NativeArray<JGOMOMBKPJI> DGGBILKFFCO, ComponentDataFromEntity<JGOMOMBKPJI> GJLMFDJOFCF, KGBHHKGFLKL HPACNLENFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private static void FHLMMKFLGIJ(Transform DMEEHMHNHEF, Entity NNCGIOJNJIH, int BAOHKIGDOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private static void LBDGAPHHKCG(Entity NNCGIOJNJIH, int BAOHKIGDOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private static void FMMIKJLJJCJ(int BAOHKIGDOBF, KGBHHKGFLKL HPACNLENFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x22F2570", Offset = "0x22F1170", VA = "0x1822F2570")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void PCCBAMJIFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x22F1BF0", Offset = "0x22F07F0", VA = "0x1822F1BF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x22F1960", Offset = "0x22F0560", VA = "0x1822F1960")]
		public static EntityQuery CHPJHPHGLLE(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x22F17D0", Offset = "0x22F03D0", VA = "0x1822F17D0")]
		public static EntityQuery ACNIKCNILEE(ComponentSystemBase FEPEPIEDFAD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[KHHGHKHGGFN(EOABPLMDMOL.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : GHIOHHHNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		[BurstCompile]
		private struct LBOLGLKDCCB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> HKPGKBJHLNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x22E6430", Offset = "0x22E5030", VA = "0x1822E6430", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[BurstCompile]
		private struct BEMJKFLKGOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> PPOLDHNGCAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0x22DF0F0", Offset = "0x22DDCF0", VA = "0x1822DF0F0", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013D")]
		[BurstCompile]
		private struct CDGHKLCDIIK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> PPOLDHNGCAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> FMJIMBFOMPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			[ReadOnly]
			public NativeArray<Entity> PGMFELKKDCA;

			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x22DF730", Offset = "0x22DE330", VA = "0x1822DF730", Slot = "4")]
			public void Execute(int BAOHKIGDOBF, TransformAccess DMEEHMHNHEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private const string KIPBHGNMHOO = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private const string BHHKOFELDKO = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private const string KOOEIBANPBP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly PEOJNAGCHAI OBINLNEGJJO;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly PEOJNAGCHAI CHECECLDIJP;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly PEOJNAGCHAI PPDLGBCKMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private JGDFMHBCOOH AOBEDLMFKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private JobHandle DHGMOHNEPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery LJHDOLBGEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private EntityQuery HEDEGMCICFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private EntityQuery JPMMILFCJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private TransformAccessArray FLIEFILMCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TransformAccessArray AHKECLCAAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TransformAccessArray ECGJLNLKHAI;

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x22E2310", Offset = "0x22E0F10", VA = "0x1822E2310", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x22E2520", Offset = "0x22E1120", VA = "0x1822E2520", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A50", Offset = "0x8F4650", VA = "0x1808F5A50")]
		internal JobHandle HHOJFKJHLEM()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x22E2560", Offset = "0x22E1160", VA = "0x1822E2560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x22E2180", Offset = "0x22E0D80", VA = "0x1822E2180")]
		private NativeArray<Entity> FEDBNJOMFPN(NativeArray<JGOMOMBKPJI> CFGAMGPMLDE, NativeList<Entity> NMLKODKFIAJ, TransformAccessArray KOMONPLBAPP, TransformAccessArray DJGFEDJFJPL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public class LONFLKPGNEF : GHIOHHHNFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private GGBKBMBBIIK PJFNALAHDJH;

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x255EBA0", Offset = "0x255D7A0", VA = "0x18255EBA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x255EC00", Offset = "0x255D800", VA = "0x18255EC00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x255E930", Offset = "0x255D530", VA = "0x18255E930")]
	private static void DLJCCDBHIND(EntityManager DEFMCCAEPJC, Entity NNCGIOJNJIH, Entity PPHLLODMENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x255EAC0", Offset = "0x255D6C0", VA = "0x18255EAC0")]
	private static Transform HJDGHBLHALJ(EntityManager DEFMCCAEPJC, Entity NNCGIOJNJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000861")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public LONFLKPGNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000862")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public class JMJCAHIEIBA : GHIOHHHNFPK, GLEEPPGLLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct AFJOAAONBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public NativeList<EGLCLPAGKII> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public NativeList<EGLCLPAGKII> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public NativeList<Entity> oldParents;

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		public AFJOAAONBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, DPBOGNPPLME previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x226B260", Offset = "0x2269E60", VA = "0x18226B260")]
		internal void <OnUpdate>b__2(Entity entity)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct IEFELJDHGND : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct ABIDGIGDGOL
		{
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			[NoAlias]
			public struct LJDJLOANLHP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400040D")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400040E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CIJLLLMCPHC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> OKJEFCMGPPH;

			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0x25EF290", Offset = "0x25EDE90", VA = "0x1825EF290")]
			public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x25EF210", Offset = "0x25EDE10", VA = "0x1825EF210")]
			public LJDJLOANLHP HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(LJDJLOANLHP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public NativeList<EGLCLPAGKII> BBAEGALOCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private ABIDGIGDGOL DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ABIDGIGDGOL.LJDJLOANLHP* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x25F7530", Offset = "0x25F6130", VA = "0x1825F7530")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, ParentData PDAHFHABHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x226BBF0", Offset = "0x226A7F0", VA = "0x18226BBF0", Slot = "5")]
		public void ReadFromDisplayClass(ref AFJOAAONBPK GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x25F75C0", Offset = "0x25F61C0", VA = "0x1825F75C0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x25F7660", Offset = "0x25F6260", VA = "0x1825F7660")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref ABIDGIGDGOL.LJDJLOANLHP MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x25F7710", Offset = "0x25F6310", VA = "0x1825F7710")]
		public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD, ref AFJOAAONBPK GGANILFKEIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JKHHGFHHGFE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct GGODOFGDGII
		{
			[Cpp2IlInjected.Token(Token = "0x2000146")]
			[NoAlias]
			public struct DLGAMCDEMAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000415")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000416")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CIJLLLMCPHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000417")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<DPBOGNPPLME>.Runtime DCHOBGDABDP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> OKJEFCMGPPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<DPBOGNPPLME> AOABBMLPBBD;

			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x25F12A0", Offset = "0x25EFEA0", VA = "0x1825F12A0")]
			public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x25F1200", Offset = "0x25EFE00", VA = "0x1825F1200")]
			public DLGAMCDEMAP HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(DLGAMCDEMAP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public NativeList<EGLCLPAGKII> OANIFHLFPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private GGODOFGDGII DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GGODOFGDGII.DLGAMCDEMAP* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x25FCD30", Offset = "0x25FB930", VA = "0x1825FCD30")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH, ParentData PDAHFHABHCI, DPBOGNPPLME ANDJPGLENEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x25FCFB0", Offset = "0x25FBBB0", VA = "0x1825FCFB0", Slot = "5")]
		public void ReadFromDisplayClass(ref AFJOAAONBPK GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x25FCDD0", Offset = "0x25FB9D0", VA = "0x1825FCDD0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x25FCEA0", Offset = "0x25FBAA0", VA = "0x1825FCEA0")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref GGODOFGDGII.DLGAMCDEMAP MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x25FCF70", Offset = "0x25FBB70", VA = "0x1825FCF70")]
		public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD, ref AFJOAAONBPK GGANILFKEIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct FIBGGOALGEA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000148")]
		private struct NNKBAHFHINJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000149")]
			[NoAlias]
			public struct EFCKLPBHALL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041C")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ANJKHNALBIE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFOBCBOIFLM;

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0x25F04F0", Offset = "0x25EF0F0", VA = "0x1825F04F0")]
			public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0x25F04E0", Offset = "0x25EF0E0", VA = "0x1825F04E0")]
			public EFCKLPBHALL HLPHBKBEPLL(ref ArchetypeChunk OELKLMBLOHG, int ECINBHIIKOK, int LKAFPFBIFNN)
			{
				return default(EFCKLPBHALL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public NativeList<Entity> AGOPBCDKDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private NNKBAHFHINJ DBLCJBJLCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NNKBAHFHINJ.EFCKLPBHALL* DMAILDBFFKI;

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x25F1020", Offset = "0x25EFC20", VA = "0x1825F1020")]
		internal void DMHMIBKCDOO(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x25F1180", Offset = "0x25EFD80", VA = "0x1825F1180", Slot = "5")]
		public void ReadFromDisplayClass(ref AFJOAAONBPK GGANILFKEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x25F1070", Offset = "0x25EFC70", VA = "0x1825F1070", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int MDKHGGMOCNL, int PMHFMNOLCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x25F10D0", Offset = "0x25EFCD0", VA = "0x1825F10D0")]
		public void HLCJMEEAJEC(ref ArchetypeChunk DGJPCCHKBLD, [NoAlias] ref NNKBAHFHINJ.EFCKLPBHALL MPODBPIDOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x25F1140", Offset = "0x25EFD40", VA = "0x1825F1140")]
		public void JOOHKCJALDF(JMJCAHIEIBA FEPEPIEDFAD, ref AFJOAAONBPK GGANILFKEIA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private HEINBCBJOCN NACNPKFGBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private EntityQuery ANGCIBLFGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private EntityQuery EINHOPGIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private EntityQuery HBILEFMOGLC;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	internal NativeList<EGLCLPAGKII> OKKICCBNBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<EGLCLPAGKII>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x8E73C0", Offset = "0x8E5FC0", VA = "0x1808E73C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	internal NativeList<EGLCLPAGKII> ICNEOILFNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FF0", Offset = "0x5E3BF0", VA = "0x1805E4FF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<EGLCLPAGKII>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x8E5DE0", Offset = "0x8E49E0", VA = "0x1808E5DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	internal NativeList<Entity> EAKJOBNKIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x8E73B0", Offset = "0x8E5FB0", VA = "0x1808E73B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x8E73D0", Offset = "0x8E5FD0", VA = "0x1808E73D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x25FD0C0", Offset = "0x25FBCC0", VA = "0x1825FD0C0", Slot = "14")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x25FD980", Offset = "0x25FC580", VA = "0x1825FD980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x25FD990", Offset = "0x25FC590", VA = "0x1825FD990", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x25FD160", Offset = "0x25FBD60", VA = "0x1825FD160")]
	private void EMHAMFALFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x25FD210", Offset = "0x25FBE10", VA = "0x1825FD210")]
	private void FNAPKEMHLBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x25FDA20", Offset = "0x25FC620", VA = "0x1825FDA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public JMJCAHIEIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x25FD920", Offset = "0x25FC520", VA = "0x1825FD920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x25FD330", Offset = "0x25FBF30", VA = "0x1825FD330")]
	public static EntityQuery FOEEINIKIFO(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x25FD720", Offset = "0x25FC320", VA = "0x1825FD720")]
	public static EntityQuery LOKMFEHLHMB(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x25FD560", Offset = "0x25FC160", VA = "0x1825FD560")]
	public static EntityQuery GEHHHPHIHHK(ComponentSystemBase FEPEPIEDFAD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[KHHGHKHGGFN(EOABPLMDMOL.TransformSyncing)]
	public class L2PToL2WHierarchy : CHAPJLBBPNB
	{
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		[BurstCompile]
		private struct LEGJGGBOFKG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> BLJNNNDIBAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> LDJKFBJMBHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> HFIACAFDLJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> INABKMPKDFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public ArchetypeChunkComponentType<LocalToWorldData> NHBCEMPGJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> ABAJPPDIMCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public uint KBPLIDJIHPJ;

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x22E68F0", Offset = "0x22E54F0", VA = "0x1822E68F0")]
			[Conditional("DEBUG_BUILD")]
			private void IDPFJBFGANG(Entity NNCGIOJNJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x22E6610", Offset = "0x22E5210", VA = "0x1822E6610", Slot = "4")]
			public void Execute(ArchetypeChunk DGJPCCHKBLD, int BAOHKIGDOBF, int JNEAILNOBPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x22E6560", Offset = "0x22E5160", VA = "0x1822E6560")]
			private bool ACFFBFFJOOP(ArchetypeChunk DGJPCCHKBLD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x22E6990", Offset = "0x22E5590", VA = "0x1822E6990")]
			private void KOIEGACHPEG(float4x4 IINOEGEMPBJ, Entity NNCGIOJNJIH, bool BOEGNJDAFJI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private EntityQuery CDDPMGFLDIJ;

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x22E60E0", Offset = "0x22E4CE0", VA = "0x1822E60E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x22E61E0", Offset = "0x22E4DE0", VA = "0x1822E61E0", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle NMHOHPDHKEA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public class FGCJMAAOBAH : CHAPJLBBPNB
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[BurstCompile]
	private struct MNBOPMPDPMF : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> BLJNNNDIBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public ArchetypeChunkComponentType<LocalToWorldData> NHBCEMPGJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public uint KBPLIDJIHPJ;

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2281DE0", Offset = "0x22809E0", VA = "0x182281DE0", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int BAOHKIGDOBF, int JNEAILNOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2281D60", Offset = "0x2280960", VA = "0x182281D60")]
		public bool ACFFBFFJOOP(ArchetypeChunk DGJPCCHKBLD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private EntityQuery CDDPMGFLDIJ;

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x227BE30", Offset = "0x227AA30", VA = "0x18227BE30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x227BF30", Offset = "0x227AB30", VA = "0x18227BF30", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle NMHOHPDHKEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public FGCJMAAOBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public class EIEEBPAANEO : CHAPJLBBPNB
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[BurstCompile]
	private struct BGFPHLKECIL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> JIKPBEEENDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public ArchetypeChunkComponentType<WorldPoseData> HMEHMCIMMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> LMDACHEKEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> CIFOMLFDEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public uint KBPLIDJIHPJ;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x226C140", Offset = "0x226AD40", VA = "0x18226C140", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int BAOHKIGDOBF, int JNEAILNOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x226C0C0", Offset = "0x226ACC0", VA = "0x18226C0C0")]
		public bool ACFFBFFJOOP(ArchetypeChunk DGJPCCHKBLD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private EntityQuery HILNOPGMOJL;

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x2278AF0", Offset = "0x22776F0", VA = "0x182278AF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x2278BE0", Offset = "0x22777E0", VA = "0x182278BE0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle NMHOHPDHKEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public EIEEBPAANEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public class NAIMKELPABI : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[BurstCompile]
	private struct ICMPNCPIAKB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> KDLAKNHABNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> NEPKAOPDMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> CKDAIGCHBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public ArchetypeChunkComponentType<LocalToParentData> NGBAAEHKLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public uint KBPLIDJIHPJ;

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x255A840", Offset = "0x2559440", VA = "0x18255A840", Slot = "4")]
		public void Execute(ArchetypeChunk DGJPCCHKBLD, int BAOHKIGDOBF, int JNEAILNOBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x255A770", Offset = "0x2559370", VA = "0x18255A770")]
		public bool ACFFBFFJOOP(ArchetypeChunk DGJPCCHKBLD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private EntityQuery HILNOPGMOJL;

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x2560550", Offset = "0x255F150", VA = "0x182560550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x2560660", Offset = "0x255F260", VA = "0x182560660", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle NMHOHPDHKEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public NAIMKELPABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[FAINFJBGAAN(ICDFCBCPDHG.Game)]
public class FKNLHIBADGK : CEAFPJPJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Type JJCLBEPLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x227CD00", Offset = "0x227B900", VA = "0x18227CD00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Type[] LPGANPPJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x227C8E0", Offset = "0x227B4E0", VA = "0x18227C8E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FKNLHIBADGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[FAINFJBGAAN(ICDFCBCPDHG.Loading)]
public class NIEHCLBGGEN : CEAFPJPJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public Type JJCLBEPLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x611E80", Offset = "0x610A80", VA = "0x180611E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Type[] LPGANPPJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x25620C0", Offset = "0x2560CC0", VA = "0x1825620C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NIEHCLBGGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public sealed class OJONEILMDHC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public OJONEILMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OJONEILMDHC))]
public sealed class AOPKLGLAIIJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B0")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public AOPKLGLAIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OJONEILMDHC))]
[UpdateAfter(typeof(AOPKLGLAIIJ))]
public sealed class DCCFPPLOLEP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public DCCFPPLOLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[FAINFJBGAAN(ICDFCBCPDHG.Saving)]
public class KJEPDCLNAOD : CEAFPJPJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Type JJCLBEPLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x611E80", Offset = "0x610A80", VA = "0x180611E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Type[] LPGANPPJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x25FE6D0", Offset = "0x25FD2D0", VA = "0x1825FE6D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public KJEPDCLNAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public sealed class ILEAPNKMPHK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public ILEAPNKMPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[FAINFJBGAAN(ICDFCBCPDHG.Simulation)]
public class PFHDDBMCNMF : CEAFPJPJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Type JJCLBEPLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x256AD30", Offset = "0x2569930", VA = "0x18256AD30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Type[] LPGANPPJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x256AB10", Offset = "0x2569710", VA = "0x18256AB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PFHDDBMCNMF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[PCJLLMMMFMG(typeof(OAKLFPLBGGO), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.Connectables, new string[] { "Callbacks" })]
	internal class ConnectableService : OAKLFPLBGGO, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		[CompilerGenerated]
		private sealed class CFBMGCEHHFJ : IEnumerable<GDHDBKNKOKH>, IEnumerable, IEnumerator<GDHDBKNKOKH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private GDHDBKNKOKH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private GDHDBKNKOKH localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public GDHDBKNKOKH <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000128")]
			private GDHDBKNKOKH System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008E0")]
				[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(GDHDBKNKOKH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000129")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008E2")]
				[Cpp2IlInjected.Address(RVA = "0x22DFBD0", Offset = "0x22DE7D0", VA = "0x1822DFBD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xA0D7D0", Offset = "0xA0C3D0", VA = "0x180A0D7D0")]
			[DebuggerHidden]
			public CFBMGCEHHFJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x22DFC20", Offset = "0x22DE820", VA = "0x1822DFC20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0x22DF830", Offset = "0x22DE430", VA = "0x1822DF830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x22DFD10", Offset = "0x22DE910", VA = "0x1822DFD10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x22DFD50", Offset = "0x22DE950", VA = "0x1822DFD50")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0x22DFB80", Offset = "0x22DE780", VA = "0x1822DFB80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0x22DFAD0", Offset = "0x22DE6D0", VA = "0x1822DFAD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GDHDBKNKOKH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0x22DFAD0", Offset = "0x22DE6D0", VA = "0x1822DFAD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private const string MHCBAIFGPJL = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private static readonly PEOJNAGCHAI CPIDGBEPIHN;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public const int EFPBEIBCABD = 0;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public const int MJPHKNBFAMG = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private KKNBPBMPKBC HILNOPGMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private global::FBNMKIEDAEE<AuthoredParentData, OJJDCGFPFHF, MEMELGJDJJE, AuthoredChildrenData> EHELJICGBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private global::DFKMLMGEHEE<Entity> DLHLMCICIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private global::DFKMLMGEHEE<float3> MDBFBKLLILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private global::DFKMLMGEHEE<quaternion> AEGAGIPOPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private global::DFKMLMGEHEE<Entity> PPHLLODMENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private global::DFKMLMGEHEE<float3> PHMCCHPIHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private global::DFKMLMGEHEE<quaternion> FNKFECDNDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private PropertyEventCallbacksService JCKIFLMCHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private HashSet<Entity> FIPDDHLKEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private HashSet<Entity> NALAFOIONOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private EntityQuery POLDGLEOPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private bool ONBALJNPLJC;

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public Func<ONCLIPMNFEK> MNJJFFJPJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x66FAB0", Offset = "0x66E6B0", VA = "0x18066FAB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0x671980", Offset = "0x670580", VA = "0x180671980", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<GDHDBKNKOKH, GDHDBKNKOKH> CHIIODPMBFI
		{
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x22E1A80", Offset = "0x22E0680", VA = "0x1822E1A80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0x22E1620", Offset = "0x22E0220", VA = "0x1822E1620", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<GDHDBKNKOKH, GDHDBKNKOKH> CKIJEIFFHCA
		{
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x22E1B20", Offset = "0x22E0720", VA = "0x1822E1B20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0x22E00A0", Offset = "0x22DECA0", VA = "0x1822E00A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<GDHDBKNKOKH, GDHDBKNKOKH, GDHDBKNKOKH> BHJBKGCLFON
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x22E0320", Offset = "0x22DEF20", VA = "0x1822E0320", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0x22E0280", Offset = "0x22DEE80", VA = "0x1822E0280", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<GDHDBKNKOKH> KHNHMDJMHCP
		{
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0x22E1300", Offset = "0x22DFF00", VA = "0x1822E1300", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0x22E1820", Offset = "0x22E0420", VA = "0x1822E1820", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x22E0140", Offset = "0x22DED40", VA = "0x1822E0140", Slot = "22")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x22E0DC0", Offset = "0x22DF9C0", VA = "0x1822E0DC0", Slot = "23")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x22E0590", Offset = "0x22DF190", VA = "0x1822E0590", Slot = "24")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x22E0530", Offset = "0x22DF130", VA = "0x1822E0530")]
		private void DJOIDDLIGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x22DFD90", Offset = "0x22DE990", VA = "0x1822DFD90")]
		private void ALGALGNGOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x22E18D0", Offset = "0x22E04D0", VA = "0x1822E18D0")]
		private void PCGHLEDLFNM(Entity NNCGIOJNJIH, GBEPIPMPHEG MKJDELBEPBK, BNKGCKPKCFJ EHMKAJMLGBB, BNKGCKPKCFJ GBEJOMHKKEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x22E15C0", Offset = "0x22E01C0", VA = "0x1822E15C0")]
		private void JJLHMGAGHNJ(Entity NNCGIOJNJIH, GBEPIPMPHEG MKJDELBEPBK, BNKGCKPKCFJ EHMKAJMLGBB, BNKGCKPKCFJ GBEJOMHKKEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x22E18C0", Offset = "0x22E04C0", VA = "0x1822E18C0", Slot = "14")]
		public GDHDBKNKOKH MOHDLEPEOLD(GDHDBKNKOKH IFPFHNLOHFM, int BFMMFCBEIDE)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xF31280", Offset = "0xF2FE80", VA = "0x180F31280", Slot = "15")]
		public Color GJMJDHKLNHI(GDHDBKNKOKH IFPFHNLOHFM, int BFMMFCBEIDE)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x22E0A30", Offset = "0x22DF630", VA = "0x1822E0A30", Slot = "16")]
		public void FHDAIOOLDNB(GDHDBKNKOKH IFPFHNLOHFM, GDHDBKNKOKH AEAAIACHGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x22E0D20", Offset = "0x22DF920", VA = "0x1822E0D20", Slot = "17")]
		public GDHDBKNKOKH GONPBILDEDE(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x22E0B00", Offset = "0x22DF700", VA = "0x1822E0B00", Slot = "20")]
		public void GJKCFCCEOCL(GDHDBKNKOKH IFPFHNLOHFM, Vector3 NECFPEGAGOO, Quaternion DHOJLOAIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x22E16C0", Offset = "0x22E02C0", VA = "0x1822E16C0", Slot = "25")]
		public (Vector3, Quaternion) LOEPNNIEEDN(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x22E1430", Offset = "0x22E0030", VA = "0x1822E1430", Slot = "26")]
		public (Vector3, Quaternion) JAALMBCAEDN(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x22DFEE0", Offset = "0x22DEAE0", VA = "0x1822DFEE0", Slot = "21")]
		public (Vector3, Quaternion, bool) BBFBKBGACCB(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x22E13A0", Offset = "0x22DFFA0", VA = "0x1822E13A0", Slot = "18")]
		[IteratorStateMachine(typeof(CFBMGCEHHFJ))]
		public IEnumerable<GDHDBKNKOKH> IGOCIMBLAEA(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x22E0810", Offset = "0x22DF410", VA = "0x1822E0810", Slot = "19")]
		public GDHDBKNKOKH FCBFJIMMCJO(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x22E03C0", Offset = "0x22DEFC0", VA = "0x1822E03C0", Slot = "27")]
		public void CMNDNBNHJJD(ref List<GDHDBKNKOKH> CLKPKBPNOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x22E0930", Offset = "0x22DF530", VA = "0x1822E0930")]
		private Entity FCBFJIMMCJO(Entity NNCGIOJNJIH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x22E1C40", Offset = "0x22E0840", VA = "0x1822E1C40")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[PCJLLMMMFMG(typeof(EntityHierarchyChildren), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private INFBOELCJHP GBIHOJOKJHC;

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		private EntityManager OOLEAOGIJBP
		{
			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0x22E3C50", Offset = "0x22E2850", VA = "0x1822E3C50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x22E3730", Offset = "0x22E2330", VA = "0x1822E3730", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x22E3A30", Offset = "0x22E2630", VA = "0x1822E3A30")]
		internal void IDFBPKCCMKI(Entity PPHLLODMENC, Entity PCCELBMBFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x22E3660", Offset = "0x22E2260", VA = "0x1822E3660")]
		internal void AIFBAEDCIFC(Entity PPHLLODMENC, Entity PCCELBMBFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x22E3EA0", Offset = "0x22E2AA0", VA = "0x1822E3EA0")]
		private int OJACBEFPHKA(Entity PPHLLODMENC, Entity PCCELBMBFIP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x22E3B90", Offset = "0x22E2790", VA = "0x1822E3B90")]
		internal DynamicBuffer<ChildrenData> KAFKFCFBJIC(Entity NNCGIOJNJIH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x22E39D0", Offset = "0x22E25D0", VA = "0x1822E39D0")]
		public NativeArray<Entity> HGELELLNPPB(Entity NNCGIOJNJIH, Allocator KIPGDNHHBGE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x22E37B0", Offset = "0x22E23B0", VA = "0x1822E37B0")]
		public bool EEHHKELJPPD(Entity NNCGIOJNJIH, Allocator KIPGDNHHBGE, out NativeArray<Entity> CKCIMJKIAJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x22E3890", Offset = "0x22E2490", VA = "0x1822E3890")]
		public NativeArray<Entity> EMLMCHCPNEL(Entity NNCGIOJNJIH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x22E3D90", Offset = "0x22E2990", VA = "0x1822E3D90")]
		public Entity MLIECFFOLEB(Entity NNCGIOJNJIH, int BAOHKIGDOBF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x22E3CA0", Offset = "0x22E28A0", VA = "0x1822E3CA0")]
		public int MIBHFDDOHEA(Entity NNCGIOJNJIH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[KHHGHKHGGFN(EOABPLMDMOL.HierarchySystems)]
	[PCJLLMMMFMG(typeof(EntityHierarchyEvents), new string[] { })]
	internal sealed class EntityHierarchyEvents : GLEEPPGLLOC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private ObjectEmbodimentService LIKJOLDFEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ObjectLifecycleService LNMLGEFGGOH;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x22E3FD0", Offset = "0x22E2BD0", VA = "0x1822E3FD0", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x22E4350", Offset = "0x22E2F50", VA = "0x1822E4350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private void LBFDPMPNCIG(JHMPJMIHIEB LIKJOLDFEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private void HNHLONNDEFI(JHMPJMIHIEB LIKJOLDFEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
		private void MBNCNADGBIN(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[KHHGHKHGGFN(EOABPLMDMOL.HierarchySystems)]
	[PCJLLMMMFMG(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : GLEEPPGLLOC, MJAFAPEAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private KKNBPBMPKBC HILNOPGMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private global::DFKMLMGEHEE<Entity> EAIGMDJHNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private PropertyChangeNetworkRouter IOFLDANCGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private global::FBNMKIEDAEE<ParentData, DPBOGNPPLME, KMGCPOBJPIO, ChildrenData> EHELJICGBMI;

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x22E44B0", Offset = "0x22E30B0", VA = "0x1822E44B0", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x22E4620", Offset = "0x22E3220", VA = "0x1822E4620", Slot = "5")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x22E45D0", Offset = "0x22E31D0", VA = "0x1822E45D0")]
		public Entity GONPBILDEDE(Entity NNCGIOJNJIH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x22E4530", Offset = "0x22E3130", VA = "0x1822E4530")]
		public bool FHDAIOOLDNB(Entity NNCGIOJNJIH, Entity HBOBFHIJAEB, bool JEOPJCKNNAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x22E4700", Offset = "0x22E3300", VA = "0x1822E4700")]
		private bool JNIDCENNIIK(Entity NNCGIOJNJIH, Entity HBOBFHIJAEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[APAIBGLBFHK(typeof(DJFBKNFJCKG))]
[PCJLLMMMFMG(typeof(INFBOELCJHP), new string[] { })]
internal sealed class INFBOELCJHP : GLEEPPGLLOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class EJPFONGHBDM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public INFBOELCJHP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0x130C560", Offset = "0x130B160", VA = "0x18130C560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x25F06A0", Offset = "0x25EF2A0", VA = "0x1825F06A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x22740D0", Offset = "0x2272CD0", VA = "0x1822740D0")]
		[DebuggerHidden]
		public EJPFONGHBDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x25F0500", Offset = "0x25EF100", VA = "0x1825F0500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x25F0650", Offset = "0x25EF250", VA = "0x1825F0650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x25F05A0", Offset = "0x25EF1A0", VA = "0x1825F05A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x25F05A0", Offset = "0x25EF1A0", VA = "0x1825F05A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class AIIAPCBJJNM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public INFBOELCJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x130C560", Offset = "0x130B160", VA = "0x18130C560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x25EF690", Offset = "0x25EE290", VA = "0x1825EF690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x22740D0", Offset = "0x2272CD0", VA = "0x1822740D0")]
		[DebuggerHidden]
		public AIIAPCBJJNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x25EF6E0", Offset = "0x25EE2E0", VA = "0x1825EF6E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x25EF3D0", Offset = "0x25EDFD0", VA = "0x1825EF3D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x25EF790", Offset = "0x25EE390", VA = "0x1825EF790")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x25EF640", Offset = "0x25EE240", VA = "0x1825EF640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x25EF590", Offset = "0x25EE190", VA = "0x1825EF590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x25EF590", Offset = "0x25EE190", VA = "0x1825EF590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class FCKBFEOEAAB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public INFBOELCJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x130C560", Offset = "0x130B160", VA = "0x18130C560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x25F0AA0", Offset = "0x25EF6A0", VA = "0x1825F0AA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x22740D0", Offset = "0x2272CD0", VA = "0x1822740D0")]
		[DebuggerHidden]
		public FCKBFEOEAAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x25F0AF0", Offset = "0x25EF6F0", VA = "0x1825F0AF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x25F06F0", Offset = "0x25EF2F0", VA = "0x1825F06F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x25F0BF0", Offset = "0x25EF7F0", VA = "0x1825F0BF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x25F0C30", Offset = "0x25EF830", VA = "0x1825F0C30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x25F0A50", Offset = "0x25EF650", VA = "0x1825F0A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x25F09A0", Offset = "0x25EF5A0", VA = "0x1825F09A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x25F09A0", Offset = "0x25EF5A0", VA = "0x1825F09A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private EntityHierarchyParents JJMCKEAOKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityHierarchyChildren PPLIDDKCFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private EntityQuery POLDGLEOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x25FA690", Offset = "0x25F9290", VA = "0x1825FA690")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x25F9D20", Offset = "0x25F8920", VA = "0x1825F9D20", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x25F9F00", Offset = "0x25F8B00", VA = "0x1825F9F00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x25FA8B0", Offset = "0x25F94B0", VA = "0x1825FA8B0")]
	public bool PJPPMNCPPCG(Entity NNCGIOJNJIH, Entity DDBHKAHGHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x25F9F20", Offset = "0x25F8B20", VA = "0x1825F9F20")]
	public bool EEHDFGCKPCJ(Entity NNCGIOJNJIH, Entity DDBHKAHGHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x25FA780", Offset = "0x25F9380", VA = "0x1825FA780")]
	public IEnumerable<Entity> ODDBCNABBCI(Entity NNCGIOJNJIH, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x25FA5F0", Offset = "0x25F91F0", VA = "0x1825FA5F0")]
	[IteratorStateMachine(typeof(EJPFONGHBDM))]
	private IEnumerable<Entity> JPBELHKPCBK(Entity NNCGIOJNJIH, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x25FA370", Offset = "0x25F8F70", VA = "0x1825FA370")]
	public bool ENBKDMJDKDK(Entity NNCGIOJNJIH, Entity PCCELBMBFIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x25FA000", Offset = "0x25F8C00", VA = "0x1825FA000")]
	public bool EEICHDLNGBO(Entity NNCGIOJNJIH, Entity FOKMNOHOCNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x25FA4C0", Offset = "0x25F90C0", VA = "0x1825FA4C0")]
	public IEnumerable<Entity> JILLEFHCFOK(Entity NNCGIOJNJIH, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x25FA6E0", Offset = "0x25F92E0", VA = "0x1825FA6E0")]
	[IteratorStateMachine(typeof(AIIAPCBJJNM))]
	private IEnumerable<Entity> MMCCPOKIFAP(Entity NNCGIOJNJIH, bool CFHAOIEMLLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x25F9E30", Offset = "0x25F8A30", VA = "0x1825F9E30")]
	[IteratorStateMachine(typeof(FCKBFEOEAAB))]
	private IEnumerable<Entity> CMMEGMBMHPE(Entity NNCGIOJNJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x25FA430", Offset = "0x25F9030", VA = "0x1825FA430")]
	public Entity FCBFJIMMCJO(Entity NNCGIOJNJIH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x25F9EB0", Offset = "0x25F8AB0", VA = "0x1825F9EB0")]
	public NativeArray<Entity> CMNDNBNHJJD()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x25FA1A0", Offset = "0x25F8DA0", VA = "0x1825FA1A0")]
	public bool EEOIKKOOHMM(Entity FOKMNOHOCNA, Entity FJKICIEEJIJ, out Entity ILFEJKHGEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public INFBOELCJHP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[KHHGHKHGGFN(EOABPLMDMOL.HierarchySystems)]
	public struct ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x22302D0", Offset = "0x222EED0", VA = "0x1822302D0")]
		public static void MMDAHEHGHKH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(LPPHKFGPEPM NBFNONBMPHP, global::IEEHKIFNEBA<Entity> LOBDPBBMIIM, out global::FBNMKIEDAEE<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> DPADAHHBIHE) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, JCDLAHGBHBA where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, JCDLAHGBHBA, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x22EC730", Offset = "0x22EB330", VA = "0x1822EC730")]
		public static bool NHDKOGJKEMD(JHMPJMIHIEB BDAOGBJMIGB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public struct FBNMKIEDAEE<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, JCDLAHGBHBA where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, JCDLAHGBHBA, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private static readonly PEOJNAGCHAI NLGECAJFNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly global::DFKMLMGEHEE<Entity> EAIGMDJHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly PEMMOOCPOFD IIKPAOMHLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly APLKBADHFCN PPHLLODMENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC1C0", Offset = "0x3BFADC0", VA = "0x183BFC1C0")]
	public FBNMKIEDAEE(LPPHKFGPEPM NBFNONBMPHP, global::IEEHKIFNEBA<Entity> LOBDPBBMIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB8E0", Offset = "0x3BFA4E0", VA = "0x183BFB8E0")]
	private bool HDDNABKCKNI(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBED0", Offset = "0x3BFAAD0", VA = "0x183BFBED0")]
	private bool OPBDFBMDBKL(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB200", Offset = "0x3BF9E00", VA = "0x183BFB200")]
	public bool DECBBHAPMCN(Entity NNCGIOJNJIH, in Entity HBOBFHIJAEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private static void GIGAMJBHNHI(Entity NNCGIOJNJIH, Entity HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000932")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private static void DPJFKEFFKMP(Entity NNCGIOJNJIH, Entity HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000933")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBFF0", Offset = "0x3BFABF0", VA = "0x183BFBFF0")]
	private bool PJPPMNCPPCG(Entity NNCGIOJNJIH, Entity DDBHKAHGHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBBA0", Offset = "0x3BFA7A0", VA = "0x183BFBBA0")]
	private void LNIBIMCJEBB(Entity NNCGIOJNJIH, in Entity OCKMNAKIFGM, in Entity HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAAC0", Offset = "0x3BF96C0", VA = "0x183BFAAC0")]
	private void BKAFIKHLNII(Entity NNCGIOJNJIH, in Entity OCKMNAKIFGM, in Entity HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000936")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB560", Offset = "0x3BFA160", VA = "0x183BFB560")]
	private bool FIFGKEBFHNI(FNBLDJDCGLI BNICEBMLEFD, in EEDOLIFAKPN MOKHBFMBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBC90", Offset = "0x3BFA890", VA = "0x183BFBC90")]
	private void MJLDGCDJIGN(Entity PPHLLODMENC, Entity PCCELBMBFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB9A0", Offset = "0x3BFA5A0", VA = "0x183BFB9A0")]
	private void KCADPNPACHD(Entity PPHLLODMENC, Entity PCCELBMBFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private void FMMIKJLJJCJ(Entity NNCGIOJNJIH, Entity OCKMNAKIFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	private void FHLMMKFLGIJ(Entity NNCGIOJNJIH, Entity HBOBFHIJAEB)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[PCJLLMMMFMG(typeof(TransformOwnershipPhase), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		public enum OOBIGGBJEKA
		{
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x2000167")]
		public struct GGDGBIKKLEH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private OOBIGGBJEKA ENEFKLJIHFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private readonly TransformOwnershipPhase PPHLLODMENC;

			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0x5763250", Offset = "0x5761E50", VA = "0x185763250")]
			public GGDGBIKKLEH(TransformOwnershipPhase PPHLLODMENC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0x5763230", Offset = "0x5761E30", VA = "0x185763230", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public OOBIGGBJEKA OMELIBMFJGL;

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public OOBIGGBJEKA IPPHHHIDGBO
		{
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0")]
			get
			{
				return default(OOBIGGBJEKA);
			}
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EE0", Offset = "0x5E3AE0", VA = "0x1805E4EE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public bool DDFLMMPNBIP
		{
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x9C2310", Offset = "0x9C0F10", VA = "0x1809C2310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public bool DMICKCCEFBD
		{
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0x9BBBB0", Offset = "0x9BA7B0", VA = "0x1809BBBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x5764610", Offset = "0x5763210", VA = "0x185764610")]
		public GGDGBIKKLEH HILCLPHEGLK()
		{
			return default(GGDGBIKKLEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public class EBKEGAODHEE : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly EBKEGAODHEE OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2276E90", Offset = "0x2275A90", VA = "0x182276E90", Slot = "4")]
	public bool Equals(LinkedEntityGroup FPNCCNLMGCF, LinkedEntityGroup JNKDBNBEKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2276EB0", Offset = "0x2275AB0", VA = "0x182276EB0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup HLJJNKOAONN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EBKEGAODHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct ILEOEHNOMOP : global::DGMLBDFJNFE<ILEOEHNOMOP>, NINKJOKNHPH, IEquatable<ILEOEHNOMOP>
{
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly ILEOEHNOMOP OEGEMGKBDGN;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x91DAC0", Offset = "0x91C6C0", VA = "0x18091DAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public int DBOCDBJDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x8A34E0", Offset = "0x8A20E0", VA = "0x1808A34E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x8F72D0", Offset = "0x8F5ED0", VA = "0x1808F72D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool MLPCDHELIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x25F9940", Offset = "0x25F8540", VA = "0x1825F9940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x25F9980", Offset = "0x25F8580", VA = "0x1825F9980", Slot = "8")]
	public bool Equals(ILEOEHNOMOP LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x25F99D0", Offset = "0x25F85D0", VA = "0x1825F99D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct PBDGMEDAAGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public ILEOEHNOMOP PEIBOBCLLBF;
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct FJMFDPCBMEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private const int KAKJFBIKGAM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly Stack<HashSet<object>> OKBCHDKPNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::LDPOKLHHIGK<ILEOEHNOMOP, HashSet<object>> MPHFLMACFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private EntityManager DEFMCCAEPJC;

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x227C800", Offset = "0x227B400", VA = "0x18227C800")]
	public FJMFDPCBMEC(EntityManager DEFMCCAEPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x227C510", Offset = "0x227B110", VA = "0x18227C510")]
	public void NOCELDNAFKF(Entity NNCGIOJNJIH, object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x227C1B0", Offset = "0x227ADB0", VA = "0x18227C1B0")]
	public bool FPAPHAHKCPI(Entity NNCGIOJNJIH, object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x227C4D0", Offset = "0x227B0D0", VA = "0x18227C4D0")]
	public bool KLBLGODKIIG(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x227C430", Offset = "0x227B030", VA = "0x18227C430")]
	public bool KLBLGODKIIG(ILEOEHNOMOP PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x227C5F0", Offset = "0x227B1F0", VA = "0x18227C5F0")]
	public bool PDCIHMALEMC(Entity NNCGIOJNJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x227C170", Offset = "0x227AD70", VA = "0x18227C170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x227C300", Offset = "0x227AF00", VA = "0x18227C300")]
	private void HHMAKKHEFGM(HashSet<object> CLGBMOHPCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x227C6C0", Offset = "0x227B2C0", VA = "0x18227C6C0")]
	private bool PGNIGCMPANC(Entity NNCGIOJNJIH, out ILEOEHNOMOP PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x227C3C0", Offset = "0x227AFC0", VA = "0x18227C3C0")]
	private void JAELBAFIIHJ(Entity NNCGIOJNJIH, ILEOEHNOMOP PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x227C360", Offset = "0x227AF60", VA = "0x18227C360")]
	private bool IPHJIPIDEJB(ILEOEHNOMOP PJGLHJOGEDA, out HashSet<object> CLGBMOHPCOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x227C780", Offset = "0x227B380", VA = "0x18227C780")]
	private HashSet<object> PIHNENCGHKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[PCJLLMMMFMG(typeof(HEINBCBJOCN), new string[] { })]
internal sealed class HEINBCBJOCN
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action FHJDJKBKBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x25F3CF0", Offset = "0x25F28F0", VA = "0x1825F3CF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x25F3D90", Offset = "0x25F2990", VA = "0x1825F3D90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0xE834A0", Offset = "0xE820A0", VA = "0x180E834A0")]
	public void PMKFMLLDGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HEINBCBJOCN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[PCJLLMMMFMG(typeof(ObjectEmbodimentService), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.Embodiment)]
	internal sealed class ObjectEmbodimentService : OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private readonly Dictionary<EEDOLIFAKPN, CICKPBCENCE> NGNDADFGPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private KKNBPBMPKBC HILNOPGMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private CAOPEEFBAOK LLALMPDIGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private MEOJBAKKCBG JANOGBMNGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private FJMFDPCBMEC MCMFODEDDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private EntityHierarchyChildren PPLIDDKCFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private ObjectLifecycleService LNMLGEFGGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TransformOwnershipPhase OMELIBMFJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private bool ONBALJNPLJC;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		private EntityManager OOLEAOGIJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x22E9130", Offset = "0x22E7D30", VA = "0x1822E9130")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public int EMGDEOMHNMM
		{
			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0x22E8E50", Offset = "0x22E7A50", VA = "0x1822E8E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public int LICBKFNLPLI
		{
			[Cpp2IlInjected.Token(Token = "0x600096B")]
			[Cpp2IlInjected.Address(RVA = "0x22EA540", Offset = "0x22E9140", VA = "0x1822EA540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<JHMPJMIHIEB> BNOCIBGEHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x22E80F0", Offset = "0x22E6CF0", VA = "0x1822E80F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x22E7B50", Offset = "0x22E6750", VA = "0x1822E7B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JHMPJMIHIEB> DDIFFCFNGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x22E85F0", Offset = "0x22E71F0", VA = "0x1822E85F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x22E9CB0", Offset = "0x22E88B0", VA = "0x1822E9CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x22E87C0", Offset = "0x22E73C0", VA = "0x1822E87C0", Slot = "4")]
		public void HBGKEGAFJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x22E7850", Offset = "0x22E6450", VA = "0x1822E7850", Slot = "5")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x22E87D0", Offset = "0x22E73D0", VA = "0x1822E87D0", Slot = "6")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x22E7E10", Offset = "0x22E6A10", VA = "0x1822E7E10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x22E9AE0", Offset = "0x22E86E0", VA = "0x1822E9AE0")]
		public bool NLOCKGGKDMG(Entity NNCGIOJNJIH, Allocator KIPGDNHHBGE, out NativeList<Entity> IBPDAHLHGGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x22E7810", Offset = "0x22E6410", VA = "0x1822E7810")]
		public global::CDLKACEOIMD<Entity> BKHOBANNGMG(Allocator KIPGDNHHBGE)
		{
			return default(global::CDLKACEOIMD<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x22EA520", Offset = "0x22E9120", VA = "0x1822EA520")]
		public bool PGHOMBCKNOP(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x22E8D40", Offset = "0x22E7940", VA = "0x1822E8D40")]
		public bool IJBPKLGCINO(Entity NNCGIOJNJIH, out CICKPBCENCE LIKJOLDFEOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x22E8DB0", Offset = "0x22E79B0", VA = "0x1822E8DB0")]
		private bool IJBPKLGCINO(Transform DMEEHMHNHEF, out CICKPBCENCE LIKJOLDFEOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x22E8D20", Offset = "0x22E7920", VA = "0x1822E8D20")]
		internal bool HLNPAFJGLJJ(Entity NNCGIOJNJIH, out KJFJPNENILE LIKJOLDFEOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x22EA3E0", Offset = "0x22E8FE0", VA = "0x1822EA3E0")]
		private void PDMNPMILBPC(Entity NNCGIOJNJIH, CICKPBCENCE LIKJOLDFEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F50", Offset = "0x22E7B50", VA = "0x1822E8F50")]
		private bool KBDFNDHKKAN(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x22E9180", Offset = "0x22E7D80", VA = "0x1822E9180")]
		public void LGPGOGPHNHB(EEDOLIFAKPN PLIJDIMDLMI, CICKPBCENCE ODBAAACEKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x22E94C0", Offset = "0x22E80C0", VA = "0x1822E94C0")]
		public bool LKADBJEDONG(Entity NNCGIOJNJIH, object BNKIDKMECMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x22EA300", Offset = "0x22E8F00", VA = "0x1822EA300")]
		public bool OAACJNGPADG(GDHDBKNKOKH IFPFHNLOHFM, object BNKIDKMECMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x22EA1F0", Offset = "0x22E8DF0", VA = "0x1822EA1F0")]
		public bool OAACJNGPADG(Entity NNCGIOJNJIH, [Optional] object BNKIDKMECMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x22EA2E0", Offset = "0x22E8EE0", VA = "0x1822EA2E0")]
		public bool OAACJNGPADG(CICKPBCENCE BDAOGBJMIGB, object BNKIDKMECMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x22E8EA0", Offset = "0x22E7AA0", VA = "0x1822E8EA0")]
		public bool JKJJKFIJGAL(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8E70", Offset = "0x22E7A70", VA = "0x1822E8E70")]
		public bool JKJJKFIJGAL(CICKPBCENCE LIKJOLDFEOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x22E9D60", Offset = "0x22E8960", VA = "0x1822E9D60")]
		public bool OAACJNGPADG(CICKPBCENCE LIKJOLDFEOD, [Optional] object BNKIDKMECMP, bool PPDFINNPBCJ = false, bool HDBBPEHPPOM = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x22E7610", Offset = "0x22E6210", VA = "0x1822E7610")]
		public Transform BIABPPENGKD(Entity NNCGIOJNJIH, [Optional] object BNKIDKMECMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x22E7A30", Offset = "0x22E6630", VA = "0x1822E7A30")]
		public bool CEPHPONIACJ(Entity NNCGIOJNJIH, out Transform DMEEHMHNHEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x22E8520", Offset = "0x22E7120", VA = "0x1822E8520")]
		public CICKPBCENCE FAKHDFKFALL(Entity NNCGIOJNJIH, [Optional] object BNKIDKMECMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x22E73F0", Offset = "0x22E5FF0", VA = "0x1822E73F0")]
		public void BCKJFCHEDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x22E8200", Offset = "0x22E6E00", VA = "0x1822E8200")]
		public void ENFMAINGGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x22E9840", Offset = "0x22E8440", VA = "0x1822E9840")]
		private void MMEJFEKDIHN(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x22E7B00", Offset = "0x22E6700", VA = "0x1822E7B00")]
		public CICKPBCENCE CJBKCBFHPFG(Entity NNCGIOJNJIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x22E9D50", Offset = "0x22E8950", VA = "0x1822E9D50")]
		public void NOCELDNAFKF(Entity NNCGIOJNJIH, object BNKIDKMECMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x22E8780", Offset = "0x22E7380", VA = "0x1822E8780")]
		public bool FPAPHAHKCPI(Entity NNCGIOJNJIH, object BNKIDKMECMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x22EA3D0", Offset = "0x22E8FD0", VA = "0x1822EA3D0")]
		public bool PDCIHMALEMC(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F80", Offset = "0x22E7B80", VA = "0x1822E8F80")]
		public bool KLBLGODKIIG(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F70", Offset = "0x22E7B70", VA = "0x1822E8F70")]
		public bool KLBLGODKIIG(ILEOEHNOMOP PEIBOBCLLBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x22E9580", Offset = "0x22E8180", VA = "0x1822E9580")]
		private void LOHLDGHMCGJ(bool KEFCLGCBCPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x22E97B0", Offset = "0x22E83B0", VA = "0x1822E97B0")]
		private bool MKGOPHDAKEF(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8190", Offset = "0x22E6D90", VA = "0x1822E8190")]
		private CICKPBCENCE EMBAFOOAGID(Entity NNCGIOJNJIH, object BNKIDKMECMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7F50", Offset = "0x22E6B50", VA = "0x1822E7F50")]
		private CICKPBCENCE EBMFAEAAFPB(Entity NNCGIOJNJIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x22E92B0", Offset = "0x22E7EB0", VA = "0x1822E92B0")]
		private (Vector3, Quaternion, Vector3) LILMPDLDIKO(Entity NNCGIOJNJIH)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x22E8690", Offset = "0x22E7290", VA = "0x1822E8690")]
		private void FOMACHJELLO(Entity NNCGIOJNJIH, GGPLMDHKFKM DFPCAFCOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F90", Offset = "0x22E7B90", VA = "0x1822E8F90")]
		private void KMLAHKCBEAN(GDHDBKNKOKH IFPFHNLOHFM, CICKPBCENCE ODBAAACEKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x22E8900", Offset = "0x22E7500", VA = "0x1822E8900")]
		private void HKMIDCOBKBH(CICKPBCENCE LIKJOLDFEOD, Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x22E7BF0", Offset = "0x22E67F0", VA = "0x1822E7BF0")]
		private void CMOKFAGNBLG(Entity NNCGIOJNJIH, CICKPBCENCE LIKJOLDFEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x22E96D0", Offset = "0x22E82D0", VA = "0x1822E96D0")]
		private void MECGGLFDCKL(Entity NNCGIOJNJIH, Transform DMEEHMHNHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x22E8790", Offset = "0x22E7390", VA = "0x1822E8790")]
		private GDHDBKNKOKH GPBOHBAFHHD(Entity NNCGIOJNJIH)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x22EA5B0", Offset = "0x22E91B0", VA = "0x1822EA5B0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x22EA470", Offset = "0x22E9070", VA = "0x1822EA470")]
		[CompilerGenerated]
		private void PEGIBGPCEMB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal static class KFNGCFBMCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x25FDF30", Offset = "0x25FCB30", VA = "0x1825FDF30")]
	public static CICKPBCENCE FAKHDFKFALL(this ObjectEmbodimentService BNFCLMKBNAB, GDHDBKNKOKH IFPFHNLOHFM, [Optional] object BNKIDKMECMP)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[KHHGHKHGGFN(EOABPLMDMOL.Lifecycle)]
	[PCJLLMMMFMG(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DJFBKNFJCKG PEFFPCJPBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private ObjectEmbodimentService LIKJOLDFEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private ObjectNetworkToLocalMapService CCIEDGODKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityHierarchyChildren PPLIDDKCFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private INFBOELCJHP GBIHOJOKJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityHierarchyParents JJMCKEAOKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private HOOPEGLIIBH HNCHENOPHON;

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		private EntityManager OOLEAOGIJBP
		{
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x22EB150", Offset = "0x22E9D50", VA = "0x1822EB150")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<Entity, GGPLMDHKFKM> PIBHLJBILEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x22EA660", Offset = "0x22E9260", VA = "0x1822EA660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x22EABE0", Offset = "0x22E97E0", VA = "0x1822EABE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<Entity> AGKAIIOCPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x22EAC80", Offset = "0x22E9880", VA = "0x1822EAC80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0x22EA820", Offset = "0x22E9420", VA = "0x1822EA820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x22EA700", Offset = "0x22E9300", VA = "0x1822EA700", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x22EB1A0", Offset = "0x22E9DA0", VA = "0x1822EB1A0")]
		public bool MDNKFKLILBA(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x22EB220", Offset = "0x22E9E20", VA = "0x1822EB220")]
		internal void NIOIGNGOGGH(Entity NNCGIOJNJIH, GGPLMDHKFKM DFPCAFCOFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x22EAB50", Offset = "0x22E9750", VA = "0x1822EAB50")]
		public void CPAKPCECLGL(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x22EA620", Offset = "0x22E9220", VA = "0x1822EA620")]
		public void ACBDHJAGILA(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x22EAD20", Offset = "0x22E9920", VA = "0x1822EAD20")]
		private bool HMOKPIFAKCL(Entity NNCGIOJNJIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x22EB080", Offset = "0x22E9C80", VA = "0x1822EB080")]
		public void IEPLAPCAJCO(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x22EB120", Offset = "0x22E9D20", VA = "0x1822EB120")]
		private void JKPLCMOJEME(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x22EB280", Offset = "0x22E9E80", VA = "0x1822EB280")]
		private void NMNIIINEJJC(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x22EAF20", Offset = "0x22E9B20", VA = "0x1822EAF20")]
		private void IDJFECOFPFD(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x22EA8C0", Offset = "0x22E94C0", VA = "0x1822EA8C0")]
		private void CLNLNDLEBFF(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[PCJLLMMMFMG(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.Embodiment)]
	internal sealed class ObjectNetworkToLocalMapService : GLEEPPGLLOC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private NativeHashMap<EEDOLIFAKPN, Entity> ICOLJLFLIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private DJFBKNFJCKG PEFFPCJPBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private ALMILKEKENF JFBMPLDKGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private EntityManager DEFMCCAEPJC;

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		internal NativeHashMap<EEDOLIFAKPN, Entity> MPHDIOIKNLN
		{
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A40", Offset = "0x8F4640", VA = "0x1808F5A40")]
			get
			{
				return default(NativeHashMap<EEDOLIFAKPN, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x22EB5C0", Offset = "0x22EA1C0", VA = "0x1822EB5C0", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x22EB6F0", Offset = "0x22EA2F0", VA = "0x1822EB6F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x22EB900", Offset = "0x22EA500", VA = "0x1822EB900")]
		public void MNHBKLHOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x22EB840", Offset = "0x22EA440", VA = "0x1822EB840")]
		private GDHDBKNKOKH GPBOHBAFHHD(Entity NNCGIOJNJIH)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x22EB4E0", Offset = "0x22EA0E0", VA = "0x1822EB4E0")]
		public GDHDBKNKOKH BLAKDJDJKFD(EEDOLIFAKPN PLIJDIMDLMI)
		{
			return default(GDHDBKNKOKH);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x22EB7B0", Offset = "0x22EA3B0", VA = "0x1822EB7B0")]
		public EEDOLIFAKPN GHJADADNKKE(GDHDBKNKOKH IFPFHNLOHFM)
		{
			return default(EEDOLIFAKPN);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x22EB870", Offset = "0x22EA470", VA = "0x1822EB870")]
		public void ILBPFEKDBLN(Entity NNCGIOJNJIH, EEDOLIFAKPN PLIJDIMDLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x22EB750", Offset = "0x22EA350", VA = "0x1822EB750")]
		public void EKMHCFJFGCK(Entity NNCGIOJNJIH, EEDOLIFAKPN PLIJDIMDLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x22EB690", Offset = "0x22EA290", VA = "0x1822EB690")]
		public void CKABPLFNNGG(Entity NNCGIOJNJIH, EEDOLIFAKPN PLIJDIMDLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x22EB960", Offset = "0x22EA560", VA = "0x1822EB960")]
		public void OHGGPMHCKCK(Entity NNCGIOJNJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[KHHGHKHGGFN(EOABPLMDMOL.Prefabs)]
	[APAIBGLBFHK(typeof(DJFBKNFJCKG))]
	[PCJLLMMMFMG(typeof(ObjectPrefabCreationService), new string[] { })]
	internal sealed class ObjectPrefabCreationService : OIKHNMLOMLN, BHNKHJBOFIN, GLEEPPGLLOC, MJAFAPEAAKM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private DJFBKNFJCKG DFJHEIJOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private NLIGFDOHODI JBCJCNPKPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private JFPLKGANNDJ OEIKJJKLIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ObjectNetworkToLocalMapService CCIEDGODKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private ObjectLifecycleService LNMLGEFGGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private BHICJDGEHAN CEGBCPNNCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private OFMBKHHKHGK IHBIJENOFCJ;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public int HNCHGLFGJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x22EBDD0", Offset = "0x22EA9D0", VA = "0x1822EBDD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
		public void HBGKEGAFJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x22EBBB0", Offset = "0x22EA7B0", VA = "0x1822EBBB0", Slot = "5")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x22EC000", Offset = "0x22EAC00", VA = "0x1822EC000", Slot = "6")]
		public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x22EBDF0", Offset = "0x22EA9F0", VA = "0x1822EBDF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x22EBEA0", Offset = "0x22EAAA0", VA = "0x1822EBEA0")]
		private void PNOLMFKJMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x22EBCF0", Offset = "0x22EA8F0", VA = "0x1822EBCF0")]
		public void BOMIDHABCMO(bool PPDFINNPBCJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x22EBEA0", Offset = "0x22EAAA0", VA = "0x1822EBEA0")]
		private void EFKEHNBLOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x22EBB70", Offset = "0x22EA770", VA = "0x1822EBB70")]
		public Entity AFDKJCKHECB(GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x22EBA80", Offset = "0x22EA680", VA = "0x1822EBA80")]
		public Entity AFDKJCKHECB(GGPLMDHKFKM DFPCAFCOFNA, EEDOLIFAKPN PLIJDIMDLMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x22EBDB0", Offset = "0x22EA9B0", VA = "0x1822EBDB0")]
		public Entity CDKLHBJFFCM(GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x22EC0D0", Offset = "0x22EACD0", VA = "0x1822EC0D0")]
		public Entity LOHNFJICDGO(EEDOLIFAKPN PLIJDIMDLMI, GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x22EBB70", Offset = "0x22EA770", VA = "0x1822EBB70")]
		public Entity GNDBCCFLEHM(GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x22EC090", Offset = "0x22EAC90", VA = "0x1822EC090")]
		public Entity JENKFHCCNKM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x22EC190", Offset = "0x22EAD90", VA = "0x1822EC190")]
		public Entity MKIOGIKCIDJ(AGOBHJFJLNP HCPDGKICMEB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x22EC1E0", Offset = "0x22EADE0", VA = "0x1822EC1E0")]
		public Entity NPFGAHHPCIJ(MKMAJNKPPKN HCPDGKICMEB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x22EBB20", Offset = "0x22EA720", VA = "0x1822EBB20")]
		public NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)> AFDKJCKHECB(NativeArray<GDHDBKNKOKH> HIMBCNPDLCF, Allocator KIPGDNHHBGE)
		{
			return default(NativeArray<(GDHDBKNKOKH, GDHDBKNKOKH)>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x22EC230", Offset = "0x22EAE30", VA = "0x1822EC230")]
		public IEnumerable<GGPLMDHKFKM> PBCFBHDAAGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x22EC170", Offset = "0x22EAD70", VA = "0x1822EC170")]
		public EntityArchetype MKFOPGNEDJI(GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x22EBED0", Offset = "0x22EAAD0", VA = "0x1822EBED0")]
		public Entity EIACHKBKPAB(GGPLMDHKFKM DFPCAFCOFNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x22EBEF0", Offset = "0x22EAAF0", VA = "0x1822EBEF0")]
		private Entity EJGAEKIPCJK(GGPLMDHKFKM DFPCAFCOFNA, EEDOLIFAKPN PLIJDIMDLMI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ObjectPrefabCreationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal class BHICJDGEHAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class CJIJHPJKBGI : IEnumerable<(AGOBHJFJLNP, GGPLMDHKFKM)>, IEnumerable, IEnumerator<(AGOBHJFJLNP, GGPLMDHKFKM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private (AGOBHJFJLNP primitiveType, GGPLMDHKFKM prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public BHICJDGEHAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		private (AGOBHJFJLNP, GGPLMDHKFKM) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x130C560", Offset = "0x130B160", VA = "0x18130C560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((AGOBHJFJLNP, GGPLMDHKFKM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x2274080", Offset = "0x2272C80", VA = "0x182274080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x22740D0", Offset = "0x2272CD0", VA = "0x1822740D0")]
		[DebuggerHidden]
		public CJIJHPJKBGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x2273EA0", Offset = "0x2272AA0", VA = "0x182273EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x2274030", Offset = "0x2272C30", VA = "0x182274030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x2273F90", Offset = "0x2272B90", VA = "0x182273F90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(AGOBHJFJLNP, GGPLMDHKFKM)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x2273F90", Offset = "0x2272B90", VA = "0x182273F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private readonly World DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly Dictionary<GGPLMDHKFKM, Entity> CEGBCPNNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private readonly Dictionary<GGPLMDHKFKM, EntityArchetype> PKNOPOAPBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly Dictionary<AGOBHJFJLNP, GGPLMDHKFKM> HBGGLOFKEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly Dictionary<MKMAJNKPPKN, GGPLMDHKFKM> MAONGFFJOGC;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x115C660", Offset = "0x115B260", VA = "0x18115C660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x226DF60", Offset = "0x226CB60", VA = "0x18226DF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x2271270", Offset = "0x226FE70", VA = "0x182271270")]
	public BHICJDGEHAN(World DFJHEIJOIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x226DDC0", Offset = "0x226C9C0", VA = "0x18226DDC0")]
	private void CPHCBMEKJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x226E920", Offset = "0x226D520", VA = "0x18226E920")]
	private void LBLOJPNBEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x2270870", Offset = "0x226F470", VA = "0x182270870")]
	private void PBGADOHPGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x226DD50", Offset = "0x226C950", VA = "0x18226DD50")]
	private ELLCPPFJILJ CNOIEAAGGND()
	{
		return default(ELLCPPFJILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1320", Offset = "0x1F9FF20", VA = "0x181FA1320")]
	private void FMBBPIBHIEO<T>(GGPLMDHKFKM DFPCAFCOFNA, ELLCPPFJILJ COEEIMIEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x226E1B0", Offset = "0x226CDB0", VA = "0x18226E1B0")]
	private void FMBBPIBHIEO(GGPLMDHKFKM DFPCAFCOFNA, ELLCPPFJILJ COEEIMIEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x226D070", Offset = "0x226BC70", VA = "0x18226D070")]
	public void BOMIDHABCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x22701E0", Offset = "0x226EDE0", VA = "0x1822701E0")]
	public EntityArchetype MKFOPGNEDJI(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2270170", Offset = "0x226ED70", VA = "0x182270170")]
	[IteratorStateMachine(typeof(CJIJHPJKBGI))]
	private IEnumerable<(AGOBHJFJLNP, GGPLMDHKFKM)> MIEMLMKPLPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x226CC30", Offset = "0x226B830", VA = "0x18226CC30")]
	public Entity AFDKJCKHECB(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x226E6A0", Offset = "0x226D2A0", VA = "0x18226E6A0")]
	public GGPLMDHKFKM JDBNKLLLKBM(MKMAJNKPPKN HCPDGKICMEB)
	{
		return default(GGPLMDHKFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x226E640", Offset = "0x226D240", VA = "0x18226E640")]
	public GGPLMDHKFKM JDBNKLLLKBM(AGOBHJFJLNP HCPDGKICMEB)
	{
		return default(GGPLMDHKFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x226E7E0", Offset = "0x226D3E0", VA = "0x18226E7E0")]
	private Entity KFKBMNIMGHD()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x226E740", Offset = "0x226D340", VA = "0x18226E740")]
	private Entity JJHDBDGKBEA()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x226CFD0", Offset = "0x226BBD0", VA = "0x18226CFD0")]
	private Entity BMPNPDCBPIF()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2270380", Offset = "0x226EF80", VA = "0x182270380")]
	private Entity NPKPJPAIJKM()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x226E140", Offset = "0x226CD40", VA = "0x18226E140")]
	private Entity FKGDHADAFAG()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x2270240", Offset = "0x226EE40", VA = "0x182270240")]
	private Entity MNHHPPLOAKB()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x226E010", Offset = "0x226CC10", VA = "0x18226E010")]
	private Entity FBDJLNMIACN(AGOBHJFJLNP EBLHLGNAFML)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x226E880", Offset = "0x226D480", VA = "0x18226E880")]
	private Entity KHMNBJEEOEI(MKMAJNKPPKN HCPDGKICMEB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x2270120", Offset = "0x226ED20", VA = "0x182270120")]
	private Entity LEJMOMFKCNP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2270570", Offset = "0x226F170", VA = "0x182270570")]
	private void OFBCNHDEPMH(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x226E410", Offset = "0x226D010", VA = "0x18226E410")]
	private void IADJDFDIOIJ(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x226CD30", Offset = "0x226B930", VA = "0x18226CD30")]
	private void AKPOLBJBDOA(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x226E270", Offset = "0x226CE70", VA = "0x18226E270")]
	private Entity GNDBCCFLEHM(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x2270470", Offset = "0x226F070", VA = "0x182270470")]
	private Entity OEFCNHLGGLF(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0BA0", Offset = "0x1F9F7A0", VA = "0x181FA0BA0")]
	private void DPNLKEHHEON<T>(Entity NNCGIOJNJIH, T PDMPLJICJLE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x226DCC0", Offset = "0x226C8C0", VA = "0x18226DCC0")]
	private Entity CDKLHBJFFCM(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x226E700", Offset = "0x226D300", VA = "0x18226E700")]
	private Entity JGPIGAJBFOP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x2270130", Offset = "0x226ED30", VA = "0x182270130")]
	private Entity LEOFJAKKFBF()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x226CF10", Offset = "0x226BB10", VA = "0x18226CF10")]
	private Entity BGIDOCGJLKC()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x22711B0", Offset = "0x226FDB0", VA = "0x1822711B0")]
	private Entity PBMHPOBEJHP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x2270610", Offset = "0x226F210", VA = "0x182270610")]
	private void PANJMHHLANG(Entity NNCGIOJNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x226DDE0", Offset = "0x226C9E0", VA = "0x18226DDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2270820", Offset = "0x226F420", VA = "0x182270820")]
	public IEnumerable<GGPLMDHKFKM> PBCFBHDAAGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x226DFB0", Offset = "0x226CBB0", VA = "0x18226DFB0")]
	public Entity EIACHKBKPAB(GGPLMDHKFKM DFPCAFCOFNA)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[PCJLLMMMFMG(typeof(PropertyEventCallbacksService), new string[] { })]
	[KHHGHKHGGFN(EOABPLMDMOL.Callbacks)]
	public class PropertyEventCallbacksService : GLEEPPGLLOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		private struct KIIMKGICPPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			public JMJFHPFMJDH HGFJMMOGKFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public Type HCPDGKICMEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public int AABEJHHLOHL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		private struct CJFMEPLFGEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public KIIMKGICPPA[] OHOCCAOGOIA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000177")]
		public delegate void JMJFHPFMJDH(Entity NNCGIOJNJIH, GBEPIPMPHEG MKJDELBEPBK, BNKGCKPKCFJ EHMKAJMLGBB, BNKGCKPKCFJ GBEJOMHKKEA);

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private static readonly PEOJNAGCHAI NLGECAJFNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private readonly Dictionary<GBEPIPMPHEG, JMJFHPFMJDH> HBIJLNFBGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private readonly Dictionary<int, CJFMEPLFGEG> LOBFDGLPABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private MACMHPECBIO OHOCCAOGOIA;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action KBFLKNIHDGI
		{
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x22F0B10", Offset = "0x22EF710", VA = "0x1822F0B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x22F0540", Offset = "0x22EF140", VA = "0x1822F0540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action MJKKJECAGMD
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0x22F12D0", Offset = "0x22EFED0", VA = "0x1822F12D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0x22F0900", Offset = "0x22EF500", VA = "0x1822F0900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x22F04E0", Offset = "0x22EF0E0", VA = "0x1822F04E0", Slot = "4")]
		public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x22F09A0", Offset = "0x22EF5A0", VA = "0x1822F09A0")]
		public void LGPGOGPHNHB(GBEPIPMPHEG MKJDELBEPBK, JMJFHPFMJDH HGFJMMOGKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x22F02B0", Offset = "0x22EEEB0", VA = "0x1822F02B0")]
		public void APMMIFHLLID(GBEPIPMPHEG MKJDELBEPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x22F05E0", Offset = "0x22EF1E0", VA = "0x1822F05E0")]
		internal void FMAHIEEIMKD(LNJHMHFINIC DGLKFIPALBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x22F0DE0", Offset = "0x22EF9E0", VA = "0x1822F0DE0")]
		private void OEEJNGOFGBF(LNJHMHFINIC DGLKFIPALBO, int DGOFBPBLNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x22F0BB0", Offset = "0x22EF7B0", VA = "0x1822F0BB0")]
		private void NHPPDEEMNFP(PIGCJKHMOBI JMMMLGCJDIC, EPHEKOJILAC BCNBEEFAJHF, KIIMKGICPPA GFPLPDLAOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x22F0390", Offset = "0x22EEF90", VA = "0x1822F0390")]
		private CJFMEPLFGEG BHMPODNIGMM(PIGCJKHMOBI JMMMLGCJDIC, EPHEKOJILAC BCNBEEFAJHF)
		{
			return default(CJFMEPLFGEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x22F0820", Offset = "0x22EF420", VA = "0x1822F0820")]
		private KIIMKGICPPA IAAKMJDKKPL(CJFMEPLFGEG CMCJHIBMAKJ, PIGCJKHMOBI JMMMLGCJDIC, EPHEKOJILAC BCNBEEFAJHF)
		{
			return default(KIIMKGICPPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x22F13C0", Offset = "0x22EFFC0", VA = "0x1822F13C0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[PCJLLMMMFMG(typeof(MEMHLILDHIH), new string[] { })]
public class NPODGAPBIKC : GLEEPPGLLOC, MJAFAPEAAKM, MEMHLILDHIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class BDCOMNHNKAK : IEnumerable<MOBDBBHLBGC>, IEnumerable, IEnumerator<MOBDBBHLBGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private MOBDBBHLBGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public NPODGAPBIKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private PMDIHHGIGCD spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public PMDIHHGIGCD <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		private MOBDBBHLBGC System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MOBDBBHLBGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x2556850", Offset = "0x2555450", VA = "0x182556850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA0D7D0", Offset = "0xA0C3D0", VA = "0x180A0D7D0")]
		[DebuggerHidden]
		public BDCOMNHNKAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2556600", Offset = "0x2555200", VA = "0x182556600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2556800", Offset = "0x2555400", VA = "0x182556800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x2556750", Offset = "0x2555350", VA = "0x182556750", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MOBDBBHLBGC> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2556750", Offset = "0x2555350", VA = "0x182556750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private MOLNOAJNEJN IAGGMDGICBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private ObjectPrefabCreationService CEGBCPNNCHP;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private EntityManager OOLEAOGIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2564F30", Offset = "0x2563B30", VA = "0x182564F30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private DMFKDOOKGAJ AAEMACHOPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2564980", Offset = "0x2563580", VA = "0x182564980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x2564900", Offset = "0x2563500", VA = "0x182564900", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2564BB0", Offset = "0x25637B0", VA = "0x182564BB0", Slot = "5")]
	public void HFMICLBNMPB(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x2564AD0", Offset = "0x25636D0", VA = "0x182564AD0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x2564630", Offset = "0x2563230", VA = "0x182564630")]
	private void AIKCKDKHNKA(Entity HHCFKOLMCGO, in BNKGCKPKCFJ IMPDCCMAPOP, in BNKGCKPKCFJ GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2564C70", Offset = "0x2563870", VA = "0x182564C70", Slot = "12")]
	public PMDIHHGIGCD JENKFHCCNKM()
	{
		return default(PMDIHHGIGCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2565370", Offset = "0x2563F70", VA = "0x182565370", Slot = "6")]
	public MOBDBBHLBGC PJNEOCFBNHA(PMDIHHGIGCD AIFCFJHEJLG, [Optional] Vector3? AJODAOPNJGC, [Optional] Quaternion? HMDLEIFEMBE, [Optional] Vector3? AEDGLIBFDNE)
	{
		return default(MOBDBBHLBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2564B60", Offset = "0x2563760", VA = "0x182564B60", Slot = "13")]
	public MOBDBBHLBGC EPNJAKDPEOA(PMDIHHGIGCD AIFCFJHEJLG, int BAOHKIGDOBF, [Optional] Vector3? AJODAOPNJGC, [Optional] Quaternion? HMDLEIFEMBE, [Optional] Vector3? AEDGLIBFDNE)
	{
		return default(MOBDBBHLBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2565030", Offset = "0x2563C30", VA = "0x182565030", Slot = "7")]
	public MOBDBBHLBGC ODPBDDMLBDP(PMDIHHGIGCD AIFCFJHEJLG, int BAOHKIGDOBF)
	{
		return default(MOBDBBHLBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x2564A40", Offset = "0x2563640", VA = "0x182564A40", Slot = "14")]
	public void DJJCDFADBEB(PMDIHHGIGCD AIFCFJHEJLG, MOBDBBHLBGC OJJDANFEAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x2564D90", Offset = "0x2563990", VA = "0x182564D90", Slot = "8")]
	public void JLGCEPEPLMH(PMDIHHGIGCD AIFCFJHEJLG, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x25651E0", Offset = "0x2563DE0", VA = "0x1825651E0", Slot = "15")]
	public void ONNPMCELIGO(PMDIHHGIGCD AIFCFJHEJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2564860", Offset = "0x2563460", VA = "0x182564860", Slot = "9")]
	public int BFFNMIKJGJJ(PMDIHHGIGCD AIFCFJHEJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2564D00", Offset = "0x2563900", VA = "0x182564D00", Slot = "10")]
	[IteratorStateMachine(typeof(BDCOMNHNKAK))]
	public IEnumerable<MOBDBBHLBGC> JGHAHEKOIGI(PMDIHHGIGCD AIFCFJHEJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x2565150", Offset = "0x2563D50", VA = "0x182565150")]
	private bool OGJFNNJOFBF(PMDIHHGIGCD AIFCFJHEJLG, out NativeArray<Entity> PPLIDDKCFMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x2564F80", Offset = "0x2563B80", VA = "0x182564F80")]
	private NativeArray<Entity> NELHNEHGMKJ(PMDIHHGIGCD AIFCFJHEJLG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NPODGAPBIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[PCJLLMMMFMG(typeof(NPHACLKFACK), new string[] { })]
internal sealed class NPHACLKFACK : GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private DJFBKNFJCKG DFJHEIJOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private TransformOwnershipPhase PDMJCBOMAOF;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private IMONMIBPEJJ ADPEJAKCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2564430", Offset = "0x2563030", VA = "0x182564430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x2564480", Offset = "0x2563080", VA = "0x182564480", Slot = "4")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x2564500", Offset = "0x2563100", VA = "0x182564500")]
	public void MCEMMKBJGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x25641F0", Offset = "0x2562DF0", VA = "0x1825641F0")]
	public void BBJHEFIPFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NPHACLKFACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[DefaultMember("Item")]
public struct AIGHKBHAOJO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private T[] CEECNJJKNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private int LIJNMPAFKGC;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x8A34B0", Offset = "0x8A20B0", VA = "0x1808A34B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x22BDAE0", Offset = "0x22BC6E0", VA = "0x1822BDAE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Span<T> JOLKGPIDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2EDFAE0", Offset = "0x2EDE6E0", VA = "0x182EDFAE0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool IJOOMGLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xBB9190", Offset = "0xBB7D90", VA = "0x180BB9190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x2EDFC30", Offset = "0x2EDE830", VA = "0x182EDFC30")]
	public AIGHKBHAOJO(int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x2EDFB80", Offset = "0x2EDE780", VA = "0x182EDFB80")]
	public int OIPMBJNKOEM(T PDMPLJICJLE, int DJHHNCHEKKB, int GCKMDOIKFCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x2EDFA20", Offset = "0x2EDE620", VA = "0x182EDFA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[DefaultMember("Item")]
public struct CNOFKDPPNDI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private global::AIGHKBHAOJO<T> CEECNJJKNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private int LIJNMPAFKGC;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x2352020", Offset = "0x2350C20", VA = "0x182352020")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x23513B0", Offset = "0x234FFB0", VA = "0x1823513B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public int DBOEJCGBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x2352530", Offset = "0x2351130", VA = "0x182352530")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x2352220", Offset = "0x2350E20", VA = "0x182352220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool IJOOMGLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x2351B60", Offset = "0x2350760", VA = "0x182351B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Span<T> JOLKGPIDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x2351A40", Offset = "0x2350640", VA = "0x182351A40")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2352630", Offset = "0x2351230", VA = "0x182352630")]
	public CNOFKDPPNDI(int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2351B10", Offset = "0x2350710", VA = "0x182351B10")]
	public T HCKDABMJFIH(int BAOHKIGDOBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2352560", Offset = "0x2351160", VA = "0x182352560")]
	public void PONAENFKJPP(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x23520C0", Offset = "0x2350CC0", VA = "0x1823520C0")]
	public void LOPHKMHFBKH(Span<T> EJNJGLOFIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2351E00", Offset = "0x2350A00", VA = "0x182351E00")]
	public void JNIPLPDFDNO(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x2351210", Offset = "0x234FE10", VA = "0x182351210")]
	private void ANPALFNMDLP(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x2351460", Offset = "0x2350060", VA = "0x182351460")]
	public void DIIKIMNFFNL(Span<T> DDJJEIOCKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2351400", Offset = "0x2350000", VA = "0x182351400")]
	public void DHEKKBPKDLA(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x23516E0", Offset = "0x23502E0", VA = "0x1823516E0")]
	public void EPKOAPNONFA(int EEKJCHFDMGK, int HDGDBPHDMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x2352380", Offset = "0x2350F80", VA = "0x182352380")]
	public void OFOMMAGAOIE(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x2351C00", Offset = "0x2350800", VA = "0x182351C00")]
	public void JMENJDMBEAH(int EEKJCHFDMGK, int HDGDBPHDMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2350EA0", Offset = "0x234FAA0", VA = "0x182350EA0")]
	public void ACHIKFMMOEM(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x2352470", Offset = "0x2351070", VA = "0x182352470")]
	public void OPIDBKGALDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x23523E0", Offset = "0x2350FE0", VA = "0x1823523E0")]
	public int OIPMBJNKOEM(T PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x2351BA0", Offset = "0x23507A0", VA = "0x182351BA0")]
	public bool HNMPINFIMAB(T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2351620", Offset = "0x2350220", VA = "0x182351620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x23525D0", Offset = "0x23511D0", VA = "0x1823525D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x2351670", Offset = "0x2350270", VA = "0x182351670")]
	public static Span<T> EDHAFEIJFCP(global::CNOFKDPPNDI<T> EJNJGLOFIFF)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x2351100", Offset = "0x234FD00", VA = "0x182351100")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void AFFJFEPPEEE(int PDMPLJICJLE, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void FEKEAHFFHEM(int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x23518F0", Offset = "0x23504F0", VA = "0x1823518F0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void FEKEAHFFHEM(int LIJNMPAFKGC, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2352270", Offset = "0x2350E70", VA = "0x182352270")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NDFLKAGKFAD(int PDMPLJICJLE, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x2350F60", Offset = "0x234FB60", VA = "0x182350F60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ADLLIECMAOO(int EEKJCHFDMGK, int HDGDBPHDMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2351F10", Offset = "0x2350B10", VA = "0x182351F10")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KDLLPIOIOEL(int PDMPLJICJLE, int LIJNMPAFKGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public struct KGBHHKGFLKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private const int GGKBNPFAKPH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private NativeList<Entity> PGMFELKKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private TransformAccessArray HILNOPGMOJL;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x25FE0B0", Offset = "0x25FCCB0", VA = "0x1825FE0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public NativeList<Entity> HLKLKEHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xB53810", Offset = "0xB52410", VA = "0x180B53810")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public TransformAccessArray JAFMDCEJIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x25FE280", Offset = "0x25FCE80", VA = "0x1825FE280")]
	public KGBHHKGFLKL(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x25FE120", Offset = "0x25FCD20", VA = "0x1825FE120")]
	public Entity IEEGMGNOJOL(int BAOHKIGDOBF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x25FE110", Offset = "0x25FCD10", VA = "0x1825FE110")]
	public Transform HJDGHBLHALJ(int BAOHKIGDOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x25FE0C0", Offset = "0x25FCCC0", VA = "0x1825FE0C0")]
	public void FCGNKHMIOHP(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x25FDF50", Offset = "0x25FCB50", VA = "0x1825FDF50")]
	public void AMPFGPLPHGE(int FHGPEPJEFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x25FE170", Offset = "0x25FCD70", VA = "0x1825FE170")]
	public int JNIPLPDFDNO(Transform DMEEHMHNHEF, Entity NNCGIOJNJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x25FDFC0", Offset = "0x25FCBC0", VA = "0x1825FDFC0")]
	public int DHEKKBPKDLA(int BAOHKIGDOBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x25FE040", Offset = "0x25FCC40", VA = "0x1825FE040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x25FE240", Offset = "0x25FCE40", VA = "0x1825FE240")]
	private void NPHELJNJMGF(int FFJOAELJOPP = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class JBCHJCAKILL
{
	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void DFCBEOJFPJJ(in Vector3 AJODAOPNJGC, in Quaternion HMDLEIFEMBE, in Vector3 AEDGLIBFDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void CBBGMIJGHKA(in Vector3 KJNFENAJMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void IMDJPKGMEDF(in Quaternion HMDLEIFEMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void DCBLJNLGEDG(in Vector3 GPGPNLOJMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void PNDOHEIFIGP(in Vector3 GPGPNLOJMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void MGJFOMAJGHL(in float PAOAAONMMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x25FACB0", Offset = "0x25F98B0", VA = "0x1825FACB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EBEEGLOGGGM(in float3 PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	public static void CPACPBJLPEL(in float PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x25FAC10", Offset = "0x25F9810", VA = "0x1825FAC10")]
	[Conditional("DEBUG_BUILD")]
	public static void CPACPBJLPEL(in Vector3 PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x25FAB80", Offset = "0x25F9780", VA = "0x1825FAB80")]
	[Conditional("DEBUG_BUILD")]
	public static void CPACPBJLPEL(in Quaternion PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x25FAE70", Offset = "0x25F9A70", VA = "0x1825FAE70")]
	[Conditional("DEBUG_BUILD")]
	public static void KFKNAADJDFP(in float PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x25FAD50", Offset = "0x25F9950", VA = "0x1825FAD50")]
	[Conditional("DEBUG_BUILD")]
	public static void KFKNAADJDFP(in Vector3 PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x25FADF0", Offset = "0x25F99F0", VA = "0x1825FADF0")]
	[Conditional("DEBUG_BUILD")]
	public static void KFKNAADJDFP(in Quaternion PDMPLJICJLE, string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JBCHJCAKILL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public struct EGLCLPAGKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public Entity NNCGIOJNJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public Entity PPHLLODMENC;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0xDB4450", Offset = "0xDB3050", VA = "0x180DB4450")]
	public EGLCLPAGKII(Entity NNCGIOJNJIH, Entity PPHLLODMENC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2278AC0", Offset = "0x22776C0", VA = "0x182278AC0")]
	public static EGLCLPAGKII EDHAFEIJFCP((Entity entity, Entity parent) OPOJLEDJDHG)
	{
		return default(EGLCLPAGKII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x2278AB0", Offset = "0x22776B0", VA = "0x182278AB0")]
	public void EAJCABHENAD(out Entity NNCGIOJNJIH, out Entity PPHLLODMENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public struct GOKMAJOKCDN<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private GCHandle PEIBOBCLLBF;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool OOAEDAOLDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x25FE350", Offset = "0x25FCF50", VA = "0x1825FE350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x3731C40", Offset = "0x3730840", VA = "0x183731C40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x3731B50", Offset = "0x3730750", VA = "0x183731B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x3731CE0", Offset = "0x37308E0", VA = "0x183731CE0")]
	public GOKMAJOKCDN(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x3731C10", Offset = "0x3730810", VA = "0x183731C10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(ILEAPNKMPHK))]
public sealed class ILFMCFINDDH : PEOFMAHAIPC
{
	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public ILFMCFINDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[EFHICEMKHKB]
[UpdateAfter(typeof(ILFMCFINDDH))]
[UpdateInGroup(typeof(ILEAPNKMPHK))]
public sealed class OKJGGIFGDDE : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x2566960", Offset = "0x2565560", VA = "0x182566960")]
	public OKJGGIFGDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[EFHICEMKHKB]
[UpdateAfter(typeof(OKJGGIFGDDE))]
[UpdateInGroup(typeof(ILEAPNKMPHK))]
public sealed class FBAGDFPHJLD : NCIIEKFAHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public FBAGDFPHJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(DCCFPPLOLEP))]
public class KFLKDCEDCJJ : DLNGJKMFNAC
{
	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public KFLKDCEDCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x25FDF20", Offset = "0x25FCB20", VA = "0x1825FDF20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(DCCFPPLOLEP))]
public class KOKKABFAIDH : LDGDOOHPAAH
{
	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public KOKKABFAIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(DCCFPPLOLEP))]
public class AJCCNILENFI : EJJANMLJPAF
{
	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public AJCCNILENFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x226B640", Offset = "0x226A240", VA = "0x18226B640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(AOPKLGLAIIJ))]
public sealed class IBFBOJAGHLB : ELMHHJAJPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x25F73D0", Offset = "0x25F5FD0", VA = "0x1825F73D0")]
	public IBFBOJAGHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x25F73C0", Offset = "0x25F5FC0", VA = "0x1825F73C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(MMLMIPFCGBD))]
public class HOOPEGLIIBH : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x25F6200", Offset = "0x25F4E00", VA = "0x1825F6200")]
	public HOOPEGLIIBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[EFHICEMKHKB]
[UpdateAfter(typeof(HOOPEGLIIBH))]
[UpdateInGroup(typeof(MMLMIPFCGBD))]
public class OHLPMBDFANA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public OHLPMBDFANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(GLGEPOOIJFM))]
public class BDPDDIBOGED : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public BDPDDIBOGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[EFHICEMKHKB]
[UpdateAfter(typeof(BDPDDIBOGED))]
[UpdateInGroup(typeof(GLGEPOOIJFM))]
public class APAEKECAGCI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public APAEKECAGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(APAEKECAGCI))]
[UpdateBefore(typeof(DPMBKIMIGDM))]
public sealed class GGBKBMBBIIK : JMJCAHIEIBA
{
	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public GGBKBMBBIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x2280530", Offset = "0x227F130", VA = "0x182280530", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(APAEKECAGCI))]
public sealed class DPMBKIMIGDM : ELMHHJAJPCB
{
	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x2276AA0", Offset = "0x22756A0", VA = "0x182276AA0")]
	public DPMBKIMIGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x2276A60", Offset = "0x2275660", VA = "0x182276A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OHLPMBDFANA))]
public sealed class BFBGPDOHECM : LJPJHNFLILL
{
	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x226C000", Offset = "0x226AC00", VA = "0x18226C000")]
	public BFBGPDOHECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x226BFF0", Offset = "0x226ABF0", VA = "0x18226BFF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OHLPMBDFANA))]
public sealed class JGDFMHBCOOH : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x25FBC50", Offset = "0x25FA850", VA = "0x1825FBC50")]
	public JGDFMHBCOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x25FBC40", Offset = "0x25FA840", VA = "0x1825FBC40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[EFHICEMKHKB]
[UpdateAfter(typeof(JGDFMHBCOOH))]
[UpdateInGroup(typeof(OHLPMBDFANA))]
public sealed class LGOEMIJBBNC : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x2600FF0", Offset = "0x25FFBF0", VA = "0x182600FF0")]
	public LGOEMIJBBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CBDBCBDDNDL))]
public class AHINNGPGLMH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public AHINNGPGLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CBDBCBDDNDL))]
public class OMFGBPNHHKA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public OMFGBPNHHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[ExecuteAlways]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CBDBCBDDNDL))]
[UpdateAfter(typeof(AHINNGPGLMH))]
public sealed class IBHKPIDMNEE : MEOJBAKKCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public IBHKPIDMNEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[AlwaysUpdateSystem]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OMFGBPNHHKA))]
public sealed class BFEIHJNEJKL : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	protected override ApplyPropertyDifferences ICKINFJIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x226C010", Offset = "0x226AC10", VA = "0x18226C010", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x226C060", Offset = "0x226AC60", VA = "0x18226C060")]
	public BFEIHJNEJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OMFGBPNHHKA))]
[UpdateAfter(typeof(BFEIHJNEJKL))]
public sealed class JMPOJDDCCMK : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x25FDCD0", Offset = "0x25FC8D0", VA = "0x1825FDCD0")]
	public JMPOJDDCCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[EFHICEMKHKB]
[UpdateAfter(typeof(BFEIHJNEJKL))]
[UpdateInGroup(typeof(OMFGBPNHHKA))]
public sealed class JJIHFDGPNDJ : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public JJIHFDGPNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[EFHICEMKHKB]
[UpdateAfter(typeof(JJIHFDGPNDJ))]
[UpdateInGroup(typeof(OMFGBPNHHKA))]
public sealed class OJJAIPBADFD : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000156")]
	protected override ComputePropertyDifferences CIAMKCACLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x25668B0", Offset = "0x25654B0", VA = "0x1825668B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x2566900", Offset = "0x2565500", VA = "0x182566900")]
	public OJJAIPBADFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[EFHICEMKHKB]
[UpdateAfter(typeof(OJJAIPBADFD))]
[UpdateInGroup(typeof(OMFGBPNHHKA))]
public sealed class GGGHHMENMCI : ODBFEKDJEDP
{
	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x2280540", Offset = "0x227F140", VA = "0x182280540")]
	public GGGHHMENMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(AHINNGPGLMH))]
public sealed class DFELGPEHGJE : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x2275260", Offset = "0x2273E60", VA = "0x182275260")]
	public DFELGPEHGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(AHINNGPGLMH))]
public sealed class ECKBCBBFCDH : LONFLKPGNEF
{
	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public ECKBCBBFCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(GLGEPOOIJFM))]
public class GBBKKMLFFPA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public GBBKKMLFFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(GLGEPOOIJFM))]
[UpdateAfter(typeof(GBBKKMLFFPA))]
public sealed class KMALKADDAOJ : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x25FE9F0", Offset = "0x25FD5F0", VA = "0x1825FE9F0")]
	public KMALKADDAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x25FE9E0", Offset = "0x25FD5E0", VA = "0x1825FE9E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(GLGEPOOIJFM))]
[UpdateAfter(typeof(GBBKKMLFFPA))]
public sealed class LOILPCPPEDE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public LOILPCPPEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(LOILPCPPEDE))]
public sealed class OOKEILDPFNG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public OOKEILDPFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[EFHICEMKHKB]
[ExecuteAlways]
[UpdateInGroup(typeof(LOILPCPPEDE))]
[UpdateAfter(typeof(OOKEILDPFNG))]
public sealed class MNGGEIJHPOI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public MNGGEIJHPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(MNGGEIJHPOI))]
public sealed class MPJOMFCGHDO : GICDFMFIOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public MPJOMFCGHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x2560540", Offset = "0x255F140", VA = "0x182560540", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[EFHICEMKHKB]
[UpdateAfter(typeof(MPJOMFCGHDO))]
[UpdateInGroup(typeof(MNGGEIJHPOI))]
public sealed class NCOAHHFOFHH : HFHCBJHLIKF
{
	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public NCOAHHFOFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x2561330", Offset = "0x255FF30", VA = "0x182561330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(MNGGEIJHPOI))]
[UpdateAfter(typeof(NCOAHHFOFHH))]
public sealed class PFCLEFGIACK : GKADHIHODPN
{
	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0")]
	public PFCLEFGIACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[EFHICEMKHKB]
[UpdateAfter(typeof(PFCLEFGIACK))]
[UpdateInGroup(typeof(MNGGEIJHPOI))]
public class DDMFDMHAABH : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x22750D0", Offset = "0x2273CD0", VA = "0x1822750D0")]
	public DDMFDMHAABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OOKEILDPFNG))]
public sealed class NGPBAPFCJAA : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x2561BC0", Offset = "0x25607C0", VA = "0x182561BC0")]
	public NGPBAPFCJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(GBBKKMLFFPA))]
public sealed class MNKGLICBAKC : NAIMKELPABI
{
	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public MNKGLICBAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[EFHICEMKHKB]
[UpdateAfter(typeof(MNKGLICBAKC))]
[UpdateInGroup(typeof(GBBKKMLFFPA))]
public sealed class HFAHBLHIBOG : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x25F3E30", Offset = "0x25F2A30", VA = "0x1825F3E30")]
	public HFAHBLHIBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(GBBKKMLFFPA))]
[UpdateAfter(typeof(MNKGLICBAKC))]
public sealed class KBJBOIOOHDI : FGCJMAAOBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public KBJBOIOOHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[EFHICEMKHKB]
[UpdateAfter(typeof(HFAHBLHIBOG))]
[UpdateAfter(typeof(KBJBOIOOHDI))]
[UpdateInGroup(typeof(GBBKKMLFFPA))]
public sealed class LOOHBFDIABH : EIEEBPAANEO
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public LOOHBFDIABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[ExecuteAlways]
[EFHICEMKHKB]
[UpdateInGroup(typeof(PresentationSystemGroup))]
public sealed class JBMBOKOEGGI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x226B630", Offset = "0x226A230", VA = "0x18226B630")]
	public JBMBOKOEGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class BGILOMCCJMH : JCJNBFFMOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x226C4E0", Offset = "0x226B0E0", VA = "0x18226C4E0")]
	public BGILOMCCJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
[UpdateAfter(typeof(BGILOMCCJMH))]
public sealed class AGAGCEGEOPJ : LDBLKMOPEDI
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x226B5D0", Offset = "0x226A1D0", VA = "0x18226B5D0")]
	public AGAGCEGEOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
[AlwaysUpdateSystem]
[EFHICEMKHKB]
[UpdateAfter(typeof(BGILOMCCJMH))]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class FFHHPAAIHCA : FJGIEENMGNF
{
	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x227B7E0", Offset = "0x227A3E0", VA = "0x18227B7E0")]
	public FFHHPAAIHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x227B7A0", Offset = "0x227A3A0", VA = "0x18227B7A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
[AlwaysUpdateSystem]
[EFHICEMKHKB]
[UpdateAfter(typeof(BGILOMCCJMH))]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class ADHBJJIFOKO : MDPKLBLGFPN
{
	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x226B250", Offset = "0x2269E50", VA = "0x18226B250")]
	public ADHBJJIFOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x226B240", Offset = "0x2269E40", VA = "0x18226B240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class BCGPMKAAHGI : NDBDEAGKOGC
{
	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public BCGPMKAAHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x226BFD0", Offset = "0x226ABD0", VA = "0x18226BFD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class ELMFELCGODE : MNBOEMAPPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x2279630", Offset = "0x2278230", VA = "0x182279630")]
	public ELMFELCGODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x2279620", Offset = "0x2278220", VA = "0x182279620", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class MMKGOALHNIF : BMIDABOCLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x2560490", Offset = "0x255F090", VA = "0x182560490")]
	public MMKGOALHNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x2560480", Offset = "0x255F080", VA = "0x182560480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class OJGHLDMAENI : CPFFLBDIICM
{
	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x25668A0", Offset = "0x25654A0", VA = "0x1825668A0")]
	public OJGHLDMAENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x2566890", Offset = "0x2565490", VA = "0x182566890", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(JBMBOKOEGGI))]
public sealed class LHIEMLGLCHP : CLKALALNKPI
{
	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x2601060", Offset = "0x25FFC60", VA = "0x182601060")]
	public LHIEMLGLCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x2601050", Offset = "0x25FFC50", VA = "0x182601050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(OCDLKNFDIAD))]
public class JGKNJFHGDKB : GIBPKPMFPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public JGKNJFHGDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x25FBCB0", Offset = "0x25FA8B0", VA = "0x1825FBCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CGGCCIPMHLO))]
public sealed class LKHOOIBLJFO : DCEBMLLFHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public LKHOOIBLJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2601A70", Offset = "0x2600670", VA = "0x182601A70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
[EFHICEMKHKB]
[UpdateAfter(typeof(LKHOOIBLJFO))]
[UpdateInGroup(typeof(CGGCCIPMHLO))]
public class NIIHJMMOAGB : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x25621B0", Offset = "0x2560DB0", VA = "0x1825621B0")]
	public NIIHJMMOAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x25621A0", Offset = "0x2560DA0", VA = "0x1825621A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[EFHICEMKHKB]
[AlwaysUpdateSystem]
[UpdateInGroup(typeof(CGGCCIPMHLO))]
[UpdateAfter(typeof(NIIHJMMOAGB))]
public sealed class CMGCDDPCMNO : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	protected override ApplyPropertyDifferences ICKINFJIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x22747D0", Offset = "0x22733D0", VA = "0x1822747D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2274820", Offset = "0x2273420", VA = "0x182274820")]
	public CMGCDDPCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
[EFHICEMKHKB]
[UpdateAfter(typeof(CMGCDDPCMNO))]
[UpdateInGroup(typeof(CGGCCIPMHLO))]
public sealed class ONLJKCNGNON : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2567150", Offset = "0x2565D50", VA = "0x182567150")]
	public ONLJKCNGNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[EFHICEMKHKB]
[UpdateInGroup(typeof(CGGCCIPMHLO))]
[UpdateAfter(typeof(CMGCDDPCMNO))]
public sealed class LHPDPBPMGKO : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x226BFE0", Offset = "0x226ABE0", VA = "0x18226BFE0")]
	public LHPDPBPMGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x226B5C0", Offset = "0x226A1C0", VA = "0x18226B5C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
[PCJLLMMMFMG(typeof(CDJDJFPMFGA), new string[] { })]
public sealed class IOKLBOEFEPF : CDJDJFPMFGA, GLEEPPGLLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private KIBLKIBMNHJ LFNNPGGNOEG;

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x25FAB30", Offset = "0x25F9730", VA = "0x1825FAB30", Slot = "5")]
	public void BMOIJMPFHCF(LPPHKFGPEPM NBFNONBMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x25FAA50", Offset = "0x25F9650", VA = "0x1825FAA50")]
	public bool ADEFHBFDNLI(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, Allocator KIPGDNHHBGE, out NativeArray<Entity> PGMFELKKDCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IOKLBOEFEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x25FAA50", Offset = "0x25F9650", VA = "0x1825FAA50", Slot = "4")]
	private bool HGBBCBLCFDB(in float3 KAODMBJFCOG, in float3 PNJNNEDNALB, float FLANGJLOLNC, Allocator KIPGDNHHBGE, out NativeArray<Entity> PGMFELKKDCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[FNDKJDPJFAD(typeof(AuthoredLocalPoseData))]
public sealed class OIPDKIAALLP : EKOMHLFKHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2566800", Offset = "0x2565400", VA = "0x182566800", Slot = "8")]
	protected override bool NIMFFOIGAEK(ReadOnlySpan<AuthoredLocalPoseData> DDJJEIOCKHK, OBMBDPDKGND IMPCIAHGEFF, out ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2566740", Offset = "0x2565340", VA = "0x182566740", Slot = "9")]
	protected override bool ADMGDHIHENJ(int PGLJOAGFHIO, Span<AuthoredLocalPoseData> DDJJEIOCKHK, in ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2566880", Offset = "0x2565480", VA = "0x182566880")]
	public OIPDKIAALLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[FNDKJDPJFAD(typeof(LocalPoseData))]
public sealed class PBDBMJEEMIK : JFPHOHMFGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x2569A70", Offset = "0x2568670", VA = "0x182569A70", Slot = "8")]
	protected override bool NIMFFOIGAEK(ReadOnlySpan<LocalPoseData> DDJJEIOCKHK, OBMBDPDKGND IMPCIAHGEFF, out ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x25699B0", Offset = "0x25685B0", VA = "0x1825699B0", Slot = "9")]
	protected override bool ADMGDHIHENJ(int PGLJOAGFHIO, Span<LocalPoseData> DDJJEIOCKHK, in ReadOnlySpan<byte> HNODBNMBHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x2569AF0", Offset = "0x25686F0", VA = "0x182569AF0")]
	public PBDBMJEEMIK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[Preserve]
	internal class _RRAssemblyIndex : GNPHCGOMALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF3")]
		[Cpp2IlInjected.Address(RVA = "0x22F3CA0", Offset = "0x22F28A0", VA = "0x1822F3CA0", Slot = "6")]
		public sealed override void NJKJDJAOJEO(ELHPNAFFNEB HGFJMMOGKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x22F4410", Offset = "0x22F3010", VA = "0x1822F4410", Slot = "4")]
		public sealed override void PGNCHLHGPKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
internal class BAGDCCMIMBG : ContainerPropertyBag<KJFJPNENILE>
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	private class OFAAPJJMFLK : Property<KJFJPNENILE, CICKPBCENCE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public override string JHKHALMBKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF6")]
			[Cpp2IlInjected.Address(RVA = "0x2282060", Offset = "0x2280C60", VA = "0x182282060", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public override bool BBKIICODHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2282020", Offset = "0x2280C20", VA = "0x182282020")]
		public OFAAPJJMFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x2281FD0", Offset = "0x2280BD0", VA = "0x182281FD0", Slot = "11")]
		public override CICKPBCENCE GetValue(ref KJFJPNENILE OMBBCDBECLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x2281FF0", Offset = "0x2280BF0", VA = "0x182281FF0", Slot = "12")]
		public override void SetValue(ref KJFJPNENILE OMBBCDBECLD, CICKPBCENCE PDMPLJICJLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x226BC10", Offset = "0x226A810", VA = "0x18226BC10")]
	public BAGDCCMIMBG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x57640A0", Offset = "0x5762CA0", VA = "0x1857640A0")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x227BB70", Offset = "0x227A770", VA = "0x18227BB70")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x227B840", Offset = "0x227A440", VA = "0x18227B840")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20001C2")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
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
