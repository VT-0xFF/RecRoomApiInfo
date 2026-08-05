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
	[Cpp2IlInjected.Address(RVA = "0x3E199A0", Offset = "0x3E187A0", VA = "0x183E199A0")]
	static DENEAILGKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D00210", Offset = "0x3CFF010", VA = "0x183D00210")]
	public static void HIJELFNCJBL<T>(T PPLEFHADAKM, ref T KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E19740", Offset = "0x3E18540", VA = "0x183E19740")]
	public static void HIJELFNCJBL(FixedString32 PPLEFHADAKM, ref string KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E19700", Offset = "0x3E18500", VA = "0x183E19700")]
	public static void HIJELFNCJBL(string PPLEFHADAKM, ref FixedString32 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E19810", Offset = "0x3E18610", VA = "0x183E19810")]
	public static void HIJELFNCJBL(FixedString64 PPLEFHADAKM, ref string KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E19940", Offset = "0x3E18740", VA = "0x183E19940")]
	public static void HIJELFNCJBL(string PPLEFHADAKM, ref FixedString64 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E19870", Offset = "0x3E18670", VA = "0x183E19870")]
	public static void HIJELFNCJBL(ONJOGGKGEFN PPLEFHADAKM, ref Vector3 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E198A0", Offset = "0x3E186A0", VA = "0x183E198A0")]
	public static void HIJELFNCJBL(Vector3 PPLEFHADAKM, ref ONJOGGKGEFN KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E19840", Offset = "0x3E18640", VA = "0x183E19840")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref Vector4 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E19690", Offset = "0x3E18490", VA = "0x183E19690")]
	public static void HIJELFNCJBL(Vector4 PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E19840", Offset = "0x3E18640", VA = "0x183E19840")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref Quaternion KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E19690", Offset = "0x3E18490", VA = "0x183E19690")]
	public static void HIJELFNCJBL(Quaternion PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E197E0", Offset = "0x3E185E0", VA = "0x183E197E0")]
	public static void HIJELFNCJBL(ONJOGGKGEFN PPLEFHADAKM, ref float3 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E198A0", Offset = "0x3E186A0", VA = "0x183E198A0")]
	public static void HIJELFNCJBL(float3 PPLEFHADAKM, ref ONJOGGKGEFN KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E19650", Offset = "0x3E18450", VA = "0x183E19650")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref float4 KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E19690", Offset = "0x3E18490", VA = "0x183E19690")]
	public static void HIJELFNCJBL(float4 PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E19650", Offset = "0x3E18450", VA = "0x183E19650")]
	public static void HIJELFNCJBL(ACLCFAOOCKE PPLEFHADAKM, ref quaternion KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E19770", Offset = "0x3E18570", VA = "0x183E19770")]
	public static void HIJELFNCJBL(quaternion PPLEFHADAKM, ref ACLCFAOOCKE KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E19900", Offset = "0x3E18700", VA = "0x183E19900")]
	public static void HIJELFNCJBL(Entity PPLEFHADAKM, ref AHHJJFHMNFO KCFALBDMKBF, LDGDBBFAFNK NEHLAILGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E19630", Offset = "0x3E18430", VA = "0x183E19630")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OGAFJLECHAO JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3F35940", Offset = "0x3F34740", VA = "0x183F35940", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
	public HNNECGFCPKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F35700", Offset = "0x3F34500", VA = "0x183F35700", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3F35680", Offset = "0x3F34480", VA = "0x183F35680")]
	[Preserve]
	private void EBNCNNGHCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public HFJJPBGKAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E0BCA0", Offset = "0x3E0AAA0", VA = "0x183E0BCA0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public CADDIMFPIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CD60", Offset = "0x3C5BB60", VA = "0x183C5CD60")]
		public static ObjectModelConfigAsset JKDLFHIKAAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77E460", Offset = "0x77D260", VA = "0x18077E460")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C272A0", Offset = "0x4C260A0", VA = "0x184C272A0")]
			public static AIELFMMICMN DNNHCJHDEJH(int CEONKDFAFMI)
			{
				return default(AIELFMMICMN);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4C27690", Offset = "0x4C26490", VA = "0x184C27690")]
			private static void ICCGLAAIPLH(PMFFIMLMCEJ EKIBDFHDPDI, PMFFIMLMCEJ HIFCLAGDMJN, AIELFMMICMN CDEOFEMHEEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4C27820", Offset = "0x4C26620", VA = "0x184C27820")]
			public static int JABNLOEPLBE(GameObject NCAOMIEGHPA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4C279F0", Offset = "0x4C267F0", VA = "0x184C279F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5E180", Offset = "0x3C5CF80", VA = "0x183C5E180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DF50", Offset = "0x3C5CD50", VA = "0x183C5DF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DOKNELGMFJP KICJEKGPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E4F0", Offset = "0x3C5D2F0", VA = "0x183C5E4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3C5D050", Offset = "0x3C5BE50", VA = "0x183C5D050")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool NGODNGEHGOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E670", Offset = "0x3C5D470", VA = "0x183C5E670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static OKKPKCPMOFL OPHCKCDGIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DCB0", Offset = "0x3C5CAB0", VA = "0x183C5DCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OGAFJLECHAO JCLAJNCOHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E310", Offset = "0x3C5D110", VA = "0x183C5E310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static KHAPNLPCPDI ELGLAEPGDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DC30", Offset = "0x3C5CA30", VA = "0x183C5DC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LHMGIFBKNDN NBDKJPAKGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E390", Offset = "0x3C5D190", VA = "0x183C5E390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static JEAKCMCJOBO CEJNFPFMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3C5CFD0", Offset = "0x3C5BDD0", VA = "0x183C5CFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static BCIOKJKBEBJ NJNIFJHCMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DED0", Offset = "0x3C5CCD0", VA = "0x183C5DED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool MMADCFJFMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3C5CEF0", Offset = "0x3C5BCF0", VA = "0x183C5CEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LFILGIMDCKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3C5D530", Offset = "0x3C5C330", VA = "0x183C5D530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool CFEFJCFDHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3C5D4D0", Offset = "0x3C5C2D0", VA = "0x183C5D4D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E030", Offset = "0x3C5CE30", VA = "0x183C5E030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool FOBIIHPKIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3C5D9D0", Offset = "0x3C5C7D0", VA = "0x183C5D9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E610", Offset = "0x3C5D410", VA = "0x183C5E610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action NGFIHHEOKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DA30", Offset = "0x3C5C830", VA = "0x183C5DA30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3C5DB30", Offset = "0x3C5C930", VA = "0x183C5DB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CE00", Offset = "0x3C5BC00", VA = "0x183C5CE00")]
		public static PMFFIMLMCEJ ABIIJDLPNOE(GameObject NCAOMIEGHPA)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DE70", Offset = "0x3C5CC70", VA = "0x183C5DE70")]
		public static bool JAJAMJGEIFE(ByteString GEGIPEOHNBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DD50", Offset = "0x3C5CB50", VA = "0x183C5DD50")]
		public static BDCNBKPMJEP IAEPEIJPHOB(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E7D0", Offset = "0x3C5D5D0", VA = "0x183C5E7D0")]
		public static (ByteString, IDisposable) PNKNJNLKBEB()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D8A0", Offset = "0x3C5C6A0", VA = "0x183C5D8A0")]
		public static (ByteString, IDisposable) FANAIAHMGAM(IEnumerable<PMFFIMLMCEJ> FLOFPLIMDAC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E1E0", Offset = "0x3C5CFE0", VA = "0x183C5E1E0")]
		public static bool MDFKHJICIGG(GameObject NCAOMIEGHPA, out AIELFMMICMN CDEOFEMHEEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E090", Offset = "0x3C5CE90", VA = "0x183C5E090")]
		public static bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D2D0", Offset = "0x3C5C0D0", VA = "0x183C5D2D0")]
		public static void CFMJHACGJMJ(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D720", Offset = "0x3C5C520", VA = "0x183C5D720")]
		public static Task ELFFODJEJEP(bool ILHPJDCALOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E410", Offset = "0x3C5D210", VA = "0x183C5E410")]
		private static DOKNELGMFJP OFJBMFHLPIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D3B0", Offset = "0x3C5C1B0", VA = "0x183C5D3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C61FE0", VA = "0x183C631E0")]
		public static bool LOGHBGHMEHF(GEINEDFCGEN DDJOCHKBBBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3C63490", Offset = "0x3C62290", VA = "0x183C63490")]
		public static GEINEDFCGEN MNFGPLMIANE(GameObject NCAOMIEGHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C63290", Offset = "0x3C62090", VA = "0x183C63290")]
		public static GEINEDFCGEN MNFGPLMIANE(GameObject NCAOMIEGHPA, AIELFMMICMN CDEOFEMHEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C62DF0", Offset = "0x3C61BF0", VA = "0x183C62DF0")]
		public static bool AFDHKMDJIPF(GameObject JLMCLCAPEFE, string LALNMBEBNKC, bool ANJHJIPLJFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C62EF0", Offset = "0x3C61CF0", VA = "0x183C62EF0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void GGNMLPCOMIH(GameObject JLMCLCAPEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C630F0", Offset = "0x3C61EF0", VA = "0x183C630F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PMFFIMLMCEJ KCKCDBCKCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(PMFFIMLMCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xACF570", Offset = "0xACE370", VA = "0x180ACF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E22490", Offset = "0x3E21290", VA = "0x183E22490", Slot = "15")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BDCNBKPMJEP HGBOMLOHJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3E22540", Offset = "0x3E21340", VA = "0x183E22540", Slot = "6")]
			get
			{
				return default(BDCNBKPMJEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ANGKCDCBMGA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3E22480", Offset = "0x3E21280", VA = "0x183E22480", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public GDFIOEANNKI NPJAAKCIGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x73C1E0", Offset = "0x73AFE0", VA = "0x18073C1E0", Slot = "7")]
			get
			{
				return default(GDFIOEANNKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OGAFJLECHAO JCLAJNCOHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3E21D10", Offset = "0x3E20B10", VA = "0x183E21D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private HJBNADOIEKJ JPAPBFKHHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3E21940", Offset = "0x3E20740", VA = "0x183E21940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool DMNFMOCPLAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> CPOEFFHHJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3E22340", Offset = "0x3E21140", VA = "0x183E22340")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3E22570", Offset = "0x3E21370", VA = "0x183E22570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GEINEDFCGEN> OCKAAJFFADD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3E223E0", Offset = "0x3E211E0", VA = "0x183E223E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3E22610", Offset = "0x3E21410", VA = "0x183E22610", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3E21760", Offset = "0x3E20560", VA = "0x183E21760")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3E221A0", Offset = "0x3E20FA0", VA = "0x183E221A0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3E21E50", Offset = "0x3E20C50", VA = "0x183E21E50", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3E22110", Offset = "0x3E20F10", VA = "0x183E22110", Slot = "10")]
		public void OnEmbody(JLJEDKKMHDF GLPDAIBKGJO, PMFFIMLMCEJ ALJACNMOIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3E22190", Offset = "0x3E20F90", VA = "0x183E22190", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E21F00", Offset = "0x3E20D00", VA = "0x183E21F00", Slot = "12")]
		public void OnDisembody(bool KMJJKAFNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3E21A30", Offset = "0x3E20830", VA = "0x183E21A30")]
		private void HKEFAPHGKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E219A0", Offset = "0x3E207A0", VA = "0x183E219A0")]
		private void EOEAAIEBGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3E21B30", Offset = "0x3E20930", VA = "0x183E21B30")]
		private void JFGJEPFBPOK(bool GKIJPPGHEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3E21DF0", Offset = "0x3E20BF0", VA = "0x183E21DF0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x78E430", Offset = "0x78D230", VA = "0x18078E430", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6D9C0", Offset = "0x3C6C7C0", VA = "0x183C6D9C0", Slot = "6")]
			get
			{
				return default(PEMKGMKGDAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D960", Offset = "0x3C6C760", VA = "0x183C6D960")]
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
			[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60", Slot = "6")]
			get
			{
				return default(PEMKGMKGDAH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73A8B0", Offset = "0x7396B0", VA = "0x18073A8B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PMFFIMLMCEJ KCKCDBCKCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x77C370", Offset = "0x77B170", VA = "0x18077C370", Slot = "5")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ANGKCDCBMGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity HDJJNJMCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal JEAKCMCJOBO CEJNFPFMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal HJBNADOIEKJ FMENJHJIFDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E88D40", Offset = "0x3E87B40", VA = "0x183E88D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E88C90", Offset = "0x3E87A90", VA = "0x183E88C90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E88DB0", Offset = "0x3E87BB0", VA = "0x183E88DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E88EA0", Offset = "0x3E87CA0", VA = "0x183E88EA0")]
		internal void NAGCBALDEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E88CA0", Offset = "0x3E87AA0", VA = "0x183E88CA0")]
		private bool CEFAPIMKAFP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E891B0", Offset = "0x3E87FB0", VA = "0x183E891B0")]
		private void NIKCFFCGDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E88DB0", Offset = "0x3E87BB0", VA = "0x183E88DB0")]
		internal void MCFEKKLCLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E891E0", Offset = "0x3E87FE0", VA = "0x183E891E0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E892C0", Offset = "0x3E880C0", VA = "0x183E892C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1100", Offset = "0x9BFF00", VA = "0x1809C1100", Slot = "19")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HEGPOCOMKLM OPHCKCDGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ALAPBINNPIH JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OGAFJLECHAO JCLAJNCOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F31EA0", Offset = "0x3F30CA0", VA = "0x183F31EA0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F31B20", Offset = "0x3F30920", VA = "0x183F31B20", Slot = "20")]
	public void JPFKMOKBFIC(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x10368C0", Offset = "0x10356C0", VA = "0x1810368C0")]
	private void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F31DC0", Offset = "0x3F30BC0", VA = "0x183F31DC0")]
	private void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F317B0", Offset = "0x3F305B0", VA = "0x183F317B0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F31D80", Offset = "0x3F30B80", VA = "0x183F31D80", Slot = "10")]
	public void MLBHFNLKEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void AIAJFPGBKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F31860", Offset = "0x3F30660", VA = "0x183F31860", Slot = "5")]
	public void EKPKAOOLNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F31810", Offset = "0x3F30610", VA = "0x183F31810", Slot = "6")]
	public void EBDFPIANNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F31AB0", Offset = "0x3F308B0", VA = "0x183F31AB0", Slot = "7")]
	public void JAFDOAPKFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F31C30", Offset = "0x3F30A30", VA = "0x183F31C30", Slot = "8")]
	public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3F31A40", Offset = "0x3F30840", VA = "0x183F31A40", Slot = "9")]
	public void IJMNPCGJOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3F31D10", Offset = "0x3F30B10", VA = "0x183F31D10", Slot = "11")]
	public void LEFINFPNLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F318D0", Offset = "0x3F306D0", VA = "0x183F318D0", Slot = "12")]
	public void GIAFFOHOMBD(bool EDJPCLPLIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F31E70", Offset = "0x3F30C70", VA = "0x183F31E70")]
	private void OHOLADFCMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F31EB0", Offset = "0x3F30CB0", VA = "0x183F31EB0", Slot = "13")]
	public ByteString PNKNJNLKBEB(out IDisposable MLBIKCLFEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F31680", Offset = "0x3F30480", VA = "0x183F31680", Slot = "14")]
	public void CJKIJAOEIBM(ByteString FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F31950", Offset = "0x3F30750", VA = "0x183F31950")]
	public static GKNHEGMBMLM HJNGNBALKKN(HEGPOCOMKLM GNDGFHCLBLF, NDAGMAFOAIH DNPJACNCEDM = NDAGMAFOAIH.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void BOMFCMMLBHD(HEGPOCOMKLM GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void JGCCGOFGOIO(HEGPOCOMKLM GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GKNHEGMBMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EGCOOEMKJNC
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E400", Offset = "0x3E1D200", VA = "0x183E1E400")]
	public static BDCNBKPMJEP DDBABLLMGCD(this DOKNELGMFJP BPEDINOHFJC, AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
	{
		return default(BDCNBKPMJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E540", Offset = "0x3E1D340", VA = "0x183E1E540")]
	public static OEFHHNLJGLJ EPCCFBBJKBB(this DOKNELGMFJP BPEDINOHFJC)
	{
		return default(OEFHHNLJGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E100", Offset = "0x3E1CF00", VA = "0x183E1E100")]
	public static PMFFIMLMCEJ ABIIJDLPNOE(this DOKNELGMFJP BPEDINOHFJC, Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E1B0", Offset = "0x3E1CFB0", VA = "0x183E1E1B0")]
	public static PMFFIMLMCEJ ABIIJDLPNOE(this DOKNELGMFJP BPEDINOHFJC, AIELFMMICMN CDEOFEMHEEC)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E2E0", Offset = "0x3E1D0E0", VA = "0x183E1E2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BA7AB0", Offset = "0x3BA68B0", VA = "0x183BA7AB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7A00", Offset = "0x3BA6800", VA = "0x183BA7A00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KANENNLDGEA KHDANJBAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BA95D0", Offset = "0x3BA83D0", VA = "0x183BA95D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DJCHPEIKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7F50", Offset = "0x3BA6D50", VA = "0x183BA7F50", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DFEABAJEDJB EPCEMKIEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9860", Offset = "0x3BA8660", VA = "0x183BA9860", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x37BCF10", Offset = "0x37BBD10", VA = "0x1837BCF10", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9EA0", Offset = "0x3BA8CA0", VA = "0x183BA9EA0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::DGJILFKFHNF<AIELFMMICMN> NGFIHHEOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3BA84A0", Offset = "0x3BA72A0", VA = "0x183BA84A0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BA8550", Offset = "0x3BA7350", VA = "0x183BA8550", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA1A0", Offset = "0x3BA8FA0", VA = "0x183BAA1A0")]
	public NCADOIFIPPP(global::EPFNEMCEMCP<Entity> FJONJLMIBBO, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8790", Offset = "0x3BA7590", VA = "0x183BA8790")]
	private Entity GNCNGCOCOBN(AIELFMMICMN CDEOFEMHEEC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA86B0", Offset = "0x3BA74B0", VA = "0x183BA86B0")]
	private AIELFMMICMN GNCNGCOCOBN(Entity IEFFOCOBJJI)
	{
		return default(AIELFMMICMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6FB0", Offset = "0x3BA5DB0", VA = "0x183BA6FB0", Slot = "4")]
	public T CIGAFCHFFML(AIELFMMICMN CDEOFEMHEEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7B00", Offset = "0x3BA6900", VA = "0x183BA7B00")]
	public bool FAFPJPFNCCD(AIELFMMICMN CDEOFEMHEEC, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6A50", Offset = "0x3BA5850", VA = "0x183BA6A50")]
	public bool BJINBOAHBFJ(AIELFMMICMN CDEOFEMHEEC, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BA96F0", Offset = "0x3BA84F0", VA = "0x183BA96F0", Slot = "9")]
	public bool LCJCOLBECPG(AIELFMMICMN CDEOFEMHEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BA66F0", Offset = "0x3BA54F0", VA = "0x183BA66F0", Slot = "26")]
	public object ANODEELHHIF(AIELFMMICMN CDEOFEMHEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3BA81F0", Offset = "0x3BA6FF0", VA = "0x183BA81F0")]
	public bool FOFEELJIFLA(AIELFMMICMN CDEOFEMHEEC, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6BF0", Offset = "0x3BA59F0", VA = "0x183BA6BF0")]
	public void CIGAFCHFFML(AIELFMMICMN CDEOFEMHEEC, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7E50", Offset = "0x3BA6C50", VA = "0x183BA7E50")]
	public bool FAFPJPFNCCD(AIELFMMICMN CDEOFEMHEEC, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA69D0", Offset = "0x3BA57D0", VA = "0x183BA69D0")]
	public bool BJINBOAHBFJ(AIELFMMICMN CDEOFEMHEEC, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3BA63E0", Offset = "0x3BA51E0", VA = "0x183BA63E0", Slot = "22")]
	public void ALPKNKNFCBE(LHLKDMMNFKH BAHONECJAGF, [Optional] object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6410", Offset = "0x3BA5210", VA = "0x183BA6410", Slot = "15")]
	public void ALPKNKNFCBE(AIELFMMICMN PIIJMEAKDGO, BMEAGCNBNJP BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9D20", Offset = "0x3BA8B20", VA = "0x183BA9D20", Slot = "14")]
	public bool OHCGLANLMCK(AIELFMMICMN KCFALBDMKBF, AIELFMMICMN PPLEFHADAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F60250", Offset = "0x2F5F050", VA = "0x182F60250", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA100", Offset = "0x3BA8F00", VA = "0x183BAA100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9650", Offset = "0x3BA8450", VA = "0x183BA9650")]
	public string KMKNAAEDLGP(in PEKIEJLMCEO HDEPGCNDBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9120", Offset = "0x3BA7F20", VA = "0x183BA9120")]
	private void IALIFCGOKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA98B0", Offset = "0x3BA86B0", VA = "0x183BA98B0")]
	private void NDLAAEKABBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8CF0", Offset = "0x3BA7AF0", VA = "0x183BA8CF0")]
	private void HMFLJFGFPKE(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9FC0", Offset = "0x3BA8DC0", VA = "0x183BA9FC0")]
	private void PMBMCHAFCDF(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7600", Offset = "0x3BA6400", VA = "0x183BA7600")]
	[Conditional("DEBUG_BUILD")]
	private static void CNDICPLCPDE(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC, string AOKAOIOMMBG, string MKOJBJLKAFM, [CallerMemberName] string DEEBFFICGIP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x37BCFD0", Offset = "0x37BBDD0", VA = "0x1837BCFD0", Slot = "5")]
	private bool FHBBNBOOGDJ(AIELFMMICMN PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8860", Offset = "0x3BA7660", VA = "0x183BA8860", Slot = "6")]
	private bool GPCDJOCMNED(AIELFMMICMN PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x39CD800", Offset = "0x39CC600", VA = "0x1839CD800", Slot = "10")]
	private bool AGJPHMDNIIM(AIELFMMICMN PIIJMEAKDGO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7970", Offset = "0x3BA6770", VA = "0x183BA7970", Slot = "11")]
	private void DGEBNGPLEGM(AIELFMMICMN PIIJMEAKDGO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8890", Offset = "0x3BA7690", VA = "0x183BA8890", Slot = "12")]
	private bool HKBAJPJHGBH(AIELFMMICMN PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9620", Offset = "0x3BA8420", VA = "0x183BA9620", Slot = "13")]
	private bool KBFFOGLBOOG(AIELFMMICMN PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9CF0", Offset = "0x3BA8AF0", VA = "0x183BA9CF0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x45F1540", Offset = "0x45F0340", VA = "0x1845F1540", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type CMCPPDDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x45F14E0", Offset = "0x45F02E0", VA = "0x1845F14E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KANENNLDGEA KHDANJBAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x45F2E90", Offset = "0x45F1C90", VA = "0x1845F2E90", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DJCHPEIKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x45F1A30", Offset = "0x45F0830", VA = "0x1845F1A30", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DFEABAJEDJB EPCEMKIEBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x45F3020", Offset = "0x45F1E20", VA = "0x1845F3020", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x427BB50", Offset = "0x427A950", VA = "0x18427BB50", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4286A50", Offset = "0x4285850", VA = "0x184286A50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::DGJILFKFHNF<PMFFIMLMCEJ> NGFIHHEOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x45F1F50", Offset = "0x45F0D50", VA = "0x1845F1F50", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x45F2000", Offset = "0x45F0E00", VA = "0x1845F2000", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA1A0", Offset = "0x3BA8FA0", VA = "0x183BAA1A0")]
	public GEBDEPLDOED(global::EPFNEMCEMCP<Entity> FJONJLMIBBO, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x23F28E0", Offset = "0x23F16E0", VA = "0x1823F28E0")]
	private Entity GNCNGCOCOBN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x427FD70", Offset = "0x427EB70", VA = "0x18427FD70")]
	private PMFFIMLMCEJ GNCNGCOCOBN(Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x45F1080", Offset = "0x45EFE80", VA = "0x1845F1080", Slot = "4")]
	public T CIGAFCHFFML(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x45F1820", Offset = "0x45F0620", VA = "0x1845F1820")]
	public bool FAFPJPFNCCD(PMFFIMLMCEJ GMOMNBJDADO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x45F0B40", Offset = "0x45EF940", VA = "0x1845F0B40")]
	public bool BJINBOAHBFJ(PMFFIMLMCEJ GMOMNBJDADO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x45F2EE0", Offset = "0x45F1CE0", VA = "0x1845F2EE0", Slot = "9")]
	public bool LCJCOLBECPG(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x42782C0", Offset = "0x42770C0", VA = "0x1842782C0", Slot = "26")]
	public object ANODEELHHIF(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x45F1A80", Offset = "0x45F0880", VA = "0x1845F1A80")]
	public bool FOFEELJIFLA(PMFFIMLMCEJ GMOMNBJDADO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x45F1400", Offset = "0x45F0200", VA = "0x1845F1400")]
	public void CIGAFCHFFML(PMFFIMLMCEJ GMOMNBJDADO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x427D3C0", Offset = "0x427C1C0", VA = "0x18427D3C0")]
	public bool FAFPJPFNCCD(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4279100", Offset = "0x4277F00", VA = "0x184279100")]
	public bool BJINBOAHBFJ(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3BA63E0", Offset = "0x3BA51E0", VA = "0x183BA63E0", Slot = "22")]
	public void ALPKNKNFCBE(LHLKDMMNFKH BAHONECJAGF, [Optional] object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x45F0620", Offset = "0x45EF420", VA = "0x1845F0620", Slot = "15")]
	public void ALPKNKNFCBE(PMFFIMLMCEJ PIIJMEAKDGO, BMEAGCNBNJP BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x42866F0", Offset = "0x42854F0", VA = "0x1842866F0", Slot = "14")]
	public bool OHCGLANLMCK(PMFFIMLMCEJ KCFALBDMKBF, PMFFIMLMCEJ PPLEFHADAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x45F2C10", Offset = "0x45F1A10", VA = "0x1845F2C10")]
	private void IALIFCGOKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x45F30C0", Offset = "0x45F1EC0", VA = "0x1845F30C0")]
	private void NDLAAEKABBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x45F25A0", Offset = "0x45F13A0", VA = "0x1845F25A0")]
	private void HMFLJFGFPKE(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x45F36E0", Offset = "0x45F24E0", VA = "0x1845F36E0")]
	private void PMBMCHAFCDF(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x427BC40", Offset = "0x427AA40", VA = "0x18427BC40", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x45F3830", Offset = "0x45F2630", VA = "0x1845F3830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9650", Offset = "0x3BA8450", VA = "0x183BA9650")]
	public string KMKNAAEDLGP(in PEKIEJLMCEO HDEPGCNDBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x42864C0", Offset = "0x42852C0", VA = "0x1842864C0", Slot = "5")]
	private bool NHPIDCHICEI(PMFFIMLMCEJ PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x427FD30", Offset = "0x427EB30", VA = "0x18427FD30", Slot = "6")]
	private bool GHAFAEHOHLP(PMFFIMLMCEJ PIIJMEAKDGO, in T ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x39CD7C0", Offset = "0x39CC5C0", VA = "0x1839CD7C0", Slot = "10")]
	private bool GJBEJAIIAPC(PMFFIMLMCEJ PIIJMEAKDGO, in object ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x427BB10", Offset = "0x427A910", VA = "0x18427BB10", Slot = "11")]
	private void CNCDNEGOJAM(PMFFIMLMCEJ PIIJMEAKDGO, in MELHFKPCLBG DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4283E20", Offset = "0x4282C20", VA = "0x184283E20", Slot = "12")]
	private bool JFEDKMABCOE(PMFFIMLMCEJ PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4286A90", Offset = "0x4285890", VA = "0x184286A90", Slot = "13")]
	private bool PLLINFLOODM(PMFFIMLMCEJ PIIJMEAKDGO, in PEKIEJLMCEO ANLFJINAGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9CF0", Offset = "0x3BA8AF0", VA = "0x183BA9CF0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public EGLINNINABL(NativeArray<EntityRemapUtility.EntityRemapInfo> NFLOAHPEMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EF70", Offset = "0x3E1DD70", VA = "0x183E1EF70", Slot = "6")]
	public PMFFIMLMCEJ EHCMINANPLD(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EEC0", Offset = "0x3E1DCC0", VA = "0x183E1EEC0", Slot = "7")]
	public Entity EHCMINANPLD(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EED0", Offset = "0x3E1DCD0", VA = "0x183E1EED0", Slot = "8")]
	public IEnumerable<PMFFIMLMCEJ> EHCMINANPLD(IEnumerable<PMFFIMLMCEJ> FLOFPLIMDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EE60", Offset = "0x3E1DC60", VA = "0x183E1EE60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E81390", Offset = "0x3E80190", VA = "0x183E81390")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool NJGPOAGJMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3E81300", Offset = "0x3E80100", VA = "0x183E81300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3E814A0", Offset = "0x3E802A0", VA = "0x183E814A0")]
		public static SerializationRemapScope DIJLAOODIFN()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3E81930", Offset = "0x3E80730", VA = "0x183E81930")]
		public SerializationRemapScope(IKONBHPFCLI MABKPGGCPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3E81500", Offset = "0x3E80300", VA = "0x183E81500", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3E81610", Offset = "0x3E80410", VA = "0x183E81610")]
		public static PMFFIMLMCEJ EHCMINANPLD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3E81770", Offset = "0x3E80570", VA = "0x183E81770")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0BF30", Offset = "0x3E0AD30", VA = "0x183E0BF30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C0B0", Offset = "0x3E0AEB0", VA = "0x183E0C0B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EDBJAGHMFFD ACOFPGPLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BE90", Offset = "0x3E0AC90", VA = "0x183E0BE90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C150", Offset = "0x3E0AF50", VA = "0x183E0C150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event HPGIBFPGDJD PPKNPFHAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BDF0", Offset = "0x3E0ABF0", VA = "0x183E0BDF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BFD0", Offset = "0x3E0ADD0", VA = "0x183E0BFD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C090", Offset = "0x3E0AE90", VA = "0x183E0C090")]
	[Conditional("UNITY_EDITOR")]
	public void JMIILDJFIPJ(AIELFMMICMN ONIGAPOOANN, in NGIENACHJHK FILAKGLBGGA, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C070", Offset = "0x3E0AE70", VA = "0x183E0C070")]
	[Conditional("UNITY_EDITOR")]
	public void INBEGHIKINF(AIELFMMICMN ONIGAPOOANN, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C1F0", Offset = "0x3E0AFF0", VA = "0x183E0C1F0")]
	[Conditional("UNITY_EDITOR")]
	public void PLNCAGFGGGM(AIELFMMICMN ONIGAPOOANN, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool KIKMEFEMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2E170", Offset = "0x3F2CF70", VA = "0x183F2E170")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E6D0", Offset = "0x3F2D4D0", VA = "0x183F2E6D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event FGMJDPMGAAO ACOFPGPLJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E030", Offset = "0x3F2CE30", VA = "0x183F2E030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E9D0", Offset = "0x3F2D7D0", VA = "0x183F2E9D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event POGFJKNKLMC OELKPLHBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E370", Offset = "0x3F2D170", VA = "0x183F2E370")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E870", Offset = "0x3F2D670", VA = "0x183F2E870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event FGMJDPMGAAO IHFLOBEIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E210", Offset = "0x3F2D010", VA = "0x183F2E210")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E590", Offset = "0x3F2D390", VA = "0x183F2E590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IHAODDKEKPO PPKNPFHAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DF90", Offset = "0x3F2CD90", VA = "0x183F2DF90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E4D0", Offset = "0x3F2D2D0", VA = "0x183F2E4D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event OOHCIPJKILH CHMIOKINBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E7A0", Offset = "0x3F2D5A0", VA = "0x183F2E7A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E630", Offset = "0x3F2D430", VA = "0x183F2E630")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> EGJMBEAPHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E0D0", Offset = "0x3F2CED0", VA = "0x183F2E0D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EA70", Offset = "0x3F2D870", VA = "0x183F2EA70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EDIBAPFIALG CEHPPBCHOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E910", Offset = "0x3F2D710", VA = "0x183F2E910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E410", Offset = "0x3F2D210", VA = "0x183F2E410")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E840", Offset = "0x3F2D640", VA = "0x183F2E840")]
	[Conditional("UNITY_EDITOR")]
	public void NAAAFKDCPMN(AIELFMMICMN CDEOFEMHEEC, in NGIENACHJHK FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E4B0", Offset = "0x3F2D2B0", VA = "0x183F2E4B0")]
	[Conditional("UNITY_EDITOR")]
	public void GFKILKGNJKC(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E2B0", Offset = "0x3F2D0B0", VA = "0x183F2E2B0")]
	[Conditional("UNITY_EDITOR")]
	public void DICHEGKLFIB(AIELFMMICMN CDEOFEMHEEC, in NGIENACHJHK FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E570", Offset = "0x3F2D370", VA = "0x183F2E570")]
	[Conditional("UNITY_EDITOR")]
	public void GJMLNELAMDN(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E770", Offset = "0x3F2D570", VA = "0x183F2E770")]
	[Conditional("UNITY_EDITOR")]
	public void KKLCCOHKAMP(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, bool JGOFOHJAGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E9B0", Offset = "0x3F2D7B0", VA = "0x183F2E9B0")]
	[Conditional("UNITY_EDITOR")]
	public void PBLLBLIFPFE(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E310", Offset = "0x3F2D110", VA = "0x183F2E310")]
	[Conditional("UNITY_EDITOR")]
	public void EBOPHGNBINL(string IADPDEAGFAB, object BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3F2E2E0", Offset = "0x3F2D0E0", VA = "0x183F2E2E0")]
	[Conditional("UNITY_EDITOR")]
	public void DPIFIBLMBCA(DCNNCMLGLFN PIIJMEAKDGO, ReadOnlyMemory<byte> BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FPOMEGCHHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DEJAKMDKDPE(typeof(LHIJLKPPKGL), new string[] { })]
public class MMGMEBFDNOB : LHIJLKPPKGL
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C545C0", Offset = "0x3C533C0", VA = "0x183C545C0", Slot = "5")]
	public void EPBJAODJOJN(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C543B0", Offset = "0x3C531B0", VA = "0x183C543B0", Slot = "6")]
	public void BIDPFLOOJBA(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C542C0", Offset = "0x3C530C0", VA = "0x183C542C0", Slot = "7")]
	public void ALCIKGHCGLD(object LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C544A0", Offset = "0x3C532A0", VA = "0x183C544A0", Slot = "4")]
	public IDisposable CPFJBHFKLEJ(object LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0A540", Offset = "0x3E09340", VA = "0x183E0A540")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B9C0", Offset = "0x3E0A7C0", VA = "0x183E0B9C0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E09D10", Offset = "0x3E08B10", VA = "0x183E09D10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A590", Offset = "0x3E09390", VA = "0x183E0A590")]
		public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> GBMJHKDDBFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BB40", Offset = "0x3E0A940", VA = "0x183E0BB40")]
		public static bool OBHKEFHAEPL(JBNHJOMIEDN KJACHHOOFKC, out AIELFMMICMN CDEOFEMHEEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E09D20", Offset = "0x3E08B20", VA = "0x183E09D20")]
		private void EHEIDCKMIBG(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, IEnumerable<JBNHJOMIEDN> GBMJHKDDBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A0A0", Offset = "0x3E08EA0", VA = "0x183E0A0A0")]
		private void FDIGGDFNDHN(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A710", Offset = "0x3E09510", VA = "0x183E0A710")]
		private void KFLEJGKKBFO(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, AIELFMMICMN CDEOFEMHEEC, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B490", Offset = "0x3E0A290", VA = "0x183E0B490")]
		private void LOBEFKBNABO(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E0ABF0", Offset = "0x3E099F0", VA = "0x183E0ABF0")]
		private void LEPBHHDBIIM(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, List<JBNHJOMIEDN> KKMENDKLKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A370", Offset = "0x3E09170", VA = "0x183E0A370")]
		private NativeList<AIELFMMICMN> FHCNMOJIAIB(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG)
		{
			return default(NativeList<AIELFMMICMN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B7F0", Offset = "0x3E0A5F0", VA = "0x183E0B7F0")]
		private NativeArray<Entity> LOPKLFEOANM(NativeList<AIELFMMICMN> EOJFKEDDOBI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A2D0", Offset = "0x3E090D0", VA = "0x183E0A2D0")]
		private static void FFPMKODNIDL(Dictionary<AIELFMMICMN, JBNHJOMIEDN> LLHCHDMLAEG, AIELFMMICMN CDEOFEMHEEC, JBNHJOMIEDN KJACHHOOFKC, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E1D1C0", Offset = "0x3E1BFC0", VA = "0x183E1D1C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D140", Offset = "0x3E1BF40", VA = "0x183E1D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool JKLJPALPGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D180", Offset = "0x3E1BF80", VA = "0x183E1D180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3E1D100", Offset = "0x3E1BF00", VA = "0x183E1D100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public void EJEFMDCLGJK(string IADPDEAGFAB, EntityManager MKHPDCKNNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public static void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x73B600", Offset = "0x73A400", VA = "0x18073B600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x73AEE0", Offset = "0x739CE0", VA = "0x18073AEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool NAFDIKOMKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x73B2E0", Offset = "0x73A0E0", VA = "0x18073B2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x73B220", Offset = "0x73A020", VA = "0x18073B220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0xC850D0", Offset = "0xC83ED0", VA = "0x180C850D0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC85100", Offset = "0xC83F00", VA = "0x180C85100", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool GBDHEFPIFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xD4AFE0", Offset = "0xD49DE0", VA = "0x180D4AFE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x85DCE0", Offset = "0x85CAE0", VA = "0x18085DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JBKANIAMFJC HJLBIIAFNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3E835A0", Offset = "0x3E823A0", VA = "0x183E835A0", Slot = "16")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3E82240", Offset = "0x3E81040", VA = "0x183E82240", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3E82C50", Offset = "0x3E81A50", VA = "0x183E82C50")]
		public static bool JAJAMJGEIFE(ByteString GEGIPEOHNBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x836620", Offset = "0x835420", VA = "0x180836620")]
		public void FCNKMGBIECB(MACMNODFHDH MCDGGGMPFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E83240", Offset = "0x3E82040", VA = "0x183E83240", Slot = "5")]
		public void LGAIOBDOLNF(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E82530", Offset = "0x3E81330", VA = "0x183E82530", Slot = "6")]
		public Task FMMMFBCFJNA(bool ILHPJDCALOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E83820", Offset = "0x3E82620", VA = "0x183E83820", Slot = "7")]
		public ByteString PNKNJNLKBEB(out IDisposable MLBIKCLFEHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E83640", Offset = "0x3E82440", VA = "0x183E83640", Slot = "19")]
		public ByteString PNKNJNLKBEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E81B90", Offset = "0x3E80990", VA = "0x183E81B90", Slot = "9")]
		public bool CJKIJAOEIBM(ByteString DFKKPBPDGCI, BBJEKFLIBLK DNPJACNCEDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E81BF0", Offset = "0x3E809F0", VA = "0x183E81BF0")]
		private bool CLIBGLDCABB(ByteString DFKKPBPDGCI, BBJEKFLIBLK DNPJACNCEDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E819C0", Offset = "0x3E807C0", VA = "0x183E819C0", Slot = "8")]
		public void CDFDDCKFAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E829E0", Offset = "0x3E817E0", VA = "0x183E829E0", Slot = "10")]
		public bool JAFDOAPKFLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E82E00", Offset = "0x3E81C00", VA = "0x183E82E00", Slot = "11")]
		public bool KEMAFHDLFGF(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E82900", Offset = "0x3E81700", VA = "0x183E82900")]
		public bool ILAPMPCALLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E826D0", Offset = "0x3E814D0", VA = "0x183E826D0", Slot = "12")]
		public bool IJMNPCGJOCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E81F10", Offset = "0x3E80D10", VA = "0x183E81F10")]
		public void CMFFENBBNBN(JBKANIAMFJC.AOCPEIEHKKM.MAEOINGMEMC JOHEPNEHJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E83310", Offset = "0x3E82110", VA = "0x183E83310")]
		private bool LGFGMKDDBMM(ByteString DFKKPBPDGCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E82DB0", Offset = "0x3E81BB0", VA = "0x183E82DB0")]
		private void KDCFJHJPIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E82670", Offset = "0x3E81470", VA = "0x183E82670")]
		private ByteString HBOBKKMJFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E82420", Offset = "0x3E81220", VA = "0x183E82420")]
		private ByteString FBJHGNACJFP(ByteString GEGIPEOHNBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E821A0", Offset = "0x3E80FA0", VA = "0x183E821A0")]
		private JBKANIAMFJC.AOCPEIEHKKM.MAEOINGMEMC DBEPPMKAOJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E82D80", Offset = "0x3E81B80", VA = "0x183E82D80")]
		private void JLGNLABEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E83070", Offset = "0x3E81E70", VA = "0x183E83070", Slot = "13")]
		public bool LEFINFPNLGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E825C0", Offset = "0x3E813C0", VA = "0x183E825C0", Slot = "14")]
		public void GIAFFOHOMBD(bool EDJPCLPLIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E82250", Offset = "0x3E81050", VA = "0x183E82250")]
		private void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E19290", Offset = "0x3E18090", VA = "0x183E19290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E19010", Offset = "0x3E17E10", VA = "0x183E19010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IKONBHPFCLI> CABEPOPPDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E19510", Offset = "0x3E18310", VA = "0x183E19510", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E19470", Offset = "0x3E18270", VA = "0x183E19470", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action HGINGPBGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E18F70", Offset = "0x3E17D70", VA = "0x183E18F70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E191A0", Offset = "0x3E17FA0", VA = "0x183E191A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action PCPIOEBBKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E19100", Offset = "0x3E17F00", VA = "0x183E19100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E19330", Offset = "0x3E18130", VA = "0x183E19330", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<IKONBHPFCLI> PIIGFJLEOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E18ED0", Offset = "0x3E17CD0", VA = "0x183E18ED0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E193D0", Offset = "0x3E181D0", VA = "0x183E193D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x21A7920", Offset = "0x21A6720", VA = "0x1821A7920")]
	public void CDFDDCKFAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2289840", Offset = "0x2288640", VA = "0x182289840")]
	public void IAEIHKKBAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2289CB0", Offset = "0x2288AB0", VA = "0x182289CB0")]
	public void LCPINFHPIAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E19240", Offset = "0x3E18040", VA = "0x183E19240")]
	public void HMEAEAJLKAA(IKONBHPFCLI LINDLPIKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E190B0", Offset = "0x3E17EB0", VA = "0x183E190B0")]
	public void EJAKHINCGEF(IKONBHPFCLI LINDLPIKMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x73C1F0", Offset = "0x73AFF0", VA = "0x18073C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D4F0", Offset = "0x3F2C2F0", VA = "0x183F2D4F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xC07730", Offset = "0xC06530", VA = "0x180C07730", Slot = "14")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DA90", Offset = "0x3F2C890", VA = "0x183F2DA90", Slot = "15")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CF10", Offset = "0x3F2BD10", VA = "0x183F2CF10", Slot = "16")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1095040", Offset = "0x1093E40", VA = "0x181095040", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B000", Offset = "0x3C59E00", VA = "0x183C5B000")]
	private PMFFIMLMCEJ AGBHEPFNNIC(Entity IEFFOCOBJJI)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D870", Offset = "0x3F2C670", VA = "0x183F2D870", Slot = "4")]
	public PMFFIMLMCEJ LGNFHDEKAND(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CCF0", Offset = "0x3F2BAF0", VA = "0x183F2CCF0", Slot = "19")]
	public void BNNIGJAFFAC(ref List<PMFFIMLMCEJ> HCIALCFLHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D8D0", Offset = "0x3F2C6D0", VA = "0x183F2D8D0", Slot = "20")]
	public IEnumerable<PMFFIMLMCEJ> LHNLJGEEPBH(PMFFIMLMCEJ GMOMNBJDADO, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D000", Offset = "0x3F2BE00", VA = "0x183F2D000", Slot = "21")]
	public PMFFIMLMCEJ CCOFDHEFLND(PMFFIMLMCEJ GMOMNBJDADO, int NPDGHPHAKDK)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D610", Offset = "0x3F2C410", VA = "0x183F2D610", Slot = "22")]
	public int HHHEJELPEEC(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CB20", Offset = "0x3F2B920", VA = "0x183F2CB20", Slot = "8")]
	public int APKIBECFENN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D9A0", Offset = "0x3F2C7A0", VA = "0x183F2D9A0", Slot = "9")]
	public CIMNJIOJIIP LILLNBMHGGN(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(CIMNJIOJIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D1D0", Offset = "0x3F2BFD0", VA = "0x183F2D1D0", Slot = "23")]
	public bool DCCCGHJBHLC(PMFFIMLMCEJ GMOMNBJDADO, out CIMNJIOJIIP PPLEFFEADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DBC0", Offset = "0x3F2C9C0", VA = "0x183F2DBC0", Slot = "24")]
	public IEnumerable<PMFFIMLMCEJ> PICEAKMECIB(PMFFIMLMCEJ GMOMNBJDADO, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D730", Offset = "0x3F2C530", VA = "0x183F2D730", Slot = "12")]
	public PMFFIMLMCEJ IHGCMJMELMP(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D540", Offset = "0x3F2C340", VA = "0x183F2D540", Slot = "13")]
	public bool GOHPGPBBEBL(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB, out PMFFIMLMCEJ OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D3A0", Offset = "0x3F2C1A0", VA = "0x183F2D3A0", Slot = "5")]
	public PMFFIMLMCEJ EKMEMACGALM(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DB90", Offset = "0x3F2C990", VA = "0x183F2DB90", Slot = "11")]
	public bool ONFDIBDBOKI(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DB60", Offset = "0x3F2C960", VA = "0x183F2DB60", Slot = "25")]
	public bool OIGMHNPAGCC(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ELFIACEEOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F2CCC0", Offset = "0x3F2BAC0", VA = "0x183F2CCC0", Slot = "10")]
	public bool BNNCMPPKFKP(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ BBDPANMBHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D440", Offset = "0x3F2C240", VA = "0x183F2D440", Slot = "6")]
	public bool GBLKBIAEIPL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ICMEPOIJCJO, bool NBCBLABIJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3F2D800", Offset = "0x3F2C600", VA = "0x183F2D800", Slot = "7")]
	public bool LAPLJEJINGM(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ ICMEPOIJCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E1ED90", Offset = "0x3E1DB90", VA = "0x183E1ED90", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E980", Offset = "0x3E1D780", VA = "0x183E1E980", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E660", Offset = "0x3E1D460", VA = "0x183E1E660")]
	public BBDBBCGEPIJ CAPHOBNHMEK(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E760", Offset = "0x3E1D560", VA = "0x183E1E760")]
	public BBDBBCGEPIJ CAPHOBNHMEK(OEMFGOLGDMG DLFEJOALJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EC00", Offset = "0x3E1DA00", VA = "0x183E1EC00")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EDE0", Offset = "0x3E1DBE0", VA = "0x183E1EDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710")]
		get
		{
			return default(NativeList<MJPMCDBPLIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<GGMEAKIAMAM> MPNMNBKCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x77C370", Offset = "0x77B170", VA = "0x18077C370")]
		get
		{
			return default(NativeList<GGMEAKIAMAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<MLDEGJAOMMP> KGIBFDKCFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x785430", Offset = "0x784230", VA = "0x180785430")]
		get
		{
			return default(NativeList<MLDEGJAOMMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<GGMEAKIAMAM> JMLIOKDIKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x785400", Offset = "0x784200", VA = "0x180785400")]
		get
		{
			return default(NativeList<GGMEAKIAMAM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle NLBGHIPACEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EF0B0", Offset = "0x9EDEB0", VA = "0x1809EF0B0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2873200", Offset = "0x2872000", VA = "0x182873200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x87D090", Offset = "0x87BE90", VA = "0x18087D090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool BMNPHBIFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E085D0", Offset = "0x3E073D0", VA = "0x183E085D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3E08AE0", Offset = "0x3E078E0", VA = "0x183E08AE0")]
	public BBDBBCGEPIJ(Allocator AEPJLHDIHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3E08540", Offset = "0x3E07340", VA = "0x183E08540")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E089B0", Offset = "0x3E077B0", VA = "0x183E089B0")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3E08680", Offset = "0x3E07480", VA = "0x183E08680")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F39990", Offset = "0x3F38790", VA = "0x183F39990", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3F39970", Offset = "0x3F38770", VA = "0x183F39970", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x8513D0", Offset = "0x8501D0", VA = "0x1808513D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3E21060", Offset = "0x3E1FE60", VA = "0x183E21060")]
	public AIELFMMICMN OCMENEAPIJH()
	{
		return default(AIELFMMICMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3E20FB0", Offset = "0x3E1FDB0", VA = "0x183E20FB0")]
	public void MHNOIJLIFPD(AIELFMMICMN CDEOFEMHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9B88D0", Offset = "0x9B76D0", VA = "0x1809B88D0", Slot = "6")]
	public virtual void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x734720", Offset = "0x733520", VA = "0x180734720", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FC60", Offset = "0x3F2EA60", VA = "0x183F2FC60", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FBB0", Offset = "0x3F2E9B0", VA = "0x183F2FBB0")]
	private void EKHHDNHJPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FC00", Offset = "0x3F2EA00", VA = "0x183F2FC00", Slot = "6")]
	public override void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3EDF0", Offset = "0x3F3DBF0", VA = "0x183F3EDF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery KDELDNBNNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery IMDCAOPKEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x927A10", Offset = "0x926810", VA = "0x180927A10")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery NIFDIGFNDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A10", Offset = "0x8C4810", VA = "0x1808C5A10")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MJGLCBKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF0B0", Offset = "0x9EDEB0", VA = "0x1809EF0B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PIOINGDMMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x77E2F0", Offset = "0x77D0F0", VA = "0x18077E2F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery NMJIJAIKENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EED0", Offset = "0x3F3DCD0", VA = "0x183F3EED0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int LGCAFJDIACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EF50", Offset = "0x3F3DD50", VA = "0x183F3EF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int LHNLIMDPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EE60", Offset = "0x3F3DC60", VA = "0x183F3EE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int CPPHNBAGBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EC70", Offset = "0x3F3DA70", VA = "0x183F3EC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int COGEAMAJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EE40", Offset = "0x3F3DC40", VA = "0x183F3EE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int LGCAFALEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EC50", Offset = "0x3F3DA50", VA = "0x183F3EC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int KJCLOAMCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EF70", Offset = "0x3F3DD70", VA = "0x183F3EF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EE80", Offset = "0x3F3DC80", VA = "0x183F3EE80", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3F3E640", Offset = "0x3F3D440", VA = "0x183F3E640", Slot = "6")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EAE0", Offset = "0x3F3D8E0", VA = "0x183F3EAE0")]
	private EntityQueryDesc COIEDKGPFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EBF0", Offset = "0x3F3D9F0", VA = "0x183F3EBF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EC90", Offset = "0x3F3DA90", VA = "0x183F3EC90")]
	public EIPLHIGFIFI GGKGHPIKBBB(PMFFIMLMCEJ ALJACNMOIMH)
	{
		return default(EIPLHIGFIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3F3ED40", Offset = "0x3F3DB40", VA = "0x183F3ED40")]
	public EIPLHIGFIFI GGKGHPIKBBB(Entity IEFFOCOBJJI)
	{
		return default(EIPLHIGFIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EB40", Offset = "0x3F3D940", VA = "0x183F3EB40")]
	public PEMKGMKGDAH DOKKMMPFKFK(Entity IEFFOCOBJJI)
	{
		return default(PEMKGMKGDAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EF90", Offset = "0x3F3DD90", VA = "0x183F3EF90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int LGCAFJDIACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x3C62AD0", Offset = "0x3C618D0", VA = "0x183C62AD0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LHNLIMDPDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x3C61FD0", Offset = "0x3C60DD0", VA = "0x183C61FD0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int CPPHNBAGBJM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x3C61E30", Offset = "0x3C60C30", VA = "0x183C61E30", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int COGEAMAJCCL
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x3C61F60", Offset = "0x3C60D60", VA = "0x183C61F60", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int LGCAFALEFIH
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x3C61830", Offset = "0x3C60630", VA = "0x183C61830", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int KJCLOAMCHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x3C62D50", Offset = "0x3C61B50", VA = "0x183C62D50", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<PMFFIMLMCEJ, PEMKGMKGDAH> FDOEINMOMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x3C61E50", Offset = "0x3C60C50", VA = "0x183C61E50", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x3C62250", Offset = "0x3C61050", VA = "0x183C62250", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PMFFIMLMCEJ> BIOLFFJDBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x3C62B90", Offset = "0x3C61990", VA = "0x183C62B90", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x3C61FF0", Offset = "0x3C60DF0", VA = "0x183C61FF0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3C62840", Offset = "0x3C61640", VA = "0x183C62840", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3C616B0", Offset = "0x3C604B0", VA = "0x183C616B0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3C62AF0", Offset = "0x3C618F0", VA = "0x183C62AF0")]
		private void NOLLINAKACP(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3C60FF0", Offset = "0x3C5FDF0", VA = "0x183C60FF0")]
		private void BPAKJAKMHFA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3C60F60", Offset = "0x3C5FD60", VA = "0x183C60F60")]
		internal PMFFIMLMCEJ AGBHEPFNNIC(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3C62C30", Offset = "0x3C61A30", VA = "0x183C62C30", Slot = "41")]
		public CIMNJIOJIIP OKCIOHKKCDJ()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3C624E0", Offset = "0x3C612E0", VA = "0x183C624E0", Slot = "42")]
		public CIMNJIOJIIP LAGCFBPEHLM()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3C615D0", Offset = "0x3C603D0", VA = "0x183C615D0", Slot = "43")]
		public CIMNJIOJIIP DIHKJLHNGJD()
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3C61EF0", Offset = "0x3C60CF0", VA = "0x183C61EF0", Slot = "10")]
		public EIPLHIGFIFI GGKGHPIKBBB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(EIPLHIGFIFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3C61670", Offset = "0x3C60470", VA = "0x183C61670", Slot = "11")]
		public PEMKGMKGDAH DOKKMMPFKFK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3C61850", Offset = "0x3C60650", VA = "0x183C61850")]
		private CIMNJIOJIIP EMCOOIHDBGP(EntityQuery FBENFNFLPOM)
		{
			return default(CIMNJIOJIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3C62590", Offset = "0x3C61390", VA = "0x183C62590", Slot = "33")]
		public bool LCJCOLBECPG(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3C623B0", Offset = "0x3C611B0", VA = "0x183C623B0", Slot = "29")]
		public void KGNKLNCMPDI(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3C62090", Offset = "0x3C60E90", VA = "0x183C62090", Slot = "30")]
		public void HJMIDDMHEPE(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3C61080", Offset = "0x3C5FE80", VA = "0x183C61080", Slot = "31")]
		public void CAFIKGIFHPM(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3C611D0", Offset = "0x3C5FFD0", VA = "0x183C611D0", Slot = "22")]
		public BDCNBKPMJEP CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C61120", Offset = "0x3C5FF20", VA = "0x183C61120", Slot = "23")]
		public BDCNBKPMJEP CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3C620F0", Offset = "0x3C60EF0", VA = "0x183C620F0", Slot = "24")]
		public BDCNBKPMJEP INDBOJHFAIL(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3C613A0", Offset = "0x3C601A0", VA = "0x183C613A0", Slot = "25")]
		public BDCNBKPMJEP DDBABLLMGCD(AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3C60F80", Offset = "0x3C5FD80", VA = "0x183C60F80", Slot = "44")]
		public BDCNBKPMJEP BOOHNKKNADD(int ALBKKCBBEMK, PEMKGMKGDAH NFNGIKPPKJH, GameObject NCAOMIEGHPA)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3C61900", Offset = "0x3C60700", VA = "0x183C61900", Slot = "26")]
		public OEFHHNLJGLJ EPCCFBBJKBB()
		{
			return default(OEFHHNLJGLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3C61A40", Offset = "0x3C60840", VA = "0x183C61A40", Slot = "45")]
		public DAHHMEIBOMD FGEKKLAKOKM(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(DAHHMEIBOMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C62400", Offset = "0x3C61200", VA = "0x183C62400", Slot = "27")]
		public MDHBMIBEBAN KMAEBAOIOFC()
		{
			return default(MDHBMIBEBAN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3C62700", Offset = "0x3C61500", VA = "0x183C62700", Slot = "28")]
		public HEMMHNKDMJN MLJMHNFKMOG(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(HEMMHNKDMJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3C62AB0", Offset = "0x3C618B0", VA = "0x183C62AB0", Slot = "12")]
		public void MNFGPLMIANE(AIELFMMICMN CDEOFEMHEEC, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3C61B60", Offset = "0x3C60960", VA = "0x183C61B60", Slot = "13")]
		public BDCNBKPMJEP FJINJLOCNAL(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return default(BDCNBKPMJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3C62620", Offset = "0x3C61420", VA = "0x183C62620", Slot = "14")]
		public bool MAKGCDLBBBK(PMFFIMLMCEJ GMOMNBJDADO, out GEINEDFCGEN MMPEAFKIOCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3C61F80", Offset = "0x3C60D80", VA = "0x183C61F80", Slot = "46")]
		public Transform HCCGAJBGGPD(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3C62200", Offset = "0x3C61000", VA = "0x183C62200", Slot = "16")]
		public bool JIACBDMPAMB(PMFFIMLMCEJ GMOMNBJDADO, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3C62360", Offset = "0x3C61160", VA = "0x183C62360", Slot = "17")]
		public bool KFLIOAAFEFM(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3C61570", Offset = "0x3C60370", VA = "0x183C61570")]
		public bool DHANCBOLGKO(GEINEDFCGEN DFEOJBAFBHE, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3C615A0", Offset = "0x3C603A0", VA = "0x183C615A0", Slot = "47")]
		public bool DHANCBOLGKO(PMFFIMLMCEJ GMOMNBJDADO, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3C61A20", Offset = "0x3C60820", VA = "0x183C61A20", Slot = "48")]
		public void FCMOAONOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3C61C80", Offset = "0x3C60A80", VA = "0x183C61C80", Slot = "15")]
		public void FKDNCCMDFFP(GEINEDFCGEN GKCPJCKCENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3C61F20", Offset = "0x3C60D20", VA = "0x183C61F20", Slot = "49")]
		public void GKEDFHBNNKA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3C62180", Offset = "0x3C60F80", VA = "0x183C62180", Slot = "18")]
		public bool JGLLIFJLHAE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3C62CD0", Offset = "0x3C61AD0", VA = "0x183C62CD0", Slot = "19")]
		public bool PHJOIGAAGCH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3C61330", Offset = "0x3C60130", VA = "0x183C61330", Slot = "50")]
		public bool DBCMAAAEHMC(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3C622F0", Offset = "0x3C610F0", VA = "0x183C622F0", Slot = "51")]
		public bool KBKAKBBJBHI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3C619C0", Offset = "0x3C607C0", VA = "0x183C619C0", Slot = "32")]
		public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3C61290", Offset = "0x3C60090", VA = "0x183C61290", Slot = "21")]
		public AIELFMMICMN CIDLEEFEFNC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(AIELFMMICMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3C60E70", Offset = "0x3C5FC70", VA = "0x183C60E70", Slot = "20")]
		public PMFFIMLMCEJ ABIIJDLPNOE(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3C626C0", Offset = "0x3C614C0", VA = "0x183C626C0")]
		private void MKPHAPMPLFP(PEMKGMKGDAH NFNGIKPPKJH, PMFFIMLMCEJ GMOMNBJDADO, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F355F0", Offset = "0x3F343F0", VA = "0x183F355F0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3F35310", Offset = "0x3F34110", VA = "0x183F35310")]
	public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
	{
		return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3F35410", Offset = "0x3F34210", VA = "0x183F35410")]
	private void KLDGKBFOFAE(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3F34B20", Offset = "0x3F33920", VA = "0x183F34B20")]
	private void BOMFIHGAMPC(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC, int NFNGIKPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3F34990", Offset = "0x3F33790", VA = "0x183F34990")]
	private void BGMFMLHGDLB(NativeMultiHashMap<int, (PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> FGOPFKHJLPC, int NFNGIKPPKJH, PGIKEAFDIOH JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3F34FB0", Offset = "0x3F33DB0", VA = "0x183F34FB0")]
	private NativeMultiHashMap<int, (PMFFIMLMCEJ, PMFFIMLMCEJ)> DBBOOLGMANB(Allocator AEPJLHDIHPH, NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, out NativeArray<(PMFFIMLMCEJ src, PMFFIMLMCEJ dst)> LAHOBEIJIGE)
	{
		return default(NativeMultiHashMap<int, (PMFFIMLMCEJ, PMFFIMLMCEJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8B870", Offset = "0x3E8A670", VA = "0x183E8B870")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private CGJFLAGLGMG GBGKPEOJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x3E8D150", Offset = "0x3E8BF50", VA = "0x183E8D150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D040", Offset = "0x3E8BE40", VA = "0x183E8D040", Slot = "33")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A3F0", Offset = "0x3E891F0", VA = "0x183E8A3F0", Slot = "34")]
		public bool CPDDNAGIOIJ(Transform FLCFNMLPAML, out PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D470", Offset = "0x3E8C270", VA = "0x183E8D470", Slot = "35")]
		public Transform NHDJANMKOLL(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C130", Offset = "0x3E8AF30", VA = "0x183E8C130", Slot = "30")]
		public bool JIACBDMPAMB(Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B6E0", Offset = "0x3E8A4E0", VA = "0x183E8B6E0")]
		private void FFEFNBPLCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AAA0", Offset = "0x3E898A0", VA = "0x183E8AAA0", Slot = "29")]
		public void DJMPPFCPMKB(Entity IEFFOCOBJJI, out Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AE80", Offset = "0x3E89C80", VA = "0x183E8AE80", Slot = "4")]
		public void EOEAAIEBGEA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B7A0", Offset = "0x3E8A5A0", VA = "0x183E8B7A0")]
		public void GCJBMOBOFDI(Entity IEFFOCOBJJI, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK, Vector3 CGOLLDJLBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3E89B20", Offset = "0x3E88920", VA = "0x183E89B20")]
		public void BICBFAKLOLG(Entity IEFFOCOBJJI, Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ABF0", Offset = "0x3E899F0", VA = "0x183E8ABF0", Slot = "27")]
		public void DLFDFJODBHO(Entity IEFFOCOBJJI, out Matrix4x4 AIEHGIIJFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B990", Offset = "0x3E8A790", VA = "0x183E8B990")]
		public void ICGHLFAIJEP(Entity IEFFOCOBJJI, in Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CD20", Offset = "0x3E8BB20", VA = "0x183E8CD20")]
		public void MFNBAILGADD(Entity IEFFOCOBJJI, in Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C590", Offset = "0x3E8B390", VA = "0x183E8C590")]
		public void KNNABGOKBFB(Entity IEFFOCOBJJI, in Matrix4x4 CFHGHGMHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3E89380", Offset = "0x3E88180", VA = "0x183E89380", Slot = "5")]
		public void AEDOKGKNHMF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B3B0", Offset = "0x3E8A1B0", VA = "0x183E8B3B0", Slot = "6")]
		public Vector3 FDAKLDHCMFH(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B070", Offset = "0x3E89E70", VA = "0x183E8B070", Slot = "7")]
		public void EOOLKIJFFHJ(Entity IEFFOCOBJJI, Quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3E894A0", Offset = "0x3E882A0", VA = "0x183E894A0", Slot = "8")]
		public Quaternion AFCMKBPCCGH(Entity IEFFOCOBJJI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CF40", Offset = "0x3E8BD40", VA = "0x183E8CF40", Slot = "12")]
		public void MIBMKNNHFFF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C220", Offset = "0x3E8B020", VA = "0x183E8C220", Slot = "11")]
		public Vector3 JMAHNOKCJBK(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E250", Offset = "0x3E8D050", VA = "0x183E8E250")]
		public void ONKJHMFHPBJ(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C4F0", Offset = "0x3E8B2F0", VA = "0x183E8C4F0")]
		private Vector3 KGEJOEDIFKE(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B700", Offset = "0x3E8A500", VA = "0x183E8B700", Slot = "14")]
		public float FGOMGKJMJIL(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B170", Offset = "0x3E89F70", VA = "0x183E8B170", Slot = "13")]
		public void EPFPKDBDJFP(Entity IEFFOCOBJJI, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A090", Offset = "0x3E88E90", VA = "0x183E8A090")]
		private float CAIAHEGLMPL(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E2F0", Offset = "0x3E8D0F0", VA = "0x183E8E2F0")]
		public void PCMLMDPOEFD(Entity IEFFOCOBJJI, float OHEEIOFMHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C920", Offset = "0x3E8B720", VA = "0x183E8C920", Slot = "16")]
		public Vector3 LGHNHCCLLEH(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E120", Offset = "0x3E8CF20", VA = "0x183E8E120", Slot = "15")]
		public void OGHBLGNOEEM(Entity IEFFOCOBJJI, Vector3 GCMCIHOGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3E89590", Offset = "0x3E88390", VA = "0x183E89590")]
		private Vector3 AFHLNGCBJKB(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B8C0", Offset = "0x3E8A6C0", VA = "0x183E8B8C0")]
		public void HAPAEBGFHDD(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BD50", Offset = "0x3E8AB50", VA = "0x183E8BD50")]
		[Conditional("DEBUG_BUILD")]
		private void JFIAHMFEGOM(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AC00", Offset = "0x3E89A00", VA = "0x183E8AC00", Slot = "36")]
		public void DNOABEIJEJG(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C7D0", Offset = "0x3E8B5D0", VA = "0x183E8C7D0", Slot = "9")]
		public void KOIMOEHOCOB(Entity IEFFOCOBJJI, out Vector3 IJBELJOFGFA, out Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B280", Offset = "0x3E8A080", VA = "0x183E8B280", Slot = "10")]
		public void FANAHDJFCPN(Entity IEFFOCOBJJI, out Vector3 IJBELJOFGFA, out Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B4C0", Offset = "0x3E8A2C0", VA = "0x183E8B4C0", Slot = "37")]
		public void FEACFDPIMOM(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C330", Offset = "0x3E8B130", VA = "0x183E8C330")]
		public void KABEBPDPMIJ(Entity IEFFOCOBJJI, Vector3 IJBELJOFGFA, Quaternion EIGPDNIOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3E896C0", Offset = "0x3E884C0", VA = "0x183E896C0", Slot = "17")]
		public void AKLPLNGENKF(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CC40", Offset = "0x3E8BA40", VA = "0x183E8CC40", Slot = "18")]
		public Vector3 MFINHFOBLPA(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CA00", Offset = "0x3E8B800", VA = "0x183E8CA00", Slot = "19")]
		public void MAMMGLHAFED(Entity IEFFOCOBJJI, Quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A180", Offset = "0x3E88F80", VA = "0x183E8A180", Slot = "20")]
		public Quaternion CELLKLHHAFM(Entity IEFFOCOBJJI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3E89C30", Offset = "0x3E88A30", VA = "0x183E89C30", Slot = "22")]
		public void BJBCJICNPJE(Entity IEFFOCOBJJI, Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CE50", Offset = "0x3E8BC50", VA = "0x183E8CE50", Slot = "21")]
		public Vector3 MHJEBGJKDLJ(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A270", Offset = "0x3E89070", VA = "0x183E8A270", Slot = "23")]
		public void CGDKBIGBIPB(Entity IEFFOCOBJJI, float DJECIOHEFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AD60", Offset = "0x3E89B60", VA = "0x183E8AD60", Slot = "24")]
		public float DPBDAPJBLNA(Entity IEFFOCOBJJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A5B0", Offset = "0x3E893B0", VA = "0x183E8A5B0", Slot = "25")]
		public void DDDNCFMMPDC(Entity IEFFOCOBJJI, Vector3 JMOMDJGICGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D330", Offset = "0x3E8C130", VA = "0x183E8D330", Slot = "26")]
		public Vector3 MPJBDCKBJNK(Entity IEFFOCOBJJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D8D0", Offset = "0x3E8C6D0", VA = "0x183E8D8D0", Slot = "31")]
		public void NKPBMMMLJNF(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BF00", Offset = "0x3E8AD00", VA = "0x183E8BF00")]
		private PMFFIMLMCEJ JGAPMBMDNIA(Transform FLCFNMLPAML)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3E898F0", Offset = "0x3E886F0", VA = "0x183E898F0")]
		private static TransformEntity AMOIEJPHHGD(PEMKGMKGDAH IGEIBCJNCHF, GameObject JLMCLCAPEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D210", Offset = "0x3E8C010", VA = "0x183E8D210", Slot = "32")]
		public void MOPGPCGBCME(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK, Entity LCCGHHJFGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C750", Offset = "0x3E8B550", VA = "0x183E8C750")]
		private KAHCBEFNIAJ KOIMOEHOCOB(Entity IEFFOCOBJJI)
		{
			return default(KAHCBEFNIAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C050", Offset = "0x3E8AE50", VA = "0x183E8C050")]
		private bool JGPHIFFFOHJ(Entity IEFFOCOBJJI, out Entity ICMEPOIJCJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DF70", Offset = "0x3E8CD70", VA = "0x183E8DF70")]
		private void NMDECDGPLLP(Entity IEFFOCOBJJI, out Matrix4x4 MLIDICHNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D530", Offset = "0x3E8C330", VA = "0x183E8D530")]
		private void NJJMDCLHHBD(Entity IEFFOCOBJJI, out Matrix4x4 CFHGHGMHJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A3E0", Offset = "0x3E891E0", VA = "0x183E8A3E0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E08FE0", Offset = "0x3E07DE0", VA = "0x183E08FE0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3E08F70", Offset = "0x3E07D70", VA = "0x183E08F70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C24B90", Offset = "0x4C23990", VA = "0x184C24B90")]
		public OCFPLFOAJCN(GFGDPLIPMKB ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4C24B70", Offset = "0x4C23970", VA = "0x184C24B70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2521C70", Offset = "0x2520A70", VA = "0x182521C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action IMOHEMBKPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2FDF0", Offset = "0x3F2EBF0", VA = "0x183F2FDF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2FD50", Offset = "0x3F2EB50", VA = "0x183F2FD50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FD20", Offset = "0x3F2EB20", VA = "0x183F2FD20")]
	public OCFPLFOAJCN FDMPPFDLEPC()
	{
		return default(OCFPLFOAJCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xD69690", Offset = "0xD68490", VA = "0x180D69690")]
	public void OFKDPKABHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FD00", Offset = "0x3F2EB00", VA = "0x183F2FD00")]
	public void EFBCANIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2EC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A40B0", Offset = "0x8A2EB0", VA = "0x1808A40B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7ADD0", Offset = "0x3E79BD0", VA = "0x183E7ADD0")]
			public CHPBGIKBHKC(NativeArray<int> EOIEIICJLCG, NativeArray<int> JOOBOILFNKM, Dictionary<ComponentSystemBase, int> GDFCEKJMLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3E7AB50", Offset = "0x3E79950", VA = "0x183E7AB50")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public IFOKFKFAJIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4C208E0", Offset = "0x4C1F6E0", VA = "0x184C208E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4C20AB0", Offset = "0x4C1F8B0", VA = "0x184C20AB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x4C20A00", Offset = "0x4C1F800", VA = "0x184C20A00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x4C20A00", Offset = "0x4C1F800", VA = "0x184C20A00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E237E0", Offset = "0x3E225E0", VA = "0x183E237E0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E22F80", Offset = "0x3E21D80", VA = "0x183E22F80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E23010", Offset = "0x3E21E10", VA = "0x183E23010")]
		[IteratorStateMachine(typeof(IFOKFKFAJIL))]
		private IEnumerable<ComponentSystemBase> ELABNLHFDJG(int FHGIIAKFJFF, int APIEJLBIMAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E22E80", Offset = "0x3E21C80", VA = "0x183E22E80", Slot = "5")]
		public void DMHOOCIGLMM(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E231A0", Offset = "0x3E21FA0", VA = "0x183E231A0")]
		private void ELEAJINJHMG(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E230A0", Offset = "0x3E21EA0", VA = "0x183E230A0")]
		public void ELEAJINJHMG(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E23550", Offset = "0x3E22350", VA = "0x183E23550")]
		private void MBKODKCLKPG(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E22CF0", Offset = "0x3E21AF0", VA = "0x183E22CF0")]
		private void ANMLDILCJLD(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E23490", Offset = "0x3E22290", VA = "0x183E23490")]
		private void KOOEIBOLOGE(KHFGEOAKOKD IIDLBJCOLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E232F0", Offset = "0x3E220F0", VA = "0x183E232F0")]
		private void ELIGOHDACHE(int FHGIIAKFJFF, int APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E22D80", Offset = "0x3E21B80", VA = "0x183E22D80")]
		private void CFMJHACGJMJ(int FHGIIAKFJFF, int APIEJLBIMAO, bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E23470", Offset = "0x3E22270", VA = "0x183E23470")]
		private int JAFLOEJLPJI(KHFGEOAKOKD IIDLBJCOLPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E226B0", Offset = "0x3E214B0", VA = "0x183E226B0")]
		private bool ABBBJOJLPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E22E90", Offset = "0x3E21C90", VA = "0x183E22E90")]
		private Dictionary<ComponentSystemBase, int> DOJMEPKFMJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E22E40", Offset = "0x3E21C40", VA = "0x183E22E40")]
		private void COMCACEMKIL(NativeArray<int> EOIEIICJLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E22C40", Offset = "0x3E21A40", VA = "0x183E22C40")]
		private void ADBHGJHBPEG(NativeArray<int> JOOBOILFNKM, NativeArray<int> EOIEIICJLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E23410", Offset = "0x3E22210", VA = "0x183E23410")]
		private static KHFGEOAKOKD IHLMDHIGAFD(Type IGEIBCJNCHF, KHFGEOAKOKD PGBDPKDFJME)
		{
			return default(KHFGEOAKOKD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E238F0", Offset = "0x3E226F0", VA = "0x183E238F0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E233B0", Offset = "0x3E221B0", VA = "0x183E233B0")]
		[CompilerGenerated]
		private void FMLLHBEDEJP(COMOMFINKHP HLMBINIPBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E234F0", Offset = "0x3E222F0", VA = "0x183E234F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E87740", Offset = "0x3E86540", VA = "0x183E87740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool ELCLIKFJMHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3E88710", Offset = "0x3E87510", VA = "0x183E88710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool ALAFFHMPDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3E87740", Offset = "0x3E86540", VA = "0x183E87740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool NGCNLAGBKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x3E87740", Offset = "0x3E86540", VA = "0x183E87740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E87BF0", Offset = "0x3E869F0", VA = "0x183E87BF0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E885F0", Offset = "0x3E873F0", VA = "0x183E885F0", Slot = "14")]
		public void OGBGHIJCMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E87880", Offset = "0x3E86680", VA = "0x183E87880", Slot = "15")]
		public void GJMFHABAJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E877B0", Offset = "0x3E865B0", VA = "0x183E877B0", Slot = "5")]
		public void CJBJBGJOMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E87EB0", Offset = "0x3E86CB0", VA = "0x183E87EB0", Slot = "6")]
		public void NJOHPCFDKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E88030", Offset = "0x3E86E30", VA = "0x183E88030", Slot = "7")]
		public void NLPMOAPDCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E879A0", Offset = "0x3E867A0", VA = "0x183E879A0", Slot = "8")]
		public void IHJMNBEDLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E875C0", Offset = "0x3E863C0", VA = "0x183E875C0", Slot = "9")]
		public void AHFHABAIIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E881B0", Offset = "0x3E86FB0", VA = "0x183E881B0", Slot = "10")]
		public void OBOGAEJIIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E87B20", Offset = "0x3E86920", VA = "0x183E87B20", Slot = "11")]
		public void MKHMJNKCKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
		public void HLCPEAKANIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E87D60", Offset = "0x3E86B60", VA = "0x183E87D60", Slot = "12")]
		public void NBBFKLIADFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public CGJFLAGLGMG GBGKPEOJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x143A590", Offset = "0x1439390", VA = "0x18143A590", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x3E96EF0", Offset = "0x3E95CF0", VA = "0x183E96EF0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool NMMHNMGCMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x736830", Offset = "0x735630", VA = "0x180736830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E97040", Offset = "0x3E95E40", VA = "0x183E97040", Slot = "10")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E96F10", Offset = "0x3E95D10", VA = "0x183E96F10")]
		private void HJNGNBALKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E96CC0", Offset = "0x3E95AC0", VA = "0x183E96CC0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E97020", Offset = "0x3E95E20", VA = "0x183E97020", Slot = "8")]
		public ComponentSystemBase MGCDCBKMLNL(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C246A0", Offset = "0x4C234A0", VA = "0x184C246A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF30", Offset = "0x9FBD30", VA = "0x1809FCF30")]
		[DebuggerHidden]
		public NFDKGFLBEKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x4C24390", Offset = "0x4C23190", VA = "0x184C24390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4C24660", Offset = "0x4C23460", VA = "0x184C24660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4C245C0", Offset = "0x4C233C0", VA = "0x184C245C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4C245C0", Offset = "0x4C233C0", VA = "0x184C245C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F33B50", Offset = "0x3F32950", VA = "0x183F33B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<NOLDFLLDJKB> JHEPCBPDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F33840", Offset = "0x3F32640", VA = "0x183F33840", Slot = "8")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F32EB0", Offset = "0x3F31CB0", VA = "0x183F32EB0", Slot = "9")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F32FB0", Offset = "0x3F31DB0", VA = "0x183F32FB0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3F32D90", Offset = "0x3F31B90", VA = "0x183F32D90", Slot = "6")]
	public bool BDKDMMLHNEC(NOLDFLLDJKB FJONJLMIBBO, out IPECHNMOHGG JOKFNNKABBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F331D0", Offset = "0x3F31FD0", VA = "0x183F331D0")]
	private void KGDGGEMMCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F339B0", Offset = "0x3F327B0", VA = "0x183F339B0")]
	private void OLIHIJMMCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F33040", Offset = "0x3F31E40", VA = "0x183F33040")]
	private EEPMGPBIGKA GMAEIGPPALK(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F33B50", Offset = "0x3F32950", VA = "0x183F33B50")]
	private EEPMGPBIGKA PDCILNKJGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F335D0", Offset = "0x3F323D0", VA = "0x183F335D0")]
	private EEPMGPBIGKA LPFLDBJPCMI(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3F338A0", Offset = "0x3F326A0", VA = "0x183F338A0")]
	private EEPMGPBIGKA OBJKMLBENFF(string JLGENJBOGCK, string KCCFEDJJGAN, [Optional] EEPMGPBIGKA LPFFJHJDBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F33560", Offset = "0x3F32360", VA = "0x183F33560")]
	[IteratorStateMachine(typeof(NFDKGFLBEKH))]
	private IEnumerable<(string, string)> LLOMCCCOLFA(string NBGCIGJMOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3F33180", Offset = "0x3F31F80", VA = "0x183F33180")]
	private bool IIPNEAJMPFP(NOLDFLLDJKB FJONJLMIBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3F32CB0", Offset = "0x3F31AB0", VA = "0x183F32CB0")]
	private DMNOINFOIBI BAGOBHHCLIB(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x3F32ED0", Offset = "0x3F31CD0", VA = "0x183F32ED0")]
	private DMNOINFOIBI CKCAMMFPBNK(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3F32E20", Offset = "0x3F31C20", VA = "0x183F32E20")]
	private DMNOINFOIBI BDLNNGNIKCG(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A27560", Offset = "0x3A26360", VA = "0x183A27560")]
	private T EDPCACBNNON<T>(NOLDFLLDJKB FJONJLMIBBO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3F330A0", Offset = "0x3F31EA0", VA = "0x183F330A0")]
	private FieldInfo IGHLHBGGLDA(NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F33BB0", Offset = "0x3F329B0", VA = "0x183F33BB0")]
	public GNHBODHFIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F32F20", Offset = "0x3F31D20", VA = "0x183F32F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IPECHNMOHGG MGPIFHPCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<IPECHNMOHGG> EKNJPFIMDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<NOLDFLLDJKB> ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E000", Offset = "0x3E1CE00", VA = "0x183E1E000")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C221D0", Offset = "0x4C20FD0", VA = "0x184C221D0")]
			public JJGKJBNHMHO(HistoryService KGAFOEANBBF, bool NPJADAPMKIL, uint IIJDDKBOPLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4C221A0", Offset = "0x4C20FA0", VA = "0x184C221A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1E180", Offset = "0x4C1CF80", VA = "0x184C1E180")]
				public DENFOJIHLML(CAJGLGINPIC DBADFKHLJMI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x4C1CE10", Offset = "0x4C1BC10", VA = "0x184C1CE10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1CE40", Offset = "0x4C1BC40", VA = "0x184C1CE40")]
				public BPLMACLJKFK(CAJGLGINPIC DBADFKHLJMI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x4C1CE10", Offset = "0x4C1BC10", VA = "0x184C1CE10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1D560", Offset = "0x4C1C360", VA = "0x184C1D560")]
			public CAJGLGINPIC(HistoryService FHBNDHEOPHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D4E0", Offset = "0x4C1C2E0", VA = "0x184C1D4E0")]
			public bool IBGFCGLBHEJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D510", Offset = "0x4C1C310", VA = "0x184C1D510")]
			public BPLMACLJKFK MEBKBHJOELE()
			{
				return default(BPLMACLJKFK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D490", Offset = "0x4C1C290", VA = "0x184C1D490")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public EKFBANOOLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4C1EA60", Offset = "0x4C1D860", VA = "0x184C1EA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public AIBFBDCBJPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4C1BD90", Offset = "0x4C1AB90", VA = "0x184C1BD90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public DKJHPDCBEME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x4C1E280", Offset = "0x4C1D080", VA = "0x184C1E280")]
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
			[Cpp2IlInjected.Address(RVA = "0x785420", Offset = "0x784220", VA = "0x180785420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool CIKIKKFBBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x3F371C0", Offset = "0x3F35FC0", VA = "0x183F371C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool LFLPHDGCMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x3F38C30", Offset = "0x3F37A30", VA = "0x183F38C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool JHDDKNONGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x3F36FB0", Offset = "0x3F35DB0", VA = "0x183F36FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int HIOCFEEKKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3F37230", Offset = "0x3F36030", VA = "0x183F37230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int GGJPBBCJHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3F377C0", Offset = "0x3F365C0", VA = "0x183F377C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool MPHNCICJFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3F36B70", Offset = "0x3F35970", VA = "0x183F36B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool EPABDLEICAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x3F37D80", Offset = "0x3F36B80", VA = "0x183F37D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool DLDDGHBJKGG
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x849530", Offset = "0x848330", VA = "0x180849530", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xF29FA0", Offset = "0xF28DA0", VA = "0x180F29FA0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer IBDNOKDIBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3F37C90", Offset = "0x3F36A90", VA = "0x183F37C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action GAHABKKJMEH
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x3F38AB0", Offset = "0x3F378B0", VA = "0x183F38AB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x3F372F0", Offset = "0x3F360F0", VA = "0x183F372F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action DGPFFPMCCPF
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3F37F70", Offset = "0x3F36D70", VA = "0x183F37F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3F38A10", Offset = "0x3F37810", VA = "0x183F38A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3F38170", Offset = "0x3F36F70", VA = "0x183F38170", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3F37390", Offset = "0x3F36190", VA = "0x183F37390", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3F37870", Offset = "0x3F36670", VA = "0x183F37870")]
		private void GCANJAKJCLB(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3F37CA0", Offset = "0x3F36AA0", VA = "0x183F37CA0")]
		private void JDIMMFPKBDJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO ACDGNPNCEEN, PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3F38830", Offset = "0x3F37630", VA = "0x183F38830")]
		private void NNHNKAFCEIJ(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3F37CC0", Offset = "0x3F36AC0", VA = "0x183F37CC0", Slot = "14")]
		public IDisposable KGLPMCGJFLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3F37D20", Offset = "0x3F36B20", VA = "0x183F37D20", Slot = "9")]
		public IDisposable LHIJMJACOHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3F37930", Offset = "0x3F36730", VA = "0x183F37930", Slot = "6")]
		public UndoAction GJCNDKKNGGA()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3F37100", Offset = "0x3F35F00", VA = "0x183F37100", Slot = "15")]
		public RedoAction CPMFFLOLHKD()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3F37D90", Offset = "0x3F36B90", VA = "0x183F37D90", Slot = "16")]
		public UndoAction LNFCFBBFPJE()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3F36FE0", Offset = "0x3F35DE0", VA = "0x183F36FE0", Slot = "7")]
		public RedoAction CPMFFLOLHKD(UndoAction IBCPLIFFFGK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3F37E50", Offset = "0x3F36C50", VA = "0x183F37E50", Slot = "8")]
		public UndoAction LNFCFBBFPJE(RedoAction IBCPLIFFFGK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3F36EB0", Offset = "0x3F35CB0", VA = "0x183F36EB0")]
		public bool CEFCHABAGJG(IGHLDNIINHN LMCIPCHPDMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3F377E0", Offset = "0x3F365E0", VA = "0x183F377E0", Slot = "17")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3F36EF0", Offset = "0x3F35CF0", VA = "0x183F36EF0")]
		public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3F38B50", Offset = "0x3F37950", VA = "0x183F38B50")]
		public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ANLFJINAGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3F37710", Offset = "0x3F36510", VA = "0x183F37710")]
		public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3F37830", Offset = "0x3F36630", VA = "0x183F37830")]
		private void ENLOKCCHLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B80", Offset = "0x3F35980", VA = "0x183F36B80")]
		private void BLNOGLJLKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B30", Offset = "0x3F35930", VA = "0x183F36B30")]
		private void AKOOLCAOLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3F379F0", Offset = "0x3F367F0", VA = "0x183F379F0")]
		private CPEGLNOCJGF HOPKCAHHLOB()
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B50", Offset = "0x3F35950", VA = "0x183F36B50")]
		private uint AOOFGDICMPP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3F372D0", Offset = "0x3F360D0", VA = "0x183F372D0")]
		private bool DFHIEEMFFJJ(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3F37AF0", Offset = "0x3F368F0", VA = "0x183F37AF0")]
		private bool IDPOLGFHINF(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3F38680", Offset = "0x3F37480", VA = "0x183F38680")]
		private RedoAction NIJELJHFECP(CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3F38620", Offset = "0x3F37420", VA = "0x183F38620")]
		private UndoAction NECKKHMHCKE(CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3F36BC0", Offset = "0x3F359C0", VA = "0x183F36BC0")]
		private CPEGLNOCJGF BMCAJEODCKH(CPEGLNOCJGF KNOLDLABLMF, ActionBuffer EEFHJMOJPAK, bool NPJADAPMKIL)
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3F37630", Offset = "0x3F36430", VA = "0x183F37630")]
		private void EALHAGLBCNH(Action KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x369B430", Offset = "0x369A230", VA = "0x18369B430")]
		private T EALHAGLBCNH<T>(Func<T> ABAJKNEIKOD)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3F36E80", Offset = "0x3F35C80", VA = "0x183F36E80")]
		private JJGKJBNHMHO CBIEELIMJCL(bool NPJADAPMKIL, uint IIJDDKBOPLN)
		{
			return default(JJGKJBNHMHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3F38DB0", Offset = "0x3F37BB0", VA = "0x183F38DB0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3F386E0", Offset = "0x3F374E0", VA = "0x183F386E0")]
		[CompilerGenerated]
		private UndoAction NNAKGNAGILG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3F37B10", Offset = "0x3F36910", VA = "0x183F37B10")]
		[CompilerGenerated]
		private RedoAction IOBMOIMCPOC()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3F38010", Offset = "0x3F36E10", VA = "0x183F38010")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public EPLGFAIOMHP(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3E21700", Offset = "0x3E20500", VA = "0x183E21700")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public JDMFNNEOLIB(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3F3CFC0", Offset = "0x3F3BDC0", VA = "0x183F3CFC0")]
	public static JDMFNNEOLIB LFOOIECCIPM(NativeArray<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3FB35E0", Offset = "0x3FB23E0", VA = "0x183FB35E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public AIDBFOLIHEH(NativeArray<byte> DBOPJMNFJMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3E06370", Offset = "0x3E05170", VA = "0x183E06370")]
	public static AIDBFOLIHEH LFOOIECCIPM(NativeArray<byte> DBOPJMNFJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x35FC830", Offset = "0x35FB630", VA = "0x1835FC830")]
	public void JMIBPICBBFK<T>(in T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x35FC730", Offset = "0x35FB530", VA = "0x1835FC730")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F41C90", Offset = "0x3F40A90", VA = "0x183F41C90")]
	public static Span<byte> KKLCOGJIJAM(this NativeArray<byte> DBOPJMNFJMA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3F41A20", Offset = "0x3F40820", VA = "0x183F41A20")]
	public static ReadOnlySpan<byte> FFHOHNIJDJJ(this NativeArray<byte> DBOPJMNFJMA)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3F41920", Offset = "0x3F40720", VA = "0x183F41920")]
	public static NativeArray<byte> BJPMOLGEFMG(this NativeArray<byte> DBOPJMNFJMA, int FHGIIAKFJFF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3F41BA0", Offset = "0x3F409A0", VA = "0x183F41BA0")]
	public static NativeArray<byte> GPMKAMPNFLF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x36CAB00", Offset = "0x36C9900", VA = "0x1836CAB00")]
	public static NativeArray<byte> GPMKAMPNFLF<T>(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3F41C20", Offset = "0x3F40A20", VA = "0x183F41C20")]
	public static NativeArray<byte> KADJNOHLEJF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x36CAB60", Offset = "0x36C9960", VA = "0x1836CAB60")]
	public static NativeArray<byte> KADJNOHLEJF<T>(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3F419A0", Offset = "0x3F407A0", VA = "0x183F419A0")]
	public static NativeArray<byte> BMPIBIGAJBF(this NativeArray<byte> DBOPJMNFJMA, int MIOCJKOOLBL = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E200", Offset = "0x3A0D000", VA = "0x183A0E200")]
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
	[Cpp2IlInjected.Address(RVA = "0x8EAB20", Offset = "0x8E9920", VA = "0x1808EAB20")]
	public ECIJCHIDDMF(NativeList<byte> DEEJEKFIHBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DFA0", Offset = "0x3E1CDA0", VA = "0x183E1DFA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B230", Offset = "0x3C6A030", VA = "0x183C6B230")]
		public OBLIGMOAKKF.JDPFELICGMF FDMPPFDLEPC()
		{
			return default(OBLIGMOAKKF.JDPFELICGMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BA10", Offset = "0x3C6A810", VA = "0x183C6BA10", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B770", Offset = "0x3C6A570", VA = "0x183C6B770", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3C6ACE0", Offset = "0x3C69AE0", VA = "0x183C6ACE0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B270", Offset = "0x3C6A070", VA = "0x183C6B270")]
		public void GJCNDKKNGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B200", Offset = "0x3C6A000", VA = "0x183C6B200")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B660", Offset = "0x3C6A460", VA = "0x183C6B660")]
		private void MLFMBPLNLEG(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B480", Offset = "0x3C6A280", VA = "0x183C6B480")]
		private void IABNGNJBIOL(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO ACDGNPNCEEN, PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B380", Offset = "0x3C6A180", VA = "0x183C6B380")]
		private void HBNAEBDJHPL(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AF20", Offset = "0x3C69D20", VA = "0x183C6AF20")]
		private void EKKBEDKPPDM(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B530", Offset = "0x3C6A330", VA = "0x183C6B530")]
		private void LBBGJEOJNPJ(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AB80", Offset = "0x3C69980", VA = "0x183C6AB80")]
		private void BIODCEJHCND(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B9F0", Offset = "0x3C6A7F0", VA = "0x183C6B9F0")]
		private void OFKDPKABHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AF00", Offset = "0x3C69D00", VA = "0x183C6AF00")]
		private void EFBCANIPFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AC40", Offset = "0x3C69A40", VA = "0x183C6AC40")]
		private void DGHMLCNIEON(KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x44E74C0", Offset = "0x44E62C0", VA = "0x1844E74C0", Slot = "6")]
		private void KBBOGOGHKEO<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, object KPJEGNGKPOH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6BB50", Offset = "0x3C6A950", VA = "0x183C6BB50")]
		public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BB90", Offset = "0x3C6A990", VA = "0x183C6BB90")]
		public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ACDGNPNCEEN, in PEKIEJLMCEO ANLFJINAGJI, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BB70", Offset = "0x3C6A970", VA = "0x183C6BB70")]
		public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH, bool AGNNEGPIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E7C480", Offset = "0x3E7B280", VA = "0x183E7C480")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public PDCHDHAOJMP[] IOJDKJEMHNM
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x3E7C4D0", Offset = "0x3E7B2D0", VA = "0x183E7C4D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
			public IPEFFJIHFBP(ActionBuffer OKFKCFDJEGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C390", Offset = "0x3E7B190", VA = "0x183E7C390")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E7ECE0", Offset = "0x3E7DAE0", VA = "0x183E7ECE0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(KEIEEPAJBNC, string, object)> LJFFKOJPADD
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F170", Offset = "0x3E7DF70", VA = "0x183E7F170")]
			public PDCHDHAOJMP(ActionBuffer OKFKCFDJEGF, CPEGLNOCJGF KNOLDLABLMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F070", Offset = "0x3E7DE70", VA = "0x183E7F070")]
			private string OBEJBNLCOLL(KEIEEPAJBNC KNDPILCJGBD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x3E7ED30", Offset = "0x3E7DB30", VA = "0x183E7ED30")]
			private void JGMOEBJPLEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4485880", Offset = "0x4484680", VA = "0x184485880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E06C90", Offset = "0x3E05A90", VA = "0x183E06C90")]
			get
			{
				return default(HNGGECHLFOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x3E06EA0", Offset = "0x3E05CA0", VA = "0x183E06EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3E07850", Offset = "0x3E06650", VA = "0x183E07850")]
		public ActionBuffer(MKLPHIINDDK JHBPCGGOFEN, DPCIBBJGPEK JDJBDCDEPOJ, bool HBINDFILBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3E072F0", Offset = "0x3E060F0", VA = "0x183E072F0")]
		public bool HIKJHBOEDNM(out CPEGLNOCJGF KNOLDLABLMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x3E06F50", Offset = "0x3E05D50", VA = "0x183E06F50")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3E071B0", Offset = "0x3E05FB0", VA = "0x183E071B0")]
		public CPEGLNOCJGF GJCNDKKNGGA(GBGICIPJHGM PGEAEBLBOHE, OIHIOHPKDOB GDBEDAHCFGJ, uint IFPAHELFCMC)
		{
			return default(CPEGLNOCJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x3E07550", Offset = "0x3E06350", VA = "0x183E07550")]
		public bool MMMGAIDGCKM(uint IFPAHELFCMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3E06FC0", Offset = "0x3E05DC0", VA = "0x183E06FC0")]
		public bool EPCLOIMDMLD(uint IFPAHELFCMC, out CPEGLNOCJGF IBCPLIFFFGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x3E07380", Offset = "0x3E06180", VA = "0x183E07380")]
		public void IKDJMBCFKLN(CPEGLNOCJGF IBCPLIFFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x3E06B50", Offset = "0x3E05950", VA = "0x183E06B50")]
		[Conditional("DEBUG_BUILD")]
		private void AIAIIPDAAGM(CPEGLNOCJGF IBCPLIFFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3E06CD0", Offset = "0x3E05AD0", VA = "0x183E06CD0")]
		private void BMCAJEODCKH(CPEGLNOCJGF NEPNHPOCKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3E07580", Offset = "0x3E06380", VA = "0x183E07580")]
		private void OPPJEGDENAJ(JDMFNNEOLIB CIBDGPLFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3E074F0", Offset = "0x3E062F0", VA = "0x183E074F0")]
		private void LDEDGPINLKB(CPEGLNOCJGF KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3E06DE0", Offset = "0x3E05BE0", VA = "0x183E06DE0")]
		private JDMFNNEOLIB CCKDNPEJCIA(CPEGLNOCJGF KNOLDLABLMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E06EE0", Offset = "0x3E05CE0", VA = "0x183E06EE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B2C40", Offset = "0x6B1A40", VA = "0x1806B2C40")]
	public PGOKOKDBCMO(MKLPHIINDDK JHBPCGGOFEN, DPCIBBJGPEK JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x33DB120", Offset = "0x33D9F20", VA = "0x1833DB120", Slot = "4")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> EOBNNANCHLF, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C63FE0", Offset = "0x3C62DE0", VA = "0x183C63FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C21700", Offset = "0x4C20500", VA = "0x184C21700")]
		public JDPFELICGMF(OBLIGMOAKKF ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C216E0", Offset = "0x4C204E0", VA = "0x184C216E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C56220", Offset = "0x3C55020", VA = "0x183C56220")]
		get
		{
			return default(GBGICIPJHGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool JAAKCFCOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C56580", Offset = "0x3C55380", VA = "0x183C56580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C56720", Offset = "0x3C55520", VA = "0x183C56720")]
	public OBLIGMOAKKF(GBGICIPJHGM.BPAPEHLGNHK DOBAHHBACNO = GBGICIPJHGM.BPAPEHLGNHK.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C56540", Offset = "0x3C55340", VA = "0x183C56540")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C56260", Offset = "0x3C55060", VA = "0x183C56260")]
	public void CEOIJANDDEJ(AIELFMMICMN ALJACNMOIMH, NGIENACHJHK IEIGAJLABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C56690", Offset = "0x3C55490", VA = "0x183C56690")]
	public void OHNNIAFAFCJ(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C56360", Offset = "0x3C55160", VA = "0x183C56360")]
	public void EBHJJJFMEDM(AIELFMMICMN ALJACNMOIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C56590", Offset = "0x3C55390", VA = "0x183C56590")]
	public void OFKDPKABHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C56440", Offset = "0x3C55240", VA = "0x183C56440")]
	public void EFBCANIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C56350", Offset = "0x3C55150", VA = "0x183C56350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C56550", Offset = "0x3C55350", VA = "0x183C56550")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F40620", Offset = "0x3F3F420", VA = "0x183F40620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x1808E87E0")]
	public KEIEEPAJBNC(AIELFMMICMN ALJACNMOIMH, OEMFGOLGDMG DLFEJOALJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F404A0", Offset = "0x3F3F2A0", VA = "0x183F404A0")]
	public void EMHCMDMAIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F40460", Offset = "0x3F3F260", VA = "0x183F40460", Slot = "4")]
	public int CompareTo(KEIEEPAJBNC KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F40680", Offset = "0x3F3F480", VA = "0x183F40680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F40500", Offset = "0x3F3F300", VA = "0x183F40500", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3F404B0", Offset = "0x3F3F2B0", VA = "0x183F404B0", Slot = "5")]
	public bool Equals(KEIEEPAJBNC KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3F405A0", Offset = "0x3F3F3A0", VA = "0x183F405A0")]
	public static bool FHCNBCDBOFI(KEIEEPAJBNC JCHPGJLCOCJ, KEIEEPAJBNC GHMOJHOMMOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F40630", Offset = "0x3F3F430", VA = "0x183F40630")]
	public static bool LIEIJOJMABA(KEIEEPAJBNC JCHPGJLCOCJ, KEIEEPAJBNC GHMOJHOMMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F405E0", Offset = "0x3F3F3E0", VA = "0x183F405E0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F33D20", Offset = "0x3F32B20", VA = "0x183F33D20")]
		public void HJKKNDHLMHD(AIELFMMICMN ALJACNMOIMH, MKLPHIINDDK JHBPCGGOFEN, HistoryService FHBNDHEOPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F33E30", Offset = "0x3F32C30", VA = "0x183F33E30", Slot = "4")]
		private void NPIFBOGEIJG(NDPPHEAPNHN FJONJLMIBBO, in PEKIEJLMCEO DFEOJBAFBHE, object KPJEGNGKPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class EKEMCCMMODF
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E20DF0", Offset = "0x3E1FBF0", VA = "0x183E20DF0")]
	public static void LBBGJEOJNPJ(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD, NGIENACHJHK IEIGAJLABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E20EF0", Offset = "0x3E1FCF0", VA = "0x183E20EF0")]
	public static void LFDAFCACKGI(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E20C50", Offset = "0x3E1FA50", VA = "0x183E20C50")]
	public static void BIODCEJHCND(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E20D40", Offset = "0x3E1FB40", VA = "0x183E20D40")]
	public static void KACCOFCDKLC(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E20CF0", Offset = "0x3E1FAF0", VA = "0x183E20CF0")]
	public static NGIENACHJHK FDFDCKBEJME(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD)
	{
		return default(NGIENACHJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4075F70", Offset = "0x4074D70", VA = "0x184075F70")]
	public static T LKAGKPIKGOL<T>(GBGICIPJHGM PGEAEBLBOHE, KEIEEPAJBNC KNDPILCJGBD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4075F90", Offset = "0x4074D90", VA = "0x184075F90")]
	public static T LKAGKPIKGOL<T>(ref JDMFNNEOLIB FILAKGLBGGA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E20CA0", Offset = "0x3E1FAA0", VA = "0x183E20CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C1CDD0", Offset = "0x4C1BBD0", VA = "0x184C1CDD0")]
		public BKJFBPOHEIC(GBGICIPJHGM DEEJEKFIHBB, OIHIOHPKDOB GDBEDAHCFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C800", Offset = "0x4C1B600", VA = "0x184C1C800")]
		public void IFDMEPFNMHD(NativeList<byte> KJHFBEBKBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CB90", Offset = "0x4C1B990", VA = "0x184C1CB90")]
		private void NBGDCLNIHPH(KEIEEPAJBNC KNDPILCJGBD, ref AIDBFOLIHEH CKCBCCNOGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CBE0", Offset = "0x4C1B9E0", VA = "0x184C1CBE0")]
		private void PDGLNOJHNIK(KEIEEPAJBNC KNDPILCJGBD, ref AIDBFOLIHEH CKCBCCNOGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CAA0", Offset = "0x4C1B8A0", VA = "0x184C1CAA0")]
		private NativeArray<byte> LALOIFEBCKM(NativeList<byte> KJHFBEBKBIB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C4C0", Offset = "0x4C1B2C0", VA = "0x184C1C4C0")]
		private NativeArray<byte> CBCCOMIMNNO(NativeList<byte> KJHFBEBKBIB, int MFAHIHFAKKH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C5B0", Offset = "0x4C1B3B0", VA = "0x184C1C5B0")]
		private int IEIHFHJIMKH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CC70", Offset = "0x4C1BA70", VA = "0x184C1CC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C20140", Offset = "0x4C1EF40", VA = "0x184C20140")]
		internal HKFBBFGLMKO(GBGICIPJHGM DEEJEKFIHBB, KEIEEPAJBNC JFBGEPNCFEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C200A0", Offset = "0x4C1EEA0", VA = "0x184C200A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x4C20040", Offset = "0x4C1EE40", VA = "0x184C20040")]
		public void FODALFDNBDN(NativeArray<byte> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C200D0", Offset = "0x4C1EED0", VA = "0x184C200D0")]
		public void LNINOCPIKCC(NativeArray<byte> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C20130", Offset = "0x4C1EF30", VA = "0x184C20130")]
		public void PDGLNOJHNIK(in PEKIEJLMCEO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x446D330", Offset = "0x446C130", VA = "0x18446D330")]
		public void PDGLNOJHNIK<T>(T DFEOJBAFBHE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FF70", Offset = "0x4C1ED70", VA = "0x184C1FF70")]
		private void BFMFGHCBCCL(int DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FEC0", Offset = "0x4C1ECC0", VA = "0x184C1FEC0")]
		private void BFMFGHCBCCL(in PEKIEJLMCEO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FFE0", Offset = "0x4C1EDE0", VA = "0x184C1FFE0")]
		private unsafe void BFMFGHCBCCL(void* BOLLPIGIHNO, int MFAHIHFAKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x4C20040", Offset = "0x4C1EE40", VA = "0x184C20040")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C22E50", Offset = "0x4C21C50", VA = "0x184C22E50")]
		internal LCECGMGKOID(GBGICIPJHGM DEEJEKFIHBB, NativeArray<byte> FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C22B90", Offset = "0x4C21990", VA = "0x184C22B90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x4C22BA0", Offset = "0x4C219A0", VA = "0x184C22BA0")]
		public NativeArray<byte> JAAOKGGFOAC(int MFAHIHFAKKH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x4C22C60", Offset = "0x4C21A60", VA = "0x184C22C60")]
		public NativeArray<byte> LIJGMJGJGPA()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x446E2F0", Offset = "0x446D0F0", VA = "0x18446E2F0")]
		public T PEAHPJAKBCE<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x4C22D50", Offset = "0x4C21B50", VA = "0x184C22D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C21690", Offset = "0x4C20490", VA = "0x184C21690", Slot = "4")]
			get
			{
				return default(KEIEEPAJBNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x4C21650", Offset = "0x4C20450", VA = "0x184C21650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3F118B0", Offset = "0x3F106B0", VA = "0x183F118B0")]
		internal IKNCMIDMCBG(NativeList<KEIEEPAJBNC> PPLEFHADAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4C21510", Offset = "0x4C20310", VA = "0x184C21510", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4C21610", Offset = "0x4C20410", VA = "0x184C21610", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C23FD0", Offset = "0x4C22DD0", VA = "0x184C23FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int AIDNDNJDDHB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x4C23F50", Offset = "0x4C22D50", VA = "0x184C23F50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x4C23E80", Offset = "0x4C22C80", VA = "0x184C23E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public BPAPEHLGNHK CHJLLPANBAM
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x4C23FA0", Offset = "0x4C22DA0", VA = "0x184C23FA0")]
			get
			{
				return default(BPAPEHLGNHK);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x4C23F00", Offset = "0x4C22D00", VA = "0x184C23F00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool JAAKCFCOGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x4C23FB0", Offset = "0x4C22DB0", VA = "0x184C23FB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x4C23F80", Offset = "0x4C22D80", VA = "0x184C23F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool EJMHJMLDIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x4C23FC0", Offset = "0x4C22DC0", VA = "0x184C23FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x4C23F60", Offset = "0x4C22D60", VA = "0x184C23F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4C24010", Offset = "0x4C22E10", VA = "0x184C24010")]
		public LOJIIACCADF(BPAPEHLGNHK DOBAHHBACNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4C23E90", Offset = "0x4C22C90", VA = "0x184C23E90")]
		private int CIGAFCHFFML(int PNKNABOKANH, int GPDMPHJAHLC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4C23F10", Offset = "0x4C22D10", VA = "0x184C23F10")]
		private void FAFPJPFNCCD(int PNKNABOKANH, int DFEOJBAFBHE, int GPDMPHJAHLC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4C23EC0", Offset = "0x4C22CC0", VA = "0x184C23EC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2F5E0", Offset = "0x3F2E3E0", VA = "0x183F2F5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BMNPHBIFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F030", Offset = "0x3F2DE30", VA = "0x183F2F030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int AIDNDNJDDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F020", Offset = "0x3F2DE20", VA = "0x183F2F020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int GEFHGPICAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F1C0", Offset = "0x3F2DFC0", VA = "0x183F2F1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F5F0", Offset = "0x3F2E3F0", VA = "0x183F2F5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F050", Offset = "0x3F2DE50", VA = "0x183F2F050")]
	public static GBGICIPJHGM HJNGNBALKKN(BPAPEHLGNHK DOBAHHBACNO = BPAPEHLGNHK.Last, int CKGCBBOJNGO = 16, int MKPANIAACLN = 256)
	{
		return default(GBGICIPJHGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F800", Offset = "0x3F2E600", VA = "0x183F2F800")]
	private GBGICIPJHGM(BPAPEHLGNHK DOBAHHBACNO, int CKGCBBOJNGO, int MKPANIAACLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3F2ECE0", Offset = "0x3F2DAE0", VA = "0x183F2ECE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EDC0", Offset = "0x3F2DBC0", VA = "0x183F2EDC0")]
	public HKFBBFGLMKO EKKBEDKPPDM(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(HKFBBFGLMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EB10", Offset = "0x3F2D910", VA = "0x183F2EB10")]
	public LCECGMGKOID ACNKAENJBON(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(LCECGMGKOID);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F200", Offset = "0x3F2E000", VA = "0x183F2F200")]
	public bool MIPKHOAMFJL(KEIEEPAJBNC JFBGEPNCFEC, out LCECGMGKOID IGMJMLJDCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EC90", Offset = "0x3F2DA90", VA = "0x183F2EC90")]
	public bool DACELNFABBJ(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F630", Offset = "0x3F2E430", VA = "0x183F2F630")]
	public bool PKOFKKGEBLP(KEIEEPAJBNC JFBGEPNCFEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F0D0", Offset = "0x3F2DED0", VA = "0x183F2F0D0")]
	public void IJNNCGOPCBH(NativeList<byte> KJHFBEBKBIB, OIHIOHPKDOB GDBEDAHCFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A17B20", Offset = "0x3A16920", VA = "0x183A17B20")]
	public T NAGKGPCIBKK<T>(KEIEEPAJBNC JFBGEPNCFEC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EF40", Offset = "0x3F2DD40", VA = "0x183F2EF40")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F090", Offset = "0x3F2DE90", VA = "0x183F2F090")]
	public IKNCMIDMCBG HPPJKDPBNFG()
	{
		return default(IKNCMIDMCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F3F0", Offset = "0x3F2E1F0", VA = "0x183F2F3F0")]
	private void MMLNIFNNNMI(KEIEEPAJBNC JFBGEPNCFEC, int FHGIIAKFJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EE50", Offset = "0x3F2DC50", VA = "0x183F2EE50")]
	private void EMHCMDMAIBK(int NIKABAFFCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F2EBA0", Offset = "0x3F2D9A0", VA = "0x183F2EBA0")]
	private void APKIMBAIHMK(KEIEEPAJBNC JFBGEPNCFEC, int FHGIIAKFJFF, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A17AA0", Offset = "0x3A168A0", VA = "0x183A17AA0")]
	private static T NAGKGPCIBKK<T>(NativeArray<byte> DBOPJMNFJMA, int PNKNABOKANH = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F740", Offset = "0x3F2E540", VA = "0x183F2F740", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F700", Offset = "0x3F2E500", VA = "0x183F2F700", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D8A130", Offset = "0x3D88F30", VA = "0x183D8A130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A1C0", Offset = "0x3D88FC0", VA = "0x183D8A1C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A230", Offset = "0x3D89030", VA = "0x183D8A230")]
	public EJALMOLJKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0EAB0", Offset = "0x3E0D8B0", VA = "0x183E0EAB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EB50", Offset = "0x3E0D950", VA = "0x183E0EB50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3D4F0", Offset = "0x3F3C2F0", VA = "0x183F3D4F0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D540", Offset = "0x3F3C340", VA = "0x183F3D540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D5D0", Offset = "0x3F3C3D0", VA = "0x183F3D5D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public JKICMHHNALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F403F0", Offset = "0x3F3F1F0", VA = "0x183F403F0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3F40440", Offset = "0x3F3F240", VA = "0x183F40440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public KEEDAADGPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1D920", Offset = "0x3E1C720", VA = "0x183E1D920", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D970", Offset = "0x3E1C770", VA = "0x183E1D970", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DA00", Offset = "0x3E1C800", VA = "0x183E1DA00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		private readonly List<NativeListAsync<HAKDBPCBHEI>> HECABBCJCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[GNFGKNINDPI]
		private JLJEDKKMHDF JNDOBDHNDEN;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3E18130", Offset = "0x3E16F30", VA = "0x183E18130", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3E180C0", Offset = "0x3E16EC0", VA = "0x183E180C0")]
		public void GDCKDGGGFHA(NativeListAsync<HAKDBPCBHEI> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x3E17C50", Offset = "0x3E16A50", VA = "0x183E17C50")]
		public void EIHAMFJLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x3E17AE0", Offset = "0x3E168E0", VA = "0x183E17AE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x3E181D0", Offset = "0x3E16FD0", VA = "0x183E181D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C68280", Offset = "0x3C67080", VA = "0x183C68280", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x3C68320", Offset = "0x3C67120", VA = "0x183C68320", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x3C68490", Offset = "0x3C67290", VA = "0x183C68490", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3C67DC0", Offset = "0x3C66BC0", VA = "0x183C67DC0", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x3C68060", Offset = "0x3C66E60", VA = "0x183C68060", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x3C683C0", Offset = "0x3C671C0", VA = "0x183C683C0", Slot = "8")]
		public bool KGNFPLCFKLA(PMFFIMLMCEJ GMOMNBJDADO, out Collider AMDPNFGBEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x3C685B0", Offset = "0x3C673B0", VA = "0x183C685B0")]
		private void OEALKIEFBDG(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x3C681C0", Offset = "0x3C66FC0", VA = "0x183C681C0", Slot = "9")]
		public void FGEMBDECDKJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6F2B0", Offset = "0x3C6E0B0", VA = "0x183C6F2B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3C70220", Offset = "0x3C6F020", VA = "0x183C70220", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FB10", Offset = "0x3C6E910", VA = "0x183C6FB10", Slot = "6")]
		public KPOFKKHEJCB JKJNLPOJMCI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3C70AF0", Offset = "0x3C6F8F0", VA = "0x183C70AF0", Slot = "5")]
		public void PGDLPINEDOH(PMFFIMLMCEJ GMOMNBJDADO, KPOFKKHEJCB DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F250", Offset = "0x3C6E050", VA = "0x183C6F250", Slot = "34")]
		public CollisionDetectionMode GCKLEGGGPKJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F950", Offset = "0x3C6E750", VA = "0x183C6F950", Slot = "35")]
		public void JCLACKIFBGI(PMFFIMLMCEJ GMOMNBJDADO, CollisionDetectionMode DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E030", Offset = "0x3C6CE30", VA = "0x183C6E030", Slot = "36")]
		public BJLMKDOLGOG BJAJLGJALCK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(BJLMKDOLGOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E8D0", Offset = "0x3C6D6D0", VA = "0x183C6E8D0", Slot = "37")]
		public void DEDIIFAAILE(PMFFIMLMCEJ GMOMNBJDADO, BJLMKDOLGOG DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DFD0", Offset = "0x3C6CDD0", VA = "0x183C6DFD0", Slot = "38")]
		public bool BFNMHLMHHCK(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F9C0", Offset = "0x3C6E7C0", VA = "0x183C6F9C0", Slot = "39")]
		public void JDEBOCLHDMN(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FE90", Offset = "0x3C6EC90", VA = "0x183C6FE90", Slot = "40")]
		public PMFFIMLMCEJ LGNFHDEKAND(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FE10", Offset = "0x3C6EC10", VA = "0x183C6FE10", Slot = "41")]
		public void LEIFGCFKGAD(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6ED40", Offset = "0x3C6DB40", VA = "0x183C6ED40", Slot = "42")]
		public PMFFIMLMCEJ EKMEMACGALM(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F140", Offset = "0x3C6DF40", VA = "0x183C6F140", Slot = "43")]
		public void GBLKBIAEIPL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F650", Offset = "0x3C6E450", VA = "0x183C6F650", Slot = "7")]
		public void HLPNFHFHFFD(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x3C70BA0", Offset = "0x3C6F9A0", VA = "0x183C70BA0", Slot = "8")]
		public void PGODIABCAMB(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DE60", Offset = "0x3C6CC60", VA = "0x183C6DE60", Slot = "9")]
		public int APKIBECFENN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E230", Offset = "0x3C6D030", VA = "0x183C6E230", Slot = "10")]
		public PMFFIMLMCEJ CCOFDHEFLND(PMFFIMLMCEJ GMOMNBJDADO, int NPDGHPHAKDK)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EF50", Offset = "0x3C6DD50", VA = "0x183C6EF50", Slot = "11")]
		public void EPJFNIMDAHK(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F2D0", Offset = "0x3C6E0D0", VA = "0x183C6F2D0", Slot = "12")]
		public void GPALNFINBIF(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN, PMFFIMLMCEJ DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3C70130", Offset = "0x3C6EF30", VA = "0x183C70130", Slot = "13")]
		public void MJAHAPBICKL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x3C70350", Offset = "0x3C6F150", VA = "0x183C70350", Slot = "14")]
		public bool MNGDIFLMGOF(PMFFIMLMCEJ GMOMNBJDADO, out PMFFIMLMCEJ DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x3C702D0", Offset = "0x3C6F0D0", VA = "0x183C702D0", Slot = "15")]
		public void MNAJABLGAAL(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EA00", Offset = "0x3C6D800", VA = "0x183C6EA00", Slot = "16")]
		public bool DNJPCIBLNPH(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FD10", Offset = "0x3C6EB10", VA = "0x183C6FD10", Slot = "17")]
		public void KHKMDKGMOBH(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E670", Offset = "0x3C6D470", VA = "0x183C6E670", Slot = "18")]
		public bool CMINKOCEACE(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FA30", Offset = "0x3C6E830", VA = "0x183C6FA30", Slot = "26")]
		public float3 JGCCJPPGFCD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EC60", Offset = "0x3C6DA60", VA = "0x183C6EC60", Slot = "27")]
		public void DPCKOEOCFCL(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DA30", Offset = "0x3C6C830", VA = "0x183C6DA30", Slot = "28")]
		public float ACIPPEFEKMJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3C70E00", Offset = "0x3C6FC00", VA = "0x183C70E00", Slot = "29")]
		public void PMKNPGJDFNG(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DE00", Offset = "0x3C6CC00", VA = "0x183C6DE00", Slot = "30")]
		public float ANJMPDPCMFI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x3C70A80", Offset = "0x3C6F880", VA = "0x183C70A80", Slot = "31")]
		public void PFBMLJPNMDF(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x3C70A20", Offset = "0x3C6F820", VA = "0x183C70A20", Slot = "32")]
		public bool PAGLNKEOMGA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EBF0", Offset = "0x3C6D9F0", VA = "0x183C6EBF0", Slot = "33")]
		public void DONDAIPJIBM(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DF50", Offset = "0x3C6CD50", VA = "0x183C6DF50", Slot = "19")]
		public void BFJIKAMIIJF(PMFFIMLMCEJ GMOMNBJDADO, float3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x3C70850", Offset = "0x3C6F650", VA = "0x183C70850", Slot = "20")]
		public bool OJIBAKHGAKB(PMFFIMLMCEJ GMOMNBJDADO, out float3 DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x3C70750", Offset = "0x3C6F550", VA = "0x183C70750", Slot = "21")]
		public void ODHHHALHCBO(PMFFIMLMCEJ GMOMNBJDADO, quaternion DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E510", Offset = "0x3C6D310", VA = "0x183C6E510", Slot = "22")]
		public bool CIMFPJBBANB(PMFFIMLMCEJ GMOMNBJDADO, out quaternion DFEOJBAFBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DB90", Offset = "0x3C6C990", VA = "0x183C6DB90", Slot = "23")]
		public bool AIDPFAEBDNN(PMFFIMLMCEJ GMOMNBJDADO, out float3 HMDELLKKDMD, out quaternion OPDKACIDFEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FFE0", Offset = "0x3C6EDE0", VA = "0x183C6FFE0", Slot = "44")]
		public IGGCCDKGNJO MCCLOPCMAAB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(IGGCCDKGNJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F5E0", Offset = "0x3C6E3E0", VA = "0x183C6F5E0", Slot = "45")]
		public void HKDLBEJCJHB(PMFFIMLMCEJ GMOMNBJDADO, IGGCCDKGNJO DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F0B0", Offset = "0x3C6DEB0", VA = "0x183C6F0B0", Slot = "72")]
		public void FKLEAMEDKAJ(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E970", Offset = "0x3C6D770", VA = "0x183C6E970", Slot = "73")]
		public void DIMAGHMNMFL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F560", Offset = "0x3C6E360", VA = "0x183C6F560", Slot = "74")]
		public bool HFMHKCJAKON(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x3C707C0", Offset = "0x3C6F5C0", VA = "0x183C707C0", Slot = "81")]
		public void ODKCMFJFNOK(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EB60", Offset = "0x3C6D960", VA = "0x183C6EB60", Slot = "82")]
		public void DOKGNMHHIAA(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E850", Offset = "0x3C6D650", VA = "0x183C6E850", Slot = "83")]
		public bool DDIKJJLKDDL(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FC10", Offset = "0x3C6EA10", VA = "0x183C6FC10", Slot = "84")]
		public IEnumerable<object> KHJLAENAPJA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x3C70DA0", Offset = "0x3C6FBA0", VA = "0x183C70DA0", Slot = "46")]
		public bool PLNCHPBJGOO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D9D0", Offset = "0x3C6C7D0", VA = "0x183C6D9D0", Slot = "47")]
		public void ABGFCJLKAJF(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E3C0", Offset = "0x3C6D1C0", VA = "0x183C6E3C0", Slot = "48")]
		public bool CGJDAIGGEIN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x3C709B0", Offset = "0x3C6F7B0", VA = "0x183C709B0", Slot = "49")]
		public void ONPDNCGGHMK(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x3C700D0", Offset = "0x3C6EED0", VA = "0x183C700D0", Slot = "50")]
		public bool MGPBHHGHMOA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F040", Offset = "0x3C6DE40", VA = "0x183C6F040", Slot = "51")]
		public void FIBJIMFJADM(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x3C6ECE0", Offset = "0x3C6DAE0", VA = "0x183C6ECE0", Slot = "52")]
		public RigidbodyConstraints EKCICLFGJAO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DA90", Offset = "0x3C6C890", VA = "0x183C6DA90", Slot = "53")]
		public void ACPFIOJBMEL(PMFFIMLMCEJ GMOMNBJDADO, RigidbodyConstraints DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E420", Offset = "0x3C6D220", VA = "0x183C6E420", Slot = "54")]
		public float CHBHEJEGMLP(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3C705E0", Offset = "0x3C6F3E0", VA = "0x183C705E0", Slot = "55")]
		public void NGOFOMINHIA(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x3C706C0", Offset = "0x3C6F4C0", VA = "0x183C706C0", Slot = "56")]
		public float OAAKAIPADLD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3C70650", Offset = "0x3C6F450", VA = "0x183C70650", Slot = "57")]
		public void NHJABKMKICN(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x3C70D40", Offset = "0x3C6FB40", VA = "0x183C70D40", Slot = "58")]
		public bool PLJMLMEOMLA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E1C0", Offset = "0x3C6CFC0", VA = "0x183C6E1C0", Slot = "59")]
		public void BPKOEKCFJBL(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x3C704B0", Offset = "0x3C6F2B0", VA = "0x183C704B0", Slot = "60")]
		public bool MOLLAFHIGGE(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FBA0", Offset = "0x3C6E9A0", VA = "0x183C6FBA0", Slot = "61")]
		public void KAFHBCLGIJG(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E160", Offset = "0x3C6CF60", VA = "0x183C6E160", Slot = "62")]
		public int BPEJICCPBIP(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x3C70570", Offset = "0x3C6F370", VA = "0x183C70570", Slot = "63")]
		public void NGJBKBDELCO(PMFFIMLMCEJ GMOMNBJDADO, int DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F760", Offset = "0x3C6E560", VA = "0x183C6F760", Slot = "64")]
		public Rigidbody IGBEBCNCEDD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EDF0", Offset = "0x3C6DBF0", VA = "0x183C6EDF0", Slot = "65")]
		public void EOGNNLEGICC(PMFFIMLMCEJ GMOMNBJDADO, Rigidbody DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E480", Offset = "0x3C6D280", VA = "0x183C6E480", Slot = "75")]
		public void CHFCCKGMKCB(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F1C0", Offset = "0x3C6DFC0", VA = "0x183C6F1C0", Slot = "76")]
		public void GBLPAFKEPJK(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E7D0", Offset = "0x3C6D5D0", VA = "0x183C6E7D0", Slot = "77")]
		public bool DCLBPMGCAGD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x3C70040", Offset = "0x3C6EE40", VA = "0x183C70040", Slot = "66")]
		public object MCGDPEDPLMI(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F7F0", Offset = "0x3C6E5F0", VA = "0x183C6F7F0", Slot = "67")]
		public void JAMCIKOKEDK(PMFFIMLMCEJ GMOMNBJDADO, object DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E0D0", Offset = "0x3C6CED0", VA = "0x183C6E0D0", Slot = "68")]
		public object BNCBJFAECFN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F400", Offset = "0x3C6E200", VA = "0x183C6F400", Slot = "69")]
		public void HCHKLGEEEAL(PMFFIMLMCEJ GMOMNBJDADO, object DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FAB0", Offset = "0x3C6E8B0", VA = "0x183C6FAB0", Slot = "70")]
		public float JJAEGIJLPNE(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E350", Offset = "0x3C6D150", VA = "0x183C6E350", Slot = "71")]
		public void CFJKKEECEOP(PMFFIMLMCEJ GMOMNBJDADO, float DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DB00", Offset = "0x3C6C900", VA = "0x183C6DB00", Slot = "78")]
		public void AEJMHKDKBAL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x3C70CB0", Offset = "0x3C6FAB0", VA = "0x183C70CB0", Slot = "79")]
		public void PKDEHKAGOGL(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FD90", Offset = "0x3C6EB90", VA = "0x183C6FD90", Slot = "80")]
		public bool LDLNPHFEHFF(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x3C701C0", Offset = "0x3C6EFC0", VA = "0x183C701C0", Slot = "24")]
		public void MLIMBIPMNDK(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x3C70510", Offset = "0x3C6F310", VA = "0x183C70510", Slot = "25")]
		public void NCILAAKGOBA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x47E9560", Offset = "0x47E8360", VA = "0x1847E9560")]
		private void KJNHLIAGBNK<T>(PMFFIMLMCEJ GMOMNBJDADO, bool DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x47E9380", Offset = "0x47E8180", VA = "0x1847E9380")]
		private bool FPJPCKNMOJP<T>(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x47E92C0", Offset = "0x47E80C0", VA = "0x1847E92C0")]
		private void FAHLDBEBGON<T>(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x47E93E0", Offset = "0x47E81E0", VA = "0x1847E93E0")]
		private bool KFLOGKOFLIL<TC, TV>(PMFFIMLMCEJ GMOMNBJDADO, Func<TC, TV> ABAJKNEIKOD, out TV DFEOJBAFBHE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x47E9240", Offset = "0x47E8040", VA = "0x1847E9240")]
		private bool KFLOGKOFLIL<T>(PMFFIMLMCEJ GMOMNBJDADO, out T DFEOJBAFBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x47E8D30", Offset = "0x47E7B30", VA = "0x1847E8D30")]
		private T ACGOAAPFFJB<T>(PMFFIMLMCEJ GMOMNBJDADO) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x47E9C10", Offset = "0x47E8A10", VA = "0x1847E9C10")]
		private void LGMDHOFNAIM<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x47E95B0", Offset = "0x47E83B0", VA = "0x1847E95B0")]
		private void KKPFOIBBLFK<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x47E9240", Offset = "0x47E8040", VA = "0x1847E9240")]
		private bool DJONOMKPGEP<T>(PMFFIMLMCEJ GMOMNBJDADO, out T DFEOJBAFBHE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x47E9320", Offset = "0x47E8120", VA = "0x1847E9320")]
		private T FDNIFGCIJJE<T>(PMFFIMLMCEJ GMOMNBJDADO) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x47E9240", Offset = "0x47E8040", VA = "0x1847E9240")]
		private void FEOEINAMFIL<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x47EA160", Offset = "0x47E8F60", VA = "0x1847EA160")]
		private void OLJAMHBPJML<T>(PMFFIMLMCEJ GMOMNBJDADO, T DFEOJBAFBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x3C70720", Offset = "0x3C6F520", VA = "0x183C70720")]
		private PMFFIMLMCEJ OBAFGPPPDCA(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FF10", Offset = "0x3C6ED10", VA = "0x183C6FF10")]
		private DynamicBuffer<Entity> MBJMMKNKPAA(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x47E9180", Offset = "0x47E7F80", VA = "0x1847E9180")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public KELCLPBDCMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x4C22780", Offset = "0x4C21580", VA = "0x184C22780", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x4C22440", Offset = "0x4C21240", VA = "0x184C22440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x4C22800", Offset = "0x4C21600", VA = "0x184C22800")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4C22740", Offset = "0x4C21540", VA = "0x184C22740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x4C22690", Offset = "0x4C21490", VA = "0x184C22690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KPOFKKHEJCB> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x4C22690", Offset = "0x4C21490", VA = "0x184C22690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F425C0", Offset = "0x3F413C0", VA = "0x183F425C0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F424A0", Offset = "0x3F412A0", VA = "0x183F424A0")]
		public void GDCKDGGGFHA(NativeArray<Entity> BNEBECKGGLP, bool HFOHPLOHMOM, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F42200", Offset = "0x3F41000", VA = "0x183F42200")]
		public void EIHAMFJLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F42610", Offset = "0x3F41410", VA = "0x183F42610")]
		private void ODPOMDDJAOM(NativeArray<Entity> BNEBECKGGLP, bool HFOHPLOHMOM, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F42410", Offset = "0x3F41210", VA = "0x183F42410")]
		[IteratorStateMachine(typeof(KELCLPBDCMB))]
		private IEnumerable<KPOFKKHEJCB> ELKOJDHGNAN(NativeArray<Entity> BNEBECKGGLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F420B0", Offset = "0x3F40EB0", VA = "0x183F420B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F42E20", Offset = "0x3F41C20", VA = "0x183F42E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C56C80", Offset = "0x3C55A80", VA = "0x183C56C80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ONEPLGLDGPM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C56CA0", Offset = "0x3C55AA0", VA = "0x183C56CA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public ONEPLGLDGPM PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C56CA0", Offset = "0x3C55AA0", VA = "0x183C56CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C574A0", Offset = "0x3C562A0", VA = "0x183C574A0", Slot = "11")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C57180", Offset = "0x3C55F80", VA = "0x183C57180", Slot = "12")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C57200", Offset = "0x3C56000", VA = "0x183C57200")]
	private void NDGLNNEABBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x14E6350", Offset = "0x14E5150", VA = "0x1814E6350")]
	private string HINLODFBECH(string IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C570A0", Offset = "0x3C55EA0", VA = "0x183C570A0", Slot = "7")]
	public ONEPLGLDGPM MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C56DF0", Offset = "0x3C55BF0", VA = "0x183C56DF0")]
	private bool KNGJMMCCCGD(Type KKBMLPHFFPJ, string IADPDEAGFAB, out ONEPLGLDGPM DEIOLBFJFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C56CE0", Offset = "0x3C55AE0", VA = "0x183C56CE0", Slot = "8")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C56CC0", Offset = "0x3C55AC0", VA = "0x183C56CC0", Slot = "9")]
	public IEnumerator<ONEPLGLDGPM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C56CC0", Offset = "0x3C55AC0", VA = "0x183C56CC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C574F0", Offset = "0x3C562F0", VA = "0x183C574F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2B100", Offset = "0x3F29F00", VA = "0x183F2B100", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B080", Offset = "0x3F29E80", VA = "0x183F2B080", Slot = "6")]
	public bool BGGLEPHOHDG(OEMFGOLGDMG KCHLIHHPAKF, out int BDHBBDMMOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B3D0", Offset = "0x3F2A1D0", VA = "0x183F2B3D0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B0F0", Offset = "0x3F29EF0", VA = "0x183F2B0F0", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B160", Offset = "0x3F29F60", VA = "0x183F2B160")]
	private void IKOPIEDCKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B430", Offset = "0x3F2A230", VA = "0x183F2B430")]
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
		[Cpp2IlInjected.Address(RVA = "0x1327CF0", Offset = "0x1326AF0", VA = "0x181327CF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FOINMHEHJED PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D860", Offset = "0x3F3C660", VA = "0x183F3D860", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public FOINMHEHJED PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D860", Offset = "0x3F3C660", VA = "0x183F3D860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "10")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x3F3DCC0", Offset = "0x3F3CAC0", VA = "0x183F3DCC0", Slot = "11")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "12")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3F3DB90", Offset = "0x3F3C990", VA = "0x183F3DB90", Slot = "6")]
	public FOINMHEHJED MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F3DAC0", Offset = "0x3F3C8C0", VA = "0x183F3DAC0", Slot = "7")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D9E0", Offset = "0x3F3C7E0", VA = "0x183F3D9E0", Slot = "8")]
	public IEnumerator<FOINMHEHJED> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F3DF60", Offset = "0x3F3CD60", VA = "0x183F3DF60", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE110", Offset = "0x3FBCF10", VA = "0x183FBE110", Slot = "13")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D8A0", Offset = "0x3F3C6A0", VA = "0x183F3D8A0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public JLDFIMHBGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D860", Offset = "0x3F3C660", VA = "0x183F3D860")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3F2A0", Offset = "0x3F3E0A0", VA = "0x183F3F2A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public NOLDFLLDJKB PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F030", Offset = "0x3F3DE30", VA = "0x183F3F030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public NOLDFLLDJKB PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F030", Offset = "0x3F3DE30", VA = "0x183F3F030", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F690", Offset = "0x3F3E490", VA = "0x183F3F690", Slot = "9")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F040", Offset = "0x3F3DE40", VA = "0x183F3F040", Slot = "10")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F700", Offset = "0x3F3E500", VA = "0x183F3F700")]
	private NOLDFLLDJKB PEALGHEOHBP(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F570", Offset = "0x3F3E370", VA = "0x183F3F570", Slot = "6")]
	public NOLDFLLDJKB MEBAILBJFAN(ELBABKAKAAC AOKAOIOMMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F4A0", Offset = "0x3F3E2A0", VA = "0x183F3F4A0", Slot = "14")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC AOKAOIOMMBG)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F390", Offset = "0x3F3E190", VA = "0x183F3F390", Slot = "7")]
	public IEnumerator<NOLDFLLDJKB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F390", Offset = "0x3F3E190", VA = "0x183F3F390", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x39FCF20", Offset = "0x39FBD20", VA = "0x1839FCF20", Slot = "11")]
	public void MKJHLAFNNFK<TKey, T>(global::DJFCMGPMMKP<TKey, T> FJONJLMIBBO, [Optional] object KPJEGNGKPOH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F2F0", Offset = "0x3F3E0F0", VA = "0x183F3F2F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KBILICJHJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F030", Offset = "0x3F3DE30", VA = "0x183F3F030")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736700", VA = "0x180737900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F301F0", Offset = "0x3F2EFF0", VA = "0x183F301F0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F30030", Offset = "0x3F2EE30", VA = "0x183F30030")]
	private void IBGHGKLPMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x36DBDC0", Offset = "0x36DABC0", VA = "0x1836DBDC0")]
	public T NKDDKAPKFDH<T>() where T : PGIKEAFDIOH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F30120", Offset = "0x3F2EF20", VA = "0x183F30120")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F2FF60", Offset = "0x3F2ED60", VA = "0x183F2FF60")]
	public NOLDFLLDJKB CHNOAICCDFL(ELBABKAKAAC IADPDEAGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D3F0", Offset = "0x3A1C1F0", VA = "0x183A1D3F0")]
	public global::GEBDEPLDOED<T> CHNOAICCDFL<T>(ELBABKAKAAC IADPDEAGFAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FE90", Offset = "0x3F2EC90", VA = "0x183F2FE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GFKIJDOEHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class KHEEKPEKKDG
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CEC0", Offset = "0x3A0BCC0", VA = "0x183A0CEC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E049C0", Offset = "0x3E037C0", VA = "0x183E049C0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3E048A0", Offset = "0x3E036A0", VA = "0x183E048A0")]
	public void JFGJEPFBPOK(AIELFMMICMN CDEOFEMHEEC, bool GKIJPPGHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
		[DebuggerHidden]
		public LELJDLHNNGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x4C23280", Offset = "0x4C22080", VA = "0x184C23280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x4C22ED0", Offset = "0x4C21CD0", VA = "0x184C22ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x4C23300", Offset = "0x4C22100", VA = "0x184C23300")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x4C23240", Offset = "0x4C22040", VA = "0x184C23240", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x4C231B0", Offset = "0x4C21FB0", VA = "0x184C231B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x4C231B0", Offset = "0x4C21FB0", VA = "0x184C231B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3B700", Offset = "0x3F3A500", VA = "0x183F3B700", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A180", Offset = "0x3F38F80", VA = "0x183F3A180", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A4C0", Offset = "0x3F392C0", VA = "0x183F3A4C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A3B0", Offset = "0x3F391B0", VA = "0x183F3A3B0")]
	private void CNGFICGEGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B280", Offset = "0x3F3A080", VA = "0x183F3B280")]
	internal void JCDOKIFEMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B0A0", Offset = "0x3F39EA0", VA = "0x183F3B0A0")]
	private void IJJKMHNDGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A3C0", Offset = "0x3F391C0", VA = "0x183F3A3C0")]
	private void DNNAJHLHFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B6B0", Offset = "0x3F3A4B0", VA = "0x183F3B6B0")]
	[IteratorStateMachine(typeof(LELJDLHNNGA))]
	private IEnumerable<RRCustomPropTag> MJFJLDLJOOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A660", Offset = "0x3F39460", VA = "0x183F3A660")]
	private void EJEEMFGLAHI(PMFFIMLMCEJ GMOMNBJDADO, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B7D0", Offset = "0x3F3A5D0", VA = "0x183F3B7D0")]
	private void MNFGPLMIANE(SerializableGuid FBKLHONPMNF, GameObject NCAOMIEGHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AB30", Offset = "0x3F39930", VA = "0x183F3AB30")]
	private void FFAADBDDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AEC0", Offset = "0x3F39CC0", VA = "0x183F3AEC0")]
	private bool GKJNKFNPMAG(FAKHEKJICGB MOBOLDJMLON, Transform ICMEPOIJCJO, out GameObject OMPFLELLCCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AAE0", Offset = "0x3F398E0", VA = "0x183F3AAE0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B910", Offset = "0x3F3A710", VA = "0x183F3B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D8E0", Offset = "0x3C6C6E0", VA = "0x183C6D8E0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F2B4B0", Offset = "0x3F2A2B0", VA = "0x183F2B4B0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C4F030", Offset = "0x3C4DE30", VA = "0x183C4F030", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x3C4EFF0", Offset = "0x3C4DDF0", VA = "0x183C4EFF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F0A0", Offset = "0x3C4DEA0", VA = "0x183C4F0A0")]
	private void OFHLOHNGDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F0C0", Offset = "0x3C4DEC0", VA = "0x183C4F0C0")]
	private void PIJHLBBGHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F44640", Offset = "0x3F43440", VA = "0x183F44640", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public PMFFIMLMCEJ EIDOMAMADAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x3F44AF0", Offset = "0x3F438F0", VA = "0x183F44AF0", Slot = "9")]
		get
		{
			return default(PMFFIMLMCEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3F447A0", Offset = "0x3F435A0", VA = "0x183F447A0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public BDCNBKPMJEP KLILMAOCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x3F446E0", Offset = "0x3F434E0", VA = "0x183F446E0", Slot = "11")]
		get
		{
			return default(BDCNBKPMJEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3F447A0", Offset = "0x3F435A0", VA = "0x183F447A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BDCNBKPMJEP EDNNBMNIIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x3F44E30", Offset = "0x3F43C30", VA = "0x183F44E30", Slot = "13")]
		get
		{
			return default(BDCNBKPMJEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint AJIOIJHGPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3F44EF0", Offset = "0x3F43CF0", VA = "0x183F44EF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event OILFJMMGMAP DMHOOCIGLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3F456B0", Offset = "0x3F444B0", VA = "0x183F456B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x3F451D0", Offset = "0x3F43FD0", VA = "0x183F451D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x3F455E0", Offset = "0x3F443E0", VA = "0x183F455E0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x3F44950", Offset = "0x3F43750", VA = "0x183F44950", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x3F44D80", Offset = "0x3F43B80", VA = "0x183F44D80", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x3F45270", Offset = "0x3F44070", VA = "0x183F45270")]
	private void LIBMHDBLCHL(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x3F450C0", Offset = "0x3F43EC0", VA = "0x183F450C0", Slot = "14")]
	public PMFFIMLMCEJ IHGCMJMELMP(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x3F44FC0", Offset = "0x3F43DC0", VA = "0x183F44FC0", Slot = "15")]
	public bool GOHPGPBBEBL(PMFFIMLMCEJ BBDPANMBHID, PMFFIMLMCEJ PACKOPHLIKB, out PMFFIMLMCEJ OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x3F447C0", Offset = "0x3F435C0", VA = "0x183F447C0", Slot = "16")]
	public void BPDEEDEBJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x3F44FA0", Offset = "0x3F43DA0", VA = "0x183F44FA0", Slot = "17")]
	public void GLGJICACCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x3F44B90", Offset = "0x3F43990", VA = "0x183F44B90", Slot = "18")]
	public bool CLCKHCOLFEG(PMFFIMLMCEJ IBCPLIFFFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3F45470", Offset = "0x3F44270", VA = "0x183F45470")]
	private void MHMICLAEMEA(PMFFIMLMCEJ JKLFAAILIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F41FC0", Offset = "0x3F40DC0", VA = "0x183F41FC0", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x3F42040", Offset = "0x3F40E40", VA = "0x183F42040", Slot = "5")]
	public void NDHLGLINELI(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x36CC390", Offset = "0x36CB190", VA = "0x1836CC390")]
	private void FAFPJPFNCCD<T>(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E81230", Offset = "0x3E80030", VA = "0x183E81230", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3E811C0", Offset = "0x3E7FFC0", VA = "0x183E811C0", Slot = "5")]
		public void IAGNHLLEPKM(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3E81150", Offset = "0x3E7FF50", VA = "0x183E81150", Slot = "6")]
		public void APNKBCIODFM(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x36CC390", Offset = "0x36CB190", VA = "0x1836CC390")]
		private void FAFPJPFNCCD<T>(PMFFIMLMCEJ ALJACNMOIMH, bool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F2C970", Offset = "0x3F2B770", VA = "0x183F2C970", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0xE1E400", Offset = "0xE1D200", VA = "0x180E1E400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3E96AA0", Offset = "0x3E958A0", VA = "0x183E96AA0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL MPKJGFCBIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x3E95F90", Offset = "0x3E94D90", VA = "0x183E95F90", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x3E965C0", Offset = "0x3E953C0", VA = "0x183E965C0", Slot = "6")]
		public bool KABGCCDIEOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x3E96C10", Offset = "0x3E95A10", VA = "0x183E96C10", Slot = "7")]
		public bool PAAMODNKOMP(IEnumerable<JBNHJOMIEDN> LCDCNFCEDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x3E95B00", Offset = "0x3E94900", VA = "0x183E95B00", Slot = "5")]
		public ByteString CCPOABEFOJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x3E96BF0", Offset = "0x3E959F0", VA = "0x183E96BF0")]
		private void NGNKNOOOPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3E964A0", Offset = "0x3E952A0", VA = "0x183E964A0")]
		private void FJENLEOPPNH(EGLINNINABL LINDLPIKMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x3E95FC0", Offset = "0x3E94DC0", VA = "0x183E95FC0")]
		private void EPHJIJGNBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x3E967C0", Offset = "0x3E955C0", VA = "0x183E967C0")]
		private void LDHMAMDPAOM(IKONBHPFCLI LINDLPIKMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x3E96570", Offset = "0x3E95370", VA = "0x183E96570", Slot = "8")]
		public void IJMNPCGJOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3E96720", Offset = "0x3E95520", VA = "0x183E96720")]
		private EGLINNINABL LACCDJIOIOK(EntityManager DDNAAJMMFNN, EntityManager BLDEHLEAJGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E05F10", Offset = "0x3E04D10", VA = "0x183E05F10")]
	public GameObject CJGBGIFPLJG(PDAOCOFFNGC OEIOFKJKBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x3E05FE0", Offset = "0x3E04DE0", VA = "0x183E05FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E88A40", Offset = "0x3E87840", VA = "0x183E88A40")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x3E88B70", Offset = "0x3E87970", VA = "0x183E88B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool POJFIIEGDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x736830", Offset = "0x735630", VA = "0x180736830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x736B30", Offset = "0x735930", VA = "0x180736B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xF52360", Offset = "0xF51160", VA = "0x180F52360", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x3E88BF0", Offset = "0x3E879F0", VA = "0x183E88BF0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x3E88AB0", Offset = "0x3E878B0", VA = "0x183E88AB0")]
		public void FHMOEDGLOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E84D90", Offset = "0x3E83B90", VA = "0x183E84D90", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3E84BC0", Offset = "0x3E839C0", VA = "0x183E84BC0", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3E84CF0", Offset = "0x3E83AF0", VA = "0x183E84CF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3E84E00", Offset = "0x3E83C00", VA = "0x183E84E00")]
		private void NNNMGDHGBAA(Entity IEFFOCOBJJI, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F26E90", Offset = "0x3F25C90", VA = "0x183F26E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private DAFEDNGOABD JLHOGDFBIFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x3F26F80", Offset = "0x3F25D80", VA = "0x183F26F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3F26F00", Offset = "0x3F25D00", VA = "0x183F26F00", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3F26EE0", Offset = "0x3F25CE0", VA = "0x183F26EE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ABMMBFGOJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x4C1BBD0", Offset = "0x4C1A9D0", VA = "0x184C1BBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public LNHIDELIMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x4C23E20", Offset = "0x4C22C20", VA = "0x184C23E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1100", Offset = "0x9BFF00", VA = "0x1809C1100", Slot = "4")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AHBEEJODFBD MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x3C549F0", Offset = "0x3C537F0", VA = "0x183C549F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x3C548C0", Offset = "0x3C536C0", VA = "0x183C548C0", Slot = "5")]
	public void JPFKMOKBFIC(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x3C54A40", Offset = "0x3C53840", VA = "0x183C54A40", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x3C54910", Offset = "0x3C53710", VA = "0x183C54910", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x3C546B0", Offset = "0x3C534B0", VA = "0x183C546B0", Slot = "8")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x3C54790", Offset = "0x3C53590", VA = "0x183C54790", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x38A3DB0", Offset = "0x38A2BB0", VA = "0x1838A3DB0")]
	private void DEFGLDLMBIO<T>(Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x477B4D0", Offset = "0x477A2D0", VA = "0x18477B4D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x477B530", Offset = "0x477A330", VA = "0x18477B530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x477B4A0", Offset = "0x477A2A0", VA = "0x18477B4A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x459C590", Offset = "0x459B390", VA = "0x18459C590")]
	public GNNDOMKAGHE(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ, bool FJBBIADFENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x477B090", Offset = "0x4779E90", VA = "0x18477B090", Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x4001450", Offset = "0x4000250", VA = "0x184001450", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x477B0F0", Offset = "0x4779EF0", VA = "0x18477B0F0", Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x477B150", Offset = "0x4779F50", VA = "0x18477B150", Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x477B260", Offset = "0x477A060", VA = "0x18477B260", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x477B330", Offset = "0x477A130", VA = "0x18477B330", Slot = "6")]
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x477B390", Offset = "0x477A190", VA = "0x18477B390", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x477B440", Offset = "0x477A240", VA = "0x18477B440", Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x477B410", Offset = "0x477A210", VA = "0x18477B410", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x42A92B0", Offset = "0x42A80B0", VA = "0x1842A92B0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ABA080", Offset = "0x3AB8E80", VA = "0x183ABA080", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA0D0", Offset = "0x3AB8ED0", VA = "0x183ABA0D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA040", Offset = "0x3AB8E40", VA = "0x183ABA040", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x3611DE0", Offset = "0x3610BE0", VA = "0x183611DE0")]
	public DNDGNGLMMAP(Func<From, To> JLJLCNPKNHA, Func<To, From> KDMLDPACOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9C50", Offset = "0x3AB8A50", VA = "0x183AB9C50", Slot = "11")]
	public void Add(To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9C90", Offset = "0x3AB8A90", VA = "0x183AB9C90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9CD0", Offset = "0x3AB8AD0", VA = "0x183AB9CD0", Slot = "13")]
	public bool Contains(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9D90", Offset = "0x3AB8B90", VA = "0x183AB9D90", Slot = "14")]
	public void CopyTo(To[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9E50", Offset = "0x3AB8C50", VA = "0x183AB9E50", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9F10", Offset = "0x3AB8D10", VA = "0x183AB9F10", Slot = "6")]
	public int IndexOf(To LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9F80", Offset = "0x3AB8D80", VA = "0x183AB9F80", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, To LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA000", Offset = "0x3AB8E00", VA = "0x183ABA000", Slot = "15")]
	public bool Remove(To LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9FC0", Offset = "0x3AB8DC0", VA = "0x183AB9FC0", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E704E0", Offset = "0x2E6F2E0", VA = "0x182E704E0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public DGGOCMIJOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x4C1E1C0", Offset = "0x4C1CFC0", VA = "0x184C1E1C0")]
		internal void <InitServices>b__1(COMOMFINKHP svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x4C1E220", Offset = "0x4C1D020", VA = "0x184C1E220")]
		internal void <InitServices>b__2(BDDJKMOFDGN svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F31F90", Offset = "0x3F30D90", VA = "0x183F31F90")]
	public static void OHMOAAJMNJA(this AHBEEJODFBD GLPDAIBKGJO, OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A26160", Offset = "0x3A24F60", VA = "0x183A26160")]
	public static void DEFGLDLMBIO<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A266A0", Offset = "0x3A254A0", VA = "0x183A266A0")]
	public static void HPNMDCEHEGC<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A261D0", Offset = "0x3A24FD0", VA = "0x183A261D0")]
	public static void DEOLMOBBEIA<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A26840", Offset = "0x3A25640", VA = "0x183A26840")]
	public static void MHDNGOKOLOP<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A26380", Offset = "0x3A25180", VA = "0x183A26380")]
	public static void HLGMGBEBGOE<T>(this AHBEEJODFBD GLPDAIBKGJO, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A26530", Offset = "0x3A25330", VA = "0x183A26530")]
	public static void HPNMDCEHEGC<T>(IEnumerable<ComponentSystemBase> GNCNHHEOEMG, Action<T> BPIAHGDBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A269F0", Offset = "0x3A257F0", VA = "0x183A269F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F43610", Offset = "0x3F42410", VA = "0x183F43610")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public NHFDNPDFOPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C640B0", Offset = "0x3C62EB0", VA = "0x183C640B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E83E50", Offset = "0x3E82C50", VA = "0x183E83E50")]
		public static void EFMBJNCKONM(this HEGPOCOMKLM GNDGFHCLBLF, NDAGMAFOAIH DNPJACNCEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E83990", Offset = "0x3E82790", VA = "0x183E83990")]
		public static void BCFPIHPAJGO(this HEGPOCOMKLM GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E84080", Offset = "0x3E82E80", VA = "0x183E84080")]
		public static void EFMBJNCKONM(this HEGPOCOMKLM GNDGFHCLBLF, [Optional] string[] CHDEBPEGPOB, [Optional] string[] HBJKNPALEGK, [Optional] string[] HIIJLAHHCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E84190", Offset = "0x3E82F90", VA = "0x183E84190")]
		public static void FNBLCKLGPJL(this HEGPOCOMKLM GNDGFHCLBLF, params string[] JFOHECKOLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E84240", Offset = "0x3E83040", VA = "0x183E84240")]
		public static void LFKCJOCHLDA(this HEGPOCOMKLM GNDGFHCLBLF, params string[] JFOHECKOLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E83C50", Offset = "0x3E82A50", VA = "0x183E83C50")]
		private static string[] ECJGMBFJMGM(NDAGMAFOAIH DNPJACNCEDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E83A90", Offset = "0x3E82890", VA = "0x183E83A90")]
		private static bool BNOIHDNDMOH(NDAGMAFOAIH DNPJACNCEDM, out string[] PHDEHNPPPEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F2FA90", Offset = "0x3F2E890", VA = "0x183F2FA90")]
	public IOIMAGFEJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BKNNBPEHKAH();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x3F3BD50", Offset = "0x3F3AB50", VA = "0x183F3BD50")]
	public MethodInfo BHHNKIKLECN(Action KNOLDLABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F3BD90", Offset = "0x3F3AB90", VA = "0x183F3BD90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E05DE0", Offset = "0x3E04BE0", VA = "0x183E05DE0", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ABJLMKCELFF<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E05E70", Offset = "0x3E04C70", VA = "0x183E05E70")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E05F00", Offset = "0x3E04D00", VA = "0x183E05F00")]
	protected AGINDNANPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class EJMPALHMCHN : IOIMAGFEJEF
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E205C0", Offset = "0x3E1F3C0", VA = "0x183E205C0", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void APOBCKKPPBP<T>() where T : JHGAIKODJEE;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E20650", Offset = "0x3E1F450", VA = "0x183E20650")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E05F00", Offset = "0x3E04D00", VA = "0x183E05F00")]
	protected EJMPALHMCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class GCONKENLJGL : IOIMAGFEJEF
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F2F970", Offset = "0x3F2E770", VA = "0x183F2F970", Slot = "5")]
	public override Action BKNNBPEHKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void AJKAAFGKLOC<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FA00", Offset = "0x3F2E800", VA = "0x183F2FA00")]
	[Preserve]
	public void KLBKMAOOOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2FA90", Offset = "0x3F2E890", VA = "0x183F2FA90")]
	protected GCONKENLJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LCENBLDPCFF
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F43510", Offset = "0x3F42310", VA = "0x183F43510")]
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
				[Cpp2IlInjected.Address(RVA = "0x2E6E280", Offset = "0x2E6D080", VA = "0x182E6E280", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C24340", Offset = "0x4C23140", VA = "0x184C24340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DB70", Offset = "0x4C1C970", VA = "0x184C1DB70")]
			[DebuggerHidden]
			public NBFKPLNCBEH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x4C24170", Offset = "0x4C22F70", VA = "0x184C24170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x4C24300", Offset = "0x4C23100", VA = "0x184C24300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x4C24250", Offset = "0x4C23050", VA = "0x184C24250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x4C24250", Offset = "0x4C23050", VA = "0x184C24250", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2E6E280", Offset = "0x2E6D080", VA = "0x182E6E280", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C24A40", Offset = "0x4C23840", VA = "0x184C24A40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DB70", Offset = "0x4C1C970", VA = "0x184C1DB70")]
			[DebuggerHidden]
			public OAELKENFEOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x4C24A90", Offset = "0x4C23890", VA = "0x184C24A90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x4C24760", Offset = "0x4C23560", VA = "0x184C24760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x4C24B20", Offset = "0x4C23920", VA = "0x184C24B20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x4C24A00", Offset = "0x4C23800", VA = "0x184C24A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x4C24950", Offset = "0x4C23750", VA = "0x184C24950", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x4C24950", Offset = "0x4C23750", VA = "0x184C24950", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2E6E280", Offset = "0x2E6D080", VA = "0x182E6E280", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1D9B0", Offset = "0x4C1C7B0", VA = "0x184C1D9B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DB70", Offset = "0x4C1C970", VA = "0x184C1DB70")]
			[DebuggerHidden]
			public CBKIJNMDBJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DA00", Offset = "0x4C1C800", VA = "0x184C1DA00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D5A0", Offset = "0x4C1C3A0", VA = "0x184C1D5A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DAD0", Offset = "0x4C1C8D0", VA = "0x184C1DAD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DB20", Offset = "0x4C1C920", VA = "0x184C1DB20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D970", Offset = "0x4C1C770", VA = "0x184C1D970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D8D0", Offset = "0x4C1C6D0", VA = "0x184C1D8D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x4C1D8D0", Offset = "0x4C1C6D0", VA = "0x184C1D8D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A7F0", Offset = "0x3F295F0", VA = "0x183F2A7F0")]
		public static Entity MAGJHAEAOAI(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AC70", Offset = "0x3F29A70", VA = "0x183F2AC70")]
		public static DynamicBuffer<ChildrenData> PLGKICCDOKG(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A4C0", Offset = "0x3F292C0", VA = "0x183F2A4C0")]
		public static DynamicBuffer<ChildrenData> KEFLHAKPOMO(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A2E0", Offset = "0x3F290E0", VA = "0x183F2A2E0")]
		public static NativeArray<Entity> IOKEKIJMFLH(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F29ED0", Offset = "0x3F28CD0", VA = "0x183F29ED0")]
		public static bool HONEICGJHAO(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH, out NativeArray<Entity> CFAPEIBDFEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F29D70", Offset = "0x3F28B70", VA = "0x183F29D70")]
		public static NativeArray<Entity> HGDENHFMCHF(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F29590", Offset = "0x3F28390", VA = "0x183F29590")]
		public static Entity CCOFDHEFLND(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F292F0", Offset = "0x3F280F0", VA = "0x183F292F0")]
		public static int APKIBECFENN(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F298B0", Offset = "0x3F286B0", VA = "0x183F298B0")]
		public static void GFMOPDELPBL(NativeArray<Entity> JMOFNBOBEAE, NativeArray<Entity> MIHJGHDPEEA, EntityManager MKHPDCKNNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A410", Offset = "0x3F29210", VA = "0x183F2A410")]
		public static int JBGHMDGDFGD(this EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A990", Offset = "0x3F29790", VA = "0x183F2A990")]
		public static bool ONFDIBDBOKI(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A650", Offset = "0x3F29450", VA = "0x183F2A650")]
		public static IEnumerable<Entity> LHNLJGEEPBH(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A860", Offset = "0x3F29660", VA = "0x183F2A860")]
		public static bool OIGMHNPAGCC(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity ELFIACEEOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F29400", Offset = "0x3F28200", VA = "0x183F29400")]
		public static bool BNNCMPPKFKP(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity BBDPANMBHID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A0D0", Offset = "0x3F28ED0", VA = "0x183F2A0D0")]
		public static NativeList<Entity> IEEPKLPNIEF(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false, Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AAF0", Offset = "0x3F298F0", VA = "0x183F2AAF0")]
		public static IEnumerable<Entity> PICEAKMECIB(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A550", Offset = "0x3F29350", VA = "0x183F2A550")]
		public static Entity LGNFHDEKAND(this EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x3F29B10", Offset = "0x3F28910", VA = "0x183F29B10")]
		public static bool GOHPGPBBEBL(this EntityManager MKHPDCKNNBB, Entity BBDPANMBHID, Entity PACKOPHLIKB, out Entity OCIPFMKDCPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3F297A0", Offset = "0x3F285A0", VA = "0x183F297A0")]
		internal static void DPIBMKGBJOE(EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x3F29FD0", Offset = "0x3F28DD0", VA = "0x183F29FD0")]
		internal static void ICMPGCIDKJM(EntityManager MKHPDCKNNBB, Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A760", Offset = "0x3F29560", VA = "0x183F2A760")]
		[IteratorStateMachine(typeof(NBFKPLNCBEH))]
		private static IEnumerable<Entity> LLOFCNEOKMK(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3F29820", Offset = "0x3F28620", VA = "0x183F29820")]
		[IteratorStateMachine(typeof(OAELKENFEOL))]
		private static IEnumerable<Entity> ENPFGNGCADI(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A910", Offset = "0x3F29710", VA = "0x183F2A910")]
		[IteratorStateMachine(typeof(CBKIJNMDBJK))]
		private static IEnumerable<Entity> OKCBNEGAIJC(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3F296C0", Offset = "0x3F284C0", VA = "0x183F296C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public ALAPBINNPIH JHOBIIIGOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JLJEDKKMHDF MECEOFMEJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AFNBNNKFHAD GDAMCIHJNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public DOKNELGMFJP KICJEKGPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public JEAKCMCJOBO CEJNFPFMJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BCIOKJKBEBJ NJNIFJHCMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HJBNADOIEKJ FMENJHJIFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4D0", Offset = "0x6BD2D0", VA = "0x1806BE4D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public BHIIPBMPCDB NIPBBEMJDED
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7678A0", Offset = "0x7666A0", VA = "0x1807678A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public IDIHNGDEJEE EBGGDKFHAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6BF760", Offset = "0x6BE560", VA = "0x1806BF760", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public MFDIJJOFCMP ILODDHJBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x785420", Offset = "0x784220", VA = "0x180785420", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LAEEMBKBPLL AFGKCGMMBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x77D700", Offset = "0x77C500", VA = "0x18077D700", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MJGMCJFCPCM JCFDPAKBHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x77DA40", Offset = "0x77C840", VA = "0x18077DA40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public KHAPNLPCPDI ELGLAEPGDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C660", VA = "0x18077D860", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LHMGIFBKNDN NBDKJPAKGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7835B0", Offset = "0x7823B0", VA = "0x1807835B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public CHJKDGGMOBG KFNMGLHMELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x77D8C0", Offset = "0x77C6C0", VA = "0x18077D8C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DLPNOHDEIMB BOPMPJOAALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x77D880", Offset = "0x77C680", VA = "0x18077D880", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public GEKCJJABACO DLBKDKKEPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x77D820", Offset = "0x77C620", VA = "0x18077D820", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public CPAGJJIMMGO ELKFEGKPNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x77D810", Offset = "0x77C610", VA = "0x18077D810", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DACMFIPKNDK GGLLKAAOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x77D890", Offset = "0x77C690", VA = "0x18077D890", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public IGKHNFEAAFE MPJAONPNNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x77D8A0", Offset = "0x77C6A0", VA = "0x18077D8A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public HMOKJIFMIAI CDBGKLIMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6B1810", Offset = "0x6B0610", VA = "0x1806B1810", Slot = "21")]
		get
		{
			return default(HMOKJIFMIAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3F44350", Offset = "0x3F43150", VA = "0x183F44350", Slot = "22")]
	public void JPFKMOKBFIC(OKKPKCPMOFL MPKJGFCBIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x30DB2E0", Offset = "0x30DA0E0", VA = "0x1830DB2E0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3F44330", Offset = "0x3F43130", VA = "0x183F44330", Slot = "23")]
	public void DMHOOCIGLMM(OKKPKCPMOFL MPKJGFCBIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x73A2B0", Offset = "0x7390B0", VA = "0x18073A2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C269D0", Offset = "0x4C257D0", VA = "0x184C269D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
		[DebuggerHidden]
		public PLHLABIBLHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x4C26820", Offset = "0x4C25620", VA = "0x184C26820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x4C26990", Offset = "0x4C25790", VA = "0x184C26990", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x73A8B0", Offset = "0x7396B0", VA = "0x18073A8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int LLHBHAOFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x73A5F0", Offset = "0x7393F0", VA = "0x18073A5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x73A2A0", Offset = "0x7390A0", VA = "0x18073A2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BA10", Offset = "0x3F2A810", VA = "0x183F2BA10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C310", Offset = "0x3F2B110", VA = "0x183F2C310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C5E0", Offset = "0x3F2B3E0", VA = "0x183F2C5E0")]
	public FHBCPKACIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C660", Offset = "0x3F2B460", VA = "0x183F2C660")]
	public FHBCPKACIBL(int KDNFGAPAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C230", Offset = "0x3F2B030", VA = "0x183F2C230")]
	public bool ODJIALJAHHI(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BE10", Offset = "0x3F2AC10", VA = "0x183F2BE10")]
	public bool GLGGDGFLNCI(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BAB0", Offset = "0x3F2A8B0", VA = "0x183F2BAB0")]
	public bool DHNKMDBPJKM(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BBC0", Offset = "0x3F2A9C0", VA = "0x183F2BBC0")]
	public bool DOFAOAHKOHP(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C0B0", Offset = "0x3F2AEB0", VA = "0x183F2C0B0")]
	public void IBIGAGAEFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C140", Offset = "0x3F2AF40", VA = "0x183F2C140")]
	public void KNBBMABFAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BD20", Offset = "0x3F2AB20", VA = "0x183F2BD20")]
	public void FAFPJPFNCCD(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BBD0", Offset = "0x3F2A9D0", VA = "0x183F2BBD0")]
	public void EMOCNNJJBKM(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BB30", Offset = "0x3F2A930", VA = "0x183F2BB30")]
	public bool DIAPBLEJNDD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C4C0", Offset = "0x3F2B2C0", VA = "0x183F2C4C0")]
	public void PFMOMOJGLBI(int PNKNABOKANH, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B850", Offset = "0x3F2A650", VA = "0x183F2B850")]
	public void BEGIFDBPECD(int LLJOHLBBLLB, int FOPGHCLMOAD, int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BFE0", Offset = "0x3F2ADE0", VA = "0x183F2BFE0")]
	public int HMNAIPBHJIK(int MIOCJKOOLBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BF70", Offset = "0x3F2AD70", VA = "0x183F2BF70")]
	public int HMNAIPBHJIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BCD0", Offset = "0x3F2AAD0", VA = "0x183F2BCD0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BF00", Offset = "0x3F2AD00", VA = "0x183F2BF00", Slot = "4")]
	[IteratorStateMachine(typeof(PLHLABIBLHB))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BF00", Offset = "0x3F2AD00", VA = "0x183F2BF00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x299DE60", Offset = "0x299CC60", VA = "0x18299DE60")]
	public MHNBDOHJLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3814310", Offset = "0x3813110", VA = "0x183814310")]
	public MHNBDOHJLOG(global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3813C20", Offset = "0x3812A20", VA = "0x183813C20", Slot = "11")]
	public override T CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3814060", Offset = "0x3812E60", VA = "0x183814060", Slot = "12")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, T DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EMMMPLLOBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x4076F10", Offset = "0x4075D10", VA = "0x184076F10")]
	public static OEMFGOLGDMG MNFGPLMIANE<T>(this OBCIKAMHODM JDJBDCDEPOJ, global::KBOIOIDENFM<T> IADPDEAGFAB, global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE) where T : struct
	{
		return default(OEMFGOLGDMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class DHBOBEFNCKC<T> : global::MHNBDOHJLOG<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFF00", Offset = "0x3AAED00", VA = "0x183AAFF00")]
	public DHBOBEFNCKC(T AJMPIJJCLNC, T JFFGPOOCEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class BIADNFMMLDL<T> : global::AGGGPMKCIOC<T> where T : struct, JHGAIKODJEE
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7480", Offset = "0x3BE6280", VA = "0x183BE7480", Slot = "11")]
	public override T CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7560", Offset = "0x3BE6360", VA = "0x183BE7560", Slot = "12")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x3853740", Offset = "0x3852540", VA = "0x183853740")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FF4610", Offset = "0x3FF3410", VA = "0x183FF4610", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FF3F30", Offset = "0x3FF2D30", VA = "0x183FF3F30", Slot = "8")]
	public override void CJKIJAOEIBM(AGINBCFDEDM INFJLMMKNPA, in MELHFKPCLBG IBCPLIFFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF52B0", Offset = "0x3FF40B0", VA = "0x183FF52B0", Slot = "9")]
	public override void PNKNJNLKBEB(AGINBCFDEDM INFJLMMKNPA, in PEKIEJLMCEO JFBGEPNCFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3540", Offset = "0x3FF2340", VA = "0x183FF3540", Slot = "10")]
	public override void ALPKNKNFCBE(AGINBCFDEDM INFJLMMKNPA, AGOFGGGPNPC BAHONECJAGF, object KPJEGNGKPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790")]
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
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public OCNNIDIJOPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x3BC8ED0", Offset = "0x3BC7CD0", VA = "0x183BC8ED0")]
			internal void <RegisterFixedString>b__0(AGINBCFDEDM p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x3BC92E0", Offset = "0x3BC80E0", VA = "0x183BC92E0")]
			internal T <RegisterFixedString>b__1(AGINBCFDEDM p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AF90", Offset = "0x3E79D90", VA = "0x183E7AF90")]
		public static void GJGDMAHCJAG(MEJLDDCCOEN BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x446C130", Offset = "0x446AF30", VA = "0x18446C130")]
		private static void FNGFPIFAJIB<T>(MEJLDDCCOEN BMNJABIDNBC, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x446C250", Offset = "0x446B050", VA = "0x18446C250")]
		private static void GHKMCGKGADH<T>(AGINBCFDEDM ONINKGDNEEG, T BGLBBPFJJCJ, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x446C2E0", Offset = "0x446B0E0", VA = "0x18446C2E0")]
		private static T KHFLBCIDKPK<T>(AGINBCFDEDM ONINKGDNEEG, int JFFGPOOCEHG) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x446BF70", Offset = "0x446AD70", VA = "0x18446BF70", Slot = "6")]
		public override void ABJLMKCELFF<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AED0", Offset = "0x3E79CD0", VA = "0x183E7AED0")]
		public static void EGJPKMMLEJC(MEJLDDCCOEN BMNJABIDNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AF80", Offset = "0x3E79D80", VA = "0x183E7AF80")]
		public DAIJHEOGKEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x3E1A720", Offset = "0x3E19520", VA = "0x183E1A720")]
	public static void HGMCEGHOEPL(MEJLDDCCOEN BMNJABIDNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x3D04C50", Offset = "0x3D03A50", VA = "0x183D04C50")]
	public static void LKDFGHCAFND<T>(MEJLDDCCOEN BMNJABIDNBC, global::AFGGCKFKJIL<T> GFCAPLHGOPK, global::DLMPCLMCJDM<T> CODKEDJGDDE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x3D04BE0", Offset = "0x3D039E0", VA = "0x183D04BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E058E0", Offset = "0x3E046E0", VA = "0x183E058E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C652D0", Offset = "0x3C640D0", VA = "0x183C652D0")]
	public PNPCEOCBIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C65350", Offset = "0x3C64150", VA = "0x183C65350")]
	public PNPCEOCBIMC(Dictionary<OEMFGOLGDMG, OIJLHFGLBPH> BMNJABIDNBC, bool FHNOIGDJPEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C65270", Offset = "0x3C64070", VA = "0x183C65270", Slot = "7")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C65080", Offset = "0x3C63E80", VA = "0x183C65080", Slot = "8")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C64CD0", Offset = "0x3C63AD0", VA = "0x183C64CD0", Slot = "9")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C64D20", Offset = "0x3C63B20", VA = "0x183C64D20", Slot = "4")]
	public OEMFGOLGDMG HHGGFOMNIKM(ELBABKAKAAC IADPDEAGFAB)
	{
		return default(OEMFGOLGDMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C65100", Offset = "0x3C63F00", VA = "0x183C65100", Slot = "5")]
	public void MNFGPLMIANE(OEMFGOLGDMG KCHLIHHPAKF, OIJLHFGLBPH PPBHALAGCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C64B90", Offset = "0x3C63990", VA = "0x183C64B90")]
	[Conditional("DEBUG_BUILD")]
	private void AHJHACPLCOB(OEMFGOLGDMG KCHLIHHPAKF, Type IGEIBCJNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C64ED0", Offset = "0x3C63CD0", VA = "0x183C64ED0", Slot = "6")]
	public bool MDMOKHFDALA(OEMFGOLGDMG KCHLIHHPAKF, out OIJLHFGLBPH PPBHALAGCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C64DF0", Offset = "0x3C63BF0", VA = "0x183C64DF0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x736830", Offset = "0x735630", VA = "0x180736830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x736B30", Offset = "0x735930", VA = "0x180736B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E880", Offset = "0x3E8D680", VA = "0x183E8E880")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E900", Offset = "0x3E8D700", VA = "0x183E8E900")]
		public TypeSerializerService(Dictionary<Type, OIJLHFGLBPH> BMNJABIDNBC, bool FHNOIGDJPEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E7D0", Offset = "0x3E8D5D0", VA = "0x183E8E7D0", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E6B0", Offset = "0x3E8D4B0", VA = "0x183E8E6B0", Slot = "5")]
		public void MNFGPLMIANE(Type IGEIBCJNCHF, OIJLHFGLBPH PPBHALAGCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E5D0", Offset = "0x3E8D3D0", VA = "0x183E8E5D0", Slot = "6")]
		public bool MDMOKHFDALA(Type IGEIBCJNCHF, out OIJLHFGLBPH PPBHALAGCOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E4F0", Offset = "0x3E8D2F0", VA = "0x183E8E4F0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C54060", Offset = "0x3C52E60", VA = "0x183C54060", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C53F90", Offset = "0x3C52D90", VA = "0x183C53F90", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C53FF0", Offset = "0x3C52DF0", VA = "0x183C53FF0", Slot = "4")]
	public void MNFGPLMIANE(OEMFGOLGDMG DLFEJOALJGM, Type KJBCODGFBDC, NGMECMFEEPK KKFPGOCIING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C53F20", Offset = "0x3C52D20", VA = "0x183C53F20", Slot = "5")]
	public bool ACMGIDOBIEM(OEMFGOLGDMG DLFEJOALJGM, out NGMECMFEEPK KKFPGOCIING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C540B0", Offset = "0x3C52EB0", VA = "0x183C540B0")]
	[Conditional("DEBUG_BUILD")]
	private void PBNHGOOLLKF(OEMFGOLGDMG DLFEJOALJGM, Type KJBCODGFBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C54240", Offset = "0x3C53040", VA = "0x183C54240")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F32390", Offset = "0x3F31190", VA = "0x183F32390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool LCHELPOHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x836410", Offset = "0x835210", VA = "0x180836410", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x836290", Offset = "0x835090", VA = "0x180836290", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F323E0", Offset = "0x3F311E0", VA = "0x183F323E0", Slot = "6")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F32A50", Offset = "0x3F31850", VA = "0x183F32A50", Slot = "7")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x3F322E0", Offset = "0x3F310E0", VA = "0x183F322E0", Slot = "8")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3F32870", Offset = "0x3F31670", VA = "0x183F32870")]
	private void KBGDDFDNCBC(PMFFIMLMCEJ GMOMNBJDADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3F32910", Offset = "0x3F31710", VA = "0x183F32910", Slot = "4")]
	public bool MHHFAKHKBJJ(AIELFMMICMN CDEOFEMHEEC, OEMFGOLGDMG FJONJLMIBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3F32520", Offset = "0x3F31320", VA = "0x183F32520", Slot = "5")]
	public void HNCGHBNHCBA(AIELFMMICMN CDEOFEMHEEC, Span<OEMFGOLGDMG> JDJBDCDEPOJ, bool EPGOJCBLBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F323E0", Offset = "0x3F311E0", VA = "0x183F323E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F32AD0", Offset = "0x3F318D0", VA = "0x183F32AD0")]
	public GMLEHANOGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class AFFBNPIAHOM
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E05C10", Offset = "0x3E04A10", VA = "0x183E05C10")]
	public static void IDENMLGOFHB(this AGINBCFDEDM INFJLMMKNPA, ReadOnlyMemory<byte> FFPKNKEACPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x35F89B0", Offset = "0x35F77B0", VA = "0x1835F89B0")]
	public static void AOMBALNDCDK<T>(this AGINBCFDEDM INFJLMMKNPA, in T DFEOJBAFBHE) where T : struct, JHGAIKODJEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x35F8AE0", Offset = "0x35F78E0", VA = "0x1835F8AE0")]
	public static T LLEHKKLGDKD<T>(this AGINBCFDEDM INFJLMMKNPA) where T : struct, JHGAIKODJEE
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E05A30", Offset = "0x3E04830", VA = "0x183E05A30")]
	public static void AOMBALNDCDK(this AGINBCFDEDM INFJLMMKNPA, GNADOFADBFA KHHCHKEIKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E05C90", Offset = "0x3E04A90", VA = "0x183E05C90")]
	public static GNADOFADBFA IINAGFAHFBO(this AGINBCFDEDM INFJLMMKNPA)
	{
		return default(GNADOFADBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E05A60", Offset = "0x3E04860", VA = "0x183E05A60")]
	public static void GHLDLHMAHNN(this AGINBCFDEDM GAKCPFEFIJJ, uint CCMCDGFOLOD, bool HDDAGFDDALC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E05CC0", Offset = "0x3E04AC0", VA = "0x183E05CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public FAKDCNBEDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x37C8C70", Offset = "0x37C7A70", VA = "0x1837C8C70")]
		internal void <GetByteEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x37C8CE0", Offset = "0x37C7AE0", VA = "0x1837C8CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public OIOCBIIOBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x39C7590", Offset = "0x39C6390", VA = "0x1839C7590")]
		internal void <GetSByteEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x39C7600", Offset = "0x39C6400", VA = "0x1839C7600")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public HHEACIKECGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B11660", Offset = "0x3B10460", VA = "0x183B11660")]
		internal void <GetShortEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3B116D0", Offset = "0x3B104D0", VA = "0x183B116D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public DKBPNDIOIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3290", Offset = "0x3AB2090", VA = "0x183AB3290")]
		internal void <GetUShortEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3300", Offset = "0x3AB2100", VA = "0x183AB3300")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public BMKAGKEDENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x489D710", Offset = "0x489C510", VA = "0x18489D710")]
		internal void <GetIntEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x489D770", Offset = "0x489C570", VA = "0x18489D770")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public MPIPAECLCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x42602B0", Offset = "0x425F0B0", VA = "0x1842602B0")]
		internal void <GetUIntEnumDelegates>b__0(AGINBCFDEDM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x4260310", Offset = "0x425F110", VA = "0x184260310")]
		internal T <GetUIntEnumDelegates>b__1(AGINBCFDEDM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A29EE0", Offset = "0x3A28CE0", VA = "0x183A29EE0")]
	public static void PJHPOEDPHAP<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A29AF0", Offset = "0x3A288F0", VA = "0x183A29AF0")]
	private static void BBEJNLDDDDF<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A29AF0", Offset = "0x3A288F0", VA = "0x183A29AF0")]
	private static void MPJDBLBAFBF<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A29C40", Offset = "0x3A28A40", VA = "0x183A29C40")]
	private static void EPCNHLBNBEL<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A29C40", Offset = "0x3A28A40", VA = "0x183A29C40")]
	private static void LAMEMNNBEPM<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A29D90", Offset = "0x3A28B90", VA = "0x183A29D90")]
	private static void EPPJAKECMED<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A29D90", Offset = "0x3A28B90", VA = "0x183A29D90")]
	private static void MPMBNEHFOBP<T>(T AJMPIJJCLNC, T JFFGPOOCEHG, out global::AFGGCKFKJIL<T> GJPFKPOLDIF, out global::DLMPCLMCJDM<T> BDDHAEICBFO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class BLFFKOKMHAL : MAAAHNNGDPO, BDDJKMOFDGN
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E09B60", Offset = "0x3E08960", VA = "0x183E09B60", Slot = "4")]
	private void LBHGPOAHGNB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LCPPLAMNAHP(OBCIKAMHODM JDJBDCDEPOJ);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
	protected BLFFKOKMHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ILPFPDPNEBP(typeof(LocalPoseData))]
public sealed class OPIABACGHAB : BLFFKOKMHAL
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x3C57740", Offset = "0x3C56540", VA = "0x183C57740", Slot = "5")]
	protected override void LCPPLAMNAHP(OBCIKAMHODM JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E15100", Offset = "0x3E13F00", VA = "0x183E15100", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E15320", Offset = "0x3E14120", VA = "0x183E15320", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E154A0", Offset = "0x3E142A0", VA = "0x183E154A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E15470", Offset = "0x3E14270", VA = "0x183E15470", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E14CE0", Offset = "0x3E13AE0", VA = "0x183E14CE0")]
		private void HPLDDOPGLEJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E14650", Offset = "0x3E13450", VA = "0x183E14650")]
		private void ADLAMFBLCBI(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E147F0", Offset = "0x3E135F0", VA = "0x183E147F0")]
		private void AOMEGMOOHCA(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E15170", Offset = "0x3E13F70", VA = "0x183E15170")]
		private void NBNODMLDOGB(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E14AD0", Offset = "0x3E138D0", VA = "0x183E14AD0")]
		private void BEIAGKCNPMD(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E15020", Offset = "0x3E13E20", VA = "0x183E15020")]
		private void LGEPMIOMCBC(PMFFIMLMCEJ GMOMNBJDADO, int IFEILBLHHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3F930", Offset = "0x3F3E730", VA = "0x183F3F930", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F3FF60", Offset = "0x3F3ED60", VA = "0x183F3FF60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x3F40020", Offset = "0x3F3EE20", VA = "0x183F40020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F980", Offset = "0x3F3E780", VA = "0x183F3F980")]
	private void OAJODGFGBPM(NativeArray<Entity> BNEBECKGGLP, NativeList<Entity> HECABBCJCKD, ComponentDataFromEntity<JEFKALPCHJH> LICDJNDNDJK, BufferFromEntity<ChildrenData> CMFGHFEEBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public KDDGAFHJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class EAHJJDHMJFG : ParentSystemBase<AuthoredParentData, CMKCMMGCODO, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DEE0", Offset = "0x3E1CCE0", VA = "0x183E1DEE0", Slot = "14")]
	protected override EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x817E20", Offset = "0x816C20", VA = "0x180817E20", Slot = "15")]
	protected override EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DEA0", Offset = "0x3E1CCA0", VA = "0x183E1DEA0", Slot = "16")]
	protected override EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DE60", Offset = "0x3E1CC60", VA = "0x183E1DE60", Slot = "17")]
	protected override EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DF60", Offset = "0x3E1CD60", VA = "0x183E1DF60")]
	public EAHJJDHMJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DF20", Offset = "0x3E1CD20", VA = "0x183E1DF20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E1A380", Offset = "0x3E19180", VA = "0x183E1A380", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x3E1A400", Offset = "0x3E19200", VA = "0x183E1A400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1A4A0", Offset = "0x3E192A0", VA = "0x183E1A4A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public DIMCHFHJAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E05540", Offset = "0x3E04340", VA = "0x183E05540", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x3E055C0", Offset = "0x3E043C0", VA = "0x183E055C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x3E05660", Offset = "0x3E04460", VA = "0x183E05660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public AEHIIPEENNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3F8E0", Offset = "0x3F3E6E0", VA = "0x183F3F8E0", Slot = "4")]
	public bool Equals(KCLMHFFOANM KICLNADFIEK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90")]
	public static DMDIEKGLKBI LFOOIECCIPM(KEOMFONJOJH DCLMHANFEGK)
	{
		return default(DMDIEKGLKBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class LBEDOOFEKFO : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x3F432E0", Offset = "0x3F420E0", VA = "0x183F432E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x3F43470", Offset = "0x3F42270", VA = "0x183F43470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	protected LBEDOOFEKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3E4F0", Offset = "0x3F3D2F0", VA = "0x183F3E4F0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x3F3DF80", Offset = "0x3F3CD80", VA = "0x183F3DF80")]
	protected void BKEDNLGMILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x3F3E270", Offset = "0x3F3D070", VA = "0x183F3E270")]
	protected void HBEIGBNPLOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3F3E200", Offset = "0x3F3D000", VA = "0x183F3E200")]
	protected CIMNJIOJIIP EMCOOIHDBGP()
	{
		return default(CIMNJIOJIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	protected JLLPLKHKBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class NEGGDLIOOMB : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x3C54B70", Offset = "0x3C53970", VA = "0x183C54B70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x3C54D00", Offset = "0x3C53B00", VA = "0x183C54D00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3C54DA0", Offset = "0x3C53BA0", VA = "0x183C54DA0")]
	protected NEGGDLIOOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class FPOFKLIIBEE : JLLPLKHKBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DDF0", Offset = "0x3F2CBF0", VA = "0x183F2DDF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x3F2DF00", Offset = "0x3F2CD00", VA = "0x183F2DF00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	protected FPOFKLIIBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2FB40", Offset = "0x3F2E940", VA = "0x183F2FB40", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public GDDCKGDKLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F32C30", Offset = "0x3F31A30", VA = "0x183F32C30", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x3F32CA0", Offset = "0x3F31AA0", VA = "0x183F32CA0")]
	public GMOGIPDPHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E063D0", Offset = "0x3E051D0", VA = "0x183E063D0", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3C54DA0", Offset = "0x3C53BA0", VA = "0x183C54DA0")]
	public ANCHBAJCLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3E5D0", Offset = "0x3F3D3D0", VA = "0x183F3E5D0", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public JMGDMDHGGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3E560", Offset = "0x3F3D360", VA = "0x183F3E560", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x3F32CA0", Offset = "0x3F31AA0", VA = "0x183F32CA0")]
	public JLMNPLMGKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2DD80", Offset = "0x3F2CB80", VA = "0x183F2DD80", Slot = "15")]
		get
		{
			return default(FGKJJIHFJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public FNHKDFACJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F2B750", Offset = "0x3F2A550", VA = "0x183F2B750")]
	public FGKJJIHFJDO(ComponentType JCHPDENPJBC, ComponentType IPNLFJPKKOM, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E520", Offset = "0x3A0D320", VA = "0x183A0E520")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91DDB0", VA = "0x18091EFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x9FD200", Offset = "0x9FC000", VA = "0x1809FD200", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x9FD210", Offset = "0x9FC010", VA = "0x1809FD210", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool DOFAOAHKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3F40740", Offset = "0x3F3F540", VA = "0x183F40740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F8E0", Offset = "0x3F3E6E0", VA = "0x183F3F8E0", Slot = "8")]
	public bool Equals(KEOMFONJOJH KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x3F40780", Offset = "0x3F3F580", VA = "0x183F40780", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C22EB0", Offset = "0x4C21CB0", VA = "0x184C22EB0")]
			public LCNIHBLPIPJ(KEOMFONJOJH DCLMHANFEGK, float3 IJBELJOFGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x4C22E90", Offset = "0x4C21C90", VA = "0x184C22E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
			public JCALFAFDBBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
			public EIGEOPMDOAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
			public GIDNDLCODMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1FD60", Offset = "0x4C1EB60", VA = "0x184C1FD60")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x4C1FCA0", Offset = "0x4C1EAA0", VA = "0x184C1FCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C20B60", Offset = "0x4C1F960", VA = "0x184C20B60")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, WorldPoseData JLELBDHDMMK, in DynamicBuffer<DMDIEKGLKBI> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x4C21000", Offset = "0x4C1FE00", VA = "0x184C21000", Slot = "5")]
			public void ReadFromDisplayClass(ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x4C21030", Offset = "0x4C1FE30", VA = "0x184C21030", Slot = "6")]
			public void WriteToDisplayClass(ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x4C20DA0", Offset = "0x4C1FBA0", VA = "0x184C20DA0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x4C20E80", Offset = "0x4C1FC80", VA = "0x184C20E80")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref HFBNKBKHNNN.DJHPAJFOECE MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x4C20FC0", Offset = "0x4C1FDC0", VA = "0x184C20FC0")]
			public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM, ref JCALFAFDBBP ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x4C20AF0", Offset = "0x4C1F8F0", VA = "0x184C20AF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C263B0", Offset = "0x4C251B0", VA = "0x184C263B0")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x4C26310", Offset = "0x4C25110", VA = "0x184C26310")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C20590", Offset = "0x4C1F390", VA = "0x184C20590")]
			internal void EACJNOHFKHL(in WorldPoseData JLELBDHDMMK, in DynamicBuffer<KCLMHFFOANM> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D4B0", VA = "0x180E1E6B0", Slot = "5")]
			public void ReadFromDisplayClass(ref EIGEOPMDOAE ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x4C206A0", Offset = "0x4C1F4A0", VA = "0x184C206A0", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x4C20770", Offset = "0x4C1F570", VA = "0x184C20770")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref PGHCHHNCEAI.EMPOFFOONLJ MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x4C20840", Offset = "0x4C1F640", VA = "0x184C20840")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1BD00", Offset = "0x4C1AB00", VA = "0x184C1BD00")]
				public void JCIHNCONGGN(UpdateConnectableVisuals MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x4C1BC30", Offset = "0x4C1AA30", VA = "0x184C1BC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C21810", Offset = "0x4C20610", VA = "0x184C21810")]
			internal void EACJNOHFKHL(in WorldPoseData JLELBDHDMMK, in LNABMIPCKIO EAFAMHNKMAN, in DynamicBuffer<KCLMHFFOANM> IDIIBDOHICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D4B0", VA = "0x180E1E6B0", Slot = "5")]
			public void ReadFromDisplayClass(ref GIDNDLCODMD ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x4C21970", Offset = "0x4C20770", VA = "0x184C21970", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x4C219F0", Offset = "0x4C207F0", VA = "0x184C219F0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref AGKIADCAONN.OHLMFMGCGOM MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x4C21B10", Offset = "0x4C20910", VA = "0x184C21B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8FEC0", Offset = "0x3E8ECC0", VA = "0x183E8FEC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F7F0", Offset = "0x3E8E5F0", VA = "0x183E8F7F0")]
		internal AKFIDAIPMLM AJCANACNOFA(KEOMFONJOJH DCLMHANFEGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x3E91530", Offset = "0x3E90330", VA = "0x183E91530", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x3E91D80", Offset = "0x3E90B80", VA = "0x183E91D80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x3E92000", Offset = "0x3E90E00", VA = "0x183E92000", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x3E92190", Offset = "0x3E90F90", VA = "0x183E92190", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x3E91FC0", Offset = "0x3E90DC0", VA = "0x183E91FC0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x3E93BA0", Offset = "0x3E929A0", VA = "0x183E93BA0")]
		private void POCNMCEHADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x3E91170", Offset = "0x3E8FF70", VA = "0x183E91170")]
		private void MAAJJOGKAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x3E905C0", Offset = "0x3E8F3C0", VA = "0x183E905C0")]
		private void FJGKBGPNAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x3E921D0", Offset = "0x3E90FD0", VA = "0x183E921D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x3E92BB0", Offset = "0x3E919B0", VA = "0x183E92BB0")]
		private void PGLCEDHDGGL(EntityQuery PNNDDOKIOOP, EntityQuery COEFDEGAPFE, EntityQuery FNGMEOGCPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x3E90070", Offset = "0x3E8EE70", VA = "0x183E90070")]
		private void FAHLDBEBGON(EntityQuery FNGMEOGCPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x3E902E0", Offset = "0x3E8F0E0", VA = "0x183E902E0")]
		private void FFJGIONJDGJ(NativeArrayAsync<Entity> KMJKKFBOOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x3E90970", Offset = "0x3E8F770", VA = "0x183E90970")]
		private void HDJDACNMDAE(NativeArrayAsync<Entity> KIDGEKMGAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x3E91880", Offset = "0x3E90680", VA = "0x183E91880")]
		private void OCFKHAEHNHE(NativeArrayAsync<Entity> KFDDFKJABKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x3E8FF00", Offset = "0x3E8ED00", VA = "0x183E8FF00")]
		private void CIEKIIPIFOM(NativeList<KEOMFONJOJH> NGPENBBOCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x3E93680", Offset = "0x3E92480", VA = "0x183E93680")]
		private NativeList<KEOMFONJOJH> PLADAALKJOH(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<KEOMFONJOJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x3E92590", Offset = "0x3E91390", VA = "0x183E92590")]
		private void PEHKHPOGJPN(NativeArray<Entity> BNEBECKGGLP, NativeList<KEOMFONJOJH> NGPENBBOCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x3E90A80", Offset = "0x3E8F880", VA = "0x183E90A80")]
		private void KMIAPPHEAOL(NativeArray<Entity> FPIDLIBAEHG, NativeArray<Entity> ALBBMILABNK, NativeList<KEOMFONJOJH> NIEHJLCAJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x3E93090", Offset = "0x3E91E90", VA = "0x183E93090")]
		private void PHGGPDCMBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x3E93540", Offset = "0x3E92340", VA = "0x183E93540")]
		private NativeListAsync<LCNIHBLPIPJ> PKDCPHEBPAD(EntityQuery FBENFNFLPOM, Func<NativeList<LCNIHBLPIPJ>, JobHandle> PEAABMHIGIG)
		{
			return default(NativeListAsync<LCNIHBLPIPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8FAD0", Offset = "0x3E8E8D0", VA = "0x183E8FAD0")]
		private JobHandle BCDGDKAFBAK(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x3E901A0", Offset = "0x3E8EFA0", VA = "0x183E901A0")]
		private JobHandle FCBJEDIMFDO(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x3E91AF0", Offset = "0x3E908F0", VA = "0x183E91AF0")]
		private JobHandle OOPHJHCPIKE(NativeList<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F840", Offset = "0x3E8E640", VA = "0x183E8F840")]
		private void BBAHDJELAJD(NativeListAsync<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x3E92300", Offset = "0x3E91100", VA = "0x183E92300")]
		private void PDLJKPHJPMA(NativeListAsync<LCNIHBLPIPJ> DEEJEKFIHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x3E90140", Offset = "0x3E8EF40", VA = "0x183E90140")]
		private bool FCAEBNMKBNG(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x3E91A20", Offset = "0x3E90820", VA = "0x183E91A20")]
		private NativeArray<Entity> ONCONKFOHAE(Entity IEFFOCOBJJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x3E90FB0", Offset = "0x3E8FDB0", VA = "0x183E90FB0")]
		private KEOMFONJOJH LAPBPPFIJKN(NativeList<KEOMFONJOJH> NIEHJLCAJEN)
		{
			return default(KEOMFONJOJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x3E915F0", Offset = "0x3E903F0", VA = "0x183E915F0")]
		private void MPEKBDKBEIE(KEOMFONJOJH DCLMHANFEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3E91C20", Offset = "0x3E90A20", VA = "0x183E91C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3E91680", Offset = "0x3E90480", VA = "0x183E91680")]
		public static EntityQuery OBOLFHGDNNI(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3E8FC60", Offset = "0x3E8EA60", VA = "0x183E8FC60")]
		public static EntityQuery BKABJGMDPEP(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3E912C0", Offset = "0x3E900C0", VA = "0x183E912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6A2C0", Offset = "0x3C690C0", VA = "0x183C6A2C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A230", Offset = "0x3C69030", VA = "0x183C6A230", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A3C0", Offset = "0x3C691C0", VA = "0x183C6A3C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FADFMPBIOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	public FADFMPBIOEN(GEINEDFCGEN NKDJGKIHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AD90", Offset = "0x3F29B90", VA = "0x183F2AD90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F45750", Offset = "0x3F44550", VA = "0x183F45750", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x3F457B0", Offset = "0x3F445B0", VA = "0x183F457B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x3F457E0", Offset = "0x3F445E0", VA = "0x183F457E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	protected LPONIDGDICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F344D0", Offset = "0x3F332D0", VA = "0x183F344D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int FNGDFEABKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x3F34070", Offset = "0x3F32E70", VA = "0x183F34070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x3F34550", Offset = "0x3F33350", VA = "0x183F34550", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x3F34750", Offset = "0x3F33550", VA = "0x183F34750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x3F34950", Offset = "0x3F33750", VA = "0x183F34950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F344B0", Offset = "0x3F332B0", VA = "0x183F344B0")]
	public int KLEILBIFCLP(SceneTag PPJNHEBGICL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F34970", Offset = "0x3F33770", VA = "0x183F34970")]
	public int POIOKMGKODA(SceneTag PPJNHEBGICL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F341C0", Offset = "0x3F32FC0", VA = "0x183F341C0")]
	protected void JDEGDGPEHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F34640", Offset = "0x3F33440", VA = "0x183F34640")]
	protected void NBNDKABMFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F34080", Offset = "0x3F32E80", VA = "0x183F34080")]
	public NativeArrayAsync<Entity> CGAIJGAIMNI(SceneTag PPJNHEBGICL, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x3F34170", Offset = "0x3F32F70", VA = "0x183F34170")]
	public NativeArrayAsync<Entity> IAEFKIIKCHF(SceneTag PPJNHEBGICL, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x3F345B0", Offset = "0x3F333B0", VA = "0x183F345B0")]
	public bool MNFPMFNOAPO(SceneTag PPJNHEBGICL, out NativeArrayAsync<Entity> NKDJGKIHEEA, Allocator AEPJLHDIHPH = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F34450", Offset = "0x3F33250", VA = "0x183F34450")]
	public bool KFLIOAAFEFM(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F343E0", Offset = "0x3F331E0", VA = "0x183F343E0")]
	public GEINEDFCGEN JKHNBLPIIAC(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F344E0", Offset = "0x3F332E0", VA = "0x183F344E0")]
	public bool MAKGCDLBBBK(Entity IEFFOCOBJJI, out FADFMPBIOEN NKDJGKIHEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F340D0", Offset = "0x3F32ED0", VA = "0x183F340D0")]
	public void DIGPHILJGLP(Entity IEFFOCOBJJI, FADFMPBIOEN NKDJGKIHEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F34110", Offset = "0x3F32F10", VA = "0x183F34110")]
	public bool EDKKGBDGEDF(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void EOIIGNKEEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public HDKBBILLNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C647A0", Offset = "0x3C635A0", VA = "0x183C647A0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C647F0", Offset = "0x3C635F0", VA = "0x183C647F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C648B0", Offset = "0x3C636B0", VA = "0x183C648B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x33E4AF0", Offset = "0x33E38F0", VA = "0x1833E4AF0")]
	private bool IMBNFDILLLN<TComponentData>(EntityQuery FBENFNFLPOM, out NativeArray<Entity> BNEBECKGGLP, out NativeArray<TComponentData> IHFNCPHANDK) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C64730", Offset = "0x3C63530", VA = "0x183C64730")]
	public GEINEDFCGEN JKHNBLPIIAC(Entity IEFFOCOBJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public PKNHBBAJCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E847C0", Offset = "0x3E835C0", VA = "0x183E847C0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E84810", Offset = "0x3E83610", VA = "0x183E84810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E84A40", Offset = "0x3E83840", VA = "0x183E84A40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E84750", Offset = "0x3E83550", VA = "0x183E84750")]
		private void HMNAIPBHJIK(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E84380", Offset = "0x3E83180", VA = "0x183E84380")]
		private void FAHLDBEBGON(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E849D0", Offset = "0x3E837D0", VA = "0x183E849D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E843F0", Offset = "0x3E831F0", VA = "0x183E843F0")]
		private void HKPCHNMPOKA(EntityQuery FBENFNFLPOM, bool FLGLFAGJDGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public GOOPLIAJADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1C320", Offset = "0x4C1B120", VA = "0x184C1C320")]
			public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C260", Offset = "0x4C1B060", VA = "0x184C1C260")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C1ED10", Offset = "0x4C1DB10", VA = "0x184C1ED10")]
		internal void EACJNOHFKHL(Entity CJCOOPPJGHI, SplineShapeData GJBHFPJIHBB, DynamicBuffer<LinkedEntityGroup> FAHBHODOFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C1ED70", Offset = "0x4C1DB70", VA = "0x184C1ED70", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x4C1EE40", Offset = "0x4C1DC40", VA = "0x184C1EE40")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref BAOECGMKKJA.APEGMMHALNC MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C1EF60", Offset = "0x4C1DD60", VA = "0x184C1EF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C25720", Offset = "0x4C24520", VA = "0x184C25720")]
			public void JCIHNCONGGN(MBNMHOKMFEL MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x4C256A0", Offset = "0x4C244A0", VA = "0x184C256A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C1DE30", Offset = "0x4C1CC30", VA = "0x184C1DE30")]
		internal void EACJNOHFKHL(Entity KBGCHGICHIL, SplinePointParentData IHNIIIEMDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F82250", Offset = "0x1F81050", VA = "0x181F82250", Slot = "5")]
		public void ReadFromDisplayClass(ref GOOPLIAJADN ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DEC0", Offset = "0x4C1CCC0", VA = "0x184C1DEC0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DF60", Offset = "0x4C1CD60", VA = "0x184C1DF60")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref OFBDNECDBID.IPCKBDEMKCI MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x4C1E010", Offset = "0x4C1CE10", VA = "0x184C1E010")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C4F690", Offset = "0x3C4E490", VA = "0x183C4F690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F740", Offset = "0x3C4E540", VA = "0x183C4F740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public MBNMHOKMFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F3F0", Offset = "0x3C4E1F0", VA = "0x183C4F3F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F250", Offset = "0x3C4E050", VA = "0x183C4F250")]
	public static EntityQuery MCKOELHBGOE(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F0F0", Offset = "0x3C4DEF0", VA = "0x183C4F0F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E195B0", Offset = "0x3E183B0", VA = "0x183E195B0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E19610", Offset = "0x3E18410", VA = "0x183E19610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public DDBEFDIFMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public EEAGLJNDKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, JOLFHHMPJFM previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C217B0", Offset = "0x4C205B0", VA = "0x184C217B0")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x4C21730", Offset = "0x4C20530", VA = "0x184C21730")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7E770", Offset = "0x3E7D570", VA = "0x183E7E770")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData JFKHJAJODDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D4B0", VA = "0x180E1E6B0", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E7F0", Offset = "0x3E7D5F0", VA = "0x183E7E7F0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E860", Offset = "0x3E7D660", VA = "0x183E7E860")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref JHAOLPCHFIE.FJAMMLIOCBB MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E910", Offset = "0x3E7D710", VA = "0x183E7E910")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1C440", Offset = "0x4C1B240", VA = "0x184C1C440")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C3A0", Offset = "0x4C1B1A0", VA = "0x184C1C3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7DAE0", Offset = "0x3E7C8E0", VA = "0x183E7DAE0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData JFKHJAJODDL, JOLFHHMPJFM MBHNFHEJPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DD30", Offset = "0x3E7CB30", VA = "0x183E7DD30", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DBA0", Offset = "0x3E7C9A0", VA = "0x183E7DBA0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DC10", Offset = "0x3E7CA10", VA = "0x183E7DC10")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref BCGAFKNFAKP.NCCGJBKFDCO MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DCF0", Offset = "0x3E7CAF0", VA = "0x183E7DCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C25B60", Offset = "0x4C24960", VA = "0x184C25B60")]
			public void JCIHNCONGGN(DBALFPEDPGG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x4C25AE0", Offset = "0x4C248E0", VA = "0x184C25AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7A1D0", Offset = "0x3E78FD0", VA = "0x183E7A1D0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, JOLFHHMPJFM MBHNFHEJPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A3B0", Offset = "0x3E791B0", VA = "0x183E7A3B0", Slot = "5")]
		public void ReadFromDisplayClass(ref EEAGLJNDKPJ ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A250", Offset = "0x3E79050", VA = "0x183E7A250", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A2C0", Offset = "0x3E790C0", VA = "0x183E7A2C0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref OLDEBPPHGCK.BBIFCAGLHAN MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A370", Offset = "0x3E79170", VA = "0x183E7A370")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E18670", Offset = "0x3E17470", VA = "0x183E18670", Slot = "14")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E18C10", Offset = "0x3E17A10", VA = "0x183E18C10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public DBALFPEDPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E18BB0", Offset = "0x3E179B0", VA = "0x183E18BB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E18750", Offset = "0x3E17550", VA = "0x183E18750")]
	public static EntityQuery CAAGDHKOCMJ(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E18440", Offset = "0x3E17240", VA = "0x183E18440")]
	public static EntityQuery AHDEBAHJNDB(ComponentSystemBase MFLHDNPOKPM)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E189B0", Offset = "0x3E177B0", VA = "0x183E189B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3BFB0", Offset = "0x3F3ADB0", VA = "0x183F3BFB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BF40", Offset = "0x3F3AD40", VA = "0x183F3BF40", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C040", Offset = "0x3F3AE40", VA = "0x183F3C040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class GHEOPIIMCDK : ParentSystemBase<ParentData, JOLFHHMPJFM, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x3F304D0", Offset = "0x3F2F2D0", VA = "0x183F304D0", Slot = "14")]
	protected override EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x817E20", Offset = "0x816C20", VA = "0x180817E20", Slot = "15")]
	protected override EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x3F30490", Offset = "0x3F2F290", VA = "0x183F30490", Slot = "16")]
	protected override EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x3F30450", Offset = "0x3F2F250", VA = "0x183F30450", Slot = "17")]
	protected override EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x3F30550", Offset = "0x3F2F350", VA = "0x183F30550")]
	public GHEOPIIMCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x3F30510", Offset = "0x3F2F310", VA = "0x183F30510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AA4520", Offset = "0x3AA3320", VA = "0x183AA4520", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x445F040", Offset = "0x445DE40", VA = "0x18445F040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ABAB40", Offset = "0x3AB9940", VA = "0x183ABAB40")]
			private int PJDPOLEOOME(DynamicBuffer<ChildrenData> MIHJGHDPEEA, Entity IEFFOCOBJJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x3ABA4C0", Offset = "0x3AB92C0", VA = "0x183ABA4C0")]
			private void BECCJJKPGKB(Entity ICMEPOIJCJO, DynamicBuffer<ChildrenData> MIHJGHDPEEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x3ABA8E0", Offset = "0x3AB96E0", VA = "0x183ABA8E0")]
			private void PGPJBAPCGOM(Entity ICMEPOIJCJO, DynamicBuffer<ChildrenData> MIHJGHDPEEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x3ABA780", Offset = "0x3AB9580", VA = "0x183ABA780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FE0A80", Offset = "0x3FDF880", VA = "0x183FE0A80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A5D400", Offset = "0x3A5C200", VA = "0x183A5D400")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D220", Offset = "0x3A5C020", VA = "0x183A5D220")]
		private int PJDPOLEOOME(DynamicBuffer<ChildrenData> MIHJGHDPEEA, Entity IEFFOCOBJJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B6E0", Offset = "0x3A5A4E0", VA = "0x183A5B6E0")]
		private void CFAKJPIFGJC(Entity KFDBMMENHCC, Entity LMCIODJPIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x817E20", Offset = "0x816C20", VA = "0x180817E20", Slot = "14")]
		protected virtual EntityQueryDesc OPKGGKLDPBG(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x817E20", Offset = "0x816C20", VA = "0x180817E20", Slot = "15")]
		protected virtual EntityQueryDesc CKGNOGIHPEP(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x817E20", Offset = "0x816C20", VA = "0x180817E20", Slot = "16")]
		protected virtual EntityQueryDesc LKDDHFGEAHL(EntityQueryDesc FBENFNFLPOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FAMKBBDMKFD(EntityQueryDesc FBENFNFLPOM);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CE80", Offset = "0x3A5BC80", VA = "0x183A5CE80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B3E0", Offset = "0x3A5A1E0", VA = "0x183A5B3E0")]
		private void AECADGKCPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BFC0", Offset = "0x3A5ADC0", VA = "0x183A5BFC0")]
		private void HAMBILBMIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C180", Offset = "0x3A5AF80", VA = "0x183A5C180")]
		private JobHandle KLOABJBGNPE(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BB20", Offset = "0x3A5A920", VA = "0x183A5BB20")]
		private void GJLEKCELHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D150", Offset = "0x3A5BF50", VA = "0x183A5D150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D120", Offset = "0x3A5BF20", VA = "0x183A5D120", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790", Slot = "4")]
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
		public NativeListAsync<Entity> CJEGGGDDAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public NativeListAsync<Entity> FGHCPPPEIKI;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x4C26730", Offset = "0x4C25530", VA = "0x184C26730")]
		public PHMGJLOLBKJ(NativeList<Entity> CJEGGGDDAKI, NativeList<Entity> FGHCPPPEIKI, JobHandle CPPLLJNMFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x4C266B0", Offset = "0x4C254B0", VA = "0x184C266B0")]
		public JobHandle MPENILFCJEH(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x4C26620", Offset = "0x4C25420", VA = "0x184C26620", Slot = "4")]
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
		public ComponentDataFromEntity JKFBBNMPPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public ComponentDataFromEntity HAFLGAJBAMM;

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
		[Cpp2IlInjected.Address(RVA = "0x4C235B0", Offset = "0x4C223B0", VA = "0x184C235B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x4C237C0", Offset = "0x4C225C0", VA = "0x184C237C0")]
		private void JIBJLLJOHGH(Entity IEFFOCOBJJI, bool CMGFIBOFJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x4C23AF0", Offset = "0x4C228F0", VA = "0x184C23AF0")]
		private void PBCFLMCEEMD(Entity IEFFOCOBJJI, bool CMGFIBOFJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x4C23C00", Offset = "0x4C22A00", VA = "0x184C23C00")]
		public PHMGJLOLBKJ PNBMHBBAFDE(NativeArray<Entity> HCIALCFLHOM, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x4C23740", Offset = "0x4C22540", VA = "0x184C23740")]
		public PHMGJLOLBKJ GLMOLACOKCE(NativeArray<Entity> HCIALCFLHOM, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x4C23A10", Offset = "0x4C22810", VA = "0x184C23A10")]
		public PHMGJLOLBKJ NMEHBCJNJIF(NativeList<GGMEAKIAMAM> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x4C23850", Offset = "0x4C22650", VA = "0x184C23850")]
		public PHMGJLOLBKJ LOPGFLONLML(NativeList<GGMEAKIAMAM> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x4C23930", Offset = "0x4C22730", VA = "0x184C23930")]
		public PHMGJLOLBKJ NLEGPFOMEFB(NativeList<MLDEGJAOMMP> DEEJEKFIHBB, JobHandle MPFKOMLNJME)
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x575FCE0", Offset = "0x575EAE0", VA = "0x18575FCE0")]
		private PHMGJLOLBKJ CPIBHMJGANG<T>(NativeList<T> DEEJEKFIHBB, int FIBNJGKFAOF, int IMADHAKDDOL, KEIODGEKLDD HOEJODOFJHI, JobHandle MPFKOMLNJME) where T : struct
		{
			return default(PHMGJLOLBKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x4C23350", Offset = "0x4C22150", VA = "0x184C23350")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C53E60", Offset = "0x3C52C60", VA = "0x183C53E60")]
	protected MINODIPADOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x3C52920", Offset = "0x3C51720", VA = "0x183C52920", Slot = "14")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x3C52DC0", Offset = "0x3C51BC0", VA = "0x183C52DC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x3C52FF0", Offset = "0x3C51DF0", VA = "0x183C52FF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xFD0120", Offset = "0xFCEF20", VA = "0x180FD0120", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x3C52B10", Offset = "0x3C51910", VA = "0x183C52B10")]
	private void LDOGDMMNDJL(NativeArray<Entity> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x3C52A00", Offset = "0x3C51800", VA = "0x183C52A00")]
	private void DIBKDOOGPKL(NativeArray<Entity> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x3C526D0", Offset = "0x3C514D0", VA = "0x183C526D0")]
	private void ALIDKHKHIDI(PHMGJLOLBKJ NKDLEOPEHEM, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x3C52810", Offset = "0x3C51610", VA = "0x183C52810")]
	private void ALIDKHKHIDI(NativeListAsync<Entity> JAGLIDKDBDK, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x3C52B70", Offset = "0x3C51970", VA = "0x183C52B70")]
	private void NNILBEEGHEL(PHMGJLOLBKJ NKDLEOPEHEM, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x3C52CB0", Offset = "0x3C51AB0", VA = "0x183C52CB0")]
	private void NNILBEEGHEL(NativeListAsync<Entity> JAGLIDKDBDK, string GMLNFHEPDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x3C52AA0", Offset = "0x3C518A0", VA = "0x183C52AA0")]
	private bool JHFGOAEJOHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public MCGHGAEJGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1FDF0", Offset = "0x4C1EBF0", VA = "0x184C1FDF0")]
			public void JCIHNCONGGN(GJCMMEINCFG MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x4C1FDE0", Offset = "0x4C1EBE0", VA = "0x184C1FDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C1FA90", Offset = "0x4C1E890", VA = "0x184C1FA90")]
		internal void EACJNOHFKHL(Entity PBDFKDHMIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F2C0", Offset = "0x4C1E0C0", VA = "0x184C1F2C0", Slot = "5")]
		public void ReadFromDisplayClass(ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F2F0", Offset = "0x4C1E0F0", VA = "0x184C1F2F0", Slot = "6")]
		public void WriteToDisplayClass(ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FBA0", Offset = "0x4C1E9A0", VA = "0x184C1FBA0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FBF0", Offset = "0x4C1E9F0", VA = "0x184C1FBF0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref HIAFAALFFOH.DKEBACGCBDC MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FC60", Offset = "0x4C1EA60", VA = "0x184C1FC60")]
		public void JCIHNCONGGN(GJCMMEINCFG MFLHDNPOKPM, ref MCGHGAEJGJD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FA20", Offset = "0x4C1E820", VA = "0x184C1FA20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F30DC0", Offset = "0x3F2FBC0", VA = "0x183F30DC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x3F30C80", Offset = "0x3F2FA80", VA = "0x183F30C80", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3F30E20", Offset = "0x3F2FC20", VA = "0x183F30E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public GJCMMEINCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x3F30CE0", Offset = "0x3F2FAE0", VA = "0x183F30CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x3F30AB0", Offset = "0x3F2F8B0", VA = "0x183F30AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C63750", Offset = "0x3C62550", VA = "0x183C63750", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x3C637C0", Offset = "0x3C625C0", VA = "0x183C637C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x3C63860", Offset = "0x3C62660", VA = "0x183C63860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public PBOGPFPMMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x775530", Offset = "0x774330", VA = "0x180775530")]
	public static DBHDJCDCOHB LFOOIECCIPM(in FGLBLDPHAAD CCEBBLCHMLD)
	{
		return default(DBHDJCDCOHB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x775530", Offset = "0x774330", VA = "0x180775530")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C567E0", Offset = "0x3C555E0", VA = "0x183C567E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	public OBMLDKENPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public CEFJGCDEEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C222C0", Offset = "0x4C210C0", VA = "0x184C222C0")]
			public void JCIHNCONGGN(JICHCGBEEFB MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x4C22240", Offset = "0x4C21040", VA = "0x184C22240")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C1EFE0", Offset = "0x4C1DDE0", VA = "0x184C1EFE0")]
		internal void EACJNOHFKHL(Entity PBDFKDHMIEL, DBHDJCDCOHB BBLMMHCDFOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F2C0", Offset = "0x4C1E0C0", VA = "0x184C1F2C0", Slot = "5")]
		public void ReadFromDisplayClass(ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F2F0", Offset = "0x4C1E0F0", VA = "0x184C1F2F0", Slot = "6")]
		public void WriteToDisplayClass(ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F0E0", Offset = "0x4C1DEE0", VA = "0x184C1F0E0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F180", Offset = "0x4C1DF80", VA = "0x184C1F180")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref JKJLIMNAFNC.CMGCEEJFLDP MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F230", Offset = "0x4C1E030", VA = "0x184C1F230")]
		public void JCIHNCONGGN(JICHCGBEEFB MFLHDNPOKPM, ref CEFJGCDEEMD ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x4C1EF70", Offset = "0x4C1DD70", VA = "0x184C1EF70")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3D330", Offset = "0x3F3C130", VA = "0x183F3D330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D1F0", Offset = "0x3F3BFF0", VA = "0x183F3D1F0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D390", Offset = "0x3F3C190", VA = "0x183F3D390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public JICHCGBEEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D250", Offset = "0x3F3C050", VA = "0x183F3D250", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D020", Offset = "0x3F3BE20", VA = "0x183F3D020")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C223A0", Offset = "0x4C211A0", VA = "0x184C223A0")]
			public KCMGHBCPKBE(int CIMAPKKBLKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x4C22320", Offset = "0x4C21120", VA = "0x184C22320", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C23C80", Offset = "0x4C22A80", VA = "0x184C23C80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1E2B0", Offset = "0x4C1D0B0", VA = "0x184C1E2B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C67130", Offset = "0x3C65F30", VA = "0x183C67130", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x3C672D0", Offset = "0x3C660D0", VA = "0x183C672D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x3C67590", Offset = "0x3C66390", VA = "0x183C67590", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x3C675D0", Offset = "0x3C663D0", VA = "0x183C675D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x3C67190", Offset = "0x3C65F90", VA = "0x183C67190")]
		private void OGBKNHBIBLI(EntityQuery FBENFNFLPOM, out (NativeArrayAsync<DBHDJCDCOHB> handles, NativeArrayAsync<CFIMDNLGMOJ> bounds) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x3C66810", Offset = "0x3C65610", VA = "0x183C66810")]
		private void AEJGNCNCHAA((NativeArrayAsync<DBHDJCDCOHB> handles, NativeArrayAsync<CFIMDNLGMOJ> bounds) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x3C67590", Offset = "0x3C66390", VA = "0x183C67590")]
		private void PLLHJIEPEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x3C66BA0", Offset = "0x3C659A0", VA = "0x183C66BA0")]
		private void DCLBCLBIPMJ(EntityQuery FBENFNFLPOM, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<DBHDJCDCOHB> handles) FILAKGLBGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x3C66E40", Offset = "0x3C65C40", VA = "0x183C66E40")]
		private void LDJJICGPALA((NativeArrayAsync<Entity> entities, NativeArrayAsync<DBHDJCDCOHB> handles) FILAKGLBGGA, KCMGHBCPKBE IEOJBDIPJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3C66CE0", Offset = "0x3C65AE0", VA = "0x183C66CE0")]
		private JobHandle FIBLDHOCIEK(KCMGHBCPKBE IEOJBDIPJCJ, ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK, ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD, ComponentDataFromEntity<WorldDeformableScaleData> OOIGBOHOCCG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x3C66A70", Offset = "0x3C65870", VA = "0x183C66A70")]
		private JobHandle AIBDCMPNAIA(KCMGHBCPKBE IEOJBDIPJCJ, ComponentDataFromEntity<WorldPoseData> PGLNGAMPAOK, ComponentDataFromEntity<WorldUniformScaleData> CEADNNNKCPD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1FE00", Offset = "0x4C1EC00", VA = "0x184C1FE00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1DBA0", Offset = "0x4C1C9A0", VA = "0x184C1DBA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E86D10", Offset = "0x3E85B10", VA = "0x183E86D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x3E86F20", Offset = "0x3E85D20", VA = "0x183E86F20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x3E86530", Offset = "0x3E85330", VA = "0x183E86530")]
		private JobHandle JLHEIGFLFMD(NativeArrayAsync<Entity> DBOPJMNFJMA, int MFAHIHFAKKH, JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x3E86610", Offset = "0x3E85410", VA = "0x183E86610")]
		private JobHandle JLHEIGFLFMD(NativeArray<Entity> AJOBCOAMIIM, int MFAHIHFAKKH, [Optional] JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x3E864B0", Offset = "0x3E852B0", VA = "0x183E864B0")]
		private NativeArrayAsync<Entity> GPJIKKKEMMJ(EntityQuery FBENFNFLPOM)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x3E86060", Offset = "0x3E84E60", VA = "0x183E86060")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) GIIHPEIHPHF(NativeArrayAsync<Entity> GIGEAPDONPC)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x3E867F0", Offset = "0x3E855F0", VA = "0x183E867F0")]
		private void KBJFKJJAOCC(out NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x3E86880", Offset = "0x3E85680", VA = "0x183E86880")]
		private void KPDEGEPAFBI(NativeList<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x3E86910", Offset = "0x3E85710", VA = "0x183E86910")]
		private void KPDEGEPAFBI(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x3E87440", Offset = "0x3E86240", VA = "0x183E87440")]
		private void PHAMJCIIGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void GCFBBELLCIL(int LEAJLAJJOOH, int CEICDMPEGMK, int BGMAJCGHBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x3E869E0", Offset = "0x3E857E0", VA = "0x183E869E0")]
		private static CFIMDNLGMOJ MCNLAKDEPLH(NativeArray<Entity> EICLCEAPHDF, ComponentDataFromEntity<SplinePointPositionData> NLMEHIFJMHE, ComponentDataFromEntity<SplinePointScaleData> JKMNFJHBCNM)
		{
			return default(CFIMDNLGMOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1D620", Offset = "0x3E1C420", VA = "0x183E1D620", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D570", Offset = "0x3E1C370", VA = "0x183E1D570")]
		public bool EODNDGBDJMM(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D740", Offset = "0x3E1C540", VA = "0x183E1D740", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D890", Offset = "0x3E1C690", VA = "0x183E1D890", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D870", Offset = "0x3E1C670", VA = "0x183E1D870", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2C37E40", Offset = "0x2C36C40", VA = "0x182C37E40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D890", Offset = "0x3E1C690", VA = "0x183E1D890")]
		private void PAAFLFLLDKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D690", Offset = "0x3E1C490", VA = "0x183E1D690")]
		private void OFHNJHJILBA(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D200", Offset = "0x3E1C000", VA = "0x183E1D200")]
		private void BECCDDNBKAM(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D460", Offset = "0x3E1C260", VA = "0x183E1D460")]
		private void DHJNKJNMCAN(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D340", Offset = "0x3E1C140", VA = "0x183E1D340")]
		private void BPFAJGABJDC(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F28C00", Offset = "0x3F27A00", VA = "0x183F28C00", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3F28CB0", Offset = "0x3F27AB0", VA = "0x183F28CB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x3F28670", Offset = "0x3F27470", VA = "0x183F28670")]
		private void BLCCKHAHODP(HKIFOHOEGHF DCICIPKAADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private void ODJHFCNGKCG(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC, ONEPLGLDGPM DEIOLBFJFGO, FGFOHLOEDBC EGEKMEIMAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6D780", Offset = "0x3C6C580", VA = "0x183C6D780", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D810", Offset = "0x3C6C610", VA = "0x183C6D810", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E8E450", Offset = "0x3E8D250", VA = "0x183E8E450", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E4A0", Offset = "0x3E8D2A0", VA = "0x183E8E4A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7A640", Offset = "0x3E79440", VA = "0x183E7A640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0D730", Offset = "0x3E0C530", VA = "0x183E0D730", Slot = "14")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D330", Offset = "0x3E0C130", VA = "0x183E0D330", Slot = "15")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D3C0", Offset = "0x3E0C1C0", VA = "0x183E0D3C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D510", Offset = "0x3E0C310", VA = "0x183E0D510", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D740", Offset = "0x3E0C540", VA = "0x183E0D740")]
		private bool POEBFCOBIIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CFF0", Offset = "0x3E0BDF0", VA = "0x183E0CFF0")]
		private void CGFNNANEJDH(EntityQuery FBENFNFLPOM, float3 IDJIHGJADAJ, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6A150", Offset = "0x3C68F50", VA = "0x183C6A150", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A1A0", Offset = "0x3C68FA0", VA = "0x183C6A1A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E95760", Offset = "0x3E94560", VA = "0x183E95760", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E957D0", Offset = "0x3E945D0", VA = "0x183E957D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E95860", Offset = "0x3E94660", VA = "0x183E95860", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F27C10", Offset = "0x3F26A10", VA = "0x183F27C10", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F28020", Offset = "0x3F26E20", VA = "0x183F28020", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F27570", Offset = "0x3F26370", VA = "0x183F27570")]
		private void GKGLMLIDDEB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DEEJEKFIHBB, EntityQueryDesc LPKCPBGDPIE, bool CEDEGPILKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F27430", Offset = "0x3F26230", VA = "0x183F27430")]
		private void GKGLMLIDDEB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DEEJEKFIHBB, EntityQueryDesc LPKCPBGDPIE, bool CEDEGPILKLH, bool KDNPPGNBIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F28280", Offset = "0x3F27080", VA = "0x183F28280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F27A20", Offset = "0x3F26820", VA = "0x183F27A20")]
		private void JEEPIOBGOMI(EntityQuery FBENFNFLPOM, bool FEMFOKCKINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F27DD0", Offset = "0x3F26BD0", VA = "0x183F27DD0")]
		private void NIDKBBDGFMP(EntityQuery FBENFNFLPOM, bool FCFNJJPCAAA, bool FEMFOKCKINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F27020", Offset = "0x3F25E20", VA = "0x183F27020")]
		private void ALCNAFGJJAE(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F27C60", Offset = "0x3F26A60", VA = "0x183F27C60")]
		private void NFCCNNKPJGB(NativeList<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F27310", Offset = "0x3F26110", VA = "0x183F27310")]
		private void FJGJPGMOJEP(NativeArray<Entity> BNEBECKGGLP, bool FCFNJJPCAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F27680", Offset = "0x3F26480", VA = "0x183F27680")]
		private NativeList<Entity> HGDCIPIGFJO(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F27240", Offset = "0x3F26040", VA = "0x183F27240")]
		private NativeList<Entity> DKBKCMAIBKG(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F27FE0", Offset = "0x3F26DE0", VA = "0x183F27FE0")]
		private NativeList<Entity> OLMCFGNJKLK(NativeArray<Entity> BNEBECKGGLP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F27880", Offset = "0x3F26680", VA = "0x183F27880")]
		private NativeList<Entity> IHOBHGCCKDM(NativeArray<Entity> BNEBECKGGLP, bool OEGDHHMGKHJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F27280", Offset = "0x3F26080", VA = "0x183F27280")]
		private FPIJIFEICHE ELKOJDHGNAN(NativeArray<Entity> BNEBECKGGLP)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(FPIJIFEICHE);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F285A0", Offset = "0x3F273A0", VA = "0x183F285A0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6A1C0", Offset = "0x3C68FC0", VA = "0x183C6A1C0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A210", Offset = "0x3C69010", VA = "0x183C6A210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1CE70", Offset = "0x3E1BC70", VA = "0x183E1CE70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D030", Offset = "0x3E1BE30", VA = "0x183E1D030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C9F0", Offset = "0x3E1B7F0", VA = "0x183E1C9F0")]
		private void COHAJIDJILB(EntityQuery FBENFNFLPOM, bool MPNBEECGANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CC30", Offset = "0x3E1BA30", VA = "0x183E1CC30")]
		private void GKJBCBALALK(EntityQuery FBENFNFLPOM, bool MPNBEECGANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E07DE0", Offset = "0x3E06BE0", VA = "0x183E07DE0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E080A0", Offset = "0x3E06EA0", VA = "0x183E080A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E081B0", Offset = "0x3E06FB0", VA = "0x183E081B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B00", Offset = "0x3E06900", VA = "0x183E07B00")]
		private void ANCDDJEPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E07C70", Offset = "0x3E06A70", VA = "0x183E07C70")]
		private void FPGCFGNBHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E081D0", Offset = "0x3E06FD0", VA = "0x183E081D0")]
		private void PLDGMCNNIHN(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x3E07F60", Offset = "0x3E06D60", VA = "0x183E07F60")]
		private void OELLDOLDIBG(NativeArray<Entity> BNEBECKGGLP, int IAPLKGBBKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E07E50", Offset = "0x3E06C50", VA = "0x183E07E50")]
		private void NLGPGOEIBOP(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E07C10", Offset = "0x3E06A10", VA = "0x183E07C10")]
		private void EIJINEPPJCC(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void BBJABDNEEEF(int IFEILBLHHPO, Transform FLCFNMLPAML, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class JPMMBGJGFFB
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F3EFA0", Offset = "0x3F3DDA0", VA = "0x183F3EFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0EF00", Offset = "0x3E0DD00", VA = "0x183E0EF00", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EF50", Offset = "0x3E0DD50", VA = "0x183E0EF50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F010", Offset = "0x3E0DE10", VA = "0x183E0F010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F45940", Offset = "0x3F44740", VA = "0x183F45940")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x3F45A40", Offset = "0x3F44840", VA = "0x183F45A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity BKFELIEPMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x3F45C30", Offset = "0x3F44A30", VA = "0x183F45C30")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public PMFFIMLMCEJ AAHBFGJELMD
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x3F45BA0", Offset = "0x3F449A0", VA = "0x183F45BA0")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x3F459A0", Offset = "0x3F447A0", VA = "0x183F459A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public PMFFIMLMCEJ BKGCODOOPAF
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x3F45B10", Offset = "0x3F44910", VA = "0x183F45B10")]
			get
			{
				return default(PMFFIMLMCEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F45E20", Offset = "0x3F44C20", VA = "0x183F45E20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F45AA0", Offset = "0x3F448A0", VA = "0x183F45AA0", Slot = "15")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F45EC0", Offset = "0x3F44CC0", VA = "0x183F45EC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F45C90", Offset = "0x3F44A90", VA = "0x183F45C90", Slot = "14")]
		protected override void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F45800", Offset = "0x3F44600", VA = "0x183F45800")]
		private void CHDLAODBNOK(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F45F40", Offset = "0x3F44D40", VA = "0x183F45F40")]
		private void PLPLNPLALGB(Entity IEFFOCOBJJI, Entity HDBFDPJEOFG, Entity MDOJBKLAOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x36DBD30", Offset = "0x36DAB30", VA = "0x1836DBD30")]
		private bool MDMOKHFDALA<T>(out T DFEOJBAFBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x36DBC70", Offset = "0x36DAA70", VA = "0x1836DBC70")]
		private void EIHINOPMEGD<T>(T DFEOJBAFBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F458E0", Offset = "0x3F446E0", VA = "0x183F458E0")]
		public bool ECOJFCMIMLI(PMFFIMLMCEJ PIJOPLAILOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F45A10", Offset = "0x3F44810", VA = "0x183F45A10")]
		private static bool HFCCBEJNGIA(PMFFIMLMCEJ LODGEHOKDPG, PMFFIMLMCEJ KEIPMOFFIEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F46230", Offset = "0x3F45030", VA = "0x183F46230")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F45DE0", Offset = "0x3F44BE0", VA = "0x183F45DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E17550", Offset = "0x3E16350", VA = "0x183E17550", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x3E175A0", Offset = "0x3E163A0", VA = "0x183E175A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x3E17640", Offset = "0x3E16440", VA = "0x183E17640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x3E172F0", Offset = "0x3E160F0", VA = "0x183E172F0")]
		private NativeArray<Entity> ELMPNDJDNMM(int MIOCJKOOLBL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x3E17440", Offset = "0x3E16240", VA = "0x183E17440")]
		private void INAFMCAMEFF(NativeArray<Entity> GDIMDGGFBCE, NativeArray<Entity> NNNAHLEFPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F369A0", Offset = "0x3F357A0", VA = "0x183F369A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x3F36A90", Offset = "0x3F35890", VA = "0x183F36A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3793670", Offset = "0x3792470", VA = "0x183793670")]
	public static NativeArray<T> CPIBHMJGANG<T>(NativeArray<Entity> BNEBECKGGLP, EntityManager MKHPDCKNNBB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x3E08E30", Offset = "0x3E07C30", VA = "0x183E08E30")]
	public static void JOFKPPLDLJM(EntityQuery FBENFNFLPOM, EntityManager MKHPDCKNNBB, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x3E08BD0", Offset = "0x3E079D0", VA = "0x183E08BD0")]
	public static void EEAJFDPLMCB(NativeArray<Entity> GDIMDGGFBCE, JEAKCMCJOBO NAANBDEGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x3E08D00", Offset = "0x3E07B00", VA = "0x183E08D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E955D0", Offset = "0x3E943D0", VA = "0x183E955D0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x3E95660", Offset = "0x3E94460", VA = "0x183E95660", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x3E95700", Offset = "0x3E94500", VA = "0x183E95700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x3E94930", Offset = "0x3E93730", VA = "0x183E94930")]
		private void HPDJNGBCOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x3E94820", Offset = "0x3E93620", VA = "0x183E94820")]
		private void GLBLBLOBNHE(NativeArray<Entity> GDIMDGGFBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3E93D00", Offset = "0x3E92B00", VA = "0x183E93D00")]
		private void BFICBOKONNE(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x3E945D0", Offset = "0x3E933D0", VA = "0x183E945D0")]
		private void GCKFPIDHNBM(NativeArray<Entity> NNNAHLEFPHB, NativeArray<RigidTransform> JFNBGKEOLJC, NativeArray<RigidTransform> CLNMLIEFCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x3E95140", Offset = "0x3E93F40", VA = "0x183E95140")]
		private void JDKDNEDPNJK(NativeArray<RigidTransform> CLNMLIEFCBN, NativeArray<Entity> NNNAHLEFPHB, NativeList<Entity> HOALKGHBPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C68770", Offset = "0x3C67570", VA = "0x183C68770", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3C687E0", Offset = "0x3C675E0", VA = "0x183C687E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3C68930", Offset = "0x3C67730", VA = "0x183C68930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x3C68700", Offset = "0x3C67500", VA = "0x183C68700")]
		private void FCCACKHLLFL(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C69FC0", Offset = "0x3C68DC0", VA = "0x183C69FC0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A050", Offset = "0x3C68E50", VA = "0x183C6A050", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A0F0", Offset = "0x3C68EF0", VA = "0x183C6A0F0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x3C69E30", Offset = "0x3C68C30", VA = "0x183C69E30")]
		private void DKEAKLKPONF(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7F230", Offset = "0x3E7E030", VA = "0x183E7F230", Slot = "14")]
		protected override void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F380", Offset = "0x3E7E180", VA = "0x183E7F380")]
		[BurstCompile]
		private static void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> PEMGELIABFI, ComponentDataFromEntity<global::FPPGPOHJNPK> CMPHDOJMEKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F490", Offset = "0x3E7E290", VA = "0x183E7F490")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F450", Offset = "0x3E7E250", VA = "0x183E7F450", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x49409F0", Offset = "0x493F7F0", VA = "0x1849409F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x4940BF0", Offset = "0x493F9F0", VA = "0x184940BF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x4940BC0", Offset = "0x493F9C0", VA = "0x184940BC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x493F360", Offset = "0x493E160", VA = "0x18493F360")]
		private void EAHAIGADCPE(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x493FB90", Offset = "0x493E990", VA = "0x18493FB90")]
		private void FEAFIKKCEKJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x493FF80", Offset = "0x493ED80", VA = "0x18493FF80")]
		private void HONGPFKNEAJ(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void OMDBELIJLHM(NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> ICFPPFFMEFK, NativeArray<Entity> PEMGELIABFI);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A230", Offset = "0x3D89030", VA = "0x183D8A230")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF790", Offset = "0x2CDE590", VA = "0x182CDF790", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E09790", Offset = "0x3E08590", VA = "0x183E09790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x3E09990", Offset = "0x3E08790", VA = "0x183E09990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x3E09AE0", Offset = "0x3E088E0", VA = "0x183E09AE0")]
	public BLFDJJKOMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F74F50", Offset = "0x1F73D50", VA = "0x181F74F50")]
	public static Entity LFOOIECCIPM(NLLKDFGBAFF FILAKGLBGGA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x1F74F50", Offset = "0x1F73D50", VA = "0x181F74F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C64430", Offset = "0x3C63230", VA = "0x183C64430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x3C644B0", Offset = "0x3C632B0", VA = "0x183C644B0")]
	public PJECKKFIGKG(ComponentType OMMPBBANJJE, NativeList<int> JOOBOILFNKM, NativeList<int> EOFKAJHOCOO, NativeArray<Entity> BNEBECKGGLP, NativeArray<Entity> BMEHNGMFIGM, NativeArray<byte> MBHNFHEJPDH, NativeArray<byte> JFKHJAJODDL, int LKBNNMCHCFI, int IMIACOEJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x3C642B0", Offset = "0x3C630B0", VA = "0x183C642B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C643E0", Offset = "0x3C631E0", VA = "0x183C643E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C64260", Offset = "0x3C63060", VA = "0x183C64260")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C64180", Offset = "0x3C62F80", VA = "0x183C64180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F33FA0", Offset = "0x3F32DA0", VA = "0x183F33FA0")]
	public HALLOMDKPOM(ComponentType OMMPBBANJJE, int LKBNNMCHCFI, int IMIACOEJDJI, EntityQuery FBENFNFLPOM, NativeArray<LEHGOJHFAJL> JDJBDCDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x3F33F50", Offset = "0x3F32D50", VA = "0x183F33F50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x1808E87E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x1808E87E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2B540", Offset = "0x3F2A340", VA = "0x183F2B540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public OEMFGOLGDMG OIMEPCKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790")]
		get
		{
			return default(OEMFGOLGDMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B550", Offset = "0x3F2A350", VA = "0x183F2B550")]
	public PEKIEJLMCEO MGMCDCOFEHD(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B640", Offset = "0x3F2A440", VA = "0x183F2B640")]
	public PEKIEJLMCEO NOHDCNAIOHM(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E4E0", Offset = "0x3A0D2E0", VA = "0x183A0E4E0")]
	public T MGMCDCOFEHD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E500", Offset = "0x3A0D300", VA = "0x183A0E500")]
	public T NOHDCNAIOHM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B730", Offset = "0x3F2A530", VA = "0x183F2B730")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E0C840", Offset = "0x3E0B640", VA = "0x183E0C840", Slot = "17")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CAD0", Offset = "0x3E0B8D0", VA = "0x183E0CAD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C890", Offset = "0x3E0B690", VA = "0x183E0C890", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	protected CLFIGHANMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C4FE30", Offset = "0x3C4EC30", VA = "0x183C4FE30")]
		get
		{
			return default(HALLOMDKPOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FDE0", Offset = "0x3C4EBE0", VA = "0x183C4FDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x3C504B0", Offset = "0x3C4F2B0", VA = "0x183C504B0")]
	public MDBAAKNLHNI(JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x3C50300", Offset = "0x3C4F100", VA = "0x183C50300")]
	public bool HADOILGNPLN(ComponentType OMMPBBANJJE, out HALLOMDKPOM JOHEPNEHJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x3C50370", Offset = "0x3C4F170", VA = "0x183C50370")]
	public Dictionary<ComponentType, HALLOMDKPOM>.Enumerator HPPJKDPBNFG()
	{
		return default(Dictionary<ComponentType, HALLOMDKPOM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x3C4FEC0", Offset = "0x3C4ECC0", VA = "0x183C4FEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F980", Offset = "0x3C4E780", VA = "0x183C4F980")]
	private void CHJLJKHDKAE(IEnumerable<PGIKEAFDIOH> OCJPNOLMEHI, EntityManager MKHPDCKNNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x3C50400", Offset = "0x3C4F200", VA = "0x183C50400")]
	private static int JBDGDPOLOFO(PGIKEAFDIOH BAEHHBGAGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x3C50050", Offset = "0x3C4EE50", VA = "0x183C50050")]
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
			[Cpp2IlInjected.Address(RVA = "0xB691D0", Offset = "0xB67FD0", VA = "0x180B691D0", Slot = "4")]
			get
			{
				return default(FGFOHLOEDBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x3E7EB90", Offset = "0x3E7D990", VA = "0x183E7EB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EBE0", Offset = "0x3E7D9E0", VA = "0x183E7EBE0")]
		internal OCPFHKOIPOD(NativeMultiHashMap<Entity, FGFOHLOEDBC> LLHCHDMLAEG, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E980", Offset = "0x3E7D780", VA = "0x183E7E980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E950", Offset = "0x3E7D750", VA = "0x183E7E950")]
		public OCPFHKOIPOD HPPJKDPBNFG()
		{
			return default(OCPFHKOIPOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EA50", Offset = "0x3E7D850", VA = "0x183E7EA50", Slot = "9")]
		private IEnumerator<FGFOHLOEDBC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EAF0", Offset = "0x3E7D8F0", VA = "0x183E7EAF0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E066A0", Offset = "0x3E054A0", VA = "0x183E066A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x3E06900", Offset = "0x3E05700", VA = "0x183E06900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2E66670", Offset = "0x2E65470", VA = "0x182E66670")]
	public ANLCPLEKFMI(OKLEKHOLNCL IDIIBDOHICE, JobHandle KGEDOEANNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x3E06440", Offset = "0x3E05240", VA = "0x183E06440")]
	public bool DFNEACELHKG(Allocator AEPJLHDIHPH, out NativeKeyValueArrays<Entity, FGFOHLOEDBC> MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05590", VA = "0x183E06790")]
	public bool OHLCHDPGHLA(Allocator AEPJLHDIHPH, out (NativeArray<Entity> entities, int uniqueCount) MMPEAFKIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3E06580", Offset = "0x3E05380", VA = "0x183E06580")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F439A0", Offset = "0x3F427A0", VA = "0x183F439A0")]
		get
		{
			return default(HALLOMDKPOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x3F43960", Offset = "0x3F42760", VA = "0x183F43960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x3F43C20", Offset = "0x3F42A20", VA = "0x183F43C20")]
	public LHHIGECFLLB(MDBAAKNLHNI KPBEGLEDJIB, JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x3F43BA0", Offset = "0x3F429A0", VA = "0x183F43BA0")]
	public List<HALLOMDKPOM>.Enumerator HPPJKDPBNFG()
	{
		return default(List<HALLOMDKPOM>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x3F43A30", Offset = "0x3F42830", VA = "0x183F43A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x3F43660", Offset = "0x3F42460", VA = "0x183F43660")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C51F30", Offset = "0x3C50D30", VA = "0x183C51F30")]
	public MFMDMDGDHMO(ObjectInstantiationService AAPBAEGCALL, JLJEDKKMHDF JNDOBDHNDEN, FBNJDMKEPCN KKLHLPEDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x3C512B0", Offset = "0x3C500B0", VA = "0x183C512B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x3C51250", Offset = "0x3C50050", VA = "0x183C51250")]
	public bool CFEDEDIJJMD(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x3C50AF0", Offset = "0x3C4F8F0", VA = "0x183C50AF0")]
	private void AHNMALCCCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x3C505C0", Offset = "0x3C4F3C0", VA = "0x183C505C0")]
	private EntityArchetype AHAIEENMEGC(EntityArchetype ABOLABLPENH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x3C51B00", Offset = "0x3C50900", VA = "0x183C51B00")]
	public static void PHLKPPPNJND(EntityManager DDNAAJMMFNN, EntityManager BLDEHLEAJGA, NativeArray<Entity> PNFNAEBJOEK, NativeArray<EntityArchetype> IHLCCPAJGBF, [Optional] NativeArray<Entity> AEMHGFJOIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x3C514C0", Offset = "0x3C502C0", VA = "0x183C514C0")]
	[Conditional("DEBUG_BUILD")]
	private static void IFHDDFFMILC(NativeArray<EntityArchetype> OOJLGDAONOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3C51710", Offset = "0x3C50510", VA = "0x183C51710")]
	private static string KMKNAAEDLGP(EntityArchetype FAAKDBHJKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x3C51380", Offset = "0x3C50180", VA = "0x183C51380")]
	[CompilerGenerated]
	internal static void FCBCIMDJLPN(ref Span<ComponentType> KNIMIDPAGFE, ComponentType DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3C51950", Offset = "0x3C50750", VA = "0x183C51950")]
	[CompilerGenerated]
	internal static void ONDNAMLNNAP(Span<ComponentType> DBOPJMNFJMA, ref Span<ComponentType> KNIMIDPAGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x3C51630", Offset = "0x3C50430", VA = "0x183C51630")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E07990", Offset = "0x3E06790", VA = "0x183E07990", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x3E07A50", Offset = "0x3E06850", VA = "0x183E07A50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7B400", Offset = "0x3E7A200", VA = "0x183E7B400", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x3E7B540", Offset = "0x3E7A340", VA = "0x183E7B540")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7ADF0", Offset = "0x3E79BF0", VA = "0x183E7ADF0", Slot = "4")]
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
			public ComponentDataFromEntity HDIEHNKBFOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int LKBNNMCHCFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker JKKJMPHIDNF;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x3E7B830", Offset = "0x3E7A630", VA = "0x183E7B830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7A3C0", Offset = "0x3E791C0", VA = "0x183E7A3C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E10AC0", Offset = "0x3E0F8C0", VA = "0x183E10AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private OKLEKHOLNCL NPJAAKCIGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x3E0FB00", Offset = "0x3E0E900", VA = "0x183E0FB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x3E11370", Offset = "0x3E10170", VA = "0x183E11370", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "15")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x3E11BE0", Offset = "0x3E109E0", VA = "0x183E11BE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3E11DA0", Offset = "0x3E10BA0", VA = "0x183E11DA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3E11D30", Offset = "0x3E10B30", VA = "0x183E11D30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FD50", Offset = "0x3E0EB50", VA = "0x183E0FD50")]
		private void IGEEGOEHFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E11350", Offset = "0x3E10150", VA = "0x183E11350")]
		internal void MCNPBJPJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E10B80", Offset = "0x3E0F980", VA = "0x183E10B80")]
		private void MCNPBJPJFIP(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E10880", Offset = "0x3E0F680", VA = "0x183E10880")]
		private void LHFAGNJOGNA(NativeArray<Entity> PNFNAEBJOEK, NativeArray<RRObjectPrefabData> BHHIHKBGNIJ, ref NativeArray<Entity> GEDFDAHEOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E113C0", Offset = "0x3E101C0", VA = "0x183E113C0")]
		internal void NGEBLNGCCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E113E0", Offset = "0x3E101E0", VA = "0x183E113E0")]
		private void NGEBLNGCCHA(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E10120", Offset = "0x3E0EF20", VA = "0x183E10120")]
		internal void LBFLMDABOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E11EE0", Offset = "0x3E10CE0", VA = "0x183E11EE0")]
		private void PHBNOEJJEIP(OKLEKHOLNCL IDIIBDOHICE, HALLOMDKPOM ECGOBGEIPCF, bool AKKJMIAABJH, ref JobHandle AEEKBHHEJFH, ref JobHandle MOMLDMEKEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F0D0", Offset = "0x3E0DED0", VA = "0x183E0F0D0")]
		internal bool ALGNFLDCAEA(in HALLOMDKPOM KMJCJNGOPHM, out JobHandle DCLMHANFEGK, out PJECKKFIGKG IADGPFGBGBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F100", Offset = "0x3E0DF00", VA = "0x183E0F100")]
		private bool ALGNFLDCAEA(in HALLOMDKPOM KMJCJNGOPHM, bool AKKJMIAABJH, out JobHandle DCLMHANFEGK, out PJECKKFIGKG IADGPFGBGBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E121C0", Offset = "0x3E10FC0", VA = "0x183E121C0")]
		internal (NativeList<int>, NativeList<int>) PLHGFHPOMPN(NativeList<NLCDIAMMCAI> HECABBCJCKD, int CIMAPKKBLKM, JobHandle MPFKOMLNJME, out JobHandle CPPLLJNMFIG, Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FC20", Offset = "0x3E0EA20", VA = "0x183E0FC20")]
		internal static NativeArray<Entity> GPNAJLIHBOE(EntityQuery FBENFNFLPOM, out JobHandle CGOHMJGOOHH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FCD0", Offset = "0x3E0EAD0", VA = "0x183E0FCD0")]
		internal static NativeArray<byte> HKGFBHFDECG(int CCFMJPPGPDK, out JobHandle ODIMFJPOPPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E10010", Offset = "0x3E0EE10", VA = "0x183E10010")]
		internal static NativeArray<byte> IMOBKJBBLHI(EntityQuery FBENFNFLPOM, int CNNKHGOHIDH, out JobHandle ODIMFJPOPPC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FB20", Offset = "0x3E0E920", VA = "0x183E0FB20")]
		internal static NativeArray<Entity> GPJIKKKEMMJ(EntityQuery FBENFNFLPOM, out JobHandle IFIIDOINMHG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E117E0", Offset = "0x3E105E0", VA = "0x183E117E0")]
		internal NativeArray<byte> NKDIOOPHLFL(NativeArray<Entity> BNEBECKGGLP, HALLOMDKPOM ECGOBGEIPCF, JobHandle MPFKOMLNJME, out JobHandle CPPLLJNMFIG, Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E11A50", Offset = "0x3E10850", VA = "0x183E11A50")]
		internal JobHandle NNGBOAODBFO(in PJECKKFIGKG FILAKGLBGGA, in HALLOMDKPOM ECGOBGEIPCF, NativeMultiHashMap<Entity, FGFOHLOEDBC> CGCELJGOCCG, JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1B87730", Offset = "0x1B86530", VA = "0x181B87730")]
		private JobHandle HBHPOFMOEGE(JobHandle ECAENDJPKEI, JobHandle BFBAIBNDBID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1B87730", Offset = "0x1B86530", VA = "0x181B87730")]
		private JobHandle HBHPOFMOEGE(JobHandle ECAENDJPKEI, JobHandle BFBAIBNDBID, JobHandle IDOFKIEGPCJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6AA30", Offset = "0x3C69830", VA = "0x183C6AA30", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA00", Offset = "0x3C69800", VA = "0x183C6AA00", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x3C6A9D0", Offset = "0x3C697D0", VA = "0x183C6A9D0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E60", Offset = "0x3C52C60", VA = "0x183C53E60")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6AAC0", Offset = "0x3C698C0", VA = "0x183C6AAC0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA90", Offset = "0x3C69890", VA = "0x183C6AA90", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AA60", Offset = "0x3C69860", VA = "0x183C6AA60", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E60", Offset = "0x3C52C60", VA = "0x183C53E60")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E1C180", Offset = "0x3E1AF80", VA = "0x183E1C180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E1C210", Offset = "0x3E1B010", VA = "0x183E1C210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public DMJGFGOFPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public BBDHPHAAJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C24110", Offset = "0x4C22F10", VA = "0x184C24110")]
			public void JCIHNCONGGN(EHPOJBKJMON MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x4C24090", Offset = "0x4C22E90", VA = "0x184C24090")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7B640", Offset = "0x3E7A440", VA = "0x183E7B640")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, SplinePointParentData LMABBBKCION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B810", Offset = "0x3E7A610", VA = "0x183E7B810", Slot = "5")]
		public void ReadFromDisplayClass(ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B820", Offset = "0x3E7A620", VA = "0x183E7B820", Slot = "6")]
		public void WriteToDisplayClass(ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B6B0", Offset = "0x3E7A4B0", VA = "0x183E7B6B0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B720", Offset = "0x3E7A520", VA = "0x183E7B720")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref MGPDFBODIDE.FDANAAOMBHH MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B7D0", Offset = "0x3E7A5D0", VA = "0x183E7B7D0")]
		public void JCIHNCONGGN(EHPOJBKJMON MFLHDNPOKPM, ref BBDHPHAAJBG ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B5D0", Offset = "0x3E7A3D0", VA = "0x183E7B5D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E1F350", Offset = "0x3E1E150", VA = "0x183E1F350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public EHPOJBKJMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F120", Offset = "0x3E1DF20", VA = "0x183E1F120", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EFC0", Offset = "0x3E1DDC0", VA = "0x183E1EFC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E215B0", Offset = "0x3E203B0", VA = "0x183E215B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E21640", Offset = "0x3E20440", VA = "0x183E21640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public ENHKJKGDFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(DMJGFGOFPFF))]
public class DAIGAGHKCEB : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E18330", Offset = "0x3E17130", VA = "0x183E18330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public DAIGAGHKCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public ALPLJDNLNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C26080", Offset = "0x4C24E80", VA = "0x184C26080")]
			public void JCIHNCONGGN(EMJADLKIPAM MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x4C26000", Offset = "0x4C24E00", VA = "0x184C26000")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7C1B0", Offset = "0x3E7AFB0", VA = "0x183E7C1B0")]
		internal void EACJNOHFKHL(Entity IEFFOCOBJJI, ObjectNetworkIdComponentData KKFCOGJAMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D4B0", VA = "0x180E1E6B0", Slot = "5")]
		public void ReadFromDisplayClass(ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x33BB250", Offset = "0x33BA050", VA = "0x1833BB250", Slot = "6")]
		public void WriteToDisplayClass(ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C230", Offset = "0x3E7B030", VA = "0x183E7C230", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C2A0", Offset = "0x3E7B0A0", VA = "0x183E7C2A0")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref PBHMIPLGBFO.HHCIMFHPGIM MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C350", Offset = "0x3E7B150", VA = "0x183E7C350")]
		public void JCIHNCONGGN(EMJADLKIPAM MFLHDNPOKPM, ref ALPLJDNLNDM ENNMBDEBHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C140", Offset = "0x3E7AF40", VA = "0x183E7C140")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E21210", Offset = "0x3E20010", VA = "0x183E21210", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E21470", Offset = "0x3E20270", VA = "0x183E21470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public EMJADLKIPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E21270", Offset = "0x3E20070", VA = "0x183E21270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E210B0", Offset = "0x3E1FEB0", VA = "0x183E210B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C22B30", Offset = "0x4C21930", VA = "0x184C22B30")]
			public void JCIHNCONGGN(KGEPBPDNNPB MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x4C22AB0", Offset = "0x4C218B0", VA = "0x184C22AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C228C0", Offset = "0x4C216C0", VA = "0x184C228C0")]
		public void EACJNOHFKHL(Entity IEFFOCOBJJI, ParentData FBJFKLLHMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x4C228E0", Offset = "0x4C216E0", VA = "0x184C228E0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C22980", Offset = "0x4C21780", VA = "0x184C22980")]
		public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref LBBNIKCEMBD.PALPCGGKMEM MAGMDKMOKCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C22A30", Offset = "0x4C21830", VA = "0x184C22A30")]
		public void JCIHNCONGGN(KGEPBPDNNPB MFLHDNPOKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C22850", Offset = "0x4C21650", VA = "0x184C22850")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F40B20", Offset = "0x3F3F920", VA = "0x183F40B20", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F40D80", Offset = "0x3F3FB80", VA = "0x183F40D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public KGEPBPDNNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F407D0", Offset = "0x3F3F5D0", VA = "0x183F407D0")]
	[CompilerGenerated]
	private void DLHCGDHHIMI(Entity IEFFOCOBJJI, ParentData FBJFKLLHMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F40B80", Offset = "0x3F3F980", VA = "0x183F40B80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F409C0", Offset = "0x3F3F7C0", VA = "0x183F409C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C523C0", Offset = "0x3C511C0", VA = "0x183C523C0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C52410", Offset = "0x3C51210", VA = "0x183C52410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C524F0", Offset = "0x3C512F0", VA = "0x183C524F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C52020", Offset = "0x3C50E20", VA = "0x183C52020")]
	private void FADPOKMLNPG(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public MFOFPNHDDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C68A40", Offset = "0x3C67840", VA = "0x183C68A40", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x3C68A90", Offset = "0x3C67890", VA = "0x183C68A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
			public KGHMJICOIBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1BEA0", Offset = "0x4C1ACA0", VA = "0x184C1BEA0")]
				public void JCIHNCONGGN(PostLoadInitializeNetworkId MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x4C1BDF0", Offset = "0x4C1ABF0", VA = "0x184C1BDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C257F0", Offset = "0x4C245F0", VA = "0x184C257F0")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, int KBNPGMICLJO, ref ObjectNetworkIdComponentData KKFCOGJAMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D4B0", VA = "0x180E1E6B0", Slot = "5")]
			public void ReadFromDisplayClass(ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x33BB250", Offset = "0x33BA050", VA = "0x1833BB250", Slot = "6")]
			public void WriteToDisplayClass(ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x4C25880", Offset = "0x4C24680", VA = "0x184C25880", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x4C25970", Offset = "0x4C24770", VA = "0x184C25970")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref AIFMIFECCKF.BJIEICBBFIF MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x4C25A40", Offset = "0x4C24840", VA = "0x184C25A40")]
			public void JCIHNCONGGN(PostLoadInitializeNetworkId MFLHDNPOKPM, ref KGHMJICOIBN ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x4C25780", Offset = "0x4C24580", VA = "0x184C25780")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C696C0", Offset = "0x3C684C0", VA = "0x183C696C0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x3C699C0", Offset = "0x3C687C0", VA = "0x183C699C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x3C69390", Offset = "0x3C68190", VA = "0x183C69390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x3C69390", Offset = "0x3C68190", VA = "0x183C69390")]
		public void HDEKDDOGIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x3C68E40", Offset = "0x3C67C40", VA = "0x183C68E40")]
		private void EJPJIGGIGPN(NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x3C69460", Offset = "0x3C68260", VA = "0x183C69460")]
		private void KJEKDHHCIGH(NativeHashMap<AIELFMMICMN, Entity> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3C69730", Offset = "0x3C68530", VA = "0x183C69730", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3C68CA0", Offset = "0x3C67AA0", VA = "0x183C68CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E20490", Offset = "0x3E1F290", VA = "0x183E20490", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x3E20520", Offset = "0x3E1F320", VA = "0x183E20520", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public EJHDIJBKOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3CC20", Offset = "0x3F3BA20", VA = "0x183F3CC20", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x3F3CCC0", Offset = "0x3F3BAC0", VA = "0x183F3CCC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x3F3C9C0", Offset = "0x3F3B7C0", VA = "0x183F3C9C0")]
	private void FPNJCAMPBJL(NativeList<EntityArchetype> OOJLGDAONOE, NativeHashMap<int, PEFLLNEDEOA> NJEOKLPOEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x3F3C880", Offset = "0x3F3B680", VA = "0x183F3C880")]
	private Span<int> EJIPNOIHEKP(EntityArchetype FAAKDBHJKLM)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x3F3CB50", Offset = "0x3F3B950", VA = "0x183F3CB50")]
	private bool IAKHKPAGNOG(int CNNKHGOHIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x3F3C280", Offset = "0x3F3B080", VA = "0x183F3C280")]
	private void BKCFAMKHOGM(NativeHashMap<int, PEFLLNEDEOA> NJEOKLPOEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public JAFGDDJPLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C69AB0", Offset = "0x3C688B0", VA = "0x183C69AB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x3C69D30", Offset = "0x3C68B30", VA = "0x183C69D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
			public MIBCBFOIHJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x3E7A1C0", Offset = "0x3E78FC0", VA = "0x183E7A1C0")]
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
			public ComponentDataFromEntity JEPELMJGPHI;

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
			[Cpp2IlInjected.Address(RVA = "0x4C20360", Offset = "0x4C1F160", VA = "0x184C20360")]
			internal void EACJNOHFKHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x4C20550", Offset = "0x4C1F350", VA = "0x184C20550", Slot = "5")]
			public void ReadFromDisplayClass(ref MIBCBFOIHJG ENNMBDEBHBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x4C20520", Offset = "0x4C1F320", VA = "0x184C20520", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x4C20530", Offset = "0x4C1F330", VA = "0x184C20530")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E852E0", Offset = "0x3E840E0", VA = "0x183E852E0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x3E84F90", Offset = "0x3E83D90", VA = "0x183E84F90")]
		public JobHandle KLEJCNDMJEE(JobHandle MPFKOMLNJME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x3E85340", Offset = "0x3E84140", VA = "0x183E85340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x3E84FD0", Offset = "0x3E83DD0", VA = "0x183E84FD0")]
		private bool MLEGAOGIIOE(JobHandle MPFKOMLNJME, int CNNKHGOHIDH, out JobHandle CDICIBOMMJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F40E90", Offset = "0x3F3FC90", VA = "0x183F40E90", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public KGJFBMCBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E1C8A0", Offset = "0x3E1B6A0", VA = "0x183E1C8A0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public DOCHMGNAMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C54DB0", Offset = "0x3C53BB0", VA = "0x183C54DB0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public NIJGMDCGDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F321E0", Offset = "0x3F30FE0", VA = "0x183F321E0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public GLPDMDGLDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1810", Offset = "0x6B0610", VA = "0x1806B1810", Slot = "18")]
		get
		{
			return default(HKIFOHOEGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public CPEOCAOJGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F399E0", Offset = "0x3F387E0", VA = "0x183F399E0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public IHNNGLHDAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class AAAOFFGBNJM : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public AAAOFFGBNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "18")]
		get
		{
			return default(HKIFOHOEGHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x3C63FD0", Offset = "0x3C62DD0", VA = "0x183C63FD0")]
	public PFKLLPDENKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F359B0", Offset = "0x3F347B0", VA = "0x183F359B0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public HPMOHGHHBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class KMCNFCNMMDB : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public KMCNFCNMMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class DABHEHADJJP : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public DABHEHADJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class MLDHKKJBBNJ : GAJBCDLDAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public MLDHKKJBBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C561B0", Offset = "0x3C54FB0", VA = "0x183C561B0", Slot = "14")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x3C56200", Offset = "0x3C55000", VA = "0x183C56200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public NOBEEEJHDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7BA80", Offset = "0x3E7A880", VA = "0x183E7BA80", Slot = "4")]
			public void Execute(int NPDGHPHAKDK, TransformAccess FLCFNMLPAML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x3E7BCB0", Offset = "0x3E7AAB0", VA = "0x183E7BCB0")]
			private bool LBPIGEGMNBG(float3 MKDFAPBMCCA, float3 FDANAHCAINP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x3E7BC40", Offset = "0x3E7AA40", VA = "0x183E7BC40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7C5A0", Offset = "0x3E7B3A0", VA = "0x183E7C5A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E15530", Offset = "0x3E14330", VA = "0x183E15530", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x3E155A0", Offset = "0x3E143A0", VA = "0x183E155A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x3E155D0", Offset = "0x3E143D0", VA = "0x183E155D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1EB80", Offset = "0x4C1D980", VA = "0x184C1EB80")]
				public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x4C1EAC0", Offset = "0x4C1D8C0", VA = "0x184C1EAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1BF80", Offset = "0x4C1AD80", VA = "0x184C1BF80")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, FIGJHEBAEKN MNHDAEDPKMK, Transform FLCFNMLPAML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C080", Offset = "0x4C1AE80", VA = "0x184C1C080", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C170", Offset = "0x4C1AF70", VA = "0x184C1C170")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, ref ENJKOLEMJNB.KEGCJEDLPNC MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C250", Offset = "0x4C1B050", VA = "0x184C1C250")]
			public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x4C1BF10", Offset = "0x4C1AD10", VA = "0x184C1BF10")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C1E120", Offset = "0x4C1CF20", VA = "0x184C1E120")]
				public void JCIHNCONGGN(RegisterTransforms MFLHDNPOKPM)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x4C1E0A0", Offset = "0x4C1CEA0", VA = "0x184C1E0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C21B50", Offset = "0x4C20950", VA = "0x184C21B50")]
			internal void EACJNOHFKHL(Entity IEFFOCOBJJI, FIGJHEBAEKN MNHDAEDPKMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x4C21C30", Offset = "0x4C20A30", VA = "0x184C21C30", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int EHPHMOBJNOI, int IOAPAMHCGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x4C21CC0", Offset = "0x4C20AC0", VA = "0x184C21CC0")]
			public void GAFHJNGNBGC(ref ArchetypeChunk LDGNGMADGKK, [NoAlias] ref CPJCCGKAFGM.HELOOJOECLB MAGMDKMOKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x4C1E120", Offset = "0x4C1CF20", VA = "0x184C1E120")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C71AE0", Offset = "0x3C708E0", VA = "0x183C71AE0", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x3C71DA0", Offset = "0x3C70BA0", VA = "0x183C71DA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x3C71FB0", Offset = "0x3C70DB0", VA = "0x183C71FB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x3C70E70", Offset = "0x3C6FC70", VA = "0x183C70E70")]
		private void DEJIDINEOOO(EntityQuery FBENFNFLPOM, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x3C720C0", Offset = "0x3C70EC0", VA = "0x183C720C0")]
		private void PCLAMAHCGDH(EntityQuery FBENFNFLPOM, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x3C71F50", Offset = "0x3C70D50", VA = "0x183C71F50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x3C719A0", Offset = "0x3C707A0", VA = "0x183C719A0")]
		private void MENBPIBPIDH(NativeArray<Entity> BNEBECKGGLP, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x3C714A0", Offset = "0x3C702A0", VA = "0x183C714A0")]
		[BurstCompile]
		internal static void HPAIBGLDNPF(NativeArray<FIGJHEBAEKN> IONNDHGCPJJ, ComponentDataFromEntity<FIGJHEBAEKN> LMFBKOKDJCO, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void DFOPOAHELPH(Transform FLCFNMLPAML, Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void CEKOBKDFCOF(Entity IEFFOCOBJJI, int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void KCIJMJKBHEO(int NPDGHPHAKDK, OCGEMJOOKNP NCGKHNPLCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x3C717C0", Offset = "0x3C705C0", VA = "0x183C717C0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void IPLFJGOHEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x3C71B30", Offset = "0x3C70930", VA = "0x183C71B30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x3C71130", Offset = "0x3C6FF30", VA = "0x183C71130")]
		public static EntityQuery DNJBIILDKGA(ComponentSystemBase MFLHDNPOKPM)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x3C712D0", Offset = "0x3C700D0", VA = "0x183C712D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7EC00", Offset = "0x3E7DA00", VA = "0x183E7EC00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7E6D0", Offset = "0x3E7D4D0", VA = "0x183E7E6D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7B980", Offset = "0x3E7A780", VA = "0x183E7B980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E15A80", Offset = "0x3E14880", VA = "0x183E15A80", Slot = "14")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x3E15C50", Offset = "0x3E14A50", VA = "0x183E15C50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x3E15E40", Offset = "0x3E14C40", VA = "0x183E15E40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x3E15ED0", Offset = "0x3E14CD0", VA = "0x183E15ED0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x3E15F00", Offset = "0x3E14D00", VA = "0x183E15F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x3E15AD0", Offset = "0x3E148D0", VA = "0x183E15AD0")]
		private NativeArray<Entity> OCFPGDDGHJH(NativeArray<FIGJHEBAEKN> JOOBOILFNKM, NativeList<Entity> PNFNAEBJOEK, TransformAccessArray MCJONMBOGNP, TransformAccessArray FDFDJNJDKDF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C6A0F0", Offset = "0x3C68EF0", VA = "0x183C6A0F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x3E16830", Offset = "0x3E15630", VA = "0x183E16830", Slot = "14")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x3E16B60", Offset = "0x3E15960", VA = "0x183E16B60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x3E16940", Offset = "0x3E15740", VA = "0x183E16940")]
		private static void HHPPAKOEDEP(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, Entity ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x3E16AC0", Offset = "0x3E158C0", VA = "0x183E16AC0")]
		private static bool JIACBDMPAMB(EntityManager MKHPDCKNNBB, Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C26D10", Offset = "0x4C25B10", VA = "0x184C26D10")]
			[Conditional("DEBUG_BUILD")]
			private void HLDGAENDGPF(Entity IEFFOCOBJJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x4C26A20", Offset = "0x4C25820", VA = "0x184C26A20", Slot = "4")]
			public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x4C26DE0", Offset = "0x4C25BE0", VA = "0x184C26DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F42EA0", Offset = "0x3F41CA0", VA = "0x183F42EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x3F42FC0", Offset = "0x3F41DC0", VA = "0x183F42FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C201E0", Offset = "0x4C1EFE0", VA = "0x184C201E0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x4C202E0", Offset = "0x4C1F0E0", VA = "0x184C202E0")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery KHLHLOFGEDF;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x3F416F0", Offset = "0x3F404F0", VA = "0x183F416F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x3F41820", Offset = "0x3F40620", VA = "0x183F41820", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public KLHMGKNNHGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C21D70", Offset = "0x4C20B70", VA = "0x184C21D70", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x4C22120", Offset = "0x4C20F20", VA = "0x184C22120")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery AKKHHLBJIJB;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AE00", Offset = "0x3F29C00", VA = "0x183F2AE00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AF10", Offset = "0x3F29D10", VA = "0x183F2AF10", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public FAGGANCKJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C24BC0", Offset = "0x4C239C0", VA = "0x184C24BC0", Slot = "4")]
		public void Execute(ArchetypeChunk LDGNGMADGKK, int NPDGHPHAKDK, int BLGJNDLBLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x4C252D0", Offset = "0x4C240D0", VA = "0x184C252D0")]
		public bool NNBHJPBHOAE(ArchetypeChunk LDGNGMADGKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery AKKHHLBJIJB;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x3F41D20", Offset = "0x3F40B20", VA = "0x183F41D20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x3F41E50", Offset = "0x3F40C50", VA = "0x183F41E50", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DADNKIMPICM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	public KNCDCOBLKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6AB50", Offset = "0x3C69950", VA = "0x183C6AB50", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType AMCGLJABEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AB20", Offset = "0x3C69920", VA = "0x183C6AB20", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType OODCNKPPICD
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AAF0", Offset = "0x3C698F0", VA = "0x183C6AAF0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x3C53E60", Offset = "0x3C52C60", VA = "0x183C53E60")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E09720", Offset = "0x3E08520", VA = "0x183E09720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x3E090B0", Offset = "0x3E07EB0", VA = "0x183E090B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CA30", Offset = "0x3F2B830", VA = "0x183F2CA30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FHHPNKPLMJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class INJEBCEEHLP : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x3F3BA10", Offset = "0x3F3A810", VA = "0x183F3BA10", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public INJEBCEEHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DC90", Offset = "0x3F2CA90", VA = "0x183F2DC90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FICGJEKKHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class OMFLDFOCLJJ : DLPLBLIFJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x3C57570", Offset = "0x3C56370", VA = "0x183C57570", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public OMFLDFOCLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C63F60", Offset = "0x3C62D60", VA = "0x183C63F60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] PDBCIOGHAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x3C63BB0", Offset = "0x3C629B0", VA = "0x183C63BB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F33FD0", Offset = "0x3F32DD0", VA = "0x183F33FD0", Slot = "4")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F29230", Offset = "0x3F28030", VA = "0x183F29230", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3F28E00", Offset = "0x3F27C00", VA = "0x183F28E00", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3F28F00", Offset = "0x3F27D00", VA = "0x183F28F00")]
		public Entity EKMEMACGALM(Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3F291D0", Offset = "0x3F27FD0", VA = "0x183F291D0")]
		public bool LAPLJEJINGM(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3F28F50", Offset = "0x3F27D50", VA = "0x183F28F50")]
		public bool GBLKBIAEIPL(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE, bool NBCBLABIJMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x3F28FF0", Offset = "0x3F27DF0", VA = "0x183F28FF0")]
		private bool GDHEHGJFFEM(Entity IEFFOCOBJJI, Entity LCCGHHJFGDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E04DE0", Offset = "0x3E03BE0", VA = "0x183E04DE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x3E05200", Offset = "0x3E04000", VA = "0x183E05200", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x3E04DC0", Offset = "0x3E03BC0", VA = "0x183E04DC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x3E053C0", Offset = "0x3E041C0", VA = "0x183E053C0")]
	public bool ONFDIBDBOKI(Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x3E05090", Offset = "0x3E03E90", VA = "0x183E05090")]
	public IEnumerable<Entity> LHNLJGEEPBH(Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x3E05300", Offset = "0x3E04100", VA = "0x183E05300")]
	public bool OIGMHNPAGCC(Entity IEFFOCOBJJI, Entity ELFIACEEOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x3E04CB0", Offset = "0x3E03AB0", VA = "0x183E04CB0")]
	public bool BNNCMPPKFKP(Entity IEFFOCOBJJI, Entity BBDPANMBHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x3E04F00", Offset = "0x3E03D00", VA = "0x183E04F00")]
	public NativeList<Entity> IEEPKLPNIEF(Entity IEFFOCOBJJI, bool CCDLJLHECME = false, Allocator AEPJLHDIHPH = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x3E05480", Offset = "0x3E04280", VA = "0x183E05480")]
	public IEnumerable<Entity> PICEAKMECIB(Entity IEFFOCOBJJI, bool CCDLJLHECME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x3E04FE0", Offset = "0x3E03DE0", VA = "0x183E04FE0")]
	public Entity LGNFHDEKAND(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x3E04D70", Offset = "0x3E03B70", VA = "0x183E04D70")]
	public NativeArray<Entity> BNNIGJAFFAC()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x3E04E30", Offset = "0x3E03C30", VA = "0x183E04E30")]
	public bool GOHPGPBBEBL(Entity BBDPANMBHID, Entity PACKOPHLIKB, out Entity OCIPFMKDCPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x3E05150", Offset = "0x3E03F50", VA = "0x183E05150")]
	private Entity MAGJHAEAOAI(Entity IEFFOCOBJJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x33E9310", Offset = "0x33E8110", VA = "0x1833E9310")]
		public static void JGMOEBJPLEH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(OKKPKCPMOFL GNDGFHCLBLF, global::KBOIOIDENFM<Entity> AOKAOIOMMBG, out global::NJDCFGJOHMC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> BHEGBBGFCPN) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LFJBLBLGJHE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LFJBLBLGJHE, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x3C65410", Offset = "0x3C64210", VA = "0x183C65410")]
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
	[Cpp2IlInjected.Address(RVA = "0x42AAB20", Offset = "0x42A9920", VA = "0x1842AAB20")]
	public NJDCFGJOHMC(OKKPKCPMOFL GNDGFHCLBLF, global::KBOIOIDENFM<Entity> AOKAOIOMMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x42A9CB0", Offset = "0x42A8AB0", VA = "0x1842A9CB0")]
	private bool MKDANKEGIPK(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x42A9C60", Offset = "0x42A8A60", VA = "0x1842A9C60")]
	private bool MDALKKAJGJO(Entity IEFFOCOBJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x42A9C30", Offset = "0x42A8A30", VA = "0x1842A9C30")]
	public bool LAPLJEJINGM(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D70", Offset = "0x42A8B70", VA = "0x1842A9D70")]
	public bool OGAFOFCGLKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x42A9DA0", Offset = "0x42A8BA0", VA = "0x1842A9DA0")]
	private bool OGAFOFCGLKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE, bool GDNDPJPIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void FKFMAIIHMML(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void IJOMODFOKPM(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void CIMEMNGOLIF(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void LEIDIGHFBKP(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private static void DIPDHPHOKKK(Entity IEFFOCOBJJI, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x42AA1E0", Offset = "0x42A8FE0", VA = "0x1842AA1E0")]
	private bool ONFDIBDBOKI(Entity IEFFOCOBJJI, Entity OLFCKPDOOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x42A96E0", Offset = "0x42A84E0", VA = "0x1842A96E0")]
	private void FIKOBEBKDBP(Entity IEFFOCOBJJI, in Entity KFGEJHIJBGK, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x42A98F0", Offset = "0x42A86F0", VA = "0x1842A98F0")]
	private void JJLEDHBOEAA(Entity IEFFOCOBJJI, in Entity KFGEJHIJBGK, in Entity LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x42A92E0", Offset = "0x42A80E0", VA = "0x1842A92E0")]
	private bool DAMBMOELOGB(FOKMJKHMEIK ACABAHFPHCL, in AIELFMMICMN KAKGJMHAAEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x42AA3A0", Offset = "0x42A91A0", VA = "0x1842AA3A0")]
	private void PGODIABCAMB(Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x42A97D0", Offset = "0x42A85D0", VA = "0x1842A97D0")]
	private void HLPNFHFHFFD(Entity ICMEPOIJCJO, Entity ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	private void KCIJMJKBHEO(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
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
		[Cpp2IlInjected.Address(RVA = "0x775530", Offset = "0x774330", VA = "0x180775530", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HMIKLFBELAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BE0", Offset = "0x8C49E0", VA = "0x1808C5BE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C593D0", Offset = "0x3C581D0", VA = "0x183C593D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int NIINPFLMDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x3C5A3C0", Offset = "0x3C591C0", VA = "0x183C5A3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int FNGDFEABKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x3C57DF0", Offset = "0x3C56BF0", VA = "0x183C57DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x3353F10", Offset = "0x3352D10", VA = "0x183353F10", Slot = "4")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x3C5ABC0", Offset = "0x3C599C0", VA = "0x183C5ABC0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x3C59FB0", Offset = "0x3C58DB0", VA = "0x183C59FB0")]
		public void KNFCIAAKCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x3C57CA0", Offset = "0x3C56AA0", VA = "0x183C57CA0", Slot = "6")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x3C58E20", Offset = "0x3C57C20", VA = "0x183C58E20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3C59F90", Offset = "0x3C58D90", VA = "0x183C59F90")]
		public int KLEILBIFCLP(SceneTag PPJNHEBGICL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B620", Offset = "0x3C5A420", VA = "0x183C5B620")]
		public int POIOKMGKODA(SceneTag PPJNHEBGICL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B110", Offset = "0x3C59F10", VA = "0x183C5B110")]
		public bool OKIFBABICGJ(Entity IEFFOCOBJJI, Allocator AEPJLHDIHPH, out NativeList<Entity> OPCIAPFFKEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3C583B0", Offset = "0x3C571B0", VA = "0x183C583B0")]
		public bool DCIOMKBMMMH(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3C59ED0", Offset = "0x3C58CD0", VA = "0x183C59ED0")]
		public bool KFLIOAAFEFM(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A7A0", Offset = "0x3C595A0", VA = "0x183C5A7A0")]
		public bool MAKGCDLBBBK(Entity IEFFOCOBJJI, out GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A810", Offset = "0x3C59610", VA = "0x183C5A810")]
		private bool MAKGCDLBBBK(Transform FLCFNMLPAML, out GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x3C58D90", Offset = "0x3C57B90", VA = "0x183C58D90")]
		private void DIGPHILJGLP(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x3C58F50", Offset = "0x3C57D50", VA = "0x183C58F50")]
		private bool EDKKGBDGEDF(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x3C5ACF0", Offset = "0x3C59AF0", VA = "0x183C5ACF0")]
		public void MNFGPLMIANE(AIELFMMICMN CDEOFEMHEEC, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x3C57ED0", Offset = "0x3C56CD0", VA = "0x183C57ED0")]
		public bool CJKIOBBKHHH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x3C589E0", Offset = "0x3C577E0", VA = "0x183C589E0")]
		public bool DHANCBOLGKO(PMFFIMLMCEJ GMOMNBJDADO, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x3C58990", Offset = "0x3C57790", VA = "0x183C58990")]
		public bool DHANCBOLGKO(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x3C58970", Offset = "0x3C57770", VA = "0x183C58970")]
		public bool DHANCBOLGKO(GEINEDFCGEN JENEHFPKFDC, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x3C59420", Offset = "0x3C58220", VA = "0x183C59420")]
		public bool GKEDFHBNNKA(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x3C597F0", Offset = "0x3C585F0", VA = "0x183C597F0")]
		public bool GKEDFHBNNKA(GEINEDFCGEN NKDJGKIHEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x3C58600", Offset = "0x3C57400", VA = "0x183C58600")]
		public bool DHANCBOLGKO(GEINEDFCGEN NKDJGKIHEEA, [Optional] object KCCFEDJJGAN, bool PAKHNBOHLFK = false, bool IMODGJODCCN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x3C59820", Offset = "0x3C58620", VA = "0x183C59820")]
		public Transform HCCGAJBGGPD(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x3C59CD0", Offset = "0x3C58AD0", VA = "0x183C59CD0")]
		public bool JIACBDMPAMB(Entity IEFFOCOBJJI, out Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x3C59200", Offset = "0x3C58000", VA = "0x183C59200")]
		public GEINEDFCGEN FJINJLOCNAL(Entity IEFFOCOBJJI, [Optional] object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x3C58F70", Offset = "0x3C57D70", VA = "0x183C58F70")]
		public void FCMOAONOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A3E0", Offset = "0x3C591E0", VA = "0x183C5A3E0")]
		public void LHGPMLOGFNE(SceneTag PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A000", Offset = "0x3C58E00", VA = "0x183C5A000")]
		private void LEGKAOLGKJJ(Entity IEFFOCOBJJI, bool ANOIJBOMAFM, bool FLMMGPPLPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x3C59C30", Offset = "0x3C58A30", VA = "0x183C59C30")]
		private void JHGOEPJFGMO(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA, bool ANOIJBOMAFM, bool FLMMGPPLPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x3C592F0", Offset = "0x3C580F0", VA = "0x183C592F0")]
		public GEINEDFCGEN FLFFBLKEEFH(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x3C59BB0", Offset = "0x3C589B0", VA = "0x183C59BB0")]
		public bool JGLLIFJLHAE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B5A0", Offset = "0x3C5A3A0", VA = "0x183C5B5A0")]
		public bool PHJOIGAAGCH(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x3C59E60", Offset = "0x3C58C60", VA = "0x183C59E60")]
		public bool KBKAKBBJBHI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x3C58270", Offset = "0x3C57070", VA = "0x183C58270")]
		public bool DBCMAAAEHMC(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x3C582E0", Offset = "0x3C570E0", VA = "0x183C582E0")]
		public bool DBCMAAAEHMC(HMIKLFBELAH DCLMHANFEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void EOIIGNKEEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x3C59DA0", Offset = "0x3C58BA0", VA = "0x183C59DA0")]
		private void JKIJOBHFCDG(bool IGGFHHEDAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x3C59340", Offset = "0x3C58140", VA = "0x183C59340")]
		private bool FLNMKKGOGHA(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x3C59EF0", Offset = "0x3C58CF0", VA = "0x183C59EF0")]
		private GEINEDFCGEN KHGJDGAOKOE(Entity IEFFOCOBJJI, object KCCFEDJJGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x3C57990", Offset = "0x3C56790", VA = "0x183C57990")]
		private GEINEDFCGEN AANBONKKMMH(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x3C59990", Offset = "0x3C58790", VA = "0x183C59990")]
		private (Vector3, Quaternion, Vector3) HONLAKNIAPG(Entity IEFFOCOBJJI)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5AEF0", Offset = "0x3C59CF0", VA = "0x183C5AEF0")]
		private void NPFLBKMJAIN(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x3C57E10", Offset = "0x3C56C10", VA = "0x183C57E10")]
		private void CHIKFGIPBDO(PMFFIMLMCEJ GMOMNBJDADO, GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x3C57B80", Offset = "0x3C56980", VA = "0x183C57B80")]
		private void BCLDHJHDHMK(GEINEDFCGEN NKJBKNOEMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A8C0", Offset = "0x3C596C0", VA = "0x183C5A8C0")]
		private void MEJENFCFOCG(GEINEDFCGEN NKDJGKIHEEA, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B360", Offset = "0x3C5A160", VA = "0x183C5B360")]
		private void OOHGDDKLAJP(Entity IEFFOCOBJJI, GEINEDFCGEN NKDJGKIHEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B030", Offset = "0x3C59E30", VA = "0x183C5B030")]
		private void OKEEAAOGCHJ(Entity IEFFOCOBJJI, Transform FLCFNMLPAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B000", Offset = "0x3C59E00", VA = "0x183C5B000")]
		private PMFFIMLMCEJ OGPGFBOCGBO(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B690", Offset = "0x3C5A490", VA = "0x183C5B690")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x3C5AAF0", Offset = "0x3C598F0", VA = "0x183C5AAF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C56B80", Offset = "0x3C55980", VA = "0x183C56B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5C6F0", Offset = "0x3C5B4F0", VA = "0x183C5C6F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, PEMKGMKGDAH> FDOEINMOMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x3C5C650", Offset = "0x3C5B450", VA = "0x183C5C650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x3C5C820", Offset = "0x3C5B620", VA = "0x183C5C820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> CMOJGOJPGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x3C5C780", Offset = "0x3C5B580", VA = "0x183C5C780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x3C5CC70", Offset = "0x3C5BA70", VA = "0x183C5CC70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CB40", Offset = "0x3C5B940", VA = "0x183C5CB40", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x1095040", Offset = "0x1093E40", VA = "0x181095040", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CAC0", Offset = "0x3C5B8C0", VA = "0x183C5CAC0")]
		public bool LCJCOLBECPG(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C5F0", Offset = "0x3C5B3F0", VA = "0x183C5C5F0")]
		internal void FLAEOIMDEPF(Entity IEFFOCOBJJI, PEMKGMKGDAH NFNGIKPPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C740", Offset = "0x3C5B540", VA = "0x183C5C740")]
		public void HJMIDDMHEPE(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CC20", Offset = "0x3C5BA20", VA = "0x183C5CC20")]
		public void NOFMEPKGEFN(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BEC0", Offset = "0x3C5ACC0", VA = "0x183C5BEC0")]
		private bool CALDDMHHLKE(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C8C0", Offset = "0x3C5B6C0", VA = "0x183C5C8C0")]
		public void KGNKLNCMPDI(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C230", Offset = "0x3C5B030", VA = "0x183C5C230")]
		private bool EONGFJBCGJI(Entity IEFFOCOBJJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BE30", Offset = "0x3C5AC30", VA = "0x183C5BE30")]
		public void CAFIKGIFHPM(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BDD0", Offset = "0x3C5ABD0", VA = "0x183C5BDD0")]
		private void ADPHFKPCNIG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BF80", Offset = "0x3C5AD80", VA = "0x183C5BF80")]
		private void DDABKLLHJNG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C1E0", Offset = "0x3C5AFE0", VA = "0x183C5C1E0")]
		public void DHJNKJNMCAN(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private void BLEKLGEFGCL(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C3F0", Offset = "0x3C5B1F0", VA = "0x183C5C3F0")]
		private void FJFICDDJKAE(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
				[Cpp2IlInjected.Address(RVA = "0x2E6E280", Offset = "0x2E6D080", VA = "0x182E6E280", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C262C0", Offset = "0x4C250C0", VA = "0x184C262C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DB70", Offset = "0x4C1C970", VA = "0x184C1DB70")]
			[DebuggerHidden]
			public PBLEMCJJOJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x4C260E0", Offset = "0x4C24EE0", VA = "0x184C260E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x4C26280", Offset = "0x4C25080", VA = "0x184C26280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x4C261E0", Offset = "0x4C24FE0", VA = "0x184C261E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(PDAOCOFFNGC, PEMKGMKGDAH)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x4C261E0", Offset = "0x4C24FE0", VA = "0x184C261E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5FCB0", Offset = "0x3C5EAB0", VA = "0x183C5FCB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x3C603E0", Offset = "0x3C5F1E0", VA = "0x183C603E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x3C606A0", Offset = "0x3C5F4A0", VA = "0x183C606A0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FE20", Offset = "0x3C5EC20", VA = "0x183C5FE20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x3C60310", Offset = "0x3C5F110", VA = "0x183C60310")]
		internal IEnumerable<Type> FOPAHDPPJME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x3C60370", Offset = "0x3C5F170", VA = "0x183C60370")]
		internal ONKHKDOBJAL GEMMEHMHOEM(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FD00", Offset = "0x3C5EB00", VA = "0x183C5FD00")]
		public EntityArchetype DGAGOIDBGAD(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x3C60520", Offset = "0x3C5F320", VA = "0x183C60520")]
		public NativeHashMap<int, EntityArchetype> LCAFEGDBHKJ(Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F9A0", Offset = "0x3C5E7A0", VA = "0x183C5F9A0")]
		public bool CEIAPAFHDOL(PEMKGMKGDAH NFNGIKPPKJH, out EntityArchetype FAAKDBHJKLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F7C0", Offset = "0x3C5E5C0", VA = "0x183C5F7C0", Slot = "4")]
		[IteratorStateMachine(typeof(PBLEMCJJOJP))]
		public IEnumerable<(PDAOCOFFNGC, PEMKGMKGDAH)> BBKIFGLIMLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x3C601B0", Offset = "0x3C5EFB0", VA = "0x183C601B0")]
		public Entity FAKFHJIOGLF(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FDC0", Offset = "0x3C5EBC0", VA = "0x183C5FDC0")]
		public PEMKGMKGDAH DOKKMMPFKFK(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FD60", Offset = "0x3C5EB60", VA = "0x183C5FD60")]
		public PEMKGMKGDAH DOKKMMPFKFK(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(PEMKGMKGDAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F830", Offset = "0x3C5E630", VA = "0x183C5F830")]
		public NativeHashMap<int, Entity> BNOFEJBKGLC(Allocator AEPJLHDIHPH = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x3C602C0", Offset = "0x3C5F0C0", VA = "0x183C602C0")]
		public IEnumerable<PEMKGMKGDAH> FEAMMEKINDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x3C60150", Offset = "0x3C5EF50", VA = "0x183C60150")]
		public Entity EHKNDPLJDHA(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FA10", Offset = "0x3C5E810", VA = "0x183C5FA10")]
		public bool CFEDEDIJJMD(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F370", Offset = "0x3C5E170", VA = "0x183C5F370")]
		private void AAPNNMMCLNP(ONKHKDOBJAL ILBINHKPOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FA80", Offset = "0x3C5E880", VA = "0x183C5FA80")]
		internal void CGIFALKBEHL(PEMKGMKGDAH NFNGIKPPKJH, ComponentTypeList FOOIEEEGFDG, FPKNLHBDGEP ENCNEIHBNIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F210", Offset = "0x3C5E010", VA = "0x183C5F210")]
		private void AALOHBDPEMM(PEMKGMKGDAH NFNGIKPPKJH, ComponentTypeList IHFNCPHANDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x3C60400", Offset = "0x3C5F200", VA = "0x183C60400")]
		internal Entity JLKBKFODPAI(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x3C60AD0", Offset = "0x3C5F8D0", VA = "0x183C60AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E20230", Offset = "0x3E1F030", VA = "0x183E20230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private MDBAAKNLHNI LMHDHLGMLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x143A590", Offset = "0x1439390", VA = "0x18143A590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private LHHIGECFLLB JDACLIPOFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0xA56780", Offset = "0xA55580", VA = "0x180A56780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, FGFOHLOEDBC> PNFOKDAEDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x927A10", Offset = "0x926810", VA = "0x180927A10", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, FGFOHLOEDBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle OMAAMMGDLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1B0", Offset = "0x9EDFB0", VA = "0x1809EF1B0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xD4C770", Offset = "0xD4B570", VA = "0x180D4C770", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool KKIENAEPCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x3E20390", Offset = "0x3E1F190", VA = "0x183E20390", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World GMABANAEKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1F8D0", Offset = "0x3E1E6D0", VA = "0x183E1F8D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x3E203E0", Offset = "0x3E1F1E0", VA = "0x183E203E0")]
	public EIECINGNDLI(AHKBIJEMLBD HGLAEFBOOJL, HKIFOHOEGHF DCICIPKAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x3E20380", Offset = "0x3E1F180", VA = "0x183E20380", Slot = "11")]
	private void PHOOGHEPLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x3E20140", Offset = "0x3E1EF40", VA = "0x183E20140", Slot = "10")]
	private bool JIGEEPNLOKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FD60", Offset = "0x3E1EB60", VA = "0x183E1FD60", Slot = "12")]
	private void FDBIFLAEGPJ(ComponentType OMMPBBANJJE, in PJECKKFIGKG HHKBPEJHMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FA80", Offset = "0x3E1E880", VA = "0x183E1FA80", Slot = "13")]
	private bool DPKHJCPEDLL(PEMKGMKGDAH NFNGIKPPKJH, out Entity GLJOCEFKOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F610", Offset = "0x3E1E410", VA = "0x183E1F610", Slot = "16")]
	private bool AGLOCDBGMCJ(out NativeArray<int> OOFMEFFBOEL, Allocator AEPJLHDIHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FE50", Offset = "0x3E1EC50", VA = "0x183E1FE50", Slot = "17")]
	private bool HGPPMKGJAPK(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL, out HALLOMDKPOM ECGOBGEIPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FFD0", Offset = "0x3E1EDD0", VA = "0x183E1FFD0", Slot = "18")]
	private bool HGPPMKGJAPK(ComponentType OMMPBBANJJE, out PJECKKFIGKG OOIMAIIKJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x3E20290", Offset = "0x3E1F090", VA = "0x183E20290", Slot = "19")]
	private PJECKKFIGKG NPENIIJOLJK(ComponentType OMMPBBANJJE)
	{
		return default(PJECKKFIGKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x3E20100", Offset = "0x3E1EF00", VA = "0x183E20100", Slot = "20")]
	private ANLCPLEKFMI HJHJMLBCAJA()
	{
		return default(ANLCPLEKFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x3E203A0", Offset = "0x3E1F1A0", VA = "0x183E203A0", Slot = "21")]
	private void POAICCGIAPD(JobHandle CPPLLJNMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FAB0", Offset = "0x3E1E8B0", VA = "0x183E1FAB0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F6B0", Offset = "0x3E1E4B0", VA = "0x183E1F6B0")]
	private bool BHBIONNJICN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F930", Offset = "0x3E1E730", VA = "0x183E1F930")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E06310", Offset = "0x3E05110", VA = "0x183E06310", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public MDBAAKNLHNI DPFLAIIDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1F9D0", Offset = "0x4C1E7D0", VA = "0x184C1F9D0")]
			public GFLIHOBBBBM(PropertyDiffStateService KGAFOEANBBF, HKIFOHOEGHF EFHOBNEHINK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x4C1F9B0", Offset = "0x4C1E7B0", VA = "0x184C1F9B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public IEPINABNOFO GDGIAKPEFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x3BC5CB0", Offset = "0x3BC4AB0", VA = "0x183BC5CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public OKLEKHOLNCL CAFGCCINODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x3BC5CB0", Offset = "0x3BC4AB0", VA = "0x183BC5CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x1380850", Offset = "0x137F650", VA = "0x181380850")]
		public IEPINABNOFO HJEDPDBIHIP(HKIFOHOEGHF DCICIPKAADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x1380850", Offset = "0x137F650", VA = "0x181380850")]
		public OKLEKHOLNCL JADKLFBFLBE(HKIFOHOEGHF DCICIPKAADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C280", Offset = "0x3C6B080", VA = "0x183C6C280", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x3C6BC50", Offset = "0x3C6AA50", VA = "0x183C6BC50", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C200", Offset = "0x3C6B000", VA = "0x183C6C200")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C050", Offset = "0x3C6AE50", VA = "0x183C6C050", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C260", Offset = "0x3C6B060", VA = "0x183C6C260")]
		public GFLIHOBBBBM FFMPIIONNCL(HKIFOHOEGHF DCICIPKAADP)
		{
			return default(GFLIHOBBBBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C350", Offset = "0x3C6B150", VA = "0x183C6C350")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7FC20", Offset = "0x3E7EA20", VA = "0x183E7FC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> MCBKADDNCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x9EF190", Offset = "0x9EDF90", VA = "0x1809EF190")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x32F48B0", Offset = "0x32F36B0", VA = "0x1832F48B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity GCOBIHNJLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FCA0", Offset = "0x3E7EAA0", VA = "0x183E7FCA0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag NAOBPLLCNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FF20", Offset = "0x3E7ED20", VA = "0x183E7FF20")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity CGBFJIDFLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FF20", Offset = "0x3E7ED20", VA = "0x183E7FF20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FEB0", Offset = "0x3E7ECB0", VA = "0x183E7FEB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FF70", Offset = "0x3E7ED70", VA = "0x183E7FF70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x3E80B50", Offset = "0x3E7F950", VA = "0x183E80B50", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FDF0", Offset = "0x3E7EBF0", VA = "0x183E7FDF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FE40", Offset = "0x3E7EC40", VA = "0x183E7FE40")]
		public void FAIFBKGANNA(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FC70", Offset = "0x3E7EA70", VA = "0x183E7FC70")]
		public NativeArray<Entity> DEJBNDNMIAB(Allocator AEPJLHDIHPH = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x3E801D0", Offset = "0x3E7EFD0", VA = "0x183E801D0")]
		public void JBCFDECJIOI(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x3E80E60", Offset = "0x3E7FC60", VA = "0x183E80E60")]
		public Entity PCDLDDIDMHM(string IADPDEAGFAB = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F9A0", Offset = "0x3E7E7A0", VA = "0x183E7F9A0")]
		public void BHGFLPNBMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x3E80E40", Offset = "0x3E7FC40", VA = "0x183E80E40")]
		public void OFHLOHNGDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x3E80170", Offset = "0x3E7EF70", VA = "0x183E80170")]
		public void IILNOAFLELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F990", Offset = "0x3E7E790", VA = "0x183E7F990")]
		public void BCHHHHGFCIB(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FB70", Offset = "0x3E7E970", VA = "0x183E7FB70")]
		public bool CHMADMKFHMF(Entity PPJNHEBGICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FE30", Offset = "0x3E7EC30", VA = "0x183E7FE30")]
		public void EGDFHNKHAFP(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x3E80C30", Offset = "0x3E7FA30", VA = "0x183E80C30")]
		public string MPBBMFNKCLC(Entity PPJNHEBGICL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		public void FDGCKPEPFMG(Entity PPJNHEBGICL, string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x3E810C0", Offset = "0x3E7FEC0", VA = "0x183E810C0")]
		public bool PNLIFCMGBMD(string IADPDEAGFAB, out Entity PPJNHEBGICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x3E80A40", Offset = "0x3E7F840", VA = "0x183E80A40")]
		public void LGCCJADAOLA(Entity PPJNHEBGICL, bool MGCIKFODOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x3E81040", Offset = "0x3E7FE40", VA = "0x183E81040")]
		public void PIDNAOPPIJH(Entity IEFFOCOBJJI, bool FCELOHALIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x3E80FD0", Offset = "0x3E7FDD0", VA = "0x183E80FD0")]
		public void PIDNAOPPIJH(NativeArray<Entity> BNEBECKGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x3E80EE0", Offset = "0x3E7FCE0", VA = "0x183E80EE0")]
		public void PIDNAOPPIJH(EntityQuery FBENFNFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F760", Offset = "0x3E7E560", VA = "0x183E7F760")]
		public void AGDPBFCLLLJ(Entity IEFFOCOBJJI, Entity PPJNHEBGICL, bool FCELOHALIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F4D0", Offset = "0x3E7E2D0", VA = "0x183E7F4D0")]
		public void AGDPBFCLLLJ(NativeArray<Entity> BNEBECKGGLP, Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F6B0", Offset = "0x3E7E4B0", VA = "0x183E7F6B0")]
		public void AGDPBFCLLLJ(EntityQuery FBENFNFLPOM, Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F9C0", Offset = "0x3E7E7C0", VA = "0x183E7F9C0")]
		private void BJDACDAJAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FE80", Offset = "0x3E7EC80", VA = "0x183E7FE80")]
		private void FECNKLMFCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FCA0", Offset = "0x3E7EAA0", VA = "0x183E7FCA0")]
		private Entity DENBPMGFOMD()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x3E80730", Offset = "0x3E7F530", VA = "0x183E80730")]
		private void KKEOIFIMCKL(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x3E805B0", Offset = "0x3E7F3B0", VA = "0x183E805B0")]
		private void JNELMMFBGED(EntityQuery HPJKJIMEHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x3E802D0", Offset = "0x3E7F0D0", VA = "0x183E802D0")]
		private void JNELMMFBGED(NativeArray<Entity> MMKJPCINEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x3E80680", Offset = "0x3E7F480", VA = "0x183E80680")]
		private void JNJBAPKMHLB(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x3E807E0", Offset = "0x3E7F5E0", VA = "0x183E807E0")]
		private void KOHKPCHKOCD(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x3E80970", Offset = "0x3E7F770", VA = "0x183E80970")]
		private void LBAKJFEFKOK(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x3E80150", Offset = "0x3E7EF50", VA = "0x183E80150")]
		private void HIOAIAEPFAC(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FFC0", Offset = "0x3E7EDC0", VA = "0x183E7FFC0")]
		private void HAAMFEJFMCH(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x3E80DA0", Offset = "0x3E7FBA0", VA = "0x183E80DA0")]
		private void NKADCNECGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x4BB1450", Offset = "0x4BB0250", VA = "0x184BB1450")]
		private void BDINBBPBCLK<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void AEFGDEMOBLH(SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x3E80D40", Offset = "0x3E7FB40", VA = "0x183E80D40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NBBGBMDPIIP(EntityQuery FBENFNFLPOM, string IADPDEAGFAB, SceneTag IIGMBPNLIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x3E80A10", Offset = "0x3E7F810", VA = "0x183E80A10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LBEJHFJOBOJ(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OFBMCHDHBIO(Entity PPJNHEBGICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8F620", Offset = "0x3E8E420", VA = "0x183E8F620")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F6E0", Offset = "0x3E8E4E0", VA = "0x183E8F6E0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F2C0", Offset = "0x3E8E0C0", VA = "0x183E8F2C0", Slot = "5")]
		public void FAIFBKGANNA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F430", Offset = "0x3E8E230", VA = "0x183E8F430", Slot = "6")]
		public bool FIHCIEBDFLE(PMFFIMLMCEJ GMOMNBJDADO, Transform FLCFNMLPAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F670", Offset = "0x3E8E470", VA = "0x183E8F670")]
		private bool JBKHFMNAEHO(Scene PPJNHEBGICL, out Entity MOHJOPANEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F770", Offset = "0x3E8E570", VA = "0x183E8F770")]
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
		private ComponentTypeList IHFNCPHANDK;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int BCBDBMHFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x3E858D0", Offset = "0x3E846D0", VA = "0x183E858D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity HDJJNJMCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager KEPLCDNBIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x3E85C50", Offset = "0x3E84A50", VA = "0x183E85C50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2CF0", Offset = "0x4BB1AF0", VA = "0x184BB2CF0")]
		public T CIGAFCHFFML<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2DB0", Offset = "0x4BB1BB0", VA = "0x184BB2DB0")]
		public void FAFPJPFNCCD<T>(T DFEOJBAFBHE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x3E85FA0", Offset = "0x3E84DA0", VA = "0x183E85FA0", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x3E85730", Offset = "0x3E84530", VA = "0x183E85730", Slot = "5")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x3E85730", Offset = "0x3E84530", VA = "0x183E85730")]
		private void LOKMFKIGEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x3E85980", Offset = "0x3E84780", VA = "0x183E85980", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x3E85CA0", Offset = "0x3E84AA0", VA = "0x183E85CA0")]
		private ComponentTypeList GKPEFFHHJOH()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void JEGPKEJAKCF(int MIOCJKOOLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
		private static void KJBBABONHEK(Type IGEIBCJNCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x3E858E0", Offset = "0x3E846E0", VA = "0x183E858E0")]
		private static void DIOBFOIHAOA(Type IGEIBCJNCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KGEAMOGNOJJ ECNJPOKIBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KGEAMOGNOJJ LIBOGJAGOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KGEAMOGNOJJ EGMMKIJEOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KGEAMOGNOJJ LGLGKHLFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KGEAMOGNOJJ ILCKBEJPNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager KEPLCDNBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D700", Offset = "0x3F3C500", VA = "0x183F3D700")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D750", Offset = "0x3F3C550", VA = "0x183F3D750", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x3F3D610", Offset = "0x3F3C410", VA = "0x183F3D610", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE080", Offset = "0x3FBCE80", VA = "0x183FBE080")]
	private void JGMOEBJPLEH<T>(ref global::JAGLGPBNCCL<T> BHBEGJLFINL) where T : struct, ADNHFABDAIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE080", Offset = "0x3FBCE80", VA = "0x183FBE080")]
	private void JGMOEBJPLEH<TC, TV>(ref global::LIFNMLFFFJC<TC, TV> BHBEGJLFINL) where TC : struct, ADNHFABDAIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x1973740", Offset = "0x1972540", VA = "0x181973740")]
		get
		{
			return default(OCGEMJOOKNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x3E04C60", Offset = "0x3E03A60", VA = "0x183E04C60", Slot = "4")]
	public void PACEPADOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x3E04C50", Offset = "0x3E03A50", VA = "0x183E04C50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C1EC20", Offset = "0x4C1DA20", VA = "0x184C1EC20")]
			public FDNDAGFHDFE(TransformOwnershipPhase ICMEPOIJCJO, BLPMHBGIGLO DCICIPKAADP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x4C1EC00", Offset = "0x4C1DA00", VA = "0x184C1EC00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
			get
			{
				return default(BLPMHBGIGLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x733300", Offset = "0x732100", VA = "0x180733300")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool LCAGCNDJMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x1B10A00", Offset = "0x1B0F800", VA = "0x181B10A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool ABKMPPMFLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x2709FE0", Offset = "0x2708DE0", VA = "0x182709FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x3E89300", Offset = "0x3E88100", VA = "0x183E89300")]
		public FDNDAGFHDFE PPILHCOPBKG()
		{
			return default(FDNDAGFHDFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x3E892D0", Offset = "0x3E880D0", VA = "0x183E892D0")]
		public FDNDAGFHDFE FGBFLAMNBKN()
		{
			return default(FDNDAGFHDFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0E850", Offset = "0x3E0D650", VA = "0x183E0E850", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E000", Offset = "0x3E0CE00", VA = "0x183E0E000", Slot = "5")]
		public bool IJDODDJFFED(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E780", Offset = "0x3E0D580", VA = "0x183E0E780", Slot = "7")]
		public Guid LPLCNJAAPMN(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DB60", Offset = "0x3E0C960", VA = "0x183E0DB60", Slot = "8")]
		public void HJBPCFPJILK(PMFFIMLMCEJ GMOMNBJDADO, Guid GKKMLLNMKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E6B0", Offset = "0x3E0D4B0", VA = "0x183E0E6B0", Slot = "9")]
		public Guid LGJIIEIOIIO(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D8B0", Offset = "0x3E0C6B0", VA = "0x183E0D8B0", Slot = "10")]
		public void BBOHCMJLLCH(PMFFIMLMCEJ GMOMNBJDADO, Guid DDCPNJANHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DB10", Offset = "0x3E0C910", VA = "0x183E0DB10", Slot = "11")]
		public bool BKGANEOPPAB(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DF90", Offset = "0x3E0CD90", VA = "0x183E0DF90", Slot = "12")]
		public void IEMICBDGJNA(PMFFIMLMCEJ GMOMNBJDADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E100", Offset = "0x3E0CF00", VA = "0x183E0E100", Slot = "13")]
		public void JPJCGMLGEFA(PMFFIMLMCEJ IBCPLIFFFGK, PMFFIMLMCEJ ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E8F0", Offset = "0x3E0D6F0", VA = "0x183E0E8F0")]
		private void POMOOCHKJEF(FBKIOBCBAGM KJBKDPLLBPK, PMFFIMLMCEJ ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E4C0", Offset = "0x3E0D2C0", VA = "0x183E0E4C0")]
		private void LBOAHCLJNPJ(FBKIOBCBAGM KJBKDPLLBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DDC0", Offset = "0x3E0CBC0", VA = "0x183E0DDC0")]
		private bool HOJKMIFGMGD(BDCNBKPMJEP GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D800", Offset = "0x3E0C600", VA = "0x183E0D800")]
		private bool AHPJLCPCJEF(BDCNBKPMJEP GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E650", Offset = "0x3E0D450", VA = "0x183E0E650", Slot = "6")]
		public bool LGJFFFBKJIL(PMFFIMLMCEJ ALJACNMOIMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
				[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E7E510", Offset = "0x3E7D310", VA = "0x183E7E510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x9FCF30", Offset = "0x9FBD30", VA = "0x1809FCF30")]
			[DebuggerHidden]
			public LIMGMAJMLIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E560", Offset = "0x3E7D360", VA = "0x183E7E560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E120", Offset = "0x3E7CF20", VA = "0x183E7E120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E630", Offset = "0x3E7D430", VA = "0x183E7E630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E680", Offset = "0x3E7D480", VA = "0x183E7E680")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E4D0", Offset = "0x3E7D2D0", VA = "0x183E7E4D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E420", Offset = "0x3E7D220", VA = "0x183E7E420", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PMFFIMLMCEJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E420", Offset = "0x3E7D220", VA = "0x183E7E420", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x77D8A0", Offset = "0x77C6A0", VA = "0x18077D8A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x83C070", Offset = "0x83AE70", VA = "0x18083C070", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ> KHEHPEBECLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x3E136D0", Offset = "0x3E124D0", VA = "0x183E136D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x3E14000", Offset = "0x3E12E00", VA = "0x183E14000", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ> HDCDKKEOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x3E14470", Offset = "0x3E13270", VA = "0x183E14470", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x3E13A80", Offset = "0x3E12880", VA = "0x183E13A80", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<PMFFIMLMCEJ, PMFFIMLMCEJ, PMFFIMLMCEJ> AOBHFDAFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x3E139E0", Offset = "0x3E127E0", VA = "0x183E139E0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x3E13DA0", Offset = "0x3E12BA0", VA = "0x183E13DA0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<PMFFIMLMCEJ> IKJBHGKCBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x3E142C0", Offset = "0x3E130C0", VA = "0x183E142C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x3E13110", Offset = "0x3E11F10", VA = "0x183E13110", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x3E140A0", Offset = "0x3E12EA0", VA = "0x183E140A0", Slot = "25")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x3E12A00", Offset = "0x3E11800", VA = "0x183E12A00", Slot = "26")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x3E131B0", Offset = "0x3E11FB0", VA = "0x183E131B0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x3E13800", Offset = "0x3E12600", VA = "0x183E13800")]
		private void GJGJPMHDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x3E13360", Offset = "0x3E12160", VA = "0x183E13360")]
		private void ECFOGJHIMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x3E13E40", Offset = "0x3E12C40", VA = "0x183E13E40")]
		private void LIFEDEIOPMO(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x3E14360", Offset = "0x3E13160", VA = "0x183E14360")]
		private void OPNECLNJDDG(Entity IEFFOCOBJJI, OEMFGOLGDMG DLFEJOALJGM, PEKIEJLMCEO FDANAHCAINP, PEKIEJLMCEO MKDFAPBMCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1B87730", Offset = "0x1B86530", VA = "0x181B87730", Slot = "14")]
		public PMFFIMLMCEJ NDAKBMDKHPJ(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x23F4E10", Offset = "0x23F3C10", VA = "0x1823F4E10", Slot = "15")]
		public Color OHIAIIOJMAB(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x3E12EA0", Offset = "0x3E11CA0", VA = "0x183E12EA0", Slot = "16")]
		public float3 CCAKFCNADGN(PMFFIMLMCEJ GMOMNBJDADO, int DGDCAIBHINB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x3E143C0", Offset = "0x3E131C0", VA = "0x183E143C0", Slot = "17")]
		public bool PEFMDIEBKFL(PMFFIMLMCEJ GMOMNBJDADO, PMFFIMLMCEJ GMANPLBBDPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x3E13620", Offset = "0x3E12420", VA = "0x183E13620", Slot = "18")]
		public PMFFIMLMCEJ EHHPCCNKBGC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x3E134D0", Offset = "0x3E122D0", VA = "0x183E134D0", Slot = "21")]
		public void EDCMGEGFKLI(PMFFIMLMCEJ GMOMNBJDADO, Vector3 NFGBMNLOFOC, Quaternion AELLGGHNCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x3E14220", Offset = "0x3E13020", VA = "0x183E14220", Slot = "23")]
		public float3 MOPNALDCMEC(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x3E13770", Offset = "0x3E12570", VA = "0x183E13770", Slot = "24")]
		public quaternion GFHOBBALCOM(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x3E12730", Offset = "0x3E11530", VA = "0x183E12730", Slot = "28")]
		public RigidTransform BDOOIJKNLLO(FJAKKJCOGLM CHCLCLFDGOH)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x3E13860", Offset = "0x3E12660", VA = "0x183E13860", Slot = "22")]
		public bool HOJJGBLMLJD(PMFFIMLMCEJ GMOMNBJDADO, out RigidTransform EIAPPNLJHEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x3E13080", Offset = "0x3E11E80", VA = "0x183E13080", Slot = "19")]
		[IteratorStateMachine(typeof(LIMGMAJMLIA))]
		public IEnumerable<PMFFIMLMCEJ> CFAKAHJEKLJ(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x3E13C40", Offset = "0x3E12A40", VA = "0x183E13C40", Slot = "20")]
		public PMFFIMLMCEJ KOIEJHABPCD(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x3E12830", Offset = "0x3E11630", VA = "0x183E12830", Slot = "29")]
		public void BGOPIGFMNMF(ref List<PMFFIMLMCEJ> HCIALCFLHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x3E13B20", Offset = "0x3E12920", VA = "0x183E13B20")]
		private Entity KOIEJHABPCD(Entity IEFFOCOBJJI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x3E145A0", Offset = "0x3E133A0", VA = "0x183E145A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5B9F0", Offset = "0x3C5A7F0", VA = "0x183C5B9F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BC50", Offset = "0x3C5AA50", VA = "0x183C5BC50", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BA40", Offset = "0x3C5A840", VA = "0x183C5BA40")]
		public Entity INDBOJHFAIL(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B7A0", Offset = "0x3C5A5A0", VA = "0x183C5B7A0")]
		public Entity DDBABLLMGCD(AIELFMMICMN CDEOFEMHEEC, PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B750", Offset = "0x3C5A550", VA = "0x183C5B750")]
		public Entity CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B710", Offset = "0x3C5A510", VA = "0x183C5B710")]
		public Entity CEOIJANDDEJ(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BB80", Offset = "0x3C5A980", VA = "0x183C5BB80")]
		public Entity KMAEBAOIOFC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BBC0", Offset = "0x3C5A9C0", VA = "0x183C5BBC0")]
		public Entity MLJMHNFKMOG(PDAOCOFFNGC IGEIBCJNCHF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B960", Offset = "0x3C5A760", VA = "0x183C5B960")]
		public Entity FGEKKLAKOKM(OLDNDABJJEI IGEIBCJNCHF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B8C0", Offset = "0x3C5A6C0", VA = "0x183C5B8C0")]
		public NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)> FAKFHJIOGLF(NativeArray<PMFFIMLMCEJ> GGDMFBHILFL, Allocator AEPJLHDIHPH)
		{
			return default(NativeArray<(PMFFIMLMCEJ, PMFFIMLMCEJ)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B910", Offset = "0x3C5A710", VA = "0x183C5B910")]
		public IEnumerable<PEMKGMKGDAH> FEAMMEKINDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B800", Offset = "0x3C5A600", VA = "0x183C5B800")]
		public EntityArchetype DGAGOIDBGAD(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B860", Offset = "0x3C5A660", VA = "0x183C5B860")]
		public Entity EHKNDPLJDHA(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B710", Offset = "0x3C5A510", VA = "0x183C5B710")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B750", Offset = "0x3C5A550", VA = "0x183C5B750")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH, bool KLIFPCONCCF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BA60", Offset = "0x3C5A860", VA = "0x183C5BA60")]
		private Entity IOPMOANMIJP(PEMKGMKGDAH NFNGIKPPKJH, AIELFMMICMN CDEOFEMHEEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C65FE0", Offset = "0x3C64DE0", VA = "0x183C65FE0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x3C66410", Offset = "0x3C65210", VA = "0x183C66410", Slot = "9")]
		public void PACEPADOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x3C662B0", Offset = "0x3C650B0", VA = "0x183C662B0", Slot = "10")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x3C656C0", Offset = "0x3C644C0", VA = "0x183C656C0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x3C65D20", Offset = "0x3C64B20", VA = "0x183C65D20", Slot = "4")]
		public FGLBLDPHAAD IECDPFAFKKE(Entity IEFFOCOBJJI)
		{
			return default(FGLBLDPHAAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3C66020", Offset = "0x3C64E20", VA = "0x183C66020", Slot = "5")]
		public void KJMPEKBEAAD(NativeArray<FGLBLDPHAAD> ANAONBGCBEJ, NativeArray<CFIMDNLGMOJ> HJIDIDOFHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x3C65450", Offset = "0x3C64250", VA = "0x183C65450", Slot = "6")]
		public void ALEEAKBECHD(FGLBLDPHAAD DCLMHANFEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3C66370", Offset = "0x3C65170", VA = "0x183C66370", Slot = "7")]
		public bool OJLLAOEBLPB(FGLBLDPHAAD DCLMHANFEGK, out Collider AMDPNFGBEBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3C65A10", Offset = "0x3C64810", VA = "0x183C65A10")]
		public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x3C65E70", Offset = "0x3C64C70", VA = "0x183C65E70")]
		private void ILDOJDHDCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x8C4970", Offset = "0x8C3770", VA = "0x1808C4970")]
		private void PBGPPFBEHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x3C66580", Offset = "0x3C65380", VA = "0x183C66580")]
		private void PGDAHOHKALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x161E970", Offset = "0x161D770", VA = "0x18161E970")]
		private void IOAMGOFJOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x3C65EC0", Offset = "0x3C64CC0", VA = "0x183C65EC0")]
		private BoxCollider JPJJNPDDEMB(Entity IEFFOCOBJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x3C65520", Offset = "0x3C64320", VA = "0x183C65520")]
		private void CGLFLBHJFGP(BoxCollider PCKKLDIHMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x3C66230", Offset = "0x3C65030", VA = "0x183C66230")]
		[Conditional("UNITY_EDITOR")]
		private void MEGALPCGMGC(GameObject NCAOMIEGHPA, Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x3C665D0", Offset = "0x3C653D0", VA = "0x183C665D0")]
		private void PNFNAMDJOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x3C655A0", Offset = "0x3C643A0", VA = "0x183C655A0")]
		private void DCCKICEHFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x3C657C0", Offset = "0x3C645C0", VA = "0x183C657C0")]
		private void EIDKGHGLBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x3C659D0", Offset = "0x3C647D0", VA = "0x183C659D0")]
		private void FAENLEHPIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x3C656B0", Offset = "0x3C644B0", VA = "0x183C656B0")]
		private void DPEDFIJKFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x3C66270", Offset = "0x3C65070", VA = "0x183C66270")]
		private void MHPHFOFFLBI(Scene KKMHBLHDEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x3C65A00", Offset = "0x3C64800", VA = "0x183C65A00", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F441B0", Offset = "0x3F42FB0", VA = "0x183F441B0", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x3F43D30", Offset = "0x3F42B30", VA = "0x183F43D30")]
	public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, out GJJLCPLKMOF MLHEJPEMPIL, out Entity FCDBIEPFJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x3F44220", Offset = "0x3F43020", VA = "0x183F44220")]
	public static bool NFELNFGCMKM(in Span<GJJLCPLKMOF> JIFPJBCIHDM, float JFMOIJLKEGH, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x3F43D00", Offset = "0x3F42B00", VA = "0x183F43D00")]
	public static float CMGIIPLEMCM(float ENHNHFJMKPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public LJLMGMKKJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x3F44320", Offset = "0x3F43120", VA = "0x183F44320", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7C9E0", Offset = "0x3E7B7E0", VA = "0x183E7C9E0", Slot = "4")]
		public void Execute(int NPDGHPHAKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D2D0", Offset = "0x3E7C0D0", VA = "0x183E7D2D0")]
		private static float3 KPGPKAPBJHG(in float4x4 GJGNOLNHHHL, in float3 ONINKGDNEEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CDC0", Offset = "0x3E7BBC0", VA = "0x183E7CDC0")]
		private static float3 GFFAOJODAAP(in float4x4 GJGNOLNHHHL, in float3 LNMAPJNBGLF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CCC0", Offset = "0x3E7BAC0", VA = "0x183E7CCC0")]
		private static float3 FMPDIJAMFPB(in float4x4 GJGNOLNHHHL, in float3 ONINKGDNEEG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C7C0", Offset = "0x3E7B5C0", VA = "0x183E7C7C0")]
		private static float3 BENNPJENLPE(in float4x4 GJGNOLNHHHL, in float3 LNMAPJNBGLF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CF80", Offset = "0x3E7BD80", VA = "0x183E7CF80")]
		private bool JJCCPKLBFGF(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, in NativeArray<Entity> CFCHICCPODI, out float3 MLHEJPEMPIL, out float3 FEMBJLJDLPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D3A0", Offset = "0x3E7C1A0", VA = "0x183E7D3A0")]
		public static bool LEKMHCLEFJA(in float3 CBFFHAOEBOM, in float3 EPCIEIJKPMH, in float3 JFGMAFEPGME, in float3 MODBHGKBMHD, float MIKFOOFEIMF, float IJCOEPFDNAB, out float PHLICBNKKOO, out float3 HOHFMJFIEBG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager MKHPDCKNNBB;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x3E20BD0", Offset = "0x3E1F9D0", VA = "0x183E20BD0", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x3E206E0", Offset = "0x3E1F4E0", VA = "0x183E206E0")]
	public void HFCCBFOEMBC(in NativeArray<Entity> BNEBECKGGLP, in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, in NativeArray<GJJLCPLKMOF> GEGOKFDMMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public EKCJLPGJJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x3E20BC0", Offset = "0x3E1F9C0", VA = "0x183E20BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x785430", Offset = "0x784230", VA = "0x180785430")]
			get
			{
				return default(NativeHashMap<AIELFMMICMN, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint HPEACKKAJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x3C5EFD0", Offset = "0x3C5DDD0", VA = "0x183C5EFD0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool NMMHNMGCMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8B0", Offset = "0x8FC6B0", VA = "0x1808FD8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x8FDDA0", Offset = "0x8FCBA0", VA = "0x1808FDDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EE80", Offset = "0x3C5DC80", VA = "0x183C5EE80", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EC30", Offset = "0x3C5DA30", VA = "0x183C5EC30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x3C5ECA0", Offset = "0x3C5DAA0", VA = "0x183C5ECA0")]
		public void EMOCNNJJBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F000", Offset = "0x3C5DE00", VA = "0x183C5F000")]
		public void OOAHHCOJLHM(AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EFA0", Offset = "0x3C5DDA0", VA = "0x183C5EFA0")]
		private PMFFIMLMCEJ OGPGFBOCGBO(Entity IEFFOCOBJJI)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EA00", Offset = "0x3C5D800", VA = "0x183C5EA00")]
		public PMFFIMLMCEJ ABIIJDLPNOE(AIELFMMICMN CDEOFEMHEEC)
		{
			return default(PMFFIMLMCEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EAE0", Offset = "0x3C5D8E0", VA = "0x183C5EAE0")]
		public AIELFMMICMN CIDLEEFEFNC(PMFFIMLMCEJ GMOMNBJDADO)
		{
			return default(AIELFMMICMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5ED20", Offset = "0x3C5DB20", VA = "0x183C5ED20")]
		public void GIIFDIMJIKJ(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EBD0", Offset = "0x3C5D9D0", VA = "0x183C5EBD0")]
		public void DNDDENNMNJF(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EB70", Offset = "0x3C5D970", VA = "0x183C5EB70")]
		public void CKIBNCNGNFL(Entity IEFFOCOBJJI, AIELFMMICMN CDEOFEMHEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EDB0", Offset = "0x3C5DBB0", VA = "0x183C5EDB0")]
		public void LLHJEKFKFEG(Entity IEFFOCOBJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C6CBB0", Offset = "0x3C6B9B0", VA = "0x183C6CBB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D4E0", Offset = "0x3C6C2E0", VA = "0x183C6D4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action IMLDCPJFCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x3C6C3F0", Offset = "0x3C6B1F0", VA = "0x183C6C3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x3C6D2D0", Offset = "0x3C6C0D0", VA = "0x183C6D2D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D280", Offset = "0x3C6C080", VA = "0x183C6D280", Slot = "4")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C720", Offset = "0x3C6B520", VA = "0x183C6C720", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D370", Offset = "0x3C6C170", VA = "0x183C6D370")]
		public void MNFGPLMIANE(OEMFGOLGDMG DLFEJOALJGM, CAGCNOEEMMG KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CC50", Offset = "0x3C6BA50", VA = "0x183C6CC50")]
		public void MFJOMNDPBAP(OEMFGOLGDMG DLFEJOALJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C490", Offset = "0x3C6B290", VA = "0x183C6C490")]
		internal void DHLPKFNGLCM(IEPINABNOFO IDIIBDOHICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CD40", Offset = "0x3C6BB40", VA = "0x183C6CD40")]
		private void MIJFKMEGMJN(IEPINABNOFO IDIIBDOHICE, int CNNKHGOHIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C930", Offset = "0x3C6B730", VA = "0x183C6C930")]
		private void GNJMKLKNGHG(ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM, NPGPDJOLJIL FJNIFBKOEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C7B0", Offset = "0x3C6B5B0", VA = "0x183C6C7B0")]
		private OBMHKHBNGLF GMHJMJOAPGF(ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM)
		{
			return default(OBMHKHBNGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D580", Offset = "0x3C6C380", VA = "0x183C6D580")]
		private NPGPDJOLJIL PIIGEKDIIOC(OBMHKHBNGLF ECGOBGEIPCF, ONEPLGLDGPM DEIOLBFJFGO, KANENNLDGEA NMEFJLIPHHM)
		{
			return default(NPGPDJOLJIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D6C0", Offset = "0x3C6C4C0", VA = "0x183C6D6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C265D0", Offset = "0x4C253D0", VA = "0x184C265D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF30", Offset = "0x9FBD30", VA = "0x1809FCF30")]
		[DebuggerHidden]
		public PHJJKCPCNLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x4C26420", Offset = "0x4C25220", VA = "0x184C26420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x4C26590", Offset = "0x4C25390", VA = "0x184C26590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x4C264E0", Offset = "0x4C252E0", VA = "0x184C264E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMFFIMLMCEJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x4C264E0", Offset = "0x4C252E0", VA = "0x184C264E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C55530", Offset = "0x3C54330", VA = "0x183C55530")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private CGJFLAGLGMG GBGKPEOJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x3C55AE0", Offset = "0x3C548E0", VA = "0x183C55AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x3C55A50", Offset = "0x3C54850", VA = "0x183C55A50", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x3C550B0", Offset = "0x3C53EB0", VA = "0x183C550B0", Slot = "5")]
	public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x3C55270", Offset = "0x3C54070", VA = "0x183C55270", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x3C55C40", Offset = "0x3C54A40", VA = "0x183C55C40")]
	private void NNLLFDMMCFO(Entity LJMJHEJCGON, in PEKIEJLMCEO GPIBDBLFJEE, in PEKIEJLMCEO ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x3C558A0", Offset = "0x3C546A0", VA = "0x183C558A0", Slot = "14")]
	public PMFFIMLMCEJ KMAEBAOIOFC()
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x3C551B0", Offset = "0x3C53FB0", VA = "0x183C551B0", Slot = "10")]
	public void CFOLGKJEIBA(PMFFIMLMCEJ GMOMNBJDADO, NDMIFLOOPHF FHLNMMPFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x3C55470", Offset = "0x3C54270", VA = "0x183C55470", Slot = "9")]
	public NDMIFLOOPHF GCKNPNBEFPA(PMFFIMLMCEJ GMOMNBJDADO)
	{
		return default(NDMIFLOOPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x3C55580", Offset = "0x3C54380", VA = "0x183C55580", Slot = "11")]
	public PMFFIMLMCEJ JHFAFONMIJE(PMFFIMLMCEJ CJCOOPPJGHI, [Optional] Vector3? IJBELJOFGFA, [Optional] Quaternion? EIGPDNIOAKK, [Optional] Vector3? LAKBNONGKOL)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x3C55A10", Offset = "0x3C54810", VA = "0x183C55A10", Slot = "15")]
	public PMFFIMLMCEJ MFHODAMJOAH(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK, [Optional] Vector3? IJBELJOFGFA, [Optional] Quaternion? EIGPDNIOAKK, [Optional] Vector3? LAKBNONGKOL)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x3C55920", Offset = "0x3C54720", VA = "0x183C55920", Slot = "7")]
	public PMFFIMLMCEJ LIFGBGDNNEF(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK)
	{
		return default(PMFFIMLMCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x3C56060", Offset = "0x3C54E60", VA = "0x183C56060", Slot = "16")]
	public void PAHIHDCEADN(PMFFIMLMCEJ LHDCFFBCJLG, PMFFIMLMCEJ KBGCHGICHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F10", Offset = "0x3C53D10", VA = "0x183C54F10", Slot = "12")]
	public void BIJHKBDOELI(PMFFIMLMCEJ LHDCFFBCJLG, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x3C55EC0", Offset = "0x3C54CC0", VA = "0x183C55EC0", Slot = "17")]
	public void NOEJMGPDKMA(PMFFIMLMCEJ LHDCFFBCJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x3C55BA0", Offset = "0x3C549A0", VA = "0x183C55BA0", Slot = "8")]
	public int NMDCOKGEBPA(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x3C56120", Offset = "0x3C54F20", VA = "0x183C56120", Slot = "6")]
	[IteratorStateMachine(typeof(PHJJKCPCNLM))]
	public IEnumerable<PMFFIMLMCEJ> PPOGLGAEIDH(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x3C55320", Offset = "0x3C54120", VA = "0x183C55320")]
	private bool EGHELBBFBGL(PMFFIMLMCEJ LHDCFFBCJLG, out NativeArray<Entity> MIHJGHDPEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x3C553B0", Offset = "0x3C541B0", VA = "0x183C553B0")]
	private NativeArray<Entity> EKDMDJJLMAF(PMFFIMLMCEJ LHDCFFBCJLG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0CFA0", Offset = "0x3E0BDA0", VA = "0x183E0CFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CF20", Offset = "0x3E0BD20", VA = "0x183E0CF20", Slot = "4")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CE30", Offset = "0x3E0BC30", VA = "0x183E0CE30")]
	public void LDENHAGOCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CB60", Offset = "0x3E0B960", VA = "0x183E0CB60")]
	public void IIAMNLKNDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2C6F0", Offset = "0x3F2B4F0", VA = "0x183F2C6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C900", Offset = "0x3F2B700", VA = "0x183F2C900")]
	public FHDMIGGLNFL(Type IGEIBCJNCHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C820", Offset = "0x3F2B620", VA = "0x183F2C820")]
	public static FHDMIGGLNFL LFOOIECCIPM(Type IGEIBCJNCHF)
	{
		return default(FHDMIGGLNFL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C7D0", Offset = "0x3F2B5D0", VA = "0x183F2C7D0")]
	public static Type LFOOIECCIPM(FHDMIGGLNFL DCLMHANFEGK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0xA252B0", Offset = "0xA240B0", VA = "0x180A252B0")]
	public static bool FHCNBCDBOFI(FHDMIGGLNFL NCNGLFNLPAG, FHDMIGGLNFL OPGAGDBKIDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0xA252B0", Offset = "0xA240B0", VA = "0x180A252B0")]
	public static bool LIEIJOJMABA(FHDMIGGLNFL NCNGLFNLPAG, FHDMIGGLNFL OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0xA24E70", Offset = "0xA23C70", VA = "0x180A24E70", Slot = "4")]
	public bool Equals(FHDMIGGLNFL KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C750", Offset = "0x3F2B550", VA = "0x183F2C750", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3F2C880", Offset = "0x3F2B680", VA = "0x183F2C880", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E0C6D0", Offset = "0x3E0B4D0", VA = "0x183E0C6D0")]
	static CILJPAMKPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x37A2A80", Offset = "0x37A1880", VA = "0x1837A2A80")]
	public static bool HMNAIPBHJIK<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C4A0", Offset = "0x3E0B2A0", VA = "0x183E0C4A0")]
	public static bool HMNAIPBHJIK(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C330", Offset = "0x3E0B130", VA = "0x183E0C330")]
	private static bool HMNAIPBHJIK(Type IGEIBCJNCHF, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x37A29F0", Offset = "0x37A17F0", VA = "0x1837A29F0")]
	public static int FEAMCPOBIKK<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C2C0", Offset = "0x3E0B0C0", VA = "0x183E0C2C0")]
	public static int FEAMCPOBIKK(Type IGEIBCJNCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x37A2B10", Offset = "0x37A1910", VA = "0x1837A2B10")]
	public static bool MDMOKHFDALA<T>(out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C510", Offset = "0x3E0B310", VA = "0x183E0C510")]
	public static bool MDMOKHFDALA(Type IGEIBCJNCHF, out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C220", Offset = "0x3E0B020", VA = "0x183E0C220")]
	public static Type CIGAFCHFFML(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C5B0", Offset = "0x3E0B3B0", VA = "0x183E0C5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x757A20", Offset = "0x756820", VA = "0x180757A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x366D270", Offset = "0x366C070", VA = "0x18366D270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> ENIJEODOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x4F40920", Offset = "0x4F3F720", VA = "0x184F40920")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x9BE060", Offset = "0x9BCE60", VA = "0x1809BE060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x4F40B30", Offset = "0x4F3F930", VA = "0x184F40B30")]
	public BCHFKABCHJB(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x4F40A80", Offset = "0x4F3F880", VA = "0x184F40A80")]
	public int FIGLOCELEJH(T DFEOJBAFBHE, int FHGIIAKFJFF, int MIOCJKOOLBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x4F409C0", Offset = "0x4F3F7C0", VA = "0x184F409C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x45F46F0", Offset = "0x45F34F0", VA = "0x1845F46F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x45F59E0", Offset = "0x45F47E0", VA = "0x1845F59E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x3BC71B0", Offset = "0x3BC5FB0", VA = "0x183BC71B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x45F5A30", Offset = "0x45F4830", VA = "0x1845F5A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x45F5AF0", Offset = "0x45F48F0", VA = "0x1845F5AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> ENIJEODOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x45F45A0", Offset = "0x45F33A0", VA = "0x1845F45A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x45F5C10", Offset = "0x45F4A10", VA = "0x1845F5C10")]
	public BEAOGGJJKMN(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x45F52D0", Offset = "0x45F40D0", VA = "0x1845F52D0")]
	public T HNNONCAKBHI(int NPDGHPHAKDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x45F5B30", Offset = "0x45F4930", VA = "0x1845F5B30")]
	public void PMMNFCJNHJH(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x45F5660", Offset = "0x45F4460", VA = "0x1845F5660")]
	public void JPFMAFBCANN(Span<T> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x45F51C0", Offset = "0x45F3FC0", VA = "0x1845F51C0")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x45F4D00", Offset = "0x45F3B00", VA = "0x1845F4D00")]
	private void GHGEHDFNFCM(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x45F4300", Offset = "0x45F3100", VA = "0x1845F4300")]
	public void BMDGMDNJPHD(Span<T> FKFMFNKJNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x45F42A0", Offset = "0x45F30A0", VA = "0x1845F42A0")]
	public void BKLAMEDJEPA(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x45F4F40", Offset = "0x45F3D40", VA = "0x1845F4F40")]
	public void HENDNLGJJNI(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x45F4540", Offset = "0x45F3340", VA = "0x1845F4540")]
	public void CCGFPBPKEDH(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x45F57D0", Offset = "0x45F45D0", VA = "0x1845F57D0")]
	public void KLGOEMEOLCH(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x45F4910", Offset = "0x45F3710", VA = "0x1845F4910")]
	public void FCEDBOOKGLB(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x45F4E80", Offset = "0x45F3C80", VA = "0x1845F4E80")]
	public void GLODPDIONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x45F49D0", Offset = "0x45F37D0", VA = "0x1845F49D0")]
	public int FIGLOCELEJH(T DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x45F5160", Offset = "0x45F3F60", VA = "0x1845F5160")]
	public bool HGEFFBLNLHD(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x45F48C0", Offset = "0x45F36C0", VA = "0x1845F48C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x45F5BA0", Offset = "0x45F49A0", VA = "0x1845F5BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x45F5A80", Offset = "0x45F4880", VA = "0x1845F5A80")]
	public static Span<T> LFOOIECCIPM(global::BEAOGGJJKMN<T> DEEJEKFIHBB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x45F4A60", Offset = "0x45F3860", VA = "0x1845F4A60")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FLAKGEDNEGO(int DFEOJBAFBHE, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GDOJDFFNHEH(int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x45F4BA0", Offset = "0x45F39A0", VA = "0x1845F4BA0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GDOJDFFNHEH(int MFAHIHFAKKH, int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x45F4780", Offset = "0x45F3580", VA = "0x1845F4780")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DMGKIPGOGOE(int DFEOJBAFBHE, int MFAHIHFAKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x45F5460", Offset = "0x45F4260", VA = "0x1845F5460")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JBKLPJCGCAC(int PHDGJLLBPDH, int APIEJLBIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x45F5320", Offset = "0x45F4120", VA = "0x1845F5320")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C56890", Offset = "0x3C55690", VA = "0x183C56890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> CMBIEGLMGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x77D6D0", Offset = "0x77C4D0", VA = "0x18077D6D0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray BDFIMOGPJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x3C56A40", Offset = "0x3C55840", VA = "0x183C56A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x3C56B00", Offset = "0x3C55900", VA = "0x183C56B00")]
	public OCGEMJOOKNP(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x3C56920", Offset = "0x3C55720", VA = "0x183C56920")]
	public Entity FKEODMAICIA(int NPDGHPHAKDK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x3C56AB0", Offset = "0x3C558B0", VA = "0x183C56AB0")]
	public Transform NHDJANMKOLL(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x3C56A60", Offset = "0x3C55860", VA = "0x183C56A60")]
	public void MPKFKNPIPHJ(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x3C56970", Offset = "0x3C55770", VA = "0x183C56970")]
	public int HMNAIPBHJIK(Transform FLCFNMLPAML, Entity IEFFOCOBJJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x3C56810", Offset = "0x3C55610", VA = "0x183C56810")]
	public int BKLAMEDJEPA(int NPDGHPHAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x3C568A0", Offset = "0x3C556A0", VA = "0x183C568A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x3C56AC0", Offset = "0x3C558C0", VA = "0x183C56AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F39720", Offset = "0x3F38520", VA = "0x183F39720")]
	public IANBFBPDFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x3F39270", Offset = "0x3F38070", VA = "0x183F39270")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F392D0", Offset = "0x3F380D0", VA = "0x183F392D0")]
	public void FAFPJPFNCCD(Type IGEIBCJNCHF, PEKIEJLMCEO DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3F38E30", Offset = "0x3F37C30", VA = "0x183F38E30")]
	public PEKIEJLMCEO CIGAFCHFFML(Type IGEIBCJNCHF)
	{
		return default(PEKIEJLMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3F39680", Offset = "0x3F38480", VA = "0x183F39680")]
	private NativeArray<byte> KPJAFBEEOCO(int2 BOLOJDIFGHI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3F391D0", Offset = "0x3F37FD0", VA = "0x183F391D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3F39560", Offset = "0x3F38360", VA = "0x183F39560", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C645B0", Offset = "0x3C633B0", VA = "0x183C645B0")]
	internal static void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void FAFPJPFNCCD<T>(T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x3C64620", Offset = "0x3C63420", VA = "0x183C64620")]
	public static void FAFPJPFNCCD(Type IGEIBCJNCHF, PEKIEJLMCEO DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T CIGAFCHFFML<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x3C64510", Offset = "0x3C63310", VA = "0x183C64510")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F3F7E0", Offset = "0x3F3E5E0", VA = "0x183F3F7E0", Slot = "4")]
	public bool Equals(LinkedEntityGroup JMDPDGBMGAA, LinkedEntityGroup GKDCJKNJEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F800", Offset = "0x3F3E600", VA = "0x183F3F800", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup GKCPJCKCENH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KCLEABANIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class IDNOIKOIDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void HFJDJHLNAJI(in Vector3 IJBELJOFGFA, in Quaternion EIGPDNIOAKK, in Vector3 LAKBNONGKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void APGHJIMINCH(in Vector3 MJLFONEIMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void GHNOMDJEOGM(in Quaternion EIGPDNIOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void HJJCOOIHHED(in Vector3 BCDKADPIFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void JFMPIHILMMC(in Vector3 BCDKADPIFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void CDDGCDOFCAB(in float BGPEGNJCNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3F398C0", Offset = "0x3F386C0", VA = "0x183F398C0")]
	[Conditional("DEBUG_BUILD")]
	public static void NAAFGEEEJEH(in float3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in float DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x3F397C0", Offset = "0x3F385C0", VA = "0x183F397C0")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in Vector3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3F39810", Offset = "0x3F38610", VA = "0x183F39810")]
	[Conditional("DEBUG_BUILD")]
	public static void DNKFANGBODK(in Quaternion DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x3F398B0", Offset = "0x3F386B0", VA = "0x183F398B0")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in float DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3F39870", Offset = "0x3F38670", VA = "0x183F39870")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in Vector3 DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3F39840", Offset = "0x3F38640", VA = "0x183F39840")]
	[Conditional("DEBUG_BUILD")]
	public static void LFBBLLFIAMP(in Quaternion DFEOJBAFBHE, string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C53F10", Offset = "0x3C52D10", VA = "0x183C53F10")]
	public MLDEGJAOMMP(Entity IEFFOCOBJJI, Entity KFGEJHIJBGK, Entity LCCGHHJFGDE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x3C53ED0", Offset = "0x3C52CD0", VA = "0x183C53ED0")]
	public static MLDEGJAOMMP LFOOIECCIPM((Entity entity, Entity oldParent, Entity newParent) FHJGCPGBEAL)
	{
		return default(MLDEGJAOMMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x3C53EB0", Offset = "0x3C52CB0", VA = "0x183C53EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0xDBE590", Offset = "0xDBD390", VA = "0x180DBE590")]
	public GGMEAKIAMAM(Entity IEFFOCOBJJI, Entity ICMEPOIJCJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x3F30330", Offset = "0x3F2F130", VA = "0x183F30330")]
	public static GGMEAKIAMAM LFOOIECCIPM((Entity entity, Entity parent) FHJGCPGBEAL)
	{
		return default(GGMEAKIAMAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x3F30320", Offset = "0x3F2F120", VA = "0x183F30320")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F40620", Offset = "0x3F3F420", VA = "0x183F40620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x508FD00", Offset = "0x508EB00", VA = "0x18508FD00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x508FDA0", Offset = "0x508EBA0", VA = "0x18508FDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x508FE60", Offset = "0x508EC60", VA = "0x18508FE60")]
	public HOBLNHDMNAF(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x508FCD0", Offset = "0x508EAD0", VA = "0x18508FCD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x1808E87E0")]
	public MJPMCDBPLIH(PPEAHEMHINL IOFJIFKFLFF, int NIKABAFFCDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x1F74F50", Offset = "0x1F73D50", VA = "0x181F74F50")]
	public static MJPMCDBPLIH LFOOIECCIPM((PPEAHEMHINL eventType, int eventIndex) JMDPDGBMGAA)
	{
		return default(MJPMCDBPLIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x3C53EA0", Offset = "0x3C52CA0", VA = "0x183C53EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F30400", Offset = "0x3F2F200", VA = "0x183F30400", Slot = "5")]
	public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x3F30360", Offset = "0x3F2F160", VA = "0x183F30360")]
	public bool HFCCBFOEMBC(in float3 ELILOAMNFDJ, in float3 FKPLFKHGEBI, float JFMOIJLKEGH, Allocator AEPJLHDIHPH, out NativeArray<Entity> BNEBECKGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GHDMMKNFMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x3F30360", Offset = "0x3F2F160", VA = "0x183F30360", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F30590", Offset = "0x3F2F390", VA = "0x183F30590", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public GIAKCLIIKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C56BA0", Offset = "0x3C559A0", VA = "0x183C56BA0", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public OLFICMLNACI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F30F70", Offset = "0x3F2FD70", VA = "0x183F30F70", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public GJJLMCGHAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class JAPNGKLKPHC : PAOJLIIMPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public JAPNGKLKPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E18250", Offset = "0x3E17050", VA = "0x183E18250", Slot = "16")]
	protected override ComponentSystemBase OENKBFADAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x3C54F00", Offset = "0x3C53D00", VA = "0x183C54F00")]
	public DAFEDNGOABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[CNPLGNFBEPP(typeof(AuthoredLocalPoseData))]
public sealed class BOEMCKNOBHK : AIMIAFCPLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x3E09C80", Offset = "0x3E08A80", VA = "0x183E09C80", Slot = "8")]
	protected override bool GLCFABJPCDC(ReadOnlySpan<AuthoredLocalPoseData> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3E09BC0", Offset = "0x3E089C0", VA = "0x183E09BC0", Slot = "9")]
	protected override bool EHOJBANGFCF(int IIJDDKBOPLN, Span<AuthoredLocalPoseData> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x3E09D00", Offset = "0x3E08B00", VA = "0x183E09D00")]
	public BOEMCKNOBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[CNPLGNFBEPP(typeof(LocalPoseData))]
public sealed class KHEEHOJHBOD : ACJMFJHFCHL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x3F41030", Offset = "0x3F3FE30", VA = "0x183F41030", Slot = "8")]
	protected override bool GLCFABJPCDC(ReadOnlySpan<LocalPoseData> FKFMFNKJNOH, LDGDBBFAFNK NEHLAILGLJO, out ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x3F40F70", Offset = "0x3F3FD70", VA = "0x183F40F70", Slot = "9")]
	protected override bool EHOJBANGFCF(int IIJDDKBOPLN, Span<LocalPoseData> FKFMFNKJNOH, in ReadOnlySpan<byte> GEGIPEOHNBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3F410B0", Offset = "0x3F3FEB0", VA = "0x183F410B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x3E971A0", Offset = "0x3E95FA0", VA = "0x183E971A0", Slot = "6")]
		public sealed override void EFMBJNCKONM(GEJJOANAKLE KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x3E98140", Offset = "0x3E96F40", VA = "0x183E98140", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x3F41410", Offset = "0x3F40210", VA = "0x183F41410")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3F410C0", Offset = "0x3F3FEC0", VA = "0x183F410C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
