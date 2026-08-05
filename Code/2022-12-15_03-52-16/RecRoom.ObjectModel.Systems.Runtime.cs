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
	[Cpp2IlInjected.Address(RVA = "0x2BCF4E0", Offset = "0x2BCDEE0", VA = "0x182BCF4E0")]
	static DDGNBBCBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C49510", Offset = "0x1C47F10", VA = "0x181C49510")]
	public static void PLMJBMGGDBE<T>(T EIAMEKHGGAJ, ref T DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF4B0", Offset = "0x2BCDEB0", VA = "0x182BCF4B0")]
	public static void PLMJBMGGDBE(FixedString32 EIAMEKHGGAJ, ref string DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF3B0", Offset = "0x2BCDDB0", VA = "0x182BCF3B0")]
	public static void PLMJBMGGDBE(string EIAMEKHGGAJ, ref FixedString32 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF3F0", Offset = "0x2BCDDF0", VA = "0x182BCF3F0")]
	public static void PLMJBMGGDBE(FixedString64 EIAMEKHGGAJ, ref string DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF420", Offset = "0x2BCDE20", VA = "0x182BCF420")]
	public static void PLMJBMGGDBE(string EIAMEKHGGAJ, ref FixedString64 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF230", Offset = "0x2BCDC30", VA = "0x182BCF230")]
	public static void PLMJBMGGDBE(HBIIBBBKJAB EIAMEKHGGAJ, ref Vector3 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF350", Offset = "0x2BCDD50", VA = "0x182BCF350")]
	public static void PLMJBMGGDBE(Vector3 EIAMEKHGGAJ, ref HBIIBBBKJAB DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF200", Offset = "0x2BCDC00", VA = "0x182BCF200")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref Vector4 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF190", Offset = "0x2BCDB90", VA = "0x182BCF190")]
	public static void PLMJBMGGDBE(Vector4 EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF200", Offset = "0x2BCDC00", VA = "0x182BCF200")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref Quaternion DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF190", Offset = "0x2BCDB90", VA = "0x182BCF190")]
	public static void PLMJBMGGDBE(Quaternion EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF480", Offset = "0x2BCDE80", VA = "0x182BCF480")]
	public static void PLMJBMGGDBE(HBIIBBBKJAB EIAMEKHGGAJ, ref float3 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF350", Offset = "0x2BCDD50", VA = "0x182BCF350")]
	public static void PLMJBMGGDBE(float3 EIAMEKHGGAJ, ref HBIIBBBKJAB DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF260", Offset = "0x2BCDC60", VA = "0x182BCF260")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref float4 DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF190", Offset = "0x2BCDB90", VA = "0x182BCF190")]
	public static void PLMJBMGGDBE(float4 EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF260", Offset = "0x2BCDC60", VA = "0x182BCF260")]
	public static void PLMJBMGGDBE(CAIENHKOPMK EIAMEKHGGAJ, ref quaternion DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF2E0", Offset = "0x2BCDCE0", VA = "0x182BCF2E0")]
	public static void PLMJBMGGDBE(quaternion EIAMEKHGGAJ, ref CAIENHKOPMK DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF2A0", Offset = "0x2BCDCA0", VA = "0x182BCF2A0")]
	public static void PLMJBMGGDBE(Entity EIAMEKHGGAJ, ref IIMOFJIHOKP DGEBCAGKNCO, LHDHMGCHIDM IHGCOMBDNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF170", Offset = "0x2BCDB70", VA = "0x182BCF170")]
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
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OBPBNOCJFPI ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F16880", Offset = "0x2F15280", VA = "0x182F16880", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	public GMAKHEOHPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1A570", Offset = "0x2F18F70", VA = "0x182F1A570", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A7B0", Offset = "0x2F191B0", VA = "0x182F1A7B0")]
	[Preserve]
	private void GKAPBBHHFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public ICKPFPJHBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B0B0", Offset = "0x2F19AB0", VA = "0x182F1B0B0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public IEDCGGIGAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FEA0", Offset = "0x2B2E8A0", VA = "0x182B2FEA0")]
		public static ObjectModelConfigAsset PHFCPGGCCJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEC6A60", Offset = "0xEC5460", VA = "0x180EC6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7D760", Offset = "0x3E7C160", VA = "0x183E7D760")]
			public static COEEIJJLOPG PFLBDODGAII(int JCBOPFBACOG)
			{
				return default(COEEIJJLOPG);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3E7DB50", Offset = "0x3E7C550", VA = "0x183E7DB50")]
			private static void PPLAKIJEIKD(NIALADIPDNC BBCLPDIBELE, NIALADIPDNC PHBCAHMJAJH, COEEIJJLOPG FBIBIHJENAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3E7D510", Offset = "0x3E7BF10", VA = "0x183E7D510")]
			public static int MAHLJKMJLDD(GameObject EHEABJNEALG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3E7D6E0", Offset = "0x3E7C0E0", VA = "0x183E7D6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B305C0", Offset = "0x2B2EFC0", VA = "0x182B305C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B30190", Offset = "0x2B2EB90", VA = "0x182B30190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static EOPMPEPMNDF DJPIGNBFNDD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B30700", Offset = "0x2B2F100", VA = "0x182B30700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B30E40", Offset = "0x2B2F840", VA = "0x182B30E40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool BMDLOJGHPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B31400", Offset = "0x2B2FE00", VA = "0x182B31400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static PFKGIHKPIGG AEDPBOIFJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B31860", Offset = "0x2B30260", VA = "0x182B31860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OBPBNOCJFPI ABBJLIEIKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B31380", Offset = "0x2B2FD80", VA = "0x182B31380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static MJFDNFOLGPA GLKPOKJAFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FFA0", Offset = "0x2B2E9A0", VA = "0x182B2FFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LAMNHLNDGKO BPLOKGOONKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B316C0", Offset = "0x2B300C0", VA = "0x182B316C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static CLJEHOFLHAA FPLKCFFBBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B31900", Offset = "0x2B30300", VA = "0x182B31900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static OPAKLFEDMAA MLMCGKJNBJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B30020", Offset = "0x2B2EA20", VA = "0x182B30020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool LBFCHMNDIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B310C0", Offset = "0x2B2FAC0", VA = "0x182B310C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool IPLJLPELEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B309F0", Offset = "0x2B2F3F0", VA = "0x182B309F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool OKIPCPMGFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2B319E0", Offset = "0x2B303E0", VA = "0x182B319E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2B31320", Offset = "0x2B2FD20", VA = "0x182B31320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool OEKBGEEADPL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B31980", Offset = "0x2B30380", VA = "0x182B31980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FF40", Offset = "0x2B2E940", VA = "0x182B2FF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action EOJIPPCPFCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2B30270", Offset = "0x2B2EC70", VA = "0x182B30270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B31560", Offset = "0x2B2FF60", VA = "0x182B31560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B300A0", Offset = "0x2B2EAA0", VA = "0x182B300A0")]
		public static NIALADIPDNC BIKIJJFPJAP(GameObject EHEABJNEALG)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31660", Offset = "0x2B30060", VA = "0x182B31660")]
		public static bool LGJCPCMMJDL(ByteString FJHIHOOEHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B31740", Offset = "0x2B30140", VA = "0x182B31740")]
		public static INPNGJHLELG MDMFFOHHDFN(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B30D10", Offset = "0x2B2F710", VA = "0x182B30D10")]
		public static (ByteString, IDisposable) HGEKGOKJCDE()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B30BE0", Offset = "0x2B2F5E0", VA = "0x182B30BE0")]
		public static (ByteString, IDisposable) HFGBNDBMBOK(IEnumerable<NIALADIPDNC> FEELJHFMNCJ)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B30490", Offset = "0x2B2EE90", VA = "0x182B30490")]
		public static bool FLICJPOGKON(GameObject EHEABJNEALG, out COEEIJJLOPG FBIBIHJENAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B30900", Offset = "0x2B2F300", VA = "0x182B30900")]
		public static bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B30620", Offset = "0x2B2F020", VA = "0x182B30620")]
		public static void GDKKLJBLGGP(bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B311A0", Offset = "0x2B2FBA0", VA = "0x182B311A0")]
		public static Task IKIINMJCMNM(bool CFGMGGHPOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B30820", Offset = "0x2B2F220", VA = "0x182B30820")]
		private static EOPMPEPMNDF GOCEMGIKHLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B30370", Offset = "0x2B2ED70", VA = "0x182B30370")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B36050", Offset = "0x2B34A50", VA = "0x182B36050")]
		public static bool DCKHIGDAIJO(GLICHKLIKDB NLCKOEKLBBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B361F0", Offset = "0x2B34BF0", VA = "0x182B361F0")]
		public static GLICHKLIKDB KOEBKPOFGOP(GameObject EHEABJNEALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B36420", Offset = "0x2B34E20", VA = "0x182B36420")]
		public static GLICHKLIKDB KOEBKPOFGOP(GameObject EHEABJNEALG, COEEIJJLOPG FBIBIHJENAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B35F50", Offset = "0x2B34950", VA = "0x182B35F50")]
		public static bool AOOMLGLMAAE(GameObject POFNLMLLLOA, string IMOKOPFFOAJ, bool NAHCNBIBMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B36620", Offset = "0x2B35020", VA = "0x182B36620")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void NDFLGOAKPBI(GameObject POFNLMLLLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B36100", Offset = "0x2B34B00", VA = "0x182B36100")]
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
			[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NIALADIPDNC CDCHGJINIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NIALADIPDNC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x257A060", Offset = "0x2578A60", VA = "0x18257A060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F09270", Offset = "0x2F07C70", VA = "0x182F09270", Slot = "15")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public INPNGJHLELG BDILHMAFPHD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2F09320", Offset = "0x2F07D20", VA = "0x182F09320", Slot = "6")]
			get
			{
				return default(INPNGJHLELG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2F09260", Offset = "0x2F07C60", VA = "0x182F09260", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EBAPHHOIILB CJEEMAGCIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9E78C0", Offset = "0x9E62C0", VA = "0x1809E78C0", Slot = "7")]
			get
			{
				return default(EBAPHHOIILB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OBPBNOCJFPI ABBJLIEIKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2F08AF0", Offset = "0x2F074F0", VA = "0x182F08AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BBGDLMHBFGH NBLANOGNFOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2F087B0", Offset = "0x2F071B0", VA = "0x182F087B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NMAPLFKNFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FB70", VA = "0x180731170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> HHNGKOLCNIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2F09120", Offset = "0x2F07B20", VA = "0x182F09120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2F09350", Offset = "0x2F07D50", VA = "0x182F09350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GLICHKLIKDB> EFKPICKIDKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2F091C0", Offset = "0x2F07BC0", VA = "0x182F091C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2F093F0", Offset = "0x2F07DF0", VA = "0x182F093F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2F085A0", Offset = "0x2F06FA0", VA = "0x182F085A0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2F08F80", Offset = "0x2F07980", VA = "0x182F08F80", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2F08C30", Offset = "0x2F07630", VA = "0x182F08C30", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2F08EF0", Offset = "0x2F078F0", VA = "0x182F08EF0", Slot = "10")]
		public void OnEmbody(LEDNJPMFMJI KHDPJJEDHOA, NIALADIPDNC EHLCJHMJBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2F08F70", Offset = "0x2F07970", VA = "0x182F08F70", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2F08CE0", Offset = "0x2F076E0", VA = "0x182F08CE0", Slot = "12")]
		public void OnDisembody(bool EHDHBHIGMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2F08810", Offset = "0x2F07210", VA = "0x182F08810")]
		private void JBKMHMCHKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2F08720", Offset = "0x2F07120", VA = "0x182F08720")]
		private void ECHHBHCOJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2F08910", Offset = "0x2F07310", VA = "0x182F08910")]
		private void JBLOBEABNOF(bool IKFCIOJBEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2F08BD0", Offset = "0x2F075D0", VA = "0x182F08BD0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xF96540", Offset = "0xF94F40", VA = "0x180F96540", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B433F0", Offset = "0x2B41DF0", VA = "0x182B433F0", Slot = "6")]
			get
			{
				return default(HLEPLICHNKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B43390", Offset = "0x2B41D90", VA = "0x182B43390")]
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
			[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0", Slot = "6")]
			get
			{
				return default(HLEPLICHNKK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x719E10", VA = "0x18071B410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NIALADIPDNC CDCHGJINIFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC97010", Offset = "0xC95A10", VA = "0x180C97010", Slot = "5")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MGEAADBCNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811120", VA = "0x180812720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity LHEGNCBACAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal CLJEHOFLHAA FPLKCFFBBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal BBGDLMHBFGH MHIMBKNCMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D3C0A0", Offset = "0x2D3AAA0", VA = "0x182D3C0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BED0", Offset = "0x2D3A8D0", VA = "0x182D3BED0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BFB0", Offset = "0x2D3A9B0", VA = "0x182D3BFB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C110", Offset = "0x2D3AB10", VA = "0x182D3C110")]
		internal void OIEJOMHJJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BF10", Offset = "0x2D3A910", VA = "0x182D3BF10")]
		private bool EDDODBNBMEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BEE0", Offset = "0x2D3A8E0", VA = "0x182D3BEE0")]
		private void CBGOAIBBOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BFB0", Offset = "0x2D3A9B0", VA = "0x182D3BFB0")]
		internal void ENCBMHFAOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C420", Offset = "0x2D3AE20", VA = "0x182D3C420")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C500", Offset = "0x2D3AF00", VA = "0x182D3C500")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C84C0", Offset = "0x8C6EC0", VA = "0x1808C84C0", Slot = "19")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EGGANIJGBAJ AEDPBOIFJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KMGAJCBNKGB KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OBPBNOCJFPI ABBJLIEIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB80", Offset = "0x2BBD580", VA = "0x182BBEB80", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE2E0", Offset = "0x2BBCCE0", VA = "0x182BBE2E0", Slot = "20")]
	public void AMMIBONBLOJ(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9810", Offset = "0x7C8210", VA = "0x1807C9810")]
	private void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEAD0", Offset = "0x2BBD4D0", VA = "0x182BBEAD0")]
	private void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE4E0", Offset = "0x2BBCEE0", VA = "0x182BBE4E0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE940", Offset = "0x2BBD340", VA = "0x182BBE940", Slot = "10")]
	public void HIMHLDJIPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void MBKGOAOOIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE9F0", Offset = "0x2BBD3F0", VA = "0x182BBE9F0", Slot = "5")]
	public void KIMLPLPJNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE760", Offset = "0x2BBD160", VA = "0x182BBE760", Slot = "6")]
	public void GIIKIGODMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE980", Offset = "0x2BBD380", VA = "0x182BBE980", Slot = "7")]
	public void IKNKCCOLBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE7B0", Offset = "0x2BBD1B0", VA = "0x182BBE7B0", Slot = "8")]
	public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEA60", Offset = "0x2BBD460", VA = "0x182BBEA60", Slot = "9")]
	public void KPNGBGLCOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE540", Offset = "0x2BBCF40", VA = "0x182BBE540", Slot = "11")]
	public void EOIOFEACJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE6E0", Offset = "0x2BBD0E0", VA = "0x182BBE6E0", Slot = "12")]
	public void FHJCBOAFEOJ(bool BHFCIBGKHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE830", Offset = "0x2BBD230", VA = "0x182BBE830")]
	private void HEAMKLLBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE860", Offset = "0x2BBD260", VA = "0x182BBE860", Slot = "13")]
	public ByteString HGEKGOKJCDE(out IDisposable FEOPLMNGHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE5B0", Offset = "0x2BBCFB0", VA = "0x182BBE5B0", Slot = "14")]
	public void FFFJLEEKFAK(ByteString JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE3F0", Offset = "0x2BBCDF0", VA = "0x182BBE3F0")]
	public static BJDHOGDNAJH CBFHJGEFJHE(EGGANIJGBAJ GOCENLCAMDB, BDNNNEAGBLH NBBMMINMBNH = BDNNNEAGBLH.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void OFMBGANDJKL(EGGANIJGBAJ GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void KAHDAIAHBIF(EGGANIJGBAJ GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public BJDHOGDNAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KPPFOBIONEG
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F20BB0", Offset = "0x2F1F5B0", VA = "0x182F20BB0")]
	public static INPNGJHLELG INDFCIHCJOC(this EOPMPEPMNDF IJJOMIGFFLF, COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
	{
		return default(INPNGJHLELG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F20A90", Offset = "0x2F1F490", VA = "0x182F20A90")]
	public static ADPNEJLEBMK CKCDOPLEPGG(this EOPMPEPMNDF IJJOMIGFFLF)
	{
		return default(ADPNEJLEBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F209E0", Offset = "0x2F1F3E0", VA = "0x182F209E0")]
	public static NIALADIPDNC BIKIJJFPJAP(this EOPMPEPMNDF IJJOMIGFFLF, Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F208B0", Offset = "0x2F1F2B0", VA = "0x182F208B0")]
	public static NIALADIPDNC BIKIJJFPJAP(this EOPMPEPMNDF IJJOMIGFFLF, COEEIJJLOPG FBIBIHJENAB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F20CF0", Offset = "0x2F1F6F0", VA = "0x182F20CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AE22C0", Offset = "0x4AE0CC0", VA = "0x184AE22C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4AE18D0", Offset = "0x4AE02D0", VA = "0x184AE18D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BCFEIPPIFOG AAEEOADJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4AE33D0", Offset = "0x4AE1DD0", VA = "0x184AE33D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BHEGLCENDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4AE1B90", Offset = "0x4AE0590", VA = "0x184AE1B90", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GIKJNBNLBJJ FJAIGBGOONO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4ACA8D0", Offset = "0x4AC92D0", VA = "0x184ACA8D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1554420", Offset = "0x1552E20", VA = "0x181554420", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x414E6B0", Offset = "0x414D0B0", VA = "0x18414E6B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::ALOKFBCAIMB<COEEIJJLOPG> EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4AC9EA0", Offset = "0x4AC88A0", VA = "0x184AC9EA0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCE50", Offset = "0x4ADB850", VA = "0x184ADCE50", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x31ACA60", Offset = "0x31AB460", VA = "0x1831ACA60")]
	public BOKDKPCCEKG(global::NHFPPBDNHIF<Entity> LNOIPGJELOP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2E10", Offset = "0x4AE1810", VA = "0x184AE2E10")]
	private Entity OOFEPMABPOC(COEEIJJLOPG FBIBIHJENAB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x41597F0", Offset = "0x41581F0", VA = "0x1841597F0")]
	private COEEIJJLOPG OOFEPMABPOC(Entity FLADPKIONGF)
	{
		return default(COEEIJJLOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF3C0", Offset = "0x4ACDDC0", VA = "0x184ACF3C0", Slot = "4")]
	public T DNJGGIFCOKL(COEEIJJLOPG FBIBIHJENAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF010", Offset = "0x4ADDA10", VA = "0x184ADF010")]
	public bool KMNEKDAGPNL(COEEIJJLOPG FBIBIHJENAB, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4AC86E0", Offset = "0x4AC70E0", VA = "0x184AC86E0")]
	public bool ADOANPCNBFI(COEEIJJLOPG FBIBIHJENAB, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0580", Offset = "0x4ACEF80", VA = "0x184AD0580", Slot = "9")]
	public bool DPFPNIAFGMD(COEEIJJLOPG FBIBIHJENAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x414EFF0", Offset = "0x414D9F0", VA = "0x18414EFF0", Slot = "26")]
	public object GOFJHIIODPI(COEEIJJLOPG FBIBIHJENAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC220", Offset = "0x4ADAC20", VA = "0x184ADC220")]
	public bool IKGICBKDCJJ(COEEIJJLOPG FBIBIHJENAB, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4ACEAB0", Offset = "0x4ACD4B0", VA = "0x184ACEAB0")]
	public void DNJGGIFCOKL(COEEIJJLOPG FBIBIHJENAB, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4154670", Offset = "0x4153070", VA = "0x184154670")]
	public bool KMNEKDAGPNL(COEEIJJLOPG FBIBIHJENAB, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x413E970", Offset = "0x413D370", VA = "0x18413E970")]
	public bool ADOANPCNBFI(COEEIJJLOPG FBIBIHJENAB, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x31AA620", Offset = "0x31A9020", VA = "0x1831AA620", Slot = "22")]
	public void HEIGEPEFDPE(IDBCBPLBJEI GIBODALIGFC, [Optional] object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8F50", Offset = "0x4AD7950", VA = "0x184AD8F50", Slot = "15")]
	public void HEIGEPEFDPE(COEEIJJLOPG AIGAKEKDKHM, KMICCHHKOED GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x414EC80", Offset = "0x414D680", VA = "0x18414EC80", Slot = "14")]
	public bool GFHPIODIGEI(COEEIJJLOPG DGEBCAGKNCO, COEEIJJLOPG EIAMEKHGGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x24B1D70", Offset = "0x24B0770", VA = "0x1824B1D70", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3830", Offset = "0x4AE2230", VA = "0x184AE3830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x31AB650", Offset = "0x31AA050", VA = "0x1831AB650")]
	public string KABCHDDLAJE(in COGGJKLIPPL DFGEBCFIFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4ACB0F0", Offset = "0x4AC9AF0", VA = "0x184ACB0F0")]
	private void DLADBALAOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4AE09B0", Offset = "0x4ADF3B0", VA = "0x184AE09B0")]
	private void LFJNEAEHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4AD4400", Offset = "0x4AD2E00", VA = "0x184AD4400")]
	private void EFHLPLLMDMO(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA390", Offset = "0x4AD8D90", VA = "0x184ADA390")]
	private void HIDHBMKDCIC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4AD75A0", Offset = "0x4AD5FA0", VA = "0x184AD75A0")]
	[Conditional("DEBUG_BUILD")]
	private static void EIJLDOEFLNK(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB, string MABBPMMEACO, string BBGPEEJJFHP, [CallerMemberName] string CHAHHBDIPFA = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2581870", Offset = "0x2580270", VA = "0x182581870", Slot = "5")]
	private bool ELJGHPBKMGI(COEEIJJLOPG AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x323E1F0", Offset = "0x323CBF0", VA = "0x18323E1F0", Slot = "6")]
	private bool ABNHFMFHCLL(COEEIJJLOPG AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AE60", Offset = "0x2C09860", VA = "0x182C0AE60", Slot = "10")]
	private bool MMMALAHKIGM(COEEIJJLOPG AIGAKEKDKHM, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4158DC0", Offset = "0x41577C0", VA = "0x184158DC0", Slot = "11")]
	private void LMPOJBADNKJ(COEEIJJLOPG AIGAKEKDKHM, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x41545B0", Offset = "0x4152FB0", VA = "0x1841545B0", Slot = "12")]
	private bool KBEMELNIDKC(COEEIJJLOPG AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4153340", Offset = "0x4151D40", VA = "0x184153340", Slot = "13")]
	private bool JEANFCEODEH(COEEIJJLOPG AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x31AA080", Offset = "0x31A8A80", VA = "0x1831AA080", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x31AC710", Offset = "0x31AB110", VA = "0x1831AC710", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x31AC520", Offset = "0x31AAF20", VA = "0x1831AC520", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BCFEIPPIFOG AAEEOADJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x31AC790", Offset = "0x31AB190", VA = "0x1831AC790", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BHEGLCENDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x31AC5D0", Offset = "0x31AAFD0", VA = "0x1831AC5D0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GIKJNBNLBJJ FJAIGBGOONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x31A7EE0", Offset = "0x31A68E0", VA = "0x1831A7EE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x31AA470", Offset = "0x31A8E70", VA = "0x1831AA470", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x31AA040", Offset = "0x31A8A40", VA = "0x1831AA040", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::ALOKFBCAIMB<NIALADIPDNC> EOJIPPCPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x31A7D30", Offset = "0x31A6730", VA = "0x1831A7D30", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x31AB490", Offset = "0x31A9E90", VA = "0x1831AB490", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x31ACA60", Offset = "0x31AB460", VA = "0x1831ACA60")]
	public JGPMEKBNBND(global::NHFPPBDNHIF<Entity> LNOIPGJELOP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1352550", Offset = "0x1350F50", VA = "0x181352550")]
	private Entity OOFEPMABPOC(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x31AC760", Offset = "0x31AB160", VA = "0x1831AC760")]
	private NIALADIPDNC OOFEPMABPOC(Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x31A89D0", Offset = "0x31A73D0", VA = "0x1831A89D0", Slot = "4")]
	public T DNJGGIFCOKL(NIALADIPDNC KLCGNDEDAPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x31AB6E0", Offset = "0x31AA0E0", VA = "0x1831AB6E0")]
	public bool KMNEKDAGPNL(NIALADIPDNC KLCGNDEDAPD, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x31A75C0", Offset = "0x31A5FC0", VA = "0x1831A75C0")]
	public bool ADOANPCNBFI(NIALADIPDNC KLCGNDEDAPD, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x31A9120", Offset = "0x31A7B20", VA = "0x1831A9120", Slot = "9")]
	public bool DPFPNIAFGMD(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31AA5B0", Offset = "0x31A8FB0", VA = "0x1831AA5B0", Slot = "26")]
	public object GOFJHIIODPI(NIALADIPDNC KLCGNDEDAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x31AAF10", Offset = "0x31A9910", VA = "0x1831AAF10")]
	public bool IKGICBKDCJJ(NIALADIPDNC KLCGNDEDAPD, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x31A8D60", Offset = "0x31A7760", VA = "0x1831A8D60")]
	public void DNJGGIFCOKL(NIALADIPDNC KLCGNDEDAPD, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x31ABC30", Offset = "0x31AA630", VA = "0x1831ABC30")]
	public bool KMNEKDAGPNL(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x31A79D0", Offset = "0x31A63D0", VA = "0x1831A79D0")]
	public bool ADOANPCNBFI(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31AA620", Offset = "0x31A9020", VA = "0x1831AA620", Slot = "22")]
	public void HEIGEPEFDPE(IDBCBPLBJEI GIBODALIGFC, [Optional] object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x31AA650", Offset = "0x31A9050", VA = "0x1831AA650", Slot = "15")]
	public void HEIGEPEFDPE(NIALADIPDNC AIGAKEKDKHM, KMICCHHKOED GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31AA2E0", Offset = "0x31A8CE0", VA = "0x1831AA2E0", Slot = "14")]
	public bool GFHPIODIGEI(NIALADIPDNC DGEBCAGKNCO, NIALADIPDNC EIAMEKHGGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x31A8420", Offset = "0x31A6E20", VA = "0x1831A8420")]
	private void DLADBALAOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31AC020", Offset = "0x31AAA20", VA = "0x1831AC020")]
	private void LFJNEAEHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x31A9780", Offset = "0x31A8180", VA = "0x1831A9780")]
	private void EFHLPLLMDMO(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x31AAAF0", Offset = "0x31A94F0", VA = "0x1831AAAF0")]
	private void HIDHBMKDCIC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x31A9300", Offset = "0x31A7D00", VA = "0x1831A9300", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x31AC9C0", Offset = "0x31AB3C0", VA = "0x1831AC9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x31AB650", Offset = "0x31AA050", VA = "0x1831AB650")]
	public string KABCHDDLAJE(in COGGJKLIPPL DFGEBCFIFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x31A7F80", Offset = "0x31A6980", VA = "0x1831A7F80", Slot = "5")]
	private bool DEOJJGGBJIA(NIALADIPDNC AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x31AB6A0", Offset = "0x31AA0A0", VA = "0x1831AB6A0", Slot = "6")]
	private bool KEFJCLFNECC(NIALADIPDNC AIGAKEKDKHM, in T MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AE90", Offset = "0x2C09890", VA = "0x182C0AE90", Slot = "10")]
	private bool HLKBALAMMCP(NIALADIPDNC AIGAKEKDKHM, in object MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x31AA0B0", Offset = "0x31A8AB0", VA = "0x1831AA0B0", Slot = "11")]
	private void GAPAFPKNHCL(NIALADIPDNC AIGAKEKDKHM, in MMINGLJLPAL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x31A7C40", Offset = "0x31A6640", VA = "0x1831A7C40", Slot = "12")]
	private bool BJHNEKCJDMM(NIALADIPDNC AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x31AA3D0", Offset = "0x31A8DD0", VA = "0x1831AA3D0", Slot = "13")]
	private bool GGDEOMLGNPG(NIALADIPDNC AIGAKEKDKHM, in COGGJKLIPPL MAEOIACPFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x31AA080", Offset = "0x31A8A80", VA = "0x1831AA080", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public JGONKIMCOJA(NativeArray<EntityRemapUtility.EntityRemapInfo> HIEMJPKDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D300", Offset = "0x2F1BD00", VA = "0x182F1D300", Slot = "6")]
	public NIALADIPDNC NCLBEMCGPAN(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D2F0", Offset = "0x2F1BCF0", VA = "0x182F1D2F0", Slot = "7")]
	public Entity NCLBEMCGPAN(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D350", Offset = "0x2F1BD50", VA = "0x182F1D350", Slot = "8")]
	public IEnumerable<NIALADIPDNC> NCLBEMCGPAN(IEnumerable<NIALADIPDNC> FEELJHFMNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D290", Offset = "0x2F1BC90", VA = "0x182F1D290", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D349B0", Offset = "0x2D333B0", VA = "0x182D349B0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool IAIALDMGIMH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2D34690", Offset = "0x2D33090", VA = "0x182D34690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2D34630", Offset = "0x2D33030", VA = "0x182D34630")]
		public static SerializationRemapScope EFGLCJPBGNA()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2D34B50", Offset = "0x2D33550", VA = "0x182D34B50")]
		public SerializationRemapScope(HEONIOFKGAF IHALOBEPDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2D34520", Offset = "0x2D32F20", VA = "0x182D34520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2D34720", Offset = "0x2D33120", VA = "0x182D34720")]
		public static NIALADIPDNC NCLBEMCGPAN(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2D34880", Offset = "0x2D33280", VA = "0x182D34880")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F113F0", Offset = "0x2F0FDF0", VA = "0x182F113F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2F11490", Offset = "0x2F0FE90", VA = "0x182F11490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LNMGHGPAPDC KGNIOJBDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2F11750", Offset = "0x2F10150", VA = "0x182F11750")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2F116B0", Offset = "0x2F100B0", VA = "0x182F116B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GDPNCKKMIHE NGHCKACDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2F11570", Offset = "0x2F0FF70", VA = "0x182F11570")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2F11610", Offset = "0x2F10010", VA = "0x182F11610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2F11550", Offset = "0x2F0FF50", VA = "0x182F11550")]
	[Conditional("UNITY_EDITOR")]
	public void FEHPJLPCCNM(COEEIJJLOPG HJBMOBHOPDM, in ODPPCAFLFEI JIHCLPECHIB, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F11530", Offset = "0x2F0FF30", VA = "0x182F11530")]
	[Conditional("UNITY_EDITOR")]
	public void EHDLFMKFHKL(COEEIJJLOPG HJBMOBHOPDM, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2F117F0", Offset = "0x2F101F0", VA = "0x182F117F0")]
	[Conditional("UNITY_EDITOR")]
	public void OHEBKFOOFEJ(COEEIJJLOPG HJBMOBHOPDM, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool JECNHFKPBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B39EF0", Offset = "0x2B388F0", VA = "0x182B39EF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A100", Offset = "0x2B38B00", VA = "0x182B3A100")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CJBDJABJIBA KGNIOJBDOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A910", Offset = "0x2B39310", VA = "0x182B3A910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7D0", Offset = "0x2B391D0", VA = "0x182B3A7D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event KNHAKMNKNMM LIEFGBLDIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A360", Offset = "0x2B38D60", VA = "0x182B3A360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A700", Offset = "0x2B39100", VA = "0x182B3A700")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event CJBDJABJIBA NCCGFNIDICD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A1A0", Offset = "0x2B38BA0", VA = "0x182B3A1A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A400", Offset = "0x2B38E00", VA = "0x182B3A400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event CNKLNJABDIB NGHCKACDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A270", Offset = "0x2B38C70", VA = "0x182B3A270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A660", Offset = "0x2B39060", VA = "0x182B3A660")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MKINNGKOGGH DPIKBEILBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A4C0", Offset = "0x2B38EC0", VA = "0x182B3A4C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A5C0", Offset = "0x2B38FC0", VA = "0x182B3A5C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> JLAHLIMLOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A870", Offset = "0x2B39270", VA = "0x182B3A870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A9D0", Offset = "0x2B393D0", VA = "0x182B3A9D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event PANJGFGLBKA JCAOCFMBODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B39F90", Offset = "0x2B38990", VA = "0x182B39F90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A030", Offset = "0x2B38A30", VA = "0x182B3A030")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A330", Offset = "0x2B38D30", VA = "0x182B3A330")]
	[Conditional("UNITY_EDITOR")]
	public void FPKIDIFHAEM(COEEIJJLOPG FBIBIHJENAB, in ODPPCAFLFEI JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A9B0", Offset = "0x2B393B0", VA = "0x182B3A9B0")]
	[Conditional("UNITY_EDITOR")]
	public void NFOGGMEOAGK(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A0D0", Offset = "0x2B38AD0", VA = "0x182B3A0D0")]
	[Conditional("UNITY_EDITOR")]
	public void CFEDDMKCBCH(COEEIJJLOPG FBIBIHJENAB, in ODPPCAFLFEI JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A4A0", Offset = "0x2B38EA0", VA = "0x182B3A4A0")]
	[Conditional("UNITY_EDITOR")]
	public void IDLPOBCCBLF(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A240", Offset = "0x2B38C40", VA = "0x182B3A240")]
	[Conditional("UNITY_EDITOR")]
	public void DLNEKHEAMGF(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, bool OPBABOLEFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A310", Offset = "0x2B38D10", VA = "0x182B3A310")]
	[Conditional("UNITY_EDITOR")]
	public void FMPCCECLHGK(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A560", Offset = "0x2B38F60", VA = "0x182B3A560")]
	[Conditional("UNITY_EDITOR")]
	public void LHAAEGKOEBH(string NBODBMLPNJA, object GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A7A0", Offset = "0x2B391A0", VA = "0x182B3A7A0")]
	[Conditional("UNITY_EDITOR")]
	public void MLOIHEJKJOC(OKMKIIGHDIM AIGAKEKDKHM, ReadOnlyMemory<byte> GOMBJHKPMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public PNILGBJCJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DHKIICMHACJ(typeof(HNFOOABEAMF), new string[] { })]
public class CMNFIJDIHFF : HNFOOABEAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3540", Offset = "0x2BC1F40", VA = "0x182BC3540", Slot = "5")]
	public void PMPKLGNHKCF(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3460", Offset = "0x2BC1E60", VA = "0x182BC3460", Slot = "6")]
	public void PJEMNEPHBOF(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3270", Offset = "0x2BC1C70", VA = "0x182BC3270", Slot = "7")]
	public void GHGGJEKDBMH(object DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3350", Offset = "0x2BC1D50", VA = "0x182BC3350", Slot = "4")]
	public IDisposable KLAGOJJNMDO(object DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BC1490", Offset = "0x2BBFE90", VA = "0x182BC1490")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC10A0", Offset = "0x2BBFAA0", VA = "0x182BC10A0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0120", Offset = "0x2BBEB20", VA = "0x182BC0120", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0130", Offset = "0x2BBEB30", VA = "0x182BC0130")]
		public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> IFDAGNIOADM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC14E0", Offset = "0x2BBFEE0", VA = "0x182BC14E0")]
		public static bool PAKCIOFGFIL(PDNLIBNBICJ GHNJJOLFHLE, out COEEIJJLOPG FBIBIHJENAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0AF0", Offset = "0x2BBF4F0", VA = "0x182BC0AF0")]
		private void IOOOJMONDON(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, IEnumerable<PDNLIBNBICJ> IFDAGNIOADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0E70", Offset = "0x2BBF870", VA = "0x182BC0E70")]
		private void JMAGEBLCLJK(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BC15F0", Offset = "0x2BBFFF0", VA = "0x182BC15F0")]
		private void PMBJLCKAJHM(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, COEEIJJLOPG FBIBIHJENAB, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1CA0", Offset = "0x2BC06A0", VA = "0x182BC1CA0")]
		private void POLCDJEHEKK(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0250", Offset = "0x2BBEC50", VA = "0x182BC0250")]
		private void HJBLHLMNPML(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, List<PDNLIBNBICJ> MDDLBBEJIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2BC12C0", Offset = "0x2BBFCC0", VA = "0x182BC12C0")]
		private NativeList<COEEIJJLOPG> OMHOMAGHPEC(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA)
		{
			return default(NativeList<COEEIJJLOPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1AD0", Offset = "0x2BC04D0", VA = "0x182BC1AD0")]
		private NativeArray<Entity> PMMKNAJGDOK(NativeList<COEEIJJLOPG> PNEBOKCAENN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1220", Offset = "0x2BBFC20", VA = "0x182BC1220")]
		private static void NMNBJNPMHAB(Dictionary<COEEIJJLOPG, PDNLIBNBICJ> BLDLHAOGGDA, COEEIJJLOPG FBIBIHJENAB, PDNLIBNBICJ GHNJJOLFHLE, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F06600", Offset = "0x2F05000", VA = "0x182F06600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2F06540", Offset = "0x2F04F40", VA = "0x182F06540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool HAFBIPGILLK
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2F06580", Offset = "0x2F04F80", VA = "0x182F06580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2F065C0", Offset = "0x2F04FC0", VA = "0x182F065C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public void AKJHGKNEMFG(string NBODBMLPNJA, EntityManager LNPEGOPJJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public static void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679C50", VA = "0x18067B250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67B270", Offset = "0x679C70", VA = "0x18067B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool PNILLHLFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x776570", Offset = "0x774F70", VA = "0x180776570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x776580", Offset = "0x774F80", VA = "0x180776580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D368C0", Offset = "0x2D352C0", VA = "0x182D368C0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2D36810", Offset = "0x2D35210", VA = "0x182D36810", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool MLDJEKHGDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x71ACE0", Offset = "0x7196E0", VA = "0x18071ACE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x71B490", Offset = "0x719E90", VA = "0x18071B490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public OOEKEMBOFOH DNGHIFJGAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2D36820", Offset = "0x2D35220", VA = "0x182D36820", Slot = "16")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2D35430", Offset = "0x2D33E30", VA = "0x182D35430", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2D366E0", Offset = "0x2D350E0", VA = "0x182D366E0")]
		public static bool LGJCPCMMJDL(ByteString FJHIHOOEHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
		public void DFPABCJAJIP(JDGJKANJDLB KJMBMCGJAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2D35040", Offset = "0x2D33A40", VA = "0x182D35040", Slot = "5")]
		public void CAFNGMCCLJO(bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2D35440", Offset = "0x2D33E40", VA = "0x182D35440", Slot = "6")]
		public Task EEOLLOMMEME(bool CFGMGGHPOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D35CF0", Offset = "0x2D346F0", VA = "0x182D35CF0", Slot = "7")]
		public ByteString HGEKGOKJCDE(out IDisposable FEOPLMNGHHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D35DD0", Offset = "0x2D347D0", VA = "0x182D35DD0", Slot = "19")]
		public ByteString HGEKGOKJCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D356D0", Offset = "0x2D340D0", VA = "0x182D356D0", Slot = "9")]
		public bool FFFJLEEKFAK(ByteString KGNNNIOABNI, LGHOOJDLGDA NBBMMINMBNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D35110", Offset = "0x2D33B10", VA = "0x182D35110")]
		private bool DKKCGCHEDOL(ByteString KGNNNIOABNI, LGHOOJDLGDA NBBMMINMBNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D34E70", Offset = "0x2D33870", VA = "0x182D34E70", Slot = "8")]
		public void ALCNIPKLHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D36240", Offset = "0x2D34C40", VA = "0x182D36240", Slot = "10")]
		public bool IKNKCCOLBMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D35A30", Offset = "0x2D34430", VA = "0x182D35A30", Slot = "11")]
		public bool GPJCPDDOKLN(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D35730", Offset = "0x2D34130", VA = "0x182D35730")]
		public bool FHAGLJJEIBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D364B0", Offset = "0x2D34EB0", VA = "0x182D364B0", Slot = "12")]
		public bool KPNGBGLCOHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D35FB0", Offset = "0x2D349B0", VA = "0x182D35FB0")]
		public void HPLHBIJMEIC(OOEKEMBOFOH.EDALOGCEEGJ.HOKHMJPLAHB ILAPGNJICNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D34BE0", Offset = "0x2D335E0", VA = "0x182D34BE0")]
		private bool AKPNNKMGKOD(ByteString KGNNNIOABNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D35CA0", Offset = "0x2D346A0", VA = "0x182D35CA0")]
		private void HFEOOJJCBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D359D0", Offset = "0x2D343D0", VA = "0x182D359D0")]
		private ByteString GLNPFDLBBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D358C0", Offset = "0x2D342C0", VA = "0x182D358C0")]
		private ByteString FMMMFPMNJGH(ByteString FJHIHOOEHJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D36AA0", Offset = "0x2D354A0", VA = "0x182D36AA0")]
		private OOEKEMBOFOH.EDALOGCEEGJ.HOKHMJPLAHB PKDOFDMECCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D356A0", Offset = "0x2D340A0", VA = "0x182D356A0")]
		private void FDBCEOHOEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D354D0", Offset = "0x2D33ED0", VA = "0x182D354D0", Slot = "13")]
		public bool EOIOFEACJOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D35810", Offset = "0x2D34210", VA = "0x182D35810", Slot = "14")]
		public void FHJCBOAFEOJ(bool BHFCIBGKHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D368D0", Offset = "0x2D352D0", VA = "0x182D368D0")]
		private void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B28320", Offset = "0x2B26D20", VA = "0x182B28320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B280A0", Offset = "0x2B26AA0", VA = "0x182B280A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HEONIOFKGAF> ANPDIGHBHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B281E0", Offset = "0x2B26BE0", VA = "0x182B281E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B27E70", Offset = "0x2B26870", VA = "0x182B27E70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action HBPLGFLPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B28280", Offset = "0x2B26C80", VA = "0x182B28280", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B283C0", Offset = "0x2B26DC0", VA = "0x182B283C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JPHHPJDBILA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B28140", Offset = "0x2B26B40", VA = "0x182B28140", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B28000", Offset = "0x2B26A00", VA = "0x182B28000", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HEONIOFKGAF> KJAGJABOKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B28460", Offset = "0x2B26E60", VA = "0x182B28460", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B27F60", Offset = "0x2B26960", VA = "0x182B27F60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1342BF0", Offset = "0x13415F0", VA = "0x181342BF0")]
	public void ALCNIPKLHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x11C08B0", Offset = "0x11BF2B0", VA = "0x1811C08B0")]
	public void ACJAHNDDKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x10571D0", Offset = "0x1055BD0", VA = "0x1810571D0")]
	public void CPDCLCJIPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B27F10", Offset = "0x2B26910", VA = "0x182B27F10")]
	public void DLJHKLKAACH(HEONIOFKGAF GLKFPPDNABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B27E20", Offset = "0x2B26820", VA = "0x182B27E20")]
	public void CKHDJDHKJJN(HEONIOFKGAF GLKFPPDNABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67CFA0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9C60", Offset = "0x2BB8660", VA = "0x182BB9C60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1686530", Offset = "0x1684F30", VA = "0x181686530", Slot = "14")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB99C0", Offset = "0x2BB83C0", VA = "0x182BB99C0", Slot = "15")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9360", Offset = "0x2BB7D60", VA = "0x182BB9360", Slot = "16")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x82C9E0", Offset = "0x82B3E0", VA = "0x18082C9E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D800", Offset = "0x2B2C200", VA = "0x182B2D800")]
	private NIALADIPDNC EPEPGGCDEDK(Entity FLADPKIONGF)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB98D0", Offset = "0x2BB82D0", VA = "0x182BB98D0", Slot = "4")]
	public NIALADIPDNC KCDNPIAEBEL(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9140", Offset = "0x2BB7B40", VA = "0x182BB9140", Slot = "19")]
	public void BMFAMGNJFCC(ref List<NIALADIPDNC> BEMBCCNAMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9750", Offset = "0x2BB8150", VA = "0x182BB9750", Slot = "20")]
	public IEnumerable<NIALADIPDNC> IPMINALCKNM(NIALADIPDNC KLCGNDEDAPD, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9040", Offset = "0x2BB7A40", VA = "0x182BB9040", Slot = "21")]
	public NIALADIPDNC ALAEJPDKHIN(NIALADIPDNC KLCGNDEDAPD, int EBBLFLFCHFB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8E30", Offset = "0x2BB7830", VA = "0x182BB8E30", Slot = "22")]
	public int ABJOCCLMFMB(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9820", Offset = "0x2BB8220", VA = "0x182BB9820", Slot = "8")]
	public int JGMHFKDKOJL(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8F50", Offset = "0x2BB7950", VA = "0x182BB8F50", Slot = "9")]
	public OKKOFBJCFMA AHEFCACPBBA(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(OKKOFBJCFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9450", Offset = "0x2BB7E50", VA = "0x182BB9450", Slot = "23")]
	public bool DIEIHEANPAO(NIALADIPDNC KLCGNDEDAPD, out OKKOFBJCFMA HONBDPFPFMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9B90", Offset = "0x2BB8590", VA = "0x182BB9B90", Slot = "24")]
	public IEnumerable<NIALADIPDNC> OPILOIOFOMC(NIALADIPDNC KLCGNDEDAPD, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9AC0", Offset = "0x2BB84C0", VA = "0x182BB9AC0", Slot = "12")]
	public NIALADIPDNC OJHGJIBAMMJ(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9650", Offset = "0x2BB8050", VA = "0x182BB9650", Slot = "13")]
	public bool DNKFCLNJCJP(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON, out NIALADIPDNC JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9960", Offset = "0x2BB8360", VA = "0x182BB9960", Slot = "5")]
	public NIALADIPDNC NCMHOFMDGAH(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9930", Offset = "0x2BB8330", VA = "0x182BB9930", Slot = "11")]
	public bool LLHMMIJNOKL(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9CB0", Offset = "0x2BB86B0", VA = "0x182BB9CB0", Slot = "25")]
	public bool PKNAJOGAKAI(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC IMDKOHMGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9620", Offset = "0x2BB8020", VA = "0x182BB9620", Slot = "10")]
	public bool DNJHMIGKLJO(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC EOECNBNBJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9A90", Offset = "0x2BB8490", VA = "0x182BB9A90", Slot = "6")]
	public bool OGODNIIEFFB(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC LFAIGCEGCPL, bool KEKDECHAOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9720", Offset = "0x2BB8120", VA = "0x182BB9720", Slot = "7")]
	public bool EAIMLJHMGNG(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC LFAIGCEGCPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD15B0", Offset = "0x2BCFFB0", VA = "0x182BD15B0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1010", Offset = "0x2BCFA10", VA = "0x182BD1010", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1290", Offset = "0x2BCFC90", VA = "0x182BD1290")]
	public DELPMNCMFNN EGNPFCCJCMB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1390", Offset = "0x2BCFD90", VA = "0x182BD1390")]
	public DELPMNCMFNN EGNPFCCJCMB(HDFAPEIIIAK DPEKNLAIHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1600", Offset = "0x2BD0000", VA = "0x182BD1600")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1790", Offset = "0x2BD0190", VA = "0x182BD1790")]
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
		[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50")]
		get
		{
			return default(NativeList<LODLLBEOEDK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<KCBMDFFNPLE> ENEAKBAAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xC97010", Offset = "0xC95A10", VA = "0x180C97010")]
		get
		{
			return default(NativeList<KCBMDFFNPLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<AGAIJBALKEC> ICFKOKKMJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x11ABD70", Offset = "0x11AA770", VA = "0x1811ABD70")]
		get
		{
			return default(NativeList<AGAIJBALKEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<KCBMDFFNPLE> FPPCMHBMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x11E1610", Offset = "0x11E0010", VA = "0x1811E1610")]
		get
		{
			return default(NativeList<KCBMDFFNPLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle OKNAOHFLMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1716760", Offset = "0x1715160", VA = "0x181716760")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1716750", Offset = "0x1715150", VA = "0x181716750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6540", VA = "0x1809F7B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool ANLEMNFHGII
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFEC0", Offset = "0x2BCE8C0", VA = "0x182BCFEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0440", Offset = "0x2BCEE40", VA = "0x182BD0440")]
	public DELPMNCMFNN(Allocator GGLOKAHPEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD03B0", Offset = "0x2BCEDB0", VA = "0x182BD03B0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFF70", Offset = "0x2BCE970", VA = "0x182BCFF70")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD00A0", Offset = "0x2BCEAA0", VA = "0x182BD00A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F179E0", Offset = "0x2F163E0", VA = "0x182F179E0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F179C0", Offset = "0x2F163C0", VA = "0x182F179C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x9E55F0", Offset = "0x9E3FF0", VA = "0x1809E55F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE290", Offset = "0x2BBCC90", VA = "0x182BBE290")]
	public COEEIJJLOPG OGMOOIPPHPH()
	{
		return default(COEEIJJLOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE1E0", Offset = "0x2BBCBE0", VA = "0x182BBE1E0")]
	public void OCNLHILDMBA(COEEIJJLOPG FBIBIHJENAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1321F20", Offset = "0x1320920", VA = "0x181321F20", Slot = "6")]
	public virtual void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675A10", VA = "0x180677010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2F17090", Offset = "0x2F15A90", VA = "0x182F17090", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2F17040", Offset = "0x2F15A40", VA = "0x182F17040")]
	private void GLPHCFDDABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2F16FE0", Offset = "0x2F159E0", VA = "0x182F16FE0", Slot = "6")]
	public override void GJKIOCLBKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB8860", Offset = "0x2BB7260", VA = "0x182BB8860")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery IJIBFNGGDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery LONNJGHEKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x698030", Offset = "0x696A30", VA = "0x180698030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery BPKGNOGCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1384020", Offset = "0x1382A20", VA = "0x181384020")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MEHHOICNIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1716760", Offset = "0x1715160", VA = "0x181716760")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery PEDBCJGKHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x169B640", Offset = "0x169A040", VA = "0x18169B640")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery JKNFNMHCLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8770", Offset = "0x2BB7170", VA = "0x182BB8770")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int AEFMACOGJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8000", Offset = "0x2BB6A00", VA = "0x182BB8000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int GFFJNIOHENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2BB86A0", Offset = "0x2BB70A0", VA = "0x182BB86A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KPJKFNMIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7F60", Offset = "0x2BB6960", VA = "0x182BB7F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CLADKEDBOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2BB87F0", Offset = "0x2BB71F0", VA = "0x182BB87F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int GAOBMDALHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7F80", Offset = "0x2BB6980", VA = "0x182BB7F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int NJKCHLCGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8520", Offset = "0x2BB6F20", VA = "0x182BB8520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8810", Offset = "0x2BB7210", VA = "0x182BB8810", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8020", Offset = "0x2BB6A20", VA = "0x182BB8020", Slot = "6")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7FA0", Offset = "0x2BB69A0", VA = "0x182BB7FA0")]
	private EntityQueryDesc BMAMMLJNGNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB84C0", Offset = "0x2BB6EC0", VA = "0x182BB84C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB85F0", Offset = "0x2BB6FF0", VA = "0x182BB85F0")]
	public ODOBGKDOFKD GBHFENEHOGG(NIALADIPDNC EHLCJHMJBBP)
	{
		return default(ODOBGKDOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8540", Offset = "0x2BB6F40", VA = "0x182BB8540")]
	public ODOBGKDOFKD GBHFENEHOGG(Entity FLADPKIONGF)
	{
		return default(ODOBGKDOFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB86C0", Offset = "0x2BB70C0", VA = "0x182BB86C0")]
	public HLEPLICHNKK JJGMBAPGGMB(Entity FLADPKIONGF)
	{
		return default(HLEPLICHNKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2BB88B0", Offset = "0x2BB72B0", VA = "0x182BB88B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int AEFMACOGJLN
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2B34430", Offset = "0x2B32E30", VA = "0x182B34430", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int GFFJNIOHENI
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2B34F10", Offset = "0x2B33910", VA = "0x182B34F10", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int KPJKFNMIPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2B34080", Offset = "0x2B32A80", VA = "0x182B34080", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CLADKEDBOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2B35990", Offset = "0x2B34390", VA = "0x182B35990", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int GAOBMDALHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2B340A0", Offset = "0x2B32AA0", VA = "0x182B340A0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int NJKCHLCGMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2B34C10", Offset = "0x2B33610", VA = "0x182B34C10", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<NIALADIPDNC, HLEPLICHNKK> KHMHAFFAPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2B34A20", Offset = "0x2B33420", VA = "0x182B34A20", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2B340C0", Offset = "0x2B32AC0", VA = "0x182B340C0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<NIALADIPDNC> NHLEHDOIPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2B356E0", Offset = "0x2B340E0", VA = "0x182B356E0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2B34D40", Offset = "0x2B33740", VA = "0x182B34D40", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2B359B0", Offset = "0x2B343B0", VA = "0x182B359B0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2B348A0", Offset = "0x2B332A0", VA = "0x182B348A0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2B345B0", Offset = "0x2B32FB0", VA = "0x182B345B0")]
		private void DFOJNMEGACD(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2B34700", Offset = "0x2B33100", VA = "0x182B34700")]
		private void DMOEAPAFOCK(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2B34C30", Offset = "0x2B33630", VA = "0x182B34C30")]
		internal NIALADIPDNC EPEPGGCDEDK(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2B34390", Offset = "0x2B32D90", VA = "0x182B34390", Slot = "41")]
		public OKKOFBJCFMA CDIEAIOHHOI()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2B34650", Offset = "0x2B33050", VA = "0x182B34650", Slot = "42")]
		public OKKOFBJCFMA DJKLOGCINHF()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2B357A0", Offset = "0x2B341A0", VA = "0x182B357A0", Slot = "43")]
		public OKKOFBJCFMA LGELAFNPICM()
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2B34CA0", Offset = "0x2B336A0", VA = "0x182B34CA0", Slot = "10")]
		public ODOBGKDOFKD GBHFENEHOGG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(ODOBGKDOFKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2B35310", Offset = "0x2B33D10", VA = "0x182B35310", Slot = "11")]
		public HLEPLICHNKK JJGMBAPGGMB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2B34290", Offset = "0x2B32C90", VA = "0x182B34290")]
		private OKKOFBJCFMA BKKBIDPJMNE(EntityQuery AMEIGJPGLKK)
		{
			return default(OKKOFBJCFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2B34790", Offset = "0x2B33190", VA = "0x182B34790", Slot = "33")]
		public bool DPFPNIAFGMD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2B34DE0", Offset = "0x2B337E0", VA = "0x182B34DE0", Slot = "29")]
		public void GGPEMOPMMCE(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2B34450", Offset = "0x2B32E50", VA = "0x182B34450", Slot = "30")]
		public void CGLPGHAHONL(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2B35E30", Offset = "0x2B34830", VA = "0x182B35E30", Slot = "31")]
		public void PDCINDJGKMO(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2B34FE0", Offset = "0x2B339E0", VA = "0x182B34FE0", Slot = "22")]
		public INPNGJHLELG HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2B34F30", Offset = "0x2B33930", VA = "0x182B34F30", Slot = "23")]
		public INPNGJHLELG HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2B35C80", Offset = "0x2B34680", VA = "0x182B35C80", Slot = "24")]
		public INPNGJHLELG NNEMDFGGGMJ(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2B350C0", Offset = "0x2B33AC0", VA = "0x182B350C0", Slot = "25")]
		public INPNGJHLELG INDFCIHCJOC(COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2B33FB0", Offset = "0x2B329B0", VA = "0x182B33FB0", Slot = "44")]
		public INPNGJHLELG AAMMNLAAJBN(int GODMIFAALFB, HLEPLICHNKK IGDDGFIHFCA, GameObject EHEABJNEALG)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2B344B0", Offset = "0x2B32EB0", VA = "0x182B344B0", Slot = "26")]
		public ADPNEJLEBMK CKCDOPLEPGG()
		{
			return default(ADPNEJLEBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2B35D10", Offset = "0x2B34710", VA = "0x182B35D10", Slot = "45")]
		public HPDKCBPJHII PAOGIEEBPDE(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(HPDKCBPJHII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2B34E30", Offset = "0x2B33830", VA = "0x182B34E30", Slot = "27")]
		public GACPLFBDPAB HDLNFCHMNLC()
		{
			return default(GACPLFBDPAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2B353F0", Offset = "0x2B33DF0", VA = "0x182B353F0", Slot = "28")]
		public MJKCNNIGAAE KIBFEIABGNF(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(MJKCNNIGAAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2B35780", Offset = "0x2B34180", VA = "0x182B35780", Slot = "12")]
		public void KOEBKPOFGOP(COEEIJJLOPG FBIBIHJENAB, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2B34AC0", Offset = "0x2B334C0", VA = "0x182B34AC0", Slot = "13")]
		public INPNGJHLELG EGMFKDJNLKC(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return default(INPNGJHLELG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2B34340", Offset = "0x2B32D40", VA = "0x182B34340", Slot = "14")]
		public bool CDEJDKLJJPA(NIALADIPDNC KLCGNDEDAPD, out GLICHKLIKDB BIDLMNEFHJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2B34C50", Offset = "0x2B33650", VA = "0x182B34C50", Slot = "46")]
		public Transform FJAPHIONMLH(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2B35940", Offset = "0x2B34340", VA = "0x182B35940", Slot = "16")]
		public bool MKGOOONPMIK(NIALADIPDNC KLCGNDEDAPD, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2B35840", Offset = "0x2B34240", VA = "0x182B35840", Slot = "17")]
		public bool LOMGEMGINNG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2B34050", Offset = "0x2B32A50", VA = "0x182B34050")]
		public bool ADPNNHDPBFH(GLICHKLIKDB MAKFNMHIJIF, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2B34020", Offset = "0x2B32A20", VA = "0x182B34020", Slot = "47")]
		public bool ADPNNHDPBFH(NIALADIPDNC KLCGNDEDAPD, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2B350A0", Offset = "0x2B33AA0", VA = "0x182B350A0", Slot = "48")]
		public void IHFDMGOCGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2B35530", Offset = "0x2B33F30", VA = "0x182B35530", Slot = "15")]
		public void KJDHLIJPDHF(GLICHKLIKDB LGKNNMGLNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2B34250", Offset = "0x2B32C50", VA = "0x182B34250", Slot = "49")]
		public void BJPKHDLNNBP(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2B34820", Offset = "0x2B33220", VA = "0x182B34820", Slot = "18")]
		public bool DPKIDNMHHHJ(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2B35290", Offset = "0x2B33C90", VA = "0x182B35290", Slot = "19")]
		public bool JGABPGKHJJO(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2B358D0", Offset = "0x2B342D0", VA = "0x182B358D0", Slot = "50")]
		public bool MHNBBGFCOPH(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2B34CD0", Offset = "0x2B336D0", VA = "0x182B34CD0", Slot = "51")]
		public bool GCEGADAHECD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2B35C20", Offset = "0x2B34620", VA = "0x182B35C20", Slot = "32")]
		public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2B35350", Offset = "0x2B33D50", VA = "0x182B35350", Slot = "21")]
		public COEEIJJLOPG KHNEHGBKPKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(COEEIJJLOPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2B34160", Offset = "0x2B32B60", VA = "0x182B34160", Slot = "20")]
		public NIALADIPDNC BIKIJJFPJAP(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2B34570", Offset = "0x2B32F70", VA = "0x182B34570")]
		private void CLDACEFIDLN(HLEPLICHNKK IGDDGFIHFCA, NIALADIPDNC KLCGNDEDAPD, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBD8F0", Offset = "0x2BBC2F0", VA = "0x182BBD8F0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD980", Offset = "0x2BBC380", VA = "0x182BBD980")]
	public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
	{
		return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCF20", Offset = "0x2BBB920", VA = "0x182BBCF20")]
	private void GJBEKJLIACA(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD100", Offset = "0x2BBBB00", VA = "0x182BBD100")]
	private void LABMEBHLGIH(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD, int IGDDGFIHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCD90", Offset = "0x2BBB790", VA = "0x182BBCD90")]
	private void DDHKODNIFGK(NativeMultiHashMap<int, (NIALADIPDNC src, NIALADIPDNC dst)> CNFCBIMGEDD, int IGDDGFIHFCA, LDCIHJCLMHG KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD590", Offset = "0x2BBBF90", VA = "0x182BBD590")]
	private NativeMultiHashMap<int, (NIALADIPDNC, NIALADIPDNC)> LLPEKOFHKBJ(Allocator GGLOKAHPEPM, NativeArray<NIALADIPDNC> GDBKNKBNEEN, out NativeArray<(NIALADIPDNC src, NIALADIPDNC dst)> FCJMLDEPMCK)
	{
		return default(NativeMultiHashMap<int, (NIALADIPDNC, NIALADIPDNC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D41170", Offset = "0x2D3FB70", VA = "0x182D41170")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private NNAMEJEONOI MLIEHBECBGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2D3CFF0", Offset = "0x2D3B9F0", VA = "0x182D3CFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2D40870", Offset = "0x2D3F270", VA = "0x182D40870", Slot = "33")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C6A0", Offset = "0x2D3B0A0", VA = "0x182D3C6A0", Slot = "34")]
		public bool AOHOHCHBAPN(Transform HJLACGOIJCA, out NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DF60", Offset = "0x2D3C960", VA = "0x182D3DF60", Slot = "35")]
		public Transform EGPJFBDDOGE(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2D40680", Offset = "0x2D3F080", VA = "0x182D40680", Slot = "30")]
		public bool MKGOOONPMIK(Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2D411C0", Offset = "0x2D3FBC0", VA = "0x182D411C0")]
		private void PCJOBHBOEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F6D0", Offset = "0x2D3E0D0", VA = "0x182D3F6D0", Slot = "29")]
		public void JCLDIEMBPGK(Entity FLADPKIONGF, out Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DB70", Offset = "0x2D3C570", VA = "0x182D3DB70", Slot = "4")]
		public void ECHHBHCOJJD(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E570", Offset = "0x2D3CF70", VA = "0x182D3E570")]
		public void GMFIHJOPNCL(Entity FLADPKIONGF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL, Vector3 PPCHAAFEDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2D413B0", Offset = "0x2D3FDB0", VA = "0x182D413B0")]
		public void PKGDKAJPBGM(Entity FLADPKIONGF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2D41160", Offset = "0x2D3FB60", VA = "0x182D41160", Slot = "27")]
		public void OKHKBBAHJHG(Entity FLADPKIONGF, out Matrix4x4 MIAMIGJGGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2D40DA0", Offset = "0x2D3F7A0", VA = "0x182D40DA0")]
		public void OHOAOOEHGBO(Entity FLADPKIONGF, in Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FE90", Offset = "0x2D3E890", VA = "0x182D3FE90")]
		public void KMGOFJHMOME(Entity FLADPKIONGF, in Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CD20", Offset = "0x2D3B720", VA = "0x182D3CD20")]
		public void BNFIHNKLDEK(Entity FLADPKIONGF, in Matrix4x4 JCKHCLEBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E640", Offset = "0x2D3D040", VA = "0x182D3E640", Slot = "5")]
		public void HBLOPJIPEGM(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F820", Offset = "0x2D3E220", VA = "0x182D3F820", Slot = "6")]
		public Vector3 KDGMFLJDDAN(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2D40770", Offset = "0x2D3F170", VA = "0x182D40770", Slot = "7")]
		public void NDDKBIILBIG(Entity FLADPKIONGF, Quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F5E0", Offset = "0x2D3DFE0", VA = "0x182D3F5E0", Slot = "8")]
		public Quaternion JCHPFNJLGAB(Entity FLADPKIONGF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2D414C0", Offset = "0x2D3FEC0", VA = "0x182D414C0", Slot = "12")]
		public void PKHBLFKPBPM(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CEE0", Offset = "0x2D3B8E0", VA = "0x182D3CEE0", Slot = "11")]
		public Vector3 CDADONFEOKD(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E180", Offset = "0x2D3CB80", VA = "0x182D3E180")]
		public void ELEOAPFDCDK(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2D405E0", Offset = "0x2D3EFE0", VA = "0x182D405E0")]
		private Vector3 MJFCAFIOCKN(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2D40980", Offset = "0x2D3F380", VA = "0x182D40980", Slot = "14")]
		public float NIFMKHDJJNK(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DA60", Offset = "0x2D3C460", VA = "0x182D3DA60", Slot = "13")]
		public void EBICDAKJIHC(Entity FLADPKIONGF, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CA10", Offset = "0x2D3B410", VA = "0x182D3CA10")]
		private float BDLFDEJMOEI(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C860", Offset = "0x2D3B260", VA = "0x182D3C860")]
		public void AOJBKBIJFFO(Entity FLADPKIONGF, float FJLPNOBMKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2D40CC0", Offset = "0x2D3F6C0", VA = "0x182D40CC0", Slot = "16")]
		public Vector3 OGKDGADDFJE(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DE30", Offset = "0x2D3C830", VA = "0x182D3DE30", Slot = "15")]
		public void EGDFIAJIHEE(Entity FLADPKIONGF, Vector3 DNNHJOLMOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FFC0", Offset = "0x2D3E9C0", VA = "0x182D3FFC0")]
		private Vector3 KNJGMJGFFPK(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3DD60", Offset = "0x2D3C760", VA = "0x182D3DD60")]
		public void EFBJHPAJOFD(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2D40B10", Offset = "0x2D3F510", VA = "0x182D40B10")]
		[Conditional("DEBUG_BUILD")]
		private void NOLIGALHMEP(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E020", Offset = "0x2D3CA20", VA = "0x182D3E020", Slot = "36")]
		public void ELAFJFCHKFH(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D130", Offset = "0x2D3BB30", VA = "0x182D3D130", Slot = "9")]
		public void CJPIJADJPPB(Entity FLADPKIONGF, out Vector3 EINGNKDKDHC, out Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D700", Offset = "0x2D3C100", VA = "0x182D3D700", Slot = "10")]
		public void DJDMGHIFBFF(Entity FLADPKIONGF, out Vector3 EINGNKDKDHC, out Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2D3CB00", Offset = "0x2D3B500", VA = "0x182D3CB00", Slot = "37")]
		public void BIKEMMKHJFE(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2D411E0", Offset = "0x2D3FBE0", VA = "0x182D411E0")]
		public void PFJBAFAOHEN(Entity FLADPKIONGF, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E340", Offset = "0x2D3CD40", VA = "0x182D3E340", Slot = "17")]
		public void EPCLMLHFNOF(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C5C0", Offset = "0x2D3AFC0", VA = "0x182D3C5C0", Slot = "18")]
		public Vector3 AIOEBCNOFCP(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FC50", Offset = "0x2D3E650", VA = "0x182D3FC50", Slot = "19")]
		public void KJOKAKCLOLD(Entity FLADPKIONGF, Quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2D40A20", Offset = "0x2D3F420", VA = "0x182D40A20", Slot = "20")]
		public Quaternion NKHCLDCNKGM(Entity FLADPKIONGF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E760", Offset = "0x2D3D160", VA = "0x182D3E760", Slot = "22")]
		public void HEICAIGEECI(Entity FLADPKIONGF, Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F3B0", Offset = "0x2D3DDB0", VA = "0x182D3F3B0", Slot = "21")]
		public Vector3 IBHNOLBJBOE(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F930", Offset = "0x2D3E330", VA = "0x182D3F930", Slot = "23")]
		public void KGHJMEPBGCC(Entity FLADPKIONGF, float KFJIEPBCIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C8F0", Offset = "0x2D3B2F0", VA = "0x182D3C8F0", Slot = "24")]
		public float BCNKCAFHEPN(Entity FLADPKIONGF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2D400F0", Offset = "0x2D3EAF0", VA = "0x182D400F0", Slot = "25")]
		public void LFKDFIGLAEM(Entity FLADPKIONGF, Vector3 KGCCAPLOJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F4A0", Offset = "0x2D3DEA0", VA = "0x182D3F4A0", Slot = "26")]
		public Vector3 IONBKODNGEC(Entity FLADPKIONGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2D3EBC0", Offset = "0x2D3D5C0", VA = "0x182D3EBC0", Slot = "31")]
		public void HFIGFKMINCI(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F260", Offset = "0x2D3DC60", VA = "0x182D3F260")]
		private NIALADIPDNC HMPGNLACACA(Transform HJLACGOIJCA)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D830", Offset = "0x2D3C230", VA = "0x182D3D830")]
		private static TransformEntity DOJDFDGEPHF(HLEPLICHNKK MCLMFJEAHEC, GameObject POFNLMLLLOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2D3E220", Offset = "0x2D3CC20", VA = "0x182D3E220", Slot = "32")]
		public void EOHJCEFBFKJ(Entity FLADPKIONGF, Entity KOEBMFNDCDN, Entity EBIGGMLCEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D0B0", Offset = "0x2D3BAB0", VA = "0x182D3D0B0")]
		private MKNCPKODDIK CJPIJADJPPB(Entity FLADPKIONGF)
		{
			return default(MKNCPKODDIK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D620", Offset = "0x2D3C020", VA = "0x182D3D620")]
		private bool CPJAIDCOIFN(Entity FLADPKIONGF, out Entity LFAIGCEGCPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2D3FAA0", Offset = "0x2D3E4A0", VA = "0x182D3FAA0")]
		private void KJDPOKHPMNC(Entity FLADPKIONGF, out Matrix4x4 MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2D3D280", Offset = "0x2D3BC80", VA = "0x182D3D280")]
		private void CNNIOHOCPAO(Entity FLADPKIONGF, out Matrix4x4 JCKHCLEBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2D413A0", Offset = "0x2D3FDA0", VA = "0x182D413A0", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC31A0", Offset = "0x2BC1BA0", VA = "0x182BC31A0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3130", Offset = "0x2BC1B30", VA = "0x182BC3130", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E790E0", Offset = "0x3E77AE0", VA = "0x183E790E0")]
		public LGDOIINGDIO(IABHAOPOIBC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E790C0", Offset = "0x3E77AC0", VA = "0x183E790C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1081450", Offset = "0x107FE50", VA = "0x181081450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action ODBBIIKIBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A360", Offset = "0x2F18D60", VA = "0x182F1A360")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A2A0", Offset = "0x2F18CA0", VA = "0x182F1A2A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A400", Offset = "0x2F18E00", VA = "0x182F1A400")]
	public LGDOIINGDIO OJJLAJPCHGJ()
	{
		return default(LGDOIINGDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x15055B0", Offset = "0x1503FB0", VA = "0x1815055B0")]
	public void NBPFDKDKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A340", Offset = "0x2F18D40", VA = "0x182F1A340")]
	public void EGPDAHMJJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0xE65990", Offset = "0xE64390", VA = "0x180E65990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x885E20", Offset = "0x884820", VA = "0x180885E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E74BA0", Offset = "0x3E735A0", VA = "0x183E74BA0")]
			public FDJJCJPIKAL(NativeArray<int> IKGOBLILHLB, NativeArray<int> BGLJHEFMNHL, Dictionary<ComponentSystemBase, int> NFECJNKAEOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3E74920", Offset = "0x3E73320", VA = "0x183E74920")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public JMCBLINEGFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x3E77EF0", Offset = "0x3E768F0", VA = "0x183E77EF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x3E780C0", Offset = "0x3E76AC0", VA = "0x183E780C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x3E78010", Offset = "0x3E76A10", VA = "0x183E78010", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x3E78010", Offset = "0x3E76A10", VA = "0x183E78010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0A360", Offset = "0x2F08D60", VA = "0x182F0A360", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F098A0", Offset = "0x2F082A0", VA = "0x182F098A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2F09990", Offset = "0x2F08390", VA = "0x182F09990")]
		[IteratorStateMachine(typeof(JMCBLINEGFB))]
		private IEnumerable<ComponentSystemBase> EOAGABPEMPK(int LJECKBCMELA, int EAJAFIHJLHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F09A20", Offset = "0x2F08420", VA = "0x182F09A20", Slot = "5")]
		public void GAAJOMGCPID(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2F09A20", Offset = "0x2F08420", VA = "0x182F09A20")]
		private void PAMEBPJLKNP(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A490", Offset = "0x2F08E90", VA = "0x182F0A490")]
		public void PAMEBPJLKNP(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2F09490", Offset = "0x2F07E90", VA = "0x182F09490")]
		private void AHJLPFNAOAN(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F09810", Offset = "0x2F08210", VA = "0x182F09810")]
		private void BMEMHCHOGGH(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A240", Offset = "0x2F08C40", VA = "0x182F0A240")]
		private void LKLFNONKGAM(HIFIKBEHMNK ILFGBJGNEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A2A0", Offset = "0x2F08CA0", VA = "0x182F0A2A0")]
		private void MBDNHAAPLOO(int LJECKBCMELA, int EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F09AA0", Offset = "0x2F084A0", VA = "0x182F09AA0")]
		private void GDKKLJBLGGP(int LJECKBCMELA, int EAJAFIHJLHG, bool CFGMGGHPOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A590", Offset = "0x2F08F90", VA = "0x182F0A590")]
		private int PCGKDBDOOHK(HIFIKBEHMNK ILFGBJGNEIK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2F09CB0", Offset = "0x2F086B0", VA = "0x182F09CB0")]
		private bool INADPGGEOHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F09720", Offset = "0x2F08120", VA = "0x182F09720")]
		private Dictionary<ComponentSystemBase, int> BAGEAJBKNKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F09BC0", Offset = "0x2F085C0", VA = "0x182F09BC0")]
		private void IBFPAHLGIDA(NativeArray<int> IKGOBLILHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2F09C00", Offset = "0x2F08600", VA = "0x182F09C00")]
		private void ICNIAPMCFCB(NativeArray<int> BGLJHEFMNHL, NativeArray<int> IKGOBLILHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2F09930", Offset = "0x2F08330", VA = "0x182F09930")]
		private static HIFIKBEHMNK EGDJFGMCKMN(Type MCLMFJEAHEC, HIFIKBEHMNK BKMGNMEJDHA)
		{
			return default(HIFIKBEHMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A640", Offset = "0x2F09040", VA = "0x182F0A640")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2F09B60", Offset = "0x2F08560", VA = "0x182F09B60")]
		[CompilerGenerated]
		private void IACOLAKIBEA(GOJCOOFCPOI LDEKBPOBLDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A430", Offset = "0x2F08E30", VA = "0x182F0A430")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D3A980", Offset = "0x2D39380", VA = "0x182D3A980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool OOKGKOOKPPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2D3B030", Offset = "0x2D39A30", VA = "0x182D3B030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool OMKFJBGCHBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A980", Offset = "0x2D39380", VA = "0x182D3A980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool CMIEMBCACJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2D3A980", Offset = "0x2D39380", VA = "0x182D3A980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B880", Offset = "0x2D3A280", VA = "0x182D3B880", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A9F0", Offset = "0x2D393F0", VA = "0x182D3A9F0", Slot = "14")]
		public void BMJJOILPNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B0D0", Offset = "0x2D39AD0", VA = "0x182D3B0D0", Slot = "15")]
		public void JAFIMFDGMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AC60", Offset = "0x2D39660", VA = "0x182D3AC60", Slot = "5")]
		public void GJDAPNKJCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A800", Offset = "0x2D39200", VA = "0x182D3A800", Slot = "6")]
		public void ABMMBMMDKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B2C0", Offset = "0x2D39CC0", VA = "0x182D3B2C0", Slot = "7")]
		public void KELDCKEFIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AEB0", Offset = "0x2D398B0", VA = "0x182D3AEB0", Slot = "8")]
		public void GNFDCHIIGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AD30", Offset = "0x2D39730", VA = "0x182D3AD30", Slot = "9")]
		public void GMPPMOEBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B440", Offset = "0x2D39E40", VA = "0x182D3B440", Slot = "10")]
		public void KJPCDHNNHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D3B1F0", Offset = "0x2D39BF0", VA = "0x182D3B1F0", Slot = "11")]
		public void JKHCOBLFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
		public void DDONAPIJHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D3AB10", Offset = "0x2D39510", VA = "0x182D3AB10", Slot = "12")]
		public void DCGLPEBKLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public NNAMEJEONOI MLIEHBECBGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7A20", Offset = "0x2BB6420", VA = "0x182BB7A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2D49AD0", Offset = "0x2D484D0", VA = "0x182D49AD0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D499C0", Offset = "0x2D483C0", VA = "0x182D499C0", Slot = "10")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D49660", Offset = "0x2D48060", VA = "0x182D49660")]
		private void CBFHJGEFJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D49790", Offset = "0x2D48190", VA = "0x182D49790", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D49770", Offset = "0x2D48170", VA = "0x182D49770", Slot = "8")]
		public ComponentSystemBase CLIENKFCHHO(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E775D0", Offset = "0x3E75FD0", VA = "0x183E775D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA97B60", Offset = "0xA96560", VA = "0x180A97B60")]
		[DebuggerHidden]
		public HPHGJPKDAFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x3E772C0", Offset = "0x3E75CC0", VA = "0x183E772C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x3E77590", Offset = "0x3E75F90", VA = "0x183E77590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3E774F0", Offset = "0x3E75EF0", VA = "0x183E774F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3E774F0", Offset = "0x3E75EF0", VA = "0x183E774F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD64A0", Offset = "0x2BD4EA0", VA = "0x182BD64A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<MIKODHFFJMF> GIFLGPFGFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6850", Offset = "0x2BD5250", VA = "0x182BD6850", Slot = "8")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5A30", Offset = "0x2BD4430", VA = "0x182BD5A30", Slot = "9")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD61C0", Offset = "0x2BD4BC0", VA = "0x182BD61C0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6250", Offset = "0x2BD4C50", VA = "0x182BD6250", Slot = "6")]
	public bool FKPKMMIGAAD(MIKODHFFJMF LNOIPGJELOP, out NPKIDEECJBB NABGGPANDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5B50", Offset = "0x2BD4550", VA = "0x182BD5B50")]
	private void COHIMCKKAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6500", Offset = "0x2BD4F00", VA = "0x182BD6500")]
	private void IHEPLGCCFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BD59D0", Offset = "0x2BD43D0", VA = "0x182BD59D0")]
	private LEMCOGLIKLN BDBIALKADMG(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BD64A0", Offset = "0x2BD4EA0", VA = "0x182BD64A0")]
	private LEMCOGLIKLN IADPNBBBAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5F50", Offset = "0x2BD4950", VA = "0x182BD5F50")]
	private LEMCOGLIKLN DBLJNEBMLKO(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD66F0", Offset = "0x2BD50F0", VA = "0x182BD66F0")]
	private LEMCOGLIKLN MGEKILGKJKJ(string GFBIJELPOGE, string HKLDIENGNNB, [Optional] LEMCOGLIKLN FMOHFMENOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BD62E0", Offset = "0x2BD4CE0", VA = "0x182BD62E0")]
	[IteratorStateMachine(typeof(HPHGJPKDAFB))]
	private IEnumerable<(string, string)> GFFIFLNNLEL(string DOGPNFMBGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6800", Offset = "0x2BD5200", VA = "0x182BD6800")]
	private bool MMILLIMCGHL(MIKODHFFJMF LNOIPGJELOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6350", Offset = "0x2BD4D50", VA = "0x182BD6350")]
	private BBBICGHCCGN HBNGOBMDALH(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD66A0", Offset = "0x2BD50A0", VA = "0x182BD66A0")]
	private BBBICGHCCGN LMPEMGEMLFC(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5A50", Offset = "0x2BD4450", VA = "0x182BD5A50")]
	private BBBICGHCCGN CKBBDJKHHPB(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1C54E20", Offset = "0x1C53820", VA = "0x181C54E20")]
	private T GOJGMKLOOCG<T>(MIKODHFFJMF LNOIPGJELOP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6940", Offset = "0x2BD5340", VA = "0x182BD6940")]
	private FieldInfo PECCACIBDOK(MIKODHFFJMF LNOIPGJELOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6A20", Offset = "0x2BD5420", VA = "0x182BD6A20")]
	public DPOPHIADMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD68B0", Offset = "0x2BD52B0", VA = "0x182BD68B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NPKIDEECJBB CALMODKDDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<NPKIDEECJBB> NPBDACIGPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<MIKODHFFJMF> DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2F22710", Offset = "0x2F21110", VA = "0x182F22710")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E779A0", Offset = "0x3E763A0", VA = "0x183E779A0")]
			public IMLHLFNBEOK(HistoryService AGMOENMHCDB, bool KDKNGPBBMHK, uint AJGHIJIKOBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3E77970", Offset = "0x3E76370", VA = "0x183E77970", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E71780", Offset = "0x3E70180", VA = "0x183E71780")]
				public AAPPFCOMJNA(FIIPMPGFJKA LBGOBMKAOKK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x3E71750", Offset = "0x3E70150", VA = "0x183E71750", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E7CB60", Offset = "0x3E7B560", VA = "0x183E7CB60")]
				public PEIDEGJNMMJ(FIIPMPGFJKA LBGOBMKAOKK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x3E71750", Offset = "0x3E70150", VA = "0x183E71750", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E753B0", Offset = "0x3E73DB0", VA = "0x183E753B0")]
			public FIIPMPGFJKA(HistoryService JLIPNAINFPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3E75330", Offset = "0x3E73D30", VA = "0x183E75330")]
			public bool GBHGPCNHJPA(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3E75360", Offset = "0x3E73D60", VA = "0x183E75360")]
			public PEIDEGJNMMJ HEPMAAKPJDK()
			{
				return default(PEIDEGJNMMJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3E752E0", Offset = "0x3E73CE0", VA = "0x183E752E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public ILCAMOANIKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x3E77910", Offset = "0x3E76310", VA = "0x183E77910")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public BAOMDDGJADN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x3E726E0", Offset = "0x3E710E0", VA = "0x183E726E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public DNPDOPELOBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x3E73D10", Offset = "0x3E72710", VA = "0x183E73D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool MGMNDKMGNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2F19C70", Offset = "0x2F18670", VA = "0x182F19C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool ICJNLOGIOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2F17BE0", Offset = "0x2F165E0", VA = "0x182F17BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool IGJFEPOGBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2F189B0", Offset = "0x2F173B0", VA = "0x182F189B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int GDEPMBODMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2F18CD0", Offset = "0x2F176D0", VA = "0x182F18CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int JBOAJIEGIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2F19030", Offset = "0x2F17A30", VA = "0x182F19030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool CBDCKJEFGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2F19D40", Offset = "0x2F18740", VA = "0x182F19D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool MOAFIODJNNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2F17C80", Offset = "0x2F16680", VA = "0x182F17C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool JCAKAODLKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x9496F0", Offset = "0x9480F0", VA = "0x1809496F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xFA67C0", Offset = "0xFA51C0", VA = "0x180FA67C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer GADKKOIPBOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2F198F0", Offset = "0x2F182F0", VA = "0x182F198F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action GNGPOMCBPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2F19E10", Offset = "0x2F18810", VA = "0x182F19E10", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2F18760", Offset = "0x2F17160", VA = "0x182F18760", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action ILMBKOICKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2F186C0", Offset = "0x2F170C0", VA = "0x182F186C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2F18050", Offset = "0x2F16A50", VA = "0x182F18050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2F19380", Offset = "0x2F17D80", VA = "0x182F19380", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2F18420", Offset = "0x2F16E20", VA = "0x182F18420", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2F182B0", Offset = "0x2F16CB0", VA = "0x182F182B0")]
		private void DPNIBBGOAIP(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2F18800", Offset = "0x2F17200", VA = "0x182F18800")]
		private void FLKNFHNBIHD(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL FCHBILJGJHO, COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2F19050", Offset = "0x2F17A50", VA = "0x182F19050")]
		private void KDPELIFJFIF(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2F180F0", Offset = "0x2F16AF0", VA = "0x182F180F0", Slot = "14")]
		public IDisposable CPCMKLOAMFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2F18250", Offset = "0x2F16C50", VA = "0x182F18250", Slot = "9")]
		public IDisposable DKPMBCJBPBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2F19D50", Offset = "0x2F18750", VA = "0x182F19D50", Slot = "6")]
		public UndoAction OMDPLCDMOMN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2F19A50", Offset = "0x2F18450", VA = "0x182F19A50", Slot = "15")]
		public RedoAction ODHGEPEIALH()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2F19F60", Offset = "0x2F18960", VA = "0x182F19F60", Slot = "16")]
		public UndoAction PHFLMIPKPIP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2F19B10", Offset = "0x2F18510", VA = "0x182F19B10", Slot = "7")]
		public RedoAction ODHGEPEIALH(UndoAction BIPEBBMCHLH)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A020", Offset = "0x2F18A20", VA = "0x182F1A020", Slot = "8")]
		public UndoAction PHFLMIPKPIP(RedoAction BIPEBBMCHLH)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2F19ED0", Offset = "0x2F188D0", VA = "0x182F19ED0")]
		public bool PEAMEGHCLBA(IKGNDAIPPJE LCBBHNAFOCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2F19F10", Offset = "0x2F18910", VA = "0x182F19F10", Slot = "17")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2F189E0", Offset = "0x2F173E0", VA = "0x182F189E0")]
		public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2F18820", Offset = "0x2F17220", VA = "0x182F18820")]
		public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL MAEOIACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2F17C90", Offset = "0x2F16690", VA = "0x182F17C90")]
		public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2F19C30", Offset = "0x2F18630", VA = "0x182F19C30")]
		private void OIGMFBFNPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2F18970", Offset = "0x2F17370", VA = "0x182F18970")]
		private void GPPBMJODEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2F18950", Offset = "0x2F17350", VA = "0x182F18950")]
		private void GOGCOAKNLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2F18150", Offset = "0x2F16B50", VA = "0x182F18150")]
		private GAEJJDCGBDA DEKCFALNOEO()
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2F18CB0", Offset = "0x2F176B0", VA = "0x182F18CB0")]
		private uint JANDDMHGLBN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2F19EB0", Offset = "0x2F188B0", VA = "0x182F19EB0")]
		private bool PCPAGDAMGEM(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2F17BC0", Offset = "0x2F165C0", VA = "0x182F17BC0")]
		private bool AOPDBEHEHAE(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2F192F0", Offset = "0x2F17CF0", VA = "0x182F192F0")]
		private RedoAction KODCJKCMFJB(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2F19CE0", Offset = "0x2F186E0", VA = "0x182F19CE0")]
		private UndoAction OKEIBFJJIAI(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2F18D70", Offset = "0x2F17770", VA = "0x182F18D70")]
		private GAEJJDCGBDA JNBOBMIHBHF(GAEJJDCGBDA PBOHOIMMGFG, ActionBuffer JDEPMOCPCPK, bool KDKNGPBBMHK)
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2F17DF0", Offset = "0x2F167F0", VA = "0x182F17DF0")]
		private void BKIGBHECLPI(Action PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2509100", Offset = "0x2507B00", VA = "0x182509100")]
		private T BKIGBHECLPI<T>(Func<T> PLKNOODMMGB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2F19350", Offset = "0x2F17D50", VA = "0x182F19350")]
		private IMLHLFNBEOK LIBIEENOEPO(bool KDKNGPBBMHK, uint AJGHIJIKOBE)
		{
			return default(IMLHLFNBEOK);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A220", Offset = "0x2F18C20", VA = "0x182F1A220")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2F19900", Offset = "0x2F18300", VA = "0x182F19900")]
		[CompilerGenerated]
		private UndoAction ODBAJMMAOFI()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2F17ED0", Offset = "0x2F168D0", VA = "0x182F17ED0")]
		[CompilerGenerated]
		private RedoAction CBMGMLAMKFL()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2F18B50", Offset = "0x2F17550", VA = "0x182F18B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public IKHAGHAKDMA(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B920", Offset = "0x2F1A320", VA = "0x182F1B920")]
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
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public HHKIHGDAHAF(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2F17960", Offset = "0x2F16360", VA = "0x182F17960")]
	public static HHKIHGDAHAF DGKBAOBECFH(NativeArray<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2504180", Offset = "0x2502B80", VA = "0x182504180")]
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
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public GJHKCIEBHGJ(NativeArray<byte> HEONDDEAIBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2F161F0", Offset = "0x2F14BF0", VA = "0x182F161F0")]
	public static GJHKCIEBHGJ DGKBAOBECFH(NativeArray<byte> HEONDDEAIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x24F33B0", Offset = "0x24F1DB0", VA = "0x1824F33B0")]
	public void FJHFGNBAGIM<T>(in T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x24F32B0", Offset = "0x24F1CB0", VA = "0x1824F32B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B293E0", Offset = "0x2B27DE0", VA = "0x182B293E0")]
	public static Span<byte> MNFIMGFCCFG(this NativeArray<byte> HEONDDEAIBL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2B29260", Offset = "0x2B27C60", VA = "0x182B29260")]
	public static ReadOnlySpan<byte> MCPMGKMNEIO(this NativeArray<byte> HEONDDEAIBL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2B29470", Offset = "0x2B27E70", VA = "0x182B29470")]
	public static NativeArray<byte> NBJGADHPALO(this NativeArray<byte> HEONDDEAIBL, int LJECKBCMELA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2B291E0", Offset = "0x2B27BE0", VA = "0x182B291E0")]
	public static NativeArray<byte> LMCGEKMLPKM(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x35DD1F0", Offset = "0x35DBBF0", VA = "0x1835DD1F0")]
	public static NativeArray<byte> LMCGEKMLPKM<T>(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2B29170", Offset = "0x2B27B70", VA = "0x182B29170")]
	public static NativeArray<byte> LMBBJAKCDCD(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x35DD190", Offset = "0x35DBB90", VA = "0x1835DD190")]
	public static NativeArray<byte> LMBBJAKCDCD<T>(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2B290F0", Offset = "0x2B27AF0", VA = "0x182B290F0")]
	public static NativeArray<byte> HBHGAIKEDKO(this NativeArray<byte> HEONDDEAIBL, int FPLNDBJJHMM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x35DBC50", Offset = "0x35DA650", VA = "0x1835DBC50")]
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
	[Cpp2IlInjected.Address(RVA = "0xD705F0", Offset = "0xD6EFF0", VA = "0x180D705F0")]
	public CEKAIILGIPJ(NativeList<byte> ACLENHAHHHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC23B0", Offset = "0x2BC0DB0", VA = "0x182BC23B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2B41510", Offset = "0x2B3FF10", VA = "0x182B41510")]
		public FFIDHHPFIFE.IBIHKNHKNLC OJJLAJPCHGJ()
		{
			return default(FFIDHHPFIFE.IBIHKNHKNLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2B40DD0", Offset = "0x2B3F7D0", VA = "0x182B40DD0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2B411D0", Offset = "0x2B3FBD0", VA = "0x182B411D0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2B40A00", Offset = "0x2B3F400", VA = "0x182B40A00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2B41530", Offset = "0x2B3FF30", VA = "0x182B41530")]
		public void OMDPLCDMOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2B41640", Offset = "0x2B40040", VA = "0x182B41640")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2B41180", Offset = "0x2B3FB80", VA = "0x182B41180")]
		private void LOPGBJIBCBH(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C40", Offset = "0x2B3F640", VA = "0x182B40C40")]
		private void EOMIOCMCOPG(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL FCHBILJGJHO, COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2B408E0", Offset = "0x2B3F2E0", VA = "0x182B408E0")]
		private void AHFFBOOJKLD(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E30", Offset = "0x2B3F830", VA = "0x182B40E30")]
		private void KHJHKCELOIP(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C80", Offset = "0x2B3F680", VA = "0x182B40C80")]
		private void GFADCGMPEFP(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2B41450", Offset = "0x2B3FE50", VA = "0x182B41450")]
		private void ODCOOJHGFBM(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2B411B0", Offset = "0x2B3FBB0", VA = "0x182B411B0")]
		private void NBPFDKDKAJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C20", Offset = "0x2B3F620", VA = "0x182B40C20")]
		private void EGPDAHMJJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2B40910", Offset = "0x2B3F310", VA = "0x182B40910")]
		private void CIGGCBOHBIM(KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7240", Offset = "0x3DB5C40", VA = "0x183DB7240", Slot = "6")]
		private void ILNFOPMDOAJ<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, object JOOJGLPIMBB) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41740", Offset = "0x2B40140", VA = "0x182B41740")]
		public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2B416D0", Offset = "0x2B400D0", VA = "0x182B416D0")]
		public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL FCHBILJGJHO, in COGGJKLIPPL MAEOIACPFFP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2B416B0", Offset = "0x2B400B0", VA = "0x182B416B0")]
		public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP, bool MKEMJGPOLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D2DDF0", Offset = "0x2D2C7F0", VA = "0x182D2DDF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public OLJEDHCFLAF[] FIPMHCKCADD
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x2D2DC30", Offset = "0x2D2C630", VA = "0x182D2DC30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
			public DIKPCBBHODH(ActionBuffer IAIILBKFNKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x2D2DD00", Offset = "0x2D2C700", VA = "0x182D2DD00")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D30F00", Offset = "0x2D2F900", VA = "0x182D30F00")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(KNMMJEOEOPK, string, object)> APKKNJBDCIO
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D30F50", Offset = "0x2D2F950", VA = "0x182D30F50")]
			public OLJEDHCFLAF(ActionBuffer IAIILBKFNKO, GAEJJDCGBDA PBOHOIMMGFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x2D30E00", Offset = "0x2D2F800", VA = "0x182D30E00")]
			private string MHCHBKFLKKI(KNMMJEOEOPK IMBILOOKOPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x2D30AC0", Offset = "0x2D2F4C0", VA = "0x182D30AC0")]
			private void IFEPEMKMGAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B6B530", Offset = "0x2B69F30", VA = "0x182B6B530", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBBE20", Offset = "0x2BBA820", VA = "0x182BBBE20")]
			get
			{
				return default(LBOOECEHGKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int ICNBMEOIEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB9D0", Offset = "0x2BBA3D0", VA = "0x182BBB9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBF40", Offset = "0x2BBA940", VA = "0x182BBBF40")]
		public ActionBuffer(CBEPKLBIIOB EPFNIEDFLEF, NHGGIKDMDCJ KECMGAIBBMH, bool MBIKHONBHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBE60", Offset = "0x2BBA860", VA = "0x182BBBE60")]
		public bool PHFBNKNMGCL(out GAEJJDCGBDA PBOHOIMMGFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBDB0", Offset = "0x2BBA7B0", VA = "0x182BBBDB0")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBBB0", Offset = "0x2BBA5B0", VA = "0x182BBBBB0")]
		public GAEJJDCGBDA OMDPLCDMOMN(FCHLEGPJOOJ GLIGCLJIOHI, MADKAIDKJMP HMHKKKAECHF, uint ODPIDGFBPMF)
		{
			return default(GAEJJDCGBDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB270", Offset = "0x2BB9C70", VA = "0x182BBB270")]
		public bool AJGANKIPMJE(uint ODPIDGFBPMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB480", Offset = "0x2BB9E80", VA = "0x182BBB480")]
		public bool HPMHEMEBDFK(uint ODPIDGFBPMF, out GAEJJDCGBDA BIPEBBMCHLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB310", Offset = "0x2BB9D10", VA = "0x182BBB310")]
		public void FLKDKHMGMMP(GAEJJDCGBDA BIPEBBMCHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBA10", Offset = "0x2BBA410", VA = "0x182BBBA10")]
		[Conditional("DEBUG_BUILD")]
		private void NLDNGAKCAEK(GAEJJDCGBDA BIPEBBMCHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB8C0", Offset = "0x2BBA2C0", VA = "0x182BBB8C0")]
		private void JNBOBMIHBHF(GAEJJDCGBDA GGNPCMLBMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB670", Offset = "0x2BBA070", VA = "0x182BBB670")]
		private void INIIPOKFIPD(HHKIHGDAHAF CBIEEMJACJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBB50", Offset = "0x2BBA550", VA = "0x182BBBB50")]
		private void OBMECJOPMEL(GAEJJDCGBDA PBOHOIMMGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBCF0", Offset = "0x2BBA6F0", VA = "0x182BBBCF0")]
		private HHKIHGDAHAF PBAOCLHMPMN(GAEJJDCGBDA PBOHOIMMGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB2A0", Offset = "0x2BB9CA0", VA = "0x182BBB2A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6776E0", Offset = "0x6760E0", VA = "0x1806776E0")]
	public CBCEJNIPFII(CBEPKLBIIOB EPFNIEDFLEF, NHGGIKDMDCJ KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x25E9560", Offset = "0x25E7F60", VA = "0x1825E9560", Slot = "4")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> AKKPMKJBELG, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2140", Offset = "0x2BC0B40", VA = "0x182BC2140")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E77780", Offset = "0x3E76180", VA = "0x183E77780")]
		public IBIHKNHKNLC(FFIDHHPFIFE LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E77760", Offset = "0x3E76160", VA = "0x183E77760", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0F520", Offset = "0x2F0DF20", VA = "0x182F0F520")]
		get
		{
			return default(FCHLEGPJOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool ODJOJHICMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0F780", Offset = "0x2F0E180", VA = "0x182F0F780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F8B0", Offset = "0x2F0E2B0", VA = "0x182F0F8B0")]
	public FFIDHHPFIFE(FCHLEGPJOOJ.PDMNNKDAAOM CBHAAIPJCPO = FCHLEGPJOOJ.PDMNNKDAAOM.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F8A0", Offset = "0x2F0E2A0", VA = "0x182F0F8A0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F6B0", Offset = "0x2F0E0B0", VA = "0x182F0F6B0")]
	public void HJILJCOBKBK(COEEIJJLOPG EHLCJHMJBBP, ODPPCAFLFEI LLLOECINIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F650", Offset = "0x2F0E050", VA = "0x182F0F650")]
	public void FMLJOGAGNLO(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F460", Offset = "0x2F0DE60", VA = "0x182F0F460")]
	public void BHHFEICBEND(COEEIJJLOPG EHLCJHMJBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F790", Offset = "0x2F0E190", VA = "0x182F0F790")]
	public void NBPFDKDKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F570", Offset = "0x2F0DF70", VA = "0x182F0F570")]
	public void EGPDAHMJJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F560", Offset = "0x2F0DF60", VA = "0x182F0F560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F870", Offset = "0x2F0E270", VA = "0x182F0F870")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A64720", Offset = "0x2A63120", VA = "0x182A64720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
	public KNMMJEOEOPK(COEEIJJLOPG EHLCJHMJBBP, HDFAPEIIIAK DPEKNLAIHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F430", Offset = "0x2F1DE30", VA = "0x182F1F430")]
	public void FHDOHDMGJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F2B0", Offset = "0x2F1DCB0", VA = "0x182F1F2B0", Slot = "4")]
	public int CompareTo(KNMMJEOEOPK OANENNOJEBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F4C0", Offset = "0x2F1DEC0", VA = "0x182F1F4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F340", Offset = "0x2F1DD40", VA = "0x182F1F340", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F3E0", Offset = "0x2F1DDE0", VA = "0x182F1F3E0", Slot = "5")]
	public bool Equals(KNMMJEOEOPK OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F440", Offset = "0x2F1DE40", VA = "0x182F1F440")]
	public static bool GBIPOJBPNDJ(KNMMJEOEOPK OLACFPEGPAG, KNMMJEOEOPK GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F2F0", Offset = "0x2F1DCF0", VA = "0x182F1F2F0")]
	public static bool EOCJAGBGMLJ(KNMMJEOEOPK OLACFPEGPAG, KNMMJEOEOPK GLLCOOLKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F480", Offset = "0x2F1DE80", VA = "0x182F1F480", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F16DB0", Offset = "0x2F157B0", VA = "0x182F16DB0")]
		public void IBOAJMMFNDA(COEEIJJLOPG EHLCJHMJBBP, CBEPKLBIIOB EPFNIEDFLEF, HistoryService JLIPNAINFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F16EC0", Offset = "0x2F158C0", VA = "0x182F16EC0", Slot = "4")]
		private void LBOGHDIEGFM(EOKJCPFONJL LNOIPGJELOP, in COGGJKLIPPL MAKFNMHIJIF, object JOOJGLPIMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class OHJMCJHNALO
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B29D20", Offset = "0x2B28720", VA = "0x182B29D20")]
	public static void GFADCGMPEFP(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL, ODPPCAFLFEI LLLOECINIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B29E20", Offset = "0x2B28820", VA = "0x182B29E20")]
	public static void HNLDCCKEKEP(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B29EE0", Offset = "0x2B288E0", VA = "0x182B29EE0")]
	public static void ODCOOJHGFBM(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B29C70", Offset = "0x2B28670", VA = "0x182B29C70")]
	public static void FLPCLIDMLIB(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B29C20", Offset = "0x2B28620", VA = "0x182B29C20")]
	public static ODPPCAFLFEI CDCHHLCFDNB(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL)
	{
		return default(ODPPCAFLFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x35E00F0", Offset = "0x35DEAF0", VA = "0x1835E00F0")]
	public static T OHDEGGJMFFP<T>(FCHLEGPJOOJ GLIGCLJIOHI, KNMMJEOEOPK IMBILOOKOPL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x35E00C0", Offset = "0x35DEAC0", VA = "0x1835E00C0")]
	public static T OHDEGGJMFFP<T>(ref HHKIHGDAHAF JIHCLPECHIB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B29BD0", Offset = "0x2B285D0", VA = "0x182B29BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7C180", Offset = "0x3E7AB80", VA = "0x183E7C180")]
		public OEPDEPMEIGM(FCHLEGPJOOJ ACLENHAHHHH, MADKAIDKJMP HMHKKKAECHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BAC0", Offset = "0x3E7A4C0", VA = "0x183E7BAC0")]
		public void DGIBIKKOBAK(NativeList<byte> FJEDANIIFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C130", Offset = "0x3E7AB30", VA = "0x183E7C130")]
		private void PFAEPEKFIFL(KNMMJEOEOPK IMBILOOKOPL, ref GJHKCIEBHGJ EOBIHPNMGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C0A0", Offset = "0x3E7AAA0", VA = "0x183E7C0A0")]
		private void GLJLAONLPFJ(KNMMJEOEOPK IMBILOOKOPL, ref GJHKCIEBHGJ EOBIHPNMGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B9D0", Offset = "0x3E7A3D0", VA = "0x183E7B9D0")]
		private NativeArray<byte> DCKEEJEBHAK(NativeList<byte> FJEDANIIFJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BD60", Offset = "0x3E7A760", VA = "0x183E7BD60")]
		private NativeArray<byte> EDNGDFHNMLD(NativeList<byte> FJEDANIIFJL, int JKABHKIANJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BE50", Offset = "0x3E7A850", VA = "0x183E7BE50")]
		private int GJELJKOOHOO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B870", Offset = "0x3E7A270", VA = "0x183E7B870")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E796F0", Offset = "0x3E780F0", VA = "0x183E796F0")]
		internal LKHNNDCGJLC(FCHLEGPJOOJ ACLENHAHHHH, KNMMJEOEOPK CELBLIIOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E794D0", Offset = "0x3E77ED0", VA = "0x183E794D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E79500", Offset = "0x3E77F00", VA = "0x183E79500")]
		public void EPGBCEBPCKD(NativeArray<byte> MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E79470", Offset = "0x3E77E70", VA = "0x183E79470")]
		public void BPLHEGOLOIO(NativeArray<byte> MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E79560", Offset = "0x3E77F60", VA = "0x183E79560")]
		public void GLJLAONLPFJ(in COGGJKLIPPL MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2764500", Offset = "0x2762F00", VA = "0x182764500")]
		public void GLJLAONLPFJ<T>(T MAKFNMHIJIF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E79570", Offset = "0x3E77F70", VA = "0x183E79570")]
		private void LJJPFEFIAKJ(int MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E79640", Offset = "0x3E78040", VA = "0x183E79640")]
		private void LJJPFEFIAKJ(in COGGJKLIPPL MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E795E0", Offset = "0x3E77FE0", VA = "0x183E795E0")]
		private unsafe void LJJPFEFIAKJ(void* FLKLBGFLDPE, int JKABHKIANJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E79500", Offset = "0x3E77F00", VA = "0x183E79500")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E74F90", Offset = "0x3E73990", VA = "0x183E74F90")]
		internal FFBMDFNFEOK(FCHLEGPJOOJ ACLENHAHHHH, NativeArray<byte> JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E74DC0", Offset = "0x3E737C0", VA = "0x183E74DC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E74DD0", Offset = "0x3E737D0", VA = "0x183E74DD0")]
		public NativeArray<byte> ELDHGGNOKEN(int JKABHKIANJL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3E74CD0", Offset = "0x3E736D0", VA = "0x183E74CD0")]
		public NativeArray<byte> BHJECCKGPAO()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2762670", Offset = "0x2761070", VA = "0x182762670")]
		public T NAKEDDIGNIK<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3E74E90", Offset = "0x3E73890", VA = "0x183E74E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E75150", Offset = "0x3E73B50", VA = "0x183E75150", Slot = "4")]
			get
			{
				return default(KNMMJEOEOPK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x3E75110", Offset = "0x3E73B10", VA = "0x183E75110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2F88E10", Offset = "0x2F87810", VA = "0x182F88E10")]
		internal FFLHGLNJJJI(NativeList<KNMMJEOEOPK> EIAMEKHGGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3E74FD0", Offset = "0x3E739D0", VA = "0x183E74FD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3E750D0", Offset = "0x3E73AD0", VA = "0x183E750D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E786F0", Offset = "0x3E770F0", VA = "0x183E786F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int CLKAJICIIHF
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3E78670", Offset = "0x3E77070", VA = "0x183E78670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x3E78730", Offset = "0x3E77130", VA = "0x183E78730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public PDMNNKDAAOM OLOCEMLLNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3E786E0", Offset = "0x3E770E0", VA = "0x183E786E0")]
			get
			{
				return default(PDMNNKDAAOM);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x3E78680", Offset = "0x3E77080", VA = "0x183E78680")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool ODJOJHICMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3E78690", Offset = "0x3E77090", VA = "0x183E78690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x3E78650", Offset = "0x3E77050", VA = "0x183E78650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool FGFJBHJIBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x3E785B0", Offset = "0x3E76FB0", VA = "0x183E785B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x3E785C0", Offset = "0x3E76FC0", VA = "0x183E785C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3E78740", Offset = "0x3E77140", VA = "0x183E78740")]
		public KHEOBOKGMPC(PDMNNKDAAOM CBHAAIPJCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3E785E0", Offset = "0x3E76FE0", VA = "0x183E785E0")]
		private int DNJGGIFCOKL(int ADDILPEFEHP, int BNGJDOKIFFL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3E786A0", Offset = "0x3E770A0", VA = "0x183E786A0")]
		private void KMNEKDAGPNL(int ADDILPEFEHP, int MAKFNMHIJIF, int BNGJDOKIFFL = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3E78610", Offset = "0x3E77010", VA = "0x183E78610", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0EAF0", Offset = "0x2F0D4F0", VA = "0x182F0EAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ANLEMNFHGII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E380", Offset = "0x2F0CD80", VA = "0x182F0E380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CLKAJICIIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E900", Offset = "0x2F0D300", VA = "0x182F0E900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int CFKMIJKPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EF30", Offset = "0x2F0D930", VA = "0x182F0EF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0EC20", Offset = "0x2F0D620", VA = "0x182F0EC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E3F0", Offset = "0x2F0CDF0", VA = "0x182F0E3F0")]
	public static FCHLEGPJOOJ CBFHJGEFJHE(PDMNNKDAAOM CBHAAIPJCPO = PDMNNKDAAOM.Last, int ELJAOJKOMCF = 16, int BLLDKIFEENK = 256)
	{
		return default(FCHLEGPJOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F070", Offset = "0x2F0DA70", VA = "0x182F0F070")]
	private FCHLEGPJOOJ(PDMNNKDAAOM CBHAAIPJCPO, int ELJAOJKOMCF, int BLLDKIFEENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E660", Offset = "0x2F0D060", VA = "0x182F0E660", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EB00", Offset = "0x2F0D500", VA = "0x182F0EB00")]
	public LKHNNDCGJLC KHJHKCELOIP(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(LKHNNDCGJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EB90", Offset = "0x2F0D590", VA = "0x182F0EB90")]
	public FFBMDFNFEOK LNFOEOJBHOB(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(FFBMDFNFEOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EC60", Offset = "0x2F0D660", VA = "0x182F0EC60")]
	public bool NFPEFJHNBGL(KNMMJEOEOPK CELBLIIOMDE, out FFBMDFNFEOK IFBGMBPKKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E3A0", Offset = "0x2F0CDA0", VA = "0x182F0E3A0")]
	public bool BOONJHGAGHB(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E830", Offset = "0x2F0D230", VA = "0x182F0E830")]
	public bool HCEELEGAAJP(KNMMJEOEOPK CELBLIIOMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E910", Offset = "0x2F0D310", VA = "0x182F0E910")]
	public void JJEFLMMGPIP(NativeList<byte> FJEDANIIFJL, MADKAIDKJMP HMHKKKAECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF30", Offset = "0x27BE930", VA = "0x1827BFF30")]
	public T IHBCBCAIMIC<T>(KNMMJEOEOPK CELBLIIOMDE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EE50", Offset = "0x2F0D850", VA = "0x182F0EE50")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E430", Offset = "0x2F0CE30", VA = "0x182F0E430")]
	public FFLHGLNJJJI CBILBBMABKJ()
	{
		return default(FFLHGLNJJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E470", Offset = "0x2F0CE70", VA = "0x182F0E470")]
	private void CKHBGDOGBCG(KNMMJEOEOPK CELBLIIOMDE, int LJECKBCMELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E740", Offset = "0x2F0D140", VA = "0x182F0E740")]
	private void FHDOHDMGJMO(int FPLOLBPBBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EA00", Offset = "0x2F0D400", VA = "0x182F0EA00")]
	private void KCPIAHOEHKC(KNMMJEOEOPK CELBLIIOMDE, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x27C00C0", Offset = "0x27BEAC0", VA = "0x1827C00C0")]
	private static T IHBCBCAIMIC<T>(NativeArray<byte> HEONDDEAIBL, int ADDILPEFEHP = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EFB0", Offset = "0x2F0D9B0", VA = "0x182F0EFB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EF70", Offset = "0x2F0D970", VA = "0x182F0EF70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x431B380", Offset = "0x4319D80", VA = "0x18431B380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x431B4A0", Offset = "0x4319EA0", VA = "0x18431B4A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2864230", Offset = "0x2862C30", VA = "0x182864230")]
	public HNCHKDHGCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x258DD80", Offset = "0x258C780", VA = "0x18258DD80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC5100", Offset = "0x2BC3B00", VA = "0x182BC5100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC51A0", Offset = "0x2BC3BA0", VA = "0x182BC51A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B368B0", Offset = "0x2B352B0", VA = "0x182B368B0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2B36900", Offset = "0x2B35300", VA = "0x182B36900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2B36990", Offset = "0x2B35390", VA = "0x182B36990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public PBCPPGJFODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B39E30", Offset = "0x2B38830", VA = "0x182B39E30", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2B39E80", Offset = "0x2B38880", VA = "0x182B39E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public PNGEPBCJOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F06D60", Offset = "0x2F05760", VA = "0x182F06D60", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2F06DB0", Offset = "0x2F057B0", VA = "0x182F06DB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2F06E40", Offset = "0x2F05840", VA = "0x182F06E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCE7C0", Offset = "0x2BCD1C0", VA = "0x182BCE7C0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE750", Offset = "0x2BCD150", VA = "0x182BCE750")]
		public void EOKNBBAEDFA(global::NLPBCKKLMDB<OGGEFBPFCHD> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE2E0", Offset = "0x2BCCCE0", VA = "0x182BCE2E0")]
		public void ECEJGBDIPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE170", Offset = "0x2BCCB70", VA = "0x182BCE170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE860", Offset = "0x2BCD260", VA = "0x182BCE860")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B3DD10", Offset = "0x2B3C710", VA = "0x182B3DD10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x2B3DDB0", Offset = "0x2B3C7B0", VA = "0x182B3DDB0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E1E0", Offset = "0x2B3CBE0", VA = "0x182B3E1E0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE50", Offset = "0x2B3C850", VA = "0x182B3DE50", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E080", Offset = "0x2B3CA80", VA = "0x182B3E080", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E110", Offset = "0x2B3CB10", VA = "0x182B3E110", Slot = "8")]
		public bool KFBPIKEMCNP(NIALADIPDNC KLCGNDEDAPD, out Collider BKPBAEGGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E300", Offset = "0x2B3CD00", VA = "0x182B3E300")]
		private void NNKNEKICLGD(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DFC0", Offset = "0x2B3C9C0", VA = "0x182B3DFC0", Slot = "9")]
		public void DGIAHJOJINH(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B46620", Offset = "0x2B45020", VA = "0x182B46620")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45C90", Offset = "0x2B44690", VA = "0x182B45C90", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FD0", Offset = "0x2B429D0", VA = "0x182B43FD0", Slot = "6")]
		public IAEKLBCNHIG DLPKGCFNLFI(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2B45720", Offset = "0x2B44120", VA = "0x182B45720", Slot = "5")]
		public void LALJHKFAMEL(NIALADIPDNC KLCGNDEDAPD, IAEKLBCNHIG MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2B43640", Offset = "0x2B42040", VA = "0x182B43640", Slot = "34")]
		public CollisionDetectionMode AJNFIHLIDIP(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2B461A0", Offset = "0x2B44BA0", VA = "0x182B461A0", Slot = "35")]
		public void OENKJBLGKDB(NIALADIPDNC KLCGNDEDAPD, CollisionDetectionMode MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2B467A0", Offset = "0x2B451A0", VA = "0x182B467A0", Slot = "36")]
		public CKHEJONCKGK POAIBGFFFKK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(CKHEJONCKGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2B46010", Offset = "0x2B44A10", VA = "0x182B46010", Slot = "37")]
		public void NMEGEAIJCMG(NIALADIPDNC KLCGNDEDAPD, CKHEJONCKGK MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2B449C0", Offset = "0x2B433C0", VA = "0x182B449C0", Slot = "38")]
		public bool IBHKBPDCGAN(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2B436A0", Offset = "0x2B420A0", VA = "0x182B436A0", Slot = "39")]
		public void ALAEBGCDJHO(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2B45210", Offset = "0x2B43C10", VA = "0x182B45210", Slot = "40")]
		public NIALADIPDNC KCDNPIAEBEL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2B46720", Offset = "0x2B45120", VA = "0x182B46720", Slot = "41")]
		public void PKKLCJELFEI(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2B45B80", Offset = "0x2B44580", VA = "0x182B45B80", Slot = "42")]
		public NIALADIPDNC NCMHOFMDGAH(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2B462F0", Offset = "0x2B44CF0", VA = "0x182B462F0", Slot = "43")]
		public void OGODNIIEFFB(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2B46510", Offset = "0x2B44F10", VA = "0x182B46510", Slot = "7")]
		public void OPJJCFHECII(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2B438A0", Offset = "0x2B422A0", VA = "0x182B438A0", Slot = "8")]
		public void APJHAKKKPLO(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x2B45030", Offset = "0x2B43A30", VA = "0x182B45030", Slot = "9")]
		public int JGMHFKDKOJL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2B43710", Offset = "0x2B42110", VA = "0x182B43710", Slot = "10")]
		public NIALADIPDNC ALAEJPDKHIN(NIALADIPDNC KLCGNDEDAPD, int EBBLFLFCHFB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2B43400", Offset = "0x2B41E00", VA = "0x182B43400", Slot = "11")]
		public void AAFJDBGBNLK(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2B44D30", Offset = "0x2B43730", VA = "0x182B44D30", Slot = "12")]
		public void ILOEHODJFLD(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB, NIALADIPDNC MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2B44410", Offset = "0x2B42E10", VA = "0x182B44410", Slot = "13")]
		public void EMIILCGJJLB(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2B44060", Offset = "0x2B42A60", VA = "0x182B44060", Slot = "14")]
		public bool EBEMABAEMMB(NIALADIPDNC KLCGNDEDAPD, out NIALADIPDNC MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2B46370", Offset = "0x2B44D70", VA = "0x182B46370", Slot = "15")]
		public void OHODHFDLDKK(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2B45EB0", Offset = "0x2B448B0", VA = "0x182B45EB0", Slot = "16")]
		public bool NLFOHIKDCFF(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2B43560", Offset = "0x2B41F60", VA = "0x182B43560", Slot = "17")]
		public void AIPEBLNKKIJ(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2B447E0", Offset = "0x2B431E0", VA = "0x182B447E0", Slot = "18")]
		public bool HHIOGDKIPIB(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2B43D20", Offset = "0x2B42720", VA = "0x182B43D20", Slot = "26")]
		public float3 CMMECPNHHJF(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2B441C0", Offset = "0x2B42BC0", VA = "0x182B441C0", Slot = "27")]
		public void EDLHINCKBGC(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2B45500", Offset = "0x2B43F00", VA = "0x182B45500", Slot = "28")]
		public float KLFNJBEEHJL(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45D40", Offset = "0x2B44740", VA = "0x182B45D40", Slot = "29")]
		public void NFOOMMJHALN(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2B44780", Offset = "0x2B43180", VA = "0x182B44780", Slot = "30")]
		public float GLOIMGGMOKJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B45DB0", Offset = "0x2B447B0", VA = "0x182B45DB0", Slot = "31")]
		public void NGBNHFHHKHB(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2B435E0", Offset = "0x2B41FE0", VA = "0x182B435E0", Slot = "32")]
		public bool AJHEOPOFLAD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2B44530", Offset = "0x2B42F30", VA = "0x182B44530", Slot = "33")]
		public void EPHFHGIMMMB(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2B44940", Offset = "0x2B43340", VA = "0x182B44940", Slot = "19")]
		public void HHNIHLEEOIE(NIALADIPDNC KLCGNDEDAPD, float3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2B44240", Offset = "0x2B42C40", VA = "0x182B44240", Slot = "20")]
		public bool EFCOGJPGGCO(NIALADIPDNC KLCGNDEDAPD, out float3 MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2B43DA0", Offset = "0x2B427A0", VA = "0x182B43DA0", Slot = "21")]
		public void CPINEKECPJJ(NIALADIPDNC KLCGNDEDAPD, quaternion MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2B455C0", Offset = "0x2B43FC0", VA = "0x182B455C0", Slot = "22")]
		public bool KPOFMJIAOEH(NIALADIPDNC KLCGNDEDAPD, out quaternion MAKFNMHIJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2B45290", Offset = "0x2B43C90", VA = "0x182B45290", Slot = "23")]
		public bool KKJIIKFKKNP(NIALADIPDNC KLCGNDEDAPD, out float3 CGEGKNKGPFM, out quaternion LGNJCDPNHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2B445A0", Offset = "0x2B42FA0", VA = "0x182B445A0", Slot = "44")]
		public MGONBPIMIEF FKHPGAAJCCO(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(MGONBPIMIEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2B43830", Offset = "0x2B42230", VA = "0x182B43830", Slot = "45")]
		public void ALGOJFGCEFD(NIALADIPDNC KLCGNDEDAPD, MGONBPIMIEF MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2B45AF0", Offset = "0x2B444F0", VA = "0x182B45AF0", Slot = "72")]
		public void NBBDGJBDGID(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2B43B10", Offset = "0x2B42510", VA = "0x182B43B10", Slot = "73")]
		public void BPICDIFEHOD(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2B43BA0", Offset = "0x2B425A0", VA = "0x182B43BA0", Slot = "74")]
		public bool CBHGKKIFLPD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2B444A0", Offset = "0x2B42EA0", VA = "0x182B444A0", Slot = "81")]
		public void ENFKGGCFLID(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45E20", Offset = "0x2B44820", VA = "0x182B45E20", Slot = "82")]
		public void NJDBCKJHEAN(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2B46270", Offset = "0x2B44C70", VA = "0x182B46270", Slot = "83")]
		public bool OFMOMHPPBEE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2B43C20", Offset = "0x2B42620", VA = "0x182B43C20", Slot = "84")]
		public IEnumerable<object> CKJHDKFAHKP(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2B464B0", Offset = "0x2B44EB0", VA = "0x182B464B0", Slot = "46")]
		public bool OKPNADILIBC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45560", Offset = "0x2B43F60", VA = "0x182B45560", Slot = "47")]
		public void KOBPOPOIBAK(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2B45C30", Offset = "0x2B44630", VA = "0x182B45C30", Slot = "48")]
		public bool NDAPKANPJCK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E60", Offset = "0x2B43860", VA = "0x182B44E60", Slot = "49")]
		public void IOOACNLNGJF(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2B46140", Offset = "0x2B44B40", VA = "0x182B46140", Slot = "50")]
		public bool OALDGAPFJHJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2B466B0", Offset = "0x2B450B0", VA = "0x182B466B0", Slot = "51")]
		public void PHCPOHODIFC(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2B46210", Offset = "0x2B44C10", VA = "0x182B46210", Slot = "52")]
		public RigidbodyConstraints OFGKHJLCPOI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2B45980", Offset = "0x2B44380", VA = "0x182B45980", Slot = "53")]
		public void LOKHKOHJMHL(NIALADIPDNC KLCGNDEDAPD, RigidbodyConstraints MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2B463F0", Offset = "0x2B44DF0", VA = "0x182B463F0", Slot = "54")]
		public float OICAFAFKOCE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2B443A0", Offset = "0x2B42DA0", VA = "0x182B443A0", Slot = "55")]
		public void ELDJCOLGGCL(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2B43E10", Offset = "0x2B42810", VA = "0x182B43E10", Slot = "56")]
		public float DHAEDBKIGML(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2B45910", Offset = "0x2B44310", VA = "0x182B45910", Slot = "57")]
		public void LJKNPGBGMKD(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2B46450", Offset = "0x2B44E50", VA = "0x182B46450", Slot = "58")]
		public bool OJNALKDCGEI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2B434F0", Offset = "0x2B41EF0", VA = "0x182B434F0", Slot = "59")]
		public void AAGKDHNINMK(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2B446B0", Offset = "0x2B430B0", VA = "0x182B446B0", Slot = "60")]
		public bool GCMAJPIFLBC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2B46640", Offset = "0x2B45040", VA = "0x182B46640", Slot = "61")]
		public void PGECINJGFMD(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2B45830", Offset = "0x2B44230", VA = "0x182B45830", Slot = "62")]
		public int LHDCPDDNNKB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45A80", Offset = "0x2B44480", VA = "0x182B45A80", Slot = "63")]
		public void MNJGLBDCIPF(NIALADIPDNC KLCGNDEDAPD, int MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2B44FA0", Offset = "0x2B439A0", VA = "0x182B44FA0", Slot = "64")]
		public Rigidbody JAAOBHBLKKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2B439B0", Offset = "0x2B423B0", VA = "0x182B439B0", Slot = "65")]
		public void BFHMBJJGBCK(NIALADIPDNC KLCGNDEDAPD, Rigidbody MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2B44A20", Offset = "0x2B43420", VA = "0x182B44A20", Slot = "75")]
		public void IHCEABBGJNA(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2B44B40", Offset = "0x2B43540", VA = "0x182B44B40", Slot = "76")]
		public void IKAPLFMFBGG(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2B44630", Offset = "0x2B43030", VA = "0x182B44630", Slot = "77")]
		public bool FNNKALCPKLJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2B460B0", Offset = "0x2B44AB0", VA = "0x182B460B0", Slot = "66")]
		public object NOCGIAAKMMF(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2B43E70", Offset = "0x2B42870", VA = "0x182B43E70", Slot = "67")]
		public void DHJPGIOHBFO(NIALADIPDNC KLCGNDEDAPD, object MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2B459F0", Offset = "0x2B443F0", VA = "0x182B459F0", Slot = "68")]
		public object MIPNGEKNJMJ(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2B44BD0", Offset = "0x2B435D0", VA = "0x182B44BD0", Slot = "69")]
		public void IKCBPIHMJEJ(NIALADIPDNC KLCGNDEDAPD, object MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2B457D0", Offset = "0x2B441D0", VA = "0x182B457D0", Slot = "70")]
		public float LBAEENMICGI(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2B44710", Offset = "0x2B43110", VA = "0x182B44710", Slot = "71")]
		public void GKNBMLJEJOF(NIALADIPDNC KLCGNDEDAPD, float MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45180", Offset = "0x2B43B80", VA = "0x182B45180", Slot = "78")]
		public void JMMEKLBPKCK(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2B44AB0", Offset = "0x2B434B0", VA = "0x182B44AB0", Slot = "79")]
		public void IJNFOLLCMCI(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2B45890", Offset = "0x2B44290", VA = "0x182B45890", Slot = "80")]
		public bool LJABEMCEPMC(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46840", Offset = "0x2B45240", VA = "0x182B46840", Slot = "24")]
		public void PPMHJKGACBG(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45120", Offset = "0x2B43B20", VA = "0x182B45120", Slot = "25")]
		public void JIJOKELMPFC(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD460", Offset = "0x3DCBE60", VA = "0x183DCD460")]
		private void MOIAJHLONAA<T>(NIALADIPDNC KLCGNDEDAPD, bool MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCFB0", Offset = "0x3DCB9B0", VA = "0x183DCCFB0")]
		private bool LFIKBHCLHHI<T>(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC760", Offset = "0x3DCB160", VA = "0x183DCC760")]
		private void EMIFMEAGDDE<T>(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCE30", Offset = "0x3DCB830", VA = "0x183DCCE30")]
		private bool KOMMMKEDIDP<TC, TV>(NIALADIPDNC KLCGNDEDAPD, Func<TC, TV> PLKNOODMMGB, out TV MAKFNMHIJIF) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBFD0", Offset = "0x3DCA9D0", VA = "0x183DCBFD0")]
		private bool KOMMMKEDIDP<T>(NIALADIPDNC KLCGNDEDAPD, out T MAKFNMHIJIF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD010", Offset = "0x3DCBA10", VA = "0x183DCD010")]
		private T MIDJFBJDPMP<T>(NIALADIPDNC KLCGNDEDAPD) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC7C0", Offset = "0x3DCB1C0", VA = "0x183DCC7C0")]
		private void FKBMLKPEFCI<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC100", Offset = "0x3DCAB00", VA = "0x183DCC100")]
		private void BEBIMCHEGFI<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBFD0", Offset = "0x3DCA9D0", VA = "0x183DCBFD0")]
		private bool NMIJJIHBLBF<T>(NIALADIPDNC KLCGNDEDAPD, out T MAKFNMHIJIF) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCD10", Offset = "0x3DCB710", VA = "0x183DCCD10")]
		private T JFMJGABCIND<T>(NIALADIPDNC KLCGNDEDAPD) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBFD0", Offset = "0x3DCA9D0", VA = "0x183DCBFD0")]
		private void AEPCPIJAJHL<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC050", Offset = "0x3DCAA50", VA = "0x183DCC050")]
		private void ANLGLGJOOAA<T>(NIALADIPDNC KLCGNDEDAPD, T MAKFNMHIJIF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2B44600", Offset = "0x2B43000", VA = "0x182B44600")]
		private NIALADIPDNC FLPHBJACNKB(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2B44ED0", Offset = "0x2B438D0", VA = "0x182B44ED0")]
		private DynamicBuffer<Entity> IPHGFBAPLOK(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCD70", Offset = "0x3DCB770", VA = "0x183DCCD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public OPOENODHDPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C600", Offset = "0x3E7B000", VA = "0x183E7C600", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C2C0", Offset = "0x3E7ACC0", VA = "0x183E7C2C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C680", Offset = "0x3E7B080", VA = "0x183E7C680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C5C0", Offset = "0x3E7AFC0", VA = "0x183E7C5C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C510", Offset = "0x3E7AF10", VA = "0x183E7C510", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IAEKLBCNHIG> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C510", Offset = "0x3E7AF10", VA = "0x183E7C510", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F21AE0", Offset = "0x2F204E0", VA = "0x182F21AE0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F21200", Offset = "0x2F1FC00", VA = "0x182F21200")]
		public void EOKNBBAEDFA(NativeArray<Entity> IJBCECFNJIL, bool OKCPLEPCJGC, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2F20FF0", Offset = "0x2F1F9F0", VA = "0x182F20FF0")]
		public void ECEJGBDIPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F21320", Offset = "0x2F1FD20", VA = "0x182F21320")]
		private void FBFMNKIPGOD(NativeArray<Entity> IJBCECFNJIL, bool OKCPLEPCJGC, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F20E10", Offset = "0x2F1F810", VA = "0x182F20E10")]
		[IteratorStateMachine(typeof(OPOENODHDPD))]
		private IEnumerable<IAEKLBCNHIG> CKKBBDHNMKI(NativeArray<Entity> IJBCECFNJIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F20EA0", Offset = "0x2F1F8A0", VA = "0x182F20EA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F21B80", Offset = "0x2F20580", VA = "0x182F21B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F142C0", Offset = "0x2F12CC0", VA = "0x182F142C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DHPNCKOALMM EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F13E70", Offset = "0x2F12870", VA = "0x182F13E70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DHPNCKOALMM EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F13E70", Offset = "0x2F12870", VA = "0x182F13E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F14270", Offset = "0x2F12C70", VA = "0x182F14270", Slot = "11")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F142E0", Offset = "0x2F12CE0", VA = "0x182F142E0", Slot = "12")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F13A90", Offset = "0x2F12490", VA = "0x182F13A90")]
	private void ABEKKMLAJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1587400", Offset = "0x1585E00", VA = "0x181587400")]
	private string GBFKMANADIH(string NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F13D90", Offset = "0x2F12790", VA = "0x182F13D90", Slot = "7")]
	public DHPNCKOALMM EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F13E90", Offset = "0x2F12890", VA = "0x182F13E90")]
	private bool GNBNOIDOCMI(Type BMNJCJDHIKF, string NBODBMLPNJA, out DHPNCKOALMM MEIAOCKHKHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F14160", Offset = "0x2F12B60", VA = "0x182F14160", Slot = "8")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F14140", Offset = "0x2F12B40", VA = "0x182F14140", Slot = "9")]
	public IEnumerator<DHPNCKOALMM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F14140", Offset = "0x2F12B40", VA = "0x182F14140", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F14360", Offset = "0x2F12D60", VA = "0x182F14360")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3B1B0", Offset = "0x2B39BB0", VA = "0x182B3B1B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B270", Offset = "0x2B39C70", VA = "0x182B3B270", Slot = "6")]
	public bool PBMLNKHCBFP(HDFAPEIIIAK CBBOJGIJLHN, out int JLMAIAGOBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B210", Offset = "0x2B39C10", VA = "0x182B3B210", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B1A0", Offset = "0x2B39BA0", VA = "0x182B3B1A0", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AF30", Offset = "0x2B39930", VA = "0x182B3AF30")]
	private void AFFDJHOHDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B2E0", Offset = "0x2B39CE0", VA = "0x182B3B2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F23280", Offset = "0x2F21C80", VA = "0x182F23280", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CKNEHODEDLN EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2F22E20", Offset = "0x2F21820", VA = "0x182F22E20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CKNEHODEDLN EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F22E20", Offset = "0x2F21820", VA = "0x182F22E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "10")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F23290", Offset = "0x2F21C90", VA = "0x182F23290", Slot = "11")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "12")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F22FA0", Offset = "0x2F219A0", VA = "0x182F22FA0", Slot = "6")]
	public CKNEHODEDLN EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F231B0", Offset = "0x2F21BB0", VA = "0x182F231B0", Slot = "7")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F230D0", Offset = "0x2F21AD0", VA = "0x182F230D0", Slot = "8")]
	public IEnumerator<CKNEHODEDLN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F23530", Offset = "0x2F21F30", VA = "0x182F23530", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BB11F0", Offset = "0x3BAFBF0", VA = "0x183BB11F0", Slot = "13")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F22E60", Offset = "0x2F21860", VA = "0x182F22E60", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public LJDIDJAEPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F22E20", Offset = "0x2F21820", VA = "0x182F22E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F122D0", Offset = "0x2F10CD0", VA = "0x182F122D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MIKODHFFJMF EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2F11BE0", Offset = "0x2F105E0", VA = "0x182F11BE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MIKODHFFJMF EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F11BE0", Offset = "0x2F105E0", VA = "0x182F11BE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F12320", Offset = "0x2F10D20", VA = "0x182F12320", Slot = "9")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F11BF0", Offset = "0x2F105F0", VA = "0x182F11BF0", Slot = "10")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F121F0", Offset = "0x2F10BF0", VA = "0x182F121F0")]
	private MIKODHFFJMF KGIIKCPNKBO(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F11EF0", Offset = "0x2F108F0", VA = "0x182F11EF0", Slot = "6")]
	public MIKODHFFJMF EPJNCDJOANB(DMNHKHOLGBO MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F12120", Offset = "0x2F10B20", VA = "0x182F12120", Slot = "14")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO MABBPMMEACO)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F12010", Offset = "0x2F10A10", VA = "0x182F12010", Slot = "7")]
	public IEnumerator<MIKODHFFJMF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F12010", Offset = "0x2F10A10", VA = "0x182F12010", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x27D5090", Offset = "0x27D3A90", VA = "0x1827D5090", Slot = "11")]
	public void AAMBELEGHKP<TKey, T>(global::IMEOCHFBNFN<TKey, T> LNOIPGJELOP, [Optional] object JOOJGLPIMBB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F11E50", Offset = "0x2F10850", VA = "0x182F11E50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public FPGKKPPBGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F11BE0", Offset = "0x2F105E0", VA = "0x182F11BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B278D0", Offset = "0x2B262D0", VA = "0x182B278D0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B27AD0", Offset = "0x2B264D0", VA = "0x182B27AD0")]
	private void PPEKFCDLGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x39D0610", Offset = "0x39CF010", VA = "0x1839D0610")]
	public T JFJJHICDBIL<T>() where T : LDCIHJCLMHG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B27800", Offset = "0x2B26200", VA = "0x182B27800")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B27730", Offset = "0x2B26130", VA = "0x182B27730")]
	public MIKODHFFJMF COKFMIALAJN(DMNHKHOLGBO NBODBMLPNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x39D0590", Offset = "0x39CEF90", VA = "0x1839D0590")]
	public global::JGPMEKBNBND<T> COKFMIALAJN<T>(DMNHKHOLGBO NBODBMLPNJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B27A00", Offset = "0x2B26400", VA = "0x182B27A00")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public NJNCDGKENIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class EODIOGHDCOK
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x254EEE0", Offset = "0x254D8E0", VA = "0x18254EEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1C880", Offset = "0x2F1B280", VA = "0x182F1C880", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C760", Offset = "0x2F1B160", VA = "0x182F1C760")]
	public void JBLOBEABNOF(COEEIJJLOPG FBIBIHJENAB, bool IKFCIOJBEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
		[DebuggerHidden]
		public MEPNJKDHKHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3E79FB0", Offset = "0x3E789B0", VA = "0x183E79FB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3E79C00", Offset = "0x3E78600", VA = "0x183E79C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A030", Offset = "0x3E78A30", VA = "0x183E7A030")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x3E79F70", Offset = "0x3E78970", VA = "0x183E79F70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3E79EE0", Offset = "0x3E788E0", VA = "0x183E79EE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3E79EE0", Offset = "0x3E788E0", VA = "0x183E79EE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F15B50", Offset = "0x2F14550", VA = "0x182F15B50", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2F149D0", Offset = "0x2F133D0", VA = "0x182F149D0", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2F14FD0", Offset = "0x2F139D0", VA = "0x182F14FD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2F149C0", Offset = "0x2F133C0", VA = "0x182F149C0")]
	private void BMCKBGPJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2F14BA0", Offset = "0x2F135A0", VA = "0x182F14BA0")]
	internal void DBHGOFAKPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2F154A0", Offset = "0x2F13EA0", VA = "0x182F154A0")]
	private void KOBELGLMGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2F153A0", Offset = "0x2F13DA0", VA = "0x182F153A0")]
	private void KEIEPMMBHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2F15350", Offset = "0x2F13D50", VA = "0x182F15350")]
	[IteratorStateMachine(typeof(MEPNJKDHKHH))]
	private IEnumerable<RRCustomPropTag> GAEOLBEMEAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2F15C70", Offset = "0x2F14670", VA = "0x182F15C70")]
	private void PKGNLBHNJPJ(NIALADIPDNC KLCGNDEDAPD, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2F15680", Offset = "0x2F14080", VA = "0x182F15680")]
	private void KOEBKPOFGOP(SerializableGuid GDIIAHJOKME, GameObject EHEABJNEALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2F157C0", Offset = "0x2F141C0", VA = "0x182F157C0")]
	private void MCBNKEJFPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2F15170", Offset = "0x2F13B70", VA = "0x182F15170")]
	private bool FBLPPDHMCOB(ALGPAJCFDGK OEMKNHEOBPA, Transform LFAIGCEGCPL, out GameObject PFOFOPEANHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2F15C20", Offset = "0x2F14620", VA = "0x182F15C20")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2F160F0", Offset = "0x2F14AF0", VA = "0x182F160F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2B43310", Offset = "0x2B41D10", VA = "0x182B43310")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1CEC0", Offset = "0x2F1B8C0", VA = "0x182F1CEC0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F22DB0", Offset = "0x2F217B0", VA = "0x182F22DB0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2F22D70", Offset = "0x2F21770", VA = "0x182F22D70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2F22D50", Offset = "0x2F21750", VA = "0x182F22D50")]
	private void AJNEIPBAHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2F22D20", Offset = "0x2F21720", VA = "0x182F22D20")]
	private void AALNCNODAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B261B0", Offset = "0x2B24BB0", VA = "0x182B261B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NIALADIPDNC BIJMJHHBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2B26710", Offset = "0x2B25110", VA = "0x182B26710", Slot = "9")]
		get
		{
			return default(NIALADIPDNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2B26190", Offset = "0x2B24B90", VA = "0x182B26190", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public INPNGJHLELG OBLCOCPFGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2B25810", Offset = "0x2B24210", VA = "0x182B25810", Slot = "11")]
		get
		{
			return default(INPNGJHLELG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2B26190", Offset = "0x2B24B90", VA = "0x182B26190", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public INPNGJHLELG IHNPJOODLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2B25F20", Offset = "0x2B24920", VA = "0x182B25F20", Slot = "13")]
		get
		{
			return default(INPNGJHLELG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint IKFFKFOINAI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2B263E0", Offset = "0x2B24DE0", VA = "0x182B263E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LNJOKNOCHHN GAAJOMGCPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2B26560", Offset = "0x2B24F60", VA = "0x182B26560", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2B25AD0", Offset = "0x2B244D0", VA = "0x182B25AD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26490", Offset = "0x2B24E90", VA = "0x182B26490", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2B25D80", Offset = "0x2B24780", VA = "0x182B25D80", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2B260E0", Offset = "0x2B24AE0", VA = "0x182B260E0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2B258D0", Offset = "0x2B242D0", VA = "0x182B258D0")]
	private void AGNPAKFLNLJ(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2B26600", Offset = "0x2B25000", VA = "0x182B26600", Slot = "14")]
	public NIALADIPDNC OJHGJIBAMMJ(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2B25FE0", Offset = "0x2B249E0", VA = "0x182B25FE0", Slot = "15")]
	public bool DNKFCLNJCJP(NIALADIPDNC EOECNBNBJEC, NIALADIPDNC FNIMMJACBON, out NIALADIPDNC JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2B267B0", Offset = "0x2B251B0", VA = "0x182B267B0", Slot = "16")]
	public void OLGMGBNAEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2B25B70", Offset = "0x2B24570", VA = "0x182B25B70", Slot = "17")]
	public void BFFEDKNADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2B25B90", Offset = "0x2B24590", VA = "0x182B25B90", Slot = "18")]
	public bool CECILCPDGGE(NIALADIPDNC BIPEBBMCHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2B26250", Offset = "0x2B24C50", VA = "0x182B26250")]
	private void LKJJDPAKFJC(NIALADIPDNC HLPLMDDPLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC20C0", Offset = "0x2BC0AC0", VA = "0x182BC20C0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2050", Offset = "0x2BC0A50", VA = "0x182BC2050", Slot = "5")]
	public void GDIDMLIHIAL(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x25E94F0", Offset = "0x25E7EF0", VA = "0x1825E94F0")]
	private void KMNEKDAGPNL<T>(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D34450", Offset = "0x2D32E50", VA = "0x182D34450", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2D343E0", Offset = "0x2D32DE0", VA = "0x182D343E0", Slot = "5")]
		public void LBLPDEBDJFH(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2D34370", Offset = "0x2D32D70", VA = "0x182D34370", Slot = "6")]
		public void FKMGHBKEIDH(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x25E94F0", Offset = "0x25E7EF0", VA = "0x1825E94F0")]
		private void KMNEKDAGPNL<T>(NIALADIPDNC EHLCJHMJBBP, bool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1CF50", Offset = "0x2F1B950", VA = "0x182F1CF50", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCBC210", Offset = "0xCBAC10", VA = "0x180CBC210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2D48B60", Offset = "0x2D47560", VA = "0x182D48B60", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG DDAOLJGIIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2D48570", Offset = "0x2D46F70", VA = "0x182D48570", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2D48CB0", Offset = "0x2D476B0", VA = "0x182D48CB0", Slot = "6")]
		public bool NMBDCHIJFJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2D485A0", Offset = "0x2D46FA0", VA = "0x182D485A0", Slot = "7")]
		public bool IBCIKLNJDPJ(IEnumerable<PDNLIBNBICJ> MGCNMCGEJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2D48610", Offset = "0x2D47010", VA = "0x182D48610", Slot = "5")]
		public ByteString MHOEBEHGBOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2D48AA0", Offset = "0x2D474A0", VA = "0x182D48AA0")]
		private void MMHIKBOAIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2D484A0", Offset = "0x2D46EA0", VA = "0x182D484A0")]
		private void APPJNFEPODN(JGONKIMCOJA GLKFPPDNABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2D490F0", Offset = "0x2D47AF0", VA = "0x182D490F0")]
		private void OMBAJNABOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2D48E10", Offset = "0x2D47810", VA = "0x182D48E10")]
		private void OJLLKNAAHKB(HEONIOFKGAF GLKFPPDNABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2D485C0", Offset = "0x2D46FC0", VA = "0x182D485C0", Slot = "8")]
		public void KPNGBGLCOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2D48AC0", Offset = "0x2D474C0", VA = "0x182D48AC0")]
		private JGONKIMCOJA NCHPJHBPJDP(EntityManager OPLEGACAFEB, EntityManager PCGCHIPEABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBDCB0", Offset = "0x2BBC6B0", VA = "0x182BBDCB0")]
	public GameObject BCAOCHCBGDH(KFKBMIIJOHI KCEOAINNEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDD80", Offset = "0x2BBC780", VA = "0x182BBDD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D3BDC0", Offset = "0x2D3A7C0", VA = "0x182D3BDC0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x2D3BD40", Offset = "0x2D3A740", VA = "0x182D3BD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DFOJLFKFLHF
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1A00", VA = "0x1806B3000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC730", Offset = "0x1ACB130", VA = "0x181ACC730", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BE30", Offset = "0x2D3A830", VA = "0x182D3BE30", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2D3BC80", Offset = "0x2D3A680", VA = "0x182D3BC80")]
		public void CGLJJCPGDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D37FD0", Offset = "0x2D369D0", VA = "0x182D37FD0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2D37E00", Offset = "0x2D36800", VA = "0x182D37E00", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2D37F30", Offset = "0x2D36930", VA = "0x182D37F30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2D38040", Offset = "0x2D36A40", VA = "0x182D38040")]
		private void PKPJEFIPNKC(Entity FLADPKIONGF, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F0A6C0", Offset = "0x2F090C0", VA = "0x182F0A6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private PDEALDMPPOP HPBKOFGDFGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x2F0A650", Offset = "0x2F09050", VA = "0x182F0A650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A710", Offset = "0x2F09110", VA = "0x182F0A710", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A6A0", Offset = "0x2F090A0", VA = "0x182F0A6A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public HLKBBENOBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3E771A0", Offset = "0x3E75BA0", VA = "0x183E771A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PGOGHAHBMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CBA0", Offset = "0x3E7B5A0", VA = "0x183E7CBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C84C0", Offset = "0x8C6EC0", VA = "0x1808C84C0", Slot = "4")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DAOJGNOGCID CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ACD0", Offset = "0x2B396D0", VA = "0x182B3ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AA70", Offset = "0x2B39470", VA = "0x182B3AA70", Slot = "5")]
	public void AMMIBONBLOJ(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AD20", Offset = "0x2B39720", VA = "0x182B3AD20", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AE50", Offset = "0x2B39850", VA = "0x182B3AE50", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AAC0", Offset = "0x2B394C0", VA = "0x182B3AAC0", Slot = "8")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2B3ABA0", Offset = "0x2B395A0", VA = "0x182B3ABA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x279E9E0", Offset = "0x279D3E0", VA = "0x18279E9E0")]
	private void DMDKCGBKKMK<T>(Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x369A6F0", Offset = "0x36990F0", VA = "0x18369A6F0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x369A750", Offset = "0x3699150", VA = "0x18369A750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x369A6C0", Offset = "0x36990C0", VA = "0x18369A6C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FB70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x31A25A0", Offset = "0x31A0FA0", VA = "0x1831A25A0")]
	public ECAGGMPGMNA(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK, bool JPIIMKIJCFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x369A280", Offset = "0x3698C80", VA = "0x18369A280", Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x369A2E0", Offset = "0x3698CE0", VA = "0x18369A2E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x369A310", Offset = "0x3698D10", VA = "0x18369A310", Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x369A370", Offset = "0x3698D70", VA = "0x18369A370", Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x369A480", Offset = "0x3698E80", VA = "0x18369A480", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x369A550", Offset = "0x3698F50", VA = "0x18369A550", Slot = "6")]
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x369A5B0", Offset = "0x3698FB0", VA = "0x18369A5B0", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x369A660", Offset = "0x3699060", VA = "0x18369A660", Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x369A630", Offset = "0x3699030", VA = "0x18369A630", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2585E60", Offset = "0x2584860", VA = "0x182585E60", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x31D6F10", Offset = "0x31D5910", VA = "0x1831D6F10", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x31D6F60", Offset = "0x31D5960", VA = "0x1831D6F60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x31D6ED0", Offset = "0x31D58D0", VA = "0x1831D6ED0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DEIPNMFGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696A20", VA = "0x180698020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2263460", Offset = "0x2261E60", VA = "0x182263460")]
	public FFCDMIIFCDI(Func<From, To> JNICKEKIKKP, Func<To, From> BGDBKLMEHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x31D6AE0", Offset = "0x31D54E0", VA = "0x1831D6AE0", Slot = "11")]
	public void Add(To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x31D6B20", Offset = "0x31D5520", VA = "0x1831D6B20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x31D6B60", Offset = "0x31D5560", VA = "0x1831D6B60", Slot = "13")]
	public bool Contains(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x31D6C20", Offset = "0x31D5620", VA = "0x1831D6C20", Slot = "14")]
	public void CopyTo(To[] HEONDDEAIBL, int EBNCDCCMBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x31D6CE0", Offset = "0x31D56E0", VA = "0x1831D6CE0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x31D6DA0", Offset = "0x31D57A0", VA = "0x1831D6DA0", Slot = "6")]
	public int IndexOf(To GIFJLGCAEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x31D6E10", Offset = "0x31D5810", VA = "0x1831D6E10", Slot = "7")]
	public void Insert(int EBBLFLFCHFB, To GIFJLGCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x31D6E90", Offset = "0x31D5890", VA = "0x1831D6E90", Slot = "15")]
	public bool Remove(To GIFJLGCAEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x31D6E50", Offset = "0x31D5850", VA = "0x1831D6E50", Slot = "8")]
	public void RemoveAt(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x24B28A0", Offset = "0x24B12A0", VA = "0x1824B28A0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public OHIIECPFMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C1C0", Offset = "0x3E7ABC0", VA = "0x183E7C1C0")]
		internal void <InitServices>b__1(GOJCOOFCPOI svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C220", Offset = "0x3E7AC20", VA = "0x183E7C220")]
		internal void <InitServices>b__2(GKFAMMKGENJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DEB0", Offset = "0x2F1C8B0", VA = "0x182F1DEB0")]
	public static void GKGBOMAKLPF(this DAOJGNOGCID KHDPJJEDHOA, PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2295410", Offset = "0x2293E10", VA = "0x182295410")]
	public static void DMDKCGBKKMK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2294DA0", Offset = "0x22937A0", VA = "0x182294DA0")]
	public static void AHHNIKIKLJK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x22950B0", Offset = "0x2293AB0", VA = "0x1822950B0")]
	public static void CCPIDMDBFCK<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2295260", Offset = "0x2293C60", VA = "0x182295260")]
	public static void CIOGKMMDEJM<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x2295540", Offset = "0x2293F40", VA = "0x182295540")]
	public static void GBINFPICIFL<T>(this DAOJGNOGCID KHDPJJEDHOA, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2294F40", Offset = "0x2293940", VA = "0x182294F40")]
	public static void AHHNIKIKLJK<T>(IEnumerable<ComponentSystemBase> FLDPOGAHGIJ, Action<T> LINLEPEJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2295480", Offset = "0x2293E80", VA = "0x182295480")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F11B90", Offset = "0x2F10590", VA = "0x182F11B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ANAPOMBEABG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5890", Offset = "0x2BD4290", VA = "0x182BD5890")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D36E80", Offset = "0x2D35880", VA = "0x182D36E80")]
		public static void FHBOKNJGNHA(this EGGANIJGBAJ GOCENLCAMDB, BDNNNEAGBLH NBBMMINMBNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D371C0", Offset = "0x2D35BC0", VA = "0x182D371C0")]
		public static void GJBFMOFALMC(this EGGANIJGBAJ GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D370B0", Offset = "0x2D35AB0", VA = "0x182D370B0")]
		public static void FHBOKNJGNHA(this EGGANIJGBAJ GOCENLCAMDB, [Optional] string[] OAFKPBHEEGG, [Optional] string[] HPPLDAEPAIB, [Optional] string[] MBEEDHCOGPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D36DD0", Offset = "0x2D357D0", VA = "0x182D36DD0")]
		public static void CBFECCIJPDH(this EGGANIJGBAJ GOCENLCAMDB, params string[] CNILCBCFBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D37480", Offset = "0x2D35E80", VA = "0x182D37480")]
		public static void OCPCCONLCEA(this EGGANIJGBAJ GOCENLCAMDB, params string[] CNILCBCFBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D36BD0", Offset = "0x2D355D0", VA = "0x182D36BD0")]
		private static string[] BNOEEKAHBEB(BDNNNEAGBLH NBBMMINMBNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D372C0", Offset = "0x2D35CC0", VA = "0x182D372C0")]
		private static bool JNCHCOOGHGL(BDNNNEAGBLH NBBMMINMBNH, out string[] LLICCDFNAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD0A60", Offset = "0x2BCF460", VA = "0x182BD0A60")]
	public DGAIADJPJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action AFEIMHDHKAG();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0A20", Offset = "0x2BCF420", VA = "0x182BD0A20")]
	public MethodInfo MMJKBBDIIJE(Action PBOHOIMMGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0870", Offset = "0x2BCF270", VA = "0x182BD0870", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F17840", Offset = "0x2F16240", VA = "0x182F17840", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KFJHNIEABJD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F178D0", Offset = "0x2F162D0", VA = "0x182F178D0")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE1D0", Offset = "0x2BBCBD0", VA = "0x182BBE1D0")]
	protected HHBNALMADFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class BEHGAILHHKM : DGAIADJPJMC
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE0B0", Offset = "0x2BBCAB0", VA = "0x182BBE0B0", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LPKMANFLOAE<T>() where T : EAGFMBINGCM;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE140", Offset = "0x2BBCB40", VA = "0x182BBE140")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE1D0", Offset = "0x2BBCBD0", VA = "0x182BBE1D0")]
	protected BEHGAILHHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class BNBMEJNGAHN : DGAIADJPJMC
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEDA0", Offset = "0x2BBD7A0", VA = "0x182BBEDA0", Slot = "5")]
	public override Action AFEIMHDHKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void OIENDPGOGLJ<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEE30", Offset = "0x2BBD830", VA = "0x182BBEE30")]
	[Preserve]
	public void PEILNJEDEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE1D0", Offset = "0x2BBCBD0", VA = "0x182BBE1D0")]
	protected BNBMEJNGAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LFNJHBPNCFP
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F22880", Offset = "0x2F21280", VA = "0x182F22880")]
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
				[Cpp2IlInjected.Address(RVA = "0x2192790", Offset = "0x2191190", VA = "0x182192790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E77BE0", Offset = "0x3E765E0", VA = "0x183E77BE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x3E75800", Offset = "0x3E74200", VA = "0x183E75800")]
			[DebuggerHidden]
			public JDHMCBIDJBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x3E77A10", Offset = "0x3E76410", VA = "0x183E77A10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x3E77BA0", Offset = "0x3E765A0", VA = "0x183E77BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3E77AF0", Offset = "0x3E764F0", VA = "0x183E77AF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3E77AF0", Offset = "0x3E764F0", VA = "0x183E77AF0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2192790", Offset = "0x2191190", VA = "0x182192790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E756D0", Offset = "0x3E740D0", VA = "0x183E756D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3E75800", Offset = "0x3E74200", VA = "0x183E75800")]
			[DebuggerHidden]
			public FIMGPICPCCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3E75720", Offset = "0x3E74120", VA = "0x183E75720", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x3E753F0", Offset = "0x3E73DF0", VA = "0x183E753F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x3E757B0", Offset = "0x3E741B0", VA = "0x183E757B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x3E75690", Offset = "0x3E74090", VA = "0x183E75690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x3E755E0", Offset = "0x3E73FE0", VA = "0x183E755E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x3E755E0", Offset = "0x3E73FE0", VA = "0x183E755E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2192790", Offset = "0x2191190", VA = "0x182192790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E76EC0", Offset = "0x3E758C0", VA = "0x183E76EC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x3E75800", Offset = "0x3E74200", VA = "0x183E75800")]
			[DebuggerHidden]
			public HFCPMNNCMLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x3E76F10", Offset = "0x3E75910", VA = "0x183E76F10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x3E76AB0", Offset = "0x3E754B0", VA = "0x183E76AB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x3E76FE0", Offset = "0x3E759E0", VA = "0x183E76FE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x3E77030", Offset = "0x3E75A30", VA = "0x183E77030")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x3E76E80", Offset = "0x3E75880", VA = "0x183E76E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x3E76DE0", Offset = "0x3E757E0", VA = "0x183E76DE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x3E76DE0", Offset = "0x3E757E0", VA = "0x183E76DE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D220", Offset = "0x2F0BC20", VA = "0x182F0D220")]
		public static Entity ENNBBFIPAAI(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E1B0", Offset = "0x2F0CBB0", VA = "0x182F0E1B0")]
		public static DynamicBuffer<ChildrenData> PHOJADHLOEG(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DEA0", Offset = "0x2F0C8A0", VA = "0x182F0DEA0")]
		public static DynamicBuffer<ChildrenData> NCEBDJBCAOA(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D290", Offset = "0x2F0BC90", VA = "0x182F0D290")]
		public static NativeArray<Entity> FFMKKHKIFMM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DF30", Offset = "0x2F0C930", VA = "0x182F0DF30")]
		public static bool NIHNKEFEPIA(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Allocator GGLOKAHPEPM, out NativeArray<Entity> FCIOKFNCKIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D3C0", Offset = "0x2F0BDC0", VA = "0x182F0D3C0")]
		public static NativeArray<Entity> GGIOAFCBBAM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CAB0", Offset = "0x2F0B4B0", VA = "0x182F0CAB0")]
		public static Entity ALAEJPDKHIN(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D8D0", Offset = "0x2F0C2D0", VA = "0x182F0D8D0")]
		public static int JGMHFKDKOJL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CBE0", Offset = "0x2F0B5E0", VA = "0x182F0CBE0")]
		public static void BEBNKDLABJP(NativeArray<Entity> AKGGBDCLIGD, NativeArray<Entity> PAHCBODMCHK, EntityManager LNPEGOPJJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D170", Offset = "0x2F0BB70", VA = "0x182F0D170")]
		public static int EEJEBBJAJCK(this EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DCC0", Offset = "0x2F0C6C0", VA = "0x182F0DCC0")]
		public static bool LLHMMIJNOKL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity EGGHGELDMAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D7C0", Offset = "0x2F0C1C0", VA = "0x182F0D7C0")]
		public static IEnumerable<Entity> IPMINALCKNM(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E240", Offset = "0x2F0CC40", VA = "0x182F0E240")]
		public static bool PKNAJOGAKAI(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity IMDKOHMGEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CF50", Offset = "0x2F0B950", VA = "0x182F0CF50")]
		public static bool DNJHMIGKLJO(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity EOECNBNBJEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D5B0", Offset = "0x2F0BFB0", VA = "0x182F0D5B0")]
		public static NativeList<Entity> IEFPHBPMHJN(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false, Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0E030", Offset = "0x2F0CA30", VA = "0x182F0E030")]
		public static IEnumerable<Entity> OPILOIOFOMC(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DAE0", Offset = "0x2F0C4E0", VA = "0x182F0DAE0")]
		public static Entity KCDNPIAEBEL(this EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CFD0", Offset = "0x2F0B9D0", VA = "0x182F0CFD0")]
		public static bool DNKFCLNJCJP(this EntityManager LNPEGOPJJGK, Entity EOECNBNBJEC, Entity FNIMMJACBON, out Entity JFHEPJJAOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CED0", Offset = "0x2F0B8D0", VA = "0x182F0CED0")]
		internal static void DLBLODCGEAA(EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D9E0", Offset = "0x2F0C3E0", VA = "0x182F0D9E0")]
		internal static void JNFCNFLJFMH(EntityManager LNPEGOPJJGK, Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D520", Offset = "0x2F0BF20", VA = "0x182F0D520")]
		[IteratorStateMachine(typeof(JDHMCBIDJBH))]
		private static IEnumerable<Entity> GHHGKCNHNOL(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CE40", Offset = "0x2F0B840", VA = "0x182F0CE40")]
		[IteratorStateMachine(typeof(FIMGPICPCCA))]
		private static IEnumerable<Entity> CAEKPACEOBI(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DE20", Offset = "0x2F0C820", VA = "0x182F0DE20")]
		[IteratorStateMachine(typeof(HFCPMNNCMLA))]
		private static IEnumerable<Entity> MMDPLCCIDPJ(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2F0DBE0", Offset = "0x2F0C5E0", VA = "0x182F0DBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public KMGAJCBNKGB KEPKLMOMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LEDNJPMFMJI CMJHCGAKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public KDGBBCMLLMM CABGMKCDNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public EOPMPEPMNDF DJPIGNBFNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CLJEHOFLHAA FPLKCFFBBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public OPAKLFEDMAA MLMCGKJNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BBGDLMHBFGH MHIMBKNCMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CPFCFGLKHDP FNJJAECIOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x68D760", Offset = "0x68C160", VA = "0x18068D760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public KBNPAGHEBHB IHEEMHLFMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6770B0", Offset = "0x675AB0", VA = "0x1806770B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GIHCPFBMAPF DICNKIMDLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C170", VA = "0x18068D770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LDMOCILFLPC EPOBBKNLLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x68D780", Offset = "0x68C180", VA = "0x18068D780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OHNIAMAPMFF PBMDILPDIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x68D700", Offset = "0x68C100", VA = "0x18068D700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MJFDNFOLGPA GLKPOKJAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x68D710", Offset = "0x68C110", VA = "0x18068D710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LAMNHLNDGKO BPLOKGOONKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x6B36D0", Offset = "0x6B20D0", VA = "0x1806B36D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OOFBFFNNIPK CPCPDBAFFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x67DD80", Offset = "0x67C780", VA = "0x18067DD80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public NOFMFNFCABJ MIMHEAODKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x67DE20", Offset = "0x67C820", VA = "0x18067DE20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public PPLBOFNBIPJ JHBHHNPLABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6B36A0", Offset = "0x6B20A0", VA = "0x1806B36A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PNINELHDCOE EFIOEIEIDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x68D720", Offset = "0x68C120", VA = "0x18068D720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public ALNELIOAEHM NKMKGOEEINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x68D730", Offset = "0x68C130", VA = "0x18068D730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PJCBAJNDEOE AOLKGNGHNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x68D750", Offset = "0x68C150", VA = "0x18068D750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public EHJNMOMNBNJ MMABDIGILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA0", Offset = "0x69C4A0", VA = "0x18069DAA0", Slot = "21")]
		get
		{
			return default(EHJNMOMNBNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EFA0", Offset = "0x2F1D9A0", VA = "0x182F1EFA0", Slot = "22")]
	public void AMMIBONBLOJ(PFKGIHKPIGG DDAOLJGIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA6E0", Offset = "0x1DC90E0", VA = "0x181DCA6E0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F290", Offset = "0x2F1DC90", VA = "0x182F1F290", Slot = "23")]
	public void GAAJOMGCPID(PFKGIHKPIGG DDAOLJGIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C190", VA = "0x18068D790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D2FF00", Offset = "0x2D2E900", VA = "0x182D2FF00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679C00", VA = "0x18067B200")]
		[DebuggerHidden]
		public IIGEGGLKJBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FD50", Offset = "0x2D2E750", VA = "0x182D2FD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FEC0", Offset = "0x2D2E8C0", VA = "0x182D2FEC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x719E10", VA = "0x18071B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int FMPENOLGNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x692C90", Offset = "0x691690", VA = "0x180692C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x71B320", Offset = "0x719D20", VA = "0x18071B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA2F0", Offset = "0x2BB8CF0", VA = "0x182BBA2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9E60", Offset = "0x2BB8860", VA = "0x182BB9E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAA70", Offset = "0x2BB9470", VA = "0x182BBAA70")]
	public ANJCGBDFFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAAF0", Offset = "0x2BB94F0", VA = "0x182BBAAF0")]
	public ANJCGBDFFEP(int OBNABJCFIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA720", Offset = "0x2BB9120", VA = "0x182BBA720")]
	public bool OCOPPDHLOLD(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9CE0", Offset = "0x2BB86E0", VA = "0x182BB9CE0")]
	public bool AOBMBBOELGH(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9DD0", Offset = "0x2BB87D0", VA = "0x182BB9DD0")]
	public bool BHHAMMMPKAB(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9E50", Offset = "0x2BB8850", VA = "0x182BB9E50")]
	public bool DEHMHJNDOKD(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA950", Offset = "0x2BB9350", VA = "0x182BBA950")]
	public void PHJEJOHIMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA630", Offset = "0x2BB9030", VA = "0x182BBA630")]
	public void OAFINNBIOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA400", Offset = "0x2BB8E00", VA = "0x182BBA400")]
	public void KMNEKDAGPNL(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA850", Offset = "0x2BB9250", VA = "0x182BBA850")]
	public void PGHHBKOCHPM(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA9E0", Offset = "0x2BB93E0", VA = "0x182BBA9E0")]
	public bool PLBNCIKFCHN(int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA010", Offset = "0x2BB8A10", VA = "0x182BBA010")]
	public void FFDPJHIJPBB(int ADDILPEFEHP, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA130", Offset = "0x2BB8B30", VA = "0x182BBA130")]
	public void GCEHDHPKJFH(int PHEBOHLEEKJ, int KCHHIMPOGLA, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA560", Offset = "0x2BB8F60", VA = "0x182BBA560")]
	public int MFMCNFFMIAP(int FPLNDBJJHMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA4F0", Offset = "0x2BB8EF0", VA = "0x182BBA4F0")]
	public int MFMCNFFMIAP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA800", Offset = "0x2BB9200", VA = "0x182BBA800")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA390", Offset = "0x2BB8D90", VA = "0x182BBA390", Slot = "4")]
	[IteratorStateMachine(typeof(IIGEGGLKJBL))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA390", Offset = "0x2BB8D90", VA = "0x182BBA390", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1563EC0", Offset = "0x15628C0", VA = "0x181563EC0")]
	public GAHGEMOFMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2A64FA0", Offset = "0x2A639A0", VA = "0x182A64FA0")]
	public GAHGEMOFMBF(global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2A648B0", Offset = "0x2A632B0", VA = "0x182A648B0", Slot = "11")]
	public override T FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2A64C50", Offset = "0x2A63650", VA = "0x182A64C50", Slot = "12")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, T MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class AMKGJAKJKII
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x19E4070", Offset = "0x19E2A70", VA = "0x1819E4070")]
	public static HDFAPEIIIAK KOEBKPOFGOP<T>(this MPPFNHNPBFD KECMGAIBBMH, global::AJFAFKBPGAH<T> NBODBMLPNJA, global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD) where T : struct
	{
		return default(HDFAPEIIIAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class NAJKGJOKCEO<T> : global::GAHGEMOFMBF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2395AB0", Offset = "0x23944B0", VA = "0x182395AB0")]
	public NAJKGJOKCEO(T MJBMGGEOKEA, T CGFBNEMNBGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class GFHMKIENFJL<T> : global::KCEDBLNOIMG<T> where T : struct, EAGFMBINGCM
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2A75560", Offset = "0x2A73F60", VA = "0x182A75560", Slot = "11")]
	public override T FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2A75600", Offset = "0x2A74000", VA = "0x182A75600", Slot = "12")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x1562240", Offset = "0x1560C40", VA = "0x181562240")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EB11B0", Offset = "0x1EAFBB0", VA = "0x181EB11B0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x1EAECA0", Offset = "0x1EAD6A0", VA = "0x181EAECA0", Slot = "8")]
	public override void FFFJLEEKFAK(PBIBIEGBJNI ACHCPHHHGBA, in MMINGLJLPAL BIPEBBMCHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB0810", Offset = "0x1EAF210", VA = "0x181EB0810", Slot = "9")]
	public override void HGEKGOKJCDE(PBIBIEGBJNI ACHCPHHHGBA, in COGGJKLIPPL CELBLIIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF6C0", Offset = "0x1EAE0C0", VA = "0x181EAF6C0", Slot = "10")]
	public override void HEIGEPEFDPE(PBIBIEGBJNI ACHCPHHHGBA, OBLHLJIIBJE GIBODALIGFC, object JOOJGLPIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x14A8070", Offset = "0x14A6A70", VA = "0x1814A8070")]
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
			[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
			public EKLMHDPAPNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x291A180", Offset = "0x2918B80", VA = "0x18291A180")]
			internal void <RegisterFixedString>b__0(PBIBIEGBJNI p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x291A490", Offset = "0x2918E90", VA = "0x18291A490")]
			internal T <RegisterFixedString>b__1(PBIBIEGBJNI p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3E77200", Offset = "0x3E75C00", VA = "0x183E77200")]
		public static void KJFBPHINCGB(KBKEFPAEKOK HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x27633E0", Offset = "0x2761DE0", VA = "0x1827633E0")]
		private static void LJOJFHNAOBP<T>(KBKEFPAEKOK HLCNJFHNKCM, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2763350", Offset = "0x2761D50", VA = "0x182763350")]
		private static void LJDILEGBMIE<T>(PBIBIEGBJNI GODDPHBMKAO, T HIGLPPEBKMI, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2762D00", Offset = "0x2761700", VA = "0x182762D00")]
		private static T CMPGEGHCGDF<T>(PBIBIEGBJNI GODDPHBMKAO, int CGFBNEMNBGA) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2764A80", Offset = "0x2763480", VA = "0x182764A80", Slot = "6")]
		public override void KFJHNIEABJD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AF70", Offset = "0x3E79970", VA = "0x183E7AF70")]
		public static void IDIBCAFNFON(KBKEFPAEKOK HLCNJFHNKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B020", Offset = "0x3E79A20", VA = "0x183E7B020")]
		public NDHKPLKIAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2B373E0", Offset = "0x2B35DE0", VA = "0x182B373E0")]
	public static void KOJBMHAKCCN(KBKEFPAEKOK HLCNJFHNKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x279D150", Offset = "0x279BB50", VA = "0x18279D150")]
	public static void AGCILKOHDFN<T>(KBKEFPAEKOK HLCNJFHNKCM, global::LMGKHNILJAI<T> LJAGGIBNJPB, global::IDGNLLEKOLE<T> OCPLBEBMNGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x279D1E0", Offset = "0x279BBE0", VA = "0x18279D1E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B980", Offset = "0x2F1A380", VA = "0x182F1B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766980", VA = "0x180767F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FB70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B030", Offset = "0x2F19A30", VA = "0x182F1B030")]
	public ICPDMGPMBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AF70", Offset = "0x2F19970", VA = "0x182F1AF70")]
	public ICPDMGPMBFO(Dictionary<HDFAPEIIIAK, DJICGFHHPAN> HLCNJFHNKCM, bool ONKJPFNEHEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ACD0", Offset = "0x2F196D0", VA = "0x182F1ACD0", Slot = "7")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AEA0", Offset = "0x2F198A0", VA = "0x182F1AEA0", Slot = "8")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AF20", Offset = "0x2F19920", VA = "0x182F1AF20", Slot = "9")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AC00", Offset = "0x2F19600", VA = "0x182F1AC00", Slot = "4")]
	public HDFAPEIIIAK KAMKGFPCENK(DMNHKHOLGBO NBODBMLPNJA)
	{
		return default(HDFAPEIIIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AD30", Offset = "0x2F19730", VA = "0x182F1AD30", Slot = "5")]
	public void KOEBKPOFGOP(HDFAPEIIIAK CBBOJGIJLHN, DJICGFHHPAN IOHHLKEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A830", Offset = "0x2F19230", VA = "0x182F1A830")]
	[Conditional("DEBUG_BUILD")]
	private void DEKFONDPGOO(HDFAPEIIIAK CBBOJGIJLHN, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A970", Offset = "0x2F19370", VA = "0x182F1A970", Slot = "6")]
	public bool DJEIEOEOGPA(HDFAPEIIIAK CBBOJGIJLHN, out DJICGFHHPAN IOHHLKEMCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AB20", Offset = "0x2F19520", VA = "0x182F1AB20", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1A00", VA = "0x1806B3000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D41B80", Offset = "0x2D40580", VA = "0x182D41B80")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D404C0", VA = "0x182D41AC0")]
		public TypeSerializerService(Dictionary<Type, DJICGFHHPAN> HLCNJFHNKCM, bool ONKJPFNEHEJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D418F0", Offset = "0x2D402F0", VA = "0x182D418F0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D41950", Offset = "0x2D40350", VA = "0x182D41950", Slot = "5")]
		public void KOEBKPOFGOP(Type MCLMFJEAHEC, DJICGFHHPAN IOHHLKEMCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D41730", Offset = "0x2D40130", VA = "0x182D41730", Slot = "6")]
		public bool DJEIEOEOGPA(Type MCLMFJEAHEC, out DJICGFHHPAN IOHHLKEMCKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D41810", Offset = "0x2D40210", VA = "0x182D41810", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B239B0", Offset = "0x2B223B0", VA = "0x182B239B0", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B23C00", Offset = "0x2B22600", VA = "0x182B23C00", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B23A00", Offset = "0x2B22400", VA = "0x182B23A00", Slot = "4")]
	public void KOEBKPOFGOP(HDFAPEIIIAK DPEKNLAIHMP, Type LBKEDMNOBKJ, BKEHBCJJAII FHJGMKKJIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B23940", Offset = "0x2B22340", VA = "0x182B23940", Slot = "5")]
	public bool ECEDBMAJBKL(HDFAPEIIIAK DPEKNLAIHMP, out BKEHBCJJAII FHJGMKKJIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B23A70", Offset = "0x2B22470", VA = "0x182B23A70")]
	[Conditional("DEBUG_BUILD")]
	private void MBKFKAGMDEF(HDFAPEIIIAK DPEKNLAIHMP, Type LBKEDMNOBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B23C60", Offset = "0x2B22660", VA = "0x182B23C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD35E0", Offset = "0x2BD1FE0", VA = "0x182BD35E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool DHMPGINIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x742540", Offset = "0x740F40", VA = "0x180742540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x96AC90", Offset = "0x969690", VA = "0x18096AC90", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD36E0", Offset = "0x2BD20E0", VA = "0x182BD36E0", Slot = "6")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3D50", Offset = "0x2BD2750", VA = "0x182BD3D50", Slot = "7")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3630", Offset = "0x2BD2030", VA = "0x182BD3630", Slot = "8")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3820", Offset = "0x2BD2220", VA = "0x182BD3820")]
	private void HFOMJKPIOGJ(NIALADIPDNC KLCGNDEDAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3C10", Offset = "0x2BD2610", VA = "0x182BD3C10", Slot = "4")]
	public bool JNCBJIFACNJ(COEEIJJLOPG FBIBIHJENAB, HDFAPEIIIAK LNOIPGJELOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BD38C0", Offset = "0x2BD22C0", VA = "0x182BD38C0", Slot = "5")]
	public void JIDNIABLPGK(COEEIJJLOPG FBIBIHJENAB, Span<HDFAPEIIIAK> KECMGAIBBMH, bool DAKGDGBCFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD36E0", Offset = "0x2BD20E0", VA = "0x182BD36E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3DD0", Offset = "0x2BD27D0", VA = "0x182BD3DD0")]
	public DOOEJMHKPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class ELNLJGFBCBB
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F08000", Offset = "0x2F06A00", VA = "0x182F08000")]
	public static void HKNPDKKGIDG(this PBIBIEGBJNI ACHCPHHHGBA, ReadOnlyMemory<byte> JLNOCAAFAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x254C420", Offset = "0x254AE20", VA = "0x18254C420")]
	public static void ILGFNCIGIKC<T>(this PBIBIEGBJNI ACHCPHHHGBA, in T MAKFNMHIJIF) where T : struct, EAGFMBINGCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x254C550", Offset = "0x254AF50", VA = "0x18254C550")]
	public static T KOHFLBNBAKA<T>(this PBIBIEGBJNI ACHCPHHHGBA) where T : struct, EAGFMBINGCM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F081A0", Offset = "0x2F06BA0", VA = "0x182F081A0")]
	public static void ILGFNCIGIKC(this PBIBIEGBJNI ACHCPHHHGBA, EFPCBBNPEJA OCIJCOOAIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F07E20", Offset = "0x2F06820", VA = "0x182F07E20")]
	public static EFPCBBNPEJA COPHGOPBOGK(this PBIBIEGBJNI ACHCPHHHGBA)
	{
		return default(EFPCBBNPEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F07E50", Offset = "0x2F06850", VA = "0x182F07E50")]
	public static void FJALIIAHOON(this PBIBIEGBJNI IEEJJNDPOHK, uint OFIFAJJCPOM, bool CNMIEEKMKKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F08080", Offset = "0x2F06A80", VA = "0x182F08080")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public HIBKNIEPIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F3ABF0", Offset = "0x3F395F0", VA = "0x183F3ABF0")]
		internal void <GetByteEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F3AC60", Offset = "0x3F39660", VA = "0x183F3AC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public PCCDFINJLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x40E8F90", Offset = "0x40E7990", VA = "0x1840E8F90")]
		internal void <GetSByteEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x40E9000", Offset = "0x40E7A00", VA = "0x1840E9000")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public EAMNBHDMCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x32A3FB0", Offset = "0x32A29B0", VA = "0x1832A3FB0")]
		internal void <GetShortEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x32A4020", Offset = "0x32A2A20", VA = "0x1832A4020")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public LCNHEAMHEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E26590", Offset = "0x1E24F90", VA = "0x181E26590")]
		internal void <GetUShortEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E26600", Offset = "0x1E25000", VA = "0x181E26600")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public IEKAILJPAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2796580", Offset = "0x2794F80", VA = "0x182796580")]
		internal void <GetIntEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x27965E0", Offset = "0x2794FE0", VA = "0x1827965E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public BFAHAGAOIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x45C5560", Offset = "0x45C3F60", VA = "0x1845C5560")]
		internal void <GetUIntEnumDelegates>b__0(PBIBIEGBJNI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x45C55C0", Offset = "0x45C3FC0", VA = "0x1845C55C0")]
		internal T <GetUIntEnumDelegates>b__1(PBIBIEGBJNI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x27C6E80", Offset = "0x27C5880", VA = "0x1827C6E80")]
	public static void KKCCEHODGOG<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x27C6A90", Offset = "0x27C5490", VA = "0x1827C6A90")]
	private static void BCAKEPLEAFC<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x27C6A90", Offset = "0x27C5490", VA = "0x1827C6A90")]
	private static void CJKCABOBDHE<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x27C6BE0", Offset = "0x27C55E0", VA = "0x1827C6BE0")]
	private static void BOEFFPNCILI<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x27C6BE0", Offset = "0x27C55E0", VA = "0x1827C6BE0")]
	private static void CHFIDGBIHPM<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x27C6D30", Offset = "0x27C5730", VA = "0x1827C6D30")]
	private static void JPPDODNEEBF<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x27C6D30", Offset = "0x27C5730", VA = "0x1827C6D30")]
	private static void GNJPHPIMHDC<T>(T MJBMGGEOKEA, T CGFBNEMNBGA, out global::LMGKHNILJAI<T> MFIBBCDCIAI, out global::IDGNLLEKOLE<T> HAFHAKKEECB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class PGEKFEGMJML : EKPBGJEDCGJ, GKFAMMKGENJ
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B37380", Offset = "0x2B35D80", VA = "0x182B37380", Slot = "4")]
	private void PDFHPPGKKGO(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DAOLMNILPOB(MPPFNHNPBFD KECMGAIBBMH);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	protected PGEKFEGMJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[AOABIAIICLA(typeof(LocalPoseData))]
public sealed class PEFMKJDPMAB : PGEKFEGMJML
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B37130", Offset = "0x2B35B30", VA = "0x182B37130", Slot = "5")]
	protected override void DAOLMNILPOB(MPPFNHNPBFD KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCB950", Offset = "0x2BCA350", VA = "0x182BCB950", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB9C0", Offset = "0x2BCA3C0", VA = "0x182BCB9C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBB40", Offset = "0x2BCA540", VA = "0x182BCBB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBB10", Offset = "0x2BCA510", VA = "0x182BCBB10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB400", Offset = "0x2BC9E00", VA = "0x182BCB400")]
		private void IPPKHIAIAFG(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCACF0", Offset = "0x2BC96F0", VA = "0x182BCACF0")]
		private void FCEADFGDAAK(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAE90", Offset = "0x2BC9890", VA = "0x182BCAE90")]
		private void GIDIAEAGDIP(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB250", Offset = "0x2BC9C50", VA = "0x182BCB250")]
		private void HJNCEEIOJEE(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB740", Offset = "0x2BCA140", VA = "0x182BCB740")]
		private void KKMGJECMABK(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB170", Offset = "0x2BC9B70", VA = "0x182BCB170")]
		private void HCNOPLDPFLM(NIALADIPDNC KLCGNDEDAPD, int NPMIJOEHCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1D9D0", Offset = "0x2F1C3D0", VA = "0x182F1D9D0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DA20", Offset = "0x2F1C420", VA = "0x182F1DA20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DAE0", Offset = "0x2F1C4E0", VA = "0x182F1DAE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D3F0", Offset = "0x2F1BDF0", VA = "0x182F1D3F0")]
	private void MAOANDBBNAO(NativeArray<Entity> IJBCECFNJIL, NativeList<Entity> PEGLPLKBCDI, ComponentDataFromEntity<GNKPBKJDEDC> NBLHJNLELMG, BufferFromEntity<ChildrenData> KCJJJGGDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public JHDMPEEDJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class IJDHPLINHIO : ParentSystemBase<AuthoredParentData, OAGDIIKIAEI, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B610", Offset = "0x2F1A010", VA = "0x182F1B610", Slot = "14")]
	protected override EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7210B0", VA = "0x1807226B0", Slot = "15")]
	protected override EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B690", Offset = "0x2F1A090", VA = "0x182F1B690", Slot = "16")]
	protected override EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B650", Offset = "0x2F1A050", VA = "0x182F1B650", Slot = "17")]
	protected override EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B710", Offset = "0x2F1A110", VA = "0x182F1B710")]
	public IJDHPLINHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B6D0", Offset = "0x2F1A0D0", VA = "0x182F1B6D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F22980", Offset = "0x2F21380", VA = "0x182F22980", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2F22A00", Offset = "0x2F21400", VA = "0x182F22A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2F22AA0", Offset = "0x2F214A0", VA = "0x182F22AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public LGCEFDJNIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B25470", Offset = "0x2B23E70", VA = "0x182B25470", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2B254F0", Offset = "0x2B23EF0", VA = "0x182B254F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2B25590", Offset = "0x2B23F90", VA = "0x182B25590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public MMHPBCMMDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F11100", Offset = "0x2F0FB00", VA = "0x182F11100", Slot = "4")]
	public bool Equals(JMGMKGGOCKH OANENNOJEBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
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
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static EHKAPCLDEFB DGKBAOBECFH(FJDOFGNFPLL ODMNDKFKJHN)
	{
		return default(EHKAPCLDEFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class BBOKDLJHKBF : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDA80", Offset = "0x2BBC480", VA = "0x182BBDA80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDC10", Offset = "0x2BBC610", VA = "0x182BBDC10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330")]
	protected BBOKDLJHKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F138F0", Offset = "0x2F122F0", VA = "0x182F138F0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2F133F0", Offset = "0x2F11DF0", VA = "0x182F133F0")]
	protected void JDDDLPCEGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x2F13670", Offset = "0x2F12070", VA = "0x182F13670")]
	protected void KNHGDJDEBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2F13380", Offset = "0x2F11D80", VA = "0x182F13380")]
	protected OKKOFBJCFMA BKKBIDPJMNE()
	{
		return default(OKKOFBJCFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	protected GCOOCIPHEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class DODBJDMKJMM : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2BD33B0", Offset = "0x2BD1DB0", VA = "0x182BD33B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3540", Offset = "0x2BD1F40", VA = "0x182BD3540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330")]
	protected DODBJDMKJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class NHLBFIGLPKI : GCOOCIPHEME
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2B27190", Offset = "0x2B25B90", VA = "0x182B27190", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x2B272A0", Offset = "0x2B25CA0", VA = "0x182B272A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330")]
	protected NHLBFIGLPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1CE50", Offset = "0x2F1B850", VA = "0x182F1CE50", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6CE0", Offset = "0x2BB56E0", VA = "0x182BB6CE0")]
	public JBMPGJMFCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1EF30", Offset = "0x2F1D930", VA = "0x182F1EF30", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6CE0", Offset = "0x2BB56E0", VA = "0x182BB6CE0")]
	public KHHLMNODHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B39DC0", Offset = "0x2B387C0", VA = "0x182B39DC0", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330")]
	public PMPEACMNAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBCC40", Offset = "0x2BBB640", VA = "0x182BBCC40", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330")]
	public BABAHODAHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F22040", Offset = "0x2F20A40", VA = "0x182F22040", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6CE0", Offset = "0x2BB56E0", VA = "0x182BB6CE0")]
	public LAMGADAHOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB6C70", Offset = "0x2BB5670", VA = "0x182BB6C70", Slot = "15")]
		get
		{
			return default(CNMBMIEJNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6CE0", Offset = "0x2BB56E0", VA = "0x182BB6CE0")]
	public AAIIACNJPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2B27330", Offset = "0x2B25D30", VA = "0x182B27330", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC3620", Offset = "0x2BC2020", VA = "0x182BC3620")]
	public CNMBMIEJNOJ(ComponentType GLAGKBEAACJ, ComponentType FCMEFMFMNGP, object HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5F10", Offset = "0x2DB4910", VA = "0x182DB5F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727790", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int HOBPJIMDIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4560", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xE8F640", Offset = "0xE8E040", VA = "0x180E8F640", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool DEHMHJNDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2F110C0", Offset = "0x2F0FAC0", VA = "0x182F110C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2F11100", Offset = "0x2F0FB00", VA = "0x182F11100", Slot = "8")]
	public bool Equals(FJDOFGNFPLL OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2F11150", Offset = "0x2F0FB50", VA = "0x182F11150", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7C2A0", Offset = "0x3E7ACA0", VA = "0x183E7C2A0")]
			public OJMJLDJJMBJ(FJDOFGNFPLL ODMNDKFKJHN, float3 EINGNKDKDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C280", Offset = "0x3E7AC80", VA = "0x183E7C280")]
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
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
			public OEDKAKBOMEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
			public ECPCHCBBNGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
			public DMHEGDICODD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E71880", Offset = "0x3E70280", VA = "0x183E71880")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x3E717C0", Offset = "0x3E701C0", VA = "0x183E717C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E72280", Offset = "0x3E70C80", VA = "0x183E72280")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, WorldPoseData EMJPNBNIJPK, in DynamicBuffer<EHKAPCLDEFB> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x3E72670", Offset = "0x3E71070", VA = "0x183E72670", Slot = "5")]
			public void ReadFromDisplayClass(ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x3E726A0", Offset = "0x3E710A0", VA = "0x183E726A0", Slot = "6")]
			public void WriteToDisplayClass(ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x3E72160", Offset = "0x3E70B60", VA = "0x183E72160", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x3E72530", Offset = "0x3E70F30", VA = "0x183E72530")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref AEECEPAILCF.OBMMHNACNCO GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x3E72240", Offset = "0x3E70C40", VA = "0x183E72240")]
			public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK, ref OEDKAKBOMEO IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x3E724C0", Offset = "0x3E70EC0", VA = "0x183E724C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E74C60", Offset = "0x3E73660", VA = "0x183E74C60")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x3E74BC0", Offset = "0x3E735C0", VA = "0x183E74BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E74740", Offset = "0x3E73140", VA = "0x183E74740")]
			internal void KFDLFOBMEJP(in WorldPoseData EMJPNBNIJPK, in DynamicBuffer<JMGMKGGOCKH> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2D2CE70", Offset = "0x2D2B870", VA = "0x182D2CE70", Slot = "5")]
			public void ReadFromDisplayClass(ref ECPCHCBBNGH IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x3E745D0", Offset = "0x3E72FD0", VA = "0x183E745D0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x3E74850", Offset = "0x3E73250", VA = "0x183E74850")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref FEIDDCFFHHN.LCKHAFEMDLK GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x3E746A0", Offset = "0x3E730A0", VA = "0x183E746A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E79030", Offset = "0x3E77A30", VA = "0x183E79030")]
				public void KBLGIFLFDKL(UpdateConnectableVisuals AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x3E78F60", Offset = "0x3E77960", VA = "0x183E78F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E74350", Offset = "0x3E72D50", VA = "0x183E74350")]
			internal void KFDLFOBMEJP(in WorldPoseData EMJPNBNIJPK, in JDMLIIAJBHN BNONCODMDPO, in DynamicBuffer<JMGMKGGOCKH> BLJBLMCPLPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x2D2CE70", Offset = "0x2D2B870", VA = "0x182D2CE70", Slot = "5")]
			public void ReadFromDisplayClass(ref DMHEGDICODD IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x3E74290", Offset = "0x3E72C90", VA = "0x183E74290", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x3E744B0", Offset = "0x3E72EB0", VA = "0x183E744B0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref LCJBAMDBBFB.BBPOJAHKHAO GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x3E74310", Offset = "0x3E72D10", VA = "0x183E74310")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D454B0", Offset = "0x2D43EB0", VA = "0x182D454B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2D42300", Offset = "0x2D40D00", VA = "0x182D42300")]
		internal NMHMDBFHOBL BBGEJKCNCBD(FJDOFGNFPLL ODMNDKFKJHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2D45630", Offset = "0x2D44030", VA = "0x182D45630", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2D460D0", Offset = "0x2D44AD0", VA = "0x182D460D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2D46350", Offset = "0x2D44D50", VA = "0x182D46350", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2D464E0", Offset = "0x2D44EE0", VA = "0x182D464E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2D46310", Offset = "0x2D44D10", VA = "0x182D46310", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2D42870", Offset = "0x2D41270", VA = "0x182D42870")]
		private void GGJJHAEALDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2D43240", Offset = "0x2D41C40", VA = "0x182D43240")]
		private void IODCJGHCABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2D43A40", Offset = "0x2D42440", VA = "0x182D43A40")]
		private void KANEKCNGPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2D46520", Offset = "0x2D44F20", VA = "0x182D46520", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2D449B0", Offset = "0x2D433B0", VA = "0x182D449B0")]
		private void LJKNPIDDPEM(EntityQuery BPJPGLJIBCD, EntityQuery JDEFICMNKIF, EntityQuery HDFADBKIHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D425E0", Offset = "0x2D40FE0", VA = "0x182D425E0")]
		private void EMIFMEAGDDE(EntityQuery HDFADBKIHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2D45C90", Offset = "0x2D44690", VA = "0x182D45C90")]
		private void OFNJKKFDHLO(global::AFMKKOBINHK<Entity> HHCMGOJAHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2D43DF0", Offset = "0x2D427F0", VA = "0x182D43DF0")]
		private void KLKFKFNDMMM(global::AFMKKOBINHK<Entity> GFAAIHHBGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2D433F0", Offset = "0x2D41DF0", VA = "0x182D433F0")]
		private void JJLIEKGCDDG(global::AFMKKOBINHK<Entity> LKNDNLGNPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2D42190", Offset = "0x2D40B90", VA = "0x182D42190")]
		private void ADNJCEKIHLJ(NativeList<FJDOFGNFPLL> KFJGBAPMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2D42AB0", Offset = "0x2D414B0", VA = "0x182D42AB0")]
		private NativeList<FJDOFGNFPLL> HNLADJLHPLB(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<FJDOFGNFPLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2D44E90", Offset = "0x2D43890", VA = "0x182D44E90")]
		private void MCKNNALHGEL(NativeArray<Entity> IJBCECFNJIL, NativeList<FJDOFGNFPLL> KFJGBAPMDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2D441F0", Offset = "0x2D42BF0", VA = "0x182D441F0")]
		private void LIEHABANGHJ(NativeArray<Entity> HPNEDIJFLCD, NativeArray<Entity> ANCBEEHDLED, NativeList<FJDOFGNFPLL> NHLDHGBMFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2D43590", Offset = "0x2D41F90", VA = "0x182D43590")]
		private void JLNAIGAFGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2D459C0", Offset = "0x2D443C0", VA = "0x182D459C0")]
		private global::NLPBCKKLMDB<OJMJLDJJMBJ> NJAABOLHILF(EntityQuery AMEIGJPGLKK, Func<NativeList<OJMJLDJJMBJ>, JobHandle> MJHMBIGHKDE)
		{
			return default(global::NLPBCKKLMDB<OJMJLDJJMBJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2D45B00", Offset = "0x2D44500", VA = "0x182D45B00")]
		private JobHandle NJPGOAFJOHF(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2D454F0", Offset = "0x2D43EF0", VA = "0x182D454F0")]
		private JobHandle MNBBMDDNENA(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2D42980", Offset = "0x2D41380", VA = "0x182D42980")]
		private JobHandle HKMBCOPAOPH(NativeList<OJMJLDJJMBJ> ACLENHAHHHH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2D42350", Offset = "0x2D40D50", VA = "0x182D42350")]
		private void BFGLKAKLDHI(global::NLPBCKKLMDB<OJMJLDJJMBJ> ACLENHAHHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2D44720", Offset = "0x2D43120", VA = "0x182D44720")]
		private void LIIHFPLMCMO(global::NLPBCKKLMDB<OJMJLDJJMBJ> ACLENHAHHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2D43390", Offset = "0x2D41D90", VA = "0x182D43390")]
		private bool JCIHEDDFDNB(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2D456F0", Offset = "0x2D440F0", VA = "0x182D456F0")]
		private NativeArray<Entity> NEAJEDJDNBN(Entity FLADPKIONGF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2D426B0", Offset = "0x2D410B0", VA = "0x182D426B0")]
		private FJDOFGNFPLL GDGNCDGBCJB(NativeList<FJDOFGNFPLL> NHLDHGBMFAK)
		{
			return default(FJDOFGNFPLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2D44160", Offset = "0x2D42B60", VA = "0x182D44160")]
		private void LHEHCMEOEKI(FJDOFGNFPLL ODMNDKFKJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2D45F70", Offset = "0x2D44970", VA = "0x182D45F70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2D457C0", Offset = "0x2D441C0", VA = "0x182D457C0")]
		public static EntityQuery NIOKCJOKAOM(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2D43F00", Offset = "0x2D42900", VA = "0x182D43F00")]
		public static EntityQuery KPDAIGBBPNA(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2D42FD0", Offset = "0x2D419D0", VA = "0x182D42FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B40010", Offset = "0x2B3EA10", VA = "0x182B40010", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF80", Offset = "0x2B3E980", VA = "0x182B3FF80", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B40110", Offset = "0x2B3EB10", VA = "0x182B40110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public LFFFJCCHELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
	public LFFFJCCHELC(GLICHKLIKDB NCAANBGOHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2F22810", Offset = "0x2F21210", VA = "0x182F22810", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28500", Offset = "0x2B26F00", VA = "0x182B28500", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x2B28560", Offset = "0x2B26F60", VA = "0x182B28560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2B28590", Offset = "0x2B26F90", VA = "0x182B28590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	protected NOHHJNLGKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B28E00", Offset = "0x2B27800", VA = "0x182B28E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int JKMNPHCFCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2B28C70", Offset = "0x2B27670", VA = "0x182B28C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2B28E10", Offset = "0x2B27810", VA = "0x182B28E10", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2B28ED0", Offset = "0x2B278D0", VA = "0x182B28ED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2B290D0", Offset = "0x2B27AD0", VA = "0x182B290D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B28C50", Offset = "0x2B27650", VA = "0x182B28C50")]
	public int DEIOFDOJNON(SceneTag FMEDCFLNIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B28E70", Offset = "0x2B27870", VA = "0x182B28E70")]
	public int NMPFPNGDBIL(SceneTag FMEDCFLNIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B28790", Offset = "0x2B27190", VA = "0x182B28790")]
	protected void ANKFCELGCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B28AD0", Offset = "0x2B274D0", VA = "0x182B28AD0")]
	protected void BLEGANKIHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B28C80", Offset = "0x2B27680", VA = "0x182B28C80")]
	public global::AFMKKOBINHK<Entity> KDGHICCCEGF(SceneTag FMEDCFLNIMM, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(global::AFMKKOBINHK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B28A80", Offset = "0x2B27480", VA = "0x182B28A80")]
	public global::AFMKKOBINHK<Entity> BGDDJCHGCEJ(SceneTag FMEDCFLNIMM, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(global::AFMKKOBINHK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B28700", Offset = "0x2B27100", VA = "0x182B28700")]
	public bool ACEEBBBBMCG(SceneTag FMEDCFLNIMM, out global::AFMKKOBINHK<Entity> NCAANBGOHJP, Allocator GGLOKAHPEPM = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B28DA0", Offset = "0x2B277A0", VA = "0x182B28DA0")]
	public bool LOMGEMGINNG(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B28CD0", Offset = "0x2B276D0", VA = "0x182B28CD0")]
	public GLICHKLIKDB KGEFEIKIFHE(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B28BE0", Offset = "0x2B275E0", VA = "0x182B28BE0")]
	public bool CDEJDKLJJPA(Entity FLADPKIONGF, out LFFFJCCHELC NCAANBGOHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B28E90", Offset = "0x2B27890", VA = "0x182B28E90")]
	public void ONNODGLGOKJ(Entity FLADPKIONGF, LFFFJCCHELC NCAANBGOHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B28D40", Offset = "0x2B27740", VA = "0x182B28D40")]
	public bool KPKJJLDLPLG(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LAHMKEKFIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public OCLBFAENKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B25080", Offset = "0x2B23A80", VA = "0x182B25080", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B250D0", Offset = "0x2B23AD0", VA = "0x182B250D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B25190", Offset = "0x2B23B90", VA = "0x182B25190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x249F110", Offset = "0x249DB10", VA = "0x18249F110")]
	private bool IHBPILEDBKE<TComponentData>(EntityQuery AMEIGJPGLKK, out NativeArray<Entity> IJBCECFNJIL, out NativeArray<TComponentData> NEOKJGOPJJM) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B25010", Offset = "0x2B23A10", VA = "0x182B25010")]
	public GLICHKLIKDB KGEFEIKIFHE(Entity FLADPKIONGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public MMCLOMICBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D37A00", Offset = "0x2D36400", VA = "0x182D37A00", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D37A50", Offset = "0x2D36450", VA = "0x182D37A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D37C80", Offset = "0x2D36680", VA = "0x182D37C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D37630", Offset = "0x2D36030", VA = "0x182D37630")]
		private void MFMCNFFMIAP(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D375C0", Offset = "0x2D35FC0", VA = "0x182D375C0")]
		private void EMIFMEAGDDE(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D37C10", Offset = "0x2D36610", VA = "0x182D37C10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D376A0", Offset = "0x2D360A0", VA = "0x182D376A0")]
		private void NBKNIPPFJIM(EntityQuery AMEIGJPGLKK, bool IBCMFFCNBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public PGIPBIBLICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E75260", Offset = "0x3E73C60", VA = "0x183E75260")]
			public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x3E751A0", Offset = "0x3E73BA0", VA = "0x183E751A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D2FFE0", Offset = "0x2D2E9E0", VA = "0x182D2FFE0")]
		internal void KFDLFOBMEJP(Entity CJBPCJKPDLN, SplineShapeData IBHBGBEBHJM, DynamicBuffer<LinkedEntityGroup> DICKNCEHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FF50", Offset = "0x2D2E950", VA = "0x182D2FF50", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D30040", Offset = "0x2D2EA40", VA = "0x182D30040")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref FIGMGEOGMJE.LENEBMNMFIO GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FFD0", Offset = "0x2D2E9D0", VA = "0x182D2FFD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E76A50", Offset = "0x3E75450", VA = "0x183E76A50")]
			public void KBLGIFLFDKL(DDAIGJDJEMG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x3E769D0", Offset = "0x3E753D0", VA = "0x183E769D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D2F210", Offset = "0x2D2DC10", VA = "0x182D2F210")]
		internal void KFDLFOBMEJP(Entity JOMCMEOJGLA, SplinePointParentData CINJNIBEMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F350", Offset = "0x2D2DD50", VA = "0x182D2F350", Slot = "5")]
		public void ReadFromDisplayClass(ref PGIPBIBLICC IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F160", Offset = "0x2D2DB60", VA = "0x182D2F160", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F2A0", Offset = "0x2D2DCA0", VA = "0x182D2F2A0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref HEHEJFFEADF.BFCKGAAJFDM GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F1D0", Offset = "0x2D2DBD0", VA = "0x182D2F1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BCEE80", Offset = "0x2BCD880", VA = "0x182BCEE80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEF30", Offset = "0x2BCD930", VA = "0x182BCEF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public DDAIGJDJEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEBE0", Offset = "0x2BCD5E0", VA = "0x182BCEBE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE8E0", Offset = "0x2BCD2E0", VA = "0x182BCE8E0")]
	public static EntityQuery AJCJKPKPFIA(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEA80", Offset = "0x2BCD480", VA = "0x182BCEA80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B590", Offset = "0x2F19F90", VA = "0x182F1B590", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B5F0", Offset = "0x2F19FF0", VA = "0x182F1B5F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public IHGKNPBKKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public PLGJMLOPGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, EELLNPEINOG previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7ABC0", Offset = "0x3E795C0", VA = "0x183E7ABC0")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x3E7AB40", Offset = "0x3E79540", VA = "0x183E7AB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E79320", Offset = "0x3E77D20", VA = "0x183E79320")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData OBFMOAOGODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CE70", Offset = "0x2D2B870", VA = "0x182D2CE70", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E791F0", Offset = "0x3E77BF0", VA = "0x183E791F0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E793A0", Offset = "0x3E77DA0", VA = "0x183E793A0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref MLJNHAGKDBI.MNBACOJOHFP GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E79290", Offset = "0x3E77C90", VA = "0x183E79290")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E77120", Offset = "0x3E75B20", VA = "0x183E77120")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x3E77080", Offset = "0x3E75A80", VA = "0x183E77080")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E77D40", Offset = "0x3E76740", VA = "0x183E77D40")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData OBFMOAOGODB, EELLNPEINOG ONJEGBJDGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E77EE0", Offset = "0x3E768E0", VA = "0x183E77EE0", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E77C30", Offset = "0x3E76630", VA = "0x183E77C30", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E77E00", Offset = "0x3E76800", VA = "0x183E77E00")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref HIHCEBBPAPA.JMCACFKGECK GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E77D00", Offset = "0x3E76700", VA = "0x183E77D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E778B0", Offset = "0x3E762B0", VA = "0x183E778B0")]
			public void KBLGIFLFDKL(EKCMPODICBG AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x3E77830", Offset = "0x3E76230", VA = "0x183E77830")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7AE30", Offset = "0x3E79830", VA = "0x183E7AE30")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, EELLNPEINOG ONJEGBJDGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AF60", Offset = "0x3E79960", VA = "0x183E7AF60", Slot = "5")]
		public void ReadFromDisplayClass(ref PLGJMLOPGAN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AD00", Offset = "0x3E79700", VA = "0x183E7AD00", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7AEB0", Offset = "0x3E798B0", VA = "0x183E7AEB0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref IHHHIGAPOIP.NJIBDDIHAFL GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7ADA0", Offset = "0x3E797A0", VA = "0x183E7ADA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F07390", Offset = "0x2F05D90", VA = "0x182F07390", Slot = "14")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F07B60", Offset = "0x2F06560", VA = "0x182F07B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public EKCMPODICBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F07B00", Offset = "0x2F06500", VA = "0x182F07B00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F07670", Offset = "0x2F06070", VA = "0x182F07670")]
	public static EntityQuery MNOLIEOFHKO(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F078D0", Offset = "0x2F062D0", VA = "0x182F078D0")]
	public static EntityQuery OAGMBJGGNJD(ComponentSystemBase AJPOCCLBMGK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F07470", Offset = "0x2F05E70", VA = "0x182F07470")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1CB80", Offset = "0x2F1B580", VA = "0x182F1CB80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CB10", Offset = "0x2F1B510", VA = "0x182F1CB10", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CC10", Offset = "0x2F1B610", VA = "0x182F1CC10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class IBAGICNMDNG : ParentSystemBase<ParentData, EELLNPEINOG, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A430", Offset = "0x2F18E30", VA = "0x182F1A430", Slot = "14")]
	protected override EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7210B0", VA = "0x1807226B0", Slot = "15")]
	protected override EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A4B0", Offset = "0x2F18EB0", VA = "0x182F1A4B0", Slot = "16")]
	protected override EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A470", Offset = "0x2F18E70", VA = "0x182F1A470", Slot = "17")]
	protected override EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A530", Offset = "0x2F18F30", VA = "0x182F1A530")]
	public IBAGICNMDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A4F0", Offset = "0x2F18EF0", VA = "0x182F1A4F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A7A730", Offset = "0x2A79130", VA = "0x182A7A730", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x24B22D0", Offset = "0x24B0CD0", VA = "0x1824B22D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35C9BC0", Offset = "0x35C85C0", VA = "0x1835C9BC0")]
			private int PEHMAAIDLEO(DynamicBuffer<ChildrenData> PAHCBODMCHK, Entity FLADPKIONGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x35C9540", Offset = "0x35C7F40", VA = "0x1835C9540")]
			private void ADHLPHPIMOP(Entity LFAIGCEGCPL, DynamicBuffer<ChildrenData> PAHCBODMCHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x35C9960", Offset = "0x35C8360", VA = "0x1835C9960")]
			private void MIMDMJMKMCH(Entity LFAIGCEGCPL, DynamicBuffer<ChildrenData> PAHCBODMCHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x35C9800", Offset = "0x35C8200", VA = "0x1835C9800", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2570690", Offset = "0x256F090", VA = "0x182570690", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x258E590", Offset = "0x258CF90", VA = "0x18258E590")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x258E3B0", Offset = "0x258CDB0", VA = "0x18258E3B0")]
		private int PEHMAAIDLEO(DynamicBuffer<ChildrenData> PAHCBODMCHK, Entity FLADPKIONGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x258D020", Offset = "0x258BA20", VA = "0x18258D020")]
		private void IMIOAAOICHL(Entity NHIGGOACGGE, Entity EBPNONDMOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7210B0", VA = "0x1807226B0", Slot = "14")]
		protected virtual EntityQueryDesc ACEKICMCFFB(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7210B0", VA = "0x1807226B0", Slot = "15")]
		protected virtual EntityQueryDesc PKOONEMHANH(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7210B0", VA = "0x1807226B0", Slot = "16")]
		protected virtual EntityQueryDesc EOJHNOCDJCO(EntityQueryDesc AMEIGJPGLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc CHCFPMMOJON(EntityQueryDesc AMEIGJPGLKK);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x258DDA0", Offset = "0x258C7A0", VA = "0x18258DDA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x258DBE0", Offset = "0x258C5E0", VA = "0x18258DBE0")]
		private void ONIPHGJPOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x258CB40", Offset = "0x258B540", VA = "0x18258CB40")]
		private void EBJNEOPFGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x258D180", Offset = "0x258BB80", VA = "0x18258D180")]
		private JobHandle MAEDMIHFLKG(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x258C860", Offset = "0x258B260", VA = "0x18258C860")]
		private void AFKNLHCCGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x258E2E0", Offset = "0x258CCE0", VA = "0x18258E2E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x23957E0", Offset = "0x23941E0", VA = "0x1823957E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x258DD80", Offset = "0x258C780", VA = "0x18258DD80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E76150", Offset = "0x3E74B50", VA = "0x183E76150")]
		public GGALAMDJCAC(NativeList<Entity> CBBNLFABCAH, NativeList<Entity> NAHCFHBDGDE, JobHandle AHIGBHNJKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x3E760D0", Offset = "0x3E74AD0", VA = "0x183E760D0")]
		public JobHandle IJIEFFPOAMP(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x3E76040", Offset = "0x3E74A40", VA = "0x183E76040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D2D6C0", Offset = "0x2D2C0C0", VA = "0x182D2D6C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D850", Offset = "0x2D2C250", VA = "0x182D2D850")]
		private void GCFGEGCMEKP(Entity FLADPKIONGF, bool JFPDELADEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DAA0", Offset = "0x2D2C4A0", VA = "0x182D2DAA0")]
		private void NGKJOILDFHN(Entity FLADPKIONGF, bool JFPDELADEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D640", Offset = "0x2D2C040", VA = "0x182D2D640")]
		public GGALAMDJCAC EKEOAGCIPLE(NativeArray<Entity> BEMBCCNAMCE, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DBB0", Offset = "0x2D2C5B0", VA = "0x182D2DBB0")]
		public GGALAMDJCAC PHMKMGEKNPE(NativeArray<Entity> BEMBCCNAMCE, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D560", Offset = "0x2D2BF60", VA = "0x182D2D560")]
		public GGALAMDJCAC DBFHGKOECBN(NativeList<KCBMDFFNPLE> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D8E0", Offset = "0x2D2C2E0", VA = "0x182D2D8E0")]
		public GGALAMDJCAC ICCJLIGGAIN(NativeList<KCBMDFFNPLE> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D9C0", Offset = "0x2D2C3C0", VA = "0x182D2D9C0")]
		public GGALAMDJCAC LLHFBEHEOED(NativeList<AGAIJBALKEC> ACLENHAHHHH, JobHandle BAMHFDJJPAO)
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x27478E0", Offset = "0x27462E0", VA = "0x1827478E0")]
		private GGALAMDJCAC ABPAKOFKCJN<T>(NativeList<T> ACLENHAHHHH, int ALCMCJODGAH, int JMIAEFEPHMM, OENMLOCKMAH OLBBMHHLPIG, JobHandle BAMHFDJJPAO) where T : struct
		{
			return default(GGALAMDJCAC);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D390", Offset = "0x2D2BD90", VA = "0x182D2D390")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD30D0", Offset = "0x2BD1AD0", VA = "0x182BD30D0")]
	protected DLIGPDHAAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1810", Offset = "0x2BD0210", VA = "0x182BD1810", Slot = "14")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1FA0", Offset = "0x2BD09A0", VA = "0x182BD1FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x2BD21D0", Offset = "0x2BD0BD0", VA = "0x182BD21D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x780510", Offset = "0x77EF10", VA = "0x180780510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x2BD18F0", Offset = "0x2BD02F0", VA = "0x182BD18F0")]
	private void FICHIMLCECG(NativeArray<Entity> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1CB0", Offset = "0x2BD06B0", VA = "0x182BD1CB0")]
	private void IMMEIACMCHJ(NativeArray<Entity> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1950", Offset = "0x2BD0350", VA = "0x182BD1950")]
	private void GAMOFJNBDAH(GGALAMDJCAC LKELINMLMFO, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1A90", Offset = "0x2BD0490", VA = "0x182BD1A90")]
	private void GAMOFJNBDAH(global::NLPBCKKLMDB<Entity> GBNGHGBEGOP, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1E60", Offset = "0x2BD0860", VA = "0x182BD1E60")]
	private void LCOCFDHHDAL(GGALAMDJCAC LKELINMLMFO, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1D50", Offset = "0x2BD0750", VA = "0x182BD1D50")]
	private void LCOCFDHHDAL(global::NLPBCKKLMDB<Entity> GBNGHGBEGOP, string GJEBOKDBHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1BA0", Offset = "0x2BD05A0", VA = "0x182BD1BA0")]
	private bool GCFFCJFBDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public PHAHFPHEIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E79460", Offset = "0x3E77E60", VA = "0x183E79460")]
			public void KBLGIFLFDKL(GNLKGNPEMJB AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x3E79450", Offset = "0x3E77E50", VA = "0x183E79450")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E78190", Offset = "0x3E76B90", VA = "0x183E78190")]
		internal void KFDLFOBMEJP(Entity CNABBHHIHOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x3E75B80", Offset = "0x3E74580", VA = "0x183E75B80", Slot = "5")]
		public void ReadFromDisplayClass(ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x3E75BB0", Offset = "0x3E745B0", VA = "0x183E75BB0", Slot = "6")]
		public void WriteToDisplayClass(ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x3E78100", Offset = "0x3E76B00", VA = "0x183E78100", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x3E78310", Offset = "0x3E76D10", VA = "0x183E78310")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref LKBHOCMFAPL.CACLDJJECNA GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x3E78150", Offset = "0x3E76B50", VA = "0x183E78150")]
		public void KBLGIFLFDKL(GNLKGNPEMJB AJPOCCLBMGK, ref PHAHFPHEIKN IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x3E782A0", Offset = "0x3E76CA0", VA = "0x183E782A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F16C00", Offset = "0x2F15600", VA = "0x182F16C00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2F16AC0", Offset = "0x2F154C0", VA = "0x182F16AC0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2F16C60", Offset = "0x2F15660", VA = "0x182F16C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public GNLKGNPEMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2F16B20", Offset = "0x2F15520", VA = "0x182F16B20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2F168F0", Offset = "0x2F152F0", VA = "0x182F168F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1C300", Offset = "0x2F1AD00", VA = "0x182F1C300", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C370", Offset = "0x2F1AD70", VA = "0x182F1C370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C410", Offset = "0x2F1AE10", VA = "0x182F1C410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public IOCKKLCEHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000")]
	public static CIINKDAIIND DGKBAOBECFH(in GICNBHGCLJH LEFNEJCOFJL)
	{
		return default(CIINKDAIIND);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F22650", Offset = "0x2F21050", VA = "0x182F22650", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	public LDFECCHBCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public GDAOMHKIAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7B1D0", Offset = "0x3E79BD0", VA = "0x183E7B1D0")]
			public void KBLGIFLFDKL(FHIKJCOPHGD AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x3E7B150", Offset = "0x3E79B50", VA = "0x183E7B150")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E75960", Offset = "0x3E74360", VA = "0x183E75960")]
		internal void KFDLFOBMEJP(Entity CNABBHHIHOO, CIINKDAIIND MCOOKECPGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x3E75B80", Offset = "0x3E74580", VA = "0x183E75B80", Slot = "5")]
		public void ReadFromDisplayClass(ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x3E75BB0", Offset = "0x3E745B0", VA = "0x183E75BB0", Slot = "6")]
		public void WriteToDisplayClass(ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x3E75830", Offset = "0x3E74230", VA = "0x183E75830", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x3E75AD0", Offset = "0x3E744D0", VA = "0x183E75AD0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref NIDOOEGKGKO.DEHKEFIPEGP GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3E758D0", Offset = "0x3E742D0", VA = "0x183E758D0")]
		public void KBLGIFLFDKL(FHIKJCOPHGD AJPOCCLBMGK, ref GDAOMHKIAEO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x3E75A60", Offset = "0x3E74460", VA = "0x183E75A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F0FCB0", Offset = "0x2F0E6B0", VA = "0x182F0FCB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FB70", Offset = "0x2F0E570", VA = "0x182F0FB70", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FD10", Offset = "0x2F0E710", VA = "0x182F0FD10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public FHIKJCOPHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FBD0", Offset = "0x2F0E5D0", VA = "0x182F0FBD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F9A0", Offset = "0x2F0E3A0", VA = "0x182F0F9A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7B0B0", Offset = "0x3E79AB0", VA = "0x183E7B0B0")]
			public NEINFBOMBIB(int FHGNFGIEADL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x3E7B030", Offset = "0x3E79A30", VA = "0x183E7B030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E79A60", Offset = "0x3E78460", VA = "0x183E79A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7B720", Offset = "0x3E7A120", VA = "0x183E7B720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3D0C0", Offset = "0x2B3BAC0", VA = "0x182B3D0C0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D260", Offset = "0x2B3BC60", VA = "0x182B3D260", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CCB0", Offset = "0x2B3B6B0", VA = "0x182B3CCB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D520", Offset = "0x2B3BF20", VA = "0x182B3D520", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CE20", Offset = "0x2B3B820", VA = "0x182B3CE20")]
		private void MKKACDOFLIO(EntityQuery AMEIGJPGLKK, out (global::AFMKKOBINHK<CIINKDAIIND> handles, global::AFMKKOBINHK<EBMEGFHECAE> bounds) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C760", Offset = "0x2B3B160", VA = "0x182B3C760")]
		private void DIADEKOGMDE((global::AFMKKOBINHK<CIINKDAIIND> handles, global::AFMKKOBINHK<EBMEGFHECAE> bounds) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CCB0", Offset = "0x2B3B6B0", VA = "0x182B3CCB0")]
		private void ECJFBALLNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D120", Offset = "0x2B3BB20", VA = "0x182B3D120")]
		private void OAFOACGPPJM(EntityQuery AMEIGJPGLKK, out (global::AFMKKOBINHK<Entity> entities, global::AFMKKOBINHK<CIINKDAIIND> handles) JIHCLPECHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C9C0", Offset = "0x2B3B3C0", VA = "0x182B3C9C0")]
		private void DMOIMFJBEEE((global::AFMKKOBINHK<Entity> entities, global::AFMKKOBINHK<CIINKDAIIND> handles) JIHCLPECHIB, NEINFBOMBIB LGPKJBBIKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CF60", Offset = "0x2B3B960", VA = "0x182B3CF60")]
		private JobHandle MMFBDEIPHEJ(NEINFBOMBIB LGPKJBBIKKA, ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ, ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO, ComponentDataFromEntity<WorldDeformableScaleData> NMJJMNPBNGM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CCF0", Offset = "0x2B3B6F0", VA = "0x182B3CCF0")]
		private JobHandle HOCFKECOANB(NEINFBOMBIB LGPKJBBIKKA, ComponentDataFromEntity<WorldPoseData> BHFKPEOIIMJ, ComponentDataFromEntity<WorldUniformScaleData> LICFJEDLFDO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E72DA0", Offset = "0x3E717A0", VA = "0x183E72DA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E787C0", Offset = "0x3E771C0", VA = "0x183E787C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D3A000", Offset = "0x2D38A00", VA = "0x182D3A000", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A210", Offset = "0x2D38C10", VA = "0x182D3A210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2D39B80", Offset = "0x2D38580", VA = "0x182D39B80")]
		private JobHandle LDALNJNKDIP(global::AFMKKOBINHK<Entity> HEONDDEAIBL, int JKABHKIANJL, JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2D39C60", Offset = "0x2D38660", VA = "0x182D39C60")]
		private JobHandle LDALNJNKDIP(NativeArray<Entity> LHOOFBNDFAP, int JKABHKIANJL, [Optional] JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A730", Offset = "0x2D39130", VA = "0x182D3A730")]
		private global::AFMKKOBINHK<Entity> PNONOLIOHMK(EntityQuery AMEIGJPGLKK)
		{
			return default(global::AFMKKOBINHK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2D392A0", Offset = "0x2D37CA0", VA = "0x182D392A0")]
		private (global::NLPBCKKLMDB<Entity>, global::NLPBCKKLMDB<Entity>) AOEFLHOHCBJ(global::AFMKKOBINHK<Entity> OHNOLPHNEEG)
		{
			return default((global::NLPBCKKLMDB<Entity>, global::NLPBCKKLMDB<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x2D39F70", Offset = "0x2D38970", VA = "0x182D39F70")]
		private void ONHDEDCEEBC(out NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2D396F0", Offset = "0x2D380F0", VA = "0x182D396F0")]
		private void CIFIFDHDHFL(NativeList<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2D39780", Offset = "0x2D38180", VA = "0x182D39780")]
		private void CIFIFDHDHFL(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2D39E40", Offset = "0x2D38840", VA = "0x182D39E40")]
		private void OIDPAKOFFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void GBCLDGBNEHA(int KLDIBGACAGG, int OBEIAGKELAO, int GNCMLAKBBAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2D39850", Offset = "0x2D38250", VA = "0x182D39850")]
		private static EBMEGFHECAE LAOLKGBINPA(NativeArray<Entity> FINHNPIHHDI, ComponentDataFromEntity<SplinePointPositionData> HBKNOECNGMP, ComponentDataFromEntity<SplinePointScaleData> CHLLLKLOOPG)
		{
			return default(EBMEGFHECAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F069F0", Offset = "0x2F053F0", VA = "0x182F069F0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2F06640", Offset = "0x2F05040", VA = "0x182F06640")]
		public bool ACKAGFFFKJJ(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2F06BC0", Offset = "0x2F055C0", VA = "0x182F06BC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2F06A60", Offset = "0x2F05460", VA = "0x182F06A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2F06CF0", Offset = "0x2F056F0", VA = "0x182F06CF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x1332FE0", Offset = "0x13319E0", VA = "0x181332FE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2F06A60", Offset = "0x2F05460", VA = "0x182F06A60")]
		private void NMBOOEIPCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2F06800", Offset = "0x2F05200", VA = "0x182F06800")]
		private void IDJKAFLJHHB(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2F068B0", Offset = "0x2F052B0", VA = "0x182F068B0")]
		private void NDCJIFCEOKK(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2F066F0", Offset = "0x2F050F0", VA = "0x182F066F0")]
		private void CAHDAIHLDPP(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2F06AA0", Offset = "0x2F054A0", VA = "0x182F06AA0")]
		private void OEACAAKJOIA(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0C3C0", Offset = "0x2F0ADC0", VA = "0x182F0C3C0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C470", Offset = "0x2F0AE70", VA = "0x182F0C470", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BE30", Offset = "0x2F0A830", VA = "0x182F0BE30")]
		private void LOFKLGHFEMF(IGGCJBCLGAF CBBKLGMGPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private void CHPMANCHJPA(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB, DHPNCKOALMM MEIAOCKHKHB, KCFNAMGFMNK KIEFDNEMCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B431B0", Offset = "0x2B41BB0", VA = "0x182B431B0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B43240", Offset = "0x2B41C40", VA = "0x182B43240", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D41690", Offset = "0x2D40090", VA = "0x182D41690", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D416E0", Offset = "0x2D400E0", VA = "0x182D416E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D2CE80", Offset = "0x2D2B880", VA = "0x182D2CE80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC39F0", Offset = "0x2BC23F0", VA = "0x182BC39F0", Slot = "14")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3A00", Offset = "0x2BC2400", VA = "0x182BC3A00", Slot = "15")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3A90", Offset = "0x2BC2490", VA = "0x182BC3A90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3BE0", Offset = "0x2BC25E0", VA = "0x182BC3BE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3980", Offset = "0x2BC2380", VA = "0x182BC3980")]
		private bool JLHLHEJFKON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3640", Offset = "0x2BC2040", VA = "0x182BC3640")]
		private void AEPBJHBIDBL(EntityQuery AMEIGJPGLKK, float3 MFJCDEMGGLB, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FEA0", Offset = "0x2B3E8A0", VA = "0x182B3FEA0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FEF0", Offset = "0x2B3E8F0", VA = "0x182B3FEF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D48100", Offset = "0x2D46B00", VA = "0x182D48100", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D48170", Offset = "0x2D46B70", VA = "0x182D48170", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D48200", Offset = "0x2D46C00", VA = "0x182D48200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0B620", Offset = "0x2F0A020", VA = "0x182F0B620", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B7E0", Offset = "0x2F0A1E0", VA = "0x182F0B7E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AB50", Offset = "0x2F09550", VA = "0x182F0AB50")]
		private void CFHGMLNLCPC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ACLENHAHHHH, EntityQueryDesc HLHOOFAHPJK, bool CCLEKJNADLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AA10", Offset = "0x2F09410", VA = "0x182F0AA10")]
		private void CFHGMLNLCPC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ACLENHAHHHH, EntityQueryDesc HLHOOFAHPJK, bool CCLEKJNADLB, bool CPHPLAEKCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BA40", Offset = "0x2F0A440", VA = "0x182F0BA40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A7E0", Offset = "0x2F091E0", VA = "0x182F0A7E0")]
		private void ALKMJGDDHDA(EntityQuery AMEIGJPGLKK, bool JMJIDNELPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AD30", Offset = "0x2F09730", VA = "0x182F0AD30")]
		private void HCMNJKGGJCN(EntityQuery AMEIGJPGLKK, bool HMGDHPGJDKJ, bool JMJIDNELPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AF40", Offset = "0x2F09940", VA = "0x182F0AF40")]
		private void HNKFMJLACEO(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B670", Offset = "0x2F0A070", VA = "0x182F0B670")]
		private void NDLDBKNHBIC(NativeList<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B360", Offset = "0x2F09D60", VA = "0x182F0B360")]
		private void IOHBEGEEKDN(NativeArray<Entity> IJBCECFNJIL, bool HMGDHPGJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B160", Offset = "0x2F09B60", VA = "0x182F0B160")]
		private NativeList<Entity> ICPOIAGHIJK(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0ACF0", Offset = "0x2F096F0", VA = "0x182F0ACF0")]
		private NativeList<Entity> GACPELOHELK(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F0A9D0", Offset = "0x2F093D0", VA = "0x182F0A9D0")]
		private NativeList<Entity> BKAEFHLBJME(NativeArray<Entity> IJBCECFNJIL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B480", Offset = "0x2F09E80", VA = "0x182F0B480")]
		private NativeList<Entity> JMMLFMGCMIB(NativeArray<Entity> IJBCECFNJIL, bool BNECEEHLHPF)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x2F0AC60", Offset = "0x2F09660", VA = "0x182F0AC60")]
		private LJIODJFNCKI CKKBBDHNMKI(NativeArray<Entity> IJBCECFNJIL)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LJIODJFNCKI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x2F0BD60", Offset = "0x2F0A760", VA = "0x182F0BD60")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FF10", Offset = "0x2B3E910", VA = "0x182B3FF10", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF60", Offset = "0x2B3E960", VA = "0x182B3FF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F062B0", Offset = "0x2F04CB0", VA = "0x182F062B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2F06470", Offset = "0x2F04E70", VA = "0x182F06470", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2F05E30", Offset = "0x2F04830", VA = "0x182F05E30")]
		private void BEGDICGCAPB(EntityQuery AMEIGJPGLKK, bool BGANFPDCCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2F06070", Offset = "0x2F04A70", VA = "0x182F06070")]
		private void NOBCKKMDLCC(EntityQuery AMEIGJPGLKK, bool BGANFPDCCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBCA50", Offset = "0x2BBB450", VA = "0x182BBCA50", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCAC0", Offset = "0x2BBB4C0", VA = "0x182BBCAC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCBD0", Offset = "0x2BBB5D0", VA = "0x182BBCBD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC7D0", Offset = "0x2BBB1D0", VA = "0x182BBC7D0")]
		private void EKAELDNMMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC660", Offset = "0x2BBB060", VA = "0x182BBC660")]
		private void DPIMHHGOFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC200", Offset = "0x2BBAC00", VA = "0x182BBC200")]
		private void CBBLKHGBGBI(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC520", Offset = "0x2BBAF20", VA = "0x182BBC520")]
		private void DINOAJBIEAD(NativeArray<Entity> IJBCECFNJIL, int NCACOMDBOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC8E0", Offset = "0x2BBB2E0", VA = "0x182BBC8E0")]
		private void IFJFIJAIMCE(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC9F0", Offset = "0x2BBB3F0", VA = "0x182BBC9F0")]
		private void JLPIFAPJIHD(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void EBKNAIOEKJA(int NPMIJOEHCCM, Transform HJLACGOIJCA, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class LDOOHBIHGMH
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F22680", Offset = "0x2F21080", VA = "0x182F22680")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC5550", Offset = "0x2BC3F50", VA = "0x182BC5550", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC55A0", Offset = "0x2BC3FA0", VA = "0x182BC55A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5660", Offset = "0x2BC4060", VA = "0x182BC5660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B23D10", Offset = "0x2B22710", VA = "0x182B23D10")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x2B23DF0", Offset = "0x2B227F0", VA = "0x182B23DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity CAFBNGCEACD
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x2B246D0", Offset = "0x2B230D0", VA = "0x182B246D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public NIALADIPDNC HDJONJGBALG
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F30", Offset = "0x2B22930", VA = "0x182B23F30")]
			get
			{
				return default(NIALADIPDNC);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B23FF0", Offset = "0x2B229F0", VA = "0x182B23FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public NIALADIPDNC LIMJLNEJNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B24060", Offset = "0x2B22A60", VA = "0x182B24060")]
			get
			{
				return default(NIALADIPDNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B245B0", Offset = "0x2B22FB0", VA = "0x182B245B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B24240", Offset = "0x2B22C40", VA = "0x182B24240", Slot = "15")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B24650", Offset = "0x2B23050", VA = "0x182B24650", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B240F0", Offset = "0x2B22AF0", VA = "0x182B240F0", Slot = "14")]
		protected override void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B23E50", Offset = "0x2B22850", VA = "0x182B23E50")]
		private void DEFNLDFODMJ(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B242B0", Offset = "0x2B22CB0", VA = "0x182B242B0")]
		private void NMAMEDOPGMF(Entity FLADPKIONGF, Entity KLNJIPMLJAD, Entity CFFOBEPMEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCBA0", Offset = "0x3BCB5A0", VA = "0x183BCCBA0")]
		private bool DJEIEOEOGPA<T>(out T MAKFNMHIJIF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCC30", Offset = "0x3BCB630", VA = "0x183BCCC30")]
		private void FFFKFHDEEJJ<T>(T MAKFNMHIJIF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B23D70", Offset = "0x2B22770", VA = "0x182B23D70")]
		public bool BBAFLDMEEIM(NIALADIPDNC FPHANPAOKPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B23FC0", Offset = "0x2B229C0", VA = "0x182B23FC0")]
		private static bool FLOODIHMIPG(NIALADIPDNC BAOOHKEMBGH, NIALADIPDNC PPFCNPGDEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B24780", Offset = "0x2B23180", VA = "0x182B24780")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B24570", Offset = "0x2B22F70", VA = "0x182B24570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCDAD0", Offset = "0x2BCC4D0", VA = "0x182BCDAD0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDC30", Offset = "0x2BCC630", VA = "0x182BCDC30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCD0", Offset = "0x2BCC6D0", VA = "0x182BCDCD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD980", Offset = "0x2BCC380", VA = "0x182BCD980")]
		private NativeArray<Entity> KOIIMLDOFEM(int FPLNDBJJHMM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDB20", Offset = "0x2BCC520", VA = "0x182BCDB20")]
		private void ONECENODGNM(NativeArray<Entity> EBBFGPFNGNP, NativeArray<Entity> EBBPNAKFEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F17A30", Offset = "0x2F16430", VA = "0x182F17A30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2F17B20", Offset = "0x2F16520", VA = "0x182F17B20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x279D5F0", Offset = "0x279BFF0", VA = "0x18279D5F0")]
	public static NativeArray<T> ABPAKOFKCJN<T>(NativeArray<Entity> IJBCECFNJIL, EntityManager LNPEGOPJJGK) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x2B39C80", Offset = "0x2B38680", VA = "0x182B39C80")]
	public static void IKOJLOGIDDJ(EntityQuery AMEIGJPGLKK, EntityManager LNPEGOPJJGK, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x2B39B50", Offset = "0x2B38550", VA = "0x182B39B50")]
	public static void FFNPPDNMKMI(NativeArray<Entity> EBBFGPFNGNP, CLJEHOFLHAA GLMAKIKHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38420", VA = "0x182B39A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D47450", Offset = "0x2D45E50", VA = "0x182D47450", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2D474E0", Offset = "0x2D45EE0", VA = "0x182D474E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2D47580", Offset = "0x2D45F80", VA = "0x182D47580", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2D46C40", Offset = "0x2D45640", VA = "0x182D46C40")]
		private void JNDEHBKDDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2D466A0", Offset = "0x2D450A0", VA = "0x182D466A0")]
		private void AMNAMPNLINA(NativeArray<Entity> EBBFGPFNGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2D47590", Offset = "0x2D45F90", VA = "0x182D47590")]
		private void PHJOLNFEMIJ(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2D47E60", Offset = "0x2D46860", VA = "0x182D47E60")]
		private void POGOAFJBNIP(NativeArray<Entity> EBBPNAKFEMI, NativeArray<RigidTransform> OIGFGPHKEAB, NativeArray<RigidTransform> FPINOMFIINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2D467B0", Offset = "0x2D451B0", VA = "0x182D467B0")]
		private void CHEAAFIHFBG(NativeArray<RigidTransform> FPINOMFIINJ, NativeArray<Entity> EBBPNAKFEMI, NativeList<Entity> PAOOLNPAMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3E4C0", Offset = "0x2B3CEC0", VA = "0x182B3E4C0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E530", Offset = "0x2B3CF30", VA = "0x182B3E530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E680", Offset = "0x2B3D080", VA = "0x182B3E680", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E450", Offset = "0x2B3CE50", VA = "0x182B3E450")]
		private void BPFEAIHKCJD(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FB80", Offset = "0x2B3E580", VA = "0x182B3FB80", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FDA0", Offset = "0x2B3E7A0", VA = "0x182B3FDA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FE40", Offset = "0x2B3E840", VA = "0x182B3FE40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FC10", Offset = "0x2B3E610", VA = "0x182B3FC10")]
		private void NHABEAMIBKM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D32520", Offset = "0x2D30F20", VA = "0x182D32520", Slot = "14")]
		protected override void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2D32450", Offset = "0x2D30E50", VA = "0x182D32450")]
		[BurstCompile]
		private static void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CCFJELKOCGI, ComponentDataFromEntity<global::PLGKGDLBNHN> HGGBDJIEDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2D326B0", Offset = "0x2D310B0", VA = "0x182D326B0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2D32670", Offset = "0x2D31070", VA = "0x182D32670", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2863FA0", Offset = "0x28629A0", VA = "0x182863FA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x28641A0", Offset = "0x2862BA0", VA = "0x1828641A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2864170", Offset = "0x2862B70", VA = "0x182864170", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x2862D70", Offset = "0x2861770", VA = "0x182862D70")]
		private void JNPDMGMMJKL(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x28635F0", Offset = "0x2861FF0", VA = "0x1828635F0")]
		private void JPGPIDFEDIM(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2862920", Offset = "0x2861320", VA = "0x182862920")]
		private void AAEEFJOGMBO(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void JOFKCBMHMLC(NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> OLEOPPGABBJ, NativeArray<Entity> CCFJELKOCGI);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2864230", Offset = "0x2862C30", VA = "0x182864230")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x258DD80", Offset = "0x258C780", VA = "0x18258DD80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F081D0", Offset = "0x2F06BD0", VA = "0x182F081D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2F083D0", Offset = "0x2F06DD0", VA = "0x182F083D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2F08520", Offset = "0x2F06F20", VA = "0x182F08520")]
	public EONJFGKPAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B23CE0", Offset = "0x2B226E0", VA = "0x182B23CE0")]
	public static Entity DGKBAOBECFH(DOJOLOPDIDF JIHCLPECHIB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2B23CE0", Offset = "0x2B226E0", VA = "0x182B23CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1B4B0", Offset = "0x2F19EB0", VA = "0x182F1B4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B530", Offset = "0x2F19F30", VA = "0x182F1B530")]
	public IFHANGOBDPE(ComponentType ALGBEENOGLE, NativeList<int> BGLJHEFMNHL, NativeList<int> MGCBIKMPPGP, NativeArray<Entity> IJBCECFNJIL, NativeArray<Entity> CIMNNGLPNBL, NativeArray<byte> ONJEGBJDGFD, NativeArray<byte> OBFMOAOGODB, int FFDNEEBDPLF, int KEDIELKNBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B380", Offset = "0x2F19D80", VA = "0x182F1B380")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B330", Offset = "0x2F19D30", VA = "0x182F1B330")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B2E0", Offset = "0x2F19CE0", VA = "0x182F1B2E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1B200", Offset = "0x2F19C00", VA = "0x182F1B200", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B2A6A0", Offset = "0x2B290A0", VA = "0x182B2A6A0")]
	public OPLPBOKJNKG(ComponentType ALGBEENOGLE, int FFDNEEBDPLF, int KEDIELKNBEI, EntityQuery AMEIGJPGLKK, NativeArray<OHEJDJOONHG> KECMGAIBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A650", Offset = "0x2B29050", VA = "0x182B2A650", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
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
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1E3B0", Offset = "0x2F1CDB0", VA = "0x182F1E3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public HDFAPEIIIAK GOODPMCPKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20")]
		get
		{
			return default(HDFAPEIIIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E4B0", Offset = "0x2F1CEB0", VA = "0x182F1E4B0")]
	public COGGJKLIPPL GJJAFAPMIOG(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E3C0", Offset = "0x2F1CDC0", VA = "0x182F1E3C0")]
	public COGGJKLIPPL EDJFNOLGIKK(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x22A04F0", Offset = "0x229EEF0", VA = "0x1822A04F0")]
	public T GJJAFAPMIOG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x22A04D0", Offset = "0x229EED0", VA = "0x1822A04D0")]
	public T EDJFNOLGIKK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E5A0", Offset = "0x2F1CFA0", VA = "0x182F1E5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BB6F30", Offset = "0x2BB5930", VA = "0x182BB6F30", Slot = "17")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6F80", Offset = "0x2BB5980", VA = "0x182BB6F80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6CF0", Offset = "0x2BB56F0", VA = "0x182BB6CF0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	protected AAJMJDCHNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B39470", Offset = "0x2B37E70", VA = "0x182B39470")]
		get
		{
			return default(OPLPBOKJNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x2B39810", Offset = "0x2B38210", VA = "0x182B39810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x2B39910", Offset = "0x2B38310", VA = "0x182B39910")]
	public PIFFPMLCLFK(LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x2B39500", Offset = "0x2B37F00", VA = "0x182B39500")]
	public bool IDEDABPJLGL(ComponentType ALGBEENOGLE, out OPLPBOKJNKG ILAPGNJICNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x2B38E40", Offset = "0x2B37840", VA = "0x182B38E40")]
	public Dictionary<ComponentType, OPLPBOKJNKG>.Enumerator CBILBBMABKJ()
	{
		return default(Dictionary<ComponentType, OPLPBOKJNKG>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2B38ED0", Offset = "0x2B378D0", VA = "0x182B38ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2B39070", Offset = "0x2B37A70", VA = "0x182B39070")]
	private void FKKKKGBGGDI(IEnumerable<LDCIHJCLMHG> BNBJOMLPPDN, EntityManager LNPEGOPJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2B39860", Offset = "0x2B38260", VA = "0x182B39860")]
	private static int NFNJEIBJGEF(LDCIHJCLMHG JDPNBCGEEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x2B39570", Offset = "0x2B37F70", VA = "0x182B39570")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5CAE0", Offset = "0xD5B4E0", VA = "0x180D5CAE0", Slot = "4")]
			get
			{
				return default(KCFNAMGFMNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x3E76480", Offset = "0x3E74E80", VA = "0x183E76480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x3E764D0", Offset = "0x3E74ED0", VA = "0x183E764D0")]
		internal GOBAIJEKNID(NativeMultiHashMap<Entity, KCFNAMGFMNK> BLDLHAOGGDA, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x3E76270", Offset = "0x3E74C70", VA = "0x183E76270", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x3E76240", Offset = "0x3E74C40", VA = "0x183E76240")]
		public GOBAIJEKNID CBILBBMABKJ()
		{
			return default(GOBAIJEKNID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x3E76340", Offset = "0x3E74D40", VA = "0x183E76340", Slot = "9")]
		private IEnumerator<KCFNAMGFMNK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x3E763E0", Offset = "0x3E74DE0", VA = "0x183E763E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F221F0", Offset = "0x2F20BF0", VA = "0x182F221F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x2F22450", Offset = "0x2F20E50", VA = "0x182F22450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x1E23AE0", Offset = "0x1E224E0", VA = "0x181E23AE0")]
	public LBOLGJICLNI(DBNCKKCNGJJ BLJBLMCPLPH, JobHandle COLJNHAKGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2F220B0", Offset = "0x2F20AB0", VA = "0x182F220B0")]
	public bool CKGGCMKPNGB(Allocator GGLOKAHPEPM, out NativeKeyValueArrays<Entity, KCFNAMGFMNK> BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2F222E0", Offset = "0x2F20CE0", VA = "0x182F222E0")]
	public bool LPNGABLFNOL(Allocator GGLOKAHPEPM, out (NativeArray<Entity> entities, int uniqueCount) BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2F22530", Offset = "0x2F20F30", VA = "0x182F22530")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBB0C0", Offset = "0x2BB9AC0", VA = "0x182BBB0C0")]
		get
		{
			return default(OPLPBOKJNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int ICNBMEOIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB150", Offset = "0x2BB9B50", VA = "0x182BBB150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB190", Offset = "0x2BB9B90", VA = "0x182BBB190")]
	public APMEOIGEMKF(PIFFPMLCLFK JIANONPNEOD, LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAB80", Offset = "0x2BB9580", VA = "0x182BBAB80")]
	public List<OPLPBOKJNKG>.Enumerator CBILBBMABKJ()
	{
		return default(List<OPLPBOKJNKG>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAC00", Offset = "0x2BB9600", VA = "0x182BBAC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAD80", Offset = "0x2BB9780", VA = "0x182BBAD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD57A0", Offset = "0x2BD41A0", VA = "0x182BD57A0")]
	public DPDLGGKHONK(ObjectInstantiationService EJCAANKBGPG, LEDNJPMFMJI NCKCDMENEMI, FGGEJMNNOEE LAEOPKAJMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4460", Offset = "0x2BD2E60", VA = "0x182BD4460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5740", Offset = "0x2BD4140", VA = "0x182BD5740")]
	public bool OABIHIPJEOM(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD46E0", Offset = "0x2BD30E0", VA = "0x182BD46E0")]
	private void HCKIKFOPLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3F30", Offset = "0x2BD2930", VA = "0x182BD3F30")]
	private EntityArchetype BAJDKJLJBCF(EntityArchetype CLMPEOBNPPG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5060", Offset = "0x2BD3A60", VA = "0x182BD5060")]
	public static void NDOCCMNEPAB(EntityManager OPLEGACAFEB, EntityManager PCGCHIPEABE, NativeArray<Entity> FOMMJLEICDI, NativeArray<EntityArchetype> OBKKKOHOLJM, [Optional] NativeArray<Entity> HDMJCPIPBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD55D0", Offset = "0x2BD3FD0", VA = "0x182BD55D0")]
	[Conditional("DEBUG_BUILD")]
	private static void NPOKKHDAODA(NativeArray<EntityArchetype> CGBHJDKNJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4D40", Offset = "0x2BD3740", VA = "0x182BD4D40")]
	private static string KABCHDDLAJE(EntityArchetype HEFFAMIFPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5490", Offset = "0x2BD3E90", VA = "0x182BD5490")]
	[CompilerGenerated]
	internal static void NPODIEAADLG(ref Span<ComponentType> JICGAPJOBOB, ComponentType MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4530", Offset = "0x2BD2F30", VA = "0x182BD4530")]
	[CompilerGenerated]
	internal static void FHOABOKDBBH(Span<ComponentType> HEONDDEAIBL, ref Span<ComponentType> JICGAPJOBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4F80", Offset = "0x2BD3980", VA = "0x182BD4F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBC090", Offset = "0x2BBAA90", VA = "0x182BBC090", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC150", Offset = "0x2BBAB50", VA = "0x182BBC150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D301F0", Offset = "0x2D2EBF0", VA = "0x182D301F0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2D30160", Offset = "0x2D2EB60", VA = "0x182D30160")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D2FC70", Offset = "0x2D2E670", VA = "0x182D2FC70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D30330", Offset = "0x2D2ED30", VA = "0x182D30330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D2F9F0", Offset = "0x2D2E3F0", VA = "0x182D2F9F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BC6760", Offset = "0x2BC5160", VA = "0x182BC6760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private DBNCKKCNGJJ CJEEMAGCIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x2BC5A20", Offset = "0x2BC4420", VA = "0x182BC5A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC82E0", Offset = "0x2BC6CE0", VA = "0x182BC82E0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "15")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC83B0", Offset = "0x2BC6DB0", VA = "0x182BC83B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8570", Offset = "0x2BC6F70", VA = "0x182BC8570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8500", Offset = "0x2BC6F00", VA = "0x182BC8500", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5720", Offset = "0x2BC4120", VA = "0x182BC5720")]
		private void AEICDKNOBDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7C00", Offset = "0x2BC6600", VA = "0x182BC7C00")]
		internal void LEBADALCGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7420", Offset = "0x2BC5E20", VA = "0x182BC7420")]
		private void LEBADALCGDC(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5A40", Offset = "0x2BC4440", VA = "0x182BC5A40")]
		private void CECPDIFHFIG(NativeArray<Entity> FOMMJLEICDI, NativeArray<RRObjectPrefabData> BJIJCMMGOKN, ref NativeArray<Entity> EKHJECGFOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2BC82C0", Offset = "0x2BC6CC0", VA = "0x182BC82C0")]
		internal void NDDLDJCGGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7EC0", Offset = "0x2BC68C0", VA = "0x182BC7EC0")]
		private void NDDLDJCGGGG(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6820", Offset = "0x2BC5220", VA = "0x182BC6820")]
		internal void IMFEJLKPDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7140", Offset = "0x2BC5B40", VA = "0x182BC7140")]
		private void KEJCJEEBBIO(DBNCKKCNGJJ BLJBLMCPLPH, OPLPBOKJNKG PAGFKHPKKBH, bool NFCFCKAGAJP, ref JobHandle OLKLNNNEFHL, ref JobHandle GHGACIMPAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6680", Offset = "0x2BC5080", VA = "0x182BC6680")]
		internal bool DKLMPNHJNHA(in OPLPBOKJNKG AALANACCLGM, out JobHandle ODMNDKFKJHN, out IFHANGOBDPE ACMPOMMGGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5C80", Offset = "0x2BC4680", VA = "0x182BC5C80")]
		private bool DKLMPNHJNHA(in OPLPBOKJNKG AALANACCLGM, bool NFCFCKAGAJP, out JobHandle ODMNDKFKJHN, out IFHANGOBDPE ACMPOMMGGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6F80", Offset = "0x2BC5980", VA = "0x182BC6F80")]
		internal (NativeList<int>, NativeList<int>) KDPLLCKOKLL(NativeList<JGGFKCAKJNP> PEGLPLKBCDI, int FHGNFGIEADL, JobHandle BAMHFDJJPAO, out JobHandle AHIGBHNJKNN, Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC66B0", Offset = "0x2BC50B0", VA = "0x182BC66B0")]
		internal static NativeArray<Entity> DNLJONLDHCE(EntityQuery AMEIGJPGLKK, out JobHandle LLLMIBOLDJD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8330", Offset = "0x2BC6D30", VA = "0x182BC8330")]
		internal static NativeArray<byte> OPJNCDPBIJI(int PPJLGCLGPJE, out JobHandle BMDDFOONLKG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7DB0", Offset = "0x2BC67B0", VA = "0x182BC7DB0")]
		internal static NativeArray<byte> MPDMMBPDNFF(EntityQuery AMEIGJPGLKK, int HIMMGNBBIHM, out JobHandle BMDDFOONLKG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8920", Offset = "0x2BC7320", VA = "0x182BC8920")]
		internal static NativeArray<Entity> PNONOLIOHMK(EntityQuery AMEIGJPGLKK, out JobHandle EPHHCLCDHAA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC86B0", Offset = "0x2BC70B0", VA = "0x182BC86B0")]
		internal NativeArray<byte> PAFBKNHDKBJ(NativeArray<Entity> IJBCECFNJIL, OPLPBOKJNKG PAGFKHPKKBH, JobHandle BAMHFDJJPAO, out JobHandle AHIGBHNJKNN, Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7C20", Offset = "0x2BC6620", VA = "0x182BC7C20")]
		internal JobHandle LOMGGHDHLLJ(in IFHANGOBDPE JIHCLPECHIB, in OPLPBOKJNKG PAGFKHPKKBH, NativeMultiHashMap<Entity, KCFNAMGFMNK> JODGBANCIIN, JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB060", Offset = "0x1FD9A60", VA = "0x181FDB060")]
		private JobHandle AMAIHJKEGHF(JobHandle ECECGDFDCNH, JobHandle IPPDCMIFCOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB060", Offset = "0x1FD9A60", VA = "0x181FDB060")]
		private JobHandle AMAIHJKEGHF(JobHandle ECECGDFDCNH, JobHandle IPPDCMIFCOL, JobHandle LOCNNLCCGAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B40780", Offset = "0x2B3F180", VA = "0x182B40780", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B40720", Offset = "0x2B3F120", VA = "0x182B40720", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B40750", Offset = "0x2B3F150", VA = "0x182B40750", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B407B0", Offset = "0x2B3F1B0", VA = "0x182B407B0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B40820", Offset = "0x2B3F220", VA = "0x182B40820", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B407C0", Offset = "0x2B3F1C0", VA = "0x182B407C0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x2B407F0", Offset = "0x2B3F1F0", VA = "0x182B407F0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B407B0", Offset = "0x2B3F1B0", VA = "0x182B407B0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B29F30", Offset = "0x2B28930", VA = "0x182B29F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B29FC0", Offset = "0x2B289C0", VA = "0x182B29FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public OKNOOGJABCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public PHMFDJLKCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7D4B0", Offset = "0x3E7BEB0", VA = "0x183E7D4B0")]
			public void KBLGIFLFDKL(KCGCJDJECHM AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x3E7D430", Offset = "0x3E7BE30", VA = "0x183E7D430")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E73550", Offset = "0x3E71F50", VA = "0x183E73550")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, SplinePointParentData IGAJPNPGFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E736E0", Offset = "0x3E720E0", VA = "0x183E736E0", Slot = "5")]
		public void ReadFromDisplayClass(ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E736F0", Offset = "0x3E720F0", VA = "0x183E736F0", Slot = "6")]
		public void WriteToDisplayClass(ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E73420", Offset = "0x3E71E20", VA = "0x183E73420", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E73630", Offset = "0x3E72030", VA = "0x183E73630")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref PPJHANKGAOK.HKJAFDCBHLE GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E734C0", Offset = "0x3E71EC0", VA = "0x183E734C0")]
		public void KBLGIFLFDKL(KCGCJDJECHM AJPOCCLBMGK, ref PHMFDJLKCEA IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E735C0", Offset = "0x3E71FC0", VA = "0x183E735C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1E950", Offset = "0x2F1D350", VA = "0x182F1E950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public KCGCJDJECHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E720", Offset = "0x2F1D120", VA = "0x182F1E720", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E5C0", Offset = "0x2F1CFC0", VA = "0x182F1E5C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B275E0", Offset = "0x2B25FE0", VA = "0x182B275E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B27670", Offset = "0x2B26070", VA = "0x182B27670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public NIDKPHMDOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(OKNOOGJABCA))]
public class NNIIEMAEFCL : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B27BD0", Offset = "0x2B265D0", VA = "0x182B27BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public NNIIEMAEFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public LPDPNOELMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E79190", Offset = "0x3E77B90", VA = "0x183E79190")]
			public void KBLGIFLFDKL(DGKJBIJADGO AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x3E79110", Offset = "0x3E77B10", VA = "0x183E79110")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D2CCD0", Offset = "0x2D2B6D0", VA = "0x182D2CCD0")]
		internal void KFDLFOBMEJP(Entity FLADPKIONGF, ObjectNetworkIdComponentData AMEIKDNDEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CE70", Offset = "0x2D2B870", VA = "0x182D2CE70", Slot = "5")]
		public void ReadFromDisplayClass(ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x277BEE0", Offset = "0x277A8E0", VA = "0x18277BEE0", Slot = "6")]
		public void WriteToDisplayClass(ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CC20", Offset = "0x2D2B620", VA = "0x182D2CC20", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CDC0", Offset = "0x2D2B7C0", VA = "0x182D2CDC0")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref LHMCLILFHIE.KFILMIEJOOB GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CC90", Offset = "0x2D2B690", VA = "0x182D2CC90")]
		public void KBLGIFLFDKL(DGKJBIJADGO AJPOCCLBMGK, ref LPDPNOELMKO IMEAEFOFEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CD50", Offset = "0x2D2B750", VA = "0x182D2CD50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD0C70", Offset = "0x2BCF670", VA = "0x182BD0C70", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0ED0", Offset = "0x2BCF8D0", VA = "0x182BD0ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public DGKJBIJADGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0CD0", Offset = "0x2BCF6D0", VA = "0x182BD0CD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0B10", Offset = "0x2BCF510", VA = "0x182BD0B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7ACA0", Offset = "0x3E796A0", VA = "0x183E7ACA0")]
			public void KBLGIFLFDKL(NDLONCCLEBM AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x3E7AC20", Offset = "0x3E79620", VA = "0x183E7AC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E76890", Offset = "0x3E75290", VA = "0x183E76890")]
		public void KFDLFOBMEJP(Entity FLADPKIONGF, ParentData INCKFPNOIFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E76770", Offset = "0x3E75170", VA = "0x183E76770", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E76920", Offset = "0x3E75320", VA = "0x183E76920")]
		public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref NABPGJACCPJ.EMHONEOJCOJ GDKNHFKHEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E76810", Offset = "0x3E75210", VA = "0x183E76810")]
		public void KBLGIFLFDKL(NDLONCCLEBM AJPOCCLBMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E768B0", Offset = "0x3E752B0", VA = "0x183E768B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B26E20", Offset = "0x2B25820", VA = "0x182B26E20", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B27080", Offset = "0x2B25A80", VA = "0x182B27080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public NDLONCCLEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B26C30", Offset = "0x2B25630", VA = "0x182B26C30")]
	[CompilerGenerated]
	private void BCJPKPENCCL(Entity FLADPKIONGF, ParentData INCKFPNOIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B26E80", Offset = "0x2B25880", VA = "0x182B26E80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AD0", Offset = "0x2B254D0", VA = "0x182B26AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F205A0", Offset = "0x2F1EFA0", VA = "0x182F205A0", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F205F0", Offset = "0x2F1EFF0", VA = "0x182F205F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F206D0", Offset = "0x2F1F0D0", VA = "0x182F206D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F20250", Offset = "0x2F1EC50", VA = "0x182F20250")]
	private void ICDDEHKPDMI(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public KPLIENFAMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3E790", Offset = "0x2B3D190", VA = "0x182B3E790", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E7E0", Offset = "0x2B3D1E0", VA = "0x182B3E7E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
			public LPOOBMJNANI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E733B0", Offset = "0x3E71DB0", VA = "0x183E733B0")]
				public void KBLGIFLFDKL(PostLoadInitializeNetworkId AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x3E73300", Offset = "0x3E71D00", VA = "0x183E73300")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E728D0", Offset = "0x3E712D0", VA = "0x183E728D0")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, int JMJIFFLHKMK, ref ObjectNetworkIdComponentData AMEIKDNDEPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x2D2CE70", Offset = "0x2D2B870", VA = "0x182D2CE70", Slot = "5")]
			public void ReadFromDisplayClass(ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x277BEE0", Offset = "0x277A8E0", VA = "0x18277BEE0", Slot = "6")]
			public void WriteToDisplayClass(ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x3E72740", Offset = "0x3E71140", VA = "0x183E72740", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x3E729D0", Offset = "0x3E713D0", VA = "0x183E729D0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref DCACJDGOIND.MEICIHILCDM GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x3E72830", Offset = "0x3E71230", VA = "0x183E72830")]
			public void KBLGIFLFDKL(PostLoadInitializeNetworkId AJPOCCLBMGK, ref LPOOBMJNANI IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x3E72960", Offset = "0x3E71360", VA = "0x183E72960")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F1B0", Offset = "0x2B3DBB0", VA = "0x182B3F1B0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F4B0", Offset = "0x2B3DEB0", VA = "0x182B3F4B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E9F0", Offset = "0x2B3D3F0", VA = "0x182B3E9F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E9F0", Offset = "0x2B3D3F0", VA = "0x182B3E9F0")]
		public void FHPOEBEBBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EAC0", Offset = "0x2B3D4C0", VA = "0x182B3EAC0")]
		private void FODIPOHKKJL(NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F550", Offset = "0x2B3DF50", VA = "0x182B3F550")]
		private void PDKGKDDNOPB(NativeHashMap<COEEIJJLOPG, Entity> BLDLHAOGGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F220", Offset = "0x2B3DC20", VA = "0x182B3F220", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F010", Offset = "0x2B3DA10", VA = "0x182B3F010")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F13960", Offset = "0x2F12360", VA = "0x182F13960", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2F139F0", Offset = "0x2F123F0", VA = "0x182F139F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public GHFCNJAKHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBF790", Offset = "0x2BBE190", VA = "0x182BBF790", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF900", Offset = "0x2BBE300", VA = "0x182BBF900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF600", Offset = "0x2BBE000", VA = "0x182BBF600")]
	private void JEAKLBDGLAC(NativeList<EntityArchetype> CGBHJDKNJLN, NativeHashMap<int, ABCENELPPGI> LDINHFJLBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEEC0", Offset = "0x2BBD8C0", VA = "0x182BBEEC0")]
	private Span<int> DFKHFDNDCHD(EntityArchetype HEFFAMIFPAM)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF830", Offset = "0x2BBE230", VA = "0x182BBF830")]
	private bool NMIJGFEDPDM(int HIMMGNBBIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF000", Offset = "0x2BBDA00", VA = "0x182BBF000")]
	private void EAAKFCOEKEC(NativeHashMap<int, ABCENELPPGI> LDINHFJLBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public BNOBBBKDDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F800", Offset = "0x2B3E200", VA = "0x182B3F800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FA80", Offset = "0x2B3E480", VA = "0x182B3FA80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
			public GKKONMNHANL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x2D30790", Offset = "0x2D2F190", VA = "0x182D30790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E79860", Offset = "0x3E78260", VA = "0x183E79860")]
			internal void KFDLFOBMEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x3E79A20", Offset = "0x3E78420", VA = "0x183E79A20", Slot = "5")]
			public void ReadFromDisplayClass(ref GKKONMNHANL IMEAEFOFEDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x3E79830", Offset = "0x3E78230", VA = "0x183E79830", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x3E79840", Offset = "0x3E78240", VA = "0x183E79840")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D381D0", Offset = "0x2D36BD0", VA = "0x182D381D0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x2D38230", Offset = "0x2D36C30", VA = "0x182D38230")]
		public JobHandle NNEMCMGIMIK(JobHandle BAMHFDJJPAO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x2D38270", Offset = "0x2D36C70", VA = "0x182D38270", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D38610", Offset = "0x2D37010", VA = "0x182D38610")]
		private bool PIFPLAGNNAP(JobHandle BAMHFDJJPAO, int HIMMGNBBIHM, out JobHandle OJPHDFDEEHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC22D0", Offset = "0x2BC0CD0", VA = "0x182BC22D0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public CECIJINLABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD3260", Offset = "0x2BD1C60", VA = "0x182BD3260", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public DNOBEGFCEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F143E0", Offset = "0x2F12DE0", VA = "0x182F143E0", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public GHJCKFNOCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B26940", Offset = "0x2B25340", VA = "0x182B26940", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public NAKNKCDHKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x69DAA0", Offset = "0x69C4A0", VA = "0x18069DAA0", Slot = "18")]
		get
		{
			return default(IGGCJBCLGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2B27BC0", Offset = "0x2B265C0", VA = "0x182B27BC0")]
	public LHDJJBKJBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC2910", Offset = "0x2BC1310", VA = "0x182BC2910", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public CJICNPGIEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class JHKPLCNPCJD : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public JHKPLCNPCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "18")]
		get
		{
			return default(IGGCJBCLGAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2B27BC0", Offset = "0x2B265C0", VA = "0x182B27BC0")]
	public NKJLHMKHPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F12390", Offset = "0x2F10D90", VA = "0x182F12390", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public FPMAILCKPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class DCPDKFEIFKP : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public DCPDKFEIFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class HLIMCOAJIGM : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public HLIMCOAJIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class ONMAKNPNCJM : CPOPPILPLCL
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public ONMAKNPNCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD5960", Offset = "0x2BD4360", VA = "0x182BD5960", Slot = "14")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD59B0", Offset = "0x2BD43B0", VA = "0x182BD59B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public DPOJGLGGHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D30520", Offset = "0x2D2EF20", VA = "0x182D30520", Slot = "4")]
			public void Execute(int EBBLFLFCHFB, TransformAccess HJLACGOIJCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x2D306E0", Offset = "0x2D2F0E0", VA = "0x182D306E0")]
			private bool IHMEMFNPKNA(float3 PNPBNOELPMC, float3 GLJCMMBCBOC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x2D30720", Offset = "0x2D2F120", VA = "0x182D30720")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D307A0", Offset = "0x2D2F1A0", VA = "0x182D307A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCBBD0", Offset = "0x2BCA5D0", VA = "0x182BCBBD0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBC40", Offset = "0x2BCA640", VA = "0x182BCBC40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBC70", Offset = "0x2BCA670", VA = "0x182BCBC70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E776E0", Offset = "0x3E760E0", VA = "0x183E776E0")]
				public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x3E77620", Offset = "0x3E76020", VA = "0x183E77620")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E74040", Offset = "0x3E72A40", VA = "0x183E74040")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, LBEPJEEIEEG EBNCDCCMBJP, Transform HJLACGOIJCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x3E73F40", Offset = "0x3E72940", VA = "0x183E73F40", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x3E741B0", Offset = "0x3E72BB0", VA = "0x183E741B0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, ref IAEHPIIMBLN.OPJMAGJLBAE GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x3E74030", Offset = "0x3E72A30", VA = "0x183E74030")]
			public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x3E74140", Offset = "0x3E72B40", VA = "0x183E74140")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E76580", Offset = "0x3E74F80", VA = "0x183E76580")]
				public void KBLGIFLFDKL(RegisterTransforms AJPOCCLBMGK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x3E777B0", Offset = "0x3E761B0", VA = "0x183E777B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E765E0", Offset = "0x3E74FE0", VA = "0x183E765E0")]
			internal void KFDLFOBMEJP(Entity FLADPKIONGF, LBEPJEEIEEG EBNCDCCMBJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x3E764F0", Offset = "0x3E74EF0", VA = "0x183E764F0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int LCDLJNKCNOD, int HJEIDPELCBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x3E766C0", Offset = "0x3E750C0", VA = "0x183E766C0")]
			public void MNJPFHMDBLJ(ref ArchetypeChunk ANLGKBAEBBF, [NoAlias] ref IFNIDGNIFFH.JBLMIOIDOBE GDKNHFKHEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x3E76580", Offset = "0x3E74F80", VA = "0x183E76580")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D31C20", Offset = "0x2D30620", VA = "0x182D31C20", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D31EE0", Offset = "0x2D308E0", VA = "0x182D31EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D320F0", Offset = "0x2D30AF0", VA = "0x182D320F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D321C0", Offset = "0x2D30BC0", VA = "0x182D321C0")]
		private void PFOCCHMDKAL(EntityQuery AMEIGJPGLKK, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x2D31010", Offset = "0x2D2FA10", VA = "0x182D31010")]
		private void DKFICCNNFML(EntityQuery AMEIGJPGLKK, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D32090", Offset = "0x2D30A90", VA = "0x182D32090", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x2D31280", Offset = "0x2D2FC80", VA = "0x182D31280")]
		private void FNFCPINBPLC(NativeArray<Entity> IJBCECFNJIL, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x2D31910", Offset = "0x2D30310", VA = "0x182D31910")]
		[BurstCompile]
		internal static void MIFACHPHIIB(NativeArray<LBEPJEEIEEG> AMMMMPFBOFD, ComponentDataFromEntity<LBEPJEEIEEG> BDCFFAPHCGM, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void DACFLNGAALO(Transform HJLACGOIJCA, Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void HFDEMKDAKJM(Entity FLADPKIONGF, int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void ILPDMAAGODC(int EBBLFLFCHFB, FMHLIBMOGNG LLBLAMCIJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x2D31730", Offset = "0x2D30130", VA = "0x182D31730")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void LFFOANCLOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x2D31C70", Offset = "0x2D30670", VA = "0x182D31C70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2D313C0", Offset = "0x2D2FDC0", VA = "0x182D313C0")]
		public static EntityQuery JCBPKAIIBJB(ComponentSystemBase AJPOCCLBMGK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D31560", Offset = "0x2D2FF60", VA = "0x182D31560")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D2F910", Offset = "0x2D2E310", VA = "0x182D2F910", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D30480", Offset = "0x2D2EE80", VA = "0x182D30480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D309C0", Offset = "0x2D2F3C0", VA = "0x182D309C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCC2A0", Offset = "0x2BCACA0", VA = "0x182BCC2A0", Slot = "14")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC2F0", Offset = "0x2BCACF0", VA = "0x182BCC2F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC4E0", Offset = "0x2BCAEE0", VA = "0x182BCC4E0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC570", Offset = "0x2BCAF70", VA = "0x182BCC570", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC5A0", Offset = "0x2BCAFA0", VA = "0x182BCC5A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC120", Offset = "0x2BCAB20", VA = "0x182BCC120")]
		private NativeArray<Entity> HHAKEINKCJB(NativeArray<LBEPJEEIEEG> BGLJHEFMNHL, NativeList<Entity> FOMMJLEICDI, TransformAccessArray NCEBCHFFMPF, TransformAccessArray GHJMGNMMHAK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3FE40", Offset = "0x2B3E840", VA = "0x182B3FE40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCED0", Offset = "0x2BCB8D0", VA = "0x182BCCED0", Slot = "14")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD200", Offset = "0x2BCBC00", VA = "0x182BCD200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCFE0", Offset = "0x2BCB9E0", VA = "0x182BCCFE0")]
		private static void HEGDJKAIPBP(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, Entity LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD160", Offset = "0x2BCBB60", VA = "0x182BCD160")]
		private static bool MKGOOONPMIK(EntityManager LNPEGOPJJGK, Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7CC00", Offset = "0x3E7B600", VA = "0x183E7CC00")]
			[Conditional("DEBUG_BUILD")]
			private void AAFNLOCCPHB(Entity FLADPKIONGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x3E7CCD0", Offset = "0x3E7B6D0", VA = "0x183E7CCD0", Slot = "4")]
			public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x3E7CFC0", Offset = "0x3E7B9C0", VA = "0x183E7CFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F21C00", Offset = "0x2F20600", VA = "0x182F21C00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x2F21D20", Offset = "0x2F20720", VA = "0x182F21D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E78E60", Offset = "0x3E77860", VA = "0x183E78E60", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x3E78DE0", Offset = "0x3E777E0", VA = "0x183E78DE0")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery PAKACLHMGLB;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC10", Offset = "0x2F1D610", VA = "0x182F1EC10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ED40", Offset = "0x2F1D740", VA = "0x182F1ED40", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public KCPCKDOPHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E7B370", Offset = "0x3E79D70", VA = "0x183E7B370", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B2F0", Offset = "0x3E79CF0", VA = "0x183E7B2F0")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery PJBANBJAEAL;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F1E0", Offset = "0x2F0DBE0", VA = "0x182F0F1E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F2F0", Offset = "0x2F0DCF0", VA = "0x182F0F2F0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0")]
	public FDNCHKLNEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E719E0", Offset = "0x3E703E0", VA = "0x183E719E0", Slot = "4")]
		public void Execute(ArchetypeChunk ANLGKBAEBBF, int EBBLFLFCHFB, int LBBDAMHJOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x3E71900", Offset = "0x3E70300", VA = "0x183E71900")]
		public bool CHICEPFNPLC(ArchetypeChunk ANLGKBAEBBF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery PJBANBJAEAL;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2B27340", Offset = "0x2B25D40", VA = "0x182B27340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x2B27470", Offset = "0x2B25E70", VA = "0x182B27470", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PJCPCKJAOAL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
	public NIANMMCNJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B408B0", Offset = "0x2B3F2B0", VA = "0x182B408B0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType FPMGPJGNKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x2B40850", Offset = "0x2B3F250", VA = "0x182B40850", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType CFBKJAFDBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x2B40880", Offset = "0x2B3F280", VA = "0x182B40880", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x2B407B0", Offset = "0x2B3F1B0", VA = "0x182B407B0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0xF469D0", Offset = "0xF453D0", VA = "0x180F469D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B294F0", Offset = "0x2B27EF0", VA = "0x182B294F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x2B29560", Offset = "0x2B27F60", VA = "0x182B29560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EE40", Offset = "0x2F1D840", VA = "0x182F1EE40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public KEKOKEGPFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class DFOKDPAKEAE : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0530", Offset = "0x2BCEF30", VA = "0x182BD0530", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public DFOKDPAKEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2F072A0", Offset = "0x2F05CA0", VA = "0x182F072A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public EGNKDAABNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class IJGDBPGDPGJ : OILIIHGJOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B750", Offset = "0x2F1A150", VA = "0x182F1B750", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public IJGDBPGDPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC24F0", Offset = "0x2BC0EF0", VA = "0x182BC24F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] GIBIOLDFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2560", Offset = "0x2BC0F60", VA = "0x182BC2560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBEB90", Offset = "0x2BBD590", VA = "0x182BBEB90", Slot = "4")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F0C950", Offset = "0x2F0B350", VA = "0x182F0C950", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C5C0", Offset = "0x2F0AFC0", VA = "0x182F0C5C0", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C900", Offset = "0x2F0B300", VA = "0x182F0C900")]
		public Entity NCMHOFMDGAH(Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C6C0", Offset = "0x2F0B0C0", VA = "0x182F0C6C0")]
		public bool EAIMLJHMGNG(Entity FLADPKIONGF, Entity EBIGGMLCEAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C9C0", Offset = "0x2F0B3C0", VA = "0x182F0C9C0")]
		public bool OGODNIIEFFB(Entity FLADPKIONGF, Entity EBIGGMLCEAF, bool KEKDECHAOMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C720", Offset = "0x2F0B120", VA = "0x182F0C720")]
		private bool FDDKBBILGLG(Entity FLADPKIONGF, Entity EBIGGMLCEAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F200D0", Offset = "0x2F1EAD0", VA = "0x182F200D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FDD0", Offset = "0x2F1E7D0", VA = "0x182F1FDD0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F8F0", Offset = "0x2F1E2F0", VA = "0x182F1F8F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FD10", Offset = "0x2F1E710", VA = "0x182F1FD10")]
	public bool LLHMMIJNOKL(Entity FLADPKIONGF, Entity EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FAE0", Offset = "0x2F1E4E0", VA = "0x182F1FAE0")]
	public IEnumerable<Entity> IPMINALCKNM(Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x2F20120", Offset = "0x2F1EB20", VA = "0x182F20120")]
	public bool PKNAJOGAKAI(Entity FLADPKIONGF, Entity IMDKOHMGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F5D0", Offset = "0x2F1DFD0", VA = "0x182F1F5D0")]
	public bool DNJHMIGKLJO(Entity FLADPKIONGF, Entity EOECNBNBJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FA00", Offset = "0x2F1E400", VA = "0x182F1FA00")]
	public NativeList<Entity> IEFPHBPMHJN(Entity FLADPKIONGF, bool NPBOCMDCJPH = false, Allocator GGLOKAHPEPM = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FED0", Offset = "0x2F1E8D0", VA = "0x182F1FED0")]
	public IEnumerable<Entity> OPILOIOFOMC(Entity FLADPKIONGF, bool NPBOCMDCJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FC60", Offset = "0x2F1E660", VA = "0x182F1FC60")]
	public Entity KCDNPIAEBEL(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F580", Offset = "0x2F1DF80", VA = "0x182F1F580")]
	public NativeArray<Entity> BMFAMGNJFCC()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F6D0", Offset = "0x2F1E0D0", VA = "0x182F1F6D0")]
	public bool DNKFCLNJCJP(Entity EOECNBNBJEC, Entity FNIMMJACBON, out Entity JFHEPJJAOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F910", Offset = "0x2F1E310", VA = "0x182F1F910")]
	private Entity ENNBBFIPAAI(Entity FLADPKIONGF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A0AE0", Offset = "0x279F4E0", VA = "0x1827A0AE0")]
		public static void IFEPEMKMGAF<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(PFKGIHKPIGG GOCENLCAMDB, global::AJFAFKBPGAH<Entity> MABBPMMEACO, out global::DNKHIOPKPFH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> FHDIHMMIHDJ) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, CGCOJDLBGDN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, CGCOJDLBGDN, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B360", Offset = "0x2B39D60", VA = "0x182B3B360")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EB6C80", Offset = "0x2EB5680", VA = "0x182EB6C80")]
	public DNKHIOPKPFH(PFKGIHKPIGG GOCENLCAMDB, global::AJFAFKBPGAH<Entity> MABBPMMEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5D10", Offset = "0x2EB4710", VA = "0x182EB5D10")]
	private bool AODOFDEGDAD(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6650", Offset = "0x2EB5050", VA = "0x182EB6650")]
	private bool NHDJFMHNIMI(Entity FLADPKIONGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6370", Offset = "0x2EB4D70", VA = "0x182EB6370")]
	public bool EAIMLJHMGNG(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5F00", Offset = "0x2EB4900", VA = "0x182EB5F00")]
	public bool BPHDFDMIMDE(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5F30", Offset = "0x2EB4930", VA = "0x182EB5F30")]
	private bool BPHDFDMIMDE(Entity FLADPKIONGF, in Entity EBIGGMLCEAF, bool PFOOECGMKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void AJLJKELCOFK(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void CKJMGGCNAOH(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void FHNPJBLFBDB(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void CNLFFFMDLLF(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private static void FAFNMDJEBFA(Entity FLADPKIONGF, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6490", Offset = "0x2EB4E90", VA = "0x182EB6490")]
	private bool LLHMMIJNOKL(Entity FLADPKIONGF, Entity EGGHGELDMAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2EB63A0", Offset = "0x2EB4DA0", VA = "0x182EB63A0")]
	private void GKHECDJEFEM(Entity FLADPKIONGF, in Entity KOEBMFNDCDN, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2EB67C0", Offset = "0x2EB51C0", VA = "0x182EB67C0")]
	private void PJIHAHONNIA(Entity FLADPKIONGF, in Entity KOEBMFNDCDN, in Entity EBIGGMLCEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5910", Offset = "0x2EB4310", VA = "0x182EB5910")]
	private bool ALPMOJCOLFG(ABGCOLIMINN BEKGLMLIAIJ, in COEEIJJLOPG CFCDMOHCLML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2EB5DD0", Offset = "0x2EB47D0", VA = "0x182EB5DD0")]
	private void APJHAKKKPLO(Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6730", Offset = "0x2EB5130", VA = "0x182EB6730")]
	private void OPJJCFHECII(Entity LFAIGCEGCPL, Entity IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	private void ILPDMAAGODC(Entity FLADPKIONGF, Entity KOEBMFNDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GMLHAACHBKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DAEE0", VA = "0x1806DC4E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2E370", Offset = "0x2B2CD70", VA = "0x182B2E370")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int DOOOPAJAEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DB40", Offset = "0x2B2C540", VA = "0x182B2DB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int JKMNPHCFCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x2B2BEA0", Offset = "0x2B2A8A0", VA = "0x182B2BEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x10AA3C0", Offset = "0x10A8DC0", VA = "0x1810AA3C0", Slot = "4")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DD80", Offset = "0x2B2C780", VA = "0x182B2DD80", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B650", Offset = "0x2B2A050", VA = "0x182B2B650")]
		public void BLGJNLFGPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B810", Offset = "0x2B2A210", VA = "0x182B2B810", Slot = "6")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BAB0", Offset = "0x2B2A4B0", VA = "0x182B2BAB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BA00", Offset = "0x2B2A400", VA = "0x182B2BA00")]
		public int DEIOFDOJNON(SceneTag FMEDCFLNIMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DEB0", Offset = "0x2B2C8B0", VA = "0x182B2DEB0")]
		public int NMPFPNGDBIL(SceneTag FMEDCFLNIMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D560", Offset = "0x2B2BF60", VA = "0x182B2D560")]
		public bool LDKHBOLKJMB(Entity FLADPKIONGF, Allocator GGLOKAHPEPM, out NativeList<Entity> FHECHPPDJGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D830", Offset = "0x2B2C230", VA = "0x182B2D830")]
		public bool LKJHLJGGMJG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DAD0", Offset = "0x2B2C4D0", VA = "0x182B2DAD0")]
		public bool LOMGEMGINNG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B750", Offset = "0x2B2A150", VA = "0x182B2B750")]
		public bool CDEJDKLJJPA(Entity FLADPKIONGF, out GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B6A0", Offset = "0x2B2A0A0", VA = "0x182B2B6A0")]
		private bool CDEJDKLJJPA(Transform HJLACGOIJCA, out GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E2D0", Offset = "0x2B2CCD0", VA = "0x182B2E2D0")]
		private void ONNODGLGOKJ(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D4F0", Offset = "0x2B2BEF0", VA = "0x182B2D4F0")]
		private bool KPKJJLDLPLG(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D190", Offset = "0x2B2BB90", VA = "0x182B2D190")]
		public void KOEBKPOFGOP(COEEIJJLOPG FBIBIHJENAB, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E3C0", Offset = "0x2B2CDC0", VA = "0x182B2E3C0")]
		public bool PCEBDKCDCEK(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AC40", Offset = "0x2B29640", VA = "0x182B2AC40")]
		public bool ADPNNHDPBFH(NIALADIPDNC KLCGNDEDAPD, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ABF0", Offset = "0x2B295F0", VA = "0x182B2ABF0")]
		public bool ADPNNHDPBFH(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ABD0", Offset = "0x2B295D0", VA = "0x182B2ABD0")]
		public bool ADPNNHDPBFH(GLICHKLIKDB EDNIAMBKPNL, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B180", Offset = "0x2B29B80", VA = "0x182B2B180")]
		public bool BJPKHDLNNBP(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B150", Offset = "0x2B29B50", VA = "0x182B2B150")]
		public bool BJPKHDLNNBP(GLICHKLIKDB NCAANBGOHJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A820", Offset = "0x2B29220", VA = "0x182B2A820")]
		public bool ADPNNHDPBFH(GLICHKLIKDB NCAANBGOHJP, [Optional] object HKLDIENGNNB, bool CBEIFKNKIIE = false, bool EIPNMJFHFCJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BD10", Offset = "0x2B2A710", VA = "0x182B2BD10")]
		public Transform FJAPHIONMLH(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DCB0", Offset = "0x2B2C6B0", VA = "0x182B2DCB0")]
		public bool MKGOOONPMIK(Entity FLADPKIONGF, out Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BBE0", Offset = "0x2B2A5E0", VA = "0x182B2BBE0")]
		public GLICHKLIKDB EGMFKDJNLKC(Entity FLADPKIONGF, [Optional] object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C560", Offset = "0x2B2AF60", VA = "0x182B2C560")]
		public void IHFDMGOCGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DEE0", Offset = "0x2B2C8E0", VA = "0x182B2DEE0")]
		public void NMPNNEJBCPI(SceneTag FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C010", Offset = "0x2B2AA10", VA = "0x182B2C010")]
		private void IAFGBHBNPNB(Entity FLADPKIONGF, bool POFNLFLHCKJ, bool OJLHMJCOGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B0B0", Offset = "0x2B29AB0", VA = "0x182B2B0B0")]
		private void BHPHHKOBFHM(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP, bool POFNLFLHCKJ, bool OJLHMJCOGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A7D0", Offset = "0x2B291D0", VA = "0x182B2A7D0")]
		public GLICHKLIKDB ADLDJPPEBIA(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BA30", Offset = "0x2B2A430", VA = "0x182B2BA30")]
		public bool DPKIDNMHHHJ(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CCA0", Offset = "0x2B2B6A0", VA = "0x182B2CCA0")]
		public bool JGABPGKHJJO(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BE30", Offset = "0x2B2A830", VA = "0x182B2BE30")]
		public bool GCEGADAHECD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DB70", Offset = "0x2B2C570", VA = "0x182B2DB70")]
		public bool MHNBBGFCOPH(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DBE0", Offset = "0x2B2C5E0", VA = "0x182B2DBE0")]
		public bool MHNBBGFCOPH(GMLHAACHBKL ODMNDKFKJHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LAHMKEKFIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AFF0", Offset = "0x2B299F0", VA = "0x182B2AFF0")]
		private void AOBNDJBBLAD(bool MALFJDJBPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BC80", Offset = "0x2B2A680", VA = "0x182B2BC80")]
		private bool ELOHJKCBJOM(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B960", Offset = "0x2B2A360", VA = "0x182B2B960")]
		private GLICHKLIKDB CPKGOOIFDFG(Entity FLADPKIONGF, object HKLDIENGNNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C370", Offset = "0x2B2AD70", VA = "0x182B2C370")]
		private GLICHKLIKDB IAJPAAIOOBB(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CD20", Offset = "0x2B2B720", VA = "0x182B2CD20")]
		private (Vector3, Quaternion, Vector3) JLOPOEDOLCD(Entity FLADPKIONGF)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2C810", Offset = "0x2B2B210", VA = "0x182B2C810")]
		private void IIJCJHGLNME(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BED0", Offset = "0x2B2A8D0", VA = "0x182B2BED0")]
		private void GHKEFMLJFKB(NIALADIPDNC KLCGNDEDAPD, GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D3D0", Offset = "0x2B2BDD0", VA = "0x182B2D3D0")]
		private void KOEHHMGCCKN(GLICHKLIKDB CJGEEPGCHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CA40", Offset = "0x2B2B440", VA = "0x182B2CA40")]
		private void JDCPBPPANJP(GLICHKLIKDB NCAANBGOHJP, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CF40", Offset = "0x2B2B940", VA = "0x182B2CF40")]
		private void KAMFEGPDENH(Entity FLADPKIONGF, GLICHKLIKDB NCAANBGOHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B570", Offset = "0x2B29F70", VA = "0x182B2B570")]
		private void BLFPMBLHEKE(Entity FLADPKIONGF, Transform HJLACGOIJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D800", Offset = "0x2B2C200", VA = "0x182B2D800")]
		private NIALADIPDNC LKDLNANKINH(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E7D0", Offset = "0x2B2D1D0", VA = "0x182B2E7D0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2B2BF40", Offset = "0x2B2A940", VA = "0x182B2BF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1E100", Offset = "0x2F1CB00", VA = "0x182F1E100")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2FD70", Offset = "0x2B2E770", VA = "0x182B2FD70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, HLEPLICHNKK> KHMHAFFAPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F110", Offset = "0x2B2DB10", VA = "0x182B2F110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x2B2EF10", Offset = "0x2B2D910", VA = "0x182B2EF10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> KNNJPCNCMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F1B0", Offset = "0x2B2DBB0", VA = "0x182B2F1B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FA30", Offset = "0x2B2E430", VA = "0x182B2FA30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FAD0", Offset = "0x2B2E4D0", VA = "0x182B2FAD0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x82C9E0", Offset = "0x82B3E0", VA = "0x18082C9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F090", Offset = "0x2B2DA90", VA = "0x182B2F090")]
		public bool DPFPNIAFGMD(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F250", Offset = "0x2B2DC50", VA = "0x182B2F250")]
		internal void FAKINIFECHA(Entity FLADPKIONGF, HLEPLICHNKK IGDDGFIHFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F050", Offset = "0x2B2DA50", VA = "0x182B2F050")]
		public void CGLPGHAHONL(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EFB0", Offset = "0x2B2D9B0", VA = "0x182B2EFB0")]
		public void BEJINFJIIKP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F4B0", Offset = "0x2B2DEB0", VA = "0x182B2F4B0")]
		private bool HLDMFBLKEKJ(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F2B0", Offset = "0x2B2DCB0", VA = "0x182B2F2B0")]
		public void GGPEMOPMMCE(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FBB0", Offset = "0x2B2E5B0", VA = "0x182B2FBB0")]
		private bool PAIMHOKHDJB(Entity FLADPKIONGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FDC0", Offset = "0x2B2E7C0", VA = "0x182B2FDC0")]
		public void PDCINDJGKMO(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F7D0", Offset = "0x2B2E1D0", VA = "0x182B2F7D0")]
		private void JLGCLDPLICM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F570", Offset = "0x2B2DF70", VA = "0x182B2F570")]
		private void IPDMIPACPCE(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F000", Offset = "0x2B2DA00", VA = "0x182B2F000")]
		public void CAHDAIHLDPP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private void PFDMJBBMDNB(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F830", Offset = "0x2B2E230", VA = "0x182B2F830")]
		private void KHEHKDLFPGP(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2192790", Offset = "0x2191190", VA = "0x182192790", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E78560", Offset = "0x3E76F60", VA = "0x183E78560", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x3E75800", Offset = "0x3E74200", VA = "0x183E75800")]
			[DebuggerHidden]
			public KAMLJEPKJMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x3E78380", Offset = "0x3E76D80", VA = "0x183E78380", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x3E78520", Offset = "0x3E76F20", VA = "0x183E78520", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x3E78480", Offset = "0x3E76E80", VA = "0x183E78480", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(KFKBMIIJOHI, HLEPLICHNKK)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x3E78480", Offset = "0x3E76E80", VA = "0x183E78480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B33470", Offset = "0x2B31E70", VA = "0x182B33470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x2B33A20", Offset = "0x2B32420", VA = "0x182B33A20")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x2B334C0", Offset = "0x2B31EC0", VA = "0x182B334C0", Slot = "5")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x2B326F0", Offset = "0x2B310F0", VA = "0x182B326F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x2B32350", Offset = "0x2B30D50", VA = "0x182B32350")]
		internal IEnumerable<Type> AIKIDOGMPDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x2B323B0", Offset = "0x2B30DB0", VA = "0x182B323B0")]
		internal ECJOKHEDOAA CHCGKGOLMGL(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x2B330C0", Offset = "0x2B31AC0", VA = "0x182B330C0")]
		public EntityArchetype JCGKNAGCLPO(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x2B33A40", Offset = "0x2B32440", VA = "0x182B33A40")]
		public NativeHashMap<int, EntityArchetype> PKKFLMODMLN(Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2B32FE0", Offset = "0x2B319E0", VA = "0x182B32FE0")]
		public bool GJMFCBMMONL(HLEPLICHNKK IGDDGFIHFCA, out EntityArchetype HEFFAMIFPAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x2B33050", Offset = "0x2B31A50", VA = "0x182B33050", Slot = "4")]
		[IteratorStateMachine(typeof(KAMLJEPKJMP))]
		public IEnumerable<(KFKBMIIJOHI, HLEPLICHNKK)> IGFEMMPCLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2B338A0", Offset = "0x2B322A0", VA = "0x182B338A0")]
		public Entity NEEHFODMFJK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2B33120", Offset = "0x2B31B20", VA = "0x182B33120")]
		public HLEPLICHNKK JJGMBAPGGMB(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B33180", Offset = "0x2B31B80", VA = "0x182B33180")]
		public HLEPLICHNKK JJGMBAPGGMB(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(HLEPLICHNKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B32580", Offset = "0x2B30F80", VA = "0x182B32580")]
		public NativeHashMap<int, Entity> DKBOELLMGNP(Allocator GGLOKAHPEPM = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B40", Offset = "0x2B31540", VA = "0x182B32B40")]
		public IEnumerable<HLEPLICHNKK> FPMKKFAPLCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2B331E0", Offset = "0x2B31BE0", VA = "0x182B331E0")]
		public Entity KHPNNFFFMMF(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2B339B0", Offset = "0x2B323B0", VA = "0x182B339B0")]
		public bool OABIHIPJEOM(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B90", Offset = "0x2B31590", VA = "0x182B32B90")]
		private void GGMCAIKPMHI(ECJOKHEDOAA EOKLIJEFLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2B33240", Offset = "0x2B31C40", VA = "0x182B33240")]
		internal void LJPJPIAEMKN(HLEPLICHNKK IGDDGFIHFCA, ODIEFIPMBGL BGIKBILIONK, KPCPJNHBGBE OALIMJPCECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2B32420", Offset = "0x2B30E20", VA = "0x182B32420")]
		private void CJGANCNIHHI(HLEPLICHNKK IGDDGFIHFCA, ODIEFIPMBGL NEOKJGOPJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2B32A20", Offset = "0x2B31420", VA = "0x182B32A20")]
		internal Entity EJPPNCDBCKD(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x2B33C10", Offset = "0x2B32610", VA = "0x182B33C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB7730", Offset = "0x2BB6130", VA = "0x182BB7730", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private PIFFPMLCLFK OEDOBIJLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7A20", Offset = "0x2BB6420", VA = "0x182BB7A20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private APMEOIGEMKF KNPKJOFKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x68BD40", Offset = "0x68A740", VA = "0x18068BD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, KCFNAMGFMNK> HAOFLGCDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x698030", Offset = "0x696A30", VA = "0x180698030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, KCFNAMGFMNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle PPHGFACFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x137ADD0", Offset = "0x13797D0", VA = "0x18137ADD0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x137AE50", Offset = "0x1379850", VA = "0x18137AE50", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool HHHGMLLGHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7830", Offset = "0x2BB6230", VA = "0x182BB7830", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World KFFLEJJCAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7980", Offset = "0x2BB6380", VA = "0x182BB7980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7E40", Offset = "0x2BB6840", VA = "0x182BB7E40")]
	public ABPLGJHCONF(PBIGHLIMKNA MNNGMBKBGHB, IGGCJBCLGAF CBBKLGMGPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7970", Offset = "0x2BB6370", VA = "0x182BB7970", Slot = "11")]
	private void IJEKODECJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7880", Offset = "0x2BB6280", VA = "0x182BB7880", Slot = "10")]
	private bool IBJBGMLIKFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7080", Offset = "0x2BB5A80", VA = "0x182BB7080", Slot = "12")]
	private void BMNDOEHKGKM(ComponentType ALGBEENOGLE, in IFHANGOBDPE JDHBAMAGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7010", Offset = "0x2BB5A10", VA = "0x182BB7010", Slot = "13")]
	private bool APKFDCIPKJK(HLEPLICHNKK IGDDGFIHFCA, out Entity BHIKNMNBHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7790", Offset = "0x2BB6190", VA = "0x182BB7790", Slot = "16")]
	private bool EOPALPCLELJ(out NativeArray<int> DFCIIJDJCIO, Allocator GGLOKAHPEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7170", Offset = "0x2BB5B70", VA = "0x182BB7170", Slot = "17")]
	private bool CIBIOHKLOEC(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI, out OPLPBOKJNKG PAGFKHPKKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2BB72F0", Offset = "0x2BB5CF0", VA = "0x182BB72F0", Slot = "18")]
	private bool CIBIOHKLOEC(ComponentType ALGBEENOGLE, out IFHANGOBDPE LFDDAFOFBOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7640", Offset = "0x2BB6040", VA = "0x182BB7640", Slot = "19")]
	private IFHANGOBDPE DDLCKPJMPMA(ComponentType ALGBEENOGLE)
	{
		return default(IFHANGOBDPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x2BB79E0", Offset = "0x2BB63E0", VA = "0x182BB79E0", Slot = "20")]
	private LBOLGJICLNI KDOPIGEFLKJ()
	{
		return default(LBOLGJICLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7840", Offset = "0x2BB6240", VA = "0x182BB7840", Slot = "21")]
	private void IBCGKELIMGK(JobHandle AHIGBHNJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7A40", Offset = "0x2BB6440", VA = "0x182BB7A40")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7420", Offset = "0x2BB5E20", VA = "0x182BB7420")]
	private bool DBBEEMBPGLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7CF0", Offset = "0x2BB66F0", VA = "0x182BB7CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B369D0", Offset = "0x2B353D0", VA = "0x182B369D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PIFFPMLCLFK MOKNNLHOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7D3E0", Offset = "0x3E7BDE0", VA = "0x183E7D3E0")]
			public PJBMKGIJBGF(PropertyDiffStateService AGMOENMHCDB, IGGCJBCLGAF AEBMIONNBAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x3E7D3C0", Offset = "0x3E7BDC0", VA = "0x183E7D3C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public ACMLCBMOLDA ADKKLDBJCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x2B417B0", Offset = "0x2B401B0", VA = "0x182B417B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public DBNCKKCNGJJ KCKLPJGBINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x2B417B0", Offset = "0x2B401B0", VA = "0x182B417B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7880", Offset = "0x8D6280", VA = "0x1808D7880")]
		public ACMLCBMOLDA ODIPNEBMFLM(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7880", Offset = "0x8D6280", VA = "0x1808D7880")]
		public DBNCKKCNGJJ NLKIFHPCKGJ(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x2B41C50", Offset = "0x2B40650", VA = "0x182B41C50", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x2B41810", Offset = "0x2B40210", VA = "0x182B41810", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2B41CD0", Offset = "0x2B406D0", VA = "0x182B41CD0")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x2B41B70", Offset = "0x2B40570", VA = "0x182B41B70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x2B417F0", Offset = "0x2B401F0", VA = "0x182B417F0")]
		public PJBMKGIJBGF AOBFHDIGADL(IGGCJBCLGAF CBBKLGMGPCP)
		{
			return default(PJBMKGIJBGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x2B41D80", Offset = "0x2B40780", VA = "0x182B41D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D32CB0", Offset = "0x2D316B0", VA = "0x182D32CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> EGHGGMHHILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x120D070", Offset = "0x120BA70", VA = "0x18120D070")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x18B2980", Offset = "0x18B1380", VA = "0x1818B2980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity LCMKEANPPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x2D335C0", Offset = "0x2D31FC0", VA = "0x182D335C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag AIKKNEDCIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x2D326F0", Offset = "0x2D310F0", VA = "0x182D326F0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity GDJEHHMMMIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x2D326F0", Offset = "0x2D310F0", VA = "0x182D326F0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x2D34190", Offset = "0x2D32B90", VA = "0x182D34190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x2D34200", Offset = "0x2D32C00", VA = "0x182D34200")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D33EE0", Offset = "0x2D328E0", VA = "0x182D33EE0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x2D32EE0", Offset = "0x2D318E0", VA = "0x182D32EE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x2D32C70", Offset = "0x2D31670", VA = "0x182D32C70")]
		public void BIPEFLGPOBF(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D32C40", Offset = "0x2D31640", VA = "0x182D32C40")]
		public NativeArray<Entity> BCMNJFKEPBC(Allocator GGLOKAHPEPM = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D33290", Offset = "0x2D31C90", VA = "0x182D33290")]
		public void GIKIHGNHOPB(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D33FC0", Offset = "0x2D329C0", VA = "0x182D33FC0")]
		public Entity NGIDDMAIDKI(string NBODBMLPNJA = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D337E0", Offset = "0x2D321E0", VA = "0x182D337E0")]
		public void JIGOEGAAMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D32AF0", Offset = "0x2D314F0", VA = "0x182D32AF0")]
		public void AJNEIPBAHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D33CC0", Offset = "0x2D326C0", VA = "0x182D33CC0")]
		public void LCCFICPMDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D33D20", Offset = "0x2D32720", VA = "0x182D33D20")]
		public void LNOFBFCGGKG(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2D32E30", Offset = "0x2D31830", VA = "0x182D32E30")]
		public bool DCHJKCLCEGK(Entity FMEDCFLNIMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2D34040", Offset = "0x2D32A40", VA = "0x182D34040")]
		public void OGOFCMMEMDL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2D32D00", Offset = "0x2D31700", VA = "0x182D32D00")]
		public string CBDHMGCPFDO(Entity FMEDCFLNIMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		public void JJNIPCJIADI(Entity FMEDCFLNIMM, string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2D32E10", Offset = "0x2D31810", VA = "0x182D32E10")]
		public bool CLOPMPMADBP(string NBODBMLPNJA, out Entity FMEDCFLNIMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D34050", Offset = "0x2D32A50", VA = "0x182D34050")]
		public void OILHIIEHIEG(Entity FMEDCFLNIMM, bool BGIKBDOCDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D330B0", Offset = "0x2D31AB0", VA = "0x182D330B0")]
		public void GAJOMFADMDA(Entity FLADPKIONGF, bool MFCDCBMLNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D33130", Offset = "0x2D31B30", VA = "0x182D33130")]
		public void GAJOMFADMDA(NativeArray<Entity> IJBCECFNJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D331A0", Offset = "0x2D31BA0", VA = "0x182D331A0")]
		public void GAJOMFADMDA(EntityQuery AMEIGJPGLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D33A90", Offset = "0x2D32490", VA = "0x182D33A90")]
		public void KHPLLHCLNNL(Entity FLADPKIONGF, Entity FMEDCFLNIMM, bool MFCDCBMLNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x2D33800", Offset = "0x2D32200", VA = "0x182D33800")]
		public void KHPLLHCLNNL(NativeArray<Entity> IJBCECFNJIL, Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x2D339E0", Offset = "0x2D323E0", VA = "0x182D339E0")]
		public void KHPLLHCLNNL(EntityQuery AMEIGJPGLKK, Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x2D33D30", Offset = "0x2D32730", VA = "0x182D33D30")]
		private void MCGBBNKCOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x2D34160", Offset = "0x2D32B60", VA = "0x182D34160")]
		private void OKMLLHDGLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x2D335C0", Offset = "0x2D31FC0", VA = "0x182D335C0")]
		private Entity NBJLHEFAHEA()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2D32B30", Offset = "0x2D31530", VA = "0x182D32B30")]
		private void AKLBHFNGFIL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2D32740", Offset = "0x2D31140", VA = "0x182D32740")]
		private void AEDDIIIEJBL(EntityQuery PHFFFDIHFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2D32810", Offset = "0x2D31210", VA = "0x182D32810")]
		private void AEDDIIIEJBL(NativeArray<Entity> LLLBMIKLOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2D34250", Offset = "0x2D32C50", VA = "0x182D34250")]
		private void PEEHCJCKGGM(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2D32F20", Offset = "0x2D31920", VA = "0x182D32F20")]
		private void EDNHGNLLJEL(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2D33740", Offset = "0x2D32140", VA = "0x182D33740")]
		private void JAKKDKMHLDA(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2D32B10", Offset = "0x2D31510", VA = "0x182D32B10")]
		private void AJPOOGOKIIB(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2D33430", Offset = "0x2D31E30", VA = "0x182D33430")]
		private void IACKDCODBGB(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2D33390", Offset = "0x2D31D90", VA = "0x182D33390")]
		private void IAANBNJHEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x381F380", Offset = "0x381DD80", VA = "0x18381F380")]
		private void IPMLJNKBEKN<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void AJGJEODNOJH(SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2D32BE0", Offset = "0x2D315E0", VA = "0x182D32BE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BBPHNGBIGLB(EntityQuery AMEIGJPGLKK, string NBODBMLPNJA, SceneTag NOKJLFDBBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D33710", Offset = "0x2D32110", VA = "0x182D33710")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void INODCEGMEEN(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GDIOABOKJJM(Entity FMEDCFLNIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D420C0", Offset = "0x2D40AC0", VA = "0x182D420C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D42030", Offset = "0x2D40A30", VA = "0x182D42030", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D41C60", Offset = "0x2D40660", VA = "0x182D41C60", Slot = "5")]
		public void BIPEFLGPOBF(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2D41E40", Offset = "0x2D40840", VA = "0x182D41E40", Slot = "6")]
		public bool JPFJKODKFPO(NIALADIPDNC KLCGNDEDAPD, Transform HJLACGOIJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2D41DD0", Offset = "0x2D407D0", VA = "0x182D41DD0")]
		private bool IDKMPGBKOPF(Scene FMEDCFLNIMM, out Entity MOEJBLMOECD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2D42110", Offset = "0x2D40B10", VA = "0x182D42110")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D38E80", Offset = "0x2D37880", VA = "0x182D38E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity LHEGNCBACAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager BPLKCGNFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x2D38F00", Offset = "0x2D37900", VA = "0x182D38F00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3820CB0", Offset = "0x381F6B0", VA = "0x183820CB0")]
		public T DNJGGIFCOKL<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3820D70", Offset = "0x381F770", VA = "0x183820D70")]
		public void KMNEKDAGPNL<T>(T MAKFNMHIJIF) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2D38E90", Offset = "0x2D37890", VA = "0x182D38E90", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2D38970", Offset = "0x2D37370", VA = "0x182D38970", Slot = "5")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2D38970", Offset = "0x2D37370", VA = "0x182D38970")]
		private void OJHANNIJMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2D38B10", Offset = "0x2D37510", VA = "0x182D38B10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2D38F50", Offset = "0x2D37950", VA = "0x182D38F50")]
		private ODIEFIPMBGL PPMIBKNMMJE()
		{
			return default(ODIEFIPMBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void FFJIFHNHNDC(int FPLNDBJJHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		private static void AIPGFAKCFNH(Type MCLMFJEAHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2D38DE0", Offset = "0x2D377E0", VA = "0x182D38DE0")]
		private static void LHANEBOBBHF(Type MCLMFJEAHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KGGBBDKCFNK NHMJJOEDBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KGGBBDKCFNK GLAACLCDFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KGGBBDKCFNK IJJBPGLCILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KGGBBDKCFNK BCHLNGKMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KGGBBDKCFNK OKFNDMOLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager BPLKCGNFBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E320", Offset = "0x2F1CD20", VA = "0x182F1E320")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E210", Offset = "0x2F1CC10", VA = "0x182F1E210", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E120", Offset = "0x2F1CB20", VA = "0x182F1E120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x22A0440", Offset = "0x229EE40", VA = "0x1822A0440")]
	private void IFEPEMKMGAF<T>(ref global::BHECHFLOHKD<T> JDMFCLOEMNK) where T : struct, FEHJDGBIBFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x22A0440", Offset = "0x229EE40", VA = "0x1822A0440")]
	private void IFEPEMKMGAF<TC, TV>(ref global::MBBKMHEBCCI<TC, TV> JDMFCLOEMNK) where TC : struct, FEHJDGBIBFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E24CD0", Offset = "0x1E236D0", VA = "0x181E24CD0")]
		get
		{
			return default(FMHLIBMOGNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x2F11360", Offset = "0x2F0FD60", VA = "0x182F11360", Slot = "4")]
	public void KDODMFBCLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x2F11350", Offset = "0x2F0FD50", VA = "0x182F11350", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E72AC0", Offset = "0x3E714C0", VA = "0x183E72AC0")]
			public CFJMCMGIOLO(TransformOwnershipPhase LFAIGCEGCPL, OBKMOHGGCNJ CBBKLGMGPCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x3E72AA0", Offset = "0x3E714A0", VA = "0x183E72AA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
			get
			{
				return default(OBKMOHGGCNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696930", VA = "0x180697F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool LGOELJFGMLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xBDF8D0", Offset = "0xBDE2D0", VA = "0x180BDF8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool IOIHOMFBMLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x14107C0", Offset = "0x140F1C0", VA = "0x1814107C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C510", Offset = "0x2D3AF10", VA = "0x182D3C510")]
		public CFJMCMGIOLO CDAKBFPMONP()
		{
			return default(CFJMCMGIOLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x2D3C540", Offset = "0x2D3AF40", VA = "0x182D3C540")]
		public CFJMCMGIOLO GPNHMENDIHO()
		{
			return default(CFJMCMGIOLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BC4DD0", Offset = "0x2BC37D0", VA = "0x182BC4DD0", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4AA0", Offset = "0x2BC34A0", VA = "0x182BC4AA0", Slot = "5")]
		public bool INGMIMILKOE(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3E50", Offset = "0x2BC2850", VA = "0x182BC3E50", Slot = "7")]
		public Guid EEBKLLIBFNG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4840", Offset = "0x2BC3240", VA = "0x182BC4840", Slot = "8")]
		public void HAEMNFBLNCF(NIALADIPDNC KLCGNDEDAPD, Guid DNKCIBPKEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4770", Offset = "0x2BC3170", VA = "0x182BC4770", Slot = "9")]
		public Guid GIMMENNNGFB(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2BC40F0", Offset = "0x2BC2AF0", VA = "0x182BC40F0", Slot = "10")]
		public void FAADICJIPMG(NIALADIPDNC KLCGNDEDAPD, Guid LLKHAPMPGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4BA0", Offset = "0x2BC35A0", VA = "0x182BC4BA0", Slot = "11")]
		public bool JEBOCGPANOM(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4BF0", Offset = "0x2BC35F0", VA = "0x182BC4BF0", Slot = "12")]
		public void JJJBCENALGA(NIALADIPDNC KLCGNDEDAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4350", Offset = "0x2BC2D50", VA = "0x182BC4350", Slot = "13")]
		public void FCCMJCHDFKO(NIALADIPDNC BIPEBBMCHLH, NIALADIPDNC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4C60", Offset = "0x2BC3660", VA = "0x182BC4C60")]
		private void JJNHJCJEJFL(MMELFMPPKGG KCNCLFLFKKF, NIALADIPDNC LFAIGCEGCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4E70", Offset = "0x2BC3870", VA = "0x182BC4E70")]
		private void PINBACBOIGG(MMELFMPPKGG KCNCLFLFKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3F20", Offset = "0x2BC2920", VA = "0x182BC3F20")]
		private bool FAABIMAMNAH(INPNGJHLELG LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x2BC5000", Offset = "0x2BC3A00", VA = "0x182BC5000")]
		private bool PJEFNKJKDFF(INPNGJHLELG LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4710", Offset = "0x2BC3110", VA = "0x182BC4710", Slot = "6")]
		public bool FPMOALBAMLP(NIALADIPDNC EHLCJHMJBBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D2F750", Offset = "0x2D2E150", VA = "0x182D2F750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0xA97B60", Offset = "0xA96560", VA = "0x180A97B60")]
			[DebuggerHidden]
			public GGMIEHEGPKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F7A0", Offset = "0x2D2E1A0", VA = "0x182D2F7A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F360", Offset = "0x2D2DD60", VA = "0x182D2F360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F870", Offset = "0x2D2E270", VA = "0x182D2F870")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F8C0", Offset = "0x2D2E2C0", VA = "0x182D2F8C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F710", Offset = "0x2D2E110", VA = "0x182D2F710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F660", Offset = "0x2D2E060", VA = "0x182D2F660", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NIALADIPDNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x2D2F660", Offset = "0x2D2E060", VA = "0x182D2F660", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x68D750", Offset = "0x68C150", VA = "0x18068D750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4E0", Offset = "0x7A8EE0", VA = "0x1807AA4E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<NIALADIPDNC, NIALADIPDNC> CEANFDAHFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA030", Offset = "0x2BC8A30", VA = "0x182BCA030", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9CB0", Offset = "0x2BC86B0", VA = "0x182BC9CB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<NIALADIPDNC, NIALADIPDNC> GCLMAEDFBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9F90", Offset = "0x2BC8990", VA = "0x182BC9F90", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9E50", Offset = "0x2BC8850", VA = "0x182BC9E50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<NIALADIPDNC, NIALADIPDNC, NIALADIPDNC> IBHGFANEMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA390", Offset = "0x2BC8D90", VA = "0x182BCA390", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9030", Offset = "0x2BC7A30", VA = "0x182BC9030", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<NIALADIPDNC> KFBEHNEIABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x2BC9EF0", Offset = "0x2BC88F0", VA = "0x182BC9EF0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x2BC8F90", Offset = "0x2BC7990", VA = "0x182BC8F90", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA710", Offset = "0x2BC9110", VA = "0x182BCA710", Slot = "25")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2BC90D0", Offset = "0x2BC7AD0", VA = "0x182BC90D0", Slot = "26")]
		public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9920", Offset = "0x2BC8320", VA = "0x182BC9920", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9AD0", Offset = "0x2BC84D0", VA = "0x182BC9AD0")]
		private void ECPCAAJAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA220", Offset = "0x2BC8C20", VA = "0x182BCA220")]
		private void LAMNODKAJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8DD0", Offset = "0x2BC77D0", VA = "0x182BC8DD0")]
		private void AHLGGPGIMFF(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA6B0", Offset = "0x2BC90B0", VA = "0x182BCA6B0")]
		private void MGDLJFOBBDK(Entity FLADPKIONGF, HDFAPEIIIAK DPEKNLAIHMP, COGGJKLIPPL GLJCMMBCBOC, COGGJKLIPPL PNPBNOELPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB060", Offset = "0x1FD9A60", VA = "0x181FDB060", Slot = "14")]
		public NIALADIPDNC KNHPHOJOCLN(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x135E3E0", Offset = "0x135CDE0", VA = "0x18135E3E0", Slot = "15")]
		public Color IABFALGIHIC(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA9D0", Offset = "0x2BC93D0", VA = "0x182BCA9D0", Slot = "16")]
		public float3 PEGMMOELKJL(NIALADIPDNC KLCGNDEDAPD, int PKEGBMBNNJK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA920", Offset = "0x2BC9320", VA = "0x182BCA920", Slot = "17")]
		public bool OEAGDOKEHIM(NIALADIPDNC KLCGNDEDAPD, NIALADIPDNC NAIPJHKFJBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA0D0", Offset = "0x2BC8AD0", VA = "0x182BCA0D0", Slot = "18")]
		public NIALADIPDNC HIHPEPPJJPP(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9570", Offset = "0x2BC7F70", VA = "0x182BC9570", Slot = "21")]
		public void COLJKODFFFJ(NIALADIPDNC KLCGNDEDAPD, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA180", Offset = "0x2BC8B80", VA = "0x182BCA180", Slot = "23")]
		public float3 JHAGHBBDDPF(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA890", Offset = "0x2BC9290", VA = "0x182BCA890", Slot = "24")]
		public quaternion NJFMIOKMKJD(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9D50", Offset = "0x2BC8750", VA = "0x182BC9D50", Slot = "28")]
		public RigidTransform GBLJMBFFBIM(EFPPOJIIAJN JEDGMEJHFGK)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9B30", Offset = "0x2BC8530", VA = "0x182BC9B30", Slot = "22")]
		public bool ENKIJIDCIHL(NIALADIPDNC KLCGNDEDAPD, out RigidTransform CNCDAEGBHHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9890", Offset = "0x2BC8290", VA = "0x182BC9890", Slot = "19")]
		[IteratorStateMachine(typeof(GGMIEHEGPKG))]
		public IEnumerable<NIALADIPDNC> DHAKAFDGBJH(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA430", Offset = "0x2BC8E30", VA = "0x182BCA430", Slot = "20")]
		public NIALADIPDNC MBDHKCBALEG(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2BC96C0", Offset = "0x2BC80C0", VA = "0x182BC96C0", Slot = "29")]
		public void DADKJHFJJMM(ref List<NIALADIPDNC> BEMBCCNAMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA590", Offset = "0x2BC8F90", VA = "0x182BCA590")]
		private Entity MBDHKCBALEG(Entity FLADPKIONGF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAC40", Offset = "0x2BC9640", VA = "0x182BCAC40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2EA90", Offset = "0x2B2D490", VA = "0x182B2EA90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EC90", Offset = "0x2B2D690", VA = "0x182B2EC90", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EE10", Offset = "0x2B2D810", VA = "0x182B2EE10")]
		public Entity NNEMDFGGGMJ(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EAE0", Offset = "0x2B2D4E0", VA = "0x182B2EAE0")]
		public Entity INDFCIHCJOC(COEEIJJLOPG FBIBIHJENAB, HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8E0", Offset = "0x2B2D2E0", VA = "0x182B2E8E0")]
		public Entity HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8A0", Offset = "0x2B2D2A0", VA = "0x182B2E8A0")]
		public Entity HJILJCOBKBK(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EA50", Offset = "0x2B2D450", VA = "0x182B2EA50")]
		public Entity HDLNFCHMNLC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EC00", Offset = "0x2B2D600", VA = "0x182B2EC00")]
		public Entity KIBFEIABGNF(KFKBMIIJOHI MCLMFJEAHEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EE30", Offset = "0x2B2D830", VA = "0x182B2EE30")]
		public Entity PAOGIEEBPDE(KHIPNLNOHNH MCLMFJEAHEC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EDC0", Offset = "0x2B2D7C0", VA = "0x182B2EDC0")]
		public NativeArray<(NIALADIPDNC, NIALADIPDNC)> NEEHFODMFJK(NativeArray<NIALADIPDNC> GDBKNKBNEEN, Allocator GGLOKAHPEPM)
		{
			return default(NativeArray<(NIALADIPDNC, NIALADIPDNC)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E850", Offset = "0x2B2D250", VA = "0x182B2E850")]
		public IEnumerable<HLEPLICHNKK> FPMKKFAPLCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EB40", Offset = "0x2B2D540", VA = "0x182B2EB40")]
		public EntityArchetype JCGKNAGCLPO(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EBA0", Offset = "0x2B2D5A0", VA = "0x182B2EBA0")]
		public Entity KHPNNFFFMMF(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8A0", Offset = "0x2B2D2A0", VA = "0x182B2E8A0")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E8E0", Offset = "0x2B2D2E0", VA = "0x182B2E8E0")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA, bool LFALMOHOCIE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E930", Offset = "0x2B2D330", VA = "0x182B2E930")]
		private Entity HCDODLFDEMI(HLEPLICHNKK IGDDGFIHFCA, COEEIJJLOPG FBIBIHJENAB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B3B3A0", Offset = "0x2B39DA0", VA = "0x182B3B3A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BEE0", Offset = "0x2B3A8E0", VA = "0x182B3BEE0", Slot = "9")]
		public void KDODMFBCLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C210", Offset = "0x2B3AC10", VA = "0x182B3C210", Slot = "10")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B4E0", Offset = "0x2B39EE0", VA = "0x182B3B4E0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BD50", Offset = "0x2B3A750", VA = "0x182B3BD50", Slot = "4")]
		public GICNBHGCLJH JDKKCIMDCKK(Entity FLADPKIONGF)
		{
			return default(GICNBHGCLJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BB00", Offset = "0x2B3A500", VA = "0x182B3BB00", Slot = "5")]
		public void HNDMNKKCFGN(NativeArray<GICNBHGCLJH> OEKBACIGMFI, NativeArray<EBMEGFHECAE> KLBNFOIEKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B7F0", Offset = "0x2B3A1F0", VA = "0x182B3B7F0", Slot = "6")]
		public void FDNNDLEHFKD(GICNBHGCLJH ODMNDKFKJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C170", Offset = "0x2B3AB70", VA = "0x182B3C170", Slot = "7")]
		public bool MKHMMCJJNEJ(GICNBHGCLJH ODMNDKFKJHN, out Collider BKPBAEGGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C3F0", Offset = "0x2B3ADF0", VA = "0x182B3C3F0")]
		public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B490", Offset = "0x2B39E90", VA = "0x182B3B490")]
		private void DJLMHEEFHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xC9F9D0", Offset = "0xC9E3D0", VA = "0x180C9F9D0")]
		private void IBBABJLMHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B8C0", Offset = "0x2B3A2C0", VA = "0x182B3B8C0")]
		private void FKLKLMFAIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x14B35A0", Offset = "0x14B1FA0", VA = "0x1814B35A0")]
		private void LJIKJACBIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C2D0", Offset = "0x2B3ACD0", VA = "0x182B3C2D0")]
		private BoxCollider OKEANPMELGG(Entity FLADPKIONGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B410", Offset = "0x2B39E10", VA = "0x182B3B410")]
		private void BLEKKJBGBKN(BoxCollider PPGPEGIOJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BEA0", Offset = "0x2B3A8A0", VA = "0x182B3BEA0")]
		[Conditional("UNITY_EDITOR")]
		private void JODAFGCIGDP(GameObject EHEABJNEALG, Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B910", Offset = "0x2B3A310", VA = "0x182B3B910")]
		private void FLFFLOICEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C050", Offset = "0x2B3AA50", VA = "0x182B3C050")]
		private void MDLPNDPIGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B5E0", Offset = "0x2B39FE0", VA = "0x182B3B5E0")]
		private void EKELPNGHIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3E0", Offset = "0x2B39DE0", VA = "0x182B3B3E0")]
		private void ANGBPGBIPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C160", Offset = "0x2B3AB60", VA = "0x182B3C160")]
		private void MGNICNOFOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BD10", Offset = "0x2B3A710", VA = "0x182B3BD10")]
		private void IBNCGIMELHN(Scene COIOOIJMLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C700", Offset = "0x2B3B100", VA = "0x182B3C700", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F16350", Offset = "0x2F14D50", VA = "0x182F16350", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2F163D0", Offset = "0x2F14DD0", VA = "0x182F163D0")]
	public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, out IMLPDEKDMHD BCCNCLJADPN, out Entity AOCCAACMBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2F16250", Offset = "0x2F14C50", VA = "0x182F16250")]
	public static bool IHCELKAKPFM(in Span<IMLPDEKDMHD> NANCADONKPH, float IDHCBHDHMCK, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2F16850", Offset = "0x2F15250", VA = "0x182F16850")]
	public static float PMNDMAPOJPN(float FAHPBJHMFEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GLGCNFPKLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2F163C0", Offset = "0x2F14DC0", VA = "0x182F163C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D2E350", Offset = "0x2D2CD50", VA = "0x182D2E350", Slot = "4")]
		public void Execute(int EBBLFLFCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E730", Offset = "0x2D2D130", VA = "0x182D2E730")]
		private static float3 LJLMPKJDFNJ(in float4x4 JOGEFGNGOKI, in float3 GODDPHBMKAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E190", Offset = "0x2D2CB90", VA = "0x182D2E190")]
		private static float3 EJENOFGBHHA(in float4x4 JOGEFGNGOKI, in float3 OECCBELLJIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E630", Offset = "0x2D2D030", VA = "0x182D2E630")]
		private static float3 KJPADHDKJMK(in float4x4 JOGEFGNGOKI, in float3 GODDPHBMKAO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EED0", Offset = "0x2D2D8D0", VA = "0x182D2EED0")]
		private static float3 OPFLMNMLGGN(in float4x4 JOGEFGNGOKI, in float3 OECCBELLJIJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DE40", Offset = "0x2D2C840", VA = "0x182D2DE40")]
		private bool BEODICJNGEH(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, in NativeArray<Entity> FHJHHNEKCIB, out float3 BCCNCLJADPN, out float3 FACACMFGKHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E800", Offset = "0x2D2D200", VA = "0x182D2E800")]
		public static bool NFDOHBDOEIA(in float3 PDBIDMEAHPJ, in float3 IGBOHNBJLPJ, in float3 AJJPBAOLMBP, in float3 FMIOEBCGDGK, float ALNNAJNJAJO, float OIGIAECEHDG, out float KHJLEOILJMF, out float3 AFNHKCHCFAI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager LNPEGOPJJGK;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x2BB88D0", Offset = "0x2BB72D0", VA = "0x182BB88D0", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8950", Offset = "0x2BB7350", VA = "0x182BB8950")]
	public void ONLAOGPNMOG(in NativeArray<Entity> IJBCECFNJIL, in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, in NativeArray<IMLPDEKDMHD> BHKPFKGNPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public AJKIOOEJPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x2BB88C0", Offset = "0x2BB72C0", VA = "0x182BB88C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x11ABD70", Offset = "0x11AA770", VA = "0x1811ABD70")]
			get
			{
				return default(NativeHashMap<COEEIJJLOPG, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint EFIJAEJKFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x2B31DE0", Offset = "0x2B307E0", VA = "0x182B31DE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x826CE0", Offset = "0x8256E0", VA = "0x180826CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0xDACAB0", Offset = "0xDAB4B0", VA = "0x180DACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2B32160", Offset = "0x2B30B60", VA = "0x182B32160", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C80", Offset = "0x2B30680", VA = "0x182B31C80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x2B32280", Offset = "0x2B30C80", VA = "0x182B32280")]
		public void PGHHBKOCHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E10", Offset = "0x2B30810", VA = "0x182B31E10")]
		public void HDECAMKOCDJ(COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32060", Offset = "0x2B30A60", VA = "0x182B32060")]
		private NIALADIPDNC LKDLNANKINH(Entity FLADPKIONGF)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x2B31B40", Offset = "0x2B30540", VA = "0x182B31B40")]
		public NIALADIPDNC BIKIJJFPJAP(COEEIJJLOPG FBIBIHJENAB)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x2B31FD0", Offset = "0x2B309D0", VA = "0x182B31FD0")]
		public COEEIJJLOPG KHNEHGBKPKD(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(COEEIJJLOPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31CF0", Offset = "0x2B306F0", VA = "0x182B31CF0")]
		public void EABCHBAKPHG(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C20", Offset = "0x2B30620", VA = "0x182B31C20")]
		public void CODIDBLNHMJ(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D80", Offset = "0x2B30780", VA = "0x182B31D80")]
		public void GJJOGOOPAKK(Entity FLADPKIONGF, COEEIJJLOPG FBIBIHJENAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x2B32090", Offset = "0x2B30A90", VA = "0x182B32090")]
		public void MHKCGKBBFAM(Entity FLADPKIONGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B42D80", Offset = "0x2B41780", VA = "0x182B42D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x2B42C90", Offset = "0x2B41690", VA = "0x182B42C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action KCHBKIMIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x2B42130", Offset = "0x2B40B30", VA = "0x182B42130")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x2B41F10", Offset = "0x2B40910", VA = "0x182B41F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x2B42D30", Offset = "0x2B41730", VA = "0x182B42D30", Slot = "4")]
		public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x2B420A0", Offset = "0x2B40AA0", VA = "0x182B420A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x2B42B20", Offset = "0x2B41520", VA = "0x182B42B20")]
		public void KOEBKPOFGOP(HDFAPEIIIAK DPEKNLAIHMP, DDBCMBKNLPG ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x2B41FB0", Offset = "0x2B409B0", VA = "0x182B41FB0")]
		public void DIAMOLMPOPF(HDFAPEIIIAK DPEKNLAIHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x2B42710", Offset = "0x2B41110", VA = "0x182B42710")]
		internal void KEFKEPOOGPA(ACMLCBMOLDA BLJBLMCPLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x2B421D0", Offset = "0x2B40BD0", VA = "0x182B421D0")]
		private void HAEOEECBMBD(ACMLCBMOLDA BLJBLMCPLPH, int HIMMGNBBIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x2B42E20", Offset = "0x2B41820", VA = "0x182B42E20")]
		private void PIHHKJNBNJB(DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG, ILHDILENIKC KHOKCBMOPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x2B429A0", Offset = "0x2B413A0", VA = "0x182B429A0")]
		private JBMKGMAAILI KNNKPACLAAA(DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG)
		{
			return default(JBMKGMAAILI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E20", Offset = "0x2B40820", VA = "0x182B41E20")]
		private ILHDILENIKC BNCPBJFAMFC(JBMKGMAAILI PAGFKHPKKBH, DHPNCKOALMM MEIAOCKHKHB, BCFEIPPIFOG FGGMEGPIENG)
		{
			return default(ILHDILENIKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x2B430F0", Offset = "0x2B41AF0", VA = "0x182B430F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E73EF0", Offset = "0x3E728F0", VA = "0x183E73EF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA97B60", Offset = "0xA96560", VA = "0x180A97B60")]
		[DebuggerHidden]
		public DOBGNKIEIOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x3E73D40", Offset = "0x3E72740", VA = "0x183E73D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x3E73EB0", Offset = "0x3E728B0", VA = "0x183E73EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x3E73E00", Offset = "0x3E72800", VA = "0x183E73E00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIALADIPDNC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x3E73E00", Offset = "0x3E72800", VA = "0x183E73E00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F10F80", Offset = "0x2F0F980", VA = "0x182F10F80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private NNAMEJEONOI MLIEHBECBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2F10310", Offset = "0x2F0ED10", VA = "0x182F10310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x2F10EF0", Offset = "0x2F0F8F0", VA = "0x182F10EF0", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2F10360", Offset = "0x2F0ED60", VA = "0x182F10360", Slot = "5")]
	public void CINIFMEGBBE(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2F104A0", Offset = "0x2F0EEA0", VA = "0x182F104A0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2F106F0", Offset = "0x2F0F0F0", VA = "0x182F106F0")]
	private void FACFIFDLEFF(Entity IDNHGIFGKAE, in COGGJKLIPPL COIGMOLEHIG, in COGGJKLIPPL MAEOIACPFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2F10970", Offset = "0x2F0F370", VA = "0x182F10970", Slot = "14")]
	public NIALADIPDNC HDLNFCHMNLC()
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2F10B50", Offset = "0x2F0F550", VA = "0x182F10B50", Slot = "10")]
	public void LNPAPAFIMNJ(NIALADIPDNC KLCGNDEDAPD, BKNCABFHGMF JJDMBGDPAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x2F10C40", Offset = "0x2F0F640", VA = "0x182F10C40", Slot = "9")]
	public BKNCABFHGMF LOEKLKAMFAK(NIALADIPDNC KLCGNDEDAPD)
	{
		return default(BKNCABFHGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FE70", Offset = "0x2F0E870", VA = "0x182F0FE70", Slot = "11")]
	public NIALADIPDNC AIAEFIEGLIL(NIALADIPDNC CJBPCJKPDLN, [Optional] Vector3? EINGNKDKDHC, [Optional] Quaternion? JGCPJBFFFAC, [Optional] Vector3? IIOOEIFOODC)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2F10460", Offset = "0x2F0EE60", VA = "0x182F10460", Slot = "15")]
	public NIALADIPDNC DEKBHBFBKLB(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB, [Optional] Vector3? EINGNKDKDHC, [Optional] Quaternion? JGCPJBFFFAC, [Optional] Vector3? IIOOEIFOODC)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2F10FD0", Offset = "0x2F0F9D0", VA = "0x182F10FD0", Slot = "7")]
	public NIALADIPDNC PEIFIHDAEIE(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB)
	{
		return default(NIALADIPDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2F10A90", Offset = "0x2F0F490", VA = "0x182F10A90", Slot = "16")]
	public void IMPJEIFPANK(NIALADIPDNC HIMFGNKFJFD, NIALADIPDNC JOMCMEOJGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2F10170", Offset = "0x2F0EB70", VA = "0x182F10170", Slot = "12")]
	public void CDMFFIMJFPP(NIALADIPDNC HIMFGNKFJFD, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2F10550", Offset = "0x2F0EF50", VA = "0x182F10550", Slot = "17")]
	public void EJPHJKIJFKI(NIALADIPDNC HIMFGNKFJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2F10E50", Offset = "0x2F0F850", VA = "0x182F10E50", Slot = "8")]
	public int MPICFMLJMPK(NIALADIPDNC HIMFGNKFJFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2F10D30", Offset = "0x2F0F730", VA = "0x182F10D30", Slot = "6")]
	[IteratorStateMachine(typeof(DOBGNKIEIOF))]
	public IEnumerable<NIALADIPDNC> MDOOCFHKHLJ(NIALADIPDNC HIMFGNKFJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2F10DC0", Offset = "0x2F0F7C0", VA = "0x182F10DC0")]
	private bool MPEDAOFGLFL(NIALADIPDNC HIMFGNKFJFD, out NativeArray<Entity> PAHCBODMCHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x2F109D0", Offset = "0x2F0F3D0", VA = "0x182F109D0")]
	private NativeArray<Entity> HLANMNAMFOD(NIALADIPDNC HIMFGNKFJFD)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F14530", Offset = "0x2F12F30", VA = "0x182F14530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2F14850", Offset = "0x2F13250", VA = "0x182F14850", Slot = "4")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2F148D0", Offset = "0x2F132D0", VA = "0x182F148D0")]
	public void NMBFNAPDGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2F14580", Offset = "0x2F12F80", VA = "0x182F14580")]
	public void HMGOOCAOEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F1D140", Offset = "0x2F1BB40", VA = "0x182F1D140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D220", Offset = "0x2F1BC20", VA = "0x182F1D220")]
	public JEONNONMJKN(Type MCLMFJEAHEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D060", Offset = "0x2F1BA60", VA = "0x182F1D060")]
	public static JEONNONMJKN DGKBAOBECFH(Type MCLMFJEAHEC)
	{
		return default(JEONNONMJKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D010", Offset = "0x2F1BA10", VA = "0x182F1D010")]
	public static Type DGKBAOBECFH(JEONNONMJKN ODMNDKFKJHN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x1026820", Offset = "0x1025220", VA = "0x181026820")]
	public static bool GBIPOJBPNDJ(JEONNONMJKN IKAMJBDPPHG, JEONNONMJKN LKLEFAIICIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x1026820", Offset = "0x1025220", VA = "0x181026820")]
	public static bool EOCJAGBGMLJ(JEONNONMJKN IKAMJBDPPHG, JEONNONMJKN LKLEFAIICIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x8586A0", Offset = "0x8570A0", VA = "0x1808586A0", Slot = "4")]
	public bool Equals(JEONNONMJKN OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D0C0", Offset = "0x2F1BAC0", VA = "0x182F1D0C0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D1A0", Offset = "0x2F1BBA0", VA = "0x182F1D1A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B36EE0", Offset = "0x2B358E0", VA = "0x182B36EE0")]
	static PBJCNIBABCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2799900", Offset = "0x2798300", VA = "0x182799900")]
	public static bool MFMCNFFMIAP<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2B36E70", Offset = "0x2B35870", VA = "0x182B36E70")]
	public static bool MFMCNFFMIAP(Type MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2B36D00", Offset = "0x2B35700", VA = "0x182B36D00")]
	private static bool MFMCNFFMIAP(Type MCLMFJEAHEC, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x2799870", Offset = "0x2798270", VA = "0x182799870")]
	public static int GIKDDENMNIA<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x2B36C90", Offset = "0x2B35690", VA = "0x182B36C90")]
	public static int GIKDDENMNIA(Type MCLMFJEAHEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x27997D0", Offset = "0x27981D0", VA = "0x1827997D0")]
	public static bool DJEIEOEOGPA<T>(out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2B36A30", Offset = "0x2B35430", VA = "0x182B36A30")]
	public static bool DJEIEOEOGPA(Type MCLMFJEAHEC, out int EBBLFLFCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x2B36BF0", Offset = "0x2B355F0", VA = "0x182B36BF0")]
	public static Type DNJGGIFCOKL(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2B36AD0", Offset = "0x2B354D0", VA = "0x182B36AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x774FE0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x19DD670", Offset = "0x19DC070", VA = "0x1819DD670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> KHANGGOFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2A70920", Offset = "0x2A6F320", VA = "0x182A70920")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x92EFA0", Offset = "0x92D9A0", VA = "0x18092EFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B30", Offset = "0x2A6F530", VA = "0x182A70B30")]
	public GDKJPPNHBEA(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2A70A80", Offset = "0x2A6F480", VA = "0x182A70A80")]
	public int NCLIALNFMIA(T MAKFNMHIJIF, int LJECKBCMELA, int FPLNDBJJHMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x2A709C0", Offset = "0x2A6F3C0", VA = "0x182A709C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EEF7E0", Offset = "0x2EEE1E0", VA = "0x182EEF7E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int ELOKHHJFINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x2EEF630", Offset = "0x2EEE030", VA = "0x182EEF630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int KMFAFOCNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x2EF0020", Offset = "0x2EEEA20", VA = "0x182EF0020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x2EEFFD0", Offset = "0x2EEE9D0", VA = "0x182EEFFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CAJAMKMLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x2EF0160", Offset = "0x2EEEB60", VA = "0x182EF0160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> KHANGGOFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x2EEEF30", Offset = "0x2EED930", VA = "0x182EEEF30")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF02F0", Offset = "0x2EEECF0", VA = "0x182EF02F0")]
	public MOFGJBIANBO(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0230", Offset = "0x2EEEC30", VA = "0x182EF0230")]
	public T NDLPBJJGODE(int EBBLFLFCHFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF480", Offset = "0x2EEDE80", VA = "0x182EEF480")]
	public void EAPOPGMPIAN(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2EEEB50", Offset = "0x2EED550", VA = "0x182EEEB50")]
	public void ANNCMMPKBHC(Span<T> ACLENHAHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0050", Offset = "0x2EEEA50", VA = "0x182EF0050")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF870", Offset = "0x2EEE270", VA = "0x182EEF870")]
	private void HCAKDOJKAFA(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFA50", Offset = "0x2EEE450", VA = "0x182EEFA50")]
	public void HGKMPAKBDLD(Span<T> EPKPHBHDHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF3D0", Offset = "0x2EEDDD0", VA = "0x182EEF3D0")]
	public void DJBHJCJMAFL(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF080", Offset = "0x2EEDA80", VA = "0x182EEF080")]
	public void CMMGLMLLAND(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2EEECC0", Offset = "0x2EED6C0", VA = "0x182EEECC0")]
	public void APBNDDFINKH(int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2EEED20", Offset = "0x2EED720", VA = "0x182EEED20")]
	public void BCKCFIAIJFC(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF2A0", Offset = "0x2EEDCA0", VA = "0x182EEF2A0")]
	public void COMPHBNLPPJ(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFC90", Offset = "0x2EEE690", VA = "0x182EEFC90")]
	public void IFOKOKMOLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF01A0", Offset = "0x2EEEBA0", VA = "0x182EF01A0")]
	public int NCLIALNFMIA(T MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF9F0", Offset = "0x2EEE3F0", VA = "0x182EEF9F0")]
	public bool HEBLGIOGKGC(T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF430", Offset = "0x2EEDE30", VA = "0x182EEF430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0280", Offset = "0x2EEEC80", VA = "0x182EF0280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF360", Offset = "0x2EEDD60", VA = "0x182EEF360")]
	public static Span<T> DGKBAOBECFH(global::MOFGJBIANBO<T> ACLENHAHHHH)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFD50", Offset = "0x2EEE750", VA = "0x182EEFD50")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IMIKFGABDNA(int MAKFNMHIJIF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GKOBPMIMFNN(int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF680", Offset = "0x2EEE080", VA = "0x182EEF680")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GKOBPMIMFNN(int JKABHKIANJL, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFE90", Offset = "0x2EEE890", VA = "0x182EEFE90")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JLOONFMJHFN(int MAKFNMHIJIF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE950", Offset = "0x2EED350", VA = "0x182EEE950")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ABIMBIKDBMO(int BDICDJBOCMG, int EAJAFIHJLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF4F0", Offset = "0x2EEDEF0", VA = "0x182EEF4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F11AC0", Offset = "0x2F104C0", VA = "0x182F11AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> CCHLCHPBPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCC670", VA = "0x180CCDC70")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray BPFDOGBAHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x2F11980", Offset = "0x2F10380", VA = "0x182F11980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x2F11B10", Offset = "0x2F10510", VA = "0x182F11B10")]
	public FMHLIBMOGNG(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2F119A0", Offset = "0x2F103A0", VA = "0x182F119A0")]
	public Entity MBHLEOADAJO(int EBBLFLFCHFB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2F11970", Offset = "0x2F10370", VA = "0x182F11970")]
	public Transform EGPJFBDDOGE(int EBBLFLFCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x2F11820", Offset = "0x2F10220", VA = "0x182F11820")]
	public void BHHBALHHNAM(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x2F119F0", Offset = "0x2F103F0", VA = "0x182F119F0")]
	public int MFMCNFFMIAP(Transform HJLACGOIJCA, Entity FLADPKIONGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2F11870", Offset = "0x2F10270", VA = "0x182F11870")]
	public int DJBHJCJMAFL(int EBBLFLFCHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x2F118F0", Offset = "0x2F102F0", VA = "0x182F118F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2F11AD0", Offset = "0x2F104D0", VA = "0x182F11AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1C260", Offset = "0x2F1AC60", VA = "0x182F1C260")]
	public ILBIHHBCGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C200", Offset = "0x2F1AC00", VA = "0x182F1C200")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F1BF70", Offset = "0x2F1A970", VA = "0x182F1BF70")]
	public void KMNEKDAGPNL(Type MCLMFJEAHEC, COGGJKLIPPL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BA80", Offset = "0x2F1A480", VA = "0x182F1BA80")]
	public COGGJKLIPPL DNJGGIFCOKL(Type MCLMFJEAHEC)
	{
		return default(COGGJKLIPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BED0", Offset = "0x2F1A8D0", VA = "0x182F1BED0")]
	private NativeArray<byte> KCDBGMIDMMC(int2 OPKMEAOACCL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BD10", Offset = "0x2F1A710", VA = "0x182F1BD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BDB0", Offset = "0x2F1A7B0", VA = "0x182F1BDB0", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B24900", Offset = "0x2B23300", VA = "0x182B24900")]
	internal static void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void KMNEKDAGPNL<T>(T MAKFNMHIJIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2B24860", Offset = "0x2B23260", VA = "0x182B24860")]
	public static void KMNEKDAGPNL(Type MCLMFJEAHEC, COGGJKLIPPL MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T DNJGGIFCOKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x2B247C0", Offset = "0x2B231C0", VA = "0x182B247C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B2A6D0", Offset = "0x2B290D0", VA = "0x182B2A6D0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FBHIPILAOBE, LinkedEntityGroup DPKHPCDGHJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A6F0", Offset = "0x2B290F0", VA = "0x182B2A6F0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup LGKNNMGLNIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public OPMBHIENKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class FJNPKDEABHB
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HGOCJCNMADJ(in Vector3 EINGNKDKDHC, in Quaternion JGCPJBFFFAC, in Vector3 IIOOEIFOODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void KNLJKEILPIF(in Vector3 PBCIBNFLBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GHBGBCBNIAB(in Quaternion JGCPJBFFFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void ALANJKJDPPD(in Vector3 OBHHFBHHOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void INGLDPANENM(in Vector3 OBHHFBHHOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BFCCDEBINLI(in float NMPAKEMAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2F11220", Offset = "0x2F0FC20", VA = "0x182F11220")]
	[Conditional("DEBUG_BUILD")]
	public static void HHDOHDNHKOO(in float3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in float MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x2F11300", Offset = "0x2F0FD00", VA = "0x182F11300")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in Vector3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2F112D0", Offset = "0x2F0FCD0", VA = "0x182F112D0")]
	[Conditional("DEBUG_BUILD")]
	public static void OFFOFJGFMOP(in Quaternion MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2F111D0", Offset = "0x2F0FBD0", VA = "0x182F111D0")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in float MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2F111E0", Offset = "0x2F0FBE0", VA = "0x182F111E0")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in Vector3 MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2F111A0", Offset = "0x2F0FBA0", VA = "0x182F111A0")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJGHNKMMKG(in Quaternion MAKFNMHIJIF, string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BB7F50", Offset = "0x2BB6950", VA = "0x182BB7F50")]
	public AGAIJBALKEC(Entity FLADPKIONGF, Entity KOEBMFNDCDN, Entity EBIGGMLCEAF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7EF0", Offset = "0x2BB68F0", VA = "0x182BB7EF0")]
	public static AGAIJBALKEC DGKBAOBECFH((Entity entity, Entity oldParent, Entity newParent) FLBKHBGNHCC)
	{
		return default(AGAIJBALKEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7F30", Offset = "0x2BB6930", VA = "0x182BB7F30")]
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
	[Cpp2IlInjected.Address(RVA = "0xF4CE50", Offset = "0xF4B850", VA = "0x180F4CE50")]
	public KCBMDFFNPLE(Entity FLADPKIONGF, Entity LFAIGCEGCPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E370", Offset = "0x2F1CD70", VA = "0x182F1E370")]
	public static KCBMDFFNPLE DGKBAOBECFH((Entity entity, Entity parent) FLBKHBGNHCC)
	{
		return default(KCBMDFFNPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E3A0", Offset = "0x2F1CDA0", VA = "0x182F1E3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A64720", Offset = "0x2A63120", VA = "0x182A64720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x2A64730", Offset = "0x2A63130", VA = "0x182A64730")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x2A64630", Offset = "0x2A63030", VA = "0x182A64630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x2A647D0", Offset = "0x2A631D0", VA = "0x182A647D0")]
	public GAGCOPLHKFA(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2A646F0", Offset = "0x2A630F0", VA = "0x182A646F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
	public LODLLBEOEDK(NDCKDIDFMEA PJKFKLILAKL, int FPLOLBPBBLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x2B23CE0", Offset = "0x2B226E0", VA = "0x182B23CE0")]
	public static LODLLBEOEDK DGKBAOBECFH((NDCKDIDFMEA eventType, int eventIndex) FBHIPILAOBE)
	{
		return default(LODLLBEOEDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x2B23D00", Offset = "0x2B22700", VA = "0x182B23D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B27CE0", Offset = "0x2B266E0", VA = "0x182B27CE0", Slot = "5")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x2B27D30", Offset = "0x2B26730", VA = "0x182B27D30")]
	public bool ONLAOGPNMOG(in float3 ANCFDPJDHMG, in float3 FOGEFLLJLFJ, float IDHCBHDHMCK, Allocator GGLOKAHPEPM, out NativeArray<Entity> IJBCECFNJIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public NNJPNPDHKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x2B27D30", Offset = "0x2B26730", VA = "0x182B27D30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBFC00", Offset = "0x2BBE600", VA = "0x182BBFC00", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public BPPCNJIIPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BC2410", Offset = "0x2BC0E10", VA = "0x182BC2410", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public CFNDOPINCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F17130", Offset = "0x2F15B30", VA = "0x182F17130", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public HGDGAPPFILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class FNJHAHNACMJ : HMNHMIKHJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public FNJHAHNACMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B37050", Offset = "0x2B35A50", VA = "0x182B37050", Slot = "16")]
	protected override ComponentSystemBase GADCGJMGDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x2B26AC0", Offset = "0x2B254C0", VA = "0x182B26AC0")]
	public PDEALDMPPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[BPAPKMJCHMP(typeof(AuthoredLocalPoseData))]
public sealed class NONENIAELEG : MHLOHCPJKFG
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2B28670", Offset = "0x2B27070", VA = "0x182B28670", Slot = "8")]
	protected override bool HABKFPAJILN(ReadOnlySpan<AuthoredLocalPoseData> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2B285B0", Offset = "0x2B26FB0", VA = "0x182B285B0", Slot = "9")]
	protected override bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<AuthoredLocalPoseData> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x2B286F0", Offset = "0x2B270F0", VA = "0x182B286F0")]
	public NONENIAELEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[BPAPKMJCHMP(typeof(LocalPoseData))]
public sealed class DMANAJHKIHB : LGKPBDJCABL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x2BD31D0", Offset = "0x2BD1BD0", VA = "0x182BD31D0", Slot = "8")]
	protected override bool HABKFPAJILN(ReadOnlySpan<LocalPoseData> EPKPHBHDHGH, LHDHMGCHIDM IHGCOMBDNKO, out ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3110", Offset = "0x2BD1B10", VA = "0x182BD3110", Slot = "9")]
	protected override bool DFCKKOIGNHF(int AJGHIJIKOBE, Span<LocalPoseData> EPKPHBHDHGH, in ReadOnlySpan<byte> FJHIHOOEHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3250", Offset = "0x2BD1C50", VA = "0x182BD3250")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x2D49B40", Offset = "0x2D48540", VA = "0x182D49B40", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x2D4AAE0", Offset = "0x2D494E0", VA = "0x182D4AAE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x2B24D30", Offset = "0x2B23730", VA = "0x182B24D30")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2B249E0", Offset = "0x2B233E0", VA = "0x182B249E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
