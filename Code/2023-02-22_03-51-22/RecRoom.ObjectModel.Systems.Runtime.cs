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
public sealed class IMGIIIKMFGG<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class EPLJAEJKENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::IMGIIIKMFGG<T> NPILFAEKMIO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] IPPCCIGNCPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public EPLJAEJKENC(global::IMGIIIKMFGG<T> NPILFAEKMIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GCGGINCMLAL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::IMGIIIKMFGG<T> <>4__this;

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
		public GCGGINCMLAL(int <>1__state)
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
	private const int CKHHJOLJAOP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> BEEKFOFCFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int ODICABOBAPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T OMKECOOHJIM
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
	private bool LBAPGGCGMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FBJOEAADMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool OBPPCLBLLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AFIKAHDKFAP
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
	public int HGPJFHAOHMD
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
	public IMGIIIKMFGG(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public IMGIIIKMFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void PPINHDFDPLB(int BELCAJFDAHD, T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void LDKAFBDIKPM(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] LHBPEMIBDMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void DBFDBNJLJJJ(NativeArray<T> PFCDNINKMFA, int POHDMEMKCCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::IMGIIIKMFGG<>.GCGGINCMLAL))]
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
	public int EDAEEPKFCFE(T KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool BCBAFCFKBLF(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void MCNNDPEKIJO(int HMBCLHCAGKB, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void JAPDHEBCIHE(int HMBCLHCAGKB, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void NJOFBNEOKEK(int HMBCLHCAGKB, int ELOEOOGBENM, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int ILFFOHDBGCO(int BELCAJFDAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T LMANCDAIKNB(int BELCAJFDAHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void EOEDIPBOFLK(int BELCAJFDAHD, T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void CIDCKNCGDIL(int BELCAJFDAHD, T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void IMDFNFICEKL(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int IIDHMFGMCOM(int JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int PJPOJCPLOKJ(int JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void NACPNOOONCM(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void EEIJDGILCHK(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T HNIBIBHIPPF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T HKGMOKGNKCA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void IAMPNFNFFMM(int BELCAJFDAHD, IReadOnlyCollection<T> HGLAIHECBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void EFHGHOIKDHJ(int BELCAJFDAHD, int LLEPDJHOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void AJNCKAAODJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void HNBGJBMGLBM(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void AMMAENCKDHA(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void DEEKCMABCMO(int ELOEOOGBENM, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T CFBHCPJCGPL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T BOILOPKCDHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GHMAJOMNKOK]
public static class AILIPFEHOCM
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F480", Offset = "0x2C3E680", VA = "0x182C3F480")]
	static AILIPFEHOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26A08A0", Offset = "0x269FAA0", VA = "0x1826A08A0")]
	public static void GNMIMBAOKMA<T>(T NKOMPJIJHJB, ref T HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F450", Offset = "0x2C3E650", VA = "0x182C3F450")]
	public static void GNMIMBAOKMA(FixedString32 NKOMPJIJHJB, ref string HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F330", Offset = "0x2C3E530", VA = "0x182C3F330")]
	public static void GNMIMBAOKMA(string NKOMPJIJHJB, ref FixedString32 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F240", Offset = "0x2C3E440", VA = "0x182C3F240")]
	public static void GNMIMBAOKMA(FixedString64 NKOMPJIJHJB, ref string HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F270", Offset = "0x2C3E470", VA = "0x182C3F270")]
	public static void GNMIMBAOKMA(string NKOMPJIJHJB, ref FixedString64 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F3E0", Offset = "0x2C3E5E0", VA = "0x182C3F3E0")]
	public static void GNMIMBAOKMA(GKGNOKDIHMJ NKOMPJIJHJB, ref Vector3 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F2D0", Offset = "0x2C3E4D0", VA = "0x182C3F2D0")]
	public static void GNMIMBAOKMA(Vector3 NKOMPJIJHJB, ref GKGNOKDIHMJ HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F370", Offset = "0x2C3E570", VA = "0x182C3F370")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref Vector4 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F110", Offset = "0x2C3E310", VA = "0x182C3F110")]
	public static void GNMIMBAOKMA(Vector4 NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F370", Offset = "0x2C3E570", VA = "0x182C3F370")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref Quaternion HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F110", Offset = "0x2C3E310", VA = "0x182C3F110")]
	public static void GNMIMBAOKMA(Quaternion NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F180", Offset = "0x2C3E380", VA = "0x182C3F180")]
	public static void GNMIMBAOKMA(GKGNOKDIHMJ NKOMPJIJHJB, ref float3 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F2D0", Offset = "0x2C3E4D0", VA = "0x182C3F2D0")]
	public static void GNMIMBAOKMA(float3 NKOMPJIJHJB, ref GKGNOKDIHMJ HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F3A0", Offset = "0x2C3E5A0", VA = "0x182C3F3A0")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref float4 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F110", Offset = "0x2C3E310", VA = "0x182C3F110")]
	public static void GNMIMBAOKMA(float4 NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F3A0", Offset = "0x2C3E5A0", VA = "0x182C3F3A0")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref quaternion HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F1D0", Offset = "0x2C3E3D0", VA = "0x182C3F1D0")]
	public static void GNMIMBAOKMA(quaternion NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F410", Offset = "0x2C3E610", VA = "0x182C3F410")]
	public static void GNMIMBAOKMA(Entity NKOMPJIJHJB, ref LMDNEEFMHDK HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F1B0", Offset = "0x2C3E3B0", VA = "0x182C3F1B0")]
	public static void GNMIMBAOKMA(LMDNEEFMHDK NKOMPJIJHJB, ref Entity HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OEMDBJIOCGA]
public class OEFMGOFECMO : ComponentSystem, DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JHLNNPKIFCO BELPKEBIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GPJINHAGDJN NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7091C0", Offset = "0x7083C0", VA = "0x1807091C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A745F0", Offset = "0x2A737F0", VA = "0x182A745F0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
	public OEFMGOFECMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(IOHJPJGEGDO))]
internal class KLGJEKMJKNK : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x31B5F70", Offset = "0x31B5170", VA = "0x1831B5F70", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31B5EF0", Offset = "0x31B50F0", VA = "0x1831B5EF0")]
	[Preserve]
	private void NHFIBDOPLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public KLGJEKMJKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(IOHJPJGEGDO))]
internal class OIDMHGAFELH : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A74820", Offset = "0x2A73A20", VA = "0x182A74820", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public OIDMHGAFELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A2D0", Offset = "0x2A794D0", VA = "0x182A7A2D0")]
		public static ObjectModelConfigAsset CCCJKEPCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE21BA0", Offset = "0xE20DA0", VA = "0x180E21BA0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int BAMMNFGMJMI = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FADHLPPNOEF ICGADBEDOKK;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x41CBDC0", Offset = "0x41CAFC0", VA = "0x1841CBDC0")]
			public static IOLFAAOECPP FHEMMMHJIPK(int ENAKFDCFJAM)
			{
				return default(IOLFAAOECPP);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x41CC1B0", Offset = "0x41CB3B0", VA = "0x1841CC1B0")]
			private static void KHDAEKCLDBL(NFJEDPPAJMK COKFILNDBLP, NFJEDPPAJMK PAGBOOHJAJE, IOLFAAOECPP IOCKLNNJMIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x41CBBF0", Offset = "0x41CADF0", VA = "0x1841CBBF0")]
			public static int BEJCDPMKCBG(GameObject OOKBNBHDPPG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x41CC340", Offset = "0x41CB540", VA = "0x1841CC340")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void NLEIBBOLCGI(NFJEDPPAJMK OOGHONKGHEE, int ENAKFDCFJAM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static LECENBDGBAK LNELKNMCOEH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static IBAFENGCGOE CCPHBLENGBG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static LECENBDGBAK LJOKEFMODBN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A370", Offset = "0x2A79570", VA = "0x182A7A370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A7D0", Offset = "0x2A799D0", VA = "0x182A7A7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static IBAFENGCGOE HOEJKHDAMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AA50", Offset = "0x2A79C50", VA = "0x182A7AA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B660", Offset = "0x2A7A860", VA = "0x182A7B660")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool KOJEFNHPNGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AB70", Offset = "0x2A79D70", VA = "0x182A7AB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static JHLNNPKIFCO BELPKEBIKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AF50", Offset = "0x2A7A150", VA = "0x182A7AF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BF30", Offset = "0x2A7B130", VA = "0x182A7BF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static CGLADJHJCEM BNAKAEDMIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BD90", Offset = "0x2A7AF90", VA = "0x182A7BD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static BDFDGLPPMOH FGOFHGLAPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B8E0", Offset = "0x2A7AAE0", VA = "0x182A7B8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NPFNHEGAPFJ APIPCEEBONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A500", Offset = "0x2A79700", VA = "0x182A7A500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static DJCLCEOJBJF NCKPBBOBINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BCB0", Offset = "0x2A7AEB0", VA = "0x182A7BCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool FOPMPJMIIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BA80", Offset = "0x2A7AC80", VA = "0x182A7BA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool EGBFMNHLJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A3D0", Offset = "0x2A795D0", VA = "0x182A7A3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool KJELGKIPPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AFF0", Offset = "0x2A7A1F0", VA = "0x182A7AFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool JODKOEPKNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B300", Offset = "0x2A7A500", VA = "0x182A7B300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A9F0", Offset = "0x2A79BF0", VA = "0x182A7A9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OPJEHBLJCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BD30", Offset = "0x2A7AF30", VA = "0x182A7BD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B880", Offset = "0x2A7AA80", VA = "0x182A7B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JDAOGMBMFNA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7ACD0", Offset = "0x2A79ED0", VA = "0x182A7ACD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A6D0", Offset = "0x2A798D0", VA = "0x182A7A6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B490", Offset = "0x2A7A690", VA = "0x182A7B490")]
		public static NFJEDPPAJMK HELPAPLNDJP(GameObject OOKBNBHDPPG)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A990", Offset = "0x2A79B90", VA = "0x182A7A990")]
		public static bool EDKHLDNKOGL(ByteString EJAHCFFDNJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B960", Offset = "0x2A7AB60", VA = "0x182A7B960")]
		public static JMAKJOJHHNF IMCAMNOPOMH(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BB60", Offset = "0x2A7AD60", VA = "0x182A7BB60")]
		public static (ByteString, IDisposable) LMGAKHPBOLH()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A580", Offset = "0x2A79780", VA = "0x182A7A580")]
		public static (ByteString, IDisposable) BKBMLMOHLGK(IEnumerable<NFJEDPPAJMK> LMPNJECPIDC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B360", Offset = "0x2A7A560", VA = "0x182A7B360")]
		public static bool GFONIKEOCKE(GameObject OOKBNBHDPPG, out IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BE10", Offset = "0x2A7B010", VA = "0x182A7BE10")]
		public static bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B580", Offset = "0x2A7A780", VA = "0x182A7B580")]
		public static void HGJPOICCAII(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A7ADD0", Offset = "0x2A79FD0", VA = "0x182A7ADD0")]
		public static Task FCOPPLBIOGF(bool LNJLGDKOFHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A8B0", Offset = "0x2A79AB0", VA = "0x182A7A8B0")]
		private static IBAFENGCGOE CKHHJAEFOHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B1E0", Offset = "0x2A7A3E0", VA = "0x182A7B1E0")]
		private static bool FKKCPLCFAOH()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MBALNPKLAGP(FOFKCKDBIPD.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A80D50", Offset = "0x2A7FF50", VA = "0x182A80D50")]
		public static bool LEOEHHMPOIB(MIDGCDECPDI IPNBFMDFCBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A80B20", Offset = "0x2A7FD20", VA = "0x182A80B20")]
		public static MIDGCDECPDI KJDPCLCGNLB(GameObject OOKBNBHDPPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A80920", Offset = "0x2A7FB20", VA = "0x182A80920")]
		public static MIDGCDECPDI KJDPCLCGNLB(GameObject OOKBNBHDPPG, IOLFAAOECPP IOCKLNNJMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A80820", Offset = "0x2A7FA20", VA = "0x182A80820")]
		public static bool HONJBMHLIAN(GameObject GODCAKDBDMK, string FMCEKOCABPG, bool HMIAGGLBLKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A80530", Offset = "0x2A7F730", VA = "0x182A80530")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void AEIHPKIBBDP(GameObject GODCAKDBDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2A80730", Offset = "0x2A7F930", VA = "0x182A80730")]
		[CompilerGenerated]
		internal static string GOPLDHJNDAH((GameObject go, string prefabName) FKNKEJLLBEP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, LIMMFBCPGFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NFJEDPPAJMK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x23504F0", Offset = "0x234F6F0", VA = "0x1823504F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[MBALNPKLAGP(FOFKCKDBIPD.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, MIDGCDECPDI, LIMMFBCPGFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string KKPJODHMKIF = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IKFLBBFLGHA BGHMFEPCABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NFJEDPPAJMK ONBAMHPEIDG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x319DCF0", Offset = "0x319CEF0", VA = "0x18319DCF0", Slot = "15")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public JMAKJOJHHNF MAEACMMEJHE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x319DDA0", Offset = "0x319CFA0", VA = "0x18319DDA0", Slot = "6")]
			get
			{
				return default(JMAKJOJHHNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x319DCE0", Offset = "0x319CEE0", VA = "0x18319DCE0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IKFLBBFLGHA BFKMFKKIINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9A1590", Offset = "0x9A0790", VA = "0x1809A1590", Slot = "7")]
			get
			{
				return default(IKFLBBFLGHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x319DA70", Offset = "0x319CC70", VA = "0x18319DA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private DFPNHPPNFLJ GNPLMALODDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x319CFC0", Offset = "0x319C1C0", VA = "0x18319CFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool NNDDENBBBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x781170", Offset = "0x780370", VA = "0x180781170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> MAAMINLJGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x319DBA0", Offset = "0x319CDA0", VA = "0x18319DBA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x319DDD0", Offset = "0x319CFD0", VA = "0x18319DDD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<MIDGCDECPDI> BCGMGNAPMHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x319DC40", Offset = "0x319CE40", VA = "0x18319DC40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x319DE70", Offset = "0x319D070", VA = "0x18319DE70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x319D020", Offset = "0x319C220", VA = "0x18319D020")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x319D790", Offset = "0x319C990", VA = "0x18319D790", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x319D440", Offset = "0x319C640", VA = "0x18319D440", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x319D700", Offset = "0x319C900", VA = "0x18319D700", Slot = "10")]
		public void OnEmbody(CPEFIMBHABA OACNPKMLCHI, NFJEDPPAJMK ONBAMHPEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x319D780", Offset = "0x319C980", VA = "0x18319D780", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x319D4F0", Offset = "0x319C6F0", VA = "0x18319D4F0", Slot = "12")]
		public void OnDisembody(bool CIJGBBABFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x319D8E0", Offset = "0x319CAE0", VA = "0x18319D8E0")]
		private void PFOMFMINDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x319D9E0", Offset = "0x319CBE0", VA = "0x18319D9E0")]
		private void PHIGHDGGMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x319D260", Offset = "0x319C460", VA = "0x18319D260")]
		private void ONDFMJFBIEL(bool AFEBCJCKFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x319D200", Offset = "0x319C400", VA = "0x18319D200", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x10DB450", Offset = "0x10DA650", VA = "0x1810DB450", Slot = "9")]
		private GameObject PNEHDCPLPKJ()
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
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[MBALNPKLAGP(FOFKCKDBIPD.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MFOBNBKALPH PMBFHMDCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C0E0", Offset = "0x2A8B2E0", VA = "0x182A8C0E0", Slot = "6")]
			get
			{
				return default(MFOBNBKALPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C080", Offset = "0x2A8B280", VA = "0x182A8C080")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[MBALNPKLAGP(FOFKCKDBIPD.Registration)]
	public class TransformEntity : MonoBehaviour, LIMMFBCPGFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private MFOBNBKALPH prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NFJEDPPAJMK OOGHONKGHEE;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual MFOBNBKALPH PMBFHMDCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0", Slot = "6")]
			get
			{
				return default(MFOBNBKALPH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A610", VA = "0x18076B410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xBF8CA0", Offset = "0xBF7EA0", VA = "0x180BF8CA0", Slot = "5")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7030", Offset = "0x6C6230", VA = "0x1806C7030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA318D0", Offset = "0xA30AD0", VA = "0x180A318D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity COBGFIFKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal NPFNHEGAPFJ APIPCEEBONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal DFPNHPPNFLJ JHLNDBLKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2CC35D0", Offset = "0x2CC27D0", VA = "0x182CC35D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3120", Offset = "0x2CC2320", VA = "0x182CC3120")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CC34E0", Offset = "0x2CC26E0", VA = "0x182CC34E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3130", Offset = "0x2CC2330", VA = "0x182CC3130")]
		internal void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3440", Offset = "0x2CC2640", VA = "0x182CC3440")]
		private bool FJENGNJIPGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3640", Offset = "0x2CC2840", VA = "0x182CC3640")]
		private void OLFHCOGKOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CC34E0", Offset = "0x2CC26E0", VA = "0x182CC34E0")]
		internal void FLEJEMANDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3670", Offset = "0x2CC2870", VA = "0x182CC3670")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3750", Offset = "0x2CC2950", VA = "0x182CC3750")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DENLLMODGFC(typeof(AKKPACBLFCH))]
[LOJIIDJFKAI(typeof(IBAFENGCGOE), new string[] { })]
public class IIDNIPDKBKG : IBAFENGCGOE, COEMEMEDCFH, AKKPACBLFCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MMAHKENHAHO KOKEGENGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GPJINHAGDJN HOCPKHHLENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NILGHIEKGGJ BCIFAEHMMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KHJGFAKJFCE BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MMGILMAMAJD NDEGGHNDKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MMAHKENHAHO BELPKEBIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public GAOMEBKFAAA DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GPJINHAGDJN NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KHJGFAKJFCE LHBKKNBFPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MMGILMAMAJD JEJLEAHPDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x879B50", Offset = "0x878D50", VA = "0x180879B50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x31AD750", Offset = "0x31AC950", VA = "0x1831AD750", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9340C0", Offset = "0x9332C0", VA = "0x1809340C0", Slot = "10")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x31AD4B0", Offset = "0x31AC6B0", VA = "0x1831AD4B0")]
	public static IIDNIPDKBKG BFPHDDBHNEE(MMAHKENHAHO KOKEGENGCAH, AKHLGKPGKGF NOECNPHPBKJ = AKHLGKPGKGF.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void APLFDHADJCE(MMAHKENHAHO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void DFBCEBNGGJC(MMAHKENHAHO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31AD600", Offset = "0x31AC800", VA = "0x1831AD600", Slot = "11")]
	public void JKLOGDJOLHP(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F58E90", Offset = "0x2F58090", VA = "0x182F58E90")]
	private void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x31AD760", Offset = "0x31AC960", VA = "0x1831AD760")]
	private void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31AD5A0", Offset = "0x31AC7A0", VA = "0x1831AD5A0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IIDNIPDKBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MHHIICPONFE
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A70100", Offset = "0x2A6F300", VA = "0x182A70100")]
	public static JMAKJOJHHNF AIPMEHKGCLA(this IBAFENGCGOE CCPHBLENGBG, IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
	{
		return default(JMAKJOJHHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A70420", Offset = "0x2A6F620", VA = "0x182A70420")]
	public static KAINPBJGIFE IEIDJDJHKHA(this IBAFENGCGOE CCPHBLENGBG)
	{
		return default(KAINPBJGIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A70370", Offset = "0x2A6F570", VA = "0x182A70370")]
	public static NFJEDPPAJMK HELPAPLNDJP(this IBAFENGCGOE CCPHBLENGBG, Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A70240", Offset = "0x2A6F440", VA = "0x182A70240")]
	public static NFJEDPPAJMK HELPAPLNDJP(this IBAFENGCGOE CCPHBLENGBG, IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A70540", Offset = "0x2A6F740", VA = "0x182A70540")]
	public static IOLFAAOECPP LPAPEMKKHGI(this IBAFENGCGOE CCPHBLENGBG, NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(IOLFAAOECPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum AKHLGKPGKGF
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
[LOJIIDJFKAI(typeof(MMGILMAMAJD), new string[] { })]
public class EOLGGOLJKJP : MMGILMAMAJD, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[IMNMHIBEIDL]
	private AKKPACBLFCH ONMGKKCFHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MMAHKENHAHO KOKEGENGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BDAJNAKKLOI BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NILGHIEKGGJ BCIFAEHMMMD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KCGLGHDKOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x319C530", Offset = "0x319B730", VA = "0x18319C530", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x319C6A0", Offset = "0x319B8A0", VA = "0x18319C6A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x319C740", Offset = "0x319B940", VA = "0x18319C740", Slot = "16")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x319C490", Offset = "0x319B690", VA = "0x18319C490", Slot = "13")]
	public void EIPMHIGFPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "6")]
	public void IHOPJKJHOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x319C5D0", Offset = "0x319B7D0", VA = "0x18319C5D0", Slot = "7")]
	public void JGFPDJGKMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x319C620", Offset = "0x319B820", VA = "0x18319C620", Slot = "8")]
	public void JHOMBPAMHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1CC68A0", Offset = "0x1CC5AA0", VA = "0x181CC68A0", Slot = "9")]
	public void EHCPOBIJCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x319C370", Offset = "0x319B570", VA = "0x18319C370", Slot = "10")]
	public void AAHEOHMMMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x319C7F0", Offset = "0x319B9F0", VA = "0x18319C7F0", Slot = "11")]
	public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x319C440", Offset = "0x319B640", VA = "0x18319C440", Slot = "12")]
	public void COMMHLEBCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x319C3F0", Offset = "0x319B5F0", VA = "0x18319C3F0", Slot = "14")]
	public void CCKCOKOBDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x319C4D0", Offset = "0x319B6D0", VA = "0x18319C4D0", Slot = "15")]
	public void FPEJLEMDNNG(bool LKAGAODJCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x319C3C0", Offset = "0x319B5C0", VA = "0x18319C3C0")]
	private void AKJDIGODPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EOLGGOLJKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[LOJIIDJFKAI(typeof(KHJGFAKJFCE), new string[] { })]
public class IIMKKPKHHGA : KHJGFAKJFCE, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[IMNMHIBEIDL]
	private AKKPACBLFCH ONMGKKCFHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private MMAHKENHAHO KOKEGENGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BDAJNAKKLOI BDFANKEHIJK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x31ADA30", Offset = "0x31ACC30", VA = "0x1831ADA30", Slot = "6")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x31AD850", Offset = "0x31ACA50", VA = "0x1831AD850", Slot = "4")]
	public ByteString LMGAKHPBOLH(out IDisposable BIGKFLCOHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x31AD910", Offset = "0x31ACB10", VA = "0x1831AD910", Slot = "5")]
	public void LPJEJNEGJFP(ByteString ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IIMKKPKHHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class GEAJGNGECAJ<T> : global::APDLBOGPEAC<T>, global::MALNIJMODCH<IOLFAAOECPP, T>, global::CCJKFKABKGC<IOLFAAOECPP>, ANOLFBPNBLO, IDisposable, ICAMIIGEPFO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::CCJKFKABKGC<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate GNABHCENNFC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB640", Offset = "0x2BBA840", VA = "0x182BBB640", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2BB82E0", Offset = "0x2BB74E0", VA = "0x182BB82E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CNAIHAMIBKF PJJGDKDHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BB97B0", Offset = "0x2BB89B0", VA = "0x182BB97B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int POKDJMJKNLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2610", Offset = "0x2BB1810", VA = "0x182BB2610", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PNEGJGPDCOE CEHDHBHCGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAD00", Offset = "0x2BB9F00", VA = "0x182BBAD00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x239EB00", Offset = "0x239DD00", VA = "0x18239EB00", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5370", Offset = "0x2BB4570", VA = "0x182BB5370", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MIFAEDKDHPB<IOLFAAOECPP> JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4B70", Offset = "0x2BB3D70", VA = "0x182BB4B70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2970", Offset = "0x2BB1B70", VA = "0x182BB2970", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBAF0", Offset = "0x2BBACF0", VA = "0x182BBBAF0")]
	public GEAJGNGECAJ(global::CCJKFKABKGC<Entity> LKAENGEIFGG, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5090", Offset = "0x2BB4290", VA = "0x182BB5090")]
	private Entity FFPKNNKHNKN(IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4EE0", Offset = "0x2BB40E0", VA = "0x182BB4EE0")]
	private IOLFAAOECPP FFPKNNKHNKN(Entity OAOGLFGGBPI)
	{
		return default(IOLFAAOECPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB90B0", Offset = "0x2BB82B0", VA = "0x182BB90B0", Slot = "4")]
	public T JLPNHBINJFC(IOLFAAOECPP IOCKLNNJMIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5550", Offset = "0x2BB4750", VA = "0x182BB5550")]
	public bool HDECKBNAIGA(IOLFAAOECPP IOCKLNNJMIA, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6880", Offset = "0x2BB5A80", VA = "0x182BB6880")]
	public bool IEIBIDGHFGB(IOLFAAOECPP IOCKLNNJMIA, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4930", Offset = "0x2BB3B30", VA = "0x182BB4930", Slot = "9")]
	public bool EOKNMHALCBJ(IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6160", Offset = "0x2BB5360", VA = "0x182BB6160", Slot = "26")]
	public object ICCPIPABPLI(IOLFAAOECPP IOCKLNNJMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA4F0", Offset = "0x2BB96F0", VA = "0x182BBA4F0")]
	public bool NHPJKNLHJCD(IOLFAAOECPP IOCKLNNJMIA, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8D40", Offset = "0x2BB7F40", VA = "0x182BB8D40")]
	public void JLPNHBINJFC(IOLFAAOECPP IOCKLNNJMIA, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB58A0", Offset = "0x2BB4AA0", VA = "0x182BB58A0")]
	public bool HDECKBNAIGA(IOLFAAOECPP IOCKLNNJMIA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6440", Offset = "0x2BB5640", VA = "0x182BB6440")]
	public bool IEIBIDGHFGB(IOLFAAOECPP IOCKLNNJMIA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAEC0", Offset = "0x2BBA0C0", VA = "0x182BBAEC0", Slot = "22")]
	public void OKJGILDOJEJ(FNFKCLIHOKN CFPEBKLBEPN, [Optional] object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAEF0", Offset = "0x2BBA0F0", VA = "0x182BBAEF0", Slot = "15")]
	public void OKJGILDOJEJ(IOLFAAOECPP EBOEHIFNNLM, JLMGPHFMAFP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9450", Offset = "0x2BB8650", VA = "0x182BB9450", Slot = "14")]
	public bool JPMCEPOCADG(IOLFAAOECPP HCHNJGMBMMC, IOLFAAOECPP NKOMPJIJHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE19C0", Offset = "0x1CE0BC0", VA = "0x181CE19C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBA50", Offset = "0x2BBAC50", VA = "0x182BBBA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3600", Offset = "0x2BB2800", VA = "0x182BB3600")]
	public string ENCCFGOODIM(in LONBCMOJAJF NMKPBPLEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA0C0", Offset = "0x2BB92C0", VA = "0x182BBA0C0")]
	private void MMHDEHEFJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB30E0", Offset = "0x2BB22E0", VA = "0x182BB30E0")]
	private void EMLKDKHPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB70A0", Offset = "0x2BB62A0", VA = "0x182BB70A0")]
	private void IHBFKBPOCBC(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5E80", Offset = "0x2BB5080", VA = "0x182BB5E80")]
	private void HNMIGAEDJEO(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3AE0", Offset = "0x2BB2CE0", VA = "0x182BB3AE0")]
	[Conditional("DEBUG_BUILD")]
	private static void EOAAFIJMIEI(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA, string CGCMEEFENJL, string PMNLFCAAAOI, [CallerMemberName] string KIKOLEGOJKD = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2545610", Offset = "0x2544810", VA = "0x182545610", Slot = "5")]
	private bool ENADCOIHDLE(IOLFAAOECPP EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2A20", Offset = "0x2BB1C20", VA = "0x182BB2A20", Slot = "6")]
	private bool BOLHFKGPLCA(IOLFAAOECPP EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1F73F90", Offset = "0x1F73190", VA = "0x181F73F90", Slot = "10")]
	private bool EDFEBLPAGKN(IOLFAAOECPP EBOEHIFNNLM, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2A50", Offset = "0x2BB1C50", VA = "0x182BB2A50", Slot = "11")]
	private void CFDJKOIKBIN(IOLFAAOECPP EBOEHIFNNLM, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAE90", Offset = "0x2BBA090", VA = "0x182BBAE90", Slot = "12")]
	private bool OAIBGBJIAFM(IOLFAAOECPP EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2BB95F0", Offset = "0x2BB87F0", VA = "0x182BB95F0", Slot = "13")]
	private bool KJPBGFHLDFN(IOLFAAOECPP EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC930", Offset = "0x2BABB30", VA = "0x182BAC930", Slot = "16")]
	private string FDCLPGLDNGF(in LONBCMOJAJF JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class EALCHGCDDPJ<T> : global::HKEMDJIFJBH<T>, global::MALNIJMODCH<NFJEDPPAJMK, T>, global::CCJKFKABKGC<NFJEDPPAJMK>, ANOLFBPNBLO, IDisposable, FNOOJMKBHOH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::CCJKFKABKGC<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate GNABHCENNFC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3D97810", Offset = "0x3D96A10", VA = "0x183D97810", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F3F0", Offset = "0x3D8E5F0", VA = "0x183D8F3F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CNAIHAMIBKF PJJGDKDHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3D92A00", Offset = "0x3D91C00", VA = "0x183D92A00", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int POKDJMJKNLC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D84860", Offset = "0x3D83A60", VA = "0x183D84860", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PNEGJGPDCOE CEHDHBHCGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D96220", Offset = "0x3D95420", VA = "0x183D96220", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D92720", Offset = "0x3D91920", VA = "0x183D92720", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3D87DD0", Offset = "0x3D86FD0", VA = "0x183D87DD0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MIFAEDKDHPB<NFJEDPPAJMK> JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D87820", Offset = "0x3D86A20", VA = "0x183D87820", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D84E20", Offset = "0x3D84020", VA = "0x183D84E20", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBAF0", Offset = "0x2BBACF0", VA = "0x182BBBAF0")]
	public EALCHGCDDPJ(global::CCJKFKABKGC<Entity> LKAENGEIFGG, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1DA75B0", Offset = "0x1DA67B0", VA = "0x181DA75B0")]
	private Entity FFPKNNKHNKN(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D87DA0", Offset = "0x3D86FA0", VA = "0x183D87DA0")]
	private NFJEDPPAJMK FFPKNNKHNKN(Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FCE0", Offset = "0x3D8EEE0", VA = "0x183D8FCE0", Slot = "4")]
	public T JLPNHBINJFC(NFJEDPPAJMK OOGHONKGHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3D88C90", Offset = "0x3D87E90", VA = "0x183D88C90")]
	public bool HDECKBNAIGA(NFJEDPPAJMK OOGHONKGHEE, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B280", Offset = "0x3D8A480", VA = "0x183D8B280")]
	public bool IEIBIDGHFGB(NFJEDPPAJMK OOGHONKGHEE, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3D87200", Offset = "0x3D86400", VA = "0x183D87200", Slot = "9")]
	public bool EOKNMHALCBJ(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A230", Offset = "0x3D89430", VA = "0x183D8A230", Slot = "26")]
	public object ICCPIPABPLI(NFJEDPPAJMK OOGHONKGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3D956B0", Offset = "0x3D948B0", VA = "0x183D956B0")]
	public bool NHPJKNLHJCD(NFJEDPPAJMK OOGHONKGHEE, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FFE0", Offset = "0x3D8F1E0", VA = "0x183D8FFE0")]
	public void JLPNHBINJFC(NFJEDPPAJMK OOGHONKGHEE, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3D88270", Offset = "0x3D87470", VA = "0x183D88270")]
	public bool HDECKBNAIGA(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A4B0", Offset = "0x3D896B0", VA = "0x183D8A4B0")]
	public bool IEIBIDGHFGB(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAEC0", Offset = "0x2BBA0C0", VA = "0x182BBAEC0", Slot = "22")]
	public void OKJGILDOJEJ(FNFKCLIHOKN CFPEBKLBEPN, [Optional] object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3D96900", Offset = "0x3D95B00", VA = "0x183D96900", Slot = "15")]
	public void OKJGILDOJEJ(NFJEDPPAJMK EBOEHIFNNLM, JLMGPHFMAFP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D921B0", Offset = "0x3D913B0", VA = "0x183D921B0", Slot = "14")]
	public bool JPMCEPOCADG(NFJEDPPAJMK HCHNJGMBMMC, NFJEDPPAJMK NKOMPJIJHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3D93AE0", Offset = "0x3D92CE0", VA = "0x183D93AE0")]
	private void MMHDEHEFJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D86740", Offset = "0x3D85940", VA = "0x183D86740")]
	private void EMLKDKHPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D870", Offset = "0x3D8CA70", VA = "0x183D8D870")]
	private void IHBFKBPOCBC(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3D89E90", Offset = "0x3D89090", VA = "0x183D89E90")]
	private void HNMIGAEDJEO(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3D851D0", Offset = "0x3D843D0", VA = "0x183D851D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3D97CC0", Offset = "0x3D96EC0", VA = "0x183D97CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3600", Offset = "0x2BB2800", VA = "0x182BB3600")]
	public string ENCCFGOODIM(in LONBCMOJAJF NMKPBPLEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3D85190", Offset = "0x3D84390", VA = "0x183D85190", Slot = "5")]
	private bool BNCJIBGCFPA(NFJEDPPAJMK EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3D87520", Offset = "0x3D86720", VA = "0x183D87520", Slot = "6")]
	private bool FAIIIJNKLLH(NFJEDPPAJMK EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1F73FC0", Offset = "0x1F731C0", VA = "0x181F73FC0", Slot = "10")]
	private bool DILKOLHDACO(NFJEDPPAJMK EBOEHIFNNLM, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3D898D0", Offset = "0x3D88AD0", VA = "0x183D898D0", Slot = "11")]
	private void HKJFKHHGMAJ(NFJEDPPAJMK EBOEHIFNNLM, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3D92680", Offset = "0x3D91880", VA = "0x183D92680", Slot = "12")]
	private bool KENHJDNNIOJ(NFJEDPPAJMK EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3D945D0", Offset = "0x3D937D0", VA = "0x183D945D0", Slot = "13")]
	private bool NEFGIHCCHPH(NFJEDPPAJMK EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC930", Offset = "0x2BABB30", VA = "0x182BAC930", Slot = "16")]
	private string JMIFCPCNGDH(in LONBCMOJAJF JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HKGKEPCIADL : IDisposable, MHOEABJDIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> MNAJFGJDBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public HKGKEPCIADL(NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x31A7BF0", Offset = "0x31A6DF0", VA = "0x1831A7BF0", Slot = "6")]
	public NFJEDPPAJMK IFPCEMLDIEH(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x31A7CE0", Offset = "0x31A6EE0", VA = "0x1831A7CE0", Slot = "7")]
	public Entity IFPCEMLDIEH(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x31A7C40", Offset = "0x31A6E40", VA = "0x1831A7C40", Slot = "8")]
	public IEnumerable<NFJEDPPAJMK> IFPCEMLDIEH(IEnumerable<NFJEDPPAJMK> LMPNJECPIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x31A7B90", Offset = "0x31A6D90", VA = "0x1831A7B90", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly FADHLPPNOEF GCIMKBKOFEO;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int FAFKHKCDNNF;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static MHOEABJDIBA CEEHHEDBOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool CENOJKDODOD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> MNAJFGJDBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2CBB770", Offset = "0x2CBA970", VA = "0x182CBB770")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2CBBC80", Offset = "0x2CBAE80", VA = "0x182CBBC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBC20", Offset = "0x2CBAE20", VA = "0x182CBBC20")]
		public static SerializationRemapScope JJNMIIPPGJM()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBDA0", Offset = "0x2CBAFA0", VA = "0x182CBBDA0")]
		public SerializationRemapScope(MHOEABJDIBA KCEJCOIFNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB880", Offset = "0x2CBAA80", VA = "0x182CBB880", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB990", Offset = "0x2CBAB90", VA = "0x182CBB990")]
		public static NFJEDPPAJMK IFPCEMLDIEH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBAF0", Offset = "0x2CBACF0", VA = "0x182CBBAF0")]
		public static Entity IFPCEMLDIEH(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LOJIIDJFKAI(typeof(KNNAFEJKLMH), new string[] { "Editor" })]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public sealed class KNNAFEJKLMH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void EOPDEAPMNJC(IOLFAAOECPP PBICEPMHFMD, FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void GAMNMHPBKEG(IOLFAAOECPP PBICEPMHFMD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void LAICEEEJEAP(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EOPDEAPMNJC BINAKMDNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x31B6790", Offset = "0x31B5990", VA = "0x1831B6790")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x31B6400", Offset = "0x31B5600", VA = "0x1831B6400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GAMNMHPBKEG GABIINCCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x31B6590", Offset = "0x31B5790", VA = "0x1831B6590")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x31B6650", Offset = "0x31B5850", VA = "0x1831B6650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event LAICEEEJEAP EAGODJINNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x31B64F0", Offset = "0x31B56F0", VA = "0x1831B64F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x31B66F0", Offset = "0x31B58F0", VA = "0x1831B66F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x31B6630", Offset = "0x31B5830", VA = "0x1831B6630")]
	[Conditional("UNITY_EDITOR")]
	public void HKECMHKPKCN(IOLFAAOECPP PBICEPMHFMD, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x31B64A0", Offset = "0x31B56A0", VA = "0x1831B64A0")]
	[Conditional("UNITY_EDITOR")]
	public void AJMBANJFKHK(IOLFAAOECPP PBICEPMHFMD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x31B64C0", Offset = "0x31B56C0", VA = "0x1831B64C0")]
	[Conditional("UNITY_EDITOR")]
	public void DBCEICDGIHA(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KNNAFEJKLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LOJIIDJFKAI(typeof(FNCOHMIDMDB), new string[] { "Editor" })]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public sealed class FNCOHMIDMDB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void IEEKOMLFLMP(IOLFAAOECPP IOCKLNNJMIA, FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void IJGHGKBHAGO(IOLFAAOECPP IOCKLNNJMIA, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void EDHGLGPANDG(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM, bool LFHBBHMKFBM);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void AAIDNIEOCFA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void JFMMHAJFIDD(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> KMIIFHKKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x31A58B0", Offset = "0x31A4AB0", VA = "0x1831A58B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x31A4E60", Offset = "0x31A4060", VA = "0x1831A4E60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> MFGNHIKBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x31A5590", Offset = "0x31A4790", VA = "0x1831A5590")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x31A5060", Offset = "0x31A4260", VA = "0x1831A5060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event IEEKOMLFLMP BINAKMDNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x31A54F0", Offset = "0x31A46F0", VA = "0x1831A54F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x31A4C10", Offset = "0x31A3E10", VA = "0x1831A4C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IJGHGKBHAGO GABIINCCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x31A51F0", Offset = "0x31A43F0", VA = "0x1831A51F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x31A5330", Offset = "0x31A4530", VA = "0x1831A5330")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event IEEKOMLFLMP HNODKEEEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x31A5A00", Offset = "0x31A4C00", VA = "0x1831A5A00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x31A4F20", Offset = "0x31A4120", VA = "0x1831A4F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event IJGHGKBHAGO JCLGHNCGACG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x31A56F0", Offset = "0x31A48F0", VA = "0x1831A56F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x31A4FC0", Offset = "0x31A41C0", VA = "0x1831A4FC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EDHGLGPANDG EAGODJINNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x31A4DC0", Offset = "0x31A3FC0", VA = "0x1831A4DC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x31A5400", Offset = "0x31A4600", VA = "0x1831A5400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event AAIDNIEOCFA BGKGAFNMNND
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x31A5290", Offset = "0x31A4490", VA = "0x1831A5290")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x31A5150", Offset = "0x31A4350", VA = "0x1831A5150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> DKPOCHBKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x31A4D20", Offset = "0x31A3F20", VA = "0x1831A4D20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x31A5AD0", Offset = "0x31A4CD0", VA = "0x1831A5AD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event JFMMHAJFIDD NHNJBLLHFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x31A57F0", Offset = "0x31A49F0", VA = "0x1831A57F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x31A5650", Offset = "0x31A4850", VA = "0x1831A5650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x31A5120", Offset = "0x31A4320", VA = "0x1831A5120")]
	[Conditional("UNITY_EDITOR")]
	public void GOJEACAHJIJ(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x31A54D0", Offset = "0x31A46D0", VA = "0x1831A54D0")]
	[Conditional("UNITY_EDITOR")]
	public void JIOGADHJHMG(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x31A54A0", Offset = "0x31A46A0", VA = "0x1831A54A0")]
	[Conditional("UNITY_EDITOR")]
	public void IKAECEOPBLE(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x31A5890", Offset = "0x31A4A90", VA = "0x1831A5890")]
	[Conditional("UNITY_EDITOR")]
	public void LHEIPDGNBLD(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x31A53D0", Offset = "0x31A45D0", VA = "0x1831A53D0")]
	[Conditional("UNITY_EDITOR")]
	public void ICGAADLGBNN(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool LFHBBHMKFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x31A5970", Offset = "0x31A4B70", VA = "0x1831A5970")]
	[Conditional("UNITY_EDITOR")]
	public void NDNBMJPDPDF(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x31A5790", Offset = "0x31A4990", VA = "0x1831A5790")]
	[Conditional("UNITY_EDITOR")]
	public void KONCDHPAELG(string IGHJIHNAPBA, object KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x31A5AA0", Offset = "0x31A4CA0", VA = "0x1831A5AA0")]
	[Conditional("UNITY_EDITOR")]
	public void OLDKFHFNEIH(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x31A5990", Offset = "0x31A4B90", VA = "0x1831A5990")]
	[Conditional("UNITY_EDITOR")]
	public void OCGOKAPCPFD(World OACNPKMLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x31A4CB0", Offset = "0x31A3EB0", VA = "0x1831A4CB0")]
	[Conditional("UNITY_EDITOR")]
	public void BJDPAGPEHMB(World OACNPKMLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FNCOHMIDMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[LOJIIDJFKAI(typeof(IENNIKCNIJD), new string[] { })]
public class NGENOGJCGIP : IENNIKCNIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2A73910", Offset = "0x2A72B10", VA = "0x182A73910", Slot = "5")]
	public void MFMDHPGAJCA(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2A73700", Offset = "0x2A72900", VA = "0x182A73700", Slot = "6")]
	public void CCGCJHHLGNP(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2A73A00", Offset = "0x2A72C00", VA = "0x182A73A00", Slot = "7")]
	public void OGIEKGHKJMI(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2A737F0", Offset = "0x2A729F0", VA = "0x182A737F0", Slot = "4")]
	public IDisposable LGPGEDLNOFB(object DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NGENOGJCGIP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[LOJIIDJFKAI(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal class BulkInstantiateSceneObjectService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string LALGPMCNOEH = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[IMNMHIBEIDL]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery NAEFNFIFMEP;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2C45D40", Offset = "0x2C44F40", VA = "0x182C45D40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2C47320", Offset = "0x2C46520", VA = "0x182C47320", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2C45910", Offset = "0x2C44B10", VA = "0x182C45910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2C474A0", Offset = "0x2C466A0", VA = "0x182C474A0")]
		public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> OGFKJCKDCGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2C47210", Offset = "0x2C46410", VA = "0x182C47210")]
		public static bool OOEKCMLNKAO(CKLPCIIPNON EFADACBHMKC, out IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2C45920", Offset = "0x2C44B20", VA = "0x182C45920")]
		private void EGNAPEHGOPD(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IEnumerable<CKLPCIIPNON> OGFKJCKDCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2C45D90", Offset = "0x2C44F90", VA = "0x182C45D90")]
		private void JFCNMFDPMFI(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2C45FC0", Offset = "0x2C451C0", VA = "0x182C45FC0")]
		private void LJOFPIMLCIO(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IOLFAAOECPP IOCKLNNJMIA, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2C46EB0", Offset = "0x2C460B0", VA = "0x182C46EB0")]
		private void NLGLAFENJKG(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2C46610", Offset = "0x2C45810", VA = "0x182C46610")]
		private void MNOMJIKJMHJ(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, List<CKLPCIIPNON> GNFHDKNMNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2C46440", Offset = "0x2C45640", VA = "0x182C46440")]
		private NativeList<IOLFAAOECPP> MNOLIEGGFBN(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
			return default(NativeList<IOLFAAOECPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2C47620", Offset = "0x2C46820", VA = "0x182C47620")]
		private NativeArray<Entity> PNKGPJGCNGL(NativeList<IOLFAAOECPP> BENIOJBNGJE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2C45CA0", Offset = "0x2C44EA0", VA = "0x182C45CA0")]
		private static void FLBAHFMCKLI(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IOLFAAOECPP IOCKLNNJMIA, CKLPCIIPNON EFADACBHMKC, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
	[LOJIIDJFKAI(typeof(DebugWorldsService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool KNFCGHKCAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2C59030", Offset = "0x2C58230", VA = "0x182C59030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2C58FB0", Offset = "0x2C581B0", VA = "0x182C58FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool FDHKFPBCFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2C58F70", Offset = "0x2C58170", VA = "0x182C58F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2C58FF0", Offset = "0x2C581F0", VA = "0x182C58FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public void LHJBILOKHME(string IGHJIHNAPBA, EntityManager KNABDDPENKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public static void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
[LOJIIDJFKAI(typeof(NILGHIEKGGJ), new string[] { })]
internal class NILGHIEKGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB250", Offset = "0x6CA450", VA = "0x1806CB250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB270", Offset = "0x6CA470", VA = "0x1806CB270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool EMOMJDOBJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E7E70", Offset = "0x7E7070", VA = "0x1807E7E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E7E80", Offset = "0x7E7080", VA = "0x1807E7E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NILGHIEKGGJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DENLLMODGFC(typeof(SerializationService))]
	[LOJIIDJFKAI(typeof(BDAJNAKKLOI), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal class SerializationService : BDAJNAKKLOI, IDisposable, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly FADHLPPNOEF CEDIHMKBBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[IMNMHIBEIDL]
		private BANIDHAOEAM IPILJEFIHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[IMNMHIBEIDL]
		private NILGHIEKGGJ BCIFAEHMMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GKBBEKJICJK POAFAEBNFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private OKNJKHAMLJO DDDCPHLJCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope BIGKFLCOHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? OMIDNCCFOLO;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HCGGEANBBJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2CBC5E0", Offset = "0x2CBB7E0", VA = "0x182CBC5E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2CBD0B0", Offset = "0x2CBC2B0", VA = "0x182CBD0B0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool OMMOFMDIGDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x76ACE0", Offset = "0x769EE0", VA = "0x18076ACE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x76B490", Offset = "0x76A690", VA = "0x18076B490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public OKNJKHAMLJO HLMDNBNAKJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CBDA80", Offset = "0x2CBCC80", VA = "0x182CBDA80", Slot = "16")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC870", Offset = "0x2CBBA70", VA = "0x182CBC870", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC880", Offset = "0x2CBBA80", VA = "0x182CBC880")]
		public static bool EDKHLDNKOGL(ByteString EJAHCFFDNJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7091C0", Offset = "0x7083C0", VA = "0x1807091C0")]
		public void OEOEMELPEEH(GKBBEKJICJK MNPBGJJKLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCA10", Offset = "0x2CBBC10", VA = "0x182CBCA10", Slot = "5")]
		public void FICEOIDDKMB(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD020", Offset = "0x2CBC220", VA = "0x182CBD020", Slot = "6")]
		public Task INECHLNGNHD(bool LNJLGDKOFHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD290", Offset = "0x2CBC490", VA = "0x182CBD290", Slot = "7")]
		public ByteString LMGAKHPBOLH(out IDisposable BIGKFLCOHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD370", Offset = "0x2CBC570", VA = "0x182CBD370", Slot = "19")]
		public ByteString LMGAKHPBOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD550", Offset = "0x2CBC750", VA = "0x182CBD550", Slot = "9")]
		public bool LPJEJNEGJFP(ByteString HJHKMBPIDKG, IKEMBFOFLAL NOECNPHPBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD5B0", Offset = "0x2CBC7B0", VA = "0x182CBD5B0")]
		private bool MNDICCLLCEP(ByteString HJHKMBPIDKG, IKEMBFOFLAL NOECNPHPBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD0C0", Offset = "0x2CBC2C0", VA = "0x182CBD0C0", Slot = "8")]
		public void LLNDPIJOIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBE30", Offset = "0x2CBB030", VA = "0x182CBBE30", Slot = "10")]
		public bool AAHEOHMMMBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2CBDB20", Offset = "0x2CBCD20", VA = "0x182CBDB20", Slot = "11")]
		public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC0A0", Offset = "0x2CBB2A0", VA = "0x182CBC0A0")]
		public bool BKICLGMDFAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC5F0", Offset = "0x2CBB7F0", VA = "0x182CBC5F0", Slot = "12")]
		public bool COMMHLEBCKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC350", Offset = "0x2CBB550", VA = "0x182CBC350")]
		public void CKBPIOFJIFD(OKNJKHAMLJO.BEABNMJDFOG.CAPLMFCIHOK MNKFJJIHAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCD60", Offset = "0x2CBBF60", VA = "0x182CBCD60")]
		private bool GAAGDHHJABP(ByteString HJHKMBPIDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC820", Offset = "0x2CBBA20", VA = "0x182CBC820")]
		private void DNPAPDFHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC9B0", Offset = "0x2CBBBB0", VA = "0x182CBC9B0")]
		private ByteString FFACCHNOIKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD8D0", Offset = "0x2CBCAD0", VA = "0x182CBD8D0")]
		private ByteString NFKNACOIGFO(ByteString EJAHCFFDNJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CBD9E0", Offset = "0x2CBCBE0", VA = "0x182CBD9E0")]
		private OKNJKHAMLJO.BEABNMJDFOG.CAPLMFCIHOK NLLBJGAMNJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCFF0", Offset = "0x2CBC1F0", VA = "0x182CBCFF0")]
		private void ICOELLDODGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC180", Offset = "0x2CBB380", VA = "0x182CBC180", Slot = "13")]
		public bool CCKCOKOBDEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCAE0", Offset = "0x2CBBCE0", VA = "0x182CBCAE0", Slot = "14")]
		public void FPEJLEMDNNG(bool LKAGAODJCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCB90", Offset = "0x2CBBD90", VA = "0x182CBCB90")]
		private void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LOJIIDJFKAI(typeof(BMGHPMCGENG), new string[] { })]
[DENLLMODGFC(typeof(BANIDHAOEAM))]
internal class BANIDHAOEAM : BMGHPMCGENG
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JGFPDJGKMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C43B80", Offset = "0x2C42D80", VA = "0x182C43B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C43D60", Offset = "0x2C42F60", VA = "0x182C43D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MHOEABJDIBA> NLLJHMCAAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C43F90", Offset = "0x2C43190", VA = "0x182C43F90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C43EF0", Offset = "0x2C430F0", VA = "0x182C43EF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action EGKDMNHKGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C43A40", Offset = "0x2C42C40", VA = "0x182C43A40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C43950", Offset = "0x2C42B50", VA = "0x182C43950", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action FABLIOINEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C43CC0", Offset = "0x2C42EC0", VA = "0x182C43CC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C43AE0", Offset = "0x2C42CE0", VA = "0x182C43AE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<MHOEABJDIBA> LCIHJABLCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C43E50", Offset = "0x2C43050", VA = "0x182C43E50", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C43C20", Offset = "0x2C42E20", VA = "0x182C43C20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x11D4E40", Offset = "0x11D4040", VA = "0x1811D4E40")]
	public void LLNDPIJOIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x139A7B0", Offset = "0x13999B0", VA = "0x18139A7B0")]
	public void AKFIJEOJPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x13E5C40", Offset = "0x13E4E40", VA = "0x1813E5C40")]
	public void JBFKABGNBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C43E00", Offset = "0x2C43000", VA = "0x182C43E00")]
	public void JBDFMEBJKCK(MHOEABJDIBA CEEHHEDBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C439F0", Offset = "0x2C42BF0", VA = "0x182C439F0")]
	public void ANJJJKLLPNB(MHOEABJDIBA CEEHHEDBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BANIDHAOEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LOJIIDJFKAI(typeof(DJCLCEOJBJF), new string[] { })]
public class HMIGOAGKBHF : DJCLCEOJBJF, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents NKDKBMKAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CGHKOIFBLNH LHDIADGEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService ALLKDINDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::HKEMDJIFJBH<NFJEDPPAJMK> EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5A0", Offset = "0x6CD7A0", VA = "0x1806CE5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x31A8630", Offset = "0x31A7830", VA = "0x1831A8630")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xF8F110", Offset = "0xF8E310", VA = "0x180F8F110", Slot = "14")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x31A91F0", Offset = "0x31A83F0", VA = "0x1831A91F0", Slot = "15")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x31A8850", Offset = "0x31A7A50", VA = "0x1831A8850", Slot = "16")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0xF8F040", Offset = "0xF8E240", VA = "0x180F8F040", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A77020", Offset = "0x2A76220", VA = "0x182A77020")]
	private NFJEDPPAJMK NGLBNBDHCBP(Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x31A8FD0", Offset = "0x31A81D0", VA = "0x1831A8FD0", Slot = "4")]
	public NFJEDPPAJMK MNEECNHBEJG(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x31A8CD0", Offset = "0x31A7ED0", VA = "0x1831A8CD0", Slot = "19")]
	public void KCMHHNCAIMK(ref List<NFJEDPPAJMK> JGJKBMBOGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x31A8320", Offset = "0x31A7520", VA = "0x1831A8320", Slot = "20")]
	public IEnumerable<NFJEDPPAJMK> BIJKCDCNJDN(NFJEDPPAJMK OOGHONKGHEE, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x31A8A30", Offset = "0x31A7C30", VA = "0x1831A8A30", Slot = "21")]
	public NFJEDPPAJMK JIABEAAPFBL(NFJEDPPAJMK OOGHONKGHEE, int BELCAJFDAHD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x31A90D0", Offset = "0x31A82D0", VA = "0x1831A90D0", Slot = "22")]
	public int NPABIIHHFED(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x31A8420", Offset = "0x31A7620", VA = "0x1831A8420", Slot = "8")]
	public int FJOEJBEAIPG(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x31A8940", Offset = "0x31A7B40", VA = "0x1831A8940", Slot = "9")]
	public KAANBEDLICJ JCNHAHMIGIL(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(KAANBEDLICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x31A8680", Offset = "0x31A7880", VA = "0x1831A8680", Slot = "23")]
	public bool ICGCDJLAOGF(NFJEDPPAJMK OOGHONKGHEE, out KAANBEDLICJ LNHADOCOJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x31A8C00", Offset = "0x31A7E00", VA = "0x1831A8C00", Slot = "24")]
	public IEnumerable<NFJEDPPAJMK> JPCGBLEHGGF(NFJEDPPAJMK OOGHONKGHEE, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x31A8250", Offset = "0x31A7450", VA = "0x1831A8250", Slot = "12")]
	public NFJEDPPAJMK BEIEOAFNFAF(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x31A8180", Offset = "0x31A7380", VA = "0x1831A8180", Slot = "13")]
	public bool ABEADFFICKO(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD, out NFJEDPPAJMK OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x31A9030", Offset = "0x31A8230", VA = "0x1831A9030", Slot = "5")]
	public NFJEDPPAJMK MODGPLDICAF(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x31A8EF0", Offset = "0x31A80F0", VA = "0x1831A8EF0", Slot = "11")]
	public bool KFKEAKANFDF(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x31A92C0", Offset = "0x31A84C0", VA = "0x1831A92C0", Slot = "25")]
	public bool PNPLAMAGNCA(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK LKJGCNCCCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x31A83F0", Offset = "0x31A75F0", VA = "0x1831A83F0", Slot = "10")]
	public bool CLCGCNNPCNJ(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK HOHCGCELNKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x31A8F20", Offset = "0x31A8120", VA = "0x1831A8F20", Slot = "6")]
	public bool KKGLFGKJMPP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK GPFONCECPBK, bool INKJNEFMNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x31A85C0", Offset = "0x31A77C0", VA = "0x1831A85C0", Slot = "7")]
	public bool GFCKPIADCDP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK GPFONCECPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HMIGOAGKBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[LOJIIDJFKAI(typeof(LKPHHNIFJFE), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal class LKPHHNIFJFE : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, BCCHDFPAANJ> KNKJOFMCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F210", Offset = "0x2A6E410", VA = "0x182A6F210", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EC40", Offset = "0x2A6DE40", VA = "0x182A6EC40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F000", Offset = "0x2A6E200", VA = "0x182A6F000")]
	public BCCHDFPAANJ GBIPKNCFFFJ(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EEB0", Offset = "0x2A6E0B0", VA = "0x182A6EEB0")]
	public BCCHDFPAANJ GBIPKNCFFFJ(NMLCFAIOCDK MPKOBDPILJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ED90", Offset = "0x2A6DF90", VA = "0x182A6ED90")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F260", Offset = "0x2A6E460", VA = "0x182A6F260")]
	public LKPHHNIFJFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BCCHDFPAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<KIHDBJFDLNG> LIGBFHFNCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<LMIKKFINNNK> JLABFFGDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<CCLINJKNNFF> FHNJMFEHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<LMIKKFINNNK> PKOGBONKPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<KIHDBJFDLNG> HCBIGKOJDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
		get
		{
			return default(NativeList<KIHDBJFDLNG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<LMIKKFINNNK> ELGOEEGBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xBF8CA0", Offset = "0xBF7EA0", VA = "0x180BF8CA0")]
		get
		{
			return default(NativeList<LMIKKFINNNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<CCLINJKNNFF> MAGNNNDECGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xEACBE0", Offset = "0xEABDE0", VA = "0x180EACBE0")]
		get
		{
			return default(NativeList<CCLINJKNNFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<LMIKKFINNNK> EMNGNAECNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xF0C0C0", Offset = "0xF0B2C0", VA = "0x180F0C0C0")]
		get
		{
			return default(NativeList<LMIKKFINNNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle KOGMBPFEHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x13621D0", Offset = "0x13613D0", VA = "0x1813621D0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15F4ED0", Offset = "0x15F40D0", VA = "0x1815F4ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1074960", Offset = "0x1073B60", VA = "0x181074960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool HCBAHJPCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2C44250", Offset = "0x2C43450", VA = "0x182C44250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2C447D0", Offset = "0x2C439D0", VA = "0x182C447D0")]
	public BCCHDFPAANJ(Allocator OPBLDCCKGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2C44610", Offset = "0x2C43810", VA = "0x182C44610")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2C446A0", Offset = "0x2C438A0", VA = "0x182C446A0")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2C44300", Offset = "0x2C43500", VA = "0x182C44300")]
	public void AOHLLDNPMGN(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(FBCNKCHPACJ), new string[] { })]
public class FBCNKCHPACJ : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[IMNMHIBEIDL]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x31A3080", Offset = "0x31A2280", VA = "0x1831A3080", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x31A3060", Offset = "0x31A2260", VA = "0x1831A3060", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FBCNKCHPACJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[LOJIIDJFKAI(typeof(PhotonInstanceCleanupService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.PhotonRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	public class PhotonInstanceCleanupService : DPDCPMNGBKH, LFPMKPLIAAM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private MMGILMAMAJD GMLCALJNCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AKKPACBLFCH ONMGKKCFHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> EEDLNGCNICA;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2A83F00", Offset = "0x2A83100", VA = "0x182A83F00", Slot = "5")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2A83F60", Offset = "0x2A83160", VA = "0x182A83F60", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2A83E60", Offset = "0x2A83060", VA = "0x182A83E60")]
		public void JBIEBACCPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2A83B20", Offset = "0x2A82D20", VA = "0x182A83B20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C50", Offset = "0x2A82E50", VA = "0x182A83C50")]
		public void GAMPMPDIDKK(global::CEFPLBEJFHF<int> GODOBFAPBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C10", Offset = "0x2A82E10", VA = "0x182A83C10")]
		public void FBLAKGJBHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class JDBOBJPFFMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint FEOCEMOCKPE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x99F2A0", Offset = "0x99E4A0", VA = "0x18099F2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x31AF540", Offset = "0x31AE740", VA = "0x1831AF540")]
	public IOLFAAOECPP LNPPGCFLOHH()
	{
		return default(IOLFAAOECPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x31AF590", Offset = "0x31AE790", VA = "0x1831AF590")]
	public void NIJKJOBCOCK(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x10EC7D0", Offset = "0x10EB9D0", VA = "0x1810EC7D0", Slot = "6")]
	public virtual void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	protected JDBOBJPFFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LOJIIDJFKAI(typeof(AAIADCALDOD), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class AAIADCALDOD : JDBOBJPFFMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint PMIGFHIBOOC;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E270", Offset = "0x2C3D470", VA = "0x182C3E270", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E1C0", Offset = "0x2C3D3C0", VA = "0x182C3E1C0")]
	private void BHPKNPKGHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E210", Offset = "0x2C3D410", VA = "0x182C3E210", Slot = "6")]
	public override void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
	public AAIADCALDOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(LNNMLPAEAED), new string[] { })]
internal sealed class LNNMLPAEAED : JDBOBJPFFMG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
	public LNNMLPAEAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LOJIIDJFKAI(typeof(DEBKKNKNNEP), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class DEBKKNKNNEP : JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery EGEKBBOJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery NFIKLHBDHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery LGDEKACIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery CFDEBNKJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery IBALNAGMJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery JJCIKGNBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2C55DE0", Offset = "0x2C54FE0", VA = "0x182C55DE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MAIFNINLJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery DGIOOGHLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6E8030", Offset = "0x6E7230", VA = "0x1806E8030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery GAJJOHAKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x11A4660", Offset = "0x11A3860", VA = "0x1811A4660")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery CGPELACBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x13621D0", Offset = "0x13613D0", VA = "0x1813621D0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery LAIKGDJDIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1AE9F20", Offset = "0x1AE9120", VA = "0x181AE9F20")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery DJMEEJAEBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2C563B0", Offset = "0x2C555B0", VA = "0x182C563B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int LKLIKLMACMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2C55E50", Offset = "0x2C55050", VA = "0x182C55E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int APEIIPIDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2C55E30", Offset = "0x2C55030", VA = "0x182C55E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int KIPPHGBJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2C56330", Offset = "0x2C55530", VA = "0x182C56330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int KBHDDOIFNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2C55BB0", Offset = "0x2C54DB0", VA = "0x182C55BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int IHBICFBPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2C55E70", Offset = "0x2C55070", VA = "0x182C55E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BMDJAMEMPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2C55B30", Offset = "0x2C54D30", VA = "0x182C55B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2C56430", Offset = "0x2C55630", VA = "0x182C56430", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2C55E90", Offset = "0x2C55090", VA = "0x182C55E90", Slot = "6")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2C56350", Offset = "0x2C55550", VA = "0x182C56350")]
	private EntityQueryDesc NLDEKBFMEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2C55B50", Offset = "0x2C54D50", VA = "0x182C55B50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2C55BD0", Offset = "0x2C54DD0", VA = "0x182C55BD0")]
	public JNMBNPFAJDL FLCJGEPPJJA(NFJEDPPAJMK ONBAMHPEIDG)
	{
		return default(JNMBNPFAJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2C55C80", Offset = "0x2C54E80", VA = "0x182C55C80")]
	public JNMBNPFAJDL FLCJGEPPJJA(Entity OAOGLFGGBPI)
	{
		return default(JNMBNPFAJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2C55D30", Offset = "0x2C54F30", VA = "0x182C55D30")]
	public MFOBNBKALPH GBKNIBKIHOC(Entity OAOGLFGGBPI)
	{
		return default(MFOBNBKALPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2C56480", Offset = "0x2C55680", VA = "0x182C56480")]
	public DEBKKNKNNEP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[LOJIIDJFKAI(typeof(NPFNHEGAPFJ), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.All)]
	public class ObjectService : DPDCPMNGBKH, NPFNHEGAPFJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly FADHLPPNOEF OAACCKPBMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[IMNMHIBEIDL]
		private GPJINHAGDJN HOCPKHHLENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[IMNMHIBEIDL]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[IMNMHIBEIDL]
		private ObjectInstantiationService DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int LKLIKLMACMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F940", Offset = "0x2A7EB40", VA = "0x182A7F940", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int APEIIPIDGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F8D0", Offset = "0x2A7EAD0", VA = "0x182A7F8D0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int KIPPHGBJEGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FA20", Offset = "0x2A7EC20", VA = "0x182A7FA20", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int KBHDDOIFNPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2A7EE90", Offset = "0x2A7E090", VA = "0x182A7EE90", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int IHBICFBPGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FA00", Offset = "0x2A7EC00", VA = "0x182A7FA00", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int BMDJAMEMPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2A7EA70", Offset = "0x2A7DC70", VA = "0x182A7EA70", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<NFJEDPPAJMK, MFOBNBKALPH> AGJONJAHFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2A7E930", Offset = "0x2A7DB30", VA = "0x182A7E930", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FA40", Offset = "0x2A7EC40", VA = "0x182A7FA40", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<NFJEDPPAJMK> AEAKNNLHOFF
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FD20", Offset = "0x2A7EF20", VA = "0x182A7FD20", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F960", Offset = "0x2A7EB60", VA = "0x182A7F960", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2A80120", Offset = "0x2A7F320", VA = "0x182A80120", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7ED10", Offset = "0x2A7DF10", VA = "0x182A7ED10", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E7F0", Offset = "0x2A7D9F0", VA = "0x182A7E7F0")]
		private void BFBNAODLCNH(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F200", Offset = "0x2A7E400", VA = "0x182A7F200")]
		private void FEHHFKCODGC(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FF40", Offset = "0x2A7F140", VA = "0x182A7FF40")]
		internal NFJEDPPAJMK NGLBNBDHCBP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EF50", Offset = "0x2A7E150", VA = "0x182A7EF50", Slot = "41")]
		public KAANBEDLICJ EOJHKFGEAIB()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2A80070", Offset = "0x2A7F270", VA = "0x182A80070", Slot = "42")]
		public KAANBEDLICJ PAMBNIOCPCM()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EEB0", Offset = "0x2A7E0B0", VA = "0x182A7EEB0", Slot = "43")]
		public KAANBEDLICJ EIDHNJKNGFM()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F290", Offset = "0x2A7E490", VA = "0x182A7F290", Slot = "10")]
		public JNMBNPFAJDL FLCJGEPPJJA(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(JNMBNPFAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F4F0", Offset = "0x2A7E6F0", VA = "0x182A7F4F0", Slot = "11")]
		public MFOBNBKALPH GBKNIBKIHOC(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EC60", Offset = "0x2A7DE60", VA = "0x182A7EC60")]
		private KAANBEDLICJ DALBGCMGJDD(EntityQuery JLMGAJOHFKO)
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EFF0", Offset = "0x2A7E1F0", VA = "0x182A7EFF0", Slot = "33")]
		public bool EOKNMHALCBJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E5D0", Offset = "0x2A7D7D0", VA = "0x182A7E5D0", Slot = "29")]
		public void ACJHDFNHANL(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EA90", Offset = "0x2A7DC90", VA = "0x182A7EA90", Slot = "30")]
		public void COLIANFIIAH(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E890", Offset = "0x2A7DA90", VA = "0x182A7E890", Slot = "31")]
		public void BNAAMBOKMGH(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EBA0", Offset = "0x2A7DDA0", VA = "0x182A7EBA0", Slot = "22")]
		public JMAKJOJHHNF CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EAF0", Offset = "0x2A7DCF0", VA = "0x182A7EAF0", Slot = "23")]
		public JMAKJOJHHNF CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FEB0", Offset = "0x2A7F0B0", VA = "0x182A7FEB0", Slot = "24")]
		public JMAKJOJHHNF MMLGPEAALJN(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E620", Offset = "0x2A7D820", VA = "0x182A7E620", Slot = "25")]
		public JMAKJOJHHNF AIPMEHKGCLA(IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F780", Offset = "0x2A7E980", VA = "0x182A7F780", Slot = "44")]
		public JMAKJOJHHNF HIPEEDFCDLK(int BJBILOLHCFO, MFOBNBKALPH JDHIJCJKFOO, GameObject OOKBNBHDPPG)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F810", Offset = "0x2A7EA10", VA = "0x182A7F810", Slot = "26")]
		public KAINPBJGIFE IEIDJDJHKHA()
		{
			return default(KAINPBJGIFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2A80390", Offset = "0x2A7F590", VA = "0x182A80390", Slot = "45")]
		public FAEDMMBBFOA PPFCLJJLPDP(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(FAEDMMBBFOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F5B0", Offset = "0x2A7E7B0", VA = "0x182A7F5B0", Slot = "27")]
		public FCINIMONKIM GKHEHOAFOIC()
		{
			return default(FCINIMONKIM);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F0C0", Offset = "0x2A7E2C0", VA = "0x182A7F0C0", Slot = "28")]
		public OLODCECCCEO FBCCHMIENCE(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(OLODCECCCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FB50", Offset = "0x2A7ED50", VA = "0x182A7FB50", Slot = "12")]
		public void KJDPCLCGNLB(IOLFAAOECPP IOCKLNNJMIA, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F2C0", Offset = "0x2A7E4C0", VA = "0x182A7F2C0", Slot = "13")]
		public JMAKJOJHHNF GAKEHOENCMF(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E9D0", Offset = "0x2A7DBD0", VA = "0x182A7E9D0", Slot = "14")]
		public bool CCBOPNINIEJ(NFJEDPPAJMK OOGHONKGHEE, out MIDGCDECPDI APCBFLNDMMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FE60", Offset = "0x2A7F060", VA = "0x182A7FE60", Slot = "46")]
		public Transform MHIJHDGLGCN(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E580", Offset = "0x2A7D780", VA = "0x182A7E580", Slot = "16")]
		public bool AAMKJDPJALI(NFJEDPPAJMK OOGHONKGHEE, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F8F0", Offset = "0x2A7EAF0", VA = "0x182A7F8F0", Slot = "17")]
		public bool IGNAOPBPCKO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2A80000", Offset = "0x2A7F200", VA = "0x182A80000")]
		public bool ODOOOIFCONJ(MIDGCDECPDI JFBPNBNBHOE, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FFD0", Offset = "0x2A7F1D0", VA = "0x182A7FFD0", Slot = "47")]
		public bool ODOOOIFCONJ(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F7F0", Offset = "0x2A7E9F0", VA = "0x182A7F7F0", Slot = "48")]
		public void HPILCJEPAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FB70", Offset = "0x2A7ED70", VA = "0x182A7FB70", Slot = "15")]
		public void KKIAJDCJNFI(MIDGCDECPDI ADHHHFDPAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2A80030", Offset = "0x2A7F230", VA = "0x182A80030", Slot = "49")]
		public void OONHDEIOEPE(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F470", Offset = "0x2A7E670", VA = "0x182A7F470", Slot = "18")]
		public bool GBKFKBLGCCA(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F530", Offset = "0x2A7E730", VA = "0x182A7F530", Slot = "19")]
		public bool GJIPPEJJKHO(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FF60", Offset = "0x2A7F160", VA = "0x182A7FF60", Slot = "50")]
		public bool NMIIAKEHEIC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FAE0", Offset = "0x2A7ECE0", VA = "0x182A7FAE0", Slot = "51")]
		public bool KFEOGLGLLAC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E520", Offset = "0x2A7D720", VA = "0x182A7E520", Slot = "32")]
		public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FDC0", Offset = "0x2A7EFC0", VA = "0x182A7FDC0", Slot = "21")]
		public IOLFAAOECPP LPAPEMKKHGI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(IOLFAAOECPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F690", Offset = "0x2A7E890", VA = "0x182A7F690", Slot = "20")]
		public NFJEDPPAJMK HELPAPLNDJP(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F080", Offset = "0x2A7E280", VA = "0x182A7F080")]
		private void FACNMHLBPKJ(MFOBNBKALPH JDHIJCJKFOO, NFJEDPPAJMK OOGHONKGHEE, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LOJIIDJFKAI(typeof(JEIKFBGOBDH), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class JEIKFBGOBDH : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[IMNMHIBEIDL]
	private DEBKKNKNNEP LHDIADGEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x31B07C0", Offset = "0x31AF9C0", VA = "0x1831B07C0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x31AFBE0", Offset = "0x31AEDE0", VA = "0x1831AFBE0")]
	public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
	{
		return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x31B05E0", Offset = "0x31AF7E0", VA = "0x1831B05E0")]
	private void LJGNDNNOBOG(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x31AFE70", Offset = "0x31AF070", VA = "0x1831AFE70")]
	private void GAMMHAGIBAO(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD, int JDHIJCJKFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x31AFCE0", Offset = "0x31AEEE0", VA = "0x1831AFCE0")]
	private void AHGKMIJEPBI(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD, int JDHIJCJKFOO, BCNEEGFPPIH ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x31B0300", Offset = "0x31AF500", VA = "0x1831B0300")]
	private NativeMultiHashMap<int, (NFJEDPPAJMK, NFJEDPPAJMK)> KCBKOKHBKHK(Allocator OPBLDCCKGEG, NativeArray<NFJEDPPAJMK> IHEMFOMABIH, out NativeArray<(NFJEDPPAJMK src, NFJEDPPAJMK dst)> JAEMFJIDANN)
	{
		return default(NativeMultiHashMap<int, (NFJEDPPAJMK, NFJEDPPAJMK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JEIKFBGOBDH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DENLLMODGFC(typeof(TransformService))]
	[LOJIIDJFKAI(typeof(DFPNHPPNFLJ), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class TransformService : DFPNHPPNFLJ, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly FADHLPPNOEF DKLKEDAKIIG;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly FADHLPPNOEF CHIGBDKNFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GKJCKFLLFKJ KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DJCLCEOJBJF FPAHGFEONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase PIGADKLNHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService CCJAOIAIHHP;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2CC6410", Offset = "0x2CC5610", VA = "0x182CC6410")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private JCGKPCPJOOI OHPMAEDABBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2CC3E20", Offset = "0x2CC3020", VA = "0x182CC3E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8510", Offset = "0x2CC7710", VA = "0x182CC8510", Slot = "33")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC68E0", Offset = "0x2CC5AE0", VA = "0x182CC68E0", Slot = "34")]
		public bool IBMPCAOLAEC(Transform LJLOGOIJMEM, out NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6460", Offset = "0x2CC5660", VA = "0x182CC6460", Slot = "35")]
		public Transform HOIMJPFPMPD(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3810", Offset = "0x2CC2A10", VA = "0x182CC3810", Slot = "30")]
		public bool AAMKJDPJALI(Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6AA0", Offset = "0x2CC5CA0", VA = "0x182CC6AA0")]
		private void IDFOLKGMAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5580", Offset = "0x2CC4780", VA = "0x182CC5580", Slot = "29")]
		public void FBBDPHCKLIO(Entity OAOGLFGGBPI, out Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8620", Offset = "0x2CC7820", VA = "0x182CC8620", Slot = "4")]
		public void PHIGHDGGMNO(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7700", Offset = "0x2CC6900", VA = "0x182CC7700")]
		public void NHJGLIDADAO(Entity OAOGLFGGBPI, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM, Vector3 IINIILHCOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3F80", Offset = "0x2CC3180", VA = "0x182CC3F80")]
		public void BJCLMAOOLIC(Entity OAOGLFGGBPI, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2CC48E0", Offset = "0x2CC3AE0", VA = "0x182CC48E0", Slot = "27")]
		public void EEMHAMNAJMM(Entity OAOGLFGGBPI, out Matrix4x4 BEMAHJKDKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6520", Offset = "0x2CC5720", VA = "0x182CC6520")]
		public void HONNGIDOFNJ(Entity OAOGLFGGBPI, in Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2CC75D0", Offset = "0x2CC67D0", VA = "0x182CC75D0")]
		public void LPPMGFNCCHE(Entity OAOGLFGGBPI, in Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8350", Offset = "0x2CC7550", VA = "0x182CC8350")]
		public void ONGILAGIPPG(Entity OAOGLFGGBPI, in Matrix4x4 OJNOPDDINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2CC44B0", Offset = "0x2CC36B0", VA = "0x182CC44B0", Slot = "5")]
		public void DFMLPKFHNLG(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6300", Offset = "0x2CC5500", VA = "0x182CC6300", Slot = "6")]
		public Vector3 GJBOKJIGCBL(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2CC56D0", Offset = "0x2CC48D0", VA = "0x182CC56D0", Slot = "7")]
		public void FDNACLAKOEC(Entity OAOGLFGGBPI, Quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC57D0", Offset = "0x2CC49D0", VA = "0x182CC57D0", Slot = "8")]
		public Quaternion FEOIBCPCOKG(Entity OAOGLFGGBPI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6AC0", Offset = "0x2CC5CC0", VA = "0x182CC6AC0", Slot = "12")]
		public void IJPDEBBBFKD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5160", Offset = "0x2CC4360", VA = "0x182CC5160", Slot = "11")]
		public Vector3 EJMFAKDNICO(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6BC0", Offset = "0x2CC5DC0", VA = "0x182CC6BC0")]
		public void JAKLKBGEFBL(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3EE0", Offset = "0x2CC30E0", VA = "0x182CC3EE0")]
		private Vector3 BGJGLDHLJAO(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3A20", Offset = "0x2CC2C20", VA = "0x182CC3A20", Slot = "14")]
		public float AMNMNBPMHEK(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3910", Offset = "0x2CC2B10", VA = "0x182CC3910", Slot = "13")]
		public void ALEHHKAPKKL(Entity OAOGLFGGBPI, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2CC47F0", Offset = "0x2CC39F0", VA = "0x182CC47F0")]
		private float DODDMFBBGLF(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8160", Offset = "0x2CC7360", VA = "0x182CC8160")]
		public void OIPAJHAEFPA(Entity OAOGLFGGBPI, float BHBODGPIKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2CC42A0", Offset = "0x2CC34A0", VA = "0x182CC42A0", Slot = "16")]
		public Vector3 CJKHDOHDFBM(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3AC0", Offset = "0x2CC2CC0", VA = "0x182CC3AC0", Slot = "15")]
		public void ANMCAOHEHND(Entity OAOGLFGGBPI, Vector3 JCELHCJFLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CC72F0", Offset = "0x2CC64F0", VA = "0x182CC72F0")]
		private Vector3 KJCCCINBPFN(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7FA0", Offset = "0x2CC71A0", VA = "0x182CC7FA0")]
		public void OEJIDBJIMDD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5EA0", Offset = "0x2CC50A0", VA = "0x182CC5EA0")]
		[Conditional("DEBUG_BUILD")]
		private void FOPPBHPFGMJ(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2CC81F0", Offset = "0x2CC73F0", VA = "0x182CC81F0", Slot = "36")]
		public void OKNHICOLCGK(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2CC4F90", Offset = "0x2CC4190", VA = "0x182CC4F90", Slot = "9")]
		public void EJAOPPBIHHJ(Entity OAOGLFGGBPI, out Vector3 DACBJNCMNFL, out Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC4380", Offset = "0x2CC3580", VA = "0x182CC4380", Slot = "10")]
		public void CMAAFHILFDG(Entity OAOGLFGGBPI, out Vector3 DACBJNCMNFL, out Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC45D0", Offset = "0x2CC37D0", VA = "0x182CC45D0", Slot = "37")]
		public void DJCOHCPGCAG(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5270", Offset = "0x2CC4470", VA = "0x182CC5270")]
		public void EJOKFHOEGAI(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2CC70C0", Offset = "0x2CC62C0", VA = "0x182CC70C0", Slot = "17")]
		public void KFOBMOMMNKD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7EC0", Offset = "0x2CC70C0", VA = "0x182CC7EC0", Slot = "18")]
		public Vector3 ODHOKPOFNHG(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5C60", Offset = "0x2CC4E60", VA = "0x182CC5C60", Slot = "19")]
		public void FNKHHLBABJJ(Entity OAOGLFGGBPI, Quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2CC4090", Offset = "0x2CC3290", VA = "0x182CC4090", Slot = "20")]
		public Quaternion CBGOMHCMEFK(Entity OAOGLFGGBPI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6C60", Offset = "0x2CC5E60", VA = "0x182CC6C60", Slot = "22")]
		public void KAILFGIEIKO(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8070", Offset = "0x2CC7270", VA = "0x182CC8070", Slot = "21")]
		public Vector3 OIDIBCOMBEN(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6050", Offset = "0x2CC5250", VA = "0x182CC6050", Slot = "23")]
		public void GCAJBHEGGNN(Entity OAOGLFGGBPI, float PLOEFOCDODI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CC78B0", Offset = "0x2CC6AB0", VA = "0x182CC78B0", Slot = "24")]
		public float OAJPAGBABKJ(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CC79D0", Offset = "0x2CC6BD0", VA = "0x182CC79D0", Slot = "25")]
		public void OCBFLFOKHEP(Entity OAOGLFGGBPI, Vector3 CCHOHGAKEGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CC61C0", Offset = "0x2CC53C0", VA = "0x182CC61C0", Slot = "26")]
		public Vector3 GFHDDODHJEA(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CC48F0", Offset = "0x2CC3AF0", VA = "0x182CC48F0", Slot = "31")]
		public void EFKAHDGAODL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CC5430", Offset = "0x2CC4630", VA = "0x182CC5430")]
		private NFJEDPPAJMK FAMOKPHFIPE(Transform LJLOGOIJMEM)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3BF0", Offset = "0x2CC2DF0", VA = "0x182CC3BF0")]
		private static TransformEntity BAIOFNKIKJJ(MFOBNBKALPH DDJDPMGLPAE, GameObject GODCAKDBDMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CC4180", Offset = "0x2CC3380", VA = "0x182CC4180", Slot = "32")]
		public void CCIIMJPCLDL(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CC50E0", Offset = "0x2CC42E0", VA = "0x182CC50E0")]
		private HJJLGKMPGLN EJAOPPBIHHJ(Entity OAOGLFGGBPI)
		{
			return default(HJJLGKMPGLN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CC77D0", Offset = "0x2CC69D0", VA = "0x182CC77D0")]
		private bool NKOHPLNJLNH(Entity OAOGLFGGBPI, out Entity GPFONCECPBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7420", Offset = "0x2CC6620", VA = "0x182CC7420")]
		private void KLJOIGGINIF(Entity OAOGLFGGBPI, out Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CC58C0", Offset = "0x2CC4AC0", VA = "0x182CC58C0")]
		private void FMDOGOKBOLA(Entity OAOGLFGGBPI, out Matrix4x4 OJNOPDDINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3900", Offset = "0x2CC2B00", VA = "0x182CC3900", Slot = "28")]
		private void AGACPGICPIH(Entity OAOGLFGGBPI, in Matrix4x4 BEMAHJKDKCM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LOJIIDJFKAI(typeof(EDLEDNKNNMB), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class EDLEDNKNNMB : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A160", Offset = "0x2C59360", VA = "0x182C5A160", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A0F0", Offset = "0x2C592F0", VA = "0x182C5A0F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EDLEDNKNNMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(INBLIGACKIF), new string[] { })]
public class INBLIGACKIF
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct FDDHIKKDAJJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly INBLIGACKIF GPFONCECPBK;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x41C4740", Offset = "0x41C3940", VA = "0x1841C4740")]
		public FDDHIKKDAJJ(INBLIGACKIF GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x41C4720", Offset = "0x41C3920", VA = "0x1841C4720", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int FAHIDMNDFOC;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool NJFOAKJMCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x13CCD80", Offset = "0x13CBF80", VA = "0x1813CCD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action LJAGMFKKKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x31AE7F0", Offset = "0x31AD9F0", VA = "0x1831AE7F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x31AE750", Offset = "0x31AD950", VA = "0x1831AE750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x31AE720", Offset = "0x31AD920", VA = "0x1831AE720")]
	public FDDHIKKDAJJ ABEBGHBCBGI()
	{
		return default(FDDHIKKDAJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1997CF0", Offset = "0x1996EF0", VA = "0x181997CF0")]
	public void MHHBNKIPINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x31AE890", Offset = "0x31ADA90", VA = "0x1831AE890")]
	public void OMGFPDIACBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public INBLIGACKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LOJIIDJFKAI(typeof(ADMIKKBEDIN), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public class ADMIKKBEDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int FAHIDMNDFOC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDD9C50", Offset = "0xDD8E50", VA = "0x180DD9C50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE70", Offset = "0x9AB070", VA = "0x1809ABE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public ADMIKKBEDIN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(EnableComponentSystemsInScope), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : DPDCPMNGBKH, CBFMKNIGECP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct FKGCBMIMKKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> EEFMIEFKGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> NHJCEALNJLO;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x41C4B90", Offset = "0x41C3D90", VA = "0x1841C4B90")]
			public FKGCBMIMKKK(NativeArray<int> EEFMIEFKGLG, NativeArray<int> GGHFLGHFEMD, Dictionary<ComponentSystemBase, int> NHJCEALNJLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x41C4910", Offset = "0x41C3B10", VA = "0x1841C4910")]
			public void LFEJNLLPNFL(IEnumerable<ComponentSystemBase> HOCPKHHLENG, JHCKAKNDFFP PLOEGHGLKPD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BGEBFGFOFFP : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public BGEBFGFOFFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x41C1940", Offset = "0x41C0B40", VA = "0x1841C1940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x41C1B10", Offset = "0x41C0D10", VA = "0x1841C1B10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x41C1A60", Offset = "0x41C0C60", VA = "0x1841C1A60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x41C1A60", Offset = "0x41C0C60", VA = "0x1841C1A60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const JHCKAKNDFFP HJOCIDOBHPP = JHCKAKNDFFP.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FADHLPPNOEF BPGBIEPDJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private JHLNNPKIFCO KOKEGENGCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> FFAAGADNJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> PPNJBNFDHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int FLPPPNDNNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private JHCKAKNDFFP KLLMIENMENM;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x319F040", Offset = "0x319E240", VA = "0x18319F040", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x319E260", Offset = "0x319D460", VA = "0x18319E260", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x319E2F0", Offset = "0x319D4F0", VA = "0x18319E2F0")]
		[IteratorStateMachine(typeof(BGEBFGFOFFP))]
		private IEnumerable<ComponentSystemBase> FCDEGJJLGLB(int IDCHKLCNMBN, int HEGLMOCOEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x319DF10", Offset = "0x319D110", VA = "0x18319DF10", Slot = "5")]
		public void AEPAOFPFGOA(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x319E3E0", Offset = "0x319D5E0", VA = "0x18319E3E0")]
		private void FFOMGBEMCCK(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x319E530", Offset = "0x319D730", VA = "0x18319E530")]
		public void FFOMGBEMCCK(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x319DF20", Offset = "0x319D120", VA = "0x18319DF20")]
		private void APGOCKEFEMH(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x319EE00", Offset = "0x319E000", VA = "0x18319EE00")]
		private void MPKCJFHOCGD(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x319EFE0", Offset = "0x319E1E0", VA = "0x18319EFE0")]
		private void NFJCBKDGGKD(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x319E750", Offset = "0x319D950", VA = "0x18319E750")]
		private void JODGKFHFJKL(int IDCHKLCNMBN, int HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x319E690", Offset = "0x319D890", VA = "0x18319E690")]
		private void HGJPOICCAII(int IDCHKLCNMBN, int HEGLMOCOEGO, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x319E670", Offset = "0x319D870", VA = "0x18319E670")]
		private int GPJCGEHCJHB(JHCKAKNDFFP AANIBAOFBJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x319E810", Offset = "0x319DA10", VA = "0x18319E810")]
		private bool KMBLCCNNPEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x319EE90", Offset = "0x319E090", VA = "0x18319EE90")]
		private Dictionary<ComponentSystemBase, int> NALBKCHBLNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x319E630", Offset = "0x319D830", VA = "0x18319E630")]
		private void FNEMCAFIPEL(NativeArray<int> EEFMIEFKGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x319E1B0", Offset = "0x319D3B0", VA = "0x18319E1B0")]
		private void CPLENEBENDI(NativeArray<int> GGHFLGHFEMD, NativeArray<int> EEFMIEFKGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x319EF80", Offset = "0x319E180", VA = "0x18319EF80")]
		private static JHCKAKNDFFP NDFAADKNGLC(Type DDJDPMGLPAE, JHCKAKNDFFP EOBGHKICABG)
		{
			return default(JHCKAKNDFFP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x319F150", Offset = "0x319E350", VA = "0x18319F150")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x319E380", Offset = "0x319D580", VA = "0x18319E380")]
		[CompilerGenerated]
		private void FDJFPLHGIAN(DPDCPMNGBKH IACHGNJKHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x319EDA0", Offset = "0x319DFA0", VA = "0x18319EDA0")]
		[CompilerGenerated]
		private void LNOPIFDFDCI(FPHKGEBJIKC IACHGNJKHMN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[LOJIIDJFKAI(typeof(LFIBHLPOILP), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.WorldService)]
	public class TickService : DPDCPMNGBKH, LFIBHLPOILP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker PCFJEAHMHDP;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker CJLBIBJDJLK;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker AFPGHIMOENP;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker JJLEPCBFAFF;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker FEMAMMCNBFK;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker HMHKJDKBLPH;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker PDBHCMGKEIJ;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker EBGMPOFMJEA;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker JMKMFHLHODE;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker AKEACOBJOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[IMNMHIBEIDL]
		private BDAJNAKKLOI BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[IMNMHIBEIDL]
		private NILGHIEKGGJ ADBPFEHIBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[IMNMHIBEIDL]
		private TransformOwnershipPhase EDDHBBFFICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[IMNMHIBEIDL]
		private TimeService JOGKAGECKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private MJGGLIPIDNP OACNPKMLCHI;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool PCMNKHFDPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2CC2200", Offset = "0x2CC1400", VA = "0x182CC2200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool IHPJCFCPAKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2CC1D20", Offset = "0x2CC0F20", VA = "0x182CC1D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool LJMFMFBLKDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2CC2200", Offset = "0x2CC1400", VA = "0x182CC2200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool DLOFBJENFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2CC2200", Offset = "0x2CC1400", VA = "0x182CC2200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2AD0", Offset = "0x2CC1CD0", VA = "0x182CC2AD0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2010", Offset = "0x2CC1210", VA = "0x182CC2010", Slot = "14")]
		public void GKFBCPAHPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2830", Offset = "0x2CC1A30", VA = "0x182CC2830", Slot = "15")]
		public void LOKEIDCHOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1F40", Offset = "0x2CC1140", VA = "0x182CC1F40", Slot = "5")]
		public void FJBGJECCJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1DC0", Offset = "0x2CC0FC0", VA = "0x182CC1DC0", Slot = "6")]
		public void EIOOCHEOKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1BA0", Offset = "0x2CC0DA0", VA = "0x182CC1BA0", Slot = "7")]
		public void BJAKFLHJNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CC26B0", Offset = "0x2CC18B0", VA = "0x182CC26B0", Slot = "8")]
		public void LKEKIONCJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2950", Offset = "0x2CC1B50", VA = "0x182CC2950", Slot = "9")]
		public void NHEOCLKOANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2270", Offset = "0x2CC1470", VA = "0x182CC2270", Slot = "10")]
		public void KLGBCPNHBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2130", Offset = "0x2CC1330", VA = "0x182CC2130", Slot = "11")]
		public void HPIFEDLDHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
		public void LJCMLABHGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1A50", Offset = "0x2CC0C50", VA = "0x182CC1A50", Slot = "12")]
		public void ALEDHMOOFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[LOJIIDJFKAI(typeof(CPEFIMBHABA), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.WorldService)]
	public class WorldService : CPEFIMBHABA, IDisposable, LFPMKPLIAAM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private MJGGLIPIDNP OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FNCOHMIDMDB OKPOBPNCFMK;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MJGGLIPIDNP IIINLMPBCPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JCGKPCPJOOI OHPMAEDABBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2C57A50", Offset = "0x2C56C50", VA = "0x182C57A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2CD0D10", Offset = "0x2CCFF10", VA = "0x182CD0D10", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0D30", Offset = "0x2CCFF30", VA = "0x182CD0D30", Slot = "10")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0E40", Offset = "0x2CD0040", VA = "0x182CD0E40", Slot = "11")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD09B0", Offset = "0x2CCFBB0", VA = "0x182CD09B0")]
		private void BFPHDDBHNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0AC0", Offset = "0x2CCFCC0", VA = "0x182CD0AC0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0CF0", Offset = "0x2CCFEF0", VA = "0x182CD0CF0", Slot = "8")]
		public ComponentSystemBase ENGBKAHPLGI(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LOJIIDJFKAI(typeof(LFJAPFGLCMI), new string[] { })]
public sealed class LAMGODIJFKL : LFJAPFGLCMI, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JJEPBHPMDEL : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x41C7D00", Offset = "0x41C6F00", VA = "0x1841C7D00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E120", VA = "0x18096EF20")]
		[DebuggerHidden]
		public JJEPBHPMDEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x41C79F0", Offset = "0x41C6BF0", VA = "0x1841C79F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x41C7CC0", Offset = "0x41C6EC0", VA = "0x1841C7CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x41C7C20", Offset = "0x41C6E20", VA = "0x1841C7C20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x41C7C20", Offset = "0x41C6E20", VA = "0x1841C7C20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[IMNMHIBEIDL]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly CDKDMLIJPKH GMNIHNAKLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, OHBNOLPKNLP> KKCEAEGPCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, JDGJMEJMAJC> EMIGFHNAFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<FNOOJMKBHOH> NMLIPDDKLMG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public JDGJMEJMAJC GJEJHPOKGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C1B0", Offset = "0x2A6B3B0", VA = "0x182A6C1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<FNOOJMKBHOH> HIBNOCAMLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C9E0", Offset = "0x2A6BBE0", VA = "0x182A6C9E0", Slot = "8")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C260", Offset = "0x2A6B460", VA = "0x182A6C260", Slot = "9")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BD00", Offset = "0x2A6AF00", VA = "0x182A6BD00", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BE20", Offset = "0x2A6B020", VA = "0x182A6BE20", Slot = "6")]
	public bool EPNNAEJBDMB(FNOOJMKBHOH LKAENGEIFGG, out JDGJMEJMAJC HMGHGFKHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C280", Offset = "0x2A6B480", VA = "0x182A6C280")]
	private void MHDONBPAPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C610", Offset = "0x2A6B810", VA = "0x182A6C610")]
	private void NOONKDBIMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C980", Offset = "0x2A6BB80", VA = "0x182A6C980")]
	private OHBNOLPKNLP OICIAJGPIJB(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C1B0", Offset = "0x2A6B3B0", VA = "0x182A6C1B0")]
	private OHBNOLPKNLP KGDEAIHEIPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BF40", Offset = "0x2A6B140", VA = "0x182A6BF40")]
	private OHBNOLPKNLP GDMMKGPHBIJ(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C7B0", Offset = "0x2A6B9B0", VA = "0x182A6C7B0")]
	private OHBNOLPKNLP OCBEEGLJNPO(string BENGLHDIHMD, string AJDBKDIMOHA, [Optional] OHBNOLPKNLP IGPIJNKEGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BC90", Offset = "0x2A6AE90", VA = "0x182A6BC90")]
	[IteratorStateMachine(typeof(JJEPBHPMDEL))]
	private IEnumerable<(string, string)> DIKAHJNFDMF(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BA80", Offset = "0x2A6AC80", VA = "0x182A6BA80")]
	private bool AHCIGLFIHAG(FNOOJMKBHOH LKAENGEIFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BBB0", Offset = "0x2A6ADB0", VA = "0x182A6BBB0")]
	private CDKDMLIJPKH CHHKNICJNGB(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C210", Offset = "0x2A6B410", VA = "0x182A6C210")]
	private CDKDMLIJPKH GIDNEBEJCOO(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BEB0", Offset = "0x2A6B0B0", VA = "0x182A6BEB0")]
	private CDKDMLIJPKH FFKCNKNEOPH(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1D67590", Offset = "0x1D66790", VA = "0x181D67590")]
	private T POOMBALJPGK<T>(FNOOJMKBHOH LKAENGEIFGG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BAD0", Offset = "0x2A6ACD0", VA = "0x182A6BAD0")]
	private FieldInfo BLMGFOFAFHM(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CA40", Offset = "0x2A6BC40", VA = "0x182A6CA40")]
	public LAMGODIJFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BD90", Offset = "0x2A6AF90", VA = "0x182A6BD90")]
	[CompilerGenerated]
	private int EOLKGADHMGE(FNOOJMKBHOH FAMKPEGNHFC, FNOOJMKBHOH GPHMIGDKMEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class OHBNOLPKNLP : JDGJMEJMAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string ICINBCPMBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly OHBNOLPKNLP IGPIJNKEGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<OHBNOLPKNLP> PMKNEIGPLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<FNOOJMKBHOH> ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string KKLLJOOPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JDGJMEJMAJC PBOLBJKBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<JDGJMEJMAJC> KPJPFEOMAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<FNOOJMKBHOH> LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A74660", Offset = "0x2A73860", VA = "0x182A74660")]
	public OHBNOLPKNLP(string IGHJIHNAPBA, OHBNOLPKNLP GPFONCECPBK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[LOJIIDJFKAI(typeof(BDFDGLPPMOH), new string[] { })]
	[DENLLMODGFC(typeof(HistoryService))]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	public class HistoryService : DPDCPMNGBKH, IDisposable, BDFDGLPPMOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum DFJEOKIAIEF
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct LKPMGDMGEOD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly DFJEOKIAIEF GGFPKNAGICN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService IAFMOECNDHE;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x41C9810", Offset = "0x41C8A10", VA = "0x1841C9810")]
			public LKPMGDMGEOD(HistoryService IAFMOECNDHE, bool IKPNDPMFPFI, uint FLPPPNDNNNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x41C97E0", Offset = "0x41C89E0", VA = "0x1841C97E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class ELIPEMMEIFN
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct GEFMHJFHKOD : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly ELIPEMMEIFN OCOPNGDLHNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool NPPNMDKDEDG;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x41C5230", Offset = "0x41C4430", VA = "0x1841C5230")]
				public GEFMHJFHKOD(ELIPEMMEIFN OCOPNGDLHNC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x41C5200", Offset = "0x41C4400", VA = "0x1841C5200", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct OIPKJDFIGEK : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly ELIPEMMEIFN OCOPNGDLHNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool NPPNMDKDEDG;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x41CAB20", Offset = "0x41C9D20", VA = "0x1841CAB20")]
				public OIPKJDFIGEK(ELIPEMMEIFN OCOPNGDLHNC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x41C5200", Offset = "0x41C4400", VA = "0x1841C5200", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService HIOJLLPHGDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool MGFPEGPPAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int KLJNJIDEGGO;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x41C3E30", Offset = "0x41C3030", VA = "0x1841C3E30")]
			public ELIPEMMEIFN(HistoryService HIOJLLPHGDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x41C3E00", Offset = "0x41C3000", VA = "0x1841C3E00")]
			public bool PCCIFICCJAA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x41C3D60", Offset = "0x41C2F60", VA = "0x1841C3D60")]
			public OIPKJDFIGEK LJFEMNGILEK()
			{
				return default(OIPKJDFIGEK);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x41C3DB0", Offset = "0x41C2FB0", VA = "0x1841C3DB0")]
			public GEFMHJFHKOD MJDPJDPCHBC()
			{
				return default(GEFMHJFHKOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class DNOMCEFHJIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public DNOMCEFHJIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x41C3540", Offset = "0x41C2740", VA = "0x1841C3540")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class NKMFGDEAIDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public NKMFGDEAIDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x41C9DE0", Offset = "0x41C8FE0", VA = "0x1841C9DE0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class EGOBBPJJFIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public EGOBBPJJFIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x41C3D30", Offset = "0x41C2F30", VA = "0x1841C3D30")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction IMFIFDBIMNM;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction NGAPJBHGDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private KICCKOIDPBO FBDLPEHLAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer DFOCENHNIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer JIADBEGIKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private PLIJOECNIOG IDEOMAMPKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase EDDHBBFFICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService IENMAKNKOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private HHKCCBKAPBE CNNFEIHJDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DFJEOKIAIEF MIGKFHCPEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private ELIPEMMEIFN OCOPNGDLHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private KHFJEIHOPJL MBCIBOFNGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private NMLCFAIOCDK ABMHCNHPEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete KDBDLEAJFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint IACAHLNJKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint FGGEPMIEECJ;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private ELIPEMMEIFN GHPHKEKHMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool PAGHHEHABKO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x31AA620", Offset = "0x31A9820", VA = "0x1831AA620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool IEDOGAJLEBH
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x31AB330", Offset = "0x31AA530", VA = "0x1831AB330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool PBEPNNJPLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x31A99C0", Offset = "0x31A8BC0", VA = "0x1831A99C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int EHACICKFFNL
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x31AA9F0", Offset = "0x31A9BF0", VA = "0x1831AA9F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int PPLLIDPKOAK
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x31AA140", Offset = "0x31A9340", VA = "0x1831AA140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool CHIGAIKKHNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x31A99F0", Offset = "0x31A8BF0", VA = "0x1831A99F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool KPHEJEIJCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x31ABF50", Offset = "0x31AB150", VA = "0x1831ABF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool IAGBGFOGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x906DD0", Offset = "0x905FD0", VA = "0x180906DD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x1E53AE0", Offset = "0x1E52CE0", VA = "0x181E53AE0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer MIAEHIKBGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x31AA6A0", Offset = "0x31A98A0", VA = "0x1831AA6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action GBCBJIMDKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x31AA6B0", Offset = "0x31A98B0", VA = "0x1831AA6B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x31AB290", Offset = "0x31AA490", VA = "0x1831AB290", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action ADNPCOFOEMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x31AB900", Offset = "0x31AAB00", VA = "0x1831AB900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x31A9A00", Offset = "0x31A8C00", VA = "0x1831A9A00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x31ABA00", Offset = "0x31AAC00", VA = "0x1831ABA00", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x31A9EA0", Offset = "0x31A90A0", VA = "0x1831A9EA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x31AAB50", Offset = "0x31A9D50", VA = "0x1831AAB50")]
		private void HMOFDIEJHLD(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x31ABF30", Offset = "0x31AB130", VA = "0x1831ABF30")]
		private void PFPFPBBPDGG(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x31AAE50", Offset = "0x31AA050", VA = "0x1831AAE50")]
		private void IHIBAGEPFAJ(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x31AB9A0", Offset = "0x31AABA0", VA = "0x1831AB9A0", Slot = "14")]
		public IDisposable ODBIPMMOBCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x31A9AA0", Offset = "0x31A8CA0", VA = "0x1831A9AA0", Slot = "9")]
		public IDisposable CJIJKNNJGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x31AAA90", Offset = "0x31A9C90", VA = "0x1831AAA90", Slot = "6")]
		public UndoAction HAEGFBMAPFO()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x31AB720", Offset = "0x31AA920", VA = "0x1831AB720", Slot = "15")]
		public RedoAction MIKKEMNJLJG()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x31AB3D0", Offset = "0x31AA5D0", VA = "0x1831AB3D0", Slot = "16")]
		public UndoAction KOONLPPNMFN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x31AB7E0", Offset = "0x31AA9E0", VA = "0x1831AB7E0", Slot = "7")]
		public RedoAction MIKKEMNJLJG(UndoAction MOOHJICILGA)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x31AB490", Offset = "0x31AA690", VA = "0x1831AB490", Slot = "8")]
		public UndoAction KOONLPPNMFN(RedoAction MOOHJICILGA)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x31AACD0", Offset = "0x31A9ED0", VA = "0x1831AACD0")]
		public bool HOFLJALMCGD(BHILBDPNLIE DMKJPKCHIMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x31AA750", Offset = "0x31A9950", VA = "0x1831AA750", Slot = "17")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x31A9B00", Offset = "0x31A8D00", VA = "0x1831A9B00")]
		public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x31AA880", Offset = "0x31A9A80", VA = "0x1831AA880")]
		public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF FPEGOFLFPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x31AB110", Offset = "0x31AA310", VA = "0x1831AB110")]
		public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x31A9E00", Offset = "0x31A9000", VA = "0x1831A9E00")]
		private void DFKMOENDAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x31AA160", Offset = "0x31A9360", VA = "0x1831AA160")]
		private void EGJFCNKFFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x31AA680", Offset = "0x31A9880", VA = "0x1831AA680")]
		private void FJFFJKGMDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x31AAD50", Offset = "0x31A9F50", VA = "0x1831AAD50")]
		private PEMAAMNAJKO IDCKDKMJMJJ()
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x31AB700", Offset = "0x31AA900", VA = "0x1831AB700")]
		private uint LLDKACHCJFB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x31AAD10", Offset = "0x31A9F10", VA = "0x1831AAD10")]
		private bool HOPBJEJDLBP(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x31AAD30", Offset = "0x31A9F30", VA = "0x1831AAD30")]
		private bool ICFLFPDOEOH(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x31AA5C0", Offset = "0x31A97C0", VA = "0x1831AA5C0")]
		private RedoAction EOCMBBAJLIF(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x31A9E40", Offset = "0x31A9040", VA = "0x1831A9E40")]
		private UndoAction DLPEAKDNOAK(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x31AA300", Offset = "0x31A9500", VA = "0x1831AA300")]
		private PEMAAMNAJKO EKNKCODIAPH(PEMAAMNAJKO GPNJNMLGIEN, ActionBuffer BHAPIDPHJEE, bool IKPNDPMFPFI)
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x31AA7A0", Offset = "0x31A99A0", VA = "0x1831AA7A0")]
		private void GFJGKDFJBDJ(Action GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2888700", Offset = "0x2887900", VA = "0x182888700")]
		private T GFJGKDFJBDJ<T>(Func<T> JHCJMGCFBCP)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x31AA9C0", Offset = "0x31A9BC0", VA = "0x1831AA9C0")]
		private LKPMGDMGEOD GIFJGJOFPKI(bool IKPNDPMFPFI, uint FLPPPNDNNNB)
		{
			return default(LKPMGDMGEOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x31AC040", Offset = "0x31AB240", VA = "0x1831AC040")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x31AB5B0", Offset = "0x31AA7B0", VA = "0x1831AB5B0")]
		[CompilerGenerated]
		private UndoAction KPAABNNJMKI()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x31A9C90", Offset = "0x31A8E90", VA = "0x1831A9C90")]
		[CompilerGenerated]
		private RedoAction DACECIFLHPL()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x31AA1A0", Offset = "0x31A93A0", VA = "0x1831AA1A0")]
		[CompilerGenerated]
		private UndoAction EHOPDFBNLPM()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GKIKIIPHIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public GKIKIIPHIPD(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x31A64A0", Offset = "0x31A56A0", VA = "0x1831A64A0")]
	public static GKIKIIPHIPD LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T JHODGLELKOI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> DPECBKGPLOG<T>(int ONCBCCLEFOH, Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> MPJNBOANJGK<T>(Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OEANOHNOMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public OEANOHNOMHP(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2A74590", Offset = "0x2A73790", VA = "0x182A74590")]
	public static OEANOHNOMHP LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x29A0330", Offset = "0x299F530", VA = "0x1829A0330")]
	public T JHODGLELKOI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> DPECBKGPLOG<T>(int ONCBCCLEFOH, Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LCCMDDNOBCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public LCCMDDNOBCP(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CBB0", Offset = "0x2A6BDB0", VA = "0x182A6CBB0")]
	public static LCCMDDNOBCP LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x1D675D0", Offset = "0x1D667D0", VA = "0x181D675D0")]
	public void ALJMGCDBJBG<T>(in T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x1D67630", Offset = "0x1D66830", VA = "0x181D67630")]
	public void LEFCNKJGCHI<T>(NativeArray<T> NKOMPJIJHJB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void OBMILPHCIJL<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LKJPPNCAKLD
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EBB0", Offset = "0x2A6DDB0", VA = "0x182A6EBB0")]
	public static Span<byte> OLCIBMEHNBL(this NativeArray<byte> PFCDNINKMFA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EA30", Offset = "0x2A6DC30", VA = "0x182A6EA30")]
	public static ReadOnlySpan<byte> OEKPMDLKKCJ(this NativeArray<byte> PFCDNINKMFA)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E9B0", Offset = "0x2A6DBB0", VA = "0x182A6E9B0")]
	public static NativeArray<byte> OALHLDFIGLH(this NativeArray<byte> PFCDNINKMFA, int IDCHKLCNMBN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E8B0", Offset = "0x2A6DAB0", VA = "0x182A6E8B0")]
	public static NativeArray<byte> FIOKLPGGCOI(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x305F0F0", Offset = "0x305E2F0", VA = "0x18305F0F0")]
	public static NativeArray<byte> FIOKLPGGCOI<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E840", Offset = "0x2A6DA40", VA = "0x182A6E840")]
	public static NativeArray<byte> EAHICGLGAKH(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1D69740", Offset = "0x1D68940", VA = "0x181D69740")]
	public static NativeArray<byte> EAHICGLGAKH<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E930", Offset = "0x2A6DB30", VA = "0x182A6E930")]
	public static NativeArray<byte> NJDCDEMHAGN(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x305F150", Offset = "0x305E350", VA = "0x18305F150")]
	public static NativeArray<byte> NJDCDEMHAGN<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KJNFLEBIMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xCD29C0", Offset = "0xCD1BC0", VA = "0x180CD29C0")]
	public KJNFLEBIMHD(NativeList<byte> NHOGENNANEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x31B49C0", Offset = "0x31B3BC0", VA = "0x1831B49C0")]
	public static KJNFLEBIMHD LOJIFGBJNLM(NativeList<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void ALJMGCDBJBG<T>(in T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void LEFCNKJGCHI<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void OBMILPHCIJL<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	public class PropertyChangeNetworkRouter : LFPMKPLIAAM, DPDCPMNGBKH, FNFKCLIHOKN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[IMNMHIBEIDL]
		private DOKECPFELPH ABIHDCBCABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[IMNMHIBEIDL]
		private KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[IMNMHIBEIDL]
		private INBLIGACKIF IIIFHEOJELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[IMNMHIBEIDL]
		private PropertyChangeRouterService IENMAKNKOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KICCKOIDPBO BEKIFNKENPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private CCIMPJPAJHL HBPEOGPLFPI;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public KICCKOIDPBO LJAACKPJCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2A89750", Offset = "0x2A88950", VA = "0x182A89750")]
		public KICCKOIDPBO.POAGGECHELL ABEBGHBCBGI()
		{
			return default(KICCKOIDPBO.POAGGECHELL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FD0", Offset = "0x2A891D0", VA = "0x182A89FD0", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A130", Offset = "0x2A89330", VA = "0x182A8A130", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2A89770", Offset = "0x2A88970", VA = "0x182A89770", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2A899E0", Offset = "0x2A88BE0", VA = "0x182A899E0")]
		public void HAEGFBMAPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2A899C0", Offset = "0x2A88BC0", VA = "0x182A899C0")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2A89AF0", Offset = "0x2A88CF0", VA = "0x182A89AF0")]
		private void HOBIDCFJFHC(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A3B0", Offset = "0x2A895B0", VA = "0x182A8A3B0")]
		private void PHMEIEFBAHO(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2A89990", Offset = "0x2A88B90", VA = "0x182A89990")]
		private void EDIJBNLFNNB(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B20", Offset = "0x2A88D20", VA = "0x182A89B20")]
		private void HPNHJJMBODC(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2A89E00", Offset = "0x2A89000", VA = "0x182A89E00")]
		private void JEFDJMPFGLA(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A050", Offset = "0x2A89250", VA = "0x182A8A050")]
		private void OHDCLCGLONB(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A030", Offset = "0x2A89230", VA = "0x182A8A030")]
		private void MHHBNKIPINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A110", Offset = "0x2A89310", VA = "0x182A8A110")]
		private void OMGFPDIACBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2A89F30", Offset = "0x2A89130", VA = "0x182A89F30")]
		private void JHCOENKOCAI(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x34ED9B0", Offset = "0x34ECBB0", VA = "0x1834ED9B0", Slot = "6")]
		private void HLKHCGJKOIB<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, object MAFDHEKFLMG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void AEGFCBECNHF(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void JMDPFAEGJMH(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void IMPPIOPKKDP(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AEGFCBECNHF BFPHDDBHNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JMDPFAEGJMH HLGHGIGOMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IMPPIOPKKDP ACJHDFNHANL;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A440", Offset = "0x2A89640", VA = "0x182A8A440")]
		public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A460", Offset = "0x2A89660", VA = "0x182A8A460")]
		public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A4D0", Offset = "0x2A896D0", VA = "0x182A8A4D0")]
		public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(HOMCFAPIGOG))]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class HOMCFAPIGOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer IEGPGBKLAIF;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int HGPJFHAOHMD
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2CB5800", Offset = "0x2CB4A00", VA = "0x182CB5800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public DANDHMMDDOH[] OEHNIAOIBPD
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2CB5730", Offset = "0x2CB4930", VA = "0x182CB5730")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
			public HOMCFAPIGOG(ActionBuffer MPHDAOEKEHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5850", Offset = "0x2CB4A50", VA = "0x182CB5850")]
			[CompilerGenerated]
			private DANDHMMDDOH NPHPNLEMNLA(PEMAAMNAJKO GPNJNMLGIEN)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class DANDHMMDDOH : FNFKCLIHOKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer IEGPGBKLAIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly PEMAAMNAJKO GPNJNMLGIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(CCIMPJPAJHL, string, object)> IPILJEFIHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private OEANOHNOMHP OJMODHIKFDB;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int HGPJFHAOHMD
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2CB4720", Offset = "0x2CB3920", VA = "0x182CB4720")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(CCIMPJPAJHL, string, object)> HGPBPBGNLKC
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4770", Offset = "0x2CB3970", VA = "0x182CB4770")]
			public DANDHMMDDOH(ActionBuffer MPHDAOEKEHO, PEMAAMNAJKO GPNJNMLGIEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4620", Offset = "0x2CB3820", VA = "0x182CB4620")]
			private string KPEDCJCNFLM(CCIMPJPAJHL HBPEOGPLFPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2CB42E0", Offset = "0x2CB34E0", VA = "0x182CB42E0")]
			private void HBGEMGCKMHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x273B110", Offset = "0x273A310", VA = "0x18273B110", Slot = "4")]
			public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> FFEKEOCBAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<PEMAAMNAJKO> PEEPHJNAIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly HLBOLBJCEGO PLGAGPOFHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool ACDKBAAEDMN;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public GCHHEAHPBFM CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C42650", Offset = "0x2C41850", VA = "0x182C42650")]
			get
			{
				return default(GCHHEAHPBFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C42690", Offset = "0x2C41890", VA = "0x182C42690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C42890", Offset = "0x2C41A90", VA = "0x182C42890")]
		public ActionBuffer(DEMIGFIOEMK GIPMDGDJGML, KJEMHJEIOEO ELCMIPNJFNP, bool ACDKBAAEDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C41BC0", Offset = "0x2C40DC0", VA = "0x182C41BC0")]
		public bool BINFABIFFJD(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C42210", Offset = "0x2C41410", VA = "0x182C42210")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C42340", Offset = "0x2C41540", VA = "0x182C42340")]
		public PEMAAMNAJKO HAEGFBMAPFO(ALALGBOOEMC IPILJEFIHFH, HHKCCBKAPBE CNNFEIHJDFO, uint PHOHCIEDGIF)
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C42620", Offset = "0x2C41820", VA = "0x182C42620")]
		public bool LDDPJIPNHAD(uint PHOHCIEDGIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C41C50", Offset = "0x2C40E50", VA = "0x182C41C50")]
		public bool DLOPDOOGOAA(uint PHOHCIEDGIF, out PEMAAMNAJKO MOOHJICILGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C426D0", Offset = "0x2C418D0", VA = "0x182C426D0")]
		public void PGHOCHJBOPI(PEMAAMNAJKO MOOHJICILGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C42480", Offset = "0x2C41680", VA = "0x182C42480")]
		[Conditional("DEBUG_BUILD")]
		private void IGPEIHMAKID(PEMAAMNAJKO MOOHJICILGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C41EB0", Offset = "0x2C410B0", VA = "0x182C41EB0")]
		private void EKNKCODIAPH(PEMAAMNAJKO EFILEMBEAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C41FC0", Offset = "0x2C411C0", VA = "0x182C41FC0")]
		private void ENBBJHMPPNL(OEANOHNOMHP LMBOEDLDGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C425C0", Offset = "0x2C417C0", VA = "0x182C425C0")]
		private void JIAGLDBMOAA(PEMAAMNAJKO GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C42280", Offset = "0x2C41480", VA = "0x182C42280")]
		private OEANOHNOMHP GKDJAKPINJK(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C41E40", Offset = "0x2C41040", VA = "0x182C41E40", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class HLBOLBJCEGO : FNFKCLIHOKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly DEMIGFIOEMK GIPMDGDJGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private IOLFAAOECPP ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private OEANOHNOMHP GLBHCLELODD;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C76E0", Offset = "0x6C68E0", VA = "0x1806C76E0")]
	public HLBOLBJCEGO(DEMIGFIOEMK GIPMDGDJGML, KJEMHJEIOEO ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x287E7F0", Offset = "0x287D9F0", VA = "0x18287E7F0", Slot = "4")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> FCACNCCFEGJ, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x31A8090", Offset = "0x31A7290", VA = "0x1831A8090")]
	public void OKJGILDOJEJ(CCIMPJPAJHL HBPEOGPLFPI, ref OEANOHNOMHP LMBOEDLDGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class KICCKOIDPBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct POAGGECHELL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly KICCKOIDPBO GPFONCECPBK;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x41CBA40", Offset = "0x41CAC40", VA = "0x1841CBA40")]
		public POAGGECHELL(KICCKOIDPBO GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x41CBA20", Offset = "0x41CAC20", VA = "0x1841CBA20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected ALALGBOOEMC IPILJEFIHFH;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public ALALGBOOEMC HGPBPBGNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x30BFBC0", Offset = "0x30BEDC0", VA = "0x1830BFBC0")]
		get
		{
			return default(ALALGBOOEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool NEMJFHADGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x31B4530", Offset = "0x31B3730", VA = "0x1831B4530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x31B4540", Offset = "0x31B3740", VA = "0x1831B4540")]
	public KICCKOIDPBO(ALALGBOOEMC.GOPDKOCOPDJ EJKKBCGPHEE = ALALGBOOEMC.GOPDKOCOPDJ.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x31B41B0", Offset = "0x31B33B0", VA = "0x1831B41B0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x31B40B0", Offset = "0x31B32B0", VA = "0x1831B40B0")]
	public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x31B41C0", Offset = "0x31B33C0", VA = "0x1831B41C0")]
	public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x31B4250", Offset = "0x31B3450", VA = "0x1831B4250")]
	public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x31B4330", Offset = "0x31B3530", VA = "0x1831B4330")]
	public void MHHBNKIPINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x31B4430", Offset = "0x31B3630", VA = "0x1831B4430")]
	public void OMGFPDIACBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x31B41A0", Offset = "0x31B33A0", VA = "0x1831B41A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x31B4080", Offset = "0x31B3280", VA = "0x1831B4080")]
	public POAGGECHELL ABEBGHBCBGI()
	{
		return default(POAGGECHELL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct CCIMPJPAJHL : IComparable<CCIMPJPAJHL>, IEquatable<CCIMPJPAJHL>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly CCIMPJPAJHL BAMMNFGMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public IOLFAAOECPP ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public NMLCFAIOCDK MPKOBDPILJB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26B0", Offset = "0x2AA18B0", VA = "0x182AA26B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
	public CCIMPJPAJHL(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C47A40", Offset = "0x2C46C40", VA = "0x182C47A40")]
	public void NDAJBIBMBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C47890", Offset = "0x2C46A90", VA = "0x182C47890", Slot = "4")]
	public int CompareTo(CCIMPJPAJHL IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C47A50", Offset = "0x2C46C50", VA = "0x182C47A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C478D0", Offset = "0x2C46AD0", VA = "0x182C478D0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C47970", Offset = "0x2C46B70", VA = "0x182C47970", Slot = "5")]
	public bool Equals(CCIMPJPAJHL IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C479C0", Offset = "0x2C46BC0", VA = "0x182C479C0")]
	public static bool GJOJIEKGOHO(CCIMPJPAJHL KPCLHBOMAKO, CCIMPJPAJHL NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C47840", Offset = "0x2C46A40", VA = "0x182C47840")]
	public static bool ALCENKEOHOJ(CCIMPJPAJHL KPCLHBOMAKO, CCIMPJPAJHL NFBNADMIDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C47A00", Offset = "0x2C46C00", VA = "0x182C47A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	public class GatherPropertiesForUndelete : JLMGPHFMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IOLFAAOECPP ONBAMHPEIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService HIOJLLPHGDG;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x31A6F70", Offset = "0x31A6170", VA = "0x1831A6F70")]
		public void NMKBKFBFGOP(IOLFAAOECPP ONBAMHPEIDG, DEMIGFIOEMK GIPMDGDJGML, HistoryService HIOJLLPHGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x31A6EA0", Offset = "0x31A60A0", VA = "0x1831A6EA0", Slot = "4")]
		private void BFNDAHKEBGF(ANOLFBPNBLO LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class JLIAFGMGBJM
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x31B0C30", Offset = "0x31AFE30", VA = "0x1831B0C30")]
	public static void JEFDJMPFGLA(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI, FANLJDFBPKN MBIBEFAMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x31B0B70", Offset = "0x31AFD70", VA = "0x1831B0B70")]
	public static void DAMGKKIFOLP(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x31B0DE0", Offset = "0x31AFFE0", VA = "0x1831B0DE0")]
	public static void OHDCLCGLONB(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x31B0D30", Offset = "0x31AFF30", VA = "0x1831B0D30")]
	public static void NDODCGNGBKC(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x31B0E30", Offset = "0x31B0030", VA = "0x1831B0E30")]
	public static FANLJDFBPKN PMEBGDJLACB(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
		return default(FANLJDFBPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D55BC0", Offset = "0x1D54DC0", VA = "0x181D55BC0")]
	public static T CKKFDFCIEFG<T>(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D55BE0", Offset = "0x1D54DE0", VA = "0x181D55BE0")]
	public static T CKKFDFCIEFG<T>(ref OEANOHNOMHP ONIBEFDCPGD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x31B0E80", Offset = "0x31B0080", VA = "0x1831B0E80")]
	public static FANLJDFBPKN PMEBGDJLACB(ref OEANOHNOMHP ONIBEFDCPGD)
	{
		return default(FANLJDFBPKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct ALALGBOOEMC : IEnumerable<CCIMPJPAJHL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum GOPDKOCOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct JJEGPKJBOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly HHKCCBKAPBE CNNFEIHJDFO;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6430", Offset = "0x2CB5630", VA = "0x182CB6430")]
		public JJEGPKJBOBJ(ALALGBOOEMC NHOGENNANEB, HHKCCBKAPBE CNNFEIHJDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5B20", Offset = "0x2CB4D20", VA = "0x182CB5B20")]
		public void CIHMCFCGMLC(NativeList<byte> DMEDBCCHBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5EB0", Offset = "0x2CB50B0", VA = "0x182CB5EB0")]
		private void FFCGDHECPCH(CCIMPJPAJHL HBPEOGPLFPI, ref LCCMDDNOBCP JBKCJIDDIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6060", Offset = "0x2CB5260", VA = "0x182CB6060")]
		private void KNCOLNDKFHN(CCIMPJPAJHL HBPEOGPLFPI, ref LCCMDDNOBCP JBKCJIDDIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6340", Offset = "0x2CB5540", VA = "0x182CB6340")]
		private NativeArray<byte> NPOCLKELBNJ(NativeList<byte> DMEDBCCHBBH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5DC0", Offset = "0x2CB4FC0", VA = "0x182CB5DC0")]
		private NativeArray<byte> EOKEFNHNLJG(NativeList<byte> DMEDBCCHBBH, int ONCBCCLEFOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB60F0", Offset = "0x2CB52F0", VA = "0x182CB60F0")]
		private int LHNNBAPOCFM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5F00", Offset = "0x2CB5100", VA = "0x182CB5F00")]
		private bool KMIENPALEIC(CCIMPJPAJHL HBPEOGPLFPI, out NativeArray<byte> DPICFNCJJBK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct MCEFNHMLAKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> ONIBEFDCPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly CCIMPJPAJHL GEMNKBDIDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int IDCHKLCNMBN;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6B00", Offset = "0x2CB5D00", VA = "0x182CB6B00")]
		internal MCEFNHMLAKC(ALALGBOOEMC NHOGENNANEB, CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB68E0", Offset = "0x2CB5AE0", VA = "0x182CB68E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6880", Offset = "0x2CB5A80", VA = "0x182CB6880")]
		public void DEJKDLAENFK(NativeArray<byte> JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6A90", Offset = "0x2CB5C90", VA = "0x182CB6A90")]
		public void JFIENPDMMBG(NativeArray<byte> JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6AF0", Offset = "0x2CB5CF0", VA = "0x182CB6AF0")]
		public void KNCOLNDKFHN(in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2744F40", Offset = "0x2744140", VA = "0x182744F40")]
		public void KNCOLNDKFHN<T>(T JFBPNBNBHOE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6970", Offset = "0x2CB5B70", VA = "0x182CB6970")]
		private void FOAOMDBAOHB(int JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2CB69E0", Offset = "0x2CB5BE0", VA = "0x182CB69E0")]
		private void FOAOMDBAOHB(in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6910", Offset = "0x2CB5B10", VA = "0x182CB6910")]
		private unsafe void FOAOMDBAOHB(void* FLICKNNFHAA, int ONCBCCLEFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6880", Offset = "0x2CB5A80", VA = "0x182CB6880")]
		private void FOAOMDBAOHB(NativeArray<byte> NKOMPJIJHJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct EODLNMOBMDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> ONIBEFDCPGD;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4DB0", Offset = "0x2CB3FB0", VA = "0x182CB4DB0")]
		internal EODLNMOBMDE(ALALGBOOEMC NHOGENNANEB, NativeArray<byte> ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4BB0", Offset = "0x2CB3DB0", VA = "0x182CB4BB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4AF0", Offset = "0x2CB3CF0", VA = "0x182CB4AF0")]
		public NativeArray<byte> DPECBKGPLOG(int ONCBCCLEFOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4CC0", Offset = "0x2CB3EC0", VA = "0x182CB4CC0")]
		public NativeArray<byte> MPJNBOANJGK()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2743AB0", Offset = "0x2742CB0", VA = "0x182743AB0")]
		public T JHODGLELKOI<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4BC0", Offset = "0x2CB3DC0", VA = "0x182CB4BC0")]
		public void JHODGLELKOI(in EGIBCKCHGAP JFBPNBNBHOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NMMMNIKHKPO : IEnumerator<CCIMPJPAJHL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<CCIMPJPAJHL> PFCDNINKMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public CCIMPJPAJHL CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6D90", Offset = "0x2CB5F90", VA = "0x182CB6D90", Slot = "4")]
			get
			{
				return default(CCIMPJPAJHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6D40", Offset = "0x2CB5F40", VA = "0x182CB6D40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6D80", Offset = "0x2CB5F80", VA = "0x182CB6D80")]
		internal NMMMNIKHKPO(NativeList<CCIMPJPAJHL> NKOMPJIJHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6C00", Offset = "0x2CB5E00", VA = "0x182CB6C00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6D00", Offset = "0x2CB5F00", VA = "0x182CB6D00", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct FFDMOACLIHD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int DKKOKNDFFPL = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int PEPCOBLJABP = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int KEFAHABMMDO = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> ONIBEFDCPGD;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool DJGPJELDCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4E20", Offset = "0x2CB4020", VA = "0x182CB4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int JNPKCAINCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4E00", Offset = "0x2CB4000", VA = "0x182CB4E00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4E60", Offset = "0x2CB4060", VA = "0x182CB4E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public GOPDKOCOPDJ NEDNAFFINCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4E10", Offset = "0x2CB4010", VA = "0x182CB4E10")]
			get
			{
				return default(GOPDKOCOPDJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4F70", Offset = "0x2CB4170", VA = "0x182CB4F70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool NEMJFHADGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4F60", Offset = "0x2CB4160", VA = "0x182CB4F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4F40", Offset = "0x2CB4140", VA = "0x182CB4F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool FOMNBAIADFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4DF0", Offset = "0x2CB3FF0", VA = "0x182CB4DF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4F20", Offset = "0x2CB4120", VA = "0x182CB4F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4F80", Offset = "0x2CB4180", VA = "0x182CB4F80")]
		public FFDMOACLIHD(GOPDKOCOPDJ EJKKBCGPHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4EF0", Offset = "0x2CB40F0", VA = "0x182CB4EF0")]
		private int JLPNHBINJFC(int ELOEOOGBENM, int MBMFKBJGMMJ = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4EB0", Offset = "0x2CB40B0", VA = "0x182CB4EB0")]
		private void HDECKBNAIGA(int ELOEOOGBENM, int JFBPNBNBHOE, int MBMFKBJGMMJ = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4E70", Offset = "0x2CB4070", VA = "0x182CB4E70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int JIFFGBMDDME = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int MFPNPFGPMAI = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly CCIMPJPAJHL BJIDDCOKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<CCIMPJPAJHL, int> NBLBCGJAPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<CCIMPJPAJHL> IPILJEFIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> PPNJBNFDHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> NEAHAHDJDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private FFDMOACLIHD OOMECLFFJIL;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NEMJFHADGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C41940", Offset = "0x2C40B40", VA = "0x182C41940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HCBAHJPCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C40E70", Offset = "0x2C40070", VA = "0x182C40E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int JNPKCAINCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C40ED0", Offset = "0x2C400D0", VA = "0x182C40ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int AGGNFCFKFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C40F20", Offset = "0x2C40120", VA = "0x182C40F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C40EE0", Offset = "0x2C400E0", VA = "0x182C40EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C40E90", Offset = "0x2C40090", VA = "0x182C40E90")]
	public static ALALGBOOEMC BFPHDDBHNEE(GOPDKOCOPDJ EJKKBCGPHEE = GOPDKOCOPDJ.Last, int BFAHCFGPDMG = 16, int FJBJGPOOKJP = 256)
	{
		return default(ALALGBOOEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C41A50", Offset = "0x2C40C50", VA = "0x182C41A50")]
	private ALALGBOOEMC(GOPDKOCOPDJ EJKKBCGPHEE, int BFAHCFGPDMG, int FJBJGPOOKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C40F60", Offset = "0x2C40160", VA = "0x182C40F60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C41210", Offset = "0x2C40410", VA = "0x182C41210")]
	public MCEFNHMLAKC HPNHJJMBODC(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(MCEFNHMLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C414E0", Offset = "0x2C406E0", VA = "0x182C414E0")]
	public EODLNMOBMDE KABLBGKPIHD(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(EODLNMOBMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C412A0", Offset = "0x2C404A0", VA = "0x182C412A0")]
	public bool JAMNKAIEBOF(CCIMPJPAJHL GEMNKBDIDNJ, out EODLNMOBMDE CBLJIOEJBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C41490", Offset = "0x2C40690", VA = "0x182C41490")]
	public bool JHPECFFAFKJ(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C40DA0", Offset = "0x2C3FFA0", VA = "0x182C40DA0")]
	public bool AIKPBEDHLII(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C41850", Offset = "0x2C40A50", VA = "0x182C41850")]
	public void OJOFAMDPLDM(NativeList<byte> DMEDBCCHBBH, HHKCCBKAPBE CNNFEIHJDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x26AA9B0", Offset = "0x26A9BB0", VA = "0x1826AA9B0")]
	public T HNFKECKMLCA<T>(CCIMPJPAJHL GEMNKBDIDNJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C41040", Offset = "0x2C40240", VA = "0x182C41040")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C40D60", Offset = "0x2C3FF60", VA = "0x182C40D60")]
	public NMMMNIKHKPO AHIPNMLLDNB()
	{
		return default(NMMMNIKHKPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C41570", Offset = "0x2C40770", VA = "0x182C41570")]
	private void MPLAGIPNCOK(CCIMPJPAJHL GEMNKBDIDNJ, int IDCHKLCNMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C41760", Offset = "0x2C40960", VA = "0x182C41760")]
	private void NDAJBIBMBCB(int BBOJBAGCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C41120", Offset = "0x2C40320", VA = "0x182C41120")]
	private void HFGOMNHDNKM(CCIMPJPAJHL GEMNKBDIDNJ, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x26AA930", Offset = "0x26A9B30", VA = "0x1826AA930")]
	private static T HNFKECKMLCA<T>(NativeArray<byte> PFCDNINKMFA, int ELOEOOGBENM = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2C41990", Offset = "0x2C40B90", VA = "0x182C41990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2C41950", Offset = "0x2C40B50", VA = "0x182C41950", Slot = "4")]
	private IEnumerator<CCIMPJPAJHL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class GAAMFIAGDKH<T> : DHDEFGPGMMG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0F40", Offset = "0x3CF0140", VA = "0x183CF0F40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1060", Offset = "0x3CF0260", VA = "0x183CF1060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2FD8880", Offset = "0x2FD7A80", VA = "0x182FD8880")]
	public GAAMFIAGDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	internal class CleanupRigidbodyExImpl : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B690", Offset = "0x2C4A890", VA = "0x182C4B690", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B730", Offset = "0x2C4A930", VA = "0x182C4B730", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class DGIAAKMIKDF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery FJLHJPALFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2C565C0", Offset = "0x2C557C0", VA = "0x182C565C0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2C564F0", Offset = "0x2C556F0", VA = "0x182C564F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2C56580", Offset = "0x2C55780", VA = "0x182C56580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public DGIAAKMIKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal class OIAEJHDACNH : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService CFGDKDNFKAH;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2A747D0", Offset = "0x2A739D0", VA = "0x182A747D0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74760", Offset = "0x2A73960", VA = "0x182A74760", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public OIAEJHDACNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2C59C40", Offset = "0x2C58E40", VA = "0x182C59C40", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2C59790", Offset = "0x2C58990", VA = "0x182C59790", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2C59820", Offset = "0x2C58A20", VA = "0x182C59820", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[LOJIIDJFKAI(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<MMJDEMOFKKF>> EAPAOOBBMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2C54CB0", Offset = "0x2C53EB0", VA = "0x182C54CB0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2C54C40", Offset = "0x2C53E40", VA = "0x182C54C40")]
		public void MGAFJABNDCK(NativeListAsync<MMJDEMOFKKF> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2C547D0", Offset = "0x2C539D0", VA = "0x182C547D0")]
		public void KGABBKPALAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2C54660", Offset = "0x2C53860", VA = "0x182C54660", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2C54D50", Offset = "0x2C53F50", VA = "0x182C54D50")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LOJIIDJFKAI(typeof(LKGNBGJGHAA), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class PhysicsService : DPDCPMNGBKH, FPHKGEBJIKC, LKGNBGJGHAA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly FADHLPPNOEF PAPLKBBKEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private DPHIHEMGLPB ADPNILAIFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService FMKAHEFPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::DEHNDDIKMEN<DIKGCJEICCJ> LKCFENLBOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<NFJEDPPAJMK, DIKGCJEICCJ> INAMCGAFDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2A87080", Offset = "0x2A86280", VA = "0x182A87080", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2A86990", Offset = "0x2A85B90", VA = "0x182A86990", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2A87120", Offset = "0x2A86320", VA = "0x182A87120", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2A86DE0", Offset = "0x2A85FE0", VA = "0x182A86DE0", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2A86BC0", Offset = "0x2A85DC0", VA = "0x182A86BC0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2A86AF0", Offset = "0x2A85CF0", VA = "0x182A86AF0", Slot = "8")]
		public bool AMCAKIHCKGA(NFJEDPPAJMK OOGHONKGHEE, out Collider NCCADNBJIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A86D20", Offset = "0x2A85F20", VA = "0x182A86D20")]
		private void FDKAHKLMLOJ(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2A86A30", Offset = "0x2A85C30", VA = "0x182A86A30", Slot = "9")]
		public void AEBBADBLPIF(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[LOJIIDJFKAI(typeof(MCAEHJPOCLP), new string[] { })]
	public class RbexService : DPDCPMNGBKH, MCAEHJPOCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private LEPGAPILAAM ACPBAMPBPGO;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2A8DAA0", Offset = "0x2A8CCA0", VA = "0x182A8DAA0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F250", Offset = "0x2A8E450", VA = "0x182A8F250", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C710", Offset = "0x2A8B910", VA = "0x182A8C710", Slot = "6")]
		public MGDHAHFMJMO DBAHGJMLEGP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C290", Offset = "0x2A8B490", VA = "0x182A8C290", Slot = "5")]
		public void BMNPJDBGHKP(NFJEDPPAJMK OOGHONKGHEE, MGDHAHFMJMO JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EFD0", Offset = "0x2A8E1D0", VA = "0x182A8EFD0", Slot = "34")]
		public CollisionDetectionMode ODOCPGENJJP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C500", Offset = "0x2A8B700", VA = "0x182A8C500", Slot = "35")]
		public void CLNFHJJLLKH(NFJEDPPAJMK OOGHONKGHEE, CollisionDetectionMode JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E350", Offset = "0x2A8D550", VA = "0x182A8E350", Slot = "36")]
		public PPGNAFCKNOL LFBLAICLCNJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(PPGNAFCKNOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C1F0", Offset = "0x2A8B3F0", VA = "0x182A8C1F0", Slot = "37")]
		public void AIILPFAOLOH(NFJEDPPAJMK OOGHONKGHEE, PPGNAFCKNOL JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CEF0", Offset = "0x2A8C0F0", VA = "0x182A8CEF0", Slot = "38")]
		public bool FBGNHJDEDMJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CF50", Offset = "0x2A8C150", VA = "0x182A8CF50", Slot = "39")]
		public void FEFBHBDEPKJ(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EA90", Offset = "0x2A8DC90", VA = "0x182A8EA90", Slot = "40")]
		public NFJEDPPAJMK MNEECNHBEJG(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E260", Offset = "0x2A8D460", VA = "0x182A8E260", Slot = "41")]
		public void KLFLFGBKAAA(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EB10", Offset = "0x2A8DD10", VA = "0x182A8EB10", Slot = "42")]
		public NFJEDPPAJMK MODGPLDICAF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E070", Offset = "0x2A8D270", VA = "0x182A8E070", Slot = "43")]
		public void KKGLFGKJMPP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D120", Offset = "0x2A8C320", VA = "0x182A8D120", Slot = "7")]
		public void FIMHIJJNHNG(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E640", Offset = "0x2A8D840", VA = "0x182A8E640", Slot = "8")]
		public void LNGINODJAIF(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D330", Offset = "0x2A8C530", VA = "0x182A8D330", Slot = "9")]
		public int FJOEJBEAIPG(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DDD0", Offset = "0x2A8CFD0", VA = "0x182A8DDD0", Slot = "10")]
		public NFJEDPPAJMK JIABEAAPFBL(NFJEDPPAJMK OOGHONKGHEE, int BELCAJFDAHD)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E0F0", Offset = "0x2A8D2F0", VA = "0x182A8E0F0", Slot = "11")]
		public void KKKGMHHOEFC(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CD30", Offset = "0x2A8BF30", VA = "0x182A8CD30", Slot = "12")]
		public void EMFHKCCJCMI(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D230", Offset = "0x2A8C430", VA = "0x182A8D230", Slot = "13")]
		public void FIOINIIBKGK(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F360", Offset = "0x2A8E560", VA = "0x182A8F360", Slot = "14")]
		public bool PIDIPMJBGDP(NFJEDPPAJMK OOGHONKGHEE, out NFJEDPPAJMK JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DFF0", Offset = "0x2A8D1F0", VA = "0x182A8DFF0", Slot = "15")]
		public void KCCGBFPMPGL(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D5D0", Offset = "0x2A8C7D0", VA = "0x182A8D5D0", Slot = "16")]
		public bool GGNEONIMNFF(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EA10", Offset = "0x2A8DC10", VA = "0x182A8EA10", Slot = "17")]
		public void MJNLDDJEFNO(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EDE0", Offset = "0x2A8DFE0", VA = "0x182A8EDE0", Slot = "18")]
		public bool OAIBMAKBCBG(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E1E0", Offset = "0x2A8D3E0", VA = "0x182A8E1E0", Slot = "26")]
		public float3 KKNFCLNHIPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D900", Offset = "0x2A8CB00", VA = "0x182A8D900", Slot = "27")]
		public void HBJMIFMDHJH(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F1F0", Offset = "0x2A8E3F0", VA = "0x182A8F1F0", Slot = "28")]
		public float PCHNAMNKKHL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C340", Offset = "0x2A8B540", VA = "0x182A8C340", Slot = "29")]
		public void CGGJFFODFCK(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C930", Offset = "0x2A8BB30", VA = "0x182A8C930", Slot = "30")]
		public float DPJIHEDKBFH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D4A0", Offset = "0x2A8C6A0", VA = "0x182A8D4A0", Slot = "31")]
		public void FPOBCCILBBI(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2A8ED80", Offset = "0x2A8DF80", VA = "0x182A8ED80", Slot = "32")]
		public bool NJEBDEKANKC(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D730", Offset = "0x2A8C930", VA = "0x182A8D730", Slot = "33")]
		public void GHJLDOAMDAN(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C8B0", Offset = "0x2A8BAB0", VA = "0x182A8C8B0", Slot = "19")]
		public void DPAICFKBHKC(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E3F0", Offset = "0x2A8D5F0", VA = "0x182A8E3F0", Slot = "20")]
		public bool LHMFNDPLNFP(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC60", Offset = "0x2A8BE60", VA = "0x182A8CC60", Slot = "21")]
		public void EGFNJCAIHME(NFJEDPPAJMK OOGHONKGHEE, quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EC20", Offset = "0x2A8DE20", VA = "0x182A8EC20", Slot = "22")]
		public bool NFHMKOEAFNH(NFJEDPPAJMK OOGHONKGHEE, out quaternion JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C990", Offset = "0x2A8BB90", VA = "0x182A8C990", Slot = "23")]
		public bool ECJJCHNJEBA(NFJEDPPAJMK OOGHONKGHEE, out float3 MDMEPBIDEMF, out quaternion FPBHBLNIIHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D570", Offset = "0x2A8C770", VA = "0x182A8D570", Slot = "44")]
		public GDPCJHNBEPD GEKJIGMIAOF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(GDPCJHNBEPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C180", Offset = "0x2A8B380", VA = "0x182A8C180", Slot = "45")]
		public void AELADANKEEK(NFJEDPPAJMK OOGHONKGHEE, GDPCJHNBEPD JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CE60", Offset = "0x2A8C060", VA = "0x182A8CE60", Slot = "72")]
		public void EMPDLMHGOKL(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D980", Offset = "0x2A8CB80", VA = "0x182A8D980", Slot = "73")]
		public void HDIPLCIMADM(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C410", Offset = "0x2A8B610", VA = "0x182A8C410", Slot = "74")]
		public bool CJLENBHBNJH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA10", Offset = "0x2A8CC10", VA = "0x182A8DA10", Slot = "81")]
		public void HEFMFPDAIFJ(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C5F0", Offset = "0x2A8B7F0", VA = "0x182A8C5F0", Slot = "82")]
		public void CODHLLPMAMF(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C570", Offset = "0x2A8B770", VA = "0x182A8C570", Slot = "83")]
		public bool CMLLPKAFDDI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E8B0", Offset = "0x2A8DAB0", VA = "0x182A8E8B0", Slot = "84")]
		public IEnumerable<object> MAIAADFKPJN(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F300", Offset = "0x2A8E500", VA = "0x182A8F300", Slot = "46")]
		public bool PELIGOEKBAF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EBC0", Offset = "0x2A8DDC0", VA = "0x182A8EBC0", Slot = "47")]
		public void NEJMCBJEGNJ(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CCD0", Offset = "0x2A8BED0", VA = "0x182A8CCD0", Slot = "48")]
		public bool EHMAMBIGBLJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E2E0", Offset = "0x2A8D4E0", VA = "0x182A8E2E0", Slot = "49")]
		public void LEHIBIEOLCL(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E5E0", Offset = "0x2A8D7E0", VA = "0x182A8E5E0", Slot = "50")]
		public bool LLEKMNNLFFM(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAC0", Offset = "0x2A8CCC0", VA = "0x182A8DAC0", Slot = "51")]
		public void HPOIKIHCHKK(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F0A0", Offset = "0x2A8E2A0", VA = "0x182A8F0A0", Slot = "52")]
		public RigidbodyConstraints OGPNEFJKAPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D2C0", Offset = "0x2A8C4C0", VA = "0x182A8D2C0", Slot = "53")]
		public void FJJAKNBEOJP(NFJEDPPAJMK OOGHONKGHEE, RigidbodyConstraints JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E9B0", Offset = "0x2A8DBB0", VA = "0x182A8E9B0", Slot = "54")]
		public float MFGIABEJMEL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F4C0", Offset = "0x2A8E6C0", VA = "0x182A8F4C0", Slot = "55")]
		public void PJHEDPBECDO(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F190", Offset = "0x2A8E390", VA = "0x182A8F190", Slot = "56")]
		public float PBNAAGMIAPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DD60", Offset = "0x2A8CF60", VA = "0x182A8DD60", Slot = "57")]
		public void JEPFOOOBHMG(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F530", Offset = "0x2A8E730", VA = "0x182A8F530", Slot = "58")]
		public bool POANHIOCLGH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F030", Offset = "0x2A8E230", VA = "0x182A8F030", Slot = "59")]
		public void OFEOCGHEIJM(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C820", Offset = "0x2A8BA20", VA = "0x182A8C820", Slot = "60")]
		public bool DIJIGKBMJHH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DEF0", Offset = "0x2A8D0F0", VA = "0x182A8DEF0", Slot = "61")]
		public void JKIGBAAGNJA(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC30", Offset = "0x2A8CE30", VA = "0x182A8DC30", Slot = "62")]
		public int IKJHGLILIJL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DB30", Offset = "0x2A8CD30", VA = "0x182A8DB30", Slot = "63")]
		public void IEHBKFNOKMJ(NFJEDPPAJMK OOGHONKGHEE, int JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E550", Offset = "0x2A8D750", VA = "0x182A8E550", Slot = "64")]
		public Rigidbody LIGLOJGGGFI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E750", Offset = "0x2A8D950", VA = "0x182A8E750", Slot = "65")]
		public void MACIJBHOPDB(NFJEDPPAJMK OOGHONKGHEE, Rigidbody JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F100", Offset = "0x2A8E300", VA = "0x182A8F100", Slot = "75")]
		public void OOBBBPJENLK(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EF40", Offset = "0x2A8E140", VA = "0x182A8EF40", Slot = "76")]
		public void ODAOKNAMNPO(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C7A0", Offset = "0x2A8B9A0", VA = "0x182A8C7A0", Slot = "77")]
		public bool DHDBMJGNKEH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DF60", Offset = "0x2A8D160", VA = "0x182A8DF60", Slot = "66")]
		public object KBCPJMDLLFO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CFC0", Offset = "0x2A8C1C0", VA = "0x182A8CFC0", Slot = "67")]
		public void FFAOIHCKNLG(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DBA0", Offset = "0x2A8CDA0", VA = "0x182A8DBA0", Slot = "68")]
		public object IJLJCLHOIIF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D7A0", Offset = "0x2A8C9A0", VA = "0x182A8D7A0", Slot = "69")]
		public void GIDIPIDOPGM(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC00", Offset = "0x2A8BE00", VA = "0x182A8CC00", Slot = "70")]
		public float EELAIMBFGEK(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C490", Offset = "0x2A8B690", VA = "0x182A8C490", Slot = "71")]
		public void CJOOFKCBJCD(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C680", Offset = "0x2A8B880", VA = "0x182A8C680", Slot = "78")]
		public void CPOMNIFIMEH(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C0F0", Offset = "0x2A8B2F0", VA = "0x182A8C0F0", Slot = "79")]
		public void ADPJKPCEEGN(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D420", Offset = "0x2A8C620", VA = "0x182A8D420", Slot = "80")]
		public bool FLGGNOAJFBP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D510", Offset = "0x2A8C710", VA = "0x182A8D510", Slot = "24")]
		public void GCIJILELHNN(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C3B0", Offset = "0x2A8B5B0", VA = "0x182A8C3B0", Slot = "25")]
		public void CJFAJCNLIBK(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x45DB800", Offset = "0x45DAA00", VA = "0x1845DB800")]
		private void MHDOJJHCJKM<T>(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x45DB290", Offset = "0x45DA490", VA = "0x1845DB290")]
		private bool FNMHKDLACLI<T>(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x45DA680", Offset = "0x45D9880", VA = "0x1845DA680")]
		private void BCBAFCFKBLF<T>(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x45DB960", Offset = "0x45DAB60", VA = "0x1845DB960")]
		private bool POEOEOCKJOD<TC, TV>(NFJEDPPAJMK OOGHONKGHEE, Func<TC, TV> JHCJMGCFBCP, out TV JFBPNBNBHOE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x45DA600", Offset = "0x45D9800", VA = "0x1845DA600")]
		private bool POEOEOCKJOD<T>(NFJEDPPAJMK OOGHONKGHEE, out T JFBPNBNBHOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x45DB3B0", Offset = "0x45DA5B0", VA = "0x1845DB3B0")]
		private T LLDFALJIFCH<T>(NFJEDPPAJMK OOGHONKGHEE) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x45DA6E0", Offset = "0x45D98E0", VA = "0x1845DA6E0")]
		private void BGDLHPIBHGK<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x45DAC30", Offset = "0x45D9E30", VA = "0x1845DAC30")]
		private void DCFEDLLGHBK<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x45DA600", Offset = "0x45D9800", VA = "0x1845DA600")]
		private bool APDEIBNIKJF<T>(NFJEDPPAJMK OOGHONKGHEE, out T JFBPNBNBHOE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x45DB900", Offset = "0x45DAB00", VA = "0x1845DB900")]
		private T PEDBKCDGEPG<T>(NFJEDPPAJMK OOGHONKGHEE) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x45DA600", Offset = "0x45D9800", VA = "0x1845DA600")]
		private void FPIFFMALFOD<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x45DB850", Offset = "0x45DAA50", VA = "0x1845DB850")]
		private void NNLPNDPOLMH<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C880", Offset = "0x2A8BA80", VA = "0x182A8C880")]
		private NFJEDPPAJMK DNKKDOLDNIE(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC90", Offset = "0x2A8CE90", VA = "0x182A8DC90")]
		private DynamicBuffer<Entity> JBFEJAKGNJD(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x45DB2F0", Offset = "0x45DA4F0", VA = "0x1845DB2F0")]
		private void KLAKNCFPJPD<T>(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE, Func<object, T> JHCJMGCFBCP) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void HBGEMGCKMHE<T>(ref global::GGEJOAKONHH<T> BAMMKKCEACG) where T : struct, NBKDCFKNMHI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void HBGEMGCKMHE<TC, TV>(ref global::IMJKKCAJKJE<TC, TV> BAMMKKCEACG) where TC : struct, NBKDCFKNMHI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[LOJIIDJFKAI(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class OAHFJGHGGKL : IEnumerable<MGDHAHFMJMO>, IEnumerable, IEnumerator<MGDHAHFMJMO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private MGDHAHFMJMO <>2__current;

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
			private MGDHAHFMJMO System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public OAHFJGHGGKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x41CA4E0", Offset = "0x41C96E0", VA = "0x1841CA4E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x41CA1A0", Offset = "0x41C93A0", VA = "0x1841CA1A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x41CA560", Offset = "0x41C9760", VA = "0x1841CA560")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x41CA4A0", Offset = "0x41C96A0", VA = "0x1841CA4A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x41CA3F0", Offset = "0x41C95F0", VA = "0x1841CA3F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MGDHAHFMJMO> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x41CA3F0", Offset = "0x41C95F0", VA = "0x1841CA3F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> FPKCOABGINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x31B7500", Offset = "0x31B6700", VA = "0x1831B7500", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x31B73E0", Offset = "0x31B65E0", VA = "0x1831B73E0")]
		public void MGAFJABNDCK(NativeArray<Entity> GNGEEFEGDCP, bool PGIEHHJIIFL, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x31B71D0", Offset = "0x31B63D0", VA = "0x1831B71D0")]
		public void KGABBKPALAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x31B6830", Offset = "0x31B5A30", VA = "0x1831B6830")]
		private void BAEJHPPJHIF(NativeArray<Entity> GNGEEFEGDCP, bool PGIEHHJIIFL, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x31B7140", Offset = "0x31B6340", VA = "0x1831B7140")]
		[IteratorStateMachine(typeof(OAHFJGHGGKL))]
		private IEnumerable<MGDHAHFMJMO> HHGFAEDKPBK(NativeArray<Entity> GNGEEFEGDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x31B6FF0", Offset = "0x31B61F0", VA = "0x1831B6FF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x31B75A0", Offset = "0x31B67A0", VA = "0x1831B75A0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[LOJIIDJFKAI(typeof(KHFJEIHOPJL), new string[] { })]
public class DIHMLMHBMFI : KHFJEIHOPJL, IEnumerable<GKFDLLIKKMD>, IEnumerable, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[IMNMHIBEIDL]
	private MHNMKOLPOKF ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> FDJOGCMPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private NBEJBJMNGCG KNGEPEIOMBA;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C57010", Offset = "0x2C56210", VA = "0x182C57010", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GKFDLLIKKMD OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C56FF0", Offset = "0x2C561F0", VA = "0x182C56FF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GKFDLLIKKMD OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C56FF0", Offset = "0x2C561F0", VA = "0x182C56FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C56FA0", Offset = "0x2C561A0", VA = "0x182C56FA0", Slot = "11")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C57110", Offset = "0x2C56310", VA = "0x182C57110", Slot = "12")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C56D00", Offset = "0x2C55F00", VA = "0x182C56D00")]
	private void JLEPHBJLNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x27DC950", Offset = "0x27DBB50", VA = "0x1827DC950")]
	private string KLKNOGHKLGI(string IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C57030", Offset = "0x2C56230", VA = "0x182C57030", Slot = "7")]
	public GKFDLLIKKMD MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C56920", Offset = "0x2C55B20", VA = "0x182C56920")]
	private bool GIOOOLIFLGK(Type JHMACGKJPAP, string IGHJIHNAPBA, out GKFDLLIKKMD IPFKDLFGNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C56BD0", Offset = "0x2C55DD0", VA = "0x182C56BD0", Slot = "8")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C56CE0", Offset = "0x2C55EE0", VA = "0x182C56CE0", Slot = "9")]
	public IEnumerator<GKFDLLIKKMD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C56CE0", Offset = "0x2C55EE0", VA = "0x182C56CE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C57190", Offset = "0x2C56390", VA = "0x182C57190")]
	public DIHMLMHBMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[DefaultMember("Item")]
public interface HHKCCBKAPBE
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNPOONDBPKB(NMLCFAIOCDK LIKFEBDBPON, out int PCAHMJECHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[LOJIIDJFKAI(typeof(HHKCCBKAPBE), new string[] { })]
public class JOBPHLPMHND : DPDCPMNGBKH, FPHKGEBJIKC, HHKCCBKAPBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[IMNMHIBEIDL]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<NMLCFAIOCDK, int> FNPHJDDFFHP;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x31B14B0", Offset = "0x31B06B0", VA = "0x1831B14B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x31B1430", Offset = "0x31B0630", VA = "0x1831B1430", Slot = "6")]
	public bool CNPOONDBPKB(NMLCFAIOCDK LIKFEBDBPON, out int PCAHMJECHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x31B1780", Offset = "0x31B0980", VA = "0x1831B1780", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x31B14A0", Offset = "0x31B06A0", VA = "0x1831B14A0", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x31B1510", Offset = "0x31B0710", VA = "0x1831B1510")]
	private void OKAMHJBHMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x31B17E0", Offset = "0x31B09E0", VA = "0x1831B17E0")]
	public JOBPHLPMHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[LOJIIDJFKAI(typeof(KJEMHJEIOEO), new string[] { })]
[DefaultMember("Item")]
public class IPGEOCGLAEL : KJEMHJEIOEO, IEnumerable<ICAMIIGEPFO>, IEnumerable, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, FNFKCLIHOKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private ICAMIIGEPFO[] HBOOJFCEDKO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x31AECD0", Offset = "0x31ADED0", VA = "0x1831AECD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ICAMIIGEPFO OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x31AE9A0", Offset = "0x31ADBA0", VA = "0x1831AE9A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ICAMIIGEPFO OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x31AE9A0", Offset = "0x31ADBA0", VA = "0x1831AE9A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "10")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x31AEE10", Offset = "0x31AE010", VA = "0x1831AEE10", Slot = "11")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "12")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x31AECE0", Offset = "0x31ADEE0", VA = "0x1831AECE0", Slot = "6")]
	public ICAMIIGEPFO MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x31AEB20", Offset = "0x31ADD20", VA = "0x1831AEB20", Slot = "7")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x31AEBF0", Offset = "0x31ADDF0", VA = "0x1831AEBF0", Slot = "8")]
	public IEnumerator<ICAMIIGEPFO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x31AF0B0", Offset = "0x31AE2B0", VA = "0x1831AF0B0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x288C290", Offset = "0x288B490", VA = "0x18288C290", Slot = "13")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x31AE9E0", Offset = "0x31ADBE0", VA = "0x1831AE9E0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IPGEOCGLAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x31AE9A0", Offset = "0x31ADBA0", VA = "0x1831AE9A0")]
	[CompilerGenerated]
	private ICAMIIGEPFO BDHEOKJIHOE(int BHOLCDOGKAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[LOJIIDJFKAI(typeof(PMEGIOPIHFM), new string[] { })]
public class NNEPNHKNJKA : PMEGIOPIHFM, IEnumerable<FNOOJMKBHOH>, IEnumerable, DPDCPMNGBKH, FPHKGEBJIKC, FNFKCLIHOKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private FNOOJMKBHOH[] HBOOJFCEDKO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A740C0", Offset = "0x2A732C0", VA = "0x182A740C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FNOOJMKBHOH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A73AF0", Offset = "0x2A72CF0", VA = "0x182A73AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FNOOJMKBHOH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2A73AF0", Offset = "0x2A72CF0", VA = "0x182A73AF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A74230", Offset = "0x2A73430", VA = "0x182A74230", Slot = "9")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A73E60", Offset = "0x2A73060", VA = "0x182A73E60", Slot = "10")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A73B00", Offset = "0x2A72D00", VA = "0x182A73B00")]
	private FNOOJMKBHOH BKCFICCGMPC(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2A74110", Offset = "0x2A73310", VA = "0x182A74110", Slot = "6")]
	public FNOOJMKBHOH MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2A73C80", Offset = "0x2A72E80", VA = "0x182A73C80", Slot = "14")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2A73D50", Offset = "0x2A72F50", VA = "0x182A73D50", Slot = "7")]
	public IEnumerator<FNOOJMKBHOH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2A73D50", Offset = "0x2A72F50", VA = "0x182A73D50", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2D4D9B0", Offset = "0x2D4CBB0", VA = "0x182D4D9B0", Slot = "11")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2A73BE0", Offset = "0x2A72DE0", VA = "0x182A73BE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public NNEPNHKNJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2A73AF0", Offset = "0x2A72CF0", VA = "0x182A73AF0")]
	[CompilerGenerated]
	private FNOOJMKBHOH BDHEOKJIHOE(int BHOLCDOGKAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[LOJIIDJFKAI(typeof(MHNMKOLPOKF), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal class MHNMKOLPOKF : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private PMEGIOPIHFM GGAKPCLFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private KJEMHJEIOEO BPHAFAOANOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::DGIKCDEPKDI<BCNEEGFPPIH> MBGKNDLKFDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public NBEJBJMNGCG MLHOKFIPNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6CE590", Offset = "0x6CD790", VA = "0x1806CE590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2A70A30", Offset = "0x2A6FC30", VA = "0x182A70A30", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2A706D0", Offset = "0x2A6F8D0", VA = "0x182A706D0")]
	private void AGNKCEEGCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3071180", Offset = "0x3070380", VA = "0x183071180")]
	public T EHHFFPPDBPA<T>() where T : BCNEEGFPPIH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2A70890", Offset = "0x2A6FA90", VA = "0x182A70890")]
	public GKFDLLIKKMD LPKJPMGMJLK(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::DEHNDDIKMEN<T> LPKJPMGMJLK<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2A70960", Offset = "0x2A6FB60", VA = "0x182A70960")]
	public FNOOJMKBHOH NBCFHJCHPJO(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x3080140", Offset = "0x307F340", VA = "0x183080140")]
	public global::EALCHGCDDPJ<T> NBCFHJCHPJO<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2A707C0", Offset = "0x2A6F9C0", VA = "0x182A707C0")]
	public ICAMIIGEPFO GBOLGOLDFDH(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::GEAJGNGECAJ<T> GBOLGOLDFDH<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MHNMKOLPOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class NCCNAJJBFBO
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2D49890", Offset = "0x2D48A90", VA = "0x182D49890")]
	public static global::DEHNDDIKMEN<T> LPKJPMGMJLK<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::EALCHGCDDPJ<T> NBCFHJCHPJO<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::GEAJGNGECAJ<T> GBOLGOLDFDH<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[LOJIIDJFKAI(typeof(KIMMPHOEFCL), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public class KIMMPHOEFCL : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private DEMIGFIOEMK GIPMDGDJGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private NMLCFAIOCDK[] IPNJKLGEGGB;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x31B4730", Offset = "0x31B3930", VA = "0x1831B4730", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x31B4610", Offset = "0x31B3810", VA = "0x1831B4610")]
	public void ONDFMJFBIEL(IOLFAAOECPP IOCKLNNJMIA, bool AFEBCJCKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KIMMPHOEFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LOJIIDJFKAI(typeof(NAHABAIDKKI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public sealed class NAHABAIDKKI : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CJIMMDCKAGN : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public CJIMMDCKAGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x41C28F0", Offset = "0x41C1AF0", VA = "0x1841C28F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x41C2540", Offset = "0x41C1740", VA = "0x1841C2540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x41C2970", Offset = "0x41C1B70", VA = "0x1841C2970")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x41C28B0", Offset = "0x41C1AB0", VA = "0x1841C28B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x41C2820", Offset = "0x41C1A20", VA = "0x1841C2820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x41C2820", Offset = "0x41C1A20", VA = "0x1841C2820", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string JLPCCDCONOB = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, AEMFLFLGAKF> FIAOFMOLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> GFBJBCAKPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private BMGHPMCGENG BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JCGKPCPJOOI BDAAELOCEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::HKEMDJIFJBH<AEMFLFLGAKF> FMDBKJDEFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject KKHLDKDGGLB;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2A72E00", Offset = "0x2A72000", VA = "0x182A72E00", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2A72000", Offset = "0x2A71200", VA = "0x182A72000", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2A71890", Offset = "0x2A70A90", VA = "0x182A71890", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2A71E10", Offset = "0x2A71010", VA = "0x182A71E10")]
	private void HAAMBKCKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2A729D0", Offset = "0x2A71BD0", VA = "0x182A729D0")]
	internal void ODLECDMINBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2A72370", Offset = "0x2A71570", VA = "0x182A72370")]
	private void KKOJFBLMDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2A71740", Offset = "0x2A70940", VA = "0x182A71740")]
	private void AFMNGDDPDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2A71840", Offset = "0x2A70A40", VA = "0x182A71840")]
	[IteratorStateMachine(typeof(CJIMMDCKAGN))]
	private IEnumerable<RRCustomPropTag> CKIGLNPKICL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2A72550", Offset = "0x2A71750", VA = "0x182A72550")]
	private void LEAFPMEAEME(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2A72230", Offset = "0x2A71430", VA = "0x182A72230")]
	private void KJDPCLCGNLB(SerializableGuid JHHPNHDNIID, GameObject OOKBNBHDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2A71A80", Offset = "0x2A70C80", VA = "0x182A71A80")]
	private void GMFKNLHNPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2A71E20", Offset = "0x2A71020", VA = "0x182A71E20")]
	private bool IHLNIOJNGEJ(AEMFLFLGAKF MKHEGFILDPH, Transform GPFONCECPBK, out GameObject MPOGNODCFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2A71A30", Offset = "0x2A70C30", VA = "0x182A71A30")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2A72ED0", Offset = "0x2A720D0", VA = "0x182A72ED0")]
	public NAHABAIDKKI()
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
		public SerializableGuid MCOFJEKHEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C000", Offset = "0x2A8B200", VA = "0x182A8C000")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[LOJIIDJFKAI(typeof(AIPMOHLKLGI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public class AIPMOHLKLGI : DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string ODKFNCHENHH = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FE60", Offset = "0x2C3F060", VA = "0x182C3FE60", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AIPMOHLKLGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(AFJJDNCHENE), new string[] { })]
public class AFJJDNCHENE : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[IMNMHIBEIDL]
	private EnableComponentSystemsInScope EKJFPEDJHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[IMNMHIBEIDL]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F0A0", Offset = "0x2C3E2A0", VA = "0x182C3F0A0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F010", Offset = "0x2C3E210", VA = "0x182C3F010", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F050", Offset = "0x2C3E250", VA = "0x182C3F050")]
	private void FFNOCNODJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3F070", Offset = "0x2C3E270", VA = "0x182C3F070")]
	private void NMHNLLFAOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AFJJDNCHENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[LOJIIDJFKAI(typeof(CGLADJHJCEM), new string[] { })]
public class AKIMKJDDDDE : DPDCPMNGBKH, FPHKGEBJIKC, CGLADJHJCEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private DJCLCEOJBJF FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private MNCPFFBIPBM PIOIBKPFDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService FMKAHEFPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem LDEGMCDCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int LPIFJGNEIMC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool FOPMPJMIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2C40530", Offset = "0x2C3F730", VA = "0x182C40530", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public NFJEDPPAJMK OOMHMDEKIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2C408F0", Offset = "0x2C3FAF0", VA = "0x182C408F0", Slot = "9")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2C40440", Offset = "0x2C3F640", VA = "0x182C40440", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public JMAKJOJHHNF CHIKBBJPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2C408A0", Offset = "0x2C3FAA0", VA = "0x182C408A0", Slot = "11")]
		get
		{
			return default(JMAKJOJHHNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2C40440", Offset = "0x2C3F640", VA = "0x182C40440", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JMAKJOJHHNF PAIGKEACLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2C404E0", Offset = "0x2C3F6E0", VA = "0x182C404E0", Slot = "13")]
		get
		{
			return default(JMAKJOJHHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint BAEDJPNEDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2C40090", Offset = "0x2C3F290", VA = "0x182C40090")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LOPBLFJGGII AEPAOFPFGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2C40250", Offset = "0x2C3F450", VA = "0x182C40250", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FFF0", Offset = "0x2C3F1F0", VA = "0x182C3FFF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2C40C90", Offset = "0x2C3FE90", VA = "0x182C40C90", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2C40570", Offset = "0x2C3F770", VA = "0x182C40570", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2C40390", Offset = "0x2C3F590", VA = "0x182C40390", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2C40A90", Offset = "0x2C3FC90", VA = "0x182C40A90")]
	private void NAPOHPPKBLH(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2C40140", Offset = "0x2C3F340", VA = "0x182C40140", Slot = "14")]
	public NFJEDPPAJMK BEIEOAFNFAF(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FEF0", Offset = "0x2C3F0F0", VA = "0x182C3FEF0", Slot = "15")]
	public bool ABEADFFICKO(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD, out NFJEDPPAJMK OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2C40710", Offset = "0x2C3F910", VA = "0x182C40710", Slot = "16")]
	public void KEAPAJJBIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2C402F0", Offset = "0x2C3F4F0", VA = "0x182C402F0", Slot = "17")]
	public void BPMACDADLOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2C40930", Offset = "0x2C3FB30", VA = "0x182C40930", Slot = "18")]
	public bool MPLFKOIHFPF(NFJEDPPAJMK MOOHJICILGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2C40440", Offset = "0x2C3F640", VA = "0x182C40440")]
	private void GHGFKHHEHNE(NFJEDPPAJMK FFBBPBHPNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public AKIMKJDDDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[LOJIIDJFKAI(typeof(DEMDCLJBMBJ), new string[] { })]
public class DOHAFCLPGCK : DPDCPMNGBKH, DEMDCLJBMBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2C578D0", Offset = "0x2C56AD0", VA = "0x182C578D0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2C57860", Offset = "0x2C56A60", VA = "0x182C57860", Slot = "5")]
	public void PBDHOHEJHEJ(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2578FE0", Offset = "0x25781E0", VA = "0x182578FE0")]
	private void HDECKBNAIGA<T>(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DOHAFCLPGCK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	[LOJIIDJFKAI(typeof(EOGBLGKJGCD), new string[] { })]
	public class SelectionService : DPDCPMNGBKH, EOGBLGKJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB6A0", Offset = "0x2CBA8A0", VA = "0x182CBB6A0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB5C0", Offset = "0x2CBA7C0", VA = "0x182CBB5C0", Slot = "5")]
		public void JDCIOHHAIMF(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB630", Offset = "0x2CBA830", VA = "0x182CBB630", Slot = "6")]
		public void LJFMADGJJCC(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2578FE0", Offset = "0x25781E0", VA = "0x182578FE0")]
		private void HDECKBNAIGA<T>(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(JKIIJLILCCP), new string[] { })]
internal sealed class JKIIJLILCCP : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[IMNMHIBEIDL]
	private ObjectEmbodimentService ALLKDINDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x31B0990", Offset = "0x31AFB90", VA = "0x1831B0990", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JKIIJLILCCP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	[LOJIIDJFKAI(typeof(WorldSerialization), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	internal sealed class WorldSerialization : DPDCPMNGBKH, GKBBEKJICJK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly FADHLPPNOEF CEDIHMKBBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[IMNMHIBEIDL]
		private LFIBHLPOILP PPDJEICCKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[IMNMHIBEIDL]
		private SerializationService BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[IMNMHIBEIDL]
		private BANIDHAOEAM IPILJEFIHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[IMNMHIBEIDL]
		private DebugWorldsService EKBOMMFEOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[IMNMHIBEIDL]
		private BulkInstantiateSceneObjectService EBOLOFHGGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private JHLNNPKIFCO KOKEGENGCAH;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private OKNJKHAMLJO HLMDNBNAKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xC1DEF0", Offset = "0xC1D0F0", VA = "0x180C1DEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD07D0", Offset = "0x2CCF9D0", VA = "0x182CD07D0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO JAOCFOBBLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF900", Offset = "0x2CCEB00", VA = "0x182CCF900", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0170", Offset = "0x2CCF370", VA = "0x182CD0170", Slot = "6")]
		public bool KKJBIOFDHBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2CD02D0", Offset = "0x2CCF4D0", VA = "0x182CD02D0", Slot = "7")]
		public bool MOBLBDDLMMJ(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2CCFCE0", Offset = "0x2CCEEE0", VA = "0x182CCFCE0", Slot = "5")]
		public ByteString KHCMMGKFHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF8E0", Offset = "0x2CCEAE0", VA = "0x182CCF8E0")]
		private void DLEHLBPFOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2CCFC10", Offset = "0x2CCEE10", VA = "0x182CCFC10")]
		private void GEAKLAABGMI(HKGKEPCIADL CEEHHEDBOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2CD02F0", Offset = "0x2CCF4F0", VA = "0x182CD02F0")]
		private void NOOGCIKELGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF930", Offset = "0x2CCEB30", VA = "0x182CCF930")]
		private void GBHHGAAJMPE(MHOEABJDIBA CEEHHEDBOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF890", Offset = "0x2CCEA90", VA = "0x182CCF890", Slot = "8")]
		public void COMMHLEBCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF7F0", Offset = "0x2CCE9F0", VA = "0x182CCF7F0")]
		private HKGKEPCIADL ACAFOEKMJLB(EntityManager FDDCHHJLNLF, EntityManager PMCBFHAJAOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(GDFIPNNJBAF), new string[] { })]
public class GDFIPNNJBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<PCLEKMKAJBM, string> IDBELADJMGE;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x31A5EF0", Offset = "0x31A50F0", VA = "0x1831A5EF0")]
	public GameObject ABIMPNPLHMP(PCLEKMKAJBM FFLMGLOOKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x31A5FC0", Offset = "0x31A51C0", VA = "0x1831A5FC0")]
	public GDFIPNNJBAF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(TimeService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class TimeService : LFPMKPLIAAM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[IMNMHIBEIDL]
		private SingletonComponentService IDGCJAPHIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool DOIPIBNHHCB;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData EDLKJAOEHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2CC2ED0", Offset = "0x2CC20D0", VA = "0x182CC2ED0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2CC2F40", Offset = "0x2CC2140", VA = "0x182CC2F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FCKEAKEOFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x703000", Offset = "0x702200", VA = "0x180703000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2216130", Offset = "0x2215330", VA = "0x182216130", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2CC2FC0", Offset = "0x2CC21C0", VA = "0x182CC2FC0", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3010", Offset = "0x2CC2210", VA = "0x182CC3010")]
		public void PEKOAHIKAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[LOJIIDJFKAI(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::DEHNDDIKMEN<Entity> GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService CCJAOIAIHHP;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF360", Offset = "0x2CBE560", VA = "0x182CBF360", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF0F0", Offset = "0x2CBE2F0", VA = "0x182CBF0F0", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF050", Offset = "0x2CBE250", VA = "0x182CBF050", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF220", Offset = "0x2CBE420", VA = "0x182CBF220")]
		private void KKPBCPLKBEH(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Services)]
	[LOJIIDJFKAI(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[IMNMHIBEIDL]
		private ADMIKKBEDIN LNJLGDKOFHH;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private ACDNAFCMOHG CAEPCIMDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x319F180", Offset = "0x319E380", VA = "0x18319F180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private MGBLANLDNCG GFAOFEHDKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x319F1D0", Offset = "0x319E3D0", VA = "0x18319F1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x319F220", Offset = "0x319E420", VA = "0x18319F220", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x319F160", Offset = "0x319E360", VA = "0x18319F160", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(CMKHMHNPMBE), new string[] { })]
public class CMKHMHNPMBE : COEMEMEDCFH, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class MLIOGBNLKEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MLIOGBNLKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6BA0", Offset = "0x2CB5DA0", VA = "0x182CB6BA0")]
		internal void <InitReferences>b__0(DPDCPMNGBKH svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JMCJOMOHAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public JMCJOMOHAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6470", Offset = "0x2CB5670", VA = "0x182CB6470")]
		internal void <InitExternal>b__0(FPHKGEBJIKC svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x9340C0", Offset = "0x9332C0", VA = "0x1809340C0", Slot = "4")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MJGGLIPIDNP IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2C495E0", Offset = "0x2C487E0", VA = "0x182C495E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2C49710", Offset = "0x2C48910", VA = "0x182C49710", Slot = "5")]
	public void JKLOGDJOLHP(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2C49760", Offset = "0x2C48960", VA = "0x182C49760", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2C49890", Offset = "0x2C48A90", VA = "0x182C49890", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2C49630", Offset = "0x2C48830", VA = "0x182C49630", Slot = "8")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2C494B0", Offset = "0x2C486B0", VA = "0x182C494B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x25617F0", Offset = "0x25609F0", VA = "0x1825617F0")]
	private void PMOBBGIOLAN<T>(Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CMKHMHNPMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class MNIEODKMIBJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> IEGPGBKLAIF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To OMKECOOHJIM
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
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public MNIEODKMIBJ(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
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
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
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
public class HPDKBNPNCNA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x36277F0", Offset = "0x36269F0", VA = "0x1836277F0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x3627850", Offset = "0x3626A50", VA = "0x183627850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x36277C0", Offset = "0x36269C0", VA = "0x1836277C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x781170", Offset = "0x780370", VA = "0x180781170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F67420", Offset = "0x1F66620", VA = "0x181F67420")]
	public HPDKBNPNCNA(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB, bool LPKIEPPBIHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x3627410", Offset = "0x3626610", VA = "0x183627410", Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x3118440", Offset = "0x3117640", VA = "0x183118440", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3627470", Offset = "0x3626670", VA = "0x183627470", Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x36274D0", Offset = "0x36266D0", VA = "0x1836274D0", Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x36275E0", Offset = "0x36267E0", VA = "0x1836275E0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3627650", Offset = "0x3626850", VA = "0x183627650", Slot = "6")]
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x36276B0", Offset = "0x36268B0", VA = "0x1836276B0", Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3627760", Offset = "0x3626960", VA = "0x183627760", Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3627730", Offset = "0x3626930", VA = "0x183627730", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x23576B0", Offset = "0x23568B0", VA = "0x1823576B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class MCIDMCJKHCJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBCF0", Offset = "0x3AEAEF0", VA = "0x183AEBCF0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBD40", Offset = "0x3AEAF40", VA = "0x183AEBD40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBCB0", Offset = "0x3AEAEB0", VA = "0x183AEBCB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2685400", Offset = "0x2684600", VA = "0x182685400")]
	public MCIDMCJKHCJ(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB8C0", Offset = "0x3AEAAC0", VA = "0x183AEB8C0", Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB900", Offset = "0x3AEAB00", VA = "0x183AEB900", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB940", Offset = "0x3AEAB40", VA = "0x183AEB940", Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBA00", Offset = "0x3AEAC00", VA = "0x183AEBA00", Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBAC0", Offset = "0x3AEACC0", VA = "0x183AEBAC0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBB80", Offset = "0x3AEAD80", VA = "0x183AEBB80", Slot = "6")]
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBBF0", Offset = "0x3AEADF0", VA = "0x183AEBBF0", Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBC70", Offset = "0x3AEAE70", VA = "0x183AEBC70", Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBC30", Offset = "0x3AEAE30", VA = "0x183AEBC30", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1160", Offset = "0x1CD0360", VA = "0x181CD1160", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class IAFCLHDCNGE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To OMKECOOHJIM
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
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public IAFCLHDCNGE(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
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
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
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
public static class FFABMDFPAPO
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string ABBINPODNLB = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string LLCJMOLDDHB = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string JBNMHGGCGDB = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string DLHHDMNOPNO = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string NJIDGDLMBJJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string POCNDGEPBED = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string FGCALMBPIEH = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string CEJONDMOHOP = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class KCMGDGDLHHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OKJNGDAIKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public OKJNGDAIKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x41CAD80", Offset = "0x41C9F80", VA = "0x1841CAD80")]
		internal void <InitServices>b__1(DPDCPMNGBKH svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x41CADE0", Offset = "0x41C9FE0", VA = "0x1841CADE0")]
		internal void <InitServices>b__2(FPHKGEBJIKC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x31B18D0", Offset = "0x31B0AD0", VA = "0x1831B18D0")]
	public static void CHKECECPCLE(this MJGGLIPIDNP OACNPKMLCHI, JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D646C0", Offset = "0x1D638C0", VA = "0x181D646C0")]
	public static void PMOBBGIOLAN<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D64140", Offset = "0x1D63340", VA = "0x181D64140")]
	public static void GFPEIBFCEJA<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D63F90", Offset = "0x1D63190", VA = "0x181D63F90")]
	public static void DPLBMLKONEI<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x1D63DE0", Offset = "0x1D62FE0", VA = "0x181D63DE0")]
	public static void BDKNJDMNINI<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D64450", Offset = "0x1D63650", VA = "0x181D64450")]
	public static void KBONJFNFFBF<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x1D642E0", Offset = "0x1D634E0", VA = "0x181D642E0")]
	public static void GFPEIBFCEJA<T>(IEnumerable<ComponentSystemBase> HOCPKHHLENG, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x1D64600", Offset = "0x1D63800", VA = "0x181D64600")]
	private static void PEOIKHJLPHM<T>(object DCOPHBBEGEL, Action<T> MLBIDGHDIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class PCDDEIANACH
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class OCCNFHPOKOO
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A74540", Offset = "0x2A73740", VA = "0x182A74540")]
	public static void AFCLCMKGMDH(ComponentSystemBase DCOPHBBEGEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DAKJPGHHMGH
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool PHKNCADEDHN<T>(ref T FAMKPEGNHFC, ref T GPHMIGDKMEO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BBKFPNPODPB
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class PMKIJJAPFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PMKIJJAPFFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C44030", Offset = "0x2C43230", VA = "0x182C44030")]
	public static string FEJBNKNMICE(Transform LJLOGOIJMEM, Transform MOOHJICILGA)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[MBALNPKLAGP(FOFKCKDBIPD.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBDF30", Offset = "0x2CBD130", VA = "0x182CBDF30")]
		public static void ABDNPPIKLOH(this MMAHKENHAHO KOKEGENGCAH, AKHLGKPGKGF NOECNPHPBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE480", Offset = "0x2CBD680", VA = "0x182CBE480")]
		public static void PAHMLHEPEPE(this MMAHKENHAHO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBDE20", Offset = "0x2CBD020", VA = "0x182CBDE20")]
		public static void ABDNPPIKLOH(this MMAHKENHAHO KOKEGENGCAH, [Optional] string[] EKJJGDJAGBM, [Optional] string[] HFJJLADKPMN, [Optional] string[] PEMEJBAMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE160", Offset = "0x2CBD360", VA = "0x182CBE160")]
		public static void ILFFCLHNGMD(this MMAHKENHAHO KOKEGENGCAH, params string[] IJNGHIHLMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE3D0", Offset = "0x2CBD5D0", VA = "0x182CBE3D0")]
		public static void LFOOMLNFJMO(this MMAHKENHAHO KOKEGENGCAH, params string[] IJNGHIHLMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE580", Offset = "0x2CBD780", VA = "0x182CBE580")]
		private static string[] PFKMALBJMCD(AKHLGKPGKGF NOECNPHPBKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE210", Offset = "0x2CBD410", VA = "0x182CBE210")]
		private static bool JDBNOAPMBAF(AKHLGKPGKGF NOECNPHPBKJ, out string[] KGIOLOGPFOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00")]
		private static bool PCJEMJDINLD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class NPECMMOIGKD : NHFAACLOLLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo MJOCJIJILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] FKNKEJLLBEP;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A74490", Offset = "0x2A73690", VA = "0x182A74490")]
	public NPECMMOIGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action AKJGGHEAFNK();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A74450", Offset = "0x2A73650", VA = "0x182A74450")]
	public MethodInfo NMKMCCJKMKM(Action GPNJNMLGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A742A0", Offset = "0x2A734A0", VA = "0x182A742A0", Slot = "4")]
	public void KJDPCLCGNLB(Type DDJDPMGLPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class KENMGPMEAAD : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum NIMNELBNOEM
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x31B3480", Offset = "0x31B2680", VA = "0x1831B3480", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LEOMFAEFBGI<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x31B3510", Offset = "0x31B2710", VA = "0x1831B3510")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x31AF530", Offset = "0x31AE730", VA = "0x1831AF530")]
	protected KENMGPMEAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class JKLBMELODFJ : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x31B0A50", Offset = "0x31AFC50", VA = "0x1831B0A50", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void COBHDHHPEEM<T>() where T : HGKJFOODIMO;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x31B0AE0", Offset = "0x31AFCE0", VA = "0x1831B0AE0")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x31AF530", Offset = "0x31AE730", VA = "0x1831AF530")]
	protected JKLBMELODFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class JCBBEKGEPGH : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x31AF410", Offset = "0x31AE610", VA = "0x1831AF410", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPPMCGNKPME<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x31AF4A0", Offset = "0x31AE6A0", VA = "0x1831AF4A0")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x31AF530", Offset = "0x31AE730", VA = "0x1831AF530")]
	protected JCBBEKGEPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class FGDIJOKBBLM
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x31A3840", Offset = "0x31A2A40", VA = "0x1831A3840")]
	public static Entity BHAGDEEBMIJ(this EntityManager KNABDDPENKI)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class JEANINLGOMF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x264BC30", Offset = "0x264AE30", VA = "0x18264BC30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41C7140", Offset = "0x41C6340", VA = "0x1841C7140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x41C5EE0", Offset = "0x41C50E0", VA = "0x1841C5EE0")]
			[DebuggerHidden]
			public JEANINLGOMF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x41C6F70", Offset = "0x41C6170", VA = "0x1841C6F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x41C7100", Offset = "0x41C6300", VA = "0x1841C7100", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x41C7050", Offset = "0x41C6250", VA = "0x1841C7050", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x41C7050", Offset = "0x41C6250", VA = "0x1841C7050", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class PHMNFNCNJAP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x264BC30", Offset = "0x264AE30", VA = "0x18264BC30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41CB3E0", Offset = "0x41CA5E0", VA = "0x1841CB3E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x41C5EE0", Offset = "0x41C50E0", VA = "0x1841C5EE0")]
			[DebuggerHidden]
			public PHMNFNCNJAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x41CB430", Offset = "0x41CA630", VA = "0x1841CB430", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x41CB100", Offset = "0x41CA300", VA = "0x1841CB100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x41CB4C0", Offset = "0x41CA6C0", VA = "0x1841CB4C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x41CB3A0", Offset = "0x41CA5A0", VA = "0x1841CB3A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x41CB2F0", Offset = "0x41CA4F0", VA = "0x1841CB2F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x41CB2F0", Offset = "0x41CA4F0", VA = "0x1841CB2F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class HCFIKCHBDLK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x264BC30", Offset = "0x264AE30", VA = "0x18264BC30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41C5D20", Offset = "0x41C4F20", VA = "0x1841C5D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x41C5EE0", Offset = "0x41C50E0", VA = "0x1841C5EE0")]
			[DebuggerHidden]
			public HCFIKCHBDLK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x41C5D70", Offset = "0x41C4F70", VA = "0x1841C5D70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x41C5910", Offset = "0x41C4B10", VA = "0x1841C5910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x41C5E40", Offset = "0x41C5040", VA = "0x1841C5E40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x41C5E90", Offset = "0x41C5090", VA = "0x1841C5E90")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x41C5CE0", Offset = "0x41C4EE0", VA = "0x1841C5CE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x41C5C40", Offset = "0x41C4E40", VA = "0x1841C5C40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x41C5C40", Offset = "0x41C4E40", VA = "0x1841C5C40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x31A2380", Offset = "0x31A1580", VA = "0x1831A2380")]
		public static Entity HHCKLGJHJDM(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x31A2D30", Offset = "0x31A1F30", VA = "0x1831A2D30")]
		public static DynamicBuffer<ChildrenData> NOKFNLAAOIH(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x31A2CA0", Offset = "0x31A1EA0", VA = "0x1831A2CA0")]
		public static DynamicBuffer<ChildrenData> NDKOENAKEJM(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x31A1B90", Offset = "0x31A0D90", VA = "0x1831A1B90")]
		public static NativeArray<Entity> BPLBMMECGOF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x31A2AA0", Offset = "0x31A1CA0", VA = "0x1831A2AA0")]
		public static bool MLDPIIIMGHA(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG, out NativeArray<Entity> GGJICFIFGND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x31A1CC0", Offset = "0x31A0EC0", VA = "0x1831A1CC0")]
		public static NativeArray<Entity> CIMFGHKFFLC(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x31A23F0", Offset = "0x31A15F0", VA = "0x1831A23F0")]
		public static Entity JIABEAAPFBL(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x31A2170", Offset = "0x31A1370", VA = "0x1831A2170")]
		public static int FJOEJBEAIPG(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x31A1930", Offset = "0x31A0B30", VA = "0x1831A1930")]
		public static void BIPMKHFOLGI(NativeArray<Entity> NKDKBMKAAAG, NativeArray<Entity> PLBLCMNMLJO, EntityManager KNABDDPENKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x31A20C0", Offset = "0x31A12C0", VA = "0x1831A20C0")]
		public static int ENLCMJGOKGJ(this EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x31A26A0", Offset = "0x31A18A0", VA = "0x1831A26A0")]
		public static bool KFKEAKANFDF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x31A1820", Offset = "0x31A0A20", VA = "0x1831A1820")]
		public static IEnumerable<Entity> BIJKCDCNJDN(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x31A2F20", Offset = "0x31A2120", VA = "0x1831A2F20")]
		public static bool PNPLAMAGNCA(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity LKJGCNCCCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x31A1EB0", Offset = "0x31A10B0", VA = "0x1831A1EB0")]
		public static bool CLCGCNNPCNJ(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity HOHCGCELNKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x31A2800", Offset = "0x31A1A00", VA = "0x1831A2800")]
		public static NativeList<Entity> KGECOFKCEIF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false, Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x31A2520", Offset = "0x31A1720", VA = "0x1831A2520")]
		public static IEnumerable<Entity> JPCGBLEHGGF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x31A2BA0", Offset = "0x31A1DA0", VA = "0x1831A2BA0")]
		public static Entity MNEECNHBEJG(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x31A15C0", Offset = "0x31A07C0", VA = "0x1831A15C0")]
		public static bool ABEADFFICKO(this EntityManager KNABDDPENKI, Entity HOHCGCELNKE, Entity MDKKIEJKOGD, out Entity OBCBEGEPMDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x31A2040", Offset = "0x31A1240", VA = "0x1831A2040")]
		internal static void DJDHBHJAKFL(EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x31A2280", Offset = "0x31A1480", VA = "0x1831A2280")]
		internal static void GPFEDAJBGJL(EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x31A2A10", Offset = "0x31A1C10", VA = "0x1831A2A10")]
		[IteratorStateMachine(typeof(JEANINLGOMF))]
		private static IEnumerable<Entity> LNLLLAAJIIB(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x31A1E20", Offset = "0x31A1020", VA = "0x1831A1E20")]
		[IteratorStateMachine(typeof(PHMNFNCNJAP))]
		private static IEnumerable<Entity> CKCKJCNLNJO(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x31A2DC0", Offset = "0x31A1FC0", VA = "0x1831A2DC0")]
		[IteratorStateMachine(typeof(HCFIKCHBDLK))]
		private static IEnumerable<Entity> OKNCIDJHCMG(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x31A2E40", Offset = "0x31A2040", VA = "0x1831A2E40")]
		private static bool PBFEHOEJGEL(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[LOJIIDJFKAI(typeof(GPJINHAGDJN), new string[] { })]
public class DGNMBLKBPAN : GPJINHAGDJN, COEMEMEDCFH, CBFMKNIGECP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private JHLNNPKIFCO KOKEGENGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private LFIBHLPOILP PPDJEICCKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private IBAFENGCGOE CCPHBLENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private DJCLCEOJBJF FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private DFPNHPPNFLJ ELCDAMLJAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private BDAJNAKKLOI BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private IPBKNNKPCHC CGLLMAJNLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private NINFMKFKPIG DHFDEFJOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private NOGKKJEEDNP HLFPFGGCOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private CGLADJHJCEM CBLJIOEJBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private BDFDGLPPMOH HIOJLLPHGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private LKGNBGJGHAA FIECGFNHODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private DEMDCLJBMBJ MCLILDBFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private EOGBLGKJGCD BEPEJBEHEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private PEJNHEGAEGK AOCCCIOCKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private KGOCHOHEAHM GFECAPKCLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private MCAEHJPOCLP LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JHLNNPKIFCO BELPKEBIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public GAOMEBKFAAA DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CPEFIMBHABA IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public LFIBHLPOILP FJPJBKHCDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IBAFENGCGOE HOEJKHDAMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NPFNHEGAPFJ APIPCEEBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public DJCLCEOJBJF NCKPBBOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DFPNHPPNFLJ JHLNDBLKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D0", Offset = "0x6C62D0", VA = "0x1806C70D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public BDAJNAKKLOI LHBKKNBFPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6DD760", Offset = "0x6DC960", VA = "0x1806DD760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public IPBKNNKPCHC MBBHHOCIIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6C70B0", Offset = "0x6C62B0", VA = "0x1806C70B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public PMEGIOPIHFM LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6DD770", Offset = "0x6DC970", VA = "0x1806DD770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public NINFMKFKPIG NEOGHNFHADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6DD780", Offset = "0x6DC980", VA = "0x1806DD780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NOGKKJEEDNP KOEKIONFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6DD700", Offset = "0x6DC900", VA = "0x1806DD700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public CGLADJHJCEM BNAKAEDMIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6DD710", Offset = "0x6DC910", VA = "0x1806DD710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public BDFDGLPPMOH FGOFHGLAPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7036D0", Offset = "0x7028D0", VA = "0x1807036D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public LKGNBGJGHAA FDGCGGHGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6CDD80", Offset = "0x6CCF80", VA = "0x1806CDD80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DEMDCLJBMBJ GFPKMCENMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x6CDE20", Offset = "0x6CD020", VA = "0x1806CDE20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public EOGBLGKJGCD MKLOEABFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7036A0", Offset = "0x7028A0", VA = "0x1807036A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public PEJNHEGAEGK CGCPGBMKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD720", Offset = "0x6DC920", VA = "0x1806DD720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public KGOCHOHEAHM CIEFHNFOHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6DD730", Offset = "0x6DC930", VA = "0x1806DD730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public MCAEHJPOCLP CINGNKENKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6DD750", Offset = "0x6DC950", VA = "0x1806DD750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAA0", Offset = "0x6ECCA0", VA = "0x1806EDAA0", Slot = "21")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2C56630", Offset = "0x2C55830", VA = "0x182C56630", Slot = "22")]
	public void JKLOGDJOLHP(JHLNNPKIFCO JAOCFOBBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x21EC940", Offset = "0x21EBB40", VA = "0x1821EC940", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2C56610", Offset = "0x2C55810", VA = "0x182C56610", Slot = "23")]
	public void AEPAOFPFGOA(JHLNNPKIFCO JAOCFOBBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DGNMBLKBPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class KKHBPEFIMOA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NLMFEFOPIAE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public KKHBPEFIMOA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6DD790", Offset = "0x6DC990", VA = "0x1806DD790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41C9FF0", Offset = "0x41C91F0", VA = "0x1841C9FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
		[DebuggerHidden]
		public NLMFEFOPIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x41C9E40", Offset = "0x41C9040", VA = "0x1841C9E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x41C9FB0", Offset = "0x41C91B0", VA = "0x1841C9FB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong BBKKCEPBGIA = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong AKAMEBDDJNO = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int FCJMBIPACOE = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int GIIKEHGOMPH = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int JAECDFHNFFA = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int LJCJHBKLPLG = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> FFOOLEPKCGE;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A610", VA = "0x18076B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int KPABNKEIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6E2C90", Offset = "0x6E1E90", VA = "0x1806E2C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x76B320", Offset = "0x76A520", VA = "0x18076B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x31B5480", Offset = "0x31B4680", VA = "0x1831B5480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x31B5160", Offset = "0x31B4360", VA = "0x1831B5160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x31B57B0", Offset = "0x31B49B0", VA = "0x1831B57B0")]
	public KKHBPEFIMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x31B5830", Offset = "0x31B4A30", VA = "0x1831B5830")]
	public KKHBPEFIMOA(int KHFADEKJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x31B56D0", Offset = "0x31B48D0", VA = "0x1831B56D0")]
	public bool PCGJMBHDOGN(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x31B4DA0", Offset = "0x31B3FA0", VA = "0x1831B4DA0")]
	public bool CCBOGEEGFOC(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x31B4D20", Offset = "0x31B3F20", VA = "0x1831B4D20")]
	public bool BBIJEGALJJM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x31B5470", Offset = "0x31B4670", VA = "0x1831B5470")]
	public bool HGGGGBFNODB(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x31B4E90", Offset = "0x31B4090", VA = "0x1831B4E90")]
	public void ENCHMHKFMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x31B4F20", Offset = "0x31B4120", VA = "0x1831B4F20")]
	public void FAOKIKBFOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x31B5380", Offset = "0x31B4580", VA = "0x1831B5380")]
	public void HDECKBNAIGA(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x31B5010", Offset = "0x31B4210", VA = "0x1831B5010")]
	public void FPNLAFLJCKH(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x31B5640", Offset = "0x31B4840", VA = "0x1831B5640")]
	public bool OGNHIEBNHGO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x31B5520", Offset = "0x31B4720", VA = "0x1831B5520")]
	public void NGACHCOLDNM(int ELOEOOGBENM, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x31B4A20", Offset = "0x31B3C20", VA = "0x1831B4A20")]
	public void AFNMACFKKMI(int JFKLAOAGCCB, int BMJHAAKDFMA, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x31B4C50", Offset = "0x31B3E50", VA = "0x1831B4C50")]
	public int AOHLLDNPMGN(int OCCKKIPCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x31B4BE0", Offset = "0x31B3DE0", VA = "0x1831B4BE0")]
	public int AOHLLDNPMGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x31B5110", Offset = "0x31B4310", VA = "0x1831B5110")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x31B5310", Offset = "0x31B4510", VA = "0x1831B5310", Slot = "4")]
	[IteratorStateMachine(typeof(NLMFEFOPIAE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x31B5310", Offset = "0x31B4510", VA = "0x1831B5310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class BJGEOGLBCGK<T> : global::AAAGDCFOBOE<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::DEJGHNLFIHL<T> DINCDDJBCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::KAAKIKFDMHB<T> CPFAGJHAJGF;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x1764C70", Offset = "0x1763E70", VA = "0x181764C70")]
	public BJGEOGLBCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x228E630", Offset = "0x228D830", VA = "0x18228E630")]
	public BJGEOGLBCGK(global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x228E3C0", Offset = "0x228D5C0", VA = "0x18228E3C0", Slot = "11")]
	public override T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x228DFD0", Offset = "0x228D1D0", VA = "0x18228DFD0", Slot = "12")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class GFDEPHMAKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x25ABED0", Offset = "0x25AB0D0", VA = "0x1825ABED0")]
	public static NMLCFAIOCDK KJDPCLCGNLB<T>(this GINHFLNLBFM ELCMIPNJFNP, global::PHNOBDPMINP<T> IGHJIHNAPBA, global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF) where T : struct
	{
		return default(NMLCFAIOCDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class IMBMOFOCABC<T> : global::BJGEOGLBCGK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x27E2870", Offset = "0x27E1A70", VA = "0x1827E2870")]
	public IMBMOFOCABC(T LOOCNKEBNDJ, T KLDHGDMNHDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class MJLMGKPALMD<T> : global::AAAGDCFOBOE<T> where T : struct, HGKJFOODIMO
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CBC0", Offset = "0x2E6BDC0", VA = "0x182E6CBC0", Slot = "11")]
	public override T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CA90", Offset = "0x2E6BC90", VA = "0x182E6CA90", Slot = "12")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x246D140", Offset = "0x246C340", VA = "0x18246D140")]
	public MJLMGKPALMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class HLBAFPNMBMM : NAFDCBJOMHH
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type LDNIEKAGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG, in EGIBCKCHGAP JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, in LONBCMOJAJF JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void OKJGILDOJEJ(GDKEGMAHJIA EMEJPAMPJKG, NGFPDGDPGKP CFPEBKLBEPN, [Optional] object MAFDHEKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	protected HLBAFPNMBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class AAAGDCFOBOE<T> : HLBAFPNMBMM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type LDNIEKAGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x33DECC0", Offset = "0x33DDEC0", VA = "0x1833DECC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x33DFD70", Offset = "0x33DEF70", VA = "0x1833DFD70", Slot = "8")]
	public override void LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG, in EGIBCKCHGAP MOOHJICILGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x33DF690", Offset = "0x33DE890", VA = "0x1833DF690", Slot = "9")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, in LONBCMOJAJF GEMNKBDIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x33E0DA0", Offset = "0x33DFFA0", VA = "0x1833E0DA0", Slot = "10")]
	public override void OKJGILDOJEJ(GDKEGMAHJIA EMEJPAMPJKG, NGFPDGDPGKP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30")]
	protected AAAGDCFOBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class EGBOGGDAKOC
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class FDNGLLLIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class PHGDGPODCJA<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
			public PHGDGPODCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x3299780", Offset = "0x3298980", VA = "0x183299780")]
			internal void <RegisterFixedString>b__0(GDKEGMAHJIA p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x3299AB0", Offset = "0x3298CB0", VA = "0x183299AB0")]
			internal T <RegisterFixedString>b__1(GDKEGMAHJIA p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x41C4770", Offset = "0x41C3970", VA = "0x1841C4770")]
		public static void PFFOHNDHOEB(CDAGGLGHKNE ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x27443F0", Offset = "0x27435F0", VA = "0x1827443F0")]
		private static void NGKLIHHINNE<T>(CDAGGLGHKNE ANLABGKNJHG, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2744360", Offset = "0x2743560", VA = "0x182744360")]
		private static void JDAKJPKKLIL<T>(GDKEGMAHJIA KHNOBAAPEAO, T AEOKKHKBMBB, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2743D10", Offset = "0x2742F10", VA = "0x182743D10")]
		private static T FLBABJJJLCH<T>(GDKEGMAHJIA KHNOBAAPEAO, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public FDNGLLLIHOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class EPJCKMLPBPE : KENMGPMEAAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private CDAGGLGHKNE ANLABGKNJHG;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2743B50", Offset = "0x2742D50", VA = "0x182743B50", Slot = "6")]
		public override void LEOMFAEFBGI<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x41C4070", Offset = "0x41C3270", VA = "0x1841C4070")]
		public static void POALIMPAOBL(CDAGGLGHKNE ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x41C4120", Offset = "0x41C3320", VA = "0x1841C4120")]
		public EPJCKMLPBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A8E0", Offset = "0x2C59AE0", VA = "0x182C5A8E0")]
	public static void GIPOAJMDPFD(CDAGGLGHKNE ANLABGKNJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x1F985A0", Offset = "0x1F977A0", VA = "0x181F985A0")]
	public static void KAILEDHADHG<T>(CDAGGLGHKNE ANLABGKNJHG, global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x1F98530", Offset = "0x1F97730", VA = "0x181F98530")]
	public static void KABEEAMPAMG<T>(CDAGGLGHKNE HIFHBPOKANI) where T : struct, HGKJFOODIMO
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public interface CDAGGLGHKNE : global::GDIKFDIOHFC<CDAGGLGHKNE>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJDPCLCGNLB(Type DDJDPMGLPAE, NAFDCBJOMHH HIFHBPOKANI);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIGJNHOBOLH(Type DDJDPMGLPAE, out NAFDCBJOMHH HIFHBPOKANI);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class OKOKKPPOJHI
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A74970", Offset = "0x2A73B70", VA = "0x182A74970")]
	public static void KJDPCLCGNLB(this CDAGGLGHKNE IAFMOECNDHE, NAFDCBJOMHH HIFHBPOKANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[LOJIIDJFKAI(typeof(GINHFLNLBFM), new string[] { })]
public sealed class CFLAOEJELHP : GINHFLNLBFM, global::GDIKFDIOHFC<GINHFLNLBFM>, LFPMKPLIAAM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<NMLCFAIOCDK, NAFDCBJOMHH> ANLABGKNJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private CDAGGLGHKNE CJLLIMPENGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool PGIMNJLLNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x781170", Offset = "0x780370", VA = "0x180781170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C48380", Offset = "0x2C47580", VA = "0x182C48380")]
	public CFLAOEJELHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C482C0", Offset = "0x2C474C0", VA = "0x182C482C0")]
	public CFLAOEJELHP(Dictionary<NMLCFAIOCDK, NAFDCBJOMHH> ANLABGKNJHG, bool LJJHHADAAOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C48070", Offset = "0x2C47270", VA = "0x182C48070", Slot = "7")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C48240", Offset = "0x2C47440", VA = "0x182C48240", Slot = "8")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C47C60", Offset = "0x2C46E60", VA = "0x182C47C60", Slot = "9")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C47E60", Offset = "0x2C47060", VA = "0x182C47E60", Slot = "4")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C480D0", Offset = "0x2C472D0", VA = "0x182C480D0", Slot = "5")]
	public void KJDPCLCGNLB(NMLCFAIOCDK LIKFEBDBPON, NAFDCBJOMHH HIFHBPOKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C47F30", Offset = "0x2C47130", VA = "0x182C47F30")]
	[Conditional("DEBUG_BUILD")]
	private void HLNHHEJDAOO(NMLCFAIOCDK LIKFEBDBPON, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C47CB0", Offset = "0x2C46EB0", VA = "0x182C47CB0", Slot = "6")]
	public bool GIGJNHOBOLH(NMLCFAIOCDK LIKFEBDBPON, out NAFDCBJOMHH HIFHBPOKANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C47B80", Offset = "0x2C46D80", VA = "0x182C47B80", Slot = "10")]
	public GINHFLNLBFM EHDNGDPNMFL()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[LOJIIDJFKAI(typeof(CDAGGLGHKNE), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.TypeSerializer)]
	public sealed class TypeSerializerService : LFPMKPLIAAM, CDAGGLGHKNE, global::GDIKFDIOHFC<CDAGGLGHKNE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, NAFDCBJOMHH> ANLABGKNJHG;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool PGIMNJLLNOP
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x703000", Offset = "0x702200", VA = "0x180703000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8D10", Offset = "0x2CC7F10", VA = "0x182CC8D10")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8D90", Offset = "0x2CC7F90", VA = "0x182CC8D90")]
		public TypeSerializerService(Dictionary<Type, NAFDCBJOMHH> ANLABGKNJHG, bool LJJHHADAAOJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8B40", Offset = "0x2CC7D40", VA = "0x182CC8B40", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8BA0", Offset = "0x2CC7DA0", VA = "0x182CC8BA0", Slot = "5")]
		public void KJDPCLCGNLB(Type DDJDPMGLPAE, NAFDCBJOMHH HIFHBPOKANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8A60", Offset = "0x2CC7C60", VA = "0x182CC8A60", Slot = "6")]
		public bool GIGJNHOBOLH(Type DDJDPMGLPAE, out NAFDCBJOMHH HIFHBPOKANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8980", Offset = "0x2CC7B80", VA = "0x182CC8980", Slot = "7")]
		public CDAGGLGHKNE EHDNGDPNMFL()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[LOJIIDJFKAI(typeof(OCNNCEMNKMG), new string[] { })]
internal sealed class HKHGGDGCPJH : OCNNCEMNKMG, LFPMKPLIAAM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<NMLCFAIOCDK, PMKHHHLLOPE> IJOAAMKIMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x31A7EF0", Offset = "0x31A70F0", VA = "0x1831A7EF0", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x31A7FB0", Offset = "0x31A71B0", VA = "0x1831A7FB0", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x31A7F40", Offset = "0x31A7140", VA = "0x1831A7F40", Slot = "4")]
	public void KJDPCLCGNLB(NMLCFAIOCDK MPKOBDPILJB, Type HHLBCDGILNF, PMKHHHLLOPE LJMEBHLNOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x31A7CF0", Offset = "0x31A6EF0", VA = "0x1831A7CF0", Slot = "5")]
	public bool AKHCPCIAJIF(NMLCFAIOCDK MPKOBDPILJB, out PMKHHHLLOPE LJMEBHLNOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x31A7D60", Offset = "0x31A6F60", VA = "0x1831A7D60")]
	[Conditional("DEBUG_BUILD")]
	private void GGOGHGBBJNB(NMLCFAIOCDK MPKOBDPILJB, Type HHLBCDGILNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x31A8010", Offset = "0x31A7210", VA = "0x1831A8010")]
	public HKHGGDGCPJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[LOJIIDJFKAI(typeof(POIJNILNJOE), new string[] { })]
internal sealed class IDKKKNIOCEF : POIJNILNJOE, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly KKHBPEFIMOA CPOLDJAHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<IOLFAAOECPP, int> KANMBGKMMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> MBFGHJLKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[IMNMHIBEIDL]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int LJAINNNDGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x31AD210", Offset = "0x31AC410", VA = "0x1831AD210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x792540", Offset = "0x791740", VA = "0x180792540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9284A0", Offset = "0x9276A0", VA = "0x1809284A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x31AD020", Offset = "0x31AC220", VA = "0x1831AD020", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x31AD260", Offset = "0x31AC460", VA = "0x1831AD260", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x31AD160", Offset = "0x31AC360", VA = "0x1831AD160", Slot = "8")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x31ACAF0", Offset = "0x31ABCF0", VA = "0x1831ACAF0")]
	private void AHMBLEDJIAC(NFJEDPPAJMK OOGHONKGHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x31ACEE0", Offset = "0x31AC0E0", VA = "0x1831ACEE0", Slot = "4")]
	public bool DLHDPJHIOPA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x31ACB90", Offset = "0x31ABD90", VA = "0x1831ACB90", Slot = "5")]
	public void DBOBEMBMCPG(IOLFAAOECPP IOCKLNNJMIA, Span<NMLCFAIOCDK> ELCMIPNJFNP, bool PHHHFKPPFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x31AD020", Offset = "0x31AC220", VA = "0x1831AD020", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x31AD2E0", Offset = "0x31AC4E0", VA = "0x1831AD2E0")]
	public IDKKKNIOCEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class FLPMMBNNDDC
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x31A4890", Offset = "0x31A3A90", VA = "0x1831A4890")]
	public static void GDHIODHAEFN(this GDKEGMAHJIA EMEJPAMPJKG, ReadOnlyMemory<byte> GECDJJHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2EABDF0", Offset = "0x2EAAFF0", VA = "0x182EABDF0")]
	public static void EFLAGMJPJKC<T>(this GDKEGMAHJIA EMEJPAMPJKG, in T JFBPNBNBHOE) where T : struct, HGKJFOODIMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2EABF20", Offset = "0x2EAB120", VA = "0x182EABF20")]
	public static T NDJBHKCBOCI<T>(this GDKEGMAHJIA EMEJPAMPJKG) where T : struct, HGKJFOODIMO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x31A4860", Offset = "0x31A3A60", VA = "0x1831A4860")]
	public static void EFLAGMJPJKC(this GDKEGMAHJIA EMEJPAMPJKG, JKDEDHBDHBM AHPJJBDHKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x31A4A30", Offset = "0x31A3C30", VA = "0x1831A4A30")]
	public static JKDEDHBDHBM JBOBDIPJLJH(this GDKEGMAHJIA EMEJPAMPJKG)
	{
		return default(JKDEDHBDHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x31A4A60", Offset = "0x31A3C60", VA = "0x1831A4A60")]
	public static void OKJDCCMIKNF(this GDKEGMAHJIA ABIHDCBCABG, uint JGNCEKJOLON, bool GMKHKEIGGNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x31A4910", Offset = "0x31A3B10", VA = "0x1831A4910")]
	public static uint IAKACPCKCFJ(this GDKEGMAHJIA OJMODHIKFDB, bool GMKHKEIGGNH = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class FEGMBDKOLGO
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class MOGGIMALCLA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public MOGGIMALCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x3085390", Offset = "0x3084590", VA = "0x183085390")]
		internal void <GetByteEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x3085400", Offset = "0x3084600", VA = "0x183085400")]
		internal T <GetByteEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class IKHGNDBCMIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public IKHGNDBCMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1F76CA0", Offset = "0x1F75EA0", VA = "0x181F76CA0")]
		internal void <GetSByteEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x1F76D10", Offset = "0x1F75F10", VA = "0x181F76D10")]
		internal T <GetSByteEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class JKNNKDKGLGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public JKNNKDKGLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A120", Offset = "0x3B19320", VA = "0x183B1A120")]
		internal void <GetShortEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A190", Offset = "0x3B19390", VA = "0x183B1A190")]
		internal T <GetShortEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class HBBFIDFNMCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public HBBFIDFNMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7600", Offset = "0x3BF6800", VA = "0x183BF7600")]
		internal void <GetUShortEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7670", Offset = "0x3BF6870", VA = "0x183BF7670")]
		internal T <GetUShortEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class GBCBMIEHMEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public GBCBMIEHMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB5C0", Offset = "0x2BAA7C0", VA = "0x182BAB5C0")]
		internal void <GetIntEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB620", Offset = "0x2BAA820", VA = "0x182BAB620")]
		internal T <GetIntEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class BGEDNCEMAPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public BGEDNCEMAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E41FE0", Offset = "0x3E411E0", VA = "0x183E41FE0")]
		internal void <GetUIntEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x3E42040", Offset = "0x3E41240", VA = "0x183E42040")]
		internal T <GetUIntEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2820", Offset = "0x2EA1A20", VA = "0x182EA2820")]
	public static void MGLBHFJKIMO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EA26D0", Offset = "0x2EA18D0", VA = "0x182EA26D0")]
	private static void ONIMHEDNBPO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x2EA26D0", Offset = "0x2EA18D0", VA = "0x182EA26D0")]
	private static void DHDHBPJGBFO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2580", Offset = "0x2EA1780", VA = "0x182EA2580")]
	private static void APBJJOPDFHO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2580", Offset = "0x2EA1780", VA = "0x182EA2580")]
	private static void IEIPAFKEHDM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2430", Offset = "0x2EA1630", VA = "0x182EA2430")]
	private static void AGHBKKNCFNM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2430", Offset = "0x2EA1630", VA = "0x182EA2430")]
	private static void LCNHGEFPBMM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class BBOBOCOGEKH : EHNCFNMGCGK, FPHKGEBJIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2C44100", Offset = "0x2C43300", VA = "0x182C44100", Slot = "4")]
	private void FEANLCHAMEF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EGOICCPFGIK(GINHFLNLBFM ELCMIPNJFNP);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
	protected BBOBOCOGEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[DDFPMNGAPLM(typeof(LocalPoseData))]
public sealed class KLOGHHNDIIN : BBOBOCOGEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x31B61B0", Offset = "0x31B53B0", VA = "0x1831B61B0", Slot = "5")]
	protected override void EGOICCPFGIK(GINHFLNLBFM ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	public KLOGHHNDIIN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class CopyAuthorityToEntity : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery GKBBEIMEIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery KBPHPMFNMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2C52000", Offset = "0x2C51200", VA = "0x182C52000", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2C51E40", Offset = "0x2C51040", VA = "0x182C51E40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2C51FC0", Offset = "0x2C511C0", VA = "0x182C51FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2C51F90", Offset = "0x2C51190", VA = "0x182C51F90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2C51660", Offset = "0x2C50860", VA = "0x182C51660")]
		private void HMNIHAPDMKO(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2C511E0", Offset = "0x2C503E0", VA = "0x182C511E0")]
		private void CHKFEDEKDDH(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2C51380", Offset = "0x2C50580", VA = "0x182C51380")]
		private void GOKELKEOOPG(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2C519A0", Offset = "0x2C50BA0", VA = "0x182C519A0")]
		private void JJMBCAHBBBC(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2C51C30", Offset = "0x2C50E30", VA = "0x182C51C30")]
		private void NECIPKNIMOI(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2C51B50", Offset = "0x2C50D50", VA = "0x182C51B50")]
		private void KPCEAHNADHF(NFJEDPPAJMK OOGHONKGHEE, int PMIGFHIBOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class BJEDBPLFJHJ : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2C458A0", Offset = "0x2C44AA0", VA = "0x182C458A0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2C45410", Offset = "0x2C44610", VA = "0x182C45410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2C454D0", Offset = "0x2C446D0", VA = "0x182C454D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2C44E30", Offset = "0x2C44030", VA = "0x182C44E30")]
	private void NLICFAHOEKE(NativeArray<Entity> GNGEEFEGDCP, NativeList<Entity> EAPAOOBBMGJ, ComponentDataFromEntity<NKCAEIPLFAF> PMNJGOOLNBI, BufferFromEntity<ChildrenData> LFGPHLBNJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public BJEDBPLFJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class JFOHNHNGEKD : ParentSystemBase<AuthoredParentData, HLMIEDJMAKI, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x31B0890", Offset = "0x31AFA90", VA = "0x1831B0890", Slot = "14")]
	protected override EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7726B0", Offset = "0x7718B0", VA = "0x1807726B0", Slot = "15")]
	protected override EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x31B0850", Offset = "0x31AFA50", VA = "0x1831B0850", Slot = "16")]
	protected override EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x31B0910", Offset = "0x31AFB10", VA = "0x1831B0910", Slot = "17")]
	protected override EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x31B0950", Offset = "0x31AFB50", VA = "0x1831B0950")]
	public JFOHNHNGEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x31B08D0", Offset = "0x31AFAD0", VA = "0x1831B08D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class ICHOBIPMOGN : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object AKFAIOOBKJE;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x31AC3E0", Offset = "0x31AB5E0", VA = "0x1831AC3E0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x31AC0C0", Offset = "0x31AB2C0", VA = "0x1831AC0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x31AC160", Offset = "0x31AB360", VA = "0x1831AC160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public ICHOBIPMOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class EBLECJAMLCJ : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object AKFAIOOBKJE;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A000", Offset = "0x2C59200", VA = "0x182C5A000", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2C59CE0", Offset = "0x2C58EE0", VA = "0x182C59CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2C59D80", Offset = "0x2C58F80", VA = "0x182C59D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public EBLECJAMLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct MGIFPDLOLOA : ISystemStateBufferElementData, IBufferElementData, IEquatable<MGIFPDLOLOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public KFGEJPOHHNK KJNCDAGJAPF;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2A700F0", Offset = "0x2A6F2F0", VA = "0x182A700F0", Slot = "4")]
	public bool Equals(MGIFPDLOLOA IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00")]
	public static MGIFPDLOLOA LOJIFGBJNLM(KFGEJPOHHNK KJNCDAGJAPF)
	{
		return default(MGIFPDLOLOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct LENNAEIOLNF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public KFGEJPOHHNK KJNCDAGJAPF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00")]
	public static LENNAEIOLNF LOJIFGBJNLM(KFGEJPOHHNK KJNCDAGJAPF)
	{
		return default(LENNAEIOLNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class NFGAPLIHOBJ : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2A734D0", Offset = "0x2A726D0", VA = "0x182A734D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2A73660", Offset = "0x2A72860", VA = "0x182A73660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	protected NFGAPLIHOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[LOFBNDLMONN]
internal abstract class FHHOCGHDMCF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected MCAEHJPOCLP LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x31A40D0", Offset = "0x31A32D0", VA = "0x1831A40D0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x31A3B60", Offset = "0x31A2D60", VA = "0x1831A3B60")]
	protected void BGEPHIOCLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x31A3E50", Offset = "0x31A3050", VA = "0x1831A3E50")]
	protected void DHDOHBDGAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x31A3DE0", Offset = "0x31A2FE0", VA = "0x1831A3DE0")]
	protected KAANBEDLICJ DALBGCMGJDD()
	{
		return default(KAANBEDLICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	protected FHHOCGHDMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class LICMNIGOGPC : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E600", Offset = "0x2A6D800", VA = "0x182A6E600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E790", Offset = "0x2A6D990", VA = "0x182A6E790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	protected LICMNIGOGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class CMIPMDHFNFG : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2C49310", Offset = "0x2C48510", VA = "0x182C49310", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2C49420", Offset = "0x2C48620", VA = "0x182C49420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	protected CMIPMDHFNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class CFMGBNGIDAM : NFGAPLIHOBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2C48880", Offset = "0x2C47A80", VA = "0x182C48880", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2C488F0", Offset = "0x2C47AF0", VA = "0x182C488F0")]
	public CFMGBNGIDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class MHKBGOPGGHJ : LICMNIGOGPC
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2A70660", Offset = "0x2A6F860", VA = "0x182A70660", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	public MHKBGOPGGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class EBMHNHCFNDL : CMIPMDHFNFG
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A080", Offset = "0x2C59280", VA = "0x182C5A080", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	public EBMHNHCFNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class IFGMMEHADJG : NFGAPLIHOBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x31AD440", Offset = "0x31AC640", VA = "0x1831AD440", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2C488F0", Offset = "0x2C47AF0", VA = "0x182C488F0")]
	public IFGMMEHADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class IDIGNCICFAK : LICMNIGOGPC
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x31ACA80", Offset = "0x31ABC80", VA = "0x1831ACA80", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2C488F0", Offset = "0x2C47AF0", VA = "0x182C488F0")]
	public IDIGNCICFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class DCPMFAFNILI : CMIPMDHFNFG
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2C55660", Offset = "0x2C54860", VA = "0x182C55660", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E830", Offset = "0x2A6DA30", VA = "0x182A6E830")]
	public DCPMFAFNILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct MEKIGEFFJAD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct HPPGJHBMEJE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct DNFEPNKMINK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct KEPFOAAIAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType ONPDMHJKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType MPPCHDNPEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object AJDBKDIMOHA;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x31B35A0", Offset = "0x31B27A0", VA = "0x1831B35A0")]
	public KEPFOAAIAOD(ComponentType ONPDMHJKADH, ComponentType MPPCHDNPEDD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x1D64E60", Offset = "0x1D64060", VA = "0x181D64E60")]
	public static KEPFOAAIAOD FFPKNNKHNKN<TReq, TTag>(object AJDBKDIMOHA)
	{
		return default(KEPFOAAIAOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class PEOCFAOCDAJ
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string KCKIEIHLPKL = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string PHBHJDBHOCF = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly KEPFOAAIAOD MKLOEABFLBH;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly KEPFOAAIAOD EBACDHOKCIB;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct KFGEJPOHHNK : global::BDDOIGLJFOK<KFGEJPOHHNK>, IGCGKLPONMN, IEquatable<KFGEJPOHHNK>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x31B3AE0", Offset = "0x31B2CE0", VA = "0x1831B3AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x31B3A90", Offset = "0x31B2C90", VA = "0x1831B3A90", Slot = "8")]
	public bool Equals(KFGEJPOHHNK IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x31B3B20", Offset = "0x31B2D20", VA = "0x1831B3B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[LOFBNDLMONN]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	public class UpdateConnectableVisuals : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct CBAFEKKPAIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public KFGEJPOHHNK KJNCDAGJAPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 DACBJNCMNFL;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x41C1EA0", Offset = "0x41C10A0", VA = "0x1841C1EA0")]
			public CBAFEKKPAIL(KFGEJPOHHNK KJNCDAGJAPF, float3 DACBJNCMNFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x41C1E80", Offset = "0x41C1080", VA = "0x1841C1E80")]
			public void EEEPFIIDMLE(out KFGEJPOHHNK KJNCDAGJAPF, out float3 DACBJNCMNFL)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct DCIKKDAELAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
			public DCIKKDAELAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<LENNAEIOLNF> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct PAKCDHKMPPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
			public PAKCDHKMPPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<MGIFPDLOLOA> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct AJICMHHELBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
			public AJICMHHELBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in CEIFDNONLIL com, in DynamicBuffer<MGIFPDLOLOA> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HFFLCNAIGNK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct ODBBKGJDGFJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct KPIOIBECFHL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<LENNAEIOLNF>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LENNAEIOLNF> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x41CA9E0", Offset = "0x41C9BE0", VA = "0x1841CA9E0")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x41CAA60", Offset = "0x41C9C60", VA = "0x1841CAA60")]
				public KPIOIBECFHL OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(KPIOIBECFHL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals BFAPLOAAIBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private ODBBKGJDGFJ LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ODBBKGJDGFJ.KPIOIBECFHL* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x41C5F80", Offset = "0x41C5180", VA = "0x1841C5F80")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, WorldPoseData OJHBEGOMAPB, in DynamicBuffer<LENNAEIOLNF> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x41C6420", Offset = "0x41C5620", VA = "0x1841C6420", Slot = "5")]
			public void ReadFromDisplayClass(ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x41C6450", Offset = "0x41C5650", VA = "0x1841C6450", Slot = "6")]
			public void WriteToDisplayClass(ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x41C6200", Offset = "0x41C5400", VA = "0x1841C6200", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x41C62E0", Offset = "0x41C54E0", VA = "0x1841C62E0")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref ODBBKGJDGFJ.KPIOIBECFHL DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x41C61C0", Offset = "0x41C53C0", VA = "0x1841C61C0")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x41C5F10", Offset = "0x41C5110", VA = "0x1841C5F10")]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct ANEBPJFBGLH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct BHNNOLGGJNH
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct ABDCAAIINNE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x41C1B50", Offset = "0x41C0D50", VA = "0x1841C1B50")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x41C1BC0", Offset = "0x41C0DC0", VA = "0x1841C1BC0")]
				public ABDCAAIINNE OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(ABDCAAIINNE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private BHNNOLGGJNH LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BHNNOLGGJNH.ABDCAAIINNE* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x41C0EC0", Offset = "0x41C00C0", VA = "0x1841C0EC0")]
			internal void AOFNEGGIPNF(in WorldPoseData OJHBEGOMAPB, in DynamicBuffer<MGIFPDLOLOA> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x119AF90", Offset = "0x119A190", VA = "0x18119AF90", Slot = "5")]
			public void ReadFromDisplayClass(ref PAKCDHKMPPE IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x41C1070", Offset = "0x41C0270", VA = "0x1841C1070", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x41C1140", Offset = "0x41C0340", VA = "0x1841C1140")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref BHNNOLGGJNH.ABDCAAIINNE DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x41C0FD0", Offset = "0x41C01D0", VA = "0x1841C0FD0")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref PAKCDHKMPPE IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CGMAACKBPDA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct NNCHBFPCKJG
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct BCMMEBNCGON
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<CEIFDNONLIL>.Runtime DOJBCBMLBIL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<CEIFDNONLIL> FMDJBMHLKLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x41CA040", Offset = "0x41C9240", VA = "0x1841CA040")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x41CA0D0", Offset = "0x41C92D0", VA = "0x1841CA0D0")]
				public BCMMEBNCGON OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(BCMMEBNCGON);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private NNCHBFPCKJG LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NNCHBFPCKJG.BCMMEBNCGON* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x41C1F30", Offset = "0x41C1130", VA = "0x1841C1F30")]
			internal void AOFNEGGIPNF(in WorldPoseData OJHBEGOMAPB, in CEIFDNONLIL DEIGCPCMMPG, in DynamicBuffer<MGIFPDLOLOA> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x119AF90", Offset = "0x119A190", VA = "0x18119AF90", Slot = "5")]
			public void ReadFromDisplayClass(ref AJICMHHELBO IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x41C20D0", Offset = "0x41C12D0", VA = "0x1841C20D0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x41C2150", Offset = "0x41C1350", VA = "0x1841C2150")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref NNCHBFPCKJG.BCMMEBNCGON DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x41C2090", Offset = "0x41C1290", VA = "0x1841C2090")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref AJICMHHELBO IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery JOENFDKOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery IANPOBHMFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery BCFEBBFAMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery GIKEAIFGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery AMDJIPKHOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery JIDHPICCDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery LIJICKLIBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery NNKGLNOFECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery HIFKGEENBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery CAMNKNMBNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::JBJIOMDHKBO<KFGEJPOHHNK, GJLAMBHCAMH> EDPDCLMFPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private KGOCHOHEAHM GFECAPKCLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private CGLADJHJCEM CBLJIOEJBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private HFNIHCOGOJL HJFDMKOEODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery GBJDAPCIAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker GFKMMGCPDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery LHHCINDMMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery OBKMDJEJFFN;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2CCD010", Offset = "0x2CCC210", VA = "0x182CCD010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9890", Offset = "0x2CC8A90", VA = "0x182CC9890")]
		internal GJLAMBHCAMH ALOKEFPAEBO(KFGEJPOHHNK KJNCDAGJAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD8E0", Offset = "0x2CCCAE0", VA = "0x182CCD8E0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD360", Offset = "0x2CCC560", VA = "0x182CCD360", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD5E0", Offset = "0x2CCC7E0", VA = "0x182CCD5E0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD770", Offset = "0x2CCC970", VA = "0x182CCD770", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD5A0", Offset = "0x2CCC7A0", VA = "0x182CCD5A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBD00", Offset = "0x2CCAF00", VA = "0x182CCBD00")]
		private void HNKNJBKFJAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD050", Offset = "0x2CCC250", VA = "0x182CCD050")]
		private void MCNJHIGNNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2CC94E0", Offset = "0x2CC86E0", VA = "0x182CC94E0")]
		private void AEAMONOOMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD7B0", Offset = "0x2CCC9B0", VA = "0x182CCD7B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2CCCB30", Offset = "0x2CCBD30", VA = "0x182CCCB30")]
		private void KJAIMLDDOOF(EntityQuery GKBBEIMEIPO, EntityQuery GIENCMBCINK, EntityQuery KBPHPMFNMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9F00", Offset = "0x2CC9100", VA = "0x182CC9F00")]
		private void BCBAFCFKBLF(EntityQuery KBPHPMFNMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2CCAA90", Offset = "0x2CC9C90", VA = "0x182CCAA90")]
		private void DMFAOBCOHHM(NativeArrayAsync<Entity> GCHMMICFNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2CCA8B0", Offset = "0x2CC9AB0", VA = "0x182CCA8B0")]
		private void DCDBMMIMHHA(NativeArrayAsync<Entity> OGDEFABGACE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2CCC990", Offset = "0x2CCBB90", VA = "0x182CCC990")]
		private void JOAGFKKNNIN(NativeArrayAsync<Entity> DGPMFNFOMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBB90", Offset = "0x2CCAD90", VA = "0x182CCBB90")]
		private void GLBMHOEFLIJ(NativeList<KFGEJPOHHNK> DPIDOCFEJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2CCC340", Offset = "0x2CCB540", VA = "0x182CCC340")]
		private NativeList<KFGEJPOHHNK> INCBDNGKIKI(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<KFGEJPOHHNK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2CC98E0", Offset = "0x2CC8AE0", VA = "0x182CC98E0")]
		private void ANIAMFJDDBD(NativeArray<Entity> GNGEEFEGDCP, NativeList<KFGEJPOHHNK> DPIDOCFEJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBE10", Offset = "0x2CCB010", VA = "0x182CCBE10")]
		private void IKPFHNIADPG(NativeArray<Entity> BICAIHCABBB, NativeArray<Entity> FPOPONLDEPD, NativeList<KFGEJPOHHNK> MBFGHJLKLPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2CCA400", Offset = "0x2CC9600", VA = "0x182CCA400")]
		private void CADKKOFIGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2CCAD70", Offset = "0x2CC9F70", VA = "0x182CCAD70")]
		private NativeListAsync<CBAFEKKPAIL> DPBEBKBOCHI(EntityQuery JLMGAJOHFKO, Func<NativeList<CBAFEKKPAIL>, JobHandle> AOGJIBBKMOE)
		{
			return default(NativeListAsync<CBAFEKKPAIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB0B0", Offset = "0x2CCA2B0", VA = "0x182CCB0B0")]
		private JobHandle EAKBNCBJCCD(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB9C0", Offset = "0x2CCABC0", VA = "0x182CCB9C0")]
		private JobHandle GCHDDHNHBIB(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2CCC860", Offset = "0x2CCBA60", VA = "0x182CCC860")]
		private JobHandle JFNHCOPIIBC(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB240", Offset = "0x2CCA440", VA = "0x182CCB240")]
		private void EIMIBBMKOED(NativeListAsync<CBAFEKKPAIL> NHOGENNANEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB4D0", Offset = "0x2CCA6D0", VA = "0x182CCB4D0")]
		private void FDEKAIDOLIP(NativeListAsync<CBAFEKKPAIL> NHOGENNANEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD1A0", Offset = "0x2CCC3A0", VA = "0x182CCD1A0")]
		private bool NBPIPADACDJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2CCA9C0", Offset = "0x2CC9BC0", VA = "0x182CCA9C0")]
		private NativeArray<Entity> DHEPGNDLOHF(Entity OAOGLFGGBPI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9FD0", Offset = "0x2CC91D0", VA = "0x182CC9FD0")]
		private KFGEJPOHHNK BGCDIBBNNJE(NativeList<KFGEJPOHHNK> MBFGHJLKLPA)
		{
			return default(KFGEJPOHHNK);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBB00", Offset = "0x2CCAD00", VA = "0x182CCBB00")]
		private void GFOKJNBMOLF(KFGEJPOHHNK KJNCDAGJAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD200", Offset = "0x2CCC400", VA = "0x182CCD200", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2CCAEB0", Offset = "0x2CCA0B0", VA = "0x182CCAEB0")]
		public static EntityQuery DPPANAPLKKJ(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2CCB760", Offset = "0x2CCA960", VA = "0x182CCB760")]
		public static EntityQuery GCFLBLDIMBO(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2CCA190", Offset = "0x2CC9390", VA = "0x182CCA190")]
		public static EntityQuery BHHJKEGPFND(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[MBALNPKLAGP(FOFKCKDBIPD.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private DJCLCEOJBJF FPAHGFEONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private AOHCKDBFDIB HEGKMFCNMCJ;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A88E00", Offset = "0x2A88000", VA = "0x182A88E00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A894C0", Offset = "0x2A886C0", VA = "0x182A894C0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A88F00", Offset = "0x2A88100", VA = "0x182A88F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class KAANIFMEHKC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public MIDGCDECPDI ALLKDINDGEN;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KAANIFMEHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
	public KAANIFMEHKC(MIDGCDECPDI ALLKDINDGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x31B1860", Offset = "0x31B0A60", VA = "0x1831B1860", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class KHHMELCFBHA : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService CCJAOIAIHHP;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x31B3BC0", Offset = "0x31B2DC0", VA = "0x1831B3BC0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x31B3B70", Offset = "0x31B2D70", VA = "0x1831B3B70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x31B3BA0", Offset = "0x31B2DA0", VA = "0x1831B3BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	protected KHHMELCFBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class IKGNJCJKDHP : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery ICNCIOMOAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery JIEFELCOICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery MEFPAAALPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery NCIFABMCOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService LEEABEOMEGF;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int GHENHLBAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x31AE230", Offset = "0x31AD430", VA = "0x1831AE230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int PIOCBEALFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x31AE000", Offset = "0x31AD200", VA = "0x1831AE000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x31AE620", Offset = "0x31AD820", VA = "0x1831AE620", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x31AE400", Offset = "0x31AD600", VA = "0x1831AE400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x31AE600", Offset = "0x31AD800", VA = "0x1831AE600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x31AE2A0", Offset = "0x31AD4A0", VA = "0x1831AE2A0")]
	public int ILPEILOOILG(SceneTag BGCBBDJLHHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x31AE310", Offset = "0x31AD510", VA = "0x1831AE310")]
	public int LHLAAECBKCO(SceneTag BGCBBDJLHHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x31AE010", Offset = "0x31AD210", VA = "0x1831AE010")]
	protected void GNAMPJEKJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x31ADEA0", Offset = "0x31AD0A0", VA = "0x1831ADEA0")]
	protected void DFLJPGJHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x31ADFB0", Offset = "0x31AD1B0", VA = "0x1831ADFB0")]
	public NativeArrayAsync<Entity> EDJJJKMLCHD(SceneTag BGCBBDJLHHN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x31AE2C0", Offset = "0x31AD4C0", VA = "0x1831AE2C0")]
	public NativeArrayAsync<Entity> LHJEDCPABDE(SceneTag BGCBBDJLHHN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x31ADD60", Offset = "0x31ACF60", VA = "0x1831ADD60")]
	public bool BCIMIJPHOKA(SceneTag BGCBBDJLHHN, out NativeArrayAsync<Entity> ALLKDINDGEN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x31AE240", Offset = "0x31AD440", VA = "0x1831AE240")]
	public bool IGNAOPBPCKO(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x31AE330", Offset = "0x31AD530", VA = "0x1831AE330")]
	public MIDGCDECPDI LMGDNNBAIHJ(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x31ADDF0", Offset = "0x31ACFF0", VA = "0x1831ADDF0")]
	public bool CCBOPNINIEJ(Entity OAOGLFGGBPI, out KAANIFMEHKC ALLKDINDGEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x31ADE60", Offset = "0x31AD060", VA = "0x1831ADE60")]
	public void CKKJBILLNPP(Entity OAOGLFGGBPI, KAANIFMEHKC ALLKDINDGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x31AE3A0", Offset = "0x31AD5A0", VA = "0x1831AE3A0")]
	public bool LOPKHLFIMAA(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void AEEKNBJJNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public IKGNJCJKDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class DDIIGOMIFDD : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery KOLIHBAFFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C55AE0", Offset = "0x2C54CE0", VA = "0x182C55AE0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C55740", Offset = "0x2C54940", VA = "0x182C55740", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C55800", Offset = "0x2C54A00", VA = "0x182C55800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2575410", Offset = "0x2574610", VA = "0x182575410")]
	private bool IELCMMKFOLD<TComponentData>(EntityQuery JLMGAJOHFKO, out NativeArray<Entity> GNGEEFEGDCP, out NativeArray<TComponentData> AOONNNAPHDO) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C556D0", Offset = "0x2C548D0", VA = "0x182C556D0")]
	public MIDGCDECPDI LMGDNNBAIHJ(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public DDIIGOMIFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery PHCJLFMMJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery ODOAJCHFDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery DACICHHHJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBEFB0", Offset = "0x2CBE1B0", VA = "0x182CBEFB0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE8F0", Offset = "0x2CBDAF0", VA = "0x182CBE8F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBEB20", Offset = "0x2CBDD20", VA = "0x182CBEB20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE810", Offset = "0x2CBDA10", VA = "0x182CBE810")]
		private void AOHLLDNPMGN(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE880", Offset = "0x2CBDA80", VA = "0x182CBE880")]
		private void BCBAFCFKBLF(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBEAB0", Offset = "0x2CBDCB0", VA = "0x182CBEAB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CBEC50", Offset = "0x2CBDE50", VA = "0x182CBEC50")]
		private void PDDELNAGNBO(EntityQuery JLMGAJOHFKO, bool BEIBHGPBPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class DAFDIPMPEAJ : DHDEFGPGMMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct OHNABPIEGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public OHNABPIEGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BJGFMCMMPDG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct ENOPHELFFHE
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct LPOFPJKNJGH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime KFLCDHONKNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime EPOJHMHGNJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime LBIBDPJKNDN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PIAEOHBJBAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> OKKKDBHPPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> GGEEGPBEOKG;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x41C3E70", Offset = "0x41C3070", VA = "0x1841C3E70")]
			public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x41C3EF0", Offset = "0x41C30F0", VA = "0x1841C3EF0")]
			public LPOFPJKNJGH OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(LPOFPJKNJGH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private ENOPHELFFHE LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ENOPHELFFHE.LPOFPJKNJGH* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3B20", Offset = "0x2CB2D20", VA = "0x182CB3B20")]
		internal void AOFNEGGIPNF(Entity OHJOALHOEEJ, SplineShapeData IGJFJCHKKMF, DynamicBuffer<LinkedEntityGroup> IEGPGBKLAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3B90", Offset = "0x2CB2D90", VA = "0x182CB3B90", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3C10", Offset = "0x2CB2E10", VA = "0x182CB3C10")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref ENOPHELFFHE.LPOFPJKNJGH DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3B80", Offset = "0x2CB2D80", VA = "0x182CB3B80")]
		public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GMJBOKFHHIK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct LLCBCCDFBOH
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct OCMHLNBINEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABDIGJHNOKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime JLFIMJMPGMJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JLPMLHIMHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> OBGEEHLIIDG;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x41C9880", Offset = "0x41C8A80", VA = "0x1841C9880")]
			public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x41C98E0", Offset = "0x41C8AE0", VA = "0x1841C98E0")]
			public OCMHLNBINEA OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(OCMHLNBINEA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> CIOKPOMIGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private LLCBCCDFBOH LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LLCBCCDFBOH.OCMHLNBINEA* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5530", Offset = "0x2CB4730", VA = "0x182CB5530")]
		internal void AOFNEGGIPNF(Entity CFGMGHMOBMD, SplinePointParentData EIDEAPADNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5720", Offset = "0x2CB4920", VA = "0x182CB5720", Slot = "5")]
		public void ReadFromDisplayClass(ref OHNABPIEGHK IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5600", Offset = "0x2CB4800", VA = "0x182CB5600", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5670", Offset = "0x2CB4870", VA = "0x182CB5670")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref LLCBCCDFBOH.OCMHLNBINEA DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x2CB55C0", Offset = "0x2CB47C0", VA = "0x182CB55C0")]
		public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD, ref OHNABPIEGHK IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery HNEDEFEIDIH;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C551D0", Offset = "0x2C543D0", VA = "0x182C551D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C55280", Offset = "0x2C54480", VA = "0x182C55280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public DAFDIPMPEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C54F30", Offset = "0x2C54130", VA = "0x182C54F30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C554C0", Offset = "0x2C546C0", VA = "0x182C554C0")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C54DD0", Offset = "0x2C53FD0", VA = "0x182C54DD0")]
	public static EntityQuery CBPGCGEEHHJ(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public sealed class CJLJGAHNBCL : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private LKPHHNIFJFE NEIHAKKOCEJ;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C492B0", Offset = "0x2C484B0", VA = "0x182C492B0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C49290", Offset = "0x2C48490", VA = "0x182C49290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public CJLJGAHNBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class PGDJIJBDEMM : DHDEFGPGMMG, FPHKGEBJIKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct FIKABHKEIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<LMIKKFINNNK> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<CCLINJKNNFF> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<LMIKKFINNNK> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public FIKABHKEIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, EHHPMHEMOMP previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__2(Entity entity, EHHPMHEMOMP previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct GEIKONMIAOC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct FJEJLPJLPDN
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct NLFGFMEEGII
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NLLHLGIICMK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> CFIMAMHLFJF;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x41C4830", Offset = "0x41C3A30", VA = "0x1841C4830")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x41C4890", Offset = "0x41C3A90", VA = "0x1841C4890")]
			public NLFGFMEEGII OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(NLFGFMEEGII);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<LMIKKFINNNK> JLABFFGDGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private FJEJLPJLPDN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FJEJLPJLPDN.NLFGFMEEGII* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x41C5270", Offset = "0x41C4470", VA = "0x1841C5270")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData BEKIFNKENPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x119AF90", Offset = "0x119A190", VA = "0x18119AF90", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x41C5380", Offset = "0x41C4580", VA = "0x1841C5380", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x41C5420", Offset = "0x41C4620", VA = "0x1841C5420")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref FJEJLPJLPDN.NLFGFMEEGII DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x41C52F0", Offset = "0x41C44F0", VA = "0x1841C52F0")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OLKNEPJBOPO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct HIJJMCCODAN
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct HCEAGEONGPP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NLLHLGIICMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP>.Runtime GIPHOKHPOII;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CFIMAMHLFJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP> BPCCBBKNFBI;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x41C6490", Offset = "0x41C5690", VA = "0x1841C6490")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x41C6510", Offset = "0x41C5710", VA = "0x1841C6510")]
			public HCEAGEONGPP OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HCEAGEONGPP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<CCLINJKNNFF> FHNJMFEHEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private HIJJMCCODAN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HIJJMCCODAN.HCEAGEONGPP* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x41CAE40", Offset = "0x41CA040", VA = "0x1841CAE40")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData BEKIFNKENPL, EHHPMHEMOMP JHBHPHLKKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x41CB0F0", Offset = "0x41CA2F0", VA = "0x1841CB0F0", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x41CAF40", Offset = "0x41CA140", VA = "0x1841CAF40", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x41CB010", Offset = "0x41CA210", VA = "0x1841CB010")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref HIJJMCCODAN.HCEAGEONGPP DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x41CAF00", Offset = "0x41CA100", VA = "0x1841CAF00")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GBDDELFOGEI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct COCPPGEJEDN
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct HOFLNMCKPDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP>.Runtime GIPHOKHPOII;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP> BPCCBBKNFBI;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x41C29C0", Offset = "0x41C1BC0", VA = "0x1841C29C0")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x41C2A20", Offset = "0x41C1C20", VA = "0x1841C2A20")]
			public HOFLNMCKPDH OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HOFLNMCKPDH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<LMIKKFINNNK> PKOGBONKPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private COCPPGEJEDN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe COCPPGEJEDN.HOFLNMCKPDH* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x41C4F90", Offset = "0x41C4190", VA = "0x1841C4F90")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, EHHPMHEMOMP JHBHPHLKKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x41C51F0", Offset = "0x41C43F0", VA = "0x1841C51F0", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x41C50A0", Offset = "0x41C42A0", VA = "0x1841C50A0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x41C5140", Offset = "0x41C4340", VA = "0x1841C5140")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref COCPPGEJEDN.HOFLNMCKPDH DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x41C5010", Offset = "0x41C4210", VA = "0x1841C5010")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private BCCHDFPAANJ JBMKIDLKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery GKGLNBLOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery EGFLMCMGEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery AKDOBKCPDCG;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A82D40", Offset = "0x2A81F40", VA = "0x182A82D40", Slot = "14")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A832B0", Offset = "0x2A824B0", VA = "0x182A832B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public PGDJIJBDEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A83250", Offset = "0x2A82450", VA = "0x182A83250", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A82AE0", Offset = "0x2A81CE0", VA = "0x182A82AE0")]
	public static EntityQuery BCEAJCOGFBB(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A82E20", Offset = "0x2A82020", VA = "0x182A82E20")]
	public static EntityQuery LKNCGAEOIKA(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A83050", Offset = "0x2A82250", VA = "0x182A83050")]
	public static EntityQuery NDJMCOPHEBI(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	public class InitializeRigidbodyExHierarchy : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private FAJMNCCNMML FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x31AF0D0", Offset = "0x31AE2D0", VA = "0x1831AF0D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x31AF350", Offset = "0x31AE550", VA = "0x1831AF350", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x31AF160", Offset = "0x31AE360", VA = "0x1831AF160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class EEJDKDKCCAP : ParentSystemBase<ParentData, EHHPMHEMOMP, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A270", Offset = "0x2C59470", VA = "0x182C5A270", Slot = "14")]
	protected override EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x7726B0", Offset = "0x7718B0", VA = "0x1807726B0", Slot = "15")]
	protected override EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A230", Offset = "0x2C59430", VA = "0x182C5A230", Slot = "16")]
	protected override EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A2F0", Offset = "0x2C594F0", VA = "0x182C5A2F0", Slot = "17")]
	protected override EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A330", Offset = "0x2C59530", VA = "0x182C5A330")]
	public EEJDKDKCCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A2B0", Offset = "0x2C594B0", VA = "0x182C5A2B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : DHDEFGPGMMG where ParentData : struct, IComponentData, LCIGIOAHNLO where PreviousParentData : struct, IComponentData, LCIGIOAHNLO where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LCIGIOAHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct OKBDHCPGNPG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter HPONPDGOAKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter NPHFPEKAJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> PEGGFDAEEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> JKNKKPGGKLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType OKAKOJILFPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint LBAGCJGFKCK;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x264CDB0", Offset = "0x264BFB0", VA = "0x18264CDB0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct DPGJEDAPKIL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> LPDDAAHBDPL;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x37730A0", Offset = "0x37722A0", VA = "0x1837730A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct FNAFDEDDPDC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> HPONPDGOAKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> NPHFPEKAJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3041360", Offset = "0x3040560", VA = "0x183041360")]
			private int CDMJPGCEDAA(DynamicBuffer<ChildrenData> PLBLCMNMLJO, Entity OAOGLFGGBPI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3041840", Offset = "0x3040A40", VA = "0x183041840")]
			private void HBIJPAEEOLD(Entity GPFONCECPBK, DynamicBuffer<ChildrenData> PLBLCMNMLJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3041B00", Offset = "0x3040D00", VA = "0x183041B00")]
			private void NJDKKMLGNOD(Entity GPFONCECPBK, DynamicBuffer<ChildrenData> PLBLCMNMLJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x30416E0", Offset = "0x30408E0", VA = "0x1830416E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct KDNBDHLPMCN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> LGAHGBFJDHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> LILCAAEDFCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x23436E0", Offset = "0x23428E0", VA = "0x1823436E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery AAEAOHNNBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery IGADABAPLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery LDIGFMNCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery ODIJLFGCKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker IJKGIDENJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker ACNFOMALPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker NFKGHHAHPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker GIHIJLFOCMF;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x28D0FF0", Offset = "0x28D01F0", VA = "0x1828D0FF0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x28CFA60", Offset = "0x28CEC60", VA = "0x1828CFA60")]
		private int CDMJPGCEDAA(DynamicBuffer<ChildrenData> PLBLCMNMLJO, Entity OAOGLFGGBPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x28D0160", Offset = "0x28CF360", VA = "0x1828D0160")]
		private void EOCGMKNONGG(Entity AOAMDLBGHMH, Entity MOGIDIJEPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x7726B0", Offset = "0x7718B0", VA = "0x1807726B0", Slot = "14")]
		protected virtual EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x7726B0", Offset = "0x7718B0", VA = "0x1807726B0", Slot = "15")]
		protected virtual EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x7726B0", Offset = "0x7718B0", VA = "0x1807726B0", Slot = "16")]
		protected virtual EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x28D09E0", Offset = "0x28CFBE0", VA = "0x1828D09E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x28CFFC0", Offset = "0x28CF1C0", VA = "0x1828CFFC0")]
		private void EAPIKGLACDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x28CFC40", Offset = "0x28CEE40", VA = "0x1828CFC40")]
		private void CNMMMIHCFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x28CF000", Offset = "0x28CE200", VA = "0x1828CF000")]
		private JobHandle BGKKHGBPFFG(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x28D0700", Offset = "0x28CF900", VA = "0x1828D0700")]
		private void KAJNIGAMCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x28D0F20", Offset = "0x28D0120", VA = "0x1828D0F20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x26843A0", Offset = "0x26835A0", VA = "0x1826843A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public abstract class PCIKMMGBFEM : DHDEFGPGMMG, FPHKGEBJIKC
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct LMDMLIAMAPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> OAJOEDDBLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> FJHNANDIFHE;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x41C9A70", Offset = "0x41C8C70", VA = "0x1841C9A70")]
		public LMDMLIAMAPJ(NativeList<Entity> OAJOEDDBLOD, NativeList<Entity> FJHNANDIFHE, JobHandle GNEAPAJLKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x41C99F0", Offset = "0x41C8BF0", VA = "0x1841C99F0")]
		public JobHandle PBKOIJEMIDF(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x41C9960", Offset = "0x41C8B60", VA = "0x1841C9960", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct JMHLIJLIMFD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum OHGCIBGJCEP
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
		public NativeList<Entity> NDDGKAJIPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> OGBKKKBDHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> DHKFLGCKLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> CMBIJAGAABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity NFIKKPBHMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity OANNLJALGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> LMKFMOLPBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int OFNNGJDBJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int PCHMLGCKCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private OHGCIBGJCEP MDBJGCBLKKA;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x41C87F0", Offset = "0x41C79F0", VA = "0x1841C87F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x41C8600", Offset = "0x41C7800", VA = "0x1841C8600")]
		private void BJCGBAHDMJE(Entity OAOGLFGGBPI, bool NJCBPCFIKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x41C8C60", Offset = "0x41C7E60", VA = "0x1841C8C60")]
		private void MIMDKKLLJKN(Entity OAOGLFGGBPI, bool NJCBPCFIKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x41C8980", Offset = "0x41C7B80", VA = "0x1841C8980")]
		public LMDMLIAMAPJ GLPJPIHHPHD(NativeArray<Entity> JGJKBMBOGAH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x41C8770", Offset = "0x41C7970", VA = "0x1841C8770")]
		public LMDMLIAMAPJ EPMIHLCLCDD(NativeArray<Entity> JGJKBMBOGAH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x41C8690", Offset = "0x41C7890", VA = "0x1841C8690")]
		public LMDMLIAMAPJ CCHHAEFJINE(NativeList<LMIKKFINNNK> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x41C8E50", Offset = "0x41C8050", VA = "0x1841C8E50")]
		public LMDMLIAMAPJ NAPDDDHFLGP(NativeList<LMIKKFINNNK> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x41C8D70", Offset = "0x41C7F70", VA = "0x1841C8D70")]
		public LMDMLIAMAPJ NANEMKECHIP(NativeList<CCLINJKNNFF> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x4DCD030", Offset = "0x4DCC230", VA = "0x184DCD030")]
		private LMDMLIAMAPJ KJBFOFDKFOF<T>(NativeList<T> NHOGENNANEB, int PBIPNMLPAMF, int BEJPMFNJOJD, OHGCIBGJCEP PDGDINPCGGH, JobHandle MEDEIGIKJJO) where T : struct
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x41C8A00", Offset = "0x41C7C00", VA = "0x1841C8A00")]
		private LMDMLIAMAPJ KJBFOFDKFOF(NativeArray<Entity> GNGEEFEGDCP, int PBIPNMLPAMF, int BEJPMFNJOJD, OHGCIBGJCEP PDGDINPCGGH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery JNNCLMGAKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery BLGFBAFBMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private BCCHDFPAANJ PIEJKHPDGJK;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType MHOCPBNFJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType DFAGGHLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType IOBOLGCGMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2A82620", Offset = "0x2A81820", VA = "0x182A82620")]
	protected PCIKMMGBFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2A81150", Offset = "0x2A80350", VA = "0x182A81150", Slot = "14")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2A814E0", Offset = "0x2A806E0", VA = "0x182A814E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2A81710", Offset = "0x2A80910", VA = "0x182A81710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A80", Offset = "0x7F0C80", VA = "0x1807F1A80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2A81480", Offset = "0x2A80680", VA = "0x182A81480")]
	private void MFNEIFCODOD(NativeArray<Entity> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2A82580", Offset = "0x2A81780", VA = "0x182A82580")]
	private void PIPNGOBOKDF(NativeArray<Entity> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2A80FA0", Offset = "0x2A801A0", VA = "0x182A80FA0")]
	private void HNEHALMHICO(LMDMLIAMAPJ CLJKPGCKBPN, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2A80E90", Offset = "0x2A80090", VA = "0x182A80E90")]
	private void HNEHALMHICO(NativeListAsync<Entity> KPCAHJCNBDC, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2A81230", Offset = "0x2A80430", VA = "0x182A81230")]
	private void MBEJGFOGIPH(LMDMLIAMAPJ CLJKPGCKBPN, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2A81370", Offset = "0x2A80570", VA = "0x182A81370")]
	private void MBEJGFOGIPH(NativeListAsync<Entity> KPCAHJCNBDC, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2A810E0", Offset = "0x2A802E0", VA = "0x182A810E0")]
	private bool INEAKPJMHNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class JNEFMKCCKHE : DHDEFGPGMMG, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct PBFOCALMOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public JNEFMKCCKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public PBFOCALMOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PJDEIBBFNEK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct JGPOOCIDLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct GGOOLDIBPBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime CHMHDPOCLGM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FOKALLBHGDF;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x41C78B0", Offset = "0x41C6AB0", VA = "0x1841C78B0")]
			public void BHIDKDBKBAC(JNEFMKCCKHE MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x41C78C0", Offset = "0x41C6AC0", VA = "0x1841C78C0")]
			public GGOOLDIBPBI OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(GGOOLDIBPBI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JNEFMKCCKHE BFAPLOAAIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer MCOIHMEDDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private JGPOOCIDLHM LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JGPOOCIDLHM.GGOOLDIBPBI* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x41CB580", Offset = "0x41CA780", VA = "0x1841CB580")]
		internal void AOFNEGGIPNF(Entity LBPJAILMLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x41C46B0", Offset = "0x41C38B0", VA = "0x1841C46B0", Slot = "5")]
		public void ReadFromDisplayClass(ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x41C46E0", Offset = "0x41C38E0", VA = "0x1841C46E0", Slot = "6")]
		public void WriteToDisplayClass(ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x41CB6D0", Offset = "0x41CA8D0", VA = "0x1841CB6D0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x41CB720", Offset = "0x41CA920", VA = "0x1841CB720")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref JGPOOCIDLHM.GGOOLDIBPBI DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x41CB690", Offset = "0x41CA890", VA = "0x1841CB690")]
		public void BHIDKDBKBAC(JNEFMKCCKHE MFPLGOJOEDD, ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x41CB510", Offset = "0x41CA710", VA = "0x1841CB510")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private GKLOHLMMION OKOMBANGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery DEABFFPIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker NFDECGAIHKN;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x31B1220", Offset = "0x31B0420", VA = "0x1831B1220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x31B13D0", Offset = "0x31B05D0", VA = "0x1831B13D0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x31B1280", Offset = "0x31B0480", VA = "0x1831B1280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public JNEFMKCCKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x31B1140", Offset = "0x31B0340", VA = "0x1831B1140", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x31B0F70", Offset = "0x31B0170", VA = "0x1831B0F70")]
	public static EntityQuery AEPGBDCFMBL(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[LOFBNDLMONN]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class KHJKLIHDMCF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService KPLEIKICILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x31B4010", Offset = "0x31B3210", VA = "0x1831B4010", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x31B3C20", Offset = "0x31B2E20", VA = "0x1831B3C20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x31B3CC0", Offset = "0x31B2EC0", VA = "0x1831B3CC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public KHJKLIHDMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct PAEMMFFCJJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public LPABFJLFMIG KJNCDAGJAPF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7000", Offset = "0x6C6200", VA = "0x1806C7000")]
	public static PAEMMFFCJJL LOJIFGBJNLM(in LPABFJLFMIG JJNBMHNJAOL)
	{
		return default(PAEMMFFCJJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7000", Offset = "0x6C6200", VA = "0x1806C7000")]
	public static LPABFJLFMIG LOJIFGBJNLM(in PAEMMFFCJJL DFPHPOJNCKP)
	{
		return default(LPABFJLFMIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class GKLOHLMMION : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x31A6500", Offset = "0x31A5700", VA = "0x1831A6500", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	public GKLOHLMMION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class KFDCJLIMNBH : DHDEFGPGMMG, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct EDELEMGAECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public KFDCJLIMNBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public EDELEMGAECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__0(Entity e, PAEMMFFCJJL ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FCFFCBACPKF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct BJOIHJGIEKI
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct HFHLJCMGPLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime CHMHDPOCLGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<PAEMMFFCJJL>.Runtime BNDAAFBCMEN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FOKALLBHGDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PAEMMFFCJJL> HOAPAACGMHI;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x41C1DA0", Offset = "0x41C0FA0", VA = "0x1841C1DA0")]
			public void BHIDKDBKBAC(KFDCJLIMNBH MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x41C1E00", Offset = "0x41C1000", VA = "0x1841C1E00")]
			public HFHLJCMGPLF OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HFHLJCMGPLF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public KFDCJLIMNBH BFAPLOAAIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer MCOIHMEDDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private BJOIHJGIEKI LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BJOIHJGIEKI.HFHLJCMGPLF* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x41C43D0", Offset = "0x41C35D0", VA = "0x1841C43D0")]
		internal void AOFNEGGIPNF(Entity LBPJAILMLKD, PAEMMFFCJJL IFJLGNNKAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x41C46B0", Offset = "0x41C38B0", VA = "0x1841C46B0", Slot = "5")]
		public void ReadFromDisplayClass(ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x41C46E0", Offset = "0x41C38E0", VA = "0x1841C46E0", Slot = "6")]
		public void WriteToDisplayClass(ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x41C4560", Offset = "0x41C3760", VA = "0x1841C4560", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x41C4600", Offset = "0x41C3800", VA = "0x1841C4600")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref BJOIHJGIEKI.HFHLJCMGPLF DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x41C44D0", Offset = "0x41C36D0", VA = "0x1841C44D0")]
		public void BHIDKDBKBAC(KFDCJLIMNBH MFPLGOJOEDD, ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x41C4360", Offset = "0x41C3560", VA = "0x1841C4360")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private GKLOHLMMION OKOMBANGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery ONIJHELACPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker KIAOIFCFILF;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x31B3870", Offset = "0x31B2A70", VA = "0x1831B3870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x31B3A30", Offset = "0x31B2C30", VA = "0x1831B3A30", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x31B38D0", Offset = "0x31B2AD0", VA = "0x1831B38D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public KFDCJLIMNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x31B3790", Offset = "0x31B2990", VA = "0x1831B3790", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x31B35C0", Offset = "0x31B27C0", VA = "0x1831B35C0")]
	public static EntityQuery IHDNEPHLCCO(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct JIFMPAJIHCF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public HNJLOOJCIKA ELCDAMLJAMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, CHLMDABNGKB> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x41C7950", Offset = "0x41C6B50", VA = "0x1841C7950")]
			public JIFMPAJIHCF(int DOMGBHGFPFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x41C78D0", Offset = "0x41C6AD0", VA = "0x1841C78D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct LNOPILAFFLF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> NCEGELMEING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> OGHJHMOKOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x41C9B60", Offset = "0x41C8D60", VA = "0x1841C9B60", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct FNCJENOONDD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> NCEGELMEING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x41C4BB0", Offset = "0x41C3DB0", VA = "0x1841C4BB0", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private DPHIHEMGLPB JIHJABJGCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery AFCFJFEACJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery OFCNMPFNJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery GCDMOGEEFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery LKLHAJFAJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery CNLCPPDKCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle DJMCAHPHCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private JIFMPAJIHCF FJFMCFPKAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private JIFMPAJIHCF IIMLLFHHDGG;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2A868E0", Offset = "0x2A85AE0", VA = "0x182A868E0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2A85E80", Offset = "0x2A85080", VA = "0x182A85E80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2A853E0", Offset = "0x2A845E0", VA = "0x182A853E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2A86140", Offset = "0x2A85340", VA = "0x182A86140", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2A85420", Offset = "0x2A84620", VA = "0x182A85420")]
		private void DBHLILFIPBM(EntityQuery JLMGAJOHFKO, out (NativeArrayAsync<PAEMMFFCJJL> handles, NativeArrayAsync<PBPGODBNIIF> bounds) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2A85C20", Offset = "0x2A84E20", VA = "0x182A85C20")]
		private void IPONHGIBEFF((NativeArrayAsync<PAEMMFFCJJL> handles, NativeArrayAsync<PBPGODBNIIF> bounds) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2A853E0", Offset = "0x2A845E0", VA = "0x182A853E0")]
		private void AJKPOPHOPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2A859B0", Offset = "0x2A84BB0", VA = "0x182A859B0")]
		private void HIHKAHJLEJO(EntityQuery JLMGAJOHFKO, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<PAEMMFFCJJL> handles) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2A856C0", Offset = "0x2A848C0", VA = "0x182A856C0")]
		private void EPHHMEDKMDP((NativeArrayAsync<Entity> entities, NativeArrayAsync<PAEMMFFCJJL> handles) ONIBEFDCPGD, JIFMPAJIHCF HNCPDLIBBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2A85560", Offset = "0x2A84760", VA = "0x182A85560")]
		private JobHandle DPBGCNAPMBN(JIFMPAJIHCF HNCPDLIBBAB, ComponentDataFromEntity<WorldPoseData> NCEGELMEING, ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH, ComponentDataFromEntity<WorldDeformableScaleData> OGHJHMOKOIM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2A85AF0", Offset = "0x2A84CF0", VA = "0x182A85AF0")]
		private JobHandle IANPGMDPOOH(JIFMPAJIHCF HNCPDLIBBAB, ComponentDataFromEntity<WorldPoseData> NCEGELMEING, ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct OHBHHABGBMM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class SplineLocalBoundsSystem : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct EBKPOLNMPEN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> HDKAJPECANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> CGFNFEOHGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<PBPGODBNIIF> OAEKMIFBBHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, CHLMDABNGKB>.ParallelWriter DNHNPHJILIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CDNKHMIIJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter GLOHIMFBLCL;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x41C36F0", Offset = "0x41C28F0", VA = "0x1841C36F0", Slot = "4")]
			public void Execute(int BELCAJFDAHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct PKHPJBKDHKD : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> PMPIJFBGLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> NGOPFBDABOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> JFIKMEPDDKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<PBPGODBNIIF> EIENBKLGCOC;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x41CB790", Offset = "0x41CA990", VA = "0x1841CB790", Slot = "4")]
			public void Execute(int BELCAJFDAHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery ICBOJPIMFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery EKKOJMBJHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery IGDINACNKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery IAEGLEMMFOM;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2CC12D0", Offset = "0x2CC04D0", VA = "0x182CC12D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2CC14E0", Offset = "0x2CC06E0", VA = "0x182CC14E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2CC1010", Offset = "0x2CC0210", VA = "0x182CC1010")]
		private JobHandle NKIHHBLDNCB(NativeArrayAsync<Entity> PFCDNINKMFA, int ONCBCCLEFOH, JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2CC10F0", Offset = "0x2CC02F0", VA = "0x182CC10F0")]
		private JobHandle NKIHHBLDNCB(NativeArray<Entity> EDGCKJPPCNA, int ONCBCCLEFOH, [Optional] JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2CC04F0", Offset = "0x2CBF6F0", VA = "0x182CC04F0")]
		private NativeArrayAsync<Entity> ACOCCFAIDOG(EntityQuery JLMGAJOHFKO)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0570", Offset = "0x2CBF770", VA = "0x182CC0570")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) ADKJOFKDKLM(NativeArrayAsync<Entity> IAMGJMABCOF)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0E20", Offset = "0x2CC0020", VA = "0x182CC0E20")]
		private void LADPEELPKPO(out NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0F80", Offset = "0x2CC0180", VA = "0x182CC0F80")]
		private void NJLJGLMANAD(NativeList<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0EB0", Offset = "0x2CC00B0", VA = "0x182CC0EB0")]
		private void NJLJGLMANAD(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0CF0", Offset = "0x2CBFEF0", VA = "0x182CC0CF0")]
		private void EHJMPFLMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void MKFBMLAPBOO(int MMEGPPKAEIB, int AFIENCCHJBK, int GLEGLJOKLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2CC09C0", Offset = "0x2CBFBC0", VA = "0x182CC09C0")]
		private static PBPGODBNIIF DIOGHNDFPPP(NativeArray<Entity> FHOKLGFMOHD, ComponentDataFromEntity<SplinePointPositionData> JFIKMEPDDKC, ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK)
		{
			return default(PBPGODBNIIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct MDFGPEKPEHE : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	public class DestroyLocalObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery HABFILNCFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery PFJAPHDBGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C594A0", Offset = "0x2C586A0", VA = "0x182C594A0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C59070", Offset = "0x2C58270", VA = "0x182C59070")]
		public bool EGAEJNEMACJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C59350", Offset = "0x2C58550", VA = "0x182C59350", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C59120", Offset = "0x2C58320", VA = "0x182C59120", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C59480", Offset = "0x2C58680", VA = "0x182C59480", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D45520", Offset = "0x1D44720", VA = "0x181D45520", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C59120", Offset = "0x2C58320", VA = "0x182C59120")]
		private void JENDOENGMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C59160", Offset = "0x2C58360", VA = "0x182C59160")]
		private void JLGHFMGGIMA(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C59210", Offset = "0x2C58410", VA = "0x182C59210")]
		private void NPEIFHCLGLP(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C59630", Offset = "0x2C58830", VA = "0x182C59630")]
		private void PPCDKKLHCJP(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C59510", Offset = "0x2C58710", VA = "0x182C59510")]
		private void PGHIAFKMBHG(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static ENELKKCPMCO[] CEKIKBHMIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private BKOAPAPEJAI GNBJBEPJLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private KHFJEIHOPJL EOPODOHPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x31A0F90", Offset = "0x31A0190", VA = "0x1831A0F90", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x31A0ED0", Offset = "0x31A00D0", VA = "0x1831A0ED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x31A0940", Offset = "0x319FB40", VA = "0x1831A0940")]
		private void ACFNKIFGPJN(ENELKKCPMCO KGOFCGFBHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private void CEPHILAPHPH(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA, GKFDLLIKKMD IPFKDLFGNOG, GBDBBLLJIJK LLNCPHJHCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[MBALNPKLAGP(FOFKCKDBIPD.Callbacks)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public sealed class PropertyEventCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService OBOKKBNADPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase KGOFCGFBHNK;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BF70", Offset = "0x2A8B170", VA = "0x182A8BF70", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BE70", Offset = "0x2A8B070", VA = "0x182A8BE70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	internal class TransmitNetworkDataSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private IPBKNNKPCHC CGLLMAJNLJD;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8930", Offset = "0x2CC7B30", VA = "0x182CC8930", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CC88E0", Offset = "0x2CC7AE0", VA = "0x182CC88E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[LOFBNDLMONN]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class CalculateCullingBandChanges : DHDEFGPGMMG, LFPMKPLIAAM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct AEHGEJHBPLO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType ABFNOJJIFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> MFKFFPDJGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<MMJDEMOFKKF>.ParallelWriter IBIFFOPBKKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<GEOLEJFMBML> LJPOLDBBADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 MOOHJICILGA;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 OAOFBIAANMO;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 JOOHFHJIEBL;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 LNHJJAJKCHH;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2CB33A0", Offset = "0x2CB25A0", VA = "0x182CB33A0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int GHJKICBPJKL = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double OBCODDGIGAD = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery EIPKPAJBHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery MCBJIKLJLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double KFINHOHHMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService MCODOOGFPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService JOGKAGECKFN;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C499E0", Offset = "0x2C48BE0", VA = "0x182C499E0", Slot = "14")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A0A0", Offset = "0x2C492A0", VA = "0x182C4A0A0", Slot = "15")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C49D30", Offset = "0x2C48F30", VA = "0x182C49D30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C49E80", Offset = "0x2C49080", VA = "0x182C49E80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C49970", Offset = "0x2C48B70", VA = "0x182C49970")]
		private bool GPPBBLMCCPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C499F0", Offset = "0x2C48BF0", VA = "0x182C499F0")]
		private void OAGCDDBNBDB(EntityQuery JLMGAJOHFKO, float3 OPLAFBPCIEH, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct MMJDEMOFKKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public LJKHPCCHKIO IAMOONJKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public LJKHPCCHKIO AFLEFPKENKF;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class ProcessCullingBandChangeCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService MCODOOGFPIB;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D40", Offset = "0x2A87F40", VA = "0x182A88D40", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D20", Offset = "0x2A87F20", VA = "0x182A88D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class UpdateInertialProperties : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery HIJDJAJMKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private NNABLGDOJFG EKFCAEOLCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF780", Offset = "0x2CCE980", VA = "0x182CCF780", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF450", Offset = "0x2CCE650", VA = "0x182CCF450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF4E0", Offset = "0x2CCE6E0", VA = "0x182CCF4E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GHBMLKHDBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PIOIOICCPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OKCAEOJCPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService KDCKCPKFAAP;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x31A0790", Offset = "0x319F990", VA = "0x1831A0790", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x31A00C0", Offset = "0x319F2C0", VA = "0x1831A00C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x319F550", Offset = "0x319E750", VA = "0x18319F550")]
		private void FNBLDDLEBKA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NHOGENNANEB, EntityQueryDesc DEBKCIPIIEB, bool IHFIBCKLILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x319F410", Offset = "0x319E610", VA = "0x18319F410")]
		private void FNBLDDLEBKA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NHOGENNANEB, EntityQueryDesc DEBKCIPIIEB, bool IHFIBCKLILB, bool BNEEGIEDHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x31A0320", Offset = "0x319F520", VA = "0x1831A0320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x319F880", Offset = "0x319EA80", VA = "0x18319F880")]
		private void HFOIEEGNPME(EntityQuery JLMGAJOHFKO, bool DNPGIIMBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x319FB00", Offset = "0x319ED00", VA = "0x18319FB00")]
		private void JMKJECHDJHF(EntityQuery JLMGAJOHFKO, bool PMCOBFBKIAH, bool DNPGIIMBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x319F660", Offset = "0x319E860", VA = "0x18319F660")]
		private void HBBKCPMFFHA(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x319FF10", Offset = "0x319F110", VA = "0x18319FF10")]
		private void NOOBELOGIPP(NativeList<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x319F2F0", Offset = "0x319E4F0", VA = "0x18319F2F0")]
		private void DBHADAGANBB(NativeArray<Entity> GNGEEFEGDCP, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x319FD10", Offset = "0x319EF10", VA = "0x18319FD10")]
		private NativeList<Entity> JPKGKIIGCAF(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x31A07E0", Offset = "0x319F9E0", VA = "0x1831A07E0")]
		private NativeList<Entity> PELLKDJOKFH(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x31A0080", Offset = "0x319F280", VA = "0x1831A0080")]
		private NativeList<Entity> OMMNPBDOJOF(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x31A05F0", Offset = "0x319F7F0", VA = "0x1831A05F0")]
		private NativeList<Entity> PBBIHOLEJKE(NativeArray<Entity> GNGEEFEGDCP, bool LKEOIFNOBLC)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x319FA70", Offset = "0x319EC70", VA = "0x18319FA70")]
		private PLJOAMLOBDL HHGFAEDKPBK(NativeArray<Entity> GNGEEFEGDCP)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(PLJOAMLOBDL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x31A0870", Offset = "0x319FA70", VA = "0x1831A0870")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService KDCKCPKFAAP;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A88DB0", Offset = "0x2A87FB0", VA = "0x182A88DB0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D90", Offset = "0x2A87F90", VA = "0x182A88D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : ILHKCJPPBMP
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery OJDFIJPKHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery IPGJLCNKJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery GOEAJLPENDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery KGDACKLNBEG;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C58CE0", Offset = "0x2C57EE0", VA = "0x182C58CE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C58EA0", Offset = "0x2C580A0", VA = "0x182C58EA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C58860", Offset = "0x2C57A60", VA = "0x182C58860")]
		private void CPIHMAOLCBE(EntityQuery JLMGAJOHFKO, bool FLGDGHMLIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C58AA0", Offset = "0x2C57CA0", VA = "0x182C58AA0")]
		private void LCHEFAHOMGN(EntityQuery JLMGAJOHFKO, bool FLGDGHMLIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class AssignPlayerIdsSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery GBIKPKILAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery PCDEOKFCOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService KJGMKGKKNGC;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C434C0", Offset = "0x2C426C0", VA = "0x182C434C0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C43390", Offset = "0x2C42590", VA = "0x182C43390", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C434A0", Offset = "0x2C426A0", VA = "0x182C434A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C42BA0", Offset = "0x2C41DA0", VA = "0x182C42BA0")]
		private void GKLJBFJEJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C430E0", Offset = "0x2C422E0", VA = "0x182C430E0")]
		private void NNHFNBNBBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C42DC0", Offset = "0x2C41FC0", VA = "0x182C42DC0")]
		private void NDGIHFJHLPD(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C43250", Offset = "0x2C42450", VA = "0x182C43250")]
		private void NNIONKONFJA(NativeArray<Entity> GNGEEFEGDCP, int JKINPFDPJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C42CB0", Offset = "0x2C41EB0", VA = "0x182C42CB0")]
		private void MLEANBHJBCE(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C42B40", Offset = "0x2C41D40", VA = "0x182C42B40")]
		private void FJLLFANBLFP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void MBPIBAFELKF(int PMIGFHIBOOC, Transform LJLOGOIJMEM, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class FDIALEEDHJL
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x31A37B0", Offset = "0x31A29B0", VA = "0x1831A37B0")]
	public static bool DHOGAMHCJNH(this SystemBase DCOPHBBEGEL, out Entity OAOGLFGGBPI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery HAGJFHJGKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private CGLADJHJCEM JPIIPGKJJOO;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BC10", Offset = "0x2C4AE10", VA = "0x182C4BC10", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BAE0", Offset = "0x2C4ACE0", VA = "0x182C4BAE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BBA0", Offset = "0x2C4ADA0", VA = "0x182C4BBA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<OJAPCNHANOE>, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string ECLGCHIFILN = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private DEMDCLJBMBJ MCLILDBFPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery OIOOCCDEAFB;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity KACOPDDEDFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2A6F9F0", Offset = "0x2A6EBF0", VA = "0x182A6F9F0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2A6F560", Offset = "0x2A6E760", VA = "0x182A6F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity NLMPEJILEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2A6F5C0", Offset = "0x2A6E7C0", VA = "0x182A6F5C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public NFJEDPPAJMK KFAFBGNOICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FAD0", Offset = "0x2A6ECD0", VA = "0x182A6FAD0")]
			get
			{
				return default(NFJEDPPAJMK);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FD50", Offset = "0x2A6EF50", VA = "0x182A6FD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public NFJEDPPAJMK CKAEEGNCAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FB60", Offset = "0x2A6ED60", VA = "0x182A6FB60")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FC30", Offset = "0x2A6EE30", VA = "0x182A6FC30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FDC0", Offset = "0x2A6EFC0", VA = "0x182A6FDC0", Slot = "15")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FCD0", Offset = "0x2A6EED0", VA = "0x182A6FCD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FE30", Offset = "0x2A6F030", VA = "0x182A6FE30", Slot = "14")]
		protected override void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F910", Offset = "0x2A6EB10", VA = "0x182A6F910")]
		private void FFNGBDGCJAH(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F620", Offset = "0x2A6E820", VA = "0x182A6F620")]
		private void DIEHJBIMEIL(Entity OAOGLFGGBPI, Entity NPHFOCPHDMJ, Entity DGNNOBANMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x30710F0", Offset = "0x30702F0", VA = "0x1830710F0")]
		private bool GIGJNHOBOLH<T>(out T JFBPNBNBHOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x3071030", Offset = "0x3070230", VA = "0x183071030")]
		private void BFDDADMOHJF<T>(T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FA50", Offset = "0x2A6EC50", VA = "0x182A6FA50")]
		public bool HOMAPCMFJKC(NFJEDPPAJMK DCPANEJBMLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F8E0", Offset = "0x2A6EAE0", VA = "0x182A6F8E0")]
		private static bool EJAPHKJIGEF(NFJEDPPAJMK HJNHKENHAKD, NFJEDPPAJMK PNOEOKEDDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FFD0", Offset = "0x2A6F1D0", VA = "0x182A6FFD0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FBF0", Offset = "0x2A6EDF0", VA = "0x182A6FBF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2C545C0", Offset = "0x2C537C0", VA = "0x182C545C0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2C540D0", Offset = "0x2C532D0", VA = "0x182C540D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2C54170", Offset = "0x2C53370", VA = "0x182C54170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2C53E70", Offset = "0x2C53070", VA = "0x182C53E70")]
		private NativeArray<Entity> JFPEDLFHGAP(int OCCKKIPCFBH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2C53FC0", Offset = "0x2C531C0", VA = "0x182C53FC0")]
		private void JJOGPHJGJEL(NativeArray<Entity> KLOACGKPFHH, NativeArray<Entity> NHCNGFJEBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class HideRemotePivotsNotInScope : DHDEFGPGMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery CKNPMJDDFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery CHIEBAOILAL;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x31A9830", Offset = "0x31A8A30", VA = "0x1831A9830", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x31A9920", Offset = "0x31A8B20", VA = "0x1831A9920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class PDAEDGFJOLO
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string PFBPLPFFABG = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x29B3F30", Offset = "0x29B3130", VA = "0x1829B3F30")]
	public static NativeArray<T> KJBFOFDKFOF<T>(NativeArray<Entity> GNGEEFEGDCP, EntityManager KNABDDPENKI) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2A82790", Offset = "0x2A81990", VA = "0x182A82790")]
	public static void CGLPGEGJOJC(EntityQuery JLMGAJOHFKO, EntityManager KNABDDPENKI, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2A82660", Offset = "0x2A81860", VA = "0x182A82660")]
	public static void BFGHFGNFFIL(NativeArray<Entity> KLOACGKPFHH, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2A828D0", Offset = "0x2A81AD0", VA = "0x182A828D0")]
	public static void EGDHMAACHAB(NativeArray<Entity> KLOACGKPFHH, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF370", Offset = "0x2CCE570", VA = "0x182CCF370", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF2C0", Offset = "0x2CCE4C0", VA = "0x182CCF2C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF360", Offset = "0x2CCE560", VA = "0x182CCF360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2CCDE80", Offset = "0x2CCD080", VA = "0x182CCDE80")]
		private void CBPGPKAPELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE8E0", Offset = "0x2CCDAE0", VA = "0x182CCE8E0")]
		private void LFEIGFLEHJN(NativeArray<Entity> KLOACGKPFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE9F0", Offset = "0x2CCDBF0", VA = "0x182CCE9F0")]
		private void MLNCDPENHNL(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE690", Offset = "0x2CCD890", VA = "0x182CCE690")]
		private void CEJMMJGFINE(NativeArray<Entity> NHCNGFJEBDM, NativeArray<RigidTransform> FLKBEPEJPKF, NativeArray<RigidTransform> HFEMGCMKDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD9F0", Offset = "0x2CCCBF0", VA = "0x182CCD9F0")]
		private void AFJIDIENBEA(NativeArray<RigidTransform> HFEMGCMKDMO, NativeArray<Entity> NHCNGFJEBDM, NativeList<Entity> ICNAFJODPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class PostGameplayOnScopeChange : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery HAGJFHJGKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery GOLLAJMOAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2A87550", Offset = "0x2A86750", VA = "0x182A87550", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2A87340", Offset = "0x2A86540", VA = "0x182A87340", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2A87490", Offset = "0x2A86690", VA = "0x182A87490", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2A872D0", Offset = "0x2A864D0", VA = "0x182A872D0")]
		private void NIFLGEJJAKF(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class PreventDisembodiedScopesSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery KNIJJFPELEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents NKDKBMKAAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private CGLADJHJCEM JPIIPGKJJOO;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2A88C40", Offset = "0x2A87E40", VA = "0x182A88C40", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2A88B90", Offset = "0x2A87D90", VA = "0x182A88B90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2A88C30", Offset = "0x2A87E30", VA = "0x182A88C30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2A88A00", Offset = "0x2A87C00", VA = "0x182A88A00")]
		private void OIGFEAAGNIA(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<FGFDDMCIDKL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9600", Offset = "0x2CB8800", VA = "0x182CB9600", Slot = "14")]
		protected override void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9750", Offset = "0x2CB8950", VA = "0x182CB9750")]
		[BurstCompile]
		private static void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> MIEJHEFMMGG, ComponentDataFromEntity<global::MMOLLCEJBDE> HPGHKCBEMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9820", Offset = "0x2CB8A20", VA = "0x182CB9820")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2CB95C0", Offset = "0x2CB87C0", VA = "0x182CB95C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : DHDEFGPGMMG where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery BJLBDFNCDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery GKGPLPKAGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery HGJGNOBDKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery JLHPGGIPDJH;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x2FD85F0", Offset = "0x2FD77F0", VA = "0x182FD85F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x2FD87F0", Offset = "0x2FD79F0", VA = "0x182FD87F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x2FD87C0", Offset = "0x2FD79C0", VA = "0x182FD87C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7FE0", Offset = "0x2FD71E0", VA = "0x182FD7FE0")]
		private void JMBDHOMBLPL(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x2FD6B20", Offset = "0x2FD5D20", VA = "0x182FD6B20")]
		private void HDJDIOMOILL(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7750", Offset = "0x2FD6950", VA = "0x182FD7750")]
		private void HKGFOMHIDJD(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8880", Offset = "0x2FD7A80", VA = "0x182FD8880")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x1D06A30", Offset = "0x1D05C30", VA = "0x181D06A30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class BAJLNEMLKBP : DHDEFGPGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> LHDIADGEJKI;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2C43580", Offset = "0x2C42780", VA = "0x182C43580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2C43780", Offset = "0x2C42980", VA = "0x182C43780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2C438D0", Offset = "0x2C42AD0", VA = "0x182C438D0")]
	public BAJLNEMLKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct HMDBPEFKDBJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int ICGLEEKOOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int DMLEMNEAJDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x31A8160", Offset = "0x31A7360", VA = "0x1831A8160")]
	public static Entity LOJIFGBJNLM(HMDBPEFKDBJ ONIBEFDCPGD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x31A8160", Offset = "0x31A7360", VA = "0x1831A8160")]
	public static HMDBPEFKDBJ LOJIFGBJNLM(Entity OAOGLFGGBPI)
	{
		return default(HMDBPEFKDBJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct EAKNHDJIPCK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct CFMAIOKLGLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType HBILNHOEIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> GGHFLGHFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> PLGKAEIBFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> GNGEEFEGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> HHLLOPMMJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> JHBHPHLKKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> BEKIFNKENPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int ENFCEHCBAIJ;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CELDDGFEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2C48400", Offset = "0x2C47600", VA = "0x182C48400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2C48820", Offset = "0x2C47A20", VA = "0x182C48820")]
	public CFMAIOKLGLK(ComponentType HBILNHOEIJP, NativeList<int> GGHFLGHFEMD, NativeList<int> PLGKAEIBFCM, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> HHLLOPMMJPK, NativeArray<byte> JHBHPHLKKNF, NativeArray<byte> BEKIFNKENPL, int KKDBIBDEEDA, int ENFCEHCBAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2C48560", Offset = "0x2C47760", VA = "0x182C48560")]
	private LONBCMOJAJF FKLHBEPEAMO(NativeArray<byte> PFCDNINKMFA, int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T FKLHBEPEAMO<T>(NativeArray<byte> PFCDNINKMFA, int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2C48780", Offset = "0x2C47980", VA = "0x182C48780")]
	public LONBCMOJAJF JEDLCILCODA(int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T JEDLCILCODA<T>(int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2C487D0", Offset = "0x2C479D0", VA = "0x182C487D0")]
	public LONBCMOJAJF OBPIOPFKNIK(int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T OBPIOPFKNIK<T>(int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2C48480", Offset = "0x2C47680", VA = "0x182C48480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct OMCDLMPOANH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<FBGJBPABGDC> ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType HBILNHOEIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int ENFCEHCBAIJ;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2A74AC0", Offset = "0x2A73CC0", VA = "0x182A74AC0")]
	public OMCDLMPOANH(ComponentType HBILNHOEIJP, int KKDBIBDEEDA, int ENFCEHCBAIJ, EntityQuery JLMGAJOHFKO, NativeArray<FBGJBPABGDC> ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2A74A70", Offset = "0x2A73C70", VA = "0x182A74A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct PBFFOMIANOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int BELCAJFDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int PGAMAINOGKP;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
	public PBFFOMIANOH(int BELCAJFDAHD, int PGAMAINOGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct FBGJBPABGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int ELOEOOGBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int PCAHMJECHKC;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
	public FBGJBPABGDC(int ELOEOOGBENM, int PCAHMJECHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct GBDBBLLJIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly NMLCFAIOCDK LIKFEBDBPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* JHBHPHLKKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* BEKIFNKENPL;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x31A5DD0", Offset = "0x31A4FD0", VA = "0x1831A5DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NMLCFAIOCDK FFBMMDAJDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20")]
		get
		{
			return default(NMLCFAIOCDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x31A5DE0", Offset = "0x31A4FE0", VA = "0x1831A5DE0")]
	public LONBCMOJAJF PDENJHMAPFE(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x31A5CE0", Offset = "0x31A4EE0", VA = "0x1831A5CE0")]
	public LONBCMOJAJF FKFCBPAOIJJ(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1BB0", Offset = "0x2EB0DB0", VA = "0x182EB1BB0")]
	public T PDENJHMAPFE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x2EB1B90", Offset = "0x2EB0D90", VA = "0x182EB1B90")]
	public T FKFCBPAOIJJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x31A5ED0", Offset = "0x31A50D0", VA = "0x1831A5ED0")]
	public unsafe GBDBBLLJIJK(NMLCFAIOCDK LIKFEBDBPON, int PCAHMJECHKC, byte* JHBHPHLKKNF, byte* BEKIFNKENPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class HHJNKOGKPDA : LINMPAMPHKC, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService FFFJHMGPLAD;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x31A7B40", Offset = "0x31A6D40", VA = "0x1831A7B40", Slot = "17")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x31A7AB0", Offset = "0x31A6CB0", VA = "0x1831A7AB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x31A7870", Offset = "0x31A6A70", VA = "0x1831A7870", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	protected HHJNKOGKPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class FOIMEBLICIG
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] DICCOGOFCJL;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class AAGANFGPMAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, OMCDLMPOANH> CGKHLCEONNO;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public OMCDLMPOANH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DFD0", Offset = "0x2C3D1D0", VA = "0x182C3DFD0")]
		get
		{
			return default(OMCDLMPOANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E060", Offset = "0x2C3D260", VA = "0x182C3E060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E0B0", Offset = "0x2C3D2B0", VA = "0x182C3E0B0")]
	public AAGANFGPMAE(CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D8C0", Offset = "0x2C3CAC0", VA = "0x182C3D8C0")]
	public bool CPKINNFJFHF(ComponentType HBILNHOEIJP, out OMCDLMPOANH MNKFJJIHAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D580", Offset = "0x2C3C780", VA = "0x182C3D580")]
	public Dictionary<ComponentType, OMCDLMPOANH>.Enumerator AHIPNMLLDNB()
	{
		return default(Dictionary<ComponentType, OMCDLMPOANH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D930", Offset = "0x2C3CB30", VA = "0x182C3D930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2C3DB70", Offset = "0x2C3CD70", VA = "0x182C3DB70")]
	private void JNIKBKFLDOE(IEnumerable<BCNEEGFPPIH> NBCLHDKKCNA, EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2C3DAC0", Offset = "0x2C3CCC0", VA = "0x182C3DAC0")]
	private static int JBEOLFNIDCM(BCNEEGFPPIH MBGKNDLKFDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D610", Offset = "0x2C3C810", VA = "0x182C3D610")]
	private static NativeArray<FBGJBPABGDC> BMJAFFONEIC(BCNEEGFPPIH MBGKNDLKFDJ, Allocator OPBLDCCKGEG = Allocator.Persistent)
	{
		return default(NativeArray<FBGJBPABGDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface DOBDGKNHJII
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool CELDDGFEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOCBOCJCBIN(out NativeArray<int> KJCOLFIBADD, Allocator OPBLDCCKGEG);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKMBGAHALGF(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP, out OMCDLMPOANH AJMEBMGKGGC);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MKMBGAHALGF(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFMAIOKLGLK FEHBPADFEII(ComponentType HBILNHOEIJP);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JDPCKAFOGOO IBKCIFBPPKJ();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDAGJHLGGFL(JobHandle GNEAPAJLKDP);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
internal interface LJBFLMONAFL
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	EOHNGDMHPEJ EFPANIGJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, GBDBBLLJIJK> POMNHHAKDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle HNKHEPALLHI
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
	bool HBGEMGCKMHE();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPNLAFLJCKH();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNJKDJGDNPJ(ComponentType HBILNHOEIJP, in CFMAIOKLGLK HBJHPADKKFF);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OCLLBEBJMPO(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct JDPCKAFOGOO
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct DAKHKODMHGI : IEnumerator<GBDBBLLJIJK>, IEnumerator, IDisposable, IEnumerable<GBDBBLLJIJK>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, GBDBBLLJIJK> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity OAOGLFGGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> FNFFOLJGBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private GBDBBLLJIJK BEKIFNKENPL;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public GBDBBLLJIJK CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xCBEDD0", Offset = "0xCBDFD0", VA = "0x180CBEDD0", Slot = "4")]
			get
			{
				return default(GBDBBLLJIJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x41C2CE0", Offset = "0x41C1EE0", VA = "0x1841C2CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x41C2D30", Offset = "0x41C1F30", VA = "0x1841C2D30")]
		internal DAKHKODMHGI(NativeMultiHashMap<Entity, GBDBBLLJIJK> KFCGKKLOJFF, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x41C2AD0", Offset = "0x41C1CD0", VA = "0x1841C2AD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x41C2AA0", Offset = "0x41C1CA0", VA = "0x1841C2AA0")]
		public DAKHKODMHGI AHIPNMLLDNB()
		{
			return default(DAKHKODMHGI);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x41C2BA0", Offset = "0x41C1DA0", VA = "0x1841C2BA0", Slot = "9")]
		private IEnumerator<GBDBBLLJIJK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x41C2C40", Offset = "0x41C1E40", VA = "0x1841C2C40", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly LJBFLMONAFL BGHMFEPCABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle EEMENGAFDFO;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int AMKHNDPHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x31AF840", Offset = "0x31AEA40", VA = "0x1831AF840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x31AF640", Offset = "0x31AE840", VA = "0x1831AF640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5B40", Offset = "0x1CD4D40", VA = "0x181CD5B40")]
	public JDPCKAFOGOO(LJBFLMONAFL BGHMFEPCABE, JobHandle EEMENGAFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x31AFAA0", Offset = "0x31AECA0", VA = "0x1831AFAA0")]
	public bool HNDLHADPJOO(Allocator OPBLDCCKGEG, out NativeKeyValueArrays<Entity, GBDBBLLJIJK> APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x31AF930", Offset = "0x31AEB30", VA = "0x1831AF930")]
	public bool DKLHLMDGNNP(Allocator OPBLDCCKGEG, out (NativeArray<Entity> entities, int uniqueCount) APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x31AF720", Offset = "0x31AE920", VA = "0x1831AF720")]
	public DAKHKODMHGI CJKHCAOBOFF(Entity OAOGLFGGBPI)
	{
		return default(DAKHKODMHGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class EOHNGDMHPEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<OMCDLMPOANH> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public OMCDLMPOANH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x319C1C0", Offset = "0x319B3C0", VA = "0x18319C1C0")]
		get
		{
			return default(OMCDLMPOANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x319C250", Offset = "0x319B450", VA = "0x18319C250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x319C290", Offset = "0x319B490", VA = "0x18319C290")]
	public EOHNGDMHPEJ(AAGANFGPMAE CGKHLCEONNO, CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x319BC80", Offset = "0x319AE80", VA = "0x18319BC80")]
	public List<OMCDLMPOANH>.Enumerator AHIPNMLLDNB()
	{
		return default(List<OMCDLMPOANH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x319BD00", Offset = "0x319AF00", VA = "0x18319BD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x319BE80", Offset = "0x319B080", VA = "0x18319BE80")]
	private void JNIKBKFLDOE(AAGANFGPMAE CGKHLCEONNO, EntityManager KNABDDPENKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class KDPNKMKDLAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::DGIKCDEPKDI<BCNEEGFPPIH> KNGEPEIOMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World KIIGBAKFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager KNABDDPENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> IEHEJIODGKG;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x31B3390", Offset = "0x31B2590", VA = "0x1831B3390")]
	public KDPNKMKDLAM(ObjectInstantiationService DHJNAJDHBIA, CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x31B1C90", Offset = "0x31B0E90", VA = "0x1831B1C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x31B3180", Offset = "0x31B2380", VA = "0x1831B3180")]
	public bool OHLPFOOMIAD(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x31B2A40", Offset = "0x31B1C40", VA = "0x1831B2A40")]
	private void LGINHKKOKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x31B2510", Offset = "0x31B1710", VA = "0x1831B2510")]
	private EntityArchetype JHMNGCOJFLB(EntityArchetype DADKLHEKCJP)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x31B20E0", Offset = "0x31B12E0", VA = "0x1831B20E0")]
	public static void HMJMJJLCGML(EntityManager FDDCHHJLNLF, EntityManager PMCBFHAJAOJ, NativeArray<Entity> EOPMDICNPHI, NativeArray<EntityArchetype> NHPPGOOBAHO, [Optional] NativeArray<Entity> DGICGHHINEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x31B1B20", Offset = "0x31B0D20", VA = "0x1831B1B20")]
	[Conditional("DEBUG_BUILD")]
	private static void AJKCKJDKMPF(NativeArray<EntityArchetype> FIFGIFGGGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x31B1EA0", Offset = "0x31B10A0", VA = "0x1831B1EA0")]
	private static string ENCCFGOODIM(EntityArchetype CAABDGCKDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x31B1D60", Offset = "0x31B0F60", VA = "0x1831B1D60")]
	[CompilerGenerated]
	internal static void EAOAMDDHBAH(ref Span<ComponentType> MNKPHDHCEDF, ComponentType JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x31B31E0", Offset = "0x31B23E0", VA = "0x1831B31E0")]
	[CompilerGenerated]
	internal static void PGPHEBEJHFG(Span<ComponentType> PFCDNINKMFA, ref Span<ComponentType> MNKPHDHCEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x31B30A0", Offset = "0x31B22A0", VA = "0x1831B30A0")]
	[CompilerGenerated]
	internal static void LLJLECKDCCM(Span<ComponentType> PFCDNINKMFA, ref Span<ComponentType> MNKPHDHCEDF, ComponentType ONPDMHJKADH)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld FHMPGBCOEKP;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C42A80", Offset = "0x2C41C80", VA = "0x182C42A80", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C429D0", Offset = "0x2C41BD0", VA = "0x182C429D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct FLBDNOLCEHG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> JDOHCNPIBGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> IPCLJEDBOLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<FBGJBPABGDC> LAMFBEMMFAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<PBFFOMIANOH>.ParallelWriter NCOBIAFJNFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int APFMFONOKKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int MIJACNKDCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5000", Offset = "0x2CB4200", VA = "0x182CB5000", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5140", Offset = "0x2CB4340", VA = "0x182CB5140")]
			private unsafe int FNPJGENNBMJ(byte* ELEMBGKEMPE, byte* BGHFDNDJKMA)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct JHICOFNPIHB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> NLCHEAKJBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<PBFFOMIANOH> EAPAOOBBMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5940", Offset = "0x2CB4B40", VA = "0x182CB5940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct LFGKIGJMCID : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> NDEJALFCCJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity EFILNEPNOPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int KKDBIBDEEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6730", Offset = "0x2CB5930", VA = "0x182CB6730", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct GHJMBCPHOID : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, GBDBBLLJIJK> ECALILOKEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> JHBHPHLKKNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> BEKIFNKENPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<FBGJBPABGDC> LIOLINCGCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> PLGKAEIBFCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int PLGECGICBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int ENFCEHCBAIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2CB51D0", Offset = "0x2CB43D0", VA = "0x182CB51D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker HJICNBJCEEC;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker GGKEEENCHEF;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker KEJGAJKFEFO;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker LFAGOLBBACH;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker KEHLHFAJDCC;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker JANPDLGEOOH;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker GDKLKKGIGHO;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker NEOLBKGMKBO;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker DGHIMNCGJIP;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker JELDMOBCCLL;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker BMMFIACCAGJ;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker DBMNENCFDAI;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker MJNMKMELCMI;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker ANDOEGKPHEP;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker DANHGNMINME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery GKBBEIMEIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery KBPHPMFNMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World JMJANPOMBMK
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C4DB80", Offset = "0x2C4CD80", VA = "0x182C4DB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private LJBFLMONAFL BFKMFKKIINE
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E0E0", Offset = "0x2C4D2E0", VA = "0x182C4E0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EEC0", Offset = "0x2C4E0C0", VA = "0x182C4EEC0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "15")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EBC0", Offset = "0x2C4DDC0", VA = "0x182C4EBC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ED80", Offset = "0x2C4DF80", VA = "0x182C4ED80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ED10", Offset = "0x2C4DF10", VA = "0x182C4ED10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BF40", Offset = "0x2C4B140", VA = "0x182C4BF40")]
		private void CBPBFOPCDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C4EBA0", Offset = "0x2C4DDA0", VA = "0x182C4EBA0")]
		internal void ONNOIGGBOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E3D0", Offset = "0x2C4D5D0", VA = "0x182C4E3D0")]
		private void ONNOIGGBOFG(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C2F0", Offset = "0x2C4B4F0", VA = "0x182C4C2F0")]
		private void GDGBCEFGLGP(NativeArray<Entity> EOPMDICNPHI, NativeArray<RRObjectPrefabData> HGNEOGGNINJ, ref NativeArray<Entity> JIKKHKNCDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DC40", Offset = "0x2C4CE40", VA = "0x182C4DC40")]
		internal void JHDKDKHBGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DC60", Offset = "0x2C4CE60", VA = "0x182C4DC60")]
		private void JHDKDKHBGOE(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C4CE90", Offset = "0x2C4C090", VA = "0x182C4CE90")]
		internal void IHHEDLFOPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D8A0", Offset = "0x2C4CAA0", VA = "0x182C4D8A0")]
		private void IPEEEOKDCID(LJBFLMONAFL BGHMFEPCABE, OMCDLMPOANH AJMEBMGKGGC, bool KINJNAKPOMK, ref JobHandle JKAHDCBCMPG, ref JobHandle NLGJALJNGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C530", Offset = "0x2C4B730", VA = "0x182C4C530")]
		internal bool HPOKFIIECLA(in OMCDLMPOANH BGHFDNDJKMA, out JobHandle KJNCDAGJAPF, out CFMAIOKLGLK GDPOICOMAOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C560", Offset = "0x2C4B760", VA = "0x182C4C560")]
		private bool HPOKFIIECLA(in OMCDLMPOANH BGHFDNDJKMA, bool KINJNAKPOMK, out JobHandle KJNCDAGJAPF, out CFMAIOKLGLK GDPOICOMAOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E210", Offset = "0x2C4D410", VA = "0x182C4E210")]
		internal (NativeList<int>, NativeList<int>) NLINGKGJJED(NativeList<PBFFOMIANOH> EAPAOOBBMGJ, int DOMGBHGFPFL, JobHandle MEDEIGIKJJO, out JobHandle GNEAPAJLKDP, Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C4C240", Offset = "0x2C4B440", VA = "0x182C4C240")]
		internal static NativeArray<Entity> EADCJFIJEDO(EntityQuery JLMGAJOHFKO, out JobHandle JCEEGHEHAGP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E060", Offset = "0x2C4D260", VA = "0x182C4E060")]
		internal static NativeArray<byte> KMJBGPPAFPI(int NPNCGJAPKIL, out JobHandle AEAFBCLMAIL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E100", Offset = "0x2C4D300", VA = "0x182C4E100")]
		internal static NativeArray<byte> NHGHHOKMABG(EntityQuery JLMGAJOHFKO, int NLGBDLLFIPJ, out JobHandle AEAFBCLMAIL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BCB0", Offset = "0x2C4AEB0", VA = "0x182C4BCB0")]
		internal static NativeArray<Entity> ACOCCFAIDOG(EntityQuery JLMGAJOHFKO, out JobHandle IOMBFCCNMIL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D630", Offset = "0x2C4C830", VA = "0x182C4D630")]
		internal NativeArray<byte> ILAEEHEKKLB(NativeArray<Entity> GNGEEFEGDCP, OMCDLMPOANH AJMEBMGKGGC, JobHandle MEDEIGIKJJO, out JobHandle GNEAPAJLKDP, Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BDB0", Offset = "0x2C4AFB0", VA = "0x182C4BDB0")]
		internal JobHandle BGCCBCNMGOL(in CFMAIOKLGLK ONIBEFDCPGD, in OMCDLMPOANH AJMEBMGKGGC, NativeMultiHashMap<Entity, GBDBBLLJIJK> ECALILOKEOO, JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x10A9190", Offset = "0x10A8390", VA = "0x1810A9190")]
		private JobHandle HFGOKLFHDID(JobHandle HOLIJANELEK, JobHandle FECDABLMHPH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x10A9190", Offset = "0x10A8390", VA = "0x1810A9190")]
		private JobHandle HFGOKLFHDID(JobHandle HOLIJANELEK, JobHandle FECDABLMHPH, JobHandle NAKCKBDNDBI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateHoverRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct IJHPADLEHPO : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2A895A0", Offset = "0x2A887A0", VA = "0x182A895A0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2A89600", Offset = "0x2A88800", VA = "0x182A89600", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A895D0", Offset = "0x2A887D0", VA = "0x182A895D0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A82620", Offset = "0x2A81820", VA = "0x182A82620")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateSelectionRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct PDMEBGFPAKO : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2A89630", Offset = "0x2A88830", VA = "0x182A89630", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2A89690", Offset = "0x2A88890", VA = "0x182A89690", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2A89660", Offset = "0x2A88860", VA = "0x182A89660", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A82620", Offset = "0x2A81820", VA = "0x182A82620")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[LOFBNDLMONN]
public class FLBBDJNLCKP : ILHKCJPPBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x31A4140", Offset = "0x31A3340", VA = "0x1831A4140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x31A41D0", Offset = "0x31A33D0", VA = "0x1831A41D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public FLBBDJNLCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[LOFBNDLMONN]
public class DKBPFAICKBK : ILHKCJPPBMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct PFEHFEBOKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public PFEHFEBOKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct KHDPHNHLHPP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct DOPKEGCGOLK
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct FOANKNCJOPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime PCEBLCHCHJC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> DBANDHAINFN;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x41C35A0", Offset = "0x41C27A0", VA = "0x1841C35A0")]
			public void BHIDKDBKBAC(DKBPFAICKBK MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x41C3600", Offset = "0x41C2800", VA = "0x1841C3600")]
			public FOANKNCJOPA OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(FOANKNCJOPA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> PNBLHJIMJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private DOPKEGCGOLK LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DOPKEGCGOLK.FOANKNCJOPA* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HDJBFJIALLJ;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6540", Offset = "0x2CB5740", VA = "0x182CB6540")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, SplinePointParentData CKJEELMDBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6710", Offset = "0x2CB5910", VA = "0x182CB6710", Slot = "5")]
		public void ReadFromDisplayClass(ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6720", Offset = "0x2CB5920", VA = "0x182CB6720", Slot = "6")]
		public void WriteToDisplayClass(ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x2CB65F0", Offset = "0x2CB57F0", VA = "0x182CB65F0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6660", Offset = "0x2CB5860", VA = "0x182CB6660")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref DOPKEGCGOLK.FOANKNCJOPA DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB65B0", Offset = "0x2CB57B0", VA = "0x182CB65B0")]
		public void BHIDKDBKBAC(DKBPFAICKBK MFPLGOJOEDD, ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CB64D0", Offset = "0x2CB56D0", VA = "0x182CB64D0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C57440", Offset = "0x2C56640", VA = "0x182C57440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public DKBPFAICKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C57210", Offset = "0x2C56410", VA = "0x182C57210", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C57700", Offset = "0x2C56900", VA = "0x182C57700")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[LOFBNDLMONN]
public class LMHAMJBPEEL : ILHKCJPPBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery NNHMIIDOGFK;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F2E0", Offset = "0x2A6E4E0", VA = "0x182A6F2E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F370", Offset = "0x2A6E570", VA = "0x182A6F370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public LMHAMJBPEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(FLBBDJNLCKP))]
public class EHGBFCHOFGP : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x319A6D0", Offset = "0x31998D0", VA = "0x18319A6D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public EHGBFCHOFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class NDABIIHCCGC : ILHKCJPPBMP, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct IIJNCIDFPCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<IOLFAAOECPP, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public IIJNCIDFPCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CIDABAMLGFE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct EDFPNOOIAAL
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct FFMFMDDDIID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BNGNICNMLNH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JEFPCLJPLFC;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x41C37B0", Offset = "0x41C29B0", VA = "0x1841C37B0")]
			public void BHIDKDBKBAC(NDABIIHCCGC MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x41C3810", Offset = "0x41C2A10", VA = "0x1841C3810")]
			public FFMFMDDDIID OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(FFMFMDDDIID);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private EDFPNOOIAAL LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EDFPNOOIAAL.FFMFMDDDIID* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x41C22E0", Offset = "0x41C14E0", VA = "0x1841C22E0")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ObjectNetworkIdComponentData MMOOINOADGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x119AF90", Offset = "0x119A190", VA = "0x18119AF90", Slot = "5")]
		public void ReadFromDisplayClass(ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x22DC4A0", Offset = "0x22DB6A0", VA = "0x1822DC4A0", Slot = "6")]
		public void WriteToDisplayClass(ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x41C23F0", Offset = "0x41C15F0", VA = "0x1841C23F0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x41C2490", Offset = "0x41C1690", VA = "0x1841C2490")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref EDFPNOOIAAL.FFMFMDDDIID DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x41C2360", Offset = "0x41C1560", VA = "0x1841C2360")]
		public void BHIDKDBKBAC(NDABIIHCCGC MFPLGOJOEDD, ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x41C2270", Offset = "0x41C1470", VA = "0x1841C2270")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService OHHOLLBKJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A73470", Offset = "0x2A72670", VA = "0x182A73470", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A731D0", Offset = "0x2A723D0", VA = "0x182A731D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public NDABIIHCCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A72FD0", Offset = "0x2A721D0", VA = "0x182A72FD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A73310", Offset = "0x2A72510", VA = "0x182A73310")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class HBFIJPFJDNH : ILHKCJPPBMP, DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LDGCEFELFCJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct GIDKBJHGLBL
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct GCMBOELCLPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NDEGDPEAEPB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> ECKGELJDACG;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x41C5830", Offset = "0x41C4A30", VA = "0x1841C5830")]
			public void BHIDKDBKBAC(HBFIJPFJDNH MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x41C5890", Offset = "0x41C4A90", VA = "0x1841C5890")]
			public GCMBOELCLPO OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(GCMBOELCLPO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HBFIJPFJDNH INPNEHDIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private GIDKBJHGLBL LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GIDKBJHGLBL.GCMBOELCLPO* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x41C93F0", Offset = "0x41C85F0", VA = "0x1841C93F0")]
		public void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData CEOGJFOKGBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x41C9490", Offset = "0x41C8690", VA = "0x1841C9490", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x41C9530", Offset = "0x41C8730", VA = "0x1841C9530")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref GIDKBJHGLBL.GCMBOELCLPO DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x41C9410", Offset = "0x41C8610", VA = "0x1841C9410")]
		public void BHIDKDBKBAC(HBFIJPFJDNH MFPLGOJOEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x41C9380", Offset = "0x41C8580", VA = "0x1841C9380")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x31A7730", Offset = "0x31A6930", VA = "0x1831A7730", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x31A74C0", Offset = "0x31A66C0", VA = "0x1831A74C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public HBFIJPFJDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x31A70D0", Offset = "0x31A62D0", VA = "0x1831A70D0")]
	[CompilerGenerated]
	private void MBOPKOFPBBH(Entity OAOGLFGGBPI, ParentData CEOGJFOKGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x31A72C0", Offset = "0x31A64C0", VA = "0x1831A72C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x31A75D0", Offset = "0x31A67D0", VA = "0x1831A75D0")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class ACEOOKLAJPC : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int GNJEMLNNPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs DHJNAJDHBIA;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2C3EAA0", Offset = "0x2C3DCA0", VA = "0x182C3EAA0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E7E0", Offset = "0x2C3D9E0", VA = "0x182C3E7E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E8C0", Offset = "0x2C3DAC0", VA = "0x182C3E8C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E490", Offset = "0x2C3D690", VA = "0x182C3E490")]
	private void IDDAJNLGMGN(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public ACEOOKLAJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	[UpdateBefore(typeof(ACEOOKLAJPC))]
	public class PostLoadAddSceneTagEntity : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService KJGMKGKKNGC;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2A877D0", Offset = "0x2A869D0", VA = "0x182A877D0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2A87610", Offset = "0x2A86810", VA = "0x182A87610", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[ELANPKCEIEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	public class PostLoadInitializeNetworkId : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct KNNIJDGIMNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<IOLFAAOECPP, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
			public KNNIJDGIMNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct GHMGMBJCFLO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct BCFIEGJALMO
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct CPANLLJIAPC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime AGLILKJOIBC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BNGNICNMLNH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex EEKLHCACNAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JEFPCLJPLFC;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x41C1210", Offset = "0x41C0410", VA = "0x1841C1210")]
				public void BHIDKDBKBAC(PostLoadInitializeNetworkId MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x41C1280", Offset = "0x41C0480", VA = "0x1841C1280")]
				public CPANLLJIAPC OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(CPANLLJIAPC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private BCFIEGJALMO LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BCFIEGJALMO.CPANLLJIAPC* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HDJBFJIALLJ;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x41C5540", Offset = "0x41C4740", VA = "0x1841C5540")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, int EHDOKFHFJCO, ref ObjectNetworkIdComponentData MMOOINOADGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x119AF90", Offset = "0x119A190", VA = "0x18119AF90", Slot = "5")]
			public void ReadFromDisplayClass(ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x22DC4A0", Offset = "0x22DB6A0", VA = "0x1822DC4A0", Slot = "6")]
			public void WriteToDisplayClass(ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x41C5670", Offset = "0x41C4870", VA = "0x1841C5670", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x41C5760", Offset = "0x41C4960", VA = "0x1841C5760")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref BCFIEGJALMO.CPANLLJIAPC DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x41C55D0", Offset = "0x41C47D0", VA = "0x1841C55D0")]
			public void BHIDKDBKBAC(PostLoadInitializeNetworkId MFPLGOJOEDD, ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x41C54D0", Offset = "0x41C46D0", VA = "0x1841C54D0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[IMNMHIBEIDL]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery ADIJGJANNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker FEJPEEDJFOG;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2A885C0", Offset = "0x2A877C0", VA = "0x182A885C0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2A88450", Offset = "0x2A87650", VA = "0x182A88450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2A884F0", Offset = "0x2A876F0", VA = "0x182A884F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2A884F0", Offset = "0x2A876F0", VA = "0x182A884F0")]
		public void PKOGPJICAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2A87870", Offset = "0x2A86A70", VA = "0x182A87870")]
		private void FACCCJNMIEC(NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2A87DC0", Offset = "0x2A86FC0", VA = "0x182A87DC0")]
		private void GCBGNANIKII(NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2A881C0", Offset = "0x2A873C0", VA = "0x182A881C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2A88020", Offset = "0x2A87220", VA = "0x182A88020")]
		public static EntityQuery IEAFAJBHNKF(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class LENCDLIDLEJ : DHDEFGPGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery ICNCIOMOAKJ;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E280", Offset = "0x2A6D480", VA = "0x182A6E280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E310", Offset = "0x2A6D510", VA = "0x182A6E310", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public LENCDLIDLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class LAGGJIEOGKN : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::DGIKCDEPKDI<CMIJGGBLCJC> EFAGAJHPINO;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x31B8700", Offset = "0x31B7900", VA = "0x1831B8700", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x31B8400", Offset = "0x31B7600", VA = "0x1831B8400", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x31B8270", Offset = "0x31B7470", VA = "0x1831B8270")]
	private void MGEBOHMCLIB(NativeList<EntityArchetype> FIFGIFGGGDP, NativeHashMap<int, CHLMDABNGKB> PIEGJJIHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x31B8130", Offset = "0x31B7330", VA = "0x1831B8130")]
	private Span<int> KFEAJOIPJAK(EntityArchetype CAABDGCKDOD)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x31B7A60", Offset = "0x31B6C60", VA = "0x1831B7A60")]
	private bool AAIFOOJECBN(int NLGBDLLFIPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x31B7B30", Offset = "0x31B6D30", VA = "0x1831B7B30")]
	private void IPDINAFCCJL(NativeHashMap<int, CHLMDABNGKB> PIEGJJIHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public LAGGJIEOGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	public class PreSerializeRemoveEntities : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery MFAAHFEILOO;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2A88680", Offset = "0x2A87880", VA = "0x182A88680", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2A88900", Offset = "0x2A87B00", VA = "0x182A88900", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct BGAGDOKDPKF
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
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
			public BGAGDOKDPKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2CB8100", Offset = "0x2CB7300", VA = "0x182CB8100")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct FAHAHCDLBGE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> HHLLOPMMJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity BANMGIDCEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> BEKIFNKENPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int KKDBIBDEEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType HBILNHOEIJP;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x41C4130", Offset = "0x41C3330", VA = "0x1841C4130")]
			internal void AOFNEGGIPNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x41C4320", Offset = "0x41C3520", VA = "0x1841C4320", Slot = "5")]
			public void ReadFromDisplayClass(ref BGAGDOKDPKF IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x41C4310", Offset = "0x41C3510", VA = "0x1841C4310", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x41C42F0", Offset = "0x41C34F0", VA = "0x1841C42F0")]
			public void BHIDKDBKBAC(ShadowWorldApplyPropertyDifferencesToShadowWorld MFPLGOJOEDD, ref BGAGDOKDPKF IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle NHNANODGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle CMLFNGKGMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private DOBDGKNHJII BGHMFEPCABE;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2CBFB10", Offset = "0x2CBED10", VA = "0x182CBFB10", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF730", Offset = "0x2CBE930", VA = "0x182CBF730")]
		public JobHandle OGDLHKKECID(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF770", Offset = "0x2CBE970", VA = "0x182CBF770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2CBF420", Offset = "0x2CBE620", VA = "0x182CBF420")]
		private bool GIJDDCJBIIA(JobHandle MEDEIGIKJJO, int NLGBDLLFIPJ, out JobHandle PLJEPLODDHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(CDPBEFOKBPH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class HGIDMMLPHAI : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x31A7790", Offset = "0x31A6990", VA = "0x1831A7790", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public HGIDMMLPHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(PAADBABBJJN))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class ENLDJKKLAHP : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x319BB30", Offset = "0x319AD30", VA = "0x18319BB30", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public ENLDJKKLAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(BADAIICIPJH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class GOJJMONEOOE : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x31A6D50", Offset = "0x31A5F50", VA = "0x1831A6D50", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public GOJJMONEOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(OLEIJCJDIOL))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class ACDNAFCMOHG : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E310", Offset = "0x2C3D510", VA = "0x182C3E310", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public ACDNAFCMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class IFEIMGKNEIP : HHJNKOGKPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAA0", Offset = "0x6ECCA0", VA = "0x1806EDAA0", Slot = "18")]
		get
		{
			return default(ENELKKCPMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public IFEIMGKNEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(GCJNDOFEDGI))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class GODCOHPPKAB : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x31A6530", Offset = "0x31A5730", VA = "0x1831A6530", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public GODCOHPPKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class IKFOHLNNICL : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public IKFOHLNNICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class HALIFIOBHAG : HHJNKOGKPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "18")]
		get
		{
			return default(ENELKKCPMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public HALIFIOBHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(FLHGDPEKGFK))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class LDLOJEMFNHL : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D280", Offset = "0x2A6C480", VA = "0x182A6D280", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public LDLOJEMFNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class IFIIAKANGFH : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public IFIIAKANGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class BEFJKHFDDAH : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public BEFJKHFDDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class JIADEHDPCNK : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public JIADEHDPCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[LOFBNDLMONN]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class OMIPJNCFJPF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService JOGKAGECKFN;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B10", Offset = "0x2A73D10", VA = "0x182A74B10", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2A74AF0", Offset = "0x2A73CF0", VA = "0x182A74AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public OMIPJNCFJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct BFAEOKGMNEO : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float CEONAHNHACE = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> HKIJDOHMPBL;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2CB3920", Offset = "0x2CB2B20", VA = "0x182CB3920", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2CB3AE0", Offset = "0x2CB2CE0", VA = "0x182CB3AE0")]
			private bool KHOLPCLPIOM(float3 AFLEFPKENKF, float3 IAMOONJKNLF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2CB38B0", Offset = "0x2CB2AB0", VA = "0x182CB38B0")]
			private bool CICNCHCOJEF(quaternion AFLEFPKENKF, quaternion IAMOONJKNLF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct DMCKJDDNEOD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> LGIFNGEDBFC;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4830", Offset = "0x2CB3A30", VA = "0x182CB4830", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly FADHLPPNOEF HAKKCCOEJEA;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly FADHLPPNOEF DPAPELHLEIJ;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly FADHLPPNOEF HPMAGILDKAC;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker FBLCINJIPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2C52460", Offset = "0x2C51660", VA = "0x182C52460", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2C520C0", Offset = "0x2C512C0", VA = "0x182C520C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2C520F0", Offset = "0x2C512F0", VA = "0x182C520F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class RegisterTransforms : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JFGOOBPPCHF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct BJEGJCPBMOE
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct DJECMOIIJLB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO>.Runtime EPDAMFLJBCJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime KKKCDBJJGDE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO> BNKHDBMHHLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> KIHDLLCLDIP;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x41C1C60", Offset = "0x41C0E60", VA = "0x1841C1C60")]
				public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x41C1CE0", Offset = "0x41C0EE0", VA = "0x1841C1CE0")]
				public DJECMOIIJLB OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(DJECMOIIJLB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private BJEGJCPBMOE LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BJEGJCPBMOE.DJECMOIIJLB* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x41C7200", Offset = "0x41C6400", VA = "0x1841C7200")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, AHIGIKNEKPO POHDMEMKCCD, Transform LJLOGOIJMEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x41C7310", Offset = "0x41C6510", VA = "0x1841C7310", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x41C7400", Offset = "0x41C6600", VA = "0x1841C7400")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref BJEGJCPBMOE.DJECMOIIJLB DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x41C7300", Offset = "0x41C6500", VA = "0x1841C7300")]
			public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x41C7190", Offset = "0x41C6390", VA = "0x1841C7190")]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OJCFFJPOHAI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct NANFIBFKLGE
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct JMJNCPHEKBG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO>.Runtime EPDAMFLJBCJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO> BNKHDBMHHLK;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x41C9D00", Offset = "0x41C8F00", VA = "0x1841C9D00")]
				public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x41C9D60", Offset = "0x41C8F60", VA = "0x1841C9D60")]
				public JMJNCPHEKBG OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(JMJNCPHEKBG);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private NANFIBFKLGE LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NANFIBFKLGE.JMJNCPHEKBG* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x41CAB60", Offset = "0x41C9D60", VA = "0x1841CAB60")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, AHIGIKNEKPO POHDMEMKCCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x41CAC40", Offset = "0x41C9E40", VA = "0x1841CAC40", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x41CACD0", Offset = "0x41C9ED0", VA = "0x1841CACD0")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref NANFIBFKLGE.JMJNCPHEKBG DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x41C9D00", Offset = "0x41C8F00", VA = "0x1841C9D00")]
			public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery MCHKMIPNOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery FALOFACHEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery MCDDFLEGICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery KMMFIDLFKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery OIKENPHJBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker KNLEJMNKDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery IPJPLDCHBIB;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9350", Offset = "0x2CB8550", VA = "0x182CB9350", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9070", Offset = "0x2CB8270", VA = "0x182CB9070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9280", Offset = "0x2CB8480", VA = "0x182CB9280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8A20", Offset = "0x2CB7C20", VA = "0x182CB8A20")]
		private void KLGGBKKIFAI(EntityQuery JLMGAJOHFKO, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8180", Offset = "0x2CB7380", VA = "0x182CB8180")]
		private void DKLNMNLOMJH(EntityQuery JLMGAJOHFKO, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9220", Offset = "0x2CB8420", VA = "0x182CB9220", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2CB88E0", Offset = "0x2CB7AE0", VA = "0x182CB88E0")]
		private void KEKBJMLNMOH(NativeArray<Entity> GNGEEFEGDCP, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB83F0", Offset = "0x2CB75F0", VA = "0x182CB83F0")]
		[BurstCompile]
		internal static void GOCBKJBPGME(NativeArray<AHIGIKNEKPO> JFIMNHPLHBN, ComponentDataFromEntity<AHIGIKNEKPO> JCEGHLMGKEA, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void EKBHDPJPKLP(Transform LJLOGOIJMEM, Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void DPKKGPFDHNE(Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void DGPKCGALGFD(int BELCAJFDAHD, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8700", Offset = "0x2CB7900", VA = "0x182CB8700")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HJFMNCNAFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8E00", Offset = "0x2CB8000", VA = "0x182CB8E00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8C60", Offset = "0x2CB7E60", VA = "0x182CB8C60")]
		public static EntityQuery LEFDHBJCJHF(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2CB93A0", Offset = "0x2CB85A0", VA = "0x182CB93A0")]
		public static EntityQuery PKBFLMINOHP(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class CopyTransformDataToGameObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct GJOPBBGONLL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> HKIJDOHMPBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5450", Offset = "0x2CB4650", VA = "0x182CB5450", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct EMJIKOJGCGE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4A50", Offset = "0x2CB3C50", VA = "0x182CB4A50", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct JIPGLKGPANE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> LGIFNGEDBFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5A20", Offset = "0x2CB4C20", VA = "0x182CB5A20", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly FADHLPPNOEF HAKKCCOEJEA;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FADHLPPNOEF DPAPELHLEIJ;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly FADHLPPNOEF HPMAGILDKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery AKLGMKMLJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery IKKMFGIJJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery BEIECPDCKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray ILILIKHGFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray LDAOLCLLDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray CLPCDGMHFPO;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2C53260", Offset = "0x2C52460", VA = "0x182C53260", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2C52790", Offset = "0x2C51990", VA = "0x182C52790", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2C52980", Offset = "0x2C51B80", VA = "0x182C52980", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2C52A10", Offset = "0x2C51C10", VA = "0x182C52A10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2C52A40", Offset = "0x2C51C40", VA = "0x182C52A40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2C52610", Offset = "0x2C51810", VA = "0x182C52610")]
		private NativeArray<Entity> DNBPFDPOOPI(NativeArray<AHIGIKNEKPO> GGHFLGHFEMD, NativeList<Entity> EOPMDICNPHI, TransformAccessArray JHGDHCEBEBO, TransformAccessArray FMANINJHIAF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class CopyTransformParentsToGameObjects : DHDEFGPGMMG, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private LKPHHNIFJFE NEIHAKKOCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private BCCHDFPAANJ DCDKCDLJBLH;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2A88C30", Offset = "0x2A87E30", VA = "0x182A88C30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2C535E0", Offset = "0x2C527E0", VA = "0x182C535E0", Slot = "14")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2C536F0", Offset = "0x2C528F0", VA = "0x182C536F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2C53460", Offset = "0x2C52660", VA = "0x182C53460")]
		private static void HNFBJIKPBMH(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2C533C0", Offset = "0x2C525C0", VA = "0x182C533C0")]
		private static bool AAMKJDPJALI(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class L2PToL2WHierarchy : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct IBELBFGGCPD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JBKIBKHMEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> CGOCGHAGCFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> CMBIJAGAABP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CKCHEMEJJOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> OCHHGJDLMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> PCJJOCJDEIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint LBAGCJGFKCK;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x41C65B0", Offset = "0x41C57B0", VA = "0x1841C65B0")]
			[Conditional("DEBUG_BUILD")]
			private void DNNKHGBPENM(Entity OAOGLFGGBPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x41C6680", Offset = "0x41C5880", VA = "0x1841C6680", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x41C6970", Offset = "0x41C5B70", VA = "0x1841C6970")]
			private void PDGDMAFHNMF(float4x4 IBJFMBEOAPA, Entity OAOGLFGGBPI, bool ILIEDJAPGLC, int ELMCLGINMHD = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery JNECPNBJKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery BNALOLGAMCD;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x31B7620", Offset = "0x31B6820", VA = "0x1831B7620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x31B7740", Offset = "0x31B6940", VA = "0x1831B7740", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class ONINDKIHCDA : CICADLGFANF
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct PPAIJAPNAIL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JBKIBKHMEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> OCHHGJDLMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x41CBA70", Offset = "0x41CAC70", VA = "0x1841CBA70", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x41CBB70", Offset = "0x41CAD70", VA = "0x1841CBB70")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery JNECPNBJKBE;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B60", Offset = "0x2A73D60", VA = "0x182A74B60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2A74C90", Offset = "0x2A73E90", VA = "0x182A74C90", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public ONINDKIHCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class LDDDOGLJEOF : CICADLGFANF
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct OBLMDMLDJJO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> DNBPPLDKJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> BMGLDGMPIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> ODEKOHFGDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> OLCDPOMDCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x41CA5B0", Offset = "0x41C97B0", VA = "0x1841CA5B0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x41CA960", Offset = "0x41C9B60", VA = "0x1841CA960")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CEB0", Offset = "0x2A6C0B0", VA = "0x182A6CEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFC0", Offset = "0x2A6C1C0", VA = "0x182A6CFC0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xEAAB30", Offset = "0xEA9D30", VA = "0x180EAAB30")]
	public LDDDOGLJEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class LDCDHKDKILF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct DKPLPHJGNIM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> MLLCIKBCILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> NEDJGGNBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> NNHICDCOAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> DBFJMBEMKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x41C2D50", Offset = "0x41C1F50", VA = "0x1841C2D50", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x41C3460", Offset = "0x41C2660", VA = "0x1841C3460")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CC10", Offset = "0x2A6BE10", VA = "0x182A6CC10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CD40", Offset = "0x2A6BF40", VA = "0x182A6CD40", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	public LDCDHKDKILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct NDIKOFPCIJM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2A896C0", Offset = "0x2A888C0", VA = "0x182A896C0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2A89720", Offset = "0x2A88920", VA = "0x182A89720", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2A896F0", Offset = "0x2A888F0", VA = "0x182A896F0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2A82620", Offset = "0x2A81820", VA = "0x182A82620")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Game)]
public class FBDOELDLMAP : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x31A3740", Offset = "0x31A2940", VA = "0x1831A3740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x31A30D0", Offset = "0x31A22D0", VA = "0x1831A30D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FBDOELDLMAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Loading)]
public class LNKFHMLNNCK : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F470", Offset = "0x2A6E670", VA = "0x182A6F470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public LNKFHMLNNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class MNEPNNNCJOA : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B60", Offset = "0x2A6FD60", VA = "0x182A70B60", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public MNEPNNNCJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Saving)]
public class BBPGBAHCPON : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD370", VA = "0x1806CE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2C44160", Offset = "0x2C43360", VA = "0x182C44160", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BBPGBAHCPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class HNNOKALKPBL : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x31A9660", Offset = "0x31A8860", VA = "0x1831A9660", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public HNNOKALKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Simulation)]
public class BDFBDHAMBHI : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2C44C70", Offset = "0x2C43E70", VA = "0x182C44C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2C448C0", Offset = "0x2C43AC0", VA = "0x182C448C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public BDFBDHAMBHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[LOJIIDJFKAI(typeof(JMFPNODBMEF), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal class JMFPNODBMEF : FPHKGEBJIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::BCEPNNPCKLO<AuthoredParentData, HLMIEDJMAKI, CJLPKAOODOE, AuthoredChildrenData> HKBOAGLHPOH;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x31B0ED0", Offset = "0x31B00D0", VA = "0x1831B0ED0", Slot = "4")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JMFPNODBMEF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(EntityHierarchyParents), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	internal sealed class EntityHierarchyParents : DPDCPMNGBKH, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[IMNMHIBEIDL]
		private PropertyChangeNetworkRouter PICAOCFCGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::DEHNDDIKMEN<Entity> LKAENGEIFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::BCEPNNPCKLO<ParentData, EHHPMHEMOMP, JJDKNDIBKCI, ChildrenData> HKBOAGLHPOH;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x31A1500", Offset = "0x31A0700", VA = "0x1831A1500", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x31A1130", Offset = "0x31A0330", VA = "0x1831A1130", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x31A14B0", Offset = "0x31A06B0", VA = "0x1831A14B0")]
		public Entity MODGPLDICAF(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x31A10D0", Offset = "0x31A02D0", VA = "0x1831A10D0")]
		public bool GFCKPIADCDP(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x31A1410", Offset = "0x31A0610", VA = "0x1831A1410")]
		public bool KKGLFGKJMPP(Entity OAOGLFGGBPI, Entity DPPABCPODHG, bool INKJNEFMNFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x31A1230", Offset = "0x31A0430", VA = "0x1831A1230")]
		private bool JCOHKFCAPAO(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(CGHKOIFBLNH), new string[] { })]
internal sealed class CGHKOIFBLNH : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery GFIAFOEDDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x2C48C20", Offset = "0x2C47E20", VA = "0x182C48C20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x2C48FD0", Offset = "0x2C481D0", VA = "0x182C48FD0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2C48B50", Offset = "0x2C47D50", VA = "0x182C48B50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2C48D80", Offset = "0x2C47F80", VA = "0x182C48D80")]
	public bool KFKEAKANFDF(Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2C489D0", Offset = "0x2C47BD0", VA = "0x182C489D0")]
	public IEnumerable<Entity> BIJKCDCNJDN(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2C490D0", Offset = "0x2C482D0", VA = "0x182C490D0")]
	public bool PNPLAMAGNCA(Entity OAOGLFGGBPI, Entity LKJGCNCCCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2C48A90", Offset = "0x2C47C90", VA = "0x182C48A90")]
	public bool CLCGCNNPCNJ(Entity OAOGLFGGBPI, Entity HOHCGCELNKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2C48E40", Offset = "0x2C48040", VA = "0x182C48E40")]
	public NativeList<Entity> KGECOFKCEIF(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false, Allocator OPBLDCCKGEG = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2C48C70", Offset = "0x2C47E70", VA = "0x182C48C70")]
	public IEnumerable<Entity> JPCGBLEHGGF(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2C48F20", Offset = "0x2C48120", VA = "0x182C48F20")]
	public Entity MNEECNHBEJG(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2C48D30", Offset = "0x2C47F30", VA = "0x182C48D30")]
	public NativeArray<Entity> KCMHHNCAIMK()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2C48900", Offset = "0x2C47B00", VA = "0x182C48900")]
	public bool ABEADFFICKO(Entity HOHCGCELNKE, Entity MDKKIEJKOGD, out Entity OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2C48B70", Offset = "0x2C47D70", VA = "0x182C48B70")]
	private Entity HHCKLGJHJDM(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CGHKOIFBLNH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x5471800", Offset = "0x5470A00", VA = "0x185471800")]
		public static void HBGEMGCKMHE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(JHLNNPKIFCO KOKEGENGCAH, global::PHNOBDPMINP<Entity> CGCMEEFENJL, out global::BCEPNNPCKLO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> EJKCHKLJKIP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LCIGIOAHNLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LCIGIOAHNLO, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2A83AE0", Offset = "0x2A82CE0", VA = "0x182A83AE0")]
		public static bool EBMHIDGOHHI(JMAKJOJHHNF CHOBEAJIPKF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class BCEPNNPCKLO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LCIGIOAHNLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LCIGIOAHNLO, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::DEHNDDIKMEN<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly DEBKKNKNNEP JFGGHOKHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly ICAMIIGEPFO GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager KNABDDPENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly BCCHDFPAANJ DCDKCDLJBLH;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EF70", Offset = "0x3E3E170", VA = "0x183E3EF70")]
	public BCEPNNPCKLO(JHLNNPKIFCO KOKEGENGCAH, global::PHNOBDPMINP<Entity> CGCMEEFENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DC60", Offset = "0x3E3CE60", VA = "0x183E3DC60")]
	private bool ANOCBCBGGJB(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EDA0", Offset = "0x3E3DFA0", VA = "0x183E3EDA0")]
	private bool PKEJCNLNHPB(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E740", Offset = "0x3E3D940", VA = "0x183E3E740")]
	public bool GFCKPIADCDP(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E100", Offset = "0x3E3D300", VA = "0x183E3E100")]
	public bool APIKBBINCEL(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DCC0", Offset = "0x3E3CEC0", VA = "0x183E3DCC0")]
	private bool APIKBBINCEL(Entity OAOGLFGGBPI, in Entity DPPABCPODHG, bool OBHLGFFLNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void MNMOCJMOCKM(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void KGNICBBGGPO(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void FOCNMBDNMHC(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void JMDPHKELOMM(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private static void IPCBOPKNMPH(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EB90", Offset = "0x3E3DD90", VA = "0x183E3EB90")]
	private bool KFKEAKANFDF(Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E130", Offset = "0x3E3D330", VA = "0x183E3E130")]
	private void BHOPKGJMACC(Entity OAOGLFGGBPI, in Entity CIPDAEPIOJL, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E910", Offset = "0x3E3DB10", VA = "0x183E3E910")]
	private void IBNFLHIBOOB(Entity OAOGLFGGBPI, in Entity CIPDAEPIOJL, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E220", Offset = "0x3E3D420", VA = "0x183E3E220")]
	private bool EBOGDHDAJJP(LADNHJNEPKG DPBGLDFEONN, in IOLFAAOECPP OIEPABNELMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x3E3EC70", Offset = "0x3E3DE70", VA = "0x183E3EC70")]
	private void LNGINODJAIF(Entity GPFONCECPBK, Entity LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E620", Offset = "0x3E3D820", VA = "0x183E3E620")]
	private void FIMHIJJNHNG(Entity GPFONCECPBK, Entity LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private void DGPKCGALGFD(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	private void EKBHDPJPKLP(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct JEHJBIOPOMD : NBKDCFKNMHI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public LEEGNLJBNDK FGCCDFCMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x6C7000", Offset = "0x6C6200", VA = "0x1806C7000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LEEGNLJBNDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x72C4E0", Offset = "0x72B6E0", VA = "0x18072C4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[LOJIIDJFKAI(typeof(ObjectEmbodimentService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.Embodiment)]
	internal sealed class ObjectEmbodimentService : JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[IMNMHIBEIDL]
		private BMGHPMCGENG BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[IMNMHIBEIDL]
		private LEPGAPILAAM AAKCANBNOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[IMNMHIBEIDL]
		private TransformOwnershipPhase KGOFCGFBHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<IOLFAAOECPP, MIDGCDECPDI> ADKPFJIMBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private IKGNJCJKDHP CPMCPOGIHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2A76380", Offset = "0x2A75580", VA = "0x182A76380")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int GHENHLBAJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2A762D0", Offset = "0x2A754D0", VA = "0x182A762D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int PIOCBEALFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2A76230", Offset = "0x2A75430", VA = "0x182A76230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1385450", Offset = "0x1384650", VA = "0x181385450", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A80", Offset = "0x2A77C80", VA = "0x182A78A80", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2A77350", Offset = "0x2A76550", VA = "0x182A77350")]
		public void MEMDMDPLAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2A76C90", Offset = "0x2A75E90", VA = "0x182A76C90", Slot = "6")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2A75A70", Offset = "0x2A74C70", VA = "0x182A75A70", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2A76BB0", Offset = "0x2A75DB0", VA = "0x182A76BB0")]
		public int ILPEILOOILG(SceneTag BGCBBDJLHHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2A77310", Offset = "0x2A76510", VA = "0x182A77310")]
		public int LHLAAECBKCO(SceneTag BGCBBDJLHHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2A75E70", Offset = "0x2A75070", VA = "0x182A75E70")]
		public bool FDHNAHEDHFO(Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG, out NativeList<Entity> EBGCJPGCLKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2A77510", Offset = "0x2A76710", VA = "0x182A77510")]
		public bool MJPFOHOOMEJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2A76970", Offset = "0x2A75B70", VA = "0x182A76970")]
		public bool IGNAOPBPCKO(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2A754B0", Offset = "0x2A746B0", VA = "0x182A754B0")]
		public bool CCBOPNINIEJ(Entity OAOGLFGGBPI, out MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2A75400", Offset = "0x2A74600", VA = "0x182A75400")]
		private bool CCBOPNINIEJ(Transform LJLOGOIJMEM, out MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2A75520", Offset = "0x2A74720", VA = "0x182A75520")]
		private void CKKJBILLNPP(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2A77330", Offset = "0x2A76530", VA = "0x182A77330")]
		private bool LOPKHLFIMAA(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2A770C0", Offset = "0x2A762C0", VA = "0x182A770C0")]
		public void KJDPCLCGNLB(IOLFAAOECPP IOCKLNNJMIA, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2A77870", Offset = "0x2A76A70", VA = "0x182A77870")]
		public bool NKLGPADCMJB(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2A77E30", Offset = "0x2A77030", VA = "0x182A77E30")]
		public bool ODOOOIFCONJ(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2A78570", Offset = "0x2A77770", VA = "0x182A78570")]
		public bool ODOOOIFCONJ(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2A78550", Offset = "0x2A77750", VA = "0x182A78550")]
		public bool ODOOOIFCONJ(MIDGCDECPDI CHOBEAJIPKF, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2A78680", Offset = "0x2A77880", VA = "0x182A78680")]
		public bool OONHDEIOEPE(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A50", Offset = "0x2A77C50", VA = "0x182A78A50")]
		public bool OONHDEIOEPE(MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2A781E0", Offset = "0x2A773E0", VA = "0x182A781E0")]
		public bool ODOOOIFCONJ(MIDGCDECPDI ALLKDINDGEN, [Optional] object AJDBKDIMOHA, bool BIOMHNNIJHG = false, bool FOGEFHPIHNA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2A773A0", Offset = "0x2A765A0", VA = "0x182A773A0")]
		public Transform MHIJHDGLGCN(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2A74D90", Offset = "0x2A73F90", VA = "0x182A74D90")]
		public bool AAMKJDPJALI(Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2A760C0", Offset = "0x2A752C0", VA = "0x182A760C0")]
		public MIDGCDECPDI GAKEHOENCMF(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2A766E0", Offset = "0x2A758E0", VA = "0x182A766E0")]
		public void HPILCJEPAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2A75680", Offset = "0x2A74880", VA = "0x182A75680")]
		public void DIGHECKADBO(SceneTag BGCBBDJLHHN, bool AEODMGJBILG, global::CEFPLBEJFHF<int> MFIMBIBHAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2A74E60", Offset = "0x2A74060", VA = "0x182A74E60")]
		private void BALDGCOKCIP(Entity OAOGLFGGBPI, bool AEODMGJBILG, bool HDPMMHOPKMN, global::CEFPLBEJFHF<int> MFIMBIBHAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2A75360", Offset = "0x2A74560", VA = "0x182A75360")]
		private void CBHFAPAMCMN(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN, bool AEODMGJBILG, bool HDPMMHOPKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2A772C0", Offset = "0x2A764C0", VA = "0x182A772C0")]
		public MIDGCDECPDI KKELGPPIGEL(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2A761B0", Offset = "0x2A753B0", VA = "0x182A761B0")]
		public bool GBKFKBLGCCA(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2A76250", Offset = "0x2A75450", VA = "0x182A76250")]
		public bool GJIPPEJJKHO(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2A77050", Offset = "0x2A76250", VA = "0x182A77050")]
		public bool KFEOGLGLLAC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2A77C10", Offset = "0x2A76E10", VA = "0x182A77C10")]
		public bool NMIIAKEHEIC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2A77C80", Offset = "0x2A76E80", VA = "0x182A77C80")]
		public bool NMIIAKEHEIC(LEEGNLJBNDK KJNCDAGJAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void AEEKNBJJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2A785C0", Offset = "0x2A777C0", VA = "0x182A785C0")]
		private void OKHNABDHGEK(bool IKCFBOJHGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2A762F0", Offset = "0x2A754F0", VA = "0x182A762F0")]
		private bool HKIBCGAFAAK(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2A75BA0", Offset = "0x2A74DA0", VA = "0x182A75BA0")]
		private MIDGCDECPDI ECHLNEBHONI(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2A763D0", Offset = "0x2A755D0", VA = "0x182A763D0")]
		private MIDGCDECPDI HNDCDCLNOLO(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2A76990", Offset = "0x2A75B90", VA = "0x182A76990")]
		private (Vector3, Quaternion, Vector3) ILCEDDNABAH(Entity OAOGLFGGBPI)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2A77760", Offset = "0x2A76960", VA = "0x182A77760")]
		private void NHPCHBFEIEE(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2A76BD0", Offset = "0x2A75DD0", VA = "0x182A76BD0")]
		private void IMLHCOJBHIE(NFJEDPPAJMK OOGHONKGHEE, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2A765C0", Offset = "0x2A757C0", VA = "0x182A765C0")]
		private void HPCFAJMLJKK(MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2A75C40", Offset = "0x2A74E40", VA = "0x182A75C40")]
		private void EPMJCFJMIDK(MIDGCDECPDI ALLKDINDGEN, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2A76DE0", Offset = "0x2A75FE0", VA = "0x182A76DE0")]
		private void JEOIBCAGNHI(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2A77D50", Offset = "0x2A76F50", VA = "0x182A77D50")]
		private void NONEAMGMGPC(Entity OAOGLFGGBPI, Transform LJLOGOIJMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2A77020", Offset = "0x2A76220", VA = "0x182A77020")]
		private NFJEDPPAJMK JGKFJOJMEAP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2A78C00", Offset = "0x2A77E00", VA = "0x182A78C00")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2A755B0", Offset = "0x2A747B0", VA = "0x182A755B0")]
		[CompilerGenerated]
		private void DGLNCFCKDPI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class BPHLIJCECDN
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2C458F0", Offset = "0x2C44AF0", VA = "0x182C458F0")]
	public static MIDGCDECPDI GAKEHOENCMF(this ObjectEmbodimentService CCJAOIAIHHP, NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[LOJIIDJFKAI(typeof(ObjectLifecycleService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class ObjectLifecycleService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private FNCOHMIDMDB OKPOBPNCFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects PKFEILEKHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2A79D00", Offset = "0x2A78F00", VA = "0x182A79D00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, MFOBNBKALPH> AGJONJAHFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2A797E0", Offset = "0x2A789E0", VA = "0x182A797E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2A79FB0", Offset = "0x2A791B0", VA = "0x182A79FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> BBDEMMJFNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2A79AC0", Offset = "0x2A78CC0", VA = "0x182A79AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A050", Offset = "0x2A79250", VA = "0x182A7A050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A150", Offset = "0x2A79350", VA = "0x182A7A150", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xF8F040", Offset = "0xF8E240", VA = "0x180F8F040", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2A79B60", Offset = "0x2A78D60", VA = "0x182A79B60")]
		public bool EOKNMHALCBJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2A79BE0", Offset = "0x2A78DE0", VA = "0x182A79BE0")]
		internal void FFOJHBEMCDE(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2A79A80", Offset = "0x2A78C80", VA = "0x182A79A80")]
		public void COLIANFIIAH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2A79340", Offset = "0x2A78540", VA = "0x182A79340")]
		public void ACJDPHMJEOL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2A79C40", Offset = "0x2A78E40", VA = "0x182A79C40")]
		private bool HJHIJFEGLNE(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2A79390", Offset = "0x2A78590", VA = "0x182A79390")]
		public void ACJHDFNHANL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2A79590", Offset = "0x2A78790", VA = "0x182A79590")]
		private bool BFEHPHCAIKJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2A79750", Offset = "0x2A78950", VA = "0x182A79750")]
		public void BNAAMBOKMGH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A0F0", Offset = "0x2A792F0", VA = "0x182A7A0F0")]
		private void OLOCILILAEH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2A79D50", Offset = "0x2A78F50", VA = "0x182A79D50")]
		private void IALJJAFJICK(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A230", Offset = "0x2A79430", VA = "0x182A7A230")]
		public void PPCDKKLHCJP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private void KDAPAIFDOMM(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2A79880", Offset = "0x2A78A80", VA = "0x182A79880")]
		private void CDGNPPELDIP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(ObjectPrefabs), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Prefabs)]
	internal class ObjectPrefabs : JDENCAMHKCA, DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class JKLNNKPCDFA : IEnumerable<(PCLEKMKAJBM, MFOBNBKALPH)>, IEnumerable, IEnumerator<(PCLEKMKAJBM, MFOBNBKALPH)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (PCLEKMKAJBM primitiveType, MFOBNBKALPH prefabType) <>2__current;

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
			private (PCLEKMKAJBM, MFOBNBKALPH) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x264BC30", Offset = "0x264AE30", VA = "0x18264BC30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((PCLEKMKAJBM, MFOBNBKALPH));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x41C7F30", Offset = "0x41C7130", VA = "0x1841C7F30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x41C5EE0", Offset = "0x41C50E0", VA = "0x1841C5EE0")]
			[DebuggerHidden]
			public JKLNNKPCDFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x41C7D50", Offset = "0x41C6F50", VA = "0x1841C7D50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x41C7EF0", Offset = "0x41C70F0", VA = "0x1841C7EF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x41C7E50", Offset = "0x41C7050", VA = "0x1841C7E50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(PCLEKMKAJBM, MFOBNBKALPH)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x41C7E50", Offset = "0x41C7050", VA = "0x1841C7E50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<MFOBNBKALPH, Entity> DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<MFOBNBKALPH, EntityArchetype> FIFGIFGGGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<PCLEKMKAJBM, MFOBNBKALPH> JLBJOGJGCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<MJPOECHPGHN, MFOBNBKALPH> KMOAAIIFGOJ;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D9E0", Offset = "0x2A7CBE0", VA = "0x182A7D9E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D270", Offset = "0x2A7C470", VA = "0x182A7D270")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DD50", Offset = "0x2A7CF50", VA = "0x182A7DD50", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CA90", Offset = "0x2A7BC90", VA = "0x182A7CA90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DCF0", Offset = "0x2A7CEF0", VA = "0x182A7DCF0")]
		internal IEnumerable<Type> PBDCKNMJICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D290", Offset = "0x2A7C490", VA = "0x182A7D290")]
		internal GEBEJCMGDEA HPILECLMCEJ(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D980", Offset = "0x2A7CB80", VA = "0x182A7D980")]
		public EntityArchetype KFGAPPIDKBA(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DA30", Offset = "0x2A7CC30", VA = "0x182A7DA30")]
		public NativeHashMap<int, EntityArchetype> NJLEFBMNPHN(Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DBB0", Offset = "0x2A7CDB0", VA = "0x182A7DBB0")]
		public bool NJLJEKPONCN(MFOBNBKALPH JDHIJCJKFOO, out EntityArchetype CAABDGCKDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C9D0", Offset = "0x2A7BBD0", VA = "0x182A7C9D0", Slot = "4")]
		[IteratorStateMachine(typeof(JKLNNKPCDFA))]
		public IEnumerable<(PCLEKMKAJBM, MFOBNBKALPH)> BGIOLCAOFIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C8C0", Offset = "0x2A7BAC0", VA = "0x182A7C8C0")]
		public Entity AALANCDKDJF(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D0A0", Offset = "0x2A7C2A0", VA = "0x182A7D0A0")]
		public MFOBNBKALPH GBKNIBKIHOC(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D040", Offset = "0x2A7C240", VA = "0x182A7D040")]
		public MFOBNBKALPH GBKNIBKIHOC(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D100", Offset = "0x2A7C300", VA = "0x182A7D100")]
		public NativeHashMap<int, Entity> GLCKPKLCMFO(Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CA40", Offset = "0x2A7BC40", VA = "0x182A7CA40")]
		public IEnumerable<MFOBNBKALPH> BNBJLMLDFAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DC20", Offset = "0x2A7CE20", VA = "0x182A7DC20")]
		public Entity ODADLIIMGLG(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DC80", Offset = "0x2A7CE80", VA = "0x182A7DC80")]
		public bool OHLPFOOMIAD(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D300", Offset = "0x2A7C500", VA = "0x182A7D300")]
		private void IIFDKJCCILD(GEBEJCMGDEA MEOOBDIBHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D750", Offset = "0x2A7C950", VA = "0x182A7D750")]
		internal void IPOKHOEPCKC(MFOBNBKALPH JDHIJCJKFOO, ComponentTypeList LPPKOMBLCMM, IKAMNEMAICF FBGDHNOKHCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CEE0", Offset = "0x2A7C0E0", VA = "0x182A7CEE0")]
		private void FADOHIPLDLH(MFOBNBKALPH JDHIJCJKFOO, ComponentTypeList AOONNNAPHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CDC0", Offset = "0x2A7BFC0", VA = "0x182A7CDC0")]
		internal Entity EHONOAPJBJB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E180", Offset = "0x2A7D380", VA = "0x182A7E180")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum ENELKKCPMCO
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface HJLICMFNEDM
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class DOMOJAJMPKI : LJBFLMONAFL, DOBDGKNHJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly DFJNBONFIPE BOPDNIJLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly ENELKKCPMCO KGOFCGFBHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<CFMAIOKLGLK> MHDMHLBIKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, GBDBBLLJIJK> IMPHGFLBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> HJOJCNIDHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle IHONAKKHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle MOLCALNBEFE;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World CCENIHIJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2C58660", Offset = "0x2C57860", VA = "0x182C58660", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private AAGANFGPMAE KOAGAJEABFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2C57A50", Offset = "0x2C56C50", VA = "0x182C57A50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private EOHNGDMHPEJ IIHPMNGKEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD40", Offset = "0x6DAF40", VA = "0x1806DBD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, GBDBBLLJIJK> FHAGEIBBBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x6E8030", Offset = "0x6E7230", VA = "0x1806E8030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, GBDBBLLJIJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle FEOBIEADMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x115A910", Offset = "0x1159B10", VA = "0x18115A910", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x115A920", Offset = "0x1159B20", VA = "0x18115A920", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool GEDIHOEPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2C57A40", Offset = "0x2C56C40", VA = "0x182C57A40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World NKCLDFNMCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2C57F60", Offset = "0x2C57160", VA = "0x182C57F60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2C587B0", Offset = "0x2C579B0", VA = "0x182C587B0")]
	public DOMOJAJMPKI(DFJNBONFIPE BOPDNIJLBEO, ENELKKCPMCO KGOFCGFBHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2C57A70", Offset = "0x2C56C70", VA = "0x182C57A70", Slot = "11")]
	private void BCDKPODILND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2C582B0", Offset = "0x2C574B0", VA = "0x182C582B0", Slot = "10")]
	private bool JCLHKBNALMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2C586C0", Offset = "0x2C578C0", VA = "0x182C586C0", Slot = "12")]
	private void PCHOPONBCLI(ComponentType HBILNHOEIJP, in CFMAIOKLGLK HBJHPADKKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2C583D0", Offset = "0x2C575D0", VA = "0x182C583D0", Slot = "13")]
	private bool KKMPBMKGGLN(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2C57AC0", Offset = "0x2C56CC0", VA = "0x182C57AC0", Slot = "16")]
	private bool BLKPKHFIANF(out NativeArray<int> KJCOLFIBADD, Allocator OPBLDCCKGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2C580F0", Offset = "0x2C572F0", VA = "0x182C580F0", Slot = "17")]
	private bool HLNECFBCDML(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP, out OMCDLMPOANH AJMEBMGKGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2C57FC0", Offset = "0x2C571C0", VA = "0x182C57FC0", Slot = "18")]
	private bool HLNECFBCDML(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2C57950", Offset = "0x2C56B50", VA = "0x182C57950", Slot = "19")]
	private CFMAIOKLGLK ADFLFIFJLON(ComponentType HBILNHOEIJP)
	{
		return default(CFMAIOKLGLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2C57A80", Offset = "0x2C56C80", VA = "0x182C57A80", Slot = "20")]
	private JDPCKAFOGOO BHHPMAEPCHI()
	{
		return default(JDPCKAFOGOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2C58620", Offset = "0x2C57820", VA = "0x182C58620", Slot = "21")]
	private void OIEKNDCGEMB(JobHandle GNEAPAJLKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2C57CF0", Offset = "0x2C56EF0", VA = "0x182C57CF0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2C58400", Offset = "0x2C57600", VA = "0x182C58400")]
	private bool MLIBGBPHPGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2C57B60", Offset = "0x2C56D60", VA = "0x182C57B60")]
	private int DPIOANEGEPK()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class DFJNBONFIPE : HJLICMFNEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public AAGANFGPMAE CGKHLCEONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public EOHNGDMHPEJ MDIDNDENAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public KDPNKMKDLAM IEHEJIODGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2C56490", Offset = "0x2C55690", VA = "0x182C56490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public DFJNBONFIPE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(PropertyDiffStateService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	internal class PropertyDiffStateService : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct EBJJPCPKPFB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly ENELKKCPMCO KNOGJLNJJJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService IAFMOECNDHE;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x41C36A0", Offset = "0x41C28A0", VA = "0x1841C36A0")]
			public EBJJPCPKPFB(PropertyDiffStateService IAFMOECNDHE, ENELKKCPMCO IPLOBCPFMCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x41C3680", Offset = "0x41C2880", VA = "0x1841C3680", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly DFJNBONFIPE BOPDNIJLBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly DOMOJAJMPKI[] OJGGGDPBKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private ENELKKCPMCO FCCKCOKJADL;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public HJLICMFNEDM DPCGFEFKGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public DOBDGKNHJII HNBBMNAKLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A620", Offset = "0x2A89820", VA = "0x182A8A620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public LJBFLMONAFL LJEMNDFDFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2A8A620", Offset = "0x2A89820", VA = "0x182A8A620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x894EA0", Offset = "0x8940A0", VA = "0x180894EA0")]
		public DOBDGKNHJII AJLHDKPEJGO(ENELKKCPMCO KGOFCGFBHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x894EA0", Offset = "0x8940A0", VA = "0x180894EA0")]
		public LJBFLMONAFL LHEPNBENOIH(ENELKKCPMCO KGOFCGFBHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A970", Offset = "0x2A89B70", VA = "0x182A8A970", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A6E0", Offset = "0x2A898E0", VA = "0x182A8A6E0", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A660", Offset = "0x2A89860", VA = "0x182A8A660")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A540", Offset = "0x2A89740", VA = "0x182A8A540", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A6C0", Offset = "0x2A898C0", VA = "0x182A8A6C0")]
		public EBJJPCPKPFB ILNJGBLAJKE(ENELKKCPMCO KGOFCGFBHNK)
		{
			return default(EBJJPCPKPFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AA40", Offset = "0x2A89C40", VA = "0x182A8AA40")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	[LOJIIDJFKAI(typeof(SceneService), new string[] { })]
	internal class SceneService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag KOEGNMNIGIO;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string CNAIAMCOPKM = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string EBJMPEEPGMD = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[IMNMHIBEIDL]
		private LFIBHLPOILP PPDJEICCKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[IMNMHIBEIDL]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[IMNMHIBEIDL]
		private SingletonComponentService LAMNHLDLCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[IMNMHIBEIDL]
		private PhotonInstanceCleanupService KAHBCNFMGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery DBCPKCDAFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery KCIOJHLJKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery ALHCMPHKMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity PJJDHGFALMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool HDOCPFIDKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2CB9E50", Offset = "0x2CB9050", VA = "0x182CB9E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> CIAJCEICPGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x16F3EA0", Offset = "0x16F30A0", VA = "0x1816F3EA0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x22BCB50", Offset = "0x22BBD50", VA = "0x1822BCB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity OPKPBGJKPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2CBA5E0", Offset = "0x2CB97E0", VA = "0x182CBA5E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag EDCHEJMNICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2CB9E00", Offset = "0x2CB9000", VA = "0x182CB9E00")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity MCGKDACEJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2CB9E00", Offset = "0x2CB9000", VA = "0x182CB9E00")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2CB9960", Offset = "0x2CB8B60", VA = "0x182CB9960")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2CBA590", Offset = "0x2CB9790", VA = "0x182CBA590")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB1F0", Offset = "0x2CBA3F0", VA = "0x182CBB1F0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9F10", Offset = "0x2CB9110", VA = "0x182CB9F10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA3A0", Offset = "0x2CB95A0", VA = "0x182CBA3A0")]
		public void GCBIKBKOJJD(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA7E0", Offset = "0x2CB99E0", VA = "0x182CBA7E0")]
		public NativeArray<Entity> JCEPBJLINDJ(Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9860", Offset = "0x2CB8A60", VA = "0x182CB9860")]
		public void AEGDDAJIMDG(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB170", Offset = "0x2CBA370", VA = "0x182CBB170")]
		public Entity ODNGLJOIJNB(string IGHJIHNAPBA = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBABE0", Offset = "0x2CB9DE0", VA = "0x182CBABE0")]
		public void LJFEMNLKDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA090", Offset = "0x2CB9290", VA = "0x182CBA090")]
		public void FFNOCNODJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB99F0", Offset = "0x2CB8BF0", VA = "0x182CB99F0")]
		public void BMNNIDHMOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA7D0", Offset = "0x2CB99D0", VA = "0x182CBA7D0")]
		public void JBPOOHIPEGP(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB4A0", Offset = "0x2CBA6A0", VA = "0x182CBB4A0")]
		public bool PLOCBNEANOB(Entity BGCBBDJLHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA8C0", Offset = "0x2CB9AC0", VA = "0x182CBA8C0")]
		public void JIINOPBNCJF(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA0B0", Offset = "0x2CB92B0", VA = "0x182CBA0B0")]
		public string FGHKOGHBCLM(Entity BGCBBDJLHHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		public void COENLNNOBCH(Entity BGCBBDJLHHN, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2CB99D0", Offset = "0x2CB8BD0", VA = "0x182CB99D0")]
		public bool AKECABMEFIP(string IGHJIHNAPBA, out Entity BGCBBDJLHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA930", Offset = "0x2CB9B30", VA = "0x182CBA930")]
		public void KPDCBKAGLIM(Entity BGCBBDJLHHN, bool BNAKOLIBLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA1C0", Offset = "0x2CB93C0", VA = "0x182CBA1C0")]
		public void GBOIINIDEOO(Entity OAOGLFGGBPI, bool JHECLPHKCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA240", Offset = "0x2CB9440", VA = "0x182CBA240")]
		public void GBOIINIDEOO(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA2B0", Offset = "0x2CB94B0", VA = "0x182CBA2B0")]
		public void GBOIINIDEOO(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2CBADE0", Offset = "0x2CB9FE0", VA = "0x182CBADE0")]
		public void MLLPPMLEDOI(Entity OAOGLFGGBPI, Entity BGCBBDJLHHN, bool JHECLPHKCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBAC00", Offset = "0x2CB9E00", VA = "0x182CBAC00")]
		public void MLLPPMLEDOI(NativeArray<Entity> GNGEEFEGDCP, Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB010", Offset = "0x2CBA210", VA = "0x182CBB010")]
		public void MLLPPMLEDOI(EntityQuery JLMGAJOHFKO, Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA3E0", Offset = "0x2CB95E0", VA = "0x182CBA3E0")]
		private void HJAIIKEEICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9EA0", Offset = "0x2CB90A0", VA = "0x182CB9EA0")]
		private void DMAKAEHGJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA5E0", Offset = "0x2CB97E0", VA = "0x182CBA5E0")]
		private Entity HODELEFOMOF()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA810", Offset = "0x2CB9A10", VA = "0x182CBA810")]
		private void JHMAGIAALJF(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9D30", Offset = "0x2CB8F30", VA = "0x182CB9D30")]
		private void BNOIFHEPNDO(EntityQuery JGBCHPFJOAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9A50", Offset = "0x2CB8C50", VA = "0x182CB9A50")]
		private void BNOIFHEPNDO(NativeArray<Entity> KPLEIKICILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB0C0", Offset = "0x2CBA2C0", VA = "0x182CBB0C0")]
		private void NIHNKGNIJGP(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9F60", Offset = "0x2CB9160", VA = "0x182CB9F60")]
		private void EMIFGHKMNKM(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2CBAA40", Offset = "0x2CB9C40", VA = "0x182CBAA40")]
		private void LFAPBPHJOBF(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9ED0", Offset = "0x2CB90D0", VA = "0x182CB9ED0")]
		private void DNJGBLIDLMP(SceneTag LCNLGBDLFBH, global::CEFPLBEJFHF<int> MFIMBIBHAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB310", Offset = "0x2CBA510", VA = "0x182CBB310")]
		private void PLLDBBAJIEP(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA730", Offset = "0x2CB9930", VA = "0x182CBA730")]
		private void IDEDJPFOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x36ACB50", Offset = "0x36ABD50", VA = "0x1836ACB50")]
		private void ANICKOGBLOA<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BAFHNOAMAJM(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA8D0", Offset = "0x2CB9AD0", VA = "0x182CBA8D0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void KNECCGIGHGG(EntityQuery JLMGAJOHFKO, string IGHJIHNAPBA, SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBABB0", Offset = "0x2CB9DB0", VA = "0x182CBABB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LFLEOFFKJIO(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CDELGNLILHL(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[KFMPJDNIPEO(JHCKAKNDFFP.PhotonRoom)]
	[LOJIIDJFKAI(typeof(GKJCKFLLFKJ), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	internal class UnitySceneService : DPDCPMNGBKH, GKJCKFLLFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[IMNMHIBEIDL]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> CDLGAINENNB;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2CC9120", Offset = "0x2CC8320", VA = "0x182CC9120")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2CC93D0", Offset = "0x2CC85D0", VA = "0x182CC93D0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8FB0", Offset = "0x2CC81B0", VA = "0x182CC8FB0", Slot = "5")]
		public void GCBIKBKOJJD(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2CC91E0", Offset = "0x2CC83E0", VA = "0x182CC91E0", Slot = "6")]
		public bool OECKGMOBFFL(NFJEDPPAJMK OOGHONKGHEE, Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9170", Offset = "0x2CC8370", VA = "0x182CC9170")]
		private bool ILJBFEHHAOO(Scene BGCBBDJLHHN, out Entity DBINELJNBGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9460", Offset = "0x2CC8660", VA = "0x182CC9460")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	[LOJIIDJFKAI(typeof(SingletonComponentService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class SingletonComponentService : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity OAOGLFGGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList AOONNNAPHDO;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2CC0420", Offset = "0x2CBF620", VA = "0x182CC0420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity COBGFIFKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2CBFF30", Offset = "0x2CBF130", VA = "0x182CBFF30")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x36AE510", Offset = "0x36AD710", VA = "0x1836AE510")]
		public T JLPNHBINJFC<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x36AE440", Offset = "0x36AD640", VA = "0x1836AE440")]
		public void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0430", Offset = "0x2CBF630", VA = "0x182CC0430", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBFF80", Offset = "0x2CBF180", VA = "0x182CBFF80", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBFF80", Offset = "0x2CBF180", VA = "0x182CBFF80")]
		private void PNIDGLKCLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBFC60", Offset = "0x2CBEE60", VA = "0x182CBFC60", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2CC0120", Offset = "0x2CBF320", VA = "0x182CC0120")]
		private ComponentTypeList KIEBILDCJFO()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void FLFGKGJNFOF(int OCCKKIPCFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
		private static void CGLNAPDCPBD(Type DDJDPMGLPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2CBFBC0", Offset = "0x2CBEDC0", VA = "0x182CBFBC0")]
		private static void AINDOEJCEMC(Type DDJDPMGLPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct EOFMIIIMDOL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(LEPGAPILAAM), new string[] { })]
internal sealed class LEPGAPILAAM : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::IMJKKCAJKJE<KKCCBJBJBOD, Entity> HNLGNIOKMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::GGEJOAKONHH<FKACANNGOBE> MNDJFDEMNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::GGEJOAKONHH<OHNEHFENPHJ> JHCKKDMPKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::GGEJOAKONHH<JIGPGFGCLCJ> PNCGNDEAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::GGEJOAKONHH<NJONDCMECFD> BJHPEMPKHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::GGEJOAKONHH<JEHJBIOPOMD> CCJAOIAIHHP;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::PMFGMAIPJGC<Entity> APJLAJFFDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public AKGLNOALMDP BCNGECMJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AKGLNOALMDP KNAJBFDLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public AKGLNOALMDP KAKLNDMBCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AKGLNOALMDP JKIBGGBBOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public AKGLNOALMDP CGOGCINFOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6CE580", Offset = "0x6CD780", VA = "0x1806CE580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E4A0", Offset = "0x2A6D6A0", VA = "0x182A6E4A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E4F0", Offset = "0x2A6D6F0", VA = "0x182A6E4F0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E3B0", Offset = "0x2A6D5B0", VA = "0x182A6E3B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x1D688D0", Offset = "0x1D67AD0", VA = "0x181D688D0")]
	private void HBGEMGCKMHE<T>(ref global::GGEJOAKONHH<T> BAMMKKCEACG) where T : struct, NBKDCFKNMHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x1D688D0", Offset = "0x1D67AD0", VA = "0x181D688D0")]
	private void HBGEMGCKMHE<TC, TV>(ref global::IMJKKCAJKJE<TC, TV> BAMMKKCEACG) where TC : struct, NBKDCFKNMHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public LEPGAPILAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[LOJIIDJFKAI(typeof(IMPKDEPFPDI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class IMPKDEPFPDI : LFPMKPLIAAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private HNJLOOJCIKA JLLNJFMLFDB;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public HNJLOOJCIKA CEGOKBJBFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1CD6CC0", Offset = "0x1CD5EC0", VA = "0x181CD6CC0")]
		get
		{
			return default(HNJLOOJCIKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x31AE690", Offset = "0x31AD890", VA = "0x1831AE690", Slot = "4")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x31AE680", Offset = "0x31AD880", VA = "0x1831AE680", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IMPKDEPFPDI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(TransformOwnershipPhase), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum GJKDBKKDDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct CDMMKMABJNA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private GJKDBKKDDNJ CHIGJKKLELG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase GPFONCECPBK;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x41C1EE0", Offset = "0x41C10E0", VA = "0x1841C1EE0")]
			public CDMMKMABJNA(TransformOwnershipPhase GPFONCECPBK, GJKDBKKDDNJ KGOFCGFBHNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x41C1EC0", Offset = "0x41C10C0", VA = "0x1841C1EC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public GJKDBKKDDNJ KGOFCGFBHNK;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public GJKDBKKDDNJ BLOCIPJCABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
			get
			{
				return default(GJKDBKKDDNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E7130", VA = "0x1806E7F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool LMEAOFLIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB612B0", Offset = "0xB604B0", VA = "0x180B612B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool DGJJFLPOFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0xF07920", Offset = "0xF06B20", VA = "0x180F07920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3790", Offset = "0x2CC2990", VA = "0x182CC3790")]
		public CDMMKMABJNA FABELCJDDFL()
		{
			return default(CDMMKMABJNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC3760", Offset = "0x2CC2960", VA = "0x182CC3760")]
		public CDMMKMABJNA EFIPPAELNKB()
		{
			return default(CDMMKMABJNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[LOJIIDJFKAI(typeof(PEJNHEGAEGK), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Circuits)]
	public class CircuitsService : DPDCPMNGBKH, PEJNHEGAEGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[IMNMHIBEIDL]
		private NHBHMJGOMNH FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B5A0", Offset = "0x2C4A7A0", VA = "0x182C4B5A0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AF40", Offset = "0x2C4A140", VA = "0x182C4AF40", Slot = "5")]
		public bool HDOAAKFDILL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ABC0", Offset = "0x2C49DC0", VA = "0x182C4ABC0", Slot = "7")]
		public bool ELMKAECJLJO(NFJEDPPAJMK OOGHONKGHEE, out Guid GADNLPCKAGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B040", Offset = "0x2C4A240", VA = "0x182C4B040", Slot = "8")]
		public Guid ICJNFLKOOME(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A3E0", Offset = "0x2C495E0", VA = "0x182C4A3E0", Slot = "9")]
		public void ALDIAANMIGE(NFJEDPPAJMK OOGHONKGHEE, Guid GADNLPCKAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A6A0", Offset = "0x2C498A0", VA = "0x182C4A6A0", Slot = "10")]
		public bool BODIKJHCJGK(NFJEDPPAJMK OOGHONKGHEE, out Guid ICBBOKLLMHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B2C0", Offset = "0x2C4A4C0", VA = "0x182C4B2C0", Slot = "11")]
		public Guid KADHPPLAKGK(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A180", Offset = "0x2C49380", VA = "0x182C4A180", Slot = "12")]
		public void ALAKLCNJDKI(NFJEDPPAJMK OOGHONKGHEE, Guid ICBBOKLLMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2C4AD60", Offset = "0x2C49F60", VA = "0x182C4AD60", Slot = "13")]
		public bool GBAMJPEPJPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A790", Offset = "0x2C49990", VA = "0x182C4A790", Slot = "14")]
		public void DJGGAIHIALF(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A800", Offset = "0x2C49A00", VA = "0x182C4A800", Slot = "15")]
		public void DJPJCHIHIHA(NFJEDPPAJMK MOOHJICILGA, NFJEDPPAJMK GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B150", Offset = "0x2C4A350", VA = "0x182C4B150")]
		private void IKMGMOMNLMB(CEPMAFNDCOM KECKFACHJCH, NFJEDPPAJMK GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ADB0", Offset = "0x2C49FB0", VA = "0x182C4ADB0")]
		private void GNKBINGBKOC(CEPMAFNDCOM KECKFACHJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B3D0", Offset = "0x2C4A5D0", VA = "0x182C4B3D0")]
		private bool LOFHHIGCAFE(JMAKJOJHHNF ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2C4ACB0", Offset = "0x2C49EB0", VA = "0x182C4ACB0")]
		private bool FGMGCOEEBCJ(JMAKJOJHHNF ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A640", Offset = "0x2C49840", VA = "0x182C4A640", Slot = "6")]
		public bool ANLDDCHAFPJ(NFJEDPPAJMK ONBAMHPEIDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[LOJIIDJFKAI(typeof(KGOCHOHEAHM), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	internal class ConnectableService : KGOCHOHEAHM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class CCDKJCNOEJD : IEnumerable<NFJEDPPAJMK>, IEnumerable, IEnumerator<NFJEDPPAJMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private NFJEDPPAJMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private NFJEDPPAJMK localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public NFJEDPPAJMK <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private NFJEDPPAJMK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NFJEDPPAJMK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2CB4120", Offset = "0x2CB3320", VA = "0x182CB4120", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E120", VA = "0x18096EF20")]
			[DebuggerHidden]
			public CCDKJCNOEJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4170", Offset = "0x2CB3370", VA = "0x182CB4170", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2CB3D30", Offset = "0x2CB2F30", VA = "0x182CB3D30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4240", Offset = "0x2CB3440", VA = "0x182CB4240")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4290", Offset = "0x2CB3490", VA = "0x182CB4290")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2CB40E0", Offset = "0x2CB32E0", VA = "0x182CB40E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4030", Offset = "0x2CB3230", VA = "0x182CB4030", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NFJEDPPAJMK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4030", Offset = "0x2CB3230", VA = "0x182CB4030", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly FADHLPPNOEF PAPLKBBKEMI;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int LKCOAEFNGDO = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int NPDALJINFHP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService FMKAHEFPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::DEHNDDIKMEN<Entity> DJIJEGELBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::DEHNDDIKMEN<float3> GCAODGABHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::DEHNDDIKMEN<quaternion> MMKHPPEPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::DEHNDDIKMEN<Entity> GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::DEHNDDIKMEN<float3> HHJBJKMLAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::DEHNDDIKMEN<quaternion> LLGKGFNMLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> HPGNAABABLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> MEEGCJMDFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery GFIAFOEDDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<GJLAMBHCAMH> JBNONCCLHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x6DD750", Offset = "0x6DC950", VA = "0x1806DD750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA100", Offset = "0x7F9300", VA = "0x1807FA100", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK> GFKLHDGNJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2C50D50", Offset = "0x2C4FF50", VA = "0x182C50D50", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2C50CB0", Offset = "0x2C4FEB0", VA = "0x182C50CB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK> DHDLEAOLJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2C4FD10", Offset = "0x2C4EF10", VA = "0x182C4FD10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2C4F2C0", Offset = "0x2C4E4C0", VA = "0x182C4F2C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK, NFJEDPPAJMK> DLDCLODHMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2C50850", Offset = "0x2C4FA50", VA = "0x182C50850", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2C50E80", Offset = "0x2C50080", VA = "0x182C50E80", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<NFJEDPPAJMK> MGPOCDHHGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2C509A0", Offset = "0x2C4FBA0", VA = "0x182C509A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2C507B0", Offset = "0x2C4F9B0", VA = "0x182C507B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2C50F20", Offset = "0x2C50120", VA = "0x182C50F20", Slot = "25")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FE50", Offset = "0x2C4F050", VA = "0x182C4FE50", Slot = "26")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F720", Offset = "0x2C4E920", VA = "0x182C4F720", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2C50570", Offset = "0x2C4F770", VA = "0x182C50570")]
		private void KADFGIONPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F8D0", Offset = "0x2C4EAD0", VA = "0x182C4F8D0")]
		private void EGBJBKGMION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2C50A40", Offset = "0x2C4FC40", VA = "0x182C50A40")]
		private void NBONHMIBOGB(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F570", Offset = "0x2C4E770", VA = "0x182C4F570")]
		private void CKJADHBEIAJ(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x10A9190", Offset = "0x10A8390", VA = "0x1810A9190", Slot = "14")]
		public NFJEDPPAJMK HFHDDBDJANF(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x14E0EC0", Offset = "0x14E00C0", VA = "0x1814E0EC0", Slot = "15")]
		public Color HHODCMBIBMD(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2C505D0", Offset = "0x2C4F7D0", VA = "0x182C505D0", Slot = "16")]
		public float3 LBPKPMBCHOC(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2C50C00", Offset = "0x2C4FE00", VA = "0x182C50C00", Slot = "17")]
		public bool NCAAKEIGBDM(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK HIAKCAGPFMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2C508F0", Offset = "0x2C4FAF0", VA = "0x182C508F0", Slot = "18")]
		public NFJEDPPAJMK MAAOOGFLOCL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F5D0", Offset = "0x2C4E7D0", VA = "0x182C4F5D0", Slot = "21")]
		public void DHIKDMAALFF(NFJEDPPAJMK OOGHONKGHEE, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FDB0", Offset = "0x2C4EFB0", VA = "0x182C4FDB0", Slot = "23")]
		public float3 INBBNOGKAAD(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2C50DF0", Offset = "0x2C4FFF0", VA = "0x182C50DF0", Slot = "24")]
		public quaternion PBBFFBIJIPF(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FC10", Offset = "0x2C4EE10", VA = "0x182C4FC10", Slot = "28")]
		public RigidTransform GGFDIFPEJGO(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F3F0", Offset = "0x2C4E5F0", VA = "0x182C4F3F0", Slot = "22")]
		public bool CFNHIKHHNDE(NFJEDPPAJMK OOGHONKGHEE, out RigidTransform NKKNNJOLJCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F360", Offset = "0x2C4E560", VA = "0x182C4F360", Slot = "19")]
		[IteratorStateMachine(typeof(CCDKJCNOEJD))]
		public IEnumerable<NFJEDPPAJMK> BIKGLEMMNFO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2C502F0", Offset = "0x2C4F4F0", VA = "0x182C502F0", Slot = "20")]
		public NFJEDPPAJMK JEANBCHEEEA(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FA40", Offset = "0x2C4EC40", VA = "0x182C4FA40", Slot = "29")]
		public void EKEABBPPCMB(ref List<NFJEDPPAJMK> JGJKBMBOGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2C50450", Offset = "0x2C4F650", VA = "0x182C50450")]
		private Entity JEANBCHEEEA(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2C51130", Offset = "0x2C50330", VA = "0x182C51130")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[MBALNPKLAGP(FOFKCKDBIPD.Prefabs)]
	[LOJIIDJFKAI(typeof(ObjectInstantiationService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class ObjectInstantiationService : DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[IMNMHIBEIDL]
		private LNNMLPAEAED HJCGDDIMGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[IMNMHIBEIDL]
		private AAIADCALDOD DMCMGHEPJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[IMNMHIBEIDL]
		private ObjectPrefabs DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[IMNMHIBEIDL]
		private JEIKFBGOBDH HGNDMBCHHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private FNCOHMIDMDB OKPOBPNCFMK;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int APEIIPIDGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2A79000", Offset = "0x2A78200", VA = "0x182A79000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2A79130", Offset = "0x2A78330", VA = "0x182A79130", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2A790B0", Offset = "0x2A782B0", VA = "0x182A790B0")]
		public Entity MMLGPEAALJN(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2A78CD0", Offset = "0x2A77ED0", VA = "0x182A78CD0")]
		public Entity AIPMEHKGCLA(IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2A78DC0", Offset = "0x2A77FC0", VA = "0x182A78DC0")]
		public Entity CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D80", Offset = "0x2A77F80", VA = "0x182A78D80")]
		public Entity CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2A78EA0", Offset = "0x2A780A0", VA = "0x182A78EA0")]
		public Entity GKHEHOAFOIC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2A78E10", Offset = "0x2A78010", VA = "0x182A78E10")]
		public Entity FBCCHMIENCE(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2A79260", Offset = "0x2A78460", VA = "0x182A79260")]
		public Entity PPFCLJJLPDP(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2A78C80", Offset = "0x2A77E80", VA = "0x182A78C80")]
		public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D30", Offset = "0x2A77F30", VA = "0x182A78D30")]
		public IEnumerable<MFOBNBKALPH> BNBJLMLDFAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2A79050", Offset = "0x2A78250", VA = "0x182A79050")]
		public EntityArchetype KFGAPPIDKBA(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2A790D0", Offset = "0x2A782D0", VA = "0x182A790D0")]
		public Entity ODADLIIMGLG(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D80", Offset = "0x2A77F80", VA = "0x182A78D80")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2A78DC0", Offset = "0x2A77FC0", VA = "0x182A78DC0")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2A78EE0", Offset = "0x2A780E0", VA = "0x182A78EE0")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO, IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[LOJIIDJFKAI(typeof(DPHIHEMGLPB), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public sealed class PhysicsSceneColliderService : DPHIHEMGLPB, CCINBDMJAOA, LFPMKPLIAAM, DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string GJDDBOBPNEB = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int AEIMMGBFCML = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int ODPMBKFFPPO = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[IMNMHIBEIDL]
		private BMGHPMCGENG BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] CMLOJLGCMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] BLGLLHOGLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::JBJIOMDHKBO<LPABFJLFMIG, BoxCollider> NIMLMKIGPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene BGCBBDJLHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene CLHGLCCEMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject NMEDHGOIPNG;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int DOCPELJKEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2A84B40", Offset = "0x2A83D40", VA = "0x182A84B40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2A84B80", Offset = "0x2A83D80", VA = "0x182A84B80", Slot = "9")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2A85080", Offset = "0x2A84280", VA = "0x182A85080", Slot = "10")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2A84990", Offset = "0x2A83B90", VA = "0x182A84990", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2A84E00", Offset = "0x2A84000", VA = "0x182A84E00", Slot = "4")]
		public LPABFJLFMIG MKLPHMNOBHM(Entity OAOGLFGGBPI)
		{
			return default(LPABFJLFMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2A845C0", Offset = "0x2A837C0", VA = "0x182A845C0", Slot = "5")]
		public void BNJCPCDOJIO(NativeArray<LPABFJLFMIG> OFODIKGIPOH, NativeArray<PBPGODBNIIF> LIJLBDEDOGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2A84800", Offset = "0x2A83A00", VA = "0x182A84800", Slot = "6")]
		public void CHLKOJEFFEK(LPABFJLFMIG KJNCDAGJAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2A84210", Offset = "0x2A83410", VA = "0x182A84210", Slot = "7")]
		public bool ALBBCNDDHCH(LPABFJLFMIG KJNCDAGJAPF, out Collider NCCADNBJIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2A842B0", Offset = "0x2A834B0", VA = "0x182A842B0")]
		public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2A84AE0", Offset = "0x2A83CE0", VA = "0x182A84AE0")]
		private void HCDHOJHPCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC01660", Offset = "0xC00860", VA = "0x180C01660")]
		private void NIJKJIAFGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2A84A90", Offset = "0x2A83C90", VA = "0x182A84A90")]
		private void GFMJGILOAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x96B120", Offset = "0x96A320", VA = "0x18096B120")]
		private void GPMCBAECEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2A84F60", Offset = "0x2A84160", VA = "0x182A84F60")]
		private BoxCollider NBJHKNOBLDJ(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2A84910", Offset = "0x2A83B10", VA = "0x182A84910")]
		private void DIDDBOIPBNE(BoxCollider FGHDNBPDEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2A85350", Offset = "0x2A84550", VA = "0x182A85350")]
		[Conditional("UNITY_EDITOR")]
		private void PNGINCICOCE(GameObject OOKBNBHDPPG, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2A84020", Offset = "0x2A83220", VA = "0x182A84020")]
		private void AFEDMNAKEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2A84CF0", Offset = "0x2A83EF0", VA = "0x182A84CF0")]
		private void KIIPKADPMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2A85140", Offset = "0x2A84340", VA = "0x182A85140")]
		private void PMGLAOEGFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2A847D0", Offset = "0x2A839D0", VA = "0x182A847D0")]
		private void BOMEGKLLNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2A84B30", Offset = "0x2A83D30", VA = "0x182A84B30")]
		private void HFBNNIAGHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2A848D0", Offset = "0x2A83AD0", VA = "0x182A848D0")]
		private void DDAINOGDGAK(Scene CDPLHKGNILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84F50", Offset = "0x2A84150", VA = "0x182A84F50", Slot = "8")]
		private bool MLFDMKJKJKC(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[LOJIIDJFKAI(typeof(NOGKKJEEDNP), new string[] { })]
public sealed class KKIHIGJMKJD : NOGKKJEEDNP, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct EDNNPEMMHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float JBOJGNNLCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint ICAOKLMLEIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private CCINBDMJAOA IBDIHHBPCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private HFFECIEHFPL JDDODMDBFGF;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x31B5E80", Offset = "0x31B5080", VA = "0x1831B5E80", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x31B58C0", Offset = "0x31B4AC0", VA = "0x1831B58C0")]
	public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, out DHHPKBBIADG GKPLJANNKLP, out Entity BCFGIMKABOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x31B5D80", Offset = "0x31B4F80", VA = "0x1831B5D80")]
	public static bool NAKFBCJOHCD(in Span<DHHPKBBIADG> EGECBAPDDJM, float KMAOMDJLDEN, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x31B5D40", Offset = "0x31B4F40", VA = "0x1831B5D40")]
	public static float BBKOOIFMEPG(float JBOJGNNLCOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public KKIHIGJMKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x31B5D70", Offset = "0x31B4F70", VA = "0x1831B5D70", Slot = "4")]
	private bool JGHLCIBPKME(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, out DHHPKBBIADG GKPLJANNKLP, out Entity BCFGIMKABOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[LOJIIDJFKAI(typeof(HFFECIEHFPL), new string[] { })]
public sealed class EFKCINBKBEK : HFFECIEHFPL, DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct ODMNCNKBNJE : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> GNGEEFEGDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 LJNFAFBDPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 GCHNHAFLLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> HPKKGOGFLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> JMBDAJANIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NGOPFBDABOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> JCMDBEGKCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<DHHPKBBIADG> GLFDAJFJIGJ;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly DHHPKBBIADG CJBBFIGOKFA;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7510", Offset = "0x2CB6710", VA = "0x182CB7510", Slot = "4")]
		public void Execute(int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x2CB78F0", Offset = "0x2CB6AF0", VA = "0x182CB78F0")]
		private static float3 MDPFHAMJCDB(in float4x4 CFPAGFJCEHC, in float3 KHNOBAAPEAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6DE0", Offset = "0x2CB5FE0", VA = "0x182CB6DE0")]
		private static float3 CBENELOOHGA(in float4x4 CFPAGFJCEHC, in float3 ABLKMJLKIKH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x2CB77F0", Offset = "0x2CB69F0", VA = "0x182CB77F0")]
		private static float3 LOJOLHONEGH(in float4x4 CFPAGFJCEHC, in float3 KHNOBAAPEAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6FA0", Offset = "0x2CB61A0", VA = "0x182CB6FA0")]
		private static float3 EEFKFKOEFON(in float4x4 CFPAGFJCEHC, in float3 ABLKMJLKIKH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB71C0", Offset = "0x2CB63C0", VA = "0x182CB71C0")]
		private bool ENEJGLEIJAN(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<Entity> KLKFAEBGKNK, out float3 GKPLJANNKLP, out float3 EMALJDHGDFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB79C0", Offset = "0x2CB6BC0", VA = "0x182CB79C0")]
		public static bool ODPCONDBIEH(in float3 NNMAFADONCE, in float3 JEGCEJIDDCG, in float3 PCAFKIBGCHA, in float3 CBGHIIFGHNB, float BMOLCPJMDGL, float PEAEJAGKHAK, out float EHIBGNPGILO, out float3 BCFFBCFIMGP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A860", Offset = "0x2C59A60", VA = "0x182C5A860", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A370", Offset = "0x2C59570", VA = "0x182C5A370")]
	public void APHFDLGPJFP(in NativeArray<Entity> GNGEEFEGDCP, in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<DHHPKBBIADG> JAJAEFPBINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EFKCINBKBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A850", Offset = "0x2C59A50", VA = "0x182C5A850", Slot = "4")]
	private void GHAMBEBPBBO(in NativeArray<Entity> GNGEEFEGDCP, in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<DHHPKBBIADG> JAJAEFPBINK)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[MBALNPKLAGP(FOFKCKDBIPD.Embodiment)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[IMNMHIBEIDL]
		private LNNMLPAEAED DDFJHGAMHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[IMNMHIBEIDL]
		private AAIADCALDOD GEGLBNPPOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<IOLFAAOECPP, Entity> KDPGFILMLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<IOLFAAOECPP, Entity> IMFBJJCGKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xEACBE0", Offset = "0xEABDE0", VA = "0x180EACBE0")]
			get
			{
				return default(NativeHashMap<IOLFAAOECPP, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint ONEHNENJNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C3A0", Offset = "0x2A7B5A0", VA = "0x182A7C3A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7E40", Offset = "0x8C7040", VA = "0x1808C7E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD0EE80", Offset = "0xD0E080", VA = "0x180D0EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C750", Offset = "0x2A7B950", VA = "0x182A7C750", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C3D0", Offset = "0x2A7B5D0", VA = "0x182A7C3D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C440", Offset = "0x2A7B640", VA = "0x182A7C440")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C1E0", Offset = "0x2A7B3E0", VA = "0x182A7C1E0")]
		public void CECCKMOGCHG(IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C5A0", Offset = "0x2A7B7A0", VA = "0x182A7C5A0")]
		private NFJEDPPAJMK JGKFJOJMEAP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C4C0", Offset = "0x2A7B6C0", VA = "0x182A7C4C0")]
		public NFJEDPPAJMK HELPAPLNDJP(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C630", Offset = "0x2A7B830", VA = "0x182A7C630")]
		public IOLFAAOECPP LPAPEMKKHGI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(IOLFAAOECPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C6C0", Offset = "0x2A7B8C0", VA = "0x182A7C6C0")]
		public void OPEFIPBMOFI(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C5D0", Offset = "0x2A7B7D0", VA = "0x182A7C5D0")]
		public void JGOBGPNIMKB(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C0B0", Offset = "0x2A7B2B0", VA = "0x182A7C0B0")]
		public void AKKFBCFDNPG(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C110", Offset = "0x2A7B310", VA = "0x182A7C110")]
		public void BBAFMAALDCM(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[LOJIIDJFKAI(typeof(PropertyEventCallbacksService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Callbacks)]
	public class PropertyEventCallbacksService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct DHLLIHDPGNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public BFNCOEDHLLM IGAMPECHIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type DDJDPMGLPAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int PCAHMJECHKC;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct MNGNCKDOOAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public DHLLIHDPGNG[] ELCMIPNJFNP;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void BFNCOEDHLLM(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<NMLCFAIOCDK, BFNCOEDHLLM> DEIGJEJHMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, MNGNCKDOOAM> OECLHDKGEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private KHFJEIHOPJL ELCMIPNJFNP;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action BAOBKENPIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8BCC0", Offset = "0x2A8AEC0", VA = "0x182A8BCC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AC60", Offset = "0x2A89E60", VA = "0x182A8AC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action KLJGMEAPGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B180", Offset = "0x2A8A380", VA = "0x182A8B180")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B0E0", Offset = "0x2A8A2E0", VA = "0x182A8B0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B9E0", Offset = "0x2A8ABE0", VA = "0x182A8B9E0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AAE0", Offset = "0x2A89CE0", VA = "0x182A8AAE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89F00", VA = "0x182A8AD00")]
		public void KJDPCLCGNLB(NMLCFAIOCDK MPKOBDPILJB, BFNCOEDHLLM IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AB70", Offset = "0x2A89D70", VA = "0x182A8AB70")]
		public void JHPDLJNMECO(NMLCFAIOCDK MPKOBDPILJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BA30", Offset = "0x2A8AC30", VA = "0x182A8BA30")]
		internal void PEKNGHHEIPM(DOBDGKNHJII BGHMFEPCABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B4A0", Offset = "0x2A8A6A0", VA = "0x182A8B4A0")]
		private void PBPOKAFDLAA(DOBDGKNHJII BGHMFEPCABE, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B220", Offset = "0x2A8A420", VA = "0x182A8B220")]
		private void NOFFIOMBDHO(GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB, DHLLIHDPGNG DKEGLKMJLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AF60", Offset = "0x2A8A160", VA = "0x182A8AF60")]
		private MNGNCKDOOAM NHCAGFAMJCA(GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB)
		{
			return default(MNGNCKDOOAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AE70", Offset = "0x2A8A070", VA = "0x182A8AE70")]
		private DHLLIHDPGNG NFFCKLOAJPK(MNGNCKDOOAM AJMEBMGKGGC, GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB)
		{
			return default(DHLLIHDPGNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BDB0", Offset = "0x2A8AFB0", VA = "0x182A8BDB0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[LOJIIDJFKAI(typeof(NINFMKFKPIG), new string[] { })]
public class EHONOOCHJEC : DPDCPMNGBKH, FPHKGEBJIKC, NINFMKFKPIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class LILAKNKEIJE : IEnumerable<NFJEDPPAJMK>, IEnumerable, IEnumerator<NFJEDPPAJMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private NFJEDPPAJMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public EHONOOCHJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private NFJEDPPAJMK splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public NFJEDPPAJMK <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private NFJEDPPAJMK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x41C9790", Offset = "0x41C8990", VA = "0x1841C9790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E120", VA = "0x18096EF20")]
		[DebuggerHidden]
		public LILAKNKEIJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x41C95E0", Offset = "0x41C87E0", VA = "0x1841C95E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x41C9750", Offset = "0x41C8950", VA = "0x1841C9750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x41C96A0", Offset = "0x41C88A0", VA = "0x1841C96A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NFJEDPPAJMK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x41C96A0", Offset = "0x41C88A0", VA = "0x1841C96A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private ECMHFHDFNAA DPEGFHFLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x319AFF0", Offset = "0x319A1F0", VA = "0x18319AFF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JCGKPCPJOOI OHPMAEDABBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x319A8D0", Offset = "0x3199AD0", VA = "0x18319A8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x319B9E0", Offset = "0x319ABE0", VA = "0x18319B9E0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x319B770", Offset = "0x319A970", VA = "0x18319B770", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x319A990", Offset = "0x3199B90", VA = "0x18319A990", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x319B4F0", Offset = "0x319A6F0", VA = "0x18319B4F0")]
	private void IOJEGPEKJCP(Entity MEGKMABGGNB, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x319AF90", Offset = "0x319A190", VA = "0x18319AF90", Slot = "14")]
	public NFJEDPPAJMK GKHEHOAFOIC()
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x319AA40", Offset = "0x3199C40", VA = "0x18319AA40", Slot = "10")]
	public void ENBCPMDHGKD(NFJEDPPAJMK OOGHONKGHEE, PEBFAOCIAHA OOMECLFFJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x319AB00", Offset = "0x3199D00", VA = "0x18319AB00", Slot = "9")]
	public PEBFAOCIAHA FAEACHJGIFH(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(PEBFAOCIAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x319B040", Offset = "0x319A240", VA = "0x18319B040", Slot = "11")]
	public NFJEDPPAJMK HNFLMLOPHHA(NFJEDPPAJMK OHJOALHOEEJ, [Optional] Vector3? DACBJNCMNFL, [Optional] Quaternion? MCFIHGJCDCP, [Optional] Vector3? BDMGGOCELCK)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x319B9A0", Offset = "0x319ABA0", VA = "0x18319B9A0", Slot = "15")]
	public NFJEDPPAJMK NGLCCBCIDOG(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD, [Optional] Vector3? DACBJNCMNFL, [Optional] Quaternion? MCFIHGJCDCP, [Optional] Vector3? BDMGGOCELCK)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x319B400", Offset = "0x319A600", VA = "0x18319B400", Slot = "7")]
	public NFJEDPPAJMK IMFDOPICOHE(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x319BA70", Offset = "0x319AC70", VA = "0x18319BA70", Slot = "16")]
	public void PLCIHKEHIPN(NFJEDPPAJMK BBFEKNBJKMC, NFJEDPPAJMK CFGMGHMOBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x319ABC0", Offset = "0x3199DC0", VA = "0x18319ABC0", Slot = "12")]
	public void FLKEGBPLANM(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x319ADF0", Offset = "0x3199FF0", VA = "0x18319ADF0", Slot = "17")]
	public void GFAKBMKOKAI(NFJEDPPAJMK BBFEKNBJKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x319B900", Offset = "0x319AB00", VA = "0x18319B900", Slot = "8")]
	public int LEDEJMODPPH(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x319B870", Offset = "0x319AA70", VA = "0x18319B870", Slot = "6")]
	[IteratorStateMachine(typeof(LILAKNKEIJE))]
	public IEnumerable<NFJEDPPAJMK> KAOCDNPPDAP(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x319AD60", Offset = "0x3199F60", VA = "0x18319AD60")]
	private bool GBGPFIFGAOG(NFJEDPPAJMK BBFEKNBJKMC, out NativeArray<Entity> PLBLCMNMLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x319B340", Offset = "0x319A540", VA = "0x18319B340")]
	private NativeArray<Entity> ILAKBJFIDNG(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EHONOOCHJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(PLIJOECNIOG), new string[] { })]
internal sealed class PLIJOECNIOG : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase EDDHBBFFICK;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private MJGGLIPIDNP IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2A83920", Offset = "0x2A82B20", VA = "0x182A83920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2A83A60", Offset = "0x2A82C60", VA = "0x182A83A60", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2A83970", Offset = "0x2A82B70", VA = "0x182A83970")]
	public void KDEOPCGFPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2A83650", Offset = "0x2A82850", VA = "0x182A83650")]
	public void EDHANPBDHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public PLIJOECNIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct IKGDNLPBCGC : IEquatable<IKGDNLPBCGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int NLGBDLLFIPJ;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x31ADB40", Offset = "0x31ACD40", VA = "0x1831ADB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x31ADCA0", Offset = "0x31ACEA0", VA = "0x1831ADCA0")]
	public IKGDNLPBCGC(Type DDJDPMGLPAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x31ADC20", Offset = "0x31ACE20", VA = "0x1831ADC20")]
	public static IKGDNLPBCGC LOJIFGBJNLM(Type DDJDPMGLPAE)
	{
		return default(IKGDNLPBCGC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x31ADC50", Offset = "0x31ACE50", VA = "0x1831ADC50")]
	public static Type LOJIFGBJNLM(IKGDNLPBCGC KJNCDAGJAPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0xF08770", Offset = "0xF07970", VA = "0x180F08770")]
	public static bool GJOJIEKGOHO(IKGDNLPBCGC FAMKPEGNHFC, IKGDNLPBCGC GPHMIGDKMEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0xF08770", Offset = "0xF07970", VA = "0x180F08770")]
	public static bool ALCENKEOHOJ(IKGDNLPBCGC FAMKPEGNHFC, IKGDNLPBCGC GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x86E560", Offset = "0x86D760", VA = "0x18086E560", Slot = "4")]
	public bool Equals(IKGDNLPBCGC IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x31ADAC0", Offset = "0x31ACCC0", VA = "0x1831ADAC0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x31ADC70", Offset = "0x31ACE70", VA = "0x1831ADC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class ICMCNFAAMEA
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> IMPCKIDAPNP;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> HDCLBFPCGCP;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x31AC910", Offset = "0x31ABB10", VA = "0x1831AC910")]
	static ICMCNFAAMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x288AC30", Offset = "0x2889E30", VA = "0x18288AC30")]
	public static bool AOHLLDNPMGN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x31AC460", Offset = "0x31AB660", VA = "0x1831AC460")]
	public static bool AOHLLDNPMGN(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x31AC4D0", Offset = "0x31AB6D0", VA = "0x1831AC4D0")]
	private static bool AOHLLDNPMGN(Type DDJDPMGLPAE, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x288AD60", Offset = "0x2889F60", VA = "0x18288AD60")]
	public static int MGNJLCPLAEP<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x31AC8A0", Offset = "0x31ABAA0", VA = "0x1831AC8A0")]
	public static int MGNJLCPLAEP(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x288ACC0", Offset = "0x2889EC0", VA = "0x18288ACC0")]
	public static bool GIGJNHOBOLH<T>(out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x31AC640", Offset = "0x31AB840", VA = "0x1831AC640")]
	public static bool GIGJNHOBOLH(Type DDJDPMGLPAE, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x31AC800", Offset = "0x31ABA00", VA = "0x1831AC800")]
	public static Type JLPNHBINJFC(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x31AC6E0", Offset = "0x31AB8E0", VA = "0x1831AC6E0")]
	public static bool GIGJNHOBOLH(int BELCAJFDAHD, out Type DDJDPMGLPAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct KIEMDCELJOF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int ONCBCCLEFOH;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x7E7EE0", Offset = "0x7E70E0", VA = "0x1807E7EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x234B620", Offset = "0x234A820", VA = "0x18234B620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> BIPDNCABMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x234B580", Offset = "0x234A780", VA = "0x18234B580")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x8EC650", Offset = "0x8EB850", VA = "0x1808EC650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x234B660", Offset = "0x234A860", VA = "0x18234B660")]
	public KIEMDCELJOF(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x234B4D0", Offset = "0x234A6D0", VA = "0x18234B4D0")]
	public int EDAEEPKFCFE(T JFBPNBNBHOE, int IDCHKLCNMBN, int OCCKKIPCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x234B410", Offset = "0x234A610", VA = "0x18234B410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct CPJMDAICANB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::KIEMDCELJOF<T> ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int ONCBCCLEFOH;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EA80", Offset = "0x2F1DC80", VA = "0x182F1EA80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E450", Offset = "0x2F1D650", VA = "0x182F1E450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DFC0", Offset = "0x2F1D1C0", VA = "0x182F1DFC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E200", Offset = "0x2F1D400", VA = "0x182F1E200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DF80", Offset = "0x2F1D180", VA = "0x182F1DF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> BIPDNCABMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E640", Offset = "0x2F1D840", VA = "0x182F1E640")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F0A0", Offset = "0x2F1E2A0", VA = "0x182F1F0A0")]
	public CPJMDAICANB(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D700", Offset = "0x2F1C900", VA = "0x182F1D700")]
	public T ADBECJBPAHJ(int BELCAJFDAHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E9B0", Offset = "0x2F1DBB0", VA = "0x182F1E9B0")]
	public void KHAHMOHDIMJ(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EB10", Offset = "0x2F1DD10", VA = "0x182F1EB10")]
	public void LGJAECILOOF(Span<T> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DAF0", Offset = "0x2F1CCF0", VA = "0x182F1DAF0")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DC00", Offset = "0x2F1CE00", VA = "0x182F1DC00")]
	private void BCFLJFECAHG(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D8B0", Offset = "0x2F1CAB0", VA = "0x182F1D8B0")]
	public void ALLOANNJLKE(Span<T> HIMJHOIKJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E330", Offset = "0x2F1D530", VA = "0x182F1E330")]
	public void EMPMGDILILO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E790", Offset = "0x2F1D990", VA = "0x182F1E790")]
	public void IECOBAKONFF(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EA20", Offset = "0x2F1DC20", VA = "0x182F1EA20")]
	public void LDKAFBDIKPM(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DFF0", Offset = "0x2F1D1F0", VA = "0x182F1DFF0")]
	public void DEEKCMABCMO(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E390", Offset = "0x2F1D590", VA = "0x182F1E390")]
	public void FAGCLLGFJNH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ECF0", Offset = "0x2F1DEF0", VA = "0x182F1ECF0")]
	public void MAADJFIJLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E2A0", Offset = "0x2F1D4A0", VA = "0x182F1E2A0")]
	public int EDAEEPKFCFE(T JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E4A0", Offset = "0x2F1D6A0", VA = "0x182F1E4A0")]
	public bool GPEECKGOEKF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E250", Offset = "0x2F1D450", VA = "0x182F1E250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F030", Offset = "0x2F1E230", VA = "0x182F1F030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC80", Offset = "0x2F1DE80", VA = "0x182F1EC80")]
	public static Span<T> LOJIFGBJNLM(global::CPJMDAICANB<T> NHOGENNANEB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EEF0", Offset = "0x2F1E0F0", VA = "0x182F1EEF0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void OBKBBPLPHBF(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void AEAGPLJIAHL(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D750", Offset = "0x2F1C950", VA = "0x182F1D750")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void AEAGPLJIAHL(int ONCBCCLEFOH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EDB0", Offset = "0x2F1DFB0", VA = "0x182F1EDB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MDCAMELBHHJ(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DD80", Offset = "0x2F1CF80", VA = "0x182F1DD80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void BMNNBJEGPPO(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E500", Offset = "0x2F1D700", VA = "0x182F1E500")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HCOGHMGPCOP(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct HNJLOOJCIKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int PBLBMIADLFF = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> GNGEEFEGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x31A9530", Offset = "0x31A8730", VA = "0x1831A9530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> OIHFEMNEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC2F960", Offset = "0xC2EB60", VA = "0x180C2F960")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray FNNNFCDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x31A94D0", Offset = "0x31A86D0", VA = "0x1831A94D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x31A95E0", Offset = "0x31A87E0", VA = "0x1831A95E0")]
	public HNJLOOJCIKA(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x31A9540", Offset = "0x31A8740", VA = "0x1831A9540")]
	public Entity NPGFKDKEGEL(int BELCAJFDAHD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x31A94C0", Offset = "0x31A86C0", VA = "0x1831A94C0")]
	public Transform HOIMJPFPMPD(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x31A9590", Offset = "0x31A8790", VA = "0x1831A9590")]
	public void OMMIMKBLIAB(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x31A92F0", Offset = "0x31A84F0", VA = "0x1831A92F0")]
	public int AOHLLDNPMGN(Transform LJLOGOIJMEM, Entity OAOGLFGGBPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x31A9440", Offset = "0x31A8640", VA = "0x1831A9440")]
	public int EMPMGDILILO(int BELCAJFDAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x31A93C0", Offset = "0x31A85C0", VA = "0x1831A93C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x31A94F0", Offset = "0x31A86F0", VA = "0x1831A94F0")]
	private void LNJFEFBOFJD(int KFFPMHLOCGD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class MOHNGBNLJCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<IKGDNLPBCGC, int2> AKNMLLLMLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> IEGPGBKLAIF;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x2A716A0", Offset = "0x2A708A0", VA = "0x182A716A0")]
	public MOHNGBNLJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2A70F40", Offset = "0x2A70140", VA = "0x182A70F40")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T JLPNHBINJFC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2A710C0", Offset = "0x2A702C0", VA = "0x182A710C0")]
	public void HDECKBNAIGA(Type DDJDPMGLPAE, LONBCMOJAJF JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2A712D0", Offset = "0x2A704D0", VA = "0x182A712D0")]
	public LONBCMOJAJF JLPNHBINJFC(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2A71600", Offset = "0x2A70800", VA = "0x182A71600")]
	private NativeArray<byte> PFAAGCBPJKK(int2 GGOPFABBCCA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2A70EA0", Offset = "0x2A700A0", VA = "0x182A70EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x2A70FA0", Offset = "0x2A701A0", VA = "0x182A70FA0", Slot = "1")]
	~MOHNGBNLJCF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct BHAELKOFCPA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::BHAELKOFCPA<T> LOJIFGBJNLM(T JFBPNBNBHOE)
	{
		return default(global::BHAELKOFCPA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T LOJIFGBJNLM(global::BHAELKOFCPA<T> EOBGHKICABG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class FGGCNCODMIC
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly MOHNGBNLJCF IPCLNCBGNPH;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x31A3940", Offset = "0x31A2B40", VA = "0x1831A3940")]
	internal static void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x31A39B0", Offset = "0x31A2BB0", VA = "0x1831A39B0")]
	public static void HDECKBNAIGA(Type DDJDPMGLPAE, LONBCMOJAJF JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T JLPNHBINJFC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x31A3A50", Offset = "0x31A2C50", VA = "0x1831A3A50")]
	public static LONBCMOJAJF JLPNHBINJFC(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class CJDEOKCHLHN : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly CJDEOKCHLHN HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2C49190", Offset = "0x2C48390", VA = "0x182C49190", Slot = "4")]
	public bool Equals(LinkedEntityGroup BIAIPPDLOMD, LinkedEntityGroup ECJDGGJBGPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2C491B0", Offset = "0x2C483B0", VA = "0x182C491B0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ADHHHFDPAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CJDEOKCHLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class GGMPHIFPNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void FDEBMOBLOHF(in Vector3 DACBJNCMNFL, in Quaternion MCFIHGJCDCP, in Vector3 BDMGGOCELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EJMICIMCCEM(in Vector3 GGOBCHKBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MNHIJGOBOPF(in Quaternion MCFIHGJCDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BJILOHPEBPO(in Vector3 KEPHECCGNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void IIHDBFPLIHO(in Vector3 KEPHECCGNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HJOOCKPDJGO(in float BBJPLPKDAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x31A6370", Offset = "0x31A5570", VA = "0x1831A6370")]
	[Conditional("DEBUG_BUILD")]
	public static void OKPLLAKKLPK(in float3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in float JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x31A62F0", Offset = "0x31A54F0", VA = "0x1831A62F0")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in Vector3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x31A6340", Offset = "0x31A5540", VA = "0x1831A6340")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in Quaternion JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x31A6420", Offset = "0x31A5620", VA = "0x1831A6420")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in float JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x31A6430", Offset = "0x31A5630", VA = "0x1831A6430")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in Vector3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x31A6470", Offset = "0x31A5670", VA = "0x1831A6470")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in Quaternion JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public GGMPHIFPNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct CCLINJKNNFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity CIPDAEPIOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity DPPABCPODHG;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2C47B70", Offset = "0x2C46D70", VA = "0x182C47B70")]
	public CCLINJKNNFF(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2C47B30", Offset = "0x2C46D30", VA = "0x182C47B30")]
	public static CCLINJKNNFF LOJIFGBJNLM((Entity entity, Entity oldParent, Entity newParent) GPGJLDIDGOO)
	{
		return default(CCLINJKNNFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2C47B10", Offset = "0x2C46D10", VA = "0x182C47B10")]
	public void EEEPFIIDMLE(out Entity OAOGLFGGBPI, out Entity CIPDAEPIOJL, out Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct LMIKKFINNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity GPFONCECPBK;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xEB1570", Offset = "0xEB0770", VA = "0x180EB1570")]
	public LMIKKFINNNK(Entity OAOGLFGGBPI, Entity GPFONCECPBK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F440", Offset = "0x2A6E640", VA = "0x182A6F440")]
	public static LMIKKFINNNK LOJIFGBJNLM((Entity entity, Entity parent) GPGJLDIDGOO)
	{
		return default(LMIKKFINNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F430", Offset = "0x2A6E630", VA = "0x182A6F430")]
	public void EEEPFIIDMLE(out Entity OAOGLFGGBPI, out Entity GPFONCECPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct ADHBFNPAIBJ<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle KJNCDAGJAPF;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool LPEEJAPCPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26B0", Offset = "0x2AA18B0", VA = "0x182AA26B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26F0", Offset = "0x2AA18F0", VA = "0x182AA26F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x2AA25F0", Offset = "0x2AA17F0", VA = "0x182AA25F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2790", Offset = "0x2AA1990", VA = "0x182AA2790")]
	public ADHBFNPAIBJ(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2AA26C0", Offset = "0x2AA18C0", VA = "0x182AA26C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum EJJOLCFCCMH
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct KIHDBJFDLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public EJJOLCFCCMH MGPNMJKAHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int BBOJBAGCOAP;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x6E8050", Offset = "0x6E7250", VA = "0x1806E8050")]
	public KIHDBJFDLNG(EJJOLCFCCMH MGPNMJKAHOK, int BBOJBAGCOAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x31A8160", Offset = "0x31A7360", VA = "0x1831A8160")]
	public static KIHDBJFDLNG LOJIFGBJNLM((EJJOLCFCCMH eventType, int eventIndex) BIAIPPDLOMD)
	{
		return default(KIHDBJFDLNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x31B4600", Offset = "0x31B3800", VA = "0x1831B4600")]
	public void EEEPFIIDMLE(out EJJOLCFCCMH MGPNMJKAHOK, out int BBOJBAGCOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[LOJIIDJFKAI(typeof(CCINBDMJAOA), new string[] { })]
public sealed class IPENIOJBPMG : CCINBDMJAOA, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x31AE950", Offset = "0x31ADB50", VA = "0x1831AE950", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x31AE8B0", Offset = "0x31ADAB0", VA = "0x1831AE8B0")]
	public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public IPENIOJBPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x31AE8B0", Offset = "0x31ADAB0", VA = "0x1831AE8B0", Slot = "4")]
	private bool MLFDMKJKJKC(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(MENAGEAHGAA))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class ACJIFFHBFME : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3EAF0", Offset = "0x2C3DCF0", VA = "0x182C3EAF0", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public ACJIFFHBFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(FOGAEHKMBML))]
public sealed class PHOBFOPIEAM : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x2A83570", Offset = "0x2A82770", VA = "0x182A83570", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public PHOBFOPIEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(BKFNKEDABJH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class EOOEMEAHNPN : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x319C8B0", Offset = "0x319BAB0", VA = "0x18319C8B0", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public EOOEMEAHNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class NDLCLJMPPBJ : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public NDLCLJMPPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[OEMDBJIOCGA]
[ExecuteAlways]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(OODOIKMOLLK))]
internal sealed class MGBLANLDNCG : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x2A70010", Offset = "0x2A6F210", VA = "0x182A70010", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E270", Offset = "0x2A6D470", VA = "0x182A6E270")]
	public MGBLANLDNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[DFPBKKCJHKF(typeof(AuthoredLocalPoseData))]
public sealed class BGDEJOJJHND : KNEHBPMPLBN
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2C44DA0", Offset = "0x2C43FA0", VA = "0x182C44DA0", Slot = "8")]
	protected override bool NKCHLENEANC(ReadOnlySpan<AuthoredLocalPoseData> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2C44CE0", Offset = "0x2C43EE0", VA = "0x182C44CE0", Slot = "9")]
	protected override bool DKHHDDPIABM(int FLPPPNDNNNB, Span<AuthoredLocalPoseData> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2C44E20", Offset = "0x2C44020", VA = "0x182C44E20")]
	public BGDEJOJJHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[DFPBKKCJHKF(typeof(LocalPoseData))]
public sealed class LDFIPDMHCDN : MJJIGOLHCHL
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D1F0", Offset = "0x2A6C3F0", VA = "0x182A6D1F0", Slot = "8")]
	protected override bool NKCHLENEANC(ReadOnlySpan<LocalPoseData> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D130", Offset = "0x2A6C330", VA = "0x182A6D130", Slot = "9")]
	protected override bool DKHHDDPIABM(int FLPPPNDNNNB, Span<LocalPoseData> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D270", Offset = "0x2A6C470", VA = "0x182A6D270")]
	public LDFIPDMHCDN()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0EE0", Offset = "0x2CD00E0", VA = "0x182CD0EE0", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1F00", Offset = "0x2CD1100", VA = "0x182CD1F00", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x319A0A0", Offset = "0x31992A0", VA = "0x18319A0A0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x319A1B0", Offset = "0x31993B0", VA = "0x18319A1B0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
