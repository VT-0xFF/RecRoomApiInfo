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
public sealed class FBCJLMHGEOK<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class MINKKIFIDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::FBCJLMHGEOK<T> BOMMMPNDCJJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] FIGAANFKKBP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public MINKKIFIDBB(global::FBCJLMHGEOK<T> BOMMMPNDCJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GJDLHJHBDFG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::FBCJLMHGEOK<T> <>4__this;

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
		public GJDLHJHBDFG(int <>1__state)
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
	private const int FMCBBHJCJBF = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> GICGKCLJLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int AILAJNKGIFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T IHLOOLPGFPM
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
	private bool CFLJFFCDDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool IFGAKHJKEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool PJNKBNOEJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LFCNNPBFNIK
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
	public int IIEJMBAKGHF
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
	public FBCJLMHGEOK(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public FBCJLMHGEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void AJKNHJEFJIF(int EGBCAPEEJBF, T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void PJBBGDBFNGB(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] IFPMJMGFJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void FOKDDJLFMJA(NativeArray<T> EGIDMCNFHCK, int FMNFDAHCLKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::FBCJLMHGEOK<>.GJDLHJHBDFG))]
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
	public int LGFPODHHMBH(T DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool PMMODKPOELK(T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void INBFPNOGHIO(int PADOBLBIEON, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void MDMOJLMIALE(int PADOBLBIEON, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void GEDMAICKFNB(int PADOBLBIEON, int LKCJJEBACFP, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int EPBGFJHHGCO(int EGBCAPEEJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T HJPKOIJHKCI(int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void NNDADIMMGBL(int EGBCAPEEJBF, T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void COEKCJLFOCI(int EGBCAPEEJBF, T DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void HGIDEOAFNGI(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int FDJPBHBOFMH(int KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int IPJOJEJONJM(int KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void KDDFFMGEIAC(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void PNKKOPMBJJP(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T FLLCNMAAKGF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T BOJMCOLKFAD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void JJDOCPKBGDI(int EGBCAPEEJBF, IReadOnlyCollection<T> MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void DGPFDDAEDHC(int EGBCAPEEJBF, int HONGFBDNEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void HBPCBHPDNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void FMLBANEBGHC(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void LBOMJIAPKDL(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void JIKJIAINCEG(int LKCJJEBACFP, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T FJKKDOKEBEL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T IEAKGEPKLBN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NCFMNHDMAHK]
public static class BACKMEJJOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D14160", Offset = "0x2D13160", VA = "0x182D14160")]
	static BACKMEJJOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x328BDB0", Offset = "0x328ADB0", VA = "0x18328BDB0")]
	public static void PEMAFCFLIEJ<T>(T GLOMCJNAEIH, ref T KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D13FD0", Offset = "0x2D12FD0", VA = "0x182D13FD0")]
	public static void PEMAFCFLIEJ(FixedString32 GLOMCJNAEIH, ref string KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D13F50", Offset = "0x2D12F50", VA = "0x182D13F50")]
	public static void PEMAFCFLIEJ(string GLOMCJNAEIH, ref FixedString32 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D14090", Offset = "0x2D13090", VA = "0x182D14090")]
	public static void PEMAFCFLIEJ(FixedString64 GLOMCJNAEIH, ref string KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D14030", Offset = "0x2D13030", VA = "0x182D14030")]
	public static void PEMAFCFLIEJ(string GLOMCJNAEIH, ref FixedString64 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D14130", Offset = "0x2D13130", VA = "0x182D14130")]
	public static void PEMAFCFLIEJ(MJMNFMKBJIH GLOMCJNAEIH, ref Vector3 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D13EF0", Offset = "0x2D12EF0", VA = "0x182D13EF0")]
	public static void PEMAFCFLIEJ(Vector3 GLOMCJNAEIH, ref MJMNFMKBJIH KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D14000", Offset = "0x2D13000", VA = "0x182D14000")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref Vector4 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E80", Offset = "0x2D12E80", VA = "0x182D13E80")]
	public static void PEMAFCFLIEJ(Vector4 GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D14000", Offset = "0x2D13000", VA = "0x182D14000")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref Quaternion KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E80", Offset = "0x2D12E80", VA = "0x182D13E80")]
	public static void PEMAFCFLIEJ(Quaternion GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D13DF0", Offset = "0x2D12DF0", VA = "0x182D13DF0")]
	public static void PEMAFCFLIEJ(MJMNFMKBJIH GLOMCJNAEIH, ref float3 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D13EF0", Offset = "0x2D12EF0", VA = "0x182D13EF0")]
	public static void PEMAFCFLIEJ(float3 GLOMCJNAEIH, ref MJMNFMKBJIH KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E20", Offset = "0x2D12E20", VA = "0x182D13E20")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref float4 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E80", Offset = "0x2D12E80", VA = "0x182D13E80")]
	public static void PEMAFCFLIEJ(float4 GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E20", Offset = "0x2D12E20", VA = "0x182D13E20")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref quaternion KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D140C0", Offset = "0x2D130C0", VA = "0x182D140C0")]
	public static void PEMAFCFLIEJ(quaternion GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D13F90", Offset = "0x2D12F90", VA = "0x182D13F90")]
	public static void PEMAFCFLIEJ(Entity GLOMCJNAEIH, ref MDJLKHGDBCE KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D13E60", Offset = "0x2D12E60", VA = "0x182D13E60")]
	public static void PEMAFCFLIEJ(MDJLKHGDBCE GLOMCJNAEIH, ref Entity KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BEOLFPGNHND]
public class BFFFIIHIBEB : ComponentSystem, MIBCENMOHFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FEPIHHOJCOJ LOLLNGHJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MNJAFLLCGLD OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D15BA0", Offset = "0x2D14BA0", VA = "0x182D15BA0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
	public BFFFIIHIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BEOLFPGNHND]
[UpdateInGroup(typeof(CAOCCHHGBCN))]
internal class GLMDBLKBNNA : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x30E0AF0", Offset = "0x30DFAF0", VA = "0x1830E0AF0", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x30E0A70", Offset = "0x30DFA70", VA = "0x1830E0A70")]
	[Preserve]
	private void IHEOGMAENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public GLMDBLKBNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BEOLFPGNHND]
[UpdateInGroup(typeof(CAOCCHHGBCN))]
internal class AMBBOCEBBMJ : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D11D90", Offset = "0x2D10D90", VA = "0x182D11D90", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public AMBBOCEBBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6360", Offset = "0x2AB5360", VA = "0x182AB6360")]
		public static ObjectModelConfigAsset IHLBCLFNJEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE23C60", Offset = "0xE22C60", VA = "0x180E23C60")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[OHGELDJCNJM(GGAOONGBEBH.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int GDFEBAPAIEO = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly JHCDFELAIDH AOHKNGHOEPF;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x41436A0", Offset = "0x41426A0", VA = "0x1841436A0")]
			public static IJDKBBDMEBI GBHAGFGCIEP(int LPKIPPIIMKJ)
			{
				return default(IJDKBBDMEBI);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4143510", Offset = "0x4142510", VA = "0x184143510")]
			private static void AODNNJGAIJH(GPEJGMHBDPO HHDOKHJIBAD, GPEJGMHBDPO FEHBBDMJOCH, IJDKBBDMEBI DGPLFECNDCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4143A90", Offset = "0x4142A90", VA = "0x184143A90")]
			public static int IKMHMDNOMMB(GameObject BLPBCMIHDMD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4143C60", Offset = "0x4142C60", VA = "0x184143C60")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void LAFOPEJGOKN(GPEJGMHBDPO GBPGPLEPLBP, int LPKIPPIIMKJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static DDFGGHLLPGI MBIOGPPGEOG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static PLHAEEKILKB ALNGLBHBEKI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DDFGGHLLPGI JKCHCJNIPFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6570", Offset = "0x2AB5570", VA = "0x182AB6570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6C40", Offset = "0x2AB5C40", VA = "0x182AB6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static PLHAEEKILKB JFDMKHENBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6E20", Offset = "0x2AB5E20", VA = "0x182AB6E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7020", Offset = "0x2AB6020", VA = "0x182AB7020")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool DGIKKNHIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7240", Offset = "0x2AB6240", VA = "0x182AB7240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FEPIHHOJCOJ LOLLNGHJAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7BA0", Offset = "0x2AB6BA0", VA = "0x182AB7BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static MNJAFLLCGLD OMJDBNDAANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6D20", Offset = "0x2AB5D20", VA = "0x182AB6D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static EHCGNDKDHFM FAMBGOHJMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2AB76B0", Offset = "0x2AB66B0", VA = "0x182AB76B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static NNPPGMKPBPK NMOFOMIKKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6400", Offset = "0x2AB5400", VA = "0x182AB6400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FOBNDAGEMLO FPIICNIIOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6DA0", Offset = "0x2AB5DA0", VA = "0x182AB6DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static CGDDJBMDAKP AKFBLEDGEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7D80", Offset = "0x2AB6D80", VA = "0x182AB7D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool AMBDDFHIMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6F40", Offset = "0x2AB5F40", VA = "0x182AB6F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool OIJEJAPNBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7730", Offset = "0x2AB6730", VA = "0x182AB7730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool DCOCGOHKOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6720", Offset = "0x2AB5720", VA = "0x182AB6720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool BKCPMHDPPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7C40", Offset = "0x2AB6C40", VA = "0x182AB7C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7650", Offset = "0x2AB6650", VA = "0x182AB7650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool NIBAEDKKIOA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7E00", Offset = "0x2AB6E00", VA = "0x182AB7E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7FE0", Offset = "0x2AB6FE0", VA = "0x182AB7FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action NKOIMHHPNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7400", Offset = "0x2AB6400", VA = "0x182AB7400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2AB7980", Offset = "0x2AB6980", VA = "0x182AB7980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6480", Offset = "0x2AB5480", VA = "0x182AB6480")]
		public static GPEJGMHBDPO BPFLLEIAFPB(GameObject BLPBCMIHDMD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB73A0", Offset = "0x2AB63A0", VA = "0x182AB73A0")]
		public static bool JBIJHELDJID(ByteString BMHLFOOGPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7A80", Offset = "0x2AB6A80", VA = "0x182AB7A80")]
		public static CDFLNPBCBAA MAMJHGMNPEO(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AB65D0", Offset = "0x2AB55D0", VA = "0x182AB65D0")]
		public static (ByteString, IDisposable) CJKIIDNIDDE()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7500", Offset = "0x2AB6500", VA = "0x182AB7500")]
		public static (ByteString, IDisposable) JGECDNFPBAM(IEnumerable<GPEJGMHBDPO> CMLLBIKBAEF)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6910", Offset = "0x2AB5910", VA = "0x182AB6910")]
		public static bool EHGJDJBMNBB(GameObject BLPBCMIHDMD, out IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7860", Offset = "0x2AB6860", VA = "0x182AB7860")]
		public static bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7CA0", Offset = "0x2AB6CA0", VA = "0x182AB7CA0")]
		public static void NJLLPDINJFK(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7E60", Offset = "0x2AB6E60", VA = "0x182AB7E60")]
		public static Task PGBHOMEMIJD(bool IGPDCEGDODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6B60", Offset = "0x2AB5B60", VA = "0x182AB6B60")]
		private static PLHAEEKILKB FBBCMMBONPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6A40", Offset = "0x2AB5A40", VA = "0x182AB6A40")]
		private static bool EOHECENMFIE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[OHGELDJCNJM(GGAOONGBEBH.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC9F0", Offset = "0x2ABB9F0", VA = "0x182ABC9F0")]
		public static bool BCMCEFMMKOB(EMAJLAJEHKH PFHGJECLIGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCAA0", Offset = "0x2ABBAA0", VA = "0x182ABCAA0")]
		public static EMAJLAJEHKH GBHABPPKBJN(GameObject BLPBCMIHDMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCCD0", Offset = "0x2ABBCD0", VA = "0x182ABCCD0")]
		public static EMAJLAJEHKH GBHABPPKBJN(GameObject BLPBCMIHDMD, IJDKBBDMEBI DGPLFECNDCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD1C0", Offset = "0x2ABC1C0", VA = "0x182ABD1C0")]
		public static bool OMDHKONIAAB(GameObject LOCIAIPOBLA, string ANCBAFIJPAE, bool JHOHJFFPNPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCFC0", Offset = "0x2ABBFC0", VA = "0x182ABCFC0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void NFJDPFLAOPI(GameObject LOCIAIPOBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2ABCED0", Offset = "0x2ABBED0", VA = "0x182ABCED0")]
		[CompilerGenerated]
		internal static string LEAGNKJBDLM((GameObject go, string prefabName) KCPODLJODHA)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, KLCPDNGMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GPEJGMHBDPO PJKAPDAPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GPEJGMHBDPO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x28EBA70", Offset = "0x28EAA70", VA = "0x1828EBA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[OHGELDJCNJM(GGAOONGBEBH.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, EMAJLAJEHKH, KLCPDNGMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string FLPGGBIMNJC = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JOIKFKIBIDF KFCHBPFAEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GPEJGMHBDPO LCCDBPIJCNE;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public GPEJGMHBDPO PJKAPDAPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x30D3200", Offset = "0x30D2200", VA = "0x1830D3200", Slot = "15")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public CDFLNPBCBAA HJKKKHLKLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x30D32B0", Offset = "0x30D22B0", VA = "0x1830D32B0", Slot = "6")]
			get
			{
				return default(CDFLNPBCBAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x30D31F0", Offset = "0x30D21F0", VA = "0x1830D31F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public JOIKFKIBIDF GDOPJIHDKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9B94F0", Offset = "0x9B84F0", VA = "0x1809B94F0", Slot = "7")]
			get
			{
				return default(JOIKFKIBIDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MNJAFLLCGLD OMJDBNDAANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x30D28F0", Offset = "0x30D18F0", VA = "0x1830D28F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EOBKLCMHAME CPCMBJKPKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x30D2890", Offset = "0x30D1890", VA = "0x1830D2890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool HPJFGMAKOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> DKOHJIMIECE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x30D30B0", Offset = "0x30D20B0", VA = "0x1830D30B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x30D32E0", Offset = "0x30D22E0", VA = "0x1830D32E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EMAJLAJEHKH> JFLFBIIMDGA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x30D3150", Offset = "0x30D2150", VA = "0x1830D3150", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x30D3380", Offset = "0x30D2380", VA = "0x1830D3380", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x30D25C0", Offset = "0x30D15C0", VA = "0x1830D25C0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x30D2E10", Offset = "0x30D1E10", VA = "0x1830D2E10", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x30D2AC0", Offset = "0x30D1AC0", VA = "0x1830D2AC0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x30D2D80", Offset = "0x30D1D80", VA = "0x1830D2D80", Slot = "10")]
		public void OnEmbody(EEPEPNPEOFG BKFHGKOCNCC, GPEJGMHBDPO LCCDBPIJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x30D2E00", Offset = "0x30D1E00", VA = "0x1830D2E00", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x30D2B70", Offset = "0x30D1B70", VA = "0x1830D2B70", Slot = "12")]
		public void OnDisembody(bool PMMCMPPCHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x30D2F60", Offset = "0x30D1F60", VA = "0x1830D2F60")]
		private void PEAAOCOHBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x30D29D0", Offset = "0x30D19D0", VA = "0x1830D29D0")]
		private void IEPKMGFHODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x30D27A0", Offset = "0x30D17A0", VA = "0x1830D27A0")]
		private void CMONGHJDGLF(bool MFNFGLHHIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x30D2A60", Offset = "0x30D1A60", VA = "0x1830D2A60", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xF01540", Offset = "0xF00540", VA = "0x180F01540", Slot = "9")]
		private GameObject IIEHCKMBMLB()
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
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[OHGELDJCNJM(GGAOONGBEBH.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override OBNHEEKLBIB HJPKBHBAGHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6420", Offset = "0x2AC5420", VA = "0x182AC6420", Slot = "6")]
			get
			{
				return default(OBNHEEKLBIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC63C0", Offset = "0x2AC53C0", VA = "0x182AC63C0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[OHGELDJCNJM(GGAOONGBEBH.Registration)]
	public class TransformEntity : MonoBehaviour, KLCPDNGMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private OBNHEEKLBIB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GPEJGMHBDPO GBPGPLEPLBP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual OBNHEEKLBIB HJPKBHBAGHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0", Slot = "6")]
			get
			{
				return default(OBNHEEKLBIB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x783430", Offset = "0x782430", VA = "0x180783430", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GPEJGMHBDPO PJKAPDAPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC10C00", Offset = "0xC0FC00", VA = "0x180C10C00", Slot = "5")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA49830", Offset = "0xA48830", VA = "0x180A49830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity OIMONIPJMNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal FOBNDAGEMLO FPIICNIIOKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal EOBKLCMHAME OMHHCDEFKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C93180", Offset = "0x2C92180", VA = "0x182C93180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C92D90", Offset = "0x2C91D90", VA = "0x182C92D90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C931F0", Offset = "0x2C921F0", VA = "0x182C931F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C92E70", Offset = "0x2C91E70", VA = "0x182C92E70")]
		internal void JHHOMPLGCBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C92DD0", Offset = "0x2C91DD0", VA = "0x182C92DD0")]
		private bool DADIFHMBCFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C92DA0", Offset = "0x2C91DA0", VA = "0x182C92DA0")]
		private void BNMMGJOPBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C931F0", Offset = "0x2C921F0", VA = "0x182C931F0")]
		internal void NCMANBGJLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C932E0", Offset = "0x2C922E0", VA = "0x182C932E0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C933C0", Offset = "0x2C923C0", VA = "0x182C933C0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[IABFONFHPFO(typeof(PLHAEEKILKB), new string[] { })]
[DBACNPOLGIH(typeof(AHENLKMMNNA))]
public class JNFIKBCHEPC : PLHAEEKILKB, BDIPMKLAHKL, AHENLKMMNNA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EHPGCEGHLNO HPFBGIEBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MNJAFLLCGLD FGEEBMNILFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JILOIECAIMB HCMHLLALCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PJNMANJFEMH JGIJGKDIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JJLHCHOLEPN GGBBONCEEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EHPGCEGHLNO LOLLNGHJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KHCCBBJDMKM JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MNJAFLLCGLD OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PJNMANJFEMH JJCHHCLNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JJLHCHOLEPN JMBHPDNDFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x891B10", Offset = "0x890B10", VA = "0x180891B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x30E9330", Offset = "0x30E8330", VA = "0x1830E9330", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PIEGKGHOKCE JBBLCINBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94C020", Offset = "0x94B020", VA = "0x18094C020", Slot = "10")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x30E9340", Offset = "0x30E8340", VA = "0x1830E9340")]
	public static JNFIKBCHEPC BMDGCEOIEEG(EHPGCEGHLNO HPFBGIEBCLA, DGHHMLJKDPD HGNBPKPAAFI = DGHHMLJKDPD.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void PKFBLPCDBDE(EHPGCEGHLNO HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void FEPCAGCDNJE(EHPGCEGHLNO HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x30E9490", Offset = "0x30E8490", VA = "0x1830E9490", Slot = "11")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x281C930", Offset = "0x281B930", VA = "0x18281C930")]
	private void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30E95E0", Offset = "0x30E85E0", VA = "0x1830E95E0")]
	private void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x30E9430", Offset = "0x30E8430", VA = "0x1830E9430", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public JNFIKBCHEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FMAFJGMFEKD
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x30DB0D0", Offset = "0x30DA0D0", VA = "0x1830DB0D0")]
	public static CDFLNPBCBAA NFKICFAFKEF(this PLHAEEKILKB ALNGLBHBEKI, IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
	{
		return default(CDFLNPBCBAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x30DAFB0", Offset = "0x30D9FB0", VA = "0x1830DAFB0")]
	public static NBODNKOLKBD LOKKOCJOODO(this PLHAEEKILKB ALNGLBHBEKI)
	{
		return default(NBODNKOLKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x30DADD0", Offset = "0x30D9DD0", VA = "0x1830DADD0")]
	public static GPEJGMHBDPO BPFLLEIAFPB(this PLHAEEKILKB ALNGLBHBEKI, Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x30DAE80", Offset = "0x30D9E80", VA = "0x1830DAE80")]
	public static GPEJGMHBDPO BPFLLEIAFPB(this PLHAEEKILKB ALNGLBHBEKI, IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x30DACB0", Offset = "0x30D9CB0", VA = "0x1830DACB0")]
	public static IJDKBBDMEBI BAAKGEKGEDO(this PLHAEEKILKB ALNGLBHBEKI, GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(IJDKBBDMEBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum DGHHMLJKDPD
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
[IABFONFHPFO(typeof(JJLHCHOLEPN), new string[] { })]
public class KEPELEKJKFL : JJLHCHOLEPN, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[JOODLPJEDOA]
	private AHENLKMMNNA ACCCBDFPKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EHPGCEGHLNO HPFBGIEBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EPLLJMMPLGC JGIJGKDIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JILOIECAIMB HCMHLLALCKJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NCMCNCFCLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x30EC410", Offset = "0x30EB410", VA = "0x1830EC410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x30EC110", Offset = "0x30EB110", VA = "0x1830EC110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x30EC200", Offset = "0x30EB200", VA = "0x1830EC200", Slot = "16")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x30EC370", Offset = "0x30EB370", VA = "0x1830EC370", Slot = "13")]
	public void LDFIGNNEJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "6")]
	public void NEMOFPFLNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x30EC1B0", Offset = "0x30EB1B0", VA = "0x1830EC1B0", Slot = "7")]
	public void JBNMEOHKANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x30EBFC0", Offset = "0x30EAFC0", VA = "0x1830EBFC0", Slot = "8")]
	public void EBALAAGLHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1494810", Offset = "0x1493810", VA = "0x181494810", Slot = "9")]
	public void FLHDAFPJPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x30EC070", Offset = "0x30EB070", VA = "0x1830EC070", Slot = "10")]
	public void GGOEDFNGDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x30EC2B0", Offset = "0x30EB2B0", VA = "0x1830EC2B0", Slot = "11")]
	public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x30EC0C0", Offset = "0x30EB0C0", VA = "0x1830EC0C0", Slot = "12")]
	public void HBECBLLPJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x30EC4B0", Offset = "0x30EB4B0", VA = "0x1830EC4B0", Slot = "14")]
	public void OHBHCAIGIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x30EC3B0", Offset = "0x30EB3B0", VA = "0x1830EC3B0", Slot = "15")]
	public void LGOJHIHHOKC(bool CEHAMLKELDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x30EC040", Offset = "0x30EB040", VA = "0x1830EC040")]
	private void EMBHMOKLPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public KEPELEKJKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IABFONFHPFO(typeof(PJNMANJFEMH), new string[] { })]
public class NGGFKJHIIKO : PJNMANJFEMH, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[JOODLPJEDOA]
	private AHENLKMMNNA ACCCBDFPKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EHPGCEGHLNO HPFBGIEBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EPLLJMMPLGC JGIJGKDIPGB;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AACE70", Offset = "0x2AABE70", VA = "0x182AACE70", Slot = "6")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AACCF0", Offset = "0x2AABCF0", VA = "0x182AACCF0", Slot = "4")]
	public ByteString CJKIIDNIDDE(out IDisposable FIOJMHPAHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AACD50", Offset = "0x2AABD50", VA = "0x182AACD50", Slot = "5")]
	public void EOLLHEJPBAN(ByteString FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public NGGFKJHIIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class PLOKGEGHGGL<T> : global::KMKEHABABIL<T>, global::PKAHIOONALH<IJDKBBDMEBI, T>, global::DFDBMCBGAEF<IJDKBBDMEBI>, OHACNMOLGIH, IDisposable, AGAFPGKKJCP where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::DFDBMCBGAEF<Entity> MLIELKFMALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate NIJJEEPIMIN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C140", Offset = "0x3D0B140", VA = "0x183D0C140", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type DBLKLNHCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CFA0", Offset = "0x3D0BFA0", VA = "0x183D0CFA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EBDBOJDCJEC HAKFDIMBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C8F0", Offset = "0x3D0B8F0", VA = "0x183D0C8F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int HPBCENIKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D110F0", Offset = "0x3D100F0", VA = "0x183D110F0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IOBEOAGNJJA FGOPDNCKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CB70", Offset = "0x3D0BB70", VA = "0x183D0CB70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34695D0", Offset = "0x34685D0", VA = "0x1834695D0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3469C80", Offset = "0x3468C80", VA = "0x183469C80", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MOFEKMBHHLI<IJDKBBDMEBI> NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D110", Offset = "0x3D0C110", VA = "0x183D0D110", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F260", Offset = "0x3D0E260", VA = "0x183D0F260", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x29B8370", Offset = "0x29B7370", VA = "0x1829B8370")]
	public PLOKGEGHGGL(global::DFDBMCBGAEF<Entity> MLIELKFMALM, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D082C0", Offset = "0x3D072C0", VA = "0x183D082C0")]
	private Entity BAGBAIEEPPJ(IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34650A0", Offset = "0x34640A0", VA = "0x1834650A0")]
	private IJDKBBDMEBI BAGBAIEEPPJ(Entity PJEENOLDJIO)
	{
		return default(IJDKBBDMEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D09E30", Offset = "0x3D08E30", VA = "0x183D09E30", Slot = "4")]
	public T BOEAFIEBIHC(IJDKBBDMEBI DGPLFECNDCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DE60", Offset = "0x3D0CE60", VA = "0x183D0DE60")]
	public bool JPNFGACMGOG(IJDKBBDMEBI DGPLFECNDCD, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B010", Offset = "0x3D0A010", VA = "0x183D0B010")]
	public bool CBCHFBKJCOA(IJDKBBDMEBI DGPLFECNDCD, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D086D0", Offset = "0x3D076D0", VA = "0x183D086D0", Slot = "9")]
	public bool BKIFKBMENNF(IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x346ABD0", Offset = "0x3469BD0", VA = "0x18346ABD0", Slot = "26")]
	public object IIKMGFNOMEN(IJDKBBDMEBI DGPLFECNDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F930", Offset = "0x3D0E930", VA = "0x183D0F930")]
	public bool LAOIDJMPGGI(IJDKBBDMEBI DGPLFECNDCD, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3465F00", Offset = "0x3464F00", VA = "0x183465F00")]
	public void BOEAFIEBIHC(IJDKBBDMEBI DGPLFECNDCD, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x346C0E0", Offset = "0x346B0E0", VA = "0x18346C0E0")]
	public bool JPNFGACMGOG(IJDKBBDMEBI DGPLFECNDCD, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x34685F0", Offset = "0x34675F0", VA = "0x1834685F0")]
	public bool CBCHFBKJCOA(IJDKBBDMEBI DGPLFECNDCD, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C30", Offset = "0x29B3C30", VA = "0x1829B4C30", Slot = "22")]
	public void LPKKHPLBIJM(PAOKNLKENHE NIICHBPFANE, [Optional] object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3D106D0", Offset = "0x3D0F6D0", VA = "0x183D106D0", Slot = "15")]
	public void LPKKHPLBIJM(IJDKBBDMEBI EBOIOCBODNI, FDCKEIMNKII NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3469690", Offset = "0x3468690", VA = "0x183469690", Slot = "14")]
	public bool EBGLHADENDP(IJDKBBDMEBI KMOLMNMNMNO, IJDKBBDMEBI GLOMCJNAEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x26948D0", Offset = "0x26938D0", VA = "0x1826948D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3D14A40", Offset = "0x3D13A40", VA = "0x183D14A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x29B0150", Offset = "0x29AF150", VA = "0x1829B0150")]
	public string HADDKMAPJJJ(in MPOLKMCKMLM PCAFGDJMGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E310", Offset = "0x3D0D310", VA = "0x183D0E310")]
	private void KDHLIDENPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ABD0", Offset = "0x3D09BD0", VA = "0x183D0ABD0")]
	private void BONCDEDJNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3D132A0", Offset = "0x3D122A0", VA = "0x183D132A0")]
	private void PIOCKEMLGJJ(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C440", Offset = "0x3D0B440", VA = "0x183D0C440")]
	private void FCDILPBBFPE(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3D11FA0", Offset = "0x3D10FA0", VA = "0x183D11FA0")]
	[Conditional("DEBUG_BUILD")]
	private static void NLOGCFCJHJP(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD, string GPBJNICHLBB, string LHIPDNIACGO, [CallerMemberName] string OCAFPAEFJBH = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x30005E0", Offset = "0x2FFF5E0", VA = "0x1830005E0", Slot = "5")]
	private bool HCFPKDINMOF(IJDKBBDMEBI EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3031630", Offset = "0x3030630", VA = "0x183031630", Slot = "6")]
	private bool NIDONLBPICE(IJDKBBDMEBI EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x346A860", Offset = "0x3469860", VA = "0x18346A860", Slot = "10")]
	private bool HECAKJABJIL(IJDKBBDMEBI EBOIOCBODNI, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x346FA20", Offset = "0x346EA20", VA = "0x18346FA20", Slot = "11")]
	private void NIMMJDPMIPD(IJDKBBDMEBI EBOIOCBODNI, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3469660", Offset = "0x3468660", VA = "0x183469660", Slot = "12")]
	private bool CEOJKKAGMAP(IJDKBBDMEBI EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x346A470", Offset = "0x3469470", VA = "0x18346A470", Slot = "13")]
	private bool GPEOPABKOBB(IJDKBBDMEBI EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x29042C0", Offset = "0x29032C0", VA = "0x1829042C0", Slot = "16")]
	private string FJBHAFABONB(in MPOLKMCKMLM KPPLMEOMNGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DIJBCAAPJBG<T> : global::FMNGHOMPIJM<T>, global::PKAHIOONALH<GPEJGMHBDPO, T>, global::DFDBMCBGAEF<GPEJGMHBDPO>, OHACNMOLGIH, IDisposable, MGJBDIBFMNC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::DFDBMCBGAEF<Entity> MLIELKFMALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate NIJJEEPIMIN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x29AF610", Offset = "0x29AE610", VA = "0x1829AF610", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type DBLKLNHCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x29B08E0", Offset = "0x29AF8E0", VA = "0x1829B08E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public EBDBOJDCJEC HAKFDIMBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x29AFE20", Offset = "0x29AEE20", VA = "0x1829AFE20", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HPBCENIKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x29B5900", Offset = "0x29B4900", VA = "0x1829B5900", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IOBEOAGNJJA FGOPDNCKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x29B03F0", Offset = "0x29AF3F0", VA = "0x1829B03F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x29AEC40", Offset = "0x29ADC40", VA = "0x1829AEC40", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x29AF6A0", Offset = "0x29AE6A0", VA = "0x1829AF6A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MOFEKMBHHLI<GPEJGMHBDPO> NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x29B10B0", Offset = "0x29B00B0", VA = "0x1829B10B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x29B3760", Offset = "0x29B2760", VA = "0x1829B3760", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x29B8370", Offset = "0x29B7370", VA = "0x1829B8370")]
	public DIJBCAAPJBG(global::DFDBMCBGAEF<Entity> MLIELKFMALM, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D59390", Offset = "0x1D58390", VA = "0x181D59390")]
	private Entity BAGBAIEEPPJ(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x29AA6B0", Offset = "0x29A96B0", VA = "0x1829AA6B0")]
	private GPEJGMHBDPO BAGBAIEEPPJ(Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x29ABD40", Offset = "0x29AAD40", VA = "0x1829ABD40", Slot = "4")]
	public T BOEAFIEBIHC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x29B1CF0", Offset = "0x29B0CF0", VA = "0x1829B1CF0")]
	public bool JPNFGACMGOG(GPEJGMHBDPO GBPGPLEPLBP, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x29AE6B0", Offset = "0x29AD6B0", VA = "0x1829AE6B0")]
	public bool CBCHFBKJCOA(GPEJGMHBDPO GBPGPLEPLBP, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x29AA820", Offset = "0x29A9820", VA = "0x1829AA820", Slot = "9")]
	public bool BKIFKBMENNF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x29B07B0", Offset = "0x29AF7B0", VA = "0x1829B07B0", Slot = "26")]
	public object IIKMGFNOMEN(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x29B3FA0", Offset = "0x29B2FA0", VA = "0x1829B3FA0")]
	public bool LAOIDJMPGGI(GPEJGMHBDPO GBPGPLEPLBP, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x29AC380", Offset = "0x29AB380", VA = "0x1829AC380")]
	public void BOEAFIEBIHC(GPEJGMHBDPO GBPGPLEPLBP, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x29B1360", Offset = "0x29B0360", VA = "0x1829B1360")]
	public bool JPNFGACMGOG(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29AE600", Offset = "0x29AD600", VA = "0x1829AE600")]
	public bool CBCHFBKJCOA(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C30", Offset = "0x29B3C30", VA = "0x1829B4C30", Slot = "22")]
	public void LPKKHPLBIJM(PAOKNLKENHE NIICHBPFANE, [Optional] object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x29B55E0", Offset = "0x29B45E0", VA = "0x1829B55E0", Slot = "15")]
	public void LPKKHPLBIJM(GPEJGMHBDPO EBOIOCBODNI, FDCKEIMNKII NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x29AF190", Offset = "0x29AE190", VA = "0x1829AF190", Slot = "14")]
	public bool EBGLHADENDP(GPEJGMHBDPO KMOLMNMNMNO, GPEJGMHBDPO GLOMCJNAEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29B2D40", Offset = "0x29B1D40", VA = "0x1829B2D40")]
	private void KDHLIDENPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x29AD0C0", Offset = "0x29AC0C0", VA = "0x1829AD0C0")]
	private void BONCDEDJNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x29B6430", Offset = "0x29B5430", VA = "0x1829B6430")]
	private void PIOCKEMLGJJ(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x29AFA20", Offset = "0x29AEA20", VA = "0x1829AFA20")]
	private void FCDILPBBFPE(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x29AED70", Offset = "0x29ADD70", VA = "0x1829AED70", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x29B80F0", Offset = "0x29B70F0", VA = "0x1829B80F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x29B0150", Offset = "0x29AF150", VA = "0x1829B0150")]
	public string HADDKMAPJJJ(in MPOLKMCKMLM PCAFGDJMGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x29AF6A0", Offset = "0x29AE6A0", VA = "0x1829AF6A0", Slot = "5")]
	private bool KLGKDFLMMKH(GPEJGMHBDPO EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x29B2440", Offset = "0x29B1440", VA = "0x1829B2440", Slot = "6")]
	private bool KAMONPCECNN(GPEJGMHBDPO EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x29B5B80", Offset = "0x29B4B80", VA = "0x1829B5B80", Slot = "10")]
	private bool OCIGGPHBFBA(GPEJGMHBDPO EBOIOCBODNI, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29AF3A0", Offset = "0x29AE3A0", VA = "0x1829AF3A0", Slot = "11")]
	private void EBKOOJHOLMB(GPEJGMHBDPO EBOIOCBODNI, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29B1160", Offset = "0x29B0160", VA = "0x1829B1160", Slot = "12")]
	private bool JGKMKDCMLHE(GPEJGMHBDPO EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x29AA670", Offset = "0x29A9670", VA = "0x1829AA670", Slot = "13")]
	private bool AAECOHFHAJN(GPEJGMHBDPO EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x29042C0", Offset = "0x29032C0", VA = "0x1829042C0", Slot = "16")]
	private string DNPMJODKHHD(in MPOLKMCKMLM KPPLMEOMNGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KDFLMOJDNAH : IDisposable, CONHDBOPGAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JEPMCIAENEG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public KDFLMOJDNAH(NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x30EB020", Offset = "0x30EA020", VA = "0x1830EB020", Slot = "6")]
	public GPEJGMHBDPO NIDPNGHEKLF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x30EB070", Offset = "0x30EA070", VA = "0x1830EB070", Slot = "7")]
	public Entity NIDPNGHEKLF(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x30EB080", Offset = "0x30EA080", VA = "0x1830EB080", Slot = "8")]
	public IEnumerable<GPEJGMHBDPO> NIDPNGHEKLF(IEnumerable<GPEJGMHBDPO> CMLLBIKBAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x30EAFC0", Offset = "0x30E9FC0", VA = "0x1830EAFC0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly JHCDFELAIDH PFDHPKHJCCI;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int KMAANPCADBJ;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static CONHDBOPGAO OIAFFOAGAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool KDANNCFBOPL;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> JEPMCIAENEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B580", Offset = "0x2C8A580", VA = "0x182C8B580")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool APJNBIELNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B4F0", Offset = "0x2C8A4F0", VA = "0x182C8B4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B690", Offset = "0x2C8A690", VA = "0x182C8B690")]
		public static SerializationRemapScope NDLIONNJEPP()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BA10", Offset = "0x2C8AA10", VA = "0x182C8BA10")]
		public SerializationRemapScope(CONHDBOPGAO HJINIPHPMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B3E0", Offset = "0x2C8A3E0", VA = "0x182C8B3E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B820", Offset = "0x2C8A820", VA = "0x182C8B820")]
		public static GPEJGMHBDPO NIDPNGHEKLF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B6F0", Offset = "0x2C8A6F0", VA = "0x182C8B6F0")]
		public static Entity NIDPNGHEKLF(Entity PJEENOLDJIO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
[IABFONFHPFO(typeof(CPEFMNDKAGA), new string[] { "Editor" })]
public sealed class CPEFMNDKAGA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void JMEOCMMENNO(IJDKBBDMEBI IIIBOGBNOJB, ADIOIKPLFDJ FNIHENPLJHK, bool GEEHDIBABFL);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void GAKNGMOAHFO(IJDKBBDMEBI IIIBOGBNOJB, bool GEEHDIBABFL);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void GKMMCIEDEKI(IJDKBBDMEBI IIIBOGBNOJB, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool GEEHDIBABFL);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JMEOCMMENNO CABKJPMCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A7D0", Offset = "0x2D197D0", VA = "0x182D1A7D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A510", Offset = "0x2D19510", VA = "0x182D1A510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GAKNGMOAHFO AEDIJKMJDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A8A0", Offset = "0x2D198A0", VA = "0x182D1A8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A5B0", Offset = "0x2D195B0", VA = "0x182D1A5B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event GKMMCIEDEKI HHNGMJPOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A710", Offset = "0x2D19710", VA = "0x182D1A710")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A650", Offset = "0x2D19650", VA = "0x182D1A650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A6F0", Offset = "0x2D196F0", VA = "0x182D1A6F0")]
	[Conditional("UNITY_EDITOR")]
	public void FJLIPCHEOBE(IJDKBBDMEBI IIIBOGBNOJB, in ADIOIKPLFDJ FNIHENPLJHK, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A7B0", Offset = "0x2D197B0", VA = "0x182D1A7B0")]
	[Conditional("UNITY_EDITOR")]
	public void IBLCGNHLMAO(IJDKBBDMEBI IIIBOGBNOJB, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A870", Offset = "0x2D19870", VA = "0x182D1A870")]
	[Conditional("UNITY_EDITOR")]
	public void NIOBEEEGPGI(IJDKBBDMEBI IIIBOGBNOJB, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public CPEFMNDKAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[IABFONFHPFO(typeof(GDLOHCFNDBC), new string[] { "Editor" })]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
public sealed class GDLOHCFNDBC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void MMLJPPFFNLH(IJDKBBDMEBI DGPLFECNDCD, ADIOIKPLFDJ FNIHENPLJHK, bool GEEHDIBABFL);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void IFNNCMBFHAJ(IJDKBBDMEBI DGPLFECNDCD, bool GEEHDIBABFL);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void NLOBLMEMGGO(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool GEEHDIBABFL, bool DCHMPDGMBME);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void LOJCLENIFBB(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void ELAKNFEBOHJ(FOLBPKGHHOJ EBOIOCBODNI, ReadOnlyMemory<byte> OBBOCNIOLOI);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> KJNKODPECBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x30DFAD0", Offset = "0x30DEAD0", VA = "0x1830DFAD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x30DF390", Offset = "0x30DE390", VA = "0x1830DF390")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> HPEMBFHBBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x30DF9E0", Offset = "0x30DE9E0", VA = "0x1830DF9E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x30DF470", Offset = "0x30DE470", VA = "0x1830DF470")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event MMLJPPFFNLH CABKJPMCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x30DF8A0", Offset = "0x30DE8A0", VA = "0x1830DF8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x30DEF60", Offset = "0x30DDF60", VA = "0x1830DEF60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IFNNCMBFHAJ AEDIJKMJDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x30DFC60", Offset = "0x30DEC60", VA = "0x1830DFC60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x30DF140", Offset = "0x30DE140", VA = "0x1830DF140")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MMLJPPFFNLH CMGHLCAMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x30DFBC0", Offset = "0x30DEBC0", VA = "0x1830DFBC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x30DF710", Offset = "0x30DE710", VA = "0x1830DF710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event IFNNCMBFHAJ HCMCPBGGNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x30DF000", Offset = "0x30DE000", VA = "0x1830DF000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x30DEEC0", Offset = "0x30DDEC0", VA = "0x1830DEEC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event NLOBLMEMGGO HHNGMJPOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x30DF5D0", Offset = "0x30DE5D0", VA = "0x1830DF5D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x30DF1E0", Offset = "0x30DE1E0", VA = "0x1830DF1E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event LOJCLENIFBB APEBLENHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x30DF530", Offset = "0x30DE530", VA = "0x1830DF530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x30DF0A0", Offset = "0x30DE0A0", VA = "0x1830DF0A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BEPLPCENJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x30DF7B0", Offset = "0x30DE7B0", VA = "0x1830DF7B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x30DF280", Offset = "0x30DE280", VA = "0x1830DF280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ELAKNFEBOHJ HPLODIPHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x30DFD00", Offset = "0x30DED00", VA = "0x1830DFD00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x30DF670", Offset = "0x30DE670", VA = "0x1830DF670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x30DF850", Offset = "0x30DE850", VA = "0x1830DF850")]
	[Conditional("UNITY_EDITOR")]
	public void IIHJPKFCABP(IJDKBBDMEBI DGPLFECNDCD, in ADIOIKPLFDJ FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x30DF880", Offset = "0x30DE880", VA = "0x1830DF880")]
	[Conditional("UNITY_EDITOR")]
	public void JNDLLJLPINO(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x30DF940", Offset = "0x30DE940", VA = "0x1830DF940")]
	[Conditional("UNITY_EDITOR")]
	public void KMLGLEKDNEJ(IJDKBBDMEBI DGPLFECNDCD, in ADIOIKPLFDJ FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x30DFDA0", Offset = "0x30DEDA0", VA = "0x1830DFDA0")]
	[Conditional("UNITY_EDITOR")]
	public void PCNEGMDHNFA(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x30DFB90", Offset = "0x30DEB90", VA = "0x1830DFB90")]
	[Conditional("UNITY_EDITOR")]
	public void NFGDMNCOPDJ(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool DCHMPDGMBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x30DF450", Offset = "0x30DE450", VA = "0x1830DF450")]
	[Conditional("UNITY_EDITOR")]
	public void EMIMEKDCAPI(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x30DFDC0", Offset = "0x30DEDC0", VA = "0x1830DFDC0")]
	[Conditional("UNITY_EDITOR")]
	public void PMBPENPHCCJ(string GOENAEMJAON, object OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30DFAA0", Offset = "0x30DEAA0", VA = "0x1830DFAA0")]
	[Conditional("UNITY_EDITOR")]
	public void MAKCPDAKGBN(FOLBPKGHHOJ EBOIOCBODNI, ReadOnlyMemory<byte> OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x30DF320", Offset = "0x30DE320", VA = "0x1830DF320")]
	[Conditional("UNITY_EDITOR")]
	public void DNOKICKLCAG(World BKFHGKOCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x30DF970", Offset = "0x30DE970", VA = "0x1830DF970")]
	[Conditional("UNITY_EDITOR")]
	public void LJJLEOOHJPA(World BKFHGKOCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public GDLOHCFNDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IABFONFHPFO(typeof(JEOCGGOIEBA), new string[] { })]
public class EGJIMMHENNE : JEOCGGOIEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B050", Offset = "0x2D2A050", VA = "0x182D2B050", Slot = "5")]
	public void AKEOAFPDGOF(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B350", Offset = "0x2D2A350", VA = "0x182D2B350", Slot = "6")]
	public void KHNNKKDCGJN(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B140", Offset = "0x2D2A140", VA = "0x182D2B140", Slot = "7")]
	public void CJHKNGFKCCC(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B230", Offset = "0x2D2A230", VA = "0x182D2B230", Slot = "4")]
	public IDisposable FIHMOHBBGKC(object GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EGJIMMHENNE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	[IABFONFHPFO(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	internal class BulkInstantiateSceneObjectService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string CJBDDGDAIFN = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[JOODLPJEDOA]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[JOODLPJEDOA]
		private EOBKLCMHAME GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery FOBDPJBBDNF;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2D16EB0", Offset = "0x2D15EB0", VA = "0x182D16EB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2D16F00", Offset = "0x2D15F00", VA = "0x182D16F00", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2D168E0", Offset = "0x2D158E0", VA = "0x182D168E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2D17080", Offset = "0x2D16080", VA = "0x182D17080")]
		public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> CAGEECIKHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D17430", Offset = "0x2D16430", VA = "0x182D17430")]
		public static bool LPGEGIPIELB(EMMEDLLCNCH LPOCBPNMNHF, out IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2D16AC0", Offset = "0x2D15AC0", VA = "0x182D16AC0")]
		private void GKPNNODKKDP(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IEnumerable<EMMEDLLCNCH> CAGEECIKHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2D17200", Offset = "0x2D16200", VA = "0x182D17200")]
		private void LEKJJLKFFDG(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2D17FB0", Offset = "0x2D16FB0", VA = "0x182D17FB0")]
		private void OBENAKHEJDH(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IJDKBBDMEBI DGPLFECNDCD, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2D16580", Offset = "0x2D15580", VA = "0x182D16580")]
		private void ALPJFPHHPCN(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2D17710", Offset = "0x2D16710", VA = "0x182D17710")]
		private void NOAAGBFJDBN(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, List<EMMEDLLCNCH> EGFBJAJJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D168F0", Offset = "0x2D158F0", VA = "0x182D168F0")]
		private NativeList<IJDKBBDMEBI> FJMKEMFGEOE(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
			return default(NativeList<IJDKBBDMEBI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D17540", Offset = "0x2D16540", VA = "0x182D17540")]
		private NativeArray<Entity> MFGNADIBFJN(NativeList<IJDKBBDMEBI> OKEAMEHANCD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2D18430", Offset = "0x2D17430", VA = "0x182D18430")]
		private static void PCHHADECPGF(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IJDKBBDMEBI DGPLFECNDCD, EMMEDLLCNCH LPOCBPNMNHF, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IODJMJFIADF(PGBOFPGBDBH.Application)]
	[IABFONFHPFO(typeof(DebugWorldsService), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool PIODGPGALDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2D29580", Offset = "0x2D28580", VA = "0x182D29580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2D295C0", Offset = "0x2D285C0", VA = "0x182D295C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool NNEIKEIFBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2D29600", Offset = "0x2D28600", VA = "0x182D29600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2D29640", Offset = "0x2D28640", VA = "0x182D29640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public void LKIFDPINEGH(string GOENAEMJAON, EntityManager JGDEKKJFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public static void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[IABFONFHPFO(typeof(JILOIECAIMB), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
internal class JILOIECAIMB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E3270", Offset = "0x6E2270", VA = "0x1806E3270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool HELAKMEDDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE90", Offset = "0x7FEE90", VA = "0x1807FFE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEA0", Offset = "0x7FEEA0", VA = "0x1807FFEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public JILOIECAIMB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[IABFONFHPFO(typeof(EPLLJMMPLGC), new string[] { })]
	[DBACNPOLGIH(typeof(SerializationService))]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	internal class SerializationService : EPLLJMMPLGC, IDisposable, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly JHCDFELAIDH HIBAFJNAMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[JOODLPJEDOA]
		private AGABOCBEEBB GLKGCBOKLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[JOODLPJEDOA]
		private JILOIECAIMB HCMHLLALCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private OAOFKKDMKNC DFPIJEFAPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private FNDMDJJGFHH ONPFFLDOKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope FIOJMHPAHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? JOGHIIBNKIP;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool AFMBPDMJPBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C8D680", Offset = "0x2C8C680", VA = "0x182C8D680", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C380", Offset = "0x2C8B380", VA = "0x182C8C380", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KJPFFELANDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x782D00", Offset = "0x781D00", VA = "0x180782D00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7834B0", Offset = "0x7824B0", VA = "0x1807834B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FNDMDJJGFHH FDBKDEBJKKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D190", Offset = "0x2C8C190", VA = "0x182C8D190", Slot = "16")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C370", Offset = "0x2C8B370", VA = "0x182C8C370", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D060", Offset = "0x2C8C060", VA = "0x182C8D060")]
		public static bool JBIJHELDJID(ByteString BMHLFOOGPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210")]
		public void CPGMIMAKPKD(OAOFKKDMKNC PKHJCMCBPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D5B0", Offset = "0x2C8C5B0", VA = "0x182C8D5B0", Slot = "5")]
		public void LAOAAHMJCFG(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D740", Offset = "0x2C8C740", VA = "0x182C8D740", Slot = "6")]
		public Task LNAILFNIBOP(bool IGPDCEGDODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C1F0", Offset = "0x2C8B1F0", VA = "0x182C8C1F0", Slot = "7")]
		public ByteString CJKIIDNIDDE(out IDisposable FIOJMHPAHHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C010", Offset = "0x2C8B010", VA = "0x182C8C010", Slot = "19")]
		public ByteString CJKIIDNIDDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C390", Offset = "0x2C8B390", VA = "0x182C8C390", Slot = "9")]
		public bool EOLLHEJPBAN(ByteString MBNJCFBPOAL, NJNFGALPFEE HGNBPKPAAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C880", Offset = "0x2C8B880", VA = "0x182C8C880")]
		private bool GMGGAPDFFIN(ByteString MBNJCFBPOAL, NJNFGALPFEE HGNBPKPAAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BAA0", Offset = "0x2C8AAA0", VA = "0x182C8BAA0", Slot = "8")]
		public void ACDCHJGJMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C610", Offset = "0x2C8B610", VA = "0x182C8C610", Slot = "10")]
		public bool GGOEDFNGDOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D230", Offset = "0x2C8C230", VA = "0x182C8D230", Slot = "11")]
		public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BC70", Offset = "0x2C8AC70", VA = "0x182C8BC70")]
		public bool AFFHLMLBHHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CBA0", Offset = "0x2C8BBA0", VA = "0x182C8CBA0", Slot = "12")]
		public bool HBECBLLPJDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BD80", Offset = "0x2C8AD80", VA = "0x182C8BD80")]
		public void CAGDCHNLIOC(FNDMDJJGFHH.OADFLCFJFGF.HEDMGLIHHHI ADOLOEKMGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CDD0", Offset = "0x2C8BDD0", VA = "0x182C8CDD0")]
		private bool HCLGEPCMJMB(ByteString MBNJCFBPOAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C3F0", Offset = "0x2C8B3F0", VA = "0x182C8C3F0")]
		private void FFKJFAANGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D7D0", Offset = "0x2C8C7D0", VA = "0x182C8D7D0")]
		private ByteString NPIKIFGINIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D4A0", Offset = "0x2C8C4A0", VA = "0x182C8D4A0")]
		private ByteString KMAEBGCBAED(ByteString BMHLFOOGPAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C2D0", Offset = "0x2C8B2D0", VA = "0x182C8C2D0")]
		private FNDMDJJGFHH.OADFLCFJFGF.HEDMGLIHHHI DELOPEIOJBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BD50", Offset = "0x2C8AD50", VA = "0x182C8BD50")]
		private void AFOCEKJHPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D830", Offset = "0x2C8C830", VA = "0x182C8D830", Slot = "13")]
		public bool OHBHCAIGIHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D690", Offset = "0x2C8C690", VA = "0x182C8D690", Slot = "14")]
		public void LGOJHIHHOKC(bool CEHAMLKELDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C440", Offset = "0x2C8B440", VA = "0x182C8C440")]
		private void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IABFONFHPFO(typeof(LCBBOCICDFN), new string[] { })]
[DBACNPOLGIH(typeof(AGABOCBEEBB))]
internal class AGABOCBEEBB : LCBBOCICDFN
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JBNMEOHKANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D10080", Offset = "0x2D0F080", VA = "0x182D10080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FAE0", Offset = "0x2D0EAE0", VA = "0x182D0FAE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<CONHDBOPGAO> PGEIPEOFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FFE0", Offset = "0x2D0EFE0", VA = "0x182D0FFE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FD10", Offset = "0x2D0ED10", VA = "0x182D0FD10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action IJICLIHOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D10120", Offset = "0x2D0F120", VA = "0x182D10120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FF40", Offset = "0x2D0EF40", VA = "0x182D0FF40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action BIIPHAMKIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FC70", Offset = "0x2D0EC70", VA = "0x182D0FC70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FDB0", Offset = "0x2D0EDB0", VA = "0x182D0FDB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CONHDBOPGAO> KNBEBGNBJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FBD0", Offset = "0x2D0EBD0", VA = "0x182D0FBD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FE50", Offset = "0x2D0EE50", VA = "0x182D0FE50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x14624E0", Offset = "0x14614E0", VA = "0x1814624E0")]
	public void ACDCHJGJMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1431220", Offset = "0x1430220", VA = "0x181431220")]
	public void IOMMAIDLKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1434830", Offset = "0x1433830", VA = "0x181434830")]
	public void OGEMCEMIGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FEF0", Offset = "0x2D0EEF0", VA = "0x182D0FEF0")]
	public void NINDDAOKPBN(CONHDBOPGAO OIAFFOAGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FB80", Offset = "0x2D0EB80", VA = "0x182D0FB80")]
	public void GNBELAEHPMG(CONHDBOPGAO OIAFFOAGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public AGABOCBEEBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[IABFONFHPFO(typeof(CGDDJBMDAKP), new string[] { })]
public class FPJBCDDGCMC : CGDDJBMDAKP, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents OCFBEMCGNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MJJAHFLLHGK OCJMBDKKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService AIJDONAKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::FMNGHOMPIJM<GPEJGMHBDPO> AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E65A0", Offset = "0x6E55A0", VA = "0x1806E65A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x30DD2C0", Offset = "0x30DC2C0", VA = "0x1830DD2C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x199DE70", Offset = "0x199CE70", VA = "0x18199DE70", Slot = "14")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x30DD5E0", Offset = "0x30DC5E0", VA = "0x1830DD5E0", Slot = "15")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x30DD0C0", Offset = "0x30DC0C0", VA = "0x1830DD0C0", Slot = "16")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x199DDA0", Offset = "0x199CDA0", VA = "0x18199DDA0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4210", Offset = "0x2AB3210", VA = "0x182AB4210")]
	private GPEJGMHBDPO DHJIOFINLAO(Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x30DDDB0", Offset = "0x30DCDB0", VA = "0x1830DDDB0", Slot = "4")]
	public GPEJGMHBDPO PLFCFKIEBOC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x30DD3C0", Offset = "0x30DC3C0", VA = "0x1830DD3C0", Slot = "19")]
	public void JJOOJLAKEOM(ref List<GPEJGMHBDPO> NKLDGGPGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x30DDCE0", Offset = "0x30DCCE0", VA = "0x1830DDCE0", Slot = "20")]
	public IEnumerable<GPEJGMHBDPO> PKDPPNNMDAK(GPEJGMHBDPO GBPGPLEPLBP, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x30DCDD0", Offset = "0x30DBDD0", VA = "0x1830DCDD0", Slot = "21")]
	public GPEJGMHBDPO ELIAHCIMIEO(GPEJGMHBDPO GBPGPLEPLBP, int EGBCAPEEJBF)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x30DCFA0", Offset = "0x30DBFA0", VA = "0x1830DCFA0", Slot = "22")]
	public int EOLCOIPHINA(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x30DD780", Offset = "0x30DC780", VA = "0x1830DD780", Slot = "8")]
	public int KIPGBJMICGF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x30DDBC0", Offset = "0x30DCBC0", VA = "0x1830DDBC0", Slot = "9")]
	public LNMIPKFIEGC PEHLCNLPMAC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(LNMIPKFIEGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x30DD920", Offset = "0x30DC920", VA = "0x1830DD920", Slot = "23")]
	public bool OJBBEGIAKJG(GPEJGMHBDPO GBPGPLEPLBP, out LNMIPKFIEGC ANHOGGAMAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x30DD6B0", Offset = "0x30DC6B0", VA = "0x1830DD6B0", Slot = "24")]
	public IEnumerable<GPEJGMHBDPO> JNFNFOAALOH(GPEJGMHBDPO GBPGPLEPLBP, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x30DDAF0", Offset = "0x30DCAF0", VA = "0x1830DDAF0", Slot = "12")]
	public GPEJGMHBDPO OLCENLILHJP(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x30DCD00", Offset = "0x30DBD00", VA = "0x1830DCD00", Slot = "13")]
	public bool DBLIAABGAHD(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO, out GPEJGMHBDPO HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x30DD1B0", Offset = "0x30DC1B0", VA = "0x1830DD1B0", Slot = "5")]
	public GPEJGMHBDPO FCHNDLGHOIE(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x30DDCB0", Offset = "0x30DCCB0", VA = "0x1830DDCB0", Slot = "11")]
	public bool PFJDPANHIDM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x30DCCD0", Offset = "0x30DBCD0", VA = "0x1830DCCD0", Slot = "25")]
	public bool CCMBIGLHNMK(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO BOGHNKLNLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x30DCCA0", Offset = "0x30DBCA0", VA = "0x1830DCCA0", Slot = "10")]
	public bool BEPDKIFHAFJ(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO PDOBLLBCDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x30DD310", Offset = "0x30DC310", VA = "0x1830DD310", Slot = "6")]
	public bool JDHACNMMLIE(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO OKMBLMILFGG, bool ANHIENPBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x30DD250", Offset = "0x30DC250", VA = "0x1830DD250", Slot = "7")]
	public bool GLJCMDFJBFM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO OKMBLMILFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FPJBCDDGCMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(ECMNKKDCFCB), new string[] { })]
internal class ECMNKKDCFCB : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[JOODLPJEDOA]
	private PABMDGDAPHJ ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, HPMBAGGHCAG> MADKPAIKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A930", Offset = "0x2D29930", VA = "0x182D2A930", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A360", Offset = "0x2D29360", VA = "0x182D2A360", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A5D0", Offset = "0x2D295D0", VA = "0x182D2A5D0")]
	public HPMBAGGHCAG HHNKAJHAOAE(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A7E0", Offset = "0x2D297E0", VA = "0x182D2A7E0")]
	public HPMBAGGHCAG HHNKAJHAOAE(BPHAMHGLCNC AOKMGDODDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A4B0", Offset = "0x2D294B0", VA = "0x182D2A4B0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A980", Offset = "0x2D29980", VA = "0x182D2A980")]
	public ECMNKKDCFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class HPMBAGGHCAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<PGHABJEAHKP> JAPCABPGDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<EJDOAJBNLAC> ELMCGNGKECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<DFLCMAHAHIM> EEDDICNOFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<EJDOAJBNLAC> IBGHANMGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<PGHABJEAHKP> EIMBLBOBDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0")]
		get
		{
			return default(NativeList<PGHABJEAHKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<EJDOAJBNLAC> FKMHHEDDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC10C00", Offset = "0xC0FC00", VA = "0x180C10C00")]
		get
		{
			return default(NativeList<EJDOAJBNLAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<DFLCMAHAHIM> DEIDKIDMILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1011190", Offset = "0x1010190", VA = "0x181011190")]
		get
		{
			return default(NativeList<DFLCMAHAHIM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<EJDOAJBNLAC> MPOKGNKHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xFF85E0", Offset = "0xFF75E0", VA = "0x180FF85E0")]
		get
		{
			return default(NativeList<EJDOAJBNLAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle DOPKIHCHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x10E2280", Offset = "0x10E1280", VA = "0x1810E2280")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1312FD0", Offset = "0x1311FD0", VA = "0x181312FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xF10FD0", Offset = "0xF0FFD0", VA = "0x180F10FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PMNEPBJNENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x30E2AF0", Offset = "0x30E1AF0", VA = "0x1830E2AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x30E2BA0", Offset = "0x30E1BA0", VA = "0x1830E2BA0")]
	public HPMBAGGHCAG(Allocator GOLNHBOGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x30E2600", Offset = "0x30E1600", VA = "0x1830E2600")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x30E29C0", Offset = "0x30E19C0", VA = "0x1830E29C0")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x30E2690", Offset = "0x30E1690", VA = "0x1830E2690")]
	public void GBJBCHALJOG(Entity PJEENOLDJIO, Entity KJNCJMANDLF, Entity KHLHKJKADHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[IABFONFHPFO(typeof(HHJAPPDHPCO), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
public class HHJAPPDHPCO : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[JOODLPJEDOA]
	private SceneService KPCHKHEBGLC;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x30E1EA0", Offset = "0x30E0EA0", VA = "0x1830E1EA0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x30E1E80", Offset = "0x30E0E80", VA = "0x1830E1E80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HHJAPPDHPCO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[IABFONFHPFO(typeof(PhotonInstanceCleanupService), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Lifecycle)]
	[IODJMJFIADF(PGBOFPGBDBH.PhotonRoom)]
	public class PhotonInstanceCleanupService : MIBCENMOHFA, JMMCIOGFDJD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JJLHCHOLEPN LFIIIJDKEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AHENLKMMNNA ACCCBDFPKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> EJCHJNBCEOB;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE180", Offset = "0x2ABD180", VA = "0x182ABE180", Slot = "5")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE1E0", Offset = "0x2ABD1E0", VA = "0x182ABE1E0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDED0", Offset = "0x2ABCED0", VA = "0x182ABDED0")]
		public void FABNEPJDBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDDE0", Offset = "0x2ABCDE0", VA = "0x182ABDDE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDF70", Offset = "0x2ABCF70", VA = "0x182ABDF70")]
		public void HNKLBDKIDPO(global::DFJBCINJNGH<int> BFIKAJGDHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE250", Offset = "0x2ABD250", VA = "0x182ABE250")]
		public void KPDKGAONBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class NCNPDBDOMOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint HPNPLJNBMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint LDACNHENHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9B7200", Offset = "0x9B6200", VA = "0x1809B7200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC500", Offset = "0x2AAB500", VA = "0x182AAC500")]
	public IJDKBBDMEBI MKEIGDPDNLI()
	{
		return default(IJDKBBDMEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC550", Offset = "0x2AAB550", VA = "0x182AAC550")]
	public void NEFAKFGJPMJ(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xF5B850", Offset = "0xF5A850", VA = "0x180F5B850", Slot = "6")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	protected NCNPDBDOMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(IEGMKAAGAAJ), new string[] { })]
internal sealed class IEGMKAAGAAJ : NCNPDBDOMOB, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JOODLPJEDOA]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint HIFBLLMBEPO;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint LDACNHENHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x30E5D10", Offset = "0x30E4D10", VA = "0x1830E5D10", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x30E5DB0", Offset = "0x30E4DB0", VA = "0x1830E5DB0")]
	private void OFOOPHJOKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x30E5CB0", Offset = "0x30E4CB0", VA = "0x1830E5CB0", Slot = "6")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
	public IEGMKAAGAAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IABFONFHPFO(typeof(OEPDOHBHEIO), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
internal sealed class OEPDOHBHEIO : NCNPDBDOMOB
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint LDACNHENHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OEPDOHBHEIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(NMNBEJDKFLE), new string[] { })]
internal sealed class NMNBEJDKFLE : HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery KAFBHDIAOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery CKGKHMHEMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery ELKGHNIIGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery CGBCAGHMMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery GLHMFCDFLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery CDFHAOPHIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE8A0", Offset = "0x2AAD8A0", VA = "0x182AAE8A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery AIOPFBNCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery KLEEMFNPACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x700030", Offset = "0x6FF030", VA = "0x180700030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery PPKPGCAMEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xFBDE50", Offset = "0xFBCE50", VA = "0x180FBDE50")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery DGKJGDIEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10E2280", Offset = "0x10E1280", VA = "0x1810E2280")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery FJCBIDLCECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10E2A60", Offset = "0x10E1A60", VA = "0x1810E2A60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery MPKDCDEMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEA20", Offset = "0x2AADA20", VA = "0x182AAEA20")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int DNIDCAJKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEA00", Offset = "0x2AADA00", VA = "0x182AAEA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int IHMBBPFEOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE8F0", Offset = "0x2AAD8F0", VA = "0x182AAE8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int FEDBEPEBODG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE9E0", Offset = "0x2AAD9E0", VA = "0x182AAE9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NDKLKDPOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE960", Offset = "0x2AAD960", VA = "0x182AAE960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int FDOHOLAIHME
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE150", Offset = "0x2AAD150", VA = "0x182AAE150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HINADLHMOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE1D0", Offset = "0x2AAD1D0", VA = "0x182AAE1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE910", Offset = "0x2AAD910", VA = "0x182AAE910", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE1F0", Offset = "0x2AAD1F0", VA = "0x182AAE1F0", Slot = "6")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE980", Offset = "0x2AAD980", VA = "0x182AAE980")]
	private EntityQueryDesc LKHBLEGDHOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE170", Offset = "0x2AAD170", VA = "0x182AAE170", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE740", Offset = "0x2AAD740", VA = "0x182AAE740")]
	public OKPPODDCHEL FGOOKEJCEGB(GPEJGMHBDPO LCCDBPIJCNE)
	{
		return default(OKPPODDCHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE690", Offset = "0x2AAD690", VA = "0x182AAE690")]
	public OKPPODDCHEL FGOOKEJCEGB(Entity PJEENOLDJIO)
	{
		return default(OKPPODDCHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE7F0", Offset = "0x2AAD7F0", VA = "0x182AAE7F0")]
	public OBNHEEKLBIB IJPMOHIFBJK(Entity PJEENOLDJIO)
	{
		return default(OBNHEEKLBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEAA0", Offset = "0x2AADAA0", VA = "0x182AAEAA0")]
	public NMNBEJDKFLE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[OHGELDJCNJM(GGAOONGBEBH.All)]
	[IABFONFHPFO(typeof(FOBNDAGEMLO), new string[] { })]
	public class ObjectService : MIBCENMOHFA, FOBNDAGEMLO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly JHCDFELAIDH BBNICPODAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[JOODLPJEDOA]
		private MNJAFLLCGLD FGEEBMNILFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[JOODLPJEDOA]
		private ObjectLifecycleService HDOHKKMKDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[JOODLPJEDOA]
		private ObjectEmbodimentService AIJDONAKHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[JOODLPJEDOA]
		private ObjectInstantiationService APEJINPFNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[JOODLPJEDOA]
		private NMNBEJDKFLE OCJMBDKKCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService OAKEGNELFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public MNJAFLLCGLD OMJDBNDAANI
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int DNIDCAJKPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2ABC7C0", Offset = "0x2ABB7C0", VA = "0x182ABC7C0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int IHMBBPFEOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB9B0", Offset = "0x2ABA9B0", VA = "0x182ABB9B0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int FEDBEPEBODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2ABC540", Offset = "0x2ABB540", VA = "0x182ABC540", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int NDKLKDPOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2ABBF10", Offset = "0x2ABAF10", VA = "0x182ABBF10", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FDOHOLAIHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2ABAAF0", Offset = "0x2AB9AF0", VA = "0x182ABAAF0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int HINADLHMOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB110", Offset = "0x2ABA110", VA = "0x182ABB110", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<GPEJGMHBDPO, OBNHEEKLBIB> LONFBPMMGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB140", Offset = "0x2ABA140", VA = "0x182ABB140", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2ABA790", Offset = "0x2AB9790", VA = "0x182ABA790", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<GPEJGMHBDPO> BGPPAHLBDPO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2ABC250", Offset = "0x2ABB250", VA = "0x182ABC250", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2ABB710", Offset = "0x2ABA710", VA = "0x182ABB710", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBC30", Offset = "0x2ABAC30", VA = "0x182ABBC30", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAE30", Offset = "0x2AB9E30", VA = "0x182ABAE30", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC110", Offset = "0x2ABB110", VA = "0x182ABC110")]
		private void MHIOIGHIBNM(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2ABACD0", Offset = "0x2AB9CD0", VA = "0x182ABACD0")]
		private void DHGHBKGBICL(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAD60", Offset = "0x2AB9D60", VA = "0x182ABAD60")]
		internal GPEJGMHBDPO DHJIOFINLAO(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC1B0", Offset = "0x2ABB1B0", VA = "0x182ABC1B0", Slot = "41")]
		public LNMIPKFIEGC MMPNOCAJABC()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC7F0", Offset = "0x2ABB7F0", VA = "0x182ABC7F0", Slot = "42")]
		public LNMIPKFIEGC PECJIHCFOKA()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAFB0", Offset = "0x2AB9FB0", VA = "0x182ABAFB0", Slot = "43")]
		public LNMIPKFIEGC EAABOFBIABC()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB300", Offset = "0x2ABA300", VA = "0x182ABB300", Slot = "10")]
		public OKPPODDCHEL FGOOKEJCEGB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(OKPPODDCHEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB7B0", Offset = "0x2ABA7B0", VA = "0x182ABB7B0", Slot = "11")]
		public OBNHEEKLBIB IJPMOHIFBJK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB900", Offset = "0x2ABA900", VA = "0x182ABB900")]
		private LNMIPKFIEGC IKMNJMMAFKM(EntityQuery APEJLGJADFF)
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA920", Offset = "0x2AB9920", VA = "0x182ABA920", Slot = "33")]
		public bool BKIFKBMENNF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA8D0", Offset = "0x2AB98D0", VA = "0x182ABA8D0", Slot = "29")]
		public void BAFMLPIANAD(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAC70", Offset = "0x2AB9C70", VA = "0x182ABAC70", Slot = "30")]
		public void DBEGAACJLOG(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBB90", Offset = "0x2ABAB90", VA = "0x182ABBB90", Slot = "31")]
		public void JMGLAECFLLN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC5F0", Offset = "0x2ABB5F0", VA = "0x182ABC5F0", Slot = "22")]
		public CDFLNPBCBAA NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC570", Offset = "0x2ABB570", VA = "0x182ABC570", Slot = "23")]
		public CDFLNPBCBAA NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB640", Offset = "0x2ABA640", VA = "0x182ABB640", Slot = "24")]
		public CDFLNPBCBAA HBBIFLCNHAN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC2F0", Offset = "0x2ABB2F0", VA = "0x182ABC2F0", Slot = "25")]
		public CDFLNPBCBAA NFKICFAFKEF(IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBEA0", Offset = "0x2ABAEA0", VA = "0x182ABBEA0", Slot = "44")]
		public CDFLNPBCBAA JMPLLPHEPGD(int OLCDBMHGIMP, OBNHEEKLBIB IBFEICPOBBG, GameObject BLPBCMIHDMD)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC070", Offset = "0x2ABB070", VA = "0x182ABC070", Slot = "26")]
		public NBODNKOLKBD LOKKOCJOODO()
		{
			return default(NBODNKOLKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAB20", Offset = "0x2AB9B20", VA = "0x182ABAB20", Slot = "45")]
		public LADIDIPKOKJ CMIPAENJOBN(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(LADIDIPKOKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAD80", Offset = "0x2AB9D80", VA = "0x182ABAD80", Slot = "27")]
		public DAIBEFDKFJE DPPJEBGFDDC()
		{
			return default(DAIBEFDKFJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB1E0", Offset = "0x2ABA1E0", VA = "0x182ABB1E0", Slot = "28")]
		public BCDBMEOMLBF FEGDAGMALKP(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(BCDBMEOMLBF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB410", Offset = "0x2ABA410", VA = "0x182ABB410", Slot = "12")]
		public void GBHABPPKBJN(IJDKBBDMEBI DGPLFECNDCD, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB490", Offset = "0x2ABA490", VA = "0x182ABB490", Slot = "13")]
		public CDFLNPBCBAA GEMGJFNJBAB(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBFB0", Offset = "0x2ABAFB0", VA = "0x182ABBFB0", Slot = "14")]
		public bool KLLNBFNLACK(GPEJGMHBDPO GBPGPLEPLBP, out EMAJLAJEHKH GPPHCPBMODE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB3C0", Offset = "0x2ABA3C0", VA = "0x182ABB3C0", Slot = "46")]
		public Transform FPAEAJMMINO(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAAA0", Offset = "0x2AB9AA0", VA = "0x182ABAAA0", Slot = "16")]
		public bool CGMALIJKBMC(GPEJGMHBDPO GBPGPLEPLBP, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAC20", Offset = "0x2AB9C20", VA = "0x182ABAC20", Slot = "17")]
		public bool CPIAGHNENJJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC6E0", Offset = "0x2ABB6E0", VA = "0x182ABC6E0")]
		public bool OCEBLLHENFE(EMAJLAJEHKH KPPLMEOMNGF, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC710", Offset = "0x2ABB710", VA = "0x182ABC710", Slot = "47")]
		public bool OCEBLLHENFE(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC050", Offset = "0x2ABB050", VA = "0x182ABC050", Slot = "48")]
		public void LNLDIFPJBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB9E0", Offset = "0x2ABA9E0", VA = "0x182ABB9E0", Slot = "15")]
		public void JJCKLLJLOGC(EMAJLAJEHKH AELIHOPICED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB6D0", Offset = "0x2ABA6D0", VA = "0x182ABB6D0", Slot = "49")]
		public void HHLPCJAJHPN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB880", Offset = "0x2ABA880", VA = "0x182ABB880", Slot = "18")]
		public bool IKALCDHMJEH(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC740", Offset = "0x2ABB740", VA = "0x182ABC740", Slot = "19")]
		public bool ODMDIGGOFIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC900", Offset = "0x2ABB900", VA = "0x182ABC900", Slot = "50")]
		public bool PODBFJOOFPP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBF40", Offset = "0x2ABAF40", VA = "0x182ABBF40", Slot = "51")]
		public bool KFENFCDAEAH(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB430", Offset = "0x2ABA430", VA = "0x182ABB430", Slot = "32")]
		public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA830", Offset = "0x2AB9830", VA = "0x182ABA830", Slot = "21")]
		public IJDKBBDMEBI BAAKGEKGEDO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(IJDKBBDMEBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA9B0", Offset = "0x2AB99B0", VA = "0x182ABA9B0", Slot = "20")]
		public GPEJGMHBDPO BPFLLEIAFPB(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2ABB050", Offset = "0x2ABA050", VA = "0x182ABB050")]
		private void EDKGEGKEJEA(OBNHEEKLBIB IBFEICPOBBG, GPEJGMHBDPO GBPGPLEPLBP, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(AIEDNAFPHHD), new string[] { })]
internal sealed class AIEDNAFPHHD : MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService APEJINPFNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[JOODLPJEDOA]
	private NMNBEJDKFLE OCJMBDKKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2D11AE0", Offset = "0x2D10AE0", VA = "0x182D11AE0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2D119E0", Offset = "0x2D109E0", VA = "0x182D119E0")]
	public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
	{
		return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2D10F00", Offset = "0x2D0FF00", VA = "0x182D10F00")]
	private void ADPDJBHKJMP(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2D11550", Offset = "0x2D10550", VA = "0x182D11550")]
	private void BBMKMNFHGHJ(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM, int IBFEICPOBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2D113C0", Offset = "0x2D103C0", VA = "0x182D113C0")]
	private void AKKMIAKHEDE(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM, int IBFEICPOBBG, GBOCHCBEADE ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2D110E0", Offset = "0x2D100E0", VA = "0x182D110E0")]
	private NativeMultiHashMap<int, (GPEJGMHBDPO, GPEJGMHBDPO)> AFBPHKKBPMO(Allocator GOLNHBOGNGC, NativeArray<GPEJGMHBDPO> PJAAAGDAINA, out NativeArray<(GPEJGMHBDPO src, GPEJGMHBDPO dst)> DBMMCBDCINA)
	{
		return default(NativeMultiHashMap<int, (GPEJGMHBDPO, GPEJGMHBDPO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public AIEDNAFPHHD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	[DBACNPOLGIH(typeof(TransformService))]
	[IABFONFHPFO(typeof(EOBKLCMHAME), new string[] { })]
	public class TransformService : EOBKLCMHAME, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly JHCDFELAIDH DDOBFICGHLH;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly JHCDFELAIDH LCGDAJKMFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private HKFLOGJJADM LKMIJPPNOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CGDDJBMDAKP EBGBIKNFKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase EHHMCFOFHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService EMDCODCKMDO;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2C96230", Offset = "0x2C95230", VA = "0x182C96230")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private JLCGKPAGLMB JADDHOMJIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2C948E0", Offset = "0x2C938E0", VA = "0x182C948E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2C96560", Offset = "0x2C95560", VA = "0x182C96560", Slot = "33")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2C94430", Offset = "0x2C93430", VA = "0x182C94430", Slot = "34")]
		public bool CJELNEIGLGO(Transform PKIKNDCFAFJ, out GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2C95B80", Offset = "0x2C94B80", VA = "0x182C95B80", Slot = "35")]
		public Transform FJEJMGNKJIP(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2C941C0", Offset = "0x2C931C0", VA = "0x182C941C0", Slot = "30")]
		public bool CGMALIJKBMC(Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2C98360", Offset = "0x2C97360", VA = "0x182C98360")]
		private void PLKCLPDECOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2C97B20", Offset = "0x2C96B20", VA = "0x182C97B20", Slot = "29")]
		public void OMKFDFNIAJJ(Entity PJEENOLDJIO, out Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2C96040", Offset = "0x2C95040", VA = "0x182C96040", Slot = "4")]
		public void IEPKMGFHODI(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2C93AD0", Offset = "0x2C92AD0", VA = "0x182C93AD0")]
		public void BHFIJGMDJJP(Entity PJEENOLDJIO, Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA, Vector3 KAEBFLACOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2C97E90", Offset = "0x2C96E90", VA = "0x182C97E90")]
		public void PANAMLFNMKM(Entity PJEENOLDJIO, Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2C97210", Offset = "0x2C96210", VA = "0x182C97210", Slot = "27")]
		public void NFCGOIEOCJB(Entity PJEENOLDJIO, out Matrix4x4 IDBPHKDPEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2C97FA0", Offset = "0x2C96FA0", VA = "0x182C97FA0")]
		public void PHOECKOKDKI(Entity PJEENOLDJIO, in Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2C95900", Offset = "0x2C94900", VA = "0x182C95900")]
		public void EPNNOBOLICL(Entity PJEENOLDJIO, in Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2C94000", Offset = "0x2C93000", VA = "0x182C94000")]
		public void CDPIOPMOHPP(Entity PJEENOLDJIO, in Matrix4x4 FEMLPJHHNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2C937D0", Offset = "0x2C927D0", VA = "0x182C937D0", Slot = "5")]
		public void BBOADPLCJPI(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2C96670", Offset = "0x2C95670", VA = "0x182C96670", Slot = "6")]
		public Vector3 KIFABACKKPJ(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2C98380", Offset = "0x2C97380", VA = "0x182C98380", Slot = "7")]
		public void PPJHEHDDOLF(Entity PJEENOLDJIO, Quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2C96F70", Offset = "0x2C95F70", VA = "0x182C96F70", Slot = "8")]
		public Quaternion MHFNKDBALLE(Entity PJEENOLDJIO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2C938F0", Offset = "0x2C928F0", VA = "0x182C938F0", Slot = "12")]
		public void BFHLPIKGJHN(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2C95550", Offset = "0x2C94550", VA = "0x182C95550", Slot = "11")]
		public Vector3 EJGNALJEEBN(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2C93730", Offset = "0x2C92730", VA = "0x182C93730")]
		public void BBHPGOADENE(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2C94390", Offset = "0x2C93390", VA = "0x182C94390")]
		private Vector3 CJBHDMBPEAD(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2C935A0", Offset = "0x2C925A0", VA = "0x182C935A0", Slot = "14")]
		public float AKMGLHLMAOI(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2C97800", Offset = "0x2C96800", VA = "0x182C97800", Slot = "13")]
		public void OCKPLCBEGKF(Entity PJEENOLDJIO, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2C97DA0", Offset = "0x2C96DA0", VA = "0x182C97DA0")]
		private float OPLEPMOKCHG(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2C94730", Offset = "0x2C93730", VA = "0x182C94730")]
		public void CNDMIDAMEME(Entity PJEENOLDJIO, float AJLJCODIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2C942B0", Offset = "0x2C932B0", VA = "0x182C942B0", Slot = "16")]
		public Vector3 CIIFPNOANIO(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2C96280", Offset = "0x2C95280", VA = "0x182C96280", Slot = "15")]
		public void JDCBGNOIOGJ(Entity PJEENOLDJIO, Vector3 GJHOGJGJPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2C97C70", Offset = "0x2C96C70", VA = "0x182C97C70")]
		private Vector3 OPGOCMDKKDG(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2C97910", Offset = "0x2C96910", VA = "0x182C97910")]
		public void OEDLLEEOMJO(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2C963B0", Offset = "0x2C953B0", VA = "0x182C963B0")]
		[Conditional("DEBUG_BUILD")]
		private void JJCALJOMFHF(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2C949A0", Offset = "0x2C939A0", VA = "0x182C949A0", Slot = "36")]
		public void DNJCOHKIFIM(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2C95CC0", Offset = "0x2C94CC0", VA = "0x182C95CC0", Slot = "9")]
		public void GFCMMFBPAAM(Entity PJEENOLDJIO, out Vector3 MIFJBHLKJIN, out Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2C979E0", Offset = "0x2C969E0", VA = "0x182C979E0", Slot = "10")]
		public void OFHLPIDPPON(Entity PJEENOLDJIO, out Vector3 MIFJBHLKJIN, out Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2C96D50", Offset = "0x2C95D50", VA = "0x182C96D50", Slot = "37")]
		public void LPBOFGEKIEB(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2C95740", Offset = "0x2C94740", VA = "0x182C95740")]
		public void EOKKNDBKCHA(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2C95E10", Offset = "0x2C94E10", VA = "0x182C95E10", Slot = "17")]
		public void GNNLADJMFCP(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2C939F0", Offset = "0x2C929F0", VA = "0x182C939F0", Slot = "18")]
		public Vector3 BGOGHJCBENP(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2C94C70", Offset = "0x2C93C70", VA = "0x182C94C70", Slot = "19")]
		public void EGLJAPGDEPG(Entity PJEENOLDJIO, Quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C97220", Offset = "0x2C96220", VA = "0x182C97220", Slot = "20")]
		public Quaternion NINNEGKMMIN(Entity PJEENOLDJIO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C93BA0", Offset = "0x2C92BA0", VA = "0x182C93BA0", Slot = "22")]
		public void CAEMMIGJJCA(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C93640", Offset = "0x2C92640", VA = "0x182C93640", Slot = "21")]
		public Vector3 AOLOKGKNIJJ(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C94B00", Offset = "0x2C93B00", VA = "0x182C94B00", Slot = "23")]
		public void EAMNBHFMEKI(Entity PJEENOLDJIO, float PJBHBFMMIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C93480", Offset = "0x2C92480", VA = "0x182C93480", Slot = "24")]
		public float ABJFADFPCJD(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C97310", Offset = "0x2C96310", VA = "0x182C97310", Slot = "25")]
		public void NPOMLANMLPB(Entity PJEENOLDJIO, Vector3 KEEGNGGHACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C945F0", Offset = "0x2C935F0", VA = "0x182C945F0", Slot = "26")]
		public Vector3 CKJMHGEKPOL(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C94EB0", Offset = "0x2C93EB0", VA = "0x182C94EB0", Slot = "31")]
		public void EIANPNBBNBO(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C95A30", Offset = "0x2C94A30", VA = "0x182C95A30")]
		private GPEJGMHBDPO FBOGJOOPDJE(Transform PKIKNDCFAFJ)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C96780", Offset = "0x2C95780", VA = "0x182C96780")]
		private static TransformEntity LBFHOGFNEJO(OBNHEEKLBIB HAOFNDAEGFJ, GameObject LOCIAIPOBLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C947C0", Offset = "0x2C937C0", VA = "0x182C947C0", Slot = "32")]
		public void CONCMHPGOPE(Entity PJEENOLDJIO, Entity KJNCJMANDLF, Entity KHLHKJKADHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C95C40", Offset = "0x2C94C40", VA = "0x182C95C40")]
		private KEGHKGPFCFN GFCMMFBPAAM(Entity PJEENOLDJIO)
		{
			return default(KEGHKGPFCFN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C95660", Offset = "0x2C94660", VA = "0x182C95660")]
		private bool EMHBKFNELKD(Entity PJEENOLDJIO, out Entity OKMBLMILFGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C97060", Offset = "0x2C96060", VA = "0x182C97060")]
		private void MLINHKKJOFD(Entity PJEENOLDJIO, out Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C969B0", Offset = "0x2C959B0", VA = "0x182C969B0")]
		private void LDMKFKEOFOB(Entity PJEENOLDJIO, out Matrix4x4 FEMLPJHHNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C97B10", Offset = "0x2C96B10", VA = "0x182C97B10", Slot = "28")]
		private void OLFEDHIIOAG(Entity PJEENOLDJIO, in Matrix4x4 IDBPHKDPEMN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
[IABFONFHPFO(typeof(MFKKIMDMDIN), new string[] { })]
internal sealed class MFKKIMDMDIN : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[JOODLPJEDOA]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9550", Offset = "0x2AA8550", VA = "0x182AA9550", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA94E0", Offset = "0x2AA84E0", VA = "0x182AA94E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public MFKKIMDMDIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(GNEGPFIBKFN), new string[] { })]
public class GNEGPFIBKFN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct OIGOMFLAIKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly GNEGPFIBKFN OKMBLMILFGG;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x41427D0", Offset = "0x41417D0", VA = "0x1841427D0")]
		public OIGOMFLAIKO(GNEGPFIBKFN OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x41427B0", Offset = "0x41417B0", VA = "0x1841427B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EEOLLAOHBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool CPEOCLEAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10A62E0", Offset = "0x10A52E0", VA = "0x1810A62E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action GMBFHBMIPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x30E0D50", Offset = "0x30DFD50", VA = "0x1830E0D50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x30E0E20", Offset = "0x30DFE20", VA = "0x1830E0E20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x30E0DF0", Offset = "0x30DFDF0", VA = "0x1830E0DF0")]
	public OIGOMFLAIKO HJDABMCHLDO()
	{
		return default(OIGOMFLAIKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1344250", Offset = "0x1343250", VA = "0x181344250")]
	public void ICIPFBNLMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x30E0D30", Offset = "0x30DFD30", VA = "0x1830E0D30")]
	public void DEDKIMIMABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public GNEGPFIBKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IABFONFHPFO(typeof(LLEOCPFGDHE), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
public class LLEOCPFGDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int EEOLLAOHBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDD81C0", Offset = "0xDD71C0", VA = "0x180DD81C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DD0", Offset = "0x9C2DD0", VA = "0x1809C3DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LLEOCPFGDHE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[IABFONFHPFO(typeof(EnableComponentSystemsInScope), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : MIBCENMOHFA, HAOCLMFADNP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct LFNAJNOEDIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> NJFCJFKAOFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> CAHDBKNLLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> KMOICGDDEDI;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x413FE80", Offset = "0x413EE80", VA = "0x18413FE80")]
			public LFNAJNOEDIE(NativeArray<int> NJFCJFKAOFB, NativeArray<int> CAHDBKNLLCN, Dictionary<ComponentSystemBase, int> KMOICGDDEDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x413FC00", Offset = "0x413EC00", VA = "0x18413FC00")]
			public void AAKOFHIKDGC(IEnumerable<ComponentSystemBase> FGEEBMNILFP, PGBOFPGBDBH IAFADNGAPLH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class NBOAFDCGCNH : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public NBOAFDCGCNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4141280", Offset = "0x4140280", VA = "0x184141280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4141450", Offset = "0x4140450", VA = "0x184141450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x41413A0", Offset = "0x41403A0", VA = "0x1841413A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x41413A0", Offset = "0x41403A0", VA = "0x1841413A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const PGBOFPGBDBH GHJGMFIPKLD = PGBOFPGBDBH.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly JHCDFELAIDH JFKLGFMLGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private FEPIHHOJCOJ HPFBGIEBCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> EJHNLMLIIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> LHKCGGFJGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int LFMBJAIIPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private PGBOFPGBDBH PADGMJKIDHF;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x30D3FC0", Offset = "0x30D2FC0", VA = "0x1830D3FC0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x30D36D0", Offset = "0x30D26D0", VA = "0x1830D36D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x30D44B0", Offset = "0x30D34B0", VA = "0x1830D44B0")]
		[IteratorStateMachine(typeof(NBOAFDCGCNH))]
		private IEnumerable<ComponentSystemBase> OIEJAFGAPNA(int GODLNPABGMH, int EICPOANFBCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x30D4440", Offset = "0x30D3440", VA = "0x1830D4440", Slot = "5")]
		public void NMNMMBPECAK(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x30D4130", Offset = "0x30D3130", VA = "0x1830D4130")]
		private void LCKAEHCHHME(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x30D4280", Offset = "0x30D3280", VA = "0x1830D4280")]
		public void LCKAEHCHHME(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x30D3420", Offset = "0x30D2420", VA = "0x1830D3420")]
		private void DDMLGMDJGOM(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x30D4540", Offset = "0x30D3540", VA = "0x1830D4540")]
		private void OJKCDCDMAKP(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x30D37A0", Offset = "0x30D27A0", VA = "0x1830D37A0")]
		private void EMIGBBKDFOE(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x30D3F00", Offset = "0x30D2F00", VA = "0x1830D3F00")]
		private void JHCGFCODJBC(int GODLNPABGMH, int EICPOANFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x30D4380", Offset = "0x30D3380", VA = "0x1830D4380")]
		private void NJLLPDINJFK(int GODLNPABGMH, int EICPOANFBCD, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x30D36B0", Offset = "0x30D26B0", VA = "0x1830D36B0")]
		private int DHCIAGOLJPH(PGBOFPGBDBH LEHOMGAJBKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x30D3970", Offset = "0x30D2970", VA = "0x1830D3970")]
		private bool JFGPOJAFIDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x30D4040", Offset = "0x30D3040", VA = "0x1830D4040")]
		private Dictionary<ComponentSystemBase, int> JOPGNALCFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x30D3760", Offset = "0x30D2760", VA = "0x1830D3760")]
		private void EBACANHNCJP(NativeArray<int> NJFCJFKAOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x30D3860", Offset = "0x30D2860", VA = "0x1830D3860")]
		private void GCNGLHGHKAO(NativeArray<int> CAHDBKNLLCN, NativeArray<int> NJFCJFKAOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x30D3910", Offset = "0x30D2910", VA = "0x1830D3910")]
		private static PGBOFPGBDBH HHBAIIGOAFP(Type HAOFNDAEGFJ, PGBOFPGBDBH PNIJKHBHNEL)
		{
			return default(PGBOFPGBDBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x30D4660", Offset = "0x30D3660", VA = "0x1830D4660")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x30D4450", Offset = "0x30D3450", VA = "0x1830D4450")]
		[CompilerGenerated]
		private void OBIKDKPJMAL(MIBCENMOHFA NHELGCBBJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x30D3800", Offset = "0x30D2800", VA = "0x1830D3800")]
		[CompilerGenerated]
		private void EOAEGBMCAGJ(PFFHIJLFPMD NHELGCBBJNH)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[OHGELDJCNJM(GGAOONGBEBH.WorldService)]
	[IABFONFHPFO(typeof(PJCCMDKJKFG), new string[] { })]
	public class TickService : MIBCENMOHFA, PJCCMDKJKFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker FGKJOEJAKME;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker IKBDDIOBDCO;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker CMIILJECKHB;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker DHNHMPGBOLI;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker LFIPOHHMGED;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker OFONOKMOJDA;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker LHCPBHBHIFJ;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker GLMBEMFJDBD;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker ODADEOFCBDH;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker BNMKPHEKKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[JOODLPJEDOA]
		private EPLLJMMPLGC JGIJGKDIPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[JOODLPJEDOA]
		private JILOIECAIMB ONNMOOKNGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[JOODLPJEDOA]
		private TransformOwnershipPhase CIBDMNLICDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[JOODLPJEDOA]
		private TimeService KLKIAHEMFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private NPAPPEKNDDD BKFHGKOCNCC;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool OKLJAMHNDJC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2C92040", Offset = "0x2C91040", VA = "0x182C92040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool JPHFAJGBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2C91910", Offset = "0x2C90910", VA = "0x182C91910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool LKCDCDILHHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C92040", Offset = "0x2C91040", VA = "0x182C92040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool FFPGEGOCGBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2C92040", Offset = "0x2C91040", VA = "0x182C92040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C92230", Offset = "0x2C91230", VA = "0x182C92230", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C923A0", Offset = "0x2C913A0", VA = "0x182C923A0", Slot = "14")]
		public void KABICKOEJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C92610", Offset = "0x2C91610", VA = "0x182C92610", Slot = "15")]
		public void LGAJLHMGPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C91F70", Offset = "0x2C90F70", VA = "0x182C91F70", Slot = "5")]
		public void GEKCCLOOMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C920B0", Offset = "0x2C910B0", VA = "0x182C920B0", Slot = "6")]
		public void IHDNKPLAFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C92730", Offset = "0x2C91730", VA = "0x182C92730", Slot = "7")]
		public void OGGLGECIIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C91DF0", Offset = "0x2C90DF0", VA = "0x182C91DF0", Slot = "8")]
		public void FOEEKBCPEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C916C0", Offset = "0x2C906C0", VA = "0x182C916C0", Slot = "9")]
		public void AKJGGNJGIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C919B0", Offset = "0x2C909B0", VA = "0x182C919B0", Slot = "10")]
		public void EMNHCFJLCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C91840", Offset = "0x2C90840", VA = "0x182C91840", Slot = "11")]
		public void BBGKALGNPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
		public void JGDCKJHGEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C924C0", Offset = "0x2C914C0", VA = "0x182C924C0", Slot = "12")]
		public void KFGLKCIAMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[IABFONFHPFO(typeof(EEPEPNPEOFG), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.WorldService)]
	public class WorldService : EEPEPNPEOFG, IDisposable, JMMCIOGFDJD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private NPAPPEKNDDD BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GDLOHCFNDBC NFHBPPOEMBF;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public NPAPPEKNDDD BFPFOELPAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JLCGKPAGLMB JADDHOMJIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AAA530", Offset = "0x2AA9530", VA = "0x182AAA530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0910", Offset = "0x2C9F910", VA = "0x182CA0910", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool KCIOFPNPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0800", Offset = "0x2C9F800", VA = "0x182CA0800", Slot = "10")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0930", Offset = "0x2C9F930", VA = "0x182CA0930", Slot = "11")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA04C0", Offset = "0x2C9F4C0", VA = "0x182CA04C0")]
		private void BMDGCEOIEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA05D0", Offset = "0x2C9F5D0", VA = "0x182CA05D0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0980", Offset = "0x2C9F980", VA = "0x182CA0980", Slot = "8")]
		public ComponentSystemBase NIOCCJPAFAI(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IABFONFHPFO(typeof(GJKJMJJGHKM), new string[] { })]
public sealed class KOLDOIACOBE : GJKJMJJGHKM, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KMFLOABPIKI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x413FA70", Offset = "0x413EA70", VA = "0x18413FA70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x986E80", Offset = "0x985E80", VA = "0x180986E80")]
		[DebuggerHidden]
		public KMFLOABPIKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x413F760", Offset = "0x413E760", VA = "0x18413F760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x413FA30", Offset = "0x413EA30", VA = "0x18413FA30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x413F990", Offset = "0x413E990", VA = "0x18413F990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x413F990", Offset = "0x413E990", VA = "0x18413F990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JOODLPJEDOA]
	private FMGCEKBAGOP ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly LILOCMPMJLJ FMNLMHCMKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, HEDJDIFJHAC> MMNGDECPGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, JEOAIDCLOLN> HANOMNKFIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<MGJBDIBFMNC> AJJFGOGFHPM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public JEOAIDCLOLN GMBMBHMAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x30EDC80", Offset = "0x30ECC80", VA = "0x1830EDC80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<MGJBDIBFMNC> EILOCIJEEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x30EDCE0", Offset = "0x30ECCE0", VA = "0x1830EDCE0", Slot = "8")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x30EDC60", Offset = "0x30ECC60", VA = "0x1830EDC60", Slot = "9")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x30EDB60", Offset = "0x30ECB60", VA = "0x1830EDB60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x30EE1E0", Offset = "0x30ED1E0", VA = "0x1830EE1E0", Slot = "6")]
	public bool LKKDNIJHMJA(MGJBDIBFMNC MLIELKFMALM, out JEOAIDCLOLN DEGOBDGJJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x30ED6A0", Offset = "0x30EC6A0", VA = "0x1830ED6A0")]
	private void CGLAALLIAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x30EE040", Offset = "0x30ED040", VA = "0x1830EE040")]
	private void LGLKHBBBFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x30EE350", Offset = "0x30ED350", VA = "0x1830EE350")]
	private HEDJDIFJHAC PGGKANLMGJB(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x30EDC80", Offset = "0x30ECC80", VA = "0x1830EDC80")]
	private HEDJDIFJHAC IFKKNIBNOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x30EDDD0", Offset = "0x30ECDD0", VA = "0x1830EDDD0")]
	private HEDJDIFJHAC KENNHHFBGBF(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x30ED4D0", Offset = "0x30EC4D0", VA = "0x1830ED4D0")]
	private HEDJDIFJHAC BIJLDHLICJD(string NEIBENCLOEC, string JAKCBCDLMLB, [Optional] HEDJDIFJHAC HPENJENHMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x30EDBF0", Offset = "0x30ECBF0", VA = "0x1830EDBF0")]
	[IteratorStateMachine(typeof(KMFLOABPIKI))]
	private IEnumerable<(string, string)> EDIHNOODPBB(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x30EDA30", Offset = "0x30ECA30", VA = "0x1830EDA30")]
	private bool CHFMCKCPEHM(MGJBDIBFMNC MLIELKFMALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x30EDA80", Offset = "0x30ECA80", VA = "0x1830EDA80")]
	private LILOCMPMJLJ DHBJFKGINDB(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x30EE300", Offset = "0x30ED300", VA = "0x1830EE300")]
	private LILOCMPMJLJ OMKBOHBIHNB(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x30EDD40", Offset = "0x30ECD40", VA = "0x1830EDD40")]
	private LILOCMPMJLJ KDIFMHAFCCF(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2FBF4E0", Offset = "0x2FBE4E0", VA = "0x182FBF4E0")]
	private T PCDKLBFDPBK<T>(MGJBDIBFMNC MLIELKFMALM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x30ED460", Offset = "0x30EC460", VA = "0x1830ED460")]
	private FieldInfo BCJGLIMJFKE(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x30EE3B0", Offset = "0x30ED3B0", VA = "0x1830EE3B0")]
	public KOLDOIACOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x30EE270", Offset = "0x30ED270", VA = "0x1830EE270")]
	[CompilerGenerated]
	private int MGMJCKPAHNK(MGJBDIBFMNC BECDKHGLGNB, MGJBDIBFMNC ICPOAGANOLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class HEDJDIFJHAC : JEOAIDCLOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string CLFKPCBMBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly HEDJDIFJHAC HPENJENHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<HEDJDIFJHAC> FAOIGENEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<MGJBDIBFMNC> ICBILMELIDM;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string BPOLGNIIBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JEOAIDCLOLN KPEGMGBBKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<JEOAIDCLOLN> EPIAMHJOEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<MGJBDIBFMNC> DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x30E1170", Offset = "0x30E0170", VA = "0x1830E1170")]
	public HEDJDIFJHAC(string GOENAEMJAON, HEDJDIFJHAC OKMBLMILFGG)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[IABFONFHPFO(typeof(NNPPGMKPBPK), new string[] { })]
	[DBACNPOLGIH(typeof(HistoryService))]
	[OHGELDJCNJM(GGAOONGBEBH.History)]
	public class HistoryService : MIBCENMOHFA, IDisposable, NNPPGMKPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum LBPCFLKJHJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct CJMIHABBCHJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly LBPCFLKJHJH KKINNECEKHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService GNJOCELFONM;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x413A0D0", Offset = "0x41390D0", VA = "0x18413A0D0")]
			public CJMIHABBCHJ(HistoryService GNJOCELFONM, bool BLGMOFOMDOD, uint LFMBJAIIPEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x413A0A0", Offset = "0x41390A0", VA = "0x18413A0A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class KJLOGOAGLJE
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct INMBGCEJKNM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly KJLOGOAGLJE COANEGMLMGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool HCIFABFJCFJ;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x413D7C0", Offset = "0x413C7C0", VA = "0x18413D7C0")]
				public INMBGCEJKNM(KJLOGOAGLJE COANEGMLMGF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x413B9A0", Offset = "0x413A9A0", VA = "0x18413B9A0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct FAOIAHJBGOM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly KJLOGOAGLJE COANEGMLMGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool HCIFABFJCFJ;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x413B9D0", Offset = "0x413A9D0", VA = "0x18413B9D0")]
				public FAOIAHJBGOM(KJLOGOAGLJE COANEGMLMGF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x413B9A0", Offset = "0x413A9A0", VA = "0x18413B9A0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService MBIMJJEJMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool IGJCOLOHHLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int PNEHABOECIH;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x413F060", Offset = "0x413E060", VA = "0x18413F060")]
			public KJLOGOAGLJE(HistoryService MBIMJJEJMCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x413F030", Offset = "0x413E030", VA = "0x18413F030")]
			public bool NKCBMOOJDBH(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x413EF90", Offset = "0x413DF90", VA = "0x18413EF90")]
			public FAOIAHJBGOM CNMMAAFNDFL()
			{
				return default(FAOIAHJBGOM);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x413EFE0", Offset = "0x413DFE0", VA = "0x18413EFE0")]
			public INMBGCEJKNM DACAHPCONHK()
			{
				return default(INMBGCEJKNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class BEEHNCPJMPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public BEEHNCPJMPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4139240", Offset = "0x4138240", VA = "0x184139240")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class DMOOMEOPNGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public DMOOMEOPNGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x413AA40", Offset = "0x4139A40", VA = "0x18413AA40")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class IMIEBIAMFFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public IMIEBIAMFFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x413D6D0", Offset = "0x413C6D0", VA = "0x18413D6D0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction FJAKMFEJAEO;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction OHNJOFLNNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private ADCMMFFHADO KNCLILEABKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer ECDJENCHOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer NBMIBPIAEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private FKFAILBCEFF HGMDMKGFOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase CIBDMNLICDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService ANOCLDOPIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private EAIOBOKBFDP JKCCIJPHOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private LBPCFLKJHJH EJNLFJIGBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private KJLOGOAGLJE COANEGMLMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ODHBDONHIOF OKGDPALNOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private PABMDGDAPHJ NKKIHHJKBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private BPHAMHGLCNC BEGJIDPGJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete CCNKLHILNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint ODMGBJKABEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint BCBBGLCKEIP;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private KJLOGOAGLJE CCOHLDJJBMP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool GGNGEMDMIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x30E3320", Offset = "0x30E2320", VA = "0x1830E3320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool AMDHMLCMIBN
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x30E4CA0", Offset = "0x30E3CA0", VA = "0x1830E4CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool LNJPOLKFNGB
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x30E4D40", Offset = "0x30E3D40", VA = "0x1830E4D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int LNDBDIMKAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x30E4D70", Offset = "0x30E3D70", VA = "0x1830E4D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int PBELHMPBAPE
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x30E4AF0", Offset = "0x30E3AF0", VA = "0x1830E4AF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool IHCOBENEKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x30E3C90", Offset = "0x30E2C90", VA = "0x1830E3C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool AKBBMIGELMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x30E3C20", Offset = "0x30E2C20", VA = "0x1830E3C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool FMEHOHIOCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x91ED30", Offset = "0x91DD30", VA = "0x18091ED30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xFE4980", Offset = "0xFE3980", VA = "0x180FE4980", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer NAPFNKPIMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x30E4B10", Offset = "0x30E3B10", VA = "0x1830E4B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action EAHEKKNPCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x30E3A60", Offset = "0x30E2A60", VA = "0x1830E3A60", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x30E2EA0", Offset = "0x30E1EA0", VA = "0x1830E2EA0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action PPJFBBNFAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x30E3B20", Offset = "0x30E2B20", VA = "0x1830E3B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x30E4E80", Offset = "0x30E3E80", VA = "0x1830E4E80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x30E3DA0", Offset = "0x30E2DA0", VA = "0x1830E3DA0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x30E3590", Offset = "0x30E2590", VA = "0x1830E3590", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x30E4BE0", Offset = "0x30E3BE0", VA = "0x1830E4BE0")]
		private void ODNPEIAAKKN(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x30E2E20", Offset = "0x30E1E20", VA = "0x1830E2E20")]
		private void ACCCPGOJEGO(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM LOAIKIOKFPK, MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x30E3880", Offset = "0x30E2880", VA = "0x1830E3880")]
		private void GCANCHLLJPN(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x30E3530", Offset = "0x30E2530", VA = "0x1830E3530", Slot = "14")]
		public IDisposable DMDHNMJLKDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x30E3BC0", Offset = "0x30E2BC0", VA = "0x1830E3BC0", Slot = "9")]
		public IDisposable HCOCEBGMCAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x30E4780", Offset = "0x30E3780", VA = "0x1830E4780", Slot = "6")]
		public UndoAction MKACKFBEKFL()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x30E3120", Offset = "0x30E2120", VA = "0x1830E3120", Slot = "15")]
		public RedoAction BNAODKOCPOB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x30E2F40", Offset = "0x30E1F40", VA = "0x1830E2F40", Slot = "16")]
		public UndoAction BKEHEAGIMGN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x30E31E0", Offset = "0x30E21E0", VA = "0x1830E31E0", Slot = "7")]
		public RedoAction BNAODKOCPOB(UndoAction NMAMPMADCBK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x30E3000", Offset = "0x30E2000", VA = "0x1830E3000", Slot = "8")]
		public UndoAction BKEHEAGIMGN(RedoAction NMAMPMADCBK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x30E2E40", Offset = "0x30E1E40", VA = "0x1830E2E40")]
		public bool AGDFIKNFHPD(OGOMGDIDANE BNGGLNMHDJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x30E3830", Offset = "0x30E2830", VA = "0x1830E3830", Slot = "17")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x30E4B20", Offset = "0x30E3B20", VA = "0x1830E4B20")]
		public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x30E4250", Offset = "0x30E3250", VA = "0x1830E4250")]
		public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM GLLAKMPHGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x30E45F0", Offset = "0x30E35F0", VA = "0x1830E45F0")]
		public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x30E4E10", Offset = "0x30E3E10", VA = "0x1830E4E10")]
		private void PCLMCAIONGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x30E3380", Offset = "0x30E2380", VA = "0x1830E3380")]
		private void CNPPNBLODBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x30E3300", Offset = "0x30E2300", VA = "0x1830E3300")]
		private void CDAFMEIOCMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x30E3CA0", Offset = "0x30E2CA0", VA = "0x1830E3CA0")]
		private HAOHNOCBDIF JKLMOALPJMD()
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x30E3B00", Offset = "0x30E2B00", VA = "0x1830E3B00")]
		private uint GKLDAECJLBL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x30E2E80", Offset = "0x30E1E80", VA = "0x1830E2E80")]
		private bool BAKDHNKICLJ(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x30E4F20", Offset = "0x30E3F20", VA = "0x1830E4F20")]
		private bool PHKFGNAEPHH(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x30E4F40", Offset = "0x30E3F40", VA = "0x1830E4F40")]
		private RedoAction PMDKIDJFMEG(HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x30E3C30", Offset = "0x30E2C30", VA = "0x1830E3C30")]
		private UndoAction JAECFBLBAML(HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x30E4330", Offset = "0x30E3330", VA = "0x1830E4330")]
		private HAOHNOCBDIF LHDGGGAEMPE(HAOHNOCBDIF FFBLFKDINEA, ActionBuffer MNLJMCGEPLD, bool BLGMOFOMDOD)
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x30E46A0", Offset = "0x30E36A0", VA = "0x1830E46A0")]
		private void MHIMJCDIPKJ(Action FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x22BB240", Offset = "0x22BA240", VA = "0x1822BB240")]
		private T MHIMJCDIPKJ<T>(Func<T> GBGEJGMHGKE)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x30E4E50", Offset = "0x30E3E50", VA = "0x1830E4E50")]
		private CJMIHABBCHJ PGCNKHNHKEK(bool BLGMOFOMDOD, uint LFMBJAIIPEH)
		{
			return default(CJMIHABBCHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x30E5080", Offset = "0x30E4080", VA = "0x1830E5080")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x30E4840", Offset = "0x30E3840", VA = "0x1830E4840")]
		[CompilerGenerated]
		private UndoAction MOFBAJAFKMG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x30E33C0", Offset = "0x30E23C0", VA = "0x1830E33C0")]
		[CompilerGenerated]
		private RedoAction COGAGJCBMNH()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x30E4990", Offset = "0x30E3990", VA = "0x1830E4990")]
		[CompilerGenerated]
		private UndoAction NHPKFIGNGPH()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MBOMJEFALDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> EGIDMCNFHCK;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public MBOMJEFALDL(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90D0", Offset = "0x2AA80D0", VA = "0x182AA90D0")]
	public static MBOMJEFALDL HEFILGHKDEM(NativeArray<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T LAPMNFNPPEF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> MLEADCLLMII<T>(int GDDNEEFIBDF, Allocator GOLNHBOGNGC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> KOGOOLHIMII<T>(Allocator GOLNHBOGNGC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CMHGAHJMLIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> EGIDMCNFHCK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public CMHGAHJMLIF(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A100", Offset = "0x2D19100", VA = "0x182D1A100")]
	public static CMHGAHJMLIF HEFILGHKDEM(NativeArray<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x283E7D0", Offset = "0x283D7D0", VA = "0x18283E7D0")]
	public T LAPMNFNPPEF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> MLEADCLLMII<T>(int GDDNEEFIBDF, Allocator GOLNHBOGNGC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BDKAFDDMKPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> EGIDMCNFHCK;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public BDKAFDDMKPO(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2D15B40", Offset = "0x2D14B40", VA = "0x182D15B40")]
	public static BDKAFDDMKPO HEFILGHKDEM(NativeArray<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x328CFC0", Offset = "0x328BFC0", VA = "0x18328CFC0")]
	public void DGONKICHOIN<T>(in T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x328D020", Offset = "0x328C020", VA = "0x18328D020")]
	public void HGHJJABPICH<T>(NativeArray<T> GLOMCJNAEIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void PBJICMPFGKI<T>(NativeArray<T> KPPLMEOMNGF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MHMGBEOBBOD
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9850", Offset = "0x2AA8850", VA = "0x182AA9850")]
	public static Span<byte> KEHDAOBPPPA(this NativeArray<byte> EGIDMCNFHCK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99E0", Offset = "0x2AA89E0", VA = "0x182AA99E0")]
	public static ReadOnlySpan<byte> NPPIMJPMMMP(this NativeArray<byte> EGIDMCNFHCK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA98E0", Offset = "0x2AA88E0", VA = "0x182AA98E0")]
	public static NativeArray<byte> LOIKFCLLDJF(this NativeArray<byte> EGIDMCNFHCK, int GODLNPABGMH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9960", Offset = "0x2AA8960", VA = "0x182AA9960")]
	public static NativeArray<byte> MEHMIAFMLCG(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x223BC50", Offset = "0x223AC50", VA = "0x18223BC50")]
	public static NativeArray<byte> MEHMIAFMLCG<T>(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9B60", Offset = "0x2AA8B60", VA = "0x182AA9B60")]
	public static NativeArray<byte> OLKHDAMDPIG(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x223BCB0", Offset = "0x223ACB0", VA = "0x18223BCB0")]
	public static NativeArray<byte> OLKHDAMDPIG<T>(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9BD0", Offset = "0x2AA8BD0", VA = "0x182AA9BD0")]
	public static NativeArray<byte> PAHKEBDDEHH(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x223BD10", Offset = "0x223AD10", VA = "0x18223BD10")]
	public static NativeArray<byte> PAHKEBDDEHH<T>(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LHOCDONFHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xCEAD90", Offset = "0xCE9D90", VA = "0x180CEAD90")]
	public LHOCDONFHBE(NativeList<byte> EHJGMBFBLBN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6870", Offset = "0x2AA5870", VA = "0x182AA6870")]
	public static LHOCDONFHBE HEFILGHKDEM(NativeList<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void DGONKICHOIN<T>(in T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void HGHJJABPICH<T>(NativeArray<T> KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void PBJICMPFGKI<T>(NativeArray<T> KPPLMEOMNGF) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.PropertyChanges)]
	public class PropertyChangeNetworkRouter : JMMCIOGFDJD, MIBCENMOHFA, PAOKNLKENHE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[JOODLPJEDOA]
		private CIIJHFDGNGN BBPDLFOHCNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[JOODLPJEDOA]
		private KNGDFJPFKAH ICBILMELIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[JOODLPJEDOA]
		private GNEGPFIBKFN MNJBPLGJFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[JOODLPJEDOA]
		private PropertyChangeRouterService ANOCLDOPIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ADCMMFFHADO IMFNGEBEPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GJNEDJALMDE EMGGINCCEHB;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public ADCMMFFHADO NMJFCILPKGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3E60", Offset = "0x2AC2E60", VA = "0x182AC3E60")]
		public ADCMMFFHADO.FCIGFKLHDBP HJDABMCHLDO()
		{
			return default(ADCMMFFHADO.FCIGFKLHDBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3EA0", Offset = "0x2AC2EA0", VA = "0x182AC3EA0", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3F00", Offset = "0x2AC2F00", VA = "0x182AC3F00", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3910", Offset = "0x2AC2910", VA = "0x182AC3910", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC41C0", Offset = "0x2AC31C0", VA = "0x182AC41C0")]
		public void MKACKFBEKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3B60", Offset = "0x2AC2B60", VA = "0x182AC3B60")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC42D0", Offset = "0x2AC32D0", VA = "0x182AC42D0")]
		private void MKHMFDOLINH(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4180", Offset = "0x2AC3180", VA = "0x182AC4180")]
		private void LIKAMDDGELI(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM LOAIKIOKFPK, MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3B30", Offset = "0x2AC2B30", VA = "0x182AC3B30")]
		private void EPMHDFKPLEJ(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3B80", Offset = "0x2AC2B80", VA = "0x182AC3B80")]
		private void GNKEMEEABAB(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4300", Offset = "0x2AC3300", VA = "0x182AC4300")]
		private void OIJINCLADKN(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3850", Offset = "0x2AC2850", VA = "0x182AC3850")]
		private void DOAMIHPOINF(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3E80", Offset = "0x2AC2E80", VA = "0x182AC3E80")]
		private void ICIPFBNLMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3830", Offset = "0x2AC2830", VA = "0x182AC3830")]
		private void DEDKIMIMABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4430", Offset = "0x2AC3430", VA = "0x182AC4430")]
		private void POCKKLGKKFG(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4485730", Offset = "0x4484730", VA = "0x184485730", Slot = "6")]
		private void ECALMKPNLAI<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, object MFEOJPNCOBA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[OHGELDJCNJM(GGAOONGBEBH.History)]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void CBJMNBDFHCN(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void CBBBIOKFIPB(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM LOAIKIOKFPK, MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void JKFBDHBPMKD(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CBJMNBDFHCN BMDGCEOIEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CBBBIOKFIPB LJHAIPHPMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JKFBDHBPMKD BAFMLPIANAD;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC45B0", Offset = "0x2AC35B0", VA = "0x182AC45B0")]
		public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4520", Offset = "0x2AC3520", VA = "0x182AC4520")]
		public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM LOAIKIOKFPK, in MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4590", Offset = "0x2AC3590", VA = "0x182AC4590")]
		public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(AEIKLODAOFE))]
	[OHGELDJCNJM(GGAOONGBEBH.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class AEIKLODAOFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer BFNDINBALAB;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int IIEJMBAKGHF
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2C838D0", Offset = "0x2C828D0", VA = "0x182C838D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public NMAGLEIDGHF[] HJOLNCNNDFA
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2C83920", Offset = "0x2C82920", VA = "0x182C83920")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
			public AEIKLODAOFE(ActionBuffer KAIDENHIDAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2C837E0", Offset = "0x2C827E0", VA = "0x182C837E0")]
			[CompilerGenerated]
			private NMAGLEIDGHF FMENLMFNGAK(HAOHNOCBDIF FFBLFKDINEA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class NMAGLEIDGHF : PAOKNLKENHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer BFNDINBALAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly HAOHNOCBDIF FFBLFKDINEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(GJNEDJALMDE, string, object)> GLKGCBOKLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private CMHGAHJMLIF CAOOCDOHIKF;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int IIEJMBAKGHF
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2C875E0", Offset = "0x2C865E0", VA = "0x182C875E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(GJNEDJALMDE, string, object)> NDLOCDALLEL
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2C87630", Offset = "0x2C86630", VA = "0x182C87630")]
			public NMAGLEIDGHF(ActionBuffer KAIDENHIDAD, HAOHNOCBDIF FFBLFKDINEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2C874E0", Offset = "0x2C864E0", VA = "0x182C874E0")]
			private string MNOMENMHBNK(GJNEDJALMDE EMGGINCCEHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2C871A0", Offset = "0x2C861A0", VA = "0x182C871A0")]
			private void MGAGAAKAIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2B8CC80", Offset = "0x2B8BC80", VA = "0x182B8CC80", Slot = "4")]
			public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, [Optional] object MFEOJPNCOBA) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> KOMNBMOHOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<HAOHNOCBDIF> HNCGKCBIMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly ICLOMBCOJEF GECFOOCOBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly ODHBDONHIOF OKGDPALNOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly KNGDFJPFKAH ICBILMELIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool GJELBFGDNKL;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public ECAJINLFENJ AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2D12CB0", Offset = "0x2D11CB0", VA = "0x182D12CB0")]
			get
			{
				return default(ECAJINLFENJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D13070", Offset = "0x2D12070", VA = "0x182D13070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D13100", Offset = "0x2D12100", VA = "0x182D13100")]
		public ActionBuffer(ODHBDONHIOF OKGDPALNOAA, KNGDFJPFKAH ICBILMELIDM, bool GJELBFGDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D12EA0", Offset = "0x2D11EA0", VA = "0x182D12EA0")]
		public bool MHKBLPPBOOD(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D12AD0", Offset = "0x2D11AD0", VA = "0x182D12AD0")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D12F30", Offset = "0x2D11F30", VA = "0x182D12F30")]
		public HAOHNOCBDIF MKACKFBEKFL(EIMPGEHINCC GLKGCBOKLJL, EAIOBOKBFDP JKCCIJPHOBG, uint HNCBIABFJPH)
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D125D0", Offset = "0x2D115D0", VA = "0x182D125D0")]
		public bool ADOGLCANOKE(uint HNCBIABFJPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D123E0", Offset = "0x2D113E0", VA = "0x182D123E0")]
		public bool AACLAIDNHNK(uint HNCBIABFJPH, out HAOHNOCBDIF NMAMPMADCBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D12B40", Offset = "0x2D11B40", VA = "0x182D12B40")]
		public void HHEFMAHOKLG(HAOHNOCBDIF NMAMPMADCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D12990", Offset = "0x2D11990", VA = "0x182D12990")]
		[Conditional("DEBUG_BUILD")]
		private void EELGGEHAFMK(HAOHNOCBDIF NMAMPMADCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D12CF0", Offset = "0x2D11CF0", VA = "0x182D12CF0")]
		private void LHDGGGAEMPE(HAOHNOCBDIF NHOLBOBHHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D12600", Offset = "0x2D11600", VA = "0x182D12600")]
		private void AODFDAGAHFI(CMHGAHJMLIF DEAFIOFDCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D12E40", Offset = "0x2D11E40", VA = "0x182D12E40")]
		private void MAOMFFHKMOI(HAOHNOCBDIF FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D12840", Offset = "0x2D11840", VA = "0x182D12840")]
		private CMHGAHJMLIF CACNNAPEAJJ(HAOHNOCBDIF FFBLFKDINEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D12920", Offset = "0x2D11920", VA = "0x182D12920", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class ICLOMBCOJEF : PAOKNLKENHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly ODHBDONHIOF OKGDPALNOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly KNGDFJPFKAH ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private IJDKBBDMEBI LCCDBPIJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private CMHGAHJMLIF KIEEFELECNH;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6E0", Offset = "0x6DE6E0", VA = "0x1806DF6E0")]
	public ICLOMBCOJEF(ODHBDONHIOF OKGDPALNOAA, KNGDFJPFKAH ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x22BDD60", Offset = "0x22BCD60", VA = "0x1822BDD60", Slot = "4")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> JKKOPMICBJA, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x30E5100", Offset = "0x30E4100", VA = "0x1830E5100")]
	public void LPKKHPLBIJM(GJNEDJALMDE EMGGINCCEHB, ref CMHGAHJMLIF DEAFIOFDCHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ADCMMFFHADO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct FCIGFKLHDBP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly ADCMMFFHADO OKMBLMILFGG;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C83F30", Offset = "0x2C82F30", VA = "0x182C83F30")]
		public FCIGFKLHDBP(ADCMMFFHADO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C83F10", Offset = "0x2C82F10", VA = "0x182C83F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected EIMPGEHINCC GLKGCBOKLJL;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EIMPGEHINCC NDLOCDALLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E810", Offset = "0x2D0D810", VA = "0x182D0E810")]
		get
		{
			return default(EIMPGEHINCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OHGLIFCLEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D0EBF0", Offset = "0x2D0DBF0", VA = "0x182D0EBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EC00", Offset = "0x2D0DC00", VA = "0x182D0EC00")]
	public ADCMMFFHADO(EIMPGEHINCC.BEMKIHCEIOB CIMKFPCFBNF = EIMPGEHINCC.BEMKIHCEIOB.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E850", Offset = "0x2D0D850", VA = "0x182D0E850")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EB00", Offset = "0x2D0DB00", VA = "0x182D0EB00")]
	public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E990", Offset = "0x2D0D990", VA = "0x182D0E990")]
	public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EA20", Offset = "0x2D0DA20", VA = "0x182D0EA20")]
	public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E890", Offset = "0x2D0D890", VA = "0x182D0E890")]
	public void ICIPFBNLMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E700", Offset = "0x2D0D700", VA = "0x182D0E700")]
	public void DEDKIMIMABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E800", Offset = "0x2D0D800", VA = "0x182D0E800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E860", Offset = "0x2D0D860", VA = "0x182D0E860")]
	public FCIGFKLHDBP HJDABMCHLDO()
	{
		return default(FCIGFKLHDBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct GJNEDJALMDE : IComparable<GJNEDJALMDE>, IEquatable<GJNEDJALMDE>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly GJNEDJALMDE GDFEBAPAIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public IJDKBBDMEBI LCCDBPIJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public BPHAMHGLCNC AOKMGDODDPA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x30E09A0", Offset = "0x30DF9A0", VA = "0x1830E09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
	public GJNEDJALMDE(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x30E0940", Offset = "0x30DF940", VA = "0x1830E0940")]
	public void LIPJNEJALJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x30E0790", Offset = "0x30DF790", VA = "0x1830E0790", Slot = "4")]
	public int CompareTo(GJNEDJALMDE JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x30E09B0", Offset = "0x30DF9B0", VA = "0x1830E09B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x30E0820", Offset = "0x30DF820", VA = "0x1830E0820", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x30E07D0", Offset = "0x30DF7D0", VA = "0x1830E07D0", Slot = "5")]
	public bool Equals(GJNEDJALMDE JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x30E0900", Offset = "0x30DF900", VA = "0x1830E0900")]
	public static bool IIPILNNMHKL(GJNEDJALMDE AJDPMFOKMPC, GJNEDJALMDE DAAPHBHBHCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x30E0950", Offset = "0x30DF950", VA = "0x1830E0950")]
	public static bool NCOOAABHIPD(GJNEDJALMDE AJDPMFOKMPC, GJNEDJALMDE DAAPHBHBHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x30E08C0", Offset = "0x30DF8C0", VA = "0x1830E08C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[OHGELDJCNJM(GGAOONGBEBH.History)]
	public class GatherPropertiesForUndelete : FDCKEIMNKII
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private ODHBDONHIOF OKGDPALNOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IJDKBBDMEBI LCCDBPIJCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService MBIMJJEJMCN;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x30E0F90", Offset = "0x30DFF90", VA = "0x1830E0F90")]
		public void DBJECMLBLNK(IJDKBBDMEBI LCCDBPIJCNE, ODHBDONHIOF OKGDPALNOAA, HistoryService MBIMJJEJMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x30E0EC0", Offset = "0x30DFEC0", VA = "0x1830E0EC0", Slot = "4")]
		private void CLHPNLMKHIP(OHACNMOLGIH MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GDCBANIHENN
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x30DEDC0", Offset = "0x30DDDC0", VA = "0x1830DEDC0")]
	public static void OIJINCLADKN(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB, ADIOIKPLFDJ IHJHNOGDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x30DEB60", Offset = "0x30DDB60", VA = "0x1830DEB60")]
	public static void CHDFDHALOJD(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x30DEC20", Offset = "0x30DDC20", VA = "0x1830DEC20")]
	public static void DOAMIHPOINF(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x30DEC70", Offset = "0x30DDC70", VA = "0x1830DEC70")]
	public static void FEDJBBEEOMK(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x30DED20", Offset = "0x30DDD20", VA = "0x1830DED20")]
	public static ADIOIKPLFDJ KAJODJILOGD(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
		return default(ADIOIKPLFDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x231D290", Offset = "0x231C290", VA = "0x18231D290")]
	public static T ICNGPLOGIFB<T>(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x231D760", Offset = "0x231C760", VA = "0x18231D760")]
	public static T ICNGPLOGIFB<T>(ref CMHGAHJMLIF FNIHENPLJHK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x30DED70", Offset = "0x30DDD70", VA = "0x1830DED70")]
	public static ADIOIKPLFDJ KAJODJILOGD(ref CMHGAHJMLIF FNIHENPLJHK)
	{
		return default(ADIOIKPLFDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct EIMPGEHINCC : IEnumerable<GJNEDJALMDE>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum BEMKIHCEIOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct BCBGPFPJACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly EIMPGEHINCC EHJGMBFBLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly EAIOBOKBFDP JKCCIJPHOBG;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4139200", Offset = "0x4138200", VA = "0x184139200")]
		public BCBGPFPJACO(EIMPGEHINCC EHJGMBFBLBN, EAIOBOKBFDP JKCCIJPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4138E00", Offset = "0x4137E00", VA = "0x184138E00")]
		public void OPJGGHDHMGP(NativeList<byte> BBKJOBCNEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4138B60", Offset = "0x4137B60", VA = "0x184138B60")]
		private void GEPEPIMHLGH(GJNEDJALMDE EMGGINCCEHB, ref BDKAFDDMKPO OIMCEIHNOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x41388F0", Offset = "0x41378F0", VA = "0x1841388F0")]
		private void DHEJHCOJENK(GJNEDJALMDE EMGGINCCEHB, ref BDKAFDDMKPO OIMCEIHNOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4138980", Offset = "0x4137980", VA = "0x184138980")]
		private NativeArray<byte> EJPFMCJBPLI(NativeList<byte> BBKJOBCNEOF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4138A70", Offset = "0x4137A70", VA = "0x184138A70")]
		private NativeArray<byte> FEEMNAJBONB(NativeList<byte> BBKJOBCNEOF, int GDDNEEFIBDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4138BB0", Offset = "0x4137BB0", VA = "0x184138BB0")]
		private int GKMBDBJKADB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x41390A0", Offset = "0x41380A0", VA = "0x1841390A0")]
		private bool PNCJHJJJPHM(GJNEDJALMDE EMGGINCCEHB, out NativeArray<byte> OKEDHPLMBHM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ACHPMAOFGNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> FNIHENPLJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private EIMPGEHINCC EHJGMBFBLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly GJNEDJALMDE EHNCKNECPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int GODLNPABGMH;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x41375F0", Offset = "0x41365F0", VA = "0x1841375F0")]
		internal ACHPMAOFGNK(EIMPGEHINCC EHJGMBFBLBN, GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4137380", Offset = "0x4136380", VA = "0x184137380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x41373B0", Offset = "0x41363B0", VA = "0x1841373B0")]
		public void FMIJJIPPKFC(NativeArray<byte> KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4137410", Offset = "0x4136410", VA = "0x184137410")]
		public void JAPGIHIMBEL(NativeArray<byte> KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4137370", Offset = "0x4136370", VA = "0x184137370")]
		public void DHEJHCOJENK(in MPOLKMCKMLM KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2B76CA0", Offset = "0x2B75CA0", VA = "0x182B76CA0")]
		public void DHEJHCOJENK<T>(T KPPLMEOMNGF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x41374D0", Offset = "0x41364D0", VA = "0x1841374D0")]
		private void KEGBOBEHJBC(int KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4137540", Offset = "0x4136540", VA = "0x184137540")]
		private void KEGBOBEHJBC(in MPOLKMCKMLM KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4137470", Offset = "0x4136470", VA = "0x184137470")]
		private unsafe void KEGBOBEHJBC(void* BIDBAIHFLFD, int GDDNEEFIBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x41373B0", Offset = "0x41363B0", VA = "0x1841373B0")]
		private void KEGBOBEHJBC(NativeArray<byte> GLOMCJNAEIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FAAFIHDHLAN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private EIMPGEHINCC EHJGMBFBLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> FNIHENPLJHK;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x413B960", Offset = "0x413A960", VA = "0x18413B960")]
		internal FAAFIHDHLAN(EIMPGEHINCC EHJGMBFBLBN, NativeArray<byte> FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x413B6A0", Offset = "0x413A6A0", VA = "0x18413B6A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x413B8A0", Offset = "0x413A8A0", VA = "0x18413B8A0")]
		public NativeArray<byte> MLEADCLLMII(int GDDNEEFIBDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x413B6B0", Offset = "0x413A6B0", VA = "0x18413B6B0")]
		public NativeArray<byte> KOGOOLHIMII()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2B77930", Offset = "0x2B76930", VA = "0x182B77930")]
		public T LAPMNFNPPEF<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x413B7A0", Offset = "0x413A7A0", VA = "0x18413B7A0")]
		public void LAPMNFNPPEF(in GHPDGIAHCBK KPPLMEOMNGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NHPNHPOMKAN : IEnumerator<GJNEDJALMDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<GJNEDJALMDE> EGIDMCNFHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int EGBCAPEEJBF;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public GJNEDJALMDE AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x41416D0", Offset = "0x41406D0", VA = "0x1841416D0", Slot = "4")]
			get
			{
				return default(GJNEDJALMDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x4141690", Offset = "0x4140690", VA = "0x184141690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x31DF790", Offset = "0x31DE790", VA = "0x1831DF790")]
		internal NHPNHPOMKAN(NativeList<GJNEDJALMDE> GLOMCJNAEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x4141550", Offset = "0x4140550", VA = "0x184141550", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4141650", Offset = "0x4140650", VA = "0x184141650", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct KLGNLMLHPEF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int MIIMBDFNNJN = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int GBEHLANOPBP = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int NNDCJDNOELE = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> FNIHENPLJHK;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool FAFBILBNMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x413F5F0", Offset = "0x413E5F0", VA = "0x18413F5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int IBBOMNPJGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x413F5A0", Offset = "0x413E5A0", VA = "0x18413F5A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x413F570", Offset = "0x413E570", VA = "0x18413F570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public BEMKIHCEIOB IOLLCPFPNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x413F580", Offset = "0x413E580", VA = "0x18413F580")]
			get
			{
				return default(BEMKIHCEIOB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x413F590", Offset = "0x413E590", VA = "0x18413F590")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool OHGLIFCLEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x413F650", Offset = "0x413E650", VA = "0x18413F650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x413F630", Offset = "0x413E630", VA = "0x18413F630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool KFOHGDOOFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x413F660", Offset = "0x413E660", VA = "0x18413F660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x413F510", Offset = "0x413E510", VA = "0x18413F510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x413F670", Offset = "0x413E670", VA = "0x18413F670")]
		public KLGNLMLHPEF(BEMKIHCEIOB CIMKFPCFBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x413F4E0", Offset = "0x413E4E0", VA = "0x18413F4E0")]
		private int BOEAFIEBIHC(int LKCJJEBACFP, int HEFBLHDCOBM = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x413F5B0", Offset = "0x413E5B0", VA = "0x18413F5B0")]
		private void JPNFGACMGOG(int LKCJJEBACFP, int KPPLMEOMNGF, int HEFBLHDCOBM = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x413F530", Offset = "0x413E530", VA = "0x18413F530", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int HIMNGMNFJGB = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int OPDFOMCPAKE = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly GJNEDJALMDE HNEJENCKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<GJNEDJALMDE, int> AAJFOGCOCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<GJNEDJALMDE> GLKGCBOKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> LHKCGGFJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> HLDMDGPFLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private KLGNLMLHPEF DGCNIAGLPMA;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OHGLIFCLEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C020", Offset = "0x2D2B020", VA = "0x182D2C020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PMNEPBJNENC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BEF0", Offset = "0x2D2AEF0", VA = "0x182D2BEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int IBBOMNPJGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BD20", Offset = "0x2D2AD20", VA = "0x182D2BD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int DEELBMINOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B570", Offset = "0x2D2A570", VA = "0x182D2B570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BFE0", Offset = "0x2D2AFE0", VA = "0x182D2BFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B530", Offset = "0x2D2A530", VA = "0x182D2B530")]
	public static EIMPGEHINCC BMDGCEOIEEG(BEMKIHCEIOB CIMKFPCFBNF = BEMKIHCEIOB.Last, int MPDIEGJOOBA = 16, int JONLFIPEDCN = 256)
	{
		return default(EIMPGEHINCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C130", Offset = "0x2D2B130", VA = "0x182D2C130")]
	private EIMPGEHINCC(BEMKIHCEIOB CIMKFPCFBNF, int MPDIEGJOOBA, int JONLFIPEDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B6A0", Offset = "0x2D2A6A0", VA = "0x182D2B6A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B860", Offset = "0x2D2A860", VA = "0x182D2B860")]
	public ACHPMAOFGNK GNKEMEEABAB(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(ACHPMAOFGNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BE60", Offset = "0x2D2AE60", VA = "0x182D2BE60")]
	public FAAFIHDHLAN LMPCHNBHKDC(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(FAAFIHDHLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BB30", Offset = "0x2D2AB30", VA = "0x182D2BB30")]
	public bool JIBEPPJMFCH(GJNEDJALMDE EHNCKNECPAL, out FAAFIHDHLAN AKMHDEFEKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BAE0", Offset = "0x2D2AAE0", VA = "0x182D2BAE0")]
	public bool IPHPDBNLADP(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BF10", Offset = "0x2D2AF10", VA = "0x182D2BF10")]
	public bool NBALFPMAHGJ(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B5B0", Offset = "0x2D2A5B0", VA = "0x182D2B5B0")]
	public void CPJGLJCDGOO(NativeList<byte> BBKJOBCNEOF, EAIOBOKBFDP JKCCIJPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E17250", Offset = "0x1E16250", VA = "0x181E17250")]
	public T IPFANDCPJOE<T>(GJNEDJALMDE EHNCKNECPAL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B780", Offset = "0x2D2A780", VA = "0x182D2B780")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BD30", Offset = "0x2D2AD30", VA = "0x182D2BD30")]
	public NHPNHPOMKAN KGLEFCHHJJI()
	{
		return default(NHPNHPOMKAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B8F0", Offset = "0x2D2A8F0", VA = "0x182D2B8F0")]
	private void HGIFOPINIAH(GJNEDJALMDE EHNCKNECPAL, int GODLNPABGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BD70", Offset = "0x2D2AD70", VA = "0x182D2BD70")]
	private void LIPJNEJALJE(int JMOLLNMGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B440", Offset = "0x2D2A440", VA = "0x182D2B440")]
	private void ACMIFKHCHID(GJNEDJALMDE EHNCKNECPAL, int GODLNPABGMH, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1E173E0", Offset = "0x1E163E0", VA = "0x181E173E0")]
	private static T IPFANDCPJOE<T>(NativeArray<byte> EGIDMCNFHCK, int LKCJJEBACFP = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C070", Offset = "0x2D2B070", VA = "0x182D2C070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C030", Offset = "0x2D2B030", VA = "0x182D2C030", Slot = "4")]
	private IEnumerator<GJNEDJALMDE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class ANHDKBGNFCG<T> : HCAPJDLAPMD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3E24FB0", Offset = "0x3E23FB0", VA = "0x183E24FB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3E250D0", Offset = "0x3E240D0", VA = "0x183E250D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x302C6C0", Offset = "0x302B6C0", VA = "0x18302C6C0")]
	public ANHDKBGNFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	internal class CleanupRigidbodyExImpl : HCAPJDLAPMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C5E0", Offset = "0x2D1B5E0", VA = "0x182D1C5E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C680", Offset = "0x2D1B680", VA = "0x182D1C680", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class ACICEEJKODG : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery FBMGCPJOJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E570", Offset = "0x2D0D570", VA = "0x182D0E570", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E5C0", Offset = "0x2D0D5C0", VA = "0x182D0E5C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E650", Offset = "0x2D0D650", VA = "0x182D0E650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public ACICEEJKODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal class IOAJNJPOEHI : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService IIGGNDCMPHA;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x30E6D20", Offset = "0x30E5D20", VA = "0x1830E6D20", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x30E6D70", Offset = "0x30E5D70", VA = "0x1830E6D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public IOAJNJPOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService LKMIJPPNOAG;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2D29DA0", Offset = "0x2D28DA0", VA = "0x182D29DA0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2D29DF0", Offset = "0x2D28DF0", VA = "0x182D29DF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2D29E80", Offset = "0x2D28E80", VA = "0x182D29E80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	[IABFONFHPFO(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<ODILOCJODCG>> MAGLBLOKDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2D25790", Offset = "0x2D24790", VA = "0x182D25790", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2D25720", Offset = "0x2D24720", VA = "0x182D25720")]
		public void IHGGPOIHOJD(NativeListAsync<ODILOCJODCG> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2D257E0", Offset = "0x2D247E0", VA = "0x182D257E0")]
		public void OFICLPBCEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2D255B0", Offset = "0x2D245B0", VA = "0x182D255B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2D25CA0", Offset = "0x2D24CA0", VA = "0x182D25CA0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[IABFONFHPFO(typeof(AHELNIAPJDN), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public class PhysicsService : MIBCENMOHFA, PFFHIJLFPMD, AHELNIAPJDN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly JHCDFELAIDH MOOGCCGHDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private IIEBHPDOOAI GDLIAMNMDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService FOOIHPIJMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::HHLEGGEGCOD<GNGNCAJDDOM> HFMBLNLNJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<GPEJGMHBDPO, GNGNCAJDDOM> GKOLHLBCBDM
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1260", Offset = "0x2AC0260", VA = "0x182AC1260", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC1100", Offset = "0x2AC0100", VA = "0x182AC1100", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0FE0", Offset = "0x2ABFFE0", VA = "0x182AC0FE0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0E70", Offset = "0x2ABFE70", VA = "0x182AC0E70", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0C50", Offset = "0x2ABFC50", VA = "0x182AC0C50", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0DA0", Offset = "0x2ABFDA0", VA = "0x182AC0DA0", Slot = "8")]
		public bool ELPDMAKIGPE(GPEJGMHBDPO GBPGPLEPLBP, out Collider MMNMMMMCHOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2AC11A0", Offset = "0x2AC01A0", VA = "0x182AC11A0")]
		private void NNCNEPPIONG(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0CE0", Offset = "0x2ABFCE0", VA = "0x182AC0CE0", Slot = "9")]
		public void EGMKKCJGINM(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[IABFONFHPFO(typeof(OLGPCPINIDC), new string[] { })]
	public class RbexService : MIBCENMOHFA, OLGPCPINIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private LLCGHMDHHEA JGEFAJMNOMB;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8380", Offset = "0x2AC7380", VA = "0x182AC8380")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2AC86A0", Offset = "0x2AC76A0", VA = "0x182AC86A0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7E20", Offset = "0x2AC6E20", VA = "0x182AC7E20", Slot = "6")]
		public KLALODLBPPC HDJGOBKHOHI(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9210", Offset = "0x2AC8210", VA = "0x182AC9210", Slot = "5")]
		public void MGJHNOCJPAI(GPEJGMHBDPO GBPGPLEPLBP, KLALODLBPPC KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7240", Offset = "0x2AC6240", VA = "0x182AC7240", Slot = "34")]
		public CollisionDetectionMode DBCLLGDDCGL(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6A20", Offset = "0x2AC5A20", VA = "0x182AC6A20", Slot = "35")]
		public void BGKEEAMIHGM(GPEJGMHBDPO GBPGPLEPLBP, CollisionDetectionMode KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7A20", Offset = "0x2AC6A20", VA = "0x182AC7A20", Slot = "36")]
		public CLIIJKDLFPK GEAIKJCLOGP(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CLIIJKDLFPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6590", Offset = "0x2AC5590", VA = "0x182AC6590", Slot = "37")]
		public void ADGMABPELNK(GPEJGMHBDPO GBPGPLEPLBP, CLIIJKDLFPK KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8E90", Offset = "0x2AC7E90", VA = "0x182AC8E90", Slot = "38")]
		public bool LDLGFHNEPCH(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7940", Offset = "0x2AC6940", VA = "0x182AC7940", Slot = "39")]
		public void FOOEIAEOEKK(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9850", Offset = "0x2AC8850", VA = "0x182AC9850", Slot = "40")]
		public GPEJGMHBDPO PLFCFKIEBOC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7080", Offset = "0x2AC6080", VA = "0x182AC7080", Slot = "41")]
		public void CEJMMPCINJH(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2AC76B0", Offset = "0x2AC66B0", VA = "0x182AC76B0", Slot = "42")]
		public GPEJGMHBDPO FCHNDLGHOIE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2AC85C0", Offset = "0x2AC75C0", VA = "0x182AC85C0", Slot = "43")]
		public void JDHACNMMLIE(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7BF0", Offset = "0x2AC6BF0", VA = "0x182AC7BF0", Slot = "7")]
		public void GFLPJLNLLDG(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8D80", Offset = "0x2AC7D80", VA = "0x182AC8D80", Slot = "8")]
		public void LDFJFKBFDMD(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8C90", Offset = "0x2AC7C90", VA = "0x182AC8C90", Slot = "9")]
		public int KIPGBJMICGF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7520", Offset = "0x2AC6520", VA = "0x182AC7520", Slot = "10")]
		public GPEJGMHBDPO ELIAHCIMIEO(GPEJGMHBDPO GBPGPLEPLBP, int EGBCAPEEJBF)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2AC88E0", Offset = "0x2AC78E0", VA = "0x182AC88E0", Slot = "11")]
		public void KEBPCPNFNOA(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7AC0", Offset = "0x2AC6AC0", VA = "0x182AC7AC0", Slot = "12")]
		public void GFKEMMLPMKC(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93D0", Offset = "0x2AC83D0", VA = "0x182AC93D0", Slot = "13")]
		public void NAIJGGADILP(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8010", Offset = "0x2AC7010", VA = "0x182AC8010", Slot = "14")]
		public bool IBIMJNBNPAM(GPEJGMHBDPO GBPGPLEPLBP, out GPEJGMHBDPO KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8C10", Offset = "0x2AC7C10", VA = "0x182AC8C10", Slot = "15")]
		public void KIFINBFGOBH(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6E90", Offset = "0x2AC5E90", VA = "0x182AC6E90", Slot = "16")]
		public bool BODINHBKBCO(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7850", Offset = "0x2AC6850", VA = "0x182AC7850", Slot = "17")]
		public void FJHKIOFBFIG(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6A90", Offset = "0x2AC5A90", VA = "0x182AC6A90", Slot = "18")]
		public bool BHGNDGMNKEH(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7F10", Offset = "0x2AC6F10", VA = "0x182AC7F10", Slot = "26")]
		public float3 HELAJODAOIB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7F90", Offset = "0x2AC6F90", VA = "0x182AC7F90", Slot = "27")]
		public void HNNBIOJHDFN(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9760", Offset = "0x2AC8760", VA = "0x182AC9760", Slot = "28")]
		public float PEJCKENHMFC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9550", Offset = "0x2AC8550", VA = "0x182AC9550", Slot = "29")]
		public void OHAEJELHKHK(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8200", Offset = "0x2AC7200", VA = "0x182AC8200", Slot = "30")]
		public float IGKPCBJHCAP(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2AC96F0", Offset = "0x2AC86F0", VA = "0x182AC96F0", Slot = "31")]
		public void PCLAMECJFPB(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2AC95C0", Offset = "0x2AC85C0", VA = "0x182AC95C0", Slot = "32")]
		public bool OIEFKDDNJOK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8480", Offset = "0x2AC7480", VA = "0x182AC8480", Slot = "33")]
		public void IOPJGMHMNEP(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2AC66C0", Offset = "0x2AC56C0", VA = "0x182AC66C0", Slot = "19")]
		public void AJFINOGDGGA(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6BF0", Offset = "0x2AC5BF0", VA = "0x182AC6BF0", Slot = "20")]
		public bool BHHCKKBPFDB(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC78D0", Offset = "0x2AC68D0", VA = "0x182AC78D0", Slot = "21")]
		public void FOCPOBBHBIN(GPEJGMHBDPO GBPGPLEPLBP, quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC90B0", Offset = "0x2AC80B0", VA = "0x182AC90B0", Slot = "22")]
		public bool MBDCDFKIFAL(GPEJGMHBDPO GBPGPLEPLBP, out quaternion KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6740", Offset = "0x2AC5740", VA = "0x182AC6740", Slot = "23")]
		public bool APGPCNDDAAC(GPEJGMHBDPO GBPGPLEPLBP, out float3 HEEAFJJDDDN, out quaternion HNDEAFEIHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9690", Offset = "0x2AC8690", VA = "0x182AC9690", Slot = "44")]
		public CACECFKIIAN PBHLDOLFJFK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CACECFKIIAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7640", Offset = "0x2AC6640", VA = "0x182AC7640", Slot = "45")]
		public void EPMPDPGCKBN(GPEJGMHBDPO GBPGPLEPLBP, CACECFKIIAN KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6630", Offset = "0x2AC5630", VA = "0x182AC6630", Slot = "72")]
		public void ADPCEDEIBAN(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2AC97C0", Offset = "0x2AC87C0", VA = "0x182AC97C0", Slot = "73")]
		public void PJMHPOOCMGC(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2AC71C0", Offset = "0x2AC61C0", VA = "0x182AC71C0", Slot = "74")]
		public bool CMBFFGPGFGA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2AC72A0", Offset = "0x2AC62A0", VA = "0x182AC72A0", Slot = "81")]
		public void DKHHOAIECEJ(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8850", Offset = "0x2AC7850", VA = "0x182AC8850", Slot = "82")]
		public void KDIPPBLKDPA(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9460", Offset = "0x2AC8460", VA = "0x182AC9460", Slot = "83")]
		public bool NEOJDDFALBE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2AC73C0", Offset = "0x2AC63C0", VA = "0x182AC73C0", Slot = "84")]
		public IEnumerable<object> DLCLEHONLLJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8640", Offset = "0x2AC7640", VA = "0x182AC8640", Slot = "46")]
		public bool JEADMAHLCBM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8BB0", Offset = "0x2AC7BB0", VA = "0x182AC8BB0", Slot = "47")]
		public void KGNFPJNJGIF(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7D60", Offset = "0x2AC6D60", VA = "0x182AC7D60", Slot = "48")]
		public bool GPKPIMDMNCB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8750", Offset = "0x2AC7750", VA = "0x182AC8750", Slot = "49")]
		public void JPEIOCMBKHL(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC77F0", Offset = "0x2AC67F0", VA = "0x182AC77F0", Slot = "50")]
		public bool FGNIDPMGLCC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC79B0", Offset = "0x2AC69B0", VA = "0x182AC79B0", Slot = "51")]
		public void FPJCLJEKIMI(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9050", Offset = "0x2AC8050", VA = "0x182AC9050", Slot = "52")]
		public RigidbodyConstraints LOBIBEONOFE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC69B0", Offset = "0x2AC59B0", VA = "0x182AC69B0", Slot = "53")]
		public void BBGMNJCNHOM(GPEJGMHBDPO GBPGPLEPLBP, RigidbodyConstraints KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7EB0", Offset = "0x2AC6EB0", VA = "0x182AC7EB0", Slot = "54")]
		public float HEKNDLKLNGB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2AC94E0", Offset = "0x2AC84E0", VA = "0x182AC94E0", Slot = "55")]
		public void OECEHKGENPJ(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7D00", Offset = "0x2AC6D00", VA = "0x182AC7D00", Slot = "56")]
		public float GKHNAPBHBOA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6D50", Offset = "0x2AC5D50", VA = "0x182AC6D50", Slot = "57")]
		public void BHLAGEHDKAO(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7DC0", Offset = "0x2AC6DC0", VA = "0x182AC7DC0", Slot = "58")]
		public bool HCACJPAEEKE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2AC92C0", Offset = "0x2AC82C0", VA = "0x182AC92C0", Slot = "59")]
		public void MHJHELHLJLI(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7160", Offset = "0x2AC6160", VA = "0x182AC7160", Slot = "60")]
		public bool CGDCEMJAEGO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9620", Offset = "0x2AC8620", VA = "0x182AC9620", Slot = "61")]
		public void PAFABGIFGOF(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7100", Offset = "0x2AC6100", VA = "0x182AC7100", Slot = "62")]
		public int CFGBCGALNND(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2AC9330", Offset = "0x2AC8330", VA = "0x182AC9330", Slot = "63")]
		public void MKPPILDMAIM(GPEJGMHBDPO GBPGPLEPLBP, int KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6FF0", Offset = "0x2AC5FF0", VA = "0x182AC6FF0", Slot = "64")]
		public Rigidbody BPICHLHNMGF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8EF0", Offset = "0x2AC7EF0", VA = "0x182AC8EF0", Slot = "65")]
		public void LMBCLHNJMDN(GPEJGMHBDPO GBPGPLEPLBP, Rigidbody KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8260", Offset = "0x2AC7260", VA = "0x182AC8260", Slot = "75")]
		public void IHDBPPFEHMM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC82F0", Offset = "0x2AC72F0", VA = "0x182AC82F0", Slot = "76")]
		public void IJGOFLCDNLM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC83A0", Offset = "0x2AC73A0", VA = "0x182AC83A0", Slot = "77")]
		public bool ILAGIPAEENF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7760", Offset = "0x2AC6760", VA = "0x182AC7760", Slot = "66")]
		public object FFDFJBDFOEC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC89D0", Offset = "0x2AC79D0", VA = "0x182AC89D0", Slot = "67")]
		public void KFOPGECHEIG(GPEJGMHBDPO GBPGPLEPLBP, object KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8170", Offset = "0x2AC7170", VA = "0x182AC8170", Slot = "68")]
		public object ICHHOINEMPN(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6430", Offset = "0x2AC5430", VA = "0x182AC6430", Slot = "69")]
		public void AALDAPDLJAO(GPEJGMHBDPO GBPGPLEPLBP, object KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC74C0", Offset = "0x2AC64C0", VA = "0x182AC74C0", Slot = "70")]
		public float EJEKBMDLIBA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC84F0", Offset = "0x2AC74F0", VA = "0x182AC84F0", Slot = "71")]
		public void JCFEOFGMADC(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC87C0", Offset = "0x2AC77C0", VA = "0x182AC87C0", Slot = "78")]
		public void JPFBIOHPAPP(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7330", Offset = "0x2AC6330", VA = "0x182AC7330", Slot = "79")]
		public void DKLIPDIJDHM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8B30", Offset = "0x2AC7B30", VA = "0x182AC8B30", Slot = "80")]
		public bool KGGLAGBBAOM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8420", Offset = "0x2AC7420", VA = "0x182AC8420", Slot = "24")]
		public void INILHHKBDKI(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8560", Offset = "0x2AC7560", VA = "0x182AC8560", Slot = "25")]
		public void JDFMDINMCNB(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x449AE80", Offset = "0x4499E80", VA = "0x18449AE80")]
		private void KNOFDGJEOGM<T>(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x449AE20", Offset = "0x4499E20", VA = "0x18449AE20")]
		private bool KHJDFFMKJOL<T>(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x34EEA20", Offset = "0x34EDA20", VA = "0x1834EEA20")]
		private void PMMODKPOELK<T>(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x449A630", Offset = "0x4499630", VA = "0x18449A630")]
		private bool AIJGPGGBGFG<TC, TV>(GPEJGMHBDPO GBPGPLEPLBP, Func<TC, TV> GBGEJGMHGKE, out TV KPPLMEOMNGF) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x34EE9A0", Offset = "0x34ED9A0", VA = "0x1834EE9A0")]
		private bool AIJGPGGBGFG<T>(GPEJGMHBDPO GBPGPLEPLBP, out T KPPLMEOMNGF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x449AED0", Offset = "0x4499ED0", VA = "0x18449AED0")]
		private T LEKEELENHIE<T>(GPEJGMHBDPO GBPGPLEPLBP) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x449A8D0", Offset = "0x44998D0", VA = "0x18449A8D0")]
		private void IKMPHAGPNKE<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x34EE290", Offset = "0x34ED290", VA = "0x1834EE290")]
		private void LKGJFMLBKJI<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x34EE9A0", Offset = "0x34ED9A0", VA = "0x1834EE9A0")]
		private bool DKLPDHEDJBI<T>(GPEJGMHBDPO GBPGPLEPLBP, out T KPPLMEOMNGF) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x449A7B0", Offset = "0x44997B0", VA = "0x18449A7B0")]
		private T FOAIHDEBEMM<T>(GPEJGMHBDPO GBPGPLEPLBP) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x34EE9A0", Offset = "0x34ED9A0", VA = "0x1834EE9A0")]
		private void MFJMMAHLBLJ<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x34EE8F0", Offset = "0x34ED8F0", VA = "0x1834EE8F0")]
		private void MBNIFFNJBGE<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC93A0", Offset = "0x2AC83A0", VA = "0x182AC93A0")]
		private GPEJGMHBDPO MLCHMPFJNGD(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6DC0", Offset = "0x2AC5DC0", VA = "0x182AC6DC0")]
		private DynamicBuffer<Entity> BLLJAKKJPOO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x449A810", Offset = "0x4499810", VA = "0x18449A810")]
		private void IJEKFILKHEO<T>(GPEJGMHBDPO GBPGPLEPLBP, object KPPLMEOMNGF, Func<object, T> GBGEJGMHGKE) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void MGAGAAKAIAK<T>(ref global::BLGJBPKCMHC<T> ABGEACDGIFN) where T : struct, LOINMAGCOGI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void MGAGAAKAIAK<TC, TV>(ref global::CMEECFLOIOG<TC, TV> ABGEACDGIFN) where TC : struct, LOINMAGCOGI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	[IABFONFHPFO(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class PKLNDKFKAED : IEnumerable<KLALODLBPPC>, IEnumerable, IEnumerator<KLALODLBPPC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private KLALODLBPPC <>2__current;

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
			private KLALODLBPPC System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public PKLNDKFKAED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4142F60", Offset = "0x4141F60", VA = "0x184142F60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x4142C20", Offset = "0x4141C20", VA = "0x184142C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x4142FE0", Offset = "0x4141FE0", VA = "0x184142FE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x4142F20", Offset = "0x4141F20", VA = "0x184142F20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4142E70", Offset = "0x4141E70", VA = "0x184142E70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KLALODLBPPC> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x4142E70", Offset = "0x4141E70", VA = "0x184142E70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> AEHFFIGFDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x30EE820", Offset = "0x30ED820", VA = "0x1830EE820", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x30EE700", Offset = "0x30ED700", VA = "0x1830EE700")]
		public void IHGGPOIHOJD(NativeArray<Entity> GMAMPIGCEAB, bool LNOMECDPGOO, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x30EF030", Offset = "0x30EE030", VA = "0x1830EF030")]
		public void OFICLPBCEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x30EE870", Offset = "0x30ED870", VA = "0x1830EE870")]
		private void MMCDAINHJOD(NativeArray<Entity> GMAMPIGCEAB, bool LNOMECDPGOO, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x30EE520", Offset = "0x30ED520", VA = "0x1830EE520")]
		[IteratorStateMachine(typeof(PKLNDKFKAED))]
		private IEnumerable<KLALODLBPPC> BNOBLHNNDHL(NativeArray<Entity> GMAMPIGCEAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x30EE5B0", Offset = "0x30ED5B0", VA = "0x1830EE5B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x30EF290", Offset = "0x30EE290", VA = "0x1830EF290")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[IABFONFHPFO(typeof(PABMDGDAPHJ), new string[] { })]
public class KHEBFHEMJLA : PABMDGDAPHJ, IEnumerable<GJOKNGAFGLP>, IEnumerable, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[JOODLPJEDOA]
	private ADFGLBDCGIJ ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> NJLKKONHKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private FENJJPCPFPB FCJJBPFOFMN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x30ECDB0", Offset = "0x30EBDB0", VA = "0x1830ECDB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GJOKNGAFGLP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x30EC7B0", Offset = "0x30EB7B0", VA = "0x1830EC7B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GJOKNGAFGLP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x30EC7B0", Offset = "0x30EB7B0", VA = "0x1830EC7B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x30EC7F0", Offset = "0x30EB7F0", VA = "0x1830EC7F0", Slot = "11")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x30EC920", Offset = "0x30EB920", VA = "0x1830EC920", Slot = "12")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x30EC9A0", Offset = "0x30EB9A0", VA = "0x1830EC9A0")]
	private void LDHGKFGDPIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2589710", Offset = "0x2588710", VA = "0x182589710")]
	private string EAIPEFGMMJF(string GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x30EC840", Offset = "0x30EB840", VA = "0x1830EC840", Slot = "7")]
	public GJOKNGAFGLP IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x30EC500", Offset = "0x30EB500", VA = "0x1830EC500")]
	private bool CBMGJGOPPBN(Type PMIFMNEAFNB, string GOENAEMJAON, out GJOKNGAFGLP LPPHHGKFEEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x30ECCA0", Offset = "0x30EBCA0", VA = "0x1830ECCA0", Slot = "8")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x30EC7D0", Offset = "0x30EB7D0", VA = "0x1830EC7D0", Slot = "9")]
	public IEnumerator<GJOKNGAFGLP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x30EC7D0", Offset = "0x30EB7D0", VA = "0x1830EC7D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x30ECDD0", Offset = "0x30EBDD0", VA = "0x1830ECDD0")]
	public KHEBFHEMJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[DefaultMember("Item")]
public interface EAIOBOKBFDP
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPAAOLEILLP(BPHAMHGLCNC CLOAPFCHKDE, out int MKMGHJFMNMB);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[IABFONFHPFO(typeof(EAIOBOKBFDP), new string[] { })]
public class LIGFBIGBFNN : MIBCENMOHFA, PFFHIJLFPMD, EAIOBOKBFDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[JOODLPJEDOA]
	private KNGDFJPFKAH ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<BPHAMHGLCNC, int> CDGHDDDCOGK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6960", Offset = "0x2AA5960", VA = "0x182AA6960", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA69D0", Offset = "0x2AA59D0", VA = "0x182AA69D0", Slot = "6")]
	public bool GPAAOLEILLP(BPHAMHGLCNC CLOAPFCHKDE, out int MKMGHJFMNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6A40", Offset = "0x2AA5A40", VA = "0x182AA6A40", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA69C0", Offset = "0x2AA59C0", VA = "0x182AA69C0", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6AA0", Offset = "0x2AA5AA0", VA = "0x182AA6AA0")]
	private void KKMHDFJKFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6D10", Offset = "0x2AA5D10", VA = "0x182AA6D10")]
	public LIGFBIGBFNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[IABFONFHPFO(typeof(KNGDFJPFKAH), new string[] { })]
[DefaultMember("Item")]
public class PJPHBCLBKGI : KNGDFJPFKAH, IEnumerable<AGAFPGKKJCP>, IEnumerable, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, PAOKNLKENHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[JOODLPJEDOA]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[JOODLPJEDOA]
	private PABMDGDAPHJ NKKIHHJKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private AGAFPGKKJCP[] OEEKBIDAMMA;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDD70", Offset = "0x2ABCD70", VA = "0x182ABDD70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public AGAFPGKKJCP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD670", Offset = "0x2ABC670", VA = "0x182ABD670", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public AGAFPGKKJCP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD670", Offset = "0x2ABC670", VA = "0x182ABD670", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "10")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2ABDA00", Offset = "0x2ABCA00", VA = "0x182ABDA00", Slot = "11")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "12")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD8D0", Offset = "0x2ABC8D0", VA = "0x182ABD8D0", Slot = "6")]
	public AGAFPGKKJCP IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABDCA0", Offset = "0x2ABCCA0", VA = "0x182ABDCA0", Slot = "7")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD7F0", Offset = "0x2ABC7F0", VA = "0x182ABD7F0", Slot = "8")]
	public IEnumerator<AGAFPGKKJCP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABDD80", Offset = "0x2ABCD80", VA = "0x182ABDD80", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3661900", Offset = "0x3660900", VA = "0x183661900", Slot = "13")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD6B0", Offset = "0x2ABC6B0", VA = "0x182ABD6B0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public PJPHBCLBKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD670", Offset = "0x2ABC670", VA = "0x182ABD670")]
	[CompilerGenerated]
	private AGAFPGKKJCP JADFJFIILID(int BDAADCOCKII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[IABFONFHPFO(typeof(FMGCEKBAGOP), new string[] { })]
public class KCAGAILGGCG : FMGCEKBAGOP, IEnumerable<MGJBDIBFMNC>, IEnumerable, MIBCENMOHFA, PFFHIJLFPMD, PAOKNLKENHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[JOODLPJEDOA]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[JOODLPJEDOA]
	private PABMDGDAPHJ NKKIHHJKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private MGJBDIBFMNC[] OEEKBIDAMMA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x30EAA00", Offset = "0x30E9A00", VA = "0x1830EAA00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MGJBDIBFMNC IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x30EA2A0", Offset = "0x30E92A0", VA = "0x1830EA2A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MGJBDIBFMNC IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x30EA2A0", Offset = "0x30E92A0", VA = "0x1830EA2A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x30EA8C0", Offset = "0x30E98C0", VA = "0x1830EA8C0", Slot = "9")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x30EA350", Offset = "0x30E9350", VA = "0x1830EA350", Slot = "10")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x30EA5B0", Offset = "0x30E95B0", VA = "0x1830EA5B0")]
	private MGJBDIBFMNC GFAMKPCIPGK(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x30EA7A0", Offset = "0x30E97A0", VA = "0x1830EA7A0", Slot = "6")]
	public MGJBDIBFMNC IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x30EA930", Offset = "0x30E9930", VA = "0x1830EA930", Slot = "14")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x30EA690", Offset = "0x30E9690", VA = "0x1830EA690", Slot = "7")]
	public IEnumerator<MGJBDIBFMNC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x30EA690", Offset = "0x30E9690", VA = "0x1830EA690", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x21D72F0", Offset = "0x21D62F0", VA = "0x1821D72F0", Slot = "11")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x30EA2B0", Offset = "0x30E92B0", VA = "0x1830EA2B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public KCAGAILGGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x30EA2A0", Offset = "0x30E92A0", VA = "0x1830EA2A0")]
	[CompilerGenerated]
	private MGJBDIBFMNC JADFJFIILID(int BDAADCOCKII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[IABFONFHPFO(typeof(ADFGLBDCGIJ), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
internal class ADFGLBDCGIJ : MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private PABMDGDAPHJ NKKIHHJKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private FMGCEKBAGOP NPGHHJGHLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private KNGDFJPFKAH CBONMIACFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::FOIBHJLLDAJ<GBOCHCBEADE> JFILCDKBAEE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public FENJJPCPFPB LJDIHHKGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EF80", Offset = "0x2D0DF80", VA = "0x182D0EF80", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EE90", Offset = "0x2D0DE90", VA = "0x182D0EE90")]
	private void IHPFHAJBBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1767790", Offset = "0x1766790", VA = "0x181767790")]
	public T AAOAHJEMNCJ<T>() where T : GBOCHCBEADE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F0B0", Offset = "0x2D0E0B0", VA = "0x182D0F0B0")]
	public GJOKNGAFGLP KMKDKCIDJAF(DLPKPOKLLDJ GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::HHLEGGEGCOD<T> KMKDKCIDJAF<T>(DLPKPOKLLDJ GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EDC0", Offset = "0x2D0DDC0", VA = "0x182D0EDC0")]
	public MGJBDIBFMNC HGJABPPMKIA(DLPKPOKLLDJ GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x17677C0", Offset = "0x17667C0", VA = "0x1817677C0")]
	public global::DIJBCAAPJBG<T> HGJABPPMKIA<T>(DLPKPOKLLDJ GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2D0ECF0", Offset = "0x2D0DCF0", VA = "0x182D0ECF0")]
	public AGAFPGKKJCP BEOPODEINJI(DLPKPOKLLDJ GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::PLOKGEGHGGL<T> BEOPODEINJI<T>(DLPKPOKLLDJ GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public ADFGLBDCGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class AKJNHIEIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x176C7C0", Offset = "0x176B7C0", VA = "0x18176C7C0")]
	public static global::HHLEGGEGCOD<T> KMKDKCIDJAF<T>(this ADFGLBDCGIJ FPDFBEPIKDA, global::CKGECMCPKDO<T> GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::DIJBCAAPJBG<T> HGJABPPMKIA<T>(this ADFGLBDCGIJ FPDFBEPIKDA, global::CKGECMCPKDO<T> GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::PLOKGEGHGGL<T> BEOPODEINJI<T>(this ADFGLBDCGIJ FPDFBEPIKDA, global::CKGECMCPKDO<T> GOENAEMJAON) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[IABFONFHPFO(typeof(DBJEICFIKOJ), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
public class DBJEICFIKOJ : MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private ODHBDONHIOF OKGDPALNOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private BPHAMHGLCNC[] CHEFEMHKKOH;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2D25E40", Offset = "0x2D24E40", VA = "0x182D25E40", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2D25D20", Offset = "0x2D24D20", VA = "0x182D25D20")]
	public void CMONGHJDGLF(IJDKBBDMEBI DGPLFECNDCD, bool MFNFGLHHIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public DBJEICFIKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[IABFONFHPFO(typeof(LCIBPAKKMLE), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
public sealed class LCIBPAKKMLE : MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class EMEFJIGINHJ : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
		[DebuggerHidden]
		public EMEFJIGINHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x413B5D0", Offset = "0x413A5D0", VA = "0x18413B5D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x413B220", Offset = "0x413A220", VA = "0x18413B220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x413B650", Offset = "0x413A650", VA = "0x18413B650")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x413B590", Offset = "0x413A590", VA = "0x18413B590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x413B500", Offset = "0x413A500", VA = "0x18413B500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x413B500", Offset = "0x413A500", VA = "0x18413B500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string CGCNBEGFIHC = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, KNLEFPMCGDO> EDPNAHNKKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> ODACKAICDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> APEJINPFNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private FMGCEKBAGOP ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private LCBBOCICDFN JGIJGKDIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JLCGKPAGLMB DCJBADMCBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::FMNGHOMPIJM<KNLEFPMCGDO> DFOINEAFOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject HDMJJHCJJAJ;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6480", Offset = "0x2AA5480", VA = "0x182AA6480", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5780", Offset = "0x2AA4780", VA = "0x182AA5780", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5400", Offset = "0x2AA4400", VA = "0x182AA5400", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA53F0", Offset = "0x2AA43F0", VA = "0x182AA53F0")]
	private void DKHHHBJFOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5CC0", Offset = "0x2AA4CC0", VA = "0x182AA5CC0")]
	internal void IEFCAOLALKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5AE0", Offset = "0x2AA4AE0", VA = "0x182AA5AE0")]
	private void HOLLIAOCKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2AA65A0", Offset = "0x2AA55A0", VA = "0x182AA65A0")]
	private void MNCMMOOGNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6550", Offset = "0x2AA5550", VA = "0x182AA6550")]
	[IteratorStateMachine(typeof(EMEFJIGINHJ))]
	private IEnumerable<RRCustomPropTag> KOALJDNAIEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4F70", Offset = "0x2AA3F70", VA = "0x182AA4F70")]
	private void CHJFAIPGPFE(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2AA59A0", Offset = "0x2AA49A0", VA = "0x182AA59A0")]
	private void GBHABPPKBJN(SerializableGuid DBODHDCBMLJ, GameObject BLPBCMIHDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2AA60F0", Offset = "0x2AA50F0", VA = "0x182AA60F0")]
	private void JDNPOKNLCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2AA55A0", Offset = "0x2AA45A0", VA = "0x182AA55A0")]
	private bool EPGKABFBDKL(KNLEFPMCGDO EELGGBLPOIL, Transform OKMBLMILFGG, out GameObject NMHCDAEEFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5950", Offset = "0x2AA4950", VA = "0x182AA5950")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2AA66A0", Offset = "0x2AA56A0", VA = "0x182AA66A0")]
	public LCIBPAKKMLE()
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
		public SerializableGuid OCGMAIELJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6340", Offset = "0x2AC5340", VA = "0x182AC6340")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[IABFONFHPFO(typeof(CBJJDLDBEIF), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
public class CBJJDLDBEIF : MIBCENMOHFA
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string DKPOKPNLJPD = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService KPCHKHEBGLC;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2D18750", Offset = "0x2D17750", VA = "0x182D18750", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public CBJJDLDBEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[IABFONFHPFO(typeof(CGLOPKPKFKG), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
public class CGLOPKPKFKG : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[JOODLPJEDOA]
	private EnableComponentSystemsInScope PPEBGPGNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[JOODLPJEDOA]
	private SceneService KPCHKHEBGLC;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2D19850", Offset = "0x2D18850", VA = "0x182D19850", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2D197E0", Offset = "0x2D187E0", VA = "0x182D197E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2D198C0", Offset = "0x2D188C0", VA = "0x182D198C0")]
	private void MBBOHHGLIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2D19820", Offset = "0x2D18820", VA = "0x182D19820")]
	private void EDAAICNBGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public CGLOPKPKFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[IABFONFHPFO(typeof(EHCGNDKDHFM), new string[] { })]
public class LKALLMGLJBB : MIBCENMOHFA, PFFHIJLFPMD, EHCGNDKDHFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private CGDDJBMDAKP EBGBIKNFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private NIAFMBFAFPH OGNLPKJPJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService FOOIHPIJMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem FDLLANOLCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int ICOCIGAPOEG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool AMBDDFHIMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A00", Offset = "0x2AA6A00", VA = "0x182AA7A00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GPEJGMHBDPO EJMHGHICPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA71C0", Offset = "0x2AA61C0", VA = "0x182AA71C0", Slot = "9")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7DC0", Offset = "0x2AA6DC0", VA = "0x182AA7DC0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CDFLNPBCBAA MOPPCBEDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7D00", Offset = "0x2AA6D00", VA = "0x182AA7D00", Slot = "11")]
		get
		{
			return default(CDFLNPBCBAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7DC0", Offset = "0x2AA6DC0", VA = "0x182AA7DC0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CDFLNPBCBAA AELCMLEDMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7F90", Offset = "0x2AA6F90", VA = "0x182AA7F90", Slot = "13")]
		get
		{
			return default(CDFLNPBCBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint GHJNABOINON
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7280", Offset = "0x2AA6280", VA = "0x182AA7280")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NEHADPJGDHC NMNMMBPECAK
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7120", Offset = "0x2AA6120", VA = "0x182AA7120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7DE0", Offset = "0x2AA6DE0", VA = "0x182AA7DE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7C30", Offset = "0x2AA6C30", VA = "0x182AA7C30", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2AA76D0", Offset = "0x2AA66D0", VA = "0x182AA76D0", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7620", Offset = "0x2AA6620", VA = "0x182AA7620", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8050", Offset = "0x2AA7050", VA = "0x182AA8050")]
	private void PMMOCKFCAEA(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E80", Offset = "0x2AA6E80", VA = "0x182AA7E80", Slot = "14")]
	public GPEJGMHBDPO OLCENLILHJP(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7330", Offset = "0x2AA6330", VA = "0x182AA7330", Slot = "15")]
	public bool DBLIAABGAHD(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO, out GPEJGMHBDPO HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7AA0", Offset = "0x2AA6AA0", VA = "0x182AA7AA0", Slot = "16")]
	public void ILCEMCLBPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7260", Offset = "0x2AA6260", VA = "0x182AA7260", Slot = "17")]
	public void APCOHHNFOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7430", Offset = "0x2AA6430", VA = "0x182AA7430", Slot = "18")]
	public bool DMNDLLJKJKD(GPEJGMHBDPO NMAMPMADCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7870", Offset = "0x2AA6870", VA = "0x182AA7870")]
	private void IDAACAFLGLI(GPEJGMHBDPO GNGEBABNPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LKALLMGLJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[IABFONFHPFO(typeof(HBMNANFILGC), new string[] { })]
public class HGFMIAJLFBH : MIBCENMOHFA, HBMNANFILGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x30E1BB0", Offset = "0x30E0BB0", VA = "0x1830E1BB0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x30E1B40", Offset = "0x30E0B40", VA = "0x1830E1B40", Slot = "5")]
	public void JANFKDNKIJO(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2330410", Offset = "0x232F410", VA = "0x182330410")]
	private void JPNFGACMGOG<T>(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HGFMIAJLFBH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[IABFONFHPFO(typeof(BIEHHNEIICJ), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.RenderEffects)]
	public class SelectionService : MIBCENMOHFA, BIEHHNEIICJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B2A0", Offset = "0x2C8A2A0", VA = "0x182C8B2A0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B230", Offset = "0x2C8A230", VA = "0x182C8B230", Slot = "5")]
		public void BMOHKAOODHK(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B320", Offset = "0x2C8A320", VA = "0x182C8B320", Slot = "6")]
		public void NPFGMIKLPAP(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2330410", Offset = "0x232F410", VA = "0x182330410")]
		private void JPNFGACMGOG<T>(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
[IABFONFHPFO(typeof(MNCGEMIOHKK), new string[] { })]
internal sealed class MNCGEMIOHKK : MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[JOODLPJEDOA]
	private ObjectEmbodimentService AIJDONAKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG DOFDFFCHKPB;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB3C0", Offset = "0x2AAA3C0", VA = "0x182AAB3C0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public MNCGEMIOHKK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	[IABFONFHPFO(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : MIBCENMOHFA, OAOFKKDMKNC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly JHCDFELAIDH HIBAFJNAMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[JOODLPJEDOA]
		private PJCCMDKJKFG CMEPKDAKLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[JOODLPJEDOA]
		private SerializationService JGIJGKDIPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[JOODLPJEDOA]
		private AGABOCBEEBB GLKGCBOKLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[JOODLPJEDOA]
		private DebugWorldsService LLLBBHEEGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[JOODLPJEDOA]
		private BulkInstantiateSceneObjectService CBNLJABNELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private FEPIHHOJCOJ HPFBGIEBCLA;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private FNDMDJJGFHH FDBKDEBJKKE
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xC35E50", Offset = "0xC34E50", VA = "0x180C35E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FDE0", Offset = "0x2C9EDE0", VA = "0x182C9FDE0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ NOOBBCKAGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F3C0", Offset = "0x2C9E3C0", VA = "0x182C9F3C0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F7F0", Offset = "0x2C9E7F0", VA = "0x182C9F7F0", Slot = "6")]
		public bool HGCEOMJIBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0410", Offset = "0x2C9F410", VA = "0x182CA0410", Slot = "7")]
		public bool MLAHAICGOPD(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F950", Offset = "0x2C9E950", VA = "0x182C9F950", Slot = "5")]
		public ByteString IDGEKAFJKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F300", Offset = "0x2C9E300", VA = "0x182C9F300")]
		private void AHIDBLHDIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F3F0", Offset = "0x2C9E3F0", VA = "0x182C9F3F0")]
		private void GKLEIOJOBBM(KDFLMOJDNAH OIAFFOAGAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FF30", Offset = "0x2C9EF30", VA = "0x182C9FF30")]
		private void MKJBPNKKHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F510", Offset = "0x2C9E510", VA = "0x182C9F510")]
		private void HBKDLOBFCFI(CONHDBOPGAO OIAFFOAGAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F4C0", Offset = "0x2C9E4C0", VA = "0x182C9F4C0", Slot = "8")]
		public void HBECBLLPJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F320", Offset = "0x2C9E320", VA = "0x182C9F320")]
		private KDFLMOJDNAH AHPBEKCMKPJ(EntityManager ABFDLFMHAJL, EntityManager LKAGEFPMCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[IABFONFHPFO(typeof(HLLCJHEPJPB), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
public class HLLCJHEPJPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<MCLBIBPLLEA, string> IPEMAMFLJJH;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x30E1EF0", Offset = "0x30E0EF0", VA = "0x1830E1EF0")]
	public GameObject GIEPJEOMMKO(MCLBIBPLLEA CLFHKFOADIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x30E1FC0", Offset = "0x30E0FC0", VA = "0x1830E1FC0")]
	public HLLCJHEPJPB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(TimeService), new string[] { })]
	public class TimeService : JMMCIOGFDJD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[JOODLPJEDOA]
		private SingletonComponentService GIDMMDNBHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool OIBLAAJGOOF;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData OKADPEMLCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2C92CD0", Offset = "0x2C91CD0", VA = "0x182C92CD0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2C92B40", Offset = "0x2C91B40", VA = "0x182C92B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool LDCFIBOIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x71B000", Offset = "0x71A000", VA = "0x18071B000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x245F3D0", Offset = "0x245E3D0", VA = "0x18245F3D0", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2C92C80", Offset = "0x2C91C80", VA = "0x182C92C80", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2C92BC0", Offset = "0x2C91BC0", VA = "0x182C92BC0")]
		public void IDBFLDBCCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	[IABFONFHPFO(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private EOBKLCMHAME GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::HHLEGGEGCOD<Entity> OKMBLMILFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService EMDCODCKMDO;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EE90", Offset = "0x2C8DE90", VA = "0x182C8EE90", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ED60", Offset = "0x2C8DD60", VA = "0x182C8ED60", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ECC0", Offset = "0x2C8DCC0", VA = "0x182C8ECC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EF00", Offset = "0x2C8DF00", VA = "0x182C8EF00")]
		private void POIDDGAPPAI(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[OHGELDJCNJM(GGAOONGBEBH.Services)]
	[IABFONFHPFO(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[JOODLPJEDOA]
		private LLEOCPFGDHE IGPDCEGDODH;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private DCBPIOFBCON MBJLEFDCMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x30D4760", Offset = "0x30D3760", VA = "0x1830D4760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private MGKDLMNJGLC KEPENBEICJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x30D4690", Offset = "0x30D3690", VA = "0x1830D4690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x30D46E0", Offset = "0x30D36E0", VA = "0x1830D46E0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x30D4670", Offset = "0x30D3670", VA = "0x1830D4670", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[IABFONFHPFO(typeof(FPLAKKEPGBK), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
public class FPLAKKEPGBK : BDIPMKLAHKL, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class EDLFHEBOAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FEPIHHOJCOJ services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EDLFHEBOAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x413ADF0", Offset = "0x4139DF0", VA = "0x18413ADF0")]
		internal void <InitReferences>b__0(MIBCENMOHFA svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class BPDPCGLKBBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public FEPIHHOJCOJ services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BPDPCGLKBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x41395B0", Offset = "0x41385B0", VA = "0x1841395B0")]
		internal void <InitExternal>b__0(PFFHIJLFPMD svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG DOFDFFCHKPB;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public PIEGKGHOKCE JBBLCINBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x94C020", Offset = "0x94B020", VA = "0x18094C020", Slot = "4")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NPAPPEKNDDD BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x30DE070", Offset = "0x30DD070", VA = "0x1830DE070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x30DE020", Offset = "0x30DD020", VA = "0x1830DE020", Slot = "5")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x30DE0C0", Offset = "0x30DD0C0", VA = "0x1830DE0C0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x30DE1F0", Offset = "0x30DD1F0", VA = "0x1830DE1F0", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x30DDF40", Offset = "0x30DCF40", VA = "0x1830DDF40", Slot = "8")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x30DDE10", Offset = "0x30DCE10", VA = "0x1830DDE10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2359A50", Offset = "0x2358A50", VA = "0x182359A50")]
	private void ABFIAEOBJJK<T>(Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FPLAKKEPGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class BBJCFGPBJNP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> IICCJFLIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> BFNDINBALAB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To IHLOOLPGFPM
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
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public BBJCFGPBJNP(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
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
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
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
public class EGHLJOHKCPL<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> IICCJFLIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E12F10", Offset = "0x2E11F10", VA = "0x182E12F10", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E12F70", Offset = "0x2E11F70", VA = "0x182E12F70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2E12EE0", Offset = "0x2E11EE0", VA = "0x182E12EE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x299F4B0", Offset = "0x299E4B0", VA = "0x18299F4B0")]
	public EGHLJOHKCPL(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF, bool BHCHPGOJODJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E12B00", Offset = "0x2E11B00", VA = "0x182E12B00", Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E12B60", Offset = "0x2E11B60", VA = "0x182E12B60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E12B90", Offset = "0x2E11B90", VA = "0x182E12B90", Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E12BF0", Offset = "0x2E11BF0", VA = "0x182E12BF0", Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E12D00", Offset = "0x2E11D00", VA = "0x182E12D00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E12D70", Offset = "0x2E11D70", VA = "0x182E12D70", Slot = "6")]
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E12DD0", Offset = "0x2E11DD0", VA = "0x182E12DD0", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E12E80", Offset = "0x2E11E80", VA = "0x182E12E80", Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E12E50", Offset = "0x2E11E50", VA = "0x182E12E50", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2524D30", Offset = "0x2523D30", VA = "0x182524D30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class KJJDOFLKDCI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> IICCJFLIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> EGIDMCNFHCK;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B56CC0", Offset = "0x2B55CC0", VA = "0x182B56CC0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B56D10", Offset = "0x2B55D10", VA = "0x182B56D10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C80", Offset = "0x2B55C80", VA = "0x182B56C80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2708F80", Offset = "0x2707F80", VA = "0x182708F80")]
	public KJJDOFLKDCI(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B56860", Offset = "0x2B55860", VA = "0x182B56860", Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B568A0", Offset = "0x2B558A0", VA = "0x182B568A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B568E0", Offset = "0x2B558E0", VA = "0x182B568E0", Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B569A0", Offset = "0x2B559A0", VA = "0x182B569A0", Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B56A60", Offset = "0x2B55A60", VA = "0x182B56A60", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B56B20", Offset = "0x2B55B20", VA = "0x182B56B20", Slot = "6")]
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B56B90", Offset = "0x2B55B90", VA = "0x182B56B90", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B56C10", Offset = "0x2B55C10", VA = "0x182B56C10", Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B56BD0", Offset = "0x2B55BD0", VA = "0x182B56BD0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B56C50", Offset = "0x2B55C50", VA = "0x182B56C50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class NEKOENOIJPC<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> DKEBKHECPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> IICCJFLIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To IHLOOLPGFPM
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
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public NEKOENOIJPC(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
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
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
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
public static class GDNCNLECMEN
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string HPCHEMOPDHA = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string ENNFCMBFEHL = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string KDLMFLNGGNG = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string FEPMFDLKINF = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string IGANKOBKONB = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string KOHIAODJAHA = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string MBBOOAGGHJE = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string AGBIBDLIKAE = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class HGLNCKDJPGE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class NGFCJPHMDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FEPIHHOJCOJ services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NGFCJPHMDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4141490", Offset = "0x4140490", VA = "0x184141490")]
		internal void <InitServices>b__1(MIBCENMOHFA svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x41414F0", Offset = "0x41404F0", VA = "0x1841414F0")]
		internal void <InitServices>b__2(PFFHIJLFPMD svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x30E1C30", Offset = "0x30E0C30", VA = "0x1830E1C30")]
	public static void LBLKFPNACLN(this NPAPPEKNDDD BKFHGKOCNCC, FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2330480", Offset = "0x232F480", VA = "0x182330480")]
	public static void ABFIAEOBJJK<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x23309C0", Offset = "0x232F9C0", VA = "0x1823309C0")]
	public static void HIIBCEBNIGH<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2330C20", Offset = "0x232FC20", VA = "0x182330C20")]
	public static void NLIBGFMKGNO<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x23306A0", Offset = "0x232F6A0", VA = "0x1823306A0")]
	public static void HGDNHAGBKNJ<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x23304F0", Offset = "0x232F4F0", VA = "0x1823304F0")]
	public static void EOAAICFCIPM<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x2330850", Offset = "0x232F850", VA = "0x182330850")]
	public static void HIIBCEBNIGH<T>(IEnumerable<ComponentSystemBase> FGEEBMNILFP, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2330B60", Offset = "0x232FB60", VA = "0x182330B60")]
	private static void LFFMDDMHKNL<T>(object NGCKCOHKMBE, Action<T> PIJHAFCEHLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class LNIOCJABDGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LEAGBOMOJHK
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA67A0", Offset = "0x2AA57A0", VA = "0x182AA67A0")]
	public static void BKHMOMMAKNJ(ComponentSystemBase NGCKCOHKMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class MHHAEEGJFEB
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool HGJBBDHLFGJ<T>(ref T BECDKHGLGNB, ref T ICPOAGANOLH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PHNIBKGBCDJ
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DDLIKBJKCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DDLIKBJKCOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD5A0", Offset = "0x2ABC5A0", VA = "0x182ABD5A0")]
	public static string OAMNHGMAINF(Transform PKIKNDCFAFJ, Transform NMAMPMADCBK)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[OHGELDJCNJM(GGAOONGBEBH.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DEB0", Offset = "0x2C8CEB0", VA = "0x182C8DEB0")]
		public static void LDHMAOMPMOJ(this EHPGCEGHLNO HPFBGIEBCLA, DGHHMLJKDPD HGNBPKPAAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DC50", Offset = "0x2C8CC50", VA = "0x182C8DC50")]
		public static void BMOAPIFINMA(this EHPGCEGHLNO HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E0E0", Offset = "0x2C8D0E0", VA = "0x182C8E0E0")]
		public static void LDHMAOMPMOJ(this EHPGCEGHLNO HPFBGIEBCLA, [Optional] string[] MCDHAAGLAGD, [Optional] string[] OLODNCAENMJ, [Optional] string[] CNAHBAPFKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DD50", Offset = "0x2C8CD50", VA = "0x182C8DD50")]
		public static void CGIPIPBKEJN(this EHPGCEGHLNO HPFBGIEBCLA, params string[] BLGBFHLBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DE00", Offset = "0x2C8CE00", VA = "0x182C8DE00")]
		public static void KAMILGFPOHK(this EHPGCEGHLNO HPFBGIEBCLA, params string[] BLGBFHLBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E1F0", Offset = "0x2C8D1F0", VA = "0x182C8E1F0")]
		private static string[] LKOBGLNBAEI(DGHHMLJKDPD HGNBPKPAAFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DA90", Offset = "0x2C8CA90", VA = "0x182C8DA90")]
		private static bool BAFLKMOGAPA(DGHHMLJKDPD HGNBPKPAAFI, out string[] PGMGILACNBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00")]
		private static bool ALBKPMPDACL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class EOBELOOOIIG : NMBIFHBMHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo MMPMPCGHMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] KCPODLJODHA;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D164D0", Offset = "0x2D154D0", VA = "0x182D164D0")]
	public EOBELOOOIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BCDKGFIJJDD();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C580", Offset = "0x2D2B580", VA = "0x182D2C580")]
	public MethodInfo NBKKHLNFPLA(Action FFBLFKDINEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C3D0", Offset = "0x2D2B3D0", VA = "0x182D2C3D0", Slot = "4")]
	public void GBHABPPKBJN(Type HAOFNDAEGFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class OJPFDPPCFDF : EOBELOOOIIG
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum BLPMLDECPCD
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF080", Offset = "0x2AAE080", VA = "0x182AAF080", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BENMIKCNMJG<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF110", Offset = "0x2AAE110", VA = "0x182AAF110")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9250", Offset = "0x2AA8250", VA = "0x182AA9250")]
	protected OJPFDPPCFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class BOOCJNPMKNA : EOBELOOOIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2D163B0", Offset = "0x2D153B0", VA = "0x182D163B0", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LPHEFIDJEDE<T>() where T : KHHHMANHCMP;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2D16440", Offset = "0x2D15440", VA = "0x182D16440")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2D164D0", Offset = "0x2D154D0", VA = "0x182D164D0")]
	protected BOOCJNPMKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class MCELHJMBBCH : EOBELOOOIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9130", Offset = "0x2AA8130", VA = "0x182AA9130", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IGJJAOCCECA<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2AA91C0", Offset = "0x2AA81C0", VA = "0x182AA91C0")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9250", Offset = "0x2AA8250", VA = "0x182AA9250")]
	protected MCELHJMBBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class LNJAILBBBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2AA84A0", Offset = "0x2AA74A0", VA = "0x182AA84A0")]
	public static Entity CGOHCEDLGLP(this EntityManager JGDEKKJFKAJ)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class BLCIGMFMKOJ : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2386B20", Offset = "0x2385B20", VA = "0x182386B20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4139470", Offset = "0x4138470", VA = "0x184139470", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x41394C0", Offset = "0x41384C0", VA = "0x1841394C0")]
			[DebuggerHidden]
			public BLCIGMFMKOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x41392A0", Offset = "0x41382A0", VA = "0x1841392A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x4139430", Offset = "0x4138430", VA = "0x184139430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x4139380", Offset = "0x4138380", VA = "0x184139380", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x4139380", Offset = "0x4138380", VA = "0x184139380", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class GILMEBKPOOD : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2386B20", Offset = "0x2385B20", VA = "0x182386B20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x413C4A0", Offset = "0x413B4A0", VA = "0x18413C4A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x41394C0", Offset = "0x41384C0", VA = "0x1841394C0")]
			[DebuggerHidden]
			public GILMEBKPOOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x413C4F0", Offset = "0x413B4F0", VA = "0x18413C4F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x413C1C0", Offset = "0x413B1C0", VA = "0x18413C1C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x413C580", Offset = "0x413B580", VA = "0x18413C580")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x413C460", Offset = "0x413B460", VA = "0x18413C460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x413C3B0", Offset = "0x413B3B0", VA = "0x18413C3B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x413C3B0", Offset = "0x413B3B0", VA = "0x18413C3B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class MLHKJDGHBAB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x2386B20", Offset = "0x2385B20", VA = "0x182386B20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4141000", Offset = "0x4140000", VA = "0x184141000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x41394C0", Offset = "0x41384C0", VA = "0x1841394C0")]
			[DebuggerHidden]
			public MLHKJDGHBAB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x4141050", Offset = "0x4140050", VA = "0x184141050", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x4140BF0", Offset = "0x413FBF0", VA = "0x184140BF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x4141120", Offset = "0x4140120", VA = "0x184141120")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x4141170", Offset = "0x4140170", VA = "0x184141170")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x4140FC0", Offset = "0x413FFC0", VA = "0x184140FC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x4140F20", Offset = "0x413FF20", VA = "0x184140F20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x4140F20", Offset = "0x413FF20", VA = "0x184140F20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x30D7B90", Offset = "0x30D6B90", VA = "0x1830D7B90")]
		public static Entity JBLCGLJHIOG(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x30D77A0", Offset = "0x30D67A0", VA = "0x1830D77A0")]
		public static DynamicBuffer<ChildrenData> FCHBCBICGMH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x30D7D30", Offset = "0x30D6D30", VA = "0x1830D7D30")]
		public static DynamicBuffer<ChildrenData> JKEFMKGAFNC(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x30D7C00", Offset = "0x30D6C00", VA = "0x1830D7C00")]
		public static NativeArray<Entity> JCFAOEENOOF(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x30D7A90", Offset = "0x30D6A90", VA = "0x1830D7A90")]
		public static bool HMDLBGPCNIP(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Allocator GOLNHBOGNGC, out NativeArray<Entity> HPJAEDPBFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x30D6AD0", Offset = "0x30D5AD0", VA = "0x1830D6AD0")]
		public static NativeArray<Entity> AAPKPAPPKJH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x30D7670", Offset = "0x30D6670", VA = "0x1830D7670")]
		public static Entity ELIAHCIMIEO(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x30D7F40", Offset = "0x30D6F40", VA = "0x1830D7F40")]
		public static int KIPGBJMICGF(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x30D7410", Offset = "0x30D6410", VA = "0x1830D7410")]
		public static void DNGOJPJPEBP(NativeArray<Entity> OCFBEMCGNEI, NativeArray<Entity> DJHPOGLHKJI, EntityManager JGDEKKJFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x30D7080", Offset = "0x30D6080", VA = "0x1830D7080")]
		public static int CJNFLMDPHGO(this EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x30D8170", Offset = "0x30D7170", VA = "0x1830D8170")]
		public static bool PFJDPANHIDM(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x30D82D0", Offset = "0x30D72D0", VA = "0x1830D82D0")]
		public static IEnumerable<Entity> PKDPPNNMDAK(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x30D6DC0", Offset = "0x30D5DC0", VA = "0x1830D6DC0")]
		public static bool CCMBIGLHNMK(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity BOGHNKLNLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x30D6C30", Offset = "0x30D5C30", VA = "0x1830D6C30")]
		public static bool BEPDKIFHAFJ(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity PDOBLLBCDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x30D6E70", Offset = "0x30D5E70", VA = "0x1830D6E70")]
		public static NativeList<Entity> CHFELALAAIJ(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false, Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x30D7DC0", Offset = "0x30D6DC0", VA = "0x1830D7DC0")]
		public static IEnumerable<Entity> JNFNFOAALOH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x30D83E0", Offset = "0x30D73E0", VA = "0x1830D83E0")]
		public static Entity PLFCFKIEBOC(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x30D71B0", Offset = "0x30D61B0", VA = "0x1830D71B0")]
		public static bool DBLIAABGAHD(this EntityManager JGDEKKJFKAJ, Entity PDOBLLBCDKJ, Entity FENFFOFPKDO, out Entity HGNJLFHFDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x30D7910", Offset = "0x30D6910", VA = "0x1830D7910")]
		internal static void FLIFJBCJMOD(EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x30D7990", Offset = "0x30D6990", VA = "0x1830D7990")]
		internal static void GLCMELCNEDN(EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x30D80E0", Offset = "0x30D70E0", VA = "0x1830D80E0")]
		[IteratorStateMachine(typeof(BLCIGMFMKOJ))]
		private static IEnumerable<Entity> ODOEDOCNMDI(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x30D8050", Offset = "0x30D7050", VA = "0x1830D8050")]
		[IteratorStateMachine(typeof(GILMEBKPOOD))]
		private static IEnumerable<Entity> NNDFBOJHPDM(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x30D7130", Offset = "0x30D6130", VA = "0x1830D7130")]
		[IteratorStateMachine(typeof(MLHKJDGHBAB))]
		private static IEnumerable<Entity> CLJLPKANAFH(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x30D7830", Offset = "0x30D6830", VA = "0x1830D7830")]
		private static bool FKOGCDMIMOG(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[IABFONFHPFO(typeof(MNJAFLLCGLD), new string[] { })]
public class KDNNOFOGCEI : MNJAFLLCGLD, BDIPMKLAHKL, HAOCLMFADNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private FEPIHHOJCOJ HPFBGIEBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private PJCCMDKJKFG CMEPKDAKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private PLHAEEKILKB ALNGLBHBEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private CGDDJBMDAKP EBGBIKNFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private EOBKLCMHAME GAICKEELBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private EPLLJMMPLGC JGIJGKDIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private OHFKOIDMPOO ABFECNENKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private FMGCEKBAGOP ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private DMNNGJLJJJC HIDDBEEPIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private AIIFBLBGOBI MGBFHBJOHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private EHCGNDKDHFM AKMHDEFEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private NNPPGMKPBPK MBIMJJEJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private AHELNIAPJDN OPKNAKKAGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private HBMNANFILGC PPCKCAIAOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private BIEHHNEIICJ CPCJGBILAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private BJNLEMECNFA AGBEKOFDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private MJBFDNAELPM NGJMIGNGFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private OLGPCPINIDC LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public FEPIHHOJCOJ LOLLNGHJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public KHCCBBJDMKM JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public EEPEPNPEOFG BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PJCCMDKJKFG EPDHPONELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public PLHAEEKILKB JFDMKHENBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public FOBNDAGEMLO FPIICNIIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public CGDDJBMDAKP AKFBLEDGEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EOBKLCMHAME OMHHCDEFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public EPLLJMMPLGC JJCHHCLNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6F5760", Offset = "0x6F4760", VA = "0x1806F5760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OHFKOIDMPOO FPIIOFIPILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0B0", Offset = "0x6DE0B0", VA = "0x1806DF0B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public FMGCEKBAGOP DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DMNNGJLJJJC IEMKBGEBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AIIFBLBGOBI FJMJMIJBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6F5700", Offset = "0x6F4700", VA = "0x1806F5700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public EHCGNDKDHFM FAMBGOHJMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5710", Offset = "0x6F4710", VA = "0x1806F5710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NNPPGMKPBPK NMOFOMIKKED
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x71B6D0", Offset = "0x71A6D0", VA = "0x18071B6D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public AHELNIAPJDN MOCOCKENKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D80", Offset = "0x6E4D80", VA = "0x1806E5D80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HBMNANFILGC NOKBBCNBEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E20", Offset = "0x6E4E20", VA = "0x1806E5E20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BIEHHNEIICJ PAGKBNBNKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A0", Offset = "0x71A6A0", VA = "0x18071B6A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BJNLEMECNFA EOJIPMNJOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5720", Offset = "0x6F4720", VA = "0x1806F5720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MJBFDNAELPM JILOHMEMMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6F5730", Offset = "0x6F4730", VA = "0x1806F5730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public OLGPCPINIDC INDLFDCDHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6F5750", Offset = "0x6F4750", VA = "0x1806F5750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public PIEGKGHOKCE JBBLCINBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x705AA0", Offset = "0x704AA0", VA = "0x180705AA0", Slot = "21")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x30EBC90", Offset = "0x30EAC90", VA = "0x1830EBC90", Slot = "22")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ NOOBBCKAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1DE2720", Offset = "0x1DE1720", VA = "0x181DE2720", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x30EBF80", Offset = "0x30EAF80", VA = "0x1830EBF80", Slot = "23")]
	public void NMNMMBPECAK(FEPIHHOJCOJ NOOBBCKAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public KDNNOFOGCEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class FPHDAPPLMBA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EDEOFJKHDMG : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public FPHDAPPLMBA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x413ADA0", Offset = "0x4139DA0", VA = "0x18413ADA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public EDEOFJKHDMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x413ABF0", Offset = "0x4139BF0", VA = "0x18413ABF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x413AD60", Offset = "0x4139D60", VA = "0x18413AD60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong BHLKCGGJEJK = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong EJABALPCJCA = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int OJFBDAPANKM = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int KOMFDNFEGJJ = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int MBPPAODMCAL = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int NDFNMJLHPHG = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> BBMIPEDKIHJ;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x783430", Offset = "0x782430", VA = "0x180783430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int HEMFIMDKICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC90", Offset = "0x6F9C90", VA = "0x1806FAC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782340", VA = "0x180783340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x30DBD50", Offset = "0x30DAD50", VA = "0x1830DBD50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x30DBE80", Offset = "0x30DAE80", VA = "0x1830DBE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x30DCC20", Offset = "0x30DBC20", VA = "0x1830DCC20")]
	public FPHDAPPLMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x30DCAE0", Offset = "0x30DBAE0", VA = "0x1830DCAE0")]
	public FPHDAPPLMBA(int OECMPIPLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x30DC760", Offset = "0x30DB760", VA = "0x1830DC760")]
	public bool KGNHPEHADKP(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x30DC840", Offset = "0x30DB840", VA = "0x1830DC840")]
	public bool MILBJPHEDCF(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x30DBDF0", Offset = "0x30DADF0", VA = "0x1830DBDF0")]
	public bool EGHJJKFFGDL(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x30DBE70", Offset = "0x30DAE70", VA = "0x1830DBE70")]
	public bool EMBOEJCGPBA(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x30DC5E0", Offset = "0x30DB5E0", VA = "0x1830DC5E0")]
	public void JHNODPHEAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x30DC4F0", Offset = "0x30DB4F0", VA = "0x1830DC4F0")]
	public void HIANJBIKEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x30DC670", Offset = "0x30DB670", VA = "0x1830DC670")]
	public void JPNFGACMGOG(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x30DC030", Offset = "0x30DB030", VA = "0x1830DC030")]
	public void FPEOCMBDEPF(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x30DC930", Offset = "0x30DB930", VA = "0x1830DC930")]
	public bool OLMDFONJDCE(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x30DC9C0", Offset = "0x30DB9C0", VA = "0x1830DC9C0")]
	public void OOBAJEHGDJF(int LKCJJEBACFP, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x30DC330", Offset = "0x30DB330", VA = "0x1830DC330")]
	public void HAPIIJDFKIK(int MHOBHCMCJBM, int HFNHDBFKNLC, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x30DC180", Offset = "0x30DB180", VA = "0x1830DC180")]
	public int GBJBCHALJOG(int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x30DC250", Offset = "0x30DB250", VA = "0x1830DC250")]
	public int GBJBCHALJOG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x30DC130", Offset = "0x30DB130", VA = "0x1830DC130")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x30DC2C0", Offset = "0x30DB2C0", VA = "0x1830DC2C0", Slot = "4")]
	[IteratorStateMachine(typeof(EDEOFJKHDMG))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x30DC2C0", Offset = "0x30DB2C0", VA = "0x1830DC2C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class EIODOCPCLNH<T> : global::HGLMBFKILIE<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::DFPNLGKLLNI<T> OFGEDPJNLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::NIMGDENJGPM<T> HMEPNCLLPDD;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x1116660", Offset = "0x1115660", VA = "0x181116660")]
	public EIODOCPCLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x2018D20", Offset = "0x2017D20", VA = "0x182018D20")]
	public EIODOCPCLNH(global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x20189E0", Offset = "0x20179E0", VA = "0x1820189E0", Slot = "11")]
	public override T EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x20186D0", Offset = "0x20176D0", VA = "0x1820186D0", Slot = "12")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, T KPPLMEOMNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class MIJIICGHBAK
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x223D250", Offset = "0x223C250", VA = "0x18223D250")]
	public static BPHAMHGLCNC GBHABPPKBJN<T>(this DHPMLHOBOOK ICBILMELIDM, global::CKGECMCPKDO<T> GOENAEMJAON, global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD) where T : struct
	{
		return default(BPHAMHGLCNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class LGEJMOFIIHK<T> : global::EIODOCPCLNH<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x25F7C20", Offset = "0x25F6C20", VA = "0x1825F7C20")]
	public LGEJMOFIIHK(T EKDCKLAKFJN, T IBFPNBPAEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class AJHEAFJCDGO<T> : global::HGLMBFKILIE<T> where T : struct, KHHHMANHCMP
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x24E8780", Offset = "0x24E7780", VA = "0x1824E8780", Slot = "11")]
	public override T EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x24E8660", Offset = "0x24E7660", VA = "0x1824E8660", Slot = "12")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1ABA160", Offset = "0x1AB9160", VA = "0x181ABA160")]
	public AJHEAFJCDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class DNALLNHHNHE : JGIBKOJOACC
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type PONCNEBBHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA, in GHPDGIAHCBK KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, in MPOLKMCKMLM KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LPKKHPLBIJM(IDNDLGCBDKF AKJDPBEAJPA, GMGJEMLNHGE NIICHBPFANE, [Optional] object MFEOJPNCOBA);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	protected DNALLNHHNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class HGLMBFKILIE<T> : DNALLNHHNHE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type PONCNEBBHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2C6F2A0", Offset = "0x2C6E2A0", VA = "0x182C6F2A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, T KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FF90", Offset = "0x2C6EF90", VA = "0x182C6FF90", Slot = "8")]
	public override void EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA, in GHPDGIAHCBK NMAMPMADCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E820", Offset = "0x2C6D820", VA = "0x182C6E820", Slot = "9")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, in MPOLKMCKMLM EHNCKNECPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2C705E0", Offset = "0x2C6F5E0", VA = "0x182C705E0", Slot = "10")]
	public override void LPKKHPLBIJM(IDNDLGCBDKF AKJDPBEAJPA, GMGJEMLNHGE NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540")]
	protected HGLMBFKILIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class FAJHFAOCIKJ
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class INEKCADALPA
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class JAIIPFPDEOJ<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
			public JAIIPFPDEOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CCA0", Offset = "0x2B3BCA0", VA = "0x182B3CCA0")]
			internal void <RegisterFixedString>b__0(IDNDLGCBDKF p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2B3CED0", Offset = "0x2B3BED0", VA = "0x182B3CED0")]
			internal T <RegisterFixedString>b__1(IDNDLGCBDKF p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x413D700", Offset = "0x413C700", VA = "0x18413D700")]
		public static void HKCGAKMPIED(IIAGOIHDMCC JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2B89B00", Offset = "0x2B88B00", VA = "0x182B89B00")]
		private static void JINLLMKAMNB<T>(IIAGOIHDMCC JEMCFCDDPDL, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2B89C20", Offset = "0x2B88C20", VA = "0x182B89C20")]
		private static void PLDILALKEJE<T>(IDNDLGCBDKF JPPIJLBNKPM, T APLGHPJFDAI, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2B894B0", Offset = "0x2B884B0", VA = "0x182B894B0")]
		private static T HJHJBFNNDEL<T>(IDNDLGCBDKF JPPIJLBNKPM, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public INEKCADALPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class IHKMFLAMIMM : OJPFDPPCFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IIAGOIHDMCC JEMCFCDDPDL;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2B89290", Offset = "0x2B88290", VA = "0x182B89290", Slot = "6")]
		public override void BENMIKCNMJG<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x413D1E0", Offset = "0x413C1E0", VA = "0x18413D1E0")]
		public static void JDEFDBGAAPE(IIAGOIHDMCC JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x413D290", Offset = "0x413C290", VA = "0x18413D290")]
		public IHKMFLAMIMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x30D8720", Offset = "0x30D7720", VA = "0x1830D8720")]
	public static void KJKOKPHEMIO(IIAGOIHDMCC JEMCFCDDPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2349DE0", Offset = "0x2348DE0", VA = "0x182349DE0")]
	public static void IIFKIALBGHG<T>(IIAGOIHDMCC JEMCFCDDPDL, global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2349E70", Offset = "0x2348E70", VA = "0x182349E70")]
	public static void KILJJOAMGNE<T>(IIAGOIHDMCC NLIHAKMICKJ) where T : struct, KHHHMANHCMP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
public interface IIAGOIHDMCC : global::ENPICKHCJFK<IIAGOIHDMCC>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBHABPPKBJN(Type HAOFNDAEGFJ, JGIBKOJOACC NLIHAKMICKJ);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEDONIKBHEA(Type HAOFNDAEGFJ, out JGIBKOJOACC NLIHAKMICKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class CLIIMIDIADF
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A000", Offset = "0x2D19000", VA = "0x182D1A000")]
	public static void GBHABPPKBJN(this IIAGOIHDMCC GNJOCELFONM, JGIBKOJOACC NLIHAKMICKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[IABFONFHPFO(typeof(DHPMLHOBOOK), new string[] { })]
public sealed class BCOMHCIKEPP : DHPMLHOBOOK, global::ENPICKHCJFK<DHPMLHOBOOK>, JMMCIOGFDJD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<BPHAMHGLCNC, JGIBKOJOACC> JEMCFCDDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private IIAGOIHDMCC DEBOGBGICOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private KNGDFJPFKAH ICBILMELIDM;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool OIIGMLLGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D15AC0", Offset = "0x2D14AC0", VA = "0x182D15AC0")]
	public BCOMHCIKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D15A00", Offset = "0x2D14A00", VA = "0x182D15A00")]
	public BCOMHCIKEPP(Dictionary<BPHAMHGLCNC, JGIBKOJOACC> JEMCFCDDPDL, bool JLMINONKOLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D156A0", Offset = "0x2D146A0", VA = "0x182D156A0", Slot = "7")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D15700", Offset = "0x2D14700", VA = "0x182D15700", Slot = "8")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D154E0", Offset = "0x2D144E0", VA = "0x182D154E0", Slot = "9")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D15930", Offset = "0x2D14930", VA = "0x182D15930", Slot = "4")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GOENAEMJAON)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D15530", Offset = "0x2D14530", VA = "0x182D15530", Slot = "5")]
	public void GBHABPPKBJN(BPHAMHGLCNC CLOAPFCHKDE, JGIBKOJOACC NLIHAKMICKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D153A0", Offset = "0x2D143A0", VA = "0x182D153A0")]
	[Conditional("DEBUG_BUILD")]
	private void EEJHOPIFLAD(BPHAMHGLCNC CLOAPFCHKDE, Type HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D15780", Offset = "0x2D14780", VA = "0x182D15780", Slot = "6")]
	public bool LEDONIKBHEA(BPHAMHGLCNC CLOAPFCHKDE, out JGIBKOJOACC NLIHAKMICKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D152C0", Offset = "0x2D142C0", VA = "0x182D152C0", Slot = "10")]
	public DHPMLHOBOOK BEALFINIICI()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[IABFONFHPFO(typeof(IIAGOIHDMCC), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.TypeSerializer)]
	public sealed class TypeSerializerService : JMMCIOGFDJD, IIAGOIHDMCC, global::ENPICKHCJFK<IIAGOIHDMCC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, JGIBKOJOACC> JEMCFCDDPDL;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool OIIGMLLGEIE
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x71B000", Offset = "0x71A000", VA = "0x18071B000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C98980", Offset = "0x2C97980", VA = "0x182C98980")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C98A00", Offset = "0x2C97A00", VA = "0x182C98A00")]
		public TypeSerializerService(Dictionary<Type, JGIBKOJOACC> JEMCFCDDPDL, bool JLMINONKOLE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C987F0", Offset = "0x2C977F0", VA = "0x182C987F0", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C986D0", Offset = "0x2C976D0", VA = "0x182C986D0", Slot = "5")]
		public void GBHABPPKBJN(Type HAOFNDAEGFJ, JGIBKOJOACC NLIHAKMICKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C98850", Offset = "0x2C97850", VA = "0x182C98850", Slot = "6")]
		public bool LEDONIKBHEA(Type HAOFNDAEGFJ, out JGIBKOJOACC NLIHAKMICKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C985F0", Offset = "0x2C975F0", VA = "0x182C985F0", Slot = "7")]
		public IIAGOIHDMCC BEALFINIICI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[IABFONFHPFO(typeof(MFMAKOOKGCF), new string[] { })]
internal sealed class DBNEGCJJCHB : MFMAKOOKGCF, JMMCIOGFDJD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<BPHAMHGLCNC, PNKMIOFLGOC> FMPJOAFGJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private KNGDFJPFKAH ICBILMELIDM;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D261B0", Offset = "0x2D251B0", VA = "0x182D261B0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D26200", Offset = "0x2D25200", VA = "0x182D26200", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D26140", Offset = "0x2D25140", VA = "0x182D26140", Slot = "4")]
	public void GBHABPPKBJN(BPHAMHGLCNC AOKMGDODDPA, Type DDANHEOJOHK, PNKMIOFLGOC HGLGAJBLDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D260D0", Offset = "0x2D250D0", VA = "0x182D260D0", Slot = "5")]
	public bool CNBLODMEEBF(BPHAMHGLCNC AOKMGDODDPA, out PNKMIOFLGOC HGLGAJBLDDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D26260", Offset = "0x2D25260", VA = "0x182D26260")]
	[Conditional("DEBUG_BUILD")]
	private void LEAAKOEBBEO(BPHAMHGLCNC AOKMGDODDPA, Type DDANHEOJOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D263F0", Offset = "0x2D253F0", VA = "0x182D263F0")]
	public DBNEGCJJCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[IABFONFHPFO(typeof(LNEECONIDCC), new string[] { })]
internal sealed class CJDHLCELCED : LNEECONIDCC, HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly FPHDAPPLMBA IIDCCHPMPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<IJDKBBDMEBI, int> ANIEMMLPIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> JAJAJEGKILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[JOODLPJEDOA]
	private KNGDFJPFKAH ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[JOODLPJEDOA]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int OGDJEKDLBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D70", Offset = "0x2D18D70", VA = "0x182D19D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA560", Offset = "0x7A9560", VA = "0x1807AA560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x940400", Offset = "0x93F400", VA = "0x180940400", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D198F0", Offset = "0x2D188F0", VA = "0x182D198F0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D19E80", Offset = "0x2D18E80", VA = "0x182D19E80", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D19AA0", Offset = "0x2D18AA0", VA = "0x182D19AA0", Slot = "8")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D19A00", Offset = "0x2D18A00", VA = "0x182D19A00")]
	private void EONPIEEJHFP(GPEJGMHBDPO GBPGPLEPLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D19DC0", Offset = "0x2D18DC0", VA = "0x182D19DC0", Slot = "4")]
	public bool HLPJCPMPMOI(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D19B50", Offset = "0x2D18B50", VA = "0x182D19B50", Slot = "5")]
	public void HGONIOHMEBK(IJDKBBDMEBI DGPLFECNDCD, Span<BPHAMHGLCNC> ICBILMELIDM, bool MDCMJGBFODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D198F0", Offset = "0x2D188F0", VA = "0x182D198F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D19F00", Offset = "0x2D18F00", VA = "0x182D19F00")]
	public CJDHLCELCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class COCONAMFLJM
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A2B0", Offset = "0x2D192B0", VA = "0x182D1A2B0")]
	public static void ECIBCLFFOMM(this IDNDLGCBDKF AKJDPBEAJPA, ReadOnlyMemory<byte> AODPABKGGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x28422E0", Offset = "0x28412E0", VA = "0x1828422E0")]
	public static void ACBIDAJPHGD<T>(this IDNDLGCBDKF AKJDPBEAJPA, in T KPPLMEOMNGF) where T : struct, KHHHMANHCMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2842410", Offset = "0x2841410", VA = "0x182842410")]
	public static T JNAOCBCMBGH<T>(this IDNDLGCBDKF AKJDPBEAJPA) where T : struct, KHHHMANHCMP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A160", Offset = "0x2D19160", VA = "0x182D1A160")]
	public static void ACBIDAJPHGD(this IDNDLGCBDKF AKJDPBEAJPA, FFBLPEHDKDF PDAMOLAHIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A4E0", Offset = "0x2D194E0", VA = "0x182D1A4E0")]
	public static FFBLPEHDKDF NJOCBGFKEDD(this IDNDLGCBDKF AKJDPBEAJPA)
	{
		return default(FFBLPEHDKDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A330", Offset = "0x2D19330", VA = "0x182D1A330")]
	public static void NECHCDBGEDF(this IDNDLGCBDKF BBPDLFOHCNG, uint NJEPIMFKKCO, bool AKPBIFOOPJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A190", Offset = "0x2D19190", VA = "0x182D1A190")]
	public static uint DBNGDOICCFA(this IDNDLGCBDKF CAOOCDOHIKF, bool AKPBIFOOPJF = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class JAEDNIIODHH
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class FJGDBPGDLIG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public FJGDBPGDLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2907CC0", Offset = "0x2906CC0", VA = "0x182907CC0")]
		internal void <GetByteEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2907D30", Offset = "0x2906D30", VA = "0x182907D30")]
		internal T <GetByteEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class HGLHKHONFBN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public HGLHKHONFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E760", Offset = "0x2C6D760", VA = "0x182C6E760")]
		internal void <GetSByteEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E7D0", Offset = "0x2C6D7D0", VA = "0x182C6E7D0")]
		internal T <GetSByteEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class NPMNAFAMPIB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public NPMNAFAMPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x29D01F0", Offset = "0x29CF1F0", VA = "0x1829D01F0")]
		internal void <GetShortEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x29D0260", Offset = "0x29CF260", VA = "0x1829D0260")]
		internal T <GetShortEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class JDDGIGFNCCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public JDDGIGFNCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B41E40", Offset = "0x2B40E40", VA = "0x182B41E40")]
		internal void <GetUShortEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B41EB0", Offset = "0x2B40EB0", VA = "0x182B41EB0")]
		internal T <GetUShortEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class GFEEIIIJGNI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public GFEEIIIJGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x28F0B30", Offset = "0x28EFB30", VA = "0x1828F0B30")]
		internal void <GetIntEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x28F0B90", Offset = "0x28EFB90", VA = "0x1828F0B90")]
		internal T <GetIntEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class GFEKPPGEEMG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public GFEKPPGEEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x28F0BE0", Offset = "0x28EFBE0", VA = "0x1828F0BE0")]
		internal void <GetUIntEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x28F0C40", Offset = "0x28EFC40", VA = "0x1828F0C40")]
		internal T <GetUIntEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x29473C0", Offset = "0x29463C0", VA = "0x1829473C0")]
	public static void GFAAFAFPCPB<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x29475E0", Offset = "0x29465E0", VA = "0x1829475E0")]
	private static void OECGCPDEKOE<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x29475E0", Offset = "0x29465E0", VA = "0x1829475E0")]
	private static void HFKKMOPOLOK<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2947270", Offset = "0x2946270", VA = "0x182947270")]
	private static void EBDLODACFAH<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x2947270", Offset = "0x2946270", VA = "0x182947270")]
	private static void LIMMMCDOHMA<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x2947120", Offset = "0x2946120", VA = "0x182947120")]
	private static void FHNHHCMHCAC<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2947120", Offset = "0x2946120", VA = "0x182947120")]
	private static void CPABNGLBGFI<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class IENBFKHMMCN : OMMIJKDJINI, PFFHIJLFPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x30E5E00", Offset = "0x30E4E00", VA = "0x1830E5E00", Slot = "4")]
	private void FOJNOIOPKLP(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MIFGDNDEHIK(DHPMLHOBOOK ICBILMELIDM);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
	protected IENBFKHMMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[INBKPPOJOGA(typeof(LocalPoseData))]
public sealed class JACAEMOPGKD : IENBFKHMMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x30E74E0", Offset = "0x30E64E0", VA = "0x1830E74E0", Slot = "5")]
	protected override void MIFGDNDEHIK(DHPMLHOBOOK ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
	public JACAEMOPGKD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class CopyAuthorityToEntity : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery BPIFFIIDDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery BDNJLMMMHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery OINLNJKBILL;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2D22AF0", Offset = "0x2D21AF0", VA = "0x182D22AF0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2D22E50", Offset = "0x2D21E50", VA = "0x182D22E50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2D22FD0", Offset = "0x2D21FD0", VA = "0x182D22FD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2D22FA0", Offset = "0x2D21FA0", VA = "0x182D22FA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2D22330", Offset = "0x2D21330", VA = "0x182D22330")]
		private void BPPGOHFOFEO(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2D22950", Offset = "0x2D21950", VA = "0x182D22950")]
		private void IOMLEDCABAI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2D22670", Offset = "0x2D21670", VA = "0x182D22670")]
		private void CKPIOEECHMJ(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2D22180", Offset = "0x2D21180", VA = "0x182D22180")]
		private void BLHNLGEPKMO(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2D22C40", Offset = "0x2D21C40", VA = "0x182D22C40")]
		private void OEFHCCMBDEC(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2D22B60", Offset = "0x2D21B60", VA = "0x182D22B60")]
		private void MKNCGIBNGGA(GPEJGMHBDPO GBPGPLEPLBP, int HIFBLLMBEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class EPDCKAODPNP : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C6A0", Offset = "0x2D2B6A0", VA = "0x182D2C6A0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CCD0", Offset = "0x2D2BCD0", VA = "0x182D2CCD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CD90", Offset = "0x2D2BD90", VA = "0x182D2CD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C6F0", Offset = "0x2D2B6F0", VA = "0x182D2C6F0")]
	private void OKFFABCDFPB(NativeArray<Entity> GMAMPIGCEAB, NativeList<Entity> MAGLBLOKDFO, ComponentDataFromEntity<PJEFIJNLAOI> DJJOBGKBOLN, BufferFromEntity<ChildrenData> CGNJHCJMHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public EPDCKAODPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class PAGEBCNLPIB : ParentSystemBase<AuthoredParentData, OFFHECIKBLF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD390", Offset = "0x2ABC390", VA = "0x182ABD390", Slot = "14")]
	protected override EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x78A6D0", Offset = "0x7896D0", VA = "0x18078A6D0", Slot = "15")]
	protected override EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD3D0", Offset = "0x2ABC3D0", VA = "0x182ABD3D0", Slot = "16")]
	protected override EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD350", Offset = "0x2ABC350", VA = "0x182ABD350", Slot = "17")]
	protected override EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD450", Offset = "0x2ABC450", VA = "0x182ABD450")]
	public PAGEBCNLPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD410", Offset = "0x2ABC410", VA = "0x182ABD410", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class IOPPJNEEHEF : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object DLDDEBCCONJ;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x30E6D90", Offset = "0x30E5D90", VA = "0x1830E6D90", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x30E6E10", Offset = "0x30E5E10", VA = "0x1830E6E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x30E6EB0", Offset = "0x30E5EB0", VA = "0x1830E6EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public IOPPJNEEHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class NNJNDLKLICM : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object DLDDEBCCONJ;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEAB0", Offset = "0x2AADAB0", VA = "0x182AAEAB0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEB30", Offset = "0x2AADB30", VA = "0x182AAEB30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEBD0", Offset = "0x2AADBD0", VA = "0x182AAEBD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public NNJNDLKLICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct JPGEHKBMENC : ISystemStateBufferElementData, IBufferElementData, IEquatable<JPGEHKBMENC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public FOLAJHLHGHC BDCLOJHOMDK;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x30DBC70", Offset = "0x30DAC70", VA = "0x1830DBC70", Slot = "4")]
	public bool Equals(JPGEHKBMENC JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20")]
	public static JPGEHKBMENC HEFILGHKDEM(FOLAJHLHGHC BDCLOJHOMDK)
	{
		return default(JPGEHKBMENC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct KJDKPBCMHHG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public FOLAJHLHGHC BDCLOJHOMDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20")]
	public static KJDKPBCMHHG HEFILGHKDEM(FOLAJHLHGHC BDCLOJHOMDK)
	{
		return default(KJDKPBCMHHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class OJPBPMICBGP : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEE50", Offset = "0x2AADE50", VA = "0x182AAEE50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEFE0", Offset = "0x2AADFE0", VA = "0x182AAEFE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90C0", Offset = "0x2AA80C0", VA = "0x182AA90C0")]
	protected OJPBPMICBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[CGJIBJMELLG]
internal abstract class AAANMICNOEB : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected OLGPCPINIDC LKMGIJIPLIN;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E280", Offset = "0x2D0D280", VA = "0x182D0E280", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E2F0", Offset = "0x2D0D2F0", VA = "0x182D0E2F0")]
	protected void KCKIJJMDLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DF90", Offset = "0x2D0CF90", VA = "0x182D0DF90")]
	protected void HNBINKBJCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E210", Offset = "0x2D0D210", VA = "0x182D0E210")]
	protected LNMIPKFIEGC IKMNJMMAFKM()
	{
		return default(LNMIPKFIEGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	protected AAANMICNOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class KABFGNEFJKH : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x30EA070", Offset = "0x30E9070", VA = "0x1830EA070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x30EA200", Offset = "0x30E9200", VA = "0x1830EA200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90C0", Offset = "0x2AA80C0", VA = "0x182AA90C0")]
	protected KABFGNEFJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class JJGPOFFPHGA : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x30E87A0", Offset = "0x30E77A0", VA = "0x1830E87A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x30E88B0", Offset = "0x30E78B0", VA = "0x1830E88B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90C0", Offset = "0x2AA80C0", VA = "0x182AA90C0")]
	protected JJGPOFFPHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class MBFNDBILOHJ : OJPBPMICBGP
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9050", Offset = "0x2AA8050", VA = "0x182AA9050", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90C0", Offset = "0x2AA80C0", VA = "0x182AA90C0")]
	public MBFNDBILOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class LGMKIIIENBF : KABFGNEFJKH
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2AA67F0", Offset = "0x2AA57F0", VA = "0x182AA67F0", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6860", Offset = "0x2AA5860", VA = "0x182AA6860")]
	public LGMKIIIENBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class NBDMNJBAIHB : JJGPOFFPHGA
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB4A0", Offset = "0x2AAA4A0", VA = "0x182AAB4A0", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6860", Offset = "0x2AA5860", VA = "0x182AA6860")]
	public NBDMNJBAIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class AKFFNGCIKKB : OJPBPMICBGP
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2D11BD0", Offset = "0x2D10BD0", VA = "0x182D11BD0", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6860", Offset = "0x2AA5860", VA = "0x182AA6860")]
	public AKFFNGCIKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class IPBGIFKKPMK : KABFGNEFJKH
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x30E7130", Offset = "0x30E6130", VA = "0x1830E7130", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90C0", Offset = "0x2AA80C0", VA = "0x182AA90C0")]
	public IPBGIFKKPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class MDGFCFDNKCJ : JJGPOFFPHGA
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override DMBFIJFHJEL KDDNOGHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9260", Offset = "0x2AA8260", VA = "0x182AA9260", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6860", Offset = "0x2AA5860", VA = "0x182AA6860")]
	public MDGFCFDNKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct ODMBJCFOGFI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct BKPAMFDNNFG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct HIKPKEPHLMF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct DMBFIJFHJEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType EKKJDILLMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType IJHBCFMOMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object JAKCBCDLMLB;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2D28E50", Offset = "0x2D27E50", VA = "0x182D28E50")]
	public DMBFIJFHJEL(ComponentType EKKJDILLMHE, ComponentType IJHBCFMOMGF, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x213AEC0", Offset = "0x2139EC0", VA = "0x18213AEC0")]
	public static DMBFIJFHJEL BAGBAIEEPPJ<TReq, TTag>(object JAKCBCDLMLB)
	{
		return default(DMBFIJFHJEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class EOIHMNFEINE
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string EGNCLGHPBCF = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string KJDKCBFJMDF = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly DMBFIJFHJEL PAGKBNBNKGD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly DMBFIJFHJEL MBOLKHHHNIE;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct FOLAJHLHGHC : global::AOOPJGHLJBJ<FOLAJHLHGHC>, LGHBPHHHPFG, IEquatable<FOLAJHLHGHC>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x30DBCC0", Offset = "0x30DACC0", VA = "0x1830DBCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x30DBC70", Offset = "0x30DAC70", VA = "0x1830DBC70", Slot = "8")]
	public bool Equals(FOLAJHLHGHC JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x30DBD00", Offset = "0x30DAD00", VA = "0x1830DBD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CGJIBJMELLG]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Connectables)]
	public class UpdateConnectableVisuals : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct CANIDKBJIKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public FOLAJHLHGHC BDCLOJHOMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 MIFJBHLKJIN;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x4139630", Offset = "0x4138630", VA = "0x184139630")]
			public CANIDKBJIKJ(FOLAJHLHGHC BDCLOJHOMDK, float3 MIFJBHLKJIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x4139610", Offset = "0x4138610", VA = "0x184139610")]
			public void LEPJGOMAPEJ(out FOLAJHLHGHC BDCLOJHOMDK, out float3 MIFJBHLKJIN)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct FGBDKLPAKFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<CANIDKBJIKJ> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
			public FGBDKLPAKFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<KJDKPBCMHHG> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct KIHKNOENEBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<CANIDKBJIKJ> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
			public KIHKNOENEBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<JPGEHKBMENC> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct FNKBIOBMAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<CANIDKBJIKJ> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
			public FNKBIOBMAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in MFOFDKAGJEK com, in DynamicBuffer<JPGEHKBMENC> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct DKFDKOACDHL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct AFCBAGFKMJL
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct DOEMCLCFJIK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime FEOPCENDCDE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<KJDKPBCMHHG>.Runtime OEIOBGDDDJM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFLBKBJJPPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<KJDKPBCMHHG> JFMCFNCOKHP;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x4137E80", Offset = "0x4136E80", VA = "0x184137E80")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x4137DC0", Offset = "0x4136DC0", VA = "0x184137DC0")]
				public DOEMCLCFJIK CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(DOEMCLCFJIK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals PDCCJAEJIHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<CANIDKBJIKJ> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private AFCBAGFKMJL PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AFCBAGFKMJL.DOEMCLCFJIK* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x413A560", Offset = "0x4139560", VA = "0x18413A560")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, WorldPoseData FJNMJJIHMCM, in DynamicBuffer<KJDKPBCMHHG> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x413A7A0", Offset = "0x41397A0", VA = "0x18413A7A0", Slot = "5")]
			public void ReadFromDisplayClass(ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x413A7D0", Offset = "0x41397D0", VA = "0x18413A7D0", Slot = "6")]
			public void WriteToDisplayClass(ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x413A290", Offset = "0x4139290", VA = "0x18413A290", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x413A3E0", Offset = "0x41393E0", VA = "0x18413A3E0")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref AFCBAGFKMJL.DOEMCLCFJIK KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x413A520", Offset = "0x4139520", VA = "0x18413A520")]
			public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH, ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x413A370", Offset = "0x4139370", VA = "0x18413A370")]
			public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LHEGCJPLNAN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct HJMLEKCMIEJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct JDPJPDPLNEA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime FEOPCENDCDE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JPGEHKBMENC>.Runtime OEIOBGDDDJM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFLBKBJJPPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<JPGEHKBMENC> JFMCFNCOKHP;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x413C870", Offset = "0x413B870", VA = "0x18413C870")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x413C7D0", Offset = "0x413B7D0", VA = "0x18413C7D0")]
				public JDPJPDPLNEA CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(JDPJPDPLNEA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<CANIDKBJIKJ> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private HJMLEKCMIEJ PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HJMLEKCMIEJ.JDPJPDPLNEA* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x41400E0", Offset = "0x413F0E0", VA = "0x1841400E0")]
			internal void OCIBIOHOPKH(in WorldPoseData FJNMJJIHMCM, in DynamicBuffer<JPGEHKBMENC> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13CA9F0", VA = "0x1813CB9F0", Slot = "5")]
			public void ReadFromDisplayClass(ref KIHKNOENEBK BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x413FEA0", Offset = "0x413EEA0", VA = "0x18413FEA0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x413FF70", Offset = "0x413EF70", VA = "0x18413FF70")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref HJMLEKCMIEJ.JDPJPDPLNEA KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x4140040", Offset = "0x413F040", VA = "0x184140040")]
			public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH, ref KIHKNOENEBK BFCCEFMGPEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LJKMCHPNECH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct FNNDAOCMNLJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct NHHMHCEKBBE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime FEOPCENDCDE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<MFOFDKAGJEK>.Runtime OLIPBCGOLDP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JPGEHKBMENC>.Runtime OEIOBGDDDJM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NFLBKBJJPPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<MFOFDKAGJEK> OKLLMNLKEJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<JPGEHKBMENC> JFMCFNCOKHP;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x413BD10", Offset = "0x413AD10", VA = "0x18413BD10")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x413BC40", Offset = "0x413AC40", VA = "0x18413BC40")]
				public NHHMHCEKBBE CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(NHHMHCEKBBE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<CANIDKBJIKJ> EHJGMBFBLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private FNNDAOCMNLJ PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FNNDAOCMNLJ.NHHMHCEKBBE* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x41403D0", Offset = "0x413F3D0", VA = "0x1841403D0")]
			internal void OCIBIOHOPKH(in WorldPoseData FJNMJJIHMCM, in MFOFDKAGJEK LCBCIHMHDMO, in DynamicBuffer<JPGEHKBMENC> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13CA9F0", VA = "0x1813CB9F0", Slot = "5")]
			public void ReadFromDisplayClass(ref FNKBIOBMAFE BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x41401F0", Offset = "0x413F1F0", VA = "0x1841401F0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x4140270", Offset = "0x413F270", VA = "0x184140270")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref FNNDAOCMNLJ.NHHMHCEKBBE KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x4140390", Offset = "0x413F390", VA = "0x184140390")]
			public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH, ref FNKBIOBMAFE BFCCEFMGPEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery NBJIPFKIFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery AGLFJGGLMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery MJEJOMJCALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery EPBNODIMMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery NFGFKODAAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery EJFBMMJCFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery FNBLDACAJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery JKBDLEHCCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery CDINODFJKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery PBFKHDAPAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::IEDFOPGJHFB<FOLAJHLHGHC, HCEFJNDGODN> ODAOEDJMHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private MJBFDNAELPM NGJMIGNGFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private EHCGNDKDHFM AKMHDEFEKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private PHHKGGDPBDG FEPOMKGOMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery OBFHAMBCKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker IAOGJAFGBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery GMDOEBIGDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery OGDNILNIPNH;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2C9C0C0", Offset = "0x2C9B0C0", VA = "0x182C9C0C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2C98FF0", Offset = "0x2C97FF0", VA = "0x182C98FF0")]
		internal HCEFJNDGODN ABEGHGNHLLG(FOLAJHLHGHC BDCLOJHOMDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B310", Offset = "0x2C9A310", VA = "0x182C9B310", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CC00", Offset = "0x2C9BC00", VA = "0x182C9CC00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CE80", Offset = "0x2C9BE80", VA = "0x182C9CE80", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D010", Offset = "0x2C9C010", VA = "0x182C9D010", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CE40", Offset = "0x2C9BE40", VA = "0x182C9CE40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B3D0", Offset = "0x2C9A3D0", VA = "0x182C9B3D0")]
		private void KHCHPGBLLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BBA0", Offset = "0x2C9ABA0", VA = "0x182C9BBA0")]
		private void LMNELOPMGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C100", Offset = "0x2C9B100", VA = "0x182C9C100")]
		private void NJNNKHOFNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D050", Offset = "0x2C9C050", VA = "0x182C9D050", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AD00", Offset = "0x2C99D00", VA = "0x182C9AD00")]
		private void HMNCABBCMFO(EntityQuery BPIFFIIDDIC, EntityQuery CHENOCAGDJL, EntityQuery BDNJLMMMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D3E0", Offset = "0x2C9C3E0", VA = "0x182C9D3E0")]
		private void PMMODKPOELK(EntityQuery BDNJLMMMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2C999B0", Offset = "0x2C989B0", VA = "0x182C999B0")]
		private void EMPBDBOHOJD(NativeArrayAsync<Entity> EHIBMPOCMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2C99540", Offset = "0x2C98540", VA = "0x182C99540")]
		private void DBFNCNGHHLH(NativeArrayAsync<Entity> AOOECIAPIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BA00", Offset = "0x2C9AA00", VA = "0x182C9BA00")]
		private void KNMFBANLOEO(NativeArrayAsync<Entity> DGEDLENHJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2C997E0", Offset = "0x2C987E0", VA = "0x182C997E0")]
		private void DIFDLCGIOKG(NativeList<FOLAJHLHGHC> ODBCMMPFKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A1C0", Offset = "0x2C991C0", VA = "0x182C9A1C0")]
		private NativeList<FOLAJHLHGHC> HBIPEEDJJPM(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<FOLAJHLHGHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A6E0", Offset = "0x2C996E0", VA = "0x182C9A6E0")]
		private void HCNELJHHOCL(NativeArray<Entity> GMAMPIGCEAB, NativeList<FOLAJHLHGHC> ODBCMMPFKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2C99C90", Offset = "0x2C98C90", VA = "0x182C99C90")]
		private void GNMACPHGKGL(NativeArray<Entity> DKDJJFDGEMD, NativeArray<Entity> KENGEDAIJDB, NativeList<FOLAJHLHGHC> JAJAJEGKILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C4B0", Offset = "0x2C9B4B0", VA = "0x182C9C4B0")]
		private void NLIEPODEPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C960", Offset = "0x2C9B960", VA = "0x182C9C960")]
		private NativeListAsync<CANIDKBJIKJ> OINFMJJBMBM(EntityQuery APEJLGJADFF, Func<NativeList<CANIDKBJIKJ>, JobHandle> HNCEEGILEGK)
		{
			return default(NativeListAsync<CANIDKBJIKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2C99650", Offset = "0x2C98650", VA = "0x182C99650")]
		private JobHandle DCGOMBPNMLI(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2C99200", Offset = "0x2C98200", VA = "0x182C99200")]
		private JobHandle ALDKLBELIJL(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B1E0", Offset = "0x2C9A1E0", VA = "0x182C9B1E0")]
		private JobHandle IOHAOBDMMAF(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B4E0", Offset = "0x2C9A4E0", VA = "0x182C9B4E0")]
		private void KHKNGDAHBAE(NativeListAsync<CANIDKBJIKJ> EHJGMBFBLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B770", Offset = "0x2C9A770", VA = "0x182C9B770")]
		private void KLFGBFBPNLA(NativeListAsync<CANIDKBJIKJ> EHJGMBFBLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2C99950", Offset = "0x2C98950", VA = "0x182C99950")]
		private bool EGCLNNMCELP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BFF0", Offset = "0x2C9AFF0", VA = "0x182C9BFF0")]
		private NativeArray<Entity> MPCMNLGDDHP(Entity PJEENOLDJIO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2C99040", Offset = "0x2C98040", VA = "0x182C99040")]
		private FOLAJHLHGHC ADHBPIGNGAG(NativeList<FOLAJHLHGHC> JAJAJEGKILP)
		{
			return default(FOLAJHLHGHC);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BCF0", Offset = "0x2C9ACF0", VA = "0x182C9BCF0")]
		private void LPDECKMEDNA(FOLAJHLHGHC BDCLOJHOMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CAA0", Offset = "0x2C9BAA0", VA = "0x182C9CAA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2C99340", Offset = "0x2C98340", VA = "0x182C99340")]
		public static EntityQuery BJGIDNABIMI(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D180", Offset = "0x2C9C180", VA = "0x182C9D180")]
		public static EntityQuery PDBMCDDIDCA(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BD80", Offset = "0x2C9AD80", VA = "0x182C9BD80")]
		public static EntityQuery MKPGKLBNIJL(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[OHGELDJCNJM(GGAOONGBEBH.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private CGDDJBMDAKP EBGBIKNFKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private KGMIPOMIBOG CDDPFJGAJAH;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2F60", Offset = "0x2AC1F60", VA = "0x182AC2F60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2ED0", Offset = "0x2AC1ED0", VA = "0x182AC2ED0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3060", Offset = "0x2AC2060", VA = "0x182AC3060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class EBGGPCADDGJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public EMAJLAJEHKH AIJDONAKHON;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EBGGPCADDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	public EBGGPCADDGJ(EMAJLAJEHKH AIJDONAKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A2F0", Offset = "0x2D292F0", VA = "0x182D2A2F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class BOBDGHNGPNP : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService EMDCODCKMDO;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D16200", Offset = "0x2D15200", VA = "0x182D16200", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D16260", Offset = "0x2D15260", VA = "0x182D16260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D16290", Offset = "0x2D15290", VA = "0x182D16290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	protected BOBDGHNGPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class JOPEEOLALKP : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery OJMGCJCFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery ALNOHHLENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery GENEPBLBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery NDBDFPOBLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService GBAPIGCEAHA;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int OKELKMPBJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x30E9CB0", Offset = "0x30E8CB0", VA = "0x1830E9CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int DKCGFGMKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x30E9A00", Offset = "0x30E8A00", VA = "0x1830E9A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x30E9A30", Offset = "0x30E8A30", VA = "0x1830E9A30", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x30E9CC0", Offset = "0x30E8CC0", VA = "0x1830E9CC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x30E9EC0", Offset = "0x30E8EC0", VA = "0x1830E9EC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x30E9980", Offset = "0x30E8980", VA = "0x1830E9980")]
	public int CLEDONPNABJ(SceneTag JLPOKIGCHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x30E9A10", Offset = "0x30E8A10", VA = "0x1830E9A10")]
	public int GHLJGKCNJAI(SceneTag JLPOKIGCHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x30E9760", Offset = "0x30E8760", VA = "0x1830E9760")]
	protected void BOIFAPGKPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x30E9EE0", Offset = "0x30E8EE0", VA = "0x1830E9EE0")]
	protected void PMDABOOEHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x30E9B50", Offset = "0x30E8B50", VA = "0x1830E9B50")]
	public NativeArrayAsync<Entity> LDCFNAIPDIB(SceneTag JLPOKIGCHBG, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x30E9A90", Offset = "0x30E8A90", VA = "0x1830E9A90")]
	public NativeArrayAsync<Entity> KBOJEPFPNKN(SceneTag JLPOKIGCHBG, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x30E96D0", Offset = "0x30E86D0", VA = "0x1830E96D0")]
	public bool AFOEKCKEOCB(SceneTag JLPOKIGCHBG, out NativeArrayAsync<Entity> AIJDONAKHON, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x30E99A0", Offset = "0x30E89A0", VA = "0x1830E99A0")]
	public bool CPIAGHNENJJ(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x30E9BE0", Offset = "0x30E8BE0", VA = "0x1830E9BE0")]
	public EMAJLAJEHKH MAONNFPMIBI(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x30E9AE0", Offset = "0x30E8AE0", VA = "0x1830E9AE0")]
	public bool KLLNBFNLACK(Entity PJEENOLDJIO, out EBGGPCADDGJ AIJDONAKHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x30E9BA0", Offset = "0x30E8BA0", VA = "0x1830E9BA0")]
	public void LDHHNPPIDMN(Entity PJEENOLDJIO, EBGGPCADDGJ AIJDONAKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x30E9C50", Offset = "0x30E8C50", VA = "0x1830E9C50")]
	public bool ODEOGIOICML(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LCHFPPHLBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public JOPEEOLALKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class ANBBCJHLCNL : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery NGGONIJBNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private KHCCBBJDMKM JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D11EE0", Offset = "0x2D10EE0", VA = "0x182D11EE0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D11FA0", Offset = "0x2D10FA0", VA = "0x182D11FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D12060", Offset = "0x2D11060", VA = "0x182D12060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x176CDE0", Offset = "0x176BDE0", VA = "0x18176CDE0")]
	private bool JMGKGIGAGKI<TComponentData>(EntityQuery APEJLGJADFF, out NativeArray<Entity> GMAMPIGCEAB, out NativeArray<TComponentData> MDPFJMFBAOK) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D11F30", Offset = "0x2D10F30", VA = "0x182D11F30")]
	public EMAJLAJEHKH MAONNFPMIBI(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public ANBBCJHLCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[OHGELDJCNJM(GGAOONGBEBH.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery JFPDFPBPNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery MECAMEDGPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery FIDHLPMLJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery OINLNJKBILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E850", Offset = "0x2C8D850", VA = "0x182C8E850", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E8A0", Offset = "0x2C8D8A0", VA = "0x182C8E8A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EAD0", Offset = "0x2C8DAD0", VA = "0x182C8EAD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E480", Offset = "0x2C8D480", VA = "0x182C8E480")]
		private void GBJBCHALJOG(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EC00", Offset = "0x2C8DC00", VA = "0x182C8EC00")]
		private void PMMODKPOELK(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EA60", Offset = "0x2C8DA60", VA = "0x182C8EA60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E4F0", Offset = "0x2C8D4F0", VA = "0x182C8E4F0")]
		private void HKIAPADCEBA(EntityQuery APEJLGJADFF, bool HAAPPAEMABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class GCJOGLOLCBD : HCAPJDLAPMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct PPKJHCCEPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public PPKJHCCEPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PNKFILNLGCN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct LCLLEOELAFF
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct EIFBICKMEGN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GOHCBLMGPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime FFNKIAHAIFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime JKNDAGFGKDL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GOFLDJEOCBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> KGGFEADPFKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> MHJAPMICIPK;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x413FB80", Offset = "0x413EB80", VA = "0x18413FB80")]
			public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x413FAC0", Offset = "0x413EAC0", VA = "0x18413FAC0")]
			public EIFBICKMEGN CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(EIFBICKMEGN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private LCLLEOELAFF PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LCLLEOELAFF.EIFBICKMEGN* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x4143230", Offset = "0x4142230", VA = "0x184143230")]
		internal void OCIBIOHOPKH(Entity JMFCHNOMKAM, SplineShapeData BJBDNHBIPAI, DynamicBuffer<LinkedEntityGroup> BFNDINBALAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x4143030", Offset = "0x4142030", VA = "0x184143030", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x4143100", Offset = "0x4142100", VA = "0x184143100")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref LCLLEOELAFF.EIFBICKMEGN KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x4143220", Offset = "0x4142220", VA = "0x184143220")]
		public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PPCCCJEBJHE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct KHFFANINBGC
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct JIECIMAGGIK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MPCPJILPNBP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime DMAJJDLEIKL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity KIMFCKFKNGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> KECPJFGPMGH;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x413EF30", Offset = "0x413DF30", VA = "0x18413EF30")]
			public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x413EEB0", Offset = "0x413DEB0", VA = "0x18413EEB0")]
			public JIECIMAGGIK CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(JIECIMAGGIK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> NEMMLOPFJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private KHFFANINBGC PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KHFFANINBGC.JIECIMAGGIK* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x4143470", Offset = "0x4142470", VA = "0x184143470")]
		internal void OCIBIOHOPKH(Entity ODIEOJHEKBE, SplinePointParentData EIALPBJMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x4143500", Offset = "0x4142500", VA = "0x184143500", Slot = "5")]
		public void ReadFromDisplayClass(ref PPKJHCCEPLC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x4143290", Offset = "0x4142290", VA = "0x184143290", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x4143330", Offset = "0x4142330", VA = "0x184143330")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref KHFFANINBGC.JIECIMAGGIK KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x41433E0", Offset = "0x41423E0", VA = "0x1841433E0")]
		public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH, ref PPKJHCCEPLC BFCCEFMGPEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery OLPNFLOIHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery BPLELGNNOBB;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x30DE870", Offset = "0x30DD870", VA = "0x1830DE870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x30DE920", Offset = "0x30DD920", VA = "0x1830DE920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public GCJOGLOLCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x30DE5D0", Offset = "0x30DD5D0", VA = "0x1830DE5D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x30DE2D0", Offset = "0x30DD2D0", VA = "0x1830DE2D0")]
	public static EntityQuery BIIJLNAHEEL(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x30DE470", Offset = "0x30DD470", VA = "0x1830DE470")]
	public static EntityQuery GNMJBHBADKG(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public sealed class HBFOEJBCPJM : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private ECMNKKDCFCB OLFNCOFMCFB;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x30E10F0", Offset = "0x30E00F0", VA = "0x1830E10F0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x30E1150", Offset = "0x30E0150", VA = "0x1830E1150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public HBFOEJBCPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class CGBHHPHCONE : HCAPJDLAPMD, PFFHIJLFPMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct HMEENMEPIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<EJDOAJBNLAC> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<DFLCMAHAHIM> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<EJDOAJBNLAC> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public HMEENMEPIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, CEDELNEJEJO previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__2(Entity entity, CEDELNEJEJO previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct CIGOCIDFMEM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct IHPPCKNIIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct INHMMFLPHNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJALCHANNKE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> EENDHBJJEHJ;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x413D320", Offset = "0x413C320", VA = "0x18413D320")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x413D2A0", Offset = "0x413C2A0", VA = "0x18413D2A0")]
			public INHMMFLPHNL CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(INHMMFLPHNL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<EJDOAJBNLAC> ELMCGNGKECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private IHPPCKNIIDJ PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IHPPCKNIIDJ.INHMMFLPHNL* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x2C83E90", Offset = "0x2C82E90", VA = "0x182C83E90")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData IMFNGEBEPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13CA9F0", VA = "0x1813CB9F0", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x2C83D30", Offset = "0x2C82D30", VA = "0x182C83D30", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2C83DA0", Offset = "0x2C82DA0", VA = "0x182C83DA0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref IHPPCKNIIDJ.INHMMFLPHNL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2C83E50", Offset = "0x2C82E50", VA = "0x182C83E50")]
		public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH, ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MAMMBOGENEP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct GEIJKKPACAG
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct OAABMHIJDFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJALCHANNKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<CEDELNEJEJO>.Runtime BIAHKOAGJLB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> EENDHBJJEHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<CEDELNEJEJO> NJPCNHHIOAE;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x413C060", Offset = "0x413B060", VA = "0x18413C060")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x413BFC0", Offset = "0x413AFC0", VA = "0x18413BFC0")]
			public OAABMHIJDFB CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(OAABMHIJDFB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<DFLCMAHAHIM> EEDDICNOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private GEIJKKPACAG PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GEIJKKPACAG.OAABMHIJDFB* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2C86D00", Offset = "0x2C85D00", VA = "0x182C86D00")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData IMFNGEBEPMB, CEDELNEJEJO KCDBOIAJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2C86DC0", Offset = "0x2C85DC0", VA = "0x182C86DC0", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2C86B70", Offset = "0x2C85B70", VA = "0x182C86B70", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2C86BE0", Offset = "0x2C85BE0", VA = "0x182C86BE0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref GEIJKKPACAG.OAABMHIJDFB KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2C86CC0", Offset = "0x2C85CC0", VA = "0x182C86CC0")]
		public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH, ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BIJOCBLCPAJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct CELEOFPKKPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct PCFBFNDKKOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<CEDELNEJEJO>.Runtime BIAHKOAGJLB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<CEDELNEJEJO> NJPCNHHIOAE;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x413A040", Offset = "0x4139040", VA = "0x18413A040")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x4139FC0", Offset = "0x4138FC0", VA = "0x184139FC0")]
			public PCFBFNDKKOL CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(PCFBFNDKKOL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<EJDOAJBNLAC> IBGHANMGCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private CELEOFPKKPD PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CELEOFPKKPD.PCFBFNDKKOL* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x2C83CA0", Offset = "0x2C82CA0", VA = "0x182C83CA0")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, CEDELNEJEJO KCDBOIAJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2C83D20", Offset = "0x2C82D20", VA = "0x182C83D20", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2C83B40", Offset = "0x2C82B40", VA = "0x182C83B40", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2C83BB0", Offset = "0x2C82BB0", VA = "0x182C83BB0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref CELEOFPKKPD.PCFBFNDKKOL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2C83C60", Offset = "0x2C82C60", VA = "0x182C83C60")]
		public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH, ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private HPMBAGGHCAG OJNHMCLANPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery OPPMABHMMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery OMGOCEOGHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery GHPLELHJPIP;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D191B0", Offset = "0x2D181B0", VA = "0x182D191B0", Slot = "14")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D19520", Offset = "0x2D18520", VA = "0x182D19520", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public CGBHHPHCONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D194C0", Offset = "0x2D184C0", VA = "0x182D194C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D18D50", Offset = "0x2D17D50", VA = "0x182D18D50")]
	public static EntityQuery BBHAJCMHJBK(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D19290", Offset = "0x2D18290", VA = "0x182D19290")]
	public static EntityQuery LOGOANOEIEB(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D18FB0", Offset = "0x2D17FB0", VA = "0x182D18FB0")]
	public static EntityQuery BOMPBGGBLJN(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[OHGELDJCNJM(GGAOONGBEBH.Connectables)]
	public class InitializeRigidbodyExHierarchy : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private NNOKEEGAFIH JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x30E7210", Offset = "0x30E6210", VA = "0x1830E7210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x30E71A0", Offset = "0x30E61A0", VA = "0x1830E71A0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x30E72A0", Offset = "0x30E62A0", VA = "0x1830E72A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class MHEHMPGEHBA : ParentSystemBase<ParentData, CEDELNEJEJO, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9750", Offset = "0x2AA8750", VA = "0x182AA9750", Slot = "14")]
	protected override EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x78A6D0", Offset = "0x7896D0", VA = "0x18078A6D0", Slot = "15")]
	protected override EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9790", Offset = "0x2AA8790", VA = "0x182AA9790", Slot = "16")]
	protected override EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9710", Offset = "0x2AA8710", VA = "0x182AA9710", Slot = "17")]
	protected override EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9810", Offset = "0x2AA8810", VA = "0x182AA9810")]
	public MHEHMPGEHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2AA97D0", Offset = "0x2AA87D0", VA = "0x182AA97D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : HCAPJDLAPMD where ParentData : struct, IComponentData, PGCNPEJMMNE where PreviousParentData : struct, IComponentData, PGCNPEJMMNE where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, PGCNPEJMMNE
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct KLFCDDENMPG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MCHAEMCCGIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter KBMGNNMKCPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter PBHJPIGHHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> CJEKHLPEMPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> PEFIHCGLJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType BPDEPBOJGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint NONCMKJPKFP;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x2B59690", Offset = "0x2B58690", VA = "0x182B59690", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct ABOMJBLJEBF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> PBHJPIGHHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BMEKADFLAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> NFMNGPOABKI;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x350FB20", Offset = "0x350EB20", VA = "0x18350FB20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct EIOIIEOHGGB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MCHAEMCCGIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> KBMGNNMKCPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> PBHJPIGHHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> BMEKADFLAGP;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x2018EA0", Offset = "0x2017EA0", VA = "0x182018EA0")]
			private int BCMGAFLLCEJ(DynamicBuffer<ChildrenData> DJHPOGLHKJI, Entity PJEENOLDJIO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x2019630", Offset = "0x2018630", VA = "0x182019630")]
			private void PKOGDGKDNAA(Entity OKMBLMILFGG, DynamicBuffer<ChildrenData> DJHPOGLHKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x2019270", Offset = "0x2018270", VA = "0x182019270")]
			private void HFCPKGNPHGM(Entity OKMBLMILFGG, DynamicBuffer<ChildrenData> DJHPOGLHKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x2019110", Offset = "0x2018110", VA = "0x182019110", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct HEKFBJGDIAI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> GGCIOGALEGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> BIMGCBEFPGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> BMEKADFLAGP;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2C6BB00", Offset = "0x2C6AB00", VA = "0x182C6BB00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery LEHOJJNLEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery EGGBBEDLOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery HEPFNJAMNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery HJKDOAGBPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker FFONMNCAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker IIAMMLJJAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker GADOGOPBMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker MGOILBCBDNB;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x286CC40", Offset = "0x286BC40", VA = "0x18286CC40")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x286AC50", Offset = "0x2869C50", VA = "0x18286AC50")]
		private int BCMGAFLLCEJ(DynamicBuffer<ChildrenData> DJHPOGLHKJI, Entity PJEENOLDJIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x286C370", Offset = "0x286B370", VA = "0x18286C370")]
		private void NFHEJFHDAHL(Entity GJDECBBPLAI, Entity IDJGDIEPILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x78A6D0", Offset = "0x7896D0", VA = "0x18078A6D0", Slot = "14")]
		protected virtual EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x78A6D0", Offset = "0x7896D0", VA = "0x18078A6D0", Slot = "15")]
		protected virtual EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x78A6D0", Offset = "0x7896D0", VA = "0x18078A6D0", Slot = "16")]
		protected virtual EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x286C8D0", Offset = "0x286B8D0", VA = "0x18286C8D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x286BE50", Offset = "0x286AE50", VA = "0x18286BE50")]
		private void HEBEMMNGPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x286C1B0", Offset = "0x286B1B0", VA = "0x18286C1B0")]
		private void KELPDGDADFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x286B3F0", Offset = "0x286A3F0", VA = "0x18286B3F0")]
		private JobHandle GFMBNHDDEGH(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x286B110", Offset = "0x286A110", VA = "0x18286B110")]
		private void CDBMMMMAPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x286CB70", Offset = "0x286BB70", VA = "0x18286CB70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x23B8250", Offset = "0x23B7250", VA = "0x1823B8250", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public abstract class DDKJOGCAJFL : HCAPJDLAPMD, PFFHIJLFPMD
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct GADGPAJFCKD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> CMKIJDLHCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> FJDBOOKELJF;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x2C84370", Offset = "0x2C83370", VA = "0x182C84370")]
		public GADGPAJFCKD(NativeList<Entity> CMKIJDLHCPJ, NativeList<Entity> FJDBOOKELJF, JobHandle DGGOEPGELHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x2C842F0", Offset = "0x2C832F0", VA = "0x182C842F0")]
		public JobHandle HHNDJHENABI(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x2C84260", Offset = "0x2C83260", VA = "0x182C84260", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct JJCHODMOJME : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum HBJOHDNGEOA
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
		public NativeList<Entity> IFHCPOFNPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> DCNCJHHIEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> AILJIMCPJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> KLECGONBOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity PMPMNCKJAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity ACOOBAOKJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> MKDCAFODKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int PIHLADDNIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int GIOOIFAMJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private HBJOHDNGEOA LGANHOBMNJH;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x2C856C0", Offset = "0x2C846C0", VA = "0x182C856C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x2C85E80", Offset = "0x2C84E80", VA = "0x182C85E80")]
		private void NLIEMFCMBNK(Entity PJEENOLDJIO, bool DJLCOHNAEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x2C85850", Offset = "0x2C84850", VA = "0x182C85850")]
		private void FLJNJLIEKLI(Entity PJEENOLDJIO, bool DJLCOHNAEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x2C85D20", Offset = "0x2C84D20", VA = "0x182C85D20")]
		public GADGPAJFCKD MMNMKFJHIAB(NativeArray<Entity> NKLDGGPGPDP, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x2C85CA0", Offset = "0x2C84CA0", VA = "0x182C85CA0")]
		public GADGPAJFCKD LHIJGDGHKEE(NativeArray<Entity> NKLDGGPGPDP, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x2C85BC0", Offset = "0x2C84BC0", VA = "0x182C85BC0")]
		public GADGPAJFCKD KJOIMKJFHNC(NativeList<EJDOAJBNLAC> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x2C85F10", Offset = "0x2C84F10", VA = "0x182C85F10")]
		public GADGPAJFCKD ODJODPEDHNB(NativeList<EJDOAJBNLAC> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x2C85DA0", Offset = "0x2C84DA0", VA = "0x182C85DA0")]
		public GADGPAJFCKD NGJOOGCPOPK(NativeList<DFLCMAHAHIM> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CAA0", Offset = "0x2B8BAA0", VA = "0x182B8CAA0")]
		private GADGPAJFCKD GEHHGFMIJEJ<T>(NativeList<T> EHJGMBFBLBN, int IBMHHJLNPFA, int EHNCJMOMENA, HBJOHDNGEOA COAEGBJAHMB, JobHandle OFHDPBCPCFP) where T : struct
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x2C85960", Offset = "0x2C84960", VA = "0x182C85960")]
		private GADGPAJFCKD GEHHGFMIJEJ(NativeArray<Entity> GMAMPIGCEAB, int IBMHHJLNPFA, int EHNCJMOMENA, HBJOHDNGEOA COAEGBJAHMB, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery JDNBIOIEFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery JJOKIBGNMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private HPMBAGGHCAG JGEMJHLKEJL;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType HDOODGHOMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType ILDNNFHLDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType HOEGHECCJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2D27D80", Offset = "0x2D26D80", VA = "0x182D27D80")]
	protected DDKJOGCAJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2D26690", Offset = "0x2D25690", VA = "0x182D26690", Slot = "14")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2D26CE0", Offset = "0x2D25CE0", VA = "0x182D26CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2D26F10", Offset = "0x2D25F10", VA = "0x182D26F10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x809AA0", Offset = "0x808AA0", VA = "0x180809AA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2D26C80", Offset = "0x2D25C80", VA = "0x182D26C80")]
	private void NHJFEKPEAEB(NativeArray<Entity> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2D265F0", Offset = "0x2D255F0", VA = "0x182D265F0")]
	private void AFMLGMIHFOF(NativeArray<Entity> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2D26A30", Offset = "0x2D25A30", VA = "0x182D26A30")]
	private void LNLDDMCLLPN(GADGPAJFCKD KIEIMPAHGJC, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2D26B70", Offset = "0x2D25B70", VA = "0x182D26B70")]
	private void LNLDDMCLLPN(NativeListAsync<Entity> KCMICKABOHN, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2D26770", Offset = "0x2D25770", VA = "0x182D26770")]
	private void IIOAABNIJCO(GADGPAJFCKD KIEIMPAHGJC, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2D268B0", Offset = "0x2D258B0", VA = "0x182D268B0")]
	private void IIOAABNIJCO(NativeListAsync<Entity> KCMICKABOHN, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2D269C0", Offset = "0x2D259C0", VA = "0x182D269C0")]
	private bool JJCNIIHFHLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public class IKKOMIHLCNH : HCAPJDLAPMD, MIBCENMOHFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct EKGAOGAJFIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public IKKOMIHLCNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public EKGAOGAJFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MGAIOGIJIDI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct IAIIMLNMGKM
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct NCCCAIBNFOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime PBICDPDDPAN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CLHDCFAJKBJ;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x413CCB0", Offset = "0x413BCB0", VA = "0x18413CCB0")]
			public void LICMABLNMJG(IKKOMIHLCNH JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x413CCA0", Offset = "0x413BCA0", VA = "0x18413CCA0")]
			public NCCCAIBNFOL CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(NCCCAIBNFOL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public IKKOMIHLCNH PDCCJAEJIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer GMAKCDFJECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IAIIMLNMGKM PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IAIIMLNMGKM.NCCCAIBNFOL* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x4140AE0", Offset = "0x413FAE0", VA = "0x184140AE0")]
		internal void OCIBIOHOPKH(Entity CJDLKEIECEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x413CC30", Offset = "0x413BC30", VA = "0x18413CC30", Slot = "5")]
		public void ReadFromDisplayClass(ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x413CC60", Offset = "0x413BC60", VA = "0x18413CC60", Slot = "6")]
		public void WriteToDisplayClass(ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x4140970", Offset = "0x413F970", VA = "0x184140970", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x4140A30", Offset = "0x413FA30", VA = "0x184140A30")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref IAIIMLNMGKM.NCCCAIBNFOL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x4140AA0", Offset = "0x413FAA0", VA = "0x184140AA0")]
		public void LICMABLNMJG(IKKOMIHLCNH JFLOFOFLJIH, ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x41409C0", Offset = "0x413F9C0", VA = "0x1841409C0")]
		public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private KLEHOOKIDEL KDCGGMHBONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private IIEBHPDOOAI CDMLFNGLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery PHMILNFGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker LEDLMMODDCK;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x30E6390", Offset = "0x30E5390", VA = "0x1830E6390", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x30E6080", Offset = "0x30E5080", VA = "0x1830E6080", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x30E63F0", Offset = "0x30E53F0", VA = "0x1830E63F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public IKKOMIHLCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x30E62B0", Offset = "0x30E52B0", VA = "0x1830E62B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x30E60E0", Offset = "0x30E50E0", VA = "0x1830E60E0")]
	public static EntityQuery OHKMODGOEBN(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[CGJIBJMELLG]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public class JFABACOIMOP : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private IIEBHPDOOAI CDMLFNGLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService LKMIJPPNOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x30E79D0", Offset = "0x30E69D0", VA = "0x1830E79D0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x30E7A40", Offset = "0x30E6A40", VA = "0x1830E7A40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x30E7AE0", Offset = "0x30E6AE0", VA = "0x1830E7AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public JFABACOIMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct ONCPMHDBOJK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public FJFJJACADNC BDCLOJHOMDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF000", Offset = "0x6DE000", VA = "0x1806DF000")]
	public static ONCPMHDBOJK HEFILGHKDEM(in FJFJJACADNC HKKCKPMLCBB)
	{
		return default(ONCPMHDBOJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF000", Offset = "0x6DE000", VA = "0x1806DF000")]
	public static FJFJJACADNC HEFILGHKDEM(in ONCPMHDBOJK DFIOIBPHOGG)
	{
		return default(FJFJJACADNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class KLEHOOKIDEL : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x30ED430", Offset = "0x30EC430", VA = "0x1830ED430", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	public KLEHOOKIDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public class KHECNBBCLAJ : HCAPJDLAPMD, MIBCENMOHFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct PEBECNNPEEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public KHECNBBCLAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public PEBECNNPEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__0(Entity e, ONCPMHDBOJK ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HMKMJELOMFC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct KKDBLGPGFLE
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct ELBGFLFDFMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime PBICDPDDPAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<ONCPMHDBOJK>.Runtime OPJDKOKIEAG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CLHDCFAJKBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ONCPMHDBOJK> OLMCIGBACEL;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x413F480", Offset = "0x413E480", VA = "0x18413F480")]
			public void LICMABLNMJG(KHECNBBCLAJ JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x413F400", Offset = "0x413E400", VA = "0x18413F400")]
			public ELBGFLFDFMB CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(ELBGFLFDFMB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public KHECNBBCLAJ PDCCJAEJIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer GMAKCDFJECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private KKDBLGPGFLE PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KKDBLGPGFLE.ELBGFLFDFMB* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x413CB30", Offset = "0x413BB30", VA = "0x18413CB30")]
		internal void OCIBIOHOPKH(Entity CJDLKEIECEK, ONCPMHDBOJK MCOHFLALPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x413CC30", Offset = "0x413BC30", VA = "0x18413CC30", Slot = "5")]
		public void ReadFromDisplayClass(ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x413CC60", Offset = "0x413BC60", VA = "0x18413CC60", Slot = "6")]
		public void WriteToDisplayClass(ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x413C8E0", Offset = "0x413B8E0", VA = "0x18413C8E0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x413C9F0", Offset = "0x413B9F0", VA = "0x18413C9F0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref KKDBLGPGFLE.ELBGFLFDFMB KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x413CAA0", Offset = "0x413BAA0", VA = "0x18413CAA0")]
		public void LICMABLNMJG(KHECNBBCLAJ JFLOFOFLJIH, ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x413C980", Offset = "0x413B980", VA = "0x18413C980")]
		public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private KLEHOOKIDEL KDCGGMHBONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private IIEBHPDOOAI CDMLFNGLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery KMIJKLDDDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker GAMJNHIAMEJ;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x30ED160", Offset = "0x30EC160", VA = "0x1830ED160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x30ECE50", Offset = "0x30EBE50", VA = "0x1830ECE50", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x30ED1C0", Offset = "0x30EC1C0", VA = "0x1830ED1C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public KHECNBBCLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x30ED080", Offset = "0x30EC080", VA = "0x1830ED080", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x30ECEB0", Offset = "0x30EBEB0", VA = "0x1830ECEB0")]
	public static EntityQuery MOOEFBJFFNO(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct AEPBCEGDJLK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public DLGLKFHNPHN GAICKEELBKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, ADEHAJBPFKB> GMAMPIGCEAB;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x4137710", Offset = "0x4136710", VA = "0x184137710")]
			public AEPBCEGDJLK(int KNECCHHDDJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x4137690", Offset = "0x4136690", VA = "0x184137690", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct JFLPFEGAGFD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> OFKJNJJCIHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x413EC70", Offset = "0x413DC70", VA = "0x18413EC70", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct JEEPPFGCGLG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x413EB20", Offset = "0x413DB20", VA = "0x18413EB20", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private IIEBHPDOOAI CDMLFNGLMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery FLFAHDIJBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery PILILPMNLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery BOJHPFBLLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery BBDPCGGCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery OKGFDONJGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle HOAIOMLIELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private AEPBCEGDJLK NPGIJABHKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private AEPBCEGDJLK KEBECABJLKD;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFE90", Offset = "0x2ABEE90", VA = "0x182ABFE90", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2AC01A0", Offset = "0x2ABF1A0", VA = "0x182AC01A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0020", Offset = "0x2ABF020", VA = "0x182AC0020", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0460", Offset = "0x2ABF460", VA = "0x182AC0460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0060", Offset = "0x2ABF060", VA = "0x182AC0060")]
		private void MNDENFIBNEM(EntityQuery APEJLGJADFF, out (NativeArrayAsync<ONCPMHDBOJK> handles, NativeArrayAsync<DFOPMDEEAAA> bounds) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF7E0", Offset = "0x2ABE7E0", VA = "0x182ABF7E0")]
		private void CCIMKGPMDNM((NativeArrayAsync<ONCPMHDBOJK> handles, NativeArrayAsync<DFOPMDEEAAA> bounds) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0020", Offset = "0x2ABF020", VA = "0x182AC0020")]
		private void LGCNMJHCEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF6A0", Offset = "0x2ABE6A0", VA = "0x182ABF6A0")]
		private void BMBFJAAODMM(EntityQuery APEJLGJADFF, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<ONCPMHDBOJK> handles) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFA40", Offset = "0x2ABEA40", VA = "0x182ABFA40")]
		private void FNKHJHKJGLE((NativeArrayAsync<Entity> entities, NativeArrayAsync<ONCPMHDBOJK> handles) FNIHENPLJHK, AEPBCEGDJLK FBPIKFEBIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFD30", Offset = "0x2ABED30", VA = "0x182ABFD30")]
		private JobHandle JIBKGIOKBBD(AEPBCEGDJLK FBPIKFEBIAF, ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM, ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG, ComponentDataFromEntity<WorldDeformableScaleData> OFKJNJJCIHM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFEF0", Offset = "0x2ABEEF0", VA = "0x182ABFEF0")]
		private JobHandle KPKDFHOAADN(AEPBCEGDJLK FBPIKFEBIAF, ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM, ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct EKCGCMDCEBE : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CGJIBJMELLG]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public class SplineLocalBoundsSystem : HCAPJDLAPMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct BMOOGOGOMEB : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> MOCLMKPEOGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> GDFFLMNBLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<DFOPMDEEAAA> FLCAONNMHJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, ADEHAJBPFKB>.ParallelWriter DJKGKMDDNEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HFCGAMNKKIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter PLDBMCGFBBF;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x41394F0", Offset = "0x41384F0", VA = "0x1841394F0", Slot = "4")]
			public void Execute(int EGBCAPEEJBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct IFLJNLGDEFF : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> IOKNPIMKJFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> DHCPBNMAOGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> EDBNNBFNOCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> FMEAIJLKJAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DFOPMDEEAAA> ANBKLLFNHAG;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x413CCC0", Offset = "0x413BCC0", VA = "0x18413CCC0", Slot = "4")]
			public void Execute(int EGBCAPEEJBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery BHBNHOJFOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery BEAJEMCHGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery ILMCKFKJMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery JJANMDMGFGN;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2C90AF0", Offset = "0x2C8FAF0", VA = "0x182C90AF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2C90D00", Offset = "0x2C8FD00", VA = "0x182C90D00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2C906F0", Offset = "0x2C8F6F0", VA = "0x182C906F0")]
		private JobHandle LNNFIAPGKKB(NativeArrayAsync<Entity> EGIDMCNFHCK, int GDDNEEFIBDF, JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2C90510", Offset = "0x2C8F510", VA = "0x182C90510")]
		private JobHandle LNNFIAPGKKB(NativeArray<Entity> HFIBNNPNLKF, int GDDNEEFIBDF, [Optional] JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2C90160", Offset = "0x2C8F160", VA = "0x182C90160")]
		private NativeArrayAsync<Entity> APCKJNJHEBA(EntityQuery APEJLGJADFF)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2C91220", Offset = "0x2C90220", VA = "0x182C91220")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) PHBPMPDPOEH(NativeArrayAsync<Entity> KGOLNHMMNBM)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2C90A60", Offset = "0x2C8FA60", VA = "0x182C90A60")]
		private void ONHNIDAHGMD(out NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2C908A0", Offset = "0x2C8F8A0", VA = "0x182C908A0")]
		private void MIOPNBKJLGK(NativeList<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2C907D0", Offset = "0x2C8F7D0", VA = "0x182C907D0")]
		private void MIOPNBKJLGK(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2C90930", Offset = "0x2C8F930", VA = "0x182C90930")]
		private void NHGFEDCDHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void IDHIHKCJOFD(int IHACKODNHGG, int MJBICGGKNIG, int HNOHGDAJGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2C901E0", Offset = "0x2C8F1E0", VA = "0x182C901E0")]
		private static DFOPMDEEAAA BJFFIJOAHGK(NativeArray<Entity> MDHAPBKCBBF, ComponentDataFromEntity<SplinePointPositionData> EDBNNBFNOCO, ComponentDataFromEntity<SplinePointScaleData> FMEAIJLKJAN)
		{
			return default(DFOPMDEEAAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct GFCCACBJBOL : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CGJIBJMELLG]
	[OHGELDJCNJM(GGAOONGBEBH.Lifecycle)]
	public class DestroyLocalObjects : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[JOODLPJEDOA]
		private ObjectNetworkToLocalMapService OAKEGNELFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[JOODLPJEDOA]
		private ObjectLifecycleService HDOHKKMKDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery DEJEKIMIOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery INMBHJPHJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery OINLNJKBILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D29AE0", Offset = "0x2D28AE0", VA = "0x182D29AE0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D297A0", Offset = "0x2D287A0", VA = "0x182D297A0")]
		public bool DAHFHGFHPCJ(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D29C00", Offset = "0x2D28C00", VA = "0x182D29C00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D29AA0", Offset = "0x2D28AA0", VA = "0x182D29AA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D29D30", Offset = "0x2D28D30", VA = "0x182D29D30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4E00", Offset = "0x1CF3E00", VA = "0x181CF4E00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D29AA0", Offset = "0x2D28AA0", VA = "0x182D29AA0")]
		private void GCELLLDPPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D29B50", Offset = "0x2D28B50", VA = "0x182D29B50")]
		private void OPEJIMPAIHH(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D29850", Offset = "0x2D28850", VA = "0x182D29850")]
		private void FGHBEEJDDME(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D29990", Offset = "0x2D28990", VA = "0x182D29990")]
		private void GAKJMOCPHOD(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D29680", Offset = "0x2D28680", VA = "0x182D29680")]
		private void AHLGMHDFGHG(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[OHGELDJCNJM(GGAOONGBEBH.NetworkSend)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static ENGIDADGGAI[] ANIBADBJCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private PEOICOFJGJK CPLBCEOBLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private PABMDGDAPHJ NICBODAHBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService MCOMNCLENIC;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x30D5E50", Offset = "0x30D4E50", VA = "0x1830D5E50", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x30D6490", Offset = "0x30D5490", VA = "0x1830D6490", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x30D5F00", Offset = "0x30D4F00", VA = "0x1830D5F00")]
		private void LECPEIKJNEP(ENGIDADGGAI LPKJFCDGPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private void ANCMENMABOC(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD, GJOKNGAFGLP LPPHHGKFEEH, MEGNPFABGGE BPLHNLGGGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[OHGELDJCNJM(GGAOONGBEBH.Callbacks)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public sealed class PropertyEventCallbacks : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService CBBILOOJOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService MCOMNCLENIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase LPKJFCDGPPB;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC61B0", Offset = "0x2AC51B0", VA = "0x182AC61B0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6240", Offset = "0x2AC5240", VA = "0x182AC6240", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[OHGELDJCNJM(GGAOONGBEBH.NetworkSend)]
	internal class TransmitNetworkDataSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private OHFKOIDMPOO ABFECNENKKJ;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C98550", Offset = "0x2C97550", VA = "0x182C98550", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C985A0", Offset = "0x2C975A0", VA = "0x182C985A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CGJIBJMELLG]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public class CalculateCullingBandChanges : HCAPJDLAPMD, JMMCIOGFDJD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct ODIMILPBFOG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType LJHOGCNCCNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> DCMAPMGLICP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<ODILOCJODCG>.ParallelWriter NKLMAJJPODG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<NGMDCDBMMCD> DPLNILHJOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 NMAMPMADCBK;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 MEMMAEIBOAB;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 KJBLACPLHOA;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 BPNNANFBMEI;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C876F0", Offset = "0x2C866F0", VA = "0x182C876F0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int CFOGNPEDIOM = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double GEMPLNKHPFL = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery MLAKIOPMEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery INHNADGBBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double EGDKFAAOKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService HNLBGFINPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService KLKIAHEMFFM;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AC80", Offset = "0x2D19C80", VA = "0x182D1AC80", Slot = "14")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AC90", Offset = "0x2D19C90", VA = "0x182D1AC90", Slot = "15")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AD20", Offset = "0x2D19D20", VA = "0x182D1AD20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AE70", Offset = "0x2D19E70", VA = "0x182D1AE70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B090", Offset = "0x2D1A090", VA = "0x182D1B090")]
		private bool PKOJOGDDNEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A940", Offset = "0x2D19940", VA = "0x182D1A940")]
		private void FJGFAOGAOED(EntityQuery APEJLGJADFF, float3 EMEAMHLICPL, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct ODILOCJODCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity PJEENOLDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public CBFJMCFAKAM ENFEPLFMJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public CBFJMCFAKAM IEFBANIHOGG;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public class ProcessCullingBandChangeCallbacks : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService HNLBGFINPPC;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2DF0", Offset = "0x2AC1DF0", VA = "0x182AC2DF0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2E40", Offset = "0x2AC1E40", VA = "0x182AC2E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[OHGELDJCNJM(GGAOONGBEBH.Connectables)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class UpdateInertialProperties : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery PKBFPODAHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private FKBFBGACCHL BGIKAMDKFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EF60", Offset = "0x2C9DF60", VA = "0x182C9EF60", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EFD0", Offset = "0x2C9DFD0", VA = "0x182C9EFD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F060", Offset = "0x2C9E060", VA = "0x182C9F060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CGJIBJMELLG]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JDDLEIBEKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JHNPPEHGHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KGGBKABDBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService GPFFPFMPFKM;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x30D5730", Offset = "0x30D4730", VA = "0x1830D5730", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x30D5800", Offset = "0x30D4800", VA = "0x1830D5800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x30D4DF0", Offset = "0x30D3DF0", VA = "0x1830D4DF0")]
		private void FDAKLCEAJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EHJGMBFBLBN, EntityQueryDesc ICENFFJJEBG, bool MMACFBGEFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x30D4F00", Offset = "0x30D3F00", VA = "0x1830D4F00")]
		private void FDAKLCEAJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EHJGMBFBLBN, EntityQueryDesc ICENFFJJEBG, bool MMACFBGEFCH, bool FJHEIJDCBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x30D5A60", Offset = "0x30D4A60", VA = "0x1830D5A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x30D4A00", Offset = "0x30D3A00", VA = "0x1830D4A00")]
		private void AMHGNHLMFNN(EntityQuery APEJLGJADFF, bool EOGLAAENHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x30D5300", Offset = "0x30D4300", VA = "0x1830D5300")]
		private void INFBEAMFJHG(EntityQuery APEJLGJADFF, bool LMDHKCKFPPO, bool EOGLAAENHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x30D5510", Offset = "0x30D4510", VA = "0x1830D5510")]
		private void JDBNKAABPGA(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x30D4C80", Offset = "0x30D3C80", VA = "0x1830D4C80")]
		private void EOFLEAFFCKN(NativeList<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x30D51E0", Offset = "0x30D41E0", VA = "0x1830D51E0")]
		private void HDOEENDDIGA(NativeArray<Entity> GMAMPIGCEAB, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x30D4800", Offset = "0x30D3800", VA = "0x1830D4800")]
		private NativeList<Entity> ALCFPHIEPAM(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x30D57C0", Offset = "0x30D47C0", VA = "0x1830D57C0")]
		private NativeList<Entity> MOHBBPBJPAC(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x30D5780", Offset = "0x30D4780", VA = "0x1830D5780")]
		private NativeList<Entity> KFCBPGOIOCC(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x30D5040", Offset = "0x30D4040", VA = "0x1830D5040")]
		private NativeList<Entity> GNBIAIPGIPD(NativeArray<Entity> GMAMPIGCEAB, bool MLALFFLGLGA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x30D4BF0", Offset = "0x30D3BF0", VA = "0x1830D4BF0")]
		private EPMKAAKOKHK BNOBLHNNDHL(NativeArray<Entity> GMAMPIGCEAB)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(EPMKAAKOKHK);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x30D5D80", Offset = "0x30D4D80", VA = "0x1830D5D80")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService GPFFPFMPFKM;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2E60", Offset = "0x2AC1E60", VA = "0x182AC2E60", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2EB0", Offset = "0x2AC1EB0", VA = "0x182AC2EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : MKDLICHFONK
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery GHCAEMACAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery EDIBJMDELFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery HIILHFCNAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery PADHMGBGPJI;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D292F0", Offset = "0x2D282F0", VA = "0x182D292F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D294B0", Offset = "0x2D284B0", VA = "0x182D294B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D28E70", Offset = "0x2D27E70", VA = "0x182D28E70")]
		private void IMNGGODJJMA(EntityQuery APEJLGJADFF, bool LOGAOEPCLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D290B0", Offset = "0x2D280B0", VA = "0x182D290B0")]
		private void OEANHLNOPBH(EntityQuery APEJLGJADFF, bool LOGAOEPCLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class AssignPlayerIdsSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery OKFPHBOLGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery DDHHHMMBIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService KPCHKHEBGLC;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D13550", Offset = "0x2D12550", VA = "0x182D13550", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D13C70", Offset = "0x2D12C70", VA = "0x182D13C70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D13D80", Offset = "0x2D12D80", VA = "0x182D13D80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D139F0", Offset = "0x2D129F0", VA = "0x182D139F0")]
		private void OCAGKEDDIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D13B00", Offset = "0x2D12B00", VA = "0x182D13B00")]
		private void OLGAMBNKJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D136D0", Offset = "0x2D126D0", VA = "0x182D136D0")]
		private void OAINHJLOHDI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D133B0", Offset = "0x2D123B0", VA = "0x182D133B0")]
		private void ANPHNIDNPMP(NativeArray<Entity> GMAMPIGCEAB, int MLDPHJMEGHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D135C0", Offset = "0x2D125C0", VA = "0x182D135C0")]
		private void MPANPINBHOK(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D134F0", Offset = "0x2D124F0", VA = "0x182D134F0")]
		private void FOFAGLLEEJI(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void DGGMPLPPLMA(int HIFBLLMBEPO, Transform PKIKNDCFAFJ, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class LICJKBGILLD
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA68D0", Offset = "0x2AA58D0", VA = "0x182AA68D0")]
	public static bool BEFKHAFPILH(this SystemBase NGCKCOHKMBE, out Entity PJEENOLDJIO)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery DJJJLLNDBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EHCGNDKDHFM KPIKOBDHDMH;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CA30", Offset = "0x2D1BA30", VA = "0x182D1CA30", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CA80", Offset = "0x2D1BA80", VA = "0x182D1CA80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CB40", Offset = "0x2D1BB40", VA = "0x182D1CB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<FAKLDAPDBLB>, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string ALNFNCPENGD = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private HBMNANFILGC PPCKCAIAOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery JPBLIABFEAI;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity OLOLFNHGAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8ED0", Offset = "0x2AA7ED0", VA = "0x182AA8ED0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8D10", Offset = "0x2AA7D10", VA = "0x182AA8D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity BJNFIFJNIOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8B50", Offset = "0x2AA7B50", VA = "0x182AA8B50")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public GPEJGMHBDPO KPMACBBGDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8F30", Offset = "0x2AA7F30", VA = "0x182AA8F30")]
			get
			{
				return default(GPEJGMHBDPO);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8890", Offset = "0x2AA7890", VA = "0x182AA8890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public GPEJGMHBDPO MIGEIOLOIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8A50", Offset = "0x2AA7A50", VA = "0x182AA8A50")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8DB0", Offset = "0x2AA7DB0", VA = "0x182AA8DB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8AE0", Offset = "0x2AA7AE0", VA = "0x182AA8AE0", Slot = "15")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8E50", Offset = "0x2AA7E50", VA = "0x182AA8E50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8900", Offset = "0x2AA7900", VA = "0x182AA8900", Slot = "14")]
		protected override void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8BB0", Offset = "0x2AA7BB0", VA = "0x182AA8BB0")]
		private void KGKBKLCDBCM(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2AA85A0", Offset = "0x2AA75A0", VA = "0x182AA85A0")]
		private void BDDJMMHOFNI(Entity PJEENOLDJIO, Entity JCOHCMAHJBI, Entity ILGBJHAFEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x22339D0", Offset = "0x22329D0", VA = "0x1822339D0")]
		private bool LEDONIKBHEA<T>(out T KPPLMEOMNGF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2233A60", Offset = "0x2232A60", VA = "0x182233A60")]
		private void OGNINEINMEG<T>(T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8C90", Offset = "0x2AA7C90", VA = "0x182AA8C90")]
		public bool KPILHKEKFNF(GPEJGMHBDPO JEKPLGHLKLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8860", Offset = "0x2AA7860", VA = "0x182AA8860")]
		private static bool GDDJHAIALKN(GPEJGMHBDPO FHHOOPJNCAN, GPEJGMHBDPO AFKEDDEKEKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9010", Offset = "0x2AA8010", VA = "0x182AA9010")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D70", Offset = "0x2AA7D70", VA = "0x182AA8D70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2D25020", Offset = "0x2D24020", VA = "0x182D25020", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2D25070", Offset = "0x2D24070", VA = "0x182D25070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2D25110", Offset = "0x2D24110", VA = "0x182D25110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2D24DC0", Offset = "0x2D23DC0", VA = "0x182D24DC0")]
		private NativeArray<Entity> GFHFIDHIMFA(int KJAHKKMJHHG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2D24F10", Offset = "0x2D23F10", VA = "0x182D24F10")]
		private void JEJNMBJPOOK(NativeArray<Entity> NLPMPLFDPEN, NativeArray<Entity> DLNKIPKCMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	internal class HideRemotePivotsNotInScope : HCAPJDLAPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery FNMCBBJALNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery ECIIFAAAHMK;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x30E2C90", Offset = "0x30E1C90", VA = "0x1830E2C90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x30E2D80", Offset = "0x30E1D80", VA = "0x1830E2D80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class CFGABCJANPL
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string MCCGGAHBCIK = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x2833BC0", Offset = "0x2832BC0", VA = "0x182833BC0")]
	public static NativeArray<T> GEHHGFMIJEJ<T>(NativeArray<Entity> GMAMPIGCEAB, EntityManager JGDEKKJFKAJ) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2D189B0", Offset = "0x2D179B0", VA = "0x182D189B0")]
	public static void AIKMKNJPOIC(EntityQuery APEJLGJADFF, EntityManager JGDEKKJFKAJ, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2D18C20", Offset = "0x2D17C20", VA = "0x182D18C20")]
	public static void POHPIDDFNMB(NativeArray<Entity> NLPMPLFDPEN, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2D18AF0", Offset = "0x2D17AF0", VA = "0x182D18AF0")]
	public static void JCJOPINMGNG(NativeArray<Entity> NLPMPLFDPEN, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService HDOHKKMKDMB;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E500", Offset = "0x2C9D500", VA = "0x182C9E500", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EE60", Offset = "0x2C9DE60", VA = "0x182C9EE60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EF00", Offset = "0x2C9DF00", VA = "0x182C9EF00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D500", Offset = "0x2C9C500", VA = "0x182C9D500")]
		private void AEIJLFBMOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DD10", Offset = "0x2C9CD10", VA = "0x182C9DD10")]
		private void DNHEALBDPIJ(NativeArray<Entity> NLPMPLFDPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D590", VA = "0x182C9E590")]
		private void LOLOAIAJFIO(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DE20", Offset = "0x2C9CE20", VA = "0x182C9DE20")]
		private void GJALCBPPEEJ(NativeArray<Entity> DLNKIPKCMPA, NativeArray<RigidTransform> APBAKONFHJF, NativeArray<RigidTransform> DHMONBDMIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E070", Offset = "0x2C9D070", VA = "0x182C9E070")]
		private void GMJAEPCGKON(NativeArray<RigidTransform> DHMONBDMIGL, NativeArray<Entity> DLNKIPKCMPA, NativeList<Entity> EHELFJGPLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class PostGameplayOnScopeChange : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery DJJJLLNDBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery CCHEKGIBOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1400", Offset = "0x2AC0400", VA = "0x182AC1400", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1470", Offset = "0x2AC0470", VA = "0x182AC1470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2AC15C0", Offset = "0x2AC05C0", VA = "0x182AC15C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1390", Offset = "0x2AC0390", VA = "0x182AC1390")]
		private void CLHKKCKBGPE(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal class PreventDisembodiedScopesSystem : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery LEHEFHIFMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents OCFBEMCGNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private EHCGNDKDHFM KPIKOBDHDMH;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2C60", Offset = "0x2AC1C60", VA = "0x182AC2C60", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2CF0", Offset = "0x2AC1CF0", VA = "0x182AC2CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2D90", Offset = "0x2AC1D90", VA = "0x182AC2D90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2AD0", Offset = "0x2AC1AD0", VA = "0x182AC2AD0")]
		private void GFHIHMIOGLP(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<GNMBOLPJNCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2C89300", Offset = "0x2C88300", VA = "0x182C89300", Slot = "14")]
		protected override void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2C89230", Offset = "0x2C88230", VA = "0x182C89230")]
		[BurstCompile]
		private static void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> GPMOJKJNJPH, ComponentDataFromEntity<global::PMDPALLMDFD> FFLKNEGJGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2C89490", Offset = "0x2C88490", VA = "0x182C89490")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2C89450", Offset = "0x2C88450", VA = "0x182C89450", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[OHGELDJCNJM(GGAOONGBEBH.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : HCAPJDLAPMD where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery NPJAICLPBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery JCMNNALLNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery FBECDOPHMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery KCMLDPCDIGL;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x302C260", Offset = "0x302B260", VA = "0x18302C260", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x302C630", Offset = "0x302B630", VA = "0x18302C630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x302C600", Offset = "0x302B600", VA = "0x18302C600", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x302B9E0", Offset = "0x302A9E0", VA = "0x18302B9E0")]
		private void NEBPAFFGLCE(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x302A960", Offset = "0x3029960", VA = "0x18302A960")]
		private void ADNAFCGMIMI(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x302B140", Offset = "0x302A140", VA = "0x18302B140")]
		private void HJIBJBIHKEM(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x302C6C0", Offset = "0x302B6C0", VA = "0x18302C6C0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x1116540", Offset = "0x1115540", VA = "0x181116540", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class JLGDKJGFNPK : HCAPJDLAPMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> OCJMBDKKCEH;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x30E8940", Offset = "0x30E7940", VA = "0x1830E8940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x30E8B40", Offset = "0x30E7B40", VA = "0x1830E8B40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x30E8C90", Offset = "0x30E7C90", VA = "0x1830E8C90")]
	public JLGDKJGFNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct GIAOKBBLBMM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int NOAKOLDJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int CONDCHODOCK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD570", Offset = "0x2ABC570", VA = "0x182ABD570")]
	public static Entity HEFILGHKDEM(GIAOKBBLBMM FNIHENPLJHK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD570", Offset = "0x2ABC570", VA = "0x182ABD570")]
	public static GIAOKBBLBMM HEFILGHKDEM(Entity PJEENOLDJIO)
	{
		return default(GIAOKBBLBMM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct CGMBJJIMEIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct IDEGAILMGHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType DDFJPMOIHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> CAHDBKNLLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> GCNEFCAOPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> GMAMPIGCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> LJDCHIOFGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> KCDBOIAJNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> IMFNGEBEPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int ODDNJFFKMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int CPFNENOGHKI;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool HEDHMAMHPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x30E5A50", Offset = "0x30E4A50", VA = "0x1830E5A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x30E5C50", Offset = "0x30E4C50", VA = "0x1830E5C50")]
	public IDEGAILMGHG(ComponentType DDFJPMOIHNM, NativeList<int> CAHDBKNLLCN, NativeList<int> GCNEFCAOPJG, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> LJDCHIOFGBL, NativeArray<byte> KCDBOIAJNCE, NativeArray<byte> IMFNGEBEPMB, int ODDNJFFKMJI, int CPFNENOGHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x30E5830", Offset = "0x30E4830", VA = "0x1830E5830")]
	private MPOLKMCKMLM BHOHMNGIMHN(NativeArray<byte> EGIDMCNFHCK, int EGBCAPEEJBF)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T BHOHMNGIMHN<T>(NativeArray<byte> EGIDMCNFHCK, int EGBCAPEEJBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x30E5AD0", Offset = "0x30E4AD0", VA = "0x1830E5AD0")]
	public MPOLKMCKMLM CPFCIMKMDGD(int EGBCAPEEJBF)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T CPFCIMKMDGD<T>(int EGBCAPEEJBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x30E5C00", Offset = "0x30E4C00", VA = "0x1830E5C00")]
	public MPOLKMCKMLM GBMCGEANOPK(int EGBCAPEEJBF)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T GBMCGEANOPK<T>(int EGBCAPEEJBF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x30E5B20", Offset = "0x30E4B20", VA = "0x1830E5B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct JPEEACBJEJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<HJMJEPLELOA> ICBILMELIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType DDFJPMOIHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int ODDNJFFKMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int CPFNENOGHKI;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x30EA040", Offset = "0x30E9040", VA = "0x1830EA040")]
	public JPEEACBJEJB(ComponentType DDFJPMOIHNM, int ODDNJFFKMJI, int CPFNENOGHKI, EntityQuery APEJLGJADFF, NativeArray<HJMJEPLELOA> ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x30E9FF0", Offset = "0x30E8FF0", VA = "0x1830E9FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct NEEMIEDAPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int EGBCAPEEJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int CCFMNAFFFKC;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
	public NEEMIEDAPCM(int EGBCAPEEJBF, int CCFMNAFFFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct HJMJEPLELOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int LKCJJEBACFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int MKMGHJFMNMB;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
	public HJMJEPLELOA(int LKCJJEBACFP, int MKMGHJFMNMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct MEGNPFABGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly BPHAMHGLCNC CLOAPFCHKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int ODDNJFFKMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* KCDBOIAJNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* IMFNGEBEPMB;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2AA94B0", Offset = "0x2AA84B0", VA = "0x182AA94B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public BPHAMHGLCNC FOEPHKKCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40")]
		get
		{
			return default(BPHAMHGLCNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2AA92D0", Offset = "0x2AA82D0", VA = "0x182AA92D0")]
	public MPOLKMCKMLM BFEJHELLIAA(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2AA93C0", Offset = "0x2AA83C0", VA = "0x182AA93C0")]
	public MPOLKMCKMLM PDJLJJCOAFF(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2236920", Offset = "0x2235920", VA = "0x182236920")]
	public T BFEJHELLIAA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x2236940", Offset = "0x2235940", VA = "0x182236940")]
	public T PDJLJJCOAFF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x2AA94C0", Offset = "0x2AA84C0", VA = "0x182AA94C0")]
	public unsafe MEGNPFABGGE(BPHAMHGLCNC CLOAPFCHKDE, int MKMGHJFMNMB, byte* KCDBOIAJNCE, byte* IMFNGEBEPMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class JGLHBDCLLEO : FMHBHMFLMCD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService MCOMNCLENIC;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract ENGIDADGGAI KBACBHDMBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x30E7E30", Offset = "0x30E6E30", VA = "0x1830E7E30", Slot = "17")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x30E80C0", Offset = "0x30E70C0", VA = "0x1830E80C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x30E7E80", Offset = "0x30E6E80", VA = "0x1830E7E80", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	protected JGLHBDCLLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class LJJBDDBGAMP
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] JGPNLMJLELO;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class KDNHCONPDAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, JPEEACBJEJB> JGHKHMIKDHP;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public JPEEACBJEJB IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x30EB120", Offset = "0x30EA120", VA = "0x1830EB120")]
		get
		{
			return default(JPEEACBJEJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x30EBAC0", Offset = "0x30EAAC0", VA = "0x1830EBAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x30EBB80", Offset = "0x30EAB80", VA = "0x1830EBB80")]
	public KDNHCONPDAI(EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x30EBB10", Offset = "0x30EAB10", VA = "0x1830EBB10")]
	public bool OHBANFGHGGE(ComponentType DDFJPMOIHNM, out JPEEACBJEJB ADOLOEKMGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x30EBA30", Offset = "0x30EAA30", VA = "0x1830EBA30")]
	public Dictionary<ComponentType, JPEEACBJEJB>.Enumerator KGLEFCHHJJI()
	{
		return default(Dictionary<ComponentType, JPEEACBJEJB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x30EB3E0", Offset = "0x30EA3E0", VA = "0x1830EB3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x30EB580", Offset = "0x30EA580", VA = "0x1830EB580")]
	private void GJNMIPMPDLB(IEnumerable<GBOCHCBEADE> BMIKDMDNIPC, EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x30EB980", Offset = "0x30EA980", VA = "0x1830EB980")]
	private static int HIFKHPIAFOH(GBOCHCBEADE JFILCDKBAEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x30EB1B0", Offset = "0x30EA1B0", VA = "0x1830EB1B0")]
	private static NativeArray<HJMJEPLELOA> DGPPIPEBLEF(GBOCHCBEADE JFILCDKBAEE, Allocator GOLNHBOGNGC = Allocator.Persistent)
	{
		return default(NativeArray<HJMJEPLELOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface ADIGHOEHBBA
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool HEDHMAMHPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBOBIGCFGHE(out NativeArray<int> CJNALNIEFIB, Allocator GOLNHBOGNGC);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBGEDLDAOHM(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH, out JPEEACBJEJB JJPMEEGFFGM);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GBGEDLDAOHM(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDEGAILMGHG OEPMEDEBCIM(ComponentType DDFJPMOIHNM);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DLBHGBHCIGG MIBCGNPMMLC();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MLGBJBPAEJL(JobHandle DGGOEPGELHE);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
internal interface BFHHLLCINGL
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	KDNHCONPDAI HNMCOECENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	NFFGAJCCLIN CAGOAEBCCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, MEGNPFABGGE> IJKJIGMJNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle MGDEGEAPBHM
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
	bool MGAGAAKAIAK();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPEOCMBDEPF();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IIHGABPFGLH(ComponentType DDFJPMOIHNM, in IDEGAILMGHG GFJDKJPDPGE);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IFPMJMJFDAJ(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct DLBHGBHCIGG
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct IKOJPKACCMB : IEnumerator<MEGNPFABGGE>, IEnumerator, IDisposable, IEnumerable<MEGNPFABGGE>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, MEGNPFABGGE> MOBIBCNEEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity PJEENOLDJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> BLBMJEOJNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private MEGNPFABGGE IMFNGEBEPMB;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public MEGNPFABGGE AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xCD6D30", Offset = "0xCD5D30", VA = "0x180CD6D30", Slot = "4")]
			get
			{
				return default(MEGNPFABGGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2C853E0", Offset = "0x2C843E0", VA = "0x182C853E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2C85430", Offset = "0x2C84430", VA = "0x182C85430")]
		internal IKOJPKACCMB(NativeMultiHashMap<Entity, MEGNPFABGGE> MOBIBCNEEOL, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2C851D0", Offset = "0x2C841D0", VA = "0x182C851D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2C851A0", Offset = "0x2C841A0", VA = "0x182C851A0")]
		public IKOJPKACCMB KGLEFCHHJJI()
		{
			return default(IKOJPKACCMB);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2C852A0", Offset = "0x2C842A0", VA = "0x182C852A0", Slot = "9")]
		private IEnumerator<MEGNPFABGGE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2C85340", Offset = "0x2C84340", VA = "0x182C85340", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly BFHHLLCINGL KFCHBPFAEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle APGGDPBCICD;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int CGMPOHAIBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2D28740", Offset = "0x2D27740", VA = "0x182D28740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2D28660", Offset = "0x2D27660", VA = "0x182D28660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x20A55C0", Offset = "0x20A45C0", VA = "0x1820A55C0")]
	public DLBHGBHCIGG(BFHHLLCINGL KFCHBPFAEMJ, JobHandle APGGDPBCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2D28830", Offset = "0x2D27830", VA = "0x182D28830")]
	public bool NPDCHEEKIJH(Allocator GOLNHBOGNGC, out NativeKeyValueArrays<Entity, MEGNPFABGGE> GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2D28970", Offset = "0x2D27970", VA = "0x182D28970")]
	public bool OCLKKJPHBMC(Allocator GOLNHBOGNGC, out (NativeArray<Entity> entities, int uniqueCount) GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2D28540", Offset = "0x2D27540", VA = "0x182D28540")]
	public IKOJPKACCMB HFFGDFHOLLM(Entity PJEENOLDJIO)
	{
		return default(IKOJPKACCMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class NFFGAJCCLIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<JPEEACBJEJB> EHJGMBFBLBN;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public JPEEACBJEJB IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC600", Offset = "0x2AAB600", VA = "0x182AAC600")]
		get
		{
			return default(JPEEACBJEJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2AACBD0", Offset = "0x2AABBD0", VA = "0x182AACBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2AACC10", Offset = "0x2AABC10", VA = "0x182AACC10")]
	public NFFGAJCCLIN(KDNHCONPDAI JGHKHMIKDHP, EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x2AACB50", Offset = "0x2AABB50", VA = "0x182AACB50")]
	public List<JPEEACBJEJB>.Enumerator KGLEFCHHJJI()
	{
		return default(List<JPEEACBJEJB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC690", Offset = "0x2AAB690", VA = "0x182AAC690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC810", Offset = "0x2AAB810", VA = "0x182AAC810")]
	private void GJNMIPMPDLB(KDNHCONPDAI JGHKHMIKDHP, EntityManager JGDEKKJFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class OMEHKNGHBDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService APEJINPFNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::FOIBHJLLDAJ<GBOCHCBEADE> FCJJBPFOFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World HEEDGNMHMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> FIKOJDOGPAI;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0B10", Offset = "0x2AAFB10", VA = "0x182AB0B10")]
	public OMEHKNGHBDB(ObjectInstantiationService APEJINPFNBH, EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFFA0", Offset = "0x2AAEFA0", VA = "0x182AAFFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0360", Offset = "0x2AAF360", VA = "0x182AB0360")]
	public bool GOIDOBEHMKN(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF840", Offset = "0x2AAE840", VA = "0x182AAF840")]
	private void CACLJONLPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF1A0", Offset = "0x2AAE1A0", VA = "0x182AAF1A0")]
	private EntityArchetype BBDFPHMMLMC(EntityArchetype AJNNHCKHNHJ)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB06E0", Offset = "0x2AAF6E0", VA = "0x182AB06E0")]
	public static void OJBBADHIPIG(EntityManager ABFDLFMHAJL, EntityManager LKAGEFPMCDG, NativeArray<Entity> INCINPMOBBH, NativeArray<EntityArchetype> BLPNOFOBPBN, [Optional] NativeArray<Entity> PGJHMFMABMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF6D0", Offset = "0x2AAE6D0", VA = "0x182AAF6D0")]
	[Conditional("DEBUG_BUILD")]
	private static void BIKKEHKAHIB(NativeArray<EntityArchetype> HGMIABMNLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB03C0", Offset = "0x2AAF3C0", VA = "0x182AB03C0")]
	private static string HADDKMAPJJJ(EntityArchetype GOEEEEBMLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0070", Offset = "0x2AAF070", VA = "0x182AB0070")]
	[CompilerGenerated]
	internal static void FJFIIJKFFHH(ref Span<ComponentType> KGJLLBIEGDF, ComponentType KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB01B0", Offset = "0x2AAF1B0", VA = "0x182AB01B0")]
	[CompilerGenerated]
	internal static void GICKGMNCGCO(Span<ComponentType> EGIDMCNFHCK, ref Span<ComponentType> KGJLLBIEGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0600", Offset = "0x2AAF600", VA = "0x182AB0600")]
	[CompilerGenerated]
	internal static void MIOJNGGNGHH(Span<ComponentType> EGIDMCNFHCK, ref Span<ComponentType> KGJLLBIEGDF, ComponentType EKKJDILLMHE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[OHGELDJCNJM(GGAOONGBEBH.PropertyChanges)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld KKBCOKGEMAJ;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D13240", Offset = "0x2D12240", VA = "0x182D13240", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D13300", Offset = "0x2D12300", VA = "0x182D13300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[OHGELDJCNJM(GGAOONGBEBH.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : HCAPJDLAPMD, MIBCENMOHFA, PFFHIJLFPMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct HILKKMBHGCK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> CNODPDAHKPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> ADPEILOIIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<HJMJEPLELOA> DPCFLKEACDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<NEEMIEDAPCM>.ParallelWriter FEFDDLKGBKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int GLCMGMBLAIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int MGOPICKODAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker BIBEJBLGKLM;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2C84FD0", Offset = "0x2C83FD0", VA = "0x182C84FD0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2C85110", Offset = "0x2C84110", VA = "0x182C85110")]
			private unsafe int KMJCPNHLPDK(byte* OGNGHGCPOLP, byte* NANIPOPDLDJ)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct FIDKMAJDPBD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> CAHDBKNLLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> FIAFBMPKDKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<NEEMIEDAPCM> MAGLBLOKDFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker BIBEJBLGKLM;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2C83F60", Offset = "0x2C82F60", VA = "0x182C83F60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct AJKOECDBODL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> BHMBBINMMDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity OMAGOPINIKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int ODDNJFFKMJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker BIBEJBLGKLM;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2C839F0", Offset = "0x2C829F0", VA = "0x182C839F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct GJNCDDNDKGF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, MEGNPFABGGE> NEDMLOIKIFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> KCDBOIAJNCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> IMFNGEBEPMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<HJMJEPLELOA> DEMNLFKMDJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> GCNEFCAOPJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> CAHDBKNLLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int KCDNAEAEFOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int CPFNENOGHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker BIBEJBLGKLM;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2C84900", Offset = "0x2C83900", VA = "0x182C84900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker IFCMJHPDEFL;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker CFAIPFKLEDP;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker PFFPBPCJLDN;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker PHABKANJJEB;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker NKFJMNPLNCB;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker HDOCPLLAHND;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker AMAHNFNHOAA;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker BCGFGOKKJKO;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker MMPAIPHJBNC;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker DPIBKHCENMP;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker EOMBFDFIHAB;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker LEKOOJHKGGN;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker CCLCAMBLNBO;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker JGDONEKKKPE;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker CHBOIMHLLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService MCOMNCLENIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery BPIFFIIDDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery BDNJLMMMHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery OINLNJKBILL;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World KFELBCCLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D1F700", Offset = "0x2D1E700", VA = "0x182D1F700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private BFHHLLCINGL GDOPJIHDKEG
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2D1CF40", Offset = "0x2D1BF40", VA = "0x182D1CF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E860", Offset = "0x2D1D860", VA = "0x182D1E860", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "15")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FAA0", Offset = "0x2D1EAA0", VA = "0x182D1FAA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FC60", Offset = "0x2D1EC60", VA = "0x182D1FC60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FBF0", Offset = "0x2D1EBF0", VA = "0x182D1FBF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CF60", Offset = "0x2D1BF60", VA = "0x182D1CF60")]
		private void BKEGCBNLBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E600", Offset = "0x2D1D600", VA = "0x182D1E600")]
		internal void FAACDNBNAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DE30", Offset = "0x2D1CE30", VA = "0x182D1DE30")]
		private void FAACDNBNAGJ(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CC00", Offset = "0x2D1BC00", VA = "0x182D1CC00")]
		private void ANCANMEMKKN(NativeArray<Entity> INCINPMOBBH, NativeArray<RRObjectPrefabData> FENDMLNLIDM, ref NativeArray<Entity> CJDMDALAHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F6E0", Offset = "0x2D1E6E0", VA = "0x182D1F6E0")]
		internal void NDMAHIHAEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F2E0", Offset = "0x2D1E2E0", VA = "0x182D1F2E0")]
		private void NDMAHIHAEKA(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D6D0", Offset = "0x2D1C6D0", VA = "0x182D1D6D0")]
		internal void EEHGMAABJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F7C0", Offset = "0x2D1E7C0", VA = "0x182D1F7C0")]
		private void ONEBEKBHMGD(BFHHLLCINGL KFCHBPFAEMJ, JPEEACBJEJB JJPMEEGFFGM, bool EJFAOPNCMBG, ref JobHandle HBKMCOINHFO, ref JobHandle PGAKIGHHDBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E8B0", Offset = "0x2D1D8B0", VA = "0x182D1E8B0")]
		internal bool LJAOABGJLCA(in JPEEACBJEJB NANIPOPDLDJ, out JobHandle BDCLOJHOMDK, out IDEGAILMGHG LELNBCFCCGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E8E0", Offset = "0x2D1D8E0", VA = "0x182D1E8E0")]
		private bool LJAOABGJLCA(in JPEEACBJEJB NANIPOPDLDJ, bool EJFAOPNCMBG, out JobHandle BDCLOJHOMDK, out IDEGAILMGHG LELNBCFCCGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E620", Offset = "0x2D1D620", VA = "0x182D1E620")]
		internal (NativeList<int>, NativeList<int>) GJOMOEDEHCC(NativeList<NEEMIEDAPCM> MAGLBLOKDFO, int KNECCHHDDJH, JobHandle OFHDPBCPCFP, out JobHandle DGGOEPGELHE, Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D620", Offset = "0x2D1C620", VA = "0x182D1D620")]
		internal static NativeArray<Entity> CODPEHMAOJL(EntityQuery APEJLGJADFF, out JobHandle HMBMADBNCFH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E7E0", Offset = "0x2D1D7E0", VA = "0x182D1E7E0")]
		internal static NativeArray<byte> HLFCMGDDLLJ(int FHNEBAPANCE, out JobHandle CPDJIHHOHEH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FDA0", Offset = "0x2D1EDA0", VA = "0x182D1FDA0")]
		internal static NativeArray<byte> PCAOCPMFNDF(EntityQuery APEJLGJADFF, int DFMDKBNGDLJ, out JobHandle CPDJIHHOHEH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CE40", Offset = "0x2D1BE40", VA = "0x182D1CE40")]
		internal static NativeArray<Entity> APCKJNJHEBA(EntityQuery APEJLGJADFF, out JobHandle NEPHIFININB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D220", Offset = "0x2D1C220", VA = "0x182D1D220")]
		internal NativeArray<byte> CDKLJOEGHNE(NativeArray<Entity> GMAMPIGCEAB, JPEEACBJEJB JJPMEEGFFGM, JobHandle OFHDPBCPCFP, out JobHandle DGGOEPGELHE, Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D490", Offset = "0x2D1C490", VA = "0x182D1D490")]
		internal JobHandle CLPFKFBNOED(in IDEGAILMGHG FNIHENPLJHK, in JPEEACBJEJB JJPMEEGFFGM, NativeMultiHashMap<Entity, MEGNPFABGGE> NEDMLOIKIFG, JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1D59970", Offset = "0x1D58970", VA = "0x181D59970")]
		private JobHandle EAPOHBPAEDH(JobHandle AIGKIAHLJHD, JobHandle APEOOHMEEJI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D59970", Offset = "0x1D58970", VA = "0x181D59970")]
		private JobHandle EAPOHBPAEDH(JobHandle AIGKIAHLJHD, JobHandle APEOOHMEEJI, JobHandle IMCMEEIGING)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[OHGELDJCNJM(GGAOONGBEBH.RenderEffects)]
	internal class PropagateHoverRootTag : DDKJOGCAJFL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct JPEDJIIKCBM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType HDOODGHOMBN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC36A0", Offset = "0x2AC26A0", VA = "0x182AC36A0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC36D0", Offset = "0x2AC26D0", VA = "0x182AC36D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3670", Offset = "0x2AC2670", VA = "0x182AC3670", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3700", Offset = "0x2AC2700", VA = "0x182AC3700")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[OHGELDJCNJM(GGAOONGBEBH.RenderEffects)]
	internal class PropagateSelectionRootTag : DDKJOGCAJFL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct IKADLMPMCPL : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType HDOODGHOMBN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3740", Offset = "0x2AC2740", VA = "0x182AC3740", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3770", Offset = "0x2AC2770", VA = "0x182AC3770", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3710", Offset = "0x2AC2710", VA = "0x182AC3710", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3700", Offset = "0x2AC2700", VA = "0x182AC3700")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[CGJIBJMELLG]
public class FNIHOBLGIFG : MKDLICHFONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x30DB210", Offset = "0x30DA210", VA = "0x1830DB210", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x30DB2A0", Offset = "0x30DA2A0", VA = "0x1830DB2A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public FNIHOBLGIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[CGJIBJMELLG]
public class JHGLFLMIJNB : MKDLICHFONK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct FBMCOINBLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public FBMCOINBLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct PDIPJJCIKPG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct DJNACAOLNDF
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct BAPHBLJLNEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime MJCBHOBAEHH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> EFOCFLJGINE;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x413A230", Offset = "0x4139230", VA = "0x18413A230")]
			public void LICMABLNMJG(JHGLFLMIJNB JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x413A1B0", Offset = "0x41391B0", VA = "0x18413A1B0")]
			public BAPHBLJLNEA CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(BAPHBLJLNEA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> APNFJPHFOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private DJNACAOLNDF PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DJNACAOLNDF.BAPHBLJLNEA* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate BBIIIFHMCDK;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x4142A50", Offset = "0x4141A50", VA = "0x184142A50")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, SplinePointParentData BJNJDEBFECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x4142AC0", Offset = "0x4141AC0", VA = "0x184142AC0", Slot = "5")]
		public void ReadFromDisplayClass(ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x4142AD0", Offset = "0x4141AD0", VA = "0x184142AD0", Slot = "6")]
		public void WriteToDisplayClass(ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x4142800", Offset = "0x4141800", VA = "0x184142800", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x4142910", Offset = "0x4141910", VA = "0x184142910")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref DJNACAOLNDF.BAPHBLJLNEA KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x41429C0", Offset = "0x41419C0", VA = "0x1841429C0")]
		public void LICMABLNMJG(JHGLFLMIJNB JFLOFOFLJIH, ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x41428A0", Offset = "0x41418A0", VA = "0x1841428A0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery OLPNFLOIHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker IIDENKEIGNC;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x30E84E0", Offset = "0x30E74E0", VA = "0x1830E84E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public JHGLFLMIJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x30E82B0", Offset = "0x30E72B0", VA = "0x1830E82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x30E8150", Offset = "0x30E7150", VA = "0x1830E8150")]
	public static EntityQuery BIIJLNAHEEL(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[CGJIBJMELLG]
public class AFNNDICDEPP : MKDLICHFONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery OGHKLPODMHH;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F840", Offset = "0x2D0E840", VA = "0x182D0F840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F8D0", Offset = "0x2D0E8D0", VA = "0x182D0F8D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public AFNNDICDEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(FNIHOBLGIFG))]
public class KKMLKMNCJIO : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x30ED320", Offset = "0x30EC320", VA = "0x1830ED320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public KKMLKMNCJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class BFMCGMOHAHJ : MKDLICHFONK, MIBCENMOHFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct GGCECDPGKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<IJDKBBDMEBI, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public GGCECDPGKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MJEHGADIOHO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct AKOOEDHAMBM
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct BBGLEBPHLFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime PGDMAJALGNF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> IPKFMPFJODL;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x4137F80", Offset = "0x4136F80", VA = "0x184137F80")]
			public void LICMABLNMJG(BFMCGMOHAHJ JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x4137F00", Offset = "0x4136F00", VA = "0x184137F00")]
			public BBGLEBPHLFP CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(BBGLEBPHLFP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private AKOOEDHAMBM PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AKOOEDHAMBM.BBGLEBPHLFP* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C86FA0", Offset = "0x2C85FA0", VA = "0x182C86FA0")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ObjectNetworkIdComponentData HLIFFLHFFOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13CA9F0", VA = "0x1813CB9F0", Slot = "5")]
		public void ReadFromDisplayClass(ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE7E0", VA = "0x1828AF7E0", Slot = "6")]
		public void WriteToDisplayClass(ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2C86DD0", Offset = "0x2C85DD0", VA = "0x182C86DD0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2C86EB0", Offset = "0x2C85EB0", VA = "0x182C86EB0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref AKOOEDHAMBM.BBGLEBPHLFP KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2C86F60", Offset = "0x2C85F60", VA = "0x182C86F60")]
		public void LICMABLNMJG(BFMCGMOHAHJ JFLOFOFLJIH, ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x2C86E40", Offset = "0x2C85E40", VA = "0x182C86E40")]
		public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService OAKEGNELFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery OLPNFLOIHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker IIDENKEIGNC;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D15D70", Offset = "0x2D14D70", VA = "0x182D15D70", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D15FD0", Offset = "0x2D14FD0", VA = "0x182D15FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public BFMCGMOHAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D15DD0", Offset = "0x2D14DD0", VA = "0x182D15DD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D15C10", Offset = "0x2D14C10", VA = "0x182D15C10")]
	public static EntityQuery BIIJLNAHEEL(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class AENNHIAGJIH : MKDLICHFONK, MIBCENMOHFA
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KEACGLDHLPA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct GHPFNGMNLLA
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct ECHIHLDPEFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime FBACGAJNBCF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> HMAONFLKKKP;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x413C160", Offset = "0x413B160", VA = "0x18413C160")]
			public void LICMABLNMJG(AENNHIAGJIH JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x413C0E0", Offset = "0x413B0E0", VA = "0x18413C0E0")]
			public ECHIHLDPEFG CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
			{
				return default(ECHIHLDPEFG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AENNHIAGJIH GIEGNPJBJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private GHPFNGMNLLA PMBHKEDMCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GHPFNGMNLLA.ECHIHLDPEFG* KBINLFEBIMI;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x2C865A0", Offset = "0x2C855A0", VA = "0x182C865A0")]
		public void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData OMKPIJFONFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2C863D0", Offset = "0x2C853D0", VA = "0x182C863D0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2C864B0", Offset = "0x2C854B0", VA = "0x182C864B0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref GHPFNGMNLLA.ECHIHLDPEFG KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2C86560", Offset = "0x2C85560", VA = "0x182C86560")]
		public void LICMABLNMJG(AENNHIAGJIH JFLOFOFLJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2C86440", Offset = "0x2C85440", VA = "0x182C86440")]
		public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery OLPNFLOIHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker IIDENKEIGNC;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F2E0", Offset = "0x2D0E2E0", VA = "0x182D0F2E0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F730", Offset = "0x2D0E730", VA = "0x182D0F730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public AENNHIAGJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F340", Offset = "0x2D0E340", VA = "0x182D0F340")]
	[CompilerGenerated]
	private void KNBMIABBHAE(Entity PJEENOLDJIO, ParentData OMKPIJFONFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F530", Offset = "0x2D0E530", VA = "0x182D0F530", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F180", Offset = "0x2D0E180", VA = "0x182D0F180")]
	public static EntityQuery BIIJLNAHEEL(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class IDDDCOAFMKO : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int EOOHOEFEACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery APEJLGJADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs APEJINPFNBH;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x30E51D0", Offset = "0x30E41D0", VA = "0x1830E51D0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x30E5220", Offset = "0x30E4220", VA = "0x1830E5220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x30E5300", Offset = "0x30E4300", VA = "0x1830E5300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x30E54E0", Offset = "0x30E44E0", VA = "0x1830E54E0")]
	private void PEFHGEALJKG(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public IDDDCOAFMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	[UpdateBefore(typeof(IDDDCOAFMKO))]
	public class PostLoadAddSceneTagEntity : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService KPCHKHEBGLC;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC16D0", Offset = "0x2AC06D0", VA = "0x182AC16D0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1720", Offset = "0x2AC0720", VA = "0x182AC1720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[OHKEEAJFOEC(PGBOFPGBDBH.OMRoom)]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	public class PostLoadInitializeNetworkId : HCAPJDLAPMD, MIBCENMOHFA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct BIPJDKBMHOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<IJDKBBDMEBI, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
			public BIPJDKBMHOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct KJPIBKPAPCN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct ANGHBFBBDNC
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct GFNAGLJEHIM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime PJLGCHLDELF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime PGDMAJALGNF;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex KKEKDOOFPEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> IPKFMPFJODL;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x4138090", Offset = "0x4137090", VA = "0x184138090")]
				public void LICMABLNMJG(PostLoadInitializeNetworkId JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x4137FE0", Offset = "0x4136FE0", VA = "0x184137FE0")]
				public GFNAGLJEHIM CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(GFNAGLJEHIM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private ANGHBFBBDNC PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ANGHBFBBDNC.GFNAGLJEHIM* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate BBIIIFHMCDK;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x413F370", Offset = "0x413E370", VA = "0x18413F370")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, int AJPEDLMCFNF, ref ObjectNetworkIdComponentData HLIFFLHFFOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13CA9F0", VA = "0x1813CB9F0", Slot = "5")]
			public void ReadFromDisplayClass(ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE7E0", VA = "0x1828AF7E0", Slot = "6")]
			public void WriteToDisplayClass(ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x413F0A0", Offset = "0x413E0A0", VA = "0x18413F0A0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x413F200", Offset = "0x413E200", VA = "0x18413F200")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref ANGHBFBBDNC.GFNAGLJEHIM KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x413F2D0", Offset = "0x413E2D0", VA = "0x18413F2D0")]
			public void LICMABLNMJG(PostLoadInitializeNetworkId JFLOFOFLJIH, ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x413F190", Offset = "0x413E190", VA = "0x18413F190")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[JOODLPJEDOA]
		private ObjectNetworkToLocalMapService OAKEGNELFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[JOODLPJEDOA]
		private SceneService LKMIJPPNOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery APEJLGJADFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery FEIFIJEMFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker EMDLBMHLHCD;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2AC20F0", Offset = "0x2AC10F0", VA = "0x182AC20F0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2650", Offset = "0x2AC1650", VA = "0x182AC2650", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2AC26F0", Offset = "0x2AC16F0", VA = "0x182AC26F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1930", Offset = "0x2AC0930", VA = "0x182AC1930")]
		public void AHBOJDGFGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1BA0", Offset = "0x2AC0BA0", VA = "0x182AC1BA0")]
		private void GGHEIEKHBEB(NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2160", Offset = "0x2AC1160", VA = "0x182AC2160")]
		private void MNLGJNGPGHH(NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2AC23C0", Offset = "0x2AC13C0", VA = "0x182AC23C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2AC1A00", Offset = "0x2AC0A00", VA = "0x182AC1A00")]
		public static EntityQuery FECJBBNPPPE(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class EFKFOBBDNME : HCAPJDLAPMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery OJMGCJCFDEP;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AA00", Offset = "0x2D29A00", VA = "0x182D2AA00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AA90", Offset = "0x2D29A90", VA = "0x182D2AA90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public EFKFOBBDNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class AGPKBABMEOF : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::FOIBHJLLDAJ<OCFAEDPPFGC> PGMEIJMACDB;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2D109D0", Offset = "0x2D0F9D0", VA = "0x182D109D0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2D10C00", Offset = "0x2D0FC00", VA = "0x182D10C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2D10A70", Offset = "0x2D0FA70", VA = "0x182D10A70")]
	private void KBLNNDAKFEH(NativeList<EntityArchetype> HGMIABMNLHP, NativeHashMap<int, ADEHAJBPFKB> GEGOINCNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2D101C0", Offset = "0x2D0F1C0", VA = "0x182D101C0")]
	private Span<int> EHPDKBEJCNH(EntityArchetype GOEEEEBMLPJ)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D10300", Offset = "0x2D0F300", VA = "0x182D10300")]
	private bool ENDKKKAGPEN(int DFMDKBNGDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D103D0", Offset = "0x2D0F3D0", VA = "0x182D103D0")]
	private void HCHKBOEAGLM(NativeHashMap<int, ADEHAJBPFKB> GEGOINCNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public AGPKBABMEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[OHGELDJCNJM(GGAOONGBEBH.Serialization)]
	public class PreSerializeRemoveEntities : HCAPJDLAPMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery FAEBCNDHKDO;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2750", Offset = "0x2AC1750", VA = "0x182AC2750", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2AC29D0", Offset = "0x2AC19D0", VA = "0x182AC29D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[OHGELDJCNJM(GGAOONGBEBH.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : HCAPJDLAPMD, MIBCENMOHFA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct FLGDIKLBOOJ
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
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
			public FLGDIKLBOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2C848F0", Offset = "0x2C838F0", VA = "0x182C848F0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct FJIJLCHPDFL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> CAHDBKNLLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> LJDCHIOFGBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity GMAOLEKGMKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> IMFNGEBEPMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int ODDNJFFKMJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType DDFJPMOIHNM;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x413BA40", Offset = "0x413AA40", VA = "0x18413BA40")]
			internal void OCIBIOHOPKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x413BC00", Offset = "0x413AC00", VA = "0x18413BC00", Slot = "5")]
			public void ReadFromDisplayClass(ref FLGDIKLBOOJ BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x413BA10", Offset = "0x413AA10", VA = "0x18413BA10", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x413BA20", Offset = "0x413AA20", VA = "0x18413BA20")]
			public void LICMABLNMJG(ShadowWorldApplyPropertyDifferencesToShadowWorld JFLOFOFLJIH, ref FLGDIKLBOOJ BFCCEFMGPEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService MCOMNCLENIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle OIJGMCEBNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle EOHMLCPEAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private ADIGHOEHBBA KFCHBPFAEMJ;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F0D0", Offset = "0x2C8E0D0", VA = "0x182C8F0D0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F090", Offset = "0x2C8E090", VA = "0x182C8F090")]
		public JobHandle AGCLIILCDCC(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F440", Offset = "0x2C8E440", VA = "0x182C8F440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F130", Offset = "0x2C8E130", VA = "0x182C8F130")]
		private bool LLGALBNOCLL(JobHandle OFHDPBCPCFP, int DFMDKBNGDLJ, out JobHandle PIPNFOBKJAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(OHFPMLKFCAB))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class PCJDAPKOHDG : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD490", Offset = "0x2ABC490", VA = "0x182ABD490", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public PCJDAPKOHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(AKGEPPMMEJK))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class AFOFMCAJGCB : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F990", Offset = "0x2D0E990", VA = "0x182D0F990", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public AFOFMCAJGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(OPGOAAIIKHF))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class GDPFDGNKBCD : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x30E0640", Offset = "0x30DF640", VA = "0x1830E0640", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public GDPFDGNKBCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(NIICOFFACFC))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class DCBPIOFBCON : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2D26470", Offset = "0x2D25470", VA = "0x182D26470", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public DCBPIOFBCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class CHNECHPGLEJ : JGLHBDCLLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ENGIDADGGAI KBACBHDMBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x705AA0", Offset = "0x704AA0", VA = "0x180705AA0", Slot = "18")]
		get
		{
			return default(ENGIDADGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2D198E0", Offset = "0x2D188E0", VA = "0x182D198E0")]
	public CHNECHPGLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(HGNDJEEEJJG))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class GDMLMDCLMBF : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x30DFE20", Offset = "0x30DEE20", VA = "0x1830DFE20", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public GDMLMDCLMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class AKMJPBDCOIH : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public AKMJPBDCOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class EKAIDLCEKPC : JGLHBDCLLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override ENGIDADGGAI KBACBHDMBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "18")]
		get
		{
			return default(ENGIDADGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2D198E0", Offset = "0x2D188E0", VA = "0x182D198E0")]
	public EKAIDLCEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[BEOLFPGNHND]
[ExecuteAlways]
[UpdateInGroup(typeof(EIPLBFCEONH))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class NBKHBFHAFOK : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB510", Offset = "0x2AAA510", VA = "0x182AAB510", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public NBKHBFHAFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class KAMIOINKBNK : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public KAMIOINKBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class DDMHCNFHEOF : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public DDMHCNFHEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class IKNNJGPDECM : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public IKNNJGPDECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[CGJIBJMELLG]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
public class ACLELFMAFNB : HCAPJDLAPMD, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService KLKIAHEMFFM;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E690", Offset = "0x2D0D690", VA = "0x182D0E690", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E6E0", Offset = "0x2D0D6E0", VA = "0x182D0E6E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public ACLELFMAFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct JFLFCCOIJHF : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float DIHHHDOCEHO = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> ECILKMCCIDJ;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2C854C0", Offset = "0x2C844C0", VA = "0x182C854C0", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2C85680", Offset = "0x2C84680", VA = "0x182C85680")]
			private bool GOHCEKLGJPJ(float3 IEFBANIHOGG, float3 ENFEPLFMJNK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2C85450", Offset = "0x2C84450", VA = "0x182C85450")]
			private bool DIBEFMCGIJE(quaternion IEFBANIHOGG, quaternion ENFEPLFMJNK)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct FIENKDACHIN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> LNMBIIAONHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> ANLGMFPHEID;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2C84040", Offset = "0x2C83040", VA = "0x182C84040", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly JHCDFELAIDH GCKMBMOJBKA;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly JHCDFELAIDH LOMLKELANFA;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly JHCDFELAIDH KGHDKINJJIB;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker GKDHNEPFGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private BBMAEOPJENG MDBCPGAILOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2D23060", Offset = "0x2D22060", VA = "0x182D23060", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D230D0", Offset = "0x2D220D0", VA = "0x182D230D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2D23100", Offset = "0x2D22100", VA = "0x182D23100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class RegisterTransforms : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct IKECNAFLKCK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct PIGEBJHBNEJ
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct BKFKJHABCIN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<EKKIFIHKFLD>.Runtime MHDCCBEECNE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime DGNCNIJBCLC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<EKKIFIHKFLD> AMBEEOBCGEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> MBBGOCDHCNB;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x4142BA0", Offset = "0x4141BA0", VA = "0x184142BA0")]
				public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x4142AE0", Offset = "0x4141AE0", VA = "0x184142AE0")]
				public BKFKJHABCIN CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(BKFKJHABCIN);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private PIGEBJHBNEJ PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PIGEBJHBNEJ.BKFKJHABCIN* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HMAEEHDCLDD;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x413D5D0", Offset = "0x413C5D0", VA = "0x18413D5D0")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, EKKIFIHKFLD FMNFDAHCLKF, Transform PKIKNDCFAFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x413D380", Offset = "0x413C380", VA = "0x18413D380", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x413D4E0", Offset = "0x413C4E0", VA = "0x18413D4E0")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref PIGEBJHBNEJ.BKFKJHABCIN KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x413D5C0", Offset = "0x413C5C0", VA = "0x18413D5C0")]
			public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x413D470", Offset = "0x413C470", VA = "0x18413D470")]
			public unsafe static void IEBGHNNGIEB(ArchetypeChunkIterator* GHHNLJBJHBH, void* FKODLFAPDGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct FPPFHCOIEAG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct EAAMBLNHDPL
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct AILHLLKAEIE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FDPFIMNEEBB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<EKKIFIHKFLD>.Runtime MHDCCBEECNE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity OHPAPIDKPDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<EKKIFIHKFLD> AMBEEOBCGEM;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x413AB90", Offset = "0x4139B90", VA = "0x18413AB90")]
				public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x413AB10", Offset = "0x4139B10", VA = "0x18413AB10")]
				public AILHLLKAEIE CJCEAKNMACN(ref ArchetypeChunk BBNCLJJMANH, int PBNCBBMAKDI, int CFCDNEFAOLB)
				{
					return default(AILHLLKAEIE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private EAAMBLNHDPL PMBHKEDMCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EAAMBLNHDPL.AILHLLKAEIE* KBINLFEBIMI;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x413BEE0", Offset = "0x413AEE0", VA = "0x18413BEE0")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, EKKIFIHKFLD FMNFDAHCLKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x413BDA0", Offset = "0x413ADA0", VA = "0x18413BDA0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x413BE30", Offset = "0x413AE30", VA = "0x18413BE30")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref EAAMBLNHDPL.AILHLLKAEIE KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x413AB90", Offset = "0x4139B90", VA = "0x18413AB90")]
			public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private BBMAEOPJENG MDBCPGAILOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery MNIHEKCHICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery NLPLBACDPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery KNFMGPGOEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery FPEOCKPEMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery MHLMBPFJBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker NHNHHMOMDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery GGBMBMLBJAD;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2C88620", Offset = "0x2C87620", VA = "0x182C88620", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2C88F00", Offset = "0x2C87F00", VA = "0x182C88F00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2C89110", Offset = "0x2C88110", VA = "0x182C89110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2C883E0", Offset = "0x2C873E0", VA = "0x182C883E0")]
		private void JDJFCFAMOPM(EntityQuery APEJLGJADFF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2C87DF0", Offset = "0x2C86DF0", VA = "0x182C87DF0")]
		private void BJENGOHAFEL(EntityQuery APEJLGJADFF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2C890B0", Offset = "0x2C880B0", VA = "0x182C890B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2C88670", Offset = "0x2C87670", VA = "0x182C88670")]
		private void KNDELIFLDNB(NativeArray<Entity> GMAMPIGCEAB, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2C887B0", Offset = "0x2C877B0", VA = "0x182C887B0")]
		[BurstCompile]
		internal static void LNBAOAGDPHC(NativeArray<EKKIFIHKFLD> FAPDJHOMNBP, ComponentDataFromEntity<EKKIFIHKFLD> LMDOBONNMBE, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void NEFLBIDMHGB(Transform PKIKNDCFAFJ, Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void EAGEMOEOPCH(Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void EALIJHIBOHB(int EGBCAPEEJBF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2C88200", Offset = "0x2C87200", VA = "0x182C88200")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HJGKEGJMDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2C88C90", Offset = "0x2C87C90", VA = "0x182C88C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2C88060", Offset = "0x2C87060", VA = "0x182C88060")]
		public static EntityQuery CCGJKIDKLHE(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2C88AC0", Offset = "0x2C87AC0", VA = "0x182C88AC0")]
		public static EntityQuery MALPFNJCBIM(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	public class CopyTransformDataToGameObjects : HCAPJDLAPMD, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct GDGPPNIFIOM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> ECILKMCCIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2C84810", Offset = "0x2C83810", VA = "0x182C84810", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct PDIBPCHMOGM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LNMBIIAONHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2C87C50", Offset = "0x2C86C50", VA = "0x182C87C50", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PKLHFPDJBHD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LNMBIIAONHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> ANLGMFPHEID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> GMAMPIGCEAB;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2C87CF0", Offset = "0x2C86CF0", VA = "0x182C87CF0", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly JHCDFELAIDH GCKMBMOJBKA;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly JHCDFELAIDH LOMLKELANFA;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly JHCDFELAIDH KGHDKINJJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private BBMAEOPJENG MDBCPGAILOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery EFONOIMCIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery ALIJGMCAJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery JDECHDBDPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray NPFKJKMBADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray MOPJNJDODIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray OKOMCLIDEND;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D235B0", Offset = "0x2D225B0", VA = "0x182D235B0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D23780", Offset = "0x2D22780", VA = "0x182D23780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D23970", Offset = "0x2D22970", VA = "0x182D23970", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D23A00", Offset = "0x2D22A00", VA = "0x182D23A00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D23A30", Offset = "0x2D22A30", VA = "0x182D23A30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D23600", Offset = "0x2D22600", VA = "0x182D23600")]
		private NativeArray<Entity> LJCJCGOGGIJ(NativeArray<EKKIFIHKFLD> CAHDBKNLLCN, NativeList<Entity> INCINPMOBBH, TransformAccessArray PHOCMDGPOCL, TransformAccessArray GHHOJCBLCMM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
	public class CopyTransformParentsToGameObjects : HCAPJDLAPMD, PFFHIJLFPMD
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private ECMNKKDCFCB OLFNCOFMCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private HPMBAGGHCAG FBAFAIACKJJ;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2D90", Offset = "0x2AC1D90", VA = "0x182AC2D90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D24400", Offset = "0x2D23400", VA = "0x182D24400", Slot = "14")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D24690", Offset = "0x2D23690", VA = "0x182D24690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D24510", Offset = "0x2D23510", VA = "0x182D24510")]
		private static void NNIPCDCHEHM(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D24360", Offset = "0x2D23360", VA = "0x182D24360")]
		private static bool CGMALIJKBMC(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[OHGELDJCNJM(GGAOONGBEBH.TransformSyncing)]
	public class L2PToL2WHierarchy : HCAPJDLAPMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct OBPJCBLIDOK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> GHCHNCJHDAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> KEABPBDEFKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KLECGONBOAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> MGMMPPGCOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> GFEFONNMNGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> KBMNMNNPCOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint NONCMKJPKFP;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x41426E0", Offset = "0x41416E0", VA = "0x1841426E0")]
			[Conditional("DEBUG_BUILD")]
			private void PFKMHOPKOLM(Entity PJEENOLDJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x4141FF0", Offset = "0x4140FF0", VA = "0x184141FF0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x41422E0", Offset = "0x41412E0", VA = "0x1841422E0")]
			private void HPMGJFFJKAN(float4x4 LGDBLACHNMF, Entity PJEENOLDJIO, bool AEFBCGNOIKK, int AKCCLLANEEA = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery PLMFIIKDHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery JFCJBEIHOCL;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x30EF310", Offset = "0x30EE310", VA = "0x1830EF310", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x30EF430", Offset = "0x30EE430", VA = "0x1830EF430", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class CAMNDGJOEOO : NPGNNADCJEE
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct NEGOOLMEIHJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> GHCHNCJHDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> GFEFONNMNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint NONCMKJPKFP;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x2C87020", Offset = "0x2C86020", VA = "0x182C87020", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x2C87120", Offset = "0x2C86120", VA = "0x182C87120")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery PLMFIIKDHIN;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2D18520", Offset = "0x2D17520", VA = "0x182D18520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2D18650", Offset = "0x2D17650", VA = "0x182D18650", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public CAMNDGJOEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class FEJGIKEOHDB : NPGNNADCJEE
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct NLCMEHHFMHI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> CJONJPJOAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> FOIGHCEJJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> NEPHBLCFBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> FDMDAEHHJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint NONCMKJPKFP;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x4141720", Offset = "0x4140720", VA = "0x184141720", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x4141AD0", Offset = "0x4140AD0", VA = "0x184141AD0")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery GAICKEELBKP;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x30DA180", Offset = "0x30D9180", VA = "0x1830DA180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x30DA290", Offset = "0x30D9290", VA = "0x1830DA290", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public FEJGIKEOHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class JBHKGDKMJBE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct BBFCLJNOPEE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> KEEAEGFJNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> DMMFFNFLHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> JOPPAMBKJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> IHFJEOGDDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint NONCMKJPKFP;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x4138100", Offset = "0x4137100", VA = "0x184138100", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x4138810", Offset = "0x4137810", VA = "0x184138810")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery GAICKEELBKP;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x30E7730", Offset = "0x30E6730", VA = "0x1830E7730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x30E7860", Offset = "0x30E6860", VA = "0x1830E7860", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	public JBHKGDKMJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[OHGELDJCNJM(GGAOONGBEBH.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : DDKJOGCAJFL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct KLDBIBPFLLE : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType HDOODGHOMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2AC37D0", Offset = "0x2AC27D0", VA = "0x182AC37D0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2AC3800", Offset = "0x2AC2800", VA = "0x182AC3800", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2AC37A0", Offset = "0x2AC27A0", VA = "0x182AC37A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC3700", Offset = "0x2AC2700", VA = "0x182AC3700")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[IMBAPBFDPJJ(JLLBPLFLIBM.Game)]
public class BCLAIHDBOGL : MHFGKCNGFOE
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type POLIJDHBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2D15250", Offset = "0x2D14250", VA = "0x182D15250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2D14BE0", Offset = "0x2D13BE0", VA = "0x182D14BE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public BCLAIHDBOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[IMBAPBFDPJJ(JLLBPLFLIBM.Loading)]
public class ENEDEFLCFHJ : MHFGKCNGFOE
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type POLIJDHBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C2E0", Offset = "0x2D2B2E0", VA = "0x182D2C2E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public ENEDEFLCFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class FNJLPPNLJMI : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x30DB930", Offset = "0x30DA930", VA = "0x1830DB930", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public FNJLPPNLJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[IMBAPBFDPJJ(JLLBPLFLIBM.Saving)]
public class BKMPJEINJJM : MHFGKCNGFOE
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type POLIJDHBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2D16110", Offset = "0x2D15110", VA = "0x182D16110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public BKMPJEINJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class CBPOBHNGDEN : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2D187E0", Offset = "0x2D177E0", VA = "0x182D187E0", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public CBPOBHNGDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[IMBAPBFDPJJ(JLLBPLFLIBM.Simulation)]
public class FJICLCGNEML : MHFGKCNGFOE
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type POLIJDHBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x30DA7B0", Offset = "0x30D97B0", VA = "0x1830DA7B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x30DA400", Offset = "0x30D9400", VA = "0x1830DA400", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FJICLCGNEML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[IABFONFHPFO(typeof(APHPMEDLFOE), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
internal class APHPMEDLFOE : PFFHIJLFPMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::AJPCLLKECKK<AuthoredParentData, OFFHECIKBLF, CGPADJGBHEH, AuthoredChildrenData> JJFDDACEDLC;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2D12340", Offset = "0x2D11340", VA = "0x182D12340", Slot = "4")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public APHPMEDLFOE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(EntityHierarchyParents), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	internal sealed class EntityHierarchyParents : MIBCENMOHFA, PFFHIJLFPMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[JOODLPJEDOA]
		private EOBKLCMHAME GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[JOODLPJEDOA]
		private PropertyChangeNetworkRouter LJHMEDJDLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::HHLEGGEGCOD<Entity> MLIELKFMALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::AJPCLLKECKK<ParentData, CEDELNEJEJO, ADLFHGGNGIC, ChildrenData> JJFDDACEDLC;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x30D6A10", Offset = "0x30D5A10", VA = "0x1830D6A10", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x30D65E0", Offset = "0x30D55E0", VA = "0x1830D65E0", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x30D66E0", Offset = "0x30D56E0", VA = "0x1830D66E0")]
		public Entity FCHNDLGHOIE(Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x30D6910", Offset = "0x30D5910", VA = "0x1830D6910")]
		public bool GLJCMDFJBFM(Entity PJEENOLDJIO, Entity KHLHKJKADHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x30D6970", Offset = "0x30D5970", VA = "0x1830D6970")]
		public bool JDHACNMMLIE(Entity PJEENOLDJIO, Entity KHLHKJKADHO, bool ANHIENPBNCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x30D6730", Offset = "0x30D5730", VA = "0x1830D6730")]
		private bool FEGHGECEIIF(Entity PJEENOLDJIO, Entity KHLHKJKADHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(MJJAHFLLHGK), new string[] { })]
internal sealed class MJJAHFLLHGK : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery MPPDOBIEJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9FA0", Offset = "0x2AA8FA0", VA = "0x182AA9FA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA0F0", Offset = "0x2AA90F0", VA = "0x182AAA0F0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9F80", Offset = "0x2AA8F80", VA = "0x182AA9F80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA2B0", Offset = "0x2AA92B0", VA = "0x182AAA2B0")]
	public bool PFJDPANHIDM(Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA370", Offset = "0x2AA9370", VA = "0x182AAA370")]
	public IEnumerable<Entity> PKDPPNNMDAK(Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9D10", Offset = "0x2AA8D10", VA = "0x182AA9D10")]
	public bool CCMBIGLHNMK(Entity PJEENOLDJIO, Entity BOGHNKLNLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9C50", Offset = "0x2AA8C50", VA = "0x182AA9C50")]
	public bool BEPDKIFHAFJ(Entity PJEENOLDJIO, Entity PDOBLLBCDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9DD0", Offset = "0x2AA8DD0", VA = "0x182AA9DD0")]
	public NativeList<Entity> CHFELALAAIJ(Entity PJEENOLDJIO, bool GNDBKIJJAND = false, Allocator GOLNHBOGNGC = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA1F0", Offset = "0x2AA91F0", VA = "0x182AAA1F0")]
	public IEnumerable<Entity> JNFNFOAALOH(Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA430", Offset = "0x2AA9430", VA = "0x182AAA430")]
	public Entity PLFCFKIEBOC(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA0A0", Offset = "0x2AA90A0", VA = "0x182AAA0A0")]
	public NativeArray<Entity> JJOOJLAKEOM()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9EB0", Offset = "0x2AA8EB0", VA = "0x182AA9EB0")]
	public bool DBLIAABGAHD(Entity PDOBLLBCDKJ, Entity FENFFOFPKDO, out Entity HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9FF0", Offset = "0x2AA8FF0", VA = "0x182AA9FF0")]
	private Entity JBLCGLJHIOG(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public MJJAHFLLHGK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x3670FB0", Offset = "0x366FFB0", VA = "0x183670FB0")]
		public static void MGAGAAKAIAK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FEPIHHOJCOJ HPFBGIEBCLA, global::CKGECMCPKDO<Entity> GPBJNICHLBB, out global::AJPCLLKECKK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NDEMEIEOCFP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, PGCNPEJMMNE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, PGCNPEJMMNE, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDDA0", Offset = "0x2ABCDA0", VA = "0x182ABDDA0")]
		public static bool NPALBFCDFJM(CDFLNPBCBAA FKGNAFCFFNM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class AJPCLLKECKK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, PGCNPEJMMNE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, PGCNPEJMMNE, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly JHCDFELAIDH AOHKNGHOEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::HHLEGGEGCOD<Entity> MLIELKFMALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly NMNBEJDKFLE NIDFIIPGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly AGAFPGKKJCP OKMBLMILFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly HPMBAGGHCAG FBAFAIACKJJ;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x24EAC70", Offset = "0x24E9C70", VA = "0x1824EAC70")]
	public AJPCLLKECKK(FEPIHHOJCOJ HPFBGIEBCLA, global::CKGECMCPKDO<Entity> GPBJNICHLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x24EA2B0", Offset = "0x24E92B0", VA = "0x1824EA2B0")]
	private bool LGCIMFDMKLJ(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x24E9770", Offset = "0x24E8770", VA = "0x1824E9770")]
	private bool BCFJNBEFCKB(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x24E98E0", Offset = "0x24E88E0", VA = "0x1824E98E0")]
	public bool GLJCMDFJBFM(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x24E9910", Offset = "0x24E8910", VA = "0x1824E9910")]
	public bool JJKNOCNMDKP(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x24E9940", Offset = "0x24E8940", VA = "0x1824E9940")]
	private bool JJKNOCNMDKP(Entity PJEENOLDJIO, in Entity KHLHKJKADHO, bool FMPKDFINFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void HHBKIMLAEJJ(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void CDOMMKEEELD(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void MNEFGHBHOAC(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void CNFIIAOIIDD(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private static void JAPGLHBFJAM(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x24EA370", Offset = "0x24E9370", VA = "0x1824EA370")]
	private bool PFJDPANHIDM(Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x24EA530", Offset = "0x24E9530", VA = "0x1824EA530")]
	private void PLGCGMOFAKO(Entity PJEENOLDJIO, in Entity KJNCJMANDLF, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x24E9430", Offset = "0x24E8430", VA = "0x1824E9430")]
	private void AFDBPDKMBKI(Entity PJEENOLDJIO, in Entity KJNCJMANDLF, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x24E9D80", Offset = "0x24E8D80", VA = "0x1824E9D80")]
	private bool KLGJIJHNJED(KACNPMDLMIP MCBFELIJCMG, in IJDKBBDMEBI NJCPGBBLOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x24EA180", Offset = "0x24E9180", VA = "0x1824EA180")]
	private void LDFJFKBFDMD(Entity OKMBLMILFGG, Entity BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x24E97C0", Offset = "0x24E87C0", VA = "0x1824E97C0")]
	private void GFLPJLNLLDG(Entity OKMBLMILFGG, Entity BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private void EALIJHIBOHB(Entity PJEENOLDJIO, Entity KJNCJMANDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	private void NEFLBIDMHGB(Entity PJEENOLDJIO, Entity KHLHKJKADHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct KNIAMIMDHPI : LOINMAGCOGI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public HLMPEBPKEBN OHODODKLPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x6DF000", Offset = "0x6DE000", VA = "0x1806DF000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HLMPEBPKEBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x744420", Offset = "0x743420", VA = "0x180744420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[IABFONFHPFO(typeof(ObjectEmbodimentService), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[OHGELDJCNJM(GGAOONGBEBH.Embodiment)]
	internal sealed class ObjectEmbodimentService : HFMALENMMKE, JMMCIOGFDJD, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService HDOHKKMKDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[JOODLPJEDOA]
		private EOBKLCMHAME GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[JOODLPJEDOA]
		private LCBBOCICDFN JGIJGKDIPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[JOODLPJEDOA]
		private LLCGHMDHHEA CDLAALHMHBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[JOODLPJEDOA]
		private TransformOwnershipPhase LPKJFCDGPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<IJDKBBDMEBI, EMAJLAJEHKH> PANGJBDGOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private JOPEEOLALKP HJBDHMHNDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2AB2D40", Offset = "0x2AB1D40", VA = "0x182AB2D40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int OKELKMPBJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2AB41F0", Offset = "0x2AB31F0", VA = "0x182AB41F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int DKCGFGMKLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1880", Offset = "0x2AB0880", VA = "0x182AB1880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1143670", Offset = "0x1142670", VA = "0x181143670", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2FE0", Offset = "0x2AB1FE0", VA = "0x182AB2FE0", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB12C0", Offset = "0x2AB02C0", VA = "0x182AB12C0")]
		public void DDJDAFAEPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB18A0", Offset = "0x2AB08A0", VA = "0x182AB18A0", Slot = "6")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1750", Offset = "0x2AB0750", VA = "0x182AB1750", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1280", Offset = "0x2AB0280", VA = "0x182AB1280")]
		public int CLEDONPNABJ(SceneTag JLPOKIGCHBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2460", Offset = "0x2AB1460", VA = "0x182AB2460")]
		public int GHLJGKCNJAI(SceneTag JLPOKIGCHBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2A70", Offset = "0x2AB1A70", VA = "0x182AB2A70")]
		public bool IJAPGDOFHNC(Entity PJEENOLDJIO, Allocator GOLNHBOGNGC, out NativeList<Entity> PFBMHJNEFDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2D90", Offset = "0x2AB1D90", VA = "0x182AB2D90")]
		public bool JMGMOHAEDDO(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2AB12A0", Offset = "0x2AB02A0", VA = "0x182AB12A0")]
		public bool CPIAGHNENJJ(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2AB32D0", Offset = "0x2AB22D0", VA = "0x182AB32D0")]
		public bool KLLNBFNLACK(Entity PJEENOLDJIO, out EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3220", Offset = "0x2AB2220", VA = "0x182AB3220")]
		private bool KLLNBFNLACK(Transform PKIKNDCFAFJ, out EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3340", Offset = "0x2AB2340", VA = "0x182AB3340")]
		private void LDHHNPPIDMN(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4150", Offset = "0x2AB3150", VA = "0x182AB4150")]
		private bool ODEOGIOICML(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2170", Offset = "0x2AB1170", VA = "0x182AB2170")]
		public void GBHABPPKBJN(IJDKBBDMEBI DGPLFECNDCD, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1310", Offset = "0x2AB0310", VA = "0x182AB1310")]
		public bool DKJMMHKMEIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB39C0", Offset = "0x2AB29C0", VA = "0x182AB39C0")]
		public bool OCEBLLHENFE(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4100", Offset = "0x2AB3100", VA = "0x182AB4100")]
		public bool OCEBLLHENFE(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3D70", Offset = "0x2AB2D70", VA = "0x182AB3D70")]
		public bool OCEBLLHENFE(EMAJLAJEHKH FKGNAFCFFNM, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2480", Offset = "0x2AB1480", VA = "0x182AB2480")]
		public bool HHLPCJAJHPN(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2850", Offset = "0x2AB1850", VA = "0x182AB2850")]
		public bool HHLPCJAJHPN(EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3D90", Offset = "0x2AB2D90", VA = "0x182AB3D90")]
		public bool OCEBLLHENFE(EMAJLAJEHKH AIJDONAKHON, [Optional] object JAKCBCDLMLB, bool AKNNPOEHKML = false, bool GDAKGKKKJIB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1C10", Offset = "0x2AB0C10", VA = "0x182AB1C10")]
		public Transform FPAEAJMMINO(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2AB11B0", Offset = "0x2AB01B0", VA = "0x182AB11B0")]
		public bool CGMALIJKBMC(Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2370", Offset = "0x2AB1370", VA = "0x182AB2370")]
		public EMAJLAJEHKH GEMGJFNJBAB(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2AB34B0", Offset = "0x2AB24B0", VA = "0x182AB34B0")]
		public void LNLDIFPJBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1D80", Offset = "0x2AB0D80", VA = "0x182AB1D80")]
		public void GAMKIILCKEA(SceneTag JLPOKIGCHBG, bool IKGFLBEBIIJ, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4530", Offset = "0x2AB3530", VA = "0x182AB4530")]
		private void PLAOKLEJJNE(Entity PJEENOLDJIO, bool IKGFLBEBIIJ, bool JJJAABLAABK, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2AB16B0", Offset = "0x2AB06B0", VA = "0x182AB16B0")]
		private void DOLHFLACLHB(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON, bool IKGFLBEBIIJ, bool JJJAABLAABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0E10", Offset = "0x2AAFE10", VA = "0x182AB0E10")]
		public EMAJLAJEHKH BKPJBJAHFPL(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2CC0", Offset = "0x2AB1CC0", VA = "0x182AB2CC0")]
		public bool IKALCDHMJEH(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4170", Offset = "0x2AB3170", VA = "0x182AB4170")]
		public bool ODMDIGGOFIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB31B0", Offset = "0x2AB21B0", VA = "0x182AB31B0")]
		public bool KFENFCDAEAH(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4B00", Offset = "0x2AB3B00", VA = "0x182AB4B00")]
		public bool PODBFJOOFPP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4A30", Offset = "0x2AB3A30", VA = "0x182AB4A30")]
		public bool PODBFJOOFPP(HLMPEBPKEBN BDCLOJHOMDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void LCHFPPHLBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4470", Offset = "0x2AB3470", VA = "0x182AB4470")]
		private void PKJEHBIFOJM(bool NOONJLFPGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3930", Offset = "0x2AB2930", VA = "0x182AB3930")]
		private bool NHMPHOBHAIA(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3110", Offset = "0x2AB2110", VA = "0x182AB3110")]
		private EMAJLAJEHKH KEECFPBAHLO(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3740", Offset = "0x2AB2740", VA = "0x182AB3740")]
		private EMAJLAJEHKH MLLCEFLEBEJ(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2AB19F0", Offset = "0x2AB09F0", VA = "0x182AB19F0")]
		private (Vector3, Quaternion, Vector3) FNGBPLDCIMD(Entity PJEENOLDJIO)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2AB10A0", Offset = "0x2AB00A0", VA = "0x182AB10A0")]
		private void CBMAKDDNCFD(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0D50", Offset = "0x2AAFD50", VA = "0x182AB0D50")]
		private void ANDMGAMIEMN(GPEJGMHBDPO GBPGPLEPLBP, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2880", Offset = "0x2AB1880", VA = "0x182AB2880")]
		private void ICIBIMIIPGG(EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4240", Offset = "0x2AB3240", VA = "0x182AB4240")]
		private void OPCELEDPBNN(EMAJLAJEHKH AIJDONAKHON, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0E60", Offset = "0x2AAFE60", VA = "0x182AB0E60")]
		private void BNFMPEAMBCE(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB33D0", Offset = "0x2AB23D0", VA = "0x182AB33D0")]
		private void LINEOMFIGBN(Entity PJEENOLDJIO, Transform PKIKNDCFAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4210", Offset = "0x2AB3210", VA = "0x182AB4210")]
		private GPEJGMHBDPO ONMDEPNPKNN(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4BC0", Offset = "0x2AB3BC0", VA = "0x182AB4BC0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB29A0", Offset = "0x2AB19A0", VA = "0x182AB29A0")]
		[CompilerGenerated]
		private void IEOMDKPNLFP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class KELKBFMNJDD
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x30EBFA0", Offset = "0x30EAFA0", VA = "0x1830EBFA0")]
	public static EMAJLAJEHKH GEMGJFNJBAB(this ObjectEmbodimentService EMDCODCKMDO, GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[IABFONFHPFO(typeof(ObjectLifecycleService), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Lifecycle)]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	internal sealed class ObjectLifecycleService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService AIJDONAKHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private GDLOHCFNDBC NFHBPPOEMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects PGIHHHBGHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5AD0", Offset = "0x2AB4AD0", VA = "0x182AB5AD0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, OBNHEEKLBIB> LONFBPMMGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5990", Offset = "0x2AB4990", VA = "0x182AB5990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2AB54F0", Offset = "0x2AB44F0", VA = "0x182AB54F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> NJBAOBGNPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2AB58F0", Offset = "0x2AB48F0", VA = "0x182AB58F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5590", Offset = "0x2AB4590", VA = "0x182AB5590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5BB0", Offset = "0x2AB4BB0", VA = "0x182AB5BB0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x199DDA0", Offset = "0x199CDA0", VA = "0x18199DDA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5830", Offset = "0x2AB4830", VA = "0x182AB5830")]
		public bool BKIFKBMENNF(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5490", Offset = "0x2AB4490", VA = "0x182AB5490")]
		internal void AEMLKBKAAHB(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB58B0", Offset = "0x2AB48B0", VA = "0x182AB58B0")]
		public void DBEGAACJLOG(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5A80", Offset = "0x2AB4A80", VA = "0x182AB5A80")]
		public void IIEHKMHGPPF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB53D0", Offset = "0x2AB43D0", VA = "0x182AB53D0")]
		private bool AAMEFLDCGEG(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5630", Offset = "0x2AB4630", VA = "0x182AB5630")]
		public void BAFMLPIANAD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5CF0", Offset = "0x2AB4CF0", VA = "0x182AB5CF0")]
		private bool KPEPCHEBEIO(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5B20", Offset = "0x2AB4B20", VA = "0x182AB5B20")]
		public void JMGLAECFLLN(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5C90", Offset = "0x2AB4C90", VA = "0x182AB5C90")]
		private void KONALOJIFAD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5EB0", Offset = "0x2AB4EB0", VA = "0x182AB5EB0")]
		private void MICEHPFDJMJ(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5A30", Offset = "0x2AB4A30", VA = "0x182AB5A30")]
		public void GAKJMOCPHOD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private void OANDCCGGIBF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6110", Offset = "0x2AB5110", VA = "0x182AB6110")]
		private void NCCMKGOOLMK(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(ObjectPrefabs), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Prefabs)]
	internal class ObjectPrefabs : JJMCFGGDMGC, MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class DLMMPPCGMPF : IEnumerable<(MCLBIBPLLEA, OBNHEEKLBIB)>, IEnumerable, IEnumerator<(MCLBIBPLLEA, OBNHEEKLBIB)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (MCLBIBPLLEA primitiveType, OBNHEEKLBIB prefabType) <>2__current;

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
			private (MCLBIBPLLEA, OBNHEEKLBIB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x2386B20", Offset = "0x2385B20", VA = "0x182386B20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((MCLBIBPLLEA, OBNHEEKLBIB));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x413A9F0", Offset = "0x41399F0", VA = "0x18413A9F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x41394C0", Offset = "0x41384C0", VA = "0x1841394C0")]
			[DebuggerHidden]
			public DLMMPPCGMPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x413A810", Offset = "0x4139810", VA = "0x18413A810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x413A9B0", Offset = "0x41399B0", VA = "0x18413A9B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x413A910", Offset = "0x4139910", VA = "0x18413A910", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(MCLBIBPLLEA, OBNHEEKLBIB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x413A910", Offset = "0x4139910", VA = "0x18413A910", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<OBNHEEKLBIB, Entity> APEJINPFNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<OBNHEEKLBIB, EntityArchetype> HGMIABMNLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<MCLBIBPLLEA, OBNHEEKLBIB> GFMKAONHBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<LFGFCMFBCNM, OBNHEEKLBIB> JNHOOELEBCB;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2AB99C0", Offset = "0x2AB89C0", VA = "0x182AB99C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x1896320", Offset = "0x1895320", VA = "0x181896320")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2AB94B0", Offset = "0x2AB84B0", VA = "0x182AB94B0", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB89C0", Offset = "0x2AB79C0", VA = "0x182AB89C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9890", Offset = "0x2AB8890", VA = "0x182AB9890")]
		internal IEnumerable<Type> KMECGPEEKNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9950", Offset = "0x2AB8950", VA = "0x182AB9950")]
		internal EADJHKFEPHB NAADMHBFLJJ(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB98F0", Offset = "0x2AB88F0", VA = "0x182AB98F0")]
		public EntityArchetype LIKCJCCEEML(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9A10", Offset = "0x2AB8A10", VA = "0x182AB9A10")]
		public NativeHashMap<int, EntityArchetype> OADBMDPJFAA(Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9380", Offset = "0x2AB8380", VA = "0x182AB9380")]
		public bool IHPGGKKJONC(OBNHEEKLBIB IBFEICPOBBG, out EntityArchetype GOEEEEBMLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8950", Offset = "0x2AB7950", VA = "0x182AB8950", Slot = "4")]
		[IteratorStateMachine(typeof(DLMMPPCGMPF))]
		public IEnumerable<(MCLBIBPLLEA, OBNHEEKLBIB)> BJDHAHLCMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8EB0", Offset = "0x2AB7EB0", VA = "0x182AB8EB0")]
		public Entity GCBMLPIIEEI(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9450", Offset = "0x2AB8450", VA = "0x182AB9450")]
		public OBNHEEKLBIB IJPMOHIFBJK(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2AB93F0", Offset = "0x2AB83F0", VA = "0x182AB93F0")]
		public OBNHEEKLBIB IJPMOHIFBJK(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8D40", Offset = "0x2AB7D40", VA = "0x182AB8D40")]
		public NativeHashMap<int, Entity> ELIBOEJPFPF(Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8CF0", Offset = "0x2AB7CF0", VA = "0x182AB8CF0")]
		public IEnumerable<OBNHEEKLBIB> ELDKICPEIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9CF0", Offset = "0x2AB8CF0", VA = "0x182AB9CF0")]
		public Entity OHMHGAHGEDO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8FC0", Offset = "0x2AB7FC0", VA = "0x182AB8FC0")]
		public bool GOIDOBEHMKN(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9D50", Offset = "0x2AB8D50", VA = "0x182AB9D50")]
		private void PHGADILCCDJ(EADJHKFEPHB GMLCPNMKKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9150", Offset = "0x2AB8150", VA = "0x182AB9150")]
		internal void IHEGNPLFLCB(OBNHEEKLBIB IBFEICPOBBG, ComponentTypeList JMAALAELOEJ, MFECPBIKMNM BGJMDFDIANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9B90", Offset = "0x2AB8B90", VA = "0x182AB9B90")]
		private void OCDOEOMMJBC(OBNHEEKLBIB IBFEICPOBBG, ComponentTypeList MDPFJMFBAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9030", Offset = "0x2AB8030", VA = "0x182AB9030")]
		internal Entity HNCHNFAFPMN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA1F0", Offset = "0x2AB91F0", VA = "0x182ABA1F0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum ENGIDADGGAI
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface GAJOAHMGHOA
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	KDNHCONPDAI HNMCOECENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class MLJIAFDGHKL : BFHHLLCINGL, ADIGHOEHBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly AJCPIOLJNKH CNDDLBPKDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly ENGIDADGGAI LPKJFCDGPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<IDEGAILMGHG> DGDOPIEIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, MEGNPFABGGE> HBHFCHAPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> BHGLFCMAOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle FNHELEINAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle CLNLJAKBEAE;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World PHBNLCNNMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAB210", Offset = "0x2AAA210", VA = "0x182AAB210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private KDNHCONPDAI FABDBHDPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA530", Offset = "0x2AA9530", VA = "0x182AAA530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private NFFGAJCCLIN MNONINDJKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D40", Offset = "0x6F2D40", VA = "0x1806F3D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, MEGNPFABGGE> DBIAPNDDDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x700030", Offset = "0x6FF030", VA = "0x180700030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, MEGNPFABGGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle OAGPBGCEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x1287B60", Offset = "0x1286B60", VA = "0x181287B60", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x16DED60", Offset = "0x16DDD60", VA = "0x1816DED60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool GFCOLJLAACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA550", Offset = "0x2AA9550", VA = "0x182AAA550", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World CEFJMBBLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAE40", Offset = "0x2AA9E40", VA = "0x182AAAE40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB310", Offset = "0x2AAA310", VA = "0x182AAB310")]
	public MLJIAFDGHKL(AJCPIOLJNKH CNDDLBPKDGJ, ENGIDADGGAI LPKJFCDGPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA4E0", Offset = "0x2AA94E0", VA = "0x182AAA4E0", Slot = "11")]
	private void ADCBONGPGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAD50", Offset = "0x2AA9D50", VA = "0x182AAAD50", Slot = "10")]
	private bool JEBMFJDBMPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA5D0", Offset = "0x2AA95D0", VA = "0x182AAA5D0", Slot = "12")]
	private void FBELMOLADLN(ComponentType DDFJPMOIHNM, in IDEGAILMGHG GFJDKJPDPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA560", Offset = "0x2AA9560", VA = "0x182AAA560", Slot = "13")]
	private bool DDFJDJGEANG(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB270", Offset = "0x2AAA270", VA = "0x182AAB270", Slot = "16")]
	private bool OOEOABAJJJF(out NativeArray<int> CJNALNIEFIB, Allocator GOLNHBOGNGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAAA0", Offset = "0x2AA9AA0", VA = "0x182AAAAA0", Slot = "17")]
	private bool GGIIIOKHLON(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH, out JPEEACBJEJB JJPMEEGFFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA970", Offset = "0x2AA9970", VA = "0x182AAA970", Slot = "18")]
	private bool GGIIIOKHLON(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAC20", Offset = "0x2AA9C20", VA = "0x182AAAC20", Slot = "19")]
	private IDEGAILMGHG IENEEFAEBGB(ComponentType DDFJPMOIHNM)
	{
		return default(IDEGAILMGHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA4F0", Offset = "0x2AA94F0", VA = "0x182AAA4F0", Slot = "20")]
	private DLBHGBHCIGG AHMGDGAEDMK()
	{
		return default(DLBHGBHCIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAD10", Offset = "0x2AA9D10", VA = "0x182AAAD10", Slot = "21")]
	private void IJAIOOPCHNI(JobHandle DGGOEPGELHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA6C0", Offset = "0x2AA96C0", VA = "0x182AAA6C0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAFF0", Offset = "0x2AA9FF0", VA = "0x182AAAFF0")]
	private bool MPGAPHPBGFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAEA0", Offset = "0x2AA9EA0", VA = "0x182AAAEA0")]
	private int LLKJPIDBDFL()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class AJCPIOLJNKH : GAJOAHMGHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public EEPEPNPEOFG DOFDFFCHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService APEJINPFNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public KDNHCONPDAI JGHKHMIKDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public NFFGAJCCLIN FNDDGPFJIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public OMEHKNGHBDB FIKOJDOGPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World KFELBCCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D11B70", Offset = "0x2D10B70", VA = "0x182D11B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public KDNHCONPDAI HNMCOECENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public AJCPIOLJNKH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(PropertyDiffStateService), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.PropertyChanges)]
	internal class PropertyDiffStateService : MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct DNPLLOBJPPN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly ENGIDADGGAI AGIFJONMGCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService GNJOCELFONM;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x413AAC0", Offset = "0x4139AC0", VA = "0x18413AAC0")]
			public DNPLLOBJPPN(PropertyDiffStateService GNJOCELFONM, ENGIDADGGAI EFLCOPLIDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x413AAA0", Offset = "0x4139AA0", VA = "0x18413AAA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly AJCPIOLJNKH CNDDLBPKDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly MLJIAFDGHKL[] EOABLKICGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private ENGIDADGGAI CLNPBHKMLNI;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public GAJOAHMGHOA HLMHOFJNAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public ADIGHOEHBBA NCAPNFBPPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4620", Offset = "0x2AC3620", VA = "0x182AC4620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public BFHHLLCINGL LJCFDCJLPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2AC4620", Offset = "0x2AC3620", VA = "0x182AC4620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE60", Offset = "0x8ABE60", VA = "0x1808ACE60")]
		public ADIGHOEHBBA IIICEPLLPOE(ENGIDADGGAI LPKJFCDGPPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE60", Offset = "0x8ABE60", VA = "0x1808ACE60")]
		public BFHHLLCINGL NENFCOIJJCO(ENGIDADGGAI LPKJFCDGPPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4CB0", Offset = "0x2AC3CB0", VA = "0x182AC4CB0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4810", Offset = "0x2AC3810", VA = "0x182AC4810", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4C50", Offset = "0x2AC3C50", VA = "0x182AC4C50")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4660", Offset = "0x2AC3660", VA = "0x182AC4660", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4C30", Offset = "0x2AC3C30", VA = "0x182AC4C30")]
		public DNPLLOBJPPN FJBJJDMAHDE(ENGIDADGGAI LPKJFCDGPPB)
		{
			return default(DNPLLOBJPPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4D80", Offset = "0x2AC3D80", VA = "0x182AC4D80")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	[IABFONFHPFO(typeof(SceneService), new string[] { })]
	internal class SceneService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag GNEOENMIBCL;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string BLBMPHJJEEN = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string ONMIIPLHPDC = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[JOODLPJEDOA]
		private PJCCMDKJKFG CMEPKDAKLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[JOODLPJEDOA]
		private ObjectEmbodimentService AIJDONAKHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[JOODLPJEDOA]
		private NMNBEJDKFLE OCJMBDKKCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[JOODLPJEDOA]
		private SingletonComponentService EMDOLAMEDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[JOODLPJEDOA]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[JOODLPJEDOA]
		private PhotonInstanceCleanupService OFDGJPEKDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery NGANCFFDHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery GFIGPIBHOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery CEINLHNFLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity FEGHOHKNBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool HJAGPPINKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B170", Offset = "0x2C8A170", VA = "0x182C8B170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> MMDKMABPOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x15ED880", Offset = "0x15EC880", VA = "0x1815ED880")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x21497E0", Offset = "0x21487E0", VA = "0x1821497E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity NHDHGIPPGNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2C89840", Offset = "0x2C88840", VA = "0x182C89840")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag CFMNECNKNCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A5C0", Offset = "0x2C895C0", VA = "0x182C8A5C0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity MLPNHPBGJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A5C0", Offset = "0x2C895C0", VA = "0x182C8A5C0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A840", Offset = "0x2C89840", VA = "0x182C8A840")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AA40", Offset = "0x2C89A40", VA = "0x182C8AA40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AD90", Offset = "0x2C89D90", VA = "0x182C8AD90", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2C89A60", Offset = "0x2C88A60", VA = "0x182C89A60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AD50", Offset = "0x2C89D50", VA = "0x182C8AD50")]
		public void JMELJNJFPGN(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AB40", Offset = "0x2C89B40", VA = "0x182C8AB40")]
		public NativeArray<Entity> JHLMEAAPBJD(Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A100", Offset = "0x2C89100", VA = "0x182C8A100")]
		public void ELENEGOBLIL(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AEB0", Offset = "0x2C89EB0", VA = "0x182C8AEB0")]
		public Entity JMOAKLIBCCD(string GOENAEMJAON = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B150", Offset = "0x2C8A150", VA = "0x182C8B150")]
		public void PBODALFBJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AFE0", Offset = "0x2C89FE0", VA = "0x182C8AFE0")]
		public void MBBOHHGLIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2C89AB0", Offset = "0x2C88AB0", VA = "0x182C89AB0")]
		public void EANLCDJNFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A200", Offset = "0x2C89200", VA = "0x182C8A200")]
		public void GOELJBODCNJ(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AA90", Offset = "0x2C89A90", VA = "0x182C8AA90")]
		public bool IPADCBPCPGH(Entity JLPOKIGCHBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B140", Offset = "0x2C8A140", VA = "0x182C8B140")]
		public void OOJCMAGCADB(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2C89580", Offset = "0x2C88580", VA = "0x182C89580")]
		public string BIHINHGILHF(Entity JLPOKIGCHBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		public void EDKCKEIEAOD(Entity JLPOKIGCHBG, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A610", Offset = "0x2C89610", VA = "0x182C8A610")]
		public bool HNDJOPDNOAF(string GOENAEMJAON, out Entity JLPOKIGCHBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B030", Offset = "0x2C8A030", VA = "0x182C8B030")]
		public void NFMBMJKEPII(Entity JLPOKIGCHBG, bool ENINEBIKNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8ACD0", Offset = "0x2C89CD0", VA = "0x182C8ACD0")]
		public void JMBFOGIBBKI(Entity PJEENOLDJIO, bool ONDAHMMKLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AC60", Offset = "0x2C89C60", VA = "0x182C8AC60")]
		public void JMBFOGIBBKI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AB70", Offset = "0x2C89B70", VA = "0x182C8AB70")]
		public void JMBFOGIBBKI(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2C89BC0", Offset = "0x2C88BC0", VA = "0x182C89BC0")]
		public void EJGFBNMKAFK(Entity PJEENOLDJIO, Entity JLPOKIGCHBG, bool ONDAHMMKLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2C89DF0", Offset = "0x2C88DF0", VA = "0x182C89DF0")]
		public void EJGFBNMKAFK(NativeArray<Entity> GMAMPIGCEAB, Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2C89B10", Offset = "0x2C88B10", VA = "0x182C89B10")]
		public void EJGFBNMKAFK(EntityQuery APEJLGJADFF, Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2C89690", Offset = "0x2C88690", VA = "0x182C89690")]
		private void CDICGMDKLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2C899F0", Offset = "0x2C889F0", VA = "0x182C899F0")]
		private void DBDBLBIBDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2C89840", Offset = "0x2C88840", VA = "0x182C89840")]
		private Entity GIEMINCDJOD()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AF30", Offset = "0x2C89F30", VA = "0x182C8AF30")]
		private void LJCJIFIFHHG(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A4F0", Offset = "0x2C894F0", VA = "0x182C8A4F0")]
		private void GPOMEJECHAB(EntityQuery CPAINGMLFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A210", Offset = "0x2C89210", VA = "0x182C8A210")]
		private void GPOMEJECHAB(NativeArray<Entity> LKMIJPPNOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2C894D0", Offset = "0x2C884D0", VA = "0x182C894D0")]
		private void AAPDCAOIAGP(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2C89FD0", Offset = "0x2C88FD0", VA = "0x182C89FD0")]
		private void EKMPEDDELDN(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A6D0", Offset = "0x2C896D0", VA = "0x182C8A6D0")]
		private void IBEJHOGDGPK(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2C89A20", Offset = "0x2C88A20", VA = "0x182C89A20")]
		private void DEBNKFEGAMC(SceneTag ECMPHEDFJAA, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A8B0", Offset = "0x2C898B0", VA = "0x182C8A8B0")]
		private void IGOEFMKPOKC(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A630", Offset = "0x2C89630", VA = "0x182C8A630")]
		private void IAOBMGOFNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x35061B0", Offset = "0x35051B0", VA = "0x1835061B0")]
		private void GBMGJJMIHBD<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void IDMKFOIFGMM(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2C89990", Offset = "0x2C88990", VA = "0x182C89990")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void COBHPPIELJI(EntityQuery APEJLGJADFF, string GOENAEMJAON, SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MLPNNPNKCMA(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NGNBNLLDKHA(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[IODJMJFIADF(PGBOFPGBDBH.PhotonRoom)]
	[IABFONFHPFO(typeof(HKFLOGJJADM), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	internal class UnitySceneService : MIBCENMOHFA, HKFLOGJJADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[JOODLPJEDOA]
		private SceneService LKMIJPPNOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> KJFJPNGGCFH;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2C98CB0", Offset = "0x2C97CB0", VA = "0x182C98CB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2C98E70", Offset = "0x2C97E70", VA = "0x182C98E70", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2C98D00", Offset = "0x2C97D00", VA = "0x182C98D00", Slot = "5")]
		public void JMELJNJFPGN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2C98AC0", Offset = "0x2C97AC0", VA = "0x182C98AC0", Slot = "6")]
		public bool HHEDFEIEHGE(GPEJGMHBDPO GBPGPLEPLBP, Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2C98F00", Offset = "0x2C97F00", VA = "0x182C98F00")]
		private bool PAIIKHJPBKK(Scene JLPOKIGCHBG, out Entity ODFLICDBILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2C98F70", Offset = "0x2C97F70", VA = "0x182C98F70")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[OHGELDJCNJM(GGAOONGBEBH.ComponentSystemTypes)]
	[IABFONFHPFO(typeof(SingletonComponentService), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	internal sealed class SingletonComponentService : MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[JOODLPJEDOA]
		private NMNBEJDKFLE OCJMBDKKCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity PJEENOLDJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList MDPFJMFBAOK;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2C90100", Offset = "0x2C8F100", VA = "0x182C90100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity OIMONIPJMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2C8FD40", Offset = "0x2C8ED40", VA = "0x182C8FD40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x3507AA0", Offset = "0x3506AA0", VA = "0x183507AA0")]
		public T BOEAFIEBIHC<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x3507B60", Offset = "0x3506B60", VA = "0x183507B60")]
		public void JPNFGACMGOG<T>(T KPPLMEOMNGF) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FD90", Offset = "0x2C8ED90", VA = "0x182C8FD90", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FBA0", Offset = "0x2C8EBA0", VA = "0x182C8FBA0", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FBA0", Offset = "0x2C8EBA0", VA = "0x182C8FBA0")]
		private void JHIKPAHHLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2C8F830", Offset = "0x2C8E830", VA = "0x182C8F830", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FE00", Offset = "0x2C8EE00", VA = "0x182C8FE00")]
		private ComponentTypeList KMHLNGCODFP()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void MDJJBCOLMCA(int KJAHKKMJHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		private static void OLAMCDMKCKN(Type HAOFNDAEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FB00", Offset = "0x2C8EB00", VA = "0x182C8FB00")]
		private static void EHHGLFMFANK(Type HAOFNDAEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct DHJLNKNLKJN : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
[IABFONFHPFO(typeof(LLCGHMDHHEA), new string[] { })]
internal sealed class LLCGHMDHHEA : MIBCENMOHFA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[JOODLPJEDOA]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::CMEECFLOIOG<ALPLLMBDBON, Entity> GMOHDACDANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::BLGJBPKCMHC<DGHLGAPENHN> FGKDABGFCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::BLGJBPKCMHC<FOBNDJJKLIE> IABBGNEIDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::BLGJBPKCMHC<JBLFPGJNFGD> AGBJPDNCDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::BLGJBPKCMHC<CJILDPAGJMM> BEBOLOOLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::BLGJBPKCMHC<KNIAMIMDHPI> EMDCODCKMDO;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::IHKEKCKIHGK<Entity> NDLFJPFMMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public FOIFNBDOPHG LCOLAJIIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public FOIFNBDOPHG JANEGFAEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public FOIFNBDOPHG AJLHAKJEEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public FOIFNBDOPHG CCCDBGFCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public FOIFNBDOPHG GFOEMCFLMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8340", Offset = "0x2AA7340", VA = "0x182AA8340")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8390", Offset = "0x2AA7390", VA = "0x182AA8390", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8250", Offset = "0x2AA7250", VA = "0x182AA8250", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCA30", Offset = "0x2FCBA30", VA = "0x182FCCA30")]
	private void MGAGAAKAIAK<T>(ref global::BLGJBPKCMHC<T> ABGEACDGIFN) where T : struct, LOINMAGCOGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCA30", Offset = "0x2FCBA30", VA = "0x182FCCA30")]
	private void MGAGAAKAIAK<TC, TV>(ref global::CMEECFLOIOG<TC, TV> ABGEACDGIFN) where TC : struct, LOINMAGCOGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LLCGHMDHHEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[IABFONFHPFO(typeof(BBMAEOPJENG), new string[] { })]
[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
internal sealed class BBMAEOPJENG : JMMCIOGFDJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private DLGLKFHNPHN LGFCAEGHDFF;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public DLGLKFHNPHN LHNKKFBMGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x20A65C0", Offset = "0x20A55C0", VA = "0x1820A65C0")]
		get
		{
			return default(DLGLKFHNPHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2D14B50", Offset = "0x2D13B50", VA = "0x182D14B50", Slot = "4")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2D14B40", Offset = "0x2D13B40", VA = "0x182D14B40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public BBMAEOPJENG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(TransformOwnershipPhase), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum CGLIONODIEH
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct KMACIEDNIMC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private CGLIONODIEH BGEFMBGLLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase OKMBLMILFGG;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x413F710", Offset = "0x413E710", VA = "0x18413F710")]
			public KMACIEDNIMC(TransformOwnershipPhase OKMBLMILFGG, CGLIONODIEH LPKJFCDGPPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x413F6F0", Offset = "0x413E6F0", VA = "0x18413F6F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CGLIONODIEH LPKJFCDGPPB;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public CGLIONODIEH DEMJNIBKLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
			get
			{
				return default(CGLIONODIEH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FEF30", VA = "0x1806FFF30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool JLFKGHOLHAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB79210", Offset = "0xB78210", VA = "0x180B79210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool AHMDAPIFBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x166A550", Offset = "0x1669550", VA = "0x18166A550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2C93400", Offset = "0x2C92400", VA = "0x182C93400")]
		public KMACIEDNIMC GACKDKHDLDA()
		{
			return default(KMACIEDNIMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2C933D0", Offset = "0x2C923D0", VA = "0x182C933D0")]
		public KMACIEDNIMC EDOHLAGGJCK()
		{
			return default(KMACIEDNIMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[IABFONFHPFO(typeof(BJNLEMECNFA), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Circuits)]
	public class CircuitsService : MIBCENMOHFA, BJNLEMECNFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[JOODLPJEDOA]
		private FKPLGEKODJI JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BE30", Offset = "0x2D1AE30", VA = "0x182D1BE30", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C230", Offset = "0x2D1B230", VA = "0x182D1C230", Slot = "5")]
		public bool OOECJDIBCJG(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B2E0", Offset = "0x2D1A2E0", VA = "0x182D1B2E0", Slot = "7")]
		public bool ANEFOLKNAML(GPEJGMHBDPO GBPGPLEPLBP, out Guid APEBDJMHLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BC30", Offset = "0x2D1AC30", VA = "0x182D1BC30", Slot = "8")]
		public Guid GPFKGAPLFOM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BFD0", Offset = "0x2D1AFD0", VA = "0x182D1BFD0", Slot = "9")]
		public void OJJGJMGDHKM(GPEJGMHBDPO GBPGPLEPLBP, Guid APEBDJMHLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BD40", Offset = "0x2D1AD40", VA = "0x182D1BD40", Slot = "10")]
		public bool JKFHLGOCOCL(GPEJGMHBDPO GBPGPLEPLBP, out Guid EOJILANFMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B5B0", Offset = "0x2D1A5B0", VA = "0x182D1B5B0", Slot = "11")]
		public Guid BOGBLLJOODM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1C330", Offset = "0x2D1B330", VA = "0x182D1C330", Slot = "12")]
		public void PDMPFOHPPIM(GPEJGMHBDPO GBPGPLEPLBP, Guid EOJILANFMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BED0", Offset = "0x2D1AED0", VA = "0x182D1BED0", Slot = "13")]
		public bool KDIANNPMDKF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B540", Offset = "0x2D1A540", VA = "0x182D1B540", Slot = "14")]
		public void BLEBBBBBHKJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B870", Offset = "0x2D1A870", VA = "0x182D1B870", Slot = "15")]
		public void GGBFNFKCOCA(GPEJGMHBDPO NMAMPMADCBK, GPEJGMHBDPO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B3D0", Offset = "0x2D1A3D0", VA = "0x182D1B3D0")]
		private void BCKHPMBMBJO(GMACJOGODPF JPGPKCIKOBK, GPEJGMHBDPO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B150", Offset = "0x2D1A150", VA = "0x182D1B150")]
		private void ACAAABHNDBA(GMACJOGODPF JPGPKCIKOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B720", Offset = "0x2D1A720", VA = "0x182D1B720")]
		private bool FDLCKPKNNLO(CDFLNPBCBAA AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2D1BF20", Offset = "0x2D1AF20", VA = "0x182D1BF20")]
		private bool KNNMBDGPCPK(CDFLNPBCBAA AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B6C0", Offset = "0x2D1A6C0", VA = "0x182D1B6C0", Slot = "6")]
		public bool DLJJNAGJIEG(GPEJGMHBDPO LCCDBPIJCNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[IABFONFHPFO(typeof(MJBFDNAELPM), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Connectables)]
	internal class ConnectableService : MJBFDNAELPM, MIBCENMOHFA, PFFHIJLFPMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class KILKHJDNCCJ : IEnumerable<GPEJGMHBDPO>, IEnumerable, IEnumerator<GPEJGMHBDPO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private GPEJGMHBDPO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private GPEJGMHBDPO localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public GPEJGMHBDPO <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private GPEJGMHBDPO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(GPEJGMHBDPO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2C869B0", Offset = "0x2C859B0", VA = "0x182C869B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x986E80", Offset = "0x985E80", VA = "0x180986E80")]
			[DebuggerHidden]
			public KILKHJDNCCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2C86A00", Offset = "0x2C85A00", VA = "0x182C86A00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2C865C0", Offset = "0x2C855C0", VA = "0x182C865C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2C86AD0", Offset = "0x2C85AD0", VA = "0x182C86AD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2C86B20", Offset = "0x2C85B20", VA = "0x182C86B20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2C86970", Offset = "0x2C85970", VA = "0x182C86970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2C868C0", Offset = "0x2C858C0", VA = "0x182C868C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GPEJGMHBDPO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2C868C0", Offset = "0x2C858C0", VA = "0x182C868C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly JHCDFELAIDH MOOGCCGHDEB;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int LBEAOOCCKGF = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int BLLNOHLOOHO = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EOBKLCMHAME GAICKEELBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private KHCCBBJDMKM JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService FOOIHPIJMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::HHLEGGEGCOD<Entity> GOMDOMLFCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::HHLEGGEGCOD<float3> HGKKOECINOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::HHLEGGEGCOD<quaternion> BHCAGKPODOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::HHLEGGEGCOD<Entity> OKMBLMILFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::HHLEGGEGCOD<float3> MBFNFKBJPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::HHLEGGEGCOD<quaternion> EBMHHHHKPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> HFDBMLMBJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> JGCHNPOCJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery MPPDOBIEJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<HCEFJNDGODN> PJDAPHGGPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5750", Offset = "0x6F4750", VA = "0x1806F5750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x8120C0", Offset = "0x8110C0", VA = "0x1808120C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO> INOBOELIHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2D20E40", Offset = "0x2D1FE40", VA = "0x182D20E40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2D20920", Offset = "0x2D1F920", VA = "0x182D20920", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO> AODOAHCEEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2D21D30", Offset = "0x2D20D30", VA = "0x182D21D30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2D209C0", Offset = "0x2D1F9C0", VA = "0x182D209C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO, GPEJGMHBDPO> HFJJFLHPAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2D21840", Offset = "0x2D20840", VA = "0x182D21840", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2D20D40", Offset = "0x2D1FD40", VA = "0x182D20D40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<GPEJGMHBDPO> GLMHPCHPLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2D21C90", Offset = "0x2D20C90", VA = "0x182D21C90", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D20710", Offset = "0x2D1F710", VA = "0x182D20710", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D21A10", Offset = "0x2D20A10", VA = "0x182D21A10", Slot = "25")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2D21250", Offset = "0x2D20250", VA = "0x182D21250", Slot = "26")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2D20EE0", Offset = "0x2D1FEE0", VA = "0x182D20EE0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2D20DE0", Offset = "0x2D1FDE0", VA = "0x182D20DE0")]
		private void DJCMEJLBKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2D207B0", Offset = "0x2D1F7B0", VA = "0x182D207B0")]
		private void BFKAFDKKDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2D21090", Offset = "0x2D20090", VA = "0x182D21090")]
		private void EPKHBNJNPOI(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2D20B10", Offset = "0x2D1FB10", VA = "0x182D20B10")]
		private void DAFALAINKDK(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1D59970", Offset = "0x1D58970", VA = "0x181D59970", Slot = "14")]
		public GPEJGMHBDPO MGDOBBAPFPD(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x147A5C0", Offset = "0x14795C0", VA = "0x18147A5C0", Slot = "15")]
		public Color MNCGELPPEGP(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2D21E60", Offset = "0x2D20E60", VA = "0x182D21E60", Slot = "16")]
		public float3 PLELCPCFFPP(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2D20260", Offset = "0x2D1F260", VA = "0x182D20260", Slot = "17")]
		public bool AAFEMIFHGLM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO LOGHNPBJPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2D20A60", Offset = "0x2D1FA60", VA = "0x182D20A60", Slot = "18")]
		public GPEJGMHBDPO CEEOGDGFJIM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2D216F0", Offset = "0x2D206F0", VA = "0x182D216F0", Slot = "21")]
		public void FJDLPPGILIA(GPEJGMHBDPO GBPGPLEPLBP, Vector3 MDNCMKKCHIF, Quaternion KJNACLNKACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2D218E0", Offset = "0x2D208E0", VA = "0x182D218E0", Slot = "23")]
		public float3 HNNEKJLPDCG(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2D21980", Offset = "0x2D20980", VA = "0x182D21980", Slot = "24")]
		public quaternion JKAHAIGFPCF(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2D21B90", Offset = "0x2D20B90", VA = "0x182D21B90", Slot = "28")]
		public RigidTransform KHHDHCINGPM(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2D20310", Offset = "0x2D1F310", VA = "0x182D20310", Slot = "22")]
		public bool AICNMJGJMLB(GPEJGMHBDPO GBPGPLEPLBP, out RigidTransform LLIGAMMEJDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2D21DD0", Offset = "0x2D20DD0", VA = "0x182D21DD0", Slot = "19")]
		[IteratorStateMachine(typeof(KILKHJDNCCJ))]
		public IEnumerable<GPEJGMHBDPO> PEKEMJACJCC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2D205B0", Offset = "0x2D1F5B0", VA = "0x182D205B0", Slot = "20")]
		public GPEJGMHBDPO AKMDKGCFANK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2D20B70", Offset = "0x2D1FB70", VA = "0x182D20B70", Slot = "29")]
		public void DCHFFGHDPLJ(ref List<GPEJGMHBDPO> NKLDGGPGPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2D20490", Offset = "0x2D1F490", VA = "0x182D20490")]
		private Entity AKMDKGCFANK(Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2D220D0", Offset = "0x2D210D0", VA = "0x182D220D0")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[OHGELDJCNJM(GGAOONGBEBH.Prefabs)]
	[IABFONFHPFO(typeof(ObjectInstantiationService), new string[] { })]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	internal sealed class ObjectInstantiationService : MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG BKFHGKOCNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[JOODLPJEDOA]
		private OEPDOHBHEIO AIBCEPMNAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[JOODLPJEDOA]
		private IEGMKAAGAAJ NIAHLANLHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[JOODLPJEDOA]
		private ObjectNetworkToLocalMapService OAKEGNELFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[JOODLPJEDOA]
		private ObjectLifecycleService HDOHKKMKDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[JOODLPJEDOA]
		private ObjectPrefabs APEJINPFNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[JOODLPJEDOA]
		private AIEDNAFPHHD MLGFDDOBENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private GDLOHCFNDBC NFHBPPOEMBF;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int IHMBBPFEOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4E10", Offset = "0x2AB3E10", VA = "0x182AB4E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4E60", Offset = "0x2AB3E60", VA = "0x182AB4E60", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4DF0", Offset = "0x2AB3DF0", VA = "0x182AB4DF0")]
		public Entity HBBIFLCNHAN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4FF0", Offset = "0x2AB3FF0", VA = "0x182AB4FF0")]
		public Entity NFKICFAFKEF(IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5060", Offset = "0x2AB4060", VA = "0x182AB5060")]
		public Entity NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5050", Offset = "0x2AB4050", VA = "0x182AB5050")]
		public Entity NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4CC0", Offset = "0x2AB3CC0", VA = "0x182AB4CC0")]
		public Entity DPPJEBGFDDC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4D20", Offset = "0x2AB3D20", VA = "0x182AB4D20")]
		public Entity FEGDAGMALKP(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4C40", Offset = "0x2AB3C40", VA = "0x182AB4C40")]
		public Entity CMIPAENJOBN(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4DA0", Offset = "0x2AB3DA0", VA = "0x182AB4DA0")]
		public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4CD0", Offset = "0x2AB3CD0", VA = "0x182AB4CD0")]
		public IEnumerable<OBNHEEKLBIB> ELDKICPEIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB4F90", Offset = "0x2AB3F90", VA = "0x182AB4F90")]
		public EntityArchetype LIKCJCCEEML(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB50F0", Offset = "0x2AB40F0", VA = "0x182AB50F0")]
		public Entity OHMHGAHGEDO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5150", Offset = "0x2AB4150", VA = "0x182AB5150")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB51D0", Offset = "0x2AB41D0", VA = "0x182AB51D0")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB5260", Offset = "0x2AB4260", VA = "0x182AB5260")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG, IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[IABFONFHPFO(typeof(IIEBHPDOOAI), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public sealed class PhysicsSceneColliderService : IIEBHPDOOAI, IAIIPPHGJJF, JMMCIOGFDJD, MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string KLPFBDNLHKF = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int GIGLBLJILCI = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int KJNOCANADOH = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[JOODLPJEDOA]
		private LCBBOCICDFN JGIJGKDIPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] IBIMHIPADLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] AKAFGDAPNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::IEDFOPGJHFB<FJFJJACADNC, BoxCollider> LPLAHPOAKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene JLPOKIGCHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene NEPHAFDOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject IJBPCAELLON;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int GFEIJDAKFFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF520", Offset = "0x2ABE520", VA = "0x182ABF520", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEFA0", Offset = "0x2ABDFA0", VA = "0x182ABEFA0", Slot = "9")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF110", Offset = "0x2ABE110", VA = "0x182ABF110", Slot = "10")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE7A0", Offset = "0x2ABD7A0", VA = "0x182ABE7A0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEDC0", Offset = "0x2ABDDC0", VA = "0x182ABEDC0", Slot = "4")]
		public FJFJJACADNC GPCHMCKOJPO(Entity PJEENOLDJIO)
		{
			return default(FJFJJACADNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEBA0", Offset = "0x2ABDBA0", VA = "0x182ABEBA0", Slot = "5")]
		public void GIPLOPMFHON(NativeArray<FJFJJACADNC> IJELHBLKOKB, NativeArray<DFOPMDEEAAA> BNIHLJDPCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE6D0", Offset = "0x2ABD6D0", VA = "0x182ABE6D0", Slot = "6")]
		public void DJKDLEFDGCC(FJFJJACADNC BDCLOJHOMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF560", Offset = "0x2ABE560", VA = "0x182ABF560", Slot = "7")]
		public bool OAPHHMFPIBI(FJFJJACADNC BDCLOJHOMDK, out Collider MMNMMMMCHOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF210", Offset = "0x2ABE210", VA = "0x182ABF210")]
		public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF600", Offset = "0x2ABE600", VA = "0x182ABF600")]
		private void OHBHENIMPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC195C0", Offset = "0xC185C0", VA = "0x180C195C0")]
		private void HJFJMKEAOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEF10", Offset = "0x2ABDF10", VA = "0x182ABEF10")]
		private void HEHKNFLFKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x983080", Offset = "0x982080", VA = "0x180983080")]
		private void IOFODMINCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE4F0", Offset = "0x2ABD4F0", VA = "0x182ABE4F0")]
		private BoxCollider CBOPOBPLKJJ(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE650", Offset = "0x2ABD650", VA = "0x182ABE650")]
		private void CPBGBFGDACC(BoxCollider MNOELEFBNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE610", Offset = "0x2ABD610", VA = "0x182ABE610")]
		[Conditional("UNITY_EDITOR")]
		private void CGABOGFKFCC(GameObject BLPBCMIHDMD, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE8A0", Offset = "0x2ABD8A0", VA = "0x182ABE8A0")]
		private void ECEELOAIMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEA90", Offset = "0x2ABDA90", VA = "0x182ABEA90")]
		private void GDJKCJAFJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE2E0", Offset = "0x2ABD2E0", VA = "0x182ABE2E0")]
		private void AALCPCAKNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF1E0", Offset = "0x2ABE1E0", VA = "0x182ABF1E0")]
		private void JOHMHPFHMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEDB0", Offset = "0x2ABDDB0", VA = "0x182ABEDB0")]
		private void GNLIPBHAEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEF60", Offset = "0x2ABDF60", VA = "0x182ABEF60")]
		private void HGMOPFDFALP(Scene DCGIJKGOJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF1D0", Offset = "0x2ABE1D0", VA = "0x182ABF1D0", Slot = "8")]
		private bool JNMNEDBGHHP(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[IABFONFHPFO(typeof(AIIFBLBGOBI), new string[] { })]
public sealed class LBLNCLBMJAM : AIIFBLBGOBI, MIBCENMOHFA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct KNMIMDIHFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float IFKFINIBHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint JBPOPNPHJBO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private IAIIPPHGJJF AGDCLKHCDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private DMLACEJEPHB EDAFNHNEFCE;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4970", Offset = "0x2AA3970", VA = "0x182AA4970", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA49E0", Offset = "0x2AA39E0", VA = "0x182AA49E0")]
	public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, out MFGNBHMPCKE DDGIJLNCGHO, out Entity MJJCFFJMMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4E60", Offset = "0x2AA3E60", VA = "0x182AA4E60")]
	public static bool LODKPFNGBNP(in Span<MFGNBHMPCKE> HKAIPIBCMIK, float FNIJMIADAMA, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4940", Offset = "0x2AA3940", VA = "0x182AA4940")]
	public static float GEHDIMGIPCG(float IFKFINIBHON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LBLNCLBMJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4F60", Offset = "0x2AA3F60", VA = "0x182AA4F60", Slot = "4")]
	private bool OELPHMLEIAP(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, out MFGNBHMPCKE DDGIJLNCGHO, out Entity MJJCFFJMMPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[IABFONFHPFO(typeof(DMLACEJEPHB), new string[] { })]
public sealed class KCNEEOJOHNG : DMLACEJEPHB, MIBCENMOHFA
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct IOLGCMFMFHO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> GMAMPIGCEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 DEOENACMICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 HIMPEGJGIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> MLECBNAKIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> FMFHFNEICIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DHCPBNMAOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> DKAAPKDEOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> FMEAIJLKJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<MFGNBHMPCKE> PLLLOLCKIMA;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly MFGNBHMPCKE GNGKONEIKLK;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x413DA20", Offset = "0x413CA20", VA = "0x18413DA20", Slot = "4")]
		public void Execute(int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x413E9E0", Offset = "0x413D9E0", VA = "0x18413E9E0")]
		private static float3 PLPKGOCPNJI(in float4x4 NJAPOBEJPBC, in float3 JPPIJLBNKPM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x413E3D0", Offset = "0x413D3D0", VA = "0x18413E3D0")]
		private static float3 FJPOPODFDAP(in float4x4 NJAPOBEJPBC, in float3 ABDBMKJBNIN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x413E590", Offset = "0x413D590", VA = "0x18413E590")]
		private static float3 INMKOFEFMAL(in float4x4 NJAPOBEJPBC, in float3 JPPIJLBNKPM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x413D800", Offset = "0x413C800", VA = "0x18413D800")]
		private static float3 EEJDMPEHEHL(in float4x4 NJAPOBEJPBC, in float3 ABDBMKJBNIN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x413E690", Offset = "0x413D690", VA = "0x18413E690")]
		private bool OLDMIFFHPAE(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, in NativeArray<Entity> COBLCAKGCPD, out float3 DDGIJLNCGHO, out float3 MFJFJLMHLGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x413DD00", Offset = "0x413CD00", VA = "0x18413DD00")]
		public static bool FCALJBGONIL(in float3 LKINPFLLJBO, in float3 PLKHGCCMBEC, in float3 FOFAPKNFCHO, in float3 LJIGMONOFNF, float ALBDIEBELLC, float BNJALKGHBFN, out float JELHNILOKLO, out float3 IMBJBGHLGBL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x30EAA50", Offset = "0x30E9A50", VA = "0x1830EAA50", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x30EAAD0", Offset = "0x30E9AD0", VA = "0x1830EAAD0")]
	public void LANBAAACLOF(in NativeArray<Entity> GMAMPIGCEAB, in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, in NativeArray<MFGNBHMPCKE> FHBDPKANIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public KCNEEOJOHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x30EAFB0", Offset = "0x30E9FB0", VA = "0x1830EAFB0", Slot = "4")]
	private void MLAMEFGEAME(in NativeArray<Entity> GMAMPIGCEAB, in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, in NativeArray<MFGNBHMPCKE> FHBDPKANIBN)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[OHGELDJCNJM(GGAOONGBEBH.Embodiment)]
	[IODJMJFIADF(PGBOFPGBDBH.OMRoom)]
	[IABFONFHPFO(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[JOODLPJEDOA]
		private EEPEPNPEOFG DOFDFFCHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[JOODLPJEDOA]
		private OEPDOHBHEIO PBJIKLFMGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[JOODLPJEDOA]
		private IEGMKAAGAAJ JOELDNPGFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private FOBNDAGEMLO AKPCEKFNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<IJDKBBDMEBI, Entity> DGNHEKHDDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager JGDEKKJFKAJ;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<IJDKBBDMEBI, Entity> NIHGOFBCNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x1011190", Offset = "0x1010190", VA = "0x181011190")]
			get
			{
				return default(NativeHashMap<IJDKBBDMEBI, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint ENABEPLFKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB8610", Offset = "0x2AB7610", VA = "0x182AB8610")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool KCIOFPNPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8DFDA0", Offset = "0x8DEDA0", VA = "0x1808DFDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD27250", Offset = "0xD26250", VA = "0x180D27250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8400", Offset = "0x2AB7400", VA = "0x182AB8400", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8310", Offset = "0x2AB7310", VA = "0x182AB8310", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8380", Offset = "0x2AB7380", VA = "0x182AB8380")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8640", Offset = "0x2AB7640", VA = "0x182AB8640")]
		public void LPNMIKCIFCB(IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8800", Offset = "0x2AB7800", VA = "0x182AB8800")]
		private GPEJGMHBDPO ONMDEPNPKNN(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8230", Offset = "0x2AB7230", VA = "0x182AB8230")]
		public GPEJGMHBDPO BPFLLEIAFPB(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8140", Offset = "0x2AB7140", VA = "0x182AB8140")]
		public IJDKBBDMEBI BAAKGEKGEDO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(IJDKBBDMEBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8520", Offset = "0x2AB7520", VA = "0x182AB8520")]
		public void KBFOFICGPKI(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2AB81D0", Offset = "0x2AB71D0", VA = "0x182AB81D0")]
		public void BLABKBJHPNC(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB85B0", Offset = "0x2AB75B0", VA = "0x182AB85B0")]
		public void KIOLCCBJOBI(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8830", Offset = "0x2AB7830", VA = "0x182AB8830")]
		public void PFFBIGAMFCF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
	[IABFONFHPFO(typeof(PropertyEventCallbacksService), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Callbacks)]
	public class PropertyEventCallbacksService : MIBCENMOHFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct LEJIJCIELFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public AFAANOBHJND PEPHBHFBJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type HAOFNDAEGFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int MKMGHJFMNMB;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct GCNEANLILED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public LEJIJCIELFE[] ICBILMELIDM;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void AFAANOBHJND(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<BPHAMHGLCNC, AFAANOBHJND> LPOGFILLMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, GCNEANLILED> FECMBOBBINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private PABMDGDAPHJ ICBILMELIDM;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action PHPLJKEFDND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5A20", Offset = "0x2AC4A20", VA = "0x182AC5A20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5700", Offset = "0x2AC4700", VA = "0x182AC5700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action LOCFIDHMJBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2AC5490", Offset = "0x2AC4490", VA = "0x182AC5490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2AC6000", Offset = "0x2AC5000", VA = "0x182AC6000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5530", Offset = "0x2AC4530", VA = "0x182AC5530", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2AC51A0", Offset = "0x2AC41A0", VA = "0x182AC51A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5230", Offset = "0x2AC4230", VA = "0x182AC5230")]
		public void GBHABPPKBJN(BPHAMHGLCNC AOKMGDODDPA, AFAANOBHJND PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4E20", Offset = "0x2AC3E20", VA = "0x182AC4E20")]
		public void CHMCBDDDGAK(BPHAMHGLCNC AOKMGDODDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4F10", Offset = "0x2AC3F10", VA = "0x182AC4F10")]
		internal void DBOJCEDCOGH(ADIGHOEHBBA KFCHBPFAEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5AC0", Offset = "0x2AC4AC0", VA = "0x182AC5AC0")]
		private void PIKBKPKNCAK(ADIGHOEHBBA KFCHBPFAEMJ, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2AC57A0", Offset = "0x2AC47A0", VA = "0x182AC57A0")]
		private void PGNDJLFMPAF(GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND, LEJIJCIELFE HCHKLEAOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5580", Offset = "0x2AC4580", VA = "0x182AC5580")]
		private GCNEANLILED MKKOFEHHBLA(GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND)
		{
			return default(GCNEANLILED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2AC53A0", Offset = "0x2AC43A0", VA = "0x182AC53A0")]
		private LEJIJCIELFE IFIKLHKHPJC(GCNEANLILED JJPMEEGFFGM, GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND)
		{
			return default(LEJIJCIELFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2AC60F0", Offset = "0x2AC50F0", VA = "0x182AC60F0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[IABFONFHPFO(typeof(DMNNGJLJJJC), new string[] { })]
public class NLODNNHKCBL : MIBCENMOHFA, PFFHIJLFPMD, DMNNGJLJJJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class GJCIHOKNLDJ : IEnumerable<GPEJGMHBDPO>, IEnumerable, IEnumerator<GPEJGMHBDPO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private GPEJGMHBDPO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public NLODNNHKCBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private GPEJGMHBDPO splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public GPEJGMHBDPO <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private GPEJGMHBDPO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x413C780", Offset = "0x413B780", VA = "0x18413C780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x986E80", Offset = "0x985E80", VA = "0x180986E80")]
		[DebuggerHidden]
		public GJCIHOKNLDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x413C5D0", Offset = "0x413B5D0", VA = "0x18413C5D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x413C740", Offset = "0x413B740", VA = "0x18413C740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x413C690", Offset = "0x413B690", VA = "0x18413C690", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GPEJGMHBDPO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x413C690", Offset = "0x413B690", VA = "0x18413C690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private FOBNDAGEMLO AKPCEKFNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private DHKKOGPGPKB DNPDIAMLFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService APEJINPFNBH;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD540", Offset = "0x2AAC540", VA = "0x182AAD540")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JLCGKPAGLMB JADDHOMJIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD190", Offset = "0x2AAC190", VA = "0x182AAD190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD590", Offset = "0x2AAC590", VA = "0x182AAD590", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD380", Offset = "0x2AAC380", VA = "0x182AAD380", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD240", Offset = "0x2AAC240", VA = "0x182AAD240", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2AADAE0", Offset = "0x2AACAE0", VA = "0x182AADAE0")]
	private void NNMHBFEKPHF(Entity PKFLKNEEDLH, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD1E0", Offset = "0x2AAC1E0", VA = "0x182AAD1E0", Slot = "14")]
	public GPEJGMHBDPO DPPJEBGFDDC()
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2AACFE0", Offset = "0x2AABFE0", VA = "0x182AACFE0", Slot = "10")]
	public void CCGJMNHJJAC(GPEJGMHBDPO GBPGPLEPLBP, ALCCBEKLCMG DGCNIAGLPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2AADD60", Offset = "0x2AACD60", VA = "0x182AADD60", Slot = "9")]
	public ALCCBEKLCMG OLDBJJKNILI(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(ALCCBEKLCMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2AADE50", Offset = "0x2AACE50", VA = "0x182AADE50", Slot = "11")]
	public GPEJGMHBDPO OOKIKAGIJNP(GPEJGMHBDPO JMFCHNOMKAM, [Optional] Vector3? MIFJBHLKJIN, [Optional] Quaternion? OLBDAPNGDPL, [Optional] Vector3? NHAEEIBBDJN)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2AACFA0", Offset = "0x2AABFA0", VA = "0x182AACFA0", Slot = "15")]
	public GPEJGMHBDPO BCADGGEEHNI(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF, [Optional] Vector3? MIFJBHLKJIN, [Optional] Quaternion? OLBDAPNGDPL, [Optional] Vector3? NHAEEIBBDJN)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD7C0", Offset = "0x2AAC7C0", VA = "0x182AAD7C0", Slot = "7")]
	public GPEJGMHBDPO LBOODFBPPFK(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD0D0", Offset = "0x2AAC0D0", VA = "0x182AAD0D0", Slot = "16")]
	public void CNCOEPMNCPB(GPEJGMHBDPO CPIJGODGGEN, GPEJGMHBDPO ODIEOJHEKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD620", Offset = "0x2AAC620", VA = "0x182AAD620", Slot = "12")]
	public void KBJMLCHBBAI(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD940", Offset = "0x2AAC940", VA = "0x182AAD940", Slot = "17")]
	public void NMLEFFGGLOH(GPEJGMHBDPO CPIJGODGGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2AACF00", Offset = "0x2AABF00", VA = "0x182AACF00", Slot = "8")]
	public int ACEEDCJJPCG(GPEJGMHBDPO CPIJGODGGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD8B0", Offset = "0x2AAC8B0", VA = "0x182AAD8B0", Slot = "6")]
	[IteratorStateMachine(typeof(GJCIHOKNLDJ))]
	public IEnumerable<GPEJGMHBDPO> LGEIHKMDLLG(GPEJGMHBDPO CPIJGODGGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD2F0", Offset = "0x2AAC2F0", VA = "0x182AAD2F0")]
	private bool EABIACNMDHE(GPEJGMHBDPO CPIJGODGGEN, out NativeArray<Entity> DJHPOGLHKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD480", Offset = "0x2AAC480", VA = "0x182AAD480")]
	private NativeArray<Entity> GIGDNIJJOJM(GPEJGMHBDPO CPIJGODGGEN)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public NLODNNHKCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[IODJMJFIADF(PGBOFPGBDBH.LoadInstance)]
[IABFONFHPFO(typeof(FKFAILBCEFF), new string[] { })]
internal sealed class FKFAILBCEFF : MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private EEPEPNPEOFG BKFHGKOCNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase CIBDMNLICDF;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private NPAPPEKNDDD BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x30DAAF0", Offset = "0x30D9AF0", VA = "0x1830DAAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x30DAB40", Offset = "0x30D9B40", VA = "0x1830DAB40", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x30DABC0", Offset = "0x30D9BC0", VA = "0x1830DABC0")]
	public void LCDMKGLCGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x30DA820", Offset = "0x30D9820", VA = "0x1830DA820")]
	public void DJNGEIEFBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FKFAILBCEFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct HEEHFNGKCPD : IEquatable<HEEHFNGKCPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int DFMDKBNGDLJ;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type DBLKLNHCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x30E1340", Offset = "0x30E0340", VA = "0x1830E1340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x30E1450", Offset = "0x30E0450", VA = "0x1830E1450")]
	public HEEHFNGKCPD(Type HAOFNDAEGFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x30E1310", Offset = "0x30E0310", VA = "0x1830E1310")]
	public static HEEHFNGKCPD HEFILGHKDEM(Type HAOFNDAEGFJ)
	{
		return default(HEEHFNGKCPD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x30E12F0", Offset = "0x30E02F0", VA = "0x1830E12F0")]
	public static Type HEFILGHKDEM(HEEHFNGKCPD BDCLOJHOMDK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x1334BD0", Offset = "0x1333BD0", VA = "0x181334BD0")]
	public static bool IIPILNNMHKL(HEEHFNGKCPD BECDKHGLGNB, HEEHFNGKCPD ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x1334BD0", Offset = "0x1333BD0", VA = "0x181334BD0")]
	public static bool NCOOAABHIPD(HEEHFNGKCPD BECDKHGLGNB, HEEHFNGKCPD ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x886520", Offset = "0x885520", VA = "0x180886520", Slot = "4")]
	public bool Equals(HEEHFNGKCPD JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x30E1270", Offset = "0x30E0270", VA = "0x1830E1270", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x30E1420", Offset = "0x30E0420", VA = "0x1830E1420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class JLNADKCMJCE
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> NOMJGCKNGGL;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> JGOOKECPILP;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x30E91C0", Offset = "0x30E81C0", VA = "0x1830E91C0")]
	static JLNADKCMJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x21C8E60", Offset = "0x21C7E60", VA = "0x1821C8E60")]
	public static bool GBJBCHALJOG<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x30E8F20", Offset = "0x30E7F20", VA = "0x1830E8F20")]
	public static bool GBJBCHALJOG(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x30E8DB0", Offset = "0x30E7DB0", VA = "0x1830E8DB0")]
	private static bool GBJBCHALJOG(Type HAOFNDAEGFJ, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x21C8EF0", Offset = "0x21C7EF0", VA = "0x1821C8EF0")]
	public static int KKIINDDINID<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x30E8F90", Offset = "0x30E7F90", VA = "0x1830E8F90")]
	public static int KKIINDDINID(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x21C8F80", Offset = "0x21C7F80", VA = "0x1821C8F80")]
	public static bool LEDONIKBHEA<T>(out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x30E9000", Offset = "0x30E8000", VA = "0x1830E9000")]
	public static bool LEDONIKBHEA(Type HAOFNDAEGFJ, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x30E8D10", Offset = "0x30E7D10", VA = "0x1830E8D10")]
	public static Type BOEAFIEBIHC(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x30E90A0", Offset = "0x30E80A0", VA = "0x1830E90A0")]
	public static bool LEDONIKBHEA(int EGBCAPEEJBF, out Type HAOFNDAEGFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct MNKKKLOFPDB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int GDDNEEFIBDF;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF00", Offset = "0x7FEF00", VA = "0x1807FFF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x2324CC0", Offset = "0x2323CC0", VA = "0x182324CC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> DICJPCHOIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x358D190", Offset = "0x358C190", VA = "0x18358D190")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x9045B0", Offset = "0x9035B0", VA = "0x1809045B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x358D230", Offset = "0x358C230", VA = "0x18358D230")]
	public MNKKKLOFPDB(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x358D0E0", Offset = "0x358C0E0", VA = "0x18358D0E0")]
	public int LGFPODHHMBH(T KPPLMEOMNGF, int GODLNPABGMH, int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x358D020", Offset = "0x358C020", VA = "0x18358D020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct EEGOPNFAMDL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::MNKKKLOFPDB<T> FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int GDDNEEFIBDF;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B8E0", Offset = "0x2E0A8E0", VA = "0x182E0B8E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C7D0", Offset = "0x2E0B7D0", VA = "0x182E0C7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BD40", Offset = "0x2E0AD40", VA = "0x182E0BD40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C540", Offset = "0x2E0B540", VA = "0x182E0C540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C650", Offset = "0x2E0B650", VA = "0x182E0C650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> DICJPCHOIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C820", Offset = "0x2E0B820", VA = "0x182E0C820")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D0B0", Offset = "0x2E0C0B0", VA = "0x182E0D0B0")]
	public EEGOPNFAMDL(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CB70", Offset = "0x2E0BB70", VA = "0x182E0CB70")]
	public T PGFBGCNBPKF(int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C230", Offset = "0x2E0B230", VA = "0x182E0C230")]
	public void HMOKBDLKNIA(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B710", Offset = "0x2E0A710", VA = "0x182E0B710")]
	public void ANIKBIHIFCK(Span<T> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BED0", Offset = "0x2E0AED0", VA = "0x182E0BED0")]
	public void GBJBCHALJOG(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C0B0", Offset = "0x2E0B0B0", VA = "0x182E0C0B0")]
	private void HLAGOAGKLGA(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B970", Offset = "0x2E0A970", VA = "0x182E0B970")]
	public void CMEPDJJCKOF(Span<T> KDCOOOFOCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BFE0", Offset = "0x2E0AFE0", VA = "0x182E0BFE0")]
	public void GCCKHMHCNIK(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CBC0", Offset = "0x2E0BBC0", VA = "0x182E0CBC0")]
	public void PINJNKFLMFA(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CDE0", Offset = "0x2E0BDE0", VA = "0x182E0CDE0")]
	public void PJBBGDBFNGB(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C2A0", Offset = "0x2E0B2A0", VA = "0x182E0C2A0")]
	public void JIKJIAINCEG(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C590", Offset = "0x2E0B590", VA = "0x182E0C590")]
	public void MMGHCEPKACF(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CF80", Offset = "0x2E0BF80", VA = "0x182E0CF80")]
	public void POAELJEPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C4B0", Offset = "0x2E0B4B0", VA = "0x182E0C4B0")]
	public int LGFPODHHMBH(T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B880", Offset = "0x2E0A880", VA = "0x182E0B880")]
	public bool BNDEAHDJONI(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BCF0", Offset = "0x2E0ACF0", VA = "0x182E0BCF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D040", Offset = "0x2E0C040", VA = "0x182E0D040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C040", Offset = "0x2E0B040", VA = "0x182E0C040")]
	public static Span<T> HEFILGHKDEM(global::EEGOPNFAMDL<T> EHJGMBFBLBN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BBB0", Offset = "0x2E0ABB0", VA = "0x182E0BBB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DOFNCEMJICN(int KPPLMEOMNGF, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GBAFNLLNGNI(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BD70", Offset = "0x2E0AD70", VA = "0x182E0BD70")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GBAFNLLNGNI(int GDDNEEFIBDF, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C690", Offset = "0x2E0B690", VA = "0x182E0C690")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NNELNNKODBI(int KPPLMEOMNGF, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C970", Offset = "0x2E0B970", VA = "0x182E0C970")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void PDCNOCBDJAC(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CE40", Offset = "0x2E0BE40", VA = "0x182E0CE40")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void PKBJMAAEEIH(int KPPLMEOMNGF, int GDDNEEFIBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct DLGLKFHNPHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int CEKNALKIGAP = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> GMAMPIGCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray GAICKEELBKP;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2D28DC0", Offset = "0x2D27DC0", VA = "0x182D28DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> LEJDCOPNFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC478C0", Offset = "0xC468C0", VA = "0x180C478C0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray DOLJEJLKCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2D28BF0", Offset = "0x2D27BF0", VA = "0x182D28BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2D28DD0", Offset = "0x2D27DD0", VA = "0x182D28DD0")]
	public DLGLKFHNPHN(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2D28D70", Offset = "0x2D27D70", VA = "0x182D28D70")]
	public Entity GHNMBAICEAM(int EGBCAPEEJBF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2D28C10", Offset = "0x2D27C10", VA = "0x182D28C10")]
	public Transform FJEJMGNKJIP(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2D28B20", Offset = "0x2D27B20", VA = "0x182D28B20")]
	public void BIOKPKCMOHA(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2D28C20", Offset = "0x2D27C20", VA = "0x182D28C20")]
	public int GBJBCHALJOG(Transform PKIKNDCFAFJ, Entity PJEENOLDJIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2D28CF0", Offset = "0x2D27CF0", VA = "0x182D28CF0")]
	public int GCCKHMHCNIK(int EGBCAPEEJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2D28B70", Offset = "0x2D27B70", VA = "0x182D28B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2D28AE0", Offset = "0x2D27AE0", VA = "0x182D28AE0")]
	private void AEOKHDJHECJ(int OIKHEKALAGO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class ILMNJLCHNNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<HEEHFNGKCPD, int2> JIOHCMLAHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> BFNDINBALAB;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x30E6C80", Offset = "0x30E5C80", VA = "0x1830E6C80")]
	public ILMNJLCHNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x30E6820", Offset = "0x30E5820", VA = "0x1830E6820")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void JPNFGACMGOG<T>(T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T BOEAFIEBIHC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x30E69A0", Offset = "0x30E59A0", VA = "0x1830E69A0")]
	public void JPNFGACMGOG(Type HAOFNDAEGFJ, MPOLKMCKMLM KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x30E6540", Offset = "0x30E5540", VA = "0x1830E6540")]
	public MPOLKMCKMLM BOEAFIEBIHC(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x30E6BE0", Offset = "0x30E5BE0", VA = "0x1830E6BE0")]
	private NativeArray<byte> KPCBHHFBPJO(int2 OGCMIPINAPI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x30E6780", Offset = "0x30E5780", VA = "0x1830E6780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x30E6880", Offset = "0x30E5880", VA = "0x1830E6880", Slot = "1")]
	~ILMNJLCHNNM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct JKLJEHDDJCO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::JKLJEHDDJCO<T> HEFILGHKDEM(T KPPLMEOMNGF)
	{
		return default(global::JKLJEHDDJCO<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T HEFILGHKDEM(global::JKLJEHDDJCO<T> PNIJKHBHNEL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class LJFILAKBOAP
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly ILMNJLCHNNM ADFFCDAHABD;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6E30", Offset = "0x2AA5E30", VA = "0x182AA6E30")]
	internal static void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void JPNFGACMGOG<T>(T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6EA0", Offset = "0x2AA5EA0", VA = "0x182AA6EA0")]
	public static void JPNFGACMGOG(Type HAOFNDAEGFJ, MPOLKMCKMLM KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T BOEAFIEBIHC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6D90", Offset = "0x2AA5D90", VA = "0x182AA6D90")]
	public static MPOLKMCKMLM BOEAFIEBIHC(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class BOIJEFDNHLJ : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly BOIJEFDNHLJ LMPNKNOCBFL;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2D162B0", Offset = "0x2D152B0", VA = "0x182D162B0", Slot = "4")]
	public bool Equals(LinkedEntityGroup PMEDGJGANML, LinkedEntityGroup NIPKEFBPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2D162D0", Offset = "0x2D152D0", VA = "0x182D162D0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup AELIHOPICED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public BOIJEFDNHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class FACGGEEGLAK
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OEAMAPCANPO(in Vector3 MIFJBHLKJIN, in Quaternion OLBDAPNGDPL, in Vector3 NHAEEIBBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OAFBDJOEHMB(in Vector3 NGBOFGADIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BEGFIJDNAIK(in Quaternion OLBDAPNGDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JNDHLGDBOOI(in Vector3 FLILAGFCIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NPIGCOCOGAK(in Vector3 FLILAGFCIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GAPIFPGGAGM(in float AEIEKJBHCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x30D85F0", Offset = "0x30D75F0", VA = "0x1830D85F0")]
	[Conditional("DEBUG_BUILD")]
	public static void FDBHMNJEDFN(in float3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in float KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x30D86D0", Offset = "0x30D76D0", VA = "0x1830D86D0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in Vector3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x30D86A0", Offset = "0x30D76A0", VA = "0x1830D86A0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in Quaternion KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x30D8570", Offset = "0x30D7570", VA = "0x1830D8570")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in float KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x30D8580", Offset = "0x30D7580", VA = "0x1830D8580")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in Vector3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x30D85C0", Offset = "0x30D75C0", VA = "0x1830D85C0")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in Quaternion KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public FACGGEEGLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct DFLCMAHAHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity PJEENOLDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity KJNCJMANDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity KHLHKJKADHO;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D27E20", Offset = "0x2D26E20", VA = "0x182D27E20")]
	public DFLCMAHAHIM(Entity PJEENOLDJIO, Entity KJNCJMANDLF, Entity KHLHKJKADHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D27DC0", Offset = "0x2D26DC0", VA = "0x182D27DC0")]
	public static DFLCMAHAHIM HEFILGHKDEM((Entity entity, Entity oldParent, Entity newParent) MHIEFDEAPAM)
	{
		return default(DFLCMAHAHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2D27E00", Offset = "0x2D26E00", VA = "0x182D27E00")]
	public void LEPJGOMAPEJ(out Entity PJEENOLDJIO, out Entity KJNCJMANDLF, out Entity KHLHKJKADHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct EJDOAJBNLAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity PJEENOLDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity OKMBLMILFGG;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xE9C6D0", Offset = "0xE9B6D0", VA = "0x180E9C6D0")]
	public EJDOAJBNLAC(Entity PJEENOLDJIO, Entity OKMBLMILFGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C2A0", Offset = "0x2D2B2A0", VA = "0x182D2C2A0")]
	public static EJDOAJBNLAC HEFILGHKDEM((Entity entity, Entity parent) MHIEFDEAPAM)
	{
		return default(EJDOAJBNLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C2D0", Offset = "0x2D2B2D0", VA = "0x182D2C2D0")]
	public void LEPJGOMAPEJ(out Entity PJEENOLDJIO, out Entity OKMBLMILFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct AODOKPCJNJI<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle BDCLOJHOMDK;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool NPMHNEIPJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x30E09A0", Offset = "0x30DF9A0", VA = "0x1830E09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x3E25610", Offset = "0x3E24610", VA = "0x183E25610")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x3E25550", Offset = "0x3E24550", VA = "0x183E25550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3E256E0", Offset = "0x3E246E0", VA = "0x183E256E0")]
	public AODOKPCJNJI(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3E256B0", Offset = "0x3E246B0", VA = "0x183E256B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum EIHEHJOIBDF
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct PGHABJEAHKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public EIHEHJOIBDF JFCJMBGMPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int JMOLLNMGGHK;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x700050", Offset = "0x6FF050", VA = "0x180700050")]
	public PGHABJEAHKP(EIHEHJOIBDF JFCJMBGMPGA, int JMOLLNMGGHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD570", Offset = "0x2ABC570", VA = "0x182ABD570")]
	public static PGHABJEAHKP HEFILGHKDEM((EIHEHJOIBDF eventType, int eventIndex) PMEDGJGANML)
	{
		return default(PGHABJEAHKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD590", Offset = "0x2ABC590", VA = "0x182ABD590")]
	public void LEPJGOMAPEJ(out EIHEHJOIBDF JFCJMBGMPGA, out int JMOLLNMGGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[IABFONFHPFO(typeof(IAIIPPHGJJF), new string[] { })]
public sealed class IGIGJEFCDAB : IAIIPPHGJJF, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private IIEBHPDOOAI CDMLFNGLMPO;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x30E5F40", Offset = "0x30E4F40", VA = "0x1830E5F40", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x30E5F90", Offset = "0x30E4F90", VA = "0x1830E5F90")]
	public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public IGIGJEFCDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x30E5F90", Offset = "0x30E4F90", VA = "0x1830E5F90", Slot = "4")]
	private bool JNMNEDBGHHP(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[BEOLFPGNHND]
[UpdateInGroup(typeof(GPNGEBCHKBI))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class EGDMFPJGNMG : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2D2AB30", Offset = "0x2D29B30", VA = "0x182D2AB30", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public EGDMFPJGNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[BEOLFPGNHND]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
[UpdateInGroup(typeof(KNAOFDPHFED))]
public sealed class IEPFALJOLEH : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x30E5E60", Offset = "0x30E4E60", VA = "0x1830E5E60", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public IEPFALJOLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[BEOLFPGNHND]
[UpdateInGroup(typeof(CIJEBLFAOAC))]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
internal sealed class DKPIFALCPCA : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x2D27E30", Offset = "0x2D26E30", VA = "0x182D27E30", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public DKPIFALCPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class NNAEKBCEOJJ : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public NNAEKBCEOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[BEOLFPGNHND]
[ExecuteAlways]
[OHKEEAJFOEC(PGBOFPGBDBH.LoadInstance)]
[UpdateInGroup(typeof(NMBGKHKPLBF))]
internal sealed class MGKDLMNJGLC : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9620", Offset = "0x2AA8620", VA = "0x182AA9620", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9700", Offset = "0x2AA8700", VA = "0x182AA9700")]
	public MGKDLMNJGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[BLPHJEIJPDJ(typeof(AuthoredLocalPoseData))]
public sealed class AMACAACHNJD : IJOAAFPCIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2D11D00", Offset = "0x2D10D00", VA = "0x182D11D00", Slot = "8")]
	protected override bool LHGDJEIAACJ(ReadOnlySpan<AuthoredLocalPoseData> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2D11C40", Offset = "0x2D10C40", VA = "0x182D11C40", Slot = "9")]
	protected override bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<AuthoredLocalPoseData> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2D11D80", Offset = "0x2D10D80", VA = "0x182D11D80")]
	public AMACAACHNJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[BLPHJEIJPDJ(typeof(LocalPoseData))]
public sealed class ONMBDEJKNAF : MFBAIOPOAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0CC0", Offset = "0x2AAFCC0", VA = "0x182AB0CC0", Slot = "8")]
	protected override bool LHGDJEIAACJ(ReadOnlySpan<LocalPoseData> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0C00", Offset = "0x2AAFC00", VA = "0x182AB0C00", Slot = "9")]
	protected override bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<LocalPoseData> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0D40", Offset = "0x2AAFD40", VA = "0x182AB0D40")]
	public ONMBDEJKNAF()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : PLIGCBHMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2CA14C0", Offset = "0x2CA04C0", VA = "0x182CA14C0", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2CA09F0", Offset = "0x2C9F9F0", VA = "0x182CA09F0", Slot = "4")]
		public sealed override void DOIEPELEGLE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x30E1510", Offset = "0x30E0510", VA = "0x1830E1510")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x30E1620", Offset = "0x30E0620", VA = "0x1830E1620")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
