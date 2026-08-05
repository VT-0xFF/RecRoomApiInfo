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
	[Cpp2IlInjected.Address(RVA = "0x36CF8F0", Offset = "0x36CECF0", VA = "0x1836CF8F0")]
	static AILIPFEHOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2141C90", Offset = "0x2141090", VA = "0x182141C90")]
	public static void GNMIMBAOKMA<T>(T NKOMPJIJHJB, ref T HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36CF8C0", Offset = "0x36CECC0", VA = "0x1836CF8C0")]
	public static void GNMIMBAOKMA(FixedString32 NKOMPJIJHJB, ref string HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36CF7A0", Offset = "0x36CEBA0", VA = "0x1836CF7A0")]
	public static void GNMIMBAOKMA(string NKOMPJIJHJB, ref FixedString32 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36CF6B0", Offset = "0x36CEAB0", VA = "0x1836CF6B0")]
	public static void GNMIMBAOKMA(FixedString64 NKOMPJIJHJB, ref string HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36CF6E0", Offset = "0x36CEAE0", VA = "0x1836CF6E0")]
	public static void GNMIMBAOKMA(string NKOMPJIJHJB, ref FixedString64 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36CF850", Offset = "0x36CEC50", VA = "0x1836CF850")]
	public static void GNMIMBAOKMA(GKGNOKDIHMJ NKOMPJIJHJB, ref Vector3 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36CF740", Offset = "0x36CEB40", VA = "0x1836CF740")]
	public static void GNMIMBAOKMA(Vector3 NKOMPJIJHJB, ref GKGNOKDIHMJ HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36CF7E0", Offset = "0x36CEBE0", VA = "0x1836CF7E0")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref Vector4 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36CF580", Offset = "0x36CE980", VA = "0x1836CF580")]
	public static void GNMIMBAOKMA(Vector4 NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36CF7E0", Offset = "0x36CEBE0", VA = "0x1836CF7E0")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref Quaternion HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36CF580", Offset = "0x36CE980", VA = "0x1836CF580")]
	public static void GNMIMBAOKMA(Quaternion NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36CF5F0", Offset = "0x36CE9F0", VA = "0x1836CF5F0")]
	public static void GNMIMBAOKMA(GKGNOKDIHMJ NKOMPJIJHJB, ref float3 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36CF740", Offset = "0x36CEB40", VA = "0x1836CF740")]
	public static void GNMIMBAOKMA(float3 NKOMPJIJHJB, ref GKGNOKDIHMJ HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36CF810", Offset = "0x36CEC10", VA = "0x1836CF810")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref float4 HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36CF580", Offset = "0x36CE980", VA = "0x1836CF580")]
	public static void GNMIMBAOKMA(float4 NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36CF810", Offset = "0x36CEC10", VA = "0x1836CF810")]
	public static void GNMIMBAOKMA(DAGCKJIAPFI NKOMPJIJHJB, ref quaternion HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36CF640", Offset = "0x36CEA40", VA = "0x1836CF640")]
	public static void GNMIMBAOKMA(quaternion NKOMPJIJHJB, ref DAGCKJIAPFI HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36CF880", Offset = "0x36CEC80", VA = "0x1836CF880")]
	public static void GNMIMBAOKMA(Entity NKOMPJIJHJB, ref LMDNEEFMHDK HCHNJGMBMMC, CEADEEFJIGK CIEABJMCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36CF620", Offset = "0x36CEA20", VA = "0x1836CF620")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GPJINHAGDJN NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3689750", Offset = "0x3688B50", VA = "0x183689750", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	public OEFMGOFECMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A4F290", Offset = "0x3A4E690", VA = "0x183A4F290", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F210", Offset = "0x3A4E610", VA = "0x183A4F210")]
	[Preserve]
	private void NHFIBDOPLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public KLGJEKMJKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3689980", Offset = "0x3688D80", VA = "0x183689980", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public OIDMHGAFELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x368F2C0", Offset = "0x368E6C0", VA = "0x18368F2C0")]
		public static ObjectModelConfigAsset CCCJKEPCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4766470", Offset = "0x4765870", VA = "0x184766470")]
			public static IOLFAAOECPP FHEMMMHJIPK(int ENAKFDCFJAM)
			{
				return default(IOLFAAOECPP);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4766860", Offset = "0x4765C60", VA = "0x184766860")]
			private static void KHDAEKCLDBL(NFJEDPPAJMK COKFILNDBLP, NFJEDPPAJMK PAGBOOHJAJE, IOLFAAOECPP IOCKLNNJMIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x47662A0", Offset = "0x47656A0", VA = "0x1847662A0")]
			public static int BEJCDPMKCBG(GameObject OOKBNBHDPPG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x47669F0", Offset = "0x4765DF0", VA = "0x1847669F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x368F360", Offset = "0x368E760", VA = "0x18368F360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x368F670", Offset = "0x368EA70", VA = "0x18368F670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static IBAFENGCGOE HOEJKHDAMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x368F8F0", Offset = "0x368ECF0", VA = "0x18368F8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3690500", Offset = "0x368F900", VA = "0x183690500")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool KOJEFNHPNGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x368FA10", Offset = "0x368EE10", VA = "0x18368FA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static JHLNNPKIFCO BELPKEBIKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x368FDF0", Offset = "0x368F1F0", VA = "0x18368FDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3690D80", Offset = "0x3690180", VA = "0x183690D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static CGLADJHJCEM BNAKAEDMIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3690C10", Offset = "0x3690010", VA = "0x183690C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static BDFDGLPPMOH FGOFHGLAPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3690780", Offset = "0x368FB80", VA = "0x183690780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NPFNHEGAPFJ APIPCEEBONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x368F3C0", Offset = "0x368E7C0", VA = "0x18368F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static DJCLCEOJBJF NCKPBBOBINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3690B30", Offset = "0x368FF30", VA = "0x183690B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool FOPMPJMIIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3690920", Offset = "0x368FD20", VA = "0x183690920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool KJELGKIPPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x368FE90", Offset = "0x368F290", VA = "0x18368FE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool JODKOEPKNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x36901A0", Offset = "0x368F5A0", VA = "0x1836901A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x368F890", Offset = "0x368EC90", VA = "0x18368F890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool OPJEHBLJCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3690BB0", Offset = "0x368FFB0", VA = "0x183690BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3690720", Offset = "0x368FB20", VA = "0x183690720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JDAOGMBMFNA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x368FB70", Offset = "0x368EF70", VA = "0x18368FB70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x368F570", Offset = "0x368E970", VA = "0x18368F570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3690330", Offset = "0x368F730", VA = "0x183690330")]
		public static NFJEDPPAJMK HELPAPLNDJP(GameObject OOKBNBHDPPG)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x368F830", Offset = "0x368EC30", VA = "0x18368F830")]
		public static bool EDKHLDNKOGL(ByteString EJAHCFFDNJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3690800", Offset = "0x368FC00", VA = "0x183690800")]
		public static JMAKJOJHHNF IMCAMNOPOMH(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3690A00", Offset = "0x368FE00", VA = "0x183690A00")]
		public static (ByteString, IDisposable) LMGAKHPBOLH()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x368F440", Offset = "0x368E840", VA = "0x18368F440")]
		public static (ByteString, IDisposable) BKBMLMOHLGK(IEnumerable<NFJEDPPAJMK> LMPNJECPIDC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3690200", Offset = "0x368F600", VA = "0x183690200")]
		public static bool GFONIKEOCKE(GameObject OOKBNBHDPPG, out IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3690C90", Offset = "0x3690090", VA = "0x183690C90")]
		public static bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3690420", Offset = "0x368F820", VA = "0x183690420")]
		public static void HGJPOICCAII(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x368FC70", Offset = "0x368F070", VA = "0x18368FC70")]
		public static Task FCOPPLBIOGF(bool LNJLGDKOFHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x368F750", Offset = "0x368EB50", VA = "0x18368F750")]
		private static IBAFENGCGOE CKHHJAEFOHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3690080", Offset = "0x368F480", VA = "0x183690080")]
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

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3695BA0", Offset = "0x3694FA0", VA = "0x183695BA0")]
		public static bool LEOEHHMPOIB(MIDGCDECPDI IPNBFMDFCBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3695970", Offset = "0x3694D70", VA = "0x183695970")]
		public static MIDGCDECPDI KJDPCLCGNLB(GameObject OOKBNBHDPPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3695770", Offset = "0x3694B70", VA = "0x183695770")]
		public static MIDGCDECPDI KJDPCLCGNLB(GameObject OOKBNBHDPPG, IOLFAAOECPP IOCKLNNJMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3695670", Offset = "0x3694A70", VA = "0x183695670")]
		public static bool HONJBMHLIAN(GameObject GODCAKDBDMK, string FMCEKOCABPG, bool HMIAGGLBLKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3695380", Offset = "0x3694780", VA = "0x183695380")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void AEIHPKIBBDP(GameObject GODCAKDBDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3695580", Offset = "0x3694980", VA = "0x183695580")]
		[CompilerGenerated]
		internal static string GOPLDHJNDAH((GameObject go, string prefabName) FKNKEJLLBEP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, LIMMFBCPGFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NFJEDPPAJMK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C6F30", Offset = "0x7C6330", VA = "0x1807C6F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3A370D0", Offset = "0x3A364D0", VA = "0x183A370D0", Slot = "15")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JMAKJOJHHNF MAEACMMEJHE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3A37180", Offset = "0x3A36580", VA = "0x183A37180", Slot = "6")]
			get
			{
				return default(JMAKJOJHHNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3A370C0", Offset = "0x3A364C0", VA = "0x183A370C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IKFLBBFLGHA BFKMFKKIINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x74F250", Offset = "0x74E650", VA = "0x18074F250", Slot = "7")]
			get
			{
				return default(IKFLBBFLGHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3A36E50", Offset = "0x3A36250", VA = "0x183A36E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DFPNHPPNFLJ GNPLMALODDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3A363A0", Offset = "0x3A357A0", VA = "0x183A363A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NNDDENBBBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x810300", Offset = "0x80F700", VA = "0x180810300", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> MAAMINLJGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3A36F80", Offset = "0x3A36380", VA = "0x183A36F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3A371B0", Offset = "0x3A365B0", VA = "0x183A371B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<MIDGCDECPDI> BCGMGNAPMHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3A37020", Offset = "0x3A36420", VA = "0x183A37020", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3A37250", Offset = "0x3A36650", VA = "0x183A37250", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3A36400", Offset = "0x3A35800", VA = "0x183A36400")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3A36B70", Offset = "0x3A35F70", VA = "0x183A36B70", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A36820", Offset = "0x3A35C20", VA = "0x183A36820", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3A36AE0", Offset = "0x3A35EE0", VA = "0x183A36AE0", Slot = "10")]
		public void OnEmbody(CPEFIMBHABA OACNPKMLCHI, NFJEDPPAJMK ONBAMHPEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A36B60", Offset = "0x3A35F60", VA = "0x183A36B60", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3A368D0", Offset = "0x3A35CD0", VA = "0x183A368D0", Slot = "12")]
		public void OnDisembody(bool CIJGBBABFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3A36CC0", Offset = "0x3A360C0", VA = "0x183A36CC0")]
		private void PFOMFMINDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3A36DC0", Offset = "0x3A361C0", VA = "0x183A36DC0")]
		private void PHIGHDGGMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3A36640", Offset = "0x3A35A40", VA = "0x183A36640")]
		private void ONDFMJFBIEL(bool AFEBCJCKFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3A365E0", Offset = "0x3A359E0", VA = "0x183A365E0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x12C6710", Offset = "0x12C5B10", VA = "0x1812C6710", Slot = "9")]
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

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[MBALNPKLAGP(FOFKCKDBIPD.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override MFOBNBKALPH PMBFHMDCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x36A0A30", Offset = "0x369FE30", VA = "0x1836A0A30", Slot = "6")]
			get
			{
				return default(MFOBNBKALPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x36A09D0", Offset = "0x369FDD0", VA = "0x1836A09D0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual MFOBNBKALPH PMBFHMDCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080", Slot = "6")]
			get
			{
				return default(MFOBNBKALPH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x795E90", Offset = "0x795290", VA = "0x180795E90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NFJEDPPAJMK KPJMLJDCDIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0", Slot = "5")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9C88F0", Offset = "0x9C7CF0", VA = "0x1809C88F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity COBGFIFKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal NPFNHEGAPFJ APIPCEEBONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal DFPNHPPNFLJ JHLNDBLKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x37B21D0", Offset = "0x37B15D0", VA = "0x1837B21D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x37B1D20", Offset = "0x37B1120", VA = "0x1837B1D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x37B20E0", Offset = "0x37B14E0", VA = "0x1837B20E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x37B1D30", Offset = "0x37B1130", VA = "0x1837B1D30")]
		internal void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x37B2040", Offset = "0x37B1440", VA = "0x1837B2040")]
		private bool FJENGNJIPGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x37B2240", Offset = "0x37B1640", VA = "0x1837B2240")]
		private void OLFHCOGKOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x37B20E0", Offset = "0x37B14E0", VA = "0x1837B20E0")]
		internal void FLEJEMANDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x37B2270", Offset = "0x37B1670", VA = "0x1837B2270")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x37B2350", Offset = "0x37B1750", VA = "0x1837B2350")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DENLLMODGFC(typeof(AKKPACBLFCH))]
[LOJIIDJFKAI(typeof(IBAFENGCGOE), new string[] { })]
public class IIDNIPDKBKG : MMGILMAMAJD, KHJGFAKJFCE, IBAFENGCGOE, COEMEMEDCFH, AKKPACBLFCH, IDisposable
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
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xDE2290", Offset = "0xDE1690", VA = "0x180DE2290", Slot = "19")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MMAHKENHAHO BELPKEBIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public GAOMEBKFAAA DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GPJINHAGDJN NGMCJEFJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A46C00", Offset = "0x3A46000", VA = "0x183A46C00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A468E0", Offset = "0x3A45CE0", VA = "0x183A468E0", Slot = "20")]
	public void JKLOGDJOLHP(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xB64760", Offset = "0xB63B60", VA = "0x180B64760")]
	private void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A46C10", Offset = "0x3A46010", VA = "0x183A46C10")]
	private void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A46700", Offset = "0x3A45B00", VA = "0x183A46700", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A46760", Offset = "0x3A45B60", VA = "0x183A46760", Slot = "10")]
	public void EIPMHIGFPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void IHOPJKJHOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A46820", Offset = "0x3A45C20", VA = "0x183A46820", Slot = "5")]
	public void JGFPDJGKMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A46890", Offset = "0x3A45C90", VA = "0x183A46890", Slot = "6")]
	public void JHOMBPAMHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A46490", Offset = "0x3A45890", VA = "0x183A46490", Slot = "7")]
	public void AAHEOHMMMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A46CC0", Offset = "0x3A460C0", VA = "0x183A46CC0", Slot = "8")]
	public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A46690", Offset = "0x3A45A90", VA = "0x183A46690", Slot = "9")]
	public void COMMHLEBCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A46620", Offset = "0x3A45A20", VA = "0x183A46620", Slot = "11")]
	public void CCKCOKOBDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A467A0", Offset = "0x3A45BA0", VA = "0x183A467A0", Slot = "12")]
	public void FPEJLEMDNNG(bool LKAGAODJCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A46500", Offset = "0x3A45900", VA = "0x183A46500")]
	private void AKJDIGODPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A469F0", Offset = "0x3A45DF0", VA = "0x183A469F0", Slot = "13")]
	public ByteString LMGAKHPBOLH(out IDisposable BIGKFLCOHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A46AD0", Offset = "0x3A45ED0", VA = "0x183A46AD0", Slot = "14")]
	public void LPJEJNEGJFP(ByteString ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A46530", Offset = "0x3A45930", VA = "0x183A46530")]
	public static IIDNIPDKBKG BFPHDDBHNEE(MMAHKENHAHO KOKEGENGCAH, AKHLGKPGKGF NOECNPHPBKJ = AKHLGKPGKGF.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void APLFDHADJCE(MMAHKENHAHO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void DFBCEBNGGJC(MMAHKENHAHO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public IIDNIPDKBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MHHIICPONFE
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3685260", Offset = "0x3684660", VA = "0x183685260")]
	public static JMAKJOJHHNF AIPMEHKGCLA(this IBAFENGCGOE CCPHBLENGBG, IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
	{
		return default(JMAKJOJHHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3685580", Offset = "0x3684980", VA = "0x183685580")]
	public static KAINPBJGIFE IEIDJDJHKHA(this IBAFENGCGOE CCPHBLENGBG)
	{
		return default(KAINPBJGIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x36854D0", Offset = "0x36848D0", VA = "0x1836854D0")]
	public static NFJEDPPAJMK HELPAPLNDJP(this IBAFENGCGOE CCPHBLENGBG, Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x36853A0", Offset = "0x36847A0", VA = "0x1836853A0")]
	public static NFJEDPPAJMK HELPAPLNDJP(this IBAFENGCGOE CCPHBLENGBG, IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x36856A0", Offset = "0x3684AA0", VA = "0x1836856A0")]
	public static IOLFAAOECPP LPAPEMKKHGI(this IBAFENGCGOE CCPHBLENGBG, NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(IOLFAAOECPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum AKHLGKPGKGF
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
public class GEAJGNGECAJ<T> : global::APDLBOGPEAC<T>, global::MALNIJMODCH<IOLFAAOECPP, T>, global::CCJKFKABKGC<IOLFAAOECPP>, ANOLFBPNBLO, IDisposable, ICAMIIGEPFO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::CCJKFKABKGC<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate GNABHCENNFC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x36B8FD0", Offset = "0x36B83D0", VA = "0x1836B8FD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x36B4770", Offset = "0x36B3B70", VA = "0x1836B4770", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CNAIHAMIBKF PJJGDKDHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x36B6560", Offset = "0x36B5960", VA = "0x1836B6560", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int POKDJMJKNLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x36AC540", Offset = "0x36AB940", VA = "0x1836AC540", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PNEGJGPDCOE CEHDHBHCGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x36B8360", Offset = "0x36B7760", VA = "0x1836B8360", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E21370", Offset = "0x1E20770", VA = "0x181E21370", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x36B0460", Offset = "0x36AF860", VA = "0x1836B0460", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::MIFAEDKDHPB<IOLFAAOECPP> JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x36AF990", Offset = "0x36AED90", VA = "0x1836AF990", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x36ACA00", Offset = "0x36ABE00", VA = "0x1836ACA00", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x36B9660", Offset = "0x36B8A60", VA = "0x1836B9660")]
	public GEAJGNGECAJ(global::CCJKFKABKGC<Entity> LKAENGEIFGG, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x36B0100", Offset = "0x36AF500", VA = "0x1836B0100")]
	private Entity FFPKNNKHNKN(IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x36AFE80", Offset = "0x36AF280", VA = "0x1836AFE80")]
	private IOLFAAOECPP FFPKNNKHNKN(Entity OAOGLFGGBPI)
	{
		return default(IOLFAAOECPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x36B5C40", Offset = "0x36B5040", VA = "0x1836B5C40", Slot = "4")]
	public T JLPNHBINJFC(IOLFAAOECPP IOCKLNNJMIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36B06D0", Offset = "0x36AFAD0", VA = "0x1836B06D0")]
	public bool HDECKBNAIGA(IOLFAAOECPP IOCKLNNJMIA, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x36B2220", Offset = "0x36B1620", VA = "0x1836B2220")]
	public bool IEIBIDGHFGB(IOLFAAOECPP IOCKLNNJMIA, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x36AF6A0", Offset = "0x36AEAA0", VA = "0x1836AF6A0", Slot = "9")]
	public bool EOKNMHALCBJ(IOLFAAOECPP IOCKLNNJMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x36B1800", Offset = "0x36B0C00", VA = "0x1836B1800", Slot = "26")]
	public object ICCPIPABPLI(IOLFAAOECPP IOCKLNNJMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x36B7700", Offset = "0x36B6B00", VA = "0x1836B7700")]
	public bool NHPJKNLHJCD(IOLFAAOECPP IOCKLNNJMIA, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x36B5580", Offset = "0x36B4980", VA = "0x1836B5580")]
	public void JLPNHBINJFC(IOLFAAOECPP IOCKLNNJMIA, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x36B0BC0", Offset = "0x36AFFC0", VA = "0x1836B0BC0")]
	public bool HDECKBNAIGA(IOLFAAOECPP IOCKLNNJMIA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x36B1C40", Offset = "0x36B1040", VA = "0x1836B1C40")]
	public bool IEIBIDGHFGB(IOLFAAOECPP IOCKLNNJMIA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x36B8850", Offset = "0x36B7C50", VA = "0x1836B8850", Slot = "22")]
	public void OKJGILDOJEJ(FNFKCLIHOKN CFPEBKLBEPN, [Optional] object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x36B8880", Offset = "0x36B7C80", VA = "0x1836B8880", Slot = "15")]
	public void OKJGILDOJEJ(IOLFAAOECPP EBOEHIFNNLM, JLMGPHFMAFP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x36B6160", Offset = "0x36B5560", VA = "0x1836B6160", Slot = "14")]
	public bool JPMCEPOCADG(IOLFAAOECPP HCHNJGMBMMC, IOLFAAOECPP NKOMPJIJHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2718E00", Offset = "0x2718200", VA = "0x182718E00", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x36B95C0", Offset = "0x36B89C0", VA = "0x1836B95C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x36ADB20", Offset = "0x36ACF20", VA = "0x1836ADB20")]
	public string ENCCFGOODIM(in LONBCMOJAJF NMKPBPLEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x36B72D0", Offset = "0x36B66D0", VA = "0x1836B72D0")]
	private void MMHDEHEFJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x36AD390", Offset = "0x36AC790", VA = "0x1836AD390")]
	private void EMLKDKHPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x36B2C70", Offset = "0x36B2070", VA = "0x1836B2C70")]
	private void IHBFKBPOCBC(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x36B1520", Offset = "0x36B0920", VA = "0x1836B1520")]
	private void HNMIGAEDJEO(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x36AE730", Offset = "0x36ADB30", VA = "0x1836AE730")]
	[Conditional("DEBUG_BUILD")]
	private static void EOAAFIJMIEI(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA, string CGCMEEFENJL, string PMNLFCAAAOI, [CallerMemberName] string KIKOLEGOJKD = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2DC26C0", Offset = "0x2DC1AC0", VA = "0x182DC26C0", Slot = "5")]
	private bool ENADCOIHDLE(IOLFAAOECPP EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x36ACAB0", Offset = "0x36ABEB0", VA = "0x1836ACAB0", Slot = "6")]
	private bool BOLHFKGPLCA(IOLFAAOECPP EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B86810", Offset = "0x2B85C10", VA = "0x182B86810", Slot = "10")]
	private bool EDFEBLPAGKN(IOLFAAOECPP EBOEHIFNNLM, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x36ACAE0", Offset = "0x36ABEE0", VA = "0x1836ACAE0", Slot = "11")]
	private void CFDJKOIKBIN(IOLFAAOECPP EBOEHIFNNLM, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x36B8540", Offset = "0x36B7940", VA = "0x1836B8540", Slot = "12")]
	private bool OAIBGBJIAFM(IOLFAAOECPP EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x36B6300", Offset = "0x36B5700", VA = "0x1836B6300", Slot = "13")]
	private bool KJPBGFHLDFN(IOLFAAOECPP EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x36A6880", Offset = "0x36A5C80", VA = "0x1836A6880", Slot = "16")]
	private string FDCLPGLDNGF(in LONBCMOJAJF JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class EALCHGCDDPJ<T> : global::HKEMDJIFJBH<T>, global::MALNIJMODCH<NFJEDPPAJMK, T>, global::CCJKFKABKGC<NFJEDPPAJMK>, ANOLFBPNBLO, IDisposable, FNOOJMKBHOH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::CCJKFKABKGC<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate GNABHCENNFC;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string COEOOBLBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B86490", Offset = "0x3B85890", VA = "0x183B86490", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3B857C0", Offset = "0x3B84BC0", VA = "0x183B857C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CNAIHAMIBKF PJJGDKDHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3B85D10", Offset = "0x3B85110", VA = "0x183B85D10", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int POKDJMJKNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3B847A0", Offset = "0x3B83BA0", VA = "0x183B847A0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public PNEGJGPDCOE CEHDHBHCGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3B861E0", Offset = "0x3B855E0", VA = "0x183B861E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3B85CD0", Offset = "0x3B850D0", VA = "0x183B85CD0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3B84D50", Offset = "0x3B84150", VA = "0x183B84D50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MIFAEDKDHPB<NFJEDPPAJMK> JDAOGMBMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B84C70", Offset = "0x3B84070", VA = "0x183B84C70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B847F0", Offset = "0x3B83BF0", VA = "0x183B847F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x36B9660", Offset = "0x36B8A60", VA = "0x1836B9660")]
	public EALCHGCDDPJ(global::CCJKFKABKGC<Entity> LKAENGEIFGG, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2443570", Offset = "0x2442970", VA = "0x182443570")]
	private Entity FFPKNNKHNKN(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3B84D20", Offset = "0x3B84120", VA = "0x183B84D20")]
	private NFJEDPPAJMK FFPKNNKHNKN(Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3B85820", Offset = "0x3B84C20", VA = "0x183B85820", Slot = "4")]
	public T JLPNHBINJFC(NFJEDPPAJMK OOGHONKGHEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B84E20", Offset = "0x3B84220", VA = "0x183B84E20")]
	public bool HDECKBNAIGA(NFJEDPPAJMK OOGHONKGHEE, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B851D0", Offset = "0x3B845D0", VA = "0x183B851D0")]
	public bool IEIBIDGHFGB(NFJEDPPAJMK OOGHONKGHEE, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B84B30", Offset = "0x3B83F30", VA = "0x183B84B30", Slot = "9")]
	public bool EOKNMHALCBJ(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B850D0", Offset = "0x3B844D0", VA = "0x183B850D0", Slot = "26")]
	public object ICCPIPABPLI(NFJEDPPAJMK OOGHONKGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B85FD0", Offset = "0x3B853D0", VA = "0x183B85FD0")]
	public bool NHPJKNLHJCD(NFJEDPPAJMK OOGHONKGHEE, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B85B20", Offset = "0x3B84F20", VA = "0x183B85B20")]
	public void JLPNHBINJFC(NFJEDPPAJMK OOGHONKGHEE, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B84D90", Offset = "0x3B84190", VA = "0x183B84D90")]
	public bool HDECKBNAIGA(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3B85140", Offset = "0x3B84540", VA = "0x183B85140")]
	public bool IEIBIDGHFGB(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B863B0", Offset = "0x3B857B0", VA = "0x183B863B0", Slot = "22")]
	public void OKJGILDOJEJ(FNFKCLIHOKN CFPEBKLBEPN, [Optional] object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B86230", Offset = "0x3B85630", VA = "0x183B86230", Slot = "15")]
	public void OKJGILDOJEJ(NFJEDPPAJMK EBOEHIFNNLM, JLMGPHFMAFP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B85BA0", Offset = "0x3B84FA0", VA = "0x183B85BA0", Slot = "14")]
	public bool JPMCEPOCADG(NFJEDPPAJMK HCHNJGMBMMC, NFJEDPPAJMK NKOMPJIJHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B85D60", Offset = "0x3B85160", VA = "0x183B85D60")]
	private void MMHDEHEFJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B84910", Offset = "0x3B83D10", VA = "0x183B84910")]
	private void EMLKDKHPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B85380", Offset = "0x3B84780", VA = "0x183B85380")]
	private void IHBFKBPOCBC(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B85020", Offset = "0x3B84420", VA = "0x183B85020")]
	private void HNMIGAEDJEO(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B848E0", Offset = "0x3B83CE0", VA = "0x183B848E0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B86540", Offset = "0x3B85940", VA = "0x183B86540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x36ADB20", Offset = "0x36ACF20", VA = "0x1836ADB20")]
	public string ENCCFGOODIM(in LONBCMOJAJF NMKPBPLEGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B848A0", Offset = "0x3B83CA0", VA = "0x183B848A0", Slot = "5")]
	private bool BNCJIBGCFPA(NFJEDPPAJMK EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B84C30", Offset = "0x3B84030", VA = "0x183B84C30", Slot = "6")]
	private bool FAIIIJNKLLH(NFJEDPPAJMK EBOEHIFNNLM, in T FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B86840", Offset = "0x2B85C40", VA = "0x182B86840", Slot = "10")]
	private bool DILKOLHDACO(NFJEDPPAJMK EBOEHIFNNLM, in object FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B84FE0", Offset = "0x3B843E0", VA = "0x183B84FE0", Slot = "11")]
	private void HKJFKHHGMAJ(NFJEDPPAJMK EBOEHIFNNLM, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3B85C90", Offset = "0x3B85090", VA = "0x183B85C90", Slot = "12")]
	private bool KENHJDNNIOJ(NFJEDPPAJMK EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B85F90", Offset = "0x3B85390", VA = "0x183B85F90", Slot = "13")]
	private bool NEFGIHCCHPH(NFJEDPPAJMK EBOEHIFNNLM, in LONBCMOJAJF FPEGOFLFPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x36A6880", Offset = "0x36A5C80", VA = "0x1836A6880", Slot = "16")]
	private string JMIFCPCNGDH(in LONBCMOJAJF JFBPNBNBHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HKGKEPCIADL : IDisposable, MHOEABJDIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> MNAJFGJDBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public HKGKEPCIADL(NativeArray<EntityRemapUtility.EntityRemapInfo> AHNECMHNOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3A40BF0", Offset = "0x3A3FFF0", VA = "0x183A40BF0", Slot = "6")]
	public NFJEDPPAJMK IFPCEMLDIEH(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3A40CE0", Offset = "0x3A400E0", VA = "0x183A40CE0", Slot = "7")]
	public Entity IFPCEMLDIEH(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3A40C40", Offset = "0x3A40040", VA = "0x183A40C40", Slot = "8")]
	public IEnumerable<NFJEDPPAJMK> IFPCEMLDIEH(IEnumerable<NFJEDPPAJMK> LMPNJECPIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B90", Offset = "0x3A3FF90", VA = "0x183A40B90", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FADHLPPNOEF GCIMKBKOFEO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int FAFKHKCDNNF;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static MHOEABJDIBA CEEHHEDBOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool CENOJKDODOD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> MNAJFGJDBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x37AA370", Offset = "0x37A9770", VA = "0x1837AA370")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x37AA880", Offset = "0x37A9C80", VA = "0x1837AA880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x37AA820", Offset = "0x37A9C20", VA = "0x1837AA820")]
		public static SerializationRemapScope JJNMIIPPGJM()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x37AA9A0", Offset = "0x37A9DA0", VA = "0x1837AA9A0")]
		public SerializationRemapScope(MHOEABJDIBA KCEJCOIFNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x37AA480", Offset = "0x37A9880", VA = "0x1837AA480", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x37AA590", Offset = "0x37A9990", VA = "0x1837AA590")]
		public static NFJEDPPAJMK IFPCEMLDIEH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x37AA6F0", Offset = "0x37A9AF0", VA = "0x1837AA6F0")]
		public static Entity IFPCEMLDIEH(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[LOJIIDJFKAI(typeof(KNNAFEJKLMH), new string[] { "Editor" })]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public sealed class KNNAFEJKLMH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void EOPDEAPMNJC(IOLFAAOECPP PBICEPMHFMD, FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void GAMNMHPBKEG(IOLFAAOECPP PBICEPMHFMD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void LAICEEEJEAP(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EOPDEAPMNJC BINAKMDNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3A4FAB0", Offset = "0x3A4EEB0", VA = "0x183A4FAB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F720", Offset = "0x3A4EB20", VA = "0x183A4F720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GAMNMHPBKEG GABIINCCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F8B0", Offset = "0x3A4ECB0", VA = "0x183A4F8B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F970", Offset = "0x3A4ED70", VA = "0x183A4F970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event LAICEEEJEAP EAGODJINNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F810", Offset = "0x3A4EC10", VA = "0x183A4F810")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3A4FA10", Offset = "0x3A4EE10", VA = "0x183A4FA10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F950", Offset = "0x3A4ED50", VA = "0x183A4F950")]
	[Conditional("UNITY_EDITOR")]
	public void HKECMHKPKCN(IOLFAAOECPP PBICEPMHFMD, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F7C0", Offset = "0x3A4EBC0", VA = "0x183A4F7C0")]
	[Conditional("UNITY_EDITOR")]
	public void AJMBANJFKHK(IOLFAAOECPP PBICEPMHFMD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F7E0", Offset = "0x3A4EBE0", VA = "0x183A4F7E0")]
	[Conditional("UNITY_EDITOR")]
	public void DBCEICDGIHA(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public KNNAFEJKLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[LOJIIDJFKAI(typeof(FNCOHMIDMDB), new string[] { "Editor" })]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public sealed class FNCOHMIDMDB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void IEEKOMLFLMP(IOLFAAOECPP IOCKLNNJMIA, FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void IJGHGKBHAGO(IOLFAAOECPP IOCKLNNJMIA, bool OCNBEHMFPGM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void EDHGLGPANDG(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM, bool LFHBBHMKFBM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void AAIDNIEOCFA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void JFMMHAJFIDD(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event IEEKOMLFLMP BINAKMDNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E6E0", Offset = "0x3A3DAE0", VA = "0x183A3E6E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3A3DFF0", Offset = "0x3A3D3F0", VA = "0x183A3DFF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event IJGHGKBHAGO GABIINCCGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E3E0", Offset = "0x3A3D7E0", VA = "0x183A3E3E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E520", Offset = "0x3A3D920", VA = "0x183A3E520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event IEEKOMLFLMP HNODKEEEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EA00", Offset = "0x3A3DE00", VA = "0x183A3EA00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E1D0", Offset = "0x3A3D5D0", VA = "0x183A3E1D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event IJGHGKBHAGO JCLGHNCGACG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E820", Offset = "0x3A3DC20", VA = "0x183A3E820")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E270", Offset = "0x3A3D670", VA = "0x183A3E270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event EDHGLGPANDG EAGODJINNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E130", Offset = "0x3A3D530", VA = "0x183A3E130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E5F0", Offset = "0x3A3D9F0", VA = "0x183A3E5F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event AAIDNIEOCFA BGKGAFNMNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E480", Offset = "0x3A3D880", VA = "0x183A3E480")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E340", Offset = "0x3A3D740", VA = "0x183A3E340")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> DKPOCHBKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E090", Offset = "0x3A3D490", VA = "0x183A3E090")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EAD0", Offset = "0x3A3DED0", VA = "0x183A3EAD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event JFMMHAJFIDD NHNJBLLHFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E920", Offset = "0x3A3DD20", VA = "0x183A3E920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E780", Offset = "0x3A3DB80", VA = "0x183A3E780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E310", Offset = "0x3A3D710", VA = "0x183A3E310")]
	[Conditional("UNITY_EDITOR")]
	public void GOJEACAHJIJ(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E6C0", Offset = "0x3A3DAC0", VA = "0x183A3E6C0")]
	[Conditional("UNITY_EDITOR")]
	public void JIOGADHJHMG(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E690", Offset = "0x3A3DA90", VA = "0x183A3E690")]
	[Conditional("UNITY_EDITOR")]
	public void IKAECEOPBLE(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E9C0", Offset = "0x3A3DDC0", VA = "0x183A3E9C0")]
	[Conditional("UNITY_EDITOR")]
	public void LHEIPDGNBLD(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E5C0", Offset = "0x3A3D9C0", VA = "0x183A3E5C0")]
	[Conditional("UNITY_EDITOR")]
	public void ICGAADLGBNN(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool LFHBBHMKFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E9E0", Offset = "0x3A3DDE0", VA = "0x183A3E9E0")]
	[Conditional("UNITY_EDITOR")]
	public void NDNBMJPDPDF(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E8C0", Offset = "0x3A3DCC0", VA = "0x183A3E8C0")]
	[Conditional("UNITY_EDITOR")]
	public void KONCDHPAELG(string IGHJIHNAPBA, object KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EAA0", Offset = "0x3A3DEA0", VA = "0x183A3EAA0")]
	[Conditional("UNITY_EDITOR")]
	public void OLDKFHFNEIH(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FNCOHMIDMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[LOJIIDJFKAI(typeof(IENNIKCNIJD), new string[] { })]
public class NGENOGJCGIP : IENNIKCNIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3688A70", Offset = "0x3687E70", VA = "0x183688A70", Slot = "5")]
	public void MFMDHPGAJCA(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3688860", Offset = "0x3687C60", VA = "0x183688860", Slot = "6")]
	public void CCGCJHHLGNP(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3688B60", Offset = "0x3687F60", VA = "0x183688B60", Slot = "7")]
	public void OGIEKGHKJMI(object DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3688950", Offset = "0x3687D50", VA = "0x183688950", Slot = "4")]
	public IDisposable LGPGEDLNOFB(object DENPJAMCNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NGENOGJCGIP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[LOJIIDJFKAI(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal class BulkInstantiateSceneObjectService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string LALGPMCNOEH = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[IMNMHIBEIDL]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery NAEFNFIFMEP;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x36D61B0", Offset = "0x36D55B0", VA = "0x1836D61B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x36D7790", Offset = "0x36D6B90", VA = "0x1836D7790", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x36D5D80", Offset = "0x36D5180", VA = "0x1836D5D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x36D7910", Offset = "0x36D6D10", VA = "0x1836D7910")]
		public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> OGFKJCKDCGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x36D7680", Offset = "0x36D6A80", VA = "0x1836D7680")]
		public static bool OOEKCMLNKAO(CKLPCIIPNON EFADACBHMKC, out IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x36D5D90", Offset = "0x36D5190", VA = "0x1836D5D90")]
		private void EGNAPEHGOPD(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IEnumerable<CKLPCIIPNON> OGFKJCKDCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x36D6200", Offset = "0x36D5600", VA = "0x1836D6200")]
		private void JFCNMFDPMFI(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x36D6430", Offset = "0x36D5830", VA = "0x1836D6430")]
		private void LJOFPIMLCIO(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IOLFAAOECPP IOCKLNNJMIA, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x36D7320", Offset = "0x36D6720", VA = "0x1836D7320")]
		private void NLGLAFENJKG(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x36D6A80", Offset = "0x36D5E80", VA = "0x1836D6A80")]
		private void MNOMJIKJMHJ(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, List<CKLPCIIPNON> GNFHDKNMNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x36D68B0", Offset = "0x36D5CB0", VA = "0x1836D68B0")]
		private NativeList<IOLFAAOECPP> MNOLIEGGFBN(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF)
		{
			return default(NativeList<IOLFAAOECPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x36D7A90", Offset = "0x36D6E90", VA = "0x1836D7A90")]
		private NativeArray<Entity> PNKGPJGCNGL(NativeList<IOLFAAOECPP> BENIOJBNGJE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x36D6110", Offset = "0x36D5510", VA = "0x1836D6110")]
		private static void FLBAHFMCKLI(Dictionary<IOLFAAOECPP, CKLPCIIPNON> KFCGKKLOJFF, IOLFAAOECPP IOCKLNNJMIA, CKLPCIIPNON EFADACBHMKC, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	[LOJIIDJFKAI(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool KNFCGHKCAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x36E9220", Offset = "0x36E8620", VA = "0x1836E9220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x36E91A0", Offset = "0x36E85A0", VA = "0x1836E91A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool FDHKFPBCFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x36E9160", Offset = "0x36E8560", VA = "0x1836E9160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x36E91E0", Offset = "0x36E85E0", VA = "0x1836E91E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public void LHJBILOKHME(string IGHJIHNAPBA, EntityManager KNABDDPENKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public static void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LOJIIDJFKAI(typeof(NILGHIEKGGJ), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
internal class NILGHIEKGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x75DD30", Offset = "0x75D130", VA = "0x18075DD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool EMOMJDOBJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x75DD20", Offset = "0x75D120", VA = "0x18075DD20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x75DD40", Offset = "0x75D140", VA = "0x18075DD40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NILGHIEKGGJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[DENLLMODGFC(typeof(SerializationService))]
	[LOJIIDJFKAI(typeof(BDAJNAKKLOI), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	internal class SerializationService : BDAJNAKKLOI, IDisposable, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FADHLPPNOEF CEDIHMKBBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[IMNMHIBEIDL]
		private BANIDHAOEAM IPILJEFIHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[IMNMHIBEIDL]
		private NILGHIEKGGJ BCIFAEHMMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GKBBEKJICJK POAFAEBNFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OKNJKHAMLJO DDDCPHLJCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope BIGKFLCOHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? OMIDNCCFOLO;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HCGGEANBBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x37AB1E0", Offset = "0x37AA5E0", VA = "0x1837AB1E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x37ABCB0", Offset = "0x37AB0B0", VA = "0x1837ABCB0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool OMMOFMDIGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x950210", Offset = "0x94F610", VA = "0x180950210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9509A0", Offset = "0x94FDA0", VA = "0x1809509A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public OKNJKHAMLJO HLMDNBNAKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x37AC680", Offset = "0x37ABA80", VA = "0x1837AC680", Slot = "16")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x37AB470", Offset = "0x37AA870", VA = "0x1837AB470", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x37AB480", Offset = "0x37AA880", VA = "0x1837AB480")]
		public static bool EDKHLDNKOGL(ByteString EJAHCFFDNJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2940", Offset = "0x7B1D40", VA = "0x1807B2940")]
		public void OEOEMELPEEH(GKBBEKJICJK MNPBGJJKLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x37AB610", Offset = "0x37AAA10", VA = "0x1837AB610", Slot = "5")]
		public void FICEOIDDKMB(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x37ABC20", Offset = "0x37AB020", VA = "0x1837ABC20", Slot = "6")]
		public Task INECHLNGNHD(bool LNJLGDKOFHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x37ABE90", Offset = "0x37AB290", VA = "0x1837ABE90", Slot = "7")]
		public ByteString LMGAKHPBOLH(out IDisposable BIGKFLCOHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x37ABF70", Offset = "0x37AB370", VA = "0x1837ABF70", Slot = "19")]
		public ByteString LMGAKHPBOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x37AC150", Offset = "0x37AB550", VA = "0x1837AC150", Slot = "9")]
		public bool LPJEJNEGJFP(ByteString HJHKMBPIDKG, IKEMBFOFLAL NOECNPHPBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x37AC1B0", Offset = "0x37AB5B0", VA = "0x1837AC1B0")]
		private bool MNDICCLLCEP(ByteString HJHKMBPIDKG, IKEMBFOFLAL NOECNPHPBKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x37ABCC0", Offset = "0x37AB0C0", VA = "0x1837ABCC0", Slot = "8")]
		public void LLNDPIJOIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x37AAA30", Offset = "0x37A9E30", VA = "0x1837AAA30", Slot = "10")]
		public bool AAHEOHMMMBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x37AC720", Offset = "0x37ABB20", VA = "0x1837AC720", Slot = "11")]
		public bool PKGNLNNHFBN(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x37AACA0", Offset = "0x37AA0A0", VA = "0x1837AACA0")]
		public bool BKICLGMDFAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x37AB1F0", Offset = "0x37AA5F0", VA = "0x1837AB1F0", Slot = "12")]
		public bool COMMHLEBCKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37AAF50", Offset = "0x37AA350", VA = "0x1837AAF50")]
		public void CKBPIOFJIFD(OKNJKHAMLJO.BEABNMJDFOG.CAPLMFCIHOK MNKFJJIHAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x37AB960", Offset = "0x37AAD60", VA = "0x1837AB960")]
		private bool GAAGDHHJABP(ByteString HJHKMBPIDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x37AB420", Offset = "0x37AA820", VA = "0x1837AB420")]
		private void DNPAPDFHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x37AB5B0", Offset = "0x37AA9B0", VA = "0x1837AB5B0")]
		private ByteString FFACCHNOIKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x37AC4D0", Offset = "0x37AB8D0", VA = "0x1837AC4D0")]
		private ByteString NFKNACOIGFO(ByteString EJAHCFFDNJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x37AC5E0", Offset = "0x37AB9E0", VA = "0x1837AC5E0")]
		private OKNJKHAMLJO.BEABNMJDFOG.CAPLMFCIHOK NLLBJGAMNJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x37ABBF0", Offset = "0x37AAFF0", VA = "0x1837ABBF0")]
		private void ICOELLDODGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x37AAD80", Offset = "0x37AA180", VA = "0x1837AAD80", Slot = "13")]
		public bool CCKCOKOBDEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x37AB6E0", Offset = "0x37AAAE0", VA = "0x1837AB6E0", Slot = "14")]
		public void FPEJLEMDNNG(bool LKAGAODJCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x37AB790", Offset = "0x37AAB90", VA = "0x1837AB790")]
		private void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[LOJIIDJFKAI(typeof(BMGHPMCGENG), new string[] { })]
[DENLLMODGFC(typeof(BANIDHAOEAM))]
internal class BANIDHAOEAM : BMGHPMCGENG
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action JGFPDJGKMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x36D3FF0", Offset = "0x36D33F0", VA = "0x1836D3FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x36D41D0", Offset = "0x36D35D0", VA = "0x1836D41D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MHOEABJDIBA> NLLJHMCAAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x36D4400", Offset = "0x36D3800", VA = "0x1836D4400", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x36D4360", Offset = "0x36D3760", VA = "0x1836D4360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action EGKDMNHKGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x36D3EB0", Offset = "0x36D32B0", VA = "0x1836D3EB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x36D3DC0", Offset = "0x36D31C0", VA = "0x1836D3DC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action FABLIOINEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x36D4130", Offset = "0x36D3530", VA = "0x1836D4130", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x36D3F50", Offset = "0x36D3350", VA = "0x1836D3F50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MHOEABJDIBA> LCIHJABLCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x36D42C0", Offset = "0x36D36C0", VA = "0x1836D42C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36D4090", Offset = "0x36D3490", VA = "0x1836D4090", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x188D2E0", Offset = "0x188C6E0", VA = "0x18188D2E0")]
	public void LLNDPIJOIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D7C0", Offset = "0x1C9CBC0", VA = "0x181C9D7C0")]
	public void AKFIJEOJPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E06090", Offset = "0x1E05490", VA = "0x181E06090")]
	public void JBFKABGNBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x36D4270", Offset = "0x36D3670", VA = "0x1836D4270")]
	public void JBDFMEBJKCK(MHOEABJDIBA CEEHHEDBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x36D3E60", Offset = "0x36D3260", VA = "0x1836D3E60")]
	public void ANJJJKLLPNB(MHOEABJDIBA CEEHHEDBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public BANIDHAOEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LOJIIDJFKAI(typeof(DJCLCEOJBJF), new string[] { })]
public class HMIGOAGKBHF : DJCLCEOJBJF, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents NKDKBMKAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private CGHKOIFBLNH LHDIADGEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService ALLKDINDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::HKEMDJIFJBH<NFJEDPPAJMK> EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E43E0", Offset = "0x6E37E0", VA = "0x1806E43E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A41610", Offset = "0x3A40A10", VA = "0x183A41610")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x83B0B0", Offset = "0x83A4B0", VA = "0x18083B0B0", Slot = "14")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A421D0", Offset = "0x3A415D0", VA = "0x183A421D0", Slot = "15")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A41830", Offset = "0x3A40C30", VA = "0x183A41830", Slot = "16")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xB87670", Offset = "0xB86A70", VA = "0x180B87670", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x368C010", Offset = "0x368B410", VA = "0x18368C010")]
	private NFJEDPPAJMK NGLBNBDHCBP(Entity OAOGLFGGBPI)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A41FB0", Offset = "0x3A413B0", VA = "0x183A41FB0", Slot = "4")]
	public NFJEDPPAJMK MNEECNHBEJG(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A41CB0", Offset = "0x3A410B0", VA = "0x183A41CB0", Slot = "19")]
	public void KCMHHNCAIMK(ref List<NFJEDPPAJMK> JGJKBMBOGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A41300", Offset = "0x3A40700", VA = "0x183A41300", Slot = "20")]
	public IEnumerable<NFJEDPPAJMK> BIJKCDCNJDN(NFJEDPPAJMK OOGHONKGHEE, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A41A10", Offset = "0x3A40E10", VA = "0x183A41A10", Slot = "21")]
	public NFJEDPPAJMK JIABEAAPFBL(NFJEDPPAJMK OOGHONKGHEE, int BELCAJFDAHD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A420B0", Offset = "0x3A414B0", VA = "0x183A420B0", Slot = "22")]
	public int NPABIIHHFED(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A41400", Offset = "0x3A40800", VA = "0x183A41400", Slot = "8")]
	public int FJOEJBEAIPG(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A41920", Offset = "0x3A40D20", VA = "0x183A41920", Slot = "9")]
	public KAANBEDLICJ JCNHAHMIGIL(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(KAANBEDLICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A41660", Offset = "0x3A40A60", VA = "0x183A41660", Slot = "23")]
	public bool ICGCDJLAOGF(NFJEDPPAJMK OOGHONKGHEE, out KAANBEDLICJ LNHADOCOJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A41BE0", Offset = "0x3A40FE0", VA = "0x183A41BE0", Slot = "24")]
	public IEnumerable<NFJEDPPAJMK> JPCGBLEHGGF(NFJEDPPAJMK OOGHONKGHEE, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A41230", Offset = "0x3A40630", VA = "0x183A41230", Slot = "12")]
	public NFJEDPPAJMK BEIEOAFNFAF(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A41160", Offset = "0x3A40560", VA = "0x183A41160", Slot = "13")]
	public bool ABEADFFICKO(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD, out NFJEDPPAJMK OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A42010", Offset = "0x3A41410", VA = "0x183A42010", Slot = "5")]
	public NFJEDPPAJMK MODGPLDICAF(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A41ED0", Offset = "0x3A412D0", VA = "0x183A41ED0", Slot = "11")]
	public bool KFKEAKANFDF(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A422A0", Offset = "0x3A416A0", VA = "0x183A422A0", Slot = "25")]
	public bool PNPLAMAGNCA(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK LKJGCNCCCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A413D0", Offset = "0x3A407D0", VA = "0x183A413D0", Slot = "10")]
	public bool CLCGCNNPCNJ(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK HOHCGCELNKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A41F00", Offset = "0x3A41300", VA = "0x183A41F00", Slot = "6")]
	public bool KKGLFGKJMPP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK GPFONCECPBK, bool INKJNEFMNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A415A0", Offset = "0x3A409A0", VA = "0x183A415A0", Slot = "7")]
	public bool GFCKPIADCDP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK GPFONCECPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public HMIGOAGKBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(LKPHHNIFJFE), new string[] { })]
internal class LKPHHNIFJFE : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, BCCHDFPAANJ> KNKJOFMCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3684370", Offset = "0x3683770", VA = "0x183684370", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3683DA0", Offset = "0x36831A0", VA = "0x183683DA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3684160", Offset = "0x3683560", VA = "0x183684160")]
	public BCCHDFPAANJ GBIPKNCFFFJ(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3684010", Offset = "0x3683410", VA = "0x183684010")]
	public BCCHDFPAANJ GBIPKNCFFFJ(NMLCFAIOCDK MPKOBDPILJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3683EF0", Offset = "0x36832F0", VA = "0x183683EF0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x36843C0", Offset = "0x36837C0", VA = "0x1836843C0")]
	public LKPHHNIFJFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class BCCHDFPAANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<KIHDBJFDLNG> LIGBFHFNCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<LMIKKFINNNK> JLABFFGDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<CCLINJKNNFF> FHNJMFEHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<LMIKKFINNNK> PKOGBONKPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<KIHDBJFDLNG> HCBIGKOJDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
		get
		{
			return default(NativeList<KIHDBJFDLNG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<LMIKKFINNNK> ELGOEEGBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0")]
		get
		{
			return default(NativeList<LMIKKFINNNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<CCLINJKNNFF> MAGNNNDECGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xD489D0", Offset = "0xD47DD0", VA = "0x180D489D0")]
		get
		{
			return default(NativeList<CCLINJKNNFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<LMIKKFINNNK> EMNGNAECNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x846A80", Offset = "0x845E80", VA = "0x180846A80")]
		get
		{
			return default(NativeList<LMIKKFINNNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle KOGMBPFEHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x752DA0", Offset = "0x7521A0", VA = "0x180752DA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x20BA750", Offset = "0x20B9B50", VA = "0x1820BA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HCBAHJPCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x36D46C0", Offset = "0x36D3AC0", VA = "0x1836D46C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x36D4C40", Offset = "0x36D4040", VA = "0x1836D4C40")]
	public BCCHDFPAANJ(Allocator OPBLDCCKGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x36D4A80", Offset = "0x36D3E80", VA = "0x1836D4A80")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x36D4B10", Offset = "0x36D3F10", VA = "0x1836D4B10")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x36D4770", Offset = "0x36D3B70", VA = "0x1836D4770")]
	public void AOHLLDNPMGN(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[LOJIIDJFKAI(typeof(FBCNKCHPACJ), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public class FBCNKCHPACJ : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[IMNMHIBEIDL]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C460", Offset = "0x3A3B860", VA = "0x183A3C460", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C440", Offset = "0x3A3B840", VA = "0x183A3C440", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FBCNKCHPACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class JDBOBJPFFMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint FEOCEMOCKPE;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x100F0F0", Offset = "0x100E4F0", VA = "0x18100F0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3A48820", Offset = "0x3A47C20", VA = "0x183A48820")]
	public IOLFAAOECPP LNPPGCFLOHH()
	{
		return default(IOLFAAOECPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3A48870", Offset = "0x3A47C70", VA = "0x183A48870")]
	public void NIJKJOBCOCK(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1B3E0F0", Offset = "0x1B3D4F0", VA = "0x181B3E0F0", Slot = "6")]
	public virtual void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected JDBOBJPFFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(AAIADCALDOD), new string[] { })]
internal sealed class AAIADCALDOD : JDBOBJPFFMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint PMIGFHIBOOC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x36CE6E0", Offset = "0x36CDAE0", VA = "0x1836CE6E0", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x36CE630", Offset = "0x36CDA30", VA = "0x1836CE630")]
	private void BHPKNPKGHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x36CE680", Offset = "0x36CDA80", VA = "0x1836CE680", Slot = "6")]
	public override void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	public AAIADCALDOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LOJIIDJFKAI(typeof(LNNMLPAEAED), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class LNNMLPAEAED : JDBOBJPFFMG
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint CKAIKHBBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	public LNNMLPAEAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(DEBKKNKNNEP), new string[] { })]
internal sealed class DEBKKNKNNEP : JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery EGEKBBOJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery NFIKLHBDHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery LGDEKACIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery CFDEBNKJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery IBALNAGMJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery JJCIKGNBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x36E5FF0", Offset = "0x36E53F0", VA = "0x1836E5FF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery MAIFNINLJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery DGIOOGHLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x730150", Offset = "0x72F550", VA = "0x180730150")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery GAJJOHAKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6EED90", Offset = "0x6EE190", VA = "0x1806EED90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery CGPELACBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x752DA0", Offset = "0x7521A0", VA = "0x180752DA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery LAIKGDJDIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x752E90", Offset = "0x752290", VA = "0x180752E90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery DJMEEJAEBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x36E65C0", Offset = "0x36E59C0", VA = "0x1836E65C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int LKLIKLMACMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x36E6060", Offset = "0x36E5460", VA = "0x1836E6060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int APEIIPIDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x36E6040", Offset = "0x36E5440", VA = "0x1836E6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KIPPHGBJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x36E6540", Offset = "0x36E5940", VA = "0x1836E6540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int KBHDDOIFNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x36E5DC0", Offset = "0x36E51C0", VA = "0x1836E5DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int IHBICFBPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x36E6080", Offset = "0x36E5480", VA = "0x1836E6080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int BMDJAMEMPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x36E5D40", Offset = "0x36E5140", VA = "0x1836E5D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x36E6640", Offset = "0x36E5A40", VA = "0x1836E6640", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x36E60A0", Offset = "0x36E54A0", VA = "0x1836E60A0", Slot = "6")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x36E6560", Offset = "0x36E5960", VA = "0x1836E6560")]
	private EntityQueryDesc NLDEKBFMEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x36E5D60", Offset = "0x36E5160", VA = "0x1836E5D60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x36E5DE0", Offset = "0x36E51E0", VA = "0x1836E5DE0")]
	public JNMBNPFAJDL FLCJGEPPJJA(NFJEDPPAJMK ONBAMHPEIDG)
	{
		return default(JNMBNPFAJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x36E5E90", Offset = "0x36E5290", VA = "0x1836E5E90")]
	public JNMBNPFAJDL FLCJGEPPJJA(Entity OAOGLFGGBPI)
	{
		return default(JNMBNPFAJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x36E5F40", Offset = "0x36E5340", VA = "0x1836E5F40")]
	public MFOBNBKALPH GBKNIBKIHOC(Entity OAOGLFGGBPI)
	{
		return default(MFOBNBKALPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x36E6690", Offset = "0x36E5A90", VA = "0x1836E6690")]
	public DEBKKNKNNEP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[MBALNPKLAGP(FOFKCKDBIPD.All)]
	[LOJIIDJFKAI(typeof(NPFNHEGAPFJ), new string[] { })]
	public class ObjectService : DPDCPMNGBKH, NPFNHEGAPFJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly FADHLPPNOEF OAACCKPBMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[IMNMHIBEIDL]
		private GPJINHAGDJN HOCPKHHLENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[IMNMHIBEIDL]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[IMNMHIBEIDL]
		private ObjectInstantiationService DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public GPJINHAGDJN NGMCJEFJLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int LKLIKLMACMP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x3694790", Offset = "0x3693B90", VA = "0x183694790", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int APEIIPIDGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x3694720", Offset = "0x3693B20", VA = "0x183694720", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int KIPPHGBJEGE
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x3694870", Offset = "0x3693C70", VA = "0x183694870", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int KBHDDOIFNPG
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x3693CE0", Offset = "0x36930E0", VA = "0x183693CE0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int IHBICFBPGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x3694850", Offset = "0x3693C50", VA = "0x183694850", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int BMDJAMEMPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x36938C0", Offset = "0x3692CC0", VA = "0x1836938C0", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<NFJEDPPAJMK, MFOBNBKALPH> AGJONJAHFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x3693780", Offset = "0x3692B80", VA = "0x183693780", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x3694890", Offset = "0x3693C90", VA = "0x183694890", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<NFJEDPPAJMK> AEAKNNLHOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x3694B70", Offset = "0x3693F70", VA = "0x183694B70", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x36947B0", Offset = "0x3693BB0", VA = "0x1836947B0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3694F70", Offset = "0x3694370", VA = "0x183694F70", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3693B60", Offset = "0x3692F60", VA = "0x183693B60", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3693640", Offset = "0x3692A40", VA = "0x183693640")]
		private void BFBNAODLCNH(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3694050", Offset = "0x3693450", VA = "0x183694050")]
		private void FEHHFKCODGC(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3694D90", Offset = "0x3694190", VA = "0x183694D90")]
		internal NFJEDPPAJMK NGLBNBDHCBP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3693DA0", Offset = "0x36931A0", VA = "0x183693DA0", Slot = "41")]
		public KAANBEDLICJ EOJHKFGEAIB()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3694EC0", Offset = "0x36942C0", VA = "0x183694EC0", Slot = "42")]
		public KAANBEDLICJ PAMBNIOCPCM()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3693D00", Offset = "0x3693100", VA = "0x183693D00", Slot = "43")]
		public KAANBEDLICJ EIDHNJKNGFM()
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x36940E0", Offset = "0x36934E0", VA = "0x1836940E0", Slot = "10")]
		public JNMBNPFAJDL FLCJGEPPJJA(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(JNMBNPFAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3694340", Offset = "0x3693740", VA = "0x183694340", Slot = "11")]
		public MFOBNBKALPH GBKNIBKIHOC(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3693AB0", Offset = "0x3692EB0", VA = "0x183693AB0")]
		private KAANBEDLICJ DALBGCMGJDD(EntityQuery JLMGAJOHFKO)
		{
			return default(KAANBEDLICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3693E40", Offset = "0x3693240", VA = "0x183693E40", Slot = "33")]
		public bool EOKNMHALCBJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3693420", Offset = "0x3692820", VA = "0x183693420", Slot = "29")]
		public void ACJHDFNHANL(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x36938E0", Offset = "0x3692CE0", VA = "0x1836938E0", Slot = "30")]
		public void COLIANFIIAH(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x36936E0", Offset = "0x3692AE0", VA = "0x1836936E0", Slot = "31")]
		public void BNAAMBOKMGH(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x36939F0", Offset = "0x3692DF0", VA = "0x1836939F0", Slot = "22")]
		public JMAKJOJHHNF CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3693940", Offset = "0x3692D40", VA = "0x183693940", Slot = "23")]
		public JMAKJOJHHNF CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3694D00", Offset = "0x3694100", VA = "0x183694D00", Slot = "24")]
		public JMAKJOJHHNF MMLGPEAALJN(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3693470", Offset = "0x3692870", VA = "0x183693470", Slot = "25")]
		public JMAKJOJHHNF AIPMEHKGCLA(IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x36945D0", Offset = "0x36939D0", VA = "0x1836945D0", Slot = "44")]
		public JMAKJOJHHNF HIPEEDFCDLK(int BJBILOLHCFO, MFOBNBKALPH JDHIJCJKFOO, GameObject OOKBNBHDPPG)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3694660", Offset = "0x3693A60", VA = "0x183694660", Slot = "26")]
		public KAINPBJGIFE IEIDJDJHKHA()
		{
			return default(KAINPBJGIFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x36951E0", Offset = "0x36945E0", VA = "0x1836951E0", Slot = "45")]
		public FAEDMMBBFOA PPFCLJJLPDP(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(FAEDMMBBFOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3694400", Offset = "0x3693800", VA = "0x183694400", Slot = "27")]
		public FCINIMONKIM GKHEHOAFOIC()
		{
			return default(FCINIMONKIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3693F10", Offset = "0x3693310", VA = "0x183693F10", Slot = "28")]
		public OLODCECCCEO FBCCHMIENCE(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(OLODCECCCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x36949A0", Offset = "0x3693DA0", VA = "0x1836949A0", Slot = "12")]
		public void KJDPCLCGNLB(IOLFAAOECPP IOCKLNNJMIA, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3694110", Offset = "0x3693510", VA = "0x183694110", Slot = "13")]
		public JMAKJOJHHNF GAKEHOENCMF(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return default(JMAKJOJHHNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3693820", Offset = "0x3692C20", VA = "0x183693820", Slot = "14")]
		public bool CCBOPNINIEJ(NFJEDPPAJMK OOGHONKGHEE, out MIDGCDECPDI APCBFLNDMMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3694CB0", Offset = "0x36940B0", VA = "0x183694CB0", Slot = "46")]
		public Transform MHIJHDGLGCN(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x36933D0", Offset = "0x36927D0", VA = "0x1836933D0", Slot = "16")]
		public bool AAMKJDPJALI(NFJEDPPAJMK OOGHONKGHEE, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3694740", Offset = "0x3693B40", VA = "0x183694740", Slot = "17")]
		public bool IGNAOPBPCKO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3694E50", Offset = "0x3694250", VA = "0x183694E50")]
		public bool ODOOOIFCONJ(MIDGCDECPDI JFBPNBNBHOE, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3694E20", Offset = "0x3694220", VA = "0x183694E20", Slot = "47")]
		public bool ODOOOIFCONJ(NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3694640", Offset = "0x3693A40", VA = "0x183694640", Slot = "48")]
		public void HPILCJEPAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x36949C0", Offset = "0x3693DC0", VA = "0x1836949C0", Slot = "15")]
		public void KKIAJDCJNFI(MIDGCDECPDI ADHHHFDPAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3694E80", Offset = "0x3694280", VA = "0x183694E80", Slot = "49")]
		public void OONHDEIOEPE(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x36942C0", Offset = "0x36936C0", VA = "0x1836942C0", Slot = "18")]
		public bool GBKFKBLGCCA(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3694380", Offset = "0x3693780", VA = "0x183694380", Slot = "19")]
		public bool GJIPPEJJKHO(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3694DB0", Offset = "0x36941B0", VA = "0x183694DB0", Slot = "50")]
		public bool NMIIAKEHEIC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3694930", Offset = "0x3693D30", VA = "0x183694930", Slot = "51")]
		public bool KFEOGLGLLAC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3693370", Offset = "0x3692770", VA = "0x183693370", Slot = "32")]
		public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3694C10", Offset = "0x3694010", VA = "0x183694C10", Slot = "21")]
		public IOLFAAOECPP LPAPEMKKHGI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(IOLFAAOECPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x36944E0", Offset = "0x36938E0", VA = "0x1836944E0", Slot = "20")]
		public NFJEDPPAJMK HELPAPLNDJP(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3693ED0", Offset = "0x36932D0", VA = "0x183693ED0")]
		private void FACNMHLBPKJ(MFOBNBKALPH JDHIJCJKFOO, NFJEDPPAJMK OOGHONKGHEE, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LOJIIDJFKAI(typeof(JEIKFBGOBDH), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class JEIKFBGOBDH : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[IMNMHIBEIDL]
	private DEBKKNKNNEP LHDIADGEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3A49AA0", Offset = "0x3A48EA0", VA = "0x183A49AA0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3A48EC0", Offset = "0x3A482C0", VA = "0x183A48EC0")]
	public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
	{
		return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3A498C0", Offset = "0x3A48CC0", VA = "0x183A498C0")]
	private void LJGNDNNOBOG(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3A49150", Offset = "0x3A48550", VA = "0x183A49150")]
	private void GAMMHAGIBAO(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD, int JDHIJCJKFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3A48FC0", Offset = "0x3A483C0", VA = "0x183A48FC0")]
	private void AHGKMIJEPBI(NativeMultiHashMap<int, (NFJEDPPAJMK src, NFJEDPPAJMK dst)> AKDIAJDGDMD, int JDHIJCJKFOO, BCNEEGFPPIH ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3A495E0", Offset = "0x3A489E0", VA = "0x183A495E0")]
	private NativeMultiHashMap<int, (NFJEDPPAJMK, NFJEDPPAJMK)> KCBKOKHBKHK(Allocator OPBLDCCKGEG, NativeArray<NFJEDPPAJMK> IHEMFOMABIH, out NativeArray<(NFJEDPPAJMK src, NFJEDPPAJMK dst)> JAEMFJIDANN)
	{
		return default(NativeMultiHashMap<int, (NFJEDPPAJMK, NFJEDPPAJMK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JEIKFBGOBDH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[DENLLMODGFC(typeof(TransformService))]
	[LOJIIDJFKAI(typeof(DFPNHPPNFLJ), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class TransformService : DFPNHPPNFLJ, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FADHLPPNOEF DKLKEDAKIIG;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly FADHLPPNOEF CHIGBDKNFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private GKJCKFLLFKJ KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private DJCLCEOJBJF FPAHGFEONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase PIGADKLNHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService CCJAOIAIHHP;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x37B5010", Offset = "0x37B4410", VA = "0x1837B5010")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private JCGKPCPJOOI OHPMAEDABBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x37B2A20", Offset = "0x37B1E20", VA = "0x1837B2A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x37B7110", Offset = "0x37B6510", VA = "0x1837B7110", Slot = "33")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x37B54E0", Offset = "0x37B48E0", VA = "0x1837B54E0", Slot = "34")]
		public bool IBMPCAOLAEC(Transform LJLOGOIJMEM, out NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x37B5060", Offset = "0x37B4460", VA = "0x1837B5060", Slot = "35")]
		public Transform HOIMJPFPMPD(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x37B2410", Offset = "0x37B1810", VA = "0x1837B2410", Slot = "30")]
		public bool AAMKJDPJALI(Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x37B56A0", Offset = "0x37B4AA0", VA = "0x1837B56A0")]
		private void IDFOLKGMAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x37B4180", Offset = "0x37B3580", VA = "0x1837B4180", Slot = "29")]
		public void FBBDPHCKLIO(Entity OAOGLFGGBPI, out Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x37B7220", Offset = "0x37B6620", VA = "0x1837B7220", Slot = "4")]
		public void PHIGHDGGMNO(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x37B6300", Offset = "0x37B5700", VA = "0x1837B6300")]
		public void NHJGLIDADAO(Entity OAOGLFGGBPI, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM, Vector3 IINIILHCOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x37B2B80", Offset = "0x37B1F80", VA = "0x1837B2B80")]
		public void BJCLMAOOLIC(Entity OAOGLFGGBPI, Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x37B34E0", Offset = "0x37B28E0", VA = "0x1837B34E0", Slot = "27")]
		public void EEMHAMNAJMM(Entity OAOGLFGGBPI, out Matrix4x4 BEMAHJKDKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x37B5120", Offset = "0x37B4520", VA = "0x1837B5120")]
		public void HONNGIDOFNJ(Entity OAOGLFGGBPI, in Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x37B61D0", Offset = "0x37B55D0", VA = "0x1837B61D0")]
		public void LPPMGFNCCHE(Entity OAOGLFGGBPI, in Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x37B6F50", Offset = "0x37B6350", VA = "0x1837B6F50")]
		public void ONGILAGIPPG(Entity OAOGLFGGBPI, in Matrix4x4 OJNOPDDINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x37B30B0", Offset = "0x37B24B0", VA = "0x1837B30B0", Slot = "5")]
		public void DFMLPKFHNLG(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x37B4F00", Offset = "0x37B4300", VA = "0x1837B4F00", Slot = "6")]
		public Vector3 GJBOKJIGCBL(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x37B42D0", Offset = "0x37B36D0", VA = "0x1837B42D0", Slot = "7")]
		public void FDNACLAKOEC(Entity OAOGLFGGBPI, Quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x37B43D0", Offset = "0x37B37D0", VA = "0x1837B43D0", Slot = "8")]
		public Quaternion FEOIBCPCOKG(Entity OAOGLFGGBPI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x37B56C0", Offset = "0x37B4AC0", VA = "0x1837B56C0", Slot = "12")]
		public void IJPDEBBBFKD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x37B3D60", Offset = "0x37B3160", VA = "0x1837B3D60", Slot = "11")]
		public Vector3 EJMFAKDNICO(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x37B57C0", Offset = "0x37B4BC0", VA = "0x1837B57C0")]
		public void JAKLKBGEFBL(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x37B2AE0", Offset = "0x37B1EE0", VA = "0x1837B2AE0")]
		private Vector3 BGJGLDHLJAO(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x37B2620", Offset = "0x37B1A20", VA = "0x1837B2620", Slot = "14")]
		public float AMNMNBPMHEK(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x37B2510", Offset = "0x37B1910", VA = "0x1837B2510", Slot = "13")]
		public void ALEHHKAPKKL(Entity OAOGLFGGBPI, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x37B33F0", Offset = "0x37B27F0", VA = "0x1837B33F0")]
		private float DODDMFBBGLF(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x37B6D60", Offset = "0x37B6160", VA = "0x1837B6D60")]
		public void OIPAJHAEFPA(Entity OAOGLFGGBPI, float BHBODGPIKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x37B2EA0", Offset = "0x37B22A0", VA = "0x1837B2EA0", Slot = "16")]
		public Vector3 CJKHDOHDFBM(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x37B26C0", Offset = "0x37B1AC0", VA = "0x1837B26C0", Slot = "15")]
		public void ANMCAOHEHND(Entity OAOGLFGGBPI, Vector3 JCELHCJFLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x37B5EF0", Offset = "0x37B52F0", VA = "0x1837B5EF0")]
		private Vector3 KJCCCINBPFN(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x37B6BA0", Offset = "0x37B5FA0", VA = "0x1837B6BA0")]
		public void OEJIDBJIMDD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x37B4AA0", Offset = "0x37B3EA0", VA = "0x1837B4AA0")]
		[Conditional("DEBUG_BUILD")]
		private void FOPPBHPFGMJ(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x37B6DF0", Offset = "0x37B61F0", VA = "0x1837B6DF0", Slot = "36")]
		public void OKNHICOLCGK(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x37B3B90", Offset = "0x37B2F90", VA = "0x1837B3B90", Slot = "9")]
		public void EJAOPPBIHHJ(Entity OAOGLFGGBPI, out Vector3 DACBJNCMNFL, out Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x37B2F80", Offset = "0x37B2380", VA = "0x1837B2F80", Slot = "10")]
		public void CMAAFHILFDG(Entity OAOGLFGGBPI, out Vector3 DACBJNCMNFL, out Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x37B31D0", Offset = "0x37B25D0", VA = "0x1837B31D0", Slot = "37")]
		public void DJCOHCPGCAG(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x37B3E70", Offset = "0x37B3270", VA = "0x1837B3E70")]
		public void EJOKFHOEGAI(Entity OAOGLFGGBPI, Vector3 DACBJNCMNFL, Quaternion MCFIHGJCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x37B5CC0", Offset = "0x37B50C0", VA = "0x1837B5CC0", Slot = "17")]
		public void KFOBMOMMNKD(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x37B6AC0", Offset = "0x37B5EC0", VA = "0x1837B6AC0", Slot = "18")]
		public Vector3 ODHOKPOFNHG(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x37B4860", Offset = "0x37B3C60", VA = "0x1837B4860", Slot = "19")]
		public void FNKHHLBABJJ(Entity OAOGLFGGBPI, Quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x37B2C90", Offset = "0x37B2090", VA = "0x1837B2C90", Slot = "20")]
		public Quaternion CBGOMHCMEFK(Entity OAOGLFGGBPI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x37B5860", Offset = "0x37B4C60", VA = "0x1837B5860", Slot = "22")]
		public void KAILFGIEIKO(Entity OAOGLFGGBPI, Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x37B6C70", Offset = "0x37B6070", VA = "0x1837B6C70", Slot = "21")]
		public Vector3 OIDIBCOMBEN(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x37B4C50", Offset = "0x37B4050", VA = "0x1837B4C50", Slot = "23")]
		public void GCAJBHEGGNN(Entity OAOGLFGGBPI, float PLOEFOCDODI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x37B64B0", Offset = "0x37B58B0", VA = "0x1837B64B0", Slot = "24")]
		public float OAJPAGBABKJ(Entity OAOGLFGGBPI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x37B65D0", Offset = "0x37B59D0", VA = "0x1837B65D0", Slot = "25")]
		public void OCBFLFOKHEP(Entity OAOGLFGGBPI, Vector3 CCHOHGAKEGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x37B4DC0", Offset = "0x37B41C0", VA = "0x1837B4DC0", Slot = "26")]
		public Vector3 GFHDDODHJEA(Entity OAOGLFGGBPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x37B34F0", Offset = "0x37B28F0", VA = "0x1837B34F0", Slot = "31")]
		public void EFKAHDGAODL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x37B4030", Offset = "0x37B3430", VA = "0x1837B4030")]
		private NFJEDPPAJMK FAMOKPHFIPE(Transform LJLOGOIJMEM)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x37B27F0", Offset = "0x37B1BF0", VA = "0x1837B27F0")]
		private static TransformEntity BAIOFNKIKJJ(MFOBNBKALPH DDJDPMGLPAE, GameObject GODCAKDBDMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x37B2D80", Offset = "0x37B2180", VA = "0x1837B2D80", Slot = "32")]
		public void CCIIMJPCLDL(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x37B3CE0", Offset = "0x37B30E0", VA = "0x1837B3CE0")]
		private HJJLGKMPGLN EJAOPPBIHHJ(Entity OAOGLFGGBPI)
		{
			return default(HJJLGKMPGLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x37B63D0", Offset = "0x37B57D0", VA = "0x1837B63D0")]
		private bool NKOHPLNJLNH(Entity OAOGLFGGBPI, out Entity GPFONCECPBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x37B6020", Offset = "0x37B5420", VA = "0x1837B6020")]
		private void KLJOIGGINIF(Entity OAOGLFGGBPI, out Matrix4x4 NDENFHFCEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x37B44C0", Offset = "0x37B38C0", VA = "0x1837B44C0")]
		private void FMDOGOKBOLA(Entity OAOGLFGGBPI, out Matrix4x4 OJNOPDDINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x37B2500", Offset = "0x37B1900", VA = "0x1837B2500", Slot = "28")]
		private void AGACPGICPIH(Entity OAOGLFGGBPI, in Matrix4x4 BEMAHJKDKCM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LOJIIDJFKAI(typeof(EDLEDNKNNMB), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class EDLEDNKNNMB : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x36EA340", Offset = "0x36E9740", VA = "0x1836EA340", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x36EA2D0", Offset = "0x36E96D0", VA = "0x1836EA2D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EDLEDNKNNMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(INBLIGACKIF), new string[] { })]
public class INBLIGACKIF
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FDDHIKKDAJJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly INBLIGACKIF GPFONCECPBK;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x475EDF0", Offset = "0x475E1F0", VA = "0x18475EDF0")]
		public FDDHIKKDAJJ(INBLIGACKIF GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x475EDD0", Offset = "0x475E1D0", VA = "0x18475EDD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int FAHIDMNDFOC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool NJFOAKJMCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC17B0", Offset = "0x1DC0BB0", VA = "0x181DC17B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action LJAGMFKKKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3A47AD0", Offset = "0x3A46ED0", VA = "0x183A47AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3A47A30", Offset = "0x3A46E30", VA = "0x183A47A30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A47A00", Offset = "0x3A46E00", VA = "0x183A47A00")]
	public FDDHIKKDAJJ ABEBGHBCBGI()
	{
		return default(FDDHIKKDAJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x9739B0", Offset = "0x972DB0", VA = "0x1809739B0")]
	public void MHHBNKIPINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A47B70", Offset = "0x3A46F70", VA = "0x183A47B70")]
	public void OMGFPDIACBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public INBLIGACKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LOJIIDJFKAI(typeof(ADMIKKBEDIN), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public class ADMIKKBEDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int FAHIDMNDFOC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9C9270", Offset = "0x9C8670", VA = "0x1809C9270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public ADMIKKBEDIN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[LOJIIDJFKAI(typeof(EnableComponentSystemsInScope), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	public class EnableComponentSystemsInScope : DPDCPMNGBKH, CBFMKNIGECP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct FKGCBMIMKKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> EEFMIEFKGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> NHJCEALNJLO;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x475F240", Offset = "0x475E640", VA = "0x18475F240")]
			public FKGCBMIMKKK(NativeArray<int> EEFMIEFKGLG, NativeArray<int> GGHFLGHFEMD, Dictionary<ComponentSystemBase, int> NHJCEALNJLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x475EFC0", Offset = "0x475E3C0", VA = "0x18475EFC0")]
			public void LFEJNLLPNFL(IEnumerable<ComponentSystemBase> HOCPKHHLENG, JHCKAKNDFFP PLOEGHGLKPD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class BGEBFGFOFFP : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public BGEBFGFOFFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x475BFF0", Offset = "0x475B3F0", VA = "0x18475BFF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x475C1C0", Offset = "0x475B5C0", VA = "0x18475C1C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x475C110", Offset = "0x475B510", VA = "0x18475C110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x475C110", Offset = "0x475B510", VA = "0x18475C110", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const JHCKAKNDFFP HJOCIDOBHPP = JHCKAKNDFFP.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FADHLPPNOEF BPGBIEPDJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private JHLNNPKIFCO KOKEGENGCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> FFAAGADNJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> PPNJBNFDHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int FLPPPNDNNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JHCKAKNDFFP KLLMIENMENM;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A38420", Offset = "0x3A37820", VA = "0x183A38420", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3A37640", Offset = "0x3A36A40", VA = "0x183A37640", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A376D0", Offset = "0x3A36AD0", VA = "0x183A376D0")]
		[IteratorStateMachine(typeof(BGEBFGFOFFP))]
		private IEnumerable<ComponentSystemBase> FCDEGJJLGLB(int IDCHKLCNMBN, int HEGLMOCOEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A372F0", Offset = "0x3A366F0", VA = "0x183A372F0", Slot = "5")]
		public void AEPAOFPFGOA(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A377C0", Offset = "0x3A36BC0", VA = "0x183A377C0")]
		private void FFOMGBEMCCK(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A37910", Offset = "0x3A36D10", VA = "0x183A37910")]
		public void FFOMGBEMCCK(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A37300", Offset = "0x3A36700", VA = "0x183A37300")]
		private void APGOCKEFEMH(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A381E0", Offset = "0x3A375E0", VA = "0x183A381E0")]
		private void MPKCJFHOCGD(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A383C0", Offset = "0x3A377C0", VA = "0x183A383C0")]
		private void NFJCBKDGGKD(JHCKAKNDFFP AANIBAOFBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A37B30", Offset = "0x3A36F30", VA = "0x183A37B30")]
		private void JODGKFHFJKL(int IDCHKLCNMBN, int HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A37A70", Offset = "0x3A36E70", VA = "0x183A37A70")]
		private void HGJPOICCAII(int IDCHKLCNMBN, int HEGLMOCOEGO, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A37A50", Offset = "0x3A36E50", VA = "0x183A37A50")]
		private int GPJCGEHCJHB(JHCKAKNDFFP AANIBAOFBJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A37BF0", Offset = "0x3A36FF0", VA = "0x183A37BF0")]
		private bool KMBLCCNNPEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A38270", Offset = "0x3A37670", VA = "0x183A38270")]
		private Dictionary<ComponentSystemBase, int> NALBKCHBLNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A37A10", Offset = "0x3A36E10", VA = "0x183A37A10")]
		private void FNEMCAFIPEL(NativeArray<int> EEFMIEFKGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A37590", Offset = "0x3A36990", VA = "0x183A37590")]
		private void CPLENEBENDI(NativeArray<int> GGHFLGHFEMD, NativeArray<int> EEFMIEFKGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A38360", Offset = "0x3A37760", VA = "0x183A38360")]
		private static JHCKAKNDFFP NDFAADKNGLC(Type DDJDPMGLPAE, JHCKAKNDFFP EOBGHKICABG)
		{
			return default(JHCKAKNDFFP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A38530", Offset = "0x3A37930", VA = "0x183A38530")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A37760", Offset = "0x3A36B60", VA = "0x183A37760")]
		[CompilerGenerated]
		private void FDJFPLHGIAN(DPDCPMNGBKH IACHGNJKHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A38180", Offset = "0x3A37580", VA = "0x183A38180")]
		[CompilerGenerated]
		private void LNOPIFDFDCI(FPHKGEBJIKC IACHGNJKHMN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[MBALNPKLAGP(FOFKCKDBIPD.WorldService)]
	[LOJIIDJFKAI(typeof(LFIBHLPOILP), new string[] { })]
	public class TickService : DPDCPMNGBKH, LFIBHLPOILP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker PCFJEAHMHDP;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker CJLBIBJDJLK;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker AFPGHIMOENP;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker JJLEPCBFAFF;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker FEMAMMCNBFK;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker HMHKJDKBLPH;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker PDBHCMGKEIJ;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker EBGMPOFMJEA;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker JMKMFHLHODE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker AKEACOBJOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[IMNMHIBEIDL]
		private BDAJNAKKLOI BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[IMNMHIBEIDL]
		private NILGHIEKGGJ ADBPFEHIBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[IMNMHIBEIDL]
		private TransformOwnershipPhase EDDHBBFFICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[IMNMHIBEIDL]
		private TimeService JOGKAGECKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private MJGGLIPIDNP OACNPKMLCHI;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool PCMNKHFDPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x37B0E00", Offset = "0x37B0200", VA = "0x1837B0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool IHPJCFCPAKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x37B0920", Offset = "0x37AFD20", VA = "0x1837B0920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool LJMFMFBLKDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x37B0E00", Offset = "0x37B0200", VA = "0x1837B0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool DLOFBJENFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x37B0E00", Offset = "0x37B0200", VA = "0x1837B0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x37B16D0", Offset = "0x37B0AD0", VA = "0x1837B16D0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x37B0C10", Offset = "0x37B0010", VA = "0x1837B0C10", Slot = "14")]
		public void GKFBCPAHPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x37B1430", Offset = "0x37B0830", VA = "0x1837B1430", Slot = "15")]
		public void LOKEIDCHOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x37B0B40", Offset = "0x37AFF40", VA = "0x1837B0B40", Slot = "5")]
		public void FJBGJECCJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x37B09C0", Offset = "0x37AFDC0", VA = "0x1837B09C0", Slot = "6")]
		public void EIOOCHEOKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x37B07A0", Offset = "0x37AFBA0", VA = "0x1837B07A0", Slot = "7")]
		public void BJAKFLHJNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x37B12B0", Offset = "0x37B06B0", VA = "0x1837B12B0", Slot = "8")]
		public void LKEKIONCJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x37B1550", Offset = "0x37B0950", VA = "0x1837B1550", Slot = "9")]
		public void NHEOCLKOANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x37B0E70", Offset = "0x37B0270", VA = "0x1837B0E70", Slot = "10")]
		public void KLGBCPNHBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x37B0D30", Offset = "0x37B0130", VA = "0x1837B0D30", Slot = "11")]
		public void HPIFEDLDHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
		public void LJCMLABHGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x37B0650", Offset = "0x37AFA50", VA = "0x1837B0650", Slot = "12")]
		public void ALEDHMOOFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[MBALNPKLAGP(FOFKCKDBIPD.WorldService)]
	[LOJIIDJFKAI(typeof(CPEFIMBHABA), new string[] { })]
	public class WorldService : CPEFIMBHABA, IDisposable, LFPMKPLIAAM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private MJGGLIPIDNP OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public MJGGLIPIDNP IIINLMPBCPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public JCGKPCPJOOI OHPMAEDABBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xE7EB80", Offset = "0xE7DF80", VA = "0x180E7EB80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x37BF910", Offset = "0x37BED10", VA = "0x1837BF910", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x37BF930", Offset = "0x37BED30", VA = "0x1837BF930", Slot = "10")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x37BF5B0", Offset = "0x37BE9B0", VA = "0x1837BF5B0")]
		private void BFPHDDBHNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x37BF6C0", Offset = "0x37BEAC0", VA = "0x1837BF6C0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x37BF8F0", Offset = "0x37BECF0", VA = "0x1837BF8F0", Slot = "8")]
		public ComponentSystemBase ENGBKAHPLGI(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LOJIIDJFKAI(typeof(LFJAPFGLCMI), new string[] { })]
public sealed class LAMGODIJFKL : LFJAPFGLCMI, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JJEPBHPMDEL : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x47623B0", Offset = "0x47617B0", VA = "0x1847623B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x760D30", Offset = "0x760130", VA = "0x180760D30")]
		[DebuggerHidden]
		public JJEPBHPMDEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x47620A0", Offset = "0x47614A0", VA = "0x1847620A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4762370", Offset = "0x4761770", VA = "0x184762370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x47622D0", Offset = "0x47616D0", VA = "0x1847622D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x47622D0", Offset = "0x47616D0", VA = "0x1847622D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[IMNMHIBEIDL]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly CDKDMLIJPKH GMNIHNAKLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, OHBNOLPKNLP> KKCEAEGPCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, JDGJMEJMAJC> EMIGFHNAFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<FNOOJMKBHOH> NMLIPDDKLMG;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JDGJMEJMAJC GJEJHPOKGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A521F0", Offset = "0x3A515F0", VA = "0x183A521F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<FNOOJMKBHOH> HIBNOCAMLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A52960", Offset = "0x3A51D60", VA = "0x183A52960", Slot = "8")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A522A0", Offset = "0x3A516A0", VA = "0x183A522A0", Slot = "9")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A51D40", Offset = "0x3A51140", VA = "0x183A51D40", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A51E60", Offset = "0x3A51260", VA = "0x183A51E60", Slot = "6")]
	public bool EPNNAEJBDMB(FNOOJMKBHOH LKAENGEIFGG, out JDGJMEJMAJC HMGHGFKHJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A522C0", Offset = "0x3A516C0", VA = "0x183A522C0")]
	private void MHDONBPAPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A52650", Offset = "0x3A51A50", VA = "0x183A52650")]
	private void NOONKDBIMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A52900", Offset = "0x3A51D00", VA = "0x183A52900")]
	private OHBNOLPKNLP OICIAJGPIJB(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A521F0", Offset = "0x3A515F0", VA = "0x183A521F0")]
	private OHBNOLPKNLP KGDEAIHEIPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A51F80", Offset = "0x3A51380", VA = "0x183A51F80")]
	private OHBNOLPKNLP GDMMKGPHBIJ(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A527F0", Offset = "0x3A51BF0", VA = "0x183A527F0")]
	private OHBNOLPKNLP OCBEEGLJNPO(string BENGLHDIHMD, string AJDBKDIMOHA, [Optional] OHBNOLPKNLP IGPIJNKEGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A51CD0", Offset = "0x3A510D0", VA = "0x183A51CD0")]
	[IteratorStateMachine(typeof(JJEPBHPMDEL))]
	private IEnumerable<(string, string)> DIKAHJNFDMF(string MMHIKFHMOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A51AC0", Offset = "0x3A50EC0", VA = "0x183A51AC0")]
	private bool AHCIGLFIHAG(FNOOJMKBHOH LKAENGEIFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A51BF0", Offset = "0x3A50FF0", VA = "0x183A51BF0")]
	private CDKDMLIJPKH CHHKNICJNGB(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A52250", Offset = "0x3A51650", VA = "0x183A52250")]
	private CDKDMLIJPKH GIDNEBEJCOO(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A51EF0", Offset = "0x3A512F0", VA = "0x183A51EF0")]
	private CDKDMLIJPKH FFKCNKNEOPH(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x28766E0", Offset = "0x2875AE0", VA = "0x1828766E0")]
	private T POOMBALJPGK<T>(FNOOJMKBHOH LKAENGEIFGG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A51B10", Offset = "0x3A50F10", VA = "0x183A51B10")]
	private FieldInfo BLMGFOFAFHM(FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A529C0", Offset = "0x3A51DC0", VA = "0x183A529C0")]
	public LAMGODIJFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A51DD0", Offset = "0x3A511D0", VA = "0x183A51DD0")]
	[CompilerGenerated]
	private int EOLKGADHMGE(FNOOJMKBHOH FAMKPEGNHFC, FNOOJMKBHOH GPHMIGDKMEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class OHBNOLPKNLP : JDGJMEJMAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string ICINBCPMBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly OHBNOLPKNLP IGPIJNKEGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<OHBNOLPKNLP> PMKNEIGPLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<FNOOJMKBHOH> ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string KKLLJOOPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JDGJMEJMAJC PBOLBJKBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<JDGJMEJMAJC> KPJPFEOMAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<FNOOJMKBHOH> LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x36897C0", Offset = "0x3688BC0", VA = "0x1836897C0")]
	public OHBNOLPKNLP(string IGHJIHNAPBA, OHBNOLPKNLP GPFONCECPBK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	[LOJIIDJFKAI(typeof(BDFDGLPPMOH), new string[] { })]
	[DENLLMODGFC(typeof(HistoryService))]
	public class HistoryService : DPDCPMNGBKH, IDisposable, BDFDGLPPMOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum DFJEOKIAIEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct LKPMGDMGEOD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly DFJEOKIAIEF GGFPKNAGICN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService IAFMOECNDHE;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4763EC0", Offset = "0x47632C0", VA = "0x184763EC0")]
			public LKPMGDMGEOD(HistoryService IAFMOECNDHE, bool IKPNDPMFPFI, uint FLPPPNDNNNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4763E90", Offset = "0x4763290", VA = "0x184763E90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class ELIPEMMEIFN
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct GEFMHJFHKOD : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly ELIPEMMEIFN OCOPNGDLHNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool NPPNMDKDEDG;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x475F8E0", Offset = "0x475ECE0", VA = "0x18475F8E0")]
				public GEFMHJFHKOD(ELIPEMMEIFN OCOPNGDLHNC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x475F8B0", Offset = "0x475ECB0", VA = "0x18475F8B0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct OIPKJDFIGEK : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly ELIPEMMEIFN OCOPNGDLHNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool NPPNMDKDEDG;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x47651D0", Offset = "0x47645D0", VA = "0x1847651D0")]
				public OIPKJDFIGEK(ELIPEMMEIFN OCOPNGDLHNC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x475F8B0", Offset = "0x475ECB0", VA = "0x18475F8B0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService HIOJLLPHGDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool MGFPEGPPAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int KLJNJIDEGGO;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x475E4E0", Offset = "0x475D8E0", VA = "0x18475E4E0")]
			public ELIPEMMEIFN(HistoryService HIOJLLPHGDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x475E4B0", Offset = "0x475D8B0", VA = "0x18475E4B0")]
			public bool PCCIFICCJAA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x475E410", Offset = "0x475D810", VA = "0x18475E410")]
			public OIPKJDFIGEK LJFEMNGILEK()
			{
				return default(OIPKJDFIGEK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x475E460", Offset = "0x475D860", VA = "0x18475E460")]
			public GEFMHJFHKOD MJDPJDPCHBC()
			{
				return default(GEFMHJFHKOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class DNOMCEFHJIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public DNOMCEFHJIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x475DBF0", Offset = "0x475CFF0", VA = "0x18475DBF0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class NKMFGDEAIDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public NKMFGDEAIDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4764490", Offset = "0x4763890", VA = "0x184764490")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class EGOBBPJJFIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public EGOBBPJJFIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x475E3E0", Offset = "0x475D7E0", VA = "0x18475E3E0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction IMFIFDBIMNM;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction NGAPJBHGDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private KICCKOIDPBO FBDLPEHLAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer DFOCENHNIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer JIADBEGIKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private PLIJOECNIOG IDEOMAMPKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase EDDHBBFFICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService IENMAKNKOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private HHKCCBKAPBE CNNFEIHJDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DFJEOKIAIEF MIGKFHCPEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private ELIPEMMEIFN OCOPNGDLHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private KHFJEIHOPJL MBCIBOFNGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private NMLCFAIOCDK ABMHCNHPEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete KDBDLEAJFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint IACAHLNJKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint FGGEPMIEECJ;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private ELIPEMMEIFN GHPHKEKHMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PAGHHEHABKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x3A43600", Offset = "0x3A42A00", VA = "0x183A43600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool IEDOGAJLEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x3A44310", Offset = "0x3A43710", VA = "0x183A44310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool PBEPNNJPLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x3A429A0", Offset = "0x3A41DA0", VA = "0x183A429A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int EHACICKFFNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3A439D0", Offset = "0x3A42DD0", VA = "0x183A439D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int PPLLIDPKOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3A43120", Offset = "0x3A42520", VA = "0x183A43120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool CHIGAIKKHNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3A429D0", Offset = "0x3A41DD0", VA = "0x183A429D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool KPHEJEIJCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x3A44F30", Offset = "0x3A44330", VA = "0x183A44F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool IAGBGFOGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD7AB30", Offset = "0xD79F30", VA = "0x180D7AB30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xD7AB60", Offset = "0xD79F60", VA = "0x180D7AB60", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer MIAEHIKBGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3A43680", Offset = "0x3A42A80", VA = "0x183A43680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action GBCBJIMDKOI
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x3A43690", Offset = "0x3A42A90", VA = "0x183A43690", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x3A44270", Offset = "0x3A43670", VA = "0x183A44270", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action ADNPCOFOEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3A448E0", Offset = "0x3A43CE0", VA = "0x183A448E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3A429E0", Offset = "0x3A41DE0", VA = "0x183A429E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3A449E0", Offset = "0x3A43DE0", VA = "0x183A449E0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3A42E80", Offset = "0x3A42280", VA = "0x183A42E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3A43B30", Offset = "0x3A42F30", VA = "0x183A43B30")]
		private void HMOFDIEJHLD(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3A44F10", Offset = "0x3A44310", VA = "0x183A44F10")]
		private void PFPFPBBPDGG(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3A43E30", Offset = "0x3A43230", VA = "0x183A43E30")]
		private void IHIBAGEPFAJ(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3A44980", Offset = "0x3A43D80", VA = "0x183A44980", Slot = "14")]
		public IDisposable ODBIPMMOBCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3A42A80", Offset = "0x3A41E80", VA = "0x183A42A80", Slot = "9")]
		public IDisposable CJIJKNNJGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3A43A70", Offset = "0x3A42E70", VA = "0x183A43A70", Slot = "6")]
		public UndoAction HAEGFBMAPFO()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3A44700", Offset = "0x3A43B00", VA = "0x183A44700", Slot = "15")]
		public RedoAction MIKKEMNJLJG()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3A443B0", Offset = "0x3A437B0", VA = "0x183A443B0", Slot = "16")]
		public UndoAction KOONLPPNMFN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3A447C0", Offset = "0x3A43BC0", VA = "0x183A447C0", Slot = "7")]
		public RedoAction MIKKEMNJLJG(UndoAction MOOHJICILGA)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3A44470", Offset = "0x3A43870", VA = "0x183A44470", Slot = "8")]
		public UndoAction KOONLPPNMFN(RedoAction MOOHJICILGA)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3A43CB0", Offset = "0x3A430B0", VA = "0x183A43CB0")]
		public bool HOFLJALMCGD(BHILBDPNLIE DMKJPKCHIMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3A43730", Offset = "0x3A42B30", VA = "0x183A43730", Slot = "17")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3A42AE0", Offset = "0x3A41EE0", VA = "0x183A42AE0")]
		public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3A43860", Offset = "0x3A42C60", VA = "0x183A43860")]
		public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF FPEGOFLFPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3A440F0", Offset = "0x3A434F0", VA = "0x183A440F0")]
		public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3A42DE0", Offset = "0x3A421E0", VA = "0x183A42DE0")]
		private void DFKMOENDAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3A43140", Offset = "0x3A42540", VA = "0x183A43140")]
		private void EGJFCNKFFIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3A43660", Offset = "0x3A42A60", VA = "0x183A43660")]
		private void FJFFJKGMDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3A43D30", Offset = "0x3A43130", VA = "0x183A43D30")]
		private PEMAAMNAJKO IDCKDKMJMJJ()
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3A446E0", Offset = "0x3A43AE0", VA = "0x183A446E0")]
		private uint LLDKACHCJFB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3A43CF0", Offset = "0x3A430F0", VA = "0x183A43CF0")]
		private bool HOPBJEJDLBP(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3A43D10", Offset = "0x3A43110", VA = "0x183A43D10")]
		private bool ICFLFPDOEOH(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3A435A0", Offset = "0x3A429A0", VA = "0x183A435A0")]
		private RedoAction EOCMBBAJLIF(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3A42E20", Offset = "0x3A42220", VA = "0x183A42E20")]
		private UndoAction DLPEAKDNOAK(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3A432E0", Offset = "0x3A426E0", VA = "0x183A432E0")]
		private PEMAAMNAJKO EKNKCODIAPH(PEMAAMNAJKO GPNJNMLGIEN, ActionBuffer BHAPIDPHJEE, bool IKPNDPMFPFI)
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3A43780", Offset = "0x3A42B80", VA = "0x183A43780")]
		private void GFJGKDFJBDJ(Action GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x35D8ED0", Offset = "0x35D82D0", VA = "0x1835D8ED0")]
		private T GFJGKDFJBDJ<T>(Func<T> JHCJMGCFBCP)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3A439A0", Offset = "0x3A42DA0", VA = "0x183A439A0")]
		private LKPMGDMGEOD GIFJGJOFPKI(bool IKPNDPMFPFI, uint FLPPPNDNNNB)
		{
			return default(LKPMGDMGEOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3A45020", Offset = "0x3A44420", VA = "0x183A45020")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3A44590", Offset = "0x3A43990", VA = "0x183A44590")]
		[CompilerGenerated]
		private UndoAction KPAABNNJMKI()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3A42C70", Offset = "0x3A42070", VA = "0x183A42C70")]
		[CompilerGenerated]
		private RedoAction DACECIFLHPL()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3A43180", Offset = "0x3A42580", VA = "0x183A43180")]
		[CompilerGenerated]
		private UndoAction EHOPDFBNLPM()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GKIKIIPHIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public GKIKIIPHIPD(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F4A0", Offset = "0x3A3E8A0", VA = "0x183A3F4A0")]
	public static GKIKIIPHIPD LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T JHODGLELKOI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> DPECBKGPLOG<T>(int ONCBCCLEFOH, Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> MPJNBOANJGK<T>(Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class OEANOHNOMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public OEANOHNOMHP(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x36896F0", Offset = "0x3688AF0", VA = "0x1836896F0")]
	public static OEANOHNOMHP LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3269D60", Offset = "0x3269160", VA = "0x183269D60")]
	public T JHODGLELKOI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> DPECBKGPLOG<T>(int ONCBCCLEFOH, Allocator OPBLDCCKGEG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LCCMDDNOBCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public LCCMDDNOBCP(NativeArray<byte> PFCDNINKMFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3681D10", Offset = "0x3681110", VA = "0x183681D10")]
	public static LCCMDDNOBCP LOJIFGBJNLM(NativeArray<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2876720", Offset = "0x2875B20", VA = "0x182876720")]
	public void ALJMGCDBJBG<T>(in T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2876780", Offset = "0x2875B80", VA = "0x182876780")]
	public void LEFCNKJGCHI<T>(NativeArray<T> NKOMPJIJHJB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void OBMILPHCIJL<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LKJPPNCAKLD
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3683D10", Offset = "0x3683110", VA = "0x183683D10")]
	public static Span<byte> OLCIBMEHNBL(this NativeArray<byte> PFCDNINKMFA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3683B90", Offset = "0x3682F90", VA = "0x183683B90")]
	public static ReadOnlySpan<byte> OEKPMDLKKCJ(this NativeArray<byte> PFCDNINKMFA)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3683B10", Offset = "0x3682F10", VA = "0x183683B10")]
	public static NativeArray<byte> OALHLDFIGLH(this NativeArray<byte> PFCDNINKMFA, int IDCHKLCNMBN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3683A10", Offset = "0x3682E10", VA = "0x183683A10")]
	public static NativeArray<byte> FIOKLPGGCOI(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2878910", Offset = "0x2877D10", VA = "0x182878910")]
	public static NativeArray<byte> FIOKLPGGCOI<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x36839A0", Offset = "0x3682DA0", VA = "0x1836839A0")]
	public static NativeArray<byte> EAHICGLGAKH(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x28788B0", Offset = "0x2877CB0", VA = "0x1828788B0")]
	public static NativeArray<byte> EAHICGLGAKH<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3683A90", Offset = "0x3682E90", VA = "0x183683A90")]
	public static NativeArray<byte> NJDCDEMHAGN(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2878970", Offset = "0x2877D70", VA = "0x182878970")]
	public static NativeArray<byte> NJDCDEMHAGN<T>(this NativeArray<byte> PFCDNINKMFA, int OCCKKIPCFBH = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KJNFLEBIMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x15DDD00", Offset = "0x15DD100", VA = "0x1815DDD00")]
	public KJNFLEBIMHD(NativeList<byte> NHOGENNANEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DCE0", Offset = "0x3A4D0E0", VA = "0x183A4DCE0")]
	public static KJNFLEBIMHD LOJIFGBJNLM(NativeList<byte> PFCDNINKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void ALJMGCDBJBG<T>(in T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void LEFCNKJGCHI<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void OBMILPHCIJL<T>(NativeArray<T> JFBPNBNBHOE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	public class PropertyChangeNetworkRouter : LFPMKPLIAAM, DPDCPMNGBKH, FNFKCLIHOKN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[IMNMHIBEIDL]
		private DOKECPFELPH ABIHDCBCABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[IMNMHIBEIDL]
		private KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[IMNMHIBEIDL]
		private INBLIGACKIF IIIFHEOJELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[IMNMHIBEIDL]
		private PropertyChangeRouterService IENMAKNKOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private KICCKOIDPBO BEKIFNKENPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private CCIMPJPAJHL HBPEOGPLFPI;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public KICCKOIDPBO LJAACKPJCKM
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x369E0A0", Offset = "0x369D4A0", VA = "0x18369E0A0")]
		public KICCKOIDPBO.POAGGECHELL ABEBGHBCBGI()
		{
			return default(KICCKOIDPBO.POAGGECHELL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x369E920", Offset = "0x369DD20", VA = "0x18369E920", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x369EA80", Offset = "0x369DE80", VA = "0x18369EA80", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x369E0C0", Offset = "0x369D4C0", VA = "0x18369E0C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x369E330", Offset = "0x369D730", VA = "0x18369E330")]
		public void HAEGFBMAPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x369E310", Offset = "0x369D710", VA = "0x18369E310")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x369E440", Offset = "0x369D840", VA = "0x18369E440")]
		private void HOBIDCFJFHC(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x369ED00", Offset = "0x369E100", VA = "0x18369ED00")]
		private void PHMEIEFBAHO(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x369E2E0", Offset = "0x369D6E0", VA = "0x18369E2E0")]
		private void EDIJBNLFNNB(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x369E470", Offset = "0x369D870", VA = "0x18369E470")]
		private void HPNHJJMBODC(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x369E750", Offset = "0x369DB50", VA = "0x18369E750")]
		private void JEFDJMPFGLA(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x369E9A0", Offset = "0x369DDA0", VA = "0x18369E9A0")]
		private void OHDCLCGLONB(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x369E980", Offset = "0x369DD80", VA = "0x18369E980")]
		private void MHHBNKIPINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x369EA60", Offset = "0x369DE60", VA = "0x18369EA60")]
		private void OMGFPDIACBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x369E880", Offset = "0x369DC80", VA = "0x18369E880")]
		private void JHCOENKOCAI(CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3E780D0", Offset = "0x3E774D0", VA = "0x183E780D0", Slot = "6")]
		private void HLKHCGJKOIB<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, object MAFDHEKFLMG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	[LOJIIDJFKAI(typeof(PropertyChangeRouterService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void AEGFCBECNHF(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void JMDPFAEGJMH(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF CNMFKPMEJDC, LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void IMPPIOPKKDP(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AEGFCBECNHF BFPHDDBHNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JMDPFAEGJMH HLGHGIGOMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public IMPPIOPKKDP ACJHDFNHANL;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x369ED90", Offset = "0x369E190", VA = "0x18369ED90")]
		public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x369EDB0", Offset = "0x369E1B0", VA = "0x18369EDB0")]
		public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF FPEGOFLFPHJ, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x369EE20", Offset = "0x369E220", VA = "0x18369EE20")]
		public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG, bool LIGHCDFKHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(HOMCFAPIGOG))]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class HOMCFAPIGOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer IEGPGBKLAIF;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int HGPJFHAOHMD
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x37A44E0", Offset = "0x37A38E0", VA = "0x1837A44E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public DANDHMMDDOH[] OEHNIAOIBPD
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x37A4410", Offset = "0x37A3810", VA = "0x1837A4410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
			public HOMCFAPIGOG(ActionBuffer MPHDAOEKEHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x37A4530", Offset = "0x37A3930", VA = "0x1837A4530")]
			[CompilerGenerated]
			private DANDHMMDDOH NPHPNLEMNLA(PEMAAMNAJKO GPNJNMLGIEN)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class DANDHMMDDOH : FNFKCLIHOKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer IEGPGBKLAIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly PEMAAMNAJKO GPNJNMLGIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(CCIMPJPAJHL, string, object)> IPILJEFIHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private OEANOHNOMHP OJMODHIKFDB;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int HGPJFHAOHMD
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x37A3420", Offset = "0x37A2820", VA = "0x1837A3420")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(CCIMPJPAJHL, string, object)> HGPBPBGNLKC
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x37A3470", Offset = "0x37A2870", VA = "0x1837A3470")]
			public DANDHMMDDOH(ActionBuffer MPHDAOEKEHO, PEMAAMNAJKO GPNJNMLGIEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x37A3320", Offset = "0x37A2720", VA = "0x1837A3320")]
			private string KPEDCJCNFLM(CCIMPJPAJHL HBPEOGPLFPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x37A2FE0", Offset = "0x37A23E0", VA = "0x1837A2FE0")]
			private void HBGEMGCKMHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x35A5360", Offset = "0x35A4760", VA = "0x1835A5360", Slot = "4")]
			public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> FFEKEOCBAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<PEMAAMNAJKO> PEEPHJNAIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly HLBOLBJCEGO PLGAGPOFHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool ACDKBAAEDMN;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public GCHHEAHPBFM CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x36D2AC0", Offset = "0x36D1EC0", VA = "0x1836D2AC0")]
			get
			{
				return default(GCHHEAHPBFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x36D2B00", Offset = "0x36D1F00", VA = "0x1836D2B00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x36D2D00", Offset = "0x36D2100", VA = "0x1836D2D00")]
		public ActionBuffer(DEMIGFIOEMK GIPMDGDJGML, KJEMHJEIOEO ELCMIPNJFNP, bool ACDKBAAEDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x36D2030", Offset = "0x36D1430", VA = "0x1836D2030")]
		public bool BINFABIFFJD(out PEMAAMNAJKO GPNJNMLGIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x36D2680", Offset = "0x36D1A80", VA = "0x1836D2680")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x36D27B0", Offset = "0x36D1BB0", VA = "0x1836D27B0")]
		public PEMAAMNAJKO HAEGFBMAPFO(ALALGBOOEMC IPILJEFIHFH, HHKCCBKAPBE CNNFEIHJDFO, uint PHOHCIEDGIF)
		{
			return default(PEMAAMNAJKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x36D2A90", Offset = "0x36D1E90", VA = "0x1836D2A90")]
		public bool LDDPJIPNHAD(uint PHOHCIEDGIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x36D20C0", Offset = "0x36D14C0", VA = "0x1836D20C0")]
		public bool DLOPDOOGOAA(uint PHOHCIEDGIF, out PEMAAMNAJKO MOOHJICILGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x36D2B40", Offset = "0x36D1F40", VA = "0x1836D2B40")]
		public void PGHOCHJBOPI(PEMAAMNAJKO MOOHJICILGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x36D28F0", Offset = "0x36D1CF0", VA = "0x1836D28F0")]
		[Conditional("DEBUG_BUILD")]
		private void IGPEIHMAKID(PEMAAMNAJKO MOOHJICILGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x36D2320", Offset = "0x36D1720", VA = "0x1836D2320")]
		private void EKNKCODIAPH(PEMAAMNAJKO EFILEMBEAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x36D2430", Offset = "0x36D1830", VA = "0x1836D2430")]
		private void ENBBJHMPPNL(OEANOHNOMHP LMBOEDLDGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x36D2A30", Offset = "0x36D1E30", VA = "0x1836D2A30")]
		private void JIAGLDBMOAA(PEMAAMNAJKO GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x36D26F0", Offset = "0x36D1AF0", VA = "0x1836D26F0")]
		private OEANOHNOMHP GKDJAKPINJK(PEMAAMNAJKO GPNJNMLGIEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x36D22B0", Offset = "0x36D16B0", VA = "0x1836D22B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class HLBOLBJCEGO : FNFKCLIHOKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly DEMIGFIOEMK GIPMDGDJGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private IOLFAAOECPP ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private OEANOHNOMHP GLBHCLELODD;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x77FBB0", Offset = "0x77EFB0", VA = "0x18077FBB0")]
	public HLBOLBJCEGO(DEMIGFIOEMK GIPMDGDJGML, KJEMHJEIOEO ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x35CEFC0", Offset = "0x35CE3C0", VA = "0x1835CEFC0", Slot = "4")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> FCACNCCFEGJ, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A41090", Offset = "0x3A40490", VA = "0x183A41090")]
	public void OKJGILDOJEJ(CCIMPJPAJHL HBPEOGPLFPI, ref OEANOHNOMHP LMBOEDLDGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KICCKOIDPBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct POAGGECHELL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly KICCKOIDPBO GPFONCECPBK;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x47660F0", Offset = "0x47654F0", VA = "0x1847660F0")]
		public POAGGECHELL(KICCKOIDPBO GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x47660D0", Offset = "0x47654D0", VA = "0x1847660D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected ALALGBOOEMC IPILJEFIHFH;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ALALGBOOEMC HGPBPBGNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D490", Offset = "0x3A4C890", VA = "0x183A4D490")]
		get
		{
			return default(ALALGBOOEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool NEMJFHADGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D850", Offset = "0x3A4CC50", VA = "0x183A4D850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D860", Offset = "0x3A4CC60", VA = "0x183A4D860")]
	public KICCKOIDPBO(ALALGBOOEMC.GOPDKOCOPDJ EJKKBCGPHEE = ALALGBOOEMC.GOPDKOCOPDJ.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D4D0", Offset = "0x3A4C8D0", VA = "0x183A4D4D0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D390", Offset = "0x3A4C790", VA = "0x183A4D390")]
	public void CPIDOPDPFFB(IOLFAAOECPP ONBAMHPEIDG, FANLJDFBPKN MBIBEFAMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D4E0", Offset = "0x3A4C8E0", VA = "0x183A4D4E0")]
	public void GFMCIJHDPBA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D570", Offset = "0x3A4C970", VA = "0x183A4D570")]
	public void IMPGHFMPLKG(IOLFAAOECPP ONBAMHPEIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D650", Offset = "0x3A4CA50", VA = "0x183A4D650")]
	public void MHHBNKIPINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D750", Offset = "0x3A4CB50", VA = "0x183A4D750")]
	public void OMGFPDIACBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D480", Offset = "0x3A4C880", VA = "0x183A4D480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D360", Offset = "0x3A4C760", VA = "0x183A4D360")]
	public POAGGECHELL ABEBGHBCBGI()
	{
		return default(POAGGECHELL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct CCIMPJPAJHL : IComparable<CCIMPJPAJHL>, IEquatable<CCIMPJPAJHL>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly CCIMPJPAJHL BAMMNFGMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public IOLFAAOECPP ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public NMLCFAIOCDK MPKOBDPILJB;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x33D68F0", Offset = "0x33D5CF0", VA = "0x1833D68F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
	public CCIMPJPAJHL(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x36D7EB0", Offset = "0x36D72B0", VA = "0x1836D7EB0")]
	public void NDAJBIBMBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x36D7D00", Offset = "0x36D7100", VA = "0x1836D7D00", Slot = "4")]
	public int CompareTo(CCIMPJPAJHL IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x36D7EC0", Offset = "0x36D72C0", VA = "0x1836D7EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x36D7D40", Offset = "0x36D7140", VA = "0x1836D7D40", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x36D7DE0", Offset = "0x36D71E0", VA = "0x1836D7DE0", Slot = "5")]
	public bool Equals(CCIMPJPAJHL IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x36D7E30", Offset = "0x36D7230", VA = "0x1836D7E30")]
	public static bool GJOJIEKGOHO(CCIMPJPAJHL KPCLHBOMAKO, CCIMPJPAJHL NFBNADMIDIB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x36D7CB0", Offset = "0x36D70B0", VA = "0x1836D7CB0")]
	public static bool ALCENKEOHOJ(CCIMPJPAJHL KPCLHBOMAKO, CCIMPJPAJHL NFBNADMIDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x36D7E70", Offset = "0x36D7270", VA = "0x1836D7E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[MBALNPKLAGP(FOFKCKDBIPD.History)]
	public class GatherPropertiesForUndelete : JLMGPHFMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private DEMIGFIOEMK GIPMDGDJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private IOLFAAOECPP ONBAMHPEIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService HIOJLLPHGDG;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FF70", Offset = "0x3A3F370", VA = "0x183A3FF70")]
		public void NMKBKFBFGOP(IOLFAAOECPP ONBAMHPEIDG, DEMIGFIOEMK GIPMDGDJGML, HistoryService HIOJLLPHGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FEA0", Offset = "0x3A3F2A0", VA = "0x183A3FEA0", Slot = "4")]
		private void BFNDAHKEBGF(ANOLFBPNBLO LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, object MAFDHEKFLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JLIAFGMGBJM
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A49F10", Offset = "0x3A49310", VA = "0x183A49F10")]
	public static void JEFDJMPFGLA(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI, FANLJDFBPKN MBIBEFAMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A49E50", Offset = "0x3A49250", VA = "0x183A49E50")]
	public static void DAMGKKIFOLP(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A0C0", Offset = "0x3A494C0", VA = "0x183A4A0C0")]
	public static void OHDCLCGLONB(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A010", Offset = "0x3A49410", VA = "0x183A4A010")]
	public static void NDODCGNGBKC(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A110", Offset = "0x3A49510", VA = "0x183A4A110")]
	public static FANLJDFBPKN PMEBGDJLACB(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI)
	{
		return default(FANLJDFBPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2864D00", Offset = "0x2864100", VA = "0x182864D00")]
	public static T CKKFDFCIEFG<T>(ALALGBOOEMC IPILJEFIHFH, CCIMPJPAJHL HBPEOGPLFPI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2864D20", Offset = "0x2864120", VA = "0x182864D20")]
	public static T CKKFDFCIEFG<T>(ref OEANOHNOMHP ONIBEFDCPGD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A160", Offset = "0x3A49560", VA = "0x183A4A160")]
	public static FANLJDFBPKN PMEBGDJLACB(ref OEANOHNOMHP ONIBEFDCPGD)
	{
		return default(FANLJDFBPKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct ALALGBOOEMC : IEnumerable<CCIMPJPAJHL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum GOPDKOCOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct JJEGPKJBOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly HHKCCBKAPBE CNNFEIHJDFO;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x37A5110", Offset = "0x37A4510", VA = "0x1837A5110")]
		public JJEGPKJBOBJ(ALALGBOOEMC NHOGENNANEB, HHKCCBKAPBE CNNFEIHJDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x37A4800", Offset = "0x37A3C00", VA = "0x1837A4800")]
		public void CIHMCFCGMLC(NativeList<byte> DMEDBCCHBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x37A4B90", Offset = "0x37A3F90", VA = "0x1837A4B90")]
		private void FFCGDHECPCH(CCIMPJPAJHL HBPEOGPLFPI, ref LCCMDDNOBCP JBKCJIDDIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x37A4D40", Offset = "0x37A4140", VA = "0x1837A4D40")]
		private void KNCOLNDKFHN(CCIMPJPAJHL HBPEOGPLFPI, ref LCCMDDNOBCP JBKCJIDDIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x37A5020", Offset = "0x37A4420", VA = "0x1837A5020")]
		private NativeArray<byte> NPOCLKELBNJ(NativeList<byte> DMEDBCCHBBH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x37A4AA0", Offset = "0x37A3EA0", VA = "0x1837A4AA0")]
		private NativeArray<byte> EOKEFNHNLJG(NativeList<byte> DMEDBCCHBBH, int ONCBCCLEFOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x37A4DD0", Offset = "0x37A41D0", VA = "0x1837A4DD0")]
		private int LHNNBAPOCFM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x37A4BE0", Offset = "0x37A3FE0", VA = "0x1837A4BE0")]
		private bool KMIENPALEIC(CCIMPJPAJHL HBPEOGPLFPI, out NativeArray<byte> DPICFNCJJBK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MCEFNHMLAKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> ONIBEFDCPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly CCIMPJPAJHL GEMNKBDIDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int IDCHKLCNMBN;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x37A57E0", Offset = "0x37A4BE0", VA = "0x1837A57E0")]
		internal MCEFNHMLAKC(ALALGBOOEMC NHOGENNANEB, CCIMPJPAJHL GEMNKBDIDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x37A55C0", Offset = "0x37A49C0", VA = "0x1837A55C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x37A5560", Offset = "0x37A4960", VA = "0x1837A5560")]
		public void DEJKDLAENFK(NativeArray<byte> JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x37A5770", Offset = "0x37A4B70", VA = "0x1837A5770")]
		public void JFIENPDMMBG(NativeArray<byte> JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x37A57D0", Offset = "0x37A4BD0", VA = "0x1837A57D0")]
		public void KNCOLNDKFHN(in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x35AFA90", Offset = "0x35AEE90", VA = "0x1835AFA90")]
		public void KNCOLNDKFHN<T>(T JFBPNBNBHOE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x37A5650", Offset = "0x37A4A50", VA = "0x1837A5650")]
		private void FOAOMDBAOHB(int JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x37A56C0", Offset = "0x37A4AC0", VA = "0x1837A56C0")]
		private void FOAOMDBAOHB(in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x37A55F0", Offset = "0x37A49F0", VA = "0x1837A55F0")]
		private unsafe void FOAOMDBAOHB(void* FLICKNNFHAA, int ONCBCCLEFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x37A5560", Offset = "0x37A4960", VA = "0x1837A5560")]
		private void FOAOMDBAOHB(NativeArray<byte> NKOMPJIJHJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct EODLNMOBMDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private ALALGBOOEMC NHOGENNANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> ONIBEFDCPGD;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x37A3AB0", Offset = "0x37A2EB0", VA = "0x1837A3AB0")]
		internal EODLNMOBMDE(ALALGBOOEMC NHOGENNANEB, NativeArray<byte> ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x37A38B0", Offset = "0x37A2CB0", VA = "0x1837A38B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x37A37F0", Offset = "0x37A2BF0", VA = "0x1837A37F0")]
		public NativeArray<byte> DPECBKGPLOG(int ONCBCCLEFOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x37A39C0", Offset = "0x37A2DC0", VA = "0x1837A39C0")]
		public NativeArray<byte> MPJNBOANJGK()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x35ADFB0", Offset = "0x35AD3B0", VA = "0x1835ADFB0")]
		public T JHODGLELKOI<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x37A38C0", Offset = "0x37A2CC0", VA = "0x1837A38C0")]
		public void JHODGLELKOI(in EGIBCKCHGAP JFBPNBNBHOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct NMMMNIKHKPO : IEnumerator<CCIMPJPAJHL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<CCIMPJPAJHL> PFCDNINKMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public CCIMPJPAJHL CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x37A5A70", Offset = "0x37A4E70", VA = "0x1837A5A70", Slot = "4")]
			get
			{
				return default(CCIMPJPAJHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x37A5A20", Offset = "0x37A4E20", VA = "0x1837A5A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x37A5A60", Offset = "0x37A4E60", VA = "0x1837A5A60")]
		internal NMMMNIKHKPO(NativeList<CCIMPJPAJHL> NKOMPJIJHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x37A58E0", Offset = "0x37A4CE0", VA = "0x1837A58E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x37A59E0", Offset = "0x37A4DE0", VA = "0x1837A59E0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct FFDMOACLIHD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int DKKOKNDFFPL = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int PEPCOBLJABP = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int KEFAHABMMDO = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> ONIBEFDCPGD;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool DJGPJELDCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x37A3B20", Offset = "0x37A2F20", VA = "0x1837A3B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int JNPKCAINCAK
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x37A3B00", Offset = "0x37A2F00", VA = "0x1837A3B00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x1766E20", Offset = "0x1766220", VA = "0x181766E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public GOPDKOCOPDJ NEDNAFFINCN
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x37A3B10", Offset = "0x37A2F10", VA = "0x1837A3B10")]
			get
			{
				return default(GOPDKOCOPDJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x37A3C60", Offset = "0x37A3060", VA = "0x1837A3C60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool NEMJFHADGKO
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x37A3C50", Offset = "0x37A3050", VA = "0x1837A3C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x37A3C30", Offset = "0x37A3030", VA = "0x1837A3C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool FOMNBAIADFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x37A3AF0", Offset = "0x37A2EF0", VA = "0x1837A3AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x37A3C10", Offset = "0x37A3010", VA = "0x1837A3C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x37A3C70", Offset = "0x37A3070", VA = "0x1837A3C70")]
		public FFDMOACLIHD(GOPDKOCOPDJ EJKKBCGPHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x37A3BE0", Offset = "0x37A2FE0", VA = "0x1837A3BE0")]
		private int JLPNHBINJFC(int ELOEOOGBENM, int MBMFKBJGMMJ = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x37A3BA0", Offset = "0x37A2FA0", VA = "0x1837A3BA0")]
		private void HDECKBNAIGA(int ELOEOOGBENM, int JFBPNBNBHOE, int MBMFKBJGMMJ = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x37A3B60", Offset = "0x37A2F60", VA = "0x1837A3B60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int JIFFGBMDDME = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int MFPNPFGPMAI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly CCIMPJPAJHL BJIDDCOKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<CCIMPJPAJHL, int> NBLBCGJAPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<CCIMPJPAJHL> IPILJEFIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> PPNJBNFDHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> NEAHAHDJDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private FFDMOACLIHD OOMECLFFJIL;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool NEMJFHADGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x36D1DB0", Offset = "0x36D11B0", VA = "0x1836D1DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool HCBAHJPCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x36D12E0", Offset = "0x36D06E0", VA = "0x1836D12E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int JNPKCAINCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x36D1340", Offset = "0x36D0740", VA = "0x1836D1340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int AGGNFCFKFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x36D1390", Offset = "0x36D0790", VA = "0x1836D1390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x36D1350", Offset = "0x36D0750", VA = "0x1836D1350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x36D1300", Offset = "0x36D0700", VA = "0x1836D1300")]
	public static ALALGBOOEMC BFPHDDBHNEE(GOPDKOCOPDJ EJKKBCGPHEE = GOPDKOCOPDJ.Last, int BFAHCFGPDMG = 16, int FJBJGPOOKJP = 256)
	{
		return default(ALALGBOOEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x36D1EC0", Offset = "0x36D12C0", VA = "0x1836D1EC0")]
	private ALALGBOOEMC(GOPDKOCOPDJ EJKKBCGPHEE, int BFAHCFGPDMG, int FJBJGPOOKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x36D13D0", Offset = "0x36D07D0", VA = "0x1836D13D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x36D1680", Offset = "0x36D0A80", VA = "0x1836D1680")]
	public MCEFNHMLAKC HPNHJJMBODC(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(MCEFNHMLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x36D1950", Offset = "0x36D0D50", VA = "0x1836D1950")]
	public EODLNMOBMDE KABLBGKPIHD(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(EODLNMOBMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x36D1710", Offset = "0x36D0B10", VA = "0x1836D1710")]
	public bool JAMNKAIEBOF(CCIMPJPAJHL GEMNKBDIDNJ, out EODLNMOBMDE CBLJIOEJBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x36D1900", Offset = "0x36D0D00", VA = "0x1836D1900")]
	public bool JHPECFFAFKJ(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x36D1210", Offset = "0x36D0610", VA = "0x1836D1210")]
	public bool AIKPBEDHLII(CCIMPJPAJHL GEMNKBDIDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x36D1CC0", Offset = "0x36D10C0", VA = "0x1836D1CC0")]
	public void OJOFAMDPLDM(NativeList<byte> DMEDBCCHBBH, HHKCCBKAPBE CNNFEIHJDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3829A90", Offset = "0x3828E90", VA = "0x183829A90")]
	public T HNFKECKMLCA<T>(CCIMPJPAJHL GEMNKBDIDNJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x36D14B0", Offset = "0x36D08B0", VA = "0x1836D14B0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x36D11D0", Offset = "0x36D05D0", VA = "0x1836D11D0")]
	public NMMMNIKHKPO AHIPNMLLDNB()
	{
		return default(NMMMNIKHKPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x36D19E0", Offset = "0x36D0DE0", VA = "0x1836D19E0")]
	private void MPLAGIPNCOK(CCIMPJPAJHL GEMNKBDIDNJ, int IDCHKLCNMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x36D1BD0", Offset = "0x36D0FD0", VA = "0x1836D1BD0")]
	private void NDAJBIBMBCB(int BBOJBAGCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x36D1590", Offset = "0x36D0990", VA = "0x1836D1590")]
	private void HFGOMNHDNKM(CCIMPJPAJHL GEMNKBDIDNJ, int IDCHKLCNMBN, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3829A10", Offset = "0x3828E10", VA = "0x183829A10")]
	private static T HNFKECKMLCA<T>(NativeArray<byte> PFCDNINKMFA, int ELOEOOGBENM = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x36D1E00", Offset = "0x36D1200", VA = "0x1836D1E00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x36D1DC0", Offset = "0x36D11C0", VA = "0x1836D1DC0", Slot = "4")]
	private IEnumerator<CCIMPJPAJHL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class GAAMFIAGDKH<T> : DHDEFGPGMMG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x41F4EB0", Offset = "0x41F42B0", VA = "0x1841F4EB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x41F4FD0", Offset = "0x41F43D0", VA = "0x1841F4FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3748960", Offset = "0x3747D60", VA = "0x183748960")]
	public GAAMFIAGDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	internal class CleanupRigidbodyExImpl : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x36DB8A0", Offset = "0x36DACA0", VA = "0x1836DB8A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x36DB940", Offset = "0x36DAD40", VA = "0x1836DB940", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class DGIAAKMIKDF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery FJLHJPALFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x36E67D0", Offset = "0x36E5BD0", VA = "0x1836E67D0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x36E6700", Offset = "0x36E5B00", VA = "0x1836E6700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x36E6790", Offset = "0x36E5B90", VA = "0x1836E6790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public DGIAAKMIKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal class OIAEJHDACNH : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService CFGDKDNFKAH;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3689930", Offset = "0x3688D30", VA = "0x183689930", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x36898C0", Offset = "0x3688CC0", VA = "0x1836898C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public OIAEJHDACNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x36E9E20", Offset = "0x36E9220", VA = "0x1836E9E20", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x36E9980", Offset = "0x36E8D80", VA = "0x1836E9980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x36E9A10", Offset = "0x36E8E10", VA = "0x1836E9A10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[LOJIIDJFKAI(typeof(CullingBandService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class CullingBandService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<NativeListAsync<MMJDEMOFKKF>> EAPAOOBBMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x36E4EC0", Offset = "0x36E42C0", VA = "0x1836E4EC0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x36E4E50", Offset = "0x36E4250", VA = "0x1836E4E50")]
		public void MGAFJABNDCK(NativeListAsync<MMJDEMOFKKF> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x36E49E0", Offset = "0x36E3DE0", VA = "0x1836E49E0")]
		public void KGABBKPALAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x36E4870", Offset = "0x36E3C70", VA = "0x1836E4870", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x36E4F60", Offset = "0x36E4360", VA = "0x1836E4F60")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[LOJIIDJFKAI(typeof(LKGNBGJGHAA), new string[] { })]
	public class PhysicsService : DPDCPMNGBKH, FPHKGEBJIKC, LKGNBGJGHAA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly FADHLPPNOEF PAPLKBBKEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private DPHIHEMGLPB ADPNILAIFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService FMKAHEFPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::DEHNDDIKMEN<DIKGCJEICCJ> LKCFENLBOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<NFJEDPPAJMK, DIKGCJEICCJ> INAMCGAFDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x369B9D0", Offset = "0x369ADD0", VA = "0x18369B9D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x369B2E0", Offset = "0x369A6E0", VA = "0x18369B2E0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x369BA70", Offset = "0x369AE70", VA = "0x18369BA70", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x369B730", Offset = "0x369AB30", VA = "0x18369B730", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x369B510", Offset = "0x369A910", VA = "0x18369B510", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x369B440", Offset = "0x369A840", VA = "0x18369B440", Slot = "8")]
		public bool AMCAKIHCKGA(NFJEDPPAJMK OOGHONKGHEE, out Collider NCCADNBJIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x369B670", Offset = "0x369AA70", VA = "0x18369B670")]
		private void FDKAHKLMLOJ(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x369B380", Offset = "0x369A780", VA = "0x18369B380", Slot = "9")]
		public void AEBBADBLPIF(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[LOJIIDJFKAI(typeof(MCAEHJPOCLP), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class RbexService : DPDCPMNGBKH, MCAEHJPOCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private LEPGAPILAAM ACPBAMPBPGO;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x36A23F0", Offset = "0x36A17F0", VA = "0x1836A23F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x36A3BA0", Offset = "0x36A2FA0", VA = "0x1836A3BA0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x36A1060", Offset = "0x36A0460", VA = "0x1836A1060", Slot = "6")]
		public MGDHAHFMJMO DBAHGJMLEGP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x36A0BE0", Offset = "0x369FFE0", VA = "0x1836A0BE0", Slot = "5")]
		public void BMNPJDBGHKP(NFJEDPPAJMK OOGHONKGHEE, MGDHAHFMJMO JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x36A3920", Offset = "0x36A2D20", VA = "0x1836A3920", Slot = "34")]
		public CollisionDetectionMode ODOCPGENJJP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x36A0E50", Offset = "0x36A0250", VA = "0x1836A0E50", Slot = "35")]
		public void CLNFHJJLLKH(NFJEDPPAJMK OOGHONKGHEE, CollisionDetectionMode JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x36A2CA0", Offset = "0x36A20A0", VA = "0x1836A2CA0", Slot = "36")]
		public PPGNAFCKNOL LFBLAICLCNJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(PPGNAFCKNOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x36A0B40", Offset = "0x369FF40", VA = "0x1836A0B40", Slot = "37")]
		public void AIILPFAOLOH(NFJEDPPAJMK OOGHONKGHEE, PPGNAFCKNOL JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x36A1840", Offset = "0x36A0C40", VA = "0x1836A1840", Slot = "38")]
		public bool FBGNHJDEDMJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x36A18A0", Offset = "0x36A0CA0", VA = "0x1836A18A0", Slot = "39")]
		public void FEFBHBDEPKJ(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x36A33E0", Offset = "0x36A27E0", VA = "0x1836A33E0", Slot = "40")]
		public NFJEDPPAJMK MNEECNHBEJG(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x36A2BB0", Offset = "0x36A1FB0", VA = "0x1836A2BB0", Slot = "41")]
		public void KLFLFGBKAAA(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x36A3460", Offset = "0x36A2860", VA = "0x1836A3460", Slot = "42")]
		public NFJEDPPAJMK MODGPLDICAF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x36A29C0", Offset = "0x36A1DC0", VA = "0x1836A29C0", Slot = "43")]
		public void KKGLFGKJMPP(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x36A1A70", Offset = "0x36A0E70", VA = "0x1836A1A70", Slot = "7")]
		public void FIMHIJJNHNG(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x36A2F90", Offset = "0x36A2390", VA = "0x1836A2F90", Slot = "8")]
		public void LNGINODJAIF(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x36A1C80", Offset = "0x36A1080", VA = "0x1836A1C80", Slot = "9")]
		public int FJOEJBEAIPG(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x36A2720", Offset = "0x36A1B20", VA = "0x1836A2720", Slot = "10")]
		public NFJEDPPAJMK JIABEAAPFBL(NFJEDPPAJMK OOGHONKGHEE, int BELCAJFDAHD)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x36A2A40", Offset = "0x36A1E40", VA = "0x1836A2A40", Slot = "11")]
		public void KKKGMHHOEFC(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x36A1680", Offset = "0x36A0A80", VA = "0x1836A1680", Slot = "12")]
		public void EMFHKCCJCMI(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA, NFJEDPPAJMK JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x36A1B80", Offset = "0x36A0F80", VA = "0x1836A1B80", Slot = "13")]
		public void FIOINIIBKGK(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x36A3CB0", Offset = "0x36A30B0", VA = "0x1836A3CB0", Slot = "14")]
		public bool PIDIPMJBGDP(NFJEDPPAJMK OOGHONKGHEE, out NFJEDPPAJMK JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x36A2940", Offset = "0x36A1D40", VA = "0x1836A2940", Slot = "15")]
		public void KCCGBFPMPGL(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x36A1F20", Offset = "0x36A1320", VA = "0x1836A1F20", Slot = "16")]
		public bool GGNEONIMNFF(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x36A3360", Offset = "0x36A2760", VA = "0x1836A3360", Slot = "17")]
		public void MJNLDDJEFNO(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x36A3730", Offset = "0x36A2B30", VA = "0x1836A3730", Slot = "18")]
		public bool OAIBMAKBCBG(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x36A2B30", Offset = "0x36A1F30", VA = "0x1836A2B30", Slot = "26")]
		public float3 KKNFCLNHIPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x36A2250", Offset = "0x36A1650", VA = "0x1836A2250", Slot = "27")]
		public void HBJMIFMDHJH(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x36A3B40", Offset = "0x36A2F40", VA = "0x1836A3B40", Slot = "28")]
		public float PCHNAMNKKHL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x36A0C90", Offset = "0x36A0090", VA = "0x1836A0C90", Slot = "29")]
		public void CGGJFFODFCK(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x36A1280", Offset = "0x36A0680", VA = "0x1836A1280", Slot = "30")]
		public float DPJIHEDKBFH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x36A1DF0", Offset = "0x36A11F0", VA = "0x1836A1DF0", Slot = "31")]
		public void FPOBCCILBBI(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x36A36D0", Offset = "0x36A2AD0", VA = "0x1836A36D0", Slot = "32")]
		public bool NJEBDEKANKC(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x36A2080", Offset = "0x36A1480", VA = "0x1836A2080", Slot = "33")]
		public void GHJLDOAMDAN(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x36A1200", Offset = "0x36A0600", VA = "0x1836A1200", Slot = "19")]
		public void DPAICFKBHKC(NFJEDPPAJMK OOGHONKGHEE, float3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x36A2D40", Offset = "0x36A2140", VA = "0x1836A2D40", Slot = "20")]
		public bool LHMFNDPLNFP(NFJEDPPAJMK OOGHONKGHEE, out float3 JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x36A15B0", Offset = "0x36A09B0", VA = "0x1836A15B0", Slot = "21")]
		public void EGFNJCAIHME(NFJEDPPAJMK OOGHONKGHEE, quaternion JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x36A3570", Offset = "0x36A2970", VA = "0x1836A3570", Slot = "22")]
		public bool NFHMKOEAFNH(NFJEDPPAJMK OOGHONKGHEE, out quaternion JFBPNBNBHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x36A12E0", Offset = "0x36A06E0", VA = "0x1836A12E0", Slot = "23")]
		public bool ECJJCHNJEBA(NFJEDPPAJMK OOGHONKGHEE, out float3 MDMEPBIDEMF, out quaternion FPBHBLNIIHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x36A1EC0", Offset = "0x36A12C0", VA = "0x1836A1EC0", Slot = "44")]
		public GDPCJHNBEPD GEKJIGMIAOF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(GDPCJHNBEPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x36A0AD0", Offset = "0x369FED0", VA = "0x1836A0AD0", Slot = "45")]
		public void AELADANKEEK(NFJEDPPAJMK OOGHONKGHEE, GDPCJHNBEPD JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x36A17B0", Offset = "0x36A0BB0", VA = "0x1836A17B0", Slot = "72")]
		public void EMPDLMHGOKL(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x36A22D0", Offset = "0x36A16D0", VA = "0x1836A22D0", Slot = "73")]
		public void HDIPLCIMADM(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x36A0D60", Offset = "0x36A0160", VA = "0x1836A0D60", Slot = "74")]
		public bool CJLENBHBNJH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x36A2360", Offset = "0x36A1760", VA = "0x1836A2360", Slot = "81")]
		public void HEFMFPDAIFJ(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x36A0F40", Offset = "0x36A0340", VA = "0x1836A0F40", Slot = "82")]
		public void CODHLLPMAMF(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x36A0EC0", Offset = "0x36A02C0", VA = "0x1836A0EC0", Slot = "83")]
		public bool CMLLPKAFDDI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x36A3200", Offset = "0x36A2600", VA = "0x1836A3200", Slot = "84")]
		public IEnumerable<object> MAIAADFKPJN(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x36A3C50", Offset = "0x36A3050", VA = "0x1836A3C50", Slot = "46")]
		public bool PELIGOEKBAF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x36A3510", Offset = "0x36A2910", VA = "0x1836A3510", Slot = "47")]
		public void NEJMCBJEGNJ(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x36A1620", Offset = "0x36A0A20", VA = "0x1836A1620", Slot = "48")]
		public bool EHMAMBIGBLJ(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x36A2C30", Offset = "0x36A2030", VA = "0x1836A2C30", Slot = "49")]
		public void LEHIBIEOLCL(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x36A2F30", Offset = "0x36A2330", VA = "0x1836A2F30", Slot = "50")]
		public bool LLEKMNNLFFM(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x36A2410", Offset = "0x36A1810", VA = "0x1836A2410", Slot = "51")]
		public void HPOIKIHCHKK(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x36A39F0", Offset = "0x36A2DF0", VA = "0x1836A39F0", Slot = "52")]
		public RigidbodyConstraints OGPNEFJKAPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x36A1C10", Offset = "0x36A1010", VA = "0x1836A1C10", Slot = "53")]
		public void FJJAKNBEOJP(NFJEDPPAJMK OOGHONKGHEE, RigidbodyConstraints JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x36A3300", Offset = "0x36A2700", VA = "0x1836A3300", Slot = "54")]
		public float MFGIABEJMEL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x36A3E10", Offset = "0x36A3210", VA = "0x1836A3E10", Slot = "55")]
		public void PJHEDPBECDO(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x36A3AE0", Offset = "0x36A2EE0", VA = "0x1836A3AE0", Slot = "56")]
		public float PBNAAGMIAPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x36A26B0", Offset = "0x36A1AB0", VA = "0x1836A26B0", Slot = "57")]
		public void JEPFOOOBHMG(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x36A3E80", Offset = "0x36A3280", VA = "0x1836A3E80", Slot = "58")]
		public bool POANHIOCLGH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x36A3980", Offset = "0x36A2D80", VA = "0x1836A3980", Slot = "59")]
		public void OFEOCGHEIJM(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x36A1170", Offset = "0x36A0570", VA = "0x1836A1170", Slot = "60")]
		public bool DIJIGKBMJHH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x36A2840", Offset = "0x36A1C40", VA = "0x1836A2840", Slot = "61")]
		public void JKIGBAAGNJA(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x36A2580", Offset = "0x36A1980", VA = "0x1836A2580", Slot = "62")]
		public int IKJHGLILIJL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x36A2480", Offset = "0x36A1880", VA = "0x1836A2480", Slot = "63")]
		public void IEHBKFNOKMJ(NFJEDPPAJMK OOGHONKGHEE, int JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x36A2EA0", Offset = "0x36A22A0", VA = "0x1836A2EA0", Slot = "64")]
		public Rigidbody LIGLOJGGGFI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x36A30A0", Offset = "0x36A24A0", VA = "0x1836A30A0", Slot = "65")]
		public void MACIJBHOPDB(NFJEDPPAJMK OOGHONKGHEE, Rigidbody JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x36A3A50", Offset = "0x36A2E50", VA = "0x1836A3A50", Slot = "75")]
		public void OOBBBPJENLK(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x36A3890", Offset = "0x36A2C90", VA = "0x1836A3890", Slot = "76")]
		public void ODAOKNAMNPO(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x36A10F0", Offset = "0x36A04F0", VA = "0x1836A10F0", Slot = "77")]
		public bool DHDBMJGNKEH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x36A28B0", Offset = "0x36A1CB0", VA = "0x1836A28B0", Slot = "66")]
		public object KBCPJMDLLFO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x36A1910", Offset = "0x36A0D10", VA = "0x1836A1910", Slot = "67")]
		public void FFAOIHCKNLG(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x36A24F0", Offset = "0x36A18F0", VA = "0x1836A24F0", Slot = "68")]
		public object IJLJCLHOIIF(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x36A20F0", Offset = "0x36A14F0", VA = "0x1836A20F0", Slot = "69")]
		public void GIDIPIDOPGM(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x36A1550", Offset = "0x36A0950", VA = "0x1836A1550", Slot = "70")]
		public float EELAIMBFGEK(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x36A0DE0", Offset = "0x36A01E0", VA = "0x1836A0DE0", Slot = "71")]
		public void CJOOFKCBJCD(NFJEDPPAJMK OOGHONKGHEE, float JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x36A0FD0", Offset = "0x36A03D0", VA = "0x1836A0FD0", Slot = "78")]
		public void CPOMNIFIMEH(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x36A0A40", Offset = "0x369FE40", VA = "0x1836A0A40", Slot = "79")]
		public void ADPJKPCEEGN(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x36A1D70", Offset = "0x36A1170", VA = "0x1836A1D70", Slot = "80")]
		public bool FLGGNOAJFBP(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x36A1E60", Offset = "0x36A1260", VA = "0x1836A1E60", Slot = "24")]
		public void GCIJILELHNN(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x36A0D00", Offset = "0x36A0100", VA = "0x1836A0D00", Slot = "25")]
		public void CJFAJCNLIBK(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3CF84B0", Offset = "0x3CF78B0", VA = "0x183CF84B0")]
		private void MHDOJJHCJKM<T>(NFJEDPPAJMK OOGHONKGHEE, bool JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7F40", Offset = "0x3CF7340", VA = "0x183CF7F40")]
		private bool FNMHKDLACLI<T>(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7330", Offset = "0x3CF6730", VA = "0x183CF7330")]
		private void BCBAFCFKBLF<T>(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8610", Offset = "0x3CF7A10", VA = "0x183CF8610")]
		private bool POEOEOCKJOD<TC, TV>(NFJEDPPAJMK OOGHONKGHEE, Func<TC, TV> JHCJMGCFBCP, out TV JFBPNBNBHOE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3CF72B0", Offset = "0x3CF66B0", VA = "0x183CF72B0")]
		private bool POEOEOCKJOD<T>(NFJEDPPAJMK OOGHONKGHEE, out T JFBPNBNBHOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8060", Offset = "0x3CF7460", VA = "0x183CF8060")]
		private T LLDFALJIFCH<T>(NFJEDPPAJMK OOGHONKGHEE) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7390", Offset = "0x3CF6790", VA = "0x183CF7390")]
		private void BGDLHPIBHGK<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3CF78E0", Offset = "0x3CF6CE0", VA = "0x183CF78E0")]
		private void DCFEDLLGHBK<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3CF72B0", Offset = "0x3CF66B0", VA = "0x183CF72B0")]
		private bool APDEIBNIKJF<T>(NFJEDPPAJMK OOGHONKGHEE, out T JFBPNBNBHOE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3CF85B0", Offset = "0x3CF79B0", VA = "0x183CF85B0")]
		private T PEDBKCDGEPG<T>(NFJEDPPAJMK OOGHONKGHEE) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF72B0", Offset = "0x3CF66B0", VA = "0x183CF72B0")]
		private void FPIFFMALFOD<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8500", Offset = "0x3CF7900", VA = "0x183CF8500")]
		private void NNLPNDPOLMH<T>(NFJEDPPAJMK OOGHONKGHEE, T JFBPNBNBHOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x36A11D0", Offset = "0x36A05D0", VA = "0x1836A11D0")]
		private NFJEDPPAJMK DNKKDOLDNIE(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x36A25E0", Offset = "0x36A19E0", VA = "0x1836A25E0")]
		private DynamicBuffer<Entity> JBFEJAKGNJD(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7FA0", Offset = "0x3CF73A0", VA = "0x183CF7FA0")]
		private void KLAKNCFPJPD<T>(NFJEDPPAJMK OOGHONKGHEE, object JFBPNBNBHOE, Func<object, T> JHCJMGCFBCP) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void HBGEMGCKMHE<T>(ref global::GGEJOAKONHH<T> BAMMKKCEACG) where T : struct, NBKDCFKNMHI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void HBGEMGCKMHE<TC, TV>(ref global::IMJKKCAJKJE<TC, TV> BAMMKKCEACG) where TC : struct, NBKDCFKNMHI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[LOJIIDJFKAI(typeof(KinematicSleepChangeService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class KinematicSleepChangeService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class OAHFJGHGGKL : IEnumerable<MGDHAHFMJMO>, IEnumerable, IEnumerator<MGDHAHFMJMO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private MGDHAHFMJMO <>2__current;

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
			private MGDHAHFMJMO System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public OAHFJGHGGKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x4764B90", Offset = "0x4763F90", VA = "0x184764B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x4764850", Offset = "0x4763C50", VA = "0x184764850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x4764C10", Offset = "0x4764010", VA = "0x184764C10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4764B50", Offset = "0x4763F50", VA = "0x184764B50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x4764AA0", Offset = "0x4763EA0", VA = "0x184764AA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MGDHAHFMJMO> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x4764AA0", Offset = "0x4763EA0", VA = "0x184764AA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> FPKCOABGINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A50820", Offset = "0x3A4FC20", VA = "0x183A50820", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A50700", Offset = "0x3A4FB00", VA = "0x183A50700")]
		public void MGAFJABNDCK(NativeArray<Entity> GNGEEFEGDCP, bool PGIEHHJIIFL, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A504F0", Offset = "0x3A4F8F0", VA = "0x183A504F0")]
		public void KGABBKPALAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A4FB50", Offset = "0x3A4EF50", VA = "0x183A4FB50")]
		private void BAEJHPPJHIF(NativeArray<Entity> GNGEEFEGDCP, bool PGIEHHJIIFL, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A50460", Offset = "0x3A4F860", VA = "0x183A50460")]
		[IteratorStateMachine(typeof(OAHFJGHGGKL))]
		private IEnumerable<MGDHAHFMJMO> HHGFAEDKPBK(NativeArray<Entity> GNGEEFEGDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A50310", Offset = "0x3A4F710", VA = "0x183A50310", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A508C0", Offset = "0x3A4FCC0", VA = "0x183A508C0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[LOJIIDJFKAI(typeof(KHFJEIHOPJL), new string[] { })]
public class DIHMLMHBMFI : KHFJEIHOPJL, IEnumerable<GKFDLLIKKMD>, IEnumerable, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[IMNMHIBEIDL]
	private MHNMKOLPOKF ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> FDJOGCMPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NBEJBJMNGCG KNGEPEIOMBA;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x36E7220", Offset = "0x36E6620", VA = "0x1836E7220", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public GKFDLLIKKMD OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x36E7200", Offset = "0x36E6600", VA = "0x1836E7200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GKFDLLIKKMD OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x36E7200", Offset = "0x36E6600", VA = "0x1836E7200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x36E71B0", Offset = "0x36E65B0", VA = "0x1836E71B0", Slot = "11")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x36E7320", Offset = "0x36E6720", VA = "0x1836E7320", Slot = "12")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x36E6F10", Offset = "0x36E6310", VA = "0x1836E6F10")]
	private void JLEPHBJLNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x30FB2A0", Offset = "0x30FA6A0", VA = "0x1830FB2A0")]
	private string KLKNOGHKLGI(string IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x36E7240", Offset = "0x36E6640", VA = "0x1836E7240", Slot = "7")]
	public GKFDLLIKKMD MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x36E6B30", Offset = "0x36E5F30", VA = "0x1836E6B30")]
	private bool GIOOOLIFLGK(Type JHMACGKJPAP, string IGHJIHNAPBA, out GKFDLLIKKMD IPFKDLFGNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x36E6DE0", Offset = "0x36E61E0", VA = "0x1836E6DE0", Slot = "8")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x36E6EF0", Offset = "0x36E62F0", VA = "0x1836E6EF0", Slot = "9")]
	public IEnumerator<GKFDLLIKKMD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x36E6EF0", Offset = "0x36E62F0", VA = "0x1836E6EF0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x36E73A0", Offset = "0x36E67A0", VA = "0x1836E73A0")]
	public DIHMLMHBMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[DefaultMember("Item")]
public interface HHKCCBKAPBE
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNPOONDBPKB(NMLCFAIOCDK LIKFEBDBPON, out int PCAHMJECHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[LOJIIDJFKAI(typeof(HHKCCBKAPBE), new string[] { })]
public class JOBPHLPMHND : DPDCPMNGBKH, FPHKGEBJIKC, HHKCCBKAPBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[IMNMHIBEIDL]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<NMLCFAIOCDK, int> FNPHJDDFFHP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A4A790", Offset = "0x3A49B90", VA = "0x183A4A790", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A710", Offset = "0x3A49B10", VA = "0x183A4A710", Slot = "6")]
	public bool CNPOONDBPKB(NMLCFAIOCDK LIKFEBDBPON, out int PCAHMJECHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AA60", Offset = "0x3A49E60", VA = "0x183A4AA60", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A780", Offset = "0x3A49B80", VA = "0x183A4A780", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A7F0", Offset = "0x3A49BF0", VA = "0x183A4A7F0")]
	private void OKAMHJBHMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AAC0", Offset = "0x3A49EC0", VA = "0x183A4AAC0")]
	public JOBPHLPMHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[LOJIIDJFKAI(typeof(KJEMHJEIOEO), new string[] { })]
[DefaultMember("Item")]
public class IPGEOCGLAEL : KJEMHJEIOEO, IEnumerable<ICAMIIGEPFO>, IEnumerable, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, FNFKCLIHOKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private ICAMIIGEPFO[] HBOOJFCEDKO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A47FB0", Offset = "0x3A473B0", VA = "0x183A47FB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ICAMIIGEPFO OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A47C80", Offset = "0x3A47080", VA = "0x183A47C80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ICAMIIGEPFO OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A47C80", Offset = "0x3A47080", VA = "0x183A47C80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "10")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A480F0", Offset = "0x3A474F0", VA = "0x183A480F0", Slot = "11")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "12")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A47FC0", Offset = "0x3A473C0", VA = "0x183A47FC0", Slot = "6")]
	public ICAMIIGEPFO MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A47E00", Offset = "0x3A47200", VA = "0x183A47E00", Slot = "7")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A47ED0", Offset = "0x3A472D0", VA = "0x183A47ED0", Slot = "8")]
	public IEnumerator<ICAMIIGEPFO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A48390", Offset = "0x3A47790", VA = "0x183A48390", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x35DC720", Offset = "0x35DBB20", VA = "0x1835DC720", Slot = "13")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A47CC0", Offset = "0x3A470C0", VA = "0x183A47CC0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public IPGEOCGLAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A47C80", Offset = "0x3A47080", VA = "0x183A47C80")]
	[CompilerGenerated]
	private ICAMIIGEPFO BDHEOKJIHOE(int BHOLCDOGKAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[LOJIIDJFKAI(typeof(PMEGIOPIHFM), new string[] { })]
[DefaultMember("Item")]
public class NNEPNHKNJKA : PMEGIOPIHFM, IEnumerable<FNOOJMKBHOH>, IEnumerable, DPDCPMNGBKH, FPHKGEBJIKC, FNFKCLIHOKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[IMNMHIBEIDL]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private FNOOJMKBHOH[] HBOOJFCEDKO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x3689220", Offset = "0x3688620", VA = "0x183689220", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public FNOOJMKBHOH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x3688C50", Offset = "0x3688050", VA = "0x183688C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FNOOJMKBHOH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3688C50", Offset = "0x3688050", VA = "0x183688C50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3689390", Offset = "0x3688790", VA = "0x183689390", Slot = "9")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3688FC0", Offset = "0x36883C0", VA = "0x183688FC0", Slot = "10")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3688C60", Offset = "0x3688060", VA = "0x183688C60")]
	private FNOOJMKBHOH BKCFICCGMPC(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x3689270", Offset = "0x3688670", VA = "0x183689270", Slot = "6")]
	public FNOOJMKBHOH MECKAOHJMHD(CNFMDAKFLAB CGCMEEFENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3688DE0", Offset = "0x36881E0", VA = "0x183688DE0", Slot = "14")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB CGCMEEFENJL)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3688EB0", Offset = "0x36882B0", VA = "0x183688EB0", Slot = "7")]
	public IEnumerator<FNOOJMKBHOH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3688EB0", Offset = "0x36882B0", VA = "0x183688EB0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x3897DC0", Offset = "0x38971C0", VA = "0x183897DC0", Slot = "11")]
	public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, [Optional] object MAFDHEKFLMG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3688D40", Offset = "0x3688140", VA = "0x183688D40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NNEPNHKNJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3688C50", Offset = "0x3688050", VA = "0x183688C50")]
	[CompilerGenerated]
	private FNOOJMKBHOH BDHEOKJIHOE(int BHOLCDOGKAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(MHNMKOLPOKF), new string[] { })]
internal class MHNMKOLPOKF : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private KHFJEIHOPJL MBCIBOFNGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private PMEGIOPIHFM GGAKPCLFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private KJEMHJEIOEO BPHAFAOANOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::DGIKCDEPKDI<BCNEEGFPPIH> MBGKNDLKFDJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public NBEJBJMNGCG MLHOKFIPNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x1806E1830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3685B90", Offset = "0x3684F90", VA = "0x183685B90", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3685830", Offset = "0x3684C30", VA = "0x183685830")]
	private void AGNKCEEGCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x33ACA10", Offset = "0x33ABE10", VA = "0x1833ACA10")]
	public T EHHFFPPDBPA<T>() where T : BCNEEGFPPIH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x36859F0", Offset = "0x3684DF0", VA = "0x1836859F0")]
	public GKFDLLIKKMD LPKJPMGMJLK(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::DEHNDDIKMEN<T> LPKJPMGMJLK<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3685AC0", Offset = "0x3684EC0", VA = "0x183685AC0")]
	public FNOOJMKBHOH NBCFHJCHPJO(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x33BB8B0", Offset = "0x33BACB0", VA = "0x1833BB8B0")]
	public global::EALCHGCDDPJ<T> NBCFHJCHPJO<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3685920", Offset = "0x3684D20", VA = "0x183685920")]
	public ICAMIIGEPFO GBOLGOLDFDH(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::GEAJGNGECAJ<T> GBOLGOLDFDH<T>(CNFMDAKFLAB IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public MHNMKOLPOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class NCCNAJJBFBO
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3893CA0", Offset = "0x38930A0", VA = "0x183893CA0")]
	public static global::DEHNDDIKMEN<T> LPKJPMGMJLK<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::EALCHGCDDPJ<T> NBCFHJCHPJO<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::GEAJGNGECAJ<T> GBOLGOLDFDH<T>(this MHNMKOLPOKF MEGLNFKLOHK, global::PHNOBDPMINP<T> IGHJIHNAPBA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(KIMMPHOEFCL), new string[] { })]
public class KIMMPHOEFCL : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private DEMIGFIOEMK GIPMDGDJGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private NMLCFAIOCDK[] IPNJKLGEGGB;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DA50", Offset = "0x3A4CE50", VA = "0x183A4DA50", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D930", Offset = "0x3A4CD30", VA = "0x183A4D930")]
	public void ONDFMJFBIEL(IOLFAAOECPP IOCKLNNJMIA, bool AFEBCJCKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public KIMMPHOEFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[LOJIIDJFKAI(typeof(NAHABAIDKKI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public sealed class NAHABAIDKKI : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class CJIMMDCKAGN : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
		[DebuggerHidden]
		public CJIMMDCKAGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x475CFA0", Offset = "0x475C3A0", VA = "0x18475CFA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x475CBF0", Offset = "0x475BFF0", VA = "0x18475CBF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x475D020", Offset = "0x475C420", VA = "0x18475D020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x475CF60", Offset = "0x475C360", VA = "0x18475CF60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x475CED0", Offset = "0x475C2D0", VA = "0x18475CED0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x475CED0", Offset = "0x475C2D0", VA = "0x18475CED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string JLPCCDCONOB = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, AEMFLFLGAKF> FIAOFMOLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> GFBJBCAKPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private BMGHPMCGENG BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private JCGKPCPJOOI BDAAELOCEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::HKEMDJIFJBH<AEMFLFLGAKF> FMDBKJDEFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject KKHLDKDGGLB;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x3687F60", Offset = "0x3687360", VA = "0x183687F60", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3687160", Offset = "0x3686560", VA = "0x183687160", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x36869F0", Offset = "0x3685DF0", VA = "0x1836869F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3686F70", Offset = "0x3686370", VA = "0x183686F70")]
	private void HAAMBKCKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3687B30", Offset = "0x3686F30", VA = "0x183687B30")]
	internal void ODLECDMINBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x36874D0", Offset = "0x36868D0", VA = "0x1836874D0")]
	private void KKOJFBLMDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x36868A0", Offset = "0x3685CA0", VA = "0x1836868A0")]
	private void AFMNGDDPDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x36869A0", Offset = "0x3685DA0", VA = "0x1836869A0")]
	[IteratorStateMachine(typeof(CJIMMDCKAGN))]
	private IEnumerable<RRCustomPropTag> CKIGLNPKICL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x36876B0", Offset = "0x3686AB0", VA = "0x1836876B0")]
	private void LEAFPMEAEME(NFJEDPPAJMK OOGHONKGHEE, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3687390", Offset = "0x3686790", VA = "0x183687390")]
	private void KJDPCLCGNLB(SerializableGuid JHHPNHDNIID, GameObject OOKBNBHDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3686BE0", Offset = "0x3685FE0", VA = "0x183686BE0")]
	private void GMFKNLHNPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3686F80", Offset = "0x3686380", VA = "0x183686F80")]
	private bool IHLNIOJNGEJ(AEMFLFLGAKF MKHEGFILDPH, Transform GPFONCECPBK, out GameObject MPOGNODCFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x3686B90", Offset = "0x3685F90", VA = "0x183686B90")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x3688030", Offset = "0x3687430", VA = "0x183688030")]
	public NAHABAIDKKI()
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
		public SerializableGuid MCOFJEKHEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x36A0950", Offset = "0x369FD50", VA = "0x1836A0950")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LOJIIDJFKAI(typeof(AIPMOHLKLGI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public class AIPMOHLKLGI : DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string ODKFNCHENHH = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x36D02D0", Offset = "0x36CF6D0", VA = "0x1836D02D0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AIPMOHLKLGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(AFJJDNCHENE), new string[] { })]
public class AFJJDNCHENE : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[IMNMHIBEIDL]
	private EnableComponentSystemsInScope EKJFPEDJHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[IMNMHIBEIDL]
	private SceneService KJGMKGKKNGC;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x36CF510", Offset = "0x36CE910", VA = "0x1836CF510", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x36CF480", Offset = "0x36CE880", VA = "0x1836CF480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x36CF4C0", Offset = "0x36CE8C0", VA = "0x1836CF4C0")]
	private void FFNOCNODJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x36CF4E0", Offset = "0x36CE8E0", VA = "0x1836CF4E0")]
	private void NMHNLLFAOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AFJJDNCHENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[LOJIIDJFKAI(typeof(CGLADJHJCEM), new string[] { })]
public class AKIMKJDDDDE : DPDCPMNGBKH, FPHKGEBJIKC, CGLADJHJCEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DJCLCEOJBJF FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MNCPFFBIPBM PIOIBKPFDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService FMKAHEFPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem LDEGMCDCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int LPIFJGNEIMC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FOPMPJMIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x36D09A0", Offset = "0x36CFDA0", VA = "0x1836D09A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NFJEDPPAJMK OOMHMDEKIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x36D0D60", Offset = "0x36D0160", VA = "0x1836D0D60", Slot = "9")]
		get
		{
			return default(NFJEDPPAJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x36D08B0", Offset = "0x36CFCB0", VA = "0x1836D08B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public JMAKJOJHHNF CHIKBBJPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x36D0D10", Offset = "0x36D0110", VA = "0x1836D0D10", Slot = "11")]
		get
		{
			return default(JMAKJOJHHNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x36D08B0", Offset = "0x36CFCB0", VA = "0x1836D08B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public JMAKJOJHHNF PAIGKEACLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x36D0950", Offset = "0x36CFD50", VA = "0x1836D0950", Slot = "13")]
		get
		{
			return default(JMAKJOJHHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint BAEDJPNEDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x36D0500", Offset = "0x36CF900", VA = "0x1836D0500")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LOPBLFJGGII AEPAOFPFGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x36D06C0", Offset = "0x36CFAC0", VA = "0x1836D06C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x36D0460", Offset = "0x36CF860", VA = "0x1836D0460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x36D1100", Offset = "0x36D0500", VA = "0x1836D1100", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x36D09E0", Offset = "0x36CFDE0", VA = "0x1836D09E0", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x36D0800", Offset = "0x36CFC00", VA = "0x1836D0800", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x36D0F00", Offset = "0x36D0300", VA = "0x1836D0F00")]
	private void NAPOHPPKBLH(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x36D05B0", Offset = "0x36CF9B0", VA = "0x1836D05B0", Slot = "14")]
	public NFJEDPPAJMK BEIEOAFNFAF(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x36D0360", Offset = "0x36CF760", VA = "0x1836D0360", Slot = "15")]
	public bool ABEADFFICKO(NFJEDPPAJMK HOHCGCELNKE, NFJEDPPAJMK MDKKIEJKOGD, out NFJEDPPAJMK OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x36D0B80", Offset = "0x36CFF80", VA = "0x1836D0B80", Slot = "16")]
	public void KEAPAJJBIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x36D0760", Offset = "0x36CFB60", VA = "0x1836D0760", Slot = "17")]
	public void BPMACDADLOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x36D0DA0", Offset = "0x36D01A0", VA = "0x1836D0DA0", Slot = "18")]
	public bool MPLFKOIHFPF(NFJEDPPAJMK MOOHJICILGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x36D08B0", Offset = "0x36CFCB0", VA = "0x1836D08B0")]
	private void GHGFKHHEHNE(NFJEDPPAJMK FFBBPBHPNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AKIMKJDDDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[LOJIIDJFKAI(typeof(DEMDCLJBMBJ), new string[] { })]
public class DOHAFCLPGCK : DPDCPMNGBKH, DEMDCLJBMBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x36E7AE0", Offset = "0x36E6EE0", VA = "0x1836E7AE0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x36E7A70", Offset = "0x36E6E70", VA = "0x1836E7A70", Slot = "5")]
	public void PBDHOHEJHEJ(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2C48A80", Offset = "0x2C47E80", VA = "0x182C48A80")]
	private void HDECKBNAIGA<T>(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DOHAFCLPGCK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[LOJIIDJFKAI(typeof(EOGBLGKJGCD), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	public class SelectionService : DPDCPMNGBKH, EOGBLGKJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x37AA2A0", Offset = "0x37A96A0", VA = "0x1837AA2A0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x37AA1C0", Offset = "0x37A95C0", VA = "0x1837AA1C0", Slot = "5")]
		public void JDCIOHHAIMF(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x37AA230", Offset = "0x37A9630", VA = "0x1837AA230", Slot = "6")]
		public void LJFMADGJJCC(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2C48A80", Offset = "0x2C47E80", VA = "0x182C48A80")]
		private void HDECKBNAIGA<T>(NFJEDPPAJMK ONBAMHPEIDG, bool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
[LOJIIDJFKAI(typeof(JKIIJLILCCP), new string[] { })]
internal sealed class JKIIJLILCCP : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[IMNMHIBEIDL]
	private ObjectEmbodimentService ALLKDINDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x3A49C70", Offset = "0x3A49070", VA = "0x183A49C70", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JKIIJLILCCP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	[LOJIIDJFKAI(typeof(WorldSerialization), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	internal sealed class WorldSerialization : DPDCPMNGBKH, GKBBEKJICJK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FADHLPPNOEF CEDIHMKBBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[IMNMHIBEIDL]
		private LFIBHLPOILP PPDJEICCKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[IMNMHIBEIDL]
		private SerializationService BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[IMNMHIBEIDL]
		private BANIDHAOEAM IPILJEFIHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[IMNMHIBEIDL]
		private DebugWorldsService EKBOMMFEOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[IMNMHIBEIDL]
		private BulkInstantiateSceneObjectService EBOLOFHGGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private JHLNNPKIFCO KOKEGENGCAH;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private OKNJKHAMLJO HLMDNBNAKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x147D480", Offset = "0x147C880", VA = "0x18147D480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x37BF3D0", Offset = "0x37BE7D0", VA = "0x1837BF3D0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO JAOCFOBBLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x37BE500", Offset = "0x37BD900", VA = "0x1837BE500", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x37BED70", Offset = "0x37BE170", VA = "0x1837BED70", Slot = "6")]
		public bool KKJBIOFDHBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x37BEED0", Offset = "0x37BE2D0", VA = "0x1837BEED0", Slot = "7")]
		public bool MOBLBDDLMMJ(IEnumerable<CKLPCIIPNON> CGPACAEGGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x37BE8E0", Offset = "0x37BDCE0", VA = "0x1837BE8E0", Slot = "5")]
		public ByteString KHCMMGKFHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x37BE4E0", Offset = "0x37BD8E0", VA = "0x1837BE4E0")]
		private void DLEHLBPFOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x37BE810", Offset = "0x37BDC10", VA = "0x1837BE810")]
		private void GEAKLAABGMI(HKGKEPCIADL CEEHHEDBOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x37BEEF0", Offset = "0x37BE2F0", VA = "0x1837BEEF0")]
		private void NOOGCIKELGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x37BE530", Offset = "0x37BD930", VA = "0x1837BE530")]
		private void GBHHGAAJMPE(MHOEABJDIBA CEEHHEDBOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x37BE490", Offset = "0x37BD890", VA = "0x1837BE490", Slot = "8")]
		public void COMMHLEBCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x37BE3F0", Offset = "0x37BD7F0", VA = "0x1837BE3F0")]
		private HKGKEPCIADL ACAFOEKMJLB(EntityManager FDDCHHJLNLF, EntityManager PMCBFHAJAOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[LOJIIDJFKAI(typeof(GDFIPNNJBAF), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public class GDFIPNNJBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<PCLEKMKAJBM, string> IDBELADJMGE;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EEF0", Offset = "0x3A3E2F0", VA = "0x183A3EEF0")]
	public GameObject ABIMPNPLHMP(PCLEKMKAJBM FFLMGLOOKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EFC0", Offset = "0x3A3E3C0", VA = "0x183A3EFC0")]
	public GDFIPNNJBAF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(TimeService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class TimeService : LFPMKPLIAAM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[IMNMHIBEIDL]
		private SingletonComponentService IDGCJAPHIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool DOIPIBNHHCB;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData EDLKJAOEHLO
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x37B1AD0", Offset = "0x37B0ED0", VA = "0x1837B1AD0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x37B1B40", Offset = "0x37B0F40", VA = "0x1837B1B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool FCKEAKEOFJC
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x8180E0", Offset = "0x8174E0", VA = "0x1808180E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xA8BCD0", Offset = "0xA8B0D0", VA = "0x180A8BCD0", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x37B1BC0", Offset = "0x37B0FC0", VA = "0x1837B1BC0", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x37B1C10", Offset = "0x37B1010", VA = "0x1837B1C10")]
		public void PEKOAHIKAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[LOJIIDJFKAI(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::DEHNDDIKMEN<Entity> GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService CCJAOIAIHHP;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x37ADF60", Offset = "0x37AD360", VA = "0x1837ADF60", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x37ADCF0", Offset = "0x37AD0F0", VA = "0x1837ADCF0", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x37ADC50", Offset = "0x37AD050", VA = "0x1837ADC50", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x37ADE20", Offset = "0x37AD220", VA = "0x1837ADE20")]
		private void KKPBCPLKBEH(Entity OAOGLFGGBPI, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[MBALNPKLAGP(FOFKCKDBIPD.Services)]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[LOJIIDJFKAI(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[IMNMHIBEIDL]
		private ADMIKKBEDIN LNJLGDKOFHH;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private ACDNAFCMOHG CAEPCIMDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x3A38560", Offset = "0x3A37960", VA = "0x183A38560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private MGBLANLDNCG GFAOFEHDKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x3A385B0", Offset = "0x3A379B0", VA = "0x183A385B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3A38600", Offset = "0x3A37A00", VA = "0x183A38600", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3A38540", Offset = "0x3A37940", VA = "0x183A38540", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
[LOJIIDJFKAI(typeof(CMKHMHNPMBE), new string[] { })]
public class CMKHMHNPMBE : COEMEMEDCFH, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MLIOGBNLKEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MLIOGBNLKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x37A5880", Offset = "0x37A4C80", VA = "0x1837A5880")]
		internal void <InitReferences>b__0(DPDCPMNGBKH svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JMCJOMOHAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public JMCJOMOHAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x37A5150", Offset = "0x37A4550", VA = "0x1837A5150")]
		internal void <InitExternal>b__0(FPHKGEBJIKC svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xDE2290", Offset = "0xDE1690", VA = "0x180DE2290", Slot = "4")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MJGGLIPIDNP IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x36D9A50", Offset = "0x36D8E50", VA = "0x1836D9A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x36D9B80", Offset = "0x36D8F80", VA = "0x1836D9B80", Slot = "5")]
	public void JKLOGDJOLHP(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x36D9BD0", Offset = "0x36D8FD0", VA = "0x1836D9BD0", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x36D9D00", Offset = "0x36D9100", VA = "0x1836D9D00", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x36D9AA0", Offset = "0x36D8EA0", VA = "0x1836D9AA0", Slot = "8")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x36D9920", Offset = "0x36D8D20", VA = "0x1836D9920", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2C30F20", Offset = "0x2C30320", VA = "0x182C30F20")]
	private void PMOBBGIOLAN<T>(Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CMKHMHNPMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class MNIEODKMIBJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> IEGPGBKLAIF;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To OMKECOOHJIM
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
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public MNIEODKMIBJ(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
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
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
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
public class HPDKBNPNCNA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x31D38E0", Offset = "0x31D2CE0", VA = "0x1831D38E0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x31D3940", Offset = "0x31D2D40", VA = "0x1831D3940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x31D38B0", Offset = "0x31D2CB0", VA = "0x1831D38B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x810300", Offset = "0x80F700", VA = "0x180810300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x27BDED0", Offset = "0x27BD2D0", VA = "0x1827BDED0")]
	public HPDKBNPNCNA(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB, bool LPKIEPPBIHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x31D34D0", Offset = "0x31D28D0", VA = "0x1831D34D0", Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x31D3530", Offset = "0x31D2930", VA = "0x1831D3530", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x31D3560", Offset = "0x31D2960", VA = "0x1831D3560", Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x31D35C0", Offset = "0x31D29C0", VA = "0x1831D35C0", Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x31D36D0", Offset = "0x31D2AD0", VA = "0x1831D36D0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x31D3740", Offset = "0x31D2B40", VA = "0x1831D3740", Slot = "6")]
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x31D37A0", Offset = "0x31D2BA0", VA = "0x1831D37A0", Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x31D3850", Offset = "0x31D2C50", VA = "0x1831D3850", Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x31D3820", Offset = "0x31D2C20", VA = "0x1831D3820", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C860", Offset = "0x2E7BC60", VA = "0x182E7C860", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class MCIDMCJKHCJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> PFCDNINKMFA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x40E4E40", Offset = "0x40E4240", VA = "0x1840E4E40", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x40E4E90", Offset = "0x40E4290", VA = "0x1840E4E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x40E4E00", Offset = "0x40E4200", VA = "0x1840E4E00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x31EE110", Offset = "0x31ED510", VA = "0x1831EE110")]
	public MCIDMCJKHCJ(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x40E4A10", Offset = "0x40E3E10", VA = "0x1840E4A10", Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x40E4A50", Offset = "0x40E3E50", VA = "0x1840E4A50", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x40E4A90", Offset = "0x40E3E90", VA = "0x1840E4A90", Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x40E4B50", Offset = "0x40E3F50", VA = "0x1840E4B50", Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x40E4C10", Offset = "0x40E4010", VA = "0x1840E4C10", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x40E4CD0", Offset = "0x40E40D0", VA = "0x1840E4CD0", Slot = "6")]
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x40E4D40", Offset = "0x40E4140", VA = "0x1840E4D40", Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x40E4DC0", Offset = "0x40E41C0", VA = "0x1840E4DC0", Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x40E4D80", Offset = "0x40E4180", VA = "0x1840E4D80", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF9E0", Offset = "0x2DFEDE0", VA = "0x182DFF9E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class IAFCLHDCNGE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To OMKECOOHJIM
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
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public IAFCLHDCNGE(Func<From, To> CFOONEMCGLN, Func<To, From> KMABJOABNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PFCDNINKMFA, int POHDMEMKCCD)
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
	public int IndexOf(To KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BELCAJFDAHD, To KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
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
public static class FFABMDFPAPO
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string ABBINPODNLB = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string LLCJMOLDDHB = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string JBNMHGGCGDB = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string DLHHDMNOPNO = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string NJIDGDLMBJJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string POCNDGEPBED = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string FGCALMBPIEH = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string CEJONDMOHOP = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class KCMGDGDLHHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class OKJNGDAIKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public JHLNNPKIFCO services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public OKJNGDAIKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x4765430", Offset = "0x4764830", VA = "0x184765430")]
		internal void <InitServices>b__1(DPDCPMNGBKH svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x4765490", Offset = "0x4764890", VA = "0x184765490")]
		internal void <InitServices>b__2(FPHKGEBJIKC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ABB0", Offset = "0x3A49FB0", VA = "0x183A4ABB0")]
	public static void CHKECECPCLE(this MJGGLIPIDNP OACNPKMLCHI, JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2873810", Offset = "0x2872C10", VA = "0x182873810")]
	public static void PMOBBGIOLAN<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2873290", Offset = "0x2872690", VA = "0x182873290")]
	public static void GFPEIBFCEJA<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x28730E0", Offset = "0x28724E0", VA = "0x1828730E0")]
	public static void DPLBMLKONEI<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2872F30", Offset = "0x2872330", VA = "0x182872F30")]
	public static void BDKNJDMNINI<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x28735A0", Offset = "0x28729A0", VA = "0x1828735A0")]
	public static void KBONJFNFFBF<T>(this MJGGLIPIDNP OACNPKMLCHI, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2873430", Offset = "0x2872830", VA = "0x182873430")]
	public static void GFPEIBFCEJA<T>(IEnumerable<ComponentSystemBase> HOCPKHHLENG, Action<T> MLBIDGHDIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2873750", Offset = "0x2872B50", VA = "0x182873750")]
	private static void PEOIKHJLPHM<T>(object DCOPHBBEGEL, Action<T> MLBIDGHDIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class PCDDEIANACH
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OCCNFHPOKOO
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x36896A0", Offset = "0x3688AA0", VA = "0x1836896A0")]
	public static void AFCLCMKGMDH(ComponentSystemBase DCOPHBBEGEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class DAKJPGHHMGH
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool PHKNCADEDHN<T>(ref T FAMKPEGNHFC, ref T GPHMIGDKMEO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class BBKFPNPODPB
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class PMKIJJAPFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PMKIJJAPFFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x36D44A0", Offset = "0x36D38A0", VA = "0x1836D44A0")]
	public static string FEJBNKNMICE(Transform LJLOGOIJMEM, Transform MOOHJICILGA)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x37ACB30", Offset = "0x37ABF30", VA = "0x1837ACB30")]
		public static void ABDNPPIKLOH(this MMAHKENHAHO KOKEGENGCAH, AKHLGKPGKGF NOECNPHPBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x37AD080", Offset = "0x37AC480", VA = "0x1837AD080")]
		public static void PAHMLHEPEPE(this MMAHKENHAHO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x37ACA20", Offset = "0x37ABE20", VA = "0x1837ACA20")]
		public static void ABDNPPIKLOH(this MMAHKENHAHO KOKEGENGCAH, [Optional] string[] EKJJGDJAGBM, [Optional] string[] HFJJLADKPMN, [Optional] string[] PEMEJBAMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x37ACD60", Offset = "0x37AC160", VA = "0x1837ACD60")]
		public static void ILFFCLHNGMD(this MMAHKENHAHO KOKEGENGCAH, params string[] IJNGHIHLMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x37ACFD0", Offset = "0x37AC3D0", VA = "0x1837ACFD0")]
		public static void LFOOMLNFJMO(this MMAHKENHAHO KOKEGENGCAH, params string[] IJNGHIHLMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x37AD180", Offset = "0x37AC580", VA = "0x1837AD180")]
		private static string[] PFKMALBJMCD(AKHLGKPGKGF NOECNPHPBKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x37ACE10", Offset = "0x37AC210", VA = "0x1837ACE10")]
		private static bool JDBNOAPMBAF(AKHLGKPGKGF NOECNPHPBKJ, out string[] KGIOLOGPFOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0")]
		private static bool PCJEMJDINLD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class NPECMMOIGKD : NHFAACLOLLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo MJOCJIJILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] FKNKEJLLBEP;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x36895F0", Offset = "0x36889F0", VA = "0x1836895F0")]
	public NPECMMOIGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action AKJGGHEAFNK();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x36895B0", Offset = "0x36889B0", VA = "0x1836895B0")]
	public MethodInfo NMKMCCJKMKM(Action GPNJNMLGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3689400", Offset = "0x3688800", VA = "0x183689400", Slot = "4")]
	public void KJDPCLCGNLB(Type DDJDPMGLPAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class KENMGPMEAAD : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum NIMNELBNOEM
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C760", Offset = "0x3A4BB60", VA = "0x183A4C760", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LEOMFAEFBGI<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C7F0", Offset = "0x3A4BBF0", VA = "0x183A4C7F0")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A48810", Offset = "0x3A47C10", VA = "0x183A48810")]
	protected KENMGPMEAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class JKLBMELODFJ : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A49D30", Offset = "0x3A49130", VA = "0x183A49D30", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void COBHDHHPEEM<T>() where T : HGKJFOODIMO;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A49DC0", Offset = "0x3A491C0", VA = "0x183A49DC0")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A48810", Offset = "0x3A47C10", VA = "0x183A48810")]
	protected JKLBMELODFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class JCBBEKGEPGH : NPECMMOIGKD
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A486F0", Offset = "0x3A47AF0", VA = "0x183A486F0", Slot = "5")]
	public override Action AKJGGHEAFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPPMCGNKPME<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A48780", Offset = "0x3A47B80", VA = "0x183A48780")]
	[Preserve]
	public void BMAPJNJGLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A48810", Offset = "0x3A47C10", VA = "0x183A48810")]
	protected JCBBEKGEPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class FGDIJOKBBLM
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CC20", Offset = "0x3A3C020", VA = "0x183A3CC20")]
	public static Entity BHAGDEEBMIJ(this EntityManager KNABDDPENKI)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class JEANINLGOMF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2DF7AE0", Offset = "0x2DF6EE0", VA = "0x182DF7AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x47617F0", Offset = "0x4760BF0", VA = "0x1847617F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x4760590", Offset = "0x475F990", VA = "0x184760590")]
			[DebuggerHidden]
			public JEANINLGOMF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x4761620", Offset = "0x4760A20", VA = "0x184761620", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x47617B0", Offset = "0x4760BB0", VA = "0x1847617B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x4761700", Offset = "0x4760B00", VA = "0x184761700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x4761700", Offset = "0x4760B00", VA = "0x184761700", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class PHMNFNCNJAP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2DF7AE0", Offset = "0x2DF6EE0", VA = "0x182DF7AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4765A90", Offset = "0x4764E90", VA = "0x184765A90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x4760590", Offset = "0x475F990", VA = "0x184760590")]
			[DebuggerHidden]
			public PHMNFNCNJAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x4765AE0", Offset = "0x4764EE0", VA = "0x184765AE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x47657B0", Offset = "0x4764BB0", VA = "0x1847657B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x4765B70", Offset = "0x4764F70", VA = "0x184765B70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x4765A50", Offset = "0x4764E50", VA = "0x184765A50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x47659A0", Offset = "0x4764DA0", VA = "0x1847659A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x47659A0", Offset = "0x4764DA0", VA = "0x1847659A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class HCFIKCHBDLK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2DF7AE0", Offset = "0x2DF6EE0", VA = "0x182DF7AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x47603D0", Offset = "0x475F7D0", VA = "0x1847603D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x4760590", Offset = "0x475F990", VA = "0x184760590")]
			[DebuggerHidden]
			public HCFIKCHBDLK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x4760420", Offset = "0x475F820", VA = "0x184760420", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x475FFC0", Offset = "0x475F3C0", VA = "0x18475FFC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x47604F0", Offset = "0x475F8F0", VA = "0x1847604F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x4760540", Offset = "0x475F940", VA = "0x184760540")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x4760390", Offset = "0x475F790", VA = "0x184760390", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x47602F0", Offset = "0x475F6F0", VA = "0x1847602F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x47602F0", Offset = "0x475F6F0", VA = "0x1847602F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B760", Offset = "0x3A3AB60", VA = "0x183A3B760")]
		public static Entity HHCKLGJHJDM(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C110", Offset = "0x3A3B510", VA = "0x183A3C110")]
		public static DynamicBuffer<ChildrenData> NOKFNLAAOIH(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C080", Offset = "0x3A3B480", VA = "0x183A3C080")]
		public static DynamicBuffer<ChildrenData> NDKOENAKEJM(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AF70", Offset = "0x3A3A370", VA = "0x183A3AF70")]
		public static NativeArray<Entity> BPLBMMECGOF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BE80", Offset = "0x3A3B280", VA = "0x183A3BE80")]
		public static bool MLDPIIIMGHA(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG, out NativeArray<Entity> GGJICFIFGND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B0A0", Offset = "0x3A3A4A0", VA = "0x183A3B0A0")]
		public static NativeArray<Entity> CIMFGHKFFLC(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B7D0", Offset = "0x3A3ABD0", VA = "0x183A3B7D0")]
		public static Entity JIABEAAPFBL(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B550", Offset = "0x3A3A950", VA = "0x183A3B550")]
		public static int FJOEJBEAIPG(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AD10", Offset = "0x3A3A110", VA = "0x183A3AD10")]
		public static void BIPMKHFOLGI(NativeArray<Entity> NKDKBMKAAAG, NativeArray<Entity> PLBLCMNMLJO, EntityManager KNABDDPENKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B4A0", Offset = "0x3A3A8A0", VA = "0x183A3B4A0")]
		public static int ENLCMJGOKGJ(this EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BA80", Offset = "0x3A3AE80", VA = "0x183A3BA80")]
		public static bool KFKEAKANFDF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AC00", Offset = "0x3A3A000", VA = "0x183A3AC00")]
		public static IEnumerable<Entity> BIJKCDCNJDN(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C300", Offset = "0x3A3B700", VA = "0x183A3C300")]
		public static bool PNPLAMAGNCA(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity LKJGCNCCCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B290", Offset = "0x3A3A690", VA = "0x183A3B290")]
		public static bool CLCGCNNPCNJ(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity HOHCGCELNKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BBE0", Offset = "0x3A3AFE0", VA = "0x183A3BBE0")]
		public static NativeList<Entity> KGECOFKCEIF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false, Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B900", Offset = "0x3A3AD00", VA = "0x183A3B900")]
		public static IEnumerable<Entity> JPCGBLEHGGF(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BF80", Offset = "0x3A3B380", VA = "0x183A3BF80")]
		public static Entity MNEECNHBEJG(this EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A9A0", Offset = "0x3A39DA0", VA = "0x183A3A9A0")]
		public static bool ABEADFFICKO(this EntityManager KNABDDPENKI, Entity HOHCGCELNKE, Entity MDKKIEJKOGD, out Entity OBCBEGEPMDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B420", Offset = "0x3A3A820", VA = "0x183A3B420")]
		internal static void DJDHBHJAKFL(EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B660", Offset = "0x3A3AA60", VA = "0x183A3B660")]
		internal static void GPFEDAJBGJL(EntityManager KNABDDPENKI, Entity GPFONCECPBK, Entity LKJGCNCCCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BDF0", Offset = "0x3A3B1F0", VA = "0x183A3BDF0")]
		[IteratorStateMachine(typeof(JEANINLGOMF))]
		private static IEnumerable<Entity> LNLLLAAJIIB(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B200", Offset = "0x3A3A600", VA = "0x183A3B200")]
		[IteratorStateMachine(typeof(PHMNFNCNJAP))]
		private static IEnumerable<Entity> CKCKJCNLNJO(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C1A0", Offset = "0x3A3B5A0", VA = "0x183A3C1A0")]
		[IteratorStateMachine(typeof(HCFIKCHBDLK))]
		private static IEnumerable<Entity> OKNCIDJHCMG(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C220", Offset = "0x3A3B620", VA = "0x183A3C220")]
		private static bool PBFEHOEJGEL(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[LOJIIDJFKAI(typeof(GPJINHAGDJN), new string[] { })]
public class DGNMBLKBPAN : GPJINHAGDJN, COEMEMEDCFH, CBFMKNIGECP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private JHLNNPKIFCO KOKEGENGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private LFIBHLPOILP PPDJEICCKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private IBAFENGCGOE CCPHBLENGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private DJCLCEOJBJF FPAHGFEONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private DFPNHPPNFLJ ELCDAMLJAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private BDAJNAKKLOI BDFANKEHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private IPBKNNKPCHC CGLLMAJNLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private PMEGIOPIHFM ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private NINFMKFKPIG DHFDEFJOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private NOGKKJEEDNP HLFPFGGCOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private CGLADJHJCEM CBLJIOEJBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private BDFDGLPPMOH HIOJLLPHGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private LKGNBGJGHAA FIECGFNHODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private DEMDCLJBMBJ MCLILDBFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private EOGBLGKJGCD BEPEJBEHEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private PEJNHEGAEGK AOCCCIOCKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private KGOCHOHEAHM GFECAPKCLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private MCAEHJPOCLP LDDCANHDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public JHLNNPKIFCO BELPKEBIKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public GAOMEBKFAAA DDGABFFCPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CPEFIMBHABA IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LFIBHLPOILP FJPJBKHCDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public IBAFENGCGOE HOEJKHDAMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public NPFNHEGAPFJ APIPCEEBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public DJCLCEOJBJF NCKPBBOBINB
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DFPNHPPNFLJ JHLNDBLKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public BDAJNAKKLOI LHBKKNBFPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB40", Offset = "0x7CAF40", VA = "0x1807CBB40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public IPBKNNKPCHC MBBHHOCIIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public PMEGIOPIHFM LAMFBEMMFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public NINFMKFKPIG NEOGHNFHADF
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x77D600", Offset = "0x77CA00", VA = "0x18077D600", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NOGKKJEEDNP KOEKIONFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CGLADJHJCEM BNAKAEDMIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x725C80", Offset = "0x725080", VA = "0x180725C80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public BDFDGLPPMOH FGOFHGLAPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7A4AB0", Offset = "0x7A3EB0", VA = "0x1807A4AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public LKGNBGJGHAA FDGCGGHGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x180757C60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DEMDCLJBMBJ GFPKMCENMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x786230", Offset = "0x785630", VA = "0x180786230", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public EOGBLGKJGCD MKLOEABFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F65B0", VA = "0x1806F71B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PEJNHEGAEGK CGCPGBMKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x77D610", Offset = "0x77CA10", VA = "0x18077D610", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public KGOCHOHEAHM CIEFHNFOHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x6EC370", Offset = "0x6EB770", VA = "0x1806EC370", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public MCAEHJPOCLP CINGNKENKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x6EC430", Offset = "0x6EB830", VA = "0x1806EC430", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public NHOAANBCJPO INKDAMJBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "21")]
		get
		{
			return default(NHOAANBCJPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x36E6840", Offset = "0x36E5C40", VA = "0x1836E6840", Slot = "22")]
	public void JKLOGDJOLHP(JHLNNPKIFCO JAOCFOBBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD0910", Offset = "0x2ACFD10", VA = "0x182AD0910", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x36E6820", Offset = "0x36E5C20", VA = "0x1836E6820", Slot = "23")]
	public void AEPAOFPFGOA(JHLNNPKIFCO JAOCFOBBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DGNMBLKBPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class KKHBPEFIMOA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NLMFEFOPIAE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public KKHBPEFIMOA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x47646A0", Offset = "0x4763AA0", VA = "0x1847646A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public NLMFEFOPIAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x47644F0", Offset = "0x47638F0", VA = "0x1847644F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x4764660", Offset = "0x4763A60", VA = "0x184764660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong BBKKCEPBGIA = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong AKAMEBDDJNO = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int FCJMBIPACOE = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int GIIKEHGOMPH = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int JAECDFHNFFA = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int LJCJHBKLPLG = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> FFOOLEPKCGE;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x795E90", Offset = "0x795290", VA = "0x180795E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int KPABNKEIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x795E50", Offset = "0x795250", VA = "0x180795E50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x795EA0", Offset = "0x7952A0", VA = "0x180795EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E7A0", Offset = "0x3A4DBA0", VA = "0x183A4E7A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x3A4E480", Offset = "0x3A4D880", VA = "0x183A4E480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EAD0", Offset = "0x3A4DED0", VA = "0x183A4EAD0")]
	public KKHBPEFIMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EB50", Offset = "0x3A4DF50", VA = "0x183A4EB50")]
	public KKHBPEFIMOA(int KHFADEKJGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E9F0", Offset = "0x3A4DDF0", VA = "0x183A4E9F0")]
	public bool PCGJMBHDOGN(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E0C0", Offset = "0x3A4D4C0", VA = "0x183A4E0C0")]
	public bool CCBOGEEGFOC(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E040", Offset = "0x3A4D440", VA = "0x183A4E040")]
	public bool BBIJEGALJJM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E790", Offset = "0x3A4DB90", VA = "0x183A4E790")]
	public bool HGGGGBFNODB(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E1B0", Offset = "0x3A4D5B0", VA = "0x183A4E1B0")]
	public void ENCHMHKFMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E240", Offset = "0x3A4D640", VA = "0x183A4E240")]
	public void FAOKIKBFOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E6A0", Offset = "0x3A4DAA0", VA = "0x183A4E6A0")]
	public void HDECKBNAIGA(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E330", Offset = "0x3A4D730", VA = "0x183A4E330")]
	public void FPNLAFLJCKH(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E960", Offset = "0x3A4DD60", VA = "0x183A4E960")]
	public bool OGNHIEBNHGO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E840", Offset = "0x3A4DC40", VA = "0x183A4E840")]
	public void NGACHCOLDNM(int ELOEOOGBENM, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DD40", Offset = "0x3A4D140", VA = "0x183A4DD40")]
	public void AFNMACFKKMI(int JFKLAOAGCCB, int BMJHAAKDFMA, int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DF70", Offset = "0x3A4D370", VA = "0x183A4DF70")]
	public int AOHLLDNPMGN(int OCCKKIPCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DF00", Offset = "0x3A4D300", VA = "0x183A4DF00")]
	public int AOHLLDNPMGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E430", Offset = "0x3A4D830", VA = "0x183A4E430")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E630", Offset = "0x3A4DA30", VA = "0x183A4E630", Slot = "4")]
	[IteratorStateMachine(typeof(NLMFEFOPIAE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E630", Offset = "0x3A4DA30", VA = "0x183A4E630", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class BJGEOGLBCGK<T> : global::AAAGDCFOBOE<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::DEJGHNLFIHL<T> DINCDDJBCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::KAAKIKFDMHB<T> CPFAGJHAJGF;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x1F535C0", Offset = "0x1F529C0", VA = "0x181F535C0")]
	public BJGEOGLBCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x29BB7F0", Offset = "0x29BABF0", VA = "0x1829BB7F0")]
	public BJGEOGLBCGK(global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x29BB580", Offset = "0x29BA980", VA = "0x1829BB580", Slot = "11")]
	public override T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x29BB190", Offset = "0x29BA590", VA = "0x1829BB190", Slot = "12")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class GFDEPHMAKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF10", Offset = "0x2E5B310", VA = "0x182E5BF10")]
	public static NMLCFAIOCDK KJDPCLCGNLB<T>(this GINHFLNLBFM ELCMIPNJFNP, global::PHNOBDPMINP<T> IGHJIHNAPBA, global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF) where T : struct
	{
		return default(NMLCFAIOCDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class IMBMOFOCABC<T> : global::BJGEOGLBCGK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DE50", Offset = "0x2B8D250", VA = "0x182B8DE50")]
	public IMBMOFOCABC(T LOOCNKEBNDJ, T KLDHGDMNHDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class MJLMGKPALMD<T> : global::AAAGDCFOBOE<T> where T : struct, HGKJFOODIMO
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5CA0", Offset = "0x3AA50A0", VA = "0x183AA5CA0", Slot = "11")]
	public override T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5B70", Offset = "0x3AA4F70", VA = "0x183AA5B70", Slot = "12")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x1E2EC50", Offset = "0x1E2E050", VA = "0x181E2EC50")]
	public MJLMGKPALMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class HLBAFPNMBMM : NAFDCBJOMHH
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type LDNIEKAGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG, in EGIBCKCHGAP JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, in LONBCMOJAJF JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void OKJGILDOJEJ(GDKEGMAHJIA EMEJPAMPJKG, NGFPDGDPGKP CFPEBKLBEPN, [Optional] object MAFDHEKFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected HLBAFPNMBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class AAAGDCFOBOE<T> : HLBAFPNMBMM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type LDNIEKAGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E640", Offset = "0x3C5DA40", VA = "0x183C5E640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, T JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F6F0", Offset = "0x3C5EAF0", VA = "0x183C5F6F0", Slot = "8")]
	public override void LPJEJNEGJFP(GDKEGMAHJIA EMEJPAMPJKG, in EGIBCKCHGAP MOOHJICILGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F010", Offset = "0x3C5E410", VA = "0x183C5F010", Slot = "9")]
	public override void LMGAKHPBOLH(GDKEGMAHJIA EMEJPAMPJKG, in LONBCMOJAJF GEMNKBDIDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3C60720", Offset = "0x3C5FB20", VA = "0x183C60720", Slot = "10")]
	public override void OKJGILDOJEJ(GDKEGMAHJIA EMEJPAMPJKG, NGFPDGDPGKP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80")]
	protected AAAGDCFOBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class EGBOGGDAKOC
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class FDNGLLLIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class PHGDGPODCJA<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
			public PHGDGPODCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x3398E80", Offset = "0x3398280", VA = "0x183398E80")]
			internal void <RegisterFixedString>b__0(GDKEGMAHJIA p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x33991B0", Offset = "0x33985B0", VA = "0x1833991B0")]
			internal T <RegisterFixedString>b__1(GDKEGMAHJIA p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x475EE20", Offset = "0x475E220", VA = "0x18475EE20")]
		public static void PFFOHNDHOEB(CDAGGLGHKNE ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x35AE8F0", Offset = "0x35ADCF0", VA = "0x1835AE8F0")]
		private static void NGKLIHHINNE<T>(CDAGGLGHKNE ANLABGKNJHG, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x35AE860", Offset = "0x35ADC60", VA = "0x1835AE860")]
		private static void JDAKJPKKLIL<T>(GDKEGMAHJIA KHNOBAAPEAO, T AEOKKHKBMBB, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x35AE210", Offset = "0x35AD610", VA = "0x1835AE210")]
		private static T FLBABJJJLCH<T>(GDKEGMAHJIA KHNOBAAPEAO, int KLDHGDMNHDJ) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public FDNGLLLIHOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class EPJCKMLPBPE : KENMGPMEAAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private CDAGGLGHKNE ANLABGKNJHG;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x35AE050", Offset = "0x35AD450", VA = "0x1835AE050", Slot = "6")]
		public override void LEOMFAEFBGI<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x475E720", Offset = "0x475DB20", VA = "0x18475E720")]
		public static void POALIMPAOBL(CDAGGLGHKNE ANLABGKNJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x475E7D0", Offset = "0x475DBD0", VA = "0x18475E7D0")]
		public EPJCKMLPBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x36EAAC0", Offset = "0x36E9EC0", VA = "0x1836EAAC0")]
	public static void GIPOAJMDPFD(CDAGGLGHKNE ANLABGKNJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x27C4F20", Offset = "0x27C4320", VA = "0x1827C4F20")]
	public static void KAILEDHADHG<T>(CDAGGLGHKNE ANLABGKNJHG, global::DEJGHNLFIHL<T> DINCDDJBCLK, global::KAAKIKFDMHB<T> CPFAGJHAJGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x27C4EB0", Offset = "0x27C42B0", VA = "0x1827C4EB0")]
	public static void KABEEAMPAMG<T>(CDAGGLGHKNE HIFHBPOKANI) where T : struct, HGKJFOODIMO
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
public interface CDAGGLGHKNE : global::GDIKFDIOHFC<CDAGGLGHKNE>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJDPCLCGNLB(Type DDJDPMGLPAE, NAFDCBJOMHH HIFHBPOKANI);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIGJNHOBOLH(Type DDJDPMGLPAE, out NAFDCBJOMHH HIFHBPOKANI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class OKOKKPPOJHI
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x3689AD0", Offset = "0x3688ED0", VA = "0x183689AD0")]
	public static void KJDPCLCGNLB(this CDAGGLGHKNE IAFMOECNDHE, NAFDCBJOMHH HIFHBPOKANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[LOJIIDJFKAI(typeof(GINHFLNLBFM), new string[] { })]
public sealed class CFLAOEJELHP : GINHFLNLBFM, global::GDIKFDIOHFC<GINHFLNLBFM>, LFPMKPLIAAM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<NMLCFAIOCDK, NAFDCBJOMHH> ANLABGKNJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private CDAGGLGHKNE CJLLIMPENGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool PGIMNJLLNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x810300", Offset = "0x80F700", VA = "0x180810300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x36D87F0", Offset = "0x36D7BF0", VA = "0x1836D87F0")]
	public CFLAOEJELHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x36D8730", Offset = "0x36D7B30", VA = "0x1836D8730")]
	public CFLAOEJELHP(Dictionary<NMLCFAIOCDK, NAFDCBJOMHH> ANLABGKNJHG, bool LJJHHADAAOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x36D84E0", Offset = "0x36D78E0", VA = "0x1836D84E0", Slot = "7")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x36D86B0", Offset = "0x36D7AB0", VA = "0x1836D86B0", Slot = "8")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x36D80D0", Offset = "0x36D74D0", VA = "0x1836D80D0", Slot = "9")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x36D82D0", Offset = "0x36D76D0", VA = "0x1836D82D0", Slot = "4")]
	public NMLCFAIOCDK GJNIEJDOIIG(CNFMDAKFLAB IGHJIHNAPBA)
	{
		return default(NMLCFAIOCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x36D8540", Offset = "0x36D7940", VA = "0x1836D8540", Slot = "5")]
	public void KJDPCLCGNLB(NMLCFAIOCDK LIKFEBDBPON, NAFDCBJOMHH HIFHBPOKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x36D83A0", Offset = "0x36D77A0", VA = "0x1836D83A0")]
	[Conditional("DEBUG_BUILD")]
	private void HLNHHEJDAOO(NMLCFAIOCDK LIKFEBDBPON, Type DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x36D8120", Offset = "0x36D7520", VA = "0x1836D8120", Slot = "6")]
	public bool GIGJNHOBOLH(NMLCFAIOCDK LIKFEBDBPON, out NAFDCBJOMHH HIFHBPOKANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x36D7FF0", Offset = "0x36D73F0", VA = "0x1836D7FF0", Slot = "10")]
	public GINHFLNLBFM EHDNGDPNMFL()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[LOJIIDJFKAI(typeof(CDAGGLGHKNE), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.TypeSerializer)]
	public sealed class TypeSerializerService : LFPMKPLIAAM, CDAGGLGHKNE, global::GDIKFDIOHFC<CDAGGLGHKNE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, NAFDCBJOMHH> ANLABGKNJHG;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool PGIMNJLLNOP
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x8180E0", Offset = "0x8174E0", VA = "0x1808180E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x37B7910", Offset = "0x37B6D10", VA = "0x1837B7910")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x37B7990", Offset = "0x37B6D90", VA = "0x1837B7990")]
		public TypeSerializerService(Dictionary<Type, NAFDCBJOMHH> ANLABGKNJHG, bool LJJHHADAAOJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x37B7740", Offset = "0x37B6B40", VA = "0x1837B7740", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x37B77A0", Offset = "0x37B6BA0", VA = "0x1837B77A0", Slot = "5")]
		public void KJDPCLCGNLB(Type DDJDPMGLPAE, NAFDCBJOMHH HIFHBPOKANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x37B7660", Offset = "0x37B6A60", VA = "0x1837B7660", Slot = "6")]
		public bool GIGJNHOBOLH(Type DDJDPMGLPAE, out NAFDCBJOMHH HIFHBPOKANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x37B7580", Offset = "0x37B6980", VA = "0x1837B7580", Slot = "7")]
		public CDAGGLGHKNE EHDNGDPNMFL()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[LOJIIDJFKAI(typeof(OCNNCEMNKMG), new string[] { })]
internal sealed class HKHGGDGCPJH : OCNNCEMNKMG, LFPMKPLIAAM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<NMLCFAIOCDK, PMKHHHLLOPE> IJOAAMKIMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A40EF0", Offset = "0x3A402F0", VA = "0x183A40EF0", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A40FB0", Offset = "0x3A403B0", VA = "0x183A40FB0", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A40F40", Offset = "0x3A40340", VA = "0x183A40F40", Slot = "4")]
	public void KJDPCLCGNLB(NMLCFAIOCDK MPKOBDPILJB, Type HHLBCDGILNF, PMKHHHLLOPE LJMEBHLNOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A40CF0", Offset = "0x3A400F0", VA = "0x183A40CF0", Slot = "5")]
	public bool AKHCPCIAJIF(NMLCFAIOCDK MPKOBDPILJB, out PMKHHHLLOPE LJMEBHLNOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A40D60", Offset = "0x3A40160", VA = "0x183A40D60")]
	[Conditional("DEBUG_BUILD")]
	private void GGOGHGBBJNB(NMLCFAIOCDK MPKOBDPILJB, Type HHLBCDGILNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A41010", Offset = "0x3A40410", VA = "0x183A41010")]
	public HKHGGDGCPJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[LOJIIDJFKAI(typeof(POIJNILNJOE), new string[] { })]
internal sealed class IDKKKNIOCEF : POIJNILNJOE, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly KKHBPEFIMOA CPOLDJAHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<IOLFAAOECPP, int> KANMBGKMMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> MBFGHJLKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[IMNMHIBEIDL]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int LJAINNNDGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A461F0", Offset = "0x3A455F0", VA = "0x183A461F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool KNFCGHKCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E4370", Offset = "0x6E3770", VA = "0x1806E4370", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E43F0", Offset = "0x6E37F0", VA = "0x1806E43F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A46000", Offset = "0x3A45400", VA = "0x183A46000", Slot = "6")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A46240", Offset = "0x3A45640", VA = "0x183A46240", Slot = "7")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A46140", Offset = "0x3A45540", VA = "0x183A46140", Slot = "8")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A45AD0", Offset = "0x3A44ED0", VA = "0x183A45AD0")]
	private void AHMBLEDJIAC(NFJEDPPAJMK OOGHONKGHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A45EC0", Offset = "0x3A452C0", VA = "0x183A45EC0", Slot = "4")]
	public bool DLHDPJHIOPA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A45B70", Offset = "0x3A44F70", VA = "0x183A45B70", Slot = "5")]
	public void DBOBEMBMCPG(IOLFAAOECPP IOCKLNNJMIA, Span<NMLCFAIOCDK> ELCMIPNJFNP, bool PHHHFKPPFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A46000", Offset = "0x3A45400", VA = "0x183A46000", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A462C0", Offset = "0x3A456C0", VA = "0x183A462C0")]
	public IDKKKNIOCEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class FLPMMBNNDDC
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DC70", Offset = "0x3A3D070", VA = "0x183A3DC70")]
	public static void GDHIODHAEFN(this GDKEGMAHJIA EMEJPAMPJKG, ReadOnlyMemory<byte> GECDJJHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x3770D20", Offset = "0x3770120", VA = "0x183770D20")]
	public static void EFLAGMJPJKC<T>(this GDKEGMAHJIA EMEJPAMPJKG, in T JFBPNBNBHOE) where T : struct, HGKJFOODIMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x3770E50", Offset = "0x3770250", VA = "0x183770E50")]
	public static T NDJBHKCBOCI<T>(this GDKEGMAHJIA EMEJPAMPJKG) where T : struct, HGKJFOODIMO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DC40", Offset = "0x3A3D040", VA = "0x183A3DC40")]
	public static void EFLAGMJPJKC(this GDKEGMAHJIA EMEJPAMPJKG, JKDEDHBDHBM AHPJJBDHKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DE10", Offset = "0x3A3D210", VA = "0x183A3DE10")]
	public static JKDEDHBDHBM JBOBDIPJLJH(this GDKEGMAHJIA EMEJPAMPJKG)
	{
		return default(JKDEDHBDHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DE40", Offset = "0x3A3D240", VA = "0x183A3DE40")]
	public static void OKJDCCMIKNF(this GDKEGMAHJIA ABIHDCBCABG, uint JGNCEKJOLON, bool GMKHKEIGGNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DCF0", Offset = "0x3A3D0F0", VA = "0x183A3DCF0")]
	public static uint IAKACPCKCFJ(this GDKEGMAHJIA OJMODHIKFDB, bool GMKHKEIGGNH = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class FEGMBDKOLGO
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MOGGIMALCLA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public MOGGIMALCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FC67F0", Offset = "0x3FC5BF0", VA = "0x183FC67F0")]
		internal void <GetByteEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6860", Offset = "0x3FC5C60", VA = "0x183FC6860")]
		internal T <GetByteEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class IKHGNDBCMIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public IKHGNDBCMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B894F0", Offset = "0x2B888F0", VA = "0x182B894F0")]
		internal void <GetSByteEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B89560", Offset = "0x2B88960", VA = "0x182B89560")]
		internal T <GetSByteEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class JKNNKDKGLGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public JKNNKDKGLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3EACB10", Offset = "0x3EABF10", VA = "0x183EACB10")]
		internal void <GetShortEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3EACB80", Offset = "0x3EABF80", VA = "0x183EACB80")]
		internal T <GetShortEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class HBBFIDFNMCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public HBBFIDFNMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x4388F00", Offset = "0x4388300", VA = "0x184388F00")]
		internal void <GetUShortEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x4388F70", Offset = "0x4388370", VA = "0x184388F70")]
		internal T <GetUShortEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class GBCBMIEHMEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public GBCBMIEHMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x36A5520", Offset = "0x36A4920", VA = "0x1836A5520")]
		internal void <GetIntEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x36A5580", Offset = "0x36A4980", VA = "0x1836A5580")]
		internal T <GetIntEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class BGEDNCEMAPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public BGEDNCEMAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x29B6370", Offset = "0x29B5770", VA = "0x1829B6370")]
		internal void <GetUIntEnumDelegates>b__0(GDKEGMAHJIA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x29B63D0", Offset = "0x29B57D0", VA = "0x1829B63D0")]
		internal T <GetUIntEnumDelegates>b__1(GDKEGMAHJIA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3767820", Offset = "0x3766C20", VA = "0x183767820")]
	public static void MGLBHFJKIMO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x37676D0", Offset = "0x3766AD0", VA = "0x1837676D0")]
	private static void ONIMHEDNBPO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x37676D0", Offset = "0x3766AD0", VA = "0x1837676D0")]
	private static void DHDHBPJGBFO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3767580", Offset = "0x3766980", VA = "0x183767580")]
	private static void APBJJOPDFHO<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x3767580", Offset = "0x3766980", VA = "0x183767580")]
	private static void IEIPAFKEHDM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x3767430", Offset = "0x3766830", VA = "0x183767430")]
	private static void AGHBKKNCFNM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x3767430", Offset = "0x3766830", VA = "0x183767430")]
	private static void LCNHGEFPBMM<T>(T LOOCNKEBNDJ, T KLDHGDMNHDJ, out global::DEJGHNLFIHL<T> OBLNEHKOEJP, out global::KAAKIKFDMHB<T> DDKNMADHPKF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class BBOBOCOGEKH : EHNCFNMGCGK, FPHKGEBJIKC
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x36D4570", Offset = "0x36D3970", VA = "0x1836D4570", Slot = "4")]
	private void FEANLCHAMEF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EGOICCPFGIK(GINHFLNLBFM ELCMIPNJFNP);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
	protected BBOBOCOGEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[DDFPMNGAPLM(typeof(LocalPoseData))]
public sealed class KLOGHHNDIIN : BBOBOCOGEKH
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F4D0", Offset = "0x3A4E8D0", VA = "0x183A4F4D0", Slot = "5")]
	protected override void EGOICCPFGIK(GINHFLNLBFM ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	public KLOGHHNDIIN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class CopyAuthorityToEntity : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery GKBBEIMEIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery KBPHPMFNMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x36E2210", Offset = "0x36E1610", VA = "0x1836E2210", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x36E2050", Offset = "0x36E1450", VA = "0x1836E2050", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x36E21D0", Offset = "0x36E15D0", VA = "0x1836E21D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x36E21A0", Offset = "0x36E15A0", VA = "0x1836E21A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x36E1870", Offset = "0x36E0C70", VA = "0x1836E1870")]
		private void HMNIHAPDMKO(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x36E13F0", Offset = "0x36E07F0", VA = "0x1836E13F0")]
		private void CHKFEDEKDDH(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x36E1590", Offset = "0x36E0990", VA = "0x1836E1590")]
		private void GOKELKEOOPG(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x36E1BB0", Offset = "0x36E0FB0", VA = "0x1836E1BB0")]
		private void JJMBCAHBBBC(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x36E1E40", Offset = "0x36E1240", VA = "0x1836E1E40")]
		private void NECIPKNIMOI(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x36E1D60", Offset = "0x36E1160", VA = "0x1836E1D60")]
		private void KPCEAHNADHF(NFJEDPPAJMK OOGHONKGHEE, int PMIGFHIBOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class BJEDBPLFJHJ : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x36D5D10", Offset = "0x36D5110", VA = "0x1836D5D10", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x36D5880", Offset = "0x36D4C80", VA = "0x1836D5880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x36D5940", Offset = "0x36D4D40", VA = "0x1836D5940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x36D52A0", Offset = "0x36D46A0", VA = "0x1836D52A0")]
	private void NLICFAHOEKE(NativeArray<Entity> GNGEEFEGDCP, NativeList<Entity> EAPAOOBBMGJ, ComponentDataFromEntity<NKCAEIPLFAF> PMNJGOOLNBI, BufferFromEntity<ChildrenData> LFGPHLBNJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public BJEDBPLFJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class JFOHNHNGEKD : ParentSystemBase<AuthoredParentData, HLMIEDJMAKI, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3A49B70", Offset = "0x3A48F70", VA = "0x183A49B70", Slot = "14")]
	protected override EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x84D390", Offset = "0x84C790", VA = "0x18084D390", Slot = "15")]
	protected override EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x3A49B30", Offset = "0x3A48F30", VA = "0x183A49B30", Slot = "16")]
	protected override EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3A49BF0", Offset = "0x3A48FF0", VA = "0x183A49BF0", Slot = "17")]
	protected override EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x3A49C30", Offset = "0x3A49030", VA = "0x183A49C30")]
	public JFOHNHNGEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x3A49BB0", Offset = "0x3A48FB0", VA = "0x183A49BB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class ICHOBIPMOGN : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object AKFAIOOBKJE;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x3A453C0", Offset = "0x3A447C0", VA = "0x183A453C0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x3A450A0", Offset = "0x3A444A0", VA = "0x183A450A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x3A45140", Offset = "0x3A44540", VA = "0x183A45140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public ICHOBIPMOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class EBLECJAMLCJ : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object AKFAIOOBKJE;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x36EA1E0", Offset = "0x36E95E0", VA = "0x1836EA1E0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x36E9EC0", Offset = "0x36E92C0", VA = "0x1836E9EC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x36E9F60", Offset = "0x36E9360", VA = "0x1836E9F60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public EBLECJAMLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct MGIFPDLOLOA : ISystemStateBufferElementData, IBufferElementData, IEquatable<MGIFPDLOLOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public KFGEJPOHHNK KJNCDAGJAPF;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x3685250", Offset = "0x3684650", VA = "0x183685250", Slot = "4")]
	public bool Equals(MGIFPDLOLOA IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0")]
	public static MGIFPDLOLOA LOJIFGBJNLM(KFGEJPOHHNK KJNCDAGJAPF)
	{
		return default(MGIFPDLOLOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct LENNAEIOLNF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public KFGEJPOHHNK KJNCDAGJAPF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0")]
	public static LENNAEIOLNF LOJIFGBJNLM(KFGEJPOHHNK KJNCDAGJAPF)
	{
		return default(LENNAEIOLNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class NFGAPLIHOBJ : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x3688630", Offset = "0x3687A30", VA = "0x183688630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x36887C0", Offset = "0x3687BC0", VA = "0x1836887C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	protected NFGAPLIHOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[LOFBNDLMONN]
internal abstract class FHHOCGHDMCF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected MCAEHJPOCLP LDDCANHDBNB;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D4B0", Offset = "0x3A3C8B0", VA = "0x183A3D4B0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CF40", Offset = "0x3A3C340", VA = "0x183A3CF40")]
	protected void BGEPHIOCLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D230", Offset = "0x3A3C630", VA = "0x183A3D230")]
	protected void DHDOHBDGAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D1C0", Offset = "0x3A3C5C0", VA = "0x183A3D1C0")]
	protected KAANBEDLICJ DALBGCMGJDD()
	{
		return default(KAANBEDLICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	protected FHHOCGHDMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class LICMNIGOGPC : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x3683760", Offset = "0x3682B60", VA = "0x183683760", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x36838F0", Offset = "0x3682CF0", VA = "0x1836838F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	protected LICMNIGOGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class CMIPMDHFNFG : FHHOCGHDMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x36D9780", Offset = "0x36D8B80", VA = "0x1836D9780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x36D9890", Offset = "0x36D8C90", VA = "0x1836D9890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	protected CMIPMDHFNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class CFMGBNGIDAM : NFGAPLIHOBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x36D8CF0", Offset = "0x36D80F0", VA = "0x1836D8CF0", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x36D8D60", Offset = "0x36D8160", VA = "0x1836D8D60")]
	public CFMGBNGIDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class MHKBGOPGGHJ : LICMNIGOGPC
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x36857C0", Offset = "0x3684BC0", VA = "0x1836857C0", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	public MHKBGOPGGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class EBMHNHCFNDL : CMIPMDHFNFG
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x36EA260", Offset = "0x36E9660", VA = "0x1836EA260", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	public EBMHNHCFNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class IFGMMEHADJG : NFGAPLIHOBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x3A46420", Offset = "0x3A45820", VA = "0x183A46420", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x36D8D60", Offset = "0x36D8160", VA = "0x1836D8D60")]
	public IFGMMEHADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class IDIGNCICFAK : LICMNIGOGPC
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x3A45A60", Offset = "0x3A44E60", VA = "0x183A45A60", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x36D8D60", Offset = "0x36D8160", VA = "0x1836D8D60")]
	public IDIGNCICFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class DCPMFAFNILI : CMIPMDHFNFG
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override KEPFOAAIAOD GGCECNLKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x36E5870", Offset = "0x36E4C70", VA = "0x1836E5870", Slot = "15")]
		get
		{
			return default(KEPFOAAIAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x3683990", Offset = "0x3682D90", VA = "0x183683990")]
	public DCPMFAFNILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct MEKIGEFFJAD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct HPPGJHBMEJE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct DNFEPNKMINK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct KEPFOAAIAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType ONPDMHJKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType MPPCHDNPEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object AJDBKDIMOHA;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C880", Offset = "0x3A4BC80", VA = "0x183A4C880")]
	public KEPFOAAIAOD(ComponentType ONPDMHJKADH, ComponentType MPPCHDNPEDD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2873FB0", Offset = "0x28733B0", VA = "0x182873FB0")]
	public static KEPFOAAIAOD FFPKNNKHNKN<TReq, TTag>(object AJDBKDIMOHA)
	{
		return default(KEPFOAAIAOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class PEOCFAOCDAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string KCKIEIHLPKL = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string PHBHJDBHOCF = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly KEPFOAAIAOD MKLOEABFLBH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly KEPFOAAIAOD EBACDHOKCIB;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct KFGEJPOHHNK : global::BDDOIGLJFOK<KFGEJPOHHNK>, IGCGKLPONMN, IEquatable<KFGEJPOHHNK>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x727530", Offset = "0x726930", VA = "0x180727530", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x761000", Offset = "0x760400", VA = "0x180761000", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x761010", Offset = "0x760410", VA = "0x180761010", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3A4CDC0", Offset = "0x3A4C1C0", VA = "0x183A4CDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CD70", Offset = "0x3A4C170", VA = "0x183A4CD70", Slot = "8")]
	public bool Equals(KFGEJPOHHNK IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CE00", Offset = "0x3A4C200", VA = "0x183A4CE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class UpdateConnectableVisuals : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct CBAFEKKPAIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public KFGEJPOHHNK KJNCDAGJAPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 DACBJNCMNFL;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x475C550", Offset = "0x475B950", VA = "0x18475C550")]
			public CBAFEKKPAIL(KFGEJPOHHNK KJNCDAGJAPF, float3 DACBJNCMNFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x475C530", Offset = "0x475B930", VA = "0x18475C530")]
			public void EEEPFIIDMLE(out KFGEJPOHHNK KJNCDAGJAPF, out float3 DACBJNCMNFL)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct DCIKKDAELAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
			public DCIKKDAELAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<LENNAEIOLNF> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct PAKCDHKMPPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
			public PAKCDHKMPPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<MGIFPDLOLOA> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct AJICMHHELBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<CBAFEKKPAIL> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
			public AJICMHHELBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in CEIFDNONLIL com, in DynamicBuffer<MGIFPDLOLOA> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HFFLCNAIGNK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct ODBBKGJDGFJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct KPIOIBECFHL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<LENNAEIOLNF>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LENNAEIOLNF> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x4765090", Offset = "0x4764490", VA = "0x184765090")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x4765110", Offset = "0x4764510", VA = "0x184765110")]
				public KPIOIBECFHL OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(KPIOIBECFHL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals BFAPLOAAIBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private ODBBKGJDGFJ LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ODBBKGJDGFJ.KPIOIBECFHL* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x4760630", Offset = "0x475FA30", VA = "0x184760630")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, WorldPoseData OJHBEGOMAPB, in DynamicBuffer<LENNAEIOLNF> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x4760AD0", Offset = "0x475FED0", VA = "0x184760AD0", Slot = "5")]
			public void ReadFromDisplayClass(ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x4760B00", Offset = "0x475FF00", VA = "0x184760B00", Slot = "6")]
			public void WriteToDisplayClass(ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x47608B0", Offset = "0x475FCB0", VA = "0x1847608B0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x4760990", Offset = "0x475FD90", VA = "0x184760990")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref ODBBKGJDGFJ.KPIOIBECFHL DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x4760870", Offset = "0x475FC70", VA = "0x184760870")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref DCIKKDAELAG IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x47605C0", Offset = "0x475F9C0", VA = "0x1847605C0")]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct ANEBPJFBGLH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct BHNNOLGGJNH
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct ABDCAAIINNE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x475C200", Offset = "0x475B600", VA = "0x18475C200")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x475C270", Offset = "0x475B670", VA = "0x18475C270")]
				public ABDCAAIINNE OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(ABDCAAIINNE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private BHNNOLGGJNH LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BHNNOLGGJNH.ABDCAAIINNE* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x475B570", Offset = "0x475A970", VA = "0x18475B570")]
			internal void AOFNEGGIPNF(in WorldPoseData OJHBEGOMAPB, in DynamicBuffer<MGIFPDLOLOA> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x957610", Offset = "0x956A10", VA = "0x180957610", Slot = "5")]
			public void ReadFromDisplayClass(ref PAKCDHKMPPE IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x475B720", Offset = "0x475AB20", VA = "0x18475B720", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x475B7F0", Offset = "0x475ABF0", VA = "0x18475B7F0")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref BHNNOLGGJNH.ABDCAAIINNE DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x475B680", Offset = "0x475AA80", VA = "0x18475B680")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref PAKCDHKMPPE IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct CGMAACKBPDA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct NNCHBFPCKJG
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct BCMMEBNCGON
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DKDCCDPFCEI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<CEIFDNONLIL>.Runtime DOJBCBMLBIL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA>.Runtime ECJMABCPBDH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> DJJOLDCGEOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<CEIFDNONLIL> FMDJBMHLKLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<MGIFPDLOLOA> EFGMLKAFGNB;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x47646F0", Offset = "0x4763AF0", VA = "0x1847646F0")]
				public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x4764780", Offset = "0x4763B80", VA = "0x184764780")]
				public BCMMEBNCGON OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(BCMMEBNCGON);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<CBAFEKKPAIL> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private NNCHBFPCKJG LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NNCHBFPCKJG.BCMMEBNCGON* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x475C5E0", Offset = "0x475B9E0", VA = "0x18475C5E0")]
			internal void AOFNEGGIPNF(in WorldPoseData OJHBEGOMAPB, in CEIFDNONLIL DEIGCPCMMPG, in DynamicBuffer<MGIFPDLOLOA> BGHMFEPCABE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x957610", Offset = "0x956A10", VA = "0x180957610", Slot = "5")]
			public void ReadFromDisplayClass(ref AJICMHHELBO IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x475C780", Offset = "0x475BB80", VA = "0x18475C780", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x475C800", Offset = "0x475BC00", VA = "0x18475C800")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref NNCHBFPCKJG.BCMMEBNCGON DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x475C740", Offset = "0x475BB40", VA = "0x18475C740")]
			public void BHIDKDBKBAC(UpdateConnectableVisuals MFPLGOJOEDD, ref AJICMHHELBO IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery JOENFDKOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery IANPOBHMFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery BCFEBBFAMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery GIKEAIFGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery AMDJIPKHOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery JIDHPICCDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery LIJICKLIBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery NNKGLNOFECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery HIFKGEENBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery CAMNKNMBNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::JBJIOMDHKBO<KFGEJPOHHNK, GJLAMBHCAMH> EDPDCLMFPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private KGOCHOHEAHM GFECAPKCLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private CGLADJHJCEM CBLJIOEJBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private HFNIHCOGOJL HJFDMKOEODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery GBJDAPCIAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker GFKMMGCPDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery LHHCINDMMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery OBKMDJEJFFN;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x37BBC10", Offset = "0x37BB010", VA = "0x1837BBC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x37B8490", Offset = "0x37B7890", VA = "0x1837B8490")]
		internal GJLAMBHCAMH ALOKEFPAEBO(KFGEJPOHHNK KJNCDAGJAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x37BC4E0", Offset = "0x37BB8E0", VA = "0x1837BC4E0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x37BBF60", Offset = "0x37BB360", VA = "0x1837BBF60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x37BC1E0", Offset = "0x37BB5E0", VA = "0x1837BC1E0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x37BC370", Offset = "0x37BB770", VA = "0x1837BC370", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x37BC1A0", Offset = "0x37BB5A0", VA = "0x1837BC1A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x37BA900", Offset = "0x37B9D00", VA = "0x1837BA900")]
		private void HNKNJBKFJAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x37BBC50", Offset = "0x37BB050", VA = "0x1837BBC50")]
		private void MCNJHIGNNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x37B80E0", Offset = "0x37B74E0", VA = "0x1837B80E0")]
		private void AEAMONOOMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x37BC3B0", Offset = "0x37BB7B0", VA = "0x1837BC3B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x37BB730", Offset = "0x37BAB30", VA = "0x1837BB730")]
		private void KJAIMLDDOOF(EntityQuery GKBBEIMEIPO, EntityQuery GIENCMBCINK, EntityQuery KBPHPMFNMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x37B8B00", Offset = "0x37B7F00", VA = "0x1837B8B00")]
		private void BCBAFCFKBLF(EntityQuery KBPHPMFNMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x37B9690", Offset = "0x37B8A90", VA = "0x1837B9690")]
		private void DMFAOBCOHHM(NativeArrayAsync<Entity> GCHMMICFNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x37B94B0", Offset = "0x37B88B0", VA = "0x1837B94B0")]
		private void DCDBMMIMHHA(NativeArrayAsync<Entity> OGDEFABGACE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x37BB590", Offset = "0x37BA990", VA = "0x1837BB590")]
		private void JOAGFKKNNIN(NativeArrayAsync<Entity> DGPMFNFOMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x37BA790", Offset = "0x37B9B90", VA = "0x1837BA790")]
		private void GLBMHOEFLIJ(NativeList<KFGEJPOHHNK> DPIDOCFEJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x37BAF40", Offset = "0x37BA340", VA = "0x1837BAF40")]
		private NativeList<KFGEJPOHHNK> INCBDNGKIKI(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<KFGEJPOHHNK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x37B84E0", Offset = "0x37B78E0", VA = "0x1837B84E0")]
		private void ANIAMFJDDBD(NativeArray<Entity> GNGEEFEGDCP, NativeList<KFGEJPOHHNK> DPIDOCFEJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x37BAA10", Offset = "0x37B9E10", VA = "0x1837BAA10")]
		private void IKPFHNIADPG(NativeArray<Entity> BICAIHCABBB, NativeArray<Entity> FPOPONLDEPD, NativeList<KFGEJPOHHNK> MBFGHJLKLPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x37B9000", Offset = "0x37B8400", VA = "0x1837B9000")]
		private void CADKKOFIGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x37B9970", Offset = "0x37B8D70", VA = "0x1837B9970")]
		private NativeListAsync<CBAFEKKPAIL> DPBEBKBOCHI(EntityQuery JLMGAJOHFKO, Func<NativeList<CBAFEKKPAIL>, JobHandle> AOGJIBBKMOE)
		{
			return default(NativeListAsync<CBAFEKKPAIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x37B9CB0", Offset = "0x37B90B0", VA = "0x1837B9CB0")]
		private JobHandle EAKBNCBJCCD(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x37BA5C0", Offset = "0x37B99C0", VA = "0x1837BA5C0")]
		private JobHandle GCHDDHNHBIB(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x37BB460", Offset = "0x37BA860", VA = "0x1837BB460")]
		private JobHandle JFNHCOPIIBC(NativeList<CBAFEKKPAIL> NHOGENNANEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x37B9E40", Offset = "0x37B9240", VA = "0x1837B9E40")]
		private void EIMIBBMKOED(NativeListAsync<CBAFEKKPAIL> NHOGENNANEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x37BA0D0", Offset = "0x37B94D0", VA = "0x1837BA0D0")]
		private void FDEKAIDOLIP(NativeListAsync<CBAFEKKPAIL> NHOGENNANEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x37BBDA0", Offset = "0x37BB1A0", VA = "0x1837BBDA0")]
		private bool NBPIPADACDJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x37B95C0", Offset = "0x37B89C0", VA = "0x1837B95C0")]
		private NativeArray<Entity> DHEPGNDLOHF(Entity OAOGLFGGBPI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x37B8BD0", Offset = "0x37B7FD0", VA = "0x1837B8BD0")]
		private KFGEJPOHHNK BGCDIBBNNJE(NativeList<KFGEJPOHHNK> MBFGHJLKLPA)
		{
			return default(KFGEJPOHHNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x37BA700", Offset = "0x37B9B00", VA = "0x1837BA700")]
		private void GFOKJNBMOLF(KFGEJPOHHNK KJNCDAGJAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x37BBE00", Offset = "0x37BB200", VA = "0x1837BBE00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x37B9AB0", Offset = "0x37B8EB0", VA = "0x1837B9AB0")]
		public static EntityQuery DPPANAPLKKJ(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x37BA360", Offset = "0x37B9760", VA = "0x1837BA360")]
		public static EntityQuery GCFLBLDIMBO(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x37B8D90", Offset = "0x37B8190", VA = "0x1837B8D90")]
		public static EntityQuery BHHJKEGPFND(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[MBALNPKLAGP(FOFKCKDBIPD.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private DJCLCEOJBJF FPAHGFEONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private AOHCKDBFDIB HEGKMFCNMCJ;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x369D750", Offset = "0x369CB50", VA = "0x18369D750", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x369DE10", Offset = "0x369D210", VA = "0x18369DE10", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x369D850", Offset = "0x369CC50", VA = "0x18369D850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class KAANIFMEHKC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public MIDGCDECPDI ALLKDINDGEN;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public KAANIFMEHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public KAANIFMEHKC(MIDGCDECPDI ALLKDINDGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AB40", Offset = "0x3A49F40", VA = "0x183A4AB40", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class KHHMELCFBHA : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService CCJAOIAIHHP;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CEA0", Offset = "0x3A4C2A0", VA = "0x183A4CEA0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CE50", Offset = "0x3A4C250", VA = "0x183A4CE50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CE80", Offset = "0x3A4C280", VA = "0x183A4CE80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	protected KHHMELCFBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class IKGNJCJKDHP : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery ICNCIOMOAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery JIEFELCOICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery MEFPAAALPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery NCIFABMCOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService LEEABEOMEGF;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int GHENHLBAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x3A47510", Offset = "0x3A46910", VA = "0x183A47510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int PIOCBEALFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x3A472E0", Offset = "0x3A466E0", VA = "0x183A472E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x3A47900", Offset = "0x3A46D00", VA = "0x183A47900", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x3A476E0", Offset = "0x3A46AE0", VA = "0x183A476E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x3A478E0", Offset = "0x3A46CE0", VA = "0x183A478E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A47580", Offset = "0x3A46980", VA = "0x183A47580")]
	public int ILPEILOOILG(SceneTag BGCBBDJLHHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A475F0", Offset = "0x3A469F0", VA = "0x183A475F0")]
	public int LHLAAECBKCO(SceneTag BGCBBDJLHHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A472F0", Offset = "0x3A466F0", VA = "0x183A472F0")]
	protected void GNAMPJEKJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A47180", Offset = "0x3A46580", VA = "0x183A47180")]
	protected void DFLJPGJHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A47290", Offset = "0x3A46690", VA = "0x183A47290")]
	public NativeArrayAsync<Entity> EDJJJKMLCHD(SceneTag BGCBBDJLHHN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A475A0", Offset = "0x3A469A0", VA = "0x183A475A0")]
	public NativeArrayAsync<Entity> LHJEDCPABDE(SceneTag BGCBBDJLHHN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A47040", Offset = "0x3A46440", VA = "0x183A47040")]
	public bool BCIMIJPHOKA(SceneTag BGCBBDJLHHN, out NativeArrayAsync<Entity> ALLKDINDGEN, Allocator OPBLDCCKGEG = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A47520", Offset = "0x3A46920", VA = "0x183A47520")]
	public bool IGNAOPBPCKO(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A47610", Offset = "0x3A46A10", VA = "0x183A47610")]
	public MIDGCDECPDI LMGDNNBAIHJ(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A470D0", Offset = "0x3A464D0", VA = "0x183A470D0")]
	public bool CCBOPNINIEJ(Entity OAOGLFGGBPI, out KAANIFMEHKC ALLKDINDGEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A47140", Offset = "0x3A46540", VA = "0x183A47140")]
	public void CKKJBILLNPP(Entity OAOGLFGGBPI, KAANIFMEHKC ALLKDINDGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A47680", Offset = "0x3A46A80", VA = "0x183A47680")]
	public bool LOPKHLFIMAA(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void AEEKNBJJNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public IKGNJCJKDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class DDIIGOMIFDD : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery KOLIHBAFFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x36E5CF0", Offset = "0x36E50F0", VA = "0x1836E5CF0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x36E5950", Offset = "0x36E4D50", VA = "0x1836E5950", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x36E5A10", Offset = "0x36E4E10", VA = "0x1836E5A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C44DF0", Offset = "0x2C441F0", VA = "0x182C44DF0")]
	private bool IELCMMKFOLD<TComponentData>(EntityQuery JLMGAJOHFKO, out NativeArray<Entity> GNGEEFEGDCP, out NativeArray<TComponentData> AOONNNAPHDO) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x36E58E0", Offset = "0x36E4CE0", VA = "0x1836E58E0")]
	public MIDGCDECPDI LMGDNNBAIHJ(Entity OAOGLFGGBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public DDIIGOMIFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery PHCJLFMMJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery ODOAJCHFDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery DACICHHHJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x37ADBB0", Offset = "0x37ACFB0", VA = "0x1837ADBB0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x37AD4F0", Offset = "0x37AC8F0", VA = "0x1837AD4F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x37AD720", Offset = "0x37ACB20", VA = "0x1837AD720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x37AD410", Offset = "0x37AC810", VA = "0x1837AD410")]
		private void AOHLLDNPMGN(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x37AD480", Offset = "0x37AC880", VA = "0x1837AD480")]
		private void BCBAFCFKBLF(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x37AD6B0", Offset = "0x37ACAB0", VA = "0x1837AD6B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x37AD850", Offset = "0x37ACC50", VA = "0x1837AD850")]
		private void PDDELNAGNBO(EntityQuery JLMGAJOHFKO, bool BEIBHGPBPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class DAFDIPMPEAJ : DHDEFGPGMMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct OHNABPIEGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public OHNABPIEGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct BJGFMCMMPDG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct ENOPHELFFHE
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct LPOFPJKNJGH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime KFLCDHONKNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime EPOJHMHGNJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime LBIBDPJKNDN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PIAEOHBJBAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> OKKKDBHPPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> GGEEGPBEOKG;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x475E520", Offset = "0x475D920", VA = "0x18475E520")]
			public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x475E5A0", Offset = "0x475D9A0", VA = "0x18475E5A0")]
			public LPOFPJKNJGH OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(LPOFPJKNJGH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private ENOPHELFFHE LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ENOPHELFFHE.LPOFPJKNJGH* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x37A2820", Offset = "0x37A1C20", VA = "0x1837A2820")]
		internal void AOFNEGGIPNF(Entity OHJOALHOEEJ, SplineShapeData IGJFJCHKKMF, DynamicBuffer<LinkedEntityGroup> IEGPGBKLAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x37A2890", Offset = "0x37A1C90", VA = "0x1837A2890", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x37A2910", Offset = "0x37A1D10", VA = "0x1837A2910")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref ENOPHELFFHE.LPOFPJKNJGH DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x37A2880", Offset = "0x37A1C80", VA = "0x1837A2880")]
		public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GMJBOKFHHIK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct LLCBCCDFBOH
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct OCMHLNBINEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ABDIGJHNOKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime JLFIMJMPGMJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity JLPMLHIMHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> OBGEEHLIIDG;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x4763F30", Offset = "0x4763330", VA = "0x184763F30")]
			public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x4763F90", Offset = "0x4763390", VA = "0x184763F90")]
			public OCMHLNBINEA OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(OCMHLNBINEA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> CIOKPOMIGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private LLCBCCDFBOH LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LLCBCCDFBOH.OCMHLNBINEA* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x37A4220", Offset = "0x37A3620", VA = "0x1837A4220")]
		internal void AOFNEGGIPNF(Entity CFGMGHMOBMD, SplinePointParentData EIDEAPADNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1723AA0", Offset = "0x1722EA0", VA = "0x181723AA0", Slot = "5")]
		public void ReadFromDisplayClass(ref OHNABPIEGHK IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x37A42F0", Offset = "0x37A36F0", VA = "0x1837A42F0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x37A4360", Offset = "0x37A3760", VA = "0x1837A4360")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref LLCBCCDFBOH.OCMHLNBINEA DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x37A42B0", Offset = "0x37A36B0", VA = "0x1837A42B0")]
		public void BHIDKDBKBAC(DAFDIPMPEAJ MFPLGOJOEDD, ref OHNABPIEGHK IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery HNEDEFEIDIH;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x36E53E0", Offset = "0x36E47E0", VA = "0x1836E53E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x36E5490", Offset = "0x36E4890", VA = "0x1836E5490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public DAFDIPMPEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x36E5140", Offset = "0x36E4540", VA = "0x1836E5140", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x36E56D0", Offset = "0x36E4AD0", VA = "0x1836E56D0")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x36E4FE0", Offset = "0x36E43E0", VA = "0x1836E4FE0")]
	public static EntityQuery CBPGCGEEHHJ(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public sealed class CJLJGAHNBCL : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private LKPHHNIFJFE NEIHAKKOCEJ;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x36D9720", Offset = "0x36D8B20", VA = "0x1836D9720", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x36D9700", Offset = "0x36D8B00", VA = "0x1836D9700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public CJLJGAHNBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class PGDJIJBDEMM : DHDEFGPGMMG, FPHKGEBJIKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FIKABHKEIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<LMIKKFINNNK> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<CCLINJKNNFF> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<LMIKKFINNNK> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public FIKABHKEIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, EHHPMHEMOMP previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__2(Entity entity, EHHPMHEMOMP previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct GEIKONMIAOC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct FJEJLPJLPDN
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct NLFGFMEEGII
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NLLHLGIICMK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CFIMAMHLFJF;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x475EEE0", Offset = "0x475E2E0", VA = "0x18475EEE0")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x475EF40", Offset = "0x475E340", VA = "0x18475EF40")]
			public NLFGFMEEGII OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(NLFGFMEEGII);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<LMIKKFINNNK> JLABFFGDGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private FJEJLPJLPDN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FJEJLPJLPDN.NLFGFMEEGII* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x475F920", Offset = "0x475ED20", VA = "0x18475F920")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData BEKIFNKENPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x957610", Offset = "0x956A10", VA = "0x180957610", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x475FA30", Offset = "0x475EE30", VA = "0x18475FA30", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x475FAD0", Offset = "0x475EED0", VA = "0x18475FAD0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref FJEJLPJLPDN.NLFGFMEEGII DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x475F9A0", Offset = "0x475EDA0", VA = "0x18475F9A0")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct OLKNEPJBOPO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct HIJJMCCODAN
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct HCEAGEONGPP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NLLHLGIICMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP>.Runtime GIPHOKHPOII;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CFIMAMHLFJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP> BPCCBBKNFBI;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x4760B40", Offset = "0x475FF40", VA = "0x184760B40")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x4760BC0", Offset = "0x475FFC0", VA = "0x184760BC0")]
			public HCEAGEONGPP OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HCEAGEONGPP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<CCLINJKNNFF> FHNJMFEHEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private HIJJMCCODAN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HIJJMCCODAN.HCEAGEONGPP* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x47654F0", Offset = "0x47648F0", VA = "0x1847654F0")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData BEKIFNKENPL, EHHPMHEMOMP JHBHPHLKKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x47657A0", Offset = "0x4764BA0", VA = "0x1847657A0", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x47655F0", Offset = "0x47649F0", VA = "0x1847655F0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x47656C0", Offset = "0x4764AC0", VA = "0x1847656C0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref HIJJMCCODAN.HCEAGEONGPP DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x47655B0", Offset = "0x47649B0", VA = "0x1847655B0")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct GBDDELFOGEI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct COCPPGEJEDN
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct HOFLNMCKPDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP>.Runtime GIPHOKHPOII;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EHHPMHEMOMP> BPCCBBKNFBI;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x475D070", Offset = "0x475C470", VA = "0x18475D070")]
			public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x475D0D0", Offset = "0x475C4D0", VA = "0x18475D0D0")]
			public HOFLNMCKPDH OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HOFLNMCKPDH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<LMIKKFINNNK> PKOGBONKPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private COCPPGEJEDN LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe COCPPGEJEDN.HOFLNMCKPDH* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x475F640", Offset = "0x475EA40", VA = "0x18475F640")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, EHHPMHEMOMP JHBHPHLKKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x475F8A0", Offset = "0x475ECA0", VA = "0x18475F8A0", Slot = "5")]
		public void ReadFromDisplayClass(ref FIKABHKEIHO IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x475F750", Offset = "0x475EB50", VA = "0x18475F750", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x475F7F0", Offset = "0x475EBF0", VA = "0x18475F7F0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref COCPPGEJEDN.HOFLNMCKPDH DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x475F6C0", Offset = "0x475EAC0", VA = "0x18475F6C0")]
		public void BHIDKDBKBAC(PGDJIJBDEMM MFPLGOJOEDD, ref FIKABHKEIHO IFOILLGAIOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private BCCHDFPAANJ JBMKIDLKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery GKGLNBLOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery EGFLMCMGEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery AKDOBKCPDCG;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x3697B90", Offset = "0x3696F90", VA = "0x183697B90", Slot = "14")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x3698100", Offset = "0x3697500", VA = "0x183698100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public PGDJIJBDEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x36980A0", Offset = "0x36974A0", VA = "0x1836980A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x3697930", Offset = "0x3696D30", VA = "0x183697930")]
	public static EntityQuery BCEAJCOGFBB(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x3697C70", Offset = "0x3697070", VA = "0x183697C70")]
	public static EntityQuery LKNCGAEOIKA(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x3697EA0", Offset = "0x36972A0", VA = "0x183697EA0")]
	public static EntityQuery NDJMCOPHEBI(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	public class InitializeRigidbodyExHierarchy : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private FAJMNCCNMML FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x3A483B0", Offset = "0x3A477B0", VA = "0x183A483B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A48630", Offset = "0x3A47A30", VA = "0x183A48630", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A48440", Offset = "0x3A47840", VA = "0x183A48440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class EEJDKDKCCAP : ParentSystemBase<ParentData, EHHPMHEMOMP, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x36EA450", Offset = "0x36E9850", VA = "0x1836EA450", Slot = "14")]
	protected override EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x84D390", Offset = "0x84C790", VA = "0x18084D390", Slot = "15")]
	protected override EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x36EA410", Offset = "0x36E9810", VA = "0x1836EA410", Slot = "16")]
	protected override EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x36EA4D0", Offset = "0x36E98D0", VA = "0x1836EA4D0", Slot = "17")]
	protected override EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x36EA510", Offset = "0x36E9910", VA = "0x1836EA510")]
	public EEJDKDKCCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x36EA490", Offset = "0x36E9890", VA = "0x1836EA490", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : DHDEFGPGMMG where ParentData : struct, IComponentData, LCIGIOAHNLO where PreviousParentData : struct, IComponentData, LCIGIOAHNLO where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LCIGIOAHNLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct OKBDHCPGNPG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter HPONPDGOAKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter NPHFPEKAJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> PEGGFDAEEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> JKNKKPGGKLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType OKAKOJILFPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint LBAGCJGFKCK;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x2DF8C60", Offset = "0x2DF8060", VA = "0x182DF8C60", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct DPGJEDAPKIL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> LPDDAAHBDPL;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x3EEC0E0", Offset = "0x3EEB4E0", VA = "0x183EEC0E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct FNAFDEDDPDC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> HPONPDGOAKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> NPHFPEKAJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NFNHPLEPELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x3008DA0", Offset = "0x30081A0", VA = "0x183008DA0")]
			private int CDMJPGCEDAA(DynamicBuffer<ChildrenData> PLBLCMNMLJO, Entity OAOGLFGGBPI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x3009280", Offset = "0x3008680", VA = "0x183009280")]
			private void HBIJPAEEOLD(Entity GPFONCECPBK, DynamicBuffer<ChildrenData> PLBLCMNMLJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x3009540", Offset = "0x3008940", VA = "0x183009540")]
			private void NJDKKMLGNOD(Entity GPFONCECPBK, DynamicBuffer<ChildrenData> PLBLCMNMLJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x3009120", Offset = "0x3008520", VA = "0x183009120", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct KDNBDHLPMCN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> LGAHGBFJDHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> LILCAAEDFCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> LDKMLIJPFDH;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x30D3620", Offset = "0x30D2A20", VA = "0x1830D3620", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery AAEAOHNNBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery IGADABAPLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery LDIGFMNCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery ODIJLFGCKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker IJKGIDENJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker ACNFOMALPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker NFKGHHAHPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker GIHIJLFOCMF;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x31F5640", Offset = "0x31F4A40", VA = "0x1831F5640")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x31F4080", Offset = "0x31F3480", VA = "0x1831F4080")]
		private int CDMJPGCEDAA(DynamicBuffer<ChildrenData> PLBLCMNMLJO, Entity OAOGLFGGBPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x31F4780", Offset = "0x31F3B80", VA = "0x1831F4780")]
		private void EOCGMKNONGG(Entity AOAMDLBGHMH, Entity MOGIDIJEPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x84D390", Offset = "0x84C790", VA = "0x18084D390", Slot = "14")]
		protected virtual EntityQueryDesc MJFAMNEIEJF(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x84D390", Offset = "0x84C790", VA = "0x18084D390", Slot = "15")]
		protected virtual EntityQueryDesc GEIBCANAJIE(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x84D390", Offset = "0x84C790", VA = "0x18084D390", Slot = "16")]
		protected virtual EntityQueryDesc CACMJBLBMEB(EntityQueryDesc JLMGAJOHFKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc PEDAEEFLPLJ(EntityQueryDesc JLMGAJOHFKO);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x31F5000", Offset = "0x31F4400", VA = "0x1831F5000", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x31F45E0", Offset = "0x31F39E0", VA = "0x1831F45E0")]
		private void EAPIKGLACDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x31F4260", Offset = "0x31F3660", VA = "0x1831F4260")]
		private void CNMMMIHCFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x31F3620", Offset = "0x31F2A20", VA = "0x1831F3620")]
		private JobHandle BGKKHGBPFFG(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x31F4D20", Offset = "0x31F4120", VA = "0x1831F4D20")]
		private void KAJNIGAMCEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x31F5570", Offset = "0x31F4970", VA = "0x1831F5570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x31F5540", Offset = "0x31F4940", VA = "0x1831F5540", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public abstract class PCIKMMGBFEM : DHDEFGPGMMG, FPHKGEBJIKC
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct LMDMLIAMAPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public NativeListAsync<Entity> OAJOEDDBLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public NativeListAsync<Entity> FJHNANDIFHE;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x4764120", Offset = "0x4763520", VA = "0x184764120")]
		public LMDMLIAMAPJ(NativeList<Entity> OAJOEDDBLOD, NativeList<Entity> FJHNANDIFHE, JobHandle GNEAPAJLKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x47640A0", Offset = "0x47634A0", VA = "0x1847640A0")]
		public JobHandle PBKOIJEMIDF(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x4764010", Offset = "0x4763410", VA = "0x184764010", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct JMHLIJLIMFD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum OHGCIBGJCEP
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
		public NativeList<Entity> NDDGKAJIPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> OGBKKKBDHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> DHKFLGCKLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> CMBIJAGAABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public ComponentDataFromEntity NFIKKPBHMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public ComponentDataFromEntity OANNLJALGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> LMKFMOLPBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int OFNNGJDBJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int PCHMLGCKCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private OHGCIBGJCEP MDBJGCBLKKA;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x4762EA0", Offset = "0x47622A0", VA = "0x184762EA0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x4762CB0", Offset = "0x47620B0", VA = "0x184762CB0")]
		private void BJCGBAHDMJE(Entity OAOGLFGGBPI, bool NJCBPCFIKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x4763310", Offset = "0x4762710", VA = "0x184763310")]
		private void MIMDKKLLJKN(Entity OAOGLFGGBPI, bool NJCBPCFIKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x4763030", Offset = "0x4762430", VA = "0x184763030")]
		public LMDMLIAMAPJ GLPJPIHHPHD(NativeArray<Entity> JGJKBMBOGAH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x4762E20", Offset = "0x4762220", VA = "0x184762E20")]
		public LMDMLIAMAPJ EPMIHLCLCDD(NativeArray<Entity> JGJKBMBOGAH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x4762D40", Offset = "0x4762140", VA = "0x184762D40")]
		public LMDMLIAMAPJ CCHHAEFJINE(NativeList<LMIKKFINNNK> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x4763500", Offset = "0x4762900", VA = "0x184763500")]
		public LMDMLIAMAPJ NAPDDDHFLGP(NativeList<LMIKKFINNNK> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x4763420", Offset = "0x4762820", VA = "0x184763420")]
		public LMDMLIAMAPJ NANEMKECHIP(NativeList<CCLINJKNNFF> NHOGENNANEB, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3AD0", Offset = "0x5AD2ED0", VA = "0x185AD3AD0")]
		private LMDMLIAMAPJ KJBFOFDKFOF<T>(NativeList<T> NHOGENNANEB, int PBIPNMLPAMF, int BEJPMFNJOJD, OHGCIBGJCEP PDGDINPCGGH, JobHandle MEDEIGIKJJO) where T : struct
		{
			return default(LMDMLIAMAPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x47630B0", Offset = "0x47624B0", VA = "0x1847630B0")]
		private LMDMLIAMAPJ KJBFOFDKFOF(NativeArray<Entity> GNGEEFEGDCP, int PBIPNMLPAMF, int BEJPMFNJOJD, OHGCIBGJCEP PDGDINPCGGH, JobHandle MEDEIGIKJJO)
		{
			return default(LMDMLIAMAPJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery JNNCLMGAKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery BLGFBAFBMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private BCCHDFPAANJ PIEJKHPDGJK;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType MHOCPBNFJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType DFAGGHLEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType IOBOLGCGMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x3697470", Offset = "0x3696870", VA = "0x183697470")]
	protected PCIKMMGBFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x3695FA0", Offset = "0x36953A0", VA = "0x183695FA0", Slot = "14")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x3696330", Offset = "0x3695730", VA = "0x183696330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x3696560", Offset = "0x3695960", VA = "0x183696560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xB3D010", Offset = "0xB3C410", VA = "0x180B3D010", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x36962D0", Offset = "0x36956D0", VA = "0x1836962D0")]
	private void MFNEIFCODOD(NativeArray<Entity> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x36973D0", Offset = "0x36967D0", VA = "0x1836973D0")]
	private void PIPNGOBOKDF(NativeArray<Entity> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x3695DF0", Offset = "0x36951F0", VA = "0x183695DF0")]
	private void HNEHALMHICO(LMDMLIAMAPJ CLJKPGCKBPN, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x3695CE0", Offset = "0x36950E0", VA = "0x183695CE0")]
	private void HNEHALMHICO(NativeListAsync<Entity> KPCAHJCNBDC, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x3696080", Offset = "0x3695480", VA = "0x183696080")]
	private void MBEJGFOGIPH(LMDMLIAMAPJ CLJKPGCKBPN, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x36961C0", Offset = "0x36955C0", VA = "0x1836961C0")]
	private void MBEJGFOGIPH(NativeListAsync<Entity> KPCAHJCNBDC, string BNLEAMMLCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x3695F30", Offset = "0x3695330", VA = "0x183695F30")]
	private bool INEAKPJMHNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class JNEFMKCCKHE : DHDEFGPGMMG, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct PBFOCALMOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public JNEFMKCCKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public PBFOCALMOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PJDEIBBFNEK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct JGPOOCIDLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct GGOOLDIBPBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime CHMHDPOCLGM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FOKALLBHGDF;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x4761F60", Offset = "0x4761360", VA = "0x184761F60")]
			public void BHIDKDBKBAC(JNEFMKCCKHE MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x4761F70", Offset = "0x4761370", VA = "0x184761F70")]
			public GGOOLDIBPBI OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(GGOOLDIBPBI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public JNEFMKCCKHE BFAPLOAAIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer MCOIHMEDDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private JGPOOCIDLHM LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JGPOOCIDLHM.GGOOLDIBPBI* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x4765C30", Offset = "0x4765030", VA = "0x184765C30")]
		internal void AOFNEGGIPNF(Entity LBPJAILMLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x475ED60", Offset = "0x475E160", VA = "0x18475ED60", Slot = "5")]
		public void ReadFromDisplayClass(ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x475ED90", Offset = "0x475E190", VA = "0x18475ED90", Slot = "6")]
		public void WriteToDisplayClass(ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x4765D80", Offset = "0x4765180", VA = "0x184765D80", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x4765DD0", Offset = "0x47651D0", VA = "0x184765DD0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref JGPOOCIDLHM.GGOOLDIBPBI DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x4765D40", Offset = "0x4765140", VA = "0x184765D40")]
		public void BHIDKDBKBAC(JNEFMKCCKHE MFPLGOJOEDD, ref PBFOCALMOJM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x4765BC0", Offset = "0x4764FC0", VA = "0x184765BC0")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private GKLOHLMMION OKOMBANGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery DEABFFPIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker NFDECGAIHKN;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A500", Offset = "0x3A49900", VA = "0x183A4A500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A6B0", Offset = "0x3A49AB0", VA = "0x183A4A6B0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A560", Offset = "0x3A49960", VA = "0x183A4A560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public JNEFMKCCKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A420", Offset = "0x3A49820", VA = "0x183A4A420", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A250", Offset = "0x3A49650", VA = "0x183A4A250")]
	public static EntityQuery AEPGBDCFMBL(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[LOFBNDLMONN]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class KHJKLIHDMCF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService KPLEIKICILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D2F0", Offset = "0x3A4C6F0", VA = "0x183A4D2F0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CF00", Offset = "0x3A4C300", VA = "0x183A4CF00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CFA0", Offset = "0x3A4C3A0", VA = "0x183A4CFA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public KHJKLIHDMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct PAEMMFFCJJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public LPABFJLFMIG KJNCDAGJAPF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30")]
	public static PAEMMFFCJJL LOJIFGBJNLM(in LPABFJLFMIG JJNBMHNJAOL)
	{
		return default(PAEMMFFCJJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30")]
	public static LPABFJLFMIG LOJIFGBJNLM(in PAEMMFFCJJL DFPHPOJNCKP)
	{
		return default(LPABFJLFMIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class GKLOHLMMION : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F500", Offset = "0x3A3E900", VA = "0x183A3F500", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	public GKLOHLMMION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class KFDCJLIMNBH : DHDEFGPGMMG, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct EDELEMGAECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public KFDCJLIMNBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public EDELEMGAECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__0(Entity e, PAEMMFFCJJL ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FCFFCBACPKF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct BJOIHJGIEKI
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct HFHLJCMGPLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime CHMHDPOCLGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<PAEMMFFCJJL>.Runtime BNDAAFBCMEN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FOKALLBHGDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PAEMMFFCJJL> HOAPAACGMHI;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x475C450", Offset = "0x475B850", VA = "0x18475C450")]
			public void BHIDKDBKBAC(KFDCJLIMNBH MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x475C4B0", Offset = "0x475B8B0", VA = "0x18475C4B0")]
			public HFHLJCMGPLF OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(HFHLJCMGPLF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public KFDCJLIMNBH BFAPLOAAIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer MCOIHMEDDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private BJOIHJGIEKI LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BJOIHJGIEKI.HFHLJCMGPLF* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x475EA80", Offset = "0x475DE80", VA = "0x18475EA80")]
		internal void AOFNEGGIPNF(Entity LBPJAILMLKD, PAEMMFFCJJL IFJLGNNKAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x475ED60", Offset = "0x475E160", VA = "0x18475ED60", Slot = "5")]
		public void ReadFromDisplayClass(ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x475ED90", Offset = "0x475E190", VA = "0x18475ED90", Slot = "6")]
		public void WriteToDisplayClass(ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x475EC10", Offset = "0x475E010", VA = "0x18475EC10", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x475ECB0", Offset = "0x475E0B0", VA = "0x18475ECB0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref BJOIHJGIEKI.HFHLJCMGPLF DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x475EB80", Offset = "0x475DF80", VA = "0x18475EB80")]
		public void BHIDKDBKBAC(KFDCJLIMNBH MFPLGOJOEDD, ref EDELEMGAECM IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x475EA10", Offset = "0x475DE10", VA = "0x18475EA10")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private GKLOHLMMION OKOMBANGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery ONIJHELACPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker KIAOIFCFILF;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CB50", Offset = "0x3A4BF50", VA = "0x183A4CB50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CD10", Offset = "0x3A4C110", VA = "0x183A4CD10", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CBB0", Offset = "0x3A4BFB0", VA = "0x183A4CBB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public KFDCJLIMNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4CA70", Offset = "0x3A4BE70", VA = "0x183A4CA70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C8A0", Offset = "0x3A4BCA0", VA = "0x183A4C8A0")]
	public static EntityQuery IHDNEPHLCCO(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct JIFMPAJIHCF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public HNJLOOJCIKA ELCDAMLJAMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, CHLMDABNGKB> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x4762000", Offset = "0x4761400", VA = "0x184762000")]
			public JIFMPAJIHCF(int DOMGBHGFPFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x4761F80", Offset = "0x4761380", VA = "0x184761F80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct LNOPILAFFLF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> NCEGELMEING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> OGHJHMOKOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x4764210", Offset = "0x4763610", VA = "0x184764210", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct FNCJENOONDD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> NCEGELMEING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x475F260", Offset = "0x475E660", VA = "0x18475F260", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private DPHIHEMGLPB JIHJABJGCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery AFCFJFEACJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery OFCNMPFNJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery GCDMOGEEFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery LKLHAJFAJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery CNLCPPDKCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle DJMCAHPHCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private JIFMPAJIHCF FJFMCFPKAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private JIFMPAJIHCF IIMLLFHHDGG;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x369B230", Offset = "0x369A630", VA = "0x18369B230", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x369A7D0", Offset = "0x3699BD0", VA = "0x18369A7D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x3699D30", Offset = "0x3699130", VA = "0x183699D30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x369AA90", Offset = "0x3699E90", VA = "0x18369AA90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x3699D70", Offset = "0x3699170", VA = "0x183699D70")]
		private void DBHLILFIPBM(EntityQuery JLMGAJOHFKO, out (NativeArrayAsync<PAEMMFFCJJL> handles, NativeArrayAsync<PBPGODBNIIF> bounds) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x369A570", Offset = "0x3699970", VA = "0x18369A570")]
		private void IPONHGIBEFF((NativeArrayAsync<PAEMMFFCJJL> handles, NativeArrayAsync<PBPGODBNIIF> bounds) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x3699D30", Offset = "0x3699130", VA = "0x183699D30")]
		private void AJKPOPHOPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x369A300", Offset = "0x3699700", VA = "0x18369A300")]
		private void HIHKAHJLEJO(EntityQuery JLMGAJOHFKO, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<PAEMMFFCJJL> handles) ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x369A010", Offset = "0x3699410", VA = "0x18369A010")]
		private void EPHHMEDKMDP((NativeArrayAsync<Entity> entities, NativeArrayAsync<PAEMMFFCJJL> handles) ONIBEFDCPGD, JIFMPAJIHCF HNCPDLIBBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3699EB0", Offset = "0x36992B0", VA = "0x183699EB0")]
		private JobHandle DPBGCNAPMBN(JIFMPAJIHCF HNCPDLIBBAB, ComponentDataFromEntity<WorldPoseData> NCEGELMEING, ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH, ComponentDataFromEntity<WorldDeformableScaleData> OGHJHMOKOIM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x369A440", Offset = "0x3699840", VA = "0x18369A440")]
		private JobHandle IANPGMDPOOH(JIFMPAJIHCF HNCPDLIBBAB, ComponentDataFromEntity<WorldPoseData> NCEGELMEING, ComponentDataFromEntity<WorldUniformScaleData> KEGJMHKFCFH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct OHBHHABGBMM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class SplineLocalBoundsSystem : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct EBKPOLNMPEN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> HDKAJPECANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> CGFNFEOHGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<PBPGODBNIIF> OAEKMIFBBHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, CHLMDABNGKB>.ParallelWriter DNHNPHJILIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CDNKHMIIJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter GLOHIMFBLCL;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x475DDA0", Offset = "0x475D1A0", VA = "0x18475DDA0", Slot = "4")]
			public void Execute(int BELCAJFDAHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct PKHPJBKDHKD : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> PMPIJFBGLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> NGOPFBDABOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> JFIKMEPDDKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<PBPGODBNIIF> EIENBKLGCOC;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x4765E40", Offset = "0x4765240", VA = "0x184765E40", Slot = "4")]
			public void Execute(int BELCAJFDAHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery ICBOJPIMFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery EKKOJMBJHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery IGDINACNKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery IAEGLEMMFOM;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x37AFED0", Offset = "0x37AF2D0", VA = "0x1837AFED0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x37B00E0", Offset = "0x37AF4E0", VA = "0x1837B00E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x37AFC10", Offset = "0x37AF010", VA = "0x1837AFC10")]
		private JobHandle NKIHHBLDNCB(NativeArrayAsync<Entity> PFCDNINKMFA, int ONCBCCLEFOH, JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x37AFCF0", Offset = "0x37AF0F0", VA = "0x1837AFCF0")]
		private JobHandle NKIHHBLDNCB(NativeArray<Entity> EDGCKJPPCNA, int ONCBCCLEFOH, [Optional] JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x37AF0F0", Offset = "0x37AE4F0", VA = "0x1837AF0F0")]
		private NativeArrayAsync<Entity> ACOCCFAIDOG(EntityQuery JLMGAJOHFKO)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x37AF170", Offset = "0x37AE570", VA = "0x1837AF170")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) ADKJOFKDKLM(NativeArrayAsync<Entity> IAMGJMABCOF)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x37AFA20", Offset = "0x37AEE20", VA = "0x1837AFA20")]
		private void LADPEELPKPO(out NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x37AFB80", Offset = "0x37AEF80", VA = "0x1837AFB80")]
		private void NJLJGLMANAD(NativeList<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x37AFAB0", Offset = "0x37AEEB0", VA = "0x1837AFAB0")]
		private void NJLJGLMANAD(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x37AF8F0", Offset = "0x37AECF0", VA = "0x1837AF8F0")]
		private void EHJMPFLMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void MKFBMLAPBOO(int MMEGPPKAEIB, int AFIENCCHJBK, int GLEGLJOKLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x37AF5C0", Offset = "0x37AE9C0", VA = "0x1837AF5C0")]
		private static PBPGODBNIIF DIOGHNDFPPP(NativeArray<Entity> FHOKLGFMOHD, ComponentDataFromEntity<SplinePointPositionData> JFIKMEPDDKC, ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK)
		{
			return default(PBPGODBNIIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct MDFGPEKPEHE : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	public class DestroyLocalObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery HABFILNCFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery PFJAPHDBGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x36E9690", Offset = "0x36E8A90", VA = "0x1836E9690", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x36E9260", Offset = "0x36E8660", VA = "0x1836E9260")]
		public bool EGAEJNEMACJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x36E9540", Offset = "0x36E8940", VA = "0x1836E9540", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x36E9310", Offset = "0x36E8710", VA = "0x1836E9310", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x36E9670", Offset = "0x36E8A70", VA = "0x1836E9670", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x25BC870", Offset = "0x25BBC70", VA = "0x1825BC870", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x36E9310", Offset = "0x36E8710", VA = "0x1836E9310")]
		private void JENDOENGMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x36E9350", Offset = "0x36E8750", VA = "0x1836E9350")]
		private void JLGHFMGGIMA(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x36E9400", Offset = "0x36E8800", VA = "0x1836E9400")]
		private void NPEIFHCLGLP(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x36E9820", Offset = "0x36E8C20", VA = "0x1836E9820")]
		private void PPCDKKLHCJP(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x36E9700", Offset = "0x36E8B00", VA = "0x1836E9700")]
		private void PGHIAFKMBHG(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static ENELKKCPMCO[] CEKIKBHMIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private BKOAPAPEJAI GNBJBEPJLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private KHFJEIHOPJL EOPODOHPKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A370", Offset = "0x3A39770", VA = "0x183A3A370", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A2B0", Offset = "0x3A396B0", VA = "0x183A3A2B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x3A39D20", Offset = "0x3A39120", VA = "0x183A39D20")]
		private void ACFNKIFGPJN(ENELKKCPMCO KGOFCGFBHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private void CEPHILAPHPH(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA, GKFDLLIKKMD IPFKDLFGNOG, GBDBBLLJIJK LLNCPHJHCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[MBALNPKLAGP(FOFKCKDBIPD.Callbacks)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public sealed class PropertyEventCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService OBOKKBNADPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase KGOFCGFBHNK;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x36A08C0", Offset = "0x369FCC0", VA = "0x1836A08C0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x36A07C0", Offset = "0x369FBC0", VA = "0x1836A07C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	internal class TransmitNetworkDataSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private IPBKNNKPCHC CGLLMAJNLJD;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x37B7530", Offset = "0x37B6930", VA = "0x1837B7530", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x37B74E0", Offset = "0x37B68E0", VA = "0x1837B74E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[LOFBNDLMONN]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	public class CalculateCullingBandChanges : DHDEFGPGMMG, LFPMKPLIAAM, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct AEHGEJHBPLO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType ABFNOJJIFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> MFKFFPDJGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<MMJDEMOFKKF>.ParallelWriter IBIFFOPBKKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<GEOLEJFMBML> LJPOLDBBADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 MOOHJICILGA;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 OAOFBIAANMO;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 JOOHFHJIEBL;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 LNHJJAJKCHH;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x37A20A0", Offset = "0x37A14A0", VA = "0x1837A20A0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int GHJKICBPJKL = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double OBCODDGIGAD = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery EIPKPAJBHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery MCBJIKLJLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double KFINHOHHMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService MCODOOGFPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService JOGKAGECKFN;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x36D9E50", Offset = "0x36D9250", VA = "0x1836D9E50", Slot = "14")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x36DA510", Offset = "0x36D9910", VA = "0x1836DA510", Slot = "15")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x36DA1A0", Offset = "0x36D95A0", VA = "0x1836DA1A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x36DA2F0", Offset = "0x36D96F0", VA = "0x1836DA2F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x36D9DE0", Offset = "0x36D91E0", VA = "0x1836D9DE0")]
		private bool GPPBBLMCCPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x36D9E60", Offset = "0x36D9260", VA = "0x1836D9E60")]
		private void OAGCDDBNBDB(EntityQuery JLMGAJOHFKO, float3 OPLAFBPCIEH, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct MMJDEMOFKKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public LJKHPCCHKIO IAMOONJKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public LJKHPCCHKIO AFLEFPKENKF;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService MCODOOGFPIB;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x369D690", Offset = "0x369CA90", VA = "0x18369D690", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x369D670", Offset = "0x369CA70", VA = "0x18369D670", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class UpdateInertialProperties : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery HIJDJAJMKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private NNABLGDOJFG EKFCAEOLCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x37BE380", Offset = "0x37BD780", VA = "0x1837BE380", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x37BE050", Offset = "0x37BD450", VA = "0x1837BE050", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x37BE0E0", Offset = "0x37BD4E0", VA = "0x1837BE0E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[LOFBNDLMONN]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GHBMLKHDBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PIOIOICCPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OKCAEOJCPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService KDCKCPKFAAP;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A39B70", Offset = "0x3A38F70", VA = "0x183A39B70", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A394A0", Offset = "0x3A388A0", VA = "0x183A394A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A38930", Offset = "0x3A37D30", VA = "0x183A38930")]
		private void FNBLDDLEBKA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NHOGENNANEB, EntityQueryDesc DEBKCIPIIEB, bool IHFIBCKLILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A387F0", Offset = "0x3A37BF0", VA = "0x183A387F0")]
		private void FNBLDDLEBKA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NHOGENNANEB, EntityQueryDesc DEBKCIPIIEB, bool IHFIBCKLILB, bool BNEEGIEDHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A39700", Offset = "0x3A38B00", VA = "0x183A39700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A38C60", Offset = "0x3A38060", VA = "0x183A38C60")]
		private void HFOIEEGNPME(EntityQuery JLMGAJOHFKO, bool DNPGIIMBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A38EE0", Offset = "0x3A382E0", VA = "0x183A38EE0")]
		private void JMKJECHDJHF(EntityQuery JLMGAJOHFKO, bool PMCOBFBKIAH, bool DNPGIIMBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A38A40", Offset = "0x3A37E40", VA = "0x183A38A40")]
		private void HBBKCPMFFHA(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A392F0", Offset = "0x3A386F0", VA = "0x183A392F0")]
		private void NOOBELOGIPP(NativeList<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A386D0", Offset = "0x3A37AD0", VA = "0x183A386D0")]
		private void DBHADAGANBB(NativeArray<Entity> GNGEEFEGDCP, bool PMCOBFBKIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A390F0", Offset = "0x3A384F0", VA = "0x183A390F0")]
		private NativeList<Entity> JPKGKIIGCAF(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A39BC0", Offset = "0x3A38FC0", VA = "0x183A39BC0")]
		private NativeList<Entity> PELLKDJOKFH(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A39460", Offset = "0x3A38860", VA = "0x183A39460")]
		private NativeList<Entity> OMMNPBDOJOF(NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A399D0", Offset = "0x3A38DD0", VA = "0x183A399D0")]
		private NativeList<Entity> PBBIHOLEJKE(NativeArray<Entity> GNGEEFEGDCP, bool LKEOIFNOBLC)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A38E50", Offset = "0x3A38250", VA = "0x183A38E50")]
		private PLJOAMLOBDL HHGFAEDKPBK(NativeArray<Entity> GNGEEFEGDCP)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(PLJOAMLOBDL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A39C50", Offset = "0x3A39050", VA = "0x183A39C50")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService KDCKCPKFAAP;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x369D700", Offset = "0x369CB00", VA = "0x18369D700", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x369D6E0", Offset = "0x369CAE0", VA = "0x18369D6E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : ILHKCJPPBMP
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery OJDFIJPKHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery IPGJLCNKJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery GOEAJLPENDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery KGDACKLNBEG;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x36E8ED0", Offset = "0x36E82D0", VA = "0x1836E8ED0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x36E9090", Offset = "0x36E8490", VA = "0x1836E9090", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x36E8A50", Offset = "0x36E7E50", VA = "0x1836E8A50")]
		private void CPIHMAOLCBE(EntityQuery JLMGAJOHFKO, bool FLGDGHMLIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x36E8C90", Offset = "0x36E8090", VA = "0x1836E8C90")]
		private void LCHEFAHOMGN(EntityQuery JLMGAJOHFKO, bool FLGDGHMLIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class AssignPlayerIdsSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery GBIKPKILAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery PCDEOKFCOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService KJGMKGKKNGC;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x36D3930", Offset = "0x36D2D30", VA = "0x1836D3930", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x36D3800", Offset = "0x36D2C00", VA = "0x1836D3800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x36D3910", Offset = "0x36D2D10", VA = "0x1836D3910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x36D3010", Offset = "0x36D2410", VA = "0x1836D3010")]
		private void GKLJBFJEJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x36D3550", Offset = "0x36D2950", VA = "0x1836D3550")]
		private void NNHFNBNBBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x36D3230", Offset = "0x36D2630", VA = "0x1836D3230")]
		private void NDGIHFJHLPD(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x36D36C0", Offset = "0x36D2AC0", VA = "0x1836D36C0")]
		private void NNIONKONFJA(NativeArray<Entity> GNGEEFEGDCP, int JKINPFDPJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x36D3120", Offset = "0x36D2520", VA = "0x1836D3120")]
		private void MLEANBHJBCE(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x36D2FB0", Offset = "0x36D23B0", VA = "0x1836D2FB0")]
		private void FJLLFANBLFP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void MBPIBAFELKF(int PMIGFHIBOOC, Transform LJLOGOIJMEM, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class FDIALEEDHJL
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CB90", Offset = "0x3A3BF90", VA = "0x183A3CB90")]
	public static bool DHOGAMHCJNH(this SystemBase DCOPHBBEGEL, out Entity OAOGLFGGBPI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery HAGJFHJGKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private CGLADJHJCEM JPIIPGKJJOO;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x36DBE20", Offset = "0x36DB220", VA = "0x1836DBE20", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x36DBCF0", Offset = "0x36DB0F0", VA = "0x1836DBCF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x36DBDB0", Offset = "0x36DB1B0", VA = "0x1836DBDB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<OJAPCNHANOE>, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string ECLGCHIFILN = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private DEMDCLJBMBJ MCLILDBFPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery OIOOCCDEAFB;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity KACOPDDEDFC
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x3684B50", Offset = "0x3683F50", VA = "0x183684B50")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x36846C0", Offset = "0x3683AC0", VA = "0x1836846C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity NLMPEJILEOF
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x3684720", Offset = "0x3683B20", VA = "0x183684720")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public NFJEDPPAJMK KFAFBGNOICJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x3684C30", Offset = "0x3684030", VA = "0x183684C30")]
			get
			{
				return default(NFJEDPPAJMK);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x3684EB0", Offset = "0x36842B0", VA = "0x183684EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public NFJEDPPAJMK CKAEEGNCAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x3684CC0", Offset = "0x36840C0", VA = "0x183684CC0")]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x3684D90", Offset = "0x3684190", VA = "0x183684D90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x3684F20", Offset = "0x3684320", VA = "0x183684F20", Slot = "15")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x3684E30", Offset = "0x3684230", VA = "0x183684E30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x3684F90", Offset = "0x3684390", VA = "0x183684F90", Slot = "14")]
		protected override void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x3684A70", Offset = "0x3683E70", VA = "0x183684A70")]
		private void FFNGBDGCJAH(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x3684780", Offset = "0x3683B80", VA = "0x183684780")]
		private void DIEHJBIMEIL(Entity OAOGLFGGBPI, Entity NPHFOCPHDMJ, Entity DGNNOBANMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x33AC980", Offset = "0x33ABD80", VA = "0x1833AC980")]
		private bool GIGJNHOBOLH<T>(out T JFBPNBNBHOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x33AC8C0", Offset = "0x33ABCC0", VA = "0x1833AC8C0")]
		private void BFDDADMOHJF<T>(T JFBPNBNBHOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x3684BB0", Offset = "0x3683FB0", VA = "0x183684BB0")]
		public bool HOMAPCMFJKC(NFJEDPPAJMK DCPANEJBMLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x3684A40", Offset = "0x3683E40", VA = "0x183684A40")]
		private static bool EJAPHKJIGEF(NFJEDPPAJMK HJNHKENHAKD, NFJEDPPAJMK PNOEOKEDDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x3685130", Offset = "0x3684530", VA = "0x183685130")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x3684D50", Offset = "0x3684150", VA = "0x183684D50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x36E47D0", Offset = "0x36E3BD0", VA = "0x1836E47D0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x36E42E0", Offset = "0x36E36E0", VA = "0x1836E42E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x36E4380", Offset = "0x36E3780", VA = "0x1836E4380", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x36E4080", Offset = "0x36E3480", VA = "0x1836E4080")]
		private NativeArray<Entity> JFPEDLFHGAP(int OCCKKIPCFBH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x36E41D0", Offset = "0x36E35D0", VA = "0x1836E41D0")]
		private void JJOGPHJGJEL(NativeArray<Entity> KLOACGKPFHH, NativeArray<Entity> NHCNGFJEBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class HideRemotePivotsNotInScope : DHDEFGPGMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery CKNPMJDDFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery CHIEBAOILAL;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x3A42810", Offset = "0x3A41C10", VA = "0x183A42810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x3A42900", Offset = "0x3A41D00", VA = "0x183A42900", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class PDAEDGFJOLO
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string PFBPLPFFABG = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x327DCB0", Offset = "0x327D0B0", VA = "0x18327DCB0")]
	public static NativeArray<T> KJBFOFDKFOF<T>(NativeArray<Entity> GNGEEFEGDCP, EntityManager KNABDDPENKI) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x36975E0", Offset = "0x36969E0", VA = "0x1836975E0")]
	public static void CGLPGEGJOJC(EntityQuery JLMGAJOHFKO, EntityManager KNABDDPENKI, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x36974B0", Offset = "0x36968B0", VA = "0x1836974B0")]
	public static void BFGHFGNFFIL(NativeArray<Entity> KLOACGKPFHH, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x3697720", Offset = "0x3696B20", VA = "0x183697720")]
	public static void EGDHMAACHAB(NativeArray<Entity> KLOACGKPFHH, NPFNHEGAPFJ KEFDOOCIHFG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x37BDF70", Offset = "0x37BD370", VA = "0x1837BDF70", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x37BDEC0", Offset = "0x37BD2C0", VA = "0x1837BDEC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x37BDF60", Offset = "0x37BD360", VA = "0x1837BDF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x37BCA80", Offset = "0x37BBE80", VA = "0x1837BCA80")]
		private void CBPGPKAPELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x37BD4E0", Offset = "0x37BC8E0", VA = "0x1837BD4E0")]
		private void LFEIGFLEHJN(NativeArray<Entity> KLOACGKPFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x37BD5F0", Offset = "0x37BC9F0", VA = "0x1837BD5F0")]
		private void MLNCDPENHNL(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x37BD290", Offset = "0x37BC690", VA = "0x1837BD290")]
		private void CEJMMJGFINE(NativeArray<Entity> NHCNGFJEBDM, NativeArray<RigidTransform> FLKBEPEJPKF, NativeArray<RigidTransform> HFEMGCMKDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x37BC5F0", Offset = "0x37BB9F0", VA = "0x1837BC5F0")]
		private void AFJIDIENBEA(NativeArray<RigidTransform> HFEMGCMKDMO, NativeArray<Entity> NHCNGFJEBDM, NativeList<Entity> ICNAFJODPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class PostGameplayOnScopeChange : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery HAGJFHJGKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery GOLLAJMOAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x369BEA0", Offset = "0x369B2A0", VA = "0x18369BEA0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x369BC90", Offset = "0x369B090", VA = "0x18369BC90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x369BDE0", Offset = "0x369B1E0", VA = "0x18369BDE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x369BC20", Offset = "0x369B020", VA = "0x18369BC20")]
		private void NIFLGEJJAKF(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery KNIJJFPELEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents NKDKBMKAAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private CGLADJHJCEM JPIIPGKJJOO;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x369D590", Offset = "0x369C990", VA = "0x18369D590", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x369D4E0", Offset = "0x369C8E0", VA = "0x18369D4E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x369D580", Offset = "0x369C980", VA = "0x18369D580", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x369D350", Offset = "0x369C750", VA = "0x18369D350")]
		private void OIGFEAAGNIA(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<FGFDDMCIDKL>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x37A82E0", Offset = "0x37A76E0", VA = "0x1837A82E0", Slot = "14")]
		protected override void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x37A8430", Offset = "0x37A7830", VA = "0x1837A8430")]
		[BurstCompile]
		private static void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> MIEJHEFMMGG, ComponentDataFromEntity<global::MMOLLCEJBDE> HPGHKCBEMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x37A8500", Offset = "0x37A7900", VA = "0x1837A8500")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x37A82A0", Offset = "0x37A76A0", VA = "0x1837A82A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[MBALNPKLAGP(FOFKCKDBIPD.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : DHDEFGPGMMG where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery BJLBDFNCDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery GKGPLPKAGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery HGJGNOBDKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery JLHPGGIPDJH;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x37486D0", Offset = "0x3747AD0", VA = "0x1837486D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x37488D0", Offset = "0x3747CD0", VA = "0x1837488D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x37488A0", Offset = "0x3747CA0", VA = "0x1837488A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x37480C0", Offset = "0x37474C0", VA = "0x1837480C0")]
		private void JMBDHOMBLPL(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3746C00", Offset = "0x3746000", VA = "0x183746C00")]
		private void HDJDIOMOILL(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3747830", Offset = "0x3746C30", VA = "0x183747830")]
		private void HKGFOMHIDJD(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void PPCNFBFPMCP(NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> FIFIOMIMFNI, NativeArray<Entity> MIEJHEFMMGG);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3748960", Offset = "0x3747D60", VA = "0x183748960")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x1B74E80", Offset = "0x1B74280", VA = "0x181B74E80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class BAJLNEMLKBP : DHDEFGPGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> LHDIADGEJKI;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x36D39F0", Offset = "0x36D2DF0", VA = "0x1836D39F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x36D3BF0", Offset = "0x36D2FF0", VA = "0x1836D3BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x36D3D40", Offset = "0x36D3140", VA = "0x1836D3D40")]
	public BAJLNEMLKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct HMDBPEFKDBJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int ICGLEEKOOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int DMLEMNEAJDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x17167E0", Offset = "0x1715BE0", VA = "0x1817167E0")]
	public static Entity LOJIFGBJNLM(HMDBPEFKDBJ ONIBEFDCPGD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x17167E0", Offset = "0x1715BE0", VA = "0x1817167E0")]
	public static HMDBPEFKDBJ LOJIFGBJNLM(Entity OAOGLFGGBPI)
	{
		return default(HMDBPEFKDBJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EAKNHDJIPCK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct CFMAIOKLGLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType HBILNHOEIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> GGHFLGHFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> PLGKAEIBFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> GNGEEFEGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> HHLLOPMMJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> JHBHPHLKKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> BEKIFNKENPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int ENFCEHCBAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool CELDDGFEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x36D8870", Offset = "0x36D7C70", VA = "0x1836D8870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x36D8C90", Offset = "0x36D8090", VA = "0x1836D8C90")]
	public CFMAIOKLGLK(ComponentType HBILNHOEIJP, NativeList<int> GGHFLGHFEMD, NativeList<int> PLGKAEIBFCM, NativeArray<Entity> GNGEEFEGDCP, NativeArray<Entity> HHLLOPMMJPK, NativeArray<byte> JHBHPHLKKNF, NativeArray<byte> BEKIFNKENPL, int KKDBIBDEEDA, int ENFCEHCBAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x36D89D0", Offset = "0x36D7DD0", VA = "0x1836D89D0")]
	private LONBCMOJAJF FKLHBEPEAMO(NativeArray<byte> PFCDNINKMFA, int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T FKLHBEPEAMO<T>(NativeArray<byte> PFCDNINKMFA, int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x36D8BF0", Offset = "0x36D7FF0", VA = "0x1836D8BF0")]
	public LONBCMOJAJF JEDLCILCODA(int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T JEDLCILCODA<T>(int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x36D8C40", Offset = "0x36D8040", VA = "0x1836D8C40")]
	public LONBCMOJAJF OBPIOPFKNIK(int BELCAJFDAHD)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T OBPIOPFKNIK<T>(int BELCAJFDAHD) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x36D88F0", Offset = "0x36D7CF0", VA = "0x1836D88F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct OMCDLMPOANH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<FBGJBPABGDC> ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType HBILNHOEIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int ENFCEHCBAIJ;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x3689C20", Offset = "0x3689020", VA = "0x183689C20")]
	public OMCDLMPOANH(ComponentType HBILNHOEIJP, int KKDBIBDEEDA, int ENFCEHCBAIJ, EntityQuery JLMGAJOHFKO, NativeArray<FBGJBPABGDC> ELCMIPNJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x3689BD0", Offset = "0x3688FD0", VA = "0x183689BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct PBFFOMIANOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int BELCAJFDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int PGAMAINOGKP;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
	public PBFFOMIANOH(int BELCAJFDAHD, int PGAMAINOGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct FBGJBPABGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int ELOEOOGBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int PCAHMJECHKC;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
	public FBGJBPABGDC(int ELOEOOGBENM, int PCAHMJECHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct GBDBBLLJIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly NMLCFAIOCDK LIKFEBDBPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int KKDBIBDEEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* JHBHPHLKKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* BEKIFNKENPL;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EDD0", Offset = "0x3A3E1D0", VA = "0x183A3EDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public NMLCFAIOCDK FFBMMDAJDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0")]
		get
		{
			return default(NMLCFAIOCDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EDE0", Offset = "0x3A3E1E0", VA = "0x183A3EDE0")]
	public LONBCMOJAJF PDENJHMAPFE(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3ECE0", Offset = "0x3A3E0E0", VA = "0x183A3ECE0")]
	public LONBCMOJAJF FKFCBPAOIJJ(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x3776AE0", Offset = "0x3775EE0", VA = "0x183776AE0")]
	public T PDENJHMAPFE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x3776AC0", Offset = "0x3775EC0", VA = "0x183776AC0")]
	public T FKFCBPAOIJJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EED0", Offset = "0x3A3E2D0", VA = "0x183A3EED0")]
	public unsafe GBDBBLLJIJK(NMLCFAIOCDK LIKFEBDBPON, int PCAHMJECHKC, byte* JHBHPHLKKNF, byte* BEKIFNKENPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class HHJNKOGKPDA : LINMPAMPHKC, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService FFFJHMGPLAD;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B40", Offset = "0x3A3FF40", VA = "0x183A40B40", Slot = "17")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x3A40AB0", Offset = "0x3A3FEB0", VA = "0x183A40AB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x3A40870", Offset = "0x3A3FC70", VA = "0x183A40870", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	protected HHJNKOGKPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class FOIMEBLICIG
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] DICCOGOFCJL;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class AAGANFGPMAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, OMCDLMPOANH> CGKHLCEONNO;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OMCDLMPOANH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x36CE440", Offset = "0x36CD840", VA = "0x1836CE440")]
		get
		{
			return default(OMCDLMPOANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x36CE4D0", Offset = "0x36CD8D0", VA = "0x1836CE4D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x36CE520", Offset = "0x36CD920", VA = "0x1836CE520")]
	public AAGANFGPMAE(CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x36CDD30", Offset = "0x36CD130", VA = "0x1836CDD30")]
	public bool CPKINNFJFHF(ComponentType HBILNHOEIJP, out OMCDLMPOANH MNKFJJIHAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x36CD9F0", Offset = "0x36CCDF0", VA = "0x1836CD9F0")]
	public Dictionary<ComponentType, OMCDLMPOANH>.Enumerator AHIPNMLLDNB()
	{
		return default(Dictionary<ComponentType, OMCDLMPOANH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x36CDDA0", Offset = "0x36CD1A0", VA = "0x1836CDDA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x36CDFE0", Offset = "0x36CD3E0", VA = "0x1836CDFE0")]
	private void JNIKBKFLDOE(IEnumerable<BCNEEGFPPIH> NBCLHDKKCNA, EntityManager KNABDDPENKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x36CDF30", Offset = "0x36CD330", VA = "0x1836CDF30")]
	private static int JBEOLFNIDCM(BCNEEGFPPIH MBGKNDLKFDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x36CDA80", Offset = "0x36CCE80", VA = "0x1836CDA80")]
	private static NativeArray<FBGJBPABGDC> BMJAFFONEIC(BCNEEGFPPIH MBGKNDLKFDJ, Allocator OPBLDCCKGEG = Allocator.Persistent)
	{
		return default(NativeArray<FBGJBPABGDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface DOBDGKNHJII
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool CELDDGFEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOCBOCJCBIN(out NativeArray<int> KJCOLFIBADD, Allocator OPBLDCCKGEG);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKMBGAHALGF(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP, out OMCDLMPOANH AJMEBMGKGGC);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MKMBGAHALGF(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFMAIOKLGLK FEHBPADFEII(ComponentType HBILNHOEIJP);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JDPCKAFOGOO IBKCIFBPPKJ();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDAGJHLGGFL(JobHandle GNEAPAJLKDP);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
internal interface LJBFLMONAFL
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	EOHNGDMHPEJ EFPANIGJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, GBDBBLLJIJK> POMNHHAKDJK
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle HNKHEPALLHI
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
	bool HBGEMGCKMHE();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPNLAFLJCKH();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNJKDJGDNPJ(ComponentType HBILNHOEIJP, in CFMAIOKLGLK HBJHPADKKFF);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OCLLBEBJMPO(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct JDPCKAFOGOO
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct DAKHKODMHGI : IEnumerator<GBDBBLLJIJK>, IEnumerator, IDisposable, IEnumerable<GBDBBLLJIJK>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, GBDBBLLJIJK> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity OAOGLFGGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> FNFFOLJGBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private GBDBBLLJIJK BEKIFNKENPL;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public GBDBBLLJIJK CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x803C20", Offset = "0x803020", VA = "0x180803C20", Slot = "4")]
			get
			{
				return default(GBDBBLLJIJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x475D390", Offset = "0x475C790", VA = "0x18475D390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x475D3E0", Offset = "0x475C7E0", VA = "0x18475D3E0")]
		internal DAKHKODMHGI(NativeMultiHashMap<Entity, GBDBBLLJIJK> KFCGKKLOJFF, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x475D180", Offset = "0x475C580", VA = "0x18475D180", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x475D150", Offset = "0x475C550", VA = "0x18475D150")]
		public DAKHKODMHGI AHIPNMLLDNB()
		{
			return default(DAKHKODMHGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x475D250", Offset = "0x475C650", VA = "0x18475D250", Slot = "9")]
		private IEnumerator<GBDBBLLJIJK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x475D2F0", Offset = "0x475C6F0", VA = "0x18475D2F0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly LJBFLMONAFL BGHMFEPCABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle EEMENGAFDFO;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int AMKHNDPHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x3A48B20", Offset = "0x3A47F20", VA = "0x183A48B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x3A48920", Offset = "0x3A47D20", VA = "0x183A48920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0xCB2520", Offset = "0xCB1920", VA = "0x180CB2520")]
	public JDPCKAFOGOO(LJBFLMONAFL BGHMFEPCABE, JobHandle EEMENGAFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x3A48D80", Offset = "0x3A48180", VA = "0x183A48D80")]
	public bool HNDLHADPJOO(Allocator OPBLDCCKGEG, out NativeKeyValueArrays<Entity, GBDBBLLJIJK> APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3A48C10", Offset = "0x3A48010", VA = "0x183A48C10")]
	public bool DKLHLMDGNNP(Allocator OPBLDCCKGEG, out (NativeArray<Entity> entities, int uniqueCount) APCBFLNDMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3A48A00", Offset = "0x3A47E00", VA = "0x183A48A00")]
	public DAKHKODMHGI CJKHCAOBOFF(Entity OAOGLFGGBPI)
	{
		return default(DAKHKODMHGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class EOHNGDMHPEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<OMCDLMPOANH> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public OMCDLMPOANH OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x3A35AE0", Offset = "0x3A34EE0", VA = "0x183A35AE0")]
		get
		{
			return default(OMCDLMPOANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x3A35B70", Offset = "0x3A34F70", VA = "0x183A35B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x3A35BB0", Offset = "0x3A34FB0", VA = "0x183A35BB0")]
	public EOHNGDMHPEJ(AAGANFGPMAE CGKHLCEONNO, CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x3A355A0", Offset = "0x3A349A0", VA = "0x183A355A0")]
	public List<OMCDLMPOANH>.Enumerator AHIPNMLLDNB()
	{
		return default(List<OMCDLMPOANH>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x3A35620", Offset = "0x3A34A20", VA = "0x183A35620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x3A357A0", Offset = "0x3A34BA0", VA = "0x183A357A0")]
	private void JNIKBKFLDOE(AAGANFGPMAE CGKHLCEONNO, EntityManager KNABDDPENKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class KDPNKMKDLAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::DGIKCDEPKDI<BCNEEGFPPIH> KNGEPEIOMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World KIIGBAKFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager KNABDDPENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> IEHEJIODGKG;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C670", Offset = "0x3A4BA70", VA = "0x183A4C670")]
	public KDPNKMKDLAM(ObjectInstantiationService DHJNAJDHBIA, CPEFIMBHABA PJGPDAEMPLK, FADHLPPNOEF ICGADBEDOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AF70", Offset = "0x3A4A370", VA = "0x183A4AF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C460", Offset = "0x3A4B860", VA = "0x183A4C460")]
	public bool OHLPFOOMIAD(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4BD20", Offset = "0x3A4B120", VA = "0x183A4BD20")]
	private void LGINHKKOKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B7F0", Offset = "0x3A4ABF0", VA = "0x183A4B7F0")]
	private EntityArchetype JHMNGCOJFLB(EntityArchetype DADKLHEKCJP)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B3C0", Offset = "0x3A4A7C0", VA = "0x183A4B3C0")]
	public static void HMJMJJLCGML(EntityManager FDDCHHJLNLF, EntityManager PMCBFHAJAOJ, NativeArray<Entity> EOPMDICNPHI, NativeArray<EntityArchetype> NHPPGOOBAHO, [Optional] NativeArray<Entity> DGICGHHINEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AE00", Offset = "0x3A4A200", VA = "0x183A4AE00")]
	[Conditional("DEBUG_BUILD")]
	private static void AJKCKJDKMPF(NativeArray<EntityArchetype> FIFGIFGGGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B180", Offset = "0x3A4A580", VA = "0x183A4B180")]
	private static string ENCCFGOODIM(EntityArchetype CAABDGCKDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B040", Offset = "0x3A4A440", VA = "0x183A4B040")]
	[CompilerGenerated]
	internal static void EAOAMDDHBAH(ref Span<ComponentType> MNKPHDHCEDF, ComponentType JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C4C0", Offset = "0x3A4B8C0", VA = "0x183A4C4C0")]
	[CompilerGenerated]
	internal static void PGPHEBEJHFG(Span<ComponentType> PFCDNINKMFA, ref Span<ComponentType> MNKPHDHCEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x3A4C380", Offset = "0x3A4B780", VA = "0x183A4C380")]
	[CompilerGenerated]
	internal static void LLJLECKDCCM(Span<ComponentType> PFCDNINKMFA, ref Span<ComponentType> MNKPHDHCEDF, ComponentType ONPDMHJKADH)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld FHMPGBCOEKP;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x36D2EF0", Offset = "0x36D22F0", VA = "0x1836D2EF0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x36D2E40", Offset = "0x36D2240", VA = "0x1836D2E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct FLBDNOLCEHG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> JDOHCNPIBGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> IPCLJEDBOLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<FBGJBPABGDC> LAMFBEMMFAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<PBFFOMIANOH>.ParallelWriter NCOBIAFJNFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int APFMFONOKKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int MIJACNKDCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x37A3CF0", Offset = "0x37A30F0", VA = "0x1837A3CF0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x37A3E30", Offset = "0x37A3230", VA = "0x1837A3E30")]
			private unsafe int FNPJGENNBMJ(byte* ELEMBGKEMPE, byte* BGHFDNDJKMA)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct JHICOFNPIHB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> NLCHEAKJBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<PBFFOMIANOH> EAPAOOBBMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x37A4620", Offset = "0x37A3A20", VA = "0x1837A4620", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct LFGKIGJMCID : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> NDEJALFCCJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public ComponentDataFromEntity EFILNEPNOPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int KKDBIBDEEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x37A5410", Offset = "0x37A4810", VA = "0x1837A5410", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct GHJMBCPHOID : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, GBDBBLLJIJK> ECALILOKEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> JHBHPHLKKNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> BEKIFNKENPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<FBGJBPABGDC> LIOLINCGCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> PLGKAEIBFCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int PLGECGICBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int ENFCEHCBAIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker FAOJFJCADFM;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x37A3EC0", Offset = "0x37A32C0", VA = "0x1837A3EC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker HJICNBJCEEC;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker GGKEEENCHEF;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker KEJGAJKFEFO;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker LFAGOLBBACH;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker KEHLHFAJDCC;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker JANPDLGEOOH;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker GDKLKKGIGHO;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker NEOLBKGMKBO;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker DGHIMNCGJIP;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker JELDMOBCCLL;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker BMMFIACCAGJ;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker DBMNENCFDAI;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker MJNMKMELCMI;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker ANDOEGKPHEP;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker DANHGNMINME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery GKBBEIMEIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery KBPHPMFNMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery KEBBEHLPPCM;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World JMJANPOMBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x36DDD90", Offset = "0x36DD190", VA = "0x1836DDD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private LJBFLMONAFL BFKMFKKIINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x36DE2F0", Offset = "0x36DD6F0", VA = "0x1836DE2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x36DF0D0", Offset = "0x36DE4D0", VA = "0x1836DF0D0", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "15")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x36DEDD0", Offset = "0x36DE1D0", VA = "0x1836DEDD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x36DEF90", Offset = "0x36DE390", VA = "0x1836DEF90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x36DEF20", Offset = "0x36DE320", VA = "0x1836DEF20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x36DC150", Offset = "0x36DB550", VA = "0x1836DC150")]
		private void CBPBFOPCDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x36DEDB0", Offset = "0x36DE1B0", VA = "0x1836DEDB0")]
		internal void ONNOIGGBOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x36DE5E0", Offset = "0x36DD9E0", VA = "0x1836DE5E0")]
		private void ONNOIGGBOFG(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x36DC500", Offset = "0x36DB900", VA = "0x1836DC500")]
		private void GDGBCEFGLGP(NativeArray<Entity> EOPMDICNPHI, NativeArray<RRObjectPrefabData> HGNEOGGNINJ, ref NativeArray<Entity> JIKKHKNCDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x36DDE50", Offset = "0x36DD250", VA = "0x1836DDE50")]
		internal void JHDKDKHBGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x36DDE70", Offset = "0x36DD270", VA = "0x1836DDE70")]
		private void JHDKDKHBGOE(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x36DD0A0", Offset = "0x36DC4A0", VA = "0x1836DD0A0")]
		internal void IHHEDLFOPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x36DDAB0", Offset = "0x36DCEB0", VA = "0x1836DDAB0")]
		private void IPEEEOKDCID(LJBFLMONAFL BGHMFEPCABE, OMCDLMPOANH AJMEBMGKGGC, bool KINJNAKPOMK, ref JobHandle JKAHDCBCMPG, ref JobHandle NLGJALJNGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x36DC740", Offset = "0x36DBB40", VA = "0x1836DC740")]
		internal bool HPOKFIIECLA(in OMCDLMPOANH BGHFDNDJKMA, out JobHandle KJNCDAGJAPF, out CFMAIOKLGLK GDPOICOMAOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x36DC770", Offset = "0x36DBB70", VA = "0x1836DC770")]
		private bool HPOKFIIECLA(in OMCDLMPOANH BGHFDNDJKMA, bool KINJNAKPOMK, out JobHandle KJNCDAGJAPF, out CFMAIOKLGLK GDPOICOMAOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x36DE420", Offset = "0x36DD820", VA = "0x1836DE420")]
		internal (NativeList<int>, NativeList<int>) NLINGKGJJED(NativeList<PBFFOMIANOH> EAPAOOBBMGJ, int DOMGBHGFPFL, JobHandle MEDEIGIKJJO, out JobHandle GNEAPAJLKDP, Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x36DC450", Offset = "0x36DB850", VA = "0x1836DC450")]
		internal static NativeArray<Entity> EADCJFIJEDO(EntityQuery JLMGAJOHFKO, out JobHandle JCEEGHEHAGP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x36DE270", Offset = "0x36DD670", VA = "0x1836DE270")]
		internal static NativeArray<byte> KMJBGPPAFPI(int NPNCGJAPKIL, out JobHandle AEAFBCLMAIL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x36DE310", Offset = "0x36DD710", VA = "0x1836DE310")]
		internal static NativeArray<byte> NHGHHOKMABG(EntityQuery JLMGAJOHFKO, int NLGBDLLFIPJ, out JobHandle AEAFBCLMAIL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x36DBEC0", Offset = "0x36DB2C0", VA = "0x1836DBEC0")]
		internal static NativeArray<Entity> ACOCCFAIDOG(EntityQuery JLMGAJOHFKO, out JobHandle IOMBFCCNMIL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x36DD840", Offset = "0x36DCC40", VA = "0x1836DD840")]
		internal NativeArray<byte> ILAEEHEKKLB(NativeArray<Entity> GNGEEFEGDCP, OMCDLMPOANH AJMEBMGKGGC, JobHandle MEDEIGIKJJO, out JobHandle GNEAPAJLKDP, Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x36DBFC0", Offset = "0x36DB3C0", VA = "0x1836DBFC0")]
		internal JobHandle BGCCBCNMGOL(in CFMAIOKLGLK ONIBEFDCPGD, in OMCDLMPOANH AJMEBMGKGGC, NativeMultiHashMap<Entity, GBDBBLLJIJK> ECALILOKEOO, JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1C5B150", Offset = "0x1C5A550", VA = "0x181C5B150")]
		private JobHandle HFGOKLFHDID(JobHandle HOLIJANELEK, JobHandle FECDABLMHPH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C5B150", Offset = "0x1C5A550", VA = "0x181C5B150")]
		private JobHandle HFGOKLFHDID(JobHandle HOLIJANELEK, JobHandle FECDABLMHPH, JobHandle NAKCKBDNDBI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateHoverRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct IJHPADLEHPO : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x369DEF0", Offset = "0x369D2F0", VA = "0x18369DEF0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x369DF50", Offset = "0x369D350", VA = "0x18369DF50", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x369DF20", Offset = "0x369D320", VA = "0x18369DF20", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3697470", Offset = "0x3696870", VA = "0x183697470")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateSelectionRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct PDMEBGFPAKO : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x369DF80", Offset = "0x369D380", VA = "0x18369DF80", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x369DFE0", Offset = "0x369D3E0", VA = "0x18369DFE0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x369DFB0", Offset = "0x369D3B0", VA = "0x18369DFB0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3697470", Offset = "0x3696870", VA = "0x183697470")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[LOFBNDLMONN]
public class FLBBDJNLCKP : ILHKCJPPBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D520", Offset = "0x3A3C920", VA = "0x183A3D520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D5B0", Offset = "0x3A3C9B0", VA = "0x183A3D5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public FLBBDJNLCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[LOFBNDLMONN]
public class DKBPFAICKBK : ILHKCJPPBMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct PFEHFEBOKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public PFEHFEBOKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct KHDPHNHLHPP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct DOPKEGCGOLK
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct FOANKNCJOPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime PCEBLCHCHJC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> DBANDHAINFN;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x475DC50", Offset = "0x475D050", VA = "0x18475DC50")]
			public void BHIDKDBKBAC(DKBPFAICKBK MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x475DCB0", Offset = "0x475D0B0", VA = "0x18475DCB0")]
			public FOANKNCJOPA OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(FOANKNCJOPA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager KNABDDPENKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> PNBLHJIMJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private DOPKEGCGOLK LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DOPKEGCGOLK.FOANKNCJOPA* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HDJBFJIALLJ;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x37A5220", Offset = "0x37A4620", VA = "0x1837A5220")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, SplinePointParentData CKJEELMDBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x37A53F0", Offset = "0x37A47F0", VA = "0x1837A53F0", Slot = "5")]
		public void ReadFromDisplayClass(ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x37A5400", Offset = "0x37A4800", VA = "0x1837A5400", Slot = "6")]
		public void WriteToDisplayClass(ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x37A52D0", Offset = "0x37A46D0", VA = "0x1837A52D0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x37A5340", Offset = "0x37A4740", VA = "0x1837A5340")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref DOPKEGCGOLK.FOANKNCJOPA DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x37A5290", Offset = "0x37A4690", VA = "0x1837A5290")]
		public void BHIDKDBKBAC(DKBPFAICKBK MFPLGOJOEDD, ref PFEHFEBOKDA IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x37A51B0", Offset = "0x37A45B0", VA = "0x1837A51B0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x36E7650", Offset = "0x36E6A50", VA = "0x1836E7650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public DKBPFAICKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x36E7420", Offset = "0x36E6820", VA = "0x1836E7420", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x36E7910", Offset = "0x36E6D10", VA = "0x1836E7910")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[LOFBNDLMONN]
public class LMHAMJBPEEL : ILHKCJPPBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery NNHMIIDOGFK;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x3684440", Offset = "0x3683840", VA = "0x183684440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x36844D0", Offset = "0x36838D0", VA = "0x1836844D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public LMHAMJBPEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(FLBBDJNLCKP))]
public class EHGBFCHOFGP : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A33FF0", Offset = "0x3A333F0", VA = "0x183A33FF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public EHGBFCHOFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class NDABIIHCCGC : ILHKCJPPBMP, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct IIJNCIDFPCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<IOLFAAOECPP, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public IIJNCIDFPCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CIDABAMLGFE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct EDFPNOOIAAL
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct FFMFMDDDIID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BNGNICNMLNH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JEFPCLJPLFC;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x475DE60", Offset = "0x475D260", VA = "0x18475DE60")]
			public void BHIDKDBKBAC(NDABIIHCCGC MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x475DEC0", Offset = "0x475D2C0", VA = "0x18475DEC0")]
			public FFMFMDDDIID OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(FFMFMDDDIID);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private EDFPNOOIAAL LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EDFPNOOIAAL.FFMFMDDDIID* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x475C990", Offset = "0x475BD90", VA = "0x18475C990")]
		internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, ObjectNetworkIdComponentData MMOOINOADGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x957610", Offset = "0x956A10", VA = "0x180957610", Slot = "5")]
		public void ReadFromDisplayClass(ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x29CD240", Offset = "0x29CC640", VA = "0x1829CD240", Slot = "6")]
		public void WriteToDisplayClass(ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x475CAA0", Offset = "0x475BEA0", VA = "0x18475CAA0", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x475CB40", Offset = "0x475BF40", VA = "0x18475CB40")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref EDFPNOOIAAL.FFMFMDDDIID DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x475CA10", Offset = "0x475BE10", VA = "0x18475CA10")]
		public void BHIDKDBKBAC(NDABIIHCCGC MFPLGOJOEDD, ref IIJNCIDFPCN IFOILLGAIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x475C920", Offset = "0x475BD20", VA = "0x18475C920")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService OHHOLLBKJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x36885D0", Offset = "0x36879D0", VA = "0x1836885D0", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x3688330", Offset = "0x3687730", VA = "0x183688330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public NDABIIHCCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x3688130", Offset = "0x3687530", VA = "0x183688130", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x3688470", Offset = "0x3687870", VA = "0x183688470")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class HBFIJPFJDNH : ILHKCJPPBMP, DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LDGCEFELFCJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct GIDKBJHGLBL
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct GCMBOELCLPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NDEGDPEAEPB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AFCMHBPALIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> ECKGELJDACG;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x475FEE0", Offset = "0x475F2E0", VA = "0x18475FEE0")]
			public void BHIDKDBKBAC(HBFIJPFJDNH MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x475FF40", Offset = "0x475F340", VA = "0x18475FF40")]
			public GCMBOELCLPO OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
			{
				return default(GCMBOELCLPO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public HBFIJPFJDNH INPNEHDIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private GIDKBJHGLBL LNNGGAHBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GIDKBJHGLBL.GCMBOELCLPO* HNLOOIBKOPF;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x4763AA0", Offset = "0x4762EA0", VA = "0x184763AA0")]
		public void AOFNEGGIPNF(Entity OAOGLFGGBPI, ParentData CEOGJFOKGBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x4763B40", Offset = "0x4762F40", VA = "0x184763B40", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x4763BE0", Offset = "0x4762FE0", VA = "0x184763BE0")]
		public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref GIDKBJHGLBL.GCMBOELCLPO DFAABHJNNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x4763AC0", Offset = "0x4762EC0", VA = "0x184763AC0")]
		public void BHIDKDBKBAC(HBFIJPFJDNH MFPLGOJOEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x4763A30", Offset = "0x4762E30", VA = "0x184763A30")]
		public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery OHDHMGHNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker NHLFBPIFIGD;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A40730", Offset = "0x3A3FB30", VA = "0x183A40730", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A404C0", Offset = "0x3A3F8C0", VA = "0x183A404C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public HBFIJPFJDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A400D0", Offset = "0x3A3F4D0", VA = "0x183A400D0")]
	[CompilerGenerated]
	private void MBOPKOFPBBH(Entity OAOGLFGGBPI, ParentData CEOGJFOKGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A402C0", Offset = "0x3A3F6C0", VA = "0x183A402C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A405D0", Offset = "0x3A3F9D0", VA = "0x183A405D0")]
	public static EntityQuery PCLLMIPKIOC(ComponentSystemBase MFPLGOJOEDD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class ACEOOKLAJPC : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int GNJEMLNNPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery JLMGAJOHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs DHJNAJDHBIA;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x36CEF10", Offset = "0x36CE310", VA = "0x1836CEF10", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x36CEC50", Offset = "0x36CE050", VA = "0x1836CEC50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x36CED30", Offset = "0x36CE130", VA = "0x1836CED30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x36CE900", Offset = "0x36CDD00", VA = "0x1836CE900")]
	private void IDDAJNLGMGN(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public ACEOOKLAJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(ACEOOKLAJPC))]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	public class PostLoadAddSceneTagEntity : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService KJGMKGKKNGC;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x369C120", Offset = "0x369B520", VA = "0x18369C120", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x369BF60", Offset = "0x369B360", VA = "0x18369BF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	[ELANPKCEIEO(JHCKAKNDFFP.OMRoom)]
	public class PostLoadInitializeNetworkId : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct KNNIJDGIMNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<IOLFAAOECPP, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
			public KNNIJDGIMNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GHMGMBJCFLO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct BCFIEGJALMO
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct CPANLLJIAPC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime AGLILKJOIBC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BNGNICNMLNH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex EEKLHCACNAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JEFPCLJPLFC;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x475B8C0", Offset = "0x475ACC0", VA = "0x18475B8C0")]
				public void BHIDKDBKBAC(PostLoadInitializeNetworkId MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x475B930", Offset = "0x475AD30", VA = "0x18475B930")]
				public CPANLLJIAPC OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(CPANLLJIAPC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private BCFIEGJALMO LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BCFIEGJALMO.CPANLLJIAPC* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HDJBFJIALLJ;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x475FBF0", Offset = "0x475EFF0", VA = "0x18475FBF0")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, int EHDOKFHFJCO, ref ObjectNetworkIdComponentData MMOOINOADGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x957610", Offset = "0x956A10", VA = "0x180957610", Slot = "5")]
			public void ReadFromDisplayClass(ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x29CD240", Offset = "0x29CC640", VA = "0x1829CD240", Slot = "6")]
			public void WriteToDisplayClass(ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x475FD20", Offset = "0x475F120", VA = "0x18475FD20", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x475FE10", Offset = "0x475F210", VA = "0x18475FE10")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref BCFIEGJALMO.CPANLLJIAPC DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x475FC80", Offset = "0x475F080", VA = "0x18475FC80")]
			public void BHIDKDBKBAC(PostLoadInitializeNetworkId MFPLGOJOEDD, ref KNNIJDGIMNN IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x475FB80", Offset = "0x475EF80", VA = "0x18475FB80")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[IMNMHIBEIDL]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery JLMGAJOHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery ADIJGJANNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker FEJPEEDJFOG;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x369CF10", Offset = "0x369C310", VA = "0x18369CF10", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x369CDA0", Offset = "0x369C1A0", VA = "0x18369CDA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x369CE40", Offset = "0x369C240", VA = "0x18369CE40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x369CE40", Offset = "0x369C240", VA = "0x18369CE40")]
		public void PKOGPJICAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x369C1C0", Offset = "0x369B5C0", VA = "0x18369C1C0")]
		private void FACCCJNMIEC(NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x369C710", Offset = "0x369BB10", VA = "0x18369C710")]
		private void GCBGNANIKII(NativeHashMap<IOLFAAOECPP, Entity> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x369CB10", Offset = "0x369BF10", VA = "0x18369CB10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x369C970", Offset = "0x369BD70", VA = "0x18369C970")]
		public static EntityQuery IEAFAJBHNKF(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class LENCDLIDLEJ : DHDEFGPGMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery ICNCIOMOAKJ;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x36833E0", Offset = "0x36827E0", VA = "0x1836833E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x3683470", Offset = "0x3682870", VA = "0x183683470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public LENCDLIDLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class LAGGJIEOGKN : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::DGIKCDEPKDI<CMIJGGBLCJC> EFAGAJHPINO;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x3A51A20", Offset = "0x3A50E20", VA = "0x183A51A20", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x3A51720", Offset = "0x3A50B20", VA = "0x183A51720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x3A51590", Offset = "0x3A50990", VA = "0x183A51590")]
	private void MGEBOHMCLIB(NativeList<EntityArchetype> FIFGIFGGGDP, NativeHashMap<int, CHLMDABNGKB> PIEGJJIHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x3A51450", Offset = "0x3A50850", VA = "0x183A51450")]
	private Span<int> KFEAJOIPJAK(EntityArchetype CAABDGCKDOD)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x3A50D80", Offset = "0x3A50180", VA = "0x183A50D80")]
	private bool AAIFOOJECBN(int NLGBDLLFIPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x3A50E50", Offset = "0x3A50250", VA = "0x183A50E50")]
	private void IPDINAFCCJL(NativeHashMap<int, CHLMDABNGKB> PIEGJJIHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public LAGGJIEOGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[MBALNPKLAGP(FOFKCKDBIPD.Serialization)]
	public class PreSerializeRemoveEntities : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery MFAAHFEILOO;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x369CFD0", Offset = "0x369C3D0", VA = "0x18369CFD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x369D250", Offset = "0x369C650", VA = "0x18369D250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct BGAGDOKDPKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public ComponentDataFromEntity dstComponentData;

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
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
			public BGAGDOKDPKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x37A6DE0", Offset = "0x37A61E0", VA = "0x1837A6DE0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct FAHAHCDLBGE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> GGHFLGHFEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> HHLLOPMMJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public ComponentDataFromEntity BANMGIDCEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> BEKIFNKENPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int KKDBIBDEEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType HBILNHOEIJP;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x475E7E0", Offset = "0x475DBE0", VA = "0x18475E7E0")]
			internal void AOFNEGGIPNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x475E9D0", Offset = "0x475DDD0", VA = "0x18475E9D0", Slot = "5")]
			public void ReadFromDisplayClass(ref BGAGDOKDPKF IFOILLGAIOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x475E9C0", Offset = "0x475DDC0", VA = "0x18475E9C0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x475E9A0", Offset = "0x475DDA0", VA = "0x18475E9A0")]
			public void BHIDKDBKBAC(ShadowWorldApplyPropertyDifferencesToShadowWorld MFPLGOJOEDD, ref BGAGDOKDPKF IFOILLGAIOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService FFFJHMGPLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle NHNANODGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle CMLFNGKGMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private DOBDGKNHJII BGHMFEPCABE;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x37AE710", Offset = "0x37ADB10", VA = "0x1837AE710", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x37AE330", Offset = "0x37AD730", VA = "0x1837AE330")]
		public JobHandle OGDLHKKECID(JobHandle MEDEIGIKJJO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x37AE370", Offset = "0x37AD770", VA = "0x1837AE370", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x37AE020", Offset = "0x37AD420", VA = "0x1837AE020")]
		private bool GIJDDCJBIIA(JobHandle MEDEIGIKJJO, int NLGBDLLFIPJ, out JobHandle PLJEPLODDHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(CDPBEFOKBPH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class HGIDMMLPHAI : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x3A40790", Offset = "0x3A3FB90", VA = "0x183A40790", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public HGIDMMLPHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(PAADBABBJJN))]
internal sealed class ENLDJKKLAHP : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x3A35450", Offset = "0x3A34850", VA = "0x183A35450", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public ENLDJKKLAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[OEMDBJIOCGA]
[ExecuteAlways]
[UpdateInGroup(typeof(BADAIICIPJH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class GOJJMONEOOE : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FD50", Offset = "0x3A3F150", VA = "0x183A3FD50", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public GOJJMONEOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(OLEIJCJDIOL))]
internal sealed class ACDNAFCMOHG : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x36CE780", Offset = "0x36CDB80", VA = "0x1836CE780", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public ACDNAFCMOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class IFEIMGKNEIP : HHJNKOGKPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "18")]
		get
		{
			return default(ENELKKCPMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public IFEIMGKNEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(GCJNDOFEDGI))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class GODCOHPPKAB : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F530", Offset = "0x3A3E930", VA = "0x183A3F530", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public GODCOHPPKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class IKFOHLNNICL : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public IKFOHLNNICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class HALIFIOBHAG : HHJNKOGKPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override ENELKKCPMCO PACPBJCLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "18")]
		get
		{
			return default(ENELKKCPMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public HALIFIOBHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(FLHGDPEKGFK))]
internal sealed class LDLOJEMFNHL : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x36823E0", Offset = "0x36817E0", VA = "0x1836823E0", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public LDLOJEMFNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class IFIIAKANGFH : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public IFIIAKANGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class BEFJKHFDDAH : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public BEFJKHFDDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class JIADEHDPCNK : DHDEFGPGMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public JIADEHDPCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[LOFBNDLMONN]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
public class OMIPJNCFJPF : DHDEFGPGMMG, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService JOGKAGECKFN;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x3689C70", Offset = "0x3689070", VA = "0x183689C70", Slot = "14")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x3689C50", Offset = "0x3689050", VA = "0x183689C50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public OMIPJNCFJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class CopyTransformDataFromGameObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct BFAEOKGMNEO : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float CEONAHNHACE = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> HKIJDOHMPBL;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x37A2620", Offset = "0x37A1A20", VA = "0x1837A2620", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x37A27E0", Offset = "0x37A1BE0", VA = "0x1837A27E0")]
			private bool KHOLPCLPIOM(float3 AFLEFPKENKF, float3 IAMOONJKNLF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x37A25B0", Offset = "0x37A19B0", VA = "0x1837A25B0")]
			private bool CICNCHCOJEF(quaternion AFLEFPKENKF, quaternion IAMOONJKNLF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct DMCKJDDNEOD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> LGIFNGEDBFC;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x37A3530", Offset = "0x37A2930", VA = "0x1837A3530", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FADHLPPNOEF HAKKCCOEJEA;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly FADHLPPNOEF DPAPELHLEIJ;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly FADHLPPNOEF HPMAGILDKAC;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker FBLCINJIPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x36E2670", Offset = "0x36E1A70", VA = "0x1836E2670", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x36E22D0", Offset = "0x36E16D0", VA = "0x1836E22D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x36E2300", Offset = "0x36E1700", VA = "0x1836E2300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	public class RegisterTransforms : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JFGOOBPPCHF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct BJEGJCPBMOE
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct DJECMOIIJLB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO>.Runtime EPDAMFLJBCJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime KKKCDBJJGDE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO> BNKHDBMHHLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> KIHDLLCLDIP;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x475C310", Offset = "0x475B710", VA = "0x18475C310")]
				public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x475C390", Offset = "0x475B790", VA = "0x18475C390")]
				public DJECMOIIJLB OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(DJECMOIIJLB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private BJEGJCPBMOE LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BJEGJCPBMOE.DJECMOIIJLB* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OLGECILOGAP;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x47618B0", Offset = "0x4760CB0", VA = "0x1847618B0")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, AHIGIKNEKPO POHDMEMKCCD, Transform LJLOGOIJMEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x47619C0", Offset = "0x4760DC0", VA = "0x1847619C0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x4761AB0", Offset = "0x4760EB0", VA = "0x184761AB0")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, ref BJEGJCPBMOE.DJECMOIIJLB DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x47619B0", Offset = "0x4760DB0", VA = "0x1847619B0")]
			public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x4761840", Offset = "0x4760C40", VA = "0x184761840")]
			public unsafe static void AKIAJMEECCI(ArchetypeChunkIterator* OOIGLMHMDNB, void* GFHPBIGFBGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct OJCFFJPOHAI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct NANFIBFKLGE
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct JMJNCPHEKBG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime PEFGKOAPNPM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO>.Runtime EPDAMFLJBCJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AFCMHBPALIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<AHIGIKNEKPO> BNKHDBMHHLK;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x47643B0", Offset = "0x47637B0", VA = "0x1847643B0")]
				public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x4764410", Offset = "0x4763810", VA = "0x184764410")]
				public JMJNCPHEKBG OJPJOCIDEAI(ref ArchetypeChunk MNCBFLKHIGF, int JAKAOHPEBMO, int JKGJIAGPCOD)
				{
					return default(JMJNCPHEKBG);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private NANFIBFKLGE LNNGGAHBEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NANFIBFKLGE.JMJNCPHEKBG* HNLOOIBKOPF;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x4765210", Offset = "0x4764610", VA = "0x184765210")]
			internal void AOFNEGGIPNF(Entity OAOGLFGGBPI, AHIGIKNEKPO POHDMEMKCCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x47652F0", Offset = "0x47646F0", VA = "0x1847652F0", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int PONGFBAOBFE, int EPMDLPGLCNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x4765380", Offset = "0x4764780", VA = "0x184765380")]
			public void FFLFBMEGBBJ(ref ArchetypeChunk FGCHPEJCAHE, [NoAlias] ref NANFIBFKLGE.JMJNCPHEKBG DFAABHJNNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x47643B0", Offset = "0x47637B0", VA = "0x1847643B0")]
			public void BHIDKDBKBAC(RegisterTransforms MFPLGOJOEDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery MCHKMIPNOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery FALOFACHEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery MCDDFLEGICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery KMMFIDLFKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery OIKENPHJBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker KNLEJMNKDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery IPJPLDCHBIB;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x37A8030", Offset = "0x37A7430", VA = "0x1837A8030", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x37A7D50", Offset = "0x37A7150", VA = "0x1837A7D50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x37A7F60", Offset = "0x37A7360", VA = "0x1837A7F60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x37A7700", Offset = "0x37A6B00", VA = "0x1837A7700")]
		private void KLGGBKKIFAI(EntityQuery JLMGAJOHFKO, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x37A6E60", Offset = "0x37A6260", VA = "0x1837A6E60")]
		private void DKLNMNLOMJH(EntityQuery JLMGAJOHFKO, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x37A7F00", Offset = "0x37A7300", VA = "0x1837A7F00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x37A75C0", Offset = "0x37A69C0", VA = "0x1837A75C0")]
		private void KEKBJMLNMOH(NativeArray<Entity> GNGEEFEGDCP, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x37A70D0", Offset = "0x37A64D0", VA = "0x1837A70D0")]
		[BurstCompile]
		internal static void GOCBKJBPGME(NativeArray<AHIGIKNEKPO> JFIMNHPLHBN, ComponentDataFromEntity<AHIGIKNEKPO> JCEGHLMGKEA, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void EKBHDPJPKLP(Transform LJLOGOIJMEM, Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void DPKKGPFDHNE(Entity OAOGLFGGBPI, int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void DGPKCGALGFD(int BELCAJFDAHD, HNJLOOJCIKA KNHDHCJEMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x37A73E0", Offset = "0x37A67E0", VA = "0x1837A73E0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HJFMNCNAFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x37A7AE0", Offset = "0x37A6EE0", VA = "0x1837A7AE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x37A7940", Offset = "0x37A6D40", VA = "0x1837A7940")]
		public static EntityQuery LEFDHBJCJHF(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x37A8080", Offset = "0x37A7480", VA = "0x1837A8080")]
		public static EntityQuery PKBFLMINOHP(ComponentSystemBase MFPLGOJOEDD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class CopyTransformDataToGameObjects : DHDEFGPGMMG, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct GJOPBBGONLL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> HKIJDOHMPBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x37A4140", Offset = "0x37A3540", VA = "0x1837A4140", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct EMJIKOJGCGE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x37A3750", Offset = "0x37A2B50", VA = "0x1837A3750", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct JIPGLKGPANE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OAOAHBALFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> LGIFNGEDBFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> GNGEEFEGDCP;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x37A4700", Offset = "0x37A3B00", VA = "0x1837A4700", Slot = "4")]
			public void Execute(int BELCAJFDAHD, TransformAccess LJLOGOIJMEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly FADHLPPNOEF HAKKCCOEJEA;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly FADHLPPNOEF DPAPELHLEIJ;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FADHLPPNOEF HPMAGILDKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IMPKDEPFPDI KEDEBPFCEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery AKLGMKMLJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery IKKMFGIJJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery BEIECPDCKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray ILILIKHGFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray LDAOLCLLDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray CLPCDGMHFPO;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x36E3470", Offset = "0x36E2870", VA = "0x1836E3470", Slot = "14")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x36E29A0", Offset = "0x36E1DA0", VA = "0x1836E29A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x36E2B90", Offset = "0x36E1F90", VA = "0x1836E2B90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x36E2C20", Offset = "0x36E2020", VA = "0x1836E2C20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x36E2C50", Offset = "0x36E2050", VA = "0x1836E2C50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x36E2820", Offset = "0x36E1C20", VA = "0x1836E2820")]
		private NativeArray<Entity> DNBPFDPOOPI(NativeArray<AHIGIKNEKPO> GGHFLGHFEMD, NativeList<Entity> EOPMDICNPHI, TransformAccessArray JHGDHCEBEBO, TransformAccessArray FMANINJHIAF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : DHDEFGPGMMG, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private LKPHHNIFJFE NEIHAKKOCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private BCCHDFPAANJ DCDKCDLJBLH;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x369D580", Offset = "0x369C980", VA = "0x18369D580", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x36E37F0", Offset = "0x36E2BF0", VA = "0x1836E37F0", Slot = "14")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x36E3900", Offset = "0x36E2D00", VA = "0x1836E3900", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x36E3670", Offset = "0x36E2A70", VA = "0x1836E3670")]
		private static void HNFBJIKPBMH(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, Entity GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x36E35D0", Offset = "0x36E29D0", VA = "0x1836E35D0")]
		private static bool AAMKJDPJALI(EntityManager KNABDDPENKI, Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[MBALNPKLAGP(FOFKCKDBIPD.TransformSyncing)]
	public class L2PToL2WHierarchy : DHDEFGPGMMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct IBELBFGGCPD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JBKIBKHMEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> CGOCGHAGCFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> CMBIJAGAABP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CKCHEMEJJOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> OCHHGJDLMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> PCJJOCJDEIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint LBAGCJGFKCK;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x4760C60", Offset = "0x4760060", VA = "0x184760C60")]
			[Conditional("DEBUG_BUILD")]
			private void DNNKHGBPENM(Entity OAOGLFGGBPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x4760D30", Offset = "0x4760130", VA = "0x184760D30", Slot = "4")]
			public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x4761020", Offset = "0x4760420", VA = "0x184761020")]
			private void PDGDMAFHNMF(float4x4 IBJFMBEOAPA, Entity OAOGLFGGBPI, bool ILIEDJAPGLC, int ELMCLGINMHD = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery JNECPNBJKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery BNALOLGAMCD;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x3A50940", Offset = "0x3A4FD40", VA = "0x183A50940", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x3A50A60", Offset = "0x3A4FE60", VA = "0x183A50A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class ONINDKIHCDA : CICADLGFANF
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct PPAIJAPNAIL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JBKIBKHMEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> OCHHGJDLMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x4766120", Offset = "0x4765520", VA = "0x184766120", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x4766220", Offset = "0x4765620", VA = "0x184766220")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery JNECPNBJKBE;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x3689CC0", Offset = "0x36890C0", VA = "0x183689CC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x3689DF0", Offset = "0x36891F0", VA = "0x183689DF0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public ONINDKIHCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class LDDDOGLJEOF : CICADLGFANF
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct OBLMDMLDJJO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> DNBPPLDKJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> BMGLDGMPIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> ODEKOHFGDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> OLCDPOMDCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x4764C60", Offset = "0x4764060", VA = "0x184764C60", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x4765010", Offset = "0x4764410", VA = "0x184765010")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x3682010", Offset = "0x3681410", VA = "0x183682010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x3682120", Offset = "0x3681520", VA = "0x183682120", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xFBCBC0", Offset = "0xFBBFC0", VA = "0x180FBCBC0")]
	public LDDDOGLJEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class LDCDHKDKILF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct DKPLPHJGNIM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> MLLCIKBCILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> NEDJGGNBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> NNHICDCOAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> DBFJMBEMKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint LBAGCJGFKCK;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x475D400", Offset = "0x475C800", VA = "0x18475D400", Slot = "4")]
		public void Execute(ArchetypeChunk FGCHPEJCAHE, int BELCAJFDAHD, int EFIIPKAFDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x475DB10", Offset = "0x475CF10", VA = "0x18475DB10")]
		public bool PHKNCADEDHN(ArchetypeChunk FGCHPEJCAHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x3681D70", Offset = "0x3681170", VA = "0x183681D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x3681EA0", Offset = "0x36812A0", VA = "0x183681EA0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OLACCLPDDHA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
	public LDCDHKDKILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[MBALNPKLAGP(FOFKCKDBIPD.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : PCIKMMGBFEM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct NDIKOFPCIJM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType MHOCPBNFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x369E010", Offset = "0x369D410", VA = "0x18369E010", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType DFAGGHLEDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x369E070", Offset = "0x369D470", VA = "0x18369E070", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType IOBOLGCGMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x369E040", Offset = "0x369D440", VA = "0x18369E040", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x3697470", Offset = "0x3696870", VA = "0x183697470")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Game)]
public class FBDOELDLMAP : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x3A3CB20", Offset = "0x3A3BF20", VA = "0x183A3CB20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x3A3C4B0", Offset = "0x3A3B8B0", VA = "0x183A3C4B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FBDOELDLMAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Loading)]
public class LNKFHMLNNCK : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x36845D0", Offset = "0x36839D0", VA = "0x1836845D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public LNKFHMLNNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class MNEPNNNCJOA : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x3685CC0", Offset = "0x36850C0", VA = "0x183685CC0", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public MNEPNNNCJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Saving)]
public class BBPGBAHCPON : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x36D45D0", Offset = "0x36D39D0", VA = "0x1836D45D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public BBPGBAHCPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class HNNOKALKPBL : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x3A42640", Offset = "0x3A41A40", VA = "0x183A42640", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public HNNOKALKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[LKFGEBEEFKK(PCCEMKBGKDJ.Simulation)]
public class BDFBDHAMBHI : DFEDEMKJADL
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type OOHLGBIDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x36D50E0", Offset = "0x36D44E0", VA = "0x1836D50E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] IDJLFJAIGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x36D4D30", Offset = "0x36D4130", VA = "0x1836D4D30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public BDFBDHAMBHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[LOJIIDJFKAI(typeof(JMFPNODBMEF), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal class JMFPNODBMEF : FPHKGEBJIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::BCEPNNPCKLO<AuthoredParentData, HLMIEDJMAKI, CJLPKAOODOE, AuthoredChildrenData> HKBOAGLHPOH;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A1B0", Offset = "0x3A495B0", VA = "0x183A4A1B0", Slot = "4")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JMFPNODBMEF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	[LOJIIDJFKAI(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : DPDCPMNGBKH, FPHKGEBJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[IMNMHIBEIDL]
		private PropertyChangeNetworkRouter PICAOCFCGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::DEHNDDIKMEN<Entity> LKAENGEIFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::BCEPNNPCKLO<ParentData, EHHPMHEMOMP, JJDKNDIBKCI, ChildrenData> HKBOAGLHPOH;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A8E0", Offset = "0x3A39CE0", VA = "0x183A3A8E0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A510", Offset = "0x3A39910", VA = "0x183A3A510", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A890", Offset = "0x3A39C90", VA = "0x183A3A890")]
		public Entity MODGPLDICAF(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A4B0", Offset = "0x3A398B0", VA = "0x183A3A4B0")]
		public bool GFCKPIADCDP(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A7F0", Offset = "0x3A39BF0", VA = "0x183A3A7F0")]
		public bool KKGLFGKJMPP(Entity OAOGLFGGBPI, Entity DPPABCPODHG, bool INKJNEFMNFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A610", Offset = "0x3A39A10", VA = "0x183A3A610")]
		private bool JCOHKFCAPAO(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[LOJIIDJFKAI(typeof(CGHKOIFBLNH), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class CGHKOIFBLNH : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery GFIAFOEDDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x36D9090", Offset = "0x36D8490", VA = "0x1836D9090")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x36D9440", Offset = "0x36D8840", VA = "0x1836D9440", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x36D8FC0", Offset = "0x36D83C0", VA = "0x1836D8FC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x36D91F0", Offset = "0x36D85F0", VA = "0x1836D91F0")]
	public bool KFKEAKANFDF(Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x36D8E40", Offset = "0x36D8240", VA = "0x1836D8E40")]
	public IEnumerable<Entity> BIJKCDCNJDN(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x36D9540", Offset = "0x36D8940", VA = "0x1836D9540")]
	public bool PNPLAMAGNCA(Entity OAOGLFGGBPI, Entity LKJGCNCCCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x36D8F00", Offset = "0x36D8300", VA = "0x1836D8F00")]
	public bool CLCGCNNPCNJ(Entity OAOGLFGGBPI, Entity HOHCGCELNKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x36D92B0", Offset = "0x36D86B0", VA = "0x1836D92B0")]
	public NativeList<Entity> KGECOFKCEIF(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false, Allocator OPBLDCCKGEG = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x36D90E0", Offset = "0x36D84E0", VA = "0x1836D90E0")]
	public IEnumerable<Entity> JPCGBLEHGGF(Entity OAOGLFGGBPI, bool KAFNOLOBCFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x36D9390", Offset = "0x36D8790", VA = "0x1836D9390")]
	public Entity MNEECNHBEJG(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x36D91A0", Offset = "0x36D85A0", VA = "0x1836D91A0")]
	public NativeArray<Entity> KCMHHNCAIMK()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x36D8D70", Offset = "0x36D8170", VA = "0x1836D8D70")]
	public bool ABEADFFICKO(Entity HOHCGCELNKE, Entity MDKKIEJKOGD, out Entity OBCBEGEPMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x36D8FE0", Offset = "0x36D83E0", VA = "0x1836D8FE0")]
	private Entity HHCKLGJHJDM(Entity OAOGLFGGBPI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CGHKOIFBLNH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x3282DE0", Offset = "0x32821E0", VA = "0x183282DE0")]
		public static void HBGEMGCKMHE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(JHLNNPKIFCO KOKEGENGCAH, global::PHNOBDPMINP<Entity> CGCMEEFENJL, out global::BCEPNNPCKLO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> EJKCHKLJKIP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LCIGIOAHNLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LCIGIOAHNLO, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x3698930", Offset = "0x3697D30", VA = "0x183698930")]
		public static bool EBMHIDGOHHI(JMAKJOJHHNF CHOBEAJIPKF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class BCEPNNPCKLO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LCIGIOAHNLO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LCIGIOAHNLO, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::DEHNDDIKMEN<Entity> LKAENGEIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly DEBKKNKNNEP JFGGHOKHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly ICAMIIGEPFO GPFONCECPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager KNABDDPENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly BCCHDFPAANJ DCDKCDLJBLH;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x591E150", Offset = "0x591D550", VA = "0x18591E150")]
	public BCEPNNPCKLO(JHLNNPKIFCO KOKEGENGCAH, global::PHNOBDPMINP<Entity> CGCMEEFENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x591DB20", Offset = "0x591CF20", VA = "0x18591DB20")]
	private bool ANOCBCBGGJB(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x29B3380", Offset = "0x29B2780", VA = "0x1829B3380")]
	private bool PKEJCNLNHPB(Entity OAOGLFGGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x29B2FA0", Offset = "0x29B23A0", VA = "0x1829B2FA0")]
	public bool GFCKPIADCDP(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x29B2BF0", Offset = "0x29B1FF0", VA = "0x1829B2BF0")]
	public bool APIKBBINCEL(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x29B27B0", Offset = "0x29B1BB0", VA = "0x1829B27B0")]
	private bool APIKBBINCEL(Entity OAOGLFGGBPI, in Entity DPPABCPODHG, bool OBHLGFFLNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void MNMOCJMOCKM(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void KGNICBBGGPO(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void FOCNMBDNMHC(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void JMDPHKELOMM(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private static void IPCBOPKNMPH(Entity OAOGLFGGBPI, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x591DFB0", Offset = "0x591D3B0", VA = "0x18591DFB0")]
	private bool KFKEAKANFDF(Entity OAOGLFGGBPI, Entity OBMJAGNFCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x29B2C20", Offset = "0x29B2020", VA = "0x1829B2C20")]
	private void BHOPKGJMACC(Entity OAOGLFGGBPI, in Entity CIPDAEPIOJL, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x591DE10", Offset = "0x591D210", VA = "0x18591DE10")]
	private void IBNFLHIBOOB(Entity OAOGLFGGBPI, in Entity CIPDAEPIOJL, in Entity DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x591DB80", Offset = "0x591CF80", VA = "0x18591DB80")]
	private bool EBOGDHDAJJP(LADNHJNEPKG DPBGLDFEONN, in IOLFAAOECPP OIEPABNELMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x29B3250", Offset = "0x29B2650", VA = "0x1829B3250")]
	private void LNGINODJAIF(Entity GPFONCECPBK, Entity LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x591DD80", Offset = "0x591D180", VA = "0x18591DD80")]
	private void FIMHIJJNHNG(Entity GPFONCECPBK, Entity LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private void DGPKCGALGFD(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	private void EKBHDPJPKLP(Entity OAOGLFGGBPI, Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct JEHJBIOPOMD : NBKDCFKNMHI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public LEEGNLJBNDK FGCCDFCMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LEEGNLJBNDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF60", Offset = "0x6EE360", VA = "0x1806EEF60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[LOJIIDJFKAI(typeof(ObjectEmbodimentService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Embodiment)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class ObjectEmbodimentService : JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[IMNMHIBEIDL]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[IMNMHIBEIDL]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[IMNMHIBEIDL]
		private BMGHPMCGENG BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[IMNMHIBEIDL]
		private LEPGAPILAAM AAKCANBNOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[IMNMHIBEIDL]
		private TransformOwnershipPhase KGOFCGFBHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<IOLFAAOECPP, MIDGCDECPDI> ADKPFJIMBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private IKGNJCJKDHP CPMCPOGIHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x368B370", Offset = "0x368A770", VA = "0x18368B370")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int GHENHLBAJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x368B2C0", Offset = "0x368A6C0", VA = "0x18368B2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int PIOCBEALFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x368B220", Offset = "0x368A620", VA = "0x18368B220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1D81210", Offset = "0x1D80610", VA = "0x181D81210", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x368DA70", Offset = "0x368CE70", VA = "0x18368DA70", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x368C340", Offset = "0x368B740", VA = "0x18368C340")]
		public void MEMDMDPLAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x368BC80", Offset = "0x368B080", VA = "0x18368BC80", Slot = "6")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x368AA60", Offset = "0x3689E60", VA = "0x18368AA60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x368BBA0", Offset = "0x368AFA0", VA = "0x18368BBA0")]
		public int ILPEILOOILG(SceneTag BGCBBDJLHHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x368C300", Offset = "0x368B700", VA = "0x18368C300")]
		public int LHLAAECBKCO(SceneTag BGCBBDJLHHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x368AE60", Offset = "0x368A260", VA = "0x18368AE60")]
		public bool FDHNAHEDHFO(Entity OAOGLFGGBPI, Allocator OPBLDCCKGEG, out NativeList<Entity> EBGCJPGCLKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x368C500", Offset = "0x368B900", VA = "0x18368C500")]
		public bool MJPFOHOOMEJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x368B960", Offset = "0x368AD60", VA = "0x18368B960")]
		public bool IGNAOPBPCKO(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x368A4D0", Offset = "0x36898D0", VA = "0x18368A4D0")]
		public bool CCBOPNINIEJ(Entity OAOGLFGGBPI, out MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x368A420", Offset = "0x3689820", VA = "0x18368A420")]
		private bool CCBOPNINIEJ(Transform LJLOGOIJMEM, out MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x368A540", Offset = "0x3689940", VA = "0x18368A540")]
		private void CKKJBILLNPP(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x368C320", Offset = "0x368B720", VA = "0x18368C320")]
		private bool LOPKHLFIMAA(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x368C0B0", Offset = "0x368B4B0", VA = "0x18368C0B0")]
		public void KJDPCLCGNLB(IOLFAAOECPP IOCKLNNJMIA, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x368C860", Offset = "0x368BC60", VA = "0x18368C860")]
		public bool NKLGPADCMJB(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x368CE20", Offset = "0x368C220", VA = "0x18368CE20")]
		public bool ODOOOIFCONJ(NFJEDPPAJMK OOGHONKGHEE, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x368D560", Offset = "0x368C960", VA = "0x18368D560")]
		public bool ODOOOIFCONJ(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x368D540", Offset = "0x368C940", VA = "0x18368D540")]
		public bool ODOOOIFCONJ(MIDGCDECPDI CHOBEAJIPKF, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x368D670", Offset = "0x368CA70", VA = "0x18368D670")]
		public bool OONHDEIOEPE(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x368DA40", Offset = "0x368CE40", VA = "0x18368DA40")]
		public bool OONHDEIOEPE(MIDGCDECPDI ALLKDINDGEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x368D1D0", Offset = "0x368C5D0", VA = "0x18368D1D0")]
		public bool ODOOOIFCONJ(MIDGCDECPDI ALLKDINDGEN, [Optional] object AJDBKDIMOHA, bool BIOMHNNIJHG = false, bool FOGEFHPIHNA = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x368C390", Offset = "0x368B790", VA = "0x18368C390")]
		public Transform MHIJHDGLGCN(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x3689EF0", Offset = "0x36892F0", VA = "0x183689EF0")]
		public bool AAMKJDPJALI(Entity OAOGLFGGBPI, out Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x368B0B0", Offset = "0x368A4B0", VA = "0x18368B0B0")]
		public MIDGCDECPDI GAKEHOENCMF(Entity OAOGLFGGBPI, [Optional] object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x368B6D0", Offset = "0x368AAD0", VA = "0x18368B6D0")]
		public void HPILCJEPAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x368A6A0", Offset = "0x3689AA0", VA = "0x18368A6A0")]
		public void DIGHECKADBO(SceneTag BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3689FC0", Offset = "0x36893C0", VA = "0x183689FC0")]
		private void BALDGCOKCIP(Entity OAOGLFGGBPI, bool AEODMGJBILG, bool HDPMMHOPKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x368A380", Offset = "0x3689780", VA = "0x18368A380")]
		private void CBHFAPAMCMN(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN, bool AEODMGJBILG, bool HDPMMHOPKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x368C2B0", Offset = "0x368B6B0", VA = "0x18368C2B0")]
		public MIDGCDECPDI KKELGPPIGEL(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x368B1A0", Offset = "0x368A5A0", VA = "0x18368B1A0")]
		public bool GBKFKBLGCCA(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x368B240", Offset = "0x368A640", VA = "0x18368B240")]
		public bool GJIPPEJJKHO(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x368C040", Offset = "0x368B440", VA = "0x18368C040")]
		public bool KFEOGLGLLAC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x368CC00", Offset = "0x368C000", VA = "0x18368CC00")]
		public bool NMIIAKEHEIC(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x368CC70", Offset = "0x368C070", VA = "0x18368CC70")]
		public bool NMIIAKEHEIC(LEEGNLJBNDK KJNCDAGJAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void AEEKNBJJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x368D5B0", Offset = "0x368C9B0", VA = "0x18368D5B0")]
		private void OKHNABDHGEK(bool IKCFBOJHGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x368B2E0", Offset = "0x368A6E0", VA = "0x18368B2E0")]
		private bool HKIBCGAFAAK(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x368AB90", Offset = "0x3689F90", VA = "0x18368AB90")]
		private MIDGCDECPDI ECHLNEBHONI(Entity OAOGLFGGBPI, object AJDBKDIMOHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x368B3C0", Offset = "0x368A7C0", VA = "0x18368B3C0")]
		private MIDGCDECPDI HNDCDCLNOLO(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x368B980", Offset = "0x368AD80", VA = "0x18368B980")]
		private (Vector3, Quaternion, Vector3) ILCEDDNABAH(Entity OAOGLFGGBPI)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x368C750", Offset = "0x368BB50", VA = "0x18368C750")]
		private void NHPCHBFEIEE(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x368BBC0", Offset = "0x368AFC0", VA = "0x18368BBC0")]
		private void IMLHCOJBHIE(NFJEDPPAJMK OOGHONKGHEE, MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x368B5B0", Offset = "0x368A9B0", VA = "0x18368B5B0")]
		private void HPCFAJMLJKK(MIDGCDECPDI MLKPMDNHHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x368AC30", Offset = "0x368A030", VA = "0x18368AC30")]
		private void EPMJCFJMIDK(MIDGCDECPDI ALLKDINDGEN, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x368BDD0", Offset = "0x368B1D0", VA = "0x18368BDD0")]
		private void JEOIBCAGNHI(Entity OAOGLFGGBPI, MIDGCDECPDI ALLKDINDGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x368CD40", Offset = "0x368C140", VA = "0x18368CD40")]
		private void NONEAMGMGPC(Entity OAOGLFGGBPI, Transform LJLOGOIJMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x368C010", Offset = "0x368B410", VA = "0x18368C010")]
		private NFJEDPPAJMK JGKFJOJMEAP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x368DBF0", Offset = "0x368CFF0", VA = "0x18368DBF0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x368A5D0", Offset = "0x36899D0", VA = "0x18368A5D0")]
		[CompilerGenerated]
		private void DGLNCFCKDPI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class BPHLIJCECDN
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x36D5D60", Offset = "0x36D5160", VA = "0x1836D5D60")]
	public static MIDGCDECPDI GAKEHOENCMF(this ObjectEmbodimentService CCJAOIAIHHP, NFJEDPPAJMK OOGHONKGHEE, [Optional] object AJDBKDIMOHA)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[MBALNPKLAGP(FOFKCKDBIPD.Lifecycle)]
	[LOJIIDJFKAI(typeof(ObjectLifecycleService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class ObjectLifecycleService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private FNCOHMIDMDB OKPOBPNCFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects PKFEILEKHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x368ECF0", Offset = "0x368E0F0", VA = "0x18368ECF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, MFOBNBKALPH> AGJONJAHFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x368E7D0", Offset = "0x368DBD0", VA = "0x18368E7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x368EFA0", Offset = "0x368E3A0", VA = "0x18368EFA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> BBDEMMJFNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x368EAB0", Offset = "0x368DEB0", VA = "0x18368EAB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x368F040", Offset = "0x368E440", VA = "0x18368F040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x368F140", Offset = "0x368E540", VA = "0x18368F140", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0xB87670", Offset = "0xB86A70", VA = "0x180B87670", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x368EB50", Offset = "0x368DF50", VA = "0x18368EB50")]
		public bool EOKNMHALCBJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x368EBD0", Offset = "0x368DFD0", VA = "0x18368EBD0")]
		internal void FFOJHBEMCDE(Entity OAOGLFGGBPI, MFOBNBKALPH JDHIJCJKFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x368EA70", Offset = "0x368DE70", VA = "0x18368EA70")]
		public void COLIANFIIAH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x368E330", Offset = "0x368D730", VA = "0x18368E330")]
		public void ACJDPHMJEOL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x368EC30", Offset = "0x368E030", VA = "0x18368EC30")]
		private bool HJHIJFEGLNE(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x368E380", Offset = "0x368D780", VA = "0x18368E380")]
		public void ACJHDFNHANL(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x368E580", Offset = "0x368D980", VA = "0x18368E580")]
		private bool BFEHPHCAIKJ(Entity OAOGLFGGBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x368E740", Offset = "0x368DB40", VA = "0x18368E740")]
		public void BNAAMBOKMGH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x368F0E0", Offset = "0x368E4E0", VA = "0x18368F0E0")]
		private void OLOCILILAEH(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x368ED40", Offset = "0x368E140", VA = "0x18368ED40")]
		private void IALJJAFJICK(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x368F220", Offset = "0x368E620", VA = "0x18368F220")]
		public void PPCDKKLHCJP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private void KDAPAIFDOMM(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x368E870", Offset = "0x368DC70", VA = "0x18368E870")]
		private void CDGNPPELDIP(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[LOJIIDJFKAI(typeof(ObjectPrefabs), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Prefabs)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal class ObjectPrefabs : JDENCAMHKCA, DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class JKLNNKPCDFA : IEnumerable<(PCLEKMKAJBM, MFOBNBKALPH)>, IEnumerable, IEnumerator<(PCLEKMKAJBM, MFOBNBKALPH)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (PCLEKMKAJBM primitiveType, MFOBNBKALPH prefabType) <>2__current;

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
			private (PCLEKMKAJBM, MFOBNBKALPH) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x2DF7AE0", Offset = "0x2DF6EE0", VA = "0x182DF7AE0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((PCLEKMKAJBM, MFOBNBKALPH));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x47625E0", Offset = "0x47619E0", VA = "0x1847625E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x4760590", Offset = "0x475F990", VA = "0x184760590")]
			[DebuggerHidden]
			public JKLNNKPCDFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x4762400", Offset = "0x4761800", VA = "0x184762400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x47625A0", Offset = "0x47619A0", VA = "0x1847625A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x4762500", Offset = "0x4761900", VA = "0x184762500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(PCLEKMKAJBM, MFOBNBKALPH)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x4762500", Offset = "0x4761900", VA = "0x184762500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<MFOBNBKALPH, Entity> DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<MFOBNBKALPH, EntityArchetype> FIFGIFGGGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<PCLEKMKAJBM, MFOBNBKALPH> JLBJOGJGCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<MJPOECHPGHN, MFOBNBKALPH> KMOAAIIFGOJ;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x3692830", Offset = "0x3691C30", VA = "0x183692830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x36920C0", Offset = "0x36914C0", VA = "0x1836920C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x3692BA0", Offset = "0x3691FA0", VA = "0x183692BA0", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x36918E0", Offset = "0x3690CE0", VA = "0x1836918E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x3692B40", Offset = "0x3691F40", VA = "0x183692B40")]
		internal IEnumerable<Type> PBDCKNMJICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x36920E0", Offset = "0x36914E0", VA = "0x1836920E0")]
		internal GEBEJCMGDEA HPILECLMCEJ(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x36927D0", Offset = "0x3691BD0", VA = "0x1836927D0")]
		public EntityArchetype KFGAPPIDKBA(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x3692880", Offset = "0x3691C80", VA = "0x183692880")]
		public NativeHashMap<int, EntityArchetype> NJLEFBMNPHN(Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x3692A00", Offset = "0x3691E00", VA = "0x183692A00")]
		public bool NJLJEKPONCN(MFOBNBKALPH JDHIJCJKFOO, out EntityArchetype CAABDGCKDOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x3691820", Offset = "0x3690C20", VA = "0x183691820", Slot = "4")]
		[IteratorStateMachine(typeof(JKLNNKPCDFA))]
		public IEnumerable<(PCLEKMKAJBM, MFOBNBKALPH)> BGIOLCAOFIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x3691710", Offset = "0x3690B10", VA = "0x183691710")]
		public Entity AALANCDKDJF(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x3691EF0", Offset = "0x36912F0", VA = "0x183691EF0")]
		public MFOBNBKALPH GBKNIBKIHOC(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x3691E90", Offset = "0x3691290", VA = "0x183691E90")]
		public MFOBNBKALPH GBKNIBKIHOC(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(MFOBNBKALPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x3691F50", Offset = "0x3691350", VA = "0x183691F50")]
		public NativeHashMap<int, Entity> GLCKPKLCMFO(Allocator OPBLDCCKGEG = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x3691890", Offset = "0x3690C90", VA = "0x183691890")]
		public IEnumerable<MFOBNBKALPH> BNBJLMLDFAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x3692A70", Offset = "0x3691E70", VA = "0x183692A70")]
		public Entity ODADLIIMGLG(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x3692AD0", Offset = "0x3691ED0", VA = "0x183692AD0")]
		public bool OHLPFOOMIAD(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x3692150", Offset = "0x3691550", VA = "0x183692150")]
		private void IIFDKJCCILD(GEBEJCMGDEA MEOOBDIBHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x36925A0", Offset = "0x36919A0", VA = "0x1836925A0")]
		internal void IPOKHOEPCKC(MFOBNBKALPH JDHIJCJKFOO, ComponentTypeList LPPKOMBLCMM, IKAMNEMAICF FBGDHNOKHCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x3691D30", Offset = "0x3691130", VA = "0x183691D30")]
		private void FADOHIPLDLH(MFOBNBKALPH JDHIJCJKFOO, ComponentTypeList AOONNNAPHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x3691C10", Offset = "0x3691010", VA = "0x183691C10")]
		internal Entity EHONOAPJBJB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x3692FD0", Offset = "0x36923D0", VA = "0x183692FD0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum ENELKKCPMCO
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface HJLICMFNEDM
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class DOMOJAJMPKI : LJBFLMONAFL, DOBDGKNHJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly DFJNBONFIPE BOPDNIJLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly ENELKKCPMCO KGOFCGFBHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<CFMAIOKLGLK> MHDMHLBIKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, GBDBBLLJIJK> IMPHGFLBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> HJOJCNIDHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle IHONAKKHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle MOLCALNBEFE;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World CCENIHIJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x36E8850", Offset = "0x36E7C50", VA = "0x1836E8850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private AAGANFGPMAE KOAGAJEABFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0xE7EB80", Offset = "0xE7DF80", VA = "0x180E7EB80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private EOHNGDMHPEJ IIHPMNGKEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x794100", Offset = "0x793500", VA = "0x180794100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, GBDBBLLJIJK> FHAGEIBBBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x730150", Offset = "0x72F550", VA = "0x180730150", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, GBDBBLLJIJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle FEOBIEADMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x752EC0", Offset = "0x7522C0", VA = "0x180752EC0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xD7ABA0", Offset = "0xD79FA0", VA = "0x180D7ABA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool GEDIHOEPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x36E7C50", Offset = "0x36E7050", VA = "0x1836E7C50", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World NKCLDFNMCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x36E8150", Offset = "0x36E7550", VA = "0x1836E8150", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x36E89A0", Offset = "0x36E7DA0", VA = "0x1836E89A0")]
	public DOMOJAJMPKI(DFJNBONFIPE BOPDNIJLBEO, ENELKKCPMCO KGOFCGFBHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x36E7C60", Offset = "0x36E7060", VA = "0x1836E7C60", Slot = "11")]
	private void BCDKPODILND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x36E84A0", Offset = "0x36E78A0", VA = "0x1836E84A0", Slot = "10")]
	private bool JCLHKBNALMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x36E88B0", Offset = "0x36E7CB0", VA = "0x1836E88B0", Slot = "12")]
	private void PCHOPONBCLI(ComponentType HBILNHOEIJP, in CFMAIOKLGLK HBJHPADKKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x36E85C0", Offset = "0x36E79C0", VA = "0x1836E85C0", Slot = "13")]
	private bool KKMPBMKGGLN(MFOBNBKALPH JDHIJCJKFOO, out Entity NMEDHGOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x36E7CB0", Offset = "0x36E70B0", VA = "0x1836E7CB0", Slot = "16")]
	private bool BLKPKHFIANF(out NativeArray<int> KJCOLFIBADD, Allocator OPBLDCCKGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x36E82E0", Offset = "0x36E76E0", VA = "0x1836E82E0", Slot = "17")]
	private bool HLNECFBCDML(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP, out OMCDLMPOANH AJMEBMGKGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x36E81B0", Offset = "0x36E75B0", VA = "0x1836E81B0", Slot = "18")]
	private bool HLNECFBCDML(ComponentType HBILNHOEIJP, out CFMAIOKLGLK CDLAHJHOADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x36E7B60", Offset = "0x36E6F60", VA = "0x1836E7B60", Slot = "19")]
	private CFMAIOKLGLK ADFLFIFJLON(ComponentType HBILNHOEIJP)
	{
		return default(CFMAIOKLGLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x36E7C70", Offset = "0x36E7070", VA = "0x1836E7C70", Slot = "20")]
	private JDPCKAFOGOO BHHPMAEPCHI()
	{
		return default(JDPCKAFOGOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x36E8810", Offset = "0x36E7C10", VA = "0x1836E8810", Slot = "21")]
	private void OIEKNDCGEMB(JobHandle GNEAPAJLKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x36E7EE0", Offset = "0x36E72E0", VA = "0x1836E7EE0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x36E85F0", Offset = "0x36E79F0", VA = "0x1836E85F0")]
	private bool MLIBGBPHPGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x36E7D50", Offset = "0x36E7150", VA = "0x1836E7D50")]
	private int DPIOANEGEPK()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class DFJNBONFIPE : HJLICMFNEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public CPEFIMBHABA PJGPDAEMPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public AAGANFGPMAE CGKHLCEONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public EOHNGDMHPEJ MDIDNDENAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public KDPNKMKDLAM IEHEJIODGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World JMJANPOMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x36E66A0", Offset = "0x36E5AA0", VA = "0x1836E66A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public AAGANFGPMAE EFBFIEGMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DFJNBONFIPE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[MBALNPKLAGP(FOFKCKDBIPD.PropertyChanges)]
	[LOJIIDJFKAI(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct EBJJPCPKPFB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly ENELKKCPMCO KNOGJLNJJJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService IAFMOECNDHE;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x475DD50", Offset = "0x475D150", VA = "0x18475DD50")]
			public EBJJPCPKPFB(PropertyDiffStateService IAFMOECNDHE, ENELKKCPMCO IPLOBCPFMCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x475DD30", Offset = "0x475D130", VA = "0x18475DD30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly DFJNBONFIPE BOPDNIJLBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly DOMOJAJMPKI[] OJGGGDPBKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private ENELKKCPMCO FCCKCOKJADL;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public HJLICMFNEDM DPCGFEFKGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public DOBDGKNHJII HNBBMNAKLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x369EF70", Offset = "0x369E370", VA = "0x18369EF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public LJBFLMONAFL LJEMNDFDFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x369EF70", Offset = "0x369E370", VA = "0x18369EF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0xDC1DA0", Offset = "0xDC11A0", VA = "0x180DC1DA0")]
		public DOBDGKNHJII AJLHDKPEJGO(ENELKKCPMCO KGOFCGFBHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0xDC1DA0", Offset = "0xDC11A0", VA = "0x180DC1DA0")]
		public LJBFLMONAFL LHEPNBENOIH(ENELKKCPMCO KGOFCGFBHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x369F2C0", Offset = "0x369E6C0", VA = "0x18369F2C0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x369F030", Offset = "0x369E430", VA = "0x18369F030", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x369EFB0", Offset = "0x369E3B0", VA = "0x18369EFB0")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x369EE90", Offset = "0x369E290", VA = "0x18369EE90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x369F010", Offset = "0x369E410", VA = "0x18369F010")]
		public EBJJPCPKPFB ILNJGBLAJKE(ENELKKCPMCO KGOFCGFBHNK)
		{
			return default(EBJJPCPKPFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x369F390", Offset = "0x369E790", VA = "0x18369F390")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(SceneService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	internal class SceneService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag KOEGNMNIGIO;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string CNAIAMCOPKM = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string EBJMPEEPGMD = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[IMNMHIBEIDL]
		private LFIBHLPOILP PPDJEICCKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[IMNMHIBEIDL]
		private ObjectEmbodimentService ALLKDINDGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[IMNMHIBEIDL]
		private SingletonComponentService LAMNHLDLCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery DBCPKCDAFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery KCIOJHLJKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery ALHCMPHKMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity PJJDHGFALMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool HDOCPFIDKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x37A8B30", Offset = "0x37A7F30", VA = "0x1837A8B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> CIAJCEICPGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x752EA0", Offset = "0x7522A0", VA = "0x180752EA0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x25ACDA0", Offset = "0x25AC1A0", VA = "0x1825ACDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity OPKPBGJKPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x37A92F0", Offset = "0x37A86F0", VA = "0x1837A92F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag EDCHEJMNICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x37A8AE0", Offset = "0x37A7EE0", VA = "0x1837A8AE0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity MCGKDACEJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x37A8AE0", Offset = "0x37A7EE0", VA = "0x1837A8AE0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x37A8640", Offset = "0x37A7A40", VA = "0x1837A8640")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x37A92A0", Offset = "0x37A86A0", VA = "0x1837A92A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x37A9E30", Offset = "0x37A9230", VA = "0x1837A9E30", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x37A8BD0", Offset = "0x37A7FD0", VA = "0x1837A8BD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x37A90B0", Offset = "0x37A84B0", VA = "0x1837A90B0")]
		public void GCBIKBKOJJD(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x37A94F0", Offset = "0x37A88F0", VA = "0x1837A94F0")]
		public NativeArray<Entity> JCEPBJLINDJ(Allocator OPBLDCCKGEG = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x37A8540", Offset = "0x37A7940", VA = "0x1837A8540")]
		public void AEGDDAJIMDG(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x37A9DB0", Offset = "0x37A91B0", VA = "0x1837A9DB0")]
		public Entity ODNGLJOIJNB(string IGHJIHNAPBA = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x37A9820", Offset = "0x37A8C20", VA = "0x1837A9820")]
		public void LJFEMNLKDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x37A8DA0", Offset = "0x37A81A0", VA = "0x1837A8DA0")]
		public void FFNOCNODJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x37A86D0", Offset = "0x37A7AD0", VA = "0x1837A86D0")]
		public void BMNNIDHMOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x37A94E0", Offset = "0x37A88E0", VA = "0x1837A94E0")]
		public void JBPOOHIPEGP(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x37AA0A0", Offset = "0x37A94A0", VA = "0x1837AA0A0")]
		public bool PLOCBNEANOB(Entity BGCBBDJLHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x37A95D0", Offset = "0x37A89D0", VA = "0x1837A95D0")]
		public void JIINOPBNCJF(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x37A8DC0", Offset = "0x37A81C0", VA = "0x1837A8DC0")]
		public string FGHKOGHBCLM(Entity BGCBBDJLHHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		public void COENLNNOBCH(Entity BGCBBDJLHHN, string IGHJIHNAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x37A86B0", Offset = "0x37A7AB0", VA = "0x1837A86B0")]
		public bool AKECABMEFIP(string IGHJIHNAPBA, out Entity BGCBBDJLHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x37A9640", Offset = "0x37A8A40", VA = "0x1837A9640")]
		public void KPDCBKAGLIM(Entity BGCBBDJLHHN, bool BNAKOLIBLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x37A8ED0", Offset = "0x37A82D0", VA = "0x1837A8ED0")]
		public void GBOIINIDEOO(Entity OAOGLFGGBPI, bool JHECLPHKCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x37A8F50", Offset = "0x37A8350", VA = "0x1837A8F50")]
		public void GBOIINIDEOO(NativeArray<Entity> GNGEEFEGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x37A8FC0", Offset = "0x37A83C0", VA = "0x1837A8FC0")]
		public void GBOIINIDEOO(EntityQuery JLMGAJOHFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x37A9A20", Offset = "0x37A8E20", VA = "0x1837A9A20")]
		public void MLLPPMLEDOI(Entity OAOGLFGGBPI, Entity BGCBBDJLHHN, bool JHECLPHKCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x37A9840", Offset = "0x37A8C40", VA = "0x1837A9840")]
		public void MLLPPMLEDOI(NativeArray<Entity> GNGEEFEGDCP, Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x37A9C50", Offset = "0x37A9050", VA = "0x1837A9C50")]
		public void MLLPPMLEDOI(EntityQuery JLMGAJOHFKO, Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x37A90F0", Offset = "0x37A84F0", VA = "0x1837A90F0")]
		private void HJAIIKEEICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x37A8B80", Offset = "0x37A7F80", VA = "0x1837A8B80")]
		private void DMAKAEHGJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x37A92F0", Offset = "0x37A86F0", VA = "0x1837A92F0")]
		private Entity HODELEFOMOF()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x37A9520", Offset = "0x37A8920", VA = "0x1837A9520")]
		private void JHMAGIAALJF(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x37A8A10", Offset = "0x37A7E10", VA = "0x1837A8A10")]
		private void BNOIFHEPNDO(EntityQuery JGBCHPFJOAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x37A8730", Offset = "0x37A7B30", VA = "0x1837A8730")]
		private void BNOIFHEPNDO(NativeArray<Entity> KPLEIKICILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x37A9D00", Offset = "0x37A9100", VA = "0x1837A9D00")]
		private void NIHNKGNIJGP(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x37A8C10", Offset = "0x37A8010", VA = "0x1837A8C10")]
		private void EMIFGHKMNKM(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x37A9750", Offset = "0x37A8B50", VA = "0x1837A9750")]
		private void LFAPBPHJOBF(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x37A8BB0", Offset = "0x37A7FB0", VA = "0x1837A8BB0")]
		private void DNJGBLIDLMP(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x37A9F10", Offset = "0x37A9310", VA = "0x1837A9F10")]
		private void PLLDBBAJIEP(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x37A9440", Offset = "0x37A8840", VA = "0x1837A9440")]
		private void IDEDJPFOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF0E0", Offset = "0x4DCE4E0", VA = "0x184DCF0E0")]
		private void ANICKOGBLOA<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BAFHNOAMAJM(SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x37A95E0", Offset = "0x37A89E0", VA = "0x1837A95E0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void KNECCGIGHGG(EntityQuery JLMGAJOHFKO, string IGHJIHNAPBA, SceneTag LCNLGBDLFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x37A97F0", Offset = "0x37A8BF0", VA = "0x1837A97F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LFLEOFFKJIO(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CDELGNLILHL(Entity BGCBBDJLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[LOJIIDJFKAI(typeof(GKJCKFLLFKJ), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	[KFMPJDNIPEO(JHCKAKNDFFP.PhotonRoom)]
	internal class UnitySceneService : DPDCPMNGBKH, GKJCKFLLFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[IMNMHIBEIDL]
		private SceneService KPLEIKICILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> CDLGAINENNB;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x37B7D20", Offset = "0x37B7120", VA = "0x1837B7D20")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x37B7FD0", Offset = "0x37B73D0", VA = "0x1837B7FD0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x37B7BB0", Offset = "0x37B6FB0", VA = "0x1837B7BB0", Slot = "5")]
		public void GCBIKBKOJJD(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x37B7DE0", Offset = "0x37B71E0", VA = "0x1837B7DE0", Slot = "6")]
		public bool OECKGMOBFFL(NFJEDPPAJMK OOGHONKGHEE, Transform LJLOGOIJMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x37B7D70", Offset = "0x37B7170", VA = "0x1837B7D70")]
		private bool ILJBFEHHAOO(Scene BGCBBDJLHHN, out Entity DBINELJNBGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x37B8060", Offset = "0x37B7460", VA = "0x1837B8060")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[MBALNPKLAGP(FOFKCKDBIPD.ComponentSystemTypes)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[IMNMHIBEIDL]
		private DEBKKNKNNEP LHDIADGEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity OAOGLFGGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private ComponentTypeList AOONNNAPHDO;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int HGPJFHAOHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x37AF020", Offset = "0x37AE420", VA = "0x1837AF020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity COBGFIFKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager MGHBNCMOGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x37AEB30", Offset = "0x37ADF30", VA = "0x1837AEB30")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x4DD09B0", Offset = "0x4DCFDB0", VA = "0x184DD09B0")]
		public T JLPNHBINJFC<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x4DD08E0", Offset = "0x4DCFCE0", VA = "0x184DD08E0")]
		public void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x37AF030", Offset = "0x37AE430", VA = "0x1837AF030", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x37AEB80", Offset = "0x37ADF80", VA = "0x1837AEB80", Slot = "5")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x37AEB80", Offset = "0x37ADF80", VA = "0x1837AEB80")]
		private void PNIDGLKCLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x37AE860", Offset = "0x37ADC60", VA = "0x1837AE860", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x37AED20", Offset = "0x37AE120", VA = "0x1837AED20")]
		private ComponentTypeList KIEBILDCJFO()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void FLFGKGJNFOF(int OCCKKIPCFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		private static void CGLNAPDCPBD(Type DDJDPMGLPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x37AE7C0", Offset = "0x37ADBC0", VA = "0x1837AE7C0")]
		private static void AINDOEJCEMC(Type DDJDPMGLPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct EOFMIIIMDOL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[LOJIIDJFKAI(typeof(LEPGAPILAAM), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class LEPGAPILAAM : DPDCPMNGBKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[IMNMHIBEIDL]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::IMJKKCAJKJE<KKCCBJBJBOD, Entity> HNLGNIOKMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::GGEJOAKONHH<FKACANNGOBE> MNDJFDEMNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::GGEJOAKONHH<OHNEHFENPHJ> JHCKKDMPKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::GGEJOAKONHH<JIGPGFGCLCJ> PNCGNDEAKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::GGEJOAKONHH<NJONDCMECFD> BJHPEMPKHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::GGEJOAKONHH<JEHJBIOPOMD> CCJAOIAIHHP;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::PMFGMAIPJGC<Entity> APJLAJFFDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public AKGLNOALMDP BCNGECMJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public AKGLNOALMDP KNAJBFDLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public AKGLNOALMDP KAKLNDMBCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public AKGLNOALMDP JKIBGGBBOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AKGLNOALMDP CGOGCINFOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x3683600", Offset = "0x3682A00", VA = "0x183683600")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x3683650", Offset = "0x3682A50", VA = "0x183683650", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x3683510", Offset = "0x3682910", VA = "0x183683510", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x2877990", Offset = "0x2876D90", VA = "0x182877990")]
	private void HBGEMGCKMHE<T>(ref global::GGEJOAKONHH<T> BAMMKKCEACG) where T : struct, NBKDCFKNMHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x2877990", Offset = "0x2876D90", VA = "0x182877990")]
	private void HBGEMGCKMHE<TC, TV>(ref global::IMJKKCAJKJE<TC, TV> BAMMKKCEACG) where TC : struct, NBKDCFKNMHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public LEPGAPILAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[LOJIIDJFKAI(typeof(IMPKDEPFPDI), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal sealed class IMPKDEPFPDI : LFPMKPLIAAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private HNJLOOJCIKA JLLNJFMLFDB;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HNJLOOJCIKA CEGOKBJBFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x12501F0", Offset = "0x124F5F0", VA = "0x1812501F0")]
		get
		{
			return default(HNJLOOJCIKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x3A47970", Offset = "0x3A46D70", VA = "0x183A47970", Slot = "4")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x3A47960", Offset = "0x3A46D60", VA = "0x183A47960", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public IMPKDEPFPDI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(TransformOwnershipPhase), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum GJKDBKKDDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct CDMMKMABJNA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private GJKDBKKDDNJ CHIGJKKLELG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase GPFONCECPBK;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x475C590", Offset = "0x475B990", VA = "0x18475C590")]
			public CDMMKMABJNA(TransformOwnershipPhase GPFONCECPBK, GJKDBKKDDNJ KGOFCGFBHNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x475C570", Offset = "0x475B970", VA = "0x18475C570", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public GJKDBKKDDNJ KGOFCGFBHNK;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public GJKDBKKDDNJ BLOCIPJCABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
			get
			{
				return default(GJKDBKKDDNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x7532B0", Offset = "0x7526B0", VA = "0x1807532B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool LMEAOFLIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x1388150", Offset = "0x1387550", VA = "0x181388150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool DGJJFLPOFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x1490A20", Offset = "0x148FE20", VA = "0x181490A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x37B2390", Offset = "0x37B1790", VA = "0x1837B2390")]
		public CDMMKMABJNA FABELCJDDFL()
		{
			return default(CDMMKMABJNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x37B2360", Offset = "0x37B1760", VA = "0x1837B2360")]
		public CDMMKMABJNA EFIPPAELNKB()
		{
			return default(CDMMKMABJNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[LOJIIDJFKAI(typeof(PEJNHEGAEGK), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Circuits)]
	public class CircuitsService : DPDCPMNGBKH, PEJNHEGAEGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[IMNMHIBEIDL]
		private NHBHMJGOMNH FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x36DB7B0", Offset = "0x36DABB0", VA = "0x1836DB7B0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x36DB1D0", Offset = "0x36DA5D0", VA = "0x1836DB1D0", Slot = "5")]
		public bool HDOAAKFDILL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x36DB2D0", Offset = "0x36DA6D0", VA = "0x1836DB2D0", Slot = "7")]
		public Guid ICJNFLKOOME(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x36DA850", Offset = "0x36D9C50", VA = "0x1836DA850", Slot = "8")]
		public void ALDIAANMIGE(NFJEDPPAJMK OOGHONKGHEE, Guid GADNLPCKAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x36DB510", Offset = "0x36DA910", VA = "0x1836DB510", Slot = "9")]
		public Guid KADHPPLAKGK(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x36DA5F0", Offset = "0x36D99F0", VA = "0x1836DA5F0", Slot = "10")]
		public void ALAKLCNJDKI(NFJEDPPAJMK OOGHONKGHEE, Guid ICBBOKLLMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x36DAFF0", Offset = "0x36DA3F0", VA = "0x1836DAFF0", Slot = "11")]
		public bool GBAMJPEPJPH(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x36DAB10", Offset = "0x36D9F10", VA = "0x1836DAB10", Slot = "12")]
		public void DJGGAIHIALF(NFJEDPPAJMK OOGHONKGHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x36DAB80", Offset = "0x36D9F80", VA = "0x1836DAB80", Slot = "13")]
		public void DJPJCHIHIHA(NFJEDPPAJMK MOOHJICILGA, NFJEDPPAJMK GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x36DB3A0", Offset = "0x36DA7A0", VA = "0x1836DB3A0")]
		private void IKMGMOMNLMB(CEPMAFNDCOM KECKFACHJCH, NFJEDPPAJMK GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x36DB040", Offset = "0x36DA440", VA = "0x1836DB040")]
		private void GNKBINGBKOC(CEPMAFNDCOM KECKFACHJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x36DB5E0", Offset = "0x36DA9E0", VA = "0x1836DB5E0")]
		private bool LOFHHIGCAFE(JMAKJOJHHNF ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x36DAF40", Offset = "0x36DA340", VA = "0x1836DAF40")]
		private bool FGMGCOEEBCJ(JMAKJOJHHNF ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x36DAAB0", Offset = "0x36D9EB0", VA = "0x1836DAAB0", Slot = "6")]
		public bool ANLDDCHAFPJ(NFJEDPPAJMK ONBAMHPEIDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[MBALNPKLAGP(FOFKCKDBIPD.Connectables)]
	[LOJIIDJFKAI(typeof(KGOCHOHEAHM), new string[] { })]
	internal class ConnectableService : KGOCHOHEAHM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class CCDKJCNOEJD : IEnumerable<NFJEDPPAJMK>, IEnumerable, IEnumerator<NFJEDPPAJMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private NFJEDPPAJMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private NFJEDPPAJMK localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public NFJEDPPAJMK <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private NFJEDPPAJMK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NFJEDPPAJMK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x37A2E20", Offset = "0x37A2220", VA = "0x1837A2E20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x760D30", Offset = "0x760130", VA = "0x180760D30")]
			[DebuggerHidden]
			public CCDKJCNOEJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x37A2E70", Offset = "0x37A2270", VA = "0x1837A2E70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x37A2A30", Offset = "0x37A1E30", VA = "0x1837A2A30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x37A2F40", Offset = "0x37A2340", VA = "0x1837A2F40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x37A2F90", Offset = "0x37A2390", VA = "0x1837A2F90")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x37A2DE0", Offset = "0x37A21E0", VA = "0x1837A2DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x37A2D30", Offset = "0x37A2130", VA = "0x1837A2D30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NFJEDPPAJMK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x37A2D30", Offset = "0x37A2130", VA = "0x1837A2D30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly FADHLPPNOEF PAPLKBBKEMI;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int LKCOAEFNGDO = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int NPDALJINFHP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private DFPNHPPNFLJ ELCDAMLJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private GAOMEBKFAAA FGFPMOHFMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService FMKAHEFPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::DEHNDDIKMEN<Entity> DJIJEGELBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::DEHNDDIKMEN<float3> GCAODGABHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::DEHNDDIKMEN<quaternion> MMKHPPEPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::DEHNDDIKMEN<Entity> GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::DEHNDDIKMEN<float3> HHJBJKMLAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::DEHNDDIKMEN<quaternion> LLGKGFNMLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> HPGNAABABLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> MEEGCJMDFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery GFIAFOEDDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool LKMIDCEHKGL;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<GJLAMBHCAMH> JBNONCCLHCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x6EC430", Offset = "0x6EB830", VA = "0x1806EC430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x6EC5E0", Offset = "0x6EB9E0", VA = "0x1806EC5E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK> GFKLHDGNJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x36E0F60", Offset = "0x36E0360", VA = "0x1836E0F60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x36E0EC0", Offset = "0x36E02C0", VA = "0x1836E0EC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK> DHDLEAOLJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x36DFF20", Offset = "0x36DF320", VA = "0x1836DFF20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x36DF4D0", Offset = "0x36DE8D0", VA = "0x1836DF4D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<NFJEDPPAJMK, NFJEDPPAJMK, NFJEDPPAJMK> DLDCLODHMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x36E0A60", Offset = "0x36DFE60", VA = "0x1836E0A60", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x36E1090", Offset = "0x36E0490", VA = "0x1836E1090", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<NFJEDPPAJMK> MGPOCDHHGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x36E0BB0", Offset = "0x36DFFB0", VA = "0x1836E0BB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x36E09C0", Offset = "0x36DFDC0", VA = "0x1836E09C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x36E1130", Offset = "0x36E0530", VA = "0x1836E1130", Slot = "25")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x36E0060", Offset = "0x36DF460", VA = "0x1836E0060", Slot = "26")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x36DF930", Offset = "0x36DED30", VA = "0x1836DF930", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x36E0780", Offset = "0x36DFB80", VA = "0x1836E0780")]
		private void KADFGIONPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x36DFAE0", Offset = "0x36DEEE0", VA = "0x1836DFAE0")]
		private void EGBJBKGMION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x36E0C50", Offset = "0x36E0050", VA = "0x1836E0C50")]
		private void NBONHMIBOGB(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x36DF780", Offset = "0x36DEB80", VA = "0x1836DF780")]
		private void CKJADHBEIAJ(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5B150", Offset = "0x1C5A550", VA = "0x181C5B150", Slot = "14")]
		public NFJEDPPAJMK HFHDDBDJANF(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B620", Offset = "0x1C0AA20", VA = "0x181C0B620", Slot = "15")]
		public Color HHODCMBIBMD(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x36E07E0", Offset = "0x36DFBE0", VA = "0x1836E07E0", Slot = "16")]
		public float3 LBPKPMBCHOC(NFJEDPPAJMK OOGHONKGHEE, int KBMAHEDNDFP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x36E0E10", Offset = "0x36E0210", VA = "0x1836E0E10", Slot = "17")]
		public bool NCAAKEIGBDM(NFJEDPPAJMK OOGHONKGHEE, NFJEDPPAJMK HIAKCAGPFMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x36E0B00", Offset = "0x36DFF00", VA = "0x1836E0B00", Slot = "18")]
		public NFJEDPPAJMK MAAOOGFLOCL(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x36DF7E0", Offset = "0x36DEBE0", VA = "0x1836DF7E0", Slot = "21")]
		public void DHIKDMAALFF(NFJEDPPAJMK OOGHONKGHEE, Vector3 KMMGHCOAKBG, Quaternion KEGLNCHNEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x36DFFC0", Offset = "0x36DF3C0", VA = "0x1836DFFC0", Slot = "23")]
		public float3 INBBNOGKAAD(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x36E1000", Offset = "0x36E0400", VA = "0x1836E1000", Slot = "24")]
		public quaternion PBBFFBIJIPF(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x36DFE20", Offset = "0x36DF220", VA = "0x1836DFE20", Slot = "28")]
		public RigidTransform GGFDIFPEJGO(NCKKGAOHGBN DIFJCEEAAOE)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x36DF600", Offset = "0x36DEA00", VA = "0x1836DF600", Slot = "22")]
		public bool CFNHIKHHNDE(NFJEDPPAJMK OOGHONKGHEE, out RigidTransform NKKNNJOLJCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x36DF570", Offset = "0x36DE970", VA = "0x1836DF570", Slot = "19")]
		[IteratorStateMachine(typeof(CCDKJCNOEJD))]
		public IEnumerable<NFJEDPPAJMK> BIKGLEMMNFO(NFJEDPPAJMK OOGHONKGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x36E0500", Offset = "0x36DF900", VA = "0x1836E0500", Slot = "20")]
		public NFJEDPPAJMK JEANBCHEEEA(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x36DFC50", Offset = "0x36DF050", VA = "0x1836DFC50", Slot = "29")]
		public void EKEABBPPCMB(ref List<NFJEDPPAJMK> JGJKBMBOGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x36E0660", Offset = "0x36DFA60", VA = "0x1836E0660")]
		private Entity JEANBCHEEEA(Entity OAOGLFGGBPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x36E1340", Offset = "0x36E0740", VA = "0x1836E1340")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	[LOJIIDJFKAI(typeof(ObjectInstantiationService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Prefabs)]
	internal sealed class ObjectInstantiationService : DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA OACNPKMLCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[IMNMHIBEIDL]
		private LNNMLPAEAED HJCGDDIMGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[IMNMHIBEIDL]
		private AAIADCALDOD DMCMGHEPJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[IMNMHIBEIDL]
		private ObjectNetworkToLocalMapService OHHOLLBKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[IMNMHIBEIDL]
		private ObjectLifecycleService JHGGFPKIOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[IMNMHIBEIDL]
		private ObjectPrefabs DHJNAJDHBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[IMNMHIBEIDL]
		private JEIKFBGOBDH HGNDMBCHHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private FNCOHMIDMDB OKPOBPNCFMK;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int APEIIPIDGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x368DFF0", Offset = "0x368D3F0", VA = "0x18368DFF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x368E120", Offset = "0x368D520", VA = "0x18368E120", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x368E0A0", Offset = "0x368D4A0", VA = "0x18368E0A0")]
		public Entity MMLGPEAALJN(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x368DCC0", Offset = "0x368D0C0", VA = "0x18368DCC0")]
		public Entity AIPMEHKGCLA(IOLFAAOECPP IOCKLNNJMIA, MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x368DDB0", Offset = "0x368D1B0", VA = "0x18368DDB0")]
		public Entity CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x368DD70", Offset = "0x368D170", VA = "0x18368DD70")]
		public Entity CPIDOPDPFFB(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x368DE90", Offset = "0x368D290", VA = "0x18368DE90")]
		public Entity GKHEHOAFOIC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x368DE00", Offset = "0x368D200", VA = "0x18368DE00")]
		public Entity FBCCHMIENCE(PCLEKMKAJBM DDJDPMGLPAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x368E250", Offset = "0x368D650", VA = "0x18368E250")]
		public Entity PPFCLJJLPDP(MJPOECHPGHN DDJDPMGLPAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x368DC70", Offset = "0x368D070", VA = "0x18368DC70")]
		public NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)> AALANCDKDJF(NativeArray<NFJEDPPAJMK> IHEMFOMABIH, Allocator OPBLDCCKGEG)
		{
			return default(NativeArray<(NFJEDPPAJMK, NFJEDPPAJMK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x368DD20", Offset = "0x368D120", VA = "0x18368DD20")]
		public IEnumerable<MFOBNBKALPH> BNBJLMLDFAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x368E040", Offset = "0x368D440", VA = "0x18368E040")]
		public EntityArchetype KFGAPPIDKBA(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x368E0C0", Offset = "0x368D4C0", VA = "0x18368E0C0")]
		public Entity ODADLIIMGLG(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x368DD70", Offset = "0x368D170", VA = "0x18368DD70")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x368DDB0", Offset = "0x368D1B0", VA = "0x18368DDB0")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO, bool FINBKHFKJFP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x368DED0", Offset = "0x368D2D0", VA = "0x18368DED0")]
		private Entity IBLFLFDFPKD(MFOBNBKALPH JDHIJCJKFOO, IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[MBALNPKLAGP(FOFKCKDBIPD.Physics)]
	[LOJIIDJFKAI(typeof(DPHIHEMGLPB), new string[] { })]
	public sealed class PhysicsSceneColliderService : DPHIHEMGLPB, CCINBDMJAOA, LFPMKPLIAAM, DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string GJDDBOBPNEB = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int AEIMMGBFCML = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int ODPMBKFFPPO = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[IMNMHIBEIDL]
		private BMGHPMCGENG BDFANKEHIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] CMLOJLGCMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] BLGLLHOGLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::JBJIOMDHKBO<LPABFJLFMIG, BoxCollider> NIMLMKIGPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene BGCBBDJLHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene CLHGLCCEMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject NMEDHGOIPNG;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int DOCPELJKEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x3699490", Offset = "0x3698890", VA = "0x183699490", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x36994D0", Offset = "0x36988D0", VA = "0x1836994D0", Slot = "9")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x36999D0", Offset = "0x3698DD0", VA = "0x1836999D0", Slot = "10")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x36992E0", Offset = "0x36986E0", VA = "0x1836992E0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x3699750", Offset = "0x3698B50", VA = "0x183699750", Slot = "4")]
		public LPABFJLFMIG MKLPHMNOBHM(Entity OAOGLFGGBPI)
		{
			return default(LPABFJLFMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3698F10", Offset = "0x3698310", VA = "0x183698F10", Slot = "5")]
		public void BNJCPCDOJIO(NativeArray<LPABFJLFMIG> OFODIKGIPOH, NativeArray<PBPGODBNIIF> LIJLBDEDOGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x3699150", Offset = "0x3698550", VA = "0x183699150", Slot = "6")]
		public void CHLKOJEFFEK(LPABFJLFMIG KJNCDAGJAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3698B60", Offset = "0x3697F60", VA = "0x183698B60", Slot = "7")]
		public bool ALBBCNDDHCH(LPABFJLFMIG KJNCDAGJAPF, out Collider NCCADNBJIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3698C00", Offset = "0x3698000", VA = "0x183698C00")]
		public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x3699430", Offset = "0x3698830", VA = "0x183699430")]
		private void HCDHOJHPCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCF0", Offset = "0x6ED0F0", VA = "0x1806EDCF0")]
		private void NIJKJIAFGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x36993E0", Offset = "0x36987E0", VA = "0x1836993E0")]
		private void GFMJGILOAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xF461E0", Offset = "0xF455E0", VA = "0x180F461E0")]
		private void GPMCBAECEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x36998B0", Offset = "0x3698CB0", VA = "0x1836998B0")]
		private BoxCollider NBJHKNOBLDJ(Entity OAOGLFGGBPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x3699260", Offset = "0x3698660", VA = "0x183699260")]
		private void DIDDBOIPBNE(BoxCollider FGHDNBPDEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x3699CA0", Offset = "0x36990A0", VA = "0x183699CA0")]
		[Conditional("UNITY_EDITOR")]
		private void PNGINCICOCE(GameObject OOKBNBHDPPG, Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x3698970", Offset = "0x3697D70", VA = "0x183698970")]
		private void AFEDMNAKEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x3699640", Offset = "0x3698A40", VA = "0x183699640")]
		private void KIIPKADPMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x3699A90", Offset = "0x3698E90", VA = "0x183699A90")]
		private void PMGLAOEGFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x3699120", Offset = "0x3698520", VA = "0x183699120")]
		private void BOMEGKLLNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x3699480", Offset = "0x3698880", VA = "0x183699480")]
		private void HFBNNIAGHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x3699220", Offset = "0x3698620", VA = "0x183699220")]
		private void DDAINOGDGAK(Scene CDPLHKGNILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x36998A0", Offset = "0x3698CA0", VA = "0x1836998A0", Slot = "8")]
		private bool MLFDMKJKJKC(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[LOJIIDJFKAI(typeof(NOGKKJEEDNP), new string[] { })]
public sealed class KKIHIGJMKJD : NOGKKJEEDNP, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct EDNNPEMMHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float JBOJGNNLCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint ICAOKLMLEIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private CCINBDMJAOA IBDIHHBPCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private HFFECIEHFPL JDDODMDBFGF;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F1A0", Offset = "0x3A4E5A0", VA = "0x183A4F1A0", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EBE0", Offset = "0x3A4DFE0", VA = "0x183A4EBE0")]
	public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, out DHHPKBBIADG GKPLJANNKLP, out Entity BCFGIMKABOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F0A0", Offset = "0x3A4E4A0", VA = "0x183A4F0A0")]
	public static bool NAKFBCJOHCD(in Span<DHHPKBBIADG> EGECBAPDDJM, float KMAOMDJLDEN, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F060", Offset = "0x3A4E460", VA = "0x183A4F060")]
	public static float BBKOOIFMEPG(float JBOJGNNLCOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public KKIHIGJMKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F090", Offset = "0x3A4E490", VA = "0x183A4F090", Slot = "4")]
	private bool JGHLCIBPKME(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, out DHHPKBBIADG GKPLJANNKLP, out Entity BCFGIMKABOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[LOJIIDJFKAI(typeof(HFFECIEHFPL), new string[] { })]
public sealed class EFKCINBKBEK : HFFECIEHFPL, DPDCPMNGBKH
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct ODMNCNKBNJE : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> GNGEEFEGDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 LJNFAFBDPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 GCHNHAFLLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> HPKKGOGFLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> JMBDAJANIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NGOPFBDABOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> JCMDBEGKCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> LBEHDJBDFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<DHHPKBBIADG> GLFDAJFJIGJ;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly DHHPKBBIADG CJBBFIGOKFA;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x37A61F0", Offset = "0x37A55F0", VA = "0x1837A61F0", Slot = "4")]
		public void Execute(int BELCAJFDAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x37A65D0", Offset = "0x37A59D0", VA = "0x1837A65D0")]
		private static float3 MDPFHAMJCDB(in float4x4 CFPAGFJCEHC, in float3 KHNOBAAPEAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x37A5AC0", Offset = "0x37A4EC0", VA = "0x1837A5AC0")]
		private static float3 CBENELOOHGA(in float4x4 CFPAGFJCEHC, in float3 ABLKMJLKIKH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x37A64D0", Offset = "0x37A58D0", VA = "0x1837A64D0")]
		private static float3 LOJOLHONEGH(in float4x4 CFPAGFJCEHC, in float3 KHNOBAAPEAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x37A5C80", Offset = "0x37A5080", VA = "0x1837A5C80")]
		private static float3 EEFKFKOEFON(in float4x4 CFPAGFJCEHC, in float3 ABLKMJLKIKH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x37A5EA0", Offset = "0x37A52A0", VA = "0x1837A5EA0")]
		private bool ENEJGLEIJAN(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<Entity> KLKFAEBGKNK, out float3 GKPLJANNKLP, out float3 EMALJDHGDFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x37A66A0", Offset = "0x37A5AA0", VA = "0x1837A66A0")]
		public static bool ODPCONDBIEH(in float3 NNMAFADONCE, in float3 JEGCEJIDDCG, in float3 PCAFKIBGCHA, in float3 CBGHIIFGHNB, float BMOLCPJMDGL, float PEAEJAGKHAK, out float EHIBGNPGILO, out float3 BCFFBCFIMGP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager KNABDDPENKI;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x36EAA40", Offset = "0x36E9E40", VA = "0x1836EAA40", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x36EA550", Offset = "0x36E9950", VA = "0x1836EA550")]
	public void APHFDLGPJFP(in NativeArray<Entity> GNGEEFEGDCP, in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<DHHPKBBIADG> JAJAEFPBINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EFKCINBKBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x36EAA30", Offset = "0x36E9E30", VA = "0x1836EAA30", Slot = "4")]
	private void GHAMBEBPBBO(in NativeArray<Entity> GNGEEFEGDCP, in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, in NativeArray<DHHPKBBIADG> JAJAEFPBINK)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[LOJIIDJFKAI(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.Embodiment)]
	[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[IMNMHIBEIDL]
		private CPEFIMBHABA PJGPDAEMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[IMNMHIBEIDL]
		private LNNMLPAEAED DDFJHGAMHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[IMNMHIBEIDL]
		private AAIADCALDOD GEGLBNPPOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private NPFNHEGAPFJ KEFDOOCIHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<IOLFAAOECPP, Entity> KDPGFILMLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager KNABDDPENKI;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<IOLFAAOECPP, Entity> IMFBJJCGKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xD489D0", Offset = "0xD47DD0", VA = "0x180D489D0")]
			get
			{
				return default(NativeHashMap<IOLFAAOECPP, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint ONEHNENJNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x36911F0", Offset = "0x36905F0", VA = "0x1836911F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool ACLLOIKFPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x705CF0", Offset = "0x7050F0", VA = "0x180705CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x7061E0", Offset = "0x7055E0", VA = "0x1807061E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x36915A0", Offset = "0x36909A0", VA = "0x1836915A0", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3691220", Offset = "0x3690620", VA = "0x183691220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x3691290", Offset = "0x3690690", VA = "0x183691290")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x3691030", Offset = "0x3690430", VA = "0x183691030")]
		public void CECCKMOGCHG(IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x36913F0", Offset = "0x36907F0", VA = "0x1836913F0")]
		private NFJEDPPAJMK JGKFJOJMEAP(Entity OAOGLFGGBPI)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3691310", Offset = "0x3690710", VA = "0x183691310")]
		public NFJEDPPAJMK HELPAPLNDJP(IOLFAAOECPP IOCKLNNJMIA)
		{
			return default(NFJEDPPAJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x3691480", Offset = "0x3690880", VA = "0x183691480")]
		public IOLFAAOECPP LPAPEMKKHGI(NFJEDPPAJMK OOGHONKGHEE)
		{
			return default(IOLFAAOECPP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x3691510", Offset = "0x3690910", VA = "0x183691510")]
		public void OPEFIPBMOFI(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x3691420", Offset = "0x3690820", VA = "0x183691420")]
		public void JGOBGPNIMKB(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x3690F00", Offset = "0x3690300", VA = "0x183690F00")]
		public void AKKFBCFDNPG(Entity OAOGLFGGBPI, IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x3690F60", Offset = "0x3690360", VA = "0x183690F60")]
		public void BBAFMAALDCM(Entity OAOGLFGGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[LOJIIDJFKAI(typeof(PropertyEventCallbacksService), new string[] { })]
	[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
	[MBALNPKLAGP(FOFKCKDBIPD.Callbacks)]
	public class PropertyEventCallbacksService : DPDCPMNGBKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct DHLLIHDPGNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public BFNCOEDHLLM IGAMPECHIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type DDJDPMGLPAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int PCAHMJECHKC;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct MNGNCKDOOAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public DHLLIHDPGNG[] ELCMIPNJFNP;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void BFNCOEDHLLM(Entity OAOGLFGGBPI, NMLCFAIOCDK MPKOBDPILJB, LONBCMOJAJF IAMOONJKNLF, LONBCMOJAJF AFLEFPKENKF);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<NMLCFAIOCDK, BFNCOEDHLLM> DEIGJEJHMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, MNGNCKDOOAM> OECLHDKGEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private KHFJEIHOPJL ELCMIPNJFNP;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action BAOBKENPIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x36A0610", Offset = "0x369FA10", VA = "0x1836A0610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x369F5B0", Offset = "0x369E9B0", VA = "0x18369F5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action KLJGMEAPGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x369FAD0", Offset = "0x369EED0", VA = "0x18369FAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x369FA30", Offset = "0x369EE30", VA = "0x18369FA30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x36A0330", Offset = "0x369F730", VA = "0x1836A0330", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x369F430", Offset = "0x369E830", VA = "0x18369F430", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x369F650", Offset = "0x369EA50", VA = "0x18369F650")]
		public void KJDPCLCGNLB(NMLCFAIOCDK MPKOBDPILJB, BFNCOEDHLLM IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x369F4C0", Offset = "0x369E8C0", VA = "0x18369F4C0")]
		public void JHPDLJNMECO(NMLCFAIOCDK MPKOBDPILJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x36A0380", Offset = "0x369F780", VA = "0x1836A0380")]
		internal void PEKNGHHEIPM(DOBDGKNHJII BGHMFEPCABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x369FDF0", Offset = "0x369F1F0", VA = "0x18369FDF0")]
		private void PBPOKAFDLAA(DOBDGKNHJII BGHMFEPCABE, int NLGBDLLFIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x369FB70", Offset = "0x369EF70", VA = "0x18369FB70")]
		private void NOFFIOMBDHO(GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB, DHLLIHDPGNG DKEGLKMJLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x369F8B0", Offset = "0x369ECB0", VA = "0x18369F8B0")]
		private MNGNCKDOOAM NHCAGFAMJCA(GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB)
		{
			return default(MNGNCKDOOAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x369F7C0", Offset = "0x369EBC0", VA = "0x18369F7C0")]
		private DHLLIHDPGNG NFFCKLOAJPK(MNGNCKDOOAM AJMEBMGKGGC, GKFDLLIKKMD IPFKDLFGNOG, CNAIHAMIBKF EPELECFNMCB)
		{
			return default(DHLLIHDPGNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x36A0700", Offset = "0x369FB00", VA = "0x1836A0700")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[LOJIIDJFKAI(typeof(NINFMKFKPIG), new string[] { })]
public class EHONOOCHJEC : DPDCPMNGBKH, FPHKGEBJIKC, NINFMKFKPIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class LILAKNKEIJE : IEnumerable<NFJEDPPAJMK>, IEnumerable, IEnumerator<NFJEDPPAJMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private NFJEDPPAJMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public EHONOOCHJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NFJEDPPAJMK splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public NFJEDPPAJMK <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private NFJEDPPAJMK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NFJEDPPAJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x4763E40", Offset = "0x4763240", VA = "0x184763E40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x760D30", Offset = "0x760130", VA = "0x180760D30")]
		[DebuggerHidden]
		public LILAKNKEIJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x4763C90", Offset = "0x4763090", VA = "0x184763C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x4763E00", Offset = "0x4763200", VA = "0x184763E00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x4763D50", Offset = "0x4763150", VA = "0x184763D50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NFJEDPPAJMK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x4763D50", Offset = "0x4763150", VA = "0x184763D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private ECMHFHDFNAA DPEGFHFLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService DHJNAJDHBIA;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager MGHBNCMOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x3A34910", Offset = "0x3A33D10", VA = "0x183A34910")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private JCGKPCPJOOI OHPMAEDABBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x3A341F0", Offset = "0x3A335F0", VA = "0x183A341F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x3A35300", Offset = "0x3A34700", VA = "0x183A35300", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x3A35090", Offset = "0x3A34490", VA = "0x183A35090", Slot = "5")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x3A342B0", Offset = "0x3A336B0", VA = "0x183A342B0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x3A34E10", Offset = "0x3A34210", VA = "0x183A34E10")]
	private void IOJEGPEKJCP(Entity MEGKMABGGNB, in LONBCMOJAJF OCEKJFOFJLA, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x3A348B0", Offset = "0x3A33CB0", VA = "0x183A348B0", Slot = "14")]
	public NFJEDPPAJMK GKHEHOAFOIC()
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x3A34360", Offset = "0x3A33760", VA = "0x183A34360", Slot = "10")]
	public void ENBCPMDHGKD(NFJEDPPAJMK OOGHONKGHEE, PEBFAOCIAHA OOMECLFFJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x3A34420", Offset = "0x3A33820", VA = "0x183A34420", Slot = "9")]
	public PEBFAOCIAHA FAEACHJGIFH(NFJEDPPAJMK OOGHONKGHEE)
	{
		return default(PEBFAOCIAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x3A34960", Offset = "0x3A33D60", VA = "0x183A34960", Slot = "11")]
	public NFJEDPPAJMK HNFLMLOPHHA(NFJEDPPAJMK OHJOALHOEEJ, [Optional] Vector3? DACBJNCMNFL, [Optional] Quaternion? MCFIHGJCDCP, [Optional] Vector3? BDMGGOCELCK)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x3A352C0", Offset = "0x3A346C0", VA = "0x183A352C0", Slot = "15")]
	public NFJEDPPAJMK NGLCCBCIDOG(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD, [Optional] Vector3? DACBJNCMNFL, [Optional] Quaternion? MCFIHGJCDCP, [Optional] Vector3? BDMGGOCELCK)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x3A34D20", Offset = "0x3A34120", VA = "0x183A34D20", Slot = "7")]
	public NFJEDPPAJMK IMFDOPICOHE(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD)
	{
		return default(NFJEDPPAJMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x3A35390", Offset = "0x3A34790", VA = "0x183A35390", Slot = "16")]
	public void PLCIHKEHIPN(NFJEDPPAJMK BBFEKNBJKMC, NFJEDPPAJMK CFGMGHMOBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x3A344E0", Offset = "0x3A338E0", VA = "0x183A344E0", Slot = "12")]
	public void FLKEGBPLANM(NFJEDPPAJMK BBFEKNBJKMC, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x3A34710", Offset = "0x3A33B10", VA = "0x183A34710", Slot = "17")]
	public void GFAKBMKOKAI(NFJEDPPAJMK BBFEKNBJKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x3A35220", Offset = "0x3A34620", VA = "0x183A35220", Slot = "8")]
	public int LEDEJMODPPH(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x3A35190", Offset = "0x3A34590", VA = "0x183A35190", Slot = "6")]
	[IteratorStateMachine(typeof(LILAKNKEIJE))]
	public IEnumerable<NFJEDPPAJMK> KAOCDNPPDAP(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x3A34680", Offset = "0x3A33A80", VA = "0x183A34680")]
	private bool GBGPFIFGAOG(NFJEDPPAJMK BBFEKNBJKMC, out NativeArray<Entity> PLBLCMNMLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x3A34C60", Offset = "0x3A34060", VA = "0x183A34C60")]
	private NativeArray<Entity> ILAKBJFIDNG(NFJEDPPAJMK BBFEKNBJKMC)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EHONOOCHJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[LOJIIDJFKAI(typeof(PLIJOECNIOG), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class PLIJOECNIOG : DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private CPEFIMBHABA OACNPKMLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase EDDHBBFFICK;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private MJGGLIPIDNP IIINLMPBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x3698770", Offset = "0x3697B70", VA = "0x183698770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x36988B0", Offset = "0x3697CB0", VA = "0x1836988B0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x36987C0", Offset = "0x3697BC0", VA = "0x1836987C0")]
	public void KDEOPCGFPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x36984A0", Offset = "0x36978A0", VA = "0x1836984A0")]
	public void EDHANPBDHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public PLIJOECNIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct IKGDNLPBCGC : IEquatable<IKGDNLPBCGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int NLGBDLLFIPJ;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type MGHFMIGMODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x3A46E20", Offset = "0x3A46220", VA = "0x183A46E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F80", Offset = "0x3A46380", VA = "0x183A46F80")]
	public IKGDNLPBCGC(Type DDJDPMGLPAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F00", Offset = "0x3A46300", VA = "0x183A46F00")]
	public static IKGDNLPBCGC LOJIFGBJNLM(Type DDJDPMGLPAE)
	{
		return default(IKGDNLPBCGC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F30", Offset = "0x3A46330", VA = "0x183A46F30")]
	public static Type LOJIFGBJNLM(IKGDNLPBCGC KJNCDAGJAPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x762550", Offset = "0x761950", VA = "0x180762550")]
	public static bool GJOJIEKGOHO(IKGDNLPBCGC FAMKPEGNHFC, IKGDNLPBCGC GPHMIGDKMEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x762550", Offset = "0x761950", VA = "0x180762550")]
	public static bool ALCENKEOHOJ(IKGDNLPBCGC FAMKPEGNHFC, IKGDNLPBCGC GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x762110", Offset = "0x761510", VA = "0x180762110", Slot = "4")]
	public bool Equals(IKGDNLPBCGC IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3A46DA0", Offset = "0x3A461A0", VA = "0x183A46DA0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F50", Offset = "0x3A46350", VA = "0x183A46F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class ICMCNFAAMEA
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> IMPCKIDAPNP;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> HDCLBFPCGCP;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x3A458F0", Offset = "0x3A44CF0", VA = "0x183A458F0")]
	static ICMCNFAAMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x35DB400", Offset = "0x35DA800", VA = "0x1835DB400")]
	public static bool AOHLLDNPMGN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3A45440", Offset = "0x3A44840", VA = "0x183A45440")]
	public static bool AOHLLDNPMGN(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x3A454B0", Offset = "0x3A448B0", VA = "0x183A454B0")]
	private static bool AOHLLDNPMGN(Type DDJDPMGLPAE, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x35DB530", Offset = "0x35DA930", VA = "0x1835DB530")]
	public static int MGNJLCPLAEP<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x3A45880", Offset = "0x3A44C80", VA = "0x183A45880")]
	public static int MGNJLCPLAEP(Type DDJDPMGLPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x35DB490", Offset = "0x35DA890", VA = "0x1835DB490")]
	public static bool GIGJNHOBOLH<T>(out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x3A45620", Offset = "0x3A44A20", VA = "0x183A45620")]
	public static bool GIGJNHOBOLH(Type DDJDPMGLPAE, out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x3A457E0", Offset = "0x3A44BE0", VA = "0x183A457E0")]
	public static Type JLPNHBINJFC(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x3A456C0", Offset = "0x3A44AC0", VA = "0x183A456C0")]
	public static bool GIGJNHOBOLH(int BELCAJFDAHD, out Type DDJDPMGLPAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct KIEMDCELJOF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int ONCBCCLEFOH;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x766020", Offset = "0x765420", VA = "0x180766020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2E619F0", Offset = "0x2E60DF0", VA = "0x182E619F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> BIPDNCABMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x30DB770", Offset = "0x30DAB70", VA = "0x1830DB770")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x9C88D0", Offset = "0x9C7CD0", VA = "0x1809C88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x30DB810", Offset = "0x30DAC10", VA = "0x1830DB810")]
	public KIEMDCELJOF(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x30DB6C0", Offset = "0x30DAAC0", VA = "0x1830DB6C0")]
	public int EDAEEPKFCFE(T JFBPNBNBHOE, int IDCHKLCNMBN, int OCCKKIPCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x30DB600", Offset = "0x30DAA00", VA = "0x1830DB600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct CPJMDAICANB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::KIEMDCELJOF<T> ONIBEFDCPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int ONCBCCLEFOH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x39FF160", Offset = "0x39FE560", VA = "0x1839FF160")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int CCOICBMGNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x39FEB30", Offset = "0x39FDF30", VA = "0x1839FEB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x39FE6A0", Offset = "0x39FDAA0", VA = "0x1839FE6A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x39FE8E0", Offset = "0x39FDCE0", VA = "0x1839FE8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x39FE660", Offset = "0x39FDA60", VA = "0x1839FE660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> BIPDNCABMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x39FED20", Offset = "0x39FE120", VA = "0x1839FED20")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x39FF780", Offset = "0x39FEB80", VA = "0x1839FF780")]
	public CPJMDAICANB(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x39FDDE0", Offset = "0x39FD1E0", VA = "0x1839FDDE0")]
	public T ADBECJBPAHJ(int BELCAJFDAHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x39FF090", Offset = "0x39FE490", VA = "0x1839FF090")]
	public void KHAHMOHDIMJ(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x39FF1F0", Offset = "0x39FE5F0", VA = "0x1839FF1F0")]
	public void LGJAECILOOF(Span<T> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x39FE1D0", Offset = "0x39FD5D0", VA = "0x1839FE1D0")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x39FE2E0", Offset = "0x39FD6E0", VA = "0x1839FE2E0")]
	private void BCFLJFECAHG(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x39FDF90", Offset = "0x39FD390", VA = "0x1839FDF90")]
	public void ALLOANNJLKE(Span<T> HIMJHOIKJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x39FEA10", Offset = "0x39FDE10", VA = "0x1839FEA10")]
	public void EMPMGDILILO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x39FEE70", Offset = "0x39FE270", VA = "0x1839FEE70")]
	public void IECOBAKONFF(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x39FF100", Offset = "0x39FE500", VA = "0x1839FF100")]
	public void LDKAFBDIKPM(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x39FE6D0", Offset = "0x39FDAD0", VA = "0x1839FE6D0")]
	public void DEEKCMABCMO(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x39FEA70", Offset = "0x39FDE70", VA = "0x1839FEA70")]
	public void FAGCLLGFJNH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x39FF3D0", Offset = "0x39FE7D0", VA = "0x1839FF3D0")]
	public void MAADJFIJLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x39FE980", Offset = "0x39FDD80", VA = "0x1839FE980")]
	public int EDAEEPKFCFE(T JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x39FEB80", Offset = "0x39FDF80", VA = "0x1839FEB80")]
	public bool GPEECKGOEKF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x39FE930", Offset = "0x39FDD30", VA = "0x1839FE930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x39FF710", Offset = "0x39FEB10", VA = "0x1839FF710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x39FF360", Offset = "0x39FE760", VA = "0x1839FF360")]
	public static Span<T> LOJIFGBJNLM(global::CPJMDAICANB<T> NHOGENNANEB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x39FF5D0", Offset = "0x39FE9D0", VA = "0x1839FF5D0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void OBKBBPLPHBF(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void AEAGPLJIAHL(int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x39FDE30", Offset = "0x39FD230", VA = "0x1839FDE30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void AEAGPLJIAHL(int ONCBCCLEFOH, int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x39FF490", Offset = "0x39FE890", VA = "0x1839FF490")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MDCAMELBHHJ(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x39FE460", Offset = "0x39FD860", VA = "0x1839FE460")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BMNNBJEGPPO(int HBKAKABFBFD, int HEGLMOCOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x39FEBE0", Offset = "0x39FDFE0", VA = "0x1839FEBE0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void HCOGHMGPCOP(int JFBPNBNBHOE, int ONCBCCLEFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct HNJLOOJCIKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int PBLBMIADLFF = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> GNGEEFEGDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray ELCDAMLJAMO;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3A42510", Offset = "0x3A41910", VA = "0x183A42510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> OIHFEMNEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA20", Offset = "0x6EEE20", VA = "0x1806EFA20")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray FNNNFCDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x3A424B0", Offset = "0x3A418B0", VA = "0x183A424B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x3A425C0", Offset = "0x3A419C0", VA = "0x183A425C0")]
	public HNJLOOJCIKA(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x3A42520", Offset = "0x3A41920", VA = "0x183A42520")]
	public Entity NPGFKDKEGEL(int BELCAJFDAHD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x3A424A0", Offset = "0x3A418A0", VA = "0x183A424A0")]
	public Transform HOIMJPFPMPD(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x3A42570", Offset = "0x3A41970", VA = "0x183A42570")]
	public void OMMIMKBLIAB(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x3A422D0", Offset = "0x3A416D0", VA = "0x183A422D0")]
	public int AOHLLDNPMGN(Transform LJLOGOIJMEM, Entity OAOGLFGGBPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x3A42420", Offset = "0x3A41820", VA = "0x183A42420")]
	public int EMPMGDILILO(int BELCAJFDAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x3A423A0", Offset = "0x3A417A0", VA = "0x183A423A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x3A424D0", Offset = "0x3A418D0", VA = "0x183A424D0")]
	private void LNJFEFBOFJD(int KFFPMHLOCGD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class MOHNGBNLJCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<IKGDNLPBCGC, int2> AKNMLLLMLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> IEGPGBKLAIF;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x3686800", Offset = "0x3685C00", VA = "0x183686800")]
	public MOHNGBNLJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x36860A0", Offset = "0x36854A0", VA = "0x1836860A0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T JLPNHBINJFC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x3686220", Offset = "0x3685620", VA = "0x183686220")]
	public void HDECKBNAIGA(Type DDJDPMGLPAE, LONBCMOJAJF JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3686430", Offset = "0x3685830", VA = "0x183686430")]
	public LONBCMOJAJF JLPNHBINJFC(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3686760", Offset = "0x3685B60", VA = "0x183686760")]
	private NativeArray<byte> PFAAGCBPJKK(int2 GGOPFABBCCA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3686000", Offset = "0x3685400", VA = "0x183686000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3686100", Offset = "0x3685500", VA = "0x183686100", Slot = "1")]
	~MOHNGBNLJCF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct BHAELKOFCPA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::BHAELKOFCPA<T> LOJIFGBJNLM(T JFBPNBNBHOE)
	{
		return default(global::BHAELKOFCPA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T LOJIFGBJNLM(global::BHAELKOFCPA<T> EOBGHKICABG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class FGGCNCODMIC
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly MOHNGBNLJCF IPCLNCBGNPH;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CD20", Offset = "0x3A3C120", VA = "0x183A3CD20")]
	internal static void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void HDECKBNAIGA<T>(T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CD90", Offset = "0x3A3C190", VA = "0x183A3CD90")]
	public static void HDECKBNAIGA(Type DDJDPMGLPAE, LONBCMOJAJF JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T JLPNHBINJFC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CE30", Offset = "0x3A3C230", VA = "0x183A3CE30")]
	public static LONBCMOJAJF JLPNHBINJFC(Type DDJDPMGLPAE)
	{
		return default(LONBCMOJAJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class CJDEOKCHLHN : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly CJDEOKCHLHN HMBHBEDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x36D9600", Offset = "0x36D8A00", VA = "0x1836D9600", Slot = "4")]
	public bool Equals(LinkedEntityGroup BIAIPPDLOMD, LinkedEntityGroup ECJDGGJBGPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x36D9620", Offset = "0x36D8A20", VA = "0x1836D9620", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ADHHHFDPAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CJDEOKCHLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class GGMPHIFPNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void FDEBMOBLOHF(in Vector3 DACBJNCMNFL, in Quaternion MCFIHGJCDCP, in Vector3 BDMGGOCELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void EJMICIMCCEM(in Vector3 GGOBCHKBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void MNHIJGOBOPF(in Quaternion MCFIHGJCDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void BJILOHPEBPO(in Vector3 KEPHECCGNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void IIHDBFPLIHO(in Vector3 KEPHECCGNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void HJOOCKPDJGO(in float BBJPLPKDAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F370", Offset = "0x3A3E770", VA = "0x183A3F370")]
	[Conditional("DEBUG_BUILD")]
	public static void OKPLLAKKLPK(in float3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in float JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F2F0", Offset = "0x3A3E6F0", VA = "0x183A3F2F0")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in Vector3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F340", Offset = "0x3A3E740", VA = "0x183A3F340")]
	[Conditional("DEBUG_BUILD")]
	public static void DEOJDFLGHOP(in Quaternion JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F420", Offset = "0x3A3E820", VA = "0x183A3F420")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in float JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F430", Offset = "0x3A3E830", VA = "0x183A3F430")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in Vector3 JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F470", Offset = "0x3A3E870", VA = "0x183A3F470")]
	[Conditional("DEBUG_BUILD")]
	public static void PLFODACHGFM(in Quaternion JFBPNBNBHOE, string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public GGMPHIFPNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct CCLINJKNNFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity CIPDAEPIOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity DPPABCPODHG;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x36D7FE0", Offset = "0x36D73E0", VA = "0x1836D7FE0")]
	public CCLINJKNNFF(Entity OAOGLFGGBPI, Entity CIPDAEPIOJL, Entity DPPABCPODHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x36D7FA0", Offset = "0x36D73A0", VA = "0x1836D7FA0")]
	public static CCLINJKNNFF LOJIFGBJNLM((Entity entity, Entity oldParent, Entity newParent) GPGJLDIDGOO)
	{
		return default(CCLINJKNNFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x36D7F80", Offset = "0x36D7380", VA = "0x1836D7F80")]
	public void EEEPFIIDMLE(out Entity OAOGLFGGBPI, out Entity CIPDAEPIOJL, out Entity DPPABCPODHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct LMIKKFINNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity OAOGLFGGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity GPFONCECPBK;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x9C8E50", Offset = "0x9C8250", VA = "0x1809C8E50")]
	public LMIKKFINNNK(Entity OAOGLFGGBPI, Entity GPFONCECPBK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x36845A0", Offset = "0x36839A0", VA = "0x1836845A0")]
	public static LMIKKFINNNK LOJIFGBJNLM((Entity entity, Entity parent) GPGJLDIDGOO)
	{
		return default(LMIKKFINNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x3684590", Offset = "0x3683990", VA = "0x183684590")]
	public void EEEPFIIDMLE(out Entity OAOGLFGGBPI, out Entity GPFONCECPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct ADHBFNPAIBJ<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle KJNCDAGJAPF;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool LPEEJAPCPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x33D68F0", Offset = "0x33D5CF0", VA = "0x1833D68F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x33D6930", Offset = "0x33D5D30", VA = "0x1833D6930")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x33D6830", Offset = "0x33D5C30", VA = "0x1833D6830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x33D69D0", Offset = "0x33D5DD0", VA = "0x1833D69D0")]
	public ADHBFNPAIBJ(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x33D6900", Offset = "0x33D5D00", VA = "0x1833D6900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum EJJOLCFCCMH
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct KIHDBJFDLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public EJJOLCFCCMH MGPNMJKAHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int BBOJBAGCOAP;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
	public KIHDBJFDLNG(EJJOLCFCCMH MGPNMJKAHOK, int BBOJBAGCOAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x17167E0", Offset = "0x1715BE0", VA = "0x1817167E0")]
	public static KIHDBJFDLNG LOJIFGBJNLM((EJJOLCFCCMH eventType, int eventIndex) BIAIPPDLOMD)
	{
		return default(KIHDBJFDLNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D920", Offset = "0x3A4CD20", VA = "0x183A4D920")]
	public void EEEPFIIDMLE(out EJJOLCFCCMH MGPNMJKAHOK, out int BBOJBAGCOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[LOJIIDJFKAI(typeof(CCINBDMJAOA), new string[] { })]
public sealed class IPENIOJBPMG : CCINBDMJAOA, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private DPHIHEMGLPB JIHJABJGCOM;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x3A47C30", Offset = "0x3A47030", VA = "0x183A47C30", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x3A47B90", Offset = "0x3A46F90", VA = "0x183A47B90")]
	public bool APHFDLGPJFP(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public IPENIOJBPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x3A47B90", Offset = "0x3A46F90", VA = "0x183A47B90", Slot = "4")]
	private bool MLFDMKJKJKC(in float3 KEAOCNJGPED, in float3 HHOIMIMHDMP, float KMAOMDJLDEN, Allocator OPBLDCCKGEG, out NativeArray<Entity> GNGEEFEGDCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(MENAGEAHGAA))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class ACJIFFHBFME : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x36CEF60", Offset = "0x36CE360", VA = "0x1836CEF60", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public ACJIFFHBFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(FOGAEHKMBML))]
public sealed class PHOBFOPIEAM : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x36983C0", Offset = "0x36977C0", VA = "0x1836983C0", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public PHOBFOPIEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[OEMDBJIOCGA]
[UpdateInGroup(typeof(BKFNKEDABJH))]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
internal sealed class EOOEMEAHNPN : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x3A35C90", Offset = "0x3A35090", VA = "0x183A35C90", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public EOOEMEAHNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class NDLCLJMPPBJ : LDDGDFHPCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public NDLCLJMPPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[OEMDBJIOCGA]
[ELANPKCEIEO(JHCKAKNDFFP.LoadInstance)]
[UpdateInGroup(typeof(OODOIKMOLLK))]
internal sealed class MGBLANLDNCG : LINMPAMPHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x3685170", Offset = "0x3684570", VA = "0x183685170", Slot = "16")]
	protected override ComponentSystemBase OFJPBMMHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x36833D0", Offset = "0x36827D0", VA = "0x1836833D0")]
	public MGBLANLDNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[DFPBKKCJHKF(typeof(AuthoredLocalPoseData))]
public sealed class BGDEJOJJHND : KNEHBPMPLBN
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x36D5210", Offset = "0x36D4610", VA = "0x1836D5210", Slot = "8")]
	protected override bool NKCHLENEANC(ReadOnlySpan<AuthoredLocalPoseData> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x36D5150", Offset = "0x36D4550", VA = "0x1836D5150", Slot = "9")]
	protected override bool DKHHDDPIABM(int FLPPPNDNNNB, Span<AuthoredLocalPoseData> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x36D5290", Offset = "0x36D4690", VA = "0x1836D5290")]
	public BGDEJOJJHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[DFPBKKCJHKF(typeof(LocalPoseData))]
public sealed class LDFIPDMHCDN : MJJIGOLHCHL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x3682350", Offset = "0x3681750", VA = "0x183682350", Slot = "8")]
	protected override bool NKCHLENEANC(ReadOnlySpan<LocalPoseData> HIMJHOIKJJP, CEADEEFJIGK CIEABJMCJGJ, out ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x3682290", Offset = "0x3681690", VA = "0x183682290", Slot = "9")]
	protected override bool DKHHDDPIABM(int FLPPPNDNNNB, Span<LocalPoseData> HIMJHOIKJJP, in ReadOnlySpan<byte> EJAHCFFDNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x36823D0", Offset = "0x36817D0", VA = "0x1836823D0")]
	public LDFIPDMHCDN()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x37BFA90", Offset = "0x37BEE90", VA = "0x1837BFA90", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x37C0A30", Offset = "0x37BFE30", VA = "0x1837C0A30", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x3A339C0", Offset = "0x3A32DC0", VA = "0x183A339C0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3A33AD0", Offset = "0x3A32ED0", VA = "0x183A33AD0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
