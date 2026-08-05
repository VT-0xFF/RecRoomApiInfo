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
public sealed class CNEAPCJPFBO<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class MHJCEKGHLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::CNEAPCJPFBO<T> POECPKFJOCC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] HNMMPCDPKOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public MHJCEKGHLFA(global::CNEAPCJPFBO<T> POECPKFJOCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class DEJNNBJPBEG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::CNEAPCJPFBO<T> <>4__this;

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
		public DEJNNBJPBEG(int <>1__state)
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
	private const int MNCEMKNAEDK = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> IDINEEGFGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int MLOBOPGDLDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T EAAIOELEIIM
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
	private bool PNDBPNEHPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EMPCBHLDLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool OBFDPCFOKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KMFAFOCNGGD
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
	public int ICNBMEOIEJL
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
	public CNEAPCJPFBO(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public CNEAPCJPFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void CAMAAPDKPFE(int EBBLFLFCHFB, T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void APBNDDFINKH(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] EGJGLNFOKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void IIMEGGCEOOP(NativeArray<T> HEONDDEAIBL, int EBNCDCCMBJP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::CNEAPCJPFBO<>.DEJNNBJPBEG))]
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
	public int NCLIALNFMIA(T GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool EMIFMEAGDDE(T GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void ODFMOICKFGC(int GPAIMOBEGDJ, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void GCHNGAGMCJN(int GPAIMOBEGDJ, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void MELHDJJEABA(int GPAIMOBEGDJ, int ADDILPEFEHP, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int JJBBDKKAIOK(int EBBLFLFCHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T NPODNCNMMAH(int EBBLFLFCHFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void FCNLNPLONJH(int EBBLFLFCHFB, T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void FKBHEBHPJEH(int EBBLFLFCHFB, T GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void OFFFDAFPFCB(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int EAKOKOMGGEH(int MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int MOMOJGPJPOD(int MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void JMIDHCFNOCE(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void MKOINNJEEHH(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T GALNPPHDCGP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T KDIPBOKCBHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void KCNOENNLCDP(int EBBLFLFCHFB, IReadOnlyCollection<T> JAMIHJHDKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void JALAGPLLNID(int EBBLFLFCHFB, int HIFGLNNCMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void IOKOONCICGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void GMPDNAKPNKN(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void GPAGEHFBNDN(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void BCKCFIAIJFC(int ADDILPEFEHP, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T LEFFMAKIJHP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T LPOBKMOKLBH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CPNFHFBMMGK]
public static class DDGNBBCBMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3904F00", Offset = "0x3903500", VA = "0x183904F00")]
	static DDGNBBCBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A3A2C0", Offset = "0x2A388C0", VA = "0x182A3A2C0")]
	public static void PLMJBMGGDBE<T>(T EIAMEKHGGAJ, ref T DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3904ED0", Offset = "0x39034D0", VA = "0x183904ED0")]
	public static void PLMJBMGGDBE(FixedString32 EIAMEKHGGAJ, ref string DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3904DD0", Offset = "0x39033D0", VA = "0x183904DD0")]
	public static void PLMJBMGGDBE(string EIAMEKHGGAJ, ref FixedString32 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3904E10", Offset = "0x3903410", VA = "0x183904E10")]
	public static void PLMJBMGGDBE(FixedString64 EIAMEKHGGAJ, ref string DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3904E40", Offset = "0x3903440", VA = "0x183904E40")]
	public static void PLMJBMGGDBE(string EIAMEKHGGAJ, ref FixedString64 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3904C50", Offset = "0x3903250", VA = "0x183904C50")]
	public static void PLMJBMGGDBE(HBIIBBBKJAB EIAMEKHGGAJ, ref Vector3 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3904D70", Offset = "0x3903370", VA = "0x183904D70")]
	public static void PLMJBMGGDBE(Vector3 EIAMEKHGGAJ, ref HBIIBBBKJAB DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3904C20", Offset = "0x3903220", VA = "0x183904C20")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref Vector4 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3904BB0", Offset = "0x39031B0", VA = "0x183904BB0")]
	public static void PLMJBMGGDBE(Vector4 EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3904C20", Offset = "0x3903220", VA = "0x183904C20")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref Quaternion DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3904BB0", Offset = "0x39031B0", VA = "0x183904BB0")]
	public static void PLMJBMGGDBE(Quaternion EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3904EA0", Offset = "0x39034A0", VA = "0x183904EA0")]
	public static void PLMJBMGGDBE(HBIIBBBKJAB EIAMEKHGGAJ, ref float3 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3904D70", Offset = "0x3903370", VA = "0x183904D70")]
	public static void PLMJBMGGDBE(float3 EIAMEKHGGAJ, ref HBIIBBBKJAB DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3904C80", Offset = "0x3903280", VA = "0x183904C80")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref float4 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3904BB0", Offset = "0x39031B0", VA = "0x183904BB0")]
	public static void PLMJBMGGDBE(float4 EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3904C80", Offset = "0x3903280", VA = "0x183904C80")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref quaternion DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3904D00", Offset = "0x3903300", VA = "0x183904D00")]
	public static void PLMJBMGGDBE(quaternion EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3904CC0", Offset = "0x39032C0", VA = "0x183904CC0")]
	public static void PLMJBMGGDBE(Entity EIAMEKHGGAJ, ref IIMOFJIHOKP DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3904B90", Offset = "0x3903190", VA = "0x183904B90")]
	public static void PLMJBMGGDBE(IIMOFJIHOKP EIAMEKHGGAJ, ref Entity DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BCMMDDALFAJ]
public class GMAKHEOHPBO : ComponentSystem, GOJCOOFCPOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PFKGIHKPIGG AEDPBOIFJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OBPBNOCJFPI ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0700", Offset = "0x3BBED00", VA = "0x183BC0700", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public GMAKHEOHPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(HDLEHDDPGDO))]
internal class ICKPFPJHBOM : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3BC43F0", Offset = "0x3BC29F0", VA = "0x183BC43F0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4630", Offset = "0x3BC2C30", VA = "0x183BC4630")]
	[Preserve]
	private void GKAPBBHHFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public ICKPFPJHBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(HDLEHDDPGDO))]
internal class IEDCGGIGAOF : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4F30", Offset = "0x3BC3530", VA = "0x183BC4F30", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public IEDCGGIGAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x388A5B0", Offset = "0x3888BB0", VA = "0x18388A5B0")]
		public static ObjectModelConfigAsset PHFCPGGCCJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7FADF0", Offset = "0x7F93F0", VA = "0x1807FADF0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DAINLFLPADL(OHEDAGNNHJA.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int HDJNGGOKGFI = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FGGEJMNNOEE LAEOPKAJMLP;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xDFD2B0", Offset = "0xDFB8B0", VA = "0x180DFD2B0")]
			public static COEEIJJLOPG PFLBDODGAII(int JCBOPFBACOG)
			{
				return default(COEEIJJLOPG);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xDFD6A0", Offset = "0xDFBCA0", VA = "0x180DFD6A0")]
			private static void PPLAKIJEIKD(NIALADIPDNC BBCLPDIBELE, NIALADIPDNC PHBCAHMJAJH, COEEIJJLOPG FBIBIHJENAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xDFD060", Offset = "0xDFB660", VA = "0x180DFD060")]
			public static int MAHLJKMJLDD(GameObject EHEABJNEALG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xDFD230", Offset = "0xDFB830", VA = "0x180DFD230")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void OJMFLMHLGMF(NIALADIPDNC KLCGNDEDAPD, int JCBOPFBACOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static PEGEFOEHCCC IGFHDABHNLN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static EOPMPEPMNDF IJJOMIGFFLF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static PEGEFOEHCCC CEAHPPGBFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x388ACD0", Offset = "0x38892D0", VA = "0x18388ACD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x388A8A0", Offset = "0x3888EA0", VA = "0x18388A8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static EOPMPEPMNDF DJPIGNBFNDD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x388AE10", Offset = "0x3889410", VA = "0x18388AE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x388B550", Offset = "0x3889B50", VA = "0x18388B550")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool BMDLOJGHPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x388BB10", Offset = "0x388A110", VA = "0x18388BB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static PFKGIHKPIGG AEDPBOIFJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x388BF70", Offset = "0x388A570", VA = "0x18388BF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OBPBNOCJFPI ABBJLIEIKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x388BA90", Offset = "0x388A090", VA = "0x18388BA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static MJFDNFOLGPA GLKPOKJAFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x388A6B0", Offset = "0x3888CB0", VA = "0x18388A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LAMNHLNDGKO BPLOKGOONKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x388BDD0", Offset = "0x388A3D0", VA = "0x18388BDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static CLJEHOFLHAA FPLKCFFBBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x388C010", Offset = "0x388A610", VA = "0x18388C010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static OPAKLFEDMAA MLMCGKJNBJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x388A730", Offset = "0x3888D30", VA = "0x18388A730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool LBFCHMNDIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x388B7D0", Offset = "0x3889DD0", VA = "0x18388B7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool IPLJLPELEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x388B100", Offset = "0x3889700", VA = "0x18388B100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool OKIPCPMGFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x388C0F0", Offset = "0x388A6F0", VA = "0x18388C0F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x388BA30", Offset = "0x388A030", VA = "0x18388BA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool OEKBGEEADPL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x388C090", Offset = "0x388A690", VA = "0x18388C090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x388A650", Offset = "0x3888C50", VA = "0x18388A650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action EOJIPPCPFCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x388A980", Offset = "0x3888F80", VA = "0x18388A980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x388BC70", Offset = "0x388A270", VA = "0x18388BC70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x388A7B0", Offset = "0x3888DB0", VA = "0x18388A7B0")]
		public static NIALADIPDNC BIKIJJFPJAP(GameObject EHEABJNEALG)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x388BD70", Offset = "0x388A370", VA = "0x18388BD70")]
		public static bool LGJCPCMMJDL(ByteString FJHIHOOEHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x388BE50", Offset = "0x388A450", VA = "0x18388BE50")]
		public static INPNGJHLELG MDMFFOHHDFN(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x388B420", Offset = "0x3889A20", VA = "0x18388B420")]
		public static (ByteString, IDisposable) HGEKGOKJCDE()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x388B2F0", Offset = "0x38898F0", VA = "0x18388B2F0")]
		public static (ByteString, IDisposable) HFGBNDBMBOK(IEnumerable<NIALADIPDNC> FEELJHFMNCJ)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x388ABA0", Offset = "0x38891A0", VA = "0x18388ABA0")]
		public static bool FLICJPOGKON(GameObject EHEABJNEALG, out COEEIJJLOPG FBIBIHJENAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x388B010", Offset = "0x3889610", VA = "0x18388B010")]
		public static bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x388AD30", Offset = "0x3889330", VA = "0x18388AD30")]
		public static void GDKKLJBLGGP(bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x388B8B0", Offset = "0x3889EB0", VA = "0x18388B8B0")]
		public static Task IKIINMJCMNM(bool CFGMGGHPOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x388AF30", Offset = "0x3889530", VA = "0x18388AF30")]
		private static EOPMPEPMNDF GOCEMGIKHLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x388AA80", Offset = "0x3889080", VA = "0x18388AA80")]
		private static bool EPMEJGJBAHN()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DAINLFLPADL(OHEDAGNNHJA.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3890760", Offset = "0x388ED60", VA = "0x183890760")]
		public static bool DCKHIGDAIJO(GLICHKLIKDB NLCKOEKLBBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3890900", Offset = "0x388EF00", VA = "0x183890900")]
		public static GLICHKLIKDB KOEBKPOFGOP(GameObject EHEABJNEALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3890B30", Offset = "0x388F130", VA = "0x183890B30")]
		public static GLICHKLIKDB KOEBKPOFGOP(GameObject EHEABJNEALG, COEEIJJLOPG FBIBIHJENAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3890660", Offset = "0x388EC60", VA = "0x183890660")]
		public static bool AOOMLGLMAAE(GameObject POFNLMLLLOA, string IMOKOPFFOAJ, bool NAHCNBIBMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3890D30", Offset = "0x388F330", VA = "0x183890D30")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void NDFLGOAKPBI(GameObject POFNLMLLLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3890810", Offset = "0x388EE10", VA = "0x183890810")]
		[CompilerGenerated]
		internal static string HIHBGIOHHIH((GameObject go, string prefabName) HNGHLHHNPMK)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, LBGAOCOLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NIALADIPDNC CDCHGJINIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NIALADIPDNC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B65C0", Offset = "0x8B4BC0", VA = "0x1808B65C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[DAINLFLPADL(OHEDAGNNHJA.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GLICHKLIKDB, LBGAOCOLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string LCFLIAAEPJE = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EBAPHHOIILB BLJBLMCPLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NIALADIPDNC EHLCJHMJBBP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NIALADIPDNC CDCHGJINIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3BB30F0", Offset = "0x3BB16F0", VA = "0x183BB30F0", Slot = "15")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public INPNGJHLELG BDILHMAFPHD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3BB31A0", Offset = "0x3BB17A0", VA = "0x183BB31A0", Slot = "6")]
			get
			{
				return default(INPNGJHLELG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3BB30E0", Offset = "0x3BB16E0", VA = "0x183BB30E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EBAPHHOIILB CJEEMAGCIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7E1F20", Offset = "0x7E0520", VA = "0x1807E1F20", Slot = "7")]
			get
			{
				return default(EBAPHHOIILB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OBPBNOCJFPI ABBJLIEIKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3BB2970", Offset = "0x3BB0F70", VA = "0x183BB2970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BBGDLMHBFGH NBLANOGNFOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3BB2630", Offset = "0x3BB0C30", VA = "0x183BB2630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NMAPLFKNFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> HHNGKOLCNIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3BB2FA0", Offset = "0x3BB15A0", VA = "0x183BB2FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3BB31D0", Offset = "0x3BB17D0", VA = "0x183BB31D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GLICHKLIKDB> EFKPICKIDKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3BB3040", Offset = "0x3BB1640", VA = "0x183BB3040", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3BB3270", Offset = "0x3BB1870", VA = "0x183BB3270", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2420", Offset = "0x3BB0A20", VA = "0x183BB2420")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2E00", Offset = "0x3BB1400", VA = "0x183BB2E00", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2AB0", Offset = "0x3BB10B0", VA = "0x183BB2AB0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2D70", Offset = "0x3BB1370", VA = "0x183BB2D70", Slot = "10")]
		public void OnEmbody(LEDNJPMFMJI KHDPJJEDHOA, NIALADIPDNC EHLCJHMJBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2DF0", Offset = "0x3BB13F0", VA = "0x183BB2DF0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2B60", Offset = "0x3BB1160", VA = "0x183BB2B60", Slot = "12")]
		public void OnDisembody(bool EHDHBHIGMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2690", Offset = "0x3BB0C90", VA = "0x183BB2690")]
		private void JBKMHMCHKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB25A0", Offset = "0x3BB0BA0", VA = "0x183BB25A0")]
		private void ECHHBHCOJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2790", Offset = "0x3BB0D90", VA = "0x183BB2790")]
		private void JBLOBEABNOF(bool IKFCIOJBEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2A50", Offset = "0x3BB1050", VA = "0x183BB2A50", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x154C450", Offset = "0x154AA50", VA = "0x18154C450", Slot = "9")]
		private GameObject KPBAMFPDJFH()
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
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[DAINLFLPADL(OHEDAGNNHJA.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override HLEPLICHNKK POFLLKKFNID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x389DB00", Offset = "0x389C100", VA = "0x18389DB00", Slot = "6")]
			get
			{
				return default(HLEPLICHNKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x389DAA0", Offset = "0x389C0A0", VA = "0x18389DAA0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[DAINLFLPADL(OHEDAGNNHJA.Registration)]
	public class TransformEntity : MonoBehaviour, LBGAOCOLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private HLEPLICHNKK prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NIALADIPDNC KLCGNDEDAPD;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual HLEPLICHNKK POFLLKKFNID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "6")]
			get
			{
				return default(HLEPLICHNKK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6BA610", Offset = "0x6B8C10", VA = "0x1806BA610", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NIALADIPDNC CDCHGJINIFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x783BB0", Offset = "0x7821B0", VA = "0x180783BB0", Slot = "5")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x718170", Offset = "0x716770", VA = "0x180718170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity LHEGNCBACAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal CLJEHOFLHAA FPLKCFFBBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal BBGDLMHBFGH MHIMBKNCMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x783740", Offset = "0x781D40", VA = "0x180783740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x783570", Offset = "0x781B70", VA = "0x180783570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7837B0", Offset = "0x781DB0", VA = "0x1807837B0")]
		internal void OIEJOMHJJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7835B0", Offset = "0x781BB0", VA = "0x1807835B0")]
		private bool EDDODBNBMEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x783580", Offset = "0x781B80", VA = "0x180783580")]
		private void CBGOAIBBOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650")]
		internal void ENCBMHFAOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x783BA0", Offset = "0x7821A0", VA = "0x180783BA0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CMEMHKMDBHK(typeof(PCJLBILJHMN))]
[DHKIICMHACJ(typeof(EOPMPEPMNDF), new string[] { })]
public class BJDHOGDNAJH : FCCIGPAELIJ, EBAEFANKIMF, EOPMPEPMNDF, IHDPMKBFJKB, PCJLBILJHMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EGGANIJGBAJ GOCENLCAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OBPBNOCJFPI FLDPOGAHGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ACADFKAKLNJ HEJDNNNGOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EHJNMOMNBNJ MMABDIGILBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x91B510", Offset = "0x919B10", VA = "0x18091B510", Slot = "19")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EGGANIJGBAJ AEDPBOIFJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KMGAJCBNKGB KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OBPBNOCJFPI ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38F45A0", Offset = "0x38F2BA0", VA = "0x1838F45A0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x38F3D00", Offset = "0x38F2300", VA = "0x1838F3D00", Slot = "20")]
	public void AMMIBONBLOJ(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xDAED30", Offset = "0xDAD330", VA = "0x180DAED30")]
	private void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x38F44F0", Offset = "0x38F2AF0", VA = "0x1838F44F0")]
	private void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x38F3F00", Offset = "0x38F2500", VA = "0x1838F3F00", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x38F4360", Offset = "0x38F2960", VA = "0x1838F4360", Slot = "10")]
	public void HIMHLDJIPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void MBKGOAOOIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x38F4410", Offset = "0x38F2A10", VA = "0x1838F4410", Slot = "5")]
	public void KIMLPLPJNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x38F4180", Offset = "0x38F2780", VA = "0x1838F4180", Slot = "6")]
	public void GIIKIGODMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x38F43A0", Offset = "0x38F29A0", VA = "0x1838F43A0", Slot = "7")]
	public void IKNKCCOLBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x38F41D0", Offset = "0x38F27D0", VA = "0x1838F41D0", Slot = "8")]
	public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x38F4480", Offset = "0x38F2A80", VA = "0x1838F4480", Slot = "9")]
	public void KPNGBGLCOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x38F3F60", Offset = "0x38F2560", VA = "0x1838F3F60", Slot = "11")]
	public void EOIOFEACJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x38F4100", Offset = "0x38F2700", VA = "0x1838F4100", Slot = "12")]
	public void FHJCBOAFEOJ(bool BHFCIBGKHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x38F4250", Offset = "0x38F2850", VA = "0x1838F4250")]
	private void HEAMKLLBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x38F4280", Offset = "0x38F2880", VA = "0x1838F4280", Slot = "13")]
	public ByteString HGEKGOKJCDE(out IDisposable FEOPLMNGHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x38F3FD0", Offset = "0x38F25D0", VA = "0x1838F3FD0", Slot = "14")]
	public void FFFJLEEKFAK(ByteString JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x38F3E10", Offset = "0x38F2410", VA = "0x1838F3E10")]
	public static BJDHOGDNAJH CBFHJGEFJHE(EGGANIJGBAJ GOCENLCAMDB, BDNNNEAGBLH NBBMMINMBNH = BDNNNEAGBLH.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void OFMBGANDJKL(EGGANIJGBAJ GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void KAHDAIAHBIF(EGGANIJGBAJ GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BJDHOGDNAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KPPFOBIONEG
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAA30", Offset = "0x3BC9030", VA = "0x183BCAA30")]
	public static INPNGJHLELG INDFCIHCJOC(this EOPMPEPMNDF IJJOMIGFFLF, COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
	{
		return default(INPNGJHLELG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA910", Offset = "0x3BC8F10", VA = "0x183BCA910")]
	public static ADPNEJLEBMK CKCDOPLEPGG(this EOPMPEPMNDF IJJOMIGFFLF)
	{
		return default(ADPNEJLEBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA860", Offset = "0x3BC8E60", VA = "0x183BCA860")]
	public static NIALADIPDNC BIKIJJFPJAP(this EOPMPEPMNDF IJJOMIGFFLF, Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA730", Offset = "0x3BC8D30", VA = "0x183BCA730")]
	public static NIALADIPDNC BIKIJJFPJAP(this EOPMPEPMNDF IJJOMIGFFLF, COEEIJJLOPG FBIBIHJENAB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAB70", Offset = "0x3BC9170", VA = "0x183BCAB70")]
	public static COEEIJJLOPG KHNEHGBKPKD(this EOPMPEPMNDF IJJOMIGFFLF, NIALADIPDNC KLCGNDEDAPD)
	{
		return default(COEEIJJLOPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum BDNNNEAGBLH
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
public class BOKDKPCCEKG<T> : global::AAFIPGGELPP<T>, global::IMEOCHFBNFN<COEEIJJLOPG, T>, global::NHFPPBDNHIF<COEEIJJLOPG>, EOKJCPFONJL, IDisposable, CKNEHODEDLN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::NHFPPBDNHIF<Entity> LNOIPGJELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate IJFLPHFOEAJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4F47B60", Offset = "0x4F46160", VA = "0x184F47B60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F47170", Offset = "0x4F45770", VA = "0x184F47170", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BCFEIPPIFOG AAEEOADJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F48C70", Offset = "0x4F47270", VA = "0x184F48C70", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BHEGLCENDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F47430", Offset = "0x4F45A30", VA = "0x184F47430", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GIKJNBNLBJJ FJAIGBGOONO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F30170", Offset = "0x4F2E770", VA = "0x184F30170", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2346A50", Offset = "0x2345050", VA = "0x182346A50", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4842FB0", Offset = "0x48415B0", VA = "0x184842FB0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::ALOKFBCAIMB<COEEIJJLOPG> EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F740", Offset = "0x4F2DD40", VA = "0x184F2F740", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F426F0", Offset = "0x4F40CF0", VA = "0x184F426F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1770", Offset = "0x3DBFD70", VA = "0x183DC1770")]
	public BOKDKPCCEKG(global::NHFPPBDNHIF<Entity> LNOIPGJELOP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F486B0", Offset = "0x4F46CB0", VA = "0x184F486B0")]
	private Entity OOFEPMABPOC(COEEIJJLOPG FBIBIHJENAB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x484E0F0", Offset = "0x484C6F0", VA = "0x18484E0F0")]
	private COEEIJJLOPG OOFEPMABPOC(Entity FLADPKIONGF)
	{
		return default(COEEIJJLOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F34C60", Offset = "0x4F33260", VA = "0x184F34C60", Slot = "4")]
	public T DNJGGIFCOKL(COEEIJJLOPG FBIBIHJENAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F448B0", Offset = "0x4F42EB0", VA = "0x184F448B0")]
	public bool KMNEKDAGPNL(COEEIJJLOPG FBIBIHJENAB, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F2DF80", Offset = "0x4F2C580", VA = "0x184F2DF80")]
	public bool ADOANPCNBFI(COEEIJJLOPG FBIBIHJENAB, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F35E20", Offset = "0x4F34420", VA = "0x184F35E20", Slot = "9")]
	public bool DPFPNIAFGMD(COEEIJJLOPG FBIBIHJENAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x48438F0", Offset = "0x4841EF0", VA = "0x1848438F0", Slot = "26")]
	public object GOFJHIIODPI(COEEIJJLOPG FBIBIHJENAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F41AC0", Offset = "0x4F400C0", VA = "0x184F41AC0")]
	public bool IKGICBKDCJJ(COEEIJJLOPG FBIBIHJENAB, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F34350", Offset = "0x4F32950", VA = "0x184F34350")]
	public void DNJGGIFCOKL(COEEIJJLOPG FBIBIHJENAB, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4848F70", Offset = "0x4847570", VA = "0x184848F70")]
	public bool KMNEKDAGPNL(COEEIJJLOPG FBIBIHJENAB, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4833270", Offset = "0x4831870", VA = "0x184833270")]
	public bool ADOANPCNBFI(COEEIJJLOPG FBIBIHJENAB, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF330", Offset = "0x3DBD930", VA = "0x183DBF330", Slot = "22")]
	public void HEIGEPEFDPE(IDBCBPLBJEI GIBODALIGFC, [Optional] object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E7F0", Offset = "0x4F3CDF0", VA = "0x184F3E7F0", Slot = "15")]
	public void HEIGEPEFDPE(COEEIJJLOPG AIGAKEKDKHM, KMICCHHKOED GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4843580", Offset = "0x4841B80", VA = "0x184843580", Slot = "14")]
	public bool GFHPIODIGEI(COEEIJJLOPG DGEBCAGKNCO, COEEIJJLOPG EIAMEKHGGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x32805A0", Offset = "0x327EBA0", VA = "0x1832805A0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F490D0", Offset = "0x4F476D0", VA = "0x184F490D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0360", Offset = "0x3DBE960", VA = "0x183DC0360")]
	public string KABCHDDLAJE(in COGGJKLIPPL DFGEBCFIFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F30990", Offset = "0x4F2EF90", VA = "0x184F30990")]
	private void DLADBALAOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F46250", Offset = "0x4F44850", VA = "0x184F46250")]
	private void LFJNEAEHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F39CA0", Offset = "0x4F382A0", VA = "0x184F39CA0")]
	private void EFHLPLLMDMO(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FC30", Offset = "0x4F3E230", VA = "0x184F3FC30")]
	private void HIDHBMKDCIC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F3CE40", Offset = "0x4F3B440", VA = "0x184F3CE40")]
	[Conditional("DEBUG_BUILD")]
	private static void EIJLDOEFLNK(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB, string MABBPMMEACO, string BBGPEEJJFHP, [CallerMemberName] string CHAHHBDIPFA = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x334FFD0", Offset = "0x334E5D0", VA = "0x18334FFD0", Slot = "5")]
	private bool ELJGHPBKMGI(COEEIJJLOPG AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3E36130", Offset = "0x3E34730", VA = "0x183E36130", Slot = "6")]
	private bool ABNHFMFHCLL(COEEIJJLOPG AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3940820", Offset = "0x393EE20", VA = "0x183940820", Slot = "10")]
	private bool MMMALAHKIGM(COEEIJJLOPG AIGAKEKDKHM, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x484D6C0", Offset = "0x484BCC0", VA = "0x18484D6C0", Slot = "11")]
	private void LMPOJBADNKJ(COEEIJJLOPG AIGAKEKDKHM, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4848EB0", Offset = "0x48474B0", VA = "0x184848EB0", Slot = "12")]
	private bool KBEMELNIDKC(COEEIJJLOPG AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4847C40", Offset = "0x4846240", VA = "0x184847C40", Slot = "13")]
	private bool JEANFCEODEH(COEEIJJLOPG AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3DBED90", Offset = "0x3DBD390", VA = "0x183DBED90", Slot = "16")]
	private string NCCHAOKKAAN(in COGGJKLIPPL MAKFNMHIJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class JGPMEKBNBND<T> : global::DHFNFLDBPNF<T>, global::IMEOCHFBNFN<NIALADIPDNC, T>, global::NHFPPBDNHIF<NIALADIPDNC>, EOKJCPFONJL, IDisposable, MIKODHFFJMF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::NHFPPBDNHIF<Entity> LNOIPGJELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate IJFLPHFOEAJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1420", Offset = "0x3DBFA20", VA = "0x183DC1420", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1230", Offset = "0x3DBF830", VA = "0x183DC1230", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BCFEIPPIFOG AAEEOADJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3DC14A0", Offset = "0x3DBFAA0", VA = "0x183DC14A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BHEGLCENDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3DC12E0", Offset = "0x3DBF8E0", VA = "0x183DC12E0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GIKJNBNLBJJ FJAIGBGOONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCBF0", Offset = "0x3DBB1F0", VA = "0x183DBCBF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF180", Offset = "0x3DBD780", VA = "0x183DBF180", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3DBED50", Offset = "0x3DBD350", VA = "0x183DBED50", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::ALOKFBCAIMB<NIALADIPDNC> EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCA40", Offset = "0x3DBB040", VA = "0x183DBCA40", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC01A0", Offset = "0x3DBE7A0", VA = "0x183DC01A0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1770", Offset = "0x3DBFD70", VA = "0x183DC1770")]
	public JGPMEKBNBND(global::NHFPPBDNHIF<Entity> LNOIPGJELOP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2145CE0", Offset = "0x21442E0", VA = "0x182145CE0")]
	private Entity OOFEPMABPOC(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1470", Offset = "0x3DBFA70", VA = "0x183DC1470")]
	private NIALADIPDNC OOFEPMABPOC(Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD6E0", Offset = "0x3DBBCE0", VA = "0x183DBD6E0", Slot = "4")]
	public T DNJGGIFCOKL(NIALADIPDNC KLCGNDEDAPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC03F0", Offset = "0x3DBE9F0", VA = "0x183DC03F0")]
	public bool KMNEKDAGPNL(NIALADIPDNC KLCGNDEDAPD, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC2D0", Offset = "0x3DBA8D0", VA = "0x183DBC2D0")]
	public bool ADOANPCNBFI(NIALADIPDNC KLCGNDEDAPD, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDE30", Offset = "0x3DBC430", VA = "0x183DBDE30", Slot = "9")]
	public bool DPFPNIAFGMD(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF2C0", Offset = "0x3DBD8C0", VA = "0x183DBF2C0", Slot = "26")]
	public object GOFJHIIODPI(NIALADIPDNC KLCGNDEDAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBFC20", Offset = "0x3DBE220", VA = "0x183DBFC20")]
	public bool IKGICBKDCJJ(NIALADIPDNC KLCGNDEDAPD, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDA70", Offset = "0x3DBC070", VA = "0x183DBDA70")]
	public void DNJGGIFCOKL(NIALADIPDNC KLCGNDEDAPD, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0940", Offset = "0x3DBEF40", VA = "0x183DC0940")]
	public bool KMNEKDAGPNL(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC6E0", Offset = "0x3DBACE0", VA = "0x183DBC6E0")]
	public bool ADOANPCNBFI(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF330", Offset = "0x3DBD930", VA = "0x183DBF330", Slot = "22")]
	public void HEIGEPEFDPE(IDBCBPLBJEI GIBODALIGFC, [Optional] object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF360", Offset = "0x3DBD960", VA = "0x183DBF360", Slot = "15")]
	public void HEIGEPEFDPE(NIALADIPDNC AIGAKEKDKHM, KMICCHHKOED GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3DBEFF0", Offset = "0x3DBD5F0", VA = "0x183DBEFF0", Slot = "14")]
	public bool GFHPIODIGEI(NIALADIPDNC DGEBCAGKNCO, NIALADIPDNC EIAMEKHGGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD130", Offset = "0x3DBB730", VA = "0x183DBD130")]
	private void DLADBALAOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0D30", Offset = "0x3DBF330", VA = "0x183DC0D30")]
	private void LFJNEAEHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE490", Offset = "0x3DBCA90", VA = "0x183DBE490")]
	private void EFHLPLLMDMO(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF800", Offset = "0x3DBDE00", VA = "0x183DBF800")]
	private void HIDHBMKDCIC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE010", Offset = "0x3DBC610", VA = "0x183DBE010", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC16D0", Offset = "0x3DBFCD0", VA = "0x183DC16D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0360", Offset = "0x3DBE960", VA = "0x183DC0360")]
	public string KABCHDDLAJE(in COGGJKLIPPL DFGEBCFIFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCC90", Offset = "0x3DBB290", VA = "0x183DBCC90", Slot = "5")]
	private bool DEOJJGGBJIA(NIALADIPDNC AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC03B0", Offset = "0x3DBE9B0", VA = "0x183DC03B0", Slot = "6")]
	private bool KEFJCLFNECC(NIALADIPDNC AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3940850", Offset = "0x393EE50", VA = "0x183940850", Slot = "10")]
	private bool HLKBALAMMCP(NIALADIPDNC AIGAKEKDKHM, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBEDC0", Offset = "0x3DBD3C0", VA = "0x183DBEDC0", Slot = "11")]
	private void GAPAFPKNHCL(NIALADIPDNC AIGAKEKDKHM, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC950", Offset = "0x3DBAF50", VA = "0x183DBC950", Slot = "12")]
	private bool BJHNEKCJDMM(NIALADIPDNC AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF0E0", Offset = "0x3DBD6E0", VA = "0x183DBF0E0", Slot = "13")]
	private bool GGDEOMLGNPG(NIALADIPDNC AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3DBED90", Offset = "0x3DBD390", VA = "0x183DBED90", Slot = "16")]
	private string FJNNPPFADPC(in COGGJKLIPPL MAKFNMHIJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JGONKIMCOJA : IDisposable, HEONIOFKGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FNAGHJOKBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public JGONKIMCOJA(NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7180", Offset = "0x3BC5780", VA = "0x183BC7180", Slot = "6")]
	public NIALADIPDNC NCLBEMCGPAN(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7170", Offset = "0x3BC5770", VA = "0x183BC7170", Slot = "7")]
	public Entity NCLBEMCGPAN(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3BC71D0", Offset = "0x3BC57D0", VA = "0x183BC71D0", Slot = "8")]
	public IEnumerable<NIALADIPDNC> NCLBEMCGPAN(IEnumerable<NIALADIPDNC> FEELJHFMNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7110", Offset = "0x3BC5710", VA = "0x183BC7110", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FGGEJMNNOEE OAOIBIPMINF;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int LEFCGOBKJIK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static HEONIOFKGAF GLKFPPDNABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool AGIBLGLNJDO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> FNAGHJOKBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x77BFF0", Offset = "0x77A5F0", VA = "0x18077BFF0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool IAIALDMGIMH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x77BCD0", Offset = "0x77A2D0", VA = "0x18077BCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x77BC70", Offset = "0x77A270", VA = "0x18077BC70")]
		public static SerializationRemapScope EFGLCJPBGNA()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x77C190", Offset = "0x77A790", VA = "0x18077C190")]
		public SerializationRemapScope(HEONIOFKGAF IHALOBEPDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x77BB60", Offset = "0x77A160", VA = "0x18077BB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x77BD60", Offset = "0x77A360", VA = "0x18077BD60")]
		public static NIALADIPDNC NCLBEMCGPAN(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77BEC0", Offset = "0x77A4C0", VA = "0x18077BEC0")]
		public static Entity NCLBEMCGPAN(Entity FLADPKIONGF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DHKIICMHACJ(typeof(FLCHKPMIIMP), new string[] { "Editor" })]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public sealed class FLCHKPMIIMP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void PDDCHJBBJGO(COEEIJJLOPG HJBMOBHOPDM, ODPPCAFLFEI JIHCLPECHIB, bool JECNHFKPBMO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void LNMGHGPAPDC(COEEIJJLOPG HJBMOBHOPDM, bool JECNHFKPBMO);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void GDPNCKKMIHE(COEEIJJLOPG HJBMOBHOPDM, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool JECNHFKPBMO);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PDDCHJBBJGO HNECIMGJBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB270", Offset = "0x3BB9870", VA = "0x183BBB270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB310", Offset = "0x3BB9910", VA = "0x183BBB310")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LNMGHGPAPDC KGNIOJBDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB5D0", Offset = "0x3BB9BD0", VA = "0x183BBB5D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB530", Offset = "0x3BB9B30", VA = "0x183BBB530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GDPNCKKMIHE NGHCKACDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB3F0", Offset = "0x3BB99F0", VA = "0x183BBB3F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB490", Offset = "0x3BB9A90", VA = "0x183BBB490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB3D0", Offset = "0x3BB99D0", VA = "0x183BBB3D0")]
	[Conditional("UNITY_EDITOR")]
	public void FEHPJLPCCNM(COEEIJJLOPG HJBMOBHOPDM, in ODPPCAFLFEI JIHCLPECHIB, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB3B0", Offset = "0x3BB99B0", VA = "0x183BBB3B0")]
	[Conditional("UNITY_EDITOR")]
	public void EHDLFMKFHKL(COEEIJJLOPG HJBMOBHOPDM, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB670", Offset = "0x3BB9C70", VA = "0x183BBB670")]
	[Conditional("UNITY_EDITOR")]
	public void OHEBKFOOFEJ(COEEIJJLOPG HJBMOBHOPDM, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FLCHKPMIIMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DHKIICMHACJ(typeof(PNILGBJCJNO), new string[] { "Editor" })]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public sealed class PNILGBJCJNO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void KNHAKMNKNMM(COEEIJJLOPG FBIBIHJENAB, ODPPCAFLFEI JIHCLPECHIB, bool JECNHFKPBMO);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void CJBDJABJIBA(COEEIJJLOPG FBIBIHJENAB, bool JECNHFKPBMO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void CNKLNJABDIB(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool JECNHFKPBMO, bool OPBABOLEFKI);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void MKINNGKOGGH(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void PANJGFGLBKA(OKMKIIGHDIM AIGAKEKDKHM, ReadOnlyMemory<byte> GOMBJHKPMMM);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event KNHAKMNKNMM HNECIMGJBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3894600", Offset = "0x3892C00", VA = "0x183894600")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3894810", Offset = "0x3892E10", VA = "0x183894810")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CJBDJABJIBA KGNIOJBDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3895020", Offset = "0x3893620", VA = "0x183895020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3894EE0", Offset = "0x38934E0", VA = "0x183894EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event KNHAKMNKNMM LIEFGBLDIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3894A70", Offset = "0x3893070", VA = "0x183894A70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3894E10", Offset = "0x3893410", VA = "0x183894E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event CJBDJABJIBA NCCGFNIDICD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x38948B0", Offset = "0x3892EB0", VA = "0x1838948B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3894B10", Offset = "0x3893110", VA = "0x183894B10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event CNKLNJABDIB NGHCKACDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3894980", Offset = "0x3892F80", VA = "0x183894980")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3894D70", Offset = "0x3893370", VA = "0x183894D70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MKINNGKOGGH DPIKBEILBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3894BD0", Offset = "0x38931D0", VA = "0x183894BD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3894CD0", Offset = "0x38932D0", VA = "0x183894CD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> JLAHLIMLOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3894F80", Offset = "0x3893580", VA = "0x183894F80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x38950E0", Offset = "0x38936E0", VA = "0x1838950E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event PANJGFGLBKA JCAOCFMBODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x38946A0", Offset = "0x3892CA0", VA = "0x1838946A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3894740", Offset = "0x3892D40", VA = "0x183894740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3894A40", Offset = "0x3893040", VA = "0x183894A40")]
	[Conditional("UNITY_EDITOR")]
	public void FPKIDIFHAEM(COEEIJJLOPG FBIBIHJENAB, in ODPPCAFLFEI JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x38950C0", Offset = "0x38936C0", VA = "0x1838950C0")]
	[Conditional("UNITY_EDITOR")]
	public void NFOGGMEOAGK(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x38947E0", Offset = "0x3892DE0", VA = "0x1838947E0")]
	[Conditional("UNITY_EDITOR")]
	public void CFEDDMKCBCH(COEEIJJLOPG FBIBIHJENAB, in ODPPCAFLFEI JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3894BB0", Offset = "0x38931B0", VA = "0x183894BB0")]
	[Conditional("UNITY_EDITOR")]
	public void IDLPOBCCBLF(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3894950", Offset = "0x3892F50", VA = "0x183894950")]
	[Conditional("UNITY_EDITOR")]
	public void DLNEKHEAMGF(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool OPBABOLEFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3894A20", Offset = "0x3893020", VA = "0x183894A20")]
	[Conditional("UNITY_EDITOR")]
	public void FMPCCECLHGK(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3894C70", Offset = "0x3893270", VA = "0x183894C70")]
	[Conditional("UNITY_EDITOR")]
	public void LHAAEGKOEBH(string NBODBMLPNJA, object GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3894EB0", Offset = "0x38934B0", VA = "0x183894EB0")]
	[Conditional("UNITY_EDITOR")]
	public void MLOIHEJKJOC(OKMKIIGHDIM AIGAKEKDKHM, ReadOnlyMemory<byte> GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public PNILGBJCJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DHKIICMHACJ(typeof(HNFOOABEAMF), new string[] { })]
public class CMNFIJDIHFF : HNFOOABEAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38F8F60", Offset = "0x38F7560", VA = "0x1838F8F60", Slot = "5")]
	public void PMPKLGNHKCF(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x38F8E80", Offset = "0x38F7480", VA = "0x1838F8E80", Slot = "6")]
	public void PJEMNEPHBOF(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38F8C90", Offset = "0x38F7290", VA = "0x1838F8C90", Slot = "7")]
	public void GHGGJEKDBMH(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x38F8D70", Offset = "0x38F7370", VA = "0x1838F8D70", Slot = "4")]
	public IDisposable KLAGOJJNMDO(object DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CMNFIJDIHFF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DHKIICMHACJ(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	internal class BulkInstantiateSceneObjectService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string GANOBGOKJNH = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[CJONPMHNDBN]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[CJONPMHNDBN]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[CJONPMHNDBN]
		private BBGDLMHBFGH PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery NGBDCFJBCPH;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x38F6EB0", Offset = "0x38F54B0", VA = "0x1838F6EB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x38F6AC0", Offset = "0x38F50C0", VA = "0x1838F6AC0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x38F5B40", Offset = "0x38F4140", VA = "0x1838F5B40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x38F5B50", Offset = "0x38F4150", VA = "0x1838F5B50")]
		public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> IFDAGNIOADM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x38F6F00", Offset = "0x38F5500", VA = "0x1838F6F00")]
		public static bool PAKCIOFGFIL(PDNLIBNBICJ GHNJJOLFHLE, out COEEIJJLOPG FBIBIHJENAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x38F6510", Offset = "0x38F4B10", VA = "0x1838F6510")]
		private void IOOOJMONDON(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, IEnumerable<PDNLIBNBICJ> IFDAGNIOADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x38F6890", Offset = "0x38F4E90", VA = "0x1838F6890")]
		private void JMAGEBLCLJK(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x38F7010", Offset = "0x38F5610", VA = "0x1838F7010")]
		private void PMBJLCKAJHM(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, COEEIJJLOPG FBIBIHJENAB, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38F76C0", Offset = "0x38F5CC0", VA = "0x1838F76C0")]
		private void POLCDJEHEKK(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x38F5C70", Offset = "0x38F4270", VA = "0x1838F5C70")]
		private void HJBLHLMNPML(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, List<PDNLIBNBICJ> MDDLBBEJIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x38F6CE0", Offset = "0x38F52E0", VA = "0x1838F6CE0")]
		private NativeList<COEEIJJLOPG> OMHOMAGHPEC(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
			return default(NativeList<COEEIJJLOPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38F74F0", Offset = "0x38F5AF0", VA = "0x1838F74F0")]
		private NativeArray<Entity> PMMKNAJGDOK(NativeList<COEEIJJLOPG> PNEBOKCAENN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x38F6C40", Offset = "0x38F5240", VA = "0x1838F6C40")]
		private static void NMNBJNPMHAB(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, COEEIJJLOPG FBIBIHJENAB, PDNLIBNBICJ GHNJJOLFHLE, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	[DHKIICMHACJ(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool DHMPGINIHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0480", Offset = "0x3BAEA80", VA = "0x183BB0480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3BB03C0", Offset = "0x3BAE9C0", VA = "0x183BB03C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool HAFBIPGILLK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0400", Offset = "0x3BAEA00", VA = "0x183BB0400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0440", Offset = "0x3BAEA40", VA = "0x183BB0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void AKJHGKNEMFG(string NBODBMLPNJA, EntityManager LNPEGOPJJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public static void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DHKIICMHACJ(typeof(ACADFKAKLNJ), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
internal class ACADFKAKLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7F09C0", Offset = "0x7EEFC0", VA = "0x1807F09C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool PNILLHLFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7F09B0", Offset = "0x7EEFB0", VA = "0x1807F09B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7F09D0", Offset = "0x7EEFD0", VA = "0x1807F09D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public ACADFKAKLNJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CMEMHKMDBHK(typeof(SerializationService))]
	[DHKIICMHACJ(typeof(CPFCFGLKHDP), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	internal class SerializationService : CPFCFGLKHDP, IDisposable, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FGGEJMNNOEE CENBFJJCBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[CJONPMHNDBN]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[CJONPMHNDBN]
		private NODJLDEEPBE GLIGCLJIOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[CJONPMHNDBN]
		private ACADFKAKLNJ HEJDNNNGOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private JDGJKANJDLB JEAKNBODBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OOEKEMBOFOH CGKANKMMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope FEOPLMNGHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? IEEHFBMOEHO;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool OIFDDFPPONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x77DF20", Offset = "0x77C520", VA = "0x18077DF20", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x77DE70", Offset = "0x77C470", VA = "0x18077DE70", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool MLDJEKHGDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x77C680", Offset = "0x77AC80", VA = "0x18077C680", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x70C3B0", Offset = "0x70A9B0", VA = "0x18070C3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public OOEKEMBOFOH DNGHIFJGAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x77DE80", Offset = "0x77C480", VA = "0x18077DE80", Slot = "16")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x77CA90", Offset = "0x77B090", VA = "0x18077CA90", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x77DD40", Offset = "0x77C340", VA = "0x18077DD40")]
		public static bool LGJCPCMMJDL(ByteString FJHIHOOEHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760")]
		public void DFPABCJAJIP(JDGJKANJDLB KJMBMCGJAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x77C690", Offset = "0x77AC90", VA = "0x18077C690", Slot = "5")]
		public void CAFNGMCCLJO(bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x77CAA0", Offset = "0x77B0A0", VA = "0x18077CAA0", Slot = "6")]
		public Task EEOLLOMMEME(bool CFGMGGHPOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x77D350", Offset = "0x77B950", VA = "0x18077D350", Slot = "7")]
		public ByteString HGEKGOKJCDE(out IDisposable FEOPLMNGHHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x77D430", Offset = "0x77BA30", VA = "0x18077D430", Slot = "19")]
		public ByteString HGEKGOKJCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x77CD30", Offset = "0x77B330", VA = "0x18077CD30", Slot = "9")]
		public bool FFFJLEEKFAK(ByteString KGNNNIOABNI, LGHOOJDLGDA NBBMMINMBNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x77C770", Offset = "0x77AD70", VA = "0x18077C770")]
		private bool DKKCGCHEDOL(ByteString KGNNNIOABNI, LGHOOJDLGDA NBBMMINMBNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x77C4B0", Offset = "0x77AAB0", VA = "0x18077C4B0", Slot = "8")]
		public void ALCNIPKLHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x77D8A0", Offset = "0x77BEA0", VA = "0x18077D8A0", Slot = "10")]
		public bool IKNKCCOLBMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x77D090", Offset = "0x77B690", VA = "0x18077D090", Slot = "11")]
		public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x77CD90", Offset = "0x77B390", VA = "0x18077CD90")]
		public bool FHAGLJJEIBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x77DB10", Offset = "0x77C110", VA = "0x18077DB10", Slot = "12")]
		public bool KPNGBGLCOHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x77D610", Offset = "0x77BC10", VA = "0x18077D610")]
		public void HPLHBIJMEIC(OOEKEMBOFOH.EDALOGCEEGJ.HOKHMJPLAHB ILAPGNJICNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x77C220", Offset = "0x77A820", VA = "0x18077C220")]
		private bool AKPNNKMGKOD(ByteString KGNNNIOABNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x77D300", Offset = "0x77B900", VA = "0x18077D300")]
		private void HFEOOJJCBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x77D030", Offset = "0x77B630", VA = "0x18077D030")]
		private ByteString GLNPFDLBBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x77CF20", Offset = "0x77B520", VA = "0x18077CF20")]
		private ByteString FMMMFPMNJGH(ByteString FJHIHOOEHJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x77E100", Offset = "0x77C700", VA = "0x18077E100")]
		private OOEKEMBOFOH.EDALOGCEEGJ.HOKHMJPLAHB PKDOFDMECCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x77CD00", Offset = "0x77B300", VA = "0x18077CD00")]
		private void FDBCEOHOEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x77CB30", Offset = "0x77B130", VA = "0x18077CB30", Slot = "13")]
		public bool EOIOFEACJOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x77CE70", Offset = "0x77B470", VA = "0x18077CE70", Slot = "14")]
		public void FHJCBOAFEOJ(bool BHFCIBGKHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x77DF30", Offset = "0x77C530", VA = "0x18077DF30")]
		private void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DHKIICMHACJ(typeof(PAJFOGDKCPC), new string[] { })]
[CMEMHKMDBHK(typeof(NODJLDEEPBE))]
internal class NODJLDEEPBE : PAJFOGDKCPC
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action KIMLPLPJNCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3882A30", Offset = "0x3881030", VA = "0x183882A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38827B0", Offset = "0x3880DB0", VA = "0x1838827B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HEONIOFKGAF> ANPDIGHBHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x38828F0", Offset = "0x3880EF0", VA = "0x1838828F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3882580", Offset = "0x3880B80", VA = "0x183882580", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action HBPLGFLPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3882990", Offset = "0x3880F90", VA = "0x183882990", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3882AD0", Offset = "0x38810D0", VA = "0x183882AD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JPHHPJDBILA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3882850", Offset = "0x3880E50", VA = "0x183882850", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3882710", Offset = "0x3880D10", VA = "0x183882710", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HEONIOFKGAF> KJAGJABOKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3882B70", Offset = "0x3881170", VA = "0x183882B70", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3882670", Offset = "0x3880C70", VA = "0x183882670", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B950", Offset = "0x1C99F50", VA = "0x181C9B950")]
	public void ALCNIPKLHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5FC0", Offset = "0x1FB45C0", VA = "0x181FB5FC0")]
	public void ACJAHNDDKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D6E0", Offset = "0x1E4BCE0", VA = "0x181E4D6E0")]
	public void CPDCLCJIPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3882620", Offset = "0x3880C20", VA = "0x183882620")]
	public void DLJHKLKAACH(HEONIOFKGAF GLKFPPDNABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3882530", Offset = "0x3880B30", VA = "0x183882530")]
	public void CKHDJDHKJJN(HEONIOFKGAF GLKFPPDNABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NODJLDEEPBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DHKIICMHACJ(typeof(OPAKLFEDMAA), new string[] { })]
public class AMBGKGAOIAL : OPAKLFEDMAA, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents AKGGBDCLIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private KOEDGMLBPFH GDDMJGIBAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService NCAANBGOHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::DHFNFLDBPNF<NIALADIPDNC> HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x731D00", Offset = "0x730300", VA = "0x180731D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x38EF680", Offset = "0x38EDC80", VA = "0x1838EF680")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x968E40", Offset = "0x967440", VA = "0x180968E40", Slot = "14")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x38EF3E0", Offset = "0x38ED9E0", VA = "0x1838EF3E0", Slot = "15")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x38EED80", Offset = "0x38ED380", VA = "0x1838EED80", Slot = "16")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xE7FB80", Offset = "0xE7E180", VA = "0x180E7FB80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3887F10", Offset = "0x3886510", VA = "0x183887F10")]
	private NIALADIPDNC EPEPGGCDEDK(Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x38EF2F0", Offset = "0x38ED8F0", VA = "0x1838EF2F0", Slot = "4")]
	public NIALADIPDNC KCDNPIAEBEL(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x38EEB60", Offset = "0x38ED160", VA = "0x1838EEB60", Slot = "19")]
	public void BMFAMGNJFCC(ref List<NIALADIPDNC> BEMBCCNAMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x38EF170", Offset = "0x38ED770", VA = "0x1838EF170", Slot = "20")]
	public IEnumerable<NIALADIPDNC> IPMINALCKNM(NIALADIPDNC KLCGNDEDAPD, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x38EEA60", Offset = "0x38ED060", VA = "0x1838EEA60", Slot = "21")]
	public NIALADIPDNC ALAEJPDKHIN(NIALADIPDNC KLCGNDEDAPD, int EBBLFLFCHFB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x38EE850", Offset = "0x38ECE50", VA = "0x1838EE850", Slot = "22")]
	public int ABJOCCLMFMB(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x38EF240", Offset = "0x38ED840", VA = "0x1838EF240", Slot = "8")]
	public int JGMHFKDKOJL(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x38EE970", Offset = "0x38ECF70", VA = "0x1838EE970", Slot = "9")]
	public OKKOFBJCFMA AHEFCACPBBA(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(OKKOFBJCFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x38EEE70", Offset = "0x38ED470", VA = "0x1838EEE70", Slot = "23")]
	public bool DIEIHEANPAO(NIALADIPDNC KLCGNDEDAPD, out OKKOFBJCFMA HONBDPFPFMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x38EF5B0", Offset = "0x38EDBB0", VA = "0x1838EF5B0", Slot = "24")]
	public IEnumerable<NIALADIPDNC> OPILOIOFOMC(NIALADIPDNC KLCGNDEDAPD, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x38EF4E0", Offset = "0x38EDAE0", VA = "0x1838EF4E0", Slot = "12")]
	public NIALADIPDNC OJHGJIBAMMJ(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x38EF070", Offset = "0x38ED670", VA = "0x1838EF070", Slot = "13")]
	public bool DNKFCLNJCJP(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON, out NIALADIPDNC JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x38EF380", Offset = "0x38ED980", VA = "0x1838EF380", Slot = "5")]
	public NIALADIPDNC NCMHOFMDGAH(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x38EF350", Offset = "0x38ED950", VA = "0x1838EF350", Slot = "11")]
	public bool LLHMMIJNOKL(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x38EF6D0", Offset = "0x38EDCD0", VA = "0x1838EF6D0", Slot = "25")]
	public bool PKNAJOGAKAI(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC IMDKOHMGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x38EF040", Offset = "0x38ED640", VA = "0x1838EF040", Slot = "10")]
	public bool DNJHMIGKLJO(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC EOECNBNBJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x38EF4B0", Offset = "0x38EDAB0", VA = "0x1838EF4B0", Slot = "6")]
	public bool OGODNIIEFFB(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC LFAIGCEGCPL, bool KEKDECHAOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x38EF140", Offset = "0x38ED740", VA = "0x1838EF140", Slot = "7")]
	public bool EAIMLJHMGNG(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC LFAIGCEGCPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AMBGKGAOIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(DJJJJFKCAHK), new string[] { })]
internal class DJJJJFKCAHK : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[CJONPMHNDBN]
	private OMKGMEPBKLL KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, DELPMNCMFNN> GFCKIGMAKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3906FD0", Offset = "0x39055D0", VA = "0x183906FD0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3906A30", Offset = "0x3905030", VA = "0x183906A30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3906CB0", Offset = "0x39052B0", VA = "0x183906CB0")]
	public DELPMNCMFNN EGNPFCCJCMB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3906DB0", Offset = "0x39053B0", VA = "0x183906DB0")]
	public DELPMNCMFNN EGNPFCCJCMB(HDFAPEIIIAK DPEKNLAIHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3907020", Offset = "0x3905620", VA = "0x183907020")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x39071B0", Offset = "0x39057B0", VA = "0x1839071B0")]
	public DJJJJFKCAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class DELPMNCMFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<LODLLBEOEDK> FIFLJMCAPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<KCBMDFFNPLE> MHLEJMGJHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<AGAIJBALKEC> CIBDONFAOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<KCBMDFFNPLE> HMPJBGJHGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<LODLLBEOEDK> NBFIJBANICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0")]
		get
		{
			return default(NativeList<LODLLBEOEDK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<KCBMDFFNPLE> ENEAKBAAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x783BB0", Offset = "0x7821B0", VA = "0x180783BB0")]
		get
		{
			return default(NativeList<KCBMDFFNPLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<AGAIJBALKEC> ICFKOKKMJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xBA3FD0", Offset = "0xBA25D0", VA = "0x180BA3FD0")]
		get
		{
			return default(NativeList<AGAIJBALKEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<KCBMDFFNPLE> FPPCMHBMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9747B0", Offset = "0x972DB0", VA = "0x1809747B0")]
		get
		{
			return default(NativeList<KCBMDFFNPLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle OKNAOHFLMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A70", Offset = "0x7E4070", VA = "0x1807E5A70")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2508700", Offset = "0x2506D00", VA = "0x182508700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool ANLEMNFHGII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x39058E0", Offset = "0x3903EE0", VA = "0x1839058E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3905E60", Offset = "0x3904460", VA = "0x183905E60")]
	public DELPMNCMFNN(Allocator GGLOKAHPEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3905DD0", Offset = "0x39043D0", VA = "0x183905DD0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3905990", Offset = "0x3903F90", VA = "0x183905990")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3905AC0", Offset = "0x39040C0", VA = "0x183905AC0")]
	public void MFMCNFFMIAP(Entity FLADPKIONGF, Entity KOEBMFNDCDN, Entity EBIGGMLCEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DHKIICMHACJ(typeof(HOJCKGLMAHI), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
public class HOJCKGLMAHI : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[CJONPMHNDBN]
	private SceneService LCJDMKABNOO;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1860", Offset = "0x3BBFE60", VA = "0x183BC1860", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1840", Offset = "0x3BBFE40", VA = "0x183BC1840", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public HOJCKGLMAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class BEIHDBKAKLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint BPBPMCAKOIE;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint IDNOEBNGGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xC9A320", Offset = "0xC98920", VA = "0x180C9A320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x38F3CB0", Offset = "0x38F22B0", VA = "0x1838F3CB0")]
	public COEEIJJLOPG OGMOOIPPHPH()
	{
		return default(COEEIJJLOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x38F3C00", Offset = "0x38F2200", VA = "0x1838F3C00")]
	public void OCNLHILDMBA(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9240B0", Offset = "0x9226B0", VA = "0x1809240B0", Slot = "6")]
	public virtual void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	protected BEIHDBKAKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(HCBDOBJPIPH), new string[] { })]
internal sealed class HCBDOBJPIPH : BEIHDBKAKLB, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[CJONPMHNDBN]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint NPMIJOEHCCM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint IDNOEBNGGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x70F350", Offset = "0x70D950", VA = "0x18070F350", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0F10", Offset = "0x3BBF510", VA = "0x183BC0F10", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0EC0", Offset = "0x3BBF4C0", VA = "0x183BC0EC0")]
	private void GLPHCFDDABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0E60", Offset = "0x3BBF460", VA = "0x183BC0E60", Slot = "6")]
	public override void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public HCBDOBJPIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DHKIICMHACJ(typeof(EOGPNGLEECK), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal sealed class EOGPNGLEECK : BEIHDBKAKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint IDNOEBNGGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public EOGPNGLEECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(AIEDMPHMCJI), new string[] { })]
internal sealed class AIEDMPHMCJI : GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery NKBFAIHAJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery FPHGINGCEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery LFKAMKJJMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery CNFCEILKNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery PKFILNCGNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery KPNKOLNCPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x38EE280", Offset = "0x38EC880", VA = "0x1838EE280")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery IJIBFNGGDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery LONNJGHEKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x79D130", Offset = "0x79B730", VA = "0x18079D130")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery BPKGNOGCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x73C670", Offset = "0x73AC70", VA = "0x18073C670")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MEHHOICNIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A70", Offset = "0x7E4070", VA = "0x1807E5A70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PEDBCJGKHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B60", Offset = "0x7E4160", VA = "0x1807E5B60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery JKNFNMHCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38EE190", Offset = "0x38EC790", VA = "0x1838EE190")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int AEFMACOGJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x38EDA20", Offset = "0x38EC020", VA = "0x1838EDA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int GFFJNIOHENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x38EE0C0", Offset = "0x38EC6C0", VA = "0x1838EE0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KPJKFNMIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x38ED980", Offset = "0x38EBF80", VA = "0x1838ED980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CLADKEDBOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x38EE210", Offset = "0x38EC810", VA = "0x1838EE210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int GAOBMDALHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x38ED9A0", Offset = "0x38EBFA0", VA = "0x1838ED9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int NJKCHLCGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x38EDF40", Offset = "0x38EC540", VA = "0x1838EDF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x38EE230", Offset = "0x38EC830", VA = "0x1838EE230", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x38EDA40", Offset = "0x38EC040", VA = "0x1838EDA40", Slot = "6")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x38ED9C0", Offset = "0x38EBFC0", VA = "0x1838ED9C0")]
	private EntityQueryDesc BMAMMLJNGNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x38EDEE0", Offset = "0x38EC4E0", VA = "0x1838EDEE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x38EE010", Offset = "0x38EC610", VA = "0x1838EE010")]
	public ODOBGKDOFKD GBHFENEHOGG(NIALADIPDNC EHLCJHMJBBP)
	{
		return default(ODOBGKDOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x38EDF60", Offset = "0x38EC560", VA = "0x1838EDF60")]
	public ODOBGKDOFKD GBHFENEHOGG(Entity FLADPKIONGF)
	{
		return default(ODOBGKDOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x38EE0E0", Offset = "0x38EC6E0", VA = "0x1838EE0E0")]
	public HLEPLICHNKK JJGMBAPGGMB(Entity FLADPKIONGF)
	{
		return default(HLEPLICHNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x38EE2D0", Offset = "0x38EC8D0", VA = "0x1838EE2D0")]
	public AIEDMPHMCJI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[DAINLFLPADL(OHEDAGNNHJA.All)]
	[DHKIICMHACJ(typeof(CLJEHOFLHAA), new string[] { })]
	public class ObjectService : GOJCOOFCPOI, CLJEHOFLHAA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly FGGEJMNNOEE FKOIAEJIAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[CJONPMHNDBN]
		private OBPBNOCJFPI FLDPOGAHGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[CJONPMHNDBN]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[CJONPMHNDBN]
		private ObjectLifecycleService BKOGMAMFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[CJONPMHNDBN]
		private ObjectEmbodimentService NCAANBGOHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[CJONPMHNDBN]
		private ObjectInstantiationService EJCAANKBGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[CJONPMHNDBN]
		private AIEDMPHMCJI GDDMJGIBAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService GEHGBPFFMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OBPBNOCJFPI ABBJLIEIKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int AEFMACOGJLN
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x388EB40", Offset = "0x388D140", VA = "0x18388EB40", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int GFFJNIOHENI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x388F620", Offset = "0x388DC20", VA = "0x18388F620", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int KPJKFNMIPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x388E790", Offset = "0x388CD90", VA = "0x18388E790", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CLADKEDBOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x38900A0", Offset = "0x388E6A0", VA = "0x1838900A0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int GAOBMDALHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x388E7B0", Offset = "0x388CDB0", VA = "0x18388E7B0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int NJKCHLCGMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x388F320", Offset = "0x388D920", VA = "0x18388F320", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<NIALADIPDNC, HLEPLICHNKK> KHMHAFFAPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x388F130", Offset = "0x388D730", VA = "0x18388F130", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x388E7D0", Offset = "0x388CDD0", VA = "0x18388E7D0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<NIALADIPDNC> NHLEHDOIPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x388FDF0", Offset = "0x388E3F0", VA = "0x18388FDF0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x388F450", Offset = "0x388DA50", VA = "0x18388F450", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x38900C0", Offset = "0x388E6C0", VA = "0x1838900C0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x388EFB0", Offset = "0x388D5B0", VA = "0x18388EFB0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x388ECC0", Offset = "0x388D2C0", VA = "0x18388ECC0")]
		private void DFOJNMEGACD(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x388EE10", Offset = "0x388D410", VA = "0x18388EE10")]
		private void DMOEAPAFOCK(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x388F340", Offset = "0x388D940", VA = "0x18388F340")]
		internal NIALADIPDNC EPEPGGCDEDK(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x388EAA0", Offset = "0x388D0A0", VA = "0x18388EAA0", Slot = "41")]
		public OKKOFBJCFMA CDIEAIOHHOI()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x388ED60", Offset = "0x388D360", VA = "0x18388ED60", Slot = "42")]
		public OKKOFBJCFMA DJKLOGCINHF()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x388FEB0", Offset = "0x388E4B0", VA = "0x18388FEB0", Slot = "43")]
		public OKKOFBJCFMA LGELAFNPICM()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x388F3B0", Offset = "0x388D9B0", VA = "0x18388F3B0", Slot = "10")]
		public ODOBGKDOFKD GBHFENEHOGG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(ODOBGKDOFKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x388FA20", Offset = "0x388E020", VA = "0x18388FA20", Slot = "11")]
		public HLEPLICHNKK JJGMBAPGGMB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x388E9A0", Offset = "0x388CFA0", VA = "0x18388E9A0")]
		private OKKOFBJCFMA BKKBIDPJMNE(EntityQuery AMEIGJPGLKK)
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x388EEA0", Offset = "0x388D4A0", VA = "0x18388EEA0", Slot = "33")]
		public bool DPFPNIAFGMD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x388F4F0", Offset = "0x388DAF0", VA = "0x18388F4F0", Slot = "29")]
		public void GGPEMOPMMCE(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x388EB60", Offset = "0x388D160", VA = "0x18388EB60", Slot = "30")]
		public void CGLPGHAHONL(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3890540", Offset = "0x388EB40", VA = "0x183890540", Slot = "31")]
		public void PDCINDJGKMO(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x388F6F0", Offset = "0x388DCF0", VA = "0x18388F6F0", Slot = "22")]
		public INPNGJHLELG HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x388F640", Offset = "0x388DC40", VA = "0x18388F640", Slot = "23")]
		public INPNGJHLELG HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3890390", Offset = "0x388E990", VA = "0x183890390", Slot = "24")]
		public INPNGJHLELG NNEMDFGGGMJ(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x388F7D0", Offset = "0x388DDD0", VA = "0x18388F7D0", Slot = "25")]
		public INPNGJHLELG INDFCIHCJOC(COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x388E6C0", Offset = "0x388CCC0", VA = "0x18388E6C0", Slot = "44")]
		public INPNGJHLELG AAMMNLAAJBN(int GODMIFAALFB, HLEPLICHNKK IGDDGFIHFCA, GameObject EHEABJNEALG)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x388EBC0", Offset = "0x388D1C0", VA = "0x18388EBC0", Slot = "26")]
		public ADPNEJLEBMK CKCDOPLEPGG()
		{
			return default(ADPNEJLEBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3890420", Offset = "0x388EA20", VA = "0x183890420", Slot = "45")]
		public HPDKCBPJHII PAOGIEEBPDE(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(HPDKCBPJHII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x388F540", Offset = "0x388DB40", VA = "0x18388F540", Slot = "27")]
		public GACPLFBDPAB HDLNFCHMNLC()
		{
			return default(GACPLFBDPAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x388FB00", Offset = "0x388E100", VA = "0x18388FB00", Slot = "28")]
		public MJKCNNIGAAE KIBFEIABGNF(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(MJKCNNIGAAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x388FE90", Offset = "0x388E490", VA = "0x18388FE90", Slot = "12")]
		public void KOEBKPOFGOP(COEEIJJLOPG FBIBIHJENAB, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x388F1D0", Offset = "0x388D7D0", VA = "0x18388F1D0", Slot = "13")]
		public INPNGJHLELG EGMFKDJNLKC(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x388EA50", Offset = "0x388D050", VA = "0x18388EA50", Slot = "14")]
		public bool CDEJDKLJJPA(NIALADIPDNC KLCGNDEDAPD, out GLICHKLIKDB BIDLMNEFHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x388F360", Offset = "0x388D960", VA = "0x18388F360", Slot = "46")]
		public Transform FJAPHIONMLH(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3890050", Offset = "0x388E650", VA = "0x183890050", Slot = "16")]
		public bool MKGOOONPMIK(NIALADIPDNC KLCGNDEDAPD, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x388FF50", Offset = "0x388E550", VA = "0x18388FF50", Slot = "17")]
		public bool LOMGEMGINNG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x388E760", Offset = "0x388CD60", VA = "0x18388E760")]
		public bool ADPNNHDPBFH(GLICHKLIKDB MAKFNMHIJIF, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x388E730", Offset = "0x388CD30", VA = "0x18388E730", Slot = "47")]
		public bool ADPNNHDPBFH(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x388F7B0", Offset = "0x388DDB0", VA = "0x18388F7B0", Slot = "48")]
		public void IHFDMGOCGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x388FC40", Offset = "0x388E240", VA = "0x18388FC40", Slot = "15")]
		public void KJDHLIJPDHF(GLICHKLIKDB LGKNNMGLNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x388E960", Offset = "0x388CF60", VA = "0x18388E960", Slot = "49")]
		public void BJPKHDLNNBP(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x388EF30", Offset = "0x388D530", VA = "0x18388EF30", Slot = "18")]
		public bool DPKIDNMHHHJ(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x388F9A0", Offset = "0x388DFA0", VA = "0x18388F9A0", Slot = "19")]
		public bool JGABPGKHJJO(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x388FFE0", Offset = "0x388E5E0", VA = "0x18388FFE0", Slot = "50")]
		public bool MHNBBGFCOPH(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x388F3E0", Offset = "0x388D9E0", VA = "0x18388F3E0", Slot = "51")]
		public bool GCEGADAHECD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3890330", Offset = "0x388E930", VA = "0x183890330", Slot = "32")]
		public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x388FA60", Offset = "0x388E060", VA = "0x18388FA60", Slot = "21")]
		public COEEIJJLOPG KHNEHGBKPKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(COEEIJJLOPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x388E870", Offset = "0x388CE70", VA = "0x18388E870", Slot = "20")]
		public NIALADIPDNC BIKIJJFPJAP(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x388EC80", Offset = "0x388D280", VA = "0x18388EC80")]
		private void CLDACEFIDLN(HLEPLICHNKK IGDDGFIHFCA, NIALADIPDNC KLCGNDEDAPD, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DHKIICMHACJ(typeof(BBMIMLMPGHJ), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal sealed class BBMIMLMPGHJ : GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService EJCAANKBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[CJONPMHNDBN]
	private AIEDMPHMCJI GDDMJGIBAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x38F3310", Offset = "0x38F1910", VA = "0x1838F3310", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x38F33A0", Offset = "0x38F19A0", VA = "0x1838F33A0")]
	public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
	{
		return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x38F2940", Offset = "0x38F0F40", VA = "0x1838F2940")]
	private void GJBEKJLIACA(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x38F2B20", Offset = "0x38F1120", VA = "0x1838F2B20")]
	private void LABMEBHLGIH(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD, int IGDDGFIHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x38F27B0", Offset = "0x38F0DB0", VA = "0x1838F27B0")]
	private void DDHKODNIFGK(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD, int IGDDGFIHFCA, LDCIHJCLMHG KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x38F2FB0", Offset = "0x38F15B0", VA = "0x1838F2FB0")]
	private NativeMultiHashMap<int, (NIALADIPDNC, NIALADIPDNC)> LLPEKOFHKBJ(Allocator GGLOKAHPEPM, NativeArray<NIALADIPDNC> GDBKNKBNEEN, out NativeArray<(NIALADIPDNC src, NIALADIPDNC dst)> FCJMLDEPMCK)
	{
		return default(NativeMultiHashMap<int, (NIALADIPDNC, NIALADIPDNC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BBMIMLMPGHJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CMEMHKMDBHK(typeof(TransformService))]
	[DHKIICMHACJ(typeof(BBGDLMHBFGH), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	public class TransformService : BBGDLMHBFGH, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FGGEJMNNOEE GIAAKEBNJLM;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly FGGEJMNNOEE JHELHOANAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private CBAJMILGKOG LLLBMIKLOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private OPAKLFEDMAA BFIDBOCPJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase DEDNOONHNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService MAENFGNHNOF;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x788840", Offset = "0x786E40", VA = "0x180788840")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private NNAMEJEONOI MLIEHBECBGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x7846C0", Offset = "0x782CC0", VA = "0x1807846C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x787F40", Offset = "0x786540", VA = "0x180787F40", Slot = "33")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x783D70", Offset = "0x782370", VA = "0x180783D70", Slot = "34")]
		public bool AOHOHCHBAPN(Transform HJLACGOIJCA, out NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x785630", Offset = "0x783C30", VA = "0x180785630", Slot = "35")]
		public Transform EGPJFBDDOGE(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x787D50", Offset = "0x786350", VA = "0x180787D50", Slot = "30")]
		public bool MKGOOONPMIK(Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x788890", Offset = "0x786E90", VA = "0x180788890")]
		private void PCJOBHBOEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x786DA0", Offset = "0x7853A0", VA = "0x180786DA0", Slot = "29")]
		public void JCLDIEMBPGK(Entity FLADPKIONGF, out Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x785240", Offset = "0x783840", VA = "0x180785240", Slot = "4")]
		public void ECHHBHCOJJD(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x785C40", Offset = "0x784240", VA = "0x180785C40")]
		public void GMFIHJOPNCL(Entity FLADPKIONGF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL, Vector3 PPCHAAFEDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x788A80", Offset = "0x787080", VA = "0x180788A80")]
		public void PKGDKAJPBGM(Entity FLADPKIONGF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x788830", Offset = "0x786E30", VA = "0x180788830", Slot = "27")]
		public void OKHKBBAHJHG(Entity FLADPKIONGF, out Matrix4x4 MIAMIGJGGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x788470", Offset = "0x786A70", VA = "0x180788470")]
		public void OHOAOOEHGBO(Entity FLADPKIONGF, in Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x787560", Offset = "0x785B60", VA = "0x180787560")]
		public void KMGOFJHMOME(Entity FLADPKIONGF, in Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7843F0", Offset = "0x7829F0", VA = "0x1807843F0")]
		public void BNFIHNKLDEK(Entity FLADPKIONGF, in Matrix4x4 JCKHCLEBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x785D10", Offset = "0x784310", VA = "0x180785D10", Slot = "5")]
		public void HBLOPJIPEGM(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x786EF0", Offset = "0x7854F0", VA = "0x180786EF0", Slot = "6")]
		public Vector3 KDGMFLJDDAN(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x787E40", Offset = "0x786440", VA = "0x180787E40", Slot = "7")]
		public void NDDKBIILBIG(Entity FLADPKIONGF, Quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x786CB0", Offset = "0x7852B0", VA = "0x180786CB0", Slot = "8")]
		public Quaternion JCHPFNJLGAB(Entity FLADPKIONGF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x788B90", Offset = "0x787190", VA = "0x180788B90", Slot = "12")]
		public void PKHBLFKPBPM(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7845B0", Offset = "0x782BB0", VA = "0x1807845B0", Slot = "11")]
		public Vector3 CDADONFEOKD(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x785850", Offset = "0x783E50", VA = "0x180785850")]
		public void ELEOAPFDCDK(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x787CB0", Offset = "0x7862B0", VA = "0x180787CB0")]
		private Vector3 MJFCAFIOCKN(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x788050", Offset = "0x786650", VA = "0x180788050", Slot = "14")]
		public float NIFMKHDJJNK(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x785130", Offset = "0x783730", VA = "0x180785130", Slot = "13")]
		public void EBICDAKJIHC(Entity FLADPKIONGF, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7840E0", Offset = "0x7826E0", VA = "0x1807840E0")]
		private float BDLFDEJMOEI(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x783F30", Offset = "0x782530", VA = "0x180783F30")]
		public void AOJBKBIJFFO(Entity FLADPKIONGF, float FJLPNOBMKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x788390", Offset = "0x786990", VA = "0x180788390", Slot = "16")]
		public Vector3 OGKDGADDFJE(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x785500", Offset = "0x783B00", VA = "0x180785500", Slot = "15")]
		public void EGDFIAJIHEE(Entity FLADPKIONGF, Vector3 DNNHJOLMOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x787690", Offset = "0x785C90", VA = "0x180787690")]
		private Vector3 KNJGMJGFFPK(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x785430", Offset = "0x783A30", VA = "0x180785430")]
		public void EFBJHPAJOFD(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7881E0", Offset = "0x7867E0", VA = "0x1807881E0")]
		[Conditional("DEBUG_BUILD")]
		private void NOLIGALHMEP(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7856F0", Offset = "0x783CF0", VA = "0x1807856F0", Slot = "36")]
		public void ELAFJFCHKFH(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x784800", Offset = "0x782E00", VA = "0x180784800", Slot = "9")]
		public void CJPIJADJPPB(Entity FLADPKIONGF, out Vector3 EINGNKDKDHC, out Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x784DD0", Offset = "0x7833D0", VA = "0x180784DD0", Slot = "10")]
		public void DJDMGHIFBFF(Entity FLADPKIONGF, out Vector3 EINGNKDKDHC, out Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7841D0", Offset = "0x7827D0", VA = "0x1807841D0", Slot = "37")]
		public void BIKEMMKHJFE(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7888B0", Offset = "0x786EB0", VA = "0x1807888B0")]
		public void PFJBAFAOHEN(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x785A10", Offset = "0x784010", VA = "0x180785A10", Slot = "17")]
		public void EPCLMLHFNOF(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x783C90", Offset = "0x782290", VA = "0x180783C90", Slot = "18")]
		public Vector3 AIOEBCNOFCP(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x787320", Offset = "0x785920", VA = "0x180787320", Slot = "19")]
		public void KJOKAKCLOLD(Entity FLADPKIONGF, Quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7880F0", Offset = "0x7866F0", VA = "0x1807880F0", Slot = "20")]
		public Quaternion NKHCLDCNKGM(Entity FLADPKIONGF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x785E30", Offset = "0x784430", VA = "0x180785E30", Slot = "22")]
		public void HEICAIGEECI(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x786A80", Offset = "0x785080", VA = "0x180786A80", Slot = "21")]
		public Vector3 IBHNOLBJBOE(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x787000", Offset = "0x785600", VA = "0x180787000", Slot = "23")]
		public void KGHJMEPBGCC(Entity FLADPKIONGF, float KFJIEPBCIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x783FC0", Offset = "0x7825C0", VA = "0x180783FC0", Slot = "24")]
		public float BCNKCAFHEPN(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7877C0", Offset = "0x785DC0", VA = "0x1807877C0", Slot = "25")]
		public void LFKDFIGLAEM(Entity FLADPKIONGF, Vector3 KGCCAPLOJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x786B70", Offset = "0x785170", VA = "0x180786B70", Slot = "26")]
		public Vector3 IONBKODNGEC(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x786290", Offset = "0x784890", VA = "0x180786290", Slot = "31")]
		public void HFIGFKMINCI(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x786930", Offset = "0x784F30", VA = "0x180786930")]
		private NIALADIPDNC HMPGNLACACA(Transform HJLACGOIJCA)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x784F00", Offset = "0x783500", VA = "0x180784F00")]
		private static TransformEntity DOJDFDGEPHF(HLEPLICHNKK MCLMFJEAHEC, GameObject POFNLMLLLOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7858F0", Offset = "0x783EF0", VA = "0x1807858F0", Slot = "32")]
		public void EOHJCEFBFKJ(Entity FLADPKIONGF, Entity KOEBMFNDCDN, Entity EBIGGMLCEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x782D80", VA = "0x180784780")]
		private MKNCPKODDIK CJPIJADJPPB(Entity FLADPKIONGF)
		{
			return default(MKNCPKODDIK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x784CF0", Offset = "0x7832F0", VA = "0x180784CF0")]
		private bool CPJAIDCOIFN(Entity FLADPKIONGF, out Entity LFAIGCEGCPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x787170", Offset = "0x785770", VA = "0x180787170")]
		private void KJDPOKHPMNC(Entity FLADPKIONGF, out Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x784950", Offset = "0x782F50", VA = "0x180784950")]
		private void CNNIOHOCPAO(Entity FLADPKIONGF, out Matrix4x4 JCKHCLEBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x788A70", Offset = "0x787070", VA = "0x180788A70", Slot = "28")]
		private void PKDJHPLNMHO(Entity FLADPKIONGF, in Matrix4x4 MIAMIGJGGEO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DHKIICMHACJ(typeof(CMFELJNEEND), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
internal sealed class CMFELJNEEND : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CJONPMHNDBN]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x38F8BC0", Offset = "0x38F71C0", VA = "0x1838F8BC0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x38F8B50", Offset = "0x38F7150", VA = "0x1838F8B50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CMFELJNEEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(IABHAOPOIBC), new string[] { })]
public class IABHAOPOIBC
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct LGDOIINGDIO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly IABHAOPOIBC LFAIGCEGCPL;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xDF8C20", Offset = "0xDF7220", VA = "0x180DF8C20")]
		public LGDOIINGDIO(IABHAOPOIBC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xDF8C00", Offset = "0xDF7200", VA = "0x180DF8C00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int GIJBKGJDGML;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool CINCPAPMNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1E77250", Offset = "0x1E75850", VA = "0x181E77250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action ODBBIIKIBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC41E0", Offset = "0x3BC27E0", VA = "0x183BC41E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4120", Offset = "0x3BC2720", VA = "0x183BC4120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4280", Offset = "0x3BC2880", VA = "0x183BC4280")]
	public LGDOIINGDIO OJJLAJPCHGJ()
	{
		return default(LGDOIINGDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xAA3E30", Offset = "0xAA2430", VA = "0x180AA3E30")]
	public void NBPFDKDKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BC41C0", Offset = "0x3BC27C0", VA = "0x183BC41C0")]
	public void EGPDAHMJJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IABHAOPOIBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DHKIICMHACJ(typeof(AMBDMGDKIKJ), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
public class AMBDMGDKIKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int GIJBKGJDGML;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xAF95D0", Offset = "0xAF7BD0", VA = "0x180AF95D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xAF9660", Offset = "0xAF7C60", VA = "0x180AF9660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AMBDMGDKIKJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DHKIICMHACJ(typeof(EnableComponentSystemsInScope), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	public class EnableComponentSystemsInScope : GOJCOOFCPOI, FHBPEIGBJBL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct FDJJCJPIKAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> IKGOBLILHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> BGLJHEFMNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> NFECJNKAEOB;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xDF46C0", Offset = "0xDF2CC0", VA = "0x180DF46C0")]
			public FDJJCJPIKAL(NativeArray<int> IKGOBLILHLB, NativeArray<int> BGLJHEFMNHL, Dictionary<ComponentSystemBase, int> NFECJNKAEOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xDF4440", Offset = "0xDF2A40", VA = "0x180DF4440")]
			public void ACGCHNEICPN(IEnumerable<ComponentSystemBase> FLDPOGAHGIJ, HIFIKBEHMNK BDMBKCJNJKD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class JMCBLINEGFB : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public JMCBLINEGFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xDF7A30", Offset = "0xDF6030", VA = "0x180DF7A30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xDF7C00", Offset = "0xDF6200", VA = "0x180DF7C00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xDF7B50", Offset = "0xDF6150", VA = "0x180DF7B50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xDF7B50", Offset = "0xDF6150", VA = "0x180DF7B50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const HIFIKBEHMNK BONDPHFNALG = HIFIKBEHMNK.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FGGEJMNNOEE PKKHACOCACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private PFKGIHKPIGG GOCENLCAMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> PFJIBANCAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> OOHKAPAPBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int AJGHIJIKOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HIFIKBEHMNK MABHJFGJDFG;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB41E0", Offset = "0x3BB27E0", VA = "0x183BB41E0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3720", Offset = "0x3BB1D20", VA = "0x183BB3720", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3810", Offset = "0x3BB1E10", VA = "0x183BB3810")]
		[IteratorStateMachine(typeof(JMCBLINEGFB))]
		private IEnumerable<ComponentSystemBase> EOAGABPEMPK(int LJECKBCMELA, int EAJAFIHJLHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB38A0", Offset = "0x3BB1EA0", VA = "0x183BB38A0", Slot = "5")]
		public void GAAJOMGCPID(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB38A0", Offset = "0x3BB1EA0", VA = "0x183BB38A0")]
		private void PAMEBPJLKNP(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4310", Offset = "0x3BB2910", VA = "0x183BB4310")]
		public void PAMEBPJLKNP(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3310", Offset = "0x3BB1910", VA = "0x183BB3310")]
		private void AHJLPFNAOAN(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3690", Offset = "0x3BB1C90", VA = "0x183BB3690")]
		private void BMEMHCHOGGH(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB40C0", Offset = "0x3BB26C0", VA = "0x183BB40C0")]
		private void LKLFNONKGAM(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4120", Offset = "0x3BB2720", VA = "0x183BB4120")]
		private void MBDNHAAPLOO(int LJECKBCMELA, int EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3920", Offset = "0x3BB1F20", VA = "0x183BB3920")]
		private void GDKKLJBLGGP(int LJECKBCMELA, int EAJAFIHJLHG, bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4410", Offset = "0x3BB2A10", VA = "0x183BB4410")]
		private int PCGKDBDOOHK(HIFIKBEHMNK ILFGBJGNEIK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3B30", Offset = "0x3BB2130", VA = "0x183BB3B30")]
		private bool INADPGGEOHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB35A0", Offset = "0x3BB1BA0", VA = "0x183BB35A0")]
		private Dictionary<ComponentSystemBase, int> BAGEAJBKNKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3A40", Offset = "0x3BB2040", VA = "0x183BB3A40")]
		private void IBFPAHLGIDA(NativeArray<int> IKGOBLILHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3A80", Offset = "0x3BB2080", VA = "0x183BB3A80")]
		private void ICNIAPMCFCB(NativeArray<int> BGLJHEFMNHL, NativeArray<int> IKGOBLILHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB37B0", Offset = "0x3BB1DB0", VA = "0x183BB37B0")]
		private static HIFIKBEHMNK EGDJFGMCKMN(Type MCLMFJEAHEC, HIFIKBEHMNK BKMGNMEJDHA)
		{
			return default(HIFIKBEHMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3BB44C0", Offset = "0x3BB2AC0", VA = "0x183BB44C0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB39E0", Offset = "0x3BB1FE0", VA = "0x183BB39E0")]
		[CompilerGenerated]
		private void IACOLAKIBEA(GOJCOOFCPOI LDEKBPOBLDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB42B0", Offset = "0x3BB28B0", VA = "0x183BB42B0")]
		[CompilerGenerated]
		private void OEGHPEOLDBB(GKFAMMKGENJ LDEKBPOBLDP)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[DAINLFLPADL(OHEDAGNNHJA.WorldService)]
	[DHKIICMHACJ(typeof(KDGBBCMLLMM), new string[] { })]
	public class TickService : GOJCOOFCPOI, KDGBBCMLLMM
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker LMCADLOIOEC;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker KKGHACHJFCD;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker GLHIHNMHFCH;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker OOEIHKKHGMK;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker IEHJGIGGFCP;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker KABJLOHIKOI;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker APKDLCFNJBL;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker GFCJGEBFHOF;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker IGAMIDAJKOD;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker HKFMNNAPOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[CJONPMHNDBN]
		private CPFCFGLKHDP PLNODCMOLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[CJONPMHNDBN]
		private ACADFKAKLNJ PBCABMOPBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[CJONPMHNDBN]
		private TransformOwnershipPhase KHNODNCAALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[CJONPMHNDBN]
		private TimeService MNHJICLMCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private DAOJGNOGCID KHDPJJEDHOA;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool COOGEBMAHIK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x781FF0", Offset = "0x7805F0", VA = "0x180781FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool OOKGKOOKPPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x7826A0", Offset = "0x780CA0", VA = "0x1807826A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool OMKFJBGCHBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x781FF0", Offset = "0x7805F0", VA = "0x180781FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool CMIEMBCACJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x781FF0", Offset = "0x7805F0", VA = "0x180781FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x782EF0", Offset = "0x7814F0", VA = "0x180782EF0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x782060", Offset = "0x780660", VA = "0x180782060", Slot = "14")]
		public void BMJJOILPNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x782740", Offset = "0x780D40", VA = "0x180782740", Slot = "15")]
		public void JAFIMFDGMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7822D0", Offset = "0x7808D0", VA = "0x1807822D0", Slot = "5")]
		public void GJDAPNKJCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x781E70", Offset = "0x780470", VA = "0x180781E70", Slot = "6")]
		public void ABMMBMMDKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x782930", Offset = "0x780F30", VA = "0x180782930", Slot = "7")]
		public void KELDCKEFIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x782520", Offset = "0x780B20", VA = "0x180782520", Slot = "8")]
		public void GNFDCHIIGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7823A0", Offset = "0x7809A0", VA = "0x1807823A0", Slot = "9")]
		public void GMPPMOEBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x782AB0", Offset = "0x7810B0", VA = "0x180782AB0", Slot = "10")]
		public void KJPCDHNNHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x782860", Offset = "0x780E60", VA = "0x180782860", Slot = "11")]
		public void JKHCOBLFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
		public void DDONAPIJHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x782180", Offset = "0x780780", VA = "0x180782180", Slot = "12")]
		public void DCGLPEBKLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[DAINLFLPADL(OHEDAGNNHJA.WorldService)]
	[DHKIICMHACJ(typeof(LEDNJPMFMJI), new string[] { })]
	public class WorldService : LEDNJPMFMJI, IDisposable, BGDEOEAAJCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DAOJGNOGCID KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public DAOJGNOGCID CMJHCGAKNHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public NNAMEJEONOI MLIEHBECBGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x790E60", Offset = "0x78F460", VA = "0x180790E60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x7911E0", Offset = "0x78F7E0", VA = "0x1807911E0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7910D0", Offset = "0x78F6D0", VA = "0x1807910D0", Slot = "10")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x790D50", Offset = "0x78F350", VA = "0x180790D50")]
		private void CBFHJGEFJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x790EA0", Offset = "0x78F4A0", VA = "0x180790EA0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x790E80", Offset = "0x78F480", VA = "0x180790E80", Slot = "8")]
		public ComponentSystemBase CLIENKFCHHO(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DHKIICMHACJ(typeof(MAKFOFFGOPC), new string[] { })]
public sealed class DPOPHIADMAB : MAKFOFFGOPC, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HPHGJPKDAFB : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xDF7110", Offset = "0xDF5710", VA = "0x180DF7110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x776EB0", Offset = "0x7754B0", VA = "0x180776EB0")]
		[DebuggerHidden]
		public HPHGJPKDAFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xDF6E00", Offset = "0xDF5400", VA = "0x180DF6E00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xDF70D0", Offset = "0xDF56D0", VA = "0x180DF70D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xDF7030", Offset = "0xDF5630", VA = "0x180DF7030", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xDF7030", Offset = "0xDF5630", VA = "0x180DF7030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[CJONPMHNDBN]
	private GIHCPFBMAPF KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly BBBICGHCCGN DPCPPKFAJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, LEMCOGLIKLN> AMMMFHGINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, NPKIDEECJBB> HKLAOMBMGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<MIKODHFFJMF> MEMFALIBABJ;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public NPKIDEECJBB PBGMDEOFNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x390BEC0", Offset = "0x390A4C0", VA = "0x18390BEC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<MIKODHFFJMF> GIFLGPFGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x390C270", Offset = "0x390A870", VA = "0x18390C270", Slot = "8")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x390B450", Offset = "0x3909A50", VA = "0x18390B450", Slot = "9")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x390BBE0", Offset = "0x390A1E0", VA = "0x18390BBE0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x390BC70", Offset = "0x390A270", VA = "0x18390BC70", Slot = "6")]
	public bool FKPKMMIGAAD(MIKODHFFJMF LNOIPGJELOP, out NPKIDEECJBB NABGGPANDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x390B570", Offset = "0x3909B70", VA = "0x18390B570")]
	private void COHIMCKKAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x390BF20", Offset = "0x390A520", VA = "0x18390BF20")]
	private void IHEPLGCCFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x390B3F0", Offset = "0x39099F0", VA = "0x18390B3F0")]
	private LEMCOGLIKLN BDBIALKADMG(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x390BEC0", Offset = "0x390A4C0", VA = "0x18390BEC0")]
	private LEMCOGLIKLN IADPNBBBAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x390B970", Offset = "0x3909F70", VA = "0x18390B970")]
	private LEMCOGLIKLN DBLJNEBMLKO(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x390C110", Offset = "0x390A710", VA = "0x18390C110")]
	private LEMCOGLIKLN MGEKILGKJKJ(string GFBIJELPOGE, string HKLDIENGNNB, [Optional] LEMCOGLIKLN FMOHFMENOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x390BD00", Offset = "0x390A300", VA = "0x18390BD00")]
	[IteratorStateMachine(typeof(HPHGJPKDAFB))]
	private IEnumerable<(string, string)> GFFIFLNNLEL(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x390C220", Offset = "0x390A820", VA = "0x18390C220")]
	private bool MMILLIMCGHL(MIKODHFFJMF LNOIPGJELOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x390BD70", Offset = "0x390A370", VA = "0x18390BD70")]
	private BBBICGHCCGN HBNGOBMDALH(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x390C0C0", Offset = "0x390A6C0", VA = "0x18390C0C0")]
	private BBBICGHCCGN LMPEMGEMLFC(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x390B470", Offset = "0x3909A70", VA = "0x18390B470")]
	private BBBICGHCCGN CKBBDJKHHPB(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A45BD0", Offset = "0x2A441D0", VA = "0x182A45BD0")]
	private T GOJGMKLOOCG<T>(MIKODHFFJMF LNOIPGJELOP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x390C360", Offset = "0x390A960", VA = "0x18390C360")]
	private FieldInfo PECCACIBDOK(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x390C440", Offset = "0x390AA40", VA = "0x18390C440")]
	public DPOPHIADMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x390C2D0", Offset = "0x390A8D0", VA = "0x18390C2D0")]
	[CompilerGenerated]
	private int NPABKHKELDI(MIKODHFFJMF IKAMJBDPPHG, MIKODHFFJMF LKLEFAIICIC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class LEMCOGLIKLN : NPKIDEECJBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string CJFIHPLOADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly LEMCOGLIKLN FMOHFMENOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<LEMCOGLIKLN> DFJHJNDKAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<MIKODHFFJMF> KECMGAIBBMH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string CEMABJIMANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NPKIDEECJBB CALMODKDDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<NPKIDEECJBB> NPBDACIGPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<MIKODHFFJMF> DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC590", Offset = "0x3BCAB90", VA = "0x183BCC590")]
	public LEMCOGLIKLN(string NBODBMLPNJA, LEMCOGLIKLN LFAIGCEGCPL)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[DAINLFLPADL(OHEDAGNNHJA.History)]
	[DHKIICMHACJ(typeof(LAMNHLNDGKO), new string[] { })]
	[CMEMHKMDBHK(typeof(HistoryService))]
	public class HistoryService : GOJCOOFCPOI, IDisposable, LAMNHLNDGKO
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum DDJFFLLOIIE
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct IMLHLFNBEOK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly DDJFFLLOIIE FOGNEBHLIHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService AGMOENMHCDB;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xDF74E0", Offset = "0xDF5AE0", VA = "0x180DF74E0")]
			public IMLHLFNBEOK(HistoryService AGMOENMHCDB, bool KDKNGPBBMHK, uint AJGHIJIKOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xDF74B0", Offset = "0xDF5AB0", VA = "0x180DF74B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class FIIPMPGFJKA
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct AAPPFCOMJNA : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly FIIPMPGFJKA LBGOBMKAOKK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool OIAKBINAPEH;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0xDF1290", Offset = "0xDEF890", VA = "0x180DF1290")]
				public AAPPFCOMJNA(FIIPMPGFJKA LBGOBMKAOKK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xDF1260", Offset = "0xDEF860", VA = "0x180DF1260", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct PEIDEGJNMMJ : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly FIIPMPGFJKA LBGOBMKAOKK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool OIAKBINAPEH;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0xDFC6B0", Offset = "0xDFACB0", VA = "0x180DFC6B0")]
				public PEIDEGJNMMJ(FIIPMPGFJKA LBGOBMKAOKK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xDF1260", Offset = "0xDEF860", VA = "0x180DF1260", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService JLIPNAINFPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool IKFPABDJEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int AALJIBBBHLA;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xDF4EE0", Offset = "0xDF34E0", VA = "0x180DF4EE0")]
			public FIIPMPGFJKA(HistoryService JLIPNAINFPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xDF4E60", Offset = "0xDF3460", VA = "0x180DF4E60")]
			public bool GBHGPCNHJPA(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xDF4E90", Offset = "0xDF3490", VA = "0x180DF4E90")]
			public PEIDEGJNMMJ HEPMAAKPJDK()
			{
				return default(PEIDEGJNMMJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xDF4E10", Offset = "0xDF3410", VA = "0x180DF4E10")]
			public AAPPFCOMJNA FBOPCIJHBAD()
			{
				return default(AAPPFCOMJNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class ILCAMOANIKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public ILCAMOANIKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xDF7450", Offset = "0xDF5A50", VA = "0x180DF7450")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class BAOMDDGJADN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public BAOMDDGJADN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xDF21F0", Offset = "0xDF07F0", VA = "0x180DF21F0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class DNPDOPELOBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public DNPDOPELOBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xDF3830", Offset = "0xDF1E30", VA = "0x180DF3830")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction BFKEEEPBPFF;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction HMMAAEMNGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private FFIDHHPFIFE CBFDEKGBMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer OLLFOFPBKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer BBLNHKAAMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private GINDCKHCNIE BGALHJDHLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase KHNODNCAALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService NKLFBFIOEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MADKAIDKJMP HMHKKKAECHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DDJFFLLOIIE OKKNLCMIMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private FIIPMPGFJKA LBGOBMKAOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private CBEPKLBIIOB EPFNIEDFLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private OMKGMEPBKLL BGOMBAOCODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private HDFAPEIIIAK DBLKKJIKJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete MCJOOKMJDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint CBFLMHBENFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint OHPGPOCFADF;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private FIIPMPGFJKA JNOHBKDBDDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool MGMNDKMGNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x3BC3AF0", Offset = "0x3BC20F0", VA = "0x183BC3AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool ICJNLOGIOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x3BC1A60", Offset = "0x3BC0060", VA = "0x183BC1A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool IGJFEPOGBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x3BC2830", Offset = "0x3BC0E30", VA = "0x183BC2830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int GDEPMBODMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3BC2B50", Offset = "0x3BC1150", VA = "0x183BC2B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int JBOAJIEGIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3BC2EB0", Offset = "0x3BC14B0", VA = "0x183BC2EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool CBDCKJEFGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3BC3BC0", Offset = "0x3BC21C0", VA = "0x183BC3BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool MOAFIODJNNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x3BC1B00", Offset = "0x3BC0100", VA = "0x183BC1B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool JCAKAODLKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xF61050", Offset = "0xF5F650", VA = "0x180F61050", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xF61080", Offset = "0xF5F680", VA = "0x180F61080", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer GADKKOIPBOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3BC3770", Offset = "0x3BC1D70", VA = "0x183BC3770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action GNGPOMCBPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x3BC3C90", Offset = "0x3BC2290", VA = "0x183BC3C90", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x3BC25E0", Offset = "0x3BC0BE0", VA = "0x183BC25E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action ILMBKOICKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3BC2540", Offset = "0x3BC0B40", VA = "0x183BC2540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3BC1ED0", Offset = "0x3BC04D0", VA = "0x183BC1ED0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3200", Offset = "0x3BC1800", VA = "0x183BC3200", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC22A0", Offset = "0x3BC08A0", VA = "0x183BC22A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2130", Offset = "0x3BC0730", VA = "0x183BC2130")]
		private void DPNIBBGOAIP(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2680", Offset = "0x3BC0C80", VA = "0x183BC2680")]
		private void FLKNFHNBIHD(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL FCHBILJGJHO, COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2ED0", Offset = "0x3BC14D0", VA = "0x183BC2ED0")]
		private void KDPELIFJFIF(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1F70", Offset = "0x3BC0570", VA = "0x183BC1F70", Slot = "14")]
		public IDisposable CPCMKLOAMFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3BC20D0", Offset = "0x3BC06D0", VA = "0x183BC20D0", Slot = "9")]
		public IDisposable DKPMBCJBPBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3BD0", Offset = "0x3BC21D0", VA = "0x183BC3BD0", Slot = "6")]
		public UndoAction OMDPLCDMOMN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3BC38D0", Offset = "0x3BC1ED0", VA = "0x183BC38D0", Slot = "15")]
		public RedoAction ODHGEPEIALH()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3DE0", Offset = "0x3BC23E0", VA = "0x183BC3DE0", Slot = "16")]
		public UndoAction PHFLMIPKPIP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3990", Offset = "0x3BC1F90", VA = "0x183BC3990", Slot = "7")]
		public RedoAction ODHGEPEIALH(UndoAction BIPEBBMCHLH)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3EA0", Offset = "0x3BC24A0", VA = "0x183BC3EA0", Slot = "8")]
		public UndoAction PHFLMIPKPIP(RedoAction BIPEBBMCHLH)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3D50", Offset = "0x3BC2350", VA = "0x183BC3D50")]
		public bool PEAMEGHCLBA(IKGNDAIPPJE LCBBHNAFOCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3D90", Offset = "0x3BC2390", VA = "0x183BC3D90", Slot = "17")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2860", Offset = "0x3BC0E60", VA = "0x183BC2860")]
		public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC26A0", Offset = "0x3BC0CA0", VA = "0x183BC26A0")]
		public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL MAEOIACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1B10", Offset = "0x3BC0110", VA = "0x183BC1B10")]
		public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3AB0", Offset = "0x3BC20B0", VA = "0x183BC3AB0")]
		private void OIGMFBFNPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC27F0", Offset = "0x3BC0DF0", VA = "0x183BC27F0")]
		private void GPPBMJODEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC27D0", Offset = "0x3BC0DD0", VA = "0x183BC27D0")]
		private void GOGCOAKNLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1FD0", Offset = "0x3BC05D0", VA = "0x183BC1FD0")]
		private GAEJJDCGBDA DEKCFALNOEO()
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2B30", Offset = "0x3BC1130", VA = "0x183BC2B30")]
		private uint JANDDMHGLBN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3D30", Offset = "0x3BC2330", VA = "0x183BC3D30")]
		private bool PCPAGDAMGEM(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1A40", Offset = "0x3BC0040", VA = "0x183BC1A40")]
		private bool AOPDBEHEHAE(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3170", Offset = "0x3BC1770", VA = "0x183BC3170")]
		private RedoAction KODCJKCMFJB(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3B60", Offset = "0x3BC2160", VA = "0x183BC3B60")]
		private UndoAction OKEIBFJJIAI(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2BF0", Offset = "0x3BC11F0", VA = "0x183BC2BF0")]
		private GAEJJDCGBDA JNBOBMIHBHF(GAEJJDCGBDA PBOHOIMMGFG, ActionBuffer JDEPMOCPCPK, bool KDKNGPBBMHK)
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1C70", Offset = "0x3BC0270", VA = "0x183BC1C70")]
		private void BKIGBHECLPI(Action PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x32D7920", Offset = "0x32D5F20", VA = "0x1832D7920")]
		private T BKIGBHECLPI<T>(Func<T> PLKNOODMMGB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3BC31D0", Offset = "0x3BC17D0", VA = "0x183BC31D0")]
		private IMLHLFNBEOK LIBIEENOEPO(bool KDKNGPBBMHK, uint AJGHIJIKOBE)
		{
			return default(IMLHLFNBEOK);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC40A0", Offset = "0x3BC26A0", VA = "0x183BC40A0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3780", Offset = "0x3BC1D80", VA = "0x183BC3780")]
		[CompilerGenerated]
		private UndoAction ODBAJMMAOFI()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1D50", Offset = "0x3BC0350", VA = "0x183BC1D50")]
		[CompilerGenerated]
		private RedoAction CBMGMLAMKFL()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC29D0", Offset = "0x3BC0FD0", VA = "0x183BC29D0")]
		[CompilerGenerated]
		private UndoAction ICABBMLGBGI()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IKHAGHAKDMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> HEONDDEAIBL;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public IKHAGHAKDMA(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3BC57A0", Offset = "0x3BC3DA0", VA = "0x183BC57A0")]
	public static IKHAGHAKDMA DGKBAOBECFH(NativeArray<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T NAKEDDIGNIK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> ELDHGGNOKEN<T>(int JKABHKIANJL, Allocator GGLOKAHPEPM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> BHJECCKGPAO<T>(Allocator GGLOKAHPEPM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HHKIHGDAHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> HEONDDEAIBL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public HHKIHGDAHAF(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3BC17E0", Offset = "0x3BBFDE0", VA = "0x183BC17E0")]
	public static HHKIHGDAHAF DGKBAOBECFH(NativeArray<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x32D29A0", Offset = "0x32D0FA0", VA = "0x1832D29A0")]
	public T NAKEDDIGNIK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> ELDHGGNOKEN<T>(int JKABHKIANJL, Allocator GGLOKAHPEPM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GJHKCIEBHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> HEONDDEAIBL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public GJHKCIEBHGJ(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0070", Offset = "0x3BBE670", VA = "0x183BC0070")]
	public static GJHKCIEBHGJ DGKBAOBECFH(NativeArray<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x32C1BD0", Offset = "0x32C01D0", VA = "0x1832C1BD0")]
	public void FJHFGNBAGIM<T>(in T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x32C1AD0", Offset = "0x32C00D0", VA = "0x1832C1AD0")]
	public void ENIABLJECDO<T>(NativeArray<T> EIAMEKHGGAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void KECHFCADCGA<T>(NativeArray<T> MAKFNMHIJIF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ODLFMHHKIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3883AF0", Offset = "0x38820F0", VA = "0x183883AF0")]
	public static Span<byte> MNFIMGFCCFG(this NativeArray<byte> HEONDDEAIBL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3883970", Offset = "0x3881F70", VA = "0x183883970")]
	public static ReadOnlySpan<byte> MCPMGKMNEIO(this NativeArray<byte> HEONDDEAIBL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3883B80", Offset = "0x3882180", VA = "0x183883B80")]
	public static NativeArray<byte> NBJGADHPALO(this NativeArray<byte> HEONDDEAIBL, int LJECKBCMELA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x38838F0", Offset = "0x3881EF0", VA = "0x1838838F0")]
	public static NativeArray<byte> LMCGEKMLPKM(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4099B60", Offset = "0x4098160", VA = "0x184099B60")]
	public static NativeArray<byte> LMCGEKMLPKM<T>(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3883880", Offset = "0x3881E80", VA = "0x183883880")]
	public static NativeArray<byte> LMBBJAKCDCD(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x4099B00", Offset = "0x4098100", VA = "0x184099B00")]
	public static NativeArray<byte> LMBBJAKCDCD<T>(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3883800", Offset = "0x3881E00", VA = "0x183883800")]
	public static NativeArray<byte> HBHGAIKEDKO(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x40985C0", Offset = "0x4096BC0", VA = "0x1840985C0")]
	public static NativeArray<byte> HBHGAIKEDKO<T>(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CEKAIILGIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x192F910", Offset = "0x192DF10", VA = "0x18192F910")]
	public CEKAIILGIPJ(NativeList<byte> ACLENHAHHHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x38F7DD0", Offset = "0x38F63D0", VA = "0x1838F7DD0")]
	public static CEKAIILGIPJ DGKBAOBECFH(NativeList<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void FJHFGNBAGIM<T>(in T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void ENIABLJECDO<T>(NativeArray<T> MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void KECHFCADCGA<T>(NativeArray<T> MAKFNMHIJIF) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.PropertyChanges)]
	public class PropertyChangeNetworkRouter : BGDEOEAAJCH, GOJCOOFCPOI, IDBCBPLBJEI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[CJONPMHNDBN]
		private PHMHFECEICG IEEJJNDPOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[CJONPMHNDBN]
		private NHGGIKDMDCJ KECMGAIBBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[CJONPMHNDBN]
		private IABHAOPOIBC LBNPIJBHPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[CJONPMHNDBN]
		private PropertyChangeRouterService NKLFBFIOEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private FFIDHHPFIFE OBFMOAOGODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private KNMMJEOEOPK IMBILOOKOPL;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public FFIDHHPFIFE DCKHHAHJGDI
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x389BC20", Offset = "0x389A220", VA = "0x18389BC20")]
		public FFIDHHPFIFE.IBIHKNHKNLC OJJLAJPCHGJ()
		{
			return default(FFIDHHPFIFE.IBIHKNHKNLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x389B4E0", Offset = "0x3899AE0", VA = "0x18389B4E0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x389B8E0", Offset = "0x3899EE0", VA = "0x18389B8E0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x389B110", Offset = "0x3899710", VA = "0x18389B110", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x389BC40", Offset = "0x389A240", VA = "0x18389BC40")]
		public void OMDPLCDMOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x389BD50", Offset = "0x389A350", VA = "0x18389BD50")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x389B890", Offset = "0x3899E90", VA = "0x18389B890")]
		private void LOPGBJIBCBH(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x389B350", Offset = "0x3899950", VA = "0x18389B350")]
		private void EOMIOCMCOPG(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL FCHBILJGJHO, COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x389AFF0", Offset = "0x38995F0", VA = "0x18389AFF0")]
		private void AHFFBOOJKLD(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x389B540", Offset = "0x3899B40", VA = "0x18389B540")]
		private void KHJHKCELOIP(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x389B390", Offset = "0x3899990", VA = "0x18389B390")]
		private void GFADCGMPEFP(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x389BB60", Offset = "0x389A160", VA = "0x18389BB60")]
		private void ODCOOJHGFBM(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x3899EC0", VA = "0x18389B8C0")]
		private void NBPFDKDKAJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x389B330", Offset = "0x3899930", VA = "0x18389B330")]
		private void EGPDAHMJJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x389B020", Offset = "0x3899620", VA = "0x18389B020")]
		private void CIGGCBOHBIM(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x45C8C80", Offset = "0x45C7280", VA = "0x1845C8C80", Slot = "6")]
		private void ILNFOPMDOAJ<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, object JOOJGLPIMBB) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[DAINLFLPADL(OHEDAGNNHJA.History)]
	[DHKIICMHACJ(typeof(PropertyChangeRouterService), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void NKPKEJDOCAJ(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void MGNBLBJBIMJ(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL FCHBILJGJHO, COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void KMEEACCMFPJ(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NKPKEJDOCAJ CBFHJGEFJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public MGNBLBJBIMJ BKLBAJPDACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KMEEACCMFPJ GGPEMOPMMCE;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x389BE50", Offset = "0x389A450", VA = "0x18389BE50")]
		public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x389BDE0", Offset = "0x389A3E0", VA = "0x18389BDE0")]
		public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL FCHBILJGJHO, in COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x389BDC0", Offset = "0x389A3C0", VA = "0x18389BDC0")]
		public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(DIKPCBBHODH))]
	[DAINLFLPADL(OHEDAGNNHJA.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class DIKPCBBHODH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer DICKNCEHGPP;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int ICNBMEOIEJL
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x775380", Offset = "0x773980", VA = "0x180775380")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public OLJEDHCFLAF[] FIPMHCKCADD
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x7751C0", Offset = "0x7737C0", VA = "0x1807751C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
			public DIKPCBBHODH(ActionBuffer IAIILBKFNKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773890", VA = "0x180775290")]
			[CompilerGenerated]
			private OLJEDHCFLAF JGLBHONHOKH(GAEJJDCGBDA PBOHOIMMGFG)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class OLJEDHCFLAF : IDBCBPLBJEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer DICKNCEHGPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly GAEJJDCGBDA PBOHOIMMGFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(KNMMJEOEOPK, string, object)> GLIGCLJIOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private HHKIHGDAHAF ILDGEJAOOHJ;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int ICNBMEOIEJL
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x778510", Offset = "0x776B10", VA = "0x180778510")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(KNMMJEOEOPK, string, object)> APKKNJBDCIO
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x778560", Offset = "0x776B60", VA = "0x180778560")]
			public OLJEDHCFLAF(ActionBuffer IAIILBKFNKO, GAEJJDCGBDA PBOHOIMMGFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x778410", Offset = "0x776A10", VA = "0x180778410")]
			private string MHCHBKFLKKI(KNMMJEOEOPK IMBILOOKOPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7780D0", Offset = "0x7766D0", VA = "0x1807780D0")]
			private void IFEPEMKMGAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x38A0FB0", Offset = "0x389F5B0", VA = "0x1838A0FB0", Slot = "4")]
			public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, [Optional] object JOOJGLPIMBB) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> BLEPFEFKNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<GAEJJDCGBDA> FGKFMELLJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly CBCEJNIPFII ODDJMINFJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly CBEPKLBIIOB EPFNIEDFLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly NHGGIKDMDCJ KECMGAIBBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool MBIKHONBHHM;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public LBOOECEHGKF BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x38F1840", Offset = "0x38EFE40", VA = "0x1838F1840")]
			get
			{
				return default(LBOOECEHGKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x38F13F0", Offset = "0x38EF9F0", VA = "0x1838F13F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x38F1960", Offset = "0x38EFF60", VA = "0x1838F1960")]
		public ActionBuffer(CBEPKLBIIOB EPFNIEDFLEF, NHGGIKDMDCJ KECMGAIBBMH, bool MBIKHONBHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x38F1880", Offset = "0x38EFE80", VA = "0x1838F1880")]
		public bool PHFBNKNMGCL(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x38F17D0", Offset = "0x38EFDD0", VA = "0x1838F17D0")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x38F15D0", Offset = "0x38EFBD0", VA = "0x1838F15D0")]
		public GAEJJDCGBDA OMDPLCDMOMN(FCHLEGPJOOJ GLIGCLJIOHI, MADKAIDKJMP HMHKKKAECHF, uint ODPIDGFBPMF)
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x38F0C90", Offset = "0x38EF290", VA = "0x1838F0C90")]
		public bool AJGANKIPMJE(uint ODPIDGFBPMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x38F0EA0", Offset = "0x38EF4A0", VA = "0x1838F0EA0")]
		public bool HPMHEMEBDFK(uint ODPIDGFBPMF, out GAEJJDCGBDA BIPEBBMCHLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x38F0D30", Offset = "0x38EF330", VA = "0x1838F0D30")]
		public void FLKDKHMGMMP(GAEJJDCGBDA BIPEBBMCHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x38F1430", Offset = "0x38EFA30", VA = "0x1838F1430")]
		[Conditional("DEBUG_BUILD")]
		private void NLDNGAKCAEK(GAEJJDCGBDA BIPEBBMCHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x38F12E0", Offset = "0x38EF8E0", VA = "0x1838F12E0")]
		private void JNBOBMIHBHF(GAEJJDCGBDA GGNPCMLBMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x38F1090", Offset = "0x38EF690", VA = "0x1838F1090")]
		private void INIIPOKFIPD(HHKIHGDAHAF CBIEEMJACJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x38F1570", Offset = "0x38EFB70", VA = "0x1838F1570")]
		private void OBMECJOPMEL(GAEJJDCGBDA PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x38F1710", Offset = "0x38EFD10", VA = "0x1838F1710")]
		private HHKIHGDAHAF PBAOCLHMPMN(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x38F0CC0", Offset = "0x38EF2C0", VA = "0x1838F0CC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CBCEJNIPFII : IDBCBPLBJEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly CBEPKLBIIOB EPFNIEDFLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly NHGGIKDMDCJ KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private COEEIJJLOPG EHLCJHMJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private HHKIHGDAHAF OBBGCDGAAHA;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x729000", Offset = "0x727600", VA = "0x180729000")]
	public CBCEJNIPFII(CBEPKLBIIOB EPFNIEDFLEF, NHGGIKDMDCJ KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x33B7DA0", Offset = "0x33B63A0", VA = "0x1833B7DA0", Slot = "4")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> AKKPMKJBELG, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x38F7B60", Offset = "0x38F6160", VA = "0x1838F7B60")]
	public void HEIGEPEFDPE(KNMMJEOEOPK IMBILOOKOPL, ref HHKIHGDAHAF CBIEEMJACJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FFIDHHPFIFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct IBIHKNHKNLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly FFIDHHPFIFE LFAIGCEGCPL;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xDF72C0", Offset = "0xDF58C0", VA = "0x180DF72C0")]
		public IBIHKNHKNLC(FFIDHHPFIFE LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xDF72A0", Offset = "0xDF58A0", VA = "0x180DF72A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected FCHLEGPJOOJ GLIGCLJIOHI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FCHLEGPJOOJ APKKNJBDCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB93A0", Offset = "0x3BB79A0", VA = "0x183BB93A0")]
		get
		{
			return default(FCHLEGPJOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool ODJOJHICMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9600", Offset = "0x3BB7C00", VA = "0x183BB9600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9730", Offset = "0x3BB7D30", VA = "0x183BB9730")]
	public FFIDHHPFIFE(FCHLEGPJOOJ.PDMNNKDAAOM CBHAAIPJCPO = FCHLEGPJOOJ.PDMNNKDAAOM.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9720", Offset = "0x3BB7D20", VA = "0x183BB9720")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9530", Offset = "0x3BB7B30", VA = "0x183BB9530")]
	public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BB94D0", Offset = "0x3BB7AD0", VA = "0x183BB94D0")]
	public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BB92E0", Offset = "0x3BB78E0", VA = "0x183BB92E0")]
	public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9610", Offset = "0x3BB7C10", VA = "0x183BB9610")]
	public void NBPFDKDKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BB93F0", Offset = "0x3BB79F0", VA = "0x183BB93F0")]
	public void EGPDAHMJJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB93E0", Offset = "0x3BB79E0", VA = "0x183BB93E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB96F0", Offset = "0x3BB7CF0", VA = "0x183BB96F0")]
	public IBIHKNHKNLC OJJLAJPCHGJ()
	{
		return default(IBIHKNHKNLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KNMMJEOEOPK : IComparable<KNMMJEOEOPK>, IEquatable<KNMMJEOEOPK>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly KNMMJEOEOPK HDJNGGOKGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public COEEIJJLOPG EHLCJHMJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public HDFAPEIIIAK DPEKNLAIHMP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x37BF7F0", Offset = "0x37BDDF0", VA = "0x1837BF7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950")]
	public KNMMJEOEOPK(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC92B0", Offset = "0x3BC78B0", VA = "0x183BC92B0")]
	public void FHDOHDMGJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9130", Offset = "0x3BC7730", VA = "0x183BC9130", Slot = "4")]
	public int CompareTo(KNMMJEOEOPK OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9340", Offset = "0x3BC7940", VA = "0x183BC9340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC91C0", Offset = "0x3BC77C0", VA = "0x183BC91C0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9260", Offset = "0x3BC7860", VA = "0x183BC9260", Slot = "5")]
	public bool Equals(KNMMJEOEOPK OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BC92C0", Offset = "0x3BC78C0", VA = "0x183BC92C0")]
	public static bool GBIPOJBPNDJ(KNMMJEOEOPK OLACFPEGPAG, KNMMJEOEOPK GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9170", Offset = "0x3BC7770", VA = "0x183BC9170")]
	public static bool EOCJAGBGMLJ(KNMMJEOEOPK OLACFPEGPAG, KNMMJEOEOPK GLLCOOLKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9300", Offset = "0x3BC7900", VA = "0x183BC9300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[DAINLFLPADL(OHEDAGNNHJA.History)]
	public class GatherPropertiesForUndelete : KMICCHHKOED
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private CBEPKLBIIOB EPFNIEDFLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private COEEIJJLOPG EHLCJHMJBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService JLIPNAINFPL;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0C30", Offset = "0x3BBF230", VA = "0x183BC0C30")]
		public void IBOAJMMFNDA(COEEIJJLOPG EHLCJHMJBBP, CBEPKLBIIOB EPFNIEDFLEF, HistoryService JLIPNAINFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0D40", Offset = "0x3BBF340", VA = "0x183BC0D40", Slot = "4")]
		private void LBOGHDIEGFM(EOKJCPFONJL LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class OHJMCJHNALO
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3884430", Offset = "0x3882A30", VA = "0x183884430")]
	public static void GFADCGMPEFP(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL, ODPPCAFLFEI LLLOECINIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3884530", Offset = "0x3882B30", VA = "0x183884530")]
	public static void HNLDCCKEKEP(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x38845F0", Offset = "0x3882BF0", VA = "0x1838845F0")]
	public static void ODCOOJHGFBM(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3884380", Offset = "0x3882980", VA = "0x183884380")]
	public static void FLPCLIDMLIB(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3884330", Offset = "0x3882930", VA = "0x183884330")]
	public static ODPPCAFLFEI CDCHHLCFDNB(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
		return default(ODPPCAFLFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x409CA60", Offset = "0x409B060", VA = "0x18409CA60")]
	public static T OHDEGGJMFFP<T>(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x409CA30", Offset = "0x409B030", VA = "0x18409CA30")]
	public static T OHDEGGJMFFP<T>(ref HHKIHGDAHAF JIHCLPECHIB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x38842E0", Offset = "0x38828E0", VA = "0x1838842E0")]
	public static ODPPCAFLFEI CDCHHLCFDNB(ref HHKIHGDAHAF JIHCLPECHIB)
	{
		return default(ODPPCAFLFEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct FCHLEGPJOOJ : IEnumerable<KNMMJEOEOPK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum PDMNNKDAAOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct OEPDEPMEIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly FCHLEGPJOOJ ACLENHAHHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MADKAIDKJMP HMHKKKAECHF;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xDFBCD0", Offset = "0xDFA2D0", VA = "0x180DFBCD0")]
		public OEPDEPMEIGM(FCHLEGPJOOJ ACLENHAHHHH, MADKAIDKJMP HMHKKKAECHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xDFB610", Offset = "0xDF9C10", VA = "0x180DFB610")]
		public void DGIBIKKOBAK(NativeList<byte> FJEDANIIFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xDFBC80", Offset = "0xDFA280", VA = "0x180DFBC80")]
		private void PFAEPEKFIFL(KNMMJEOEOPK IMBILOOKOPL, ref GJHKCIEBHGJ EOBIHPNMGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xDFBBF0", Offset = "0xDFA1F0", VA = "0x180DFBBF0")]
		private void GLJLAONLPFJ(KNMMJEOEOPK IMBILOOKOPL, ref GJHKCIEBHGJ EOBIHPNMGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDFB520", Offset = "0xDF9B20", VA = "0x180DFB520")]
		private NativeArray<byte> DCKEEJEBHAK(NativeList<byte> FJEDANIIFJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xDFB8B0", Offset = "0xDF9EB0", VA = "0x180DFB8B0")]
		private NativeArray<byte> EDNGDFHNMLD(NativeList<byte> FJEDANIIFJL, int JKABHKIANJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xDFB9A0", Offset = "0xDF9FA0", VA = "0x180DFB9A0")]
		private int GJELJKOOHOO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xDFB3C0", Offset = "0xDF99C0", VA = "0x180DFB3C0")]
		private bool AGOCLJBPELB(KNMMJEOEOPK IMBILOOKOPL, out NativeArray<byte> NFIOFBOLADD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct LKHNNDCGJLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> JIHCLPECHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private FCHLEGPJOOJ ACLENHAHHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly KNMMJEOEOPK CELBLIIOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int LJECKBCMELA;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xDF9230", Offset = "0xDF7830", VA = "0x180DF9230")]
		internal LKHNNDCGJLC(FCHLEGPJOOJ ACLENHAHHHH, KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xDF9010", Offset = "0xDF7610", VA = "0x180DF9010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xDF9040", Offset = "0xDF7640", VA = "0x180DF9040")]
		public void EPGBCEBPCKD(NativeArray<byte> MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xDF8FB0", Offset = "0xDF75B0", VA = "0x180DF8FB0")]
		public void BPLHEGOLOIO(NativeArray<byte> MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xDF90A0", Offset = "0xDF76A0", VA = "0x180DF90A0")]
		public void GLJLAONLPFJ(in COGGJKLIPPL MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3532570", Offset = "0x3530B70", VA = "0x183532570")]
		public void GLJLAONLPFJ<T>(T MAKFNMHIJIF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xDF90B0", Offset = "0xDF76B0", VA = "0x180DF90B0")]
		private void LJJPFEFIAKJ(int MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xDF9180", Offset = "0xDF7780", VA = "0x180DF9180")]
		private void LJJPFEFIAKJ(in COGGJKLIPPL MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xDF9120", Offset = "0xDF7720", VA = "0x180DF9120")]
		private unsafe void LJJPFEFIAKJ(void* FLKLBGFLDPE, int JKABHKIANJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xDF9040", Offset = "0xDF7640", VA = "0x180DF9040")]
		private void LJJPFEFIAKJ(NativeArray<byte> EIAMEKHGGAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct FFBMDFNFEOK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private FCHLEGPJOOJ ACLENHAHHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> JIHCLPECHIB;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xDF4AB0", Offset = "0xDF30B0", VA = "0x180DF4AB0")]
		internal FFBMDFNFEOK(FCHLEGPJOOJ ACLENHAHHHH, NativeArray<byte> JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xDF48E0", Offset = "0xDF2EE0", VA = "0x180DF48E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xDF48F0", Offset = "0xDF2EF0", VA = "0x180DF48F0")]
		public NativeArray<byte> ELDHGGNOKEN(int JKABHKIANJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xDF47F0", Offset = "0xDF2DF0", VA = "0x180DF47F0")]
		public NativeArray<byte> BHJECCKGPAO()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x35306E0", Offset = "0x352ECE0", VA = "0x1835306E0")]
		public T NAKEDDIGNIK<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xDF49B0", Offset = "0xDF2FB0", VA = "0x180DF49B0")]
		public void NAKEDDIGNIK(in MMINGLJLPAL MAKFNMHIJIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct FFLHGLNJJJI : IEnumerator<KNMMJEOEOPK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<KNMMJEOEOPK> HEONDDEAIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int EBBLFLFCHFB;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public KNMMJEOEOPK BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xDF4C80", Offset = "0xDF3280", VA = "0x180DF4C80", Slot = "4")]
			get
			{
				return default(KNMMJEOEOPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xDF4C30", Offset = "0xDF3230", VA = "0x180DF4C30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xDF4C70", Offset = "0xDF3270", VA = "0x180DF4C70")]
		internal FFLHGLNJJJI(NativeList<KNMMJEOEOPK> EIAMEKHGGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xDF4AF0", Offset = "0xDF30F0", VA = "0x180DF4AF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xDF4BF0", Offset = "0xDF31F0", VA = "0x180DF4BF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct KHEOBOKGMPC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int FNGCFDKOMKP = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int DHIHKBPECNM = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int CGHIILBDDMF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> JIHCLPECHIB;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool CAJAMKMLDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xDF8230", Offset = "0xDF6830", VA = "0x180DF8230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int CLKAJICIIHF
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xDF81B0", Offset = "0xDF67B0", VA = "0x180DF81B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xDF8270", Offset = "0xDF6870", VA = "0x180DF8270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public PDMNNKDAAOM OLOCEMLLNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xDF8220", Offset = "0xDF6820", VA = "0x180DF8220")]
			get
			{
				return default(PDMNNKDAAOM);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xDF81C0", Offset = "0xDF67C0", VA = "0x180DF81C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool ODJOJHICMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xDF81D0", Offset = "0xDF67D0", VA = "0x180DF81D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xDF8190", Offset = "0xDF6790", VA = "0x180DF8190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool FGFJBHJIBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xDF80F0", Offset = "0xDF66F0", VA = "0x180DF80F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xDF8100", Offset = "0xDF6700", VA = "0x180DF8100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xDF8280", Offset = "0xDF6880", VA = "0x180DF8280")]
		public KHEOBOKGMPC(PDMNNKDAAOM CBHAAIPJCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xDF8120", Offset = "0xDF6720", VA = "0x180DF8120")]
		private int DNJGGIFCOKL(int ADDILPEFEHP, int BNGJDOKIFFL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xDF81E0", Offset = "0xDF67E0", VA = "0x180DF81E0")]
		private void KMNEKDAGPNL(int ADDILPEFEHP, int MAKFNMHIJIF, int BNGJDOKIFFL = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xDF8150", Offset = "0xDF6750", VA = "0x180DF8150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int CDCNNOIIDIO = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int BHCENJDNOHD = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly KNMMJEOEOPK AABGEPADDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<KNMMJEOEOPK, int> BJJGMAINADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<KNMMJEOEOPK> GLIGCLJIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> OOHKAPAPBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> ODHOPIGJPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> JIHCLPECHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private KHEOBOKGMPC JJDMBGDPAOA;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool ODJOJHICMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8970", Offset = "0x3BB6F70", VA = "0x183BB8970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ANLEMNFHGII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8200", Offset = "0x3BB6800", VA = "0x183BB8200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CLKAJICIIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8780", Offset = "0x3BB6D80", VA = "0x183BB8780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int CFKMIJKPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8DB0", Offset = "0x3BB73B0", VA = "0x183BB8DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8AA0", Offset = "0x3BB70A0", VA = "0x183BB8AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8270", Offset = "0x3BB6870", VA = "0x183BB8270")]
	public static FCHLEGPJOOJ CBFHJGEFJHE(PDMNNKDAAOM CBHAAIPJCPO = PDMNNKDAAOM.Last, int ELJAOJKOMCF = 16, int BLLDKIFEENK = 256)
	{
		return default(FCHLEGPJOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8EF0", Offset = "0x3BB74F0", VA = "0x183BB8EF0")]
	private FCHLEGPJOOJ(PDMNNKDAAOM CBHAAIPJCPO, int ELJAOJKOMCF, int BLLDKIFEENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BB84E0", Offset = "0x3BB6AE0", VA = "0x183BB84E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8980", Offset = "0x3BB6F80", VA = "0x183BB8980")]
	public LKHNNDCGJLC KHJHKCELOIP(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(LKHNNDCGJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8A10", Offset = "0x3BB7010", VA = "0x183BB8A10")]
	public FFBMDFNFEOK LNFOEOJBHOB(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(FFBMDFNFEOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8AE0", Offset = "0x3BB70E0", VA = "0x183BB8AE0")]
	public bool NFPEFJHNBGL(KNMMJEOEOPK CELBLIIOMDE, out FFBMDFNFEOK IFBGMBPKKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8220", Offset = "0x3BB6820", VA = "0x183BB8220")]
	public bool BOONJHGAGHB(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB86B0", Offset = "0x3BB6CB0", VA = "0x183BB86B0")]
	public bool HCEELEGAAJP(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8790", Offset = "0x3BB6D90", VA = "0x183BB8790")]
	public void JJEFLMMGPIP(NativeList<byte> FJEDANIIFJL, MADKAIDKJMP HMHKKKAECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x358DC50", Offset = "0x358C250", VA = "0x18358DC50")]
	public T IHBCBCAIMIC<T>(KNMMJEOEOPK CELBLIIOMDE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8CD0", Offset = "0x3BB72D0", VA = "0x183BB8CD0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BB82B0", Offset = "0x3BB68B0", VA = "0x183BB82B0")]
	public FFLHGLNJJJI CBILBBMABKJ()
	{
		return default(FFLHGLNJJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BB82F0", Offset = "0x3BB68F0", VA = "0x183BB82F0")]
	private void CKHBGDOGBCG(KNMMJEOEOPK CELBLIIOMDE, int LJECKBCMELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BB85C0", Offset = "0x3BB6BC0", VA = "0x183BB85C0")]
	private void FHDOHDMGJMO(int FPLOLBPBBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8880", Offset = "0x3BB6E80", VA = "0x183BB8880")]
	private void KCPIAHOEHKC(KNMMJEOEOPK CELBLIIOMDE, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x358DDE0", Offset = "0x358C3E0", VA = "0x18358DDE0")]
	private static T IHBCBCAIMIC<T>(NativeArray<byte> HEONDDEAIBL, int ADDILPEFEHP = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8E30", Offset = "0x3BB7430", VA = "0x183BB8E30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8DF0", Offset = "0x3BB73F0", VA = "0x183BB8DF0", Slot = "4")]
	private IEnumerator<KNMMJEOEOPK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class HNCHKDHGCDL<T> : CPOPPILPLCL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x498A860", Offset = "0x4988E60", VA = "0x18498A860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x498A980", Offset = "0x4988F80", VA = "0x18498A980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3617310", Offset = "0x3615910", VA = "0x183617310")]
	public HNCHKDHGCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x335C4A0", Offset = "0x335AAA0", VA = "0x18335C4A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	internal class CleanupRigidbodyExImpl : CPOPPILPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x38FAB20", Offset = "0x38F9120", VA = "0x1838FAB20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x38FABC0", Offset = "0x38F91C0", VA = "0x1838FABC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class PBCPPGJFODN : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery LEDAJNNDCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3890FC0", Offset = "0x388F5C0", VA = "0x183890FC0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3891010", Offset = "0x388F610", VA = "0x183891010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x38910A0", Offset = "0x388F6A0", VA = "0x1838910A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public PBCPPGJFODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal class PNGEPBCJOBP : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService DAIFFCCOLFF;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3894540", Offset = "0x3892B40", VA = "0x183894540", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3894590", Offset = "0x3892B90", VA = "0x183894590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public PNGEPBCJOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService LLLBMIKLOLI;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0BE0", Offset = "0x3BAF1E0", VA = "0x183BB0BE0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0C30", Offset = "0x3BAF230", VA = "0x183BB0C30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0CC0", Offset = "0x3BAF2C0", VA = "0x183BB0CC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[DHKIICMHACJ(typeof(CullingBandService), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class CullingBandService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::NLPBCKKLMDB<OGGEFBPFCHD>> PEGLPLKBCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x39041E0", Offset = "0x39027E0", VA = "0x1839041E0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3904170", Offset = "0x3902770", VA = "0x183904170")]
		public void EOKNBBAEDFA(global::NLPBCKKLMDB<OGGEFBPFCHD> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x3903D00", Offset = "0x3902300", VA = "0x183903D00")]
		public void ECEJGBDIPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x3903B90", Offset = "0x3902190", VA = "0x183903B90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x3904280", Offset = "0x3902880", VA = "0x183904280")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[DHKIICMHACJ(typeof(OOFBFFNNIPK), new string[] { })]
	public class PhysicsService : GOJCOOFCPOI, GKFAMMKGENJ, OOFBFFNNIPK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly FGGEJMNNOEE ACGBIMFLFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager LNPEGOPJJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private IEHKMAFMFKK JFGCBBCAMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService DBDILEFJPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::JIMNIBINLKA<OECOGGMFNPJ> IMLCIDKAMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<NIALADIPDNC, OECOGGMFNPJ> PCIOPDMEPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x3898420", Offset = "0x3896A20", VA = "0x183898420", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x38984C0", Offset = "0x3896AC0", VA = "0x1838984C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x38988F0", Offset = "0x3896EF0", VA = "0x1838988F0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3898560", Offset = "0x3896B60", VA = "0x183898560", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x3898790", Offset = "0x3896D90", VA = "0x183898790", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x3898820", Offset = "0x3896E20", VA = "0x183898820", Slot = "8")]
		public bool KFBPIKEMCNP(NIALADIPDNC KLCGNDEDAPD, out Collider BKPBAEGGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x3898A10", Offset = "0x3897010", VA = "0x183898A10")]
		private void NNKNEKICLGD(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x38986D0", Offset = "0x3896CD0", VA = "0x1838986D0", Slot = "9")]
		public void DGIAHJOJINH(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[DHKIICMHACJ(typeof(PJCBAJNDEOE), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class RbexService : GOJCOOFCPOI, PJCBAJNDEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private KCAFIOGMOCH CJKDIAIBACJ;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x38A0D30", Offset = "0x389F330", VA = "0x1838A0D30")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x38A03A0", Offset = "0x389E9A0", VA = "0x1838A03A0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x389E6E0", Offset = "0x389CCE0", VA = "0x18389E6E0", Slot = "6")]
		public IAEKLBCNHIG DLPKGCFNLFI(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x389FE30", Offset = "0x389E430", VA = "0x18389FE30", Slot = "5")]
		public void LALJHKFAMEL(NIALADIPDNC KLCGNDEDAPD, IAEKLBCNHIG MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x389DD50", Offset = "0x389C350", VA = "0x18389DD50", Slot = "34")]
		public CollisionDetectionMode AJNFIHLIDIP(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x38A08B0", Offset = "0x389EEB0", VA = "0x1838A08B0", Slot = "35")]
		public void OENKJBLGKDB(NIALADIPDNC KLCGNDEDAPD, CollisionDetectionMode MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x38A0EB0", Offset = "0x389F4B0", VA = "0x1838A0EB0", Slot = "36")]
		public CKHEJONCKGK POAIBGFFFKK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(CKHEJONCKGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x38A0720", Offset = "0x389ED20", VA = "0x1838A0720", Slot = "37")]
		public void NMEGEAIJCMG(NIALADIPDNC KLCGNDEDAPD, CKHEJONCKGK MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x389F0D0", Offset = "0x389D6D0", VA = "0x18389F0D0", Slot = "38")]
		public bool IBHKBPDCGAN(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x389DDB0", Offset = "0x389C3B0", VA = "0x18389DDB0", Slot = "39")]
		public void ALAEBGCDJHO(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x389F920", Offset = "0x389DF20", VA = "0x18389F920", Slot = "40")]
		public NIALADIPDNC KCDNPIAEBEL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x38A0E30", Offset = "0x389F430", VA = "0x1838A0E30", Slot = "41")]
		public void PKKLCJELFEI(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x38A0290", Offset = "0x389E890", VA = "0x1838A0290", Slot = "42")]
		public NIALADIPDNC NCMHOFMDGAH(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x38A0A00", Offset = "0x389F000", VA = "0x1838A0A00", Slot = "43")]
		public void OGODNIIEFFB(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x38A0C20", Offset = "0x389F220", VA = "0x1838A0C20", Slot = "7")]
		public void OPJJCFHECII(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x389DFB0", Offset = "0x389C5B0", VA = "0x18389DFB0", Slot = "8")]
		public void APJHAKKKPLO(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x389F740", Offset = "0x389DD40", VA = "0x18389F740", Slot = "9")]
		public int JGMHFKDKOJL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x389DE20", Offset = "0x389C420", VA = "0x18389DE20", Slot = "10")]
		public NIALADIPDNC ALAEJPDKHIN(NIALADIPDNC KLCGNDEDAPD, int EBBLFLFCHFB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x389DB10", Offset = "0x389C110", VA = "0x18389DB10", Slot = "11")]
		public void AAFJDBGBNLK(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x389F440", Offset = "0x389DA40", VA = "0x18389F440", Slot = "12")]
		public void ILOEHODJFLD(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x389EB20", Offset = "0x389D120", VA = "0x18389EB20", Slot = "13")]
		public void EMIILCGJJLB(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x389E770", Offset = "0x389CD70", VA = "0x18389E770", Slot = "14")]
		public bool EBEMABAEMMB(NIALADIPDNC KLCGNDEDAPD, out NIALADIPDNC MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x38A0A80", Offset = "0x389F080", VA = "0x1838A0A80", Slot = "15")]
		public void OHODHFDLDKK(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x38A05C0", Offset = "0x389EBC0", VA = "0x1838A05C0", Slot = "16")]
		public bool NLFOHIKDCFF(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x389DC70", Offset = "0x389C270", VA = "0x18389DC70", Slot = "17")]
		public void AIPEBLNKKIJ(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x389EEF0", Offset = "0x389D4F0", VA = "0x18389EEF0", Slot = "18")]
		public bool HHIOGDKIPIB(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x389E430", Offset = "0x389CA30", VA = "0x18389E430", Slot = "26")]
		public float3 CMMECPNHHJF(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x389E8D0", Offset = "0x389CED0", VA = "0x18389E8D0", Slot = "27")]
		public void EDLHINCKBGC(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x389FC10", Offset = "0x389E210", VA = "0x18389FC10", Slot = "28")]
		public float KLFNJBEEHJL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x38A0450", Offset = "0x389EA50", VA = "0x1838A0450", Slot = "29")]
		public void NFOOMMJHALN(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x389EE90", Offset = "0x389D490", VA = "0x18389EE90", Slot = "30")]
		public float GLOIMGGMOKJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x38A04C0", Offset = "0x389EAC0", VA = "0x1838A04C0", Slot = "31")]
		public void NGBNHFHHKHB(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x389DCF0", Offset = "0x389C2F0", VA = "0x18389DCF0", Slot = "32")]
		public bool AJHEOPOFLAD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x389EC40", Offset = "0x389D240", VA = "0x18389EC40", Slot = "33")]
		public void EPHFHGIMMMB(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x389F050", Offset = "0x389D650", VA = "0x18389F050", Slot = "19")]
		public void HHNIHLEEOIE(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x389E950", Offset = "0x389CF50", VA = "0x18389E950", Slot = "20")]
		public bool EFCOGJPGGCO(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x389E4B0", Offset = "0x389CAB0", VA = "0x18389E4B0", Slot = "21")]
		public void CPINEKECPJJ(NIALADIPDNC KLCGNDEDAPD, quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x389FCD0", Offset = "0x389E2D0", VA = "0x18389FCD0", Slot = "22")]
		public bool KPOFMJIAOEH(NIALADIPDNC KLCGNDEDAPD, out quaternion MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x389F9A0", Offset = "0x389DFA0", VA = "0x18389F9A0", Slot = "23")]
		public bool KKJIIKFKKNP(NIALADIPDNC KLCGNDEDAPD, out float3 CGEGKNKGPFM, out quaternion LGNJCDPNHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x389ECB0", Offset = "0x389D2B0", VA = "0x18389ECB0", Slot = "44")]
		public MGONBPIMIEF FKHPGAAJCCO(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(MGONBPIMIEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x389DF40", Offset = "0x389C540", VA = "0x18389DF40", Slot = "45")]
		public void ALGOJFGCEFD(NIALADIPDNC KLCGNDEDAPD, MGONBPIMIEF MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x38A0200", Offset = "0x389E800", VA = "0x1838A0200", Slot = "72")]
		public void NBBDGJBDGID(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x389E220", Offset = "0x389C820", VA = "0x18389E220", Slot = "73")]
		public void BPICDIFEHOD(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x389E2B0", Offset = "0x389C8B0", VA = "0x18389E2B0", Slot = "74")]
		public bool CBHGKKIFLPD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x389EBB0", Offset = "0x389D1B0", VA = "0x18389EBB0", Slot = "81")]
		public void ENFKGGCFLID(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x38A0530", Offset = "0x389EB30", VA = "0x1838A0530", Slot = "82")]
		public void NJDBCKJHEAN(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x38A0980", Offset = "0x389EF80", VA = "0x1838A0980", Slot = "83")]
		public bool OFMOMHPPBEE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x389E330", Offset = "0x389C930", VA = "0x18389E330", Slot = "84")]
		public IEnumerable<object> CKJHDKFAHKP(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x38A0BC0", Offset = "0x389F1C0", VA = "0x1838A0BC0", Slot = "46")]
		public bool OKPNADILIBC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x389FC70", Offset = "0x389E270", VA = "0x18389FC70", Slot = "47")]
		public void KOBPOPOIBAK(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x38A0340", Offset = "0x389E940", VA = "0x1838A0340", Slot = "48")]
		public bool NDAPKANPJCK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x389F570", Offset = "0x389DB70", VA = "0x18389F570", Slot = "49")]
		public void IOOACNLNGJF(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x38A0850", Offset = "0x389EE50", VA = "0x1838A0850", Slot = "50")]
		public bool OALDGAPFJHJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x38A0DC0", Offset = "0x389F3C0", VA = "0x1838A0DC0", Slot = "51")]
		public void PHCPOHODIFC(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x38A0920", Offset = "0x389EF20", VA = "0x1838A0920", Slot = "52")]
		public RigidbodyConstraints OFGKHJLCPOI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x38A0090", Offset = "0x389E690", VA = "0x1838A0090", Slot = "53")]
		public void LOKHKOHJMHL(NIALADIPDNC KLCGNDEDAPD, RigidbodyConstraints MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x38A0B00", Offset = "0x389F100", VA = "0x1838A0B00", Slot = "54")]
		public float OICAFAFKOCE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x389EAB0", Offset = "0x389D0B0", VA = "0x18389EAB0", Slot = "55")]
		public void ELDJCOLGGCL(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x389E520", Offset = "0x389CB20", VA = "0x18389E520", Slot = "56")]
		public float DHAEDBKIGML(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x38A0020", Offset = "0x389E620", VA = "0x1838A0020", Slot = "57")]
		public void LJKNPGBGMKD(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x38A0B60", Offset = "0x389F160", VA = "0x1838A0B60", Slot = "58")]
		public bool OJNALKDCGEI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x389DC00", Offset = "0x389C200", VA = "0x18389DC00", Slot = "59")]
		public void AAGKDHNINMK(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x389EDC0", Offset = "0x389D3C0", VA = "0x18389EDC0", Slot = "60")]
		public bool GCMAJPIFLBC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x38A0D50", Offset = "0x389F350", VA = "0x1838A0D50", Slot = "61")]
		public void PGECINJGFMD(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x389FF40", Offset = "0x389E540", VA = "0x18389FF40", Slot = "62")]
		public int LHDCPDDNNKB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x38A0190", Offset = "0x389E790", VA = "0x1838A0190", Slot = "63")]
		public void MNJGLBDCIPF(NIALADIPDNC KLCGNDEDAPD, int MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x389F6B0", Offset = "0x389DCB0", VA = "0x18389F6B0", Slot = "64")]
		public Rigidbody JAAOBHBLKKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x389E0C0", Offset = "0x389C6C0", VA = "0x18389E0C0", Slot = "65")]
		public void BFHMBJJGBCK(NIALADIPDNC KLCGNDEDAPD, Rigidbody MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x389F130", Offset = "0x389D730", VA = "0x18389F130", Slot = "75")]
		public void IHCEABBGJNA(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x389F250", Offset = "0x389D850", VA = "0x18389F250", Slot = "76")]
		public void IKAPLFMFBGG(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x389ED40", Offset = "0x389D340", VA = "0x18389ED40", Slot = "77")]
		public bool FNNKALCPKLJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x38A07C0", Offset = "0x389EDC0", VA = "0x1838A07C0", Slot = "66")]
		public object NOCGIAAKMMF(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x389E580", Offset = "0x389CB80", VA = "0x18389E580", Slot = "67")]
		public void DHJPGIOHBFO(NIALADIPDNC KLCGNDEDAPD, object MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x38A0100", Offset = "0x389E700", VA = "0x1838A0100", Slot = "68")]
		public object MIPNGEKNJMJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x389F2E0", Offset = "0x389D8E0", VA = "0x18389F2E0", Slot = "69")]
		public void IKCBPIHMJEJ(NIALADIPDNC KLCGNDEDAPD, object MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x389FEE0", Offset = "0x389E4E0", VA = "0x18389FEE0", Slot = "70")]
		public float LBAEENMICGI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x389EE20", Offset = "0x389D420", VA = "0x18389EE20", Slot = "71")]
		public void GKNBMLJEJOF(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x389F890", Offset = "0x389DE90", VA = "0x18389F890", Slot = "78")]
		public void JMMEKLBPKCK(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x389F1C0", Offset = "0x389D7C0", VA = "0x18389F1C0", Slot = "79")]
		public void IJNFOLLCMCI(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x389FFA0", Offset = "0x389E5A0", VA = "0x18389FFA0", Slot = "80")]
		public bool LJABEMCEPMC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x38A0F50", Offset = "0x389F550", VA = "0x1838A0F50", Slot = "24")]
		public void PPMHJKGACBG(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x389F830", Offset = "0x389DE30", VA = "0x18389F830", Slot = "25")]
		public void JIJOKELMPFC(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x45DEE80", Offset = "0x45DD480", VA = "0x1845DEE80")]
		private void MOIAJHLONAA<T>(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x45DE9D0", Offset = "0x45DCFD0", VA = "0x1845DE9D0")]
		private bool LFIKBHCLHHI<T>(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x45DE180", Offset = "0x45DC780", VA = "0x1845DE180")]
		private void EMIFMEAGDDE<T>(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x45DE850", Offset = "0x45DCE50", VA = "0x1845DE850")]
		private bool KOMMMKEDIDP<TC, TV>(NIALADIPDNC KLCGNDEDAPD, Func<TC, TV> PLKNOODMMGB, out TV MAKFNMHIJIF) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x45DD9F0", Offset = "0x45DBFF0", VA = "0x1845DD9F0")]
		private bool KOMMMKEDIDP<T>(NIALADIPDNC KLCGNDEDAPD, out T MAKFNMHIJIF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x45DEA30", Offset = "0x45DD030", VA = "0x1845DEA30")]
		private T MIDJFBJDPMP<T>(NIALADIPDNC KLCGNDEDAPD) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x45DE1E0", Offset = "0x45DC7E0", VA = "0x1845DE1E0")]
		private void FKBMLKPEFCI<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x45DDB20", Offset = "0x45DC120", VA = "0x1845DDB20")]
		private void BEBIMCHEGFI<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x45DD9F0", Offset = "0x45DBFF0", VA = "0x1845DD9F0")]
		private bool NMIJJIHBLBF<T>(NIALADIPDNC KLCGNDEDAPD, out T MAKFNMHIJIF) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x45DE730", Offset = "0x45DCD30", VA = "0x1845DE730")]
		private T JFMJGABCIND<T>(NIALADIPDNC KLCGNDEDAPD) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x45DD9F0", Offset = "0x45DBFF0", VA = "0x1845DD9F0")]
		private void AEPCPIJAJHL<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x45DDA70", Offset = "0x45DC070", VA = "0x1845DDA70")]
		private void ANLGLGJOOAA<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x389ED10", Offset = "0x389D310", VA = "0x18389ED10")]
		private NIALADIPDNC FLPHBJACNKB(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x389F5E0", Offset = "0x389DBE0", VA = "0x18389F5E0")]
		private DynamicBuffer<Entity> IPHGFBAPLOK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x45DE790", Offset = "0x45DCD90", VA = "0x1845DE790")]
		private void JJANAJNLEDF<T>(NIALADIPDNC KLCGNDEDAPD, object MAKFNMHIJIF, Func<object, T> PLKNOODMMGB) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void IFEPEMKMGAF<T>(ref global::BHECHFLOHKD<T> JDMFCLOEMNK) where T : struct, FEHJDGBIBFC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void IFEPEMKMGAF<TC, TV>(ref global::MBBKMHEBCCI<TC, TV> JDMFCLOEMNK) where TC : struct, FEHJDGBIBFC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	[DHKIICMHACJ(typeof(KinematicSleepChangeService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class KinematicSleepChangeService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class OPOENODHDPD : IEnumerable<IAEKLBCNHIG>, IEnumerable, IEnumerator<IAEKLBCNHIG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private IAEKLBCNHIG <>2__current;

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
			private IAEKLBCNHIG System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public OPOENODHDPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xDFC150", Offset = "0xDFA750", VA = "0x180DFC150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xDFBE10", Offset = "0xDFA410", VA = "0x180DFBE10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xDFC1D0", Offset = "0xDFA7D0", VA = "0x180DFC1D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xDFC110", Offset = "0xDFA710", VA = "0x180DFC110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xDFC060", Offset = "0xDFA660", VA = "0x180DFC060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IAEKLBCNHIG> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xDFC060", Offset = "0xDFA660", VA = "0x180DFC060", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> OHHGFKLEBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB960", Offset = "0x3BC9F60", VA = "0x183BCB960", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB080", Offset = "0x3BC9680", VA = "0x183BCB080")]
		public void EOKNBBAEDFA(NativeArray<Entity> IJBCECFNJIL, bool OKCPLEPCJGC, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAE70", Offset = "0x3BC9470", VA = "0x183BCAE70")]
		public void ECEJGBDIPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB1A0", Offset = "0x3BC97A0", VA = "0x183BCB1A0")]
		private void FBFMNKIPGOD(NativeArray<Entity> IJBCECFNJIL, bool OKCPLEPCJGC, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAC90", Offset = "0x3BC9290", VA = "0x183BCAC90")]
		[IteratorStateMachine(typeof(OPOENODHDPD))]
		private IEnumerable<IAEKLBCNHIG> CKKBBDHNMKI(NativeArray<Entity> IJBCECFNJIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAD20", Offset = "0x3BC9320", VA = "0x183BCAD20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBA00", Offset = "0x3BCA000", VA = "0x183BCBA00")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[DHKIICMHACJ(typeof(OMKGMEPBKLL), new string[] { })]
public class GHHDLGCAOGK : OMKGMEPBKLL, IEnumerable<DHPNCKOALMM>, IEnumerable, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[CJONPMHNDBN]
	private NJNCDGKENIB KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> CJBOPBJLIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private LOLNFPEOPCL HHPGIIAPEMG;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x3BBE140", Offset = "0x3BBC740", VA = "0x183BBE140", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DHPNCKOALMM EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDCF0", Offset = "0x3BBC2F0", VA = "0x183BBDCF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DHPNCKOALMM EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDCF0", Offset = "0x3BBC2F0", VA = "0x183BBDCF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE0F0", Offset = "0x3BBC6F0", VA = "0x183BBE0F0", Slot = "11")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE160", Offset = "0x3BBC760", VA = "0x183BBE160", Slot = "12")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD910", Offset = "0x3BBBF10", VA = "0x183BBD910")]
	private void ABEKKMLAJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2379A30", Offset = "0x2378030", VA = "0x182379A30")]
	private string GBFKMANADIH(string NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDC10", Offset = "0x3BBC210", VA = "0x183BBDC10", Slot = "7")]
	public DHPNCKOALMM EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDD10", Offset = "0x3BBC310", VA = "0x183BBDD10")]
	private bool GNBNOIDOCMI(Type BMNJCJDHIKF, string NBODBMLPNJA, out DHPNCKOALMM MEIAOCKHKHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDFE0", Offset = "0x3BBC5E0", VA = "0x183BBDFE0", Slot = "8")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDFC0", Offset = "0x3BBC5C0", VA = "0x183BBDFC0", Slot = "9")]
	public IEnumerator<DHPNCKOALMM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDFC0", Offset = "0x3BBC5C0", VA = "0x183BBDFC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE1E0", Offset = "0x3BBC7E0", VA = "0x183BBE1E0")]
	public GHHDLGCAOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DefaultMember("Item")]
public interface MADKAIDKJMP
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBMLNKHCBFP(HDFAPEIIIAK CBBOJGIJLHN, out int JLMAIAGOBFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[DHKIICMHACJ(typeof(MADKAIDKJMP), new string[] { })]
public class POMKFKNIAON : GOJCOOFCPOI, GKFAMMKGENJ, MADKAIDKJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[CJONPMHNDBN]
	private NHGGIKDMDCJ KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<HDFAPEIIIAK, int> LMOHEHBKEMO;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x38958C0", Offset = "0x3893EC0", VA = "0x1838958C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x3895980", Offset = "0x3893F80", VA = "0x183895980", Slot = "6")]
	public bool PBMLNKHCBFP(HDFAPEIIIAK CBBOJGIJLHN, out int JLMAIAGOBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x3895920", Offset = "0x3893F20", VA = "0x183895920", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x38958B0", Offset = "0x3893EB0", VA = "0x1838958B0", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x3895640", Offset = "0x3893C40", VA = "0x183895640")]
	private void AFFDJHOHDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x38959F0", Offset = "0x3893FF0", VA = "0x1838959F0")]
	public POMKFKNIAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DHKIICMHACJ(typeof(NHGGIKDMDCJ), new string[] { })]
[DefaultMember("Item")]
public class LJDIDJAEPMO : NHGGIKDMDCJ, IEnumerable<CKNEHODEDLN>, IEnumerable, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDBCBPLBJEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[CJONPMHNDBN]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[CJONPMHNDBN]
	private OMKGMEPBKLL BGOMBAOCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private CKNEHODEDLN[] BMKMNDBIBDC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BCD100", Offset = "0x3BCB700", VA = "0x183BCD100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CKNEHODEDLN EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCCA0", Offset = "0x3BCB2A0", VA = "0x183BCCCA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CKNEHODEDLN EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCCA0", Offset = "0x3BCB2A0", VA = "0x183BCCCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "10")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD110", Offset = "0x3BCB710", VA = "0x183BCD110", Slot = "11")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCE20", Offset = "0x3BCB420", VA = "0x183BCCE20", Slot = "6")]
	public CKNEHODEDLN EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD030", Offset = "0x3BCB630", VA = "0x183BCD030", Slot = "7")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCF50", Offset = "0x3BCB550", VA = "0x183BCCF50", Slot = "8")]
	public IEnumerator<CKNEHODEDLN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD3B0", Offset = "0x3BCB9B0", VA = "0x183BCD3B0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x44573B0", Offset = "0x44559B0", VA = "0x1844573B0", Slot = "13")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCCE0", Offset = "0x3BCB2E0", VA = "0x183BCCCE0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LJDIDJAEPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCCA0", Offset = "0x3BCB2A0", VA = "0x183BCCCA0")]
	[CompilerGenerated]
	private CKNEHODEDLN APNFGBFFJOG(int LJOFAPCHBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DHKIICMHACJ(typeof(GIHCPFBMAPF), new string[] { })]
[DefaultMember("Item")]
public class FPGKKPPBGLE : GIHCPFBMAPF, IEnumerable<MIKODHFFJMF>, IEnumerable, GOJCOOFCPOI, GKFAMMKGENJ, IDBCBPLBJEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[CJONPMHNDBN]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[CJONPMHNDBN]
	private OMKGMEPBKLL BGOMBAOCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private MIKODHFFJMF[] BMKMNDBIBDC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC150", Offset = "0x3BBA750", VA = "0x183BBC150", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MIKODHFFJMF EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBA60", Offset = "0x3BBA060", VA = "0x183BBBA60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MIKODHFFJMF EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBA60", Offset = "0x3BBA060", VA = "0x183BBBA60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC1A0", Offset = "0x3BBA7A0", VA = "0x183BBC1A0", Slot = "9")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBA70", Offset = "0x3BBA070", VA = "0x183BBBA70", Slot = "10")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC070", Offset = "0x3BBA670", VA = "0x183BBC070")]
	private MIKODHFFJMF KGIIKCPNKBO(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBD70", Offset = "0x3BBA370", VA = "0x183BBBD70", Slot = "6")]
	public MIKODHFFJMF EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBFA0", Offset = "0x3BBA5A0", VA = "0x183BBBFA0", Slot = "14")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBE90", Offset = "0x3BBA490", VA = "0x183BBBE90", Slot = "7")]
	public IEnumerator<MIKODHFFJMF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBE90", Offset = "0x3BBA490", VA = "0x183BBBE90", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x35A2DB0", Offset = "0x35A13B0", VA = "0x1835A2DB0", Slot = "11")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBCD0", Offset = "0x3BBA2D0", VA = "0x183BBBCD0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FPGKKPPBGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBA60", Offset = "0x3BBA060", VA = "0x183BBBA60")]
	[CompilerGenerated]
	private MIKODHFFJMF APNFGBFFJOG(int LJOFAPCHBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(NJNCDGKENIB), new string[] { })]
internal class NJNCDGKENIB : GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private OMKGMEPBKLL BGOMBAOCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private GIHCPFBMAPF DBOFEMANHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private NHGGIKDMDCJ DJPEFLJBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::CBENKMECBMN<LDCIHJCLMHG> JDPNBCGEEAE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public LOLNFPEOPCL HBEEILGMIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3881FE0", Offset = "0x38805E0", VA = "0x183881FE0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x38821E0", Offset = "0x38807E0", VA = "0x1838821E0")]
	private void PPEKFCDLGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x433C9D0", Offset = "0x433AFD0", VA = "0x18433C9D0")]
	public T JFJJHICDBIL<T>() where T : LDCIHJCLMHG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3881F10", Offset = "0x3880510", VA = "0x183881F10")]
	public DHPNCKOALMM HANBKECNOCJ(DMNHKHOLGBO NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::JIMNIBINLKA<T> HANBKECNOCJ<T>(DMNHKHOLGBO NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3881E40", Offset = "0x3880440", VA = "0x183881E40")]
	public MIKODHFFJMF COKFMIALAJN(DMNHKHOLGBO NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x433C950", Offset = "0x433AF50", VA = "0x18433C950")]
	public global::JGPMEKBNBND<T> COKFMIALAJN<T>(DMNHKHOLGBO NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3882110", Offset = "0x3880710", VA = "0x183882110")]
	public CKNEHODEDLN PHBFLHALCBB(DMNHKHOLGBO NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::BOKDKPCCEKG<T> PHBFLHALCBB<T>(DMNHKHOLGBO NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NJNCDGKENIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class EODIOGHDCOK
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x331D660", Offset = "0x331BC60", VA = "0x18331D660")]
	public static global::JIMNIBINLKA<T> HANBKECNOCJ<T>(this NJNCDGKENIB GLIDFGCEEAN, global::AJFAFKBPGAH<T> NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::JGPMEKBNBND<T> COKFMIALAJN<T>(this NJNCDGKENIB GLIDFGCEEAN, global::AJFAFKBPGAH<T> NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::BOKDKPCCEKG<T> PHBFLHALCBB<T>(this NJNCDGKENIB GLIDFGCEEAN, global::AJFAFKBPGAH<T> NBODBMLPNJA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
[DHKIICMHACJ(typeof(IPHAHHKHHPH), new string[] { })]
public class IPHAHHKHHPH : GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private CBEPKLBIIOB EPFNIEDFLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private HDFAPEIIIAK[] EMCENOMLKMB;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6700", Offset = "0x3BC4D00", VA = "0x183BC6700", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3BC65E0", Offset = "0x3BC4BE0", VA = "0x183BC65E0")]
	public void JBLOBEABNOF(COEEIJJLOPG FBIBIHJENAB, bool IKFCIOJBEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IPHAHHKHHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DHKIICMHACJ(typeof(GJEDNMGKPEF), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
public sealed class GJEDNMGKPEF : GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class MEPNJKDHKHH : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public MEPNJKDHKHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xDF9AF0", Offset = "0xDF80F0", VA = "0x180DF9AF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDF9740", Offset = "0xDF7D40", VA = "0x180DF9740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDF9B70", Offset = "0xDF8170", VA = "0x180DF9B70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xDF9AB0", Offset = "0xDF80B0", VA = "0x180DF9AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xDF9A20", Offset = "0xDF8020", VA = "0x180DF9A20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xDF9A20", Offset = "0xDF8020", VA = "0x180DF9A20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string JCLGIIEDCEF = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, ALGPAJCFDGK> JAJGDIBMFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> MGKCKCJCBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> EJCAANKBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private GIHCPFBMAPF KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private PAJFOGDKCPC PLNODCMOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private NNAMEJEONOI EENBDKCLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::DHFNFLDBPNF<ALGPAJCFDGK> EFPGHHJIGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject KMBENPGAMPI;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF9D0", Offset = "0x3BBDFD0", VA = "0x183BBF9D0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE850", Offset = "0x3BBCE50", VA = "0x183BBE850", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEE50", Offset = "0x3BBD450", VA = "0x183BBEE50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE840", Offset = "0x3BBCE40", VA = "0x183BBE840")]
	private void BMCKBGPJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEA20", Offset = "0x3BBD020", VA = "0x183BBEA20")]
	internal void DBHGOFAKPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF320", Offset = "0x3BBD920", VA = "0x183BBF320")]
	private void KOBELGLMGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF220", Offset = "0x3BBD820", VA = "0x183BBF220")]
	private void KEIEPMMBHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF1D0", Offset = "0x3BBD7D0", VA = "0x183BBF1D0")]
	[IteratorStateMachine(typeof(MEPNJKDHKHH))]
	private IEnumerable<RRCustomPropTag> GAEOLBEMEAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBFAF0", Offset = "0x3BBE0F0", VA = "0x183BBFAF0")]
	private void PKGNLBHNJPJ(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF500", Offset = "0x3BBDB00", VA = "0x183BBF500")]
	private void KOEBKPOFGOP(SerializableGuid GDIIAHJOKME, GameObject EHEABJNEALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF640", Offset = "0x3BBDC40", VA = "0x183BBF640")]
	private void MCBNKEJFPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEFF0", Offset = "0x3BBD5F0", VA = "0x183BBEFF0")]
	private bool FBLPPDHMCOB(ALGPAJCFDGK OEMKNHEOBPA, Transform LFAIGCEGCPL, out GameObject PFOFOPEANHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBFAA0", Offset = "0x3BBE0A0", VA = "0x183BBFAA0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBFF70", Offset = "0x3BBE570", VA = "0x183BBFF70")]
	public GJEDNMGKPEF()
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
		public SerializableGuid NJFLHMDHIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x389DA20", Offset = "0x389C020", VA = "0x18389DA20")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DHKIICMHACJ(typeof(JDMPKCFALBH), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
public class JDMPKCFALBH : GOJCOOFCPOI
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string KMEPKIKEKCN = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService LCJDMKABNOO;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6D40", Offset = "0x3BC5340", VA = "0x183BC6D40", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JDMPKCFALBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
[DHKIICMHACJ(typeof(LGFPKLNDOFL), new string[] { })]
public class LGFPKLNDOFL : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[CJONPMHNDBN]
	private EnableComponentSystemsInScope INDALICFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[CJONPMHNDBN]
	private SceneService LCJDMKABNOO;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCC30", Offset = "0x3BCB230", VA = "0x183BCCC30", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCBF0", Offset = "0x3BCB1F0", VA = "0x183BCCBF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCBD0", Offset = "0x3BCB1D0", VA = "0x183BCCBD0")]
	private void AJNEIPBAHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCBA0", Offset = "0x3BCB1A0", VA = "0x183BCCBA0")]
	private void AALNCNODAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LGFPKLNDOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DHKIICMHACJ(typeof(MJFDNFOLGPA), new string[] { })]
public class MPLKJEKBOCE : GOJCOOFCPOI, GKFAMMKGENJ, MJFDNFOLGPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private OPAKLFEDMAA BFIDBOCPJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private KOODIGCDAJA LIDNPAFJMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService DBDILEFJPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem DECGOOEDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int GMCOIAEJNMP;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool LBFCHMNDIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x38808D0", Offset = "0x387EED0", VA = "0x1838808D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NIALADIPDNC BIJMJHHBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x3880E30", Offset = "0x387F430", VA = "0x183880E30", Slot = "9")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x38808B0", Offset = "0x387EEB0", VA = "0x1838808B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public INPNGJHLELG OBLCOCPFGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x387FF30", Offset = "0x387E530", VA = "0x18387FF30", Slot = "11")]
		get
		{
			return default(INPNGJHLELG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x38808B0", Offset = "0x387EEB0", VA = "0x1838808B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public INPNGJHLELG IHNPJOODLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x3880640", Offset = "0x387EC40", VA = "0x183880640", Slot = "13")]
		get
		{
			return default(INPNGJHLELG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint IKFFKFOINAI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3880B00", Offset = "0x387F100", VA = "0x183880B00")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LNJOKNOCHHN GAAJOMGCPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3880C80", Offset = "0x387F280", VA = "0x183880C80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x38801F0", Offset = "0x387E7F0", VA = "0x1838801F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x3880BB0", Offset = "0x387F1B0", VA = "0x183880BB0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x38804A0", Offset = "0x387EAA0", VA = "0x1838804A0", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x3880800", Offset = "0x387EE00", VA = "0x183880800", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x387FFF0", Offset = "0x387E5F0", VA = "0x18387FFF0")]
	private void AGNPAKFLNLJ(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x3880D20", Offset = "0x387F320", VA = "0x183880D20", Slot = "14")]
	public NIALADIPDNC OJHGJIBAMMJ(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x3880700", Offset = "0x387ED00", VA = "0x183880700", Slot = "15")]
	public bool DNKFCLNJCJP(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON, out NIALADIPDNC JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x3880ED0", Offset = "0x387F4D0", VA = "0x183880ED0", Slot = "16")]
	public void OLGMGBNAEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x3880290", Offset = "0x387E890", VA = "0x183880290", Slot = "17")]
	public void BFFEDKNADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x38802B0", Offset = "0x387E8B0", VA = "0x1838802B0", Slot = "18")]
	public bool CECILCPDGGE(NIALADIPDNC BIPEBBMCHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3880970", Offset = "0x387EF70", VA = "0x183880970")]
	private void LKJJDPAKFJC(NIALADIPDNC HLPLMDDPLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MPLKJEKBOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DHKIICMHACJ(typeof(NOFMFNFCABJ), new string[] { })]
public class CAMNBJJPJEL : GOJCOOFCPOI, NOFMFNFCABJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x38F7AE0", Offset = "0x38F60E0", VA = "0x1838F7AE0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x38F7A70", Offset = "0x38F6070", VA = "0x1838F7A70", Slot = "5")]
	public void GDIDMLIHIAL(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x33B7D30", Offset = "0x33B6330", VA = "0x1833B7D30")]
	private void KMNEKDAGPNL<T>(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CAMNBJJPJEL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DHKIICMHACJ(typeof(PPLBOFNBIPJ), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.RenderEffects)]
	public class SelectionService : GOJCOOFCPOI, PPLBOFNBIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager LNPEGOPJJGK;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x77BA90", Offset = "0x77A090", VA = "0x18077BA90", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x77BA20", Offset = "0x77A020", VA = "0x18077BA20", Slot = "5")]
		public void LBLPDEBDJFH(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x77B9B0", Offset = "0x779FB0", VA = "0x18077B9B0", Slot = "6")]
		public void FKMGHBKEIDH(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x33B7D30", Offset = "0x33B6330", VA = "0x1833B7D30")]
		private void KMNEKDAGPNL<T>(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
[DHKIICMHACJ(typeof(JEMPCLLHPCB), new string[] { })]
internal sealed class JEMPCLLHPCB : GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[CJONPMHNDBN]
	private ObjectEmbodimentService NCAANBGOHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI NCKCDMENEMI;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6DD0", Offset = "0x3BC53D0", VA = "0x183BC6DD0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JEMPCLLHPCB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	[DHKIICMHACJ(typeof(WorldSerialization), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	internal sealed class WorldSerialization : GOJCOOFCPOI, JDGJKANJDLB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FGGEJMNNOEE CENBFJJCBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[CJONPMHNDBN]
		private KDGBBCMLLMM JBGBBDABBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[CJONPMHNDBN]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[CJONPMHNDBN]
		private SerializationService PLNODCMOLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[CJONPMHNDBN]
		private NODJLDEEPBE GLIGCLJIOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[CJONPMHNDBN]
		private DebugWorldsService BIBBFOLCJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[CJONPMHNDBN]
		private BulkInstantiateSceneObjectService DPHPHDEMEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private PFKGIHKPIGG GOCENLCAMDB;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private OOEKEMBOFOH DNGHIFJGAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x78FC40", Offset = "0x78E240", VA = "0x18078FC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x790250", Offset = "0x78E850", VA = "0x180790250", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG DDAOLJGIIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x78FC60", Offset = "0x78E260", VA = "0x18078FC60", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7903A0", Offset = "0x78E9A0", VA = "0x1807903A0", Slot = "6")]
		public bool NMBDCHIJFJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E290", VA = "0x18078FC90", Slot = "7")]
		public bool IBCIKLNJDPJ(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x78FD00", Offset = "0x78E300", VA = "0x18078FD00", Slot = "5")]
		public ByteString MHOEBEHGBOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x790190", Offset = "0x78E790", VA = "0x180790190")]
		private void MMHIKBOAIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x78FB70", Offset = "0x78E170", VA = "0x18078FB70")]
		private void APPJNFEPODN(JGONKIMCOJA GLKFPPDNABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7907E0", Offset = "0x78EDE0", VA = "0x1807907E0")]
		private void OMBAJNABOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x790500", Offset = "0x78EB00", VA = "0x180790500")]
		private void OJLLKNAAHKB(HEONIOFKGAF GLKFPPDNABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x78FCB0", Offset = "0x78E2B0", VA = "0x18078FCB0", Slot = "8")]
		public void KPNGBGLCOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7901B0", Offset = "0x78E7B0", VA = "0x1807901B0")]
		private JGONKIMCOJA NCHPJHBPJDP(EntityManager OPLEGACAFEB, EntityManager PCGCHIPEABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DHKIICMHACJ(typeof(BDMIJCHOPPD), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
public class BDMIJCHOPPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<KFKBMIIJOHI, string> KJEOOIJBCKK;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x38F36D0", Offset = "0x38F1CD0", VA = "0x1838F36D0")]
	public GameObject BCAOCHCBGDH(KFKBMIIJOHI KCEOAINNEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x38F37A0", Offset = "0x38F1DA0", VA = "0x1838F37A0")]
	public BDMIJCHOPPD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(TimeService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class TimeService : BGDEOEAAJCH, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[CJONPMHNDBN]
		private SingletonComponentService JHCHEPNNHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool IIJIMEKMMLP;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData DODGLIKNFCD
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x783430", Offset = "0x781A30", VA = "0x180783430")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x7833B0", Offset = "0x7819B0", VA = "0x1807833B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DFOJLFKFLHF
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x7834B0", Offset = "0x781AB0", VA = "0x1807834B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7834C0", Offset = "0x781AC0", VA = "0x1807834C0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7834D0", Offset = "0x781AD0", VA = "0x1807834D0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7832F0", Offset = "0x7818F0", VA = "0x1807832F0")]
		public void CGLJJCPGDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	[DHKIICMHACJ(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private BBGDLMHBFGH PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::JIMNIBINLKA<Entity> LFAIGCEGCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService MAENFGNHNOF;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x77F640", Offset = "0x77DC40", VA = "0x18077F640", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x77F470", Offset = "0x77DA70", VA = "0x18077F470", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77DBA0", VA = "0x18077F5A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x77F6B0", Offset = "0x77DCB0", VA = "0x18077F6B0")]
		private void PKPJEFIPNKC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[DAINLFLPADL(OHEDAGNNHJA.Services)]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	[DHKIICMHACJ(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[CJONPMHNDBN]
		private AMBDMGDKIKJ CFGMGGHPOPA;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private NAKNKCDHKAE JHFOFDKLHHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x3BB4540", Offset = "0x3BB2B40", VA = "0x183BB4540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private PDEALDMPPOP HPBKOFGDFGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x3BB44D0", Offset = "0x3BB2AD0", VA = "0x183BB44D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4590", Offset = "0x3BB2B90", VA = "0x183BB4590", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4520", Offset = "0x3BB2B20", VA = "0x183BB4520", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
[DHKIICMHACJ(typeof(POLFIFOPCGH), new string[] { })]
public class POLFIFOPCGH : IHDPMKBFJKB, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class HLKBBENOBBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public PFKGIHKPIGG services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HLKBBENOBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xDF6CE0", Offset = "0xDF52E0", VA = "0x180DF6CE0")]
		internal void <InitReferences>b__0(GOJCOOFCPOI svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PGOGHAHBMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PFKGIHKPIGG services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PGOGHAHBMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xDFC6F0", Offset = "0xDFACF0", VA = "0x180DFC6F0")]
		internal void <InitExternal>b__0(GKFAMMKGENJ svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI NCKCDMENEMI;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public EHJNMOMNBNJ MMABDIGILBO
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x91B510", Offset = "0x919B10", VA = "0x18091B510", Slot = "4")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DAOJGNOGCID CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x38953E0", Offset = "0x38939E0", VA = "0x1838953E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x3895180", Offset = "0x3893780", VA = "0x183895180", Slot = "5")]
	public void AMMIBONBLOJ(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x3895430", Offset = "0x3893A30", VA = "0x183895430", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x3895560", Offset = "0x3893B60", VA = "0x183895560", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x38951D0", Offset = "0x38937D0", VA = "0x1838951D0", Slot = "8")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x38952B0", Offset = "0x38938B0", VA = "0x1838952B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x356C700", Offset = "0x356AD00", VA = "0x18356C700")]
	private void DMDKCGBKKMK<T>(Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public POLFIFOPCGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class JLKHCEPJJMD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> BGDBKLMEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> DICKNCEHGPP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To EAAIOELEIIM
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
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public JLKHCEPJJMD(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
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
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
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
public class ECAGGMPGMNA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> BGDBKLMEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x4122A90", Offset = "0x4121090", VA = "0x184122A90", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x4122AF0", Offset = "0x41210F0", VA = "0x184122AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x4122A60", Offset = "0x4121060", VA = "0x184122A60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB72D0", Offset = "0x3DB58D0", VA = "0x183DB72D0")]
	public ECAGGMPGMNA(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK, bool JPIIMKIJCFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x4122620", Offset = "0x4120C20", VA = "0x184122620", Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x4122680", Offset = "0x4120C80", VA = "0x184122680", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x41226B0", Offset = "0x4120CB0", VA = "0x1841226B0", Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x4122710", Offset = "0x4120D10", VA = "0x184122710", Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x4122820", Offset = "0x4120E20", VA = "0x184122820", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x41228F0", Offset = "0x4120EF0", VA = "0x1841228F0", Slot = "6")]
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x4122950", Offset = "0x4120F50", VA = "0x184122950", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x4122A00", Offset = "0x4121000", VA = "0x184122A00", Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x41229D0", Offset = "0x4120FD0", VA = "0x1841229D0", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x33545C0", Offset = "0x3352BC0", VA = "0x1833545C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class FFCDMIIFCDI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> BGDBKLMEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> HEONDDEAIBL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBC00", Offset = "0x3DEA200", VA = "0x183DEBC00", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBC50", Offset = "0x3DEA250", VA = "0x183DEBC50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBBC0", Offset = "0x3DEA1C0", VA = "0x183DEBBC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x747120", Offset = "0x745720", VA = "0x180747120", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x3051080", Offset = "0x304F680", VA = "0x183051080")]
	public FFCDMIIFCDI(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB7D0", Offset = "0x3DE9DD0", VA = "0x183DEB7D0", Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB810", Offset = "0x3DE9E10", VA = "0x183DEB810", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB850", Offset = "0x3DE9E50", VA = "0x183DEB850", Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB910", Offset = "0x3DE9F10", VA = "0x183DEB910", Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB9D0", Offset = "0x3DE9FD0", VA = "0x183DEB9D0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBA90", Offset = "0x3DEA090", VA = "0x183DEBA90", Slot = "6")]
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBB00", Offset = "0x3DEA100", VA = "0x183DEBB00", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBB80", Offset = "0x3DEA180", VA = "0x183DEBB80", Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBB40", Offset = "0x3DEA140", VA = "0x183DEBB40", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x32810D0", Offset = "0x327F6D0", VA = "0x1832810D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class PLKKMELCJNO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> JNICKEKIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> BGDBKLMEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To EAAIOELEIIM
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
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public PLKKMELCJNO(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
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
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
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
public static class AONBICHGGPO
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string OFNFGNIMIBA = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string EGDPCOKDCLI = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string HBMKGFOEJIB = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string OGNBEAKBBNF = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string KCCHHEPAILM = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string OENKKBJFKDJ = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string BBOBHFKPFBN = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string CFCFFGKFKLH = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class JNJDOJDJGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class OHIIECPFMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public PFKGIHKPIGG services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OHIIECPFMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xDFBD10", Offset = "0xDFA310", VA = "0x180DFBD10")]
		internal void <InitServices>b__1(GOJCOOFCPOI svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xDFBD70", Offset = "0xDFA370", VA = "0x180DFBD70")]
		internal void <InitServices>b__2(GKFAMMKGENJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7D30", Offset = "0x3BC6330", VA = "0x183BC7D30")]
	public static void GKGBOMAKLPF(this DAOJGNOGCID KHDPJJEDHOA, PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x3082CE0", Offset = "0x30812E0", VA = "0x183082CE0")]
	public static void DMDKCGBKKMK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3082670", Offset = "0x3080C70", VA = "0x183082670")]
	public static void AHHNIKIKLJK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3082980", Offset = "0x3080F80", VA = "0x183082980")]
	public static void CCPIDMDBFCK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3082B30", Offset = "0x3081130", VA = "0x183082B30")]
	public static void CIOGKMMDEJM<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x3082E10", Offset = "0x3081410", VA = "0x183082E10")]
	public static void GBINFPICIFL<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3082810", Offset = "0x3080E10", VA = "0x183082810")]
	public static void AHHNIKIKLJK<T>(IEnumerable<ComponentSystemBase> FLDPOGAHGIJ, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3082D50", Offset = "0x3081350", VA = "0x183082D50")]
	private static void FPKBBHDAJKB<T>(object HKMOJLJDDFO, Action<T> LINLEPEJJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class CKHPHDLLKGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class FODEALDBPLO
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBA10", Offset = "0x3BBA010", VA = "0x183BBBA10")]
	public static void IHIPIEBGOPP(ComponentSystemBase HKMOJLJDDFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class IMDFCCHFDBJ
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool CHICEPFNPLC<T>(ref T IKAMJBDPPHG, ref T LKLEFAIICIC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class DPOIOPICLLK
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class ANAPOMBEABG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ANAPOMBEABG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x390B2B0", Offset = "0x39098B0", VA = "0x18390B2B0")]
	public static string MPADNOHGAEP(Transform HJLACGOIJCA, Transform BIPEBBMCHLH)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[DAINLFLPADL(OHEDAGNNHJA.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x77E4E0", Offset = "0x77CAE0", VA = "0x18077E4E0")]
		public static void FHBOKNJGNHA(this EGGANIJGBAJ GOCENLCAMDB, BDNNNEAGBLH NBBMMINMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x77E820", Offset = "0x77CE20", VA = "0x18077E820")]
		public static void GJBFMOFALMC(this EGGANIJGBAJ GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x77E710", Offset = "0x77CD10", VA = "0x18077E710")]
		public static void FHBOKNJGNHA(this EGGANIJGBAJ GOCENLCAMDB, [Optional] string[] OAFKPBHEEGG, [Optional] string[] HPPLDAEPAIB, [Optional] string[] MBEEDHCOGPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x77E430", Offset = "0x77CA30", VA = "0x18077E430")]
		public static void CBFECCIJPDH(this EGGANIJGBAJ GOCENLCAMDB, params string[] CNILCBCFBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x77EAE0", Offset = "0x77D0E0", VA = "0x18077EAE0")]
		public static void OCPCCONLCEA(this EGGANIJGBAJ GOCENLCAMDB, params string[] CNILCBCFBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x77E230", Offset = "0x77C830", VA = "0x18077E230")]
		private static string[] BNOEEKAHBEB(BDNNNEAGBLH NBBMMINMBNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x77E920", Offset = "0x77CF20", VA = "0x18077E920")]
		private static bool JNCHCOOGHGL(BDNNNEAGBLH NBBMMINMBNH, out string[] LLICCDFNAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
		private static bool DOFLJMDLIDN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class DGAIADJPJMC : MABIIIHNJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo AFDGOJBDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] HNGHLHHNPMK;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x3906480", Offset = "0x3904A80", VA = "0x183906480")]
	public DGAIADJPJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action AFEIMHDHKAG();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x3906440", Offset = "0x3904A40", VA = "0x183906440")]
	public MethodInfo MMJKBBDIIJE(Action PBOHOIMMGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3906290", Offset = "0x3904890", VA = "0x183906290", Slot = "4")]
	public void KOEBKPOFGOP(Type MCLMFJEAHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class HHBNALMADFO : DGAIADJPJMC
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum OKHGAOAKEHH
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x3BC16C0", Offset = "0x3BBFCC0", VA = "0x183BC16C0", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KFJHNIEABJD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1750", Offset = "0x3BBFD50", VA = "0x183BC1750")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x38F3BF0", Offset = "0x38F21F0", VA = "0x1838F3BF0")]
	protected HHBNALMADFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class BEHGAILHHKM : DGAIADJPJMC
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x38F3AD0", Offset = "0x38F20D0", VA = "0x1838F3AD0", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LPKMANFLOAE<T>() where T : EAGFMBINGCM;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x38F3B60", Offset = "0x38F2160", VA = "0x1838F3B60")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x38F3BF0", Offset = "0x38F21F0", VA = "0x1838F3BF0")]
	protected BEHGAILHHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class BNBMEJNGAHN : DGAIADJPJMC
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x38F47C0", Offset = "0x38F2DC0", VA = "0x1838F47C0", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void OIENDPGOGLJ<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x38F4850", Offset = "0x38F2E50", VA = "0x1838F4850")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x38F3BF0", Offset = "0x38F21F0", VA = "0x1838F3BF0")]
	protected BNBMEJNGAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LFNJHBPNCFP
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC700", Offset = "0x3BCAD00", VA = "0x183BCC700")]
	public static Entity EMKLGKDFOCC(this EntityManager LNPEGOPJJGK)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class JDHMCBIDJBH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDF51C0", Offset = "0xDF37C0", VA = "0x180DF51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF7720", Offset = "0xDF5D20", VA = "0x180DF7720", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xDF5340", Offset = "0xDF3940", VA = "0x180DF5340")]
			[DebuggerHidden]
			public JDHMCBIDJBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xDF7550", Offset = "0xDF5B50", VA = "0x180DF7550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xDF76E0", Offset = "0xDF5CE0", VA = "0x180DF76E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xDF7630", Offset = "0xDF5C30", VA = "0x180DF7630", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xDF7630", Offset = "0xDF5C30", VA = "0x180DF7630", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class FIMGPICPCCA : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDF51C0", Offset = "0xDF37C0", VA = "0x180DF51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF5210", Offset = "0xDF3810", VA = "0x180DF5210", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xDF5340", Offset = "0xDF3940", VA = "0x180DF5340")]
			[DebuggerHidden]
			public FIMGPICPCCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xDF5260", Offset = "0xDF3860", VA = "0x180DF5260", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xDF4F20", Offset = "0xDF3520", VA = "0x180DF4F20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xDF52F0", Offset = "0xDF38F0", VA = "0x180DF52F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0xDF51D0", Offset = "0xDF37D0", VA = "0x180DF51D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xDF5110", Offset = "0xDF3710", VA = "0x180DF5110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xDF5110", Offset = "0xDF3710", VA = "0x180DF5110", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class HFCPMNNCMLA : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDF51C0", Offset = "0xDF37C0", VA = "0x180DF51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF6A00", Offset = "0xDF5000", VA = "0x180DF6A00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0xDF5340", Offset = "0xDF3940", VA = "0x180DF5340")]
			[DebuggerHidden]
			public HFCPMNNCMLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xDF6A50", Offset = "0xDF5050", VA = "0x180DF6A50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xDF65F0", Offset = "0xDF4BF0", VA = "0x180DF65F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xDF6B20", Offset = "0xDF5120", VA = "0x180DF6B20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xDF6B70", Offset = "0xDF5170", VA = "0x180DF6B70")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0xDF69C0", Offset = "0xDF4FC0", VA = "0x180DF69C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xDF6920", Offset = "0xDF4F20", VA = "0x180DF6920", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xDF6920", Offset = "0xDF4F20", VA = "0x180DF6920", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3BB70A0", Offset = "0x3BB56A0", VA = "0x183BB70A0")]
		public static Entity ENNBBFIPAAI(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8030", Offset = "0x3BB6630", VA = "0x183BB8030")]
		public static DynamicBuffer<ChildrenData> PHOJADHLOEG(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7D20", Offset = "0x3BB6320", VA = "0x183BB7D20")]
		public static DynamicBuffer<ChildrenData> NCEBDJBCAOA(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7110", Offset = "0x3BB5710", VA = "0x183BB7110")]
		public static NativeArray<Entity> FFMKKHKIFMM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7DB0", Offset = "0x3BB63B0", VA = "0x183BB7DB0")]
		public static bool NIHNKEFEPIA(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Allocator GGLOKAHPEPM, out NativeArray<Entity> FCIOKFNCKIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7240", Offset = "0x3BB5840", VA = "0x183BB7240")]
		public static NativeArray<Entity> GGIOAFCBBAM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6930", Offset = "0x3BB4F30", VA = "0x183BB6930")]
		public static Entity ALAEJPDKHIN(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7750", Offset = "0x3BB5D50", VA = "0x183BB7750")]
		public static int JGMHFKDKOJL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6A60", Offset = "0x3BB5060", VA = "0x183BB6A60")]
		public static void BEBNKDLABJP(NativeArray<Entity> AKGGBDCLIGD, NativeArray<Entity> PAHCBODMCHK, EntityManager LNPEGOPJJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6FF0", Offset = "0x3BB55F0", VA = "0x183BB6FF0")]
		public static int EEJEBBJAJCK(this EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7B40", Offset = "0x3BB6140", VA = "0x183BB7B40")]
		public static bool LLHMMIJNOKL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity EGGHGELDMAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7640", Offset = "0x3BB5C40", VA = "0x183BB7640")]
		public static IEnumerable<Entity> IPMINALCKNM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB80C0", Offset = "0x3BB66C0", VA = "0x183BB80C0")]
		public static bool PKNAJOGAKAI(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity IMDKOHMGEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6DD0", Offset = "0x3BB53D0", VA = "0x183BB6DD0")]
		public static bool DNJHMIGKLJO(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity EOECNBNBJEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7430", Offset = "0x3BB5A30", VA = "0x183BB7430")]
		public static NativeList<Entity> IEFPHBPMHJN(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false, Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7EB0", Offset = "0x3BB64B0", VA = "0x183BB7EB0")]
		public static IEnumerable<Entity> OPILOIOFOMC(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7960", Offset = "0x3BB5F60", VA = "0x183BB7960")]
		public static Entity KCDNPIAEBEL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6E50", Offset = "0x3BB5450", VA = "0x183BB6E50")]
		public static bool DNKFCLNJCJP(this EntityManager LNPEGOPJJGK, Entity EOECNBNBJEC, Entity FNIMMJACBON, out Entity JFHEPJJAOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6D50", Offset = "0x3BB5350", VA = "0x183BB6D50")]
		internal static void DLBLODCGEAA(EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7860", Offset = "0x3BB5E60", VA = "0x183BB7860")]
		internal static void JNFCNFLJFMH(EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3BB73A0", Offset = "0x3BB59A0", VA = "0x183BB73A0")]
		[IteratorStateMachine(typeof(JDHMCBIDJBH))]
		private static IEnumerable<Entity> GHHGKCNHNOL(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6CC0", Offset = "0x3BB52C0", VA = "0x183BB6CC0")]
		[IteratorStateMachine(typeof(FIMGPICPCCA))]
		private static IEnumerable<Entity> CAEKPACEOBI(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7CA0", Offset = "0x3BB62A0", VA = "0x183BB7CA0")]
		[IteratorStateMachine(typeof(HFCPMNNCMLA))]
		private static IEnumerable<Entity> MMDPLCCIDPJ(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7A60", Offset = "0x3BB6060", VA = "0x183BB7A60")]
		private static bool KLIFFHDNCBE(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity EGGHGELDMAI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[DHKIICMHACJ(typeof(OBPBNOCJFPI), new string[] { })]
public class KKIMDJCAADC : OBPBNOCJFPI, IHDPMKBFJKB, FHBPEIGBJBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PFKGIHKPIGG GOCENLCAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private KDGBBCMLLMM JBGBBDABBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EOPMPEPMNDF IJJOMIGFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private OPAKLFEDMAA BFIDBOCPJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private BBGDLMHBFGH PJBANBJAEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private CPFCFGLKHDP PLNODCMOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private KBNPAGHEBHB NGJACCCAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private GIHCPFBMAPF KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private LDMOCILFLPC BLNKNMICHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private OHNIAMAPMFF FECNCNEDJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private MJFDNFOLGPA IFBGMBPKKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private LAMNHLNDGKO JLIPNAINFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private OOFBFFNNIPK JDNOCMPDBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private NOFMFNFCABJ FNHCMJBPAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private PPLBOFNBIPJ ACELEELOEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private PNINELHDCOE OMJELDHKGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private ALNELIOAEHM HBIMMJCLEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private PJCBAJNDEOE FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public PFKGIHKPIGG AEDPBOIFJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public KMGAJCBNKGB KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LEDNJPMFMJI CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public KDGBBCMLLMM CABGMKCDNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public EOPMPEPMNDF DJPIGNBFNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CLJEHOFLHAA FPLKCFFBBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public OPAKLFEDMAA MLMCGKJNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BBGDLMHBFGH MHIMBKNCMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CPFCFGLKHDP FNJJAECIOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x687C20", Offset = "0x686220", VA = "0x180687C20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public KBNPAGHEBHB IHEEMHLFMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x683BB0", Offset = "0x6821B0", VA = "0x180683BB0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GIHCPFBMAPF DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x810200", Offset = "0x80E800", VA = "0x180810200", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LDMOCILFLPC EPOBBKNLLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x810210", Offset = "0x80E810", VA = "0x180810210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OHNIAMAPMFF PBMDILPDIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x708FA0", Offset = "0x7075A0", VA = "0x180708FA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MJFDNFOLGPA GLKPOKJAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x792CA0", Offset = "0x7912A0", VA = "0x180792CA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LAMNHLNDGKO BPLOKGOONKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x83C540", Offset = "0x83AB40", VA = "0x18083C540", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OOFBFFNNIPK CPCPDBAFFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8F0", Offset = "0x7E8EF0", VA = "0x1807EA8F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public NOFMFNFCABJ MIMHEAODKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x822190", Offset = "0x820790", VA = "0x180822190", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public PPLBOFNBIPJ JHBHHNPLABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x744A80", Offset = "0x743080", VA = "0x180744A80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PNINELHDCOE EFIOEIEIDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x810220", Offset = "0x80E820", VA = "0x180810220", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public ALNELIOAEHM NKMKGOEEINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x739C50", Offset = "0x738250", VA = "0x180739C50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PJCBAJNDEOE AOLKGNGHNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x739D10", Offset = "0x738310", VA = "0x180739D10", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public EHJNMOMNBNJ MMABDIGILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x677270", Offset = "0x675870", VA = "0x180677270", Slot = "21")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8E20", Offset = "0x3BC7420", VA = "0x183BC8E20", Slot = "22")]
	public void AMMIBONBLOJ(PFKGIHKPIGG DDAOLJGIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB120", Offset = "0x2BB9720", VA = "0x182BBB120", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9110", Offset = "0x3BC7710", VA = "0x183BC9110", Slot = "23")]
	public void GAAJOMGCPID(PFKGIHKPIGG DDAOLJGIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KKIMDJCAADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class ANJCGBDFFEP : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class IIGEGGLKJBL : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public ANJCGBDFFEP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x777490", Offset = "0x775A90", VA = "0x180777490", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7774E0", Offset = "0x775AE0", VA = "0x1807774E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
		[DebuggerHidden]
		public IIGEGGLKJBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x777320", Offset = "0x775920", VA = "0x180777320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7774A0", Offset = "0x775AA0", VA = "0x1807774A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong HEGHHKAAEFO = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong ILPNOGJHDFI = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int OJMBGJLMNCA = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int FLBMEKAPEBD = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int NHGHAJOBMJI = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int LNHKAAIGCNL = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> HIECLBKPLFM;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA610", Offset = "0x6B8C10", VA = "0x1806BA610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int FMPENOLGNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x83C6A0", Offset = "0x83ACA0", VA = "0x18083C6A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x83C690", Offset = "0x83AC90", VA = "0x18083C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x38EFD10", Offset = "0x38EE310", VA = "0x1838EFD10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x38EF880", Offset = "0x38EDE80", VA = "0x1838EF880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x38F0490", Offset = "0x38EEA90", VA = "0x1838F0490")]
	public ANJCGBDFFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x38F0510", Offset = "0x38EEB10", VA = "0x1838F0510")]
	public ANJCGBDFFEP(int OBNABJCFIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x38F0140", Offset = "0x38EE740", VA = "0x1838F0140")]
	public bool OCOPPDHLOLD(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x38EF700", Offset = "0x38EDD00", VA = "0x1838EF700")]
	public bool AOBMBBOELGH(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x38EF7F0", Offset = "0x38EDDF0", VA = "0x1838EF7F0")]
	public bool BHHAMMMPKAB(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x38EF870", Offset = "0x38EDE70", VA = "0x1838EF870")]
	public bool DEHMHJNDOKD(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x38F0370", Offset = "0x38EE970", VA = "0x1838F0370")]
	public void PHJEJOHIMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x38F0050", Offset = "0x38EE650", VA = "0x1838F0050")]
	public void OAFINNBIOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x38EFE20", Offset = "0x38EE420", VA = "0x1838EFE20")]
	public void KMNEKDAGPNL(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x38F0270", Offset = "0x38EE870", VA = "0x1838F0270")]
	public void PGHHBKOCHPM(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x38F0400", Offset = "0x38EEA00", VA = "0x1838F0400")]
	public bool PLBNCIKFCHN(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x38EFA30", Offset = "0x38EE030", VA = "0x1838EFA30")]
	public void FFDPJHIJPBB(int ADDILPEFEHP, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x38EFB50", Offset = "0x38EE150", VA = "0x1838EFB50")]
	public void GCEHDHPKJFH(int PHEBOHLEEKJ, int KCHHIMPOGLA, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x38EFF80", Offset = "0x38EE580", VA = "0x1838EFF80")]
	public int MFMCNFFMIAP(int FPLNDBJJHMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x38EFF10", Offset = "0x38EE510", VA = "0x1838EFF10")]
	public int MFMCNFFMIAP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x38F0220", Offset = "0x38EE820", VA = "0x1838F0220")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x38EFDB0", Offset = "0x38EE3B0", VA = "0x1838EFDB0", Slot = "4")]
	[IteratorStateMachine(typeof(IIGEGGLKJBL))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x38EFDB0", Offset = "0x38EE3B0", VA = "0x1838EFDB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class GAHGEMOFMBF<T> : global::KCEDBLNOIMG<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::LMGKHNILJAI<T> LJAGGIBNJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::IDGNLLEKOLE<T> OCPLBEBMNGD;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x23564F0", Offset = "0x2354AF0", VA = "0x1823564F0")]
	public GAHGEMOFMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x37C0070", Offset = "0x37BE670", VA = "0x1837C0070")]
	public GAHGEMOFMBF(global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x37BF980", Offset = "0x37BDF80", VA = "0x1837BF980", Slot = "11")]
	public override T FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x37BFD20", Offset = "0x37BE320", VA = "0x1837BFD20", Slot = "12")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, T MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class AMKGJAKJKII
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x27D5790", Offset = "0x27D3D90", VA = "0x1827D5790")]
	public static HDFAPEIIIAK KOEBKPOFGOP<T>(this MPPFNHNPBFD KECMGAIBBMH, global::AJFAFKBPGAH<T> NBODBMLPNJA, global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD) where T : struct
	{
		return default(HDFAPEIIIAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class NAJKGJOKCEO<T> : global::GAHGEMOFMBF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x3164400", Offset = "0x3162A00", VA = "0x183164400")]
	public NAJKGJOKCEO(T MJBMGGEOKEA, T CGFBNEMNBGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class GFHMKIENFJL<T> : global::KCEDBLNOIMG<T> where T : struct, EAGFMBINGCM
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x37D0630", Offset = "0x37CEC30", VA = "0x1837D0630", Slot = "11")]
	public override T FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x37D06D0", Offset = "0x37CECD0", VA = "0x1837D06D0", Slot = "12")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2354870", Offset = "0x2352E70", VA = "0x182354870")]
	public GFHMKIENFJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class LCCBEJEEMAM : DJICGFHHPAN
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type BMIHAJLMCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA, in MMINGLJLPAL MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, in COGGJKLIPPL MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void HEIGEPEFDPE(PBIBIEGBJNI ACHCPHHHGBA, OBLHLJIIBJE GIBODALIGFC, [Optional] object JOOJGLPIMBB);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	protected LCCBEJEEMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class KCEDBLNOIMG<T> : LCCBEJEEMAM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type BMIHAJLMCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0E80", Offset = "0x2C9F480", VA = "0x182CA0E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, T MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E970", Offset = "0x2C9CF70", VA = "0x182C9E970", Slot = "8")]
	public override void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA, in MMINGLJLPAL BIPEBBMCHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA04E0", Offset = "0x2C9EAE0", VA = "0x182CA04E0", Slot = "9")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, in COGGJKLIPPL CELBLIIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F390", Offset = "0x2C9D990", VA = "0x182C9F390", Slot = "10")]
	public override void HEIGEPEFDPE(PBIBIEGBJNI ACHCPHHHGBA, OBLHLJIIBJE GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x229A9F0", Offset = "0x2298FF0", VA = "0x18229A9F0")]
	protected KCEDBLNOIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class PIEPAPFAJFB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class HNDIAFGAEEK
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class EKLMHDPAPNB<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public EKLMHDPAPNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x36CCE00", Offset = "0x36CB400", VA = "0x1836CCE00")]
			internal void <RegisterFixedString>b__0(PBIBIEGBJNI p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x36CD110", Offset = "0x36CB710", VA = "0x1836CD110")]
			internal T <RegisterFixedString>b__1(PBIBIEGBJNI p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xDF6D40", Offset = "0xDF5340", VA = "0x180DF6D40")]
		public static void KJFBPHINCGB(KBKEFPAEKOK HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x3531450", Offset = "0x352FA50", VA = "0x183531450")]
		private static void LJOJFHNAOBP<T>(KBKEFPAEKOK HLCNJFHNKCM, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x35313C0", Offset = "0x352F9C0", VA = "0x1835313C0")]
		private static void LJDILEGBMIE<T>(PBIBIEGBJNI GODDPHBMKAO, T HIGLPPEBKMI, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3530D70", Offset = "0x352F370", VA = "0x183530D70")]
		private static T CMPGEGHCGDF<T>(PBIBIEGBJNI GODDPHBMKAO, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public HNDIAFGAEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class NDHKPLKIAAG : HHBNALMADFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KBKEFPAEKOK HLCNJFHNKCM;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x3532AF0", Offset = "0x35310F0", VA = "0x183532AF0", Slot = "6")]
		public override void KFJHNIEABJD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xDFAAC0", Offset = "0xDF90C0", VA = "0x180DFAAC0")]
		public static void IDIBCAFNFON(KBKEFPAEKOK HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xDFAB70", Offset = "0xDF9170", VA = "0x180DFAB70")]
		public NDHKPLKIAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x3891AF0", Offset = "0x38900F0", VA = "0x183891AF0")]
	public static void KOJBMHAKCCN(KBKEFPAEKOK HLCNJFHNKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x356AE70", Offset = "0x3569470", VA = "0x18356AE70")]
	public static void AGCILKOHDFN<T>(KBKEFPAEKOK HLCNJFHNKCM, global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x356AF00", Offset = "0x3569500", VA = "0x18356AF00")]
	public static void JAHHELJNLIM<T>(KBKEFPAEKOK IOHHLKEMCKO) where T : struct, EAGFMBINGCM
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
public interface KBKEFPAEKOK : global::PAHDPONDGID<KBKEFPAEKOK>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOEBKPOFGOP(Type MCLMFJEAHEC, DJICGFHHPAN IOHHLKEMCKO);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DJEIEOEOGPA(Type MCLMFJEAHEC, out DJICGFHHPAN IOHHLKEMCKO);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class IKIPKDHFELF
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5800", Offset = "0x3BC3E00", VA = "0x183BC5800")]
	public static void KOEBKPOFGOP(this KBKEFPAEKOK AGMOENMHCDB, DJICGFHHPAN IOHHLKEMCKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DHKIICMHACJ(typeof(MPPFNHNPBFD), new string[] { })]
public sealed class ICPDMGPMBFO : MPPFNHNPBFD, global::PAHDPONDGID<MPPFNHNPBFD>, BGDEOEAAJCH, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<HDFAPEIIIAK, DJICGFHHPAN> HLCNJFHNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private KBKEFPAEKOK DMDMFAJCNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private NHGGIKDMDCJ KECMGAIBBMH;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool ACEOAMAFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x84A610", Offset = "0x848C10", VA = "0x18084A610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x84A6A0", Offset = "0x848CA0", VA = "0x18084A6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4EB0", Offset = "0x3BC34B0", VA = "0x183BC4EB0")]
	public ICPDMGPMBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4DF0", Offset = "0x3BC33F0", VA = "0x183BC4DF0")]
	public ICPDMGPMBFO(Dictionary<HDFAPEIIIAK, DJICGFHHPAN> HLCNJFHNKCM, bool ONKJPFNEHEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4B50", Offset = "0x3BC3150", VA = "0x183BC4B50", Slot = "7")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4D20", Offset = "0x3BC3320", VA = "0x183BC4D20", Slot = "8")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4DA0", Offset = "0x3BC33A0", VA = "0x183BC4DA0", Slot = "9")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4A80", Offset = "0x3BC3080", VA = "0x183BC4A80", Slot = "4")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO NBODBMLPNJA)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4BB0", Offset = "0x3BC31B0", VA = "0x183BC4BB0", Slot = "5")]
	public void KOEBKPOFGOP(HDFAPEIIIAK CBBOJGIJLHN, DJICGFHHPAN IOHHLKEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC46B0", Offset = "0x3BC2CB0", VA = "0x183BC46B0")]
	[Conditional("DEBUG_BUILD")]
	private void DEKFONDPGOO(HDFAPEIIIAK CBBOJGIJLHN, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BC47F0", Offset = "0x3BC2DF0", VA = "0x183BC47F0", Slot = "6")]
	public bool DJEIEOEOGPA(HDFAPEIIIAK CBBOJGIJLHN, out DJICGFHHPAN IOHHLKEMCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x3BC49A0", Offset = "0x3BC2FA0", VA = "0x183BC49A0", Slot = "10")]
	public MPPFNHNPBFD FJOHKHGHCLH()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[DHKIICMHACJ(typeof(KBKEFPAEKOK), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.TypeSerializer)]
	public sealed class TypeSerializerService : BGDEOEAAJCH, KBKEFPAEKOK, global::PAHDPONDGID<KBKEFPAEKOK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, DJICGFHHPAN> HLCNJFHNKCM;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool ACEOAMAFBJM
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x7834B0", Offset = "0x781AB0", VA = "0x1807834B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x789250", Offset = "0x787850", VA = "0x180789250")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x789190", Offset = "0x787790", VA = "0x180789190")]
		public TypeSerializerService(Dictionary<Type, DJICGFHHPAN> HLCNJFHNKCM, bool ONKJPFNEHEJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x788FC0", Offset = "0x7875C0", VA = "0x180788FC0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x789020", Offset = "0x787620", VA = "0x180789020", Slot = "5")]
		public void KOEBKPOFGOP(Type MCLMFJEAHEC, DJICGFHHPAN IOHHLKEMCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x788E00", Offset = "0x787400", VA = "0x180788E00", Slot = "6")]
		public bool DJEIEOEOGPA(Type MCLMFJEAHEC, out DJICGFHHPAN IOHHLKEMCKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x788EE0", Offset = "0x7874E0", VA = "0x180788EE0", Slot = "7")]
		public KBKEFPAEKOK FJOHKHGHCLH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DHKIICMHACJ(typeof(ALHDGPMCOFE), new string[] { })]
internal sealed class LKFFJHHJMGM : ALHDGPMCOFE, BGDEOEAAJCH, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<HDFAPEIIIAK, BKEHBCJJAII> CLLDFCAFGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private NHGGIKDMDCJ KECMGAIBBMH;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x387E0F0", Offset = "0x387C6F0", VA = "0x18387E0F0", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x387E340", Offset = "0x387C940", VA = "0x18387E340", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x387E140", Offset = "0x387C740", VA = "0x18387E140", Slot = "4")]
	public void KOEBKPOFGOP(HDFAPEIIIAK DPEKNLAIHMP, Type LBKEDMNOBKJ, BKEHBCJJAII FHJGMKKJIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x387E080", Offset = "0x387C680", VA = "0x18387E080", Slot = "5")]
	public bool ECEDBMAJBKL(HDFAPEIIIAK DPEKNLAIHMP, out BKEHBCJJAII FHJGMKKJIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x387E1B0", Offset = "0x387C7B0", VA = "0x18387E1B0")]
	[Conditional("DEBUG_BUILD")]
	private void MBKFKAGMDEF(HDFAPEIIIAK DPEKNLAIHMP, Type LBKEDMNOBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x387E3A0", Offset = "0x387C9A0", VA = "0x18387E3A0")]
	public LKFFJHHJMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DHKIICMHACJ(typeof(LPFLGAKJLOL), new string[] { })]
internal sealed class DOOEJMHKPCL : LPFLGAKJLOL, GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly ANJCGBDFFEP OKBJOHPKBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<COEEIJJLOPG, int> PIMGFKEJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> NHLDHGBMFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[CJONPMHNDBN]
	private NHGGIKDMDCJ KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[CJONPMHNDBN]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int IPNPPMJLPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x3909000", Offset = "0x3907600", VA = "0x183909000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x731C90", Offset = "0x730290", VA = "0x180731C90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x731D10", Offset = "0x730310", VA = "0x180731D10", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x3909100", Offset = "0x3907700", VA = "0x183909100", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3909770", Offset = "0x3907D70", VA = "0x183909770", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x3909050", Offset = "0x3907650", VA = "0x183909050", Slot = "8")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3909240", Offset = "0x3907840", VA = "0x183909240")]
	private void HFOMJKPIOGJ(NIALADIPDNC KLCGNDEDAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3909630", Offset = "0x3907C30", VA = "0x183909630", Slot = "4")]
	public bool JNCBJIFACNJ(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x39092E0", Offset = "0x39078E0", VA = "0x1839092E0", Slot = "5")]
	public void JIDNIABLPGK(COEEIJJLOPG FBIBIHJENAB, Span<HDFAPEIIIAK> KECMGAIBBMH, bool DAKGDGBCFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3909100", Offset = "0x3907700", VA = "0x183909100", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x39097F0", Offset = "0x3907DF0", VA = "0x1839097F0")]
	public DOOEJMHKPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class ELNLJGFBCBB
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1E80", Offset = "0x3BB0480", VA = "0x183BB1E80")]
	public static void HKNPDKKGIDG(this PBIBIEGBJNI ACHCPHHHGBA, ReadOnlyMemory<byte> JLNOCAAFAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x331ABA0", Offset = "0x33191A0", VA = "0x18331ABA0")]
	public static void ILGFNCIGIKC<T>(this PBIBIEGBJNI ACHCPHHHGBA, in T MAKFNMHIJIF) where T : struct, EAGFMBINGCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x331ACD0", Offset = "0x33192D0", VA = "0x18331ACD0")]
	public static T KOHFLBNBAKA<T>(this PBIBIEGBJNI ACHCPHHHGBA) where T : struct, EAGFMBINGCM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2020", Offset = "0x3BB0620", VA = "0x183BB2020")]
	public static void ILGFNCIGIKC(this PBIBIEGBJNI ACHCPHHHGBA, EFPCBBNPEJA OCIJCOOAIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1CA0", Offset = "0x3BB02A0", VA = "0x183BB1CA0")]
	public static EFPCBBNPEJA COPHGOPBOGK(this PBIBIEGBJNI ACHCPHHHGBA)
	{
		return default(EFPCBBNPEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1CD0", Offset = "0x3BB02D0", VA = "0x183BB1CD0")]
	public static void FJALIIAHOON(this PBIBIEGBJNI IEEJJNDPOHK, uint OFIFAJJCPOM, bool CNMIEEKMKKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1F00", Offset = "0x3BB0500", VA = "0x183BB1F00")]
	public static uint IIGNLHPOOCO(this PBIBIEGBJNI ILDGEJAOOHJ, bool CNMIEEKMKKP = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class FEAKBMJJFCD
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class HIBKNIEPIFB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public HIBKNIEPIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x46DF360", Offset = "0x46DD960", VA = "0x1846DF360")]
		internal void <GetByteEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x46DF3D0", Offset = "0x46DD9D0", VA = "0x1846DF3D0")]
		internal T <GetByteEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class PCCDFINJLEN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public PCCDFINJLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x47D58A0", Offset = "0x47D3EA0", VA = "0x1847D58A0")]
		internal void <GetSByteEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x47D5910", Offset = "0x47D3F10", VA = "0x1847D5910")]
		internal T <GetSByteEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class EAMNBHDMCEA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public EAMNBHDMCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BE90", Offset = "0x3E9A490", VA = "0x183E9BE90")]
		internal void <GetShortEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BF00", Offset = "0x3E9A500", VA = "0x183E9BF00")]
		internal T <GetShortEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class LCNHEAMHEFH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public LCNHEAMHEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C162D0", Offset = "0x2C148D0", VA = "0x182C162D0")]
		internal void <GetUShortEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C16340", Offset = "0x2C14940", VA = "0x182C16340")]
		internal T <GetUShortEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class IEKAILJPAAE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public IEKAILJPAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x35642A0", Offset = "0x35628A0", VA = "0x1835642A0")]
		internal void <GetIntEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x3564300", Offset = "0x3562900", VA = "0x183564300")]
		internal T <GetIntEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class BFAHAGAOIKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public BFAHAGAOIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x4BCD1E0", Offset = "0x4BCB7E0", VA = "0x184BCD1E0")]
		internal void <GetUIntEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x4BCD240", Offset = "0x4BCB840", VA = "0x184BCD240")]
		internal T <GetUIntEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3594BA0", Offset = "0x35931A0", VA = "0x183594BA0")]
	public static void KKCCEHODGOG<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x35947B0", Offset = "0x3592DB0", VA = "0x1835947B0")]
	private static void BCAKEPLEAFC<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x35947B0", Offset = "0x3592DB0", VA = "0x1835947B0")]
	private static void CJKCABOBDHE<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3594900", Offset = "0x3592F00", VA = "0x183594900")]
	private static void BOEFFPNCILI<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x3594900", Offset = "0x3592F00", VA = "0x183594900")]
	private static void CHFIDGBIHPM<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x3594A50", Offset = "0x3593050", VA = "0x183594A50")]
	private static void JPPDODNEEBF<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x3594A50", Offset = "0x3593050", VA = "0x183594A50")]
	private static void GNJPHPIMHDC<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class PGEKFEGMJML : EKPBGJEDCGJ, GKFAMMKGENJ
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x3891A90", Offset = "0x3890090", VA = "0x183891A90", Slot = "4")]
	private void PDFHPPGKKGO(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DAOLMNILPOB(MPPFNHNPBFD KECMGAIBBMH);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	protected PGEKFEGMJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[AOABIAIICLA(typeof(LocalPoseData))]
public sealed class PEFMKJDPMAB : PGEKFEGMJML
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x3891840", Offset = "0x388FE40", VA = "0x183891840", Slot = "5")]
	protected override void DAOLMNILPOB(MPPFNHNPBFD KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public PEFMKJDPMAB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class CopyAuthorityToEntity : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery BPJPGLJIBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery HDFADBKIHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery DGNOJLLLEJB;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x3901370", Offset = "0x38FF970", VA = "0x183901370", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x39013E0", Offset = "0x38FF9E0", VA = "0x1839013E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x3901560", Offset = "0x38FFB60", VA = "0x183901560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x3901530", Offset = "0x38FFB30", VA = "0x183901530", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x3900E20", Offset = "0x38FF420", VA = "0x183900E20")]
		private void IPPKHIAIAFG(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3900710", Offset = "0x38FED10", VA = "0x183900710")]
		private void FCEADFGDAAK(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x39008B0", Offset = "0x38FEEB0", VA = "0x1839008B0")]
		private void GIDIAEAGDIP(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x3900C70", Offset = "0x38FF270", VA = "0x183900C70")]
		private void HJNCEEIOJEE(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x3901160", Offset = "0x38FF760", VA = "0x183901160")]
		private void KKMGJECMABK(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3900B90", Offset = "0x38FF190", VA = "0x183900B90")]
		private void HCNOPLDPFLM(NIALADIPDNC KLCGNDEDAPD, int NPMIJOEHCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class JHDMPEEDJKG : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7850", Offset = "0x3BC5E50", VA = "0x183BC7850", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC78A0", Offset = "0x3BC5EA0", VA = "0x183BC78A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7960", Offset = "0x3BC5F60", VA = "0x183BC7960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7270", Offset = "0x3BC5870", VA = "0x183BC7270")]
	private void MAOANDBBNAO(NativeArray<Entity> IJBCECFNJIL, NativeList<Entity> PEGLPLKBCDI, ComponentDataFromEntity<GNKPBKJDEDC> NBLHJNLELMG, BufferFromEntity<ChildrenData> KCJJJGGDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public JHDMPEEDJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class IJDHPLINHIO : ParentSystemBase<AuthoredParentData, OAGDIIKIAEI, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5490", Offset = "0x3BC3A90", VA = "0x183BC5490", Slot = "14")]
	protected override EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x826070", Offset = "0x824670", VA = "0x180826070", Slot = "15")]
	protected override EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5510", Offset = "0x3BC3B10", VA = "0x183BC5510", Slot = "16")]
	protected override EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3BC54D0", Offset = "0x3BC3AD0", VA = "0x183BC54D0", Slot = "17")]
	protected override EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5590", Offset = "0x3BC3B90", VA = "0x183BC5590")]
	public IJDHPLINHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5550", Offset = "0x3BC3B50", VA = "0x183BC5550", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class LGCEFDJNIDB : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object BKPBFIALDHI;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC800", Offset = "0x3BCAE00", VA = "0x183BCC800", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC880", Offset = "0x3BCAE80", VA = "0x183BCC880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC920", Offset = "0x3BCAF20", VA = "0x183BCC920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public LGCEFDJNIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class MMHPBCMMDDP : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object BKPBFIALDHI;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x387FB90", Offset = "0x387E190", VA = "0x18387FB90", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x387FC10", Offset = "0x387E210", VA = "0x18387FC10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x387FCB0", Offset = "0x387E2B0", VA = "0x18387FCB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public MMHPBCMMDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct JMGMKGGOCKH : ISystemStateBufferElementData, IBufferElementData, IEquatable<JMGMKGGOCKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public FJDOFGNFPLL ODMNDKFKJHN;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAF80", Offset = "0x3BB9580", VA = "0x183BBAF80", Slot = "4")]
	public bool Equals(JMGMKGGOCKH OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890")]
	public static JMGMKGGOCKH DGKBAOBECFH(FJDOFGNFPLL ODMNDKFKJHN)
	{
		return default(JMGMKGGOCKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct EHKAPCLDEFB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public FJDOFGNFPLL ODMNDKFKJHN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890")]
	public static EHKAPCLDEFB DGKBAOBECFH(FJDOFGNFPLL ODMNDKFKJHN)
	{
		return default(EHKAPCLDEFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class BBOKDLJHKBF : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x38F34A0", Offset = "0x38F1AA0", VA = "0x1838F34A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x38F3630", Offset = "0x38F1C30", VA = "0x1838F3630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40")]
	protected BBOKDLJHKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[LLNAOBNNFAO]
internal abstract class GCOOCIPHEME : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected PJCBAJNDEOE FHCKPPNILHO;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD770", Offset = "0x3BBBD70", VA = "0x183BBD770", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD270", Offset = "0x3BBB870", VA = "0x183BBD270")]
	protected void JDDDLPCEGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD4F0", Offset = "0x3BBBAF0", VA = "0x183BBD4F0")]
	protected void KNHGDJDEBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD200", Offset = "0x3BBB800", VA = "0x183BBD200")]
	protected OKKOFBJCFMA BKKBIDPJMNE()
	{
		return default(OKKOFBJCFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	protected GCOOCIPHEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class DODBJDMKJMM : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x3908DD0", Offset = "0x39073D0", VA = "0x183908DD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x3908F60", Offset = "0x3907560", VA = "0x183908F60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40")]
	protected DODBJDMKJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class NHLBFIGLPKI : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x38818A0", Offset = "0x387FEA0", VA = "0x1838818A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x38819B0", Offset = "0x387FFB0", VA = "0x1838819B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40")]
	protected NHLBFIGLPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class JBMPGJMFCBC : BBOKDLJHKBF
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6CD0", Offset = "0x3BC52D0", VA = "0x183BC6CD0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x38EC720", Offset = "0x38EAD20", VA = "0x1838EC720")]
	public JBMPGJMFCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class KHHLMNODHLI : DODBJDMKJMM
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8DB0", Offset = "0x3BC73B0", VA = "0x183BC8DB0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x38EC720", Offset = "0x38EAD20", VA = "0x1838EC720")]
	public KHHLMNODHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class PMPEACMNAGO : NHLBFIGLPKI
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x38944D0", Offset = "0x3892AD0", VA = "0x1838944D0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40")]
	public PMPEACMNAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class BABAHODAHPM : BBOKDLJHKBF
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x38F2660", Offset = "0x38F0C60", VA = "0x1838F2660", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40")]
	public BABAHODAHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class LAMGADAHOMG : DODBJDMKJMM
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBEC0", Offset = "0x3BCA4C0", VA = "0x183BCBEC0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x38EC720", Offset = "0x38EAD20", VA = "0x1838EC720")]
	public LAMGADAHOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class AAIIACNJPGJ : NHLBFIGLPKI
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override CNMBMIEJNOJ PMEPGKBHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x38EC6B0", Offset = "0x38EACB0", VA = "0x1838EC6B0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x38EC720", Offset = "0x38EAD20", VA = "0x1838EC720")]
	public AAIIACNJPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880040", VA = "0x183881A40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct KBHFCHNLPCI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct MPPHEKPENIM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct IPPLJNDDLKP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct CNMBMIEJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType GLAGKBEAACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType FCMEFMFMNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object HKLDIENGNNB;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x38F9040", Offset = "0x38F7640", VA = "0x1838F9040")]
	public CNMBMIEJNOJ(ComponentType GLAGKBEAACJ, ComponentType FCMEFMFMNGP, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x3A88040", Offset = "0x3A86640", VA = "0x183A88040")]
	public static CNMBMIEJNOJ OOFEPMABPOC<TReq, TTag>(object HKLDIENGNNB)
	{
		return default(CNMBMIEJNOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class BAGKFHPBFNK
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string JAMICMJCHFL = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string GNEHEBCHIDN = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly CNMBMIEJNOJ JHBHHNPLABE;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly CNMBMIEJNOJ FDLFIPOJPIC;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct FJDOFGNFPLL : global::LAJFKAIBBBL<FJDOFGNFPLL>, LDGEBNEMAMI, IEquatable<FJDOFGNFPLL>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int DNFPKCNMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x794540", Offset = "0x792B40", VA = "0x180794540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C30", Offset = "0x7F2230", VA = "0x1807F3C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAF40", Offset = "0x3BB9540", VA = "0x183BBAF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAF80", Offset = "0x3BB9580", VA = "0x183BBAF80", Slot = "8")]
	public bool Equals(FJDOFGNFPLL OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAFD0", Offset = "0x3BB95D0", VA = "0x183BBAFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[LLNAOBNNFAO]
	[DAINLFLPADL(OHEDAGNNHJA.Connectables)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class UpdateConnectableVisuals : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct OJMJLDJJMBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public FJDOFGNFPLL ODMNDKFKJHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 EINGNKDKDHC;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xDFBDF0", Offset = "0xDFA3F0", VA = "0x180DFBDF0")]
			public OJMJLDJJMBJ(FJDOFGNFPLL ODMNDKFKJHN, float3 EINGNKDKDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xDFBDD0", Offset = "0xDFA3D0", VA = "0x180DFBDD0")]
			public void EPGCMDKMDAG(out FJDOFGNFPLL ODMNDKFKJHN, out float3 EINGNKDKDHC)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct OEDKAKBOMEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<OJMJLDJJMBJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
			public OEDKAKBOMEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<EHKAPCLDEFB> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct ECPCHCBBNGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<OJMJLDJJMBJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
			public ECPCHCBBNGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<JMGMKGGOCKH> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct DMHEGDICODD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<OJMJLDJJMBJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
			public DMHEGDICODD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in JDMLIIAJBHN com, in DynamicBuffer<JMGMKGGOCKH> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct AOBEIBAGNKI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct AEECEPAILCF
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct OBMMHNACNCO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime CFFNNMIAJGJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<EHKAPCLDEFB>.Runtime IADMMFIFPDN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ILNLICHOGBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<EHKAPCLDEFB> HFDANBCEBAH;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0xDF1390", Offset = "0xDEF990", VA = "0x180DF1390")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0xDF12D0", Offset = "0xDEF8D0", VA = "0x180DF12D0")]
				public OBMMHNACNCO BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(OBMMHNACNCO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals DPMMPHPBAHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<OJMJLDJJMBJ> ACLENHAHHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private AEECEPAILCF OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AEECEPAILCF.OBMMHNACNCO* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xDF1D90", Offset = "0xDF0390", VA = "0x180DF1D90")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, WorldPoseData EMJPNBNIJPK, in DynamicBuffer<EHKAPCLDEFB> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xDF2180", Offset = "0xDF0780", VA = "0x180DF2180", Slot = "5")]
			public void ReadFromDisplayClass(ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0xDF21B0", Offset = "0xDF07B0", VA = "0x180DF21B0", Slot = "6")]
			public void WriteToDisplayClass(ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xDF1C70", Offset = "0xDF0270", VA = "0x180DF1C70", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xDF2040", Offset = "0xDF0640", VA = "0x180DF2040")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref AEECEPAILCF.OBMMHNACNCO GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xDF1D50", Offset = "0xDF0350", VA = "0x180DF1D50")]
			public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK, ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xDF1FD0", Offset = "0xDF05D0", VA = "0x180DF1FD0")]
			public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct ENOHPOFKECN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct FEIDDCFFHHN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct LCKHAFEMDLK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime CFFNNMIAJGJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JMGMKGGOCKH>.Runtime IADMMFIFPDN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ILNLICHOGBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<JMGMKGGOCKH> HFDANBCEBAH;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0xDF4780", Offset = "0xDF2D80", VA = "0x180DF4780")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0xDF46E0", Offset = "0xDF2CE0", VA = "0x180DF46E0")]
				public LCKHAFEMDLK BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(LCKHAFEMDLK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<OJMJLDJJMBJ> ACLENHAHHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private FEIDDCFFHHN OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FEIDDCFFHHN.LCKHAFEMDLK* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDF4260", Offset = "0xDF2860", VA = "0x180DF4260")]
			internal void KFDLFOBMEJP(in WorldPoseData EMJPNBNIJPK, in DynamicBuffer<JMGMKGGOCKH> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x7743F0", Offset = "0x7729F0", VA = "0x1807743F0", Slot = "5")]
			public void ReadFromDisplayClass(ref ECPCHCBBNGH IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xDF40F0", Offset = "0xDF26F0", VA = "0x180DF40F0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0xDF4370", Offset = "0xDF2970", VA = "0x180DF4370")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref FEIDDCFFHHN.LCKHAFEMDLK GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0xDF41C0", Offset = "0xDF27C0", VA = "0x180DF41C0")]
			public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK, ref ECPCHCBBNGH IMEAEFOFEDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct ENKHJMNHCND : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct LCJBAMDBBFB
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct BBPOJAHKHAO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime CFFNNMIAJGJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JDMLIIAJBHN>.Runtime KHGJEKEPENH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JMGMKGGOCKH>.Runtime IADMMFIFPDN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ILNLICHOGBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<JDMLIIAJBHN> HIMFGCFIFOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<JMGMKGGOCKH> HFDANBCEBAH;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0xDF8B70", Offset = "0xDF7170", VA = "0x180DF8B70")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0xDF8AA0", Offset = "0xDF70A0", VA = "0x180DF8AA0")]
				public BBPOJAHKHAO BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(BBPOJAHKHAO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<OJMJLDJJMBJ> ACLENHAHHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private LCJBAMDBBFB OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LCJBAMDBBFB.BBPOJAHKHAO* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xDF3E70", Offset = "0xDF2470", VA = "0x180DF3E70")]
			internal void KFDLFOBMEJP(in WorldPoseData EMJPNBNIJPK, in JDMLIIAJBHN BNONCODMDPO, in DynamicBuffer<JMGMKGGOCKH> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x7743F0", Offset = "0x7729F0", VA = "0x1807743F0", Slot = "5")]
			public void ReadFromDisplayClass(ref DMHEGDICODD IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xDF3DB0", Offset = "0xDF23B0", VA = "0x180DF3DB0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xDF3FD0", Offset = "0xDF25D0", VA = "0x180DF3FD0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref LCJBAMDBBFB.BBPOJAHKHAO GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xDF3E30", Offset = "0xDF2430", VA = "0x180DF3E30")]
			public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK, ref DMHEGDICODD IMEAEFOFEDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery CAOFDJPGBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery NECOHBANCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery GOMJBALADBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery ANBIHDBKKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery NKPNCGGIJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery DEPOBFGAIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery FPGOBAAMBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery ECLPEPDFOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery IDBHHGOENCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery DCCDBNIMKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::BGFDJNFLFAN<FJDOFGNFPLL, NMHMDBFHOBL> DKBKHCPKCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private ALNELIOAEHM HBIMMJCLEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private MJFDNFOLGPA IFBGMBPKKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private FGAICEMLFCP JLPABCEHAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery GBGNIJAPLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker AJHPBDIHBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery JBPFLFBOFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery JAMEDILBFEK;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x78CB80", Offset = "0x78B180", VA = "0x18078CB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x7899D0", Offset = "0x787FD0", VA = "0x1807899D0")]
		internal NMHMDBFHOBL BBGEJKCNCBD(FJDOFGNFPLL ODMNDKFKJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x78CD00", Offset = "0x78B300", VA = "0x18078CD00", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x78D7A0", Offset = "0x78BDA0", VA = "0x18078D7A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x78DA20", Offset = "0x78C020", VA = "0x18078DA20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x78DBB0", Offset = "0x78C1B0", VA = "0x18078DBB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x78D9E0", Offset = "0x78BFE0", VA = "0x18078D9E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x789F40", Offset = "0x788540", VA = "0x180789F40")]
		private void GGJJHAEALDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x78A910", Offset = "0x788F10", VA = "0x18078A910")]
		private void IODCJGHCABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x78B110", Offset = "0x789710", VA = "0x18078B110")]
		private void KANEKCNGPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x78DBF0", Offset = "0x78C1F0", VA = "0x18078DBF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x78C080", Offset = "0x78A680", VA = "0x18078C080")]
		private void LJKNPIDDPEM(EntityQuery BPJPGLJIBCD, EntityQuery JDEFICMNKIF, EntityQuery HDFADBKIHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x789CB0", Offset = "0x7882B0", VA = "0x180789CB0")]
		private void EMIFMEAGDDE(EntityQuery HDFADBKIHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x78D360", Offset = "0x78B960", VA = "0x18078D360")]
		private void OFNJKKFDHLO(global::AFMKKOBINHK<Entity> HHCMGOJAHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x78B4C0", Offset = "0x789AC0", VA = "0x18078B4C0")]
		private void KLKFKFNDMMM(global::AFMKKOBINHK<Entity> GFAAIHHBGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x78AAC0", Offset = "0x7890C0", VA = "0x18078AAC0")]
		private void JJLIEKGCDDG(global::AFMKKOBINHK<Entity> LKNDNLGNPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x789860", Offset = "0x787E60", VA = "0x180789860")]
		private void ADNJCEKIHLJ(NativeList<FJDOFGNFPLL> KFJGBAPMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x78A180", Offset = "0x788780", VA = "0x18078A180")]
		private NativeList<FJDOFGNFPLL> HNLADJLHPLB(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<FJDOFGNFPLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x78C560", Offset = "0x78AB60", VA = "0x18078C560")]
		private void MCKNNALHGEL(NativeArray<Entity> IJBCECFNJIL, NativeList<FJDOFGNFPLL> KFJGBAPMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x78B8C0", Offset = "0x789EC0", VA = "0x18078B8C0")]
		private void LIEHABANGHJ(NativeArray<Entity> HPNEDIJFLCD, NativeArray<Entity> ANCBEEHDLED, NativeList<FJDOFGNFPLL> NHLDHGBMFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x78AC60", Offset = "0x789260", VA = "0x18078AC60")]
		private void JLNAIGAFGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x78D090", Offset = "0x78B690", VA = "0x18078D090")]
		private global::NLPBCKKLMDB<OJMJLDJJMBJ> NJAABOLHILF(EntityQuery AMEIGJPGLKK, Func<NativeList<OJMJLDJJMBJ>, JobHandle> MJHMBIGHKDE)
		{
			return default(global::NLPBCKKLMDB<OJMJLDJJMBJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x78D1D0", Offset = "0x78B7D0", VA = "0x18078D1D0")]
		private JobHandle NJPGOAFJOHF(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x78CBC0", Offset = "0x78B1C0", VA = "0x18078CBC0")]
		private JobHandle MNBBMDDNENA(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x78A050", Offset = "0x788650", VA = "0x18078A050")]
		private JobHandle HKMBCOPAOPH(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x789A20", Offset = "0x788020", VA = "0x180789A20")]
		private void BFGLKAKLDHI(global::NLPBCKKLMDB<OJMJLDJJMBJ> ACLENHAHHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x78BDF0", Offset = "0x78A3F0", VA = "0x18078BDF0")]
		private void LIIHFPLMCMO(global::NLPBCKKLMDB<OJMJLDJJMBJ> ACLENHAHHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x78AA60", Offset = "0x789060", VA = "0x18078AA60")]
		private bool JCIHEDDFDNB(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x78CDC0", Offset = "0x78B3C0", VA = "0x18078CDC0")]
		private NativeArray<Entity> NEAJEDJDNBN(Entity FLADPKIONGF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x789D80", Offset = "0x788380", VA = "0x180789D80")]
		private FJDOFGNFPLL GDGNCDGBCJB(NativeList<FJDOFGNFPLL> NHLDHGBMFAK)
		{
			return default(FJDOFGNFPLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x78B830", Offset = "0x789E30", VA = "0x18078B830")]
		private void LHEHCMEOEKI(FJDOFGNFPLL ODMNDKFKJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x78D640", Offset = "0x78BC40", VA = "0x18078D640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x78CE90", Offset = "0x78B490", VA = "0x18078CE90")]
		public static EntityQuery NIOKCJOKAOM(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x78B5D0", Offset = "0x789BD0", VA = "0x18078B5D0")]
		public static EntityQuery KPDAIGBBPNA(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x78A6A0", Offset = "0x788CA0", VA = "0x18078A6A0")]
		public static EntityQuery ILBCCMAMAJK(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[DAINLFLPADL(OHEDAGNNHJA.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private OPAKLFEDMAA BFIDBOCPJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private HOGLAIOFIPF MNMJDEEPJKF;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x389A720", Offset = "0x3898D20", VA = "0x18389A720", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x389A690", Offset = "0x3898C90", VA = "0x18389A690", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x389A820", Offset = "0x3898E20", VA = "0x18389A820", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class LFFFJCCHELC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public GLICHKLIKDB NCAANBGOHJP;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LFFFJCCHELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public LFFFJCCHELC(GLICHKLIKDB NCAANBGOHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC690", Offset = "0x3BCAC90", VA = "0x183BCC690", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class NOHHJNLGKHJ : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService MAENFGNHNOF;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x3882C10", Offset = "0x3881210", VA = "0x183882C10", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x3882C70", Offset = "0x3881270", VA = "0x183882C70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x3882CA0", Offset = "0x38812A0", VA = "0x183882CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	protected NOHHJNLGKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class OCLBFAENKJA : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery JJGNMBCNOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery FPOENEIJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery EELKNGDKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery JBKHIBAKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService CKODEFAMJJJ;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int DOOOPAJAEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x3883510", Offset = "0x3881B10", VA = "0x183883510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int JKMNPHCFCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x3883380", Offset = "0x3881980", VA = "0x183883380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x3883520", Offset = "0x3881B20", VA = "0x183883520", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x38835E0", Offset = "0x3881BE0", VA = "0x1838835E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x38837E0", Offset = "0x3881DE0", VA = "0x1838837E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x3883360", Offset = "0x3881960", VA = "0x183883360")]
	public int DEIOFDOJNON(SceneTag FMEDCFLNIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x3883580", Offset = "0x3881B80", VA = "0x183883580")]
	public int NMPFPNGDBIL(SceneTag FMEDCFLNIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x3882EA0", Offset = "0x38814A0", VA = "0x183882EA0")]
	protected void ANKFCELGCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x38831E0", Offset = "0x38817E0", VA = "0x1838831E0")]
	protected void BLEGANKIHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x3883390", Offset = "0x3881990", VA = "0x183883390")]
	public global::AFMKKOBINHK<Entity> KDGHICCCEGF(SceneTag FMEDCFLNIMM, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(global::AFMKKOBINHK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x3883190", Offset = "0x3881790", VA = "0x183883190")]
	public global::AFMKKOBINHK<Entity> BGDDJCHGCEJ(SceneTag FMEDCFLNIMM, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(global::AFMKKOBINHK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x3882E10", Offset = "0x3881410", VA = "0x183882E10")]
	public bool ACEEBBBBMCG(SceneTag FMEDCFLNIMM, out global::AFMKKOBINHK<Entity> NCAANBGOHJP, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x38834B0", Offset = "0x3881AB0", VA = "0x1838834B0")]
	public bool LOMGEMGINNG(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x38833E0", Offset = "0x38819E0", VA = "0x1838833E0")]
	public GLICHKLIKDB KGEFEIKIFHE(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x38832F0", Offset = "0x38818F0", VA = "0x1838832F0")]
	public bool CDEJDKLJJPA(Entity FLADPKIONGF, out LFFFJCCHELC NCAANBGOHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x38835A0", Offset = "0x3881BA0", VA = "0x1838835A0")]
	public void ONNODGLGOKJ(Entity FLADPKIONGF, LFFFJCCHELC NCAANBGOHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x3883450", Offset = "0x3881A50", VA = "0x183883450")]
	public bool KPKJJLDLPLG(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LAHMKEKFIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public OCLBFAENKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class MMCLOMICBGN : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery MHPIJOAFJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x387F7A0", Offset = "0x387DDA0", VA = "0x18387F7A0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x387F7F0", Offset = "0x387DDF0", VA = "0x18387F7F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x387F8B0", Offset = "0x387DEB0", VA = "0x18387F8B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x326D940", Offset = "0x326BF40", VA = "0x18326D940")]
	private bool IHBPILEDBKE<TComponentData>(EntityQuery AMEIGJPGLKK, out NativeArray<Entity> IJBCECFNJIL, out NativeArray<TComponentData> NEOKJGOPJJM) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x387F730", Offset = "0x387DD30", VA = "0x18387F730")]
	public GLICHKLIKDB KGEFEIKIFHE(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public MMCLOMICBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[DAINLFLPADL(OHEDAGNNHJA.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery OBPENGMEPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery KNNGHGHLFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery MBFBNKPCJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery DGNOJLLLEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x77F060", Offset = "0x77D660", VA = "0x18077F060", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x77F0C0", Offset = "0x77D6C0", VA = "0x18077F0C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x77F2F0", Offset = "0x77D8F0", VA = "0x18077F2F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x77EC90", Offset = "0x77D290", VA = "0x18077EC90")]
		private void MFMCNFFMIAP(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77D220", VA = "0x18077EC20")]
		private void EMIFMEAGDDE(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x77F280", Offset = "0x77D880", VA = "0x18077F280", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x77ED00", Offset = "0x77D300", VA = "0x18077ED00")]
		private void NBKNIPPFJIM(EntityQuery AMEIGJPGLKK, bool IBCMFFCNBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class DDAIGJDJEMG : CPOPPILPLCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct PGIPBIBLICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public PGIPBIBLICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct IINHPDCAEDH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct FIGMGEOGMJE
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct LENEBMNMFIO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LMMBFNOBAMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime GMGOHDANOGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime KINOCNPHCIA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BJAFJPHDNLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> MCMNPFHGFHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> NHNBAAOPDEN;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0xDF4D90", Offset = "0xDF3390", VA = "0x180DF4D90")]
			public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0xDF4CD0", Offset = "0xDF32D0", VA = "0x180DF4CD0")]
			public LENEBMNMFIO BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(LENEBMNMFIO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private FIGMGEOGMJE OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FIGMGEOGMJE.LENEBMNMFIO* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x7775F0", Offset = "0x775BF0", VA = "0x1807775F0")]
		internal void KFDLFOBMEJP(Entity CJBPCJKPDLN, SplineShapeData IBHBGBEBHJM, DynamicBuffer<LinkedEntityGroup> DICKNCEHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x777560", Offset = "0x775B60", VA = "0x180777560", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x777650", Offset = "0x775C50", VA = "0x180777650")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref FIGMGEOGMJE.LENEBMNMFIO GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x7775E0", Offset = "0x775BE0", VA = "0x1807775E0")]
		public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GBNFNPENIAJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct HEHEJFFEADF
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct BFCKGAAJFDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ICAMBBJOFDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime BPNHBIOECHI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity KOCNMJEKFOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NNIKAAIHFIM;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xDF6590", Offset = "0xDF4B90", VA = "0x180DF6590")]
			public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0xDF6510", Offset = "0xDF4B10", VA = "0x180DF6510")]
			public BFCKGAAJFDM BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(BFCKGAAJFDM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> CHCMLGLNNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private HEHEJFFEADF OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HEHEJFFEADF.BFCKGAAJFDM* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x7767A0", Offset = "0x774DA0", VA = "0x1807767A0")]
		internal void KFDLFOBMEJP(Entity JOMCMEOJGLA, SplinePointParentData CINJNIBEMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x7768E0", Offset = "0x774EE0", VA = "0x1807768E0", Slot = "5")]
		public void ReadFromDisplayClass(ref PGIPBIBLICC IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x774CF0", VA = "0x1807766F0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x776830", Offset = "0x774E30", VA = "0x180776830")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref HEHEJFFEADF.BFCKGAAJFDM GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x776760", Offset = "0x774D60", VA = "0x180776760")]
		public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK, ref PGIPBIBLICC IMEAEFOFEDK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery GLDNMGJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery CHICECKOCLJ;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x39048A0", Offset = "0x3902EA0", VA = "0x1839048A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3904950", Offset = "0x3902F50", VA = "0x183904950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public DDAIGJDJEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x3904600", Offset = "0x3902C00", VA = "0x183904600", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3904300", Offset = "0x3902900", VA = "0x183904300")]
	public static EntityQuery AJCJKPKPFIA(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x39044A0", Offset = "0x3902AA0", VA = "0x1839044A0")]
	public static EntityQuery AKMKMDAOJAI(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public sealed class IHGKNPBKKAL : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private DJJJJFKCAHK MENKPJEEHFG;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5410", Offset = "0x3BC3A10", VA = "0x183BC5410", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5470", Offset = "0x3BC3A70", VA = "0x183BC5470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public IHGKNPBKKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class EKCMPODICBG : CPOPPILPLCL, GKFAMMKGENJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct PLGJMLOPGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<KCBMDFFNPLE> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<AGAIJBALKEC> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<KCBMDFFNPLE> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public PLGJMLOPGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, EELLNPEINOG previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__2(Entity entity, EELLNPEINOG previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct LJBNNPMHOGP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct MLJNHAGKDBI
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct MNBACOJOHFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime MHFEJHOMGHA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> JDOJFKCPDOC;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0xDFA710", Offset = "0xDF8D10", VA = "0x180DFA710")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0xDFA690", Offset = "0xDF8C90", VA = "0x180DFA690")]
			public MNBACOJOHFP BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(MNBACOJOHFP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<KCBMDFFNPLE> MHLEJMGJHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private MLJNHAGKDBI OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MLJNHAGKDBI.MNBACOJOHFP* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xDF8E60", Offset = "0xDF7460", VA = "0x180DF8E60")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData OBFMOAOGODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x7743F0", Offset = "0x7729F0", VA = "0x1807743F0", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xDF8D30", Offset = "0xDF7330", VA = "0x180DF8D30", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF74E0", VA = "0x180DF8EE0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref MLJNHAGKDBI.MNBACOJOHFP GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xDF8DD0", Offset = "0xDF73D0", VA = "0x180DF8DD0")]
		public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK, ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct JIPIFNOGKKB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct HIHCEBBPAPA
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct JMCACFKGECK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime MHFEJHOMGHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EELLNPEINOG>.Runtime KAKHNKIJILN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> JDOJFKCPDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EELLNPEINOG> JDIACPGCIBI;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0xDF6C60", Offset = "0xDF5260", VA = "0x180DF6C60")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xDF6BC0", Offset = "0xDF51C0", VA = "0x180DF6BC0")]
			public JMCACFKGECK BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(JMCACFKGECK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<AGAIJBALKEC> CIBDONFAOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private HIHCEBBPAPA OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HIHCEBBPAPA.JMCACFKGECK* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xDF7880", Offset = "0xDF5E80", VA = "0x180DF7880")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData OBFMOAOGODB, EELLNPEINOG ONJEGBJDGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xDF7A20", Offset = "0xDF6020", VA = "0x180DF7A20", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xDF7770", Offset = "0xDF5D70", VA = "0x180DF7770", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xDF7940", Offset = "0xDF5F40", VA = "0x180DF7940")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref HIHCEBBPAPA.JMCACFKGECK GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xDF7840", Offset = "0xDF5E40", VA = "0x180DF7840")]
		public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK, ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct NADEKFEPKIK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct IHHHIGAPOIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct NJIBDDIHAFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<EELLNPEINOG>.Runtime KAKHNKIJILN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<EELLNPEINOG> JDIACPGCIBI;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xDF73F0", Offset = "0xDF59F0", VA = "0x180DF73F0")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xDF7370", Offset = "0xDF5970", VA = "0x180DF7370")]
			public NJIBDDIHAFL BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(NJIBDDIHAFL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<KCBMDFFNPLE> HMPJBGJHGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private IHHHIGAPOIP OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IHHHIGAPOIP.NJIBDDIHAFL* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xDFA980", Offset = "0xDF8F80", VA = "0x180DFA980")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, EELLNPEINOG ONJEGBJDGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xDFAAB0", Offset = "0xDF90B0", VA = "0x180DFAAB0", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xDFA850", Offset = "0xDF8E50", VA = "0x180DFA850", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xDFAA00", Offset = "0xDF9000", VA = "0x180DFAA00")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref IHHHIGAPOIP.NJIBDDIHAFL GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xDFA8F0", Offset = "0xDF8EF0", VA = "0x180DFA8F0")]
		public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK, ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private DELPMNCMFNN BINMCJFEJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery DJAHFFLBPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery DLMNFJOIHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery ICAECCLLMID;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1210", Offset = "0x3BAF810", VA = "0x183BB1210", Slot = "14")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BB19E0", Offset = "0x3BAFFE0", VA = "0x183BB19E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public EKCMPODICBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1980", Offset = "0x3BAFF80", VA = "0x183BB1980", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x3BB14F0", Offset = "0x3BAFAF0", VA = "0x183BB14F0")]
	public static EntityQuery MNOLIEOFHKO(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1750", Offset = "0x3BAFD50", VA = "0x183BB1750")]
	public static EntityQuery OAGMBJGGNJD(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x3BB12F0", Offset = "0x3BAF8F0", VA = "0x183BB12F0")]
	public static EntityQuery IMHPHEHFJBE(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[DAINLFLPADL(OHEDAGNNHJA.Connectables)]
	public class InitializeRigidbodyExHierarchy : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private HGCBJKAFPHC NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6A00", Offset = "0x3BC5000", VA = "0x183BC6A00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6990", Offset = "0x3BC4F90", VA = "0x183BC6990", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6A90", Offset = "0x3BC5090", VA = "0x183BC6A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class IBAGICNMDNG : ParentSystemBase<ParentData, EELLNPEINOG, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x3BC42B0", Offset = "0x3BC28B0", VA = "0x183BC42B0", Slot = "14")]
	protected override EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x826070", Offset = "0x824670", VA = "0x180826070", Slot = "15")]
	protected override EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4330", Offset = "0x3BC2930", VA = "0x183BC4330", Slot = "16")]
	protected override EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x3BC42F0", Offset = "0x3BC28F0", VA = "0x183BC42F0", Slot = "17")]
	protected override EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x3BC43B0", Offset = "0x3BC29B0", VA = "0x183BC43B0")]
	public IBAGICNMDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4370", Offset = "0x3BC2970", VA = "0x183BC4370", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : CPOPPILPLCL where ParentData : struct, IComponentData, CGCOJDLBGDN where PreviousParentData : struct, IComponentData, CGCOJDLBGDN where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, CGCOJDLBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct GIALACFELGM : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter JNJMIMMLBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter GIEFCBHIADK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter BICKCCAPEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> AJJEDMBEGLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> CAKGLNFNGJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType DIBBBEEFIGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint CILFLPOMCLL;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x37D5280", Offset = "0x37D3880", VA = "0x1837D5280", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct ILHBNEDHBAF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BICKCCAPEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> OJBIBGAFBPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> PBDAIIIGOOO;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x3280B00", Offset = "0x327F100", VA = "0x183280B00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct GMPNAEDCMCD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> JNJMIMMLBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> GIEFCBHIADK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BICKCCAPEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> OJBIBGAFBPJ;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x4086530", Offset = "0x4084B30", VA = "0x184086530")]
			private int PEHMAAIDLEO(DynamicBuffer<ChildrenData> PAHCBODMCHK, Entity FLADPKIONGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x4085EB0", Offset = "0x40844B0", VA = "0x184085EB0")]
			private void ADHLPHPIMOP(Entity LFAIGCEGCPL, DynamicBuffer<ChildrenData> PAHCBODMCHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x40862D0", Offset = "0x40848D0", VA = "0x1840862D0")]
			private void MIMDMJMKMCH(Entity LFAIGCEGCPL, DynamicBuffer<ChildrenData> PAHCBODMCHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x4086170", Offset = "0x4084770", VA = "0x184086170", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct ELDBOMOJKEA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> OBOJPCLJGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> KEPEEEPLAGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> OJBIBGAFBPJ;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x333EE10", Offset = "0x333D410", VA = "0x18333EE10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery CNIOIMBBHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery HCHOEHBDCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery DBOKGOHMEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery OCAKEFKKGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker JPMBOKDKOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker FELLFEHOJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker OMLNNACPAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker BOICALICLMD;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x335CCB0", Offset = "0x335B2B0", VA = "0x18335CCB0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x335CAD0", Offset = "0x335B0D0", VA = "0x18335CAD0")]
		private int PEHMAAIDLEO(DynamicBuffer<ChildrenData> PAHCBODMCHK, Entity FLADPKIONGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x335B740", Offset = "0x3359D40", VA = "0x18335B740")]
		private void IMIOAAOICHL(Entity NHIGGOACGGE, Entity EBPNONDMOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x826070", Offset = "0x824670", VA = "0x180826070", Slot = "14")]
		protected virtual EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x826070", Offset = "0x824670", VA = "0x180826070", Slot = "15")]
		protected virtual EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x826070", Offset = "0x824670", VA = "0x180826070", Slot = "16")]
		protected virtual EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x335C4C0", Offset = "0x335AAC0", VA = "0x18335C4C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x335C300", Offset = "0x335A900", VA = "0x18335C300")]
		private void ONIPHGJPOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x335B260", Offset = "0x3359860", VA = "0x18335B260")]
		private void EBJNEOPFGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x335B8A0", Offset = "0x3359EA0", VA = "0x18335B8A0")]
		private JobHandle MAEDMIHFLKG(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x335AF80", Offset = "0x3359580", VA = "0x18335AF80")]
		private void AFKNLHCCGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x335CA00", Offset = "0x335B000", VA = "0x18335CA00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x3164130", Offset = "0x3162730", VA = "0x183164130", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x335C4A0", Offset = "0x335AAA0", VA = "0x18335C4A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public abstract class DLIGPDHAAFN : CPOPPILPLCL, GKFAMMKGENJ
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct GGALAMDJCAC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::NLPBCKKLMDB<Entity> CBBNLFABCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::NLPBCKKLMDB<Entity> NAHCFHBDGDE;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xDF5C90", Offset = "0xDF4290", VA = "0x180DF5C90")]
		public GGALAMDJCAC(NativeList<Entity> CBBNLFABCAH, NativeList<Entity> NAHCFHBDGDE, JobHandle AHIGBHNJKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xDF5C10", Offset = "0xDF4210", VA = "0x180DF5C10")]
		public JobHandle IJIEFFPOAMP(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xDF5B80", Offset = "0xDF4180", VA = "0x180DF5B80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct BBFLFKONODB : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum OENMLOCKMAH
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
		public NativeList<Entity> MOEKCNAAEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> MGEEDDJOLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> BNDJEFIFHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> AOGDAGAABIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public KAHEOPHNBCB HNBFBNPOPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public KAHEOPHNBCB NMPGKAEMLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> PJDJKOJJHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int JEPAOKOCJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int OGDPOCNFJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private OENMLOCKMAH AIAKBOMPCEL;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x774C50", Offset = "0x773250", VA = "0x180774C50", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x774DE0", Offset = "0x7733E0", VA = "0x180774DE0")]
		private void GCFGEGCMEKP(Entity FLADPKIONGF, bool JFPDELADEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x775030", Offset = "0x773630", VA = "0x180775030")]
		private void NGKJOILDFHN(Entity FLADPKIONGF, bool JFPDELADEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x774BD0", Offset = "0x7731D0", VA = "0x180774BD0")]
		public GGALAMDJCAC EKEOAGCIPLE(NativeArray<Entity> BEMBCCNAMCE, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x775140", Offset = "0x773740", VA = "0x180775140")]
		public GGALAMDJCAC PHMKMGEKNPE(NativeArray<Entity> BEMBCCNAMCE, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x774AF0", Offset = "0x7730F0", VA = "0x180774AF0")]
		public GGALAMDJCAC DBFHGKOECBN(NativeList<KCBMDFFNPLE> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x774E70", Offset = "0x773470", VA = "0x180774E70")]
		public GGALAMDJCAC ICCJLIGGAIN(NativeList<KCBMDFFNPLE> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x774F50", Offset = "0x773550", VA = "0x180774F50")]
		public GGALAMDJCAC LLHFBEHEOED(NativeList<AGAIJBALKEC> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x3515950", Offset = "0x3513F50", VA = "0x183515950")]
		private GGALAMDJCAC ABPAKOFKCJN<T>(NativeList<T> ACLENHAHHHH, int ALCMCJODGAH, int JMIAEFEPHMM, OENMLOCKMAH OLBBMHHLPIG, JobHandle BAMHFDJJPAO) where T : struct
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x774920", Offset = "0x772F20", VA = "0x180774920")]
		private GGALAMDJCAC ABPAKOFKCJN(NativeArray<Entity> IJBCECFNJIL, int ALCMCJODGAH, int JMIAEFEPHMM, OENMLOCKMAH OLBBMHHLPIG, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery BCNBGLPMFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery DMLDNNGGDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private DELPMNCMFNN JEHHDKELEDF;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType NBDNNKCDLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType FPMGPJGNKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType CFBKJAFDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x3908AF0", Offset = "0x39070F0", VA = "0x183908AF0")]
	protected DLIGPDHAAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x3907230", Offset = "0x3905830", VA = "0x183907230", Slot = "14")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x39079C0", Offset = "0x3905FC0", VA = "0x1839079C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x3907BF0", Offset = "0x39061F0", VA = "0x183907BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xCD0C00", Offset = "0xCCF200", VA = "0x180CD0C00", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x3907310", Offset = "0x3905910", VA = "0x183907310")]
	private void FICHIMLCECG(NativeArray<Entity> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x39076D0", Offset = "0x3905CD0", VA = "0x1839076D0")]
	private void IMMEIACMCHJ(NativeArray<Entity> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x3907370", Offset = "0x3905970", VA = "0x183907370")]
	private void GAMOFJNBDAH(GGALAMDJCAC LKELINMLMFO, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x39074B0", Offset = "0x3905AB0", VA = "0x1839074B0")]
	private void GAMOFJNBDAH(global::NLPBCKKLMDB<Entity> GBNGHGBEGOP, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x3907880", Offset = "0x3905E80", VA = "0x183907880")]
	private void LCOCFDHHDAL(GGALAMDJCAC LKELINMLMFO, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x3907770", Offset = "0x3905D70", VA = "0x183907770")]
	private void LCOCFDHHDAL(global::NLPBCKKLMDB<Entity> GBNGHGBEGOP, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x39075C0", Offset = "0x3905BC0", VA = "0x1839075C0")]
	private bool GCFFCJFBDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public class GNLKGNPEMJB : CPOPPILPLCL, GOJCOOFCPOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct PHAHFPHEIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public GNLKGNPEMJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public PHAHFPHEIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JOGBIJOLMGB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct LKBHOCMFAPL
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct CACLDJJECNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime DKKKHGDOFGO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GJJMDCPPLGN;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xDF8FA0", Offset = "0xDF75A0", VA = "0x180DF8FA0")]
			public void KBLGIFLFDKL(GNLKGNPEMJB AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0xDF8F90", Offset = "0xDF7590", VA = "0x180DF8F90")]
			public CACLDJJECNA BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(CACLDJJECNA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public GNLKGNPEMJB DPMMPHPBAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer MCFALJLCIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private LKBHOCMFAPL OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LKBHOCMFAPL.CACLDJJECNA* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xDF7CD0", Offset = "0xDF62D0", VA = "0x180DF7CD0")]
		internal void KFDLFOBMEJP(Entity CNABBHHIHOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xDF56C0", Offset = "0xDF3CC0", VA = "0x180DF56C0", Slot = "5")]
		public void ReadFromDisplayClass(ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xDF56F0", Offset = "0xDF3CF0", VA = "0x180DF56F0", Slot = "6")]
		public void WriteToDisplayClass(ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xDF7C40", Offset = "0xDF6240", VA = "0x180DF7C40", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xDF7E50", Offset = "0xDF6450", VA = "0x180DF7E50")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref LKBHOCMFAPL.CACLDJJECNA GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xDF7C90", Offset = "0xDF6290", VA = "0x180DF7C90")]
		public void KBLGIFLFDKL(GNLKGNPEMJB AJPOCCLBMGK, ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xDF7DE0", Offset = "0xDF63E0", VA = "0x180DF7DE0")]
		public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private LDFECCHBCJN GMFHACHEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private IEHKMAFMFKK ALDNNMNNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery BBJAHIEHBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker KEEGMABFOAL;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0A80", Offset = "0x3BBF080", VA = "0x183BC0A80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0940", Offset = "0x3BBEF40", VA = "0x183BC0940", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0AE0", Offset = "0x3BBF0E0", VA = "0x183BC0AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public GNLKGNPEMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC09A0", Offset = "0x3BBEFA0", VA = "0x183BC09A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0770", Offset = "0x3BBED70", VA = "0x183BC0770")]
	public static EntityQuery BJEEIKCECIM(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[LLNAOBNNFAO]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public class IOCKKLCEHOK : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private IEHKMAFMFKK ALDNNMNNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService LLLBMIKLOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6180", Offset = "0x3BC4780", VA = "0x183BC6180", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC61F0", Offset = "0x3BC47F0", VA = "0x183BC61F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6290", Offset = "0x3BC4890", VA = "0x183BC6290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public IOCKKLCEHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct CIINKDAIIND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public GICNBHGCLJH ODMNDKFKJHN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B0", Offset = "0x72DDB0", VA = "0x18072F7B0")]
	public static CIINKDAIIND DGKBAOBECFH(in GICNBHGCLJH LEFNEJCOFJL)
	{
		return default(CIINKDAIIND);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B0", Offset = "0x72DDB0", VA = "0x18072F7B0")]
	public static GICNBHGCLJH DGKBAOBECFH(in CIINKDAIIND BHIOGBJIEBO)
	{
		return default(GICNBHGCLJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class LDFECCHBCJN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC4D0", Offset = "0x3BCAAD0", VA = "0x183BCC4D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	public LDFECCHBCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public class FHIKJCOPHGD : CPOPPILPLCL, GOJCOOFCPOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct GDAOMHKIAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public FHIKJCOPHGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public GDAOMHKIAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__0(Entity e, CIINKDAIIND ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GBEEJFKOEIE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct NIDOOEGKGKO
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct DEHKEFIPEGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime DKKKHGDOFGO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<CIINKDAIIND>.Runtime FDLLJOPLLAP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GJJMDCPPLGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<CIINKDAIIND> AGPEEAHBEOG;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xDFAD20", Offset = "0xDF9320", VA = "0x180DFAD20")]
			public void KBLGIFLFDKL(FHIKJCOPHGD AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xDFACA0", Offset = "0xDF92A0", VA = "0x180DFACA0")]
			public DEHKEFIPEGP BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(DEHKEFIPEGP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public FHIKJCOPHGD DPMMPHPBAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer MCFALJLCIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private NIDOOEGKGKO OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NIDOOEGKGKO.DEHKEFIPEGP* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xDF54A0", Offset = "0xDF3AA0", VA = "0x180DF54A0")]
		internal void KFDLFOBMEJP(Entity CNABBHHIHOO, CIINKDAIIND MCOOKECPGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xDF56C0", Offset = "0xDF3CC0", VA = "0x180DF56C0", Slot = "5")]
		public void ReadFromDisplayClass(ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xDF56F0", Offset = "0xDF3CF0", VA = "0x180DF56F0", Slot = "6")]
		public void WriteToDisplayClass(ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xDF5370", Offset = "0xDF3970", VA = "0x180DF5370", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xDF5610", Offset = "0xDF3C10", VA = "0x180DF5610")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref NIDOOEGKGKO.DEHKEFIPEGP GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xDF5410", Offset = "0xDF3A10", VA = "0x180DF5410")]
		public void KBLGIFLFDKL(FHIKJCOPHGD AJPOCCLBMGK, ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xDF55A0", Offset = "0xDF3BA0", VA = "0x180DF55A0")]
		public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private LDFECCHBCJN GMFHACHEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private IEHKMAFMFKK ALDNNMNNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery NAMNPBOMECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker IJOGPFNNHDG;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9B30", Offset = "0x3BB8130", VA = "0x183BB9B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x3BB99F0", Offset = "0x3BB7FF0", VA = "0x183BB99F0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9B90", Offset = "0x3BB8190", VA = "0x183BB9B90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public FHIKJCOPHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9A50", Offset = "0x3BB8050", VA = "0x183BB9A50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9820", Offset = "0x3BB7E20", VA = "0x183BB9820")]
	public static EntityQuery JMMOABPAOMP(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct NEINFBOMBIB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public FMHLIBMOGNG PJBANBJAEAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, ABCENELPPGI> IJBCECFNJIL;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0xDFAC00", Offset = "0xDF9200", VA = "0x180DFAC00")]
			public NEINFBOMBIB(int FHGNFGIEADL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0xDFAB80", Offset = "0xDF9180", VA = "0x180DFAB80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct MEAMLHLODHN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> NMJJMNPBNGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xDF95A0", Offset = "0xDF7BA0", VA = "0x180DF95A0", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct OCAJCDNCKJA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0xDFB270", Offset = "0xDF9870", VA = "0x180DFB270", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private IEHKMAFMFKK ALDNNMNNGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery LOMDFKCEEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery MGLJMFKBBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery CHJDIIMLGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery HBPNHKCFHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery BIAAJKKLJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle EBOIJILMNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private NEINFBOMBIB GPGNJDOKHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private NEINFBOMBIB FOCMPOBGPEI;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x38977D0", Offset = "0x3895DD0", VA = "0x1838977D0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x3897970", Offset = "0x3895F70", VA = "0x183897970", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x38973C0", Offset = "0x38959C0", VA = "0x1838973C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x3897C30", Offset = "0x3896230", VA = "0x183897C30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x3897530", Offset = "0x3895B30", VA = "0x183897530")]
		private void MKKACDOFLIO(EntityQuery AMEIGJPGLKK, out (global::AFMKKOBINHK<CIINKDAIIND> handles, global::AFMKKOBINHK<EBMEGFHECAE> bounds) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x3896E70", Offset = "0x3895470", VA = "0x183896E70")]
		private void DIADEKOGMDE((global::AFMKKOBINHK<CIINKDAIIND> handles, global::AFMKKOBINHK<EBMEGFHECAE> bounds) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x38973C0", Offset = "0x38959C0", VA = "0x1838973C0")]
		private void ECJFBALLNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x3897830", Offset = "0x3895E30", VA = "0x183897830")]
		private void OAFOACGPPJM(EntityQuery AMEIGJPGLKK, out (global::AFMKKOBINHK<Entity> entities, global::AFMKKOBINHK<CIINKDAIIND> handles) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x38970D0", Offset = "0x38956D0", VA = "0x1838970D0")]
		private void DMOIMFJBEEE((global::AFMKKOBINHK<Entity> entities, global::AFMKKOBINHK<CIINKDAIIND> handles) JIHCLPECHIB, NEINFBOMBIB LGPKJBBIKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3897670", Offset = "0x3895C70", VA = "0x183897670")]
		private JobHandle MMFBDEIPHEJ(NEINFBOMBIB LGPKJBBIKKA, ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ, ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO, ComponentDataFromEntity<WorldDeformableScaleData> NMJJMNPBNGM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x3897400", Offset = "0x3895A00", VA = "0x183897400")]
		private JobHandle HOCFKECOANB(NEINFBOMBIB LGPKJBBIKKA, ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ, ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct FEIOHBJCGFG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[LLNAOBNNFAO]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class SplineLocalBoundsSystem : CPOPPILPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct CLHEMNFLNBO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> DJAAGNHLCNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> AFLEEJGLEMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<EBMEGFHECAE> KKIJLCKAFLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, ABCENELPPGI>.ParallelWriter DKLPIEGFLED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter ICMKDKAEFOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter IOKKPIGCGLB;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xDF28B0", Offset = "0xDF0EB0", VA = "0x180DF28B0", Slot = "4")]
			public void Execute(int EBBLFLFCHFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct KHKNGJCEHJN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> AHIOAOEKPBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> BHLCPIFOMEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> HBKNOECNGMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> CHLLLKLOOPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<EBMEGFHECAE> CDLDCPACGOD;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xDF8300", Offset = "0xDF6900", VA = "0x180DF8300", Slot = "4")]
			public void Execute(int EBBLFLFCHFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery PNCBOPLLMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery NGJEHLDJJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery GFFOOKBAJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery DEBFHLGIIMF;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x781670", Offset = "0x77FC70", VA = "0x180781670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x781880", Offset = "0x77FE80", VA = "0x180781880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x7811F0", Offset = "0x77F7F0", VA = "0x1807811F0")]
		private JobHandle LDALNJNKDIP(global::AFMKKOBINHK<Entity> HEONDDEAIBL, int JKABHKIANJL, JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x7812D0", Offset = "0x77F8D0", VA = "0x1807812D0")]
		private JobHandle LDALNJNKDIP(NativeArray<Entity> LHOOFBNDFAP, int JKABHKIANJL, [Optional] JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x781DA0", Offset = "0x7803A0", VA = "0x180781DA0")]
		private global::AFMKKOBINHK<Entity> PNONOLIOHMK(EntityQuery AMEIGJPGLKK)
		{
			return default(global::AFMKKOBINHK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x780910", Offset = "0x77EF10", VA = "0x180780910")]
		private (global::NLPBCKKLMDB<Entity>, global::NLPBCKKLMDB<Entity>) AOEFLHOHCBJ(global::AFMKKOBINHK<Entity> OHNOLPHNEEG)
		{
			return default((global::NLPBCKKLMDB<Entity>, global::NLPBCKKLMDB<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x7815E0", Offset = "0x77FBE0", VA = "0x1807815E0")]
		private void ONHDEDCEEBC(out NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x780D60", Offset = "0x77F360", VA = "0x180780D60")]
		private void CIFIFDHDHFL(NativeList<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x780DF0", Offset = "0x77F3F0", VA = "0x180780DF0")]
		private void CIFIFDHDHFL(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x7814B0", Offset = "0x77FAB0", VA = "0x1807814B0")]
		private void OIDPAKOFFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void GBCLDGBNEHA(int KLDIBGACAGG, int OBEIAGKELAO, int GNCMLAKBBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x780EC0", Offset = "0x77F4C0", VA = "0x180780EC0")]
		private static EBMEGFHECAE LAOLKGBINPA(NativeArray<Entity> FINHNPIHHDI, ComponentDataFromEntity<SplinePointPositionData> HBKNOECNGMP, ComponentDataFromEntity<SplinePointScaleData> CHLLLKLOOPG)
		{
			return default(EBMEGFHECAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct AFHDIHKOGCM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[LLNAOBNNFAO]
	[DAINLFLPADL(OHEDAGNNHJA.Lifecycle)]
	public class DestroyLocalObjects : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[CJONPMHNDBN]
		private ObjectNetworkToLocalMapService GEHGBPFFMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[CJONPMHNDBN]
		private ObjectLifecycleService BKOGMAMFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery GCOBNFPCJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery NCJNKANHGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery DGNOJLLLEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0870", Offset = "0x3BAEE70", VA = "0x183BB0870", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB04C0", Offset = "0x3BAEAC0", VA = "0x183BB04C0")]
		public bool ACKAGFFFKJJ(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0A40", Offset = "0x3BAF040", VA = "0x183BB0A40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB08E0", Offset = "0x3BAEEE0", VA = "0x183BB08E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0B70", Offset = "0x3BAF170", VA = "0x183BB0B70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2126800", Offset = "0x2124E00", VA = "0x182126800", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x3BB08E0", Offset = "0x3BAEEE0", VA = "0x183BB08E0")]
		private void NMBOOEIPCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0680", Offset = "0x3BAEC80", VA = "0x183BB0680")]
		private void IDJKAFLJHHB(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0730", Offset = "0x3BAED30", VA = "0x183BB0730")]
		private void NDCJIFCEOKK(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0570", Offset = "0x3BAEB70", VA = "0x183BB0570")]
		private void CAHDAIHLDPP(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0920", Offset = "0x3BAEF20", VA = "0x183BB0920")]
		private void OEACAAKJOIA(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static IGGCJBCLGAF[] MFDEDNDNJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private HBPOMPIINHA ENCNFKJIELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private OMKGMEPBKLL BBIEOIAKIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService AGNKNPKFJDG;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6240", Offset = "0x3BB4840", VA = "0x183BB6240", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB62F0", Offset = "0x3BB48F0", VA = "0x183BB62F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5CB0", Offset = "0x3BB42B0", VA = "0x183BB5CB0")]
		private void LOFKLGHFEMF(IGGCJBCLGAF CBBKLGMGPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private void CHPMANCHJPA(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB, DHPNCKOALMM MEIAOCKHKHB, KCFNAMGFMNK KIEFDNEMCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[DAINLFLPADL(OHEDAGNNHJA.Callbacks)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public sealed class PropertyEventCallbacks : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService HKMONJIHHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService AGNKNPKFJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase CBBKLGMGPCP;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x389D8C0", Offset = "0x389BEC0", VA = "0x18389D8C0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x389D950", Offset = "0x389BF50", VA = "0x18389D950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[DAINLFLPADL(OHEDAGNNHJA.NetworkSend)]
	internal class TransmitNetworkDataSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private KBNPAGHEBHB NGJACCCAPAL;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x788D60", Offset = "0x787360", VA = "0x180788D60", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x788DB0", Offset = "0x7873B0", VA = "0x180788DB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[LLNAOBNNFAO]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	public class CalculateCullingBandChanges : CPOPPILPLCL, BGDEOEAAJCH, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct AJICBGFLJNF : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType PPOIALCHBPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> LDEAMJGHFBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<OGGEFBPFCHD>.ParallelWriter KAFCGJIGMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<MNNCEFECDCD> HKBNDJJGEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 BIPEBBMCHLH;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 PAGPFPAIFAN;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 CFPKJPGFGHL;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 LBIIEBBGMBO;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x774410", Offset = "0x772A10", VA = "0x180774410", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int HBIHALLIDKM = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double OOIKLBHJKGB = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery KPCJMCEPCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery BJCJOBNEMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double AHFGEIMGMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService CJLEHCAIIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService MNHJICLMCHO;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x38F9410", Offset = "0x38F7A10", VA = "0x1838F9410", Slot = "14")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x38F9420", Offset = "0x38F7A20", VA = "0x1838F9420", Slot = "15")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x38F94B0", Offset = "0x38F7AB0", VA = "0x1838F94B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x38F9600", Offset = "0x38F7C00", VA = "0x1838F9600", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x38F93A0", Offset = "0x38F79A0", VA = "0x1838F93A0")]
		private bool JLHLHEJFKON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x38F9060", Offset = "0x38F7660", VA = "0x1838F9060")]
		private void AEPBJHBIDBL(EntityQuery AMEIGJPGLKK, float3 MFJCDEMGGLB, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct OGGEFBPFCHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity FLADPKIONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public CEFLALGDCIE GLJCMMBCBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public CEFLALGDCIE PNPBNOELPMC;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService CJLEHCAIIDH;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x389A5B0", Offset = "0x3898BB0", VA = "0x18389A5B0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x389A600", Offset = "0x3898C00", VA = "0x18389A600", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[DAINLFLPADL(OHEDAGNNHJA.Connectables)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class UpdateInertialProperties : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery DJEFFHGACDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private JIFLJCNHFKJ LGFLALPDHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x78F7D0", Offset = "0x78DDD0", VA = "0x18078F7D0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x78F840", Offset = "0x78DE40", VA = "0x18078F840", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x78F8D0", Offset = "0x78DED0", VA = "0x18078F8D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[LLNAOBNNFAO]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FEPDJPNPBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OAIHNPFIIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LOAKCHIHFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService DNKNHHLBHLO;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB54A0", Offset = "0x3BB3AA0", VA = "0x183BB54A0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5660", Offset = "0x3BB3C60", VA = "0x183BB5660", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB49D0", Offset = "0x3BB2FD0", VA = "0x183BB49D0")]
		private void CFHGMLNLCPC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ACLENHAHHHH, EntityQueryDesc HLHOOFAHPJK, bool CCLEKJNADLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4890", Offset = "0x3BB2E90", VA = "0x183BB4890")]
		private void CFHGMLNLCPC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ACLENHAHHHH, EntityQueryDesc HLHOOFAHPJK, bool CCLEKJNADLB, bool CPHPLAEKCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x3BB58C0", Offset = "0x3BB3EC0", VA = "0x183BB58C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4660", Offset = "0x3BB2C60", VA = "0x183BB4660")]
		private void ALKMJGDDHDA(EntityQuery AMEIGJPGLKK, bool JMJIDNELPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4BB0", Offset = "0x3BB31B0", VA = "0x183BB4BB0")]
		private void HCMNJKGGJCN(EntityQuery AMEIGJPGLKK, bool HMGDHPGJDKJ, bool JMJIDNELPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4DC0", Offset = "0x3BB33C0", VA = "0x183BB4DC0")]
		private void HNKFMJLACEO(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB54F0", Offset = "0x3BB3AF0", VA = "0x183BB54F0")]
		private void NDLDBKNHBIC(NativeList<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB51E0", Offset = "0x3BB37E0", VA = "0x183BB51E0")]
		private void IOHBEGEEKDN(NativeArray<Entity> IJBCECFNJIL, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4FE0", Offset = "0x3BB35E0", VA = "0x183BB4FE0")]
		private NativeList<Entity> ICPOIAGHIJK(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4B70", Offset = "0x3BB3170", VA = "0x183BB4B70")]
		private NativeList<Entity> GACPELOHELK(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4850", Offset = "0x3BB2E50", VA = "0x183BB4850")]
		private NativeList<Entity> BKAEFHLBJME(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5300", Offset = "0x3BB3900", VA = "0x183BB5300")]
		private NativeList<Entity> JMMLFMGCMIB(NativeArray<Entity> IJBCECFNJIL, bool BNECEEHLHPF)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4AE0", Offset = "0x3BB30E0", VA = "0x183BB4AE0")]
		private LJIODJFNCKI CKKBBDHNMKI(NativeArray<Entity> IJBCECFNJIL)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LJIODJFNCKI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5BE0", Offset = "0x3BB41E0", VA = "0x183BB5BE0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService DNKNHHLBHLO;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x389A620", Offset = "0x3898C20", VA = "0x18389A620", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x389A670", Offset = "0x3898C70", VA = "0x18389A670", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : GJKIDHCFCFK
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery MLOOEMEDMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery EMDNMADNMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery PMICPAFCOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery IKICFEEMODD;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0130", Offset = "0x3BAE730", VA = "0x183BB0130", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB02F0", Offset = "0x3BAE8F0", VA = "0x183BB02F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x3BAFCB0", Offset = "0x3BAE2B0", VA = "0x183BAFCB0")]
		private void BEGDICGCAPB(EntityQuery AMEIGJPGLKK, bool BGANFPDCCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x3BAFEF0", Offset = "0x3BAE4F0", VA = "0x183BAFEF0")]
		private void NOBCKKMDLCC(EntityQuery AMEIGJPGLKK, bool BGANFPDCCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class AssignPlayerIdsSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery EMJBONJNLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery NAHIPKBFEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService LCJDMKABNOO;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x38F2470", Offset = "0x38F0A70", VA = "0x1838F2470", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x38F24E0", Offset = "0x38F0AE0", VA = "0x1838F24E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x38F25F0", Offset = "0x38F0BF0", VA = "0x1838F25F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x38F21F0", Offset = "0x38F07F0", VA = "0x1838F21F0")]
		private void EKAELDNMMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x38F2080", Offset = "0x38F0680", VA = "0x1838F2080")]
		private void DPIMHHGOFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x38F1C20", Offset = "0x38F0220", VA = "0x1838F1C20")]
		private void CBBLKHGBGBI(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x38F1F40", Offset = "0x38F0540", VA = "0x1838F1F40")]
		private void DINOAJBIEAD(NativeArray<Entity> IJBCECFNJIL, int NCACOMDBOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x38F2300", Offset = "0x38F0900", VA = "0x1838F2300")]
		private void IFJFIJAIMCE(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x38F2410", Offset = "0x38F0A10", VA = "0x1838F2410")]
		private void JLPIFAPJIHD(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void EBKNAIOEKJA(int NPMIJOEHCCM, Transform HJLACGOIJCA, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class LDOOHBIHGMH
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC500", Offset = "0x3BCAB00", VA = "0x183BCC500")]
	public static bool EBJLMCBIAOH(this SystemBase HKMOJLJDDFO, out Entity FLADPKIONGF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery IFECNBPINBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private MJFDNFOLGPA KHMJCDEBCKO;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x38FAF70", Offset = "0x38F9570", VA = "0x1838FAF70", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x38FAFC0", Offset = "0x38F95C0", VA = "0x1838FAFC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x38FB080", Offset = "0x38F9680", VA = "0x1838FB080", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<JDPEHMOPLMI>, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string MNFOGBIPLGJ = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private NOFMFNFCABJ FNHCMJBPAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery MKLGCILLFEP;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity OCOMFHFAHOF
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x387E430", Offset = "0x387CA30", VA = "0x18387E430")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x387E510", Offset = "0x387CB10", VA = "0x18387E510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity CAFBNGCEACD
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x387EDF0", Offset = "0x387D3F0", VA = "0x18387EDF0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public NIALADIPDNC HDJONJGBALG
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x387E650", Offset = "0x387CC50", VA = "0x18387E650")]
			get
			{
				return default(NIALADIPDNC);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x387E710", Offset = "0x387CD10", VA = "0x18387E710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public NIALADIPDNC LIMJLNEJNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x387E780", Offset = "0x387CD80", VA = "0x18387E780")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x387ECD0", Offset = "0x387D2D0", VA = "0x18387ECD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x387E960", Offset = "0x387CF60", VA = "0x18387E960", Slot = "15")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x387ED70", Offset = "0x387D370", VA = "0x18387ED70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x387E810", Offset = "0x387CE10", VA = "0x18387E810", Slot = "14")]
		protected override void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x387E570", Offset = "0x387CB70", VA = "0x18387E570")]
		private void DEFNLDFODMJ(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x387E9D0", Offset = "0x387CFD0", VA = "0x18387E9D0")]
		private void NMAMEDOPGMF(Entity FLADPKIONGF, Entity KLNJIPMLJAD, Entity CFFOBEPMEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x4472D60", Offset = "0x4471360", VA = "0x184472D60")]
		private bool DJEIEOEOGPA<T>(out T MAKFNMHIJIF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x4472DF0", Offset = "0x44713F0", VA = "0x184472DF0")]
		private void FFFKFHDEEJJ<T>(T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x387E490", Offset = "0x387CA90", VA = "0x18387E490")]
		public bool BBAFLDMEEIM(NIALADIPDNC FPHANPAOKPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x387E6E0", Offset = "0x387CCE0", VA = "0x18387E6E0")]
		private static bool FLOODIHMIPG(NIALADIPDNC BAOOHKEMBGH, NIALADIPDNC PPFCNPGDEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x387EEA0", Offset = "0x387D4A0", VA = "0x18387EEA0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x387EC90", Offset = "0x387D290", VA = "0x18387EC90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x39034F0", Offset = "0x3901AF0", VA = "0x1839034F0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x3903650", Offset = "0x3901C50", VA = "0x183903650", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x39036F0", Offset = "0x3901CF0", VA = "0x1839036F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x39033A0", Offset = "0x39019A0", VA = "0x1839033A0")]
		private NativeArray<Entity> KOIIMLDOFEM(int FPLNDBJJHMM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x3903540", Offset = "0x3901B40", VA = "0x183903540")]
		private void ONECENODGNM(NativeArray<Entity> EBBFGPFNGNP, NativeArray<Entity> EBBPNAKFEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	internal class HideRemotePivotsNotInScope : CPOPPILPLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery PIOLDADJACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery JFGJKAKPHLO;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x3BC18B0", Offset = "0x3BBFEB0", VA = "0x183BC18B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x3BC19A0", Offset = "0x3BBFFA0", VA = "0x183BC19A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class PMHIDAAHLJC
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string ONHOMEGAKHH = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x356B310", Offset = "0x3569910", VA = "0x18356B310")]
	public static NativeArray<T> ABPAKOFKCJN<T>(NativeArray<Entity> IJBCECFNJIL, EntityManager LNPEGOPJJGK) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x3894390", Offset = "0x3892990", VA = "0x183894390")]
	public static void IKOJLOGIDDJ(EntityQuery AMEIGJPGLKK, EntityManager LNPEGOPJJGK, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x3894260", Offset = "0x3892860", VA = "0x183894260")]
	public static void FFNPPDNMKMI(NativeArray<Entity> EBBFGPFNGNP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x3894130", Offset = "0x3892730", VA = "0x183894130")]
	public static void CAHGGOAHPFE(NativeArray<Entity> EBBFGPFNGNP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService BKOGMAMFIBB;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x78EB20", Offset = "0x78D120", VA = "0x18078EB20", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x78EBB0", Offset = "0x78D1B0", VA = "0x18078EBB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x78EC50", Offset = "0x78D250", VA = "0x18078EC50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x78E310", Offset = "0x78C910", VA = "0x18078E310")]
		private void JNDEHBKDDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x78DD70", Offset = "0x78C370", VA = "0x18078DD70")]
		private void AMNAMPNLINA(NativeArray<Entity> EBBFGPFNGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x78EC60", Offset = "0x78D260", VA = "0x18078EC60")]
		private void PHJOLNFEMIJ(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x78F530", Offset = "0x78DB30", VA = "0x18078F530")]
		private void POGOAFJBNIP(NativeArray<Entity> EBBPNAKFEMI, NativeArray<RigidTransform> OIGFGPHKEAB, NativeArray<RigidTransform> FPINOMFIINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x78DE80", Offset = "0x78C480", VA = "0x18078DE80")]
		private void CHEAAFIHFBG(NativeArray<RigidTransform> FPINOMFIINJ, NativeArray<Entity> EBBPNAKFEMI, NativeList<Entity> PAOOLNPAMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class PostGameplayOnScopeChange : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery IFECNBPINBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery MDNPLGOEKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x3898BD0", Offset = "0x38971D0", VA = "0x183898BD0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3898C40", Offset = "0x3897240", VA = "0x183898C40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3898D90", Offset = "0x3897390", VA = "0x183898D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x3898B60", Offset = "0x3897160", VA = "0x183898B60")]
		private void BPFEAIHKCJD(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery HHDFGKJPDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents AKGGBDCLIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private MJFDNFOLGPA KHMJCDEBCKO;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x389A290", Offset = "0x3898890", VA = "0x18389A290", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x389A4B0", Offset = "0x3898AB0", VA = "0x18389A4B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x389A550", Offset = "0x3898B50", VA = "0x18389A550", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x389A320", Offset = "0x3898920", VA = "0x18389A320")]
		private void NHABEAMIBKM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<JHHOHHJIPMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x779B40", Offset = "0x778140", VA = "0x180779B40", Slot = "14")]
		protected override void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x779A70", Offset = "0x778070", VA = "0x180779A70")]
		[BurstCompile]
		private static void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CCFJELKOCGI, ComponentDataFromEntity<global::PLGKGDLBNHN> HGGBDJIEDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x779CD0", Offset = "0x7782D0", VA = "0x180779CD0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x779C90", Offset = "0x778290", VA = "0x180779C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[DAINLFLPADL(OHEDAGNNHJA.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : CPOPPILPLCL where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery EIJNNMKBFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery GBLNONFOPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery EKMIANFMMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery ACGEFAEFBMH;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3617080", Offset = "0x3615680", VA = "0x183617080", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3617280", Offset = "0x3615880", VA = "0x183617280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3617250", Offset = "0x3615850", VA = "0x183617250", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x3615E50", Offset = "0x3614450", VA = "0x183615E50")]
		private void JNPDMGMMJKL(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x36166D0", Offset = "0x3614CD0", VA = "0x1836166D0")]
		private void JPGPIDFEDIM(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3615A00", Offset = "0x3614000", VA = "0x183615A00")]
		private void AAEEFJOGMBO(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3617310", Offset = "0x3615910", VA = "0x183617310")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x335C4A0", Offset = "0x335AAA0", VA = "0x18335C4A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class EONJFGKPAOD : CPOPPILPLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> GDDMJGIBAFL;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2050", Offset = "0x3BB0650", VA = "0x183BB2050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2250", Offset = "0x3BB0850", VA = "0x183BB2250", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x3BB23A0", Offset = "0x3BB09A0", VA = "0x183BB23A0")]
	public EONJFGKPAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct DOJOLOPDIDF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int DNFPKCNMAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int HOBPJIMDIAG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x1AA6C10", Offset = "0x1AA5210", VA = "0x181AA6C10")]
	public static Entity DGKBAOBECFH(DOJOLOPDIDF JIHCLPECHIB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x1AA6C10", Offset = "0x1AA5210", VA = "0x181AA6C10")]
	public static DOJOLOPDIDF DGKBAOBECFH(Entity FLADPKIONGF)
	{
		return default(DOJOLOPDIDF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct KBEINJNNGOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct IFHANGOBDPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType ALGBEENOGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> BGLJHEFMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> MGCBIKMPPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> IJBCECFNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> CIMNNGLPNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> ONJEGBJDGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> OBFMOAOGODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int FFDNEEBDPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int KEDIELKNBEI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool NIOCGKDBNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5330", Offset = "0x3BC3930", VA = "0x183BC5330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC53B0", Offset = "0x3BC39B0", VA = "0x183BC53B0")]
	public IFHANGOBDPE(ComponentType ALGBEENOGLE, NativeList<int> BGLJHEFMNHL, NativeList<int> MGCBIKMPPGP, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CIMNNGLPNBL, NativeArray<byte> ONJEGBJDGFD, NativeArray<byte> OBFMOAOGODB, int FFDNEEBDPLF, int KEDIELKNBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5200", Offset = "0x3BC3800", VA = "0x183BC5200")]
	private COGGJKLIPPL INOJGPBPIIG(NativeArray<byte> HEONDDEAIBL, int EBBLFLFCHFB)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T INOJGPBPIIG<T>(NativeArray<byte> HEONDDEAIBL, int EBBLFLFCHFB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x3BC51B0", Offset = "0x3BC37B0", VA = "0x183BC51B0")]
	public COGGJKLIPPL HOJLODFJNMC(int EBBLFLFCHFB)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T HOJLODFJNMC<T>(int EBBLFLFCHFB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5160", Offset = "0x3BC3760", VA = "0x183BC5160")]
	public COGGJKLIPPL EDHFDFJHJJJ(int EBBLFLFCHFB)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T EDHFDFJHJJJ<T>(int EBBLFLFCHFB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5080", Offset = "0x3BC3680", VA = "0x183BC5080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct OPLPBOKJNKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<OHEJDJOONHG> KECMGAIBBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType ALGBEENOGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int FFDNEEBDPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int KEDIELKNBEI;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x3884DB0", Offset = "0x38833B0", VA = "0x183884DB0")]
	public OPLPBOKJNKG(ComponentType ALGBEENOGLE, int FFDNEEBDPLF, int KEDIELKNBEI, EntityQuery AMEIGJPGLKK, NativeArray<OHEJDJOONHG> KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x3884D60", Offset = "0x3883360", VA = "0x183884D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct JGGFKCAKJNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int EBBLFLFCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int BMBPPOJNIBK;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950")]
	public JGGFKCAKJNP(int EBBLFLFCHFB, int BMBPPOJNIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct OHEJDJOONHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int ADDILPEFEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int JLMAIAGOBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950")]
	public OHEJDJOONHG(int ADDILPEFEHP, int JLMAIAGOBFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct KCFNAMGFMNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly HDFAPEIIIAK CBBOJGIJLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int FFDNEEBDPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* ONJEGBJDGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* OBFMOAOGODB;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8230", Offset = "0x3BC6830", VA = "0x183BC8230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public HDFAPEIIIAK GOODPMCPKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0")]
		get
		{
			return default(HDFAPEIIIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8330", Offset = "0x3BC6930", VA = "0x183BC8330")]
	public COGGJKLIPPL GJJAFAPMIOG(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8240", Offset = "0x3BC6840", VA = "0x183BC8240")]
	public COGGJKLIPPL EDJFNOLGIKK(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x308DDC0", Offset = "0x308C3C0", VA = "0x18308DDC0")]
	public T GJJAFAPMIOG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x308DDA0", Offset = "0x308C3A0", VA = "0x18308DDA0")]
	public T EDJFNOLGIKK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8420", Offset = "0x3BC6A20", VA = "0x183BC8420")]
	public unsafe KCFNAMGFMNK(HDFAPEIIIAK CBBOJGIJLHN, int JLMAIAGOBFJ, byte* ONJEGBJDGFD, byte* OBFMOAOGODB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class AAJMJDCHNIG : OILIIHGJOFP, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService AGNKNPKFJDG;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract IGGCJBCLGAF AEGMIKGAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x38EC970", Offset = "0x38EAF70", VA = "0x1838EC970", Slot = "17")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x38EC9C0", Offset = "0x38EAFC0", VA = "0x1838EC9C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x38EC730", Offset = "0x38EAD30", VA = "0x1838EC730", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	protected AAJMJDCHNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class BMCKGDCDHLI
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] AADPMGJNDLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class PIFFPMLCLFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, OPLPBOKJNKG> JIANONPNEOD;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OPLPBOKJNKG EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x3893B80", Offset = "0x3892180", VA = "0x183893B80")]
		get
		{
			return default(OPLPBOKJNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x3893F20", Offset = "0x3892520", VA = "0x183893F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x3894020", Offset = "0x3892620", VA = "0x183894020")]
	public PIFFPMLCLFK(LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x3893C10", Offset = "0x3892210", VA = "0x183893C10")]
	public bool IDEDABPJLGL(ComponentType ALGBEENOGLE, out OPLPBOKJNKG ILAPGNJICNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x3893550", Offset = "0x3891B50", VA = "0x183893550")]
	public Dictionary<ComponentType, OPLPBOKJNKG>.Enumerator CBILBBMABKJ()
	{
		return default(Dictionary<ComponentType, OPLPBOKJNKG>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x38935E0", Offset = "0x3891BE0", VA = "0x1838935E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x3893780", Offset = "0x3891D80", VA = "0x183893780")]
	private void FKKKKGBGGDI(IEnumerable<LDCIHJCLMHG> BNBJOMLPPDN, EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x3893F70", Offset = "0x3892570", VA = "0x183893F70")]
	private static int NFNJEIBJGEF(LDCIHJCLMHG JDPNBCGEEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x3893C80", Offset = "0x3892280", VA = "0x183893C80")]
	private static NativeArray<OHEJDJOONHG> KPAIGOGOJFL(LDCIHJCLMHG JDPNBCGEEAE, Allocator GGLOKAHPEPM = Allocator.Persistent)
	{
		return default(NativeArray<OHEJDJOONHG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface ACMLCBMOLDA
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool NIOCGKDBNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNDJCGDPFIO(out NativeArray<int> DFCIIJDJCIO, Allocator GGLOKAHPEPM);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KBPFGDPENMH(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI, out OPLPBOKJNKG PAGFKHPKKBH);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KBPFGDPENMH(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IFHANGOBDPE DOCBOGMCJNA(ComponentType ALGBEENOGLE);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LBOLGJICLNI EBKBECKNFKL();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GALEMMGPNDI(JobHandle AHIGBHNJKNN);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
internal interface DBNCKKCNGJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	PIFFPMLCLFK MOKNNLHOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	APMEOIGEMKF LDAMNDHBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, KCFNAMGFMNK> FBCJIELGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle OGDHEGKHIPI
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
	bool IFEPEMKMGAF();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGHHBKOCHPM();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMPIEOMAKFP(ComponentType ALGBEENOGLE, in IFHANGOBDPE JDHBAMAGEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OPDDPHAHDGH(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct LBOLGJICLNI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct GOBAIJEKNID : IEnumerator<KCFNAMGFMNK>, IEnumerator, IDisposable, IEnumerable<KCFNAMGFMNK>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, KCFNAMGFMNK> BLDLHAOGGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity FLADPKIONGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> NCOBEJFFHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private KCFNAMGFMNK OBFMOAOGODB;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public KCFNAMGFMNK BMLOECHOMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x8F31D0", Offset = "0x8F17D0", VA = "0x1808F31D0", Slot = "4")]
			get
			{
				return default(KCFNAMGFMNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0xDF5FC0", Offset = "0xDF45C0", VA = "0x180DF5FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xDF6010", Offset = "0xDF4610", VA = "0x180DF6010")]
		internal GOBAIJEKNID(NativeMultiHashMap<Entity, KCFNAMGFMNK> BLDLHAOGGDA, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xDF5DB0", Offset = "0xDF43B0", VA = "0x180DF5DB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xDF5D80", Offset = "0xDF4380", VA = "0x180DF5D80")]
		public GOBAIJEKNID CBILBBMABKJ()
		{
			return default(GOBAIJEKNID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xDF5E80", Offset = "0xDF4480", VA = "0x180DF5E80", Slot = "9")]
		private IEnumerator<KCFNAMGFMNK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xDF5F20", Offset = "0xDF4520", VA = "0x180DF5F20", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly DBNCKKCNGJJ BLJBLMCPLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle COLJNHAKGBC;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int JJPJIPJFIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC070", Offset = "0x3BCA670", VA = "0x183BCC070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC2D0", Offset = "0x3BCA8D0", VA = "0x183BCC2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0xD92800", Offset = "0xD90E00", VA = "0x180D92800")]
	public LBOLGJICLNI(DBNCKKCNGJJ BLJBLMCPLPH, JobHandle COLJNHAKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x3BCBF30", Offset = "0x3BCA530", VA = "0x183BCBF30")]
	public bool CKGGCMKPNGB(Allocator GGLOKAHPEPM, out NativeKeyValueArrays<Entity, KCFNAMGFMNK> BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC160", Offset = "0x3BCA760", VA = "0x183BCC160")]
	public bool LPNGABLFNOL(Allocator GGLOKAHPEPM, out (NativeArray<Entity> entities, int uniqueCount) BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC3B0", Offset = "0x3BCA9B0", VA = "0x183BCC3B0")]
	public GOBAIJEKNID PFFCMCFDEGB(Entity FLADPKIONGF)
	{
		return default(GOBAIJEKNID);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class APMEOIGEMKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<OPLPBOKJNKG> ACLENHAHHHH;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public OPLPBOKJNKG EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x38F0AE0", Offset = "0x38EF0E0", VA = "0x1838F0AE0")]
		get
		{
			return default(OPLPBOKJNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x38F0B70", Offset = "0x38EF170", VA = "0x1838F0B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x38F0BB0", Offset = "0x38EF1B0", VA = "0x1838F0BB0")]
	public APMEOIGEMKF(PIFFPMLCLFK JIANONPNEOD, LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x38F05A0", Offset = "0x38EEBA0", VA = "0x1838F05A0")]
	public List<OPLPBOKJNKG>.Enumerator CBILBBMABKJ()
	{
		return default(List<OPLPBOKJNKG>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x38F0620", Offset = "0x38EEC20", VA = "0x1838F0620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x38F07A0", Offset = "0x38EEDA0", VA = "0x1838F07A0")]
	private void FKKKKGBGGDI(PIFFPMLCLFK JIANONPNEOD, EntityManager LNPEGOPJJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class DPDLGGKHONK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService EJCAANKBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::CBENKMECBMN<LDCIHJCLMHG> HHPGIIAPEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World PEOBGDFFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> KAIBGIFEHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x390B1C0", Offset = "0x39097C0", VA = "0x18390B1C0")]
	public DPDLGGKHONK(ObjectInstantiationService EJCAANKBGPG, LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x3909E80", Offset = "0x3908480", VA = "0x183909E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x390B160", Offset = "0x3909760", VA = "0x18390B160")]
	public bool OABIHIPJEOM(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x390A100", Offset = "0x3908700", VA = "0x18390A100")]
	private void HCKIKFOPLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x3909950", Offset = "0x3907F50", VA = "0x183909950")]
	private EntityArchetype BAJDKJLJBCF(EntityArchetype CLMPEOBNPPG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x390AA80", Offset = "0x3909080", VA = "0x18390AA80")]
	public static void NDOCCMNEPAB(EntityManager OPLEGACAFEB, EntityManager PCGCHIPEABE, NativeArray<Entity> FOMMJLEICDI, NativeArray<EntityArchetype> OBKKKOHOLJM, [Optional] NativeArray<Entity> HDMJCPIPBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x390AFF0", Offset = "0x39095F0", VA = "0x18390AFF0")]
	[Conditional("DEBUG_BUILD")]
	private static void NPOKKHDAODA(NativeArray<EntityArchetype> CGBHJDKNJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x390A760", Offset = "0x3908D60", VA = "0x18390A760")]
	private static string KABCHDDLAJE(EntityArchetype HEFFAMIFPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x390AEB0", Offset = "0x39094B0", VA = "0x18390AEB0")]
	[CompilerGenerated]
	internal static void NPODIEAADLG(ref Span<ComponentType> JICGAPJOBOB, ComponentType MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3909F50", Offset = "0x3908550", VA = "0x183909F50")]
	[CompilerGenerated]
	internal static void FHOABOKDBBH(Span<ComponentType> HEONDDEAIBL, ref Span<ComponentType> JICGAPJOBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x390A9A0", Offset = "0x3908FA0", VA = "0x18390A9A0")]
	[CompilerGenerated]
	internal static void LDAHHFOLHIA(Span<ComponentType> HEONDDEAIBL, ref Span<ComponentType> JICGAPJOBOB, ComponentType GLAGKBEAACJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld GICDCNOHNPL;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x38F1AB0", Offset = "0x38F00B0", VA = "0x1838F1AB0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x38F1B70", Offset = "0x38F0170", VA = "0x1838F1B70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[DAINLFLPADL(OHEDAGNNHJA.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : CPOPPILPLCL, GOJCOOFCPOI, GKFAMMKGENJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct IMBEKBFJLGG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> EJFCOBLOHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> HJBJBEDALII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<OHEJDJOONHG> DICNKIMDLHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<JGGFKCAKJNP>.ParallelWriter JECJGPHDMBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int LIEPJCIEEHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int DDKADHDEGFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker KCFPDFHKLEG;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x777800", Offset = "0x775E00", VA = "0x180777800", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x777770", Offset = "0x775D70", VA = "0x180777770")]
			private unsafe int EHKEBJNFPCK(byte* HNCMGHCGCEP, byte* AALANACCLGM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct HPHBACNCGKF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> BGLJHEFMNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> ADDKLOEEHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<JGGFKCAKJNP> PEGLPLKBCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker KCFPDFHKLEG;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x777240", Offset = "0x775840", VA = "0x180777240", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct KBCJHKGDKCB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> DPDMHDOLOGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public KAHEOPHNBCB JCOGCPOLJOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int FFDNEEBDPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker KCFPDFHKLEG;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x777940", Offset = "0x775F40", VA = "0x180777940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct HIHLHGBPNKL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, KCFNAMGFMNK> JODGBANCIIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> ONJEGBJDGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> OBFMOAOGODB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<OHEJDJOONHG> NFFPHBPIHDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> MGCBIKMPPGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> BGLJHEFMNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int FCMLCBALFAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int KEDIELKNBEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker KCFPDFHKLEG;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x776FC0", Offset = "0x7755C0", VA = "0x180776FC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker BBFFKNBFNIF;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker GBILFNENAKI;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker HMDFPLDNFMD;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker HMPFBOLGLGN;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker CHKBODCJEBA;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker AHKIAEBNMCN;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker OAKBMKLFBGL;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker MILGIEGMLHO;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker DGLAIKIGNDH;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker LOAHMECJFMP;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker PBAKIHAPAAB;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker FLKACNGMFKD;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker FCEIPMMBAAD;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker KJFDEDFLEBM;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker NLLCAABIMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService AGNKNPKFJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery BPJPGLJIBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery HDFADBKIHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery DGNOJLLLEJB;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World KBIJMFLFDFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x38FC180", Offset = "0x38FA780", VA = "0x1838FC180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private DBNCKKCNGJJ CJEEMAGCIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x38FB440", Offset = "0x38F9A40", VA = "0x1838FB440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x38FDD00", Offset = "0x38FC300", VA = "0x1838FDD00", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "15")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x38FDDD0", Offset = "0x38FC3D0", VA = "0x1838FDDD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x38FDF90", Offset = "0x38FC590", VA = "0x1838FDF90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x38FDF20", Offset = "0x38FC520", VA = "0x1838FDF20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x38FB140", Offset = "0x38F9740", VA = "0x1838FB140")]
		private void AEICDKNOBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD620", Offset = "0x38FBC20", VA = "0x1838FD620")]
		internal void LEBADALCGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x38FCE40", Offset = "0x38FB440", VA = "0x1838FCE40")]
		private void LEBADALCGDC(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x38FB460", Offset = "0x38F9A60", VA = "0x1838FB460")]
		private void CECPDIFHFIG(NativeArray<Entity> FOMMJLEICDI, NativeArray<RRObjectPrefabData> BJIJCMMGOKN, ref NativeArray<Entity> EKHJECGFOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x38FDCE0", Offset = "0x38FC2E0", VA = "0x1838FDCE0")]
		internal void NDDLDJCGGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x38FD8E0", Offset = "0x38FBEE0", VA = "0x1838FD8E0")]
		private void NDDLDJCGGGG(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x38FC240", Offset = "0x38FA840", VA = "0x1838FC240")]
		internal void IMFEJLKPDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x38FCB60", Offset = "0x38FB160", VA = "0x1838FCB60")]
		private void KEJCJEEBBIO(DBNCKKCNGJJ BLJBLMCPLPH, OPLPBOKJNKG PAGFKHPKKBH, bool NFCFCKAGAJP, ref JobHandle OLKLNNNEFHL, ref JobHandle GHGACIMPAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x38FC0A0", Offset = "0x38FA6A0", VA = "0x1838FC0A0")]
		internal bool DKLMPNHJNHA(in OPLPBOKJNKG AALANACCLGM, out JobHandle ODMNDKFKJHN, out IFHANGOBDPE ACMPOMMGGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x38FB6A0", Offset = "0x38F9CA0", VA = "0x1838FB6A0")]
		private bool DKLMPNHJNHA(in OPLPBOKJNKG AALANACCLGM, bool NFCFCKAGAJP, out JobHandle ODMNDKFKJHN, out IFHANGOBDPE ACMPOMMGGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x38FC9A0", Offset = "0x38FAFA0", VA = "0x1838FC9A0")]
		internal (NativeList<int>, NativeList<int>) KDPLLCKOKLL(NativeList<JGGFKCAKJNP> PEGLPLKBCDI, int FHGNFGIEADL, JobHandle BAMHFDJJPAO, out JobHandle AHIGBHNJKNN, Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x38FC0D0", Offset = "0x38FA6D0", VA = "0x1838FC0D0")]
		internal static NativeArray<Entity> DNLJONLDHCE(EntityQuery AMEIGJPGLKK, out JobHandle LLLMIBOLDJD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x38FDD50", Offset = "0x38FC350", VA = "0x1838FDD50")]
		internal static NativeArray<byte> OPJNCDPBIJI(int PPJLGCLGPJE, out JobHandle BMDDFOONLKG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x38FD7D0", Offset = "0x38FBDD0", VA = "0x1838FD7D0")]
		internal static NativeArray<byte> MPDMMBPDNFF(EntityQuery AMEIGJPGLKK, int HIMMGNBBIHM, out JobHandle BMDDFOONLKG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x38FE340", Offset = "0x38FC940", VA = "0x1838FE340")]
		internal static NativeArray<Entity> PNONOLIOHMK(EntityQuery AMEIGJPGLKK, out JobHandle EPHHCLCDHAA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x38FE0D0", Offset = "0x38FC6D0", VA = "0x1838FE0D0")]
		internal NativeArray<byte> PAFBKNHDKBJ(NativeArray<Entity> IJBCECFNJIL, OPLPBOKJNKG PAGFKHPKKBH, JobHandle BAMHFDJJPAO, out JobHandle AHIGBHNJKNN, Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x38FD640", Offset = "0x38FBC40", VA = "0x1838FD640")]
		internal JobHandle LOMGGHDHLLJ(in IFHANGOBDPE JIHCLPECHIB, in OPLPBOKJNKG PAGFKHPKKBH, NativeMultiHashMap<Entity, KCFNAMGFMNK> JODGBANCIIN, JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xDFEA00", Offset = "0xDFD000", VA = "0x180DFEA00")]
		private JobHandle AMAIHJKEGHF(JobHandle ECECGDFDCNH, JobHandle IPPDCMIFCOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xDFEA00", Offset = "0xDFD000", VA = "0x180DFEA00")]
		private JobHandle AMAIHJKEGHF(JobHandle ECECGDFDCNH, JobHandle IPPDCMIFCOL, JobHandle LOCNNLCCGAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[DAINLFLPADL(OHEDAGNNHJA.RenderEffects)]
	internal class PropagateHoverRootTag : DLIGPDHAAFN
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct KDJEGJLGELP : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType NBDNNKCDLBF
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x389AE90", Offset = "0x3899490", VA = "0x18389AE90", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x389AE30", Offset = "0x3899430", VA = "0x18389AE30", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x389AE60", Offset = "0x3899460", VA = "0x18389AE60", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x389AEC0", Offset = "0x38994C0", VA = "0x18389AEC0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[DAINLFLPADL(OHEDAGNNHJA.RenderEffects)]
	internal class PropagateSelectionRootTag : DLIGPDHAAFN
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct CHANADMGBEI : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType NBDNNKCDLBF
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x389AF30", Offset = "0x3899530", VA = "0x18389AF30", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x389AED0", Offset = "0x38994D0", VA = "0x18389AED0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x389AF00", Offset = "0x3899500", VA = "0x18389AF00", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x389AEC0", Offset = "0x38994C0", VA = "0x18389AEC0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[LLNAOBNNFAO]
public class OKNOOGJABCA : GJKIDHCFCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x3884640", Offset = "0x3882C40", VA = "0x183884640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x38846D0", Offset = "0x3882CD0", VA = "0x1838846D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public OKNOOGJABCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[LLNAOBNNFAO]
public class KCGCJDJECHM : GJKIDHCFCFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct PHMFDJLKCEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public PHMFDJLKCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct DCJCLGNNCAB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct PPJHANKGAOK
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct HKJAFDCBHLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime IJMEMNAOIKB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> MKLKIMDBMEF;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0xDFD000", Offset = "0xDFB600", VA = "0x180DFD000")]
			public void KBLGIFLFDKL(KCGCJDJECHM AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0xDFCF80", Offset = "0xDFB580", VA = "0x180DFCF80")]
			public HKJAFDCBHLE BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(HKJAFDCBHLE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager LNPEGOPJJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> PHCAHOKKOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private PPJHANKGAOK OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PPJHANKGAOK.HKJAFDCBHLE* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate BKNPBKKLAAE;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0xDF3070", Offset = "0xDF1670", VA = "0x180DF3070")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, SplinePointParentData IGAJPNPGFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xDF3200", Offset = "0xDF1800", VA = "0x180DF3200", Slot = "5")]
		public void ReadFromDisplayClass(ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xDF3210", Offset = "0xDF1810", VA = "0x180DF3210", Slot = "6")]
		public void WriteToDisplayClass(ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xDF2F40", Offset = "0xDF1540", VA = "0x180DF2F40", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xDF3150", Offset = "0xDF1750", VA = "0x180DF3150")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref PPJHANKGAOK.HKJAFDCBHLE GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xDF2FE0", Offset = "0xDF15E0", VA = "0x180DF2FE0")]
		public void KBLGIFLFDKL(KCGCJDJECHM AJPOCCLBMGK, ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xDF30E0", Offset = "0xDF16E0", VA = "0x180DF30E0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery GLDNMGJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker HCHJCDDCHKD;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC87D0", Offset = "0x3BC6DD0", VA = "0x183BC87D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public KCGCJDJECHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC85A0", Offset = "0x3BC6BA0", VA = "0x183BC85A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8440", Offset = "0x3BC6A40", VA = "0x183BC8440")]
	public static EntityQuery AJCJKPKPFIA(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[LLNAOBNNFAO]
public class NIDKPHMDOEM : GJKIDHCFCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery OPKCHIEPCHE;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x3881CF0", Offset = "0x38802F0", VA = "0x183881CF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x3881D80", Offset = "0x3880380", VA = "0x183881D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public NIDKPHMDOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(OKNOOGJABCA))]
public class NNIIEMAEFCL : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x38822E0", Offset = "0x38808E0", VA = "0x1838822E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public NNIIEMAEFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class DGKJBIJADGO : GJKIDHCFCFK, GOJCOOFCPOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct LPDPNOELMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<COEEIJJLOPG, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public LPDPNOELMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AADCGACCECC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct LHMCLILFHIE
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct KFILMIEJOOB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BIJKNEGBNNB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CJLIMBDEGFM;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0xDF8CD0", Offset = "0xDF72D0", VA = "0x180DF8CD0")]
			public void KBLGIFLFDKL(DGKJBIJADGO AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xDF8C50", Offset = "0xDF7250", VA = "0x180DF8C50")]
			public KFILMIEJOOB BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(KFILMIEJOOB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private LHMCLILFHIE OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LHMCLILFHIE.KFILMIEJOOB* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x774250", Offset = "0x772850", VA = "0x180774250")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ObjectNetworkIdComponentData AMEIKDNDEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x7743F0", Offset = "0x7729F0", VA = "0x1807743F0", Slot = "5")]
		public void ReadFromDisplayClass(ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x774400", Offset = "0x772A00", VA = "0x180774400", Slot = "6")]
		public void WriteToDisplayClass(ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x7741A0", Offset = "0x7727A0", VA = "0x1807741A0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x774340", Offset = "0x772940", VA = "0x180774340")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref LHMCLILFHIE.KFILMIEJOOB GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x774210", Offset = "0x772810", VA = "0x180774210")]
		public void KBLGIFLFDKL(DGKJBIJADGO AJPOCCLBMGK, ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x7742D0", Offset = "0x7728D0", VA = "0x1807742D0")]
		public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService GEHGBPFFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery GLDNMGJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker HCHJCDDCHKD;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x3906690", Offset = "0x3904C90", VA = "0x183906690", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x39068F0", Offset = "0x3904EF0", VA = "0x1839068F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public DGKJBIJADGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x39066F0", Offset = "0x3904CF0", VA = "0x1839066F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x3906530", Offset = "0x3904B30", VA = "0x183906530")]
	public static EntityQuery AJCJKPKPFIA(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class NDLONCCLEBM : GJKIDHCFCFK, GOJCOOFCPOI
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HCAJNFFFDIC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct NABPGJACCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct EMHONEOJCOJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LAHCBGNEAFA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> DDJGAPIFCND;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0xDFA7F0", Offset = "0xDF8DF0", VA = "0x180DFA7F0")]
			public void KBLGIFLFDKL(NDLONCCLEBM AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0xDFA770", Offset = "0xDF8D70", VA = "0x180DFA770")]
			public EMHONEOJCOJ BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
			{
				return default(EMHONEOJCOJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public NDLONCCLEBM IEBCNDHHJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private NABPGJACCPJ OGDGLAIMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NABPGJACCPJ.EMHONEOJCOJ* DPLDENFBENA;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0xDF63D0", Offset = "0xDF49D0", VA = "0x180DF63D0")]
		public void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData INCKFPNOIFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xDF62B0", Offset = "0xDF48B0", VA = "0x180DF62B0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xDF6460", Offset = "0xDF4A60", VA = "0x180DF6460")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref NABPGJACCPJ.EMHONEOJCOJ GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xDF6350", Offset = "0xDF4950", VA = "0x180DF6350")]
		public void KBLGIFLFDKL(NDLONCCLEBM AJPOCCLBMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xDF63F0", Offset = "0xDF49F0", VA = "0x180DF63F0")]
		public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery GLDNMGJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker HCHJCDDCHKD;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x3881530", Offset = "0x387FB30", VA = "0x183881530", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x3881790", Offset = "0x387FD90", VA = "0x183881790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public NDLONCCLEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3881340", Offset = "0x387F940", VA = "0x183881340")]
	[CompilerGenerated]
	private void BCJPKPENCCL(Entity FLADPKIONGF, ParentData INCKFPNOIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x3881590", Offset = "0x387FB90", VA = "0x183881590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x38811E0", Offset = "0x387F7E0", VA = "0x1838811E0")]
	public static EntityQuery AJCJKPKPFIA(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class KPLIENFAMDN : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int MJOKJAOLAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery AMEIGJPGLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs EJCAANKBGPG;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA420", Offset = "0x3BC8A20", VA = "0x183BCA420", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA470", Offset = "0x3BC8A70", VA = "0x183BCA470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA550", Offset = "0x3BC8B50", VA = "0x183BCA550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA0D0", Offset = "0x3BC86D0", VA = "0x183BCA0D0")]
	private void ICDDEHKPDMI(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public KPLIENFAMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(KPLIENFAMDN))]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	public class PostLoadAddSceneTagEntity : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService LCJDMKABNOO;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x3898EA0", Offset = "0x38974A0", VA = "0x183898EA0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x3898EF0", Offset = "0x38974F0", VA = "0x183898EF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	[COKNBEFPPIE(HIFIKBEHMNK.OMRoom)]
	public class PostLoadInitializeNetworkId : CPOPPILPLCL, GOJCOOFCPOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct LPOOBMJNANI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<COEEIJJLOPG, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
			public LPOOBMJNANI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct BOJGKBDDPDO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct DCACJDGOIND
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct MEICIHILCDM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime BNHHNEMAKBG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime BIJKNEGBNNB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex PEJKJGBDGEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CJLIMBDEGFM;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0xDF2ED0", Offset = "0xDF14D0", VA = "0x180DF2ED0")]
				public void KBLGIFLFDKL(PostLoadInitializeNetworkId AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0xDF2E20", Offset = "0xDF1420", VA = "0x180DF2E20")]
				public MEICIHILCDM BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(MEICIHILCDM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private DCACJDGOIND OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DCACJDGOIND.MEICIHILCDM* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate BKNPBKKLAAE;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0xDF23E0", Offset = "0xDF09E0", VA = "0x180DF23E0")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, int JMJIFFLHKMK, ref ObjectNetworkIdComponentData AMEIKDNDEPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x7743F0", Offset = "0x7729F0", VA = "0x1807743F0", Slot = "5")]
			public void ReadFromDisplayClass(ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x774400", Offset = "0x772A00", VA = "0x180774400", Slot = "6")]
			public void WriteToDisplayClass(ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xDF2250", Offset = "0xDF0850", VA = "0x180DF2250", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xDF24E0", Offset = "0xDF0AE0", VA = "0x180DF24E0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref DCACJDGOIND.MEICIHILCDM GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0xDF2340", Offset = "0xDF0940", VA = "0x180DF2340")]
			public void KBLGIFLFDKL(PostLoadInitializeNetworkId AJPOCCLBMGK, ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0xDF2470", Offset = "0xDF0A70", VA = "0x180DF2470")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[CJONPMHNDBN]
		private ObjectNetworkToLocalMapService GEHGBPFFMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[CJONPMHNDBN]
		private SceneService LLLBMIKLOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery AMEIGJPGLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery FBKDGLCHICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker GDCKCFEMKJN;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x38998C0", Offset = "0x3897EC0", VA = "0x1838998C0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x3899BC0", Offset = "0x38981C0", VA = "0x183899BC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x3899100", Offset = "0x3897700", VA = "0x183899100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x3899100", Offset = "0x3897700", VA = "0x183899100")]
		public void FHPOEBEBBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x38991D0", Offset = "0x38977D0", VA = "0x1838991D0")]
		private void FODIPOHKKJL(NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x3899C60", Offset = "0x3898260", VA = "0x183899C60")]
		private void PDKGKDDNOPB(NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3899930", Offset = "0x3897F30", VA = "0x183899930", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3899720", Offset = "0x3897D20", VA = "0x183899720")]
		public static EntityQuery LOIIIOOFDJD(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class GHFCNJAKHBB : CPOPPILPLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery JJGNMBCNOBG;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD7E0", Offset = "0x3BBBDE0", VA = "0x183BBD7E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD870", Offset = "0x3BBBE70", VA = "0x183BBD870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public GHFCNJAKHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class BNOBBBKDDOG : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::CBENKMECBMN<PDFDIHHBJJI> FOPABEIBOJL;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x38F51B0", Offset = "0x38F37B0", VA = "0x1838F51B0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x38F5320", Offset = "0x38F3920", VA = "0x1838F5320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x38F5020", Offset = "0x38F3620", VA = "0x1838F5020")]
	private void JEAKLBDGLAC(NativeList<EntityArchetype> CGBHJDKNJLN, NativeHashMap<int, ABCENELPPGI> LDINHFJLBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x38F48E0", Offset = "0x38F2EE0", VA = "0x1838F48E0")]
	private Span<int> DFKHFDNDCHD(EntityArchetype HEFFAMIFPAM)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x38F5250", Offset = "0x38F3850", VA = "0x1838F5250")]
	private bool NMIJGFEDPDM(int HIMMGNBBIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x38F4A20", Offset = "0x38F3020", VA = "0x1838F4A20")]
	private void EAAKFCOEKEC(NativeHashMap<int, ABCENELPPGI> LDINHFJLBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public BNOBBBKDDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[DAINLFLPADL(OHEDAGNNHJA.Serialization)]
	public class PreSerializeRemoveEntities : CPOPPILPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery GONBIMIDNGM;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x3899F10", Offset = "0x3898510", VA = "0x183899F10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x389A190", Offset = "0x3898790", VA = "0x18389A190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[DAINLFLPADL(OHEDAGNNHJA.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : CPOPPILPLCL, GOJCOOFCPOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct GKKONMNHANL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public KAHEOPHNBCB dstComponentData;

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
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
			public GKKONMNHANL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x777DA0", Offset = "0x7763A0", VA = "0x180777DA0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LNONLOBGEGL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> BGLJHEFMNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> CIMNNGLPNBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public KAHEOPHNBCB HBJCMKAFLLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> OBFMOAOGODB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int FFDNEEBDPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType ALGBEENOGLE;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0xDF93A0", Offset = "0xDF79A0", VA = "0x180DF93A0")]
			internal void KFDLFOBMEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0xDF9560", Offset = "0xDF7B60", VA = "0x180DF9560", Slot = "5")]
			public void ReadFromDisplayClass(ref GKKONMNHANL IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xDF9370", Offset = "0xDF7970", VA = "0x180DF9370", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0xDF9380", Offset = "0xDF7980", VA = "0x180DF9380")]
			public void KBLGIFLFDKL(ShadowWorldApplyPropertyDifferencesToShadowWorld AJPOCCLBMGK, ref GKKONMNHANL IMEAEFOFEDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService AGNKNPKFJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle CBELCOICLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle CFHAOHCNNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private ACMLCBMOLDA BLJBLMCPLPH;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x77F840", Offset = "0x77DE40", VA = "0x18077F840", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x77F8A0", Offset = "0x77DEA0", VA = "0x18077F8A0")]
		public JobHandle NNEMCMGIMIK(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x77F8E0", Offset = "0x77DEE0", VA = "0x18077F8E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x77FC80", Offset = "0x77E280", VA = "0x18077FC80")]
		private bool PIFPLAGNNAP(JobHandle BAMHFDJJPAO, int HIMMGNBBIHM, out JobHandle OJPHDFDEEHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(MIDLJCMMMGD))]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal sealed class CECIJINLABK : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x38F7CF0", Offset = "0x38F62F0", VA = "0x1838F7CF0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public CECIJINLABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[BCMMDDALFAJ]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
[UpdateInGroup(typeof(JJLONPGGJEC))]
internal sealed class DNOBEGFCEOA : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x3908C80", Offset = "0x3907280", VA = "0x183908C80", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public DNOBEGFCEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[BCMMDDALFAJ]
[ExecuteAlways]
[UpdateInGroup(typeof(BNOGFJKHCCG))]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal sealed class GHJCKFNOCDG : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE260", Offset = "0x3BBC860", VA = "0x183BBE260", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public GHJCKFNOCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[BCMMDDALFAJ]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
[UpdateInGroup(typeof(CODLCFFJGHP))]
internal sealed class NAKNKCDHKAE : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x3881060", Offset = "0x387F660", VA = "0x183881060", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public NAKNKCDHKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class LHDJJBKJBJL : AAJMJDCHNIG
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override IGGCJBCLGAF AEGMIKGAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x677270", Offset = "0x675870", VA = "0x180677270", Slot = "18")]
		get
		{
			return default(IGGCJBCLGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x38822D0", Offset = "0x38808D0", VA = "0x1838822D0")]
	public LHDJJBKJBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(FMGKIBHKAMG))]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal sealed class CJICNPGIEIJ : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x38F8330", Offset = "0x38F6930", VA = "0x1838F8330", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public CJICNPGIEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class JHKPLCNPCJD : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public JHKPLCNPCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class NKJLHMKHPIB : AAJMJDCHNIG
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override IGGCJBCLGAF AEGMIKGAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "18")]
		get
		{
			return default(IGGCJBCLGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x38822D0", Offset = "0x38808D0", VA = "0x1838822D0")]
	public NKJLHMKHPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[BCMMDDALFAJ]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
[UpdateInGroup(typeof(HLMANKFCDIJ))]
internal sealed class FPMAILCKPKH : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC210", Offset = "0x3BBA810", VA = "0x183BBC210", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public FPMAILCKPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class DCPDKFEIFKP : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public DCPDKFEIFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class HLIMCOAJIGM : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public HLIMCOAJIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class ONMAKNPNCJM : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public ONMAKNPNCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[LLNAOBNNFAO]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
public class DPOJGLGGHJG : CPOPPILPLCL, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService MNHJICLMCHO;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x390B380", Offset = "0x3909980", VA = "0x18390B380", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x390B3D0", Offset = "0x39099D0", VA = "0x18390B3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public DPOJGLGGHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class CopyTransformDataFromGameObjects : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct LKLNKDKNJLG : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float BHFBCCNNFFM = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> OJIAPDLBMFB;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x777B30", Offset = "0x776130", VA = "0x180777B30", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x777CF0", Offset = "0x7762F0", VA = "0x180777CF0")]
			private bool IHMEMFNPKNA(float3 PNPBNOELPMC, float3 GLJCMMBCBOC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x777D30", Offset = "0x776330", VA = "0x180777D30")]
			private bool MJBHDHBJLBI(quaternion PNPBNOELPMC, quaternion GLJCMMBCBOC)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct MFDNIDKEBCD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> MAKALFIMNEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> OLMJBIOPALF;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x777DB0", Offset = "0x7763B0", VA = "0x180777DB0", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FGGEJMNNOEE CKFCPHEJIOF;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly FGGEJMNNOEE ELGNAPAAONC;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly FGGEJMNNOEE EIPHJFCJPEM;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker LFFDJINLOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private FLACINKPGGL FKOHKPNDGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x39015F0", Offset = "0x38FFBF0", VA = "0x1839015F0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x3901660", Offset = "0x38FFC60", VA = "0x183901660", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x3901690", Offset = "0x38FFC90", VA = "0x183901690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	public class RegisterTransforms : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct DPGIOLAFJOO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct IAEHPIIMBLN
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct OPJMAGJLBAE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<LBEPJEEIEEG>.Runtime OOJBEGIAEJC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FFMABDDIBGE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LBEPJEEIEEG> FIOCGEFLBAC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> LBEFIMFBMFP;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0xDF7220", Offset = "0xDF5820", VA = "0x180DF7220")]
				public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0xDF7160", Offset = "0xDF5760", VA = "0x180DF7160")]
				public OPJMAGJLBAE BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(OPJMAGJLBAE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private IAEHPIIMBLN OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IAEHPIIMBLN.OPJMAGJLBAE* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate DJHLPPIIHHP;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0xDF3B60", Offset = "0xDF2160", VA = "0x180DF3B60")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, LBEPJEEIEEG EBNCDCCMBJP, Transform HJLACGOIJCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0xDF3A60", Offset = "0xDF2060", VA = "0x180DF3A60", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0xDF3CD0", Offset = "0xDF22D0", VA = "0x180DF3CD0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref IAEHPIIMBLN.OPJMAGJLBAE GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0xDF3B50", Offset = "0xDF2150", VA = "0x180DF3B50")]
			public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0xDF3C60", Offset = "0xDF2260", VA = "0x180DF3C60")]
			public unsafe static void LLAMNHLCMMI(ArchetypeChunkIterator* DJNLJBFOFDO, void* PFMEHCPKCFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct HBFJHOOOALA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct IFNIDGNIFFH
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct JBLMIOIDOBE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime CBBIJGNGEFF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<LBEPJEEIEEG>.Runtime OOJBEGIAEJC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity MCKJCPAMBFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<LBEPJEEIEEG> FIOCGEFLBAC;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0xDF60C0", Offset = "0xDF46C0", VA = "0x180DF60C0")]
				public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0xDF72F0", Offset = "0xDF58F0", VA = "0x180DF72F0")]
				public JBLMIOIDOBE BDFPGAHLPCK(ref ArchetypeChunk HDBNAICIMCF, int OENOMAGEBKN, int PMELGELOPHA)
				{
					return default(JBLMIOIDOBE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private IFNIDGNIFFH OGDGLAIMBDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IFNIDGNIFFH.JBLMIOIDOBE* DPLDENFBENA;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0xDF6120", Offset = "0xDF4720", VA = "0x180DF6120")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, LBEPJEEIEEG EBNCDCCMBJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0xDF6030", Offset = "0xDF4630", VA = "0x180DF6030", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xDF6200", Offset = "0xDF4800", VA = "0x180DF6200")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref IFNIDGNIFFH.JBLMIOIDOBE GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0xDF60C0", Offset = "0xDF46C0", VA = "0x180DF60C0")]
			public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private FLACINKPGGL FKOHKPNDGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery HGNLKOEKFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery PDBHBKACGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery ECJGBNHPJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery CAKINFFDLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery IBFDKFCIIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker DJHJLKELEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery MCHAAGNOKDA;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x779230", Offset = "0x777830", VA = "0x180779230", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x7794F0", Offset = "0x777AF0", VA = "0x1807794F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x779700", Offset = "0x777D00", VA = "0x180779700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x7797D0", Offset = "0x777DD0", VA = "0x1807797D0")]
		private void PFOCCHMDKAL(EntityQuery AMEIGJPGLKK, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x778620", Offset = "0x776C20", VA = "0x180778620")]
		private void DKFICCNNFML(EntityQuery AMEIGJPGLKK, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x7796A0", Offset = "0x777CA0", VA = "0x1807796A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x778890", Offset = "0x776E90", VA = "0x180778890")]
		private void FNFCPINBPLC(NativeArray<Entity> IJBCECFNJIL, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x778F20", Offset = "0x777520", VA = "0x180778F20")]
		[BurstCompile]
		internal static void MIFACHPHIIB(NativeArray<LBEPJEEIEEG> AMMMMPFBOFD, ComponentDataFromEntity<LBEPJEEIEEG> BDCFFAPHCGM, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void DACFLNGAALO(Transform HJLACGOIJCA, Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void HFDEMKDAKJM(Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void ILPDMAAGODC(int EBBLFLFCHFB, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x778D40", Offset = "0x777340", VA = "0x180778D40")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void LFFOANCLOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x779280", Offset = "0x777880", VA = "0x180779280", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x7789D0", Offset = "0x776FD0", VA = "0x1807789D0")]
		public static EntityQuery JCBPKAIIBJB(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x778B70", Offset = "0x777170", VA = "0x180778B70")]
		public static EntityQuery KNKKDMCADKG(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	public class CopyTransformDataToGameObjects : CPOPPILPLCL, GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct HFMCJEFFFPA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> OJIAPDLBMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x776EE0", Offset = "0x7754E0", VA = "0x180776EE0", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct KBOCICHHONM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> MAKALFIMNEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x777A90", Offset = "0x776090", VA = "0x180777A90", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct OCPIIKMPNDP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> MAKALFIMNEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> OLMJBIOPALF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> IJBCECFNJIL;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x777FD0", Offset = "0x7765D0", VA = "0x180777FD0", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly FGGEJMNNOEE CKFCPHEJIOF;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly FGGEJMNNOEE ELGNAPAAONC;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FGGEJMNNOEE EIPHJFCJPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private FLACINKPGGL FKOHKPNDGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery APDBBBDMKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery JLPPCEDCEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery LLIDHHBIFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray AOLHEDDOCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray FFCJPLNPKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray EHGGJGBPDBC;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x3901CC0", Offset = "0x39002C0", VA = "0x183901CC0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x3901D10", Offset = "0x3900310", VA = "0x183901D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x3901F00", Offset = "0x3900500", VA = "0x183901F00", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x3901F90", Offset = "0x3900590", VA = "0x183901F90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x3901FC0", Offset = "0x39005C0", VA = "0x183901FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x3901B40", Offset = "0x3900140", VA = "0x183901B40")]
		private NativeArray<Entity> HHAKEINKCJB(NativeArray<LBEPJEEIEEG> BGLJHEFMNHL, NativeList<Entity> FOMMJLEICDI, TransformAccessArray NCEBCHFFMPF, TransformAccessArray GHJMGNMMHAK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : CPOPPILPLCL, GKFAMMKGENJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private DJJJJFKCAHK MENKPJEEHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private DELPMNCMFNN OBOHCOMMCNH;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x389A550", Offset = "0x3898B50", VA = "0x18389A550", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x39028F0", Offset = "0x3900EF0", VA = "0x1839028F0", Slot = "14")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x3902C20", Offset = "0x3901220", VA = "0x183902C20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x3902A00", Offset = "0x3901000", VA = "0x183902A00")]
		private static void HEGDJKAIPBP(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x3902B80", Offset = "0x3901180", VA = "0x183902B80")]
		private static bool MKGOOONPMIK(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[DAINLFLPADL(OHEDAGNNHJA.TransformSyncing)]
	public class L2PToL2WHierarchy : CPOPPILPLCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PHHMHMLKPBE : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> ANBNOALFCJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> ANJPECHNJGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> AOGDAGAABIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> DJLMCHFFKPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> EIFMGBBLNDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> FAMLCCGNGFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint CILFLPOMCLL;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0xDFC750", Offset = "0xDFAD50", VA = "0x180DFC750")]
			[Conditional("DEBUG_BUILD")]
			private void AAFNLOCCPHB(Entity FLADPKIONGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0xDFC820", Offset = "0xDFAE20", VA = "0x180DFC820", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xDFCB10", Offset = "0xDFB110", VA = "0x180DFCB10")]
			private void KGDLJNJINNF(float4x4 GDMEPAIGICG, Entity FLADPKIONGF, bool GLPJDLECHOA, int IFJOKNDLBML = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery PAKACLHMGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery FGACFOHLFND;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBA80", Offset = "0x3BCA080", VA = "0x183BCBA80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBBA0", Offset = "0x3BCA1A0", VA = "0x183BCBBA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class KCPCKDOPHKL : LNFENIBMHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct LADLNOCGAAB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> ANBNOALFCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> EIFMGBBLNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint CILFLPOMCLL;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xDF89A0", Offset = "0xDF6FA0", VA = "0x180DF89A0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xDF8920", Offset = "0xDF6F20", VA = "0x180DF8920")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery PAKACLHMGLB;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8A90", Offset = "0x3BC7090", VA = "0x183BC8A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8BC0", Offset = "0x3BC71C0", VA = "0x183BC8BC0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public KCPCKDOPHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class FDNCHKLNEMO : LNFENIBMHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct NOHHPNKLDIO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> NGMANDAEHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> KHNPAGEHBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> CIAGHHAHPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> FPCHAOBMPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint CILFLPOMCLL;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xDFAEC0", Offset = "0xDF94C0", VA = "0x180DFAEC0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xDFAE40", Offset = "0xDF9440", VA = "0x180DFAE40")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery PJBANBJAEAL;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9060", Offset = "0x3BB7660", VA = "0x183BB9060", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9170", Offset = "0x3BB7770", VA = "0x183BB9170", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public FDNCHKLNEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class NIANMMCNJKJ : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct AFDMDFJGKEI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> MMLFKCABHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> NKKEELABFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> KNFBIMGODID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> GIFBKCFCFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint CILFLPOMCLL;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0xDF14F0", Offset = "0xDEFAF0", VA = "0x180DF14F0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0xDF1410", Offset = "0xDEFA10", VA = "0x180DF1410")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery PJBANBJAEAL;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x3881A50", Offset = "0x3880050", VA = "0x183881A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x3881B80", Offset = "0x3880180", VA = "0x183881B80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	public NIANMMCNJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[DAINLFLPADL(OHEDAGNNHJA.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : DLIGPDHAAFN
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct KNOLPHGOFNE : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType NBDNNKCDLBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x389AFC0", Offset = "0x38995C0", VA = "0x18389AFC0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x389AF60", Offset = "0x3899560", VA = "0x18389AF60", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x389AF90", Offset = "0x3899590", VA = "0x18389AF90", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x389AEC0", Offset = "0x38994C0", VA = "0x18389AEC0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[IBMNMGLBDEG(FMHJKFCFNOJ.Game)]
public class OFFNELKNNHJ : CMHOIGNLIPP
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type HJBKGIGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x3883C00", Offset = "0x3882200", VA = "0x183883C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x3883C70", Offset = "0x3882270", VA = "0x183883C70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public OFFNELKNNHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[IBMNMGLBDEG(FMHJKFCFNOJ.Loading)]
public class KEKOKEGPFBC : CMHOIGNLIPP
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type HJBKGIGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8CC0", Offset = "0x3BC72C0", VA = "0x183BC8CC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KEKOKEGPFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class DFOKDPAKEAE : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x3905F50", Offset = "0x3904550", VA = "0x183905F50", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public DFOKDPAKEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[IBMNMGLBDEG(FMHJKFCFNOJ.Saving)]
public class EGNKDAABNDE : CMHOIGNLIPP
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type HJBKGIGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1120", Offset = "0x3BAF720", VA = "0x183BB1120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public EGNKDAABNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class IJGDBPGDPGJ : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC55D0", Offset = "0x3BC3BD0", VA = "0x183BC55D0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public IJGDBPGDPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[IBMNMGLBDEG(FMHJKFCFNOJ.Simulation)]
public class CHHJGHFMPFD : CMHOIGNLIPP
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type HJBKGIGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x38F7F10", Offset = "0x38F6510", VA = "0x1838F7F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x38F7F80", Offset = "0x38F6580", VA = "0x1838F7F80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CHHJGHFMPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[DHKIICMHACJ(typeof(BLMOGKJJFOO), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal class BLMOGKJJFOO : GKFAMMKGENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::DNKHIOPKPFH<AuthoredParentData, OAGDIIKIAEI, EFOALCEOGCA, AuthoredChildrenData> DFJAIGJMBJI;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x38F45B0", Offset = "0x38F2BB0", VA = "0x1838F45B0", Slot = "4")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BLMOGKJJFOO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	[DHKIICMHACJ(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : GOJCOOFCPOI, GKFAMMKGENJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[CJONPMHNDBN]
		private BBGDLMHBFGH PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[CJONPMHNDBN]
		private PropertyChangeNetworkRouter GONEHAIFHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::JIMNIBINLKA<Entity> LNOIPGJELOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::DNKHIOPKPFH<ParentData, EELLNPEINOG, DNMGLLIEOCK, ChildrenData> DFJAIGJMBJI;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB67D0", Offset = "0x3BB4DD0", VA = "0x183BB67D0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6440", Offset = "0x3BB4A40", VA = "0x183BB6440", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6780", Offset = "0x3BB4D80", VA = "0x183BB6780")]
		public Entity NCMHOFMDGAH(Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6540", Offset = "0x3BB4B40", VA = "0x183BB6540")]
		public bool EAIMLJHMGNG(Entity FLADPKIONGF, Entity EBIGGMLCEAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6840", Offset = "0x3BB4E40", VA = "0x183BB6840")]
		public bool OGODNIIEFFB(Entity FLADPKIONGF, Entity EBIGGMLCEAF, bool KEKDECHAOMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB65A0", Offset = "0x3BB4BA0", VA = "0x183BB65A0")]
		private bool FDDKBBILGLG(Entity FLADPKIONGF, Entity EBIGGMLCEAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[DHKIICMHACJ(typeof(KOEDGMLBPFH), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal sealed class KOEDGMLBPFH : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery PNLHOHFCJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x3BC9F50", Offset = "0x3BC8550", VA = "0x183BC9F50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9C50", Offset = "0x3BC8250", VA = "0x183BC9C50", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9770", Offset = "0x3BC7D70", VA = "0x183BC9770", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9B90", Offset = "0x3BC8190", VA = "0x183BC9B90")]
	public bool LLHMMIJNOKL(Entity FLADPKIONGF, Entity EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9960", Offset = "0x3BC7F60", VA = "0x183BC9960")]
	public IEnumerable<Entity> IPMINALCKNM(Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9FA0", Offset = "0x3BC85A0", VA = "0x183BC9FA0")]
	public bool PKNAJOGAKAI(Entity FLADPKIONGF, Entity IMDKOHMGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9450", Offset = "0x3BC7A50", VA = "0x183BC9450")]
	public bool DNJHMIGKLJO(Entity FLADPKIONGF, Entity EOECNBNBJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9880", Offset = "0x3BC7E80", VA = "0x183BC9880")]
	public NativeList<Entity> IEFPHBPMHJN(Entity FLADPKIONGF, bool NPBOCMDCJPH = false, Allocator GGLOKAHPEPM = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9D50", Offset = "0x3BC8350", VA = "0x183BC9D50")]
	public IEnumerable<Entity> OPILOIOFOMC(Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9AE0", Offset = "0x3BC80E0", VA = "0x183BC9AE0")]
	public Entity KCDNPIAEBEL(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9400", Offset = "0x3BC7A00", VA = "0x183BC9400")]
	public NativeArray<Entity> BMFAMGNJFCC()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9550", Offset = "0x3BC7B50", VA = "0x183BC9550")]
	public bool DNKFCLNJCJP(Entity EOECNBNBJEC, Entity FNIMMJACBON, out Entity JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9790", Offset = "0x3BC7D90", VA = "0x183BC9790")]
	private Entity ENNBBFIPAAI(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KOEDGMLBPFH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x356E800", Offset = "0x356CE00", VA = "0x18356E800")]
		public static void IFEPEMKMGAF<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(PFKGIHKPIGG GOCENLCAMDB, global::AJFAFKBPGAH<Entity> MABBPMMEACO, out global::DNKHIOPKPFH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> FHDIHMMIHDJ) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, CGCOJDLBGDN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, CGCOJDLBGDN, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x3895A70", Offset = "0x3894070", VA = "0x183895A70")]
		public static bool ABNDKMLOGCB(INPNGJHLELG EDNIAMBKPNL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class DNKHIOPKPFH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, CGCOJDLBGDN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, CGCOJDLBGDN, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly FGGEJMNNOEE LAEOPKAJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::JIMNIBINLKA<Entity> LNOIPGJELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly AIEDMPHMCJI IJPODEPGBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly CKNEHODEDLN LFAIGCEGCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly DELPMNCMFNN OBOHCOMMCNH;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E10", Offset = "0x3B5F410", VA = "0x183B60E10")]
	public DNKHIOPKPFH(PFKGIHKPIGG GOCENLCAMDB, global::AJFAFKBPGAH<Entity> MABBPMMEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FEA0", Offset = "0x3B5E4A0", VA = "0x183B5FEA0")]
	private bool AODOFDEGDAD(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x3B607E0", Offset = "0x3B5EDE0", VA = "0x183B607E0")]
	private bool NHDJFMHNIMI(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x3B60500", Offset = "0x3B5EB00", VA = "0x183B60500")]
	public bool EAIMLJHMGNG(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x3B60090", Offset = "0x3B5E690", VA = "0x183B60090")]
	public bool BPHDFDMIMDE(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x3B600C0", Offset = "0x3B5E6C0", VA = "0x183B600C0")]
	private bool BPHDFDMIMDE(Entity FLADPKIONGF, in Entity EBIGGMLCEAF, bool PFOOECGMKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void AJLJKELCOFK(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void CKJMGGCNAOH(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void FHNPJBLFBDB(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void CNLFFFMDLLF(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private static void FAFNMDJEBFA(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x3B60620", Offset = "0x3B5EC20", VA = "0x183B60620")]
	private bool LLHMMIJNOKL(Entity FLADPKIONGF, Entity EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x3B60530", Offset = "0x3B5EB30", VA = "0x183B60530")]
	private void GKHECDJEFEM(Entity FLADPKIONGF, in Entity KOEBMFNDCDN, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x3B60950", Offset = "0x3B5EF50", VA = "0x183B60950")]
	private void PJIHAHONNIA(Entity FLADPKIONGF, in Entity KOEBMFNDCDN, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FAA0", Offset = "0x3B5E0A0", VA = "0x183B5FAA0")]
	private bool ALPMOJCOLFG(ABGCOLIMINN BEKGLMLIAIJ, in COEEIJJLOPG CFCDMOHCLML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FF60", Offset = "0x3B5E560", VA = "0x183B5FF60")]
	private void APJHAKKKPLO(Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x3B608C0", Offset = "0x3B5EEC0", VA = "0x183B608C0")]
	private void OPJJCFHECII(Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private void ILPDMAAGODC(Entity FLADPKIONGF, Entity KOEBMFNDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	private void DACFLNGAALO(Entity FLADPKIONGF, Entity EBIGGMLCEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct ADBGJJCIOEO : FEHJDGBIBFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public GMLHAACHBKL NCHIEACOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x72F7B0", Offset = "0x72DDB0", VA = "0x18072F7B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x73C840", Offset = "0x73AE40", VA = "0x18073C840", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[DHKIICMHACJ(typeof(ObjectEmbodimentService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Embodiment)]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	internal sealed class ObjectEmbodimentService : GLDNLFCIGBG, BGDEOEAAJCH, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService BKOGMAMFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[CJONPMHNDBN]
		private BBGDLMHBFGH PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[CJONPMHNDBN]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[CJONPMHNDBN]
		private PAJFOGDKCPC PLNODCMOLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[CJONPMHNDBN]
		private KCAFIOGMOCH OFHGMHEPCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[CJONPMHNDBN]
		private TransformOwnershipPhase CBBKLGMGPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<COEEIJJLOPG, GLICHKLIKDB> OPLFEJBEDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private OCLBFAENKJA GEGKEOKJJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x3888A80", Offset = "0x3887080", VA = "0x183888A80")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int DOOOPAJAEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x3888250", Offset = "0x3886850", VA = "0x183888250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int JKMNPHCFCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x38865B0", Offset = "0x3884BB0", VA = "0x1838865B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x8177F0", Offset = "0x815DF0", VA = "0x1808177F0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x3888490", Offset = "0x3886A90", VA = "0x183888490", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x3885D60", Offset = "0x3884360", VA = "0x183885D60")]
		public void BLGJNLFGPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x3885F20", Offset = "0x3884520", VA = "0x183885F20", Slot = "6")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x38861C0", Offset = "0x38847C0", VA = "0x1838861C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3886110", Offset = "0x3884710", VA = "0x183886110")]
		public int DEIOFDOJNON(SceneTag FMEDCFLNIMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x38885C0", Offset = "0x3886BC0", VA = "0x1838885C0")]
		public int NMPFPNGDBIL(SceneTag FMEDCFLNIMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3887C70", Offset = "0x3886270", VA = "0x183887C70")]
		public bool LDKHBOLKJMB(Entity FLADPKIONGF, Allocator GGLOKAHPEPM, out NativeList<Entity> FHECHPPDJGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3887F40", Offset = "0x3886540", VA = "0x183887F40")]
		public bool LKJHLJGGMJG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x38881E0", Offset = "0x38867E0", VA = "0x1838881E0")]
		public bool LOMGEMGINNG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3885E60", Offset = "0x3884460", VA = "0x183885E60")]
		public bool CDEJDKLJJPA(Entity FLADPKIONGF, out GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x3885DB0", Offset = "0x38843B0", VA = "0x183885DB0")]
		private bool CDEJDKLJJPA(Transform HJLACGOIJCA, out GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x38889E0", Offset = "0x3886FE0", VA = "0x1838889E0")]
		private void ONNODGLGOKJ(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x3887C00", Offset = "0x3886200", VA = "0x183887C00")]
		private bool KPKJJLDLPLG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x38878A0", Offset = "0x3885EA0", VA = "0x1838878A0")]
		public void KOEBKPOFGOP(COEEIJJLOPG FBIBIHJENAB, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x3888AD0", Offset = "0x38870D0", VA = "0x183888AD0")]
		public bool PCEBDKCDCEK(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x3885350", Offset = "0x3883950", VA = "0x183885350")]
		public bool ADPNNHDPBFH(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x3885300", Offset = "0x3883900", VA = "0x183885300")]
		public bool ADPNNHDPBFH(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x38852E0", Offset = "0x38838E0", VA = "0x1838852E0")]
		public bool ADPNNHDPBFH(GLICHKLIKDB EDNIAMBKPNL, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x3885890", Offset = "0x3883E90", VA = "0x183885890")]
		public bool BJPKHDLNNBP(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x3885860", Offset = "0x3883E60", VA = "0x183885860")]
		public bool BJPKHDLNNBP(GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x3884F30", Offset = "0x3883530", VA = "0x183884F30")]
		public bool ADPNNHDPBFH(GLICHKLIKDB NCAANBGOHJP, [Optional] object HKLDIENGNNB, bool CBEIFKNKIIE = false, bool EIPNMJFHFCJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x3886420", Offset = "0x3884A20", VA = "0x183886420")]
		public Transform FJAPHIONMLH(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x38883C0", Offset = "0x38869C0", VA = "0x1838883C0")]
		public bool MKGOOONPMIK(Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x38862F0", Offset = "0x38848F0", VA = "0x1838862F0")]
		public GLICHKLIKDB EGMFKDJNLKC(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x3886C70", Offset = "0x3885270", VA = "0x183886C70")]
		public void IHFDMGOCGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x38885F0", Offset = "0x3886BF0", VA = "0x1838885F0")]
		public void NMPNNEJBCPI(SceneTag FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3886720", Offset = "0x3884D20", VA = "0x183886720")]
		private void IAFGBHBNPNB(Entity FLADPKIONGF, bool POFNLFLHCKJ, bool OJLHMJCOGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x38857C0", Offset = "0x3883DC0", VA = "0x1838857C0")]
		private void BHPHHKOBFHM(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP, bool POFNLFLHCKJ, bool OJLHMJCOGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x3884EE0", Offset = "0x38834E0", VA = "0x183884EE0")]
		public GLICHKLIKDB ADLDJPPEBIA(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x3886140", Offset = "0x3884740", VA = "0x183886140")]
		public bool DPKIDNMHHHJ(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x38873B0", Offset = "0x38859B0", VA = "0x1838873B0")]
		public bool JGABPGKHJJO(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x3886540", Offset = "0x3884B40", VA = "0x183886540")]
		public bool GCEGADAHECD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x3888280", Offset = "0x3886880", VA = "0x183888280")]
		public bool MHNBBGFCOPH(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x38882F0", Offset = "0x38868F0", VA = "0x1838882F0")]
		public bool MHNBBGFCOPH(GMLHAACHBKL ODMNDKFKJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LAHMKEKFIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x3885700", Offset = "0x3883D00", VA = "0x183885700")]
		private void AOBNDJBBLAD(bool MALFJDJBPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x3886390", Offset = "0x3884990", VA = "0x183886390")]
		private bool ELOHJKCBJOM(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x3886070", Offset = "0x3884670", VA = "0x183886070")]
		private GLICHKLIKDB CPKGOOIFDFG(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x3886A80", Offset = "0x3885080", VA = "0x183886A80")]
		private GLICHKLIKDB IAJPAAIOOBB(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x3887430", Offset = "0x3885A30", VA = "0x183887430")]
		private (Vector3, Quaternion, Vector3) JLOPOEDOLCD(Entity FLADPKIONGF)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x3886F20", Offset = "0x3885520", VA = "0x183886F20")]
		private void IIJCJHGLNME(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x38865E0", Offset = "0x3884BE0", VA = "0x1838865E0")]
		private void GHKEFMLJFKB(NIALADIPDNC KLCGNDEDAPD, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x3887AE0", Offset = "0x38860E0", VA = "0x183887AE0")]
		private void KOEHHMGCCKN(GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x3887150", Offset = "0x3885750", VA = "0x183887150")]
		private void JDCPBPPANJP(GLICHKLIKDB NCAANBGOHJP, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x3887650", Offset = "0x3885C50", VA = "0x183887650")]
		private void KAMFEGPDENH(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x3885C80", Offset = "0x3884280", VA = "0x183885C80")]
		private void BLFPMBLHEKE(Entity FLADPKIONGF, Transform HJLACGOIJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x3887F10", Offset = "0x3886510", VA = "0x183887F10")]
		private NIALADIPDNC LKDLNANKINH(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x3888EE0", Offset = "0x38874E0", VA = "0x183888EE0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x3886650", Offset = "0x3884C50", VA = "0x183886650")]
		[CompilerGenerated]
		private void HAJHOLKENOK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class JPGFCCFBBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7F80", Offset = "0x3BC6580", VA = "0x183BC7F80")]
	public static GLICHKLIKDB EGMFKDJNLKC(this ObjectEmbodimentService MAENFGNHNOF, NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[DAINLFLPADL(OHEDAGNNHJA.Lifecycle)]
	[DHKIICMHACJ(typeof(ObjectLifecycleService), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	internal sealed class ObjectLifecycleService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService NCAANBGOHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private PNILGBJCJNO DNEBJPOMCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects AJMIKABBIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x388A480", Offset = "0x3888A80", VA = "0x18388A480")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, HLEPLICHNKK> KHMHAFFAPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x3889820", Offset = "0x3887E20", VA = "0x183889820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x3889620", Offset = "0x3887C20", VA = "0x183889620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> KNNJPCNCMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x38898C0", Offset = "0x3887EC0", VA = "0x1838898C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x388A140", Offset = "0x3888740", VA = "0x18388A140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x388A1E0", Offset = "0x38887E0", VA = "0x18388A1E0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0xE7FB80", Offset = "0xE7E180", VA = "0x180E7FB80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x38897A0", Offset = "0x3887DA0", VA = "0x1838897A0")]
		public bool DPFPNIAFGMD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x3889960", Offset = "0x3887F60", VA = "0x183889960")]
		internal void FAKINIFECHA(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x3889760", Offset = "0x3887D60", VA = "0x183889760")]
		public void CGLPGHAHONL(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x38896C0", Offset = "0x3887CC0", VA = "0x1838896C0")]
		public void BEJINFJIIKP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x3889BC0", Offset = "0x38881C0", VA = "0x183889BC0")]
		private bool HLDMFBLKEKJ(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x38899C0", Offset = "0x3887FC0", VA = "0x1838899C0")]
		public void GGPEMOPMMCE(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x388A2C0", Offset = "0x38888C0", VA = "0x18388A2C0")]
		private bool PAIMHOKHDJB(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x388A4D0", Offset = "0x3888AD0", VA = "0x18388A4D0")]
		public void PDCINDJGKMO(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x3889EE0", Offset = "0x38884E0", VA = "0x183889EE0")]
		private void JLGCLDPLICM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3889C80", Offset = "0x3888280", VA = "0x183889C80")]
		private void IPDMIPACPCE(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x3889710", Offset = "0x3887D10", VA = "0x183889710")]
		public void CAHDAIHLDPP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private void PFDMJBBMDNB(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x3889F40", Offset = "0x3888540", VA = "0x183889F40")]
		private void KHEHKDLFPGP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[DHKIICMHACJ(typeof(ObjectPrefabs), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Prefabs)]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	internal class ObjectPrefabs : MCHHLOEOAAJ, GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class KAMLJEPKJMP : IEnumerable<(KFKBMIIJOHI, HLEPLICHNKK)>, IEnumerable, IEnumerator<(KFKBMIIJOHI, HLEPLICHNKK)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (KFKBMIIJOHI primitiveType, HLEPLICHNKK prefabType) <>2__current;

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
			private (KFKBMIIJOHI, HLEPLICHNKK) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0xDF51C0", Offset = "0xDF37C0", VA = "0x180DF51C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((KFKBMIIJOHI, HLEPLICHNKK));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF66A0", VA = "0x180DF80A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0xDF5340", Offset = "0xDF3940", VA = "0x180DF5340")]
			[DebuggerHidden]
			public KAMLJEPKJMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0xDF7EC0", Offset = "0xDF64C0", VA = "0x180DF7EC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0xDF8060", Offset = "0xDF6660", VA = "0x180DF8060", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0xDF7FC0", Offset = "0xDF65C0", VA = "0x180DF7FC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(KFKBMIIJOHI, HLEPLICHNKK)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0xDF7FC0", Offset = "0xDF65C0", VA = "0x180DF7FC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<HLEPLICHNKK, Entity> EJCAANKBGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<HLEPLICHNKK, EntityArchetype> CGBHJDKNJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<KFKBMIIJOHI, HLEPLICHNKK> KDJBKLGMDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<KHIPNLNOHNH, HLEPLICHNKK> HOANCAOPCJK;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x388DB80", Offset = "0x388C180", VA = "0x18388DB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x388E130", Offset = "0x388C730", VA = "0x18388E130")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x388DBD0", Offset = "0x388C1D0", VA = "0x18388DBD0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x388CE00", Offset = "0x388B400", VA = "0x18388CE00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x388CA60", Offset = "0x388B060", VA = "0x18388CA60")]
		internal IEnumerable<Type> AIKIDOGMPDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x388CAC0", Offset = "0x388B0C0", VA = "0x18388CAC0")]
		internal ECJOKHEDOAA CHCGKGOLMGL(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x388D7D0", Offset = "0x388BDD0", VA = "0x18388D7D0")]
		public EntityArchetype JCGKNAGCLPO(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x388E150", Offset = "0x388C750", VA = "0x18388E150")]
		public NativeHashMap<int, EntityArchetype> PKKFLMODMLN(Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x388D6F0", Offset = "0x388BCF0", VA = "0x18388D6F0")]
		public bool GJMFCBMMONL(HLEPLICHNKK IGDDGFIHFCA, out EntityArchetype HEFFAMIFPAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x388D760", Offset = "0x388BD60", VA = "0x18388D760", Slot = "4")]
		[IteratorStateMachine(typeof(KAMLJEPKJMP))]
		public IEnumerable<(KFKBMIIJOHI, HLEPLICHNKK)> IGFEMMPCLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x388DFB0", Offset = "0x388C5B0", VA = "0x18388DFB0")]
		public Entity NEEHFODMFJK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x388D830", Offset = "0x388BE30", VA = "0x18388D830")]
		public HLEPLICHNKK JJGMBAPGGMB(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x388D890", Offset = "0x388BE90", VA = "0x18388D890")]
		public HLEPLICHNKK JJGMBAPGGMB(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x388CC90", Offset = "0x388B290", VA = "0x18388CC90")]
		public NativeHashMap<int, Entity> DKBOELLMGNP(Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x388D250", Offset = "0x388B850", VA = "0x18388D250")]
		public IEnumerable<HLEPLICHNKK> FPMKKFAPLCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x388D8F0", Offset = "0x388BEF0", VA = "0x18388D8F0")]
		public Entity KHPNNFFFMMF(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x388E0C0", Offset = "0x388C6C0", VA = "0x18388E0C0")]
		public bool OABIHIPJEOM(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x388D2A0", Offset = "0x388B8A0", VA = "0x18388D2A0")]
		private void GGMCAIKPMHI(ECJOKHEDOAA EOKLIJEFLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x388D950", Offset = "0x388BF50", VA = "0x18388D950")]
		internal void LJPJPIAEMKN(HLEPLICHNKK IGDDGFIHFCA, ODIEFIPMBGL BGIKBILIONK, KPCPJNHBGBE OALIMJPCECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x388CB30", Offset = "0x388B130", VA = "0x18388CB30")]
		private void CJGANCNIHHI(HLEPLICHNKK IGDDGFIHFCA, ODIEFIPMBGL NEOKJGOPJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x388D130", Offset = "0x388B730", VA = "0x18388D130")]
		internal Entity EJPPNCDBCKD(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x388E320", Offset = "0x388C920", VA = "0x18388E320")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum IGGCJBCLGAF
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface AABIIEJAGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	PIFFPMLCLFK MOKNNLHOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class ABPLGJHCONF : DBNCKKCNGJJ, ACMLCBMOLDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly PBIGHLIMKNA MNNGMBKBGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly IGGCJBCLGAF CBBKLGMGPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<IFHANGOBDPE> IFOEGNEKJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, KCFNAMGFMNK> ELNCFOIGCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> CFCIPCCIDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle KCAOPOAHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle KGEGKLCOCLH;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World CEKGBLIIGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x38ED170", Offset = "0x38EB770", VA = "0x1838ED170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private PIFFPMLCLFK OEDOBIJLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x790E60", Offset = "0x78F460", VA = "0x180790E60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private APMEOIGEMKF KNPKJOFKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x867010", Offset = "0x865610", VA = "0x180867010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, KCFNAMGFMNK> HAOFLGCDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x79D130", Offset = "0x79B730", VA = "0x18079D130", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, KCFNAMGFMNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle PPHGFACFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B80", Offset = "0x7E4180", VA = "0x1807E5B80", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xF610A0", Offset = "0xF5F6A0", VA = "0x180F610A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool HHHGMLLGHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x38ED270", Offset = "0x38EB870", VA = "0x1838ED270", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World KFFLEJJCAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x38ED3C0", Offset = "0x38EB9C0", VA = "0x1838ED3C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x38ED860", Offset = "0x38EBE60", VA = "0x1838ED860")]
	public ABPLGJHCONF(PBIGHLIMKNA MNNGMBKBGHB, IGGCJBCLGAF CBBKLGMGPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x38ED3B0", Offset = "0x38EB9B0", VA = "0x1838ED3B0", Slot = "11")]
	private void IJEKODECJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x38ED2C0", Offset = "0x38EB8C0", VA = "0x1838ED2C0", Slot = "10")]
	private bool IBJBGMLIKFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x38ECAC0", Offset = "0x38EB0C0", VA = "0x1838ECAC0", Slot = "12")]
	private void BMNDOEHKGKM(ComponentType ALGBEENOGLE, in IFHANGOBDPE JDHBAMAGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x38ECA50", Offset = "0x38EB050", VA = "0x1838ECA50", Slot = "13")]
	private bool APKFDCIPKJK(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x38ED1D0", Offset = "0x38EB7D0", VA = "0x1838ED1D0", Slot = "16")]
	private bool EOPALPCLELJ(out NativeArray<int> DFCIIJDJCIO, Allocator GGLOKAHPEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x38ECBB0", Offset = "0x38EB1B0", VA = "0x1838ECBB0", Slot = "17")]
	private bool CIBIOHKLOEC(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI, out OPLPBOKJNKG PAGFKHPKKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x38ECD30", Offset = "0x38EB330", VA = "0x1838ECD30", Slot = "18")]
	private bool CIBIOHKLOEC(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x38ED080", Offset = "0x38EB680", VA = "0x1838ED080", Slot = "19")]
	private IFHANGOBDPE DDLCKPJMPMA(ComponentType ALGBEENOGLE)
	{
		return default(IFHANGOBDPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x38ED420", Offset = "0x38EBA20", VA = "0x1838ED420", Slot = "20")]
	private LBOLGJICLNI KDOPIGEFLKJ()
	{
		return default(LBOLGJICLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x38ED280", Offset = "0x38EB880", VA = "0x1838ED280", Slot = "21")]
	private void IBCGKELIMGK(JobHandle AHIGBHNJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x38ED460", Offset = "0x38EBA60", VA = "0x1838ED460")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x38ECE60", Offset = "0x38EB460", VA = "0x1838ECE60")]
	private bool DBBEEMBPGLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x38ED710", Offset = "0x38EBD10", VA = "0x1838ED710")]
	private int POODCMJNMFF()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class PBIGHLIMKNA : AABIIEJAGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public LEDNJPMFMJI NCKCDMENEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService EJCAANKBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public PIFFPMLCLFK JIANONPNEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public APMEOIGEMKF OOMDEPCFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public DPDLGGKHONK KAIBGIFEHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World KBIJMFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x38910E0", Offset = "0x388F6E0", VA = "0x1838910E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PIFFPMLCLFK MOKNNLHOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public PBIGHLIMKNA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DAINLFLPADL(OHEDAGNNHJA.PropertyChanges)]
	[DHKIICMHACJ(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct PJBMKGIJBGF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly IGGCJBCLGAF KHGOAFEHLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService AGMOENMHCDB;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0xDFCF30", Offset = "0xDFB530", VA = "0x180DFCF30")]
			public PJBMKGIJBGF(PropertyDiffStateService AGMOENMHCDB, IGGCJBCLGAF AEBMIONNBAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0xDFCF10", Offset = "0xDFB510", VA = "0x180DFCF10", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly PBIGHLIMKNA MNNGMBKBGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly ABPLGJHCONF[] KKFANNHDBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private IGGCJBCLGAF FINCIPHDCJP;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public AABIIEJAGGI AFINKPJMIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public ACMLCBMOLDA ADKKLDBJCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x389BEC0", Offset = "0x389A4C0", VA = "0x18389BEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public DBNCKKCNGJJ KCKLPJGBINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x389BEC0", Offset = "0x389A4C0", VA = "0x18389BEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0xFDA090", Offset = "0xFD8690", VA = "0x180FDA090")]
		public ACMLCBMOLDA ODIPNEBMFLM(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0xFDA090", Offset = "0xFD8690", VA = "0x180FDA090")]
		public DBNCKKCNGJJ NLKIFHPCKGJ(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x389C360", Offset = "0x389A960", VA = "0x18389C360", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x389BF20", Offset = "0x389A520", VA = "0x18389BF20", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x389C3E0", Offset = "0x389A9E0", VA = "0x18389C3E0")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x389C280", Offset = "0x389A880", VA = "0x18389C280", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x389BF00", Offset = "0x389A500", VA = "0x18389BF00")]
		public PJBMKGIJBGF AOBFHDIGADL(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return default(PJBMKGIJBGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x389C490", Offset = "0x389AA90", VA = "0x18389C490")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(SceneService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	internal class SceneService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag GDKAGCMEGFP;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string FOFGHBELHLI = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string CCNFFKBEOIM = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[CJONPMHNDBN]
		private KDGBBCMLLMM JBGBBDABBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[CJONPMHNDBN]
		private ObjectEmbodimentService NCAANBGOHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[CJONPMHNDBN]
		private AIEDMPHMCJI GDDMJGIBAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[CJONPMHNDBN]
		private SingletonComponentService PCGHKDHDJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery LMBPFKEJAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery HDOBAHEFPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery DNGIBJPHCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity MBABGENBKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool KGJLEFJCIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x77A2D0", Offset = "0x7788D0", VA = "0x18077A2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> EGHGGMHHILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x77A6D0", Offset = "0x778CD0", VA = "0x18077A6D0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x77AE30", Offset = "0x779430", VA = "0x18077AE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity LCMKEANPPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x77ABF0", Offset = "0x7791F0", VA = "0x18077ABF0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag AIKKNEDCIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x779D10", Offset = "0x778310", VA = "0x180779D10")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity GDJEHHMMMIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x779D10", Offset = "0x778310", VA = "0x180779D10")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x77B7D0", Offset = "0x779DD0", VA = "0x18077B7D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x77B840", Offset = "0x779E40", VA = "0x18077B840")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x77B520", Offset = "0x779B20", VA = "0x18077B520", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x77A500", Offset = "0x778B00", VA = "0x18077A500", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x77A290", Offset = "0x778890", VA = "0x18077A290")]
		public void BIPEFLGPOBF(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x77A260", Offset = "0x778860", VA = "0x18077A260")]
		public NativeArray<Entity> BCMNJFKEPBC(Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x77A8C0", Offset = "0x778EC0", VA = "0x18077A8C0")]
		public void GIKIHGNHOPB(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x77B600", Offset = "0x779C00", VA = "0x18077B600")]
		public Entity NGIDDMAIDKI(string NBODBMLPNJA = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x77AE10", Offset = "0x779410", VA = "0x18077AE10")]
		public void JIGOEGAAMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x77A110", Offset = "0x778710", VA = "0x18077A110")]
		public void AJNEIPBAHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x77B300", Offset = "0x779900", VA = "0x18077B300")]
		public void LCCFICPMDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x77B360", Offset = "0x779960", VA = "0x18077B360")]
		public void LNOFBFCGGKG(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x77A450", Offset = "0x778A50", VA = "0x18077A450")]
		public bool DCHJKCLCEGK(Entity FMEDCFLNIMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x77B680", Offset = "0x779C80", VA = "0x18077B680")]
		public void OGOFCMMEMDL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x77A320", Offset = "0x778920", VA = "0x18077A320")]
		public string CBDHMGCPFDO(Entity FMEDCFLNIMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void JJNIPCJIADI(Entity FMEDCFLNIMM, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x77A430", Offset = "0x778A30", VA = "0x18077A430")]
		public bool CLOPMPMADBP(string NBODBMLPNJA, out Entity FMEDCFLNIMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x77B690", Offset = "0x779C90", VA = "0x18077B690")]
		public void OILHIIEHIEG(Entity FMEDCFLNIMM, bool BGIKBDOCDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x77A6E0", Offset = "0x778CE0", VA = "0x18077A6E0")]
		public void GAJOMFADMDA(Entity FLADPKIONGF, bool MFCDCBMLNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x77A760", Offset = "0x778D60", VA = "0x18077A760")]
		public void GAJOMFADMDA(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x77A7D0", Offset = "0x778DD0", VA = "0x18077A7D0")]
		public void GAJOMFADMDA(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x77B0D0", Offset = "0x7796D0", VA = "0x18077B0D0")]
		public void KHPLLHCLNNL(Entity FLADPKIONGF, Entity FMEDCFLNIMM, bool MFCDCBMLNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x77AE40", Offset = "0x779440", VA = "0x18077AE40")]
		public void KHPLLHCLNNL(NativeArray<Entity> IJBCECFNJIL, Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x77B020", Offset = "0x779620", VA = "0x18077B020")]
		public void KHPLLHCLNNL(EntityQuery AMEIGJPGLKK, Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x77B370", Offset = "0x779970", VA = "0x18077B370")]
		private void MCGBBNKCOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x77B7A0", Offset = "0x779DA0", VA = "0x18077B7A0")]
		private void OKMLLHDGLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x77ABF0", Offset = "0x7791F0", VA = "0x18077ABF0")]
		private Entity NBJLHEFAHEA()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x77A150", Offset = "0x778750", VA = "0x18077A150")]
		private void AKLBHFNGFIL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x779D60", Offset = "0x778360", VA = "0x180779D60")]
		private void AEDDIIIEJBL(EntityQuery PHFFFDIHFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x779E30", Offset = "0x778430", VA = "0x180779E30")]
		private void AEDDIIIEJBL(NativeArray<Entity> LLLBMIKLOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x77B890", Offset = "0x779E90", VA = "0x18077B890")]
		private void PEEHCJCKGGM(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x77A540", Offset = "0x778B40", VA = "0x18077A540")]
		private void EDNHGNLLJEL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x77AD70", Offset = "0x779370", VA = "0x18077AD70")]
		private void JAKKDKMHLDA(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x77A130", Offset = "0x778730", VA = "0x18077A130")]
		private void AJPOOGOKIIB(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x77AA60", Offset = "0x779060", VA = "0x18077AA60")]
		private void IACKDCODBGB(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x77A9C0", Offset = "0x778FC0", VA = "0x18077A9C0")]
		private void IAANBNJHEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x4234080", Offset = "0x4232680", VA = "0x184234080")]
		private void IPMLJNKBEKN<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void AJGJEODNOJH(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x77A200", Offset = "0x778800", VA = "0x18077A200")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BBPHNGBIGLB(EntityQuery AMEIGJPGLKK, string NBODBMLPNJA, SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x77AD40", Offset = "0x779340", VA = "0x18077AD40")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void INODCEGMEEN(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GDIOABOKJJM(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[DHKIICMHACJ(typeof(CBAJMILGKOG), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	[LOICNDEPMOJ(HIFIKBEHMNK.PhotonRoom)]
	internal class UnitySceneService : GOJCOOFCPOI, CBAJMILGKOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[CJONPMHNDBN]
		private SceneService LLLBMIKLOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> CPEINMFKIMN;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x789790", Offset = "0x787D90", VA = "0x180789790")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x789700", Offset = "0x787D00", VA = "0x180789700", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x789330", Offset = "0x787930", VA = "0x180789330", Slot = "5")]
		public void BIPEFLGPOBF(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x789510", Offset = "0x787B10", VA = "0x180789510", Slot = "6")]
		public bool JPFJKODKFPO(NIALADIPDNC KLCGNDEDAPD, Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x7894A0", Offset = "0x787AA0", VA = "0x1807894A0")]
		private bool IDKMPGBKOPF(Scene FMEDCFLNIMM, out Entity MOEJBLMOECD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x7897E0", Offset = "0x787DE0", VA = "0x1807897E0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[DAINLFLPADL(OHEDAGNNHJA.ComponentSystemTypes)]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[CJONPMHNDBN]
		private AIEDMPHMCJI GDDMJGIBAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity FLADPKIONGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private ODIEFIPMBGL NEOKJGOPJJM;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x7804F0", Offset = "0x77EAF0", VA = "0x1807804F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity LHEGNCBACAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x780570", Offset = "0x77EB70", VA = "0x180780570")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x42359B0", Offset = "0x4233FB0", VA = "0x1842359B0")]
		public T DNJGGIFCOKL<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x4235A70", Offset = "0x4234070", VA = "0x184235A70")]
		public void KMNEKDAGPNL<T>(T MAKFNMHIJIF) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x780500", Offset = "0x77EB00", VA = "0x180780500", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x77FFE0", Offset = "0x77E5E0", VA = "0x18077FFE0", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x77FFE0", Offset = "0x77E5E0", VA = "0x18077FFE0")]
		private void OJHANNIJMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x780180", Offset = "0x77E780", VA = "0x180780180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x7805C0", Offset = "0x77EBC0", VA = "0x1807805C0")]
		private ODIEFIPMBGL PPMIBKNMMJE()
		{
			return default(ODIEFIPMBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void FFJIFHNHNDC(int FPLNDBJJHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		private static void AIPGFAKCFNH(Type MCLMFJEAHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x780450", Offset = "0x77EA50", VA = "0x180780450")]
		private static void LHANEBOBBHF(Type MCLMFJEAHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct BFJPEMIKOOL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[DHKIICMHACJ(typeof(KCAFIOGMOCH), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal sealed class KCAFIOGMOCH : GOJCOOFCPOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[CJONPMHNDBN]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::MBBKMHEBCCI<OOADEDOKLOJ, Entity> LOPOPBJFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::BHECHFLOHKD<MPLAECHOBPI> FLFAGBMGJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::BHECHFLOHKD<AMNJAHKIGJJ> NDFKMJEFKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::BHECHFLOHKD<FLHDEMJJLMD> LPCGOEAGKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::BHECHFLOHKD<BDFMJFCAPKN> PJLEIJKCBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::BHECHFLOHKD<ADBGJJCIOEO> MAENFGNHNOF;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::FJFPAKAENKI<Entity> FBFJFDHIJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KGGBBDKCFNK NHMJJOEDBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KGGBBDKCFNK GLAACLCDFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KGGBBDKCFNK IJJBPGLCILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KGGBBDKCFNK BCHLNGKMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KGGBBDKCFNK OKFNDMOLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x3BC81A0", Offset = "0x3BC67A0", VA = "0x183BC81A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8090", Offset = "0x3BC6690", VA = "0x183BC8090", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7FA0", Offset = "0x3BC65A0", VA = "0x183BC7FA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x308DD10", Offset = "0x308C310", VA = "0x18308DD10")]
	private void IFEPEMKMGAF<T>(ref global::BHECHFLOHKD<T> JDMFCLOEMNK) where T : struct, FEHJDGBIBFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x308DD10", Offset = "0x308C310", VA = "0x18308DD10")]
	private void IFEPEMKMGAF<TC, TV>(ref global::MBBKMHEBCCI<TC, TV> JDMFCLOEMNK) where TC : struct, FEHJDGBIBFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KCAFIOGMOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[DHKIICMHACJ(typeof(FLACINKPGGL), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
internal sealed class FLACINKPGGL : BGDEOEAAJCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private FMHLIBMOGNG MLEBNIFIENM;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public FMHLIBMOGNG JMENOJNLGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x1487F80", Offset = "0x1486580", VA = "0x181487F80")]
		get
		{
			return default(FMHLIBMOGNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB1E0", Offset = "0x3BB97E0", VA = "0x183BBB1E0", Slot = "4")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB1D0", Offset = "0x3BB97D0", VA = "0x183BBB1D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FLACINKPGGL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(TransformOwnershipPhase), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum OBKMOHGGCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct CFJMCMGIOLO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private OBKMOHGGCNJ AOHELCDBBJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase LFAIGCEGCPL;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0xDF25D0", Offset = "0xDF0BD0", VA = "0x180DF25D0")]
			public CFJMCMGIOLO(TransformOwnershipPhase LFAIGCEGCPL, OBKMOHGGCNJ CBBKLGMGPCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xDF25B0", Offset = "0xDF0BB0", VA = "0x180DF25B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public OBKMOHGGCNJ CBBKLGMGPCP;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public OBKMOHGGCNJ IJNEIEHHLHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
			get
			{
				return default(OBKMOHGGCNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x709AB0", Offset = "0x7080B0", VA = "0x180709AB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool LGOELJFGMLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x783C30", Offset = "0x782230", VA = "0x180783C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool IOIHOMFBMLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x783BC0", Offset = "0x7821C0", VA = "0x180783BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x783BD0", Offset = "0x7821D0", VA = "0x180783BD0")]
		public CFJMCMGIOLO CDAKBFPMONP()
		{
			return default(CFJMCMGIOLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x783C00", Offset = "0x782200", VA = "0x180783C00")]
		public CFJMCMGIOLO GPNHMENDIHO()
		{
			return default(CFJMCMGIOLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[DHKIICMHACJ(typeof(PNINELHDCOE), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Circuits)]
	public class CircuitsService : GOJCOOFCPOI, PNINELHDCOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[CJONPMHNDBN]
		private IDEPDMMAOGA NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager LNPEGOPJJGK;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x38FA7F0", Offset = "0x38F8DF0", VA = "0x1838FA7F0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x38FA4C0", Offset = "0x38F8AC0", VA = "0x1838FA4C0", Slot = "5")]
		public bool INGMIMILKOE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x38F9870", Offset = "0x38F7E70", VA = "0x1838F9870", Slot = "7")]
		public Guid EEBKLLIBFNG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x38FA260", Offset = "0x38F8860", VA = "0x1838FA260", Slot = "8")]
		public void HAEMNFBLNCF(NIALADIPDNC KLCGNDEDAPD, Guid DNKCIBPKEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x38FA190", Offset = "0x38F8790", VA = "0x1838FA190", Slot = "9")]
		public Guid GIMMENNNGFB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x38F9B10", Offset = "0x38F8110", VA = "0x1838F9B10", Slot = "10")]
		public void FAADICJIPMG(NIALADIPDNC KLCGNDEDAPD, Guid LLKHAPMPGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x38FA5C0", Offset = "0x38F8BC0", VA = "0x1838FA5C0", Slot = "11")]
		public bool JEBOCGPANOM(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x38FA610", Offset = "0x38F8C10", VA = "0x1838FA610", Slot = "12")]
		public void JJJBCENALGA(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x38F9D70", Offset = "0x38F8370", VA = "0x1838F9D70", Slot = "13")]
		public void FCCMJCHDFKO(NIALADIPDNC BIPEBBMCHLH, NIALADIPDNC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x38FA680", Offset = "0x38F8C80", VA = "0x1838FA680")]
		private void JJNHJCJEJFL(MMELFMPPKGG KCNCLFLFKKF, NIALADIPDNC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x38FA890", Offset = "0x38F8E90", VA = "0x1838FA890")]
		private void PINBACBOIGG(MMELFMPPKGG KCNCLFLFKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x38F9940", Offset = "0x38F7F40", VA = "0x1838F9940")]
		private bool FAABIMAMNAH(INPNGJHLELG LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x38FAA20", Offset = "0x38F9020", VA = "0x1838FAA20")]
		private bool PJEFNKJKDFF(INPNGJHLELG LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x38FA130", Offset = "0x38F8730", VA = "0x1838FA130", Slot = "6")]
		public bool FPMOALBAMLP(NIALADIPDNC EHLCJHMJBBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[DAINLFLPADL(OHEDAGNNHJA.Connectables)]
	[DHKIICMHACJ(typeof(ALNELIOAEHM), new string[] { })]
	internal class ConnectableService : ALNELIOAEHM, GOJCOOFCPOI, GKFAMMKGENJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class GGMIEHEGPKG : IEnumerable<NIALADIPDNC>, IEnumerable, IEnumerator<NIALADIPDNC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private NIALADIPDNC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private NIALADIPDNC localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public NIALADIPDNC <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private NIALADIPDNC System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NIALADIPDNC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x776CF0", Offset = "0x7752F0", VA = "0x180776CF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x776EB0", Offset = "0x7754B0", VA = "0x180776EB0")]
			[DebuggerHidden]
			public GGMIEHEGPKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x776D40", Offset = "0x775340", VA = "0x180776D40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x7768F0", Offset = "0x774EF0", VA = "0x1807768F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x776E10", Offset = "0x775410", VA = "0x180776E10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x776E60", Offset = "0x775460", VA = "0x180776E60")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x776CB0", Offset = "0x7752B0", VA = "0x180776CB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x776BF0", Offset = "0x7751F0", VA = "0x180776BF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NIALADIPDNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x776BF0", Offset = "0x7751F0", VA = "0x180776BF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly FGGEJMNNOEE ACGBIMFLFPJ;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int PHKJOICPFLL = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int EJDBDBEAPKD = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private BBGDLMHBFGH PJBANBJAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private KMGAJCBNKGB NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService DBDILEFJPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::JIMNIBINLKA<Entity> LKDFEJDIFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::JIMNIBINLKA<float3> BBMLHNFMIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::JIMNIBINLKA<quaternion> KNAHDGCPJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::JIMNIBINLKA<Entity> LFAIGCEGCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::JIMNIBINLKA<float3> PBENCDOOEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::JIMNIBINLKA<quaternion> AILLHFOOINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> FKBDADNAPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> NKBOMIADGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery PNLHOHFCJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<NMHMDBFHOBL> AAMLBALCMHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x739D10", Offset = "0x738310", VA = "0x180739D10", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x739EC0", Offset = "0x7384C0", VA = "0x180739EC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<NIALADIPDNC, NIALADIPDNC> CEANFDAHFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x38FFA50", Offset = "0x38FE050", VA = "0x1838FFA50", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x38FF6D0", Offset = "0x38FDCD0", VA = "0x1838FF6D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<NIALADIPDNC, NIALADIPDNC> GCLMAEDFBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x38FF9B0", Offset = "0x38FDFB0", VA = "0x1838FF9B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x38FF870", Offset = "0x38FDE70", VA = "0x1838FF870", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<NIALADIPDNC, NIALADIPDNC, NIALADIPDNC> IBHGFANEMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x38FFDB0", Offset = "0x38FE3B0", VA = "0x1838FFDB0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x38FEA50", Offset = "0x38FD050", VA = "0x1838FEA50", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<NIALADIPDNC> KFBEHNEIABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x38FF910", Offset = "0x38FDF10", VA = "0x1838FF910", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x38FE9B0", Offset = "0x38FCFB0", VA = "0x1838FE9B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x3900130", Offset = "0x38FE730", VA = "0x183900130", Slot = "25")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x38FEAF0", Offset = "0x38FD0F0", VA = "0x1838FEAF0", Slot = "26")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x38FF340", Offset = "0x38FD940", VA = "0x1838FF340", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x38FF4F0", Offset = "0x38FDAF0", VA = "0x1838FF4F0")]
		private void ECPCAAJAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x38FFC40", Offset = "0x38FE240", VA = "0x1838FFC40")]
		private void LAMNODKAJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x38FE7F0", Offset = "0x38FCDF0", VA = "0x1838FE7F0")]
		private void AHLGGPGIMFF(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x39000D0", Offset = "0x38FE6D0", VA = "0x1839000D0")]
		private void MGDLJFOBBDK(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0xDFEA00", Offset = "0xDFD000", VA = "0x180DFEA00", Slot = "14")]
		public NIALADIPDNC KNHPHOJOCLN(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2151B70", Offset = "0x2150170", VA = "0x182151B70", Slot = "15")]
		public Color IABFALGIHIC(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x39003F0", Offset = "0x38FE9F0", VA = "0x1839003F0", Slot = "16")]
		public float3 PEGMMOELKJL(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x3900340", Offset = "0x38FE940", VA = "0x183900340", Slot = "17")]
		public bool OEAGDOKEHIM(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC NAIPJHKFJBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x38FFAF0", Offset = "0x38FE0F0", VA = "0x1838FFAF0", Slot = "18")]
		public NIALADIPDNC HIHPEPPJJPP(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x38FEF90", Offset = "0x38FD590", VA = "0x1838FEF90", Slot = "21")]
		public void COLJKODFFFJ(NIALADIPDNC KLCGNDEDAPD, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x38FFBA0", Offset = "0x38FE1A0", VA = "0x1838FFBA0", Slot = "23")]
		public float3 JHAGHBBDDPF(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x39002B0", Offset = "0x38FE8B0", VA = "0x1839002B0", Slot = "24")]
		public quaternion NJFMIOKMKJD(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x38FF770", Offset = "0x38FDD70", VA = "0x1838FF770", Slot = "28")]
		public RigidTransform GBLJMBFFBIM(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x38FF550", Offset = "0x38FDB50", VA = "0x1838FF550", Slot = "22")]
		public bool ENKIJIDCIHL(NIALADIPDNC KLCGNDEDAPD, out RigidTransform CNCDAEGBHHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x38FF2B0", Offset = "0x38FD8B0", VA = "0x1838FF2B0", Slot = "19")]
		[IteratorStateMachine(typeof(GGMIEHEGPKG))]
		public IEnumerable<NIALADIPDNC> DHAKAFDGBJH(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x38FFE50", Offset = "0x38FE450", VA = "0x1838FFE50", Slot = "20")]
		public NIALADIPDNC MBDHKCBALEG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x38FF0E0", Offset = "0x38FD6E0", VA = "0x1838FF0E0", Slot = "29")]
		public void DADKJHFJJMM(ref List<NIALADIPDNC> BEMBCCNAMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x38FFFB0", Offset = "0x38FE5B0", VA = "0x1838FFFB0")]
		private Entity MBDHKCBALEG(Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x3900660", Offset = "0x38FEC60", VA = "0x183900660")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	[DHKIICMHACJ(typeof(ObjectInstantiationService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Prefabs)]
	internal sealed class ObjectInstantiationService : GOJCOOFCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI KHDPJJEDHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[CJONPMHNDBN]
		private EOGPNGLEECK PNHAPJJFMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[CJONPMHNDBN]
		private HCBDOBJPIPH LICKMNPDAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[CJONPMHNDBN]
		private ObjectNetworkToLocalMapService GEHGBPFFMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[CJONPMHNDBN]
		private ObjectLifecycleService BKOGMAMFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[CJONPMHNDBN]
		private ObjectPrefabs EJCAANKBGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[CJONPMHNDBN]
		private BBMIMLMPGHJ ADGFMBFGJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private PNILGBJCJNO DNEBJPOMCAM;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int GFFJNIOHENI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x38891A0", Offset = "0x38877A0", VA = "0x1838891A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x38893A0", Offset = "0x38879A0", VA = "0x1838893A0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x3889520", Offset = "0x3887B20", VA = "0x183889520")]
		public Entity NNEMDFGGGMJ(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x38891F0", Offset = "0x38877F0", VA = "0x1838891F0")]
		public Entity INDFCIHCJOC(COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x3888FF0", Offset = "0x38875F0", VA = "0x183888FF0")]
		public Entity HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3888FB0", Offset = "0x38875B0", VA = "0x183888FB0")]
		public Entity HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3889160", Offset = "0x3887760", VA = "0x183889160")]
		public Entity HDLNFCHMNLC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3889310", Offset = "0x3887910", VA = "0x183889310")]
		public Entity KIBFEIABGNF(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x3889540", Offset = "0x3887B40", VA = "0x183889540")]
		public Entity PAOGIEEBPDE(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x38894D0", Offset = "0x3887AD0", VA = "0x1838894D0")]
		public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x3888F60", Offset = "0x3887560", VA = "0x183888F60")]
		public IEnumerable<HLEPLICHNKK> FPMKKFAPLCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3889250", Offset = "0x3887850", VA = "0x183889250")]
		public EntityArchetype JCGKNAGCLPO(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x38892B0", Offset = "0x38878B0", VA = "0x1838892B0")]
		public Entity KHPNNFFFMMF(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x3888FB0", Offset = "0x38875B0", VA = "0x183888FB0")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x3888FF0", Offset = "0x38875F0", VA = "0x183888FF0")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3889040", Offset = "0x3887640", VA = "0x183889040")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA, COEEIJJLOPG FBIBIHJENAB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[DAINLFLPADL(OHEDAGNNHJA.Physics)]
	[DHKIICMHACJ(typeof(IEHKMAFMFKK), new string[] { })]
	public sealed class PhysicsSceneColliderService : IEHKMAFMFKK, FPFBJDKGGPC, BGDEOEAAJCH, GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string GGLBPHGPCEJ = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int DEKOIGGHJBD = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int KFKKECOLJMF = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[CJONPMHNDBN]
		private PAJFOGDKCPC PLNODCMOLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] HNLONHNNNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] GCBKFLDDGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::BGFDJNFLFAN<GICNBHGCLJH, BoxCollider> NJNFNOEPLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene FMEDCFLNIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene LPBKNGLKAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject BHIKNMNBHAG;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int ABJEKBBHMCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x3895AB0", Offset = "0x38940B0", VA = "0x183895AB0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x38965F0", Offset = "0x3894BF0", VA = "0x1838965F0", Slot = "9")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x3896920", Offset = "0x3894F20", VA = "0x183896920", Slot = "10")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x3895BF0", Offset = "0x38941F0", VA = "0x183895BF0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x3896460", Offset = "0x3894A60", VA = "0x183896460", Slot = "4")]
		public GICNBHGCLJH JDKKCIMDCKK(Entity FLADPKIONGF)
		{
			return default(GICNBHGCLJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3896210", Offset = "0x3894810", VA = "0x183896210", Slot = "5")]
		public void HNDMNKKCFGN(NativeArray<GICNBHGCLJH> OEKBACIGMFI, NativeArray<EBMEGFHECAE> KLBNFOIEKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x3895F00", Offset = "0x3894500", VA = "0x183895F00", Slot = "6")]
		public void FDNNDLEHFKD(GICNBHGCLJH ODMNDKFKJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3896880", Offset = "0x3894E80", VA = "0x183896880", Slot = "7")]
		public bool MKHMMCJJNEJ(GICNBHGCLJH ODMNDKFKJHN, out Collider BKPBAEGGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3896B00", Offset = "0x3895100", VA = "0x183896B00")]
		public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x3895BA0", Offset = "0x38941A0", VA = "0x183895BA0")]
		private void DJLMHEEFHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x73B5D0", Offset = "0x739BD0", VA = "0x18073B5D0")]
		private void IBBABJLMHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x3895FD0", Offset = "0x38945D0", VA = "0x183895FD0")]
		private void FKLKLMFAIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x22A5F20", Offset = "0x22A4520", VA = "0x1822A5F20")]
		private void LJIKJACBIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x38969E0", Offset = "0x3894FE0", VA = "0x1838969E0")]
		private BoxCollider OKEANPMELGG(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x3895B20", Offset = "0x3894120", VA = "0x183895B20")]
		private void BLEKKJBGBKN(BoxCollider PPGPEGIOJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x38965B0", Offset = "0x3894BB0", VA = "0x1838965B0")]
		[Conditional("UNITY_EDITOR")]
		private void JODAFGCIGDP(GameObject EHEABJNEALG, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x3896020", Offset = "0x3894620", VA = "0x183896020")]
		private void FLFFLOICEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x3896760", Offset = "0x3894D60", VA = "0x183896760")]
		private void MDLPNDPIGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x3895CF0", Offset = "0x38942F0", VA = "0x183895CF0")]
		private void EKELPNGHIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x3895AF0", Offset = "0x38940F0", VA = "0x183895AF0")]
		private void ANGBPGBIPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x3896870", Offset = "0x3894E70", VA = "0x183896870")]
		private void MGNICNOFOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x3896420", Offset = "0x3894A20", VA = "0x183896420")]
		private void IBNCGIMELHN(Scene COIOOIJMLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x3896E10", Offset = "0x3895410", VA = "0x183896E10", Slot = "8")]
		private bool PDFKJPPMOBC(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[DHKIICMHACJ(typeof(OHNIAMAPMFF), new string[] { })]
public sealed class GLGCNFPKLHG : OHNIAMAPMFF, GOJCOOFCPOI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct MFBJPPJBENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float FAHPBJHMFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint LOKAFGDNNFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private FPFBJDKGGPC PIPCKEICHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private JBFEFNOAFMN DGICDGJFGKG;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x3BC01D0", Offset = "0x3BBE7D0", VA = "0x183BC01D0", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0250", Offset = "0x3BBE850", VA = "0x183BC0250")]
	public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, out IMLPDEKDMHD BCCNCLJADPN, out Entity AOCCAACMBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x3BC00D0", Offset = "0x3BBE6D0", VA = "0x183BC00D0")]
	public static bool IHCELKAKPFM(in Span<IMLPDEKDMHD> NANCADONKPH, float IDHCBHDHMCK, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x3BC06D0", Offset = "0x3BBECD0", VA = "0x183BC06D0")]
	public static float PMNDMAPOJPN(float FAHPBJHMFEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GLGCNFPKLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0240", Offset = "0x3BBE840", VA = "0x183BC0240", Slot = "4")]
	private bool NLNFEKIJIFA(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, out IMLPDEKDMHD BCCNCLJADPN, out Entity AOCCAACMBED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[DHKIICMHACJ(typeof(JBFEFNOAFMN), new string[] { })]
public sealed class AJKIOOEJPLO : JBFEFNOAFMN, GOJCOOFCPOI
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct DJDHGFIPPEG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> IJBCECFNJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 HINKBBCIJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 HAEFNCFNOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> MONLLHCLKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> JBDKDFMECNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> BHLCPIFOMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> JOLMCAIEFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> CHLLLKLOOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<IMLPDEKDMHD> GAPHCJAPECK;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly IMLPDEKDMHD FDPBEPHDJMN;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x7758E0", Offset = "0x773EE0", VA = "0x1807758E0", Slot = "4")]
		public void Execute(int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x775CC0", Offset = "0x7742C0", VA = "0x180775CC0")]
		private static float3 LJLMPKJDFNJ(in float4x4 JOGEFGNGOKI, in float3 GODDPHBMKAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x775720", Offset = "0x773D20", VA = "0x180775720")]
		private static float3 EJENOFGBHHA(in float4x4 JOGEFGNGOKI, in float3 OECCBELLJIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x775BC0", Offset = "0x7741C0", VA = "0x180775BC0")]
		private static float3 KJPADHDKJMK(in float4x4 JOGEFGNGOKI, in float3 GODDPHBMKAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x776460", Offset = "0x774A60", VA = "0x180776460")]
		private static float3 OPFLMNMLGGN(in float4x4 JOGEFGNGOKI, in float3 OECCBELLJIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x7753D0", Offset = "0x7739D0", VA = "0x1807753D0")]
		private bool BEODICJNGEH(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, in NativeArray<Entity> FHJHHNEKCIB, out float3 BCCNCLJADPN, out float3 FACACMFGKHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x775D90", Offset = "0x774390", VA = "0x180775D90")]
		public static bool NFDOHBDOEIA(in float3 PDBIDMEAHPJ, in float3 IGBOHNBJLPJ, in float3 AJJPBAOLMBP, in float3 FMIOEBCGDGK, float ALNNAJNJAJO, float OIGIAECEHDG, out float KHJLEOILJMF, out float3 AFNHKCHCFAI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x38EE2F0", Offset = "0x38EC8F0", VA = "0x1838EE2F0", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x38EE370", Offset = "0x38EC970", VA = "0x1838EE370")]
	public void ONLAOGPNMOG(in NativeArray<Entity> IJBCECFNJIL, in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, in NativeArray<IMLPDEKDMHD> BHKPFKGNPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AJKIOOEJPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x38EE2E0", Offset = "0x38EC8E0", VA = "0x1838EE2E0", Slot = "4")]
	private void KLPBBBGBCMF(in NativeArray<Entity> IJBCECFNJIL, in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, in NativeArray<IMLPDEKDMHD> BHKPFKGNPBG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[DHKIICMHACJ(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[DAINLFLPADL(OHEDAGNNHJA.Embodiment)]
	[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[CJONPMHNDBN]
		private LEDNJPMFMJI NCKCDMENEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[CJONPMHNDBN]
		private EOGPNGLEECK MEFFJILKAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[CJONPMHNDBN]
		private HCBDOBJPIPH JNGDDHBDAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private CLJEHOFLHAA GLMAKIKHNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<COEEIJJLOPG, Entity> DDHAOGJCFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager LNPEGOPJJGK;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<COEEIJJLOPG, Entity> EAHDONFAGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xBA3FD0", Offset = "0xBA25D0", VA = "0x180BA3FD0")]
			get
			{
				return default(NativeHashMap<COEEIJJLOPG, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint EFIJAEJKFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x388C4F0", Offset = "0x388AAF0", VA = "0x18388C4F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x753570", Offset = "0x751B70", VA = "0x180753570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x753A60", Offset = "0x752060", VA = "0x180753A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x388C870", Offset = "0x388AE70", VA = "0x18388C870", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x388C390", Offset = "0x388A990", VA = "0x18388C390", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x388C990", Offset = "0x388AF90", VA = "0x18388C990")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x388C520", Offset = "0x388AB20", VA = "0x18388C520")]
		public void HDECAMKOCDJ(COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x388C770", Offset = "0x388AD70", VA = "0x18388C770")]
		private NIALADIPDNC LKDLNANKINH(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x388C250", Offset = "0x388A850", VA = "0x18388C250")]
		public NIALADIPDNC BIKIJJFPJAP(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x388C6E0", Offset = "0x388ACE0", VA = "0x18388C6E0")]
		public COEEIJJLOPG KHNEHGBKPKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(COEEIJJLOPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x388C400", Offset = "0x388AA00", VA = "0x18388C400")]
		public void EABCHBAKPHG(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x388C330", Offset = "0x388A930", VA = "0x18388C330")]
		public void CODIDBLNHMJ(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x388C490", Offset = "0x388AA90", VA = "0x18388C490")]
		public void GJJOGOOPAKK(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x388C7A0", Offset = "0x388ADA0", VA = "0x18388C7A0")]
		public void MHKCGKBBFAM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[DHKIICMHACJ(typeof(PropertyEventCallbacksService), new string[] { })]
	[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
	[DAINLFLPADL(OHEDAGNNHJA.Callbacks)]
	public class PropertyEventCallbacksService : GOJCOOFCPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct ILHDILENIKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public DDBCMBKNLPG ONHFNOPIIKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type MCLMFJEAHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int JLMAIAGOBFJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct JBMKGMAAILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public ILHDILENIKC[] KECMGAIBBMH;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void DDBCMBKNLPG(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<HDFAPEIIIAK, DDBCMBKNLPG> MOOLNJAEDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, JBMKGMAAILI> HPEACNFJFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private OMKGMEPBKLL KECMGAIBBMH;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action LAMNCLICKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x389D490", Offset = "0x389BA90", VA = "0x18389D490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x389D3A0", Offset = "0x389B9A0", VA = "0x18389D3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action KCHBKIMIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x389C840", Offset = "0x389AE40", VA = "0x18389C840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x389C620", Offset = "0x389AC20", VA = "0x18389C620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x389D440", Offset = "0x389BA40", VA = "0x18389D440", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x389C7B0", Offset = "0x389ADB0", VA = "0x18389C7B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x389D230", Offset = "0x389B830", VA = "0x18389D230")]
		public void KOEBKPOFGOP(HDFAPEIIIAK DPEKNLAIHMP, DDBCMBKNLPG ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x389C6C0", Offset = "0x389ACC0", VA = "0x18389C6C0")]
		public void DIAMOLMPOPF(HDFAPEIIIAK DPEKNLAIHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x389CE20", Offset = "0x389B420", VA = "0x18389CE20")]
		internal void KEFKEPOOGPA(ACMLCBMOLDA BLJBLMCPLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x389C8E0", Offset = "0x389AEE0", VA = "0x18389C8E0")]
		private void HAEOEECBMBD(ACMLCBMOLDA BLJBLMCPLPH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x389D530", Offset = "0x389BB30", VA = "0x18389D530")]
		private void PIHHKJNBNJB(DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG, ILHDILENIKC KHOKCBMOPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x389D0B0", Offset = "0x389B6B0", VA = "0x18389D0B0")]
		private JBMKGMAAILI KNNKPACLAAA(DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG)
		{
			return default(JBMKGMAAILI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x389C530", Offset = "0x389AB30", VA = "0x18389C530")]
		private ILHDILENIKC BNCPBJFAMFC(JBMKGMAAILI PAGFKHPKKBH, DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG)
		{
			return default(ILHDILENIKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x389D800", Offset = "0x389BE00", VA = "0x18389D800")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[DHKIICMHACJ(typeof(LDMOCILFLPC), new string[] { })]
public class FINOGMPFBME : GOJCOOFCPOI, GKFAMMKGENJ, LDMOCILFLPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class DOBGNKIEIOF : IEnumerable<NIALADIPDNC>, IEnumerable, IEnumerator<NIALADIPDNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private NIALADIPDNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public FINOGMPFBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NIALADIPDNC splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public NIALADIPDNC <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private NIALADIPDNC System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0xDF3A10", Offset = "0xDF2010", VA = "0x180DF3A10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x776EB0", Offset = "0x7754B0", VA = "0x180776EB0")]
		[DebuggerHidden]
		public DOBGNKIEIOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xDF3860", Offset = "0xDF1E60", VA = "0x180DF3860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xDF39D0", Offset = "0xDF1FD0", VA = "0x180DF39D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xDF3920", Offset = "0xDF1F20", VA = "0x180DF3920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIALADIPDNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xDF3920", Offset = "0xDF1F20", VA = "0x180DF3920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private CLJEHOFLHAA GLMAKIKHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private MHGNLLBPLCO GMIFEBDIEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService EJCAANKBGPG;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAE00", Offset = "0x3BB9400", VA = "0x183BBAE00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private NNAMEJEONOI MLIEHBECBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA190", Offset = "0x3BB8790", VA = "0x183BBA190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAD70", Offset = "0x3BB9370", VA = "0x183BBAD70", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA1E0", Offset = "0x3BB87E0", VA = "0x183BBA1E0", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA320", Offset = "0x3BB8920", VA = "0x183BBA320", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA570", Offset = "0x3BB8B70", VA = "0x183BBA570")]
	private void FACFIFDLEFF(Entity IDNHGIFGKAE, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA7F0", Offset = "0x3BB8DF0", VA = "0x183BBA7F0", Slot = "14")]
	public NIALADIPDNC HDLNFCHMNLC()
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA9D0", Offset = "0x3BB8FD0", VA = "0x183BBA9D0", Slot = "10")]
	public void LNPAPAFIMNJ(NIALADIPDNC KLCGNDEDAPD, BKNCABFHGMF JJDMBGDPAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAAC0", Offset = "0x3BB90C0", VA = "0x183BBAAC0", Slot = "9")]
	public BKNCABFHGMF LOEKLKAMFAK(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(BKNCABFHGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9CF0", Offset = "0x3BB82F0", VA = "0x183BB9CF0", Slot = "11")]
	public NIALADIPDNC AIAEFIEGLIL(NIALADIPDNC CJBPCJKPDLN, [Optional] Vector3? EINGNKDKDHC, [Optional] Quaternion? JGCPJBFFFAC, [Optional] Vector3? IIOOEIFOODC)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA2E0", Offset = "0x3BB88E0", VA = "0x183BBA2E0", Slot = "15")]
	public NIALADIPDNC DEKBHBFBKLB(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB, [Optional] Vector3? EINGNKDKDHC, [Optional] Quaternion? JGCPJBFFFAC, [Optional] Vector3? IIOOEIFOODC)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAE50", Offset = "0x3BB9450", VA = "0x183BBAE50", Slot = "7")]
	public NIALADIPDNC PEIFIHDAEIE(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA910", Offset = "0x3BB8F10", VA = "0x183BBA910", Slot = "16")]
	public void IMPJEIFPANK(NIALADIPDNC HIMFGNKFJFD, NIALADIPDNC JOMCMEOJGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9FF0", Offset = "0x3BB85F0", VA = "0x183BB9FF0", Slot = "12")]
	public void CDMFFIMJFPP(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA3D0", Offset = "0x3BB89D0", VA = "0x183BBA3D0", Slot = "17")]
	public void EJPHJKIJFKI(NIALADIPDNC HIMFGNKFJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x3BBACD0", Offset = "0x3BB92D0", VA = "0x183BBACD0", Slot = "8")]
	public int MPICFMLJMPK(NIALADIPDNC HIMFGNKFJFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x3BBABB0", Offset = "0x3BB91B0", VA = "0x183BBABB0", Slot = "6")]
	[IteratorStateMachine(typeof(DOBGNKIEIOF))]
	public IEnumerable<NIALADIPDNC> MDOOCFHKHLJ(NIALADIPDNC HIMFGNKFJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAC40", Offset = "0x3BB9240", VA = "0x183BBAC40")]
	private bool MPEDAOFGLFL(NIALADIPDNC HIMFGNKFJFD, out NativeArray<Entity> PAHCBODMCHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA850", Offset = "0x3BB8E50", VA = "0x183BBA850")]
	private NativeArray<Entity> HLANMNAMFOD(NIALADIPDNC HIMFGNKFJFD)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FINOGMPFBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[DHKIICMHACJ(typeof(GINDCKHCNIE), new string[] { })]
[LOICNDEPMOJ(HIFIKBEHMNK.LoadInstance)]
internal sealed class GINDCKHCNIE : GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private LEDNJPMFMJI KHDPJJEDHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase KHNODNCAALN;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private DAOJGNOGCID CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x3BBE3B0", Offset = "0x3BBC9B0", VA = "0x183BBE3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE6D0", Offset = "0x3BBCCD0", VA = "0x183BBE6D0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE750", Offset = "0x3BBCD50", VA = "0x183BBE750")]
	public void NMBFNAPDGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE400", Offset = "0x3BBCA00", VA = "0x183BBE400")]
	public void HMGOOCAOEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GINDCKHCNIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct JEONNONMJKN : IEquatable<JEONNONMJKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int HIMMGNBBIHM;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6FC0", Offset = "0x3BC55C0", VA = "0x183BC6FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC70A0", Offset = "0x3BC56A0", VA = "0x183BC70A0")]
	public JEONNONMJKN(Type MCLMFJEAHEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6EE0", Offset = "0x3BC54E0", VA = "0x183BC6EE0")]
	public static JEONNONMJKN DGKBAOBECFH(Type MCLMFJEAHEC)
	{
		return default(JEONNONMJKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6E90", Offset = "0x3BC5490", VA = "0x183BC6E90")]
	public static Type DGKBAOBECFH(JEONNONMJKN ODMNDKFKJHN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5170", Offset = "0x7F3770", VA = "0x1807F5170")]
	public static bool GBIPOJBPNDJ(JEONNONMJKN IKAMJBDPPHG, JEONNONMJKN LKLEFAIICIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x7F5170", Offset = "0x7F3770", VA = "0x1807F5170")]
	public static bool EOCJAGBGMLJ(JEONNONMJKN IKAMJBDPPHG, JEONNONMJKN LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D30", Offset = "0x7F3330", VA = "0x1807F4D30", Slot = "4")]
	public bool Equals(JEONNONMJKN OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6F40", Offset = "0x3BC5540", VA = "0x183BC6F40", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7020", Offset = "0x3BC5620", VA = "0x183BC7020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class PBJCNIBABCI
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> DOMFNMJNIHG;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> NNPDNCLPNJP;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x38915F0", Offset = "0x388FBF0", VA = "0x1838915F0")]
	static PBJCNIBABCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x3567620", Offset = "0x3565C20", VA = "0x183567620")]
	public static bool MFMCNFFMIAP<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3891580", Offset = "0x388FB80", VA = "0x183891580")]
	public static bool MFMCNFFMIAP(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x3891410", Offset = "0x388FA10", VA = "0x183891410")]
	private static bool MFMCNFFMIAP(Type MCLMFJEAHEC, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x3567590", Offset = "0x3565B90", VA = "0x183567590")]
	public static int GIKDDENMNIA<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x38913A0", Offset = "0x388F9A0", VA = "0x1838913A0")]
	public static int GIKDDENMNIA(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x35674F0", Offset = "0x3565AF0", VA = "0x1835674F0")]
	public static bool DJEIEOEOGPA<T>(out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x3891140", Offset = "0x388F740", VA = "0x183891140")]
	public static bool DJEIEOEOGPA(Type MCLMFJEAHEC, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x3891300", Offset = "0x388F900", VA = "0x183891300")]
	public static Type DNJGGIFCOKL(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x38911E0", Offset = "0x388F7E0", VA = "0x1838911E0")]
	public static bool DJEIEOEOGPA(int EBBLFLFCHFB, out Type MCLMFJEAHEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct GDKJPPNHBEA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] JIHCLPECHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int JKABHKIANJL;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x677CF0", Offset = "0x6762F0", VA = "0x180677CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x27CEDB0", Offset = "0x27CD3B0", VA = "0x1827CEDB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> KHANGGOFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x37CB9F0", Offset = "0x37C9FF0", VA = "0x1837CB9F0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xAF8CD0", Offset = "0xAF72D0", VA = "0x180AF8CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x37CBC00", Offset = "0x37CA200", VA = "0x1837CBC00")]
	public GDKJPPNHBEA(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x37CBB50", Offset = "0x37CA150", VA = "0x1837CBB50")]
	public int NCLIALNFMIA(T MAKFNMHIJIF, int LJECKBCMELA, int FPLNDBJJHMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x37CBA90", Offset = "0x37CA090", VA = "0x1837CBA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct MOFGJBIANBO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::GDKJPPNHBEA<T> JIHCLPECHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int JKABHKIANJL;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x3B99670", Offset = "0x3B97C70", VA = "0x183B99670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x3B994C0", Offset = "0x3B97AC0", VA = "0x183B994C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x3B99EB0", Offset = "0x3B984B0", VA = "0x183B99EB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x3B99E60", Offset = "0x3B98460", VA = "0x183B99E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x3B99FF0", Offset = "0x3B985F0", VA = "0x183B99FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> KHANGGOFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x3B98DC0", Offset = "0x3B973C0", VA = "0x183B98DC0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A180", Offset = "0x3B98780", VA = "0x183B9A180")]
	public MOFGJBIANBO(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A0C0", Offset = "0x3B986C0", VA = "0x183B9A0C0")]
	public T NDLPBJJGODE(int EBBLFLFCHFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x3B99310", Offset = "0x3B97910", VA = "0x183B99310")]
	public void EAPOPGMPIAN(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x3B989E0", Offset = "0x3B96FE0", VA = "0x183B989E0")]
	public void ANNCMMPKBHC(Span<T> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x3B99EE0", Offset = "0x3B984E0", VA = "0x183B99EE0")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x3B99700", Offset = "0x3B97D00", VA = "0x183B99700")]
	private void HCAKDOJKAFA(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x3B998E0", Offset = "0x3B97EE0", VA = "0x183B998E0")]
	public void HGKMPAKBDLD(Span<T> EPKPHBHDHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x3B99260", Offset = "0x3B97860", VA = "0x183B99260")]
	public void DJBHJCJMAFL(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x3B98F10", Offset = "0x3B97510", VA = "0x183B98F10")]
	public void CMMGLMLLAND(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x3B98B50", Offset = "0x3B97150", VA = "0x183B98B50")]
	public void APBNDDFINKH(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x3B98BB0", Offset = "0x3B971B0", VA = "0x183B98BB0")]
	public void BCKCFIAIJFC(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3B99130", Offset = "0x3B97730", VA = "0x183B99130")]
	public void COMPHBNLPPJ(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x3B99B20", Offset = "0x3B98120", VA = "0x183B99B20")]
	public void IFOKOKMOLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A030", Offset = "0x3B98630", VA = "0x183B9A030")]
	public int NCLIALNFMIA(T MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x3B99880", Offset = "0x3B97E80", VA = "0x183B99880")]
	public bool HEBLGIOGKGC(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x3B992C0", Offset = "0x3B978C0", VA = "0x183B992C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A110", Offset = "0x3B98710", VA = "0x183B9A110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x3B991F0", Offset = "0x3B977F0", VA = "0x183B991F0")]
	public static Span<T> DGKBAOBECFH(global::MOFGJBIANBO<T> ACLENHAHHHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x3B99BE0", Offset = "0x3B981E0", VA = "0x183B99BE0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IMIKFGABDNA(int MAKFNMHIJIF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GKOBPMIMFNN(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x3B99510", Offset = "0x3B97B10", VA = "0x183B99510")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GKOBPMIMFNN(int JKABHKIANJL, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x3B99D20", Offset = "0x3B98320", VA = "0x183B99D20")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JLOONFMJHFN(int MAKFNMHIJIF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x3B987E0", Offset = "0x3B96DE0", VA = "0x183B987E0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ABIMBIKDBMO(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x3B99380", Offset = "0x3B97980", VA = "0x183B99380")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void EPGJOGKAKJN(int MAKFNMHIJIF, int JKABHKIANJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct FMHLIBMOGNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int AKGJFAOPKFH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> IJBCECFNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray PJBANBJAEAL;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB940", Offset = "0x3BB9F40", VA = "0x183BBB940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> CCHLCHPBPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x73D300", Offset = "0x73B900", VA = "0x18073D300")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray BPFDOGBAHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB800", Offset = "0x3BB9E00", VA = "0x183BBB800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB990", Offset = "0x3BB9F90", VA = "0x183BBB990")]
	public FMHLIBMOGNG(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB820", Offset = "0x3BB9E20", VA = "0x183BBB820")]
	public Entity MBHLEOADAJO(int EBBLFLFCHFB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB7F0", Offset = "0x3BB9DF0", VA = "0x183BBB7F0")]
	public Transform EGPJFBDDOGE(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB6A0", Offset = "0x3BB9CA0", VA = "0x183BBB6A0")]
	public void BHHBALHHNAM(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB870", Offset = "0x3BB9E70", VA = "0x183BBB870")]
	public int MFMCNFFMIAP(Transform HJLACGOIJCA, Entity FLADPKIONGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB6F0", Offset = "0x3BB9CF0", VA = "0x183BBB6F0")]
	public int DJBHJCJMAFL(int EBBLFLFCHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB770", Offset = "0x3BB9D70", VA = "0x183BBB770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB950", Offset = "0x3BB9F50", VA = "0x183BBB950")]
	private void PAGGNIIGBLM(int HFEDBJBGGGP = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class ILBIHHBCGAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<JEONNONMJKN, int2> CMLCEINDNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> DICKNCEHGPP;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x3BC60E0", Offset = "0x3BC46E0", VA = "0x183BC60E0")]
	public ILBIHHBCGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6080", Offset = "0x3BC4680", VA = "0x183BC6080")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void KMNEKDAGPNL<T>(T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T DNJGGIFCOKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5DF0", Offset = "0x3BC43F0", VA = "0x183BC5DF0")]
	public void KMNEKDAGPNL(Type MCLMFJEAHEC, COGGJKLIPPL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5900", Offset = "0x3BC3F00", VA = "0x183BC5900")]
	public COGGJKLIPPL DNJGGIFCOKL(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5D50", Offset = "0x3BC4350", VA = "0x183BC5D50")]
	private NativeArray<byte> KCDBGMIDMMC(int2 OPKMEAOACCL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5B90", Offset = "0x3BC4190", VA = "0x183BC5B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5C30", Offset = "0x3BC4230", VA = "0x183BC5C30", Slot = "1")]
	~ILBIHHBCGAK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct CPBCEPBDIKL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::CPBCEPBDIKL<T> DGKBAOBECFH(T MAKFNMHIJIF)
	{
		return default(global::CPBCEPBDIKL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T DGKBAOBECFH(global::CPBCEPBDIKL<T> BKMGNMEJDHA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class MCHLKADEEJB
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly ILBIHHBCGAK DDAHHJAEHHL;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x387F020", Offset = "0x387D620", VA = "0x18387F020")]
	internal static void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void KMNEKDAGPNL<T>(T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x387EF80", Offset = "0x387D580", VA = "0x18387EF80")]
	public static void KMNEKDAGPNL(Type MCLMFJEAHEC, COGGJKLIPPL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T DNJGGIFCOKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x387EEE0", Offset = "0x387D4E0", VA = "0x18387EEE0")]
	public static COGGJKLIPPL DNJGGIFCOKL(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class OPMBHIENKNB : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly OPMBHIENKNB MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x3884DE0", Offset = "0x38833E0", VA = "0x183884DE0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FBHIPILAOBE, LinkedEntityGroup DPKHPCDGHJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x3884E00", Offset = "0x3883400", VA = "0x183884E00", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup LGKNNMGLNIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public OPMBHIENKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class FJNPKDEABHB
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void HGOCJCNMADJ(in Vector3 EINGNKDKDHC, in Quaternion JGCPJBFFFAC, in Vector3 IIOOEIFOODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void KNLJKEILPIF(in Vector3 PBCIBNFLBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void GHBGBCBNIAB(in Quaternion JGCPJBFFFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void ALANJKJDPPD(in Vector3 OBHHFBHHOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void INGLDPANENM(in Vector3 OBHHFBHHOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void BFCCDEBINLI(in float NMPAKEMAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB0A0", Offset = "0x3BB96A0", VA = "0x183BBB0A0")]
	[Conditional("DEBUG_BUILD")]
	public static void HHDOHDNHKOO(in float3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in float MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB180", Offset = "0x3BB9780", VA = "0x183BBB180")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in Vector3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB150", Offset = "0x3BB9750", VA = "0x183BBB150")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in Quaternion MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB050", Offset = "0x3BB9650", VA = "0x183BBB050")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in float MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB060", Offset = "0x3BB9660", VA = "0x183BBB060")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in Vector3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB020", Offset = "0x3BB9620", VA = "0x183BBB020")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in Quaternion MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FJNPKDEABHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct AGAIJBALKEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity FLADPKIONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity KOEBMFNDCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity EBIGGMLCEAF;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x38ED970", Offset = "0x38EBF70", VA = "0x1838ED970")]
	public AGAIJBALKEC(Entity FLADPKIONGF, Entity KOEBMFNDCDN, Entity EBIGGMLCEAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x38ED910", Offset = "0x38EBF10", VA = "0x1838ED910")]
	public static AGAIJBALKEC DGKBAOBECFH((Entity entity, Entity oldParent, Entity newParent) FLBKHBGNHCC)
	{
		return default(AGAIJBALKEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x38ED950", Offset = "0x38EBF50", VA = "0x1838ED950")]
	public void EPGCMDKMDAG(out Entity FLADPKIONGF, out Entity KOEBMFNDCDN, out Entity EBIGGMLCEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct KCBMDFFNPLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity FLADPKIONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity LFAIGCEGCPL;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0xAF9240", Offset = "0xAF7840", VA = "0x180AF9240")]
	public KCBMDFFNPLE(Entity FLADPKIONGF, Entity LFAIGCEGCPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x3BC81F0", Offset = "0x3BC67F0", VA = "0x183BC81F0")]
	public static KCBMDFFNPLE DGKBAOBECFH((Entity entity, Entity parent) FLBKHBGNHCC)
	{
		return default(KCBMDFFNPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8220", Offset = "0x3BC6820", VA = "0x183BC8220")]
	public void EPGCMDKMDAG(out Entity FLADPKIONGF, out Entity LFAIGCEGCPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct GAGCOPLHKFA<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle ODMNDKFKJHN;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool FGBKEBJLBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x37BF7F0", Offset = "0x37BDDF0", VA = "0x1837BF7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x37BF800", Offset = "0x37BDE00", VA = "0x1837BF800")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x37BF700", Offset = "0x37BDD00", VA = "0x1837BF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x37BF8A0", Offset = "0x37BDEA0", VA = "0x1837BF8A0")]
	public GAGCOPLHKFA(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x37BF7C0", Offset = "0x37BDDC0", VA = "0x1837BF7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum NDCKDIDFMEA
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct LODLLBEOEDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public NDCKDIDFMEA PJKFKLILAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int FPLOLBPBBLH;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950")]
	public LODLLBEOEDK(NDCKDIDFMEA PJKFKLILAKL, int FPLOLBPBBLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x1AA6C10", Offset = "0x1AA5210", VA = "0x181AA6C10")]
	public static LODLLBEOEDK DGKBAOBECFH((NDCKDIDFMEA eventType, int eventIndex) FBHIPILAOBE)
	{
		return default(LODLLBEOEDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x387E420", Offset = "0x387CA20", VA = "0x18387E420")]
	public void EPGCMDKMDAG(out NDCKDIDFMEA PJKFKLILAKL, out int FPLOLBPBBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[DHKIICMHACJ(typeof(FPFBJDKGGPC), new string[] { })]
public sealed class NNJPNPDHKEF : FPFBJDKGGPC, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private IEHKMAFMFKK ALDNNMNNGLK;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x38823F0", Offset = "0x38809F0", VA = "0x1838823F0", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x3882440", Offset = "0x3880A40", VA = "0x183882440")]
	public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NNJPNPDHKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x3882440", Offset = "0x3880A40", VA = "0x183882440", Slot = "4")]
	private bool PDFKJPPMOBC(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(DIAIFMCDODP))]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal sealed class BPPCNJIIPAN : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x38F5620", Offset = "0x38F3C20", VA = "0x1838F5620", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public BPPCNJIIPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[BCMMDDALFAJ]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
[UpdateInGroup(typeof(NMGKDAKPLLN))]
public sealed class CFNDOPINCKD : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x38F7E30", Offset = "0x38F6430", VA = "0x1838F7E30", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public CFNDOPINCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[BCMMDDALFAJ]
[UpdateInGroup(typeof(GEBKMMJCFHB))]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
internal sealed class HGDGAPPFILL : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0FB0", Offset = "0x3BBF5B0", VA = "0x183BC0FB0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public HGDGAPPFILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class FNJHAHNACMJ : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public FNJHAHNACMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[BCMMDDALFAJ]
[COKNBEFPPIE(HIFIKBEHMNK.LoadInstance)]
[UpdateInGroup(typeof(ABLCJOKJLKE))]
internal sealed class PDEALDMPPOP : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x3891760", Offset = "0x388FD60", VA = "0x183891760", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x19AFDF0", Offset = "0x19AE3F0", VA = "0x1819AFDF0")]
	public PDEALDMPPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[BPAPKMJCHMP(typeof(AuthoredLocalPoseData))]
public sealed class NONENIAELEG : MHLOHCPJKFG
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x3882D80", Offset = "0x3881380", VA = "0x183882D80", Slot = "8")]
	protected override bool HABKFPAJILN(ReadOnlySpan<AuthoredLocalPoseData> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3882CC0", Offset = "0x38812C0", VA = "0x183882CC0", Slot = "9")]
	protected override bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<AuthoredLocalPoseData> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x3882E00", Offset = "0x3881400", VA = "0x183882E00")]
	public NONENIAELEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[BPAPKMJCHMP(typeof(LocalPoseData))]
public sealed class DMANAJHKIHB : LGKPBDJCABL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x3908BF0", Offset = "0x39071F0", VA = "0x183908BF0", Slot = "8")]
	protected override bool HABKFPAJILN(ReadOnlySpan<LocalPoseData> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x3908B30", Offset = "0x3907130", VA = "0x183908B30", Slot = "9")]
	protected override bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<LocalPoseData> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3908C70", Offset = "0x3907270", VA = "0x183908C70")]
	public DMANAJHKIHB()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x791250", Offset = "0x78F850", VA = "0x180791250", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x7921F0", Offset = "0x7907F0", VA = "0x1807921F0", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x387F450", Offset = "0x387DA50", VA = "0x18387F450")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x387F100", Offset = "0x387D700", VA = "0x18387F100")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
