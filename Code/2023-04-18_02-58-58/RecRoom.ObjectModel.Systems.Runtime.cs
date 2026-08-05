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
public sealed class FIDPGNBBHOH<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class PCDBFAEHJPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::FIDPGNBBHOH<T> BKEABAOIIBL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] LLPFMHHPAAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public PCDBFAEHJPK(global::FIDPGNBBHOH<T> BKEABAOIIBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class OFMNFDONCGH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::FIDPGNBBHOH<T> <>4__this;

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
		public OFMNFDONCGH(int <>1__state)
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
	private const int PAEPNIHKDLH = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> BFBOLBLPNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int BOKHBHNGCOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T POFBPBHJKPE
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
	private bool KGIFMFOFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EPGKCBNDAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool IIMOEGDKONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EPBJKODLMLB
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
	public int BPIIJGBNBGB
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
	public FIDPGNBBHOH(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public FIDPGNBBHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void FJNHFLOBBCM(int GMEHLIHLGEH, T ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void PDJCDCJJNPH(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] LBKAIIPADDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void FADENEECKBI(NativeArray<T> HAHPMNMCEBD, int PBNJDHGCIFC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::FIDPGNBBHOH<>.OFMNFDONCGH))]
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
	public int JEBHMABMKPB(T ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool MILDLLFOGOM(T ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void BKHFBHCKOHP(int NPAFCOMAPGF, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void BINEFGOGBKC(int NPAFCOMAPGF, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void MCCMBNELPGN(int NPAFCOMAPGF, int MOHMCFDNHKH, int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int PGKHGNIPIFC(int GMEHLIHLGEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T LNOEMPCPMFM(int GMEHLIHLGEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void PGGKIPECGGJ(int GMEHLIHLGEH, T ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void HILONDNMIBG(int GMEHLIHLGEH, T ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void PDLPNIHIFKJ(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int ONCNGKKLMLF(int IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int DDEPNJAOEOB(int IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void CELMIHNMOPJ(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void FJOEIPFIBBJ(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T DFGOHCIEABD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T EECCNAHBEIB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void NEKGAMAKIJN(int GMEHLIHLGEH, IReadOnlyCollection<T> HJHCHKNIJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void JLJIMINCMMA(int GMEHLIHLGEH, int GLCMJHKDHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void PDPADCIKINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void GNNAABIAOOJ(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void FDAGOBKLHMB(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void OAAPHNINABP(int MOHMCFDNHKH, int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T HGNIIGFNPIL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T KCEDAMAMKFN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CPDNKOEGHHF]
public static class IKNHONAMFEP
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26A9370", Offset = "0x26A8570", VA = "0x1826A9370")]
	static IKNHONAMFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F55E50", Offset = "0x1F55050", VA = "0x181F55E50")]
	public static void BHKDGPNKFCO<T>(T CKOEFCDNGOI, ref T CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26A9150", Offset = "0x26A8350", VA = "0x1826A9150")]
	public static void BHKDGPNKFCO(FixedString32 CKOEFCDNGOI, ref string CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26A9330", Offset = "0x26A8530", VA = "0x1826A9330")]
	public static void BHKDGPNKFCO(string CKOEFCDNGOI, ref FixedString32 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26A9300", Offset = "0x26A8500", VA = "0x1826A9300")]
	public static void BHKDGPNKFCO(FixedString64 CKOEFCDNGOI, ref string CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26A9240", Offset = "0x26A8440", VA = "0x1826A9240")]
	public static void BHKDGPNKFCO(string CKOEFCDNGOI, ref FixedString64 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26A92A0", Offset = "0x26A84A0", VA = "0x1826A92A0")]
	public static void BHKDGPNKFCO(POPNKIGFAPP CKOEFCDNGOI, ref Vector3 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26A9180", Offset = "0x26A8380", VA = "0x1826A9180")]
	public static void BHKDGPNKFCO(Vector3 CKOEFCDNGOI, ref POPNKIGFAPP CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26A90B0", Offset = "0x26A82B0", VA = "0x1826A90B0")]
	public static void BHKDGPNKFCO(CILCIPDONMD CKOEFCDNGOI, ref Vector4 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26A9000", Offset = "0x26A8200", VA = "0x1826A9000")]
	public static void BHKDGPNKFCO(Vector4 CKOEFCDNGOI, ref CILCIPDONMD CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26A90B0", Offset = "0x26A82B0", VA = "0x1826A90B0")]
	public static void BHKDGPNKFCO(CILCIPDONMD CKOEFCDNGOI, ref Quaternion CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26A9000", Offset = "0x26A8200", VA = "0x1826A9000")]
	public static void BHKDGPNKFCO(Quaternion CKOEFCDNGOI, ref CILCIPDONMD CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26A92D0", Offset = "0x26A84D0", VA = "0x1826A92D0")]
	public static void BHKDGPNKFCO(POPNKIGFAPP CKOEFCDNGOI, ref float3 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26A9180", Offset = "0x26A8380", VA = "0x1826A9180")]
	public static void BHKDGPNKFCO(float3 CKOEFCDNGOI, ref POPNKIGFAPP CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26A9070", Offset = "0x26A8270", VA = "0x1826A9070")]
	public static void BHKDGPNKFCO(CILCIPDONMD CKOEFCDNGOI, ref float4 CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26A9000", Offset = "0x26A8200", VA = "0x1826A9000")]
	public static void BHKDGPNKFCO(float4 CKOEFCDNGOI, ref CILCIPDONMD CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26A9070", Offset = "0x26A8270", VA = "0x1826A9070")]
	public static void BHKDGPNKFCO(CILCIPDONMD CKOEFCDNGOI, ref quaternion CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26A90E0", Offset = "0x26A82E0", VA = "0x1826A90E0")]
	public static void BHKDGPNKFCO(quaternion CKOEFCDNGOI, ref CILCIPDONMD CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x26A9200", Offset = "0x26A8400", VA = "0x1826A9200")]
	public static void BHKDGPNKFCO(Entity CKOEFCDNGOI, ref JDKGKGJGGCE CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26A91E0", Offset = "0x26A83E0", VA = "0x1826A91E0")]
	public static void BHKDGPNKFCO(JDKGKGJGGCE CKOEFCDNGOI, ref Entity CDDELNFHFEP, EEJKADCLIHN ABLKPOMPEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MPMKPCGOCAF]
public class KAEHHFLFKIC : ComponentSystem, CMLEAAEGAAL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BLBDINABANB EOEDHGLEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x26ADCD0", Offset = "0x26ACED0", VA = "0x1826ADCD0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	public KAEHHFLFKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[MPMKPCGOCAF]
[UpdateInGroup(typeof(PLPDNCCBGEC))]
internal class FOHJNJONHJG : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x269CF60", Offset = "0x269C160", VA = "0x18269CF60", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x269CEE0", Offset = "0x269C0E0", VA = "0x18269CEE0")]
	[Preserve]
	private void DKKJFKAFCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public FOHJNJONHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MPMKPCGOCAF]
[UpdateInGroup(typeof(PLPDNCCBGEC))]
internal class IFLGMGHAAEP : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26A8340", Offset = "0x26A7540", VA = "0x1826A8340", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public IFLGMGHAAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9AC0", Offset = "0x2AF8CC0", VA = "0x182AF9AC0")]
		public static ObjectModelConfigAsset PPFIGCPJDFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FF0", Offset = "0x6F91F0", VA = "0x1806F9FF0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int IGHAJOOKIHP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly HDHIMOFHFJL AHADDDAMGKE;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x34DBEB0", Offset = "0x34DB0B0", VA = "0x1834DBEB0")]
			public static HCIIHJLICJK HFIFLNGBMLN(int OFPMLDIHGNA)
			{
				return default(HCIIHJLICJK);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x34DC470", Offset = "0x34DB670", VA = "0x1834DC470")]
			private static void PIJONJBKKPL(HPHBHAKAACD OGAOCODOBHD, HPHBHAKAACD NEOJCENIHLO, HCIIHJLICJK MIBPNJCOIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x34DC2A0", Offset = "0x34DB4A0", VA = "0x1834DC2A0")]
			public static int IGAMEJFAPDM(GameObject BMNLOPDIJGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x34DBE30", Offset = "0x34DB030", VA = "0x1834DBE30")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void BBHPEAIGKGC(HPHBHAKAACD EHNNHDBEJOG, int OFPMLDIHGNA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MNALHHOLFGL FMPHDMAKDKP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static LKANKDBMEPH OPMONFEOPPL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static MNALHHOLFGL EMNOLBJFOID
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB4C0", Offset = "0x2AFA6C0", VA = "0x182AFB4C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA7E0", Offset = "0x2AF99E0", VA = "0x182AFA7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static LKANKDBMEPH MNNCAPCBMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAED0", Offset = "0x2AFA0D0", VA = "0x182AFAED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9F40", Offset = "0x2AF9140", VA = "0x182AF9F40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool BJIJEJEMPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB1E0", Offset = "0x2AFA3E0", VA = "0x182AFB1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static BLBDINABANB EOEDHGLEEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA160", Offset = "0x2AF9360", VA = "0x182AFA160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static LHKILEMFMKD FIFLKDCJGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA8C0", Offset = "0x2AF9AC0", VA = "0x182AFA8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static CNBEKDOCLNI NCJCMAENIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB340", Offset = "0x2AFA540", VA = "0x182AFB340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static IDEMJNMNAMN PGOMDBENJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9D30", Offset = "0x2AF8F30", VA = "0x182AF9D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FMAHBOCPDMM EFPODGDKADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA5B0", Offset = "0x2AF97B0", VA = "0x182AFA5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static GBMEAEPJCNJ ILLFGBFMOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB520", Offset = "0x2AFA720", VA = "0x182AFB520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool NEDBNEJNCML
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB6C0", Offset = "0x2AFA8C0", VA = "0x182AFB6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HIDDEEKGMKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA200", Offset = "0x2AF9400", VA = "0x182AFA200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool MDOALEKMJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAFF0", Offset = "0x2AFA1F0", VA = "0x182AFAFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool NIAMEGJCAKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFAD20", Offset = "0x2AF9F20", VA = "0x182AFAD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA550", Offset = "0x2AF9750", VA = "0x182AFA550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool PNFLOJJOPEP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9DB0", Offset = "0x2AF8FB0", VA = "0x182AF9DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AFACC0", Offset = "0x2AF9EC0", VA = "0x182AFACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action OLENKEHDGAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFB3C0", Offset = "0x2AFA5C0", VA = "0x182AFB3C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA330", Offset = "0x2AF9530", VA = "0x182AFA330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9B60", Offset = "0x2AF8D60", VA = "0x182AF9B60")]
		public static HPHBHAKAACD ADIDIKPFHIK(GameObject BMNLOPDIJGF)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA630", Offset = "0x2AF9830", VA = "0x182AFA630")]
		public static bool GBGIALPIAIH(ByteString NDFFNBIIOEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AFABA0", Offset = "0x2AF9DA0", VA = "0x182AFABA0")]
		public static DBJMAFIOFFK KLIHLLAPIOO(HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA690", Offset = "0x2AF9890", VA = "0x182AFA690")]
		public static (ByteString, IDisposable) IIADKJHBOIN()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAD80", Offset = "0x2AF9F80", VA = "0x182AFAD80")]
		public static (ByteString, IDisposable) LGCGMBBJFEI(IEnumerable<HPHBHAKAACD> GGDPNBMCEHC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9E10", Offset = "0x2AF9010", VA = "0x182AF9E10")]
		public static bool CBDEGIDNAFG(GameObject BMNLOPDIJGF, out HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA430", Offset = "0x2AF9630", VA = "0x182AFA430")]
		public static bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> GDKJDDCKGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAAC0", Offset = "0x2AF9CC0", VA = "0x182AFAAC0")]
		public static void KEKBKJGNAEM(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA940", Offset = "0x2AF9B40", VA = "0x182AFA940")]
		public static Task KALMGAFNCHO(bool BFDBCMGIOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9C50", Offset = "0x2AF8E50", VA = "0x182AF9C50")]
		private static LKANKDBMEPH AFDGNGDMAED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB5A0", Offset = "0x2AFA7A0", VA = "0x182AFB5A0")]
		private static bool PALGHMGKMHK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B007A0", Offset = "0x2AFF9A0", VA = "0x182B007A0")]
		public static bool FEAEGBIINDA(ACPBHPEJKKH APJNOAFFKHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B00170", Offset = "0x2AFF370", VA = "0x182B00170")]
		public static ACPBHPEJKKH BNAKCAAHHPA(GameObject BMNLOPDIJGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B003A0", Offset = "0x2AFF5A0", VA = "0x182B003A0")]
		public static ACPBHPEJKKH BNAKCAAHHPA(GameObject BMNLOPDIJGF, HCIIHJLICJK MIBPNJCOIHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B00940", Offset = "0x2AFFB40", VA = "0x182B00940")]
		public static bool KDHKPGEKFNA(GameObject HKPJJHILEBG, string PEGANFDBJPA, bool MDAOPIDDPHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B005A0", Offset = "0x2AFF7A0", VA = "0x182B005A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void COFNIHHPNCM(GameObject HKPJJHILEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B00850", Offset = "0x2AFFA50", VA = "0x182B00850")]
		[CompilerGenerated]
		internal static string IMFMFIAOCNH((GameObject go, string prefabName) ADCFFAJGNAM)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, KGDFHOFBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool KKKHNMGIFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public HPHBHAKAACD GGFLINHGDJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HPHBHAKAACD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2160210", Offset = "0x215F410", VA = "0x182160210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[CGDKNMKPKIP(OOBCCNCEGNI.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, ACPBHPEJKKH, KGDFHOFBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string BBFOHAMJMAD = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EAIPGNKLHFL DADHJJNJEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HPHBHAKAACD FLKGABKFAPI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HPHBHAKAACD GGFLINHGDJF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB240", Offset = "0x2ABA440", VA = "0x182ABB240", Slot = "15")]
			get
			{
				return default(HPHBHAKAACD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public DBJMAFIOFFK EBCMHCLDAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB2F0", Offset = "0x2ABA4F0", VA = "0x182ABB2F0", Slot = "6")]
			get
			{
				return default(DBJMAFIOFFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KKKHNMGIFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB230", Offset = "0x2ABA430", VA = "0x182ABB230", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public EAIPGNKLHFL MLHPFDHGDIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x86D5E0", Offset = "0x86C7E0", VA = "0x18086D5E0", Slot = "7")]
			get
			{
				return default(EAIPGNKLHFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private LHKILEMFMKD FIFLKDCJGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA960", Offset = "0x2AB9B60", VA = "0x182ABA960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EFDNEMMCCPM FNFBEOJCBAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA870", Offset = "0x2AB9A70", VA = "0x182ABA870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PJIFOONKJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> DLPIIGGGNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB0F0", Offset = "0x2ABA2F0", VA = "0x182ABB0F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB320", Offset = "0x2ABA520", VA = "0x182ABB320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ACPBHPEJKKH> JLBICJLGLBP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB190", Offset = "0x2ABA390", VA = "0x182ABB190", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB3C0", Offset = "0x2ABA5C0", VA = "0x182ABB3C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA590", Offset = "0x2AB9790", VA = "0x182ABA590")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAF50", Offset = "0x2ABA150", VA = "0x182ABAF50", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAB90", Offset = "0x2AB9D90", VA = "0x182ABAB90", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAEC0", Offset = "0x2ABA0C0", VA = "0x182ABAEC0", Slot = "10")]
		public void OnEmbody(DGHIBPMIJHM PHAHHGAAFFH, HPHBHAKAACD FLKGABKFAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAF40", Offset = "0x2ABA140", VA = "0x182ABAF40", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABACB0", Offset = "0x2AB9EB0", VA = "0x182ABACB0", Slot = "12")]
		public void OnDisembody(bool IOLDCDJPLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA770", Offset = "0x2AB9970", VA = "0x182ABA770")]
		private void ELEGHBNBAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA8D0", Offset = "0x2AB9AD0", VA = "0x182ABA8D0")]
		private void IIMDMKNAADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAA40", Offset = "0x2AB9C40", VA = "0x182ABAA40")]
		private void MIJAGHMGMDP(bool JOOHABHHKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAB30", Offset = "0x2AB9D30", VA = "0x182ABAB30", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x814E20", Offset = "0x814020", VA = "0x180814E20", Slot = "9")]
		private GameObject KIODJLKLPPH()
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
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[CGDKNMKPKIP(OOBCCNCEGNI.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CNKGPKGDJHD HBCBFJLJNJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x27004E0", Offset = "0x26FF6E0", VA = "0x1827004E0", Slot = "6")]
			get
			{
				return default(CNKGPKGDJHD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2700480", Offset = "0x26FF680", VA = "0x182700480")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[CGDKNMKPKIP(OOBCCNCEGNI.Registration)]
	public class TransformEntity : MonoBehaviour, KGDFHOFBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private CNKGPKGDJHD prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HPHBHAKAACD EHNNHDBEJOG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual CNKGPKGDJHD HBCBFJLJNJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0", Slot = "6")]
			get
			{
				return default(CNKGPKGDJHD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x908F90", Offset = "0x908190", VA = "0x180908F90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public HPHBHAKAACD GGFLINHGDJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB53DB0", Offset = "0xB52FB0", VA = "0x180B53DB0", Slot = "5")]
			get
			{
				return default(HPHBHAKAACD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KKKHNMGIFMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity NOIJKFBLFEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal FMAHBOCPDMM EFPODGDKADC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal EFDNEMMCCPM OMBLPNIMJKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x270ED70", Offset = "0x270DF70", VA = "0x18270ED70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x270E930", Offset = "0x270DB30", VA = "0x18270E930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x270EC80", Offset = "0x270DE80", VA = "0x18270EC80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x270E970", Offset = "0x270DB70", VA = "0x18270E970")]
		internal void IHEKMEOIBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x270EE70", Offset = "0x270E070", VA = "0x18270EE70")]
		private bool POADGLKDCAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x270E940", Offset = "0x270DB40", VA = "0x18270E940")]
		private void HHFALBHBAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x270EC80", Offset = "0x270DE80", VA = "0x18270EC80")]
		internal void MBLNKLCECMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x270EDE0", Offset = "0x270DFE0", VA = "0x18270EDE0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x270EF60", Offset = "0x270E160", VA = "0x18270EF60")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[PNCLNBNALEO(typeof(LKANKDBMEPH), new string[] { })]
[KKDNFMENBCC(typeof(MFNEEGAKIKC))]
public class ADLHAHNMNKK : LKANKDBMEPH, FGPHKGGABON, MFNEEGAKIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IALMMDHPOBI LBBJCIBEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LHKILEMFMKD JBDCCFIPMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LFKALMDGEEP ENHPMBIJPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LCMPGMKLFLC MAHBIJBCNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KIMMKIKOLAA FPDJJELEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IALMMDHPOBI EOEDHGLEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MLOAKDLKONO KNPHKPIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LCMPGMKLFLC EDPPCONEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KIMMKIKOLAA NEHHDIGHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xBB3A20", Offset = "0xBB2C20", VA = "0x180BB3A20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OKNMIKICIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F580", Offset = "0x2A9E780", VA = "0x182A9F580", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DDILJKOPKGP IAJLHNJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x860040", Offset = "0x85F240", VA = "0x180860040", Slot = "10")]
		get
		{
			return default(DDILJKOPKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F490", Offset = "0x2A9E690", VA = "0x182A9F490")]
	public static ADLHAHNMNKK GPGHDDABLEF(IALMMDHPOBI LBBJCIBEDFD, HEJOODJDOMN PANELIGGJGM = HEJOODJDOMN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void IALBAMPHJDL(IALMMDHPOBI LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void AILHMDMIFLO(IALMMDHPOBI LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F590", Offset = "0x2A9E790", VA = "0x182A9F590", Slot = "11")]
	public void OLHDANNJCMN(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F420", Offset = "0x2A9E620", VA = "0x182A9F420")]
	private void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F6E0", Offset = "0x2A9E8E0", VA = "0x182A9F6E0")]
	private void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F430", Offset = "0x2A9E630", VA = "0x182A9F430", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ADLHAHNMNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DFMPJGNFMIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4C90", Offset = "0x2AB3E90", VA = "0x182AB4C90")]
	public static DBJMAFIOFFK OADPHDJIIGP(this LKANKDBMEPH OPMONFEOPPL, HCIIHJLICJK MIBPNJCOIHL, CNKGPKGDJHD FNGBDAJENGB)
	{
		return default(DBJMAFIOFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4DD0", Offset = "0x2AB3FD0", VA = "0x182AB4DD0")]
	public static CCHAJLMBAFD OBAIKOPBHAP(this LKANKDBMEPH OPMONFEOPPL)
	{
		return default(CCHAJLMBAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4AC0", Offset = "0x2AB3CC0", VA = "0x182AB4AC0")]
	public static HPHBHAKAACD ADIDIKPFHIK(this LKANKDBMEPH OPMONFEOPPL, Entity LHCPLOHKBCE)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4990", Offset = "0x2AB3B90", VA = "0x182AB4990")]
	public static HPHBHAKAACD ADIDIKPFHIK(this LKANKDBMEPH OPMONFEOPPL, HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4B70", Offset = "0x2AB3D70", VA = "0x182AB4B70")]
	public static HCIIHJLICJK ANDMDOJLAPG(this LKANKDBMEPH OPMONFEOPPL, HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(HCIIHJLICJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum HEJOODJDOMN
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
[PNCLNBNALEO(typeof(KIMMKIKOLAA), new string[] { })]
public class IEGMMCDOFOI : KIMMKIKOLAA, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[GAJFPHPAPMA]
	private MFNEEGAKIKC JKCBLHNHOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private IALMMDHPOBI LBBJCIBEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private KNMAKEFNGNA MAHBIJBCNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private LFKALMDGEEP ENHPMBIJPEI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ALJFMIDGDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x26A7FA0", Offset = "0x26A71A0", VA = "0x1826A7FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x26A8120", Offset = "0x26A7320", VA = "0x1826A8120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26A8290", Offset = "0x26A7490", VA = "0x1826A8290", Slot = "16")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x26A8040", Offset = "0x26A7240", VA = "0x1826A8040", Slot = "13")]
	public void GPFGKOHNMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "6")]
	public void NJPNMKKOHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26A8080", Offset = "0x26A7280", VA = "0x1826A8080", Slot = "7")]
	public void HNCHFHCCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x26A8210", Offset = "0x26A7410", VA = "0x1826A8210", Slot = "8")]
	public void OAGKFDBKKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FD00", Offset = "0x1A4EF00", VA = "0x181A4FD00", Slot = "9")]
	public void BHOCKFEHAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26A80D0", Offset = "0x26A72D0", VA = "0x1826A80D0", Slot = "10")]
	public void JOENGPJNKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A7EE0", Offset = "0x26A70E0", VA = "0x1826A7EE0", Slot = "11")]
	public bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> GDKJDDCKGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26A7E00", Offset = "0x26A7000", VA = "0x1826A7E00", Slot = "12")]
	public void ALDNDHFJDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x26A81C0", Offset = "0x26A73C0", VA = "0x1826A81C0", Slot = "14")]
	public void MJFMJJDNBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26A7E80", Offset = "0x26A7080", VA = "0x1826A7E80", Slot = "15")]
	public void EANEPEKPFMA(bool KBMEGKLHBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26A7E50", Offset = "0x26A7050", VA = "0x1826A7E50")]
	private void DKDCLIEHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public IEGMMCDOFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PNCLNBNALEO(typeof(LCMPGMKLFLC), new string[] { })]
public class ECICALBJPKG : LCMPGMKLFLC, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[GAJFPHPAPMA]
	private MFNEEGAKIKC JKCBLHNHOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private IALMMDHPOBI LBBJCIBEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KNMAKEFNGNA MAHBIJBCNGK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9E90", Offset = "0x2AB9090", VA = "0x182AB9E90", Slot = "6")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9DD0", Offset = "0x2AB8FD0", VA = "0x182AB9DD0", Slot = "4")]
	public ByteString IIADKJHBOIN(out IDisposable KABCFBBDMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9CB0", Offset = "0x2AB8EB0", VA = "0x182AB9CB0", Slot = "5")]
	public void BBCFAILGGHN(ByteString PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ECICALBJPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FPMLPKLCNHP<T> : global::JHBGFDOFOMF<T>, global::FMBDPECPAID<HCIIHJLICJK, T>, global::ALBPNJDJEPD<HCIIHJLICJK>, CFMFMFJNBJM, IDisposable, HGIJDEJFJEI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::ALBPNJDJEPD<Entity> IDBLFHOOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate MAGNJOGNLBE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x465A190", Offset = "0x4659390", VA = "0x18465A190", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type MMMENNAAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x465A900", Offset = "0x4659B00", VA = "0x18465A900", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BKDBNLPNJFE OHIEJHNCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x465A550", Offset = "0x4659750", VA = "0x18465A550", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int GPHHDKAMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4669B20", Offset = "0x4668D20", VA = "0x184669B20", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MGIDMAMBDPP OANIGBBGEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4665360", Offset = "0x4664560", VA = "0x184665360", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xD67BB0", Offset = "0xD66DB0", VA = "0x180D67BB0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x465ABE0", Offset = "0x4659DE0", VA = "0x18465ABE0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::CIHMHELDCCD<HCIIHJLICJK> OLENKEHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x466C0A0", Offset = "0x466B2A0", VA = "0x18466C0A0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x465B310", Offset = "0x465A510", VA = "0x18465B310", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26E10E0", Offset = "0x26E02E0", VA = "0x1826E10E0")]
	public FPMLPKLCNHP(global::ALBPNJDJEPD<Entity> IDBLFHOOMPH, FMAHBOCPDMM GLPABBNKNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x46628B0", Offset = "0x4661AB0", VA = "0x1846628B0")]
	private Entity IAFIDDAPMCG(HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A48150", Offset = "0x3A47350", VA = "0x183A48150")]
	private HCIIHJLICJK IAFIDDAPMCG(Entity LHCPLOHKBCE)
	{
		return default(HCIIHJLICJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x46603C0", Offset = "0x465F5C0", VA = "0x1846603C0", Slot = "4")]
	public T HHCPOGCCGNF(HCIIHJLICJK MIBPNJCOIHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x466D590", Offset = "0x466C790", VA = "0x18466D590")]
	public bool PLCAKFAMFIL(HCIIHJLICJK MIBPNJCOIHL, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x46693C0", Offset = "0x46685C0", VA = "0x1846693C0")]
	public bool MEJDOIIIMIC(HCIIHJLICJK MIBPNJCOIHL, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x466A110", Offset = "0x4669310", VA = "0x18466A110", Slot = "9")]
	public bool NHKKABBPFMM(HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x465CF50", Offset = "0x465C150", VA = "0x18465CF50", Slot = "26")]
	public object FINAPKILFMF(HCIIHJLICJK MIBPNJCOIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x465CD50", Offset = "0x465BF50", VA = "0x18465CD50")]
	public bool FFDGCEAFHNA(HCIIHJLICJK MIBPNJCOIHL, in object DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4660070", Offset = "0x465F270", VA = "0x184660070")]
	public void HHCPOGCCGNF(HCIIHJLICJK MIBPNJCOIHL, in OANIPIMDODC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x466C7B0", Offset = "0x466B9B0", VA = "0x18466C7B0")]
	public bool PLCAKFAMFIL(HCIIHJLICJK MIBPNJCOIHL, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x46686C0", Offset = "0x46678C0", VA = "0x1846686C0")]
	public bool MEJDOIIIMIC(HCIIHJLICJK MIBPNJCOIHL, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x26DD240", Offset = "0x26DC440", VA = "0x1826DD240", Slot = "22")]
	public void LGHFLJJPKHF(CNNKIACDEEO MPAPMLANIKB, [Optional] object DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4664930", Offset = "0x4663B30", VA = "0x184664930", Slot = "15")]
	public void LGHFLJJPKHF(HCIIHJLICJK FDAIMOMOHIG, CMIHDJOHIOH MPAPMLANIKB, object DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x465B7A0", Offset = "0x465A9A0", VA = "0x18465B7A0", Slot = "14")]
	public bool EKNKDADOBNE(HCIIHJLICJK CDDELNFHFEP, HCIIHJLICJK CKOEFCDNGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1B3AED0", Offset = "0x1B3A0D0", VA = "0x181B3AED0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x466DF40", Offset = "0x466D140", VA = "0x18466DF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3F75BC0", Offset = "0x3F74DC0", VA = "0x183F75BC0")]
	public string OJHDDHFCNCK(in NFKEKJGDLJI GHIMBIBAOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x466A470", Offset = "0x4669670", VA = "0x18466A470")]
	private void NKBEAMLGBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4662C70", Offset = "0x4661E70", VA = "0x184662C70")]
	private void JLLDJKEBPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4666AD0", Offset = "0x4665CD0", VA = "0x184666AD0")]
	private void LPHKIEGKJHA(Entity LHCPLOHKBCE, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4661BC0", Offset = "0x4660DC0", VA = "0x184661BC0")]
	private void HOMGIJGCHEL(Entity LHCPLOHKBCE, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x465E300", Offset = "0x465D500", VA = "0x18465E300")]
	[Conditional("DEBUG_BUILD")]
	private static void GFPHJLHEHCB(Entity LHCPLOHKBCE, HCIIHJLICJK MIBPNJCOIHL, string OPCKJKNEHGA, string HDAEFHKIBNC, [CallerMemberName] string NCEHLECBNMM = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D460", Offset = "0x1B4C660", VA = "0x181B4D460", Slot = "5")]
	private bool CNCJNNPDPEN(HCIIHJLICJK FDAIMOMOHIG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29DC7A0", Offset = "0x29DB9A0", VA = "0x1829DC7A0", Slot = "6")]
	private bool MNDCKFIIPFH(HCIIHJLICJK FDAIMOMOHIG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1FC40B0", Offset = "0x1FC32B0", VA = "0x181FC40B0", Slot = "10")]
	private bool PCFODBAMDLE(HCIIHJLICJK FDAIMOMOHIG, in object DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3A484A0", Offset = "0x3A476A0", VA = "0x183A484A0", Slot = "11")]
	private void JHANFGCDEPD(HCIIHJLICJK FDAIMOMOHIG, in OANIPIMDODC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3A4BD70", Offset = "0x3A4AF70", VA = "0x183A4BD70", Slot = "12")]
	private bool OKCEFOLJFFH(HCIIHJLICJK FDAIMOMOHIG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3A48D50", Offset = "0x3A47F50", VA = "0x183A48D50", Slot = "13")]
	private bool LECPHBENOME(HCIIHJLICJK FDAIMOMOHIG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x26DA630", Offset = "0x26D9830", VA = "0x1826DA630", Slot = "16")]
	private string AGLFLBNAJGB(in NFKEKJGDLJI IPMIIEAGJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class CBCHMFJEMMP<T> : global::NOBICPNOIDE<T>, global::FMBDPECPAID<HPHBHAKAACD, T>, global::ALBPNJDJEPD<HPHBHAKAACD>, CFMFMFJNBJM, IDisposable, KFBCGBKCDNN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::ALBPNJDJEPD<Entity> IDBLFHOOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate MAGNJOGNLBE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3F69EF0", Offset = "0x3F690F0", VA = "0x183F69EF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type MMMENNAAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A570", Offset = "0x3F69770", VA = "0x183F6A570", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BKDBNLPNJFE OHIEJHNCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A1C0", Offset = "0x3F693C0", VA = "0x183F6A1C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GPHHDKAMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F73B10", Offset = "0x3F72D10", VA = "0x183F73B10", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MGIDMAMBDPP OANIGBBGEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F703F0", Offset = "0x3F6F5F0", VA = "0x183F703F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3F75C10", Offset = "0x3F74E10", VA = "0x183F75C10", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6A770", Offset = "0x3F69970", VA = "0x183F6A770", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::CIHMHELDCCD<HPHBHAKAACD> OLENKEHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F75530", Offset = "0x3F74730", VA = "0x183F75530", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AC10", Offset = "0x3F69E10", VA = "0x183F6AC10", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x26E10E0", Offset = "0x26E02E0", VA = "0x1826E10E0")]
	public CBCHMFJEMMP(global::ALBPNJDJEPD<Entity> IDBLFHOOMPH, FMAHBOCPDMM GLPABBNKNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1725240", Offset = "0x1724440", VA = "0x181725240")]
	private Entity IAFIDDAPMCG(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x26DC990", Offset = "0x26DBB90", VA = "0x1826DC990")]
	private HPHBHAKAACD IAFIDDAPMCG(Entity LHCPLOHKBCE)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3F6D340", Offset = "0x3F6C540", VA = "0x183F6D340", Slot = "4")]
	public T HHCPOGCCGNF(HPHBHAKAACD EHNNHDBEJOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3F75F00", Offset = "0x3F75100", VA = "0x183F75F00")]
	public bool PLCAKFAMFIL(HPHBHAKAACD EHNNHDBEJOG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3F72A50", Offset = "0x3F71C50", VA = "0x183F72A50")]
	public bool MEJDOIIIMIC(HPHBHAKAACD EHNNHDBEJOG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3F73F20", Offset = "0x3F73120", VA = "0x183F73F20", Slot = "9")]
	public bool NHKKABBPFMM(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C2F0", Offset = "0x3F6B4F0", VA = "0x183F6C2F0", Slot = "26")]
	public object FINAPKILFMF(HPHBHAKAACD EHNNHDBEJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3F6B670", Offset = "0x3F6A870", VA = "0x183F6B670")]
	public bool FFDGCEAFHNA(HPHBHAKAACD EHNNHDBEJOG, in object DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CF10", Offset = "0x3F6C110", VA = "0x183F6CF10")]
	public void HHCPOGCCGNF(HPHBHAKAACD EHNNHDBEJOG, in OANIPIMDODC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3F75E70", Offset = "0x3F75070", VA = "0x183F75E70")]
	public bool PLCAKFAMFIL(HPHBHAKAACD EHNNHDBEJOG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3F72F00", Offset = "0x3F72100", VA = "0x183F72F00")]
	public bool MEJDOIIIMIC(HPHBHAKAACD EHNNHDBEJOG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x26DD240", Offset = "0x26DC440", VA = "0x1826DD240", Slot = "22")]
	public void LGHFLJJPKHF(CNNKIACDEEO MPAPMLANIKB, [Optional] object DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F730", Offset = "0x3F6E930", VA = "0x183F6F730", Slot = "15")]
	public void LGHFLJJPKHF(HPHBHAKAACD FDAIMOMOHIG, CMIHDJOHIOH MPAPMLANIKB, object DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3F6AD70", Offset = "0x3F69F70", VA = "0x183F6AD70", Slot = "14")]
	public bool EKNKDADOBNE(HPHBHAKAACD CDDELNFHFEP, HPHBHAKAACD CKOEFCDNGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3F750F0", Offset = "0x3F742F0", VA = "0x183F750F0")]
	private void NKBEAMLGBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EEB0", Offset = "0x3F6E0B0", VA = "0x183F6EEB0")]
	private void JLLDJKEBPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3F71FA0", Offset = "0x3F711A0", VA = "0x183F71FA0")]
	private void LPHKIEGKJHA(Entity LHCPLOHKBCE, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E370", Offset = "0x3F6D570", VA = "0x183F6E370")]
	private void HOMGIJGCHEL(Entity LHCPLOHKBCE, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x26DAA20", Offset = "0x26D9C20", VA = "0x1826DAA20", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3F771F0", Offset = "0x3F763F0", VA = "0x183F771F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3F75BC0", Offset = "0x3F74DC0", VA = "0x183F75BC0")]
	public string OJHDDHFCNCK(in NFKEKJGDLJI GHIMBIBAOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x26DA960", Offset = "0x26D9B60", VA = "0x1826DA960", Slot = "5")]
	private bool IKFGLDGLKCM(HPHBHAKAACD FDAIMOMOHIG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x26DAF10", Offset = "0x26DA110", VA = "0x1826DAF10", Slot = "6")]
	private bool EKODLLIFAAF(HPHBHAKAACD FDAIMOMOHIG, in T DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26DA7A0", Offset = "0x26D99A0", VA = "0x1826DA7A0", Slot = "10")]
	private bool CIBJCALFMNI(HPHBHAKAACD FDAIMOMOHIG, in object DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x26DC690", Offset = "0x26DB890", VA = "0x1826DC690", Slot = "11")]
	private void HKEENJNMEDE(HPHBHAKAACD FDAIMOMOHIG, in OANIPIMDODC IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26DA9A0", Offset = "0x26D9BA0", VA = "0x1826DA9A0", Slot = "12")]
	private bool CMJEPIGOKFN(HPHBHAKAACD FDAIMOMOHIG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x26DA9E0", Offset = "0x26D9BE0", VA = "0x1826DA9E0", Slot = "13")]
	private bool DIOBMBOONBC(HPHBHAKAACD FDAIMOMOHIG, in NFKEKJGDLJI DLEMNBPMGBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x26DA630", Offset = "0x26D9830", VA = "0x1826DA630", Slot = "16")]
	private string AKKPOCCDKKA(in NFKEKJGDLJI IPMIIEAGJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AJPDKCDNPDL : IDisposable, NCIOIFNNEKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> HEGDIFHFONN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public AJPDKCDNPDL(NativeArray<EntityRemapUtility.EntityRemapInfo> NNLAFJIOMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FFF0", Offset = "0x2A9F1F0", VA = "0x182A9FFF0", Slot = "6")]
	public HPHBHAKAACD CJDCAFAGCBH(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2AA00E0", Offset = "0x2A9F2E0", VA = "0x182AA00E0", Slot = "7")]
	public Entity CJDCAFAGCBH(Entity LHCPLOHKBCE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0040", Offset = "0x2A9F240", VA = "0x182AA0040", Slot = "8")]
	public IEnumerable<HPHBHAKAACD> CJDCAFAGCBH(IEnumerable<HPHBHAKAACD> GGDPNBMCEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2AA00F0", Offset = "0x2A9F2F0", VA = "0x182AA00F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly HDHIMOFHFJL CFDCCJACBAG;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int CBCNICABBLB;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static NCIOIFNNEKH LCMDLFOKELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool HKKOBHOFMGI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> HEGDIFHFONN
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2707210", Offset = "0x2706410", VA = "0x182707210")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool BGGLHEPHJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2707490", Offset = "0x2706690", VA = "0x182707490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2707430", Offset = "0x2706630", VA = "0x182707430")]
		public static SerializationRemapScope IPFACLHCPLN()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x27075B0", Offset = "0x27067B0", VA = "0x1827075B0")]
		public SerializationRemapScope(NCIOIFNNEKH FNCBOOMGADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2707320", Offset = "0x2706520", VA = "0x182707320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2706F80", Offset = "0x2706180", VA = "0x182706F80")]
		public static HPHBHAKAACD CJDCAFAGCBH(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x27070E0", Offset = "0x27062E0", VA = "0x1827070E0")]
		public static Entity CJDCAFAGCBH(Entity LHCPLOHKBCE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
[PNCLNBNALEO(typeof(EMIELEBIIIE), new string[] { "Editor" })]
public sealed class EMIELEBIIIE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void CBPFDLNIGPP(HCIIHJLICJK FIOAPGCPMFK, LHNKALDLHDD PCPEJHIMHJJ, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void OFKLEGFGDLO(HCIIHJLICJK FIOAPGCPMFK, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void OKPLEIKEBPG(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event CBPFDLNIGPP NELDKAODLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA1C0", Offset = "0x2AB93C0", VA = "0x182ABA1C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9F20", Offset = "0x2AB9120", VA = "0x182AB9F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event OFKLEGFGDLO CKMBGPFCLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA2B0", Offset = "0x2AB94B0", VA = "0x182ABA2B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA080", Offset = "0x2AB9280", VA = "0x182ABA080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event OKPLEIKEBPG NHOGGDNBEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA120", Offset = "0x2AB9320", VA = "0x182ABA120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9FE0", Offset = "0x2AB91E0", VA = "0x182AB9FE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA260", Offset = "0x2AB9460", VA = "0x182ABA260")]
	[Conditional("UNITY_EDITOR")]
	public void JJMLIJPGNPC(HCIIHJLICJK FIOAPGCPMFK, in LHNKALDLHDD PCPEJHIMHJJ, bool BGMGDCJKJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9FC0", Offset = "0x2AB91C0", VA = "0x182AB9FC0")]
	[Conditional("UNITY_EDITOR")]
	public void CBAAPDJPILF(HCIIHJLICJK FIOAPGCPMFK, bool BGMGDCJKJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA280", Offset = "0x2AB9480", VA = "0x182ABA280")]
	[Conditional("UNITY_EDITOR")]
	public void LKECCGNLKGP(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, bool BGMGDCJKJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EMIELEBIIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[PNCLNBNALEO(typeof(PLHDIIJFCAF), new string[] { "Editor" })]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public sealed class PLHDIIJFCAF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void KFDGLEBFLIP(HCIIHJLICJK MIBPNJCOIHL, LHNKALDLHDD PCPEJHIMHJJ, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void IFBNADHLIKH(HCIIHJLICJK MIBPNJCOIHL, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void OHANJEHBKCK(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, bool BGMGDCJKJDB, bool LODHAMGPJAK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void CAKJJIOHCGE(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void EBFHHEDFIJH(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> CIBMMMKIEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B025A0", Offset = "0x2B017A0", VA = "0x182B025A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B02D90", Offset = "0x2B01F90", VA = "0x182B02D90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> NOHDMCNKGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B02660", Offset = "0x2B01860", VA = "0x182B02660")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B02340", Offset = "0x2B01540", VA = "0x182B02340")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event KFDGLEBFLIP NELDKAODLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B02BB0", Offset = "0x2B01DB0", VA = "0x182B02BB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B022A0", Offset = "0x2B014A0", VA = "0x182B022A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IFBNADHLIKH CKMBGPFCLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B03000", Offset = "0x2B02200", VA = "0x182B03000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B02720", Offset = "0x2B01920", VA = "0x182B02720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event KFDGLEBFLIP JDHFEOJKKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B02CF0", Offset = "0x2B01EF0", VA = "0x182B02CF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B024A0", Offset = "0x2B016A0", VA = "0x182B024A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event IFBNADHLIKH JGELIHAGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02900", Offset = "0x2B01B00", VA = "0x182B02900")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C50", Offset = "0x2B01E50", VA = "0x182B02C50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event OHANJEHBKCK NHOGGDNBEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B029A0", Offset = "0x2B01BA0", VA = "0x182B029A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B02400", Offset = "0x2B01600", VA = "0x182B02400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CAKJJIOHCGE ODBFODJFMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B02860", Offset = "0x2B01A60", VA = "0x182B02860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B02AE0", Offset = "0x2B01CE0", VA = "0x182B02AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BMMDOJFONPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B02F20", Offset = "0x2B02120", VA = "0x182B02F20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B027C0", Offset = "0x2B019C0", VA = "0x182B027C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EBFHHEDFIJH GMIJFDEHAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B02200", Offset = "0x2B01400", VA = "0x182B02200")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2B02A40", Offset = "0x2B01C40", VA = "0x182B02A40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2B02EF0", Offset = "0x2B020F0", VA = "0x182B02EF0")]
	[Conditional("UNITY_EDITOR")]
	public void MFHCKBHPKKA(HCIIHJLICJK MIBPNJCOIHL, in LHNKALDLHDD PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2B02FE0", Offset = "0x2B021E0", VA = "0x182B02FE0")]
	[Conditional("UNITY_EDITOR")]
	public void ODJCBFJJIKI(HCIIHJLICJK MIBPNJCOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2B02B80", Offset = "0x2B01D80", VA = "0x182B02B80")]
	[Conditional("UNITY_EDITOR")]
	public void IDCDDHHHPMJ(HCIIHJLICJK MIBPNJCOIHL, in LHNKALDLHDD PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2B02FC0", Offset = "0x2B021C0", VA = "0x182B02FC0")]
	[Conditional("UNITY_EDITOR")]
	public void OAEILHIBIJG(HCIIHJLICJK MIBPNJCOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2B021D0", Offset = "0x2B013D0", VA = "0x182B021D0")]
	[Conditional("UNITY_EDITOR")]
	public void ALFLKEMDNKD(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, bool LODHAMGPJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2B02140", Offset = "0x2B01340", VA = "0x182B02140")]
	[Conditional("UNITY_EDITOR")]
	public void ABMPAANDNNB(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2B02540", Offset = "0x2B01740", VA = "0x182B02540")]
	[Conditional("UNITY_EDITOR")]
	public void DOOPLNCLIHK(string KNOPFGAGMCN, object KHKGGNHOCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2B02EC0", Offset = "0x2B020C0", VA = "0x182B02EC0")]
	[Conditional("UNITY_EDITOR")]
	public void LPOCHIGPPIK(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2B02E50", Offset = "0x2B02050", VA = "0x182B02E50")]
	[Conditional("UNITY_EDITOR")]
	public void LCNILEFOCBJ(World PHAHHGAAFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2B02160", Offset = "0x2B01360", VA = "0x182B02160")]
	[Conditional("UNITY_EDITOR")]
	public void AFCBBFBMLNM(World PHAHHGAAFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PLHDIIJFCAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PNCLNBNALEO(typeof(BJHDLENICMM), new string[] { })]
public class CDKHBLKAMFC : BJHDLENICMM
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2AA63D0", Offset = "0x2AA55D0", VA = "0x182AA63D0", Slot = "5")]
	public void AHOGJNPBCGE(object OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2AA64C0", Offset = "0x2AA56C0", VA = "0x182AA64C0", Slot = "6")]
	public void GGDBIFANOAJ(object OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2AA65B0", Offset = "0x2AA57B0", VA = "0x182AA65B0", Slot = "7")]
	public void IMBKNNMOJLO(object OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2AA66A0", Offset = "0x2AA58A0", VA = "0x182AA66A0", Slot = "4")]
	public IDisposable PJJEPFCMIOG(object OFCFPGACNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CDKHBLKAMFC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	[PNCLNBNALEO(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	internal class BulkInstantiateSceneObjectService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string DEJGIAPKLHJ = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[GAJFPHPAPMA]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[GAJFPHPAPMA]
		private EFDNEMMCCPM EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery ADPCMNNMCCE;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2AA5530", Offset = "0x2AA4730", VA = "0x182AA5530")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5AD0", Offset = "0x2AA4CD0", VA = "0x182AA5AD0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3E10", Offset = "0x2AA3010", VA = "0x182AA3E10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3E20", Offset = "0x2AA3020", VA = "0x182AA3E20")]
		public bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> JIAEHFBOHPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4300", Offset = "0x2AA3500", VA = "0x182AA4300")]
		public static bool GHCNDIDLCNJ(GKJFAKANILO BEODCPFFPCC, out HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5580", Offset = "0x2AA4780", VA = "0x182AA5580")]
		private void OGNKOIKJNBB(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO, IEnumerable<GKJFAKANILO> JIAEHFBOHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA45E0", Offset = "0x2AA37E0", VA = "0x182AA45E0")]
		private void HBKBGCPIGFM(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2AA50B0", Offset = "0x2AA42B0", VA = "0x182AA50B0")]
		private void MCNOELADLCN(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO, HCIIHJLICJK MIBPNJCOIHL, string KNOPFGAGMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3FA0", Offset = "0x2AA31A0", VA = "0x182AA3FA0")]
		private void GEGKGIGLEEP(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4810", Offset = "0x2AA3A10", VA = "0x182AA4810")]
		private void JIIELIBPLHN(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO, List<GKJFAKANILO> NCMGMAAEDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5900", Offset = "0x2AA4B00", VA = "0x182AA5900")]
		private NativeList<HCIIHJLICJK> OPDFFOFGBIB(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO)
		{
			return default(NativeList<HCIIHJLICJK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4410", Offset = "0x2AA3610", VA = "0x182AA4410")]
		private NativeArray<Entity> GNOKILMDJOO(NativeList<HCIIHJLICJK> PNIAMGLKHHF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5C50", Offset = "0x2AA4E50", VA = "0x182AA5C50")]
		private static void PMMODHJGLDB(Dictionary<HCIIHJLICJK, GKJFAKANILO> GHKLFJFOHKO, HCIIHJLICJK MIBPNJCOIHL, GKJFAKANILO BEODCPFFPCC, string KNOPFGAGMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
	[PNCLNBNALEO(typeof(DebugWorldsService), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool OKNMIKICIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2AB81A0", Offset = "0x2AB73A0", VA = "0x182AB81A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8120", Offset = "0x2AB7320", VA = "0x182AB8120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool IJNGLGNLCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB80E0", Offset = "0x2AB72E0", VA = "0x182AB80E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8160", Offset = "0x2AB7360", VA = "0x182AB8160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public void OKBMEGJOKHL(string KNOPFGAGMCN, EntityManager IIODDCGHDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public static void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PNCLNBNALEO(typeof(LFKALMDGEEP), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
internal class LFKALMDGEEP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool OKNMIKICIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x707EE0", Offset = "0x7070E0", VA = "0x180707EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool NOGGNEENFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x14BD710", Offset = "0x14BC910", VA = "0x1814BD710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x14BC3A0", Offset = "0x14BB5A0", VA = "0x1814BC3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LFKALMDGEEP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[PNCLNBNALEO(typeof(KNMAKEFNGNA), new string[] { })]
	[KKDNFMENBCC(typeof(SerializationService))]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	internal class SerializationService : KNMAKEFNGNA, IDisposable, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly HDHIMOFHFJL KGPMGPHJKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[GAJFPHPAPMA]
		private GMIJLIFNPJO IAOPBOEHEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[GAJFPHPAPMA]
		private LFKALMDGEEP ENHPMBIJPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IIBDPIPACMB MIKICJJDBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private CLPPOKFANAO FMAHPJDILLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope KABCFBBDMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? IDKFIKKFFLE;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool DKOFLJCFHCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x27094F0", Offset = "0x27086F0", VA = "0x1827094F0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2708040", Offset = "0x2707240", VA = "0x182708040", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool AFKIDFCDNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x852C50", Offset = "0x851E50", VA = "0x180852C50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x852DF0", Offset = "0x851FF0", VA = "0x180852DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CLPPOKFANAO MNENPNLBBHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2709500", Offset = "0x2708700", VA = "0x182709500", Slot = "16")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2707D10", Offset = "0x2706F10", VA = "0x182707D10", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x27085D0", Offset = "0x27077D0", VA = "0x1827085D0")]
		public static bool GBGIALPIAIH(ByteString NDFFNBIIOEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		public void BMJCEKIBNOG(IIBDPIPACMB HIJBENKAEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2708050", Offset = "0x2707250", VA = "0x182708050", Slot = "5")]
		public void EOGAKOGIFFE(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2708F10", Offset = "0x2708110", VA = "0x182708F10", Slot = "6")]
		public Task KJEDDNOFLEJ(bool BFDBCMGIOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2708BC0", Offset = "0x2707DC0", VA = "0x182708BC0", Slot = "7")]
		public ByteString IIADKJHBOIN(out IDisposable KABCFBBDMBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x27089E0", Offset = "0x2707BE0", VA = "0x1827089E0", Slot = "19")]
		public ByteString IIADKJHBOIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2707870", Offset = "0x2706A70", VA = "0x182707870", Slot = "9")]
		public bool BBCFAILGGHN(ByteString KPEMNJPDMIK, ABKDLOMDPKF PANELIGGJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x27091D0", Offset = "0x27083D0", VA = "0x1827091D0")]
		private bool MKEMEBAFJBH(ByteString KPEMNJPDMIK, ABKDLOMDPKF PANELIGGJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2708400", Offset = "0x2707600", VA = "0x182708400", Slot = "8")]
		public void FPEPHLCNLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2708CA0", Offset = "0x2707EA0", VA = "0x182708CA0", Slot = "10")]
		public bool JOENGPJNKOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2707DD0", Offset = "0x2706FD0", VA = "0x182707DD0", Slot = "11")]
		public bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> GDKJDDCKGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2708900", Offset = "0x2707B00", VA = "0x182708900")]
		public bool ICKHDHPFNOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2707640", Offset = "0x2706840", VA = "0x182707640", Slot = "12")]
		public bool ALDNDHFJDLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2708170", Offset = "0x2707370", VA = "0x182708170")]
		public void FPDHFLOCKPA(CLPPOKFANAO.AMKHKIHEIFI.PKECMKDKILD CAKDMLJEJPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x27078D0", Offset = "0x2706AD0", VA = "0x1827078D0")]
		private bool DBJMLDPAHII(ByteString KPEMNJPDMIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2708120", Offset = "0x2707320", VA = "0x182708120")]
		private void FOFDBJBHBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2708FA0", Offset = "0x27081A0", VA = "0x182708FA0")]
		private ByteString MHFGAFOLGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2707C00", Offset = "0x2706E00", VA = "0x182707C00")]
		private ByteString DMDGODMJBIM(ByteString NDFFNBIIOEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2707B60", Offset = "0x2706D60", VA = "0x182707B60")]
		private CLPPOKFANAO.AMKHKIHEIFI.PKECMKDKILD DDPNGFPEIJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x27088D0", Offset = "0x2707AD0", VA = "0x1827088D0")]
		private void HBAFNLELEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2709000", Offset = "0x2708200", VA = "0x182709000", Slot = "13")]
		public bool MJFMJJDNBPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2707D20", Offset = "0x2706F20", VA = "0x182707D20", Slot = "14")]
		public void EANEPEKPFMA(bool KBMEGKLHBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2708700", Offset = "0x2707900", VA = "0x182708700")]
		private void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PNCLNBNALEO(typeof(DAHJGPKAIEK), new string[] { })]
[KKDNFMENBCC(typeof(GMIJLIFNPJO))]
internal class GMIJLIFNPJO : DAHJGPKAIEK
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action HNCHFHCCEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x269E720", Offset = "0x269D920", VA = "0x18269E720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x269E5E0", Offset = "0x269D7E0", VA = "0x18269E5E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<NCIOIFNNEKH> JIDLMIFGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x269E8B0", Offset = "0x269DAB0", VA = "0x18269E8B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x269E7C0", Offset = "0x269D9C0", VA = "0x18269E7C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action NDAEHHPCPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x269EA40", Offset = "0x269DC40", VA = "0x18269EA40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x269E9A0", Offset = "0x269DBA0", VA = "0x18269E9A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action KAFOLEIAEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x269EB80", Offset = "0x269DD80", VA = "0x18269EB80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x269E680", Offset = "0x269D880", VA = "0x18269E680", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NCIOIFNNEKH> GHJCNBJFLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x269EC20", Offset = "0x269DE20", VA = "0x18269EC20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x269EAE0", Offset = "0x269DCE0", VA = "0x18269EAE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x709380", Offset = "0x708580", VA = "0x180709380")]
	public void FPEPHLCNLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7092C0", Offset = "0x7084C0", VA = "0x1807092C0")]
	public void ILHECLANAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x907690", Offset = "0x906890", VA = "0x180907690")]
	public void JNGMJFIDOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x269E860", Offset = "0x269DA60", VA = "0x18269E860")]
	public void HMIAHNHAKNP(NCIOIFNNEKH LCMDLFOKELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x269E950", Offset = "0x269DB50", VA = "0x18269E950")]
	public void LDGCDPKHFHF(NCIOIFNNEKH LCMDLFOKELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GMIJLIFNPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[PNCLNBNALEO(typeof(GBMEAEPJCNJ), new string[] { })]
public class JBDLBCKKPHG : GBMEAEPJCNJ, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents BDDHHHHDEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private LFAFBMFMMKA KECMGBIFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService MICPPHDEBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::NOBICPNOIDE<HPHBHAKAACD> HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x814E30", Offset = "0x814030", VA = "0x180814E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x26ABB70", Offset = "0x26AAD70", VA = "0x1826ABB70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9B8450", Offset = "0x9B7650", VA = "0x1809B8450", Slot = "14")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x26ABE10", Offset = "0x26AB010", VA = "0x1826ABE10", Slot = "15")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x26AAB90", Offset = "0x26A9D90", VA = "0x1826AAB90", Slot = "16")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x9B8380", Offset = "0x9B7580", VA = "0x1809B8380", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x26AB680", Offset = "0x26AA880", VA = "0x1826AB680")]
	private HPHBHAKAACD KPBJNKCGKMG(Entity LHCPLOHKBCE)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x26AAE30", Offset = "0x26AA030", VA = "0x1826AAE30", Slot = "4")]
	public HPHBHAKAACD DMOICBPEOLI(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x26ABEE0", Offset = "0x26AB0E0", VA = "0x1826ABEE0", Slot = "19")]
	public void PKBPOFBHNCK(ref List<HPHBHAKAACD> DJGFOAKOCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x26AB480", Offset = "0x26AA680", VA = "0x1826AB480", Slot = "20")]
	public IEnumerable<HPHBHAKAACD> JENDCCHGJCA(HPHBHAKAACD EHNNHDBEJOG, bool FILPHNKNPEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x26AB6B0", Offset = "0x26AA8B0", VA = "0x1826AB6B0", Slot = "21")]
	public HPHBHAKAACD LADEPLKBNAJ(HPHBHAKAACD EHNNHDBEJOG, int GMEHLIHLGEH)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x26AB880", Offset = "0x26AAA80", VA = "0x1826AB880", Slot = "22")]
	public int LMPHCMFGFKC(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x26AB210", Offset = "0x26AA410", VA = "0x1826AB210", Slot = "8")]
	public int IDHBDBMGFID(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x26AAD40", Offset = "0x26A9F40", VA = "0x1826AAD40", Slot = "9")]
	public GNFJJEDLPLM BCILFEBJLHL(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(GNFJJEDLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9A0", Offset = "0x26AABA0", VA = "0x1826AB9A0", Slot = "23")]
	public bool MGFMCHJDKDH(HPHBHAKAACD EHNNHDBEJOG, out GNFJJEDLPLM NEGHGKBJBNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x26AAF20", Offset = "0x26AA120", VA = "0x1826AAF20", Slot = "24")]
	public IEnumerable<HPHBHAKAACD> FHNKAIJGLGA(HPHBHAKAACD EHNNHDBEJOG, bool FILPHNKNPEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x26AB3B0", Offset = "0x26AA5B0", VA = "0x1826AB3B0", Slot = "12")]
	public HPHBHAKAACD INDFLLMAOHH(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x26AB090", Offset = "0x26AA290", VA = "0x1826AB090", Slot = "13")]
	public bool GDHBJPCNPAN(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC, out HPHBHAKAACD LCFGMFPMPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x26AAFF0", Offset = "0x26AA1F0", VA = "0x1826AAFF0", Slot = "5")]
	public HPHBHAKAACD FONBPFGIHGB(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x26AAC80", Offset = "0x26A9E80", VA = "0x1826AAC80", Slot = "11")]
	public bool BAPHEPNKIJH(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD MIONKFPACCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x26ABBC0", Offset = "0x26AADC0", VA = "0x1826ABBC0", Slot = "25")]
	public bool MPHHNPLLNHA(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD AAFNLLCIFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x26ABD00", Offset = "0x26AAF00", VA = "0x1826ABD00", Slot = "10")]
	public bool NLKLELJEKDK(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IHEBNKKPFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x26AB160", Offset = "0x26AA360", VA = "0x1826AB160", Slot = "6")]
	public bool HMBNJDPGAJN(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD HHFDFFDPCGO, bool GBDGBMCMBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x26AAB20", Offset = "0x26A9D20", VA = "0x1826AAB20", Slot = "7")]
	public bool ACEDFEGBPAB(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD HHFDFFDPCGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public JBDLBCKKPHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(HMPKCBOCNEE), new string[] { })]
internal class HMPKCBOCNEE : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[GAJFPHPAPMA]
	private IIEGBNJCKEO BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, CLOLHMILBAD> DBJHFIDHFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x26A1F80", Offset = "0x26A1180", VA = "0x1826A1F80", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x26A19B0", Offset = "0x26A0BB0", VA = "0x1826A19B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x26A1D70", Offset = "0x26A0F70", VA = "0x1826A1D70")]
	public CLOLHMILBAD NFGPKLKDFHL(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x26A1C20", Offset = "0x26A0E20", VA = "0x1826A1C20")]
	public CLOLHMILBAD NFGPKLKDFHL(GFCMOFDOMMJ CHIEJFHOPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x26A1B00", Offset = "0x26A0D00", VA = "0x1826A1B00")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x26A1FD0", Offset = "0x26A11D0", VA = "0x1826A1FD0")]
	public HMPKCBOCNEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CLOLHMILBAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<CHBJMJOMPJA> BFMFGECOOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<NLOCLNGHLHN> ILNKOBPGIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<NIEMJPNNGFN> KDIMLDBLDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<NLOCLNGHLHN> IHCLPKFJAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<CHBJMJOMPJA> BNJMGPKIPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
		get
		{
			return default(NativeList<CHBJMJOMPJA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<NLOCLNGHLHN> OHNPKLHOEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB53DB0", Offset = "0xB52FB0", VA = "0x180B53DB0")]
		get
		{
			return default(NativeList<NLOCLNGHLHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<NIEMJPNNGFN> HOGPLFEHELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9D0E30", Offset = "0x9D0030", VA = "0x1809D0E30")]
		get
		{
			return default(NativeList<NIEMJPNNGFN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<NLOCLNGHLHN> LGANNHPKNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x908EE0", Offset = "0x9080E0", VA = "0x180908EE0")]
		get
		{
			return default(NativeList<NLOCLNGHLHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle KPPKAKOMOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x75C720", Offset = "0x75B920", VA = "0x18075C720")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x13810C0", Offset = "0x13802C0", VA = "0x1813810C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6FD200", Offset = "0x6FC400", VA = "0x1806FD200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PHANBMHEFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7680", Offset = "0x2AA6880", VA = "0x182AA7680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7730", Offset = "0x2AA6930", VA = "0x182AA7730")]
	public CLOLHMILBAD(Allocator HCEMBCPANJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2AA75F0", Offset = "0x2AA67F0", VA = "0x182AA75F0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7180", Offset = "0x2AA6380", VA = "0x182AA7180")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA72B0", Offset = "0x2AA64B0", VA = "0x182AA72B0")]
	public void CPCILMEHKPA(Entity LHCPLOHKBCE, Entity FLHBBDGHDCM, Entity BDBBMBMDCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[PNCLNBNALEO(typeof(OBNKKOONABD), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public class OBNKKOONABD : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[GAJFPHPAPMA]
	private SceneService DCDCBKEJKDG;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4100", Offset = "0x2AF3300", VA = "0x182AF4100", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF40E0", Offset = "0x2AF32E0", VA = "0x182AF40E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public OBNKKOONABD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[PNCLNBNALEO(typeof(PhotonInstanceCleanupService), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Lifecycle)]
	[OHBLGBNBPGG(IHBBGOJDEFH.PhotonRoom)]
	public class PhotonInstanceCleanupService : CMLEAAEGAAL, IMFHGBIDMMC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private KIMMKIKOLAA COEFNKAKJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MFNEEGAKIKC JKCBLHNHOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> GMCOJFJKPFG;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2B04740", Offset = "0x2B03940", VA = "0x182B04740", Slot = "5")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2B048D0", Offset = "0x2B03AD0", VA = "0x182B048D0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2B046A0", Offset = "0x2B038A0", VA = "0x182B046A0")]
		public void AGFEPBOGOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2B047A0", Offset = "0x2B039A0", VA = "0x182B047A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2B04940", Offset = "0x2B03B40", VA = "0x182B04940")]
		public void PCEDDJAOGCH(global::JMILGIFBIEP<int> IKBBFAHBIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2B04890", Offset = "0x2B03A90", VA = "0x182B04890")]
		public void MKCCDINEBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class MIJJJCDLCGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint GAPMPGIMDMP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint BGNDKPKOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2682020", Offset = "0x2681220", VA = "0x182682020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFBD0", Offset = "0x2AEEDD0", VA = "0x182AEFBD0")]
	public HCIIHJLICJK FCKJFIKIOEK()
	{
		return default(HCIIHJLICJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFC20", Offset = "0x2AEEE20", VA = "0x182AEFC20")]
	public void KLIGCJLPPEO(HCIIHJLICJK MIBPNJCOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x959B30", Offset = "0x958D30", VA = "0x180959B30", Slot = "6")]
	public virtual void PAKIMOKGMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected MIJJJCDLCGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(NONFIILBABE), new string[] { })]
internal sealed class NONFIILBABE : MIJJJCDLCGJ, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[GAJFPHPAPMA]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint PCKCPNGPNBJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint BGNDKPKOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB720", Offset = "0x6FA920", VA = "0x1806FB720", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF38C0", Offset = "0x2AF2AC0", VA = "0x182AF38C0", Slot = "7")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3870", Offset = "0x2AF2A70", VA = "0x182AF3870")]
	private void FPJCAPBNHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3960", Offset = "0x2AF2B60", VA = "0x182AF3960", Slot = "6")]
	public override void PAKIMOKGMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NONFIILBABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PNCLNBNALEO(typeof(MKPDCEPKKNF), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
internal sealed class MKPDCEPKKNF : MIJJJCDLCGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint BGNDKPKOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MKPDCEPKKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(NMOCPLDOEBP), new string[] { })]
internal sealed class NMOCPLDOEBP : BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery IPOIIMAFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery FNJFBPBFEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery PIKAOMMAHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery LOCIEBJDDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery LADFBBGKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery INMAEHOINIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2EA0", Offset = "0x2AF20A0", VA = "0x182AF2EA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery AAENBMHKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery EIHDDCEOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x951ED0", Offset = "0x9510D0", VA = "0x180951ED0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery BKBENCAHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA61F40", Offset = "0xA61140", VA = "0x180A61F40")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery LFIFLNHGNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x75C720", Offset = "0x75B920", VA = "0x18075C720")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery NLOCEBCHHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x75D3C0", Offset = "0x75C5C0", VA = "0x18075D3C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery DIBEBIDCCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2F10", Offset = "0x2AF2110", VA = "0x182AF2F10")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int CLIDALMBOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2EF0", Offset = "0x2AF20F0", VA = "0x182AF2EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int PCMDGMDIKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E80", Offset = "0x2AF2080", VA = "0x182AF2E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int DEIECHCAJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2DB0", Offset = "0x2AF1FB0", VA = "0x182AF2DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int KKHCLNNGAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2CB0", Offset = "0x2AF1EB0", VA = "0x182AF2CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int DGIFHJAMLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2CD0", Offset = "0x2AF1ED0", VA = "0x182AF2CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HHBJLCJNJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF27F0", Offset = "0x2AF19F0", VA = "0x182AF27F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "4")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2F90", Offset = "0x2AF2190", VA = "0x182AF2F90", Slot = "5")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2810", Offset = "0x2AF1A10", VA = "0x182AF2810", Slot = "6")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2D50", Offset = "0x2AF1F50", VA = "0x182AF2D50")]
	private EntityQueryDesc HPGBKAEELOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2CF0", Offset = "0x2AF1EF0", VA = "0x182AF2CF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2690", Offset = "0x2AF1890", VA = "0x182AF2690")]
	public JGDLLGICJJP ABHILIGPOAO(HPHBHAKAACD FLKGABKFAPI)
	{
		return default(JGDLLGICJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2740", Offset = "0x2AF1940", VA = "0x182AF2740")]
	public JGDLLGICJJP ABHILIGPOAO(Entity LHCPLOHKBCE)
	{
		return default(JGDLLGICJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2DD0", Offset = "0x2AF1FD0", VA = "0x182AF2DD0")]
	public CNKGPKGDJHD KIFHAIDEHFN(Entity LHCPLOHKBCE)
	{
		return default(CNKGPKGDJHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2FE0", Offset = "0x2AF21E0", VA = "0x182AF2FE0")]
	public NMOCPLDOEBP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CGDKNMKPKIP(OOBCCNCEGNI.All)]
	[PNCLNBNALEO(typeof(FMAHBOCPDMM), new string[] { })]
	public class ObjectService : CMLEAAEGAAL, FMAHBOCPDMM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly HDHIMOFHFJL CKFPBBBLFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[GAJFPHPAPMA]
		private LHKILEMFMKD JBDCCFIPMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[GAJFPHPAPMA]
		private ObjectLifecycleService FBCDDJGNMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[GAJFPHPAPMA]
		private ObjectEmbodimentService MICPPHDEBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[GAJFPHPAPMA]
		private ObjectInstantiationService ELFOBADGBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[GAJFPHPAPMA]
		private NMOCPLDOEBP KECMGBIFIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService BDHLICLKMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public LHKILEMFMKD FIFLKDCJGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CLIDALMBOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFB20", Offset = "0x2AFED20", VA = "0x182AFFB20", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int PCMDGMDIKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF500", Offset = "0x2AFE700", VA = "0x182AFF500", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int DEIECHCAJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2AFF360", Offset = "0x2AFE560", VA = "0x182AFF360", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int KKHCLNNGAGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE6D0", Offset = "0x2AFD8D0", VA = "0x182AFE6D0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int DGIFHJAMLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEA50", Offset = "0x2AFDC50", VA = "0x182AFEA50", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int HHBJLCJNJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE170", Offset = "0x2AFD370", VA = "0x182AFE170", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<HPHBHAKAACD, CNKGPKGDJHD> LDLKENKALDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEFC0", Offset = "0x2AFE1C0", VA = "0x182AFEFC0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE910", Offset = "0x2AFDB10", VA = "0x182AFE910", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<HPHBHAKAACD> HMAFJEGIFHG
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEEB0", Offset = "0x2AFE0B0", VA = "0x182AFEEB0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE9B0", Offset = "0x2AFDBB0", VA = "0x182AFE9B0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFE80", Offset = "0x2AFF080", VA = "0x182AFFE80", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEB40", Offset = "0x2AFDD40", VA = "0x182AFEB40", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE440", Offset = "0x2AFD640", VA = "0x182AFE440")]
		private void BLJDCEHOCGI(Entity LHCPLOHKBCE, CNKGPKGDJHD FNGBDAJENGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE20", Offset = "0x2AFE020", VA = "0x182AFEE20")]
		private void GMJIGMBFPEG(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF4E0", Offset = "0x2AFE6E0", VA = "0x182AFF4E0")]
		internal HPHBHAKAACD KPBJNKCGKMG(Entity LHCPLOHKBCE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF8E0", Offset = "0x2AFEAE0", VA = "0x182AFF8E0", Slot = "41")]
		public GNFJJEDLPLM NAJHFFJAIPE()
		{
			return default(GNFJJEDLPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF530", Offset = "0x2AFE730", VA = "0x182AFF530", Slot = "42")]
		public GNFJJEDLPLM MCKJHIICOFD()
		{
			return default(GNFJJEDLPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFECC0", Offset = "0x2AFDEC0", VA = "0x182AFECC0", Slot = "43")]
		public GNFJJEDLPLM EIHDCLOHFJC()
		{
			return default(GNFJJEDLPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDF10", Offset = "0x2AFD110", VA = "0x182AFDF10", Slot = "10")]
		public JGDLLGICJJP ABHILIGPOAO(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(JGDLLGICJJP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF390", Offset = "0x2AFE590", VA = "0x182AFF390", Slot = "11")]
		public CNKGPKGDJHD KIFHAIDEHFN(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(CNKGPKGDJHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDFD0", Offset = "0x2AFD1D0", VA = "0x182AFDFD0")]
		private GNFJJEDLPLM ACHEJJNOGBJ(EntityQuery ADGIOFAMOGF)
		{
			return default(GNFJJEDLPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA10", Offset = "0x2AFEC10", VA = "0x182AFFA10", Slot = "33")]
		public bool NHKKABBPFMM(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA80", Offset = "0x2AFDC80", VA = "0x182AFEA80", Slot = "29")]
		public void DPHICADNPGH(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE700", Offset = "0x2AFD900", VA = "0x182AFE700", Slot = "30")]
		public void DANFAKHLGOC(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF110", Offset = "0x2AFE310", VA = "0x182AFF110", Slot = "31")]
		public void JIMJGJIDNNL(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE580", Offset = "0x2AFD780", VA = "0x182AFE580", Slot = "22")]
		public DBJMAFIOFFK CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB, bool GFHAAPIGHIF)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE500", Offset = "0x2AFD700", VA = "0x182AFE500", Slot = "23")]
		public DBJMAFIOFFK CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF980", Offset = "0x2AFEB80", VA = "0x182AFF980", Slot = "24")]
		public DBJMAFIOFFK NFOGFCJILOM(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFB50", Offset = "0x2AFED50", VA = "0x182AFFB50", Slot = "25")]
		public DBJMAFIOFFK OADPHDJIIGP(HCIIHJLICJK MIBPNJCOIHL, CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF50", Offset = "0x2AFE150", VA = "0x182AFEF50", Slot = "44")]
		public DBJMAFIOFFK HGIHMBBECDB(int KCMCNJPECMK, CNKGPKGDJHD FNGBDAJENGB, GameObject BMNLOPDIJGF)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFDA0", Offset = "0x2AFEFA0", VA = "0x182AFFDA0", Slot = "26")]
		public CCHAJLMBAFD OBAIKOPBHAP()
		{
			return default(CCHAJLMBAFD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF260", Offset = "0x2AFE460", VA = "0x182AFF260", Slot = "45")]
		public CJFJLIBCADD KCJIMEICAKG(JCHIOIGOACO NIFOGEBEDNG)
		{
			return default(CJFJLIBCADD);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF060", Offset = "0x2AFE260", VA = "0x182AFF060", Slot = "27")]
		public HHHGBHBOEAD JFFGKANLKKJ()
		{
			return default(HHHGBHBOEAD);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF640", Offset = "0x2AFE840", VA = "0x182AFF640", Slot = "28")]
		public MAIEHBDIIPL MEMDCEONKOF(HAGCJKKHBBM NIFOGEBEDNG)
		{
			return default(MAIEHBDIIPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE4E0", Offset = "0x2AFD6E0", VA = "0x182AFE4E0", Slot = "12")]
		public void BNAKCAAHHPA(HCIIHJLICJK MIBPNJCOIHL, ACPBHPEJKKH LCEEIDPAOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE760", Offset = "0x2AFD960", VA = "0x182AFE760", Slot = "13")]
		public DBJMAFIOFFK DDGNNJCHMPH(HPHBHAKAACD EHNNHDBEJOG, [Optional] object IALNODEHBNN)
		{
			return default(DBJMAFIOFFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF840", Offset = "0x2AFEA40", VA = "0x182AFF840", Slot = "14")]
		public bool MLOGCIOJFGP(HPHBHAKAACD EHNNHDBEJOG, out ACPBHPEJKKH CDNLFEOBNKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF210", Offset = "0x2AFE410", VA = "0x182AFF210", Slot = "46")]
		public Transform KAFNOFKKMEB(HPHBHAKAACD EHNNHDBEJOG, [Optional] object IALNODEHBNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE3F0", Offset = "0x2AFD5F0", VA = "0x182AFE3F0", Slot = "16")]
		public bool BGEAIJHMDMH(HPHBHAKAACD EHNNHDBEJOG, out Transform FGNGGLFNLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2AFED60", Offset = "0x2AFDF60", VA = "0x182AFED60", Slot = "17")]
		public bool FEMFMLHCJLP(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1E0", Offset = "0x2AFE3E0", VA = "0x182AFF1E0")]
		public bool JOBEBJPEIMK(ACPBHPEJKKH IPMIIEAGJKC, [Optional] object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF1B0", Offset = "0x2AFE3B0", VA = "0x182AFF1B0", Slot = "47")]
		public bool JOBEBJPEIMK(HPHBHAKAACD EHNNHDBEJOG, [Optional] object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF760", Offset = "0x2AFE960", VA = "0x182AFF760", Slot = "48")]
		public void MFCPBIGBMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE1A0", Offset = "0x2AFD3A0", VA = "0x182AFE1A0", Slot = "15")]
		public void AGBINPBGJOB(ACPBHPEJKKH ICHBECDKHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFE40", Offset = "0x2AFF040", VA = "0x182AFFE40", Slot = "49")]
		public void OFHCHFPGGCO(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF460", Offset = "0x2AFE660", VA = "0x182AFF460", Slot = "18")]
		public bool KMOEKAMFDFB(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFAA0", Offset = "0x2AFECA0", VA = "0x182AFFAA0", Slot = "19")]
		public bool NIPPIJKNOFO(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEDB0", Offset = "0x2AFDFB0", VA = "0x182AFEDB0", Slot = "50")]
		public bool GLHBEGDCMJP(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEAD0", Offset = "0x2AFDCD0", VA = "0x182AFEAD0", Slot = "51")]
		public bool DPJDPBNCGNP(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE670", Offset = "0x2AFD870", VA = "0x182AFE670", Slot = "32")]
		public NativeArray<(HPHBHAKAACD, HPHBHAKAACD)> CLKBEFKLIOC(NativeArray<HPHBHAKAACD> KLBGBDPJKJM, Allocator HCEMBCPANJM)
		{
			return default(NativeArray<(HPHBHAKAACD, HPHBHAKAACD)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE350", Offset = "0x2AFD550", VA = "0x182AFE350", Slot = "21")]
		public HCIIHJLICJK ANDMDOJLAPG(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HCIIHJLICJK);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE080", Offset = "0x2AFD280", VA = "0x182AFE080", Slot = "20")]
		public HPHBHAKAACD ADIDIKPFHIK(HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF780", Offset = "0x2AFE980", VA = "0x182AFF780")]
		private void MJOCHMLAFIP(CNKGPKGDJHD FNGBDAJENGB, HPHBHAKAACD EHNNHDBEJOG, HCIIHJLICJK MIBPNJCOIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(DCDKBJNNODB), new string[] { })]
internal sealed class DCDKBJNNODB : CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService ELFOBADGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[GAJFPHPAPMA]
	private NMOCPLDOEBP KECMGBIFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2AB46F0", Offset = "0x2AB38F0", VA = "0x182AB46F0", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3B10", Offset = "0x2AB2D10", VA = "0x182AB3B10")]
	public NativeArray<(HPHBHAKAACD, HPHBHAKAACD)> CLKBEFKLIOC(NativeArray<HPHBHAKAACD> KLBGBDPJKJM, Allocator HCEMBCPANJM)
	{
		return default(NativeArray<(HPHBHAKAACD, HPHBHAKAACD)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2AB40A0", Offset = "0x2AB32A0", VA = "0x182AB40A0")]
	private void DIDMEPMPKDM(NativeMultiHashMap<int, (HPHBHAKAACD src, HPHBHAKAACD dst)> JNGHCEEEKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3C10", Offset = "0x2AB2E10", VA = "0x182AB3C10")]
	private void DEEDLDFGIAF(NativeMultiHashMap<int, (HPHBHAKAACD src, HPHBHAKAACD dst)> JNGHCEEEKLF, int FNGBDAJENGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4280", Offset = "0x2AB3480", VA = "0x182AB4280")]
	private void JPJNFNOFJPI(NativeMultiHashMap<int, (HPHBHAKAACD src, HPHBHAKAACD dst)> JNGHCEEEKLF, int FNGBDAJENGB, CMBJNHHMHON BBBOEOJJCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4410", Offset = "0x2AB3610", VA = "0x182AB4410")]
	private NativeMultiHashMap<int, (HPHBHAKAACD, HPHBHAKAACD)> KNMHJCMLGLO(Allocator HCEMBCPANJM, NativeArray<HPHBHAKAACD> KLBGBDPJKJM, out NativeArray<(HPHBHAKAACD src, HPHBHAKAACD dst)> JKLENFFMHAP)
	{
		return default(NativeMultiHashMap<int, (HPHBHAKAACD, HPHBHAKAACD)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public DCDKBJNNODB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	[KKDNFMENBCC(typeof(TransformService))]
	[PNCLNBNALEO(typeof(EFDNEMMCCPM), new string[] { })]
	public class TransformService : EFDNEMMCCPM, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly HDHIMOFHFJL JIEHBNILKHJ;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly HDHIMOFHFJL EDFAGGCMANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private AGGPPPAPABE JIPLOFKCDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private GBMEAEPJCNJ HKPONLMBIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase OOHAKGKBJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService BBFEJKBBFEI;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2712AE0", Offset = "0x2711CE0", VA = "0x182712AE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private DKCBHGMJMEO GHECNMHOJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x270F570", Offset = "0x270E770", VA = "0x18270F570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2713D60", Offset = "0x2712F60", VA = "0x182713D60", Slot = "33")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x27111C0", Offset = "0x27103C0", VA = "0x1827111C0", Slot = "34")]
		public bool IKGNABIGCLP(Transform FGNGGLFNLIP, out HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2711380", Offset = "0x2710580", VA = "0x182711380", Slot = "35")]
		public Transform IPMPHFIAIJC(Entity LHCPLOHKBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x270F480", Offset = "0x270E680", VA = "0x18270F480", Slot = "30")]
		public bool BGEAIJHMDMH(Entity LHCPLOHKBCE, out Transform FGNGGLFNLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2713F10", Offset = "0x2713110", VA = "0x182713F10")]
		private void PJBFDENKCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2712B30", Offset = "0x2711D30", VA = "0x182712B30", Slot = "29")]
		public void MKBDAOGLDNJ(Entity LHCPLOHKBCE, out Matrix4x4 LFDBEEJGILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2710FD0", Offset = "0x27101D0", VA = "0x182710FD0", Slot = "4")]
		public void IIMDMKNAADM(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2710430", Offset = "0x270F630", VA = "0x182710430")]
		public void DMGMCEDFCLG(Entity LHCPLOHKBCE, Vector3 EGJKEDKNNAD, Quaternion IBHAEICNMJI, Vector3 KIJDIOHEBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2713B50", Offset = "0x2712D50", VA = "0x182713B50")]
		public void OLJJCBOPOHP(Entity LHCPLOHKBCE, Vector3 EGJKEDKNNAD, Quaternion IBHAEICNMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2710BF0", Offset = "0x270FDF0", VA = "0x182710BF0", Slot = "27")]
		public void GLECOPJMCMG(Entity LHCPLOHKBCE, out Matrix4x4 OMHDLHAHJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x27124F0", Offset = "0x27116F0", VA = "0x1827124F0")]
		public void MCGIOOEPIDG(Entity LHCPLOHKBCE, in Matrix4x4 LFDBEEJGILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2712C80", Offset = "0x2711E80", VA = "0x182712C80")]
		public void NGMDMGNDABB(Entity LHCPLOHKBCE, in Matrix4x4 LFDBEEJGILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x27131A0", Offset = "0x27123A0", VA = "0x1827131A0")]
		public void NPLOJEPPEAH(Entity LHCPLOHKBCE, in Matrix4x4 GLDGKHOMBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2710220", Offset = "0x270F420", VA = "0x182710220", Slot = "5")]
		public void DAHMNDIEKOJ(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2710AE0", Offset = "0x270FCE0", VA = "0x182710AE0", Slot = "6")]
		public Vector3 GALIDLPMDIJ(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x270F750", Offset = "0x270E950", VA = "0x18270F750", Slot = "7")]
		public void CCIMDIMBMEJ(Entity LHCPLOHKBCE, Quaternion IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2710340", Offset = "0x270F540", VA = "0x182710340", Slot = "8")]
		public Quaternion DIBFIDPIMBO(Entity LHCPLOHKBCE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2713C60", Offset = "0x2712E60", VA = "0x182713C60", Slot = "12")]
		public void OMOHCCEOCEO(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2711440", Offset = "0x2710640", VA = "0x182711440", Slot = "11")]
		public Vector3 JDMEKEJNKID(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2713360", Offset = "0x2712560", VA = "0x182713360")]
		public void OBHFJEOHPOM(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2713E70", Offset = "0x2713070", VA = "0x182713E70")]
		private Vector3 PHJLOAKLMBL(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2710A40", Offset = "0x270FC40", VA = "0x182710A40", Slot = "14")]
		public float FOMNBFLBFHN(Entity LHCPLOHKBCE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x270F850", Offset = "0x270EA50", VA = "0x18270F850", Slot = "13")]
		public void CHMABLGOIJL(Entity LHCPLOHKBCE, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2713F30", Offset = "0x2713130", VA = "0x182713F30")]
		private float PKHPODAEEED(Entity LHCPLOHKBCE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x270F180", Offset = "0x270E380", VA = "0x18270F180")]
		public void APJNFKFCGPE(Entity LHCPLOHKBCE, float PNCKIBAHOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2711BF0", Offset = "0x2710DF0", VA = "0x182711BF0", Slot = "16")]
		public Vector3 KDEIALMOCID(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x27135C0", Offset = "0x27127C0", VA = "0x1827135C0", Slot = "15")]
		public void OGNICNBBMCJ(Entity LHCPLOHKBCE, Vector3 GCKGLDCFMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2710000", Offset = "0x270F200", VA = "0x182710000")]
		private Vector3 CJPHAFDDLNG(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2710890", Offset = "0x270FA90", VA = "0x182710890")]
		public void FIDOEDPOBDE(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2711A40", Offset = "0x2710C40", VA = "0x182711A40")]
		[Conditional("DEBUG_BUILD")]
		private void KAPHLBFJJBB(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x270F020", Offset = "0x270E220", VA = "0x18270F020", Slot = "36")]
		public void AEEJPEPBFAF(Entity LHCPLOHKBCE, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2710C80", Offset = "0x270FE80", VA = "0x182710C80", Slot = "9")]
		public void HDNBMELGOGH(Entity LHCPLOHKBCE, out Vector3 INLGLHIPOMC, out Quaternion HEGBBJCMANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x270F210", Offset = "0x270E410", VA = "0x18270F210", Slot = "10")]
		public void BBBGBLNGHNF(Entity LHCPLOHKBCE, out Vector3 INLGLHIPOMC, out Quaternion HEGBBJCMANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2710500", Offset = "0x270F700", VA = "0x182710500", Slot = "37")]
		public void EIKAMBECNHN(Entity LHCPLOHKBCE, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2713400", Offset = "0x2712600", VA = "0x182713400")]
		public void OCHNPGIAFGC(Entity LHCPLOHKBCE, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x27128B0", Offset = "0x2711AB0", VA = "0x1827128B0", Slot = "17")]
		public void MHCIPMAEJHH(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2710DD0", Offset = "0x270FFD0", VA = "0x182710DD0", Slot = "18")]
		public Vector3 HIOOMKMFAEI(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2711CD0", Offset = "0x2710ED0", VA = "0x182711CD0", Slot = "19")]
		public void LCGLLJKOBHG(Entity LHCPLOHKBCE, Quaternion IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x27122B0", Offset = "0x27114B0", VA = "0x1827122B0", Slot = "20")]
		public Quaternion LNEBNHNAFJL(Entity LHCPLOHKBCE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x27136F0", Offset = "0x27128F0", VA = "0x1827136F0", Slot = "22")]
		public void OHLPFAEGBCE(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2710130", Offset = "0x270F330", VA = "0x182710130", Slot = "21")]
		public Vector3 CLLDHEOIHOG(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2710720", Offset = "0x270F920", VA = "0x182710720", Slot = "23")]
		public void FHPENJKEEBM(Entity LHCPLOHKBCE, float GDGAJBPKLLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2710EB0", Offset = "0x27100B0", VA = "0x182710EB0", Slot = "24")]
		public float IHPDJPNINJD(Entity LHCPLOHKBCE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2711550", Offset = "0x2710750", VA = "0x182711550", Slot = "25")]
		public void JGKNOBBJHNB(Entity LHCPLOHKBCE, Vector3 KHAGANDBPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x270F340", Offset = "0x270E540", VA = "0x18270F340", Slot = "26")]
		public Vector3 BFGFDDADEDE(Entity LHCPLOHKBCE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x270F960", Offset = "0x270EB60", VA = "0x18270F960", Slot = "31")]
		public void CJDAFAFEAIC(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x27123A0", Offset = "0x27115A0", VA = "0x1827123A0")]
		private HPHBHAKAACD LNGJKGCDPDB(Transform FGNGGLFNLIP)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2712F60", Offset = "0x2712160", VA = "0x182712F60")]
		private static TransformEntity NOFLIICNKIO(CNKGPKGDJHD NIFOGEBEDNG, GameObject HKPJJHILEBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x270F630", Offset = "0x270E830", VA = "0x18270F630", Slot = "32")]
		public void BNMDIPAOMFL(Entity LHCPLOHKBCE, Entity FLHBBDGHDCM, Entity BDBBMBMDCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2710C00", Offset = "0x270FE00", VA = "0x182710C00")]
		private EAHKGOKECOC HDNBMELGOGH(Entity LHCPLOHKBCE)
		{
			return default(EAHKGOKECOC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2710960", Offset = "0x270FB60", VA = "0x182710960")]
		private bool FKKONLLOFNH(Entity LHCPLOHKBCE, out Entity HHFDFFDPCGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2712DB0", Offset = "0x2711FB0", VA = "0x182712DB0")]
		private void NIOMAFMMKAD(Entity LHCPLOHKBCE, out Matrix4x4 LFDBEEJGILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2711F10", Offset = "0x2711110", VA = "0x182711F10")]
		private void LDHBAFEJJPM(Entity LHCPLOHKBCE, out Matrix4x4 GLDGKHOMBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2713190", Offset = "0x2712390", VA = "0x182713190", Slot = "28")]
		private void NPIIGFOAFDK(Entity LHCPLOHKBCE, in Matrix4x4 OMHDLHAHJCK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
[PNCLNBNALEO(typeof(ANGAOMBJHLI), new string[] { })]
internal sealed class ANGAOMBJHLI : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[GAJFPHPAPMA]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0650", Offset = "0x2A9F850", VA = "0x182AA0650", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA05E0", Offset = "0x2A9F7E0", VA = "0x182AA05E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ANGAOMBJHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(GDCABLCOFAB), new string[] { })]
public class GDCABLCOFAB
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct ECPFKJDFFEH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly GDCABLCOFAB HHFDFFDPCGO;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x34D0B20", Offset = "0x34CFD20", VA = "0x1834D0B20")]
		public ECPFKJDFFEH(GDCABLCOFAB HHFDFFDPCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x34D0B00", Offset = "0x34CFD00", VA = "0x1834D0B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int CKGGFAHNAJG;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MHLIJOCLDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x997E90", Offset = "0x997090", VA = "0x180997E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action AJPFGIMOLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x269D6C0", Offset = "0x269C8C0", VA = "0x18269D6C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x269D620", Offset = "0x269C820", VA = "0x18269D620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x269D5F0", Offset = "0x269C7F0", VA = "0x18269D5F0")]
	public ECPFKJDFFEH CADKLBBONJH()
	{
		return default(ECPFKJDFFEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xEA0AF0", Offset = "0xE9FCF0", VA = "0x180EA0AF0")]
	public void MAHFEFGMLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x269D760", Offset = "0x269C960", VA = "0x18269D760")]
	public void PGJKHKIIGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public GDCABLCOFAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PNCLNBNALEO(typeof(MDBGNGDHHEL), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public class MDBGNGDHHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int CKGGFAHNAJG;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool OKNMIKICIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x702610", Offset = "0x701810", VA = "0x180702610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x11D4A30", Offset = "0x11D3C30", VA = "0x1811D4A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MDBGNGDHHEL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[PNCLNBNALEO(typeof(EnableComponentSystemsInScope), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : CMLEAAEGAAL, AFECAIPELEB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct BKCEGNIAHOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> IENFNJLMHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> EMBOJIFBMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> FKEFELCGCOI;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x34CEDF0", Offset = "0x34CDFF0", VA = "0x1834CEDF0")]
			public BKCEGNIAHOF(NativeArray<int> IENFNJLMHAN, NativeArray<int> EMBOJIFBMBL, Dictionary<ComponentSystemBase, int> FKEFELCGCOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x34CEB70", Offset = "0x34CDD70", VA = "0x1834CEB70")]
			public void HDJJFAIGIKC(IEnumerable<ComponentSystemBase> JBDCCFIPMAL, IHBBGOJDEFH KPEGPAPKKGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class KLPBPBEIJNE : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
			[DebuggerHidden]
			public KLPBPBEIJNE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x34D7910", Offset = "0x34D6B10", VA = "0x1834D7910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x34D7AE0", Offset = "0x34D6CE0", VA = "0x1834D7AE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x34D7A30", Offset = "0x34D6C30", VA = "0x1834D7A30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x34D7A30", Offset = "0x34D6C30", VA = "0x1834D7A30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const IHBBGOJDEFH OJGBLEFFBFE = IHBBGOJDEFH.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly HDHIMOFHFJL AFDEHEECKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private BLBDINABANB LBBJCIBEDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> BMMANBGEHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> OMADJBDJCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int EOGFAFNNICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IHBBGOJDEFH LAAPJDBEPAO;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2694070", Offset = "0x2693270", VA = "0x182694070", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2693680", Offset = "0x2692880", VA = "0x182693680", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2693530", Offset = "0x2692730", VA = "0x182693530")]
		[IteratorStateMachine(typeof(KLPBPBEIJNE))]
		private IEnumerable<ComponentSystemBase> BFKFKKLOBHN(int EBEICGFALNG, int OGINPOLMPBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2693710", Offset = "0x2692910", VA = "0x182693710", Slot = "5")]
		public void FKGJCGANBPC(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2693F20", Offset = "0x2693120", VA = "0x182693F20")]
		private void OJPFNEHBMOJ(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2693E20", Offset = "0x2693020", VA = "0x182693E20")]
		public void OJPFNEHBMOJ(IHBBGOJDEFH OOBOIODABDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x26939F0", Offset = "0x2692BF0", VA = "0x1826939F0")]
		private void NFEODPKBAJA(IHBBGOJDEFH OOBOIODABDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2693960", Offset = "0x2692B60", VA = "0x182693960")]
		private void MHMDPHMCLOM(IHBBGOJDEFH OOBOIODABDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2693620", Offset = "0x2692820", VA = "0x182693620")]
		private void DFBFEBLNKOG(IHBBGOJDEFH OOBOIODABDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2693740", Offset = "0x2692940", VA = "0x182693740")]
		private void JFCGFCNKLEF(int EBEICGFALNG, int OGINPOLMPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2693860", Offset = "0x2692A60", VA = "0x182693860")]
		private void KEKBKJGNAEM(int EBEICGFALNG, int OGINPOLMPBC, bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2693720", Offset = "0x2692920", VA = "0x182693720")]
		private int HDELDKBLLBC(IHBBGOJDEFH OOBOIODABDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x26940F0", Offset = "0x26932F0", VA = "0x1826940F0")]
		private bool PKGDCOJKCCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2693C80", Offset = "0x2692E80", VA = "0x182693C80")]
		private Dictionary<ComponentSystemBase, int> ODKJBKPOAHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2693920", Offset = "0x2692B20", VA = "0x182693920")]
		private void LOHODJEBHJN(NativeArray<int> IENFNJLMHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2693D70", Offset = "0x2692F70", VA = "0x182693D70")]
		private void OEEHMDNMKEM(NativeArray<int> EMBOJIFBMBL, NativeArray<int> IENFNJLMHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2693800", Offset = "0x2692A00", VA = "0x182693800")]
		private static IHBBGOJDEFH JPBALPIAPFN(Type NIFOGEBEDNG, IHBBGOJDEFH GFLAEOLMKMC)
		{
			return default(IHBBGOJDEFH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2694770", Offset = "0x2693970", VA = "0x182694770")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2694680", Offset = "0x2693880", VA = "0x182694680")]
		[CompilerGenerated]
		private void PKPMDFEGPPI(CMLEAAEGAAL MGANECJBPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x26935C0", Offset = "0x26927C0", VA = "0x1826935C0")]
		[CompilerGenerated]
		private void BKKMNAJKNFH(BDLDACMOPAJ MGANECJBPPL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CGDKNMKPKIP(OOBCCNCEGNI.WorldService)]
	[PNCLNBNALEO(typeof(AEOPHBOKNJI), new string[] { })]
	public class TickService : CMLEAAEGAAL, AEOPHBOKNJI
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker HFPDIIMIJEO;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker MFIEIEJKFBB;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker HGPJAEAMFHE;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker KNECKFBDGAC;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker ALDCGJIPNDP;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker EKKIMELANEO;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker PEBOIKPDOJN;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker EIPJNBJAMKJ;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker GCIEHFLANJO;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker MFHEOFLFEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[GAJFPHPAPMA]
		private KNMAKEFNGNA MAHBIJBCNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[GAJFPHPAPMA]
		private LFKALMDGEEP KPFNANKNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[GAJFPHPAPMA]
		private TransformOwnershipPhase NFKHPOBLOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[GAJFPHPAPMA]
		private TimeService FNMIGFKCOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private NNHDOGKABEI PHAHHGAAFFH;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool CAIEJKCOKID
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x270D3E0", Offset = "0x270C5E0", VA = "0x18270D3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool NKCBJKNAPHH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x270DE00", Offset = "0x270D000", VA = "0x18270DE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool LLPBKIIHEFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x270D3E0", Offset = "0x270C5E0", VA = "0x18270D3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool JFCODCBJHPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x270D3E0", Offset = "0x270C5E0", VA = "0x18270D3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x270DEA0", Offset = "0x270D0A0", VA = "0x18270DEA0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x270D450", Offset = "0x270C650", VA = "0x18270D450", Slot = "14")]
		public void EOOLFFNBHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x270D640", Offset = "0x270C840", VA = "0x18270D640", Slot = "15")]
		public void JGFKENHCNCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x270DBB0", Offset = "0x270CDB0", VA = "0x18270DBB0", Slot = "5")]
		public void MJNKIGLGIIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x270D260", Offset = "0x270C460", VA = "0x18270D260", Slot = "6")]
		public void CEFHGBFEACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x270D760", Offset = "0x270C960", VA = "0x18270D760", Slot = "7")]
		public void JJEPIJINDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x270D8E0", Offset = "0x270CAE0", VA = "0x18270D8E0", Slot = "8")]
		public void JPACPCLKKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x270DC80", Offset = "0x270CE80", VA = "0x18270DC80", Slot = "9")]
		public void OBHENKHGBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x270E010", Offset = "0x270D210", VA = "0x18270E010", Slot = "10")]
		public void PCODEBEMIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x270D570", Offset = "0x270C770", VA = "0x18270D570", Slot = "11")]
		public void GDPHKOCOMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
		public void KPBNOMFGFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x270DA60", Offset = "0x270CC60", VA = "0x18270DA60", Slot = "12")]
		public void MFIBFLOKJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[PNCLNBNALEO(typeof(DGHIBPMIJHM), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.WorldService)]
	public class WorldService : DGHIBPMIJHM, IDisposable, IMFHGBIDMMC, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private NNHDOGKABEI PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private PLHDIIJFCAF PNLHDLKHNBP;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public NNHDOGKABEI JCJGOFJEAMC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public DKCBHGMJMEO GHECNMHOJNG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2698AC0", Offset = "0x2697CC0", VA = "0x182698AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x271C580", Offset = "0x271B780", VA = "0x18271C580", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool ICJICHLKHIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x271C130", Offset = "0x271B330", VA = "0x18271C130", Slot = "10")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x271C5A0", Offset = "0x271B7A0", VA = "0x18271C5A0", Slot = "11")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x271C470", Offset = "0x271B670", VA = "0x18271C470")]
		private void GPGHDDABLEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x271C240", Offset = "0x271B440", VA = "0x18271C240", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x271C110", Offset = "0x271B310", VA = "0x18271C110", Slot = "8")]
		public ComponentSystemBase BFGAGKFLBOH(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[PNCLNBNALEO(typeof(MELJJCPNELB), new string[] { })]
public sealed class HGOHOICDMOG : MELJJCPNELB, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class LDNELJIBNKH : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34D86E0", Offset = "0x34D78E0", VA = "0x1834D86E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E99350", Offset = "0x1E98550", VA = "0x181E99350")]
		[DebuggerHidden]
		public LDNELJIBNKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x34D83D0", Offset = "0x34D75D0", VA = "0x1834D83D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x34D86A0", Offset = "0x34D78A0", VA = "0x1834D86A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x34D8600", Offset = "0x34D7800", VA = "0x1834D8600", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x34D8600", Offset = "0x34D7800", VA = "0x1834D8600", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[GAJFPHPAPMA]
	private BPDDKPBGCMN BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DDENPILBOMA EHCOGLIEAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, GGDBENAILOJ> DBFMCDMHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, PBKJFIBPHPK> PKPILCKFJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<KFBCGBKCDNN> PCALELEHBBK;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PBKJFIBPHPK KFHJECENHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x26A0670", Offset = "0x269F870", VA = "0x1826A0670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<KFBCGBKCDNN> IMPKGELLDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x26A1140", Offset = "0x26A0340", VA = "0x1826A1140", Slot = "8")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x26A0250", Offset = "0x269F450", VA = "0x1826A0250", Slot = "9")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x26A06D0", Offset = "0x269F8D0", VA = "0x1826A06D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x26A10B0", Offset = "0x26A02B0", VA = "0x1826A10B0", Slot = "6")]
	public bool ODJDDAKCLIP(KFBCGBKCDNN IDBLFHOOMPH, out PBKJFIBPHPK CIFHMNKCLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x26A0B20", Offset = "0x269FD20", VA = "0x1826A0B20")]
	private void JBBOEPNJIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x26A0270", Offset = "0x269F470", VA = "0x1826A0270")]
	private void BIEPLMOCLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x26A0EB0", Offset = "0x26A00B0", VA = "0x1826A0EB0")]
	private GGDBENAILOJ JDILHKOFMJC(string KGNKFDEMKCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x26A0670", Offset = "0x269F870", VA = "0x1826A0670")]
	private GGDBENAILOJ DDEDCPNDLGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x26A0840", Offset = "0x269FA40", VA = "0x1826A0840")]
	private GGDBENAILOJ FLBPINKGOCF(string KGNKFDEMKCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x26A0410", Offset = "0x269F610", VA = "0x1826A0410")]
	private GGDBENAILOJ CGPJHJGEEOJ(string KDENKOIEIEI, string IALNODEHBNN, [Optional] GGDBENAILOJ DLPJOIPNLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x26A0F60", Offset = "0x26A0160", VA = "0x1826A0F60")]
	[IteratorStateMachine(typeof(LDNELJIBNKH))]
	private IEnumerable<(string, string)> LNDPPEMKBIJ(string KGNKFDEMKCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x26A0F10", Offset = "0x26A0110", VA = "0x1826A0F10")]
	private bool KNLKHGFBLLE(KFBCGBKCDNN IDBLFHOOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x26A0760", Offset = "0x269F960", VA = "0x1826A0760")]
	private DDENPILBOMA FGGJPCLOMLJ(KFBCGBKCDNN IDBLFHOOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x26A0FD0", Offset = "0x26A01D0", VA = "0x1826A0FD0")]
	private DDENPILBOMA LPNAECFPJDB(KFBCGBKCDNN IDBLFHOOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x26A1020", Offset = "0x26A0220", VA = "0x1826A1020")]
	private DDENPILBOMA MCBFNLFHKAL(KFBCGBKCDNN IDBLFHOOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2270BC0", Offset = "0x226FDC0", VA = "0x182270BC0")]
	private T LINOBOLCOMO<T>(KFBCGBKCDNN IDBLFHOOMPH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x26A0AB0", Offset = "0x269FCB0", VA = "0x1826A0AB0")]
	private FieldInfo IGIHHGBKKPD(KFBCGBKCDNN IDBLFHOOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x26A11A0", Offset = "0x26A03A0", VA = "0x1826A11A0")]
	public HGOHOICDMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x26A05E0", Offset = "0x269F7E0", VA = "0x1826A05E0")]
	[CompilerGenerated]
	private int DAPJCJKJBDE(KFBCGBKCDNN NNMPJECKECI, KFBCGBKCDNN EFNJCAIBDLA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class GGDBENAILOJ : PBKJFIBPHPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string LMCPBPEPKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly GGDBENAILOJ DLPJOIPNLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<GGDBENAILOJ> FHACAOEPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<KFBCGBKCDNN> BBBOEOJJCHM;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string ECNPIJJFGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PBKJFIBPHPK HLKBCFCIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<PBKJFIBPHPK> ICAFHKPCPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<KFBCGBKCDNN> IGAEILAANOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x269D780", Offset = "0x269C980", VA = "0x18269D780")]
	public GGDBENAILOJ(string KNOPFGAGMCN, GGDBENAILOJ HHFDFFDPCGO)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[PNCLNBNALEO(typeof(IDEMJNMNAMN), new string[] { })]
	[KKDNFMENBCC(typeof(HistoryService))]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	public class HistoryService : CMLEAAEGAAL, IDisposable, IDEMJNMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum ONIGPHICNDD
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct KFNDFEOAHAJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly ONIGPHICNDD BNECLICDEPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService BDIJLBAAEHA;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x34D6300", Offset = "0x34D5500", VA = "0x1834D6300")]
			public KFNDFEOAHAJ(HistoryService BDIJLBAAEHA, bool DICOJFNIJHJ, uint EOGFAFNNICF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x34D62D0", Offset = "0x34D54D0", VA = "0x1834D62D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class OGKIABCPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct HLBHCJCIFKC : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly OGKIABCPMJJ HNGJGPJCNBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool BMLDHMCNJGA;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x34D4020", Offset = "0x34D3220", VA = "0x1834D4020")]
				public HLBHCJCIFKC(OGKIABCPMJJ HNGJGPJCNBJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x34D0010", Offset = "0x34CF210", VA = "0x1834D0010", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct DDBLBBDLOOG : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly OGKIABCPMJJ HNGJGPJCNBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool BMLDHMCNJGA;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x34D0040", Offset = "0x34CF240", VA = "0x1834D0040")]
				public DDBLBBDLOOG(OGKIABCPMJJ HNGJGPJCNBJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x34D0010", Offset = "0x34CF210", VA = "0x1834D0010", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService CMCOGOFJIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool NEMFOAEAKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int IOPHOEBLDHP;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x34DA080", Offset = "0x34D9280", VA = "0x1834DA080")]
			public OGKIABCPMJJ(HistoryService CMCOGOFJIDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x34DA050", Offset = "0x34D9250", VA = "0x1834DA050")]
			public bool MJMIPKBCADI(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x34DA000", Offset = "0x34D9200", VA = "0x1834DA000")]
			public DDBLBBDLOOG MHPGDKFCGAC()
			{
				return default(DDBLBBDLOOG);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x34D9FB0", Offset = "0x34D91B0", VA = "0x1834D9FB0")]
			public HLBHCJCIFKC BNOFDNFOBKJ()
			{
				return default(HLBHCJCIFKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class JMKBCCJEGCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public JMKBCCJEGCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x34D5B20", Offset = "0x34D4D20", VA = "0x1834D5B20")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class IKJEKILOILD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public IKJEKILOILD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x34D5130", Offset = "0x34D4330", VA = "0x1834D5130")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class MPLPOCHJEOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public MPLPOCHJEOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x34D93F0", Offset = "0x34D85F0", VA = "0x1834D93F0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction BGMLOKLMINB;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction EFDECLCMECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private HOABBIEFGJB LMMCBLBNHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer PKINGLGIEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer OMKJEICEHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private ANCFFMHODFD BDALNABKNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase NFKHPOBLOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService BONDPGADONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private IEHGHGMCPNO NFJHEPAAJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ONIGPHICNDD BIKKFEOMHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private OGKIABCPMJJ HNGJGPJCNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private LLJOLCFMNOE AECGBKJAICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IIEGBNJCKEO KNIFOAIMGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private GFCMOFDOMMJ JCNPKDOFBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete JIMFGDKEDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint OFCDNFHOBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint HGKPNBBMDBL;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private OGKIABCPMJJ FENNGNCKJEP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool CIEIGDFIAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x26A3050", Offset = "0x26A2250", VA = "0x1826A3050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool CJLLIMPGGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x26A37B0", Offset = "0x26A29B0", VA = "0x1826A37B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool MAAIEBLHBMM
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x26A44B0", Offset = "0x26A36B0", VA = "0x1826A44B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int OCEBIDIMAAF
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x26A4BD0", Offset = "0x26A3DD0", VA = "0x1826A4BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int NANJIKEHBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x26A53E0", Offset = "0x26A45E0", VA = "0x1826A53E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool IHIMLOPPDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x26A37A0", Offset = "0x26A29A0", VA = "0x1826A37A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool MFNBHLJCMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x26A3DF0", Offset = "0x26A2FF0", VA = "0x1826A3DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool PEOHNNCFOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x82B670", Offset = "0x82A870", VA = "0x18082B670", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x82B660", Offset = "0x82A860", VA = "0x18082B660", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer IPLJBAFJEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x26A3A00", Offset = "0x26A2C00", VA = "0x1826A3A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action KPHDFHCAJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x26A47A0", Offset = "0x26A39A0", VA = "0x1826A47A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x26A44E0", Offset = "0x26A36E0", VA = "0x1826A44E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action IEBINMDICNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x26A33C0", Offset = "0x26A25C0", VA = "0x1826A33C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x26A3E00", Offset = "0x26A3000", VA = "0x1826A3E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x26A4DD0", Offset = "0x26A3FD0", VA = "0x1826A4DD0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x26A3120", Offset = "0x26A2320", VA = "0x1826A3120", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x26A4990", Offset = "0x26A3B90", VA = "0x1826A4990")]
		private void NMPMPCHOIMH(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x26A38A0", Offset = "0x26A2AA0", VA = "0x1826A38A0")]
		private void GMGLPJMIFGI(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI FELOBKHBENM, NFKEKJGDLJI DLEMNBPMGBG, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x26A34E0", Offset = "0x26A26E0", VA = "0x1826A34E0")]
		private void EKJGFAINKFD(HCIIHJLICJK FLKGABKFAPI, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x26A3D90", Offset = "0x26A2F90", VA = "0x1826A3D90", Slot = "14")]
		public IDisposable IMJHAFAPDMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x26A4430", Offset = "0x26A3630", VA = "0x1826A4430", Slot = "9")]
		public IDisposable KDNNCEJPDKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x26A4B10", Offset = "0x26A3D10", VA = "0x1826A4B10", Slot = "6")]
		public UndoAction OALDIOFDAAO()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x26A46E0", Offset = "0x26A38E0", VA = "0x1826A46E0", Slot = "15")]
		public RedoAction MEMHFKACBBA()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x26A3B50", Offset = "0x26A2D50", VA = "0x1826A3B50", Slot = "16")]
		public UndoAction IGOOBJPABCM()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x26A45C0", Offset = "0x26A37C0", VA = "0x1826A45C0", Slot = "7")]
		public RedoAction MEMHFKACBBA(UndoAction GFCPAMJILIO)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x26A3A30", Offset = "0x26A2C30", VA = "0x1826A3A30", Slot = "8")]
		public UndoAction IGOOBJPABCM(RedoAction GFCPAMJILIO)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x26A4580", Offset = "0x26A3780", VA = "0x1826A4580")]
		public bool LMCBMGMAANK(NKKFENONCCH GNAMJIJOEJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x26A3850", Offset = "0x26A2A50", VA = "0x1826A3850", Slot = "17")]
		public void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x26A2EC0", Offset = "0x26A20C0", VA = "0x1826A2EC0")]
		public void CCGLPNCJJMM(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x26A38C0", Offset = "0x26A2AC0", VA = "0x1826A38C0")]
		public void HCJCBAMJKMA(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI DLEMNBPMGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x26A3C10", Offset = "0x26A2E10", VA = "0x1826A3C10")]
		public void IJFKMLMPNKM(HCIIHJLICJK FLKGABKFAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x26A30E0", Offset = "0x26A22E0", VA = "0x1826A30E0")]
		private void DFDKNKIMHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x26A2E60", Offset = "0x26A2060", VA = "0x1826A2E60")]
		private void AILJJFGEKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x26A2EA0", Offset = "0x26A20A0", VA = "0x1826A2EA0")]
		private void BCBECBBDNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x26A3EA0", Offset = "0x26A30A0", VA = "0x1826A3EA0")]
		private OBMMNPLGDMK JBIPLKIFKFC()
		{
			return default(OBMMNPLGDMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x26A3A10", Offset = "0x26A2C10", VA = "0x1826A3A10")]
		private uint HHLGOIKLEOE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x26A3460", Offset = "0x26A2660", VA = "0x1826A3460")]
		private bool EEKIKDPBHIP(out OBMMNPLGDMK IBKGKDECOEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x26A4490", Offset = "0x26A3690", VA = "0x1826A4490")]
		private bool KPGALKHBANC(out OBMMNPLGDMK IBKGKDECOEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x26A3480", Offset = "0x26A2680", VA = "0x1826A3480")]
		private RedoAction EHMEHEJEEHF(OBMMNPLGDMK IBKGKDECOEG)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x26A43D0", Offset = "0x26A35D0", VA = "0x1826A43D0")]
		private UndoAction KCAABFKDEKF(OBMMNPLGDMK IBKGKDECOEG)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x26A3FA0", Offset = "0x26A31A0", VA = "0x1826A3FA0")]
		private OBMMNPLGDMK JCLMNKNBOLL(OBMMNPLGDMK IBKGKDECOEG, ActionBuffer FKBOHAHKFME, bool DICOJFNIJHJ)
		{
			return default(OBMMNPLGDMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x26A5300", Offset = "0x26A4500", VA = "0x1826A5300")]
		private void PGLIMOOOIBL(Action IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x22791D0", Offset = "0x22783D0", VA = "0x1822791D0")]
		private T PGLIMOOOIBL<T>(Func<T> AGLNNHPIMMA)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x26A30B0", Offset = "0x26A22B0", VA = "0x1826A30B0")]
		private KFNDFEOAHAJ DDODIDPPPFJ(bool DICOJFNIJHJ, uint EOGFAFNNICF)
		{
			return default(KFNDFEOAHAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x26A54E0", Offset = "0x26A46E0", VA = "0x1826A54E0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x26A4840", Offset = "0x26A3A40", VA = "0x1826A4840")]
		[CompilerGenerated]
		private UndoAction NCLPPKLEKHJ()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x26A4260", Offset = "0x26A3460", VA = "0x1826A4260")]
		[CompilerGenerated]
		private RedoAction JEMOCKOBBJD()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x26A4C70", Offset = "0x26A3E70", VA = "0x1826A4C70")]
		[CompilerGenerated]
		private UndoAction OLPNFNCODCH()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AOKEGBGHPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> HAHPMNMCEBD;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public AOKEGBGHPJF(NativeArray<byte> HAHPMNMCEBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0720", Offset = "0x2A9F920", VA = "0x182AA0720")]
	public static AOKEGBGHPJF GJGPFJHFLAE(NativeArray<byte> HAHPMNMCEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T DALCAFNNKNJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> AAPENIJFDPF<T>(int MNKGPEKFPKK, Allocator HCEMBCPANJM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> HONKIBCPNNJ<T>(Allocator HCEMBCPANJM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HAKHJKFMEMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> HAHPMNMCEBD;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public HAKHJKFMEMN(NativeArray<byte> HAHPMNMCEBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x269EEF0", Offset = "0x269E0F0", VA = "0x18269EEF0")]
	public static HAKHJKFMEMN GJGPFJHFLAE(NativeArray<byte> HAHPMNMCEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x226A420", Offset = "0x2269620", VA = "0x18226A420")]
	public T DALCAFNNKNJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> AAPENIJFDPF<T>(int MNKGPEKFPKK, Allocator HCEMBCPANJM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CGEFLHHFNDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> HAHPMNMCEBD;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public CGEFLHHFNDD(NativeArray<byte> HAHPMNMCEBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7050", Offset = "0x2AA6250", VA = "0x182AA7050")]
	public static CGEFLHHFNDD GJGPFJHFLAE(NativeArray<byte> HAHPMNMCEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x1153260", Offset = "0x1152460", VA = "0x181153260")]
	public void PHPCDPKJOBK<T>(in T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x1153160", Offset = "0x1152360", VA = "0x181153160")]
	public void NHJAJBJKDJP<T>(NativeArray<T> CKOEFCDNGOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void JNLADMPJKAA<T>(NativeArray<T> IPMIIEAGJKC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LLDBDMPONKM
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDCD0", Offset = "0x2AECED0", VA = "0x182AEDCD0")]
	public static Span<byte> KJCLNMFIHEA(this NativeArray<byte> HAHPMNMCEBD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDB50", Offset = "0x2AECD50", VA = "0x182AEDB50")]
	public static ReadOnlySpan<byte> IILHEDBKAID(this NativeArray<byte> HAHPMNMCEBD)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDD60", Offset = "0x2AECF60", VA = "0x182AEDD60")]
	public static NativeArray<byte> LEPFAMHNGPM(this NativeArray<byte> HAHPMNMCEBD, int EBEICGFALNG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA50", Offset = "0x2AECC50", VA = "0x182AEDA50")]
	public static NativeArray<byte> AOPECILHHLB(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2210300", Offset = "0x220F500", VA = "0x182210300")]
	public static NativeArray<byte> AOPECILHHLB<T>(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDDE0", Offset = "0x2AECFE0", VA = "0x182AEDDE0")]
	public static NativeArray<byte> NMECPLLEKIO(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x22118A0", Offset = "0x2210AA0", VA = "0x1822118A0")]
	public static NativeArray<byte> NMECPLLEKIO<T>(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDAD0", Offset = "0x2AECCD0", VA = "0x182AEDAD0")]
	public static NativeArray<byte> CAAIFFAOMNK(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2210360", Offset = "0x220F560", VA = "0x182210360")]
	public static NativeArray<byte> CAAIFFAOMNK<T>(this NativeArray<byte> HAHPMNMCEBD, int BFFJHKFEFPP = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LFELMAAIALH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x269EF50", Offset = "0x269E150", VA = "0x18269EF50")]
	public LFELMAAIALH(NativeList<byte> JAAGBDPDCIE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x26B3730", Offset = "0x26B2930", VA = "0x1826B3730")]
	public static LFELMAAIALH GJGPFJHFLAE(NativeList<byte> HAHPMNMCEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void PHPCDPKJOBK<T>(in T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void NHJAJBJKDJP<T>(NativeArray<T> IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void JNLADMPJKAA<T>(NativeArray<T> IPMIIEAGJKC) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.PropertyChanges)]
	public class PropertyChangeNetworkRouter : IMFHGBIDMMC, CMLEAAEGAAL, CNNKIACDEEO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[GAJFPHPAPMA]
		private DJMKPBLGCLB KOODAEDNKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[GAJFPHPAPMA]
		private CCAADMLFLBF BBBOEOJJCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[GAJFPHPAPMA]
		private GDCABLCOFAB GGCIEKCEABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[GAJFPHPAPMA]
		private PropertyChangeRouterService BONDPGADONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private HOABBIEFGJB IJHMKEIOKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private BIGFKDPFDHC LBCPKCMJIKK;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public HOABBIEFGJB ENBEBOJOHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A6A0", Offset = "0x2B098A0", VA = "0x182B0A6A0")]
		public HOABBIEFGJB.MLHEMFECAPB CADKLBBONJH()
		{
			return default(HOABBIEFGJB.MLHEMFECAPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A6C0", Offset = "0x2B098C0", VA = "0x182B0A6C0", Slot = "4")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ACE0", Offset = "0x2B09EE0", VA = "0x182B0ACE0", Slot = "5")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A720", Offset = "0x2B09920", VA = "0x182B0A720", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ABD0", Offset = "0x2B09DD0", VA = "0x182B0ABD0")]
		public void OALDIOFDAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A940", Offset = "0x2B09B40", VA = "0x182B0A940")]
		public void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A960", Offset = "0x2B09B60", VA = "0x182B0A960")]
		private void IMCPEGAJKNB(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A660", Offset = "0x2B09860", VA = "0x182B0A660")]
		private void BIBAHMLLEMI(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI FELOBKHBENM, NFKEKJGDLJI DLEMNBPMGBG, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AB80", Offset = "0x2B09D80", VA = "0x182B0AB80")]
		private void LJODMHLJPAD(HCIIHJLICJK FLKGABKFAPI, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A380", Offset = "0x2B09580", VA = "0x182B0A380")]
		private void AJDMNICFHJI(BIGFKDPFDHC GLLFHCCFIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AA50", Offset = "0x2B09C50", VA = "0x182B0AA50")]
		private void LBNFNPHJHBG(BIGFKDPFDHC GLLFHCCFIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A990", Offset = "0x2B09B90", VA = "0x182B0A990")]
		private void JBLOGMOBDMN(BIGFKDPFDHC GLLFHCCFIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ABB0", Offset = "0x2B09DB0", VA = "0x182B0ABB0")]
		private void MAHFEFGMLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AF60", Offset = "0x2B0A160", VA = "0x182B0AF60")]
		private void PGJKHKIIGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A2E0", Offset = "0x2B094E0", VA = "0x182B0A2E0")]
		private void AGPEGOHEIMG(BIGFKDPFDHC GLLFHCCFIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x399BDA0", Offset = "0x399AFA0", VA = "0x18399BDA0", Slot = "6")]
		private void CCNHNNPDCFC<TKey, T>(global::FMBDPECPAID<TKey, T> IDBLFHOOMPH, object DELCOFCGDFF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void DNAMODCHKFI(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD, bool BBGPKGNEOIG);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void HGNLHPMNBJO(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI FELOBKHBENM, NFKEKJGDLJI DLEMNBPMGBG, bool BBGPKGNEOIG);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void IJDNBINFLOB(HCIIHJLICJK FLKGABKFAPI, bool BBGPKGNEOIG);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DNAMODCHKFI GPGHDDABLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HGNLHPMNBJO ILBIPNIJCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IJDNBINFLOB DPHICADNPGH;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AFD0", Offset = "0x2B0A1D0", VA = "0x182B0AFD0")]
		public void CCGLPNCJJMM(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AFF0", Offset = "0x2B0A1F0", VA = "0x182B0AFF0")]
		public void HCJCBAMJKMA(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI FELOBKHBENM, in NFKEKJGDLJI DLEMNBPMGBG, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B060", Offset = "0x2B0A260", VA = "0x182B0B060")]
		public void IJFKMLMPNKM(HCIIHJLICJK FLKGABKFAPI, bool BBGPKGNEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(PILCLECJGKL))]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class PILCLECJGKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer ACMMHKGMFIC;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int BPIIJGBNBGB
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x27001F0", Offset = "0x26FF3F0", VA = "0x1827001F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public CIGDLLBEAAO[] NJLKDGFLJCK
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2700330", Offset = "0x26FF530", VA = "0x182700330")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
			public PILCLECJGKL(ActionBuffer OBLCLEBEPDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2700240", Offset = "0x26FF440", VA = "0x182700240")]
			[CompilerGenerated]
			private CIGDLLBEAAO DJFLHJGFJIN(OBMMNPLGDMK IBKGKDECOEG)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class CIGDLLBEAAO : CNNKIACDEEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer ACMMHKGMFIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly OBMMNPLGDMK IBKGKDECOEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(BIGFKDPFDHC, string, object)> IAOPBOEHEOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private HAKHJKFMEMN EFKJIOEDNFB;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int BPIIJGBNBGB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x26FE1C0", Offset = "0x26FD3C0", VA = "0x1826FE1C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(BIGFKDPFDHC, string, object)> DEALCLPEDJB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x26FE650", Offset = "0x26FD850", VA = "0x1826FE650")]
			public CIGDLLBEAAO(ActionBuffer OBLCLEBEPDK, OBMMNPLGDMK IBKGKDECOEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x26FE210", Offset = "0x26FD410", VA = "0x1826FE210")]
			private string HCDLEONGOJC(BIGFKDPFDHC LBCPKCMJIKK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x26FE310", Offset = "0x26FD510", VA = "0x1826FE310")]
			private void LLLPMINBGLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x223C520", Offset = "0x223B720", VA = "0x18223C520", Slot = "4")]
			public void OPDHHPNOPFF<TKey, T>(global::FMBDPECPAID<TKey, T> IDBLFHOOMPH, [Optional] object DELCOFCGDFF) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> OEPDOIOJPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<OBMMNPLGDMK> KIFOHHMNMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly IBILOEKMGNK ENLKEGBFFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly LLJOLCFMNOE AECGBKJAICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly CCAADMLFLBF BBBOEOJJCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool AOAPFLPCIKK;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public FGAJIMHPGCD DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2AA2070", Offset = "0x2AA1270", VA = "0x182AA2070")]
			get
			{
				return default(FGAJIMHPGCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int BPIIJGBNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AA1740", Offset = "0x2AA0940", VA = "0x182AA1740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA21C0", Offset = "0x2AA13C0", VA = "0x182AA21C0")]
		public ActionBuffer(LLJOLCFMNOE AECGBKJAICN, CCAADMLFLBF BBBOEOJJCHM, bool AOAPFLPCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1CB0", Offset = "0x2AA0EB0", VA = "0x182AA1CB0")]
		public bool MBNNEIBLHGP(out OBMMNPLGDMK IBKGKDECOEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1850", Offset = "0x2AA0A50", VA = "0x182AA1850")]
		public void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F30", Offset = "0x2AA1130", VA = "0x182AA1F30")]
		public OBMMNPLGDMK OALDIOFDAAO(EACFOHDKMOB IAOPBOEHEOP, IEHGHGMCPNO NFJHEPAAJKO, uint OJHDPMDDEOP)
		{
			return default(OBMMNPLGDMK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1C80", Offset = "0x2AA0E80", VA = "0x182AA1C80")]
		public bool KCLNILHLAKM(uint OJHDPMDDEOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1D40", Offset = "0x2AA0F40", VA = "0x182AA1D40")]
		public bool MGMEADONKCB(uint OJHDPMDDEOP, out OBMMNPLGDMK GFCPAMJILIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA18C0", Offset = "0x2AA0AC0", VA = "0x182AA18C0")]
		public void JBCKPCNNEPL(OBMMNPLGDMK GFCPAMJILIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1B40", Offset = "0x2AA0D40", VA = "0x182AA1B40")]
		[Conditional("DEBUG_BUILD")]
		private void JEAEPDJPKLK(OBMMNPLGDMK GFCPAMJILIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1A30", Offset = "0x2AA0C30", VA = "0x182AA1A30")]
		private void JCLMNKNBOLL(OBMMNPLGDMK KHBEECJEOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA14C0", Offset = "0x2AA06C0", VA = "0x182AA14C0")]
		private void AFPMCFBENCG(HAKHJKFMEMN LEEEHBCCIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1780", Offset = "0x2AA0980", VA = "0x182AA1780")]
		private void BKBECAJHLNP(OBMMNPLGDMK IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA20B0", Offset = "0x2AA12B0", VA = "0x182AA20B0")]
		private HAKHJKFMEMN PLKMOJPMJJO(OBMMNPLGDMK IBKGKDECOEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA17E0", Offset = "0x2AA09E0", VA = "0x182AA17E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class IBILOEKMGNK : CNNKIACDEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly LLJOLCFMNOE AECGBKJAICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly CCAADMLFLBF BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private HCIIHJLICJK FLKGABKFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private HAKHJKFMEMN AHJFFJHJABE;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7086F0", Offset = "0x7078F0", VA = "0x1807086F0")]
	public IBILOEKMGNK(LLJOLCFMNOE AECGBKJAICN, CCAADMLFLBF BBBOEOJJCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x227B520", Offset = "0x227A720", VA = "0x18227B520", Slot = "4")]
	public void OPDHHPNOPFF<TKey, T>(global::FMBDPECPAID<TKey, T> KFHGABBJCKM, [Optional] object DELCOFCGDFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x26A73B0", Offset = "0x26A65B0", VA = "0x1826A73B0")]
	public void LGHFLJJPKHF(BIGFKDPFDHC LBCPKCMJIKK, ref HAKHJKFMEMN LEEEHBCCIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class HOABBIEFGJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct MLHEMFECAPB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly HOABBIEFGJB HHFDFFDPCGO;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x34D8B60", Offset = "0x34D7D60", VA = "0x1834D8B60")]
		public MLHEMFECAPB(HOABBIEFGJB HHFDFFDPCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x34D8B40", Offset = "0x34D7D40", VA = "0x1834D8B40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected EACFOHDKMOB IAOPBOEHEOP;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EACFOHDKMOB DEALCLPEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x26A2410", Offset = "0x26A1610", VA = "0x1826A2410")]
		get
		{
			return default(EACFOHDKMOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GNNMKAPGLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x26A2180", Offset = "0x26A1380", VA = "0x1826A2180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x26A2550", Offset = "0x26A1750", VA = "0x1826A2550")]
	public HOABBIEFGJB(EACFOHDKMOB.FJABGBKDGBC EIMPDNCLMJJ = EACFOHDKMOB.FJABGBKDGBC.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x26A2190", Offset = "0x26A1390", VA = "0x1826A2190")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x26A2080", Offset = "0x26A1280", VA = "0x1826A2080")]
	public void CCGLPNCJJMM(HCIIHJLICJK FLKGABKFAPI, LHNKALDLHDD JBCKGNLHIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x26A21A0", Offset = "0x26A13A0", VA = "0x1826A21A0")]
	public void HCJCBAMJKMA(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x26A2230", Offset = "0x26A1430", VA = "0x1826A2230")]
	public void IJFKMLMPNKM(HCIIHJLICJK FLKGABKFAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x26A2310", Offset = "0x26A1510", VA = "0x1826A2310")]
	public void MAHFEFGMLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x26A2450", Offset = "0x26A1650", VA = "0x1826A2450")]
	public void PGJKHKIIGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x26A2170", Offset = "0x26A1370", VA = "0x1826A2170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x26A2050", Offset = "0x26A1250", VA = "0x1826A2050")]
	public MLHEMFECAPB CADKLBBONJH()
	{
		return default(MLHEMFECAPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct BIGFKDPFDHC : IComparable<BIGFKDPFDHC>, IEquatable<BIGFKDPFDHC>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly BIGFKDPFDHC IGHAJOOKIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public HCIIHJLICJK FLKGABKFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public GFCMOFDOMMJ CHIEJFHOPDP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2163740", Offset = "0x2162940", VA = "0x182163740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
	public BIGFKDPFDHC(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3510", Offset = "0x2AA2710", VA = "0x182AA3510")]
	public void PNBLJFHEHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3360", Offset = "0x2AA2560", VA = "0x182AA3360", Slot = "4")]
	public int CompareTo(BIGFKDPFDHC HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3520", Offset = "0x2AA2720", VA = "0x182AA3520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA33F0", Offset = "0x2AA25F0", VA = "0x182AA33F0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA33A0", Offset = "0x2AA25A0", VA = "0x182AA33A0", Slot = "5")]
	public bool Equals(BIGFKDPFDHC HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA34D0", Offset = "0x2AA26D0", VA = "0x182AA34D0")]
	public static bool IGOCGGBJBII(BIGFKDPFDHC BLFKABPCHLN, BIGFKDPFDHC NPFMAENOPCH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3310", Offset = "0x2AA2510", VA = "0x182AA3310")]
	public static bool BHBKJCPJNJN(BIGFKDPFDHC BLFKABPCHLN, BIGFKDPFDHC NPFMAENOPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3490", Offset = "0x2AA2690", VA = "0x182AA3490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	public class GatherPropertiesForUndelete : CMIHDJOHIOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private LLJOLCFMNOE AECGBKJAICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private HCIIHJLICJK FLKGABKFAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService CMCOGOFJIDF;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x269ECC0", Offset = "0x269DEC0", VA = "0x18269ECC0")]
		public void EIMMHKLFOIE(HCIIHJLICJK FLKGABKFAPI, LLJOLCFMNOE AECGBKJAICN, HistoryService CMCOGOFJIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x269EDD0", Offset = "0x269DFD0", VA = "0x18269EDD0", Slot = "4")]
		private void OOJFOGINNMN(CFMFMFJNBJM IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, object DELCOFCGDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class AHBALOKNNPE
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FCC0", Offset = "0x2A9EEC0", VA = "0x182A9FCC0")]
	public static void LBNFNPHJHBG(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK, LHNKALDLHDD JBCKGNLHIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FB30", Offset = "0x2A9ED30", VA = "0x182A9FB30")]
	public static void HDHMKCGAMAL(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FC70", Offset = "0x2A9EE70", VA = "0x182A9FC70")]
	public static void JBLOGMOBDMN(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FA00", Offset = "0x2A9EC00", VA = "0x182A9FA00")]
	public static void EDEBNFBDDPD(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FE60", Offset = "0x2A9F060", VA = "0x182A9FE60")]
	public static LHNKALDLHDD OCFIJJEMKBD(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK)
	{
		return default(LHNKALDLHDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xE22BD0", Offset = "0xE21DD0", VA = "0x180E22BD0")]
	public static T INCDILPDABJ<T>(EACFOHDKMOB IAOPBOEHEOP, BIGFKDPFDHC LBCPKCMJIKK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xE22BF0", Offset = "0xE21DF0", VA = "0x180E22BF0")]
	public static T INCDILPDABJ<T>(ref HAKHJKFMEMN PCPEJHIMHJJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FEB0", Offset = "0x2A9F0B0", VA = "0x182A9FEB0")]
	public static LHNKALDLHDD OCFIJJEMKBD(ref HAKHJKFMEMN PCPEJHIMHJJ)
	{
		return default(LHNKALDLHDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct EACFOHDKMOB : IEnumerable<BIGFKDPFDHC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum FJABGBKDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct IFHIKBDKIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly EACFOHDKMOB JAAGBDPDCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly IEHGHGMCPNO NFJHEPAAJKO;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x34D5050", Offset = "0x34D4250", VA = "0x1834D5050")]
		public IFHIKBDKIIO(EACFOHDKMOB JAAGBDPDCIE, IEHGHGMCPNO NFJHEPAAJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x34D49E0", Offset = "0x34D3BE0", VA = "0x1834D49E0")]
		public void CNLCMOHPEDH(NativeList<byte> EDIGAFOKGOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x34D4990", Offset = "0x34D3B90", VA = "0x1834D4990")]
		private void CMIMKMBPMDN(BIGFKDPFDHC LBCPKCMJIKK, ref CGEFLHHFNDD BMBAKEGLHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x34D4FC0", Offset = "0x34D41C0", VA = "0x1834D4FC0")]
		private void MFPGOBCNNKP(BIGFKDPFDHC LBCPKCMJIKK, ref CGEFLHHFNDD BMBAKEGLHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x34D4ED0", Offset = "0x34D40D0", VA = "0x1834D4ED0")]
		private NativeArray<byte> DMEGGNAHLOO(NativeList<byte> EDIGAFOKGOJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x34D4C80", Offset = "0x34D3E80", VA = "0x1834D4C80")]
		private NativeArray<byte> DJIFCDOEHGC(NativeList<byte> EDIGAFOKGOJ, int MNKGPEKFPKK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x34D4740", Offset = "0x34D3940", VA = "0x1834D4740")]
		private int CKLDKLCLILK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x34D4D70", Offset = "0x34D3F70", VA = "0x1834D4D70")]
		private bool DKLHMIIOLIE(BIGFKDPFDHC LBCPKCMJIKK, out NativeArray<byte> GCODJLCICJJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FPFNPHAMLAP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> PCPEJHIMHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private EACFOHDKMOB JAAGBDPDCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly BIGFKDPFDHC GLLFHCCFIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int EBEICGFALNG;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x34D2790", Offset = "0x34D1990", VA = "0x1834D2790")]
		internal FPFNPHAMLAP(EACFOHDKMOB JAAGBDPDCIE, BIGFKDPFDHC GLLFHCCFIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x34D2510", Offset = "0x34D1710", VA = "0x1834D2510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x34D2540", Offset = "0x34D1740", VA = "0x1834D2540")]
		public void IPNELHPGGPG(NativeArray<byte> IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x34D2730", Offset = "0x34D1930", VA = "0x1834D2730")]
		public void PNIIKHONCKB(NativeArray<byte> IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x34D25A0", Offset = "0x34D17A0", VA = "0x1834D25A0")]
		public void MFPGOBCNNKP(in NFKEKJGDLJI IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x22457A0", Offset = "0x22449A0", VA = "0x1822457A0")]
		public void MFPGOBCNNKP<T>(T IPMIIEAGJKC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x34D26C0", Offset = "0x34D18C0", VA = "0x1834D26C0")]
		private void MMKCGEKAABF(int IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x34D2610", Offset = "0x34D1810", VA = "0x1834D2610")]
		private void MMKCGEKAABF(in NFKEKJGDLJI IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x34D25B0", Offset = "0x34D17B0", VA = "0x1834D25B0")]
		private unsafe void MMKCGEKAABF(void* JJLCBNJOJIE, int MNKGPEKFPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x34D2540", Offset = "0x34D1740", VA = "0x1834D2540")]
		private void MMKCGEKAABF(NativeArray<byte> CKOEFCDNGOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JCNKDMCJMED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private EACFOHDKMOB JAAGBDPDCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> PCPEJHIMHJJ;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x34D5A20", Offset = "0x34D4C20", VA = "0x1834D5A20")]
		internal JCNKDMCJMED(EACFOHDKMOB JAAGBDPDCIE, NativeArray<byte> PCPEJHIMHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x34D5920", Offset = "0x34D4B20", VA = "0x1834D5920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x34D5760", Offset = "0x34D4960", VA = "0x1834D5760")]
		public NativeArray<byte> AAPENIJFDPF(int MNKGPEKFPKK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x34D5930", Offset = "0x34D4B30", VA = "0x1834D5930")]
		public NativeArray<byte> HONKIBCPNNJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x224F5E0", Offset = "0x224E7E0", VA = "0x18224F5E0")]
		public T DALCAFNNKNJ<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x34D5820", Offset = "0x34D4A20", VA = "0x1834D5820")]
		public void DALCAFNNKNJ(in OANIPIMDODC IPMIIEAGJKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct MDDKAJGJNCH : IEnumerator<BIGFKDPFDHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<BIGFKDPFDHC> HAHPMNMCEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int GMEHLIHLGEH;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public BIGFKDPFDHC DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x34D8A10", Offset = "0x34D7C10", VA = "0x1834D8A10", Slot = "4")]
			get
			{
				return default(BIGFKDPFDHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x34D89D0", Offset = "0x34D7BD0", VA = "0x1834D89D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6930", Offset = "0x2AE5B30", VA = "0x182AE6930")]
		internal MDDKAJGJNCH(NativeList<BIGFKDPFDHC> CKOEFCDNGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x34D8890", Offset = "0x34D7A90", VA = "0x1834D8890", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x34D8990", Offset = "0x34D7B90", VA = "0x1834D8990", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct JNEAOPDBENM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int AJJCFJLHGAL = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int NGKBOOKCFKP = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int PAHKGGPMCDL = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> PCPEJHIMHJJ;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool OEPEEFKGKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x34D5CD0", Offset = "0x34D4ED0", VA = "0x1834D5CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int NLGDBEMOJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x34D5BE0", Offset = "0x34D4DE0", VA = "0x1834D5BE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x34D5BD0", Offset = "0x34D4DD0", VA = "0x1834D5BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FJABGBKDGBC EIHBOJFEIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x34D5C60", Offset = "0x34D4E60", VA = "0x1834D5C60")]
			get
			{
				return default(FJABGBKDGBC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x34D5C50", Offset = "0x34D4E50", VA = "0x1834D5C50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool GNNMKAPGLAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x34D5BF0", Offset = "0x34D4DF0", VA = "0x1834D5BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x34D5C70", Offset = "0x34D4E70", VA = "0x1834D5C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool GPCEFEEAJAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x34D5B80", Offset = "0x34D4D80", VA = "0x1834D5B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x34D5C30", Offset = "0x34D4E30", VA = "0x1834D5C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x34D5D10", Offset = "0x34D4F10", VA = "0x1834D5D10")]
		public JNEAOPDBENM(FJABGBKDGBC EIMPDNCLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x34D5C00", Offset = "0x34D4E00", VA = "0x1834D5C00")]
		private int HHCPOGCCGNF(int MOHMCFDNHKH, int CJAPMLNDJKG = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x34D5C90", Offset = "0x34D4E90", VA = "0x1834D5C90")]
		private void PLCAKFAMFIL(int MOHMCFDNHKH, int IPMIIEAGJKC, int CJAPMLNDJKG = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x34D5B90", Offset = "0x34D4D90", VA = "0x1834D5B90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int NJONHDMOPGN = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int PKPJKFLKIBD = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly BIGFKDPFDHC CLLHDAAFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<BIGFKDPFDHC, int> GLFEHIGILIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<BIGFKDPFDHC> IAOPBOEHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> OMADJBDJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> HEOHOEPAHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> PCPEJHIMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private JNEAOPDBENM HMJOKPKOPCN;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GNNMKAPGLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9540", Offset = "0x2AB8740", VA = "0x182AB9540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PHANBMHEFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AB98F0", Offset = "0x2AB8AF0", VA = "0x182AB98F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int NLGDBEMOJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9530", Offset = "0x2AB8730", VA = "0x182AB9530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BJBLGIBKPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9740", Offset = "0x2AB8940", VA = "0x182AB9740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9910", Offset = "0x2AB8B10", VA = "0x182AB9910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9860", Offset = "0x2AB8A60", VA = "0x182AB9860")]
	public static EACFOHDKMOB GPGHDDABLEF(FJABGBKDGBC EIMPDNCLMJJ = FJABGBKDGBC.Last, int JPIHODJGGCI = 16, int IDAEKFCLKEL = 256)
	{
		return default(EACFOHDKMOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9B40", Offset = "0x2AB8D40", VA = "0x182AB9B40")]
	private EACFOHDKMOB(FJABGBKDGBC EIMPDNCLMJJ, int JPIHODJGGCI, int IDAEKFCLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9170", Offset = "0x2AB8370", VA = "0x182AB9170", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8E50", Offset = "0x2AB8050", VA = "0x182AB8E50")]
	public FPFNPHAMLAP AJDMNICFHJI(BIGFKDPFDHC GLLFHCCFIGK)
	{
		return default(FPFNPHAMLAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB90E0", Offset = "0x2AB82E0", VA = "0x182AB90E0")]
	public JCNKDMCJMED DDIILJABODH(BIGFKDPFDHC GLLFHCCFIGK)
	{
		return default(JCNKDMCJMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9340", Offset = "0x2AB8540", VA = "0x182AB9340")]
	public bool EOOAAMDKNAE(BIGFKDPFDHC GLLFHCCFIGK, out JCNKDMCJMED KLPFPLFLOKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB98A0", Offset = "0x2AB8AA0", VA = "0x182AB98A0")]
	public bool NDMJCGACGPL(BIGFKDPFDHC GLLFHCCFIGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9010", Offset = "0x2AB8210", VA = "0x182AB9010")]
	public bool CPFAJPGDLGH(BIGFKDPFDHC GLLFHCCFIGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8F20", Offset = "0x2AB8120", VA = "0x182AB8F20")]
	public void CCBNGPKGLII(NativeList<byte> EDIGAFOKGOJ, IEHGHGMCPNO NFJHEPAAJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D209E0", Offset = "0x1D1FBE0", VA = "0x181D209E0")]
	public T IIEIMKIPEKF<T>(BIGFKDPFDHC GLLFHCCFIGK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9780", Offset = "0x2AB8980", VA = "0x182AB9780")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8EE0", Offset = "0x2AB80E0", VA = "0x182AB8EE0")]
	public MDDKAJGJNCH BECNODPGHJK()
	{
		return default(MDDKAJGJNCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9550", Offset = "0x2AB8750", VA = "0x182AB9550")]
	private void GEILGDOGDLF(BIGFKDPFDHC GLLFHCCFIGK, int EBEICGFALNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9950", Offset = "0x2AB8B50", VA = "0x182AB9950")]
	private void PNBLJFHEHIH(int BFMAMEIHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9250", Offset = "0x2AB8450", VA = "0x182AB9250")]
	private void EADAAAAEGMD(BIGFKDPFDHC GLLFHCCFIGK, int EBEICGFALNG, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1D20B70", Offset = "0x1D1FD70", VA = "0x181D20B70")]
	private static T IIEIMKIPEKF<T>(NativeArray<byte> HAHPMNMCEBD, int MOHMCFDNHKH = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9A80", Offset = "0x2AB8C80", VA = "0x182AB9A80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9A40", Offset = "0x2AB8C40", VA = "0x182AB9A40", Slot = "4")]
	private IEnumerator<BIGFKDPFDHC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class NFPFOBDGIEM<T> : HDACKBGFGDN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2777240", Offset = "0x2776440", VA = "0x182777240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x27772D0", Offset = "0x27764D0", VA = "0x1827772D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2777340", Offset = "0x2776540", VA = "0x182777340")]
	public NFPFOBDGIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	internal class CleanupRigidbodyExImpl : HDACKBGFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9C50", Offset = "0x2AA8E50", VA = "0x182AA9C50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9CF0", Offset = "0x2AA8EF0", VA = "0x182AA9CF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class IEBKCLHIKAJ : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery KFFAEKIODHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x26A7DB0", Offset = "0x26A6FB0", VA = "0x1826A7DB0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x26A7CE0", Offset = "0x26A6EE0", VA = "0x1826A7CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x26A7D70", Offset = "0x26A6F70", VA = "0x1826A7D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public IEBKCLHIKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal class ABIFCBHFKCP : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService AHJDDOGGCEC;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F180", Offset = "0x2A9E380", VA = "0x182A9F180", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F160", Offset = "0x2A9E360", VA = "0x182A9F160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public ABIFCBHFKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService JIPLOFKCDHI;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8DB0", Offset = "0x2AB7FB0", VA = "0x182AB8DB0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8900", Offset = "0x2AB7B00", VA = "0x182AB8900", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8990", Offset = "0x2AB7B90", VA = "0x182AB8990", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	[PNCLNBNALEO(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<CALFDDGNLFK>> HAGNIOBGLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2AB32B0", Offset = "0x2AB24B0", VA = "0x182AB32B0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2C60", Offset = "0x2AB1E60", VA = "0x182AB2C60")]
		public void CCLIJPKADNO(NativeListAsync<CALFDDGNLFK> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2E40", Offset = "0x2AB2040", VA = "0x182AB2E40")]
		public void EEMIGFCEDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2CD0", Offset = "0x2AB1ED0", VA = "0x182AB2CD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3350", Offset = "0x2AB2550", VA = "0x182AB3350")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[PNCLNBNALEO(typeof(AMOFKKLJHLA), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public class PhysicsService : CMLEAAEGAAL, BDLDACMOPAJ, AMOFKKLJHLA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly HDHIMOFHFJL GBJBKCGJAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private OHHINBMLFAA GHKNKHCKPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService GGIAAMGAMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::FPAJBINIPIL<IOBENKLLONM> CCBAMOCOMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<HPHBHAKAACD, IOBENKLLONM> DPLCFKMACEM
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2B07B60", Offset = "0x2B06D60", VA = "0x182B07B60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2B07D20", Offset = "0x2B06F20", VA = "0x182B07D20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2B07C00", Offset = "0x2B06E00", VA = "0x182B07C00", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2B075D0", Offset = "0x2B067D0", VA = "0x182B075D0", Slot = "5")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2B07940", Offset = "0x2B06B40", VA = "0x182B07940", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2B07870", Offset = "0x2B06A70", VA = "0x182B07870", Slot = "8")]
		public bool CIFKFPIACKF(HPHBHAKAACD EHNNHDBEJOG, out Collider ADMCDJKKCIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2B07AA0", Offset = "0x2B06CA0", VA = "0x182B07AA0")]
		private void FAGNLNMCPHM(Entity LHCPLOHKBCE, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI HKPEMIJGIMD, NFKEKJGDLJI INPBMNIIHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2B07510", Offset = "0x2B06710", VA = "0x182B07510", Slot = "9")]
		public void AGCCKHLANPB(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[PNCLNBNALEO(typeof(APGPGBLMNNP), new string[] { })]
	public class RbexService : CMLEAAEGAAL, APGPGBLMNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private ACMOOCKHEPB JADLNLAGNCJ;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2702EF0", Offset = "0x27020F0", VA = "0x182702EF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x27035A0", Offset = "0x27027A0", VA = "0x1827035A0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2700C40", Offset = "0x26FFE40", VA = "0x182700C40", Slot = "6")]
		public AEPAMCILECN CPJGOANNMJM(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x27027B0", Offset = "0x27019B0", VA = "0x1827027B0", Slot = "5")]
		public void IPJGOJKPNKJ(HPHBHAKAACD EHNNHDBEJOG, AEPAMCILECN IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2700790", Offset = "0x26FF990", VA = "0x182700790", Slot = "34")]
		public CollisionDetectionMode BBHICCDMIFA(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x27006C0", Offset = "0x26FF8C0", VA = "0x1827006C0", Slot = "35")]
		public void AKBFIGPDPJN(HPHBHAKAACD EHNNHDBEJOG, CollisionDetectionMode IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2702050", Offset = "0x2701250", VA = "0x182702050", Slot = "36")]
		public HHLALPMEMBB HOGJJDNADNP(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HHLALPMEMBB);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2701460", Offset = "0x2700660", VA = "0x182701460", Slot = "37")]
		public void ELAJLMOAJAA(HPHBHAKAACD EHNNHDBEJOG, HHLALPMEMBB IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2703930", Offset = "0x2702B30", VA = "0x182703930", Slot = "38")]
		public bool PPDMHENLJKC(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2700EC0", Offset = "0x27000C0", VA = "0x182700EC0", Slot = "39")]
		public void DHPOFPJGDDJ(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2701120", Offset = "0x2700320", VA = "0x182701120", Slot = "40")]
		public HPHBHAKAACD DMOICBPEOLI(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2702730", Offset = "0x2701930", VA = "0x182702730", Slot = "41")]
		public void IOJGOGBBBID(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2701710", Offset = "0x2700910", VA = "0x182701710", Slot = "42")]
		public HPHBHAKAACD FONBPFGIHGB(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2701EB0", Offset = "0x27010B0", VA = "0x182701EB0", Slot = "43")]
		public void HMBNJDPGAJN(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2701AE0", Offset = "0x2700CE0", VA = "0x182701AE0", Slot = "7")]
		public void HDJNLHIMONE(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2700DB0", Offset = "0x26FFFB0", VA = "0x182700DB0", Slot = "8")]
		public void DFCNILODFON(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2702280", Offset = "0x2701480", VA = "0x182702280", Slot = "9")]
		public int IDHBDBMGFID(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2702B30", Offset = "0x2701D30", VA = "0x182702B30", Slot = "10")]
		public HPHBHAKAACD LADEPLKBNAJ(HPHBHAKAACD EHNNHDBEJOG, int GMEHLIHLGEH)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x27019F0", Offset = "0x2700BF0", VA = "0x1827019F0", Slot = "11")]
		public void HBJNPLCDNJF(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x27009C0", Offset = "0x26FFBC0", VA = "0x1827009C0", Slot = "12")]
		public void BGHECGHAHKM(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN, HPHBHAKAACD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2700F30", Offset = "0x2700130", VA = "0x182700F30", Slot = "13")]
		public void DJAHCGGIIAI(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2701D50", Offset = "0x2700F50", VA = "0x182701D50", Slot = "14")]
		public bool HLMHFGGPCMG(HPHBHAKAACD EHNNHDBEJOG, out HPHBHAKAACD IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2702200", Offset = "0x2701400", VA = "0x182702200", Slot = "15")]
		public void IAILMMHIPKD(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2702D30", Offset = "0x2701F30", VA = "0x182702D30", Slot = "16")]
		public bool LHOHDDIHCMH(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2702860", Offset = "0x2701A60", VA = "0x182702860", Slot = "17")]
		public void KAIBLONLEMF(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2700FC0", Offset = "0x27001C0", VA = "0x182700FC0", Slot = "18")]
		public bool DKKHDIICHIF(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2700BC0", Offset = "0x26FFDC0", VA = "0x182700BC0", Slot = "26")]
		public float3 CMKCECKOJDE(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2702950", Offset = "0x2701B50", VA = "0x182702950", Slot = "27")]
		public void KEDJCFDKLAO(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2701890", Offset = "0x2700A90", VA = "0x182701890", Slot = "28")]
		public float GGHCAIBPPPB(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x27026C0", Offset = "0x27018C0", VA = "0x1827026C0", Slot = "29")]
		public void IMILCKKKLDJ(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2700730", Offset = "0x26FF930", VA = "0x182700730", Slot = "30")]
		public float APCBLGMFNNL(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x27028E0", Offset = "0x2701AE0", VA = "0x1827028E0", Slot = "31")]
		public void KCLPHGPBFDD(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2700AF0", Offset = "0x26FFCF0", VA = "0x182700AF0", Slot = "32")]
		public bool BMDPIOBCEOF(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2701200", Offset = "0x2700400", VA = "0x182701200", Slot = "33")]
		public void EHDNGJHICCN(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2702F10", Offset = "0x2702110", VA = "0x182702F10", Slot = "19")]
		public void NANOMGOMOMK(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2702560", Offset = "0x2701760", VA = "0x182702560", Slot = "20")]
		public bool IJPMJPOBMAP(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x27034B0", Offset = "0x27026B0", VA = "0x1827034B0", Slot = "21")]
		public void OGLCICJFMJG(HPHBHAKAACD EHNNHDBEJOG, quaternion IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2700860", Offset = "0x26FFA60", VA = "0x182700860", Slot = "22")]
		public bool BDBDBPPNLJN(HPHBHAKAACD EHNNHDBEJOG, out quaternion IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2702F90", Offset = "0x2702190", VA = "0x182702F90", Slot = "23")]
		public bool NCPHJKFMPLP(HPHBHAKAACD EHNNHDBEJOG, out float3 HFDCPHCEPFP, out quaternion LNJNMDKKOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x27033F0", Offset = "0x27025F0", VA = "0x1827033F0", Slot = "44")]
		public MGFMFIIFDMD NOALHDPHGKG(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(MGFMFIIFDMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2702C50", Offset = "0x2701E50", VA = "0x182702C50", Slot = "45")]
		public void LCMMOJICDNP(HPHBHAKAACD EHNNHDBEJOG, MGFMFIIFDMD IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x27037B0", Offset = "0x27029B0", VA = "0x1827037B0", Slot = "72")]
		public void PKLMIPICLLK(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x27020F0", Offset = "0x27012F0", VA = "0x1827020F0", Slot = "73")]
		public void HOJNIFMBFPG(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2702180", Offset = "0x2701380", VA = "0x182702180", Slot = "74")]
		public bool HPJCMOMNJJH(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x27018F0", Offset = "0x2700AF0", VA = "0x1827018F0", Slot = "81")]
		public void GIOPKNLCCBA(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x27024D0", Offset = "0x27016D0", VA = "0x1827024D0", Slot = "82")]
		public void IIDIBDNJFAB(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2703520", Offset = "0x2702720", VA = "0x182703520", Slot = "83")]
		public bool PABAHAFNIGD(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x27023D0", Offset = "0x27015D0", VA = "0x1827023D0", Slot = "84")]
		public IEnumerable<object> IENENNBOKAF(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2703450", Offset = "0x2702650", VA = "0x182703450", Slot = "46")]
		public bool OFEKMPDHJBE(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2702E90", Offset = "0x2702090", VA = "0x182702E90", Slot = "47")]
		public void LPDEOIDAPMA(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2703270", Offset = "0x2702470", VA = "0x182703270", Slot = "48")]
		public bool NHOHKAJPMCF(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2701980", Offset = "0x2700B80", VA = "0x182701980", Slot = "49")]
		public void GOLEGNPABKP(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2703840", Offset = "0x2702A40", VA = "0x182703840", Slot = "50")]
		public bool PLKFMDOHIDP(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x27004F0", Offset = "0x26FF6F0", VA = "0x1827004F0", Slot = "51")]
		public void ADKABFNFOFB(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x27011A0", Offset = "0x27003A0", VA = "0x1827011A0", Slot = "52")]
		public RigidbodyConstraints EFACEONLCII(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2700B50", Offset = "0x26FFD50", VA = "0x182700B50", Slot = "53")]
		public void BNPIBPBPNJJ(HPHBHAKAACD EHNNHDBEJOG, RigidbodyConstraints IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2701560", Offset = "0x2700760", VA = "0x182701560", Slot = "54")]
		public float EPJIGOPKPLJ(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2703200", Offset = "0x2702400", VA = "0x182703200", Slot = "55")]
		public void NDOLIFDNNNK(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2703750", Offset = "0x2702950", VA = "0x182703750", Slot = "56")]
		public float PFHNGKICJNG(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x27007F0", Offset = "0x26FF9F0", VA = "0x1827007F0", Slot = "57")]
		public void BCIGBIKMDBM(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x27015C0", Offset = "0x27007C0", VA = "0x1827015C0", Slot = "58")]
		public bool FBGGENNDMPM(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2702CC0", Offset = "0x2701EC0", VA = "0x182702CC0", Slot = "59")]
		public void LCNHEEJHCED(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2701270", Offset = "0x2700470", VA = "0x182701270", Slot = "60")]
		public bool EJLNGPPPAIP(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x27017C0", Offset = "0x27009C0", VA = "0x1827017C0", Slot = "61")]
		public void GDEFKJEDPPO(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2701830", Offset = "0x2700A30", VA = "0x182701830", Slot = "62")]
		public int GEPGKPGDJJL(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x27036E0", Offset = "0x27028E0", VA = "0x1827036E0", Slot = "63")]
		public void PFDJCCMOIFP(HPHBHAKAACD EHNNHDBEJOG, int IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2701FC0", Offset = "0x27011C0", VA = "0x182701FC0", Slot = "64")]
		public Rigidbody HNIOLIALEDA(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2701300", Offset = "0x2700500", VA = "0x182701300", Slot = "65")]
		public void EKJPDKGKBJN(HPHBHAKAACD EHNNHDBEJOG, Rigidbody IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x27032D0", Offset = "0x27024D0", VA = "0x1827032D0", Slot = "75")]
		public void NMECDPHOCAF(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2703650", Offset = "0x2702850", VA = "0x182703650", Slot = "76")]
		public void PFBMFGOOPAJ(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2700D30", Offset = "0x26FFF30", VA = "0x182700D30", Slot = "77")]
		public bool DEKCADMNEAF(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x27038A0", Offset = "0x2702AA0", VA = "0x1827038A0", Slot = "66")]
		public object POICFMLBOGJ(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x27029D0", Offset = "0x2701BD0", VA = "0x1827029D0", Slot = "67")]
		public void KGFBOGLIPPA(HPHBHAKAACD EHNNHDBEJOG, object IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2703360", Offset = "0x2702560", VA = "0x182703360", Slot = "68")]
		public object NNICFMOMNEA(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2700560", Offset = "0x26FF760", VA = "0x182700560", Slot = "69")]
		public void AIICIANDKMJ(HPHBHAKAACD EHNNHDBEJOG, object IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2702370", Offset = "0x2701570", VA = "0x182702370", Slot = "70")]
		public float IEDDPADLONC(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2701620", Offset = "0x2700820", VA = "0x182701620", Slot = "71")]
		public void FGCECCNOHHA(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2701CC0", Offset = "0x2700EC0", VA = "0x182701CC0", Slot = "78")]
		public void HHFDBEGAOCA(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2701F30", Offset = "0x2701130", VA = "0x182701F30", Slot = "79")]
		public void HNCPNLIICFC(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2701690", Offset = "0x2700890", VA = "0x182701690", Slot = "80")]
		public bool FNKCDILFPMO(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2700CD0", Offset = "0x26FFED0", VA = "0x182700CD0", Slot = "24")]
		public void DDAPJOFALFP(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2701500", Offset = "0x2700700", VA = "0x182701500", Slot = "25")]
		public void ELFGEDNJOHG(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x39B0AE0", Offset = "0x39AFCE0", VA = "0x1839B0AE0")]
		private void DEOIBGBBKHF<T>(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x39B0900", Offset = "0x39AFB00", VA = "0x1839B0900")]
		private bool CACDLNNMNPJ<T>(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x39B1C50", Offset = "0x39B0E50", VA = "0x1839B1C50")]
		private void MILDLLFOGOM<T>(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x39B0960", Offset = "0x39AFB60", VA = "0x1839B0960")]
		private bool CKMAOLFBIGE<TC, TV>(HPHBHAKAACD EHNNHDBEJOG, Func<TC, TV> AGLNNHPIMMA, out TV IPMIIEAGJKC) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x39B0880", Offset = "0x39AFA80", VA = "0x1839B0880")]
		private bool CKMAOLFBIGE<T>(HPHBHAKAACD EHNNHDBEJOG, out T IPMIIEAGJKC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39B1190", Offset = "0x39B0390", VA = "0x1839B1190")]
		private T IENHAIOPHPP<T>(HPHBHAKAACD EHNNHDBEJOG) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x39B1700", Offset = "0x39B0900", VA = "0x1839B1700")]
		private void KHIFOFGEHPO<T>(HPHBHAKAACD EHNNHDBEJOG, T IPMIIEAGJKC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x39B0B30", Offset = "0x39AFD30", VA = "0x1839B0B30")]
		private void HILGBDCGOCI<T>(HPHBHAKAACD EHNNHDBEJOG, T IPMIIEAGJKC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x39B0880", Offset = "0x39AFA80", VA = "0x1839B0880")]
		private bool AIKNOODKOKI<T>(HPHBHAKAACD EHNNHDBEJOG, out T IPMIIEAGJKC) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x39B16A0", Offset = "0x39B08A0", VA = "0x1839B16A0")]
		private T JBMNPEEOKJH<T>(HPHBHAKAACD EHNNHDBEJOG) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x39B0880", Offset = "0x39AFA80", VA = "0x1839B0880")]
		private void JCBGPLAGMOD<T>(HPHBHAKAACD EHNNHDBEJOG, T IPMIIEAGJKC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x39B1CB0", Offset = "0x39B0EB0", VA = "0x1839B1CB0")]
		private void MMPJLBELHDH<T>(HPHBHAKAACD EHNNHDBEJOG, T IPMIIEAGJKC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x27012D0", Offset = "0x27004D0", VA = "0x1827012D0")]
		private HPHBHAKAACD EKFIHCHJFOJ(Entity LHCPLOHKBCE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2701BF0", Offset = "0x2700DF0", VA = "0x182701BF0")]
		private DynamicBuffer<Entity> HDLBJAIPHIB(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x39B15E0", Offset = "0x39B07E0", VA = "0x1839B15E0")]
		private void INMDFHBBMCO<T>(HPHBHAKAACD EHNNHDBEJOG, object IPMIIEAGJKC, Func<object, T> AGLNNHPIMMA) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void LLLPMINBGLL<T>(ref global::PGKKAFJFFBH<T> LKGFBGELPCN) where T : struct, OEMKBCGGACH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void LLLPMINBGLL<TC, TV>(ref global::BPEILBAOPBF<TC, TV> LKGFBGELPCN) where TC : struct, OEMKBCGGACH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	[PNCLNBNALEO(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class EPGLBCAGNBL : IEnumerable<AEPAMCILECN>, IEnumerable, IEnumerator<AEPAMCILECN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private AEPAMCILECN <>2__current;

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
			private AEPAMCILECN System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
			[DebuggerHidden]
			public EPGLBCAGNBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x34D18B0", Offset = "0x34D0AB0", VA = "0x1834D18B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x34D1570", Offset = "0x34D0770", VA = "0x1834D1570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x34D1930", Offset = "0x34D0B30", VA = "0x1834D1930")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x34D1870", Offset = "0x34D0A70", VA = "0x1834D1870", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x34D17C0", Offset = "0x34D09C0", VA = "0x1834D17C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AEPAMCILECN> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x34D17C0", Offset = "0x34D09C0", VA = "0x1834D17C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> KCKDENMKJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x26B06B0", Offset = "0x26AF8B0", VA = "0x1826B06B0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x26AF9E0", Offset = "0x26AEBE0", VA = "0x1826AF9E0")]
		public void CCLIJPKADNO(NativeArray<Entity> EJIAHCPIPFJ, bool DNCFADPNEDO, bool HBNKIDFHDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x26AFC50", Offset = "0x26AEE50", VA = "0x1826AFC50")]
		public void EEMIGFCEDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x26AFEF0", Offset = "0x26AF0F0", VA = "0x1826AFEF0")]
		private void IGLGFOPGEKP(NativeArray<Entity> EJIAHCPIPFJ, bool DNCFADPNEDO, bool HBNKIDFHDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x26AFE60", Offset = "0x26AF060", VA = "0x1826AFE60")]
		[IteratorStateMachine(typeof(EPGLBCAGNBL))]
		private IEnumerable<AEPAMCILECN> HLNHBIMHDEB(NativeArray<Entity> EJIAHCPIPFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x26AFB00", Offset = "0x26AED00", VA = "0x1826AFB00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x26B0750", Offset = "0x26AF950", VA = "0x1826B0750")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[PNCLNBNALEO(typeof(IIEGBNJCKEO), new string[] { })]
public class NMIONAEBDDP : IIEGBNJCKEO, IEnumerable<NDGJEHEDOED>, IEnumerable, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[GAJFPHPAPMA]
	private PPAIBFHCMKN BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> KIDBANHGEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private GKCPENDEBGA ODJAIHADIEG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1D40", Offset = "0x2AF0F40", VA = "0x182AF1D40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public NDGJEHEDOED POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF25F0", Offset = "0x2AF17F0", VA = "0x182AF25F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public NDGJEHEDOED POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF25F0", Offset = "0x2AF17F0", VA = "0x182AF25F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1D60", Offset = "0x2AF0F60", VA = "0x182AF1D60", Slot = "11")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF22C0", Offset = "0x2AF14C0", VA = "0x182AF22C0", Slot = "12")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1DB0", Offset = "0x2AF0FB0", VA = "0x182AF1DB0")]
	private void EBKBOKCFCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x219B770", Offset = "0x219A970", VA = "0x18219B770")]
	private string KANJOFBIKID(string KNOPFGAGMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF21E0", Offset = "0x2AF13E0", VA = "0x182AF21E0", Slot = "7")]
	public NDGJEHEDOED KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2340", Offset = "0x2AF1540", VA = "0x182AF2340")]
	private bool PDPKAGPHAAN(Type GCILADHGICM, string KNOPFGAGMCN, out NDGJEHEDOED KDHBALDHKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AF20D0", Offset = "0x2AF12D0", VA = "0x182AF20D0", Slot = "8")]
	public GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return default(GFCMOFDOMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF20B0", Offset = "0x2AF12B0", VA = "0x182AF20B0", Slot = "9")]
	public IEnumerator<NDGJEHEDOED> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AF20B0", Offset = "0x2AF12B0", VA = "0x182AF20B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2610", Offset = "0x2AF1810", VA = "0x182AF2610")]
	public NMIONAEBDDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[DefaultMember("Item")]
public interface IEHGHGMCPNO
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLJAJDOFCEA(GFCMOFDOMMJ IKHNIJKGJFD, out int CAPKFCHDLFA);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[PNCLNBNALEO(typeof(IEHGHGMCPNO), new string[] { })]
public class LDGINDJBADP : CMLEAAEGAAL, BDLDACMOPAJ, IEHGHGMCPNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[GAJFPHPAPMA]
	private CCAADMLFLBF BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<GFCMOFDOMMJ, int> JKFKGJMHGOL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x26B2270", Offset = "0x26B1470", VA = "0x1826B2270", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26B21A0", Offset = "0x26B13A0", VA = "0x1826B21A0", Slot = "6")]
	public bool JLJAJDOFCEA(GFCMOFDOMMJ IKHNIJKGJFD, out int CAPKFCHDLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x26B2210", Offset = "0x26B1410", VA = "0x1826B2210", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x26B1F20", Offset = "0x26B1120", VA = "0x1826B1F20", Slot = "5")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26B1F30", Offset = "0x26B1130", VA = "0x1826B1F30")]
	private void JLDFNDLHOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x26B22D0", Offset = "0x26B14D0", VA = "0x1826B22D0")]
	public LDGINDJBADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[PNCLNBNALEO(typeof(CCAADMLFLBF), new string[] { })]
[DefaultMember("Item")]
public class PCFEMHGKECM : CCAADMLFLBF, IEnumerable<HGIJDEJFJEI>, IEnumerable, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, CNNKIACDEEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[GAJFPHPAPMA]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[GAJFPHPAPMA]
	private IIEGBNJCKEO KNIFOAIMGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private HGIJDEJFJEI[] HNNPCFFCKJK;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F90", Offset = "0x2B00190", VA = "0x182B00F90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HGIJDEJFJEI POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B00FA0", Offset = "0x2B001A0", VA = "0x182B00FA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public HGIJDEJFJEI POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B00FA0", Offset = "0x2B001A0", VA = "0x182B00FA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "10")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B01400", Offset = "0x2B00600", VA = "0x182B01400", Slot = "11")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "12")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B012D0", Offset = "0x2B004D0", VA = "0x182B012D0", Slot = "6")]
	public HGIJDEJFJEI KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B01200", Offset = "0x2B00400", VA = "0x182B01200", Slot = "7")]
	public GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return default(GFCMOFDOMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B01120", Offset = "0x2B00320", VA = "0x182B01120", Slot = "8")]
	public IEnumerator<HGIJDEJFJEI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B016A0", Offset = "0x2B008A0", VA = "0x182B016A0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E88D10", Offset = "0x2E87F10", VA = "0x182E88D10", Slot = "13")]
	public void OPDHHPNOPFF<TKey, T>(global::FMBDPECPAID<TKey, T> IDBLFHOOMPH, [Optional] object DELCOFCGDFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B00FE0", Offset = "0x2B001E0", VA = "0x182B00FE0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PCFEMHGKECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B00FA0", Offset = "0x2B001A0", VA = "0x182B00FA0")]
	[CompilerGenerated]
	private HGIJDEJFJEI DAIHIBGJDMJ(int MLECAGAJCGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[PNCLNBNALEO(typeof(BPDDKPBGCMN), new string[] { })]
public class ABGMNABGEKC : BPDDKPBGCMN, IEnumerable<KFBCGBKCDNN>, IEnumerable, CMLEAAEGAAL, BDLDACMOPAJ, CNNKIACDEEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[GAJFPHPAPMA]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[GAJFPHPAPMA]
	private IIEGBNJCKEO KNIFOAIMGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private KFBCGBKCDNN[] HNNPCFFCKJK;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EC10", Offset = "0x2A9DE10", VA = "0x182A9EC10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KFBCGBKCDNN POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EC60", Offset = "0x2A9DE60", VA = "0x182A9EC60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KFBCGBKCDNN POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EC60", Offset = "0x2A9DE60", VA = "0x182A9EC60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F0F0", Offset = "0x2A9E2F0", VA = "0x182A9F0F0", Slot = "9")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E9B0", Offset = "0x2A9DBB0", VA = "0x182A9E9B0", Slot = "10")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F010", Offset = "0x2A9E210", VA = "0x182A9F010")]
	private KFBCGBKCDNN OFFHDEMMLIC(int GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EEF0", Offset = "0x2A9E0F0", VA = "0x182A9EEF0", Slot = "6")]
	public KFBCGBKCDNN KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EE20", Offset = "0x2A9E020", VA = "0x182A9EE20", Slot = "14")]
	public GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ OPCKJKNEHGA)
	{
		return default(GFCMOFDOMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED10", Offset = "0x2A9DF10", VA = "0x182A9ED10", Slot = "7")]
	public IEnumerator<KFBCGBKCDNN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2A9ED10", Offset = "0x2A9DF10", VA = "0x182A9ED10", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0xE16430", Offset = "0xE15630", VA = "0x180E16430", Slot = "11")]
	public void OPDHHPNOPFF<TKey, T>(global::FMBDPECPAID<TKey, T> IDBLFHOOMPH, [Optional] object DELCOFCGDFF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EC70", Offset = "0x2A9DE70", VA = "0x182A9EC70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ABGMNABGEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2A9EC60", Offset = "0x2A9DE60", VA = "0x182A9EC60")]
	[CompilerGenerated]
	private KFBCGBKCDNN DAIHIBGJDMJ(int MLECAGAJCGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[PNCLNBNALEO(typeof(PPAIBFHCMKN), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
internal class PPAIBFHCMKN : CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private IIEGBNJCKEO KNIFOAIMGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private BPDDKPBGCMN ILNBFCPCCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private CCAADMLFLBF PMALKPDDKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::LCDGDDNFDOO<CMBJNHHMHON> NJABIIDPGKD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GKCPENDEBGA HOMBJJJMOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2B03D10", Offset = "0x2B02F10", VA = "0x182B03D10", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2B03B50", Offset = "0x2B02D50", VA = "0x182B03B50")]
	private void JHKFNPMKJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x13AABA0", Offset = "0x13A9DA0", VA = "0x1813AABA0")]
	public T BAADFEEMNDD<T>() where T : CMBJNHHMHON
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2B039B0", Offset = "0x2B02BB0", VA = "0x182B039B0")]
	public NDGJEHEDOED CIENIDJEAMM(JECBEPMPMHJ KNOPFGAGMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::FPAJBINIPIL<T> CIENIDJEAMM<T>(JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2B03A80", Offset = "0x2B02C80", VA = "0x182B03A80")]
	public KFBCGBKCDNN FFDCIJGIHLO(JECBEPMPMHJ KNOPFGAGMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x25BD150", Offset = "0x25BC350", VA = "0x1825BD150")]
	public global::CBCHMFJEMMP<T> FFDCIJGIHLO<T>(JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2B03C40", Offset = "0x2B02E40", VA = "0x182B03C40")]
	public HGIJDEJFJEI NIMNGFAPPDM(JECBEPMPMHJ KNOPFGAGMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::FPMLPKLCNHP<T> NIMNGFAPPDM<T>(JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PPAIBFHCMKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class FIDHOFLNNGG
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1494CB0", Offset = "0x1493EB0", VA = "0x181494CB0")]
	public static global::FPAJBINIPIL<T> CIENIDJEAMM<T>(this PPAIBFHCMKN AEBNJEGLADB, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::CBCHMFJEMMP<T> FFDCIJGIHLO<T>(this PPAIBFHCMKN AEBNJEGLADB, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::FPMLPKLCNHP<T> NIMNGFAPPDM<T>(this PPAIBFHCMKN AEBNJEGLADB, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[PNCLNBNALEO(typeof(FOLNGOGAINK), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public class FOLNGOGAINK : CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private LLJOLCFMNOE AECGBKJAICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private GFCMOFDOMMJ[] JHBKNLNOEHK;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x269D2D0", Offset = "0x269C4D0", VA = "0x18269D2D0", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x269D1B0", Offset = "0x269C3B0", VA = "0x18269D1B0")]
	public void MIJAGHMGMDP(HCIIHJLICJK MIBPNJCOIHL, bool JOOHABHHKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FOLNGOGAINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[PNCLNBNALEO(typeof(IAEFPANBICN), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public sealed class IAEFPANBICN : CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KEJMDOIHNEH : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
		[DebuggerHidden]
		public KEJMDOIHNEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x34D6140", Offset = "0x34D5340", VA = "0x1834D6140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x34D5D90", Offset = "0x34D4F90", VA = "0x1834D5D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x34D61C0", Offset = "0x34D53C0", VA = "0x1834D61C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x34D6100", Offset = "0x34D5300", VA = "0x1834D6100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x34D6070", Offset = "0x34D5270", VA = "0x1834D6070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x34D6070", Offset = "0x34D5270", VA = "0x1834D6070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string IPKGMAPFFAK = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, GCALDJOLPHE> GJOHFEGPAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> EBGDOJOAKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> ELFOBADGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private BPDDKPBGCMN BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private DAHJGPKAIEK MAHBIJBCNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private DKCBHGMJMEO ILPMCHGFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::NOBICPNOIDE<GCALDJOLPHE> JNPHDBAPKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject CIPKEIFBMMP;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x26A6BC0", Offset = "0x26A5DC0", VA = "0x1826A6BC0", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5560", Offset = "0x26A4760", VA = "0x1826A5560", Slot = "5")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x26A5C50", Offset = "0x26A4E50", VA = "0x1826A5C50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x26A6BB0", Offset = "0x26A5DB0", VA = "0x1826A6BB0")]
	private void NOOCCJGJKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6780", Offset = "0x26A5980", VA = "0x1826A6780")]
	internal void LEMHBJAIEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x26A5DF0", Offset = "0x26A4FF0", VA = "0x1826A5DF0")]
	private void FLJDHMIIELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x26A64A0", Offset = "0x26A56A0", VA = "0x1826A64A0")]
	private void IDJLHPFOCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x26A5C00", Offset = "0x26A4E00", VA = "0x1826A5C00")]
	[IteratorStateMachine(typeof(KEJMDOIHNEH))]
	private IEnumerable<RRCustomPropTag> CMJHIIGANAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x26A6020", Offset = "0x26A5220", VA = "0x1826A6020")]
	private void HFCMFGKPLEF(HPHBHAKAACD EHNNHDBEJOG, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x26A5AC0", Offset = "0x26A4CC0", VA = "0x1826A5AC0")]
	private void BNAKCAAHHPA(SerializableGuid JMIFIJDBMNM, GameObject BMNLOPDIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x26A5730", Offset = "0x26A4930", VA = "0x1826A5730")]
	private void BIHPGIOKPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x26A65A0", Offset = "0x26A57A0", VA = "0x1826A65A0")]
	private bool KKDADHEANLO(GCALDJOLPHE HKPGBGBJNID, Transform HHFDFFDPCGO, out GameObject CMDPMJBEBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x26A5FD0", Offset = "0x26A51D0", VA = "0x1826A5FD0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x26A6C90", Offset = "0x26A5E90", VA = "0x1826A6C90")]
	public IAEFPANBICN()
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
		public SerializableGuid AKIKPMDLPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2700400", Offset = "0x26FF600", VA = "0x182700400")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PNCLNBNALEO(typeof(NGNHPIBNAGP), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public class NGNHPIBNAGP : CMLEAAEGAAL
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string JKDMDKEDNAI = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService DCDCBKEJKDG;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0D60", Offset = "0x2AEFF60", VA = "0x182AF0D60", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NGNHPIBNAGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[PNCLNBNALEO(typeof(ABEIEBMDHHB), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public class ABEIEBMDHHB : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[GAJFPHPAPMA]
	private EnableComponentSystemsInScope OJAAACHOENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[GAJFPHPAPMA]
	private SceneService DCDCBKEJKDG;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E940", Offset = "0x2A9DB40", VA = "0x182A9E940", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E8E0", Offset = "0x2A9DAE0", VA = "0x182A9E8E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E920", Offset = "0x2A9DB20", VA = "0x182A9E920")]
	private void NFCMKHHCFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E8B0", Offset = "0x2A9DAB0", VA = "0x182A9E8B0")]
	private void CMLEBEADADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ABEIEBMDHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[PNCLNBNALEO(typeof(CNBEKDOCLNI), new string[] { })]
public class ABCIONEGDKA : CMLEAAEGAAL, BDLDACMOPAJ, CNBEKDOCLNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private GBMEAEPJCNJ HKPONLMBIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private JEDGFCHEAOG AFLLDBEPJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService GGIAAMGAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem OPOJMHAIGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int GBEHMDDFPIB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool NEDBNEJNCML
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E820", Offset = "0x2A9DA20", VA = "0x182A9E820", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public HPHBHAKAACD ADDFEGOCCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E7E0", Offset = "0x2A9D9E0", VA = "0x182A9E7E0", Slot = "9")]
		get
		{
			return default(HPHBHAKAACD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E3F0", Offset = "0x2A9D5F0", VA = "0x182A9E3F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DBJMAFIOFFK KANOFNBOLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E6C0", Offset = "0x2A9D8C0", VA = "0x182A9E6C0", Slot = "11")]
		get
		{
			return default(DBJMAFIOFFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E3F0", Offset = "0x2A9D5F0", VA = "0x182A9E3F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DBJMAFIOFFK NNNBFIFNHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E860", Offset = "0x2A9DA60", VA = "0x182A9E860", Slot = "13")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint CGBNEINCONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DFD0", Offset = "0x2A9D1D0", VA = "0x182A9DFD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MFGDFMIFIGG FKGJCGANBPC
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DE80", Offset = "0x2A9D080", VA = "0x182A9DE80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DBE0", Offset = "0x2A9CDE0", VA = "0x182A9DBE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E710", Offset = "0x2A9D910", VA = "0x182A9E710", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DA40", Offset = "0x2A9CC40", VA = "0x182A9DA40", Slot = "5")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DF20", Offset = "0x2A9D120", VA = "0x182A9DF20", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DC80", Offset = "0x2A9CE80", VA = "0x182A9DC80")]
	private void BEAIANDJBLG(Entity LHCPLOHKBCE, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI HKPEMIJGIMD, NFKEKJGDLJI INPBMNIIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E2E0", Offset = "0x2A9D4E0", VA = "0x182A9E2E0", Slot = "14")]
	public HPHBHAKAACD INDFLLMAOHH(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E1E0", Offset = "0x2A9D3E0", VA = "0x182A9E1E0", Slot = "15")]
	public bool GDHBJPCNPAN(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC, out HPHBHAKAACD LCFGMFPMPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E530", Offset = "0x2A9D730", VA = "0x182A9E530", Slot = "16")]
	public void MHLBJJGEBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E490", Offset = "0x2A9D690", VA = "0x182A9E490", Slot = "17")]
	public void LNAJOFELJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E080", Offset = "0x2A9D280", VA = "0x182A9E080", Slot = "18")]
	public bool EFAMJNCIJCP(HPHBHAKAACD GFCPAMJILIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E3F0", Offset = "0x2A9D5F0", VA = "0x182A9E3F0")]
	private void IPJJMDGKOMB(HPHBHAKAACD LEILCOCOOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ABCIONEGDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[PNCLNBNALEO(typeof(MBILFEPAMHC), new string[] { })]
public class AJDDGDIIBDC : CMLEAAEGAAL, MBILFEPAMHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FF70", Offset = "0x2A9F170", VA = "0x182A9FF70", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FF00", Offset = "0x2A9F100", VA = "0x182A9FF00", Slot = "5")]
	public void NMCJGPGHPPH(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2782590", Offset = "0x2781790", VA = "0x182782590")]
	private void PLCAKFAMFIL<T>(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AJDDGDIIBDC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[PNCLNBNALEO(typeof(DGBAPALLGDE), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.RenderEffects)]
	public class SelectionService : CMLEAAEGAAL, DGBAPALLGDE
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2706E40", Offset = "0x2706040", VA = "0x182706E40", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2706DD0", Offset = "0x2705FD0", VA = "0x182706DD0", Slot = "5")]
		public void HOIGBGNFADA(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2706EC0", Offset = "0x27060C0", VA = "0x182706EC0", Slot = "6")]
		public void PDDJMDKFHON(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2782590", Offset = "0x2781790", VA = "0x182782590")]
		private void PLCAKFAMFIL<T>(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
[PNCLNBNALEO(typeof(POOIJCNECMP), new string[] { })]
internal sealed class POOIJCNECMP : CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[GAJFPHPAPMA]
	private ObjectEmbodimentService MICPPHDEBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM HIJDILOKICJ;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2B038D0", Offset = "0x2B02AD0", VA = "0x182B038D0", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public POOIJCNECMP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	[PNCLNBNALEO(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : CMLEAAEGAAL, IIBDPIPACMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly HDHIMOFHFJL KGPMGPHJKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[GAJFPHPAPMA]
		private AEOPHBOKNJI JOIEBCBPCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[GAJFPHPAPMA]
		private SerializationService MAHBIJBCNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[GAJFPHPAPMA]
		private GMIJLIFNPJO IAOPBOEHEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[GAJFPHPAPMA]
		private DebugWorldsService MGGEBDILEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[GAJFPHPAPMA]
		private BulkInstantiateSceneObjectService ODCNMENPODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private BLBDINABANB LBBJCIBEDFD;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private CLPPOKFANAO MNENPNLBBHK
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x17B9A90", Offset = "0x17B8C90", VA = "0x1817B9A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x271BF30", Offset = "0x271B130", VA = "0x18271BF30", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBPEEFBDHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x271B9E0", Offset = "0x271ABE0", VA = "0x18271B9E0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x271B500", Offset = "0x271A700", VA = "0x18271B500", Slot = "6")]
		public bool CGLNBMALNKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x271BF10", Offset = "0x271B110", VA = "0x18271BF10", Slot = "7")]
		public bool MICFFOHBDMO(IEnumerable<GKJFAKANILO> GDKJDDCKGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x271B020", Offset = "0x271A220", VA = "0x18271B020", Slot = "5")]
		public ByteString AIBJBMGLFMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x271BEF0", Offset = "0x271B0F0", VA = "0x18271BEF0")]
		private void MGFFOFJBFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x271AF50", Offset = "0x271A150", VA = "0x18271AF50")]
		private void AAMKLIAAJKP(AJPDKCDNPDL LCMDLFOKELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x271BA10", Offset = "0x271AC10", VA = "0x18271BA10")]
		private void FNDBLMMHNCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x271B700", Offset = "0x271A900", VA = "0x18271B700")]
		private void DLBLNAFLIEK(NCIOIFNNEKH LCMDLFOKELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x271B4B0", Offset = "0x271A6B0", VA = "0x18271B4B0", Slot = "8")]
		public void ALDNDHFJDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x271B660", Offset = "0x271A860", VA = "0x18271B660")]
		private AJPDKCDNPDL DEGLJOPIOEJ(EntityManager MPHGLGFGOMF, EntityManager CJHLNLGDMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[PNCLNBNALEO(typeof(LDJCCPOAFIH), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public class LDJCCPOAFIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<HAGCJKKHBBM, string> IHLJHIFFNPM;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x26B2350", Offset = "0x26B1550", VA = "0x1826B2350")]
	public GameObject PEAIEFKNGCM(HAGCJKKHBBM LJGNKMONIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x26B2420", Offset = "0x26B1620", VA = "0x1826B2420")]
	public LDJCCPOAFIH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(TimeService), new string[] { })]
	public class TimeService : IMFHGBIDMMC, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[GAJFPHPAPMA]
		private SingletonComponentService PNPFBLLBFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool COPEPJHJLPP;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData BNJNAMCMGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x270E820", Offset = "0x270DA20", VA = "0x18270E820")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x270E6E0", Offset = "0x270D8E0", VA = "0x18270E6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool IAFABBLCFDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x7E47C0", Offset = "0x7E39C0", VA = "0x1807E47C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1C21AF0", Offset = "0x1C20CF0", VA = "0x181C21AF0", Slot = "4")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x270E890", Offset = "0x270DA90", VA = "0x18270E890", Slot = "5")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x270E760", Offset = "0x270D960", VA = "0x18270E760")]
		public void FNGDPOFBKJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	[PNCLNBNALEO(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private EFDNEMMCCPM EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::FPAJBINIPIL<Entity> HHFDFFDPCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService BBFEJKBBFEI;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x270AB70", Offset = "0x2709D70", VA = "0x18270AB70", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x270A860", Offset = "0x2709A60", VA = "0x18270A860", Slot = "5")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x270A990", Offset = "0x2709B90", VA = "0x18270A990", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x270AA30", Offset = "0x2709C30", VA = "0x18270AA30")]
		private void MANOIOFDEEM(Entity LHCPLOHKBCE, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Services)]
	[PNCLNBNALEO(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[GAJFPHPAPMA]
		private MDBGNGDHHEL BFDBCMGIOBG;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private CFNBPFBIHPJ IALJPNLJCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x26947A0", Offset = "0x26939A0", VA = "0x1826947A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private KDMHFPHOAPE PLBFICEGEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x26947F0", Offset = "0x26939F0", VA = "0x1826947F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2694840", Offset = "0x2693A40", VA = "0x182694840", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2694780", Offset = "0x2693980", VA = "0x182694780", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[PNCLNBNALEO(typeof(PBDGLENNILO), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public class PBDGLENNILO : FGPHKGGABON, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class GIIEDOOPCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public BLBDINABANB services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GIIEDOOPCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x34D29D0", Offset = "0x34D1BD0", VA = "0x1834D29D0")]
		internal void <InitReferences>b__0(CMLEAAEGAAL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HNBAMMBPCDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public BLBDINABANB services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public HNBAMMBPCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x34D4060", Offset = "0x34D3260", VA = "0x1834D4060")]
		internal void <InitExternal>b__0(BDLDACMOPAJ svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM HIJDILOKICJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public DDILJKOPKGP IAJLHNJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x860040", Offset = "0x85F240", VA = "0x180860040", Slot = "4")]
		get
		{
			return default(DDILJKOPKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NNHDOGKABEI JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2B00CE0", Offset = "0x2AFFEE0", VA = "0x182B00CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2B00E60", Offset = "0x2B00060", VA = "0x182B00E60", Slot = "5")]
	public void OLHDANNJCMN(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2B00BB0", Offset = "0x2AFFDB0", VA = "0x182B00BB0", Slot = "6")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2B00EB0", Offset = "0x2B000B0", VA = "0x182B00EB0", Slot = "7")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2B00AD0", Offset = "0x2AFFCD0", VA = "0x182B00AD0", Slot = "8")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2B00D30", Offset = "0x2AFFF30", VA = "0x182B00D30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2E87130", Offset = "0x2E86330", VA = "0x182E87130")]
	private void NIFODGCDHHK<T>(Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PBDGLENNILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class DNMMMPJCBFG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> FKHGIDOBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> ACMMHKGMFIC;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To POFBPBHJKPE
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
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public DNMMMPJCBFG(Func<From, To> GOIOJEGDINC, Func<To, From> FKHGIDOBCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HAHPMNMCEBD, int PBNJDHGCIFC)
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
	public int IndexOf(To ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GMEHLIHLGEH, To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
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
public class CGAEHHNONGD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> FKHGIDOBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C151D0", Offset = "0x2C143D0", VA = "0x182C151D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C15230", Offset = "0x2C14430", VA = "0x182C15230", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C151A0", Offset = "0x2C143A0", VA = "0x182C151A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x24B3950", Offset = "0x24B2B50", VA = "0x1824B3950")]
	public CGAEHHNONGD(Func<From, To> GOIOJEGDINC, Func<To, From> FKHGIDOBCCH, bool ANPMMNBJEGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C14DF0", Offset = "0x2C13FF0", VA = "0x182C14DF0", Slot = "11")]
	public void Add(To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC170", Offset = "0x2BEB370", VA = "0x182BEC170", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C14E50", Offset = "0x2C14050", VA = "0x182C14E50", Slot = "13")]
	public bool Contains(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C14EB0", Offset = "0x2C140B0", VA = "0x182C14EB0", Slot = "14")]
	public void CopyTo(To[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C14FC0", Offset = "0x2C141C0", VA = "0x182C14FC0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C15030", Offset = "0x2C14230", VA = "0x182C15030", Slot = "6")]
	public int IndexOf(To ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C15090", Offset = "0x2C14290", VA = "0x182C15090", Slot = "7")]
	public void Insert(int GMEHLIHLGEH, To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C15140", Offset = "0x2C14340", VA = "0x182C15140", Slot = "15")]
	public bool Remove(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C15110", Offset = "0x2C14310", VA = "0x182C15110", Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x21BA640", Offset = "0x21B9840", VA = "0x1821BA640", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class ANJHBLFAKAI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> FKHGIDOBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> HAHPMNMCEBD;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x31E4AC0", Offset = "0x31E3CC0", VA = "0x1831E4AC0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x31E4B10", Offset = "0x31E3D10", VA = "0x1831E4B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x31E4A80", Offset = "0x31E3C80", VA = "0x1831E4A80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2469620", Offset = "0x2468820", VA = "0x182469620")]
	public ANJHBLFAKAI(Func<From, To> GOIOJEGDINC, Func<To, From> FKHGIDOBCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x31E4690", Offset = "0x31E3890", VA = "0x1831E4690", Slot = "11")]
	public void Add(To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x31E46D0", Offset = "0x31E38D0", VA = "0x1831E46D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x31E4710", Offset = "0x31E3910", VA = "0x1831E4710", Slot = "13")]
	public bool Contains(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x31E47D0", Offset = "0x31E39D0", VA = "0x1831E47D0", Slot = "14")]
	public void CopyTo(To[] HAHPMNMCEBD, int PBNJDHGCIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x31E4890", Offset = "0x31E3A90", VA = "0x1831E4890", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x31E4950", Offset = "0x31E3B50", VA = "0x1831E4950", Slot = "6")]
	public int IndexOf(To ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x31E49C0", Offset = "0x31E3BC0", VA = "0x1831E49C0", Slot = "7")]
	public void Insert(int GMEHLIHLGEH, To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x31E4A40", Offset = "0x31E3C40", VA = "0x1831E4A40", Slot = "15")]
	public bool Remove(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x31E4A00", Offset = "0x31E3C00", VA = "0x1831E4A00", Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3520", Offset = "0x1FC2720", VA = "0x181FC3520", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class OKDEBJOLCOF<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> GOIOJEGDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> FKHGIDOBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To POFBPBHJKPE
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
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool NNJLEOOEELM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public OKDEBJOLCOF(Func<From, To> GOIOJEGDINC, Func<To, From> FKHGIDOBCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HAHPMNMCEBD, int PBNJDHGCIFC)
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
	public int IndexOf(To ONCGIPFNENB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GMEHLIHLGEH, To ONCGIPFNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To ONCGIPFNENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GMEHLIHLGEH)
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
public static class FOJIBBDKLAL
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string FPCJMOLGCOD = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string DJADKMDADMH = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string NPPDKHHDJDF = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string MNMECAEHNBC = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string ALBEJIOGMHO = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string CDAELAAMKLD = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string ILMNNGEFEFO = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string FLEPLDCHODE = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class BBDENNKMLPP
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class KLFNHDOMBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public BLBDINABANB services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KLFNHDOMBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x26FF180", Offset = "0x26FE380", VA = "0x1826FF180")]
		internal void <InitServices>b__1(CMLEAAEGAAL svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x26FF1E0", Offset = "0x26FE3E0", VA = "0x1826FF1E0")]
		internal void <InitServices>b__2(BDLDACMOPAJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2F10", Offset = "0x2AA2110", VA = "0x182AA2F10")]
	public static void GDLIPHANANM(this NNHDOGKABEI PHAHHGAAFFH, BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x240ACD0", Offset = "0x2409ED0", VA = "0x18240ACD0")]
	public static void NIFODGCDHHK<T>(this NNHDOGKABEI PHAHHGAAFFH, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x240AB30", Offset = "0x2409D30", VA = "0x18240AB30")]
	public static void MOJFKKMNHHN<T>(this NNHDOGKABEI PHAHHGAAFFH, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x240A810", Offset = "0x2409A10", VA = "0x18240A810")]
	public static void JENPCKLHKHH<T>(this NNHDOGKABEI PHAHHGAAFFH, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x240AD40", Offset = "0x2409F40", VA = "0x18240AD40")]
	public static void PKGGPCMCBMG<T>(this NNHDOGKABEI PHAHHGAAFFH, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x240A5A0", Offset = "0x24097A0", VA = "0x18240A5A0")]
	public static void AEHCNPHLAMD<T>(this NNHDOGKABEI PHAHHGAAFFH, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x240A9C0", Offset = "0x2409BC0", VA = "0x18240A9C0")]
	public static void MOJFKKMNHHN<T>(IEnumerable<ComponentSystemBase> JBDCCFIPMAL, Action<T> LHCGJABGDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x240A750", Offset = "0x2409950", VA = "0x18240A750")]
	private static void ICMBBDEOBAC<T>(object NHEJJBLKANC, Action<T> LHCGJABGDEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class MIKPABMKDIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LIJANGIDGPI
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AED200", Offset = "0x2AEC400", VA = "0x182AED200")]
	public static void MCIEPHEHLDF(ComponentSystemBase NHEJJBLKANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PAHMPMJJIGC
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool DNMKMHELHID<T>(ref T NNMPJECKECI, ref T EFNJCAIBDLA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class DJDOHJOGNGB
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class MNJOKEMFGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public MNJOKEMFGHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5E50", Offset = "0x2AB5050", VA = "0x182AB5E50")]
	public static string PMDKMIKCJNM(Transform FGNGGLFNLIP, Transform GFCPAMJILIO)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2709740", Offset = "0x2708940", VA = "0x182709740")]
		public static void FHPMCAKDNGP(this IALMMDHPOBI LBBJCIBEDFD, HEJOODJDOMN PANELIGGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2709A20", Offset = "0x2708C20", VA = "0x182709A20")]
		public static void JGGGJGBEKMM(this IALMMDHPOBI LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2709630", Offset = "0x2708830", VA = "0x182709630")]
		public static void FHPMCAKDNGP(this IALMMDHPOBI LBBJCIBEDFD, [Optional] string[] HBABOANDOKA, [Optional] string[] LNBJOJCBMBH, [Optional] string[] NFBEECABDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2709970", Offset = "0x2708B70", VA = "0x182709970")]
		public static void HBLFCAHDDBB(this IALMMDHPOBI LBBJCIBEDFD, params string[] HKHKOJGCMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2709CE0", Offset = "0x2708EE0", VA = "0x182709CE0")]
		public static void MBAGKEPNOFJ(this IALMMDHPOBI LBBJCIBEDFD, params string[] HKHKOJGCMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2709D90", Offset = "0x2708F90", VA = "0x182709D90")]
		private static string[] PACBFKCJBCH(HEJOODJDOMN PANELIGGJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2709B20", Offset = "0x2708D20", VA = "0x182709B20")]
		private static bool LLPIAMNKBLO(HEJOODJDOMN PANELIGGJGM, out string[] HACJLFMECEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0")]
		private static bool POGMOLMJOLP()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class BMNADGPKGGL : CPGHBJLKEEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo KNPFGJGJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] ADCFFAJGNAM;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3D60", Offset = "0x2AA2F60", VA = "0x182AA3D60")]
	public BMNADGPKGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action NLPHCANLEPM();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3D20", Offset = "0x2AA2F20", VA = "0x182AA3D20")]
	public MethodInfo KDKDCPPHBEI(Action IBKGKDECOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3B70", Offset = "0x2AA2D70", VA = "0x182AA3B70", Slot = "4")]
	public void BNAKCAAHHPA(Type NIFOGEBEDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class FIPOBOKEIIC : BMNADGPKGGL
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum LLKCMOFKGIO
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2699AA0", Offset = "0x2698CA0", VA = "0x182699AA0", Slot = "5")]
	public override Action NLPHCANLEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EIGMPJHOEIH<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2699A10", Offset = "0x2698C10", VA = "0x182699A10")]
	[Preserve]
	public void LNCAAHKCAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2699B30", Offset = "0x2698D30", VA = "0x182699B30")]
	protected FIPOBOKEIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class LGNBMDBBJAG : BMNADGPKGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2AED170", Offset = "0x2AEC370", VA = "0x182AED170", Slot = "5")]
	public override Action NLPHCANLEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KBDJLODIHJE<T>() where T : LLPAFDMOEEL;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2AED0E0", Offset = "0x2AEC2E0", VA = "0x182AED0E0")]
	[Preserve]
	public void LNCAAHKCAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2699B30", Offset = "0x2698D30", VA = "0x182699B30")]
	protected LGNBMDBBJAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class HLNBMHOIKLN : BMNADGPKGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x26A1920", Offset = "0x26A0B20", VA = "0x1826A1920", Slot = "5")]
	public override Action NLPHCANLEPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ABAJOJMNOCK<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x26A1890", Offset = "0x26A0A90", VA = "0x1826A1890")]
	[Preserve]
	public void LNCAAHKCAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2699B30", Offset = "0x2698D30", VA = "0x182699B30")]
	protected HLNBMHOIKLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class GJAMGHOHLFA
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x269DC20", Offset = "0x269CE20", VA = "0x18269DC20")]
	public static Entity OCBBNMFDPOI(this EntityManager IIODDCGHDHF)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class EPIHHIFIPKK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1DA4C70", Offset = "0x1DA3E70", VA = "0x181DA4C70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x34D1B50", Offset = "0x34D0D50", VA = "0x1834D1B50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x34CFD20", Offset = "0x34CEF20", VA = "0x1834CFD20")]
			[DebuggerHidden]
			public EPIHHIFIPKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x34D1980", Offset = "0x34D0B80", VA = "0x1834D1980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x34D1B10", Offset = "0x34D0D10", VA = "0x1834D1B10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x34D1A60", Offset = "0x34D0C60", VA = "0x1834D1A60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x34D1A60", Offset = "0x34D0C60", VA = "0x1834D1A60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class HEOMAHGLEND : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1DA4C70", Offset = "0x1DA3E70", VA = "0x181DA4C70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x34D3870", Offset = "0x34D2A70", VA = "0x1834D3870", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x34CFD20", Offset = "0x34CEF20", VA = "0x1834CFD20")]
			[DebuggerHidden]
			public HEOMAHGLEND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x34D38C0", Offset = "0x34D2AC0", VA = "0x1834D38C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x34D3590", Offset = "0x34D2790", VA = "0x1834D3590", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x34D3950", Offset = "0x34D2B50", VA = "0x1834D3950")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x34D3830", Offset = "0x34D2A30", VA = "0x1834D3830", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x34D3780", Offset = "0x34D2980", VA = "0x1834D3780", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x34D3780", Offset = "0x34D2980", VA = "0x1834D3780", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class IODKCIKMOLN : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1DA4C70", Offset = "0x1DA3E70", VA = "0x181DA4C70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x34D55A0", Offset = "0x34D47A0", VA = "0x1834D55A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x34CFD20", Offset = "0x34CEF20", VA = "0x1834CFD20")]
			[DebuggerHidden]
			public IODKCIKMOLN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x34D55F0", Offset = "0x34D47F0", VA = "0x1834D55F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x34D5190", Offset = "0x34D4390", VA = "0x1834D5190", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x34D56C0", Offset = "0x34D48C0", VA = "0x1834D56C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x34D5710", Offset = "0x34D4910", VA = "0x1834D5710")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x34D5560", Offset = "0x34D4760", VA = "0x1834D5560", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x34D54C0", Offset = "0x34D46C0", VA = "0x1834D54C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x34D54C0", Offset = "0x34D46C0", VA = "0x1834D54C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2696F60", Offset = "0x2696160", VA = "0x182696F60")]
		public static Entity CKDNABOIKGC(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2697F50", Offset = "0x2697150", VA = "0x182697F50")]
		public static DynamicBuffer<ChildrenData> MJHIOHMPKGI(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2697250", Offset = "0x2696450", VA = "0x182697250")]
		public static DynamicBuffer<ChildrenData> FMHCMILPPKM(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2698300", Offset = "0x2697500", VA = "0x182698300")]
		public static NativeArray<Entity> ONIOEOOMOEB(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Allocator HCEMBCPANJM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2697820", Offset = "0x2696A20", VA = "0x182697820")]
		public static bool IKLDADCJBIC(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Allocator HCEMBCPANJM, out NativeArray<Entity> EKNFAFMNDDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2697FE0", Offset = "0x26971E0", VA = "0x182697FE0")]
		public static NativeArray<Entity> MMMJLFADMNA(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2697AE0", Offset = "0x2696CE0", VA = "0x182697AE0")]
		public static Entity LADEPLKBNAJ(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, int GMEHLIHLGEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2697710", Offset = "0x2696910", VA = "0x182697710")]
		public static int IDHBDBMGFID(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2697CF0", Offset = "0x2696EF0", VA = "0x182697CF0")]
		public static void MDFGCKNNGAN(NativeArray<Entity> BDDHHHHDEKA, NativeArray<Entity> OKKDPEMOHMC, EntityManager IIODDCGHDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2697A30", Offset = "0x2696C30", VA = "0x182697A30")]
		public static int KEKDDJCJCIL(this EntityManager IIODDCGHDHF, Entity HHFDFFDPCGO, Entity AAFNLLCIFBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2696BF0", Offset = "0x2695DF0", VA = "0x182696BF0")]
		public static bool BAPHEPNKIJH(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Entity MIONKFPACCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2697920", Offset = "0x2696B20", VA = "0x182697920")]
		public static IEnumerable<Entity> JENDCCHGJCA(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x26981D0", Offset = "0x26973D0", VA = "0x1826981D0")]
		public static bool MPHHNPLLNHA(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Entity AAFNLLCIFBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2698280", Offset = "0x2697480", VA = "0x182698280")]
		public static bool NLKLELJEKDK(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Entity IHEBNKKPFLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2696D50", Offset = "0x2695F50", VA = "0x182696D50")]
		public static NativeList<Entity> CBLOBJPOGKK(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, bool FILPHNKNPEK = false, Allocator HCEMBCPANJM = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x26970D0", Offset = "0x26962D0", VA = "0x1826970D0")]
		public static IEnumerable<Entity> FHNKAIJGLGA(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2696FD0", Offset = "0x26961D0", VA = "0x182696FD0")]
		public static Entity DMOICBPEOLI(this EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2697370", Offset = "0x2696570", VA = "0x182697370")]
		public static bool GDHBJPCNPAN(this EntityManager IIODDCGHDHF, Entity IHEBNKKPFLJ, Entity NBOGDLHPFJC, out Entity LCFGMFPMPCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2697510", Offset = "0x2696710", VA = "0x182697510")]
		internal static void GEOJHFDDLNO(EntityManager IIODDCGHDHF, Entity HHFDFFDPCGO, Entity AAFNLLCIFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2697610", Offset = "0x2696810", VA = "0x182697610")]
		internal static void GOBFBKNMBFA(EntityManager IIODDCGHDHF, Entity HHFDFFDPCGO, Entity AAFNLLCIFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2698140", Offset = "0x2697340", VA = "0x182698140")]
		[IteratorStateMachine(typeof(EPIHHIFIPKK))]
		private static IEnumerable<Entity> MOFMPNGJAMJ(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x26972E0", Offset = "0x26964E0", VA = "0x1826972E0")]
		[IteratorStateMachine(typeof(HEOMAHGLEND))]
		private static IEnumerable<Entity> FNONDLKFOIJ(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x2697590", Offset = "0x2696790", VA = "0x182697590")]
		[IteratorStateMachine(typeof(IODKCIKMOLN))]
		private static IEnumerable<Entity> GNMAFLGKCHK(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2697C10", Offset = "0x2696E10", VA = "0x182697C10")]
		private static bool MBOIEMADMBC(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Entity MIONKFPACCE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[PNCLNBNALEO(typeof(LHKILEMFMKD), new string[] { })]
public class PKLOIJFFHMI : LHKILEMFMKD, FGPHKGGABON, AFECAIPELEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private BLBDINABANB LBBJCIBEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private AEOPHBOKNJI JOIEBCBPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private LKANKDBMEPH OPMONFEOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private GBMEAEPJCNJ HKPONLMBIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private EFDNEMMCCPM EDPIJECELAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private KNMAKEFNGNA MAHBIJBCNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private FGBFDIFKLHF OPKKHHNDKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private BPDDKPBGCMN BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private IKAKIKODLMN BNMEMGGGGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private MPKKBBECOPF IKCCBFMDLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private CNBEKDOCLNI KLPFPLFLOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private IDEMJNMNAMN CMCOGOFJIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private AMOFKKLJHLA HAFAFPNKHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private MBILFEPAMHC AGOMPJDPMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private DGBAPALLGDE MPLIANHHNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private EINBFFEIBHO HCGOHCHGOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private OCPAEOMCMPM BOGCPPKKDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private APGPGBLMNNP EHHPLBPDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BLBDINABANB EOEDHGLEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MLOAKDLKONO KNPHKPIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public DGHIBPMIJHM JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public AEOPHBOKNJI IGBFCBOHCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public LKANKDBMEPH MNNCAPCBMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public GBMEAEPJCNJ ILLFGBFMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EFDNEMMCCPM OMBLPNIMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KNMAKEFNGNA EDPPCONEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7A7A90", Offset = "0x7A6C90", VA = "0x1807A7A90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public FGBFDIFKLHF KAEOKEDFJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8532C0", Offset = "0x8524C0", VA = "0x1808532C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BPDDKPBGCMN IGAEILAANOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IKAKIKODLMN KGNKAEJHADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public MPKKBBECOPF PLAPCFBIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x9AD0E0", Offset = "0x9AC2E0", VA = "0x1809AD0E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public CNBEKDOCLNI NCJCMAENIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA60CF0", Offset = "0xA5FEF0", VA = "0x180A60CF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IDEMJNMNAMN PGOMDBENJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xAD6180", Offset = "0xAD5380", VA = "0x180AD6180", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public AMOFKKLJHLA HHDJKMFNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x91E5A0", Offset = "0x91D7A0", VA = "0x18091E5A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public MBILFEPAMHC HKMHLHOIPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x82B680", Offset = "0x82A880", VA = "0x18082B680", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public DGBAPALLGDE JFLMOMMCBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x91EA50", Offset = "0x91DC50", VA = "0x18091EA50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public EINBFFEIBHO OHKONPJMECE
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x91EBE0", Offset = "0x91DDE0", VA = "0x18091EBE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public OCPAEOMCMPM CDMBEMGJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6F9880", Offset = "0x6F8A80", VA = "0x1806F9880", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public APGPGBLMNNP MBNJPHPBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x91EBD0", Offset = "0x91DDD0", VA = "0x18091EBD0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public DDILJKOPKGP IAJLHNJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7A7AA0", Offset = "0x7A6CA0", VA = "0x1807A7AA0", Slot = "21")]
		get
		{
			return default(DDILJKOPKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2B01B40", Offset = "0x2B00D40", VA = "0x182B01B40", Slot = "22")]
	public void OLHDANNJCMN(BLBDINABANB LBPEEFBDHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x17968F0", Offset = "0x1795AF0", VA = "0x1817968F0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2B01B20", Offset = "0x2B00D20", VA = "0x182B01B20", Slot = "23")]
	public void FKGJCGANBPC(BLBDINABANB LBPEEFBDHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public PKLOIJFFHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class LLKHDMKPMDM : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OJIGGCCBMML : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public LLKHDMKPMDM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34DB160", Offset = "0x34DA360", VA = "0x1834DB160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
		[DebuggerHidden]
		public OJIGGCCBMML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x34DAFB0", Offset = "0x34DA1B0", VA = "0x1834DAFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x34DB120", Offset = "0x34DA320", VA = "0x1834DB120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong JGNKCAOMOPE = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong KGFICNILDGL = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int OLKBPBDDDEF = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int FHAAHIFMFMH = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int KIGEJJCPMDB = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int CCCBNEPNAAE = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> DFLMOPOGPOK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBF0", Offset = "0x7DDDF0", VA = "0x1807DEBF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x908F90", Offset = "0x908190", VA = "0x180908F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int MLENCCMNDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7DECC0", Offset = "0x7DDEC0", VA = "0x1807DECC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D20", Offset = "0x9F2F20", VA = "0x1809F3D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEA40", Offset = "0x2AEDC40", VA = "0x182AEEA40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE010", Offset = "0x2AED210", VA = "0x182AEE010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEED20", Offset = "0x2AEDF20", VA = "0x182AEED20")]
	public LLKHDMKPMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEBE0", Offset = "0x2AEDDE0", VA = "0x182AEEBE0")]
	public LLKHDMKPMDM(int OILBNELDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7E0", Offset = "0x2AED9E0", VA = "0x182AEE7E0")]
	public bool MDNCOEPCNGK(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE410", Offset = "0x2AED610", VA = "0x182AEE410")]
	public bool GFKBBGHKBLE(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE390", Offset = "0x2AED590", VA = "0x182AEE390")]
	public bool EOEEJDBLBCB(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEAE0", Offset = "0x2AEDCE0", VA = "0x182AEEAE0")]
	public bool PJAJGNFHPGD(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE300", Offset = "0x2AED500", VA = "0x182AEE300")]
	public void DDLACLEOONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE8C0", Offset = "0x2AEDAC0", VA = "0x182AEE8C0")]
	public void MPIICMDKGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEAF0", Offset = "0x2AEDCF0", VA = "0x182AEEAF0")]
	public void PLCAKFAMFIL(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE500", Offset = "0x2AED700", VA = "0x182AEE500")]
	public void GLBPPAIACJF(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE9B0", Offset = "0x2AEDBB0", VA = "0x182AEE9B0")]
	public bool NJBMNLOLIEJ(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE6C0", Offset = "0x2AED8C0", VA = "0x182AEE6C0")]
	public void IJPBMNFEJFM(int MOHMCFDNHKH, int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDE50", Offset = "0x2AED050", VA = "0x182AEDE50")]
	public void ALHCDJOIIGA(int PGGPDMLNFLP, int FKGDJKOLCNN, int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE230", Offset = "0x2AED430", VA = "0x182AEE230")]
	public int CPCILMEHKPA(int BFFJHKFEFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE1C0", Offset = "0x2AED3C0", VA = "0x182AEE1C0")]
	public int CPCILMEHKPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE600", Offset = "0x2AED800", VA = "0x182AEE600")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE650", Offset = "0x2AED850", VA = "0x182AEE650", Slot = "4")]
	[IteratorStateMachine(typeof(OJIGGCCBMML))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE650", Offset = "0x2AED850", VA = "0x182AEE650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class GNBLNDJCNJI<T> : global::DMMLMEIOKGD<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::DDCALLONOAG<T> KIKLHFEKHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::BOMFKHNNBPB<T> EOAFKONFEGL;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891230", VA = "0x180892030")]
	public GNBLNDJCNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x23BAB30", Offset = "0x23B9D30", VA = "0x1823BAB30")]
	public GNBLNDJCNJI(global::DDCALLONOAG<T> KIKLHFEKHND, global::BOMFKHNNBPB<T> EOAFKONFEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x23BA4E0", Offset = "0x23B96E0", VA = "0x1823BA4E0", Slot = "11")]
	public override T BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x23BA780", Offset = "0x23B9980", VA = "0x1823BA780", Slot = "12")]
	public override void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, T IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class PBHNLLCIFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x2E88820", Offset = "0x2E87A20", VA = "0x182E88820")]
	public static GFCMOFDOMMJ BNAKCAAHHPA<T>(this COBIKEAKJLB BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN, global::DDCALLONOAG<T> KIKLHFEKHND, global::BOMFKHNNBPB<T> EOAFKONFEGL) where T : struct
	{
		return default(GFCMOFDOMMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class GDHIFKIFOHA<T> : global::GNBLNDJCNJI<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE8200", Offset = "0x2FE7400", VA = "0x182FE8200")]
	public GDHIFKIFOHA(T IFPPBNLHCCM, T LIODLDNGDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class IIGKHGDJLEG<T> : global::DMMLMEIOKGD<T> where T : struct, LLPAFDMOEEL
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x1B2E570", Offset = "0x1B2D770", VA = "0x181B2E570", Slot = "11")]
	public override T BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x1B2E5B0", Offset = "0x1B2D7B0", VA = "0x181B2E5B0", Slot = "12")]
	public override void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xD75B50", Offset = "0xD74D50", VA = "0x180D75B50")]
	public IIGKHGDJLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class AKLLLPCNPFA : DHDBPBONHFF
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type CDGKEOJOFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM, in OANIPIMDODC IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, in NFKEKJGDLJI IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LGHFLJJPKHF(LGCEMMAIGML ALCBODINOLM, GOCGCCCLMFN MPAPMLANIKB, [Optional] object DELCOFCGDFF);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected AKLLLPCNPFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class DMMLMEIOKGD<T> : AKLLLPCNPFA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type CDGKEOJOFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x23C7200", Offset = "0x23C6400", VA = "0x1823C7200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, T IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x23C63C0", Offset = "0x23C55C0", VA = "0x1823C63C0", Slot = "8")]
	public override void BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM, in OANIPIMDODC GFCPAMJILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x23C75D0", Offset = "0x23C67D0", VA = "0x1823C75D0", Slot = "9")]
	public override void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, in NFKEKJGDLJI GLLFHCCFIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x23C85B0", Offset = "0x23C77B0", VA = "0x1823C85B0", Slot = "10")]
	public override void LGHFLJJPKHF(LGCEMMAIGML ALCBODINOLM, GOCGCCCLMFN MPAPMLANIKB, object DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20")]
	protected DMMLMEIOKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class FMDKCNOECGC
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class AEEDKAMCPEB
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class AFOBDFNOHJJ<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
			public AFOBDFNOHJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x29EE3A0", Offset = "0x29ED5A0", VA = "0x1829EE3A0")]
			internal void <RegisterFixedString>b__0(LGCEMMAIGML p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x29EE610", Offset = "0x29ED810", VA = "0x1829EE610")]
			internal T <RegisterFixedString>b__1(LGCEMMAIGML p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x34CDDE0", Offset = "0x34CCFE0", VA = "0x1834CDDE0")]
		public static void PHHBBKPJFKC(JEGHHJOPNCP LBBGMEJFNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x223B860", Offset = "0x223AA60", VA = "0x18223B860")]
		private static void EHODINBFEDJ<T>(JEGHHJOPNCP LBBGMEJFNPF, int LIODLDNGDIO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x223BFD0", Offset = "0x223B1D0", VA = "0x18223BFD0")]
		private static void JOPCOAAPPDH<T>(LGCEMMAIGML COLMAMKJPJE, T MLIPDLAHDHI, int LIODLDNGDIO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x223B980", Offset = "0x223AB80", VA = "0x18223B980")]
		private static T GBFGFJPOJNB<T>(LGCEMMAIGML COLMAMKJPJE, int LIODLDNGDIO) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public AEEDKAMCPEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class JJJNNDHKBDE : FIPOBOKEIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private JEGHHJOPNCP LBBGMEJFNPF;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x224F680", Offset = "0x224E880", VA = "0x18224F680", Slot = "6")]
		public override void EIGMPJHOEIH<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x34D5A60", Offset = "0x34D4C60", VA = "0x1834D5A60")]
		public static void PDBLBDDCIJF(JEGHHJOPNCP LBBGMEJFNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x34D5B10", Offset = "0x34D4D10", VA = "0x1834D5B10")]
		public JJJNNDHKBDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2699B40", Offset = "0x2698D40", VA = "0x182699B40")]
	public static void BBKMNGJDDJM(JEGHHJOPNCP LBBGMEJFNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x1499910", Offset = "0x1498B10", VA = "0x181499910")]
	public static void MKMLOAFLOHD<T>(JEGHHJOPNCP LBBGMEJFNPF, global::DDCALLONOAG<T> KIKLHFEKHND, global::BOMFKHNNBPB<T> EOAFKONFEGL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x14999A0", Offset = "0x1498BA0", VA = "0x1814999A0")]
	public static void MMEECBGEBKD<T>(JEGHHJOPNCP CMCBBMOIFHP) where T : struct, LLPAFDMOEEL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface JEGHHJOPNCP : global::LABIJAEFOFO<JEGHHJOPNCP>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNAKCAAHHPA(Type NIFOGEBEDNG, DHDBPBONHFF CMCBBMOIFHP);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IJDPOKFHBJA(Type NIFOGEBEDNG, out DHDBPBONHFF CMCBBMOIFHP);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class BKMKBGBMKKO
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3670", Offset = "0x2AA2870", VA = "0x182AA3670")]
	public static void BNAKCAAHHPA(this JEGHHJOPNCP BDIJLBAAEHA, DHDBPBONHFF CMCBBMOIFHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[PNCLNBNALEO(typeof(COBIKEAKJLB), new string[] { })]
public sealed class NOENJDILPCO : COBIKEAKJLB, global::LABIJAEFOFO<COBIKEAKJLB>, IMFHGBIDMMC, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<GFCMOFDOMMJ, DHDBPBONHFF> LBBGMEJFNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private JEGHHJOPNCP HKBFELOIFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private CCAADMLFLBF BBBOEOJJCHM;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool HBOJIJEAIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xAD84D0", Offset = "0xAD76D0", VA = "0x180AD84D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7B00", VA = "0x180AD8900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AF37F0", Offset = "0x2AF29F0", VA = "0x182AF37F0")]
	public NOENJDILPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3730", Offset = "0x2AF2930", VA = "0x182AF3730")]
	public NOENJDILPCO(Dictionary<GFCMOFDOMMJ, DHDBPBONHFF> LBBGMEJFNPF, bool FPMMCIINOGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3160", Offset = "0x2AF2360", VA = "0x182AF3160", Slot = "7")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF35D0", Offset = "0x2AF27D0", VA = "0x182AF35D0", Slot = "8")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AF31C0", Offset = "0x2AF23C0", VA = "0x182AF31C0", Slot = "9")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3210", Offset = "0x2AF2410", VA = "0x182AF3210", Slot = "4")]
	public GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ KNOPFGAGMCN)
	{
		return default(GFCMOFDOMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2FF0", Offset = "0x2AF21F0", VA = "0x182AF2FF0", Slot = "5")]
	public void BNAKCAAHHPA(GFCMOFDOMMJ IKHNIJKGJFD, DHDBPBONHFF CMCBBMOIFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3490", Offset = "0x2AF2690", VA = "0x182AF3490")]
	[Conditional("DEBUG_BUILD")]
	private void NJCDKELCBHA(GFCMOFDOMMJ IKHNIJKGJFD, Type NIFOGEBEDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AF32E0", Offset = "0x2AF24E0", VA = "0x182AF32E0", Slot = "6")]
	public bool IJDPOKFHBJA(GFCMOFDOMMJ IKHNIJKGJFD, out DHDBPBONHFF CMCBBMOIFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3650", Offset = "0x2AF2850", VA = "0x182AF3650", Slot = "10")]
	public COBIKEAKJLB PLNNNEBOBNE()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[PNCLNBNALEO(typeof(JEGHHJOPNCP), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.TypeSerializer)]
	public sealed class TypeSerializerService : IMFHGBIDMMC, JEGHHJOPNCP, global::LABIJAEFOFO<JEGHHJOPNCP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, DHDBPBONHFF> LBBGMEJFNPF;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool HBOJIJEAIJL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x7E47C0", Offset = "0x7E39C0", VA = "0x1807E47C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x27145E0", Offset = "0x27137E0", VA = "0x1827145E0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2714520", Offset = "0x2713720", VA = "0x182714520")]
		public TypeSerializerService(Dictionary<Type, DHDBPBONHFF> LBBGMEJFNPF, bool FPMMCIINOGB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x27142B0", Offset = "0x27134B0", VA = "0x1827142B0", Slot = "4")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2714190", Offset = "0x2713390", VA = "0x182714190", Slot = "5")]
		public void BNAKCAAHHPA(Type NIFOGEBEDNG, DHDBPBONHFF CMCBBMOIFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2714310", Offset = "0x2713510", VA = "0x182714310", Slot = "6")]
		public bool IJDPOKFHBJA(Type NIFOGEBEDNG, out DHDBPBONHFF CMCBBMOIFHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x27143F0", Offset = "0x27135F0", VA = "0x1827143F0", Slot = "7")]
		public JEGHHJOPNCP PLNNNEBOBNE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[PNCLNBNALEO(typeof(CKPGAFBPNIH), new string[] { })]
internal sealed class BLDFDHDDLKL : CKPGAFBPNIH, IMFHGBIDMMC, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<GFCMOFDOMMJ, ECJHBFPIFBA> IDNBICIMFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private CCAADMLFLBF BBBOEOJJCHM;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA37E0", Offset = "0x2AA29E0", VA = "0x182AA37E0", Slot = "6")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A90", Offset = "0x2AA2C90", VA = "0x182AA3A90", Slot = "7")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3770", Offset = "0x2AA2970", VA = "0x182AA3770", Slot = "4")]
	public void BNAKCAAHHPA(GFCMOFDOMMJ CHIEJFHOPDP, Type JLKBHACBDKM, ECJHBFPIFBA IJOOBFMHDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3A20", Offset = "0x2AA2C20", VA = "0x182AA3A20", Slot = "5")]
	public bool NJJBAMDMMFJ(GFCMOFDOMMJ CHIEJFHOPDP, out ECJHBFPIFBA IJOOBFMHDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3830", Offset = "0x2AA2A30", VA = "0x182AA3830")]
	[Conditional("DEBUG_BUILD")]
	private void HKJGLDDEPEL(GFCMOFDOMMJ CHIEJFHOPDP, Type JLKBHACBDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3AF0", Offset = "0x2AA2CF0", VA = "0x182AA3AF0")]
	public BLDFDHDDLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[PNCLNBNALEO(typeof(BCHEBEJHIBE), new string[] { })]
internal sealed class CPMHHCKNLHC : BCHEBEJHIBE, BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly LLKHDMKPMDM GBHICEMDPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<HCIIHJLICJK, int> BIFGAKCHHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> FNLHHAHKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[GAJFPHPAPMA]
	private CCAADMLFLBF BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[GAJFPHPAPMA]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int IBLINHKDMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A80", Offset = "0x2AA6C80", VA = "0x182AA7A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool OKNMIKICIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4980", Offset = "0x7B3B80", VA = "0x1807B4980", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4840", Offset = "0x7B3A40", VA = "0x1807B4840", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7970", Offset = "0x2AA6B70", VA = "0x182AA7970", Slot = "6")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7DB0", Offset = "0x2AA6FB0", VA = "0x182AA7DB0", Slot = "7")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7820", Offset = "0x2AA6A20", VA = "0x182AA7820", Slot = "8")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA78D0", Offset = "0x2AA6AD0", VA = "0x182AA78D0")]
	private void AHFIHODDJIM(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7CF0", Offset = "0x2AA6EF0", VA = "0x182AA7CF0", Slot = "4")]
	public bool NJLIAMIICOC(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7AD0", Offset = "0x2AA6CD0", VA = "0x182AA7AD0", Slot = "5")]
	public void LPCBHIOIPOJ(HCIIHJLICJK MIBPNJCOIHL, Span<GFCMOFDOMMJ> BBBOEOJJCHM, bool LJAANIMCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7970", Offset = "0x2AA6B70", VA = "0x182AA7970", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E30", Offset = "0x2AA7030", VA = "0x182AA7E30")]
	public CPMHHCKNLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class MIMJKGBLFFE
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFE50", Offset = "0x2AEF050", VA = "0x182AEFE50")]
	public static void OJJBAODGCHA(this LGCEMMAIGML ALCBODINOLM, ReadOnlyMemory<byte> HPBIAPIHFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x13B83B0", Offset = "0x13B75B0", VA = "0x1813B83B0")]
	public static void DNHNFLEJEFG<T>(this LGCEMMAIGML ALCBODINOLM, in T IPMIIEAGJKC) where T : struct, LLPAFDMOEEL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x13B84E0", Offset = "0x13B76E0", VA = "0x1813B84E0")]
	public static T HHHAJKMMHIK<T>(this LGCEMMAIGML ALCBODINOLM) where T : struct, LLPAFDMOEEL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFCD0", Offset = "0x2AEEED0", VA = "0x182AEFCD0")]
	public static void DNHNFLEJEFG(this LGCEMMAIGML ALCBODINOLM, AKNLEMIGMCN GOCHJIMGLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFD00", Offset = "0x2AEEF00", VA = "0x182AEFD00")]
	public static AKNLEMIGMCN KMPAFCFGHEF(this LGCEMMAIGML ALCBODINOLM)
	{
		return default(AKNLEMIGMCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFED0", Offset = "0x2AEF0D0", VA = "0x182AEFED0")]
	public static void PBCFKBMLGKD(this LGCEMMAIGML KOODAEDNKIK, uint JKFFFEJEKFE, bool HICAPJPGPDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFD30", Offset = "0x2AEEF30", VA = "0x182AEFD30")]
	public static uint LEEJDPEBLKI(this LGCEMMAIGML EFKJIOEDNFB, bool HICAPJPGPDM = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class EDBHDNPNFOI
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class OJLFMPOHEMN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public OJLFMPOHEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x202FC20", Offset = "0x202EE20", VA = "0x18202FC20")]
		internal void <GetByteEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x202FC90", Offset = "0x202EE90", VA = "0x18202FC90")]
		internal T <GetByteEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class KODHEBNAHJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public KODHEBNAHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A8B0", Offset = "0x2D99AB0", VA = "0x182D9A8B0")]
		internal void <GetSByteEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9A920", Offset = "0x2D99B20", VA = "0x182D9A920")]
		internal T <GetSByteEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class NGFLGCIBCEJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public NGFLGCIBCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x27774A0", Offset = "0x27766A0", VA = "0x1827774A0")]
		internal void <GetShortEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2777510", Offset = "0x2776710", VA = "0x182777510")]
		internal T <GetShortEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class HMKCHHPNBIF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public HMKCHHPNBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C75360", Offset = "0x2C74560", VA = "0x182C75360")]
		internal void <GetUShortEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C753D0", Offset = "0x2C745D0", VA = "0x182C753D0")]
		internal T <GetUShortEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class CANJELPELHL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public CANJELPELHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F69D60", Offset = "0x3F68F60", VA = "0x183F69D60")]
		internal void <GetIntEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x3F69DC0", Offset = "0x3F68FC0", VA = "0x183F69DC0")]
		internal T <GetIntEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class LCOJBEADIJB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public LCOJBEADIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3B00", Offset = "0x3BE2D00", VA = "0x183BE3B00")]
		internal void <GetUIntEnumDelegates>b__0(LGCEMMAIGML b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3B60", Offset = "0x3BE2D60", VA = "0x183BE3B60")]
		internal T <GetUIntEnumDelegates>b__1(LGCEMMAIGML b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D26370", Offset = "0x1D25570", VA = "0x181D26370")]
	public static void LKLICBILBLF<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D25F80", Offset = "0x1D25180", VA = "0x181D25F80")]
	private static void ABPCBJBJFPL<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D25F80", Offset = "0x1D25180", VA = "0x181D25F80")]
	private static void PABDOIKHPDC<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D26220", Offset = "0x1D25420", VA = "0x181D26220")]
	private static void AOKMFOFOACB<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D26220", Offset = "0x1D25420", VA = "0x181D26220")]
	private static void PAMEAAMDGAK<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D260D0", Offset = "0x1D252D0", VA = "0x181D260D0")]
	private static void IHPCJLKOABI<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D260D0", Offset = "0x1D252D0", VA = "0x181D260D0")]
	private static void AMIPEAKPKIA<T>(T IFPPBNLHCCM, T LIODLDNGDIO, out global::DDCALLONOAG<T> EPLBNAKEKPL, out global::BOMFKHNNBPB<T> FKBCHBJJJLK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class KLAKDBICBKK : CGCIGFDONLA, BDLDACMOPAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x26AF260", Offset = "0x26AE460", VA = "0x1826AF260", Slot = "4")]
	private void PDEEABJLNKO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PAMLMAOGALE(COBIKEAKJLB BBBOEOJJCHM);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	protected KLAKDBICBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[DEABIHNCNIC(typeof(LocalPoseData))]
public sealed class POIGNGAEPOL : KLAKDBICBKK
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2B03680", Offset = "0x2B02880", VA = "0x182B03680", Slot = "5")]
	protected override void PAMLMAOGALE(COBIKEAKJLB BBBOEOJJCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public POIGNGAEPOL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class CopyAuthorityToEntity : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery BBFFIDPIKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery OHCNCHBJJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery PFIMNLNCAFF;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0620", Offset = "0x2AAF820", VA = "0x182AB0620", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0460", Offset = "0x2AAF660", VA = "0x182AB0460", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB05E0", Offset = "0x2AAF7E0", VA = "0x182AB05E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB05B0", Offset = "0x2AAF7B0", VA = "0x182AB05B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFC90", Offset = "0x2AAEE90", VA = "0x182AAFC90")]
		private void FBLFGPJMGMG(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB00B0", Offset = "0x2AAF2B0", VA = "0x182AB00B0")]
		private void NAENGPIOPAH(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF800", Offset = "0x2AAEA00", VA = "0x182AAF800")]
		private void BOOAFLNIECF(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFAE0", Offset = "0x2AAECE0", VA = "0x182AAFAE0")]
		private void ELMHDOKICPG(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0250", Offset = "0x2AAF450", VA = "0x182AB0250")]
		private void NMMNKCNFAAE(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFFD0", Offset = "0x2AAF1D0", VA = "0x182AAFFD0")]
		private void KNIGJMPOALK(HPHBHAKAACD EHNNHDBEJOG, int PCKCPNGPNBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class NLPEEOHPBMI : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1CF0", Offset = "0x2AF0EF0", VA = "0x182AF1CF0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1860", Offset = "0x2AF0A60", VA = "0x182AF1860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1920", Offset = "0x2AF0B20", VA = "0x182AF1920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1280", Offset = "0x2AF0480", VA = "0x182AF1280")]
	private void CKKEGHHJCMF(NativeArray<Entity> EJIAHCPIPFJ, NativeList<Entity> HAGNIOBGLCF, ComponentDataFromEntity<EHLHABPDOKG> JLIKIHFEHLO, BufferFromEntity<ChildrenData> OHHDFNNNBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public NLPEEOHPBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class CEAECPKJFKK : ParentSystemBase<AuthoredParentData, KBMOAFKGKDP, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA67C0", Offset = "0x2AA59C0", VA = "0x182AA67C0", Slot = "14")]
	protected override EntityQueryDesc ACIKKGMNINI(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "15")]
	protected override EntityQueryDesc IOLHLOAGBGO(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6800", Offset = "0x2AA5A00", VA = "0x182AA6800", Slot = "16")]
	protected override EntityQueryDesc NHPIDPMMCIA(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6840", Offset = "0x2AA5A40", VA = "0x182AA6840", Slot = "17")]
	protected override EntityQueryDesc NPNAKCFPEPP(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2AA68C0", Offset = "0x2AA5AC0", VA = "0x182AA68C0")]
	public CEAECPKJFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6880", Offset = "0x2AA5A80", VA = "0x182AA6880", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class GIIILDBGLDE : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object KAELNFJDBFL;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x269DBA0", Offset = "0x269CDA0", VA = "0x18269DBA0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x269D880", Offset = "0x269CA80", VA = "0x18269D880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x269D920", Offset = "0x269CB20", VA = "0x18269D920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public GIIILDBGLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class CFCDKCPCIIK : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object KAELNFJDBFL;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6C20", Offset = "0x2AA5E20", VA = "0x182AA6C20", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6900", Offset = "0x2AA5B00", VA = "0x182AA6900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA69A0", Offset = "0x2AA5BA0", VA = "0x182AA69A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public CFCDKCPCIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct DJAMOOHIFAL : ISystemStateBufferElementData, IBufferElementData, IEquatable<DJAMOOHIFAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public HKFKNNJOKKH PLFCHHKILCM;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5E40", Offset = "0x2AB5040", VA = "0x182AB5E40", Slot = "4")]
	public bool Equals(DJAMOOHIFAL HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static DJAMOOHIFAL GJGPFJHFLAE(HKFKNNJOKKH PLFCHHKILCM)
	{
		return default(DJAMOOHIFAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct DLMCGENEBNE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public HKFKNNJOKKH PLFCHHKILCM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static DLMCGENEBNE GJGPFJHFLAE(HKFKNNJOKKH PLFCHHKILCM)
	{
		return default(DLMCGENEBNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class LPFBGKHDCEB : PLHKNLIFFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEDA0", Offset = "0x2AEDFA0", VA = "0x182AEEDA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEF30", Offset = "0x2AEE130", VA = "0x182AEEF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	protected LPFBGKHDCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[LJPJOHADJCO]
internal abstract class PLHKNLIFFMO : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected APGPGBLMNNP EHHPLBPDKBE;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2B03610", Offset = "0x2B02810", VA = "0x182B03610", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2B03110", Offset = "0x2B02310", VA = "0x182B03110")]
	protected void MLEHHOEAFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2B03390", Offset = "0x2B02590", VA = "0x182B03390")]
	protected void OEGHBOHOBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2B030A0", Offset = "0x2B022A0", VA = "0x182B030A0")]
	protected GNFJJEDLPLM ACHEJJNOGBJ()
	{
		return default(GNFJJEDLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	protected PLHKNLIFFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class AFHKNANOLOP : PLHKNLIFFMO
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F7D0", Offset = "0x2A9E9D0", VA = "0x182A9F7D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F960", Offset = "0x2A9EB60", VA = "0x182A9F960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x26AF460", Offset = "0x26AE660", VA = "0x1826AF460")]
	protected AFHKNANOLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class KLEGBCKMPMI : PLHKNLIFFMO
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x26AF2C0", Offset = "0x26AE4C0", VA = "0x1826AF2C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x26AF3D0", Offset = "0x26AE5D0", VA = "0x1826AF3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x26AF460", Offset = "0x26AE660", VA = "0x1826AF460")]
	protected KLEGBCKMPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class PLEEBOJMNBF : LPFBGKHDCEB
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B020D0", Offset = "0x2B012D0", VA = "0x182B020D0", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public PLEEBOJMNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class LBLHDMLKADI : AFHKNANOLOP
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x26B1780", Offset = "0x26B0980", VA = "0x1826B1780", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x26AF250", Offset = "0x26AE450", VA = "0x1826AF250")]
	public LBLHDMLKADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class OEOFIMALBJE : KLEGBCKMPMI
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4150", Offset = "0x2AF3350", VA = "0x182AF4150", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x26AF250", Offset = "0x26AE450", VA = "0x1826AF250")]
	public OEOFIMALBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class CCOJBJDJCGD : LPFBGKHDCEB
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6360", Offset = "0x2AA5560", VA = "0x182AA6360", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x26AF460", Offset = "0x26AE660", VA = "0x1826AF460")]
	public CCOJBJDJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class KKEMJIMPGJM : AFHKNANOLOP
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x26AF1E0", Offset = "0x26AE3E0", VA = "0x1826AF1E0", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x26AF250", Offset = "0x26AE450", VA = "0x1826AF250")]
	public KKEMJIMPGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class DKHDAMMFNME : KLEGBCKMPMI
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override NKNMEFJJCKN DFFGLFMJPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5F20", Offset = "0x2AB5120", VA = "0x182AB5F20", Slot = "15")]
		get
		{
			return default(NKNMEFJJCKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x26AF250", Offset = "0x26AE450", VA = "0x1826AF250")]
	public DKHDAMMFNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct PFMOOACHDMP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct ENIDMDIMNNA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct FLMFJMMOJFA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct NKNMEFJJCKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType AEOCFALMHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType AHNIMJDLOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object IALNODEHBNN;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1220", Offset = "0x2AF0420", VA = "0x182AF1220")]
	public NKNMEFJJCKN(ComponentType AEOCFALMHIC, ComponentType AHNIMJDLOPB, object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x1C7F630", Offset = "0x1C7E830", VA = "0x181C7F630")]
	public static NKNMEFJJCKN IAFIDDAPMCG<TReq, TTag>(object IALNODEHBNN)
	{
		return default(NKNMEFJJCKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class CCDOODOAPPJ
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string LOBICPMHPNE = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string LJOAABDBBHO = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly NKNMEFJJCKN JFLMOMMCBMN;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly NKNMEFJJCKN JBPNNMMJHIB;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct HKFKNNJOKKH : global::ECNPNPKOHHG<HKFKNNJOKKH>, ONMCCIDPEOK, IEquatable<HKFKNNJOKKH>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x26A1650", Offset = "0x26A0850", VA = "0x1826A1650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x26A1690", Offset = "0x26A0890", VA = "0x1826A1690", Slot = "8")]
	public bool Equals(HKFKNNJOKKH HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x26A16E0", Offset = "0x26A08E0", VA = "0x1826A16E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[LJPJOHADJCO]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Connectables)]
	public class UpdateConnectableVisuals : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct EFLIOEPBLAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public HKFKNNJOKKH PLFCHHKILCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 INLGLHIPOMC;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x34D0B70", Offset = "0x34CFD70", VA = "0x1834D0B70")]
			public EFLIOEPBLAG(HKFKNNJOKKH PLFCHHKILCM, float3 INLGLHIPOMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x34D0B50", Offset = "0x34CFD50", VA = "0x1834D0B50")]
			public void HABFEFJGGOE(out HKFKNNJOKKH PLFCHHKILCM, out float3 INLGLHIPOMC)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct EAJIHHFFGKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<EFLIOEPBLAG> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
			public EAJIHHFFGKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<DLMCGENEBNE> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct DIIILIGPAJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<EFLIOEPBLAG> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
			public DIIILIGPAJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<DJAMOOHIFAL> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct LHALIPDLHDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<EFLIOEPBLAG> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
			public LHALIPDLHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in HKGHPKHADEF com, in DynamicBuffer<DJAMOOHIFAL> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct NAPHIHDJGJE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct ACLBEPLOPHM
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct OGJOAKDJJMM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NMOBCNFOJAC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<DLMCGENEBNE>.Runtime KKIIFPLJPJE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ABFEPEOEJKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DLMCGENEBNE> NGEOLLMLLJK;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x34CDD60", Offset = "0x34CCF60", VA = "0x1834CDD60")]
				public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x34CDCA0", Offset = "0x34CCEA0", VA = "0x1834CDCA0")]
				public OGJOAKDJJMM CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(OGJOAKDJJMM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals DKDKPIPCMGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<EFLIOEPBLAG> JAAGBDPDCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private ACLBEPLOPHM JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ACLBEPLOPHM.OGJOAKDJJMM* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x34D96F0", Offset = "0x34D88F0", VA = "0x1834D96F0")]
			internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, WorldPoseData JEOGNKACOPK, in DynamicBuffer<DLMCGENEBNE> DADHJJNJEFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x34D9930", Offset = "0x34D8B30", VA = "0x1834D9930", Slot = "5")]
			public void ReadFromDisplayClass(ref EAJIHHFFGKC AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x34D9960", Offset = "0x34D8B60", VA = "0x1834D9960", Slot = "6")]
			public void WriteToDisplayClass(ref EAJIHHFFGKC AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x34D9490", Offset = "0x34D8690", VA = "0x1834D9490", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x34D95B0", Offset = "0x34D87B0", VA = "0x1834D95B0")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref ACLBEPLOPHM.OGJOAKDJJMM CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x34D9570", Offset = "0x34D8770", VA = "0x1834D9570")]
			public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO, ref EAJIHHFFGKC AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x34D9420", Offset = "0x34D8620", VA = "0x1834D9420")]
			public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GOJJOPOMHBC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct DJHAPABIFOC
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct MAHJOONBHJL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NMOBCNFOJAC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<DJAMOOHIFAL>.Runtime KKIIFPLJPJE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ABFEPEOEJKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DJAMOOHIFAL> NGEOLLMLLJK;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x34D0600", Offset = "0x34CF800", VA = "0x1834D0600")]
				public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x34D0560", Offset = "0x34CF760", VA = "0x1834D0560")]
				public MAHJOONBHJL CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(MAHJOONBHJL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<EFLIOEPBLAG> JAAGBDPDCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private DJHAPABIFOC JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DJHAPABIFOC.MAHJOONBHJL* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x34D2F20", Offset = "0x34D2120", VA = "0x1834D2F20")]
			internal void NKAIDNDKJJJ(in WorldPoseData JEOGNKACOPK, in DynamicBuffer<DJAMOOHIFAL> DADHJJNJEFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xE7E610", Offset = "0xE7D810", VA = "0x180E7E610", Slot = "5")]
			public void ReadFromDisplayClass(ref DIIILIGPAJF AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x34D2CE0", Offset = "0x34D1EE0", VA = "0x1834D2CE0", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x34D2E50", Offset = "0x34D2050", VA = "0x1834D2E50")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref DJHAPABIFOC.MAHJOONBHJL CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x34D2DB0", Offset = "0x34D1FB0", VA = "0x1834D2DB0")]
			public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO, ref DIIILIGPAJF AAEEIKBBKHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ALEMKLFKAPK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct MADNKBFKMOL
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct OPIJPLKILPL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NMOBCNFOJAC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<HKGHPKHADEF>.Runtime KAJAOHBAOMG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<DJAMOOHIFAL>.Runtime KKIIFPLJPJE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ABFEPEOEJKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<HKGHPKHADEF> KEGBPCIIFGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DJAMOOHIFAL> NGEOLLMLLJK;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x34D8800", Offset = "0x34D7A00", VA = "0x1834D8800")]
				public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x34D8730", Offset = "0x34D7930", VA = "0x1834D8730")]
				public OPIJPLKILPL CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(OPIJPLKILPL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<EFLIOEPBLAG> JAAGBDPDCIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private MADNKBFKMOL JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe MADNKBFKMOL.OPIJPLKILPL* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x34CE170", Offset = "0x34CD370", VA = "0x1834CE170")]
			internal void NKAIDNDKJJJ(in WorldPoseData JEOGNKACOPK, in HKGHPKHADEF JCPAHDFOLFG, in DynamicBuffer<DJAMOOHIFAL> DADHJJNJEFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xE7E610", Offset = "0xE7D810", VA = "0x180E7E610", Slot = "5")]
			public void ReadFromDisplayClass(ref LHALIPDLHDB AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF90", Offset = "0x34CD190", VA = "0x1834CDF90", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x34CE050", Offset = "0x34CD250", VA = "0x1834CE050")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref MADNKBFKMOL.OPIJPLKILPL CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x34CE010", Offset = "0x34CD210", VA = "0x1834CE010")]
			public void JNNOBNMLOFO(UpdateConnectableVisuals GEIMOJMNBNO, ref LHALIPDLHDB AAEEIKBBKHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery IGPONMPIFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery GHLODFHPCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery FJEKIHEAGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery MIGCOLAPFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery JMLLPPMKHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery FHHLPAFDNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery DLPKFIKGMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery LOAGJMAJDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery GGMJIKEOPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery KJDPJOMNKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::MFEFOKNAOGN<HKFKNNJOKKH, KEEAFCDJANP> CHFJMKKIOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private OCPAEOMCMPM BOGCPPKKDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private CNBEKDOCLNI KLPFPLFLOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private ACCGKJEOBEB BHCCDMJFHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery CDPHBMDHCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker GEMJHPKOFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery OKAFCJPMAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery CNCMNPIKCHH;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int BPIIJGBNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2714C40", Offset = "0x2713E40", VA = "0x182714C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2717250", Offset = "0x2716450", VA = "0x182717250")]
		internal KEEAFCDJANP IOMNBDNKBHN(HKFKNNJOKKH PLFCHHKILCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2718B20", Offset = "0x2717D20", VA = "0x182718B20", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x27185A0", Offset = "0x27177A0", VA = "0x1827185A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2718820", Offset = "0x2717A20", VA = "0x182718820", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x27189B0", Offset = "0x2717BB0", VA = "0x1827189B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x27187E0", Offset = "0x27179E0", VA = "0x1827187E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2717B70", Offset = "0x2716D70", VA = "0x182717B70")]
		private void NDHBJDBBDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2716FD0", Offset = "0x27161D0", VA = "0x182716FD0")]
		private void HKHOHPGGLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2716C20", Offset = "0x2715E20", VA = "0x182716C20")]
		private void HFFIJLDONNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x27189F0", Offset = "0x2717BF0", VA = "0x1827189F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2714F90", Offset = "0x2714190", VA = "0x182714F90")]
		private void CDJHKCNAIKI(EntityQuery BBFFIDPIKDL, EntityQuery FBFLLMKFMDL, EntityQuery OHCNCHBJJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2717A10", Offset = "0x2716C10", VA = "0x182717A10")]
		private void MILDLLFOGOM(EntityQuery OHCNCHBJJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2715AE0", Offset = "0x2714CE0", VA = "0x182715AE0")]
		private void DNOAEEAJBCK(NativeArrayAsync<Entity> DGNHBINPEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2714E80", Offset = "0x2714080", VA = "0x182714E80")]
		private void BPJALOHFLPK(NativeArrayAsync<Entity> KLDDGNMEOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x27161F0", Offset = "0x27153F0", VA = "0x1827161F0")]
		private void FAEKDEEPGMA(NativeArrayAsync<Entity> KMKIHMENMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2717430", Offset = "0x2716630", VA = "0x182717430")]
		private void KOILPAEHHHE(NativeList<HKFKNNJOKKH> OIHODJGCKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2718BE0", Offset = "0x2717DE0", VA = "0x182718BE0")]
		private NativeList<HKFKNNJOKKH> PHDJFEEOFOL(NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(NativeList<HKFKNNJOKKH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2716390", Offset = "0x2715590", VA = "0x182716390")]
		private void FELOPFBIBCJ(NativeArray<Entity> EJIAHCPIPFJ, NativeList<HKFKNNJOKKH> OIHODJGCKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2717C80", Offset = "0x2716E80", VA = "0x182717C80")]
		private void NEEMGKEOBIB(NativeArray<Entity> HNMMMICFHKE, NativeArray<Entity> NLDOCBCLKCC, NativeList<HKFKNNJOKKH> FNLHHAHKLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2715630", Offset = "0x2714830", VA = "0x182715630")]
		private void DNJOBODAGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x27160B0", Offset = "0x27152B0", VA = "0x1827160B0")]
		private NativeListAsync<EFLIOEPBLAG> EOOFIBMKHFI(EntityQuery ADGIOFAMOGF, Func<NativeList<EFLIOEPBLAG>, JobHandle> CMPAIKPMJPK)
		{
			return default(NativeListAsync<EFLIOEPBLAG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x27172A0", Offset = "0x27164A0", VA = "0x1827172A0")]
		private JobHandle KDPNBCKNIBJ(NativeList<EFLIOEPBLAG> JAAGBDPDCIE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x27175A0", Offset = "0x27167A0", VA = "0x1827175A0")]
		private JobHandle LGDEBCGCKIL(NativeList<EFLIOEPBLAG> JAAGBDPDCIE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2717120", Offset = "0x2716320", VA = "0x182717120")]
		private JobHandle IMNKOPNBHNO(NativeList<EFLIOEPBLAG> JAAGBDPDCIE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2715DC0", Offset = "0x2714FC0", VA = "0x182715DC0")]
		private void EALLNKPLBIH(NativeListAsync<EFLIOEPBLAG> JAAGBDPDCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x27181B0", Offset = "0x27173B0", VA = "0x1827181B0")]
		private void NMANMHFPIHJ(NativeListAsync<EFLIOEPBLAG> JAAGBDPDCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2716050", Offset = "0x2715250", VA = "0x182716050")]
		private bool EFGHHDIJLEH(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2717940", Offset = "0x2716B40", VA = "0x182717940")]
		private NativeArray<Entity> MBIDAFIPGOI(Entity LHCPLOHKBCE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2715470", Offset = "0x2714670", VA = "0x182715470")]
		private HKFKNNJOKKH DLIFFKENEPD(NativeList<HKFKNNJOKKH> FNLHHAHKLIP)
		{
			return default(HKFKNNJOKKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2717AE0", Offset = "0x2716CE0", VA = "0x182717AE0")]
		private void MLMGPKIMLPG(HKFKNNJOKKH PLFCHHKILCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2718440", Offset = "0x2717640", VA = "0x182718440", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2714C80", Offset = "0x2713E80", VA = "0x182714C80")]
		public static EntityQuery AOOEBFPPBPB(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x27176E0", Offset = "0x27168E0", VA = "0x1827176E0")]
		public static EntityQuery LJMCOLGCPEP(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x27169B0", Offset = "0x2715BB0", VA = "0x1827169B0")]
		public static EntityQuery FIOCLBNPKLG(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private GBMEAEPJCNJ HKPONLMBIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private PJLDDPKOLDE NEBMDPHJHAJ;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B09980", Offset = "0x2B08B80", VA = "0x182B09980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A040", Offset = "0x2B09240", VA = "0x182B0A040", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B09A80", Offset = "0x2B08C80", VA = "0x182B09A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class CLBNKFLCDJC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public ACPBHPEJKKH MICPPHDEBFL;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CLBNKFLCDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public CLBNKFLCDJC(ACPBHPEJKKH MICPPHDEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7110", Offset = "0x2AA6310", VA = "0x182AA7110", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class JPOEOICFPNA : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService BBFEJKBBFEI;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x26ADC70", Offset = "0x26ACE70", VA = "0x1826ADC70", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x26ADC20", Offset = "0x26ACE20", VA = "0x1826ADC20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x26ADC50", Offset = "0x26ACE50", VA = "0x1826ADC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	protected JPOEOICFPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class DGBMHMLDPLG : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery NANDDGGBFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery EFIJAJEAFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery BDONJMBMAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery DGABPHBLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService IHPLCKANCIE;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int ELEKBHEODOK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4EF0", Offset = "0x2AB40F0", VA = "0x182AB4EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int HLDBFIHOMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4F20", Offset = "0x2AB4120", VA = "0x182AB4F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB57B0", Offset = "0x2AB49B0", VA = "0x182AB57B0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5590", Offset = "0x2AB4790", VA = "0x182AB5590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5790", Offset = "0x2AB4990", VA = "0x182AB5790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4F00", Offset = "0x2AB4100", VA = "0x182AB4F00")]
	public int AJKLHMEOEOI(SceneTag FEGPGPHCDJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB53A0", Offset = "0x2AB45A0", VA = "0x182AB53A0")]
	public int JPHLNAACLHO(SceneTag FEGPGPHCDJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5180", Offset = "0x2AB4380", VA = "0x182AB5180")]
	protected void JKOECLFOHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4FC0", Offset = "0x2AB41C0", VA = "0x182AB4FC0")]
	protected void EDPFDPIJCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5130", Offset = "0x2AB4330", VA = "0x182AB5130")]
	public NativeArrayAsync<Entity> FPGFEJGGGKG(SceneTag FEGPGPHCDJD, Allocator HCEMBCPANJM = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5540", Offset = "0x2AB4740", VA = "0x182AB5540")]
	public NativeArrayAsync<Entity> NKBOCNMHOLK(SceneTag FEGPGPHCDJD, Allocator HCEMBCPANJM = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4F30", Offset = "0x2AB4130", VA = "0x182AB4F30")]
	public bool DPOLFPCJKNJ(SceneTag FEGPGPHCDJD, out NativeArrayAsync<Entity> MICPPHDEBFL, Allocator HCEMBCPANJM = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB50D0", Offset = "0x2AB42D0", VA = "0x182AB50D0")]
	public bool FEMFMLHCJLP(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB54D0", Offset = "0x2AB46D0", VA = "0x182AB54D0")]
	public ACPBHPEJKKH MMGJFDFMENH(Entity LHCPLOHKBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5460", Offset = "0x2AB4660", VA = "0x182AB5460")]
	public bool MLOGCIOJFGP(Entity LHCPLOHKBCE, out CLBNKFLCDJC MICPPHDEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB53C0", Offset = "0x2AB45C0", VA = "0x182AB53C0")]
	public void LBINHIANAEM(Entity LHCPLOHKBCE, CLBNKFLCDJC MICPPHDEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5400", Offset = "0x2AB4600", VA = "0x182AB5400")]
	public bool LMKNKNMADHG(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void GGDMLKNOGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public DGBMHMLDPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class PJJPBIIOPDH : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery PKEDJMOGABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private MLOAKDLKONO FPLPHBFOJPL;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B01AD0", Offset = "0x2B00CD0", VA = "0x182B01AD0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B01730", Offset = "0x2B00930", VA = "0x182B01730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B017F0", Offset = "0x2B009F0", VA = "0x182B017F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x25B8F20", Offset = "0x25B8120", VA = "0x1825B8F20")]
	private bool AKFDONBHHHK<TComponentData>(EntityQuery ADGIOFAMOGF, out NativeArray<Entity> EJIAHCPIPFJ, out NativeArray<TComponentData> LGJGAACOOON) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B016C0", Offset = "0x2B008C0", VA = "0x182B016C0")]
	public ACPBHPEJKKH MMGJFDFMENH(Entity LHCPLOHKBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public PJJPBIIOPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery FEFPALKPEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery DNEENKDFCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery BBCMGKOEEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery PFIMNLNCAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x270A7C0", Offset = "0x27099C0", VA = "0x18270A7C0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x270A460", Offset = "0x2709660", VA = "0x18270A460", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x270A690", Offset = "0x2709890", VA = "0x18270A690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x270A380", Offset = "0x2709580", VA = "0x18270A380")]
		private void CPCILMEHKPA(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x270A3F0", Offset = "0x27095F0", VA = "0x18270A3F0")]
		private void MILDLLFOGOM(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x270A620", Offset = "0x2709820", VA = "0x18270A620", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x270A020", Offset = "0x2709220", VA = "0x18270A020")]
		private void CEPKDMGEBIH(EntityQuery ADGIOFAMOGF, bool FBHDABEFLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class LFMEMFKDHKE : HDACKBGFGDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct AGEEBEAJPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public AGEEBEAJPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EFOJHGGGDNL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct DFMPCMLLMMD
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct FGCHGJFMBFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DAKDKLEGLID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime NNEFACOBAMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime GKCJOGHGKFD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BDGAKKMDNDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> GMLBGBDMHNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> BMBIGFGLFNM;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x34D0280", Offset = "0x34CF480", VA = "0x1834D0280")]
			public void JNNOBNMLOFO(LFMEMFKDHKE GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x34D01C0", Offset = "0x34CF3C0", VA = "0x1834D01C0")]
			public FGCHGJFMBFA CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(FGCHGJFMBFA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private DFMPCMLLMMD JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DFMPCMLLMMD.FGCHGJFMBFA* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x34D0D90", Offset = "0x34CFF90", VA = "0x1834D0D90")]
		internal void NKAIDNDKJJJ(Entity MIJLKPMKNKG, SplineShapeData GADDGJANIGG, DynamicBuffer<LinkedEntityGroup> ACMMHKGMFIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x34D0B90", Offset = "0x34CFD90", VA = "0x1834D0B90", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x34D0C70", Offset = "0x34CFE70", VA = "0x1834D0C70")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref DFMPCMLLMMD.FGCHGJFMBFA CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x34D0C60", Offset = "0x34CFE60", VA = "0x1834D0C60")]
		public void JNNOBNMLOFO(LFMEMFKDHKE GEIMOJMNBNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KKEKMBNPEOC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct PNHHEDMMKGB
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct BNGGHEJCDAB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BMAJKFEIEHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime NDAPMCPFJBB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity MNBALIABBNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> CNONGCGKGEM;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x34DBDD0", Offset = "0x34DAFD0", VA = "0x1834DBDD0")]
			public void JNNOBNMLOFO(LFMEMFKDHKE GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x34DBD50", Offset = "0x34DAF50", VA = "0x1834DBD50")]
			public BNGGHEJCDAB CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(BNGGHEJCDAB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> KJECEJMMOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private PNHHEDMMKGB JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PNHHEDMMKGB.BNGGHEJCDAB* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x34D7870", Offset = "0x34D6A70", VA = "0x1834D7870")]
		internal void NKAIDNDKJJJ(Entity JJJFDLFNLAH, SplinePointParentData IELLALBFDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x34D7900", Offset = "0x34D6B00", VA = "0x1834D7900", Slot = "5")]
		public void ReadFromDisplayClass(ref AGEEBEAJPAB AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x34D7690", Offset = "0x34D6890", VA = "0x1834D7690", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x34D77C0", Offset = "0x34D69C0", VA = "0x1834D77C0")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref PNHHEDMMKGB.BNGGHEJCDAB CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x34D7730", Offset = "0x34D6930", VA = "0x1834D7730")]
		public void JNNOBNMLOFO(LFMEMFKDHKE GEIMOJMNBNO, ref AGEEBEAJPAB AAEEIKBBKHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery JGDCILGJDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery GLHFKCJOFNJ;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x26B4420", Offset = "0x26B3620", VA = "0x1826B4420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x26B44D0", Offset = "0x26B36D0", VA = "0x1826B44D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public LFMEMFKDHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x26B4180", Offset = "0x26B3380", VA = "0x1826B4180", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x26B3E80", Offset = "0x26B3080", VA = "0x1826B3E80")]
	public static EntityQuery AADDANJMHCD(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x26B4020", Offset = "0x26B3220", VA = "0x1826B4020")]
	public static EntityQuery BIDKJNNGOLA(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public sealed class BJPJAHAJABC : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private HMPKCBOCNEE MKCNDHMGOPM;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3600", Offset = "0x2AA2800", VA = "0x182AA3600", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA35E0", Offset = "0x2AA27E0", VA = "0x182AA35E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public BJPJAHAJABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class INMAJEFDFPB : HDACKBGFGDN, BDLDACMOPAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct PPFFAHONFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<NLOCLNGHLHN> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<NIEMJPNNGFN> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<NLOCLNGHLHN> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public PPFFAHONFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, DKOMKLJHDNG previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__2(Entity entity, DKOMKLJHDNG previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct DGBPKLBFMMP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct NILAEAHACBJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct DAOMOMKMBGF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJDGNEELDJP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> OBJKFOPLLDL;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x34D9A90", Offset = "0x34D8C90", VA = "0x1834D9A90")]
			public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x34D9A10", Offset = "0x34D8C10", VA = "0x1834D9A10")]
			public DAOMOMKMBGF CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(DAOMOMKMBGF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<NLOCLNGHLHN> ILNKOBPGIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private NILAEAHACBJ JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NILAEAHACBJ.DAOMOMKMBGF* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x34D04E0", Offset = "0x34CF6E0", VA = "0x1834D04E0")]
		internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, ParentData IJHMKEIOKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0xE7E610", Offset = "0xE7D810", VA = "0x180E7E610", Slot = "5")]
		public void ReadFromDisplayClass(ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x34D0300", Offset = "0x34CF500", VA = "0x1834D0300", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x34D0430", Offset = "0x34CF630", VA = "0x1834D0430")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref NILAEAHACBJ.DAOMOMKMBGF CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x34D03A0", Offset = "0x34CF5A0", VA = "0x1834D03A0")]
		public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO, ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CPHOLDELNHM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct OIJCKFKDGCK
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct DFPAAKOGCAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJDGNEELDJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<DKOMKLJHDNG>.Runtime EEDLEDJBLGC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> OBJKFOPLLDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<DKOMKLJHDNG> INHFFMBGDCM;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x34DAF30", Offset = "0x34DA130", VA = "0x1834DAF30")]
			public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x34DAE90", Offset = "0x34DA090", VA = "0x1834DAE90")]
			public DFPAAKOGCAG CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(DFPAAKOGCAG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<NIEMJPNNGFN> KDIMLDBLDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private OIJCKFKDGCK JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OIJCKFKDGCK.DFPAAKOGCAG* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x34CFF40", Offset = "0x34CF140", VA = "0x1834CFF40")]
		internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, ParentData IJHMKEIOKHN, DKOMKLJHDNG GHAEJDCDBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x34D0000", Offset = "0x34CF200", VA = "0x1834D0000", Slot = "5")]
		public void ReadFromDisplayClass(ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x34CFD50", Offset = "0x34CEF50", VA = "0x1834CFD50", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x34CFE60", Offset = "0x34CF060", VA = "0x1834CFE60")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref OIJCKFKDGCK.DFPAAKOGCAG CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x34CFE20", Offset = "0x34CF020", VA = "0x1834CFE20")]
		public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO, ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IDOCDFGIJON : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct IAEOGAJAMCN
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct KIMHEOEGOLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<DKOMKLJHDNG>.Runtime EEDLEDJBLGC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<DKOMKLJHDNG> INHFFMBGDCM;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x34D4140", Offset = "0x34D3340", VA = "0x1834D4140")]
			public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x34D40C0", Offset = "0x34D32C0", VA = "0x1834D40C0")]
			public KIMHEOEGOLD CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(KIMHEOEGOLD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<NLOCLNGHLHN> IHCLPKFJAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private IAEOGAJAMCN JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IAEOGAJAMCN.KIMHEOEGOLD* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x34D4420", Offset = "0x34D3620", VA = "0x1834D4420")]
		internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, DKOMKLJHDNG GHAEJDCDBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x34D44A0", Offset = "0x34D36A0", VA = "0x1834D44A0", Slot = "5")]
		public void ReadFromDisplayClass(ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x34D4240", Offset = "0x34D3440", VA = "0x1834D4240", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x34D4370", Offset = "0x34D3570", VA = "0x1834D4370")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref IAEOGAJAMCN.KIMHEOEGOLD CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x34D42E0", Offset = "0x34D34E0", VA = "0x1834D42E0")]
		public void JNNOBNMLOFO(INMAJEFDFPB GEIMOJMNBNO, ref PPFFAHONFNK AAEEIKBBKHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private CLOLHMILBAD DGDOFEMJJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery PCOEKOMKAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery OJCFBFADOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery GAJLELNCIDL;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x26A9F80", Offset = "0x26A9180", VA = "0x1826A9F80", Slot = "14")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x26AA520", Offset = "0x26A9720", VA = "0x1826AA520", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public INMAJEFDFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x26AA4C0", Offset = "0x26A96C0", VA = "0x1826AA4C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x26AA060", Offset = "0x26A9260", VA = "0x1826AA060")]
	public static EntityQuery GOBPAPAOODD(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x26A9D50", Offset = "0x26A8F50", VA = "0x1826A9D50")]
	public static EntityQuery AFLODMHDAAK(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x26AA2C0", Offset = "0x26A94C0", VA = "0x1826AA2C0")]
	public static EntityQuery OJBAMEPJNMF(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Connectables)]
	public class InitializeRigidbodyExHierarchy : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private BPDKAHOMBHL FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x26AA7E0", Offset = "0x26A99E0", VA = "0x1826AA7E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x26AAA60", Offset = "0x26A9C60", VA = "0x1826AAA60", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x26AA870", Offset = "0x26A9A70", VA = "0x1826AA870", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class MNGBMBBPADN : ParentSystemBase<ParentData, DKOMKLJHDNG, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0080", Offset = "0x2AEF280", VA = "0x182AF0080", Slot = "14")]
	protected override EntityQueryDesc ACIKKGMNINI(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "15")]
	protected override EntityQueryDesc IOLHLOAGBGO(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF00C0", Offset = "0x2AEF2C0", VA = "0x182AF00C0", Slot = "16")]
	protected override EntityQueryDesc NHPIDPMMCIA(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0100", Offset = "0x2AEF300", VA = "0x182AF0100", Slot = "17")]
	protected override EntityQueryDesc NPNAKCFPEPP(EntityQueryDesc ADGIOFAMOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0180", Offset = "0x2AEF380", VA = "0x182AF0180")]
	public MNGBMBBPADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0140", Offset = "0x2AEF340", VA = "0x182AF0140", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : HDACKBGFGDN where ParentData : struct, IComponentData, KLMOHFMGCOL where PreviousParentData : struct, IComponentData, KLMOHFMGCOL where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, KLMOHFMGCOL
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct NEINJCDDMNF : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter LNHICEHEAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter ONCMOPFOCFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter OBILBGAPGPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> KNOHOLJLDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> OIHGMNNFJLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType LALONPKCHCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint EABDLDFBCCO;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x24BE490", Offset = "0x24BD690", VA = "0x1824BE490", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct MKLJMLEBPGA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OBILBGAPGPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> IPPCHKJDPAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> NFAOAFEAPPH;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x262E280", Offset = "0x262D480", VA = "0x18262E280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct EJMBKFMCGFO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> LNHICEHEAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> ONCMOPFOCFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OBILBGAPGPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> IPPCHKJDPAK;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x27E60C0", Offset = "0x27E52C0", VA = "0x1827E60C0")]
			private int LHAKHDHLHCD(DynamicBuffer<ChildrenData> OKKDPEMOHMC, Entity LHCPLOHKBCE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x27E58E0", Offset = "0x27E4AE0", VA = "0x1827E58E0")]
			private void EBDBEKPIKCK(Entity HHFDFFDPCGO, DynamicBuffer<ChildrenData> OKKDPEMOHMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x27E5F90", Offset = "0x27E5190", VA = "0x1827E5F90")]
			private void LBFJDNJBGHI(Entity HHFDFFDPCGO, DynamicBuffer<ChildrenData> OKKDPEMOHMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x27E5BA0", Offset = "0x27E4DA0", VA = "0x1827E5BA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct DPGIHKKHOFP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> CDPNPIGKMGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> NCLNEDAIDDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> IPPCHKJDPAK;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2E13910", Offset = "0x2E12B10", VA = "0x182E13910", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery ODKOHMPPEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery ILAPNMEHPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery OIDNODKIDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery GNKJKODMDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker OIKMKGPLAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker GADDFPNPCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker LKLLECJMGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker CPBDLMOJIOB;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2470F90", Offset = "0x2470190", VA = "0x182470F90")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x24704B0", Offset = "0x246F6B0", VA = "0x1824704B0")]
		private int LHAKHDHLHCD(DynamicBuffer<ChildrenData> OKKDPEMOHMC, Entity LHCPLOHKBCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2470690", Offset = "0x246F890", VA = "0x182470690")]
		private void MGNGMNEEPNC(Entity IBOBCJFCMCK, Entity GLBJFNNAHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "14")]
		protected virtual EntityQueryDesc ACIKKGMNINI(EntityQueryDesc ADGIOFAMOGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "15")]
		protected virtual EntityQueryDesc IOLHLOAGBGO(EntityQueryDesc ADGIOFAMOGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB10", Offset = "0x8ECD10", VA = "0x1808EDB10", Slot = "16")]
		protected virtual EntityQueryDesc NHPIDPMMCIA(EntityQueryDesc ADGIOFAMOGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc NPNAKCFPEPP(EntityQueryDesc ADGIOFAMOGF);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2470950", Offset = "0x246FB50", VA = "0x182470950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x246FAA0", Offset = "0x246ECA0", VA = "0x18246FAA0")]
		private void FAKNDHLHNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x246FD30", Offset = "0x246EF30", VA = "0x18246FD30")]
		private void HLGBDBPHKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x246EF70", Offset = "0x246E170", VA = "0x18246EF70")]
		private JobHandle EDJFGCFLHKE(JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x246FEF0", Offset = "0x246F0F0", VA = "0x18246FEF0")]
		private void LDLLPLHNBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2470EC0", Offset = "0x24700C0", VA = "0x182470EC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2470E90", Offset = "0x2470090", VA = "0x182470E90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public abstract class FMFJLEJCFKG : HDACKBGFGDN, BDLDACMOPAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct OKMHEOIDALC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> ELKCDGAHMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> LHGCKENOLHB;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x34DB2C0", Offset = "0x34DA4C0", VA = "0x1834DB2C0")]
		public OKMHEOIDALC(NativeList<Entity> ELKCDGAHMJJ, NativeList<Entity> LHGCKENOLHB, JobHandle KBGHJIGDKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x34DB240", Offset = "0x34DA440", VA = "0x1834DB240")]
		public JobHandle GEFJEMFBCHK(JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x34DB1B0", Offset = "0x34DA3B0", VA = "0x1834DB1B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct OIIBNLKNGAH : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum CJFIAGFCOJN
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
		public NativeList<Entity> KKCHMPCFJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> MHKCAFFCLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> HPBCCONEGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FNOCLECIAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity NCODFFCHEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity AFNAFOGJKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GBOPAFIGDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int PFALHKFIKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int GNBHPOOPHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private CJFIAGFCOJN MDEOCKDFDNK;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x34DA7C0", Offset = "0x34D99C0", VA = "0x1834DA7C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x34DAD20", Offset = "0x34D9F20", VA = "0x1834DAD20")]
		private void LCNKAKNMKMA(Entity LHCPLOHKBCE, bool KJCJCFKFPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x34DAC10", Offset = "0x34D9E10", VA = "0x1834DAC10")]
		private void KMEMIEAMFKB(Entity LHCPLOHKBCE, bool KJCJCFKFPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x34DAB90", Offset = "0x34D9D90", VA = "0x1834DAB90")]
		public OKMHEOIDALC JMHCLIACFDG(NativeArray<Entity> DJGFOAKOCAP, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x34DAB10", Offset = "0x34D9D10", VA = "0x1834DAB10")]
		public OKMHEOIDALC JKGPHGFOCPA(NativeArray<Entity> DJGFOAKOCAP, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x34DADB0", Offset = "0x34D9FB0", VA = "0x1834DADB0")]
		public OKMHEOIDALC MHMIPCJKHHM(NativeList<NLOCLNGHLHN> JAAGBDPDCIE, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x34DA950", Offset = "0x34D9B50", VA = "0x1834DA950")]
		public OKMHEOIDALC GJDNKMBNIKL(NativeList<NLOCLNGHLHN> JAAGBDPDCIE, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x34DAA30", Offset = "0x34D9C30", VA = "0x1834DAA30")]
		public OKMHEOIDALC JFPNKFHMAHK(NativeList<NIEMJPNNGFN> JAAGBDPDCIE, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2263970", Offset = "0x2262B70", VA = "0x182263970")]
		private OKMHEOIDALC CDNGCOKBPLF<T>(NativeList<T> JAAGBDPDCIE, int DPDNMBMPDFG, int DIOJOKKGNBN, CJFIAGFCOJN DNLPIHIBJDP, JobHandle BPJJMMFHOJB) where T : struct
		{
			return default(OKMHEOIDALC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x34DA560", Offset = "0x34D9760", VA = "0x1834DA560")]
		private OKMHEOIDALC CDNGCOKBPLF(NativeArray<Entity> EJIAHCPIPFJ, int DPDNMBMPDFG, int DIOJOKKGNBN, CJFIAGFCOJN DNLPIHIBJDP, JobHandle BPJJMMFHOJB)
		{
			return default(OKMHEOIDALC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery EKHNLIDKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery OAGJAEDCAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private CLOLHMILBAD MHBKHAOHOGF;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType CKBKGNNPFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType KCMCCINKDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType GOGHPKEOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x269CD30", Offset = "0x269BF30", VA = "0x18269CD30")]
	protected FMFJLEJCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x269B5A0", Offset = "0x269A7A0", VA = "0x18269B5A0", Slot = "14")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x269BC90", Offset = "0x269AE90", VA = "0x18269BC90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x269BEC0", Offset = "0x269B0C0", VA = "0x18269BEC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x10D2970", Offset = "0x10D1B70", VA = "0x1810D2970", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x269B9E0", Offset = "0x269ABE0", VA = "0x18269B9E0")]
	private void KNPMJJCFDHC(NativeArray<Entity> JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x269B940", Offset = "0x269AB40", VA = "0x18269B940")]
	private void IJENPFMBCEP(NativeArray<Entity> JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x269BB50", Offset = "0x269AD50", VA = "0x18269BB50")]
	private void MPEJPNLILAG(OKMHEOIDALC GDCFBODKBJA, string OFMGPNLDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x269BA40", Offset = "0x269AC40", VA = "0x18269BA40")]
	private void MPEJPNLILAG(NativeListAsync<Entity> JFMMHFCCPDG, string OFMGPNLDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x269B790", Offset = "0x269A990", VA = "0x18269B790")]
	private void ALECPOOAADC(OKMHEOIDALC GDCFBODKBJA, string OFMGPNLDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x269B680", Offset = "0x269A880", VA = "0x18269B680")]
	private void ALECPOOAADC(NativeListAsync<Entity> JFMMHFCCPDG, string OFMGPNLDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x269B8D0", Offset = "0x269AAD0", VA = "0x18269B8D0")]
	private bool CBAPOBAKFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public class IKFALFDGFFP : HDACKBGFGDN, CMLEAAEGAAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct IFJHLEGIJFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public IKFALFDGFFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public IFJHLEGIJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FLFOACCFDKO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct IBOGNBMAEJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct OPBKADNOEEB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime MOFOPELKEEM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HAEHOBPBLAK;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x34D4230", Offset = "0x34D3430", VA = "0x1834D4230")]
			public void JNNOBNMLOFO(IKFALFDGFFP GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x34D4220", Offset = "0x34D3420", VA = "0x1834D4220")]
			public OPBKADNOEEB CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(OPBKADNOEEB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public IKFALFDGFFP DKDKPIPCMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer LJLJDLPDOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IBOGNBMAEJO JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IBOGNBMAEJO.OPBKADNOEEB* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x34D2390", Offset = "0x34D1590", VA = "0x1834D2390")]
		internal void NKAIDNDKJJJ(Entity GCBHEJANCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x34D24A0", Offset = "0x34D16A0", VA = "0x1834D24A0", Slot = "5")]
		public void ReadFromDisplayClass(ref IFJHLEGIJFH AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x34D24D0", Offset = "0x34D16D0", VA = "0x1834D24D0", Slot = "6")]
		public void WriteToDisplayClass(ref IFJHLEGIJFH AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x34D2290", Offset = "0x34D1490", VA = "0x1834D2290", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x34D2320", Offset = "0x34D1520", VA = "0x1834D2320")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref IBOGNBMAEJO.OPBKADNOEEB CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x34D22E0", Offset = "0x34D14E0", VA = "0x1834D22E0")]
		public void JNNOBNMLOFO(IKFALFDGFFP GEIMOJMNBNO, ref IFJHLEGIJFH AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x34D2220", Offset = "0x34D1420", VA = "0x1834D2220")]
		public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private CKNFFNLJEMG IEGLCCNAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private OHHINBMLFAA NGAKIPILJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery MCMDHCMIGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker GMLDNHHKNMA;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x26A8570", Offset = "0x26A7770", VA = "0x1826A8570", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x26A8720", Offset = "0x26A7920", VA = "0x1826A8720", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x26A85D0", Offset = "0x26A77D0", VA = "0x1826A85D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public IKFALFDGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x26A8490", Offset = "0x26A7690", VA = "0x1826A8490", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x26A8780", Offset = "0x26A7980", VA = "0x1826A8780")]
	public static EntityQuery PBCBKDEMDFF(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[LJPJOHADJCO]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public class CCAAMKMCJKO : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private OHHINBMLFAA NGAKIPILJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService JIPLOFKCDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6130", Offset = "0x2AA5330", VA = "0x182AA6130", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5D40", Offset = "0x2AA4F40", VA = "0x182AA5D40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5DE0", Offset = "0x2AA4FE0", VA = "0x182AA5DE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public CCAAMKMCJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct GAAAGMGKLBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public EKNJLMLFPKH PLFCHHKILCM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
	public static GAAAGMGKLBK GJGPFJHFLAE(in EKNJLMLFPKH ONDDBAKFENP)
	{
		return default(GAAAGMGKLBK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
	public static EKNJLMLFPKH GJGPFJHFLAE(in GAAAGMGKLBK MIEJELOCCPL)
	{
		return default(EKNJLMLFPKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class CKNFFNLJEMG : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70E0", Offset = "0x2AA62E0", VA = "0x182AA70E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public CKNFFNLJEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public class FDGHNACDJNG : HDACKBGFGDN, CMLEAAEGAAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct PLFGPCAGBIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public FDGHNACDJNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public PLFGPCAGBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__0(Entity e, GAAAGMGKLBK ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PHEMPIOEMAE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct MJKDCFGMEDL
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct NHALABEKBDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime MOFOPELKEEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<GAAAGMGKLBK>.Runtime LJKEOEFLOFD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HAEHOBPBLAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GAAAGMGKLBK> EDCOPCDLEMJ;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x34D8AE0", Offset = "0x34D7CE0", VA = "0x1834D8AE0")]
			public void JNNOBNMLOFO(FDGHNACDJNG GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x34D8A60", Offset = "0x34D7C60", VA = "0x1834D8A60")]
			public NHALABEKBDM CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(NHALABEKBDM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public FDGHNACDJNG DKDKPIPCMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer LJLJDLPDOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private MJKDCFGMEDL JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MJKDCFGMEDL.NHALABEKBDM* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x34DBC50", Offset = "0x34DAE50", VA = "0x1834DBC50")]
		internal void NKAIDNDKJJJ(Entity GCBHEJANCJK, GAAAGMGKLBK HOFAMEHDGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x34D24A0", Offset = "0x34D16A0", VA = "0x1834D24A0", Slot = "5")]
		public void ReadFromDisplayClass(ref PLFGPCAGBIF AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x34D24D0", Offset = "0x34D16D0", VA = "0x1834D24D0", Slot = "6")]
		public void WriteToDisplayClass(ref PLFGPCAGBIF AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x34DBA70", Offset = "0x34DAC70", VA = "0x1834DBA70", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x34DBBA0", Offset = "0x34DADA0", VA = "0x1834DBBA0")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref MJKDCFGMEDL.NHALABEKBDM CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x34DBB10", Offset = "0x34DAD10", VA = "0x1834DBB10")]
		public void JNNOBNMLOFO(FDGHNACDJNG GEIMOJMNBNO, ref PLFGPCAGBIF AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x34DBA00", Offset = "0x34DAC00", VA = "0x1834DBA00")]
		public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private CKNFFNLJEMG IEGLCCNAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private OHHINBMLFAA NGAKIPILJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery HJGIMLPPOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker BPBBLKNDNHF;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x26988A0", Offset = "0x2697AA0", VA = "0x1826988A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2698A60", Offset = "0x2697C60", VA = "0x182698A60", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2698900", Offset = "0x2697B00", VA = "0x182698900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public FDGHNACDJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x26987C0", Offset = "0x26979C0", VA = "0x1826987C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x26985F0", Offset = "0x26977F0", VA = "0x1826985F0")]
	public static EntityQuery GJBEMPFEJFM(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct CEPDIJABLMP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public JEMIGPGNFON EDPIJECELAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, MFEHAEMCKCJ> EJIAHCPIPFJ;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x34CF820", Offset = "0x34CEA20", VA = "0x1834CF820")]
			public CEPDIJABLMP(int FAPOEIDOLFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x34CF7A0", Offset = "0x34CE9A0", VA = "0x1834CF7A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct GEEAPIJKDLN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EOFCGIFBGHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> KFDIOMHMMGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MPCDPNJIPDB;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x34D2830", Offset = "0x34D1A30", VA = "0x1834D2830", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct CIMLIEPFGBO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EOFCGIFBGHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MPCDPNJIPDB;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x34CF8C0", Offset = "0x34CEAC0", VA = "0x1834CF8C0", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private OHHINBMLFAA NGAKIPILJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery KDDFJIEEIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery ACJKHHAHMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery IMFAKMLAMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery AOLMKIABHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery AFGPBANGMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle IEEFIMEIOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private CEPDIJABLMP ELECKHDIONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private CEPDIJABLMP DNALIKBPIKF;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2B07460", Offset = "0x2B06660", VA = "0x182B07460", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2B06A00", Offset = "0x2B05C00", VA = "0x182B06A00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2B06890", Offset = "0x2B05A90", VA = "0x182B06890", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2B06CC0", Offset = "0x2B05EC0", VA = "0x182B06CC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2B06250", Offset = "0x2B05450", VA = "0x182B06250")]
		private void DNJLBPPJKKC(EntityQuery ADGIOFAMOGF, out (NativeArrayAsync<GAAAGMGKLBK> handles, NativeArrayAsync<DBFJJBPOONO> bounds) PCPEJHIMHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2B06630", Offset = "0x2B05830", VA = "0x182B06630")]
		private void LAFJFFONKIH((NativeArrayAsync<GAAAGMGKLBK> handles, NativeArrayAsync<DBFJJBPOONO> bounds) PCPEJHIMHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2B06890", Offset = "0x2B05A90", VA = "0x182B06890")]
		private void LHMNDFCCDLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2B064F0", Offset = "0x2B056F0", VA = "0x182B064F0")]
		private void GPCLFFBPEIC(EntityQuery ADGIOFAMOGF, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<GAAAGMGKLBK> handles) PCPEJHIMHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2B05F60", Offset = "0x2B05160", VA = "0x182B05F60")]
		private void DBPACOHICLE((NativeArrayAsync<Entity> entities, NativeArrayAsync<GAAAGMGKLBK> handles) PCPEJHIMHJJ, CEPDIJABLMP LCPAKHJBEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2B06390", Offset = "0x2B05590", VA = "0x182B06390")]
		private JobHandle EEMPLJFBIEK(CEPDIJABLMP LCPAKHJBEOA, ComponentDataFromEntity<WorldPoseData> EOFCGIFBGHM, ComponentDataFromEntity<WorldUniformScaleData> MPCDPNJIPDB, ComponentDataFromEntity<WorldDeformableScaleData> KFDIOMHMMGE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2B068D0", Offset = "0x2B05AD0", VA = "0x182B068D0")]
		private JobHandle OCHGAFNNNMP(CEPDIJABLMP LCPAKHJBEOA, ComponentDataFromEntity<WorldPoseData> EOFCGIFBGHM, ComponentDataFromEntity<WorldUniformScaleData> MPCDPNJIPDB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct PFFBFGEECBD : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[LJPJOHADJCO]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public class SplineLocalBoundsSystem : HDACKBGFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct OBENDIHAICI : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> PMLNGBBEHOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> LDAKJPLIALJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<DBFJJBPOONO> NGCECEDAJAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, MFEHAEMCKCJ>.ParallelWriter EPNLKDBADCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter BICFGGGEPKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter KPELGCLLDIO;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x34D9AF0", Offset = "0x34D8CF0", VA = "0x1834D9AF0", Slot = "4")]
			public void Execute(int GMEHLIHLGEH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct FDEDJLLAKCI : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> HNBGCOGMIGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> ADEGAHPFOBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> DKBJLNIFONJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> NKLAIJIDLDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DBFJJBPOONO> LPLELDGFAGO;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x34D1F90", Offset = "0x34D1190", VA = "0x1834D1F90", Slot = "4")]
			public void Execute(int GMEHLIHLGEH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery AFFGHKCCFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery LEGFFGJKPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery NOPNFEHLPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery LOBNBHKGEHP;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x270C7B0", Offset = "0x270B9B0", VA = "0x18270C7B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x270C9C0", Offset = "0x270BBC0", VA = "0x18270C9C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x270C0A0", Offset = "0x270B2A0", VA = "0x18270C0A0")]
		private JobHandle LHIFLAPGHFE(NativeArrayAsync<Entity> HAHPMNMCEBD, int MNKGPEKFPKK, JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x270C180", Offset = "0x270B380", VA = "0x18270C180")]
		private JobHandle LHIFLAPGHFE(NativeArray<Entity> JGGJHCOOIBD, int MNKGPEKFPKK, [Optional] JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x270BD90", Offset = "0x270AF90", VA = "0x18270BD90")]
		private NativeArrayAsync<Entity> BNKPIELLHNO(EntityQuery ADGIOFAMOGF)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x270C360", Offset = "0x270B560", VA = "0x18270C360")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) NKGAHGFIEGJ(NativeArrayAsync<Entity> DIFMOMFKPOF)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x270BD00", Offset = "0x270AF00", VA = "0x18270BD00")]
		private void AJMKIOEMAEL(out NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x270BE10", Offset = "0x270B010", VA = "0x18270BE10")]
		private void GJONGPGPMNP(NativeList<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x270BEA0", Offset = "0x270B0A0", VA = "0x18270BEA0")]
		private void GJONGPGPMNP(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x270BF70", Offset = "0x270B170", VA = "0x18270BF70")]
		private void GNEKIBENHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void JBGLLAPNGPF(int MBGEDKGLLEA, int INPBGFNKIFI, int CHLCOOEPANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x270CEE0", Offset = "0x270C0E0", VA = "0x18270CEE0")]
		private static DBFJJBPOONO POEHPFMBFHG(NativeArray<Entity> JHGHLOJACOB, ComponentDataFromEntity<SplinePointPositionData> DKBJLNIFONJ, ComponentDataFromEntity<SplinePointScaleData> NKLAIJIDLDH)
		{
			return default(DBFJJBPOONO);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct FAPLDHBEJGJ : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[LJPJOHADJCO]
	[CGDKNMKPKIP(OOBCCNCEGNI.Lifecycle)]
	public class DestroyLocalObjects : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[GAJFPHPAPMA]
		private ObjectNetworkToLocalMapService BDHLICLKMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[GAJFPHPAPMA]
		private ObjectLifecycleService FBCDDJGNMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery OHAOLBEBEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery LOHBLNCEFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery PFIMNLNCAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8730", Offset = "0x2AB7930", VA = "0x182AB8730", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB83F0", Offset = "0x2AB75F0", VA = "0x182AB83F0")]
		public bool MEEHIKDHCAE(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB85E0", Offset = "0x2AB77E0", VA = "0x182AB85E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB83B0", Offset = "0x2AB75B0", VA = "0x182AB83B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8710", Offset = "0x2AB7910", VA = "0x182AB8710", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E40", Offset = "0x9A7040", VA = "0x1809A7E40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2AB83B0", Offset = "0x2AB75B0", VA = "0x182AB83B0")]
		private void FBOIPAJCENL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AB81E0", Offset = "0x2AB73E0", VA = "0x182AB81E0")]
		private void DCKCAAPNFHL(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB84A0", Offset = "0x2AB76A0", VA = "0x182AB84A0")]
		private void NDJCEHNAMOK(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB87A0", Offset = "0x2AB79A0", VA = "0x182AB87A0")]
		private void PICGCAPNLAO(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8290", Offset = "0x2AB7490", VA = "0x182AB8290")]
		private void EHAKLONCPDK(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.NetworkSend)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static JJFNDNAGMHB[] PPNIFLGBNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private POBKBOKNKBJ LFFNAIMKPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private IIEGBNJCKEO DFFNDCEBDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService CNOPCHGAFOK;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x26965B0", Offset = "0x26957B0", VA = "0x1826965B0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x26964F0", Offset = "0x26956F0", VA = "0x1826964F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2695F60", Offset = "0x2695160", VA = "0x182695F60")]
		private void NHMPJEBKELH(JJFNDNAGMHB MGADLDPDPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private void DLHGEFJDALA(Entity LHCPLOHKBCE, HCIIHJLICJK MIBPNJCOIHL, NDGJEHEDOED KDHBALDHKBN, DDBPAPBBEPF FECCLDLGMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Callbacks)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public sealed class PropertyEventCallbacks : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService ACDHNMANGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService CNOPCHGAFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase MGADLDPDPGK;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CB00", Offset = "0x2B0BD00", VA = "0x182B0CB00", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CA00", Offset = "0x2B0BC00", VA = "0x182B0CA00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[CGDKNMKPKIP(OOBCCNCEGNI.NetworkSend)]
	internal class TransmitNetworkDataSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private FGBFDIFKLHF OPKKHHNDKJF;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2714140", Offset = "0x2713340", VA = "0x182714140", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x27140F0", Offset = "0x27132F0", VA = "0x1827140F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[LJPJOHADJCO]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public class CalculateCullingBandChanges : HDACKBGFGDN, IMFHGBIDMMC, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct LDCKPMDMKMI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType DOJENKMGDBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> BLHMMJKAJFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<CALFDDGNLFK>.ParallelWriter CJJCBAPHAEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<KPIHKGMDINM> IIIHBCBHIEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 GFCPAMJILIO;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 LFKFHBHOPBL;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 KEDBAELNJIE;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 GIIOAPIFEEC;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x26FF4B0", Offset = "0x26FE6B0", VA = "0x1826FF4B0", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int OMIMFEGNGBP = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double NCNIMCIOBCK = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery JDGBBJNGMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery FIFGHNBHNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double JIJCKCGHLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService FGELPKAOBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService FNMIGFKCOMI;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7FA0", Offset = "0x2AA71A0", VA = "0x182AA7FA0", Slot = "14")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8660", Offset = "0x2AA7860", VA = "0x182AA8660", Slot = "15")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA82F0", Offset = "0x2AA74F0", VA = "0x182AA82F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8440", Offset = "0x2AA7640", VA = "0x182AA8440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7F30", Offset = "0x2AA7130", VA = "0x182AA7F30")]
		private bool APIKDGMMKFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7FB0", Offset = "0x2AA71B0", VA = "0x182AA7FB0")]
		private void KFHCHJPBKOG(EntityQuery ADGIOFAMOGF, float3 CACOOJDPNLO, string KNOPFGAGMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct CALFDDGNLFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity LHCPLOHKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public AIDCDLFPLAF HKPEMIJGIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public AIDCDLFPLAF INPBMNIIHJJ;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public class ProcessCullingBandChangeCallbacks : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService FGELPKAOBJF;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B098C0", Offset = "0x2B08AC0", VA = "0x182B098C0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B098A0", Offset = "0x2B08AA0", VA = "0x182B098A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Connectables)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class UpdateInertialProperties : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery NCDHHEDBIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private FPOFHEKDION JDNBLINEMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x271AEE0", Offset = "0x271A0E0", VA = "0x18271AEE0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x271ABB0", Offset = "0x2719DB0", VA = "0x18271ABB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x271AC40", Offset = "0x2719E40", VA = "0x18271AC40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[LJPJOHADJCO]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EDPCOLLGIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HKIICOPAECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OBHCAJOEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService CFKBOIBHFGM;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2695DF0", Offset = "0x2694FF0", VA = "0x182695DF0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x26958C0", Offset = "0x2694AC0", VA = "0x1826958C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2694CC0", Offset = "0x2693EC0", VA = "0x182694CC0")]
		private void DCAHFDGICOG(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JAAGBDPDCIE, EntityQueryDesc HNCPHICOFLM, bool FNBMGBEMKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x2694DD0", Offset = "0x2693FD0", VA = "0x182694DD0")]
		private void DCAHFDGICOG(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JAAGBDPDCIE, EntityQueryDesc HNCPHICOFLM, bool FNBMGBEMKPE, bool OIEPDFJCEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2695B20", Offset = "0x2694D20", VA = "0x182695B20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x26954A0", Offset = "0x26946A0", VA = "0x1826954A0")]
		private void HILGCFFPCIP(EntityQuery ADGIOFAMOGF, bool KEDMEFHBKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2694AB0", Offset = "0x2693CB0", VA = "0x182694AB0")]
		private void BBFJKIMDGMM(EntityQuery ADGIOFAMOGF, bool HBNKIDFHDAJ, bool KEDMEFHBKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2695080", Offset = "0x2694280", VA = "0x182695080")]
		private void FKDCGLIFPHB(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2694F10", Offset = "0x2694110", VA = "0x182694F10")]
		private void ELPDCHALAMO(NativeList<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2695720", Offset = "0x2694920", VA = "0x182695720")]
		private void IHELALNGMNH(NativeArray<Entity> EJIAHCPIPFJ, bool HBNKIDFHDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x26952A0", Offset = "0x26944A0", VA = "0x1826952A0")]
		private NativeList<Entity> GIKMJGFKEMP(NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2695880", Offset = "0x2694A80", VA = "0x182695880")]
		private NativeList<Entity> MKHLLOIFMJJ(NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2695840", Offset = "0x2694A40", VA = "0x182695840")]
		private NativeList<Entity> JBOPPLPOFPC(NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2694910", Offset = "0x2693B10", VA = "0x182694910")]
		private NativeList<Entity> APDDFANKNKA(NativeArray<Entity> EJIAHCPIPFJ, bool KAHMHCGMHBH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2695690", Offset = "0x2694890", VA = "0x182695690")]
		private PGAFEBDIIOE HLNHBIMHDEB(NativeArray<Entity> EJIAHCPIPFJ)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(PGAFEBDIIOE);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2695E90", Offset = "0x2695090", VA = "0x182695E90")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService CFKBOIBHFGM;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B09930", Offset = "0x2B08B30", VA = "0x182B09930", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B09910", Offset = "0x2B08B10", VA = "0x182B09910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : MMOBGAEEAHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery POHHCMLMKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery COLJBNIAFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery OOMEJMJABDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery ABJOEIHMACE;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7E50", Offset = "0x2AB7050", VA = "0x182AB7E50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8010", Offset = "0x2AB7210", VA = "0x182AB8010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AB79D0", Offset = "0x2AB6BD0", VA = "0x182AB79D0")]
		private void IBDBAHNILDE(EntityQuery ADGIOFAMOGF, bool NAABJGGIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7C10", Offset = "0x2AB6E10", VA = "0x182AB7C10")]
		private void OCIAEBHBBDO(EntityQuery ADGIOFAMOGF, bool NAABJGGIBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class AssignPlayerIdsSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery FJMOOPKKFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery KBFHHELECLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService DCDCBKEJKDG;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2DF0", Offset = "0x2AA1FF0", VA = "0x182AA2DF0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2CC0", Offset = "0x2AA1EC0", VA = "0x182AA2CC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2DD0", Offset = "0x2AA1FD0", VA = "0x182AA2DD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2830", Offset = "0x2AA1A30", VA = "0x182AA2830")]
		private void EDAFGGNFOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26C0", Offset = "0x2AA18C0", VA = "0x182AA26C0")]
		private void ECMPECOMPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA29A0", Offset = "0x2AA1BA0", VA = "0x182AA29A0")]
		private void MAOJJOEGDMB(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2580", Offset = "0x2AA1780", VA = "0x182AA2580")]
		private void BDPBHJCOHKM(NativeArray<Entity> EJIAHCPIPFJ, int PHCCEBCFBED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2470", Offset = "0x2AA1670", VA = "0x182AA2470")]
		private void AMJBBLFKIBL(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2940", Offset = "0x2AA1B40", VA = "0x182AA2940")]
		private void JHILHNHNBKB(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void KJMFIFKANJO(int PCKCPNGPNBJ, Transform FGNGGLFNLIP, Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class GBPMINIGOJB
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x269D560", Offset = "0x269C760", VA = "0x18269D560")]
	public static bool LGBNDPMGBEF(this SystemBase NHEJJBLKANC, out Entity LHCPLOHKBCE)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery CEDMJFMHNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private CNBEKDOCLNI PFLGLMCPODE;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA1D0", Offset = "0x2AA93D0", VA = "0x182AAA1D0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA0A0", Offset = "0x2AA92A0", VA = "0x182AAA0A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA160", Offset = "0x2AA9360", VA = "0x182AAA160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<EKHFGCPHKOH>, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string IPAGKDPDPEK = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private MBILFEPAMHC AGOMPJDPMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery JNPFKLHOJKD;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity BINEEKEMIJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2AEEFD0", Offset = "0x2AEE1D0", VA = "0x182AEEFD0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF430", Offset = "0x2AEE630", VA = "0x182AEF430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity JJMGPEKOABC
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF3D0", Offset = "0x2AEE5D0", VA = "0x182AEF3D0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public HPHBHAKAACD DLNNBLFHFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF500", Offset = "0x2AEE700", VA = "0x182AEF500")]
			get
			{
				return default(HPHBHAKAACD);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF490", Offset = "0x2AEE690", VA = "0x182AEF490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public HPHBHAKAACD IBJFDHHGLNB
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF6E0", Offset = "0x2AEE8E0", VA = "0x182AEF6E0")]
			get
			{
				return default(HPHBHAKAACD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF860", Offset = "0x2AEEA60", VA = "0x182AEF860", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF980", Offset = "0x2AEEB80", VA = "0x182AEF980", Slot = "15")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF900", Offset = "0x2AEEB00", VA = "0x182AEF900", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF590", Offset = "0x2AEE790", VA = "0x182AEF590", Slot = "14")]
		protected override void MANIFALKNOL(NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> BMPGOIMGDGM, NativeArray<Entity> MJDCMBNHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF2F0", Offset = "0x2AEE4F0", VA = "0x182AEF2F0")]
		private void CPGBABAMLOD(NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> MJDCMBNHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF030", Offset = "0x2AEE230", VA = "0x182AEF030")]
		private void CBCBMMLNMJI(Entity LHCPLOHKBCE, Entity BAGJEIJOHOF, Entity IKJDKBEABNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x13AAB10", Offset = "0x13A9D10", VA = "0x1813AAB10")]
		private bool IJDPOKFHBJA<T>(out T IPMIIEAGJKC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x13AAA50", Offset = "0x13A9C50", VA = "0x1813AAA50")]
		private void AOHLPHLILHI<T>(T IPMIIEAGJKC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF7A0", Offset = "0x2AEE9A0", VA = "0x182AEF7A0")]
		public bool OGBOJBOHBOC(HPHBHAKAACD FMNHDNOKLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF770", Offset = "0x2AEE970", VA = "0x182AEF770")]
		private static bool OABHJJCLEOL(HPHBHAKAACD DNHJLMOFCIK, HPHBHAKAACD PFIAPJLFMHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFA40", Offset = "0x2AEEC40", VA = "0x182AEFA40")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF820", Offset = "0x2AEEA20", VA = "0x182AEF820", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2BC0", Offset = "0x2AB1DC0", VA = "0x182AB2BC0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB26D0", Offset = "0x2AB18D0", VA = "0x182AB26D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2770", Offset = "0x2AB1970", VA = "0x182AB2770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2580", Offset = "0x2AB1780", VA = "0x182AB2580")]
		private NativeArray<Entity> NDLGJBEGHCA(int BFFJHKFEFPP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2470", Offset = "0x2AB1670", VA = "0x182AB2470")]
		private void ENCFFKKINPF(NativeArray<Entity> AEEEEDPKLJD, NativeArray<Entity> AKOIOBGGCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	internal class HideRemotePivotsNotInScope : HDACKBGFGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery GIEIIMHNAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery DJIIMKGGDLG;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x26A2CD0", Offset = "0x26A1ED0", VA = "0x1826A2CD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x26A2DC0", Offset = "0x26A1FC0", VA = "0x1826A2DC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class GLAGMJGBEFL
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string LDJDDFBFMOA = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x22662B0", Offset = "0x22654B0", VA = "0x1822662B0")]
	public static NativeArray<T> CDNGCOKBPLF<T>(NativeArray<Entity> EJIAHCPIPFJ, EntityManager IIODDCGHDHF) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x269E240", Offset = "0x269D440", VA = "0x18269E240")]
	public static void GANEELBKIBB(EntityQuery ADGIOFAMOGF, EntityManager IIODDCGHDHF, FMAHBOCPDMM GLPABBNKNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x269E4B0", Offset = "0x269D6B0", VA = "0x18269E4B0")]
	public static void KIGOEOGGOIE(NativeArray<Entity> AEEEEDPKLJD, FMAHBOCPDMM GLPABBNKNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x269E380", Offset = "0x269D580", VA = "0x18269E380")]
	public static void KHOBFLCGMGH(NativeArray<Entity> AEEEEDPKLJD, FMAHBOCPDMM GLPABBNKNEO)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService FBCDDJGNMEF;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x271AAD0", Offset = "0x2719CD0", VA = "0x18271AAD0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x271AA20", Offset = "0x2719C20", VA = "0x18271AA20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x271AAC0", Offset = "0x2719CC0", VA = "0x18271AAC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2719940", Offset = "0x2718B40", VA = "0x182719940")]
		private void JHLBINDBJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x27193A0", Offset = "0x27185A0", VA = "0x1827193A0")]
		private void EMGECJLMFFN(NativeArray<Entity> AEEEEDPKLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x271A150", Offset = "0x2719350", VA = "0x18271A150")]
		private void LCEFGLNPONO(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2719150", Offset = "0x2718350", VA = "0x182719150")]
		private void CGDLDDECEKH(NativeArray<Entity> AKOIOBGGCLN, NativeArray<RigidTransform> JIKGJMGGFGF, NativeArray<RigidTransform> EABEGECCOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x27194B0", Offset = "0x27186B0", VA = "0x1827194B0")]
		private void GGMDFFNFBIG(NativeArray<RigidTransform> EABEGECCOOI, NativeArray<Entity> AKOIOBGGCLN, NativeList<Entity> IBOICNIHHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class PostGameplayOnScopeChange : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery CEDMJFMHNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery HOEAFMJDKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2B080D0", Offset = "0x2B072D0", VA = "0x182B080D0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2B07EC0", Offset = "0x2B070C0", VA = "0x182B07EC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2B08010", Offset = "0x2B07210", VA = "0x182B08010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2B07E50", Offset = "0x2B07050", VA = "0x182B07E50")]
		private void OHLHEJKOJIF(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal class PreventDisembodiedScopesSystem : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery DOMBNNEIHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents BDDHHHHDEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private CNBEKDOCLNI PFLGLMCPODE;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2B097C0", Offset = "0x2B089C0", VA = "0x182B097C0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2B09720", Offset = "0x2B08920", VA = "0x182B09720", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D10", Offset = "0x2AB0F10", VA = "0x182AB1D10", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2B09590", Offset = "0x2B08790", VA = "0x182B09590")]
		private void GFGDJDNHOKK(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<BGALNCIPCCM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2704EA0", Offset = "0x27040A0", VA = "0x182704EA0", Slot = "14")]
		protected override void MANIFALKNOL(NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> BMPGOIMGDGM, NativeArray<Entity> MJDCMBNHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2704DD0", Offset = "0x2703FD0", VA = "0x182704DD0")]
		[BurstCompile]
		private static void MANIFALKNOL(NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> MJDCMBNHPCK, ComponentDataFromEntity<global::DNKGHNHAJPL> JOGPJKHLFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2705030", Offset = "0x2704230", VA = "0x182705030")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2704FF0", Offset = "0x27041F0", VA = "0x182704FF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : HDACKBGFGDN where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery APOPENKHGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery HJAOMNBFEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery JCNEOMGJFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery LFDCNBFNNJC;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x29D7570", Offset = "0x29D6770", VA = "0x1829D7570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x29D7770", Offset = "0x29D6970", VA = "0x1829D7770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x29D7740", Offset = "0x29D6940", VA = "0x1829D7740", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x29D5AA0", Offset = "0x29D4CA0", VA = "0x1829D5AA0")]
		private void BIAOEHDCKMF(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x29D6FB0", Offset = "0x29D61B0", VA = "0x1829D6FB0")]
		private void KABBCDNPGDN(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x29D6770", Offset = "0x29D5970", VA = "0x1829D6770")]
		private void CJBJNMDKDNB(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void MANIFALKNOL(NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> BMPGOIMGDGM, NativeArray<Entity> MJDCMBNHPCK);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2777340", Offset = "0x2776540", VA = "0x182777340")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x895C20", Offset = "0x894E20", VA = "0x180895C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class KBNMMFBLAEM : HDACKBGFGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> KECMGBIFIHE;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x26ADD40", Offset = "0x26ACF40", VA = "0x1826ADD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x26ADF40", Offset = "0x26AD140", VA = "0x1826ADF40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x26AE090", Offset = "0x26AD290", VA = "0x1826AE090")]
	public KBNMMFBLAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct CMJPFHMJHLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int BCGMDEIHEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int OLGKJALIAAI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70B0", Offset = "0x2AA62B0", VA = "0x182AA70B0")]
	public static Entity GJGPFJHFLAE(CMJPFHMJHLI PCPEJHIMHJJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70B0", Offset = "0x2AA62B0", VA = "0x182AA70B0")]
	public static CMJPFHMJHLI GJGPFJHFLAE(Entity LHCPLOHKBCE)
	{
		return default(CMJPFHMJHLI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct KGIIEJHICNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct OKIOMKCAIII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType KBJJKACLINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> EMBOJIFBMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> FNDBBIGHECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> EJIAHCPIPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> FIBGFGODECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> GHAEJDCDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> IJHMKEIOKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int PMIDHLBPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int DAJGDABIDON;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool OOBIHDFKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2AF41C0", Offset = "0x2AF33C0", VA = "0x182AF41C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2AF44F0", Offset = "0x2AF36F0", VA = "0x182AF44F0")]
	public OKIOMKCAIII(ComponentType KBJJKACLINM, NativeList<int> EMBOJIFBMBL, NativeList<int> FNDBBIGHECH, NativeArray<Entity> EJIAHCPIPFJ, NativeArray<Entity> FIBGFGODECA, NativeArray<byte> GHAEJDCDBBB, NativeArray<byte> IJHMKEIOKHN, int PMIDHLBPJEL, int DAJGDABIDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4320", Offset = "0x2AF3520", VA = "0x182AF4320")]
	private NFKEKJGDLJI EOIONOGJGKK(NativeArray<byte> HAHPMNMCEBD, int GMEHLIHLGEH)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T EOIONOGJGKK<T>(NativeArray<byte> HAHPMNMCEBD, int GMEHLIHLGEH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF44A0", Offset = "0x2AF36A0", VA = "0x182AF44A0")]
	public NFKEKJGDLJI PKPAJGCMENB(int GMEHLIHLGEH)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T PKPAJGCMENB<T>(int GMEHLIHLGEH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4450", Offset = "0x2AF3650", VA = "0x182AF4450")]
	public NFKEKJGDLJI ILKDCLEIKOP(int GMEHLIHLGEH)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T ILKDCLEIKOP<T>(int GMEHLIHLGEH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4240", Offset = "0x2AF3440", VA = "0x182AF4240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct HGFCKIBIOML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<IJOFHBBNGNE> BBBOEOJJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType KBJJKACLINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int PMIDHLBPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int DAJGDABIDON;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x26A0220", Offset = "0x269F420", VA = "0x1826A0220")]
	public HGFCKIBIOML(ComponentType KBJJKACLINM, int PMIDHLBPJEL, int DAJGDABIDON, EntityQuery ADGIOFAMOGF, NativeArray<IJOFHBBNGNE> BBBOEOJJCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x26A01D0", Offset = "0x269F3D0", VA = "0x1826A01D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct CEJEEOHLKOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int GMEHLIHLGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int EBBNMKKOLJD;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
	public CEJEEOHLKOA(int GMEHLIHLGEH, int EBBNMKKOLJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct IJOFHBBNGNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int MOHMCFDNHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int CAPKFCHDLFA;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
	public IJOFHBBNGNE(int MOHMCFDNHKH, int CAPKFCHDLFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct DDBPAPBBEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly GFCMOFDOMMJ IKHNIJKGJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int PMIDHLBPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* GHAEJDCDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* IJHMKEIOKHN;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4870", Offset = "0x2AB3A70", VA = "0x182AB4870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public GFCMOFDOMMJ GHIEHEOOCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360")]
		get
		{
			return default(GFCMOFDOMMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4780", Offset = "0x2AB3980", VA = "0x182AB4780")]
	public NFKEKJGDLJI CJLKNCLAAON(Type NIFOGEBEDNG)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4880", Offset = "0x2AB3A80", VA = "0x182AB4880")]
	public NFKEKJGDLJI GAIACPLEOKN(Type NIFOGEBEDNG)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x116F3D0", Offset = "0x116E5D0", VA = "0x18116F3D0")]
	public T CJLKNCLAAON<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x116F3F0", Offset = "0x116E5F0", VA = "0x18116F3F0")]
	public T GAIACPLEOKN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4970", Offset = "0x2AB3B70", VA = "0x182AB4970")]
	public unsafe DDBPAPBBEPF(GFCMOFDOMMJ IKHNIJKGJFD, int CAPKFCHDLFA, byte* GHAEJDCDBBB, byte* IJHMKEIOKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class GJMDMCAOEHH : HCIIOJALALA, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService CNOPCHGAFOK;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract JJFNDNAGMHB DANJJKHIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x269DFF0", Offset = "0x269D1F0", VA = "0x18269DFF0", Slot = "17")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x269DF60", Offset = "0x269D160", VA = "0x18269DF60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x269DD20", Offset = "0x269CF20", VA = "0x18269DD20", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	protected GJMDMCAOEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class FMHFHHJABAA
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] NBFGFFLBJKJ;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class LAOCDEHPEDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, HGFCKIBIOML> AJIFNGCHGMH;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public HGFCKIBIOML POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x26B15E0", Offset = "0x26B07E0", VA = "0x1826B15E0")]
		get
		{
			return default(HGFCKIBIOML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x26B0C10", Offset = "0x26AFE10", VA = "0x1826B0C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x26B1670", Offset = "0x26B0870", VA = "0x1826B1670")]
	public LAOCDEHPEDM(DGHIBPMIJHM HIJDILOKICJ, HDHIMOFHFJL AHADDDAMGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x26B0E90", Offset = "0x26B0090", VA = "0x1826B0E90")]
	public bool HOAIDNCFMEI(ComponentType KBJJKACLINM, out HGFCKIBIOML CAKDMLJEJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x26B0C60", Offset = "0x26AFE60", VA = "0x1826B0C60")]
	public Dictionary<ComponentType, HGFCKIBIOML>.Enumerator BECNODPGHJK()
	{
		return default(Dictionary<ComponentType, HGFCKIBIOML>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x26B0CF0", Offset = "0x26AFEF0", VA = "0x1826B0CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x26B1130", Offset = "0x26B0330", VA = "0x1826B1130")]
	private void MIOHNHICGLA(IEnumerable<CMBJNHHMHON> IINPKGMDEIC, EntityManager IIODDCGHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x26B1530", Offset = "0x26B0730", VA = "0x1826B1530")]
	private static int NJLOCGOLFDD(CMBJNHHMHON NJABIIDPGKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x26B0F00", Offset = "0x26B0100", VA = "0x1826B0F00")]
	private static NativeArray<IJOFHBBNGNE> ICOMEMBBIHH(CMBJNHHMHON NJABIIDPGKD, Allocator HCEMBCPANJM = Allocator.Persistent)
	{
		return default(NativeArray<IJOFHBBNGNE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface GIDNMOCOABH
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool OOBIHDFKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World ADMAJPELGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGHKEMBOAJP(out NativeArray<int> BEBLJFCKMDD, Allocator HCEMBCPANJM);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGPJALOKCOD(ComponentType KBJJKACLINM, out OKIOMKCAIII NGBEMEAOCPB, out HGFCKIBIOML FMEBKGHCHLH);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DGPJALOKCOD(ComponentType KBJJKACLINM, out OKIOMKCAIII NGBEMEAOCPB);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OKIOMKCAIII OOHPKGAIGPO(ComponentType KBJJKACLINM);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LFKHECFMCND EDEPLHCIGNP();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKHIBHLBPGA(JobHandle KBGHJIGDKDL);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
internal interface LENAHHJHMLI
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World ADMAJPELGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	LAOCDEHPEDM IDHLDBDPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	IKNFBHNFDLA BIGBMJHCBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, DDBPAPBBEPF> EJGIDEHOLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle GKLGPNJCEAK
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
	bool LLLPMINBGLL();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLBPPAIACJF();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBLBIGMBGLL(ComponentType KBJJKACLINM, in OKIOMKCAIII GPIEHJALFCH);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BABAPIOCGOP(CNKGPKGDJHD FNGBDAJENGB, out Entity GDEKLMNKJBC);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct LFKHECFMCND
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct GNFAJJHPOHL : IEnumerator<DDBPAPBBEPF>, IEnumerator, IDisposable, IEnumerable<DDBPAPBBEPF>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, DDBPAPBBEPF> GHKLFJFOHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity LHCPLOHKBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> DBHFCNAFJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private DDBPAPBBEPF IJHMKEIOKHN;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public DDBPAPBBEPF DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x17591C0", Offset = "0x17583C0", VA = "0x1817591C0", Slot = "4")]
			get
			{
				return default(DDBPAPBBEPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x34D2C70", Offset = "0x34D1E70", VA = "0x1834D2C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x34D2CC0", Offset = "0x34D1EC0", VA = "0x1834D2CC0")]
		internal GNFAJJHPOHL(NativeMultiHashMap<Entity, DDBPAPBBEPF> GHKLFJFOHKO, Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x34D2A60", Offset = "0x34D1C60", VA = "0x1834D2A60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x34D2A30", Offset = "0x34D1C30", VA = "0x1834D2A30")]
		public GNFAJJHPOHL BECNODPGHJK()
		{
			return default(GNFAJJHPOHL);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x34D2B30", Offset = "0x34D1D30", VA = "0x1834D2B30", Slot = "9")]
		private IEnumerator<DDBPAPBBEPF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x34D2BD0", Offset = "0x34D1DD0", VA = "0x1834D2BD0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly LENAHHJHMLI DADHJJNJEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle FAEPBILJHEE;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int DMOFHIMEKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x26B3A50", Offset = "0x26B2C50", VA = "0x1826B3A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x26B3DA0", Offset = "0x26B2FA0", VA = "0x1826B3DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9B60", Offset = "0x1BF8D60", VA = "0x181BF9B60")]
	public LFKHECFMCND(LENAHHJHMLI DADHJJNJEFA, JobHandle FAEPBILJHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x26B3C60", Offset = "0x26B2E60", VA = "0x1826B3C60")]
	public bool PLODAEHFNBF(Allocator HCEMBCPANJM, out NativeKeyValueArrays<Entity, DDBPAPBBEPF> CDNLFEOBNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x26B38E0", Offset = "0x26B2AE0", VA = "0x1826B38E0")]
	public bool COLHJGJAJMM(Allocator HCEMBCPANJM, out (NativeArray<Entity> entities, int uniqueCount) CDNLFEOBNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x26B3B40", Offset = "0x26B2D40", VA = "0x1826B3B40")]
	public GNFAJJHPOHL KMGJNALEMNF(Entity LHCPLOHKBCE)
	{
		return default(GNFAJJHPOHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class IKNFBHNFDLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<HGFCKIBIOML> JAAGBDPDCIE;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public HGFCKIBIOML POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x26A8E90", Offset = "0x26A8090", VA = "0x1826A8E90")]
		get
		{
			return default(HGFCKIBIOML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x26A8950", Offset = "0x26A7B50", VA = "0x1826A8950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x26A8F20", Offset = "0x26A8120", VA = "0x1826A8F20")]
	public IKNFBHNFDLA(LAOCDEHPEDM AJIFNGCHGMH, DGHIBPMIJHM HIJDILOKICJ, HDHIMOFHFJL AHADDDAMGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x26A8990", Offset = "0x26A7B90", VA = "0x1826A8990")]
	public List<HGFCKIBIOML>.Enumerator BECNODPGHJK()
	{
		return default(List<HGFCKIBIOML>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x26A8A10", Offset = "0x26A7C10", VA = "0x1826A8A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x26A8B80", Offset = "0x26A7D80", VA = "0x1826A8B80")]
	private void MIOHNHICGLA(LAOCDEHPEDM AJIFNGCHGMH, EntityManager IIODDCGHDHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class DLLMPOAHENO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService ELFOBADGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::LCDGDDNFDOO<CMBJNHHMHON> ODJAIHADIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World COKIOKOGLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> CGLICANDEMK;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7800", Offset = "0x2AB6A00", VA = "0x182AB7800")]
	public DLLMPOAHENO(ObjectInstantiationService ELFOBADGBAE, DGHIBPMIJHM HIJDILOKICJ, HDHIMOFHFJL AHADDDAMGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6100", Offset = "0x2AB5300", VA = "0x182AB6100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB73B0", Offset = "0x2AB65B0", VA = "0x182AB73B0")]
	public bool NCFAIABJPND(CNKGPKGDJHD FNGBDAJENGB, out Entity GDEKLMNKJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6D50", Offset = "0x2AB5F50", VA = "0x182AB6D50")]
	private void MFIFDAHBFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6310", Offset = "0x2AB5510", VA = "0x182AB6310")]
	private EntityArchetype GDPPFPMMIJA(EntityArchetype EBPEFCGLPIL)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6840", Offset = "0x2AB5A40", VA = "0x182AB6840")]
	public static void IJODOKDOFKI(EntityManager MPHGLGFGOMF, EntityManager CJHLNLGDMLM, NativeArray<Entity> HNLMOMAOEAN, NativeArray<EntityArchetype> GLMMCHCGFFD, [Optional] NativeArray<Entity> GIGFNEHBBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5F90", Offset = "0x2AB5190", VA = "0x182AB5F90")]
	[Conditional("DEBUG_BUILD")]
	private static void CMCBCDKDNKF(NativeArray<EntityArchetype> IIMOMEKGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB75C0", Offset = "0x2AB67C0", VA = "0x182AB75C0")]
	private static string OJHDDHFCNCK(EntityArchetype AOOCNFHGCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB61D0", Offset = "0x2AB53D0", VA = "0x182AB61D0")]
	[CompilerGenerated]
	internal static void FHPGOMBEBHC(ref Span<ComponentType> MKLAILNPNJE, ComponentType IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7410", Offset = "0x2AB6610", VA = "0x182AB7410")]
	[CompilerGenerated]
	internal static void OALKCPJLBGB(Span<ComponentType> HAHPMNMCEBD, ref Span<ComponentType> MKLAILNPNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6C70", Offset = "0x2AB5E70", VA = "0x182AB6C70")]
	[CompilerGenerated]
	internal static void KNKFGCDCAAA(Span<ComponentType> HAHPMNMCEBD, ref Span<ComponentType> MKLAILNPNJE, ComponentType AEOCFALMHIC)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CGDKNMKPKIP(OOBCCNCEGNI.PropertyChanges)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld FJPBFEGLNAN;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA23B0", Offset = "0x2AA15B0", VA = "0x182AA23B0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2300", Offset = "0x2AA1500", VA = "0x182AA2300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[CGDKNMKPKIP(OOBCCNCEGNI.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : HDACKBGFGDN, CMLEAAEGAAL, BDLDACMOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct GGBPPMIMNHP : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> OGKBJLOOHCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> PHFOHINJNBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<IJOFHBBNGNE> IGAEILAANOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<CEJEEOHLKOA>.ParallelWriter PGJBKEIHPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int AHFKBJNPCKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int PIHNBEDHGDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker LOFDOFOMGJG;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x26FE9D0", Offset = "0x26FDBD0", VA = "0x1826FE9D0", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x26FEB10", Offset = "0x26FDD10", VA = "0x1826FEB10")]
			private unsafe int KHFNIHJDDHF(byte* DOMMFFPFHDJ, byte* KLEOIMLJIAC)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct HOMJIBGELGE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> EMBOJIFBMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> AGLJKDAPFAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<CEJEEOHLKOA> HAGNIOBGLCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker LOFDOFOMGJG;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x26FEBA0", Offset = "0x26FDDA0", VA = "0x1826FEBA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct NAFOIACBILL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> NCBHAOJFAAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity DPODNMOCBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int PMIDHLBPJEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker LOFDOFOMGJG;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x26FFFC0", Offset = "0x26FF1C0", VA = "0x1826FFFC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct ILBCLCBIDGM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, DDBPAPBBEPF> PNDNLPIACIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> GHAEJDCDBBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> IJHMKEIOKHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<IJOFHBBNGNE> CMPFJBOLKIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> FNDBBIGHECH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> EMBOJIFBMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int HHAKOPGLLAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int DAJGDABIDON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker LOFDOFOMGJG;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x26FEC80", Offset = "0x26FDE80", VA = "0x1826FEC80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker BECHCOCILMC;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker KADBIEGLJGK;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker ALFCIDKLGML;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker LKJOBHKNJIB;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker IOLANPDEBAD;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker BOODBCPOIIM;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker FOFPDLCDOPK;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker NFOLDPCMEKP;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker KMIINPFGECK;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker PDBELOJKMIA;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker NHDELGGBDGB;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker IMDOBNCLPBP;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker OPIEPDLIMJD;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker PPHFPDMJAKO;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker PHCMDAGFGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService CNOPCHGAFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery BBFFIDPIKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery OHCNCHBJJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery PFIMNLNCAFF;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World ADMAJPELGCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD120", Offset = "0x2AAC320", VA = "0x182AAD120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private LENAHHJHMLI MLHPFDHGDIL
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2AAC900", Offset = "0x2AABB00", VA = "0x182AAC900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD4E0", Offset = "0x2AAC6E0", VA = "0x182AAD4E0", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "15")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD1E0", Offset = "0x2AAC3E0", VA = "0x182AAD1E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD3A0", Offset = "0x2AAC5A0", VA = "0x182AAD3A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD330", Offset = "0x2AAC530", VA = "0x182AAD330", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC640", Offset = "0x2AAB840", VA = "0x182AAC640")]
		private void KIODMPJLPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC920", Offset = "0x2AABB20", VA = "0x182AAC920")]
		internal void OEHAIENNKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC940", Offset = "0x2AABB40", VA = "0x182AAC940")]
		private void OEHAIENNKMN(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB530", Offset = "0x2AAA730", VA = "0x182AAB530")]
		private void DOPALOCGLLK(NativeArray<Entity> HNLMOMAOEAN, NativeArray<RRObjectPrefabData> HJAEKCBMJJF, ref NativeArray<Entity> HCIEBGLOCEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB900", Offset = "0x2AAAB00", VA = "0x182AAB900")]
		internal void FHBPHEGGGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB920", Offset = "0x2AAAB20", VA = "0x182AAB920")]
		private void FHBPHEGGGNO(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AABEE0", Offset = "0x2AAB0E0", VA = "0x182AABEE0")]
		internal void JPJABKGDNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB120", Offset = "0x2AAA320", VA = "0x182AAB120")]
		private void DJMHALNMGIH(LENAHHJHMLI DADHJJNJEFA, HGFCKIBIOML FMEBKGHCHLH, bool BKAGPIIIGFA, ref JobHandle KPABLFGDBBC, ref JobHandle OCJCBGGHEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB0F0", Offset = "0x2AAA2F0", VA = "0x182AAB0F0")]
		internal bool CGIDHFPBIJN(in HGFCKIBIOML KLEOIMLJIAC, out JobHandle PLFCHHKILCM, out OKIOMKCAIII DNJJIOJKPGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA6F0", Offset = "0x2AA98F0", VA = "0x182AAA6F0")]
		private bool CGIDHFPBIJN(in HGFCKIBIOML KLEOIMLJIAC, bool BKAGPIIIGFA, out JobHandle PLFCHHKILCM, out OKIOMKCAIII DNJJIOJKPGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AABD20", Offset = "0x2AAAF20", VA = "0x182AABD20")]
		internal (NativeList<int>, NativeList<int>) GDPCKCHLDLO(NativeList<CEJEEOHLKOA> HAGNIOBGLCF, int FAPOEIDOLFP, JobHandle BPJJMMFHOJB, out JobHandle KBGHJIGDKDL, Allocator HCEMBCPANJM = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB400", Offset = "0x2AAA600", VA = "0x182AAB400")]
		internal static NativeArray<Entity> DKILCJDLLJA(EntityQuery ADGIOFAMOGF, out JobHandle EJLGGBCFBNE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB4B0", Offset = "0x2AAA6B0", VA = "0x182AAB4B0")]
		internal static NativeArray<byte> DOLKEIOONEE(int ODBGNNDKAMK, out JobHandle HOJJDHJPKKD)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA270", Offset = "0x2AA9470", VA = "0x182AAA270")]
		internal static NativeArray<byte> BACPAGOLLFA(EntityQuery ADGIOFAMOGF, int BEBJDDHDFCD, out JobHandle HOJJDHJPKKD)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA5F0", Offset = "0x2AA97F0", VA = "0x182AAA5F0")]
		internal static NativeArray<Entity> BNKPIELLHNO(EntityQuery ADGIOFAMOGF, out JobHandle KJAAEOKDIFF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA380", Offset = "0x2AA9580", VA = "0x182AAA380")]
		internal NativeArray<byte> BEBJOCLBAOI(NativeArray<Entity> EJIAHCPIPFJ, HGFCKIBIOML FMEBKGHCHLH, JobHandle BPJJMMFHOJB, out JobHandle KBGHJIGDKDL, Allocator HCEMBCPANJM = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB770", Offset = "0x2AAA970", VA = "0x182AAB770")]
		internal JobHandle EKINMHHMHGN(in OKIOMKCAIII PCPEJHIMHJJ, in HGFCKIBIOML FMEBKGHCHLH, NativeMultiHashMap<Entity, DDBPAPBBEPF> PNDNLPIACIN, JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1725820", Offset = "0x1724A20", VA = "0x181725820")]
		private JobHandle DKPENFGKEHC(JobHandle BIILOAMBLJF, JobHandle LPMLLFHIDDO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1725820", Offset = "0x1724A20", VA = "0x181725820")]
		private JobHandle DKPENFGKEHC(JobHandle BIILOAMBLJF, JobHandle LPMLLFHIDDO, JobHandle JOGNLGCGICA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CGDKNMKPKIP(OOBCCNCEGNI.RenderEffects)]
	internal class PropagateHoverRootTag : FMFJLEJCFKG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct GLEAPJNHGON : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType CKBKGNNPFML
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A180", Offset = "0x2B09380", VA = "0x182B0A180", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType KCMCCINKDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A150", Offset = "0x2B09350", VA = "0x182B0A150", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType GOGHPKEOPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A120", Offset = "0x2B09320", VA = "0x182B0A120", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A1B0", Offset = "0x2B093B0", VA = "0x182B0A1B0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.RenderEffects)]
	internal class PropagateSelectionRootTag : FMFJLEJCFKG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct IFBALBKGEDE : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType CKBKGNNPFML
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A220", Offset = "0x2B09420", VA = "0x182B0A220", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType KCMCCINKDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A1F0", Offset = "0x2B093F0", VA = "0x182B0A1F0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType GOGHPKEOPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A1C0", Offset = "0x2B093C0", VA = "0x182B0A1C0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A1B0", Offset = "0x2B093B0", VA = "0x182B0A1B0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[LJPJOHADJCO]
public class OBEONDJGEED : MMOBGAEEAHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AF39C0", Offset = "0x2AF2BC0", VA = "0x182AF39C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3A50", Offset = "0x2AF2C50", VA = "0x182AF3A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public OBEONDJGEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[LJPJOHADJCO]
public class JPAKNLHNNAC : MMOBGAEEAHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct FMPPHOCNHMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public FMPPHOCNHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct HCONBJIMDOH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct CLHNDOEAMIA
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct LNKBLEAKBJH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime KGMDLKAOIOP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NJPFBAEPAAK;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x34CFA90", Offset = "0x34CEC90", VA = "0x1834CFA90")]
			public void JNNOBNMLOFO(JPAKNLHNNAC GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x34CFA10", Offset = "0x34CEC10", VA = "0x1834CFA10")]
			public LNKBLEAKBJH CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(LNKBLEAKBJH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> OHPNELPBKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private CLHNDOEAMIA JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CLHNDOEAMIA.LNKBLEAKBJH* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KKLOFDFCEDG;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x34D3500", Offset = "0x34D2700", VA = "0x1834D3500")]
		internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, SplinePointParentData PDFEDMAOMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x34D3570", Offset = "0x34D2770", VA = "0x1834D3570", Slot = "5")]
		public void ReadFromDisplayClass(ref FMPPHOCNHMB AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x34D3580", Offset = "0x34D2780", VA = "0x1834D3580", Slot = "6")]
		public void WriteToDisplayClass(ref FMPPHOCNHMB AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x34D3320", Offset = "0x34D2520", VA = "0x1834D3320", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x34D3450", Offset = "0x34D2650", VA = "0x1834D3450")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref CLHNDOEAMIA.LNKBLEAKBJH CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x34D33C0", Offset = "0x34D25C0", VA = "0x1834D33C0")]
		public void JNNOBNMLOFO(JPAKNLHNNAC GEIMOJMNBNO, ref FMPPHOCNHMB AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x34D32B0", Offset = "0x34D24B0", VA = "0x1834D32B0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery JGDCILGJDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker OKBJJHOKJLA;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x26AD960", Offset = "0x26ACB60", VA = "0x1826AD960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public JPAKNLHNNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x26AD730", Offset = "0x26AC930", VA = "0x1826AD730", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x26AD5D0", Offset = "0x26AC7D0", VA = "0x1826AD5D0")]
	public static EntityQuery AADDANJMHCD(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[LJPJOHADJCO]
public class MHCFIGIJKHD : MMOBGAEEAHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery BAKIKAOMMEP;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFA80", Offset = "0x2AEEC80", VA = "0x182AEFA80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFB10", Offset = "0x2AEED10", VA = "0x182AEFB10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public MHCFIGIJKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(OBEONDJGEED))]
public class GKPKJDBKECD : HDACKBGFGDN
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x269E040", Offset = "0x269D240", VA = "0x18269E040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public GKPKJDBKECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class JFEDCDBLHNG : MMOBGAEEAHF, CMLEAAEGAAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct PALENJNHKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<HCIIHJLICJK, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public PALENJNHKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FCIOMOADMKI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct AFAMPKLAOAK
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct GLACFINOFAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DAKGBEKJFDG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> PNPMCHFOILD;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF20", Offset = "0x34CD120", VA = "0x1834CDF20")]
			public void JNNOBNMLOFO(JFEDCDBLHNG GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x34CDEA0", Offset = "0x34CD0A0", VA = "0x1834CDEA0")]
			public GLACFINOFAK CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(GLACFINOFAK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<HCIIHJLICJK, Entity> GHKLFJFOHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private AFAMPKLAOAK JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AFAMPKLAOAK.GLACFINOFAK* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x34D1F10", Offset = "0x34D1110", VA = "0x1834D1F10")]
		internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, ObjectNetworkIdComponentData MCEPFIINCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xE7E610", Offset = "0xE7D810", VA = "0x180E7E610", Slot = "5")]
		public void ReadFromDisplayClass(ref PALENJNHKLC AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2428D70", Offset = "0x2427F70", VA = "0x182428D70", Slot = "6")]
		public void WriteToDisplayClass(ref PALENJNHKLC AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x34D1D30", Offset = "0x34D0F30", VA = "0x1834D1D30", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x34D1E60", Offset = "0x34D1060", VA = "0x1834D1E60")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref AFAMPKLAOAK.GLACFINOFAK CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x34D1DD0", Offset = "0x34D0FD0", VA = "0x1834D1DD0")]
		public void JNNOBNMLOFO(JFEDCDBLHNG GEIMOJMNBNO, ref PALENJNHKLC AAEEIKBBKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x34D1CC0", Offset = "0x34D0EC0", VA = "0x1834D1CC0")]
		public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService BDHLICLKMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery JGDCILGJDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker OKBJJHOKJLA;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x26AD100", Offset = "0x26AC300", VA = "0x1826AD100", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x26ACFC0", Offset = "0x26AC1C0", VA = "0x1826ACFC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public JFEDCDBLHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x26ACDC0", Offset = "0x26ABFC0", VA = "0x1826ACDC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x26ACC60", Offset = "0x26ABE60", VA = "0x1826ACC60")]
	public static EntityQuery AADDANJMHCD(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class HPPIODNEFOM : MMOBGAEEAHF, CMLEAAEGAAL
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BLHEELHNCPH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct BDEDKADOCMM
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct GAAJPLMFLOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime HMJBDGJNLPK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> LJBIKMHNMIG;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x34CEB10", Offset = "0x34CDD10", VA = "0x1834CEB10")]
			public void JNNOBNMLOFO(HPPIODNEFOM GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x34CEA90", Offset = "0x34CDC90", VA = "0x1834CEA90")]
			public GAAJPLMFLOK CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
			{
				return default(GAAJPLMFLOK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HPPIODNEFOM ELGGMBKANPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private BDEDKADOCMM JBGAPHFLKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BDEDKADOCMM.GAAJPLMFLOK* BIKDLBDICKE;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x34CF050", Offset = "0x34CE250", VA = "0x1834CF050")]
		public void NKAIDNDKJJJ(Entity LHCPLOHKBCE, ParentData DHEOBDLENJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x34CEE80", Offset = "0x34CE080", VA = "0x1834CEE80", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x34CEFA0", Offset = "0x34CE1A0", VA = "0x1834CEFA0")]
		public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref BDEDKADOCMM.GAAJPLMFLOK CILGKBEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x34CEF20", Offset = "0x34CE120", VA = "0x1834CEF20")]
		public void JNNOBNMLOFO(HPPIODNEFOM GEIMOJMNBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x34CEE10", Offset = "0x34CE010", VA = "0x1834CEE10")]
		public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery JGDCILGJDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker OKBJJHOKJLA;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x26A2C70", Offset = "0x26A1E70", VA = "0x1826A2C70", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x26A2B60", Offset = "0x26A1D60", VA = "0x1826A2B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public HPPIODNEFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x26A2770", Offset = "0x26A1970", VA = "0x1826A2770")]
	[CompilerGenerated]
	private void NMMOKCLCICM(Entity LHCPLOHKBCE, ParentData DHEOBDLENJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x26A2960", Offset = "0x26A1B60", VA = "0x1826A2960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x26A2610", Offset = "0x26A1810", VA = "0x1826A2610")]
	public static EntityQuery AADDANJMHCD(ComponentSystemBase GEIMOJMNBNO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class LJJJDNBNCAE : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int IJBIBHCLBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery ADGIOFAMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs ELFOBADGBAE;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2AED8B0", Offset = "0x2AECAB0", VA = "0x182AED8B0", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2AED5F0", Offset = "0x2AEC7F0", VA = "0x182AED5F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2AED6D0", Offset = "0x2AEC8D0", VA = "0x182AED6D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2AED250", Offset = "0x2AEC450", VA = "0x182AED250")]
	private void BFCAMJCADPM(Entity LHCPLOHKBCE, CNKGPKGDJHD FNGBDAJENGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public LJJJDNBNCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	[UpdateBefore(typeof(LJJJDNBNCAE))]
	public class PostLoadAddSceneTagEntity : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService DCDCBKEJKDG;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2B08350", Offset = "0x2B07550", VA = "0x182B08350", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2B08190", Offset = "0x2B07390", VA = "0x182B08190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CFJADOACGIL(IHBBGOJDEFH.OMRoom)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	public class PostLoadInitializeNetworkId : HDACKBGFGDN, CMLEAAEGAAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct LHPLHBDMBCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<HCIIHJLICJK, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
			public LHPLHBDMBCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct OCPHFKLKHFL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct FABIDCBHPJJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct IBDPIMANNKB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime DKINPKKLKNB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DAKGBEKJFDG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex CHCDLKDFEKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> PNPMCHFOILD;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x34D1C50", Offset = "0x34D0E50", VA = "0x1834D1C50")]
				public void JNNOBNMLOFO(PostLoadInitializeNetworkId GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x34D1BA0", Offset = "0x34D0DA0", VA = "0x1834D1BA0")]
				public IBDPIMANNKB CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(IBDPIMANNKB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<HCIIHJLICJK, Entity> GHKLFJFOHKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private FABIDCBHPJJ JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FABIDCBHPJJ.IBDPIMANNKB* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KKLOFDFCEDG;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x34D9E80", Offset = "0x34D9080", VA = "0x1834D9E80")]
			internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, int JAEEHGILINA, ref ObjectNetworkIdComponentData MCEPFIINCGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xE7E610", Offset = "0xE7D810", VA = "0x180E7E610", Slot = "5")]
			public void ReadFromDisplayClass(ref LHPLHBDMBCJ AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2428D70", Offset = "0x2427F70", VA = "0x182428D70", Slot = "6")]
			public void WriteToDisplayClass(ref LHPLHBDMBCJ AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x34D9C20", Offset = "0x34D8E20", VA = "0x1834D9C20", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x34D9DB0", Offset = "0x34D8FB0", VA = "0x1834D9DB0")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref FABIDCBHPJJ.IBDPIMANNKB CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x34D9D10", Offset = "0x34D8F10", VA = "0x1834D9D10")]
			public void JNNOBNMLOFO(PostLoadInitializeNetworkId GEIMOJMNBNO, ref LHPLHBDMBCJ AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x34D9BB0", Offset = "0x34D8DB0", VA = "0x1834D9BB0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[GAJFPHPAPMA]
		private ObjectNetworkToLocalMapService BDHLICLKMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[GAJFPHPAPMA]
		private SceneService JIPLOFKCDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery ADGIOFAMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery BNEKHNAFJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker PPEGGOEFFNO;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B09150", Offset = "0x2B08350", VA = "0x182B09150", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2B090A0", Offset = "0x2B082A0", VA = "0x182B090A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2B09140", Offset = "0x2B08340", VA = "0x182B09140", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2B08D40", Offset = "0x2B07F40", VA = "0x182B08D40")]
		public void HFGINMJJLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2B087F0", Offset = "0x2B079F0", VA = "0x182B087F0")]
		private void GLHOODJMNFI(NativeHashMap<HCIIHJLICJK, Entity> GHKLFJFOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2B083F0", Offset = "0x2B075F0", VA = "0x182B083F0")]
		private void ECPKBIPILFB(NativeHashMap<HCIIHJLICJK, Entity> GHKLFJFOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2B08E10", Offset = "0x2B08010", VA = "0x182B08E10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2B08650", Offset = "0x2B07850", VA = "0x182B08650")]
		public static EntityQuery FBHDLGBJDPD(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class FBINBOMNGML : HDACKBGFGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery NANDDGGBFEI;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x26984C0", Offset = "0x26976C0", VA = "0x1826984C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2698550", Offset = "0x2697750", VA = "0x182698550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public FBINBOMNGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class APKMBIHBAEK : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::LCDGDDNFDOO<NDDLLHHFIJF> EBBJPCCOCNP;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1420", Offset = "0x2AA0620", VA = "0x182AA1420", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1120", Offset = "0x2AA0320", VA = "0x182AA1120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0780", Offset = "0x2A9F980", VA = "0x182AA0780")]
	private void IGHFFJIFBBP(NativeList<EntityArchetype> IIMOMEKGFJI, NativeHashMap<int, MFEHAEMCKCJ> FEACNFDHIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0F10", Offset = "0x2AA0110", VA = "0x182AA0F10")]
	private Span<int> JOKCANOJBCN(EntityArchetype AOOCNFHGCNI)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1050", Offset = "0x2AA0250", VA = "0x182AA1050")]
	private bool LPODJPMPKNN(int BEBJDDHDFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0910", Offset = "0x2A9FB10", VA = "0x182AA0910")]
	private void IPOOIBDFICJ(NativeHashMap<int, MFEHAEMCKCJ> FEACNFDHIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public APKMBIHBAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Serialization)]
	public class PreSerializeRemoveEntities : HDACKBGFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery MPOFLLDIHMK;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2B09210", Offset = "0x2B08410", VA = "0x182B09210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2B09490", Offset = "0x2B08690", VA = "0x182B09490", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CGDKNMKPKIP(OOBCCNCEGNI.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : HDACKBGFGDN, CMLEAAEGAAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct MDKPEJDOMFD
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
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
			public MDKPEJDOMFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x34CDF80", Offset = "0x34CD180", VA = "0x1834CDF80")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct LDDFEPCNECM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> EMBOJIFBMBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> FIBGFGODECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity EAFJHCKKEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> IJHMKEIOKHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int PMIDHLBPJEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType KBJJKACLINM;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x34D81D0", Offset = "0x34D73D0", VA = "0x1834D81D0")]
			internal void NKAIDNDKJJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x34D8390", Offset = "0x34D7590", VA = "0x1834D8390", Slot = "5")]
			public void ReadFromDisplayClass(ref MDKPEJDOMFD AAEEIKBBKHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x34D81A0", Offset = "0x34D73A0", VA = "0x1834D81A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x34D81B0", Offset = "0x34D73B0", VA = "0x1834D81B0")]
			public void JNNOBNMLOFO(ShadowWorldApplyPropertyDifferencesToShadowWorld GEIMOJMNBNO, ref MDKPEJDOMFD AAEEIKBBKHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService CNOPCHGAFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle KENDEOHIHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle JLPJNFKNDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private GIDNMOCOABH DADHJJNJEFA;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x270B320", Offset = "0x270A520", VA = "0x18270B320", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x270AC30", Offset = "0x2709E30", VA = "0x18270AC30")]
		public JobHandle AOJMCGNBNBG(JobHandle BPJJMMFHOJB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x270AF80", Offset = "0x270A180", VA = "0x18270AF80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x270AC70", Offset = "0x2709E70", VA = "0x18270AC70")]
		private bool GICOEKCDKGO(JobHandle BPJJMMFHOJB, int BEBJDDHDFCD, out JobHandle PKFECLMNIBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(MGAMFCCKDIP))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class CCHBOKEPBIC : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6280", Offset = "0x2AA5480", VA = "0x182AA6280", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public CCHBOKEPBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(AKLNEOINLAE))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class KPMOBAKPOOI : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x26AF890", Offset = "0x26AEA90", VA = "0x1826AF890", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public KPMOBAKPOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(FBFMLLJBOHO))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class EPIBEDEIOCK : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA440", Offset = "0x2AB9640", VA = "0x182ABA440", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public EPIBEDEIOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(HFNCMAAMEAD))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class CFNBPFBIHPJ : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6ED0", Offset = "0x2AA60D0", VA = "0x182AA6ED0", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public CFNBPFBIHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class BKHPGLDKNCJ : GJMDMCAOEHH
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override JJFNDNAGMHB DANJJKHIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x7A7AA0", Offset = "0x7A6CA0", VA = "0x1807A7AA0", Slot = "18")]
		get
		{
			return default(JJFNDNAGMHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3660", Offset = "0x2AA2860", VA = "0x182AA3660")]
	public BKHPGLDKNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(AOMBNDEGEDH))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class PPDCEGLCEMI : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2B03E40", Offset = "0x2B03040", VA = "0x182B03E40", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public PPDCEGLCEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class BDNCKCGLNEF : KDBBKADLGNC
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public BDNCKCGLNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class NKKDPPCAOFD : GJMDMCAOEHH
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override JJFNDNAGMHB DANJJKHIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "18")]
		get
		{
			return default(JJFNDNAGMHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3660", Offset = "0x2AA2860", VA = "0x182AA3660")]
	public NKKDPPCAOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[MPMKPCGOCAF]
[ExecuteAlways]
[UpdateInGroup(typeof(LCBCGAGCLLI))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class KEODNLPJGAL : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x26AE1F0", Offset = "0x26AD3F0", VA = "0x1826AE1F0", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public KEODNLPJGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class MCIJBFEDIFH : KDBBKADLGNC
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public MCIJBFEDIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class IGPKGFHIOCC : KDBBKADLGNC
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public IGPKGFHIOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class DBDFDIPODED : HDACKBGFGDN
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public DBDFDIPODED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[LJPJOHADJCO]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
public class HLEHBCKDFGP : HDACKBGFGDN, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService FNMIGFKCOMI;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x26A1840", Offset = "0x26A0A40", VA = "0x1826A1840", Slot = "14")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x26A1820", Offset = "0x26A0A20", VA = "0x1826A1820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public HLEHBCKDFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct KPOOOENBEHL : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float MPJIPFNOEKP = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> CLOLACPGMFL;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x26FF2F0", Offset = "0x26FE4F0", VA = "0x1826FF2F0", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x26FF2B0", Offset = "0x26FE4B0", VA = "0x1826FF2B0")]
			private bool EJJIKFFNCIK(float3 INPBMNIIHJJ, float3 HKPEMIJGIMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x26FF240", Offset = "0x26FE440", VA = "0x1826FF240")]
			private bool DOCFLOCLFLE(quaternion INPBMNIIHJJ, quaternion HKPEMIJGIMD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct DGNOBBBOMJH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> GDMPFDILKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> KHPGCJGOIPM;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x26FE710", Offset = "0x26FD910", VA = "0x1826FE710", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly HDHIMOFHFJL GAHAEFAECNA;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly HDHIMOFHFJL PDHDLPFCBND;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly HDHIMOFHFJL AHNECBBDEHK;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker MMPAKPPDFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private BABKCDBKOGM BGEPCDMJIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0A80", Offset = "0x2AAFC80", VA = "0x182AB0A80", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB06E0", Offset = "0x2AAF8E0", VA = "0x182AB06E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0710", Offset = "0x2AAF910", VA = "0x182AB0710", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class RegisterTransforms : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ENBKMACMALC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct DEGAKGPBPKB
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct NENDOMNJOIL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<KKIBNEOFHLO>.Runtime NDLCGAILNAL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime KKPHLNPOCID;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<KKIBNEOFHLO> HBFFFIJMLMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> CKJAGGIALDC;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x34D0140", Offset = "0x34CF340", VA = "0x1834D0140")]
				public void JNNOBNMLOFO(RegisterTransforms GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x34D0080", Offset = "0x34CF280", VA = "0x1834D0080")]
				public NENDOMNJOIL CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(NENDOMNJOIL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private DEGAKGPBPKB JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DEGAKGPBPKB.NENDOMNJOIL* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HLHLBAKLBFO;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x34D1470", Offset = "0x34D0670", VA = "0x1834D1470")]
			internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, KKIBNEOFHLO PBNJDHGCIFC, Transform FGNGGLFNLIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x34D1290", Offset = "0x34D0490", VA = "0x1834D1290", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x34D1390", Offset = "0x34D0590", VA = "0x1834D1390")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, ref DEGAKGPBPKB.NENDOMNJOIL CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x34D1380", Offset = "0x34D0580", VA = "0x1834D1380")]
			public void JNNOBNMLOFO(RegisterTransforms GEIMOJMNBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x34D1220", Offset = "0x34D0420", VA = "0x1834D1220")]
			public unsafe static void BBHGLEEGMLJ(ArchetypeChunkIterator* CFDBJLIFKHF, void* FGEKNPAMDGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HBCIJNENFEB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct IAMOGJCBELM
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct LNGFGLPDCEB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime GDOCGFFCOND;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<KKIBNEOFHLO>.Runtime NDLCGAILNAL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity BHHHKGJMGLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<KKIBNEOFHLO> HBFFFIJMLMB;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x34D30C0", Offset = "0x34D22C0", VA = "0x1834D30C0")]
				public void JNNOBNMLOFO(RegisterTransforms GEIMOJMNBNO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x34D41A0", Offset = "0x34D33A0", VA = "0x1834D41A0")]
				public LNGFGLPDCEB CDDKJIEEPKO(ref ArchetypeChunk DBJCEIOACJO, int PCGFKGLHLFP, int ICIKOCELOLI)
				{
					return default(LNGFGLPDCEB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private IAMOGJCBELM JBGAPHFLKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IAMOGJCBELM.LNGFGLPDCEB* BIKDLBDICKE;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x34D31D0", Offset = "0x34D23D0", VA = "0x1834D31D0")]
			internal void NKAIDNDKJJJ(Entity LHCPLOHKBCE, KKIBNEOFHLO PBNJDHGCIFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x34D3030", Offset = "0x34D2230", VA = "0x1834D3030", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int IFLKNFOCJOL, int OGEKEAPBEOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x34D3120", Offset = "0x34D2320", VA = "0x1834D3120")]
			public void NDNHPEKHAEJ(ref ArchetypeChunk DMDHEKMOMJJ, [NoAlias] ref IAMOGJCBELM.LNGFGLPDCEB CILGKBEGLHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x34D30C0", Offset = "0x34D22C0", VA = "0x1834D30C0")]
			public void JNNOBNMLOFO(RegisterTransforms GEIMOJMNBNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private BABKCDBKOGM BGEPCDMJIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery KEAOFCNMPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery DFIFAAEIOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery CBBONKKHGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery BKACAEIOAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery JOKAJBCMCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker HMONNFOPNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery ACGJCAMMHAJ;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2704D30", Offset = "0x2703F30", VA = "0x182704D30", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2704A50", Offset = "0x2703C50", VA = "0x182704A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2704C60", Offset = "0x2703E60", VA = "0x182704C60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2703990", Offset = "0x2702B90", VA = "0x182703990")]
		private void EGNOBKDDIMP(EntityQuery ADGIOFAMOGF, JEMIGPGNFON KJCCBJNGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2704570", Offset = "0x2703770", VA = "0x182704570")]
		private void MJLFEBCILOO(EntityQuery ADGIOFAMOGF, JEMIGPGNFON KJCCBJNGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2704C00", Offset = "0x2703E00", VA = "0x182704C00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2704080", Offset = "0x2703280", VA = "0x182704080")]
		private void HOBIHKNFCDC(NativeArray<Entity> EJIAHCPIPFJ, JEMIGPGNFON KJCCBJNGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2703BD0", Offset = "0x2702DD0", VA = "0x182703BD0")]
		[BurstCompile]
		internal static void GMHOHNGGKMF(NativeArray<KKIBNEOFHLO> APIEMJBNOPF, ComponentDataFromEntity<KKIBNEOFHLO> NMPGFDKKMGB, JEMIGPGNFON KJCCBJNGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void BLNJFKCOOOL(Transform FGNGGLFNLIP, Entity LHCPLOHKBCE, int GMEHLIHLGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void DOKOGAGFMAF(Entity LHCPLOHKBCE, int GMEHLIHLGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void NJENDGBHNAP(int GMEHLIHLGEH, JEMIGPGNFON KJCCBJNGELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x27041C0", Offset = "0x27033C0", VA = "0x1827041C0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void KGFFPGOJLMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x27047E0", Offset = "0x27039E0", VA = "0x1827047E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2703EE0", Offset = "0x27030E0", VA = "0x182703EE0")]
		public static EntityQuery HCDNNMBFMBE(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x27043A0", Offset = "0x27035A0", VA = "0x1827043A0")]
		public static EntityQuery LDBOMEAGKGK(ComponentSystemBase GEIMOJMNBNO)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	public class CopyTransformDataToGameObjects : HDACKBGFGDN, CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct PCFMLNCIPFE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> CLOLACPGMFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2700110", Offset = "0x26FF310", VA = "0x182700110", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct GEDFLPHBMAO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> GDMPFDILKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x26FE930", Offset = "0x26FDB30", VA = "0x1826FE930", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct KFHBEEKEFEI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> GDMPFDILKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> KHPGCJGOIPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> EJIAHCPIPFJ;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x26FF080", Offset = "0x26FE280", VA = "0x1826FF080", Slot = "4")]
			public void Execute(int GMEHLIHLGEH, TransformAccess FGNGGLFNLIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly HDHIMOFHFJL GAHAEFAECNA;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly HDHIMOFHFJL PDHDLPFCBND;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly HDHIMOFHFJL AHNECBBDEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private BABKCDBKOGM BGEPCDMJIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery DOALHMEHBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery KNAEIGGKLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery EEMLFGMCKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray OFDFHKNHNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray LHCBGJCOPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray PGIOILDFHLC;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1880", Offset = "0x2AB0A80", VA = "0x182AB1880", Slot = "14")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0DB0", Offset = "0x2AAFFB0", VA = "0x182AB0DB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0FA0", Offset = "0x2AB01A0", VA = "0x182AB0FA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1030", Offset = "0x2AB0230", VA = "0x182AB1030", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1060", Offset = "0x2AB0260", VA = "0x182AB1060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0C30", Offset = "0x2AAFE30", VA = "0x182AB0C30")]
		private NativeArray<Entity> KEHPOLGHLEH(NativeArray<KKIBNEOFHLO> EMBOJIFBMBL, NativeList<Entity> HNLMOMAOEAN, TransformAccessArray BNOGJCCBJDN, TransformAccessArray MEJBGEIMELE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
	public class CopyTransformParentsToGameObjects : HDACKBGFGDN, BDLDACMOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private HMPKCBOCNEE MKCNDHMGOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private CLOLHMILBAD NOLLKEFDAIA;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D10", Offset = "0x2AB0F10", VA = "0x182AB1D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB19E0", Offset = "0x2AB0BE0", VA = "0x182AB19E0", Slot = "14")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D20", Offset = "0x2AB0F20", VA = "0x182AB1D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1B90", Offset = "0x2AB0D90", VA = "0x182AB1B90")]
		private static void FDJOKAMEEEC(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, Entity HHFDFFDPCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1AF0", Offset = "0x2AB0CF0", VA = "0x182AB1AF0")]
		private static bool BGEAIJHMDMH(EntityManager IIODDCGHDHF, Entity LHCPLOHKBCE, out Transform FGNGGLFNLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CGDKNMKPKIP(OOBCCNCEGNI.TransformSyncing)]
	public class L2PToL2WHierarchy : HDACKBGFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct BCHKLDMPAFO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JONDIGOGGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> PNGIDOCCGCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> FNOCLECIAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> MJFPJDIDLLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> BCHONPEBKDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> DPJAJFMAIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint EABDLDFBCCO;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x34CE9C0", Offset = "0x34CDBC0", VA = "0x1834CE9C0")]
			[Conditional("DEBUG_BUILD")]
			private void MDDBHEPGFMB(Entity LHCPLOHKBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x34CE2D0", Offset = "0x34CD4D0", VA = "0x1834CE2D0", Slot = "4")]
			public void Execute(ArchetypeChunk DMDHEKMOMJJ, int GMEHLIHLGEH, int ADOFFBKHIEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x34CE5C0", Offset = "0x34CD7C0", VA = "0x1834CE5C0")]
			private void GAOJJBIDINN(float4x4 FKAONHMFLHN, Entity LHCPLOHKBCE, bool DHGMOFBDDIO, int GADEOBMPDPB = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery FEDNEKMBAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery BODCBNDPDEC;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x26B07D0", Offset = "0x26AF9D0", VA = "0x1826B07D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x26B08F0", Offset = "0x26AFAF0", VA = "0x1826B08F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class CFLLOMEGDOG : FEPOGEEKBIH
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct JOHOLJFJHAA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JONDIGOGGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> BCHONPEBKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint EABDLDFBCCO;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x26FEF80", Offset = "0x26FE180", VA = "0x1826FEF80", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int GMEHLIHLGEH, int ADOFFBKHIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x26FEF00", Offset = "0x26FE100", VA = "0x1826FEF00")]
		public bool DNMKMHELHID(ArchetypeChunk DMDHEKMOMJJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery FEDNEKMBAPH;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6CA0", Offset = "0x2AA5EA0", VA = "0x182AA6CA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6DD0", Offset = "0x2AA5FD0", VA = "0x182AA6DD0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OCAIANLHDDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public CFLLOMEGDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class NHLDHBLEGBG : FEPOGEEKBIH
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct EHFFMIPDPIO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> PPCNIKCPHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> MPOMMHKENNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> BGDCPGFKNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> EDGOGAJADID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint EABDLDFBCCO;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x34D0E70", Offset = "0x34D0070", VA = "0x1834D0E70", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int GMEHLIHLGEH, int ADOFFBKHIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x34D0DF0", Offset = "0x34CFFF0", VA = "0x1834D0DF0")]
		public bool DNMKMHELHID(ArchetypeChunk DMDHEKMOMJJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery EDPIJECELAJ;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0DF0", Offset = "0x2AEFFF0", VA = "0x182AF0DF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0F00", Offset = "0x2AF0100", VA = "0x182AF0F00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OCAIANLHDDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public NHLDHBLEGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class PLBHOADDLPF : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct MMNIPGPKKFA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> EOLBMDPFNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BCGKMHOMNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> IHCEGHOFJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> AOOEIHAGEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint EABDLDFBCCO;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x34D8C70", Offset = "0x34D7E70", VA = "0x1834D8C70", Slot = "4")]
		public void Execute(ArchetypeChunk DMDHEKMOMJJ, int GMEHLIHLGEH, int ADOFFBKHIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x34D8B90", Offset = "0x34D7D90", VA = "0x1834D8B90")]
		public bool DNMKMHELHID(ArchetypeChunk DMDHEKMOMJJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery EDPIJECELAJ;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2B01E30", Offset = "0x2B01030", VA = "0x182B01E30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2B01F60", Offset = "0x2B01160", VA = "0x182B01F60", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OCAIANLHDDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0")]
	public PLBHOADDLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CGDKNMKPKIP(OOBCCNCEGNI.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : FMFJLEJCFKG
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct GINKKDEOPKG : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType CKBKGNNPFML
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A2B0", Offset = "0x2B094B0", VA = "0x182B0A2B0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType KCMCCINKDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A280", Offset = "0x2B09480", VA = "0x182B0A280", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType GOGHPKEOPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A250", Offset = "0x2B09450", VA = "0x182B0A250", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A1B0", Offset = "0x2B093B0", VA = "0x182B0A1B0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xBA69F0", Offset = "0xBA5BF0", VA = "0x180BA69F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[OEFBFCOKFKI(NMAPNONNEIE.Game)]
public class DBCELKIBBGF : BMJFDFMNLOB
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type MEKANAKNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3430", Offset = "0x2AB2630", VA = "0x182AB3430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] NHIDJJDLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB34A0", Offset = "0x2AB26A0", VA = "0x182AB34A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public DBCELKIBBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[OEFBFCOKFKI(NMAPNONNEIE.Loading)]
public class HLAFJHDABDL : BMJFDFMNLOB
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type MEKANAKNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] NHIDJJDLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x26A1730", Offset = "0x26A0930", VA = "0x1826A1730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HLAFJHDABDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class HJPLHIBBPFN : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x26A1310", Offset = "0x26A0510", VA = "0x1826A1310", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public HJPLHIBBPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[OEFBFCOKFKI(NMAPNONNEIE.Saving)]
public class ENAHBKJIEOG : BMJFDFMNLOB
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type MEKANAKNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] NHIDJJDLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA350", Offset = "0x2AB9550", VA = "0x182ABA350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ENAHBKJIEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class JIOHDEMJCLA : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x26AD160", Offset = "0x26AC360", VA = "0x1826AD160", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public JIOHDEMJCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[OEFBFCOKFKI(NMAPNONNEIE.Simulation)]
public class KPLIFEMMMHM : BMJFDFMNLOB
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type MEKANAKNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x26AF470", Offset = "0x26AE670", VA = "0x1826AF470", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] NHIDJJDLKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x26AF4E0", Offset = "0x26AE6E0", VA = "0x1826AF4E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public KPLIFEMMMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[PNCLNBNALEO(typeof(AAGOKKLCOLG), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
internal class AAGOKKLCOLG : BDLDACMOPAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::BMOJAHCNCJI<AuthoredParentData, KBMOAFKGKDP, GIGJEKKPFIJ, AuthoredChildrenData> FCBGFADDFNI;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D9A0", Offset = "0x2A9CBA0", VA = "0x182A9D9A0", Slot = "4")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AAGOKKLCOLG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(EntityHierarchyParents), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	internal sealed class EntityHierarchyParents : CMLEAAEGAAL, BDLDACMOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[GAJFPHPAPMA]
		private EFDNEMMCCPM EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[GAJFPHPAPMA]
		private PropertyChangeNetworkRouter BMCJDJOMPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::FPAJBINIPIL<Entity> IDBLFHOOMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::BMOJAHCNCJI<ParentData, DKOMKLJHDNG, JPBIMHNFJCP, ChildrenData> FCBGFADDFNI;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x2696B30", Offset = "0x2695D30", VA = "0x182696B30", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2696760", Offset = "0x2695960", VA = "0x182696760", Slot = "5")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x2696A40", Offset = "0x2695C40", VA = "0x182696A40")]
		public Entity FONBPFGIHGB(Entity LHCPLOHKBCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2696700", Offset = "0x2695900", VA = "0x182696700")]
		public bool ACEDFEGBPAB(Entity LHCPLOHKBCE, Entity BDBBMBMDCFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2696A90", Offset = "0x2695C90", VA = "0x182696A90")]
		public bool HMBNJDPGAJN(Entity LHCPLOHKBCE, Entity BDBBMBMDCFP, bool GBDGBMCMBHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x2696860", Offset = "0x2695A60", VA = "0x182696860")]
		private bool ENCBOOABLHE(Entity LHCPLOHKBCE, Entity BDBBMBMDCFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(LFAFBMFMMKA), new string[] { })]
internal sealed class LFAFBMFMMKA : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery HEEEGDDIHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x26B3360", Offset = "0x26B2560", VA = "0x1826B3360")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x26B35E0", Offset = "0x26B27E0", VA = "0x1826B35E0", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x26B2DA0", Offset = "0x26B1FA0", VA = "0x1826B2DA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A60", Offset = "0x26B1C60", VA = "0x1826B2A60")]
	public bool BAPHEPNKIJH(Entity LHCPLOHKBCE, Entity MIONKFPACCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x26B31E0", Offset = "0x26B23E0", VA = "0x1826B31E0")]
	public IEnumerable<Entity> JENDCCHGJCA(Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x26B33B0", Offset = "0x26B25B0", VA = "0x1826B33B0")]
	public bool MPHHNPLLNHA(Entity LHCPLOHKBCE, Entity AAFNLLCIFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x26B34E0", Offset = "0x26B26E0", VA = "0x1826B34E0")]
	public bool NLKLELJEKDK(Entity LHCPLOHKBCE, Entity IHEBNKKPFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x26B2B20", Offset = "0x26B1D20", VA = "0x1826B2B20")]
	public NativeList<Entity> CBLOBJPOGKK(Entity LHCPLOHKBCE, bool FILPHNKNPEK = false, Allocator HCEMBCPANJM = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x26B2DC0", Offset = "0x26B1FC0", VA = "0x1826B2DC0")]
	public IEnumerable<Entity> FHNKAIJGLGA(Entity LHCPLOHKBCE, bool FILPHNKNPEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x26B2CF0", Offset = "0x26B1EF0", VA = "0x1826B2CF0")]
	public Entity DMOICBPEOLI(Entity LHCPLOHKBCE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x26B36E0", Offset = "0x26B28E0", VA = "0x1826B36E0")]
	public NativeArray<Entity> PKBPOFBHNCK()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x26B2FC0", Offset = "0x26B21C0", VA = "0x1826B2FC0")]
	public bool GDHBJPCNPAN(Entity IHEBNKKPFLJ, Entity NBOGDLHPFJC, out Entity LCFGMFPMPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C00", Offset = "0x26B1E00", VA = "0x1826B2C00")]
	private Entity CKDNABOIKGC(Entity LHCPLOHKBCE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LFAFBMFMMKA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x25BE6D0", Offset = "0x25BD8D0", VA = "0x1825BE6D0")]
		public static void LLLPMINBGLL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(BLBDINABANB LBBJCIBEDFD, global::LEMPDKIOGJO<Entity> OPCKJKNEHGA, out global::BMOJAHCNCJI<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NNBOONBGLBC) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, KLMOHFMGCOL where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, KLMOHFMGCOL, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2B04660", Offset = "0x2B03860", VA = "0x182B04660")]
		public static bool NMGBCHDKGME(DBJMAFIOFFK LPHOEJICCFI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class BMOJAHCNCJI<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, KLMOHFMGCOL where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, KLMOHFMGCOL, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::FPAJBINIPIL<Entity> IDBLFHOOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly NMOCPLDOEBP PHBBLDDEABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly HGIJDEJFJEI HHFDFFDPCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly CLOLHMILBAD NOLLKEFDAIA;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9090", Offset = "0x1EB8290", VA = "0x181EB9090")]
	public BMOJAHCNCJI(BLBDINABANB LBBJCIBEDFD, global::LEMPDKIOGJO<Entity> OPCKJKNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8130", Offset = "0x1EB7330", VA = "0x181EB8130")]
	private bool HCPANKGNPIM(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8B80", Offset = "0x1EB7D80", VA = "0x181EB8B80")]
	private bool LEFBKNJOFOI(Entity LHCPLOHKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7D20", Offset = "0x1EB6F20", VA = "0x181EB7D20")]
	public bool ACEDFEGBPAB(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8750", Offset = "0x1EB7950", VA = "0x181EB8750")]
	public bool KFDKKLOGJBG(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8310", Offset = "0x1EB7510", VA = "0x181EB8310")]
	private bool KFDKKLOGJBG(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP, bool LBNPAMHIGMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void CIPCHPCPOKN(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void PJEEPJBKANP(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void AIPBGHKNFCM(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void AECOHCIMOMO(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void BKCJFMBOAMA(Entity LHCPLOHKBCE, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7E30", Offset = "0x1EB7030", VA = "0x181EB7E30")]
	private bool BAPHEPNKIJH(Entity LHCPLOHKBCE, Entity MIONKFPACCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8040", Offset = "0x1EB7240", VA = "0x181EB8040")]
	private void EKFFJBFOGEJ(Entity LHCPLOHKBCE, in Entity FLHBBDGHDCM, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8BD0", Offset = "0x1EB7DD0", VA = "0x181EB8BD0")]
	private void NBECIOBJJDL(Entity LHCPLOHKBCE, in Entity FLHBBDGHDCM, in Entity BDBBMBMDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8980", Offset = "0x1EB7B80", VA = "0x181EB8980")]
	private bool KPOJFAAOGDC(FAAFLFNFNCP NGJEDKCNODL, in HCIIHJLICJK EDAFBPJBKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7F10", Offset = "0x1EB7110", VA = "0x181EB7F10")]
	private void DFCNILODFON(Entity HHFDFFDPCGO, Entity AAFNLLCIFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8280", Offset = "0x1EB7480", VA = "0x181EB8280")]
	private void HDJNLHIMONE(Entity HHFDFFDPCGO, Entity AAFNLLCIFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private void NJENDGBHNAP(Entity LHCPLOHKBCE, Entity FLHBBDGHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private void BLNJFKCOOOL(Entity LHCPLOHKBCE, Entity BDBBMBMDCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct NPBBOFDALAN : OEMKBCGGACH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public GDJECICPFDH ELOGHOABGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GDJECICPFDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0xBFDEC0", Offset = "0xBFD0C0", VA = "0x180BFDEC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[PNCLNBNALEO(typeof(ObjectEmbodimentService), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[CGDKNMKPKIP(OOBCCNCEGNI.Embodiment)]
	internal sealed class ObjectEmbodimentService : BKBCOOOPJAH, IMFHGBIDMMC, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService FBCDDJGNMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[GAJFPHPAPMA]
		private EFDNEMMCCPM EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[GAJFPHPAPMA]
		private DAHJGPKAIEK MAHBIJBCNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[GAJFPHPAPMA]
		private ACMOOCKHEPB BCEOOJIEMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[GAJFPHPAPMA]
		private TransformOwnershipPhase MGADLDPDPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<HCIIHJLICJK, ACPBHPEJKKH> BBOHIDPMJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private DGBMHMLDPLG NEJFAIJGGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF75D0", Offset = "0x2AF67D0", VA = "0x182AF75D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int ELEKBHEODOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4550", Offset = "0x2AF3750", VA = "0x182AF4550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int HLDBFIHOMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4FA0", Offset = "0x2AF41A0", VA = "0x182AF4FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1216B70", Offset = "0x1215D70", VA = "0x181216B70", Slot = "4")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7F10", Offset = "0x2AF7110", VA = "0x182AF7F10", Slot = "5")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B40", Offset = "0x2AF4D40", VA = "0x182AF5B40")]
		public void HMPIGDCHCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4570", Offset = "0x2AF3770", VA = "0x182AF4570", Slot = "6")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5120", Offset = "0x2AF4320", VA = "0x182AF5120", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2AF46C0", Offset = "0x2AF38C0", VA = "0x182AF46C0")]
		public int AJKLHMEOEOI(SceneTag FEGPGPHCDJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2AF68E0", Offset = "0x2AF5AE0", VA = "0x182AF68E0")]
		public int JPHLNAACLHO(SceneTag FEGPGPHCDJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4770", Offset = "0x2AF3970", VA = "0x182AF4770")]
		public bool BBOPMFGJGKA(Entity LHCPLOHKBCE, Allocator HCEMBCPANJM, out NativeList<Entity> BECHLGMHGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2AF70D0", Offset = "0x2AF62D0", VA = "0x182AF70D0")]
		public bool LLHBJABEDAE(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2AF52A0", Offset = "0x2AF44A0", VA = "0x182AF52A0")]
		public bool FEMFMLHCJLP(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2AF76D0", Offset = "0x2AF68D0", VA = "0x182AF76D0")]
		public bool MLOGCIOJFGP(Entity LHCPLOHKBCE, out ACPBHPEJKKH MICPPHDEBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7620", Offset = "0x2AF6820", VA = "0x182AF7620")]
		private bool MLOGCIOJFGP(Transform FGNGGLFNLIP, out ACPBHPEJKKH MICPPHDEBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6AF0", Offset = "0x2AF5CF0", VA = "0x182AF6AF0")]
		private void LBINHIANAEM(Entity LHCPLOHKBCE, ACPBHPEJKKH MICPPHDEBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7320", Offset = "0x2AF6520", VA = "0x182AF7320")]
		private bool LMKNKNMADHG(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4CC0", Offset = "0x2AF3EC0", VA = "0x182AF4CC0")]
		public void BNAKCAAHHPA(HCIIHJLICJK MIBPNJCOIHL, ACPBHPEJKKH LCEEIDPAOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5370", Offset = "0x2AF4570", VA = "0x182AF5370")]
		public bool GDOFPJLNPHC(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6170", Offset = "0x2AF5370", VA = "0x182AF6170")]
		public bool JOBEBJPEIMK(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6890", Offset = "0x2AF5A90", VA = "0x182AF6890")]
		public bool JOBEBJPEIMK(Entity LHCPLOHKBCE, [Optional] object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6150", Offset = "0x2AF5350", VA = "0x182AF6150")]
		public bool JOBEBJPEIMK(ACPBHPEJKKH LPHOEJICCFI, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B10", Offset = "0x2AF6D10", VA = "0x182AF7B10")]
		public bool OFHCHFPGGCO(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7EE0", Offset = "0x2AF70E0", VA = "0x182AF7EE0")]
		public bool OFHCHFPGGCO(ACPBHPEJKKH MICPPHDEBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6520", Offset = "0x2AF5720", VA = "0x182AF6520")]
		public bool JOBEBJPEIMK(ACPBHPEJKKH MICPPHDEBFL, [Optional] object IALNODEHBNN, bool COPOILGLIAJ = false, bool IGCHPFAHCOC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6900", Offset = "0x2AF5B00", VA = "0x182AF6900")]
		public Transform KAFNOFKKMEB(Entity LHCPLOHKBCE, [Optional] object IALNODEHBNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4BF0", Offset = "0x2AF3DF0", VA = "0x182AF4BF0")]
		public bool BGEAIJHMDMH(Entity LHCPLOHKBCE, out Transform FGNGGLFNLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4FC0", Offset = "0x2AF41C0", VA = "0x182AF4FC0")]
		public ACPBHPEJKKH DDGNNJCHMPH(Entity LHCPLOHKBCE, [Optional] object IALNODEHBNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7340", Offset = "0x2AF6540", VA = "0x182AF7340")]
		public void MFCPBIGBMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6C20", Offset = "0x2AF5E20", VA = "0x182AF6C20")]
		public void LFNJHOLIMJG(SceneTag FEGPGPHCDJD, bool DHIHGJKBLHN, global::JMILGIFBIEP<int> ILAALHLAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5C50", Offset = "0x2AF4E50", VA = "0x182AF5C50")]
		private void IDJFOEPLCKB(Entity LHCPLOHKBCE, bool DHIHGJKBLHN, bool KFAOIJBOEPG, global::JMILGIFBIEP<int> ILAALHLAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8040", Offset = "0x2AF7240", VA = "0x182AF8040")]
		private void PAJIOAPIMLC(Entity LHCPLOHKBCE, ACPBHPEJKKH MICPPHDEBFL, bool DHIHGJKBLHN, bool KFAOIJBOEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5250", Offset = "0x2AF4450", VA = "0x182AF5250")]
		public ACPBHPEJKKH ELPGILPIEPG(Entity LHCPLOHKBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6A70", Offset = "0x2AF5C70", VA = "0x182AF6A70")]
		public bool KMOEKAMFDFB(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7980", Offset = "0x2AF6B80", VA = "0x182AF7980")]
		public bool NIPPIJKNOFO(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF50B0", Offset = "0x2AF42B0", VA = "0x182AF50B0")]
		public bool DPJDPBNCGNP(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5A00", Offset = "0x2AF4C00", VA = "0x182AF5A00")]
		public bool GLHBEGDCMJP(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5930", Offset = "0x2AF4B30", VA = "0x182AF5930")]
		public bool GLHBEGDCMJP(GDJECICPFDH PLFCHHKILCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void GGDMLKNOGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B90", Offset = "0x2AF4D90", VA = "0x182AF5B90")]
		private void HOKKFLABBDD(bool AEKOPFPIHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2AF46E0", Offset = "0x2AF38E0", VA = "0x182AF46E0")]
		private bool AOLLMFFKCAC(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6B80", Offset = "0x2AF5D80", VA = "0x182AF6B80")]
		private ACPBHPEJKKH LEKIKHDKDPG(Entity LHCPLOHKBCE, object IALNODEHBNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2AF80E0", Offset = "0x2AF72E0", VA = "0x182AF80E0")]
		private ACPBHPEJKKH PFOEAGGEOAK(Entity LHCPLOHKBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5710", Offset = "0x2AF4910", VA = "0x182AF5710")]
		private (Vector3, Quaternion, Vector3) GKEPBGNKOEC(Entity LHCPLOHKBCE)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7A00", Offset = "0x2AF6C00", VA = "0x182AF7A00")]
		private void NJCLGEEIMCE(Entity LHCPLOHKBCE, CNKGPKGDJHD FNGBDAJENGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7010", Offset = "0x2AF6210", VA = "0x182AF7010")]
		private void LIFEIKDHALD(HPHBHAKAACD EHNNHDBEJOG, ACPBHPEJKKH LCEEIDPAOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2AF52C0", Offset = "0x2AF44C0", VA = "0x182AF52C0")]
		private void FPHJLIEBLBI(ACPBHPEJKKH LCEEIDPAOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2AF49C0", Offset = "0x2AF3BC0", VA = "0x182AF49C0")]
		private void BCGMMBENPMF(ACPBHPEJKKH MICPPHDEBFL, Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7740", Offset = "0x2AF6940", VA = "0x182AF7740")]
		private void NBEDLIHODPC(Entity LHCPLOHKBCE, ACPBHPEJKKH MICPPHDEBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4EC0", Offset = "0x2AF40C0", VA = "0x182AF4EC0")]
		private void CEPDCHJIDOC(Entity LHCPLOHKBCE, Transform FGNGGLFNLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x26AB680", Offset = "0x26AA880", VA = "0x1826AB680")]
		private HPHBHAKAACD NFLHCPFJANJ(Entity LHCPLOHKBCE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8320", Offset = "0x2AF7520", VA = "0x182AF8320")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5A70", Offset = "0x2AF4C70", VA = "0x182AF5A70")]
		[CompilerGenerated]
		private void HGAFBDDOMGP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class LCHAMGIPFBD
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x26B17F0", Offset = "0x26B09F0", VA = "0x1826B17F0")]
	public static ACPBHPEJKKH DDGNNJCHMPH(this ObjectEmbodimentService BBFEJKBBFEI, HPHBHAKAACD EHNNHDBEJOG, [Optional] object IALNODEHBNN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[PNCLNBNALEO(typeof(ObjectLifecycleService), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Lifecycle)]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	internal sealed class ObjectLifecycleService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService MICPPHDEBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private PLHDIIJFCAF PNLHDLKHNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects OKJMDJLIBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9570", Offset = "0x2AF8770", VA = "0x182AF9570")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, CNKGPKGDJHD> LDLKENKALDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9120", Offset = "0x2AF8320", VA = "0x182AF9120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8DD0", Offset = "0x2AF7FD0", VA = "0x182AF8DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> EBDDIGGGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9310", Offset = "0x2AF8510", VA = "0x182AF9310")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2AF99D0", Offset = "0x2AF8BD0", VA = "0x182AF99D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98A0", Offset = "0x2AF8AA0", VA = "0x182AF98A0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x9B8380", Offset = "0x9B7580", VA = "0x1809B8380", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9820", Offset = "0x2AF8A20", VA = "0x182AF9820")]
		public bool NHKKABBPFMM(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D30", Offset = "0x2AF7F30", VA = "0x182AF8D30")]
		internal void DAAOFBJPKEB(Entity LHCPLOHKBCE, CNKGPKGDJHD FNGBDAJENGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D90", Offset = "0x2AF7F90", VA = "0x182AF8D90")]
		public void DANFAKHLGOC(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF90D0", Offset = "0x2AF82D0", VA = "0x182AF90D0")]
		public void ELJMCOEOPJE(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9250", Offset = "0x2AF8450", VA = "0x182AF9250")]
		private bool JNDMIGEHCNC(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8ED0", Offset = "0x2AF80D0", VA = "0x182AF8ED0")]
		public void DPHICADNPGH(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF93B0", Offset = "0x2AF85B0", VA = "0x182AF93B0")]
		private bool LPNPNKNAKNF(Entity LHCPLOHKBCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91C0", Offset = "0x2AF83C0", VA = "0x182AF91C0")]
		public void JIMJGJIDNNL(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8E70", Offset = "0x2AF8070", VA = "0x182AF8E70")]
		private void DNCLHLCCMHI(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2AF95C0", Offset = "0x2AF87C0", VA = "0x182AF95C0")]
		private void NCMHKNKCOGB(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9980", Offset = "0x2AF8B80", VA = "0x182AF9980")]
		public void PICGCAPNLAO(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private void COOBIELBCOB(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B30", Offset = "0x2AF7D30", VA = "0x182AF8B30")]
		private void CENIOBGPNNO(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(ObjectPrefabs), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Prefabs)]
	internal class ObjectPrefabs : DNFGCBJMOHN, CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class COILIFBKIBG : IEnumerable<(HAGCJKKHBBM, CNKGPKGDJHD)>, IEnumerable, IEnumerator<(HAGCJKKHBBM, CNKGPKGDJHD)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (HAGCJKKHBBM primitiveType, CNKGPKGDJHD prefabType) <>2__current;

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
			private (HAGCJKKHBBM, CNKGPKGDJHD) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x1DA4C70", Offset = "0x1DA3E70", VA = "0x181DA4C70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((HAGCJKKHBBM, CNKGPKGDJHD));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x34CFCD0", Offset = "0x34CEED0", VA = "0x1834CFCD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x34CFD20", Offset = "0x34CEF20", VA = "0x1834CFD20")]
			[DebuggerHidden]
			public COILIFBKIBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x34CFAF0", Offset = "0x34CECF0", VA = "0x1834CFAF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x34CFC90", Offset = "0x34CEE90", VA = "0x1834CFC90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x34CFBF0", Offset = "0x34CEDF0", VA = "0x1834CFBF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(HAGCJKKHBBM, CNKGPKGDJHD)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x34CFBF0", Offset = "0x34CEDF0", VA = "0x1834CFBF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<CNKGPKGDJHD, Entity> ELFOBADGBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<CNKGPKGDJHD, EntityArchetype> IIMOMEKGFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<HAGCJKKHBBM, CNKGPKGDJHD> CMNNKEEKBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<JCHIOIGOACO, CNKGPKGDJHD> GJOPKDFFKIP;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int BPIIJGBNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2AFC0B0", Offset = "0x2AFB2B0", VA = "0x182AFC0B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2AFCEF0", Offset = "0x2AFC0F0", VA = "0x182AFCEF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD540", Offset = "0x2AFC740", VA = "0x182AFD540", Slot = "5")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC510", Offset = "0x2AFB710", VA = "0x182AFC510", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC9A0", Offset = "0x2AFBBA0", VA = "0x182AFC9A0")]
		internal IEnumerable<Type> ENLPIKMLCLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC100", Offset = "0x2AFB300", VA = "0x182AFC100")]
		internal OOCNBKCHBGM BIJDOAOOPNM(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC170", Offset = "0x2AFB370", VA = "0x182AFC170")]
		public EntityArchetype BLHLGFJPIOA(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC00", Offset = "0x2AFBE00", VA = "0x182AFCC00")]
		public NativeHashMap<int, EntityArchetype> IPBAEKFNKFN(Allocator HCEMBCPANJM = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA00", Offset = "0x2AFBC00", VA = "0x182AFCA00")]
		public bool FBGPBGFINHL(CNKGPKGDJHD FNGBDAJENGB, out EntityArchetype AOOCNFHGCNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCA70", Offset = "0x2AFBC70", VA = "0x182AFCA70", Slot = "4")]
		[IteratorStateMachine(typeof(COILIFBKIBG))]
		public IEnumerable<(HAGCJKKHBBM, CNKGPKGDJHD)> FKICIFCOLGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC1D0", Offset = "0x2AFB3D0", VA = "0x182AFC1D0")]
		public Entity CLKBEFKLIOC(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCDE0", Offset = "0x2AFBFE0", VA = "0x182AFCDE0")]
		public CNKGPKGDJHD KIFHAIDEHFN(JCHIOIGOACO NIFOGEBEDNG)
		{
			return default(CNKGPKGDJHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCD80", Offset = "0x2AFBF80", VA = "0x182AFCD80")]
		public CNKGPKGDJHD KIFHAIDEHFN(HAGCJKKHBBM NIFOGEBEDNG)
		{
			return default(CNKGPKGDJHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD3D0", Offset = "0x2AFC5D0", VA = "0x182AFD3D0")]
		public NativeHashMap<int, Entity> NEALEEGCGDL(Allocator HCEMBCPANJM = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE40", Offset = "0x2AFC040", VA = "0x182AFCE40")]
		public IEnumerable<CNKGPKGDJHD> KKMPNCFKPHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE90", Offset = "0x2AFC090", VA = "0x182AFCE90")]
		public Entity MDPEOFOIHOD(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD360", Offset = "0x2AFC560", VA = "0x182AFD360")]
		public bool NCFAIABJPND(CNKGPKGDJHD FNGBDAJENGB, out Entity GDEKLMNKJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCF10", Offset = "0x2AFC110", VA = "0x182AFCF10")]
		private void MMEFLBOHFFE(OOCNBKCHBGM KJOBLCFILPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC2E0", Offset = "0x2AFB4E0", VA = "0x182AFC2E0")]
		internal void DHNIKGOOEDB(CNKGPKGDJHD FNGBDAJENGB, ComponentTypeList PADDFMKKGFD, HDAFOCFOAHA IPBAGGNJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC840", Offset = "0x2AFBA40", VA = "0x182AFC840")]
		private void EFEFEJLIOGE(CNKGPKGDJHD FNGBDAJENGB, ComponentTypeList LGJGAACOOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAE0", Offset = "0x2AFBCE0", VA = "0x182AFCAE0")]
		internal Entity GNOJADJFNMN(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD970", Offset = "0x2AFCB70", VA = "0x182AFD970")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum JJFNDNAGMHB
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface BHLNANMGMPL
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World ADMAJPELGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	LAOCDEHPEDM IDHLDBDPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class FEMHCINAMLJ : LENAHHJHMLI, GIDNMOCOABH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly DBAGHIAEIFE LOFLPNDCLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly JJFNDNAGMHB MGADLDPDPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<OKIOMKCAIII> JBMFIAIOALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, DDBPAPBBEPF> IGJLNECGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> PEANMDNPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle DGJIBKBPHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle IPOMMAEAEPB;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World MCPMGAKPIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2698EC0", Offset = "0x26980C0", VA = "0x182698EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private LAOCDEHPEDM IEKECAEBKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2698AC0", Offset = "0x2697CC0", VA = "0x182698AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private IKNFBHNFDLA BACENKPLJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BF80", Offset = "0x1E4B180", VA = "0x181E4BF80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, DDBPAPBBEPF> EJIDEAKDDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x951ED0", Offset = "0x9510D0", VA = "0x180951ED0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, DDBPAPBBEPF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle IENMKMKPDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0xFFB190", Offset = "0xFFA390", VA = "0x180FFB190", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1381360", Offset = "0x1380560", VA = "0x181381360", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool NGBNJEHLJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2699950", Offset = "0x2698B50", VA = "0x182699950", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World ENNOIAKFEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2699480", Offset = "0x2698680", VA = "0x182699480", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2699960", Offset = "0x2698B60", VA = "0x182699960")]
	public FEMHCINAMLJ(DBAGHIAEIFE LOFLPNDCLLC, JJFNDNAGMHB MGADLDPDPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2699470", Offset = "0x2698670", VA = "0x182699470", Slot = "11")]
	private void LCKAFMPPPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2699830", Offset = "0x2698A30", VA = "0x182699830", Slot = "10")]
	private bool PAHGGHLFEHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2698AE0", Offset = "0x2697CE0", VA = "0x182698AE0", Slot = "12")]
	private void BEDKIEAEGFO(ComponentType KBJJKACLINM, in OKIOMKCAIII GPIEHJALFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2699360", Offset = "0x2698560", VA = "0x182699360", Slot = "13")]
	private bool HDPADKEHJPC(CNKGPKGDJHD FNGBDAJENGB, out Entity GDEKLMNKJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2699390", Offset = "0x2698590", VA = "0x182699390", Slot = "16")]
	private bool HEJBNFLDAAJ(out NativeArray<int> BEBLJFCKMDD, Allocator HCEMBCPANJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2698D00", Offset = "0x2697F00", VA = "0x182698D00", Slot = "17")]
	private bool CBLKABFFCBN(ComponentType KBJJKACLINM, out OKIOMKCAIII NGBEMEAOCPB, out HGFCKIBIOML FMEBKGHCHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2698BD0", Offset = "0x2697DD0", VA = "0x182698BD0", Slot = "18")]
	private bool CBLKABFFCBN(ComponentType KBJJKACLINM, out OKIOMKCAIII NGBEMEAOCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x26994E0", Offset = "0x26986E0", VA = "0x1826994E0", Slot = "19")]
	private OKIOMKCAIII LMPDAEAFGAP(ComponentType KBJJKACLINM)
	{
		return default(OKIOMKCAIII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2699430", Offset = "0x2698630", VA = "0x182699430", Slot = "20")]
	private LFKHECFMCND JDMFMPPEHED()
	{
		return default(LFKHECFMCND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x26995D0", Offset = "0x26987D0", VA = "0x1826995D0", Slot = "21")]
	private void NBPKGBKKGGB(JobHandle KBGHJIGDKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x26990B0", Offset = "0x26982B0", VA = "0x1826990B0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2699610", Offset = "0x2698810", VA = "0x182699610")]
	private bool NOMPFKMHLIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2698F20", Offset = "0x2698120", VA = "0x182698F20")]
	private int FGKNPNNJJMC()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class DBAGHIAEIFE : BHLNANMGMPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public DGHIBPMIJHM HIJDILOKICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService ELFOBADGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public LAOCDEHPEDM AJIFNGCHGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public IKNFBHNFDLA FPHOOMBLMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public DLLMPOAHENO CGLICANDEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World ADMAJPELGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB33D0", Offset = "0x2AB25D0", VA = "0x182AB33D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public LAOCDEHPEDM IDHLDBDPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public DBAGHIAEIFE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(PropertyDiffStateService), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.PropertyChanges)]
	internal class PropertyDiffStateService : CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct KLPLNMDNINP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly JJFNDNAGMHB NKPKNPNHPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService BDIJLBAAEHA;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x34D7B40", Offset = "0x34D6D40", VA = "0x1834D7B40")]
			public KLPLNMDNINP(PropertyDiffStateService BDIJLBAAEHA, JJFNDNAGMHB EICNLOHCLPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x34D7B20", Offset = "0x34D6D20", VA = "0x1834D7B20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly DBAGHIAEIFE LOFLPNDCLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly FEMHCINAMLJ[] AEFKINBPBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private JJFNDNAGMHB MJCDGGILABB;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public BHLNANMGMPL FDDCKEDBNLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public GIDNMOCOABH GENMNIDNCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x1EC7AE0", Offset = "0x1EC6CE0", VA = "0x181EC7AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public LENAHHJHMLI NKEJOGEKPOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x1EC7AE0", Offset = "0x1EC6CE0", VA = "0x181EC7AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B360", Offset = "0x2B0A560", VA = "0x182B0B360")]
		public GIDNMOCOABH ELALEGHCPGB(JJFNDNAGMHB MGADLDPDPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B360", Offset = "0x2B0A560", VA = "0x182B0B360")]
		public LENAHHJHMLI DHMIIEKJFFC(JJFNDNAGMHB MGADLDPDPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B500", Offset = "0x2B0A700", VA = "0x182B0B500", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B0D0", Offset = "0x2B0A2D0", VA = "0x182B0B0D0", Slot = "5")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B480", Offset = "0x2B0A680", VA = "0x182B0B480")]
		public void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B3A0", Offset = "0x2B0A5A0", VA = "0x182B0B3A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B4E0", Offset = "0x2B0A6E0", VA = "0x182B0B4E0")]
		public KLPLNMDNINP NIJKMJLCOEO(JJFNDNAGMHB MGADLDPDPGK)
		{
			return default(KLPLNMDNINP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B5D0", Offset = "0x2B0A7D0", VA = "0x182B0B5D0")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	[PNCLNBNALEO(typeof(SceneService), new string[] { })]
	internal class SceneService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag DELPKJDFJOH;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string FDAAILBELDN = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string NHPFHOOOFHL = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[GAJFPHPAPMA]
		private AEOPHBOKNJI JOIEBCBPCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[GAJFPHPAPMA]
		private ObjectEmbodimentService MICPPHDEBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[GAJFPHPAPMA]
		private NMOCPLDOEBP KECMGBIFIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[GAJFPHPAPMA]
		private SingletonComponentService MMPGEJGEGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[GAJFPHPAPMA]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[GAJFPHPAPMA]
		private PhotonInstanceCleanupService EHGPBJLGCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery ANFPFCJHEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery JJJEMLKKNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery CBGIMOJLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity HIIPKNINKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool FNNJMCGDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2705D70", Offset = "0x2704F70", VA = "0x182705D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> GCIKHEGNCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0xD4D670", Offset = "0xD4C870", VA = "0x180D4D670")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x1A15740", Offset = "0x1A14940", VA = "0x181A15740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity LMNPHHDNPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2705070", Offset = "0x2704270", VA = "0x182705070")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag MLDMGOFFCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2705FA0", Offset = "0x27051A0", VA = "0x182705FA0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity CCDMDLPPNKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2705FA0", Offset = "0x27051A0", VA = "0x182705FA0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2705FF0", Offset = "0x27051F0", VA = "0x182705FF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2706680", Offset = "0x2705880", VA = "0x182706680")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2706C40", Offset = "0x2705E40", VA = "0x182706C40", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2705600", Offset = "0x2704800", VA = "0x182705600", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x27068A0", Offset = "0x2705AA0", VA = "0x1827068A0")]
		public void NNCFLLMJPFG(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x27055A0", Offset = "0x27047A0", VA = "0x1827055A0")]
		public NativeArray<Entity> CPFAABANFEA(Allocator HCEMBCPANJM = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x27051C0", Offset = "0x27043C0", VA = "0x1827051C0")]
		public void BPLEKNBIMMB(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2705520", Offset = "0x2704720", VA = "0x182705520")]
		public Entity COCICBIJILB(string KNOPFGAGMCN = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x27066F0", Offset = "0x27058F0", VA = "0x1827066F0")]
		public void MLHHJJDDBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2706770", Offset = "0x2705970", VA = "0x182706770")]
		public void NFCMKHHCFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x27065F0", Offset = "0x27057F0", VA = "0x1827065F0")]
		public void LNBPALPCAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2706060", Offset = "0x2705260", VA = "0x182706060")]
		public void IJBBJMLCCPJ(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2706080", Offset = "0x2705280", VA = "0x182706080")]
		public bool JNCKDMLHGDL(Entity FEGPGPHCDJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2706070", Offset = "0x2705270", VA = "0x182706070")]
		public void JINIJMNHDAD(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2706790", Offset = "0x2705990", VA = "0x182706790")]
		public string NMBELNDCMAF(Entity FEGPGPHCDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		public void EOBJEBNOCFD(Entity FEGPGPHCDJD, string KNOPFGAGMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x27066D0", Offset = "0x27058D0", VA = "0x1827066D0")]
		public bool MKKNBEMMNCG(string KNOPFGAGMCN, out Entity FEGPGPHCDJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x27064E0", Offset = "0x27056E0", VA = "0x1827064E0")]
		public void KOJHEFGLJJG(Entity FEGPGPHCDJD, bool CADNJNBNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2705EB0", Offset = "0x27050B0", VA = "0x182705EB0")]
		public void HALFPGJIEMI(Entity LHCPLOHKBCE, bool OHPIDGDAFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2705F30", Offset = "0x2705130", VA = "0x182705F30")]
		public void HALFPGJIEMI(NativeArray<Entity> EJIAHCPIPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2705DC0", Offset = "0x2704FC0", VA = "0x182705DC0")]
		public void HALFPGJIEMI(EntityQuery ADGIOFAMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x27059E0", Offset = "0x2704BE0", VA = "0x1827059E0")]
		public void GAPAGHDLFMK(Entity LHCPLOHKBCE, Entity FEGPGPHCDJD, bool OHPIDGDAFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2705800", Offset = "0x2704A00", VA = "0x182705800")]
		public void GAPAGHDLFMK(NativeArray<Entity> EJIAHCPIPFJ, Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2705C10", Offset = "0x2704E10", VA = "0x182705C10")]
		public void GAPAGHDLFMK(EntityQuery ADGIOFAMOGF, Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x27052C0", Offset = "0x27044C0", VA = "0x1827052C0")]
		private void CFBDAHMEIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x27055D0", Offset = "0x27047D0", VA = "0x1827055D0")]
		private void DHCGDHFMAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2705070", Offset = "0x2704270", VA = "0x182705070")]
		private Entity COIAGIKLMOE()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2705CC0", Offset = "0x2704EC0", VA = "0x182705CC0")]
		private void GDFNFMGPBPA(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2706130", Offset = "0x2705330", VA = "0x182706130")]
		private void KHEGGEGNFJJ(EntityQuery KNKADONPCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2706200", Offset = "0x2705400", VA = "0x182706200")]
		private void KHEGGEGNFJJ(NativeArray<Entity> JIPLOFKCDHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2705470", Offset = "0x2704670", VA = "0x182705470")]
		private void CHLLJHKCGJN(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2706B10", Offset = "0x2705D10", VA = "0x182706B10")]
		private void ODMNODNDHPH(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2705690", Offset = "0x2704890", VA = "0x182705690")]
		private void FPOJMJHBHJG(SceneTag ABHGHJIMPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2705650", Offset = "0x2704850", VA = "0x182705650")]
		private void FJEAPOHKKBH(SceneTag ABHGHJIMPPN, global::JMILGIFBIEP<int> ILAALHLAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2706980", Offset = "0x2705B80", VA = "0x182706980")]
		private void ODFHPMLGGPD(SceneTag ABHGHJIMPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x27068E0", Offset = "0x2705AE0", VA = "0x1827068E0")]
		private void OAMDOAJHMLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x32A8F30", Offset = "0x32A8130", VA = "0x1832A8F30")]
		private void MEIENPNDEDA<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BDIOJKEANGP(SceneTag ABHGHJIMPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2706710", Offset = "0x2705910", VA = "0x182706710")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NDEGPGEMNEF(EntityQuery ADGIOFAMOGF, string KNOPFGAGMCN, SceneTag ABHGHJIMPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2706650", Offset = "0x2705850", VA = "0x182706650")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MFBDFBAAAJM(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DABEJOPAKFL(Entity FEGPGPHCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[OHBLGBNBPGG(IHBBGOJDEFH.PhotonRoom)]
	[PNCLNBNALEO(typeof(AGGPPPAPABE), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	internal class UnitySceneService : CMLEAAEGAAL, AGGPPPAPABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[GAJFPHPAPMA]
		private SceneService JIPLOFKCDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> AECCJENCKAA;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2714780", Offset = "0x2713980", VA = "0x182714780")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2714B30", Offset = "0x2713D30", VA = "0x182714B30", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x27149C0", Offset = "0x2713BC0", VA = "0x1827149C0", Slot = "5")]
		public void NNCFLLMJPFG(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x27147D0", Offset = "0x27139D0", VA = "0x1827147D0", Slot = "6")]
		public bool NBBCCHEHOAG(HPHBHAKAACD EHNNHDBEJOG, Transform FGNGGLFNLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2714710", Offset = "0x2713910", VA = "0x182714710")]
		private bool MBANGKJADLH(Scene FEGPGPHCDJD, out Entity JKJOCKKPHFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2714BC0", Offset = "0x2713DC0", VA = "0x182714BC0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ComponentSystemTypes)]
	[PNCLNBNALEO(typeof(SingletonComponentService), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	internal sealed class SingletonComponentService : CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[GAJFPHPAPMA]
		private NMOCPLDOEBP KECMGBIFIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity LHCPLOHKBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList LGJGAACOOON;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int BPIIJGBNBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x270B570", Offset = "0x270A770", VA = "0x18270B570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity NOIJKFBLFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager KBDBPGCEONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x270BBF0", Offset = "0x270ADF0", VA = "0x18270BBF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x32AA820", Offset = "0x32A9A20", VA = "0x1832AA820")]
		public T HHCPOGCCGNF<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x32AA8E0", Offset = "0x32A9AE0", VA = "0x1832AA8E0")]
		public void PLCAKFAMFIL<T>(T IPMIIEAGJKC) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x270BC40", Offset = "0x270AE40", VA = "0x18270BC40", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x270B3D0", Offset = "0x270A5D0", VA = "0x18270B3D0", Slot = "5")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x270B3D0", Offset = "0x270A5D0", VA = "0x18270B3D0")]
		private void HALCCNMFPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x270B580", Offset = "0x270A780", VA = "0x18270B580", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x270B850", Offset = "0x270AA50", VA = "0x18270B850")]
		private ComponentTypeList GAIKMGBCCPD()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void JHGGPLPKMIP(int BFFJHKFEFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		private static void GNPBIHHIKHI(Type NIFOGEBEDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x270BB50", Offset = "0x270AD50", VA = "0x18270BB50")]
		private static void GHDKADELAIM(Type NIFOGEBEDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct IBNEEBODCDA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[PNCLNBNALEO(typeof(ACMOOCKHEPB), new string[] { })]
internal sealed class ACMOOCKHEPB : CMLEAAEGAAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[GAJFPHPAPMA]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::BPEILBAOPBF<GNABCKLLPCL, Entity> FFMDHDKFNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::PGKKAFJFFBH<PAMKIKPGOKH> HJHOGHOICIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::PGKKAFJFFBH<PIAPKONBGND> JAODOBBJAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::PGKKAFJFFBH<MGDOAIKOGKF> JPEAGKGNGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::PGKKAFJFFBH<LEPDCOPBACH> KOBLHIMHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::PGKKAFJFFBH<NPBBOFDALAN> BBFEJKBBFEI;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::GOBEPPLFEKJ<Entity> CPNOJJNPAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public DDONOJLIGHB FICEIJOPEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public DDONOJLIGHB LODKCLGKEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public DDONOJLIGHB HKNBJNBBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public DDONOJLIGHB HGOJMGMHBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DDONOJLIGHB DIFOPAHBHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F2C0", Offset = "0x2A9E4C0", VA = "0x182A9F2C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F310", Offset = "0x2A9E510", VA = "0x182A9F310", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F1D0", Offset = "0x2A9E3D0", VA = "0x182A9F1D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0xE226B0", Offset = "0xE218B0", VA = "0x180E226B0")]
	private void LLLPMINBGLL<T>(ref global::PGKKAFJFFBH<T> LKGFBGELPCN) where T : struct, OEMKBCGGACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0xE226B0", Offset = "0xE218B0", VA = "0x180E226B0")]
	private void LLLPMINBGLL<TC, TV>(ref global::BPEILBAOPBF<TC, TV> LKGFBGELPCN) where TC : struct, OEMKBCGGACH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ACMOOCKHEPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[PNCLNBNALEO(typeof(BABKCDBKOGM), new string[] { })]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
internal sealed class BABKCDBKOGM : IMFHGBIDMMC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private JEMIGPGNFON PAOGCIEGPME;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public JEMIGPGNFON NOBFHCDKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1BFACB0", Offset = "0x1BF9EB0", VA = "0x181BFACB0")]
		get
		{
			return default(JEMIGPGNFON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2EB0", Offset = "0x2AA20B0", VA = "0x182AA2EB0", Slot = "4")]
	public void DCPKDJKEEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2F00", Offset = "0x2AA2100", VA = "0x182AA2F00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BABKCDBKOGM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(TransformOwnershipPhase), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum MEIGNKONMLP
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct NGEFMECOBIH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private MEIGNKONMLP CIJPJFPBNCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase HHFDFFDPCGO;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x34D99C0", Offset = "0x34D8BC0", VA = "0x1834D99C0")]
			public NGEFMECOBIH(TransformOwnershipPhase HHFDFFDPCGO, MEIGNKONMLP MGADLDPDPGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x34D99A0", Offset = "0x34D8BA0", VA = "0x1834D99A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public MEIGNKONMLP MGADLDPDPGK;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public MEIGNKONMLP BIEJOPAFBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
			get
			{
				return default(MEIGNKONMLP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x7E49D0", Offset = "0x7E3BD0", VA = "0x1807E49D0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool AJMNBPFKMKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDA10", Offset = "0x1FCCC10", VA = "0x181FCDA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool EGKNPJGOGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x82D150", Offset = "0x82C350", VA = "0x18082D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x270EFA0", Offset = "0x270E1A0", VA = "0x18270EFA0")]
		public NGEFMECOBIH GGIALBJIDFI()
		{
			return default(NGEFMECOBIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x270EF70", Offset = "0x270E170", VA = "0x18270EF70")]
		public NGEFMECOBIH ABHAHHJMCJI()
		{
			return default(NGEFMECOBIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[PNCLNBNALEO(typeof(EINBFFEIBHO), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Circuits)]
	public class CircuitsService : CMLEAAEGAAL, EINBFFEIBHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[GAJFPHPAPMA]
		private CBKODGDOCOH FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9B60", Offset = "0x2AA8D60", VA = "0x182AA9B60", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8940", Offset = "0x2AA7B40", VA = "0x182AA8940", Slot = "5")]
		public bool BGCOMFEFMMH(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9A70", Offset = "0x2AA8C70", VA = "0x182AA9A70", Slot = "7")]
		public bool KEOODBJEIIM(HPHBHAKAACD EHNNHDBEJOG, out Guid GLLFFIFLOAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9020", Offset = "0x2AA8220", VA = "0x182AA9020", Slot = "8")]
		public Guid EHBGLDJHJDP(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9810", Offset = "0x2AA8A10", VA = "0x182AA9810", Slot = "9")]
		public void JGMOKMHAFHK(HPHBHAKAACD EHNNHDBEJOG, Guid GLLFFIFLOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8740", Offset = "0x2AA7940", VA = "0x182AA8740", Slot = "10")]
		public bool AGMBHECIJAE(HPHBHAKAACD EHNNHDBEJOG, out Guid KKBFAENPLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8830", Offset = "0x2AA7A30", VA = "0x182AA8830", Slot = "11")]
		public Guid ANANIBBDAHN(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9200", Offset = "0x2AA8400", VA = "0x182AA9200", Slot = "12")]
		public void HEMBEKEAHGB(HPHBHAKAACD EHNNHDBEJOG, Guid KKBFAENPLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA95F0", Offset = "0x2AA87F0", VA = "0x182AA95F0", Slot = "13")]
		public bool ILFFNACOIKA(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9130", Offset = "0x2AA8330", VA = "0x182AA9130", Slot = "14")]
		public void FFPBNIBKPKF(HPHBHAKAACD EHNNHDBEJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8BB0", Offset = "0x2AA7DB0", VA = "0x182AA8BB0", Slot = "15")]
		public void DIGINCDEJIN(HPHBHAKAACD GFCPAMJILIO, HPHBHAKAACD HHFDFFDPCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8A40", Offset = "0x2AA7C40", VA = "0x182AA8A40")]
		private void CHGPBJNJGMD(MGLKJGICKPJ OBAFEPEDJKP, HPHBHAKAACD HHFDFFDPCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9460", Offset = "0x2AA8660", VA = "0x182AA9460")]
		private void HLMOOBHJDFO(MGLKJGICKPJ OBAFEPEDJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9640", Offset = "0x2AA8840", VA = "0x182AA9640")]
		private bool IMNIOHLPDAN(DBJMAFIOFFK ICHBECDKHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8F70", Offset = "0x2AA8170", VA = "0x182AA8F70")]
		private bool DOIIOJPLDBO(DBJMAFIOFFK ICHBECDKHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2AA91A0", Offset = "0x2AA83A0", VA = "0x182AA91A0", Slot = "6")]
		public bool GAHJEFOONOH(HPHBHAKAACD FLKGABKFAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[PNCLNBNALEO(typeof(OCPAEOMCMPM), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Connectables)]
	internal class ConnectableService : OCPAEOMCMPM, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class MDOBMBIFNGM : IEnumerable<HPHBHAKAACD>, IEnumerable, IEnumerator<HPHBHAKAACD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private HPHBHAKAACD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private HPHBHAKAACD localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public HPHBHAKAACD <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private HPHBHAKAACD System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(HPHBHAKAACD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x26FFE00", Offset = "0x26FF000", VA = "0x1826FFE00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x1E99350", Offset = "0x1E98550", VA = "0x181E99350")]
			[DebuggerHidden]
			public MDOBMBIFNGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x26FFE50", Offset = "0x26FF050", VA = "0x1826FFE50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x26FFA10", Offset = "0x26FEC10", VA = "0x1826FFA10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x26FFF20", Offset = "0x26FF120", VA = "0x1826FFF20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x26FFF70", Offset = "0x26FF170", VA = "0x1826FFF70")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x26FFDC0", Offset = "0x26FEFC0", VA = "0x1826FFDC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x26FFD10", Offset = "0x26FEF10", VA = "0x1826FFD10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HPHBHAKAACD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x26FFD10", Offset = "0x26FEF10", VA = "0x1826FFD10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly HDHIMOFHFJL GBJBKCGJAHI;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int HGPFJOEAAPK = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int CLLPMIJNBHN = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EFDNEMMCCPM EDPIJECELAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private MLOAKDLKONO FPLPHBFOJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService GGIAAMGAMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::FPAJBINIPIL<Entity> NPNDHNOOBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::FPAJBINIPIL<float3> FFCHFOJCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::FPAJBINIPIL<quaternion> CGBPMPCDDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::FPAJBINIPIL<Entity> HHFDFFDPCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::FPAJBINIPIL<float3> EGJKEDKNNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::FPAJBINIPIL<quaternion> IBHAEICNMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> NGLDBFJCBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> DCMJGIFLPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery HEEEGDDIHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool KBDIBPJIHNN;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<KEEAFCDJANP> NIMCAGONIOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x91EBD0", Offset = "0x91DDD0", VA = "0x18091EBD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x91EA30", Offset = "0x91DC30", VA = "0x18091EA30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<HPHBHAKAACD, HPHBHAKAACD> DCCMBGCMHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE660", Offset = "0x2AAD860", VA = "0x182AAE660", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE210", Offset = "0x2AAD410", VA = "0x182AAE210", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<HPHBHAKAACD, HPHBHAKAACD> LHPMHJJNDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF0E0", Offset = "0x2AAE2E0", VA = "0x182AAF0E0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE700", Offset = "0x2AAD900", VA = "0x182AAE700", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<HPHBHAKAACD, HPHBHAKAACD, HPHBHAKAACD> ANBLDJAHFLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF180", Offset = "0x2AAE380", VA = "0x182AAF180", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE5C0", Offset = "0x2AAD7C0", VA = "0x182AAE5C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<HPHBHAKAACD> KOFMAOKOPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2AADEF0", Offset = "0x2AAD0F0", VA = "0x182AADEF0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEC50", Offset = "0x2AADE50", VA = "0x182AAEC50", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF400", Offset = "0x2AAE600", VA = "0x182AAF400", Slot = "25")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2AADA50", Offset = "0x2AACC50", VA = "0x182AADA50", Slot = "26")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE310", Offset = "0x2AAD510", VA = "0x182AAE310", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE4C0", Offset = "0x2AAD6C0", VA = "0x182AAE4C0")]
		private void EKDJJEONNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD8E0", Offset = "0x2AACAE0", VA = "0x182AAD8E0")]
		private void AEAHAIAGPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEDA0", Offset = "0x2AADFA0", VA = "0x182AAEDA0")]
		private void MJNEDKKNKHF(Entity LHCPLOHKBCE, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI HKPEMIJGIMD, NFKEKJGDLJI INPBMNIIHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE2B0", Offset = "0x2AAD4B0", VA = "0x182AAE2B0")]
		private void DNGMEIPIBLD(Entity LHCPLOHKBCE, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI HKPEMIJGIMD, NFKEKJGDLJI INPBMNIIHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1725820", Offset = "0x1724A20", VA = "0x181725820", Slot = "14")]
		public HPHBHAKAACD OMKNFCHFCOL(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0xB12A80", Offset = "0xB11C80", VA = "0x180B12A80", Slot = "15")]
		public Color GLOOJNEBOPK(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF220", Offset = "0x2AAE420", VA = "0x182AAF220", Slot = "16")]
		public float3 OBLHOONGEAP(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF580", Offset = "0x2AAE780", VA = "0x182AAF580", Slot = "17")]
		public bool PBBNMDMDELB(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD PFEBBONNCEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAECF0", Offset = "0x2AADEF0", VA = "0x182AAECF0", Slot = "18")]
		public HPHBHAKAACD MFNLLJHOJJL(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE7A0", Offset = "0x2AAD9A0", VA = "0x182AAE7A0", Slot = "21")]
		public void IKHBKMODIJM(HPHBHAKAACD EHNNHDBEJOG, Vector3 GJGMLLFCOAD, Quaternion FLINFHACPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE520", Offset = "0x2AAD720", VA = "0x182AAE520", Slot = "23")]
		public float3 GGEOIKLDDPB(PAOFKDGAONA BGDMKGJPDBD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEBC0", Offset = "0x2AADDC0", VA = "0x182AAEBC0", Slot = "24")]
		public quaternion LAKLCPPGIDG(PAOFKDGAONA BGDMKGJPDBD)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEAC0", Offset = "0x2AADCC0", VA = "0x182AAEAC0", Slot = "28")]
		public RigidTransform LADMBDMOMLN(PAOFKDGAONA BGDMKGJPDBD)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEF60", Offset = "0x2AAE160", VA = "0x182AAEF60", Slot = "22")]
		public bool NDGLBMLNJHA(HPHBHAKAACD EHNNHDBEJOG, out RigidTransform EDOPNMHALFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF630", Offset = "0x2AAE830", VA = "0x182AAF630", Slot = "19")]
		[IteratorStateMachine(typeof(MDOBMBIFNGM))]
		public IEnumerable<HPHBHAKAACD> PPAHCGDHGEO(HPHBHAKAACD EHNNHDBEJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2AADF90", Offset = "0x2AAD190", VA = "0x182AADF90", Slot = "20")]
		public HPHBHAKAACD CNJKGJDMLFO(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE8F0", Offset = "0x2AADAF0", VA = "0x182AAE8F0", Slot = "29")]
		public void KCJCNGKKPFJ(ref List<HPHBHAKAACD> DJGFOAKOCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE0F0", Offset = "0x2AAD2F0", VA = "0x182AAE0F0")]
		private Entity CNJKGJDMLFO(Entity LHCPLOHKBCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF750", Offset = "0x2AAE950", VA = "0x182AAF750")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Prefabs)]
	[PNCLNBNALEO(typeof(ObjectInstantiationService), new string[] { })]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	internal sealed class ObjectInstantiationService : CMLEAAEGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM PHAHHGAAFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[GAJFPHPAPMA]
		private MKPDCEPKKNF ODDNMDPHLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[GAJFPHPAPMA]
		private NONFIILBABE CBHMNKMMFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[GAJFPHPAPMA]
		private ObjectNetworkToLocalMapService BDHLICLKMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[GAJFPHPAPMA]
		private ObjectLifecycleService FBCDDJGNMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[GAJFPHPAPMA]
		private ObjectPrefabs ELFOBADGBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[GAJFPHPAPMA]
		private DCDKBJNNODB BONABHPADBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private PLHDIIJFCAF PNLHDLKHNBP;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int PCMDGMDIKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8800", Offset = "0x2AF7A00", VA = "0x182AF8800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2AF89B0", Offset = "0x2AF7BB0", VA = "0x182AF89B0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8930", Offset = "0x2AF7B30", VA = "0x182AF8930")]
		public Entity NFOGFCJILOM(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8950", Offset = "0x2AF7B50", VA = "0x182AF8950")]
		public Entity OADPHDJIIGP(HCIIHJLICJK MIBPNJCOIHL, CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8410", Offset = "0x2AF7610", VA = "0x182AF8410")]
		public Entity CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB, bool GFHAAPIGHIF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8400", Offset = "0x2AF7600", VA = "0x182AF8400")]
		public Entity CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8720", Offset = "0x2AF7920", VA = "0x182AF8720")]
		public Entity JFFGKANLKKJ()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2AF88B0", Offset = "0x2AF7AB0", VA = "0x182AF88B0")]
		public Entity MEMDCEONKOF(HAGCJKKHBBM NIFOGEBEDNG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8730", Offset = "0x2AF7930", VA = "0x182AF8730")]
		public Entity KCJIMEICAKG(JCHIOIGOACO NIFOGEBEDNG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2AF86D0", Offset = "0x2AF78D0", VA = "0x182AF86D0")]
		public NativeArray<(HPHBHAKAACD, HPHBHAKAACD)> CLKBEFKLIOC(NativeArray<HPHBHAKAACD> KLBGBDPJKJM, Allocator HCEMBCPANJM)
		{
			return default(NativeArray<(HPHBHAKAACD, HPHBHAKAACD)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF87B0", Offset = "0x2AF79B0", VA = "0x182AF87B0")]
		public IEnumerable<CNKGPKGDJHD> KKMPNCFKPHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF83A0", Offset = "0x2AF75A0", VA = "0x182AF83A0")]
		public EntityArchetype BLHLGFJPIOA(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8850", Offset = "0x2AF7A50", VA = "0x182AF8850")]
		public Entity MDPEOFOIHOD(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8650", Offset = "0x2AF7850", VA = "0x182AF8650")]
		private Entity CGNJCAAHIDC(CNKGPKGDJHD FNGBDAJENGB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF85C0", Offset = "0x2AF77C0", VA = "0x182AF85C0")]
		private Entity CGNJCAAHIDC(CNKGPKGDJHD FNGBDAJENGB, bool GFHAAPIGHIF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF84A0", Offset = "0x2AF76A0", VA = "0x182AF84A0")]
		private Entity CGNJCAAHIDC(CNKGPKGDJHD FNGBDAJENGB, HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[PNCLNBNALEO(typeof(OHHINBMLFAA), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Physics)]
	public sealed class PhysicsSceneColliderService : OHHINBMLFAA, AAKFCNNNLEL, IMFHGBIDMMC, CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string KHADGDBKDNC = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int KCBJCKOMPMI = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int KBPGHBLFCMF = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[GAJFPHPAPMA]
		private DAHJGPKAIEK MAHBIJBCNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] JOMAMFOCFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] MNEDGGFKOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::MFEFOKNAOGN<EKNJLMLFPKH, BoxCollider> CLNDGGIBBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene FEGPGPHCDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene CJHJLCJOJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject GDEKLMNKJBC;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int JLCIPHLEMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2B05ED0", Offset = "0x2B050D0", VA = "0x182B05ED0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FA0", Offset = "0x2B041A0", VA = "0x182B04FA0", Slot = "9")]
		public void DCPKDJKEEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2B05E10", Offset = "0x2B05010", VA = "0x182B05E10", Slot = "10")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2B05110", Offset = "0x2B04310", VA = "0x182B05110", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2B059C0", Offset = "0x2B04BC0", VA = "0x182B059C0", Slot = "4")]
		public EKNJLMLFPKH MLEHOKPOHJC(Entity LHCPLOHKBCE)
		{
			return default(EKNJLMLFPKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2B04BA0", Offset = "0x2B03DA0", VA = "0x182B04BA0", Slot = "5")]
		public void BLFMLIAKMFJ(NativeArray<EKNJLMLFPKH> OBDCNEMMCJC, NativeArray<DBFJJBPOONO> DBPFJELGIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2B05210", Offset = "0x2B04410", VA = "0x182B05210", Slot = "6")]
		public void EEEDFOICKPB(EKNJLMLFPKH PLFCHHKILCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B60", Offset = "0x2B04D60", VA = "0x182B05B60", Slot = "7")]
		public bool OGHENDLJIOJ(EKNJLMLFPKH PLFCHHKILCM, out Collider ADMCDJKKCIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05670", Offset = "0x2B04870", VA = "0x182B05670")]
		public bool KHDIAAGJBJI(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, Allocator HCEMBCPANJM, out NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B10", Offset = "0x2B04D10", VA = "0x182B05B10")]
		private void NEKOMDKIDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xB9AB00", Offset = "0xB99D00", VA = "0x180B9AB00")]
		private void LBHFJINGOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B05620", Offset = "0x2B04820", VA = "0x182B05620")]
		private void KHBIECFFKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x768940", Offset = "0x767B40", VA = "0x180768940")]
		private void EAKKIDJMBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B05320", Offset = "0x2B04520", VA = "0x182B05320")]
		private BoxCollider FHICGIOMBNH(Entity LHCPLOHKBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2B05480", Offset = "0x2B04680", VA = "0x182B05480")]
		private void JAEHPPFJLKL(BoxCollider DNNNHENCFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2B052E0", Offset = "0x2B044E0", VA = "0x182B052E0")]
		[Conditional("UNITY_EDITOR")]
		private void EHDJFHIKCLN(GameObject BMNLOPDIJGF, Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2B04DB0", Offset = "0x2B03FB0", VA = "0x182B04DB0")]
		private void DCEKGNDKJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2B05510", Offset = "0x2B04710", VA = "0x182B05510")]
		private void KBPBHIJBNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C00", Offset = "0x2B04E00", VA = "0x182B05C00")]
		private void OIMNMBJEKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2B05440", Offset = "0x2B04640", VA = "0x182B05440")]
		private void GFKJBDFDPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2B05470", Offset = "0x2B04670", VA = "0x182B05470")]
		private void HIBJMDANGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2B05980", Offset = "0x2B04B80", VA = "0x182B05980")]
		private void KKJEGDFFILL(Scene BNBFEKHCOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05500", Offset = "0x2B04700", VA = "0x182B05500", Slot = "8")]
		private bool JBMLBCDBKGK(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, Allocator HCEMBCPANJM, out NativeArray<Entity> EJIAHCPIPFJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[PNCLNBNALEO(typeof(MPKKBBECOPF), new string[] { })]
public sealed class DIKCNGDAIEC : MPKKBBECOPF, CMLEAAEGAAL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct KJLIFFCEAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float IAKGPAAHECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint DJGCMHNEBOC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private AAKFCNNNLEL INNAMCKKHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private GNAIBKODMII CAMPNBEEHBD;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5DD0", Offset = "0x2AB4FD0", VA = "0x182AB5DD0", Slot = "5")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5920", Offset = "0x2AB4B20", VA = "0x182AB5920")]
	public bool KHDIAAGJBJI(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, out GGLOEKDBMCM BBOLIJMGKDH, out Entity EGHGAHNDMAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5810", Offset = "0x2AB4A10", VA = "0x182AB5810")]
	public static bool BJGBMEEMAJM(in Span<GGLOEKDBMCM> IPECGOFJCED, float GKJHODLJDHD, out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5DA0", Offset = "0x2AB4FA0", VA = "0x182AB5DA0")]
	public static float LIIPMMPEMEG(float IAKGPAAHECM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public DIKCNGDAIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5910", Offset = "0x2AB4B10", VA = "0x182AB5910", Slot = "4")]
	private bool IGGBKBJGKHK(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, out GGLOEKDBMCM BBOLIJMGKDH, out Entity EGHGAHNDMAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[PNCLNBNALEO(typeof(GNAIBKODMII), new string[] { })]
public sealed class MPLHOGDLJDA : GNAIBKODMII, CMLEAAEGAAL
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct KJAOJHGMNFI : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> EJIAHCPIPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 MJLEEEJHOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 PFHEGEHJKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GPOHCKGBAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> BHCAEJENNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> ADEGAHPFOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> GCCLKGPNHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> NKLAIJIDLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<GGLOEKDBMCM> NIHFFPBNCBI;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly GGLOEKDBMCM JHIEAKALCKN;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x34D6A40", Offset = "0x34D5C40", VA = "0x1834D6A40", Slot = "4")]
		public void Execute(int GMEHLIHLGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x34D6D20", Offset = "0x34D5F20", VA = "0x1834D6D20")]
		private static float3 FJEOCJEPJOL(in float4x4 CJHEDPFOCKO, in float3 COLMAMKJPJE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x34D7110", Offset = "0x34D6310", VA = "0x1834D7110")]
		private static float3 MLAGNNEOMII(in float4x4 CJHEDPFOCKO, in float3 ENDFPEOPAIK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x34D7010", Offset = "0x34D6210", VA = "0x1834D7010")]
		private static float3 LGBPMMCBMEL(in float4x4 CJHEDPFOCKO, in float3 COLMAMKJPJE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x34D6DF0", Offset = "0x34D5FF0", VA = "0x1834D6DF0")]
		private static float3 KDFENDDLHOH(in float4x4 CJHEDPFOCKO, in float3 ENDFPEOPAIK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x34D72D0", Offset = "0x34D64D0", VA = "0x1834D72D0")]
		private bool OJBKAPJPNHB(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, in NativeArray<Entity> HKBPOHBDPJE, out float3 BBOLIJMGKDH, out float3 CHEKLLFMKBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x34D6370", Offset = "0x34D5570", VA = "0x1834D6370")]
		public static bool EONKOHHABIK(in float3 OPOIAIGKJCB, in float3 FMIDKKKJPOP, in float3 ALPKJAFNCJH, in float3 GIBIDFGNIFP, float FMBPNGIGKKL, float EACAGOOIFKJ, out float IHPJCBCPLCM, out float3 OPFODHFENED)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager IIODDCGHDHF;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x2AF06B0", Offset = "0x2AEF8B0", VA = "0x182AF06B0", Slot = "5")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x2AF01C0", Offset = "0x2AEF3C0", VA = "0x182AF01C0")]
	public void KHDIAAGJBJI(in NativeArray<Entity> EJIAHCPIPFJ, in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, in NativeArray<GGLOEKDBMCM> HDNIHMEOOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public MPLHOGDLJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x2AF06A0", Offset = "0x2AEF8A0", VA = "0x182AF06A0", Slot = "4")]
	private void OFIACPDEDII(in NativeArray<Entity> EJIAHCPIPFJ, in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, in NativeArray<GGLOEKDBMCM> HDNIHMEOOJD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[CGDKNMKPKIP(OOBCCNCEGNI.Embodiment)]
	[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
	[PNCLNBNALEO(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[GAJFPHPAPMA]
		private DGHIBPMIJHM HIJDILOKICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[GAJFPHPAPMA]
		private MKPDCEPKKNF DJGPLCMADNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[GAJFPHPAPMA]
		private NONFIILBABE DCCNDPPOHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<HCIIHJLICJK, Entity> DOBPAMNIMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager IIODDCGHDHF;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<HCIIHJLICJK, Entity> FDIEOJMMPFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x9D0E30", Offset = "0x9D0030", VA = "0x1809D0E30")]
			get
			{
				return default(NativeHashMap<HCIIHJLICJK, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint GIJDJPDNJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFBDB0", Offset = "0x2AFAFB0", VA = "0x182AFBDB0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool ICJICHLKHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0xD10740", Offset = "0xD0F940", VA = "0x180D10740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xFBE0C0", Offset = "0xFBD2C0", VA = "0x180FBE0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF40", Offset = "0x2AFB140", VA = "0x182AFBF40", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA70", Offset = "0x2AFAC70", VA = "0x182AFBA70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBAE0", Offset = "0x2AFACE0", VA = "0x182AFBAE0")]
		public void GLBPPAIACJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBBF0", Offset = "0x2AFADF0", VA = "0x182AFBBF0")]
		public void JGJABLEBJKP(HCIIHJLICJK MIBPNJCOIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEB0", Offset = "0x2AFB0B0", VA = "0x182AFBEB0")]
		private HPHBHAKAACD NFLHCPFJANJ(Entity LHCPLOHKBCE)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB8A0", Offset = "0x2AFAAA0", VA = "0x182AFB8A0")]
		public HPHBHAKAACD ADIDIKPFHIK(HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(HPHBHAKAACD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB980", Offset = "0x2AFAB80", VA = "0x182AFB980")]
		public HCIIHJLICJK ANDMDOJLAPG(HPHBHAKAACD EHNNHDBEJOG)
		{
			return default(HCIIHJLICJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB60", Offset = "0x2AFAD60", VA = "0x182AFBB60")]
		public void JEFFIJPPDGP(Entity LHCPLOHKBCE, HCIIHJLICJK MIBPNJCOIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBEE0", Offset = "0x2AFB0E0", VA = "0x182AFBEE0")]
		public void OGFKGHGKNKE(Entity LHCPLOHKBCE, HCIIHJLICJK MIBPNJCOIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBA10", Offset = "0x2AFAC10", VA = "0x182AFBA10")]
		public void CDDNCAHILFM(Entity LHCPLOHKBCE, HCIIHJLICJK MIBPNJCOIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBDE0", Offset = "0x2AFAFE0", VA = "0x182AFBDE0")]
		public void MPNFJKFILJC(Entity LHCPLOHKBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
	[PNCLNBNALEO(typeof(PropertyEventCallbacksService), new string[] { })]
	[CGDKNMKPKIP(OOBCCNCEGNI.Callbacks)]
	public class PropertyEventCallbacksService : CMLEAAEGAAL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct AMAIEJLNCDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public LAIKGKINLJB ONAFALABHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type NIFOGEBEDNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int CAPKFCHDLFA;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct ACNHAOBPJMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public AMAIEJLNCDA[] BBBOEOJJCHM;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void LAIKGKINLJB(Entity LHCPLOHKBCE, GFCMOFDOMMJ CHIEJFHOPDP, NFKEKJGDLJI HKPEMIJGIMD, NFKEKJGDLJI INPBMNIIHJJ);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<GFCMOFDOMMJ, LAIKGKINLJB> BIFFOMEIIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, ACNHAOBPJMK> EBJBKNFHLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private IIEGBNJCKEO BBBOEOJJCHM;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action DJJHOKEMDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C1D0", Offset = "0x2B0B3D0", VA = "0x182B0C1D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C130", Offset = "0x2B0B330", VA = "0x182B0C130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action LHPBEDDCKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C800", Offset = "0x2B0BA00", VA = "0x182B0C800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2B0C270", Offset = "0x2B0B470", VA = "0x182B0C270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C8A0", Offset = "0x2B0BAA0", VA = "0x182B0C8A0", Slot = "4")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B8D0", Offset = "0x2B0AAD0", VA = "0x182B0B8D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B670", Offset = "0x2B0A870", VA = "0x182B0B670")]
		public void BNAKCAAHHPA(GFCMOFDOMMJ CHIEJFHOPDP, LAIKGKINLJB ONAFALABHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B7E0", Offset = "0x2B0A9E0", VA = "0x182B0B7E0")]
		public void DMGMPLBCGKC(GFCMOFDOMMJ CHIEJFHOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BEA0", Offset = "0x2B0B0A0", VA = "0x182B0BEA0")]
		internal void EGPJABCDHJO(GIDNMOCOABH DADHJJNJEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B960", Offset = "0x2B0AB60", VA = "0x182B0B960")]
		private void EDFGMEDPDNM(GIDNMOCOABH DADHJJNJEFA, int BEBJDDHDFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C580", Offset = "0x2B0B780", VA = "0x182B0C580")]
		private void MKJIBNDJCCG(NDGJEHEDOED KDHBALDHKBN, BKDBNLPNJFE DOAJAAMEOLM, AMAIEJLNCDA LAKCDODEPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C310", Offset = "0x2B0B510", VA = "0x182B0C310")]
		private ACNHAOBPJMK KGILNPBOMBH(NDGJEHEDOED KDHBALDHKBN, BKDBNLPNJFE DOAJAAMEOLM)
		{
			return default(ACNHAOBPJMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C490", Offset = "0x2B0B690", VA = "0x182B0C490")]
		private AMAIEJLNCDA LJFGIBCDPEJ(ACNHAOBPJMK FMEBKGHCHLH, NDGJEHEDOED KDHBALDHKBN, BKDBNLPNJFE DOAJAAMEOLM)
		{
			return default(AMAIEJLNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C940", Offset = "0x2B0BB40", VA = "0x182B0C940")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[PNCLNBNALEO(typeof(IKAKIKODLMN), new string[] { })]
public class HELLLCBAEFD : CMLEAAEGAAL, BDLDACMOPAJ, IKAKIKODLMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class PALJMGMMJCP : IEnumerable<HPHBHAKAACD>, IEnumerable, IEnumerator<HPHBHAKAACD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private HPHBHAKAACD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public HELLLCBAEFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private HPHBHAKAACD splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public HPHBHAKAACD <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private HPHBHAKAACD System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HPHBHAKAACD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x34DB9B0", Offset = "0x34DABB0", VA = "0x1834DB9B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x1E99350", Offset = "0x1E98550", VA = "0x181E99350")]
		[DebuggerHidden]
		public PALJMGMMJCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x34DB800", Offset = "0x34DAA00", VA = "0x1834DB800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x34DB970", Offset = "0x34DAB70", VA = "0x1834DB970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x34DB8C0", Offset = "0x34DAAC0", VA = "0x1834DB8C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HPHBHAKAACD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x34DB8C0", Offset = "0x34DAAC0", VA = "0x1834DB8C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private ADGAEKGGBOB OAFODAKDAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService ELFOBADGBAE;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x269FD80", Offset = "0x269EF80", VA = "0x18269FD80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private DKCBHGMJMEO GHECNMHOJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x269F410", Offset = "0x269E610", VA = "0x18269F410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x26A0140", Offset = "0x269F340", VA = "0x1826A0140", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x269F010", Offset = "0x269E210", VA = "0x18269F010", Slot = "5")]
	public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x269F6B0", Offset = "0x269E8B0", VA = "0x18269F6B0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x269FDD0", Offset = "0x269EFD0", VA = "0x18269FDD0")]
	private void OCOIIIABGMJ(Entity LFMHLKNFOGL, in NFKEKJGDLJI JMJKKGAMABE, in NFKEKJGDLJI DLEMNBPMGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x269F950", Offset = "0x269EB50", VA = "0x18269F950", Slot = "14")]
	public HPHBHAKAACD JFFGKANLKKJ()
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x269F460", Offset = "0x269E660", VA = "0x18269F460", Slot = "10")]
	public void BPNJEPENEBD(HPHBHAKAACD EHNNHDBEJOG, FCILLPHFLHB HMJOKPKOPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x269F760", Offset = "0x269E960", VA = "0x18269F760", Slot = "9")]
	public FCILLPHFLHB EKGNDHHKMGK(HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(FCILLPHFLHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x269F110", Offset = "0x269E310", VA = "0x18269F110", Slot = "11")]
	public HPHBHAKAACD ANKDFLBBJOM(HPHBHAKAACD MIJLKPMKNKG, [Optional] Vector3? INLGLHIPOMC, [Optional] Quaternion? HEGBBJCMANH, [Optional] Vector3? JDFDFBKKBPO)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x269F850", Offset = "0x269EA50", VA = "0x18269F850", Slot = "15")]
	public HPHBHAKAACD IJKLALBAHFI(HPHBHAKAACD IIEKDGEBNBJ, int GMEHLIHLGEH, [Optional] Vector3? INLGLHIPOMC, [Optional] Quaternion? HEGBBJCMANH, [Optional] Vector3? JDFDFBKKBPO)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x26A0050", Offset = "0x269F250", VA = "0x1826A0050", Slot = "7")]
	public HPHBHAKAACD OPGMOHIDPFL(HPHBHAKAACD IIEKDGEBNBJ, int GMEHLIHLGEH)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x269F550", Offset = "0x269E750", VA = "0x18269F550", Slot = "16")]
	public void CEONFNJFJOP(HPHBHAKAACD IIEKDGEBNBJ, HPHBHAKAACD JJJFDLFNLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x269F9B0", Offset = "0x269EBB0", VA = "0x18269F9B0", Slot = "12")]
	public void JHIKBCLEFPO(HPHBHAKAACD IIEKDGEBNBJ, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x269FBE0", Offset = "0x269EDE0", VA = "0x18269FBE0", Slot = "17")]
	public void LBEJKKOBAEP(HPHBHAKAACD IIEKDGEBNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x269F610", Offset = "0x269E810", VA = "0x18269F610", Slot = "8")]
	public int DNGBIEGCECA(HPHBHAKAACD IIEKDGEBNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x269FB50", Offset = "0x269ED50", VA = "0x18269FB50", Slot = "6")]
	[IteratorStateMachine(typeof(PALJMGMMJCP))]
	public IEnumerable<HPHBHAKAACD> KMNABEBBBIK(HPHBHAKAACD IIEKDGEBNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x269EF80", Offset = "0x269E180", VA = "0x18269EF80")]
	private bool AACHPGNDFAD(HPHBHAKAACD IIEKDGEBNBJ, out NativeArray<Entity> OKKDPEMOHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x269F890", Offset = "0x269EA90", VA = "0x18269F890")]
	private NativeArray<Entity> JDOJLMHACDL(HPHBHAKAACD IIEKDGEBNBJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public HELLLCBAEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
[PNCLNBNALEO(typeof(ANCFFMHODFD), new string[] { })]
internal sealed class ANCFFMHODFD : CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private DGHIBPMIJHM PHAHHGAAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase NFKHPOBLOFA;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private NNHDOGKABEI JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0420", Offset = "0x2A9F620", VA = "0x182AA0420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0560", Offset = "0x2A9F760", VA = "0x182AA0560", Slot = "4")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0470", Offset = "0x2A9F670", VA = "0x182AA0470")]
	public void GNJBNLCKHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0150", Offset = "0x2A9F350", VA = "0x182AA0150")]
	public void ALHDDFNBNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public ANCFFMHODFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct JJMPBECJGDP : IEquatable<JJMPBECJGDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int BEBJDDHDFCD;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type MMMENNAAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x26AD330", Offset = "0x26AC530", VA = "0x1826AD330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x26AD510", Offset = "0x26AC710", VA = "0x1826AD510")]
	public JJMPBECJGDP(Type NIFOGEBEDNG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x26AD4B0", Offset = "0x26AC6B0", VA = "0x1826AD4B0")]
	public static JJMPBECJGDP GJGPFJHFLAE(Type NIFOGEBEDNG)
	{
		return default(JJMPBECJGDP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x26AD490", Offset = "0x26AC690", VA = "0x1826AD490")]
	public static Type GJGPFJHFLAE(JJMPBECJGDP PLFCHHKILCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x865EB0", Offset = "0x8650B0", VA = "0x180865EB0")]
	public static bool IGOCGGBJBII(JJMPBECJGDP NNMPJECKECI, JJMPBECJGDP EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x865EB0", Offset = "0x8650B0", VA = "0x180865EB0")]
	public static bool BHBKJCPJNJN(JJMPBECJGDP NNMPJECKECI, JJMPBECJGDP EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x865E70", Offset = "0x865070", VA = "0x180865E70", Slot = "4")]
	public bool Equals(JJMPBECJGDP HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x26AD410", Offset = "0x26AC610", VA = "0x1826AD410", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x26AD4E0", Offset = "0x26AC6E0", VA = "0x1826AD4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class IAOMHIJEJNK
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> PMHKPLJCEKO;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> DFDNLPPPGMN;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x26A7240", Offset = "0x26A6440", VA = "0x1826A7240")]
	static IAOMHIJEJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x227B180", Offset = "0x227A380", VA = "0x18227B180")]
	public static bool CPCILMEHKPA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x26A6D90", Offset = "0x26A5F90", VA = "0x1826A6D90")]
	public static bool CPCILMEHKPA(Type NIFOGEBEDNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x26A6E00", Offset = "0x26A6000", VA = "0x1826A6E00")]
	private static bool CPCILMEHKPA(Type NIFOGEBEDNG, out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x227B210", Offset = "0x227A410", VA = "0x18227B210")]
	public static int GFMNNFCLLJF<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F70", Offset = "0x26A6170", VA = "0x1826A6F70")]
	public static int GFMNNFCLLJF(Type NIFOGEBEDNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x227B2A0", Offset = "0x227A4A0", VA = "0x18227B2A0")]
	public static bool IJDPOKFHBJA<T>(out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x26A71A0", Offset = "0x26A63A0", VA = "0x1826A71A0")]
	public static bool IJDPOKFHBJA(Type NIFOGEBEDNG, out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x26A6FE0", Offset = "0x26A61E0", VA = "0x1826A6FE0")]
	public static Type HHCPOGCCGNF(int GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x26A7080", Offset = "0x26A6280", VA = "0x1826A7080")]
	public static bool IJDPOKFHBJA(int GMEHLIHLGEH, out Type NIFOGEBEDNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct MBMHLKLMDDC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] PCPEJHIMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int MNKGPEKFPKK;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x1448B70", Offset = "0x1447D70", VA = "0x181448B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x12F4C90", Offset = "0x12F3E90", VA = "0x1812F4C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> EAIOPKGLAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2430", Offset = "0x2DD1630", VA = "0x182DD2430")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0xB42B00", Offset = "0xB41D00", VA = "0x180B42B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2580", Offset = "0x2DD1780", VA = "0x182DD2580")]
	public MBMHLKLMDDC(int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2DD24D0", Offset = "0x2DD16D0", VA = "0x182DD24D0")]
	public int JEBHMABMKPB(T IPMIIEAGJKC, int EBEICGFALNG, int BFFJHKFEFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2370", Offset = "0x2DD1570", VA = "0x182DD2370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct BMDAGHONEOE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::MBMHLKLMDDC<T> PCPEJHIMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int MNKGPEKFPKK;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x1EB77E0", Offset = "0x1EB69E0", VA = "0x181EB77E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x1EB6690", Offset = "0x1EB5890", VA = "0x181EB6690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int EPBJKODLMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x1EB71E0", Offset = "0x1EB63E0", VA = "0x181EB71E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x1EB62E0", Offset = "0x1EB54E0", VA = "0x181EB62E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7870", Offset = "0x1EB6A70", VA = "0x181EB7870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> EAIOPKGLAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x1EB69D0", Offset = "0x1EB5BD0", VA = "0x181EB69D0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7920", Offset = "0x1EB6B20", VA = "0x181EB7920")]
	public BMDAGHONEOE(int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x1EB66E0", Offset = "0x1EB58E0", VA = "0x181EB66E0")]
	public T FMKCEDFCBNE(int GMEHLIHLGEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6800", Offset = "0x1EB5A00", VA = "0x181EB6800")]
	public void HHIALCNGNNB(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6F30", Offset = "0x1EB6130", VA = "0x181EB6F30")]
	public void LCPGLALIAHK(Span<T> JAAGBDPDCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6330", Offset = "0x1EB5530", VA = "0x181EB6330")]
	public void CPCILMEHKPA(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6DB0", Offset = "0x1EB5FB0", VA = "0x181EB6DB0")]
	private void KMCIKAHLOHC(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x1EB5F80", Offset = "0x1EB5180", VA = "0x181EB5F80")]
	public void AKIKAHMEOBL(Span<T> DKIPBFCBBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x1EB67A0", Offset = "0x1EB59A0", VA = "0x181EB67A0")]
	public void GKEOCICPDND(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7210", Offset = "0x1EB6410", VA = "0x181EB7210")]
	public void NIDPFAKGKND(int MAPKBMLINGC, int OGINPOLMPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7780", Offset = "0x1EB6980", VA = "0x181EB7780")]
	public void PDJCDCJJNPH(int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7430", Offset = "0x1EB6630", VA = "0x181EB7430")]
	public void OAAPHNINABP(int MAPKBMLINGC, int OGINPOLMPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x1EB61C0", Offset = "0x1EB53C0", VA = "0x181EB61C0")]
	public void BEDBGNEFMAM(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6B20", Offset = "0x1EB5D20", VA = "0x181EB6B20")]
	public void IOKAOEEECFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6BE0", Offset = "0x1EB5DE0", VA = "0x181EB6BE0")]
	public int JEBHMABMKPB(T IPMIIEAGJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6280", Offset = "0x1EB5480", VA = "0x181EB6280")]
	public bool BPCENLKELKP(T IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6440", Offset = "0x1EB5640", VA = "0x181EB6440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x1EB78B0", Offset = "0x1EB6AB0", VA = "0x181EB78B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6730", Offset = "0x1EB5930", VA = "0x181EB6730")]
	public static Span<T> GJGPFJHFLAE(global::BMDAGHONEOE<T> JAAGBDPDCIE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6C70", Offset = "0x1EB5E70", VA = "0x181EB6C70")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JIMKKFOMKGO(int IPMIIEAGJKC, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void IICMAAKBFBB(int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6870", Offset = "0x1EB5A70", VA = "0x181EB6870")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IICMAAKBFBB(int MNKGPEKFPKK, int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x1EB70A0", Offset = "0x1EB62A0", VA = "0x181EB70A0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void LIOBCMGJKHF(int IPMIIEAGJKC, int MNKGPEKFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x1EB6490", Offset = "0x1EB5690", VA = "0x181EB6490")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void ELJPBIPHLCG(int MAPKBMLINGC, int OGINPOLMPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB7640", Offset = "0x1EB6840", VA = "0x181EB7640")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void PBNILJAOHDN(int IPMIIEAGJKC, int MNKGPEKFPKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct JEMIGPGNFON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int CKCMGLEMGJO = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> EJIAHCPIPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray EDPIJECELAJ;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x26AC110", Offset = "0x26AB310", VA = "0x1826AC110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> JFJGIMNFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray LNIJIKJGBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x26AC2C0", Offset = "0x26AB4C0", VA = "0x1826AC2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x26AC400", Offset = "0x26AB600", VA = "0x1826AC400")]
	public JEMIGPGNFON(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x26AC3B0", Offset = "0x26AB5B0", VA = "0x1826AC3B0")]
	public Entity KBPIPFJPHLM(int GMEHLIHLGEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x26AC3A0", Offset = "0x26AB5A0", VA = "0x1826AC3A0")]
	public Transform IPMPHFIAIJC(int GMEHLIHLGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x26AC270", Offset = "0x26AB470", VA = "0x1826AC270")]
	public void ECBIPIHPKEP(int FAPOEIDOLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x26AC120", Offset = "0x26AB320", VA = "0x1826AC120")]
	public int CPCILMEHKPA(Transform FGNGGLFNLIP, Entity LHCPLOHKBCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x26AC2E0", Offset = "0x26AB4E0", VA = "0x1826AC2E0")]
	public int GKEOCICPDND(int GMEHLIHLGEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x26AC1F0", Offset = "0x26AB3F0", VA = "0x1826AC1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x26AC360", Offset = "0x26AB560", VA = "0x1826AC360")]
	private void IAOBBGLKGDC(int GMPECCKAPPO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class JFCAMHEHMID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<JJMPBECJGDP, int2> EBDBNFEAAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> ACMMHKGMFIC;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x26ACBC0", Offset = "0x26ABDC0", VA = "0x1826ACBC0")]
	public JFCAMHEHMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x26AC6E0", Offset = "0x26AB8E0", VA = "0x1826AC6E0")]
	public void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void PLCAKFAMFIL<T>(T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T HHCPOGCCGNF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x26AC980", Offset = "0x26ABB80", VA = "0x1826AC980")]
	public void PLCAKFAMFIL(Type NIFOGEBEDNG, NFKEKJGDLJI IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x26AC740", Offset = "0x26AB940", VA = "0x1826AC740")]
	public NFKEKJGDLJI HHCPOGCCGNF(Type NIFOGEBEDNG)
	{
		return default(NFKEKJGDLJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x26AC480", Offset = "0x26AB680", VA = "0x1826AC480")]
	private NativeArray<byte> BANDGAMINIE(int2 MPFECMKLDFD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x26AC520", Offset = "0x26AB720", VA = "0x1826AC520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x26AC5C0", Offset = "0x26AB7C0", VA = "0x1826AC5C0", Slot = "1")]
	~JFCAMHEHMID()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct BIKINNFLMKK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::BIKINNFLMKK<T> GJGPFJHFLAE(T IPMIIEAGJKC)
	{
		return default(global::BIKINNFLMKK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T GJGPFJHFLAE(global::BIKINNFLMKK<T> GFLAEOLMKMC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class ICIFKNDJJOP
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly JFCAMHEHMID FMPPCFELPGD;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x26A74E0", Offset = "0x26A66E0", VA = "0x1826A74E0")]
	internal static void GLBPPAIACJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void PLCAKFAMFIL<T>(T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x26A7630", Offset = "0x26A6830", VA = "0x1826A7630")]
	public static void PLCAKFAMFIL(Type NIFOGEBEDNG, NFKEKJGDLJI IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T HHCPOGCCGNF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x26A7590", Offset = "0x26A6790", VA = "0x1826A7590")]
	public static NFKEKJGDLJI HHCPOGCCGNF(Type NIFOGEBEDNG)
	{
		return default(NFKEKJGDLJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class LFOCFOOAHBN : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly LFOCFOOAHBN FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2AECFE0", Offset = "0x2AEC1E0", VA = "0x182AECFE0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FCCGDNMAHPA, LinkedEntityGroup BADLFKONABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2AED000", Offset = "0x2AEC200", VA = "0x182AED000", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ICHBECDKHOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public LFOCFOOAHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class BCGIJGCCBHF
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void IAELPJJJLKI(in Vector3 INLGLHIPOMC, in Quaternion HEGBBJCMANH, in Vector3 JDFDFBKKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void AMEMHADEHAG(in Vector3 ICCMEFDDKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void DACIFLBFLHP(in Quaternion HEGBBJCMANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void EMCBMPPCIKG(in Vector3 IGMDHMAILAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void IECBBLDPCFG(in Vector3 IGMDHMAILAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void EILAGIJFHEA(in float PDNBMOJFPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3160", Offset = "0x2AA2360", VA = "0x182AA3160")]
	[Conditional("DEBUG_BUILD")]
	public static void MDLKEOGIPEM(in float3 IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	[Conditional("DEBUG_BUILD")]
	public static void NMAGBICBANO(in float IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3240", Offset = "0x2AA2440", VA = "0x182AA3240")]
	[Conditional("DEBUG_BUILD")]
	public static void NMAGBICBANO(in Vector3 IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3210", Offset = "0x2AA2410", VA = "0x182AA3210")]
	[Conditional("DEBUG_BUILD")]
	public static void NMAGBICBANO(in Quaternion IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3300", Offset = "0x2AA2500", VA = "0x182AA3300")]
	[Conditional("DEBUG_BUILD")]
	public static void PMFDEMDGIOP(in float IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2AA32C0", Offset = "0x2AA24C0", VA = "0x182AA32C0")]
	[Conditional("DEBUG_BUILD")]
	public static void PMFDEMDGIOP(in Vector3 IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3290", Offset = "0x2AA2490", VA = "0x182AA3290")]
	[Conditional("DEBUG_BUILD")]
	public static void PMFDEMDGIOP(in Quaternion IPMIIEAGJKC, string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BCGIJGCCBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct NIEMJPNNGFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity LHCPLOHKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity FLHBBDGHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity BDBBMBMDCFP;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF10D0", Offset = "0x2AF02D0", VA = "0x182AF10D0")]
	public NIEMJPNNGFN(Entity LHCPLOHKBCE, Entity FLHBBDGHDCM, Entity BDBBMBMDCFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1070", Offset = "0x2AF0270", VA = "0x182AF1070")]
	public static NIEMJPNNGFN GJGPFJHFLAE((Entity entity, Entity oldParent, Entity newParent) EKJEPNEDGAP)
	{
		return default(NIEMJPNNGFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF10B0", Offset = "0x2AF02B0", VA = "0x182AF10B0")]
	public void HABFEFJGGOE(out Entity LHCPLOHKBCE, out Entity FLHBBDGHDCM, out Entity BDBBMBMDCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct NLOCLNGHLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity LHCPLOHKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity HHFDFFDPCGO;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA230", Offset = "0x1BF9430", VA = "0x181BFA230")]
	public NLOCLNGHLHN(Entity LHCPLOHKBCE, Entity HHFDFFDPCGO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1240", Offset = "0x2AF0440", VA = "0x182AF1240")]
	public static NLOCLNGHLHN GJGPFJHFLAE((Entity entity, Entity parent) EKJEPNEDGAP)
	{
		return default(NLOCLNGHLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1270", Offset = "0x2AF0470", VA = "0x182AF1270")]
	public void HABFEFJGGOE(out Entity LHCPLOHKBCE, out Entity HHFDFFDPCGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct KCPNLBADAAH<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle PLFCHHKILCM;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool EHHLLHOCBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2163740", Offset = "0x2162940", VA = "0x182163740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x21635B0", Offset = "0x21627B0", VA = "0x1821635B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x2163650", Offset = "0x2162850", VA = "0x182163650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2163750", Offset = "0x2162950", VA = "0x182163750")]
	public KCPNLBADAAH(T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2163710", Offset = "0x2162910", VA = "0x182163710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum EFDGIEOLLMH
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct CHBJMJOMPJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public EFDGIEOLLMH ENKMDOKIHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int BFMAMEIHANL;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
	public CHBJMJOMPJA(EFDGIEOLLMH ENKMDOKIHHM, int BFMAMEIHANL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70B0", Offset = "0x2AA62B0", VA = "0x182AA70B0")]
	public static CHBJMJOMPJA GJGPFJHFLAE((EFDGIEOLLMH eventType, int eventIndex) FCCGDNMAHPA)
	{
		return default(CHBJMJOMPJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2AA70D0", Offset = "0x2AA62D0", VA = "0x182AA70D0")]
	public void HABFEFJGGOE(out EFDGIEOLLMH ENKMDOKIHHM, out int BFMAMEIHANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[PNCLNBNALEO(typeof(AAKFCNNNLEL), new string[] { })]
public sealed class NKDGMIJKFLA : AAKFCNNNLEL, CMLEAAEGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private OHHINBMLFAA NGAKIPILJGD;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF11D0", Offset = "0x2AF03D0", VA = "0x182AF11D0", Slot = "5")]
	public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF10E0", Offset = "0x2AF02E0", VA = "0x182AF10E0")]
	public bool KHDIAAGJBJI(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, Allocator HCEMBCPANJM, out NativeArray<Entity> EJIAHCPIPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NKDGMIJKFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF10E0", Offset = "0x2AF02E0", VA = "0x182AF10E0", Slot = "4")]
	private bool JBMLBCDBKGK(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, Allocator HCEMBCPANJM, out NativeArray<Entity> EJIAHCPIPFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[MPMKPCGOCAF]
[UpdateInGroup(typeof(NOMOGFCIADP))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class ICILBOJIGFH : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x26A77C0", Offset = "0x26A69C0", VA = "0x1826A77C0", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public ICILBOJIGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[MPMKPCGOCAF]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
[UpdateInGroup(typeof(EPPHCBJCGJF))]
public sealed class DONHIONDDGM : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x2AB78F0", Offset = "0x2AB6AF0", VA = "0x182AB78F0", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public DONHIONDDGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[MPMKPCGOCAF]
[UpdateInGroup(typeof(DFJBFFLDIPJ))]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
internal sealed class LCLMPCPFDBK : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x26B1810", Offset = "0x26B0A10", VA = "0x1826B1810", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public LCLMPCPFDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class AJKGBBOOPAJ : KDBBKADLGNC
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public AJKGBBOOPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[MPMKPCGOCAF]
[ExecuteAlways]
[CFJADOACGIL(IHBBGOJDEFH.LoadInstance)]
[UpdateInGroup(typeof(BBJFHGJFLOG))]
internal sealed class KDMHFPHOAPE : HCIIOJALALA
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x26AE110", Offset = "0x26AD310", VA = "0x1826AE110", Slot = "16")]
	protected override ComponentSystemBase EIEDLCCHMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x269D1A0", Offset = "0x269C3A0", VA = "0x18269D1A0")]
	public KDMHFPHOAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[AOMPPMBGCFH(typeof(AuthoredLocalPoseData))]
public sealed class LFJNLALLAAF : EPKOBKCDGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x26B3850", Offset = "0x26B2A50", VA = "0x1826B3850", Slot = "8")]
	protected override bool OOCPMEIOPFA(ReadOnlySpan<AuthoredLocalPoseData> DKIPBFCBBBG, EEJKADCLIHN ABLKPOMPEKC, out ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x26B3790", Offset = "0x26B2990", VA = "0x1826B3790", Slot = "9")]
	protected override bool HPNNOMNIJED(int EOGFAFNNICF, Span<AuthoredLocalPoseData> DKIPBFCBBBG, in ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x26B38D0", Offset = "0x26B2AD0", VA = "0x1826B38D0")]
	public LFJNLALLAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[AOMPPMBGCFH(typeof(LocalPoseData))]
public sealed class LJJLNKGNFDL : BKFJCDOFECI
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED9C0", Offset = "0x2AECBC0", VA = "0x182AED9C0", Slot = "8")]
	protected override bool OOCPMEIOPFA(ReadOnlySpan<LocalPoseData> DKIPBFCBBBG, EEJKADCLIHN ABLKPOMPEKC, out ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2AED900", Offset = "0x2AECB00", VA = "0x182AED900", Slot = "9")]
	protected override bool HPNNOMNIJED(int EOGFAFNNICF, Span<LocalPoseData> DKIPBFCBBBG, in ReadOnlySpan<byte> NDFFNBIIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA40", Offset = "0x2AECC40", VA = "0x182AEDA40")]
	public LJJLNKGNFDL()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x271C640", Offset = "0x271B840", VA = "0x18271C640", Slot = "6")]
		public sealed override void FHPMCAKDNGP(DAOLJFMJMGL ONAFALABHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x271D660", Offset = "0x271C860", VA = "0x18271D660", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0730", Offset = "0x2AEF930", VA = "0x182AF0730")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0840", Offset = "0x2AEFA40", VA = "0x182AF0840")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
