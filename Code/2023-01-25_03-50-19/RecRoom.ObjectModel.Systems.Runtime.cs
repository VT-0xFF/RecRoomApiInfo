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
public sealed class EDGCLEAPMBI<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class FJMJOPOGKEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::EDGCLEAPMBI<T> LCFDGIBILKF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] HMAIPIOAODJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public FJMJOPOGKEO(global::EDGCLEAPMBI<T> LCFDGIBILKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class MCGKIGJIFCO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::EDGCLEAPMBI<T> <>4__this;

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
		public MCGKIGJIFCO(int <>1__state)
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
	private const int JFIEDLIIFIO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> BOIMJBIIDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int EOHIPFFJLNE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T PGMGPNCDKFC
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
	private bool HEIHABBDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FAOIIJHGJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool HEGEJELENFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AMLADJJCJHM
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
	public int BCBDBMHFMFJ
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
	public EDGCLEAPMBI(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public EDGCLEAPMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void HAMDIHHFDGH(int NPDGHPHAKDK, T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void CCGFPBPKEDH(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] CCDPKGMDNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void NJPCEECMDNG(NativeArray<T> DBOPJMNFJMA, int MNHDAEDPKMK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::EDGCLEAPMBI<>.MCGKIGJIFCO))]
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
	public int FIGLOCELEJH(T LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool FAHLDBEBGON(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void NNDNJKKGDAN(int ADOCMPMAEMN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void IDOALOENBNH(int ADOCMPMAEMN, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void BPMKDPOGELE(int ADOCMPMAEMN, int PNKNABOKANH, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int GGCCAPMIELN(int NPDGHPHAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T APPLJIKOCFH(int NPDGHPHAKDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void EKMKMGLAEED(int NPDGHPHAKDK, T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void FPBBDELCBGP(int NPDGHPHAKDK, T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void NHDINMCCLDD(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int APFEONGMHDM(int DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int PBBCFFFIKLI(int DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void IPLLDGDLOLK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void DFMBFDIPKHI(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T FFIJMHCOLND()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T DEAKANOELKD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void GIBHMHDNAMM(int NPDGHPHAKDK, IReadOnlyCollection<T> GLNLHJNNDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void EAMCHPCELFG(int NPDGHPHAKDK, int INAOINNBPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void EIEGOEBOMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void GNDACMOONOL(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void AEDPCDMLLIL(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void KLGOEMEOLCH(int PNKNABOKANH, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T CGEDDJODLKK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T CLGFLCCLAOK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[HFKGOIIGIAJ]
public static class DENEAILGKBG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A79E30", Offset = "0x2A78E30", VA = "0x182A79E30")]
	static DENEAILGKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25A9350", Offset = "0x25A8350", VA = "0x1825A9350")]
	public static void HIJELFNCJBL<T>(T PPLEFHADAKM, ref T KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A79BD0", Offset = "0x2A78BD0", VA = "0x182A79BD0")]
	public static void HIJELFNCJBL(FixedString32 PPLEFHADAKM, ref string KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B90", Offset = "0x2A78B90", VA = "0x182A79B90")]
	public static void HIJELFNCJBL(string PPLEFHADAKM, ref FixedString32 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CA0", Offset = "0x2A78CA0", VA = "0x182A79CA0")]
	public static void HIJELFNCJBL(FixedString64 PPLEFHADAKM, ref string KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A79DD0", Offset = "0x2A78DD0", VA = "0x182A79DD0")]
	public static void HIJELFNCJBL(string PPLEFHADAKM, ref FixedString64 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D00", Offset = "0x2A78D00", VA = "0x182A79D00")]
	public static void HIJELFNCJBL(ONJOGGKGEFN PPLEFHADAKM, ref Vector3 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D30", Offset = "0x2A78D30", VA = "0x182A79D30")]
	public static void HIJELFNCJBL(Vector3 PPLEFHADAKM, ref ONJOGGKGEFN KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CD0", Offset = "0x2A78CD0", VA = "0x182A79CD0")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref Vector4 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B20", Offset = "0x2A78B20", VA = "0x182A79B20")]
	public static void HIJELFNCJBL(Vector4 PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CD0", Offset = "0x2A78CD0", VA = "0x182A79CD0")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref Quaternion KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B20", Offset = "0x2A78B20", VA = "0x182A79B20")]
	public static void HIJELFNCJBL(Quaternion PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A79C70", Offset = "0x2A78C70", VA = "0x182A79C70")]
	public static void HIJELFNCJBL(ONJOGGKGEFN PPLEFHADAKM, ref float3 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D30", Offset = "0x2A78D30", VA = "0x182A79D30")]
	public static void HIJELFNCJBL(float3 PPLEFHADAKM, ref ONJOGGKGEFN KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AE0", Offset = "0x2A78AE0", VA = "0x182A79AE0")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref float4 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B20", Offset = "0x2A78B20", VA = "0x182A79B20")]
	public static void HIJELFNCJBL(float4 PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AE0", Offset = "0x2A78AE0", VA = "0x182A79AE0")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref quaternion KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A79C00", Offset = "0x2A78C00", VA = "0x182A79C00")]
	public static void HIJELFNCJBL(quaternion PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D90", Offset = "0x2A78D90", VA = "0x182A79D90")]
	public static void HIJELFNCJBL(Entity PPLEFHADAKM, ref AHHJJFHMNFO KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AC0", Offset = "0x2A78AC0", VA = "0x182A79AC0")]
	public static void HIJELFNCJBL(AHHJJFHMNFO PPLEFHADAKM, ref Entity KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BLFKHCHIGFF]
public class HNNECGFCPKB : ComponentSystem, COMOMFINKHP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OKKPKCPMOFL OPHCKCDGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OGAFJLECHAO JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C01C0", Offset = "0x6BF1C0", VA = "0x1806C01C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C62D80", Offset = "0x2C61D80", VA = "0x182C62D80", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public HNNECGFCPKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(EJJAHMJHKIF))]
internal class HFJJPBGKAKF : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C62B40", Offset = "0x2C61B40", VA = "0x182C62B40", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C62AC0", Offset = "0x2C61AC0", VA = "0x182C62AC0")]
	[Preserve]
	private void EBNCNNGHCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public HFJJPBGKAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(EJJAHMJHKIF))]
internal class CADDIMFPIJI : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C130", Offset = "0x2A6B130", VA = "0x182A6C130", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public CADDIMFPIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29799B0", Offset = "0x29789B0", VA = "0x1829799B0")]
		public static ObjectModelConfigAsset JKDLFHIKAAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[LMNMHFHDONH(IPKPBIMLPOB.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int KKELJKMFEKL = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FBNJDMKEPCN KKLHLPEDHHE;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4147100", Offset = "0x4146100", VA = "0x184147100")]
			public static AIELFMMICMN DNNHCJHDEJH(int CEONKDFAFMI)
			{
				return default(AIELFMMICMN);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x41474F0", Offset = "0x41464F0", VA = "0x1841474F0")]
			private static void ICCGLAAIPLH(PMFFIMLMCEJ EKIBDFHDPDI, PMFFIMLMCEJ HIFCLAGDMJN, AIELFMMICMN CDEOFEMHEEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4147680", Offset = "0x4146680", VA = "0x184147680")]
			public static int JABNLOEPLBE(GameObject NCAOMIEGHPA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4147850", Offset = "0x4146850", VA = "0x184147850")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void MDMHBLMELPG(PMFFIMLMCEJ GMOMNBJDADO, int CEONKDFAFMI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static GBDCKFPNAEP FOIOPKEONKP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static DOKNELGMFJP BPEDINOHFJC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static GBDCKFPNAEP JMIIMIBHIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x297ADD0", Offset = "0x2979DD0", VA = "0x18297ADD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x297ABA0", Offset = "0x2979BA0", VA = "0x18297ABA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DOKNELGMFJP KICJEKGPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x297B140", Offset = "0x297A140", VA = "0x18297B140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2979CA0", Offset = "0x2978CA0", VA = "0x182979CA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool NGODNGEHGOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x297B2C0", Offset = "0x297A2C0", VA = "0x18297B2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static OKKPKCPMOFL OPHCKCDGIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x297A900", Offset = "0x2979900", VA = "0x18297A900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OGAFJLECHAO JCLAJNCOHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x297AF60", Offset = "0x2979F60", VA = "0x18297AF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static KHAPNLPCPDI ELGLAEPGDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x297A880", Offset = "0x2979880", VA = "0x18297A880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LHMGIFBKNDN NBDKJPAKGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x297AFE0", Offset = "0x2979FE0", VA = "0x18297AFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static JEAKCMCJOBO CEJNFPFMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2979C20", Offset = "0x2978C20", VA = "0x182979C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static BCIOKJKBEBJ NJNIFJHCMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x297AB20", Offset = "0x2979B20", VA = "0x18297AB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool MMADCFJFMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2979B40", Offset = "0x2978B40", VA = "0x182979B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LFILGIMDCKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x297A180", Offset = "0x2979180", VA = "0x18297A180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool CFEFJCFDHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x297A120", Offset = "0x2979120", VA = "0x18297A120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x297AC80", Offset = "0x2979C80", VA = "0x18297AC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool FOBIIHPKIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x297A620", Offset = "0x2979620", VA = "0x18297A620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x297B260", Offset = "0x297A260", VA = "0x18297B260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action NGFIHHEOKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x297A680", Offset = "0x2979680", VA = "0x18297A680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x297A780", Offset = "0x2979780", VA = "0x18297A780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2979A50", Offset = "0x2978A50", VA = "0x182979A50")]
		public static PMFFIMLMCEJ ABIIJDLPNOE(GameObject NCAOMIEGHPA)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x297AAC0", Offset = "0x2979AC0", VA = "0x18297AAC0")]
		public static bool JAJAMJGEIFE(ByteString GEGIPEOHNBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x297A9A0", Offset = "0x29799A0", VA = "0x18297A9A0")]
		public static BDCNBKPMJEP IAEPEIJPHOB(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x297B420", Offset = "0x297A420", VA = "0x18297B420")]
		public static (ByteString, IDisposable) PNKNJNLKBEB()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x297A4F0", Offset = "0x29794F0", VA = "0x18297A4F0")]
		public static (ByteString, IDisposable) FANAIAHMGAM(IEnumerable<PMFFIMLMCEJ> FLOFPLIMDAC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x297AE30", Offset = "0x2979E30", VA = "0x18297AE30")]
		public static bool MDFKHJICIGG(GameObject NCAOMIEGHPA, out AIELFMMICMN CDEOFEMHEEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x297ACE0", Offset = "0x2979CE0", VA = "0x18297ACE0")]
		public static bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2979F20", Offset = "0x2978F20", VA = "0x182979F20")]
		public static void CFMJHACGJMJ(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x297A370", Offset = "0x2979370", VA = "0x18297A370")]
		public static Task ELFFODJEJEP(bool ILHPJDCALOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x297B060", Offset = "0x297A060", VA = "0x18297B060")]
		private static DOKNELGMFJP OFJBMFHLPIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x297A000", Offset = "0x2979000", VA = "0x18297A000")]
		private static bool DHGBMNDPBIP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[LMNMHFHDONH(IPKPBIMLPOB.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x297FE30", Offset = "0x297EE30", VA = "0x18297FE30")]
		public static bool LOGHBGHMEHF(GEINEDFCGEN DDJOCHKBBBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x29800E0", Offset = "0x297F0E0", VA = "0x1829800E0")]
		public static GEINEDFCGEN MNFGPLMIANE(GameObject NCAOMIEGHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x297FEE0", Offset = "0x297EEE0", VA = "0x18297FEE0")]
		public static GEINEDFCGEN MNFGPLMIANE(GameObject NCAOMIEGHPA, AIELFMMICMN CDEOFEMHEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x297FA40", Offset = "0x297EA40", VA = "0x18297FA40")]
		public static bool AFDHKMDJIPF(GameObject JLMCLCAPEFE, string LALNMBEBNKC, bool ANJHJIPLJFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x297FB40", Offset = "0x297EB40", VA = "0x18297FB40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void GGNMLPCOMIH(GameObject JLMCLCAPEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x297FD40", Offset = "0x297ED40", VA = "0x18297FD40")]
		[CompilerGenerated]
		internal static string HEFOBKPONPJ((GameObject go, string prefabName) IJPNBHGIPKF)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, HKMNLJGGALD
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool ANGKCDCBMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PMFFIMLMCEJ KCKCDBCKCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(PMFFIMLMCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2A7DDB0", Offset = "0x2A7CDB0", VA = "0x182A7DDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[LMNMHFHDONH(IPKPBIMLPOB.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GEINEDFCGEN, HKMNLJGGALD
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string NAKBGPCOJBG = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private GDFIOEANNKI IDIIBDOHICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PMFFIMLMCEJ ALJACNMOIMH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PMFFIMLMCEJ KCKCDBCKCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2A82960", Offset = "0x2A81960", VA = "0x182A82960", Slot = "15")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BDCNBKPMJEP HGBOMLOHJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2A82A10", Offset = "0x2A81A10", VA = "0x182A82A10", Slot = "6")]
			get
			{
				return default(BDCNBKPMJEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ANGKCDCBMGA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2A82950", Offset = "0x2A81950", VA = "0x182A82950", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public GDFIOEANNKI NPJAAKCIGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x959010", Offset = "0x958010", VA = "0x180959010", Slot = "7")]
			get
			{
				return default(GDFIOEANNKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OGAFJLECHAO JCLAJNCOHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2A821E0", Offset = "0x2A811E0", VA = "0x182A821E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private HJBNADOIEKJ JPAPBFKHHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2A81E10", Offset = "0x2A80E10", VA = "0x182A81E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool DMNFMOCPLAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x738170", Offset = "0x737170", VA = "0x180738170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> CPOEFFHHJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2A82810", Offset = "0x2A81810", VA = "0x182A82810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2A82A40", Offset = "0x2A81A40", VA = "0x182A82A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GEINEDFCGEN> OCKAAJFFADD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2A828B0", Offset = "0x2A818B0", VA = "0x182A828B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2A82AE0", Offset = "0x2A81AE0", VA = "0x182A82AE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2A81C30", Offset = "0x2A80C30", VA = "0x182A81C30")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A82670", Offset = "0x2A81670", VA = "0x182A82670", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2A82320", Offset = "0x2A81320", VA = "0x182A82320", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2A825E0", Offset = "0x2A815E0", VA = "0x182A825E0", Slot = "10")]
		public void OnEmbody(JLJEDKKMHDF GLPDAIBKGJO, PMFFIMLMCEJ ALJACNMOIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2A82660", Offset = "0x2A81660", VA = "0x182A82660", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A823D0", Offset = "0x2A813D0", VA = "0x182A823D0", Slot = "12")]
		public void OnDisembody(bool KMJJKAFNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A81F00", Offset = "0x2A80F00", VA = "0x182A81F00")]
		private void HKEFAPHGKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A81E70", Offset = "0x2A80E70", VA = "0x182A81E70")]
		private void EOEAAIEBGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A82000", Offset = "0x2A81000", VA = "0x182A82000")]
		private void JFGJEPFBPOK(bool GKIJPPGHEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2A822C0", Offset = "0x2A812C0", VA = "0x182A822C0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xEFAD90", Offset = "0xEF9D90", VA = "0x180EFAD90", Slot = "9")]
		private GameObject FBMCDIIOPHH()
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
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[LMNMHFHDONH(IPKPBIMLPOB.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override PEMKGMKGDAH MJKHJAHDMHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x298A610", Offset = "0x2989610", VA = "0x18298A610", Slot = "6")]
			get
			{
				return default(PEMKGMKGDAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x298A5B0", Offset = "0x29895B0", VA = "0x18298A5B0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[LMNMHFHDONH(IPKPBIMLPOB.Registration)]
	public class TransformEntity : MonoBehaviour, HKMNLJGGALD
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private PEMKGMKGDAH prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private PMFFIMLMCEJ GMOMNBJDADO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual PEMKGMKGDAH MJKHJAHDMHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0", Slot = "6")]
			get
			{
				return default(PEMKGMKGDAH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x722410", Offset = "0x721410", VA = "0x180722410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PMFFIMLMCEJ KCKCDBCKCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB99180", Offset = "0xB98180", VA = "0x180B99180", Slot = "5")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ANGKCDCBMGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F7EA0", Offset = "0x7F6EA0", VA = "0x1807F7EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity HDJJNJMCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal JEAKCMCJOBO CEJNFPFMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal HJBNADOIEKJ FMENJHJIFDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DD60", Offset = "0x2B0CD60", VA = "0x182B0DD60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DCB0", Offset = "0x2B0CCB0", VA = "0x182B0DCB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDD0", Offset = "0x2B0CDD0", VA = "0x182B0DDD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DEC0", Offset = "0x2B0CEC0", VA = "0x182B0DEC0")]
		internal void NAGCBALDEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DCC0", Offset = "0x2B0CCC0", VA = "0x182B0DCC0")]
		private bool CEFAPIMKAFP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E1D0", Offset = "0x2B0D1D0", VA = "0x182B0E1D0")]
		private void NIKCFFCGDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDD0", Offset = "0x2B0CDD0", VA = "0x182B0DDD0")]
		internal void MCFEKKLCLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E200", Offset = "0x2B0D200", VA = "0x182B0E200")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2E0", Offset = "0x2B0D2E0", VA = "0x182B0E2E0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[EHMOCHPPOLA(typeof(OBLBCABGFFH))]
[DEJAKMDKDPE(typeof(DOKNELGMFJP), new string[] { })]
public class GKNHEGMBMLM : KOKMJLFFLIC, DDKHKAIOLNH, DOKNELGMFJP, BCEBHKLAAOO, OBLBCABGFFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HEGPOCOMKLM GNDGFHCLBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OGAFJLECHAO GNCNHHEOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MABCHLFNALK AFNOHBIAEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HMOKJIFMIAI CDBGKLIMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C90", Offset = "0x8E6C90", VA = "0x1808E7C90", Slot = "19")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HEGPOCOMKLM OPHCKCDGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ALAPBINNPIH JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OGAFJLECHAO JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F2E0", Offset = "0x2C5E2E0", VA = "0x182C5F2E0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EF60", Offset = "0x2C5DF60", VA = "0x182C5EF60", Slot = "20")]
	public void JPFKMOKBFIC(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF90", Offset = "0x7ADF90", VA = "0x1807AEF90")]
	private void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F200", Offset = "0x2C5E200", VA = "0x182C5F200")]
	private void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EBF0", Offset = "0x2C5DBF0", VA = "0x182C5EBF0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F1C0", Offset = "0x2C5E1C0", VA = "0x182C5F1C0", Slot = "10")]
	public void MLBHFNLKEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void AIAJFPGBKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C5ECA0", Offset = "0x2C5DCA0", VA = "0x182C5ECA0", Slot = "5")]
	public void EKPKAOOLNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EC50", Offset = "0x2C5DC50", VA = "0x182C5EC50", Slot = "6")]
	public void EBDFPIANNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EEF0", Offset = "0x2C5DEF0", VA = "0x182C5EEF0", Slot = "7")]
	public void JAFDOAPKFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F070", Offset = "0x2C5E070", VA = "0x182C5F070", Slot = "8")]
	public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EE80", Offset = "0x2C5DE80", VA = "0x182C5EE80", Slot = "9")]
	public void IJMNPCGJOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F150", Offset = "0x2C5E150", VA = "0x182C5F150", Slot = "11")]
	public void LEFINFPNLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5ED10", Offset = "0x2C5DD10", VA = "0x182C5ED10", Slot = "12")]
	public void GIAFFOHOMBD(bool EDJPCLPLIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F2B0", Offset = "0x2C5E2B0", VA = "0x182C5F2B0")]
	private void OHOLADFCMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F2F0", Offset = "0x2C5E2F0", VA = "0x182C5F2F0", Slot = "13")]
	public ByteString PNKNJNLKBEB(out IDisposable MLBIKCLFEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EAC0", Offset = "0x2C5DAC0", VA = "0x182C5EAC0", Slot = "14")]
	public void CJKIJAOEIBM(ByteString FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C5ED90", Offset = "0x2C5DD90", VA = "0x182C5ED90")]
	public static GKNHEGMBMLM HJNGNBALKKN(HEGPOCOMKLM GNDGFHCLBLF, NDAGMAFOAIH DNPJACNCEDM = NDAGMAFOAIH.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void BOMFCMMLBHD(HEGPOCOMKLM GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void JGCCGOFGOIO(HEGPOCOMKLM GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GKNHEGMBMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EGCOOEMKJNC
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E8B0", Offset = "0x2A7D8B0", VA = "0x182A7E8B0")]
	public static BDCNBKPMJEP DDBABLLMGCD(this DOKNELGMFJP BPEDINOHFJC, AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
	{
		return default(BDCNBKPMJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E9F0", Offset = "0x2A7D9F0", VA = "0x182A7E9F0")]
	public static OEFHHNLJGLJ EPCCFBBJKBB(this DOKNELGMFJP BPEDINOHFJC)
	{
		return default(OEFHHNLJGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E5B0", Offset = "0x2A7D5B0", VA = "0x182A7E5B0")]
	public static PMFFIMLMCEJ ABIIJDLPNOE(this DOKNELGMFJP BPEDINOHFJC, Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E660", Offset = "0x2A7D660", VA = "0x182A7E660")]
	public static PMFFIMLMCEJ ABIIJDLPNOE(this DOKNELGMFJP BPEDINOHFJC, AIELFMMICMN CDEOFEMHEEC)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E790", Offset = "0x2A7D790", VA = "0x182A7E790")]
	public static AIELFMMICMN CIDLEEFEFNC(this DOKNELGMFJP BPEDINOHFJC, PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(AIELFMMICMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum NDAGMAFOAIH
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
public class NCADOIFIPPP<T> : global::ECNMAPAIOOE<T>, global::DJFCMGPMMKP<AIELFMMICMN, T>, global::EPFNEMCEMCP<AIELFMMICMN>, NDPPHEAPNHN, IDisposable, FOINMHEHJED where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::EPFNEMCEMCP<Entity> FJONJLMIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate HNKFMGGLPLH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2398C80", Offset = "0x2397C80", VA = "0x182398C80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2398C20", Offset = "0x2397C20", VA = "0x182398C20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KANENNLDGEA KHDANJBAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2399AE0", Offset = "0x2398AE0", VA = "0x182399AE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DJCHPEIKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2398F90", Offset = "0x2397F90", VA = "0x182398F90", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DFEABAJEDJB EPCEMKIEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2399CA0", Offset = "0x2398CA0", VA = "0x182399CA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2398BF0", Offset = "0x2397BF0", VA = "0x182398BF0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x239A000", Offset = "0x2399000", VA = "0x18239A000", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::DGJILFKFHNF<AIELFMMICMN> NGFIHHEOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x23991E0", Offset = "0x23981E0", VA = "0x1823991E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2399290", Offset = "0x2398290", VA = "0x182399290", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x239A180", Offset = "0x2399180", VA = "0x18239A180")]
	public NCADOIFIPPP(global::EPFNEMCEMCP<Entity> FJONJLMIBBO, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2399350", Offset = "0x2398350", VA = "0x182399350")]
	private Entity GNCNGCOCOBN(AIELFMMICMN CDEOFEMHEEC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2399340", Offset = "0x2398340", VA = "0x182399340")]
	private AIELFMMICMN GNCNGCOCOBN(Entity IEFFOCOBJJI)
	{
		return default(AIELFMMICMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2398570", Offset = "0x2397570", VA = "0x182398570", Slot = "4")]
	public T CIGAFCHFFML(AIELFMMICMN CDEOFEMHEEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2398D30", Offset = "0x2397D30", VA = "0x182398D30")]
	public bool FAFPJPFNCCD(AIELFMMICMN CDEOFEMHEEC, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2398360", Offset = "0x2397360", VA = "0x182398360")]
	public bool BJINBOAHBFJ(AIELFMMICMN CDEOFEMHEEC, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2399BB0", Offset = "0x2398BB0", VA = "0x182399BB0", Slot = "9")]
	public bool LCJCOLBECPG(AIELFMMICMN CDEOFEMHEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2398280", Offset = "0x2397280", VA = "0x182398280", Slot = "26")]
	public object ANODEELHHIF(AIELFMMICMN CDEOFEMHEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2398FE0", Offset = "0x2397FE0", VA = "0x182398FE0")]
	public bool FOFEELJIFLA(AIELFMMICMN CDEOFEMHEEC, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2398500", Offset = "0x2397500", VA = "0x182398500")]
	public void CIGAFCHFFML(AIELFMMICMN CDEOFEMHEEC, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2398EE0", Offset = "0x2397EE0", VA = "0x182398EE0")]
	public bool FAFPJPFNCCD(AIELFMMICMN CDEOFEMHEEC, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x23982E0", Offset = "0x23972E0", VA = "0x1823982E0")]
	public bool BJINBOAHBFJ(AIELFMMICMN CDEOFEMHEEC, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x23980E0", Offset = "0x23970E0", VA = "0x1823980E0", Slot = "22")]
	public void ALPKNKNFCBE(LHLKDMMNFKH BAHONECJAGF, [Optional] object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2398110", Offset = "0x2397110", VA = "0x182398110", Slot = "15")]
	public void ALPKNKNFCBE(AIELFMMICMN PIIJMEAKDGO, BMEAGCNBNJP BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2399F40", Offset = "0x2398F40", VA = "0x182399F40", Slot = "14")]
	public bool OHCGLANLMCK(AIELFMMICMN KCFALBDMKBF, AIELFMMICMN PPLEFHADAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EF10", Offset = "0x1E6DF10", VA = "0x181E6EF10", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x239A0E0", Offset = "0x23990E0", VA = "0x18239A0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2399B60", Offset = "0x2398B60", VA = "0x182399B60")]
	public string KMKNAAEDLGP(in PEKIEJLMCEO HDEPGCNDBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x23998B0", Offset = "0x23988B0", VA = "0x1823998B0")]
	private void IALIFCGOKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2399CF0", Offset = "0x2398CF0", VA = "0x182399CF0")]
	private void NDLAAEKABBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2399480", Offset = "0x2398480", VA = "0x182399480")]
	private void HMFLJFGFPKE(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x239A040", Offset = "0x2399040", VA = "0x18239A040")]
	private void PMBMCHAFCDF(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2398850", Offset = "0x2397850", VA = "0x182398850")]
	[Conditional("DEBUG_BUILD")]
	private static void CNDICPLCPDE(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC, string AOKAOIOMMBG, string MKOJBJLKAFM, [CallerMemberName] string DEEBFFICGIP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2398F60", Offset = "0x2397F60", VA = "0x182398F60", Slot = "5")]
	private bool FHBBNBOOGDJ(AIELFMMICMN PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2399420", Offset = "0x2398420", VA = "0x182399420", Slot = "6")]
	private bool GPCDJOCMNED(AIELFMMICMN PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x23980B0", Offset = "0x23970B0", VA = "0x1823980B0", Slot = "10")]
	private bool AGJPHMDNIIM(AIELFMMICMN PIIJMEAKDGO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2398BC0", Offset = "0x2397BC0", VA = "0x182398BC0", Slot = "11")]
	private void DGEBNGPLEGM(AIELFMMICMN PIIJMEAKDGO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2399450", Offset = "0x2398450", VA = "0x182399450", Slot = "12")]
	private bool HKBAJPJHGBH(AIELFMMICMN PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2399B30", Offset = "0x2398B30", VA = "0x182399B30", Slot = "13")]
	private bool KBFFOGLBOOG(AIELFMMICMN PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2399F10", Offset = "0x2398F10", VA = "0x182399F10", Slot = "16")]
	private string NGNLBFBMEHC(in PEKIEJLMCEO DFEOJBAFBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class GEBDEPLDOED<T> : global::BBJCJNAHHAJ<T>, global::DJFCMGPMMKP<PMFFIMLMCEJ, T>, global::EPFNEMCEMCP<PMFFIMLMCEJ>, NDPPHEAPNHN, IDisposable, NOLDFLLDJKB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::EPFNEMCEMCP<Entity> FJONJLMIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate HNKFMGGLPLH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string ADMEEJPABPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x39EF860", Offset = "0x39EE860", VA = "0x1839EF860", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x39EF400", Offset = "0x39EE400", VA = "0x1839EF400", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KANENNLDGEA KHDANJBAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x39F9220", Offset = "0x39F8220", VA = "0x1839F9220", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DJCHPEIKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39F16F0", Offset = "0x39F06F0", VA = "0x1839F16F0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DFEABAJEDJB EPCEMKIEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x39F9E40", Offset = "0x39F8E40", VA = "0x1839F9E40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x39EF260", Offset = "0x39EE260", VA = "0x1839EF260", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x39FC0F0", Offset = "0x39FB0F0", VA = "0x1839FC0F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::DGJILFKFHNF<PMFFIMLMCEJ> NGFIHHEOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x39F37A0", Offset = "0x39F27A0", VA = "0x1839F37A0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x39F3B10", Offset = "0x39F2B10", VA = "0x1839F3B10", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x239A180", Offset = "0x2399180", VA = "0x18239A180")]
	public GEBDEPLDOED(global::EPFNEMCEMCP<Entity> FJONJLMIBBO, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x11DE010", Offset = "0x11DD010", VA = "0x1811DE010")]
	private Entity GNCNGCOCOBN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x39F4180", Offset = "0x39F3180", VA = "0x1839F4180")]
	private PMFFIMLMCEJ GNCNGCOCOBN(Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x39EDDF0", Offset = "0x39ECDF0", VA = "0x1839EDDF0", Slot = "4")]
	public T CIGAFCHFFML(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x39F10A0", Offset = "0x39F00A0", VA = "0x1839F10A0")]
	public bool FAFPJPFNCCD(PMFFIMLMCEJ GMOMNBJDADO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x39EB790", Offset = "0x39EA790", VA = "0x1839EB790")]
	public bool BJINBOAHBFJ(PMFFIMLMCEJ GMOMNBJDADO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x39F9A80", Offset = "0x39F8A80", VA = "0x1839F9A80", Slot = "9")]
	public bool LCJCOLBECPG(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39EAF00", Offset = "0x39E9F00", VA = "0x1839EAF00", Slot = "26")]
	public object ANODEELHHIF(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x39F1E10", Offset = "0x39F0E10", VA = "0x1839F1E10")]
	public bool FOFEELJIFLA(PMFFIMLMCEJ GMOMNBJDADO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x39ED380", Offset = "0x39EC380", VA = "0x1839ED380")]
	public void CIGAFCHFFML(PMFFIMLMCEJ GMOMNBJDADO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x39F04C0", Offset = "0x39EF4C0", VA = "0x1839F04C0")]
	public bool FAFPJPFNCCD(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x39EBC10", Offset = "0x39EAC10", VA = "0x1839EBC10")]
	public bool BJINBOAHBFJ(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x23980E0", Offset = "0x23970E0", VA = "0x1823980E0", Slot = "22")]
	public void ALPKNKNFCBE(LHLKDMMNFKH BAHONECJAGF, [Optional] object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x39EA240", Offset = "0x39E9240", VA = "0x1839EA240", Slot = "15")]
	public void ALPKNKNFCBE(PMFFIMLMCEJ PIIJMEAKDGO, BMEAGCNBNJP BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39FBB20", Offset = "0x39FAB20", VA = "0x1839FBB20", Slot = "14")]
	public bool OHCGLANLMCK(PMFFIMLMCEJ KCFALBDMKBF, PMFFIMLMCEJ PPLEFHADAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39F88D0", Offset = "0x39F78D0", VA = "0x1839F88D0")]
	private void IALIFCGOKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39FA380", Offset = "0x39F9380", VA = "0x1839FA380")]
	private void NDLAAEKABBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39F4E70", Offset = "0x39F3E70", VA = "0x1839F4E70")]
	private void HMFLJFGFPKE(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39FC690", Offset = "0x39FB690", VA = "0x1839FC690")]
	private void PMBMCHAFCDF(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39EF310", Offset = "0x39EE310", VA = "0x1839EF310", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x39FD190", Offset = "0x39FC190", VA = "0x1839FD190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2399B60", Offset = "0x2398B60", VA = "0x182399B60")]
	public string KMKNAAEDLGP(in PEKIEJLMCEO HDEPGCNDBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39FBAE0", Offset = "0x39FAAE0", VA = "0x1839FBAE0", Slot = "5")]
	private bool NHPIDCHICEI(PMFFIMLMCEJ PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x39F4140", Offset = "0x39F3140", VA = "0x1839F4140", Slot = "6")]
	private bool GHAFAEHOHLP(PMFFIMLMCEJ PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25F74E0", Offset = "0x25F64E0", VA = "0x1825F74E0", Slot = "10")]
	private bool GJBEJAIIAPC(PMFFIMLMCEJ PIIJMEAKDGO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x39EF220", Offset = "0x39EE220", VA = "0x1839EF220", Slot = "11")]
	private void CNCDNEGOJAM(PMFFIMLMCEJ PIIJMEAKDGO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x39F8F60", Offset = "0x39F7F60", VA = "0x1839F8F60", Slot = "12")]
	private bool JFEDKMABCOE(PMFFIMLMCEJ PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39FC230", Offset = "0x39FB230", VA = "0x1839FC230", Slot = "13")]
	private bool PLLINFLOODM(PMFFIMLMCEJ PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2399F10", Offset = "0x2398F10", VA = "0x182399F10", Slot = "16")]
	private string DNBEDHDBOFK(in PEKIEJLMCEO DFEOJBAFBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EGLINNINABL : IDisposable, IKONBHPFCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JJGBAABFGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public EGLINNINABL(NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F420", Offset = "0x2A7E420", VA = "0x182A7F420", Slot = "6")]
	public PMFFIMLMCEJ EHCMINANPLD(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F370", Offset = "0x2A7E370", VA = "0x182A7F370", Slot = "7")]
	public Entity EHCMINANPLD(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F380", Offset = "0x2A7E380", VA = "0x182A7F380", Slot = "8")]
	public IEnumerable<PMFFIMLMCEJ> EHCMINANPLD(IEnumerable<PMFFIMLMCEJ> FLOFPLIMDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F310", Offset = "0x2A7E310", VA = "0x182A7F310", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FBNJDMKEPCN FGEJNAJECFG;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int IHOJJFDDALM;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IKONBHPFCLI LINDLPIKMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool HGNGJACENIH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> JJGBAABFGJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2B06390", Offset = "0x2B05390", VA = "0x182B06390")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool NJGPOAGJMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2B06300", Offset = "0x2B05300", VA = "0x182B06300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B064A0", Offset = "0x2B054A0", VA = "0x182B064A0")]
		public static SerializationRemapScope DIJLAOODIFN()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2B06930", Offset = "0x2B05930", VA = "0x182B06930")]
		public SerializationRemapScope(IKONBHPFCLI MABKPGGCPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2B06500", Offset = "0x2B05500", VA = "0x182B06500", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2B06610", Offset = "0x2B05610", VA = "0x182B06610")]
		public static PMFFIMLMCEJ EHCMINANPLD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B06770", Offset = "0x2B05770", VA = "0x182B06770")]
		public static Entity EHCMINANPLD(Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DEJAKMDKDPE(typeof(CEJKFGELEFD), new string[] { "Editor" })]
[LGHOGGGGJFL(KHFGEOAKOKD.Application)]
public sealed class CEJKFGELEFD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void LDDANFOEJFK(AIELFMMICMN ONIGAPOOANN, NGIENACHJHK FILAKGLBGGA, bool KIKMEFEMMOL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void EDBJAGHMFFD(AIELFMMICMN ONIGAPOOANN, bool KIKMEFEMMOL);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void HPGIBFPGDJD(AIELFMMICMN ONIGAPOOANN, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool KIKMEFEMMOL);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LDDANFOEJFK FHLJCPEAKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C3C0", Offset = "0x2A6B3C0", VA = "0x182A6C3C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C540", Offset = "0x2A6B540", VA = "0x182A6C540")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EDBJAGHMFFD ACOFPGPLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C320", Offset = "0x2A6B320", VA = "0x182A6C320")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C5E0", Offset = "0x2A6B5E0", VA = "0x182A6C5E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event HPGIBFPGDJD PPKNPFHAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C280", Offset = "0x2A6B280", VA = "0x182A6C280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C460", Offset = "0x2A6B460", VA = "0x182A6C460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C520", Offset = "0x2A6B520", VA = "0x182A6C520")]
	[Conditional("UNITY_EDITOR")]
	public void JMIILDJFIPJ(AIELFMMICMN ONIGAPOOANN, in NGIENACHJHK FILAKGLBGGA, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C500", Offset = "0x2A6B500", VA = "0x182A6C500")]
	[Conditional("UNITY_EDITOR")]
	public void INBEGHIKINF(AIELFMMICMN ONIGAPOOANN, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C680", Offset = "0x2A6B680", VA = "0x182A6C680")]
	[Conditional("UNITY_EDITOR")]
	public void PLNCAGFGGGM(AIELFMMICMN ONIGAPOOANN, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CEJKFGELEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DEJAKMDKDPE(typeof(FPOMEGCHHAA), new string[] { "Editor" })]
[LGHOGGGGJFL(KHFGEOAKOKD.Application)]
public sealed class FPOMEGCHHAA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void POGFJKNKLMC(AIELFMMICMN CDEOFEMHEEC, NGIENACHJHK FILAKGLBGGA, bool KIKMEFEMMOL);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void FGMJDPMGAAO(AIELFMMICMN CDEOFEMHEEC, bool KIKMEFEMMOL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void IHAODDKEKPO(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool KIKMEFEMMOL, bool JGOFOHJAGKE);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void OOHCIPJKILH(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void EDIBAPFIALG(DCNNCMLGLFN PIIJMEAKDGO, ReadOnlyMemory<byte> BNKBFACGLIM);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event POGFJKNKLMC FHLJCPEAKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B5B0", Offset = "0x2C5A5B0", VA = "0x182C5B5B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BB10", Offset = "0x2C5AB10", VA = "0x182C5BB10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event FGMJDPMGAAO ACOFPGPLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B470", Offset = "0x2C5A470", VA = "0x182C5B470")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BE10", Offset = "0x2C5AE10", VA = "0x182C5BE10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event POGFJKNKLMC OELKPLHBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B7B0", Offset = "0x2C5A7B0", VA = "0x182C5B7B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BCB0", Offset = "0x2C5ACB0", VA = "0x182C5BCB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event FGMJDPMGAAO IHFLOBEIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B650", Offset = "0x2C5A650", VA = "0x182C5B650")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B9D0", Offset = "0x2C5A9D0", VA = "0x182C5B9D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IHAODDKEKPO PPKNPFHAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B3D0", Offset = "0x2C5A3D0", VA = "0x182C5B3D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B910", Offset = "0x2C5A910", VA = "0x182C5B910")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event OOHCIPJKILH CHMIOKINBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BBE0", Offset = "0x2C5ABE0", VA = "0x182C5BBE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BA70", Offset = "0x2C5AA70", VA = "0x182C5BA70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> EGJMBEAPHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B510", Offset = "0x2C5A510", VA = "0x182C5B510")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BEB0", Offset = "0x2C5AEB0", VA = "0x182C5BEB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EDIBAPFIALG CEHPPBCHOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BD50", Offset = "0x2C5AD50", VA = "0x182C5BD50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B850", Offset = "0x2C5A850", VA = "0x182C5B850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BC80", Offset = "0x2C5AC80", VA = "0x182C5BC80")]
	[Conditional("UNITY_EDITOR")]
	public void NAAAFKDCPMN(AIELFMMICMN CDEOFEMHEEC, in NGIENACHJHK FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B8F0", Offset = "0x2C5A8F0", VA = "0x182C5B8F0")]
	[Conditional("UNITY_EDITOR")]
	public void GFKILKGNJKC(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B6F0", Offset = "0x2C5A6F0", VA = "0x182C5B6F0")]
	[Conditional("UNITY_EDITOR")]
	public void DICHEGKLFIB(AIELFMMICMN CDEOFEMHEEC, in NGIENACHJHK FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B9B0", Offset = "0x2C5A9B0", VA = "0x182C5B9B0")]
	[Conditional("UNITY_EDITOR")]
	public void GJMLNELAMDN(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BBB0", Offset = "0x2C5ABB0", VA = "0x182C5BBB0")]
	[Conditional("UNITY_EDITOR")]
	public void KKLCCOHKAMP(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool JGOFOHJAGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BDF0", Offset = "0x2C5ADF0", VA = "0x182C5BDF0")]
	[Conditional("UNITY_EDITOR")]
	public void PBLLBLIFPFE(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B750", Offset = "0x2C5A750", VA = "0x182C5B750")]
	[Conditional("UNITY_EDITOR")]
	public void EBOPHGNBINL(string IADPDEAGFAB, object BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B720", Offset = "0x2C5A720", VA = "0x182C5B720")]
	[Conditional("UNITY_EDITOR")]
	public void DPIFIBLMBCA(DCNNCMLGLFN PIIJMEAKDGO, ReadOnlyMemory<byte> BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FPOMEGCHHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DEJAKMDKDPE(typeof(LHIJLKPPKGL), new string[] { })]
public class MMGMEBFDNOB : LHIJLKPPKGL
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2971220", Offset = "0x2970220", VA = "0x182971220", Slot = "5")]
	public void EPBJAODJOJN(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2971030", Offset = "0x2970030", VA = "0x182971030", Slot = "6")]
	public void BIDPFLOOJBA(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2970F50", Offset = "0x296FF50", VA = "0x182970F50", Slot = "7")]
	public void ALCIKGHCGLD(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2971110", Offset = "0x2970110", VA = "0x182971110", Slot = "4")]
	public IDisposable CPFJBHFKLEJ(object LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MMGMEBFDNOB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DEJAKMDKDPE(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	internal class BulkInstantiateSceneObjectService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string JOMNOHLGNJN = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[GNFGKNINDPI]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[GNFGKNINDPI]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[GNFGKNINDPI]
		private HJBNADOIEKJ AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery MGMKIBLJKFN;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2A6A9D0", Offset = "0x2A699D0", VA = "0x182A6A9D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2A6BE50", Offset = "0x2A6AE50", VA = "0x182A6BE50", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A1A0", Offset = "0x2A691A0", VA = "0x182A6A1A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2A6AA20", Offset = "0x2A69A20", VA = "0x182A6AA20")]
		public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> GBMJHKDDBFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2A6BFD0", Offset = "0x2A6AFD0", VA = "0x182A6BFD0")]
		public static bool OBHKEFHAEPL(JBNHJOMIEDN KJACHHOOFKC, out AIELFMMICMN CDEOFEMHEEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A1B0", Offset = "0x2A691B0", VA = "0x182A6A1B0")]
		private void EHEIDCKMIBG(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, IEnumerable<JBNHJOMIEDN> GBMJHKDDBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A530", Offset = "0x2A69530", VA = "0x182A6A530")]
		private void FDIGGDFNDHN(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ABA0", Offset = "0x2A69BA0", VA = "0x182A6ABA0")]
		private void KFLEJGKKBFO(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, AIELFMMICMN CDEOFEMHEEC, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A6B920", Offset = "0x2A6A920", VA = "0x182A6B920")]
		private void LOBEFKBNABO(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2A6B080", Offset = "0x2A6A080", VA = "0x182A6B080")]
		private void LEPBHHDBIIM(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, List<JBNHJOMIEDN> KKMENDKLKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A800", Offset = "0x2A69800", VA = "0x182A6A800")]
		private NativeList<AIELFMMICMN> FHCNMOJIAIB(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
			return default(NativeList<AIELFMMICMN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A6BC80", Offset = "0x2A6AC80", VA = "0x182A6BC80")]
		private NativeArray<Entity> LOPKLFEOANM(NativeList<AIELFMMICMN> EOJFKEDDOBI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A760", Offset = "0x2A69760", VA = "0x182A6A760")]
		private static void FFPMKODNIDL(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, AIELFMMICMN CDEOFEMHEEC, JBNHJOMIEDN KJACHHOOFKC, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[LGHOGGGGJFL(KHFGEOAKOKD.Application)]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	[DEJAKMDKDPE(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool LCHELPOHLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D650", Offset = "0x2A7C650", VA = "0x182A7D650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D5D0", Offset = "0x2A7C5D0", VA = "0x182A7D5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool JKLJPALPGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D610", Offset = "0x2A7C610", VA = "0x182A7D610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D590", Offset = "0x2A7C590", VA = "0x182A7D590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public void EJEFMDCLGJK(string IADPDEAGFAB, EntityManager MKHPDCKNNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public static void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DEJAKMDKDPE(typeof(MABCHLFNALK), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.Application)]
internal class MABCHLFNALK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x682250", Offset = "0x681250", VA = "0x180682250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x682270", Offset = "0x681270", VA = "0x180682270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool NAFDIKOMKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x77D570", Offset = "0x77C570", VA = "0x18077D570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x77D580", Offset = "0x77C580", VA = "0x18077D580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MABCHLFNALK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[EHMOCHPPOLA(typeof(SerializationService))]
	[DEJAKMDKDPE(typeof(BHIIPBMPCDB), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	internal class SerializationService : BHIIPBMPCDB, IDisposable, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FBNJDMKEPCN JMKJAKDNGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[GNFGKNINDPI]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[GNFGKNINDPI]
		private DBPDOJBMJDO PGEAEBLBOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[GNFGKNINDPI]
		private MABCHLFNALK AFNOHBIAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private MACMNODFHDH BEDHDIFMIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private JBKANIAMFJC FFKANHLNMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope MLBIKCLFEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? BJHCODJHMEB;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool GPENAPAOCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2B08650", Offset = "0x2B07650", VA = "0x182B08650", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2B071A0", Offset = "0x2B061A0", VA = "0x182B071A0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool GBDHEFPIFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x721CE0", Offset = "0x720CE0", VA = "0x180721CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x722490", Offset = "0x721490", VA = "0x180722490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JBKANIAMFJC HJLBIIAFNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B085B0", Offset = "0x2B075B0", VA = "0x182B085B0", Slot = "16")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B07250", Offset = "0x2B06250", VA = "0x182B07250", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B07C60", Offset = "0x2B06C60", VA = "0x182B07C60")]
		public static bool JAJAMJGEIFE(ByteString GEGIPEOHNBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6C01C0", Offset = "0x6BF1C0", VA = "0x1806C01C0")]
		public void FCNKMGBIECB(MACMNODFHDH MCDGGGMPFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B08250", Offset = "0x2B07250", VA = "0x182B08250", Slot = "5")]
		public void LGAIOBDOLNF(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2B07540", Offset = "0x2B06540", VA = "0x182B07540", Slot = "6")]
		public Task FMMMFBCFJNA(bool ILHPJDCALOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B08840", Offset = "0x2B07840", VA = "0x182B08840", Slot = "7")]
		public ByteString PNKNJNLKBEB(out IDisposable MLBIKCLFEHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B08660", Offset = "0x2B07660", VA = "0x182B08660", Slot = "19")]
		public ByteString PNKNJNLKBEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B06B90", Offset = "0x2B05B90", VA = "0x182B06B90", Slot = "9")]
		public bool CJKIJAOEIBM(ByteString DFKKPBPDGCI, BBJEKFLIBLK DNPJACNCEDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B06BF0", Offset = "0x2B05BF0", VA = "0x182B06BF0")]
		private bool CLIBGLDCABB(ByteString DFKKPBPDGCI, BBJEKFLIBLK DNPJACNCEDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B069C0", Offset = "0x2B059C0", VA = "0x182B069C0", Slot = "8")]
		public void CDFDDCKFAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B079F0", Offset = "0x2B069F0", VA = "0x182B079F0", Slot = "10")]
		public bool JAFDOAPKFLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B07E10", Offset = "0x2B06E10", VA = "0x182B07E10", Slot = "11")]
		public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B07910", Offset = "0x2B06910", VA = "0x182B07910")]
		public bool ILAPMPCALLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B076E0", Offset = "0x2B066E0", VA = "0x182B076E0", Slot = "12")]
		public bool IJMNPCGJOCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B06F10", Offset = "0x2B05F10", VA = "0x182B06F10")]
		public void CMFFENBBNBN(JBKANIAMFJC.AOCPEIEHKKM.MAEOINGMEMC JOHEPNEHJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B08320", Offset = "0x2B07320", VA = "0x182B08320")]
		private bool LGFGMKDDBMM(ByteString DFKKPBPDGCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B07DC0", Offset = "0x2B06DC0", VA = "0x182B07DC0")]
		private void KDCFJHJPIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B07680", Offset = "0x2B06680", VA = "0x182B07680")]
		private ByteString HBOBKKMJFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B07430", Offset = "0x2B06430", VA = "0x182B07430")]
		private ByteString FBJHGNACJFP(ByteString GEGIPEOHNBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B071B0", Offset = "0x2B061B0", VA = "0x182B071B0")]
		private JBKANIAMFJC.AOCPEIEHKKM.MAEOINGMEMC DBEPPMKAOJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B07D90", Offset = "0x2B06D90", VA = "0x182B07D90")]
		private void JLGNLABEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B08080", Offset = "0x2B07080", VA = "0x182B08080", Slot = "13")]
		public bool LEFINFPNLGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B075D0", Offset = "0x2B065D0", VA = "0x182B075D0", Slot = "14")]
		public void GIAFFOHOMBD(bool EDJPCLPLIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B07260", Offset = "0x2B06260", VA = "0x182B07260")]
		private void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DEJAKMDKDPE(typeof(HBFLPONDKFF), new string[] { })]
[EHMOCHPPOLA(typeof(DBPDOJBMJDO))]
internal class DBPDOJBMJDO : HBFLPONDKFF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action EKPKAOOLNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A79720", Offset = "0x2A78720", VA = "0x182A79720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A794A0", Offset = "0x2A784A0", VA = "0x182A794A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IKONBHPFCLI> CABEPOPPDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A799A0", Offset = "0x2A789A0", VA = "0x182A799A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A79900", Offset = "0x2A78900", VA = "0x182A79900", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action HGINGPBGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A79400", Offset = "0x2A78400", VA = "0x182A79400", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A79630", Offset = "0x2A78630", VA = "0x182A79630", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action PCPIOEBBKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A79590", Offset = "0x2A78590", VA = "0x182A79590", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A797C0", Offset = "0x2A787C0", VA = "0x182A797C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<IKONBHPFCLI> PIIGFJLEOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A79360", Offset = "0x2A78360", VA = "0x182A79360", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A79860", Offset = "0x2A78860", VA = "0x182A79860", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x11D17F0", Offset = "0x11D07F0", VA = "0x1811D17F0")]
	public void CDFDDCKFAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x154C050", Offset = "0x154B050", VA = "0x18154C050")]
	public void IAEIHKKBAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x136A630", Offset = "0x1369630", VA = "0x18136A630")]
	public void LCPINFHPIAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A796D0", Offset = "0x2A786D0", VA = "0x182A796D0")]
	public void HMEAEAJLKAA(IKONBHPFCLI LINDLPIKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A79540", Offset = "0x2A78540", VA = "0x182A79540")]
	public void EJAKHINCGEF(IKONBHPFCLI LINDLPIKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public DBPDOJBMJDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DEJAKMDKDPE(typeof(BCIOKJKBEBJ), new string[] { })]
public class FHJMIJIKNAN : BCIOKJKBEBJ, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents JMOFNBOBEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private AEHDHJJIFOJ COANALBPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService NKDJGKIHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::BBJCJNAHHAJ<PMFFIMLMCEJ> JAGJOAIDNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x685580", Offset = "0x684580", VA = "0x180685580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6855A0", Offset = "0x6845A0", VA = "0x1806855A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C5A930", Offset = "0x2C59930", VA = "0x182C5A930")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1618E50", Offset = "0x1617E50", VA = "0x181618E50", Slot = "14")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AED0", Offset = "0x2C59ED0", VA = "0x182C5AED0", Slot = "15")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A350", Offset = "0x2C59350", VA = "0x182C5A350", Slot = "16")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x154C4C0", Offset = "0x154B4C0", VA = "0x18154C4C0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2977C50", Offset = "0x2976C50", VA = "0x182977C50")]
	private PMFFIMLMCEJ AGBHEPFNNIC(Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5ACB0", Offset = "0x2C59CB0", VA = "0x182C5ACB0", Slot = "4")]
	public PMFFIMLMCEJ LGNFHDEKAND(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A130", Offset = "0x2C59130", VA = "0x182C5A130", Slot = "19")]
	public void BNNIGJAFFAC(ref List<PMFFIMLMCEJ> HCIALCFLHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AD10", Offset = "0x2C59D10", VA = "0x182C5AD10", Slot = "20")]
	public IEnumerable<PMFFIMLMCEJ> LHNLJGEEPBH(PMFFIMLMCEJ GMOMNBJDADO, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A440", Offset = "0x2C59440", VA = "0x182C5A440", Slot = "21")]
	public PMFFIMLMCEJ CCOFDHEFLND(PMFFIMLMCEJ GMOMNBJDADO, int NPDGHPHAKDK)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AA50", Offset = "0x2C59A50", VA = "0x182C5AA50", Slot = "22")]
	public int HHHEJELPEEC(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C59F60", Offset = "0x2C58F60", VA = "0x182C59F60", Slot = "8")]
	public int APKIBECFENN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C5ADE0", Offset = "0x2C59DE0", VA = "0x182C5ADE0", Slot = "9")]
	public CIMNJIOJIIP LILLNBMHGGN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(CIMNJIOJIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A610", Offset = "0x2C59610", VA = "0x182C5A610", Slot = "23")]
	public bool DCCCGHJBHLC(PMFFIMLMCEJ GMOMNBJDADO, out CIMNJIOJIIP PPLEFFEADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B000", Offset = "0x2C5A000", VA = "0x182C5B000", Slot = "24")]
	public IEnumerable<PMFFIMLMCEJ> PICEAKMECIB(PMFFIMLMCEJ GMOMNBJDADO, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AB70", Offset = "0x2C59B70", VA = "0x182C5AB70", Slot = "12")]
	public PMFFIMLMCEJ IHGCMJMELMP(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A980", Offset = "0x2C59980", VA = "0x182C5A980", Slot = "13")]
	public bool GOHPGPBBEBL(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB, out PMFFIMLMCEJ OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A7E0", Offset = "0x2C597E0", VA = "0x182C5A7E0", Slot = "5")]
	public PMFFIMLMCEJ EKMEMACGALM(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AFD0", Offset = "0x2C59FD0", VA = "0x182C5AFD0", Slot = "11")]
	public bool ONFDIBDBOKI(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AFA0", Offset = "0x2C59FA0", VA = "0x182C5AFA0", Slot = "25")]
	public bool OIGMHNPAGCC(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ELFIACEEOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A100", Offset = "0x2C59100", VA = "0x182C5A100", Slot = "10")]
	public bool BNNCMPPKFKP(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ BBDPANMBHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A880", Offset = "0x2C59880", VA = "0x182C5A880", Slot = "6")]
	public bool GBLKBIAEIPL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ICMEPOIJCJO, bool NBCBLABIJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AC40", Offset = "0x2C59C40", VA = "0x182C5AC40", Slot = "7")]
	public bool LAPLJEJINGM(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ICMEPOIJCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FHJMIJIKNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(EGFHGGJBAIJ), new string[] { })]
internal class EGFHGGJBAIJ : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[GNFGKNINDPI]
	private OEKGHEEACHJ JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, BBDBBCGEPIJ> KHMNFMFBIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F240", Offset = "0x2A7E240", VA = "0x182A7F240", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EE30", Offset = "0x2A7DE30", VA = "0x182A7EE30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EB10", Offset = "0x2A7DB10", VA = "0x182A7EB10")]
	public BBDBBCGEPIJ CAPHOBNHMEK(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EC10", Offset = "0x2A7DC10", VA = "0x182A7EC10")]
	public BBDBBCGEPIJ CAPHOBNHMEK(OEMFGOLGDMG DLFEJOALJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F0B0", Offset = "0x2A7E0B0", VA = "0x182A7F0B0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F290", Offset = "0x2A7E290", VA = "0x182A7F290")]
	public EGFHGGJBAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class BBDBBCGEPIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<MJPMCDBPLIH> GCANFKEHOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<GGMEAKIAMAM> OFNKHIAKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<MLDEGJAOMMP> AMPKAIHCHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<GGMEAKIAMAM> ABONCKHPPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<MJPMCDBPLIH> BPMJCPPGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000")]
		get
		{
			return default(NativeList<MJPMCDBPLIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<GGMEAKIAMAM> MPNMNBKCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xB99180", Offset = "0xB98180", VA = "0x180B99180")]
		get
		{
			return default(NativeList<GGMEAKIAMAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<MLDEGJAOMMP> KGIBFDKCFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xF5F980", Offset = "0xF5E980", VA = "0x180F5F980")]
		get
		{
			return default(NativeList<MLDEGJAOMMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<GGMEAKIAMAM> JMLIOKDIKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1086940", Offset = "0x1085940", VA = "0x181086940")]
		get
		{
			return default(NativeList<GGMEAKIAMAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle NLBGHIPACEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xF5F680", Offset = "0xF5E680", VA = "0x180F5F680")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xF60080", Offset = "0xF5F080", VA = "0x180F60080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x969290", Offset = "0x968290", VA = "0x180969290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool BMNPHBIFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A68A60", Offset = "0x2A67A60", VA = "0x182A68A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A68F70", Offset = "0x2A67F70", VA = "0x182A68F70")]
	public BBDBBCGEPIJ(Allocator AEPJLHDIHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A689D0", Offset = "0x2A679D0", VA = "0x182A689D0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A68E40", Offset = "0x2A67E40", VA = "0x182A68E40")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A68B10", Offset = "0x2A67B10", VA = "0x182A68B10")]
	public void HMNAIPBHJIK(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK, Entity LCCGHHJFGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DEJAKMDKDPE(typeof(IDPDKEDKHDN), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
public class IDPDKEDKHDN : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[GNFGKNINDPI]
	private SceneService EFOAKEMFNMA;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C66DD0", Offset = "0x2C65DD0", VA = "0x182C66DD0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C66DB0", Offset = "0x2C65DB0", VA = "0x182C66DB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IDPDKEDKHDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class EMDHOEMNJID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint IBMNMLKFNHN;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint EKEKEPBBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x956D30", Offset = "0x955D30", VA = "0x180956D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2A81530", Offset = "0x2A80530", VA = "0x182A81530")]
	public AIELFMMICMN OCMENEAPIJH()
	{
		return default(AIELFMMICMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2A81480", Offset = "0x2A80480", VA = "0x182A81480")]
	public void MHNOIJLIFPD(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xFE7300", Offset = "0xFE6300", VA = "0x180FE7300", Slot = "6")]
	public virtual void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected EMDHOEMNJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(GDKIDCILBBI), new string[] { })]
internal sealed class GDKIDCILBBI : EMDHOEMNJID, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[GNFGKNINDPI]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint IFEILBLHHPO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint EKEKEPBBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x67E010", Offset = "0x67D010", VA = "0x18067E010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D0A0", Offset = "0x2C5C0A0", VA = "0x182C5D0A0", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CFF0", Offset = "0x2C5BFF0", VA = "0x182C5CFF0")]
	private void EKHHDNHJPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D040", Offset = "0x2C5C040", VA = "0x182C5D040", Slot = "6")]
	public override void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public GDKIDCILBBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DEJAKMDKDPE(typeof(NPLLEAPJFIF), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal sealed class NPLLEAPJFIF : EMDHOEMNJID
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint EKEKEPBBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public NPLLEAPJFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(JNPKGPPKFAP), new string[] { })]
internal sealed class JNPKGPPKFAP : MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery HIJGNOKDKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery OOKMDEIKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery ECOGCKJKBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery KMGILDFLGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery CLFBGGMMAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery IIBHFBHCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C240", Offset = "0x2C6B240", VA = "0x182C6C240")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery KDELDNBNNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery IMDCAOPKEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x69F030", Offset = "0x69E030", VA = "0x18069F030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery NIFDIGFNDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x12770C0", Offset = "0x12760C0", VA = "0x1812770C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MJGLCBKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xF5F680", Offset = "0xF5E680", VA = "0x180F5F680")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PIOINGDMMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x13C0280", Offset = "0x13BF280", VA = "0x1813C0280")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery NMJIJAIKENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C320", Offset = "0x2C6B320", VA = "0x182C6C320")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int LGCAFJDIACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C3A0", Offset = "0x2C6B3A0", VA = "0x182C6C3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int LHNLIMDPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C2B0", Offset = "0x2C6B2B0", VA = "0x182C6C2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int CPPHNBAGBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C0C0", Offset = "0x2C6B0C0", VA = "0x182C6C0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int COGEAMAJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C290", Offset = "0x2C6B290", VA = "0x182C6C290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int LGCAFALEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C0A0", Offset = "0x2C6B0A0", VA = "0x182C6C0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int KJCLOAMCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C3C0", Offset = "0x2C6B3C0", VA = "0x182C6C3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C2D0", Offset = "0x2C6B2D0", VA = "0x182C6C2D0", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6BA90", Offset = "0x2C6AA90", VA = "0x182C6BA90", Slot = "6")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6BF30", Offset = "0x2C6AF30", VA = "0x182C6BF30")]
	private EntityQueryDesc COIEDKGPFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C040", Offset = "0x2C6B040", VA = "0x182C6C040", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C0E0", Offset = "0x2C6B0E0", VA = "0x182C6C0E0")]
	public EIPLHIGFIFI GGKGHPIKBBB(PMFFIMLMCEJ ALJACNMOIMH)
	{
		return default(EIPLHIGFIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C190", Offset = "0x2C6B190", VA = "0x182C6C190")]
	public EIPLHIGFIFI GGKGHPIKBBB(Entity IEFFOCOBJJI)
	{
		return default(EIPLHIGFIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6BF90", Offset = "0x2C6AF90", VA = "0x182C6BF90")]
	public PEMKGMKGDAH DOKKMMPFKFK(Entity IEFFOCOBJJI)
	{
		return default(PEMKGMKGDAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C3E0", Offset = "0x2C6B3E0", VA = "0x182C6C3E0")]
	public JNPKGPPKFAP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[LMNMHFHDONH(IPKPBIMLPOB.All)]
	[DEJAKMDKDPE(typeof(JEAKCMCJOBO), new string[] { })]
	public class ObjectService : COMOMFINKHP, JEAKCMCJOBO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly FBNJDMKEPCN OCJLGAJJPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[GNFGKNINDPI]
		private OGAFJLECHAO GNCNHHEOEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[GNFGKNINDPI]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[GNFGKNINDPI]
		private ObjectLifecycleService FHPIBOEMPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[GNFGKNINDPI]
		private ObjectEmbodimentService NKDJGKIHEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[GNFGKNINDPI]
		private ObjectInstantiationService AAPBAEGCALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[GNFGKNINDPI]
		private JNPKGPPKFAP COANALBPMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService LEAPKBHNHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OGAFJLECHAO JCLAJNCOHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int LGCAFJDIACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x297F720", Offset = "0x297E720", VA = "0x18297F720", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LHNLIMDPDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x297EC20", Offset = "0x297DC20", VA = "0x18297EC20", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int CPPHNBAGBJM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x297EA80", Offset = "0x297DA80", VA = "0x18297EA80", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int COGEAMAJCCL
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x297EBB0", Offset = "0x297DBB0", VA = "0x18297EBB0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int LGCAFALEFIH
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x297E480", Offset = "0x297D480", VA = "0x18297E480", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int KJCLOAMCHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x297F9A0", Offset = "0x297E9A0", VA = "0x18297F9A0", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<PMFFIMLMCEJ, PEMKGMKGDAH> FDOEINMOMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x297EAA0", Offset = "0x297DAA0", VA = "0x18297EAA0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x297EEA0", Offset = "0x297DEA0", VA = "0x18297EEA0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PMFFIMLMCEJ> BIOLFFJDBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x297F7E0", Offset = "0x297E7E0", VA = "0x18297F7E0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x297EC40", Offset = "0x297DC40", VA = "0x18297EC40", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x297F490", Offset = "0x297E490", VA = "0x18297F490", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x297E300", Offset = "0x297D300", VA = "0x18297E300", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x297F740", Offset = "0x297E740", VA = "0x18297F740")]
		private void NOLLINAKACP(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x297DC40", Offset = "0x297CC40", VA = "0x18297DC40")]
		private void BPAKJAKMHFA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x297DBB0", Offset = "0x297CBB0", VA = "0x18297DBB0")]
		internal PMFFIMLMCEJ AGBHEPFNNIC(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x297F880", Offset = "0x297E880", VA = "0x18297F880", Slot = "41")]
		public CIMNJIOJIIP OKCIOHKKCDJ()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x297F130", Offset = "0x297E130", VA = "0x18297F130", Slot = "42")]
		public CIMNJIOJIIP LAGCFBPEHLM()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x297E220", Offset = "0x297D220", VA = "0x18297E220", Slot = "43")]
		public CIMNJIOJIIP DIHKJLHNGJD()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x297EB40", Offset = "0x297DB40", VA = "0x18297EB40", Slot = "10")]
		public EIPLHIGFIFI GGKGHPIKBBB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(EIPLHIGFIFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x297E2C0", Offset = "0x297D2C0", VA = "0x18297E2C0", Slot = "11")]
		public PEMKGMKGDAH DOKKMMPFKFK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x297E4A0", Offset = "0x297D4A0", VA = "0x18297E4A0")]
		private CIMNJIOJIIP EMCOOIHDBGP(EntityQuery FBENFNFLPOM)
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x297F1E0", Offset = "0x297E1E0", VA = "0x18297F1E0", Slot = "33")]
		public bool LCJCOLBECPG(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x297F000", Offset = "0x297E000", VA = "0x18297F000", Slot = "29")]
		public void KGNKLNCMPDI(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x297ECE0", Offset = "0x297DCE0", VA = "0x18297ECE0", Slot = "30")]
		public void HJMIDDMHEPE(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x297DCD0", Offset = "0x297CCD0", VA = "0x18297DCD0", Slot = "31")]
		public void CAFIKGIFHPM(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x297DE20", Offset = "0x297CE20", VA = "0x18297DE20", Slot = "22")]
		public BDCNBKPMJEP CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x297DD70", Offset = "0x297CD70", VA = "0x18297DD70", Slot = "23")]
		public BDCNBKPMJEP CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x297ED40", Offset = "0x297DD40", VA = "0x18297ED40", Slot = "24")]
		public BDCNBKPMJEP INDBOJHFAIL(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x297DFF0", Offset = "0x297CFF0", VA = "0x18297DFF0", Slot = "25")]
		public BDCNBKPMJEP DDBABLLMGCD(AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x297DBD0", Offset = "0x297CBD0", VA = "0x18297DBD0", Slot = "44")]
		public BDCNBKPMJEP BOOHNKKNADD(int ALBKKCBBEMK, PEMKGMKGDAH NFNGIKPPKJH, GameObject NCAOMIEGHPA)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x297E550", Offset = "0x297D550", VA = "0x18297E550", Slot = "26")]
		public OEFHHNLJGLJ EPCCFBBJKBB()
		{
			return default(OEFHHNLJGLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x297E690", Offset = "0x297D690", VA = "0x18297E690", Slot = "45")]
		public DAHHMEIBOMD FGEKKLAKOKM(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(DAHHMEIBOMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x297F050", Offset = "0x297E050", VA = "0x18297F050", Slot = "27")]
		public MDHBMIBEBAN KMAEBAOIOFC()
		{
			return default(MDHBMIBEBAN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x297F350", Offset = "0x297E350", VA = "0x18297F350", Slot = "28")]
		public HEMMHNKDMJN MLJMHNFKMOG(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(HEMMHNKDMJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x297F700", Offset = "0x297E700", VA = "0x18297F700", Slot = "12")]
		public void MNFGPLMIANE(AIELFMMICMN CDEOFEMHEEC, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x297E7B0", Offset = "0x297D7B0", VA = "0x18297E7B0", Slot = "13")]
		public BDCNBKPMJEP FJINJLOCNAL(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x297F270", Offset = "0x297E270", VA = "0x18297F270", Slot = "14")]
		public bool MAKGCDLBBBK(PMFFIMLMCEJ GMOMNBJDADO, out GEINEDFCGEN MMPEAFKIOCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x297EBD0", Offset = "0x297DBD0", VA = "0x18297EBD0", Slot = "46")]
		public Transform HCCGAJBGGPD(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x297EE50", Offset = "0x297DE50", VA = "0x18297EE50", Slot = "16")]
		public bool JIACBDMPAMB(PMFFIMLMCEJ GMOMNBJDADO, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x297EFB0", Offset = "0x297DFB0", VA = "0x18297EFB0", Slot = "17")]
		public bool KFLIOAAFEFM(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x297E1C0", Offset = "0x297D1C0", VA = "0x18297E1C0")]
		public bool DHANCBOLGKO(GEINEDFCGEN DFEOJBAFBHE, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x297E1F0", Offset = "0x297D1F0", VA = "0x18297E1F0", Slot = "47")]
		public bool DHANCBOLGKO(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x297E670", Offset = "0x297D670", VA = "0x18297E670", Slot = "48")]
		public void FCMOAONOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x297E8D0", Offset = "0x297D8D0", VA = "0x18297E8D0", Slot = "15")]
		public void FKDNCCMDFFP(GEINEDFCGEN GKCPJCKCENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x297EB70", Offset = "0x297DB70", VA = "0x18297EB70", Slot = "49")]
		public void GKEDFHBNNKA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x297EDD0", Offset = "0x297DDD0", VA = "0x18297EDD0", Slot = "18")]
		public bool JGLLIFJLHAE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x297F920", Offset = "0x297E920", VA = "0x18297F920", Slot = "19")]
		public bool PHJOIGAAGCH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x297DF80", Offset = "0x297CF80", VA = "0x18297DF80", Slot = "50")]
		public bool DBCMAAAEHMC(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x297EF40", Offset = "0x297DF40", VA = "0x18297EF40", Slot = "51")]
		public bool KBKAKBBJBHI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x297E610", Offset = "0x297D610", VA = "0x18297E610", Slot = "32")]
		public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x297DEE0", Offset = "0x297CEE0", VA = "0x18297DEE0", Slot = "21")]
		public AIELFMMICMN CIDLEEFEFNC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(AIELFMMICMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x297DAC0", Offset = "0x297CAC0", VA = "0x18297DAC0", Slot = "20")]
		public PMFFIMLMCEJ ABIIJDLPNOE(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x297F310", Offset = "0x297E310", VA = "0x18297F310")]
		private void MKPHAPMPLFP(PEMKGMKGDAH NFNGIKPPKJH, PMFFIMLMCEJ GMOMNBJDADO, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DEJAKMDKDPE(typeof(HEADBEHLNDI), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal sealed class HEADBEHLNDI : COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService AAPBAEGCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[GNFGKNINDPI]
	private JNPKGPPKFAP COANALBPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2C62A30", Offset = "0x2C61A30", VA = "0x182C62A30", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2C62750", Offset = "0x2C61750", VA = "0x182C62750")]
	public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
	{
		return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2C62850", Offset = "0x2C61850", VA = "0x182C62850")]
	private void KLDGKBFOFAE(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2C61F60", Offset = "0x2C60F60", VA = "0x182C61F60")]
	private void BOMFIHGAMPC(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC, int NFNGIKPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2C61DD0", Offset = "0x2C60DD0", VA = "0x182C61DD0")]
	private void BGMFMLHGDLB(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC, int NFNGIKPPKJH, PGIKEAFDIOH JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2C623F0", Offset = "0x2C613F0", VA = "0x182C623F0")]
	private NativeMultiHashMap<int, (PMFFIMLMCEJ, PMFFIMLMCEJ)> DBBOOLGMANB(Allocator AEPJLHDIHPH, NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, out NativeArray<(PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> LAHOBEIJIGE)
	{
		return default(NativeMultiHashMap<int, (PMFFIMLMCEJ, PMFFIMLMCEJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HEADBEHLNDI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[EHMOCHPPOLA(typeof(TransformService))]
	[DEJAKMDKDPE(typeof(HJBNADOIEKJ), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	public class TransformService : HJBNADOIEKJ, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FBNJDMKEPCN ALBBGALBMCO;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly FBNJDMKEPCN JODEDLKPPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private DNMOINOIHDI MMKJPCINEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private BCIOKJKBEBJ NJHJPKKCNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase CEGAKOKAOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService ADDOLKFBKIO;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2B10890", Offset = "0x2B0F890", VA = "0x182B10890")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private CGJFLAGLGMG GBGKPEOJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2B12170", Offset = "0x2B11170", VA = "0x182B12170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2B12060", Offset = "0x2B11060", VA = "0x182B12060", Slot = "33")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F410", Offset = "0x2B0E410", VA = "0x182B0F410", Slot = "34")]
		public bool CPDDNAGIOIJ(Transform FLCFNMLPAML, out PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2B12490", Offset = "0x2B11490", VA = "0x182B12490", Slot = "35")]
		public Transform NHDJANMKOLL(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2B11150", Offset = "0x2B10150", VA = "0x182B11150", Slot = "30")]
		public bool JIACBDMPAMB(Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2B10700", Offset = "0x2B0F700", VA = "0x182B10700")]
		private void FFEFNBPLCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FAC0", Offset = "0x2B0EAC0", VA = "0x182B0FAC0", Slot = "29")]
		public void DJMPPFCPMKB(Entity IEFFOCOBJJI, out Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FEA0", Offset = "0x2B0EEA0", VA = "0x182B0FEA0", Slot = "4")]
		public void EOEAAIEBGEA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2B107C0", Offset = "0x2B0F7C0", VA = "0x182B107C0")]
		public void GCJBMOBOFDI(Entity IEFFOCOBJJI, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK, Vector3 CGOLLDJLBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EB40", Offset = "0x2B0DB40", VA = "0x182B0EB40")]
		public void BICBFAKLOLG(Entity IEFFOCOBJJI, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FC10", Offset = "0x2B0EC10", VA = "0x182B0FC10", Slot = "27")]
		public void DLFDFJODBHO(Entity IEFFOCOBJJI, out Matrix4x4 AIEHGIIJFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2B109B0", Offset = "0x2B0F9B0", VA = "0x182B109B0")]
		public void ICGHLFAIJEP(Entity IEFFOCOBJJI, in Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2B11D40", Offset = "0x2B10D40", VA = "0x182B11D40")]
		public void MFNBAILGADD(Entity IEFFOCOBJJI, in Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2B115B0", Offset = "0x2B105B0", VA = "0x182B115B0")]
		public void KNNABGOKBFB(Entity IEFFOCOBJJI, in Matrix4x4 CFHGHGMHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E3A0", Offset = "0x2B0D3A0", VA = "0x182B0E3A0", Slot = "5")]
		public void AEDOKGKNHMF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2B103D0", Offset = "0x2B0F3D0", VA = "0x182B103D0", Slot = "6")]
		public Vector3 FDAKLDHCMFH(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2B10090", Offset = "0x2B0F090", VA = "0x182B10090", Slot = "7")]
		public void EOOLKIJFFHJ(Entity IEFFOCOBJJI, Quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E4C0", Offset = "0x2B0D4C0", VA = "0x182B0E4C0", Slot = "8")]
		public Quaternion AFCMKBPCCGH(Entity IEFFOCOBJJI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2B11F60", Offset = "0x2B10F60", VA = "0x182B11F60", Slot = "12")]
		public void MIBMKNNHFFF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2B11240", Offset = "0x2B10240", VA = "0x182B11240", Slot = "11")]
		public Vector3 JMAHNOKCJBK(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2B13270", Offset = "0x2B12270", VA = "0x182B13270")]
		public void ONKJHMFHPBJ(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2B11510", Offset = "0x2B10510", VA = "0x182B11510")]
		private Vector3 KGEJOEDIFKE(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2B10720", Offset = "0x2B0F720", VA = "0x182B10720", Slot = "14")]
		public float FGOMGKJMJIL(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2B10190", Offset = "0x2B0F190", VA = "0x182B10190", Slot = "13")]
		public void EPFPKDBDJFP(Entity IEFFOCOBJJI, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F0B0", Offset = "0x2B0E0B0", VA = "0x182B0F0B0")]
		private float CAIAHEGLMPL(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2B13310", Offset = "0x2B12310", VA = "0x182B13310")]
		public void PCMLMDPOEFD(Entity IEFFOCOBJJI, float OHEEIOFMHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2B11940", Offset = "0x2B10940", VA = "0x182B11940", Slot = "16")]
		public Vector3 LGHNHCCLLEH(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2B13140", Offset = "0x2B12140", VA = "0x182B13140", Slot = "15")]
		public void OGHBLGNOEEM(Entity IEFFOCOBJJI, Vector3 GCMCIHOGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E5B0", Offset = "0x2B0D5B0", VA = "0x182B0E5B0")]
		private Vector3 AFHLNGCBJKB(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2B108E0", Offset = "0x2B0F8E0", VA = "0x182B108E0")]
		public void HAPAEBGFHDD(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2B10D70", Offset = "0x2B0FD70", VA = "0x182B10D70")]
		[Conditional("DEBUG_BUILD")]
		private void JFIAHMFEGOM(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FC20", Offset = "0x2B0EC20", VA = "0x182B0FC20", Slot = "36")]
		public void DNOABEIJEJG(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2B117F0", Offset = "0x2B107F0", VA = "0x182B117F0", Slot = "9")]
		public void KOIMOEHOCOB(Entity IEFFOCOBJJI, out Vector3 IJBELJOFGFA, out Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2B102A0", Offset = "0x2B0F2A0", VA = "0x182B102A0", Slot = "10")]
		public void FANAHDJFCPN(Entity IEFFOCOBJJI, out Vector3 IJBELJOFGFA, out Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2B104E0", Offset = "0x2B0F4E0", VA = "0x182B104E0", Slot = "37")]
		public void FEACFDPIMOM(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2B11350", Offset = "0x2B10350", VA = "0x182B11350")]
		public void KABEBPDPMIJ(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E6E0", Offset = "0x2B0D6E0", VA = "0x182B0E6E0", Slot = "17")]
		public void AKLPLNGENKF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C60", Offset = "0x2B10C60", VA = "0x182B11C60", Slot = "18")]
		public Vector3 MFINHFOBLPA(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A20", Offset = "0x2B10A20", VA = "0x182B11A20", Slot = "19")]
		public void MAMMGLHAFED(Entity IEFFOCOBJJI, Quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F1A0", Offset = "0x2B0E1A0", VA = "0x182B0F1A0", Slot = "20")]
		public Quaternion CELLKLHHAFM(Entity IEFFOCOBJJI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EC50", Offset = "0x2B0DC50", VA = "0x182B0EC50", Slot = "22")]
		public void BJBCJICNPJE(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2B11E70", Offset = "0x2B10E70", VA = "0x182B11E70", Slot = "21")]
		public Vector3 MHJEBGJKDLJ(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F290", Offset = "0x2B0E290", VA = "0x182B0F290", Slot = "23")]
		public void CGDKBIGBIPB(Entity IEFFOCOBJJI, float DJECIOHEFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FD80", Offset = "0x2B0ED80", VA = "0x182B0FD80", Slot = "24")]
		public float DPBDAPJBLNA(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F5D0", Offset = "0x2B0E5D0", VA = "0x182B0F5D0", Slot = "25")]
		public void DDDNCFMMPDC(Entity IEFFOCOBJJI, Vector3 JMOMDJGICGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2B12350", Offset = "0x2B11350", VA = "0x182B12350", Slot = "26")]
		public Vector3 MPJBDCKBJNK(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2B128F0", Offset = "0x2B118F0", VA = "0x182B128F0", Slot = "31")]
		public void NKPBMMMLJNF(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2B10F20", Offset = "0x2B0FF20", VA = "0x182B10F20")]
		private PMFFIMLMCEJ JGAPMBMDNIA(Transform FLCFNMLPAML)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E910", Offset = "0x2B0D910", VA = "0x182B0E910")]
		private static TransformEntity AMOIEJPHHGD(PEMKGMKGDAH IGEIBCJNCHF, GameObject JLMCLCAPEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2B12230", Offset = "0x2B11230", VA = "0x182B12230", Slot = "32")]
		public void MOPGPCGBCME(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK, Entity LCCGHHJFGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2B11770", Offset = "0x2B10770", VA = "0x182B11770")]
		private KAHCBEFNIAJ KOIMOEHOCOB(Entity IEFFOCOBJJI)
		{
			return default(KAHCBEFNIAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2B11070", Offset = "0x2B10070", VA = "0x182B11070")]
		private bool JGPHIFFFOHJ(Entity IEFFOCOBJJI, out Entity ICMEPOIJCJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2B12F90", Offset = "0x2B11F90", VA = "0x182B12F90")]
		private void NMDECDGPLLP(Entity IEFFOCOBJJI, out Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2B12550", Offset = "0x2B11550", VA = "0x182B12550")]
		private void NJJMDCLHHBD(Entity IEFFOCOBJJI, out Matrix4x4 CFHGHGMHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F400", Offset = "0x2B0E400", VA = "0x182B0F400", Slot = "28")]
		private void CKLLDADLEGH(Entity IEFFOCOBJJI, in Matrix4x4 AIEHGIIJFOI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DEJAKMDKDPE(typeof(BHDKNMGNAOM), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
internal sealed class BHDKNMGNAOM : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[GNFGKNINDPI]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2A69470", Offset = "0x2A68470", VA = "0x182A69470", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2A69400", Offset = "0x2A68400", VA = "0x182A69400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public BHDKNMGNAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(GFGDPLIPMKB), new string[] { })]
public class GFGDPLIPMKB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OCFPLFOAJCN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly GFGDPLIPMKB ICMEPOIJCJO;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x41449F0", Offset = "0x41439F0", VA = "0x1841449F0")]
		public OCFPLFOAJCN(GFGDPLIPMKB ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x41449D0", Offset = "0x41439D0", VA = "0x1841449D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int HJGBACNDMNH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool JHBNPIJHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x139DD30", Offset = "0x139CD30", VA = "0x18139DD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action IMOHEMBKPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D230", Offset = "0x2C5C230", VA = "0x182C5D230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D190", Offset = "0x2C5C190", VA = "0x182C5D190")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D160", Offset = "0x2C5C160", VA = "0x182C5D160")]
	public OCFPLFOAJCN FDMPPFDLEPC()
	{
		return default(OCFPLFOAJCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x14A0CA0", Offset = "0x149FCA0", VA = "0x1814A0CA0")]
	public void OFKDPKABHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D140", Offset = "0x2C5C140", VA = "0x182C5D140")]
	public void EFBCANIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GFGDPLIPMKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DEJAKMDKDPE(typeof(OEHMAIGJCPM), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
public class OEHMAIGJCPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int HJGBACNDMNH;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xD35020", Offset = "0xD34020", VA = "0x180D35020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x981330", Offset = "0x980330", VA = "0x180981330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public OEHMAIGJCPM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DEJAKMDKDPE(typeof(EnableComponentSystemsInScope), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	public class EnableComponentSystemsInScope : COMOMFINKHP, OMNOAEHFEEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct CHPBGIKBHKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> EOIEIICJLCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> JOOBOILFNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> GDFCEKJMLJB;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFDC0", Offset = "0x2AFEDC0", VA = "0x182AFFDC0")]
			public CHPBGIKBHKC(NativeArray<int> EOIEIICJLCG, NativeArray<int> JOOBOILFNKM, Dictionary<ComponentSystemBase, int> GDFCEKJMLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFB40", Offset = "0x2AFEB40", VA = "0x182AFFB40")]
			public void NEEDBNNAFFK(IEnumerable<ComponentSystemBase> GNCNHHEOEMG, KHFGEOAKOKD MGAKBAOGMDF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class IFOKFKFAJIL : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public IFOKFKFAJIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4140740", Offset = "0x413F740", VA = "0x184140740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4140910", Offset = "0x413F910", VA = "0x184140910", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x4140860", Offset = "0x413F860", VA = "0x184140860", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x4140860", Offset = "0x413F860", VA = "0x184140860", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const KHFGEOAKOKD EEAHIBBCBOF = KHFGEOAKOKD.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FBNJDMKEPCN EHONJLONGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private OKKPKCPMOFL GNDGFHCLBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> ANNKAMEPGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> KNDMAKMCMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int IIJDDKBOPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private KHFGEOAKOKD DJAKMNPDGFN;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A83CB0", Offset = "0x2A82CB0", VA = "0x182A83CB0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A83450", Offset = "0x2A82450", VA = "0x182A83450", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A834E0", Offset = "0x2A824E0", VA = "0x182A834E0")]
		[IteratorStateMachine(typeof(IFOKFKFAJIL))]
		private IEnumerable<ComponentSystemBase> ELABNLHFDJG(int FHGIIAKFJFF, int APIEJLBIMAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A83350", Offset = "0x2A82350", VA = "0x182A83350", Slot = "5")]
		public void DMHOOCIGLMM(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A83670", Offset = "0x2A82670", VA = "0x182A83670")]
		private void ELEAJINJHMG(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A83570", Offset = "0x2A82570", VA = "0x182A83570")]
		public void ELEAJINJHMG(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A83A20", Offset = "0x2A82A20", VA = "0x182A83A20")]
		private void MBKODKCLKPG(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A831C0", Offset = "0x2A821C0", VA = "0x182A831C0")]
		private void ANMLDILCJLD(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A83960", Offset = "0x2A82960", VA = "0x182A83960")]
		private void KOOEIBOLOGE(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A837C0", Offset = "0x2A827C0", VA = "0x182A837C0")]
		private void ELIGOHDACHE(int FHGIIAKFJFF, int APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A83250", Offset = "0x2A82250", VA = "0x182A83250")]
		private void CFMJHACGJMJ(int FHGIIAKFJFF, int APIEJLBIMAO, bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A83940", Offset = "0x2A82940", VA = "0x182A83940")]
		private int JAFLOEJLPJI(KHFGEOAKOKD IIDLBJCOLPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A82B80", Offset = "0x2A81B80", VA = "0x182A82B80")]
		private bool ABBBJOJLPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A83360", Offset = "0x2A82360", VA = "0x182A83360")]
		private Dictionary<ComponentSystemBase, int> DOJMEPKFMJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A83310", Offset = "0x2A82310", VA = "0x182A83310")]
		private void COMCACEMKIL(NativeArray<int> EOIEIICJLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A83110", Offset = "0x2A82110", VA = "0x182A83110")]
		private void ADBHGJHBPEG(NativeArray<int> JOOBOILFNKM, NativeArray<int> EOIEIICJLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A838E0", Offset = "0x2A828E0", VA = "0x182A838E0")]
		private static KHFGEOAKOKD IHLMDHIGAFD(Type IGEIBCJNCHF, KHFGEOAKOKD PGBDPKDFJME)
		{
			return default(KHFGEOAKOKD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A83DC0", Offset = "0x2A82DC0", VA = "0x182A83DC0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A83880", Offset = "0x2A82880", VA = "0x182A83880")]
		[CompilerGenerated]
		private void FMLLHBEDEJP(COMOMFINKHP HLMBINIPBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A839C0", Offset = "0x2A829C0", VA = "0x182A839C0")]
		[CompilerGenerated]
		private void LGFGINPCGKE(BDDJKMOFDGN HLMBINIPBFD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[LMNMHFHDONH(IPKPBIMLPOB.WorldService)]
	[DEJAKMDKDPE(typeof(AFNBNNKFHAD), new string[] { })]
	public class TickService : COMOMFINKHP, AFNBNNKFHAD
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker GDDDMNPHHIE;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker AEELMLGPPMN;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker FDMEBDDKAOO;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker IKLOGOOGOMK;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker LOJNOJBDKEM;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker IOKCLCKDHHG;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker ODJPMJNJFNF;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker EFBLGLGNAAM;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker OMDOIEMDCMI;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker NAEJMFHEIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[GNFGKNINDPI]
		private BHIIPBMPCDB OLPNBPCMPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[GNFGKNINDPI]
		private MABCHLFNALK JHLPOBMNEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[GNFGKNINDPI]
		private TransformOwnershipPhase KMANEIOAPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[GNFGKNINDPI]
		private TimeService ABBPIJBGMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private AHBEEJODFBD GLPDAIBKGJO;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool FKNFBCHICAM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C760", Offset = "0x2B0B760", VA = "0x182B0C760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool ELCLIKFJMHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0D730", Offset = "0x2B0C730", VA = "0x182B0D730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool ALAFFHMPDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C760", Offset = "0x2B0B760", VA = "0x182B0C760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool NGCNLAGBKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C760", Offset = "0x2B0B760", VA = "0x182B0C760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC10", Offset = "0x2B0BC10", VA = "0x182B0CC10", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D610", Offset = "0x2B0C610", VA = "0x182B0D610", Slot = "14")]
		public void OGBGHIJCMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8A0", Offset = "0x2B0B8A0", VA = "0x182B0C8A0", Slot = "15")]
		public void GJMFHABAJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C7D0", Offset = "0x2B0B7D0", VA = "0x182B0C7D0", Slot = "5")]
		public void CJBJBGJOMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CED0", Offset = "0x2B0BED0", VA = "0x182B0CED0", Slot = "6")]
		public void NJOHPCFDKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D050", Offset = "0x2B0C050", VA = "0x182B0D050", Slot = "7")]
		public void NLPMOAPDCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C9C0", Offset = "0x2B0B9C0", VA = "0x182B0C9C0", Slot = "8")]
		public void IHJMNBEDLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C5E0", Offset = "0x2B0B5E0", VA = "0x182B0C5E0", Slot = "9")]
		public void AHFHABAIIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D1D0", Offset = "0x2B0C1D0", VA = "0x182B0D1D0", Slot = "10")]
		public void OBOGAEJIIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CB40", Offset = "0x2B0BB40", VA = "0x182B0CB40", Slot = "11")]
		public void MKHMJNKCKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
		public void HLCPEAKANIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CD80", Offset = "0x2B0BD80", VA = "0x182B0CD80", Slot = "12")]
		public void NBBFKLIADFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[LMNMHFHDONH(IPKPBIMLPOB.WorldService)]
	[DEJAKMDKDPE(typeof(JLJEDKKMHDF), new string[] { })]
	public class WorldService : JLJEDKKMHDF, IDisposable, LGFONBKKNKN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AHBEEJODFBD GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public AHBEEJODFBD MECEOFMEJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public CGJFLAGLGMG GBGKPEOJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A7FD80", Offset = "0x2A7ED80", VA = "0x182A7FD80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2B1BF10", Offset = "0x2B1AF10", VA = "0x182B1BF10", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool NMMHNMGCMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6988D0", Offset = "0x6978D0", VA = "0x1806988D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C060", Offset = "0x2B1B060", VA = "0x182B1C060", Slot = "10")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BF30", Offset = "0x2B1AF30", VA = "0x182B1BF30")]
		private void HJNGNBALKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BCE0", Offset = "0x2B1ACE0", VA = "0x182B1BCE0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C040", Offset = "0x2B1B040", VA = "0x182B1C040", Slot = "8")]
		public ComponentSystemBase MGCDCBKMLNL(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DEJAKMDKDPE(typeof(NIMHHIKGLPG), new string[] { })]
public sealed class GNHBODHFIDP : NIMHHIKGLPG, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NFDKGFLBEKH : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4144500", Offset = "0x4143500", VA = "0x184144500", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA51C0", VA = "0x181FA61C0")]
		[DebuggerHidden]
		public NFDKGFLBEKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x41441F0", Offset = "0x41431F0", VA = "0x1841441F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x41444C0", Offset = "0x41434C0", VA = "0x1841444C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4144420", Offset = "0x4143420", VA = "0x184144420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4144420", Offset = "0x4143420", VA = "0x184144420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[GNFGKNINDPI]
	private MFDIJJOFCMP JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly DMNOINFOIBI BNBDLMAJEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, EEPMGPBIGKA> IGEGENPKKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, IPECHNMOHGG> PEDNKNCDMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<NOLDFLLDJKB> BLANGFECLIA;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IPECHNMOHGG OKPDNHAEDOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C60F90", Offset = "0x2C5FF90", VA = "0x182C60F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<NOLDFLLDJKB> JHEPCBPDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C60C80", Offset = "0x2C5FC80", VA = "0x182C60C80", Slot = "8")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C602F0", Offset = "0x2C5F2F0", VA = "0x182C602F0", Slot = "9")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C603F0", Offset = "0x2C5F3F0", VA = "0x182C603F0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C601D0", Offset = "0x2C5F1D0", VA = "0x182C601D0", Slot = "6")]
	public bool BDKDMMLHNEC(NOLDFLLDJKB FJONJLMIBBO, out IPECHNMOHGG JOKFNNKABBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C60610", Offset = "0x2C5F610", VA = "0x182C60610")]
	private void KGDGGEMMCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C60DF0", Offset = "0x2C5FDF0", VA = "0x182C60DF0")]
	private void OLIHIJMMCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C60480", Offset = "0x2C5F480", VA = "0x182C60480")]
	private EEPMGPBIGKA GMAEIGPPALK(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C60F90", Offset = "0x2C5FF90", VA = "0x182C60F90")]
	private EEPMGPBIGKA PDCILNKJGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C60A10", Offset = "0x2C5FA10", VA = "0x182C60A10")]
	private EEPMGPBIGKA LPFLDBJPCMI(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C60CE0", Offset = "0x2C5FCE0", VA = "0x182C60CE0")]
	private EEPMGPBIGKA OBJKMLBENFF(string JLGENJBOGCK, string KCCFEDJJGAN, [Optional] EEPMGPBIGKA LPFFJHJDBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C609A0", Offset = "0x2C5F9A0", VA = "0x182C609A0")]
	[IteratorStateMachine(typeof(NFDKGFLBEKH))]
	private IEnumerable<(string, string)> LLOMCCCOLFA(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C605C0", Offset = "0x2C5F5C0", VA = "0x182C605C0")]
	private bool IIPNEAJMPFP(NOLDFLLDJKB FJONJLMIBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C600F0", Offset = "0x2C5F0F0", VA = "0x182C600F0")]
	private DMNOINFOIBI BAGOBHHCLIB(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C60310", Offset = "0x2C5F310", VA = "0x182C60310")]
	private DMNOINFOIBI CKCAMMFPBNK(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C60260", Offset = "0x2C5F260", VA = "0x182C60260")]
	private DMNOINFOIBI BDLNNGNIKCG(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x225B060", Offset = "0x225A060", VA = "0x18225B060")]
	private T EDPCACBNNON<T>(NOLDFLLDJKB FJONJLMIBBO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C604E0", Offset = "0x2C5F4E0", VA = "0x182C604E0")]
	private FieldInfo IGHLHBGGLDA(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C60FF0", Offset = "0x2C5FFF0", VA = "0x182C60FF0")]
	public GNHBODHFIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C60360", Offset = "0x2C5F360", VA = "0x182C60360")]
	[CompilerGenerated]
	private int DBIKHPOBBAC(NOLDFLLDJKB NCNGLFNLPAG, NOLDFLLDJKB OPGAGDBKIDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class EEPMGPBIGKA : IPECHNMOHGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string LOHFJEKMLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly EEPMGPBIGKA LPFFJHJDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<EEPMGPBIGKA> MNIJFMDCHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<NOLDFLLDJKB> JDJBDCDEPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string GFDOEPCIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IPECHNMOHGG MGPIFHPCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<IPECHNMOHGG> EKNJPFIMDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<NOLDFLLDJKB> ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E4B0", Offset = "0x2A7D4B0", VA = "0x182A7E4B0")]
	public EEPMGPBIGKA(string IADPDEAGFAB, EEPMGPBIGKA ICMEPOIJCJO)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[LMNMHFHDONH(IPKPBIMLPOB.History)]
	[DEJAKMDKDPE(typeof(LHMGIFBKNDN), new string[] { })]
	[EHMOCHPPOLA(typeof(HistoryService))]
	public class HistoryService : COMOMFINKHP, IDisposable, LHMGIFBKNDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum PPOBDOKNEND
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct JJGKJBNHMHO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly PPOBDOKNEND DALPPGCJAHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService KGAFOEANBBF;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4142030", Offset = "0x4141030", VA = "0x184142030")]
			public JJGKJBNHMHO(HistoryService KGAFOEANBBF, bool NPJADAPMKIL, uint IIJDDKBOPLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4142000", Offset = "0x4141000", VA = "0x184142000", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class CAJGLGINPIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct DENFOJIHLML : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly CAJGLGINPIC DBADFKHLJMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool PPMBFIJDBAJ;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x413DFE0", Offset = "0x413CFE0", VA = "0x18413DFE0")]
				public DENFOJIHLML(CAJGLGINPIC DBADFKHLJMI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x413CC60", Offset = "0x413BC60", VA = "0x18413CC60", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct BPLMACLJKFK : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly CAJGLGINPIC DBADFKHLJMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool PPMBFIJDBAJ;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x413CC90", Offset = "0x413BC90", VA = "0x18413CC90")]
				public BPLMACLJKFK(CAJGLGINPIC DBADFKHLJMI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x413CC60", Offset = "0x413BC60", VA = "0x18413CC60", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService FHBNDHEOPHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool JKKPKCOEILI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int HIGIMLEOAPG;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x413D3B0", Offset = "0x413C3B0", VA = "0x18413D3B0")]
			public CAJGLGINPIC(HistoryService FHBNDHEOPHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x413D330", Offset = "0x413C330", VA = "0x18413D330")]
			public bool IBGFCGLBHEJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x413D360", Offset = "0x413C360", VA = "0x18413D360")]
			public BPLMACLJKFK MEBKBHJOELE()
			{
				return default(BPLMACLJKFK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x413D2E0", Offset = "0x413C2E0", VA = "0x18413D2E0")]
			public DENFOJIHLML DDAPMJBHKCE()
			{
				return default(DENFOJIHLML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class EKFBANOOLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public EKFBANOOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x413E8C0", Offset = "0x413D8C0", VA = "0x18413E8C0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class AIBFBDCBJPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public AIBFBDCBJPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x413BBE0", Offset = "0x413ABE0", VA = "0x18413BBE0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class DKJHPDCBEME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public DKJHPDCBEME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x413E0E0", Offset = "0x413D0E0", VA = "0x18413E0E0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction LDBNFNFJHKB;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction ICILHJPKGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private OBLIGMOAKKF FDPGCBLLMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer JBHOCOJODFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer LLGDOLDBILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private CMGLJGJIAFN PLLIMNFHMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase KMANEIOAPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService AHEHOIEGADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private OIHIOHPKDOB GDBEDAHCFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private PPOBDOKNEND ALEBINGBGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private CAJGLGINPIC DBADFKHLJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private MKLPHIINDDK JHBPCGGOFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private OEKGHEEACHJ BGLDIAJAIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private OEMFGOLGDMG GIDCMGOAIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete LKHCAIFJCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint KGFBECKGKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint OGJAFCGEENN;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private CAJGLGINPIC NCODPDBPGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x694770", Offset = "0x693770", VA = "0x180694770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CIKIKKFBBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2C64600", Offset = "0x2C63600", VA = "0x182C64600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool LFLPHDGCMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2C66070", Offset = "0x2C65070", VA = "0x182C66070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool JHDDKNONGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2C643F0", Offset = "0x2C633F0", VA = "0x182C643F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int HIOCFEEKKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2C64670", Offset = "0x2C63670", VA = "0x182C64670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int GGJPBBCJHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2C64C00", Offset = "0x2C63C00", VA = "0x182C64C00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool MPHNCICJFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2C63FB0", Offset = "0x2C62FB0", VA = "0x182C63FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool EPABDLEICAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2C651C0", Offset = "0x2C641C0", VA = "0x182C651C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool DLDDGHBJKGG
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8BA9E0", Offset = "0x8B99E0", VA = "0x1808BA9E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x10D5650", Offset = "0x10D4650", VA = "0x1810D5650", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer IBDNOKDIBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2C650D0", Offset = "0x2C640D0", VA = "0x182C650D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action GAHABKKJMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2C65EF0", Offset = "0x2C64EF0", VA = "0x182C65EF0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2C64730", Offset = "0x2C63730", VA = "0x182C64730", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action DGPFFPMCCPF
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2C653B0", Offset = "0x2C643B0", VA = "0x182C653B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2C65E50", Offset = "0x2C64E50", VA = "0x182C65E50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2C655B0", Offset = "0x2C645B0", VA = "0x182C655B0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2C647D0", Offset = "0x2C637D0", VA = "0x182C647D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2C64CB0", Offset = "0x2C63CB0", VA = "0x182C64CB0")]
		private void GCANJAKJCLB(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2C650E0", Offset = "0x2C640E0", VA = "0x182C650E0")]
		private void JDIMMFPKBDJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO ACDGNPNCEEN, PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2C65C70", Offset = "0x2C64C70", VA = "0x182C65C70")]
		private void NNHNKAFCEIJ(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2C65100", Offset = "0x2C64100", VA = "0x182C65100", Slot = "14")]
		public IDisposable KGLPMCGJFLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2C65160", Offset = "0x2C64160", VA = "0x182C65160", Slot = "9")]
		public IDisposable LHIJMJACOHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2C64D70", Offset = "0x2C63D70", VA = "0x182C64D70", Slot = "6")]
		public UndoAction GJCNDKKNGGA()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2C64540", Offset = "0x2C63540", VA = "0x182C64540", Slot = "15")]
		public RedoAction CPMFFLOLHKD()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2C651D0", Offset = "0x2C641D0", VA = "0x182C651D0", Slot = "16")]
		public UndoAction LNFCFBBFPJE()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2C64420", Offset = "0x2C63420", VA = "0x182C64420", Slot = "7")]
		public RedoAction CPMFFLOLHKD(UndoAction IBCPLIFFFGK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2C65290", Offset = "0x2C64290", VA = "0x182C65290", Slot = "8")]
		public UndoAction LNFCFBBFPJE(RedoAction IBCPLIFFFGK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2C642F0", Offset = "0x2C632F0", VA = "0x182C642F0")]
		public bool CEFCHABAGJG(IGHLDNIINHN LMCIPCHPDMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2C64C20", Offset = "0x2C63C20", VA = "0x182C64C20", Slot = "17")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2C64330", Offset = "0x2C63330", VA = "0x182C64330")]
		public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2C65F90", Offset = "0x2C64F90", VA = "0x182C65F90")]
		public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ANLFJINAGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2C64B50", Offset = "0x2C63B50", VA = "0x182C64B50")]
		public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2C64C70", Offset = "0x2C63C70", VA = "0x182C64C70")]
		private void ENLOKCCHLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2C63FC0", Offset = "0x2C62FC0", VA = "0x182C63FC0")]
		private void BLNOGLJLKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2C63F70", Offset = "0x2C62F70", VA = "0x182C63F70")]
		private void AKOOLCAOLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2C64E30", Offset = "0x2C63E30", VA = "0x182C64E30")]
		private CPEGLNOCJGF HOPKCAHHLOB()
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2C63F90", Offset = "0x2C62F90", VA = "0x182C63F90")]
		private uint AOOFGDICMPP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2C64710", Offset = "0x2C63710", VA = "0x182C64710")]
		private bool DFHIEEMFFJJ(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2C64F30", Offset = "0x2C63F30", VA = "0x182C64F30")]
		private bool IDPOLGFHINF(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2C65AC0", Offset = "0x2C64AC0", VA = "0x182C65AC0")]
		private RedoAction NIJELJHFECP(CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2C65A60", Offset = "0x2C64A60", VA = "0x182C65A60")]
		private UndoAction NECKKHMHCKE(CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2C64000", Offset = "0x2C63000", VA = "0x182C64000")]
		private CPEGLNOCJGF BMCAJEODCKH(CPEGLNOCJGF KNOLDLABLMF, ActionBuffer EEFHJMOJPAK, bool NPJADAPMKIL)
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2C64A70", Offset = "0x2C63A70", VA = "0x182C64A70")]
		private void EALHAGLBCNH(Action KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2268900", Offset = "0x2267900", VA = "0x182268900")]
		private T EALHAGLBCNH<T>(Func<T> ABAJKNEIKOD)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2C642C0", Offset = "0x2C632C0", VA = "0x182C642C0")]
		private JJGKJBNHMHO CBIEELIMJCL(bool NPJADAPMKIL, uint IIJDDKBOPLN)
		{
			return default(JJGKJBNHMHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2C661F0", Offset = "0x2C651F0", VA = "0x182C661F0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2C65B20", Offset = "0x2C64B20", VA = "0x182C65B20")]
		[CompilerGenerated]
		private UndoAction NNAKGNAGILG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2C64F50", Offset = "0x2C63F50", VA = "0x182C64F50")]
		[CompilerGenerated]
		private RedoAction IOBMOIMCPOC()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2C65450", Offset = "0x2C64450", VA = "0x182C65450")]
		[CompilerGenerated]
		private UndoAction MLMIPGNBGIA()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EPLGFAIOMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> DBOPJMNFJMA;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public EPLGFAIOMHP(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2A81BD0", Offset = "0x2A80BD0", VA = "0x182A81BD0")]
	public static EPLGFAIOMHP LFOOIECCIPM(NativeArray<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T PEAHPJAKBCE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> JAAOKGGFOAC<T>(int MFAHIHFAKKH, Allocator AEPJLHDIHPH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> LIJGMJGJGPA<T>(Allocator AEPJLHDIHPH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JDMFNNEOLIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> DBOPJMNFJMA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public JDMFNNEOLIB(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A400", Offset = "0x2C69400", VA = "0x182C6A400")]
	public static JDMFNNEOLIB LFOOIECCIPM(NativeArray<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x28CDB20", Offset = "0x28CCB20", VA = "0x1828CDB20")]
	public T PEAHPJAKBCE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> JAAOKGGFOAC<T>(int MFAHIHFAKKH, Allocator AEPJLHDIHPH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class AIDBFOLIHEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> DBOPJMNFJMA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public AIDBFOLIHEH(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2A66800", Offset = "0x2A65800", VA = "0x182A66800")]
	public static AIDBFOLIHEH LFOOIECCIPM(NativeArray<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x227A550", Offset = "0x2279550", VA = "0x18227A550")]
	public void JMIBPICBBFK<T>(in T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x227A450", Offset = "0x2279450", VA = "0x18227A450")]
	public void FGJPEPMOBEB<T>(NativeArray<T> PPLEFHADAKM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void IPKIGKOICMO<T>(NativeArray<T> DFEOJBAFBHE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KMGHEFJPKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F0E0", Offset = "0x2C6E0E0", VA = "0x182C6F0E0")]
	public static Span<byte> KKLCOGJIJAM(this NativeArray<byte> DBOPJMNFJMA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EE70", Offset = "0x2C6DE70", VA = "0x182C6EE70")]
	public static ReadOnlySpan<byte> FFHOHNIJDJJ(this NativeArray<byte> DBOPJMNFJMA)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2C6ED70", Offset = "0x2C6DD70", VA = "0x182C6ED70")]
	public static NativeArray<byte> BJPMOLGEFMG(this NativeArray<byte> DBOPJMNFJMA, int FHGIIAKFJFF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EFF0", Offset = "0x2C6DFF0", VA = "0x182C6EFF0")]
	public static NativeArray<byte> GPMKAMPNFLF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x256E280", Offset = "0x256D280", VA = "0x18256E280")]
	public static NativeArray<byte> GPMKAMPNFLF<T>(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F070", Offset = "0x2C6E070", VA = "0x182C6F070")]
	public static NativeArray<byte> KADJNOHLEJF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x256E2E0", Offset = "0x256D2E0", VA = "0x18256E2E0")]
	public static NativeArray<byte> KADJNOHLEJF<T>(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EDF0", Offset = "0x2C6DDF0", VA = "0x182C6EDF0")]
	public static NativeArray<byte> BMPIBIGAJBF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x256CD40", Offset = "0x256BD40", VA = "0x18256CD40")]
	public static NativeArray<byte> BMPIBIGAJBF<T>(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class ECIJCHIDDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xC3E9D0", Offset = "0xC3D9D0", VA = "0x180C3E9D0")]
	public ECIJCHIDDMF(NativeList<byte> DEEJEKFIHBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E450", Offset = "0x2A7D450", VA = "0x182A7E450")]
	public static ECIJCHIDDMF LFOOIECCIPM(NativeList<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void JMIBPICBBFK<T>(in T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void FGJPEPMOBEB<T>(NativeArray<T> DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void IPKIGKOICMO<T>(NativeArray<T> DFEOJBAFBHE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.PropertyChanges)]
	public class PropertyChangeNetworkRouter : LGFONBKKNKN, COMOMFINKHP, LHLKDMMNFKH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[GNFGKNINDPI]
		private LJNOAKDEJDG GAKCPFEFIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[GNFGKNINDPI]
		private DPCIBBJGPEK JDJBDCDEPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[GNFGKNINDPI]
		private GFGDPLIPMKB CIFPBENKAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[GNFGKNINDPI]
		private PropertyChangeRouterService AHEHOIEGADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private OBLIGMOAKKF JFKHJAJODDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private KEIEEPAJBNC KNDPILCJGBD;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OBLIGMOAKKF MHEGOCACDLO
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2987E80", Offset = "0x2986E80", VA = "0x182987E80")]
		public OBLIGMOAKKF.JDPFELICGMF FDMPPFDLEPC()
		{
			return default(OBLIGMOAKKF.JDPFELICGMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2988660", Offset = "0x2987660", VA = "0x182988660", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x29883C0", Offset = "0x29873C0", VA = "0x1829883C0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2987930", Offset = "0x2986930", VA = "0x182987930", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2987EC0", Offset = "0x2986EC0", VA = "0x182987EC0")]
		public void GJCNDKKNGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2987E50", Offset = "0x2986E50", VA = "0x182987E50")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x29882B0", Offset = "0x29872B0", VA = "0x1829882B0")]
		private void MLFMBPLNLEG(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x29880D0", Offset = "0x29870D0", VA = "0x1829880D0")]
		private void IABNGNJBIOL(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO ACDGNPNCEEN, PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2987FD0", Offset = "0x2986FD0", VA = "0x182987FD0")]
		private void HBNAEBDJHPL(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2987B70", Offset = "0x2986B70", VA = "0x182987B70")]
		private void EKKBEDKPPDM(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2988180", Offset = "0x2987180", VA = "0x182988180")]
		private void LBBGJEOJNPJ(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x29877D0", Offset = "0x29867D0", VA = "0x1829877D0")]
		private void BIODCEJHCND(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2988640", Offset = "0x2987640", VA = "0x182988640")]
		private void OFKDPKABHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2987B50", Offset = "0x2986B50", VA = "0x182987B50")]
		private void EFBCANIPFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2987890", Offset = "0x2986890", VA = "0x182987890")]
		private void DGHMLCNIEON(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x38AC390", Offset = "0x38AB390", VA = "0x1838AC390", Slot = "6")]
		private void KBBOGOGHKEO<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, object KPJEGNGKPOH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[LMNMHFHDONH(IPKPBIMLPOB.History)]
	[DEJAKMDKDPE(typeof(PropertyChangeRouterService), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void OEPEJBJPFEE(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void FKADKELNPFN(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO ACDGNPNCEEN, PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ECNHPFGOMKH(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public OEPEJBJPFEE HJNGNBALKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FKADKELNPFN ANLIDMEIHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public ECNHPFGOMKH KGNKLNCMPDI;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x29887A0", Offset = "0x29877A0", VA = "0x1829887A0")]
		public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x29887E0", Offset = "0x29877E0", VA = "0x1829887E0")]
		public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ACDGNPNCEEN, in PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x29887C0", Offset = "0x29877C0", VA = "0x1829887C0")]
		public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(IPEFFJIHFBP))]
	[LMNMHFHDONH(IPKPBIMLPOB.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class IPEFFJIHFBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer FAHBHODOFIG;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int BCBDBMHFMFJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x2B01480", Offset = "0x2B00480", VA = "0x182B01480")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public PDCHDHAOJMP[] IOJDKJEMHNM
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B014D0", Offset = "0x2B004D0", VA = "0x182B014D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
			public IPEFFJIHFBP(ActionBuffer OKFKCFDJEGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B01390", Offset = "0x2B00390", VA = "0x182B01390")]
			[CompilerGenerated]
			private PDCHDHAOJMP ACPPGFGFBFD(CPEGLNOCJGF KNOLDLABLMF)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class PDCHDHAOJMP : LHLKDMMNFKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer FAHBHODOFIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly CPEGLNOCJGF KNOLDLABLMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(KEIEEPAJBNC, string, object)> PGEAEBLBOHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private JDMFNNEOLIB NINBMPMOGGB;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int BCBDBMHFMFJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B03CE0", Offset = "0x2B02CE0", VA = "0x182B03CE0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(KEIEEPAJBNC, string, object)> LJFFKOJPADD
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B04170", Offset = "0x2B03170", VA = "0x182B04170")]
			public PDCHDHAOJMP(ActionBuffer OKFKCFDJEGF, CPEGLNOCJGF KNOLDLABLMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x2B04070", Offset = "0x2B03070", VA = "0x182B04070")]
			private string OBEJBNLCOLL(KEIEEPAJBNC KNDPILCJGBD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x2B03D30", Offset = "0x2B02D30", VA = "0x182B03D30")]
			private void JGMOEBJPLEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A2C140", Offset = "0x2A2B140", VA = "0x182A2C140", Slot = "4")]
			public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, [Optional] object KPJEGNGKPOH) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> APIGNLIODDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<CPEGLNOCJGF> HOHJEEPMOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly PGOKOKDBCMO IKDDBIADAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly MKLPHIINDDK JHBPCGGOFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly DPCIBBJGPEK JDJBDCDEPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool HBINDFILBHB;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public HNGGECHLFOA JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x2A67120", Offset = "0x2A66120", VA = "0x182A67120")]
			get
			{
				return default(HNGGECHLFOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x2A67330", Offset = "0x2A66330", VA = "0x182A67330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2A67CE0", Offset = "0x2A66CE0", VA = "0x182A67CE0")]
		public ActionBuffer(MKLPHIINDDK JHBPCGGOFEN, DPCIBBJGPEK JDJBDCDEPOJ, bool HBINDFILBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2A67780", Offset = "0x2A66780", VA = "0x182A67780")]
		public bool HIKJHBOEDNM(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2A673E0", Offset = "0x2A663E0", VA = "0x182A673E0")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2A67640", Offset = "0x2A66640", VA = "0x182A67640")]
		public CPEGLNOCJGF GJCNDKKNGGA(GBGICIPJHGM PGEAEBLBOHE, OIHIOHPKDOB GDBEDAHCFGJ, uint IFPAHELFCMC)
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2A679E0", Offset = "0x2A669E0", VA = "0x182A679E0")]
		public bool MMMGAIDGCKM(uint IFPAHELFCMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2A67450", Offset = "0x2A66450", VA = "0x182A67450")]
		public bool EPCLOIMDMLD(uint IFPAHELFCMC, out CPEGLNOCJGF IBCPLIFFFGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2A67810", Offset = "0x2A66810", VA = "0x182A67810")]
		public void IKDJMBCFKLN(CPEGLNOCJGF IBCPLIFFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2A66FE0", Offset = "0x2A65FE0", VA = "0x182A66FE0")]
		[Conditional("DEBUG_BUILD")]
		private void AIAIIPDAAGM(CPEGLNOCJGF IBCPLIFFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2A67160", Offset = "0x2A66160", VA = "0x182A67160")]
		private void BMCAJEODCKH(CPEGLNOCJGF NEPNHPOCKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2A67A10", Offset = "0x2A66A10", VA = "0x182A67A10")]
		private void OPPJEGDENAJ(JDMFNNEOLIB CIBDGPLFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2A67980", Offset = "0x2A66980", VA = "0x182A67980")]
		private void LDEDGPINLKB(CPEGLNOCJGF KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2A67270", Offset = "0x2A66270", VA = "0x182A67270")]
		private JDMFNNEOLIB CCKDNPEJCIA(CPEGLNOCJGF KNOLDLABLMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A67370", Offset = "0x2A66370", VA = "0x182A67370", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class PGOKOKDBCMO : LHLKDMMNFKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MKLPHIINDDK JHBPCGGOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly DPCIBBJGPEK JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private AIELFMMICMN ALJACNMOIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private JDMFNNEOLIB CMHHBKEOELE;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x67E6E0", Offset = "0x67D6E0", VA = "0x18067E6E0")]
	public PGOKOKDBCMO(MKLPHIINDDK JHBPCGGOFEN, DPCIBBJGPEK JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F31660", Offset = "0x2F30660", VA = "0x182F31660", Slot = "4")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> EOBNNANCHLF, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2980C30", Offset = "0x297FC30", VA = "0x182980C30")]
	public void ALPKNKNFCBE(KEIEEPAJBNC KNDPILCJGBD, ref JDMFNNEOLIB CIBDGPLFJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OBLIGMOAKKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct JDPFELICGMF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly OBLIGMOAKKF ICMEPOIJCJO;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x4141560", Offset = "0x4140560", VA = "0x184141560")]
		public JDPFELICGMF(OBLIGMOAKKF ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4141540", Offset = "0x4140540", VA = "0x184141540", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected GBGICIPJHGM PGEAEBLBOHE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GBGICIPJHGM LJFFKOJPADD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2972E70", Offset = "0x2971E70", VA = "0x182972E70")]
		get
		{
			return default(GBGICIPJHGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool JAAKCFCOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x29731D0", Offset = "0x29721D0", VA = "0x1829731D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2973370", Offset = "0x2972370", VA = "0x182973370")]
	public OBLIGMOAKKF(GBGICIPJHGM.BPAPEHLGNHK DOBAHHBACNO = GBGICIPJHGM.BPAPEHLGNHK.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2973190", Offset = "0x2972190", VA = "0x182973190")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2972EB0", Offset = "0x2971EB0", VA = "0x182972EB0")]
	public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x29732E0", Offset = "0x29722E0", VA = "0x1829732E0")]
	public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2972FB0", Offset = "0x2971FB0", VA = "0x182972FB0")]
	public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x29731E0", Offset = "0x29721E0", VA = "0x1829731E0")]
	public void OFKDPKABHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2973090", Offset = "0x2972090", VA = "0x182973090")]
	public void EFBCANIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2972FA0", Offset = "0x2971FA0", VA = "0x182972FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x29731A0", Offset = "0x29721A0", VA = "0x1829731A0")]
	public JDPFELICGMF FDMPPFDLEPC()
	{
		return default(JDPFELICGMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KEIEEPAJBNC : IComparable<KEIEEPAJBNC>, IEquatable<KEIEEPAJBNC>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly KEIEEPAJBNC KKELJKMFEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public AIELFMMICMN ALJACNMOIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public OEMFGOLGDMG DLFEJOALJGM;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DA70", Offset = "0x2C6CA70", VA = "0x182C6DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
	public KEIEEPAJBNC(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D8F0", Offset = "0x2C6C8F0", VA = "0x182C6D8F0")]
	public void EMHCMDMAIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D8B0", Offset = "0x2C6C8B0", VA = "0x182C6D8B0", Slot = "4")]
	public int CompareTo(KEIEEPAJBNC KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DAD0", Offset = "0x2C6CAD0", VA = "0x182C6DAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D950", Offset = "0x2C6C950", VA = "0x182C6D950", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D900", Offset = "0x2C6C900", VA = "0x182C6D900", Slot = "5")]
	public bool Equals(KEIEEPAJBNC KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D9F0", Offset = "0x2C6C9F0", VA = "0x182C6D9F0")]
	public static bool FHCNBCDBOFI(KEIEEPAJBNC JCHPGJLCOCJ, KEIEEPAJBNC GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DA80", Offset = "0x2C6CA80", VA = "0x182C6DA80")]
	public static bool LIEIJOJMABA(KEIEEPAJBNC JCHPGJLCOCJ, KEIEEPAJBNC GHMOJHOMMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DA30", Offset = "0x2C6CA30", VA = "0x182C6DA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[LMNMHFHDONH(IPKPBIMLPOB.History)]
	public class GatherPropertiesForUndelete : BMEAGCNBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private MKLPHIINDDK JHBPCGGOFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private AIELFMMICMN ALJACNMOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService FHBNDHEOPHO;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C61160", Offset = "0x2C60160", VA = "0x182C61160")]
		public void HJKKNDHLMHD(AIELFMMICMN ALJACNMOIMH, MKLPHIINDDK JHBPCGGOFEN, HistoryService FHBNDHEOPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C61270", Offset = "0x2C60270", VA = "0x182C61270", Slot = "4")]
		private void NPIFBOGEIJG(NDPPHEAPNHN FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, object KPJEGNGKPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class EKEMCCMMODF
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A812C0", Offset = "0x2A802C0", VA = "0x182A812C0")]
	public static void LBBGJEOJNPJ(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD, NGIENACHJHK IEIGAJLABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A813C0", Offset = "0x2A803C0", VA = "0x182A813C0")]
	public static void LFDAFCACKGI(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A81120", Offset = "0x2A80120", VA = "0x182A81120")]
	public static void BIODCEJHCND(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A81210", Offset = "0x2A80210", VA = "0x182A81210")]
	public static void KACCOFCDKLC(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A811C0", Offset = "0x2A801C0", VA = "0x182A811C0")]
	public static NGIENACHJHK FDFDCKBEJME(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
		return default(NGIENACHJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x395B710", Offset = "0x395A710", VA = "0x18395B710")]
	public static T LKAGKPIKGOL<T>(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x395B730", Offset = "0x395A730", VA = "0x18395B730")]
	public static T LKAGKPIKGOL<T>(ref JDMFNNEOLIB FILAKGLBGGA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A81170", Offset = "0x2A80170", VA = "0x182A81170")]
	public static NGIENACHJHK FDFDCKBEJME(ref JDMFNNEOLIB FILAKGLBGGA)
	{
		return default(NGIENACHJHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct GBGICIPJHGM : IEnumerable<KEIEEPAJBNC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum BPAPEHLGNHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct BKJFBPOHEIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly GBGICIPJHGM DEEJEKFIHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly OIHIOHPKDOB GDBEDAHCFGJ;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x413CC20", Offset = "0x413BC20", VA = "0x18413CC20")]
		public BKJFBPOHEIC(GBGICIPJHGM DEEJEKFIHBB, OIHIOHPKDOB GDBEDAHCFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x413C650", Offset = "0x413B650", VA = "0x18413C650")]
		public void IFDMEPFNMHD(NativeList<byte> KJHFBEBKBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x413C9E0", Offset = "0x413B9E0", VA = "0x18413C9E0")]
		private void NBGDCLNIHPH(KEIEEPAJBNC KNDPILCJGBD, ref AIDBFOLIHEH CKCBCCNOGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x413CA30", Offset = "0x413BA30", VA = "0x18413CA30")]
		private void PDGLNOJHNIK(KEIEEPAJBNC KNDPILCJGBD, ref AIDBFOLIHEH CKCBCCNOGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x413C8F0", Offset = "0x413B8F0", VA = "0x18413C8F0")]
		private NativeArray<byte> LALOIFEBCKM(NativeList<byte> KJHFBEBKBIB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x413C310", Offset = "0x413B310", VA = "0x18413C310")]
		private NativeArray<byte> CBCCOMIMNNO(NativeList<byte> KJHFBEBKBIB, int MFAHIHFAKKH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x413C400", Offset = "0x413B400", VA = "0x18413C400")]
		private int IEIHFHJIMKH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x413CAC0", Offset = "0x413BAC0", VA = "0x18413CAC0")]
		private bool PMOAOECEIJD(KEIEEPAJBNC KNDPILCJGBD, out NativeArray<byte> PMOHBILFOMG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HKFBBFGLMKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> FILAKGLBGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private GBGICIPJHGM DEEJEKFIHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly KEIEEPAJBNC JFBGEPNCFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int FHGIIAKFJFF;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x413FFA0", Offset = "0x413EFA0", VA = "0x18413FFA0")]
		internal HKFBBFGLMKO(GBGICIPJHGM DEEJEKFIHBB, KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x413FF00", Offset = "0x413EF00", VA = "0x18413FF00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x413FEA0", Offset = "0x413EEA0", VA = "0x18413FEA0")]
		public void FODALFDNBDN(NativeArray<byte> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x413FF30", Offset = "0x413EF30", VA = "0x18413FF30")]
		public void LNINOCPIKCC(NativeArray<byte> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x413FF90", Offset = "0x413EF90", VA = "0x18413FF90")]
		public void PDGLNOJHNIK(in PEKIEJLMCEO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2669370", Offset = "0x2668370", VA = "0x182669370")]
		public void PDGLNOJHNIK<T>(T DFEOJBAFBHE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x413FDD0", Offset = "0x413EDD0", VA = "0x18413FDD0")]
		private void BFMFGHCBCCL(int DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x413FD20", Offset = "0x413ED20", VA = "0x18413FD20")]
		private void BFMFGHCBCCL(in PEKIEJLMCEO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x413FE40", Offset = "0x413EE40", VA = "0x18413FE40")]
		private unsafe void BFMFGHCBCCL(void* BOLLPIGIHNO, int MFAHIHFAKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x413FEA0", Offset = "0x413EEA0", VA = "0x18413FEA0")]
		private void BFMFGHCBCCL(NativeArray<byte> PPLEFHADAKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct LCECGMGKOID : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private GBGICIPJHGM DEEJEKFIHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> FILAKGLBGGA;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x4142CB0", Offset = "0x4141CB0", VA = "0x184142CB0")]
		internal LCECGMGKOID(GBGICIPJHGM DEEJEKFIHBB, NativeArray<byte> FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x41429F0", Offset = "0x41419F0", VA = "0x1841429F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x4142A00", Offset = "0x4141A00", VA = "0x184142A00")]
		public NativeArray<byte> JAAOKGGFOAC(int MFAHIHFAKKH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x4142AC0", Offset = "0x4141AC0", VA = "0x184142AC0")]
		public NativeArray<byte> LIJGMJGJGPA()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x266A470", Offset = "0x2669470", VA = "0x18266A470")]
		public T PEAHPJAKBCE<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x4142BB0", Offset = "0x4141BB0", VA = "0x184142BB0")]
		public void PEAHPJAKBCE(in MELHFKPCLBG DFEOJBAFBHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct IKNCMIDMCBG : IEnumerator<KEIEEPAJBNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<KEIEEPAJBNC> DBOPJMNFJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int NPDGHPHAKDK;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public KEIEEPAJBNC JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x41414F0", Offset = "0x41404F0", VA = "0x1841414F0", Slot = "4")]
			get
			{
				return default(KEIEEPAJBNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x41414B0", Offset = "0x41404B0", VA = "0x1841414B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2E1A3B0", Offset = "0x2E193B0", VA = "0x182E1A3B0")]
		internal IKNCMIDMCBG(NativeList<KEIEEPAJBNC> PPLEFHADAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4141370", Offset = "0x4140370", VA = "0x184141370", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4141470", Offset = "0x4140470", VA = "0x184141470", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct LOJIIACCADF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int KBIEEBAONCK = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int AICFGKFCHKH = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int AFBAODPCNCF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> FILAKGLBGGA;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool CAJAJNAMICK
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x4143E30", Offset = "0x4142E30", VA = "0x184143E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int AIDNDNJDDHB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x4143DB0", Offset = "0x4142DB0", VA = "0x184143DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x4143CE0", Offset = "0x4142CE0", VA = "0x184143CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public BPAPEHLGNHK CHJLLPANBAM
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x4143E00", Offset = "0x4142E00", VA = "0x184143E00")]
			get
			{
				return default(BPAPEHLGNHK);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x4143D60", Offset = "0x4142D60", VA = "0x184143D60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool JAAKCFCOGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x4143E10", Offset = "0x4142E10", VA = "0x184143E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x4143DE0", Offset = "0x4142DE0", VA = "0x184143DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool EJMHJMLDIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x4143E20", Offset = "0x4142E20", VA = "0x184143E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x4143DC0", Offset = "0x4142DC0", VA = "0x184143DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4143E70", Offset = "0x4142E70", VA = "0x184143E70")]
		public LOJIIACCADF(BPAPEHLGNHK DOBAHHBACNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4143CF0", Offset = "0x4142CF0", VA = "0x184143CF0")]
		private int CIGAFCHFFML(int PNKNABOKANH, int GPDMPHJAHLC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4143D70", Offset = "0x4142D70", VA = "0x184143D70")]
		private void FAFPJPFNCCD(int PNKNABOKANH, int DFEOJBAFBHE, int GPDMPHJAHLC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4143D20", Offset = "0x4142D20", VA = "0x184143D20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int AAMHLDJEENL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int BJOHANIAEOI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly KEIEEPAJBNC PDPLDDEGCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<KEIEEPAJBNC, int> JCANNBCHDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<KEIEEPAJBNC> PGEAEBLBOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> KNDMAKMCMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> COFNFFMPJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> FILAKGLBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private LOJIIACCADF FHLNMMPFILI;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool JAAKCFCOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CA20", Offset = "0x2C5BA20", VA = "0x182C5CA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BMNPHBIFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C470", Offset = "0x2C5B470", VA = "0x182C5C470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int AIDNDNJDDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C460", Offset = "0x2C5B460", VA = "0x182C5C460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int GEFHGPICAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C5C600", Offset = "0x2C5B600", VA = "0x182C5C600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CA30", Offset = "0x2C5BA30", VA = "0x182C5CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C490", Offset = "0x2C5B490", VA = "0x182C5C490")]
	public static GBGICIPJHGM HJNGNBALKKN(BPAPEHLGNHK DOBAHHBACNO = BPAPEHLGNHK.Last, int CKGCBBOJNGO = 16, int MKPANIAACLN = 256)
	{
		return default(GBGICIPJHGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CC40", Offset = "0x2C5BC40", VA = "0x182C5CC40")]
	private GBGICIPJHGM(BPAPEHLGNHK DOBAHHBACNO, int CKGCBBOJNGO, int MKPANIAACLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C120", Offset = "0x2C5B120", VA = "0x182C5C120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C200", Offset = "0x2C5B200", VA = "0x182C5C200")]
	public HKFBBFGLMKO EKKBEDKPPDM(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(HKFBBFGLMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BF50", Offset = "0x2C5AF50", VA = "0x182C5BF50")]
	public LCECGMGKOID ACNKAENJBON(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(LCECGMGKOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C640", Offset = "0x2C5B640", VA = "0x182C5C640")]
	public bool MIPKHOAMFJL(KEIEEPAJBNC JFBGEPNCFEC, out LCECGMGKOID IGMJMLJDCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C0D0", Offset = "0x2C5B0D0", VA = "0x182C5C0D0")]
	public bool DACELNFABBJ(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CA70", Offset = "0x2C5BA70", VA = "0x182C5CA70")]
	public bool PKOFKKGEBLP(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C510", Offset = "0x2C5B510", VA = "0x182C5C510")]
	public void IJNNCGOPCBH(NativeList<byte> KJHFBEBKBIB, OIHIOHPKDOB GDBEDAHCFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x27EC2A0", Offset = "0x27EB2A0", VA = "0x1827EC2A0")]
	public T NAGKGPCIBKK<T>(KEIEEPAJBNC JFBGEPNCFEC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C380", Offset = "0x2C5B380", VA = "0x182C5C380")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C4D0", Offset = "0x2C5B4D0", VA = "0x182C5C4D0")]
	public IKNCMIDMCBG HPPJKDPBNFG()
	{
		return default(IKNCMIDMCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C830", Offset = "0x2C5B830", VA = "0x182C5C830")]
	private void MMLNIFNNNMI(KEIEEPAJBNC JFBGEPNCFEC, int FHGIIAKFJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C290", Offset = "0x2C5B290", VA = "0x182C5C290")]
	private void EMHCMDMAIBK(int NIKABAFFCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BFE0", Offset = "0x2C5AFE0", VA = "0x182C5BFE0")]
	private void APKIMBAIHMK(KEIEEPAJBNC JFBGEPNCFEC, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2253A10", Offset = "0x2252A10", VA = "0x182253A10")]
	private static T NAGKGPCIBKK<T>(NativeArray<byte> DBOPJMNFJMA, int PNKNABOKANH = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CB80", Offset = "0x2C5BB80", VA = "0x182C5CB80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CB40", Offset = "0x2C5BB40", VA = "0x182C5CB40", Slot = "4")]
	private IEnumerator<KEIEEPAJBNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class EJALMOLJKJG<T> : GAJBCDLDAEF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2006B20", Offset = "0x2005B20", VA = "0x182006B20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2006BB0", Offset = "0x2005BB0", VA = "0x182006BB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2006C20", Offset = "0x2005C20", VA = "0x182006C20")]
	public EJALMOLJKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2006A70", Offset = "0x2005A70", VA = "0x182006A70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	internal class CleanupRigidbodyExImpl : GAJBCDLDAEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EF40", Offset = "0x2A6DF40", VA = "0x182A6EF40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EFE0", Offset = "0x2A6DFE0", VA = "0x182A6EFE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class JKICMHHNALP : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery JMJGAOHNNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A930", Offset = "0x2C69930", VA = "0x182C6A930", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A980", Offset = "0x2C69980", VA = "0x182C6A980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AA10", Offset = "0x2C69A10", VA = "0x182C6AA10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public JKICMHHNALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal class KEEDAADGPFO : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService FMLOKJNJNDI;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D840", Offset = "0x2C6C840", VA = "0x182C6D840", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D890", Offset = "0x2C6C890", VA = "0x182C6D890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public KEEDAADGPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService MMKJPCINEBD;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DDD0", Offset = "0x2A7CDD0", VA = "0x182A7DDD0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DE20", Offset = "0x2A7CE20", VA = "0x182A7DE20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DEB0", Offset = "0x2A7CEB0", VA = "0x182A7DEB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[DEJAKMDKDPE(typeof(CullingBandService), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class CullingBandService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::LNAIBACCGLG<HAKDBPCBHEI>> HECABBCJCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2A785C0", Offset = "0x2A775C0", VA = "0x182A785C0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2A78550", Offset = "0x2A77550", VA = "0x182A78550")]
		public void GDCKDGGGFHA(global::LNAIBACCGLG<HAKDBPCBHEI> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2A780E0", Offset = "0x2A770E0", VA = "0x182A780E0")]
		public void EIHAMFJLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2A77F70", Offset = "0x2A76F70", VA = "0x182A77F70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2A78660", Offset = "0x2A77660", VA = "0x182A78660")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[DEJAKMDKDPE(typeof(CHJKDGGMOBG), new string[] { })]
	public class PhysicsService : COMOMFINKHP, BDDJKMOFDGN, CHJKDGGMOBG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly FBNJDMKEPCN NAAAPINMHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager MKHPDCKNNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private JEGLAIMIPKC KOJBCIMOFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService CJDOJFJGMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::IBOLLEGFEDA<CNFADDOPKLA> GMGFGLOLLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<PMFFIMLMCEJ, CNFADDOPKLA> PALKPHABGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x2984ED0", Offset = "0x2983ED0", VA = "0x182984ED0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x2984F70", Offset = "0x2983F70", VA = "0x182984F70", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x29850E0", Offset = "0x29840E0", VA = "0x1829850E0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2984A10", Offset = "0x2983A10", VA = "0x182984A10", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2984CB0", Offset = "0x2983CB0", VA = "0x182984CB0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2985010", Offset = "0x2984010", VA = "0x182985010", Slot = "8")]
		public bool KGNFPLCFKLA(PMFFIMLMCEJ GMOMNBJDADO, out Collider AMDPNFGBEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2985200", Offset = "0x2984200", VA = "0x182985200")]
		private void OEALKIEFBDG(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2984E10", Offset = "0x2983E10", VA = "0x182984E10", Slot = "9")]
		public void FGEMBDECDKJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[DEJAKMDKDPE(typeof(IGKHNFEAAFE), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class RbexService : COMOMFINKHP, IGKHNFEAAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private JLADNPOGKFE CLDAEDJHPFL;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x298BF00", Offset = "0x298AF00", VA = "0x18298BF00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x298CE70", Offset = "0x298BE70", VA = "0x18298CE70", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x298C760", Offset = "0x298B760", VA = "0x18298C760", Slot = "6")]
		public KPOFKKHEJCB JKJNLPOJMCI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x298D740", Offset = "0x298C740", VA = "0x18298D740", Slot = "5")]
		public void PGDLPINEDOH(PMFFIMLMCEJ GMOMNBJDADO, KPOFKKHEJCB DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x298BEA0", Offset = "0x298AEA0", VA = "0x18298BEA0", Slot = "34")]
		public CollisionDetectionMode GCKLEGGGPKJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x298C5A0", Offset = "0x298B5A0", VA = "0x18298C5A0", Slot = "35")]
		public void JCLACKIFBGI(PMFFIMLMCEJ GMOMNBJDADO, CollisionDetectionMode DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x298AC80", Offset = "0x2989C80", VA = "0x18298AC80", Slot = "36")]
		public BJLMKDOLGOG BJAJLGJALCK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(BJLMKDOLGOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x298B520", Offset = "0x298A520", VA = "0x18298B520", Slot = "37")]
		public void DEDIIFAAILE(PMFFIMLMCEJ GMOMNBJDADO, BJLMKDOLGOG DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x298AC20", Offset = "0x2989C20", VA = "0x18298AC20", Slot = "38")]
		public bool BFNMHLMHHCK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x298C610", Offset = "0x298B610", VA = "0x18298C610", Slot = "39")]
		public void JDEBOCLHDMN(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x298CAE0", Offset = "0x298BAE0", VA = "0x18298CAE0", Slot = "40")]
		public PMFFIMLMCEJ LGNFHDEKAND(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x298CA60", Offset = "0x298BA60", VA = "0x18298CA60", Slot = "41")]
		public void LEIFGCFKGAD(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x298B990", Offset = "0x298A990", VA = "0x18298B990", Slot = "42")]
		public PMFFIMLMCEJ EKMEMACGALM(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x298BD90", Offset = "0x298AD90", VA = "0x18298BD90", Slot = "43")]
		public void GBLKBIAEIPL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x298C2A0", Offset = "0x298B2A0", VA = "0x18298C2A0", Slot = "7")]
		public void HLPNFHFHFFD(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x298D7F0", Offset = "0x298C7F0", VA = "0x18298D7F0", Slot = "8")]
		public void PGODIABCAMB(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x298AAB0", Offset = "0x2989AB0", VA = "0x18298AAB0", Slot = "9")]
		public int APKIBECFENN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x298AE80", Offset = "0x2989E80", VA = "0x18298AE80", Slot = "10")]
		public PMFFIMLMCEJ CCOFDHEFLND(PMFFIMLMCEJ GMOMNBJDADO, int NPDGHPHAKDK)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x298BBA0", Offset = "0x298ABA0", VA = "0x18298BBA0", Slot = "11")]
		public void EPJFNIMDAHK(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x298BF20", Offset = "0x298AF20", VA = "0x18298BF20", Slot = "12")]
		public void GPALNFINBIF(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x298CD80", Offset = "0x298BD80", VA = "0x18298CD80", Slot = "13")]
		public void MJAHAPBICKL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x298CFA0", Offset = "0x298BFA0", VA = "0x18298CFA0", Slot = "14")]
		public bool MNGDIFLMGOF(PMFFIMLMCEJ GMOMNBJDADO, out PMFFIMLMCEJ DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x298CF20", Offset = "0x298BF20", VA = "0x18298CF20", Slot = "15")]
		public void MNAJABLGAAL(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x298B650", Offset = "0x298A650", VA = "0x18298B650", Slot = "16")]
		public bool DNJPCIBLNPH(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x298C960", Offset = "0x298B960", VA = "0x18298C960", Slot = "17")]
		public void KHKMDKGMOBH(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x298B2C0", Offset = "0x298A2C0", VA = "0x18298B2C0", Slot = "18")]
		public bool CMINKOCEACE(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x298C680", Offset = "0x298B680", VA = "0x18298C680", Slot = "26")]
		public float3 JGCCJPPGFCD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x298B8B0", Offset = "0x298A8B0", VA = "0x18298B8B0", Slot = "27")]
		public void DPCKOEOCFCL(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x298A680", Offset = "0x2989680", VA = "0x18298A680", Slot = "28")]
		public float ACIPPEFEKMJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x298DA50", Offset = "0x298CA50", VA = "0x18298DA50", Slot = "29")]
		public void PMKNPGJDFNG(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x298AA50", Offset = "0x2989A50", VA = "0x18298AA50", Slot = "30")]
		public float ANJMPDPCMFI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x298D6D0", Offset = "0x298C6D0", VA = "0x18298D6D0", Slot = "31")]
		public void PFBMLJPNMDF(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x298D670", Offset = "0x298C670", VA = "0x18298D670", Slot = "32")]
		public bool PAGLNKEOMGA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x298B840", Offset = "0x298A840", VA = "0x18298B840", Slot = "33")]
		public void DONDAIPJIBM(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x298ABA0", Offset = "0x2989BA0", VA = "0x18298ABA0", Slot = "19")]
		public void BFJIKAMIIJF(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x298D4A0", Offset = "0x298C4A0", VA = "0x18298D4A0", Slot = "20")]
		public bool OJIBAKHGAKB(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x298D3A0", Offset = "0x298C3A0", VA = "0x18298D3A0", Slot = "21")]
		public void ODHHHALHCBO(PMFFIMLMCEJ GMOMNBJDADO, quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x298B160", Offset = "0x298A160", VA = "0x18298B160", Slot = "22")]
		public bool CIMFPJBBANB(PMFFIMLMCEJ GMOMNBJDADO, out quaternion DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x298A7E0", Offset = "0x29897E0", VA = "0x18298A7E0", Slot = "23")]
		public bool AIDPFAEBDNN(PMFFIMLMCEJ GMOMNBJDADO, out float3 HMDELLKKDMD, out quaternion OPDKACIDFEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x298CC30", Offset = "0x298BC30", VA = "0x18298CC30", Slot = "44")]
		public IGGCCDKGNJO MCCLOPCMAAB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(IGGCCDKGNJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x298C230", Offset = "0x298B230", VA = "0x18298C230", Slot = "45")]
		public void HKDLBEJCJHB(PMFFIMLMCEJ GMOMNBJDADO, IGGCCDKGNJO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x298BD00", Offset = "0x298AD00", VA = "0x18298BD00", Slot = "72")]
		public void FKLEAMEDKAJ(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x298B5C0", Offset = "0x298A5C0", VA = "0x18298B5C0", Slot = "73")]
		public void DIMAGHMNMFL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x298C1B0", Offset = "0x298B1B0", VA = "0x18298C1B0", Slot = "74")]
		public bool HFMHKCJAKON(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x298D410", Offset = "0x298C410", VA = "0x18298D410", Slot = "81")]
		public void ODKCMFJFNOK(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x298B7B0", Offset = "0x298A7B0", VA = "0x18298B7B0", Slot = "82")]
		public void DOKGNMHHIAA(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x298B4A0", Offset = "0x298A4A0", VA = "0x18298B4A0", Slot = "83")]
		public bool DDIKJJLKDDL(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x298C860", Offset = "0x298B860", VA = "0x18298C860", Slot = "84")]
		public IEnumerable<object> KHJLAENAPJA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x298D9F0", Offset = "0x298C9F0", VA = "0x18298D9F0", Slot = "46")]
		public bool PLNCHPBJGOO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x298A620", Offset = "0x2989620", VA = "0x18298A620", Slot = "47")]
		public void ABGFCJLKAJF(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x298B010", Offset = "0x298A010", VA = "0x18298B010", Slot = "48")]
		public bool CGJDAIGGEIN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x298D600", Offset = "0x298C600", VA = "0x18298D600", Slot = "49")]
		public void ONPDNCGGHMK(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x298CD20", Offset = "0x298BD20", VA = "0x18298CD20", Slot = "50")]
		public bool MGPBHHGHMOA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x298BC90", Offset = "0x298AC90", VA = "0x18298BC90", Slot = "51")]
		public void FIBJIMFJADM(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x298B930", Offset = "0x298A930", VA = "0x18298B930", Slot = "52")]
		public RigidbodyConstraints EKCICLFGJAO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x298A6E0", Offset = "0x29896E0", VA = "0x18298A6E0", Slot = "53")]
		public void ACPFIOJBMEL(PMFFIMLMCEJ GMOMNBJDADO, RigidbodyConstraints DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x298B070", Offset = "0x298A070", VA = "0x18298B070", Slot = "54")]
		public float CHBHEJEGMLP(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x298D230", Offset = "0x298C230", VA = "0x18298D230", Slot = "55")]
		public void NGOFOMINHIA(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x298D310", Offset = "0x298C310", VA = "0x18298D310", Slot = "56")]
		public float OAAKAIPADLD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x298D2A0", Offset = "0x298C2A0", VA = "0x18298D2A0", Slot = "57")]
		public void NHJABKMKICN(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x298D990", Offset = "0x298C990", VA = "0x18298D990", Slot = "58")]
		public bool PLJMLMEOMLA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x298AE10", Offset = "0x2989E10", VA = "0x18298AE10", Slot = "59")]
		public void BPKOEKCFJBL(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x298D100", Offset = "0x298C100", VA = "0x18298D100", Slot = "60")]
		public bool MOLLAFHIGGE(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x298C7F0", Offset = "0x298B7F0", VA = "0x18298C7F0", Slot = "61")]
		public void KAFHBCLGIJG(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x298ADB0", Offset = "0x2989DB0", VA = "0x18298ADB0", Slot = "62")]
		public int BPEJICCPBIP(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x298D1C0", Offset = "0x298C1C0", VA = "0x18298D1C0", Slot = "63")]
		public void NGJBKBDELCO(PMFFIMLMCEJ GMOMNBJDADO, int DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x298C3B0", Offset = "0x298B3B0", VA = "0x18298C3B0", Slot = "64")]
		public Rigidbody IGBEBCNCEDD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x298BA40", Offset = "0x298AA40", VA = "0x18298BA40", Slot = "65")]
		public void EOGNNLEGICC(PMFFIMLMCEJ GMOMNBJDADO, Rigidbody DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x298B0D0", Offset = "0x298A0D0", VA = "0x18298B0D0", Slot = "75")]
		public void CHFCCKGMKCB(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x298BE10", Offset = "0x298AE10", VA = "0x18298BE10", Slot = "76")]
		public void GBLPAFKEPJK(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x298B420", Offset = "0x298A420", VA = "0x18298B420", Slot = "77")]
		public bool DCLBPMGCAGD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x298CC90", Offset = "0x298BC90", VA = "0x18298CC90", Slot = "66")]
		public object MCGDPEDPLMI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x298C440", Offset = "0x298B440", VA = "0x18298C440", Slot = "67")]
		public void JAMCIKOKEDK(PMFFIMLMCEJ GMOMNBJDADO, object DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x298AD20", Offset = "0x2989D20", VA = "0x18298AD20", Slot = "68")]
		public object BNCBJFAECFN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x298C050", Offset = "0x298B050", VA = "0x18298C050", Slot = "69")]
		public void HCHKLGEEEAL(PMFFIMLMCEJ GMOMNBJDADO, object DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x298C700", Offset = "0x298B700", VA = "0x18298C700", Slot = "70")]
		public float JJAEGIJLPNE(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x298AFA0", Offset = "0x2989FA0", VA = "0x18298AFA0", Slot = "71")]
		public void CFJKKEECEOP(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x298A750", Offset = "0x2989750", VA = "0x18298A750", Slot = "78")]
		public void AEJMHKDKBAL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x298D900", Offset = "0x298C900", VA = "0x18298D900", Slot = "79")]
		public void PKDEHKAGOGL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x298C9E0", Offset = "0x298B9E0", VA = "0x18298C9E0", Slot = "80")]
		public bool LDLNPHFEHFF(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x298CE10", Offset = "0x298BE10", VA = "0x18298CE10", Slot = "24")]
		public void MLIMBIPMNDK(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x298D160", Offset = "0x298C160", VA = "0x18298D160", Slot = "25")]
		public void NCILAAKGOBA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3C60580", Offset = "0x3C5F580", VA = "0x183C60580")]
		private void KJNHLIAGBNK<T>(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3C603A0", Offset = "0x3C5F3A0", VA = "0x183C603A0")]
		private bool FPJPCKNMOJP<T>(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3C602E0", Offset = "0x3C5F2E0", VA = "0x183C602E0")]
		private void FAHLDBEBGON<T>(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3C60400", Offset = "0x3C5F400", VA = "0x183C60400")]
		private bool KFLOGKOFLIL<TC, TV>(PMFFIMLMCEJ GMOMNBJDADO, Func<TC, TV> ABAJKNEIKOD, out TV DFEOJBAFBHE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3C60260", Offset = "0x3C5F260", VA = "0x183C60260")]
		private bool KFLOGKOFLIL<T>(PMFFIMLMCEJ GMOMNBJDADO, out T DFEOJBAFBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FD50", Offset = "0x3C5ED50", VA = "0x183C5FD50")]
		private T ACGOAAPFFJB<T>(PMFFIMLMCEJ GMOMNBJDADO) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3C60C30", Offset = "0x3C5FC30", VA = "0x183C60C30")]
		private void LGMDHOFNAIM<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3C605D0", Offset = "0x3C5F5D0", VA = "0x183C605D0")]
		private void KKPFOIBBLFK<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3C60260", Offset = "0x3C5F260", VA = "0x183C60260")]
		private bool DJONOMKPGEP<T>(PMFFIMLMCEJ GMOMNBJDADO, out T DFEOJBAFBHE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3C60340", Offset = "0x3C5F340", VA = "0x183C60340")]
		private T FDNIFGCIJJE<T>(PMFFIMLMCEJ GMOMNBJDADO) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3C60260", Offset = "0x3C5F260", VA = "0x183C60260")]
		private void FEOEINAMFIL<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3C61180", Offset = "0x3C60180", VA = "0x183C61180")]
		private void OLJAMHBPJML<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x298D370", Offset = "0x298C370", VA = "0x18298D370")]
		private PMFFIMLMCEJ OBAFGPPPDCA(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x298CB60", Offset = "0x298BB60", VA = "0x18298CB60")]
		private DynamicBuffer<Entity> MBJMMKNKPAA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3C601A0", Offset = "0x3C5F1A0", VA = "0x183C601A0")]
		private void DCCBIIPKPPH<T>(PMFFIMLMCEJ GMOMNBJDADO, object DFEOJBAFBHE, Func<object, T> ABAJKNEIKOD) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void JGMOEBJPLEH<T>(ref global::JAGLGPBNCCL<T> BHBEGJLFINL) where T : struct, ADNHFABDAIG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void JGMOEBJPLEH<TC, TV>(ref global::LIFNMLFFFJC<TC, TV> BHBEGJLFINL) where TC : struct, ADNHFABDAIG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	[DEJAKMDKDPE(typeof(KinematicSleepChangeService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class KinematicSleepChangeService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KELCLPBDCMB : IEnumerable<KPOFKKHEJCB>, IEnumerable, IEnumerator<KPOFKKHEJCB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private KPOFKKHEJCB <>2__current;

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
			private KPOFKKHEJCB System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public KELCLPBDCMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x41425E0", Offset = "0x41415E0", VA = "0x1841425E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x41422A0", Offset = "0x41412A0", VA = "0x1841422A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x4142660", Offset = "0x4141660", VA = "0x184142660")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x41425A0", Offset = "0x41415A0", VA = "0x1841425A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x41424F0", Offset = "0x41414F0", VA = "0x1841424F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KPOFKKHEJCB> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x41424F0", Offset = "0x41414F0", VA = "0x1841424F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> FMEGJNEFCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FA10", Offset = "0x2C6EA10", VA = "0x182C6FA10", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F8F0", Offset = "0x2C6E8F0", VA = "0x182C6F8F0")]
		public void GDCKDGGGFHA(NativeArray<Entity> BNEBECKGGLP, bool HFOHPLOHMOM, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F650", Offset = "0x2C6E650", VA = "0x182C6F650")]
		public void EIHAMFJLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FA60", Offset = "0x2C6EA60", VA = "0x182C6FA60")]
		private void ODPOMDDJAOM(NativeArray<Entity> BNEBECKGGLP, bool HFOHPLOHMOM, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F860", Offset = "0x2C6E860", VA = "0x182C6F860")]
		[IteratorStateMachine(typeof(KELCLPBDCMB))]
		private IEnumerable<KPOFKKHEJCB> ELKOJDHGNAN(NativeArray<Entity> BNEBECKGGLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F500", Offset = "0x2C6E500", VA = "0x182C6F500", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C70270", Offset = "0x2C6F270", VA = "0x182C70270")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[DEJAKMDKDPE(typeof(OEKGHEEACHJ), new string[] { })]
public class OLHJJDMGFKL : OEKGHEEACHJ, IEnumerable<ONEPLGLDGPM>, IEnumerable, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[GNFGKNINDPI]
	private GFKIJDOEHLD JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> AEMIIPGJBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private KMCBCJAGIFI MJMHKKBFMPC;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x29738D0", Offset = "0x29728D0", VA = "0x1829738D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ONEPLGLDGPM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x29738F0", Offset = "0x29728F0", VA = "0x1829738F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public ONEPLGLDGPM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x29738F0", Offset = "0x29728F0", VA = "0x1829738F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x29740F0", Offset = "0x29730F0", VA = "0x1829740F0", Slot = "11")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2973DD0", Offset = "0x2972DD0", VA = "0x182973DD0", Slot = "12")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2973E50", Offset = "0x2972E50", VA = "0x182973E50")]
	private void NDGLNNEABBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x13FC050", Offset = "0x13FB050", VA = "0x1813FC050")]
	private string HINLODFBECH(string IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2973CF0", Offset = "0x2972CF0", VA = "0x182973CF0", Slot = "7")]
	public ONEPLGLDGPM MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2973A40", Offset = "0x2972A40", VA = "0x182973A40")]
	private bool KNGJMMCCCGD(Type KKBMLPHFFPJ, string IADPDEAGFAB, out ONEPLGLDGPM DEIOLBFJFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2973930", Offset = "0x2972930", VA = "0x182973930", Slot = "8")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2973910", Offset = "0x2972910", VA = "0x182973910", Slot = "9")]
	public IEnumerator<ONEPLGLDGPM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2973910", Offset = "0x2972910", VA = "0x182973910", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2974140", Offset = "0x2973140", VA = "0x182974140")]
	public OLHJJDMGFKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DefaultMember("Item")]
public interface OIHIOHPKDOB
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGGLEPHOHDG(OEMFGOLGDMG KCHLIHHPAKF, out int BDHBBDMMOKG);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[DEJAKMDKDPE(typeof(OIHIOHPKDOB), new string[] { })]
public class FDEPPPFKNNA : COMOMFINKHP, BDDJKMOFDGN, OIHIOHPKDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[GNFGKNINDPI]
	private DPCIBBJGPEK JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<OEMFGOLGDMG, int> JGEEJIICEPH;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C58540", Offset = "0x2C57540", VA = "0x182C58540", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C584C0", Offset = "0x2C574C0", VA = "0x182C584C0", Slot = "6")]
	public bool BGGLEPHOHDG(OEMFGOLGDMG KCHLIHHPAKF, out int BDHBBDMMOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C58810", Offset = "0x2C57810", VA = "0x182C58810", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C58530", Offset = "0x2C57530", VA = "0x182C58530", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C585A0", Offset = "0x2C575A0", VA = "0x182C585A0")]
	private void IKOPIEDCKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C58870", Offset = "0x2C57870", VA = "0x182C58870")]
	public FDEPPPFKNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DEJAKMDKDPE(typeof(DPCIBBJGPEK), new string[] { })]
[DefaultMember("Item")]
public class JLDFIMHBGIH : DPCIBBJGPEK, IEnumerable<FOINMHEHJED>, IEnumerable, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, LHLKDMMNFKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[GNFGKNINDPI]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[GNFGKNINDPI]
	private OEKGHEEACHJ BGLDIAJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private FOINMHEHJED[] DMPHPKMNDBL;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C6ACE0", Offset = "0x2C69CE0", VA = "0x182C6ACE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FOINMHEHJED PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C6ACA0", Offset = "0x2C69CA0", VA = "0x182C6ACA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public FOINMHEHJED PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C6ACA0", Offset = "0x2C69CA0", VA = "0x182C6ACA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "10")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B110", Offset = "0x2C6A110", VA = "0x182C6B110", Slot = "11")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "12")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AFE0", Offset = "0x2C69FE0", VA = "0x182C6AFE0", Slot = "6")]
	public FOINMHEHJED MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AF10", Offset = "0x2C69F10", VA = "0x182C6AF10", Slot = "7")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AE30", Offset = "0x2C69E30", VA = "0x182C6AE30", Slot = "8")]
	public IEnumerator<FOINMHEHJED> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B3B0", Offset = "0x2C6A3B0", VA = "0x182C6B3B0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x27AFA60", Offset = "0x27AEA60", VA = "0x1827AFA60", Slot = "13")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6ACF0", Offset = "0x2C69CF0", VA = "0x182C6ACF0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JLDFIMHBGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6ACA0", Offset = "0x2C69CA0", VA = "0x182C6ACA0")]
	[CompilerGenerated]
	private FOINMHEHJED APHFGKIFPLM(int MNBBHFLLBID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DEJAKMDKDPE(typeof(MFDIJJOFCMP), new string[] { })]
[DefaultMember("Item")]
public class KBILICJHJGK : MFDIJJOFCMP, IEnumerable<NOLDFLLDJKB>, IEnumerable, COMOMFINKHP, BDDJKMOFDGN, LHLKDMMNFKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[GNFGKNINDPI]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[GNFGKNINDPI]
	private OEKGHEEACHJ BGLDIAJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NOLDFLLDJKB[] DMPHPKMNDBL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C6F0", Offset = "0x2C6B6F0", VA = "0x182C6C6F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public NOLDFLLDJKB PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C480", Offset = "0x2C6B480", VA = "0x182C6C480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public NOLDFLLDJKB PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C480", Offset = "0x2C6B480", VA = "0x182C6C480", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CAE0", Offset = "0x2C6BAE0", VA = "0x182C6CAE0", Slot = "9")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C490", Offset = "0x2C6B490", VA = "0x182C6C490", Slot = "10")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CB50", Offset = "0x2C6BB50", VA = "0x182C6CB50")]
	private NOLDFLLDJKB PEALGHEOHBP(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C9C0", Offset = "0x2C6B9C0", VA = "0x182C6C9C0", Slot = "6")]
	public NOLDFLLDJKB MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C8F0", Offset = "0x2C6B8F0", VA = "0x182C6C8F0", Slot = "14")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C7E0", Offset = "0x2C6B7E0", VA = "0x182C6C7E0", Slot = "7")]
	public IEnumerator<NOLDFLLDJKB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C7E0", Offset = "0x2C6B7E0", VA = "0x182C6C7E0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x27CD3C0", Offset = "0x27CC3C0", VA = "0x1827CD3C0", Slot = "11")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C740", Offset = "0x2C6B740", VA = "0x182C6C740", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KBILICJHJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C480", Offset = "0x2C6B480", VA = "0x182C6C480")]
	[CompilerGenerated]
	private NOLDFLLDJKB APHFGKIFPLM(int MNBBHFLLBID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(GFKIJDOEHLD), new string[] { })]
internal class GFKIJDOEHLD : COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private OEKGHEEACHJ BGLDIAJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private MFDIJJOFCMP JOMJILLPIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private DPCIBBJGPEK GMMLOICCBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::BOONDFDEOBC<PGIKEAFDIOH> BAEHHBGAGMM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public KMCBCJAGIFI HHEDNGEJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x685590", Offset = "0x684590", VA = "0x180685590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D630", Offset = "0x2C5C630", VA = "0x182C5D630", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D470", Offset = "0x2C5C470", VA = "0x182C5D470")]
	private void IBGHGKLPMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2258310", Offset = "0x2257310", VA = "0x182258310")]
	public T NKDDKAPKFDH<T>() where T : PGIKEAFDIOH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D560", Offset = "0x2C5C560", VA = "0x182C5D560")]
	public ONEPLGLDGPM JLJIHAFKOHC(ELBABKAKAAC IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::IBOLLEGFEDA<T> JLJIHAFKOHC<T>(ELBABKAKAAC IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D3A0", Offset = "0x2C5C3A0", VA = "0x182C5D3A0")]
	public NOLDFLLDJKB CHNOAICCDFL(ELBABKAKAAC IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2258290", Offset = "0x2257290", VA = "0x182258290")]
	public global::GEBDEPLDOED<T> CHNOAICCDFL<T>(ELBABKAKAAC IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D2D0", Offset = "0x2C5C2D0", VA = "0x182C5D2D0")]
	public FOINMHEHJED BPONHEAKNDF(ELBABKAKAAC IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::NCADOIFIPPP<T> BPONHEAKNDF<T>(ELBABKAKAAC IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GFKIJDOEHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class KHEEKPEKKDG
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x256B750", Offset = "0x256A750", VA = "0x18256B750")]
	public static global::IBOLLEGFEDA<T> JLJIHAFKOHC<T>(this GFKIJDOEHLD KJBBHHLPGKO, global::KBOIOIDENFM<T> IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::GEBDEPLDOED<T> CHNOAICCDFL<T>(this GFKIJDOEHLD KJBBHHLPGKO, global::KBOIOIDENFM<T> IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::NCADOIFIPPP<T> BPONHEAKNDF<T>(this GFKIJDOEHLD KJBBHHLPGKO, global::KBOIOIDENFM<T> IADPDEAGFAB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
[DEJAKMDKDPE(typeof(ABPHPIGFOEG), new string[] { })]
public class ABPHPIGFOEG : COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private MKLPHIINDDK JHBPCGGOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private OEMFGOLGDMG[] FOPEHNOKLIJ;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A64E50", Offset = "0x2A63E50", VA = "0x182A64E50", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2A64D30", Offset = "0x2A63D30", VA = "0x182A64D30")]
	public void JFGJEPFBPOK(AIELFMMICMN CDEOFEMHEEC, bool GKIJPPGHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ABPHPIGFOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DEJAKMDKDPE(typeof(ILCPNKLEMDC), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
public sealed class ILCPNKLEMDC : COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LELJDLHNNGA : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
		[DebuggerHidden]
		public LELJDLHNNGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x41430E0", Offset = "0x41420E0", VA = "0x1841430E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x4142D30", Offset = "0x4141D30", VA = "0x184142D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x4143160", Offset = "0x4142160", VA = "0x184143160")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x41430A0", Offset = "0x41420A0", VA = "0x1841430A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x4143010", Offset = "0x4142010", VA = "0x184143010", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x4143010", Offset = "0x4142010", VA = "0x184143010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string GNCAAGFJDNC = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, FAKHEKJICGB> LDBDPFLLIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> LGPCOOOCAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> AAPBAEGCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private MFDIJJOFCMP JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private HBFLPONDKFF OLPNBPCMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private CGJFLAGLGMG LHAACBBCHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::BBJCJNAHHAJ<FAKHEKJICGB> GKKKNBDHPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject LEDEMIBPAHC;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2C68B40", Offset = "0x2C67B40", VA = "0x182C68B40", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2C675C0", Offset = "0x2C665C0", VA = "0x182C675C0", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2C67900", Offset = "0x2C66900", VA = "0x182C67900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2C677F0", Offset = "0x2C667F0", VA = "0x182C677F0")]
	private void CNGFICGEGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2C686C0", Offset = "0x2C676C0", VA = "0x182C686C0")]
	internal void JCDOKIFEMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2C684E0", Offset = "0x2C674E0", VA = "0x182C684E0")]
	private void IJJKMHNDGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2C67800", Offset = "0x2C66800", VA = "0x182C67800")]
	private void DNNAJHLHFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2C68AF0", Offset = "0x2C67AF0", VA = "0x182C68AF0")]
	[IteratorStateMachine(typeof(LELJDLHNNGA))]
	private IEnumerable<RRCustomPropTag> MJFJLDLJOOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2C67AA0", Offset = "0x2C66AA0", VA = "0x182C67AA0")]
	private void EJEEMFGLAHI(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2C68C10", Offset = "0x2C67C10", VA = "0x182C68C10")]
	private void MNFGPLMIANE(SerializableGuid FBKLHONPMNF, GameObject NCAOMIEGHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2C67F70", Offset = "0x2C66F70", VA = "0x182C67F70")]
	private void FFAADBDDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2C68300", Offset = "0x2C67300", VA = "0x182C68300")]
	private bool GKJNKFNPMAG(FAKHEKJICGB MOBOLDJMLON, Transform ICMEPOIJCJO, out GameObject OMPFLELLCCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2C67F20", Offset = "0x2C66F20", VA = "0x182C67F20")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2C68D50", Offset = "0x2C67D50", VA = "0x182C68D50")]
	public ILCPNKLEMDC()
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
		public SerializableGuid KHPJKBEKBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x298A530", Offset = "0x2989530", VA = "0x18298A530")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DEJAKMDKDPE(typeof(FFPHAHHIPFK), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
public class FFPHAHHIPFK : COMOMFINKHP
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string HIDHGGAFILG = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService EFOAKEMFNMA;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2C588F0", Offset = "0x2C578F0", VA = "0x182C588F0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FFPHAHHIPFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
[DEJAKMDKDPE(typeof(MBLFNJNHCKI), new string[] { })]
public class MBLFNJNHCKI : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[GNFGKNINDPI]
	private EnableComponentSystemsInScope JLJOAPNOOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[GNFGKNINDPI]
	private SceneService EFOAKEMFNMA;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x296BCA0", Offset = "0x296ACA0", VA = "0x18296BCA0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x296BC60", Offset = "0x296AC60", VA = "0x18296BC60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x296BD10", Offset = "0x296AD10", VA = "0x18296BD10")]
	private void OFHLOHNGDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x296BD30", Offset = "0x296AD30", VA = "0x18296BD30")]
	private void PIJHLBBGHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MBLFNJNHCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DEJAKMDKDPE(typeof(KHAPNLPCPDI), new string[] { })]
public class LPADBHECNLI : COMOMFINKHP, BDDJKMOFDGN, KHAPNLPCPDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private BCIOKJKBEBJ NJHJPKKCNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private KGDDANOKKFF EAHPAMJDCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService CJDOJFJGMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem AKKIINAMGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int HLHNPGHLBMB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool MMADCFJFMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2C71A90", Offset = "0x2C70A90", VA = "0x182C71A90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public PMFFIMLMCEJ EIDOMAMADAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2C71F40", Offset = "0x2C70F40", VA = "0x182C71F40", Slot = "9")]
		get
		{
			return default(PMFFIMLMCEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2C71BF0", Offset = "0x2C70BF0", VA = "0x182C71BF0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public BDCNBKPMJEP KLILMAOCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2C71B30", Offset = "0x2C70B30", VA = "0x182C71B30", Slot = "11")]
		get
		{
			return default(BDCNBKPMJEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2C71BF0", Offset = "0x2C70BF0", VA = "0x182C71BF0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BDCNBKPMJEP EDNNBMNIIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2C72280", Offset = "0x2C71280", VA = "0x182C72280", Slot = "13")]
		get
		{
			return default(BDCNBKPMJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint AJIOIJHGPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2C72340", Offset = "0x2C71340", VA = "0x182C72340")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event OILFJMMGMAP DMHOOCIGLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2C72B00", Offset = "0x2C71B00", VA = "0x182C72B00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2C72620", Offset = "0x2C71620", VA = "0x182C72620", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2C72A30", Offset = "0x2C71A30", VA = "0x182C72A30", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2C71DA0", Offset = "0x2C70DA0", VA = "0x182C71DA0", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2C721D0", Offset = "0x2C711D0", VA = "0x182C721D0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2C726C0", Offset = "0x2C716C0", VA = "0x182C726C0")]
	private void LIBMHDBLCHL(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2C72510", Offset = "0x2C71510", VA = "0x182C72510", Slot = "14")]
	public PMFFIMLMCEJ IHGCMJMELMP(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2C72410", Offset = "0x2C71410", VA = "0x182C72410", Slot = "15")]
	public bool GOHPGPBBEBL(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB, out PMFFIMLMCEJ OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2C71C10", Offset = "0x2C70C10", VA = "0x182C71C10", Slot = "16")]
	public void BPDEEDEBJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2C723F0", Offset = "0x2C713F0", VA = "0x182C723F0", Slot = "17")]
	public void GLGJICACCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2C71FE0", Offset = "0x2C70FE0", VA = "0x182C71FE0", Slot = "18")]
	public bool CLCKHCOLFEG(PMFFIMLMCEJ IBCPLIFFFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2C728C0", Offset = "0x2C718C0", VA = "0x182C728C0")]
	private void MHMICLAEMEA(PMFFIMLMCEJ JKLFAAILIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LPADBHECNLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DEJAKMDKDPE(typeof(DLPNOHDEIMB), new string[] { })]
public class KPPGOKDFPBI : COMOMFINKHP, DLPNOHDEIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F410", Offset = "0x2C6E410", VA = "0x182C6F410", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F490", Offset = "0x2C6E490", VA = "0x182C6F490", Slot = "5")]
	public void NDHLGLINELI(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x256F990", Offset = "0x256E990", VA = "0x18256F990")]
	private void FAFPJPFNCCD<T>(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KPPGOKDFPBI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DEJAKMDKDPE(typeof(GEKCJJABACO), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.RenderEffects)]
	public class SelectionService : COMOMFINKHP, GEKCJJABACO
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager MKHPDCKNNBB;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2B06230", Offset = "0x2B05230", VA = "0x182B06230", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2B061C0", Offset = "0x2B051C0", VA = "0x182B061C0", Slot = "5")]
		public void IAGNHLLEPKM(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2B06150", Offset = "0x2B05150", VA = "0x182B06150", Slot = "6")]
		public void APNKBCIODFM(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x256F990", Offset = "0x256E990", VA = "0x18256F990")]
		private void FAFPJPFNCCD<T>(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
[DEJAKMDKDPE(typeof(FHEFGOCJINE), new string[] { })]
internal sealed class FHEFGOCJINE : COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[GNFGKNINDPI]
	private ObjectEmbodimentService NKDJGKIHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF JNDOBDHNDEN;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2C59DB0", Offset = "0x2C58DB0", VA = "0x182C59DB0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FHEFGOCJINE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	[DEJAKMDKDPE(typeof(WorldSerialization), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	internal sealed class WorldSerialization : COMOMFINKHP, MACMNODFHDH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FBNJDMKEPCN JMKJAKDNGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[GNFGKNINDPI]
		private AFNBNNKFHAD KFPILFJMBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[GNFGKNINDPI]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[GNFGKNINDPI]
		private SerializationService OLPNBPCMPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[GNFGKNINDPI]
		private DBPDOJBMJDO PGEAEBLBOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[GNFGKNINDPI]
		private DebugWorldsService PADOOEAKDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[GNFGKNINDPI]
		private BulkInstantiateSceneObjectService KPOAOAEBOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private OKKPKCPMOFL GNDGFHCLBLF;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private JBKANIAMFJC HJLBIIAFNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0xBBE3D0", Offset = "0xBBD3D0", VA = "0x180BBE3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BAC0", Offset = "0x2B1AAC0", VA = "0x182B1BAC0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL MPKJGFCBIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AFB0", Offset = "0x2B19FB0", VA = "0x182B1AFB0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B5E0", Offset = "0x2B1A5E0", VA = "0x182B1B5E0", Slot = "6")]
		public bool KABGCCDIEOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BC30", Offset = "0x2B1AC30", VA = "0x182B1BC30", Slot = "7")]
		public bool PAAMODNKOMP(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AB20", Offset = "0x2B19B20", VA = "0x182B1AB20", Slot = "5")]
		public ByteString CCPOABEFOJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BC10", Offset = "0x2B1AC10", VA = "0x182B1BC10")]
		private void NGNKNOOOPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B4C0", Offset = "0x2B1A4C0", VA = "0x182B1B4C0")]
		private void FJENLEOPPNH(EGLINNINABL LINDLPIKMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AFE0", Offset = "0x2B19FE0", VA = "0x182B1AFE0")]
		private void EPHJIJGNBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B7E0", Offset = "0x2B1A7E0", VA = "0x182B1B7E0")]
		private void LDHMAMDPAOM(IKONBHPFCLI LINDLPIKMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B590", Offset = "0x2B1A590", VA = "0x182B1B590", Slot = "8")]
		public void IJMNPCGJOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B740", Offset = "0x2B1A740", VA = "0x182B1B740")]
		private EGLINNINABL LACCDJIOIOK(EntityManager DDNAAJMMFNN, EntityManager BLDEHLEAJGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DEJAKMDKDPE(typeof(AHGKDOLNJLL), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
public class AHGKDOLNJLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<PDAOCOFFNGC, string> KHEGBNANOHP;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2A663A0", Offset = "0x2A653A0", VA = "0x182A663A0")]
	public GameObject CJGBGIFPLJG(PDAOCOFFNGC OEIOFKJKBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2A66470", Offset = "0x2A65470", VA = "0x182A66470")]
	public AHGKDOLNJLL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(TimeService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class TimeService : LGFONBKKNKN, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[GNFGKNINDPI]
		private SingletonComponentService GEEOABODELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool LBMKGBNBHEA;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData FPINDHLABHF
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DA60", Offset = "0x2B0CA60", VA = "0x182B0DA60")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DB90", Offset = "0x2B0CB90", VA = "0x182B0DB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool POJFIIEGDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x6988D0", Offset = "0x6978D0", VA = "0x1806988D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x6BA000", Offset = "0x6B9000", VA = "0x1806BA000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x12753B0", Offset = "0x12743B0", VA = "0x1812753B0", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DC10", Offset = "0x2B0CC10", VA = "0x182B0DC10", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DAD0", Offset = "0x2B0CAD0", VA = "0x182B0DAD0")]
		public void FHMOEDGLOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	[DEJAKMDKDPE(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private HJBNADOIEKJ AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::IBOLLEGFEDA<Entity> ICMEPOIJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService ADDOLKFBKIO;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2B09DB0", Offset = "0x2B08DB0", VA = "0x182B09DB0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2B09BE0", Offset = "0x2B08BE0", VA = "0x182B09BE0", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2B09D10", Offset = "0x2B08D10", VA = "0x182B09D10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E20", Offset = "0x2B08E20", VA = "0x182B09E20")]
		private void NNNMGDHGBAA(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[LMNMHFHDONH(IPKPBIMLPOB.Services)]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	[DEJAKMDKDPE(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[GNFGKNINDPI]
		private OEHMAIGJCPM ILHPJDCALOO;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private GLPDMDGLDBM LKGOEFLEABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x2C542D0", Offset = "0x2C532D0", VA = "0x182C542D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private DAFEDNGOABD JLHOGDFBIFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x2C543C0", Offset = "0x2C533C0", VA = "0x182C543C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2C54340", Offset = "0x2C53340", VA = "0x182C54340", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2C54320", Offset = "0x2C53320", VA = "0x182C54320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
[DEJAKMDKDPE(typeof(MOOBEMHPLGJ), new string[] { })]
public class MOOBEMHPLGJ : BCEBHKLAAOO, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class ABMMBFGOJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public OKKPKCPMOFL services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ABMMBFGOJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x413BA20", Offset = "0x413AA20", VA = "0x18413BA20")]
		internal void <InitReferences>b__0(COMOMFINKHP svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class LNHIDELIMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public OKKPKCPMOFL services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LNHIDELIMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x4143C80", Offset = "0x4142C80", VA = "0x184143C80")]
		internal void <InitExternal>b__0(BDDJKMOFDGN svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF JNDOBDHNDEN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HMOKJIFMIAI CDBGKLIMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C90", Offset = "0x8E6C90", VA = "0x1808E7C90", Slot = "4")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AHBEEJODFBD MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2971640", Offset = "0x2970640", VA = "0x182971640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2971510", Offset = "0x2970510", VA = "0x182971510", Slot = "5")]
	public void JPFKMOKBFIC(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2971690", Offset = "0x2970690", VA = "0x182971690", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2971560", Offset = "0x2970560", VA = "0x182971560", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2971300", Offset = "0x2970300", VA = "0x182971300", Slot = "8")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x29713E0", Offset = "0x29703E0", VA = "0x1829713E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x249EF60", Offset = "0x249DF60", VA = "0x18249EF60")]
	private void DEFGLDLMBIO<T>(Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public MOOBEMHPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class GKEIOPGKFIG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> FAHBHODOFIG;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To PGMGPNCDKFC
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
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public GKEIOPGKFIG(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
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
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
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
public class GNNDOMKAGHE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x28595C0", Offset = "0x28585C0", VA = "0x1828595C0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2859620", Offset = "0x2858620", VA = "0x182859620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2859590", Offset = "0x2858590", VA = "0x182859590", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x738170", Offset = "0x737170", VA = "0x180738170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2859500", Offset = "0x2858500", VA = "0x182859500")]
	public GNNDOMKAGHE(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ, bool FJBBIADFENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x28590F0", Offset = "0x28580F0", VA = "0x1828590F0", Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2859150", Offset = "0x2858150", VA = "0x182859150", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2859180", Offset = "0x2858180", VA = "0x182859180", Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x28591E0", Offset = "0x28581E0", VA = "0x1828591E0", Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x28592F0", Offset = "0x28582F0", VA = "0x1828592F0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2859360", Offset = "0x2858360", VA = "0x182859360", Slot = "6")]
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x28593C0", Offset = "0x28583C0", VA = "0x1828593C0", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2859470", Offset = "0x2858470", VA = "0x182859470", Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2859440", Offset = "0x2858440", VA = "0x182859440", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x28594D0", Offset = "0x28584D0", VA = "0x1828594D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class DNDGNGLMMAP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> DBOPJMNFJMA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x28DC860", Offset = "0x28DB860", VA = "0x1828DC860", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x28DC8B0", Offset = "0x28DB8B0", VA = "0x1828DC8B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x28DC820", Offset = "0x28DB820", VA = "0x1828DC820", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2005CF0", Offset = "0x2004CF0", VA = "0x182005CF0")]
	public DNDGNGLMMAP(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x28DC430", Offset = "0x28DB430", VA = "0x1828DC430", Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x28DC470", Offset = "0x28DB470", VA = "0x1828DC470", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x28DC4B0", Offset = "0x28DB4B0", VA = "0x1828DC4B0", Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x28DC570", Offset = "0x28DB570", VA = "0x1828DC570", Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x28DC630", Offset = "0x28DB630", VA = "0x1828DC630", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x28DC6F0", Offset = "0x28DB6F0", VA = "0x1828DC6F0", Slot = "6")]
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x28DC760", Offset = "0x28DB760", VA = "0x1828DC760", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x28DC7E0", Offset = "0x28DB7E0", VA = "0x1828DC7E0", Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x28DC7A0", Offset = "0x28DB7A0", VA = "0x1828DC7A0", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2081AD0", Offset = "0x2080AD0", VA = "0x182081AD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class NMMAOEFNHIE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To PGMGPNCDKFC
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
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public NMMAOEFNHIE(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
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
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
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
public static class KBACIJMFKCM
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string DMHJAFOPEHL = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string FKNKJINFOLA = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string EKNPINMPOIL = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string MKHFAJEIEOO = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string BPENCCJEHMG = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string DHHPBACILCO = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string EGONJCNFAOO = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string LAJKKJGBENP = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class GLKAJPCLAHO
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DGGOCMIJOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public OKKPKCPMOFL services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DGGOCMIJOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x413E020", Offset = "0x413D020", VA = "0x18413E020")]
		internal void <InitServices>b__1(COMOMFINKHP svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x413E080", Offset = "0x413D080", VA = "0x18413E080")]
		internal void <InitServices>b__2(BDDJKMOFDGN svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F3D0", Offset = "0x2C5E3D0", VA = "0x182C5F3D0")]
	public static void OHMOAAJMNJA(this AHBEEJODFBD GLPDAIBKGJO, OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2259C60", Offset = "0x2258C60", VA = "0x182259C60")]
	public static void DEFGLDLMBIO<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x225A1A0", Offset = "0x22591A0", VA = "0x18225A1A0")]
	public static void HPNMDCEHEGC<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x2259CD0", Offset = "0x2258CD0", VA = "0x182259CD0")]
	public static void DEOLMOBBEIA<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x225A340", Offset = "0x2259340", VA = "0x18225A340")]
	public static void MHDNGOKOLOP<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x2259E80", Offset = "0x2258E80", VA = "0x182259E80")]
	public static void HLGMGBEBGOE<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x225A030", Offset = "0x2259030", VA = "0x18225A030")]
	public static void HPNMDCEHEGC<T>(IEnumerable<ComponentSystemBase> GNCNHHEOEMG, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x225A4F0", Offset = "0x22594F0", VA = "0x18225A4F0")]
	private static void PBPBBBDLMHI<T>(object KFLDFPCKAGO, Action<T> BPIAHGDBOBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class BMOMCOKMAGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class LDBALLIJEPD
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C70A60", Offset = "0x2C6FA60", VA = "0x182C70A60")]
	public static void LEIDBIKLJLN(ComponentSystemBase KFLDFPCKAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class PDEFFGNOOMK
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool NNBHJPBHOAE<T>(ref T NCNGLFNLPAG, ref T OPGAGDBKIDA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class PGPOMLKIMFE
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NHFDNPDFOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public NHFDNPDFOPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2980D00", Offset = "0x297FD00", VA = "0x182980D00")]
	public static string ODPDBMHMLPP(Transform FLCFNMLPAML, Transform IBCPLIFFFGK)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[LMNMHFHDONH(IPKPBIMLPOB.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B08E70", Offset = "0x2B07E70", VA = "0x182B08E70")]
		public static void EFMBJNCKONM(this HEGPOCOMKLM GNDGFHCLBLF, NDAGMAFOAIH DNPJACNCEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B089B0", Offset = "0x2B079B0", VA = "0x182B089B0")]
		public static void BCFPIHPAJGO(this HEGPOCOMKLM GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B090A0", Offset = "0x2B080A0", VA = "0x182B090A0")]
		public static void EFMBJNCKONM(this HEGPOCOMKLM GNDGFHCLBLF, [Optional] string[] CHDEBPEGPOB, [Optional] string[] HBJKNPALEGK, [Optional] string[] HIIJLAHHCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B091B0", Offset = "0x2B081B0", VA = "0x182B091B0")]
		public static void FNBLCKLGPJL(this HEGPOCOMKLM GNDGFHCLBLF, params string[] JFOHECKOLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B09260", Offset = "0x2B08260", VA = "0x182B09260")]
		public static void LFKCJOCHLDA(this HEGPOCOMKLM GNDGFHCLBLF, params string[] JFOHECKOLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B08C70", Offset = "0x2B07C70", VA = "0x182B08C70")]
		private static string[] ECJGMBFJMGM(NDAGMAFOAIH DNPJACNCEDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B08AB0", Offset = "0x2B07AB0", VA = "0x182B08AB0")]
		private static bool BNOIHDNDMOH(NDAGMAFOAIH DNPJACNCEDM, out string[] PHDEHNPPPEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00")]
		private static bool GKCODOMLMKP()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class IOIMAGFEJEF : JMNDOGGEHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo CEAAEBPPEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] IJPNBHGIPKF;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CED0", Offset = "0x2C5BED0", VA = "0x182C5CED0")]
	public IOIMAGFEJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BKNNBPEHKAH();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C69190", Offset = "0x2C68190", VA = "0x182C69190")]
	public MethodInfo BHHNKIKLECN(Action KNOLDLABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C691D0", Offset = "0x2C681D0", VA = "0x182C691D0", Slot = "4")]
	public void MNFGPLMIANE(Type IGEIBCJNCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class AGINDNANPBG : IOIMAGFEJEF
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum FEGPHPBMGHG
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A66270", Offset = "0x2A65270", VA = "0x182A66270", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ABJLMKCELFF<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A66300", Offset = "0x2A65300", VA = "0x182A66300")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A66390", Offset = "0x2A65390", VA = "0x182A66390")]
	protected AGINDNANPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class EJMPALHMCHN : IOIMAGFEJEF
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A80A90", Offset = "0x2A7FA90", VA = "0x182A80A90", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void APOBCKKPPBP<T>() where T : JHGAIKODJEE;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A80B20", Offset = "0x2A7FB20", VA = "0x182A80B20")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A66390", Offset = "0x2A65390", VA = "0x182A66390")]
	protected EJMPALHMCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class GCONKENLJGL : IOIMAGFEJEF
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CDB0", Offset = "0x2C5BDB0", VA = "0x182C5CDB0", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void AJKAAFGKLOC<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CE40", Offset = "0x2C5BE40", VA = "0x182C5CE40")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CED0", Offset = "0x2C5BED0", VA = "0x182C5CED0")]
	protected GCONKENLJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LCENBLDPCFF
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C70960", Offset = "0x2C6F960", VA = "0x182C70960")]
	public static Entity PKDJJDGFLPJ(this EntityManager MKHPDCKNNBB)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class NBFKPLNCBEH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1BF7FC0", Offset = "0x1BF6FC0", VA = "0x181BF7FC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41441A0", Offset = "0x41431A0", VA = "0x1841441A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x413D9C0", Offset = "0x413C9C0", VA = "0x18413D9C0")]
			[DebuggerHidden]
			public NBFKPLNCBEH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x4143FD0", Offset = "0x4142FD0", VA = "0x184143FD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x4144160", Offset = "0x4143160", VA = "0x184144160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x41440B0", Offset = "0x41430B0", VA = "0x1841440B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x41440B0", Offset = "0x41430B0", VA = "0x1841440B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class OAELKENFEOL : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1BF7FC0", Offset = "0x1BF6FC0", VA = "0x181BF7FC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41448A0", Offset = "0x41438A0", VA = "0x1841448A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x413D9C0", Offset = "0x413C9C0", VA = "0x18413D9C0")]
			[DebuggerHidden]
			public OAELKENFEOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x41448F0", Offset = "0x41438F0", VA = "0x1841448F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x41445C0", Offset = "0x41435C0", VA = "0x1841445C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x4144980", Offset = "0x4143980", VA = "0x184144980")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x4144860", Offset = "0x4143860", VA = "0x184144860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x41447B0", Offset = "0x41437B0", VA = "0x1841447B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x41447B0", Offset = "0x41437B0", VA = "0x1841447B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class CBKIJNMDBJK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1BF7FC0", Offset = "0x1BF6FC0", VA = "0x181BF7FC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x413D800", Offset = "0x413C800", VA = "0x18413D800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x413D9C0", Offset = "0x413C9C0", VA = "0x18413D9C0")]
			[DebuggerHidden]
			public CBKIJNMDBJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x413D850", Offset = "0x413C850", VA = "0x18413D850", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x413D3F0", Offset = "0x413C3F0", VA = "0x18413D3F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x413D920", Offset = "0x413C920", VA = "0x18413D920")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x413D970", Offset = "0x413C970", VA = "0x18413D970")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x413D7C0", Offset = "0x413C7C0", VA = "0x18413D7C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x413D720", Offset = "0x413C720", VA = "0x18413D720", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x413D720", Offset = "0x413C720", VA = "0x18413D720", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C57C30", Offset = "0x2C56C30", VA = "0x182C57C30")]
		public static Entity MAGJHAEAOAI(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C580B0", Offset = "0x2C570B0", VA = "0x182C580B0")]
		public static DynamicBuffer<ChildrenData> PLGKICCDOKG(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C57900", Offset = "0x2C56900", VA = "0x182C57900")]
		public static DynamicBuffer<ChildrenData> KEFLHAKPOMO(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C57720", Offset = "0x2C56720", VA = "0x182C57720")]
		public static NativeArray<Entity> IOKEKIJMFLH(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C57310", Offset = "0x2C56310", VA = "0x182C57310")]
		public static bool HONEICGJHAO(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH, out NativeArray<Entity> CFAPEIBDFEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C571B0", Offset = "0x2C561B0", VA = "0x182C571B0")]
		public static NativeArray<Entity> HGDENHFMCHF(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C569D0", Offset = "0x2C559D0", VA = "0x182C569D0")]
		public static Entity CCOFDHEFLND(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C56730", Offset = "0x2C55730", VA = "0x182C56730")]
		public static int APKIBECFENN(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C56CF0", Offset = "0x2C55CF0", VA = "0x182C56CF0")]
		public static void GFMOPDELPBL(NativeArray<Entity> JMOFNBOBEAE, NativeArray<Entity> MIHJGHDPEEA, EntityManager MKHPDCKNNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C57850", Offset = "0x2C56850", VA = "0x182C57850")]
		public static int JBGHMDGDFGD(this EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C57DD0", Offset = "0x2C56DD0", VA = "0x182C57DD0")]
		public static bool ONFDIBDBOKI(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C57A90", Offset = "0x2C56A90", VA = "0x182C57A90")]
		public static IEnumerable<Entity> LHNLJGEEPBH(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C57CA0", Offset = "0x2C56CA0", VA = "0x182C57CA0")]
		public static bool OIGMHNPAGCC(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity ELFIACEEOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C56840", Offset = "0x2C55840", VA = "0x182C56840")]
		public static bool BNNCMPPKFKP(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity BBDPANMBHID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C57510", Offset = "0x2C56510", VA = "0x182C57510")]
		public static NativeList<Entity> IEEPKLPNIEF(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false, Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C57F30", Offset = "0x2C56F30", VA = "0x182C57F30")]
		public static IEnumerable<Entity> PICEAKMECIB(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2C57990", Offset = "0x2C56990", VA = "0x182C57990")]
		public static Entity LGNFHDEKAND(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2C56F50", Offset = "0x2C55F50", VA = "0x182C56F50")]
		public static bool GOHPGPBBEBL(this EntityManager MKHPDCKNNBB, Entity BBDPANMBHID, Entity PACKOPHLIKB, out Entity OCIPFMKDCPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2C56BE0", Offset = "0x2C55BE0", VA = "0x182C56BE0")]
		internal static void DPIBMKGBJOE(EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2C57410", Offset = "0x2C56410", VA = "0x182C57410")]
		internal static void ICMPGCIDKJM(EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2C57BA0", Offset = "0x2C56BA0", VA = "0x182C57BA0")]
		[IteratorStateMachine(typeof(NBFKPLNCBEH))]
		private static IEnumerable<Entity> LLOFCNEOKMK(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2C56C60", Offset = "0x2C55C60", VA = "0x182C56C60")]
		[IteratorStateMachine(typeof(OAELKENFEOL))]
		private static IEnumerable<Entity> ENPFGNGCADI(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2C57D50", Offset = "0x2C56D50", VA = "0x182C57D50")]
		[IteratorStateMachine(typeof(CBKIJNMDBJK))]
		private static IEnumerable<Entity> OKCBNEGAIJC(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2C56B00", Offset = "0x2C55B00", VA = "0x182C56B00")]
		private static bool DCOCMLALEEJ(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[DEJAKMDKDPE(typeof(OGAFJLECHAO), new string[] { })]
public class LMAJLLBNAKD : OGAFJLECHAO, BCEBHKLAAOO, OMNOAEHFEEE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private OKKPKCPMOFL GNDGFHCLBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private AFNBNNKFHAD KFPILFJMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private DOKNELGMFJP BPEDINOHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private BCIOKJKBEBJ NJHJPKKCNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private HJBNADOIEKJ AKKHHLBJIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private BHIIPBMPCDB OLPNBPCMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private IDIHNGDEJEE FKPAJEBPAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private MFDIJJOFCMP JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private LAEEMBKBPLL NFJHBFBEOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private MJGMCJFCPCM BDDKNEOOFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private KHAPNLPCPDI IGMJMLJDCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private LHMGIFBKNDN FHBNDHEOPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private CHJKDGGMOBG NNAMBPFCCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private DLPNOHDEIMB MPMMMCINMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private GEKCJJABACO JHPMDDOMPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private CPAGJJIMMGO PKLLBBDOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private DACMFIPKNDK BGONJHEABPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private IGKHNFEAAFE MFNIBBKJICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public OKKPKCPMOFL OPHCKCDGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public ALAPBINNPIH JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JLJEDKKMHDF MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AFNBNNKFHAD GDAMCIHJNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DOKNELGMFJP KICJEKGPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public JEAKCMCJOBO CEJNFPFMJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BCIOKJKBEBJ NJNIFJHCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x685580", Offset = "0x684580", VA = "0x180685580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HJBNADOIEKJ FMENJHJIFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D0", Offset = "0x67D0D0", VA = "0x18067E0D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public BHIIPBMPCDB NIPBBEMJDED
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x694760", Offset = "0x693760", VA = "0x180694760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public IDIHNGDEJEE EBGGDKFHAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x67E0B0", Offset = "0x67D0B0", VA = "0x18067E0B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public MFDIJJOFCMP ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x694770", Offset = "0x693770", VA = "0x180694770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LAEEMBKBPLL AFGKCGMMBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x694780", Offset = "0x693780", VA = "0x180694780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MJGMCJFCPCM JCFDPAKBHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x694700", Offset = "0x693700", VA = "0x180694700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public KHAPNLPCPDI ELGLAEPGDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x694710", Offset = "0x693710", VA = "0x180694710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LHMGIFBKNDN NBDKJPAKGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6D0", Offset = "0x6B96D0", VA = "0x1806BA6D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public CHJKDGGMOBG KFNMGLHMELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x684D80", Offset = "0x683D80", VA = "0x180684D80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DLPNOHDEIMB BOPMPJOAALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x684E20", Offset = "0x683E20", VA = "0x180684E20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GEKCJJABACO DLBKDKKEPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6A0", Offset = "0x6B96A0", VA = "0x1806BA6A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public CPAGJJIMMGO ELKFEGKPNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x694720", Offset = "0x693720", VA = "0x180694720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DACMFIPKNDK GGLLKAAOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x694730", Offset = "0x693730", VA = "0x180694730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public IGKHNFEAAFE MPJAONPNNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x694750", Offset = "0x693750", VA = "0x180694750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public HMOKJIFMIAI CDBGKLIMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AA0", Offset = "0x6A3AA0", VA = "0x1806A4AA0", Slot = "21")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2C717A0", Offset = "0x2C707A0", VA = "0x182C717A0", Slot = "22")]
	public void JPFKMOKBFIC(OKKPKCPMOFL MPKJGFCBIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1C3B9E0", Offset = "0x1C3A9E0", VA = "0x181C3B9E0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2C71780", Offset = "0x2C70780", VA = "0x182C71780", Slot = "23")]
	public void DMHOOCIGLMM(OKKPKCPMOFL MPKJGFCBIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LMAJLLBNAKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class FHBCPKACIBL : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class PLHLABIBLHB : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public FHBCPKACIBL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x694790", Offset = "0x693790", VA = "0x180694790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4146830", Offset = "0x4145830", VA = "0x184146830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x682200", Offset = "0x681200", VA = "0x180682200")]
		[DebuggerHidden]
		public PLHLABIBLHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x4146680", Offset = "0x4145680", VA = "0x184146680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x41467F0", Offset = "0x41457F0", VA = "0x1841467F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong INDAKPOONPJ = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong JBJFMBOFFAO = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int ILALEBLCCPE = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int OHPIPCLLPKA = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int FGELJCFFBAH = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int EMPJHCPOIFO = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> GEFDGCJIJFA;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x722410", Offset = "0x721410", VA = "0x180722410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int LLHBHAOFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x699C90", Offset = "0x698C90", VA = "0x180699C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x722320", Offset = "0x721320", VA = "0x180722320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2C58E50", Offset = "0x2C57E50", VA = "0x182C58E50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2C59750", Offset = "0x2C58750", VA = "0x182C59750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2C59A20", Offset = "0x2C58A20", VA = "0x182C59A20")]
	public FHBCPKACIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2C59AA0", Offset = "0x2C58AA0", VA = "0x182C59AA0")]
	public FHBCPKACIBL(int KDNFGAPAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2C59670", Offset = "0x2C58670", VA = "0x182C59670")]
	public bool ODJIALJAHHI(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2C59250", Offset = "0x2C58250", VA = "0x182C59250")]
	public bool GLGGDGFLNCI(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2C58EF0", Offset = "0x2C57EF0", VA = "0x182C58EF0")]
	public bool DHNKMDBPJKM(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2C59000", Offset = "0x2C58000", VA = "0x182C59000")]
	public bool DOFAOAHKOHP(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2C594F0", Offset = "0x2C584F0", VA = "0x182C594F0")]
	public void IBIGAGAEFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2C59580", Offset = "0x2C58580", VA = "0x182C59580")]
	public void KNBBMABFAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2C59160", Offset = "0x2C58160", VA = "0x182C59160")]
	public void FAFPJPFNCCD(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2C59010", Offset = "0x2C58010", VA = "0x182C59010")]
	public void EMOCNNJJBKM(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2C58F70", Offset = "0x2C57F70", VA = "0x182C58F70")]
	public bool DIAPBLEJNDD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2C59900", Offset = "0x2C58900", VA = "0x182C59900")]
	public void PFMOMOJGLBI(int PNKNABOKANH, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x2C58C90", Offset = "0x2C57C90", VA = "0x182C58C90")]
	public void BEGIFDBPECD(int LLJOHLBBLLB, int FOPGHCLMOAD, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2C59420", Offset = "0x2C58420", VA = "0x182C59420")]
	public int HMNAIPBHJIK(int MIOCJKOOLBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2C593B0", Offset = "0x2C583B0", VA = "0x182C593B0")]
	public int HMNAIPBHJIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2C59110", Offset = "0x2C58110", VA = "0x182C59110")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2C59340", Offset = "0x2C58340", VA = "0x182C59340", Slot = "4")]
	[IteratorStateMachine(typeof(PLHLABIBLHB))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2C59340", Offset = "0x2C58340", VA = "0x182C59340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class MHNBDOHJLOG<T> : global::AGGGPMKCIOC<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::AFGGCKFKJIL<T> GFCAPLHGOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::DLMPCLMCJDM<T> CODKEDJGDDE;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x13D7DF0", Offset = "0x13D6DF0", VA = "0x1813D7DF0")]
	public MHNBDOHJLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x24BA380", Offset = "0x24B9380", VA = "0x1824BA380")]
	public MHNBDOHJLOG(global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x24B9C90", Offset = "0x24B8C90", VA = "0x1824B9C90", Slot = "11")]
	public override T CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x24BA0D0", Offset = "0x24B90D0", VA = "0x1824BA0D0", Slot = "12")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, T DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EMMMPLLOBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x395C630", Offset = "0x395B630", VA = "0x18395C630")]
	public static OEMFGOLGDMG MNFGPLMIANE<T>(this OBCIKAMHODM JDJBDCDEPOJ, global::KBOIOIDENFM<T> IADPDEAGFAB, global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE) where T : struct
	{
		return default(OEMFGOLGDMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class DHBOBEFNCKC<T> : global::MHNBDOHJLOG<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D22E0", VA = "0x1828D32E0")]
	public DHBOBEFNCKC(T AJMPIJJCLNC, T JFFGPOOCEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class BIADNFMMLDL<T> : global::AGGGPMKCIOC<T> where T : struct, JHGAIKODJEE
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x28271C0", Offset = "0x28261C0", VA = "0x1828271C0", Slot = "11")]
	public override T CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x28272A0", Offset = "0x28262A0", VA = "0x1828272A0", Slot = "12")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x22CD240", Offset = "0x22CC240", VA = "0x1822CD240")]
	public BIADNFMMLDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class KHJOCGMPINF : OIJLHFGLBPH
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type LNKEDHNPBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA, in MELHFKPCLBG DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, in PEKIEJLMCEO DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ALPKNKNFCBE(AGINBCFDEDM INFJLMMKNPA, AGOFGGGPNPC BAHONECJAGF, [Optional] object KPJEGNGKPOH);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected KHJOCGMPINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class AGGGPMKCIOC<T> : KHJOCGMPINF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type LNKEDHNPBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x29609C0", Offset = "0x295F9C0", VA = "0x1829609C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, T DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x29602E0", Offset = "0x295F2E0", VA = "0x1829602E0", Slot = "8")]
	public override void CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA, in MELHFKPCLBG IBCPLIFFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2961660", Offset = "0x2960660", VA = "0x182961660", Slot = "9")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, in PEKIEJLMCEO JFBGEPNCFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x295F8F0", Offset = "0x295E8F0", VA = "0x18295F8F0", Slot = "10")]
	public override void ALPKNKNFCBE(AGINBCFDEDM INFJLMMKNPA, AGOFGGGPNPC BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1E33270", Offset = "0x1E32270", VA = "0x181E33270")]
	protected AGGGPMKCIOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class DLNILMDALGL
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class DLBECHCOANP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OCNNIDIJOPK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
			public OCNNIDIJOPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x26FED90", Offset = "0x26FDD90", VA = "0x1826FED90")]
			internal void <RegisterFixedString>b__0(AGINBCFDEDM p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x26FF1A0", Offset = "0x26FE1A0", VA = "0x1826FF1A0")]
			internal T <RegisterFixedString>b__1(AGINBCFDEDM p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF80", Offset = "0x2AFEF80", VA = "0x182AFFF80")]
		public static void GJGDMAHCJAG(MEJLDDCCOEN BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x26655D0", Offset = "0x26645D0", VA = "0x1826655D0")]
		private static void FNGFPIFAJIB<T>(MEJLDDCCOEN BMNJABIDNBC, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x26656F0", Offset = "0x26646F0", VA = "0x1826656F0")]
		private static void GHKMCGKGADH<T>(AGINBCFDEDM ONINKGDNEEG, T BGLBBPFJJCJ, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2665780", Offset = "0x2664780", VA = "0x182665780")]
		private static T KHFLBCIDKPK<T>(AGINBCFDEDM ONINKGDNEEG, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DLBECHCOANP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class DAIJHEOGKEP : AGINDNANPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private MEJLDDCCOEN BMNJABIDNBC;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x26651F0", Offset = "0x26641F0", VA = "0x1826651F0", Slot = "6")]
		public override void ABJLMKCELFF<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFEC0", Offset = "0x2AFEEC0", VA = "0x182AFFEC0")]
		public static void EGJPKMMLEJC(MEJLDDCCOEN BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF70", Offset = "0x2AFEF70", VA = "0x182AFFF70")]
		public DAIJHEOGKEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ABB0", Offset = "0x2A79BB0", VA = "0x182A7ABB0")]
	public static void HGMCEGHOEPL(MEJLDDCCOEN BMNJABIDNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x25ADFB0", Offset = "0x25ACFB0", VA = "0x1825ADFB0")]
	public static void LKDFGHCAFND<T>(MEJLDDCCOEN BMNJABIDNBC, global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x25ADF40", Offset = "0x25ACF40", VA = "0x1825ADF40")]
	public static void GJELGJEJBBC<T>(MEJLDDCCOEN PPBHALAGCOC) where T : struct, JHGAIKODJEE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
public interface MEJLDDCCOEN : global::OLEHPGMCMPC<MEJLDDCCOEN>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNFGPLMIANE(Type IGEIBCJNCHF, OIJLHFGLBPH PPBHALAGCOC);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDMOKHFDALA(Type IGEIBCJNCHF, out OIJLHFGLBPH PPBHALAGCOC);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class AEJOGPBEOKA
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A65D70", Offset = "0x2A64D70", VA = "0x182A65D70")]
	public static void MNFGPLMIANE(this MEJLDDCCOEN KGAFOEANBBF, OIJLHFGLBPH PPBHALAGCOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DEJAKMDKDPE(typeof(OBCIKAMHODM), new string[] { })]
public sealed class PNPCEOCBIMC : OBCIKAMHODM, global::OLEHPGMCMPC<OBCIKAMHODM>, LGFONBKKNKN, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<OEMFGOLGDMG, OIJLHFGLBPH> BMNJABIDNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private MEJLDDCCOEN FGEHIGKIDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private DPCIBBJGPEK JDJBDCDEPOJ;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool LKCPHIECPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x738170", Offset = "0x737170", VA = "0x180738170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2981F20", Offset = "0x2980F20", VA = "0x182981F20")]
	public PNPCEOCBIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2981FA0", Offset = "0x2980FA0", VA = "0x182981FA0")]
	public PNPCEOCBIMC(Dictionary<OEMFGOLGDMG, OIJLHFGLBPH> BMNJABIDNBC, bool FHNOIGDJPEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2981EC0", Offset = "0x2980EC0", VA = "0x182981EC0", Slot = "7")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2981CD0", Offset = "0x2980CD0", VA = "0x182981CD0", Slot = "8")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2981920", Offset = "0x2980920", VA = "0x182981920", Slot = "9")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2981970", Offset = "0x2980970", VA = "0x182981970", Slot = "4")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC IADPDEAGFAB)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2981D50", Offset = "0x2980D50", VA = "0x182981D50", Slot = "5")]
	public void MNFGPLMIANE(OEMFGOLGDMG KCHLIHHPAKF, OIJLHFGLBPH PPBHALAGCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x29817E0", Offset = "0x29807E0", VA = "0x1829817E0")]
	[Conditional("DEBUG_BUILD")]
	private void AHJHACPLCOB(OEMFGOLGDMG KCHLIHHPAKF, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2981B20", Offset = "0x2980B20", VA = "0x182981B20", Slot = "6")]
	public bool MDMOKHFDALA(OEMFGOLGDMG KCHLIHHPAKF, out OIJLHFGLBPH PPBHALAGCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2981A40", Offset = "0x2980A40", VA = "0x182981A40", Slot = "10")]
	public OBCIKAMHODM IIDODNOLDOK()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[DEJAKMDKDPE(typeof(MEJLDDCCOEN), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.TypeSerializer)]
	public sealed class TypeSerializerService : LGFONBKKNKN, MEJLDDCCOEN, global::OLEHPGMCMPC<MEJLDDCCOEN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, OIJLHFGLBPH> BMNJABIDNBC;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool LKCPHIECPEC
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x6988D0", Offset = "0x6978D0", VA = "0x1806988D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x6BA000", Offset = "0x6B9000", VA = "0x1806BA000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B138A0", Offset = "0x2B128A0", VA = "0x182B138A0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B13920", Offset = "0x2B12920", VA = "0x182B13920")]
		public TypeSerializerService(Dictionary<Type, OIJLHFGLBPH> BMNJABIDNBC, bool FHNOIGDJPEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B137F0", Offset = "0x2B127F0", VA = "0x182B137F0", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B136D0", Offset = "0x2B126D0", VA = "0x182B136D0", Slot = "5")]
		public void MNFGPLMIANE(Type IGEIBCJNCHF, OIJLHFGLBPH PPBHALAGCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B135F0", Offset = "0x2B125F0", VA = "0x182B135F0", Slot = "6")]
		public bool MDMOKHFDALA(Type IGEIBCJNCHF, out OIJLHFGLBPH PPBHALAGCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B13510", Offset = "0x2B12510", VA = "0x182B13510", Slot = "7")]
		public MEJLDDCCOEN IIDODNOLDOK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DEJAKMDKDPE(typeof(KNNGHNBFHEB), new string[] { })]
internal sealed class MMANJGJHNNG : KNNGHNBFHEB, LGFONBKKNKN, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<OEMFGOLGDMG, NGMECMFEEPK> BJKBIPFFHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private DPCIBBJGPEK JDJBDCDEPOJ;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2970CF0", Offset = "0x296FCF0", VA = "0x182970CF0", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2970C20", Offset = "0x296FC20", VA = "0x182970C20", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2970C80", Offset = "0x296FC80", VA = "0x182970C80", Slot = "4")]
	public void MNFGPLMIANE(OEMFGOLGDMG DLFEJOALJGM, Type KJBCODGFBDC, NGMECMFEEPK KKFPGOCIING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2970BB0", Offset = "0x296FBB0", VA = "0x182970BB0", Slot = "5")]
	public bool ACMGIDOBIEM(OEMFGOLGDMG DLFEJOALJGM, out NGMECMFEEPK KKFPGOCIING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2970D40", Offset = "0x296FD40", VA = "0x182970D40")]
	[Conditional("DEBUG_BUILD")]
	private void PBNHGOOLLKF(OEMFGOLGDMG DLFEJOALJGM, Type KJBCODGFBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2970ED0", Offset = "0x296FED0", VA = "0x182970ED0")]
	public MMANJGJHNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DEJAKMDKDPE(typeof(BDINFDEDPEH), new string[] { })]
internal sealed class GMLEHANOGIO : BDINFDEDPEH, MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly FHBCPKACIBL FLPFOJIMLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<AIELFMMICMN, int> IJHHJPKEOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> NIEHJLCAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[GNFGKNINDPI]
	private DPCIBBJGPEK JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[GNFGKNINDPI]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int HPGPPJIKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C5F7D0", Offset = "0x2C5E7D0", VA = "0x182C5F7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x749540", Offset = "0x748540", VA = "0x180749540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC070", Offset = "0x8DB070", VA = "0x1808DC070", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F820", Offset = "0x2C5E820", VA = "0x182C5F820", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FE90", Offset = "0x2C5EE90", VA = "0x182C5FE90", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F720", Offset = "0x2C5E720", VA = "0x182C5F720", Slot = "8")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FCB0", Offset = "0x2C5ECB0", VA = "0x182C5FCB0")]
	private void KBGDDFDNCBC(PMFFIMLMCEJ GMOMNBJDADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FD50", Offset = "0x2C5ED50", VA = "0x182C5FD50", Slot = "4")]
	public bool MHHFAKHKBJJ(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F960", Offset = "0x2C5E960", VA = "0x182C5F960", Slot = "5")]
	public void HNCGHBNHCBA(AIELFMMICMN CDEOFEMHEEC, Span<OEMFGOLGDMG> JDJBDCDEPOJ, bool EPGOJCBLBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F820", Offset = "0x2C5E820", VA = "0x182C5F820", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FF10", Offset = "0x2C5EF10", VA = "0x182C5FF10")]
	public GMLEHANOGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class AFFBNPIAHOM
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A660A0", Offset = "0x2A650A0", VA = "0x182A660A0")]
	public static void IDENMLGOFHB(this AGINBCFDEDM INFJLMMKNPA, ReadOnlyMemory<byte> FFPKNKEACPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2277400", Offset = "0x2276400", VA = "0x182277400")]
	public static void AOMBALNDCDK<T>(this AGINBCFDEDM INFJLMMKNPA, in T DFEOJBAFBHE) where T : struct, JHGAIKODJEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2277530", Offset = "0x2276530", VA = "0x182277530")]
	public static T LLEHKKLGDKD<T>(this AGINBCFDEDM INFJLMMKNPA) where T : struct, JHGAIKODJEE
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A65EC0", Offset = "0x2A64EC0", VA = "0x182A65EC0")]
	public static void AOMBALNDCDK(this AGINBCFDEDM INFJLMMKNPA, GNADOFADBFA KHHCHKEIKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A66120", Offset = "0x2A65120", VA = "0x182A66120")]
	public static GNADOFADBFA IINAGFAHFBO(this AGINBCFDEDM INFJLMMKNPA)
	{
		return default(GNADOFADBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A65EF0", Offset = "0x2A64EF0", VA = "0x182A65EF0")]
	public static void GHLDLHMAHNN(this AGINBCFDEDM GAKCPFEFIJJ, uint CCMCDGFOLOD, bool HDDAGFDDALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A66150", Offset = "0x2A65150", VA = "0x182A66150")]
	public static uint LGJLCPHFJJC(this AGINBCFDEDM NINBMPMOGGB, bool HDDAGFDDALC = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class HBKEEDIMCED
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class FAKDCNBEDHF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public FAKDCNBEDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x23ADD40", Offset = "0x23ACD40", VA = "0x1823ADD40")]
		internal void <GetByteEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x23ADDB0", Offset = "0x23ACDB0", VA = "0x1823ADDB0")]
		internal T <GetByteEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class OIOCBIIOBPE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public OIOCBIIOBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x25F0790", Offset = "0x25EF790", VA = "0x1825F0790")]
		internal void <GetSByteEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x25F0800", Offset = "0x25EF800", VA = "0x1825F0800")]
		internal T <GetSByteEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class HHEACIKECGL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public HHEACIKECGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3188110", Offset = "0x3187110", VA = "0x183188110")]
		internal void <GetShortEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3188180", Offset = "0x3187180", VA = "0x183188180")]
		internal T <GetShortEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class DKBPNDIOIGG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public DKBPNDIOIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x28D6430", Offset = "0x28D5430", VA = "0x1828D6430")]
		internal void <GetUShortEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x28D64A0", Offset = "0x28D54A0", VA = "0x1828D64A0")]
		internal T <GetUShortEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class BMKAGKEDENN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public BMKAGKEDENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x240B6F0", Offset = "0x240A6F0", VA = "0x18240B6F0")]
		internal void <GetIntEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x240B750", Offset = "0x240A750", VA = "0x18240B750")]
		internal T <GetIntEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class MPIPAECLCCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public MPIPAECLCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C986C0", Offset = "0x2C976C0", VA = "0x182C986C0")]
		internal void <GetUIntEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C98720", Offset = "0x2C97720", VA = "0x182C98720")]
		internal T <GetUIntEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x225DA70", Offset = "0x225CA70", VA = "0x18225DA70")]
	public static void PJHPOEDPHAP<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x225D680", Offset = "0x225C680", VA = "0x18225D680")]
	private static void BBEJNLDDDDF<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x225D680", Offset = "0x225C680", VA = "0x18225D680")]
	private static void MPJDBLBAFBF<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x225D7D0", Offset = "0x225C7D0", VA = "0x18225D7D0")]
	private static void EPCNHLBNBEL<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x225D7D0", Offset = "0x225C7D0", VA = "0x18225D7D0")]
	private static void LAMEMNNBEPM<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x225D920", Offset = "0x225C920", VA = "0x18225D920")]
	private static void EPPJAKECMED<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x225D920", Offset = "0x225C920", VA = "0x18225D920")]
	private static void MPMBNEHFOBP<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class BLFFKOKMHAL : MAAAHNNGDPO, BDDJKMOFDGN
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A69FF0", Offset = "0x2A68FF0", VA = "0x182A69FF0", Slot = "4")]
	private void LBHGPOAHGNB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LCPPLAMNAHP(OBCIKAMHODM JDJBDCDEPOJ);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	protected BLFFKOKMHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ILPFPDPNEBP(typeof(LocalPoseData))]
public sealed class OPIABACGHAB : BLFFKOKMHAL
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2974390", Offset = "0x2973390", VA = "0x182974390", Slot = "5")]
	protected override void LCPPLAMNAHP(OBCIKAMHODM JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public OPIABACGHAB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class CopyAuthorityToEntity : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery PNNDDOKIOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery FNGMEOGCPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery DOFIHHGOMII;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A75590", Offset = "0x2A74590", VA = "0x182A75590", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A757B0", Offset = "0x2A747B0", VA = "0x182A757B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A75930", Offset = "0x2A74930", VA = "0x182A75930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A75900", Offset = "0x2A74900", VA = "0x182A75900", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A75170", Offset = "0x2A74170", VA = "0x182A75170")]
		private void HPLDDOPGLEJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A74AE0", Offset = "0x2A73AE0", VA = "0x182A74AE0")]
		private void ADLAMFBLCBI(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C80", Offset = "0x2A73C80", VA = "0x182A74C80")]
		private void AOMEGMOOHCA(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A75600", Offset = "0x2A74600", VA = "0x182A75600")]
		private void NBNODMLDOGB(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A74F60", Offset = "0x2A73F60", VA = "0x182A74F60")]
		private void BEIAGKCNPMD(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A754B0", Offset = "0x2A744B0", VA = "0x182A754B0")]
		private void LGEPMIOMCBC(PMFFIMLMCEJ GMOMNBJDADO, int IFEILBLHHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class KDDGAFHJKED : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CD80", Offset = "0x2C6BD80", VA = "0x182C6CD80", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D3B0", Offset = "0x2C6C3B0", VA = "0x182C6D3B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D470", Offset = "0x2C6C470", VA = "0x182C6D470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CDD0", Offset = "0x2C6BDD0", VA = "0x182C6CDD0")]
	private void OAJODGFGBPM(NativeArray<Entity> BNEBECKGGLP, NativeList<Entity> HECABBCJCKD, ComponentDataFromEntity<JEFKALPCHJH> LICDJNDNDJK, BufferFromEntity<ChildrenData> CMFGHFEEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public KDDGAFHJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class EAHJJDHMJFG : ParentSystemBase<AuthoredParentData, CMKCMMGCODO, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E390", Offset = "0x2A7D390", VA = "0x182A7E390", Slot = "14")]
	protected override EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7296B0", Offset = "0x7286B0", VA = "0x1807296B0", Slot = "15")]
	protected override EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E350", Offset = "0x2A7D350", VA = "0x182A7E350", Slot = "16")]
	protected override EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E310", Offset = "0x2A7D310", VA = "0x182A7E310", Slot = "17")]
	protected override EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E410", Offset = "0x2A7D410", VA = "0x182A7E410")]
	public EAHJJDHMJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E3D0", Offset = "0x2A7D3D0", VA = "0x182A7E3D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class DIMCHFHJAJC : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object AEMINPHNBOP;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A810", Offset = "0x2A79810", VA = "0x182A7A810", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A890", Offset = "0x2A79890", VA = "0x182A7A890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A930", Offset = "0x2A79930", VA = "0x182A7A930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public DIMCHFHJAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class AEHIIPEENNN : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object AEMINPHNBOP;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2A659D0", Offset = "0x2A649D0", VA = "0x182A659D0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2A65A50", Offset = "0x2A64A50", VA = "0x182A65A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2A65AF0", Offset = "0x2A64AF0", VA = "0x182A65AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public AEHIIPEENNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct KCLMHFFOANM : ISystemStateBufferElementData, IBufferElementData, IEquatable<KCLMHFFOANM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public KEOMFONJOJH DCLMHANFEGK;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CD30", Offset = "0x2C6BD30", VA = "0x182C6CD30", Slot = "4")]
	public bool Equals(KCLMHFFOANM KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500")]
	public static KCLMHFFOANM LFOOIECCIPM(KEOMFONJOJH DCLMHANFEGK)
	{
		return default(KCLMHFFOANM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct DMDIEKGLKBI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public KEOMFONJOJH DCLMHANFEGK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500")]
	public static DMDIEKGLKBI LFOOIECCIPM(KEOMFONJOJH DCLMHANFEGK)
	{
		return default(DMDIEKGLKBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class LBEDOOFEKFO : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2C70730", Offset = "0x2C6F730", VA = "0x182C70730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2C708C0", Offset = "0x2C6F8C0", VA = "0x182C708C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	protected LBEDOOFEKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[EJCMEBPBPBF]
internal abstract class JLLPLKHKBAO : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected IGKHNFEAAFE MFNIBBKJICM;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B940", Offset = "0x2C6A940", VA = "0x182C6B940", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B3D0", Offset = "0x2C6A3D0", VA = "0x182C6B3D0")]
	protected void BKEDNLGMILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B6C0", Offset = "0x2C6A6C0", VA = "0x182C6B6C0")]
	protected void HBEIGBNPLOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B650", Offset = "0x2C6A650", VA = "0x182C6B650")]
	protected CIMNJIOJIIP EMCOOIHDBGP()
	{
		return default(CIMNJIOJIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	protected JLLPLKHKBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class NEGGDLIOOMB : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x29717C0", Offset = "0x29707C0", VA = "0x1829717C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2971950", Offset = "0x2970950", VA = "0x182971950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x29719F0", Offset = "0x29709F0", VA = "0x1829719F0")]
	protected NEGGDLIOOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class FPOFKLIIBEE : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B230", Offset = "0x2C5A230", VA = "0x182C5B230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B340", Offset = "0x2C5A340", VA = "0x182C5B340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	protected FPOFKLIIBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class GDDCKGDKLNN : LBEDOOFEKFO
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CF80", Offset = "0x2C5BF80", VA = "0x182C5CF80", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public GDDCKGDKLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class GMOGIPDPHMP : NEGGDLIOOMB
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2C60070", Offset = "0x2C5F070", VA = "0x182C60070", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x2C600E0", Offset = "0x2C5F0E0", VA = "0x182C600E0")]
	public GMOGIPDPHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x29719F0", Offset = "0x29709F0", VA = "0x1829719F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class ANCHBAJCLCK : FPOFKLIIBEE
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2A66860", Offset = "0x2A65860", VA = "0x182A66860", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x29719F0", Offset = "0x29709F0", VA = "0x1829719F0")]
	public ANCHBAJCLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class JMGDMDHGGFO : LBEDOOFEKFO
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BA20", Offset = "0x2C6AA20", VA = "0x182C6BA20", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public JMGDMDHGGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class JLMNPLMGKKI : NEGGDLIOOMB
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B9B0", Offset = "0x2C6A9B0", VA = "0x182C6B9B0", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2C600E0", Offset = "0x2C5F0E0", VA = "0x182C600E0")]
	public JLMNPLMGKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x29719F0", Offset = "0x29709F0", VA = "0x1829719F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class FNHKDFACJOH : FPOFKLIIBEE
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override FGKJJIHFJDO MOHIIMDMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B1C0", Offset = "0x2C5A1C0", VA = "0x182C5B1C0", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public FNHKDFACJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct CPCODCDAHNM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct FPBJHNBDGIA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct MJDAAKOEEEK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct FGKJJIHFJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType JCHPDENPJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType IPNLFJPKKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object KCCFEDJJGAN;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2C58B90", Offset = "0x2C57B90", VA = "0x182C58B90")]
	public FGKJJIHFJDO(ComponentType JCHPDENPJBC, ComponentType IPNLFJPKKOM, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x27E28C0", Offset = "0x27E18C0", VA = "0x1827E28C0")]
	public static FGKJJIHFJDO GNCNGCOCOBN<TReq, TTag>(object KCCFEDJJGAN)
	{
		return default(FGKJJIHFJDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class FHBBJNODCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string OHHDNAJLLNE = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string IJJJLHJGFCD = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly FGKJJIHFJDO DLBKDKKEPBL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly FGKJJIHFJDO MHOFGIAAICE;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct KEOMFONJOJH : global::GAMKFLDBKPP<KEOMFONJOJH>, BCAIPGNNKGO, IEquatable<KEOMFONJOJH>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x72FD90", Offset = "0x72ED90", VA = "0x18072FD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xDED3C0", Offset = "0xDEC3C0", VA = "0x180DED3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DB90", Offset = "0x2C6CB90", VA = "0x182C6DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CD30", Offset = "0x2C6BD30", VA = "0x182C6CD30", Slot = "8")]
	public bool Equals(KEOMFONJOJH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DBD0", Offset = "0x2C6CBD0", VA = "0x182C6DBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[EJCMEBPBPBF]
	[LMNMHFHDONH(IPKPBIMLPOB.Connectables)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class UpdateConnectableVisuals : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct LCNIHBLPIPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public KEOMFONJOJH DCLMHANFEGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 IJBELJOFGFA;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x4142D10", Offset = "0x4141D10", VA = "0x184142D10")]
			public LCNIHBLPIPJ(KEOMFONJOJH DCLMHANFEGK, float3 IJBELJOFGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x4142CF0", Offset = "0x4141CF0", VA = "0x184142CF0")]
			public void KONCNEDHOLC(out KEOMFONJOJH DCLMHANFEGK, out float3 IJBELJOFGFA)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct JCALFAFDBBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<LCNIHBLPIPJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
			public JCALFAFDBBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<DMDIEKGLKBI> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct EIGEOPMDOAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<LCNIHBLPIPJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
			public EIGEOPMDOAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<KCLMHFFOANM> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct GIDNDLCODMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<LCNIHBLPIPJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
			public GIDNDLCODMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in LNABMIPCKIO com, in DynamicBuffer<KCLMHFFOANM> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct IGFNLINIMBF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct HFBNKBKHNNN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct DJHPAJFOECE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KMOMOMMAOJA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<DMDIEKGLKBI>.Runtime APNFNNOBNHI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> IDOHFGGKEFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DMDIEKGLKBI> BIDCBJPKHCA;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x413FBC0", Offset = "0x413EBC0", VA = "0x18413FBC0")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x413FB00", Offset = "0x413EB00", VA = "0x18413FB00")]
				public DJHPAJFOECE EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(DJHPAJFOECE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals EBMLNNICADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<LCNIHBLPIPJ> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private HFBNKBKHNNN IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HFBNKBKHNNN.DJHPAJFOECE* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x41409C0", Offset = "0x413F9C0", VA = "0x1841409C0")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, WorldPoseData JLELBDHDMMK, in DynamicBuffer<DMDIEKGLKBI> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x4140E60", Offset = "0x413FE60", VA = "0x184140E60", Slot = "5")]
			public void ReadFromDisplayClass(ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x4140E90", Offset = "0x413FE90", VA = "0x184140E90", Slot = "6")]
			public void WriteToDisplayClass(ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x4140C00", Offset = "0x413FC00", VA = "0x184140C00", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x4140CE0", Offset = "0x413FCE0", VA = "0x184140CE0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref HFBNKBKHNNN.DJHPAJFOECE MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x4140E20", Offset = "0x413FE20", VA = "0x184140E20")]
			public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM, ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x4140950", Offset = "0x413F950", VA = "0x184140950")]
			public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct IBIMOBHODMA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct PGHCHHNCEAI
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct EMPOFFOONLJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KMOMOMMAOJA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<KCLMHFFOANM>.Runtime APNFNNOBNHI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> IDOHFGGKEFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<KCLMHFFOANM> BIDCBJPKHCA;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x4146210", Offset = "0x4145210", VA = "0x184146210")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x4146170", Offset = "0x4145170", VA = "0x184146170")]
				public EMPOFFOONLJ EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(EMPOFFOONLJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<LCNIHBLPIPJ> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private PGHCHHNCEAI IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PGHCHHNCEAI.EMPOFFOONLJ* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x41403F0", Offset = "0x413F3F0", VA = "0x1841403F0")]
			internal void EACJNOHFKHL(in WorldPoseData JLELBDHDMMK, in DynamicBuffer<KCLMHFFOANM> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00380", VA = "0x182B01380", Slot = "5")]
			public void ReadFromDisplayClass(ref EIGEOPMDOAE ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x4140500", Offset = "0x413F500", VA = "0x184140500", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x41405D0", Offset = "0x413F5D0", VA = "0x1841405D0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref PGHCHHNCEAI.EMPOFFOONLJ MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x41406A0", Offset = "0x413F6A0", VA = "0x1841406A0")]
			public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM, ref EIGEOPMDOAE ENNMBDEBHBB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct JHIJEBDBEHC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct AGKIADCAONN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct OHLMFMGCGOM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime KMOMOMMAOJA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<LNABMIPCKIO>.Runtime GHLBGANCIIJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<KCLMHFFOANM>.Runtime APNFNNOBNHI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> IDOHFGGKEFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LNABMIPCKIO> JEOMKDMPHOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<KCLMHFFOANM> BIDCBJPKHCA;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x413BB50", Offset = "0x413AB50", VA = "0x18413BB50")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x413BA80", Offset = "0x413AA80", VA = "0x18413BA80")]
				public OHLMFMGCGOM EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(OHLMFMGCGOM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<LCNIHBLPIPJ> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private AGKIADCAONN IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AGKIADCAONN.OHLMFMGCGOM* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x4141670", Offset = "0x4140670", VA = "0x184141670")]
			internal void EACJNOHFKHL(in WorldPoseData JLELBDHDMMK, in LNABMIPCKIO EAFAMHNKMAN, in DynamicBuffer<KCLMHFFOANM> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00380", VA = "0x182B01380", Slot = "5")]
			public void ReadFromDisplayClass(ref GIDNDLCODMD ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x41417D0", Offset = "0x41407D0", VA = "0x1841417D0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x4141850", Offset = "0x4140850", VA = "0x184141850")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref AGKIADCAONN.OHLMFMGCGOM MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x4141970", Offset = "0x4140970", VA = "0x184141970")]
			public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM, ref GIDNDLCODMD ENNMBDEBHBB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery CKGPCFIHFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery LKJHHJOECDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery DPFFHPIEFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery APLDOGOIGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery JDMGNDFLIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery ODPPHOONPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery PJDMPOGOOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery DMCBCAHKFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery KHDGEIEEADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery AELPLBNGCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::AOPGFFKJFJG<KEOMFONJOJH, AKFIDAIPMLM> JLJGAMCGJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private DACMFIPKNDK BGONJHEABPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private KHAPNLPCPDI IGMJMLJDCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private HAACLMBMGHG NMNGIHMGHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery CKMAECHHKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker IGPKINAKJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery LPFONOOOFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery ABOEFNMBOEC;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2B14EE0", Offset = "0x2B13EE0", VA = "0x182B14EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2B14810", Offset = "0x2B13810", VA = "0x182B14810")]
		internal AKFIDAIPMLM AJCANACNOFA(KEOMFONJOJH DCLMHANFEGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2B16550", Offset = "0x2B15550", VA = "0x182B16550", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2B16DA0", Offset = "0x2B15DA0", VA = "0x182B16DA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2B17020", Offset = "0x2B16020", VA = "0x182B17020", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B171B0", Offset = "0x2B161B0", VA = "0x182B171B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2B16FE0", Offset = "0x2B15FE0", VA = "0x182B16FE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2B18BC0", Offset = "0x2B17BC0", VA = "0x182B18BC0")]
		private void POCNMCEHADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B16190", Offset = "0x2B15190", VA = "0x182B16190")]
		private void MAAJJOGKAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2B155E0", Offset = "0x2B145E0", VA = "0x182B155E0")]
		private void FJGKBGPNAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2B171F0", Offset = "0x2B161F0", VA = "0x182B171F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2B17BD0", Offset = "0x2B16BD0", VA = "0x182B17BD0")]
		private void PGLCEDHDGGL(EntityQuery PNNDDOKIOOP, EntityQuery COEFDEGAPFE, EntityQuery FNGMEOGCPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2B15090", Offset = "0x2B14090", VA = "0x182B15090")]
		private void FAHLDBEBGON(EntityQuery FNGMEOGCPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B15300", Offset = "0x2B14300", VA = "0x182B15300")]
		private void FFJGIONJDGJ(global::OKGGDJPONBN<Entity> KMJKKFBOOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2B15990", Offset = "0x2B14990", VA = "0x182B15990")]
		private void HDJDACNMDAE(global::OKGGDJPONBN<Entity> KIDGEKMGAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2B168A0", Offset = "0x2B158A0", VA = "0x182B168A0")]
		private void OCFKHAEHNHE(global::OKGGDJPONBN<Entity> KFDDFKJABKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2B14F20", Offset = "0x2B13F20", VA = "0x182B14F20")]
		private void CIEKIIPIFOM(NativeList<KEOMFONJOJH> NGPENBBOCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2B186A0", Offset = "0x2B176A0", VA = "0x182B186A0")]
		private NativeList<KEOMFONJOJH> PLADAALKJOH(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<KEOMFONJOJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2B175B0", Offset = "0x2B165B0", VA = "0x182B175B0")]
		private void PEHKHPOGJPN(NativeArray<Entity> BNEBECKGGLP, NativeList<KEOMFONJOJH> NGPENBBOCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2B15AA0", Offset = "0x2B14AA0", VA = "0x182B15AA0")]
		private void KMIAPPHEAOL(NativeArray<Entity> FPIDLIBAEHG, NativeArray<Entity> ALBBMILABNK, NativeList<KEOMFONJOJH> NIEHJLCAJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2B180B0", Offset = "0x2B170B0", VA = "0x182B180B0")]
		private void PHGGPDCMBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2B18560", Offset = "0x2B17560", VA = "0x182B18560")]
		private global::LNAIBACCGLG<LCNIHBLPIPJ> PKDCPHEBPAD(EntityQuery FBENFNFLPOM, Func<NativeList<LCNIHBLPIPJ>, JobHandle> PEAABMHIGIG)
		{
			return default(global::LNAIBACCGLG<LCNIHBLPIPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2B14AF0", Offset = "0x2B13AF0", VA = "0x182B14AF0")]
		private JobHandle BCDGDKAFBAK(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2B151C0", Offset = "0x2B141C0", VA = "0x182B151C0")]
		private JobHandle FCBJEDIMFDO(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B16B10", Offset = "0x2B15B10", VA = "0x182B16B10")]
		private JobHandle OOPHJHCPIKE(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2B14860", Offset = "0x2B13860", VA = "0x182B14860")]
		private void BBAHDJELAJD(global::LNAIBACCGLG<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2B17320", Offset = "0x2B16320", VA = "0x182B17320")]
		private void PDLJKPHJPMA(global::LNAIBACCGLG<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2B15160", Offset = "0x2B14160", VA = "0x182B15160")]
		private bool FCAEBNMKBNG(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2B16A40", Offset = "0x2B15A40", VA = "0x182B16A40")]
		private NativeArray<Entity> ONCONKFOHAE(Entity IEFFOCOBJJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2B15FD0", Offset = "0x2B14FD0", VA = "0x182B15FD0")]
		private KEOMFONJOJH LAPBPPFIJKN(NativeList<KEOMFONJOJH> NIEHJLCAJEN)
		{
			return default(KEOMFONJOJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2B16610", Offset = "0x2B15610", VA = "0x182B16610")]
		private void MPEKBDKBEIE(KEOMFONJOJH DCLMHANFEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2B16C40", Offset = "0x2B15C40", VA = "0x182B16C40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2B166A0", Offset = "0x2B156A0", VA = "0x182B166A0")]
		public static EntityQuery OBOLFHGDNNI(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2B14C80", Offset = "0x2B13C80", VA = "0x182B14C80")]
		public static EntityQuery BKABJGMDPEP(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2B162E0", Offset = "0x2B152E0", VA = "0x182B162E0")]
		public static EntityQuery MHONAPDDGCG(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[LMNMHFHDONH(IPKPBIMLPOB.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private BCIOKJKBEBJ NJHJPKKCNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private DLDJNBAJPKI KHDMFOLFIDI;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2986F10", Offset = "0x2985F10", VA = "0x182986F10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2986E80", Offset = "0x2985E80", VA = "0x182986E80", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2987010", Offset = "0x2986010", VA = "0x182987010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class FADFMPBIOEN : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public GEINEDFCGEN NKDJGKIHEEA;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FADFMPBIOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	public FADFMPBIOEN(GEINEDFCGEN NKDJGKIHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2C581D0", Offset = "0x2C571D0", VA = "0x182C581D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LPONIDGDICL : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService ADDOLKFBKIO;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x2C72BA0", Offset = "0x2C71BA0", VA = "0x182C72BA0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x2C72C00", Offset = "0x2C71C00", VA = "0x182C72C00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2C72C30", Offset = "0x2C71C30", VA = "0x182C72C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	protected LPONIDGDICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class HDKBBILLNDN : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery MHKIKHPHHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery MGDJLALCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery FJDIIMNBMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery IJMAFOKEDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService BPNGHPMJGIC;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int NIINPFLMDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2C61910", Offset = "0x2C60910", VA = "0x182C61910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int FNGDFEABKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2C614B0", Offset = "0x2C604B0", VA = "0x182C614B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2C61990", Offset = "0x2C60990", VA = "0x182C61990", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2C61B90", Offset = "0x2C60B90", VA = "0x182C61B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2C61D90", Offset = "0x2C60D90", VA = "0x182C61D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C618F0", Offset = "0x2C608F0", VA = "0x182C618F0")]
	public int KLEILBIFCLP(SceneTag PPJNHEBGICL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C61DB0", Offset = "0x2C60DB0", VA = "0x182C61DB0")]
	public int POIOKMGKODA(SceneTag PPJNHEBGICL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C61600", Offset = "0x2C60600", VA = "0x182C61600")]
	protected void JDEGDGPEHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C61A80", Offset = "0x2C60A80", VA = "0x182C61A80")]
	protected void NBNDKABMFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C614C0", Offset = "0x2C604C0", VA = "0x182C614C0")]
	public global::OKGGDJPONBN<Entity> CGAIJGAIMNI(SceneTag PPJNHEBGICL, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(global::OKGGDJPONBN<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C615B0", Offset = "0x2C605B0", VA = "0x182C615B0")]
	public global::OKGGDJPONBN<Entity> IAEFKIIKCHF(SceneTag PPJNHEBGICL, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(global::OKGGDJPONBN<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C619F0", Offset = "0x2C609F0", VA = "0x182C619F0")]
	public bool MNFPMFNOAPO(SceneTag PPJNHEBGICL, out global::OKGGDJPONBN<Entity> NKDJGKIHEEA, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C61890", Offset = "0x2C60890", VA = "0x182C61890")]
	public bool KFLIOAAFEFM(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C61820", Offset = "0x2C60820", VA = "0x182C61820")]
	public GEINEDFCGEN JKHNBLPIIAC(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C61920", Offset = "0x2C60920", VA = "0x182C61920")]
	public bool MAKGCDLBBBK(Entity IEFFOCOBJJI, out FADFMPBIOEN NKDJGKIHEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C61510", Offset = "0x2C60510", VA = "0x182C61510")]
	public void DIGPHILJGLP(Entity IEFFOCOBJJI, FADFMPBIOEN NKDJGKIHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C61550", Offset = "0x2C60550", VA = "0x182C61550")]
	public bool EDKKGBDGEDF(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void EOIIGNKEEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public HDKBBILLNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class PKNHBBAJCOA : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery HONFHEKEKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private ALAPBINNPIH ACNDHAIKGGB;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x29813F0", Offset = "0x29803F0", VA = "0x1829813F0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2981440", Offset = "0x2980440", VA = "0x182981440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2981500", Offset = "0x2980500", VA = "0x182981500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3ABA0", Offset = "0x2F39BA0", VA = "0x182F3ABA0")]
	private bool IMBNFDILLLN<TComponentData>(EntityQuery FBENFNFLPOM, out NativeArray<Entity> BNEBECKGGLP, out NativeArray<TComponentData> IHFNCPHANDK) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2981380", Offset = "0x2980380", VA = "0x182981380")]
	public GEINEDFCGEN JKHNBLPIIAC(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public PKNHBBAJCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[LMNMHFHDONH(IPKPBIMLPOB.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery EDOCIAAFAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery OKMCIJOEFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery PLJEKDLAMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery DOFIHHGOMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B097E0", Offset = "0x2B087E0", VA = "0x182B097E0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B09830", Offset = "0x2B08830", VA = "0x182B09830", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B09A60", Offset = "0x2B08A60", VA = "0x182B09A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B09770", Offset = "0x2B08770", VA = "0x182B09770")]
		private void HMNAIPBHJIK(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B093A0", Offset = "0x2B083A0", VA = "0x182B093A0")]
		private void FAHLDBEBGON(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B099F0", Offset = "0x2B089F0", VA = "0x182B099F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B09410", Offset = "0x2B08410", VA = "0x182B09410")]
		private void HKPCHNMPOKA(EntityQuery FBENFNFLPOM, bool FLGLFAGJDGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class MBNMHOKMFEL : GAJBCDLDAEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct GOOPLIAJADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public GOOPLIAJADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct FHFKCHCCPFL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct BAOECGMKKJA
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct APEGMMHALNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FKBKHGEPAEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime ANFKLNFMAJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime LAAHJCPANOF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity MHCHHGEMDEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> HMEOIILHMJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> ONCFCHOHLME;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x413C170", Offset = "0x413B170", VA = "0x18413C170")]
			public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x413C0B0", Offset = "0x413B0B0", VA = "0x18413C0B0")]
			public APEGMMHALNC EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(APEGMMHALNC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private BAOECGMKKJA IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BAOECGMKKJA.APEGMMHALNC* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x413EB70", Offset = "0x413DB70", VA = "0x18413EB70")]
		internal void EACJNOHFKHL(Entity CJCOOPPJGHI, SplineShapeData GJBHFPJIHBB, DynamicBuffer<LinkedEntityGroup> FAHBHODOFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x413EBD0", Offset = "0x413DBD0", VA = "0x18413EBD0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x413ECA0", Offset = "0x413DCA0", VA = "0x18413ECA0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref BAOECGMKKJA.APEGMMHALNC MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x413EDC0", Offset = "0x413DDC0", VA = "0x18413EDC0")]
		public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CHFGOHLIBFO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct OFBDNECDBID
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct IPCKBDEMKCI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime EGCPJBLMECF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime NFMOAEKBPNK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity KDAABBPLLPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> IEMKPBJDEJE;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x4145580", Offset = "0x4144580", VA = "0x184145580")]
			public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x4145500", Offset = "0x4144500", VA = "0x184145500")]
			public IPCKBDEMKCI EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(IPCKBDEMKCI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> NICLIADLLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private OFBDNECDBID IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OFBDNECDBID.IPCKBDEMKCI* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x413DC80", Offset = "0x413CC80", VA = "0x18413DC80")]
		internal void EACJNOHFKHL(Entity KBGCHGICHIL, SplinePointParentData IHNIIIEMDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x413DEF0", Offset = "0x413CEF0", VA = "0x18413DEF0", Slot = "5")]
		public void ReadFromDisplayClass(ref GOOPLIAJADN ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x413DD10", Offset = "0x413CD10", VA = "0x18413DD10", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x413DDB0", Offset = "0x413CDB0", VA = "0x18413DDB0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref OFBDNECDBID.IPCKBDEMKCI MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x413DE60", Offset = "0x413CE60", VA = "0x18413DE60")]
		public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM, ref GOOPLIAJADN ENNMBDEBHBB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery HAJJMFHLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery HKGINBPGOCM;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x296C300", Offset = "0x296B300", VA = "0x18296C300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x296C3B0", Offset = "0x296B3B0", VA = "0x18296C3B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public MBNMHOKMFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x296C060", Offset = "0x296B060", VA = "0x18296C060", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x296BEC0", Offset = "0x296AEC0", VA = "0x18296BEC0")]
	public static EntityQuery MCKOELHBGOE(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x296BD60", Offset = "0x296AD60", VA = "0x18296BD60")]
	public static EntityQuery LFFIIFDCHAI(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public sealed class DDBEFDIFMNB : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EGFHGGJBAIJ NOGKPMLPCFD;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A79A40", Offset = "0x2A78A40", VA = "0x182A79A40", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AA0", Offset = "0x2A78AA0", VA = "0x182A79AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public DDBEFDIFMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class DBALFPEDPGG : GAJBCDLDAEF, BDDJKMOFDGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct EEAGLJNDKPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<GGMEAKIAMAM> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<MLDEGJAOMMP> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<GGMEAKIAMAM> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public EEAGLJNDKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, JOLFHHMPJFM previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__2(Entity entity, JOLFHHMPJFM previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct NLOCEMCEBNF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct JHAOLPCHFIE
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct FJAMMLIOCBB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime IMHEKDEDMCE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IDFLNKNNNGN;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x4141610", Offset = "0x4140610", VA = "0x184141610")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x4141590", Offset = "0x4140590", VA = "0x184141590")]
			public FJAMMLIOCBB EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(FJAMMLIOCBB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<GGMEAKIAMAM> OFNKHIAKKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private JHAOLPCHFIE IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JHAOLPCHFIE.FJAMMLIOCBB* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B03770", Offset = "0x2B02770", VA = "0x182B03770")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData JFKHJAJODDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00380", VA = "0x182B01380", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B037F0", Offset = "0x2B027F0", VA = "0x182B037F0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B03860", Offset = "0x2B02860", VA = "0x182B03860")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref JHAOLPCHFIE.FJAMMLIOCBB MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B03910", Offset = "0x2B02910", VA = "0x182B03910")]
		public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM, ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct KPBIAMJLFJN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct BCGAFKNFAKP
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct NCCGJBKFDCO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime IMHEKDEDMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<JOLFHHMPJFM>.Runtime GPOCCJLONPN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IDFLNKNNNGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JOLFHHMPJFM> GOLOKALFGMC;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x413C290", Offset = "0x413B290", VA = "0x18413C290")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x413C1F0", Offset = "0x413B1F0", VA = "0x18413C1F0")]
			public NCCGJBKFDCO EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(NCCGJBKFDCO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<MLDEGJAOMMP> AMPKAIHCHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private BCGAFKNFAKP IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BCGAFKNFAKP.NCCGJBKFDCO* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B02AE0", Offset = "0x2B01AE0", VA = "0x182B02AE0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData JFKHJAJODDL, JOLFHHMPJFM MBHNFHEJPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B02D30", Offset = "0x2B01D30", VA = "0x182B02D30", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B02BA0", Offset = "0x2B01BA0", VA = "0x182B02BA0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C10", Offset = "0x2B01C10", VA = "0x182B02C10")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref BCGAFKNFAKP.NCCGJBKFDCO MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B02CF0", Offset = "0x2B01CF0", VA = "0x182B02CF0")]
		public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM, ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct CBOLNLJKJEI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct OLDEBPPHGCK
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct BBIFCAGLHAN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<JOLFHHMPJFM>.Runtime GPOCCJLONPN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JOLFHHMPJFM> GOLOKALFGMC;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x41459C0", Offset = "0x41449C0", VA = "0x1841459C0")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x4145940", Offset = "0x4144940", VA = "0x184145940")]
			public BBIFCAGLHAN EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(BBIFCAGLHAN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<GGMEAKIAMAM> ABONCKHPPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private OLDEBPPHGCK IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OLDEBPPHGCK.BBIFCAGLHAN* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1C0", Offset = "0x2AFE1C0", VA = "0x182AFF1C0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, JOLFHHMPJFM MBHNFHEJPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF3A0", Offset = "0x2AFE3A0", VA = "0x182AFF3A0", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF240", Offset = "0x2AFE240", VA = "0x182AFF240", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2B0", Offset = "0x2AFE2B0", VA = "0x182AFF2B0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref OLDEBPPHGCK.BBIFCAGLHAN MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF360", Offset = "0x2AFE360", VA = "0x182AFF360")]
		public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM, ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private BBDBBCGEPIJ CHLGOACIFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery JIECMGLJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery NDOALKOAAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery JBGFHKILLAN;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A78B00", Offset = "0x2A77B00", VA = "0x182A78B00", Slot = "14")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A790A0", Offset = "0x2A780A0", VA = "0x182A790A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public DBALFPEDPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A79040", Offset = "0x2A78040", VA = "0x182A79040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A78BE0", Offset = "0x2A77BE0", VA = "0x182A78BE0")]
	public static EntityQuery CAAGDHKOCMJ(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A788D0", Offset = "0x2A778D0", VA = "0x182A788D0")]
	public static EntityQuery AHDEBAHJNDB(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A78E40", Offset = "0x2A77E40", VA = "0x182A78E40")]
	public static EntityQuery KPPLNABMGFM(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[LMNMHFHDONH(IPKPBIMLPOB.Connectables)]
	public class InitializeRigidbodyExHierarchy : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private HOOGGJCBAFC ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C693F0", Offset = "0x2C683F0", VA = "0x182C693F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C69380", Offset = "0x2C68380", VA = "0x182C69380", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C69480", Offset = "0x2C68480", VA = "0x182C69480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class GHEOPIIMCDK : ParentSystemBase<ParentData, JOLFHHMPJFM, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D910", Offset = "0x2C5C910", VA = "0x182C5D910", Slot = "14")]
	protected override EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x7296B0", Offset = "0x7286B0", VA = "0x1807296B0", Slot = "15")]
	protected override EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D8D0", Offset = "0x2C5C8D0", VA = "0x182C5D8D0", Slot = "16")]
	protected override EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D890", Offset = "0x2C5C890", VA = "0x182C5D890", Slot = "17")]
	protected override EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D990", Offset = "0x2C5C990", VA = "0x182C5D990")]
	public GHEOPIIMCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D950", Offset = "0x2C5C950", VA = "0x182C5D950", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : GAJBCDLDAEF where ParentData : struct, IComponentData, LFJBLBLGJHE where PreviousParentData : struct, IComponentData, LFJBLBLGJHE where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LFJBLBLGJHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct DFPEIOOKFDJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MBMLIFMIDGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter HAFOOFLAGJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter KJLAHPDBHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> OLDHBKOKHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> ICIJGIDBLAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType BOCDPFIKBAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint PKCPKELNCNN;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x2895220", Offset = "0x2894220", VA = "0x182895220", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct LNINLCDIDJP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> KJLAHPDBHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KANIBILEJAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> FBNICKJBLDH;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x3A52770", Offset = "0x3A51770", VA = "0x183A52770", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct DNJLGBGOEOH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MBMLIFMIDGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> HAFOOFLAGJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> KJLAHPDBHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> KANIBILEJAP;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x28DD0D0", Offset = "0x28DC0D0", VA = "0x1828DD0D0")]
			private int PJDPOLEOOME(DynamicBuffer<ChildrenData> MIHJGHDPEEA, Entity IEFFOCOBJJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x28DCA50", Offset = "0x28DBA50", VA = "0x1828DCA50")]
			private void BECCJJKPGKB(Entity ICMEPOIJCJO, DynamicBuffer<ChildrenData> MIHJGHDPEEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x28DCE70", Offset = "0x28DBE70", VA = "0x1828DCE70")]
			private void PGPJBAPCGOM(Entity ICMEPOIJCJO, DynamicBuffer<ChildrenData> MIHJGHDPEEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x28DCD10", Offset = "0x28DBD10", VA = "0x1828DCD10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct FLPPAEHPBMF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> FLAOKOAIOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> OAIKOAKHGFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> KANIBILEJAP;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x2E06AE0", Offset = "0x2E05AE0", VA = "0x182E06AE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery FCBLBHKFOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery MCEJDLJPLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery FGNIBEHGHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery KGLNNHDNCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker FJOGDGKKHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker JGCFEOKJELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker MOIAMFIOOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker ENLJMOJPIAH;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5260", Offset = "0x2DA4260", VA = "0x182DA5260")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5080", Offset = "0x2DA4080", VA = "0x182DA5080")]
		private int PJDPOLEOOME(DynamicBuffer<ChildrenData> MIHJGHDPEEA, Entity IEFFOCOBJJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3570", Offset = "0x2DA2570", VA = "0x182DA3570")]
		private void CFAKJPIFGJC(Entity KFDBMMENHCC, Entity LMCIODJPIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7296B0", Offset = "0x7286B0", VA = "0x1807296B0", Slot = "14")]
		protected virtual EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7296B0", Offset = "0x7286B0", VA = "0x1807296B0", Slot = "15")]
		protected virtual EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7296B0", Offset = "0x7286B0", VA = "0x1807296B0", Slot = "16")]
		protected virtual EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4D10", Offset = "0x2DA3D10", VA = "0x182DA4D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3270", Offset = "0x2DA2270", VA = "0x182DA3270")]
		private void AECADGKCPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3E50", Offset = "0x2DA2E50", VA = "0x182DA3E50")]
		private void HAMBILBMIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4010", Offset = "0x2DA3010", VA = "0x182DA4010")]
		private JobHandle KLOABJBGNPE(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2DA39B0", Offset = "0x2DA29B0", VA = "0x182DA39B0")]
		private void GJLEKCELHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4FB0", Offset = "0x2DA3FB0", VA = "0x182DA4FB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x238EB60", Offset = "0x238DB60", VA = "0x18238EB60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2006A70", Offset = "0x2005A70", VA = "0x182006A70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public abstract class MINODIPADOM : GAJBCDLDAEF, BDDJKMOFDGN
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct PHMGJLOLBKJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::LNAIBACCGLG<Entity> CJEGGGDDAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::LNAIBACCGLG<Entity> FGHCPPPEIKI;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x4146590", Offset = "0x4145590", VA = "0x184146590")]
		public PHMGJLOLBKJ(NativeList<Entity> CJEGGGDDAKI, NativeList<Entity> FGHCPPPEIKI, JobHandle CPPLLJNMFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x4146510", Offset = "0x4145510", VA = "0x184146510")]
		public JobHandle MPENILFCJEH(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x4146480", Offset = "0x4145480", VA = "0x184146480", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct LHBJFFKPHJD : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum KEIODGEKLDD
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
		public NativeList<Entity> MEILALDGABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> AJPENCMMMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> IGGLOPGJCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> JNODMIHLOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public BOHBJPNCJPN JKFBBNMPPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public BOHBJPNCJPN HAFLGAJBAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> JLLDPMOHBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int DPHNJJNAMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int DEICKGDPMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private KEIODGEKLDD GOFFFFOLECI;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x4143410", Offset = "0x4142410", VA = "0x184143410", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x4143620", Offset = "0x4142620", VA = "0x184143620")]
		private void JIBJLLJOHGH(Entity IEFFOCOBJJI, bool CMGFIBOFJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x4143950", Offset = "0x4142950", VA = "0x184143950")]
		private void PBCFLMCEEMD(Entity IEFFOCOBJJI, bool CMGFIBOFJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x4143A60", Offset = "0x4142A60", VA = "0x184143A60")]
		public PHMGJLOLBKJ PNBMHBBAFDE(NativeArray<Entity> HCIALCFLHOM, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x41435A0", Offset = "0x41425A0", VA = "0x1841435A0")]
		public PHMGJLOLBKJ GLMOLACOKCE(NativeArray<Entity> HCIALCFLHOM, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x4143870", Offset = "0x4142870", VA = "0x184143870")]
		public PHMGJLOLBKJ NMEHBCJNJIF(NativeList<GGMEAKIAMAM> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x41436B0", Offset = "0x41426B0", VA = "0x1841436B0")]
		public PHMGJLOLBKJ LOPGFLONLML(NativeList<GGMEAKIAMAM> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x4143790", Offset = "0x4142790", VA = "0x184143790")]
		public PHMGJLOLBKJ NLEGPFOMEFB(NativeList<MLDEGJAOMMP> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x266A510", Offset = "0x2669510", VA = "0x18266A510")]
		private PHMGJLOLBKJ CPIBHMJGANG<T>(NativeList<T> DEEJEKFIHBB, int FIBNJGKFAOF, int IMADHAKDDOL, KEIODGEKLDD HOEJODOFJHI, JobHandle MPFKOMLNJME) where T : struct
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x41431B0", Offset = "0x41421B0", VA = "0x1841431B0")]
		private PHMGJLOLBKJ CPIBHMJGANG(NativeArray<Entity> BNEBECKGGLP, int FIBNJGKFAOF, int IMADHAKDDOL, KEIODGEKLDD HOEJODOFJHI, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery CJFMHPIPKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery CILNGFOMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private BBDBBCGEPIJ ONOJBBBIBBC;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType DLJFHHGKHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType AMCGLJABEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType OODCNKPPICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x2970AD0", Offset = "0x296FAD0", VA = "0x182970AD0")]
	protected MINODIPADOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x296F590", Offset = "0x296E590", VA = "0x18296F590", Slot = "14")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x296FA30", Offset = "0x296EA30", VA = "0x18296FA30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x296FC60", Offset = "0x296EC60", VA = "0x18296FC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x787510", Offset = "0x786510", VA = "0x180787510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x296F780", Offset = "0x296E780", VA = "0x18296F780")]
	private void LDOGDMMNDJL(NativeArray<Entity> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x296F670", Offset = "0x296E670", VA = "0x18296F670")]
	private void DIBKDOOGPKL(NativeArray<Entity> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x296F450", Offset = "0x296E450", VA = "0x18296F450")]
	private void ALIDKHKHIDI(PHMGJLOLBKJ NKDLEOPEHEM, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x296F340", Offset = "0x296E340", VA = "0x18296F340")]
	private void ALIDKHKHIDI(global::LNAIBACCGLG<Entity> JAGLIDKDBDK, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x296F7E0", Offset = "0x296E7E0", VA = "0x18296F7E0")]
	private void NNILBEEGHEL(PHMGJLOLBKJ NKDLEOPEHEM, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x296F920", Offset = "0x296E920", VA = "0x18296F920")]
	private void NNILBEEGHEL(global::LNAIBACCGLG<Entity> JAGLIDKDBDK, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x296F710", Offset = "0x296E710", VA = "0x18296F710")]
	private bool JHFGOAEJOHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public class GJCMMEINCFG : GAJBCDLDAEF, COMOMFINKHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct MCGHGAEJGJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public GJCMMEINCFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public MCGHGAEJGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HACMAFDCJCB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct HIAFAALFFOH
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct DKEBACGCBDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime KJGMNBKHLPD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LDEOENAIEIP;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x413FC50", Offset = "0x413EC50", VA = "0x18413FC50")]
			public void JCIHNCONGGN(GJCMMEINCFG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x413FC40", Offset = "0x413EC40", VA = "0x18413FC40")]
			public DKEBACGCBDC EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(DKEBACGCBDC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public GJCMMEINCFG EBMLNNICADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer NNBGHLKFNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private HIAFAALFFOH IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HIAFAALFFOH.DKEBACGCBDC* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x413F8F0", Offset = "0x413E8F0", VA = "0x18413F8F0")]
		internal void EACJNOHFKHL(Entity PBDFKDHMIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x413F120", Offset = "0x413E120", VA = "0x18413F120", Slot = "5")]
		public void ReadFromDisplayClass(ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x413F150", Offset = "0x413E150", VA = "0x18413F150", Slot = "6")]
		public void WriteToDisplayClass(ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x413FA00", Offset = "0x413EA00", VA = "0x18413FA00", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x413FA50", Offset = "0x413EA50", VA = "0x18413FA50")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref HIAFAALFFOH.DKEBACGCBDC MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x413FAC0", Offset = "0x413EAC0", VA = "0x18413FAC0")]
		public void JCIHNCONGGN(GJCMMEINCFG MFLHDNPOKPM, ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x413F880", Offset = "0x413E880", VA = "0x18413F880")]
		public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private OBMLDKENPPG BLACCPJFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private JEGLAIMIPKC FCPBNGLBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery ELDHHKMIBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker FAICFHNICNI;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E200", Offset = "0x2C5D200", VA = "0x182C5E200", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E0C0", Offset = "0x2C5D0C0", VA = "0x182C5E0C0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E260", Offset = "0x2C5D260", VA = "0x182C5E260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public GJCMMEINCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E120", Offset = "0x2C5D120", VA = "0x182C5E120", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2C5DEF0", Offset = "0x2C5CEF0", VA = "0x182C5DEF0")]
	public static EntityQuery IHIFEEJEEAF(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[EJCMEBPBPBF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public class PBOGPFPMMLO : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private JEGLAIMIPKC FCPBNGLBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService MMKJPCINEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x29803A0", Offset = "0x297F3A0", VA = "0x1829803A0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2980410", Offset = "0x297F410", VA = "0x182980410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x29804B0", Offset = "0x297F4B0", VA = "0x1829804B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public PBOGPFPMMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct DBHDJCDCOHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public FGLBLDPHAAD DCLMHANFEGK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000")]
	public static DBHDJCDCOHB LFOOIECCIPM(in FGLBLDPHAAD CCEBBLCHMLD)
	{
		return default(DBHDJCDCOHB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000")]
	public static FGLBLDPHAAD LFOOIECCIPM(in DBHDJCDCOHB KNIFPFAIBNM)
	{
		return default(FGLBLDPHAAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class OBMLDKENPPG : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2973430", Offset = "0x2972430", VA = "0x182973430", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public OBMLDKENPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public class JICHCGBEEFB : GAJBCDLDAEF, COMOMFINKHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct CEFJGCDEEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public JICHCGBEEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public CEFJGCDEEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__0(Entity e, DBHDJCDCOHB ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FICAIIPOHCE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct JKJLIMNAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct CMGCEEJFLDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime KJGMNBKHLPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<DBHDJCDCOHB>.Runtime MHEDKEFCOOC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LDEOENAIEIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<DBHDJCDCOHB> LBFOABANGFP;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x4142120", Offset = "0x4141120", VA = "0x184142120")]
			public void JCIHNCONGGN(JICHCGBEEFB MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x41420A0", Offset = "0x41410A0", VA = "0x1841420A0")]
			public CMGCEEJFLDP EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(CMGCEEJFLDP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public JICHCGBEEFB EBMLNNICADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer NNBGHLKFNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private JKJLIMNAFNC IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JKJLIMNAFNC.CMGCEEJFLDP* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x413EE40", Offset = "0x413DE40", VA = "0x18413EE40")]
		internal void EACJNOHFKHL(Entity PBDFKDHMIEL, DBHDJCDCOHB BBLMMHCDFOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x413F120", Offset = "0x413E120", VA = "0x18413F120", Slot = "5")]
		public void ReadFromDisplayClass(ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x413F150", Offset = "0x413E150", VA = "0x18413F150", Slot = "6")]
		public void WriteToDisplayClass(ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x413EF40", Offset = "0x413DF40", VA = "0x18413EF40", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x413EFE0", Offset = "0x413DFE0", VA = "0x18413EFE0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref JKJLIMNAFNC.CMGCEEJFLDP MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x413F090", Offset = "0x413E090", VA = "0x18413F090")]
		public void JCIHNCONGGN(JICHCGBEEFB MFLHDNPOKPM, ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x413EDD0", Offset = "0x413DDD0", VA = "0x18413EDD0")]
		public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private OBMLDKENPPG BLACCPJFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private JEGLAIMIPKC FCPBNGLBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery HKNLFFEDGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker FDCLHLGDOCI;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A770", Offset = "0x2C69770", VA = "0x182C6A770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A630", Offset = "0x2C69630", VA = "0x182C6A630", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A7D0", Offset = "0x2C697D0", VA = "0x182C6A7D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public JICHCGBEEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A690", Offset = "0x2C69690", VA = "0x182C6A690", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A460", Offset = "0x2C69460", VA = "0x182C6A460")]
	public static EntityQuery DGIONCAAPFL(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct KCMGHBCPKBE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public OCGEMJOOKNP AKKHHLBJIJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, PEFLLNEDEOA> BNEBECKGGLP;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x4142200", Offset = "0x4141200", VA = "0x184142200")]
			public KCMGHBCPKBE(int CIMAPKKBLKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x4142180", Offset = "0x4141180", VA = "0x184142180", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct LLDMOKFJHAE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> OOIGBOHOCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x4143AE0", Offset = "0x4142AE0", VA = "0x184143AE0", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct DPMBBFDABIE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x413E110", Offset = "0x413D110", VA = "0x18413E110", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private JEGLAIMIPKC FCPBNGLBMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery PDINBPNEPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery BMDIBILIHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery DNAIDECHPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery IOIOGOHLIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery HFGLCHLCNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle FNFKCFKDHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private KCMGHBCPKBE ODNMLJCMLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private KCMGHBCPKBE HGMPENBCLMD;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2983D80", Offset = "0x2982D80", VA = "0x182983D80", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x2983F20", Offset = "0x2982F20", VA = "0x182983F20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x29841E0", Offset = "0x29831E0", VA = "0x1829841E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x2984220", Offset = "0x2983220", VA = "0x182984220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x2983DE0", Offset = "0x2982DE0", VA = "0x182983DE0")]
		private void OGBKNHBIBLI(EntityQuery FBENFNFLPOM, out (global::OKGGDJPONBN<DBHDJCDCOHB> handles, global::OKGGDJPONBN<CFIMDNLGMOJ> bounds) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2983460", Offset = "0x2982460", VA = "0x182983460")]
		private void AEJGNCNCHAA((global::OKGGDJPONBN<DBHDJCDCOHB> handles, global::OKGGDJPONBN<CFIMDNLGMOJ> bounds) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x29841E0", Offset = "0x29831E0", VA = "0x1829841E0")]
		private void PLLHJIEPEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x29837F0", Offset = "0x29827F0", VA = "0x1829837F0")]
		private void DCLBCLBIPMJ(EntityQuery FBENFNFLPOM, out (global::OKGGDJPONBN<Entity> entities, global::OKGGDJPONBN<DBHDJCDCOHB> handles) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2983A90", Offset = "0x2982A90", VA = "0x182983A90")]
		private void LDJJICGPALA((global::OKGGDJPONBN<Entity> entities, global::OKGGDJPONBN<DBHDJCDCOHB> handles) FILAKGLBGGA, KCMGHBCPKBE IEOJBDIPJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2983930", Offset = "0x2982930", VA = "0x182983930")]
		private JobHandle FIBLDHOCIEK(KCMGHBCPKBE IEOJBDIPJCJ, ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK, ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD, ComponentDataFromEntity<WorldDeformableScaleData> OOIGBOHOCCG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x29836C0", Offset = "0x29826C0", VA = "0x1829836C0")]
		private JobHandle AIBDCMPNAIA(KCMGHBCPKBE IEOJBDIPJCJ, ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK, ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct HDJLPPMNBFI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[EJCMEBPBPBF]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class SplineLocalBoundsSystem : GAJBCDLDAEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct HJCPFHLBLCK : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> HBKIBKIFHEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> INMFLIOHBFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<CFIMDNLGMOJ> INGPHHMHFEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, PEFLLNEDEOA>.ParallelWriter KNLJICNHFCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter FFNIBNOHDFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter JAGPNBFPOKP;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x413FC60", Offset = "0x413EC60", VA = "0x18413FC60", Slot = "4")]
			public void Execute(int NPDGHPHAKDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct CDBGCDGACFJ : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> BCGBJCIGJHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> MBMGBKDNPMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> NLMEHIFJMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> JKMNFJHBCNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<CFIMDNLGMOJ> OIDJDDADHNO;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x413D9F0", Offset = "0x413C9F0", VA = "0x18413D9F0", Slot = "4")]
			public void Execute(int NPDGHPHAKDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery ACGPMKLJMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery BBAHBMLGFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery LEFJFNCLMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery MCFLOKGNBHH;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD30", Offset = "0x2B0AD30", VA = "0x182B0BD30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BF40", Offset = "0x2B0AF40", VA = "0x182B0BF40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B550", Offset = "0x2B0A550", VA = "0x182B0B550")]
		private JobHandle JLHEIGFLFMD(global::OKGGDJPONBN<Entity> DBOPJMNFJMA, int MFAHIHFAKKH, JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B630", Offset = "0x2B0A630", VA = "0x182B0B630")]
		private JobHandle JLHEIGFLFMD(NativeArray<Entity> AJOBCOAMIIM, int MFAHIHFAKKH, [Optional] JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B4D0", Offset = "0x2B0A4D0", VA = "0x182B0B4D0")]
		private global::OKGGDJPONBN<Entity> GPJIKKKEMMJ(EntityQuery FBENFNFLPOM)
		{
			return default(global::OKGGDJPONBN<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B080", Offset = "0x2B0A080", VA = "0x182B0B080")]
		private (global::LNAIBACCGLG<Entity>, global::LNAIBACCGLG<Entity>) GIIHPEIHPHF(global::OKGGDJPONBN<Entity> GIGEAPDONPC)
		{
			return default((global::LNAIBACCGLG<Entity>, global::LNAIBACCGLG<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B810", Offset = "0x2B0A810", VA = "0x182B0B810")]
		private void KBJFKJJAOCC(out NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B8A0", Offset = "0x2B0A8A0", VA = "0x182B0B8A0")]
		private void KPDEGEPAFBI(NativeList<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B930", Offset = "0x2B0A930", VA = "0x182B0B930")]
		private void KPDEGEPAFBI(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C460", Offset = "0x2B0B460", VA = "0x182B0C460")]
		private void PHAMJCIIGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void GCFBBELLCIL(int LEAJLAJJOOH, int CEICDMPEGMK, int BGMAJCGHBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BA00", Offset = "0x2B0AA00", VA = "0x182B0BA00")]
		private static CFIMDNLGMOJ MCNLAKDEPLH(NativeArray<Entity> EICLCEAPHDF, ComponentDataFromEntity<SplinePointPositionData> NLMEHIFJMHE, ComponentDataFromEntity<SplinePointScaleData> JKMNFJHBCNM)
		{
			return default(CFIMDNLGMOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct BGKFNCCCMIK : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[EJCMEBPBPBF]
	[LMNMHFHDONH(IPKPBIMLPOB.Lifecycle)]
	public class DestroyLocalObjects : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[GNFGKNINDPI]
		private ObjectNetworkToLocalMapService LEAPKBHNHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[GNFGKNINDPI]
		private ObjectLifecycleService FHPIBOEMPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery BKPIDHNPHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery FNOFMLALLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery DOFIHHGOMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DAB0", Offset = "0x2A7CAB0", VA = "0x182A7DAB0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DA00", Offset = "0x2A7CA00", VA = "0x182A7DA00")]
		public bool EODNDGBDJMM(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DBD0", Offset = "0x2A7CBD0", VA = "0x182A7DBD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DD20", Offset = "0x2A7CD20", VA = "0x182A7DD20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DD00", Offset = "0x2A7CD00", VA = "0x182A7DD00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x174CEB0", Offset = "0x174BEB0", VA = "0x18174CEB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DD20", Offset = "0x2A7CD20", VA = "0x182A7DD20")]
		private void PAAFLFLLDKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DB20", Offset = "0x2A7CB20", VA = "0x182A7DB20")]
		private void OFHNJHJILBA(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D690", Offset = "0x2A7C690", VA = "0x182A7D690")]
		private void BECCDDNBKAM(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D8F0", Offset = "0x2A7C8F0", VA = "0x182A7D8F0")]
		private void DHJNKJNMCAN(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D7D0", Offset = "0x2A7C7D0", VA = "0x182A7D7D0")]
		private void BPFAJGABJDC(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static HKIFOHOEGHF[] MCCGACFCOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private GKHDEOBEKMI OAKKLAFMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private OEKGHEEACHJ HHGELGEBPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService GHONGEBCKKA;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2C56040", Offset = "0x2C55040", VA = "0x182C56040", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2C560F0", Offset = "0x2C550F0", VA = "0x182C560F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2C55AB0", Offset = "0x2C54AB0", VA = "0x182C55AB0")]
		private void BLCCKHAHODP(HKIFOHOEGHF DCICIPKAADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private void ODJHFCNGKCG(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC, ONEPLGLDGPM DEIOLBFJFGO, FGFOHLOEDBC EGEKMEIMAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[LMNMHFHDONH(IPKPBIMLPOB.Callbacks)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public sealed class PropertyEventCallbacks : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService CLAEEJIDJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService GHONGEBCKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase DCICIPKAADP;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x298A3D0", Offset = "0x29893D0", VA = "0x18298A3D0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x298A460", Offset = "0x2989460", VA = "0x18298A460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[LMNMHFHDONH(IPKPBIMLPOB.NetworkSend)]
	internal class TransmitNetworkDataSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private IDIHNGDEJEE FKPAJEBPAFI;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B13470", Offset = "0x2B12470", VA = "0x182B13470", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B134C0", Offset = "0x2B124C0", VA = "0x182B134C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[EJCMEBPBPBF]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	public class CalculateCullingBandChanges : GAJBCDLDAEF, LGFONBKKNKN, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct CGPBGKOHCKI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType GKKAEJBOHCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> NGEOHINJBLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<HAKDBPCBHEI>.ParallelWriter LAEIFNBAPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<CHBBDDFKDKL> ANOHFDMJINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 IBCPLIFFFGK;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 BBNBJIDANHF;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 MPJIFOLGDLP;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 ECOMDCHIEEN;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF630", Offset = "0x2AFE630", VA = "0x182AFF630", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int FIMNKCDAECN = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double FGOBOCOCJME = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery MLGGMFEKPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery EFOOKCCNIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double BAOCHLCLAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService KLICEFIPLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService ABBPIJBGMOG;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DBC0", Offset = "0x2A6CBC0", VA = "0x182A6DBC0", Slot = "14")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D7C0", Offset = "0x2A6C7C0", VA = "0x182A6D7C0", Slot = "15")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D850", Offset = "0x2A6C850", VA = "0x182A6D850", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D9A0", Offset = "0x2A6C9A0", VA = "0x182A6D9A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DBD0", Offset = "0x2A6CBD0", VA = "0x182A6DBD0")]
		private bool POEBFCOBIIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D480", Offset = "0x2A6C480", VA = "0x182A6D480")]
		private void CGFNNANEJDH(EntityQuery FBENFNFLPOM, float3 IDJIHGJADAJ, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct HAKDBPCBHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity IEFFOCOBJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public HKBEBGEFHBE FDANAHCAINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public HKBEBGEFHBE MKDFAPBMCCA;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService KLICEFIPLCM;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2986DA0", Offset = "0x2985DA0", VA = "0x182986DA0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2986DF0", Offset = "0x2985DF0", VA = "0x182986DF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[LMNMHFHDONH(IPKPBIMLPOB.Connectables)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class UpdateInertialProperties : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery BIFEHGILKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private NJDEJHAOOKH DEIEBPBAKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A780", Offset = "0x2B19780", VA = "0x182B1A780", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A7F0", Offset = "0x2B197F0", VA = "0x182B1A7F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A880", Offset = "0x2B19880", VA = "0x182B1A880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[EJCMEBPBPBF]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GEPPPLOCFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OJFIACFNMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LMNLCPKIHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService JPOOAEHMAAO;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C55050", Offset = "0x2C54050", VA = "0x182C55050", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C55460", Offset = "0x2C54460", VA = "0x182C55460", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C549B0", Offset = "0x2C539B0", VA = "0x182C549B0")]
		private void GKGLMLIDDEB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DEEJEKFIHBB, EntityQueryDesc LPKCPBGDPIE, bool CEDEGPILKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C54870", Offset = "0x2C53870", VA = "0x182C54870")]
		private void GKGLMLIDDEB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DEEJEKFIHBB, EntityQueryDesc LPKCPBGDPIE, bool CEDEGPILKLH, bool KDNPPGNBIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C556C0", Offset = "0x2C546C0", VA = "0x182C556C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C54E60", Offset = "0x2C53E60", VA = "0x182C54E60")]
		private void JEEPIOBGOMI(EntityQuery FBENFNFLPOM, bool FEMFOKCKINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C55210", Offset = "0x2C54210", VA = "0x182C55210")]
		private void NIDKBBDGFMP(EntityQuery FBENFNFLPOM, bool FCFNJJPCAAA, bool FEMFOKCKINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C54460", Offset = "0x2C53460", VA = "0x182C54460")]
		private void ALCNAFGJJAE(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C550A0", Offset = "0x2C540A0", VA = "0x182C550A0")]
		private void NFCCNNKPJGB(NativeList<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C54750", Offset = "0x2C53750", VA = "0x182C54750")]
		private void FJGJPGMOJEP(NativeArray<Entity> BNEBECKGGLP, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C54AC0", Offset = "0x2C53AC0", VA = "0x182C54AC0")]
		private NativeList<Entity> HGDCIPIGFJO(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C54680", Offset = "0x2C53680", VA = "0x182C54680")]
		private NativeList<Entity> DKBKCMAIBKG(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C55420", Offset = "0x2C54420", VA = "0x182C55420")]
		private NativeList<Entity> OLMCFGNJKLK(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C54CC0", Offset = "0x2C53CC0", VA = "0x182C54CC0")]
		private NativeList<Entity> IHOBHGCCKDM(NativeArray<Entity> BNEBECKGGLP, bool OEGDHHMGKHJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C546C0", Offset = "0x2C536C0", VA = "0x182C546C0")]
		private FPIJIFEICHE ELKOJDHGNAN(NativeArray<Entity> BNEBECKGGLP)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(FPIJIFEICHE);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C559E0", Offset = "0x2C549E0", VA = "0x182C559E0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService JPOOAEHMAAO;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x2986E10", Offset = "0x2985E10", VA = "0x182986E10", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x2986E60", Offset = "0x2985E60", VA = "0x182986E60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : HNBBKDMFLBC
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery LGOAFGHHFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery CBLOGAKDDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery GGAAGOOKNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery JPHJFPGDFDH;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D300", Offset = "0x2A7C300", VA = "0x182A7D300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D4C0", Offset = "0x2A7C4C0", VA = "0x182A7D4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CE80", Offset = "0x2A7BE80", VA = "0x182A7CE80")]
		private void COHAJIDJILB(EntityQuery FBENFNFLPOM, bool MPNBEECGANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D0C0", Offset = "0x2A7C0C0", VA = "0x182A7D0C0")]
		private void GKJBCBALALK(EntityQuery FBENFNFLPOM, bool MPNBEECGANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class AssignPlayerIdsSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery CPGIJEOMNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery AINMCJIAKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService EFOAKEMFNMA;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A68270", Offset = "0x2A67270", VA = "0x182A68270", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A68530", Offset = "0x2A67530", VA = "0x182A68530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A68640", Offset = "0x2A67640", VA = "0x182A68640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A67F90", Offset = "0x2A66F90", VA = "0x182A67F90")]
		private void ANCDDJEPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A68100", Offset = "0x2A67100", VA = "0x182A68100")]
		private void FPGCFGNBHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A68660", Offset = "0x2A67660", VA = "0x182A68660")]
		private void PLDGMCNNIHN(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A683F0", Offset = "0x2A673F0", VA = "0x182A683F0")]
		private void OELLDOLDIBG(NativeArray<Entity> BNEBECKGGLP, int IAPLKGBBKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A682E0", Offset = "0x2A672E0", VA = "0x182A682E0")]
		private void NLGPGOEIBOP(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A680A0", Offset = "0x2A670A0", VA = "0x182A680A0")]
		private void EIJINEPPJCC(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void BBJABDNEEEF(int IFEILBLHHPO, Transform FLCFNMLPAML, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class JPMMBGJGFFB
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C3F0", Offset = "0x2C6B3F0", VA = "0x182C6C3F0")]
	public static bool NIOBFBOKCOK(this SystemBase KFLDFPCKAGO, out Entity IEFFOCOBJJI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery GNMFLLABIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private KHAPNLPCPDI EOBAGGGIMJH;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F390", Offset = "0x2A6E390", VA = "0x182A6F390", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F3E0", Offset = "0x2A6E3E0", VA = "0x182A6F3E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F4A0", Offset = "0x2A6E4A0", VA = "0x182A6F4A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<KFIGLHFDNPH>, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string NCMEGAJBGCE = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private DLPNOHDEIMB MPMMMCINMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery OBKAIJAMEPK;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity MADBDOPHELP
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x2C72D90", Offset = "0x2C71D90", VA = "0x182C72D90")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x2C72E90", Offset = "0x2C71E90", VA = "0x182C72E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity BKFELIEPMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x2C73080", Offset = "0x2C72080", VA = "0x182C73080")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public PMFFIMLMCEJ AAHBFGJELMD
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x2C72FF0", Offset = "0x2C71FF0", VA = "0x182C72FF0")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x2C72DF0", Offset = "0x2C71DF0", VA = "0x182C72DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public PMFFIMLMCEJ BKGCODOOPAF
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2C72F60", Offset = "0x2C71F60", VA = "0x182C72F60")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C73270", Offset = "0x2C72270", VA = "0x182C73270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C72EF0", Offset = "0x2C71EF0", VA = "0x182C72EF0", Slot = "15")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C73310", Offset = "0x2C72310", VA = "0x182C73310", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C730E0", Offset = "0x2C720E0", VA = "0x182C730E0", Slot = "14")]
		protected override void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C72C50", Offset = "0x2C71C50", VA = "0x182C72C50")]
		private void CHDLAODBNOK(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C73390", Offset = "0x2C72390", VA = "0x182C73390")]
		private void PLPLNPLALGB(Entity IEFFOCOBJJI, Entity HDBFDPJEOFG, Entity MDOJBKLAOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x257E8A0", Offset = "0x257D8A0", VA = "0x18257E8A0")]
		private bool MDMOKHFDALA<T>(out T DFEOJBAFBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x257E7E0", Offset = "0x257D7E0", VA = "0x18257E7E0")]
		private void EIHINOPMEGD<T>(T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C72D30", Offset = "0x2C71D30", VA = "0x182C72D30")]
		public bool ECOJFCMIMLI(PMFFIMLMCEJ PIJOPLAILOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C72E60", Offset = "0x2C71E60", VA = "0x182C72E60")]
		private static bool HFCCBEJNGIA(PMFFIMLMCEJ LODGEHOKDPG, PMFFIMLMCEJ KEIPMOFFIEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C73680", Offset = "0x2C72680", VA = "0x182C73680")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C73230", Offset = "0x2C72230", VA = "0x182C73230", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2A779E0", Offset = "0x2A769E0", VA = "0x182A779E0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2A77A30", Offset = "0x2A76A30", VA = "0x182A77A30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2A77AD0", Offset = "0x2A76AD0", VA = "0x182A77AD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2A77780", Offset = "0x2A76780", VA = "0x182A77780")]
		private NativeArray<Entity> ELMPNDJDNMM(int MIOCJKOOLBL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2A778D0", Offset = "0x2A768D0", VA = "0x182A778D0")]
		private void INAFMCAMEFF(NativeArray<Entity> GDIMDGGFBCE, NativeArray<Entity> NNNAHLEFPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	internal class HideRemotePivotsNotInScope : GAJBCDLDAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery IHAENEOPFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery GKPIIGGLPAE;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2C63DE0", Offset = "0x2C62DE0", VA = "0x182C63DE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2C63ED0", Offset = "0x2C62ED0", VA = "0x182C63ED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class BEFFMIBAKPC
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string GJGFPECLAMM = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x22D69B0", Offset = "0x22D59B0", VA = "0x1822D69B0")]
	public static NativeArray<T> CPIBHMJGANG<T>(NativeArray<Entity> BNEBECKGGLP, EntityManager MKHPDCKNNBB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x2A692C0", Offset = "0x2A682C0", VA = "0x182A692C0")]
	public static void JOFKPPLDLJM(EntityQuery FBENFNFLPOM, EntityManager MKHPDCKNNBB, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x2A69060", Offset = "0x2A68060", VA = "0x182A69060")]
	public static void EEAJFDPLMCB(NativeArray<Entity> GDIMDGGFBCE, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x2A69190", Offset = "0x2A68190", VA = "0x182A69190")]
	public static void GCFKAANCGHC(NativeArray<Entity> GDIMDGGFBCE, JEAKCMCJOBO NAANBDEGGGO)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService FHPIBOEMPHI;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A5F0", Offset = "0x2B195F0", VA = "0x182B1A5F0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A680", Offset = "0x2B19680", VA = "0x182B1A680", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A720", Offset = "0x2B19720", VA = "0x182B1A720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2B19950", Offset = "0x2B18950", VA = "0x182B19950")]
		private void HPDJNGBCOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2B19840", Offset = "0x2B18840", VA = "0x182B19840")]
		private void GLBLBLOBNHE(NativeArray<Entity> GDIMDGGFBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2B18D20", Offset = "0x2B17D20", VA = "0x182B18D20")]
		private void BFICBOKONNE(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2B195F0", Offset = "0x2B185F0", VA = "0x182B195F0")]
		private void GCKFPIDHNBM(NativeArray<Entity> NNNAHLEFPHB, NativeArray<RigidTransform> JFNBGKEOLJC, NativeArray<RigidTransform> CLNMLIEFCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2B1A160", Offset = "0x2B19160", VA = "0x182B1A160")]
		private void JDKDNEDPNJK(NativeArray<RigidTransform> CLNMLIEFCBN, NativeArray<Entity> NNNAHLEFPHB, NativeList<Entity> HOALKGHBPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class PostGameplayOnScopeChange : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery GNMFLLABIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery HPADMEJJMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x29853C0", Offset = "0x29843C0", VA = "0x1829853C0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2985430", Offset = "0x2984430", VA = "0x182985430", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2985580", Offset = "0x2984580", VA = "0x182985580", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x2985350", Offset = "0x2984350", VA = "0x182985350")]
		private void FCCACKHLLFL(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery GCLDAEMHBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents JMOFNBOBEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private KHAPNLPCPDI EOBAGGGIMJH;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2986C10", Offset = "0x2985C10", VA = "0x182986C10", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2986CA0", Offset = "0x2985CA0", VA = "0x182986CA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2986D40", Offset = "0x2985D40", VA = "0x182986D40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2986A80", Offset = "0x2985A80", VA = "0x182986A80")]
		private void DKEAKLKPONF(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<OPMOOOPNGOD>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2B04230", Offset = "0x2B03230", VA = "0x182B04230", Slot = "14")]
		protected override void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2B04380", Offset = "0x2B03380", VA = "0x182B04380")]
		[BurstCompile]
		private static void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> PEMGELIABFI, ComponentDataFromEntity<global::FPPGPOHJNPK> CMPHDOJMEKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2B04490", Offset = "0x2B03490", VA = "0x182B04490")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04450", Offset = "0x2B03450", VA = "0x182B04450", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[LMNMHFHDONH(IPKPBIMLPOB.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : GAJBCDLDAEF where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery PCABKCEGLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery GFJOIKAPOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery HEALACFKFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery AMIOMCJBNCO;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x33F5AC0", Offset = "0x33F4AC0", VA = "0x1833F5AC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x33F5CC0", Offset = "0x33F4CC0", VA = "0x1833F5CC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x33F5C90", Offset = "0x33F4C90", VA = "0x1833F5C90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x33F4430", Offset = "0x33F3430", VA = "0x1833F4430")]
		private void EAHAIGADCPE(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x33F4C60", Offset = "0x33F3C60", VA = "0x1833F4C60")]
		private void FEAFIKKCEKJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x33F5050", Offset = "0x33F4050", VA = "0x1833F5050")]
		private void HONGPFKNEAJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2006C20", Offset = "0x2005C20", VA = "0x182006C20")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2006A70", Offset = "0x2005A70", VA = "0x182006A70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class BLFDJJKOMBL : GAJBCDLDAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> COANALBPMNH;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2A69C20", Offset = "0x2A68C20", VA = "0x182A69C20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2A69E20", Offset = "0x2A68E20", VA = "0x182A69E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2A69F70", Offset = "0x2A68F70", VA = "0x182A69F70")]
	public BLFDJJKOMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct NLLKDFGBAFF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int EBAKNIMBLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int DKBOPEOPEBA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x2970B20", Offset = "0x296FB20", VA = "0x182970B20")]
	public static Entity LFOOIECCIPM(NLLKDFGBAFF FILAKGLBGGA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2970B20", Offset = "0x296FB20", VA = "0x182970B20")]
	public static NLLKDFGBAFF LFOOIECCIPM(Entity IEFFOCOBJJI)
	{
		return default(NLLKDFGBAFF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct IEEAKPAALNB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct PJECKKFIGKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType OMMPBBANJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> JOOBOILFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> EOFKAJHOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> BNEBECKGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> BMEHNGMFIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> MBHNFHEJPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> JFKHJAJODDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int LKBNNMCHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int IMIACOEJDJI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool NOGGEPJGNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2981080", Offset = "0x2980080", VA = "0x182981080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2981100", Offset = "0x2980100", VA = "0x182981100")]
	public PJECKKFIGKG(ComponentType OMMPBBANJJE, NativeList<int> JOOBOILFNKM, NativeList<int> EOFKAJHOCOO, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> BMEHNGMFIGM, NativeArray<byte> MBHNFHEJPDH, NativeArray<byte> JFKHJAJODDL, int LKBNNMCHCFI, int IMIACOEJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2980F00", Offset = "0x297FF00", VA = "0x182980F00")]
	private PEKIEJLMCEO IIICJIPGKEF(NativeArray<byte> DBOPJMNFJMA, int NPDGHPHAKDK)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T IIICJIPGKEF<T>(NativeArray<byte> DBOPJMNFJMA, int NPDGHPHAKDK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2981030", Offset = "0x2980030", VA = "0x182981030")]
	public PEKIEJLMCEO LEFOJIGMEIG(int NPDGHPHAKDK)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T LEFOJIGMEIG<T>(int NPDGHPHAKDK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2980EB0", Offset = "0x297FEB0", VA = "0x182980EB0")]
	public PEKIEJLMCEO HIBPLAPAEDF(int NPDGHPHAKDK)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T HIBPLAPAEDF<T>(int NPDGHPHAKDK) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2980DD0", Offset = "0x297FDD0", VA = "0x182980DD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct HALLOMDKPOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<LEHGOJHFAJL> JDJBDCDEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType OMMPBBANJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int LKBNNMCHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int IMIACOEJDJI;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2C613E0", Offset = "0x2C603E0", VA = "0x182C613E0")]
	public HALLOMDKPOM(ComponentType OMMPBBANJJE, int LKBNNMCHCFI, int IMIACOEJDJI, EntityQuery FBENFNFLPOM, NativeArray<LEHGOJHFAJL> JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2C61390", Offset = "0x2C60390", VA = "0x182C61390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct NLCDIAMMCAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int NPDGHPHAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int FMEGALDIEDN;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
	public NLCDIAMMCAI(int NPDGHPHAKDK, int FMEGALDIEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct LEHGOJHFAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int PNKNABOKANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int BDHBBDMMOKG;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
	public LEHGOJHFAJL(int PNKNABOKANH, int BDHBBDMMOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct FGFOHLOEDBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly OEMFGOLGDMG KCHLIHHPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int LKBNNMCHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* MBHNFHEJPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* JFKHJAJODDL;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2C58980", Offset = "0x2C57980", VA = "0x182C58980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public OEMFGOLGDMG OIMEPCKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20")]
		get
		{
			return default(OEMFGOLGDMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x2C58990", Offset = "0x2C57990", VA = "0x182C58990")]
	public PEKIEJLMCEO MGMCDCOFEHD(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2C58A80", Offset = "0x2C57A80", VA = "0x182C58A80")]
	public PEKIEJLMCEO NOHDCNAIOHM(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x27E2880", Offset = "0x27E1880", VA = "0x1827E2880")]
	public T MGMCDCOFEHD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x27E28A0", Offset = "0x27E18A0", VA = "0x1827E28A0")]
	public T NOHDCNAIOHM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2C58B70", Offset = "0x2C57B70", VA = "0x182C58B70")]
	public unsafe FGFOHLOEDBC(OEMFGOLGDMG KCHLIHHPAKF, int BDHBBDMMOKG, byte* MBHNFHEJPDH, byte* JFKHJAJODDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class CLFIGHANMAA : DLPLBLIFJLF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService GHONGEBCKKA;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract HKIFOHOEGHF PEMLFOLLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CCD0", Offset = "0x2A6BCD0", VA = "0x182A6CCD0", Slot = "17")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CF60", Offset = "0x2A6BF60", VA = "0x182A6CF60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CD20", Offset = "0x2A6BD20", VA = "0x182A6CD20", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	protected CLFIGHANMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class APBNFHIMGID
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] AGANMJMIMLG;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class MDBAAKNLHNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, HALLOMDKPOM> KPBEGLEDJIB;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public HALLOMDKPOM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x296CAA0", Offset = "0x296BAA0", VA = "0x18296CAA0")]
		get
		{
			return default(HALLOMDKPOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x296CA50", Offset = "0x296BA50", VA = "0x18296CA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x296D120", Offset = "0x296C120", VA = "0x18296D120")]
	public MDBAAKNLHNI(JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x296CF70", Offset = "0x296BF70", VA = "0x18296CF70")]
	public bool HADOILGNPLN(ComponentType OMMPBBANJJE, out HALLOMDKPOM JOHEPNEHJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x296CFE0", Offset = "0x296BFE0", VA = "0x18296CFE0")]
	public Dictionary<ComponentType, HALLOMDKPOM>.Enumerator HPPJKDPBNFG()
	{
		return default(Dictionary<ComponentType, HALLOMDKPOM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x296CB30", Offset = "0x296BB30", VA = "0x18296CB30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x296C5F0", Offset = "0x296B5F0", VA = "0x18296C5F0")]
	private void CHJLJKHDKAE(IEnumerable<PGIKEAFDIOH> OCJPNOLMEHI, EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x296D070", Offset = "0x296C070", VA = "0x18296D070")]
	private static int JBDGDPOLOFO(PGIKEAFDIOH BAEHHBGAGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x296CCC0", Offset = "0x296BCC0", VA = "0x18296CCC0")]
	private static NativeArray<LEHGOJHFAJL> GLINOCNEKGL(PGIKEAFDIOH BAEHHBGAGMM, Allocator AEPJLHDIHPH = Allocator.Persistent)
	{
		return default(NativeArray<LEHGOJHFAJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface IEPINABNOFO
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool NOGGEPJGNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLBOOBNALLB(out NativeArray<int> OOFMEFFBOEL, Allocator AEPJLHDIHPH);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGLFIEACDOM(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL, out HALLOMDKPOM ECGOBGEIPCF);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGLFIEACDOM(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PJECKKFIGKG CIOEJGFEPAP(ComponentType OMMPBBANJJE);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ANLCPLEKFMI CCLMOKHOCDG();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDEABHDDOPP(JobHandle CPPLLJNMFIG);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
internal interface OKLEKHOLNCL
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	MDBAAKNLHNI DPFLAIIDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	LHHIGECFLLB GCKBEBKAKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, FGFOHLOEDBC> GDJBNAFIAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle BGCHOABBPOA
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
	bool JGMOEBJPLEH();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMOCNNJJBKM();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCLHNKGMGCJ(ComponentType OMMPBBANJJE, in PJECKKFIGKG HHKBPEJHMKB);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BJBOIJCAMCN(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct ANLCPLEKFMI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct OCPFHKOIPOD : IEnumerator<FGFOHLOEDBC>, IEnumerator, IDisposable, IEnumerable<FGFOHLOEDBC>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, FGFOHLOEDBC> LLHCHDMLAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity IEFFOCOBJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> EBJPMLFKDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private FGFOHLOEDBC JFKHJAJODDL;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public FGFOHLOEDBC JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xC2AE10", Offset = "0xC29E10", VA = "0x180C2AE10", Slot = "4")]
			get
			{
				return default(FGFOHLOEDBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x2B03B90", Offset = "0x2B02B90", VA = "0x182B03B90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x2B03BE0", Offset = "0x2B02BE0", VA = "0x182B03BE0")]
		internal OCPFHKOIPOD(NativeMultiHashMap<Entity, FGFOHLOEDBC> LLHCHDMLAEG, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2B03980", Offset = "0x2B02980", VA = "0x182B03980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2B03950", Offset = "0x2B02950", VA = "0x182B03950")]
		public OCPFHKOIPOD HPPJKDPBNFG()
		{
			return default(OCPFHKOIPOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x2B03A50", Offset = "0x2B02A50", VA = "0x182B03A50", Slot = "9")]
		private IEnumerator<FGFOHLOEDBC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2B03AF0", Offset = "0x2B02AF0", VA = "0x182B03AF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly OKLEKHOLNCL IDIIBDOHICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle KGEDOEANNML;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int AMLIKOHLHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2A66B30", Offset = "0x2A65B30", VA = "0x182A66B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x2A66D90", Offset = "0x2A65D90", VA = "0x182A66D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2077F70", Offset = "0x2076F70", VA = "0x182077F70")]
	public ANLCPLEKFMI(OKLEKHOLNCL IDIIBDOHICE, JobHandle KGEDOEANNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2A668D0", Offset = "0x2A658D0", VA = "0x182A668D0")]
	public bool DFNEACELHKG(Allocator AEPJLHDIHPH, out NativeKeyValueArrays<Entity, FGFOHLOEDBC> MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2A66C20", Offset = "0x2A65C20", VA = "0x182A66C20")]
	public bool OHLCHDPGHLA(Allocator AEPJLHDIHPH, out (NativeArray<Entity> entities, int uniqueCount) MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2A66A10", Offset = "0x2A65A10", VA = "0x182A66A10")]
	public OCPFHKOIPOD HBFADDABMME(Entity IEFFOCOBJJI)
	{
		return default(OCPFHKOIPOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class LHHIGECFLLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<HALLOMDKPOM> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public HALLOMDKPOM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2C70DF0", Offset = "0x2C6FDF0", VA = "0x182C70DF0")]
		get
		{
			return default(HALLOMDKPOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2C70DB0", Offset = "0x2C6FDB0", VA = "0x182C70DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2C71070", Offset = "0x2C70070", VA = "0x182C71070")]
	public LHHIGECFLLB(MDBAAKNLHNI KPBEGLEDJIB, JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2C70FF0", Offset = "0x2C6FFF0", VA = "0x182C70FF0")]
	public List<HALLOMDKPOM>.Enumerator HPPJKDPBNFG()
	{
		return default(List<HALLOMDKPOM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2C70E80", Offset = "0x2C6FE80", VA = "0x182C70E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2C70AB0", Offset = "0x2C6FAB0", VA = "0x182C70AB0")]
	private void CHJLJKHDKAE(MDBAAKNLHNI KPBEGLEDJIB, EntityManager MKHPDCKNNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class MFMDMDGDHMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService AAPBAEGCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::BOONDFDEOBC<PGIKEAFDIOH> MJMHKKBFMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World KJHAPGELJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> JCBGAMJMEKF;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x296EBA0", Offset = "0x296DBA0", VA = "0x18296EBA0")]
	public MFMDMDGDHMO(ObjectInstantiationService AAPBAEGCALL, JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x296DF20", Offset = "0x296CF20", VA = "0x18296DF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x296DEC0", Offset = "0x296CEC0", VA = "0x18296DEC0")]
	public bool CFEDEDIJJMD(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x296D760", Offset = "0x296C760", VA = "0x18296D760")]
	private void AHNMALCCCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x296D230", Offset = "0x296C230", VA = "0x18296D230")]
	private EntityArchetype AHAIEENMEGC(EntityArchetype ABOLABLPENH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x296E770", Offset = "0x296D770", VA = "0x18296E770")]
	public static void PHLKPPPNJND(EntityManager DDNAAJMMFNN, EntityManager BLDEHLEAJGA, NativeArray<Entity> PNFNAEBJOEK, NativeArray<EntityArchetype> IHLCCPAJGBF, [Optional] NativeArray<Entity> AEMHGFJOIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x296E130", Offset = "0x296D130", VA = "0x18296E130")]
	[Conditional("DEBUG_BUILD")]
	private static void IFHDDFFMILC(NativeArray<EntityArchetype> OOJLGDAONOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x296E380", Offset = "0x296D380", VA = "0x18296E380")]
	private static string KMKNAAEDLGP(EntityArchetype FAAKDBHJKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x296DFF0", Offset = "0x296CFF0", VA = "0x18296DFF0")]
	[CompilerGenerated]
	internal static void FCBCIMDJLPN(ref Span<ComponentType> KNIMIDPAGFE, ComponentType DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x296E5C0", Offset = "0x296D5C0", VA = "0x18296E5C0")]
	[CompilerGenerated]
	internal static void ONDNAMLNNAP(Span<ComponentType> DBOPJMNFJMA, ref Span<ComponentType> KNIMIDPAGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x296E2A0", Offset = "0x296D2A0", VA = "0x18296E2A0")]
	[CompilerGenerated]
	internal static void JDGDGAEJKMK(Span<ComponentType> DBOPJMNFJMA, ref Span<ComponentType> KNIMIDPAGFE, ComponentType JCHPDENPJBC)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld COMGPKJLCBG;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x2A67E20", Offset = "0x2A66E20", VA = "0x182A67E20", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2A67EE0", Offset = "0x2A66EE0", VA = "0x182A67EE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[LMNMHFHDONH(IPKPBIMLPOB.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : GAJBCDLDAEF, COMOMFINKHP, BDDJKMOFDGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct ENIIFLLGJKJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> JJKNAENJPNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> FIPFIFIPNJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<LEHGOJHFAJL> ILODDHJBLAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<NLCDIAMMCAI>.ParallelWriter LNBJDPLIKFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int IDNDLEGDKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int HDNHCECJIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker JKKJMPHIDNF;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B003F0", Offset = "0x2AFF3F0", VA = "0x182B003F0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B00530", Offset = "0x2AFF530", VA = "0x182B00530")]
			private unsafe int JCCKJCNLAJP(byte* HNBAEIKIKNN, byte* KMJCJNGOPHM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct CJILLIPBFAD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> JOOBOILFNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> OGBKBJACAAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<NLCDIAMMCAI> HECABBCJCKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker JKKJMPHIDNF;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFDE0", Offset = "0x2AFEDE0", VA = "0x182AFFDE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct GIDONEENLIG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> LOGDKKACCOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public BOHBJPNCJPN HDIEHNKBFOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int LKBNNMCHCFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker JKKJMPHIDNF;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B00820", Offset = "0x2AFF820", VA = "0x182B00820", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct CFDFLGHLAGA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, FGFOHLOEDBC> CGCELJGOCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> MBHNFHEJPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> JFKHJAJODDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<LEHGOJHFAJL> DOFMFIICANP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> EOFKAJHOCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> JOOBOILFNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int OABCMEJCLEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int IMIACOEJDJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker JKKJMPHIDNF;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF3B0", Offset = "0x2AFE3B0", VA = "0x182AFF3B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker OPFBPLNFJLD;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker IOLGGGIIPNH;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker FLHMDGPJEAF;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker MNJNABBLCAL;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker KLOIIOMEOPE;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker KFNEIEHKAMC;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker OKBFAFNEGBA;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker LKHNGJCGFEB;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker DHFANCAFHAG;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker GFKINFMCFHL;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker PGABHCAICMH;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker ABFPBENHFHO;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker HEIHEHCPMHD;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker HJHLJDHHNPN;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker AKNNNNPLFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService GHONGEBCKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery PNNDDOKIOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery FNGMEOGCPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery DOFIHHGOMII;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World BGENOIKENDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2A70F50", Offset = "0x2A6FF50", VA = "0x182A70F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private OKLEKHOLNCL NPJAAKCIGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FF90", Offset = "0x2A6EF90", VA = "0x182A6FF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2A71800", Offset = "0x2A70800", VA = "0x182A71800", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "15")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2A72070", Offset = "0x2A71070", VA = "0x182A72070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2A72230", Offset = "0x2A71230", VA = "0x182A72230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2A721C0", Offset = "0x2A711C0", VA = "0x182A721C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2A701E0", Offset = "0x2A6F1E0", VA = "0x182A701E0")]
		private void IGEEGOEHFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A717E0", Offset = "0x2A707E0", VA = "0x182A717E0")]
		internal void MCNPBJPJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A71010", Offset = "0x2A70010", VA = "0x182A71010")]
		private void MCNPBJPJFIP(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A70D10", Offset = "0x2A6FD10", VA = "0x182A70D10")]
		private void LHFAGNJOGNA(NativeArray<Entity> PNFNAEBJOEK, NativeArray<RRObjectPrefabData> BHHIHKBGNIJ, ref NativeArray<Entity> GEDFDAHEOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A71850", Offset = "0x2A70850", VA = "0x182A71850")]
		internal void NGEBLNGCCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A71870", Offset = "0x2A70870", VA = "0x182A71870")]
		private void NGEBLNGCCHA(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A705B0", Offset = "0x2A6F5B0", VA = "0x182A705B0")]
		internal void LBFLMDABOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A72370", Offset = "0x2A71370", VA = "0x182A72370")]
		private void PHBNOEJJEIP(OKLEKHOLNCL IDIIBDOHICE, HALLOMDKPOM ECGOBGEIPCF, bool AKKJMIAABJH, ref JobHandle AEEKBHHEJFH, ref JobHandle MOMLDMEKEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F560", Offset = "0x2A6E560", VA = "0x182A6F560")]
		internal bool ALGNFLDCAEA(in HALLOMDKPOM KMJCJNGOPHM, out JobHandle DCLMHANFEGK, out PJECKKFIGKG IADGPFGBGBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A6F590", Offset = "0x2A6E590", VA = "0x182A6F590")]
		private bool ALGNFLDCAEA(in HALLOMDKPOM KMJCJNGOPHM, bool AKKJMIAABJH, out JobHandle DCLMHANFEGK, out PJECKKFIGKG IADGPFGBGBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A72650", Offset = "0x2A71650", VA = "0x182A72650")]
		internal (NativeList<int>, NativeList<int>) PLHGFHPOMPN(NativeList<NLCDIAMMCAI> HECABBCJCKD, int CIMAPKKBLKM, JobHandle MPFKOMLNJME, out JobHandle CPPLLJNMFIG, Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A700B0", Offset = "0x2A6F0B0", VA = "0x182A700B0")]
		internal static NativeArray<Entity> GPNAJLIHBOE(EntityQuery FBENFNFLPOM, out JobHandle CGOHMJGOOHH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A70160", Offset = "0x2A6F160", VA = "0x182A70160")]
		internal static NativeArray<byte> HKGFBHFDECG(int CCFMJPPGPDK, out JobHandle ODIMFJPOPPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A704A0", Offset = "0x2A6F4A0", VA = "0x182A704A0")]
		internal static NativeArray<byte> IMOBKJBBLHI(EntityQuery FBENFNFLPOM, int CNNKHGOHIDH, out JobHandle ODIMFJPOPPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FFB0", Offset = "0x2A6EFB0", VA = "0x182A6FFB0")]
		internal static NativeArray<Entity> GPJIKKKEMMJ(EntityQuery FBENFNFLPOM, out JobHandle IFIIDOINMHG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A71C70", Offset = "0x2A70C70", VA = "0x182A71C70")]
		internal NativeArray<byte> NKDIOOPHLFL(NativeArray<Entity> BNEBECKGGLP, HALLOMDKPOM ECGOBGEIPCF, JobHandle MPFKOMLNJME, out JobHandle CPPLLJNMFIG, Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A71EE0", Offset = "0x2A70EE0", VA = "0x182A71EE0")]
		internal JobHandle NNGBOAODBFO(in PJECKKFIGKG FILAKGLBGGA, in HALLOMDKPOM ECGOBGEIPCF, NativeMultiHashMap<Entity, FGFOHLOEDBC> CGCELJGOCCG, JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E589E0", Offset = "0x1E579E0", VA = "0x181E589E0")]
		private JobHandle HBHPOFMOEGE(JobHandle ECAENDJPKEI, JobHandle BFBAIBNDBID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E589E0", Offset = "0x1E579E0", VA = "0x181E589E0")]
		private JobHandle HBHPOFMOEGE(JobHandle ECAENDJPKEI, JobHandle BFBAIBNDBID, JobHandle IDOFKIEGPCJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[LMNMHFHDONH(IPKPBIMLPOB.RenderEffects)]
	internal class PropagateHoverRootTag : MINODIPADOM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct FMFEDOHFCNB : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType DLJFHHGKHHB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x2987680", Offset = "0x2986680", VA = "0x182987680", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x2987650", Offset = "0x2986650", VA = "0x182987650", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x2987620", Offset = "0x2986620", VA = "0x182987620", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2970AD0", Offset = "0x296FAD0", VA = "0x182970AD0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[LMNMHFHDONH(IPKPBIMLPOB.RenderEffects)]
	internal class PropagateSelectionRootTag : MINODIPADOM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct POEJCGHAIFD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType DLJFHHGKHHB
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x2987710", Offset = "0x2986710", VA = "0x182987710", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x29876E0", Offset = "0x29866E0", VA = "0x1829876E0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x29876B0", Offset = "0x29866B0", VA = "0x1829876B0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2970AD0", Offset = "0x296FAD0", VA = "0x182970AD0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[EJCMEBPBPBF]
public class DMJGFGOFPFF : HNBBKDMFLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C610", Offset = "0x2A7B610", VA = "0x182A7C610", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C6A0", Offset = "0x2A7B6A0", VA = "0x182A7C6A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public DMJGFGOFPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[EJCMEBPBPBF]
public class EHPOJBKJMON : HNBBKDMFLBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BBDHPHAAJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public BBDHPHAAJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct FPOIIEAKKFK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct MGPDFBODIDE
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct FDANAAOMBHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime KPLOKAMBCNK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NEKOHHEEMPD;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x4143F70", Offset = "0x4142F70", VA = "0x184143F70")]
			public void JCIHNCONGGN(EHPOJBKJMON MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x4143EF0", Offset = "0x4142EF0", VA = "0x184143EF0")]
			public FDANAAOMBHH EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(FDANAAOMBHH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager MKHPDCKNNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> HFNBFDGJCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private MGPDFBODIDE IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MGPDFBODIDE.FDANAAOMBHH* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCHEEHNBOGO;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B00630", Offset = "0x2AFF630", VA = "0x182B00630")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, SplinePointParentData LMABBBKCION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B00800", Offset = "0x2AFF800", VA = "0x182B00800", Slot = "5")]
		public void ReadFromDisplayClass(ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B00810", Offset = "0x2AFF810", VA = "0x182B00810", Slot = "6")]
		public void WriteToDisplayClass(ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B006A0", Offset = "0x2AFF6A0", VA = "0x182B006A0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B00710", Offset = "0x2AFF710", VA = "0x182B00710")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref MGPDFBODIDE.FDANAAOMBHH MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B007C0", Offset = "0x2AFF7C0", VA = "0x182B007C0")]
		public void JCIHNCONGGN(EHPOJBKJMON MFLHDNPOKPM, ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B005C0", Offset = "0x2AFF5C0", VA = "0x182B005C0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery HAJJMFHLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker OOOJHALNLDA;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F800", Offset = "0x2A7E800", VA = "0x182A7F800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public EHPOJBKJMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F5D0", Offset = "0x2A7E5D0", VA = "0x182A7F5D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F470", Offset = "0x2A7E470", VA = "0x182A7F470")]
	public static EntityQuery MCKOELHBGOE(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[EJCMEBPBPBF]
public class ENHKJKGDFEJ : HNBBKDMFLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery JGGJHPIDDLD;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A81A80", Offset = "0x2A80A80", VA = "0x182A81A80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A81B10", Offset = "0x2A80B10", VA = "0x182A81B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public ENHKJKGDFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(DMJGFGOFPFF))]
public class DAIGAGHKCEB : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A787C0", Offset = "0x2A777C0", VA = "0x182A787C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public DAIGAGHKCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class EMJADLKIPAM : HNBBKDMFLBC, COMOMFINKHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct ALPLJDNLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<AIELFMMICMN, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public ALPLJDNLNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IIKOMEMCCDO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct PBHMIPLGBFO
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct HHCIMFHPGIM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BLAJMEMAINO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MPNOECLFIEJ;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x4145EE0", Offset = "0x4144EE0", VA = "0x184145EE0")]
			public void JCIHNCONGGN(EMJADLKIPAM MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x4145E60", Offset = "0x4144E60", VA = "0x184145E60")]
			public HHCIMFHPGIM EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(HHCIMFHPGIM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private PBHMIPLGBFO IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PBHMIPLGBFO.HHCIMFHPGIM* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B011A0", Offset = "0x2B001A0", VA = "0x182B011A0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ObjectNetworkIdComponentData KKFCOGJAMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00380", VA = "0x182B01380", Slot = "5")]
		public void ReadFromDisplayClass(ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x26C9E00", Offset = "0x26C8E00", VA = "0x1826C9E00", Slot = "6")]
		public void WriteToDisplayClass(ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01220", Offset = "0x2B00220", VA = "0x182B01220", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B01290", Offset = "0x2B00290", VA = "0x182B01290")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref PBHMIPLGBFO.HHCIMFHPGIM MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B01340", Offset = "0x2B00340", VA = "0x182B01340")]
		public void JCIHNCONGGN(EMJADLKIPAM MFLHDNPOKPM, ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B01130", Offset = "0x2B00130", VA = "0x182B01130")]
		public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService LEAPKBHNHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery HAJJMFHLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker OOOJHALNLDA;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A816E0", Offset = "0x2A806E0", VA = "0x182A816E0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A81940", Offset = "0x2A80940", VA = "0x182A81940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public EMJADLKIPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A81740", Offset = "0x2A80740", VA = "0x182A81740", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A81580", Offset = "0x2A80580", VA = "0x182A81580")]
	public static EntityQuery MCKOELHBGOE(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class KGEPBPDNNPB : HNBBKDMFLBC, COMOMFINKHP
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LADCEELPHPO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct LBBNIKCEMBD
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct PALPCGGKMEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime DFLOILGIILM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> NKFGAFFAJFP;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x4142990", Offset = "0x4141990", VA = "0x184142990")]
			public void JCIHNCONGGN(KGEPBPDNNPB MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x4142910", Offset = "0x4141910", VA = "0x184142910")]
			public PALPCGGKMEM EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
			{
				return default(PALPCGGKMEM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public KGEPBPDNNPB KABCGLMAMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private LBBNIKCEMBD IKPLEGMAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LBBNIKCEMBD.PALPCGGKMEM* GGPLOGLMNCG;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x4142720", Offset = "0x4141720", VA = "0x184142720")]
		public void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData FBJFKLLHMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x4142740", Offset = "0x4141740", VA = "0x184142740", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x41427E0", Offset = "0x41417E0", VA = "0x1841427E0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref LBBNIKCEMBD.PALPCGGKMEM MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x4142890", Offset = "0x4141890", VA = "0x184142890")]
		public void JCIHNCONGGN(KGEPBPDNNPB MFLHDNPOKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x41426B0", Offset = "0x41416B0", VA = "0x1841426B0")]
		public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery HAJJMFHLKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker OOOJHALNLDA;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DF70", Offset = "0x2C6CF70", VA = "0x182C6DF70", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E1D0", Offset = "0x2C6D1D0", VA = "0x182C6E1D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public KGEPBPDNNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DC20", Offset = "0x2C6CC20", VA = "0x182C6DC20")]
	[CompilerGenerated]
	private void DLHCGDHHIMI(Entity IEFFOCOBJJI, ParentData FBJFKLLHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DFD0", Offset = "0x2C6CFD0", VA = "0x182C6DFD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C6DE10", Offset = "0x2C6CE10", VA = "0x182C6DE10")]
	public static EntityQuery MCKOELHBGOE(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class MFOFPNHDDEA : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int DMIONCHNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery FBENFNFLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs AAPBAEGCALL;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x296F030", Offset = "0x296E030", VA = "0x18296F030", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x296F080", Offset = "0x296E080", VA = "0x18296F080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x296F160", Offset = "0x296E160", VA = "0x18296F160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x296EC90", Offset = "0x296DC90", VA = "0x18296EC90")]
	private void FADPOKMLNPG(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public MFOFPNHDDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(MFOFPNHDDEA))]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	public class PostLoadAddSceneTagEntity : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService EFOAKEMFNMA;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2985690", Offset = "0x2984690", VA = "0x182985690", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x29856E0", Offset = "0x29846E0", VA = "0x1829856E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	[HEOEGCBCCCD(KHFGEOAKOKD.OMRoom)]
	public class PostLoadInitializeNetworkId : GAJBCDLDAEF, COMOMFINKHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct KGHMJICOIBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<AIELFMMICMN, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
			public KGHMJICOIBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OLBPHCKPHOE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct AIFMIFECCKF
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct BJIEICBBFIF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime FAOGNOODDOG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BLAJMEMAINO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex AAHKKHBOJAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MPNOECLFIEJ;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x413BCF0", Offset = "0x413ACF0", VA = "0x18413BCF0")]
				public void JCIHNCONGGN(PostLoadInitializeNetworkId MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x413BC40", Offset = "0x413AC40", VA = "0x18413BC40")]
				public BJIEICBBFIF EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(BJIEICBBFIF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private AIFMIFECCKF IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AIFMIFECCKF.BJIEICBBFIF* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DCHEEHNBOGO;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x4145650", Offset = "0x4144650", VA = "0x184145650")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, int KBNPGMICLJO, ref ObjectNetworkIdComponentData KKFCOGJAMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x2B01380", Offset = "0x2B00380", VA = "0x182B01380", Slot = "5")]
			public void ReadFromDisplayClass(ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x26C9E00", Offset = "0x26C8E00", VA = "0x1826C9E00", Slot = "6")]
			public void WriteToDisplayClass(ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x41456E0", Offset = "0x41446E0", VA = "0x1841456E0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x41457D0", Offset = "0x41447D0", VA = "0x1841457D0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref AIFMIFECCKF.BJIEICBBFIF MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x41458A0", Offset = "0x41448A0", VA = "0x1841458A0")]
			public void JCIHNCONGGN(PostLoadInitializeNetworkId MFLHDNPOKPM, ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x41455E0", Offset = "0x41445E0", VA = "0x1841455E0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[GNFGKNINDPI]
		private ObjectNetworkToLocalMapService LEAPKBHNHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[GNFGKNINDPI]
		private SceneService MMKJPCINEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery FBENFNFLPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery JEGAMODLENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker KFKLBCDDFBP;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x2986310", Offset = "0x2985310", VA = "0x182986310", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x2986610", Offset = "0x2985610", VA = "0x182986610", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x2985FE0", Offset = "0x2984FE0", VA = "0x182985FE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x2985FE0", Offset = "0x2984FE0", VA = "0x182985FE0")]
		public void HDEKDDOGIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x2985A90", Offset = "0x2984A90", VA = "0x182985A90")]
		private void EJPJIGGIGPN(NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x29860B0", Offset = "0x29850B0", VA = "0x1829860B0")]
		private void KJEKDHHCIGH(NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2986380", Offset = "0x2985380", VA = "0x182986380", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x29858F0", Offset = "0x29848F0", VA = "0x1829858F0")]
		public static EntityQuery DIIOKCEOEMD(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class EJHDIJBKOOE : GAJBCDLDAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery MHKIKHPHHAD;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80960", Offset = "0x2A7F960", VA = "0x182A80960", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2A809F0", Offset = "0x2A7F9F0", VA = "0x182A809F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public EJHDIJBKOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class JAFGDDJPLKB : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::BOONDFDEOBC<CBDMAFGMIBG> PCIBIEHDLDP;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A060", Offset = "0x2C69060", VA = "0x182C6A060", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A100", Offset = "0x2C69100", VA = "0x182C6A100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x2C69E00", Offset = "0x2C68E00", VA = "0x182C69E00")]
	private void FPNJCAMPBJL(NativeList<EntityArchetype> OOJLGDAONOE, NativeHashMap<int, PEFLLNEDEOA> NJEOKLPOEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x2C69CC0", Offset = "0x2C68CC0", VA = "0x182C69CC0")]
	private Span<int> EJIPNOIHEKP(EntityArchetype FAAKDBHJKLM)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x2C69F90", Offset = "0x2C68F90", VA = "0x182C69F90")]
	private bool IAKHKPAGNOG(int CNNKHGOHIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x2C696C0", Offset = "0x2C686C0", VA = "0x182C696C0")]
	private void BKCFAMKHOGM(NativeHashMap<int, PEFLLNEDEOA> NJEOKLPOEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public JAFGDDJPLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[LMNMHFHDONH(IPKPBIMLPOB.Serialization)]
	public class PreSerializeRemoveEntities : GAJBCDLDAEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery AMDEGPFCAAC;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2986700", Offset = "0x2985700", VA = "0x182986700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2986980", Offset = "0x2985980", VA = "0x182986980", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[LMNMHFHDONH(IPKPBIMLPOB.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : GAJBCDLDAEF, COMOMFINKHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct MIBCBFOIHJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public BOHBJPNCJPN dstComponentData;

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
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
			public MIBCBFOIHJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE1B0", VA = "0x182AFF1B0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct IANLBKJCJEI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> JOOBOILFNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> BMEHNGMFIGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public BOHBJPNCJPN JEPELMJGPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> JFKHJAJODDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int LKBNNMCHCFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType OMMPBBANJJE;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x41401C0", Offset = "0x413F1C0", VA = "0x1841401C0")]
			internal void EACJNOHFKHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x41403B0", Offset = "0x413F3B0", VA = "0x1841403B0", Slot = "5")]
			public void ReadFromDisplayClass(ref MIBCBFOIHJG ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x4140380", Offset = "0x413F380", VA = "0x184140380", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x4140390", Offset = "0x413F390", VA = "0x184140390")]
			public void JCIHNCONGGN(ShadowWorldApplyPropertyDifferencesToShadowWorld MFLHDNPOKPM, ref MIBCBFOIHJG ENNMBDEBHBB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService GHONGEBCKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle NKPGBCONHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle GNKAFCEMEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private IEPINABNOFO IDIIBDOHICE;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A300", Offset = "0x2B09300", VA = "0x182B0A300", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x2B09FB0", Offset = "0x2B08FB0", VA = "0x182B09FB0")]
		public JobHandle KLEJCNDMJEE(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A360", Offset = "0x2B09360", VA = "0x182B0A360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2B09FF0", Offset = "0x2B08FF0", VA = "0x182B09FF0")]
		private bool MLEGAOGIIOE(JobHandle MPFKOMLNJME, int CNNKHGOHIDH, out JobHandle CDICIBOMMJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(MKJABAMJHFG))]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal sealed class KGJFBMCBDKO : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E2E0", Offset = "0x2C6D2E0", VA = "0x182C6E2E0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public KGJFBMCBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[BLFKHCHIGFF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
[UpdateInGroup(typeof(CBMCNFGKKIE))]
internal sealed class DOCHMGNAMCK : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CD30", Offset = "0x2A7BD30", VA = "0x182A7CD30", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public DOCHMGNAMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[BLFKHCHIGFF]
[ExecuteAlways]
[UpdateInGroup(typeof(NOJHNPFEEEK))]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal sealed class NIJGMDCGDHM : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2971A00", Offset = "0x2970A00", VA = "0x182971A00", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public NIJGMDCGDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[BLFKHCHIGFF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
[UpdateInGroup(typeof(NFLLPDGJECH))]
internal sealed class GLPDMDGLDBM : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F620", Offset = "0x2C5E620", VA = "0x182C5F620", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public GLPDMDGLDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class CPEOCAOJGEA : CLFIGHANMAA
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override HKIFOHOEGHF PEMLFOLLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AA0", Offset = "0x6A3AA0", VA = "0x1806A4AA0", Slot = "18")]
		get
		{
			return default(HKIFOHOEGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public CPEOCAOJGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(EMCPAACKFBP))]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal sealed class IHNNGLHDAML : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x2C66E20", Offset = "0x2C65E20", VA = "0x182C66E20", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public IHNNGLHDAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class AAAOFFGBNJM : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public AAAOFFGBNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class PFKLLPDENKJ : CLFIGHANMAA
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override HKIFOHOEGHF PEMLFOLLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "18")]
		get
		{
			return default(HKIFOHOEGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2980C20", Offset = "0x297FC20", VA = "0x182980C20")]
	public PFKLLPDENKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[BLFKHCHIGFF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
[UpdateInGroup(typeof(IEFOBDFNPEA))]
internal sealed class HPMOHGHHBJM : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2C62DF0", Offset = "0x2C61DF0", VA = "0x182C62DF0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public HPMOHGHHBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class KMCNFCNMMDB : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public KMCNFCNMMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class DABHEHADJJP : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public DABHEHADJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class MLDHKKJBBNJ : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public MLDHKKJBBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[EJCMEBPBPBF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
public class NOBEEEJHDIH : GAJBCDLDAEF, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService ABBPIJBGMOG;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2972E00", Offset = "0x2971E00", VA = "0x182972E00", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2972E50", Offset = "0x2971E50", VA = "0x182972E50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public NOBEEEJHDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class CopyTransformDataFromGameObjects : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct HJOFPBJLKHN : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float POBFDCJHOGD = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> NNFKFGMKAKG;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x2B00A70", Offset = "0x2AFFA70", VA = "0x182B00A70", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x2B00CA0", Offset = "0x2AFFCA0", VA = "0x182B00CA0")]
			private bool LBPIGEGMNBG(float3 MKDFAPBMCCA, float3 FDANAHCAINP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x2B00C30", Offset = "0x2AFFC30", VA = "0x182B00C30")]
			private bool JMMOMOBEPKP(quaternion MKDFAPBMCCA, quaternion FDANAHCAINP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct KCCDOFBKDMM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> EANJBIKMEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> AMCHLGPIJGL;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x2B015A0", Offset = "0x2B005A0", VA = "0x182B015A0", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FBNJDMKEPCN FNJEFDLNIOB;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly FBNJDMKEPCN HLKGAAIAOJE;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly FBNJDMKEPCN LFKOPEGGCHD;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker PLPEDLPEMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private ADJFIMDIPEF IEEGCHGELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x2A759C0", Offset = "0x2A749C0", VA = "0x182A759C0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x2A75A30", Offset = "0x2A74A30", VA = "0x182A75A30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x2A75A60", Offset = "0x2A74A60", VA = "0x182A75A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	public class RegisterTransforms : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct AMKKOMOMIEE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct ENJKOLEMJNB
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct KEGCJEDLPNC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<FIGJHEBAEKN>.Runtime BGDBOALLFLD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime DFAAJCMKIIJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<FIGJHEBAEKN> DCLMAJECJIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> HAOFJOJAFEP;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x413E9E0", Offset = "0x413D9E0", VA = "0x18413E9E0")]
				public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x413E920", Offset = "0x413D920", VA = "0x18413E920")]
				public KEGCJEDLPNC EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(KEGCJEDLPNC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private ENJKOLEMJNB IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ENJKOLEMJNB.KEGCJEDLPNC* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IBNDIABFDFE;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x413BDD0", Offset = "0x413ADD0", VA = "0x18413BDD0")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, FIGJHEBAEKN MNHDAEDPKMK, Transform FLCFNMLPAML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x413BED0", Offset = "0x413AED0", VA = "0x18413BED0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x413BFC0", Offset = "0x413AFC0", VA = "0x18413BFC0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref ENJKOLEMJNB.KEGCJEDLPNC MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x413C0A0", Offset = "0x413B0A0", VA = "0x18413C0A0")]
			public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x413BD60", Offset = "0x413AD60", VA = "0x18413BD60")]
			public unsafe static void CDEKFJFKPFH(ArchetypeChunkIterator* JLKLPCFJOPJ, void* KNMBBNJMGMG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct JIAKDCFDLBI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct CPJCCGKAFGM
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct HELOOJOECLB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime BGAFIJOEIID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<FIGJHEBAEKN>.Runtime BGDBOALLFLD;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity PIHPNAIPLMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<FIGJHEBAEKN> DCLMAJECJIC;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x413DF80", Offset = "0x413CF80", VA = "0x18413DF80")]
				public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x413DF00", Offset = "0x413CF00", VA = "0x18413DF00")]
				public HELOOJOECLB EMHIHNJOPBA(ref ArchetypeChunk LHFPCCMKNGE, int PJAJGKDMKAN, int IGGIMEMIANP)
				{
					return default(HELOOJOECLB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private CPJCCGKAFGM IKPLEGMAFHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CPJCCGKAFGM.HELOOJOECLB* GGPLOGLMNCG;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x41419B0", Offset = "0x41409B0", VA = "0x1841419B0")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, FIGJHEBAEKN MNHDAEDPKMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x4141A90", Offset = "0x4140A90", VA = "0x184141A90", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x4141B20", Offset = "0x4140B20", VA = "0x184141B20")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref CPJCCGKAFGM.HELOOJOECLB MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x413DF80", Offset = "0x413CF80", VA = "0x18413DF80")]
			public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private ADJFIMDIPEF IEEGCHGELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery ABJGGIFMDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery NILAADJLAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery EPEBFFPLGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery AJLKFBELOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery OBLDHDNENMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker OLINDFLEAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery PFIEMHBDFJO;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x298E730", Offset = "0x298D730", VA = "0x18298E730", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x298E9F0", Offset = "0x298D9F0", VA = "0x18298E9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x298EC00", Offset = "0x298DC00", VA = "0x18298EC00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x298DAC0", Offset = "0x298CAC0", VA = "0x18298DAC0")]
		private void DEJIDINEOOO(EntityQuery FBENFNFLPOM, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x298ED10", Offset = "0x298DD10", VA = "0x18298ED10")]
		private void PCLAMAHCGDH(EntityQuery FBENFNFLPOM, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x298EBA0", Offset = "0x298DBA0", VA = "0x18298EBA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x298E5F0", Offset = "0x298D5F0", VA = "0x18298E5F0")]
		private void MENBPIBPIDH(NativeArray<Entity> BNEBECKGGLP, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x298E0F0", Offset = "0x298D0F0", VA = "0x18298E0F0")]
		[BurstCompile]
		internal static void HPAIBGLDNPF(NativeArray<FIGJHEBAEKN> IONNDHGCPJJ, ComponentDataFromEntity<FIGJHEBAEKN> LMFBKOKDJCO, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void DFOPOAHELPH(Transform FLCFNMLPAML, Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void CEKOBKDFCOF(Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void KCIJMJKBHEO(int NPDGHPHAKDK, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x298E410", Offset = "0x298D410", VA = "0x18298E410")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void IPLFJGOHEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x298E780", Offset = "0x298D780", VA = "0x18298E780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x298DD80", Offset = "0x298CD80", VA = "0x18298DD80")]
		public static EntityQuery DNJBIILDKGA(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x298DF20", Offset = "0x298CF20", VA = "0x18298DF20")]
		public static EntityQuery GAKAKOHHGJO(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	public class CopyTransformDataToGameObjects : GAJBCDLDAEF, COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct OEMJGMKCMCG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> NNFKFGMKAKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x2B03C00", Offset = "0x2B02C00", VA = "0x182B03C00", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct NACHHPEHJIA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> EANJBIKMEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x2B036D0", Offset = "0x2B026D0", VA = "0x182B036D0", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct GLJOKLPKILH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> EANJBIKMEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> AMCHLGPIJGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> BNEBECKGGLP;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x2B00970", Offset = "0x2AFF970", VA = "0x182B00970", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly FBNJDMKEPCN FNJEFDLNIOB;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly FBNJDMKEPCN HLKGAAIAOJE;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FBNJDMKEPCN LFKOPEGGCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private ADJFIMDIPEF IEEGCHGELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery HOOGPJDCFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery HEMAFGACJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery DJGMOCHFDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray PAMHDIKNDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray FEOMHAMALMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray DJNMCPANKNO;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F10", Offset = "0x2A74F10", VA = "0x182A75F10", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2A760E0", Offset = "0x2A750E0", VA = "0x182A760E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2A762D0", Offset = "0x2A752D0", VA = "0x182A762D0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x2A76360", Offset = "0x2A75360", VA = "0x182A76360", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x2A76390", Offset = "0x2A75390", VA = "0x182A76390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F60", Offset = "0x2A74F60", VA = "0x182A75F60")]
		private NativeArray<Entity> OCFPGDDGHJH(NativeArray<FIGJHEBAEKN> JOOBOILFNKM, NativeList<Entity> PNFNAEBJOEK, TransformAccessArray MCJONMBOGNP, TransformAccessArray FDFDJNJDKDF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : GAJBCDLDAEF, BDDJKMOFDGN
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private EGFHGGJBAIJ NOGKPMLPCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private BBDBBCGEPIJ HEDKEAMNACE;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x2986D40", Offset = "0x2985D40", VA = "0x182986D40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x2A76CC0", Offset = "0x2A75CC0", VA = "0x182A76CC0", Slot = "14")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x2A76FF0", Offset = "0x2A75FF0", VA = "0x182A76FF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x2A76DD0", Offset = "0x2A75DD0", VA = "0x182A76DD0")]
		private static void HHPPAKOEDEP(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x2A76F50", Offset = "0x2A75F50", VA = "0x182A76F50")]
		private static bool JIACBDMPAMB(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[LMNMHFHDONH(IPKPBIMLPOB.TransformSyncing)]
	public class L2PToL2WHierarchy : GAJBCDLDAEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PNGJIGICAEI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JNJJEBMGPEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> HPLGPDPLMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> JNODMIHLOFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CKGAJPIDFAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> LCIAMIJPINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> DIFBFOIAIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint PKCPKELNCNN;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x4146B70", Offset = "0x4145B70", VA = "0x184146B70")]
			[Conditional("DEBUG_BUILD")]
			private void HLDGAENDGPF(Entity IEFFOCOBJJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x4146880", Offset = "0x4145880", VA = "0x184146880", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x4146C40", Offset = "0x4145C40", VA = "0x184146C40")]
			private void NEAJLAMBJHD(float4x4 BGBKHFDFGBA, Entity IEFFOCOBJJI, bool EPAIHNIAHPO, int HFAPDGCFEDI = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery KHLHLOFGEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery ABBKODHFHBA;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x2C702F0", Offset = "0x2C6F2F0", VA = "0x182C702F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x2C70410", Offset = "0x2C6F410", VA = "0x182C70410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class KLHMGKNNHGO : EIFFBCEFCLG
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct HMGJKDECPOB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JNJJEBMGPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> LCIAMIJPINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint PKCPKELNCNN;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x4140040", Offset = "0x413F040", VA = "0x184140040", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x4140140", Offset = "0x413F140", VA = "0x184140140")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery KHLHLOFGEDF;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EB40", Offset = "0x2C6DB40", VA = "0x182C6EB40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EC70", Offset = "0x2C6DC70", VA = "0x182C6EC70", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public KLHMGKNNHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class FAGGANCKJPO : EIFFBCEFCLG
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct JJBCBADLKEI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> AGNHEHIENKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> LNDPLGCLPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> NPODEOBKHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> OLONHHEOCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint PKCPKELNCNN;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x4141BD0", Offset = "0x4140BD0", VA = "0x184141BD0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x4141F80", Offset = "0x4140F80", VA = "0x184141F80")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery AKKHHLBJIJB;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x2C58240", Offset = "0x2C57240", VA = "0x182C58240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x2C58350", Offset = "0x2C57350", VA = "0x182C58350", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xDEC260", Offset = "0xDEB260", VA = "0x180DEC260")]
	public FAGGANCKJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class KNCDCOBLKOH : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct OCKPHPONHBH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> KHOOOJAIADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> GDKADLIEJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> DGGEIAMANKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> OFFAOJLFCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint PKCPKELNCNN;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x4144A20", Offset = "0x4143A20", VA = "0x184144A20", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x4145130", Offset = "0x4144130", VA = "0x184145130")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery AKKHHLBJIJB;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F170", Offset = "0x2C6E170", VA = "0x182C6F170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F2A0", Offset = "0x2C6E2A0", VA = "0x182C6F2A0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public KNCDCOBLKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[LMNMHFHDONH(IPKPBIMLPOB.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : MINODIPADOM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct EKKJDNFOGFF : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType DLJFHHGKHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x29877A0", Offset = "0x29867A0", VA = "0x1829877A0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x2987770", Offset = "0x2986770", VA = "0x182987770", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x2987740", Offset = "0x2986740", VA = "0x182987740", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x2970AD0", Offset = "0x296FAD0", VA = "0x182970AD0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[GAMJJBEBIEK(LFELPHGLBIM.Game)]
public class BKGDNPKBAKB : BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x2A69BB0", Offset = "0x2A68BB0", VA = "0x182A69BB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x2A69540", Offset = "0x2A68540", VA = "0x182A69540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public BKGDNPKBAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[GAMJJBEBIEK(LFELPHGLBIM.Loading)]
public class FHHPNKPLMJL : BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x2C59E70", Offset = "0x2C58E70", VA = "0x182C59E70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FHHPNKPLMJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class INJEBCEEHLP : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x2C68E50", Offset = "0x2C67E50", VA = "0x182C68E50", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public INJEBCEEHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[GAMJJBEBIEK(LFELPHGLBIM.Saving)]
public class FICGJEKKHPO : BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2C5B0D0", Offset = "0x2C5A0D0", VA = "0x182C5B0D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public FICGJEKKHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class OMFLDFOCLJJ : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x29741C0", Offset = "0x29731C0", VA = "0x1829741C0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public OMFLDFOCLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[GAMJJBEBIEK(LFELPHGLBIM.Simulation)]
public class PDGLGDBCFOM : BKDOMKKCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type PCPMHJMOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2980BB0", Offset = "0x297FBB0", VA = "0x182980BB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x2980800", Offset = "0x297F800", VA = "0x182980800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PDGLGDBCFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[DEJAKMDKDPE(typeof(HCIKADJCDDL), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal class HCIKADJCDDL : BDDJKMOFDGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::NJDCFGJOHMC<AuthoredParentData, CMKCMMGCODO, DAIENMFCLGH, AuthoredChildrenData> LIMJKGMPKME;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x2C61410", Offset = "0x2C60410", VA = "0x182C61410", Slot = "4")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public HCIKADJCDDL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	[DEJAKMDKDPE(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : COMOMFINKHP, BDDJKMOFDGN
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[GNFGKNINDPI]
		private HJBNADOIEKJ AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[GNFGKNINDPI]
		private PropertyChangeNetworkRouter CKKLKHDKCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::IBOLLEGFEDA<Entity> FJONJLMIBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::NJDCFGJOHMC<ParentData, JOLFHHMPJFM, NGOFLCOLJKB, ChildrenData> LIMJKGMPKME;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x2C56670", Offset = "0x2C55670", VA = "0x182C56670", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2C56240", Offset = "0x2C55240", VA = "0x182C56240", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2C56340", Offset = "0x2C55340", VA = "0x182C56340")]
		public Entity EKMEMACGALM(Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2C56610", Offset = "0x2C55610", VA = "0x182C56610")]
		public bool LAPLJEJINGM(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2C56390", Offset = "0x2C55390", VA = "0x182C56390")]
		public bool GBLKBIAEIPL(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE, bool NBCBLABIJMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2C56430", Offset = "0x2C55430", VA = "0x182C56430")]
		private bool GDHEHGJFFEM(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[DEJAKMDKDPE(typeof(AEHDHJJIFOJ), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal sealed class AEHDHJJIFOJ : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery HHNNJENPEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2A65270", Offset = "0x2A64270", VA = "0x182A65270")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x2A65690", Offset = "0x2A64690", VA = "0x182A65690", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x2A65250", Offset = "0x2A64250", VA = "0x182A65250", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2A65850", Offset = "0x2A64850", VA = "0x182A65850")]
	public bool ONFDIBDBOKI(Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2A65520", Offset = "0x2A64520", VA = "0x182A65520")]
	public IEnumerable<Entity> LHNLJGEEPBH(Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x2A65790", Offset = "0x2A64790", VA = "0x182A65790")]
	public bool OIGMHNPAGCC(Entity IEFFOCOBJJI, Entity ELFIACEEOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x2A65140", Offset = "0x2A64140", VA = "0x182A65140")]
	public bool BNNCMPPKFKP(Entity IEFFOCOBJJI, Entity BBDPANMBHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2A65390", Offset = "0x2A64390", VA = "0x182A65390")]
	public NativeList<Entity> IEEPKLPNIEF(Entity IEFFOCOBJJI, bool CCDLJLHECME = false, Allocator AEPJLHDIHPH = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2A65910", Offset = "0x2A64910", VA = "0x182A65910")]
	public IEnumerable<Entity> PICEAKMECIB(Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2A65470", Offset = "0x2A64470", VA = "0x182A65470")]
	public Entity LGNFHDEKAND(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2A65200", Offset = "0x2A64200", VA = "0x182A65200")]
	public NativeArray<Entity> BNNIGJAFFAC()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2A652C0", Offset = "0x2A642C0", VA = "0x182A652C0")]
	public bool GOHPGPBBEBL(Entity BBDPANMBHID, Entity PACKOPHLIKB, out Entity OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x2A655E0", Offset = "0x2A645E0", VA = "0x182A655E0")]
	private Entity MAGJHAEAOAI(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AEHDHJJIFOJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x2F3E790", Offset = "0x2F3D790", VA = "0x182F3E790")]
		public static void JGMOEBJPLEH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(OKKPKCPMOFL GNDGFHCLBLF, global::KBOIOIDENFM<Entity> AOKAOIOMMBG, out global::NJDCFGJOHMC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> BHEGBBGFCPN) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LFJBLBLGJHE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LFJBLBLGJHE, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x2982060", Offset = "0x2981060", VA = "0x182982060")]
		public static bool ILANAEFMBKB(BDCNBKPMJEP JENEHFPKFDC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class NJDCFGJOHMC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LFJBLBLGJHE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LFJBLBLGJHE, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::IBOLLEGFEDA<Entity> FJONJLMIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly JNPKGPPKFAP GCLLFAFDLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly FOINMHEHJED ICMEPOIJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly BBDBBCGEPIJ HEDKEAMNACE;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x32A29A0", Offset = "0x32A19A0", VA = "0x1832A29A0")]
	public NJDCFGJOHMC(OKKPKCPMOFL GNDGFHCLBLF, global::KBOIOIDENFM<Entity> AOKAOIOMMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x32A1B30", Offset = "0x32A0B30", VA = "0x1832A1B30")]
	private bool MKDANKEGIPK(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x32A1AE0", Offset = "0x32A0AE0", VA = "0x1832A1AE0")]
	private bool MDALKKAJGJO(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x32A1AB0", Offset = "0x32A0AB0", VA = "0x1832A1AB0")]
	public bool LAPLJEJINGM(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x32A1BF0", Offset = "0x32A0BF0", VA = "0x1832A1BF0")]
	public bool OGAFOFCGLKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x32A1C20", Offset = "0x32A0C20", VA = "0x1832A1C20")]
	private bool OGAFOFCGLKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE, bool GDNDPJPIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void FKFMAIIHMML(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void IJOMODFOKPM(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void CIMEMNGOLIF(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void LEIDIGHFBKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private static void DIPDHPHOKKK(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x32A2060", Offset = "0x32A1060", VA = "0x1832A2060")]
	private bool ONFDIBDBOKI(Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x32A1560", Offset = "0x32A0560", VA = "0x1832A1560")]
	private void FIKOBEBKDBP(Entity IEFFOCOBJJI, in Entity KFGEJHIJBGK, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x32A1770", Offset = "0x32A0770", VA = "0x1832A1770")]
	private void JJLEDHBOEAA(Entity IEFFOCOBJJI, in Entity KFGEJHIJBGK, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x32A1160", Offset = "0x32A0160", VA = "0x1832A1160")]
	private bool DAMBMOELOGB(FOKMJKHMEIK ACABAHFPHCL, in AIELFMMICMN KAKGJMHAAEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x32A2220", Offset = "0x32A1220", VA = "0x1832A2220")]
	private void PGODIABCAMB(Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x32A1650", Offset = "0x32A0650", VA = "0x1832A1650")]
	private void HLPNFHFHFFD(Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private void KCIJMJKBHEO(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	private void DFOPOAHELPH(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct NGNDDACDKHJ : ADNHFABDAIG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public HMIKLFBELAH BDHDLDFKJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HMIKLFBELAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6E34E0", Offset = "0x6E24E0", VA = "0x1806E34E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[DEJAKMDKDPE(typeof(ObjectEmbodimentService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Embodiment)]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	internal sealed class ObjectEmbodimentService : MBAIJLHLCNO, LGFONBKKNKN, COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService FHPIBOEMPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[GNFGKNINDPI]
		private HJBNADOIEKJ AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[GNFGKNINDPI]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[GNFGKNINDPI]
		private HBFLPONDKFF OLPNBPCMPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[GNFGKNINDPI]
		private JLADNPOGKFE BIJJDHBNBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[GNFGKNINDPI]
		private TransformOwnershipPhase DCICIPKAADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<AIELFMMICMN, GEINEDFCGEN> EODAJGIEKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private HDKBBILLNDN DPMGNNOOBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x2976020", Offset = "0x2975020", VA = "0x182976020")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int NIINPFLMDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x2977010", Offset = "0x2976010", VA = "0x182977010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int FNGDFEABKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x2974A40", Offset = "0x2973A40", VA = "0x182974A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1D19A10", Offset = "0x1D18A10", VA = "0x181D19A10", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2977810", Offset = "0x2976810", VA = "0x182977810", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x2976C00", Offset = "0x2975C00", VA = "0x182976C00")]
		public void KNFCIAAKCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x29748F0", Offset = "0x29738F0", VA = "0x1829748F0", Slot = "6")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x2975A70", Offset = "0x2974A70", VA = "0x182975A70", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x2976BE0", Offset = "0x2975BE0", VA = "0x182976BE0")]
		public int KLEILBIFCLP(SceneTag PPJNHEBGICL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x2978270", Offset = "0x2977270", VA = "0x182978270")]
		public int POIOKMGKODA(SceneTag PPJNHEBGICL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x2977D60", Offset = "0x2976D60", VA = "0x182977D60")]
		public bool OKIFBABICGJ(Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH, out NativeList<Entity> OPCIAPFFKEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x2975000", Offset = "0x2974000", VA = "0x182975000")]
		public bool DCIOMKBMMMH(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x2976B20", Offset = "0x2975B20", VA = "0x182976B20")]
		public bool KFLIOAAFEFM(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x29773F0", Offset = "0x29763F0", VA = "0x1829773F0")]
		public bool MAKGCDLBBBK(Entity IEFFOCOBJJI, out GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x2977460", Offset = "0x2976460", VA = "0x182977460")]
		private bool MAKGCDLBBBK(Transform FLCFNMLPAML, out GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x29759E0", Offset = "0x29749E0", VA = "0x1829759E0")]
		private void DIGPHILJGLP(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2975BA0", Offset = "0x2974BA0", VA = "0x182975BA0")]
		private bool EDKKGBDGEDF(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2977940", Offset = "0x2976940", VA = "0x182977940")]
		public void MNFGPLMIANE(AIELFMMICMN CDEOFEMHEEC, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x2974B20", Offset = "0x2973B20", VA = "0x182974B20")]
		public bool CJKIOBBKHHH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x2975630", Offset = "0x2974630", VA = "0x182975630")]
		public bool DHANCBOLGKO(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x29755E0", Offset = "0x29745E0", VA = "0x1829755E0")]
		public bool DHANCBOLGKO(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x29755C0", Offset = "0x29745C0", VA = "0x1829755C0")]
		public bool DHANCBOLGKO(GEINEDFCGEN JENEHFPKFDC, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x2976070", Offset = "0x2975070", VA = "0x182976070")]
		public bool GKEDFHBNNKA(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x2976440", Offset = "0x2975440", VA = "0x182976440")]
		public bool GKEDFHBNNKA(GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x2975250", Offset = "0x2974250", VA = "0x182975250")]
		public bool DHANCBOLGKO(GEINEDFCGEN NKDJGKIHEEA, [Optional] object KCCFEDJJGAN, bool PAKHNBOHLFK = false, bool IMODGJODCCN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x2976470", Offset = "0x2975470", VA = "0x182976470")]
		public Transform HCCGAJBGGPD(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x2976920", Offset = "0x2975920", VA = "0x182976920")]
		public bool JIACBDMPAMB(Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2975E50", Offset = "0x2974E50", VA = "0x182975E50")]
		public GEINEDFCGEN FJINJLOCNAL(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2975BC0", Offset = "0x2974BC0", VA = "0x182975BC0")]
		public void FCMOAONOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2977030", Offset = "0x2976030", VA = "0x182977030")]
		public void LHGPMLOGFNE(SceneTag PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2976C50", Offset = "0x2975C50", VA = "0x182976C50")]
		private void LEGKAOLGKJJ(Entity IEFFOCOBJJI, bool ANOIJBOMAFM, bool FLMMGPPLPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x2976880", Offset = "0x2975880", VA = "0x182976880")]
		private void JHGOEPJFGMO(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA, bool ANOIJBOMAFM, bool FLMMGPPLPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x2975F40", Offset = "0x2974F40", VA = "0x182975F40")]
		public GEINEDFCGEN FLFFBLKEEFH(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2976800", Offset = "0x2975800", VA = "0x182976800")]
		public bool JGLLIFJLHAE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x29781F0", Offset = "0x29771F0", VA = "0x1829781F0")]
		public bool PHJOIGAAGCH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2976AB0", Offset = "0x2975AB0", VA = "0x182976AB0")]
		public bool KBKAKBBJBHI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2974EC0", Offset = "0x2973EC0", VA = "0x182974EC0")]
		public bool DBCMAAAEHMC(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2974F30", Offset = "0x2973F30", VA = "0x182974F30")]
		public bool DBCMAAAEHMC(HMIKLFBELAH DCLMHANFEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void EOIIGNKEEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x29769F0", Offset = "0x29759F0", VA = "0x1829769F0")]
		private void JKIJOBHFCDG(bool IGGFHHEDAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2975F90", Offset = "0x2974F90", VA = "0x182975F90")]
		private bool FLNMKKGOGHA(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2976B40", Offset = "0x2975B40", VA = "0x182976B40")]
		private GEINEDFCGEN KHGJDGAOKOE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x29745E0", Offset = "0x29735E0", VA = "0x1829745E0")]
		private GEINEDFCGEN AANBONKKMMH(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x29765E0", Offset = "0x29755E0", VA = "0x1829765E0")]
		private (Vector3, Quaternion, Vector3) HONLAKNIAPG(Entity IEFFOCOBJJI)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2977B40", Offset = "0x2976B40", VA = "0x182977B40")]
		private void NPFLBKMJAIN(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2974A60", Offset = "0x2973A60", VA = "0x182974A60")]
		private void CHIKFGIPBDO(PMFFIMLMCEJ GMOMNBJDADO, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x29747D0", Offset = "0x29737D0", VA = "0x1829747D0")]
		private void BCLDHJHDHMK(GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2977510", Offset = "0x2976510", VA = "0x182977510")]
		private void MEJENFCFOCG(GEINEDFCGEN NKDJGKIHEEA, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2977FB0", Offset = "0x2976FB0", VA = "0x182977FB0")]
		private void OOHGDDKLAJP(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2977C80", Offset = "0x2976C80", VA = "0x182977C80")]
		private void OKEEAAOGCHJ(Entity IEFFOCOBJJI, Transform FLCFNMLPAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2977C50", Offset = "0x2976C50", VA = "0x182977C50")]
		private PMFFIMLMCEJ OGPGFBOCGBO(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x29782E0", Offset = "0x29772E0", VA = "0x1829782E0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2977740", Offset = "0x2976740", VA = "0x182977740")]
		[CompilerGenerated]
		private void MLGHOCKLPIA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class OJKAGBBILAB
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x29737D0", Offset = "0x29727D0", VA = "0x1829737D0")]
	public static GEINEDFCGEN FJINJLOCNAL(this ObjectEmbodimentService ADDOLKFBKIO, PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[LMNMHFHDONH(IPKPBIMLPOB.Lifecycle)]
	[DEJAKMDKDPE(typeof(ObjectLifecycleService), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	internal sealed class ObjectLifecycleService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService NKDJGKIHEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private FPOMEGCHHAA NPMFOILJLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects JKOAKHNPKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x2979340", Offset = "0x2978340", VA = "0x182979340")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, PEMKGMKGDAH> FDOEINMOMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x29792A0", Offset = "0x29782A0", VA = "0x1829792A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x2979470", Offset = "0x2978470", VA = "0x182979470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> CMOJGOJPGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x29793D0", Offset = "0x29783D0", VA = "0x1829793D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x29798C0", Offset = "0x29788C0", VA = "0x1829798C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2979790", Offset = "0x2978790", VA = "0x182979790", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x154C4C0", Offset = "0x154B4C0", VA = "0x18154C4C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2979710", Offset = "0x2978710", VA = "0x182979710")]
		public bool LCJCOLBECPG(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x2979240", Offset = "0x2978240", VA = "0x182979240")]
		internal void FLAEOIMDEPF(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2979390", Offset = "0x2978390", VA = "0x182979390")]
		public void HJMIDDMHEPE(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2979870", Offset = "0x2978870", VA = "0x182979870")]
		public void NOFMEPKGEFN(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2978B10", Offset = "0x2977B10", VA = "0x182978B10")]
		private bool CALDDMHHLKE(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2979510", Offset = "0x2978510", VA = "0x182979510")]
		public void KGNKLNCMPDI(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2978E80", Offset = "0x2977E80", VA = "0x182978E80")]
		private bool EONGFJBCGJI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2978A80", Offset = "0x2977A80", VA = "0x182978A80")]
		public void CAFIKGIFHPM(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2978A20", Offset = "0x2977A20", VA = "0x182978A20")]
		private void ADPHFKPCNIG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2978BD0", Offset = "0x2977BD0", VA = "0x182978BD0")]
		private void DDABKLLHJNG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2978E30", Offset = "0x2977E30", VA = "0x182978E30")]
		public void DHJNKJNMCAN(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private void BLEKLGEFGCL(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2979040", Offset = "0x2978040", VA = "0x182979040")]
		private void FJFICDDJKAE(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[DEJAKMDKDPE(typeof(ObjectPrefabs), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Prefabs)]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	internal class ObjectPrefabs : BPDFOFCBJLO, COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class PBLEMCJJOJP : IEnumerable<(PDAOCOFFNGC, PEMKGMKGDAH)>, IEnumerable, IEnumerator<(PDAOCOFFNGC, PEMKGMKGDAH)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (PDAOCOFFNGC primitiveType, PEMKGMKGDAH prefabType) <>2__current;

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
			private (PDAOCOFFNGC, PEMKGMKGDAH) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x1BF7FC0", Offset = "0x1BF6FC0", VA = "0x181BF7FC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((PDAOCOFFNGC, PEMKGMKGDAH));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x4146120", Offset = "0x4145120", VA = "0x184146120", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x413D9C0", Offset = "0x413C9C0", VA = "0x18413D9C0")]
			[DebuggerHidden]
			public PBLEMCJJOJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x4145F40", Offset = "0x4144F40", VA = "0x184145F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x41460E0", Offset = "0x41450E0", VA = "0x1841460E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x4146040", Offset = "0x4145040", VA = "0x184146040", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(PDAOCOFFNGC, PEMKGMKGDAH)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x4146040", Offset = "0x4145040", VA = "0x184146040", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<PEMKGMKGDAH, Entity> AAPBAEGCALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<PEMKGMKGDAH, EntityArchetype> OOJLGDAONOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<PDAOCOFFNGC, PEMKGMKGDAH> HMFIKHPECEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<OLDNDABJJEI, PEMKGMKGDAH> DILLFIHOJIM;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x297C900", Offset = "0x297B900", VA = "0x18297C900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x297D030", Offset = "0x297C030", VA = "0x18297D030")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x297D2F0", Offset = "0x297C2F0", VA = "0x18297D2F0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x297CA70", Offset = "0x297BA70", VA = "0x18297CA70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x297CF60", Offset = "0x297BF60", VA = "0x18297CF60")]
		internal IEnumerable<Type> FOPAHDPPJME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x297CFC0", Offset = "0x297BFC0", VA = "0x18297CFC0")]
		internal ONKHKDOBJAL GEMMEHMHOEM(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x297C950", Offset = "0x297B950", VA = "0x18297C950")]
		public EntityArchetype DGAGOIDBGAD(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x297D170", Offset = "0x297C170", VA = "0x18297D170")]
		public NativeHashMap<int, EntityArchetype> LCAFEGDBHKJ(Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x297C5F0", Offset = "0x297B5F0", VA = "0x18297C5F0")]
		public bool CEIAPAFHDOL(PEMKGMKGDAH NFNGIKPPKJH, out EntityArchetype FAAKDBHJKLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x297C410", Offset = "0x297B410", VA = "0x18297C410", Slot = "4")]
		[IteratorStateMachine(typeof(PBLEMCJJOJP))]
		public IEnumerable<(PDAOCOFFNGC, PEMKGMKGDAH)> BBKIFGLIMLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x297CE00", Offset = "0x297BE00", VA = "0x18297CE00")]
		public Entity FAKFHJIOGLF(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x297CA10", Offset = "0x297BA10", VA = "0x18297CA10")]
		public PEMKGMKGDAH DOKKMMPFKFK(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x297C9B0", Offset = "0x297B9B0", VA = "0x18297C9B0")]
		public PEMKGMKGDAH DOKKMMPFKFK(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x297C480", Offset = "0x297B480", VA = "0x18297C480")]
		public NativeHashMap<int, Entity> BNOFEJBKGLC(Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x297CF10", Offset = "0x297BF10", VA = "0x18297CF10")]
		public IEnumerable<PEMKGMKGDAH> FEAMMEKINDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x297CDA0", Offset = "0x297BDA0", VA = "0x18297CDA0")]
		public Entity EHKNDPLJDHA(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x297C660", Offset = "0x297B660", VA = "0x18297C660")]
		public bool CFEDEDIJJMD(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x297BFC0", Offset = "0x297AFC0", VA = "0x18297BFC0")]
		private void AAPNNMMCLNP(ONKHKDOBJAL ILBINHKPOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x297C6D0", Offset = "0x297B6D0", VA = "0x18297C6D0")]
		internal void CGIFALKBEHL(PEMKGMKGDAH NFNGIKPPKJH, OANHHCFFOEG FOOIEEEGFDG, FPKNLHBDGEP ENCNEIHBNIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x297BE60", Offset = "0x297AE60", VA = "0x18297BE60")]
		private void AALOHBDPEMM(PEMKGMKGDAH NFNGIKPPKJH, OANHHCFFOEG IHFNCPHANDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x297D050", Offset = "0x297C050", VA = "0x18297D050")]
		internal Entity JLKBKFODPAI(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x297D720", Offset = "0x297C720", VA = "0x18297D720")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum HKIFOHOEGHF
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface CKPGCELNFNM
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	MDBAAKNLHNI DPFLAIIDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class EIECINGNDLI : OKLEKHOLNCL, IEPINABNOFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly AHKBIJEMLBD HGLAEFBOOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly HKIFOHOEGHF DCICIPKAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<PJECKKFIGKG> IICNBHHODDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, FGFOHLOEDBC> OJOPOEOLLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> BOJMKKBKIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle DEIDIKJMCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle KBAIICEFHAP;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World JGBNLMMMHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2A80700", Offset = "0x2A7F700", VA = "0x182A80700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private MDBAAKNLHNI LMHDHLGMLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FD80", Offset = "0x2A7ED80", VA = "0x182A7FD80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private LHHIGECFLLB JDACLIPOFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x692D40", Offset = "0x691D40", VA = "0x180692D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, FGFOHLOEDBC> PNFOKDAEDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x69F030", Offset = "0x69E030", VA = "0x18069F030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, FGFOHLOEDBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle OMAAMMGDLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0xF5F9C0", Offset = "0xF5E9C0", VA = "0x180F5F9C0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xF60090", Offset = "0xF5F090", VA = "0x180F60090", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool KKIENAEPCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x2A80860", Offset = "0x2A7F860", VA = "0x182A80860", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World GMABANAEKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FDA0", Offset = "0x2A7EDA0", VA = "0x182A7FDA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x2A808B0", Offset = "0x2A7F8B0", VA = "0x182A808B0")]
	public EIECINGNDLI(AHKBIJEMLBD HGLAEFBOOJL, HKIFOHOEGHF DCICIPKAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2A80850", Offset = "0x2A7F850", VA = "0x182A80850", Slot = "11")]
	private void PHOOGHEPLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80610", Offset = "0x2A7F610", VA = "0x182A80610", Slot = "10")]
	private bool JIGEEPNLOKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x2A80230", Offset = "0x2A7F230", VA = "0x182A80230", Slot = "12")]
	private void FDBIFLAEGPJ(ComponentType OMMPBBANJJE, in PJECKKFIGKG HHKBPEJHMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FF50", Offset = "0x2A7EF50", VA = "0x182A7FF50", Slot = "13")]
	private bool DPKHJCPEDLL(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FAC0", Offset = "0x2A7EAC0", VA = "0x182A7FAC0", Slot = "16")]
	private bool AGLOCDBGMCJ(out NativeArray<int> OOFMEFFBOEL, Allocator AEPJLHDIHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x2A80320", Offset = "0x2A7F320", VA = "0x182A80320", Slot = "17")]
	private bool HGPPMKGJAPK(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL, out HALLOMDKPOM ECGOBGEIPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2A804A0", Offset = "0x2A7F4A0", VA = "0x182A804A0", Slot = "18")]
	private bool HGPPMKGJAPK(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x2A80760", Offset = "0x2A7F760", VA = "0x182A80760", Slot = "19")]
	private PJECKKFIGKG NPENIIJOLJK(ComponentType OMMPBBANJJE)
	{
		return default(PJECKKFIGKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x2A805D0", Offset = "0x2A7F5D0", VA = "0x182A805D0", Slot = "20")]
	private ANLCPLEKFMI HJHJMLBCAJA()
	{
		return default(ANLCPLEKFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x2A80870", Offset = "0x2A7F870", VA = "0x182A80870", Slot = "21")]
	private void POAICCGIAPD(JobHandle CPPLLJNMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FF80", Offset = "0x2A7EF80", VA = "0x182A7FF80")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FB60", Offset = "0x2A7EB60", VA = "0x182A7FB60")]
	private bool BHBIONNJICN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FE00", Offset = "0x2A7EE00", VA = "0x182A7FE00")]
	private int DKCDNBPDPLO()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class AHKBIJEMLBD : CKPGCELNFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public JLJEDKKMHDF JNDOBDHNDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService AAPBAEGCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public MDBAAKNLHNI KPBEGLEDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public LHHIGECFLLB MPPDNOHMPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public MFMDMDGDHMO JCBGAMJMEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World BGENOIKENDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x2A667A0", Offset = "0x2A657A0", VA = "0x182A667A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public MDBAAKNLHNI DPFLAIIDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public AHKBIJEMLBD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[LMNMHFHDONH(IPKPBIMLPOB.PropertyChanges)]
	[DEJAKMDKDPE(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct GFLIHOBBBBM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly HKIFOHOEGHF PMCAGGDJBAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService KGAFOEANBBF;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x413F830", Offset = "0x413E830", VA = "0x18413F830")]
			public GFLIHOBBBBM(PropertyDiffStateService KGAFOEANBBF, HKIFOHOEGHF EFHOBNEHINK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x413F810", Offset = "0x413E810", VA = "0x18413F810", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly AHKBIJEMLBD HGLAEFBOOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly EIECINGNDLI[] JFPOOGFMDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private HKIFOHOEGHF PFILHJPCNNM;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public CKPGCELNFNM BHACAPPGJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public IEPINABNOFO GDGIAKPEFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x26FBE40", Offset = "0x26FAE40", VA = "0x1826FBE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public OKLEKHOLNCL CAFGCCINODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x26FBE40", Offset = "0x26FAE40", VA = "0x1826FBE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x848AF0", Offset = "0x847AF0", VA = "0x180848AF0")]
		public IEPINABNOFO HJEDPDBIHIP(HKIFOHOEGHF DCICIPKAADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x848AF0", Offset = "0x847AF0", VA = "0x180848AF0")]
		public OKLEKHOLNCL JADKLFBFLBE(HKIFOHOEGHF DCICIPKAADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x2988ED0", Offset = "0x2987ED0", VA = "0x182988ED0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x29888A0", Offset = "0x29878A0", VA = "0x1829888A0", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2988E50", Offset = "0x2987E50", VA = "0x182988E50")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x2988CA0", Offset = "0x2987CA0", VA = "0x182988CA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x2988EB0", Offset = "0x2987EB0", VA = "0x182988EB0")]
		public GFLIHOBBBBM FFMPIIONNCL(HKIFOHOEGHF DCICIPKAADP)
		{
			return default(GFLIHOBBBBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x2988FA0", Offset = "0x2987FA0", VA = "0x182988FA0")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(SceneService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	internal class SceneService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag HIADNPKDCON;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string CGBPNGMEGMD = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string JNKHOPAMGLB = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[GNFGKNINDPI]
		private AFNBNNKFHAD KFPILFJMBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[GNFGKNINDPI]
		private ObjectEmbodimentService NKDJGKIHEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[GNFGKNINDPI]
		private JNPKGPPKFAP COANALBPMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[GNFGKNINDPI]
		private SingletonComponentService GAKMHCOLFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery INEHDHCMPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery EKNGAEHGCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery NEANOJBHNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity NEPCMKIFBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool EEBOCCNLMLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x2B04C20", Offset = "0x2B03C20", VA = "0x182B04C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> MCBKADDNCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x123BA40", Offset = "0x123AA40", VA = "0x18123BA40")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x1BF70D0", Offset = "0x1BF60D0", VA = "0x181BF70D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity GCOBIHNJLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x2B04CA0", Offset = "0x2B03CA0", VA = "0x182B04CA0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag NAOBPLLCNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x2B04F20", Offset = "0x2B03F20", VA = "0x182B04F20")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity CGBFJIDFLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B04F20", Offset = "0x2B03F20", VA = "0x182B04F20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x2B04EB0", Offset = "0x2B03EB0", VA = "0x182B04EB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x2B04F70", Offset = "0x2B03F70", VA = "0x182B04F70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B50", Offset = "0x2B04B50", VA = "0x182B05B50", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x2B04DF0", Offset = "0x2B03DF0", VA = "0x182B04DF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E40", Offset = "0x2B03E40", VA = "0x182B04E40")]
		public void FAIFBKGANNA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C70", Offset = "0x2B03C70", VA = "0x182B04C70")]
		public NativeArray<Entity> DEJBNDNMIAB(Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B051D0", Offset = "0x2B041D0", VA = "0x182B051D0")]
		public void JBCFDECJIOI(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B05E60", Offset = "0x2B04E60", VA = "0x182B05E60")]
		public Entity PCDLDDIDMHM(string IADPDEAGFAB = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x2B049A0", Offset = "0x2B039A0", VA = "0x182B049A0")]
		public void BHGFLPNBMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x2B05E40", Offset = "0x2B04E40", VA = "0x182B05E40")]
		public void OFHLOHNGDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B05170", Offset = "0x2B04170", VA = "0x182B05170")]
		public void IILNOAFLELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04990", Offset = "0x2B03990", VA = "0x182B04990")]
		public void BCHHHHGFCIB(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B70", Offset = "0x2B03B70", VA = "0x182B04B70")]
		public bool CHMADMKFHMF(Entity PPJNHEBGICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E30", Offset = "0x2B03E30", VA = "0x182B04E30")]
		public void EGDFHNKHAFP(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C30", Offset = "0x2B04C30", VA = "0x182B05C30")]
		public string MPBBMFNKCLC(Entity PPJNHEBGICL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		public void FDGCKPEPFMG(Entity PPJNHEBGICL, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2B060C0", Offset = "0x2B050C0", VA = "0x182B060C0")]
		public bool PNLIFCMGBMD(string IADPDEAGFAB, out Entity PPJNHEBGICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A40", Offset = "0x2B04A40", VA = "0x182B05A40")]
		public void LGCCJADAOLA(Entity PPJNHEBGICL, bool MGCIKFODOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x2B06040", Offset = "0x2B05040", VA = "0x182B06040")]
		public void PIDNAOPPIJH(Entity IEFFOCOBJJI, bool FCELOHALIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x2B05FD0", Offset = "0x2B04FD0", VA = "0x182B05FD0")]
		public void PIDNAOPPIJH(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x2B05EE0", Offset = "0x2B04EE0", VA = "0x182B05EE0")]
		public void PIDNAOPPIJH(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x2B04760", Offset = "0x2B03760", VA = "0x182B04760")]
		public void AGDPBFCLLLJ(Entity IEFFOCOBJJI, Entity PPJNHEBGICL, bool FCELOHALIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x2B044D0", Offset = "0x2B034D0", VA = "0x182B044D0")]
		public void AGDPBFCLLLJ(NativeArray<Entity> BNEBECKGGLP, Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x2B046B0", Offset = "0x2B036B0", VA = "0x182B046B0")]
		public void AGDPBFCLLLJ(EntityQuery FBENFNFLPOM, Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x2B049C0", Offset = "0x2B039C0", VA = "0x182B049C0")]
		private void BJDACDAJAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E80", Offset = "0x2B03E80", VA = "0x182B04E80")]
		private void FECNKLMFCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CA0", Offset = "0x2B03CA0", VA = "0x182B04CA0")]
		private Entity DENBPMGFOMD()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2B05730", Offset = "0x2B04730", VA = "0x182B05730")]
		private void KKEOIFIMCKL(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2B055B0", Offset = "0x2B045B0", VA = "0x182B055B0")]
		private void JNELMMFBGED(EntityQuery HPJKJIMEHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2B052D0", Offset = "0x2B042D0", VA = "0x182B052D0")]
		private void JNELMMFBGED(NativeArray<Entity> MMKJPCINEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2B05680", Offset = "0x2B04680", VA = "0x182B05680")]
		private void JNJBAPKMHLB(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2B057E0", Offset = "0x2B047E0", VA = "0x182B057E0")]
		private void KOHKPCHKOCD(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2B05970", Offset = "0x2B04970", VA = "0x182B05970")]
		private void LBAKJFEFKOK(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2B05150", Offset = "0x2B04150", VA = "0x182B05150")]
		private void HIOAIAEPFAC(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FC0", Offset = "0x2B03FC0", VA = "0x182B04FC0")]
		private void HAAMFEJFMCH(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2B05DA0", Offset = "0x2B04DA0", VA = "0x182B05DA0")]
		private void NKADCNECGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3671A20", Offset = "0x3670A20", VA = "0x183671A20")]
		private void BDINBBPBCLK<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void AEFGDEMOBLH(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2B05D40", Offset = "0x2B04D40", VA = "0x182B05D40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NBBGBMDPIIP(EntityQuery FBENFNFLPOM, string IADPDEAGFAB, SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A10", Offset = "0x2B04A10", VA = "0x182B05A10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LBEJHFJOBOJ(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OFBMCHDHBIO(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[DEJAKMDKDPE(typeof(DNMOINOIHDI), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	[LGHOGGGGJFL(KHFGEOAKOKD.PhotonRoom)]
	internal class UnitySceneService : COMOMFINKHP, DNMOINOIHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[GNFGKNINDPI]
		private SceneService MMKJPCINEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> PIBKLLMLMGF;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x2B14640", Offset = "0x2B13640", VA = "0x182B14640")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2B14700", Offset = "0x2B13700", VA = "0x182B14700", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2B142E0", Offset = "0x2B132E0", VA = "0x182B142E0", Slot = "5")]
		public void FAIFBKGANNA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2B14450", Offset = "0x2B13450", VA = "0x182B14450", Slot = "6")]
		public bool FIHCIEBDFLE(PMFFIMLMCEJ GMOMNBJDADO, Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2B14690", Offset = "0x2B13690", VA = "0x182B14690")]
		private bool JBKHFMNAEHO(Scene PPJNHEBGICL, out Entity MOHJOPANEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2B14790", Offset = "0x2B13790", VA = "0x182B14790")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[LMNMHFHDONH(IPKPBIMLPOB.ComponentSystemTypes)]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[GNFGKNINDPI]
		private JNPKGPPKFAP COANALBPMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity IEFFOCOBJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private OANHHCFFOEG IHFNCPHANDK;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A8F0", Offset = "0x2B098F0", VA = "0x182B0A8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity HDJJNJMCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0AC70", Offset = "0x2B09C70", VA = "0x182B0AC70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3673350", Offset = "0x3672350", VA = "0x183673350")]
		public T CIGAFCHFFML<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3673410", Offset = "0x3672410", VA = "0x183673410")]
		public void FAFPJPFNCCD<T>(T DFEOJBAFBHE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AFC0", Offset = "0x2B09FC0", VA = "0x182B0AFC0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A750", Offset = "0x2B09750", VA = "0x182B0A750", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A750", Offset = "0x2B09750", VA = "0x182B0A750")]
		private void LOKMFKIGEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A9A0", Offset = "0x2B099A0", VA = "0x182B0A9A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ACC0", Offset = "0x2B09CC0", VA = "0x182B0ACC0")]
		private OANHHCFFOEG GKPEFFHHJOH()
		{
			return default(OANHHCFFOEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void JEGPKEJAKCF(int MIOCJKOOLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
		private static void KJBBABONHEK(Type IGEIBCJNCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A900", Offset = "0x2B09900", VA = "0x182B0A900")]
		private static void DIOBFOIHAOA(Type IGEIBCJNCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct IDCAEAIDFED : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[DEJAKMDKDPE(typeof(JLADNPOGKFE), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal sealed class JLADNPOGKFE : COMOMFINKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[GNFGKNINDPI]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::LIFNMLFFFJC<AFDFALAEGJP, Entity> GKHLMMKKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::JAGLGPBNCCL<AFOFKDAGIDG> HMCMFNKCGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::JAGLGPBNCCL<BLEMJGDAHGE> BMMANKBBMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::JAGLGPBNCCL<KMIOPDEBEGJ> BAFKMLPJEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::JAGLGPBNCCL<HKELBKNHIFA> JFMPCEMMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::JAGLGPBNCCL<NGNDDACDKHJ> ADDOLKFBKIO;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::LHGPJLBEMAO<Entity> BNGIBCOPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KGEAMOGNOJJ ECNJPOKIBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KGEAMOGNOJJ LIBOGJAGOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KGEAMOGNOJJ EGMMKIJEOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KGEAMOGNOJJ LGLGKHLFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x685570", Offset = "0x684570", VA = "0x180685570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KGEAMOGNOJJ ILCKBEJPNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x685580", Offset = "0x684580", VA = "0x180685580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2C6AB40", Offset = "0x2C69B40", VA = "0x182C6AB40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AB90", Offset = "0x2C69B90", VA = "0x182C6AB90", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AA50", Offset = "0x2C69A50", VA = "0x182C6AA50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x27AF9D0", Offset = "0x27AE9D0", VA = "0x1827AF9D0")]
	private void JGMOEBJPLEH<T>(ref global::JAGLGPBNCCL<T> BHBEGJLFINL) where T : struct, ADNHFABDAIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x27AF9D0", Offset = "0x27AE9D0", VA = "0x1827AF9D0")]
	private void JGMOEBJPLEH<TC, TV>(ref global::LIFNMLFFFJC<TC, TV> BHBEGJLFINL) where TC : struct, ADNHFABDAIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public JLADNPOGKFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[DEJAKMDKDPE(typeof(ADJFIMDIPEF), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
internal sealed class ADJFIMDIPEF : LGFONBKKNKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private OCGEMJOOKNP DGFDLMFNOCA;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public OCGEMJOOKNP KFOANNLIOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x2078CA0", Offset = "0x2077CA0", VA = "0x182078CA0")]
		get
		{
			return default(OCGEMJOOKNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x2A650F0", Offset = "0x2A640F0", VA = "0x182A650F0", Slot = "4")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x2A650E0", Offset = "0x2A640E0", VA = "0x182A650E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ADJFIMDIPEF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(TransformOwnershipPhase), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum BLPMHBGIGLO
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct FDNDAGFHDFE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private BLPMHBGIGLO EEDNFOIKMMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase ICMEPOIJCJO;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x413EA80", Offset = "0x413DA80", VA = "0x18413EA80")]
			public FDNDAGFHDFE(TransformOwnershipPhase ICMEPOIJCJO, BLPMHBGIGLO DCICIPKAADP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x413EA60", Offset = "0x413DA60", VA = "0x18413EA60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public BLPMHBGIGLO DCICIPKAADP;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public BLPMHBGIGLO ALDKBGKKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
			get
			{
				return default(BLPMHBGIGLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x69EF30", Offset = "0x69DF30", VA = "0x18069EF30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool LCAGCNDJMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xAE1960", Offset = "0xAE0960", VA = "0x180AE1960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool ABKMPPMFLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x12274A0", Offset = "0x12264A0", VA = "0x1812274A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E320", Offset = "0x2B0D320", VA = "0x182B0E320")]
		public FDNDAGFHDFE PPILHCOPBKG()
		{
			return default(FDNDAGFHDFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2F0", Offset = "0x2B0D2F0", VA = "0x182B0E2F0")]
		public FDNDAGFHDFE FGBFLAMNBKN()
		{
			return default(FDNDAGFHDFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[DEJAKMDKDPE(typeof(CPAGJJIMMGO), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Circuits)]
	public class CircuitsService : COMOMFINKHP, CPAGJJIMMGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[GNFGKNINDPI]
		private MFGAIDNJPNB ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager MKHPDCKNNBB;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ECE0", Offset = "0x2A6DCE0", VA = "0x182A6ECE0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E490", Offset = "0x2A6D490", VA = "0x182A6E490", Slot = "5")]
		public bool IJDODDJFFED(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EC10", Offset = "0x2A6DC10", VA = "0x182A6EC10", Slot = "7")]
		public Guid LPLCNJAAPMN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DFF0", Offset = "0x2A6CFF0", VA = "0x182A6DFF0", Slot = "8")]
		public void HJBPCFPJILK(PMFFIMLMCEJ GMOMNBJDADO, Guid GKKMLLNMKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EB40", Offset = "0x2A6DB40", VA = "0x182A6EB40", Slot = "9")]
		public Guid LGJIIEIOIIO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DD40", Offset = "0x2A6CD40", VA = "0x182A6DD40", Slot = "10")]
		public void BBOHCMJLLCH(PMFFIMLMCEJ GMOMNBJDADO, Guid DDCPNJANHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DFA0", Offset = "0x2A6CFA0", VA = "0x182A6DFA0", Slot = "11")]
		public bool BKGANEOPPAB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E420", Offset = "0x2A6D420", VA = "0x182A6E420", Slot = "12")]
		public void IEMICBDGJNA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E590", Offset = "0x2A6D590", VA = "0x182A6E590", Slot = "13")]
		public void JPJCGMLGEFA(PMFFIMLMCEJ IBCPLIFFFGK, PMFFIMLMCEJ ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ED80", Offset = "0x2A6DD80", VA = "0x182A6ED80")]
		private void POMOOCHKJEF(FBKIOBCBAGM KJBKDPLLBPK, PMFFIMLMCEJ ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E950", Offset = "0x2A6D950", VA = "0x182A6E950")]
		private void LBOAHCLJNPJ(FBKIOBCBAGM KJBKDPLLBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E250", Offset = "0x2A6D250", VA = "0x182A6E250")]
		private bool HOJKMIFGMGD(BDCNBKPMJEP GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DC90", Offset = "0x2A6CC90", VA = "0x182A6DC90")]
		private bool AHPJLCPCJEF(BDCNBKPMJEP GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EAE0", Offset = "0x2A6DAE0", VA = "0x182A6EAE0", Slot = "6")]
		public bool LGJFFFBKJIL(PMFFIMLMCEJ ALJACNMOIMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[LMNMHFHDONH(IPKPBIMLPOB.Connectables)]
	[DEJAKMDKDPE(typeof(DACMFIPKNDK), new string[] { })]
	internal class ConnectableService : DACMFIPKNDK, COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class LIMGMAJMLIA : IEnumerable<PMFFIMLMCEJ>, IEnumerable, IEnumerator<PMFFIMLMCEJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private PMFFIMLMCEJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private PMFFIMLMCEJ localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public PMFFIMLMCEJ <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private PMFFIMLMCEJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(PMFFIMLMCEJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x2B03510", Offset = "0x2B02510", VA = "0x182B03510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA51C0", VA = "0x181FA61C0")]
			[DebuggerHidden]
			public LIMGMAJMLIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2B03560", Offset = "0x2B02560", VA = "0x182B03560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x2B03120", Offset = "0x2B02120", VA = "0x182B03120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x2B03630", Offset = "0x2B02630", VA = "0x182B03630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x2B03680", Offset = "0x2B02680", VA = "0x182B03680")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x2B034D0", Offset = "0x2B024D0", VA = "0x182B034D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x2B03420", Offset = "0x2B02420", VA = "0x182B03420", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PMFFIMLMCEJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x2B03420", Offset = "0x2B02420", VA = "0x182B03420", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly FBNJDMKEPCN NAAAPINMHMI;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int HCCPGACGMKG = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int CBBEFHPBJIE = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private HJBNADOIEKJ AKKHHLBJIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private ALAPBINNPIH ACNDHAIKGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService CJDOJFJGMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::IBOLLEGFEDA<Entity> MODKBIMOIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::IBOLLEGFEDA<float3> ONNHHFOHAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::IBOLLEGFEDA<quaternion> GHIOPNFNJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::IBOLLEGFEDA<Entity> ICMEPOIJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::IBOLLEGFEDA<float3> CEKGMIFMNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::IBOLLEGFEDA<quaternion> OBFOOPGJBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> HPOODJODCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> IKNCBKMGMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery HHNNJENPEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool HJIBKFJJOMP;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<AKFIDAIPMLM> COEMJLAHNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x694750", Offset = "0x693750", VA = "0x180694750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x78FC50", Offset = "0x78EC50", VA = "0x18078FC50", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ> KHEHPEBECLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x2A73B60", Offset = "0x2A72B60", VA = "0x182A73B60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x2A74490", Offset = "0x2A73490", VA = "0x182A74490", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ> HDCDKKEOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x2A74900", Offset = "0x2A73900", VA = "0x182A74900", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x2A73F10", Offset = "0x2A72F10", VA = "0x182A73F10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ, PMFFIMLMCEJ> AOBHFDAFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x2A73E70", Offset = "0x2A72E70", VA = "0x182A73E70", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x2A74230", Offset = "0x2A73230", VA = "0x182A74230", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<PMFFIMLMCEJ> IKJBHGKCBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x2A74750", Offset = "0x2A73750", VA = "0x182A74750", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x2A735A0", Offset = "0x2A725A0", VA = "0x182A735A0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2A74530", Offset = "0x2A73530", VA = "0x182A74530", Slot = "25")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2A72E90", Offset = "0x2A71E90", VA = "0x182A72E90", Slot = "26")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2A73640", Offset = "0x2A72640", VA = "0x182A73640", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2A73C90", Offset = "0x2A72C90", VA = "0x182A73C90")]
		private void GJGJPMHDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2A737F0", Offset = "0x2A727F0", VA = "0x182A737F0")]
		private void ECFOGJHIMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2A742D0", Offset = "0x2A732D0", VA = "0x182A742D0")]
		private void LIFEDEIOPMO(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2A747F0", Offset = "0x2A737F0", VA = "0x182A747F0")]
		private void OPNECLNJDDG(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1E589E0", Offset = "0x1E579E0", VA = "0x181E589E0", Slot = "14")]
		public PMFFIMLMCEJ NDAKBMDKHPJ(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x134C0F0", Offset = "0x134B0F0", VA = "0x18134C0F0", Slot = "15")]
		public Color OHIAIIOJMAB(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2A73330", Offset = "0x2A72330", VA = "0x182A73330", Slot = "16")]
		public float3 CCAKFCNADGN(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2A74850", Offset = "0x2A73850", VA = "0x182A74850", Slot = "17")]
		public bool PEFMDIEBKFL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ GMANPLBBDPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2A73AB0", Offset = "0x2A72AB0", VA = "0x182A73AB0", Slot = "18")]
		public PMFFIMLMCEJ EHHPCCNKBGC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2A73960", Offset = "0x2A72960", VA = "0x182A73960", Slot = "21")]
		public void EDCMGEGFKLI(PMFFIMLMCEJ GMOMNBJDADO, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2A746B0", Offset = "0x2A736B0", VA = "0x182A746B0", Slot = "23")]
		public float3 MOPNALDCMEC(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2A73C00", Offset = "0x2A72C00", VA = "0x182A73C00", Slot = "24")]
		public quaternion GFHOBBALCOM(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x2A72BC0", Offset = "0x2A71BC0", VA = "0x182A72BC0", Slot = "28")]
		public RigidTransform BDOOIJKNLLO(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x2A73CF0", Offset = "0x2A72CF0", VA = "0x182A73CF0", Slot = "22")]
		public bool HOJJGBLMLJD(PMFFIMLMCEJ GMOMNBJDADO, out RigidTransform EIAPPNLJHEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x2A73510", Offset = "0x2A72510", VA = "0x182A73510", Slot = "19")]
		[IteratorStateMachine(typeof(LIMGMAJMLIA))]
		public IEnumerable<PMFFIMLMCEJ> CFAKAHJEKLJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2A740D0", Offset = "0x2A730D0", VA = "0x182A740D0", Slot = "20")]
		public PMFFIMLMCEJ KOIEJHABPCD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2A72CC0", Offset = "0x2A71CC0", VA = "0x182A72CC0", Slot = "29")]
		public void BGOPIGFMNMF(ref List<PMFFIMLMCEJ> HCIALCFLHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2A73FB0", Offset = "0x2A72FB0", VA = "0x182A73FB0")]
		private Entity KOIEJHABPCD(Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2A74A30", Offset = "0x2A73A30", VA = "0x182A74A30")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	[DEJAKMDKDPE(typeof(ObjectInstantiationService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Prefabs)]
	internal sealed class ObjectInstantiationService : COMOMFINKHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF GLPDAIBKGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[GNFGKNINDPI]
		private NPLLEAPJFIF MGNIOBGCAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[GNFGKNINDPI]
		private GDKIDCILBBI IEOPDHOGHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[GNFGKNINDPI]
		private ObjectNetworkToLocalMapService LEAPKBHNHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[GNFGKNINDPI]
		private ObjectLifecycleService FHPIBOEMPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[GNFGKNINDPI]
		private ObjectPrefabs AAPBAEGCALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[GNFGKNINDPI]
		private HEADBEHLNDI DCEPJPPIPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private FPOMEGCHHAA NPMFOILJLDI;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int LHNLIMDPDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x2978640", Offset = "0x2977640", VA = "0x182978640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x29788A0", Offset = "0x29778A0", VA = "0x1829788A0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x2978690", Offset = "0x2977690", VA = "0x182978690")]
		public Entity INDBOJHFAIL(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x29783F0", Offset = "0x29773F0", VA = "0x1829783F0")]
		public Entity DDBABLLMGCD(AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x29783A0", Offset = "0x29773A0", VA = "0x1829783A0")]
		public Entity CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2978360", Offset = "0x2977360", VA = "0x182978360")]
		public Entity CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x29787D0", Offset = "0x29777D0", VA = "0x1829787D0")]
		public Entity KMAEBAOIOFC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2978810", Offset = "0x2977810", VA = "0x182978810")]
		public Entity MLJMHNFKMOG(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x29785B0", Offset = "0x29775B0", VA = "0x1829785B0")]
		public Entity FGEKKLAKOKM(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2978510", Offset = "0x2977510", VA = "0x182978510")]
		public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2978560", Offset = "0x2977560", VA = "0x182978560")]
		public IEnumerable<PEMKGMKGDAH> FEAMMEKINDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2978450", Offset = "0x2977450", VA = "0x182978450")]
		public EntityArchetype DGAGOIDBGAD(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x29784B0", Offset = "0x29774B0", VA = "0x1829784B0")]
		public Entity EHKNDPLJDHA(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2978360", Offset = "0x2977360", VA = "0x182978360")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x29783A0", Offset = "0x29773A0", VA = "0x1829783A0")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x29786B0", Offset = "0x29776B0", VA = "0x1829786B0")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH, AIELFMMICMN CDEOFEMHEEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[LMNMHFHDONH(IPKPBIMLPOB.Physics)]
	[DEJAKMDKDPE(typeof(JEGLAIMIPKC), new string[] { })]
	public sealed class PhysicsSceneColliderService : JEGLAIMIPKC, JKBMOIGEDEI, LGFONBKKNKN, COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string MFEHCFPNAMA = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int MJKANMPFLNI = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int HBHIGPPNBID = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[GNFGKNINDPI]
		private HBFLPONDKFF OLPNBPCMPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] CBCDEBGCKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] NCMPOGBKCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::AOPGFFKJFJG<FGLBLDPHAAD, BoxCollider> MIDBJELODPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene PPJNHEBGICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene NANOELFAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject GLJOCEFKOFB;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int IHFHODCNOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2982C30", Offset = "0x2981C30", VA = "0x182982C30", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x2983060", Offset = "0x2982060", VA = "0x182983060", Slot = "9")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x2982F00", Offset = "0x2981F00", VA = "0x182982F00", Slot = "10")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x2982310", Offset = "0x2981310", VA = "0x182982310", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2982970", Offset = "0x2981970", VA = "0x182982970", Slot = "4")]
		public FGLBLDPHAAD IECDPFAFKKE(Entity IEFFOCOBJJI)
		{
			return default(FGLBLDPHAAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x2982C70", Offset = "0x2981C70", VA = "0x182982C70", Slot = "5")]
		public void KJMPEKBEAAD(NativeArray<FGLBLDPHAAD> ANAONBGCBEJ, NativeArray<CFIMDNLGMOJ> HJIDIDOFHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x29820A0", Offset = "0x29810A0", VA = "0x1829820A0", Slot = "6")]
		public void ALEEAKBECHD(FGLBLDPHAAD DCLMHANFEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x2982FC0", Offset = "0x2981FC0", VA = "0x182982FC0", Slot = "7")]
		public bool OJLLAOEBLPB(FGLBLDPHAAD DCLMHANFEGK, out Collider AMDPNFGBEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x2982660", Offset = "0x2981660", VA = "0x182982660")]
		public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x2982AC0", Offset = "0x2981AC0", VA = "0x182982AC0")]
		private void ILDOJDHDCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xBA1B40", Offset = "0xBA0B40", VA = "0x180BA1B40")]
		private void PBGPPFBEHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x29831D0", Offset = "0x29821D0", VA = "0x1829831D0")]
		private void PGDAHOHKALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x1E97760", Offset = "0x1E96760", VA = "0x181E97760")]
		private void IOAMGOFJOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2982B10", Offset = "0x2981B10", VA = "0x182982B10")]
		private BoxCollider JPJJNPDDEMB(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2982170", Offset = "0x2981170", VA = "0x182982170")]
		private void CGLFLBHJFGP(BoxCollider PCKKLDIHMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2982E80", Offset = "0x2981E80", VA = "0x182982E80")]
		[Conditional("UNITY_EDITOR")]
		private void MEGALPCGMGC(GameObject NCAOMIEGHPA, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2983220", Offset = "0x2982220", VA = "0x182983220")]
		private void PNFNAMDJOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x29821F0", Offset = "0x29811F0", VA = "0x1829821F0")]
		private void DCCKICEHFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2982410", Offset = "0x2981410", VA = "0x182982410")]
		private void EIDKGHGLBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2982620", Offset = "0x2981620", VA = "0x182982620")]
		private void FAENLEHPIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2982300", Offset = "0x2981300", VA = "0x182982300")]
		private void DPEDFIJKFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2982EC0", Offset = "0x2981EC0", VA = "0x182982EC0")]
		private void MHPHFOFFLBI(Scene KKMHBLHDEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2982650", Offset = "0x2981650", VA = "0x182982650", Slot = "8")]
		private bool GMOJELGNNMN(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[DEJAKMDKDPE(typeof(MJGMCJFCPCM), new string[] { })]
public sealed class LJLMGMKKJDM : MJGMCJFCPCM, COMOMFINKHP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct OOGNFCLDDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float ENHNHFJMKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint GNFKHCJLCKF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private JKBMOIGEDEI OOPBEMOONNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private AGCIOABNBOD DABNEFKAJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2C71600", Offset = "0x2C70600", VA = "0x182C71600", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2C71180", Offset = "0x2C70180", VA = "0x182C71180")]
	public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, out GJJLCPLKMOF MLHEJPEMPIL, out Entity FCDBIEPFJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2C71670", Offset = "0x2C70670", VA = "0x182C71670")]
	public static bool NFELNFGCMKM(in Span<GJJLCPLKMOF> JIFPJBCIHDM, float JFMOIJLKEGH, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2C71150", Offset = "0x2C70150", VA = "0x182C71150")]
	public static float CMGIIPLEMCM(float ENHNHFJMKPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public LJLMGMKKJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2C71770", Offset = "0x2C70770", VA = "0x182C71770", Slot = "4")]
	private bool PIEKIFAEKGF(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, out GJJLCPLKMOF MLHEJPEMPIL, out Entity FCDBIEPFJBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[DEJAKMDKDPE(typeof(AGCIOABNBOD), new string[] { })]
public sealed class EKCJLPGJJOO : AGCIOABNBOD, COMOMFINKHP
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct KLBEPNMADHP : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> BNEBECKGGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 DFCNCKFBNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 BAFBOHPOHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GKOLIMCAHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> NEOLDIKHLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MBMGBKDNPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> PCFHMLBOMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> JKMNFJHBCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<GJJLCPLKMOF> PGGDAEIGHOI;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly GJJLCPLKMOF AKHFAJLIHDI;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B019E0", Offset = "0x2B009E0", VA = "0x182B019E0", Slot = "4")]
		public void Execute(int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B022D0", Offset = "0x2B012D0", VA = "0x182B022D0")]
		private static float3 KPGPKAPBJHG(in float4x4 GJGNOLNHHHL, in float3 ONINKGDNEEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x2B01DC0", Offset = "0x2B00DC0", VA = "0x182B01DC0")]
		private static float3 GFFAOJODAAP(in float4x4 GJGNOLNHHHL, in float3 LNMAPJNBGLF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B01CC0", Offset = "0x2B00CC0", VA = "0x182B01CC0")]
		private static float3 FMPDIJAMFPB(in float4x4 GJGNOLNHHHL, in float3 ONINKGDNEEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x2B017C0", Offset = "0x2B007C0", VA = "0x182B017C0")]
		private static float3 BENNPJENLPE(in float4x4 GJGNOLNHHHL, in float3 LNMAPJNBGLF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B01F80", Offset = "0x2B00F80", VA = "0x182B01F80")]
		private bool JJCCPKLBFGF(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, in NativeArray<Entity> CFCHICCPODI, out float3 MLHEJPEMPIL, out float3 FEMBJLJDLPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2B023A0", Offset = "0x2B013A0", VA = "0x182B023A0")]
		public static bool LEKMHCLEFJA(in float3 CBFFHAOEBOM, in float3 EPCIEIJKPMH, in float3 JFGMAFEPGME, in float3 MODBHGKBMHD, float MIKFOOFEIMF, float IJCOEPFDNAB, out float PHLICBNKKOO, out float3 HOHFMJFIEBG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x2A810A0", Offset = "0x2A800A0", VA = "0x182A810A0", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x2A80BB0", Offset = "0x2A7FBB0", VA = "0x182A80BB0")]
	public void HFCCBFOEMBC(in NativeArray<Entity> BNEBECKGGLP, in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, in NativeArray<GJJLCPLKMOF> GEGOKFDMMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public EKCJLPGJJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x2A81090", Offset = "0x2A80090", VA = "0x182A81090", Slot = "4")]
	private void MAIHEFKHCEO(in NativeArray<Entity> BNEBECKGGLP, in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, in NativeArray<GJJLCPLKMOF> GEGOKFDMMFH)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[DEJAKMDKDPE(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[LMNMHFHDONH(IPKPBIMLPOB.Embodiment)]
	[LGHOGGGGJFL(KHFGEOAKOKD.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[GNFGKNINDPI]
		private NPLLEAPJFIF JHNMFCDLEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[GNFGKNINDPI]
		private GDKIDCILBBI AFEKIMHCKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private JEAKCMCJOBO NAANBDEGGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<AIELFMMICMN, Entity> BINMNODCIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager MKHPDCKNNBB;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<AIELFMMICMN, Entity> IPFAAKLMDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xF5F980", Offset = "0xF5E980", VA = "0x180F5F980")]
			get
			{
				return default(NativeHashMap<AIELFMMICMN, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint HPEACKKAJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x297BC20", Offset = "0x297AC20", VA = "0x18297BC20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool NMMHNMGCMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x80C460", Offset = "0x80B460", VA = "0x18080C460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0xC7C080", Offset = "0xC7B080", VA = "0x180C7C080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x297BAD0", Offset = "0x297AAD0", VA = "0x18297BAD0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x297B880", Offset = "0x297A880", VA = "0x18297B880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x297B8F0", Offset = "0x297A8F0", VA = "0x18297B8F0")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x297BC50", Offset = "0x297AC50", VA = "0x18297BC50")]
		public void OOAHHCOJLHM(AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x297BBF0", Offset = "0x297ABF0", VA = "0x18297BBF0")]
		private PMFFIMLMCEJ OGPGFBOCGBO(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x297B650", Offset = "0x297A650", VA = "0x18297B650")]
		public PMFFIMLMCEJ ABIIJDLPNOE(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x297B730", Offset = "0x297A730", VA = "0x18297B730")]
		public AIELFMMICMN CIDLEEFEFNC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(AIELFMMICMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x297B970", Offset = "0x297A970", VA = "0x18297B970")]
		public void GIIFDIMJIKJ(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x297B820", Offset = "0x297A820", VA = "0x18297B820")]
		public void DNDDENNMNJF(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x297B7C0", Offset = "0x297A7C0", VA = "0x18297B7C0")]
		public void CKIBNCNGNFL(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x297BA00", Offset = "0x297AA00", VA = "0x18297BA00")]
		public void LLHJEKFKFEG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[DEJAKMDKDPE(typeof(PropertyEventCallbacksService), new string[] { })]
	[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
	[LMNMHFHDONH(IPKPBIMLPOB.Callbacks)]
	public class PropertyEventCallbacksService : COMOMFINKHP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct NPGPDJOLJIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public CAGCNOEEMMG KDDLOKAHKOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type IGEIBCJNCHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int BDHBBDMMOKG;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct OBMHKHBNGLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public NPGPDJOLJIL[] JDJBDCDEPOJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void CAGCNOEEMMG(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<OEMFGOLGDMG, CAGCNOEEMMG> MLHHKMEKOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, OBMHKHBNGLF> NPLNBENFHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private OEKGHEEACHJ JDJBDCDEPOJ;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action AIPEHAFPLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x2989800", Offset = "0x2988800", VA = "0x182989800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x298A130", Offset = "0x2989130", VA = "0x18298A130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action IMLDCPJFCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x2989040", Offset = "0x2988040", VA = "0x182989040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x2989F20", Offset = "0x2988F20", VA = "0x182989F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x2989ED0", Offset = "0x2988ED0", VA = "0x182989ED0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x2989370", Offset = "0x2988370", VA = "0x182989370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x2989FC0", Offset = "0x2988FC0", VA = "0x182989FC0")]
		public void MNFGPLMIANE(OEMFGOLGDMG DLFEJOALJGM, CAGCNOEEMMG KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x29898A0", Offset = "0x29888A0", VA = "0x1829898A0")]
		public void MFJOMNDPBAP(OEMFGOLGDMG DLFEJOALJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x29890E0", Offset = "0x29880E0", VA = "0x1829890E0")]
		internal void DHLPKFNGLCM(IEPINABNOFO IDIIBDOHICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x2989990", Offset = "0x2988990", VA = "0x182989990")]
		private void MIJFKMEGMJN(IEPINABNOFO IDIIBDOHICE, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x2989580", Offset = "0x2988580", VA = "0x182989580")]
		private void GNJMKLKNGHG(ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM, NPGPDJOLJIL FJNIFBKOEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x2989400", Offset = "0x2988400", VA = "0x182989400")]
		private OBMHKHBNGLF GMHJMJOAPGF(ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM)
		{
			return default(OBMHKHBNGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x298A1D0", Offset = "0x29891D0", VA = "0x18298A1D0")]
		private NPGPDJOLJIL PIIGEKDIIOC(OBMHKHBNGLF ECGOBGEIPCF, ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM)
		{
			return default(NPGPDJOLJIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x298A310", Offset = "0x2989310", VA = "0x18298A310")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[DEJAKMDKDPE(typeof(LAEEMBKBPLL), new string[] { })]
public class NJJIJOKGKGN : COMOMFINKHP, BDDJKMOFDGN, LAEEMBKBPLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class PHJJKCPCNLM : IEnumerable<PMFFIMLMCEJ>, IEnumerable, IEnumerator<PMFFIMLMCEJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private PMFFIMLMCEJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public NJJIJOKGKGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private PMFFIMLMCEJ splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public PMFFIMLMCEJ <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private PMFFIMLMCEJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x4146430", Offset = "0x4145430", VA = "0x184146430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA51C0", VA = "0x181FA61C0")]
		[DebuggerHidden]
		public PHJJKCPCNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x4146280", Offset = "0x4145280", VA = "0x184146280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x41463F0", Offset = "0x41453F0", VA = "0x1841463F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x4146340", Offset = "0x4145340", VA = "0x184146340", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMFFIMLMCEJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x4146340", Offset = "0x4145340", VA = "0x184146340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private JEAKCMCJOBO NAANBDEGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private AOKKKKFKIPA HFCPKJJACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService AAPBAEGCALL;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2972180", Offset = "0x2971180", VA = "0x182972180")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private CGJFLAGLGMG GBGKPEOJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2972730", Offset = "0x2971730", VA = "0x182972730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x29726A0", Offset = "0x29716A0", VA = "0x1829726A0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2971D00", Offset = "0x2970D00", VA = "0x182971D00", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2971EC0", Offset = "0x2970EC0", VA = "0x182971EC0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2972890", Offset = "0x2971890", VA = "0x182972890")]
	private void NNLLFDMMCFO(Entity LJMJHEJCGON, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x29724F0", Offset = "0x29714F0", VA = "0x1829724F0", Slot = "14")]
	public PMFFIMLMCEJ KMAEBAOIOFC()
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2971E00", Offset = "0x2970E00", VA = "0x182971E00", Slot = "10")]
	public void CFOLGKJEIBA(PMFFIMLMCEJ GMOMNBJDADO, NDMIFLOOPHF FHLNMMPFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x29720C0", Offset = "0x29710C0", VA = "0x1829720C0", Slot = "9")]
	public NDMIFLOOPHF GCKNPNBEFPA(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(NDMIFLOOPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x29721D0", Offset = "0x29711D0", VA = "0x1829721D0", Slot = "11")]
	public PMFFIMLMCEJ JHFAFONMIJE(PMFFIMLMCEJ CJCOOPPJGHI, [Optional] Vector3? IJBELJOFGFA, [Optional] Quaternion? EIGPDNIOAKK, [Optional] Vector3? LAKBNONGKOL)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2972660", Offset = "0x2971660", VA = "0x182972660", Slot = "15")]
	public PMFFIMLMCEJ MFHODAMJOAH(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK, [Optional] Vector3? IJBELJOFGFA, [Optional] Quaternion? EIGPDNIOAKK, [Optional] Vector3? LAKBNONGKOL)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2972570", Offset = "0x2971570", VA = "0x182972570", Slot = "7")]
	public PMFFIMLMCEJ LIFGBGDNNEF(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2972CB0", Offset = "0x2971CB0", VA = "0x182972CB0", Slot = "16")]
	public void PAHIHDCEADN(PMFFIMLMCEJ LHDCFFBCJLG, PMFFIMLMCEJ KBGCHGICHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2971B60", Offset = "0x2970B60", VA = "0x182971B60", Slot = "12")]
	public void BIJHKBDOELI(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2972B10", Offset = "0x2971B10", VA = "0x182972B10", Slot = "17")]
	public void NOEJMGPDKMA(PMFFIMLMCEJ LHDCFFBCJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x29727F0", Offset = "0x29717F0", VA = "0x1829727F0", Slot = "8")]
	public int NMDCOKGEBPA(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2972D70", Offset = "0x2971D70", VA = "0x182972D70", Slot = "6")]
	[IteratorStateMachine(typeof(PHJJKCPCNLM))]
	public IEnumerable<PMFFIMLMCEJ> PPOGLGAEIDH(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2971F70", Offset = "0x2970F70", VA = "0x182971F70")]
	private bool EGHELBBFBGL(PMFFIMLMCEJ LHDCFFBCJLG, out NativeArray<Entity> MIHJGHDPEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x2972000", Offset = "0x2971000", VA = "0x182972000")]
	private NativeArray<Entity> EKDMDJJLMAF(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public NJJIJOKGKGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[DEJAKMDKDPE(typeof(CMGLJGJIAFN), new string[] { })]
[LGHOGGGGJFL(KHFGEOAKOKD.LoadInstance)]
internal sealed class CMGLJGJIAFN : COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private JLJEDKKMHDF GLPDAIBKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase KMANEIOAPIA;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private AHBEEJODFBD MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D430", Offset = "0x2A6C430", VA = "0x182A6D430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D3B0", Offset = "0x2A6C3B0", VA = "0x182A6D3B0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D2C0", Offset = "0x2A6C2C0", VA = "0x182A6D2C0")]
	public void LDENHAGOCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFF0", Offset = "0x2A6BFF0", VA = "0x182A6CFF0")]
	public void IIAMNLKNDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public CMGLJGJIAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct FHDMIGGLNFL : IEquatable<FHDMIGGLNFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int CNNKHGOHIDH;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2C59B30", Offset = "0x2C58B30", VA = "0x182C59B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2C59D40", Offset = "0x2C58D40", VA = "0x182C59D40")]
	public FHDMIGGLNFL(Type IGEIBCJNCHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2C59C60", Offset = "0x2C58C60", VA = "0x182C59C60")]
	public static FHDMIGGLNFL LFOOIECCIPM(Type IGEIBCJNCHF)
	{
		return default(FHDMIGGLNFL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2C59C10", Offset = "0x2C58C10", VA = "0x182C59C10")]
	public static Type LFOOIECCIPM(FHDMIGGLNFL DCLMHANFEGK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0xEC6260", Offset = "0xEC5260", VA = "0x180EC6260")]
	public static bool FHCNBCDBOFI(FHDMIGGLNFL NCNGLFNLPAG, FHDMIGGLNFL OPGAGDBKIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0xEC6260", Offset = "0xEC5260", VA = "0x180EC6260")]
	public static bool LIEIJOJMABA(FHDMIGGLNFL NCNGLFNLPAG, FHDMIGGLNFL OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x8221E0", Offset = "0x8211E0", VA = "0x1808221E0", Slot = "4")]
	public bool Equals(FHDMIGGLNFL KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2C59B90", Offset = "0x2C58B90", VA = "0x182C59B90", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x72FE20", Offset = "0x72EE20", VA = "0x18072FE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2C59CC0", Offset = "0x2C58CC0", VA = "0x182C59CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class CILJPAMKPOD
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> OGNHPCDCONK;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> AKOPLNBNICF;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CB60", Offset = "0x2A6BB60", VA = "0x182A6CB60")]
	static CILJPAMKPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x22E4CF0", Offset = "0x22E3CF0", VA = "0x1822E4CF0")]
	public static bool HMNAIPBHJIK<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C930", Offset = "0x2A6B930", VA = "0x182A6C930")]
	public static bool HMNAIPBHJIK(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C7C0", Offset = "0x2A6B7C0", VA = "0x182A6C7C0")]
	private static bool HMNAIPBHJIK(Type IGEIBCJNCHF, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x22E4C60", Offset = "0x22E3C60", VA = "0x1822E4C60")]
	public static int FEAMCPOBIKK<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C750", Offset = "0x2A6B750", VA = "0x182A6C750")]
	public static int FEAMCPOBIKK(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x22E4D80", Offset = "0x22E3D80", VA = "0x1822E4D80")]
	public static bool MDMOKHFDALA<T>(out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C9A0", Offset = "0x2A6B9A0", VA = "0x182A6C9A0")]
	public static bool MDMOKHFDALA(Type IGEIBCJNCHF, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C6B0", Offset = "0x2A6B6B0", VA = "0x182A6C6B0")]
	public static Type CIGAFCHFFML(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CA40", Offset = "0x2A6BA40", VA = "0x182A6CA40")]
	public static bool MDMOKHFDALA(int NPDGHPHAKDK, out Type IGEIBCJNCHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct BCHFKABCHJB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] FILAKGLBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int MFAHIHFAKKH;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x77D5E0", Offset = "0x77C5E0", VA = "0x18077D5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x1E22E40", Offset = "0x1E21E40", VA = "0x181E22E40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> ENIJEODOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x374FBA0", Offset = "0x374EBA0", VA = "0x18374FBA0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x8A0280", Offset = "0x89F280", VA = "0x1808A0280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x374FDB0", Offset = "0x374EDB0", VA = "0x18374FDB0")]
	public BCHFKABCHJB(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x374FD00", Offset = "0x374ED00", VA = "0x18374FD00")]
	public int FIGLOCELEJH(T DFEOJBAFBHE, int FHGIIAKFJFF, int MIOCJKOOLBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x374FC40", Offset = "0x374EC40", VA = "0x18374FC40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct BEAOGGJJKMN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::BCHFKABCHJB<T> FILAKGLBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int MFAHIHFAKKH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x37578C0", Offset = "0x37568C0", VA = "0x1837578C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x3758D80", Offset = "0x3757D80", VA = "0x183758D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x37573A0", Offset = "0x37563A0", VA = "0x1837573A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x3758DD0", Offset = "0x3757DD0", VA = "0x183758DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x3758E90", Offset = "0x3757E90", VA = "0x183758E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> ENIJEODOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x3757720", Offset = "0x3756720", VA = "0x183757720")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x3758FB0", Offset = "0x3757FB0", VA = "0x183758FB0")]
	public BEAOGGJJKMN(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x37585C0", Offset = "0x37575C0", VA = "0x1837585C0")]
	public T HNNONCAKBHI(int NPDGHPHAKDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x3758EC0", Offset = "0x3757EC0", VA = "0x183758EC0")]
	public void PMMNFCJNHJH(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x3758950", Offset = "0x3757950", VA = "0x183758950")]
	public void JPFMAFBCANN(Span<T> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x37584A0", Offset = "0x37574A0", VA = "0x1837584A0")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x3757EE0", Offset = "0x3756EE0", VA = "0x183757EE0")]
	private void GHGEHDFNFCM(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x3757430", Offset = "0x3756430", VA = "0x183757430")]
	public void BMDGMDNJPHD(Span<T> FKFMFNKJNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x37573D0", Offset = "0x37563D0", VA = "0x1837573D0")]
	public void BKLAMEDJEPA(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x37581A0", Offset = "0x37571A0", VA = "0x1837581A0")]
	public void HENDNLGJJNI(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x37576C0", Offset = "0x37566C0", VA = "0x1837576C0")]
	public void CCGFPBPKEDH(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x3758AF0", Offset = "0x3757AF0", VA = "0x183758AF0")]
	public void KLGOEMEOLCH(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3757AF0", Offset = "0x3756AF0", VA = "0x183757AF0")]
	public void FCEDBOOKGLB(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x37580E0", Offset = "0x37570E0", VA = "0x1837580E0")]
	public void GLODPDIONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x3757BB0", Offset = "0x3756BB0", VA = "0x183757BB0")]
	public int FIGLOCELEJH(T DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x3758440", Offset = "0x3757440", VA = "0x183758440")]
	public bool HGEFFBLNLHD(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x3757AA0", Offset = "0x3756AA0", VA = "0x183757AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x3758F40", Offset = "0x3757F40", VA = "0x183758F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x3758E20", Offset = "0x3757E20", VA = "0x183758E20")]
	public static Span<T> LFOOIECCIPM(global::BEAOGGJJKMN<T> DEEJEKFIHBB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x3757C40", Offset = "0x3756C40", VA = "0x183757C40")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FLAKGEDNEGO(int DFEOJBAFBHE, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GDOJDFFNHEH(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x3757D80", Offset = "0x3756D80", VA = "0x183757D80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GDOJDFFNHEH(int MFAHIHFAKKH, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x3757960", Offset = "0x3756960", VA = "0x183757960")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DMGKIPGOGOE(int DFEOJBAFBHE, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x3758750", Offset = "0x3757750", VA = "0x183758750")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JBKLPJCGCAC(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x3758610", Offset = "0x3757610", VA = "0x183758610")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void IPOFOFDCDIF(int DFEOJBAFBHE, int MFAHIHFAKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct OCGEMJOOKNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int FPPAJOINBAB = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> BNEBECKGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray AKKHHLBJIJB;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x29734E0", Offset = "0x29724E0", VA = "0x1829734E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> CMBIEGLMGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xBCFE30", Offset = "0xBCEE30", VA = "0x180BCFE30")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray BDFIMOGPJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x2973690", Offset = "0x2972690", VA = "0x182973690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x2973750", Offset = "0x2972750", VA = "0x182973750")]
	public OCGEMJOOKNP(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2973570", Offset = "0x2972570", VA = "0x182973570")]
	public Entity FKEODMAICIA(int NPDGHPHAKDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2973700", Offset = "0x2972700", VA = "0x182973700")]
	public Transform NHDJANMKOLL(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x29736B0", Offset = "0x29726B0", VA = "0x1829736B0")]
	public void MPKFKNPIPHJ(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x29735C0", Offset = "0x29725C0", VA = "0x1829735C0")]
	public int HMNAIPBHJIK(Transform FLCFNMLPAML, Entity IEFFOCOBJJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2973460", Offset = "0x2972460", VA = "0x182973460")]
	public int BKLAMEDJEPA(int NPDGHPHAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x29734F0", Offset = "0x29724F0", VA = "0x1829734F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2973710", Offset = "0x2972710", VA = "0x182973710")]
	private void PIOBFJDCKOF(int IEGDCAKJBPN = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class IANBFBPDFBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<FHDMIGGLNFL, int2> IELBDOPCHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> FAHBHODOFIG;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x2C66B60", Offset = "0x2C65B60", VA = "0x182C66B60")]
	public IANBFBPDFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2C666B0", Offset = "0x2C656B0", VA = "0x182C666B0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void FAFPJPFNCCD<T>(T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T CIGAFCHFFML<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x2C66710", Offset = "0x2C65710", VA = "0x182C66710")]
	public void FAFPJPFNCCD(Type IGEIBCJNCHF, PEKIEJLMCEO DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2C66270", Offset = "0x2C65270", VA = "0x182C66270")]
	public PEKIEJLMCEO CIGAFCHFFML(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2C66AC0", Offset = "0x2C65AC0", VA = "0x182C66AC0")]
	private NativeArray<byte> KPJAFBEEOCO(int2 BOLOJDIFGHI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2C66610", Offset = "0x2C65610", VA = "0x182C66610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2C669A0", Offset = "0x2C659A0", VA = "0x182C669A0", Slot = "1")]
	~IANBFBPDFBP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct CEGCCDMDLHF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::CEGCCDMDLHF<T> LFOOIECCIPM(T DFEOJBAFBHE)
	{
		return default(global::CEGCCDMDLHF<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T LFOOIECCIPM(global::CEGCCDMDLHF<T> PGBDPKDFJME)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class PKFNBHAIMDE
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly IANBFBPDFBP IDLDHPKMMJB;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x2981200", Offset = "0x2980200", VA = "0x182981200")]
	internal static void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void FAFPJPFNCCD<T>(T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2981270", Offset = "0x2980270", VA = "0x182981270")]
	public static void FAFPJPFNCCD(Type IGEIBCJNCHF, PEKIEJLMCEO DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T CIGAFCHFFML<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x2981160", Offset = "0x2980160", VA = "0x182981160")]
	public static PEKIEJLMCEO CIGAFCHFFML(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class KCLEABANIKJ : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly KCLEABANIKJ DCLACCPOJAP;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CC30", Offset = "0x2C6BC30", VA = "0x182C6CC30", Slot = "4")]
	public bool Equals(LinkedEntityGroup JMDPDGBMGAA, LinkedEntityGroup GKDCJKNJEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CC50", Offset = "0x2C6BC50", VA = "0x182C6CC50", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup GKCPJCKCENH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KCLEABANIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class IDNOIKOIDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HFJDJHLNAJI(in Vector3 IJBELJOFGFA, in Quaternion EIGPDNIOAKK, in Vector3 LAKBNONGKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void APGHJIMINCH(in Vector3 MJLFONEIMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GHNOMDJEOGM(in Quaternion EIGPDNIOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HJJCOOIHHED(in Vector3 BCDKADPIFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JFMPIHILMMC(in Vector3 BCDKADPIFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void CDDGCDOFCAB(in float BGPEGNJCNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2C66D00", Offset = "0x2C65D00", VA = "0x182C66D00")]
	[Conditional("DEBUG_BUILD")]
	public static void NAAFGEEEJEH(in float3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in float DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x2C66C00", Offset = "0x2C65C00", VA = "0x182C66C00")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in Vector3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2C66C50", Offset = "0x2C65C50", VA = "0x182C66C50")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in Quaternion DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2C66CF0", Offset = "0x2C65CF0", VA = "0x182C66CF0")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in float DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2C66CB0", Offset = "0x2C65CB0", VA = "0x182C66CB0")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in Vector3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2C66C80", Offset = "0x2C65C80", VA = "0x182C66C80")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in Quaternion DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public IDNOIKOIDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct MLDEGJAOMMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity IEFFOCOBJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity KFGEJHIJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity LCCGHHJFGDE;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x2970BA0", Offset = "0x296FBA0", VA = "0x182970BA0")]
	public MLDEGJAOMMP(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK, Entity LCCGHHJFGDE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x2970B60", Offset = "0x296FB60", VA = "0x182970B60")]
	public static MLDEGJAOMMP LFOOIECCIPM((Entity entity, Entity oldParent, Entity newParent) FHJGCPGBEAL)
	{
		return default(MLDEGJAOMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x2970B40", Offset = "0x296FB40", VA = "0x182970B40")]
	public void KONCNEDHOLC(out Entity IEFFOCOBJJI, out Entity KFGEJHIJBGK, out Entity LCCGHHJFGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct GGMEAKIAMAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity IEFFOCOBJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity ICMEPOIJCJO;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0xDF1520", Offset = "0xDF0520", VA = "0x180DF1520")]
	public GGMEAKIAMAM(Entity IEFFOCOBJJI, Entity ICMEPOIJCJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D770", Offset = "0x2C5C770", VA = "0x182C5D770")]
	public static GGMEAKIAMAM LFOOIECCIPM((Entity entity, Entity parent) FHJGCPGBEAL)
	{
		return default(GGMEAKIAMAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D760", Offset = "0x2C5C760", VA = "0x182C5D760")]
	public void KONCNEDHOLC(out Entity IEFFOCOBJJI, out Entity ICMEPOIJCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct HOBLNHDMNAF<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle DCLMHANFEGK;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool HAKCAILKKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DA70", Offset = "0x2C6CA70", VA = "0x182C6DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x2E47120", Offset = "0x2E46120", VA = "0x182E47120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x2E471C0", Offset = "0x2E461C0", VA = "0x182E471C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x2E47280", Offset = "0x2E46280", VA = "0x182E47280")]
	public HOBLNHDMNAF(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2E470F0", Offset = "0x2E460F0", VA = "0x182E470F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum PPEAHEMHINL
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct MJPMCDBPLIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public PPEAHEMHINL IOFJIFKFLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int NIKABAFFCDO;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
	public MJPMCDBPLIH(PPEAHEMHINL IOFJIFKFLFF, int NIKABAFFCDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x2970B20", Offset = "0x296FB20", VA = "0x182970B20")]
	public static MJPMCDBPLIH LFOOIECCIPM((PPEAHEMHINL eventType, int eventIndex) JMDPDGBMGAA)
	{
		return default(MJPMCDBPLIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x2970B10", Offset = "0x296FB10", VA = "0x182970B10")]
	public void KONCNEDHOLC(out PPEAHEMHINL IOFJIFKFLFF, out int NIKABAFFCDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[DEJAKMDKDPE(typeof(JKBMOIGEDEI), new string[] { })]
public sealed class GHDMMKNFMGA : JKBMOIGEDEI, COMOMFINKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private JEGLAIMIPKC FCPBNGLBMDO;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D840", Offset = "0x2C5C840", VA = "0x182C5D840", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D7A0", Offset = "0x2C5C7A0", VA = "0x182C5D7A0")]
	public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GHDMMKNFMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D7A0", Offset = "0x2C5C7A0", VA = "0x182C5D7A0", Slot = "4")]
	private bool GMOJELGNNMN(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(AGJALCIGKKG))]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal sealed class GIAKCLIIKJH : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D9D0", Offset = "0x2C5C9D0", VA = "0x182C5D9D0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public GIAKCLIIKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[BLFKHCHIGFF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
[UpdateInGroup(typeof(EMNLGBGFAID))]
public sealed class OLFICMLNACI : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x29737F0", Offset = "0x29727F0", VA = "0x1829737F0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public OLFICMLNACI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[BLFKHCHIGFF]
[UpdateInGroup(typeof(BIPCFAGHHOL))]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
internal sealed class GJJLMCGHAIA : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E3B0", Offset = "0x2C5D3B0", VA = "0x182C5E3B0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public GJJLMCGHAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class JAPNGKLKPHC : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public JAPNGKLKPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[BLFKHCHIGFF]
[HEOEGCBCCCD(KHFGEOAKOKD.LoadInstance)]
[UpdateInGroup(typeof(GNLJPHBPHDD))]
internal sealed class DAFEDNGOABD : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2A786E0", Offset = "0x2A776E0", VA = "0x182A786E0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x2971B50", Offset = "0x2970B50", VA = "0x182971B50")]
	public DAFEDNGOABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[CNPLGNFBEPP(typeof(AuthoredLocalPoseData))]
public sealed class BOEMCKNOBHK : AIMIAFCPLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A110", Offset = "0x2A69110", VA = "0x182A6A110", Slot = "8")]
	protected override bool GLCFABJPCDC(ReadOnlySpan<AuthoredLocalPoseData> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A050", Offset = "0x2A69050", VA = "0x182A6A050", Slot = "9")]
	protected override bool EHOJBANGFCF(int IIJDDKBOPLN, Span<AuthoredLocalPoseData> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A190", Offset = "0x2A69190", VA = "0x182A6A190")]
	public BOEMCKNOBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[CNPLGNFBEPP(typeof(LocalPoseData))]
public sealed class KHEEHOJHBOD : ACJMFJHFCHL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E480", Offset = "0x2C6D480", VA = "0x182C6E480", Slot = "8")]
	protected override bool GLCFABJPCDC(ReadOnlySpan<LocalPoseData> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E3C0", Offset = "0x2C6D3C0", VA = "0x182C6E3C0", Slot = "9")]
	protected override bool EHOJBANGFCF(int IIJDDKBOPLN, Span<LocalPoseData> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E500", Offset = "0x2C6D500", VA = "0x182C6E500")]
	public KHEEHOJHBOD()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C1C0", Offset = "0x2B1B1C0", VA = "0x182B1C1C0", Slot = "6")]
		public sealed override void EFMBJNCKONM(GEJJOANAKLE KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D160", Offset = "0x2B1C160", VA = "0x182B1D160", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E860", Offset = "0x2C6D860", VA = "0x182C6E860")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E510", Offset = "0x2C6D510", VA = "0x182C6E510")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
